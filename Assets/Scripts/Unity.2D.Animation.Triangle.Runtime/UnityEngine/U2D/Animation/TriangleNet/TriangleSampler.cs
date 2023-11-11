using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.U2D.Animation.TriangleNet.Topology;

namespace UnityEngine.U2D.Animation.TriangleNet
{
	internal class TriangleSampler : IEnumerable<Triangle>, IEnumerable
	{
		private const int RANDOM_SEED = 110503;

		private const int samplefactor = 11;

		private Random random;

		private Mesh mesh;

		private int samples = 1;

		private int triangleCount;

		public TriangleSampler(Mesh mesh)
			: this(mesh, new Random(110503))
		{
		}

		public TriangleSampler(Mesh mesh, Random random)
		{
			this.mesh = mesh;
			this.random = random;
		}

		public void Reset()
		{
			samples = 1;
			triangleCount = 0;
		}

		public void Update()
		{
			int count = mesh.triangles.Count;
			if (triangleCount != count)
			{
				triangleCount = count;
				while (11 * samples * samples * samples < count)
				{
					samples++;
				}
			}
		}

		public IEnumerator<Triangle> GetEnumerator()
		{
			return mesh.triangles.Sample(samples, random).GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
