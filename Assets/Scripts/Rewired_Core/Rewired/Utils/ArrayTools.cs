using System;
using System.Collections.Generic;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Utils
{
	public static class ArrayTools
	{
		public static int[] ConvertToIntArray(Array array)
		{
			if (array == null || array.Length == 0)
			{
				return null;
			}
			int[] array2 = new int[array.Length];
			int num = 0;
			foreach (object item in array)
			{
				array2[num++] = Convert.ToInt32(item);
			}
			return array2;
		}

		public static T[] DeepClone<T>(T[] array) where T : class, IDeepCloneable
		{
			if (array == null)
			{
				return null;
			}
			T[] array2 = new T[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					array2[i] = array[i].DeepClone() as T;
				}
			}
			return array2;
		}

		public static T[] ShallowCopy<T>(T[] array)
		{
			if (array == null)
			{
				return null;
			}
			T[] array2 = new T[array.Length];
			Array.Copy(array, array2, array.Length);
			return array2;
		}

		public static void ShallowCopy<T>(T[] sourceArray, T[] targetArray)
		{
			if (sourceArray != null && targetArray != null)
			{
				int length = Math.Min(sourceArray.Length, targetArray.Length);
				Array.Copy(sourceArray, targetArray, length);
			}
		}

		public static void ShallowCopy(int[] sourceArray, int[] targetArray)
		{
			if (sourceArray != null && targetArray != null)
			{
				int length = Math.Min(sourceArray.Length, targetArray.Length);
				Array.Copy(sourceArray, targetArray, length);
			}
		}

		public static void ShallowCopy(float[] sourceArray, float[] targetArray)
		{
			if (sourceArray != null && targetArray != null)
			{
				int length = Math.Min(sourceArray.Length, targetArray.Length);
				Array.Copy(sourceArray, targetArray, length);
			}
		}

		public static void ShallowCopy(bool[] sourceArray, bool[] targetArray)
		{
			if (sourceArray != null && targetArray != null)
			{
				int length = Math.Min(sourceArray.Length, targetArray.Length);
				Array.Copy(sourceArray, targetArray, length);
			}
		}

		public static byte[] CopyRange(byte[] inArray, int startPos, int length)
		{
			if (inArray == null || length < 1 || startPos < 0)
			{
				return null;
			}
			byte[] array = new byte[length];
			for (int i = 0; i < length; i++)
			{
				array[i] = inArray[startPos + i];
			}
			return array;
		}

		public static int[] CopyRange(int[] inArray, int startPos, int length)
		{
			if (inArray == null || length < 1 || startPos < 0)
			{
				return null;
			}
			int[] array = new int[length];
			for (int i = 0; i < length; i++)
			{
				array[i] = inArray[startPos + i];
			}
			return array;
		}

		public static float[] CopyRange(float[] inArray, int startPos, int length)
		{
			if (inArray == null || length < 1 || startPos < 0)
			{
				return null;
			}
			float[] array = new float[length];
			for (int i = 0; i < length; i++)
			{
				array[i] = inArray[startPos + i];
			}
			return array;
		}

		public static string[] CopyRange(string[] inArray, int startPos, int length)
		{
			if (inArray == null || length < 1 || startPos < 0)
			{
				return null;
			}
			string[] array = new string[length];
			for (int i = 0; i < length; i++)
			{
				array[i] = inArray[startPos + i];
			}
			return array;
		}

		public static byte[] Combine(byte[] inArray1, byte[] inArray2)
		{
			byte[] result = null;
			int num = ((inArray1 != null) ? inArray1.Length : 0);
			int num2 = ((inArray2 != null) ? inArray2.Length : 0);
			if (num == 0 && num2 == 0)
			{
				return result;
			}
			result = new byte[num + num2];
			int num3 = 0;
			for (int i = 0; i < num; i++)
			{
				result[num3] = inArray1[i];
				num3++;
			}
			for (int j = 0; j < num2; j++)
			{
				result[num3] = inArray2[j];
				num3++;
			}
			return result;
		}

		public static int[] Combine(int[] inArray1, int[] inArray2)
		{
			int[] result = null;
			int num = ((inArray1 != null) ? inArray1.Length : 0);
			int num2 = ((inArray2 != null) ? inArray2.Length : 0);
			if (num == 0 && num2 == 0)
			{
				return result;
			}
			result = new int[num + num2];
			int num3 = 0;
			for (int i = 0; i < num; i++)
			{
				result[num3] = inArray1[i];
				num3++;
			}
			for (int j = 0; j < num2; j++)
			{
				result[num3] = inArray2[j];
				num3++;
			}
			return result;
		}

		public static float[] Combine(float[] inArray1, float[] inArray2)
		{
			float[] result = null;
			int num = ((inArray1 != null) ? inArray1.Length : 0);
			int num2 = ((inArray2 != null) ? inArray2.Length : 0);
			if (num == 0 && num2 == 0)
			{
				return result;
			}
			result = new float[num + num2];
			int num3 = 0;
			for (int i = 0; i < num; i++)
			{
				result[num3] = inArray1[i];
				num3++;
			}
			for (int j = 0; j < num2; j++)
			{
				result[num3] = inArray2[j];
				num3++;
			}
			return result;
		}

		public static string[] Combine(string[] inArray1, string[] inArray2)
		{
			string[] result = null;
			int num = ((inArray1 != null) ? inArray1.Length : 0);
			int num2 = ((inArray2 != null) ? inArray2.Length : 0);
			if (num == 0 && num2 == 0)
			{
				return result;
			}
			result = new string[num + num2];
			int num3 = 0;
			for (int i = 0; i < num; i++)
			{
				result[num3] = inArray1[i];
				num3++;
			}
			for (int j = 0; j < num2; j++)
			{
				result[num3] = inArray2[j];
				num3++;
			}
			return result;
		}

		public static T[] ParseArray<T>(string line)
		{
			line = line.Replace("{", "");
			line = line.Replace("}", "");
			string[] array = line.Split(',');
			int num = array.Length;
			T[] array2 = new T[num];
			if (num == 1)
			{
				string text = array[0].Trim().ToLower();
				if (text == "" || text == "null")
				{
					return null;
				}
			}
			for (int i = 0; i < num; i++)
			{
				string value = array[i].Trim();
				array2[i] = (T)Convert.ChangeType(value, typeof(T));
			}
			return array2;
		}

		public static T[] SortAscending<T>(T[] array, out int[] sortedIndices) where T : IComparable<T>
		{
			if (array == null)
			{
				sortedIndices = null;
				return null;
			}
			int num = array.Length;
			switch (num)
			{
			case 0:
				sortedIndices = new int[0];
				return array;
			case 1:
			{
				int[] array4 = new int[1];
				sortedIndices = array4;
				return array;
			}
			default:
			{
				T[] array2 = new T[num];
				sortedIndices = new int[num];
				bool[] array3 = new bool[num];
				for (int i = 0; i < num; i++)
				{
					T val = default(T);
					int num2 = -1;
					for (int j = 0; j < num; j++)
					{
						if (!array3[j])
						{
							T val2 = array[j];
							if (num2 == -1 || val2.CompareTo(val) < 0)
							{
								val = val2;
								num2 = j;
							}
						}
					}
					array2[i] = val;
					sortedIndices[i] = num2;
					array3[num2] = true;
				}
				return array2;
			}
			}
		}

		public static T[] SortDescending<T>(T[] array, out int[] sortedIndices, bool ascending = true) where T : IComparable<T>
		{
			if (array == null)
			{
				sortedIndices = null;
				return null;
			}
			int num = array.Length;
			switch (num)
			{
			case 0:
				sortedIndices = new int[0];
				return array;
			case 1:
			{
				int[] array4 = new int[1];
				sortedIndices = array4;
				return array;
			}
			default:
			{
				T[] array2 = new T[num];
				sortedIndices = new int[num];
				bool[] array3 = new bool[num];
				for (int i = 0; i < num; i++)
				{
					T val = default(T);
					int num2 = -1;
					for (int j = 0; j < num; j++)
					{
						if (!array3[j])
						{
							T val2 = array[j];
							if (num2 == -1 || val2.CompareTo(val) < 0)
							{
								val = val2;
								num2 = j;
							}
						}
					}
					array2[i] = val;
					sortedIndices[i] = num2;
					array3[num2] = true;
				}
				return array2;
			}
			}
		}

		public static int Add<T>(ref T[] array, T item)
		{
			int num = ((array != null) ? array.Length : 0);
			int num2 = num + 1;
			T[] array2 = new T[num2];
			int i;
			for (i = 0; i < num; i++)
			{
				array2[i] = array[i];
			}
			array2[i] = item;
			array = array2;
			return i;
		}

		public static int AddIfUnique<T>(ref T[] array, T item)
		{
			if (array == null || array.Length == 0 || !Contains(array, item))
			{
				return Add(ref array, item);
			}
			return -1;
		}

		public static int Insert<T>(ref T[] array, int index, T item)
		{
			if (index < 0)
			{
				index = 0;
			}
			int num = ((array != null) ? array.Length : 0);
			int num2 = num - 1;
			if (index > num2)
			{
				return Add(ref array, item);
			}
			int num3 = num + 1;
			T[] array2 = new T[num3];
			int i;
			for (i = 0; i < index; i++)
			{
				array2[i] = array[i];
			}
			array2[i] = item;
			int num4 = index;
			for (i++; i < num3; i++)
			{
				array2[i] = array[num4];
				num4++;
			}
			array = array2;
			return index;
		}

		public static bool RemoveAt<T>(ref T[] array, int index)
		{
			if (array == null)
			{
				return false;
			}
			if (index < 0)
			{
				index = 0;
			}
			int num = array.Length;
			int num2 = num - 1;
			if (index > num2)
			{
				index = num2;
			}
			int num3 = num - 1;
			T[] array2 = new T[num3];
			for (int i = 0; i < index; i++)
			{
				array2[i] = array[i];
			}
			for (int i = index + 1; i < num; i++)
			{
				array2[i - 1] = array[i];
			}
			array = array2;
			return true;
		}

		public static bool Remove<T>(ref T[] array, T item)
		{
			if (array == null)
			{
				return false;
			}
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				if (EqualityComparer<T>.Default.Equals(array[i], item))
				{
					RemoveAt(ref array, i);
					return true;
				}
			}
			return false;
		}

		public static void Combine<T>(ref T[] array1, T[] array2)
		{
			if (array1 == null)
			{
				if (array2 != null)
				{
					array1 = (T[])array2.Clone();
				}
			}
			else if ((array1.Length != 0 || (array2 != null && array2.Length != 0)) && array2 != null && array2.Length != 0)
			{
				int num = array1.Length;
				int num2 = array2.Length;
				int num3 = num + num2;
				T[] array3 = new T[num3];
				int num4 = 0;
				for (int i = 0; i < num; i++)
				{
					array3[num4++] = array1[i];
				}
				for (int j = 0; j < num2; j++)
				{
					array3[num4++] = array2[j];
				}
				array1 = array3;
			}
		}

		public static T[] Add<T>(T[] array, T item)
		{
			int num = ((array != null) ? array.Length : 0);
			int num2 = num + 1;
			T[] array2 = new T[num2];
			int i;
			for (i = 0; i < num; i++)
			{
				array2[i] = array[i];
			}
			array2[i] = item;
			return array2;
		}

		public static T[] AddIfUnique<T>(T[] array, T item)
		{
			if (array == null || array.Length == 0 || !Contains(array, item))
			{
				return Add(array, item);
			}
			return array;
		}

		public static T[] Insert<T>(T[] array, int index, T item)
		{
			if (index < 0)
			{
				index = 0;
			}
			int num = ((array != null) ? array.Length : 0);
			int num2 = num - 1;
			if (index > num2)
			{
				return Add(array, item);
			}
			int num3 = num + 1;
			T[] array2 = new T[num3];
			int i;
			for (i = 0; i < index; i++)
			{
				array2[i] = array[i];
			}
			array2[i] = item;
			int num4 = index;
			for (i++; i < num3; i++)
			{
				array2[i] = array[num4];
				num4++;
			}
			return array2;
		}

		public static T[] RemoveAt<T>(T[] array, int index)
		{
			if (array == null)
			{
				return null;
			}
			if (index < 0)
			{
				index = 0;
			}
			int num = array.Length;
			int num2 = num - 1;
			if (index > num2)
			{
				index = num2;
			}
			int num3 = num - 1;
			T[] array2 = new T[num3];
			for (int i = 0; i < index; i++)
			{
				array2[i] = array[i];
			}
			for (int i = index + 1; i < num; i++)
			{
				array2[i - 1] = array[i];
			}
			return array2;
		}

		public static T[] Remove<T>(T[] array, T item)
		{
			if (array == null)
			{
				return array;
			}
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				if (EqualityComparer<T>.Default.Equals(array[i], item))
				{
					return RemoveAt(array, i);
				}
			}
			return array;
		}

		public static T[] Combine<T>(T[] array1, T[] array2)
		{
			if (array1 == null && array2 == null)
			{
				return null;
			}
			int num = ((array1 != null) ? array1.Length : 0);
			int num2 = ((array2 != null) ? array2.Length : 0);
			int num3 = num + num2;
			T[] array3 = new T[num3];
			int num4 = 0;
			for (int i = 0; i < num; i++)
			{
				array3[num4++] = array1[i];
			}
			for (int j = 0; j < num2; j++)
			{
				array3[num4++] = array2[j];
			}
			return array3;
		}

		public static int IndexOf<T>(T[] array, T item)
		{
			if (array == null)
			{
				return -1;
			}
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				if (EqualityComparer<T>.Default.Equals(array[i], item))
				{
					return i;
				}
			}
			return -1;
		}

		public static bool Contains<T>(T[] array, T item)
		{
			if (array == null)
			{
				return false;
			}
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				if (EqualityComparer<T>.Default.Equals(array[i], item))
				{
					return true;
				}
			}
			return false;
		}

		public static T Find<T>(T[] array, Predicate<T> predicate)
		{
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			if (array == null)
			{
				return default(T);
			}
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				if (predicate(array[i]))
				{
					return array[i];
				}
			}
			return default(T);
		}

		public static bool SubArray<T>(ref T[] array, int startIndex)
		{
			if (array == null)
			{
				return false;
			}
			if (array.Length == 0)
			{
				return false;
			}
			if (startIndex < 0)
			{
				startIndex = 0;
			}
			int num = array.Length;
			int num2 = num - 1;
			if (startIndex >= num2)
			{
				return false;
			}
			int num3 = num - startIndex;
			T[] array2 = new T[num3];
			int num4 = 0;
			for (int i = startIndex; i < num; i++)
			{
				array2[num4++] = array[i];
			}
			array = array2;
			return true;
		}

		public static bool SubArray<T>(ref T[] array, int startIndex, int count)
		{
			if (array == null)
			{
				return false;
			}
			if (array.Length == 0)
			{
				return false;
			}
			if (count <= 0)
			{
				return false;
			}
			if (startIndex < 0)
			{
				startIndex = 0;
			}
			int num = array.Length;
			if (startIndex >= num - 1)
			{
				return false;
			}
			if (count > num - startIndex)
			{
				count = num - startIndex;
			}
			int num2 = count;
			T[] array2 = new T[num2];
			int num3 = startIndex + count - 1;
			int num4 = 0;
			for (int i = startIndex; i <= num3; i++)
			{
				array2[num4++] = array[i];
			}
			array = array2;
			return true;
		}

		public static void Expand<T>(ref T[] array, int length)
		{
			if (length > 0)
			{
				int num = ((array != null) ? array.Length : 0);
				int num2 = num + length;
				T[] array2 = new T[num2];
				if (num > 0)
				{
					Array.Copy(array, array2, num);
				}
				array = array2;
			}
		}

		public static void Trim(string[] array)
		{
			if (array == null)
			{
				return;
			}
			int num = array.Length;
			if (num != 0)
			{
				for (int i = 0; i < num; i++)
				{
					array[i].Trim();
				}
			}
		}

		public static RaycastHit[] SortNearToFar(RaycastHit[] hits)
		{
			int num = hits.Length;
			if (hits == null || num == 0)
			{
				return null;
			}
			float[] array = new float[num];
			int[] array2 = new int[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = hits[i].distance;
			}
			for (int j = 0; j < num; j++)
			{
				bool flag = true;
				float num2 = -1f;
				int num3 = -1;
				for (int k = 0; k < num; k++)
				{
					float num4 = array[k];
					if (!(num4 < 0f) && (flag || num4 < num2))
					{
						if (flag)
						{
							flag = false;
						}
						num2 = num4;
						num3 = k;
					}
				}
				array2[j] = num3;
				array[num3] = -1f;
			}
			RaycastHit[] array3 = new RaycastHit[num];
			for (int l = 0; l < num; l++)
			{
				ref RaycastHit reference = ref array3[l];
				reference = hits[array2[l]];
			}
			return array3;
		}

		public static void MoveEntryUp<T>(T[] array, int index)
		{
			if (array != null)
			{
				int num = array.Length;
				if (num > 1 && index > 0 && index < num)
				{
					int num2 = index - 1;
					T val = array[num2];
					array[num2] = array[index];
					array[index] = val;
				}
			}
		}

		public static void MoveEntryDown<T>(T[] array, int index)
		{
			if (array != null)
			{
				int num = array.Length;
				if (num > 1 && index >= 0 && index < num - 1)
				{
					int num2 = index + 1;
					T val = array[num2];
					array[num2] = array[index];
					array[index] = val;
				}
			}
		}

		public static void Compact<T>(ref T[] array) where T : class
		{
			int num = ((array != null) ? array.Length : 0);
			if (num == 0)
			{
				return;
			}
			T[] array2 = null;
			for (int i = 0; i < num; i++)
			{
				if (array[i] != null)
				{
					Add(ref array2, array[i]);
				}
			}
			array = array2;
		}

		public static int IndexOf(int[] array, int value)
		{
			if (array == null)
			{
				return -1;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == value)
				{
					return i;
				}
			}
			return -1;
		}

		public static int IndexOf(float[] array, float value)
		{
			if (array == null)
			{
				return -1;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == value)
				{
					return i;
				}
			}
			return -1;
		}

		public static int IndexOf(short[] array, short value)
		{
			if (array == null)
			{
				return -1;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == value)
				{
					return i;
				}
			}
			return -1;
		}

		public static int IndexOf(ushort[] array, ushort value)
		{
			if (array == null)
			{
				return -1;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == value)
				{
					return i;
				}
			}
			return -1;
		}

		public static int IndexOf(uint[] array, uint value)
		{
			if (array == null)
			{
				return -1;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == value)
				{
					return i;
				}
			}
			return -1;
		}

		public static int IndexOf(double[] array, double value)
		{
			if (array == null)
			{
				return -1;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == value)
				{
					return i;
				}
			}
			return -1;
		}

		public static int IndexOf(bool[] array, bool value)
		{
			if (array == null)
			{
				return -1;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == value)
				{
					return i;
				}
			}
			return -1;
		}

		public static int IndexOf(string[] array, string value)
		{
			if (array == null)
			{
				return -1;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == value)
				{
					return i;
				}
			}
			return -1;
		}

		public static int IndexOf(string[] array, string value, StringComparison stringComparison)
		{
			if (array == null)
			{
				return -1;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i].Equals(value, stringComparison))
				{
					return i;
				}
			}
			return -1;
		}

		public static void Fill<T>(T[] array, T value)
		{
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = value;
				}
			}
		}

		public static void Fill<T>(T[] array, T value, int startIndex)
		{
			if (array != null)
			{
				if (startIndex < 0 || startIndex >= array.Length)
				{
					throw new ArgumentOutOfRangeException("startIndex");
				}
				for (int i = startIndex; i < array.Length; i++)
				{
					array[i] = value;
				}
			}
		}

		public static void Fill<T>(T[] array, T value, int startIndex, int length)
		{
			if (array != null)
			{
				if (startIndex < 0 || startIndex >= array.Length)
				{
					throw new ArgumentOutOfRangeException("startIndex");
				}
				length = MathTools.Clamp(startIndex + length, 0, array.Length);
				for (int i = startIndex; i < array.Length; i++)
				{
					array[i] = value;
				}
			}
		}

		public static void Populate<T>(T[] array, int startIndex, int length, Func<T> instantiator)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (length > 0)
			{
				if (startIndex < 0)
				{
					throw new ArgumentOutOfRangeException("startIndex must be >= 0");
				}
				if (startIndex >= length)
				{
					throw new ArgumentOutOfRangeException("startIndex must be < length");
				}
				if (length > array.Length)
				{
					throw new ArgumentOutOfRangeException("length must be <= array.Length");
				}
				if (startIndex + length > array.Length)
				{
					throw new ArgumentOutOfRangeException("startIndex + length must be <= array.Length");
				}
				for (int i = startIndex; i < startIndex + length; i++)
				{
					array[i] = instantiator();
				}
			}
		}

		public static void Populate<T>(T[] array, int startIndex, int length) where T : class, new()
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (length > 0)
			{
				if (startIndex < 0)
				{
					throw new ArgumentOutOfRangeException("startIndex must be >= 0");
				}
				if (startIndex >= length)
				{
					throw new ArgumentOutOfRangeException("startIndex must be < length");
				}
				if (length > array.Length)
				{
					throw new ArgumentOutOfRangeException("length must be <= array.Length");
				}
				if (startIndex + length > array.Length)
				{
					throw new ArgumentOutOfRangeException("startIndex + length must be <= array.Length");
				}
				for (int i = startIndex; i < startIndex + length; i++)
				{
					array[i] = new T();
				}
			}
		}

		public static void Populate<T>(T[] array) where T : class, new()
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			Populate(array, 0, array.Length);
		}

		public static void Populate<T>(T[] array, Func<T> instantiator)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			Populate(array, 0, array.Length, instantiator);
		}

		public static int Count<T>(T[] array, Predicate<T> predicate)
		{
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			if (array == null)
			{
				return 0;
			}
			int num = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (predicate(array[i]))
				{
					num++;
				}
			}
			return num;
		}

		public static bool IsEqual(byte[] a1, byte[] a2)
		{
			if (a1 == a2)
			{
				return true;
			}
			if (a1.Length != a2.Length)
			{
				return false;
			}
			for (int i = 0; i < a1.Length; i++)
			{
				if (a1[i] != a2[i])
				{
					return false;
				}
			}
			return true;
		}

		public static bool Contains(string[] array, string item, bool ignoreCase)
		{
			if (array == null)
			{
				return false;
			}
			int num = array.Length;
			for (int i = 0; i < num; i++)
			{
				if (ignoreCase)
				{
					if (array[i].Equals(item, StringComparison.OrdinalIgnoreCase))
					{
						return true;
					}
				}
				else if (array[i] == item)
				{
					return true;
				}
			}
			return false;
		}

		public static int AddIfUnique(ref string[] array, string item, bool ignoreCase)
		{
			if (array == null || array.Length == 0 || !Contains(array, item, ignoreCase))
			{
				return Add(ref array, item);
			}
			return -1;
		}

		public static void RemoveDuplicates(ref string[] array, bool ignoreCase)
		{
			int num = ((array != null) ? array.Length : 0);
			if (num != 0)
			{
				string[] array2 = null;
				for (int i = 0; i < num; i++)
				{
					AddIfUnique(ref array2, array[i], ignoreCase);
				}
				array = array2;
			}
		}

		public static bool Remove(ref string[] array, string item, bool ignoreCase)
		{
			if (array == null)
			{
				return false;
			}
			int num = array.Length;
			if (item == null)
			{
				for (int i = 0; i < num; i++)
				{
					if (array[i] == null)
					{
						RemoveAt(ref array, i);
						return true;
					}
				}
			}
			else
			{
				for (int j = 0; j < num; j++)
				{
					if (ignoreCase)
					{
						if (array[j] != null && array[j].Equals(item, StringComparison.OrdinalIgnoreCase))
						{
							RemoveAt(ref array, j);
							return true;
						}
					}
					else if (array[j] == item)
					{
						RemoveAt(ref array, j);
						return true;
					}
				}
			}
			return false;
		}

		public static string[] ToLowerStripSpaces(string[] array)
		{
			if (array == null)
			{
				return null;
			}
			if (array.Length == 0)
			{
				return null;
			}
			string[] array2 = new string[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					array2[i] = array[i].ToLower().Replace(" ", "");
				}
			}
			return array2;
		}

		public static int ToBitmask(bool[] array, int startIndex, int count = 32)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (startIndex < 0 || startIndex >= array.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex");
			}
			if (count <= 0 || startIndex + count > array.Length + 1)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (count > 32)
			{
				throw new ArgumentOutOfRangeException("count must be <= 32");
			}
			int num = 0;
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i])
				{
					num |= 1 << i;
				}
			}
			return num;
		}

		public static bool IsNullOrEmpty<T>(T[] array)
		{
			if (array == null)
			{
				return true;
			}
			if (array.Length == 0)
			{
				return true;
			}
			if (!typeof(T).IsClass)
			{
				return false;
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] != null)
				{
					return false;
				}
			}
			return true;
		}
	}
}
