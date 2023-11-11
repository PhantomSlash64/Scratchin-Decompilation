using System;
using Unity.Collections;

namespace UnityEngine.U2D.Common
{
	internal static class InternalEngineBridge
	{
		public static void SetLocalAABB(SpriteRenderer spriteRenderer, Bounds aabb)
		{
			spriteRenderer.SetLocalAABB(aabb);
		}

		public static void SetDeformableBuffer(SpriteRenderer spriteRenderer, NativeArray<byte> src)
		{
			spriteRenderer.SetDeformableBuffer(src);
		}

		public static Vector2 GUIUnclip(Vector2 v)
		{
			return GUIClip.Unclip(v);
		}

		public static Rect GetGUIClipTopMostRect()
		{
			return GUIClip.topmostRect;
		}

		public static Rect GetGUIClipTopRect()
		{
			return GUIClip.GetTopRect();
		}

		public static void SetBatchDeformableBufferAndLocalAABBArray(SpriteRenderer[] spriteRenderers, NativeArray<IntPtr> buffers, NativeArray<int> bufferSizes, NativeArray<Bounds> bounds)
		{
			SpriteRendererDataAccessExtensions.SetBatchDeformableBufferAndLocalAABBArray(spriteRenderers, buffers, bufferSizes, bounds);
		}
	}
}
