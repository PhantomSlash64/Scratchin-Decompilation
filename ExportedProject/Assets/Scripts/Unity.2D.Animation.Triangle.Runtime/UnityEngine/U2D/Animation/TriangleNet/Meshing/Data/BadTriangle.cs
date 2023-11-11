using UnityEngine.U2D.Animation.TriangleNet.Geometry;
using UnityEngine.U2D.Animation.TriangleNet.Topology;

namespace UnityEngine.U2D.Animation.TriangleNet.Meshing.Data
{
	internal class BadTriangle
	{
		public Otri poortri;

		public double key;

		public Vertex org;

		public Vertex dest;

		public Vertex apex;

		public BadTriangle next;

		public override string ToString()
		{
			return $"B-TID {poortri.tri.hash}";
		}
	}
}
