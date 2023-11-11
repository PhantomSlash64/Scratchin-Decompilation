namespace UnityEngine.U2D.Animation.TriangleNet.Geometry
{
	internal interface ITriangle
	{
		int ID { get; set; }

		int Label { get; set; }

		double Area { get; set; }

		Vertex GetVertex(int index);

		int GetVertexID(int index);

		ITriangle GetNeighbor(int index);

		int GetNeighborID(int index);

		ISegment GetSegment(int index);
	}
}
