using System;
using System.Threading;

namespace Rewired.Utils.Classes.Utility
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class LockedObject<T> : IDisposable
	{
		public T item;

		private readonly object wiAAWxJXkkUNOJPPrkFaSdrKANW;

		private bool doIejlnEExUyrwadcLeWitsmGzG;

		public LockedObject()
		{
			wiAAWxJXkkUNOJPPrkFaSdrKANW = new object();
		}

		public LockedObject(object lockObject)
		{
			if (lockObject == null)
			{
				throw new ArgumentNullException("lockObject");
			}
			wiAAWxJXkkUNOJPPrkFaSdrKANW = lockObject;
		}

		public void Lock()
		{
			if (doIejlnEExUyrwadcLeWitsmGzG)
			{
				throw new Exception("Already locked. Dispose must be called before Lock can be called again.");
			}
			Monitor.Enter(wiAAWxJXkkUNOJPPrkFaSdrKANW);
			doIejlnEExUyrwadcLeWitsmGzG = true;
		}

		public void Unlock()
		{
			if (!doIejlnEExUyrwadcLeWitsmGzG)
			{
				throw new Exception("Not locked. Lock must be called before Dispose.");
			}
			Monitor.Exit(wiAAWxJXkkUNOJPPrkFaSdrKANW);
			doIejlnEExUyrwadcLeWitsmGzG = false;
		}

		void IDisposable.Dispose()
		{
			Unlock();
		}
	}
}
