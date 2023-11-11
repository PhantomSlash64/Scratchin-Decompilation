using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D.Animation
{
	[DisallowMultipleComponent]
	[AddComponentMenu("2D Animation/Sprite Library")]
	[MovedFrom("UnityEngine.Experimental.U2D.Animation")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.animation@latest/index.html?subfolder=/manual/SLAsset.html%23sprite-library-component")]
	public class SpriteLibrary : MonoBehaviour
	{
		private struct CategoryEntrySprite
		{
			public string category;

			public string entry;

			public Sprite sprite;
		}

		[SerializeField]
		private List<SpriteLibCategory> m_Library = new List<SpriteLibCategory>();

		[SerializeField]
		private SpriteLibraryAsset m_SpriteLibraryAsset;

		private Dictionary<int, CategoryEntrySprite> m_CategoryEntryHashCache;

		private Dictionary<string, HashSet<string>> m_CategoryEntryCache;

		private int m_PreviousSpriteLibraryAsset;

		private long m_PreviousModificationHash;

		public SpriteLibraryAsset spriteLibraryAsset
		{
			get
			{
				return m_SpriteLibraryAsset;
			}
			set
			{
				if (m_SpriteLibraryAsset != value)
				{
					m_SpriteLibraryAsset = value;
					CacheOverrides();
					RefreshSpriteResolvers();
				}
			}
		}

		internal IEnumerable<string> categoryNames
		{
			get
			{
				UpdateCacheOverridesIfNeeded();
				return m_CategoryEntryCache.Keys;
			}
		}

		private void OnEnable()
		{
			CacheOverrides();
		}

		public Sprite GetSprite(string category, string label)
		{
			return GetSprite(GetHashForCategoryAndEntry(category, label));
		}

		internal Sprite GetSprite(int hash)
		{
			if (m_CategoryEntryHashCache.ContainsKey(hash))
			{
				return m_CategoryEntryHashCache[hash].sprite;
			}
			return null;
		}

		private void UpdateCacheOverridesIfNeeded()
		{
			if (m_CategoryEntryCache == null || m_PreviousSpriteLibraryAsset != m_SpriteLibraryAsset?.GetInstanceID() || m_PreviousModificationHash != m_SpriteLibraryAsset?.modificationHash)
			{
				CacheOverrides();
			}
		}

		internal bool GetCategoryAndEntryNameFromHash(int hash, out string category, out string entry)
		{
			UpdateCacheOverridesIfNeeded();
			if (m_CategoryEntryHashCache.ContainsKey(hash))
			{
				category = m_CategoryEntryHashCache[hash].category;
				entry = m_CategoryEntryHashCache[hash].entry;
				return true;
			}
			category = null;
			entry = null;
			return false;
		}

		internal static int GetHashForCategoryAndEntry(string category, string entry)
		{
			return SpriteLibraryAsset.GetStringHash($"{category}_{entry}");
		}

		internal Sprite GetSpriteFromCategoryAndEntryHash(int hash, out bool validEntry)
		{
			UpdateCacheOverridesIfNeeded();
			if (m_CategoryEntryHashCache.ContainsKey(hash))
			{
				validEntry = true;
				return m_CategoryEntryHashCache[hash].sprite;
			}
			validEntry = false;
			return null;
		}

		private List<SpriteCategoryEntry> GetEntries(string category, bool addIfNotExist)
		{
			int num = m_Library.FindIndex((SpriteLibCategory x) => x.name == category);
			if (num < 0)
			{
				if (!addIfNotExist)
				{
					return null;
				}
				m_Library.Add(new SpriteLibCategory
				{
					name = category,
					categoryList = new List<SpriteCategoryEntry>()
				});
				num = m_Library.Count - 1;
			}
			return m_Library[num].categoryList;
		}

		private SpriteCategoryEntry GetEntry(List<SpriteCategoryEntry> entries, string entry, bool addIfNotExist)
		{
			int num = entries.FindIndex((SpriteCategoryEntry x) => x.name == entry);
			if (num < 0)
			{
				if (!addIfNotExist)
				{
					return null;
				}
				entries.Add(new SpriteCategoryEntry
				{
					name = entry
				});
				num = entries.Count - 1;
			}
			return entries[num];
		}

		public void AddOverride(SpriteLibraryAsset spriteLib, string category, string label)
		{
			Sprite sprite = spriteLib.GetSprite(category, label);
			List<SpriteCategoryEntry> entries = GetEntries(category, addIfNotExist: true);
			GetEntry(entries, label, addIfNotExist: true).sprite = sprite;
			CacheOverrides();
		}

		public void AddOverride(SpriteLibraryAsset spriteLib, string category)
		{
			int categoryHash = SpriteLibraryAsset.GetStringHash(category);
			SpriteLibCategory spriteLibCategory = spriteLib.categories.FirstOrDefault((SpriteLibCategory x) => x.hash == categoryHash);
			if (spriteLibCategory != null)
			{
				List<SpriteCategoryEntry> entries = GetEntries(category, addIfNotExist: true);
				for (int i = 0; i < spriteLibCategory.categoryList.Count; i++)
				{
					SpriteCategoryEntry spriteCategoryEntry = spriteLibCategory.categoryList[i];
					GetEntry(entries, spriteCategoryEntry.name, addIfNotExist: true).sprite = spriteCategoryEntry.sprite;
				}
				CacheOverrides();
			}
		}

		public void AddOverride(Sprite sprite, string category, string label)
		{
			GetEntry(GetEntries(category, addIfNotExist: true), label, addIfNotExist: true).sprite = sprite;
			CacheOverrides();
			RefreshSpriteResolvers();
		}

		public void RemoveOverride(string category)
		{
			int num = m_Library.FindIndex((SpriteLibCategory x) => x.name == category);
			if (num >= 0)
			{
				m_Library.RemoveAt(num);
				CacheOverrides();
				RefreshSpriteResolvers();
			}
		}

		public void RemoveOverride(string category, string label)
		{
			List<SpriteCategoryEntry> entries = GetEntries(category, addIfNotExist: false);
			if (entries != null)
			{
				int num = entries.FindIndex((SpriteCategoryEntry x) => x.name == label);
				if (num >= 0)
				{
					entries.RemoveAt(num);
					CacheOverrides();
					RefreshSpriteResolvers();
				}
			}
		}

		public bool HasOverride(string category, string label)
		{
			List<SpriteCategoryEntry> entries = GetEntries(category, addIfNotExist: false);
			if (entries != null)
			{
				return GetEntry(entries, label, addIfNotExist: false) != null;
			}
			return false;
		}

		public void RefreshSpriteResolvers()
		{
			SpriteResolver[] componentsInChildren = GetComponentsInChildren<SpriteResolver>();
			for (int i = 0; i < componentsInChildren.Length; i++)
			{
				componentsInChildren[i].ResolveSpriteToSpriteRenderer();
			}
		}

		internal IEnumerable<string> GetEntryNames(string category)
		{
			UpdateCacheOverridesIfNeeded();
			if (m_CategoryEntryCache.ContainsKey(category))
			{
				return m_CategoryEntryCache[category];
			}
			return null;
		}

		internal void CacheOverrides()
		{
			m_PreviousSpriteLibraryAsset = 0;
			m_PreviousModificationHash = 0L;
			m_CategoryEntryHashCache = new Dictionary<int, CategoryEntrySprite>();
			m_CategoryEntryCache = new Dictionary<string, HashSet<string>>();
			if ((bool)m_SpriteLibraryAsset)
			{
				m_PreviousSpriteLibraryAsset = m_SpriteLibraryAsset.GetInstanceID();
				m_PreviousModificationHash = m_SpriteLibraryAsset.modificationHash;
				foreach (SpriteLibCategory category in m_SpriteLibraryAsset.categories)
				{
					string text = category.name;
					m_CategoryEntryCache.Add(text, new HashSet<string>());
					HashSet<string> hashSet = m_CategoryEntryCache[text];
					foreach (SpriteCategoryEntry category2 in category.categoryList)
					{
						m_CategoryEntryHashCache.Add(GetHashForCategoryAndEntry(text, category2.name), new CategoryEntrySprite
						{
							category = text,
							entry = category2.name,
							sprite = category2.sprite
						});
						hashSet.Add(category2.name);
					}
				}
			}
			foreach (SpriteLibCategory item in m_Library)
			{
				string text2 = item.name;
				if (!m_CategoryEntryCache.ContainsKey(text2))
				{
					m_CategoryEntryCache.Add(text2, new HashSet<string>());
				}
				HashSet<string> hashSet2 = m_CategoryEntryCache[text2];
				foreach (SpriteCategoryEntry category3 in item.categoryList)
				{
					if (!hashSet2.Contains(category3.name))
					{
						hashSet2.Add(category3.name);
					}
					int hashForCategoryAndEntry = GetHashForCategoryAndEntry(text2, category3.name);
					if (!m_CategoryEntryHashCache.ContainsKey(hashForCategoryAndEntry))
					{
						m_CategoryEntryHashCache.Add(hashForCategoryAndEntry, new CategoryEntrySprite
						{
							category = text2,
							entry = category3.name,
							sprite = category3.sprite
						});
					}
					else
					{
						CategoryEntrySprite value = m_CategoryEntryHashCache[hashForCategoryAndEntry];
						value.sprite = category3.sprite;
						m_CategoryEntryHashCache[hashForCategoryAndEntry] = value;
					}
				}
			}
		}
	}
}
