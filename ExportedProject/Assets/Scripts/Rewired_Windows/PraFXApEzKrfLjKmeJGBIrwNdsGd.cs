using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Rewired;
using Rewired.Utils;

internal class PraFXApEzKrfLjKmeJGBIrwNdsGd<T>
{
	private enum jHxPTQUAaWDMuBdrNyBAIdADVErm
	{
		bzmmnRjPXpqhmuLbDgeDHMwVwUeB = 0,
		fkxGmLHVubVbdTIbUVzgCQdmCgf = 1,
		utLeLwuXZMXSHfDTkuBbyVVydMX = 2
	}

	private static class aGSbntzLtPSxPZKGlOVIGkfjaRF
	{
		private class lizNRclfNOBuLFTlpMrPFiCqMnLh : IDisposable
		{
			[CompilerGenerated]
			private sealed class PjPSKUIORbPnHmvjqhgaCuWpoOt
			{
				public ManualResetEvent BNDHHoiVkiCvFIZUOozsilpWuAC;

				public lizNRclfNOBuLFTlpMrPFiCqMnLh uNPbQXVvzYIwDwQbShpWecRbcpNC;

				public void LYCLrlQKGdMJgcQVATvnPDjoBEtD()
				{
					BNDHHoiVkiCvFIZUOozsilpWuAC.Set();
					uNPbQXVvzYIwDwQbShpWecRbcpNC.lbZBXJlVrgCTtUcwiuKbdlXTPwe();
				}
			}

			private readonly object QnjPDsavPpORFdRFTiPBJdcwCnOc;

			private List<WaitCallback> GcExMPfdWxrnztoCyYFTRgeZASG;

			private List<WaitCallback> IsbhsoIYXqMgZGmctUmtGUvAayLl;

			private Thread jplgSnfeWSYLPhJhENHqMaVNIpq;

			private AutoResetEvent NhTDKhCgQFPUBkRVzBkYnQFtQVwV;

			private bool ukfeifClXXgDsfOejPHzAyOSKWbk;

			private bool VGsBBBzWAIagXzfTbimZlgTSETe;

			private bool GGGZjRBOGncFbagcegEDEOBiqDS;

			private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

			public lizNRclfNOBuLFTlpMrPFiCqMnLh()
			{
				QnjPDsavPpORFdRFTiPBJdcwCnOc = new object();
				GcExMPfdWxrnztoCyYFTRgeZASG = new List<WaitCallback>();
				IsbhsoIYXqMgZGmctUmtGUvAayLl = new List<WaitCallback>();
				NhTDKhCgQFPUBkRVzBkYnQFtQVwV = new AutoResetEvent(initialState: false);
			}

			public void DGyXCdchaBaVyuVfrJtqDuuzSoM(WaitCallback P_0)
			{
				if (MGdUCgKavLcKdZVSFfqcdWqSuzTp())
				{
					if (P_0 == null)
					{
						throw new ArgumentNullException("waitCallback");
					}
					lock (QnjPDsavPpORFdRFTiPBJdcwCnOc)
					{
						GcExMPfdWxrnztoCyYFTRgeZASG.Add(P_0);
					}
					NhTDKhCgQFPUBkRVzBkYnQFtQVwV.Set();
				}
			}

			public void WSGEpAjVEZjyCuiFbeqLIaMIYeDH()
			{
				xHaCKJauCaggoFnLairkQoAHeRDf();
			}

			public bool TWjcxXgKqgdHVddNzOLYDFcnDAXL()
			{
				return MGdUCgKavLcKdZVSFfqcdWqSuzTp();
			}

			private bool MGdUCgKavLcKdZVSFfqcdWqSuzTp()
			{
				if (GGGZjRBOGncFbagcegEDEOBiqDS)
				{
					return false;
				}
				if (VGsBBBzWAIagXzfTbimZlgTSETe)
				{
					return false;
				}
				if (ukfeifClXXgDsfOejPHzAyOSKWbk)
				{
					return true;
				}
				if (jplgSnfeWSYLPhJhENHqMaVNIpq != null)
				{
					return true;
				}
				try
				{
					ManualResetEvent BNDHHoiVkiCvFIZUOozsilpWuAC = new ManualResetEvent(initialState: false);
					jplgSnfeWSYLPhJhENHqMaVNIpq = new Thread((ThreadStart)delegate
					{
						BNDHHoiVkiCvFIZUOozsilpWuAC.Set();
						lbZBXJlVrgCTtUcwiuKbdlXTPwe();
					});
					jplgSnfeWSYLPhJhENHqMaVNIpq.Start();
					BNDHHoiVkiCvFIZUOozsilpWuAC.WaitOne();
					return true;
				}
				catch (Exception ex)
				{
					Logger.LogError("An exception occurred trying to initialize the thread pool.\n" + ex, requiredThreadSafety: true);
					jplgSnfeWSYLPhJhENHqMaVNIpq = null;
					GGGZjRBOGncFbagcegEDEOBiqDS = true;
					return false;
				}
			}

			private void lbZBXJlVrgCTtUcwiuKbdlXTPwe()
			{
				ukfeifClXXgDsfOejPHzAyOSKWbk = true;
				while (!VGsBBBzWAIagXzfTbimZlgTSETe)
				{
					NhTDKhCgQFPUBkRVzBkYnQFtQVwV.WaitOne();
					if (VGsBBBzWAIagXzfTbimZlgTSETe)
					{
						break;
					}
					lock (QnjPDsavPpORFdRFTiPBJdcwCnOc)
					{
						MiscTools.Swap(ref GcExMPfdWxrnztoCyYFTRgeZASG, ref IsbhsoIYXqMgZGmctUmtGUvAayLl);
					}
					List<WaitCallback> isbhsoIYXqMgZGmctUmtGUvAayLl = IsbhsoIYXqMgZGmctUmtGUvAayLl;
					int count = isbhsoIYXqMgZGmctUmtGUvAayLl.Count;
					if (count == 0)
					{
						continue;
					}
					for (int i = 0; i < count; i++)
					{
						try
						{
							isbhsoIYXqMgZGmctUmtGUvAayLl[i](null);
						}
						catch (Exception ex)
						{
							Logger.LogError("Exception occurred in thread pool callback.\n" + ex, requiredThreadSafety: true);
						}
					}
					isbhsoIYXqMgZGmctUmtGUvAayLl.Clear();
				}
				lock (QnjPDsavPpORFdRFTiPBJdcwCnOc)
				{
					GcExMPfdWxrnztoCyYFTRgeZASG.Clear();
					IsbhsoIYXqMgZGmctUmtGUvAayLl.Clear();
				}
				VGsBBBzWAIagXzfTbimZlgTSETe = false;
				ukfeifClXXgDsfOejPHzAyOSKWbk = false;
			}

			private void tcPmnjxNxZbTkiuPaRljaIVFgPJ()
			{
				jplgSnfeWSYLPhJhENHqMaVNIpq = null;
				GGGZjRBOGncFbagcegEDEOBiqDS = false;
				VGsBBBzWAIagXzfTbimZlgTSETe = true;
			}

			private void xHaCKJauCaggoFnLairkQoAHeRDf()
			{
				tcPmnjxNxZbTkiuPaRljaIVFgPJ();
				try
				{
					NhTDKhCgQFPUBkRVzBkYnQFtQVwV.Set();
				}
				catch (ObjectDisposedException)
				{
				}
			}

			public void Dispose()
			{
				PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
				GC.SuppressFinalize(this);
			}

			~lizNRclfNOBuLFTlpMrPFiCqMnLh()
			{
				PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
			}

			protected virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
			{
				if (!jpnIPbpqmlecdiNqaFAxiNCsiMxs)
				{
					xHaCKJauCaggoFnLairkQoAHeRDf();
					jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
				}
			}
		}

		private static lizNRclfNOBuLFTlpMrPFiCqMnLh hELxLjWlGzJSfplMlqppBHjeRhu;

		private static int WTGsgXrqNKbGHKSccGNiCGkmxSeG;

		private static lizNRclfNOBuLFTlpMrPFiCqMnLh sbEbcIvmPEBTuXreeevpuQUcdlo => hELxLjWlGzJSfplMlqppBHjeRhu ?? (hELxLjWlGzJSfplMlqppBHjeRhu = new lizNRclfNOBuLFTlpMrPFiCqMnLh());

		static aGSbntzLtPSxPZKGlOVIGkfjaRF()
		{
			WTGsgXrqNKbGHKSccGNiCGkmxSeG = 0;
			AppDomain.CurrentDomain.DomainUnload -= GjlRTHPfzrivJIORFZFWLEjQZjs;
			AppDomain.CurrentDomain.DomainUnload += GjlRTHPfzrivJIORFZFWLEjQZjs;
		}

		private static void GjlRTHPfzrivJIORFZFWLEjQZjs(object P_0, EventArgs P_1)
		{
			PMzamCeIIFqnzgwGlxEbIeTHBFUL();
			AppDomain.CurrentDomain.DomainUnload -= GjlRTHPfzrivJIORFZFWLEjQZjs;
		}

		public static void bYcpeCMObeaQTyehnsJOjQKiWnQ()
		{
			WTGsgXrqNKbGHKSccGNiCGkmxSeG++;
		}

		public static void ZcADlUOnqXBoNhOcuFxyDmEbVlkh()
		{
			WTGsgXrqNKbGHKSccGNiCGkmxSeG--;
			if (WTGsgXrqNKbGHKSccGNiCGkmxSeG < 0)
			{
				Logger.LogError("SharedThread: Too many calls to Unregister.", requiredThreadSafety: true);
			}
			if (WTGsgXrqNKbGHKSccGNiCGkmxSeG == 0)
			{
				PMzamCeIIFqnzgwGlxEbIeTHBFUL();
			}
		}

		public static void DGyXCdchaBaVyuVfrJtqDuuzSoM(WaitCallback P_0)
		{
			sbEbcIvmPEBTuXreeevpuQUcdlo.DGyXCdchaBaVyuVfrJtqDuuzSoM(P_0);
		}

		public static void WSGEpAjVEZjyCuiFbeqLIaMIYeDH()
		{
			sbEbcIvmPEBTuXreeevpuQUcdlo.WSGEpAjVEZjyCuiFbeqLIaMIYeDH();
		}

		public static bool TWjcxXgKqgdHVddNzOLYDFcnDAXL()
		{
			return sbEbcIvmPEBTuXreeevpuQUcdlo.TWjcxXgKqgdHVddNzOLYDFcnDAXL();
		}

		private static void PMzamCeIIFqnzgwGlxEbIeTHBFUL()
		{
			if (hELxLjWlGzJSfplMlqppBHjeRhu != null)
			{
				hELxLjWlGzJSfplMlqppBHjeRhu.Dispose();
			}
			hELxLjWlGzJSfplMlqppBHjeRhu = null;
			WTGsgXrqNKbGHKSccGNiCGkmxSeG = 0;
		}
	}

	private jHxPTQUAaWDMuBdrNyBAIdADVErm qTJECNauPkgACaAQaKroahFBewdE;

	private T fUpdrEKGtjODElLHElfJqHHpurP;

	private WaitCallback gXyAzJOtPvGgrAvrFnQtfTxwttaj;

	private object tDbgVRmshvprTuFsEwttpQVIOkk;

	private Func<T> uQUAjTOYiUTuFCXpwrzrsUsBVFC;

	private bool LquyCoXeXnSylYBQHFdPsGKtAzY;

	private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

	public bool bgLAKkuspNIyPudbNgPBgmqQVpJG
	{
		get
		{
			if (qTJECNauPkgACaAQaKroahFBewdE != jHxPTQUAaWDMuBdrNyBAIdADVErm.fkxGmLHVubVbdTIbUVzgCQdmCgf)
			{
				return qTJECNauPkgACaAQaKroahFBewdE == jHxPTQUAaWDMuBdrNyBAIdADVErm.utLeLwuXZMXSHfDTkuBbyVVydMX;
			}
			return true;
		}
	}

	public T GWOwgIzmyVWsoVjleBNCERdBoQa => fUpdrEKGtjODElLHElfJqHHpurP;

	public bool bXUJACnaYvOCANYOaVrTdSwcZxj()
	{
		bool flag = qTJECNauPkgACaAQaKroahFBewdE == jHxPTQUAaWDMuBdrNyBAIdADVErm.utLeLwuXZMXSHfDTkuBbyVVydMX;
		if (flag)
		{
			qTJECNauPkgACaAQaKroahFBewdE = jHxPTQUAaWDMuBdrNyBAIdADVErm.bzmmnRjPXpqhmuLbDgeDHMwVwUeB;
		}
		return flag;
	}

	public PraFXApEzKrfLjKmeJGBIrwNdsGd(bool useSharedThread, Func<T> resultDelegate)
	{
		LquyCoXeXnSylYBQHFdPsGKtAzY = useSharedThread;
		if (resultDelegate == null)
		{
			throw new ArgumentNullException("resultDelegate");
		}
		uQUAjTOYiUTuFCXpwrzrsUsBVFC = resultDelegate;
		gXyAzJOtPvGgrAvrFnQtfTxwttaj = wDDIGqIbcZEYDMDAJdsRednKYzsN;
		tDbgVRmshvprTuFsEwttpQVIOkk = new object();
		qTJECNauPkgACaAQaKroahFBewdE = jHxPTQUAaWDMuBdrNyBAIdADVErm.bzmmnRjPXpqhmuLbDgeDHMwVwUeB;
		if (useSharedThread)
		{
			aGSbntzLtPSxPZKGlOVIGkfjaRF.bYcpeCMObeaQTyehnsJOjQKiWnQ();
		}
	}

	public bool UBdDYFzJEaQOUTjUSMwjsblQggo()
	{
		lock (tDbgVRmshvprTuFsEwttpQVIOkk)
		{
			if (qTJECNauPkgACaAQaKroahFBewdE == jHxPTQUAaWDMuBdrNyBAIdADVErm.fkxGmLHVubVbdTIbUVzgCQdmCgf)
			{
				return false;
			}
			fUpdrEKGtjODElLHElfJqHHpurP = default(T);
			qTJECNauPkgACaAQaKroahFBewdE = jHxPTQUAaWDMuBdrNyBAIdADVErm.fkxGmLHVubVbdTIbUVzgCQdmCgf;
		}
		if (LquyCoXeXnSylYBQHFdPsGKtAzY)
		{
			aGSbntzLtPSxPZKGlOVIGkfjaRF.DGyXCdchaBaVyuVfrJtqDuuzSoM(gXyAzJOtPvGgrAvrFnQtfTxwttaj);
		}
		else
		{
			ThreadPool.QueueUserWorkItem(gXyAzJOtPvGgrAvrFnQtfTxwttaj, this);
		}
		return true;
	}

	public void xZveeqhZWQBoifJNrEKvhlbeSAk()
	{
		lock (tDbgVRmshvprTuFsEwttpQVIOkk)
		{
			fUpdrEKGtjODElLHElfJqHHpurP = default(T);
			qTJECNauPkgACaAQaKroahFBewdE = jHxPTQUAaWDMuBdrNyBAIdADVErm.bzmmnRjPXpqhmuLbDgeDHMwVwUeB;
		}
	}

	private void wDDIGqIbcZEYDMDAJdsRednKYzsN(object P_0)
	{
		lock (tDbgVRmshvprTuFsEwttpQVIOkk)
		{
			if (qTJECNauPkgACaAQaKroahFBewdE == jHxPTQUAaWDMuBdrNyBAIdADVErm.fkxGmLHVubVbdTIbUVzgCQdmCgf)
			{
				fUpdrEKGtjODElLHElfJqHHpurP = uQUAjTOYiUTuFCXpwrzrsUsBVFC();
				qTJECNauPkgACaAQaKroahFBewdE = jHxPTQUAaWDMuBdrNyBAIdADVErm.utLeLwuXZMXSHfDTkuBbyVVydMX;
			}
		}
	}

	public void PMzamCeIIFqnzgwGlxEbIeTHBFUL()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
		GC.SuppressFinalize(this);
	}

	~PraFXApEzKrfLjKmeJGBIrwNdsGd()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
	}

	protected virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (!jpnIPbpqmlecdiNqaFAxiNCsiMxs)
		{
			if (P_0)
			{
				xZveeqhZWQBoifJNrEKvhlbeSAk();
			}
			if (LquyCoXeXnSylYBQHFdPsGKtAzY)
			{
				aGSbntzLtPSxPZKGlOVIGkfjaRF.ZcADlUOnqXBoNhOcuFxyDmEbVlkh();
			}
			jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
		}
	}
}
