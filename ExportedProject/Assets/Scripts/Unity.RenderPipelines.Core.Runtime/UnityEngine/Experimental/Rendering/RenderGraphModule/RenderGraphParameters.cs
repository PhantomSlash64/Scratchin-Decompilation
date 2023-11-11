using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	public struct RenderGraphParameters
	{
		public int currentFrameIndex;

		public ScriptableRenderContext scriptableRenderContext;

		public CommandBuffer commandBuffer;
	}
}
