using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Attributes;
using Rewired.Utils.Classes.Utility;

internal class sNEyuHSGAKfsWBqYgfXcuGnvzuz
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private unsafe delegate int lYEdOzCshyJkWvzrSJeSWGCTFIi(void* deviceInstance, IntPtr data);

	private readonly IntPtr aWZcFkSqSiiEloDGpAWVEVnYGkmb;

	private readonly lYEdOzCshyJkWvzrSJeSWGCTFIi gXyAzJOtPvGgrAvrFnQtfTxwttaj;

	[CompilerGenerated]
	private List<dgKreIdSZkdSgqOHVRehCRSwtT> RgNqbcAMOINMDOmtrTGFpahuDcF;

	public IntPtr qNCdusATkxKqHGKMOPeqBcgaeFqZ => aWZcFkSqSiiEloDGpAWVEVnYGkmb;

	public List<dgKreIdSZkdSgqOHVRehCRSwtT> AiIDDRailzMOmaNlFfiqTAkGwdkG
	{
		[CompilerGenerated]
		get
		{
			return RgNqbcAMOINMDOmtrTGFpahuDcF;
		}
		[CompilerGenerated]
		private set
		{
			RgNqbcAMOINMDOmtrTGFpahuDcF = value;
		}
	}

	public unsafe sNEyuHSGAKfsWBqYgfXcuGnvzuz()
	{
		gXyAzJOtPvGgrAvrFnQtfTxwttaj = iqhnxRlnpvovtXTaIZVSuSVrAAD;
		aWZcFkSqSiiEloDGpAWVEVnYGkmb = Marshal.GetFunctionPointerForDelegate((Delegate)gXyAzJOtPvGgrAvrFnQtfTxwttaj);
		AiIDDRailzMOmaNlFfiqTAkGwdkG = new List<dgKreIdSZkdSgqOHVRehCRSwtT>();
	}

	[MonoPInvokeCallback(typeof(lYEdOzCshyJkWvzrSJeSWGCTFIi))]
	private unsafe static int iqhnxRlnpvovtXTaIZVSuSVrAAD(void* P_0, IntPtr P_1)
	{
		uint instanceId = (uint)P_1.ToInt32();
		if (!ObjectInstanceTracker.Default.TryGetInstance<sNEyuHSGAKfsWBqYgfXcuGnvzuz>(instanceId, out var instance))
		{
			return 1;
		}
		dgKreIdSZkdSgqOHVRehCRSwtT item = new dgKreIdSZkdSgqOHVRehCRSwtT((IntPtr)P_0);
		instance.AiIDDRailzMOmaNlFfiqTAkGwdkG.Add(item);
		return 1;
	}
}
