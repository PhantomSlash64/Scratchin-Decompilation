using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

namespace Cinemachine.PostFX
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[AddComponentMenu("")]
	[SaveDuringPlay]
	[DisallowMultipleComponent]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.7/manual/CinemachinePostProcessing.html")]
	public class CinemachinePostProcessing : CinemachineExtension
	{
		public enum FocusTrackingMode
		{
			None = 0,
			LookAtTarget = 1,
			FollowTarget = 2,
			CustomTarget = 3,
			Camera = 4
		}

		private class VcamExtraState
		{
			public PostProcessProfile mProfileCopy;

			public void CreateProfileCopy(PostProcessProfile source)
			{
				DestroyProfileCopy();
				PostProcessProfile postProcessProfile = ScriptableObject.CreateInstance<PostProcessProfile>();
				if (source != null)
				{
					foreach (PostProcessEffectSettings setting in source.settings)
					{
						PostProcessEffectSettings item = Object.Instantiate(setting);
						postProcessProfile.settings.Add(item);
					}
				}
				mProfileCopy = postProcessProfile;
			}

			public void DestroyProfileCopy()
			{
				if (mProfileCopy != null)
				{
					RuntimeUtility.DestroyObject(mProfileCopy);
				}
				mProfileCopy = null;
			}
		}

		public static float s_VolumePriority = 1000f;

		[HideInInspector]
		public bool m_FocusTracksTarget;

		[Tooltip("If the profile has the appropriate overrides, will set the base focus distance to be the distance from the selected target to the camera.The Focus Offset field will then modify that distance.")]
		public FocusTrackingMode m_FocusTracking;

		[Tooltip("The target to use if Focus Tracks Target is set to Custom Target")]
		public Transform m_FocusTarget;

		[Tooltip("Offset from target distance, to be used with Focus Tracks Target.  Offsets the sharpest point away from the location of the focus target.")]
		public float m_FocusOffset;

		[Tooltip("This Post-Processing profile will be applied whenever this virtual camera is live")]
		public PostProcessProfile m_Profile;

		private static string sVolumeOwnerName = "__CMVolumes";

		private static List<PostProcessVolume> sVolumes = new List<PostProcessVolume>();

		private static Dictionary<CinemachineBrain, PostProcessLayer> mBrainToLayer = new Dictionary<CinemachineBrain, PostProcessLayer>();

		public bool IsValid
		{
			get
			{
				if (m_Profile != null)
				{
					return m_Profile.settings.Count > 0;
				}
				return false;
			}
		}

		public void InvalidateCachedProfile()
		{
			List<VcamExtraState> allExtraStates = GetAllExtraStates<VcamExtraState>();
			for (int i = 0; i < allExtraStates.Count; i++)
			{
				allExtraStates[i].DestroyProfileCopy();
			}
		}

		protected override void OnEnable()
		{
			base.OnEnable();
			if (m_FocusTracksTarget)
			{
				m_FocusTracking = ((base.VirtualCamera.LookAt != null) ? FocusTrackingMode.LookAtTarget : FocusTrackingMode.Camera);
			}
			m_FocusTracksTarget = false;
		}

		protected override void OnDestroy()
		{
			InvalidateCachedProfile();
			base.OnDestroy();
		}

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
			if (stage != CinemachineCore.Stage.Finalize)
			{
				return;
			}
			VcamExtraState extraState = GetExtraState<VcamExtraState>(vcam);
			if (!IsValid)
			{
				extraState.DestroyProfileCopy();
				return;
			}
			PostProcessProfile postProcessProfile = m_Profile;
			if (m_FocusTracking == FocusTrackingMode.None)
			{
				extraState.DestroyProfileCopy();
			}
			else
			{
				if (extraState.mProfileCopy == null)
				{
					extraState.CreateProfileCopy(m_Profile);
				}
				postProcessProfile = extraState.mProfileCopy;
				if (postProcessProfile.TryGetSettings<DepthOfField>(out var outSetting))
				{
					float num = m_FocusOffset;
					if (m_FocusTracking == FocusTrackingMode.LookAtTarget)
					{
						num += (state.FinalPosition - state.ReferenceLookAt).magnitude;
					}
					else
					{
						Transform transform = null;
						switch (m_FocusTracking)
						{
						case FocusTrackingMode.FollowTarget:
							transform = base.VirtualCamera.Follow;
							break;
						case FocusTrackingMode.CustomTarget:
							transform = m_FocusTarget;
							break;
						}
						if (transform != null)
						{
							num += (state.FinalPosition - transform.position).magnitude;
						}
					}
					outSetting.focusDistance.value = Mathf.Max(0f, num);
				}
			}
			state.AddCustomBlendable(new CameraState.CustomBlendable(postProcessProfile, 1f));
		}

		private static void OnCameraCut(CinemachineBrain brain)
		{
			PostProcessLayer pPLayer = GetPPLayer(brain);
			if (pPLayer != null)
			{
				pPLayer.ResetHistory();
			}
		}

		private static void ApplyPostFX(CinemachineBrain brain)
		{
			PostProcessLayer pPLayer = GetPPLayer(brain);
			if (pPLayer == null || !pPLayer.enabled || (int)pPLayer.volumeLayer == 0)
			{
				return;
			}
			CameraState currentCameraState = brain.CurrentCameraState;
			int numCustomBlendables = currentCameraState.NumCustomBlendables;
			List<PostProcessVolume> dynamicBrainVolumes = GetDynamicBrainVolumes(brain, pPLayer, numCustomBlendables);
			for (int i = 0; i < dynamicBrainVolumes.Count; i++)
			{
				dynamicBrainVolumes[i].weight = 0f;
				dynamicBrainVolumes[i].sharedProfile = null;
				dynamicBrainVolumes[i].profile = null;
			}
			PostProcessVolume postProcessVolume = null;
			int num = 0;
			for (int j = 0; j < numCustomBlendables; j++)
			{
				CameraState.CustomBlendable customBlendable = currentCameraState.GetCustomBlendable(j);
				PostProcessProfile postProcessProfile = customBlendable.m_Custom as PostProcessProfile;
				if (!(postProcessProfile == null))
				{
					PostProcessVolume postProcessVolume2 = dynamicBrainVolumes[j];
					if (postProcessVolume == null)
					{
						postProcessVolume = postProcessVolume2;
					}
					postProcessVolume2.sharedProfile = postProcessProfile;
					postProcessVolume2.isGlobal = true;
					postProcessVolume2.priority = s_VolumePriority - (float)(numCustomBlendables - j) - 1f;
					postProcessVolume2.weight = customBlendable.m_Weight;
					num++;
				}
				if (num > 1)
				{
					postProcessVolume.weight = 1f;
				}
			}
		}

		private static List<PostProcessVolume> GetDynamicBrainVolumes(CinemachineBrain brain, PostProcessLayer ppLayer, int minVolumes)
		{
			GameObject gameObject = null;
			Transform transform = brain.transform;
			int childCount = transform.childCount;
			sVolumes.Clear();
			int num = 0;
			while (gameObject == null && num < childCount)
			{
				GameObject gameObject2 = transform.GetChild(num).gameObject;
				if (gameObject2.hideFlags == HideFlags.HideAndDontSave)
				{
					gameObject2.GetComponents(sVolumes);
					if (sVolumes.Count > 0)
					{
						gameObject = gameObject2;
					}
				}
				num++;
			}
			if (minVolumes > 0)
			{
				if (gameObject == null)
				{
					gameObject = new GameObject(sVolumeOwnerName);
					gameObject.hideFlags = HideFlags.HideAndDontSave;
					gameObject.transform.parent = transform;
				}
				int value = ppLayer.volumeLayer.value;
				for (int i = 0; i < 32; i++)
				{
					if ((value & (1 << i)) != 0)
					{
						gameObject.layer = i;
						break;
					}
				}
				while (sVolumes.Count < minVolumes)
				{
					sVolumes.Add(gameObject.gameObject.AddComponent<PostProcessVolume>());
				}
			}
			return sVolumes;
		}

		private static PostProcessLayer GetPPLayer(CinemachineBrain brain)
		{
			PostProcessLayer value;
			bool flag = mBrainToLayer.TryGetValue(brain, out value);
			if (value != null)
			{
				return value;
			}
			if (flag)
			{
				brain.m_CameraCutEvent.RemoveListener(OnCameraCut);
				mBrainToLayer.Remove(brain);
				value = null;
			}
			brain.TryGetComponent<PostProcessLayer>(out value);
			if (value != null)
			{
				brain.m_CameraCutEvent.AddListener(OnCameraCut);
			}
			mBrainToLayer[brain] = value;
			return value;
		}

		private static void OnSceneUnloaded(Scene scene)
		{
			Dictionary<CinemachineBrain, PostProcessLayer>.Enumerator enumerator = mBrainToLayer.GetEnumerator();
			while (enumerator.MoveNext())
			{
				CinemachineBrain key = enumerator.Current.Key;
				if (key != null)
				{
					key.m_CameraCutEvent.RemoveListener(OnCameraCut);
				}
			}
			mBrainToLayer.Clear();
		}

		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule()
		{
			CinemachineCore.CameraUpdatedEvent.RemoveListener(ApplyPostFX);
			CinemachineCore.CameraUpdatedEvent.AddListener(ApplyPostFX);
			SceneManager.sceneUnloaded += OnSceneUnloaded;
		}
	}
}
