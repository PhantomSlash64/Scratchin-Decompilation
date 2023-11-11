using System;
using UnityEngine.U2D.Animation.TriangleNet.Geometry;

namespace UnityEngine.U2D.Animation.TriangleNet.Meshing
{
	internal class QualityOptions
	{
		public double MaximumAngle { get; set; }

		public double MinimumAngle { get; set; }

		public double MaximumArea { get; set; }

		public Func<ITriangle, double, bool> UserTest { get; set; }

		public bool VariableArea { get; set; }

		public int SteinerPoints { get; set; }
	}
}
