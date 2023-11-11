using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

internal static class cZEAfFusPwtBncvnGcfLrVnBtky
{
	public unsafe static int BltnqxmiIvdSyCqPYnANAHSIvHzq(XejzeUvgutfbSkwWeQaFpJwCZEW[] P_0, ref int P_1, int P_2)
	{
		int result;
		fixed (IntPtr* ptr = P_0)
		{
			fixed (IntPtr* ptr2 = &System.Runtime.CompilerServices.Unsafe.As<int, IntPtr>(ref P_1))
			{
				result = ogbiARqeTKzFjgiGqPriiwnkdeO(ptr, ptr2, P_2);
			}
		}
		return result;
	}

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "GetRawInputDeviceList")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int ogbiARqeTKzFjgiGqPriiwnkdeO(void* P_0, void* P_1, int P_2);

	public unsafe static int jbFEuENbVgmYUSpSznqKLhZMxXB(PeMGMZlAhscarKIvLgYFgdnrHXxt[] P_0, ref int P_1, int P_2)
	{
		int result;
		fixed (IntPtr* ptr = P_0)
		{
			fixed (IntPtr* ptr2 = &System.Runtime.CompilerServices.Unsafe.As<int, IntPtr>(ref P_1))
			{
				result = MrGdpDDNhGskfYvIXRYFDkaCejB(ptr, ptr2, P_2);
			}
		}
		return result;
	}

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "GetRegisteredRawInputDevices")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int MrGdpDDNhGskfYvIXRYFDkaCejB(void* P_0, void* P_1, int P_2);

	public unsafe static int hjcQwblPdzEbaTqLtBnrbTrCilj(IntPtr P_0, lpgIqBFTWuIztCWtjjIgfcnwVpA P_1, IntPtr P_2, ref int P_3)
	{
		int result;
		fixed (IntPtr* ptr = &System.Runtime.CompilerServices.Unsafe.As<int, IntPtr>(ref P_3))
		{
			result = rSEYSpTcSGzstkAHtPoTMPJqqEE((void*)P_0, (int)P_1, (void*)P_2, ptr);
		}
		return result;
	}

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "GetRawInputDeviceInfoW")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int rSEYSpTcSGzstkAHtPoTMPJqqEE(void* P_0, int P_1, void* P_2, void* P_3);

	public unsafe static dPPahGKYiKvHsQXyXuviFuLVknZL gmzeXFIHMSFAmcuWLaLdGUEIMEd(PeMGMZlAhscarKIvLgYFgdnrHXxt[] P_0, int P_1, int P_2)
	{
		dPPahGKYiKvHsQXyXuviFuLVknZL result;
		fixed (IntPtr* ptr = P_0)
		{
			result = DvdoskNLyLnNCxKvTUlhJvNhmeo(ptr, P_1, P_2);
		}
		return result;
	}

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "RegisterRawInputDevices")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern dPPahGKYiKvHsQXyXuviFuLVknZL DvdoskNLyLnNCxKvTUlhJvNhmeo(void* P_0, int P_1, int P_2);

	public unsafe static int BBKFLkWPzNSJyHqazeZelPtSTqg(lOjRmNhcRhwonUCOQXiLfgRvAbT[] P_0, ref int P_1, int P_2)
	{
		int result;
		fixed (IntPtr* ptr = P_0)
		{
			fixed (IntPtr* ptr2 = &System.Runtime.CompilerServices.Unsafe.As<int, IntPtr>(ref P_1))
			{
				result = njzbZvnowdoBeRGoMenYKeBPUZY(ptr, ptr2, P_2);
			}
		}
		return result;
	}

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "GetRawInputBuffer")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int njzbZvnowdoBeRGoMenYKeBPUZY(void* P_0, void* P_1, int P_2);

	public unsafe static int oDlzLWyoHhBFXoZknryyuHsAFHy(IntPtr P_0, gvVCzqztFUYVppmWLPrjTZfMdMq P_1, IntPtr P_2, ref int P_3, int P_4)
	{
		int result;
		fixed (IntPtr* ptr = &System.Runtime.CompilerServices.Unsafe.As<int, IntPtr>(ref P_3))
		{
			result = YKEpSqkJslDsFKezzKnugtdbVltI((void*)P_0, (int)P_1, (void*)P_2, ptr, P_4);
		}
		return result;
	}

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "GetRawInputData")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int YKEpSqkJslDsFKezzKnugtdbVltI(void* P_0, int P_1, void* P_2, void* P_3, int P_4);
}
