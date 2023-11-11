using System;

internal struct rpvedqmUdQEFSzNtajbluEmPcvjE
{
	private uint lLXzhOkDmRiBSwaTFAdjxNbhGqv;

	private ulong cejCKRnuLMAkPffLLPckbExisqLt;

	private static readonly bool LpsjFyrXcHAUWGqNyeCIJGJhsQmd;

	public static readonly int fnXDHADGAIKLXUikmwkYcfoOkMJD;

	static rpvedqmUdQEFSzNtajbluEmPcvjE()
	{
		LpsjFyrXcHAUWGqNyeCIJGJhsQmd = IntPtr.Size == 8;
		fnXDHADGAIKLXUikmwkYcfoOkMJD = (LpsjFyrXcHAUWGqNyeCIJGJhsQmd ? 8 : 4);
	}

	public static rpvedqmUdQEFSzNtajbluEmPcvjE FKTvkTXpHkegMjnoXwkHeuiNnfsp(byte[] P_0, int P_1)
	{
		rpvedqmUdQEFSzNtajbluEmPcvjE result = default(rpvedqmUdQEFSzNtajbluEmPcvjE);
		if (LpsjFyrXcHAUWGqNyeCIJGJhsQmd)
		{
			result.cejCKRnuLMAkPffLLPckbExisqLt = BitConverter.ToUInt64(P_0, P_1);
		}
		else
		{
			result.lLXzhOkDmRiBSwaTFAdjxNbhGqv = BitConverter.ToUInt32(P_0, P_1);
		}
		return result;
	}

	public static implicit operator uint(rpvedqmUdQEFSzNtajbluEmPcvjE obj)
	{
		if (LpsjFyrXcHAUWGqNyeCIJGJhsQmd)
		{
			return (uint)obj.cejCKRnuLMAkPffLLPckbExisqLt;
		}
		return obj.lLXzhOkDmRiBSwaTFAdjxNbhGqv;
	}

	public static implicit operator ulong(rpvedqmUdQEFSzNtajbluEmPcvjE obj)
	{
		if (LpsjFyrXcHAUWGqNyeCIJGJhsQmd)
		{
			return obj.cejCKRnuLMAkPffLLPckbExisqLt;
		}
		return obj.lLXzhOkDmRiBSwaTFAdjxNbhGqv;
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
