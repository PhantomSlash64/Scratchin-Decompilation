using System;

internal struct zUpSqpmxhDRjzPeEMOEQnpXmOmw
{
	private int lLXzhOkDmRiBSwaTFAdjxNbhGqv;

	private long cejCKRnuLMAkPffLLPckbExisqLt;

	private static readonly bool LpsjFyrXcHAUWGqNyeCIJGJhsQmd;

	public static readonly int fnXDHADGAIKLXUikmwkYcfoOkMJD;

	static zUpSqpmxhDRjzPeEMOEQnpXmOmw()
	{
		LpsjFyrXcHAUWGqNyeCIJGJhsQmd = IntPtr.Size == 8;
		fnXDHADGAIKLXUikmwkYcfoOkMJD = (LpsjFyrXcHAUWGqNyeCIJGJhsQmd ? 8 : 4);
	}

	public static zUpSqpmxhDRjzPeEMOEQnpXmOmw FKTvkTXpHkegMjnoXwkHeuiNnfsp(byte[] P_0, int P_1)
	{
		zUpSqpmxhDRjzPeEMOEQnpXmOmw result = default(zUpSqpmxhDRjzPeEMOEQnpXmOmw);
		if (LpsjFyrXcHAUWGqNyeCIJGJhsQmd)
		{
			result.cejCKRnuLMAkPffLLPckbExisqLt = BitConverter.ToInt64(P_0, P_1);
		}
		else
		{
			result.lLXzhOkDmRiBSwaTFAdjxNbhGqv = BitConverter.ToInt32(P_0, P_1);
		}
		return result;
	}

	public static implicit operator int(zUpSqpmxhDRjzPeEMOEQnpXmOmw obj)
	{
		if (LpsjFyrXcHAUWGqNyeCIJGJhsQmd)
		{
			return (int)obj.cejCKRnuLMAkPffLLPckbExisqLt;
		}
		return obj.lLXzhOkDmRiBSwaTFAdjxNbhGqv;
	}

	public static implicit operator long(zUpSqpmxhDRjzPeEMOEQnpXmOmw obj)
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
