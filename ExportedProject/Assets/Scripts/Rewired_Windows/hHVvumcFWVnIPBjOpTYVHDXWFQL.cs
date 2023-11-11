using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct hHVvumcFWVnIPBjOpTYVHDXWFQL
{
	[FieldOffset(0)]
	private int lLXzhOkDmRiBSwaTFAdjxNbhGqv;

	[FieldOffset(0)]
	private long cejCKRnuLMAkPffLLPckbExisqLt;

	[FieldOffset(0)]
	private IntPtr wtzezjAWuBqlIQNEsoDpAuPIiUFH;

	private static readonly bool LpsjFyrXcHAUWGqNyeCIJGJhsQmd;

	public static readonly int fnXDHADGAIKLXUikmwkYcfoOkMJD;

	static hHVvumcFWVnIPBjOpTYVHDXWFQL()
	{
		fnXDHADGAIKLXUikmwkYcfoOkMJD = IntPtr.Size;
		LpsjFyrXcHAUWGqNyeCIJGJhsQmd = fnXDHADGAIKLXUikmwkYcfoOkMJD == 8;
	}

	public static hHVvumcFWVnIPBjOpTYVHDXWFQL FKTvkTXpHkegMjnoXwkHeuiNnfsp(byte[] P_0, int P_1)
	{
		hHVvumcFWVnIPBjOpTYVHDXWFQL result = default(hHVvumcFWVnIPBjOpTYVHDXWFQL);
		if (LpsjFyrXcHAUWGqNyeCIJGJhsQmd)
		{
			result.cejCKRnuLMAkPffLLPckbExisqLt = BitConverter.ToInt64(P_0, P_1);
			result.wtzezjAWuBqlIQNEsoDpAuPIiUFH = new IntPtr(result.cejCKRnuLMAkPffLLPckbExisqLt);
		}
		else
		{
			result.lLXzhOkDmRiBSwaTFAdjxNbhGqv = BitConverter.ToInt32(P_0, P_1);
			result.wtzezjAWuBqlIQNEsoDpAuPIiUFH = new IntPtr(result.lLXzhOkDmRiBSwaTFAdjxNbhGqv);
		}
		return result;
	}

	public static implicit operator hHVvumcFWVnIPBjOpTYVHDXWFQL(IntPtr obj)
	{
		hHVvumcFWVnIPBjOpTYVHDXWFQL result = default(hHVvumcFWVnIPBjOpTYVHDXWFQL);
		result.wtzezjAWuBqlIQNEsoDpAuPIiUFH = obj;
		if (LpsjFyrXcHAUWGqNyeCIJGJhsQmd)
		{
			result.cejCKRnuLMAkPffLLPckbExisqLt = obj.ToInt64();
		}
		else
		{
			result.lLXzhOkDmRiBSwaTFAdjxNbhGqv = obj.ToInt32();
		}
		return result;
	}

	public static implicit operator IntPtr(hHVvumcFWVnIPBjOpTYVHDXWFQL obj)
	{
		return obj.wtzezjAWuBqlIQNEsoDpAuPIiUFH;
	}

	public override string ToString()
	{
		if (LpsjFyrXcHAUWGqNyeCIJGJhsQmd)
		{
			return cejCKRnuLMAkPffLLPckbExisqLt.ToString();
		}
		return lLXzhOkDmRiBSwaTFAdjxNbhGqv.ToString();
	}
}
