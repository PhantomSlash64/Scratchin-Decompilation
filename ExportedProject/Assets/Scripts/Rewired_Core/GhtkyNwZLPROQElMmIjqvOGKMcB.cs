using System;
using Rewired;
using Rewired.Utils;
using UnityEngine;

internal class GhtkyNwZLPROQElMmIjqvOGKMcB : LVwaBKPrmEnIQzQLZNJZsvsJqPH, IDisposable, vrTHBaPgbynUQfyrVtLqUVlMqkb, HpPUYiSsBwKxKGqHrpbgrhShPgI
{
	public readonly int aumNItRblDdXZicbRkrPApteCjR;

	public readonly int beRmxTPYgeEljczGnIuTQeGMXoR;

	public readonly int EAGWFmBKpkybcagmIjuwLbeGjsr;

	public readonly int StdYsitlniAVVqdtCruyjpWnHBB;

	public readonly short[] LPdKTqUFzkEOBzUTXBwMZshhMWS;

	private readonly ButtonLoopSet tkCKkJNldSayDfKTjRHttvKhabDf;

	public readonly short[] atBhQchFMKcSezkWuPpABZJPpVnm;

	public readonly short[] rrayIcVYCgQrIdgrwAqvowoIpxh;

	private bool xwlciijKucqyJFICAlBeQdiMzfmY;

	public bool[] WOADLayhZhIKPRYLPCltJGQQdWH
	{
		get
		{
			if (tkCKkJNldSayDfKTjRHttvKhabDf.Current == null)
			{
				return null;
			}
			return tkCKkJNldSayDfKTjRHttvKhabDf.Current.effectiveValue;
		}
	}

	public int JNhAPwAUkIguzvzFCmzXXVGbDjJ => nIyzgmlOTPDIunKnZBGAUSLRKnL;

	public int ZCgpSfgJTUAyoOeHFrTeCLSnJX => aumNItRblDdXZicbRkrPApteCjR;

	public int UELWeRwRkBeAwKhzhuLbNBQtgAyd => beRmxTPYgeEljczGnIuTQeGMXoR;

	public int zPEBnjjGCJHSfslkZIFAaxoHznSx => EAGWFmBKpkybcagmIjuwLbeGjsr;

	public int PTgKavBuPxHdSpHJeIFpeZteHZh => StdYsitlniAVVqdtCruyjpWnHBB;

	public bool lzigjraNlwCRGowQevJnxMSLJjx
	{
		get
		{
			if (aumNItRblDdXZicbRkrPApteCjR <= 0 && beRmxTPYgeEljczGnIuTQeGMXoR <= 0 && EAGWFmBKpkybcagmIjuwLbeGjsr <= 0)
			{
				return StdYsitlniAVVqdtCruyjpWnHBB > 0;
			}
			return true;
		}
	}

	public InputSource CjXujTlhqNIpInDJJhdZCrePvnB => InputSource.SDL2;

	public bool VVvDugwQqcGqEPhjYBFKOHmpHAGI => xwlciijKucqyJFICAlBeQdiMzfmY;

	public GhtkyNwZLPROQElMmIjqvOGKMcB(NlsmASWTVmJsFVheQAQWfhQWLBeY nativeJoystick, jMKaPgLzGvaHTAThgsaZcxGXSyF joystickInfo)
		: this(nativeJoystick, joystickInfo, jacddwdwZMDJlZdzYQbYRxbLVqYO.QIiFjjgvNmDRWWXPiwXfgdhsPuPT)
	{
	}

	protected GhtkyNwZLPROQElMmIjqvOGKMcB(NlsmASWTVmJsFVheQAQWfhQWLBeY nativeJoystick, jMKaPgLzGvaHTAThgsaZcxGXSyF joystickInfo, jacddwdwZMDJlZdzYQbYRxbLVqYO type)
		: this(nativeJoystick, joystickInfo, type, joystickInfo.aumNItRblDdXZicbRkrPApteCjR, joystickInfo.beRmxTPYgeEljczGnIuTQeGMXoR, joystickInfo.EAGWFmBKpkybcagmIjuwLbeGjsr, joystickInfo.StdYsitlniAVVqdtCruyjpWnHBB)
	{
	}

	protected GhtkyNwZLPROQElMmIjqvOGKMcB(PTAkOWbBsmzjLtyTsWSaoadYCNW nativeDevice, jMKaPgLzGvaHTAThgsaZcxGXSyF joystickInfo, jacddwdwZMDJlZdzYQbYRxbLVqYO type, int buttonCount, int axisCount, int hatCount, int ballCount)
		: base(nativeDevice, joystickInfo, type)
	{
		aumNItRblDdXZicbRkrPApteCjR = buttonCount;
		beRmxTPYgeEljczGnIuTQeGMXoR = axisCount;
		EAGWFmBKpkybcagmIjuwLbeGjsr = hatCount;
		StdYsitlniAVVqdtCruyjpWnHBB = ballCount;
		if (axisCount > 0)
		{
			LPdKTqUFzkEOBzUTXBwMZshhMWS = new short[axisCount];
		}
		tkCKkJNldSayDfKTjRHttvKhabDf = new ButtonLoopSet(ReInput.UserData.ConfigVars.updateLoop, buttonCount);
		if (hatCount > 0)
		{
			atBhQchFMKcSezkWuPpABZJPpVnm = new short[hatCount];
		}
		if (ballCount > 0)
		{
			rrayIcVYCgQrIdgrwAqvowoIpxh = new short[ballCount * 2];
		}
	}

	public void wAlHJoEseXwZfahDSIeyAibjNOI(RncNazFAMLQgcZOFyrDAFgCxXAC P_0, byte P_1, short P_2, double P_3)
	{
		xwlciijKucqyJFICAlBeQdiMzfmY = true;
		switch (P_0)
		{
		case RncNazFAMLQgcZOFyrDAFgCxXAC.isHGkTqyOYSZKvhjDcVOXnrMZdI:
			if (P_1 < aumNItRblDdXZicbRkrPApteCjR)
			{
				tkCKkJNldSayDfKTjRHttvKhabDf.SetValue(P_1, P_2 > 0, P_3);
			}
			break;
		case RncNazFAMLQgcZOFyrDAFgCxXAC.fgSIqbILRPxyajGxXNQhuCfVtqPG:
			if (P_1 < beRmxTPYgeEljczGnIuTQeGMXoR)
			{
				LPdKTqUFzkEOBzUTXBwMZshhMWS[P_1] = P_2;
			}
			break;
		case RncNazFAMLQgcZOFyrDAFgCxXAC.XLKBiChkHTCugrTSZoFOPbEJOGrl:
			if (P_1 < EAGWFmBKpkybcagmIjuwLbeGjsr)
			{
				atBhQchFMKcSezkWuPpABZJPpVnm[P_1] = P_2;
			}
			break;
		case RncNazFAMLQgcZOFyrDAFgCxXAC.nDRXEciuWMENggejDCkzUiCagvv:
			if (P_1 < StdYsitlniAVVqdtCruyjpWnHBB)
			{
				rrayIcVYCgQrIdgrwAqvowoIpxh[P_1] = P_2;
			}
			break;
		default:
			throw new NotImplementedException();
		}
	}

	public override void mtiNfGzpXHszOwiOIAVYQuMZclV(UpdateLoopType P_0)
	{
		tkCKkJNldSayDfKTjRHttvKhabDf.SetUpdateLoop(P_0);
	}

	void vrTHBaPgbynUQfyrVtLqUVlMqkb.mtiNfGzpXHszOwiOIAVYQuMZclV(UpdateLoopType P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in mtiNfGzpXHszOwiOIAVYQuMZclV
		this.mtiNfGzpXHszOwiOIAVYQuMZclV(P_0);
	}

	public override void OAFlvPdHOjXWTvxfZdnCaGjIult()
	{
		tkCKkJNldSayDfKTjRHttvKhabDf.Current.ClearWasTrueThisFrame();
	}

	void vrTHBaPgbynUQfyrVtLqUVlMqkb.OAFlvPdHOjXWTvxfZdnCaGjIult()
	{
		//ILSpy generated this explicit interface implementation from .override directive in OAFlvPdHOjXWTvxfZdnCaGjIult
		this.OAFlvPdHOjXWTvxfZdnCaGjIult();
	}

	public float gSbFUoUKksdvWoYrVCrMmdUmQbI(int P_0)
	{
		if (P_0 < 0 || P_0 >= beRmxTPYgeEljczGnIuTQeGMXoR)
		{
			return 0f;
		}
		return pYicbOJqdpBgpgotjjdctSSMcFX(LPdKTqUFzkEOBzUTXBwMZshhMWS[P_0]);
	}

	float HpPUYiSsBwKxKGqHrpbgrhShPgI.gSbFUoUKksdvWoYrVCrMmdUmQbI(int P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in gSbFUoUKksdvWoYrVCrMmdUmQbI
		return this.gSbFUoUKksdvWoYrVCrMmdUmQbI(P_0);
	}

	public int MRJbFLqrHPkAEszrkEduwoQPPhe(int P_0)
	{
		if (P_0 < 0 || P_0 >= beRmxTPYgeEljczGnIuTQeGMXoR)
		{
			return 0;
		}
		return LPdKTqUFzkEOBzUTXBwMZshhMWS[P_0];
	}

	int HpPUYiSsBwKxKGqHrpbgrhShPgI.MRJbFLqrHPkAEszrkEduwoQPPhe(int P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in MRJbFLqrHPkAEszrkEduwoQPPhe
		return this.MRJbFLqrHPkAEszrkEduwoQPPhe(P_0);
	}

	public bool MBcFiZeZyRdrKwPqvdeFcRGWuORk(int P_0)
	{
		if (P_0 < 0 || P_0 >= aumNItRblDdXZicbRkrPApteCjR)
		{
			return false;
		}
		return tkCKkJNldSayDfKTjRHttvKhabDf.Current.effectiveValue[P_0];
	}

	bool HpPUYiSsBwKxKGqHrpbgrhShPgI.MBcFiZeZyRdrKwPqvdeFcRGWuORk(int P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in MBcFiZeZyRdrKwPqvdeFcRGWuORk
		return this.MBcFiZeZyRdrKwPqvdeFcRGWuORk(P_0);
	}

	public int jfPUflNnCZMeVqEBBFKeenCrTcU(int P_0)
	{
		if (P_0 < 0 || P_0 >= EAGWFmBKpkybcagmIjuwLbeGjsr)
		{
			return -1;
		}
		return pUNRzdcObFuUSgHnecXcGkOivsib(atBhQchFMKcSezkWuPpABZJPpVnm[P_0]);
	}

	int HpPUYiSsBwKxKGqHrpbgrhShPgI.jfPUflNnCZMeVqEBBFKeenCrTcU(int P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in jfPUflNnCZMeVqEBBFKeenCrTcU
		return this.jfPUflNnCZMeVqEBBFKeenCrTcU(P_0);
	}

	public Vector2 KchDpiWeEXdtisGMpeYqrAlEMnf(int P_0)
	{
		return Vector2.zero;
	}

	Vector2 HpPUYiSsBwKxKGqHrpbgrhShPgI.KchDpiWeEXdtisGMpeYqrAlEMnf(int P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in KchDpiWeEXdtisGMpeYqrAlEMnf
		return this.KchDpiWeEXdtisGMpeYqrAlEMnf(P_0);
	}

	protected void awmRQwCQEmgncIxRtOMQczRMMhX(NlsmASWTVmJsFVheQAQWfhQWLBeY P_0)
	{
		if (!base.LXZqqcaJgmTjdtxNIuLgtFqZePA || fIdCQKGsUXtETiYichZnMfYilrGQ.CgqkZKbNJeRmaAdYcLalEhbPCrgC(P_0) <= 0)
		{
			return;
		}
		IntPtr intPtr = fIdCQKGsUXtETiYichZnMfYilrGQ.vQJeXaUxyIBYtDYHznwfJpIDrfB(P_0);
		if (intPtr == IntPtr.Zero)
		{
			return;
		}
		if (fIdCQKGsUXtETiYichZnMfYilrGQ.YajBssqFIRfKktCiyLxWlKeRuSe(intPtr) != 0)
		{
			fIdCQKGsUXtETiYichZnMfYilrGQ.GYaEZYDRyscrOoEympMJSDXidlWH(intPtr);
			return;
		}
		wPhdBSkmMbnKLOMDJkkaZWQobpN = new WbvcuPsnqzGOJiyKlOOPSbRSVtM(intPtr);
		AqnDEDjpLFhYchkGBmDaRqugKZUS = true;
		TojhnXIpoHfpkbvYsdcGkqfnQxXr = fIdCQKGsUXtETiYichZnMfYilrGQ.qyjUkMXmetzaYyHetPHZLEhgLiD(wPhdBSkmMbnKLOMDJkkaZWQobpN) > 0;
		if (TojhnXIpoHfpkbvYsdcGkqfnQxXr)
		{
			DgKZIwUKWYpoRBbYIharycQNYrN = 2;
		}
		CfslFBbtVIUSqrAXNdJEJqJJFmYJ = new float[DgKZIwUKWYpoRBbYIharycQNYrN];
	}

	protected override void ySehTDShWdUguYcpWKPrXhSkLEt()
	{
		awmRQwCQEmgncIxRtOMQczRMMhX(pIPdbZDlhPmFqzulHLXnYJBKFfzG as NlsmASWTVmJsFVheQAQWfhQWLBeY);
	}

	protected override void zMbSwAXDwVIQsjOeufTycVWJMIxm()
	{
		if (pIPdbZDlhPmFqzulHLXnYJBKFfzG != null && pIPdbZDlhPmFqzulHLXnYJBKFfzG.IsValid)
		{
			if (!NDecJkbixZRiRdLeBNTUmoiEuvnA())
			{
				pIPdbZDlhPmFqzulHLXnYJBKFfzG.Clear();
				return;
			}
			fIdCQKGsUXtETiYichZnMfYilrGQ.rwNhRmiJmblIhFdwIIFvzDmypog(pIPdbZDlhPmFqzulHLXnYJBKFfzG);
			pIPdbZDlhPmFqzulHLXnYJBKFfzG.Clear();
		}
	}

	private float pYicbOJqdpBgpgotjjdctSSMcFX(int P_0)
	{
		if (P_0 == 0)
		{
			return 0f;
		}
		return MathTools.ValueInNewRange(P_0, -32767f, 32768f, -1f, 1f);
	}

	private int pUNRzdcObFuUSgHnecXcGkOivsib(short P_0)
	{
		return P_0 switch
		{
			0 => -1, 
			1 => 0, 
			3 => 4500, 
			2 => 9000, 
			6 => 13500, 
			4 => 18000, 
			12 => 22500, 
			8 => 27000, 
			9 => 31500, 
			_ => -1, 
		};
	}
}
