using System.IO;
using UnityEngine.U2D.Animation.TriangleNet.Meshing;

namespace UnityEngine.U2D.Animation.TriangleNet.IO
{
	internal interface IMeshFormat : IFileFormat
	{
		IMesh Import(string filename);

		void Write(IMesh mesh, string filename);

		void Write(IMesh mesh, Stream stream);
	}
}
