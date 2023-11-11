using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rewired.Utils
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal abstract class SafeDelegate : ICloneable
	{
		private static Action<Exception> oeRfXiczLfnEEVejIwvOXjrnKJx;

		internal abstract int Count { get; }

		internal abstract Action<Exception> ExceptionHandler { get; set; }

		internal static Action<Exception> S_ExceptionHandler
		{
			get
			{
				return oeRfXiczLfnEEVejIwvOXjrnKJx;
			}
			set
			{
				oeRfXiczLfnEEVejIwvOXjrnKJx = value;
			}
		}

		internal abstract void RemoveDelegateOrAllDelegatesFromAnObject(object obj);

		internal abstract void Clear();

		public abstract object Clone();
	}
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal abstract class SafeDelegate<T> : SafeDelegate where T : class
	{
		private class AosalhUMCLIEwhFeejaGcJOfwys
		{
			public readonly T ntdQAYYKCISkDZMPhXhyiKDSvkD;

			public readonly object PXoaWZfLoapsgtctcTOzaohJoYM;

			public readonly object VehjGrlDjNcvQwYnPFWkoJbtpiZ;

			public readonly bool MKjPJrTIAQhwwHroaDYiCueHdwgg;

			public AosalhUMCLIEwhFeejaGcJOfwys(T item)
			{
				ntdQAYYKCISkDZMPhXhyiKDSvkD = item;
				PXoaWZfLoapsgtctcTOzaohJoYM = ((Delegate)(object)item).Target;
				try
				{
					VehjGrlDjNcvQwYnPFWkoJbtpiZ = ReflectionTools.GetMethodInfo((Delegate)(object)item);
				}
				catch
				{
					VehjGrlDjNcvQwYnPFWkoJbtpiZ = null;
				}
				MKjPJrTIAQhwwHroaDYiCueHdwgg = PXoaWZfLoapsgtctcTOzaohJoYM != null && PXoaWZfLoapsgtctcTOzaohJoYM is UnityEngine.Object;
			}

			public AosalhUMCLIEwhFeejaGcJOfwys(AosalhUMCLIEwhFeejaGcJOfwys source)
				: this(MiscTools.Clone((object)source.ntdQAYYKCISkDZMPhXhyiKDSvkD) as T)
			{
			}

			public bool WboyGDFEBzgoTcCKciJDFQGXqnAE()
			{
				if (PXoaWZfLoapsgtctcTOzaohJoYM != null)
				{
					if (PXoaWZfLoapsgtctcTOzaohJoYM is UnityEngine.Object)
					{
						return (UnityEngine.Object)PXoaWZfLoapsgtctcTOzaohJoYM == null;
					}
					return false;
				}
				return true;
			}
		}

		private Action<Exception> NovCmsWGGrgWDavIFmmMhthCUoYi;

		private readonly List<AosalhUMCLIEwhFeejaGcJOfwys> njhPGMgBtPENMVnOqHUnSpUEVpe;

		private readonly List<AosalhUMCLIEwhFeejaGcJOfwys> kKkVMgAMJmqiDoPbYSKVokHNDeac;

		internal override int Count => njhPGMgBtPENMVnOqHUnSpUEVpe.Count;

		internal override Action<Exception> ExceptionHandler
		{
			get
			{
				return NovCmsWGGrgWDavIFmmMhthCUoYi;
			}
			set
			{
				NovCmsWGGrgWDavIFmmMhthCUoYi = value;
			}
		}

		protected SafeDelegate()
		{
			if (!ReflectionTools.DoesTypeImplement(typeof(T), typeof(Delegate)))
			{
				throw new Exception(typeof(T).Name + " is not a delegate type! SafeDelegate only works with delegate types.");
			}
			njhPGMgBtPENMVnOqHUnSpUEVpe = new List<AosalhUMCLIEwhFeejaGcJOfwys>();
			kKkVMgAMJmqiDoPbYSKVokHNDeac = new List<AosalhUMCLIEwhFeejaGcJOfwys>();
			if (NovCmsWGGrgWDavIFmmMhthCUoYi == null)
			{
				NovCmsWGGrgWDavIFmmMhthCUoYi = SafeDelegate.S_ExceptionHandler;
			}
		}

		protected SafeDelegate(Action<Exception> exceptionHandler)
			: this()
		{
			if (exceptionHandler == null)
			{
				throw new ArgumentNullException("exceptionHandler");
			}
			NovCmsWGGrgWDavIFmmMhthCUoYi = exceptionHandler;
		}

		protected SafeDelegate(SafeDelegate<T> source)
			: this()
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (source.NovCmsWGGrgWDavIFmmMhthCUoYi != null)
			{
				NovCmsWGGrgWDavIFmmMhthCUoYi = source.NovCmsWGGrgWDavIFmmMhthCUoYi;
			}
			for (int i = 0; i < source.njhPGMgBtPENMVnOqHUnSpUEVpe.Count; i++)
			{
				njhPGMgBtPENMVnOqHUnSpUEVpe.Add(new AosalhUMCLIEwhFeejaGcJOfwys(source.njhPGMgBtPENMVnOqHUnSpUEVpe[i]));
			}
		}

		public void AddDelegate(T @delegate)
		{
			if (@delegate == null)
			{
				return;
			}
			List<Delegate> list = HPtNgJPQHhRwSBzcKmJYcAWgzjX((Delegate)(object)@delegate);
			if (list == null || list.Count == 0)
			{
				return;
			}
			for (int i = 0; i < list.Count; i++)
			{
				T val = (T)(object)list[i];
				if (!oQFygjrDaMtXNUGnYpOhqPuoBesB(val))
				{
					njhPGMgBtPENMVnOqHUnSpUEVpe.Add(new AosalhUMCLIEwhFeejaGcJOfwys(val));
				}
			}
		}

		public void RemoveDelegate(T @delegate)
		{
			if (@delegate == null)
			{
				return;
			}
			List<Delegate> list = HPtNgJPQHhRwSBzcKmJYcAWgzjX((Delegate)(object)@delegate);
			if (list == null || list.Count == 0)
			{
				return;
			}
			int count = njhPGMgBtPENMVnOqHUnSpUEVpe.Count;
			for (int i = 0; i < list.Count; i++)
			{
				for (int num = count - 1; num >= 0; num--)
				{
					if (EqualityComparer<T>.Default.Equals(njhPGMgBtPENMVnOqHUnSpUEVpe[num].ntdQAYYKCISkDZMPhXhyiKDSvkD, (T)(object)list[i]))
					{
						njhPGMgBtPENMVnOqHUnSpUEVpe.RemoveAt(num);
					}
				}
			}
		}

		internal override void RemoveDelegateOrAllDelegatesFromAnObject(object obj)
		{
			int count = njhPGMgBtPENMVnOqHUnSpUEVpe.Count;
			for (int num = count - 1; num >= 0; num--)
			{
				Delegate @delegate = FFtSVxdBHOFmUigfEUxzAbbDWXE(obj, (Delegate)(object)njhPGMgBtPENMVnOqHUnSpUEVpe[num].ntdQAYYKCISkDZMPhXhyiKDSvkD);
				if (DXJVnjuFXhommRyjfATapahlSSp(@delegate) == 0)
				{
					njhPGMgBtPENMVnOqHUnSpUEVpe.RemoveAt(num);
				}
				else
				{
					njhPGMgBtPENMVnOqHUnSpUEVpe[num] = new AosalhUMCLIEwhFeejaGcJOfwys((T)(object)@delegate);
				}
			}
		}

		internal override void Clear()
		{
			njhPGMgBtPENMVnOqHUnSpUEVpe.Clear();
		}

		protected void Invoke(Action<object, T> invokeCallback)
		{
			if (invokeCallback == null)
			{
				throw new ArgumentNullException("invokeCallback");
			}
			int count = njhPGMgBtPENMVnOqHUnSpUEVpe.Count;
			if (count == 0)
			{
				return;
			}
			kKkVMgAMJmqiDoPbYSKVokHNDeac.Clear();
			for (int i = 0; i < count; i++)
			{
				kKkVMgAMJmqiDoPbYSKVokHNDeac.Add(njhPGMgBtPENMVnOqHUnSpUEVpe[i]);
			}
			List<int> list = null;
			for (int j = 0; j < count; j++)
			{
				AosalhUMCLIEwhFeejaGcJOfwys aosalhUMCLIEwhFeejaGcJOfwys = kKkVMgAMJmqiDoPbYSKVokHNDeac[j];
				if (aosalhUMCLIEwhFeejaGcJOfwys.MKjPJrTIAQhwwHroaDYiCueHdwgg && aosalhUMCLIEwhFeejaGcJOfwys.WboyGDFEBzgoTcCKciJDFQGXqnAE())
				{
					if (list == null)
					{
						list = TempListPool.Get<int>();
					}
					list.Add(j);
					continue;
				}
				try
				{
					invokeCallback(this, aosalhUMCLIEwhFeejaGcJOfwys.ntdQAYYKCISkDZMPhXhyiKDSvkD);
				}
				catch (Exception ex)
				{
					if (NovCmsWGGrgWDavIFmmMhthCUoYi != null)
					{
						NovCmsWGGrgWDavIFmmMhthCUoYi(ex);
					}
					else if (ex.InnerException != null)
					{
						Logger.LogError(ex.InnerException, requiredThreadSafety: true);
					}
					if (list == null)
					{
						list = TempListPool.Get<int>();
					}
					list.Add(j);
				}
			}
			if (list != null)
			{
				for (int num = list.Count - 1; num >= 0; num--)
				{
					njhPGMgBtPENMVnOqHUnSpUEVpe.RemoveAt(list[num]);
				}
				TempListPool.Return(list);
			}
			if (count > 0)
			{
				kKkVMgAMJmqiDoPbYSKVokHNDeac.Clear();
			}
		}

		protected T GetCombinedDelegate()
		{
			if (njhPGMgBtPENMVnOqHUnSpUEVpe == null)
			{
				return null;
			}
			T val = null;
			for (int i = 0; i < njhPGMgBtPENMVnOqHUnSpUEVpe.Count; i++)
			{
				T ntdQAYYKCISkDZMPhXhyiKDSvkD = njhPGMgBtPENMVnOqHUnSpUEVpe[i].ntdQAYYKCISkDZMPhXhyiKDSvkD;
				if (val == null)
				{
					val = ntdQAYYKCISkDZMPhXhyiKDSvkD;
					continue;
				}
				try
				{
					val = (T)(object)Delegate.Combine((Delegate)(object)val, (Delegate)(object)ntdQAYYKCISkDZMPhXhyiKDSvkD);
				}
				catch
				{
				}
			}
			return val;
		}

		private bool oQFygjrDaMtXNUGnYpOhqPuoBesB(T P_0)
		{
			return eaOrStrSOuOlEEMmganiuTHlvbL(P_0) >= 0;
		}

		private int eaOrStrSOuOlEEMmganiuTHlvbL(T P_0)
		{
			int count = njhPGMgBtPENMVnOqHUnSpUEVpe.Count;
			for (int i = 0; i < count; i++)
			{
				if (EqualityComparer<T>.Default.Equals(njhPGMgBtPENMVnOqHUnSpUEVpe[i].ntdQAYYKCISkDZMPhXhyiKDSvkD, P_0))
				{
					return i;
				}
			}
			return -1;
		}

		private static Delegate FFtSVxdBHOFmUigfEUxzAbbDWXE(object P_0, Delegate P_1)
		{
			if ((object)P_1 == null || P_0 == null)
			{
				return P_1;
			}
			if (P_0 is Delegate)
			{
				return FFtSVxdBHOFmUigfEUxzAbbDWXE((Delegate)P_0, P_1);
			}
			try
			{
				Delegate[] invocationList = P_1.GetInvocationList();
				for (int i = 0; i < invocationList.Length; i++)
				{
					if (object.ReferenceEquals(invocationList[i].Target, P_0) || object.ReferenceEquals(ReflectionTools.GetMethodInfo(invocationList[i]), P_0))
					{
						if ((object)P_1 == null)
						{
							return P_1;
						}
						P_1 = Delegate.RemoveAll(P_1, invocationList[i]);
					}
				}
				return P_1;
			}
			catch (Exception ex)
			{
				Logger.LogError("Exception caught while removing delegates from list (1):\n" + ex);
				return P_1;
			}
		}

		private static Delegate FFtSVxdBHOFmUigfEUxzAbbDWXE(Delegate P_0, Delegate P_1)
		{
			if ((object)P_0 == null || (object)P_1 == null)
			{
				return P_1;
			}
			if (!object.ReferenceEquals(P_0.GetType(), P_0.GetType()))
			{
				return P_1;
			}
			try
			{
				Delegate[] invocationList = P_0.GetInvocationList();
				Delegate[] invocationList2 = P_1.GetInvocationList();
				foreach (Delegate @delegate in invocationList)
				{
					object methodInfo = ReflectionTools.GetMethodInfo(@delegate);
					foreach (Delegate delegate2 in invocationList2)
					{
						object methodInfo2 = ReflectionTools.GetMethodInfo(delegate2);
						if (object.ReferenceEquals(methodInfo, methodInfo2))
						{
							if ((object)P_1 == null)
							{
								return P_1;
							}
							P_1 = Delegate.RemoveAll(P_1, delegate2);
						}
					}
				}
				return P_1;
			}
			catch (Exception ex)
			{
				Logger.LogError("Exception caught while removing delegates from list (2):\n" + ex);
				return P_1;
			}
		}

		private static int DXJVnjuFXhommRyjfATapahlSSp(Delegate P_0)
		{
			if ((object)P_0 == null)
			{
				return 0;
			}
			Delegate[] invocationList = P_0.GetInvocationList();
			if (invocationList == null)
			{
				return 0;
			}
			return invocationList.Length;
		}

		private static List<Delegate> HPtNgJPQHhRwSBzcKmJYcAWgzjX(Delegate P_0)
		{
			if ((object)P_0 == null)
			{
				return null;
			}
			Delegate @delegate = P_0;
			Delegate[] invocationList = @delegate.GetInvocationList();
			if (invocationList == null)
			{
				return null;
			}
			List<Delegate> list = new List<Delegate>(invocationList.Length);
			for (int i = 0; i < invocationList.Length; i++)
			{
				list.Add(invocationList[i]);
			}
			return list;
		}
	}
}
