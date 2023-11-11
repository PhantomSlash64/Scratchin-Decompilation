namespace UnityEngine.U2D.Animation
{
	[AddComponentMenu("")]
	internal class Bone : MonoBehaviour
	{
		[SerializeField]
		[HideInInspector]
		private string m_Guid;

		public string guid
		{
			get
			{
				return m_Guid;
			}
			set
			{
				m_Guid = value;
			}
		}
	}
}
