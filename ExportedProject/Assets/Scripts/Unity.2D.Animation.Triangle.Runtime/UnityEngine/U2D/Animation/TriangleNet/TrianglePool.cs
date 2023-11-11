using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.U2D.Animation.TriangleNet.Topology;

namespace UnityEngine.U2D.Animation.TriangleNet
{
	internal class TrianglePool : ICollection<Triangle>, IEnumerable<Triangle>, IEnumerable
	{
		private class Enumerator : IEnumerator<Triangle>, IEnumerator, IDisposable
		{
			private int count;

			private Triangle[][] pool;

			private Triangle current;

			private int index;

			private int offset;

			public Triangle Current => current;

			object IEnumerator.Current => current;

			internal Enumerator(TrianglePool pool)
			{
				count = pool.Count;
				this.pool = pool.pool;
				index = 0;
				offset = 0;
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				while (index < count)
				{
					current = pool[offset / 1024][offset % 1024];
					offset++;
					if (current.hash >= 0)
					{
						index++;
						return true;
					}
				}
				return false;
			}

			public void Reset()
			{
				index = (offset = 0);
			}
		}

		private const int BLOCKSIZE = 1024;

		private int size;

		private int count;

		private Triangle[][] pool;

		private Stack<Triangle> stack;

		public int Count => count - stack.Count;

		public bool IsReadOnly => true;

		public TrianglePool()
		{
			size = 0;
			int num = Math.Max(1, 64);
			pool = new Triangle[num][];
			pool[0] = new Triangle[1024];
			stack = new Stack<Triangle>(1024);
		}

		public Triangle Get()
		{
			Triangle triangle;
			if (stack.Count > 0)
			{
				triangle = stack.Pop();
				triangle.hash = -triangle.hash - 1;
				Cleanup(triangle);
			}
			else if (count < size)
			{
				triangle = pool[count / 1024][count % 1024];
				triangle.id = triangle.hash;
				Cleanup(triangle);
				count++;
			}
			else
			{
				triangle = new Triangle();
				triangle.hash = size;
				triangle.id = triangle.hash;
				int num = size / 1024;
				if (pool[num] == null)
				{
					pool[num] = new Triangle[1024];
					if (num + 1 == pool.Length)
					{
						Array.Resize(ref pool, 2 * pool.Length);
					}
				}
				pool[num][size % 1024] = triangle;
				count = ++size;
			}
			return triangle;
		}

		public void Release(Triangle triangle)
		{
			stack.Push(triangle);
			triangle.hash = -triangle.hash - 1;
		}

		public TrianglePool Restart()
		{
			foreach (Triangle item in stack)
			{
				item.hash = -item.hash - 1;
			}
			stack.Clear();
			count = 0;
			return this;
		}

		internal IEnumerable<Triangle> Sample(int k, Random random)
		{
			int count = Count;
			if (k > count)
			{
				k = count;
			}
			while (k > 0)
			{
				int num = random.Next(0, count);
				Triangle triangle = pool[num / 1024][num % 1024];
				if (triangle.hash >= 0)
				{
					k--;
					yield return triangle;
				}
			}
		}

		private void Cleanup(Triangle triangle)
		{
			triangle.label = 0;
			triangle.area = 0.0;
			triangle.infected = false;
			for (int i = 0; i < 3; i++)
			{
				triangle.vertices[i] = null;
				triangle.subsegs[i] = default(Osub);
				triangle.neighbors[i] = default(Otri);
			}
		}

		public void Add(Triangle item)
		{
			throw new NotImplementedException();
		}

		public void Clear()
		{
			stack.Clear();
			int num = size / 1024 + 1;
			for (int i = 0; i < num; i++)
			{
				Triangle[] array = pool[i];
				int num2 = (size - i * 1024) % 1024;
				for (int j = 0; j < num2; j++)
				{
					array[j] = null;
				}
			}
			size = (count = 0);
		}

		public bool Contains(Triangle item)
		{
			int hash = item.hash;
			if (hash < 0 || hash > size)
			{
				return false;
			}
			return pool[hash / 1024][hash % 1024].hash >= 0;
		}

		public void CopyTo(Triangle[] array, int index)
		{
			IEnumerator<Triangle> enumerator = GetEnumerator();
			while (enumerator.MoveNext())
			{
				array[index] = enumerator.Current;
				index++;
			}
		}

		public bool Remove(Triangle item)
		{
			throw new NotImplementedException();
		}

		public IEnumerator<Triangle> GetEnumerator()
		{
			return new Enumerator(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
