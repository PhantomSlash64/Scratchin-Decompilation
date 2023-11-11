using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine.Rendering;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.U2D.Common;

namespace UnityEngine.U2D.Animation
{
	[Preserve]
	[ExecuteInEditMode]
	[DefaultExecutionOrder(-1)]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(SpriteRenderer))]
	[AddComponentMenu("2D Animation/Sprite Skin")]
	[MovedFrom("UnityEngine.U2D.Experimental.Animation")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.2d.animation@latest/index.html?subfolder=/manual/index.html%23sprite-skin-component")]
	public sealed class SpriteSkin : MonoBehaviour, ISerializationCallbackReceiver
	{
		[SerializeField]
		private Transform m_RootBone;

		[SerializeField]
		private Transform[] m_BoneTransforms = new Transform[0];

		[SerializeField]
		private Bounds m_Bounds;

		[SerializeField]
		private bool m_UseBatching = true;

		[SerializeField]
		private bool m_AlwaysUpdate = true;

		[SerializeField]
		private bool m_AutoRebind;

		private NativeByteArray m_DeformedVertices;

		private int m_CurrentDeformVerticesLength;

		private SpriteRenderer m_SpriteRenderer;

		private int m_CurrentDeformSprite;

		private bool m_ForceSkinning;

		private bool m_BatchSkinning;

		private bool m_IsValid;

		private int m_TransformsHash;

		internal bool batchSkinning
		{
			get
			{
				return m_BatchSkinning;
			}
			set
			{
				m_BatchSkinning = value;
			}
		}

		internal bool autoRebind
		{
			get
			{
				return m_AutoRebind;
			}
			set
			{
				m_AutoRebind = value;
				CacheCurrentSprite(m_AutoRebind);
			}
		}

		internal Sprite sprite => spriteRenderer.sprite;

		internal SpriteRenderer spriteRenderer => m_SpriteRenderer;

		public Transform[] boneTransforms
		{
			get
			{
				return m_BoneTransforms;
			}
			internal set
			{
				m_BoneTransforms = value;
				CacheValidFlag();
				OnBoneTransformChanged();
			}
		}

		public Transform rootBone
		{
			get
			{
				return m_RootBone;
			}
			internal set
			{
				m_RootBone = value;
				CacheValidFlag();
				OnRootBoneTransformChanged();
			}
		}

		internal Bounds bounds
		{
			get
			{
				return m_Bounds;
			}
			set
			{
				m_Bounds = value;
			}
		}

		public bool alwaysUpdate
		{
			get
			{
				return m_AlwaysUpdate;
			}
			set
			{
				m_AlwaysUpdate = value;
			}
		}

		internal bool isValid => this.Validate() == SpriteSkinValidationResult.Ready;

		private int GetSpriteInstanceID()
		{
			if (!(sprite != null))
			{
				return 0;
			}
			return sprite.GetInstanceID();
		}

		internal void Awake()
		{
			m_SpriteRenderer = GetComponent<SpriteRenderer>();
		}

		private void OnEnable()
		{
			Awake();
			m_TransformsHash = 0;
			CacheCurrentSprite(rebind: false);
			OnEnableBatch();
		}

		internal void OnEditorEnable()
		{
			Awake();
		}

		private void CacheValidFlag()
		{
			m_IsValid = isValid;
			if (!m_IsValid)
			{
				DeactivateSkinning();
			}
		}

		private void Reset()
		{
			Awake();
			if (base.isActiveAndEnabled)
			{
				CacheValidFlag();
				OnResetBatch();
			}
		}

		internal void UseBatching(bool value)
		{
			if (m_UseBatching != value)
			{
				m_UseBatching = value;
				UseBatchingBatch();
			}
		}

		internal NativeByteArray GetDeformedVertices(int spriteVertexCount)
		{
			if (sprite != null)
			{
				if (m_CurrentDeformVerticesLength != spriteVertexCount)
				{
					m_TransformsHash = 0;
					m_CurrentDeformVerticesLength = spriteVertexCount;
				}
			}
			else
			{
				m_CurrentDeformVerticesLength = 0;
			}
			m_DeformedVertices = BufferManager.instance.GetBuffer(GetInstanceID(), m_CurrentDeformVerticesLength);
			return m_DeformedVertices;
		}

		public bool HasCurrentDeformedVertices()
		{
			if (!m_IsValid)
			{
				return false;
			}
			if (m_CurrentDeformVerticesLength > 0)
			{
				return m_DeformedVertices.IsCreated;
			}
			return false;
		}

		internal NativeArray<byte> GetCurrentDeformedVertices()
		{
			if (!m_IsValid)
			{
				throw new InvalidOperationException("The SpriteSkin deformation is not valid.");
			}
			if (m_CurrentDeformVerticesLength <= 0)
			{
				throw new InvalidOperationException("There are no currently deformed vertices.");
			}
			if (!m_DeformedVertices.IsCreated)
			{
				throw new InvalidOperationException("There are no currently deformed vertices.");
			}
			return m_DeformedVertices.array;
		}

		internal NativeSlice<PositionVertex> GetCurrentDeformedVertexPositions()
		{
			if (sprite.HasVertexAttribute(VertexAttribute.Tangent))
			{
				throw new InvalidOperationException("This SpriteSkin has deformed tangents");
			}
			if (!sprite.HasVertexAttribute(VertexAttribute.Position))
			{
				throw new InvalidOperationException("This SpriteSkin does not have deformed positions.");
			}
			return GetCurrentDeformedVertices().Slice().SliceConvert<PositionVertex>();
		}

		internal NativeSlice<PositionTangentVertex> GetCurrentDeformedVertexPositionsAndTangents()
		{
			if (!sprite.HasVertexAttribute(VertexAttribute.Tangent))
			{
				throw new InvalidOperationException("This SpriteSkin does not have deformed tangents");
			}
			if (!sprite.HasVertexAttribute(VertexAttribute.Position))
			{
				throw new InvalidOperationException("This SpriteSkin does not have deformed positions.");
			}
			return GetCurrentDeformedVertices().Slice().SliceConvert<PositionTangentVertex>();
		}

		public IEnumerable<Vector3> GetDeformedVertexPositionData()
		{
			if (!sprite.HasVertexAttribute(VertexAttribute.Position))
			{
				throw new InvalidOperationException("Sprite does not have vertex position data.");
			}
			return new NativeCustomSliceEnumerator<Vector3>(GetCurrentDeformedVertices().Slice(sprite.GetVertexStreamOffset(VertexAttribute.Position)), sprite.GetVertexCount(), sprite.GetVertexStreamSize());
		}

		public IEnumerable<Vector4> GetDeformedVertexTangentData()
		{
			if (!sprite.HasVertexAttribute(VertexAttribute.Tangent))
			{
				throw new InvalidOperationException("Sprite does not have vertex tangent data.");
			}
			return new NativeCustomSliceEnumerator<Vector4>(GetCurrentDeformedVertices().Slice(sprite.GetVertexStreamOffset(VertexAttribute.Tangent)), sprite.GetVertexCount(), sprite.GetVertexStreamSize());
		}

		private void OnDisable()
		{
			DeactivateSkinning();
			BufferManager.instance.ReturnBuffer(GetInstanceID());
			OnDisableBatch();
		}

		private void LateUpdate()
		{
			CacheCurrentSprite(m_AutoRebind);
			if (isValid && !batchSkinning && base.enabled && (alwaysUpdate || spriteRenderer.isVisible))
			{
				int num = this.CalculateTransformHash();
				int num2 = sprite.GetVertexStreamSize() * sprite.GetVertexCount();
				if (num2 > 0 && m_TransformsHash != num)
				{
					NativeByteArray deformedVertices = GetDeformedVertices(num2);
					SpriteSkinUtility.Deform(sprite, base.gameObject.transform.worldToLocalMatrix, boneTransforms, deformedVertices.array);
					this.UpdateBounds(deformedVertices.array);
					InternalEngineBridge.SetDeformableBuffer(spriteRenderer, deformedVertices.array);
					m_TransformsHash = num;
					m_CurrentDeformSprite = GetSpriteInstanceID();
				}
			}
		}

		private void CacheCurrentSprite(bool rebind)
		{
			if (m_CurrentDeformSprite == GetSpriteInstanceID())
			{
				return;
			}
			DeactivateSkinning();
			m_CurrentDeformSprite = GetSpriteInstanceID();
			if (rebind && m_CurrentDeformSprite > 0 && rootBone != null)
			{
				SpriteBone[] bones = sprite.GetBones();
				Transform[] outTransform = new Transform[bones.Length];
				if (GetSpriteBonesTransforms(bones, rootBone, outTransform))
				{
					boneTransforms = outTransform;
				}
			}
			UpdateSpriteDeform();
			CacheValidFlag();
			m_TransformsHash = 0;
		}

		internal static bool GetSpriteBonesTransforms(SpriteBone[] spriteBones, Transform rootBone, Transform[] outTransform)
		{
			if (rootBone == null)
			{
				throw new ArgumentException("rootBone parameter cannot be null");
			}
			if (spriteBones == null)
			{
				throw new ArgumentException("spritebone parameter cannot be null");
			}
			if (outTransform == null)
			{
				throw new ArgumentException("outTransform parameter cannot be null");
			}
			if (spriteBones.Length != outTransform.Length)
			{
				throw new ArgumentException("spritebone and outTransform array length must be the same");
			}
			Bone[] componentsInChildren = rootBone.GetComponentsInChildren<Bone>();
			if (componentsInChildren != null && componentsInChildren.Length >= spriteBones.Length)
			{
				int i;
				for (i = 0; i < spriteBones.Length; i++)
				{
					string boneHash = spriteBones[i].guid;
					Bone bone = Array.Find(componentsInChildren, (Bone x) => x.guid == boneHash);
					if (bone == null)
					{
						break;
					}
					outTransform[i] = bone.transform;
				}
				if (i >= spriteBones.Length)
				{
					return true;
				}
			}
			return GetSpriteBonesTranformFromPath(spriteBones, rootBone, outTransform);
		}

		private static bool GetSpriteBonesTranformFromPath(SpriteBone[] spriteBones, Transform rootBone, Transform[] outNewBoneTransform)
		{
			string[] array = new string[spriteBones.Length];
			for (int i = 0; i < spriteBones.Length; i++)
			{
				if (array[i] == null)
				{
					CalculateBoneTransformsPath(i, spriteBones, array);
				}
				if (rootBone.name == spriteBones[i].name)
				{
					outNewBoneTransform[i] = rootBone;
					continue;
				}
				Transform transform = rootBone.Find(array[i]);
				if (transform == null)
				{
					return false;
				}
				outNewBoneTransform[i] = transform;
			}
			return true;
		}

		private static void CalculateBoneTransformsPath(int index, SpriteBone[] spriteBones, string[] paths)
		{
			SpriteBone spriteBone = spriteBones[index];
			int parentId = spriteBone.parentId;
			string text = spriteBone.name;
			if (parentId != -1 && spriteBones[parentId].parentId != -1)
			{
				if (paths[parentId] == null)
				{
					CalculateBoneTransformsPath(spriteBone.parentId, spriteBones, paths);
				}
				paths[index] = $"{paths[parentId]}/{text}";
			}
			else
			{
				paths[index] = text;
			}
		}

		private void OnDestroy()
		{
			DeactivateSkinning();
		}

		internal void DeactivateSkinning()
		{
			Sprite sprite = spriteRenderer.sprite;
			if (sprite != null)
			{
				InternalEngineBridge.SetLocalAABB(spriteRenderer, sprite.bounds);
			}
			spriteRenderer.DeactivateDeformableBuffer();
		}

		internal void ResetSprite()
		{
			m_CurrentDeformSprite = 0;
			CacheValidFlag();
		}

		public void OnBeforeSerialize()
		{
			OnBeforeSerializeBatch();
		}

		public void OnAfterDeserialize()
		{
			OnAfterSerializeBatch();
		}

		private void OnEnableBatch()
		{
		}

		internal void UpdateSpriteDeform()
		{
		}

		private void OnResetBatch()
		{
		}

		private void UseBatchingBatch()
		{
		}

		private void OnDisableBatch()
		{
		}

		private void OnBoneTransformChanged()
		{
		}

		private void OnRootBoneTransformChanged()
		{
		}

		private void OnBeforeSerializeBatch()
		{
		}

		private void OnAfterSerializeBatch()
		{
		}
	}
}
