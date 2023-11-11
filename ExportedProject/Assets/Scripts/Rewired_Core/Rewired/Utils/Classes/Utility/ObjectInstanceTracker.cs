using System;
using System.Collections.Generic;

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class ObjectInstanceTracker : IDisposable
	{
		[CustomObfuscation(rename = false)]
		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		public class Wrapper<T> : IDisposable where T : class
		{
			public readonly T instance;

			public readonly uint instanceId;

			private readonly ObjectInstanceTracker oEyDvPDKVaUqKLBmUSzawITqlRI;

			private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

			public Wrapper(T instance)
				: this(instance, Default)
			{
			}

			public Wrapper(T instance, ObjectInstanceTracker tracker)
			{
				if (instance == null)
				{
					throw new ArgumentNullException("instance");
				}
				if (tracker == null)
				{
					throw new ArgumentNullException("tracker");
				}
				this.instance = instance;
				oEyDvPDKVaUqKLBmUSzawITqlRI = tracker;
				instanceId = tracker.Register(instance);
			}

			public void Dispose()
			{
				Dispose(disposing: true);
				GC.SuppressFinalize(this);
			}

			~Wrapper()
			{
				Dispose(disposing: false);
			}

			protected virtual void Dispose(bool disposing)
			{
				if (!RFSEgUYkCipDyWyLEnlGiNDUlzz)
				{
					if (oEyDvPDKVaUqKLBmUSzawITqlRI != null)
					{
						oEyDvPDKVaUqKLBmUSzawITqlRI.Unregister(instanceId);
					}
					RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
				}
			}
		}

		private static ObjectInstanceTracker jSlMHYpliVFUzTfJqvhklMtlwTN;

		private readonly Dictionary<uint, object> bbZZfctOelnRnkMIbwwmqdGXCjt = new Dictionary<uint, object>();

		private readonly object wiAAWxJXkkUNOJPPrkFaSdrKANW = new object();

		private uint fNVHrPEgKZdLQuDpPcZeErbSwJOM;

		private int TZiwyBEbVkJpkDaMLyIwiTAkOwT;

		private bool MAhxQpPgOiyAciKSsSLflQlrhyHa;

		public static ObjectInstanceTracker Default => jSlMHYpliVFUzTfJqvhklMtlwTN ?? (jSlMHYpliVFUzTfJqvhklMtlwTN = new ObjectInstanceTracker());

		public uint Register(object instance)
		{
			if (instance == null)
			{
				throw new ArgumentNullException("instance");
			}
			TZiwyBEbVkJpkDaMLyIwiTAkOwT++;
			uint num = fNVHrPEgKZdLQuDpPcZeErbSwJOM++;
			bbZZfctOelnRnkMIbwwmqdGXCjt.Add(num, instance);
			return num;
		}

		public void Unregister(uint instanceId)
		{
			TZiwyBEbVkJpkDaMLyIwiTAkOwT--;
			if (TZiwyBEbVkJpkDaMLyIwiTAkOwT < 0)
			{
				TZiwyBEbVkJpkDaMLyIwiTAkOwT = 0;
			}
			lock (wiAAWxJXkkUNOJPPrkFaSdrKANW)
			{
				bbZZfctOelnRnkMIbwwmqdGXCjt.Remove(instanceId);
			}
		}

		public bool TryGetInstance<T>(uint instanceId, out T instance) where T : class
		{
			lock (wiAAWxJXkkUNOJPPrkFaSdrKANW)
			{
				if (!bbZZfctOelnRnkMIbwwmqdGXCjt.TryGetValue(instanceId, out var value))
				{
					instance = null;
					return false;
				}
				if (value is T)
				{
					instance = (T)value;
					return true;
				}
				instance = null;
				return false;
			}
		}

		public void Dispose()
		{
			vLCbxFvjSKbaoKsQRAbGNRMrnwI(true);
			GC.SuppressFinalize(this);
		}

		private void vLCbxFvjSKbaoKsQRAbGNRMrnwI(bool P_0)
		{
			if (!MAhxQpPgOiyAciKSsSLflQlrhyHa)
			{
				if (this == jSlMHYpliVFUzTfJqvhklMtlwTN)
				{
					jSlMHYpliVFUzTfJqvhklMtlwTN = null;
				}
				MAhxQpPgOiyAciKSsSLflQlrhyHa = true;
			}
		}

		~ObjectInstanceTracker()
		{
			vLCbxFvjSKbaoKsQRAbGNRMrnwI(false);
		}
	}
}
