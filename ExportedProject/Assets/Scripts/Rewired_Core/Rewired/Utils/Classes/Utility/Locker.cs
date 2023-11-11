using System;
using System.Threading;

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal struct Locker : IDisposable
	{
		private object PXoaWZfLoapsgtctcTOzaohJoYM;

		public Locker(object target)
		{
			PXoaWZfLoapsgtctcTOzaohJoYM = target;
			if (target != null)
			{
				Monitor.Enter(target);
			}
		}

		public void Dispose()
		{
			if (PXoaWZfLoapsgtctcTOzaohJoYM != null)
			{
				Monitor.Exit(PXoaWZfLoapsgtctcTOzaohJoYM);
				PXoaWZfLoapsgtctcTOzaohJoYM = null;
			}
		}
	}
}
