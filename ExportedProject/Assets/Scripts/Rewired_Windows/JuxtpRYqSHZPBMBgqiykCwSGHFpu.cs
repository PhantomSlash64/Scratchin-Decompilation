using System;
using System.Diagnostics;
using System.Threading;
using Rewired;
using Rewired.Utils.Attributes;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Classes.Utility;

internal class JuxtpRYqSHZPBMBgqiykCwSGHFpu : IDisposable
{
	private enum cVegWGMOHrUZIdJqHvvoDPRIgyoB
	{
		bzmmnRjPXpqhmuLbDgeDHMwVwUeB = 0,
		ZGJwvCOnaxEXenFWqGganPQUnCw = 1,
		KTgdPfhvNRnlDfTFDEpKafpVEcVH = 2,
		KBNlfWLnFyUmGwJktbiIkBWprPV = 3,
		JlwavtfxxpoAsHzTahCiAeEZymzW = 4,
		xJtFFznIWkaMupWJIrRwmpfINoR = 5
	}

	public enum ZcjRVRJeeYKDjhHkdvZhQegawSO
	{
		bzmmnRjPXpqhmuLbDgeDHMwVwUeB = 0,
		yPNTsfZPfPfRRkdmtjaEgkfNPay = 1,
		FqRLBrGOhmplYgwIvhggceeNMUQ = 2,
		ZGJwvCOnaxEXenFWqGganPQUnCw = 3,
		HSSfuIzNYanLGBUYeMCnslVRKrD = 4
	}

	public const int qnHzKTdzRwLqQKdTfzWcudsRQrR = 8;

	private const int abnAlogJQweWuazDeXKJKkPmLjVE = 10;

	private readonly string oldsdxcMxBkPydmymVttShNUbRDF;

	private IntPtr GCSBCEymLHrTIzqdggaviCSGOwYq = BhcxpsOxjdSjSDyqakqjSUDsNCD.JTYGZxsRIwNucJnfgUcsOgEecZFA;

	private readonly NativeBuffer RBtRonCEgaNDwiemTOAXtCdIbNk;

	private readonly int lRfdETvqtNeCRrIJIZIMywjYuJP;

	private readonly BhcxpsOxjdSjSDyqakqjSUDsNCD.snynPgPRxbuQnpkVXfmMQCzWGJOb pyMztbuCPCreSCzmlGpfCledjEB;

	private readonly object xEleCHZjdubhDuaWJttKHgmKdgs;

	private readonly object FcPNTpEImoWkCqdtyosPdRvjhEj;

	private readonly uint QcXbsFUjQlzmdlmNnRCVrSyNbTZ;

	private NativeOverlapped yhlwNLbHSpGFLABLpfHLcFiEMkEr;

	private cVegWGMOHrUZIdJqHvvoDPRIgyoB hRoGrnjFGwCIuLxsuMGRkmJTypp;

	private int YewoVVNPMklrcBfZQsjIXLxwKJQ;

	private bool aQNvukHAFITkriRKgnNCSlPIrYd;

	private int rzavqjYtKeiaONmoYgMucGvHmEz;

	private int XmlCRWMLQxDiYkkMRKgIsuToLhKI;

	public readonly int jOCifsTUSxVxTCDhvREUCmvJzmS;

	private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

	private bool fGcvLiXbUIhveYuKHpUprbEcdtk => sYwCgmJInQorTFIIBkpIONhajGKy.fGcvLiXbUIhveYuKHpUprbEcdtk(oldsdxcMxBkPydmymVttShNUbRDF);

	public JuxtpRYqSHZPBMBgqiykCwSGHFpu(string devicePath, int reportLength, int timeout)
	{
		if (string.IsNullOrEmpty(devicePath))
		{
			throw new ArgumentNullException("devicePath");
		}
		if (reportLength <= 0)
		{
			throw new ArgumentOutOfRangeException("reportLength must be > 0");
		}
		QcXbsFUjQlzmdlmNnRCVrSyNbTZ = ObjectInstanceTracker.Default.Register(this);
		oldsdxcMxBkPydmymVttShNUbRDF = devicePath;
		if (!nCfivWAwvBEaoblRCnCnjwhOmFSQ())
		{
			throw new Exception("Could not open HID device.");
		}
		lRfdETvqtNeCRrIJIZIMywjYuJP = reportLength;
		jOCifsTUSxVxTCDhvREUCmvJzmS = reportLength + 8;
		RBtRonCEgaNDwiemTOAXtCdIbNk = new NativeBuffer(jOCifsTUSxVxTCDhvREUCmvJzmS);
		yhlwNLbHSpGFLABLpfHLcFiEMkEr = default(NativeOverlapped);
		hRoGrnjFGwCIuLxsuMGRkmJTypp = cVegWGMOHrUZIdJqHvvoDPRIgyoB.bzmmnRjPXpqhmuLbDgeDHMwVwUeB;
		YewoVVNPMklrcBfZQsjIXLxwKJQ = ((timeout < 0) ? 65535 : timeout);
		xEleCHZjdubhDuaWJttKHgmKdgs = new object();
		FcPNTpEImoWkCqdtyosPdRvjhEj = new object();
		pyMztbuCPCreSCzmlGpfCledjEB = divZUzXEeltdAHfcxdWuHngCvzeD;
		yXtbQoGixuQSGXVAmsnwhfKJRzx(yhlwNLbHSpGFLABLpfHLcFiEMkEr);
	}

	public ZcjRVRJeeYKDjhHkdvZhQegawSO BJrAAaIAGcmOVdfUIHHCJXemriPD(byte[] P_0)
	{
		lock (FcPNTpEImoWkCqdtyosPdRvjhEj)
		{
			if (jpnIPbpqmlecdiNqaFAxiNCsiMxs)
			{
				return ZcjRVRJeeYKDjhHkdvZhQegawSO.HSSfuIzNYanLGBUYeMCnslVRKrD;
			}
			if (!yoCqvlZCfEbIHFDscAbxCjPJoVSg())
			{
				return (XmlCRWMLQxDiYkkMRKgIsuToLhKI >= 10) ? ZcjRVRJeeYKDjhHkdvZhQegawSO.HSSfuIzNYanLGBUYeMCnslVRKrD : ZcjRVRJeeYKDjhHkdvZhQegawSO.FqRLBrGOhmplYgwIvhggceeNMUQ;
			}
			if (P_0 == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (P_0.Length < jOCifsTUSxVxTCDhvREUCmvJzmS)
			{
				throw new Exception("buffer must be at least " + jOCifsTUSxVxTCDhvREUCmvJzmS + " bytes");
			}
			switch (hRoGrnjFGwCIuLxsuMGRkmJTypp)
			{
			case cVegWGMOHrUZIdJqHvvoDPRIgyoB.bzmmnRjPXpqhmuLbDgeDHMwVwUeB:
				iRpQfbLsKAfrTqXtDdVCfPfenRrh();
				break;
			case cVegWGMOHrUZIdJqHvvoDPRIgyoB.ZGJwvCOnaxEXenFWqGganPQUnCw:
				AmSFacjSXjOwBcfeyidDWtjOhOM();
				break;
			case cVegWGMOHrUZIdJqHvvoDPRIgyoB.KTgdPfhvNRnlDfTFDEpKafpVEcVH:
				qIzxTezziomnlkWJmrjeidEAaGO();
				break;
			case cVegWGMOHrUZIdJqHvvoDPRIgyoB.JlwavtfxxpoAsHzTahCiAeEZymzW:
				wgeVoTyZgpsIanFeLTcyLuSlFkJ();
				break;
			}
			switch (hRoGrnjFGwCIuLxsuMGRkmJTypp)
			{
			case cVegWGMOHrUZIdJqHvvoDPRIgyoB.bzmmnRjPXpqhmuLbDgeDHMwVwUeB:
				return ZcjRVRJeeYKDjhHkdvZhQegawSO.bzmmnRjPXpqhmuLbDgeDHMwVwUeB;
			case cVegWGMOHrUZIdJqHvvoDPRIgyoB.ZGJwvCOnaxEXenFWqGganPQUnCw:
			case cVegWGMOHrUZIdJqHvvoDPRIgyoB.KTgdPfhvNRnlDfTFDEpKafpVEcVH:
			case cVegWGMOHrUZIdJqHvvoDPRIgyoB.JlwavtfxxpoAsHzTahCiAeEZymzW:
				return ZcjRVRJeeYKDjhHkdvZhQegawSO.ZGJwvCOnaxEXenFWqGganPQUnCw;
			case cVegWGMOHrUZIdJqHvvoDPRIgyoB.xJtFFznIWkaMupWJIrRwmpfINoR:
				RBtRonCEgaNDwiemTOAXtCdIbNk.TryReadBytes(P_0, jOCifsTUSxVxTCDhvREUCmvJzmS);
				hRoGrnjFGwCIuLxsuMGRkmJTypp = cVegWGMOHrUZIdJqHvvoDPRIgyoB.bzmmnRjPXpqhmuLbDgeDHMwVwUeB;
				return ZcjRVRJeeYKDjhHkdvZhQegawSO.yPNTsfZPfPfRRkdmtjaEgkfNPay;
			case cVegWGMOHrUZIdJqHvvoDPRIgyoB.KBNlfWLnFyUmGwJktbiIkBWprPV:
				hRoGrnjFGwCIuLxsuMGRkmJTypp = cVegWGMOHrUZIdJqHvvoDPRIgyoB.bzmmnRjPXpqhmuLbDgeDHMwVwUeB;
				return ZcjRVRJeeYKDjhHkdvZhQegawSO.FqRLBrGOhmplYgwIvhggceeNMUQ;
			default:
				throw new NotImplementedException();
			}
		}
	}

	private bool iRpQfbLsKAfrTqXtDdVCfPfenRrh()
	{
		if (hRoGrnjFGwCIuLxsuMGRkmJTypp != 0)
		{
			throw new Exception("Cannot StartRead from this state. State = " + (int)hRoGrnjFGwCIuLxsuMGRkmJTypp);
		}
		try
		{
			OeUrnnZKFEfcUxLGqEbSdcenXWX();
			lock (xEleCHZjdubhDuaWJttKHgmKdgs)
			{
				bool flag = BhcxpsOxjdSjSDyqakqjSUDsNCD.qBsfoSPGrDgprIjiTaYnHvkqHME(GCSBCEymLHrTIzqdggaviCSGOwYq, RBtRonCEgaNDwiemTOAXtCdIbNk, (uint)lRfdETvqtNeCRrIJIZIMywjYuJP, ref yhlwNLbHSpGFLABLpfHLcFiEMkEr, pyMztbuCPCreSCzmlGpfCledjEB);
				if (flag)
				{
					hRoGrnjFGwCIuLxsuMGRkmJTypp = cVegWGMOHrUZIdJqHvvoDPRIgyoB.ZGJwvCOnaxEXenFWqGganPQUnCw;
					aQNvukHAFITkriRKgnNCSlPIrYd = true;
				}
				else
				{
					FqRLBrGOhmplYgwIvhggceeNMUQ();
				}
				return flag;
			}
		}
		catch (Exception)
		{
			FqRLBrGOhmplYgwIvhggceeNMUQ();
			return false;
		}
	}

	private void AmSFacjSXjOwBcfeyidDWtjOhOM()
	{
		if (hRoGrnjFGwCIuLxsuMGRkmJTypp != cVegWGMOHrUZIdJqHvvoDPRIgyoB.ZGJwvCOnaxEXenFWqGganPQUnCw)
		{
			throw new Exception("Cannot CheckReadStatus from this state. State = " + (int)hRoGrnjFGwCIuLxsuMGRkmJTypp);
		}
		switch (dPRSPHQUSYLfLtzLKHRBrnyIWvW())
		{
		case ZcjRVRJeeYKDjhHkdvZhQegawSO.FqRLBrGOhmplYgwIvhggceeNMUQ:
			FqRLBrGOhmplYgwIvhggceeNMUQ();
			break;
		case ZcjRVRJeeYKDjhHkdvZhQegawSO.yPNTsfZPfPfRRkdmtjaEgkfNPay:
			yPNTsfZPfPfRRkdmtjaEgkfNPay();
			break;
		case ZcjRVRJeeYKDjhHkdvZhQegawSO.ZGJwvCOnaxEXenFWqGganPQUnCw:
			break;
		}
	}

	private ZcjRVRJeeYKDjhHkdvZhQegawSO dPRSPHQUSYLfLtzLKHRBrnyIWvW()
	{
		if (hRoGrnjFGwCIuLxsuMGRkmJTypp != cVegWGMOHrUZIdJqHvvoDPRIgyoB.ZGJwvCOnaxEXenFWqGganPQUnCw)
		{
			return ZcjRVRJeeYKDjhHkdvZhQegawSO.FqRLBrGOhmplYgwIvhggceeNMUQ;
		}
		try
		{
			switch (BhcxpsOxjdSjSDyqakqjSUDsNCD.CjhABMzYoSBnwoOGHyJkgWyjIw(YewoVVNPMklrcBfZQsjIXLxwKJQ, true))
			{
			case 0u:
				return ZcjRVRJeeYKDjhHkdvZhQegawSO.ZGJwvCOnaxEXenFWqGganPQUnCw;
			case 192u:
			{
				if (!BhcxpsOxjdSjSDyqakqjSUDsNCD.pszLBnEvsZTckNpPgZatYbRaGYs(GCSBCEymLHrTIzqdggaviCSGOwYq, ref yhlwNLbHSpGFLABLpfHLcFiEMkEr, out var num, false))
				{
					return ZcjRVRJeeYKDjhHkdvZhQegawSO.FqRLBrGOhmplYgwIvhggceeNMUQ;
				}
				return (num > 0) ? ZcjRVRJeeYKDjhHkdvZhQegawSO.yPNTsfZPfPfRRkdmtjaEgkfNPay : ZcjRVRJeeYKDjhHkdvZhQegawSO.FqRLBrGOhmplYgwIvhggceeNMUQ;
			}
			case uint.MaxValue:
			case 128u:
			case 258u:
				return ZcjRVRJeeYKDjhHkdvZhQegawSO.ZGJwvCOnaxEXenFWqGganPQUnCw;
			default:
				return ZcjRVRJeeYKDjhHkdvZhQegawSO.FqRLBrGOhmplYgwIvhggceeNMUQ;
			}
		}
		catch
		{
			return ZcjRVRJeeYKDjhHkdvZhQegawSO.FqRLBrGOhmplYgwIvhggceeNMUQ;
		}
	}

	private void FqRLBrGOhmplYgwIvhggceeNMUQ()
	{
		hRoGrnjFGwCIuLxsuMGRkmJTypp = cVegWGMOHrUZIdJqHvvoDPRIgyoB.KTgdPfhvNRnlDfTFDEpKafpVEcVH;
		qIzxTezziomnlkWJmrjeidEAaGO();
	}

	private void qIzxTezziomnlkWJmrjeidEAaGO()
	{
		if (hRoGrnjFGwCIuLxsuMGRkmJTypp != cVegWGMOHrUZIdJqHvvoDPRIgyoB.KTgdPfhvNRnlDfTFDEpKafpVEcVH)
		{
			throw new Exception("Cannot CheckErrorFinished from this state. State = " + (int)hRoGrnjFGwCIuLxsuMGRkmJTypp);
		}
		hRoGrnjFGwCIuLxsuMGRkmJTypp = cVegWGMOHrUZIdJqHvvoDPRIgyoB.KBNlfWLnFyUmGwJktbiIkBWprPV;
	}

	private void yPNTsfZPfPfRRkdmtjaEgkfNPay()
	{
		hRoGrnjFGwCIuLxsuMGRkmJTypp = cVegWGMOHrUZIdJqHvvoDPRIgyoB.JlwavtfxxpoAsHzTahCiAeEZymzW;
		wgeVoTyZgpsIanFeLTcyLuSlFkJ();
	}

	private void wgeVoTyZgpsIanFeLTcyLuSlFkJ()
	{
		if (hRoGrnjFGwCIuLxsuMGRkmJTypp != cVegWGMOHrUZIdJqHvvoDPRIgyoB.JlwavtfxxpoAsHzTahCiAeEZymzW)
		{
			throw new Exception("Cannot CheckSuccessFinished from this state. State = " + (int)hRoGrnjFGwCIuLxsuMGRkmJTypp);
		}
		hRoGrnjFGwCIuLxsuMGRkmJTypp = cVegWGMOHrUZIdJqHvvoDPRIgyoB.xJtFFznIWkaMupWJIrRwmpfINoR;
		RBtRonCEgaNDwiemTOAXtCdIbNk.Write(ReInput.realTime, lRfdETvqtNeCRrIJIZIMywjYuJP);
	}

	private void OeUrnnZKFEfcUxLGqEbSdcenXWX()
	{
		yXtbQoGixuQSGXVAmsnwhfKJRzx(yhlwNLbHSpGFLABLpfHLcFiEMkEr);
		RBtRonCEgaNDwiemTOAXtCdIbNk.Clear();
		rzavqjYtKeiaONmoYgMucGvHmEz = 0;
		aQNvukHAFITkriRKgnNCSlPIrYd = false;
	}

	private void yXtbQoGixuQSGXVAmsnwhfKJRzx(NativeOverlapped P_0)
	{
		P_0.EventHandle = new IntPtr((int)QcXbsFUjQlzmdlmNnRCVrSyNbTZ);
		P_0.InternalHigh = IntPtr.Zero;
		P_0.InternalLow = IntPtr.Zero;
		P_0.OffsetHigh = 0;
		P_0.OffsetLow = 0;
	}

	private bool yoCqvlZCfEbIHFDscAbxCjPJoVSg()
	{
		if (XmlCRWMLQxDiYkkMRKgIsuToLhKI >= 10)
		{
			return false;
		}
		if (!nCfivWAwvBEaoblRCnCnjwhOmFSQ())
		{
			XmlCRWMLQxDiYkkMRKgIsuToLhKI++;
			return false;
		}
		if (XmlCRWMLQxDiYkkMRKgIsuToLhKI > 0)
		{
			XmlCRWMLQxDiYkkMRKgIsuToLhKI = 0;
		}
		return true;
	}

	private bool nCfivWAwvBEaoblRCnCnjwhOmFSQ()
	{
		if (GCSBCEymLHrTIzqdggaviCSGOwYq != BhcxpsOxjdSjSDyqakqjSUDsNCD.JTYGZxsRIwNucJnfgUcsOgEecZFA)
		{
			return true;
		}
		if (!fGcvLiXbUIhveYuKHpUprbEcdtk)
		{
			return false;
		}
		IntPtr intPtr = tJKAaDrvDYPmVdvOWTbYhAqgFPi.MzoYxfOdCxFlOXCkNPJXAEKRpwN(oldsdxcMxBkPydmymVttShNUbRDF, xNxlsfJtdmLgsLpXvJXvKtxFFzn.JGFkRBcUXtBlkTYWAAkEFyDDjVC, 3221225472u, onJfdTGjmuCrmsdvUkFvIZyefBlQ.CGmxvAXqZVdlwwfTOeTPkIDeTOC | onJfdTGjmuCrmsdvUkFvIZyefBlQ.mnsxsXARiylESkmzvxWpWQOciSp);
		if (intPtr == BhcxpsOxjdSjSDyqakqjSUDsNCD.JTYGZxsRIwNucJnfgUcsOgEecZFA)
		{
			return false;
		}
		GCSBCEymLHrTIzqdggaviCSGOwYq = intPtr;
		return true;
	}

	private void JkEpjVookWTcfTioKIiBoqRdEfn()
	{
		if (!(GCSBCEymLHrTIzqdggaviCSGOwYq == BhcxpsOxjdSjSDyqakqjSUDsNCD.JTYGZxsRIwNucJnfgUcsOgEecZFA))
		{
			tJKAaDrvDYPmVdvOWTbYhAqgFPi.BKZtrMellduMDpkmiJpwOwRCNXs(GCSBCEymLHrTIzqdggaviCSGOwYq);
			GCSBCEymLHrTIzqdggaviCSGOwYq = BhcxpsOxjdSjSDyqakqjSUDsNCD.JTYGZxsRIwNucJnfgUcsOgEecZFA;
		}
	}

	[MonoPInvokeCallback(typeof(BhcxpsOxjdSjSDyqakqjSUDsNCD.snynPgPRxbuQnpkVXfmMQCzWGJOb))]
	private unsafe static void divZUzXEeltdAHfcxdWuHngCvzeD(int P_0, int P_1, IntPtr P_2)
	{
		NativeOverlapped* ptr = (NativeOverlapped*)(void*)P_2;
		uint instanceId = (uint)ptr->EventHandle.ToInt32();
		if (!ObjectInstanceTracker.Default.TryGetInstance<JuxtpRYqSHZPBMBgqiykCwSGHFpu>(instanceId, out var instance))
		{
			return;
		}
		lock (instance.xEleCHZjdubhDuaWJttKHgmKdgs)
		{
			instance.rzavqjYtKeiaONmoYgMucGvHmEz = P_0;
			instance.aQNvukHAFITkriRKgnNCSlPIrYd = false;
		}
	}

	public void Dispose()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
		GC.SuppressFinalize(this);
	}

	~JuxtpRYqSHZPBMBgqiykCwSGHFpu()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
	}

	protected virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (jpnIPbpqmlecdiNqaFAxiNCsiMxs)
		{
			return;
		}
		using (new Locker(FcPNTpEImoWkCqdtyosPdRvjhEj))
		{
			if (P_0)
			{
				ObjectInstanceTracker.Default.Unregister(QcXbsFUjQlzmdlmNnRCVrSyNbTZ);
			}
			JkEpjVookWTcfTioKIiBoqRdEfn();
			jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
		}
	}

	[Conditional("DEBUGTHIS")]
	private void JliJIpnGXMcTGhbAMTmkkcnlQQTK(string P_0)
	{
	}
}
