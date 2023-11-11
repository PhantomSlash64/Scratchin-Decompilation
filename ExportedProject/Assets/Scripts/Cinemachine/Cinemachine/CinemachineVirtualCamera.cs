using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[ExcludeFromPreset]
	[AddComponentMenu("Cinemachine/CinemachineVirtualCamera")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.7/manual/CinemachineVirtualCamera.html")]
	public class CinemachineVirtualCamera : CinemachineVirtualCameraBase
	{
		public delegate Transform CreatePipelineDelegate(CinemachineVirtualCamera vcam, string name, CinemachineComponentBase[] copyFrom);

		public delegate void DestroyPipelineDelegate(GameObject pipeline);

		[Tooltip("The object that the camera wants to look at (the Aim target).  If this is null, then the vcam's Transform orientation will define the camera's orientation.")]
		[NoSaveDuringPlay]
		[VcamTargetProperty]
		public Transform m_LookAt;

		[Tooltip("The object that the camera wants to move with (the Body target).  If this is null, then the vcam's Transform position will define the camera's position.")]
		[NoSaveDuringPlay]
		[VcamTargetProperty]
		public Transform m_Follow;

		[FormerlySerializedAs("m_LensAttributes")]
		[Tooltip("Specifies the lens properties of this Virtual Camera.  This generally mirrors the Unity Camera's lens settings, and will be used to drive the Unity camera when the vcam is active.")]
		public LensSettings m_Lens = LensSettings.Default;

		public TransitionParams m_Transitions;

		[SerializeField]
		[HideInInspector]
		[FormerlySerializedAs("m_BlendHint")]
		[FormerlySerializedAs("m_PositionBlending")]
		private BlendHint m_LegacyBlendHint;

		public const string PipelineName = "cm";

		public static CreatePipelineDelegate CreatePipelineOverride;

		public static DestroyPipelineDelegate DestroyPipelineOverride;

		private CameraState m_State = CameraState.Default;

		private CinemachineComponentBase[] m_ComponentPipeline;

		[SerializeField]
		[HideInInspector]
		private Transform m_ComponentOwner;

		private Transform mCachedLookAtTarget;

		private CinemachineVirtualCameraBase mCachedLookAtTargetVcam;

		public override CameraState State => m_State;

		public override Transform LookAt
		{
			get
			{
				return ResolveLookAt(m_LookAt);
			}
			set
			{
				m_LookAt = value;
			}
		}

		public override Transform Follow
		{
			get
			{
				return ResolveFollow(m_Follow);
			}
			set
			{
				m_Follow = value;
			}
		}

		public bool UserIsDragging { get; set; }

		public override float GetMaxDampTime()
		{
			float num = base.GetMaxDampTime();
			UpdateComponentPipeline();
			if (m_ComponentPipeline != null)
			{
				for (int i = 0; i < m_ComponentPipeline.Length; i++)
				{
					num = Mathf.Max(num, m_ComponentPipeline[i].GetMaxDampTime());
				}
			}
			return num;
		}

		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
		{
			m_State = CalculateNewState(worldUp, deltaTime);
			ApplyPositionBlendMethod(ref m_State, m_Transitions.m_BlendHint);
			if (!UserIsDragging)
			{
				if (Follow != null)
				{
					base.transform.position = State.RawPosition;
				}
				if (LookAt != null)
				{
					base.transform.rotation = State.RawOrientation;
				}
			}
			PreviousStateIsValid = true;
		}

		protected override void OnEnable()
		{
			base.OnEnable();
			m_State = PullStateFromVirtualCamera(Vector3.up, ref m_Lens);
			InvalidateComponentPipeline();
			if (base.ValidatingStreamVersion < 20170927)
			{
				if (Follow != null && GetCinemachineComponent(CinemachineCore.Stage.Body) == null)
				{
					AddCinemachineComponent<CinemachineHardLockToTarget>();
				}
				if (LookAt != null && GetCinemachineComponent(CinemachineCore.Stage.Aim) == null)
				{
					AddCinemachineComponent<CinemachineHardLookAt>();
				}
			}
		}

		protected override void OnDestroy()
		{
			foreach (Transform item in base.transform)
			{
				if (item.GetComponent<CinemachinePipeline>() != null)
				{
					item.gameObject.hideFlags &= ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
				}
			}
			base.OnDestroy();
		}

		protected override void OnValidate()
		{
			base.OnValidate();
			m_Lens.Validate();
			if (m_LegacyBlendHint != 0)
			{
				m_Transitions.m_BlendHint = m_LegacyBlendHint;
				m_LegacyBlendHint = BlendHint.None;
			}
		}

		private void OnTransformChildrenChanged()
		{
			InvalidateComponentPipeline();
		}

		private void Reset()
		{
			DestroyPipeline();
		}

		private void DestroyPipeline()
		{
			List<Transform> list = new List<Transform>();
			foreach (Transform item in base.transform)
			{
				if (item.GetComponent<CinemachinePipeline>() != null)
				{
					list.Add(item);
				}
			}
			if (!RuntimeUtility.IsPrefab(base.gameObject))
			{
				foreach (Transform item2 in list)
				{
					if (DestroyPipelineOverride != null)
					{
						DestroyPipelineOverride(item2.gameObject);
					}
					else
					{
						Object.Destroy(item2.gameObject);
					}
				}
				m_ComponentOwner = null;
			}
			PreviousStateIsValid = false;
		}

		private Transform CreatePipeline(CinemachineVirtualCamera copyFrom)
		{
			CinemachineComponentBase[] copyFrom2 = null;
			if (copyFrom != null)
			{
				copyFrom.InvalidateComponentPipeline();
				copyFrom2 = copyFrom.GetComponentPipeline();
			}
			Transform transform = null;
			if (CreatePipelineOverride != null)
			{
				transform = CreatePipelineOverride(this, "cm", copyFrom2);
			}
			else
			{
				GameObject obj = new GameObject("cm");
				obj.transform.parent = base.transform;
				obj.AddComponent<CinemachinePipeline>();
				transform = obj.transform;
			}
			PreviousStateIsValid = false;
			return transform;
		}

		public void InvalidateComponentPipeline()
		{
			m_ComponentPipeline = null;
		}

		public Transform GetComponentOwner()
		{
			UpdateComponentPipeline();
			return m_ComponentOwner;
		}

		public CinemachineComponentBase[] GetComponentPipeline()
		{
			UpdateComponentPipeline();
			return m_ComponentPipeline;
		}

		public CinemachineComponentBase GetCinemachineComponent(CinemachineCore.Stage stage)
		{
			CinemachineComponentBase[] componentPipeline = GetComponentPipeline();
			if (componentPipeline != null)
			{
				CinemachineComponentBase[] array = componentPipeline;
				foreach (CinemachineComponentBase cinemachineComponentBase in array)
				{
					if (cinemachineComponentBase.Stage == stage)
					{
						return cinemachineComponentBase;
					}
				}
			}
			return null;
		}

		public T GetCinemachineComponent<T>() where T : CinemachineComponentBase
		{
			CinemachineComponentBase[] componentPipeline = GetComponentPipeline();
			if (componentPipeline != null)
			{
				CinemachineComponentBase[] array = componentPipeline;
				foreach (CinemachineComponentBase cinemachineComponentBase in array)
				{
					if (cinemachineComponentBase is T)
					{
						return cinemachineComponentBase as T;
					}
				}
			}
			return null;
		}

		public T AddCinemachineComponent<T>() where T : CinemachineComponentBase
		{
			Transform componentOwner = GetComponentOwner();
			if (componentOwner == null)
			{
				return null;
			}
			CinemachineComponentBase[] components = componentOwner.GetComponents<CinemachineComponentBase>();
			T val = componentOwner.gameObject.AddComponent<T>();
			if ((Object)val != (Object)null && components != null)
			{
				CinemachineCore.Stage stage = val.Stage;
				for (int num = components.Length - 1; num >= 0; num--)
				{
					if (components[num].Stage == stage)
					{
						components[num].enabled = false;
						RuntimeUtility.DestroyObject(components[num]);
					}
				}
			}
			InvalidateComponentPipeline();
			return val;
		}

		public void DestroyCinemachineComponent<T>() where T : CinemachineComponentBase
		{
			CinemachineComponentBase[] componentPipeline = GetComponentPipeline();
			if (componentPipeline == null)
			{
				return;
			}
			CinemachineComponentBase[] array = componentPipeline;
			foreach (CinemachineComponentBase cinemachineComponentBase in array)
			{
				if (cinemachineComponentBase is T)
				{
					cinemachineComponentBase.enabled = false;
					RuntimeUtility.DestroyObject(cinemachineComponentBase);
					InvalidateComponentPipeline();
				}
			}
		}

		private void UpdateComponentPipeline()
		{
			bool flag = RuntimeUtility.IsPrefab(base.gameObject);
			if (m_ComponentOwner != null && m_ComponentPipeline != null)
			{
				return;
			}
			m_ComponentOwner = null;
			List<CinemachineComponentBase> list = new List<CinemachineComponentBase>();
			foreach (Transform item in base.transform)
			{
				if (!(item.GetComponent<CinemachinePipeline>() != null))
				{
					continue;
				}
				m_ComponentOwner = item;
				CinemachineComponentBase[] components = item.GetComponents<CinemachineComponentBase>();
				foreach (CinemachineComponentBase cinemachineComponentBase in components)
				{
					if (cinemachineComponentBase.enabled)
					{
						list.Add(cinemachineComponentBase);
					}
				}
			}
			if (m_ComponentOwner == null && !flag)
			{
				m_ComponentOwner = CreatePipeline(null);
			}
			if (m_ComponentOwner != null)
			{
				SetFlagsForHiddenChild(m_ComponentOwner.gameObject);
			}
			if (m_ComponentOwner != null && m_ComponentOwner.gameObject != null)
			{
				list.Sort((CinemachineComponentBase c1, CinemachineComponentBase c2) => c1.Stage - c2.Stage);
				m_ComponentPipeline = list.ToArray();
			}
		}

		internal static void SetFlagsForHiddenChild(GameObject child)
		{
			if (child != null)
			{
				if (CinemachineCore.sShowHiddenObjects)
				{
					child.hideFlags &= ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
				}
				else
				{
					child.hideFlags |= HideFlags.HideInHierarchy | HideFlags.HideInInspector;
				}
			}
		}

		private CameraState CalculateNewState(Vector3 worldUp, float deltaTime)
		{
			base.FollowTargetAttachment = 1f;
			base.LookAtTargetAttachment = 1f;
			CameraState curState = PullStateFromVirtualCamera(worldUp, ref m_Lens);
			Transform lookAt = LookAt;
			if (lookAt != mCachedLookAtTarget)
			{
				mCachedLookAtTarget = lookAt;
				mCachedLookAtTargetVcam = null;
				if (lookAt != null)
				{
					mCachedLookAtTargetVcam = lookAt.GetComponent<CinemachineVirtualCameraBase>();
				}
			}
			if (lookAt != null)
			{
				if (mCachedLookAtTargetVcam != null)
				{
					curState.ReferenceLookAt = mCachedLookAtTargetVcam.State.FinalPosition;
				}
				else
				{
					curState.ReferenceLookAt = TargetPositionCache.GetTargetPosition(lookAt);
				}
			}
			UpdateComponentPipeline();
			InvokePrePipelineMutateCameraStateCallback(this, ref curState, deltaTime);
			if (m_ComponentPipeline == null)
			{
				curState.BlendHint |= CameraState.BlendHintValue.IgnoreLookAtTarget;
				for (CinemachineCore.Stage stage = CinemachineCore.Stage.Body; stage <= CinemachineCore.Stage.Finalize; stage++)
				{
					InvokePostPipelineStageCallback(this, stage, ref curState, deltaTime);
				}
			}
			else
			{
				for (int i = 0; i < m_ComponentPipeline.Length; i++)
				{
					m_ComponentPipeline[i].PrePipelineMutateCameraState(ref curState, deltaTime);
				}
				int num = 0;
				CinemachineComponentBase cinemachineComponentBase = null;
				for (CinemachineCore.Stage stage2 = CinemachineCore.Stage.Body; stage2 <= CinemachineCore.Stage.Finalize; stage2++)
				{
					CinemachineComponentBase cinemachineComponentBase2 = ((num < m_ComponentPipeline.Length) ? m_ComponentPipeline[num] : null);
					if (cinemachineComponentBase2 != null && stage2 == cinemachineComponentBase2.Stage)
					{
						num++;
						if (stage2 == CinemachineCore.Stage.Body && cinemachineComponentBase2.BodyAppliesAfterAim)
						{
							cinemachineComponentBase = cinemachineComponentBase2;
							continue;
						}
						cinemachineComponentBase2.MutateCameraState(ref curState, deltaTime);
					}
					InvokePostPipelineStageCallback(this, stage2, ref curState, deltaTime);
					if (stage2 == CinemachineCore.Stage.Aim)
					{
						if (cinemachineComponentBase2 == null)
						{
							curState.BlendHint |= CameraState.BlendHintValue.IgnoreLookAtTarget;
						}
						if (cinemachineComponentBase != null)
						{
							cinemachineComponentBase.MutateCameraState(ref curState, deltaTime);
							InvokePostPipelineStageCallback(this, CinemachineCore.Stage.Body, ref curState, deltaTime);
						}
					}
				}
			}
			return curState;
		}

		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
			if (target == Follow)
			{
				base.transform.position += positionDelta;
				m_State.RawPosition += positionDelta;
			}
			UpdateComponentPipeline();
			if (m_ComponentPipeline != null)
			{
				for (int i = 0; i < m_ComponentPipeline.Length; i++)
				{
					m_ComponentPipeline[i].OnTargetObjectWarped(target, positionDelta);
				}
			}
			base.OnTargetObjectWarped(target, positionDelta);
		}

		public override void ForceCameraPosition(Vector3 pos, Quaternion rot)
		{
			PreviousStateIsValid = true;
			base.transform.position = pos;
			base.transform.rotation = rot;
			m_State.RawPosition = pos;
			m_State.RawOrientation = rot;
			UpdateComponentPipeline();
			if (m_ComponentPipeline != null)
			{
				for (int i = 0; i < m_ComponentPipeline.Length; i++)
				{
					m_ComponentPipeline[i].ForceCameraPosition(pos, rot);
				}
			}
			base.ForceCameraPosition(pos, rot);
		}

		internal void SetStateRawPosition(Vector3 pos)
		{
			m_State.RawPosition = pos;
		}

		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
			base.OnTransitionFromCamera(fromCam, worldUp, deltaTime);
			InvokeOnTransitionInExtensions(fromCam, worldUp, deltaTime);
			bool flag = false;
			if (m_Transitions.m_InheritPosition && fromCam != null)
			{
				ForceCameraPosition(fromCam.State.FinalPosition, fromCam.State.FinalOrientation);
			}
			UpdateComponentPipeline();
			if (m_ComponentPipeline != null)
			{
				for (int i = 0; i < m_ComponentPipeline.Length; i++)
				{
					if (m_ComponentPipeline[i].OnTransitionFromCamera(fromCam, worldUp, deltaTime, ref m_Transitions))
					{
						flag = true;
					}
				}
			}
			if (flag)
			{
				InternalUpdateCameraState(worldUp, deltaTime);
				InternalUpdateCameraState(worldUp, deltaTime);
			}
			else
			{
				UpdateCameraState(worldUp, deltaTime);
			}
			if (m_Transitions.m_OnCameraLive != null)
			{
				m_Transitions.m_OnCameraLive.Invoke(this, fromCam);
			}
		}
	}
}
