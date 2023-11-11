using System;
using System.Collections.Generic;

namespace Rewired.Utils.Classes.Utility
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class ObjectPool<T> : IObjectPool<T>, IObjectPool where T : class
	{
		protected readonly Queue<T> _pool;

		protected readonly Func<T> _createInstanceDelegate;

		protected readonly Action<T> _processOnReturnDelegate;

		private ulong TZiwyBEbVkJpkDaMLyIwiTAkOwT;

		protected ulong InstanceCount => TZiwyBEbVkJpkDaMLyIwiTAkOwT;

		public ObjectPool(int startingSize, Func<T> createInstanceDelegate, Action<T> processOnReturnDelegate = null)
		{
			if (createInstanceDelegate == null)
			{
				throw new ArgumentNullException("instancerDelegate");
			}
			_processOnReturnDelegate = processOnReturnDelegate;
			_pool = ((startingSize > 0) ? new Queue<T>(startingSize) : new Queue<T>());
			_createInstanceDelegate = createInstanceDelegate;
		}

		public ObjectPool(Func<T> instancerDelegate)
			: this(0, instancerDelegate, (Action<T>)null)
		{
		}

		public void Clear(bool reduceSize = false)
		{
			lock (_pool)
			{
				_pool.Clear();
				if (reduceSize)
				{
					_pool.TrimExcess();
				}
			}
		}

		public T Get()
		{
			lock (_pool)
			{
				if (_pool.Count == 0)
				{
					return CreateInstance();
				}
				T val = _pool.Dequeue();
				if (val is IPoolableObject_Internal)
				{
					(val as IPoolableObject_Internal).pool = this;
				}
				return val;
			}
		}

		public bool Return(T item)
		{
			if (item == null)
			{
				return false;
			}
			if (_processOnReturnDelegate != null)
			{
				_processOnReturnDelegate(item);
			}
			if (item is IPoolableObject_Internal)
			{
				(item as IPoolableObject_Internal).Clear();
			}
			lock (_pool)
			{
				_pool.Enqueue(item);
			}
			return true;
		}

		private object RWnqsgyABiCIrNSvKRIXUIjMDKqA()
		{
			return Get();
		}

		object IObjectPool.Get()
		{
			//ILSpy generated this explicit interface implementation from .override directive in RWnqsgyABiCIrNSvKRIXUIjMDKqA
			return this.RWnqsgyABiCIrNSvKRIXUIjMDKqA();
		}

		private bool XMtpcsuBilvLAJwSpFOOaPWGoqL(object P_0)
		{
			return Return(P_0 as T);
		}

		bool IObjectPool.Return(object P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in XMtpcsuBilvLAJwSpFOOaPWGoqL
			return this.XMtpcsuBilvLAJwSpFOOaPWGoqL(P_0);
		}

		protected T CreateInstance()
		{
			T val = _createInstanceDelegate();
			if (val is IPoolableObject_Internal)
			{
				(val as IPoolableObject_Internal).pool = this;
			}
			IncrementInstanceCount();
			return val;
		}

		protected ulong IncrementInstanceCount()
		{
			TZiwyBEbVkJpkDaMLyIwiTAkOwT = ((TZiwyBEbVkJpkDaMLyIwiTAkOwT < ulong.MaxValue) ? (TZiwyBEbVkJpkDaMLyIwiTAkOwT + 1) : 0);
			return TZiwyBEbVkJpkDaMLyIwiTAkOwT;
		}
	}
}
