using System.Diagnostics;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	[DebuggerDisplay("Texture ({handle.index})")]
	public struct TextureHandle
	{
		private static TextureHandle s_NullHandle;

		internal ResourceHandle handle;

		public static TextureHandle nullHandle => s_NullHandle;

		internal TextureHandle(int handle, bool shared = false)
		{
			this.handle = new ResourceHandle(handle, RenderGraphResourceType.Texture, shared);
		}

		public static implicit operator RenderTargetIdentifier(TextureHandle texture)
		{
			if (!texture.IsValid())
			{
				return default(RenderTargetIdentifier);
			}
			return RenderGraphResourceRegistry.current.GetTexture(in texture);
		}

		public static implicit operator Texture(TextureHandle texture)
		{
			return texture.IsValid() ? RenderGraphResourceRegistry.current.GetTexture(in texture) : null;
		}

		public static implicit operator RenderTexture(TextureHandle texture)
		{
			return texture.IsValid() ? RenderGraphResourceRegistry.current.GetTexture(in texture) : null;
		}

		public static implicit operator RTHandle(TextureHandle texture)
		{
			if (!texture.IsValid())
			{
				return null;
			}
			return RenderGraphResourceRegistry.current.GetTexture(in texture);
		}

		public bool IsValid()
		{
			return handle.IsValid();
		}
	}
}
