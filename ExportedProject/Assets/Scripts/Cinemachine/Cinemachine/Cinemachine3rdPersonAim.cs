using UnityEngine;

namespace Cinemachine
{
	[AddComponentMenu("")]
	[ExecuteAlways]
	[SaveDuringPlay]
	[DisallowMultipleComponent]
	public class Cinemachine3rdPersonAim : CinemachineExtension
	{
		[Header("Aim Target Detection")]
		[Tooltip("Objects on these layers will be detected")]
		public LayerMask AimCollisionFilter;

		[TagField]
		[Tooltip("Objects with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
		public string IgnoreTag = string.Empty;

		[Tooltip("How far to project the object detection ray")]
		public float AimDistance;

		[Tooltip("This 2D object will be positioned in the game view over the raycast hit point, if any, or will remain in the center of the screen if no hit point is detected.  May be null, in which case no on-screen indicator will appear")]
		public RectTransform AimTargetReticle;

		private void OnValidate()
		{
			AimDistance = Mathf.Max(1f, AimDistance);
		}

		private void Reset()
		{
			AimCollisionFilter = 1;
			IgnoreTag = string.Empty;
			AimDistance = 200f;
			AimTargetReticle = null;
		}

		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
			CinemachineCore.CameraUpdatedEvent.RemoveListener(DrawReticle);
			CinemachineCore.CameraUpdatedEvent.AddListener(DrawReticle);
			return false;
		}

		private void DrawReticle(CinemachineBrain brain)
		{
			if (!brain.IsLive(base.VirtualCamera) || brain.OutputCamera == null)
			{
				CinemachineCore.CameraUpdatedEvent.RemoveListener(DrawReticle);
				return;
			}
			Transform follow = base.VirtualCamera.Follow;
			if (AimTargetReticle != null && follow != null)
			{
				Vector3 position = follow.position;
				Vector3 vector = base.VirtualCamera.State.ReferenceLookAt;
				Vector3 direction = vector - position;
				if (RuntimeUtility.RaycastIgnoreTag(new Ray(position, direction), out var hitInfo, direction.magnitude, AimCollisionFilter, in IgnoreTag))
				{
					vector = hitInfo.point;
				}
				AimTargetReticle.position = brain.OutputCamera.WorldToScreenPoint(vector);
			}
		}

		private Vector3 GetLookAtPoint(ref CameraState state)
		{
			Vector3 vector = state.CorrectedOrientation * Vector3.forward;
			Vector3 correctedPosition = state.CorrectedPosition;
			float num = AimDistance;
			Transform follow = base.VirtualCamera.Follow;
			if (follow != null)
			{
				Vector3 vector2 = Quaternion.Inverse(state.CorrectedOrientation) * (follow.position - correctedPosition);
				if (vector2.z > 0f)
				{
					correctedPosition += vector * vector2.z;
					num -= vector2.z;
				}
			}
			num = Mathf.Max(1f, num);
			if (!RuntimeUtility.RaycastIgnoreTag(new Ray(correctedPosition, vector), out var hitInfo, num, AimCollisionFilter, in IgnoreTag))
			{
				return correctedPosition + vector * num;
			}
			return hitInfo.point;
		}

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
			if (stage == CinemachineCore.Stage.Body)
			{
				state.ReferenceLookAt = GetLookAtPoint(ref state);
			}
			if (stage == CinemachineCore.Stage.Finalize)
			{
				Vector3 forward = state.ReferenceLookAt - state.FinalPosition;
				if (forward.sqrMagnitude > 0.01f)
				{
					state.RawOrientation = Quaternion.LookRotation(forward, state.ReferenceUp);
					state.OrientationCorrection = Quaternion.identity;
				}
			}
		}
	}
}
