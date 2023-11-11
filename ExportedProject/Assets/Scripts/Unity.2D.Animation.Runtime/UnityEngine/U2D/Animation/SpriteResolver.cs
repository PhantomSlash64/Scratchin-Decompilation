using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D.Animation
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[AddComponentMenu("2D Animation/Sprite Resolver")]
	[DefaultExecutionOrder(-2)]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.animation@latest/index.html?subfolder=/manual/SLAsset.html%23sprite-resolver-component")]
	[MovedFrom("UnityEngine.Experimental.U2D.Animation")]
	public class SpriteResolver : MonoBehaviour, ISerializationCallbackReceiver
	{
		[SerializeField]
		private float m_CategoryHash;

		[SerializeField]
		private float m_labelHash;

		[SerializeField]
		private float m_SpriteKey;

		private int m_CategoryHashInt;

		private int m_LabelHashInt;

		private int m_SpriteKeyInt;

		private int m_PreviousCategoryHash;

		private int m_PreviouslabelHash;

		private int m_PreviousSpriteKeyInt;

		private SpriteRenderer spriteRenderer => GetComponent<SpriteRenderer>();

		public SpriteLibrary spriteLibrary => base.gameObject.GetComponentInParent<SpriteLibrary>(includeInactive: true);

		private int spriteKeyInt
		{
			get
			{
				return m_SpriteKeyInt;
			}
			set
			{
				m_SpriteKeyInt = value;
				m_SpriteKey = ConvertIntToFloat(m_SpriteKeyInt);
			}
		}

		private void Reset()
		{
			if ((bool)spriteRenderer)
			{
				SetSprite(spriteRenderer.sprite);
			}
		}

		private void SetSprite(Sprite sprite)
		{
			SpriteLibrary spriteLibrary = this.spriteLibrary;
			if (!(spriteLibrary != null) || !(sprite != null))
			{
				return;
			}
			foreach (string categoryName in spriteLibrary.categoryNames)
			{
				foreach (string entryName in spriteLibrary.GetEntryNames(categoryName))
				{
					if (spriteLibrary.GetSprite(categoryName, entryName) == sprite)
					{
						spriteKeyInt = SpriteLibrary.GetHashForCategoryAndEntry(categoryName, entryName);
						return;
					}
				}
			}
		}

		private void OnEnable()
		{
			m_CategoryHashInt = ConvertFloatToInt(m_CategoryHash);
			m_PreviousCategoryHash = m_CategoryHashInt;
			m_LabelHashInt = ConvertFloatToInt(m_labelHash);
			m_PreviouslabelHash = m_LabelHashInt;
			m_SpriteKeyInt = ConvertFloatToInt(m_SpriteKey);
			if (m_SpriteKeyInt == 0)
			{
				m_SpriteKey = ConvertCategoryLabelHashToSpriteKey(spriteLibrary, m_CategoryHashInt, m_LabelHashInt);
				m_SpriteKeyInt = ConvertFloatToInt(m_SpriteKey);
			}
			m_PreviousSpriteKeyInt = m_SpriteKeyInt;
			ResolveSpriteToSpriteRenderer();
		}

		public void SetCategoryAndLabel(string category, string label)
		{
			spriteKeyInt = SpriteLibrary.GetHashForCategoryAndEntry(category, label);
			m_PreviousSpriteKeyInt = spriteKeyInt;
			ResolveSpriteToSpriteRenderer();
		}

		public string GetCategory()
		{
			string category = "";
			SpriteLibrary spriteLibrary = this.spriteLibrary;
			if ((bool)spriteLibrary)
			{
				spriteLibrary.GetCategoryAndEntryNameFromHash(spriteKeyInt, out category, out var _);
			}
			return category;
		}

		public string GetLabel()
		{
			string entry = "";
			SpriteLibrary spriteLibrary = this.spriteLibrary;
			if ((bool)spriteLibrary)
			{
				spriteLibrary.GetCategoryAndEntryNameFromHash(spriteKeyInt, out var _, out entry);
			}
			return entry;
		}

		private void LateUpdate()
		{
			m_SpriteKeyInt = ConvertFloatToInt(m_SpriteKey);
			if (m_SpriteKeyInt != m_PreviousSpriteKeyInt)
			{
				m_PreviousSpriteKeyInt = m_SpriteKeyInt;
				ResolveSpriteToSpriteRenderer();
				return;
			}
			m_CategoryHashInt = ConvertFloatToInt(m_CategoryHash);
			m_LabelHashInt = ConvertFloatToInt(m_labelHash);
			if ((m_LabelHashInt != m_PreviouslabelHash || m_CategoryHashInt != m_PreviousCategoryHash) && spriteLibrary != null)
			{
				m_PreviousCategoryHash = m_CategoryHashInt;
				m_PreviouslabelHash = m_LabelHashInt;
				m_SpriteKey = ConvertCategoryLabelHashToSpriteKey(spriteLibrary, m_CategoryHashInt, m_LabelHashInt);
				m_SpriteKeyInt = ConvertFloatToInt(m_SpriteKey);
				m_PreviousSpriteKeyInt = m_SpriteKeyInt;
				ResolveSpriteToSpriteRenderer();
			}
		}

		internal static float ConvertCategoryLabelHashToSpriteKey(SpriteLibrary library, int categoryHash, int labelHash)
		{
			if (library != null)
			{
				foreach (string categoryName in library.categoryNames)
				{
					if (categoryHash != SpriteLibraryAsset.GetStringHash(categoryName))
					{
						continue;
					}
					IEnumerable<string> entryNames = library.GetEntryNames(categoryName);
					if (entryNames == null)
					{
						continue;
					}
					foreach (string item in entryNames)
					{
						if (labelHash == SpriteLibraryAsset.GetStringHash(item))
						{
							return ConvertIntToFloat(SpriteLibrary.GetHashForCategoryAndEntry(categoryName, item));
						}
					}
				}
			}
			return 0f;
		}

		internal Sprite GetSprite(out bool validEntry)
		{
			SpriteLibrary spriteLibrary = this.spriteLibrary;
			if (spriteLibrary != null)
			{
				return spriteLibrary.GetSpriteFromCategoryAndEntryHash(m_SpriteKeyInt, out validEntry);
			}
			validEntry = false;
			return null;
		}

		public void ResolveSpriteToSpriteRenderer()
		{
			m_PreviousSpriteKeyInt = m_SpriteKeyInt;
			bool validEntry;
			Sprite sprite = GetSprite(out validEntry);
			SpriteRenderer spriteRenderer = this.spriteRenderer;
			if (spriteRenderer != null && (sprite != null || validEntry))
			{
				spriteRenderer.sprite = sprite;
			}
		}

		private void OnTransformParentChanged()
		{
			ResolveSpriteToSpriteRenderer();
		}

		internal unsafe static int ConvertFloatToInt(float f)
		{
			int* ptr = (int*)(&f);
			return *ptr;
		}

		internal unsafe static float ConvertIntToFloat(int f)
		{
			float* ptr = (float*)(&f);
			return *ptr;
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
		}
	}
}
