using System;
using System.Collections.Generic;

namespace UnityEngine.U2D.Animation
{
	[Serializable]
	internal class SpriteLibCategoryOverride : SpriteLibCategory
	{
		[SerializeField]
		private List<SpriteCategoryEntryOverride> m_OverrideEntries;

		[SerializeField]
		private bool m_FromMain;

		[SerializeField]
		private int m_EntryOverrideCount;

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

		public int entryOverrideCount
		{
			get
			{
				return m_EntryOverrideCount;
			}
			set
			{
				m_EntryOverrideCount = value;
			}
		}

		public List<SpriteCategoryEntryOverride> overrideEntries
		{
			get
			{
				return m_OverrideEntries;
			}
			set
			{
				m_OverrideEntries = value;
			}
		}
	}
}
