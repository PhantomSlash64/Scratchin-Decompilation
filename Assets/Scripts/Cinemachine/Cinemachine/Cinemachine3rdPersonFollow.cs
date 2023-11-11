using Cinemachine.Utility;
using UnityEngine;

namespace Cinemachine
{
	[AddComponentMenu("")]
	[SaveDuringPlay]
	public class Cinemachine3rdPersonFollow : CinemachineComponentBase
	{
		[Tooltip("How responsively the camera tracks the target.  Each axis (camera-local) can have its own setting.  Value is the approximate time it takes the camera to catch up to the target's new position.  Smaller values give a more rigid effect, larger values give a squishier one")]
		public Vector3 Damping;

		[Header("Rig")]
		[Tooltip("Position of the shoulder pivot relative to the Follow target origin.  This offset is in target-local space")]
		public Vector3 ShoulderOffset;

		[Tooltip("Vertical offset of the hand in relation to the shoulder.  Arm length will affect the follow target's screen position when the camera rotates vertically")]
		public float VerticalArmLength;

		[Tooltip("Specifies which shoulder (left, right, or in-between) the camera is on")]
		[Range(0f, 1f)]
		public float CameraSide;

		[Tooltip("How far baehind the hand the camera will be placed")]
		public float CameraDistance;

		[Header("Obstacles")]
		[Tooltip("Camera will avoid obstacles on these layers")]
		public LayerMask CameraCollisionFilter;

		[TagField]
		[Tooltip("Obstacles with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
		public string IgnoreTag = string.Empty;

		[Tooltip("Specifies how close the camera can get to obstacles")]
		[Range(0f, 1f)]
		public float CameraRadius;

		private Vector3 m_PreviousFollowTargetPosition;

		private Vector3 m_DampingCorrection;

		public override bool IsValid
		{
			get
			{
				if (base.enabled)
				{
					return base.FollowTarget != null;
				}
				return false;
			}
		}

		public override CinemachineCore.Stage Stage => CinemachineCore.Stage.Body;

		private void OnValidate()
		{
			CameraSide = Mathf.Clamp(CameraSide, -1f, 1f);
			Damping.x = Mathf.Max(0f, Damping.x);
			Damping.y = Mathf.Max(0f, Damping.y);
			Damping.z = Mathf.Max(0f, Damping.z);
			CameraRadius = Mathf.Max(0.001f, CameraRadius);
		}

		private void Reset()
		{
			ShoulderOffset = new Vector3(0.5f, -0.4f, 0f);
			VerticalArmLength = 0.4f;
			CameraSide = 1f;
			CameraDistance = 2f;
			Damping = new Vector3(0.1f, 0.5f, 0.3f);
			CameraCollisionFilter = 0;
			CameraRadius = 0.2f;
		}

		private void OnDestroy()
		{
			RuntimeUtility.DestroyScratchCollider();
		}

		public override float GetMaxDampTime()
		{
			return Mathf.Max(Damping.x, Mathf.Max(Damping.y, Damping.z));
		}

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
			if (IsValid)
			{
				if (!base.VirtualCamera.PreviousStateIsValid)
				{
					deltaTime = -1f;
				}
				PositionCamera(ref curState, deltaTime);
			}
		}

		private void PositionCamera(ref CameraState curState, float deltaTime)
		{
			Vector3 referenceUp = curState.ReferenceUp;
			Vector3 followTargetPosition = base.FollowTargetPosition;
			Quaternion followTargetRotation = base.FollowTargetRotation;
			Vector3 vector = followTargetRotation * Vector3.forward;
			Quaternion heading = GetHeading(vector, referenceUp);
			if (deltaTime < 0f)
			{
				m_DampingCorrection = Vector3.zero;
			}
			else
			{
				m_DampingCorrection += Quaternion.Inverse(heading) * (m_PreviousFollowTargetPosition - followTargetPosition);
				m_DampingCorrection -= base.VirtualCamera.DetachedFollowTargetDamp(m_DampingCorrection, Damping, deltaTime);
			}
			m_PreviousFollowTargetPosition = followTargetPosition;
			Vector3 root = followTargetPosition;
			GetRawRigPositions(root, followTargetRotation, heading, out var _, out var hand);
			Vector3 root2 = ResolveCollisions(root, hand, CameraRadius * 1.05f);
			Vector3 tip = hand - vector * (CameraDistance - m_DampingCorrection.z);
			tip = ResolveCollisions(root2, tip, CameraRadius);
			curState.RawPosition = tip;
			curState.RawOrientation = followTargetRotation;
			curState.ReferenceUp = referenceUp;
		}

		public void GetRigPositions(out Vector3 root, out Vector3 shoulder, out Vector3 hand)
		{
			Vector3 referenceUp = base.VirtualCamera.State.ReferenceUp;
			Quaternion followTargetRotation = base.FollowTargetRotation;
			Vector3 targetForward = followTargetRotation * Vector3.forward;
			Quaternion heading = GetHeading(targetForward, referenceUp);
			root = m_PreviousFollowTargetPosition;
			GetRawRigPositions(root, followTargetRotation, heading, out shoulder, out hand);
			hand = ResolveCollisions(root, hand, CameraRadius * 1.05f);
		}

		private Quaternion GetHeading(Vector3 targetForward, Vector3 up)
		{
			Vector3 v = targetForward.ProjectOntoPlane(up);
			return Quaternion.AngleAxis(UnityVectorExtensions.SignedAngle(Vector3.forward, v, up), up);
		}

		private void GetRawRigPositions(Vector3 root, Quaternion targetRot, Quaternion heading, out Vector3 shoulder, out Vector3 hand)
		{
			Vector3 vector = Vector3.Lerp(Vector3.Reflect(ShoulderOffset, Vector3.right), ShoulderOffset, CameraSide);
			vector.x += m_DampingCorrection.x;
			vector.y += m_DampingCorrection.y;
			shoulder = root + heading * vector;
			hand = shoulder + targetRot * new Vector3(0f, VerticalArmLength, 0f);
		}

		private Vector3 ResolveCollisions(Vector3 root, Vector3 tip, float cameraRadius)
		{
			if (CameraCollisionFilter.value == 0)
			{
				return tip;
			}
			Vector3 vector = tip - root;
			float magnitude = vector.magnitude;
			vector /= magnitude;
			Vector3 result = tip;
			float num = 0f;
			if (RuntimeUtility.SphereCastIgnoreTag(root, cameraRadius, vector, out var hitInfo, magnitude, CameraCollisionFilter, in IgnoreTag))
			{
				num = (hitInfo.point + hitInfo.normal * cameraRadius - tip).magnitude;
			}
			if (num > 0.0001f)
			{
				result -= vector * num;
			}
			return result;
		}
	}
}
