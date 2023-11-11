using System;

namespace Rewired.Utils
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class SafePredicate<T> : SafeDelegate<Predicate<T>>
	{
		private T ddyVBOVUvogZfBkXDNdYnbHGnAF;

		private bool oblarXCKyKxPpPzdMDydCtcjdXoF;

		private static Action<object, Predicate<T>> zKUgGZCIfazKLEtbqOUQIrWsLFRw;

		private static Action<object, Predicate<T>> invokeDelegate => XYNLMZqOPYkXEMIDuPzFcSVFwI;

		public SafePredicate()
		{
		}

		public SafePredicate(Action<Exception> exceptionHandler)
			: base(exceptionHandler)
		{
		}

		protected SafePredicate(SafePredicate<T> source)
			: base((SafeDelegate<Predicate<T>>)source)
		{
		}

		public bool Invoke(T arg0)
		{
			ddyVBOVUvogZfBkXDNdYnbHGnAF = arg0;
			try
			{
				Invoke(invokeDelegate);
				return oblarXCKyKxPpPzdMDydCtcjdXoF;
			}
			catch
			{
				Logger.LogError("Error invoking SafeDelegate base class.");
				return false;
			}
			finally
			{
				ddyVBOVUvogZfBkXDNdYnbHGnAF = default(T);
				oblarXCKyKxPpPzdMDydCtcjdXoF = false;
			}
		}

		public override object Clone()
		{
			return new SafePredicate<T>(this);
		}

		private static void XYNLMZqOPYkXEMIDuPzFcSVFwI(object P_0, Predicate<T> P_1)
		{
			if (P_1 != null && P_0 is SafePredicate<T> safePredicate)
			{
				safePredicate.oblarXCKyKxPpPzdMDydCtcjdXoF = P_1(safePredicate.ddyVBOVUvogZfBkXDNdYnbHGnAF);
			}
		}

		public static SafePredicate<T>operator +(SafePredicate<T> eventList, Predicate<T> predicate)
		{
			if (eventList == null)
			{
				eventList = new SafePredicate<T>();
			}
			eventList.AddDelegate(predicate);
			return eventList;
		}

		public static SafePredicate<T>operator -(SafePredicate<T> eventList, Predicate<T> predicate)
		{
			if (eventList == null)
			{
				return null;
			}
			eventList.RemoveDelegate(predicate);
			return eventList;
		}

		public static implicit operator Predicate<T>(SafePredicate<T> obj)
		{
			return obj?.GetCombinedDelegate();
		}

		public static implicit operator SafePredicate<T>(Predicate<T> obj)
		{
			if (obj == null)
			{
				return null;
			}
			SafePredicate<T> safePredicate = new SafePredicate<T>();
			safePredicate.AddDelegate(obj);
			return safePredicate;
		}
	}
}
