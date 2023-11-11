using System.Collections.Generic;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	internal class ComputeBufferPool : RenderGraphResourcePool<ComputeBuffer>
	{
		protected override void ReleaseInternalResource(ComputeBuffer res)
		{
			res.Release();
		}

		protected override string GetResourceName(ComputeBuffer res)
		{
			return "ComputeBufferNameNotAvailable";
		}

		protected override long GetResourceSize(ComputeBuffer res)
		{
			return res.count * res.stride;
		}

		protected override string GetResourceTypeName()
		{
			return "ComputeBuffer";
		}

		public override void PurgeUnusedResources(int currentFrameIndex)
		{
			RenderGraphResourcePool<ComputeBuffer>.s_CurrentFrameIndex = currentFrameIndex;
			foreach (KeyValuePair<int, List<(ComputeBuffer, int)>> item in m_ResourcePool)
			{
				item.Value.RemoveAll(delegate((ComputeBuffer resource, int frameIndex) obj)
				{
					if (RenderGraphResourcePool<ComputeBuffer>.ShouldReleaseResource(obj.frameIndex, RenderGraphResourcePool<ComputeBuffer>.s_CurrentFrameIndex))
					{
						obj.resource.Release();
						return true;
					}
					return false;
				});
			}
		}
	}
}
