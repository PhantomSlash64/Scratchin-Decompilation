using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired;
using Rewired.Config;
using Rewired.Data;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;

internal sealed class uhjoXbTonsTOuVJOQAQlbMAgzIYW : IDisposable
{
	public enum ahVxwCWbvzkmEHUwKowKMoJSsbi
	{
		wBCwGpigkQubfSiQoCKeOYOsLuN = 0,
		LbXKlirWfYnaOPMxjOZLYKvqtyr = 1
	}

	private class pINKUSpukJHKVoGbaHclkMBdaHA
	{
		public ADictionary<int, InputBehavior> niSwIGuixCCwVvwckEvgBcZHWRr;

		public List<InputBehavior> HvKvadCgbnXngsjplWXUDmtVjkL;

		public IList<InputBehavior> EaRHifAEJQNKbzKzqcwAdchxlQxK;

		public pINKUSpukJHKVoGbaHclkMBdaHA(List<InputBehavior> behaviors)
		{
			HvKvadCgbnXngsjplWXUDmtVjkL = new List<InputBehavior>(behaviors.Count);
			niSwIGuixCCwVvwckEvgBcZHWRr = new ADictionary<int, InputBehavior>();
			int num = 0;
			for (int i = 0; i < behaviors.Count; i++)
			{
				InputBehavior inputBehavior = behaviors[i].Clone();
				niSwIGuixCCwVvwckEvgBcZHWRr.Add(behaviors[i].id, inputBehavior);
				HvKvadCgbnXngsjplWXUDmtVjkL.Add(inputBehavior);
				num++;
			}
			EaRHifAEJQNKbzKzqcwAdchxlQxK = new ReadOnlyCollection<InputBehavior>(HvKvadCgbnXngsjplWXUDmtVjkL);
		}

		public InputBehavior eRbhnNeZqHZdHeiDXcTGTjbKoqJC(int P_0)
		{
			if (HvKvadCgbnXngsjplWXUDmtVjkL.Count == 0)
			{
				return null;
			}
			niSwIGuixCCwVvwckEvgBcZHWRr.TryGetValue(P_0, out var value);
			if (value == null)
			{
				return HvKvadCgbnXngsjplWXUDmtVjkL[0];
			}
			return value;
		}
	}

	private List<Joystick> XJgBIdbckKopkMUCjQyCdEdMrKam;

	private List<Joystick> scAOYIaxtkYadmnsGNMHXtrLRQf;

	private List<CustomController> wMZbJMpWrXVIfpZsQnOfzxvuAVP;

	private List<Controller> eNiCSwoUMQsiLCocierOoueRjQH;

	private ReadOnlyCollection<Controller> oFeUolOgowIeACPgAzfgqXgpdYw;

	private Keyboard NwgwDBihqBfhaFpOSpkapYWfrwcQ;

	private Mouse ojmdTJoYFMPLFmIeEmAuAwjFqsY;

	private ConfigVars wsqAVTjIqNDRqGlAEGJnDQDDBDPp;

	private XrsxaFoSedDmSEVIidqjOjugISoF[] ptAcOtHKrPhykgrmlKDfLBYcJZZ;

	private XrsxaFoSedDmSEVIidqjOjugISoF[] yvTznuzgWgQMkUPMHeFIRgPbaxv;

	private XrsxaFoSedDmSEVIidqjOjugISoF[,] RFUxjzYvBiGItzIesdxvgyyjHDiI;

	private RNWQZBxFpDLQTySzjFNrTBtiTEt uOGaBKJMisKaCznzyctOFAMOVzwY;

	private pvaGWIdSyISJSADPBlPBFIORiqM TQSEkBLukTtWlNVwxdHXLDGIknW;

	private pvaGWIdSyISJSADPBlPBFIORiqM[] CkQMcIhNBUOwfiKXVNnpZSGMloV;

	private global::BiRFLNGUJJvTJAuBDTeHgCjFkqdQ<ActiveControllerChangedDelegate> gnZoXverGEbCLAaotJdLyajaDkp;

	private global::BiRFLNGUJJvTJAuBDTeHgCjFkqdQ<PlayerActiveControllerChangedDelegate> gGmcTOCXSGPzjCtDjgsQGSvHWPJ;

	private global::BiRFLNGUJJvTJAuBDTeHgCjFkqdQ<PlayerActiveControllerChangedDelegate>[] wPElXqtZiDHaVHVPbcRpePMCxqJ;

	private ADictionary<int, pINKUSpukJHKVoGbaHclkMBdaHA> ebkdByYRfrQYsImkpRKbAxLruBU;

	private readonly wochuutpqUYXkdPLzqHhRFuJCAO dkugfFkVCtTWFFqVQkfYWmwUgQB;

	private IList<Joystick> ZhuKYebGpOThmTycZdewIBuSYCv;

	private IList<CustomController> BWoDLmhFuQJGaTSeyguReaoBqVJ;

	private int mKEKPOFFmsOJwYcjbJUukukpYWM;

	private bool nCHYhyJVuOgauyGTGcWtTfTJbDs;

	private bool avpDufEKpukyhnaQGdNwdewKzys;

	private bool wKhxmMQRAWCSxLHwaGXuzxzwFkD;

	private IUnifiedKeyboardSource coprZjKiqRUtSLqrKdiaFdyEHjBe;

	private IUnifiedMouseSource TYTuZTCRPEHOAJIPdWPCxdgAjnp;

	private int TpanHfdVChcvhgMyoXJhsQwEiTT;

	private kLMNgAaaWPjwLSfBhKqJsCvkZws JLezATTKNEMVFfHVAgRNIpvVfYV;

	private IgaBaIZucbxpplxyQFPTbarjdUW kRIMscNTqYOjJDgtnNDWfmLNvzj;

	private int NLEpalNfODFjJdDoCFTTlDEgNFWP;

	private int rwHTLHmPeQUKdXrAUDBtBNrghsN;

	private Action<int, ControllerDataUpdater> ywSdcyZBDhBYhakOEfgraQwkfYQn;

	private Action<bool, int, int> yeGXRmkrxqosfNMkOYgVyoYHJsp;

	private Action<ControllerStatusChangedEventArgs> zEFiqMeiOoYZBUgQJhNYImDiwIbD;

	private Action<ControllerType, int> yBxAGTiOccJapYJNFgWPxMrRDUIE;

	private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

	public IList<Joystick> QuGhzrzWRShGlIBQnTYoDJgwRuJ => ZhuKYebGpOThmTycZdewIBuSYCv;

	public List<Joystick> KzwjLjKtzsrAZVRTpjeHJpwqqOz => XJgBIdbckKopkMUCjQyCdEdMrKam;

	public int XIizDAIvfXWSeeEunnkOyCetKzC => XJgBIdbckKopkMUCjQyCdEdMrKam.Count;

	public Mouse iBsunrzpmNRGjincwoFXBCjHvrY => ojmdTJoYFMPLFmIeEmAuAwjFqsY;

	public Keyboard VptHLZXdJfMsrxxJFwCBsNGGFnMF => NwgwDBihqBfhaFpOSpkapYWfrwcQ;

	public IList<CustomController> UdNZzQLwzZqRhoPLnGarHXcAtGx => BWoDLmhFuQJGaTSeyguReaoBqVJ;

	public List<CustomController> FjMbNdBvFikIjTupQITuVXERjHo => wMZbJMpWrXVIfpZsQnOfzxvuAVP;

	public int XMEhzWyjczynJhPspwNBRqhUnS => wMZbJMpWrXVIfpZsQnOfzxvuAVP.Count;

	public IList<Controller> QzgERmDVGIXnuuyqvtyKFDdIeFF => oFeUolOgowIeACPgAzfgqXgpdYw;

	public int GqxgSOBfzUXDMaSlhNOHGJqoAwd => eNiCSwoUMQsiLCocierOoueRjQH.Count;

	private int IXDxqIfLvZlLggepywsaGShJUub
	{
		get
		{
			int tpanHfdVChcvhgMyoXJhsQwEiTT = TpanHfdVChcvhgMyoXJhsQwEiTT;
			TpanHfdVChcvhgMyoXJhsQwEiTT++;
			if (TpanHfdVChcvhgMyoXJhsQwEiTT >= int.MaxValue)
			{
				TpanHfdVChcvhgMyoXJhsQwEiTT = 0;
			}
			return tpanHfdVChcvhgMyoXJhsQwEiTT;
		}
	}

	public event Action<ControllerStatusChangedEventArgs> bpcdexfyaquuCBGdoCpSVMUiQgQi
	{
		add
		{
			zEFiqMeiOoYZBUgQJhNYImDiwIbD = (Action<ControllerStatusChangedEventArgs>)Delegate.Combine(zEFiqMeiOoYZBUgQJhNYImDiwIbD, value);
		}
		remove
		{
			zEFiqMeiOoYZBUgQJhNYImDiwIbD = (Action<ControllerStatusChangedEventArgs>)Delegate.Remove(zEFiqMeiOoYZBUgQJhNYImDiwIbD, value);
		}
	}

	public event Action<ControllerType, int> xVuJfHacqKOiraKRiMMvWvLiSIl
	{
		add
		{
			yBxAGTiOccJapYJNFgWPxMrRDUIE = (Action<ControllerType, int>)Delegate.Combine(yBxAGTiOccJapYJNFgWPxMrRDUIE, value);
		}
		remove
		{
			yBxAGTiOccJapYJNFgWPxMrRDUIE = (Action<ControllerType, int>)Delegate.Remove(yBxAGTiOccJapYJNFgWPxMrRDUIE, value);
		}
	}

	public uhjoXbTonsTOuVJOQAQlbMAgzIYW(ConfigVars configVars, PlatformInputManager inputManager)
	{
		wsqAVTjIqNDRqGlAEGJnDQDDBDPp = configVars;
		mKEKPOFFmsOJwYcjbJUukukpYWM = 0;
		nCHYhyJVuOgauyGTGcWtTfTJbDs = UnityTools.isAndroidPlatform;
		eNiCSwoUMQsiLCocierOoueRjQH = new List<Controller>(10);
		oFeUolOgowIeACPgAzfgqXgpdYw = new ReadOnlyCollection<Controller>(eNiCSwoUMQsiLCocierOoueRjQH);
		IUnifiedKeyboardSource unifiedKeyboardSource = inputManager.GetUnifiedKeyboardSource();
		if (unifiedKeyboardSource == null)
		{
			unifiedKeyboardSource = (coprZjKiqRUtSLqrKdiaFdyEHjBe = new UnityUnifiedKeyboardSource());
		}
		NwgwDBihqBfhaFpOSpkapYWfrwcQ = new Keyboard("Keyboard", unifiedKeyboardSource);
		eNiCSwoUMQsiLCocierOoueRjQH.Add(NwgwDBihqBfhaFpOSpkapYWfrwcQ);
		IUnifiedMouseSource unifiedMouseSource = inputManager.GetUnifiedMouseSource();
		if (unifiedMouseSource == null)
		{
			unifiedMouseSource = (TYTuZTCRPEHOAJIPdWPCxdgAjnp = new UnityUnifiedMouseSource());
		}
		ojmdTJoYFMPLFmIeEmAuAwjFqsY = new Mouse("Mouse", unifiedMouseSource);
		eNiCSwoUMQsiLCocierOoueRjQH.Add(ojmdTJoYFMPLFmIeEmAuAwjFqsY);
		uOGaBKJMisKaCznzyctOFAMOVzwY = new RNWQZBxFpDLQTySzjFNrTBtiTEt(configVars.updateLoop, NwgwDBihqBfhaFpOSpkapYWfrwcQ);
		NwgwDBihqBfhaFpOSpkapYWfrwcQ.EnabledStateChangedEvent += XPiUpkfgEDeCIccYHKlejzDxiCb;
		NwgwDBihqBfhaFpOSpkapYWfrwcQ.enabled = !configVars.GetPlatformVar_disableKeyboard();
		jSernrZtwfgFWhWGiBVhaYtxNfl.skeOSBSqSPGPnIZySfEhxuCHbTXM();
		dkugfFkVCtTWFFqVQkfYWmwUgQB = new wochuutpqUYXkdPLzqHhRFuJCAO(UnityTools.externalTools.GetControllerTemplateTypes(), UnityTools.externalTools.GetControllerTemplateInterfaceTypes());
		dkugfFkVCtTWFFqVQkfYWmwUgQB.rXfrpsKYmqSvVJAFxhmUjsiGnVlp(NwgwDBihqBfhaFpOSpkapYWfrwcQ);
		dkugfFkVCtTWFFqVQkfYWmwUgQB.rXfrpsKYmqSvVJAFxhmUjsiGnVlp(ojmdTJoYFMPLFmIeEmAuAwjFqsY);
		ReInput.ApplicationFocusChangedEvent += gaVcyOUkQcFnMOoDshSRsfGlDmS;
	}

	public void ijQPrfbohIDtyfCSvLMVhrlmSpB(Action<int, ControllerDataUpdater> P_0, List<InputBehavior> P_1)
	{
		ywSdcyZBDhBYhakOEfgraQwkfYQn = P_0;
		ijQPrfbohIDtyfCSvLMVhrlmSpB(P_1);
	}

	public void mtiNfGzpXHszOwiOIAVYQuMZclV(UpdateLoopType P_0)
	{
		jSernrZtwfgFWhWGiBVhaYtxNfl.oQcTSAoJFGLAsIpqhKNaiLZrNmQ(P_0);
		if (NwgwDBihqBfhaFpOSpkapYWfrwcQ.enabled)
		{
			uOGaBKJMisKaCznzyctOFAMOVzwY.mtiNfGzpXHszOwiOIAVYQuMZclV(P_0);
		}
		wjuFVrKljBJdBEXBOvRdndqtcVrJ(P_0);
		PtigViSzVvGVIFRsHSxZSXaJntA(P_0);
		jSernrZtwfgFWhWGiBVhaYtxNfl.OAFlvPdHOjXWTvxfZdnCaGjIult(P_0, ReInput.currentFrame);
		if (wKhxmMQRAWCSxLHwaGXuzxzwFkD)
		{
			DVcBuweBsYWbEtCWKHggiwVQRRN();
		}
	}

	public XrsxaFoSedDmSEVIidqjOjugISoF XPToosqqXMRHQrnQiuecVwOHVUJ(int P_0, string P_1, bool P_2)
	{
		int num = JLezATTKNEMVFfHVAgRNIpvVfYV.eaOrStrSOuOlEEMmganiuTHlvbL(P_1, P_2);
		if (num < 0)
		{
			return null;
		}
		if (P_0 == 9999999)
		{
			return yvTznuzgWgQMkUPMHeFIRgPbaxv[num];
		}
		if (P_0 < 0 || P_0 >= NLEpalNfODFjJdDoCFTTlDEgNFWP)
		{
			return null;
		}
		return RFUxjzYvBiGItzIesdxvgyyjHDiI[P_0, num];
	}

	public XrsxaFoSedDmSEVIidqjOjugISoF XPToosqqXMRHQrnQiuecVwOHVUJ(int P_0, int P_1, bool P_2)
	{
		int num = JLezATTKNEMVFfHVAgRNIpvVfYV.eaOrStrSOuOlEEMmganiuTHlvbL(P_1, P_2);
		if (num < 0)
		{
			return null;
		}
		if (P_0 == 9999999)
		{
			return yvTznuzgWgQMkUPMHeFIRgPbaxv[num];
		}
		return RFUxjzYvBiGItzIesdxvgyyjHDiI[P_0, num];
	}

	public void gVpzkMvUGUNFyPhRiDiKdeXjeud(UpdateControllerInfoEventArgs P_0)
	{
		if (P_0 != null && P_0.sourceJoystick != null)
		{
			ahVxwCWbvzkmEHUwKowKMoJSsbi ahVxwCWbvzkmEHUwKowKMoJSsbi = ahVxwCWbvzkmEHUwKowKMoJSsbi.wBCwGpigkQubfSiQoCKeOYOsLuN;
			int num = cVLHdXoDmoKFhnKGnjYTOTPUZmF(P_0.sourceJoystick.rewiredId, ahVxwCWbvzkmEHUwKowKMoJSsbi);
			if (num < 0)
			{
				ahVxwCWbvzkmEHUwKowKMoJSsbi = ahVxwCWbvzkmEHUwKowKMoJSsbi.LbXKlirWfYnaOPMxjOZLYKvqtyr;
				num = cVLHdXoDmoKFhnKGnjYTOTPUZmF(P_0.sourceJoystick.rewiredId, ahVxwCWbvzkmEHUwKowKMoJSsbi);
			}
			if (num >= 0)
			{
				Joystick joystick = ((ahVxwCWbvzkmEHUwKowKMoJSsbi != 0) ? (joystick = scAOYIaxtkYadmnsGNMHXtrLRQf[num]) : (joystick = XJgBIdbckKopkMUCjQyCdEdMrKam[num]));
				joystick.NawDrBiFtihWvqZtlfFzOTHFrgRq(P_0);
			}
		}
	}

	public bool DKtuxzTflZlILKsHepkOxAxCcgvf(int P_0, ahVxwCWbvzkmEHUwKowKMoJSsbi P_1)
	{
		if (cVLHdXoDmoKFhnKGnjYTOTPUZmF(P_0, P_1) < 0)
		{
			return false;
		}
		return true;
	}

	public int cVLHdXoDmoKFhnKGnjYTOTPUZmF(int P_0, ahVxwCWbvzkmEHUwKowKMoJSsbi P_1)
	{
		switch (P_1)
		{
		case ahVxwCWbvzkmEHUwKowKMoJSsbi.wBCwGpigkQubfSiQoCKeOYOsLuN:
		{
			int count2 = XJgBIdbckKopkMUCjQyCdEdMrKam.Count;
			for (int j = 0; j < count2; j++)
			{
				if (XJgBIdbckKopkMUCjQyCdEdMrKam[j].id == P_0)
				{
					return j;
				}
			}
			break;
		}
		case ahVxwCWbvzkmEHUwKowKMoJSsbi.LbXKlirWfYnaOPMxjOZLYKvqtyr:
		{
			int count = scAOYIaxtkYadmnsGNMHXtrLRQf.Count;
			for (int i = 0; i < count; i++)
			{
				if (scAOYIaxtkYadmnsGNMHXtrLRQf[i].id == P_0)
				{
					return i;
				}
			}
			break;
		}
		}
		return -1;
	}

	public int cVLHdXoDmoKFhnKGnjYTOTPUZmF(Guid P_0, ahVxwCWbvzkmEHUwKowKMoJSsbi P_1)
	{
		switch (P_1)
		{
		case ahVxwCWbvzkmEHUwKowKMoJSsbi.wBCwGpigkQubfSiQoCKeOYOsLuN:
		{
			int count2 = XJgBIdbckKopkMUCjQyCdEdMrKam.Count;
			for (int j = 0; j < count2; j++)
			{
				if (XJgBIdbckKopkMUCjQyCdEdMrKam[j].deviceInstanceGuid == P_0)
				{
					return j;
				}
			}
			break;
		}
		case ahVxwCWbvzkmEHUwKowKMoJSsbi.LbXKlirWfYnaOPMxjOZLYKvqtyr:
		{
			int count = scAOYIaxtkYadmnsGNMHXtrLRQf.Count;
			for (int i = 0; i < count; i++)
			{
				if (scAOYIaxtkYadmnsGNMHXtrLRQf[i].deviceInstanceGuid == P_0)
				{
					return i;
				}
			}
			break;
		}
		}
		return -1;
	}

	public bool HONTvkuxxucwyDjtXmbUxjSieuJ(int P_0)
	{
		if (MmmCFnuaRsdiMTXszhKzNYAhzvp(P_0) < 0)
		{
			return false;
		}
		return true;
	}

	public int MmmCFnuaRsdiMTXszhKzNYAhzvp(int P_0)
	{
		int count = wMZbJMpWrXVIfpZsQnOfzxvuAVP.Count;
		for (int i = 0; i < count; i++)
		{
			if (wMZbJMpWrXVIfpZsQnOfzxvuAVP[i].id == P_0)
			{
				return i;
			}
		}
		return -1;
	}

	public int MmmCFnuaRsdiMTXszhKzNYAhzvp(Guid P_0)
	{
		int count = wMZbJMpWrXVIfpZsQnOfzxvuAVP.Count;
		for (int i = 0; i < count; i++)
		{
			if (wMZbJMpWrXVIfpZsQnOfzxvuAVP[i].deviceInstanceGuid == P_0)
			{
				return i;
			}
		}
		return -1;
	}

	public void gCoNsxqDpuRmajGZvsULzeogvfc(BridgedController P_0)
	{
		GdkaWnORWIvjQITOuvPrLoeRGlU(P_0);
	}

	public void QiXeGqGvYOUhnCNpZvNxFPcHbNU(int P_0)
	{
		int num = cVLHdXoDmoKFhnKGnjYTOTPUZmF(P_0, ahVxwCWbvzkmEHUwKowKMoJSsbi.wBCwGpigkQubfSiQoCKeOYOsLuN);
		RyrnjbxSDgbsoLOKosInVnRNxBv(num);
	}

	public int mcRUKUpDpLukICEujUamAUTqcnF()
	{
		return mKEKPOFFmsOJwYcjbJUukukpYWM++;
	}

	public IList<InputBehavior> umHQUsjkrukJGdByYFaLhrPTnXQ(int P_0)
	{
		if (!ebkdByYRfrQYsImkpRKbAxLruBU.ContainsKey(P_0))
		{
			return new List<InputBehavior>();
		}
		return ebkdByYRfrQYsImkpRKbAxLruBU[P_0].EaRHifAEJQNKbzKzqcwAdchxlQxK;
	}

	public InputBehavior phwbKHKomUfIkFaLFXJBEZIqWcnG(int P_0, string P_1)
	{
		if (P_1 == null || P_1 == string.Empty)
		{
			return null;
		}
		int inputBehaviorId = ReInput.mapping.GetInputBehaviorId(P_1);
		return phwbKHKomUfIkFaLFXJBEZIqWcnG(P_0, inputBehaviorId);
	}

	public InputBehavior phwbKHKomUfIkFaLFXJBEZIqWcnG(int P_0, int P_1)
	{
		if (!ebkdByYRfrQYsImkpRKbAxLruBU.ContainsKey(P_0))
		{
			return null;
		}
		IList<InputBehavior> eaRHifAEJQNKbzKzqcwAdchxlQxK = ebkdByYRfrQYsImkpRKbAxLruBU[P_0].EaRHifAEJQNKbzKzqcwAdchxlQxK;
		for (int i = 0; i < eaRHifAEJQNKbzKzqcwAdchxlQxK.Count; i++)
		{
			if (eaRHifAEJQNKbzKzqcwAdchxlQxK[i].id == P_1)
			{
				return eaRHifAEJQNKbzKzqcwAdchxlQxK[i];
			}
		}
		return null;
	}

	public Joystick zivwXGnUcYgxVcgorNBReCMkWkS(int P_0, bool P_1 = false)
	{
		int num = cVLHdXoDmoKFhnKGnjYTOTPUZmF(P_0, ahVxwCWbvzkmEHUwKowKMoJSsbi.wBCwGpigkQubfSiQoCKeOYOsLuN);
		if (num >= 0)
		{
			return XJgBIdbckKopkMUCjQyCdEdMrKam[num];
		}
		if (P_1)
		{
			num = cVLHdXoDmoKFhnKGnjYTOTPUZmF(P_0, ahVxwCWbvzkmEHUwKowKMoJSsbi.LbXKlirWfYnaOPMxjOZLYKvqtyr);
			if (num >= 0)
			{
				return scAOYIaxtkYadmnsGNMHXtrLRQf[num];
			}
		}
		return null;
	}

	public Joystick zivwXGnUcYgxVcgorNBReCMkWkS(Guid P_0, bool P_1 = false)
	{
		int num = cVLHdXoDmoKFhnKGnjYTOTPUZmF(P_0, ahVxwCWbvzkmEHUwKowKMoJSsbi.wBCwGpigkQubfSiQoCKeOYOsLuN);
		if (num >= 0)
		{
			return XJgBIdbckKopkMUCjQyCdEdMrKam[num];
		}
		if (P_1)
		{
			num = cVLHdXoDmoKFhnKGnjYTOTPUZmF(P_0, ahVxwCWbvzkmEHUwKowKMoJSsbi.LbXKlirWfYnaOPMxjOZLYKvqtyr);
			if (num >= 0)
			{
				return scAOYIaxtkYadmnsGNMHXtrLRQf[num];
			}
		}
		return null;
	}

	public Joystick[] WgaoQSurPxefrtoArFJIIVcXTVP()
	{
		int count = XJgBIdbckKopkMUCjQyCdEdMrKam.Count;
		if (count == 0)
		{
			return EmptyObjects<Joystick>.array;
		}
		Joystick[] array = new Joystick[count];
		for (int i = 0; i < count; i++)
		{
			array[i] = XJgBIdbckKopkMUCjQyCdEdMrKam[i];
		}
		return array;
	}

	public string[] rlLFZrJtfesbyecFVJBQUMMFeUw()
	{
		int count = XJgBIdbckKopkMUCjQyCdEdMrKam.Count;
		if (count == 0)
		{
			return EmptyObjects<string>.array;
		}
		string[] array = new string[count];
		for (int i = 0; i < count; i++)
		{
			array[i] = XJgBIdbckKopkMUCjQyCdEdMrKam[i].name;
		}
		return array;
	}

	public CustomController FWZkRMuknthenkBjRBPUsZyMEpF(int P_0)
	{
		int num = MmmCFnuaRsdiMTXszhKzNYAhzvp(P_0);
		if (num < 0)
		{
			return null;
		}
		return wMZbJMpWrXVIfpZsQnOfzxvuAVP[num];
	}

	public CustomController FWZkRMuknthenkBjRBPUsZyMEpF(Guid P_0)
	{
		int num = MmmCFnuaRsdiMTXszhKzNYAhzvp(P_0);
		if (num < 0)
		{
			return null;
		}
		return wMZbJMpWrXVIfpZsQnOfzxvuAVP[num];
	}

	public CustomController[] gnoIDWojUNAxHrceKFeSYSdjYhW()
	{
		int count = wMZbJMpWrXVIfpZsQnOfzxvuAVP.Count;
		if (count == 0)
		{
			return EmptyObjects<CustomController>.array;
		}
		CustomController[] array = new CustomController[count];
		for (int i = 0; i < count; i++)
		{
			array[i] = wMZbJMpWrXVIfpZsQnOfzxvuAVP[i];
		}
		return array;
	}

	public string[] oOyuCJUjhdBMIdevEuAblmQFQlVj()
	{
		int count = wMZbJMpWrXVIfpZsQnOfzxvuAVP.Count;
		if (count == 0)
		{
			return EmptyObjects<string>.array;
		}
		string[] array = new string[count];
		for (int i = 0; i < count; i++)
		{
			array[i] = wMZbJMpWrXVIfpZsQnOfzxvuAVP[i].name;
		}
		return array;
	}

	public CustomController udmwaShPdzxbUpFVwBKjiHdbMIeF(int P_0)
	{
		CustomController_Editor customControllerById = ReInput.UserData.GetCustomControllerById(P_0);
		if (customControllerById == null)
		{
			return null;
		}
		int nextCustomControllerId = IXDxqIfLvZlLggepywsaGShJUub;
		AFODjzKlpaHUZVznVrGUOLpAAzr aFODjzKlpaHUZVznVrGUOLpAAzr = new AFODjzKlpaHUZVznVrGUOLpAAzr();
		aFODjzKlpaHUZVznVrGUOLpAAzr.eEGdvsHFSoebDZTJoammOSBqiFV = InputSource.Custom;
		aFODjzKlpaHUZVznVrGUOLpAAzr.kKDfGMxMvbfrZIlPuNxkGciRTym = customControllerById.descriptiveName;
		aFODjzKlpaHUZVznVrGUOLpAAzr.QADfLjClYSqotoMLVgvUawAGYijP = customControllerById.name;
		aFODjzKlpaHUZVznVrGUOLpAAzr.beRmxTPYgeEljczGnIuTQeGMXoR = customControllerById.axisCount;
		aFODjzKlpaHUZVznVrGUOLpAAzr.aumNItRblDdXZicbRkrPApteCjR = customControllerById.buttonCount;
		aFODjzKlpaHUZVznVrGUOLpAAzr.gNijVFSxPIkIXVEBfXiCOWbvkEY = nextCustomControllerId;
		aFODjzKlpaHUZVznVrGUOLpAAzr.BFniuQsiHoATkbVSQijmMnCGgfFF = customControllerById.id;
		aFODjzKlpaHUZVznVrGUOLpAAzr.DsvcrAsDzjKdOtdTrgwIMYaspWg = customControllerById.typeGuid;
		aFODjzKlpaHUZVznVrGUOLpAAzr.NsmiaUIozmFmBaKTmrdloGVhDiE = customControllerById.id.ToString();
		aFODjzKlpaHUZVznVrGUOLpAAzr.fznXTxzKbATxoxCDAIgWelhrXjn = customControllerById.qEYKqHdCkIFmZIOUZoOJxsUkurRn();
		AFODjzKlpaHUZVznVrGUOLpAAzr data = aFODjzKlpaHUZVznVrGUOLpAAzr;
		CustomController customController = new CustomController(data);
		heurBGDGCDjNAitaNAkazXKYoIv(customController);
		return customController;
	}

	public bool evJzcCBCQhJrCrkEyiIaVRTzVWk(CustomController P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		return bPqJQkzKFDbRgIQpDdYVjahWPJBg(P_0);
	}

	public CustomController jmTMRSVjftYhQyxRaFksWJEWTbW(int P_0)
	{
		int count = wMZbJMpWrXVIfpZsQnOfzxvuAVP.Count;
		for (int i = 0; i < count; i++)
		{
			if (wMZbJMpWrXVIfpZsQnOfzxvuAVP[i].sourceControllerId == P_0)
			{
				return wMZbJMpWrXVIfpZsQnOfzxvuAVP[i];
			}
		}
		return null;
	}

	public CustomController qNFbGqbaSrLMufXgTvDnLsuXykSM(string P_0)
	{
		int count = wMZbJMpWrXVIfpZsQnOfzxvuAVP.Count;
		for (int i = 0; i < count; i++)
		{
			if (wMZbJMpWrXVIfpZsQnOfzxvuAVP[i].tag.Equals(P_0, StringComparison.OrdinalIgnoreCase))
			{
				return wMZbJMpWrXVIfpZsQnOfzxvuAVP[i];
			}
		}
		return null;
	}

	public IEnumerable<CustomController> nmBTqqVBVKCzowzsojMoreUtMrv(int P_0)
	{
		int count = wMZbJMpWrXVIfpZsQnOfzxvuAVP.Count;
		for (int i = 0; i < count; i++)
		{
			if (wMZbJMpWrXVIfpZsQnOfzxvuAVP[i].sourceControllerId == P_0)
			{
				yield return wMZbJMpWrXVIfpZsQnOfzxvuAVP[i];
			}
		}
	}

	public IEnumerable<CustomController> TKgGscaoOwdnRsKYBPXMezCKuCJD(string P_0)
	{
		int count = wMZbJMpWrXVIfpZsQnOfzxvuAVP.Count;
		for (int i = 0; i < count; i++)
		{
			if (wMZbJMpWrXVIfpZsQnOfzxvuAVP[i].tag.Equals(P_0, StringComparison.OrdinalIgnoreCase))
			{
				yield return wMZbJMpWrXVIfpZsQnOfzxvuAVP[i];
			}
		}
	}

	public Controller RAcjlNtCncziVZzKMoHKTIJjxln(ControllerType P_0, int P_1, bool P_2 = false)
	{
		return P_0 switch
		{
			ControllerType.Joystick => zivwXGnUcYgxVcgorNBReCMkWkS(P_1, P_2), 
			ControllerType.Keyboard => NwgwDBihqBfhaFpOSpkapYWfrwcQ, 
			ControllerType.Mouse => ojmdTJoYFMPLFmIeEmAuAwjFqsY, 
			ControllerType.Custom => FWZkRMuknthenkBjRBPUsZyMEpF(P_1), 
			_ => throw new NotImplementedException(), 
		};
	}

	public Controller RAcjlNtCncziVZzKMoHKTIJjxln(ControllerIdentifier P_0, bool P_1 = false)
	{
		if (P_0.deviceInstanceGuid != Guid.Empty)
		{
			return RAcjlNtCncziVZzKMoHKTIJjxln(P_0.deviceInstanceGuid);
		}
		if (P_0.controllerId >= 0)
		{
			return RAcjlNtCncziVZzKMoHKTIJjxln(P_0.controllerType, P_0.controllerId, P_1);
		}
		return null;
	}

	public Controller RAcjlNtCncziVZzKMoHKTIJjxln(Guid P_0, bool P_1 = false)
	{
		if (P_0 == Guid.Empty)
		{
			return null;
		}
		if (NwgwDBihqBfhaFpOSpkapYWfrwcQ.deviceInstanceGuid == P_0)
		{
			return NwgwDBihqBfhaFpOSpkapYWfrwcQ;
		}
		if (ojmdTJoYFMPLFmIeEmAuAwjFqsY.deviceInstanceGuid == P_0)
		{
			return ojmdTJoYFMPLFmIeEmAuAwjFqsY;
		}
		Controller result;
		if ((result = zivwXGnUcYgxVcgorNBReCMkWkS(P_0, P_1)) != null)
		{
			return result;
		}
		if ((result = FWZkRMuknthenkBjRBPUsZyMEpF(P_0)) != null)
		{
			return result;
		}
		return null;
	}

	public Controller[] geGbEHNFdnhRHHaaUPdbhXpoYjI(ControllerType P_0)
	{
		return P_0 switch
		{
			ControllerType.Joystick => WgaoQSurPxefrtoArFJIIVcXTVP(), 
			ControllerType.Keyboard => new Controller[1] { NwgwDBihqBfhaFpOSpkapYWfrwcQ }, 
			ControllerType.Mouse => new Controller[1] { ojmdTJoYFMPLFmIeEmAuAwjFqsY }, 
			ControllerType.Custom => gnoIDWojUNAxHrceKFeSYSdjYhW(), 
			_ => throw new NotImplementedException(), 
		};
	}

	public string[] BTDsPxxWLIvxcYrZABBLATPOQdh(ControllerType P_0)
	{
		return P_0 switch
		{
			ControllerType.Joystick => rlLFZrJtfesbyecFVJBQUMMFeUw(), 
			ControllerType.Keyboard => new string[1] { NwgwDBihqBfhaFpOSpkapYWfrwcQ.name }, 
			ControllerType.Mouse => new string[1] { ojmdTJoYFMPLFmIeEmAuAwjFqsY.name }, 
			ControllerType.Custom => oOyuCJUjhdBMIdevEuAblmQFQlVj(), 
			_ => throw new NotImplementedException(), 
		};
	}

	public void sJvxAzvIhHCiuNyXTYkCIPJiQxQ(int P_0, Action<InputActionEventData> P_1, UpdateLoopType P_2)
	{
		if (!avpDufEKpukyhnaQGdNwdewKzys)
		{
			avpDufEKpukyhnaQGdNwdewKzys = true;
		}
		CUMgpZCuQojRMyOISYlWjESTDcUr(P_0)?.SxRenVshBREfxhMTnKRbfUFvwoJi(P_1, P_2, InputActionEventType.Update, null);
	}

	public void sJvxAzvIhHCiuNyXTYkCIPJiQxQ(int P_0, Action<InputActionEventData> P_1, UpdateLoopType P_2, int P_3)
	{
		if (!avpDufEKpukyhnaQGdNwdewKzys)
		{
			avpDufEKpukyhnaQGdNwdewKzys = true;
		}
		CUMgpZCuQojRMyOISYlWjESTDcUr(P_0)?.SxRenVshBREfxhMTnKRbfUFvwoJi(P_1, P_2, InputActionEventType.Update, P_3, null);
	}

	public void sJvxAzvIhHCiuNyXTYkCIPJiQxQ(int P_0, Action<InputActionEventData> P_1, UpdateLoopType P_2, string P_3)
	{
		if (!avpDufEKpukyhnaQGdNwdewKzys)
		{
			avpDufEKpukyhnaQGdNwdewKzys = true;
		}
		int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_3);
		if (num >= 0)
		{
			sJvxAzvIhHCiuNyXTYkCIPJiQxQ(P_0, P_1, P_2, num);
		}
	}

	public void sJvxAzvIhHCiuNyXTYkCIPJiQxQ(int P_0, Action<InputActionEventData> P_1, UpdateLoopType P_2, InputActionEventType P_3, object[] P_4)
	{
		if (!avpDufEKpukyhnaQGdNwdewKzys)
		{
			avpDufEKpukyhnaQGdNwdewKzys = true;
		}
		CUMgpZCuQojRMyOISYlWjESTDcUr(P_0)?.SxRenVshBREfxhMTnKRbfUFvwoJi(P_1, P_2, P_3, P_4);
	}

	public void sJvxAzvIhHCiuNyXTYkCIPJiQxQ(int P_0, Action<InputActionEventData> P_1, UpdateLoopType P_2, InputActionEventType P_3, int P_4, object[] P_5)
	{
		if (!avpDufEKpukyhnaQGdNwdewKzys)
		{
			avpDufEKpukyhnaQGdNwdewKzys = true;
		}
		CUMgpZCuQojRMyOISYlWjESTDcUr(P_0)?.SxRenVshBREfxhMTnKRbfUFvwoJi(P_1, P_2, P_3, P_4, P_5);
	}

	public void sJvxAzvIhHCiuNyXTYkCIPJiQxQ(int P_0, Action<InputActionEventData> P_1, UpdateLoopType P_2, InputActionEventType P_3, string P_4, object[] P_5)
	{
		if (!avpDufEKpukyhnaQGdNwdewKzys)
		{
			avpDufEKpukyhnaQGdNwdewKzys = true;
		}
		int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_4);
		if (num >= 0)
		{
			sJvxAzvIhHCiuNyXTYkCIPJiQxQ(P_0, P_1, P_2, P_3, num, P_5);
		}
	}

	public void fbYjmEUqKRgUFWEHQxIfUevDeIXG(int P_0, Action<InputActionEventData> P_1)
	{
		CUMgpZCuQojRMyOISYlWjESTDcUr(P_0)?.vtEeJHlHmADXshapyyaNEbLgpF(P_1);
	}

	public void fbYjmEUqKRgUFWEHQxIfUevDeIXG(int P_0, Action<InputActionEventData> P_1, int P_2)
	{
		CUMgpZCuQojRMyOISYlWjESTDcUr(P_0)?.vtEeJHlHmADXshapyyaNEbLgpF(P_1, P_2);
	}

	public void fbYjmEUqKRgUFWEHQxIfUevDeIXG(int P_0, Action<InputActionEventData> P_1, string P_2)
	{
		int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_2);
		if (num >= 0)
		{
			fbYjmEUqKRgUFWEHQxIfUevDeIXG(P_0, P_1, num);
		}
	}

	public void fbYjmEUqKRgUFWEHQxIfUevDeIXG(int P_0, Action<InputActionEventData> P_1, UpdateLoopType P_2)
	{
		CUMgpZCuQojRMyOISYlWjESTDcUr(P_0)?.vtEeJHlHmADXshapyyaNEbLgpF(P_1, P_2);
	}

	public void fbYjmEUqKRgUFWEHQxIfUevDeIXG(int P_0, Action<InputActionEventData> P_1, InputActionEventType P_2)
	{
		CUMgpZCuQojRMyOISYlWjESTDcUr(P_0)?.vtEeJHlHmADXshapyyaNEbLgpF(P_1, P_2);
	}

	public void fbYjmEUqKRgUFWEHQxIfUevDeIXG(int P_0, Action<InputActionEventData> P_1, UpdateLoopType P_2, int P_3)
	{
		CUMgpZCuQojRMyOISYlWjESTDcUr(P_0)?.vtEeJHlHmADXshapyyaNEbLgpF(P_1, P_2, P_3);
	}

	public void fbYjmEUqKRgUFWEHQxIfUevDeIXG(int P_0, Action<InputActionEventData> P_1, UpdateLoopType P_2, string P_3)
	{
		int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_3);
		if (num >= 0)
		{
			fbYjmEUqKRgUFWEHQxIfUevDeIXG(P_0, P_1, P_2, num);
		}
	}

	public void fbYjmEUqKRgUFWEHQxIfUevDeIXG(int P_0, Action<InputActionEventData> P_1, InputActionEventType P_2, int P_3)
	{
		CUMgpZCuQojRMyOISYlWjESTDcUr(P_0)?.vtEeJHlHmADXshapyyaNEbLgpF(P_1, P_2, P_3);
	}

	public void fbYjmEUqKRgUFWEHQxIfUevDeIXG(int P_0, Action<InputActionEventData> P_1, InputActionEventType P_2, string P_3)
	{
		int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_3);
		if (num >= 0)
		{
			fbYjmEUqKRgUFWEHQxIfUevDeIXG(P_0, P_1, P_2, num);
		}
	}

	public void fbYjmEUqKRgUFWEHQxIfUevDeIXG(int P_0, Action<InputActionEventData> P_1, UpdateLoopType P_2, InputActionEventType P_3)
	{
		CUMgpZCuQojRMyOISYlWjESTDcUr(P_0)?.vtEeJHlHmADXshapyyaNEbLgpF(P_1, P_2, P_3);
	}

	public void fbYjmEUqKRgUFWEHQxIfUevDeIXG(int P_0, Action<InputActionEventData> P_1, UpdateLoopType P_2, InputActionEventType P_3, int P_4)
	{
		CUMgpZCuQojRMyOISYlWjESTDcUr(P_0)?.vtEeJHlHmADXshapyyaNEbLgpF(P_1, P_2, P_3, P_4);
	}

	public void fbYjmEUqKRgUFWEHQxIfUevDeIXG(int P_0, Action<InputActionEventData> P_1, UpdateLoopType P_2, InputActionEventType P_3, string P_4)
	{
		int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_4);
		if (num >= 0)
		{
			fbYjmEUqKRgUFWEHQxIfUevDeIXG(P_0, P_1, P_2, P_3, num);
		}
	}

	public void gNVONAWiphFUgGEukggqccEDkbJw(int P_0)
	{
		CUMgpZCuQojRMyOISYlWjESTDcUr(P_0)?.LlCkzvOeJVaCziTDPktzBWuYotAZ();
	}

	public bool ZcIGDkhYqgWFskSZmIoqvrdWWSNj(int P_0)
	{
		if (P_0 == 9999999)
		{
			for (int i = 0; i < yvTznuzgWgQMkUPMHeFIRgPbaxv.Length; i++)
			{
				if (yvTznuzgWgQMkUPMHeFIRgPbaxv[i].TCWvrlpYTrIwTmaFZCrFglGyZdS())
				{
					return true;
				}
			}
			return false;
		}
		if (P_0 < 0 || P_0 >= NLEpalNfODFjJdDoCFTTlDEgNFWP)
		{
			return false;
		}
		int actionCount = JLezATTKNEMVFfHVAgRNIpvVfYV.rwHTLHmPeQUKdXrAUDBtBNrghsN;
		for (int j = 0; j < actionCount; j++)
		{
			if (RFUxjzYvBiGItzIesdxvgyyjHDiI[P_0, j].TCWvrlpYTrIwTmaFZCrFglGyZdS())
			{
				return true;
			}
		}
		return false;
	}

	public bool ZgjamxcKdSJXetMZbJmNaRmcTjun(int P_0)
	{
		if (P_0 == 9999999)
		{
			for (int i = 0; i < yvTznuzgWgQMkUPMHeFIRgPbaxv.Length; i++)
			{
				if (yvTznuzgWgQMkUPMHeFIRgPbaxv[i].UzfAMThVYdqMudGicKGhMmcVLNfe())
				{
					return true;
				}
			}
			return false;
		}
		if (P_0 < 0 || P_0 >= NLEpalNfODFjJdDoCFTTlDEgNFWP)
		{
			return false;
		}
		int actionCount = JLezATTKNEMVFfHVAgRNIpvVfYV.rwHTLHmPeQUKdXrAUDBtBNrghsN;
		for (int j = 0; j < actionCount; j++)
		{
			if (RFUxjzYvBiGItzIesdxvgyyjHDiI[P_0, j].UzfAMThVYdqMudGicKGhMmcVLNfe())
			{
				return true;
			}
		}
		return false;
	}

	public bool OomBMbWfCskalfnCMnAeOfRXaTmA(int P_0)
	{
		if (P_0 == 9999999)
		{
			for (int i = 0; i < yvTznuzgWgQMkUPMHeFIRgPbaxv.Length; i++)
			{
				if (yvTznuzgWgQMkUPMHeFIRgPbaxv[i].oRveQXtNmlxxfdFQcBcgiXXDnHhU())
				{
					return true;
				}
			}
			return false;
		}
		if (P_0 < 0 || P_0 >= NLEpalNfODFjJdDoCFTTlDEgNFWP)
		{
			return false;
		}
		int actionCount = JLezATTKNEMVFfHVAgRNIpvVfYV.rwHTLHmPeQUKdXrAUDBtBNrghsN;
		for (int j = 0; j < actionCount; j++)
		{
			if (RFUxjzYvBiGItzIesdxvgyyjHDiI[P_0, j].oRveQXtNmlxxfdFQcBcgiXXDnHhU())
			{
				return true;
			}
		}
		return false;
	}

	public bool HPNYHXydniFcCAdLzpmsavELXPke(int P_0)
	{
		if (P_0 == 9999999)
		{
			for (int i = 0; i < yvTznuzgWgQMkUPMHeFIRgPbaxv.Length; i++)
			{
				if (yvTznuzgWgQMkUPMHeFIRgPbaxv[i].LpZDtGGwsJWdKGXsgaCmlXBXbxjq())
				{
					return true;
				}
			}
			return false;
		}
		if (P_0 < 0 || P_0 >= NLEpalNfODFjJdDoCFTTlDEgNFWP)
		{
			return false;
		}
		int actionCount = JLezATTKNEMVFfHVAgRNIpvVfYV.rwHTLHmPeQUKdXrAUDBtBNrghsN;
		for (int j = 0; j < actionCount; j++)
		{
			if (RFUxjzYvBiGItzIesdxvgyyjHDiI[P_0, j].LpZDtGGwsJWdKGXsgaCmlXBXbxjq())
			{
				return true;
			}
		}
		return false;
	}

	public bool bNZBNCfIrtOxezrBCtaFiabIUlHZ(int P_0)
	{
		if (P_0 == 9999999)
		{
			for (int i = 0; i < yvTznuzgWgQMkUPMHeFIRgPbaxv.Length; i++)
			{
				if (yvTznuzgWgQMkUPMHeFIRgPbaxv[i].iqaAyEcHqdpsAZatEXcYRcIruvj())
				{
					return true;
				}
			}
			return false;
		}
		if (P_0 < 0 || P_0 >= NLEpalNfODFjJdDoCFTTlDEgNFWP)
		{
			return false;
		}
		int actionCount = JLezATTKNEMVFfHVAgRNIpvVfYV.rwHTLHmPeQUKdXrAUDBtBNrghsN;
		for (int j = 0; j < actionCount; j++)
		{
			if (RFUxjzYvBiGItzIesdxvgyyjHDiI[P_0, j].iqaAyEcHqdpsAZatEXcYRcIruvj())
			{
				return true;
			}
		}
		return false;
	}

	public bool lfMHFuEhkeBpwcbMzXtFRfJiKjtE(int P_0)
	{
		if (P_0 == 9999999)
		{
			for (int i = 0; i < yvTznuzgWgQMkUPMHeFIRgPbaxv.Length; i++)
			{
				if (yvTznuzgWgQMkUPMHeFIRgPbaxv[i].oXMNVKNTpnOLUaguzJPKSnhoapa())
				{
					return true;
				}
			}
			return false;
		}
		if (P_0 < 0 || P_0 >= NLEpalNfODFjJdDoCFTTlDEgNFWP)
		{
			return false;
		}
		int actionCount = JLezATTKNEMVFfHVAgRNIpvVfYV.rwHTLHmPeQUKdXrAUDBtBNrghsN;
		for (int j = 0; j < actionCount; j++)
		{
			if (RFUxjzYvBiGItzIesdxvgyyjHDiI[P_0, j].oXMNVKNTpnOLUaguzJPKSnhoapa())
			{
				return true;
			}
		}
		return false;
	}

	public bool QhDYZVhbCrFpsbRMPkAFUrkMnTn(int P_0)
	{
		if (P_0 == 9999999)
		{
			for (int i = 0; i < yvTznuzgWgQMkUPMHeFIRgPbaxv.Length; i++)
			{
				if (yvTznuzgWgQMkUPMHeFIRgPbaxv[i].bVfrluEmiRTJoxAilUuhMBMaOpt())
				{
					return true;
				}
			}
			return false;
		}
		if (P_0 < 0 || P_0 >= NLEpalNfODFjJdDoCFTTlDEgNFWP)
		{
			return false;
		}
		int actionCount = JLezATTKNEMVFfHVAgRNIpvVfYV.rwHTLHmPeQUKdXrAUDBtBNrghsN;
		for (int j = 0; j < actionCount; j++)
		{
			if (RFUxjzYvBiGItzIesdxvgyyjHDiI[P_0, j].bVfrluEmiRTJoxAilUuhMBMaOpt())
			{
				return true;
			}
		}
		return false;
	}

	public bool SkFmFYJpGXerRaSgnvlEVthWJGr(int P_0)
	{
		if (P_0 == 9999999)
		{
			for (int i = 0; i < yvTznuzgWgQMkUPMHeFIRgPbaxv.Length; i++)
			{
				if (yvTznuzgWgQMkUPMHeFIRgPbaxv[i].zDUGzlgrGuZsKAvySFmYAjdTBHFT())
				{
					return true;
				}
			}
			return false;
		}
		if (P_0 < 0 || P_0 >= NLEpalNfODFjJdDoCFTTlDEgNFWP)
		{
			return false;
		}
		int actionCount = JLezATTKNEMVFfHVAgRNIpvVfYV.rwHTLHmPeQUKdXrAUDBtBNrghsN;
		for (int j = 0; j < actionCount; j++)
		{
			if (RFUxjzYvBiGItzIesdxvgyyjHDiI[P_0, j].zDUGzlgrGuZsKAvySFmYAjdTBHFT())
			{
				return true;
			}
		}
		return false;
	}

	public bool KDUAfUIJfewqXTsDvFcFEztzzvC()
	{
		if (!KDUAfUIJfewqXTsDvFcFEztzzvC(ojmdTJoYFMPLFmIeEmAuAwjFqsY) && !KDUAfUIJfewqXTsDvFcFEztzzvC(XJgBIdbckKopkMUCjQyCdEdMrKam) && !KDUAfUIJfewqXTsDvFcFEztzzvC(NwgwDBihqBfhaFpOSpkapYWfrwcQ))
		{
			return KDUAfUIJfewqXTsDvFcFEztzzvC(wMZbJMpWrXVIfpZsQnOfzxvuAVP);
		}
		return true;
	}

	public bool KDUAfUIJfewqXTsDvFcFEztzzvC(ControllerType P_0)
	{
		return P_0 switch
		{
			ControllerType.Joystick => KDUAfUIJfewqXTsDvFcFEztzzvC(XJgBIdbckKopkMUCjQyCdEdMrKam), 
			ControllerType.Keyboard => KDUAfUIJfewqXTsDvFcFEztzzvC(NwgwDBihqBfhaFpOSpkapYWfrwcQ), 
			ControllerType.Mouse => KDUAfUIJfewqXTsDvFcFEztzzvC(ojmdTJoYFMPLFmIeEmAuAwjFqsY), 
			ControllerType.Custom => KDUAfUIJfewqXTsDvFcFEztzzvC(wMZbJMpWrXVIfpZsQnOfzxvuAVP), 
			_ => throw new NotImplementedException(), 
		};
	}

	public bool KDNxNlfcGVOlsYYbFJuLFWrKFxt()
	{
		if (!KDNxNlfcGVOlsYYbFJuLFWrKFxt(ojmdTJoYFMPLFmIeEmAuAwjFqsY) && !KDNxNlfcGVOlsYYbFJuLFWrKFxt(XJgBIdbckKopkMUCjQyCdEdMrKam) && !KDNxNlfcGVOlsYYbFJuLFWrKFxt(NwgwDBihqBfhaFpOSpkapYWfrwcQ))
		{
			return KDNxNlfcGVOlsYYbFJuLFWrKFxt(wMZbJMpWrXVIfpZsQnOfzxvuAVP);
		}
		return true;
	}

	public bool KDNxNlfcGVOlsYYbFJuLFWrKFxt(ControllerType P_0)
	{
		return P_0 switch
		{
			ControllerType.Joystick => KDNxNlfcGVOlsYYbFJuLFWrKFxt(XJgBIdbckKopkMUCjQyCdEdMrKam), 
			ControllerType.Keyboard => KDNxNlfcGVOlsYYbFJuLFWrKFxt(NwgwDBihqBfhaFpOSpkapYWfrwcQ), 
			ControllerType.Mouse => KDNxNlfcGVOlsYYbFJuLFWrKFxt(ojmdTJoYFMPLFmIeEmAuAwjFqsY), 
			ControllerType.Custom => KDNxNlfcGVOlsYYbFJuLFWrKFxt(wMZbJMpWrXVIfpZsQnOfzxvuAVP), 
			_ => throw new NotImplementedException(), 
		};
	}

	public bool mpCrovLLdebWlGIoVmuaFcSinjze()
	{
		if (!mpCrovLLdebWlGIoVmuaFcSinjze(ojmdTJoYFMPLFmIeEmAuAwjFqsY) && !mpCrovLLdebWlGIoVmuaFcSinjze(XJgBIdbckKopkMUCjQyCdEdMrKam) && !mpCrovLLdebWlGIoVmuaFcSinjze(NwgwDBihqBfhaFpOSpkapYWfrwcQ))
		{
			return mpCrovLLdebWlGIoVmuaFcSinjze(wMZbJMpWrXVIfpZsQnOfzxvuAVP);
		}
		return true;
	}

	public bool mpCrovLLdebWlGIoVmuaFcSinjze(ControllerType P_0)
	{
		return P_0 switch
		{
			ControllerType.Joystick => mpCrovLLdebWlGIoVmuaFcSinjze(XJgBIdbckKopkMUCjQyCdEdMrKam), 
			ControllerType.Keyboard => mpCrovLLdebWlGIoVmuaFcSinjze(NwgwDBihqBfhaFpOSpkapYWfrwcQ), 
			ControllerType.Mouse => mpCrovLLdebWlGIoVmuaFcSinjze(ojmdTJoYFMPLFmIeEmAuAwjFqsY), 
			ControllerType.Custom => mpCrovLLdebWlGIoVmuaFcSinjze(wMZbJMpWrXVIfpZsQnOfzxvuAVP), 
			_ => throw new NotImplementedException(), 
		};
	}

	public bool noACDaGyfHGudvTADgVJiBAtGpr()
	{
		if (!noACDaGyfHGudvTADgVJiBAtGpr(ojmdTJoYFMPLFmIeEmAuAwjFqsY) && !noACDaGyfHGudvTADgVJiBAtGpr(XJgBIdbckKopkMUCjQyCdEdMrKam) && !noACDaGyfHGudvTADgVJiBAtGpr(NwgwDBihqBfhaFpOSpkapYWfrwcQ))
		{
			return noACDaGyfHGudvTADgVJiBAtGpr(wMZbJMpWrXVIfpZsQnOfzxvuAVP);
		}
		return true;
	}

	public bool noACDaGyfHGudvTADgVJiBAtGpr(ControllerType P_0)
	{
		return P_0 switch
		{
			ControllerType.Joystick => noACDaGyfHGudvTADgVJiBAtGpr(XJgBIdbckKopkMUCjQyCdEdMrKam), 
			ControllerType.Keyboard => noACDaGyfHGudvTADgVJiBAtGpr(NwgwDBihqBfhaFpOSpkapYWfrwcQ), 
			ControllerType.Mouse => noACDaGyfHGudvTADgVJiBAtGpr(ojmdTJoYFMPLFmIeEmAuAwjFqsY), 
			ControllerType.Custom => noACDaGyfHGudvTADgVJiBAtGpr(wMZbJMpWrXVIfpZsQnOfzxvuAVP), 
			_ => throw new NotImplementedException(), 
		};
	}

	public bool ocAxveKgnwVHNGOLMIeckGigELcy()
	{
		if (!ocAxveKgnwVHNGOLMIeckGigELcy(ojmdTJoYFMPLFmIeEmAuAwjFqsY) && !ocAxveKgnwVHNGOLMIeckGigELcy(XJgBIdbckKopkMUCjQyCdEdMrKam) && !ocAxveKgnwVHNGOLMIeckGigELcy(NwgwDBihqBfhaFpOSpkapYWfrwcQ))
		{
			return ocAxveKgnwVHNGOLMIeckGigELcy(wMZbJMpWrXVIfpZsQnOfzxvuAVP);
		}
		return true;
	}

	public bool ocAxveKgnwVHNGOLMIeckGigELcy(ControllerType P_0)
	{
		return P_0 switch
		{
			ControllerType.Joystick => ocAxveKgnwVHNGOLMIeckGigELcy(XJgBIdbckKopkMUCjQyCdEdMrKam), 
			ControllerType.Keyboard => ocAxveKgnwVHNGOLMIeckGigELcy(NwgwDBihqBfhaFpOSpkapYWfrwcQ), 
			ControllerType.Mouse => ocAxveKgnwVHNGOLMIeckGigELcy(ojmdTJoYFMPLFmIeEmAuAwjFqsY), 
			ControllerType.Custom => ocAxveKgnwVHNGOLMIeckGigELcy(wMZbJMpWrXVIfpZsQnOfzxvuAVP), 
			_ => throw new NotImplementedException(), 
		};
	}

	private bool KDUAfUIJfewqXTsDvFcFEztzzvC<T>(IList<T> P_0) where T : Controller
	{
		if (P_0 == null)
		{
			return false;
		}
		int count = P_0.Count;
		for (int i = 0; i < count; i++)
		{
			T val = P_0[i];
			if (val != null && val.GetAnyButton())
			{
				return true;
			}
		}
		return false;
	}

	private bool KDUAfUIJfewqXTsDvFcFEztzzvC(Controller P_0)
	{
		return P_0?.GetAnyButton() ?? false;
	}

	private bool KDNxNlfcGVOlsYYbFJuLFWrKFxt<T>(IList<T> P_0) where T : Controller
	{
		if (P_0 == null)
		{
			return false;
		}
		int count = P_0.Count;
		for (int i = 0; i < count; i++)
		{
			T val = P_0[i];
			if (val != null && val.GetAnyButtonDown())
			{
				return true;
			}
		}
		return false;
	}

	private bool KDNxNlfcGVOlsYYbFJuLFWrKFxt(Controller P_0)
	{
		return P_0?.GetAnyButtonDown() ?? false;
	}

	private bool mpCrovLLdebWlGIoVmuaFcSinjze<T>(IList<T> P_0) where T : Controller
	{
		if (P_0 == null)
		{
			return false;
		}
		int count = P_0.Count;
		for (int i = 0; i < count; i++)
		{
			T val = P_0[i];
			if (val != null && val.GetAnyButtonUp())
			{
				return true;
			}
		}
		return false;
	}

	private bool mpCrovLLdebWlGIoVmuaFcSinjze(Controller P_0)
	{
		return P_0?.GetAnyButtonUp() ?? false;
	}

	private bool noACDaGyfHGudvTADgVJiBAtGpr<T>(IList<T> P_0) where T : Controller
	{
		if (P_0 == null)
		{
			return false;
		}
		int count = P_0.Count;
		for (int i = 0; i < count; i++)
		{
			T val = P_0[i];
			if (val != null && val.GetAnyButtonChanged())
			{
				return true;
			}
		}
		return false;
	}

	private bool noACDaGyfHGudvTADgVJiBAtGpr(Controller P_0)
	{
		return P_0?.GetAnyButtonChanged() ?? false;
	}

	private bool ocAxveKgnwVHNGOLMIeckGigELcy<T>(IList<T> P_0) where T : Controller
	{
		if (P_0 == null)
		{
			return false;
		}
		int count = P_0.Count;
		for (int i = 0; i < count; i++)
		{
			T val = P_0[i];
			if (val != null && val.GetAnyButtonPrev())
			{
				return true;
			}
		}
		return false;
	}

	private bool ocAxveKgnwVHNGOLMIeckGigELcy(Controller P_0)
	{
		return P_0?.GetAnyButtonPrev() ?? false;
	}

	public Controller aGkfxefwVdRHelPOPNuzYZlUGKwI()
	{
		Controller lastController = null;
		double lastTime = 0.0;
		InputTools.CompareLastActiveController(ojmdTJoYFMPLFmIeEmAuAwjFqsY, ref lastController, ref lastTime);
		InputTools.CompareLastActiveController(NwgwDBihqBfhaFpOSpkapYWfrwcQ, ref lastController, ref lastTime);
		IList<Joystick> xJgBIdbckKopkMUCjQyCdEdMrKam = XJgBIdbckKopkMUCjQyCdEdMrKam;
		for (int i = 0; i < XIizDAIvfXWSeeEunnkOyCetKzC; i++)
		{
			InputTools.CompareLastActiveController(xJgBIdbckKopkMUCjQyCdEdMrKam[i], ref lastController, ref lastTime);
		}
		IList<CustomController> list = wMZbJMpWrXVIfpZsQnOfzxvuAVP;
		for (int j = 0; j < XMEhzWyjczynJhPspwNBRqhUnS; j++)
		{
			InputTools.CompareLastActiveController(list[j], ref lastController, ref lastTime);
		}
		if (lastController == null)
		{
			lastController = NwgwDBihqBfhaFpOSpkapYWfrwcQ;
		}
		return lastController;
	}

	public Controller aGkfxefwVdRHelPOPNuzYZlUGKwI(ControllerType P_0)
	{
		Controller lastController = null;
		double lastTime = 0.0;
		switch (P_0)
		{
		case ControllerType.Joystick:
		{
			int count = XJgBIdbckKopkMUCjQyCdEdMrKam.Count;
			for (int j = 0; j < count; j++)
			{
				InputTools.CompareLastActiveController(XJgBIdbckKopkMUCjQyCdEdMrKam[j], ref lastController, ref lastTime);
			}
			break;
		}
		case ControllerType.Keyboard:
			return VptHLZXdJfMsrxxJFwCBsNGGFnMF;
		case ControllerType.Mouse:
			return iBsunrzpmNRGjincwoFXBCjHvrY;
		case ControllerType.Custom:
		{
			int count = wMZbJMpWrXVIfpZsQnOfzxvuAVP.Count;
			for (int i = 0; i < count; i++)
			{
				InputTools.CompareLastActiveController(wMZbJMpWrXVIfpZsQnOfzxvuAVP[i], ref lastController, ref lastTime);
			}
			break;
		}
		default:
			throw new NotImplementedException();
		}
		return lastController;
	}

	public T aGkfxefwVdRHelPOPNuzYZlUGKwI<T>() where T : Controller
	{
		Type typeFromHandle = typeof(T);
		if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Joystick)))
		{
			return aGkfxefwVdRHelPOPNuzYZlUGKwI(ControllerType.Joystick) as T;
		}
		if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Keyboard)))
		{
			return aGkfxefwVdRHelPOPNuzYZlUGKwI(ControllerType.Keyboard) as T;
		}
		if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(CustomController)))
		{
			return aGkfxefwVdRHelPOPNuzYZlUGKwI(ControllerType.Custom) as T;
		}
		if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Mouse)))
		{
			return aGkfxefwVdRHelPOPNuzYZlUGKwI(ControllerType.Mouse) as T;
		}
		throw new NotImplementedException();
	}

	public ControllerType yiJxrVAsBxNxWHeZHtpMdxsmAkO()
	{
		return aGkfxefwVdRHelPOPNuzYZlUGKwI()?.type ?? ControllerType.Keyboard;
	}

	public void ouxUDDBduHJbdBSMXcegTHpIIOy(ActiveControllerChangedDelegate P_0)
	{
		if (P_0 != null)
		{
			wKhxmMQRAWCSxLHwaGXuzxzwFkD = true;
			gnZoXverGEbCLAaotJdLyajaDkp.gRNxgJKbZDnZvauDcPQdINSMaiI(P_0);
		}
	}

	public void ouxUDDBduHJbdBSMXcegTHpIIOy(ActiveControllerChangedDelegate P_0, ControllerType P_1)
	{
		if (P_0 != null)
		{
			wKhxmMQRAWCSxLHwaGXuzxzwFkD = true;
			gnZoXverGEbCLAaotJdLyajaDkp.gRNxgJKbZDnZvauDcPQdINSMaiI(P_0, P_1);
		}
	}

	public void yYpaOdJbPCSCDaDDXsrqJjzhQNs(ActiveControllerChangedDelegate P_0)
	{
		if (P_0 != null)
		{
			gnZoXverGEbCLAaotJdLyajaDkp.VeJYJnGjavQKYzEHvtxpfPYEFCh(P_0);
		}
	}

	public void RpafhFXdRHzTBCHcEGoIPFgErzR(ActiveControllerChangedDelegate P_0, ControllerType P_1)
	{
		if (P_0 != null)
		{
			gnZoXverGEbCLAaotJdLyajaDkp.VeJYJnGjavQKYzEHvtxpfPYEFCh(P_0, P_1);
		}
	}

	public void PCAliDlBQkIBjxLpZAIBzFcEAjc()
	{
		gnZoXverGEbCLAaotJdLyajaDkp.LlCkzvOeJVaCziTDPktzBWuYotAZ();
	}

	public void ouxUDDBduHJbdBSMXcegTHpIIOy(int P_0, PlayerActiveControllerChangedDelegate P_1)
	{
		if (P_1 == null)
		{
			return;
		}
		if (P_0 == 9999999)
		{
			gGmcTOCXSGPzjCtDjgsQGSvHWPJ.gRNxgJKbZDnZvauDcPQdINSMaiI(P_1);
		}
		else
		{
			if ((uint)P_0 >= (uint)NLEpalNfODFjJdDoCFTTlDEgNFWP)
			{
				return;
			}
			wPElXqtZiDHaVHVPbcRpePMCxqJ[P_0].gRNxgJKbZDnZvauDcPQdINSMaiI(P_1);
		}
		wKhxmMQRAWCSxLHwaGXuzxzwFkD = true;
	}

	public void ouxUDDBduHJbdBSMXcegTHpIIOy(int P_0, PlayerActiveControllerChangedDelegate P_1, ControllerType P_2)
	{
		if (P_1 == null)
		{
			return;
		}
		if (P_0 == 9999999)
		{
			gGmcTOCXSGPzjCtDjgsQGSvHWPJ.gRNxgJKbZDnZvauDcPQdINSMaiI(P_1, P_2);
		}
		else
		{
			if ((uint)P_0 >= (uint)NLEpalNfODFjJdDoCFTTlDEgNFWP)
			{
				return;
			}
			wPElXqtZiDHaVHVPbcRpePMCxqJ[P_0].gRNxgJKbZDnZvauDcPQdINSMaiI(P_1, P_2);
		}
		wKhxmMQRAWCSxLHwaGXuzxzwFkD = true;
	}

	public void yYpaOdJbPCSCDaDDXsrqJjzhQNs(int P_0, PlayerActiveControllerChangedDelegate P_1)
	{
		if (P_1 != null)
		{
			if (P_0 == 9999999)
			{
				gGmcTOCXSGPzjCtDjgsQGSvHWPJ.VeJYJnGjavQKYzEHvtxpfPYEFCh(P_1);
			}
			else if ((uint)P_0 < (uint)NLEpalNfODFjJdDoCFTTlDEgNFWP)
			{
				wPElXqtZiDHaVHVPbcRpePMCxqJ[P_0].VeJYJnGjavQKYzEHvtxpfPYEFCh(P_1);
			}
		}
	}

	public void yYpaOdJbPCSCDaDDXsrqJjzhQNs(int P_0, PlayerActiveControllerChangedDelegate P_1, ControllerType P_2)
	{
		if (P_1 != null)
		{
			if (P_0 == 9999999)
			{
				gGmcTOCXSGPzjCtDjgsQGSvHWPJ.VeJYJnGjavQKYzEHvtxpfPYEFCh(P_1, P_2);
			}
			else if ((uint)P_0 < (uint)NLEpalNfODFjJdDoCFTTlDEgNFWP)
			{
				wPElXqtZiDHaVHVPbcRpePMCxqJ[P_0].VeJYJnGjavQKYzEHvtxpfPYEFCh(P_1, P_2);
			}
		}
	}

	public void PCAliDlBQkIBjxLpZAIBzFcEAjc(int P_0)
	{
		if (P_0 == 9999999)
		{
			gGmcTOCXSGPzjCtDjgsQGSvHWPJ.LlCkzvOeJVaCziTDPktzBWuYotAZ();
		}
		else if ((uint)P_0 < (uint)NLEpalNfODFjJdDoCFTTlDEgNFWP)
		{
			wPElXqtZiDHaVHVPbcRpePMCxqJ[P_0].LlCkzvOeJVaCziTDPktzBWuYotAZ();
		}
	}

	private void DVcBuweBsYWbEtCWKHggiwVQRRN()
	{
		if (gnZoXverGEbCLAaotJdLyajaDkp.aSzzJuEiQMKaheBdKHsuibRQtGr > 0)
		{
			gnZoXverGEbCLAaotJdLyajaDkp.xfCYlKyCqHzHHdOLGcJFntJleWp(-1, aGkfxefwVdRHelPOPNuzYZlUGKwI(), aGkfxefwVdRHelPOPNuzYZlUGKwI(ControllerType.Joystick), aGkfxefwVdRHelPOPNuzYZlUGKwI(ControllerType.Custom));
		}
		if (gGmcTOCXSGPzjCtDjgsQGSvHWPJ.aSzzJuEiQMKaheBdKHsuibRQtGr > 0)
		{
			Player.ControllerHelper controllers = kRIMscNTqYOjJDgtnNDWfmLNvzj.iZJWprFjAAltkususAHsWjhtNDP().controllers;
			gGmcTOCXSGPzjCtDjgsQGSvHWPJ.xfCYlKyCqHzHHdOLGcJFntJleWp(9999999, controllers.GetLastActiveController(), controllers.GetLastActiveController(ControllerType.Joystick), controllers.GetLastActiveController(ControllerType.Custom));
		}
		for (int i = 0; i < NLEpalNfODFjJdDoCFTTlDEgNFWP; i++)
		{
			if (wPElXqtZiDHaVHVPbcRpePMCxqJ[i].aSzzJuEiQMKaheBdKHsuibRQtGr != 0)
			{
				Player.ControllerHelper controllers2 = kRIMscNTqYOjJDgtnNDWfmLNvzj.ScSRLIvTiupEEFPdeQkuejIgEwXC[i].controllers;
				wPElXqtZiDHaVHVPbcRpePMCxqJ[i].xfCYlKyCqHzHHdOLGcJFntJleWp(i, controllers2.GetLastActiveController(), controllers2.GetLastActiveController(ControllerType.Joystick), controllers2.GetLastActiveController(ControllerType.Custom));
			}
		}
	}

	public void gHuKdJWHONKmkRrOipoirdsktpB(ThrottleCalibrationMode P_0)
	{
		for (int i = 0; i < XJgBIdbckKopkMUCjQyCdEdMrKam.Count; i++)
		{
			if (XJgBIdbckKopkMUCjQyCdEdMrKam[i] != null)
			{
				gHuKdJWHONKmkRrOipoirdsktpB(XJgBIdbckKopkMUCjQyCdEdMrKam[i], P_0);
			}
		}
		for (int j = 0; j < scAOYIaxtkYadmnsGNMHXtrLRQf.Count; j++)
		{
			if (scAOYIaxtkYadmnsGNMHXtrLRQf[j] != null)
			{
				gHuKdJWHONKmkRrOipoirdsktpB(scAOYIaxtkYadmnsGNMHXtrLRQf[j], P_0);
			}
		}
		for (int k = 0; k < XMEhzWyjczynJhPspwNBRqhUnS; k++)
		{
			if (wMZbJMpWrXVIfpZsQnOfzxvuAVP[k] != null)
			{
				gHuKdJWHONKmkRrOipoirdsktpB(wMZbJMpWrXVIfpZsQnOfzxvuAVP[k], P_0);
			}
		}
		gHuKdJWHONKmkRrOipoirdsktpB(ojmdTJoYFMPLFmIeEmAuAwjFqsY, P_0);
	}

	private void gHuKdJWHONKmkRrOipoirdsktpB(ControllerWithAxes P_0, ThrottleCalibrationMode P_1)
	{
		IList<Controller.Axis> axes = P_0.Axes;
		for (int i = 0; i < P_0.axisCount; i++)
		{
			if (axes[i].LFHpDfBYTFpZGnHfuiJaFQDzksL._specialAxisType == SpecialAxisType.Throttle)
			{
				P_0.calibrationMap.Axes[i].calibrationMode = EnumConverter.ToAlternateAxisCalibrationType(P_1);
			}
		}
	}

	public IList<T> bTkDmLfyrtYGfFgrcutCcpQubhvo<T>() where T : IControllerTemplate
	{
		return dkugfFkVCtTWFFqVQkfYWmwUgQB.lNQimYThrafnaIoBhBJyUhJMjHA<T>();
	}

	private void ijQPrfbohIDtyfCSvLMVhrlmSpB(List<InputBehavior> P_0)
	{
		JLezATTKNEMVFfHVAgRNIpvVfYV = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV;
		kRIMscNTqYOjJDgtnNDWfmLNvzj = ReInput.kRIMscNTqYOjJDgtnNDWfmLNvzj;
		XJgBIdbckKopkMUCjQyCdEdMrKam = new List<Joystick>();
		scAOYIaxtkYadmnsGNMHXtrLRQf = new List<Joystick>();
		wMZbJMpWrXVIfpZsQnOfzxvuAVP = new List<CustomController>();
		rwHTLHmPeQUKdXrAUDBtBNrghsN = JLezATTKNEMVFfHVAgRNIpvVfYV.rwHTLHmPeQUKdXrAUDBtBNrghsN;
		NLEpalNfODFjJdDoCFTTlDEgNFWP = kRIMscNTqYOjJDgtnNDWfmLNvzj.NLEpalNfODFjJdDoCFTTlDEgNFWP;
		yeGXRmkrxqosfNMkOYgVyoYHJsp = tpFfRAcxjUUoExlXsDjXqpeVBXR;
		TpanHfdVChcvhgMyoXJhsQwEiTT = 0;
		ebkdByYRfrQYsImkpRKbAxLruBU = new ADictionary<int, pINKUSpukJHKVoGbaHclkMBdaHA>();
		ebkdByYRfrQYsImkpRKbAxLruBU.Add(ReInput.players.GetSystemPlayer().id, new pINKUSpukJHKVoGbaHclkMBdaHA(P_0));
		IList<Player> players = ReInput.players.Players;
		for (int i = 0; i < players.Count; i++)
		{
			ebkdByYRfrQYsImkpRKbAxLruBU.Add(players[i].id, new pINKUSpukJHKVoGbaHclkMBdaHA(P_0));
		}
		ZhuKYebGpOThmTycZdewIBuSYCv = new ReadOnlyCollection<Joystick>(XJgBIdbckKopkMUCjQyCdEdMrKam);
		BWoDLmhFuQJGaTSeyguReaoBqVJ = new ReadOnlyCollection<CustomController>(wMZbJMpWrXVIfpZsQnOfzxvuAVP);
		XrsxaFoSedDmSEVIidqjOjugISoF.PxCsFDGKVoJJtQMUkWlUpaJvFBV(wsqAVTjIqNDRqGlAEGJnDQDDBDPp);
		ptAcOtHKrPhykgrmlKDfLBYcJZZ = new XrsxaFoSedDmSEVIidqjOjugISoF[(NLEpalNfODFjJdDoCFTTlDEgNFWP + 1) * rwHTLHmPeQUKdXrAUDBtBNrghsN];
		int num = 0;
		yvTznuzgWgQMkUPMHeFIRgPbaxv = new XrsxaFoSedDmSEVIidqjOjugISoF[rwHTLHmPeQUKdXrAUDBtBNrghsN];
		for (int j = 0; j < rwHTLHmPeQUKdXrAUDBtBNrghsN; j++)
		{
			InputAction inputAction = JLezATTKNEMVFfHVAgRNIpvVfYV.bzJqLVraxTcTEuuzzdFzDFqpCeUB(j);
			InputBehavior inputBehavior = ebkdByYRfrQYsImkpRKbAxLruBU[9999999].eRbhnNeZqHZdHeiDXcTGTjbKoqJC(inputAction.behaviorId);
			XrsxaFoSedDmSEVIidqjOjugISoF xrsxaFoSedDmSEVIidqjOjugISoF = new XrsxaFoSedDmSEVIidqjOjugISoF(9999999, inputAction, inputBehavior, wsqAVTjIqNDRqGlAEGJnDQDDBDPp);
			yvTznuzgWgQMkUPMHeFIRgPbaxv[j] = xrsxaFoSedDmSEVIidqjOjugISoF;
			ptAcOtHKrPhykgrmlKDfLBYcJZZ[num] = xrsxaFoSedDmSEVIidqjOjugISoF;
			num++;
		}
		RFUxjzYvBiGItzIesdxvgyyjHDiI = new XrsxaFoSedDmSEVIidqjOjugISoF[NLEpalNfODFjJdDoCFTTlDEgNFWP, rwHTLHmPeQUKdXrAUDBtBNrghsN];
		for (int k = 0; k < NLEpalNfODFjJdDoCFTTlDEgNFWP; k++)
		{
			for (int l = 0; l < rwHTLHmPeQUKdXrAUDBtBNrghsN; l++)
			{
				InputAction inputAction2 = JLezATTKNEMVFfHVAgRNIpvVfYV.bzJqLVraxTcTEuuzzdFzDFqpCeUB(l);
				InputBehavior inputBehavior2 = ebkdByYRfrQYsImkpRKbAxLruBU[players[k].id].eRbhnNeZqHZdHeiDXcTGTjbKoqJC(inputAction2.behaviorId);
				XrsxaFoSedDmSEVIidqjOjugISoF xrsxaFoSedDmSEVIidqjOjugISoF2 = new XrsxaFoSedDmSEVIidqjOjugISoF(k, inputAction2, inputBehavior2, wsqAVTjIqNDRqGlAEGJnDQDDBDPp);
				RFUxjzYvBiGItzIesdxvgyyjHDiI[k, l] = xrsxaFoSedDmSEVIidqjOjugISoF2;
				ptAcOtHKrPhykgrmlKDfLBYcJZZ[num] = xrsxaFoSedDmSEVIidqjOjugISoF2;
				num++;
			}
		}
		IList<Player_Editor> players_readOnly = ReInput.UserData.Players_readOnly;
		if (players_readOnly == null)
		{
			throw new ArgumentNullException("Players cannot be null!");
		}
		for (int m = 0; m < players_readOnly.Count; m++)
		{
			List<Player_Editor.CreateControllerInfo> startingCustomControllers = players_readOnly[m].startingCustomControllers;
			if (startingCustomControllers == null)
			{
				continue;
			}
			for (int n = 0; n < startingCustomControllers.Count; n++)
			{
				CustomController customController = udmwaShPdzxbUpFVwBKjiHdbMIeF(startingCustomControllers[n].sourceId);
				if (customController != null)
				{
					customController.tag = startingCustomControllers[n].tag;
					int num2 = ((m == 0) ? 9999999 : (m - 1));
					kRIMscNTqYOjJDgtnNDWfmLNvzj.fFKuoGTmbMrpFMTwXsWqdvvrhNG(num2)?.controllers.heurBGDGCDjNAitaNAkazXKYoIv(customController, false);
				}
			}
		}
		TQSEkBLukTtWlNVwxdHXLDGIknW = new pvaGWIdSyISJSADPBlPBFIORiqM();
		CkQMcIhNBUOwfiKXVNnpZSGMloV = new pvaGWIdSyISJSADPBlPBFIORiqM[NLEpalNfODFjJdDoCFTTlDEgNFWP];
		for (int num3 = 0; num3 < NLEpalNfODFjJdDoCFTTlDEgNFWP; num3++)
		{
			CkQMcIhNBUOwfiKXVNnpZSGMloV[num3] = new pvaGWIdSyISJSADPBlPBFIORiqM();
		}
		gnZoXverGEbCLAaotJdLyajaDkp = new global::BiRFLNGUJJvTJAuBDTeHgCjFkqdQ<ActiveControllerChangedDelegate>();
		gGmcTOCXSGPzjCtDjgsQGSvHWPJ = new global::BiRFLNGUJJvTJAuBDTeHgCjFkqdQ<PlayerActiveControllerChangedDelegate>();
		wPElXqtZiDHaVHVPbcRpePMCxqJ = new global::BiRFLNGUJJvTJAuBDTeHgCjFkqdQ<PlayerActiveControllerChangedDelegate>[kRIMscNTqYOjJDgtnNDWfmLNvzj.NLEpalNfODFjJdDoCFTTlDEgNFWP];
		ArrayTools.Populate(wPElXqtZiDHaVHVPbcRpePMCxqJ);
	}

	private void wjuFVrKljBJdBEXBOvRdndqtcVrJ(UpdateLoopType P_0)
	{
		int count = XJgBIdbckKopkMUCjQyCdEdMrKam.Count;
		for (int i = 0; i < count; i++)
		{
			Joystick joystick = XJgBIdbckKopkMUCjQyCdEdMrKam[i];
			if (joystick.enabled)
			{
				ywSdcyZBDhBYhakOEfgraQwkfYQn(joystick.inputManagerId, joystick.OcGEaRzMecIeBFudxFTOaknZTFKe);
				joystick.MlEQHREVxHLTuUCANSxPMEKvYTk(P_0);
			}
		}
		if (NwgwDBihqBfhaFpOSpkapYWfrwcQ.enabled)
		{
			NwgwDBihqBfhaFpOSpkapYWfrwcQ.MlEQHREVxHLTuUCANSxPMEKvYTk(P_0);
		}
		else if (nCHYhyJVuOgauyGTGcWtTfTJbDs)
		{
			NwgwDBihqBfhaFpOSpkapYWfrwcQ.ElgdfhbzScFuVnyJXVbBpyGzDWo(P_0);
		}
		if (ojmdTJoYFMPLFmIeEmAuAwjFqsY.enabled)
		{
			ojmdTJoYFMPLFmIeEmAuAwjFqsY.MlEQHREVxHLTuUCANSxPMEKvYTk(P_0);
		}
		int count2 = wMZbJMpWrXVIfpZsQnOfzxvuAVP.Count;
		for (int j = 0; j < count2; j++)
		{
			CustomController customController = wMZbJMpWrXVIfpZsQnOfzxvuAVP[j];
			if (customController.enabled)
			{
				customController.aUBASQMtPCHuIHMaOlMEaiZdWOe();
				customController.MlEQHREVxHLTuUCANSxPMEKvYTk(P_0);
			}
		}
	}

	private void PtigViSzVvGVIFRsHSxZSXaJntA(UpdateLoopType P_0)
	{
		XrsxaFoSedDmSEVIidqjOjugISoF.CYOnxLBoipGeTLxxaDrxLGBfUJM(P_0);
		Player[] allPlayers_orig = kRIMscNTqYOjJDgtnNDWfmLNvzj.OxyBMJoLSnuINnjJbjwxOnluXdE;
		int num = allPlayers_orig.Length;
		bool enabled = NwgwDBihqBfhaFpOSpkapYWfrwcQ.enabled;
		if (enabled)
		{
			for (int i = 0; i < num; i++)
			{
				IList<KeyboardMap> maps = allPlayers_orig[i].controllers.maps.GetMaps<KeyboardMap>(0);
				int count = maps.Count;
				for (int j = 0; j < count; j++)
				{
					if (maps[j].enabled)
					{
						uOGaBKJMisKaCznzyctOFAMOVzwY.KKePYWsJkMNDYKtRtNARncIAcLb(maps[j]);
					}
				}
			}
		}
		bool enabled2 = ojmdTJoYFMPLFmIeEmAuAwjFqsY.enabled;
		for (int k = 0; k < num; k++)
		{
			Player.ControllerHelper controllers = allPlayers_orig[k].controllers;
			controllers.ZZkvtkppBBqtsYXTUtwpTHHXACJ(yeGXRmkrxqosfNMkOYgVyoYHJsp);
			if (enabled || nCHYhyJVuOgauyGTGcWtTfTJbDs)
			{
				controllers.gRNXUCzdDePTRJxogGIYuaawYlC(NwgwDBihqBfhaFpOSpkapYWfrwcQ, uOGaBKJMisKaCznzyctOFAMOVzwY, yeGXRmkrxqosfNMkOYgVyoYHJsp);
			}
			if (enabled2)
			{
				controllers.lbBaLWzRWbJzYibFQOIRrYkjXn(ojmdTJoYFMPLFmIeEmAuAwjFqsY, yeGXRmkrxqosfNMkOYgVyoYHJsp);
			}
			controllers.VbxayShkGwHGcSriawazYKPJEMg(yeGXRmkrxqosfNMkOYgVyoYHJsp);
		}
		for (int l = 0; l < ptAcOtHKrPhykgrmlKDfLBYcJZZ.Length; l++)
		{
			if (ptAcOtHKrPhykgrmlKDfLBYcJZZ[l].tsDgtFeioigbPDQWDvSPMpbiEEu != XrsxaFoSedDmSEVIidqjOjugISoF.mniaGDfphUSiISWWYfSJmUinCVLc.WtCMcJojBuKCaSCvZaswmRHNkJx)
			{
				ptAcOtHKrPhykgrmlKDfLBYcJZZ[l].DvFxbmMmrwxKAdlFbBjZevjaYmxu();
			}
		}
		XrsxaFoSedDmSEVIidqjOjugISoF.FOhDNSMdIgdYxFpuGmZaFbRarOsb();
		if (!avpDufEKpukyhnaQGdNwdewKzys)
		{
			return;
		}
		if (TQSEkBLukTtWlNVwxdHXLDGIknW.ISdYIoHLHpRQaxTRDfBvRqXUAbU > 0)
		{
			for (int m = 0; m < rwHTLHmPeQUKdXrAUDBtBNrghsN; m++)
			{
				XrsxaFoSedDmSEVIidqjOjugISoF xrsxaFoSedDmSEVIidqjOjugISoF = yvTznuzgWgQMkUPMHeFIRgPbaxv[m];
				if (xrsxaFoSedDmSEVIidqjOjugISoF.tsDgtFeioigbPDQWDvSPMpbiEEu != XrsxaFoSedDmSEVIidqjOjugISoF.mniaGDfphUSiISWWYfSJmUinCVLc.WtCMcJojBuKCaSCvZaswmRHNkJx)
				{
					TQSEkBLukTtWlNVwxdHXLDGIknW.tVKqwXOFgvpSghOGdkclktQflDc(xrsxaFoSedDmSEVIidqjOjugISoF, P_0);
				}
			}
		}
		for (int n = 0; n < NLEpalNfODFjJdDoCFTTlDEgNFWP; n++)
		{
			pvaGWIdSyISJSADPBlPBFIORiqM pvaGWIdSyISJSADPBlPBFIORiqM2 = CkQMcIhNBUOwfiKXVNnpZSGMloV[n];
			if (pvaGWIdSyISJSADPBlPBFIORiqM2.ISdYIoHLHpRQaxTRDfBvRqXUAbU == 0)
			{
				continue;
			}
			for (int num2 = 0; num2 < rwHTLHmPeQUKdXrAUDBtBNrghsN; num2++)
			{
				XrsxaFoSedDmSEVIidqjOjugISoF xrsxaFoSedDmSEVIidqjOjugISoF2 = RFUxjzYvBiGItzIesdxvgyyjHDiI[n, num2];
				if (xrsxaFoSedDmSEVIidqjOjugISoF2.tsDgtFeioigbPDQWDvSPMpbiEEu != XrsxaFoSedDmSEVIidqjOjugISoF.mniaGDfphUSiISWWYfSJmUinCVLc.WtCMcJojBuKCaSCvZaswmRHNkJx)
				{
					pvaGWIdSyISJSADPBlPBFIORiqM2.tVKqwXOFgvpSghOGdkclktQflDc(xrsxaFoSedDmSEVIidqjOjugISoF2, P_0);
				}
			}
		}
	}

	private void tpFfRAcxjUUoExlXsDjXqpeVBXR(bool P_0, int P_1, int P_2)
	{
		int num = JLezATTKNEMVFfHVAgRNIpvVfYV.eaOrStrSOuOlEEMmganiuTHlvbL(P_2);
		if (num >= 0)
		{
			if (P_1 == 9999999)
			{
				yvTznuzgWgQMkUPMHeFIRgPbaxv[num].SJHzciDIjnESneSjMnBMLsZxLUbA(P_0);
			}
			else
			{
				RFUxjzYvBiGItzIesdxvgyyjHDiI[P_1, num].SJHzciDIjnESneSjMnBMLsZxLUbA(P_0);
			}
		}
	}

	private void GdkaWnORWIvjQITOuvPrLoeRGlU(BridgedController P_0)
	{
		int num = cVLHdXoDmoKFhnKGnjYTOTPUZmF(P_0.sourceJoystick.rewiredId, ahVxwCWbvzkmEHUwKowKMoJSsbi.wBCwGpigkQubfSiQoCKeOYOsLuN);
		if (num >= 0)
		{
			Logger.LogError("Controller was already in connected list!");
			return;
		}
		num = cVLHdXoDmoKFhnKGnjYTOTPUZmF(P_0.sourceJoystick.rewiredId, ahVxwCWbvzkmEHUwKowKMoJSsbi.LbXKlirWfYnaOPMxjOZLYKvqtyr);
		Joystick joystick;
		if (num >= 0)
		{
			joystick = scAOYIaxtkYadmnsGNMHXtrLRQf[num];
			scAOYIaxtkYadmnsGNMHXtrLRQf.RemoveAt(num);
			joystick.NawDrBiFtihWvqZtlfFzOTHFrgRq(P_0);
			joystick.isConnected = true;
		}
		else
		{
			joystick = new Joystick(P_0);
		}
		XJgBIdbckKopkMUCjQyCdEdMrKam.Add(joystick);
		eNiCSwoUMQsiLCocierOoueRjQH.Add(joystick);
		XJgBIdbckKopkMUCjQyCdEdMrKam.Sort(Joystick.EnXrqwOiOlQcCNmvWwnyxNBgiYQ);
		dkugfFkVCtTWFFqVQkfYWmwUgQB.rXfrpsKYmqSvVJAFxhmUjsiGnVlp(joystick);
	}

	private void RyrnjbxSDgbsoLOKosInVnRNxBv(int P_0)
	{
		if (P_0 < 0)
		{
			throw new ArgumentOutOfRangeException();
		}
		if (P_0 >= XJgBIdbckKopkMUCjQyCdEdMrKam.Count)
		{
			Logger.LogError("Device was not in connected list! Cannot remove!");
			return;
		}
		Joystick joystick = XJgBIdbckKopkMUCjQyCdEdMrKam[P_0];
		joystick.isConnected = false;
		if (zEFiqMeiOoYZBUgQJhNYImDiwIbD != null)
		{
			zEFiqMeiOoYZBUgQJhNYImDiwIbD(new ControllerStatusChangedEventArgs(joystick.name, joystick.id, joystick.type));
		}
		if (yBxAGTiOccJapYJNFgWPxMrRDUIE != null)
		{
			yBxAGTiOccJapYJNFgWPxMrRDUIE(joystick.type, joystick.id);
		}
		XJgBIdbckKopkMUCjQyCdEdMrKam.RemoveAt(P_0);
		scAOYIaxtkYadmnsGNMHXtrLRQf.Add(joystick);
		eNiCSwoUMQsiLCocierOoueRjQH.Remove(joystick);
		dkugfFkVCtTWFFqVQkfYWmwUgQB.QGwSMXaWKSCNARuGHBNVpuHCjHs(joystick);
		joystick.LlCkzvOeJVaCziTDPktzBWuYotAZ();
	}

	private void cztGhOIWEOSLYcbbDqPuIzahdkl()
	{
		int count = XJgBIdbckKopkMUCjQyCdEdMrKam.Count;
		for (int num = count - 1; num >= 0; num--)
		{
			RyrnjbxSDgbsoLOKosInVnRNxBv(num);
		}
	}

	private bool heurBGDGCDjNAitaNAkazXKYoIv(CustomController P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		for (int i = 0; i < wMZbJMpWrXVIfpZsQnOfzxvuAVP.Count; i++)
		{
			if (wMZbJMpWrXVIfpZsQnOfzxvuAVP[i] == P_0)
			{
				return true;
			}
		}
		wMZbJMpWrXVIfpZsQnOfzxvuAVP.Add(P_0);
		eNiCSwoUMQsiLCocierOoueRjQH.Add(P_0);
		dkugfFkVCtTWFFqVQkfYWmwUgQB.rXfrpsKYmqSvVJAFxhmUjsiGnVlp(P_0);
		return true;
	}

	private bool bPqJQkzKFDbRgIQpDdYVjahWPJBg(CustomController P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		dkugfFkVCtTWFFqVQkfYWmwUgQB.QGwSMXaWKSCNARuGHBNVpuHCjHs(P_0);
		eNiCSwoUMQsiLCocierOoueRjQH.Remove(P_0);
		return wMZbJMpWrXVIfpZsQnOfzxvuAVP.Remove(P_0);
	}

	private pvaGWIdSyISJSADPBlPBFIORiqM CUMgpZCuQojRMyOISYlWjESTDcUr(int P_0)
	{
		if (P_0 == 9999999)
		{
			return TQSEkBLukTtWlNVwxdHXLDGIknW;
		}
		if (P_0 < 0 || P_0 >= ReInput.kRIMscNTqYOjJDgtnNDWfmLNvzj.NLEpalNfODFjJdDoCFTTlDEgNFWP)
		{
			return null;
		}
		return CkQMcIhNBUOwfiKXVNnpZSGMloV[P_0];
	}

	private void XPiUpkfgEDeCIccYHKlejzDxiCb(bool P_0)
	{
		if (!P_0)
		{
			uOGaBKJMisKaCznzyctOFAMOVzwY.OrtqCOFFOrtonVeKwJffJoiHExO();
		}
	}

	private void gaVcyOUkQcFnMOoDshSRsfGlDmS(bool P_0)
	{
		if (!P_0 && !ReInput.applicationRunInBackground)
		{
			for (int i = 0; i < XJgBIdbckKopkMUCjQyCdEdMrKam.Count; i++)
			{
				XJgBIdbckKopkMUCjQyCdEdMrKam[i].StopVibration();
			}
		}
	}

	public void Dispose()
	{
		vLCbxFvjSKbaoKsQRAbGNRMrnwI(true);
		GC.SuppressFinalize(this);
	}

	~uhjoXbTonsTOuVJOQAQlbMAgzIYW()
	{
		vLCbxFvjSKbaoKsQRAbGNRMrnwI(false);
	}

	private void vLCbxFvjSKbaoKsQRAbGNRMrnwI(bool P_0)
	{
		if (RFSEgUYkCipDyWyLEnlGiNDUlzz)
		{
			return;
		}
		if (P_0)
		{
			if (coprZjKiqRUtSLqrKdiaFdyEHjBe is IDisposable)
			{
				(coprZjKiqRUtSLqrKdiaFdyEHjBe as IDisposable).Dispose();
			}
			if (TYTuZTCRPEHOAJIPdWPCxdgAjnp is IDisposable)
			{
				(TYTuZTCRPEHOAJIPdWPCxdgAjnp as IDisposable).Dispose();
			}
		}
		RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
	}
}
