using System;
using System.Runtime.InteropServices;

internal class wiOxVhQlrPDIDeswmspbUDPzZUB
{
	private int YPkwkqVIOCIstiQDzQFOeQDDvXdt;

	private byte[] RBtRonCEgaNDwiemTOAXtCdIbNk;

	public virtual int OAxxiRRJUwaMLNmFaPAXfzgmRpb => YPkwkqVIOCIstiQDzQFOeQDDvXdt;

	protected wiOxVhQlrPDIDeswmspbUDPzZUB()
	{
	}

	internal wiOxVhQlrPDIDeswmspbUDPzZUB(int bufferSize, IntPtr bufferPointer)
	{
		yXtbQoGixuQSGXVAmsnwhfKJRzx(bufferSize, bufferPointer);
	}

	private unsafe void yXtbQoGixuQSGXVAmsnwhfKJRzx(int P_0, IntPtr P_1)
	{
		YPkwkqVIOCIstiQDzQFOeQDDvXdt = P_0;
		if (YPkwkqVIOCIstiQDzQFOeQDDvXdt > 0 && P_1 != IntPtr.Zero)
		{
			RBtRonCEgaNDwiemTOAXtCdIbNk = new byte[P_0];
			fixed (byte* ptr = RBtRonCEgaNDwiemTOAXtCdIbNk)
			{
				WdABqngzfChtFJSJGeObIpoDQOet.rdErrbQiKPgCHcdXppfcnDcrDPZ((IntPtr)ptr, P_1, YPkwkqVIOCIstiQDzQFOeQDDvXdt);
			}
		}
	}

	protected virtual wiOxVhQlrPDIDeswmspbUDPzZUB fMyDiEWbVoVVRklJtHYIUVjCxXv(int P_0, IntPtr P_1)
	{
		yXtbQoGixuQSGXVAmsnwhfKJRzx(P_0, P_1);
		return this;
	}

	internal virtual void LivkFzdcIcShDvcgbtjCjuBmAaa(IntPtr P_0)
	{
		if (P_0 != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(P_0);
		}
	}

	internal unsafe virtual IntPtr otrcokARnroruTmNVJikhZXoofTz()
	{
		IntPtr intPtr = IntPtr.Zero;
		if (YPkwkqVIOCIstiQDzQFOeQDDvXdt > 0 && RBtRonCEgaNDwiemTOAXtCdIbNk != null)
		{
			intPtr = Marshal.AllocHGlobal(YPkwkqVIOCIstiQDzQFOeQDDvXdt);
			fixed (byte* ptr = RBtRonCEgaNDwiemTOAXtCdIbNk)
			{
				WdABqngzfChtFJSJGeObIpoDQOet.rdErrbQiKPgCHcdXppfcnDcrDPZ(intPtr, (IntPtr)ptr, YPkwkqVIOCIstiQDzQFOeQDDvXdt);
			}
		}
		return intPtr;
	}

	public unsafe T IQOgATBVEBhALblPHRRVcrvxCDnj<T>() where T : wiOxVhQlrPDIDeswmspbUDPzZUB, new()
	{
		if ((object)GetType() == typeof(T))
		{
			return (T)this;
		}
		if ((object)GetType() == typeof(wiOxVhQlrPDIDeswmspbUDPzZUB))
		{
			fixed (IntPtr* ptr = RBtRonCEgaNDwiemTOAXtCdIbNk)
			{
				T val = new T();
				return (T)val.fMyDiEWbVoVVRklJtHYIUVjCxXv(YPkwkqVIOCIstiQDzQFOeQDDvXdt, (IntPtr)ptr);
			}
		}
		return null;
	}
}
