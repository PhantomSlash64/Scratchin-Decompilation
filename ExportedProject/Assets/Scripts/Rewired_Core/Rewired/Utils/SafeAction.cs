using System;

namespace Rewired.Utils
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal sealed class SafeAction : SafeDelegate<Action>
	{
		private static Action<object, Action> zKUgGZCIfazKLEtbqOUQIrWsLFRw;

		private static Action<object, Action> invokeDelegate => XYNLMZqOPYkXEMIDuPzFcSVFwI;

		public SafeAction()
		{
		}

		public SafeAction(Action<Exception> exceptionHandler)
			: base(exceptionHandler)
		{
		}

		private SafeAction(SafeAction source)
			: base((SafeDelegate<Action>)source)
		{
		}

		public void Invoke()
		{
			try
			{
				Invoke(invokeDelegate);
			}
			catch (Exception ex)
			{
				Logger.LogError("Error invoking SafeAction base class.\n" + ex);
			}
		}

		public override object Clone()
		{
			return new SafeAction(this);
		}

		private static void XYNLMZqOPYkXEMIDuPzFcSVFwI(object P_0, Action P_1)
		{
			P_1?.Invoke();
		}

		public static SafeAction operator +(SafeAction eventList, Action listener)
		{
			if (eventList == null)
			{
				eventList = new SafeAction();
			}
			eventList.AddDelegate(listener);
			return eventList;
		}

		public static SafeAction operator -(SafeAction eventList, Action listener)
		{
			if (eventList == null)
			{
				return null;
			}
			eventList.RemoveDelegate(listener);
			return eventList;
		}

		public static implicit operator Action(SafeAction obj)
		{
			return obj?.GetCombinedDelegate();
		}

		public static implicit operator SafeAction(Action obj)
		{
			if (obj == null)
			{
				return null;
			}
			SafeAction safeAction = new SafeAction();
			safeAction.AddDelegate(obj);
			return safeAction;
		}
	}
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal sealed class SafeAction<T> : SafeDelegate<Action<T>>
	{
		private T ddyVBOVUvogZfBkXDNdYnbHGnAF;

		private static Action<object, Action<T>> zKUgGZCIfazKLEtbqOUQIrWsLFRw;

		private static Action<object, Action<T>> invokeDelegate => XYNLMZqOPYkXEMIDuPzFcSVFwI;

		public SafeAction()
		{
		}

		public SafeAction(Action<Exception> exceptionHandler)
			: base(exceptionHandler)
		{
		}

		protected SafeAction(SafeAction<T> source)
			: base((SafeDelegate<Action<T>>)source)
		{
		}

		public void Invoke(T arg0)
		{
			ddyVBOVUvogZfBkXDNdYnbHGnAF = arg0;
			try
			{
				Invoke(invokeDelegate);
			}
			catch
			{
				Logger.LogError("Error invoking SafeAction base class.");
			}
			ddyVBOVUvogZfBkXDNdYnbHGnAF = default(T);
		}

		public override object Clone()
		{
			return new SafeAction<T>(this);
		}

		private static void XYNLMZqOPYkXEMIDuPzFcSVFwI(object P_0, Action<T> P_1)
		{
			if (P_1 != null && P_0 is SafeAction<T> safeAction)
			{
				P_1(safeAction.ddyVBOVUvogZfBkXDNdYnbHGnAF);
			}
		}

		public static SafeAction<T>operator +(SafeAction<T> eventList, Action<T> listener)
		{
			if (eventList == null)
			{
				eventList = new SafeAction<T>();
			}
			eventList.AddDelegate(listener);
			return eventList;
		}

		public static SafeAction<T>operator -(SafeAction<T> eventList, Action<T> listener)
		{
			if (eventList == null)
			{
				return null;
			}
			eventList.RemoveDelegate(listener);
			return eventList;
		}

		public static implicit operator Action<T>(SafeAction<T> obj)
		{
			return obj?.GetCombinedDelegate();
		}

		public static implicit operator SafeAction<T>(Action<T> obj)
		{
			if (obj == null)
			{
				return null;
			}
			SafeAction<T> safeAction = new SafeAction<T>();
			safeAction.AddDelegate(obj);
			return safeAction;
		}
	}
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal sealed class SafeAction<T, T2> : SafeDelegate<Action<T, T2>>
	{
		private T ddyVBOVUvogZfBkXDNdYnbHGnAF;

		private T2 UQNeXzerGYcjOZFRvrTRBKmjLjM;

		private static Action<object, Action<T, T2>> zKUgGZCIfazKLEtbqOUQIrWsLFRw;

		private static Action<object, Action<T, T2>> invokeDelegate => XYNLMZqOPYkXEMIDuPzFcSVFwI;

		public SafeAction()
		{
		}

		public SafeAction(Action<Exception> exceptionHandler)
			: base(exceptionHandler)
		{
		}

		protected SafeAction(SafeAction<T, T2> source)
			: base((SafeDelegate<Action<T, T2>>)source)
		{
		}

		public void Invoke(T arg0, T2 arg1)
		{
			ddyVBOVUvogZfBkXDNdYnbHGnAF = arg0;
			UQNeXzerGYcjOZFRvrTRBKmjLjM = arg1;
			try
			{
				Invoke(invokeDelegate);
			}
			catch
			{
				Logger.LogError("Error invoking SafeAction base class.");
			}
			ddyVBOVUvogZfBkXDNdYnbHGnAF = default(T);
			UQNeXzerGYcjOZFRvrTRBKmjLjM = default(T2);
		}

		public override object Clone()
		{
			return new SafeAction<T, T2>(this);
		}

		private static void XYNLMZqOPYkXEMIDuPzFcSVFwI(object P_0, Action<T, T2> P_1)
		{
			if (P_1 != null && P_0 is SafeAction<T, T2> safeAction)
			{
				P_1(safeAction.ddyVBOVUvogZfBkXDNdYnbHGnAF, safeAction.UQNeXzerGYcjOZFRvrTRBKmjLjM);
			}
		}

		public static SafeAction<T, T2>operator +(SafeAction<T, T2> eventList, Action<T, T2> listener)
		{
			if (eventList == null)
			{
				eventList = new SafeAction<T, T2>();
			}
			eventList.AddDelegate(listener);
			return eventList;
		}

		public static SafeAction<T, T2>operator -(SafeAction<T, T2> eventList, Action<T, T2> listener)
		{
			if (eventList == null)
			{
				return null;
			}
			eventList.RemoveDelegate(listener);
			return eventList;
		}

		public static implicit operator Action<T, T2>(SafeAction<T, T2> obj)
		{
			return obj?.GetCombinedDelegate();
		}

		public static implicit operator SafeAction<T, T2>(Action<T, T2> obj)
		{
			if (obj == null)
			{
				return null;
			}
			SafeAction<T, T2> safeAction = new SafeAction<T, T2>();
			safeAction.AddDelegate(obj);
			return safeAction;
		}
	}
}
