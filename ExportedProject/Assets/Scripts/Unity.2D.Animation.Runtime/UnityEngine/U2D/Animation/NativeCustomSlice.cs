using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.U2D.Animation
{
	internal struct NativeCustomSlice<T> where T : struct
	{
		[NativeDisableUnsafePtrRestriction]
		public IntPtr data;

		public int length;

		public int stride;

		public unsafe T this[int index] => UnsafeUtility.ReadArrayElementWithStride<T>(data.ToPointer(), index, stride);

		public int Length => length;

		public static NativeCustomSlice<T> Default()
		{
			NativeCustomSlice<T> result = default(NativeCustomSlice<T>);
			result.data = IntPtr.Zero;
			result.length = 0;
			result.stride = 0;
			return result;
		}

		public unsafe NativeCustomSlice(NativeSlice<T> nativeSlice)
		{
			data = new IntPtr(nativeSlice.GetUnsafeReadOnlyPtr());
			length = nativeSlice.Length;
			stride = nativeSlice.Stride;
		}

		public unsafe NativeCustomSlice(NativeSlice<byte> slice, int length, int stride)
		{
			data = new IntPtr(slice.GetUnsafeReadOnlyPtr());
			this.length = length;
			this.stride = stride;
		}
	}
}
