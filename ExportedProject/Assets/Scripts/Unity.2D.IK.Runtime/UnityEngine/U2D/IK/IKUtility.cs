using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D.IK
{
	[MovedFrom("UnityEngine.Experimental.U2D.IK")]
	public class IKUtility
	{
		public static bool IsDescendentOf(Transform transform, Transform ancestor)
		{
			Transform parent = transform.parent;
			while ((bool)parent)
			{
				if (parent == ancestor)
				{
					return true;
				}
				parent = parent.parent;
			}
			return false;
		}

		public static int GetAncestorCount(Transform transform)
		{
			int num = 0;
			while ((bool)transform.parent)
			{
				num++;
				transform = transform.parent;
			}
			return num;
		}

		public static int GetMaxChainCount(IKChain2D chain)
		{
			int result = 0;
			if ((bool)chain.effector)
			{
				result = GetAncestorCount(chain.effector) + 1;
			}
			return result;
		}
	}
}
