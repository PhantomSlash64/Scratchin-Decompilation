using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D.Animation
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.animation@latest/index.html?subfolder=/manual/SLAsset.html")]
	[MovedFrom("UnityEngine.Experimental.U2D.Animation")]
	public class SpriteLibraryAsset : ScriptableObject
	{
		[SerializeField]
		private List<SpriteLibCategory> m_Labels = new List<SpriteLibCategory>();

		[SerializeField]
		private long m_ModificationHash;

		internal static Func<string, int> GetStringHash = Default_GetStringHash;

		internal List<SpriteLibCategory> categories
		{
			get
			{
				return m_Labels;
			}
			set
			{
				m_Labels = value;
				ValidateCategories();
				UpdateModificationHash();
			}
		}

		internal long modificationHash => m_ModificationHash;

		internal static SpriteLibraryAsset CreateAsset(List<SpriteLibCategory> categories, string assetName, long version)
		{
			SpriteLibraryAsset spriteLibraryAsset = ScriptableObject.CreateInstance<SpriteLibraryAsset>();
			spriteLibraryAsset.m_Labels = categories;
			spriteLibraryAsset.ValidateCategories();
			spriteLibraryAsset.name = assetName;
			spriteLibraryAsset.UpdateHashes();
			spriteLibraryAsset.m_ModificationHash = version;
			return spriteLibraryAsset;
		}

		internal Sprite GetSprite(int categoryHash, int labelHash)
		{
			SpriteLibCategory spriteLibCategory = m_Labels.FirstOrDefault((SpriteLibCategory x) => x.hash == categoryHash);
			if (spriteLibCategory != null)
			{
				SpriteCategoryEntry spriteCategoryEntry = spriteLibCategory.categoryList.FirstOrDefault((SpriteCategoryEntry x) => x.hash == labelHash);
				if (spriteCategoryEntry != null)
				{
					return spriteCategoryEntry.sprite;
				}
			}
			return null;
		}

		internal Sprite GetSprite(int categoryHash, int labelHash, out bool validEntry)
		{
			SpriteLibCategory spriteLibCategory = null;
			for (int i = 0; i < m_Labels.Count; i++)
			{
				if (m_Labels[i].hash == categoryHash)
				{
					spriteLibCategory = m_Labels[i];
					break;
				}
			}
			if (spriteLibCategory != null)
			{
				SpriteCategoryEntry spriteCategoryEntry = null;
				for (int j = 0; j < spriteLibCategory.categoryList.Count; j++)
				{
					if (spriteLibCategory.categoryList[j].hash == labelHash)
					{
						spriteCategoryEntry = spriteLibCategory.categoryList[j];
						break;
					}
				}
				if (spriteCategoryEntry != null)
				{
					validEntry = true;
					return spriteCategoryEntry.sprite;
				}
			}
			validEntry = false;
			return null;
		}

		public Sprite GetSprite(string category, string label)
		{
			int categoryHash = GetStringHash(category);
			int labelHash = GetStringHash(label);
			return GetSprite(categoryHash, labelHash);
		}

		public IEnumerable<string> GetCategoryNames()
		{
			return m_Labels.Select((SpriteLibCategory x) => x.name);
		}

		[Obsolete("GetCategorylabelNames has been deprecated. Please use GetCategoryLabelNames (UnityUpgradable) -> GetCategoryLabelNames(*)")]
		public IEnumerable<string> GetCategorylabelNames(string category)
		{
			return GetCategoryLabelNames(category);
		}

		public IEnumerable<string> GetCategoryLabelNames(string category)
		{
			SpriteLibCategory spriteLibCategory = m_Labels.FirstOrDefault((SpriteLibCategory x) => x.name == category);
			if (spriteLibCategory != null)
			{
				return spriteLibCategory.categoryList.Select((SpriteCategoryEntry x) => x.name);
			}
			return new string[0];
		}

		public void AddCategoryLabel(Sprite sprite, string category, string label)
		{
			category = category.Trim();
			label = label?.Trim();
			if (string.IsNullOrEmpty(category))
			{
				throw new ArgumentException("Cannot add empty or null Category string");
			}
			int catHash = GetStringHash(category);
			SpriteCategoryEntry spriteCategoryEntry = null;
			SpriteLibCategory spriteLibCategory = null;
			spriteLibCategory = m_Labels.FirstOrDefault((SpriteLibCategory x) => x.hash == catHash);
			if (spriteLibCategory != null)
			{
				if (string.IsNullOrEmpty(label))
				{
					throw new ArgumentException("Cannot add empty or null Label string");
				}
				int labelHash = GetStringHash(label);
				spriteCategoryEntry = spriteLibCategory.categoryList.FirstOrDefault((SpriteCategoryEntry y) => y.hash == labelHash);
				if (spriteCategoryEntry != null)
				{
					spriteCategoryEntry.sprite = sprite;
				}
				else
				{
					spriteCategoryEntry = new SpriteCategoryEntry
					{
						name = label,
						sprite = sprite
					};
					spriteLibCategory.categoryList.Add(spriteCategoryEntry);
				}
			}
			else
			{
				SpriteLibCategory spriteLibCategory2 = new SpriteLibCategory
				{
					categoryList = new List<SpriteCategoryEntry>(),
					name = category
				};
				if (!string.IsNullOrEmpty(label))
				{
					spriteLibCategory2.categoryList.Add(new SpriteCategoryEntry
					{
						name = label,
						sprite = sprite
					});
				}
				m_Labels.Add(spriteLibCategory2);
			}
			UpdateModificationHash();
		}

		public void RemoveCategoryLabel(string category, string label, bool deleteCategory)
		{
			int catHash = GetStringHash(category);
			SpriteLibCategory libCategory = null;
			libCategory = m_Labels.FirstOrDefault((SpriteLibCategory x) => x.hash == catHash);
			if (libCategory == null)
			{
				return;
			}
			int labelHash = GetStringHash(label);
			libCategory.categoryList.RemoveAll((SpriteCategoryEntry x) => x.hash == labelHash);
			if (deleteCategory && libCategory.categoryList.Count == 0)
			{
				m_Labels.RemoveAll((SpriteLibCategory x) => x.hash == libCategory.hash);
			}
			UpdateModificationHash();
		}

		internal void UpdateHashes()
		{
			foreach (SpriteLibCategory label in m_Labels)
			{
				label.UpdateHash();
			}
		}

		internal void ValidateCategories()
		{
			RenameDuplicate(m_Labels, delegate(string originalName, string newName)
			{
				Debug.LogWarning("Category " + originalName + " renamed to " + newName + " due to hash clash");
			});
			for (int i = 0; i < m_Labels.Count; i++)
			{
				m_Labels[i].ValidateLabels();
			}
		}

		internal static void RenameDuplicate(IEnumerable<INameHash> nameHashList, Action<string, string> onRename)
		{
			for (int i = 0; i < nameHashList.Count(); i++)
			{
				INameHash category = nameHashList.ElementAt(i);
				IEnumerable<INameHash> source = nameHashList.Where((INameHash x) => (x.hash == category.hash || x.name == category.name) && x != category);
				int j = 0;
				for (int k = 0; k < source.Count(); k++)
				{
					INameHash categoryClash = source.ElementAt(k);
					for (; j < 1000; j++)
					{
						string name = categoryClash.name;
						name = $"{name}_{j}";
						int nameHash = GetStringHash(name);
						if (nameHashList.FirstOrDefault((INameHash x) => (x.hash == nameHash || x.name == name) && x != categoryClash) == null)
						{
							onRename(categoryClash.name, name);
							categoryClash.name = name;
							break;
						}
					}
				}
			}
		}

		internal static int Default_GetStringHash(string value)
		{
			byte[] bytes = BitConverter.GetBytes(Animator.StringToHash(value));
			int num = ((!BitConverter.IsLittleEndian) ? 1 : 3);
			if (bytes[num] == byte.MaxValue)
			{
				bytes[num]--;
			}
			return BitConverter.ToInt32(bytes, 0);
		}

		private void UpdateModificationHash()
		{
			long ticks = DateTime.Now.Ticks;
			ticks ^= m_Labels.GetHashCode();
			m_ModificationHash = ticks;
		}
	}
}
