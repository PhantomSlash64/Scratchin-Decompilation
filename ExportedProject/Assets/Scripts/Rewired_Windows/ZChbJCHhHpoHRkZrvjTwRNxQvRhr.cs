using System;
using System.Runtime.InteropServices;
using System.Security;

internal static class ZChbJCHhHpoHRkZrvjTwRNxQvRhr
{
	public const int NyTbXwDGBKDOkGxGYjFdrdjzbZH = 2048;

	public unsafe static void SAlxGwDcgKhMrjirzProdgvEuWHg(IntPtr P_0, int P_1, Guid P_2, out IntPtr P_3, qFZgaejGInJCCmTgEqQEEiVAcXBC P_4)
	{
		pERSibQDMTkaGVsXRncSUqChDMi pERSibQDMTkaGVsXRncSUqChDMi2;
		fixed (IntPtr* ptr = &P_3)
		{
			pERSibQDMTkaGVsXRncSUqChDMi2 = SAgQxeguYhHAecqXbtuCJmCfGiA((void*)P_0, P_1, &P_2, ptr, (void*)(P_4?.qNCdusATkxKqHGKMOPeqBcgaeFqZ ?? IntPtr.Zero));
		}
		pERSibQDMTkaGVsXRncSUqChDMi2.cdqTgbSfyrEqXWYCQoRGOzwgRtI();
	}

	[DllImport("Rewired_DirectInput", CallingConvention = CallingConvention.StdCall, EntryPoint = "DirectInput8_Create")]
	[SuppressUnmanagedCodeSecurity]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int SAgQxeguYhHAecqXbtuCJmCfGiA(void* P_0, int P_1, void* P_2, void* P_3, void* P_4);
}
