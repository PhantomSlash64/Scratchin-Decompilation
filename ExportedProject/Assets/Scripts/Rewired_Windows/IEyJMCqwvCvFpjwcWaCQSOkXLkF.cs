using System;
using System.Collections.Generic;
using Rewired;
using Rewired.HID;
using Rewired.Interfaces;
using Rewired.Internal;
using Rewired.Platforms;
using Rewired.Utils;
using UnityEngine;

internal sealed class IEyJMCqwvCvFpjwcWaCQSOkXLkF : IElementIdentifierTool
{
	private Rewired.Internal.GUIText xXIjpzHLgzfkSBELIJawuqHQMaj;

	private string DXWFZgFWaHixCuSFHzfojVoRHDKB;

	private int GxWvzYUvwhKsFdPZclpUrYdSmvx;

	private RsVeIRZnmCozInvuVtbXAPKPjeyA kshxMxHAgRziwVCbzmgfJlWuXby;

	private KXNanfFdezOfVOeIdsOvMHQobbRn XpDCkyERZZKigIpRBBHbNOfnuRCB;

	private Guid rNcqPDxPSbxcaDlKSekOrxwikjs;

	private IList<KXNanfFdezOfVOeIdsOvMHQobbRn> RnfDZxDNHlLbWIRwJOCGpCRBAIhq;

	private bool FVIHzmPPFvAPyxxFifiposMgORw;

	private bool PylmtUHbsZJMcacsZgAnANzrHKp;

	private bool aQxKUZhtiUUpDtkppbeuAexQdBQ;

	private string[] YEijOlRtLEhWZqpTKWOYRcFvgrGB;

	private int[] jGWRXdjolteXMNuEdLatkRhZCrW;

	public void Initialize(Rewired.Internal.GUIText text)
	{
		xXIjpzHLgzfkSBELIJawuqHQMaj = text;
		YEijOlRtLEhWZqpTKWOYRcFvgrGB = Enum.GetNames(typeof(RawInputAxis));
		jGWRXdjolteXMNuEdLatkRhZCrW = (int[])Enum.GetValues(typeof(RawInputAxis));
	}

	public void Start()
	{
		if (ReInput.isEditor && ReInput.editorPlatform != EditorPlatform.Windows)
		{
			Rewired.Logger.LogError("Raw Input cannot be run on this platform. You must be running the editor in Windows.");
			return;
		}
		if (ReInput.currentPlatform != Platform.Windows)
		{
			Rewired.Logger.LogError("Raw Input cannot be run on this build target. Be sure Unity's build target is set to Windows Standalone.");
			return;
		}
		kshxMxHAgRziwVCbzmgfJlWuXby = ReInput.primaryInputManager.inputSource as RsVeIRZnmCozInvuVtbXAPKPjeyA;
		if (kshxMxHAgRziwVCbzmgfJlWuXby == null)
		{
			Rewired.Logger.LogError("Unable to initialize Raw Input! You must add a Rewired Input Manager to the scene and set the input mode to Raw Input.");
			return;
		}
		ReInput.primaryInputManager.SystemDeviceConnectedEvent += RBKmFiLfLNfzkgZjIEnUEIPSWTvE;
		ReInput.primaryInputManager.SystemDeviceDisconnectedEvent += JarXOCRCXOaaWdfFanwgfLeFoQoM;
		vaFmRokyAtlVGCugHKoScENBQVL();
		aQxKUZhtiUUpDtkppbeuAexQdBQ = true;
	}

	public void Update()
	{
		if (!aQxKUZhtiUUpDtkppbeuAexQdBQ)
		{
			return;
		}
		DXWFZgFWaHixCuSFHzfojVoRHDKB = "Raw Input Joystick Element Identifier\n\n";
		xXIjpzHLgzfkSBELIJawuqHQMaj.text = DXWFZgFWaHixCuSFHzfojVoRHDKB;
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
		if (PylmtUHbsZJMcacsZgAnANzrHKp)
		{
			vaFmRokyAtlVGCugHKoScENBQVL();
			PylmtUHbsZJMcacsZgAnANzrHKp = false;
		}
		int num = ((RnfDZxDNHlLbWIRwJOCGpCRBAIhq != null) ? RnfDZxDNHlLbWIRwJOCGpCRBAIhq.Count : 0);
		if (num == 0)
		{
			return;
		}
		if (GxWvzYUvwhKsFdPZclpUrYdSmvx < 0)
		{
			GxWvzYUvwhKsFdPZclpUrYdSmvx = num - 1;
		}
		else if (GxWvzYUvwhKsFdPZclpUrYdSmvx >= num)
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
			XpDCkyERZZKigIpRBBHbNOfnuRCB = RnfDZxDNHlLbWIRwJOCGpCRBAIhq[GxWvzYUvwhKsFdPZclpUrYdSmvx];
			if (XpDCkyERZZKigIpRBBHbNOfnuRCB == null)
			{
				return;
			}
			XpDCkyERZZKigIpRBBHbNOfnuRCB.OqhfOnkBvpKzLuKYYPKRUvpiUrOF();
		}
		bool flag2 = false;
		if (XpDCkyERZZKigIpRBBHbNOfnuRCB.aULIdCPnoKcahlmTKaJufZBJrFxf is ifndHOoqZsBPMNDcrjlvbinoYGSv)
		{
			flag2 = true;
		}
		else if (!(XpDCkyERZZKigIpRBBHbNOfnuRCB.aULIdCPnoKcahlmTKaJufZBJrFxf is motgBtqJibKySxJNjhgkDyeccgE))
		{
			return;
		}
		if (num > 0)
		{
			DXWFZgFWaHixCuSFHzfojVoRHDKB = DXWFZgFWaHixCuSFHzfojVoRHDKB + num + " connected devices:\n";
		}
		for (int i = 0; i < num; i++)
		{
			DXWFZgFWaHixCuSFHzfojVoRHDKB = DXWFZgFWaHixCuSFHzfojVoRHDKB + RnfDZxDNHlLbWIRwJOCGpCRBAIhq[i].OrRFBEhjniNFYjbjMjbVqBtWjOHD + "\n";
		}
		DXWFZgFWaHixCuSFHzfojVoRHDKB += "\n";
		object dXWFZgFWaHixCuSFHzfojVoRHDKB = DXWFZgFWaHixCuSFHzfojVoRHDKB;
		DXWFZgFWaHixCuSFHzfojVoRHDKB = string.Concat(dXWFZgFWaHixCuSFHzfojVoRHDKB, "Current RI device ", GxWvzYUvwhKsFdPZclpUrYdSmvx, ": \"", XpDCkyERZZKigIpRBBHbNOfnuRCB.OrRFBEhjniNFYjbjMjbVqBtWjOHD, "\"\n");
		DXWFZgFWaHixCuSFHzfojVoRHDKB += "(Press + or - to change monitored device id.)\n\n";
		ARJdOJKvHmQGkDFpZRAeAzmyzPK("Product Name", "\"" + XpDCkyERZZKigIpRBBHbNOfnuRCB.OrRFBEhjniNFYjbjMjbVqBtWjOHD + "\"");
		ARJdOJKvHmQGkDFpZRAeAzmyzPK("Is Bluetooth Device", XpDCkyERZZKigIpRBBHbNOfnuRCB.cjOWzBCMkHIxRWceNYEqTjupNms);
		if (XpDCkyERZZKigIpRBBHbNOfnuRCB.cjOWzBCMkHIxRWceNYEqTjupNms)
		{
			ARJdOJKvHmQGkDFpZRAeAzmyzPK("Bluetooth Device Name", "\"" + XpDCkyERZZKigIpRBBHbNOfnuRCB.AhHrqrQkLzCLgDcoKPqTNKyjQNgv + "\"");
		}
		if (flag2)
		{
			ARJdOJKvHmQGkDFpZRAeAzmyzPK("Using Custom Driver", "TRUE");
		}
		ARJdOJKvHmQGkDFpZRAeAzmyzPK("Device Type", XpDCkyERZZKigIpRBBHbNOfnuRCB.yrBKgxgwtsXACurkrpnBjVvVoyl.ToString());
		ARJdOJKvHmQGkDFpZRAeAzmyzPK("Identifier", new PidVid(XpDCkyERZZKigIpRBBHbNOfnuRCB.dtMtLyAEDljqqsSOiaBeXhtoXUH));
		ARJdOJKvHmQGkDFpZRAeAzmyzPK("Product Id", XpDCkyERZZKigIpRBBHbNOfnuRCB.LLWNXygzETOTnJQyBltZKpktGJs);
		ARJdOJKvHmQGkDFpZRAeAzmyzPK("Vendor Id", XpDCkyERZZKigIpRBBHbNOfnuRCB.XVuHkKcnbaTxiTZvxKQBLJaCehD);
		DXWFZgFWaHixCuSFHzfojVoRHDKB += "\n";
		ARJdOJKvHmQGkDFpZRAeAzmyzPK("Axis Count", XpDCkyERZZKigIpRBBHbNOfnuRCB.sUizFAHmyIDvjcdULcHAokTPxOo);
		ARJdOJKvHmQGkDFpZRAeAzmyzPK("Button Count", XpDCkyERZZKigIpRBBHbNOfnuRCB.nhlHpZITRUjXvMxgnPukLkSwoEV);
		ARJdOJKvHmQGkDFpZRAeAzmyzPK("Hat Count", XpDCkyERZZKigIpRBBHbNOfnuRCB.BzboSoxCQIbRyFecbRupUypRPUE);
		DXWFZgFWaHixCuSFHzfojVoRHDKB += "\n";
		if (flag)
		{
			string text = "";
			text = text + "Device Name: \"" + RnfDZxDNHlLbWIRwJOCGpCRBAIhq[GxWvzYUvwhKsFdPZclpUrYdSmvx].OrRFBEhjniNFYjbjMjbVqBtWjOHD + "\"\n";
			if (XpDCkyERZZKigIpRBBHbNOfnuRCB.cjOWzBCMkHIxRWceNYEqTjupNms)
			{
				text = text + "Bluetooth Device Name: \"" + XpDCkyERZZKigIpRBBHbNOfnuRCB.AhHrqrQkLzCLgDcoKPqTNKyjQNgv + "\"\n";
			}
			object obj = text;
			text = string.Concat(obj, "Identifier: ", new PidVid(XpDCkyERZZKigIpRBBHbNOfnuRCB.dtMtLyAEDljqqsSOiaBeXhtoXUH), "\n");
			Rewired.Logger.Log(text);
		}
		if (!flag2)
		{
			motgBtqJibKySxJNjhgkDyeccgE motgBtqJibKySxJNjhgkDyeccgE2 = XpDCkyERZZKigIpRBBHbNOfnuRCB.aULIdCPnoKcahlmTKaJufZBJrFxf as motgBtqJibKySxJNjhgkDyeccgE;
			for (int j = 1; j < YEijOlRtLEhWZqpTKWOYRcFvgrGB.Length - 1; j++)
			{
				int num2 = WbUNdjrqDniDXYdirtEbXVOOxfO((RawInputAxis)jGWRXdjolteXMNuEdLatkRhZCrW[j], 0, motgBtqJibKySxJNjhgkDyeccgE2);
				string text2 = YEijOlRtLEhWZqpTKWOYRcFvgrGB[j];
				try
				{
					ARJdOJKvHmQGkDFpZRAeAzmyzPK(text2, num2 + " (" + tRSsFucqdzXsNtvLSMlgIVxHHWP(num2) + ")");
				}
				catch
				{
					ARJdOJKvHmQGkDFpZRAeAzmyzPK(text2, "FAILED! Axis value = " + num2);
				}
			}
			if (motgBtqJibKySxJNjhgkDyeccgE2.jdYympfyXCOSATqXypLRvjIuHxk > 0)
			{
				for (int k = 0; k < motgBtqJibKySxJNjhgkDyeccgE2.jdYympfyXCOSATqXypLRvjIuHxk; k++)
				{
					int num3 = WbUNdjrqDniDXYdirtEbXVOOxfO(RawInputAxis.Other, k, motgBtqJibKySxJNjhgkDyeccgE2);
					string text3 = "Other Axis " + k;
					try
					{
						ARJdOJKvHmQGkDFpZRAeAzmyzPK(text3, num3 + " (" + tRSsFucqdzXsNtvLSMlgIVxHHWP(num3) + ")");
					}
					catch
					{
						ARJdOJKvHmQGkDFpZRAeAzmyzPK(text3, "FAILED! Axis value = " + num3);
					}
				}
			}
			int[] hatValues = XpDCkyERZZKigIpRBBHbNOfnuRCB.qIIdusxdnSOeOAjfnhjxlMrFQsM;
			for (int l = 0; l < hatValues.Length; l++)
			{
				int num4 = hatValues[l];
				string text4 = "Hat " + l;
				ARJdOJKvHmQGkDFpZRAeAzmyzPK(text4, num4);
			}
			bool[] buttons = XpDCkyERZZKigIpRBBHbNOfnuRCB.OZXCbzyfeJVptcfXueOFPpFxErd;
			string text5 = "";
			for (int m = 0; m < buttons.Length; m++)
			{
				if (buttons[m])
				{
					if (text5 != "")
					{
						text5 += ", ";
					}
					text5 += m;
				}
			}
			ARJdOJKvHmQGkDFpZRAeAzmyzPK("Buttons ", text5);
		}
		else
		{
			ifndHOoqZsBPMNDcrjlvbinoYGSv ifndHOoqZsBPMNDcrjlvbinoYGSv2 = XpDCkyERZZKigIpRBBHbNOfnuRCB.aULIdCPnoKcahlmTKaJufZBJrFxf as ifndHOoqZsBPMNDcrjlvbinoYGSv;
			for (int n = 0; n < XpDCkyERZZKigIpRBBHbNOfnuRCB.sUizFAHmyIDvjcdULcHAokTPxOo; n++)
			{
				float num5 = ifndHOoqZsBPMNDcrjlvbinoYGSv2.WbUNdjrqDniDXYdirtEbXVOOxfO(n);
				string text6 = n.ToString();
				try
				{
					ARJdOJKvHmQGkDFpZRAeAzmyzPK(text6, num5.ToString() + " (" + ifndHOoqZsBPMNDcrjlvbinoYGSv2.mUtNLjaBLqqvZxWxRSxbaRfYUFV(n) + ")");
				}
				catch
				{
					ARJdOJKvHmQGkDFpZRAeAzmyzPK(text6, "FAILED! Axis value = " + num5);
				}
			}
			int[] hatValues2 = XpDCkyERZZKigIpRBBHbNOfnuRCB.qIIdusxdnSOeOAjfnhjxlMrFQsM;
			for (int num6 = 0; num6 < XpDCkyERZZKigIpRBBHbNOfnuRCB.BzboSoxCQIbRyFecbRupUypRPUE; num6++)
			{
				int num7 = hatValues2[num6];
				string text7 = "Hat " + num6;
				ARJdOJKvHmQGkDFpZRAeAzmyzPK(text7, num7);
			}
			for (int num8 = 0; num8 < XpDCkyERZZKigIpRBBHbNOfnuRCB.FvCxHidPaUCtnjMuXlsGPKWUDOiD.GyroscopeCount; num8++)
			{
				int valueLength = XpDCkyERZZKigIpRBBHbNOfnuRCB.FvCxHidPaUCtnjMuXlsGPKWUDOiD.gyroscopes[num8].valueLength;
				string text8 = "";
				for (int num9 = 0; num9 < valueLength; num9++)
				{
					float num10 = XpDCkyERZZKigIpRBBHbNOfnuRCB.FvCxHidPaUCtnjMuXlsGPKWUDOiD.gyroscopes[num8].rawValue[num9];
					object obj5 = text8;
					text8 = string.Concat(obj5, "[", num9, "]: ", num10.ToString("f3"));
					if (num9 < valueLength - 1)
					{
						text8 += " ";
					}
				}
				ARJdOJKvHmQGkDFpZRAeAzmyzPK("Gyro " + num8, text8);
			}
			for (int num11 = 0; num11 < XpDCkyERZZKigIpRBBHbNOfnuRCB.FvCxHidPaUCtnjMuXlsGPKWUDOiD.AccelerometerCount; num11++)
			{
				int valueLength2 = XpDCkyERZZKigIpRBBHbNOfnuRCB.FvCxHidPaUCtnjMuXlsGPKWUDOiD.accelerometers[num11].valueLength;
				string text9 = "";
				for (int num12 = 0; num12 < valueLength2; num12++)
				{
					float num13 = XpDCkyERZZKigIpRBBHbNOfnuRCB.FvCxHidPaUCtnjMuXlsGPKWUDOiD.accelerometers[num11].rawValue[num12];
					object obj6 = text9;
					text9 = string.Concat(obj6, "[", num12, "]: ", num13.ToString("f3"));
					if (num12 < valueLength2 - 1)
					{
						text9 += " ";
					}
				}
				ARJdOJKvHmQGkDFpZRAeAzmyzPK("Accelerometer " + num11, text9);
			}
			for (int num14 = 0; num14 < XpDCkyERZZKigIpRBBHbNOfnuRCB.FvCxHidPaUCtnjMuXlsGPKWUDOiD.TouchpadCount; num14++)
			{
				HIDTouchpad hIDTouchpad = XpDCkyERZZKigIpRBBHbNOfnuRCB.FvCxHidPaUCtnjMuXlsGPKWUDOiD.touchpads[num14];
				int num15 = hIDTouchpad.values.Length;
				string text10 = "";
				for (int num16 = 0; num16 < num15; num16++)
				{
					HIDTouchpad.TouchData touchData = hIDTouchpad.values[num16];
					dXWFZgFWaHixCuSFHzfojVoRHDKB = text10;
					text10 = string.Concat(dXWFZgFWaHixCuSFHzfojVoRHDKB, "Touch ", num16, ": Is Touching = ", touchData.isTouching, "\n");
					dXWFZgFWaHixCuSFHzfojVoRHDKB = text10;
					text10 = string.Concat(dXWFZgFWaHixCuSFHzfojVoRHDKB, "Touch ", num16, ": Touch Id = ", touchData.touchId, "\n");
					dXWFZgFWaHixCuSFHzfojVoRHDKB = text10;
					text10 = string.Concat(dXWFZgFWaHixCuSFHzfojVoRHDKB, "Touch ", num16, ": Position = ", touchData.positionX, ", ", touchData.positionY, "\n");
					dXWFZgFWaHixCuSFHzfojVoRHDKB = text10;
					text10 = string.Concat(dXWFZgFWaHixCuSFHzfojVoRHDKB, "Touch ", num16, ": Abs Position = ", touchData.positionAbsX, ", ", touchData.positionAbsY, " (", touchData.positionRawX, ", ", touchData.positionRawY, ")\n");
				}
				AboGmyvldXgohNGgGnpGGfWSCZx("Touchpad " + num14, text10);
			}
			bool[] buttons2 = XpDCkyERZZKigIpRBBHbNOfnuRCB.OZXCbzyfeJVptcfXueOFPpFxErd;
			string text11 = "";
			for (int num17 = 0; num17 < buttons2.Length; num17++)
			{
				if (buttons2[num17])
				{
					if (text11 != "")
					{
						text11 += ", ";
					}
					text11 += num17;
				}
			}
			ARJdOJKvHmQGkDFpZRAeAzmyzPK("Buttons ", text11);
		}
		xXIjpzHLgzfkSBELIJawuqHQMaj.text = DXWFZgFWaHixCuSFHzfojVoRHDKB;
	}

	public void OnDestroy()
	{
		if (XpDCkyERZZKigIpRBBHbNOfnuRCB != null)
		{
			XpDCkyERZZKigIpRBBHbNOfnuRCB.PiVpHzafoUMfSDFNLmfkEJnjpdO();
		}
	}

	private void vaFmRokyAtlVGCugHKoScENBQVL()
	{
		RnfDZxDNHlLbWIRwJOCGpCRBAIhq = kshxMxHAgRziwVCbzmgfJlWuXby.GetJoysticks<KXNanfFdezOfVOeIdsOvMHQobbRn>();
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
		FVIHzmPPFvAPyxxFifiposMgORw = false;
		PylmtUHbsZJMcacsZgAnANzrHKp = false;
	}

	private void ARJdOJKvHmQGkDFpZRAeAzmyzPK(string P_0, object P_1)
	{
		string dXWFZgFWaHixCuSFHzfojVoRHDKB = DXWFZgFWaHixCuSFHzfojVoRHDKB;
		DXWFZgFWaHixCuSFHzfojVoRHDKB = dXWFZgFWaHixCuSFHzfojVoRHDKB + P_0 + " = " + P_1.ToString() + "\n";
	}

	private void AboGmyvldXgohNGgGnpGGfWSCZx(string P_0, object P_1)
	{
		string dXWFZgFWaHixCuSFHzfojVoRHDKB = DXWFZgFWaHixCuSFHzfojVoRHDKB;
		DXWFZgFWaHixCuSFHzfojVoRHDKB = dXWFZgFWaHixCuSFHzfojVoRHDKB + P_0 + ":\n" + P_1.ToString() + "\n";
	}

	private int WbUNdjrqDniDXYdirtEbXVOOxfO(RawInputAxis P_0, int P_1, motgBtqJibKySxJNjhgkDyeccgE P_2)
	{
		return P_2.WbUNdjrqDniDXYdirtEbXVOOxfO(P_0, P_1);
	}

	private float tRSsFucqdzXsNtvLSMlgIVxHHWP(int P_0)
	{
		if (P_0 == 0)
		{
			return 0f;
		}
		return MathTools.Clamp((float)MathTools.Abs(P_0) / 65535f * (float)MathTools.Sign(P_0), -1f, 1f);
	}
}
