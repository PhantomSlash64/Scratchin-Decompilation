using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

namespace E7.Introloop
{
	public class IntroloopPlayer : MonoBehaviour
	{
		private IntroloopTrack[] twoTracks = new IntroloopTrack[2];

		private float[] towardsVolume = new float[2];

		private bool[] willStop = new bool[2];

		private bool[] willPause = new bool[2];

		private float[] fadeLength = new float[2];

		private IntroloopAudio previousPlay;

		private AudioSource templateSource;

		private int currentTrack = 1;

		private const float popRemovalFadeTime = 0.055f;

		[SerializeField]
		private IntroloopSettings introloopSettings;

		private static IntroloopPlayer instance;

		private bool importantChildrenCreated;

		private float timeBeforePause;

		public AudioSource TemplateSource
		{
			get
			{
				if (templateSource == null)
				{
					templateSource = GetComponent<AudioSource>();
					if (templateSource == null)
					{
						templateSource = base.gameObject.AddComponent<AudioSource>();
						SetupDefaultAudioSourceForIntroloop(templateSource);
					}
				}
				return templateSource;
			}
		}

		public IEnumerable<AudioSource> InternalAudioSources
		{
			get
			{
				if (twoTracks == null)
				{
					throw new IntroloopException("Child game objects of Introloop player is not yet initialized. Please avoid accessing internal AudioSource on Awake.");
				}
				foreach (AudioSource allAudioSource in twoTracks[0].AllAudioSources)
				{
					yield return allAudioSource;
				}
				foreach (AudioSource allAudioSource2 in twoTracks[1].AllAudioSources)
				{
					yield return allAudioSource2;
				}
			}
		}

		public static IntroloopPlayer Instance
		{
			get
			{
				if (instance == null)
				{
					instance = InstantiatePlayer<IntroloopPlayer>();
					instance.name = "Singleton-" + instance.name;
				}
				return instance;
			}
		}

		public static T InstantiatePlayer<T>() where T : IntroloopPlayer
		{
			string text = typeof(T).Name;
			GameObject gameObject = Resources.Load<GameObject>("Introloop/" + text);
			GameObject gameObject2;
			T val;
			if (gameObject != null)
			{
				gameObject2 = UnityEngine.Object.Instantiate(gameObject);
				val = gameObject2.GetComponent<T>();
				AudioSource component = gameObject2.GetComponent<AudioSource>();
				if ((UnityEngine.Object)val == (UnityEngine.Object)null)
				{
					val = gameObject2.AddComponent<T>();
				}
				if (component == null)
				{
					SetupDefaultAudioSourceForIntroloop(gameObject2.AddComponent<AudioSource>());
				}
			}
			else
			{
				gameObject2 = new GameObject(text);
				val = gameObject2.AddComponent<T>();
				SetupDefaultAudioSourceForIntroloop(gameObject2.AddComponent<AudioSource>());
			}
			UnityEngine.Object.DontDestroyOnLoad(gameObject2);
			val.CreateImportantChildren();
			return val;
		}

		private void Awake()
		{
			if (introloopSettings == null)
			{
				introloopSettings = new IntroloopSettings();
			}
			CreateImportantChildren();
		}

		private void Start()
		{
			TemplateSource.enabled = false;
			ApplyAudioSourceCharacteristics(TemplateSource);
		}

		private void CreateImportantChildren()
		{
			if (!importantChildrenCreated)
			{
				Transform parent = base.transform;
				GameObject gameObject = new GameObject();
				gameObject.AddComponent<IntroloopTrack>();
				gameObject.name = "IntroloopTrack 1";
				gameObject.transform.parent = parent;
				gameObject.transform.localPosition = Vector3.zero;
				twoTracks[0] = gameObject.GetComponent<IntroloopTrack>();
				twoTracks[0].introloopSettings = introloopSettings;
				GameObject gameObject2 = new GameObject();
				gameObject2.AddComponent<IntroloopTrack>();
				gameObject2.name = "IntroloopTrack 2";
				gameObject2.transform.parent = parent;
				gameObject2.transform.localPosition = Vector3.zero;
				twoTracks[1] = gameObject2.GetComponent<IntroloopTrack>();
				twoTracks[1].introloopSettings = introloopSettings;
				importantChildrenCreated = true;
			}
		}

		private static void SetupDefaultAudioSourceForIntroloop(AudioSource audioSource)
		{
			audioSource.spatialBlend = 0f;
			audioSource.priority = 0;
		}

		private void Update()
		{
			FadeUpdate();
			twoTracks[0].SchedulingUpdate();
			twoTracks[1].SchedulingUpdate();
		}

		private void FadeUpdate()
		{
			for (int i = 0; i < 2; i++)
			{
				float num = towardsVolume[i];
				if (twoTracks[i].FadeVolume == num)
				{
					continue;
				}
				if (fadeLength[i] == 0f)
				{
					twoTracks[i].FadeVolume = num;
				}
				else if (twoTracks[i].FadeVolume > num)
				{
					twoTracks[i].FadeVolume -= Time.unscaledDeltaTime / fadeLength[i];
					if (twoTracks[i].FadeVolume <= num)
					{
						twoTracks[i].FadeVolume = num;
					}
				}
				else
				{
					twoTracks[i].FadeVolume += Time.unscaledDeltaTime / fadeLength[i];
					if (twoTracks[i].FadeVolume >= num)
					{
						twoTracks[i].FadeVolume = num;
					}
				}
				if (willStop[i] && twoTracks[i].FadeVolume == 0f)
				{
					willStop[i] = false;
					willPause[i] = false;
					twoTracks[i].Stop();
					UnloadTrack(i);
				}
				if (willPause[i] && twoTracks[i].FadeVolume == 0f)
				{
					willStop[i] = false;
					willPause[i] = false;
					twoTracks[i].Pause();
				}
			}
		}

		private void UnloadTrack(int trackNumber)
		{
			bool num = twoTracks[trackNumber].Music == twoTracks[(trackNumber + 1) % 2].Music;
			bool flag = twoTracks[trackNumber].Music != null && twoTracks[(trackNumber + 1) % 2].Music != null && twoTracks[trackNumber].Music.AudioClip == twoTracks[(trackNumber + 1) % 2].Music.AudioClip;
			bool flag2 = num || flag;
			bool num2 = twoTracks[trackNumber].Music == twoTracks[(trackNumber + 1) % 2].MusicAboutToPlay;
			bool flag3 = twoTracks[trackNumber].Music != null && twoTracks[(trackNumber + 1) % 2].MusicAboutToPlay != null && twoTracks[trackNumber].Music.AudioClip == twoTracks[(trackNumber + 1) % 2].MusicAboutToPlay.AudioClip;
			bool flag4 = num2 || flag3;
			if (!(twoTracks[(trackNumber + 1) % 2].IsPlaying && flag2) && !flag4)
			{
				twoTracks[trackNumber].Unload();
			}
		}

		internal void ApplyVolumeSettingToAllTracks()
		{
			twoTracks[0].ApplyVolume();
			twoTracks[1].ApplyVolume();
		}

		public void Play(IntroloopAudio audio, float fadeLengthSeconds = 0f, float startTime = 0f)
		{
			if (audio == null)
			{
				throw new ArgumentNullException("audio", "Played IntroloopAudio is null!");
			}
			Stop(fadeLengthSeconds);
			int num = (currentTrack + 1) % 2;
			twoTracks[num].Play(audio, fadeLengthSeconds != 0f, startTime);
			towardsVolume[num] = 1f;
			fadeLength[num] = TranslateFadeLength(fadeLengthSeconds);
			currentTrack = num;
			previousPlay = audio;
		}

		public void Play(IntroloopAudio audio)
		{
			Play(audio, 0f, 0f);
		}

		public void Seek(float elapsedTime)
		{
			if (twoTracks[currentTrack].IsPlaying)
			{
				twoTracks[currentTrack].Play(previousPlay, isFade: false, elapsedTime);
				towardsVolume[currentTrack] = 1f;
				fadeLength[currentTrack] = 0f;
			}
		}

		public void Stop()
		{
			willStop[currentTrack] = false;
			willPause[currentTrack] = false;
			fadeLength[currentTrack] = 0f;
			twoTracks[currentTrack].FadeVolume = 0f;
			twoTracks[currentTrack].Stop();
			UnloadTrack(currentTrack);
		}

		public void Stop(float fadeLengthSeconds)
		{
			if (fadeLengthSeconds < 0f)
			{
				Stop();
				return;
			}
			willStop[currentTrack] = true;
			willPause[currentTrack] = false;
			fadeLength[currentTrack] = TranslateFadeLength(fadeLengthSeconds);
			towardsVolume[currentTrack] = 0f;
		}

		public void Pause()
		{
			if (twoTracks[currentTrack].IsPausable())
			{
				willStop[currentTrack] = false;
				willPause[currentTrack] = false;
				fadeLength[currentTrack] = 0f;
				twoTracks[currentTrack].FadeVolume = 0f;
				twoTracks[currentTrack].Pause();
			}
		}

		public void Pause(float fadeLengthSeconds)
		{
			if (twoTracks[currentTrack].IsPausable())
			{
				if (fadeLengthSeconds < 0f)
				{
					Pause();
					return;
				}
				willPause[currentTrack] = true;
				willStop[currentTrack] = false;
				fadeLength[currentTrack] = TranslateFadeLength(fadeLengthSeconds);
				towardsVolume[currentTrack] = 0f;
			}
		}

		public void Resume(float fadeLengthSeconds = 0f)
		{
			if (twoTracks[currentTrack].Resume())
			{
				willStop[currentTrack] = false;
				willPause[currentTrack] = false;
				towardsVolume[currentTrack] = 1f;
				fadeLength[currentTrack] = TranslateFadeLength(fadeLengthSeconds);
			}
		}

		private float TranslateFadeLength(float fadeLength)
		{
			if (!(fadeLength > 0f))
			{
				if (!(fadeLength < 0f))
				{
					return 0.055f;
				}
				return 0f;
			}
			return fadeLength;
		}

		public void Preload(IntroloopAudio audio)
		{
			audio.Preload();
		}

		public float GetPlayheadTime()
		{
			return twoTracks[currentTrack].PlayheadPositionSeconds;
		}

		public void SetMixerGroup(AudioMixerGroup audioMixerGroup)
		{
			foreach (AudioSource internalAudioSource in InternalAudioSources)
			{
				internalAudioSource.outputAudioMixerGroup = audioMixerGroup;
			}
		}

		public void ApplyAudioSourceCharacteristics(AudioSource applyFrom)
		{
			foreach (AudioSource internalAudioSource in InternalAudioSources)
			{
				ApplyAudioSourceCharacteristicsInternal(internalAudioSource, applyFrom);
			}
		}

		private static void ApplyAudioSourceCharacteristicsInternal(AudioSource applyTarget, AudioSource applyFrom)
		{
			applyTarget.outputAudioMixerGroup = applyFrom.outputAudioMixerGroup;
			applyTarget.SetCustomCurve(AudioSourceCurveType.CustomRolloff, applyFrom.GetCustomCurve(AudioSourceCurveType.CustomRolloff));
			applyTarget.SetCustomCurve(AudioSourceCurveType.ReverbZoneMix, applyFrom.GetCustomCurve(AudioSourceCurveType.ReverbZoneMix));
			applyTarget.SetCustomCurve(AudioSourceCurveType.SpatialBlend, applyFrom.GetCustomCurve(AudioSourceCurveType.SpatialBlend));
			applyTarget.SetCustomCurve(AudioSourceCurveType.Spread, applyFrom.GetCustomCurve(AudioSourceCurveType.Spread));
			applyTarget.ignoreListenerVolume = applyFrom.ignoreListenerVolume;
			applyTarget.ignoreListenerPause = applyFrom.ignoreListenerPause;
			applyTarget.velocityUpdateMode = applyFrom.velocityUpdateMode;
			applyTarget.panStereo = applyFrom.panStereo;
			applyTarget.spatialBlend = applyFrom.spatialBlend;
			applyTarget.spatialize = applyFrom.spatialize;
			applyTarget.spatializePostEffects = applyFrom.spatializePostEffects;
			applyTarget.reverbZoneMix = applyFrom.reverbZoneMix;
			applyTarget.bypassEffects = applyFrom.bypassEffects;
			applyTarget.bypassListenerEffects = applyFrom.bypassListenerEffects;
			applyTarget.bypassReverbZones = applyFrom.bypassReverbZones;
			applyTarget.dopplerLevel = applyFrom.dopplerLevel;
			applyTarget.spread = applyFrom.spread;
			applyTarget.priority = applyFrom.priority;
			applyTarget.mute = applyFrom.mute;
			applyTarget.minDistance = applyFrom.minDistance;
			applyTarget.maxDistance = applyFrom.maxDistance;
		}

		public string[] GetDebugStringsTrack1()
		{
			return twoTracks[0].DebugInformation;
		}

		public string[] GetDebugStringsTrack2()
		{
			return twoTracks[1].DebugInformation;
		}

		public void OnApplicationPause(bool paused)
		{
			if (paused)
			{
				timeBeforePause = GetPlayheadTime();
			}
			else
			{
				Seek(timeBeforePause);
			}
		}
	}
	public abstract class IntroloopPlayer<T> : IntroloopPlayer where T : IntroloopPlayer
	{
		private static T instance;

		public static T Get
		{
			get
			{
				if ((UnityEngine.Object)instance == (UnityEngine.Object)null)
				{
					instance = IntroloopPlayer.InstantiatePlayer<T>();
					instance.name = "Singleton-" + instance.name;
				}
				return instance;
			}
		}
	}
}
