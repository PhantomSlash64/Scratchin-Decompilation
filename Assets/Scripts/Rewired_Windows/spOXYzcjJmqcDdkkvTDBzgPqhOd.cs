using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Attributes;
using Rewired.Utils.Classes.Utility;

internal class spOXYzcjJmqcDdkkvTDBzgPqhOd
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private unsafe delegate int sKQKKUbUxFrHXumYHWKyVWvCjnx(void* deviceInstance, IntPtr data);

	private readonly IntPtr aWZcFkSqSiiEloDGpAWVEVnYGkmb;

	private readonly sKQKKUbUxFrHXumYHWKyVWvCjnx gXyAzJOtPvGgrAvrFnQtfTxwttaj;

	[CompilerGenerated]
	private List<SXoDXAAkhtkcYIknHXlAohykBIm> ppWRNMsLDRUkxpCXiCFYaWrNlxx;

	public IntPtr qNCdusATkxKqHGKMOPeqBcgaeFqZ => aWZcFkSqSiiEloDGpAWVEVnYGkmb;

	public List<SXoDXAAkhtkcYIknHXlAohykBIm> eCDXQxlQzGiNkcHDMVGmvMJuTHd
	{
		[CompilerGenerated]
		get
		{
			return ppWRNMsLDRUkxpCXiCFYaWrNlxx;
		}
		[CompilerGenerated]
		private set
		{
			ppWRNMsLDRUkxpCXiCFYaWrNlxx = value;
		}
	}

	public unsafe spOXYzcjJmqcDdkkvTDBzgPqhOd()
	{
		gXyAzJOtPvGgrAvrFnQtfTxwttaj = cxfVeORIpCwcWwKnFrqXfwcRTQP;
		aWZcFkSqSiiEloDGpAWVEVnYGkmb = Marshal.GetFunctionPointerForDelegate((Delegate)gXyAzJOtPvGgrAvrFnQtfTxwttaj);
		eCDXQxlQzGiNkcHDMVGmvMJuTHd = new List<SXoDXAAkhtkcYIknHXlAohykBIm>();
	}

	[MonoPInvokeCallback(typeof(sKQKKUbUxFrHXumYHWKyVWvCjnx))]
	private unsafe static int cxfVeORIpCwcWwKnFrqXfwcRTQP(void* P_0, IntPtr P_1)
	{
		uint instanceId = (uint)P_1.ToInt32();
		if (!ObjectInstanceTracker.Default.TryGetInstance<spOXYzcjJmqcDdkkvTDBzgPqhOd>(instanceId, out var instance))
		{
			return 1;
		}
		SXoDXAAkhtkcYIknHXlAohykBIm sXoDXAAkhtkcYIknHXlAohykBIm = new SXoDXAAkhtkcYIknHXlAohykBIm();
		sXoDXAAkhtkcYIknHXlAohykBIm.EGZQqgUMBZeVScqTyqBpZJGgjtn(ref *(SXoDXAAkhtkcYIknHXlAohykBIm.gFPklKAmbLPWkdQPqBxfOWVZEW*)P_0);
		instance.eCDXQxlQzGiNkcHDMVGmvMJuTHd.Add(sXoDXAAkhtkcYIknHXlAohykBIm);
		return 1;
	}
}
