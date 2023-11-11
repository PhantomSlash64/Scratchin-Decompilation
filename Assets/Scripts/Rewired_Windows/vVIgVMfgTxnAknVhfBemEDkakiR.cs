using System;
using System.Runtime.InteropServices;

internal class vVIgVMfgTxnAknVhfBemEDkakiR : IDisposable
{
	private int gsYAjmXibQLzBZApMqxNDgDdvyO;

	private uint fnXDHADGAIKLXUikmwkYcfoOkMJD;

	private IntPtr GNKuEkvjmeWAVZqVodDPTwilajy;

	private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

	public vVIgVMfgTxnAknVhfBemEDkakiR(uint size)
	{
		if (size == 0)
		{
			throw new Exception("size must be > 0!");
		}
		fnXDHADGAIKLXUikmwkYcfoOkMJD = size;
		gsYAjmXibQLzBZApMqxNDgDdvyO = 0;
		try
		{
			GNKuEkvjmeWAVZqVodDPTwilajy = Marshal.AllocHGlobal((int)size);
			if (GNKuEkvjmeWAVZqVodDPTwilajy == IntPtr.Zero)
			{
				throw new Exception("Could not allocate native memory.");
			}
		}
		catch
		{
			throw;
		}
	}

	public unsafe IntPtr rFIeeoCOnxuyYUiWNbHnOwpRPVS(uint P_0, void* P_1)
	{
		if (jpnIPbpqmlecdiNqaFAxiNCsiMxs)
		{
			return IntPtr.Zero;
		}
		if (P_0 == 0)
		{
			return IntPtr.Zero;
		}
		if (P_0 > fnXDHADGAIKLXUikmwkYcfoOkMJD)
		{
			return IntPtr.Zero;
		}
		if (gsYAjmXibQLzBZApMqxNDgDdvyO + P_0 >= fnXDHADGAIKLXUikmwkYcfoOkMJD)
		{
			gsYAjmXibQLzBZApMqxNDgDdvyO = 0;
		}
		IntPtr intPtr = new IntPtr(GNKuEkvjmeWAVZqVodDPTwilajy.ToInt64() + gsYAjmXibQLzBZApMqxNDgDdvyO);
		WdABqngzfChtFJSJGeObIpoDQOet.rdErrbQiKPgCHcdXppfcnDcrDPZ(intPtr, (IntPtr)P_1, (int)P_0);
		gsYAjmXibQLzBZApMqxNDgDdvyO += (int)P_0;
		return intPtr;
	}

	public void Dispose()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
		GC.SuppressFinalize(this);
	}

	~vVIgVMfgTxnAknVhfBemEDkakiR()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
	}

	protected virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (!jpnIPbpqmlecdiNqaFAxiNCsiMxs)
		{
			jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
			if (GNKuEkvjmeWAVZqVodDPTwilajy != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(GNKuEkvjmeWAVZqVodDPTwilajy);
			}
		}
	}
}
