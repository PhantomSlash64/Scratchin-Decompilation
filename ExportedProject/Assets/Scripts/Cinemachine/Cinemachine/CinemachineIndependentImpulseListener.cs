using UnityEngine;

namespace Cinemachine
{
	[SaveDuringPlay]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.7/api/Cinemachine.CinemachineIndependentImpulseListener.html")]
	public class CinemachineIndependentImpulseListener : MonoBehaviour
	{
		private Vector3 impulsePosLastFrame;

		private Quaternion impulseRotLastFrame;

		[Tooltip("Impulse events on channels not included in the mask will be ignored.")]
		[CinemachineImpulseChannelProperty]
		public int m_ChannelMask;

		[Tooltip("Gain to apply to the Impulse signal.  1 is normal strength.  Setting this to 0 completely mutes the signal.")]
		public float m_Gain;

		[Tooltip("Enable this to perform distance calculation in 2D (ignore Z)")]
		public bool m_Use2DDistance;

		private void Reset()
		{
			m_ChannelMask = 1;
			m_Gain = 1f;
			m_Use2DDistance = false;
		}

		private void OnEnable()
		{
			impulsePosLastFrame = Vector3.zero;
			impulseRotLastFrame = Quaternion.identity;
		}

		private void Update()
		{
			base.transform.position -= impulsePosLastFrame;
			base.transform.rotation = base.transform.rotation * Quaternion.Inverse(impulseRotLastFrame);
		}

		private void LateUpdate()
		{
			if (CinemachineImpulseManager.Instance.GetImpulseAt(base.transform.position, m_Use2DDistance, m_ChannelMask, out impulsePosLastFrame, out impulseRotLastFrame))
			{
				impulsePosLastFrame *= m_Gain;
				impulseRotLastFrame = Quaternion.SlerpUnclamped(Quaternion.identity, impulseRotLastFrame, 0f - m_Gain);
				base.transform.position += impulsePosLastFrame;
				base.transform.rotation = base.transform.rotation * impulseRotLastFrame;
			}
		}
	}
}
