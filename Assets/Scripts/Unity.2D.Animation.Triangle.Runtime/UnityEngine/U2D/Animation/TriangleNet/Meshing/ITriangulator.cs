using System.Collections.Generic;
using UnityEngine.U2D.Animation.TriangleNet.Geometry;

namespace UnityEngine.U2D.Animation.TriangleNet.Meshing
{
	internal interface ITriangulator
	{
		IMesh Triangulate(IList<Vertex> points, Configuration config);
	}
}
