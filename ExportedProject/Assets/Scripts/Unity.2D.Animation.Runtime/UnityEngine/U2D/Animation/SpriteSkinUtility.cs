using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Mathematics;
using UnityEngine.Rendering;
using UnityEngine.U2D.Common;

namespace UnityEngine.U2D.Animation
{
	internal static class SpriteSkinUtility
	{
		internal static SpriteSkinValidationResult Validate(this SpriteSkin spriteSkin)
		{
			if (spriteSkin.spriteRenderer.sprite == null)
			{
				return SpriteSkinValidationResult.SpriteNotFound;
			}
			NativeArray<Matrix4x4> bindPoses = spriteSkin.spriteRenderer.sprite.GetBindPoses();
			if (bindPoses.Length == 0)
			{
				return SpriteSkinValidationResult.SpriteHasNoSkinningInformation;
			}
			if (spriteSkin.rootBone == null)
			{
				return SpriteSkinValidationResult.RootTransformNotFound;
			}
			if (spriteSkin.boneTransforms == null)
			{
				return SpriteSkinValidationResult.InvalidTransformArray;
			}
			if (bindPoses.Length != spriteSkin.boneTransforms.Length)
			{
				return SpriteSkinValidationResult.InvalidTransformArrayLength;
			}
			bool flag = false;
			Transform[] boneTransforms = spriteSkin.boneTransforms;
			foreach (Transform transform in boneTransforms)
			{
				if (transform == null)
				{
					return SpriteSkinValidationResult.TransformArrayContainsNull;
				}
				if (transform == spriteSkin.rootBone)
				{
					flag = true;
				}
			}
			if (!flag)
			{
				return SpriteSkinValidationResult.RootNotFoundInTransformArray;
			}
			return SpriteSkinValidationResult.Ready;
		}

		internal static void CreateBoneHierarchy(this SpriteSkin spriteSkin)
		{
			if (spriteSkin.spriteRenderer.sprite == null)
			{
				throw new InvalidOperationException("SpriteRenderer has no Sprite set");
			}
			SpriteBone[] bones = spriteSkin.spriteRenderer.sprite.GetBones();
			Transform[] array = new Transform[bones.Length];
			Transform transform = null;
			for (int i = 0; i < bones.Length; i++)
			{
				CreateGameObject(i, bones, array, spriteSkin.transform);
				if (bones[i].parentId < 0 && transform == null)
				{
					transform = array[i];
				}
			}
			spriteSkin.rootBone = transform;
			spriteSkin.boneTransforms = array;
		}

		internal static int GetVertexStreamSize(this Sprite sprite)
		{
			int num = 12;
			if (sprite.HasVertexAttribute(VertexAttribute.Normal))
			{
				num += 12;
			}
			if (sprite.HasVertexAttribute(VertexAttribute.Tangent))
			{
				num += 16;
			}
			return num;
		}

		internal static int GetVertexStreamOffset(this Sprite sprite, VertexAttribute channel)
		{
			bool flag = sprite.HasVertexAttribute(VertexAttribute.Position);
			bool flag2 = sprite.HasVertexAttribute(VertexAttribute.Normal);
			bool flag3 = sprite.HasVertexAttribute(VertexAttribute.Tangent);
			switch (channel)
			{
			case VertexAttribute.Position:
				if (!flag)
				{
					return -1;
				}
				return 0;
			case VertexAttribute.Normal:
				if (!flag2)
				{
					return -1;
				}
				return 12;
			case VertexAttribute.Tangent:
				if (!flag3)
				{
					return -1;
				}
				if (!flag2)
				{
					return 12;
				}
				return 24;
			default:
				return -1;
			}
		}

		private static void CreateGameObject(int index, SpriteBone[] spriteBones, Transform[] transforms, Transform root)
		{
			if (transforms[index] == null)
			{
				SpriteBone spriteBone = spriteBones[index];
				if (spriteBone.parentId >= 0)
				{
					CreateGameObject(spriteBone.parentId, spriteBones, transforms, root);
				}
				Transform transform = new GameObject(spriteBone.name).transform;
				if (spriteBone.parentId >= 0)
				{
					transform.SetParent(transforms[spriteBone.parentId]);
				}
				else
				{
					transform.SetParent(root);
				}
				transform.localPosition = spriteBone.position;
				transform.localRotation = spriteBone.rotation;
				transform.localScale = Vector3.one;
				transforms[index] = transform;
			}
		}

		internal static void ResetBindPose(this SpriteSkin spriteSkin)
		{
			if (!spriteSkin.isValid)
			{
				throw new InvalidOperationException("SpriteSkin is not valid");
			}
			SpriteBone[] bones = spriteSkin.spriteRenderer.sprite.GetBones();
			Transform[] boneTransforms = spriteSkin.boneTransforms;
			for (int i = 0; i < boneTransforms.Length; i++)
			{
				Transform transform = boneTransforms[i];
				SpriteBone spriteBone = bones[i];
				if (spriteBone.parentId != -1)
				{
					transform.localPosition = spriteBone.position;
					transform.localRotation = spriteBone.rotation;
					transform.localScale = Vector3.one;
				}
			}
		}

		private unsafe static int GetHash(Matrix4x4 matrix)
		{
			uint* ptr = (uint*)(&matrix);
			char* pBuffer = (char*)ptr;
			return (int)math.hash(pBuffer, 64);
		}

		internal static int CalculateTransformHash(this SpriteSkin spriteSkin)
		{
			int num = 0;
			int num2 = GetHash(spriteSkin.transform.localToWorldMatrix) >> num;
			num++;
			Transform[] boneTransforms = spriteSkin.boneTransforms;
			foreach (Transform transform in boneTransforms)
			{
				num2 ^= GetHash(transform.localToWorldMatrix) >> num;
				num = (num + 1) % 8;
			}
			return num2;
		}

		internal unsafe static void Deform(Sprite sprite, Matrix4x4 rootInv, NativeSlice<Vector3> vertices, NativeSlice<Vector4> tangents, NativeSlice<BoneWeight> boneWeights, NativeArray<Matrix4x4> boneTransforms, NativeSlice<Matrix4x4> bindPoses, NativeArray<byte> deformableVertices)
		{
			NativeSlice<float3> vertices2 = vertices.SliceWithStride<float3>();
			NativeSlice<float4> tangents2 = tangents.SliceWithStride<float4>();
			NativeSlice<float4x4> bindPoses2 = bindPoses.SliceWithStride<float4x4>();
			int vertexCount = sprite.GetVertexCount();
			int vertexStreamSize = sprite.GetVertexStreamSize();
			NativeArray<float4x4> boneTransforms2 = NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<float4x4>(boneTransforms.GetUnsafePtr(), boneTransforms.Length, Allocator.None);
			byte* unsafePtr = (byte*)deformableVertices.GetUnsafePtr();
			NativeSlice<float3> deformed = NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<float3>(unsafePtr, vertexStreamSize, vertexCount);
			NativeSlice<float4> deformedTangents = NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<float4>(unsafePtr, vertexStreamSize, 1);
			if (sprite.HasVertexAttribute(VertexAttribute.Tangent))
			{
				deformedTangents = NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<float4>(unsafePtr + sprite.GetVertexStreamOffset(VertexAttribute.Tangent), vertexStreamSize, vertexCount);
			}
			if (sprite.HasVertexAttribute(VertexAttribute.Tangent))
			{
				Deform(rootInv, vertices2, tangents2, boneWeights, boneTransforms2, bindPoses2, deformed, deformedTangents);
			}
			else
			{
				Deform(rootInv, vertices2, boneWeights, boneTransforms2, bindPoses2, deformed);
			}
		}

		internal static void Deform(float4x4 rootInv, NativeSlice<float3> vertices, NativeSlice<BoneWeight> boneWeights, NativeArray<float4x4> boneTransforms, NativeSlice<float4x4> bindPoses, NativeSlice<float3> deformed)
		{
			if (boneTransforms.Length != 0)
			{
				for (int i = 0; i < boneTransforms.Length; i++)
				{
					float4x4 b = bindPoses[i];
					float4x4 a = boneTransforms[i];
					boneTransforms[i] = math.mul(rootInv, math.mul(a, b));
				}
				for (int j = 0; j < vertices.Length; j++)
				{
					int boneIndex = boneWeights[j].boneIndex0;
					int boneIndex2 = boneWeights[j].boneIndex1;
					int boneIndex3 = boneWeights[j].boneIndex2;
					int boneIndex4 = boneWeights[j].boneIndex3;
					float3 b2 = vertices[j];
					deformed[j] = math.transform(boneTransforms[boneIndex], b2) * boneWeights[j].weight0 + math.transform(boneTransforms[boneIndex2], b2) * boneWeights[j].weight1 + math.transform(boneTransforms[boneIndex3], b2) * boneWeights[j].weight2 + math.transform(boneTransforms[boneIndex4], b2) * boneWeights[j].weight3;
				}
			}
		}

		internal static void Deform(float4x4 rootInv, NativeSlice<float3> vertices, NativeSlice<float4> tangents, NativeSlice<BoneWeight> boneWeights, NativeArray<float4x4> boneTransforms, NativeSlice<float4x4> bindPoses, NativeSlice<float3> deformed, NativeSlice<float4> deformedTangents)
		{
			if (boneTransforms.Length != 0)
			{
				for (int i = 0; i < boneTransforms.Length; i++)
				{
					float4x4 b = bindPoses[i];
					float4x4 a = boneTransforms[i];
					boneTransforms[i] = math.mul(rootInv, math.mul(a, b));
				}
				for (int j = 0; j < vertices.Length; j++)
				{
					int boneIndex = boneWeights[j].boneIndex0;
					int boneIndex2 = boneWeights[j].boneIndex1;
					int boneIndex3 = boneWeights[j].boneIndex2;
					int boneIndex4 = boneWeights[j].boneIndex3;
					float3 b2 = vertices[j];
					deformed[j] = math.transform(boneTransforms[boneIndex], b2) * boneWeights[j].weight0 + math.transform(boneTransforms[boneIndex2], b2) * boneWeights[j].weight1 + math.transform(boneTransforms[boneIndex3], b2) * boneWeights[j].weight2 + math.transform(boneTransforms[boneIndex4], b2) * boneWeights[j].weight3;
					float4 b3 = new float4(tangents[j].xyz, 0f);
					b3 = math.mul(boneTransforms[boneIndex], b3) * boneWeights[j].weight0 + math.mul(boneTransforms[boneIndex2], b3) * boneWeights[j].weight1 + math.mul(boneTransforms[boneIndex3], b3) * boneWeights[j].weight2 + math.mul(boneTransforms[boneIndex4], b3) * boneWeights[j].weight3;
					deformedTangents[j] = new float4(math.normalize(b3.xyz), tangents[j].w);
				}
			}
		}

		internal static void Deform(Sprite sprite, Matrix4x4 invRoot, Transform[] boneTransformsArray, NativeArray<byte> deformVertexData)
		{
			NativeSlice<Vector3> vertexAttribute = sprite.GetVertexAttribute<Vector3>(VertexAttribute.Position);
			NativeSlice<Vector4> vertexAttribute2 = sprite.GetVertexAttribute<Vector4>(VertexAttribute.Tangent);
			NativeSlice<BoneWeight> vertexAttribute3 = sprite.GetVertexAttribute<BoneWeight>(VertexAttribute.BlendWeight);
			NativeArray<Matrix4x4> bindPoses = sprite.GetBindPoses();
			NativeArray<Matrix4x4> boneTransforms = new NativeArray<Matrix4x4>(boneTransformsArray.Length, Allocator.Temp, NativeArrayOptions.UninitializedMemory);
			for (int i = 0; i < boneTransformsArray.Length; i++)
			{
				boneTransforms[i] = boneTransformsArray[i].localToWorldMatrix;
			}
			Deform(sprite, invRoot, vertexAttribute, vertexAttribute2, vertexAttribute3, boneTransforms, bindPoses, deformVertexData);
			boneTransforms.Dispose();
		}

		internal static void Bake(this SpriteSkin spriteSkin, NativeArray<byte> deformVertexData)
		{
			if (!spriteSkin.isValid)
			{
				throw new Exception("Bake error: invalid SpriteSkin");
			}
			Deform(spriteSkin.spriteRenderer.sprite, boneTransformsArray: spriteSkin.boneTransforms, invRoot: Matrix4x4.identity, deformVertexData: deformVertexData);
		}

		internal unsafe static void CalculateBounds(this SpriteSkin spriteSkin)
		{
			Sprite sprite = spriteSkin.sprite;
			NativeArray<byte> nativeArray = new NativeArray<byte>(sprite.GetVertexStreamSize() * sprite.GetVertexCount(), Allocator.Temp, NativeArrayOptions.UninitializedMemory);
			NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<Vector3>(nativeArray.GetUnsafePtr(), sprite.GetVertexStreamSize(), sprite.GetVertexCount());
			spriteSkin.Bake(nativeArray);
			spriteSkin.UpdateBounds(nativeArray);
			nativeArray.Dispose();
		}

		internal static Bounds CalculateSpriteSkinBounds(NativeSlice<float3> deformablePositions)
		{
			float3 @float = deformablePositions[0];
			float3 float2 = deformablePositions[0];
			for (int i = 1; i < deformablePositions.Length; i++)
			{
				@float = math.min(@float, deformablePositions[i]);
				float2 = math.max(float2, deformablePositions[i]);
			}
			float3 float3 = (float2 - @float) * 0.5f;
			float3 float4 = @float + float3;
			Bounds result = default(Bounds);
			result.center = float4;
			result.extents = float3;
			return result;
		}

		internal unsafe static void UpdateBounds(this SpriteSkin spriteSkin, NativeArray<byte> deformedVertices)
		{
			byte* unsafePtr = (byte*)deformedVertices.GetUnsafePtr();
			int vertexCount = spriteSkin.sprite.GetVertexCount();
			int vertexStreamSize = spriteSkin.sprite.GetVertexStreamSize();
			NativeSlice<float3> deformablePositions = NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<float3>(unsafePtr, vertexStreamSize, vertexCount);
			spriteSkin.bounds = CalculateSpriteSkinBounds(deformablePositions);
			InternalEngineBridge.SetLocalAABB(spriteSkin.spriteRenderer, spriteSkin.bounds);
		}
	}
}
