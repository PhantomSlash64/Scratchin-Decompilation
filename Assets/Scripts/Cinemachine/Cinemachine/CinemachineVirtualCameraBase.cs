using System;
using System.Collections.Generic;
using Cinemachine.Utility;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[SaveDuringPlay]
	public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera
	{
		public enum StandbyUpdateMode
		{
			Never = 0,
			Always = 1,
			RoundRobin = 2
		}

		public enum BlendHint
		{
			None = 0,
			SphericalPosition = 1,
			CylindricalPosition = 2,
			ScreenSpaceAimWhenTargetsDiffer = 3
		}

		[Serializable]
		public struct TransitionParams
		{
			[Tooltip("Hint for blending positions to and from this virtual camera")]
			[FormerlySerializedAs("m_PositionBlending")]
			public BlendHint m_BlendHint;

			[Tooltip("When this virtual camera goes Live, attempt to force the position to be the same as the current position of the Unity Camera")]
			public bool m_InheritPosition;

			[Tooltip("This event fires when the virtual camera goes Live")]
			public CinemachineBrain.VcamActivatedEvent m_OnCameraLive;
		}

		[HideInInspector]
		[SerializeField]
		[NoSaveDuringPlay]
		public string[] m_ExcludedPropertiesInInspector = new string[1] { "m_Script" };

		[HideInInspector]
		[SerializeField]
		[NoSaveDuringPlay]
		public CinemachineCore.Stage[] m_LockStageInInspector;

		private int m_ValidatingStreamVersion;

		private bool m_OnValidateCalled;

		[HideInInspector]
		[SerializeField]
		[NoSaveDuringPlay]
		private int m_StreamingVersion;

		[NoSaveDuringPlay]
		[Tooltip("The priority will determine which camera becomes active based on the state of other cameras and this camera.  Higher numbers have greater priority.")]
		public int m_Priority = 10;

		internal int m_ActivationId;

		[Tooltip("When the virtual camera is not live, this is how often the virtual camera will be updated.  Set this to tune for performance. Most of the time Never is fine, unless the virtual camera is doing shot evaluation.")]
		public StandbyUpdateMode m_StandbyUpdate = StandbyUpdateMode.RoundRobin;

		private bool m_WasStarted;

		private bool mSlaveStatusUpdated;

		private CinemachineVirtualCameraBase m_parentVcam;

		private int m_QueuePriority = int.MaxValue;

		public int ValidatingStreamVersion
		{
			get
			{
				if (!m_OnValidateCalled)
				{
					return CinemachineCore.kStreamingVersion;
				}
				return m_ValidatingStreamVersion;
			}
			private set
			{
				m_ValidatingStreamVersion = value;
			}
		}

		public float FollowTargetAttachment { get; set; }

		public float LookAtTargetAttachment { get; set; }

		internal List<CinemachineExtension> mExtensions { get; private set; }

		public string Name => base.name;

		public virtual string Description => "";

		public int Priority
		{
			get
			{
				return m_Priority;
			}
			set
			{
				m_Priority = value;
			}
		}

		public GameObject VirtualCameraGameObject
		{
			get
			{
				if (this == null)
				{
					return null;
				}
				return base.gameObject;
			}
		}

		public bool IsValid => !(this == null);

		public abstract CameraState State { get; }

		public ICinemachineCamera ParentCamera
		{
			get
			{
				if (!mSlaveStatusUpdated || !Application.isPlaying)
				{
					UpdateSlaveStatus();
				}
				return m_parentVcam;
			}
		}

		public abstract Transform LookAt { get; set; }

		public abstract Transform Follow { get; set; }

		public virtual bool PreviousStateIsValid { get; set; }

		public virtual float GetMaxDampTime()
		{
			float num = 0f;
			if (mExtensions != null)
			{
				for (int i = 0; i < mExtensions.Count; i++)
				{
					num = Mathf.Max(num, mExtensions[i].GetMaxDampTime());
				}
			}
			return num;
		}

		public float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime)
		{
			dampTime = Mathf.Lerp(Mathf.Max(1f, dampTime), dampTime, FollowTargetAttachment);
			deltaTime = Mathf.Lerp(0f, deltaTime, FollowTargetAttachment);
			return Damper.Damp(initial, dampTime, deltaTime);
		}

		public Vector3 DetachedFollowTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime)
		{
			dampTime = Vector3.Lerp(Vector3.Max(Vector3.one, dampTime), dampTime, FollowTargetAttachment);
			deltaTime = Mathf.Lerp(0f, deltaTime, FollowTargetAttachment);
			return Damper.Damp(initial, dampTime, deltaTime);
		}

		public Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime)
		{
			dampTime = Mathf.Lerp(Mathf.Max(1f, dampTime), dampTime, FollowTargetAttachment);
			deltaTime = Mathf.Lerp(0f, deltaTime, FollowTargetAttachment);
			return Damper.Damp(initial, dampTime, deltaTime);
		}

		public float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime)
		{
			dampTime = Mathf.Lerp(Mathf.Max(1f, dampTime), dampTime, LookAtTargetAttachment);
			deltaTime = Mathf.Lerp(0f, deltaTime, LookAtTargetAttachment);
			return Damper.Damp(initial, dampTime, deltaTime);
		}

		public Vector3 DetachedLookAtTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime)
		{
			dampTime = Vector3.Lerp(Vector3.Max(Vector3.one, dampTime), dampTime, LookAtTargetAttachment);
			deltaTime = Mathf.Lerp(0f, deltaTime, LookAtTargetAttachment);
			return Damper.Damp(initial, dampTime, deltaTime);
		}

		public Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime)
		{
			dampTime = Mathf.Lerp(Mathf.Max(1f, dampTime), dampTime, LookAtTargetAttachment);
			deltaTime = Mathf.Lerp(0f, deltaTime, LookAtTargetAttachment);
			return Damper.Damp(initial, dampTime, deltaTime);
		}

		public virtual void AddExtension(CinemachineExtension extension)
		{
			if (mExtensions == null)
			{
				mExtensions = new List<CinemachineExtension>();
			}
			else
			{
				mExtensions.Remove(extension);
			}
			mExtensions.Add(extension);
		}

		public virtual void RemoveExtension(CinemachineExtension extension)
		{
			if (mExtensions != null)
			{
				mExtensions.Remove(extension);
			}
		}

		protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState newState, float deltaTime)
		{
			if (mExtensions != null)
			{
				for (int i = 0; i < mExtensions.Count; i++)
				{
					CinemachineExtension cinemachineExtension = mExtensions[i];
					if (cinemachineExtension == null)
					{
						mExtensions.RemoveAt(i);
						i--;
					}
					else if (cinemachineExtension.enabled)
					{
						cinemachineExtension.InvokePostPipelineStageCallback(vcam, stage, ref newState, deltaTime);
					}
				}
			}
			CinemachineVirtualCameraBase cinemachineVirtualCameraBase = ParentCamera as CinemachineVirtualCameraBase;
			if (cinemachineVirtualCameraBase != null)
			{
				cinemachineVirtualCameraBase.InvokePostPipelineStageCallback(vcam, stage, ref newState, deltaTime);
			}
		}

		protected void InvokePrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState newState, float deltaTime)
		{
			if (mExtensions != null)
			{
				for (int i = 0; i < mExtensions.Count; i++)
				{
					CinemachineExtension cinemachineExtension = mExtensions[i];
					if (cinemachineExtension == null)
					{
						mExtensions.RemoveAt(i);
						i--;
					}
					else if (cinemachineExtension.enabled)
					{
						cinemachineExtension.PrePipelineMutateCameraStateCallback(vcam, ref newState, deltaTime);
					}
				}
			}
			CinemachineVirtualCameraBase cinemachineVirtualCameraBase = ParentCamera as CinemachineVirtualCameraBase;
			if (cinemachineVirtualCameraBase != null)
			{
				cinemachineVirtualCameraBase.InvokePrePipelineMutateCameraStateCallback(vcam, ref newState, deltaTime);
			}
		}

		protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
			bool result = false;
			if (mExtensions != null)
			{
				for (int i = 0; i < mExtensions.Count; i++)
				{
					CinemachineExtension cinemachineExtension = mExtensions[i];
					if (cinemachineExtension == null)
					{
						mExtensions.RemoveAt(i);
						i--;
					}
					else if (cinemachineExtension.enabled && cinemachineExtension.OnTransitionFromCamera(fromCam, worldUp, deltaTime))
					{
						result = true;
					}
				}
			}
			return result;
		}

		protected void ApplyPositionBlendMethod(ref CameraState state, BlendHint hint)
		{
			switch (hint)
			{
			case BlendHint.SphericalPosition:
				state.BlendHint |= CameraState.BlendHintValue.SphericalPositionBlend;
				break;
			case BlendHint.CylindricalPosition:
				state.BlendHint |= CameraState.BlendHintValue.CylindricalPositionBlend;
				break;
			case BlendHint.ScreenSpaceAimWhenTargetsDiffer:
				state.BlendHint |= CameraState.BlendHintValue.RadialAimBlend;
				break;
			}
		}

		public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return false;
		}

		public void UpdateCameraState(Vector3 worldUp, float deltaTime)
		{
			CinemachineCore.Instance.UpdateVirtualCamera(this, worldUp, deltaTime);
		}

		public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime);

		public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
			if (!base.gameObject.activeInHierarchy)
			{
				PreviousStateIsValid = false;
			}
		}

		protected virtual void OnDestroy()
		{
			CinemachineCore.Instance.CameraDestroyed(this);
		}

		protected virtual void OnTransformParentChanged()
		{
			CinemachineCore.Instance.CameraDisabled(this);
			CinemachineCore.Instance.CameraEnabled(this);
			UpdateSlaveStatus();
			UpdateVcamPoolStatus();
		}

		protected virtual void Start()
		{
			m_WasStarted = true;
		}

		internal void EnsureStarted()
		{
			if (!m_WasStarted)
			{
				m_WasStarted = true;
				CinemachineExtension[] componentsInChildren = GetComponentsInChildren<CinemachineExtension>();
				for (int i = 0; i < componentsInChildren.Length; i++)
				{
					componentsInChildren[i].EnsureStarted();
				}
			}
		}

		public AxisState.IInputAxisProvider GetInputAxisProvider()
		{
			MonoBehaviour[] componentsInChildren = GetComponentsInChildren<MonoBehaviour>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				if (componentsInChildren[i] is AxisState.IInputAxisProvider result)
				{
					return result;
				}
			}
			return null;
		}

		protected virtual void OnValidate()
		{
			m_OnValidateCalled = true;
			ValidatingStreamVersion = m_StreamingVersion;
			m_StreamingVersion = CinemachineCore.kStreamingVersion;
		}

		protected virtual void OnEnable()
		{
			UpdateSlaveStatus();
			UpdateVcamPoolStatus();
			if (!CinemachineCore.Instance.IsLive(this))
			{
				PreviousStateIsValid = false;
			}
			CinemachineCore.Instance.CameraEnabled(this);
			CinemachineVirtualCameraBase[] components = GetComponents<CinemachineVirtualCameraBase>();
			for (int i = 0; i < components.Length; i++)
			{
				if (components[i].enabled && components[i] != this)
				{
					Debug.LogError(Name + " has multiple CinemachineVirtualCameraBase-derived components.  Disabling " + GetType().Name + ".");
					base.enabled = false;
				}
			}
		}

		protected virtual void OnDisable()
		{
			UpdateVcamPoolStatus();
			CinemachineCore.Instance.CameraDisabled(this);
		}

		protected virtual void Update()
		{
			if (m_Priority != m_QueuePriority)
			{
				UpdateVcamPoolStatus();
			}
		}

		private void UpdateSlaveStatus()
		{
			mSlaveStatusUpdated = true;
			m_parentVcam = null;
			Transform parent = base.transform.parent;
			if (parent != null)
			{
				parent.TryGetComponent<CinemachineVirtualCameraBase>(out m_parentVcam);
			}
		}

		protected Transform ResolveLookAt(Transform localLookAt)
		{
			Transform transform = localLookAt;
			if (transform == null && ParentCamera != null)
			{
				transform = ParentCamera.LookAt;
			}
			return transform;
		}

		protected Transform ResolveFollow(Transform localFollow)
		{
			Transform transform = localFollow;
			if (transform == null && ParentCamera != null)
			{
				transform = ParentCamera.Follow;
			}
			return transform;
		}

		private void UpdateVcamPoolStatus()
		{
			CinemachineCore.Instance.RemoveActiveCamera(this);
			if (m_parentVcam == null && base.isActiveAndEnabled)
			{
				CinemachineCore.Instance.AddActiveCamera(this);
			}
			m_QueuePriority = m_Priority;
		}

		public void MoveToTopOfPrioritySubqueue()
		{
			UpdateVcamPoolStatus();
		}

		public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
			if (mExtensions != null)
			{
				for (int i = 0; i < mExtensions.Count; i++)
				{
					mExtensions[i].OnTargetObjectWarped(target, positionDelta);
				}
			}
		}

		public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot)
		{
			if (mExtensions != null)
			{
				for (int i = 0; i < mExtensions.Count; i++)
				{
					mExtensions[i].ForceCameraPosition(pos, rot);
				}
			}
		}

		protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend)
		{
			if (blendDef.BlendCurve == null || blendDef.BlendTime <= 0f || (camA == null && camB == null))
			{
				return null;
			}
			if (activeBlend != null)
			{
				if (activeBlend.CamA == camB && activeBlend.CamB == camA && activeBlend.Duration <= blendDef.BlendTime)
				{
					blendDef.m_Time = activeBlend.TimeInBlend;
				}
				camA = new BlendSourceVirtualCamera(activeBlend);
			}
			else if (camA == null)
			{
				camA = new StaticPointVirtualCamera(State, "(none)");
			}
			return new CinemachineBlend(camA, camB, blendDef.BlendCurve, blendDef.BlendTime, 0f);
		}

		protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens)
		{
			CameraState @default = CameraState.Default;
			@default.RawPosition = TargetPositionCache.GetTargetPosition(base.transform);
			@default.RawOrientation = TargetPositionCache.GetTargetRotation(base.transform);
			@default.ReferenceUp = worldUp;
			CinemachineBrain cinemachineBrain = CinemachineCore.Instance.FindPotentialTargetBrain(this);
			if (cinemachineBrain != null)
			{
				lens.SnapshotCameraReadOnlyProperties(cinemachineBrain.OutputCamera);
			}
			@default.Lens = lens;
			return @default;
		}
	}
}
