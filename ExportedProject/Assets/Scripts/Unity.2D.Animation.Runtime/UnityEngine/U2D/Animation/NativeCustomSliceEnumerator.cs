using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Collections;

namespace UnityEngine.U2D.Animation
{
	internal struct NativeCustomSliceEnumerator<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable where T : struct
	{
		private NativeCustomSlice<T> nativeCustomSlice;

		private int index;

		public T Current => nativeCustomSlice[index];

		object IEnumerator.Current => Current;

		internal NativeCustomSliceEnumerator(NativeSlice<byte> slice, int length, int stride)
		{
			nativeCustomSlice = new NativeCustomSlice<T>(slice, length, stride);
			index = -1;
			Reset();
		}

		public IEnumerator<T> GetEnumerator()
		{
			return this;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public bool MoveNext()
		{
			if (++index < nativeCustomSlice.length)
			{
				return true;
			}
			return false;
		}

		public void Reset()
		{
			index = -1;
		}

		void IDisposable.Dispose()
		{
		}
	}
}
