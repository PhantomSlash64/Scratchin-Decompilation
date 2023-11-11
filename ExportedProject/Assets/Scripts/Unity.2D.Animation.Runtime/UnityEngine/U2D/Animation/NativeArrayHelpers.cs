using System;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.U2D.Animation
{
	internal static class NativeArrayHelpers
	{
		public static void ResizeIfNeeded<T>(ref NativeArray<T> nativeArray, int size, Allocator allocator = Allocator.Persistent) where T : struct
		{
			bool flag = nativeArray.IsCreated;
			if (flag && nativeArray.Length != size)
			{
				nativeArray.Dispose();
				flag = false;
			}
			if (!flag)
			{
				nativeArray = new NativeArray<T>(size, allocator);
			}
		}

		public static void ResizeAndCopyIfNeeded<T>(ref NativeArray<T> nativeArray, int size, Allocator allocator = Allocator.Persistent) where T : struct
		{
			bool isCreated = nativeArray.IsCreated;
			if (!isCreated || nativeArray.Length != size)
			{
				NativeArray<T> nativeArray2 = new NativeArray<T>(size, allocator);
				if (isCreated)
				{
					NativeArray<T>.Copy(nativeArray, nativeArray2, (size < nativeArray.Length) ? size : nativeArray.Length);
					nativeArray.Dispose();
				}
				nativeArray = nativeArray2;
			}
		}

		public static void DisposeIfCreated<T>(this NativeArray<T> nativeArray) where T : struct
		{
			if (nativeArray.IsCreated)
			{
				nativeArray.Dispose();
			}
		}

		[WriteAccessRequired]
		public unsafe static void CopyFromNativeSlice<T, S>(this NativeArray<T> nativeArray, int dstStartIndex, int dstEndIndex, NativeSlice<S> slice, int srcStartIndex, int srcEndIndex) where T : struct where S : struct
		{
			if (dstEndIndex - dstStartIndex != srcEndIndex - srcStartIndex)
			{
				throw new ArgumentException("Destination and Source copy counts must match.", "slice");
			}
			int num = UnsafeUtility.SizeOf<T>();
			int num2 = UnsafeUtility.SizeOf<T>();
			byte* unsafeReadOnlyPtr = (byte*)slice.GetUnsafeReadOnlyPtr();
			unsafeReadOnlyPtr += srcStartIndex * num2;
			byte* unsafePtr = (byte*)nativeArray.GetUnsafePtr();
			unsafePtr += dstStartIndex * num;
			UnsafeUtility.MemCpyStride(unsafePtr, num2, unsafeReadOnlyPtr, slice.Stride, num, srcEndIndex - srcStartIndex);
		}
	}
}
