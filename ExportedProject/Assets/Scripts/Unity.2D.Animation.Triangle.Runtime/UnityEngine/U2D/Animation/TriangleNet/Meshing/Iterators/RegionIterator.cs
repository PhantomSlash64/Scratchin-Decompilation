using System;
using System.Collections.Generic;
using UnityEngine.U2D.Animation.TriangleNet.Topology;

namespace UnityEngine.U2D.Animation.TriangleNet.Meshing.Iterators
{
	internal class RegionIterator
	{
		private List<Triangle> region;

		public RegionIterator(Mesh mesh)
		{
			region = new List<Triangle>();
		}

		public void Process(Triangle triangle, int boundary = 0)
		{
			Process(triangle, delegate(Triangle tri)
			{
				tri.label = triangle.label;
				tri.area = triangle.area;
			}, boundary);
		}

		public void Process(Triangle triangle, Action<Triangle> action, int boundary = 0)
		{
			if (triangle.id == -1 || Otri.IsDead(triangle))
			{
				return;
			}
			region.Add(triangle);
			triangle.infected = true;
			if (boundary == 0)
			{
				ProcessRegion(action, (SubSegment seg) => seg.hash == -1);
			}
			else
			{
				ProcessRegion(action, (SubSegment seg) => seg.boundary != boundary);
			}
			region.Clear();
		}

		private void ProcessRegion(Action<Triangle> action, Func<SubSegment, bool> protector)
		{
			Otri otri = default(Otri);
			Otri ot = default(Otri);
			Osub os = default(Osub);
			for (int i = 0; i < region.Count; i++)
			{
				otri.tri = region[i];
				action(otri.tri);
				otri.orient = 0;
				while (otri.orient < 3)
				{
					otri.Sym(ref ot);
					otri.Pivot(ref os);
					if (ot.tri.id != -1 && !ot.IsInfected() && protector(os.seg))
					{
						ot.Infect();
						region.Add(ot.tri);
					}
					otri.orient++;
				}
			}
			foreach (Triangle item in region)
			{
				item.infected = false;
			}
			region.Clear();
		}
	}
}
