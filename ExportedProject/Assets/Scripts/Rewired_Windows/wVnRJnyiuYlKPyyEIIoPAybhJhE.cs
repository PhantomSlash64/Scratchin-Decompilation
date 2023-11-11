using System;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Attributes;

internal class wVnRJnyiuYlKPyyEIIoPAybhJhE : IDisposable
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private delegate IntPtr DzcXiZAHeaWWqIENvzxbIgHvKer(int nCode, IntPtr wParam, IntPtr lParam);

	private struct EamnlpvrjobCyaFQOcLOXFzMVQz
	{
		public IntPtr IlSVQuqNjaGPPEUnjdUJJaWKHTUg;

		public IntPtr PgHOOnMUEhWGgmIwxJgwmGLckBT;

		public uint TbHOmadeYmLAlXzdxIdWeNkQyMp;

		public IntPtr fwfsqRASrVKrIMKKkqIuIRsQMyF;
	}

	private const int QYLVbakDLJUjwSjRbksIUcoTDn = 4;

	private static wVnRJnyiuYlKPyyEIIoPAybhJhE yxEargcGpwGXSygjnGUBSVmDyak;

	private IntPtr WRjwQoEBCypxtnurCBnuJDbWERP = IntPtr.Zero;

	private DzcXiZAHeaWWqIENvzxbIgHvKer FInqVWtEcpkegQAhNEgfUrHaDNB;

	private Action<hHVvumcFWVnIPBjOpTYVHDXWFQL, EewfJPiHasEmIcMTTMpQEfUhPRej, uint, IntPtr> dUrEnukSITVqvwdrRKdMBfaXKjgG;

	private byte[] sHxFvhhkTOHUOMNIjqlFgGYzuss;

	private readonly bool LpsjFyrXcHAUWGqNyeCIJGJhsQmd;

	private EamnlpvrjobCyaFQOcLOXFzMVQz gLxJwGikSDOtxlchFKYmbuzyJeI;

	private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

	public wVnRJnyiuYlKPyyEIIoPAybhJhE()
	{
		if (yxEargcGpwGXSygjnGUBSVmDyak != null)
		{
			throw new Exception("Singleton instance already exists!");
		}
		yxEargcGpwGXSygjnGUBSVmDyak = this;
		LpsjFyrXcHAUWGqNyeCIJGJhsQmd = IntPtr.Size == 8;
		sHxFvhhkTOHUOMNIjqlFgGYzuss = new byte[IntPtr.Size * 3 + 4];
	}

	public void kkiYOBQaAWTBmwGqCopYrgEejsVa(Action<hHVvumcFWVnIPBjOpTYVHDXWFQL, EewfJPiHasEmIcMTTMpQEfUhPRej, uint, IntPtr> P_0, bool P_1)
	{
		dUrEnukSITVqvwdrRKdMBfaXKjgG = P_0;
		FInqVWtEcpkegQAhNEgfUrHaDNB = pxAgRpOSgffGQNzUoFcegisHwRw;
		uint num = 0u;
		if (P_1)
		{
			num = (uint)AppDomain.GetCurrentThreadId();
		}
		WRjwQoEBCypxtnurCBnuJDbWERP = RglxaMIopmQbcvCEkbnHVxbAWus(4, FInqVWtEcpkegQAhNEgfUrHaDNB, IntPtr.Zero, num);
		if (WRjwQoEBCypxtnurCBnuJDbWERP == IntPtr.Zero)
		{
			Logger.LogError("SetWindowsHookEx Failed");
		}
	}

	public void djfUFhOEPYClAtpmeFdYNGGaFyM()
	{
		if (!(WRjwQoEBCypxtnurCBnuJDbWERP == IntPtr.Zero))
		{
			if (!SdQcSxfyJXdmNdkppUqOaDyhpDvC(WRjwQoEBCypxtnurCBnuJDbWERP))
			{
				Logger.LogError("UnhookWindowsHookEx Failed");
			}
			else
			{
				WRjwQoEBCypxtnurCBnuJDbWERP = IntPtr.Zero;
			}
		}
	}

	[MonoPInvokeCallback(typeof(DzcXiZAHeaWWqIENvzxbIgHvKer))]
	private static IntPtr pxAgRpOSgffGQNzUoFcegisHwRw(int P_0, IntPtr P_1, IntPtr P_2)
	{
		Marshal.Copy(P_2, yxEargcGpwGXSygjnGUBSVmDyak.sHxFvhhkTOHUOMNIjqlFgGYzuss, 0, yxEargcGpwGXSygjnGUBSVmDyak.sHxFvhhkTOHUOMNIjqlFgGYzuss.Length);
		int num = 0;
		yxEargcGpwGXSygjnGUBSVmDyak.gLxJwGikSDOtxlchFKYmbuzyJeI.IlSVQuqNjaGPPEUnjdUJJaWKHTUg = hHVvumcFWVnIPBjOpTYVHDXWFQL.FKTvkTXpHkegMjnoXwkHeuiNnfsp(yxEargcGpwGXSygjnGUBSVmDyak.sHxFvhhkTOHUOMNIjqlFgGYzuss, num);
		num += hHVvumcFWVnIPBjOpTYVHDXWFQL.fnXDHADGAIKLXUikmwkYcfoOkMJD;
		yxEargcGpwGXSygjnGUBSVmDyak.gLxJwGikSDOtxlchFKYmbuzyJeI.PgHOOnMUEhWGgmIwxJgwmGLckBT = EewfJPiHasEmIcMTTMpQEfUhPRej.FKTvkTXpHkegMjnoXwkHeuiNnfsp(yxEargcGpwGXSygjnGUBSVmDyak.sHxFvhhkTOHUOMNIjqlFgGYzuss, num);
		num += EewfJPiHasEmIcMTTMpQEfUhPRej.fnXDHADGAIKLXUikmwkYcfoOkMJD;
		yxEargcGpwGXSygjnGUBSVmDyak.gLxJwGikSDOtxlchFKYmbuzyJeI.TbHOmadeYmLAlXzdxIdWeNkQyMp = BitConverter.ToUInt32(yxEargcGpwGXSygjnGUBSVmDyak.sHxFvhhkTOHUOMNIjqlFgGYzuss, num);
		num += 4;
		if (yxEargcGpwGXSygjnGUBSVmDyak.LpsjFyrXcHAUWGqNyeCIJGJhsQmd)
		{
			yxEargcGpwGXSygjnGUBSVmDyak.gLxJwGikSDOtxlchFKYmbuzyJeI.fwfsqRASrVKrIMKKkqIuIRsQMyF = new IntPtr(BitConverter.ToInt32(yxEargcGpwGXSygjnGUBSVmDyak.sHxFvhhkTOHUOMNIjqlFgGYzuss, num + 4));
		}
		else
		{
			yxEargcGpwGXSygjnGUBSVmDyak.gLxJwGikSDOtxlchFKYmbuzyJeI.fwfsqRASrVKrIMKKkqIuIRsQMyF = new IntPtr(BitConverter.ToInt32(yxEargcGpwGXSygjnGUBSVmDyak.sHxFvhhkTOHUOMNIjqlFgGYzuss, num));
		}
		if (P_0 >= 0)
		{
			yxEargcGpwGXSygjnGUBSVmDyak.dUrEnukSITVqvwdrRKdMBfaXKjgG(yxEargcGpwGXSygjnGUBSVmDyak.gLxJwGikSDOtxlchFKYmbuzyJeI.IlSVQuqNjaGPPEUnjdUJJaWKHTUg, yxEargcGpwGXSygjnGUBSVmDyak.gLxJwGikSDOtxlchFKYmbuzyJeI.PgHOOnMUEhWGgmIwxJgwmGLckBT, yxEargcGpwGXSygjnGUBSVmDyak.gLxJwGikSDOtxlchFKYmbuzyJeI.TbHOmadeYmLAlXzdxIdWeNkQyMp, yxEargcGpwGXSygjnGUBSVmDyak.gLxJwGikSDOtxlchFKYmbuzyJeI.fwfsqRASrVKrIMKKkqIuIRsQMyF);
		}
		return vKhuIDcbpUUZnrdteBWatfGYiPOc(yxEargcGpwGXSygjnGUBSVmDyak.WRjwQoEBCypxtnurCBnuJDbWERP, P_0, P_1, P_2);
	}

	public void Dispose()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
		GC.SuppressFinalize(this);
	}

	~wVnRJnyiuYlKPyyEIIoPAybhJhE()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
	}

	protected virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (!jpnIPbpqmlecdiNqaFAxiNCsiMxs)
		{
			djfUFhOEPYClAtpmeFdYNGGaFyM();
			if (yxEargcGpwGXSygjnGUBSVmDyak == this)
			{
				yxEargcGpwGXSygjnGUBSVmDyak = null;
			}
			jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
		}
	}

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, EntryPoint = "SetWindowsHookEx")]
	private static extern IntPtr RglxaMIopmQbcvCEkbnHVxbAWus(int P_0, DzcXiZAHeaWWqIENvzxbIgHvKer P_1, IntPtr P_2, uint P_3);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, EntryPoint = "UnhookWindowsHookEx")]
	private static extern bool SdQcSxfyJXdmNdkppUqOaDyhpDvC(IntPtr P_0);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, EntryPoint = "CallNextHookEx")]
	private static extern IntPtr vKhuIDcbpUUZnrdteBWatfGYiPOc(IntPtr P_0, int P_1, IntPtr P_2, IntPtr P_3);
}
