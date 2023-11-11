using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit, Pack = 1)]
internal struct EewfJPiHasEmIcMTTMpQEfUhPRej
{
	[FieldOffset(0)]
	private uint lLXzhOkDmRiBSwaTFAdjxNbhGqv;

	[FieldOffset(0)]
	private ulong cejCKRnuLMAkPffLLPckbExisqLt;

	[FieldOffset(0)]
	private IntPtr wtzezjAWuBqlIQNEsoDpAuPIiUFH;

	private static readonly bool LpsjFyrXcHAUWGqNyeCIJGJhsQmd;

	public static readonly int fnXDHADGAIKLXUikmwkYcfoOkMJD;

	static EewfJPiHasEmIcMTTMpQEfUhPRej()
	{
		fnXDHADGAIKLXUikmwkYcfoOkMJD = IntPtr.Size;
		LpsjFyrXcHAUWGqNyeCIJGJhsQmd = fnXDHADGAIKLXUikmwkYcfoOkMJD == 8;
	}

	public static EewfJPiHasEmIcMTTMpQEfUhPRej FKTvkTXpHkegMjnoXwkHeuiNnfsp(byte[] P_0, int P_1)
	{
		EewfJPiHasEmIcMTTMpQEfUhPRej result = default(EewfJPiHasEmIcMTTMpQEfUhPRej);
		if (LpsjFyrXcHAUWGqNyeCIJGJhsQmd)
		{
			result.cejCKRnuLMAkPffLLPckbExisqLt = BitConverter.ToUInt64(P_0, P_1);
			result.wtzezjAWuBqlIQNEsoDpAuPIiUFH = new IntPtr((long)result.cejCKRnuLMAkPffLLPckbExisqLt);
		}
		else
		{
			result.lLXzhOkDmRiBSwaTFAdjxNbhGqv = BitConverter.ToUInt32(P_0, P_1);
			result.wtzezjAWuBqlIQNEsoDpAuPIiUFH = new IntPtr((int)result.lLXzhOkDmRiBSwaTFAdjxNbhGqv);
		}
		return result;
	}

	public static implicit operator IntPtr(EewfJPiHasEmIcMTTMpQEfUhPRej obj)
	{
		return obj.wtzezjAWuBqlIQNEsoDpAuPIiUFH;
	}

	public static implicit operator EewfJPiHasEmIcMTTMpQEfUhPRej(IntPtr obj)
	{
		EewfJPiHasEmIcMTTMpQEfUhPRej result = default(EewfJPiHasEmIcMTTMpQEfUhPRej);
		result.wtzezjAWuBqlIQNEsoDpAuPIiUFH = obj;
		if (LpsjFyrXcHAUWGqNyeCIJGJhsQmd)
		{
			result.cejCKRnuLMAkPffLLPckbExisqLt = (ulong)obj.ToInt64();
		}
		else
		{
			result.lLXzhOkDmRiBSwaTFAdjxNbhGqv = (uint)obj.ToInt32();
		}
		return result;
	}

	public override string ToString()
	{
		if (LpsjFyrXcHAUWGqNyeCIJGJhsQmd)
		{
			return cejCKRnuLMAkPffLLPckbExisqLt.ToString();
		}
		return lLXzhOkDmRiBSwaTFAdjxNbhGqv.ToString();
	}

	public int GKKhtLNbvDBTmFgUzEAoIxHlPjY()
	{
		if (LpsjFyrXcHAUWGqNyeCIJGJhsQmd)
		{
			return (int)cejCKRnuLMAkPffLLPckbExisqLt;
		}
		return (int)lLXzhOkDmRiBSwaTFAdjxNbhGqv;
	}
}
