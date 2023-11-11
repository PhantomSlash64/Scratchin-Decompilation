using System.Diagnostics;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	[DebuggerDisplay("RendererList ({handle})")]
	public struct RendererListHandle
	{
		private bool m_IsValid;

		internal int handle { get; private set; }

		internal RendererListHandle(int handle)
		{
			this.handle = handle;
			m_IsValid = true;
		}

		public static implicit operator int(RendererListHandle handle)
		{
			return handle.handle;
		}

		public static implicit operator RendererList(RendererListHandle rendererList)
		{
			if (!rendererList.IsValid())
			{
				return RendererList.nullRendererList;
			}
			return RenderGraphResourceRegistry.current.GetRendererList(in rendererList);
		}

		public bool IsValid()
		{
			return m_IsValid;
		}
	}
}
