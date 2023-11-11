using System;

namespace Rewired.Utils
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal static class SystemInfo
	{
		public static readonly bool is64Bit;

		static SystemInfo()
		{
			is64Bit = IntPtr.Size == 8;
		}
	}
}
