using System.Collections.Generic;

namespace UnityEngine.U2D.Animation
{
	internal class SpriteLibrarySourceAsset : ScriptableObject
	{
		[SerializeField]
		private List<SpriteLibCategoryOverride> m_Library = new List<SpriteLibCategoryOverride>();

		[SerializeField]
		private string m_PrimaryLibraryGUID;

		public List<SpriteLibCategoryOverride> library
		{
			get
			{
				return m_Library;
			}
			set
			{
				m_Library = value;
			}
		}

		public string primaryLibraryID
		{
			get
			{
				return m_PrimaryLibraryGUID;
			}
			set
			{
				m_PrimaryLibraryGUID = value;
			}
		}
	}
}
