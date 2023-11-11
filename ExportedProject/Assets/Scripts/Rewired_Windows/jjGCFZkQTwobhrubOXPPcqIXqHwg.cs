using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Attributes;
using Rewired.Utils.Classes.Utility;

internal class jjGCFZkQTwobhrubOXPPcqIXqHwg
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private unsafe delegate int lyvBvbsQCyxltYPTrzjeyQCmhFdf(void* deviceInstance, IntPtr data);

	private readonly IntPtr aWZcFkSqSiiEloDGpAWVEVnYGkmb;

	private readonly lyvBvbsQCyxltYPTrzjeyQCmhFdf gXyAzJOtPvGgrAvrFnQtfTxwttaj;

	[CompilerGenerated]
	private List<kZGiMDfGMXWCSvEiAkxONtHlItb> CKXBJFNqIVepXFbPQSRAHfwqHcfU;

	public IntPtr qNCdusATkxKqHGKMOPeqBcgaeFqZ => aWZcFkSqSiiEloDGpAWVEVnYGkmb;

	public List<kZGiMDfGMXWCSvEiAkxONtHlItb> EHkQTNMhOWErTSnmcdFdJfremhte
	{
		[CompilerGenerated]
		get
		{
			return CKXBJFNqIVepXFbPQSRAHfwqHcfU;
		}
		[CompilerGenerated]
		private set
		{
			CKXBJFNqIVepXFbPQSRAHfwqHcfU = value;
		}
	}

	public unsafe jjGCFZkQTwobhrubOXPPcqIXqHwg()
	{
		gXyAzJOtPvGgrAvrFnQtfTxwttaj = ExqdEtHJhLfLdHUlNtDaNniUAvKv;
		aWZcFkSqSiiEloDGpAWVEVnYGkmb = Marshal.GetFunctionPointerForDelegate((Delegate)gXyAzJOtPvGgrAvrFnQtfTxwttaj);
		EHkQTNMhOWErTSnmcdFdJfremhte = new List<kZGiMDfGMXWCSvEiAkxONtHlItb>();
	}

	[MonoPInvokeCallback(typeof(lyvBvbsQCyxltYPTrzjeyQCmhFdf))]
	private unsafe static int ExqdEtHJhLfLdHUlNtDaNniUAvKv(void* P_0, IntPtr P_1)
	{
		uint instanceId = (uint)P_1.ToInt32();
		if (!ObjectInstanceTracker.Default.TryGetInstance<jjGCFZkQTwobhrubOXPPcqIXqHwg>(instanceId, out var instance))
		{
			return 1;
		}
		kZGiMDfGMXWCSvEiAkxONtHlItb kZGiMDfGMXWCSvEiAkxONtHlItb2 = new kZGiMDfGMXWCSvEiAkxONtHlItb();
		kZGiMDfGMXWCSvEiAkxONtHlItb2.EGZQqgUMBZeVScqTyqBpZJGgjtn(ref *(kZGiMDfGMXWCSvEiAkxONtHlItb.lounLOPuzIFbrCJKObdPMNkCiby*)P_0);
		instance.EHkQTNMhOWErTSnmcdFdJfremhte.Add(kZGiMDfGMXWCSvEiAkxONtHlItb2);
		return 1;
	}
}
