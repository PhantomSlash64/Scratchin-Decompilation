namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	internal struct RendererListResource
	{
		public RendererListDesc desc;

		public RendererList rendererList;

		internal RendererListResource(in RendererListDesc desc)
		{
			this.desc = desc;
			rendererList = default(RendererList);
		}
	}
}
