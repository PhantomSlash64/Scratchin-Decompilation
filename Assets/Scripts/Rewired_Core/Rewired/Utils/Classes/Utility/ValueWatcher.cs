using System;
using System.Collections.Generic;

namespace Rewired.Utils.Classes.Utility
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal abstract class ValueWatcher
	{
		public enum QjZlTrxCinORqXiVNpimTWJXjci
		{
			fbblFDgOAByPFkGIyIfyjpjCAEN = 0
		}

		public abstract bool changed { get; }

		public abstract bool autoTriggerEvent { get; set; }

		public abstract bool Update();

		public abstract bool Use();

		public abstract bool TriggerEvent();

		public abstract void AddEventListener(QjZlTrxCinORqXiVNpimTWJXjci eventType, Delegate listener);

		public abstract void RemoveEventListener(QjZlTrxCinORqXiVNpimTWJXjci eventType, Delegate listener);
	}
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal sealed class ValueWatcher<T> : ValueWatcher
	{
		private static IEqualityComparer<T> hPOodOXbAyKiBDZtGrwOeKJANXO = EqualityComparerNoAlloc<T>.Default;

		private bool BJpTHOBDZWqjBuqRcKnCppIOZXl;

		private T bvCAKWIqWpqXDpHqoSmmOfdNAgMo;

		private bool tlWGjhdEGdNGTmOBPafEfUkWgeU;

		private Func<T> UlxWrVyfgMOLSZkugzZmBoaKGPJ;

		private Action<T> SAZMNMknjNgSdBCCoBRVrQJEzSUm;

		public override bool changed => BJpTHOBDZWqjBuqRcKnCppIOZXl;

		public override bool autoTriggerEvent
		{
			get
			{
				return tlWGjhdEGdNGTmOBPafEfUkWgeU;
			}
			set
			{
				tlWGjhdEGdNGTmOBPafEfUkWgeU = value;
			}
		}

		public Func<T> getValueDelegate
		{
			get
			{
				return UlxWrVyfgMOLSZkugzZmBoaKGPJ;
			}
			set
			{
				UlxWrVyfgMOLSZkugzZmBoaKGPJ = value;
			}
		}

		public T value => bvCAKWIqWpqXDpHqoSmmOfdNAgMo;

		public event Action<T> ChangedEvent
		{
			add
			{
				SAZMNMknjNgSdBCCoBRVrQJEzSUm = (Action<T>)Delegate.Combine(SAZMNMknjNgSdBCCoBRVrQJEzSUm, value);
			}
			remove
			{
				SAZMNMknjNgSdBCCoBRVrQJEzSUm = (Action<T>)Delegate.Remove(SAZMNMknjNgSdBCCoBRVrQJEzSUm, value);
			}
		}

		public ValueWatcher(T initialValue, bool autoTriggerEvent)
		{
			bvCAKWIqWpqXDpHqoSmmOfdNAgMo = initialValue;
			tlWGjhdEGdNGTmOBPafEfUkWgeU = autoTriggerEvent;
		}

		public ValueWatcher(T initialValue, Func<T> getValueDelegate, bool autoTriggerEvent)
			: this(initialValue, autoTriggerEvent)
		{
			UlxWrVyfgMOLSZkugzZmBoaKGPJ = getValueDelegate;
		}

		public override bool Update()
		{
			if (UlxWrVyfgMOLSZkugzZmBoaKGPJ == null)
			{
				return false;
			}
			try
			{
				return Set(UlxWrVyfgMOLSZkugzZmBoaKGPJ());
			}
			catch (Exception ex)
			{
				Logger.LogError("An exception was thrown by getValueDelegate.\n" + ex);
				return false;
			}
		}

		public override bool Use()
		{
			if (!BJpTHOBDZWqjBuqRcKnCppIOZXl)
			{
				return false;
			}
			BJpTHOBDZWqjBuqRcKnCppIOZXl = false;
			return true;
		}

		public override bool TriggerEvent()
		{
			if (!BJpTHOBDZWqjBuqRcKnCppIOZXl)
			{
				return false;
			}
			if (SAZMNMknjNgSdBCCoBRVrQJEzSUm == null)
			{
				return true;
			}
			try
			{
				Use();
				SAZMNMknjNgSdBCCoBRVrQJEzSUm(bvCAKWIqWpqXDpHqoSmmOfdNAgMo);
				return true;
			}
			catch (Exception ex)
			{
				Logger.LogError("An exception was thrown by ValueChangedEvent handler.\n" + ex);
				return false;
			}
		}

		public bool Set(T value)
		{
			if (hPOodOXbAyKiBDZtGrwOeKJANXO.Equals(bvCAKWIqWpqXDpHqoSmmOfdNAgMo, value))
			{
				return false;
			}
			bvCAKWIqWpqXDpHqoSmmOfdNAgMo = value;
			BJpTHOBDZWqjBuqRcKnCppIOZXl = true;
			if (tlWGjhdEGdNGTmOBPafEfUkWgeU)
			{
				TriggerEvent();
			}
			return true;
		}

		public override void AddEventListener(QjZlTrxCinORqXiVNpimTWJXjci eventType, Delegate listener)
		{
			if (eventType == QjZlTrxCinORqXiVNpimTWJXjci.fbblFDgOAByPFkGIyIfyjpjCAEN)
			{
				if (!(listener is Action<T>))
				{
					throw new ArgumentException("listener must be of type Action<" + typeof(T).Name + ">");
				}
				ChangedEvent += (Action<T>)listener;
				return;
			}
			throw new NotImplementedException();
		}

		public override void RemoveEventListener(QjZlTrxCinORqXiVNpimTWJXjci eventType, Delegate listener)
		{
			if (eventType == QjZlTrxCinORqXiVNpimTWJXjci.fbblFDgOAByPFkGIyIfyjpjCAEN)
			{
				if (!(listener is Action<T>))
				{
					throw new ArgumentException("listener must be of type Action<" + typeof(T).Name + ">");
				}
				ChangedEvent -= (Action<T>)listener;
				return;
			}
			throw new NotImplementedException();
		}
	}
}
