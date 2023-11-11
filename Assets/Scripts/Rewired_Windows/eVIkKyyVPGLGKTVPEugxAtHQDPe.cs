using System;
using System.Collections.Generic;
using Rewired;
using Rewired.Interfaces;
using Rewired.Internal;
using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

internal sealed class eVIkKyyVPGLGKTVPEugxAtHQDPe : IElementIdentifierTool
{
	private Rewired.Internal.GUIText xXIjpzHLgzfkSBELIJawuqHQMaj;

	private string DXWFZgFWaHixCuSFHzfojVoRHDKB;

	private int GxWvzYUvwhKsFdPZclpUrYdSmvx;

	private cLFlnHVsQfZirmsvltfLdtHKFo dPWcuMTmvbDZbtxvGfKdatZLIbG;

	private nFospmxJfsUfwGENuIBuWbrCFAW XpDCkyERZZKigIpRBBHbNOfnuRCB;

	private Guid rNcqPDxPSbxcaDlKSekOrxwikjs;

	private IList<tvkecSTWbFlWcBbAxxdWaePZtgu> RnfDZxDNHlLbWIRwJOCGpCRBAIhq;

	private IList<tvkecSTWbFlWcBbAxxdWaePZtgu> JnsIbhEYuuBFpUIJkHCrrujpBcq;

	private bool FVIHzmPPFvAPyxxFifiposMgORw;

	private bool PylmtUHbsZJMcacsZgAnANzrHKp;

	private bool aQxKUZhtiUUpDtkppbeuAexQdBQ;

	private int FScIIQpkXipHJAtdfzifDfwReBR;

	private TimerRealTime XGUEehzhVvcIeAdTFNVkrDxzoqm;

	public void Initialize(Rewired.Internal.GUIText text)
	{
		xXIjpzHLgzfkSBELIJawuqHQMaj = text;
	}

	public void Start()
	{
		if (ReInput.isEditor && ReInput.editorPlatform != EditorPlatform.Windows)
		{
			Rewired.Logger.LogError("Direct Input cannot be run on this platform. You must be running the editor in Windows.");
			return;
		}
		if (ReInput.currentPlatform != Platform.Windows)
		{
			Rewired.Logger.LogError("Direct Input cannot be run on this build target. Be sure Unity's build target is set to Windows Standalone.");
			return;
		}
		if (!(ReInput.primaryInputManager.inputSource is InputSourceWrapper<cLFlnHVsQfZirmsvltfLdtHKFo> inputSourceWrapper) || inputSourceWrapper.source == null)
		{
			Rewired.Logger.LogError("Unable to initialize Direct Input! You must add a Rewired Input Manager to the scene and set the input mode to Direct Input.");
			return;
		}
		dPWcuMTmvbDZbtxvGfKdatZLIbG = inputSourceWrapper.source;
		ReInput.primaryInputManager.SystemDeviceConnectedEvent += RBKmFiLfLNfzkgZjIEnUEIPSWTvE;
		ReInput.primaryInputManager.SystemDeviceDisconnectedEvent += JarXOCRCXOaaWdfFanwgfLeFoQoM;
		XGUEehzhVvcIeAdTFNVkrDxzoqm = new TimerRealTime(1.0);
		XGUEehzhVvcIeAdTFNVkrDxzoqm.Start();
		vaFmRokyAtlVGCugHKoScENBQVL();
		aQxKUZhtiUUpDtkppbeuAexQdBQ = true;
	}

	public void Update()
	{
		if (!aQxKUZhtiUUpDtkppbeuAexQdBQ)
		{
			return;
		}
		DXWFZgFWaHixCuSFHzfojVoRHDKB = "Direct Input Joystick Element Identifier\n\n";
		xXIjpzHLgzfkSBELIJawuqHQMaj.text = DXWFZgFWaHixCuSFHzfojVoRHDKB;
		if (Input.GetKeyDown(KeyCode.A))
		{
			FVIHzmPPFvAPyxxFifiposMgORw = !FVIHzmPPFvAPyxxFifiposMgORw;
		}
		if (FVIHzmPPFvAPyxxFifiposMgORw)
		{
			xXIjpzHLgzfkSBELIJawuqHQMaj.text += "All Devices:\n";
			foreach (tvkecSTWbFlWcBbAxxdWaePZtgu item in JnsIbhEYuuBFpUIJkHCrrujpBcq)
			{
				Rewired.Internal.GUIText gUIText = xXIjpzHLgzfkSBELIJawuqHQMaj;
				object text = gUIText.text;
				gUIText.text = string.Concat(text, item.OrRFBEhjniNFYjbjMjbVqBtWjOHD, ", ", item.OyZncFkZbzFIEKyMLBbsHWcvalA, ", ", new PidVid(item.dtMtLyAEDljqqsSOiaBeXhtoXUH), ", ", item.INjTtHFMDgexAnRzMZtbcjlTrIv, ", ", item.MNRaihHKuqDsUzvPGSYEtAEmyqK, ", ", item.YxVFJDmgAkRgCcCvUfhmITfzYBad, "\n");
			}
			xXIjpzHLgzfkSBELIJawuqHQMaj.text += "\n";
		}
		int gxWvzYUvwhKsFdPZclpUrYdSmvx = GxWvzYUvwhKsFdPZclpUrYdSmvx;
		Guid guid = rNcqPDxPSbxcaDlKSekOrxwikjs;
		if (ReInput.controllers.Keyboard.GetKeyDown(KeyCode.Equals) || ReInput.controllers.Keyboard.GetKeyDown(KeyCode.Plus) || ReInput.controllers.Keyboard.GetKeyDown(KeyCode.KeypadPlus))
		{
			GxWvzYUvwhKsFdPZclpUrYdSmvx++;
		}
		if (ReInput.controllers.Keyboard.GetKeyDown(KeyCode.KeypadMinus) || ReInput.controllers.Keyboard.GetKeyDown(KeyCode.Minus))
		{
			GxWvzYUvwhKsFdPZclpUrYdSmvx--;
		}
		if (XGUEehzhVvcIeAdTFNVkrDxzoqm.Update())
		{
			int num = dPWcuMTmvbDZbtxvGfKdatZLIbG.oWiQwSTbxUPrKaexcvddXRGofgL(FnrirBBrCqEzZffWHJpycBFJwosJ.rKCopvwvfssSrhuKEWPNSGbNUIU, nnLcxzlMtvpnesQPBfJOcQhMmpL.sdvQKHtDvxdfLARkaCRCfLfJDKDa);
			if (num != FScIIQpkXipHJAtdfzifDfwReBR)
			{
				FScIIQpkXipHJAtdfzifDfwReBR = num;
				PylmtUHbsZJMcacsZgAnANzrHKp = true;
			}
			XGUEehzhVvcIeAdTFNVkrDxzoqm.Start();
		}
		if (PylmtUHbsZJMcacsZgAnANzrHKp)
		{
			vaFmRokyAtlVGCugHKoScENBQVL();
			PylmtUHbsZJMcacsZgAnANzrHKp = false;
		}
		int num2 = ((RnfDZxDNHlLbWIRwJOCGpCRBAIhq != null) ? RnfDZxDNHlLbWIRwJOCGpCRBAIhq.Count : 0);
		if (num2 == 0)
		{
			return;
		}
		if (GxWvzYUvwhKsFdPZclpUrYdSmvx < 0)
		{
			GxWvzYUvwhKsFdPZclpUrYdSmvx = num2 - 1;
		}
		else if (GxWvzYUvwhKsFdPZclpUrYdSmvx >= num2)
		{
			GxWvzYUvwhKsFdPZclpUrYdSmvx = 0;
		}
		rNcqPDxPSbxcaDlKSekOrxwikjs = RnfDZxDNHlLbWIRwJOCGpCRBAIhq[GxWvzYUvwhKsFdPZclpUrYdSmvx].mXqEWIlGwHZPoKjhftGIspoptJq;
		bool flag = false;
		if (gxWvzYUvwhKsFdPZclpUrYdSmvx != GxWvzYUvwhKsFdPZclpUrYdSmvx || guid != rNcqPDxPSbxcaDlKSekOrxwikjs)
		{
			flag = true;
		}
		if (XpDCkyERZZKigIpRBBHbNOfnuRCB == null || flag)
		{
			if (XpDCkyERZZKigIpRBBHbNOfnuRCB != null)
			{
				XpDCkyERZZKigIpRBBHbNOfnuRCB.PiVpHzafoUMfSDFNLmfkEJnjpdO();
			}
			XpDCkyERZZKigIpRBBHbNOfnuRCB = new nFospmxJfsUfwGENuIBuWbrCFAW(dPWcuMTmvbDZbtxvGfKdatZLIbG, RnfDZxDNHlLbWIRwJOCGpCRBAIhq[GxWvzYUvwhKsFdPZclpUrYdSmvx].mXqEWIlGwHZPoKjhftGIspoptJq);
			if (XpDCkyERZZKigIpRBBHbNOfnuRCB == null)
			{
				return;
			}
			IList<SXoDXAAkhtkcYIknHXlAohykBIm> list = XpDCkyERZZKigIpRBBHbNOfnuRCB.VQQyXnfgrtOvBajtBJUBOKEMUgN();
			if (list != null)
			{
				for (int i = 0; i < list.Count; i++)
				{
					if ((list[i].ZQquZILPxTVWhnsQPGDNFGBEWHq.jMbdrySazXGxqBoUZJERaOtVVTv & aROXwdaxgbeVtmneibreFeVBHR.ZVxpXwigRIivluwlxUlCrgyvIVD) != 0)
					{
						XpDCkyERZZKigIpRBBHbNOfnuRCB.wNCzQbNQwDjnYqTfSqzTkofPJPa.itttkpUpMreNpceEEMErAXCcMdEd = new XttynZfFZIAoxUqJaugDLvECWEU(-65535, 65535);
					}
				}
			}
			XpDCkyERZZKigIpRBBHbNOfnuRCB.OqhfOnkBvpKzLuKYYPKRUvpiUrOF();
		}
		LsFqLAvQnLGDBdBDuCWOBAydFmq lsFqLAvQnLGDBdBDuCWOBAydFmq;
		try
		{
			lsFqLAvQnLGDBdBDuCWOBAydFmq = XpDCkyERZZKigIpRBBHbNOfnuRCB.bGyAhxmDqyBnueQjAZjMPfKnBIXh();
		}
		catch
		{
			lsFqLAvQnLGDBdBDuCWOBAydFmq = null;
		}
		if (lsFqLAvQnLGDBdBDuCWOBAydFmq == null)
		{
			return;
		}
		if (num2 > 0)
		{
			DXWFZgFWaHixCuSFHzfojVoRHDKB = DXWFZgFWaHixCuSFHzfojVoRHDKB + num2 + " connected devices:\n";
		}
		for (int j = 0; j < num2; j++)
		{
			DXWFZgFWaHixCuSFHzfojVoRHDKB = DXWFZgFWaHixCuSFHzfojVoRHDKB + RnfDZxDNHlLbWIRwJOCGpCRBAIhq[j].OrRFBEhjniNFYjbjMjbVqBtWjOHD + "\n";
		}
		DXWFZgFWaHixCuSFHzfojVoRHDKB += "\n";
		object dXWFZgFWaHixCuSFHzfojVoRHDKB = DXWFZgFWaHixCuSFHzfojVoRHDKB;
		DXWFZgFWaHixCuSFHzfojVoRHDKB = string.Concat(dXWFZgFWaHixCuSFHzfojVoRHDKB, "Current DI device ", GxWvzYUvwhKsFdPZclpUrYdSmvx, ": ", RnfDZxDNHlLbWIRwJOCGpCRBAIhq[GxWvzYUvwhKsFdPZclpUrYdSmvx].OrRFBEhjniNFYjbjMjbVqBtWjOHD, "\n");
		DXWFZgFWaHixCuSFHzfojVoRHDKB += "(Press + or - to change monitored device id.)\n\n";
		ARJdOJKvHmQGkDFpZRAeAzmyzPK("Identifier", new PidVid(XpDCkyERZZKigIpRBBHbNOfnuRCB.UbkAbLSTowGvkaZpTwTOmOxvHNQ.dtMtLyAEDljqqsSOiaBeXhtoXUH));
		ARJdOJKvHmQGkDFpZRAeAzmyzPK("Instance GUID", XpDCkyERZZKigIpRBBHbNOfnuRCB.UbkAbLSTowGvkaZpTwTOmOxvHNQ.mXqEWIlGwHZPoKjhftGIspoptJq);
		ARJdOJKvHmQGkDFpZRAeAzmyzPK("Product Id", XpDCkyERZZKigIpRBBHbNOfnuRCB.wNCzQbNQwDjnYqTfSqzTkofPJPa.LLWNXygzETOTnJQyBltZKpktGJs);
		ARJdOJKvHmQGkDFpZRAeAzmyzPK("Device Type", XpDCkyERZZKigIpRBBHbNOfnuRCB.INkPMrgmFQHrPoFjcDSDiHJFEiNM.HmQyuofUsvomGjtCuiqveOpNWlh.ToString());
		DXWFZgFWaHixCuSFHzfojVoRHDKB += "\n";
		ARJdOJKvHmQGkDFpZRAeAzmyzPK("Axis Count", XpDCkyERZZKigIpRBBHbNOfnuRCB.INkPMrgmFQHrPoFjcDSDiHJFEiNM.bWlOTrKOqDwmrTVckOrGIxOXTbA);
		ARJdOJKvHmQGkDFpZRAeAzmyzPK("Button Count", XpDCkyERZZKigIpRBBHbNOfnuRCB.INkPMrgmFQHrPoFjcDSDiHJFEiNM.nhlHpZITRUjXvMxgnPukLkSwoEV);
		ARJdOJKvHmQGkDFpZRAeAzmyzPK("Hat Count", XpDCkyERZZKigIpRBBHbNOfnuRCB.INkPMrgmFQHrPoFjcDSDiHJFEiNM.AfpHKsHHCTqDvPBVrkTydQaxZcPV);
		DXWFZgFWaHixCuSFHzfojVoRHDKB += "\n";
		if (flag)
		{
			Rewired.Logger.Log("Device Name: \"" + RnfDZxDNHlLbWIRwJOCGpCRBAIhq[GxWvzYUvwhKsFdPZclpUrYdSmvx].OrRFBEhjniNFYjbjMjbVqBtWjOHD + "\"");
			Rewired.Logger.Log("Identifier: " + new PidVid(XpDCkyERZZKigIpRBBHbNOfnuRCB.UbkAbLSTowGvkaZpTwTOmOxvHNQ.dtMtLyAEDljqqsSOiaBeXhtoXUH));
		}
		for (int k = 0; k < 32; k++)
		{
			int num3 = WbUNdjrqDniDXYdirtEbXVOOxfO((DirectInputAxis)k, lsFqLAvQnLGDBdBDuCWOBAydFmq);
			string text2 = ((DirectInputAxis)k).ToString();
			ARJdOJKvHmQGkDFpZRAeAzmyzPK(text2, num3 + " (" + tRSsFucqdzXsNtvLSMlgIVxHHWP(num3) + ")");
		}
		int[] pointOfViewControllers = lsFqLAvQnLGDBdBDuCWOBAydFmq.mSeXMQpIolvHxXuiVLsSKBhIhGfH;
		for (int l = 0; l < 4; l++)
		{
			int num4 = pointOfViewControllers[l];
			string text3 = "Hat " + l;
			ARJdOJKvHmQGkDFpZRAeAzmyzPK(text3, num4);
		}
		bool[] buttons = lsFqLAvQnLGDBdBDuCWOBAydFmq.OZXCbzyfeJVptcfXueOFPpFxErd;
		string text4 = "";
		for (int m = 0; m < 128; m++)
		{
			if (buttons[m])
			{
				if (text4 != "")
				{
					text4 += ", ";
				}
				text4 += m;
			}
		}
		ARJdOJKvHmQGkDFpZRAeAzmyzPK("Buttons ", text4);
		xXIjpzHLgzfkSBELIJawuqHQMaj.text = DXWFZgFWaHixCuSFHzfojVoRHDKB;
	}

	private void vaFmRokyAtlVGCugHKoScENBQVL()
	{
		RnfDZxDNHlLbWIRwJOCGpCRBAIhq = dPWcuMTmvbDZbtxvGfKdatZLIbG.lpdhCcAesAIzAGEfNnVRtTZgAQra(FnrirBBrCqEzZffWHJpycBFJwosJ.UvaLcJUctvCPobYgXUuBtTtpeXVB, nnLcxzlMtvpnesQPBfJOcQhMmpL.sdvQKHtDvxdfLARkaCRCfLfJDKDa);
		JnsIbhEYuuBFpUIJkHCrrujpBcq = dPWcuMTmvbDZbtxvGfKdatZLIbG.lpdhCcAesAIzAGEfNnVRtTZgAQra(FnrirBBrCqEzZffWHJpycBFJwosJ.rKCopvwvfssSrhuKEWPNSGbNUIU, nnLcxzlMtvpnesQPBfJOcQhMmpL.sdvQKHtDvxdfLARkaCRCfLfJDKDa);
		FScIIQpkXipHJAtdfzifDfwReBR = ((JnsIbhEYuuBFpUIJkHCrrujpBcq != null) ? JnsIbhEYuuBFpUIJkHCrrujpBcq.Count : 0);
	}

	private void RBKmFiLfLNfzkgZjIEnUEIPSWTvE()
	{
		DuLzdBiIRJtyMFbYAfIhcMogLuq();
	}

	private void JarXOCRCXOaaWdfFanwgfLeFoQoM()
	{
		DuLzdBiIRJtyMFbYAfIhcMogLuq();
	}

	private void DuLzdBiIRJtyMFbYAfIhcMogLuq()
	{
		xZveeqhZWQBoifJNrEKvhlbeSAk();
		PylmtUHbsZJMcacsZgAnANzrHKp = true;
	}

	private void xZveeqhZWQBoifJNrEKvhlbeSAk()
	{
		GxWvzYUvwhKsFdPZclpUrYdSmvx = 0;
		XpDCkyERZZKigIpRBBHbNOfnuRCB = null;
		rNcqPDxPSbxcaDlKSekOrxwikjs = Guid.Empty;
		RnfDZxDNHlLbWIRwJOCGpCRBAIhq = null;
		JnsIbhEYuuBFpUIJkHCrrujpBcq = null;
		FVIHzmPPFvAPyxxFifiposMgORw = false;
		PylmtUHbsZJMcacsZgAnANzrHKp = false;
		FScIIQpkXipHJAtdfzifDfwReBR = 0;
	}

	private void ARJdOJKvHmQGkDFpZRAeAzmyzPK(string P_0, object P_1)
	{
		string dXWFZgFWaHixCuSFHzfojVoRHDKB = DXWFZgFWaHixCuSFHzfojVoRHDKB;
		DXWFZgFWaHixCuSFHzfojVoRHDKB = dXWFZgFWaHixCuSFHzfojVoRHDKB + P_0 + " = " + P_1.ToString() + "\n";
	}

	private int WbUNdjrqDniDXYdirtEbXVOOxfO(DirectInputAxis P_0, LsFqLAvQnLGDBdBDuCWOBAydFmq P_1)
	{
		return P_0 switch
		{
			DirectInputAxis.X => P_1.xpumVntKTYPdUAcEeqwWhsPgirN, 
			DirectInputAxis.Y => P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg, 
			DirectInputAxis.Z => P_1.TCogMmKASgopRYQJTNMtdAvdwtIe, 
			DirectInputAxis.RotationX => P_1.EdlzUaIOdCOXEXPAWyQWBASofyY, 
			DirectInputAxis.RotationY => P_1.DQysbbdoHDPlpAeeBSiYmmjBYbz, 
			DirectInputAxis.RotationZ => P_1.GLbyWguVoSuyBGnJfbXziXCsHPO, 
			DirectInputAxis.Slider0 => P_1.gljkmoyOBJrGQUmNqDaQBfHacODV[0], 
			DirectInputAxis.Slider1 => P_1.gljkmoyOBJrGQUmNqDaQBfHacODV[1], 
			DirectInputAxis.VelocityX => P_1.yqcjjMQvejIokWKMBapsKKiozwT, 
			DirectInputAxis.VelocityY => P_1.djKPQOAWngqnVpncpdtoeNFWLdhr, 
			DirectInputAxis.VelocityZ => P_1.SiTAMlPnuqbVwhxyevgmJzerzzWq, 
			DirectInputAxis.AngularVelocityX => P_1.oEHOYUnthFiMDrqwXfCuEDgFALxX, 
			DirectInputAxis.AngularVelocityY => P_1.ACneJuXoJhfqxfOCtjZajhvCKdIg, 
			DirectInputAxis.AngularVelocityZ => P_1.rwZlWhqrMonenQBoRuRggMEBTaR, 
			DirectInputAxis.VelocitySlider0 => P_1.FOhAAOAzmohUPgzASmfrbUHqKSxw[0], 
			DirectInputAxis.VelocitySlider1 => P_1.FOhAAOAzmohUPgzASmfrbUHqKSxw[1], 
			DirectInputAxis.AccelerationX => P_1.QtGVhGCdczHTabxrZzdRPrCmcFIk, 
			DirectInputAxis.AccelerationY => P_1.maBbJvUkRsqitIlgaKjqrgDXgJh, 
			DirectInputAxis.AccelerationZ => P_1.HAPIvWFpMbTqoVxbfdBKGmEKjwMD, 
			DirectInputAxis.AngularAccelerationX => P_1.KnZRfKkpbOxfzlgtcOSnwIcFvoU, 
			DirectInputAxis.AngularAccelerationY => P_1.sgsDqvJTsHfsvOJsZeZXGduxWTE, 
			DirectInputAxis.AngularAccelerationZ => P_1.BvlyDJjQGZkZVIWkSmDNcVOyJUe, 
			DirectInputAxis.AccelerationSlider0 => P_1.ZpABAkfHwHQDSOGXlKXhcmEydNqq[0], 
			DirectInputAxis.AccelerationSlider1 => P_1.ZpABAkfHwHQDSOGXlKXhcmEydNqq[1], 
			DirectInputAxis.ForceX => P_1.PMYsmgFkMdlUJldlnEfzdjaaJf, 
			DirectInputAxis.ForceY => P_1.XFtrQkrNkPBxJEKYzmoSMULzujeL, 
			DirectInputAxis.ForceZ => P_1.OtUGEwCUrYfgLqGOZPAfTOWdcAl, 
			DirectInputAxis.TorqueX => P_1.ZmviqYAaSckrJAJfoMAKzAMBigO, 
			DirectInputAxis.TorqueY => P_1.TNSVOyeEanHBtTbVhWsGwnpMCRE, 
			DirectInputAxis.TorqueZ => P_1.enAbylCthhDBABwXbZWLOsvRNbHd, 
			DirectInputAxis.ForceSlider0 => P_1.JUFhaMDmUXULJISwjxqzazZysjK[0], 
			DirectInputAxis.ForceSlider1 => P_1.JUFhaMDmUXULJISwjxqzazZysjK[1], 
			_ => 0, 
		};
	}

	private float tRSsFucqdzXsNtvLSMlgIVxHHWP(int P_0)
	{
		if (P_0 == 0)
		{
			return 0f;
		}
		return MathTools.Clamp((float)MathTools.Abs(P_0) / 65535f * (float)MathTools.Sign(P_0), -1f, 1f);
	}

	public void OnDestroy()
	{
		if (XpDCkyERZZKigIpRBBHbNOfnuRCB != null)
		{
			XpDCkyERZZKigIpRBBHbNOfnuRCB.PiVpHzafoUMfSDFNLmfkEJnjpdO();
		}
	}
}
