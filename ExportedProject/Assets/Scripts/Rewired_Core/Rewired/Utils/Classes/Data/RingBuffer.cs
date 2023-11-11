using System;
using System.Collections;
using System.Collections.Generic;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal sealed class RingBuffer<T> : IEnumerable, IEnumerable<T>, ICollection<T>
	{
		[Serializable]
		public struct VfafkueWlXlStBSNQnHKiRPebQkZ : IDisposable, IEnumerator, IEnumerator<T>
		{
			private RingBuffer<T> buffer;

			private int index;

			private int version;

			private T current;

			public T Current => current;

			object IEnumerator.ZlwxPJZKvbBIvjzLsDglEywvcZQ
			{
				get
				{
					if (index == 0 || index == buffer.OlNDKUfTXODfsuYHoRqmBeyGOdJC + 1)
					{
						throw new InvalidOperationException();
					}
					return Current;
				}
			}

			internal VfafkueWlXlStBSNQnHKiRPebQkZ(RingBuffer<T> buffer)
			{
				this.buffer = buffer;
				index = 0;
				version = buffer.WXuCbimssDdLmCLcKcnRVhkhcwYV;
				current = default(T);
			}

			public void Dispose()
			{
			}

			public bool MoveNext()
			{
				if (version == buffer.WXuCbimssDdLmCLcKcnRVhkhcwYV && (uint)index < (uint)buffer.OlNDKUfTXODfsuYHoRqmBeyGOdJC)
				{
					current = buffer[index];
					index++;
					return true;
				}
				return QFemHleYnRPIXTGexILLJDLakhsG();
			}

			private bool QFemHleYnRPIXTGexILLJDLakhsG()
			{
				if (version != buffer.WXuCbimssDdLmCLcKcnRVhkhcwYV)
				{
					throw new InvalidOperationException("RingBuffer was changed.");
				}
				index = buffer.OlNDKUfTXODfsuYHoRqmBeyGOdJC + 1;
				current = default(T);
				return false;
			}

			void IEnumerator.Reset()
			{
				if (version != buffer.WXuCbimssDdLmCLcKcnRVhkhcwYV)
				{
					throw new InvalidOperationException("RingBuffer was changed.");
				}
				index = 0;
				current = default(T);
			}
		}

		private readonly T[] mCcGEqkjMlkdLIrXjIaiVhutUrp;

		private readonly int nfDdeELnrQwKNlRDjFNLWWngAhc;

		private int rqjFXveLphnbEdgNwMHGdxevUWnl;

		private int FseotGPSmvLNzqctDqncUFwgRlQ;

		private int OlNDKUfTXODfsuYHoRqmBeyGOdJC;

		private int qrPyJHXGPctCxLBjDbEjPuDtHDj;

		private int WXuCbimssDdLmCLcKcnRVhkhcwYV;

		private IEqualityComparer<T> nkJlnwMjDCoZoyOzJJUrDmuqydL = EqualityComparerNoAlloc<T>.Default;

		public int Count => OlNDKUfTXODfsuYHoRqmBeyGOdJC;

		public int Capacity => nfDdeELnrQwKNlRDjFNLWWngAhc;

		public int OverrunCount => qrPyJHXGPctCxLBjDbEjPuDtHDj;

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

		public T this[int index]
		{
			get
			{
				int num = USpxJzgBYIpbEERBBSBBrkuiqhY(index);
				if (!samgOiDNFoWWKkSkFjAebzebuYbg(num))
				{
					throw new IndexOutOfRangeException();
				}
				return mCcGEqkjMlkdLIrXjIaiVhutUrp[num];
			}
			set
			{
				int num = USpxJzgBYIpbEERBBSBBrkuiqhY(index);
				if (!samgOiDNFoWWKkSkFjAebzebuYbg(num))
				{
					throw new IndexOutOfRangeException();
				}
				mCcGEqkjMlkdLIrXjIaiVhutUrp[num] = value;
			}
		}

		int ICollection<T>.Count => Count;

		bool ICollection<T>.IsReadOnly => false;

		public RingBuffer(int capacity)
		{
			if (capacity <= 0)
			{
				throw new ArgumentOutOfRangeException("capacity must be > 0.");
			}
			mCcGEqkjMlkdLIrXjIaiVhutUrp = new T[capacity];
			nfDdeELnrQwKNlRDjFNLWWngAhc = capacity;
			Clear();
		}

		public void Enqueue(T item)
		{
			rqjFXveLphnbEdgNwMHGdxevUWnl = ((rqjFXveLphnbEdgNwMHGdxevUWnl < nfDdeELnrQwKNlRDjFNLWWngAhc - 1) ? (rqjFXveLphnbEdgNwMHGdxevUWnl + 1) : 0);
			if (OlNDKUfTXODfsuYHoRqmBeyGOdJC == 0)
			{
				FseotGPSmvLNzqctDqncUFwgRlQ = 0;
			}
			else if (rqjFXveLphnbEdgNwMHGdxevUWnl == FseotGPSmvLNzqctDqncUFwgRlQ)
			{
				FseotGPSmvLNzqctDqncUFwgRlQ = ((FseotGPSmvLNzqctDqncUFwgRlQ < nfDdeELnrQwKNlRDjFNLWWngAhc - 1) ? (FseotGPSmvLNzqctDqncUFwgRlQ + 1) : 0);
				qrPyJHXGPctCxLBjDbEjPuDtHDj++;
			}
			mCcGEqkjMlkdLIrXjIaiVhutUrp[rqjFXveLphnbEdgNwMHGdxevUWnl] = item;
			if (OlNDKUfTXODfsuYHoRqmBeyGOdJC < nfDdeELnrQwKNlRDjFNLWWngAhc)
			{
				OlNDKUfTXODfsuYHoRqmBeyGOdJC++;
			}
		}

		public bool EnqueueIfUnique(T item)
		{
			if (Contains(item))
			{
				return false;
			}
			Enqueue(item);
			return true;
		}

		public T Dequeue()
		{
			if (OlNDKUfTXODfsuYHoRqmBeyGOdJC == 0)
			{
				throw new Exception("There are no items in the buffer.");
			}
			T result = mCcGEqkjMlkdLIrXjIaiVhutUrp[FseotGPSmvLNzqctDqncUFwgRlQ];
			if (FseotGPSmvLNzqctDqncUFwgRlQ == rqjFXveLphnbEdgNwMHGdxevUWnl)
			{
				Clear();
			}
			else
			{
				mCcGEqkjMlkdLIrXjIaiVhutUrp[FseotGPSmvLNzqctDqncUFwgRlQ] = default(T);
				FseotGPSmvLNzqctDqncUFwgRlQ = ((FseotGPSmvLNzqctDqncUFwgRlQ < nfDdeELnrQwKNlRDjFNLWWngAhc - 1) ? (FseotGPSmvLNzqctDqncUFwgRlQ + 1) : 0);
				qrPyJHXGPctCxLBjDbEjPuDtHDj = 0;
				OlNDKUfTXODfsuYHoRqmBeyGOdJC--;
				WXuCbimssDdLmCLcKcnRVhkhcwYV++;
			}
			return result;
		}

		public T Peek()
		{
			if (rqjFXveLphnbEdgNwMHGdxevUWnl < 0)
			{
				throw new Exception("There are no items in the buffer.");
			}
			return mCcGEqkjMlkdLIrXjIaiVhutUrp[FseotGPSmvLNzqctDqncUFwgRlQ];
		}

		public bool Contains(T item)
		{
			return USIUnwjDrQQOpzxOGtxmSsRfViS(item, nkJlnwMjDCoZoyOzJJUrDmuqydL) >= 0;
		}

		public bool Contains(T item, IEqualityComparer<T> comparer)
		{
			return USIUnwjDrQQOpzxOGtxmSsRfViS(item, comparer) >= 0;
		}

		public int IndexOf(T item)
		{
			return IndexOf(item, nkJlnwMjDCoZoyOzJJUrDmuqydL);
		}

		public int IndexOf(T item, IEqualityComparer<T> comparer)
		{
			return HpPzxlAXGaulBgERXLinEEzyBky(USIUnwjDrQQOpzxOGtxmSsRfViS(item, comparer));
		}

		public bool Remove(T item)
		{
			return Remove(item, nkJlnwMjDCoZoyOzJJUrDmuqydL);
		}

		public bool Remove(T item, IEqualityComparer<T> comparer)
		{
			if (comparer == null)
			{
				throw new ArgumentNullException("comparer");
			}
			if (Count == 0)
			{
				return false;
			}
			int num = USIUnwjDrQQOpzxOGtxmSsRfViS(item, comparer);
			if (num < 0)
			{
				return false;
			}
			azcYkVKIVbEYwCQeRgKCcDwkualO(num);
			return true;
		}

		public void RemoveAt(int index)
		{
			azcYkVKIVbEYwCQeRgKCcDwkualO(USpxJzgBYIpbEERBBSBBrkuiqhY(index));
		}

		public int RemoveAll(T item)
		{
			return RemoveAll(item, nkJlnwMjDCoZoyOzJJUrDmuqydL);
		}

		public int RemoveAll(T item, IEqualityComparer<T> comparer)
		{
			if (comparer == null)
			{
				throw new ArgumentNullException("comparer");
			}
			int num = 0;
			int count = Count;
			for (int num2 = count - 1; num2 >= 0; num2--)
			{
				if (comparer.Equals(this[num2], item))
				{
					RemoveAt(num2);
					num++;
				}
			}
			return num;
		}

		public void Clear()
		{
			if (OlNDKUfTXODfsuYHoRqmBeyGOdJC > 0)
			{
				if (rqjFXveLphnbEdgNwMHGdxevUWnl >= FseotGPSmvLNzqctDqncUFwgRlQ)
				{
					Array.Clear(mCcGEqkjMlkdLIrXjIaiVhutUrp, FseotGPSmvLNzqctDqncUFwgRlQ, rqjFXveLphnbEdgNwMHGdxevUWnl - FseotGPSmvLNzqctDqncUFwgRlQ + 1);
				}
				else
				{
					Array.Clear(mCcGEqkjMlkdLIrXjIaiVhutUrp, 0, rqjFXveLphnbEdgNwMHGdxevUWnl + 1);
					Array.Clear(mCcGEqkjMlkdLIrXjIaiVhutUrp, FseotGPSmvLNzqctDqncUFwgRlQ, nfDdeELnrQwKNlRDjFNLWWngAhc - FseotGPSmvLNzqctDqncUFwgRlQ);
				}
				OlNDKUfTXODfsuYHoRqmBeyGOdJC = 0;
			}
			rqjFXveLphnbEdgNwMHGdxevUWnl = -1;
			FseotGPSmvLNzqctDqncUFwgRlQ = -1;
			qrPyJHXGPctCxLBjDbEjPuDtHDj = 0;
			WXuCbimssDdLmCLcKcnRVhkhcwYV++;
		}

		private int USIUnwjDrQQOpzxOGtxmSsRfViS(T P_0)
		{
			return USIUnwjDrQQOpzxOGtxmSsRfViS(P_0, nkJlnwMjDCoZoyOzJJUrDmuqydL);
		}

		private int USIUnwjDrQQOpzxOGtxmSsRfViS(T P_0, IEqualityComparer<T> P_1)
		{
			if (P_1 == null)
			{
				throw new ArgumentNullException("comparer");
			}
			if (OlNDKUfTXODfsuYHoRqmBeyGOdJC == 0)
			{
				return -1;
			}
			if (rqjFXveLphnbEdgNwMHGdxevUWnl >= FseotGPSmvLNzqctDqncUFwgRlQ)
			{
				for (int i = FseotGPSmvLNzqctDqncUFwgRlQ; i <= rqjFXveLphnbEdgNwMHGdxevUWnl; i++)
				{
					if (P_1.Equals(mCcGEqkjMlkdLIrXjIaiVhutUrp[i], P_0))
					{
						return i;
					}
				}
			}
			else
			{
				for (int j = 0; j <= rqjFXveLphnbEdgNwMHGdxevUWnl; j++)
				{
					if (P_1.Equals(mCcGEqkjMlkdLIrXjIaiVhutUrp[j], P_0))
					{
						return j;
					}
				}
				for (int k = FseotGPSmvLNzqctDqncUFwgRlQ; k < nfDdeELnrQwKNlRDjFNLWWngAhc; k++)
				{
					if (P_1.Equals(mCcGEqkjMlkdLIrXjIaiVhutUrp[k], P_0))
					{
						return k;
					}
				}
			}
			return -1;
		}

		private void azcYkVKIVbEYwCQeRgKCcDwkualO(int P_0)
		{
			if (!samgOiDNFoWWKkSkFjAebzebuYbg(P_0))
			{
				throw new IndexOutOfRangeException();
			}
			if (P_0 == FseotGPSmvLNzqctDqncUFwgRlQ)
			{
				Dequeue();
				return;
			}
			if (P_0 != rqjFXveLphnbEdgNwMHGdxevUWnl)
			{
				if (rqjFXveLphnbEdgNwMHGdxevUWnl > FseotGPSmvLNzqctDqncUFwgRlQ)
				{
					Array.Copy(mCcGEqkjMlkdLIrXjIaiVhutUrp, P_0 + 1, mCcGEqkjMlkdLIrXjIaiVhutUrp, P_0, rqjFXveLphnbEdgNwMHGdxevUWnl - P_0);
				}
				else if (P_0 < rqjFXveLphnbEdgNwMHGdxevUWnl)
				{
					Array.Copy(mCcGEqkjMlkdLIrXjIaiVhutUrp, P_0 + 1, mCcGEqkjMlkdLIrXjIaiVhutUrp, P_0, rqjFXveLphnbEdgNwMHGdxevUWnl - P_0);
				}
				else
				{
					Array.Copy(mCcGEqkjMlkdLIrXjIaiVhutUrp, P_0 + 1, mCcGEqkjMlkdLIrXjIaiVhutUrp, P_0, nfDdeELnrQwKNlRDjFNLWWngAhc - P_0 - 1);
					mCcGEqkjMlkdLIrXjIaiVhutUrp[nfDdeELnrQwKNlRDjFNLWWngAhc - 1] = mCcGEqkjMlkdLIrXjIaiVhutUrp[0];
					if (rqjFXveLphnbEdgNwMHGdxevUWnl > 0)
					{
						Array.Copy(mCcGEqkjMlkdLIrXjIaiVhutUrp, 1, mCcGEqkjMlkdLIrXjIaiVhutUrp, 0, rqjFXveLphnbEdgNwMHGdxevUWnl);
					}
				}
			}
			mCcGEqkjMlkdLIrXjIaiVhutUrp[rqjFXveLphnbEdgNwMHGdxevUWnl] = default(T);
			rqjFXveLphnbEdgNwMHGdxevUWnl = ((rqjFXveLphnbEdgNwMHGdxevUWnl > 0) ? (rqjFXveLphnbEdgNwMHGdxevUWnl - 1) : (nfDdeELnrQwKNlRDjFNLWWngAhc - 1));
			WXuCbimssDdLmCLcKcnRVhkhcwYV++;
			OlNDKUfTXODfsuYHoRqmBeyGOdJC--;
		}

		private bool samgOiDNFoWWKkSkFjAebzebuYbg(int P_0)
		{
			if (OlNDKUfTXODfsuYHoRqmBeyGOdJC == 0)
			{
				return false;
			}
			if (rqjFXveLphnbEdgNwMHGdxevUWnl >= FseotGPSmvLNzqctDqncUFwgRlQ)
			{
				if (P_0 >= FseotGPSmvLNzqctDqncUFwgRlQ)
				{
					return P_0 <= rqjFXveLphnbEdgNwMHGdxevUWnl;
				}
				return false;
			}
			if (P_0 < FseotGPSmvLNzqctDqncUFwgRlQ)
			{
				return P_0 <= rqjFXveLphnbEdgNwMHGdxevUWnl;
			}
			return true;
		}

		private int HpPzxlAXGaulBgERXLinEEzyBky(int P_0)
		{
			if ((uint)P_0 >= (uint)nfDdeELnrQwKNlRDjFNLWWngAhc)
			{
				return -1;
			}
			if (!samgOiDNFoWWKkSkFjAebzebuYbg(P_0))
			{
				return -1;
			}
			if (P_0 >= FseotGPSmvLNzqctDqncUFwgRlQ)
			{
				return P_0 - FseotGPSmvLNzqctDqncUFwgRlQ;
			}
			return P_0 + nfDdeELnrQwKNlRDjFNLWWngAhc - FseotGPSmvLNzqctDqncUFwgRlQ;
		}

		private int USpxJzgBYIpbEERBBSBBrkuiqhY(int P_0)
		{
			if ((uint)P_0 >= (uint)OlNDKUfTXODfsuYHoRqmBeyGOdJC)
			{
				return -1;
			}
			P_0 = FseotGPSmvLNzqctDqncUFwgRlQ + P_0;
			if (P_0 >= nfDdeELnrQwKNlRDjFNLWWngAhc)
			{
				P_0 -= nfDdeELnrQwKNlRDjFNLWWngAhc;
			}
			return P_0;
		}

		void ICollection<T>.Add(T item)
		{
			Enqueue(item);
		}

		void ICollection<T>.Clear()
		{
			Clear();
		}

		bool ICollection<T>.Contains(T item)
		{
			return Contains(item);
		}

		void ICollection<T>.CopyTo(T[] array, int arrayIndex)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (arrayIndex < 0 || arrayIndex + Count > array.Length)
			{
				throw new ArgumentException("array is too small to hold the collection.");
			}
			int count = Count;
			for (int i = 0; i < count; i++)
			{
				array[arrayIndex + i] = this[i];
			}
		}

		bool ICollection<T>.Remove(T item)
		{
			return Remove(item);
		}

		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return new VfafkueWlXlStBSNQnHKiRPebQkZ(this);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new VfafkueWlXlStBSNQnHKiRPebQkZ(this);
		}
	}
}
