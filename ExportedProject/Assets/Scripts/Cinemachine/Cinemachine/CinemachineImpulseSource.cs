using UnityEngine;

namespace Cinemachine
{
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	[SaveDuringPlay]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.7/manual/CinemachineImpulseSourceOverview.html")]
	public class CinemachineImpulseSource : MonoBehaviour
	{
		[CinemachineImpulseDefinitionProperty]
		public CinemachineImpulseDefinition m_ImpulseDefinition = new CinemachineImpulseDefinition();

		private void OnValidate()
		{
			m_ImpulseDefinition.OnValidate();
		}

		public void GenerateImpulseAt(Vector3 position, Vector3 velocity)
		{
			if (m_ImpulseDefinition != null)
			{
				m_ImpulseDefinition.CreateEvent(position, velocity);
			}
		}

		public void GenerateImpulse(Vector3 velocity)
		{
			GenerateImpulseAt(base.transform.position, velocity);
		}

		public void GenerateImpulse(float force)
		{
			GenerateImpulseAt(base.transform.position, new Vector3(0f, 0f - force, 0f));
		}

		public void GenerateImpulse()
		{
			GenerateImpulse(Vector3.down);
		}
	}
}
