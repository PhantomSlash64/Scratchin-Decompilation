using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired;
using Rewired.Utils;
using Rewired.Utils.Classes.Utility;

internal class AtWzeFDeJXySvfbjfVuVMcsdsws : IDisposable
{
	private class kmicEZiyPWegvUXLILRvtBTSRiWd
	{
		public int nNFdeQcSfQgIQzwwSmqEoIqOmxtA;

		public int ennUaNXGzFdNTPUKCLPLQGDndiK;

		public uint jehinppHZvgWRiPBdJtxgECTktu;

		public object ZFYTDmLaIDanwzCPbVlYfRoHXgg;

		public void vAhUQyfIrMhjhGAJbutJOWoJXiD(int P_0, int P_1, uint P_2, object P_3)
		{
			nNFdeQcSfQgIQzwwSmqEoIqOmxtA = P_0;
			ennUaNXGzFdNTPUKCLPLQGDndiK = P_1;
			jehinppHZvgWRiPBdJtxgECTktu = P_2;
			ZFYTDmLaIDanwzCPbVlYfRoHXgg = P_3;
		}

		public void xZveeqhZWQBoifJNrEKvhlbeSAk()
		{
			ZFYTDmLaIDanwzCPbVlYfRoHXgg = null;
		}
	}

	private FcNgynHxpiyclOjUfyqdKozPYKY RBtRonCEgaNDwiemTOAXtCdIbNk;

	private ObjectPool<kmicEZiyPWegvUXLILRvtBTSRiWd> ysUtDyIXYCibdWXFtchaLPRlSTo;

	private Queue<kmicEZiyPWegvUXLILRvtBTSRiWd> ZXwpShCnmkEoaItWDVNNDTXjJhp;

	private Action<object> AcpMxshSyXqJkArLPELJBuoxRRa;

	private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

	[CompilerGenerated]
	private static Func<kmicEZiyPWegvUXLILRvtBTSRiWd> KjXFpHJudMmlzoNcFAqMfxLtWKZ;

	[CompilerGenerated]
	private static Action<kmicEZiyPWegvUXLILRvtBTSRiWd> GSkjvabdYbjwibbLFvKkupJEjbT;

	public bool gPaUdCEqMoTpuutyhkonXtLsaUT => wKArdUsbGnGvTzBHPTZzCYBnnUL();

	public AtWzeFDeJXySvfbjfVuVMcsdsws(int byteCapacity, int startingQueueSize, Action<object> lostCustomDataDisposalDelegate = null)
	{
		if (byteCapacity <= 0)
		{
			throw new ArgumentOutOfRangeException("capacity");
		}
		RBtRonCEgaNDwiemTOAXtCdIbNk = new FcNgynHxpiyclOjUfyqdKozPYKY(byteCapacity);
		ysUtDyIXYCibdWXFtchaLPRlSTo = new ObjectPool<kmicEZiyPWegvUXLILRvtBTSRiWd>(startingQueueSize, () => new kmicEZiyPWegvUXLILRvtBTSRiWd(), delegate(kmicEZiyPWegvUXLILRvtBTSRiWd P_0)
		{
			P_0.xZveeqhZWQBoifJNrEKvhlbeSAk();
		});
		ZXwpShCnmkEoaItWDVNNDTXjJhp = new Queue<kmicEZiyPWegvUXLILRvtBTSRiWd>(startingQueueSize);
		AcpMxshSyXqJkArLPELJBuoxRRa = lostCustomDataDisposalDelegate;
	}

	public unsafe bool UBdDYFzJEaQOUTjUSMwjsblQggo(byte* P_0, int P_1, object P_2)
	{
		if (P_0 == null || P_1 <= 0)
		{
			return false;
		}
		int num;
		uint num2;
		int num3 = RBtRonCEgaNDwiemTOAXtCdIbNk.klxMdkMazIUJPUlFFCZeFKzabgc(P_0, P_1, P_1, out num, out num2);
		if (num3 < P_1)
		{
			return false;
		}
		kmicEZiyPWegvUXLILRvtBTSRiWd kmicEZiyPWegvUXLILRvtBTSRiWd = ysUtDyIXYCibdWXFtchaLPRlSTo.Get();
		kmicEZiyPWegvUXLILRvtBTSRiWd.vAhUQyfIrMhjhGAJbutJOWoJXiD(num, P_1, num2, P_2);
		ZXwpShCnmkEoaItWDVNNDTXjJhp.Enqueue(kmicEZiyPWegvUXLILRvtBTSRiWd);
		return true;
	}

	public unsafe bool UBdDYFzJEaQOUTjUSMwjsblQggo(byte* P_0, int P_1)
	{
		return UBdDYFzJEaQOUTjUSMwjsblQggo(P_0, P_1, null);
	}

	public unsafe bool UBdDYFzJEaQOUTjUSMwjsblQggo(IntPtr P_0, int P_1, object P_2)
	{
		if (P_0 == IntPtr.Zero || P_1 <= 0)
		{
			return false;
		}
		return UBdDYFzJEaQOUTjUSMwjsblQggo((byte*)(void*)P_0, P_1, P_2);
	}

	public bool UBdDYFzJEaQOUTjUSMwjsblQggo(IntPtr P_0, int P_1)
	{
		return UBdDYFzJEaQOUTjUSMwjsblQggo(P_0, P_1, null);
	}

	public unsafe bool UBdDYFzJEaQOUTjUSMwjsblQggo(byte[] P_0, int P_1, object P_2, int P_3 = 0)
	{
		if (P_0 == null || P_1 > P_0.Length)
		{
			return false;
		}
		if (P_3 < 0)
		{
			P_3 = 0;
		}
		if (P_3 + P_1 > P_0.Length)
		{
			return false;
		}
		fixed (byte* ptr = P_0)
		{
			byte* ptr2 = ptr + P_3;
			return UBdDYFzJEaQOUTjUSMwjsblQggo(ptr2, P_1, P_2);
		}
	}

	public bool UBdDYFzJEaQOUTjUSMwjsblQggo(byte[] P_0, int P_1, int P_2 = 0)
	{
		return UBdDYFzJEaQOUTjUSMwjsblQggo(P_0, P_1, null, P_2);
	}

	public unsafe int ntZwQNpVRkPalRpoVEyccOCNlSAG(byte* P_0, int P_1, out object P_2)
	{
		if (P_0 == null || P_1 <= 0)
		{
			P_2 = null;
			return -1;
		}
		kmicEZiyPWegvUXLILRvtBTSRiWd kmicEZiyPWegvUXLILRvtBTSRiWd = DbLSWFlaQhtUVxDjCAObIotbpqWE(false);
		if (kmicEZiyPWegvUXLILRvtBTSRiWd == null)
		{
			P_2 = null;
			return -1;
		}
		if (P_1 < kmicEZiyPWegvUXLILRvtBTSRiWd.ennUaNXGzFdNTPUKCLPLQGDndiK)
		{
			Logger.LogError("The buffer is too small to hold the data. Call PeekDataLength before calling Peek to get the data length.", requiredThreadSafety: true);
			P_2 = null;
			return -1;
		}
		int num = RBtRonCEgaNDwiemTOAXtCdIbNk.oIBQWQNeHdWkwYHSjniHXFyBSmx(P_0, P_1, kmicEZiyPWegvUXLILRvtBTSRiWd.ennUaNXGzFdNTPUKCLPLQGDndiK, kmicEZiyPWegvUXLILRvtBTSRiWd.nNFdeQcSfQgIQzwwSmqEoIqOmxtA);
		if (num != kmicEZiyPWegvUXLILRvtBTSRiWd.ennUaNXGzFdNTPUKCLPLQGDndiK)
		{
			Logger.LogError("Failure reading data from buffer!", requiredThreadSafety: true);
			num = 0;
			P_2 = null;
			return -1;
		}
		P_2 = kmicEZiyPWegvUXLILRvtBTSRiWd.ZFYTDmLaIDanwzCPbVlYfRoHXgg;
		return num;
	}

	public unsafe int ntZwQNpVRkPalRpoVEyccOCNlSAG(byte* P_0, int P_1)
	{
		object obj;
		return ntZwQNpVRkPalRpoVEyccOCNlSAG(P_0, P_1, out obj);
	}

	public unsafe int ntZwQNpVRkPalRpoVEyccOCNlSAG(IntPtr P_0, int P_1, out object P_2)
	{
		if (P_0 == IntPtr.Zero || P_1 <= 0)
		{
			P_2 = null;
			return -1;
		}
		return ntZwQNpVRkPalRpoVEyccOCNlSAG((byte*)(void*)P_0, P_1, out P_2);
	}

	public int ntZwQNpVRkPalRpoVEyccOCNlSAG(IntPtr P_0, int P_1)
	{
		object obj;
		return ntZwQNpVRkPalRpoVEyccOCNlSAG(P_0, P_1, out obj);
	}

	public unsafe int ntZwQNpVRkPalRpoVEyccOCNlSAG(byte[] P_0, out object P_1)
	{
		if (P_0 == null || P_0.Length == 0)
		{
			P_1 = null;
			return -1;
		}
		fixed (byte* ptr = P_0)
		{
			return ntZwQNpVRkPalRpoVEyccOCNlSAG(ptr, P_0.Length, out P_1);
		}
	}

	public int ntZwQNpVRkPalRpoVEyccOCNlSAG(byte[] P_0)
	{
		object obj;
		return ntZwQNpVRkPalRpoVEyccOCNlSAG(P_0, out obj);
	}

	public int EPXumFaNTNvjYTORTeKsnirDTSj()
	{
		return DbLSWFlaQhtUVxDjCAObIotbpqWE(false)?.ennUaNXGzFdNTPUKCLPLQGDndiK ?? (-1);
	}

	public unsafe int FcuIHKhvqfnJXBTZoTtogAGOfyB(byte* P_0, int P_1, out object P_2)
	{
		if (P_0 == null || P_1 <= 0)
		{
			P_2 = null;
			return -1;
		}
		kmicEZiyPWegvUXLILRvtBTSRiWd kmicEZiyPWegvUXLILRvtBTSRiWd = DbLSWFlaQhtUVxDjCAObIotbpqWE(true);
		if (kmicEZiyPWegvUXLILRvtBTSRiWd == null)
		{
			P_2 = null;
			return -1;
		}
		if (P_1 < kmicEZiyPWegvUXLILRvtBTSRiWd.ennUaNXGzFdNTPUKCLPLQGDndiK)
		{
			Logger.LogError("The buffer is too small to hold the data. Call PeekDataLength before calling Dequeue to get the data length.", requiredThreadSafety: true);
			P_2 = null;
			etpuGOgeYbSvlxvAxMSfIiBlhgJ(kmicEZiyPWegvUXLILRvtBTSRiWd, true);
			return -1;
		}
		int num = RBtRonCEgaNDwiemTOAXtCdIbNk.oIBQWQNeHdWkwYHSjniHXFyBSmx(P_0, P_1, kmicEZiyPWegvUXLILRvtBTSRiWd.ennUaNXGzFdNTPUKCLPLQGDndiK, kmicEZiyPWegvUXLILRvtBTSRiWd.nNFdeQcSfQgIQzwwSmqEoIqOmxtA);
		if (num != kmicEZiyPWegvUXLILRvtBTSRiWd.ennUaNXGzFdNTPUKCLPLQGDndiK)
		{
			Logger.LogError("Failure reading data from buffer!", requiredThreadSafety: true);
			P_2 = null;
			etpuGOgeYbSvlxvAxMSfIiBlhgJ(kmicEZiyPWegvUXLILRvtBTSRiWd, true);
			return -1;
		}
		P_2 = kmicEZiyPWegvUXLILRvtBTSRiWd.ZFYTDmLaIDanwzCPbVlYfRoHXgg;
		etpuGOgeYbSvlxvAxMSfIiBlhgJ(kmicEZiyPWegvUXLILRvtBTSRiWd, false);
		return num;
	}

	public unsafe int FcuIHKhvqfnJXBTZoTtogAGOfyB(byte* P_0, int P_1)
	{
		object obj;
		return FcuIHKhvqfnJXBTZoTtogAGOfyB(P_0, P_1, out obj);
	}

	public unsafe int FcuIHKhvqfnJXBTZoTtogAGOfyB(IntPtr P_0, int P_1, out object P_2)
	{
		if (P_0 == IntPtr.Zero || P_1 <= 0)
		{
			P_2 = null;
			return -1;
		}
		return FcuIHKhvqfnJXBTZoTtogAGOfyB((byte*)(void*)P_0, P_1, out P_2);
	}

	public int FcuIHKhvqfnJXBTZoTtogAGOfyB(IntPtr P_0, int P_1)
	{
		object obj;
		return FcuIHKhvqfnJXBTZoTtogAGOfyB(P_0, P_1, out obj);
	}

	public unsafe int FcuIHKhvqfnJXBTZoTtogAGOfyB(byte[] P_0, out object P_1)
	{
		if (P_0 == null || P_0.Length == 0)
		{
			P_1 = null;
			return -1;
		}
		fixed (byte* ptr = P_0)
		{
			return FcuIHKhvqfnJXBTZoTtogAGOfyB(ptr, P_0.Length, out P_1);
		}
	}

	public int FcuIHKhvqfnJXBTZoTtogAGOfyB(byte[] P_0)
	{
		object obj;
		return FcuIHKhvqfnJXBTZoTtogAGOfyB(P_0, out obj);
	}

	public void UbHHPMhQuOGmtxkgszeCFVvzcjF()
	{
		RBtRonCEgaNDwiemTOAXtCdIbNk.UbHHPMhQuOGmtxkgszeCFVvzcjF();
		while (ZXwpShCnmkEoaItWDVNNDTXjJhp.Count > 0)
		{
			etpuGOgeYbSvlxvAxMSfIiBlhgJ(ZXwpShCnmkEoaItWDVNNDTXjJhp.Dequeue(), true);
		}
	}

	private kmicEZiyPWegvUXLILRvtBTSRiWd DbLSWFlaQhtUVxDjCAObIotbpqWE(bool P_0)
	{
		while (ZXwpShCnmkEoaItWDVNNDTXjJhp.Count > 0)
		{
			kmicEZiyPWegvUXLILRvtBTSRiWd kmicEZiyPWegvUXLILRvtBTSRiWd = (P_0 ? ZXwpShCnmkEoaItWDVNNDTXjJhp.Dequeue() : ZXwpShCnmkEoaItWDVNNDTXjJhp.Peek());
			if (RBtRonCEgaNDwiemTOAXtCdIbNk.jYuOzlJtihpWwRTDsuTZYrbfQmE(kmicEZiyPWegvUXLILRvtBTSRiWd.nNFdeQcSfQgIQzwwSmqEoIqOmxtA, kmicEZiyPWegvUXLILRvtBTSRiWd.jehinppHZvgWRiPBdJtxgECTktu))
			{
				return kmicEZiyPWegvUXLILRvtBTSRiWd;
			}
			if (!P_0)
			{
				kmicEZiyPWegvUXLILRvtBTSRiWd = ZXwpShCnmkEoaItWDVNNDTXjJhp.Dequeue();
			}
			etpuGOgeYbSvlxvAxMSfIiBlhgJ(kmicEZiyPWegvUXLILRvtBTSRiWd, true);
		}
		return null;
	}

	private bool wKArdUsbGnGvTzBHPTZzCYBnnUL()
	{
		return DbLSWFlaQhtUVxDjCAObIotbpqWE(false) != null;
	}

	private void etpuGOgeYbSvlxvAxMSfIiBlhgJ(kmicEZiyPWegvUXLILRvtBTSRiWd P_0, bool P_1)
	{
		if (P_0 != null)
		{
			if (P_1 && AcpMxshSyXqJkArLPELJBuoxRRa != null && P_0.ZFYTDmLaIDanwzCPbVlYfRoHXgg != null)
			{
				AcpMxshSyXqJkArLPELJBuoxRRa(P_0.ZFYTDmLaIDanwzCPbVlYfRoHXgg);
			}
			ysUtDyIXYCibdWXFtchaLPRlSTo.Return(P_0);
		}
	}

	public void Dispose()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
		GC.SuppressFinalize(this);
	}

	~AtWzeFDeJXySvfbjfVuVMcsdsws()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
	}

	protected void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (jpnIPbpqmlecdiNqaFAxiNCsiMxs)
		{
			return;
		}
		if (P_0)
		{
			UbHHPMhQuOGmtxkgszeCFVvzcjF();
			if (RBtRonCEgaNDwiemTOAXtCdIbNk != null)
			{
				RBtRonCEgaNDwiemTOAXtCdIbNk.Dispose();
			}
		}
		jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
	}

	public static bool sJkRUBQjRdakSISEcicEyxzszmjU(AtWzeFDeJXySvfbjfVuVMcsdsws P_0, AtWzeFDeJXySvfbjfVuVMcsdsws P_1)
	{
		if (P_0 == null || P_1 == null)
		{
			return false;
		}
		MiscTools.Swap(ref P_0.RBtRonCEgaNDwiemTOAXtCdIbNk, ref P_1.RBtRonCEgaNDwiemTOAXtCdIbNk);
		MiscTools.Swap(ref P_0.ysUtDyIXYCibdWXFtchaLPRlSTo, ref P_1.ysUtDyIXYCibdWXFtchaLPRlSTo);
		MiscTools.Swap(ref P_0.ZXwpShCnmkEoaItWDVNNDTXjJhp, ref P_1.ZXwpShCnmkEoaItWDVNNDTXjJhp);
		return true;
	}

	[CompilerGenerated]
	private static kmicEZiyPWegvUXLILRvtBTSRiWd tcgScBHSvhAwmZLQkvcKfRWuwzj()
	{
		return new kmicEZiyPWegvUXLILRvtBTSRiWd();
	}

	[CompilerGenerated]
	private static void blTvbViyrmgxnuDqBHykMzGugTI(kmicEZiyPWegvUXLILRvtBTSRiWd P_0)
	{
		P_0.xZveeqhZWQBoifJNrEKvhlbeSAk();
	}
}
