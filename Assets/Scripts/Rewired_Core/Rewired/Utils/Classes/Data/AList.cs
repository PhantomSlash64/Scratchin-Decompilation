using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using UnityEngine;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class AList<T> : IList, IEnumerable, ICollection, IEnumerable<T>, ICollection<T>, IList<T>
	{
		[Serializable]
		public struct ENfkWYyPuxNxVEOjVJMeEvqqWNQ : IDisposable, IEnumerator, IEnumerator<T>
		{
			private AList<T> list;

			private int index;

			private int version;

			private T current;

			public T Current => current;

			object IEnumerator.ZlwxPJZKvbBIvjzLsDglEywvcZQ
			{
				get
				{
					if (index == 0 || index == list._count + 1)
					{
						throw new InvalidOperationException();
					}
					return Current;
				}
			}

			internal ENfkWYyPuxNxVEOjVJMeEvqqWNQ(AList<T> list)
			{
				this.list = list;
				index = 0;
				version = list.WXuCbimssDdLmCLcKcnRVhkhcwYV;
				current = default(T);
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				AList<T> aList = list;
				if (version == aList.WXuCbimssDdLmCLcKcnRVhkhcwYV && (uint)index < (uint)aList._count)
				{
					current = aList._items[index];
					index++;
					return true;
				}
				return QFemHleYnRPIXTGexILLJDLakhsG();
			}

			private bool QFemHleYnRPIXTGexILLJDLakhsG()
			{
				if (version != list.WXuCbimssDdLmCLcKcnRVhkhcwYV)
				{
					throw new InvalidOperationException("List was changed.");
				}
				index = list._count + 1;
				current = default(T);
				return false;
			}

			void IEnumerator.Reset()
			{
				if (version != list.WXuCbimssDdLmCLcKcnRVhkhcwYV)
				{
					throw new InvalidOperationException("List was changed.");
				}
				index = 0;
				current = default(T);
			}
		}

		private const int qiHcFtHgYFYnkjovBdGofsbyCLI = 4;

		private static readonly T[] mSPpYCkqyIqUamqhPbQFEgMxXUvO = new T[0];

		private IEqualityComparer<T> nkJlnwMjDCoZoyOzJJUrDmuqydL = EqualityComparerNoAlloc<T>.Default;

		public T[] _items;

		private int nfDdeELnrQwKNlRDjFNLWWngAhc;

		public int _count;

		private int vlraAekOhoNdcAUiGZUbnWTUvMz;

		private bool etUuVssALddmzHqsmhhVcdMCxBZt;

		private readonly int uMvxWzuspNUlZfavElNAxmZxnhI;

		private readonly bool QObgKTAnsiYQwsaVufkVPvhzZbw;

		private int WXuCbimssDdLmCLcKcnRVhkhcwYV;

		[NonSerialized]
		private object TrZjRKalWAjNtJflHkrpVcJzHYF;

		public int Count => _count;

		public int Capacity => nfDdeELnrQwKNlRDjFNLWWngAhc;

		public int FreeSpace => uMvxWzuspNUlZfavElNAxmZxnhI - _count;

		public bool IsFixedSize => !QObgKTAnsiYQwsaVufkVPvhzZbw;

		public IEqualityComparer<T> EqualityComparer
		{
			get
			{
				return nkJlnwMjDCoZoyOzJJUrDmuqydL;
			}
			set
			{
				if (value == null)
				{
					value = EqualityComparerNoAlloc<T>.Default;
				}
				nkJlnwMjDCoZoyOzJJUrDmuqydL = value;
			}
		}

		public int Version => WXuCbimssDdLmCLcKcnRVhkhcwYV;

		public T this[int index]
		{
			get
			{
				if ((uint)index >= (uint)_count)
				{
					throw new IndexOutOfRangeException();
				}
				return _items[index];
			}
			set
			{
				if ((uint)index >= (uint)_count)
				{
					throw new IndexOutOfRangeException();
				}
				_items[index] = value;
				WXuCbimssDdLmCLcKcnRVhkhcwYV++;
			}
		}

		bool ICollection<T>.IsReadOnly => false;

		bool IList.IsReadOnly => false;

		object IList.this[int index]
		{
			get
			{
				return this[index];
			}
			set
			{
				if (!IOvaQRbHyCsKsditjMaHhuiQpfK(value))
				{
					throw new ArgumentException("value is an incompatible type.");
				}
				this[index] = (T)value;
			}
		}

		int ICollection.Count => _count;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot
		{
			get
			{
				if (TrZjRKalWAjNtJflHkrpVcJzHYF == null)
				{
					Interlocked.CompareExchange<object>(ref TrZjRKalWAjNtJflHkrpVcJzHYF, new object(), (object)null);
				}
				return TrZjRKalWAjNtJflHkrpVcJzHYF;
			}
		}

		public AList()
			: this(0, 0, 0)
		{
		}

		public AList(int startingCapacity)
			: this(startingCapacity, 0, 0)
		{
		}

		public AList(int startingCapacity, int maxCapacity)
			: this(startingCapacity, maxCapacity, 0)
		{
		}

		public AList(int startingCapacity, int maxCapacity, int expansionIncrement)
		{
			if (startingCapacity < 0)
			{
				throw new ArgumentOutOfRangeException("startingCapacity cannot be a negative value.");
			}
			if (expansionIncrement < 0)
			{
				expansionIncrement = 0;
			}
			if (maxCapacity < 0)
			{
				maxCapacity = 0;
			}
			if (startingCapacity > 0 && maxCapacity > 0 && maxCapacity < startingCapacity)
			{
				throw new ArgumentOutOfRangeException("maxCapacity must be >= startingCapacity or zero for unlimited.");
			}
			if (maxCapacity == 0 || maxCapacity > startingCapacity)
			{
				QObgKTAnsiYQwsaVufkVPvhzZbw = true;
			}
			if (!QObgKTAnsiYQwsaVufkVPvhzZbw && startingCapacity == 0)
			{
				throw new ArgumentOutOfRangeException("startingCapacity must be > 0 if non-expandable.");
			}
			if (QObgKTAnsiYQwsaVufkVPvhzZbw && expansionIncrement == 0)
			{
				etUuVssALddmzHqsmhhVcdMCxBZt = true;
				expansionIncrement = 1;
			}
			vlraAekOhoNdcAUiGZUbnWTUvMz = expansionIncrement;
			nfDdeELnrQwKNlRDjFNLWWngAhc = startingCapacity;
			uMvxWzuspNUlZfavElNAxmZxnhI = ((maxCapacity == 0) ? int.MaxValue : maxCapacity);
			_count = 0;
			if (nfDdeELnrQwKNlRDjFNLWWngAhc == 0)
			{
				_items = mSPpYCkqyIqUamqhPbQFEgMxXUvO;
			}
			else
			{
				_items = new T[startingCapacity];
			}
		}

		public AList(IEnumerable<T> collection)
			: this(collection, 0, 0)
		{
		}

		public AList(IEnumerable<T> collection, int maxCapacity, int expansionIncrement)
		{
			if (collection == null)
			{
				throw new ArgumentNullException("collection");
			}
			if (expansionIncrement < 0)
			{
				expansionIncrement = 0;
			}
			if (maxCapacity < 0)
			{
				maxCapacity = 0;
			}
			T[] array = null;
			if (collection is ICollection<T> collection2)
			{
				int count = collection2.Count;
				if (count == 0)
				{
					array = mSPpYCkqyIqUamqhPbQFEgMxXUvO;
				}
				else
				{
					array = new T[count];
					collection2.CopyTo(array, 0);
				}
			}
			else
			{
				using IEnumerator<T> enumerator = collection.GetEnumerator();
				List<T> list = new List<T>();
				while (enumerator.MoveNext())
				{
					list.Add(enumerator.Current);
				}
				if (list.Count > 0)
				{
					array = list.ToArray();
				}
			}
			int num = ((array != null) ? array.Length : 0);
			if (num > 0 && maxCapacity > 0 && maxCapacity < num)
			{
				throw new ArgumentOutOfRangeException("maxCapacity must be >= startingCapacity or zero for unlimited.");
			}
			if (maxCapacity == 0 || maxCapacity > num)
			{
				QObgKTAnsiYQwsaVufkVPvhzZbw = true;
			}
			if (!QObgKTAnsiYQwsaVufkVPvhzZbw && num == 0)
			{
				throw new ArgumentOutOfRangeException("startingCapacity must be > 0 if non-expandable.");
			}
			if (QObgKTAnsiYQwsaVufkVPvhzZbw && expansionIncrement == 0)
			{
				etUuVssALddmzHqsmhhVcdMCxBZt = true;
				expansionIncrement = 1;
			}
			vlraAekOhoNdcAUiGZUbnWTUvMz = expansionIncrement;
			nfDdeELnrQwKNlRDjFNLWWngAhc = num;
			uMvxWzuspNUlZfavElNAxmZxnhI = ((maxCapacity == 0) ? int.MaxValue : maxCapacity);
			_items = ((array != null) ? array : mSPpYCkqyIqUamqhPbQFEgMxXUvO);
			_count = num;
		}

		public T GetRandom()
		{
			if (_count == 0)
			{
				return default(T);
			}
			return _items[UnityEngine.Random.Range(0, _count)];
		}

		public int Add(T item)
		{
			if (_count == nfDdeELnrQwKNlRDjFNLWWngAhc && cMQMLNobbJwlGKqvplXJxyaZYMe(vlraAekOhoNdcAUiGZUbnWTUvMz) == 0)
			{
				return -1;
			}
			int count = _count;
			_items[count] = item;
			_count++;
			return count;
		}

		public bool Add(T[] items, int count = 0, int startIndex = 0, bool allowPartialAdd = false)
		{
			if (items == null || items.Length == 0)
			{
				return true;
			}
			if ((uint)startIndex >= (uint)items.Length)
			{
				throw new ArgumentOutOfRangeException("startIndex");
			}
			if (count + startIndex > items.Length)
			{
				throw new ArgumentOutOfRangeException("count + startIndex cannot be larger than the array.");
			}
			if (count <= 0)
			{
				count = items.Length - startIndex;
			}
			if (count == 0)
			{
				return true;
			}
			int num = nfDdeELnrQwKNlRDjFNLWWngAhc - _count;
			if (count > num)
			{
				int num2 = cMQMLNobbJwlGKqvplXJxyaZYMe(Math.Max(num, vlraAekOhoNdcAUiGZUbnWTUvMz), true);
				if (num2 == 0)
				{
					return false;
				}
				if (num2 < count && !allowPartialAdd)
				{
					return false;
				}
				count = cMQMLNobbJwlGKqvplXJxyaZYMe(Math.Max(num, vlraAekOhoNdcAUiGZUbnWTUvMz));
			}
			Array.Copy(items, startIndex, _items, _count, count);
			_count += count;
			WXuCbimssDdLmCLcKcnRVhkhcwYV++;
			return true;
		}

		public bool Add(AList<T> items, int count = 0, int startIndex = 0, bool allowPartialAdd = false)
		{
			if (items == null || items._count == 0)
			{
				return true;
			}
			if ((uint)startIndex >= (uint)items._count)
			{
				throw new ArgumentOutOfRangeException("startIndex");
			}
			if (count + startIndex > items._count)
			{
				throw new ArgumentOutOfRangeException("count + startIndex cannot be larger than the list.");
			}
			if (count <= 0)
			{
				count = items._count - startIndex;
			}
			if (count == 0)
			{
				return true;
			}
			int num = nfDdeELnrQwKNlRDjFNLWWngAhc - _count;
			if (count > num)
			{
				int num2 = cMQMLNobbJwlGKqvplXJxyaZYMe(Math.Max(num, vlraAekOhoNdcAUiGZUbnWTUvMz), true);
				if (num2 == 0)
				{
					return false;
				}
				if (num2 < count && !allowPartialAdd)
				{
					return false;
				}
				count = cMQMLNobbJwlGKqvplXJxyaZYMe(Math.Max(num, vlraAekOhoNdcAUiGZUbnWTUvMz));
			}
			Array.Copy(items._items, startIndex, _items, _count, count);
			_count += count;
			WXuCbimssDdLmCLcKcnRVhkhcwYV++;
			return true;
		}

		public int AddIfUnique(T item)
		{
			int num = IndexOf(item);
			if (num >= 0)
			{
				return num;
			}
			return Add(item);
		}

		public int AddToFirstOpenSpace(T item)
		{
			T y = default(T);
			for (int i = 0; i < _count; i++)
			{
				if (nkJlnwMjDCoZoyOzJJUrDmuqydL.Equals(_items[i], y))
				{
					_items[i] = item;
					return i;
				}
			}
			if (_count < uMvxWzuspNUlZfavElNAxmZxnhI)
			{
				return Add(item);
			}
			return -1;
		}

		public int AddToFirstOpenSpace(T item, T openSpaceEquals)
		{
			for (int i = 0; i < _count; i++)
			{
				if (nkJlnwMjDCoZoyOzJJUrDmuqydL.Equals(_items[i], openSpaceEquals))
				{
					_items[i] = item;
					return i;
				}
			}
			if (_count < uMvxWzuspNUlZfavElNAxmZxnhI)
			{
				return Add(item);
			}
			return -1;
		}

		public bool Insert(int index, T item)
		{
			if (index < 0 || index > _count)
			{
				throw new IndexOutOfRangeException();
			}
			if (_count == nfDdeELnrQwKNlRDjFNLWWngAhc && cMQMLNobbJwlGKqvplXJxyaZYMe(vlraAekOhoNdcAUiGZUbnWTUvMz) == 0)
			{
				return false;
			}
			if (index < _count)
			{
				Array.Copy(_items, index, _items, index + 1, _count - index);
			}
			_items[index] = item;
			_count++;
			WXuCbimssDdLmCLcKcnRVhkhcwYV++;
			return true;
		}

		public bool Remove(T item)
		{
			int num = IndexOf(item);
			if (num < 0)
			{
				return false;
			}
			RemoveAt(num);
			return true;
		}

		public void RemoveAt(int index)
		{
			if (index < 0 || index >= _count)
			{
				throw new IndexOutOfRangeException();
			}
			_count--;
			if (index < _count)
			{
				Array.Copy(_items, index + 1, _items, index, _count - index);
			}
			_items[_count] = default(T);
			WXuCbimssDdLmCLcKcnRVhkhcwYV++;
		}

		public bool Contains(T item)
		{
			return Contains(item, nkJlnwMjDCoZoyOzJJUrDmuqydL);
		}

		public bool Contains(T item, IEqualityComparer<T> comparer)
		{
			if (comparer == null)
			{
				throw new ArgumentNullException("comparer");
			}
			for (int i = 0; i < _count; i++)
			{
				if (comparer.Equals(_items[i], item))
				{
					return true;
				}
			}
			return false;
		}

		public int IndexOf(T item)
		{
			return IndexOf(item, nkJlnwMjDCoZoyOzJJUrDmuqydL);
		}

		public int IndexOf(T item, int index)
		{
			return IndexOf(item, index, nkJlnwMjDCoZoyOzJJUrDmuqydL);
		}

		public int IndexOf(T item, int index, int count)
		{
			return IndexOf(item, index, count, nkJlnwMjDCoZoyOzJJUrDmuqydL);
		}

		public int IndexOf(T item, IEqualityComparer<T> comparer)
		{
			if (comparer == null)
			{
				throw new ArgumentNullException("comparer");
			}
			for (int i = 0; i < _count; i++)
			{
				if (comparer.Equals(_items[i], item))
				{
					return i;
				}
			}
			return -1;
		}

		public int IndexOf(T item, int index, IEqualityComparer<T> comparer)
		{
			if (index < 0 || index >= _count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			for (int i = index; i < _count; i++)
			{
				if (comparer.Equals(_items[i], item))
				{
					return i;
				}
			}
			return -1;
		}

		public int IndexOf(T item, int index, int count, IEqualityComparer<T> comparer)
		{
			if (index < 0 || index >= _count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (index + count > _count)
			{
				throw new ArgumentOutOfRangeException();
			}
			int num = index + count;
			for (int i = index; i < num; i++)
			{
				if (comparer.Equals(_items[i], item))
				{
					return i;
				}
			}
			return -1;
		}

		public void Reverse()
		{
			Reverse(0, Count);
		}

		public void Reverse(int index, int count)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (_count - index < count)
			{
				throw new ArgumentOutOfRangeException();
			}
			Array.Reverse((Array)_items, index, count);
			WXuCbimssDdLmCLcKcnRVhkhcwYV++;
		}

		public void Sort()
		{
			Sort(0, Count, null);
		}

		public void Sort(IComparer<T> comparer)
		{
			Sort(0, Count, comparer);
		}

		public void Sort(int index, int count, IComparer<T> comparer)
		{
			if (index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (_count - index < count)
			{
				throw new ArgumentOutOfRangeException();
			}
			Array.Sort(_items, index, count, comparer);
			WXuCbimssDdLmCLcKcnRVhkhcwYV++;
		}

		public List<T> GetRange(int index, int count)
		{
			if (index < 0 || index >= _count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (_count - index < count)
			{
				throw new ArgumentOutOfRangeException();
			}
			T[] array = new T[count];
			Array.Copy(_items, index, array, 0, count);
			return new List<T>(array);
		}

		public ReadOnlyCollection<T> AsReadOnly()
		{
			return new ReadOnlyCollection<T>(this);
		}

		public bool Exists(Predicate<T> match)
		{
			return FindIndex(match) != -1;
		}

		public T Find(Predicate<T> match)
		{
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			for (int i = 0; i < _count; i++)
			{
				if (match(_items[i]))
				{
					return _items[i];
				}
			}
			return default(T);
		}

		public List<T> FindAll(Predicate<T> match)
		{
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			List<T> list = new List<T>();
			for (int i = 0; i < _count; i++)
			{
				if (match(_items[i]))
				{
					list.Add(_items[i]);
				}
			}
			return list;
		}

		public int FindIndex(Predicate<T> match)
		{
			return FindIndex(0, _count, match);
		}

		public int FindIndex(int startIndex, Predicate<T> match)
		{
			return FindIndex(startIndex, _count - startIndex, match);
		}

		public int FindIndex(int startIndex, int count, Predicate<T> match)
		{
			if ((uint)startIndex > (uint)_count)
			{
				throw new ArgumentNullException("startIndex");
			}
			if (count < 0 || startIndex > _count - count)
			{
				throw new ArgumentOutOfRangeException();
			}
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			int num = startIndex + count;
			for (int i = startIndex; i < num; i++)
			{
				if (match(_items[i]))
				{
					return i;
				}
			}
			return -1;
		}

		public T FindLast(Predicate<T> match)
		{
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			for (int num = _count - 1; num >= 0; num--)
			{
				if (match(_items[num]))
				{
					return _items[num];
				}
			}
			return default(T);
		}

		public int FindLastIndex(Predicate<T> match)
		{
			return FindLastIndex(_count - 1, _count, match);
		}

		public int FindLastIndex(int startIndex, Predicate<T> match)
		{
			return FindLastIndex(startIndex, startIndex + 1, match);
		}

		public int FindLastIndex(int startIndex, int count, Predicate<T> match)
		{
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			if (_count == 0)
			{
				if (startIndex != -1)
				{
					throw new ArgumentOutOfRangeException("startIndex");
				}
			}
			else if ((uint)startIndex >= (uint)_count)
			{
				throw new ArgumentOutOfRangeException("startIndex");
			}
			if (count < 0 || startIndex - count + 1 < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			int num = startIndex - count;
			for (int num2 = startIndex; num2 > num; num2--)
			{
				if (match(_items[num2]))
				{
					return num2;
				}
			}
			return -1;
		}

		public void ForEach(Action<T> action)
		{
			if (_count == 0)
			{
				return;
			}
			if (action == null)
			{
				throw new ArgumentNullException("action");
			}
			int wXuCbimssDdLmCLcKcnRVhkhcwYV = WXuCbimssDdLmCLcKcnRVhkhcwYV;
			for (int i = 0; i < _count; i++)
			{
				if (wXuCbimssDdLmCLcKcnRVhkhcwYV != WXuCbimssDdLmCLcKcnRVhkhcwYV)
				{
					break;
				}
				action(_items[i]);
			}
			if (wXuCbimssDdLmCLcKcnRVhkhcwYV == WXuCbimssDdLmCLcKcnRVhkhcwYV)
			{
				return;
			}
			throw new Exception("List was changed.");
		}

		public int LastIndexOf(T item)
		{
			if (_count == 0)
			{
				return -1;
			}
			return LastIndexOf(item, _count - 1, _count);
		}

		public int LastIndexOf(T item, int index)
		{
			if (index < 0 || index >= _count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return LastIndexOf(item, index, index + 1);
		}

		public int LastIndexOf(T item, int index, int count)
		{
			if (_count != 0 && index < 0)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (_count != 0 && count < 0)
			{
				throw new ArgumentOutOfRangeException("count");
			}
			if (_count == 0)
			{
				return -1;
			}
			if (index >= _count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (count > index + 1)
			{
				throw new ArgumentOutOfRangeException();
			}
			return Array.LastIndexOf(_items, item, index, count);
		}

		public int RemoveAll(Predicate<T> match)
		{
			if (_count == 0)
			{
				return 0;
			}
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			int i;
			for (i = 0; i < _count && !match(_items[i]); i++)
			{
			}
			if (i >= _count)
			{
				return 0;
			}
			int j = i + 1;
			while (j < _count)
			{
				for (; j < _count && match(_items[j]); j++)
				{
				}
				if (j < _count)
				{
					_items[i++] = _items[j++];
				}
			}
			Array.Clear(_items, i, _count - i);
			int result = _count - i;
			_count = i;
			WXuCbimssDdLmCLcKcnRVhkhcwYV++;
			return result;
		}

		public bool TrueForAll(Predicate<T> match)
		{
			if (match == null)
			{
				throw new ArgumentNullException("match");
			}
			for (int i = 0; i < _count; i++)
			{
				if (!match(_items[i]))
				{
					return false;
				}
			}
			return true;
		}

		public T[] ToArray()
		{
			T[] array = new T[_count];
			Array.Copy(_items, 0, array, 0, _count);
			return array;
		}

		public void CopyTo(int index, T[] array, int arrayIndex, int count)
		{
			if (_count - index < count)
			{
				throw new ArgumentOutOfRangeException();
			}
			Array.Copy(_items, index, array, arrayIndex, count);
		}

		public void CopyTo(T[] array, int arrayIndex)
		{
			Array.Copy(_items, 0, array, arrayIndex, _count);
		}

		public void Clear()
		{
			Array.Clear(_items, 0, _count);
			_count = 0;
			WXuCbimssDdLmCLcKcnRVhkhcwYV++;
		}

		public void TrimExcess()
		{
			if (QObgKTAnsiYQwsaVufkVPvhzZbw && _count != nfDdeELnrQwKNlRDjFNLWWngAhc)
			{
				ctOLgCKaxwNOBwmyGauwaNdICgr(_count);
				WXuCbimssDdLmCLcKcnRVhkhcwYV++;
			}
		}

		private int cMQMLNobbJwlGKqvplXJxyaZYMe(int P_0, bool P_1 = false)
		{
			if (!QObgKTAnsiYQwsaVufkVPvhzZbw)
			{
				return 0;
			}
			if (nfDdeELnrQwKNlRDjFNLWWngAhc >= uMvxWzuspNUlZfavElNAxmZxnhI)
			{
				return 0;
			}
			if (etUuVssALddmzHqsmhhVcdMCxBZt)
			{
				P_0 = iXBRuTecrzrTCMqiIMhmzepPNlq(nfDdeELnrQwKNlRDjFNLWWngAhc, P_0);
			}
			P_0 = Math.Min(P_0, uMvxWzuspNUlZfavElNAxmZxnhI - nfDdeELnrQwKNlRDjFNLWWngAhc);
			if (P_0 <= 0)
			{
				return 0;
			}
			if (!ctOLgCKaxwNOBwmyGauwaNdICgr(nfDdeELnrQwKNlRDjFNLWWngAhc + P_0))
			{
				return 0;
			}
			return P_0;
		}

		private int iXBRuTecrzrTCMqiIMhmzepPNlq(int P_0, int P_1)
		{
			int num = P_0 + P_1;
			if (num < 4)
			{
				num = 4;
			}
			uint num2 = MathTools.RoundUpToPowerOf2((uint)num);
			if (num2 > int.MaxValue)
			{
				num2 = 2147483647u;
			}
			return (int)num2 - P_0;
		}

		private bool ctOLgCKaxwNOBwmyGauwaNdICgr(int P_0, bool P_1 = false)
		{
			if (P_0 < 0)
			{
				P_0 = 0;
			}
			if (P_0 > uMvxWzuspNUlZfavElNAxmZxnhI)
			{
				return false;
			}
			if (P_0 == nfDdeELnrQwKNlRDjFNLWWngAhc)
			{
				return true;
			}
			if (P_1)
			{
				return true;
			}
			T[] array = new T[P_0];
			if (P_0 != 0)
			{
				Array.Copy(_items, array, Math.Min(P_0, nfDdeELnrQwKNlRDjFNLWWngAhc));
			}
			nfDdeELnrQwKNlRDjFNLWWngAhc = P_0;
			if (_count > P_0)
			{
				_count = P_0;
			}
			_items = array;
			return true;
		}

		void IList<T>.Insert(int index, T item)
		{
			Insert(index, item);
		}

		void ICollection<T>.Add(T item)
		{
			if (Add(item) < 0)
			{
				throw new Exception("List has no more space. Cannot add item.");
			}
		}

		void ICollection<T>.CopyTo(T[] array, int arrayIndex)
		{
			if (array != null && array.Rank != 1)
			{
				throw new ArgumentException("Multi-dimensional arrays are not supported.");
			}
			Array.Copy(_items, 0, array, arrayIndex, _count);
		}

		void ICollection.CopyTo(Array array, int index)
		{
			if (array != null && array.Rank != 1)
			{
				throw new ArgumentException("Multi-dimensional arrays are not supported.");
			}
			try
			{
				Array.Copy(_items, 0, array, index, _count);
			}
			catch (ArrayTypeMismatchException)
			{
				throw new ArgumentException("Invalid array type.");
			}
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return new ENfkWYyPuxNxVEOjVJMeEvqqWNQ(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new ENfkWYyPuxNxVEOjVJMeEvqqWNQ(this);
		}

		int IList.Add(object value)
		{
			if (!IOvaQRbHyCsKsditjMaHhuiQpfK(value))
			{
				throw new ArgumentException("value is an incompatible type.");
			}
			return Add((T)value);
		}

		bool IList.Contains(object value)
		{
			if (!IOvaQRbHyCsKsditjMaHhuiQpfK(value))
			{
				throw new ArgumentException("value is an incompatible type.");
			}
			return Contains((T)value);
		}

		int IList.IndexOf(object value)
		{
			if (!IOvaQRbHyCsKsditjMaHhuiQpfK(value))
			{
				throw new ArgumentException("value is an incompatible type.");
			}
			return IndexOf((T)value);
		}

		void IList.Insert(int index, object value)
		{
			if (!IOvaQRbHyCsKsditjMaHhuiQpfK(value))
			{
				throw new ArgumentException("value is an incompatible type.");
			}
			Insert(index, (T)value);
		}

		void IList.Remove(object value)
		{
			if (!IOvaQRbHyCsKsditjMaHhuiQpfK(value))
			{
				throw new ArgumentException("value is an incompatible type.");
			}
			Remove((T)value);
		}

		public static AList<T> CreateFixedLengthList(int capacity)
		{
			return new AList<T>(capacity, capacity, 0);
		}

		private static bool IOvaQRbHyCsKsditjMaHhuiQpfK(object P_0)
		{
			if (!(P_0 is T))
			{
				if (P_0 == null)
				{
					return default(T) == null;
				}
				return false;
			}
			return true;
		}
	}
}
