using System;
using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D.Animation
{
	[Serializable]
	[MovedFrom("UnityEngine.Experimental.U2D.Animation")]
	internal class SpriteLibCategory : INameHash
	{
		[SerializeField]
		private string m_Name;

		[SerializeField]
		private int m_Hash;

		[SerializeField]
		private List<SpriteCategoryEntry> m_CategoryList;

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

		public List<SpriteCategoryEntry> categoryList
		{
			get
			{
				return m_CategoryList;
			}
			set
			{
				m_CategoryList = value;
			}
		}

		public void UpdateHash()
		{
			m_Hash = SpriteLibraryAsset.GetStringHash(m_Name);
			foreach (SpriteCategoryEntry category in m_CategoryList)
			{
				category.UpdateHash();
			}
		}

		internal void ValidateLabels()
		{
			SpriteLibraryAsset.RenameDuplicate(m_CategoryList, delegate(string originalName, string newName)
			{
				Debug.LogWarning($"Label {originalName} renamed to {newName} due to hash clash");
			});
		}
	}
}
