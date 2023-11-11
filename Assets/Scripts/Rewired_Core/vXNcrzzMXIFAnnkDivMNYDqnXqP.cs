using System;
using System.Reflection;
using Rewired;

[DefaultMember("Item")]
internal struct vXNcrzzMXIFAnnkDivMNYDqnXqP : IEquatable<vXNcrzzMXIFAnnkDivMNYDqnXqP>
{
	public ModifierKey pBOItftNnYIXiGHBBoNDskFSbdJg;

	public ModifierKey IwdxopucklVhghZuedOEVRAToqn;

	public ModifierKey auChswPsWWQTcnYMenvrOHMdkZD;

	private ModifierKey mFldAkWEWmHykRxiejPmGewpCka
	{
		get
		{
			if (index <= 0)
			{
				return pBOItftNnYIXiGHBBoNDskFSbdJg;
			}
			if (index == 1)
			{
				return IwdxopucklVhghZuedOEVRAToqn;
			}
			if (index >= 2)
			{
				return auChswPsWWQTcnYMenvrOHMdkZD;
			}
			return pBOItftNnYIXiGHBBoNDskFSbdJg;
		}
		set
		{
			if (index <= 0)
			{
				pBOItftNnYIXiGHBBoNDskFSbdJg = value;
			}
			if (index == 1)
			{
				IwdxopucklVhghZuedOEVRAToqn = value;
			}
			if (index >= 2)
			{
				auChswPsWWQTcnYMenvrOHMdkZD = value;
			}
		}
	}

	public vXNcrzzMXIFAnnkDivMNYDqnXqP(ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3)
	{
		pBOItftNnYIXiGHBBoNDskFSbdJg = modifierKey1;
		IwdxopucklVhghZuedOEVRAToqn = modifierKey2;
		auChswPsWWQTcnYMenvrOHMdkZD = modifierKey3;
	}

	public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
	{
		if (pBOItftNnYIXiGHBBoNDskFSbdJg != 0)
		{
			pBOItftNnYIXiGHBBoNDskFSbdJg = ModifierKey.None;
		}
		if (IwdxopucklVhghZuedOEVRAToqn != 0)
		{
			IwdxopucklVhghZuedOEVRAToqn = ModifierKey.None;
		}
		if (auChswPsWWQTcnYMenvrOHMdkZD != 0)
		{
			auChswPsWWQTcnYMenvrOHMdkZD = ModifierKey.None;
		}
	}

	public static vXNcrzzMXIFAnnkDivMNYDqnXqP XkSYUAelKYptqQSiUpoDCQZaJiY(ModifierKeyFlags P_0)
	{
		vXNcrzzMXIFAnnkDivMNYDqnXqP result = default(vXNcrzzMXIFAnnkDivMNYDqnXqP);
		int num = 0;
		if (Keyboard.ModifierKeyFlagsContain(P_0, ModifierKey.Control))
		{
			result.set_Item(num++, ModifierKey.Control);
		}
		if (Keyboard.ModifierKeyFlagsContain(P_0, ModifierKey.Command))
		{
			result.set_Item(num++, ModifierKey.Command);
		}
		if (Keyboard.ModifierKeyFlagsContain(P_0, ModifierKey.Alt))
		{
			result.set_Item(num++, ModifierKey.Alt);
		}
		if (num >= 3)
		{
			return result;
		}
		if (Keyboard.ModifierKeyFlagsContain(P_0, ModifierKey.Shift))
		{
			result.set_Item(num++, ModifierKey.Shift);
		}
		return result;
	}

	public bool Equals(vXNcrzzMXIFAnnkDivMNYDqnXqP other)
	{
		if (pBOItftNnYIXiGHBBoNDskFSbdJg == other.pBOItftNnYIXiGHBBoNDskFSbdJg && IwdxopucklVhghZuedOEVRAToqn == other.IwdxopucklVhghZuedOEVRAToqn)
		{
			return auChswPsWWQTcnYMenvrOHMdkZD == other.auChswPsWWQTcnYMenvrOHMdkZD;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == null || !(obj is vXNcrzzMXIFAnnkDivMNYDqnXqP))
		{
			return false;
		}
		return Equals((vXNcrzzMXIFAnnkDivMNYDqnXqP)obj);
	}

	public override int GetHashCode()
	{
		int num = 17;
		num = num * 29 + pBOItftNnYIXiGHBBoNDskFSbdJg.GetHashCode();
		num = num * 29 + IwdxopucklVhghZuedOEVRAToqn.GetHashCode();
		return num * 29 + auChswPsWWQTcnYMenvrOHMdkZD.GetHashCode();
	}

	public static bool operator ==(vXNcrzzMXIFAnnkDivMNYDqnXqP a, vXNcrzzMXIFAnnkDivMNYDqnXqP b)
	{
		if (a.pBOItftNnYIXiGHBBoNDskFSbdJg == b.pBOItftNnYIXiGHBBoNDskFSbdJg && a.IwdxopucklVhghZuedOEVRAToqn == b.IwdxopucklVhghZuedOEVRAToqn)
		{
			return a.auChswPsWWQTcnYMenvrOHMdkZD == b.auChswPsWWQTcnYMenvrOHMdkZD;
		}
		return false;
	}

	public static bool operator !=(vXNcrzzMXIFAnnkDivMNYDqnXqP a, vXNcrzzMXIFAnnkDivMNYDqnXqP b)
	{
		return !(a == b);
	}
}
