using UnityEngine.U2D.Animation.TriangleNet.Geometry;

namespace UnityEngine.U2D.Animation.TriangleNet.Meshing
{
	internal interface IQualityMesher
	{
		IMesh Triangulate(IPolygon polygon, QualityOptions quality);

		IMesh Triangulate(IPolygon polygon, ConstraintOptions options, QualityOptions quality);
	}
}
