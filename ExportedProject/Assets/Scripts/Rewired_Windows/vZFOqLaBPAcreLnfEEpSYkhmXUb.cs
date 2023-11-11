using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal abstract class vZFOqLaBPAcreLnfEEpSYkhmXUb : IbZyZaiFmxnDEYzbBGjryoaClIL
{
	[CompilerGenerated]
	private JyVcVsFwWkiykZTchJaCeoITDeB DPxzGoqTmMlvPtnxOysWSwDPBFV;

	public JyVcVsFwWkiykZTchJaCeoITDeB NQlSpjJSJbKGjFiHXxSXSoNkpwF
	{
		[CompilerGenerated]
		get
		{
			return DPxzGoqTmMlvPtnxOysWSwDPBFV;
		}
		[CompilerGenerated]
		private set
		{
			DPxzGoqTmMlvPtnxOysWSwDPBFV = value;
		}
	}

	protected abstract KtgkuJPaEqCjOedAAKdZhitcavQ XimOEfCXVAbXnbqIZRtApNvXcilb { get; }

	public unsafe virtual void MGdUCgKavLcKdZVSFfqcdWqSuzTp(JyVcVsFwWkiykZTchJaCeoITDeB P_0)
	{
		NQlSpjJSJbKGjFiHXxSXSoNkpwF = P_0;
		base.qNCdusATkxKqHGKMOPeqBcgaeFqZ = Marshal.AllocHGlobal(IntPtr.Size * 2);
		GCHandle value = GCHandle.Alloc(this);
		Marshal.WriteIntPtr(base.qNCdusATkxKqHGKMOPeqBcgaeFqZ, XimOEfCXVAbXnbqIZRtApNvXcilb.ONOzRUELvkhUJSYbdUptBCQVURI);
		*(IntPtr*)((byte*)(void*)base.qNCdusATkxKqHGKMOPeqBcgaeFqZ + sizeof(IntPtr)) = GCHandle.ToIntPtr(value);
	}

	protected unsafe override void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (base.qNCdusATkxKqHGKMOPeqBcgaeFqZ != IntPtr.Zero)
		{
			GCHandle.FromIntPtr(*(IntPtr*)((byte*)(void*)base.qNCdusATkxKqHGKMOPeqBcgaeFqZ + sizeof(IntPtr))).Free();
			Marshal.FreeHGlobal(base.qNCdusATkxKqHGKMOPeqBcgaeFqZ);
			base.qNCdusATkxKqHGKMOPeqBcgaeFqZ = IntPtr.Zero;
		}
		NQlSpjJSJbKGjFiHXxSXSoNkpwF = null;
		base.PMzamCeIIFqnzgwGlxEbIeTHBFUL(P_0);
	}

	internal unsafe static T waRImjTsGDDQvkutkyfSjDaHDLNE<T>(IntPtr P_0) where T : vZFOqLaBPAcreLnfEEpSYkhmXUb
	{
		return (T)GCHandle.FromIntPtr(*(IntPtr*)((byte*)(void*)P_0 + sizeof(IntPtr))).Target;
	}
}
