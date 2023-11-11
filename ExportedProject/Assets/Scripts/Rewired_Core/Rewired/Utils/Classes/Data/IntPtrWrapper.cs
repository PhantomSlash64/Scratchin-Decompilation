using System;

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class IntPtrWrapper
	{
		private IntPtr jpWQbdNEImIrQtsJkmlAelMmRsP;

		public bool IsValid => jpWQbdNEImIrQtsJkmlAelMmRsP != IntPtr.Zero;

		public IntPtrWrapper(IntPtr pointer)
		{
			jpWQbdNEImIrQtsJkmlAelMmRsP = pointer;
		}

		public void Clear()
		{
			jpWQbdNEImIrQtsJkmlAelMmRsP = IntPtr.Zero;
		}

		public static implicit operator IntPtr(IntPtrWrapper obj)
		{
			return obj?.jpWQbdNEImIrQtsJkmlAelMmRsP ?? IntPtr.Zero;
		}
	}
}
