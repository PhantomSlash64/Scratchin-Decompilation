using System;
using Rewired.Utils;

internal class FcNgynHxpiyclOjUfyqdKozPYKY : IDisposable
{
	private readonly ONekLqHMuFNjUEgkbJeXaixhKbtZ RBtRonCEgaNDwiemTOAXtCdIbNk;

	private readonly int LuchvTBkdZMBSkHJLiuqFzaAUOcK;

	private long qVMumYliTxEbhDvuWouZzVpilfr;

	private long jXIenjkEruNJzfLtcugShQgMZQMm;

	private int zWxYYZHxNQWHXNHmCvpyfCmiFZa;

	private bool BRmuoyXmYVmmOSMdixDlTdUQCzH;

	private uint YSiBWocJJPKtAmZfddcvodBUErcm;

	private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

	public int ODYXRUaxHAtpXyCShfMqORrqAQG => LuchvTBkdZMBSkHJLiuqFzaAUOcK;

	public int pVduZnSLMTsKKyqOoXgzfynUYLv => zWxYYZHxNQWHXNHmCvpyfCmiFZa;

	public bool gYXMyJHIHlExxpCNHxiHLFhXKGZ => BRmuoyXmYVmmOSMdixDlTdUQCzH;

	public FcNgynHxpiyclOjUfyqdKozPYKY(int capacity)
	{
		LuchvTBkdZMBSkHJLiuqFzaAUOcK = capacity;
		if (capacity <= 0)
		{
			throw new ArgumentOutOfRangeException("sizeInBytes");
		}
		RBtRonCEgaNDwiemTOAXtCdIbNk = new ONekLqHMuFNjUEgkbJeXaixhKbtZ(capacity);
	}

	public unsafe int klxMdkMazIUJPUlFFCZeFKzabgc(byte* P_0, int P_1, int P_2, out int P_3, out uint P_4)
	{
		P_3 = (int)qVMumYliTxEbhDvuWouZzVpilfr;
		P_4 = YSiBWocJJPKtAmZfddcvodBUErcm;
		if (P_0 == null || P_1 <= 0 || P_2 <= 0)
		{
			return 0;
		}
		if (P_2 > P_1)
		{
			P_2 = P_1;
		}
		int num = RBtRonCEgaNDwiemTOAXtCdIbNk.ogtAcQGaIHtxEbgvVwyqUNboON(P_0, P_1, P_2, (int)qVMumYliTxEbhDvuWouZzVpilfr);
		if (num == 0)
		{
			return 0;
		}
		if (num < P_2)
		{
			num += RBtRonCEgaNDwiemTOAXtCdIbNk.ogtAcQGaIHtxEbgvVwyqUNboON(P_0 + num, P_1 - num, P_2 - num);
		}
		FIchBYeeVpCInMVumDXKcZyvDrj(num);
		return num;
	}

	public unsafe int klxMdkMazIUJPUlFFCZeFKzabgc(IntPtr P_0, int P_1, int P_2, out int P_3, out uint P_4)
	{
		if (P_0 == IntPtr.Zero || P_1 <= 0 || P_2 <= 0)
		{
			P_3 = (int)qVMumYliTxEbhDvuWouZzVpilfr;
			P_4 = YSiBWocJJPKtAmZfddcvodBUErcm;
			return 0;
		}
		return klxMdkMazIUJPUlFFCZeFKzabgc((byte*)(void*)P_0, P_1, P_2, out P_3, out P_4);
	}

	public unsafe int klxMdkMazIUJPUlFFCZeFKzabgc(byte[] P_0, int P_1, out int P_2, out uint P_3)
	{
		if (P_0 == null || P_1 <= 0)
		{
			P_2 = (int)qVMumYliTxEbhDvuWouZzVpilfr;
			P_3 = YSiBWocJJPKtAmZfddcvodBUErcm;
			return 0;
		}
		fixed (byte* ptr = P_0)
		{
			return klxMdkMazIUJPUlFFCZeFKzabgc(ptr, P_0.Length, P_1, out P_2, out P_3);
		}
	}

	public unsafe int klxMdkMazIUJPUlFFCZeFKzabgc(byte* P_0, int P_1, int P_2)
	{
		int num;
		uint num2;
		return klxMdkMazIUJPUlFFCZeFKzabgc(P_0, P_1, P_2, out num, out num2);
	}

	public int klxMdkMazIUJPUlFFCZeFKzabgc(IntPtr P_0, int P_1, int P_2)
	{
		int num;
		uint num2;
		return klxMdkMazIUJPUlFFCZeFKzabgc(P_0, P_1, P_2, out num, out num2);
	}

	public int klxMdkMazIUJPUlFFCZeFKzabgc(byte[] P_0, int P_1)
	{
		int num;
		uint num2;
		return klxMdkMazIUJPUlFFCZeFKzabgc(P_0, P_1, out num, out num2);
	}

	public unsafe int BJrAAaIAGcmOVdfUIHHCJXemriPD(byte* P_0, int P_1, int P_2)
	{
		if (P_0 == null || P_1 <= 0 || P_2 <= 0 || zWxYYZHxNQWHXNHmCvpyfCmiFZa == 0)
		{
			return 0;
		}
		if (P_2 > P_1)
		{
			P_2 = P_1;
		}
		if (P_2 > zWxYYZHxNQWHXNHmCvpyfCmiFZa)
		{
			P_2 = zWxYYZHxNQWHXNHmCvpyfCmiFZa;
		}
		int num = RBtRonCEgaNDwiemTOAXtCdIbNk.KtdFVPWbuczWQlMquhIGGlqiuHS(P_0, P_1, P_2, (int)jXIenjkEruNJzfLtcugShQgMZQMm);
		if (num <= 0)
		{
			return 0;
		}
		if (num < P_2)
		{
			num += RBtRonCEgaNDwiemTOAXtCdIbNk.KtdFVPWbuczWQlMquhIGGlqiuHS(P_0 + num, P_1 - num, P_2 - num);
		}
		hygpetHKuLsSJXXRkTkwrSTaFTs(num);
		return num;
	}

	public unsafe int BJrAAaIAGcmOVdfUIHHCJXemriPD(byte[] P_0, int P_1)
	{
		if (P_0 == null || P_1 <= 0)
		{
			return 0;
		}
		fixed (byte* ptr = P_0)
		{
			return BJrAAaIAGcmOVdfUIHHCJXemriPD(ptr, P_0.Length, P_1);
		}
	}

	public unsafe int BJrAAaIAGcmOVdfUIHHCJXemriPD(IntPtr P_0, int P_1, int P_2)
	{
		if (P_0 == IntPtr.Zero || P_1 <= 0 || P_2 <= 0)
		{
			return 0;
		}
		return BJrAAaIAGcmOVdfUIHHCJXemriPD((byte*)(void*)P_0, P_1, P_2);
	}

	public unsafe int oIBQWQNeHdWkwYHSjniHXFyBSmx(byte* P_0, int P_1, int P_2, int P_3)
	{
		if (P_0 == null || P_1 <= 0 || P_2 <= 0 || zWxYYZHxNQWHXNHmCvpyfCmiFZa == 0 || P_3 < 0 || P_3 >= LuchvTBkdZMBSkHJLiuqFzaAUOcK)
		{
			return 0;
		}
		if (P_2 > P_1)
		{
			P_2 = P_1;
		}
		if (P_2 > zWxYYZHxNQWHXNHmCvpyfCmiFZa)
		{
			P_2 = zWxYYZHxNQWHXNHmCvpyfCmiFZa;
		}
		int num = RBtRonCEgaNDwiemTOAXtCdIbNk.KtdFVPWbuczWQlMquhIGGlqiuHS(P_0, P_1, P_2, P_3);
		if (num <= 0)
		{
			return 0;
		}
		if (num < P_2)
		{
			num += RBtRonCEgaNDwiemTOAXtCdIbNk.KtdFVPWbuczWQlMquhIGGlqiuHS(P_0 + num, P_1 - num, P_2 - num);
		}
		return num;
	}

	public unsafe int oIBQWQNeHdWkwYHSjniHXFyBSmx(byte[] P_0, int P_1, int P_2)
	{
		if (P_0 == null || P_1 <= 0 || P_1 <= 0 || P_2 <= 0)
		{
			return 0;
		}
		fixed (byte* ptr = P_0)
		{
			return oIBQWQNeHdWkwYHSjniHXFyBSmx(ptr, P_0.Length, P_1, P_2);
		}
	}

	public unsafe int oIBQWQNeHdWkwYHSjniHXFyBSmx(IntPtr P_0, int P_1, int P_2, int P_3)
	{
		if (P_0 == IntPtr.Zero || P_1 <= 0 || P_2 <= 0 || P_3 <= 0)
		{
			return 0;
		}
		return oIBQWQNeHdWkwYHSjniHXFyBSmx((byte*)(void*)P_0, P_1, P_2, P_3);
	}

	public bool jYuOzlJtihpWwRTDsuTZYrbfQmE(int P_0, uint P_1)
	{
		if (P_0 < 0 || P_0 >= LuchvTBkdZMBSkHJLiuqFzaAUOcK)
		{
			return false;
		}
		if (P_0 < qVMumYliTxEbhDvuWouZzVpilfr)
		{
			if (P_1 == YSiBWocJJPKtAmZfddcvodBUErcm)
			{
				return true;
			}
		}
		else if (P_0 >= qVMumYliTxEbhDvuWouZzVpilfr)
		{
			if (YSiBWocJJPKtAmZfddcvodBUErcm == 0)
			{
				return false;
			}
			if (YSiBWocJJPKtAmZfddcvodBUErcm - 1 == P_1)
			{
				return true;
			}
		}
		return false;
	}

	public void UbHHPMhQuOGmtxkgszeCFVvzcjF()
	{
		qVMumYliTxEbhDvuWouZzVpilfr = 0L;
		jXIenjkEruNJzfLtcugShQgMZQMm = 0L;
		zWxYYZHxNQWHXNHmCvpyfCmiFZa = 0;
		BRmuoyXmYVmmOSMdixDlTdUQCzH = false;
		YSiBWocJJPKtAmZfddcvodBUErcm = 0u;
	}

	private void FIchBYeeVpCInMVumDXKcZyvDrj(int P_0)
	{
		if (P_0 <= 0)
		{
			return;
		}
		int num = (int)qVMumYliTxEbhDvuWouZzVpilfr;
		qVMumYliTxEbhDvuWouZzVpilfr += P_0;
		bool flag = false;
		if (num < jXIenjkEruNJzfLtcugShQgMZQMm)
		{
			if (qVMumYliTxEbhDvuWouZzVpilfr > jXIenjkEruNJzfLtcugShQgMZQMm)
			{
				flag = true;
			}
		}
		else if (num > jXIenjkEruNJzfLtcugShQgMZQMm)
		{
			if (qVMumYliTxEbhDvuWouZzVpilfr - LuchvTBkdZMBSkHJLiuqFzaAUOcK > jXIenjkEruNJzfLtcugShQgMZQMm)
			{
				flag = true;
			}
		}
		else if (zWxYYZHxNQWHXNHmCvpyfCmiFZa > 0)
		{
			flag = true;
		}
		if (flag)
		{
			BRmuoyXmYVmmOSMdixDlTdUQCzH = true;
			jXIenjkEruNJzfLtcugShQgMZQMm = qVMumYliTxEbhDvuWouZzVpilfr;
			if (jXIenjkEruNJzfLtcugShQgMZQMm >= LuchvTBkdZMBSkHJLiuqFzaAUOcK)
			{
				jXIenjkEruNJzfLtcugShQgMZQMm -= LuchvTBkdZMBSkHJLiuqFzaAUOcK;
			}
		}
		if (qVMumYliTxEbhDvuWouZzVpilfr >= LuchvTBkdZMBSkHJLiuqFzaAUOcK)
		{
			qVMumYliTxEbhDvuWouZzVpilfr -= LuchvTBkdZMBSkHJLiuqFzaAUOcK;
			zbccXjNFRKmhFNRTnjNnASebbyr();
		}
		zWxYYZHxNQWHXNHmCvpyfCmiFZa = (int)MathTools.Clamp((long)zWxYYZHxNQWHXNHmCvpyfCmiFZa + (long)P_0, 0L, LuchvTBkdZMBSkHJLiuqFzaAUOcK);
	}

	private void hygpetHKuLsSJXXRkTkwrSTaFTs(int P_0)
	{
		if (P_0 > 0)
		{
			if (BRmuoyXmYVmmOSMdixDlTdUQCzH)
			{
				BRmuoyXmYVmmOSMdixDlTdUQCzH = false;
			}
			jXIenjkEruNJzfLtcugShQgMZQMm += P_0;
			if (jXIenjkEruNJzfLtcugShQgMZQMm >= LuchvTBkdZMBSkHJLiuqFzaAUOcK)
			{
				jXIenjkEruNJzfLtcugShQgMZQMm -= LuchvTBkdZMBSkHJLiuqFzaAUOcK;
			}
			long num = (long)zWxYYZHxNQWHXNHmCvpyfCmiFZa - (long)P_0;
			zWxYYZHxNQWHXNHmCvpyfCmiFZa = (int)((num >= 0) ? num : 0);
		}
	}

	private void zbccXjNFRKmhFNRTnjNnASebbyr()
	{
		if (YSiBWocJJPKtAmZfddcvodBUErcm == uint.MaxValue)
		{
			YSiBWocJJPKtAmZfddcvodBUErcm = 0u;
		}
		else
		{
			YSiBWocJJPKtAmZfddcvodBUErcm++;
		}
	}

	public void Dispose()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
		GC.SuppressFinalize(this);
	}

	~FcNgynHxpiyclOjUfyqdKozPYKY()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
	}

	protected void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (!jpnIPbpqmlecdiNqaFAxiNCsiMxs)
		{
			if (P_0 && RBtRonCEgaNDwiemTOAXtCdIbNk != null)
			{
				RBtRonCEgaNDwiemTOAXtCdIbNk.Dispose();
			}
			jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
		}
	}
}
