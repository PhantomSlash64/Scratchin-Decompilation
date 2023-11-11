using UnityEngine.U2D.Animation.TriangleNet.Geometry;
using UnityEngine.U2D.Animation.TriangleNet.Topology;

namespace UnityEngine.U2D.Animation.TriangleNet.Meshing.Data
{
	internal class BadSubseg
	{
		public Osub subseg;

		public Vertex org;

		public Vertex dest;

		public override int GetHashCode()
		{
			return subseg.seg.hash;
		}

		public override string ToString()
		{
			return $"B-SID {subseg.seg.hash}";
		}
	}
}
