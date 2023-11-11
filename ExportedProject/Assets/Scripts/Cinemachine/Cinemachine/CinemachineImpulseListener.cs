using UnityEngine;

namespace Cinemachine
{
	[SaveDuringPlay]
	[AddComponentMenu("")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.7/manual/CinemachineImpulseListener.html")]
	public class CinemachineImpulseListener : CinemachineExtension
	{
		[Tooltip("When to apply the impulse reaction.  Default is after the Noise stage.  Modify this if necessary to influence the ordering of extension effects")]
		public CinemachineCore.Stage m_ApplyAfter = CinemachineCore.Stage.Aim;

		[Tooltip("Impulse events on channels not included in the mask will be ignored.")]
		[CinemachineImpulseChannelProperty]
		public int m_ChannelMask;

		[Tooltip("Gain to apply to the Impulse signal.  1 is normal strength.  Setting this to 0 completely mutes the signal.")]
		public float m_Gain;

		[Tooltip("Enable this to perform distance calculation in 2D (ignore Z)")]
		public bool m_Use2DDistance;

		private void Reset()
		{
			m_ApplyAfter = CinemachineCore.Stage.Noise;
			m_ChannelMask = 1;
			m_Gain = 1f;
			m_Use2DDistance = false;
		}

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
			if (stage == m_ApplyAfter)
			{
				Vector3 pos = Vector3.zero;
				Quaternion rot = Quaternion.identity;
				if (CinemachineImpulseManager.Instance.GetImpulseAt(state.FinalPosition, m_Use2DDistance, m_ChannelMask, out pos, out rot))
				{
					state.PositionCorrection += pos * (0f - m_Gain);
					rot = Quaternion.SlerpUnclamped(Quaternion.identity, rot, 0f - m_Gain);
					state.OrientationCorrection *= rot;
				}
			}
		}
	}
}
