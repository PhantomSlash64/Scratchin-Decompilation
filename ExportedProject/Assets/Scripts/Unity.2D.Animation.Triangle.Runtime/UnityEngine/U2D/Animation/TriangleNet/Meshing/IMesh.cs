using System.Collections.Generic;
using UnityEngine.U2D.Animation.TriangleNet.Geometry;
using UnityEngine.U2D.Animation.TriangleNet.Topology;

namespace UnityEngine.U2D.Animation.TriangleNet.Meshing
{
	internal interface IMesh
	{
		ICollection<Vertex> Vertices { get; }

		IEnumerable<Edge> Edges { get; }

		ICollection<SubSegment> Segments { get; }

		ICollection<Triangle> Triangles { get; }

		IList<Point> Holes { get; }

		Rectangle Bounds { get; }

		void Renumber();

		void Refine(QualityOptions quality, bool delaunay);
	}
}
