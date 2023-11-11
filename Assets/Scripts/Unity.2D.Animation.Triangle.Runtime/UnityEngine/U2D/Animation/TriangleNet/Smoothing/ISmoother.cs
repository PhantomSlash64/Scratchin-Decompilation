using UnityEngine.U2D.Animation.TriangleNet.Meshing;

namespace UnityEngine.U2D.Animation.TriangleNet.Smoothing
{
	internal interface ISmoother
	{
		void Smooth(IMesh mesh);

		void Smooth(IMesh mesh, int limit);
	}
}
