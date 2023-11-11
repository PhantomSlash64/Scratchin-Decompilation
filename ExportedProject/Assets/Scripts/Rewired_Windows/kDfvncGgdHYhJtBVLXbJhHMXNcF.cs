using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class kDfvncGgdHYhJtBVLXbJhHMXNcF : wiOxVhQlrPDIDeswmspbUDPzZUB
{
	[CompilerGenerated]
	private GYKvFxvDRJJUgpakzmgpziYXZjq[] blsxkqXqbjzlsKkfBIYxsLRCXrO;

	public GYKvFxvDRJJUgpakzmgpziYXZjq[] tRzHfocKeeOQUXlFcRebERDYdfL
	{
		[CompilerGenerated]
		get
		{
			return blsxkqXqbjzlsKkfBIYxsLRCXrO;
		}
		[CompilerGenerated]
		set
		{
			blsxkqXqbjzlsKkfBIYxsLRCXrO = value;
		}
	}

	public unsafe override int OAxxiRRJUwaMLNmFaPAXfzgmRpb
	{
		get
		{
			if (tRzHfocKeeOQUXlFcRebERDYdfL == null)
			{
				return 0;
			}
			return tRzHfocKeeOQUXlFcRebERDYdfL.Length * sizeof(GYKvFxvDRJJUgpakzmgpziYXZjq);
		}
	}

	protected unsafe override wiOxVhQlrPDIDeswmspbUDPzZUB fMyDiEWbVoVVRklJtHYIUVjCxXv(int P_0, IntPtr P_1)
	{
		if (P_0 <= 0 || P_0 % sizeof(GYKvFxvDRJJUgpakzmgpziYXZjq) != 0)
		{
			return null;
		}
		int num = P_0 / sizeof(GYKvFxvDRJJUgpakzmgpziYXZjq);
		tRzHfocKeeOQUXlFcRebERDYdfL = new GYKvFxvDRJJUgpakzmgpziYXZjq[num];
		fixed (GYKvFxvDRJJUgpakzmgpziYXZjq* ptr = tRzHfocKeeOQUXlFcRebERDYdfL)
		{
			WdABqngzfChtFJSJGeObIpoDQOet.rdErrbQiKPgCHcdXppfcnDcrDPZ((IntPtr)ptr, P_1, WdABqngzfChtFJSJGeObIpoDQOet.BSrOqfyRTTNMvjOTEoJRNXUWoPI<GYKvFxvDRJJUgpakzmgpziYXZjq>() * tRzHfocKeeOQUXlFcRebERDYdfL.Length);
		}
		return this;
	}

	internal unsafe override IntPtr otrcokARnroruTmNVJikhZXoofTz()
	{
		if (OAxxiRRJUwaMLNmFaPAXfzgmRpb == 0)
		{
			return IntPtr.Zero;
		}
		IntPtr intPtr = Marshal.AllocHGlobal(OAxxiRRJUwaMLNmFaPAXfzgmRpb);
		fixed (GYKvFxvDRJJUgpakzmgpziYXZjq* ptr = tRzHfocKeeOQUXlFcRebERDYdfL)
		{
			WdABqngzfChtFJSJGeObIpoDQOet.rdErrbQiKPgCHcdXppfcnDcrDPZ(intPtr, (IntPtr)ptr, WdABqngzfChtFJSJGeObIpoDQOet.BSrOqfyRTTNMvjOTEoJRNXUWoPI<GYKvFxvDRJJUgpakzmgpziYXZjq>() * tRzHfocKeeOQUXlFcRebERDYdfL.Length);
		}
		return intPtr;
	}
}
