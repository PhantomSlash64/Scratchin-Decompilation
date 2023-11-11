using System;
using System.Collections;
using System.Collections.Generic;
using Rewired.Utils.Interfaces;

namespace Rewired.Utils.Classes.Data
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class IndexedDictionary<TKey, TValue> : IEnumerable, IDictionary, ICollection, IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, Rewired.Utils.Interfaces.IReadOnlyList<TValue>, IReadOnlyList
	{
		private struct kvREBtzwNpSPawmoDYAiSurGNjc
		{
			public TKey fOeEjmDvcmIurnFXpoRksQpExxr;

			public TValue foSRcEqSuRsWnadDiKcGnhBewOU;

			public kvREBtzwNpSPawmoDYAiSurGNjc(TKey key, TValue value)
			{
				fOeEjmDvcmIurnFXpoRksQpExxr = key;
				foSRcEqSuRsWnadDiKcGnhBewOU = value;
			}

			public KeyValuePair<TKey, TValue> pFEFAjuiWqkXHWRqHAIkokzjdxRh()
			{
				return new KeyValuePair<TKey, TValue>(fOeEjmDvcmIurnFXpoRksQpExxr, foSRcEqSuRsWnadDiKcGnhBewOU);
			}
		}

		[Serializable]
		[CustomObfuscation(rename = false)]
		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		public struct Enumerator : IDisposable, IEnumerator, IDictionaryEnumerator, IEnumerator<KeyValuePair<TKey, TValue>>
		{
			internal const int DictEntry = 1;

			internal const int KeyValuePair = 2;

			private IndexedDictionary<TKey, TValue> niSwIGuixCCwVvwckEvgBcZHWRr;

			private int HMIUyauSwlzrtCBuqxkNKgKURdX;

			private int MfVGCAceIAkEXxwxwAsLGoqQvdj;

			private KeyValuePair<TKey, TValue> HBFpvdVSEToPvyDvjayPiQyuurNQ;

			private int iKXzUiflASTTRVqyQTfKKkvsorh;

			public KeyValuePair<TKey, TValue> Current => HBFpvdVSEToPvyDvjayPiQyuurNQ;

			object IEnumerator.Current
			{
				get
				{
					if (MfVGCAceIAkEXxwxwAsLGoqQvdj == 0 || MfVGCAceIAkEXxwxwAsLGoqQvdj == niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._count + 1)
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
					if (MfVGCAceIAkEXxwxwAsLGoqQvdj == 0 || MfVGCAceIAkEXxwxwAsLGoqQvdj == niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._count + 1)
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
					if (MfVGCAceIAkEXxwxwAsLGoqQvdj == 0 || MfVGCAceIAkEXxwxwAsLGoqQvdj == niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._count + 1)
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
					if (MfVGCAceIAkEXxwxwAsLGoqQvdj == 0 || MfVGCAceIAkEXxwxwAsLGoqQvdj == niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._count + 1)
					{
						throw new Exception();
					}
					return HBFpvdVSEToPvyDvjayPiQyuurNQ.Value;
				}
			}

			internal Enumerator(IndexedDictionary<TKey, TValue> dictionary, int getEnumeratorRetType)
			{
				niSwIGuixCCwVvwckEvgBcZHWRr = dictionary;
				HMIUyauSwlzrtCBuqxkNKgKURdX = dictionary.giKLSgrhLNwAUMnedtVqLxbOwiO.Version;
				MfVGCAceIAkEXxwxwAsLGoqQvdj = 0;
				iKXzUiflASTTRVqyQTfKKkvsorh = getEnumeratorRetType;
				HBFpvdVSEToPvyDvjayPiQyuurNQ = default(KeyValuePair<TKey, TValue>);
			}

			public bool MoveNext()
			{
				if (HMIUyauSwlzrtCBuqxkNKgKURdX != niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO.Version)
				{
					throw new Exception();
				}
				if ((uint)MfVGCAceIAkEXxwxwAsLGoqQvdj < (uint)niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._count)
				{
					HBFpvdVSEToPvyDvjayPiQyuurNQ = new KeyValuePair<TKey, TValue>(niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._items[MfVGCAceIAkEXxwxwAsLGoqQvdj].fOeEjmDvcmIurnFXpoRksQpExxr, niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._items[MfVGCAceIAkEXxwxwAsLGoqQvdj].foSRcEqSuRsWnadDiKcGnhBewOU);
					MfVGCAceIAkEXxwxwAsLGoqQvdj++;
					return true;
				}
				MfVGCAceIAkEXxwxwAsLGoqQvdj = niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._count + 1;
				HBFpvdVSEToPvyDvjayPiQyuurNQ = default(KeyValuePair<TKey, TValue>);
				return false;
			}

			public void Dispose()
			{
			}

			void IEnumerator.Reset()
			{
				if (HMIUyauSwlzrtCBuqxkNKgKURdX != niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO.Version)
				{
					throw new Exception();
				}
				MfVGCAceIAkEXxwxwAsLGoqQvdj = 0;
				HBFpvdVSEToPvyDvjayPiQyuurNQ = default(KeyValuePair<TKey, TValue>);
			}
		}

		[Serializable]
		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		[CustomObfuscation(rename = false)]
		public sealed class KeyCollection : IEnumerable, ICollection, IEnumerable<TKey>, ICollection<TKey>
		{
			[Serializable]
			[CustomObfuscation(rename = false)]
			[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
			public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TKey>
			{
				private IndexedDictionary<TKey, TValue> niSwIGuixCCwVvwckEvgBcZHWRr;

				private int MfVGCAceIAkEXxwxwAsLGoqQvdj;

				private int HMIUyauSwlzrtCBuqxkNKgKURdX;

				private TKey JYqTGdbvLueBBsTMAJDqEVakKMW;

				public TKey Current => JYqTGdbvLueBBsTMAJDqEVakKMW;

				object IEnumerator.Current
				{
					get
					{
						if (MfVGCAceIAkEXxwxwAsLGoqQvdj == 0 || MfVGCAceIAkEXxwxwAsLGoqQvdj == niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._count + 1)
						{
							throw new Exception();
						}
						return JYqTGdbvLueBBsTMAJDqEVakKMW;
					}
				}

				internal Enumerator(IndexedDictionary<TKey, TValue> dictionary)
				{
					niSwIGuixCCwVvwckEvgBcZHWRr = dictionary;
					HMIUyauSwlzrtCBuqxkNKgKURdX = dictionary.giKLSgrhLNwAUMnedtVqLxbOwiO.Version;
					MfVGCAceIAkEXxwxwAsLGoqQvdj = 0;
					JYqTGdbvLueBBsTMAJDqEVakKMW = default(TKey);
				}

				public void Dispose()
				{
				}

				public bool MoveNext()
				{
					if (HMIUyauSwlzrtCBuqxkNKgKURdX != niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO.Version)
					{
						throw new Exception();
					}
					if ((uint)MfVGCAceIAkEXxwxwAsLGoqQvdj < (uint)niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._count)
					{
						JYqTGdbvLueBBsTMAJDqEVakKMW = niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._items[MfVGCAceIAkEXxwxwAsLGoqQvdj].fOeEjmDvcmIurnFXpoRksQpExxr;
						MfVGCAceIAkEXxwxwAsLGoqQvdj++;
						return true;
					}
					MfVGCAceIAkEXxwxwAsLGoqQvdj = niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._count + 1;
					JYqTGdbvLueBBsTMAJDqEVakKMW = default(TKey);
					return false;
				}

				void IEnumerator.Reset()
				{
					if (HMIUyauSwlzrtCBuqxkNKgKURdX != niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO.Version)
					{
						throw new Exception();
					}
					MfVGCAceIAkEXxwxwAsLGoqQvdj = 0;
					JYqTGdbvLueBBsTMAJDqEVakKMW = default(TKey);
				}
			}

			private IndexedDictionary<TKey, TValue> niSwIGuixCCwVvwckEvgBcZHWRr;

			public int Count => niSwIGuixCCwVvwckEvgBcZHWRr.Count;

			bool ICollection<TKey>.IsReadOnly => true;

			bool ICollection.IsSynchronized => false;

			object ICollection.SyncRoot => ((ICollection)niSwIGuixCCwVvwckEvgBcZHWRr).SyncRoot;

			public KeyCollection(IndexedDictionary<TKey, TValue> dictionary)
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
				int count = niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._count;
				kvREBtzwNpSPawmoDYAiSurGNjc[] items = niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._items;
				for (int i = 0; i < count; i++)
				{
					array[index++] = items[i].fOeEjmDvcmIurnFXpoRksQpExxr;
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
				int count = niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._count;
				kvREBtzwNpSPawmoDYAiSurGNjc[] items = niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._items;
				try
				{
					for (int i = 0; i < count; i++)
					{
						array3[index++] = items[i].fOeEjmDvcmIurnFXpoRksQpExxr;
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
			[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
			[CustomObfuscation(rename = false)]
			public struct Enumerator : IDisposable, IEnumerator, IEnumerator<TValue>
			{
				private IndexedDictionary<TKey, TValue> niSwIGuixCCwVvwckEvgBcZHWRr;

				private int MfVGCAceIAkEXxwxwAsLGoqQvdj;

				private int HMIUyauSwlzrtCBuqxkNKgKURdX;

				private TValue WxoEyKAdKggSznEdFdogyftgtRP;

				public TValue Current => WxoEyKAdKggSznEdFdogyftgtRP;

				object IEnumerator.Current
				{
					get
					{
						if (MfVGCAceIAkEXxwxwAsLGoqQvdj == 0 || MfVGCAceIAkEXxwxwAsLGoqQvdj == niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._count + 1)
						{
							throw new Exception();
						}
						return WxoEyKAdKggSznEdFdogyftgtRP;
					}
				}

				internal Enumerator(IndexedDictionary<TKey, TValue> dictionary)
				{
					niSwIGuixCCwVvwckEvgBcZHWRr = dictionary;
					HMIUyauSwlzrtCBuqxkNKgKURdX = dictionary.giKLSgrhLNwAUMnedtVqLxbOwiO.Version;
					MfVGCAceIAkEXxwxwAsLGoqQvdj = 0;
					WxoEyKAdKggSznEdFdogyftgtRP = default(TValue);
				}

				public void Dispose()
				{
				}

				public bool MoveNext()
				{
					if (HMIUyauSwlzrtCBuqxkNKgKURdX != niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO.Version)
					{
						throw new Exception();
					}
					if ((uint)MfVGCAceIAkEXxwxwAsLGoqQvdj < (uint)niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._count)
					{
						WxoEyKAdKggSznEdFdogyftgtRP = niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._items[MfVGCAceIAkEXxwxwAsLGoqQvdj].foSRcEqSuRsWnadDiKcGnhBewOU;
						MfVGCAceIAkEXxwxwAsLGoqQvdj++;
						return true;
					}
					MfVGCAceIAkEXxwxwAsLGoqQvdj = niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._count + 1;
					WxoEyKAdKggSznEdFdogyftgtRP = default(TValue);
					return false;
				}

				void IEnumerator.Reset()
				{
					if (HMIUyauSwlzrtCBuqxkNKgKURdX != niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO.Version)
					{
						throw new Exception();
					}
					MfVGCAceIAkEXxwxwAsLGoqQvdj = 0;
					WxoEyKAdKggSznEdFdogyftgtRP = default(TValue);
				}
			}

			private IndexedDictionary<TKey, TValue> niSwIGuixCCwVvwckEvgBcZHWRr;

			public int Count => niSwIGuixCCwVvwckEvgBcZHWRr.Count;

			bool ICollection<TValue>.IsReadOnly => true;

			bool ICollection.IsSynchronized => false;

			object ICollection.SyncRoot => ((ICollection)niSwIGuixCCwVvwckEvgBcZHWRr).SyncRoot;

			public ValueCollection(IndexedDictionary<TKey, TValue> dictionary)
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
				int count = niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._count;
				kvREBtzwNpSPawmoDYAiSurGNjc[] items = niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._items;
				for (int i = 0; i < count; i++)
				{
					array[index++] = items[i].foSRcEqSuRsWnadDiKcGnhBewOU;
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
				int count = niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._count;
				kvREBtzwNpSPawmoDYAiSurGNjc[] items = niSwIGuixCCwVvwckEvgBcZHWRr.giKLSgrhLNwAUMnedtVqLxbOwiO._items;
				try
				{
					for (int i = 0; i < count; i++)
					{
						array3[index++] = items[i].foSRcEqSuRsWnadDiKcGnhBewOU;
					}
				}
				catch (ArrayTypeMismatchException)
				{
					throw new Exception();
				}
			}
		}

		private static readonly bool eBQvVwBOONVDFpkOxzmJYYkeLVp = ReflectionTools.IsValueType(typeof(TKey));

		private static readonly bool GKmoIrDziJTJKXaUPMfkiLDPGmJ = ReflectionTools.IsValueType(typeof(TValue));

		private IEqualityComparer<TKey> mwBiUDBItuPwEpfcLXpzrrZUnOI = EqualityComparerNoAlloc<TKey>.Default;

		private IEqualityComparer<TValue> KOOkgpdQaaudnLwzWeCkuGQxcay = EqualityComparerNoAlloc<TValue>.Default;

		private readonly AList<kvREBtzwNpSPawmoDYAiSurGNjc> giKLSgrhLNwAUMnedtVqLxbOwiO;

		private readonly ADictionary<TKey, int> IYCOAjKGeKtrRAWEtesAKKlavJA;

		private bool rfzTzdyhffsxhlEHqgWtQiYFHOW;

		public int Count => giKLSgrhLNwAUMnedtVqLxbOwiO._count;

		public bool ContainsDuplicateKeys
		{
			get
			{
				if (!rfzTzdyhffsxhlEHqgWtQiYFHOW)
				{
					return false;
				}
				return IYCOAjKGeKtrRAWEtesAKKlavJA._count < giKLSgrhLNwAUMnedtVqLxbOwiO._count;
			}
		}

		public bool AllowDuplicateKeys
		{
			get
			{
				return rfzTzdyhffsxhlEHqgWtQiYFHOW;
			}
			set
			{
				if (rfzTzdyhffsxhlEHqgWtQiYFHOW != value)
				{
					rfzTzdyhffsxhlEHqgWtQiYFHOW = value;
					if (!value && ContainsDuplicateKeys)
					{
						throw new Exception("The dictionary contains duplicate keys and cannot be changed unless the keys are removed.");
					}
				}
			}
		}

		public TValue this[int index]
		{
			get
			{
				if ((uint)index >= (uint)giKLSgrhLNwAUMnedtVqLxbOwiO._count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				return giKLSgrhLNwAUMnedtVqLxbOwiO._items[index].foSRcEqSuRsWnadDiKcGnhBewOU;
			}
			set
			{
				if ((uint)index >= (uint)giKLSgrhLNwAUMnedtVqLxbOwiO._count)
				{
					throw new ArgumentOutOfRangeException("index");
				}
				giKLSgrhLNwAUMnedtVqLxbOwiO._items[index].foSRcEqSuRsWnadDiKcGnhBewOU = value;
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

		public ICollection<TKey> Keys => new KeyCollection(this);

		public ICollection<TValue> Values => new ValueCollection(this);

		bool ICollection<KeyValuePair<TKey, TValue>>.IsReadOnly => false;

		TValue IDictionary<TKey, TValue>.this[TKey key]
		{
			get
			{
				int num = IndexOfKey(key);
				if (num < 0)
				{
					throw new KeyNotFoundException(string.Concat("Key \"", key, "\" does not exist."));
				}
				return giKLSgrhLNwAUMnedtVqLxbOwiO._items[num].foSRcEqSuRsWnadDiKcGnhBewOU;
			}
			set
			{
				SetValue(key, value);
			}
		}

		bool IDictionary.IsFixedSize => false;

		bool IDictionary.IsReadOnly => false;

		ICollection IDictionary.Keys => new KeyCollection(this);

		ICollection IDictionary.Values => new ValueCollection(this);

		object IDictionary.this[object key]
		{
			get
			{
				return ((IDictionary<TKey, TValue>)this)[(TKey)key];
			}
			set
			{
				((IDictionary<TKey, TValue>)this)[(TKey)key] = (TValue)value;
			}
		}

		bool ICollection.IsSynchronized => ((ICollection)giKLSgrhLNwAUMnedtVqLxbOwiO).IsSynchronized;

		object ICollection.SyncRoot => ((ICollection)giKLSgrhLNwAUMnedtVqLxbOwiO).SyncRoot;

		TValue Rewired.Utils.Interfaces.IReadOnlyList<TValue>.this[int index] => this[index];

		int IReadOnlyList.Count => Count;

		object IReadOnlyList.this[int index] => this[index];

		public IndexedDictionary()
			: this(0, allowDuplicateKeys: false)
		{
		}

		public IndexedDictionary(int capacity)
			: this(capacity, allowDuplicateKeys: false)
		{
		}

		public IndexedDictionary(bool allowDuplicateKeys)
			: this(0, allowDuplicateKeys)
		{
		}

		public IndexedDictionary(int capacity, bool allowDuplicateKeys)
		{
			if (capacity < 0)
			{
				throw new ArgumentOutOfRangeException("capacity");
			}
			rfzTzdyhffsxhlEHqgWtQiYFHOW = allowDuplicateKeys;
			giKLSgrhLNwAUMnedtVqLxbOwiO = new AList<kvREBtzwNpSPawmoDYAiSurGNjc>(capacity);
			IYCOAjKGeKtrRAWEtesAKKlavJA = new ADictionary<TKey, int>(capacity);
		}

		public IndexedDictionary(IDictionary<TKey, TValue> dictionary)
			: this(dictionary, allowDuplicateKeys: false)
		{
		}

		public IndexedDictionary(IDictionary<TKey, TValue> dictionary, bool allowDuplicateKeys)
			: this(0, allowDuplicateKeys)
		{
			if (dictionary == null)
			{
				throw new ArgumentNullException("dictionary");
			}
			if (ReflectionTools.DoesTypeImplement(dictionary.GetType(), typeof(IndexedDictionary<TKey, TValue>)))
			{
				IndexedDictionary<TKey, TValue> indexedDictionary = (IndexedDictionary<TKey, TValue>)dictionary;
				for (int i = 0; i < indexedDictionary.giKLSgrhLNwAUMnedtVqLxbOwiO._count; i++)
				{
					Add(indexedDictionary.giKLSgrhLNwAUMnedtVqLxbOwiO._items[i].fOeEjmDvcmIurnFXpoRksQpExxr, indexedDictionary.giKLSgrhLNwAUMnedtVqLxbOwiO._items[i].foSRcEqSuRsWnadDiKcGnhBewOU);
				}
				return;
			}
			foreach (KeyValuePair<TKey, TValue> item in dictionary)
			{
				Add(item.Key, item.Value);
			}
		}

		public TValue GetValue(TKey key)
		{
			return giKLSgrhLNwAUMnedtVqLxbOwiO._items[IYCOAjKGeKtrRAWEtesAKKlavJA[key]].foSRcEqSuRsWnadDiKcGnhBewOU;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			if (!IYCOAjKGeKtrRAWEtesAKKlavJA.TryGetValue(key, out var value2))
			{
				value = default(TValue);
				return false;
			}
			value = giKLSgrhLNwAUMnedtVqLxbOwiO._items[value2].foSRcEqSuRsWnadDiKcGnhBewOU;
			return true;
		}

		public TKey GetKeyAt(int index)
		{
			if ((uint)index >= (uint)giKLSgrhLNwAUMnedtVqLxbOwiO._count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return giKLSgrhLNwAUMnedtVqLxbOwiO[index].fOeEjmDvcmIurnFXpoRksQpExxr;
		}

		public KeyValuePair<TKey, TValue> GetEntry(TKey key)
		{
			return giKLSgrhLNwAUMnedtVqLxbOwiO[IYCOAjKGeKtrRAWEtesAKKlavJA[key]].pFEFAjuiWqkXHWRqHAIkokzjdxRh();
		}

		public KeyValuePair<TKey, TValue> GetEntryAt(int index)
		{
			if ((uint)index >= (uint)giKLSgrhLNwAUMnedtVqLxbOwiO._count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return giKLSgrhLNwAUMnedtVqLxbOwiO[index].pFEFAjuiWqkXHWRqHAIkokzjdxRh();
		}

		public bool TryGetEntry(TKey key, out KeyValuePair<TKey, TValue> entry)
		{
			if (!IYCOAjKGeKtrRAWEtesAKKlavJA.TryGetValue(key, out var value))
			{
				entry = default(KeyValuePair<TKey, TValue>);
				return false;
			}
			entry = giKLSgrhLNwAUMnedtVqLxbOwiO[value].pFEFAjuiWqkXHWRqHAIkokzjdxRh();
			return true;
		}

		public void Add(TKey key, TValue value)
		{
			bool flag = IYCOAjKGeKtrRAWEtesAKKlavJA.ContainsKey(key);
			if (flag && !rfzTzdyhffsxhlEHqgWtQiYFHOW)
			{
				throw new ArgumentException(string.Concat("Key \"", key, "\" is already in use."));
			}
			int value2 = giKLSgrhLNwAUMnedtVqLxbOwiO.Add(new kvREBtzwNpSPawmoDYAiSurGNjc(key, value));
			if (flag)
			{
				IYCOAjKGeKtrRAWEtesAKKlavJA[key] = value2;
			}
			else
			{
				IYCOAjKGeKtrRAWEtesAKKlavJA.Add(key, value2);
			}
		}

		public void SetValue(TKey key, TValue value)
		{
			if (IYCOAjKGeKtrRAWEtesAKKlavJA.TryGetValue(key, out var value2))
			{
				giKLSgrhLNwAUMnedtVqLxbOwiO._items[value2].foSRcEqSuRsWnadDiKcGnhBewOU = value;
				IYCOAjKGeKtrRAWEtesAKKlavJA[key] = value2;
			}
			else
			{
				Add(key, value);
			}
		}

		public bool Remove(TKey key)
		{
			IYCOAjKGeKtrRAWEtesAKKlavJA.Remove(key);
			if (rfzTzdyhffsxhlEHqgWtQiYFHOW)
			{
				bool result = false;
				for (int num = giKLSgrhLNwAUMnedtVqLxbOwiO._count - 1; num >= 0; num--)
				{
					if (mwBiUDBItuPwEpfcLXpzrrZUnOI.Equals(giKLSgrhLNwAUMnedtVqLxbOwiO._items[num].fOeEjmDvcmIurnFXpoRksQpExxr, key))
					{
						giKLSgrhLNwAUMnedtVqLxbOwiO.RemoveAt(num);
						result = true;
					}
				}
				return result;
			}
			int num2 = IndexOfKey(key);
			if (num2 < 0)
			{
				return false;
			}
			RemoveAt(num2);
			return true;
		}

		public void RemoveAt(int index)
		{
			if ((uint)index >= (uint)giKLSgrhLNwAUMnedtVqLxbOwiO._count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			TKey fOeEjmDvcmIurnFXpoRksQpExxr = giKLSgrhLNwAUMnedtVqLxbOwiO._items[index].fOeEjmDvcmIurnFXpoRksQpExxr;
			if (index < giKLSgrhLNwAUMnedtVqLxbOwiO._count - 1)
			{
				for (int i = index + 1; i < giKLSgrhLNwAUMnedtVqLxbOwiO.Count; i++)
				{
					IYCOAjKGeKtrRAWEtesAKKlavJA[giKLSgrhLNwAUMnedtVqLxbOwiO._items[i].fOeEjmDvcmIurnFXpoRksQpExxr] = i - 1;
				}
			}
			giKLSgrhLNwAUMnedtVqLxbOwiO.RemoveAt(index);
			IYCOAjKGeKtrRAWEtesAKKlavJA.Remove(fOeEjmDvcmIurnFXpoRksQpExxr);
		}

		public void RemoveValue(TValue value)
		{
			int num = IndexOfValue(value);
			if (num >= 0)
			{
				_ = giKLSgrhLNwAUMnedtVqLxbOwiO._items[num].fOeEjmDvcmIurnFXpoRksQpExxr;
				RemoveAt(num);
			}
		}

		public int RemoveAll(TValue value)
		{
			int num = 0;
			int count = giKLSgrhLNwAUMnedtVqLxbOwiO._count;
			for (int num2 = count - 1; num2 >= 0; num2--)
			{
				_ = giKLSgrhLNwAUMnedtVqLxbOwiO._items[num2].fOeEjmDvcmIurnFXpoRksQpExxr;
				if (KOOkgpdQaaudnLwzWeCkuGQxcay.Equals(giKLSgrhLNwAUMnedtVqLxbOwiO._items[num2].foSRcEqSuRsWnadDiKcGnhBewOU, value))
				{
					RemoveAt(num2);
					num++;
				}
			}
			return num;
		}

		public int IndexOfKey(TKey key)
		{
			if (!eBQvVwBOONVDFpkOxzmJYYkeLVp && key == null)
			{
				throw new ArgumentNullException("key");
			}
			int count = giKLSgrhLNwAUMnedtVqLxbOwiO._count;
			for (int i = 0; i < count; i++)
			{
				if (mwBiUDBItuPwEpfcLXpzrrZUnOI.Equals(giKLSgrhLNwAUMnedtVqLxbOwiO._items[i].fOeEjmDvcmIurnFXpoRksQpExxr, key))
				{
					return i;
				}
			}
			return -1;
		}

		public int IndexOfValue(TValue value)
		{
			int count = giKLSgrhLNwAUMnedtVqLxbOwiO._count;
			for (int i = 0; i < count; i++)
			{
				if (KOOkgpdQaaudnLwzWeCkuGQxcay.Equals(giKLSgrhLNwAUMnedtVqLxbOwiO._items[i].foSRcEqSuRsWnadDiKcGnhBewOU, value))
				{
					return i;
				}
			}
			return -1;
		}

		public bool ContainsKey(TKey key)
		{
			return IYCOAjKGeKtrRAWEtesAKKlavJA.ContainsKey(key);
		}

		public bool ContainsValue(TValue value)
		{
			return IndexOfValue(value) >= 0;
		}

		public void Clear()
		{
			giKLSgrhLNwAUMnedtVqLxbOwiO.Clear();
			IYCOAjKGeKtrRAWEtesAKKlavJA.Clear();
		}

		public void TrimExcess()
		{
			giKLSgrhLNwAUMnedtVqLxbOwiO.TrimExcess();
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
		{
			Add(item.Key, item.Value);
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			int num = IndexOfKey(item.Key);
			if (num < 0)
			{
				return false;
			}
			kvREBtzwNpSPawmoDYAiSurGNjc kvREBtzwNpSPawmoDYAiSurGNjc = giKLSgrhLNwAUMnedtVqLxbOwiO._items[num];
			return KOOkgpdQaaudnLwzWeCkuGQxcay.Equals(item.Value, kvREBtzwNpSPawmoDYAiSurGNjc.foSRcEqSuRsWnadDiKcGnhBewOU);
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0 || index > array.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (array.Length - index < Count)
			{
				throw new Exception();
			}
			int count = giKLSgrhLNwAUMnedtVqLxbOwiO._count;
			for (int i = 0; i < count; i++)
			{
				ref KeyValuePair<TKey, TValue> reference = ref array[index++];
				reference = new KeyValuePair<TKey, TValue>(giKLSgrhLNwAUMnedtVqLxbOwiO._items[i].fOeEjmDvcmIurnFXpoRksQpExxr, giKLSgrhLNwAUMnedtVqLxbOwiO._items[i].foSRcEqSuRsWnadDiKcGnhBewOU);
			}
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Remove(KeyValuePair<TKey, TValue> item)
		{
			if (rfzTzdyhffsxhlEHqgWtQiYFHOW)
			{
				bool result = false;
				for (int num = giKLSgrhLNwAUMnedtVqLxbOwiO._count - 1; num >= 0; num--)
				{
					kvREBtzwNpSPawmoDYAiSurGNjc kvREBtzwNpSPawmoDYAiSurGNjc = giKLSgrhLNwAUMnedtVqLxbOwiO._items[num];
					if (KOOkgpdQaaudnLwzWeCkuGQxcay.Equals(item.Value, kvREBtzwNpSPawmoDYAiSurGNjc.foSRcEqSuRsWnadDiKcGnhBewOU))
					{
						giKLSgrhLNwAUMnedtVqLxbOwiO.RemoveAt(num);
						result = true;
					}
				}
				return result;
			}
			int num2 = IndexOfKey(item.Key);
			if (num2 < 0)
			{
				return false;
			}
			kvREBtzwNpSPawmoDYAiSurGNjc kvREBtzwNpSPawmoDYAiSurGNjc2 = giKLSgrhLNwAUMnedtVqLxbOwiO._items[num2];
			if (!KOOkgpdQaaudnLwzWeCkuGQxcay.Equals(item.Value, kvREBtzwNpSPawmoDYAiSurGNjc2.foSRcEqSuRsWnadDiKcGnhBewOU))
			{
				return false;
			}
			RemoveAt(num2);
			return true;
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return new Enumerator(this, 1);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Enumerator(this, 1);
		}

		void IDictionary.Add(object key, object value)
		{
			Add((TKey)key, (TValue)value);
		}

		bool IDictionary.Contains(object key)
		{
			return ContainsKey((TKey)key);
		}

		IDictionaryEnumerator IDictionary.GetEnumerator()
		{
			return new Enumerator(this, 2);
		}

		void IDictionary.Remove(object key)
		{
			Remove((TKey)key);
		}

		void ICollection.CopyTo(Array array, int index)
		{
			if (array == null)
			{
				throw new ArgumentNullException("array");
			}
			if (index < 0 || index > array.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (array.Length - index < Count)
			{
				throw new Exception();
			}
			int count = giKLSgrhLNwAUMnedtVqLxbOwiO._count;
			for (int i = 0; i < count; i++)
			{
				array.SetValue(new KeyValuePair<TKey, TValue>(giKLSgrhLNwAUMnedtVqLxbOwiO._items[i].fOeEjmDvcmIurnFXpoRksQpExxr, giKLSgrhLNwAUMnedtVqLxbOwiO._items[i].foSRcEqSuRsWnadDiKcGnhBewOU), index++);
			}
		}

		private int xTMBPRgfdbhuHtaESknUvBBLcHRf(TValue P_0)
		{
			return IndexOfValue(P_0);
		}

		int Rewired.Utils.Interfaces.IReadOnlyList<TValue>.IndexOf(TValue P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in xTMBPRgfdbhuHtaESknUvBBLcHRf
			return this.xTMBPRgfdbhuHtaESknUvBBLcHRf(P_0);
		}

		private bool CysAiSbLZsGUpAzFeChpJYHYHvRh(TValue P_0)
		{
			return ContainsValue(P_0);
		}

		bool Rewired.Utils.Interfaces.IReadOnlyList<TValue>.Contains(TValue P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in CysAiSbLZsGUpAzFeChpJYHYHvRh
			return this.CysAiSbLZsGUpAzFeChpJYHYHvRh(P_0);
		}

		private int PaDIMeKkpLOxIFKChRHtgchSIJA(object P_0)
		{
			return IndexOfValue((TValue)P_0);
		}

		int IReadOnlyList.IndexOf(object P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in PaDIMeKkpLOxIFKChRHtgchSIJA
			return this.PaDIMeKkpLOxIFKChRHtgchSIJA(P_0);
		}

		private bool WJnwKwcFxEunlMzStSSdqbKLiQX(object P_0)
		{
			return ContainsValue((TValue)P_0);
		}

		bool IReadOnlyList.Contains(object P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in WJnwKwcFxEunlMzStSSdqbKLiQX
			return this.WJnwKwcFxEunlMzStSSdqbKLiQX(P_0);
		}
	}
}
