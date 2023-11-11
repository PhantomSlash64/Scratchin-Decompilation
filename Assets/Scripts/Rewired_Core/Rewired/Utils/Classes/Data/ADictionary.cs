using System;
using System.Collections;
using System.Collections.Generic;

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class ADictionary<TKey, TValue> : IEnumerable, IDictionary, ICollection, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>
	{
		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		[CustomObfuscation(rename = false)]
		internal struct Entry
		{
			public int hashCode;

			public int next;

			public TKey key;

			public TValue value;
		}

		[Serializable]
		[CustomObfuscation(rename = false)]
		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		public struct Enumerator : IDisposable, IEnumerator, IDictionaryEnumerator, IEnumerator<KeyValuePair<TKey, TValue>>
		{
			internal const int DictEntry = 1;

			internal const int KeyValuePair = 2;

			private ADictionary<TKey, TValue> niSwIGuixCCwVvwckEvgBcZHWRr;

			private int HMIUyauSwlzrtCBuqxkNKgKURdX;

			private int MfVGCAceIAkEXxwxwAsLGoqQvdj;

			private KeyValuePair<TKey, TValue> HBFpvdVSEToPvyDvjayPiQyuurNQ;

			private int iKXzUiflASTTRVqyQTfKKkvsorh;

			public KeyValuePair<TKey, TValue> Current => HBFpvdVSEToPvyDvjayPiQyuurNQ;

			object IEnumerator.Current
			{
				get
				{
					if (MfVGCAceIAkEXxwxwAsLGoqQvdj == 0 || MfVGCAceIAkEXxwxwAsLGoqQvdj == niSwIGuixCCwVvwckEvgBcZHWRr._count + 1)
					{
						throw new Exception();
					}
					if (iKXzUiflASTTRVqyQTfKKkvsorh == 1)
					{
						return new DictionaryEntry(HBFpvdVSEToPvyDvjayPiQyuurNQ.Key, HBFpvdVSEToPvyDvjayPiQyuurNQ.Value);
					}
					return new KeyValuePair<TKey, TValue>(HBFpvdVSEToPvyDvjayPiQyuurNQ.Key, HBFpvdVSEToPvyDvjayPiQyuurNQ.Value);
				}
			}

			DictionaryEntry IDictionaryEnumerator.Entry
			{
				get
				{
					if (MfVGCAceIAkEXxwxwAsLGoqQvdj == 0 || MfVGCAceIAkEXxwxwAsLGoqQvdj == niSwIGuixCCwVvwckEvgBcZHWRr._count + 1)
					{
						throw new Exception();
					}
					return new DictionaryEntry(HBFpvdVSEToPvyDvjayPiQyuurNQ.Key, HBFpvdVSEToPvyDvjayPiQyuurNQ.Value);
				}
			}

			object IDictionaryEnumerator.Key
			{
				get
				{
					if (MfVGCAceIAkEXxwxwAsLGoqQvdj == 0 || MfVGCAceIAkEXxwxwAsLGoqQvdj == niSwIGuixCCwVvwckEvgBcZHWRr._count + 1)
					{
						throw new Exception();
					}
					return HBFpvdVSEToPvyDvjayPiQyuurNQ.Key;
				}
			}

			object IDictionaryEnumerator.Value
			{
				get
				{
					if (MfVGCAceIAkEXxwxwAsLGoqQvdj == 0 || MfVGCAceIAkEXxwxwAsLGoqQvdj == niSwIGuixCCwVvwckEvgBcZHWRr._count + 1)
					{
						throw new Exception();
					}
					return HBFpvdVSEToPvyDvjayPiQyuurNQ.Value;
				}
			}

			internal Enumerator(ADictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
			{
				niSwIGuixCCwVvwckEvgBcZHWRr = dictionary;
				HMIUyauSwlzrtCBuqxkNKgKURdX = dictionary.WXuCbimssDdLmCLcKcnRVhkhcwYV;
				MfVGCAceIAkEXxwxwAsLGoqQvdj = 0;
				iKXzUiflASTTRVqyQTfKKkvsorh = getEnumeratorRetType;
				HBFpvdVSEToPvyDvjayPiQyuurNQ = default(KeyValuePair<TKey, TValue>);
			}

			public bool MoveNext()
			{
				if (HMIUyauSwlzrtCBuqxkNKgKURdX != niSwIGuixCCwVvwckEvgBcZHWRr.WXuCbimssDdLmCLcKcnRVhkhcwYV)
				{
					throw new Exception();
				}
				while ((uint)MfVGCAceIAkEXxwxwAsLGoqQvdj < (uint)niSwIGuixCCwVvwckEvgBcZHWRr._count)
				{
					if (niSwIGuixCCwVvwckEvgBcZHWRr._entries[MfVGCAceIAkEXxwxwAsLGoqQvdj].hashCode >= 0)
					{
						HBFpvdVSEToPvyDvjayPiQyuurNQ = new KeyValuePair<TKey, TValue>(niSwIGuixCCwVvwckEvgBcZHWRr._entries[MfVGCAceIAkEXxwxwAsLGoqQvdj].key, niSwIGuixCCwVvwckEvgBcZHWRr._entries[MfVGCAceIAkEXxwxwAsLGoqQvdj].value);
						MfVGCAceIAkEXxwxwAsLGoqQvdj++;
						return true;
					}
					MfVGCAceIAkEXxwxwAsLGoqQvdj++;
				}
				MfVGCAceIAkEXxwxwAsLGoqQvdj = niSwIGuixCCwVvwckEvgBcZHWRr._count + 1;
				HBFpvdVSEToPvyDvjayPiQyuurNQ = default(KeyValuePair<TKey, TValue>);
				return false;
			}

			public void Dispose()
			{
			}

			void IEnumerator.Reset()
			{
				if (HMIUyauSwlzrtCBuqxkNKgKURdX != niSwIGuixCCwVvwckEvgBcZHWRr.WXuCbimssDdLmCLcKcnRVhkhcwYV)
				{
					throw new Exception();
				}
				MfVGCAceIAkEXxwxwAsLGoqQvdj = 0;
				HBFpvdVSEToPvyDvjayPiQyuurNQ = default(KeyValuePair<TKey, TValue>);
			}
		}

		[Serializable]
		[CustomObfuscation(rename = false)]
		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		public sealed class KeyCollection : IEnumerable, ICollection, IEnumerable<TKey>, ICollection<TKey>
		{
			[Serializable]
			[CustomObfuscation(rename = false)]
			[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
			public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TKey>
			{
				private ADictionary<TKey, TValue> niSwIGuixCCwVvwckEvgBcZHWRr;

				private int MfVGCAceIAkEXxwxwAsLGoqQvdj;

				private int HMIUyauSwlzrtCBuqxkNKgKURdX;

				private TKey JYqTGdbvLueBBsTMAJDqEVakKMW;

				public TKey Current => JYqTGdbvLueBBsTMAJDqEVakKMW;

				object IEnumerator.Current
				{
					get
					{
						if (MfVGCAceIAkEXxwxwAsLGoqQvdj == 0 || MfVGCAceIAkEXxwxwAsLGoqQvdj == niSwIGuixCCwVvwckEvgBcZHWRr._count + 1)
						{
							throw new Exception();
						}
						return JYqTGdbvLueBBsTMAJDqEVakKMW;
					}
				}

				internal Enumerator(ADictionary<TKey, TValue> dictionary)
				{
					niSwIGuixCCwVvwckEvgBcZHWRr = dictionary;
					HMIUyauSwlzrtCBuqxkNKgKURdX = dictionary.WXuCbimssDdLmCLcKcnRVhkhcwYV;
					MfVGCAceIAkEXxwxwAsLGoqQvdj = 0;
					JYqTGdbvLueBBsTMAJDqEVakKMW = default(TKey);
				}

				public void Dispose()
				{
				}

				public bool MoveNext()
				{
					if (HMIUyauSwlzrtCBuqxkNKgKURdX != niSwIGuixCCwVvwckEvgBcZHWRr.WXuCbimssDdLmCLcKcnRVhkhcwYV)
					{
						throw new Exception();
					}
					while ((uint)MfVGCAceIAkEXxwxwAsLGoqQvdj < (uint)niSwIGuixCCwVvwckEvgBcZHWRr._count)
					{
						if (niSwIGuixCCwVvwckEvgBcZHWRr._entries[MfVGCAceIAkEXxwxwAsLGoqQvdj].hashCode >= 0)
						{
							JYqTGdbvLueBBsTMAJDqEVakKMW = niSwIGuixCCwVvwckEvgBcZHWRr._entries[MfVGCAceIAkEXxwxwAsLGoqQvdj].key;
							MfVGCAceIAkEXxwxwAsLGoqQvdj++;
							return true;
						}
						MfVGCAceIAkEXxwxwAsLGoqQvdj++;
					}
					MfVGCAceIAkEXxwxwAsLGoqQvdj = niSwIGuixCCwVvwckEvgBcZHWRr._count + 1;
					JYqTGdbvLueBBsTMAJDqEVakKMW = default(TKey);
					return false;
				}

				void IEnumerator.Reset()
				{
					if (HMIUyauSwlzrtCBuqxkNKgKURdX != niSwIGuixCCwVvwckEvgBcZHWRr.WXuCbimssDdLmCLcKcnRVhkhcwYV)
					{
						throw new Exception();
					}
					MfVGCAceIAkEXxwxwAsLGoqQvdj = 0;
					JYqTGdbvLueBBsTMAJDqEVakKMW = default(TKey);
				}
			}

			private ADictionary<TKey, TValue> niSwIGuixCCwVvwckEvgBcZHWRr;

			public int Count => niSwIGuixCCwVvwckEvgBcZHWRr.Count;

			bool ICollection<TKey>.IsReadOnly => true;

			bool ICollection.IsSynchronized => false;

			object ICollection.SyncRoot => ((ICollection)niSwIGuixCCwVvwckEvgBcZHWRr).SyncRoot;

			public KeyCollection(ADictionary<TKey, TValue> dictionary)
			{
				if (dictionary == null)
				{
					throw new ArgumentNullException("dictionary");
				}
				niSwIGuixCCwVvwckEvgBcZHWRr = dictionary;
			}

			public Enumerator GetEnumerator()
			{
				return new Enumerator(niSwIGuixCCwVvwckEvgBcZHWRr);
			}

			public void CopyTo(TKey[] array, int index)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (index < 0 || index > array.Length)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				if (array.Length - index < niSwIGuixCCwVvwckEvgBcZHWRr.Count)
				{
					throw new Exception();
				}
				int count = niSwIGuixCCwVvwckEvgBcZHWRr._count;
				Entry[] entries = niSwIGuixCCwVvwckEvgBcZHWRr._entries;
				for (int i = 0; i < count; i++)
				{
					if (entries[i].hashCode >= 0)
					{
						array[index++] = entries[i].key;
					}
				}
			}

			void ICollection<TKey>.Add(TKey item)
			{
				throw new Exception();
			}

			void ICollection<TKey>.Clear()
			{
				throw new Exception();
			}

			bool ICollection<TKey>.Contains(TKey item)
			{
				return niSwIGuixCCwVvwckEvgBcZHWRr.ContainsKey(item);
			}

			bool ICollection<TKey>.Remove(TKey item)
			{
				throw new Exception();
			}

			IEnumerator<TKey> IEnumerable<TKey>.GetEnumerator()
			{
				return new Enumerator(niSwIGuixCCwVvwckEvgBcZHWRr);
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return new Enumerator(niSwIGuixCCwVvwckEvgBcZHWRr);
			}

			void ICollection.CopyTo(Array array, int index)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (array.Rank != 1)
				{
					throw new Exception();
				}
				if (array.GetLowerBound(0) != 0)
				{
					throw new Exception();
				}
				if (index < 0 || index > array.Length)
				{
					throw new Exception();
				}
				if (array.Length - index < niSwIGuixCCwVvwckEvgBcZHWRr.Count)
				{
					throw new Exception();
				}
				if (array is TKey[] array2)
				{
					CopyTo(array2, index);
					return;
				}
				if (!(array is object[] array3))
				{
					throw new Exception();
				}
				int count = niSwIGuixCCwVvwckEvgBcZHWRr._count;
				Entry[] entries = niSwIGuixCCwVvwckEvgBcZHWRr._entries;
				try
				{
					for (int i = 0; i < count; i++)
					{
						if (entries[i].hashCode >= 0)
						{
							array3[index++] = entries[i].key;
						}
					}
				}
				catch (ArrayTypeMismatchException)
				{
					throw new Exception();
				}
			}
		}

		[Serializable]
		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		[CustomObfuscation(rename = false)]
		public sealed class ValueCollection : IEnumerable, ICollection, ICollection<TValue>, IEnumerable<TValue>
		{
			[Serializable]
			[CustomObfuscation(rename = false)]
			[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
			public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TValue>
			{
				private ADictionary<TKey, TValue> niSwIGuixCCwVvwckEvgBcZHWRr;

				private int MfVGCAceIAkEXxwxwAsLGoqQvdj;

				private int HMIUyauSwlzrtCBuqxkNKgKURdX;

				private TValue WxoEyKAdKggSznEdFdogyftgtRP;

				public TValue Current => WxoEyKAdKggSznEdFdogyftgtRP;

				object IEnumerator.Current
				{
					get
					{
						if (MfVGCAceIAkEXxwxwAsLGoqQvdj == 0 || MfVGCAceIAkEXxwxwAsLGoqQvdj == niSwIGuixCCwVvwckEvgBcZHWRr._count + 1)
						{
							throw new Exception();
						}
						return WxoEyKAdKggSznEdFdogyftgtRP;
					}
				}

				internal Enumerator(ADictionary<TKey, TValue> dictionary)
				{
					niSwIGuixCCwVvwckEvgBcZHWRr = dictionary;
					HMIUyauSwlzrtCBuqxkNKgKURdX = dictionary.WXuCbimssDdLmCLcKcnRVhkhcwYV;
					MfVGCAceIAkEXxwxwAsLGoqQvdj = 0;
					WxoEyKAdKggSznEdFdogyftgtRP = default(TValue);
				}

				public void Dispose()
				{
				}

				public bool MoveNext()
				{
					if (HMIUyauSwlzrtCBuqxkNKgKURdX != niSwIGuixCCwVvwckEvgBcZHWRr.WXuCbimssDdLmCLcKcnRVhkhcwYV)
					{
						throw new Exception();
					}
					while ((uint)MfVGCAceIAkEXxwxwAsLGoqQvdj < (uint)niSwIGuixCCwVvwckEvgBcZHWRr._count)
					{
						if (niSwIGuixCCwVvwckEvgBcZHWRr._entries[MfVGCAceIAkEXxwxwAsLGoqQvdj].hashCode >= 0)
						{
							WxoEyKAdKggSznEdFdogyftgtRP = niSwIGuixCCwVvwckEvgBcZHWRr._entries[MfVGCAceIAkEXxwxwAsLGoqQvdj].value;
							MfVGCAceIAkEXxwxwAsLGoqQvdj++;
							return true;
						}
						MfVGCAceIAkEXxwxwAsLGoqQvdj++;
					}
					MfVGCAceIAkEXxwxwAsLGoqQvdj = niSwIGuixCCwVvwckEvgBcZHWRr._count + 1;
					WxoEyKAdKggSznEdFdogyftgtRP = default(TValue);
					return false;
				}

				void IEnumerator.Reset()
				{
					if (HMIUyauSwlzrtCBuqxkNKgKURdX != niSwIGuixCCwVvwckEvgBcZHWRr.WXuCbimssDdLmCLcKcnRVhkhcwYV)
					{
						throw new Exception();
					}
					MfVGCAceIAkEXxwxwAsLGoqQvdj = 0;
					WxoEyKAdKggSznEdFdogyftgtRP = default(TValue);
				}
			}

			private ADictionary<TKey, TValue> niSwIGuixCCwVvwckEvgBcZHWRr;

			public int Count => niSwIGuixCCwVvwckEvgBcZHWRr.Count;

			bool ICollection<TValue>.IsReadOnly => true;

			bool ICollection.IsSynchronized => false;

			object ICollection.SyncRoot => ((ICollection)niSwIGuixCCwVvwckEvgBcZHWRr).SyncRoot;

			public ValueCollection(ADictionary<TKey, TValue> dictionary)
			{
				if (dictionary == null)
				{
					throw new ArgumentNullException("dictionary");
				}
				niSwIGuixCCwVvwckEvgBcZHWRr = dictionary;
			}

			public Enumerator GetEnumerator()
			{
				return new Enumerator(niSwIGuixCCwVvwckEvgBcZHWRr);
			}

			public void CopyTo(TValue[] array, int index)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (index < 0 || index > array.Length)
				{
					throw new Exception();
				}
				if (array.Length - index < niSwIGuixCCwVvwckEvgBcZHWRr.Count)
				{
					throw new Exception();
				}
				int count = niSwIGuixCCwVvwckEvgBcZHWRr._count;
				Entry[] entries = niSwIGuixCCwVvwckEvgBcZHWRr._entries;
				for (int i = 0; i < count; i++)
				{
					if (entries[i].hashCode >= 0)
					{
						array[index++] = entries[i].value;
					}
				}
			}

			void ICollection<TValue>.Add(TValue item)
			{
				throw new Exception();
			}

			bool ICollection<TValue>.Remove(TValue item)
			{
				throw new Exception();
			}

			void ICollection<TValue>.Clear()
			{
				throw new Exception();
			}

			bool ICollection<TValue>.Contains(TValue item)
			{
				return niSwIGuixCCwVvwckEvgBcZHWRr.ContainsValue(item);
			}

			IEnumerator<TValue> IEnumerable<TValue>.GetEnumerator()
			{
				return new Enumerator(niSwIGuixCCwVvwckEvgBcZHWRr);
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				return new Enumerator(niSwIGuixCCwVvwckEvgBcZHWRr);
			}

			void ICollection.CopyTo(Array array, int index)
			{
				if (array == null)
				{
					throw new ArgumentNullException("array");
				}
				if (array.Rank != 1)
				{
					throw new Exception();
				}
				if (array.GetLowerBound(0) != 0)
				{
					throw new Exception();
				}
				if (index < 0 || index > array.Length)
				{
					throw new Exception();
				}
				if (array.Length - index < niSwIGuixCCwVvwckEvgBcZHWRr.Count)
				{
					throw new Exception();
				}
				if (array is TValue[] array2)
				{
					CopyTo(array2, index);
					return;
				}
				if (!(array is object[] array3))
				{
					throw new Exception();
				}
				int count = niSwIGuixCCwVvwckEvgBcZHWRr._count;
				Entry[] entries = niSwIGuixCCwVvwckEvgBcZHWRr._entries;
				try
				{
					for (int i = 0; i < count; i++)
					{
						if (entries[i].hashCode >= 0)
						{
							array3[index++] = entries[i].value;
						}
					}
				}
				catch (ArrayTypeMismatchException)
				{
					throw new Exception();
				}
			}
		}

		private const string UpVtkkdPLHLYhtaWCdcQKrhskon = "Version";

		private const string YAWPDzLocRdDfKRJwfHMeXECWRg = "HashSize";

		private const string OxHnoobEScpaGdpgnShXDrfjWzD = "KeyValuePairs";

		private const string AtGhiteuyegrOAmRnsZJtxaIUwM = "Comparer";

		private int[] GGSOwkYkcGqPCiEAySEBrYcSich;

		internal Entry[] _entries;

		internal int _count;

		private int WXuCbimssDdLmCLcKcnRVhkhcwYV;

		private int AXLKpbqabRNdeGmrDEerbeXHKwzE;

		private int xOdawrVENNPfYfkQozMouFmFHbx;

		private int rfyUrsqsOitzcademolldrVEJAS;

		private IEqualityComparer<TKey> mwBiUDBItuPwEpfcLXpzrrZUnOI;

		private IEqualityComparer<TValue> KOOkgpdQaaudnLwzWeCkuGQxcay;

		private KeyCollection dWBakvwRNaeXHZTwqDturfEhOTq;

		private ValueCollection CZFRtBCUTwsgoIUOeTOEpgxMkqp;

		private readonly object TrZjRKalWAjNtJflHkrpVcJzHYF = new object();

		private static readonly bool eBQvVwBOONVDFpkOxzmJYYkeLVp = ReflectionTools.IsValueType(typeof(TKey));

		private static readonly bool GKmoIrDziJTJKXaUPMfkiLDPGmJ = ReflectionTools.IsValueType(typeof(TValue));

		public int Count => _count - rfyUrsqsOitzcademolldrVEJAS;

		public int TotalCount => _count;

		public KeyCollection Keys
		{
			get
			{
				if (dWBakvwRNaeXHZTwqDturfEhOTq == null)
				{
					dWBakvwRNaeXHZTwqDturfEhOTq = new KeyCollection(this);
				}
				return dWBakvwRNaeXHZTwqDturfEhOTq;
			}
		}

		public ValueCollection Values
		{
			get
			{
				if (CZFRtBCUTwsgoIUOeTOEpgxMkqp == null)
				{
					CZFRtBCUTwsgoIUOeTOEpgxMkqp = new ValueCollection(this);
				}
				return CZFRtBCUTwsgoIUOeTOEpgxMkqp;
			}
		}

		public IEqualityComparer<TKey> KeyComparer
		{
			get
			{
				return mwBiUDBItuPwEpfcLXpzrrZUnOI;
			}
			set
			{
				if (value == null)
				{
					value = EqualityComparerNoAlloc<TKey>.Default;
				}
				mwBiUDBItuPwEpfcLXpzrrZUnOI = value;
			}
		}

		public IEqualityComparer<TValue> ValueComparer
		{
			get
			{
				return KOOkgpdQaaudnLwzWeCkuGQxcay;
			}
			set
			{
				if (value == null)
				{
					value = EqualityComparerNoAlloc<TValue>.Default;
				}
				KOOkgpdQaaudnLwzWeCkuGQxcay = value;
			}
		}

		public TValue this[TKey key]
		{
			get
			{
				int num = IndexOfKey(key);
				if (num < 0)
				{
					throw new KeyNotFoundException(string.Concat("Key \"", key, " does not exist."));
				}
				return _entries[num].value;
			}
			set
			{
				QuZbncESlaeCcibZnMSMRnTzdnOR(key, value, false);
			}
		}

		public int IndexOfFirst
		{
			get
			{
				for (int i = 0; i < _count; i++)
				{
					if (_entries[i].hashCode >= 0)
					{
						return i;
					}
				}
				return -1;
			}
		}

		public int IndexOfLast
		{
			get
			{
				for (int num = _count - 1; num >= 0; num--)
				{
					if (_entries[num].hashCode >= 0)
					{
						return num;
					}
				}
				return -1;
			}
		}

		ICollection<TKey> IDictionary<TKey, TValue>.Keys
		{
			get
			{
				if (dWBakvwRNaeXHZTwqDturfEhOTq == null)
				{
					dWBakvwRNaeXHZTwqDturfEhOTq = new KeyCollection(this);
				}
				return dWBakvwRNaeXHZTwqDturfEhOTq;
			}
		}

		ICollection<TValue> IDictionary<TKey, TValue>.Values
		{
			get
			{
				if (CZFRtBCUTwsgoIUOeTOEpgxMkqp == null)
				{
					CZFRtBCUTwsgoIUOeTOEpgxMkqp = new ValueCollection(this);
				}
				return CZFRtBCUTwsgoIUOeTOEpgxMkqp;
			}
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => false;

		bool ICollection.IsSynchronized => false;

		object ICollection.SyncRoot => TrZjRKalWAjNtJflHkrpVcJzHYF;

		bool IDictionary.IsFixedSize => false;

		bool IDictionary.IsReadOnly => false;

		ICollection IDictionary.Keys => Keys;

		ICollection IDictionary.Values => Values;

		object IDictionary.this[object key]
		{
			get
			{
				if (jtcAJBkPFJHmlfLNkIDdZWwrPLcp(key))
				{
					int num = IndexOfKey((TKey)key);
					if (num >= 0)
					{
						return _entries[num].value;
					}
				}
				return null;
			}
			set
			{
				if (key == null)
				{
					throw new ArgumentNullException("key");
				}
				pVIwMuzEnBBuABeMJUvfzCnBAgo<TValue>(value, "value");
				try
				{
					TKey key2 = (TKey)key;
					try
					{
						this[key2] = (TValue)value;
					}
					catch (InvalidCastException)
					{
						throw new Exception();
					}
				}
				catch (InvalidCastException)
				{
					throw new Exception();
				}
			}
		}

		public ADictionary()
			: this(0, (IEqualityComparer<TKey>)null, (IEqualityComparer<TValue>)null)
		{
		}

		public ADictionary(IEqualityComparer<TKey> keyComparer)
			: this(0, keyComparer, (IEqualityComparer<TValue>)null)
		{
		}

		public ADictionary(IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer)
			: this(0, keyComparer, valueComparer)
		{
		}

		public ADictionary(int capacity)
			: this(capacity, (IEqualityComparer<TKey>)null, (IEqualityComparer<TValue>)null)
		{
		}

		public ADictionary(int capacity, IEqualityComparer<TKey> keyComparer)
			: this(capacity, keyComparer, (IEqualityComparer<TValue>)null)
		{
		}

		public ADictionary(int capacity, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer)
		{
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException("capacity");
			}
			if (capacity > 0)
			{
				ijQPrfbohIDtyfCSvLMVhrlmSpB(capacity);
			}
			mwBiUDBItuPwEpfcLXpzrrZUnOI = keyComparer ?? EqualityComparerNoAlloc<TKey>.Default;
			KOOkgpdQaaudnLwzWeCkuGQxcay = valueComparer ?? EqualityComparerNoAlloc<TValue>.Default;
		}

		public ADictionary(IDictionary<TKey, TValue> dictionary)
			: this(dictionary, (IEqualityComparer<TKey>)null, (IEqualityComparer<TValue>)null)
		{
		}

		public ADictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> keyComparer)
			: this(dictionary, keyComparer, (IEqualityComparer<TValue>)null)
		{
		}

		public ADictionary(IDictionary<TKey, TValue> dictionary, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer)
			: this(dictionary?.Count ?? 0, keyComparer)
		{
			if (dictionary == null)
			{
				throw new ArgumentNullException("dictionary");
			}
			foreach (KeyValuePair<TKey, TValue> item in dictionary)
			{
				Add(item.Key, item.Value);
			}
		}

		public void Add(TKey key, TValue value)
		{
			QuZbncESlaeCcibZnMSMRnTzdnOR(key, value, true);
		}

		public void Clear()
		{
			if (_count > 0)
			{
				for (int i = 0; i < GGSOwkYkcGqPCiEAySEBrYcSich.Length; i++)
				{
					GGSOwkYkcGqPCiEAySEBrYcSich[i] = -1;
				}
				Array.Clear(_entries, 0, _count);
				xOdawrVENNPfYfkQozMouFmFHbx = -1;
				_count = 0;
				rfyUrsqsOitzcademolldrVEJAS = 0;
				WXuCbimssDdLmCLcKcnRVhkhcwYV++;
				AXLKpbqabRNdeGmrDEerbeXHKwzE++;
			}
		}

		public bool ContainsKey(TKey key)
		{
			return IndexOfKey(key) >= 0;
		}

		public bool ContainsValue(TValue value)
		{
			return IndexOfValue(value) >= 0;
		}

		public Enumerator GetEnumerator()
		{
			return new Enumerator(this, 2);
		}

		public bool Remove(TKey key)
		{
			if (!eBQvVwBOONVDFpkOxzmJYYkeLVp && object.ReferenceEquals(key, null))
			{
				throw new ArgumentNullException("key");
			}
			if (GGSOwkYkcGqPCiEAySEBrYcSich != null)
			{
				int num = mwBiUDBItuPwEpfcLXpzrrZUnOI.GetHashCode(key) & 0x7FFFFFFF;
				int num2 = num % GGSOwkYkcGqPCiEAySEBrYcSich.Length;
				int num3 = -1;
				for (int num4 = GGSOwkYkcGqPCiEAySEBrYcSich[num2]; num4 >= 0; num4 = _entries[num4].next)
				{
					if (_entries[num4].hashCode == num && mwBiUDBItuPwEpfcLXpzrrZUnOI.Equals(_entries[num4].key, key))
					{
						if (num3 < 0)
						{
							GGSOwkYkcGqPCiEAySEBrYcSich[num2] = _entries[num4].next;
						}
						else
						{
							_entries[num3].next = _entries[num4].next;
						}
						_entries[num4].hashCode = -1;
						_entries[num4].next = xOdawrVENNPfYfkQozMouFmFHbx;
						_entries[num4].key = default(TKey);
						_entries[num4].value = default(TValue);
						xOdawrVENNPfYfkQozMouFmFHbx = num4;
						rfyUrsqsOitzcademolldrVEJAS++;
						WXuCbimssDdLmCLcKcnRVhkhcwYV++;
						return true;
					}
					num3 = num4;
				}
			}
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			int num = IndexOfKey(key);
			if (num >= 0)
			{
				value = _entries[num].value;
				return true;
			}
			value = default(TValue);
			return false;
		}

		public TValue GetValueSafe(TKey key)
		{
			int num = IndexOfKey(key);
			if (num >= 0)
			{
				return _entries[num].value;
			}
			return default(TValue);
		}

		public int IndexOfKey(TKey key)
		{
			if (!eBQvVwBOONVDFpkOxzmJYYkeLVp && object.ReferenceEquals(key, null))
			{
				throw new ArgumentNullException("key");
			}
			if (GGSOwkYkcGqPCiEAySEBrYcSich != null)
			{
				int num = mwBiUDBItuPwEpfcLXpzrrZUnOI.GetHashCode(key) & 0x7FFFFFFF;
				for (int num2 = GGSOwkYkcGqPCiEAySEBrYcSich[num % GGSOwkYkcGqPCiEAySEBrYcSich.Length]; num2 >= 0; num2 = _entries[num2].next)
				{
					if (_entries[num2].hashCode == num && mwBiUDBItuPwEpfcLXpzrrZUnOI.Equals(_entries[num2].key, key))
					{
						return num2;
					}
				}
			}
			return -1;
		}

		public int IndexOfValue(TValue value)
		{
			Entry[] entries = _entries;
			if (!GKmoIrDziJTJKXaUPMfkiLDPGmJ && value == null)
			{
				for (int i = 0; i < _count; i++)
				{
					if (entries[i].hashCode >= 0 && entries[i].value == null)
					{
						return i;
					}
				}
			}
			else
			{
				IEqualityComparer<TValue> kOOkgpdQaaudnLwzWeCkuGQxcay = KOOkgpdQaaudnLwzWeCkuGQxcay;
				for (int j = 0; j < _count; j++)
				{
					if (entries[j].hashCode >= 0 && kOOkgpdQaaudnLwzWeCkuGQxcay.Equals(entries[j].value, value))
					{
						return j;
					}
				}
			}
			return -1;
		}

		public bool IsValidAt(int index)
		{
			if ((uint)index >= (uint)_count)
			{
				return false;
			}
			return _entries[index].hashCode >= 0;
		}

		public TKey GetKeyAt(int index)
		{
			if ((uint)index >= (uint)_count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (_entries[index].hashCode < 0)
			{
				throw new ArgumentException("index points to an invalid entry.");
			}
			return _entries[index].key;
		}

		public TValue GetValueAt(int index)
		{
			if ((uint)index >= (uint)_count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (_entries[index].hashCode < 0)
			{
				throw new ArgumentException("index points to an invalid entry.");
			}
			return _entries[index].value;
		}

		public KeyValuePair<TKey, TValue> GetEntryAt(int index)
		{
			if ((uint)index >= (uint)_count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (_entries[index].hashCode < 0)
			{
				throw new ArgumentException("index points to an invalid entry.");
			}
			return new KeyValuePair<TKey, TValue>(_entries[index].key, _entries[index].value);
		}

		public bool TryGetKeyAt(int index, out TKey key)
		{
			if ((uint)index >= (uint)_count || _entries[index].hashCode < 0)
			{
				key = default(TKey);
				return false;
			}
			key = _entries[index].key;
			return true;
		}

		public bool TryGetValueAt(int index, out TValue value)
		{
			if ((uint)index >= (uint)_count || _entries[index].hashCode < 0)
			{
				value = default(TValue);
				return false;
			}
			value = _entries[index].value;
			return true;
		}

		public bool TryGetEntryAt(int index, out KeyValuePair<TKey, TValue> entry)
		{
			if ((uint)index >= (uint)_count || _entries[index].hashCode < 0)
			{
				entry = default(KeyValuePair<TKey, TValue>);
				return false;
			}
			entry = new KeyValuePair<TKey, TValue>(_entries[index].key, _entries[index].value);
			return true;
		}

		public bool GetNextIndex(ref int index)
		{
			index++;
			if ((uint)index >= (uint)_count)
			{
				return false;
			}
			while (index < _count)
			{
				if (_entries[index].hashCode >= 0)
				{
					return true;
				}
				index++;
			}
			return false;
		}

		public int GetNextIndex(int index)
		{
			index++;
			if ((uint)index >= (uint)_count)
			{
				return -1;
			}
			while (index < _count)
			{
				if (_entries[index].hashCode >= 0)
				{
					return index;
				}
				index++;
			}
			return -1;
		}

		public bool GetNextKey(ref int index, out TKey key)
		{
			index++;
			if ((uint)index >= (uint)_count)
			{
				key = default(TKey);
				return false;
			}
			while (index < _count)
			{
				if (_entries[index].hashCode >= 0)
				{
					key = _entries[index].key;
					return true;
				}
				index++;
			}
			key = default(TKey);
			return false;
		}

		public bool GetNextValue(ref int index, out TValue value)
		{
			index++;
			if ((uint)index >= (uint)_count)
			{
				value = default(TValue);
				return false;
			}
			while (index < _count)
			{
				if (_entries[index].hashCode >= 0)
				{
					value = _entries[index].value;
					return true;
				}
				index++;
			}
			value = default(TValue);
			return false;
		}

		public bool GetNextEntry(ref int index, out KeyValuePair<TKey, TValue> entry)
		{
			index++;
			if ((uint)index >= (uint)_count)
			{
				entry = default(KeyValuePair<TKey, TValue>);
				return false;
			}
			while (index < _count)
			{
				if (_entries[index].hashCode >= 0)
				{
					entry = new KeyValuePair<TKey, TValue>(_entries[index].key, _entries[index].value);
					return true;
				}
				index++;
			}
			entry = default(KeyValuePair<TKey, TValue>);
			return false;
		}

		public bool GetPreviousIndex(ref int index)
		{
			index--;
			if ((uint)index >= (uint)_count)
			{
				return false;
			}
			while (index >= 0)
			{
				if (_entries[index].hashCode >= 0)
				{
					return true;
				}
				index--;
			}
			return false;
		}

		public int GetPreviousIndex(int index)
		{
			index--;
			if ((uint)index >= (uint)_count)
			{
				return -1;
			}
			while (index >= 0)
			{
				if (_entries[index].hashCode >= 0)
				{
					return index;
				}
				index--;
			}
			return -1;
		}

		public bool GetPreviousKey(ref int index, out TKey key)
		{
			index--;
			if ((uint)index >= (uint)_count)
			{
				key = default(TKey);
				return false;
			}
			while (index >= 0)
			{
				if (_entries[index].hashCode >= 0)
				{
					key = _entries[index].key;
					return true;
				}
				index--;
			}
			key = default(TKey);
			return false;
		}

		public bool GetPreviousValue(ref int index, out TValue value)
		{
			index--;
			if ((uint)index >= (uint)_count)
			{
				value = default(TValue);
				return false;
			}
			while (index >= 0)
			{
				if (_entries[index].hashCode >= 0)
				{
					value = _entries[index].value;
					return true;
				}
				index--;
			}
			value = default(TValue);
			return false;
		}

		public bool GetPreviousEntry(ref int index, out KeyValuePair<TKey, TValue> entry)
		{
			index--;
			if ((uint)index >= (uint)_count)
			{
				entry = default(KeyValuePair<TKey, TValue>);
				return false;
			}
			while (index >= 0)
			{
				if (_entries[index].hashCode >= 0)
				{
					entry = new KeyValuePair<TKey, TValue>(_entries[index].key, _entries[index].value);
					return true;
				}
				index--;
			}
			entry = default(KeyValuePair<TKey, TValue>);
			return false;
		}

		public bool RemoveAt(int index)
		{
			if ((uint)index >= (uint)_count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (_entries[index].hashCode < 0)
			{
				return false;
			}
			Remove(_entries[index].key);
			return true;
		}

		private void NqJyYWfUSeVcsxtklStVCSitOjJ(KeyValuePair<TKey, TValue>[] P_0, int P_1)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException("array");
			}
			if (P_1 < 0 || P_1 > P_0.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (P_0.Length - P_1 < Count)
			{
				throw new Exception();
			}
			int count = _count;
			Entry[] entries = _entries;
			for (int i = 0; i < count; i++)
			{
				if (entries[i].hashCode >= 0)
				{
					ref KeyValuePair<TKey, TValue> reference = ref P_0[P_1++];
					reference = new KeyValuePair<TKey, TValue>(entries[i].key, entries[i].value);
				}
			}
		}

		private void ijQPrfbohIDtyfCSvLMVhrlmSpB(int P_0)
		{
			int num = wgzQpWLRzSQCvlVxxfWWhhZRFzK.JNQBqtUFDHLRkLPjdRYpJvpzPzc(P_0);
			GGSOwkYkcGqPCiEAySEBrYcSich = new int[num];
			for (int i = 0; i < GGSOwkYkcGqPCiEAySEBrYcSich.Length; i++)
			{
				GGSOwkYkcGqPCiEAySEBrYcSich[i] = -1;
			}
			_entries = new Entry[num];
			xOdawrVENNPfYfkQozMouFmFHbx = -1;
		}

		private void QuZbncESlaeCcibZnMSMRnTzdnOR(TKey P_0, TValue P_1, bool P_2)
		{
			if (!eBQvVwBOONVDFpkOxzmJYYkeLVp && object.ReferenceEquals(P_0, null))
			{
				throw new ArgumentNullException("key");
			}
			if (GGSOwkYkcGqPCiEAySEBrYcSich == null)
			{
				ijQPrfbohIDtyfCSvLMVhrlmSpB(0);
			}
			int num = mwBiUDBItuPwEpfcLXpzrrZUnOI.GetHashCode(P_0) & 0x7FFFFFFF;
			int num2 = num % GGSOwkYkcGqPCiEAySEBrYcSich.Length;
			for (int num3 = GGSOwkYkcGqPCiEAySEBrYcSich[num2]; num3 >= 0; num3 = _entries[num3].next)
			{
				if (_entries[num3].hashCode == num && mwBiUDBItuPwEpfcLXpzrrZUnOI.Equals(_entries[num3].key, P_0))
				{
					if (P_2)
					{
						throw new ArgumentException("An element with the same key already exists in the dictionary.");
					}
					_entries[num3].value = P_1;
					WXuCbimssDdLmCLcKcnRVhkhcwYV++;
					return;
				}
			}
			int count;
			if (rfyUrsqsOitzcademolldrVEJAS > 0)
			{
				count = xOdawrVENNPfYfkQozMouFmFHbx;
				xOdawrVENNPfYfkQozMouFmFHbx = _entries[count].next;
				rfyUrsqsOitzcademolldrVEJAS--;
			}
			else
			{
				if (_count == _entries.Length)
				{
					ctOLgCKaxwNOBwmyGauwaNdICgr();
					num2 = num % GGSOwkYkcGqPCiEAySEBrYcSich.Length;
				}
				count = _count;
				_count++;
			}
			_entries[count].hashCode = num;
			_entries[count].next = GGSOwkYkcGqPCiEAySEBrYcSich[num2];
			_entries[count].key = P_0;
			_entries[count].value = P_1;
			GGSOwkYkcGqPCiEAySEBrYcSich[num2] = count;
			WXuCbimssDdLmCLcKcnRVhkhcwYV++;
			AXLKpbqabRNdeGmrDEerbeXHKwzE++;
		}

		private void ctOLgCKaxwNOBwmyGauwaNdICgr()
		{
			ctOLgCKaxwNOBwmyGauwaNdICgr(wgzQpWLRzSQCvlVxxfWWhhZRFzK.xNdsRoDvcRuqXOyQxwDNXdDksqW(_count), false);
		}

		private void ctOLgCKaxwNOBwmyGauwaNdICgr(int P_0, bool P_1)
		{
			int[] array = new int[P_0];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = -1;
			}
			Entry[] array2 = new Entry[P_0];
			Array.Copy(_entries, 0, array2, 0, _count);
			if (P_1)
			{
				for (int j = 0; j < _count; j++)
				{
					if (array2[j].hashCode != -1)
					{
						array2[j].hashCode = mwBiUDBItuPwEpfcLXpzrrZUnOI.GetHashCode(array2[j].key) & 0x7FFFFFFF;
					}
				}
			}
			for (int k = 0; k < _count; k++)
			{
				if (array2[k].hashCode >= 0)
				{
					int num = array2[k].hashCode % P_0;
					array2[k].next = array[num];
					array[num] = k;
				}
			}
			GGSOwkYkcGqPCiEAySEBrYcSich = array;
			_entries = array2;
		}

		IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator()
		{
			return new Enumerator(this, 2);
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> keyValuePair)
		{
			Add(keyValuePair.Key, keyValuePair.Value);
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> keyValuePair)
		{
			int num = IndexOfKey(keyValuePair.Key);
			if (num >= 0 && KOOkgpdQaaudnLwzWeCkuGQxcay.Equals(_entries[num].value, keyValuePair.Value))
			{
				return true;
			}
			return false;
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> keyValuePair)
		{
			int num = IndexOfKey(keyValuePair.Key);
			if (num >= 0 && KOOkgpdQaaudnLwzWeCkuGQxcay.Equals(_entries[num].value, keyValuePair.Value))
			{
				Remove(keyValuePair.Key);
				return true;
			}
			return false;
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
			NqJyYWfUSeVcsxtklStVCSitOjJ(array, index);
		}

		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (array.Rank != 1)
			{
				throw new Exception();
			}
			if (array.GetLowerBound(0) != 0)
			{
				throw new Exception();
			}
			if (index < 0 || index > array.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (array.Length - index < Count)
			{
				throw new Exception();
			}
			if (array is KeyValuePair<TKey, TValue>[] array2)
			{
				NqJyYWfUSeVcsxtklStVCSitOjJ(array2, index);
				return;
			}
			if (array is DictionaryEntry[])
			{
				DictionaryEntry[] array3 = array as DictionaryEntry[];
				Entry[] entries = _entries;
				for (int i = 0; i < _count; i++)
				{
					if (entries[i].hashCode >= 0)
					{
						ref DictionaryEntry reference = ref array3[index++];
						reference = new DictionaryEntry(entries[i].key, entries[i].value);
					}
				}
				return;
			}
			if (!(array is object[] array4))
			{
				throw new Exception();
			}
			try
			{
				int count = _count;
				Entry[] entries2 = _entries;
				for (int j = 0; j < count; j++)
				{
					if (entries2[j].hashCode >= 0)
					{
						array4[index++] = new KeyValuePair<TKey, TValue>(entries2[j].key, entries2[j].value);
					}
				}
			}
			catch (ArrayTypeMismatchException)
			{
				throw new Exception();
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Enumerator(this, 2);
		}

		void IDictionary.Add(object key, object value)
		{
			if (key == null)
			{
				throw new ArgumentNullException("key");
			}
			pVIwMuzEnBBuABeMJUvfzCnBAgo<TValue>(value, "value");
			try
			{
				TKey key2 = (TKey)key;
				try
				{
					Add(key2, (TValue)value);
				}
				catch (InvalidCastException)
				{
					throw new Exception();
				}
			}
			catch (InvalidCastException)
			{
				throw new Exception();
			}
		}

		bool IDictionary.Contains(object key)
		{
			if (jtcAJBkPFJHmlfLNkIDdZWwrPLcp(key))
			{
				return ContainsKey((TKey)key);
			}
			return false;
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new Enumerator(this, 1);
		}

		void IDictionary.Remove(object key)
		{
			if (jtcAJBkPFJHmlfLNkIDdZWwrPLcp(key))
			{
				Remove((TKey)key);
			}
		}

		private static bool jtcAJBkPFJHmlfLNkIDdZWwrPLcp(object P_0)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException("key");
			}
			return P_0 is TKey;
		}

		private static void pVIwMuzEnBBuABeMJUvfzCnBAgo<T>(object P_0, string P_1)
		{
			if (P_0 == null && default(T) != null)
			{
				throw new ArgumentNullException(P_1);
			}
		}
	}
}
