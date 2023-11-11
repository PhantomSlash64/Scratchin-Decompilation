using System;

namespace UnityEngine.U2D.Animation
{
	[Serializable]
	internal class SpriteCategoryEntryOverride : SpriteCategoryEntry
	{
		[SerializeField]
		private bool m_FromMain;

		[SerializeField]
		private Sprite m_SpriteOverride;

		public bool fromMain
		{
			get
			{
				return m_FromMain;
			}
			set
			{
				m_FromMain = value;
			}
		}

		public Sprite spriteOverride
		{
			get
			{
				return m_SpriteOverride;
			}
			set
			{
				m_SpriteOverride = value;
			}
		}
	}
}
