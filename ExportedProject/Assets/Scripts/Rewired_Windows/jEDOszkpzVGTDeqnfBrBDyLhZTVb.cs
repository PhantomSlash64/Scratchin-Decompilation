using System;
using System.Runtime.InteropServices;

internal class jEDOszkpzVGTDeqnfBrBDyLhZTVb : IDisposable
{
	internal enum izEZbUIwsNUjsbbPPBSgdGyswhwv
	{
		aCVtGGLpRhphxEagrZJNGKhIoVf = 0,
		rKCopvwvfssSrhuKEWPNSGbNUIU = 1
	}

	private delegate IntPtr qnjvZcCdRrugsYAJMIYBrpPWFMX(int nCode, IntPtr wParam, IntPtr lParam);

	private const int QYLVbakDLJUjwSjRbksIUcoTDn = 4;

	private IntPtr WRjwQoEBCypxtnurCBnuJDbWERP = IntPtr.Zero;

	private qnjvZcCdRrugsYAJMIYBrpPWFMX FInqVWtEcpkegQAhNEgfUrHaDNB;

	private Action<IntPtr, IntPtr, uint, uint> dUrEnukSITVqvwdrRKdMBfaXKjgG;

	private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

	public void kkiYOBQaAWTBmwGqCopYrgEejsVa(Action<IntPtr, IntPtr, uint, uint> P_0, izEZbUIwsNUjsbbPPBSgdGyswhwv P_1)
	{
		dUrEnukSITVqvwdrRKdMBfaXKjgG = P_0;
		FInqVWtEcpkegQAhNEgfUrHaDNB = pxAgRpOSgffGQNzUoFcegisHwRw;
		uint num = 0u;
		if (P_1 == izEZbUIwsNUjsbbPPBSgdGyswhwv.aCVtGGLpRhphxEagrZJNGKhIoVf)
		{
			num = (uint)AppDomain.GetCurrentThreadId();
		}
		WRjwQoEBCypxtnurCBnuJDbWERP = RglxaMIopmQbcvCEkbnHVxbAWus(4, FInqVWtEcpkegQAhNEgfUrHaDNB, IntPtr.Zero, num);
		_ = WRjwQoEBCypxtnurCBnuJDbWERP == IntPtr.Zero;
	}

	public void djfUFhOEPYClAtpmeFdYNGGaFyM()
	{
		if (!(WRjwQoEBCypxtnurCBnuJDbWERP == IntPtr.Zero) && SdQcSxfyJXdmNdkppUqOaDyhpDvC(WRjwQoEBCypxtnurCBnuJDbWERP))
		{
			WRjwQoEBCypxtnurCBnuJDbWERP = IntPtr.Zero;
		}
	}

	private IntPtr pxAgRpOSgffGQNzUoFcegisHwRw(int P_0, IntPtr P_1, IntPtr P_2)
	{
		if (P_0 >= 0)
		{
			int num = 0;
			IntPtr arg = Marshal.ReadIntPtr(P_2, num);
			num += IntPtr.Size;
			IntPtr arg2 = Marshal.ReadIntPtr(P_2, num);
			num += IntPtr.Size;
			uint arg3 = (uint)Marshal.ReadInt32(P_2, num);
			num += 4;
			if (IntPtr.Size == 8)
			{
				num += 4;
			}
			uint arg4 = (uint)Marshal.ReadInt32(P_2, num);
			dUrEnukSITVqvwdrRKdMBfaXKjgG(arg, arg2, arg3, arg4);
		}
		return vKhuIDcbpUUZnrdteBWatfGYiPOc(WRjwQoEBCypxtnurCBnuJDbWERP, P_0, P_1, P_2);
	}

	public void Dispose()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
		GC.SuppressFinalize(this);
	}

	~jEDOszkpzVGTDeqnfBrBDyLhZTVb()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
	}

	protected virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (!jpnIPbpqmlecdiNqaFAxiNCsiMxs)
		{
			djfUFhOEPYClAtpmeFdYNGGaFyM();
			jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
		}
	}

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "SetWindowsHookEx")]
	private static extern IntPtr RglxaMIopmQbcvCEkbnHVxbAWus(int P_0, qnjvZcCdRrugsYAJMIYBrpPWFMX P_1, IntPtr P_2, uint P_3);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "UnhookWindowsHookEx")]
	private static extern bool SdQcSxfyJXdmNdkppUqOaDyhpDvC(IntPtr P_0);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "CallNextHookEx")]
	private static extern IntPtr vKhuIDcbpUUZnrdteBWatfGYiPOc(IntPtr P_0, int P_1, IntPtr P_2, IntPtr P_3);
}
