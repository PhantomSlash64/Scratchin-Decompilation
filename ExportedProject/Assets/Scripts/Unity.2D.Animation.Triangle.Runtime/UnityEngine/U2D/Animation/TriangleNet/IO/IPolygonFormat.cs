using System.IO;
using UnityEngine.U2D.Animation.TriangleNet.Geometry;

namespace UnityEngine.U2D.Animation.TriangleNet.IO
{
	internal interface IPolygonFormat : IFileFormat
	{
		IPolygon Read(string filename);

		void Write(IPolygon polygon, string filename);

		void Write(IPolygon polygon, Stream stream);
	}
}
