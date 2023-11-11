using System;
using Cinemachine.Utility;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[AddComponentMenu("")]
	[SaveDuringPlay]
	public class CinemachineOrbitalTransposer : CinemachineTransposer
	{
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public struct Heading
		{
			[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
			public enum HeadingDefinition
			{
				PositionDelta = 0,
				Velocity = 1,
				TargetForward = 2,
				WorldForward = 3
			}

			[FormerlySerializedAs("m_HeadingDefinition")]
			[Tooltip("How 'forward' is defined.  The camera will be placed by default behind the target.  PositionDelta will consider 'forward' to be the direction in which the target is moving.")]
			public HeadingDefinition m_Definition;

			[Range(0f, 10f)]
			[Tooltip("Size of the velocity sampling window for target heading filter.  This filters out irregularities in the target's movement.  Used only if deriving heading from target's movement (PositionDelta or Velocity)")]
			public int m_VelocityFilterStrength;

			[Range(-180f, 180f)]
			[FormerlySerializedAs("m_HeadingBias")]
			[Tooltip("Where the camera is placed when the X-axis value is zero.  This is a rotation in degrees around the Y axis.  When this value is 0, the camera will be placed behind the target.  Nonzero offsets will rotate the zero position around the target.")]
			public float m_Bias;

			public Heading(HeadingDefinition def, int filterStrength, float bias)
			{
				m_Definition = def;
				m_VelocityFilterStrength = filterStrength;
				m_Bias = bias;
			}
		}

		internal delegate float UpdateHeadingDelegate(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up);

		[Space]
		[OrbitalTransposerHeadingProperty]
		[Tooltip("The definition of Forward.  Camera will follow behind.")]
		public Heading m_Heading = new Heading(Heading.HeadingDefinition.TargetForward, 4, 0f);

		[Tooltip("Automatic heading recentering.  The settings here defines how the camera will reposition itself in the absence of player input.")]
		public AxisState.Recentering m_RecenterToTargetHeading = new AxisState.Recentering(enabled: true, 1f, 2f);

		[Tooltip("Heading Control.  The settings here control the behaviour of the camera in response to the player's input.")]
		[AxisStateProperty]
		public AxisState m_XAxis = new AxisState(-180f, 180f, wrap: true, rangeLocked: false, 300f, 0.1f, 0.1f, "Mouse X", invert: true);

		[SerializeField]
		[HideInInspector]
		[FormerlySerializedAs("m_Radius")]
		private float m_LegacyRadius = float.MaxValue;

		[SerializeField]
		[HideInInspector]
		[FormerlySerializedAs("m_HeightOffset")]
		private float m_LegacyHeightOffset = float.MaxValue;

		[SerializeField]
		[HideInInspector]
		[FormerlySerializedAs("m_HeadingBias")]
		private float m_LegacyHeadingBias = float.MaxValue;

		[HideInInspector]
		[NoSaveDuringPlay]
		public bool m_HeadingIsSlave;

		internal UpdateHeadingDelegate HeadingUpdater = (CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up) => orbital.UpdateHeading(deltaTime, up, ref orbital.m_XAxis, ref orbital.m_RecenterToTargetHeading, CinemachineCore.Instance.IsLive(orbital.VirtualCamera));

		private Vector3 mLastTargetPosition = Vector3.zero;

		private HeadingTracker mHeadingTracker;

		private Rigidbody mTargetRigidBody;

		private Vector3 mLastCameraPosition;

		private Transform PreviousTarget { get; set; }

		private float LastHeading { get; set; }

		protected override void OnValidate()
		{
			if (m_LegacyRadius != float.MaxValue && m_LegacyHeightOffset != float.MaxValue && m_LegacyHeadingBias != float.MaxValue)
			{
				m_FollowOffset = new Vector3(0f, m_LegacyHeightOffset, 0f - m_LegacyRadius);
				m_LegacyHeightOffset = (m_LegacyRadius = float.MaxValue);
				m_Heading.m_Bias = m_LegacyHeadingBias;
				m_XAxis.m_MaxSpeed /= 10f;
				m_XAxis.m_AccelTime /= 10f;
				m_XAxis.m_DecelTime /= 10f;
				m_LegacyHeadingBias = float.MaxValue;
				int heading = (int)m_Heading.m_Definition;
				if (m_RecenterToTargetHeading.LegacyUpgrade(ref heading, ref m_Heading.m_VelocityFilterStrength))
				{
					m_Heading.m_Definition = (Heading.HeadingDefinition)heading;
				}
			}
			m_XAxis.Validate();
			m_RecenterToTargetHeading.Validate();
			base.OnValidate();
		}

		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis)
		{
			return UpdateHeading(deltaTime, up, ref axis, ref m_RecenterToTargetHeading, isLive: true);
		}

		public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis, ref AxisState.Recentering recentering, bool isLive)
		{
			if (m_BindingMode == BindingMode.SimpleFollowWithWorldUp)
			{
				axis.m_MinValue = -180f;
				axis.m_MaxValue = 180f;
			}
			if (deltaTime < 0f || !base.VirtualCamera.PreviousStateIsValid || !isLive)
			{
				axis.Reset();
				recentering.CancelRecentering();
			}
			else if (axis.Update(deltaTime))
			{
				recentering.CancelRecentering();
			}
			if (m_BindingMode == BindingMode.SimpleFollowWithWorldUp)
			{
				float value = axis.Value;
				axis.Value = 0f;
				return value;
			}
			float targetHeading = GetTargetHeading(axis.Value, GetReferenceOrientation(up));
			recentering.DoRecentering(ref axis, deltaTime, targetHeading);
			return axis.Value;
		}

		private void OnEnable()
		{
			PreviousTarget = null;
			mLastTargetPosition = Vector3.zero;
			UpdateInputAxisProvider();
		}

		public void UpdateInputAxisProvider()
		{
			m_XAxis.SetInputAxisProvider(0, null);
			if (!m_HeadingIsSlave && base.VirtualCamera != null)
			{
				AxisState.IInputAxisProvider inputAxisProvider = base.VirtualCamera.GetInputAxisProvider();
				if (inputAxisProvider != null)
				{
					m_XAxis.SetInputAxisProvider(0, inputAxisProvider);
				}
			}
		}

		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
			base.OnTargetObjectWarped(target, positionDelta);
			if (target == base.FollowTarget)
			{
				mLastTargetPosition += positionDelta;
				mLastCameraPosition += positionDelta;
			}
		}

		public override void ForceCameraPosition(Vector3 pos, Quaternion rot)
		{
			base.ForceCameraPosition(pos, rot);
			mLastCameraPosition = pos;
			m_XAxis.Value = GetAxisClosestValue(pos, base.VirtualCamera.State.ReferenceUp);
		}

		public override bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref CinemachineVirtualCameraBase.TransitionParams transitionParams)
		{
			m_RecenterToTargetHeading.DoRecentering(ref m_XAxis, -1f, 0f);
			m_RecenterToTargetHeading.CancelRecentering();
			if (fromCam != null && m_BindingMode != BindingMode.SimpleFollowWithWorldUp && transitionParams.m_InheritPosition)
			{
				m_XAxis.Value = GetAxisClosestValue(fromCam.State.RawPosition, worldUp);
				return true;
			}
			return false;
		}

		public float GetAxisClosestValue(Vector3 cameraPos, Vector3 up)
		{
			Quaternion referenceOrientation = GetReferenceOrientation(up);
			if (!(referenceOrientation * Vector3.forward).ProjectOntoPlane(up).AlmostZero() && base.FollowTarget != null)
			{
				float num = 0f;
				if (m_BindingMode != BindingMode.SimpleFollowWithWorldUp)
				{
					num += m_Heading.m_Bias;
				}
				referenceOrientation *= Quaternion.AngleAxis(num, up);
				Vector3 followTargetPosition = base.FollowTargetPosition;
				Vector3 from = (followTargetPosition + referenceOrientation * base.EffectiveOffset - followTargetPosition).ProjectOntoPlane(up);
				Vector3 to = (cameraPos - followTargetPosition).ProjectOntoPlane(up);
				return Vector3.SignedAngle(from, to, up);
			}
			return LastHeading;
		}

		public override void MutateCameraState(ref CameraState curState, float deltaTime)
		{
			InitPrevFrameStateInfo(ref curState, deltaTime);
			if (base.FollowTarget != PreviousTarget)
			{
				PreviousTarget = base.FollowTarget;
				mTargetRigidBody = ((PreviousTarget == null) ? null : PreviousTarget.GetComponent<Rigidbody>());
				mLastTargetPosition = ((PreviousTarget == null) ? Vector3.zero : PreviousTarget.position);
				mHeadingTracker = null;
			}
			LastHeading = HeadingUpdater(this, deltaTime, curState.ReferenceUp);
			float num = LastHeading;
			if (!IsValid)
			{
				return;
			}
			if (m_BindingMode != BindingMode.SimpleFollowWithWorldUp)
			{
				num += m_Heading.m_Bias;
			}
			Quaternion quaternion = Quaternion.AngleAxis(num, Vector3.up);
			Vector3 effectiveOffset = base.EffectiveOffset;
			Vector3 vector = quaternion * effectiveOffset;
			TrackTarget(deltaTime, curState.ReferenceUp, vector, out var outTargetPosition, out var outTargetOrient);
			vector = outTargetOrient * vector;
			curState.ReferenceUp = outTargetOrient * Vector3.up;
			Vector3 followTargetPosition = base.FollowTargetPosition;
			outTargetPosition += GetOffsetForMinimumTargetDistance(outTargetPosition, vector, curState.RawOrientation * Vector3.forward, curState.ReferenceUp, followTargetPosition);
			curState.RawPosition = outTargetPosition + vector;
			if (deltaTime >= 0f && base.VirtualCamera.PreviousStateIsValid)
			{
				Vector3 vector2 = followTargetPosition;
				if (base.LookAtTarget != null)
				{
					vector2 = base.LookAtTargetPosition;
				}
				Vector3 v = mLastCameraPosition - vector2;
				Vector3 v2 = curState.RawPosition - vector2;
				if (v.sqrMagnitude > 0.01f && v2.sqrMagnitude > 0.01f)
				{
					curState.PositionDampingBypass = UnityVectorExtensions.SafeFromToRotation(v, v2, curState.ReferenceUp).eulerAngles;
				}
			}
			mLastTargetPosition = followTargetPosition;
			mLastCameraPosition = curState.RawPosition;
		}

		public override Vector3 GetTargetCameraPosition(Vector3 worldUp)
		{
			if (!IsValid)
			{
				return Vector3.zero;
			}
			float num = LastHeading;
			if (m_BindingMode != BindingMode.SimpleFollowWithWorldUp)
			{
				num += m_Heading.m_Bias;
			}
			Quaternion quaternion = Quaternion.AngleAxis(num, Vector3.up);
			quaternion = GetReferenceOrientation(worldUp) * quaternion;
			return quaternion * base.EffectiveOffset + mLastTargetPosition;
		}

		private float GetTargetHeading(float currentHeading, Quaternion targetOrientation)
		{
			if (m_BindingMode == BindingMode.SimpleFollowWithWorldUp)
			{
				return 0f;
			}
			if (base.FollowTarget == null)
			{
				return currentHeading;
			}
			Heading.HeadingDefinition headingDefinition = m_Heading.m_Definition;
			if (headingDefinition == Heading.HeadingDefinition.Velocity && mTargetRigidBody == null)
			{
				headingDefinition = Heading.HeadingDefinition.PositionDelta;
			}
			Vector3 zero = Vector3.zero;
			switch (headingDefinition)
			{
			case Heading.HeadingDefinition.Velocity:
				zero = mTargetRigidBody.velocity;
				break;
			case Heading.HeadingDefinition.PositionDelta:
				zero = base.FollowTargetPosition - mLastTargetPosition;
				break;
			case Heading.HeadingDefinition.TargetForward:
				zero = base.FollowTargetRotation * Vector3.forward;
				break;
			default:
				return 0f;
			}
			Vector3 vector = targetOrientation * Vector3.up;
			zero = zero.ProjectOntoPlane(vector);
			if (headingDefinition != Heading.HeadingDefinition.TargetForward)
			{
				int num = m_Heading.m_VelocityFilterStrength * 5;
				if (mHeadingTracker == null || mHeadingTracker.FilterSize != num)
				{
					mHeadingTracker = new HeadingTracker(num);
				}
				mHeadingTracker.DecayHistory();
				if (!zero.AlmostZero())
				{
					mHeadingTracker.Add(zero);
				}
				zero = mHeadingTracker.GetReliableHeading();
			}
			if (!zero.AlmostZero())
			{
				return UnityVectorExtensions.SignedAngle(targetOrientation * Vector3.forward, zero, vector);
			}
			return currentHeading;
		}
	}
}
