using System;

namespace UnityEngine.U2D.Animation
{
	[AddComponentMenu("")]
	[Obsolete]
	internal class SpriteSkinEntity : MonoBehaviour
	{
		private void OnEnable()
		{
			Debug.LogWarning("SpriteSkinEntity will be removed in 2D Animation 7.0", this);
		}
	}
}
