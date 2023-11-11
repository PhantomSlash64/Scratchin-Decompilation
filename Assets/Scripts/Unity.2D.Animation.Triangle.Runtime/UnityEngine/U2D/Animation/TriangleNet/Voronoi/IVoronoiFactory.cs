using UnityEngine.U2D.Animation.TriangleNet.Geometry;
using UnityEngine.U2D.Animation.TriangleNet.Topology.DCEL;

namespace UnityEngine.U2D.Animation.TriangleNet.Voronoi
{
	internal interface IVoronoiFactory
	{
		void Initialize(int vertexCount, int edgeCount, int faceCount);

		void Reset();

		UnityEngine.U2D.Animation.TriangleNet.Topology.DCEL.Vertex CreateVertex(double x, double y);

		HalfEdge CreateHalfEdge(UnityEngine.U2D.Animation.TriangleNet.Topology.DCEL.Vertex origin, Face face);

		Face CreateFace(UnityEngine.U2D.Animation.TriangleNet.Geometry.Vertex vertex);
	}
}
