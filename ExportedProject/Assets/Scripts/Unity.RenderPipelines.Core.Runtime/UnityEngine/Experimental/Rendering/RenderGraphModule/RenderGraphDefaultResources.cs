using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	public class RenderGraphDefaultResources
	{
		private bool m_IsValid;

		private RTHandle m_BlackTexture2D;

		private RTHandle m_WhiteTexture2D;

		public TextureHandle blackTexture { get; private set; }

		public TextureHandle whiteTexture { get; private set; }

		public TextureHandle clearTextureXR { get; private set; }

		public TextureHandle magentaTextureXR { get; private set; }

		public TextureHandle blackTextureXR { get; private set; }

		public TextureHandle blackTextureArrayXR { get; private set; }

		public TextureHandle blackUIntTextureXR { get; private set; }

		public TextureHandle blackTexture3DXR { get; private set; }

		public TextureHandle whiteTextureXR { get; private set; }

		internal RenderGraphDefaultResources()
		{
			m_BlackTexture2D = RTHandles.Alloc(Texture2D.blackTexture);
			m_WhiteTexture2D = RTHandles.Alloc(Texture2D.whiteTexture);
		}

		internal void Cleanup()
		{
			m_BlackTexture2D.Release();
			m_WhiteTexture2D.Release();
		}

		internal void InitializeForRendering(RenderGraph renderGraph)
		{
			blackTexture = renderGraph.ImportTexture(m_BlackTexture2D);
			whiteTexture = renderGraph.ImportTexture(m_WhiteTexture2D);
			clearTextureXR = renderGraph.ImportTexture(TextureXR.GetClearTexture());
			magentaTextureXR = renderGraph.ImportTexture(TextureXR.GetMagentaTexture());
			blackTextureXR = renderGraph.ImportTexture(TextureXR.GetBlackTexture());
			blackTextureArrayXR = renderGraph.ImportTexture(TextureXR.GetBlackTextureArray());
			blackUIntTextureXR = renderGraph.ImportTexture(TextureXR.GetBlackUIntTexture());
			blackTexture3DXR = renderGraph.ImportTexture(TextureXR.GetBlackTexture3D());
			whiteTextureXR = renderGraph.ImportTexture(TextureXR.GetWhiteTexture());
		}
	}
}
