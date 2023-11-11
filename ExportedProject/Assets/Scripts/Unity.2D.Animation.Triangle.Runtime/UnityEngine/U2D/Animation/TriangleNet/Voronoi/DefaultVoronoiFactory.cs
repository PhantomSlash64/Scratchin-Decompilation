using UnityEngine.U2D.Animation.TriangleNet.Geometry;
using UnityEngine.U2D.Animation.TriangleNet.Topology.DCEL;

namespace UnityEngine.U2D.Animation.TriangleNet.Voronoi
{
	internal class DefaultVoronoiFactory : IVoronoiFactory
	{
		public void Initialize(int vertexCount, int edgeCount, int faceCount)
		{
		}

		public void Reset()
		{
		}

		public UnityEngine.U2D.Animation.TriangleNet.Topology.DCEL.Vertex CreateVertex(double x, double y)
		{
			return new UnityEngine.U2D.Animation.TriangleNet.Topology.DCEL.Vertex(x, y);
		}

		public HalfEdge CreateHalfEdge(UnityEngine.U2D.Animation.TriangleNet.Topology.DCEL.Vertex origin, Face face)
		{
			return new HalfEdge(origin, face);
		}

		public Face CreateFace(UnityEngine.U2D.Animation.TriangleNet.Geometry.Vertex vertex)
		{
			return new Face(vertex);
		}
	}
}
