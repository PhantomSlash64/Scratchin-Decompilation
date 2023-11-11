using System;

internal struct kdngqMClcqqfiVJyOhtIATtwKrn
{
	private uint lLXzhOkDmRiBSwaTFAdjxNbhGqv;

	private ulong cejCKRnuLMAkPffLLPckbExisqLt;

	private static readonly bool LpsjFyrXcHAUWGqNyeCIJGJhsQmd;

	public static readonly int fnXDHADGAIKLXUikmwkYcfoOkMJD;

	static kdngqMClcqqfiVJyOhtIATtwKrn()
	{
		LpsjFyrXcHAUWGqNyeCIJGJhsQmd = IntPtr.Size == 8;
		fnXDHADGAIKLXUikmwkYcfoOkMJD = (LpsjFyrXcHAUWGqNyeCIJGJhsQmd ? 8 : 4);
	}

	public static kdngqMClcqqfiVJyOhtIATtwKrn FKTvkTXpHkegMjnoXwkHeuiNnfsp(byte[] P_0, int P_1)
	{
		kdngqMClcqqfiVJyOhtIATtwKrn result = default(kdngqMClcqqfiVJyOhtIATtwKrn);
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

	public static implicit operator uint(kdngqMClcqqfiVJyOhtIATtwKrn obj)
	{
		if (LpsjFyrXcHAUWGqNyeCIJGJhsQmd)
		{
			return (uint)obj.cejCKRnuLMAkPffLLPckbExisqLt;
		}
		return obj.lLXzhOkDmRiBSwaTFAdjxNbhGqv;
	}

	public static implicit operator ulong(kdngqMClcqqfiVJyOhtIATtwKrn obj)
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
