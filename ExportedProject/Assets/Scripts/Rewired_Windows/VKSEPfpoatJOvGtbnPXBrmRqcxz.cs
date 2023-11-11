using System;
using System.Runtime.InteropServices;
using System.Threading;

internal abstract class VKSEPfpoatJOvGtbnPXBrmRqcxz : vZFOqLaBPAcreLnfEEpSYkhmXUb
{
	internal class ACCZweLOgalkRwAjvadBAkMAPYaS : KtgkuJPaEqCjOedAAKdZhitcavQ
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate int uXdzLuYoyGVodjwwRpRHtkSjpNS(IntPtr thisObject, IntPtr guid, out IntPtr output);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate int nhPDmFSLAZHMfSUNPCZcsqoNbAih(IntPtr thisObject);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate int KjGMDcSNsCEvGiIGUjXKZGLANqw(IntPtr thisObject);

		public ACCZweLOgalkRwAjvadBAkMAPYaS(int numberOfCallbackMethods)
			: base(numberOfCallbackMethods + 3)
		{
			akKQBLArrGcOyjEHSgLeKpsbToBm(new uXdzLuYoyGVodjwwRpRHtkSjpNS(tUHGdEdeCiJLayyhmapwvZfGqfxr));
			akKQBLArrGcOyjEHSgLeKpsbToBm(new nhPDmFSLAZHMfSUNPCZcsqoNbAih(UBNvWOvLzZtyzPLpiFvNTbQsqkH));
			akKQBLArrGcOyjEHSgLeKpsbToBm(new KjGMDcSNsCEvGiIGUjXKZGLANqw(TICperAFFroKvUFbaJXYKNRWrFr));
		}

		protected unsafe static int tUHGdEdeCiJLayyhmapwvZfGqfxr(IntPtr P_0, IntPtr P_1, out IntPtr P_2)
		{
			VKSEPfpoatJOvGtbnPXBrmRqcxz vKSEPfpoatJOvGtbnPXBrmRqcxz = vZFOqLaBPAcreLnfEEpSYkhmXUb.waRImjTsGDDQvkutkyfSjDaHDLNE<VKSEPfpoatJOvGtbnPXBrmRqcxz>(P_0);
			if (vKSEPfpoatJOvGtbnPXBrmRqcxz == null)
			{
				P_2 = IntPtr.Zero;
				return pERSibQDMTkaGVsXRncSUqChDMi.csULEbFpzENFHQYBWuOfxOESifjE.ibiVUVhTXpCbLyPdaQVJypoECLM;
			}
			return vKSEPfpoatJOvGtbnPXBrmRqcxz.tUHGdEdeCiJLayyhmapwvZfGqfxr(P_0, ref *(Guid*)(void*)P_1, out P_2);
		}

		protected static int UBNvWOvLzZtyzPLpiFvNTbQsqkH(IntPtr P_0)
		{
			return vZFOqLaBPAcreLnfEEpSYkhmXUb.waRImjTsGDDQvkutkyfSjDaHDLNE<VKSEPfpoatJOvGtbnPXBrmRqcxz>(P_0)?.UBNvWOvLzZtyzPLpiFvNTbQsqkH(P_0) ?? 0;
		}

		protected static int TICperAFFroKvUFbaJXYKNRWrFr(IntPtr P_0)
		{
			return vZFOqLaBPAcreLnfEEpSYkhmXUb.waRImjTsGDDQvkutkyfSjDaHDLNE<VKSEPfpoatJOvGtbnPXBrmRqcxz>(P_0)?.TICperAFFroKvUFbaJXYKNRWrFr(P_0) ?? 0;
		}
	}

	private int XBGgLTtTUVjPgdLFNjczDGxUMZx = 1;

	public static Guid AONwgNiNrvYnbuqiAereGdVHJqk = new Guid("00000000-0000-0000-C000-000000000046");

	protected int tUHGdEdeCiJLayyhmapwvZfGqfxr(IntPtr P_0, ref Guid P_1, out IntPtr P_2)
	{
		VKSEPfpoatJOvGtbnPXBrmRqcxz vKSEPfpoatJOvGtbnPXBrmRqcxz = (VKSEPfpoatJOvGtbnPXBrmRqcxz)((cCsOBykrHMUgKHMvCdjhYMSKHte)base.NQlSpjJSJbKGjFiHXxSXSoNkpwF.voZvybzwnHmEoRhkjcyloiQMzsa).ZZqRZlBaBvJPLJyupfBRdfOixdg(P_1);
		if (vKSEPfpoatJOvGtbnPXBrmRqcxz != null)
		{
			vKSEPfpoatJOvGtbnPXBrmRqcxz.UBNvWOvLzZtyzPLpiFvNTbQsqkH(P_0);
			P_2 = vKSEPfpoatJOvGtbnPXBrmRqcxz.qNCdusATkxKqHGKMOPeqBcgaeFqZ;
			return pERSibQDMTkaGVsXRncSUqChDMi.OcZYepmWMDvUQaZQdPJGgcFqbBu.ibiVUVhTXpCbLyPdaQVJypoECLM;
		}
		P_2 = IntPtr.Zero;
		return pERSibQDMTkaGVsXRncSUqChDMi.csULEbFpzENFHQYBWuOfxOESifjE.ibiVUVhTXpCbLyPdaQVJypoECLM;
	}

	protected virtual int UBNvWOvLzZtyzPLpiFvNTbQsqkH(IntPtr P_0)
	{
		return Interlocked.Increment(ref XBGgLTtTUVjPgdLFNjczDGxUMZx);
	}

	protected virtual int TICperAFFroKvUFbaJXYKNRWrFr(IntPtr P_0)
	{
		return Interlocked.Decrement(ref XBGgLTtTUVjPgdLFNjczDGxUMZx);
	}
}
