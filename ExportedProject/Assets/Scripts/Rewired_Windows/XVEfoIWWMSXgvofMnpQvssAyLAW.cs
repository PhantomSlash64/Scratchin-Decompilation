using System;
using System.Runtime.InteropServices;
using Rewired.Utils;

internal static class XVEfoIWWMSXgvofMnpQvssAyLAW
{
	public static string veqmoECEegRaWsEZjvSbfJUuBZa(IntPtr P_0, int P_1)
	{
		if (P_1 <= 0)
		{
			return null;
		}
		if (P_1 < 2 || Marshal.ReadByte(P_0, P_1 - 1) != 0 || Marshal.ReadByte(P_0, P_1 - 2) != 0)
		{
			IntPtr intPtr = Marshal.AllocHGlobal(P_1 + 2);
			NativeTools.CopyMemory(P_0, intPtr, 0, 0, P_1);
			Marshal.WriteInt16(intPtr, P_1, 0);
			string result = Marshal.PtrToStringUni(intPtr);
			Marshal.FreeHGlobal(intPtr);
			return result;
		}
		return Marshal.PtrToStringUni(P_0);
	}
}
