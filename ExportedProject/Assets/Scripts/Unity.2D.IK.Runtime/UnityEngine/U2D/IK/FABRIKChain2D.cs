using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D.IK
{
	[MovedFrom("UnityEngine.Experimental.U2D.IK")]
	public struct FABRIKChain2D
	{
		public Vector2 origin;

		public Vector2 target;

		public float sqrTolerance;

		public Vector2[] positions;

		public float[] lengths;

		public int[] subChainIndices;

		public Vector3[] worldPositions;

		public Vector2 first => positions[0];

		public Vector2 last => positions[positions.Length - 1];
	}
}
