using System;

internal static class ZhzEgYNkzSQYSkAsExZjzNVVOnu
{
	public enum THjwSBimVNfknOTlrrcTuWtfmGL
	{
		HRwhOziqklijDWtMBlqDBzEDePP = 0,
		GbEfrbhqgEAlfFbdRIeEehWSXuF = 1,
		jjlbYeCxJtomCLkQbaBgdOXrsJhZ = 2
	}

	private const string JgAdeLxrznXgoXbwULqInKnHIYAh = ".*xbox[ \\-]one.*";

	private static Guid[] RjFfNnQLlHNPxqgtwrDdBtRYVIS = new Guid[6]
	{
		new Guid("02D1045E-0000-0000-0000-504944564944"),
		new Guid("02DD045E-0000-0000-0000-504944564944"),
		new Guid("02E3045E-0000-0000-0000-504944564944"),
		new Guid("DEEF045E-0000-0000-0000-504944564944"),
		new Guid("02e0045e-0000-0000-0000-504944564944"),
		new Guid("02ff045e-0000-0000-0000-504944564944")
	};

	private static string[] EQSMCsslwHBUUSMjnakXFUMAkWJC = new string[4] { "Controller (XBOX One For Windows)", "XBOX One For Windows (Controller)", "XBOX One Controller", "Xbox Bluetooth Gamepad" };

	public static string QFJFOJiyXWgrKYfnpEuAlgWfgYVB(RAOzdEPdgYzXSunXnEJayhNPEZI P_0, Guid P_1, string P_2, string P_3)
	{
		if (P_0 == null)
		{
			return string.Empty;
		}
		return CeoinftSkPZkDJSGyfOGVcUHxGc(P_0.QHBRMxWXeAijfXWAxOTnsamBcbtK, P_1, P_2, P_3) switch
		{
			THjwSBimVNfknOTlrrcTuWtfmGL.GbEfrbhqgEAlfFbdRIeEehWSXuF => "[CombinedTriggers]", 
			THjwSBimVNfknOTlrrcTuWtfmGL.jjlbYeCxJtomCLkQbaBgdOXrsJhZ => "[SplitTriggers]", 
			_ => string.Empty, 
		};
	}

	public static THjwSBimVNfknOTlrrcTuWtfmGL CeoinftSkPZkDJSGyfOGVcUHxGc(CZYFsMkvSkgWfFTKtdOnLXPfMqJK[] P_0, Guid P_1, string P_2, string P_3)
	{
		if (!FpdjMWjxNYeuTwQMrhDlVgzLxqE(P_1, P_2, P_3))
		{
			return THjwSBimVNfknOTlrrcTuWtfmGL.HRwhOziqklijDWtMBlqDBzEDePP;
		}
		for (int i = 0; i < P_0.Length; i++)
		{
			if (P_0[i].YxVFJDmgAkRgCcCvUfhmITfzYBad == 1 && !P_0[i].AWVCHCPgoJKghrszpnYHPXzQGzt && P_0[i].kEhBpsDQwgJifUrXCwflALDiuIx.MNRaihHKuqDsUzvPGSYEtAEmyqK == 53)
			{
				return THjwSBimVNfknOTlrrcTuWtfmGL.jjlbYeCxJtomCLkQbaBgdOXrsJhZ;
			}
		}
		return THjwSBimVNfknOTlrrcTuWtfmGL.GbEfrbhqgEAlfFbdRIeEehWSXuF;
	}

	public static bool FpdjMWjxNYeuTwQMrhDlVgzLxqE(Guid P_0, string P_1, string P_2)
	{
		if (Array.IndexOf(RjFfNnQLlHNPxqgtwrDdBtRYVIS, P_0) >= 0)
		{
			return true;
		}
		if (FpdjMWjxNYeuTwQMrhDlVgzLxqE(P_1))
		{
			return true;
		}
		if (FpdjMWjxNYeuTwQMrhDlVgzLxqE(P_2))
		{
			return true;
		}
		return false;
	}

	private static bool FpdjMWjxNYeuTwQMrhDlVgzLxqE(string P_0)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return false;
		}
		for (int i = 0; i < EQSMCsslwHBUUSMjnakXFUMAkWJC.Length; i++)
		{
			if (EQSMCsslwHBUUSMjnakXFUMAkWJC[i].Equals(P_0, StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
		}
		return false;
	}
}
