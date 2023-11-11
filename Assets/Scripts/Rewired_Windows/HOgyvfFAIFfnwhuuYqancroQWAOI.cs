using System;
using System.Threading;
using Rewired;
using Rewired.Utils;
using Rewired.Utils.Classes.Utility;

internal class HOgyvfFAIFfnwhuuYqancroQWAOI : IDisposable
{
	public delegate void pVfqZmTWMeSPfDhdqtjayNJVFWS(IntPtr reportPointer, int reportByteLength, int reportCount, double timestamp);

	private const int UfeQKSYGUpAsETaSEeFvpWxvyDG = 512;

	private const int DZHnSNgXQWDcLAQwGBZOdDWZjute = 250;

	private readonly pVfqZmTWMeSPfDhdqtjayNJVFWS LFUuXwuSUdpRImGmaDkFbthjTdh;

	private readonly JuxtpRYqSHZPBMBgqiykCwSGHFpu YXxppHMJOyBNyxhKRxRTPDfqJrC;

	private readonly ThreadHelper jplgSnfeWSYLPhJhENHqMaVNIpq;

	private readonly int CspHQGtbLRgBAHsjDmiiGgXNJQG;

	private readonly int qlgSpWqvOuNrOBHspuJxjbCeIUh;

	private readonly string MwLnaUaBlbHUNqJXVuEqVGEtXIj;

	private readonly byte[] JvBcIdyqdbsHBTJSjaJPJrHakHIJ;

	private readonly byte[] daebppjgufRGMcwFjLimiZLWKUu;

	private int MELezRCEAbYtnGDckGicoKaRSbS;

	private FcNgynHxpiyclOjUfyqdKozPYKY jnMrsdJZhwtRNIeOiRyDRvFQSMW;

	private FcNgynHxpiyclOjUfyqdKozPYKY KHzVLrHaqpLTxcCXFYRAoPWwWCh;

	private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

	public HOgyvfFAIFfnwhuuYqancroQWAOI(string hidDevicePath, int reportByteLength, string productName, pVfqZmTWMeSPfDhdqtjayNJVFWS processReportDelegate)
	{
		if (string.IsNullOrEmpty(hidDevicePath))
		{
			throw new ArgumentNullException("hidDevicePath");
		}
		if (processReportDelegate == null)
		{
			throw new ArgumentNullException("processReportDelegate");
		}
		qlgSpWqvOuNrOBHspuJxjbCeIUh = reportByteLength;
		if (qlgSpWqvOuNrOBHspuJxjbCeIUh <= 0)
		{
			qlgSpWqvOuNrOBHspuJxjbCeIUh = 512;
		}
		CspHQGtbLRgBAHsjDmiiGgXNJQG = reportByteLength + 8;
		MwLnaUaBlbHUNqJXVuEqVGEtXIj = productName;
		LFUuXwuSUdpRImGmaDkFbthjTdh = processReportDelegate;
		int num = CspHQGtbLRgBAHsjDmiiGgXNJQG * 60;
		if (num <= 0)
		{
			Logger.LogError("Invalid report buffer size. This device \"" + productName + "\" will not function.");
			throw new Exception();
		}
		try
		{
			YXxppHMJOyBNyxhKRxRTPDfqJrC = new JuxtpRYqSHZPBMBgqiykCwSGHFpu(hidDevicePath, reportByteLength, 250);
		}
		catch (Exception)
		{
			Logger.LogError("Out of memory. This device \"" + productName + "\" will not function.");
			throw;
		}
		try
		{
			jnMrsdJZhwtRNIeOiRyDRvFQSMW = new FcNgynHxpiyclOjUfyqdKozPYKY(num);
			KHzVLrHaqpLTxcCXFYRAoPWwWCh = new FcNgynHxpiyclOjUfyqdKozPYKY(num);
			JvBcIdyqdbsHBTJSjaJPJrHakHIJ = new byte[CspHQGtbLRgBAHsjDmiiGgXNJQG];
			daebppjgufRGMcwFjLimiZLWKUu = new byte[CspHQGtbLRgBAHsjDmiiGgXNJQG];
		}
		catch (Exception)
		{
			Logger.LogError("Out of memory. This device \"" + productName + "\" will not function.");
			throw;
		}
		try
		{
			jplgSnfeWSYLPhJhENHqMaVNIpq = ThreadHelper.Create();
			jplgSnfeWSYLPhJhENHqMaVNIpq.ThreadUpdateEvent += DBRcdHlxLcHiHqHmMVJHGfrdCCOf;
			jplgSnfeWSYLPhJhENHqMaVNIpq.Start(wait: false);
		}
		catch (Exception)
		{
			Logger.LogError("Error creating thread. This device \"" + productName + "\" will not function.");
			throw;
		}
	}

	public unsafe void EBZMKoSknSfzkSfokUzktanzxJf()
	{
		try
		{
			if (DCxIjuFFMjgvBSGRJADFxxJRJSBB())
			{
				return;
			}
			QHZJKPslwmToZGJwIhOKPkjMdgfa();
			int num = 0;
			byte[] jvBcIdyqdbsHBTJSjaJPJrHakHIJ = JvBcIdyqdbsHBTJSjaJPJrHakHIJ;
			fixed (byte* ptr = jvBcIdyqdbsHBTJSjaJPJrHakHIJ)
			{
				while (jnMrsdJZhwtRNIeOiRyDRvFQSMW.BJrAAaIAGcmOVdfUIHHCJXemriPD(jvBcIdyqdbsHBTJSjaJPJrHakHIJ, CspHQGtbLRgBAHsjDmiiGgXNJQG) > 0)
				{
					LFUuXwuSUdpRImGmaDkFbthjTdh((IntPtr)ptr, qlgSpWqvOuNrOBHspuJxjbCeIUh, 1, *(double*)(ptr + qlgSpWqvOuNrOBHspuJxjbCeIUh));
					num++;
				}
			}
		}
		catch
		{
		}
	}

	private void QHZJKPslwmToZGJwIhOKPkjMdgfa()
	{
		lock (jnMrsdJZhwtRNIeOiRyDRvFQSMW)
		{
			lock (KHzVLrHaqpLTxcCXFYRAoPWwWCh)
			{
				MiscTools.Swap(ref jnMrsdJZhwtRNIeOiRyDRvFQSMW, ref KHzVLrHaqpLTxcCXFYRAoPWwWCh);
			}
		}
	}

	private void DBRcdHlxLcHiHqHmMVJHGfrdCCOf()
	{
		if (MELezRCEAbYtnGDckGicoKaRSbS != 0)
		{
			Thread.Sleep(500);
			return;
		}
		try
		{
			byte[] array = daebppjgufRGMcwFjLimiZLWKUu;
			if (!rxZxEjPLllqUarLMDTSURBeTmDZ(array))
			{
				return;
			}
			lock (KHzVLrHaqpLTxcCXFYRAoPWwWCh)
			{
				KHzVLrHaqpLTxcCXFYRAoPWwWCh.klxMdkMazIUJPUlFFCZeFKzabgc(array, array.Length);
			}
		}
		catch
		{
		}
	}

	private bool rxZxEjPLllqUarLMDTSURBeTmDZ(byte[] P_0)
	{
		switch (YXxppHMJOyBNyxhKRxRTPDfqJrC.BJrAAaIAGcmOVdfUIHHCJXemriPD(P_0))
		{
		case JuxtpRYqSHZPBMBgqiykCwSGHFpu.ZcjRVRJeeYKDjhHkdvZhQegawSO.yPNTsfZPfPfRRkdmtjaEgkfNPay:
			return true;
		case JuxtpRYqSHZPBMBgqiykCwSGHFpu.ZcjRVRJeeYKDjhHkdvZhQegawSO.FqRLBrGOhmplYgwIvhggceeNMUQ:
			Thread.Sleep(500);
			break;
		case JuxtpRYqSHZPBMBgqiykCwSGHFpu.ZcjRVRJeeYKDjhHkdvZhQegawSO.HSSfuIzNYanLGBUYeMCnslVRKrD:
			MELezRCEAbYtnGDckGicoKaRSbS = 1;
			break;
		}
		return false;
	}

	private bool DCxIjuFFMjgvBSGRJADFxxJRJSBB()
	{
		if (MELezRCEAbYtnGDckGicoKaRSbS != 0)
		{
			if (MELezRCEAbYtnGDckGicoKaRSbS == 1)
			{
				Logger.LogError("Error communicating with HID device. This device \"" + MwLnaUaBlbHUNqJXVuEqVGEtXIj + "\" will not function.");
				MELezRCEAbYtnGDckGicoKaRSbS = 2;
				try
				{
					jplgSnfeWSYLPhJhENHqMaVNIpq.Stop(wait: false);
				}
				catch
				{
				}
			}
			return true;
		}
		return false;
	}

	public void Dispose()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
		GC.SuppressFinalize(this);
	}

	~HOgyvfFAIFfnwhuuYqancroQWAOI()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
	}

	protected virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (jpnIPbpqmlecdiNqaFAxiNCsiMxs)
		{
			return;
		}
		if (P_0)
		{
			if (jplgSnfeWSYLPhJhENHqMaVNIpq != null)
			{
				jplgSnfeWSYLPhJhENHqMaVNIpq.Dispose();
			}
			if (YXxppHMJOyBNyxhKRxRTPDfqJrC != null)
			{
				YXxppHMJOyBNyxhKRxRTPDfqJrC.Dispose();
			}
		}
		jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
	}
}
