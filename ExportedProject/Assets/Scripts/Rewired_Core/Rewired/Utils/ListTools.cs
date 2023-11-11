using System;
using System.Collections.Generic;

namespace Rewired.Utils
{
	public static class ListTools
	{
		public static bool OffsetAtIndex<T>(IList<T> list, int index, bool offsetDown, bool offsetNow = true)
		{
			if (list == null)
			{
				return false;
			}
			int count = list.Count;
			if (index < 0 || index >= count)
			{
				return false;
			}
			if (index == count - 1 && offsetDown)
			{
				return false;
			}
			if (index == 0 && !offsetDown)
			{
				return false;
			}
			if (!offsetNow)
			{
				return true;
			}
			T item = list[index];
			list.RemoveAt(index);
			int num = (offsetDown ? 1 : (-1));
			if (offsetDown && index + num >= count)
			{
				list.Add(item);
				return true;
			}
			list.Insert(index + num, item);
			return true;
		}

		public static List<T> ShallowCopy<T>(List<T> list)
		{
			if (list == null)
			{
				return null;
			}
			int count = list.Count;
			List<T> list2 = new List<T>(count);
			for (int i = 0; i < count; i++)
			{
				list2.Add(list[i]);
			}
			return list2;
		}

		public static bool CopyTo<T>(IList<T> fromList, IList<T> toList)
		{
			return CopyTo(fromList, toList, 0, -1);
		}

		public static bool CopyTo<T>(IList<T> fromList, IList<T> toList, int fromListStartIndex)
		{
			return CopyTo(fromList, toList, fromListStartIndex, -1);
		}

		public static bool CopyTo<T>(IList<T> fromList, IList<T> toList, int fromListStartIndex, int count)
		{
			if (fromList == null || toList == null)
			{
				return false;
			}
			int count2 = fromList.Count;
			if (fromListStartIndex < 0)
			{
				fromListStartIndex = 0;
			}
			if (fromListStartIndex >= count2)
			{
				return false;
			}
			if (count <= 0)
			{
				count = count2 - fromListStartIndex;
			}
			for (int i = fromListStartIndex; i < count; i++)
			{
				toList.Add(fromList[i]);
			}
			return true;
		}

		public static T[] ToArray<T>(IList<T> list)
		{
			if (list == null)
			{
				return null;
			}
			int count = list.Count;
			T[] array = new T[count];
			for (int i = 0; i < count; i++)
			{
				array[i] = list[i];
			}
			return array;
		}

		public static List<T> Combine<T>(IList<T> list1, IList<T> list2)
		{
			int num = list1?.Count ?? 0;
			int num2 = list2?.Count ?? 0;
			int capacity = num + num2;
			List<T> list3 = new List<T>(capacity);
			for (int i = 0; i < num; i++)
			{
				list3.Add(list1[i]);
			}
			for (int j = 0; j < num2; j++)
			{
				list3.Add(list2[j]);
			}
			return list3;
		}

		public static bool IsNullOrEmpty<T>(IList<T> list)
		{
			if (list == null)
			{
				return true;
			}
			int count = list.Count;
			if (count == 0)
			{
				return true;
			}
			if (!typeof(T).IsClass)
			{
				return false;
			}
			for (int i = 0; i < count; i++)
			{
				if (list[i] != null)
				{
					return false;
				}
			}
			return true;
		}

		public static List<object> ConvertToObjeclist<T>(IList<T> list)
		{
			List<object> list2 = new List<object>(list.Count);
			for (int i = 0; i < list.Count; i++)
			{
				list2.Add(list[i]);
			}
			return list2;
		}

		public static void Concat<T>(IList<T> list1, IList<T> list2)
		{
			if (list1 != null && list2 != null)
			{
				for (int i = 0; i < list2.Count; i++)
				{
					list1.Add(list2[i]);
				}
			}
		}

		public static bool AddIfUnique<T>(IList<T> list, T item)
		{
			if (list == null)
			{
				return false;
			}
			if (list.Contains(item))
			{
				return false;
			}
			list.Add(item);
			return true;
		}

		public static int Count<T>(IList<T> list, Predicate<T> predicate)
		{
			if (list == null)
			{
				return 0;
			}
			int count = list.Count;
			int num = 0;
			for (int i = 0; i < count; i++)
			{
				if (predicate(list[i]))
				{
					num++;
				}
			}
			return num;
		}

		public static void TryClear<T>(IList<T> list)
		{
			list?.Clear();
		}

		private static bool UkIIJqRiErHeumjgvgcsRpsMaEt<T>(IList<T> P_0, T P_1)
		{
			if (P_0 == null)
			{
				return false;
			}
			P_0.Add(P_1);
			return true;
		}

		public static int AddAndCreateList<T>(ref IList<T> list, T item)
		{
			if (list == null)
			{
				list = new List<T>();
			}
			list.Add(item);
			return list.Count - 1;
		}

		public static T Find<T>(IList<T> list, Predicate<T> predicate)
		{
			if (list == null || predicate == null)
			{
				return default(T);
			}
			int count = list.Count;
			for (int i = 0; i < count; i++)
			{
				if (predicate(list[i]))
				{
					return list[i];
				}
			}
			return default(T);
		}
	}
}
