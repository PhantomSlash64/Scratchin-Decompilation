using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

internal class KtgkuJPaEqCjOedAAKdZhitcavQ
{
	private readonly List<Delegate> GXKYSGiTbjeQOhFUqJOEyHxyonS;

	private readonly IntPtr bAhfczgEtgAmVKWQPCeJJpSKvTN;

	public IntPtr ONOzRUELvkhUJSYbdUptBCQVURI => bAhfczgEtgAmVKWQPCeJJpSKvTN;

	public KtgkuJPaEqCjOedAAKdZhitcavQ(int numberOfCallbackMethods)
	{
		bAhfczgEtgAmVKWQPCeJJpSKvTN = Marshal.AllocHGlobal(IntPtr.Size * numberOfCallbackMethods);
		GXKYSGiTbjeQOhFUqJOEyHxyonS = new List<Delegate>();
	}

	public unsafe void akKQBLArrGcOyjEHSgLeKpsbToBm(Delegate P_0)
	{
		int count = GXKYSGiTbjeQOhFUqJOEyHxyonS.Count;
		GXKYSGiTbjeQOhFUqJOEyHxyonS.Add(P_0);
		*(IntPtr*)((byte*)(void*)bAhfczgEtgAmVKWQPCeJJpSKvTN + (long)count * (long)sizeof(IntPtr)) = Marshal.GetFunctionPointerForDelegate(P_0);
	}
}
