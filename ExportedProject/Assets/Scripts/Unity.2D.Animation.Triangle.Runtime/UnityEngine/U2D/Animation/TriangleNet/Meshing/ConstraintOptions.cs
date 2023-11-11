using System;

namespace UnityEngine.U2D.Animation.TriangleNet.Meshing
{
	internal class ConstraintOptions
	{
		[Obsolete("Not used anywhere, will be removed in beta 4.")]
		public bool UseRegions { get; set; }

		public bool ConformingDelaunay { get; set; }

		public bool Convex { get; set; }

		public int SegmentSplitting { get; set; }
	}
}
