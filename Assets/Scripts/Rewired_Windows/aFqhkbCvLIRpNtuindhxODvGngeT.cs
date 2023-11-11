using System;
using System.Runtime.CompilerServices;

internal class aFqhkbCvLIRpNtuindhxODvGngeT
{
	private byte pjCCbEgVhaleapQHMTmpePHIaZJE;

	private byte[] rPHnJTtjOApGteMUjDIGqSwFvLl = new byte[0];

	private readonly VuyNBgYHyJnrsISOyMaOknkdeBy.jCELTIrOuITCKGftLrPHlUZcheA qTJECNauPkgACaAQaKroahFBewdE;

	[CompilerGenerated]
	private bool FDBkDQCZtmTepBdbZMahkBqjNBs;

	public bool tmBlyWxWyTEpQvVAqPrCTldYDHSB
	{
		[CompilerGenerated]
		get
		{
			return FDBkDQCZtmTepBdbZMahkBqjNBs;
		}
		[CompilerGenerated]
		private set
		{
			FDBkDQCZtmTepBdbZMahkBqjNBs = value;
		}
	}

	public VuyNBgYHyJnrsISOyMaOknkdeBy.jCELTIrOuITCKGftLrPHlUZcheA DRfIXvgNRLGsLpczZJDnGHxAbojC => qTJECNauPkgACaAQaKroahFBewdE;

	public byte isrxcmuNaKFAKHBTJDCHgVyoFWtL
	{
		get
		{
			return pjCCbEgVhaleapQHMTmpePHIaZJE;
		}
		set
		{
			pjCCbEgVhaleapQHMTmpePHIaZJE = value;
			tmBlyWxWyTEpQvVAqPrCTldYDHSB = true;
		}
	}

	public byte[] ygqDlcblBdHdDceQDJzibNhKqWEM
	{
		get
		{
			return rPHnJTtjOApGteMUjDIGqSwFvLl;
		}
		set
		{
			rPHnJTtjOApGteMUjDIGqSwFvLl = value;
			tmBlyWxWyTEpQvVAqPrCTldYDHSB = true;
		}
	}

	public aFqhkbCvLIRpNtuindhxODvGngeT(int reportSize)
	{
		Array.Resize(ref rPHnJTtjOApGteMUjDIGqSwFvLl, reportSize - 1);
	}

	public aFqhkbCvLIRpNtuindhxODvGngeT(int reportSize, VuyNBgYHyJnrsISOyMaOknkdeBy deviceData)
	{
		qTJECNauPkgACaAQaKroahFBewdE = deviceData.VbsBiIKtMXEwqXLzbQnUAzQgPUGe;
		Array.Resize(ref rPHnJTtjOApGteMUjDIGqSwFvLl, reportSize - 1);
		if (deviceData.ygqDlcblBdHdDceQDJzibNhKqWEM != null)
		{
			if (deviceData.ygqDlcblBdHdDceQDJzibNhKqWEM.Length > 0)
			{
				pjCCbEgVhaleapQHMTmpePHIaZJE = deviceData.ygqDlcblBdHdDceQDJzibNhKqWEM[0];
				tmBlyWxWyTEpQvVAqPrCTldYDHSB = true;
				if (deviceData.ygqDlcblBdHdDceQDJzibNhKqWEM.Length > 1)
				{
					int length = reportSize - 1;
					if (deviceData.ygqDlcblBdHdDceQDJzibNhKqWEM.Length < reportSize - 1)
					{
						length = deviceData.ygqDlcblBdHdDceQDJzibNhKqWEM.Length;
					}
					Array.Copy(deviceData.ygqDlcblBdHdDceQDJzibNhKqWEM, 1, rPHnJTtjOApGteMUjDIGqSwFvLl, 0, length);
				}
			}
			else
			{
				tmBlyWxWyTEpQvVAqPrCTldYDHSB = false;
			}
		}
		else
		{
			tmBlyWxWyTEpQvVAqPrCTldYDHSB = false;
		}
	}

	public byte[] GIimzmcaxGIbgoGsKKphigXoqpy()
	{
		byte[] array = null;
		Array.Resize(ref array, rPHnJTtjOApGteMUjDIGqSwFvLl.Length + 1);
		array[0] = pjCCbEgVhaleapQHMTmpePHIaZJE;
		Array.Copy(rPHnJTtjOApGteMUjDIGqSwFvLl, 0, array, 1, rPHnJTtjOApGteMUjDIGqSwFvLl.Length);
		return array;
	}
}
