using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Attributes;
using Rewired.Utils.Classes.Utility;

internal class LZQZKrohPebMvduodaBeXvRlsvzO
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	private unsafe delegate int QfMbatpJEqdlUWhFXyCNQTPTEBp(void* deviceInstance, IntPtr data);

	private readonly IntPtr aWZcFkSqSiiEloDGpAWVEVnYGkmb;

	private readonly QfMbatpJEqdlUWhFXyCNQTPTEBp gXyAzJOtPvGgrAvrFnQtfTxwttaj;

	[CompilerGenerated]
	private List<fVeZUnieJxQIWBLXIPSiBzUGSHp> aFOSOtaXzxTehRDMtpVjasFFvXd;

	public IntPtr qNCdusATkxKqHGKMOPeqBcgaeFqZ => aWZcFkSqSiiEloDGpAWVEVnYGkmb;

	public List<fVeZUnieJxQIWBLXIPSiBzUGSHp> AonHwIQzwYFVthnHFMEKEdVLDia
	{
		[CompilerGenerated]
		get
		{
			return aFOSOtaXzxTehRDMtpVjasFFvXd;
		}
		[CompilerGenerated]
		private set
		{
			aFOSOtaXzxTehRDMtpVjasFFvXd = value;
		}
	}

	public unsafe LZQZKrohPebMvduodaBeXvRlsvzO()
	{
		gXyAzJOtPvGgrAvrFnQtfTxwttaj = zTCkpDMNcLdmytHBdycYMYxbEFA;
		aWZcFkSqSiiEloDGpAWVEVnYGkmb = Marshal.GetFunctionPointerForDelegate((Delegate)gXyAzJOtPvGgrAvrFnQtfTxwttaj);
		AonHwIQzwYFVthnHFMEKEdVLDia = new List<fVeZUnieJxQIWBLXIPSiBzUGSHp>();
	}

	[MonoPInvokeCallback(typeof(QfMbatpJEqdlUWhFXyCNQTPTEBp))]
	private unsafe static int zTCkpDMNcLdmytHBdycYMYxbEFA(void* P_0, IntPtr P_1)
	{
		uint instanceId = (uint)P_1.ToInt32();
		if (!ObjectInstanceTracker.Default.TryGetInstance<LZQZKrohPebMvduodaBeXvRlsvzO>(instanceId, out var instance))
		{
			return 1;
		}
		fVeZUnieJxQIWBLXIPSiBzUGSHp fVeZUnieJxQIWBLXIPSiBzUGSHp2 = new fVeZUnieJxQIWBLXIPSiBzUGSHp();
		fVeZUnieJxQIWBLXIPSiBzUGSHp2.EGZQqgUMBZeVScqTyqBpZJGgjtn(ref *(fVeZUnieJxQIWBLXIPSiBzUGSHp.cVaVZEfNhloseOVeTgJycdXrGcN*)P_0);
		instance.AonHwIQzwYFVthnHFMEKEdVLDia.Add(fVeZUnieJxQIWBLXIPSiBzUGSHp2);
		return 1;
	}
}
