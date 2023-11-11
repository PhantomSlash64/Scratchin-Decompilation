using System;
using Rewired;
using Rewired.HID;
using Rewired.HID.Drivers;
using Rewired.Utils;

internal class dfllRGQXaCLWtJKAXCdESlJwigCi : XgheZLhTZqeGIsnzeuQlbjMWIyn, IDisposable, MXZdVNceESepGXlqCohWtaEklcVD, KXNanfFdezOfVOeIdsOvMHQobbRn
{
	private int rpUSbcZJfckKkQXpGZdhqqCogqM;

	private edIjNHJxgLBHXzZHkFeKSgvMhRu uLggKQEXhSelhAVuPdSzyosHZZH;

	private IntPtr FalDOYXDstWegjKGDYYVbqpmgZD;

	private ButtonLoopSet HAjtKKeneFfdQifVPehIAMPLKtB;

	private aZUXLSmsXxucFmeHZluozfvyJBI[] ZIDtXuIpdiZZvWpmQWHbJldEGd;

	private MxfGstFPtBHbpfUjEEFJNYMfrDBl[] WEdcLDdnlUDtkQkdDoysBylaNIPL;

	private int[] msWMpBXnhzqhCVxAEFXSRbEAvud;

	private HIDAccelerometer[] iysXgFOqlkhbXgnwuglWCkXZYJAh;

	private HIDGyroscope[] cMRhBYfbOUgiMHNjsIjSFAZxENX;

	private HIDTouchpad[] BUAYXxyWKZLMRzfFTbRaFrxudBtf;

	private int xtOVtWiRSwynUsAASZxCvWzqNLn;

	private int HhhagREajhouxoTOKEdVmPQojkMn;

	private int ASInOudDwCWKqwEMRDLbIwihalOD;

	private int eachLxsepqpLPNNFXOpVfmOqfN;

	private int hBRxvSAlnMPhAwaHwPaaMqHDjZFA;

	private int rKAfIPAdCzfuEbPLlKckFBeIAaYC;

	private HidOutputReportHandler QbUSrdFOSWBKnFDosxwPgyOVGev;

	private ifndHOoqZsBPMNDcrjlvbinoYGSv zFPRgkyjVBnakxtXNKlMbpMmICQ;

	private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

	public int nyGmXtdUMFOjsJGtySPQenWHxwN => rpUSbcZJfckKkQXpGZdhqqCogqM;

	public edIjNHJxgLBHXzZHkFeKSgvMhRu ygdAGuzWXQmtUDeKrsQEpqRiuFF => uLggKQEXhSelhAVuPdSzyosHZZH;

	public IntPtr xXBFwebtUVoAYaVmghtoNmYZrLV => FalDOYXDstWegjKGDYYVbqpmgZD;

	public bool[] OZXCbzyfeJVptcfXueOFPpFxErd => HAjtKKeneFfdQifVPehIAMPLKtB.Current.effectiveValue;

	public int[] qIIdusxdnSOeOAjfnhjxlMrFQsM => msWMpBXnhzqhCVxAEFXSRbEAvud;

	public int nhlHpZITRUjXvMxgnPukLkSwoEV => xtOVtWiRSwynUsAASZxCvWzqNLn;

	public int sUizFAHmyIDvjcdULcHAokTPxOo => HhhagREajhouxoTOKEdVmPQojkMn;

	public int BzboSoxCQIbRyFecbRupUypRPUE => ASInOudDwCWKqwEMRDLbIwihalOD;

	public bool NyNissJrezIHEYEWYiMbOJlhOtY
	{
		get
		{
			if (xtOVtWiRSwynUsAASZxCvWzqNLn <= 0 && HhhagREajhouxoTOKEdVmPQojkMn <= 0)
			{
				return ASInOudDwCWKqwEMRDLbIwihalOD > 0;
			}
			return true;
		}
	}

	public bool aopAguzVfxvEKIwhDMhrQjSkhKX
	{
		get
		{
			if (cehuXmLEWyrWHNDzjbqOXdXXoCF == null)
			{
				return false;
			}
			return cehuXmLEWyrWHNDzjbqOXdXXoCF.VibrationMotorCount > 0;
		}
	}

	public int IyeVZxyGhmfqMIZajBFUPuzNtsM
	{
		get
		{
			if (cehuXmLEWyrWHNDzjbqOXdXXoCF == null)
			{
				return 0;
			}
			return cehuXmLEWyrWHNDzjbqOXdXXoCF.VibrationMotorCount;
		}
	}

	public InputSource gDwqhSQfaYZFZHxNnvQwnNtbvOF => InputSource.InternalDriver;

	public HidOutputReportHandler JbEVsWZjWDqyxqbkktVBpiBJWcF => QbUSrdFOSWBKnFDosxwPgyOVGev;

	public bAzvngVOSxcOOtKyDFyEOmarEWE aULIdCPnoKcahlmTKaJufZBJrFxf => zFPRgkyjVBnakxtXNKlMbpMmICQ;

	public dfllRGQXaCLWtJKAXCdESlJwigCi(int joystickId, edIjNHJxgLBHXzZHkFeKSgvMhRu joystickSourceType, IntPtr joystickSourceHandle, RAOzdEPdgYzXSunXnEJayhNPEZI hidDevice, HIDDeviceDriver driver, HidOutputReportHandler hidOutputReportHandler)
		: base(hidDevice)
	{
		cehuXmLEWyrWHNDzjbqOXdXXoCF = driver;
		QbUSrdFOSWBKnFDosxwPgyOVGev = hidOutputReportHandler;
		if (cehuXmLEWyrWHNDzjbqOXdXXoCF != null)
		{
			YalseesRNHVmsOjVfDNaLrOBikr = cehuXmLEWyrWHNDzjbqOXdXXoCF.CreateControllerExtension();
		}
		rpUSbcZJfckKkQXpGZdhqqCogqM = joystickId;
		uLggKQEXhSelhAVuPdSzyosHZZH = joystickSourceType;
		FalDOYXDstWegjKGDYYVbqpmgZD = joystickSourceHandle;
		zFPRgkyjVBnakxtXNKlMbpMmICQ = new ifndHOoqZsBPMNDcrjlvbinoYGSv();
		PPytpAWNzpOLwQpfMyKaLDYPSBl();
		zFPRgkyjVBnakxtXNKlMbpMmICQ.TbZzPbXxsmlGVopxOXvnxFfgbkYH();
	}

	public override void EBZMKoSknSfzkSfokUzktanzxJf(UpdateLoopType P_0)
	{
		base.EBZMKoSknSfzkSfokUzktanzxJf(P_0);
		HAjtKKeneFfdQifVPehIAMPLKtB.SetUpdateLoop(P_0);
		for (int i = 0; i < hBRxvSAlnMPhAwaHwPaaMqHDjZFA; i++)
		{
			cMRhBYfbOUgiMHNjsIjSFAZxENX[i].Update(P_0);
		}
	}

	void MXZdVNceESepGXlqCohWtaEklcVD.EBZMKoSknSfzkSfokUzktanzxJf(UpdateLoopType P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in EBZMKoSknSfzkSfokUzktanzxJf
		this.EBZMKoSknSfzkSfokUzktanzxJf(P_0);
	}

	public override void aWoeUUEECkNImBpxjMjDHgymWpn()
	{
		HAjtKKeneFfdQifVPehIAMPLKtB.Current.ClearWasTrueThisFrame();
	}

	void MXZdVNceESepGXlqCohWtaEklcVD.aWoeUUEECkNImBpxjMjDHgymWpn()
	{
		//ILSpy generated this explicit interface implementation from .override directive in aWoeUUEECkNImBpxjMjDHgymWpn
		this.aWoeUUEECkNImBpxjMjDHgymWpn();
	}

	public void TPCPMwmmloEvGakccpOtGdgkPDqZ(IntPtr P_0, int P_1, int P_2, int P_3, double P_4)
	{
		if (P_1 > 0)
		{
			cehuXmLEWyrWHNDzjbqOXdXXoCF.ParseInputReport(P_0, P_1, P_4);
			ldPMgFaEItHhAAPdUPIqVhZTNOL();
			QAJCSlFtoGBRITqPqBBrQqVEeBT();
			UiyeluMRhyGkpXSwaniaVORGdbv();
		}
	}

	void KXNanfFdezOfVOeIdsOvMHQobbRn.TPCPMwmmloEvGakccpOtGdgkPDqZ(IntPtr P_0, int P_1, int P_2, int P_3, double P_4)
	{
		//ILSpy generated this explicit interface implementation from .override directive in TPCPMwmmloEvGakccpOtGdgkPDqZ
		this.TPCPMwmmloEvGakccpOtGdgkPDqZ(P_0, P_1, P_2, P_3, P_4);
	}

	public override void OqhfOnkBvpKzLuKYYPKRUvpiUrOF()
	{
	}

	void MXZdVNceESepGXlqCohWtaEklcVD.OqhfOnkBvpKzLuKYYPKRUvpiUrOF()
	{
		//ILSpy generated this explicit interface implementation from .override directive in OqhfOnkBvpKzLuKYYPKRUvpiUrOF
		this.OqhfOnkBvpKzLuKYYPKRUvpiUrOF();
	}

	public override void PiVpHzafoUMfSDFNLmfkEJnjpdO()
	{
	}

	void MXZdVNceESepGXlqCohWtaEklcVD.PiVpHzafoUMfSDFNLmfkEJnjpdO()
	{
		//ILSpy generated this explicit interface implementation from .override directive in PiVpHzafoUMfSDFNLmfkEJnjpdO
		this.PiVpHzafoUMfSDFNLmfkEJnjpdO();
	}

	public override bool juJWqvRsbSxoEnvwjiYrRthoEMx()
	{
		return lmqbDzgZzBzUutXYlGiroGuKFmG.fGcvLiXbUIhveYuKHpUprbEcdtk;
	}

	bool MXZdVNceESepGXlqCohWtaEklcVD.juJWqvRsbSxoEnvwjiYrRthoEMx()
	{
		//ILSpy generated this explicit interface implementation from .override directive in juJWqvRsbSxoEnvwjiYrRthoEMx
		return this.juJWqvRsbSxoEnvwjiYrRthoEMx();
	}

	public void kyUFGDyfVfGIBBZxImEmetWSOnXJ(int P_0)
	{
		rpUSbcZJfckKkQXpGZdhqqCogqM = P_0;
	}

	void KXNanfFdezOfVOeIdsOvMHQobbRn.kyUFGDyfVfGIBBZxImEmetWSOnXJ(int P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in kyUFGDyfVfGIBBZxImEmetWSOnXJ
		this.kyUFGDyfVfGIBBZxImEmetWSOnXJ(P_0);
	}

	public void TZZendhYActytkYPtwqJctWjPlp(IntPtr P_0)
	{
		FalDOYXDstWegjKGDYYVbqpmgZD = P_0;
	}

	void KXNanfFdezOfVOeIdsOvMHQobbRn.TZZendhYActytkYPtwqJctWjPlp(IntPtr P_0)
	{
		//ILSpy generated this explicit interface implementation from .override directive in TZZendhYActytkYPtwqJctWjPlp
		this.TZZendhYActytkYPtwqJctWjPlp(P_0);
	}

	private void PPytpAWNzpOLwQpfMyKaLDYPSBl()
	{
		xtOVtWiRSwynUsAASZxCvWzqNLn = cehuXmLEWyrWHNDzjbqOXdXXoCF.ButtonCount;
		HhhagREajhouxoTOKEdVmPQojkMn = cehuXmLEWyrWHNDzjbqOXdXXoCF.AxisCount;
		ASInOudDwCWKqwEMRDLbIwihalOD = cehuXmLEWyrWHNDzjbqOXdXXoCF.HatCount;
		eachLxsepqpLPNNFXOpVfmOqfN = cehuXmLEWyrWHNDzjbqOXdXXoCF.AccelerometerCount;
		hBRxvSAlnMPhAwaHwPaaMqHDjZFA = cehuXmLEWyrWHNDzjbqOXdXXoCF.GyroscopeCount;
		rKAfIPAdCzfuEbPLlKckFBeIAaYC = cehuXmLEWyrWHNDzjbqOXdXXoCF.TouchpadCount;
		HAjtKKeneFfdQifVPehIAMPLKtB = new ButtonLoopSet(ReInput.configVars.updateLoop, xtOVtWiRSwynUsAASZxCvWzqNLn);
		ZIDtXuIpdiZZvWpmQWHbJldEGd = new aZUXLSmsXxucFmeHZluozfvyJBI[HhhagREajhouxoTOKEdVmPQojkMn];
		WEdcLDdnlUDtkQkdDoysBylaNIPL = new MxfGstFPtBHbpfUjEEFJNYMfrDBl[ASInOudDwCWKqwEMRDLbIwihalOD];
		msWMpBXnhzqhCVxAEFXSRbEAvud = new int[ASInOudDwCWKqwEMRDLbIwihalOD];
		ArrayTools.Fill(msWMpBXnhzqhCVxAEFXSRbEAvud, -1);
		iysXgFOqlkhbXgnwuglWCkXZYJAh = cehuXmLEWyrWHNDzjbqOXdXXoCF.accelerometers;
		cMRhBYfbOUgiMHNjsIjSFAZxENX = cehuXmLEWyrWHNDzjbqOXdXXoCF.gyroscopes;
		BUAYXxyWKZLMRzfFTbRaFrxudBtf = cehuXmLEWyrWHNDzjbqOXdXXoCF.touchpads;
		for (int i = 0; i < HhhagREajhouxoTOKEdVmPQojkMn; i++)
		{
			ZIDtXuIpdiZZvWpmQWHbJldEGd[i] = xYNNupBGUKuxbcgXSqspOGUxJtE(cehuXmLEWyrWHNDzjbqOXdXXoCF.axes[i]);
			zFPRgkyjVBnakxtXNKlMbpMmICQ.foMDmgEgPXBkJGooEKnwEXmDjvce(ZIDtXuIpdiZZvWpmQWHbJldEGd[i]);
		}
		for (int j = 0; j < ASInOudDwCWKqwEMRDLbIwihalOD; j++)
		{
			WEdcLDdnlUDtkQkdDoysBylaNIPL[j] = ZATWUcaLRmLLcuuDuCXwhFFyFWl(cehuXmLEWyrWHNDzjbqOXdXXoCF.hats[j]);
		}
		for (int k = 0; k < eachLxsepqpLPNNFXOpVfmOqfN; k++)
		{
		}
		for (int l = 0; l < hBRxvSAlnMPhAwaHwPaaMqHDjZFA; l++)
		{
		}
	}

	private void ldPMgFaEItHhAAPdUPIqVhZTNOL()
	{
		if (xtOVtWiRSwynUsAASZxCvWzqNLn != 0)
		{
			HIDButton[] buttons = cehuXmLEWyrWHNDzjbqOXdXXoCF.buttons;
			for (int i = 0; i < xtOVtWiRSwynUsAASZxCvWzqNLn; i++)
			{
				HAjtKKeneFfdQifVPehIAMPLKtB.SetValue(i, buttons[i].rawValue, buttons[i].timestamp);
			}
		}
	}

	private void UiyeluMRhyGkpXSwaniaVORGdbv()
	{
		if (ASInOudDwCWKqwEMRDLbIwihalOD != 0)
		{
			for (int i = 0; i < ASInOudDwCWKqwEMRDLbIwihalOD; i++)
			{
				WEdcLDdnlUDtkQkdDoysBylaNIPL[i].wHkvcINXMZFnQrgJyfCUawhDiuKT = (uint)cehuXmLEWyrWHNDzjbqOXdXXoCF.hats[i].rawValue;
				msWMpBXnhzqhCVxAEFXSRbEAvud[i] = WEdcLDdnlUDtkQkdDoysBylaNIPL[i].TjnjSTTKCWNlcCrnQklvYrKUrXW;
			}
		}
	}

	private void QAJCSlFtoGBRITqPqBBrQqVEeBT()
	{
		if (HhhagREajhouxoTOKEdVmPQojkMn != 0)
		{
			for (int i = 0; i < HhhagREajhouxoTOKEdVmPQojkMn; i++)
			{
				ZIDtXuIpdiZZvWpmQWHbJldEGd[i].wHkvcINXMZFnQrgJyfCUawhDiuKT = (uint)cehuXmLEWyrWHNDzjbqOXdXXoCF.axes[i].rawValue;
			}
		}
	}

	private aZUXLSmsXxucFmeHZluozfvyJBI xYNNupBGUKuxbcgXSqspOGUxJtE(HIDAxis P_0)
	{
		if (P_0 == null)
		{
			return null;
		}
		return new aZUXLSmsXxucFmeHZluozfvyJBI(P_0.reportId, P_0.hidInfo.usagePage, P_0.hidInfo.usage, P_0.hidInfo.dataIndex, P_0.hidInfo.bitSize, P_0.hidInfo.logicalMin, P_0.hidInfo.logicalMax, P_0.hidInfo.physicalMin, P_0.hidInfo.physicalMax, P_0.hidInfo.units, P_0.hidInfo.unitsExp, 0, GizYjyDnNJcYIyixdgjEIHBRMNmK.KSIjkQBGpyBBeujEcBZqCjBSCus(P_0.hidInfo.usagePage, P_0.hidInfo.usage));
	}

	private MxfGstFPtBHbpfUjEEFJNYMfrDBl ZATWUcaLRmLLcuuDuCXwhFFyFWl(HIDHat P_0)
	{
		if (P_0 == null)
		{
			return null;
		}
		return new MxfGstFPtBHbpfUjEEFJNYMfrDBl(P_0.reportId, P_0.hidInfo.usagePage, P_0.hidInfo.usage, P_0.hidInfo.dataIndex, P_0.hidInfo.bitSize, P_0.hidInfo.logicalMin, P_0.hidInfo.logicalMax, P_0.hidInfo.physicalMin, P_0.hidInfo.physicalMax, P_0.hidInfo.units, P_0.hidInfo.unitsExp, 0);
	}

	protected override void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (!jpnIPbpqmlecdiNqaFAxiNCsiMxs)
		{
			jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
			base.PMzamCeIIFqnzgwGlxEbIeTHBFUL(P_0);
		}
	}
}
