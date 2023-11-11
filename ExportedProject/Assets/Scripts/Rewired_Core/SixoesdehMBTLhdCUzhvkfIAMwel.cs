using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Rewired;
using Rewired.Config;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

internal class SixoesdehMBTLhdCUzhvkfIAMwel : PlatformInputManager
{
	private class MsPnivhhvngiwjBoCnYOEiefUofk : IInputManagerJoystickPublic, IInputManagerJoystick
	{
		private int xUifcgfakaZXegCEIyIvyNVPONw;

		private int yCFCZIHUtxubaOkYtznBnuzDsZQ;

		private int cHGGtPQmQEdFSaIvpIgqFYTwIUM;

		public Guid lwdxrsNKwLhtAYwqCDFXheqlLse;

		public string GqiGmXqCHcCxbQPkTYeaNPbxCrCD;

		public int pIPICYzGkabAtowsQcODfpQhlrR;

		public string luRMxZWAqFInBgOhniYAkCgTarz;

		public string MNmRhbRuAIbFPiwJKgKPELqwaeZ;

		private int beRmxTPYgeEljczGnIuTQeGMXoR = 29;

		private int aumNItRblDdXZicbRkrPApteCjR = 20;

		private float[] fMaBRrMSrsdNukczypLZCirAhksd;

		private bool[] PVITKWpmXlCUxbOeOgCPsJPiOjmf;

		private bool[] rYbMdzkuuTHGJnaUhDehKzyRinB;

		private float[] oHxLISXQLdUWhyitRGfORHClHAT;

		private bool[] NGIpVchjNIOIQeikqJpsUcfWDySh;

		private HardwareJoystickMap_InputManager pAhzhvigFoLFbwPDdcXHatZWRIl;

		private bool xwlciijKucqyJFICAlBeQdiMzfmY;

		[CustomObfuscation(rename = false)]
		public int rewiredId
		{
			get
			{
				return xUifcgfakaZXegCEIyIvyNVPONw;
			}
			set
			{
				xUifcgfakaZXegCEIyIvyNVPONw = value;
			}
		}

		[CustomObfuscation(rename = false)]
		public int inputManagerId
		{
			get
			{
				return yCFCZIHUtxubaOkYtznBnuzDsZQ;
			}
			set
			{
				yCFCZIHUtxubaOkYtznBnuzDsZQ = value;
			}
		}

		[CustomObfuscation(rename = false)]
		public string name
		{
			get
			{
				if (!(GqiGmXqCHcCxbQPkTYeaNPbxCrCD != "Unknown Controller"))
				{
					return luRMxZWAqFInBgOhniYAkCgTarz;
				}
				return GqiGmXqCHcCxbQPkTYeaNPbxCrCD;
			}
		}

		[CustomObfuscation(rename = false)]
		public long? systemId
		{
			get
			{
				if (cHGGtPQmQEdFSaIvpIgqFYTwIUM < 1)
				{
					return null;
				}
				return cHGGtPQmQEdFSaIvpIgqFYTwIUM;
			}
		}

		[CustomObfuscation(rename = false)]
		public int unityId
		{
			get
			{
				return cHGGtPQmQEdFSaIvpIgqFYTwIUM;
			}
			set
			{
				cHGGtPQmQEdFSaIvpIgqFYTwIUM = value;
			}
		}

		[CustomObfuscation(rename = false)]
		public Guid instanceGuid
		{
			get
			{
				if ((ReInput.isWindowsStandaloneWebplayerOrEditorPlatform && !UnityTools.windowsJoystickNamesReturnsEmptyStringsIfJoystickNull) || UnityTools.effectivePlatform == Platform.OSX)
				{
					return MiscTools.CreateGuidHashSHA1(name);
				}
				if (UnityTools.isIOSPlatform)
				{
					return MiscTools.CreateGuidHashSHA1(luRMxZWAqFInBgOhniYAkCgTarz);
				}
				return MiscTools.CreateGuidHashSHA1(name + "_" + cHGGtPQmQEdFSaIvpIgqFYTwIUM);
			}
		}

		[CustomObfuscation(rename = false)]
		public Guid persistentGuid => instanceGuid;

		[CustomObfuscation(rename = false)]
		public Controller.Extension extension => null;

		[CustomObfuscation(rename = false)]
		public void SetVibration(float amount, int motorIndex)
		{
		}

		[CustomObfuscation(rename = false)]
		public void StopVibration()
		{
		}

		public MsPnivhhvngiwjBoCnYOEiefUofk()
		{
			yCFCZIHUtxubaOkYtznBnuzDsZQ = -1;
			xUifcgfakaZXegCEIyIvyNVPONw = -1;
			cHGGtPQmQEdFSaIvpIgqFYTwIUM = 0;
		}

		public void UcMFLlIeEVgVHdWycYuHxpkWVTYD()
		{
			fnbWnKnajTExrfChSQLkKMdqfpwH();
			lwdxrsNKwLhtAYwqCDFXheqlLse = pAhzhvigFoLFbwPDdcXHatZWRIl.hardwareMapIdentifier.guid;
			GqiGmXqCHcCxbQPkTYeaNPbxCrCD = pAhzhvigFoLFbwPDdcXHatZWRIl.controllerName;
			fMaBRrMSrsdNukczypLZCirAhksd = new float[beRmxTPYgeEljczGnIuTQeGMXoR];
			PVITKWpmXlCUxbOeOgCPsJPiOjmf = new bool[aumNItRblDdXZicbRkrPApteCjR];
			rYbMdzkuuTHGJnaUhDehKzyRinB = new bool[beRmxTPYgeEljczGnIuTQeGMXoR];
			NGIpVchjNIOIQeikqJpsUcfWDySh = new bool[29];
			oHxLISXQLdUWhyitRGfORHClHAT = new float[29];
			Update();
		}

		[CustomObfuscation(rename = false)]
		public void Update()
		{
			if (cHGGtPQmQEdFSaIvpIgqFYTwIUM > 0)
			{
				IZFcoYFWsCVLXBEXMXAIcxwfsJL();
				mrcgZsySeBJGLJfZMFgQRpWqKcPu();
				ZoEfBvZLEHeQeEqRqOmhOcalkaSu();
			}
		}

		public int sRrGplMHNlzmCBfgKNqGViUdGhN(MsPnivhhvngiwjBoCnYOEiefUofk P_0)
		{
			if ((!string.IsNullOrEmpty(MNmRhbRuAIbFPiwJKgKPELqwaeZ) || !string.IsNullOrEmpty(P_0.MNmRhbRuAIbFPiwJKgKPELqwaeZ)) && !string.Equals(MNmRhbRuAIbFPiwJKgKPELqwaeZ, P_0.MNmRhbRuAIbFPiwJKgKPELqwaeZ, StringComparison.Ordinal))
			{
				return 0;
			}
			if (P_0.luRMxZWAqFInBgOhniYAkCgTarz == luRMxZWAqFInBgOhniYAkCgTarz && P_0.pIPICYzGkabAtowsQcODfpQhlrR == pIPICYzGkabAtowsQcODfpQhlrR)
			{
				return 2;
			}
			if (P_0.luRMxZWAqFInBgOhniYAkCgTarz == luRMxZWAqFInBgOhniYAkCgTarz)
			{
				return 1;
			}
			return 0;
		}

		private void OuIWDEMIWYGLVnMRQYdgmCxlPxR(BridgedControllerHWInfo P_0)
		{
			P_0.inputManagerSource = InputSource.Fallback;
			P_0.inputSource = dwahMpvKTveSdmXVjlxHRlTCyOH();
			P_0.hardwareIdentifier = bLgThVKCoYJbgKRAATyCovcPExh();
			P_0.hardwareAxisCount = 0;
			P_0.hardwareButtonCount = 0;
			P_0.hardwareHatCount = 0;
			P_0.hw_productName = luRMxZWAqFInBgOhniYAkCgTarz;
		}

		private void OuIWDEMIWYGLVnMRQYdgmCxlPxR(BridgedController P_0)
		{
			OuIWDEMIWYGLVnMRQYdgmCxlPxR((BridgedControllerHWInfo)P_0);
			P_0.sourceJoystick = this;
			P_0.gameHardwareMap = pAhzhvigFoLFbwPDdcXHatZWRIl.ToGameHardwareControllerMap();
			P_0.instanceName = luRMxZWAqFInBgOhniYAkCgTarz;
			P_0.productName = luRMxZWAqFInBgOhniYAkCgTarz;
			P_0.isXInputDevice = false;
			P_0.axisCount = beRmxTPYgeEljczGnIuTQeGMXoR;
			P_0.buttonCount = aumNItRblDdXZicbRkrPApteCjR;
			P_0.controllerTypeGuid = lwdxrsNKwLhtAYwqCDFXheqlLse;
		}

		[CustomObfuscation(rename = false)]
		public void FillData(ControllerDataUpdater dataUpdater)
		{
			if (beRmxTPYgeEljczGnIuTQeGMXoR != dataUpdater.axisCount || aumNItRblDdXZicbRkrPApteCjR != dataUpdater.buttonCount)
			{
				throw new Exception("This controller signature does not match the data object!");
			}
			float[] axisValues = dataUpdater.axisValues;
			bool[] axisHasBeenPressedOSXLinux = dataUpdater.axisHasBeenPressedOSXLinux;
			for (int i = 0; i < beRmxTPYgeEljczGnIuTQeGMXoR; i++)
			{
				if (axisValues[i] != fMaBRrMSrsdNukczypLZCirAhksd[i])
				{
					axisValues[i] = fMaBRrMSrsdNukczypLZCirAhksd[i];
					if (axisHasBeenPressedOSXLinux[i] != rYbMdzkuuTHGJnaUhDehKzyRinB[i])
					{
						axisHasBeenPressedOSXLinux[i] = rYbMdzkuuTHGJnaUhDehKzyRinB[i];
					}
				}
			}
			bool[] buttonValues = dataUpdater.buttonValues;
			for (int j = 0; j < aumNItRblDdXZicbRkrPApteCjR; j++)
			{
				if (buttonValues[j] != PVITKWpmXlCUxbOeOgCPsJPiOjmf[j])
				{
					buttonValues[j] = PVITKWpmXlCUxbOeOgCPsJPiOjmf[j];
				}
			}
			if (xwlciijKucqyJFICAlBeQdiMzfmY && !dataUpdater.hasReceivedInput)
			{
				dataUpdater.hasReceivedInput = true;
			}
		}

		public void PwXCqpiOTklLeCgDEPZDbkqzpErB(int P_0)
		{
			if (P_0 >= 1 && P_0 <= 16)
			{
				unityId = P_0;
			}
		}

		public void swGfAgHQUqPLnzipiPrCKvmcObYR()
		{
			cHGGtPQmQEdFSaIvpIgqFYTwIUM = 0;
			FxcLOucRQkrrYFkHqvCUxSLMADZ();
		}

		public BridgedControllerHWInfo rtmepNGyphMMGYpeiwSMrmBNGeQC()
		{
			BridgedControllerHWInfo bridgedControllerHWInfo = new BridgedControllerHWInfo();
			OuIWDEMIWYGLVnMRQYdgmCxlPxR(bridgedControllerHWInfo);
			return bridgedControllerHWInfo;
		}

		[CustomObfuscation(rename = false)]
		public BridgedController ToBridgedController()
		{
			BridgedController bridgedController = new BridgedController();
			OuIWDEMIWYGLVnMRQYdgmCxlPxR(bridgedController);
			return bridgedController;
		}

		[CustomObfuscation(rename = false)]
		public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs()
		{
			return new ControllerDisconnectedEventArgs(xUifcgfakaZXegCEIyIvyNVPONw);
		}

		private void IZFcoYFWsCVLXBEXMXAIcxwfsJL()
		{
			for (int i = 0; i < 29; i++)
			{
				float joystickAxisValueByJoystickId = UnityInputHelper.GetJoystickAxisValueByJoystickId(cHGGtPQmQEdFSaIvpIgqFYTwIUM, i);
				if (oHxLISXQLdUWhyitRGfORHClHAT[i] != joystickAxisValueByJoystickId)
				{
					oHxLISXQLdUWhyitRGfORHClHAT[i] = joystickAxisValueByJoystickId;
					if (!NGIpVchjNIOIQeikqJpsUcfWDySh[i] && joystickAxisValueByJoystickId != 0f)
					{
						NGIpVchjNIOIQeikqJpsUcfWDySh[i] = true;
					}
				}
			}
		}

		private void mrcgZsySeBJGLJfZMFgQRpWqKcPu()
		{
			HardwareJoystickMap.Platform_Fallback_Base.Axis[] axes_orig = ((HardwareJoystickMap.Platform_Fallback_Base)pAhzhvigFoLFbwPDdcXHatZWRIl.map).Axes_orig;
			if (axes_orig == null)
			{
				return;
			}
			for (int i = 0; i < axes_orig.Length; i++)
			{
				if (axes_orig[i] == null)
				{
					continue;
				}
				if (i >= beRmxTPYgeEljczGnIuTQeGMXoR)
				{
					throw new Exception("Number of axes in hardware map does not match number of axes found in controller!");
				}
				float num = gSbFUoUKksdvWoYrVCrMmdUmQbI(axes_orig[i]);
				if (fMaBRrMSrsdNukczypLZCirAhksd[i] == num)
				{
					continue;
				}
				fMaBRrMSrsdNukczypLZCirAhksd[i] = num;
				if (!rYbMdzkuuTHGJnaUhDehKzyRinB[i])
				{
					if (axes_orig[i].sourceType == HardwareElementSourceTypeWithHat.Axis)
					{
						float num2 = gSbFUoUKksdvWoYrVCrMmdUmQbI(axes_orig[i].sourceAxis);
						rYbMdzkuuTHGJnaUhDehKzyRinB[i] = num2 != 0f;
					}
					else
					{
						rYbMdzkuuTHGJnaUhDehKzyRinB[i] = true;
					}
				}
				if (!xwlciijKucqyJFICAlBeQdiMzfmY && fMaBRrMSrsdNukczypLZCirAhksd[i] != 0f)
				{
					xwlciijKucqyJFICAlBeQdiMzfmY = true;
				}
			}
		}

		private void ZoEfBvZLEHeQeEqRqOmhOcalkaSu()
		{
			HardwareJoystickMap.Platform_Fallback_Base.Button[] buttons_orig = ((HardwareJoystickMap.Platform_Fallback_Base)pAhzhvigFoLFbwPDdcXHatZWRIl.map).Buttons_orig;
			if (buttons_orig == null)
			{
				return;
			}
			for (int i = 0; i < buttons_orig.Length; i++)
			{
				if (i >= aumNItRblDdXZicbRkrPApteCjR)
				{
					throw new Exception("Number of buttons in hardware map does not match number of buttons found in controller!");
				}
				bool flag = MBcFiZeZyRdrKwPqvdeFcRGWuORk(buttons_orig[i]);
				if (PVITKWpmXlCUxbOeOgCPsJPiOjmf[i] != flag)
				{
					PVITKWpmXlCUxbOeOgCPsJPiOjmf[i] = flag;
					if (!xwlciijKucqyJFICAlBeQdiMzfmY && PVITKWpmXlCUxbOeOgCPsJPiOjmf[i])
					{
						xwlciijKucqyJFICAlBeQdiMzfmY = true;
					}
				}
			}
		}

		private bool MBcFiZeZyRdrKwPqvdeFcRGWuORk(HardwareJoystickMap.Platform_Fallback_Base.Button P_0)
		{
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Button)
			{
				if (P_0.ignoreIfButtonsActive)
				{
					for (int i = 0; i < P_0.ignoreIfButtonsActiveButtons.Length; i++)
					{
						if (MBcFiZeZyRdrKwPqvdeFcRGWuORk(P_0.ignoreIfButtonsActiveButtons[i]))
						{
							return false;
						}
					}
				}
				if (P_0.requireMultipleButtons)
				{
					bool flag = false;
					for (int j = 0; j < P_0.requiredButtons.Length; j++)
					{
						if (!MBcFiZeZyRdrKwPqvdeFcRGWuORk(P_0.requiredButtons[j]))
						{
							return false;
						}
						flag = true;
					}
					if (flag)
					{
						return true;
					}
					return false;
				}
				if (P_0.sourceButton == UnityButton.None)
				{
					return false;
				}
				return MBcFiZeZyRdrKwPqvdeFcRGWuORk(P_0.sourceButton);
			}
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Axis)
			{
				if (P_0.sourceAxis == UnityAxis.None)
				{
					return false;
				}
				float num = gSbFUoUKksdvWoYrVCrMmdUmQbI(P_0.sourceAxis);
				if (MathTools.Abs(num) <= P_0.axisDeadZone)
				{
					return false;
				}
				if (P_0.sourceAxisPole == Pole.Positive && num < 0f)
				{
					return false;
				}
				if (P_0.sourceAxisPole == Pole.Negative && num > 0f)
				{
					return false;
				}
				return true;
			}
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Hat)
			{
				if (P_0.unityHat_sourceAxis1 == UnityAxis.None || P_0.unityHat_sourceAxis2 == UnityAxis.None)
				{
					return false;
				}
				UnityAxis unityHat_sourceAxis = P_0.unityHat_sourceAxis1;
				UnityAxis unityHat_sourceAxis2 = P_0.unityHat_sourceAxis2;
				float num2 = gSbFUoUKksdvWoYrVCrMmdUmQbI(unityHat_sourceAxis);
				float num3 = gSbFUoUKksdvWoYrVCrMmdUmQbI(unityHat_sourceAxis2);
				float x;
				float y;
				if (P_0.unityHat_checkNeverPressed)
				{
					if (PUxlsjteVuKAxIzPtDwreHeKcD(unityHat_sourceAxis) || PUxlsjteVuKAxIzPtDwreHeKcD(unityHat_sourceAxis2))
					{
						x = P_0.unityHat_zeroValues.x;
						y = P_0.unityHat_zeroValues.y;
					}
					else
					{
						x = P_0.unityHat_neverPressedZeroValues.x;
						y = P_0.unityHat_neverPressedZeroValues.y;
					}
				}
				else
				{
					x = P_0.unityHat_zeroValues.x;
					y = P_0.unityHat_zeroValues.y;
				}
				if (MathTools.Approximately(num2, x) && MathTools.Approximately(num3, y))
				{
					return false;
				}
				if (zgofQtbkAmxfsjEmowfnIuOzhfme(P_0.unityHat_isActiveAxisValues1.x, num2) && zgofQtbkAmxfsjEmowfnIuOzhfme(P_0.unityHat_isActiveAxisValues1.y, num3))
				{
					return true;
				}
				if (zgofQtbkAmxfsjEmowfnIuOzhfme(P_0.unityHat_isActiveAxisValues2.x, num2) && zgofQtbkAmxfsjEmowfnIuOzhfme(P_0.unityHat_isActiveAxisValues2.y, num3))
				{
					return true;
				}
				if (zgofQtbkAmxfsjEmowfnIuOzhfme(P_0.unityHat_isActiveAxisValues3.x, num2) && zgofQtbkAmxfsjEmowfnIuOzhfme(P_0.unityHat_isActiveAxisValues3.y, num3))
				{
					return true;
				}
			}
			else
			{
				if (P_0.sourceType == HardwareElementSourceTypeWithHat.Key)
				{
					if (P_0.sourceKeyCode == KeyCode.None)
					{
						return false;
					}
					return Input.GetKey(P_0.sourceKeyCode);
				}
				if (P_0.sourceType == HardwareElementSourceTypeWithHat.Custom)
				{
					CustomCalculation customCalculation = P_0.customCalculation;
					if (customCalculation == null)
					{
						return false;
					}
					if (customCalculation.ResultType != TypeWrapper.DataType.Single)
					{
						return false;
					}
					HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData[] customCalculationSourceData = P_0.customCalculationSourceData;
					if (customCalculationSourceData == null)
					{
						return false;
					}
					for (int k = 0; k < customCalculationSourceData.Length; k++)
					{
						if (customCalculationSourceData[k] == null)
						{
							continue;
						}
						switch ((HardwareElementSourceTypeWithHat)customCalculationSourceData[k].sourceType)
						{
						case HardwareElementSourceTypeWithHat.Button:
						{
							if (TYhZFIeJiMezIRPdlInkPoJvAEc(customCalculationSourceData[k], out var flag3))
							{
								customCalculation.AddData(flag3 ? 1f : 0f);
							}
							break;
						}
						case HardwareElementSourceTypeWithHat.Axis:
						{
							if (uOiFDLTDHmbpCtyZKBpdvjdnGDVg(customCalculationSourceData[k], out var num4))
							{
								customCalculation.AddData((num4 != 0f) ? 1f : 0f);
							}
							break;
						}
						case HardwareElementSourceTypeWithHat.Key:
						{
							if (BBjzKzUOYaplTNvpLQnuenBBSFr(customCalculationSourceData[k], out var flag2))
							{
								customCalculation.AddData(flag2 ? 1f : 0f);
							}
							break;
						}
						}
					}
					if (!customCalculation.Process())
					{
						return false;
					}
					if (customCalculation.Result.type != TypeWrapper.DataType.Single)
					{
						return false;
					}
					return (float)customCalculation.Result != 0f;
				}
			}
			return false;
		}

		private bool zgofQtbkAmxfsjEmowfnIuOzhfme(float P_0, float P_1)
		{
			return MathTools.IsNear(P_1, P_0, 0.1f);
		}

		private float gSbFUoUKksdvWoYrVCrMmdUmQbI(HardwareJoystickMap.Platform_Fallback_Base.Axis P_0)
		{
			switch (P_0.sourceType)
			{
			case HardwareElementSourceTypeWithHat.Axis:
				if (P_0.sourceAxis == UnityAxis.None)
				{
					return 0f;
				}
				if (!PUxlsjteVuKAxIzPtDwreHeKcD(P_0.sourceAxis))
				{
					return 0f;
				}
				return gSbFUoUKksdvWoYrVCrMmdUmQbI(P_0.sourceAxis);
			case HardwareElementSourceTypeWithHat.Button:
				if (P_0.sourceButton == UnityButton.None)
				{
					return 0f;
				}
				if (!MBcFiZeZyRdrKwPqvdeFcRGWuORk(P_0.sourceButton))
				{
					return 0f;
				}
				if (P_0.buttonAxisContribution == Pole.Positive)
				{
					return 1f;
				}
				return -1f;
			case HardwareElementSourceTypeWithHat.Key:
				if (P_0.sourceKeyCode == KeyCode.None)
				{
					return 0f;
				}
				if (!Input.GetKey(P_0.sourceKeyCode))
				{
					return 0f;
				}
				if (P_0.buttonAxisContribution == Pole.Positive)
				{
					return 1f;
				}
				return -1f;
			case HardwareElementSourceTypeWithHat.Custom:
			{
				CustomCalculation customCalculation = P_0.customCalculation;
				if (customCalculation == null)
				{
					return 0f;
				}
				if (customCalculation.ResultType != TypeWrapper.DataType.Single)
				{
					return 0f;
				}
				HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData[] customCalculationSourceData = P_0.customCalculationSourceData;
				if (customCalculationSourceData == null)
				{
					return 0f;
				}
				for (int i = 0; i < customCalculationSourceData.Length; i++)
				{
					if (customCalculationSourceData[i] != null)
					{
						HardwareElementSourceTypeWithHat sourceType = (HardwareElementSourceTypeWithHat)customCalculationSourceData[i].sourceType;
						HardwareElementSourceTypeWithHat hardwareElementSourceTypeWithHat = sourceType;
						if (hardwareElementSourceTypeWithHat == HardwareElementSourceTypeWithHat.Axis && uOiFDLTDHmbpCtyZKBpdvjdnGDVg(customCalculationSourceData[i], out var item))
						{
							customCalculation.AddData(item);
						}
					}
				}
				if (!customCalculation.Process())
				{
					return 0f;
				}
				if (customCalculation.Result.type != TypeWrapper.DataType.Single)
				{
					return 0f;
				}
				return customCalculation.Result;
			}
			default:
				return 0f;
			}
		}

		private float gSbFUoUKksdvWoYrVCrMmdUmQbI(UnityAxis P_0)
		{
			if (P_0 == UnityAxis.None)
			{
				return 0f;
			}
			int num = (int)(P_0 - 1);
			return oHxLISXQLdUWhyitRGfORHClHAT[num];
		}

		private bool MBcFiZeZyRdrKwPqvdeFcRGWuORk(UnityButton P_0)
		{
			int buttonIndex = (int)(P_0 - 1);
			return UnityInputHelper.GetJoystickButtonValueByJoystickId(cHGGtPQmQEdFSaIvpIgqFYTwIUM, buttonIndex);
		}

		private bool TYhZFIeJiMezIRPdlInkPoJvAEc(HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData P_0, out bool P_1)
		{
			P_1 = false;
			if (P_0.sourceType != 0)
			{
				return false;
			}
			UnityButton sourceElement = (UnityButton)P_0.sourceElement;
			if (sourceElement == UnityButton.None)
			{
				return false;
			}
			P_1 = MBcFiZeZyRdrKwPqvdeFcRGWuORk(sourceElement);
			return true;
		}

		private bool BBjzKzUOYaplTNvpLQnuenBBSFr(HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData P_0, out bool P_1)
		{
			P_1 = false;
			if (P_0.sourceType != 3)
			{
				return false;
			}
			KeyCode sourceElement = (KeyCode)P_0.sourceElement;
			if (sourceElement == KeyCode.None)
			{
				return false;
			}
			P_1 = Input.GetKey(sourceElement);
			return true;
		}

		private bool uOiFDLTDHmbpCtyZKBpdvjdnGDVg(HardwareJoystickMap.Platform_Fallback_Base.CustomCalculationSourceData P_0, out float P_1)
		{
			P_1 = 0f;
			if (P_0.sourceType != 1)
			{
				return false;
			}
			UnityAxis sourceElement = (UnityAxis)P_0.sourceElement;
			if (sourceElement == UnityAxis.None)
			{
				return false;
			}
			P_1 = gSbFUoUKksdvWoYrVCrMmdUmQbI(sourceElement);
			switch (P_0.sourceAxisRange)
			{
			case AxisRange.Negative:
				if (P_1 > 0f)
				{
					P_1 = 0f;
				}
				break;
			case AxisRange.Positive:
				if (P_1 < 0f)
				{
					P_1 = 0f;
				}
				break;
			}
			if (P_0.deadzone > 0f && MathTools.Abs(P_1) <= P_0.deadzone)
			{
				P_1 = 0f;
			}
			if (P_0.invert)
			{
				P_1 *= -1f;
			}
			return true;
		}

		private bool PUxlsjteVuKAxIzPtDwreHeKcD(UnityAxis P_0)
		{
			int num = (int)(P_0 - 1);
			return NGIpVchjNIOIQeikqJpsUcfWDySh[num];
		}

		private void fnbWnKnajTExrfChSQLkKMdqfpwH()
		{
			BridgedControllerHWInfo bridgedControllerHWInfo = rtmepNGyphMMGYpeiwSMrmBNGeQC();
			if (UnityTools.isAndroidPlatform)
			{
				if (Regex.IsMatch(luRMxZWAqFInBgOhniYAkCgTarz, "Xbox Wireless Controller.*"))
				{
					UnityTools.externalTools.GetDeviceVIDPIDs(out var vids, out var pids);
					for (int i = 0; i < vids.Count; i++)
					{
						if (vids[i] == 1118 && pids[i] == 736)
						{
							bridgedControllerHWInfo.definitionMatchTag = "[FW1]";
							break;
						}
					}
				}
				else if (UnityTools.androidFallbackPlatformHelper != null)
				{
					IAndroidFallbackDS4Helper ds4Helper = UnityTools.androidFallbackPlatformHelper.ds4Helper;
					if (ds4Helper != null && ds4Helper.IsDS4(luRMxZWAqFInBgOhniYAkCgTarz))
					{
						if (ds4Helper.IsDS4KeyMapped(pIPICYzGkabAtowsQcODfpQhlrR))
						{
							bridgedControllerHWInfo.definitionMatchTag = "[KEYMAP]";
						}
						else
						{
							bridgedControllerHWInfo.definitionMatchTag = "[NOKEYMAP]";
						}
					}
				}
			}
			pAhzhvigFoLFbwPDdcXHatZWRIl = ReInput.GetHardwareJoystickMap_InputManager(bridgedControllerHWInfo);
			if (pAhzhvigFoLFbwPDdcXHatZWRIl == null)
			{
				Rewired.Logger.LogError("Default hardware map not found!");
				return;
			}
			if (pAhzhvigFoLFbwPDdcXHatZWRIl.useSystemName && !string.IsNullOrEmpty(luRMxZWAqFInBgOhniYAkCgTarz))
			{
				string text = Regex.Replace(luRMxZWAqFInBgOhniYAkCgTarz, "\\s+", " ");
				text = text.Trim();
				if (!string.IsNullOrEmpty(text))
				{
					pAhzhvigFoLFbwPDdcXHatZWRIl.controllerName = text;
				}
			}
			if (UnityTools.isIOSPlatform && pAhzhvigFoLFbwPDdcXHatZWRIl.hardwareMapIdentifier.guid == Consts.joystickGuid_appleMFiController)
			{
				string text2 = ynkmfRwrabBcfArdKwiIqpfVgOI(luRMxZWAqFInBgOhniYAkCgTarz);
				if (!string.IsNullOrEmpty(text2))
				{
					pAhzhvigFoLFbwPDdcXHatZWRIl.controllerName = text2;
				}
			}
			beRmxTPYgeEljczGnIuTQeGMXoR = pAhzhvigFoLFbwPDdcXHatZWRIl.axisCount;
			aumNItRblDdXZicbRkrPApteCjR = pAhzhvigFoLFbwPDdcXHatZWRIl.buttonCount;
		}

		private void FxcLOucRQkrrYFkHqvCUxSLMADZ()
		{
			Array.Clear(PVITKWpmXlCUxbOeOgCPsJPiOjmf, 0, PVITKWpmXlCUxbOeOgCPsJPiOjmf.Length);
			Array.Clear(fMaBRrMSrsdNukczypLZCirAhksd, 0, fMaBRrMSrsdNukczypLZCirAhksd.Length);
		}

		private string bLgThVKCoYJbgKRAATyCovcPExh()
		{
			if (ReInput.currentPlatform == Platform.Webplayer)
			{
				return InputTools.FormatHardwareIdentifierString($"{ReInput.currentPlatform.ToString()}{ReInput.webplayerPlatform.ToString()}{dwahMpvKTveSdmXVjlxHRlTCyOH().ToString()}{luRMxZWAqFInBgOhniYAkCgTarz}");
			}
			if (UnityTools.isIOSPlatform)
			{
				string arg = Regex.Replace(luRMxZWAqFInBgOhniYAkCgTarz, "joystick [0-9]+ by ", "");
				return InputTools.FormatHardwareIdentifierString($"{ReInput.currentPlatform.ToString()}{dwahMpvKTveSdmXVjlxHRlTCyOH().ToString()}{arg}");
			}
			return InputTools.FormatHardwareIdentifierString($"{ReInput.currentPlatform.ToString()}{dwahMpvKTveSdmXVjlxHRlTCyOH().ToString()}{luRMxZWAqFInBgOhniYAkCgTarz}");
		}

		private InputSource dwahMpvKTveSdmXVjlxHRlTCyOH()
		{
			if (UnityTools.platform == Platform.Linux && UnityTools.externalTools.LinuxInput_IsJoystickPreconfigured(luRMxZWAqFInBgOhniYAkCgTarz))
			{
				return InputSource.Fallback_PreConfigured;
			}
			return InputSource.Fallback;
		}

		public static int QWRAqqDVdRarhOjzSpdusXmYAGUC(MsPnivhhvngiwjBoCnYOEiefUofk P_0, MsPnivhhvngiwjBoCnYOEiefUofk P_1)
		{
			if (P_0.inputManagerId < P_1.inputManagerId)
			{
				return -1;
			}
			if (P_0.inputManagerId > P_1.inputManagerId)
			{
				return 1;
			}
			return 0;
		}

		public static int MWNsKfqwZQWlNxpGNcmAKEEZkwR(MsPnivhhvngiwjBoCnYOEiefUofk P_0, MsPnivhhvngiwjBoCnYOEiefUofk P_1)
		{
			if (P_0.unityId < P_1.unityId)
			{
				return -1;
			}
			if (P_0.unityId > P_1.unityId)
			{
				return 1;
			}
			return 0;
		}

		private static string ynkmfRwrabBcfArdKwiIqpfVgOI(string P_0)
		{
			string input = Regex.Replace(P_0, "\\[.*\\] joystick [0-9]+ by ", "");
			input = Regex.Replace(input, "\\s+", " ");
			if (!string.IsNullOrEmpty(input))
			{
				input = input.Trim();
			}
			return input;
		}
	}

	private class CeheUnavwCwNItOJUwDNfBkOhMIp
	{
		public enum oMWilpQsvAaoaoaybALYDUFEqxYh
		{
			FSpAuHtupjDZXhUqvazjlutzPIHg = 0,
			zolnAcOnXpGZenMMlAIrNiahLST = 1
		}

		public class waawvpZfQqiFtXyHGlmczWJVIol
		{
			public int gNijVFSxPIkIXVEBfXiCOWbvkEY;

			public int pIPICYzGkabAtowsQcODfpQhlrR;

			public string ueeEIliAfDJvbLjXlOyWMalYqyKe;

			public int uDYTVizJuwnXvzyofQhbtGjAJpaE;

			public string MNmRhbRuAIbFPiwJKgKPELqwaeZ;

			public bool sRrGplMHNlzmCBfgKNqGViUdGhN(MsPnivhhvngiwjBoCnYOEiefUofk P_0, oMWilpQsvAaoaoaybALYDUFEqxYh P_1)
			{
				if (P_0.rewiredId == gNijVFSxPIkIXVEBfXiCOWbvkEY)
				{
					return true;
				}
				if ((!string.IsNullOrEmpty(MNmRhbRuAIbFPiwJKgKPELqwaeZ) || !string.IsNullOrEmpty(P_0.MNmRhbRuAIbFPiwJKgKPELqwaeZ)) && !string.Equals(MNmRhbRuAIbFPiwJKgKPELqwaeZ, P_0.MNmRhbRuAIbFPiwJKgKPELqwaeZ, StringComparison.Ordinal))
				{
					return false;
				}
				switch (P_1)
				{
				case oMWilpQsvAaoaoaybALYDUFEqxYh.FSpAuHtupjDZXhUqvazjlutzPIHg:
					if (pIPICYzGkabAtowsQcODfpQhlrR == P_0.pIPICYzGkabAtowsQcODfpQhlrR)
					{
						return ueeEIliAfDJvbLjXlOyWMalYqyKe == P_0.luRMxZWAqFInBgOhniYAkCgTarz;
					}
					return false;
				case oMWilpQsvAaoaoaybALYDUFEqxYh.zolnAcOnXpGZenMMlAIrNiahLST:
					return ueeEIliAfDJvbLjXlOyWMalYqyKe == P_0.luRMxZWAqFInBgOhniYAkCgTarz;
				default:
					throw new NotImplementedException();
				}
			}
		}

		private List<waawvpZfQqiFtXyHGlmczWJVIol> BOUZQgfjcmguYdmiFTTQVpzRKHM;

		public int ioXgUGjpFGeVuGnqwbPHBeKgnSzF => BOUZQgfjcmguYdmiFTTQVpzRKHM.Count;

		public CeheUnavwCwNItOJUwDNfBkOhMIp()
		{
			BOUZQgfjcmguYdmiFTTQVpzRKHM = new List<waawvpZfQqiFtXyHGlmczWJVIol>();
		}

		public void ROWDMagIyIfgsVWhoSroKVHpUgvW(MsPnivhhvngiwjBoCnYOEiefUofk P_0)
		{
			if (P_0 == null)
			{
				return;
			}
			int count = BOUZQgfjcmguYdmiFTTQVpzRKHM.Count;
			for (int i = 0; i < count; i++)
			{
				if (BOUZQgfjcmguYdmiFTTQVpzRKHM[i].sRrGplMHNlzmCBfgKNqGViUdGhN(P_0, oMWilpQsvAaoaoaybALYDUFEqxYh.FSpAuHtupjDZXhUqvazjlutzPIHg))
				{
					BOUZQgfjcmguYdmiFTTQVpzRKHM[i].gNijVFSxPIkIXVEBfXiCOWbvkEY = P_0.rewiredId;
					BOUZQgfjcmguYdmiFTTQVpzRKHM[i].ueeEIliAfDJvbLjXlOyWMalYqyKe = P_0.luRMxZWAqFInBgOhniYAkCgTarz;
					BOUZQgfjcmguYdmiFTTQVpzRKHM[i].pIPICYzGkabAtowsQcODfpQhlrR = P_0.pIPICYzGkabAtowsQcODfpQhlrR;
					BOUZQgfjcmguYdmiFTTQVpzRKHM[i].uDYTVizJuwnXvzyofQhbtGjAJpaE = P_0.inputManagerId;
					BOUZQgfjcmguYdmiFTTQVpzRKHM[i].MNmRhbRuAIbFPiwJKgKPELqwaeZ = P_0.MNmRhbRuAIbFPiwJKgKPELqwaeZ;
					jLGvBZyUjbsddWQKdQjBFPHHJQN(P_0.rewiredId, i);
					return;
				}
			}
			BOUZQgfjcmguYdmiFTTQVpzRKHM.Add(new waawvpZfQqiFtXyHGlmczWJVIol
			{
				gNijVFSxPIkIXVEBfXiCOWbvkEY = P_0.rewiredId,
				ueeEIliAfDJvbLjXlOyWMalYqyKe = P_0.luRMxZWAqFInBgOhniYAkCgTarz,
				pIPICYzGkabAtowsQcODfpQhlrR = P_0.pIPICYzGkabAtowsQcODfpQhlrR,
				uDYTVizJuwnXvzyofQhbtGjAJpaE = P_0.inputManagerId,
				MNmRhbRuAIbFPiwJKgKPELqwaeZ = P_0.MNmRhbRuAIbFPiwJKgKPELqwaeZ
			});
			jLGvBZyUjbsddWQKdQjBFPHHJQN(P_0.rewiredId, BOUZQgfjcmguYdmiFTTQVpzRKHM.Count - 1);
		}

		public bool oQFygjrDaMtXNUGnYpOhqPuoBesB(MsPnivhhvngiwjBoCnYOEiefUofk P_0, oMWilpQsvAaoaoaybALYDUFEqxYh P_1)
		{
			int count = BOUZQgfjcmguYdmiFTTQVpzRKHM.Count;
			for (int i = 0; i < count; i++)
			{
				if (BOUZQgfjcmguYdmiFTTQVpzRKHM[i].sRrGplMHNlzmCBfgKNqGViUdGhN(P_0, P_1))
				{
					return true;
				}
			}
			return false;
		}

		public IEnumerable<waawvpZfQqiFtXyHGlmczWJVIol> WfScZfFnYvGYNnfxpPOcIypkwcfV(MsPnivhhvngiwjBoCnYOEiefUofk P_0, oMWilpQsvAaoaoaybALYDUFEqxYh P_1)
		{
			int count = BOUZQgfjcmguYdmiFTTQVpzRKHM.Count;
			for (int i = 0; i < count; i++)
			{
				if (BOUZQgfjcmguYdmiFTTQVpzRKHM[i].sRrGplMHNlzmCBfgKNqGViUdGhN(P_0, P_1))
				{
					yield return BOUZQgfjcmguYdmiFTTQVpzRKHM[i];
				}
			}
		}

		public int eaOrStrSOuOlEEMmganiuTHlvbL(waawvpZfQqiFtXyHGlmczWJVIol P_0)
		{
			int count = BOUZQgfjcmguYdmiFTTQVpzRKHM.Count;
			for (int i = 0; i < count; i++)
			{
				if (BOUZQgfjcmguYdmiFTTQVpzRKHM[i] == P_0)
				{
					return i;
				}
			}
			return -1;
		}

		private void jLGvBZyUjbsddWQKdQjBFPHHJQN(int P_0, int P_1)
		{
			for (int num = BOUZQgfjcmguYdmiFTTQVpzRKHM.Count - 1; num >= 0; num--)
			{
				if (num != P_1 && BOUZQgfjcmguYdmiFTTQVpzRKHM[num].gNijVFSxPIkIXVEBfXiCOWbvkEY == P_0)
				{
					BOUZQgfjcmguYdmiFTTQVpzRKHM.RemoveAt(num);
				}
			}
		}
	}

	private List<MsPnivhhvngiwjBoCnYOEiefUofk> mqdAbRkCKsLDODrmCZPalaGwyaPz;

	private int XIizDAIvfXWSeeEunnkOyCetKzC;

	private CeheUnavwCwNItOJUwDNfBkOhMIp tWaggyJPBcRxwyAUFZkujNIcHgO;

	private bool dwsDsPDKgHTKQVAjREDWSXOsYkJ;

	private bool xITxQnsYIaSncEtDwaqnAbbkRai;

	private UpdateLoopType TnidRhAIPvMICseBcUJBQDrSFxL;

	private UpdateLoopType pwCHlVAXqOkeMGtoncWzBSGmuxy;

	private TimerAbs ZYwrSlpFpbBfKcWaftECaMBFDBB;

	private Action<int, ControllerDataUpdater> kcCBEvsiDFcwqeYRbhjvVDrLnNvd;

	private PlatformInputManager aTqiuENnHjmuSZPlDcgXHhWiQkqb;

	private readonly IUnifiedKeyboardSource ezdTZbpCGxXlKBhmftKgVJlfbSL;

	private readonly IUnifiedMouseSource CTbLquOqVjiyntzbVllPcctkhGD;

	private bool WUxRfowFWZKDQlOcvzfYhDOvPfS;

	private string[] yKFVQHQqQQpJNlBLneGKZcjXkPQ;

	[CustomObfuscation(rename = false)]
	public override int deviceCount => XIizDAIvfXWSeeEunnkOyCetKzC;

	[CustomObfuscation(rename = false)]
	public override PlatformInputManager primaryInputManager => aTqiuENnHjmuSZPlDcgXHhWiQkqb;

	[CustomObfuscation(rename = false)]
	public override IInputSource inputSource => null;

	[CustomObfuscation(rename = false)]
	public override InputSource inputSourceType => InputSource.Fallback;

	public SixoesdehMBTLhdCUzhvkfIAMwel(UpdateLoopSetting updateLoopSetting)
	{
		aTqiuENnHjmuSZPlDcgXHhWiQkqb = this;
		ezdTZbpCGxXlKBhmftKgVJlfbSL = new UnityUnifiedKeyboardSource();
		CTbLquOqVjiyntzbVllPcctkhGD = new UnityUnifiedMouseSource();
		using (TempListPool.TList<UpdateLoopType> tList = TempListPool.GetTList<UpdateLoopType>(3))
		{
			List<UpdateLoopType> list = tList.list;
			EnumConverter.ToUpdateLoopTypes(updateLoopSetting, list);
			int num = 0;
			if (num < list.Count)
			{
				pwCHlVAXqOkeMGtoncWzBSGmuxy = list[num];
			}
		}
		yKFVQHQqQQpJNlBLneGKZcjXkPQ = new string[0];
		kcCBEvsiDFcwqeYRbhjvVDrLnNvd = UpdateControllerData;
	}

	[CustomObfuscation(rename = false)]
	public override void Initialize()
	{
		if (UnityTools.isAndroidPlatform && UnityTools.androidFallbackPlatformHelper != null)
		{
			UnityTools.androidFallbackPlatformHelper.DeviceChangedEvent += ycDeCEQgHajFGdiSIMXLurmiNJu;
		}
		ZYwrSlpFpbBfKcWaftECaMBFDBB = new TimerAbs(1.0);
		tWaggyJPBcRxwyAUFZkujNIcHgO = new CeheUnavwCwNItOJUwDNfBkOhMIp();
		ensYNqjPxhKHeyOUbkLdLoRguEI();
		dwsDsPDKgHTKQVAjREDWSXOsYkJ = true;
		ZYwrSlpFpbBfKcWaftECaMBFDBB.Start();
	}

	[CustomObfuscation(rename = false)]
	public override void Update(UpdateLoopType updateLoop)
	{
		TnidRhAIPvMICseBcUJBQDrSFxL = updateLoop;
		keuiQOsVWdsoFLzpXABzFTayFwN();
		if (dwsDsPDKgHTKQVAjREDWSXOsYkJ)
		{
			wCDaVFQPEORUeWyoEnGRkTcDqlD();
		}
		HjPmTvcviOfgWiHOydmvDBtIjMVH(updateLoop);
	}

	[CustomObfuscation(rename = false)]
	public override void OnDestroy()
	{
		if (UnityTools.isAndroidPlatform && UnityTools.androidFallbackPlatformHelper != null)
		{
			UnityTools.androidFallbackPlatformHelper.DeviceChangedEvent -= ycDeCEQgHajFGdiSIMXLurmiNJu;
		}
		(ezdTZbpCGxXlKBhmftKgVJlfbSL as IDisposable).Dispose();
		(CTbLquOqVjiyntzbVllPcctkhGD as IDisposable).Dispose();
	}

	[CustomObfuscation(rename = false)]
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate()
	{
		return kcCBEvsiDFcwqeYRbhjvVDrLnNvd;
	}

	[CustomObfuscation(rename = false)]
	public override void UpdateControllerData(int assignedControllerId, ControllerDataUpdater data)
	{
		for (int i = 0; i < XIizDAIvfXWSeeEunnkOyCetKzC; i++)
		{
			if (mqdAbRkCKsLDODrmCZPalaGwyaPz[i].inputManagerId == assignedControllerId)
			{
				mqdAbRkCKsLDODrmCZPalaGwyaPz[i].FillData(data);
				return;
			}
		}
		Rewired.Logger.LogError("Invalid joystick Id " + assignedControllerId + "!");
	}

	[CustomObfuscation(rename = false)]
	public override void SystemDeviceConnected()
	{
		dwsDsPDKgHTKQVAjREDWSXOsYkJ = true;
		if (_SystemDeviceConnectedEvent != null)
		{
			_SystemDeviceConnectedEvent();
		}
	}

	[CustomObfuscation(rename = false)]
	public override void SystemDeviceDisconnected()
	{
		dwsDsPDKgHTKQVAjREDWSXOsYkJ = true;
		if (_SystemDeviceDisconnectedEvent != null)
		{
			_SystemDeviceDisconnectedEvent();
		}
	}

	private void ycDeCEQgHajFGdiSIMXLurmiNJu()
	{
		dwsDsPDKgHTKQVAjREDWSXOsYkJ = true;
		xITxQnsYIaSncEtDwaqnAbbkRai = true;
	}

	[CustomObfuscation(rename = false)]
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId)
	{
		for (int i = 0; i < mqdAbRkCKsLDODrmCZPalaGwyaPz.Count; i++)
		{
			if (mqdAbRkCKsLDODrmCZPalaGwyaPz[i].unityId == unityJoystickId)
			{
				mqdAbRkCKsLDODrmCZPalaGwyaPz[i].swGfAgHQUqPLnzipiPrCKvmcObYR();
			}
		}
		for (int j = 0; j < mqdAbRkCKsLDODrmCZPalaGwyaPz.Count; j++)
		{
			if (mqdAbRkCKsLDODrmCZPalaGwyaPz[j].rewiredId == joystickId)
			{
				mqdAbRkCKsLDODrmCZPalaGwyaPz[j].PwXCqpiOTklLeCgDEPZDbkqzpErB(unityJoystickId);
				break;
			}
		}
	}

	[CustomObfuscation(rename = false)]
	public override IUnifiedMouseSource GetUnifiedMouseSource()
	{
		return CTbLquOqVjiyntzbVllPcctkhGD;
	}

	[CustomObfuscation(rename = false)]
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource()
	{
		return ezdTZbpCGxXlKBhmftKgVJlfbSL;
	}

	private void ensYNqjPxhKHeyOUbkLdLoRguEI()
	{
		ensYNqjPxhKHeyOUbkLdLoRguEI(Input.GetJoystickNames());
	}

	private void ensYNqjPxhKHeyOUbkLdLoRguEI(string[] P_0)
	{
		int num = 0;
		List<MsPnivhhvngiwjBoCnYOEiefUofk> list = mqdAbRkCKsLDODrmCZPalaGwyaPz;
		int xIizDAIvfXWSeeEunnkOyCetKzC = XIizDAIvfXWSeeEunnkOyCetKzC;
		mqdAbRkCKsLDODrmCZPalaGwyaPz = new List<MsPnivhhvngiwjBoCnYOEiefUofk>();
		for (int i = 0; i < P_0.Length; i++)
		{
			string text = StringTools.SanitizeDeviceString(P_0[i]);
			if (UnityTools.IsValidUnityJoystickName(text))
			{
				MsPnivhhvngiwjBoCnYOEiefUofk msPnivhhvngiwjBoCnYOEiefUofk = new MsPnivhhvngiwjBoCnYOEiefUofk();
				msPnivhhvngiwjBoCnYOEiefUofk.luRMxZWAqFInBgOhniYAkCgTarz = text;
				msPnivhhvngiwjBoCnYOEiefUofk.GqiGmXqCHcCxbQPkTYeaNPbxCrCD = text;
				msPnivhhvngiwjBoCnYOEiefUofk.pIPICYzGkabAtowsQcODfpQhlrR = i;
				msPnivhhvngiwjBoCnYOEiefUofk.unityId = i + 1;
				if (UnityTools.isAndroidPlatform && UnityTools.androidFallbackPlatformHelper != null)
				{
					msPnivhhvngiwjBoCnYOEiefUofk.MNmRhbRuAIbFPiwJKgKPELqwaeZ = UnityTools.androidFallbackPlatformHelper.GetUniqueDeviceIdentifier(text, i);
				}
				msPnivhhvngiwjBoCnYOEiefUofk.UcMFLlIeEVgVHdWycYuHxpkWVTYD();
				mqdAbRkCKsLDODrmCZPalaGwyaPz.Add(msPnivhhvngiwjBoCnYOEiefUofk);
				num++;
			}
		}
		XIizDAIvfXWSeeEunnkOyCetKzC = num;
		uUjXiurHcZMVvSbyRINtfLKgLmy(xIizDAIvfXWSeeEunnkOyCetKzC, num, list, mqdAbRkCKsLDODrmCZPalaGwyaPz);
		for (int j = 0; j < num; j++)
		{
			if (_UpdateControllerInfoEvent != null)
			{
				_UpdateControllerInfoEvent(new UpdateControllerInfoEventArgs(mqdAbRkCKsLDODrmCZPalaGwyaPz[j]));
			}
		}
		lKgzcfQSolDGPyoEdiWHqTPwByFB(list, mqdAbRkCKsLDODrmCZPalaGwyaPz, false);
		lKgzcfQSolDGPyoEdiWHqTPwByFB(mqdAbRkCKsLDODrmCZPalaGwyaPz, list, true);
		yKFVQHQqQQpJNlBLneGKZcjXkPQ = P_0;
	}

	private void HjPmTvcviOfgWiHOydmvDBtIjMVH(UpdateLoopType P_0)
	{
		int count = mqdAbRkCKsLDODrmCZPalaGwyaPz.Count;
		for (int i = 0; i < count; i++)
		{
			if (mqdAbRkCKsLDODrmCZPalaGwyaPz[i] != null)
			{
				mqdAbRkCKsLDODrmCZPalaGwyaPz[i].Update();
			}
		}
	}

	private void uUjXiurHcZMVvSbyRINtfLKgLmy(int P_0, int P_1, List<MsPnivhhvngiwjBoCnYOEiefUofk> P_2, List<MsPnivhhvngiwjBoCnYOEiefUofk> P_3)
	{
		if (P_1 > 0)
		{
			P_3.Sort(MsPnivhhvngiwjBoCnYOEiefUofk.MWNsKfqwZQWlNxpGNcmAKEEZkwR);
		}
		if (P_0 > 0 && P_1 > 0)
		{
			qCjFkjCKBBayHefbiUiJnQdNyEAc(P_1, P_3, P_0, P_2, CeheUnavwCwNItOJUwDNfBkOhMIp.oMWilpQsvAaoaoaybALYDUFEqxYh.FSpAuHtupjDZXhUqvazjlutzPIHg);
			qCjFkjCKBBayHefbiUiJnQdNyEAc(P_1, P_3, P_0, P_2, CeheUnavwCwNItOJUwDNfBkOhMIp.oMWilpQsvAaoaoaybALYDUFEqxYh.zolnAcOnXpGZenMMlAIrNiahLST);
		}
		cxfdSKgGqqAkSHDXxofROylxYBHG(P_1, P_3, CeheUnavwCwNItOJUwDNfBkOhMIp.oMWilpQsvAaoaoaybALYDUFEqxYh.FSpAuHtupjDZXhUqvazjlutzPIHg);
		cxfdSKgGqqAkSHDXxofROylxYBHG(P_1, P_3, CeheUnavwCwNItOJUwDNfBkOhMIp.oMWilpQsvAaoaoaybALYDUFEqxYh.zolnAcOnXpGZenMMlAIrNiahLST);
		for (int i = 0; i < P_1; i++)
		{
			MsPnivhhvngiwjBoCnYOEiefUofk msPnivhhvngiwjBoCnYOEiefUofk = P_3[i];
			if (msPnivhhvngiwjBoCnYOEiefUofk != null && msPnivhhvngiwjBoCnYOEiefUofk.inputManagerId < 0)
			{
				msPnivhhvngiwjBoCnYOEiefUofk.inputManagerId = NyHyNinRgcrbSYtQTeIqkUCRiko(P_3);
				msPnivhhvngiwjBoCnYOEiefUofk.rewiredId = ReInput.GetNewJoystickId();
				tWaggyJPBcRxwyAUFZkujNIcHgO.ROWDMagIyIfgsVWhoSroKVHpUgvW(msPnivhhvngiwjBoCnYOEiefUofk);
			}
		}
		P_3.Sort(MsPnivhhvngiwjBoCnYOEiefUofk.QWRAqqDVdRarhOjzSpdusXmYAGUC);
	}

	private void FnIfaDIUQWVgbiivtjTLYkhLkpq(List<MsPnivhhvngiwjBoCnYOEiefUofk> P_0, int P_1, int P_2)
	{
		int count = P_0.Count;
		for (int i = 0; i < count; i++)
		{
			if (i != P_1 && P_0[i] != null && P_0[i].inputManagerId == P_2)
			{
				P_0[i].inputManagerId = -1;
			}
		}
	}

	private bool NkfgIpcuIAsjZIJbIIBeJvbMbagI(List<MsPnivhhvngiwjBoCnYOEiefUofk> P_0, int P_1)
	{
		int count = P_0.Count;
		for (int i = 0; i < count; i++)
		{
			if (P_0[i] != null && P_0[i].inputManagerId == P_1)
			{
				return false;
			}
		}
		return true;
	}

	private int NyHyNinRgcrbSYtQTeIqkUCRiko(List<MsPnivhhvngiwjBoCnYOEiefUofk> P_0)
	{
		int num = 0;
		while (true)
		{
			bool flag = false;
			int count = P_0.Count;
			for (int i = 0; i < count; i++)
			{
				if (P_0[i] != null && P_0[i].inputManagerId == num)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				break;
			}
			num++;
		}
		return num;
	}

	private bool BaEnDOhUnzNYdsILLLieXmcUjHl(List<MsPnivhhvngiwjBoCnYOEiefUofk> P_0, int P_1)
	{
		if (P_0 == null)
		{
			return false;
		}
		for (int i = 0; i < P_0.Count; i++)
		{
			if (P_0[i].rewiredId == P_1)
			{
				return true;
			}
		}
		return false;
	}

	private void qCjFkjCKBBayHefbiUiJnQdNyEAc(int P_0, List<MsPnivhhvngiwjBoCnYOEiefUofk> P_1, int P_2, List<MsPnivhhvngiwjBoCnYOEiefUofk> P_3, CeheUnavwCwNItOJUwDNfBkOhMIp.oMWilpQsvAaoaoaybALYDUFEqxYh P_4)
	{
		int num = ((P_4 != 0) ? 1 : 2);
		for (int i = 0; i < P_0; i++)
		{
			MsPnivhhvngiwjBoCnYOEiefUofk msPnivhhvngiwjBoCnYOEiefUofk = P_1[i];
			if (msPnivhhvngiwjBoCnYOEiefUofk == null || msPnivhhvngiwjBoCnYOEiefUofk.inputManagerId >= 0)
			{
				continue;
			}
			for (int j = 0; j < P_2; j++)
			{
				MsPnivhhvngiwjBoCnYOEiefUofk msPnivhhvngiwjBoCnYOEiefUofk2 = P_3[j];
				if (msPnivhhvngiwjBoCnYOEiefUofk2 != null && !BaEnDOhUnzNYdsILLLieXmcUjHl(P_1, msPnivhhvngiwjBoCnYOEiefUofk2.rewiredId) && msPnivhhvngiwjBoCnYOEiefUofk.sRrGplMHNlzmCBfgKNqGViUdGhN(msPnivhhvngiwjBoCnYOEiefUofk2) >= num)
				{
					msPnivhhvngiwjBoCnYOEiefUofk.inputManagerId = msPnivhhvngiwjBoCnYOEiefUofk2.inputManagerId;
					msPnivhhvngiwjBoCnYOEiefUofk.rewiredId = msPnivhhvngiwjBoCnYOEiefUofk2.rewiredId;
					if (ReInput.isWindowsStandaloneWebplayerOrEditorPlatform && !UnityTools.windowsJoystickNamesReturnsEmptyStringsIfJoystickNull)
					{
						msPnivhhvngiwjBoCnYOEiefUofk.unityId = msPnivhhvngiwjBoCnYOEiefUofk2.unityId;
					}
					tWaggyJPBcRxwyAUFZkujNIcHgO.ROWDMagIyIfgsVWhoSroKVHpUgvW(msPnivhhvngiwjBoCnYOEiefUofk);
				}
			}
		}
	}

	private void cxfdSKgGqqAkSHDXxofROylxYBHG(int P_0, List<MsPnivhhvngiwjBoCnYOEiefUofk> P_1, CeheUnavwCwNItOJUwDNfBkOhMIp.oMWilpQsvAaoaoaybALYDUFEqxYh P_2)
	{
		for (int i = 0; i < P_0; i++)
		{
			MsPnivhhvngiwjBoCnYOEiefUofk msPnivhhvngiwjBoCnYOEiefUofk = P_1[i];
			if (msPnivhhvngiwjBoCnYOEiefUofk == null || msPnivhhvngiwjBoCnYOEiefUofk.inputManagerId >= 0)
			{
				continue;
			}
			CeheUnavwCwNItOJUwDNfBkOhMIp.waawvpZfQqiFtXyHGlmczWJVIol waawvpZfQqiFtXyHGlmczWJVIol = null;
			foreach (CeheUnavwCwNItOJUwDNfBkOhMIp.waawvpZfQqiFtXyHGlmczWJVIol item in tWaggyJPBcRxwyAUFZkujNIcHgO.WfScZfFnYvGYNnfxpPOcIypkwcfV(msPnivhhvngiwjBoCnYOEiefUofk, P_2))
			{
				if (!BaEnDOhUnzNYdsILLLieXmcUjHl(P_1, item.gNijVFSxPIkIXVEBfXiCOWbvkEY) && item.uDYTVizJuwnXvzyofQhbtGjAJpaE >= 0)
				{
					waawvpZfQqiFtXyHGlmczWJVIol = item;
					break;
				}
			}
			if (waawvpZfQqiFtXyHGlmczWJVIol != null)
			{
				int num = waawvpZfQqiFtXyHGlmczWJVIol.uDYTVizJuwnXvzyofQhbtGjAJpaE;
				if (!NkfgIpcuIAsjZIJbIIBeJvbMbagI(P_1, num))
				{
					num = (waawvpZfQqiFtXyHGlmczWJVIol.uDYTVizJuwnXvzyofQhbtGjAJpaE = NyHyNinRgcrbSYtQTeIqkUCRiko(P_1));
				}
				msPnivhhvngiwjBoCnYOEiefUofk.inputManagerId = num;
				msPnivhhvngiwjBoCnYOEiefUofk.rewiredId = waawvpZfQqiFtXyHGlmczWJVIol.gNijVFSxPIkIXVEBfXiCOWbvkEY;
				tWaggyJPBcRxwyAUFZkujNIcHgO.ROWDMagIyIfgsVWhoSroKVHpUgvW(msPnivhhvngiwjBoCnYOEiefUofk);
			}
		}
	}

	private void wCDaVFQPEORUeWyoEnGRkTcDqlD()
	{
		string[] joystickNames = Input.GetJoystickNames();
		if (xITxQnsYIaSncEtDwaqnAbbkRai || RFvNRIRPwwcpvBALOSCUnYLABFH(joystickNames))
		{
			ensYNqjPxhKHeyOUbkLdLoRguEI(joystickNames);
		}
		dwsDsPDKgHTKQVAjREDWSXOsYkJ = false;
		if (xITxQnsYIaSncEtDwaqnAbbkRai)
		{
			xITxQnsYIaSncEtDwaqnAbbkRai = false;
		}
	}

	private bool RFvNRIRPwwcpvBALOSCUnYLABFH(string[] P_0)
	{
		if (P_0.Length != yKFVQHQqQQpJNlBLneGKZcjXkPQ.Length)
		{
			return true;
		}
		for (int i = 0; i < P_0.Length; i++)
		{
			if (!string.Equals(P_0[i], yKFVQHQqQQpJNlBLneGKZcjXkPQ[i], StringComparison.Ordinal))
			{
				return true;
			}
		}
		return false;
	}

	private void lKgzcfQSolDGPyoEdiWHqTPwByFB(List<MsPnivhhvngiwjBoCnYOEiefUofk> P_0, List<MsPnivhhvngiwjBoCnYOEiefUofk> P_1, bool P_2)
	{
		if (P_0 == null)
		{
			return;
		}
		int num = P_0?.Count ?? 0;
		int num2 = P_1?.Count ?? 0;
		for (int i = 0; i < num; i++)
		{
			MsPnivhhvngiwjBoCnYOEiefUofk msPnivhhvngiwjBoCnYOEiefUofk = P_0[i];
			if (msPnivhhvngiwjBoCnYOEiefUofk == null)
			{
				continue;
			}
			bool flag = false;
			if (P_1 != null)
			{
				for (int j = 0; j < num2; j++)
				{
					MsPnivhhvngiwjBoCnYOEiefUofk msPnivhhvngiwjBoCnYOEiefUofk2 = P_1[j];
					if (msPnivhhvngiwjBoCnYOEiefUofk2 != null && msPnivhhvngiwjBoCnYOEiefUofk.rewiredId == msPnivhhvngiwjBoCnYOEiefUofk2.rewiredId)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				RLICzZUPMdNWULVjCmtEQTTFtRN(P_0[i], P_2);
			}
		}
	}

	private void RLICzZUPMdNWULVjCmtEQTTFtRN(MsPnivhhvngiwjBoCnYOEiefUofk P_0, bool P_1)
	{
		if (P_1)
		{
			if (_DeviceConnectedEvent != null)
			{
				_DeviceConnectedEvent(P_0.ToBridgedController());
			}
		}
		else if (_DeviceDisconnectedEvent != null)
		{
			_DeviceDisconnectedEvent(P_0.ToControllerDisconnectedEventArgs());
		}
	}

	private void keuiQOsVWdsoFLzpXABzFTayFwN()
	{
		if (TnidRhAIPvMICseBcUJBQDrSFxL == pwCHlVAXqOkeMGtoncWzBSGmuxy && ZYwrSlpFpbBfKcWaftECaMBFDBB.Update())
		{
			dwsDsPDKgHTKQVAjREDWSXOsYkJ = true;
			ZYwrSlpFpbBfKcWaftECaMBFDBB.Start();
		}
	}
}
