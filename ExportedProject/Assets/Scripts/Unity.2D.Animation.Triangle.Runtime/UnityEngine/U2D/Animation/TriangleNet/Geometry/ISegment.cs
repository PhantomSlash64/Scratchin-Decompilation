namespace UnityEngine.U2D.Animation.TriangleNet.Geometry
{
	internal interface ISegment : IEdge
	{
		Vertex GetVertex(int index);

		ITriangle GetTriangle(int index);
	}
}
