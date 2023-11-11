using System.Collections.Generic;
using UnityEngine.Profiling;
using UnityEngine.Rendering;

namespace UnityEngine.Experimental.Rendering.RenderGraphModule
{
	internal class TexturePool : RenderGraphResourcePool<RTHandle>
	{
		protected override void ReleaseInternalResource(RTHandle res)
		{
			res.Release();
		}

		protected override string GetResourceName(RTHandle res)
		{
			return res.rt.name;
		}

		protected override long GetResourceSize(RTHandle res)
		{
			return Profiler.GetRuntimeMemorySizeLong(res.rt);
		}

		protected override string GetResourceTypeName()
		{
			return "Texture";
		}

		public override void PurgeUnusedResources(int currentFrameIndex)
		{
			RenderGraphResourcePool<RTHandle>.s_CurrentFrameIndex = currentFrameIndex;
			foreach (KeyValuePair<int, List<(RTHandle, int)>> item in m_ResourcePool)
			{
				item.Value.RemoveAll(delegate((RTHandle resource, int frameIndex) obj)
				{
					if (RenderGraphResourcePool<RTHandle>.ShouldReleaseResource(obj.frameIndex, RenderGraphResourcePool<RTHandle>.s_CurrentFrameIndex))
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
