internal class SIPColauqDIJVXDFgMFRCQuGiNi
{
	private float guEeKCGAvXXokDaDYmoUpjQXLwbr;

	private float iXDztkdFGDYJloTHOeDFOLNypoS;

	private float NbOAdFSGAIEpYSuOxvQKgmyKapak;

	private bool ChCbRyIZHWEtbcoyhqxGJRCujLn;

	private double DfiJduYcmfxbZUygkFhhmwBiUVv;

	private double DoTDnPFvDnaALLfaUzxHEfuzhDj;

	private bool tLLsXFxdlehRpQWEzCpgdNrJuWk;

	private bool omVeJPBAbCyLVPOZLldJEdXgTxIb;

	public bool LKGKaxUOLwuJcOsjsDKYSwNaRYh => omVeJPBAbCyLVPOZLldJEdXgTxIb;

	public SIPColauqDIJVXDFgMFRCQuGiNi(float delay, float ratePerSecond)
	{
		kciaTKUSqjAYAsNbYAPBaSPjDHNm(delay, ratePerSecond);
	}

	public void mtiNfGzpXHszOwiOIAVYQuMZclV(bool P_0, bool P_1, float P_2, float P_3, double P_4)
	{
		if (!ChCbRyIZHWEtbcoyhqxGJRCujLn && !P_0)
		{
			return;
		}
		if (omVeJPBAbCyLVPOZLldJEdXgTxIb)
		{
			vvUEnmNqngIOgkPubbAjKiBnJbRF(false, P_4);
		}
		if (!P_1)
		{
			if (ChCbRyIZHWEtbcoyhqxGJRCujLn)
			{
				skeOSBSqSPGPnIZySfEhxuCHbTXM();
			}
			return;
		}
		if (!ChCbRyIZHWEtbcoyhqxGJRCujLn || P_2 != guEeKCGAvXXokDaDYmoUpjQXLwbr || P_3 != iXDztkdFGDYJloTHOeDFOLNypoS)
		{
			kciaTKUSqjAYAsNbYAPBaSPjDHNm(P_2, P_3);
			tvCBgIPnqjaOIPTXBTydmcrRbzF(P_4);
			vvUEnmNqngIOgkPubbAjKiBnJbRF(true, P_4);
		}
		if (P_2 > 0f && !tLLsXFxdlehRpQWEzCpgdNrJuWk)
		{
			if (P_4 - DfiJduYcmfxbZUygkFhhmwBiUVv <= (double)P_2)
			{
				return;
			}
			vvUEnmNqngIOgkPubbAjKiBnJbRF(true, P_4);
			tLLsXFxdlehRpQWEzCpgdNrJuWk = true;
		}
		if (P_4 - DoTDnPFvDnaALLfaUzxHEfuzhDj >= (double)NbOAdFSGAIEpYSuOxvQKgmyKapak)
		{
			vvUEnmNqngIOgkPubbAjKiBnJbRF(true, P_4);
		}
	}

	public void kciaTKUSqjAYAsNbYAPBaSPjDHNm(float P_0, float P_1)
	{
		guEeKCGAvXXokDaDYmoUpjQXLwbr = P_0;
		iXDztkdFGDYJloTHOeDFOLNypoS = P_1;
		NbOAdFSGAIEpYSuOxvQKgmyKapak = 1f / P_1;
	}

	public void skeOSBSqSPGPnIZySfEhxuCHbTXM()
	{
		ChCbRyIZHWEtbcoyhqxGJRCujLn = false;
		tLLsXFxdlehRpQWEzCpgdNrJuWk = false;
		DoTDnPFvDnaALLfaUzxHEfuzhDj = 0.0;
		omVeJPBAbCyLVPOZLldJEdXgTxIb = false;
	}

	private void tvCBgIPnqjaOIPTXBTydmcrRbzF(double P_0)
	{
		skeOSBSqSPGPnIZySfEhxuCHbTXM();
		DfiJduYcmfxbZUygkFhhmwBiUVv = P_0;
		ChCbRyIZHWEtbcoyhqxGJRCujLn = true;
	}

	private void vvUEnmNqngIOgkPubbAjKiBnJbRF(bool P_0, double P_1)
	{
		if (P_0)
		{
			omVeJPBAbCyLVPOZLldJEdXgTxIb = true;
			DoTDnPFvDnaALLfaUzxHEfuzhDj = P_1;
		}
		else
		{
			omVeJPBAbCyLVPOZLldJEdXgTxIb = false;
		}
	}
}
