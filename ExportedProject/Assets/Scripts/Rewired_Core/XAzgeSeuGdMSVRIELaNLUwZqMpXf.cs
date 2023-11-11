using System;
using Rewired;

internal struct XAzgeSeuGdMSVRIELaNLUwZqMpXf : IEquatable<XAzgeSeuGdMSVRIELaNLUwZqMpXf>
{
	public KeyboardKeyCode KWAQEtwiTWoCdqnrZocbehZgxps;

	public ModifierKey pBOItftNnYIXiGHBBoNDskFSbdJg;

	public ModifierKey IwdxopucklVhghZuedOEVRAToqn;

	public ModifierKey auChswPsWWQTcnYMenvrOHMdkZD;

	public XAzgeSeuGdMSVRIELaNLUwZqMpXf(KeyboardKeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3)
	{
		KWAQEtwiTWoCdqnrZocbehZgxps = keyCode;
		pBOItftNnYIXiGHBBoNDskFSbdJg = modifierKey1;
		IwdxopucklVhghZuedOEVRAToqn = modifierKey2;
		auChswPsWWQTcnYMenvrOHMdkZD = modifierKey3;
	}

	public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
	{
		if (KWAQEtwiTWoCdqnrZocbehZgxps != 0)
		{
			KWAQEtwiTWoCdqnrZocbehZgxps = KeyboardKeyCode.None;
		}
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

	public bool Equals(XAzgeSeuGdMSVRIELaNLUwZqMpXf other)
	{
		if (KWAQEtwiTWoCdqnrZocbehZgxps == other.KWAQEtwiTWoCdqnrZocbehZgxps && pBOItftNnYIXiGHBBoNDskFSbdJg == other.pBOItftNnYIXiGHBBoNDskFSbdJg && IwdxopucklVhghZuedOEVRAToqn == other.IwdxopucklVhghZuedOEVRAToqn)
		{
			return auChswPsWWQTcnYMenvrOHMdkZD == other.auChswPsWWQTcnYMenvrOHMdkZD;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (obj == null || !(obj is XAzgeSeuGdMSVRIELaNLUwZqMpXf))
		{
			return false;
		}
		return Equals((XAzgeSeuGdMSVRIELaNLUwZqMpXf)obj);
	}

	public override int GetHashCode()
	{
		int num = 17;
		num = num * 29 + KWAQEtwiTWoCdqnrZocbehZgxps.GetHashCode();
		num = num * 29 + pBOItftNnYIXiGHBBoNDskFSbdJg.GetHashCode();
		num = num * 29 + IwdxopucklVhghZuedOEVRAToqn.GetHashCode();
		return num * 29 + auChswPsWWQTcnYMenvrOHMdkZD.GetHashCode();
	}

	public static bool operator ==(XAzgeSeuGdMSVRIELaNLUwZqMpXf a, XAzgeSeuGdMSVRIELaNLUwZqMpXf b)
	{
		if (a.KWAQEtwiTWoCdqnrZocbehZgxps == b.KWAQEtwiTWoCdqnrZocbehZgxps && a.pBOItftNnYIXiGHBBoNDskFSbdJg == b.pBOItftNnYIXiGHBBoNDskFSbdJg && a.IwdxopucklVhghZuedOEVRAToqn == b.IwdxopucklVhghZuedOEVRAToqn)
		{
			return a.auChswPsWWQTcnYMenvrOHMdkZD == b.auChswPsWWQTcnYMenvrOHMdkZD;
		}
		return false;
	}

	public static bool operator !=(XAzgeSeuGdMSVRIELaNLUwZqMpXf a, XAzgeSeuGdMSVRIELaNLUwZqMpXf b)
	{
		return !(a == b);
	}
}
