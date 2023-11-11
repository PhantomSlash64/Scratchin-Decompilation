using System;
using System.Runtime.CompilerServices;

internal struct arqwvMUuunLbDqdcqHYDaxGWWsC
{
	public IntPtr VhBTBMdAFpqaWuODnxKAnlMulqD;

	private IntPtr jByFaorDVdacjVxTGmZGVIEIQyU;

	private int qFjrfXcJYFJgRMfvwFehKiWAJWd;

	public int UsbDFKzTViCdeDmSneiJKBYbdnj;

	public int rHgvAWfvcVetfzBNIUSpjxABFaI;

	internal bool jYuOzlJtihpWwRTDsuTZYrbfQmE
	{
		get
		{
			if (qFjrfXcJYFJgRMfvwFehKiWAJWd > 0)
			{
				return jByFaorDVdacjVxTGmZGVIEIQyU != IntPtr.Zero;
			}
			return false;
		}
	}

	public IntPtr ZBGrZUldPcIiWuwkUFVkEUPgRLj => jByFaorDVdacjVxTGmZGVIEIQyU;

	public int dxZDKATDnZQnTqSLUlpzQjjjZkn => qFjrfXcJYFJgRMfvwFehKiWAJWd;

	internal unsafe arqwvMUuunLbDqdcqHYDaxGWWsC(ref lOjRmNhcRhwonUCOQXiLfgRvAbT rawInput, vVIgVMfgTxnAknVhfBemEDkakiR memQueue)
	{
		VhBTBMdAFpqaWuODnxKAnlMulqD = rawInput.wCEAvStPOQNPByHieIfLAPImqVH.VhBTBMdAFpqaWuODnxKAnlMulqD;
		UsbDFKzTViCdeDmSneiJKBYbdnj = rawInput.ygqDlcblBdHdDceQDJzibNhKqWEM.KXzcljqlTJZudSTSxAwIjiwKRCX.UsbDFKzTViCdeDmSneiJKBYbdnj;
		rHgvAWfvcVetfzBNIUSpjxABFaI = rawInput.ygqDlcblBdHdDceQDJzibNhKqWEM.KXzcljqlTJZudSTSxAwIjiwKRCX.GuXHNeqNqyIYAXwFGNRfUAvqPtE;
		qFjrfXcJYFJgRMfvwFehKiWAJWd = UsbDFKzTViCdeDmSneiJKBYbdnj * rHgvAWfvcVetfzBNIUSpjxABFaI;
		if (qFjrfXcJYFJgRMfvwFehKiWAJWd > 0)
		{
			fixed (IntPtr* ptr = &System.Runtime.CompilerServices.Unsafe.As<int, IntPtr>(ref rawInput.ygqDlcblBdHdDceQDJzibNhKqWEM.KXzcljqlTJZudSTSxAwIjiwKRCX.pAFwWrEZDcAhmEwjjrxXquXeQgj))
			{
				jByFaorDVdacjVxTGmZGVIEIQyU = memQueue.rFIeeoCOnxuyYUiWNbHnOwpRPVS((uint)qFjrfXcJYFJgRMfvwFehKiWAJWd, ptr);
			}
		}
		else
		{
			jByFaorDVdacjVxTGmZGVIEIQyU = IntPtr.Zero;
		}
	}
}
