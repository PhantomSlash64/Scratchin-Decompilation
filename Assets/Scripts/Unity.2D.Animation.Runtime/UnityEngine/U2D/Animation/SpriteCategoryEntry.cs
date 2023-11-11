using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D.Animation
{
	[Serializable]
	[MovedFrom("UnityEngine.Experimental.U2D.Animation")]
	internal class SpriteCategoryEntry : INameHash
	{
		[SerializeField]
		private string m_Name;

		[SerializeField]
		[HideInInspector]
		private int m_Hash;

		[SerializeField]
		private Sprite m_Sprite;

		public string name
		{
			get
			{
				return m_Name;
			}
			set
			{
				m_Name = value;
				m_Hash = SpriteLibraryAsset.GetStringHash(m_Name);
			}
		}

		public int hash => m_Hash;

		public Sprite sprite
		{
			get
			{
				return m_Sprite;
			}
			set
			{
				m_Sprite = value;
			}
		}

		public void UpdateHash()
		{
			m_Hash = SpriteLibraryAsset.GetStringHash(m_Name);
		}
	}
}
