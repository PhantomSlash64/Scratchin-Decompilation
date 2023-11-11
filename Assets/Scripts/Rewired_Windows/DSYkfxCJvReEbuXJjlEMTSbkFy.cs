using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;

internal class DSYkfxCJvReEbuXJjlEMTSbkFy
{
	[CompilerGenerated]
	private DateTime vITRDmwByMJbocSzjBdRgzLCimG;

	[CompilerGenerated]
	private WeakReference BHCtQtWHlLnGkXIBYgsVyPxLeSC;

	[CompilerGenerated]
	private string cxgsMJXyAhhvqzoeKcrtajwYOME;

	public DateTime kDmERXjytfcFgjwdsLHpqhXRfypZ
	{
		[CompilerGenerated]
		get
		{
			return vITRDmwByMJbocSzjBdRgzLCimG;
		}
		[CompilerGenerated]
		private set
		{
			vITRDmwByMJbocSzjBdRgzLCimG = value;
		}
	}

	public WeakReference HfgXrOplmvlvTLqdbZmywVQWyzL
	{
		[CompilerGenerated]
		get
		{
			return BHCtQtWHlLnGkXIBYgsVyPxLeSC;
		}
		[CompilerGenerated]
		private set
		{
			BHCtQtWHlLnGkXIBYgsVyPxLeSC = value;
		}
	}

	public string gmAMojiOmzdQUbhxftBwmrTKVoZ
	{
		[CompilerGenerated]
		get
		{
			return cxgsMJXyAhhvqzoeKcrtajwYOME;
		}
		[CompilerGenerated]
		private set
		{
			cxgsMJXyAhhvqzoeKcrtajwYOME = value;
		}
	}

	public bool TZxesclPaPyfIKONVQTgVkeUTJJ => HfgXrOplmvlvTLqdbZmywVQWyzL.IsAlive;

	public DSYkfxCJvReEbuXJjlEMTSbkFy(DateTime creationTime, qFZgaejGInJCCmTgEqQEEiVAcXBC comObject, string stackTrace)
	{
		kDmERXjytfcFgjwdsLHpqhXRfypZ = creationTime;
		HfgXrOplmvlvTLqdbZmywVQWyzL = new WeakReference(comObject, trackResurrection: true);
		gmAMojiOmzdQUbhxftBwmrTKVoZ = stackTrace;
	}

	public override string ToString()
	{
		if (!(HfgXrOplmvlvTLqdbZmywVQWyzL.Target is qFZgaejGInJCCmTgEqQEEiVAcXBC qFZgaejGInJCCmTgEqQEEiVAcXBC2))
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "Active COM Object: [0x{0:X}] Class: [{1}] Time [{2}] Stack:\r\n{3}", qFZgaejGInJCCmTgEqQEEiVAcXBC2.qNCdusATkxKqHGKMOPeqBcgaeFqZ.ToInt64(), qFZgaejGInJCCmTgEqQEEiVAcXBC2.GetType().FullName, kDmERXjytfcFgjwdsLHpqhXRfypZ, gmAMojiOmzdQUbhxftBwmrTKVoZ).AppendLine();
		return stringBuilder.ToString();
	}
}
