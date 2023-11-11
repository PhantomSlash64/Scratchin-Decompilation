using System.Collections.Generic;
using UnityEngine.U2D.Animation.TriangleNet.Geometry;

namespace UnityEngine.U2D.Animation.TriangleNet.Voronoi.Legacy
{
	internal interface IVoronoi
	{
		Point[] Points { get; }

		ICollection<VoronoiRegion> Regions { get; }

		IEnumerable<IEdge> Edges { get; }
	}
}
