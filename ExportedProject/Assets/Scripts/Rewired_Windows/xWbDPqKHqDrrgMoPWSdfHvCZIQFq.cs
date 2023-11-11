using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Attributes;
using Rewired.Utils.Classes.Utility;

internal class xWbDPqKHqDrrgMoPWSdfHvCZIQFq
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private unsafe delegate int FkoByzBLxcYhPQitKoVqACcIrPl(void* deviceInstance, IntPtr data);

	private readonly IntPtr aWZcFkSqSiiEloDGpAWVEVnYGkmb;

	private readonly FkoByzBLxcYhPQitKoVqACcIrPl gXyAzJOtPvGgrAvrFnQtfTxwttaj;

	[CompilerGenerated]
	private List<tvkecSTWbFlWcBbAxxdWaePZtgu> quUFoszayFuPsmBUynrAYfzOCjm;

	public IntPtr qNCdusATkxKqHGKMOPeqBcgaeFqZ => aWZcFkSqSiiEloDGpAWVEVnYGkmb;

	public List<tvkecSTWbFlWcBbAxxdWaePZtgu> ZFucvyenmxkdqQMvbspPlnNMIvyt
	{
		[CompilerGenerated]
		get
		{
			return quUFoszayFuPsmBUynrAYfzOCjm;
		}
		[CompilerGenerated]
		private set
		{
			quUFoszayFuPsmBUynrAYfzOCjm = value;
		}
	}

	public unsafe xWbDPqKHqDrrgMoPWSdfHvCZIQFq()
	{
		gXyAzJOtPvGgrAvrFnQtfTxwttaj = bfwwffsVzsyBvKKGHLvHgogXqnx;
		aWZcFkSqSiiEloDGpAWVEVnYGkmb = Marshal.GetFunctionPointerForDelegate((Delegate)gXyAzJOtPvGgrAvrFnQtfTxwttaj);
		ZFucvyenmxkdqQMvbspPlnNMIvyt = new List<tvkecSTWbFlWcBbAxxdWaePZtgu>();
	}

	[MonoPInvokeCallback(typeof(FkoByzBLxcYhPQitKoVqACcIrPl))]
	private unsafe static int bfwwffsVzsyBvKKGHLvHgogXqnx(void* P_0, IntPtr P_1)
	{
		uint instanceId = (uint)P_1.ToInt32();
		if (!ObjectInstanceTracker.Default.TryGetInstance<xWbDPqKHqDrrgMoPWSdfHvCZIQFq>(instanceId, out var instance))
		{
			return 1;
		}
		tvkecSTWbFlWcBbAxxdWaePZtgu tvkecSTWbFlWcBbAxxdWaePZtgu2 = new tvkecSTWbFlWcBbAxxdWaePZtgu();
		tvkecSTWbFlWcBbAxxdWaePZtgu2.EGZQqgUMBZeVScqTyqBpZJGgjtn(ref *(tvkecSTWbFlWcBbAxxdWaePZtgu.ISSIgfgpVYsEHpJdjyrTxpDJntb*)P_0);
		instance.ZFucvyenmxkdqQMvbspPlnNMIvyt.Add(tvkecSTWbFlWcBbAxxdWaePZtgu2);
		return 1;
	}
}
