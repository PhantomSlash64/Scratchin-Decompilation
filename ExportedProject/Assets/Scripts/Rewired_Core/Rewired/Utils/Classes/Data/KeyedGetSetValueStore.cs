using System;
using System.Collections;
using System.Collections.Generic;
using Rewired.Utils.Interfaces;

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	[CustomObfuscation(rename = false)]
	internal sealed class KeyedGetSetValueStore<TKey> : IEnumerable, IDictionary<TKey, object>, ICollection<KeyValuePair<TKey, object>>, IEnumerable<KeyValuePair<TKey, object>>
	{
		private readonly Dictionary<TKey, object> mCcGEqkjMlkdLIrXjIaiVhutUrp;

		private readonly bool DcdDnQgqKfoLqevzDmNiLkrXlTGe;

		public int Count => mCcGEqkjMlkdLIrXjIaiVhutUrp.Count;

		public bool isReadOnlyCollection => DcdDnQgqKfoLqevzDmNiLkrXlTGe;

		ICollection<TKey> IDictionary<TKey, object>.Keys => mCcGEqkjMlkdLIrXjIaiVhutUrp.Keys;

		ICollection<object> IDictionary<TKey, object>.Values => mCcGEqkjMlkdLIrXjIaiVhutUrp.Values;

		object IDictionary<TKey, object>.this[TKey key]
		{
			get
			{
				return mCcGEqkjMlkdLIrXjIaiVhutUrp[key];
			}
			set
			{
				SGPkbaswKPGTxcFoOTNSFSDEDLQ();
				mCcGEqkjMlkdLIrXjIaiVhutUrp[key] = value;
			}
		}

		int ICollection<KeyValuePair<TKey, object>>.Count => mCcGEqkjMlkdLIrXjIaiVhutUrp.Count;

		bool ICollection<KeyValuePair<TKey, object>>.IsReadOnly => DcdDnQgqKfoLqevzDmNiLkrXlTGe;

		public KeyedGetSetValueStore(Dictionary<TKey, object> valueDelegates, bool isReadOnlyCollection)
		{
			mCcGEqkjMlkdLIrXjIaiVhutUrp = valueDelegates;
			DcdDnQgqKfoLqevzDmNiLkrXlTGe = isReadOnlyCollection;
		}

		public KeyedGetSetValueStore(bool isReadOnlyCollection)
		{
			DcdDnQgqKfoLqevzDmNiLkrXlTGe = isReadOnlyCollection;
			mCcGEqkjMlkdLIrXjIaiVhutUrp = new Dictionary<TKey, object>();
		}

		public void AddItem<TValue>(TKey key, IGetSetValue<TValue> item)
		{
			if (item == null)
			{
				throw new ArgumentNullException("item");
			}
			SGPkbaswKPGTxcFoOTNSFSDEDLQ();
			mCcGEqkjMlkdLIrXjIaiVhutUrp.Add(key, item);
		}

		public IGetSetValue<TValue> GetItem<TValue>(TKey key)
		{
			if (!mCcGEqkjMlkdLIrXjIaiVhutUrp.TryGetValue(key, out var value) || !(value is IGetSetValue<TValue> result))
			{
				AEnQbCpVbsJGMDuACmXvnkFSRfP(key, typeof(TValue));
				return null;
			}
			return result;
		}

		public bool RemoveItem<TValue>(TKey key)
		{
			SGPkbaswKPGTxcFoOTNSFSDEDLQ();
			return mCcGEqkjMlkdLIrXjIaiVhutUrp.Remove(key);
		}

		public bool ContainsKey(TKey key)
		{
			return mCcGEqkjMlkdLIrXjIaiVhutUrp.ContainsKey(key);
		}

		public void Clear()
		{
			SGPkbaswKPGTxcFoOTNSFSDEDLQ();
			mCcGEqkjMlkdLIrXjIaiVhutUrp.Clear();
		}

		public bool ContainsValue<TValue>(TKey key)
		{
			if (mCcGEqkjMlkdLIrXjIaiVhutUrp.TryGetValue(key, out var value))
			{
				return value is IGetSetValue<TValue>;
			}
			return false;
		}

		public TValue GetValue<TValue>(TKey key)
		{
			if (!TryGetValue<TValue>(key, out var value))
			{
				AEnQbCpVbsJGMDuACmXvnkFSRfP(key, typeof(TValue));
			}
			return value;
		}

		public void SetValue<TValue>(TKey key, TValue value)
		{
			if (!TrySetValue(key, value))
			{
				AEnQbCpVbsJGMDuACmXvnkFSRfP(key, typeof(TValue));
			}
		}

		public bool TryGetValue<TValue>(TKey key, out TValue value)
		{
			if (!mCcGEqkjMlkdLIrXjIaiVhutUrp.TryGetValue(key, out var value2) || !(value2 is IGetValue<TValue> getValue))
			{
				value = default(TValue);
				Logger.LogError(xuYpBuXJnggtVMGQutUDkfcXDGF(key, typeof(TValue)), requiredThreadSafety: true);
				return false;
			}
			value = getValue.GetValue();
			return true;
		}

		public bool TrySetValue<TValue>(TKey key, TValue value)
		{
			ISetValue<TValue> setValue;
			if (!mCcGEqkjMlkdLIrXjIaiVhutUrp.TryGetValue(key, out var value2) || (setValue = value2 as GetSetValue<TValue>) == null)
			{
				Logger.LogError(xuYpBuXJnggtVMGQutUDkfcXDGF(key, typeof(TValue)), requiredThreadSafety: true);
				return false;
			}
			setValue.SetValue(value);
			return true;
		}

		private void SGPkbaswKPGTxcFoOTNSFSDEDLQ()
		{
			if (DcdDnQgqKfoLqevzDmNiLkrXlTGe)
			{
				throw new Exception("The collection is read-only.");
			}
		}

		private static void AEnQbCpVbsJGMDuACmXvnkFSRfP(TKey P_0, Type P_1)
		{
			throw new Exception(xuYpBuXJnggtVMGQutUDkfcXDGF(P_0, P_1));
		}

		private static string xuYpBuXJnggtVMGQutUDkfcXDGF(TKey P_0, Type P_1)
		{
			return string.Concat("Value with key ", P_0, " of type ", P_1, " not found.");
		}

		void IDictionary<TKey, object>.Add(TKey key, object value)
		{
			SGPkbaswKPGTxcFoOTNSFSDEDLQ();
			mCcGEqkjMlkdLIrXjIaiVhutUrp.Add(key, value);
		}

		bool IDictionary<TKey, object>.ContainsKey(TKey key)
		{
			return ContainsKey(key);
		}

		bool IDictionary<TKey, object>.Remove(TKey key)
		{
			SGPkbaswKPGTxcFoOTNSFSDEDLQ();
			return mCcGEqkjMlkdLIrXjIaiVhutUrp.Remove(key);
		}

		bool IDictionary<TKey, object>.TryGetValue(TKey key, out object value)
		{
			return mCcGEqkjMlkdLIrXjIaiVhutUrp.TryGetValue(key, out value);
		}

		void ICollection<KeyValuePair<TKey, object>>.Add(KeyValuePair<TKey, object> item)
		{
			SGPkbaswKPGTxcFoOTNSFSDEDLQ();
			((ICollection<KeyValuePair<TKey, object>>)mCcGEqkjMlkdLIrXjIaiVhutUrp).Add(item);
		}

		void ICollection<KeyValuePair<TKey, object>>.Clear()
		{
			SGPkbaswKPGTxcFoOTNSFSDEDLQ();
			((ICollection<KeyValuePair<TKey, object>>)mCcGEqkjMlkdLIrXjIaiVhutUrp).Clear();
		}

		bool ICollection<KeyValuePair<TKey, object>>.Contains(KeyValuePair<TKey, object> item)
		{
			return ((ICollection<KeyValuePair<TKey, object>>)mCcGEqkjMlkdLIrXjIaiVhutUrp).Contains(item);
		}

		void ICollection<KeyValuePair<TKey, object>>.CopyTo(KeyValuePair<TKey, object>[] array, int arrayIndex)
		{
			((ICollection<KeyValuePair<TKey, object>>)mCcGEqkjMlkdLIrXjIaiVhutUrp).CopyTo(array, arrayIndex);
		}

		bool ICollection<KeyValuePair<TKey, object>>.Remove(KeyValuePair<TKey, object> item)
		{
			SGPkbaswKPGTxcFoOTNSFSDEDLQ();
			return ((ICollection<KeyValuePair<TKey, object>>)mCcGEqkjMlkdLIrXjIaiVhutUrp).Remove(item);
		}

		IEnumerator<KeyValuePair<TKey, object>> IEnumerable<KeyValuePair<TKey, object>>.GetEnumerator()
		{
			return mCcGEqkjMlkdLIrXjIaiVhutUrp.GetEnumerator();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return mCcGEqkjMlkdLIrXjIaiVhutUrp.GetEnumerator();
		}
	}
}
