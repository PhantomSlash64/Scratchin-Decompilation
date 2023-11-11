using UnityEngine.U2D.Animation.TriangleNet.Geometry;

namespace UnityEngine.U2D.Animation.TriangleNet.Meshing
{
	internal interface IConstraintMesher
	{
		IMesh Triangulate(IPolygon polygon);

		IMesh Triangulate(IPolygon polygon, ConstraintOptions options);
	}
}
