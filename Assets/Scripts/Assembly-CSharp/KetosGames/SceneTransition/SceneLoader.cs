using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace KetosGames.SceneTransition
{
	public class SceneLoader : MonoBehaviour
	{
		private static SceneLoader SceneLoaderInstance;

		public GameObject LoadingScreen;

		public Image FadeImage;

		public Material FadeMaterial;

		[Tooltip("Use with VR.")]
		public bool VRMode;

		[Tooltip("When checked, use the Loading scene as the Loading screen (instead of the Loading UI).")]
		public bool UseSceneForLoadingScreen = true;

		[Tooltip("The name of the Loading scene to load.")]
		public string LoadingSceneName = "Loading";

		[Tooltip("When checked, fade in the loading screen.")]
		public bool FadeInLoadingScreen = true;

		[Tooltip("When checked, fade out the loading screen.")]
		public bool FadeOutLoadingScreen = true;

		[Tooltip("The number of seconds to animate the fade.")]
		public float FadeSeconds = 1f;

		[Tooltip("The number of seconds to show the loading screen after fade in. Set it to 0 to go to the new scene as soon as it's ready.")]
		public float MinimumLoadingScreenSeconds = 1f;

		[Tooltip("The color to use in the fade animation.")]
		public Color FadeColor = Color.black;

		[Tooltip("Whether to ignore timeScale. This is useful if you pause the sceen by setting the timescale to 0.")]
		public bool IgnoreTimeScale;

		[HideInInspector]
		public float Progress;

		private AsyncOperation SceneLoadingOperation;

		private bool FadingIn = true;

		private bool FadingOut;

		private float FadeTime;

		private Color FadeClearColor;

		private bool Loading;

		private bool VRInitialized;

		public static SceneLoader Instance
		{
			get
			{
				if (SceneLoaderInstance == null)
				{
					SceneLoader sceneLoader = (SceneLoader)UnityEngine.Object.FindObjectOfType(typeof(SceneLoader));
					if (sceneLoader != null)
					{
						SceneLoaderInstance = sceneLoader;
					}
					else
					{
						SceneLoaderInstance = UnityEngine.Object.Instantiate(Resources.Load<GameObject>("KetosGames/SceneTransition/Prefabs/SceneLoader")).GetComponent<SceneLoader>();
					}
				}
				return SceneLoaderInstance;
			}
		}

		private float deltaTime
		{
			get
			{
				if (!IgnoreTimeScale)
				{
					return Time.deltaTime;
				}
				return Time.unscaledDeltaTime;
			}
		}

		private float time
		{
			get
			{
				if (!IgnoreTimeScale)
				{
					return Time.time;
				}
				return Time.unscaledTime;
			}
		}

		public static void LoadScene(string name)
		{
			Instance.Load(name);
		}

		public static void LoadScene(int buildIndex)
		{
			Instance.Load(buildIndex);
		}

		public void Awake()
		{
			UnityEngine.Object.DontDestroyOnLoad(base.gameObject);
			if (SceneLoaderInstance != null && SceneLoaderInstance != this)
			{
				UnityEngine.Object.Destroy(SceneLoaderInstance.gameObject);
				SceneLoaderInstance = this;
			}
			if (VRMode && FadeMaterial == null)
			{
				throw new Exception("Fade Material is required for VR Support!");
			}
			if (!VRMode && FadeImage == null)
			{
				throw new Exception("Fade Image is required!");
			}
		}

		public void Start()
		{
			SetFadersEnabled(value: true);
			if (LoadingScreen != null)
			{
				LoadingScreen.SetActive(value: false);
			}
			if (!Loading)
			{
				BeginFadeIn();
			}
		}

		private void Update()
		{
			if (FadingIn)
			{
				UpdateFadeIn();
			}
			else if (FadingOut)
			{
				UpdateFadeOut();
			}
		}

		public void BeginFadeOut()
		{
			UpdateCamera();
			if (FadingIn && FadeTime > 0f)
			{
				FadeTime = 1f / FadeTime;
			}
			else
			{
				FadeTime = 0f;
				setFadeColor(Color.clear);
			}
			SetFadersEnabled(value: true);
			FadingIn = false;
			FadingOut = true;
			FadeClearColor = FadeColor;
			FadeClearColor.a = 0f;
		}

		public void BeginFadeIn()
		{
			UpdateCamera();
			if (FadingOut && FadeTime > 0f)
			{
				FadeTime = 1f / FadeTime;
			}
			else
			{
				FadeTime = 0f;
				setFadeColor(FadeColor);
			}
			SetFadersEnabled(value: true);
			FadingIn = true;
			FadingOut = false;
			FadeClearColor = FadeColor;
			FadeClearColor.a = 0f;
		}

		private void EndFadeIn()
		{
			setFadeColor(Color.clear);
			SetFadersEnabled(value: false);
			FadingIn = false;
		}

		private void EndFadeOut()
		{
			setFadeColor(FadeColor);
			FadingOut = false;
		}

		private void UpdateFadeIn()
		{
			FadeTime += deltaTime / FadeSeconds;
			setFadeColor(Color.Lerp(FadeColor, FadeClearColor, FadeTime));
			if (FadeTime > 1f)
			{
				EndFadeIn();
			}
		}

		private void UpdateFadeOut()
		{
			FadeTime += deltaTime / FadeSeconds;
			setFadeColor(Color.Lerp(FadeClearColor, FadeColor, FadeTime));
			if (FadeTime > 1f)
			{
				EndFadeOut();
			}
		}

		public void Load(string name)
		{
			if (!Loading)
			{
				Scene scene = new Scene
				{
					SceneName = name
				};
				StartCoroutine(InnerLoad(scene));
			}
		}

		public void Load(int buildIndex)
		{
			if (!Loading)
			{
				Scene scene = new Scene
				{
					BuildIndex = buildIndex
				};
				StartCoroutine(InnerLoad(scene));
			}
		}

		private IEnumerator InnerLoad(Scene scene)
		{
			Loading = true;
			Progress = 0f;
			BeginFadeOut();
			while (FadingOut)
			{
				yield return 0;
			}
			if (UseSceneForLoadingScreen)
			{
				SceneManager.LoadScene(LoadingSceneName);
			}
			else if (!VRMode && LoadingScreen != null)
			{
				LoadingScreen.SetActive(value: true);
			}
			if (UseSceneForLoadingScreen || !VRMode)
			{
				if (FadeInLoadingScreen)
				{
					BeginFadeIn();
					while (FadingIn)
					{
						yield return 0;
					}
				}
				else
				{
					EndFadeIn();
				}
			}
			float startTime = time;
			if (!string.IsNullOrEmpty(scene.SceneName))
			{
				SceneLoadingOperation = SceneManager.LoadSceneAsync(scene.SceneName);
			}
			else
			{
				SceneLoadingOperation = SceneManager.LoadSceneAsync(scene.BuildIndex);
			}
			SceneLoadingOperation.allowSceneActivation = false;
			while (SceneLoadingOperation.progress < 0.9f)
			{
				Progress = SceneLoadingOperation.progress;
				yield return 0;
			}
			Progress = 1f;
			if (UseSceneForLoadingScreen || !VRMode)
			{
				while (time - startTime < MinimumLoadingScreenSeconds)
				{
					yield return 0;
				}
			}
			SetFadersEnabled(value: true);
			if (UseSceneForLoadingScreen || !VRMode)
			{
				if (FadeOutLoadingScreen)
				{
					BeginFadeOut();
					while (FadingOut)
					{
						yield return 0;
					}
				}
				else
				{
					EndFadeOut();
				}
			}
			SceneLoadingOperation.allowSceneActivation = true;
			while (!SceneLoadingOperation.isDone)
			{
				yield return 0;
			}
			if (LoadingScreen != null)
			{
				LoadingScreen.SetActive(value: false);
			}
			BeginFadeIn();
			Loading = false;
		}

		private void UpdateCamera()
		{
			if (!VRMode || !(FadeMaterial != null))
			{
				return;
			}
			Camera[] allCameras = Camera.allCameras;
			foreach (Camera camera in allCameras)
			{
				if (camera.gameObject.GetComponent<ScreenFadeControl>() == null)
				{
					camera.gameObject.AddComponent<ScreenFadeControl>().fadeMaterial = FadeMaterial;
				}
			}
			if (!VRInitialized)
			{
				VRInitialized = true;
			}
		}

		private void SetFadersEnabled(bool value)
		{
			if (VRMode)
			{
				Camera[] allCameras = Camera.allCameras;
				foreach (Camera camera in allCameras)
				{
					if (camera.gameObject.GetComponent<ScreenFadeControl>() != null)
					{
						camera.gameObject.GetComponent<ScreenFadeControl>().enabled = value;
					}
				}
			}
			else
			{
				FadeImage.gameObject.SetActive(value);
			}
		}

		private void setFadeColor(Color value)
		{
			if (VRMode)
			{
				FadeMaterial.color = value;
			}
			else
			{
				FadeImage.color = value;
			}
		}

		private void OnDestroy()
		{
		}
	}
}
