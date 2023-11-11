using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Config;
using Rewired.Data.Mapping;
using Rewired.HID;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Classes.Utility;

internal class lRfdZjIakBhyrwaGkefekSyEiXO : PlatformInputManager, cAvjFIuogOpSRXxMsntCvEcAHqvj
{
	private class iHkeJQxMhCacNXSKKcHkJmGQjzU : IInputManagerJoystick, IInputManagerJoystickPublic
	{
		private int HDUfrfQaCtWbjEQjslQVHYtxamY;

		private int GMogOPiabkOgxkvSLwYiIgcbdeI;

		public Guid FbSmcmcVOWowuyUiagueSMvFgly;

		public string DcCSwoiCsPKVmzyhfFwghvYDsbp;

		public readonly apubADxSfJorcFkbCCCEczQVHYF qFTTgjZPRmbnvqCBGdmEDbfSPiSE;

		public tvkecSTWbFlWcBbAxxdWaePZtgu qdKoEcPCccDwQFCtcjxhBBoBvWrh;

		public oePPRnxqcVcTAqByosGoUzBKaEw qtuqOkhNAVUcfxFZgMaXjkkJIIlB;

		public string awueIOZppSsgBYIKhhnLggaAZAn;

		public string UjlLMcJBUCEjQCPTUCFwbFmHYQxE;

		public int nWFtSCRFEzwWJAlKCuDmeqSLzvS;

		public Guid kmlrVkJoHAiVknTEjxTfehHxMGP;

		public Guid enrHFMRQgCWUTcGBWcZaPNsNxwT;

		public Guid KBeSAIfQuakWhKYXrKovLYpHcGg;

		public int qNPHPpgvRQEdsxgBWqwsRIjHSq;

		public bool ZQJxEMiMjNdHQmVWxDtDCRrFHpRh;

		public string FfbgQkFEOHvMYGENpNQWUtsUWFC;

		public string ezJUJpdVGuAyiRzzDPTNaIehacH;

		public int qfxfzVJncFGzpqWHPKYOQjSrVSc;

		public int dueoAnsXDyCXiTcKgFRIJGbwAJdQ;

		public int rdAiJgjkWhiEydzQBaCRfzCVRNHM;

		public int sTzXfOyWCNXZCDYOkqgPDWeTHnP;

		public int HtrgaJBhAduArjOzMjluWSwCPBqi;

		public bool ElGbwvcoyOUnEXwgQgFRFCxZUkkb;

		private float[] JdVEWmnshzhQhfQpWKygbxeaWPsN;

		private bool[] zDdXRTONJmZUqqAiqtzcktIOAJw;

		private HardwareJoystickMap_InputManager FZCqfqZEBbHWoQxVVIkyNdAoiatI;

		private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> rpvCjQaePXpGswKHxhwfamxRDIu;

		private bool eiKbsRinsyNWKLFiiPPgjOvPBaj;

		private bool RtEBtfhoklZnMgNMZfcTKWlNBQe;

		private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

		[CustomObfuscation(rename = false)]
		public int rewiredId
		{
			get
			{
				return HDUfrfQaCtWbjEQjslQVHYtxamY;
			}
			set
			{
				HDUfrfQaCtWbjEQjslQVHYtxamY = value;
			}
		}

		[CustomObfuscation(rename = false)]
		public int inputManagerId
		{
			get
			{
				return GMogOPiabkOgxkvSLwYiIgcbdeI;
			}
			set
			{
				GMogOPiabkOgxkvSLwYiIgcbdeI = value;
			}
		}

		[CustomObfuscation(rename = false)]
		public string name
		{
			get
			{
				if (DcCSwoiCsPKVmzyhfFwghvYDsbp != "Unknown Controller")
				{
					return DcCSwoiCsPKVmzyhfFwghvYDsbp;
				}
				if (ZQJxEMiMjNdHQmVWxDtDCRrFHpRh && !string.IsNullOrEmpty(FfbgQkFEOHvMYGENpNQWUtsUWFC))
				{
					return FfbgQkFEOHvMYGENpNQWUtsUWFC;
				}
				return UjlLMcJBUCEjQCPTUCFwbFmHYQxE;
			}
		}

		[CustomObfuscation(rename = false)]
		public long? systemId
		{
			get
			{
				if (GMogOPiabkOgxkvSLwYiIgcbdeI < 0)
				{
					return null;
				}
				return GMogOPiabkOgxkvSLwYiIgcbdeI;
			}
		}

		[CustomObfuscation(rename = false)]
		public int unityId => 0;

		[CustomObfuscation(rename = false)]
		public Controller.Extension extension => null;

		[CustomObfuscation(rename = false)]
		public Guid instanceGuid => kmlrVkJoHAiVknTEjxTfehHxMGP;

		[CustomObfuscation(rename = false)]
		public Guid persistentGuid => instanceGuid;

		[CustomObfuscation(rename = false)]
		public void SetVibration(float amount, int motorIndex)
		{
		}

		[CustomObfuscation(rename = false)]
		public void StopVibration()
		{
		}

		public iHkeJQxMhCacNXSKKcHkJmGQjzU(apubADxSfJorcFkbCCCEczQVHYF sourceJoystick, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager)
		{
			qFTTgjZPRmbnvqCBGdmEDbfSPiSE = sourceJoystick;
			rpvCjQaePXpGswKHxhwfamxRDIu = getHardwareJoystickMap_InputManager;
			GMogOPiabkOgxkvSLwYiIgcbdeI = -1;
			HDUfrfQaCtWbjEQjslQVHYtxamY = -1;
		}

		public void iZnBUcZPCYZUOuauoTTqYipxzmI()
		{
			KBeSAIfQuakWhKYXrKovLYpHcGg = MiscTools.CreateGuidHashSHA1(UjlLMcJBUCEjQCPTUCFwbFmHYQxE + enrHFMRQgCWUTcGBWcZaPNsNxwT);
			qfxfzVJncFGzpqWHPKYOQjSrVSc = rdAiJgjkWhiEydzQBaCRfzCVRNHM;
			dueoAnsXDyCXiTcKgFRIJGbwAJdQ = sTzXfOyWCNXZCDYOkqgPDWeTHnP + HtrgaJBhAduArjOzMjluWSwCPBqi * 8;
			DkCucBGofWqRioHvuuaHxGeOUvg();
			FbSmcmcVOWowuyUiagueSMvFgly = FZCqfqZEBbHWoQxVVIkyNdAoiatI.hardwareMapIdentifier.guid;
			DcCSwoiCsPKVmzyhfFwghvYDsbp = FZCqfqZEBbHWoQxVVIkyNdAoiatI.controllerName;
			eiKbsRinsyNWKLFiiPPgjOvPBaj = ((FbSmcmcVOWowuyUiagueSMvFgly == Guid.Empty) ? true : false);
			JdVEWmnshzhQhfQpWKygbxeaWPsN = new float[qfxfzVJncFGzpqWHPKYOQjSrVSc];
			zDdXRTONJmZUqqAiqtzcktIOAJw = new bool[dueoAnsXDyCXiTcKgFRIJGbwAJdQ];
			qFTTgjZPRmbnvqCBGdmEDbfSPiSE.QTjmhwTeuRVhauTKAbvNjtNMtgF();
			Update();
		}

		public void mBTEWwhZTVXHADiOGGiZHrhHDFU(iHkeJQxMhCacNXSKKcHkJmGQjzU P_0)
		{
			if (P_0 != null)
			{
				GMogOPiabkOgxkvSLwYiIgcbdeI = P_0.GMogOPiabkOgxkvSLwYiIgcbdeI;
				HDUfrfQaCtWbjEQjslQVHYtxamY = P_0.HDUfrfQaCtWbjEQjslQVHYtxamY;
				for (int i = 0; i < MathTools.Min(zDdXRTONJmZUqqAiqtzcktIOAJw.Length, P_0.zDdXRTONJmZUqqAiqtzcktIOAJw.Length); i++)
				{
					zDdXRTONJmZUqqAiqtzcktIOAJw[i] = P_0.zDdXRTONJmZUqqAiqtzcktIOAJw[i];
				}
				for (int j = 0; j < MathTools.Min(JdVEWmnshzhQhfQpWKygbxeaWPsN.Length, P_0.JdVEWmnshzhQhfQpWKygbxeaWPsN.Length); j++)
				{
					JdVEWmnshzhQhfQpWKygbxeaWPsN[j] = P_0.JdVEWmnshzhQhfQpWKygbxeaWPsN[j];
				}
				RtEBtfhoklZnMgNMZfcTKWlNBQe = P_0.RtEBtfhoklZnMgNMZfcTKWlNBQe;
				qFTTgjZPRmbnvqCBGdmEDbfSPiSE.mBTEWwhZTVXHADiOGGiZHrhHDFU(P_0.qFTTgjZPRmbnvqCBGdmEDbfSPiSE);
			}
		}

		[CustomObfuscation(rename = false)]
		public void Update()
		{
			qFTTgjZPRmbnvqCBGdmEDbfSPiSE.YYZBcNHuDDPbbahkHHyTHvUNFGE();
			bool[] currentButtonValues = qFTTgjZPRmbnvqCBGdmEDbfSPiSE.LwmOfqNgIYjfTKnDoIWjaIBKeCxD;
			int[] mSeXMQpIolvHxXuiVLsSKBhIhGfH = qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.mSeXMQpIolvHxXuiVLsSKBhIhGfH;
			QAJCSlFtoGBRITqPqBBrQqVEeBT(currentButtonValues, mSeXMQpIolvHxXuiVLsSKBhIhGfH);
			ldPMgFaEItHhAAPdUPIqVhZTNOL(currentButtonValues, mSeXMQpIolvHxXuiVLsSKBhIhGfH);
			qFTTgjZPRmbnvqCBGdmEDbfSPiSE.aWoeUUEECkNImBpxjMjDHgymWpn();
		}

		[CustomObfuscation(rename = false)]
		public void FillData(ControllerDataUpdater dataUpdater)
		{
			if (qfxfzVJncFGzpqWHPKYOQjSrVSc != dataUpdater.axisCount || dueoAnsXDyCXiTcKgFRIJGbwAJdQ != dataUpdater.buttonCount)
			{
				throw new Exception("This controller signature does not match the data object!");
			}
			for (int i = 0; i < qfxfzVJncFGzpqWHPKYOQjSrVSc; i++)
			{
				dataUpdater.axisValues[i] = JdVEWmnshzhQhfQpWKygbxeaWPsN[i];
			}
			for (int j = 0; j < dueoAnsXDyCXiTcKgFRIJGbwAJdQ; j++)
			{
				dataUpdater.buttonValues[j] = zDdXRTONJmZUqqAiqtzcktIOAJw[j];
			}
			if (RtEBtfhoklZnMgNMZfcTKWlNBQe && !dataUpdater.hasReceivedInput)
			{
				dataUpdater.hasReceivedInput = true;
			}
		}

		public int QdqhDkpVZKgyndwhadmFgJdPnvx(iHkeJQxMhCacNXSKKcHkJmGQjzU P_0)
		{
			if (P_0.HDUfrfQaCtWbjEQjslQVHYtxamY == HDUfrfQaCtWbjEQjslQVHYtxamY)
			{
				return 2;
			}
			if (rdAiJgjkWhiEydzQBaCRfzCVRNHM != P_0.rdAiJgjkWhiEydzQBaCRfzCVRNHM)
			{
				return 0;
			}
			if (sTzXfOyWCNXZCDYOkqgPDWeTHnP != P_0.sTzXfOyWCNXZCDYOkqgPDWeTHnP)
			{
				return 0;
			}
			if (HtrgaJBhAduArjOzMjluWSwCPBqi != P_0.HtrgaJBhAduArjOzMjluWSwCPBqi)
			{
				return 0;
			}
			if (P_0.instanceGuid == instanceGuid)
			{
				return 2;
			}
			if (P_0.KBeSAIfQuakWhKYXrKovLYpHcGg == KBeSAIfQuakWhKYXrKovLYpHcGg)
			{
				return 1;
			}
			return 0;
		}

		private BridgedControllerHWInfo TdHuOOvtOeVJJeyOCtfLWYvpTOH()
		{
			BridgedControllerHWInfo bridgedControllerHWInfo = new BridgedControllerHWInfo();
			mcfuFPdUGFrLUTlWgAfDNLiDDwZ(bridgedControllerHWInfo);
			return bridgedControllerHWInfo;
		}

		[CustomObfuscation(rename = false)]
		public BridgedController ToBridgedController()
		{
			BridgedController bridgedController = new BridgedController();
			mcfuFPdUGFrLUTlWgAfDNLiDDwZ(bridgedController);
			return bridgedController;
		}

		[CustomObfuscation(rename = false)]
		public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs()
		{
			return new ControllerDisconnectedEventArgs(HDUfrfQaCtWbjEQjslQVHYtxamY);
		}

		public bool OSjZQlsjtWjjULblHOgvsjwZwLn()
		{
			try
			{
				qFTTgjZPRmbnvqCBGdmEDbfSPiSE.MunZepaFKdYsUldLUBVBfpSOkuHK.tAkSZCNyfuGJQqiDRcFnHnmuqtkC();
				return true;
			}
			catch
			{
				return false;
			}
		}

		public void OqhfOnkBvpKzLuKYYPKRUvpiUrOF()
		{
			try
			{
				if (qFTTgjZPRmbnvqCBGdmEDbfSPiSE.MunZepaFKdYsUldLUBVBfpSOkuHK != null)
				{
					qFTTgjZPRmbnvqCBGdmEDbfSPiSE.MunZepaFKdYsUldLUBVBfpSOkuHK.OqhfOnkBvpKzLuKYYPKRUvpiUrOF();
				}
			}
			catch
			{
			}
		}

		public void PiVpHzafoUMfSDFNLmfkEJnjpdO()
		{
			try
			{
				if (qFTTgjZPRmbnvqCBGdmEDbfSPiSE.MunZepaFKdYsUldLUBVBfpSOkuHK != null)
				{
					qFTTgjZPRmbnvqCBGdmEDbfSPiSE.MunZepaFKdYsUldLUBVBfpSOkuHK.PiVpHzafoUMfSDFNLmfkEJnjpdO();
				}
			}
			catch
			{
			}
		}

		private void QAJCSlFtoGBRITqPqBBrQqVEeBT(bool[] P_0, int[] P_1)
		{
			if (qfxfzVJncFGzpqWHPKYOQjSrVSc <= 0)
			{
				return;
			}
			switch (FZCqfqZEBbHWoQxVVIkyNdAoiatI.map.platform)
			{
			case InputPlatform.noJaFmPBaDlcmJbgEsFAjhnvyrY:
			{
				HardwareJoystickMap.Platform_RawInput_Base platform_RawInput_Base = (HardwareJoystickMap.Platform_RawInput_Base)FZCqfqZEBbHWoQxVVIkyNdAoiatI.map;
				HardwareJoystickMap.Platform_RawInput_Base.Axis[] axes_orig2 = platform_RawInput_Base.Axes_orig;
				if (axes_orig2 != null)
				{
					for (int j = 0; j < axes_orig2.Length; j++)
					{
						PgBiTZcLgnGgQgBxgVfbEdeObiMW(axes_orig2[j], j, P_0, P_1);
					}
				}
				break;
			}
			case InputPlatform.VJDsrfiTpGRdzQKJnkPsFSIDvJQ:
			{
				HardwareJoystickMap.Platform_DirectInput_Base platform_DirectInput_Base = (HardwareJoystickMap.Platform_DirectInput_Base)FZCqfqZEBbHWoQxVVIkyNdAoiatI.map;
				HardwareJoystickMap.Platform_DirectInput_Base.Axis[] axes_orig = platform_DirectInput_Base.Axes_orig;
				if (axes_orig != null)
				{
					for (int i = 0; i < axes_orig.Length; i++)
					{
						PgBiTZcLgnGgQgBxgVfbEdeObiMW(axes_orig[i], i, P_0, P_1);
					}
				}
				break;
			}
			}
		}

		private void ldPMgFaEItHhAAPdUPIqVhZTNOL(bool[] P_0, int[] P_1)
		{
			if (dueoAnsXDyCXiTcKgFRIJGbwAJdQ <= 0)
			{
				return;
			}
			switch (FZCqfqZEBbHWoQxVVIkyNdAoiatI.map.platform)
			{
			case InputPlatform.noJaFmPBaDlcmJbgEsFAjhnvyrY:
			{
				HardwareJoystickMap.Platform_RawInput_Base platform_RawInput_Base = (HardwareJoystickMap.Platform_RawInput_Base)FZCqfqZEBbHWoQxVVIkyNdAoiatI.map;
				HardwareJoystickMap.Platform_RawInput_Base.Button[] buttons_orig2 = platform_RawInput_Base.Buttons_orig;
				if (buttons_orig2 != null)
				{
					for (int j = 0; j < buttons_orig2.Length; j++)
					{
						LXUbHihsbIHDfayNTWVNKvbxsOEf(buttons_orig2[j], j, P_0, P_1);
					}
				}
				break;
			}
			case InputPlatform.VJDsrfiTpGRdzQKJnkPsFSIDvJQ:
			{
				HardwareJoystickMap.Platform_DirectInput_Base platform_DirectInput_Base = (HardwareJoystickMap.Platform_DirectInput_Base)FZCqfqZEBbHWoQxVVIkyNdAoiatI.map;
				HardwareJoystickMap.Platform_DirectInput_Base.Button[] buttons_orig = platform_DirectInput_Base.Buttons_orig;
				if (buttons_orig != null)
				{
					for (int i = 0; i < buttons_orig.Length; i++)
					{
						LXUbHihsbIHDfayNTWVNKvbxsOEf(buttons_orig[i], i, P_0, P_1);
					}
				}
				break;
			}
			}
		}

		private void PgBiTZcLgnGgQgBxgVfbEdeObiMW(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base P_0, int P_1, bool[] P_2, int[] P_3)
		{
			if (P_1 >= qfxfzVJncFGzpqWHPKYOQjSrVSc)
			{
				throw new Exception("Number of axes in hardware map does not match number of axes found in controller!");
			}
			JdVEWmnshzhQhfQpWKygbxeaWPsN[P_1] = WbUNdjrqDniDXYdirtEbXVOOxfO(P_0, P_2, P_3);
			if (!RtEBtfhoklZnMgNMZfcTKWlNBQe && JdVEWmnshzhQhfQpWKygbxeaWPsN[P_1] != 0f)
			{
				RtEBtfhoklZnMgNMZfcTKWlNBQe = true;
			}
		}

		private void LXUbHihsbIHDfayNTWVNKvbxsOEf(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base P_0, int P_1, bool[] P_2, int[] P_3)
		{
			if (P_1 >= dueoAnsXDyCXiTcKgFRIJGbwAJdQ)
			{
				throw new Exception("Number of buttons in hardware map does not match number of buttons found in controller!");
			}
			zDdXRTONJmZUqqAiqtzcktIOAJw[P_1] = kXRepGCTsYPuBnCuTSPcGaXqgpDv(P_0, P_2, P_3);
			if (!RtEBtfhoklZnMgNMZfcTKWlNBQe && zDdXRTONJmZUqqAiqtzcktIOAJw[P_1])
			{
				RtEBtfhoklZnMgNMZfcTKWlNBQe = true;
			}
		}

		private float WbUNdjrqDniDXYdirtEbXVOOxfO(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base P_0, bool[] P_1, int[] P_2)
		{
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Axis)
			{
				if (P_0.sourceAxis <= 0 || P_0.sourceAxis >= 32)
				{
					return 0f;
				}
				return WbUNdjrqDniDXYdirtEbXVOOxfO((DirectInputAxis)P_0.sourceAxis);
			}
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Button)
			{
				int sourceButton = P_0.sourceButton;
				if (sourceButton < 0 || sourceButton >= sTzXfOyWCNXZCDYOkqgPDWeTHnP || sourceButton >= 128)
				{
					return 0f;
				}
				if (!P_1[sourceButton])
				{
					return 0f;
				}
				if (P_0.buttonAxisContribution == Pole.Positive)
				{
					return 1f;
				}
				return -1f;
			}
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Hat)
			{
				int sourceHat = P_0.sourceHat;
				if (sourceHat < 0 || sourceHat >= HtrgaJBhAduArjOzMjluWSwCPBqi || sourceHat >= 4)
				{
					return 0f;
				}
				int num = P_2[sourceHat];
				if (num < 0)
				{
					return 0f;
				}
				float num2;
				if (P_0.sourceHatDirection == AxisDirection.Horizontal)
				{
					num2 = bmQYKGgKrUqNjnarxlXMrBxKClu(num, AxisDirection.Horizontal);
					if (P_0.sourceHatRange != 0)
					{
						if (P_0.sourceHatRange == AxisRange.Positive)
						{
							if (num2 < 0f)
							{
								return 0f;
							}
						}
						else if (num2 > 0f)
						{
							return 0f;
						}
					}
				}
				else
				{
					num2 = bmQYKGgKrUqNjnarxlXMrBxKClu(num, AxisDirection.Vertical);
					if (P_0.sourceHatRange != 0)
					{
						if (P_0.sourceHatRange == AxisRange.Positive)
						{
							if (num2 < 0f)
							{
								return 0f;
							}
						}
						else if (num2 > 0f)
						{
							return 0f;
						}
					}
				}
				if (P_0.invert)
				{
					num2 *= -1f;
				}
				return num2;
			}
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Custom)
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
				HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData[] customCalculationSourceData = P_0.customCalculationSourceData;
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
						if (hardwareElementSourceTypeWithHat == HardwareElementSourceTypeWithHat.Axis && GLJZCYcwPrWuHTmRalESCGkLPcD(customCalculationSourceData[i], out var item))
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
			return 0f;
		}

		private float WbUNdjrqDniDXYdirtEbXVOOxfO(DirectInputAxis P_0)
		{
			return P_0 switch
			{
				DirectInputAxis.X => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.xpumVntKTYPdUAcEeqwWhsPgirN, 
				DirectInputAxis.Y => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.RTwQzyWgdmiDfVtyeEaNgdMceZg, 
				DirectInputAxis.Z => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.TCogMmKASgopRYQJTNMtdAvdwtIe, 
				DirectInputAxis.RotationX => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.EdlzUaIOdCOXEXPAWyQWBASofyY, 
				DirectInputAxis.RotationY => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.DQysbbdoHDPlpAeeBSiYmmjBYbz, 
				DirectInputAxis.RotationZ => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.GLbyWguVoSuyBGnJfbXziXCsHPO, 
				DirectInputAxis.Slider0 => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.gljkmoyOBJrGQUmNqDaQBfHacODV[0], 
				DirectInputAxis.Slider1 => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.gljkmoyOBJrGQUmNqDaQBfHacODV[1], 
				DirectInputAxis.VelocityX => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.yqcjjMQvejIokWKMBapsKKiozwT, 
				DirectInputAxis.VelocityY => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.djKPQOAWngqnVpncpdtoeNFWLdhr, 
				DirectInputAxis.VelocityZ => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.SiTAMlPnuqbVwhxyevgmJzerzzWq, 
				DirectInputAxis.AngularVelocityX => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.oEHOYUnthFiMDrqwXfCuEDgFALxX, 
				DirectInputAxis.AngularVelocityY => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.ACneJuXoJhfqxfOCtjZajhvCKdIg, 
				DirectInputAxis.AngularVelocityZ => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.rwZlWhqrMonenQBoRuRggMEBTaR, 
				DirectInputAxis.VelocitySlider0 => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.FOhAAOAzmohUPgzASmfrbUHqKSxw[0], 
				DirectInputAxis.VelocitySlider1 => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.FOhAAOAzmohUPgzASmfrbUHqKSxw[1], 
				DirectInputAxis.AccelerationX => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.QtGVhGCdczHTabxrZzdRPrCmcFIk, 
				DirectInputAxis.AccelerationY => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.maBbJvUkRsqitIlgaKjqrgDXgJh, 
				DirectInputAxis.AccelerationZ => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.HAPIvWFpMbTqoVxbfdBKGmEKjwMD, 
				DirectInputAxis.AngularAccelerationX => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.KnZRfKkpbOxfzlgtcOSnwIcFvoU, 
				DirectInputAxis.AngularAccelerationY => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.sgsDqvJTsHfsvOJsZeZXGduxWTE, 
				DirectInputAxis.AngularAccelerationZ => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.BvlyDJjQGZkZVIWkSmDNcVOyJUe, 
				DirectInputAxis.AccelerationSlider0 => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.ZpABAkfHwHQDSOGXlKXhcmEydNqq[0], 
				DirectInputAxis.AccelerationSlider1 => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.ZpABAkfHwHQDSOGXlKXhcmEydNqq[1], 
				DirectInputAxis.ForceX => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.PMYsmgFkMdlUJldlnEfzdjaaJf, 
				DirectInputAxis.ForceY => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.XFtrQkrNkPBxJEKYzmoSMULzujeL, 
				DirectInputAxis.ForceZ => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.OtUGEwCUrYfgLqGOZPAfTOWdcAl, 
				DirectInputAxis.TorqueX => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.ZmviqYAaSckrJAJfoMAKzAMBigO, 
				DirectInputAxis.TorqueY => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.TNSVOyeEanHBtTbVhWsGwnpMCRE, 
				DirectInputAxis.TorqueZ => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.enAbylCthhDBABwXbZWLOsvRNbHd, 
				DirectInputAxis.ForceSlider0 => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.JUFhaMDmUXULJISwjxqzazZysjK[0], 
				DirectInputAxis.ForceSlider1 => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.uavJrsMjpaFotDyYjmdcDZVBwFWG.JUFhaMDmUXULJISwjxqzazZysjK[1], 
				_ => 0f, 
			};
		}

		private bool kXRepGCTsYPuBnCuTSPcGaXqgpDv(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base P_0, bool[] P_1, int[] P_2)
		{
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Button)
			{
				if (P_0.ignoreIfButtonsActive)
				{
					for (int i = 0; i < P_0.ignoreIfButtonsActiveButtons.Length; i++)
					{
						if (P_1[P_0.ignoreIfButtonsActiveButtons[i]])
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
						if (!P_1[P_0.requiredButtons[j]])
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
				int sourceButton = P_0.sourceButton;
				if (sourceButton < 0 || sourceButton >= sTzXfOyWCNXZCDYOkqgPDWeTHnP || sourceButton >= 128)
				{
					return false;
				}
				return P_1[sourceButton];
			}
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Axis)
			{
				if (P_0.sourceAxis <= 0 || P_0.sourceAxis > 32)
				{
					return false;
				}
				float num = WbUNdjrqDniDXYdirtEbXVOOxfO((DirectInputAxis)P_0.sourceAxis);
				if (MathTools.Abs(num) <= P_0.axisDeadZone)
				{
					return false;
				}
				if (P_0.sourceAxisPole == Pole.Positive)
				{
					if (num < 0f)
					{
						return false;
					}
				}
				else if (num > 0f)
				{
					return false;
				}
				return true;
			}
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Hat)
			{
				int sourceHat = P_0.sourceHat;
				if (sourceHat < 0 || sourceHat >= HtrgaJBhAduArjOzMjluWSwCPBqi || sourceHat >= 4)
				{
					return false;
				}
				switch (P_0.sourceHatDirection)
				{
				case HatDirection.Up:
					return arYETMBOlYsDyioxqUOrsTqFbdC(P_2[sourceHat], 0, P_0.sourceHatType);
				case HatDirection.UpRight:
					return arYETMBOlYsDyioxqUOrsTqFbdC(P_2[sourceHat], 1, P_0.sourceHatType);
				case HatDirection.Right:
					return arYETMBOlYsDyioxqUOrsTqFbdC(P_2[sourceHat], 2, P_0.sourceHatType);
				case HatDirection.DownRight:
					return arYETMBOlYsDyioxqUOrsTqFbdC(P_2[sourceHat], 3, P_0.sourceHatType);
				case HatDirection.Down:
					return arYETMBOlYsDyioxqUOrsTqFbdC(P_2[sourceHat], 4, P_0.sourceHatType);
				case HatDirection.DownLeft:
					return arYETMBOlYsDyioxqUOrsTqFbdC(P_2[sourceHat], 5, P_0.sourceHatType);
				case HatDirection.Left:
					return arYETMBOlYsDyioxqUOrsTqFbdC(P_2[sourceHat], 6, P_0.sourceHatType);
				case HatDirection.UpLeft:
					return arYETMBOlYsDyioxqUOrsTqFbdC(P_2[sourceHat], 7, P_0.sourceHatType);
				}
			}
			else if (P_0.sourceType == HardwareElementSourceTypeWithHat.Custom)
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
				HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData[] customCalculationSourceData = P_0.customCalculationSourceData;
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
						if (tpIQPPXUwJqQJhezBEmBaMUBjqk(customCalculationSourceData[k], P_1, out var flag2))
						{
							customCalculation.AddData(flag2 ? 1f : 0f);
						}
						break;
					}
					case HardwareElementSourceTypeWithHat.Axis:
					{
						if (GLJZCYcwPrWuHTmRalESCGkLPcD(customCalculationSourceData[k], out var num2))
						{
							customCalculation.AddData((num2 != 0f) ? 1f : 0f);
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
			return false;
		}

		private bool arYETMBOlYsDyioxqUOrsTqFbdC(int P_0, int P_1, HatType P_2)
		{
			if (P_0 < 0)
			{
				return false;
			}
			if (FZCqfqZEBbHWoQxVVIkyNdAoiatI.isUnknownController && !InputTools.HandleForced4WayHatsOnUnknownControllers(P_1, ref P_2))
			{
				return false;
			}
			int num = 4500;
			int num2 = num * P_1;
			if (P_2 == HatType.EightWay && P_0 != num2)
			{
				return false;
			}
			int num3;
			int num4;
			if (P_2 == HatType.EightWay)
			{
				num3 = 31500;
				num4 = 4500;
			}
			else
			{
				num3 = 27000;
				num4 = 9000;
			}
			if (P_1 == 0 && P_0 > num3)
			{
				P_0 -= 36000;
			}
			if (P_0 < num2 + num4 && P_0 > num2 - num4)
			{
				return true;
			}
			return false;
		}

		private float bmQYKGgKrUqNjnarxlXMrBxKClu(int P_0, AxisDirection P_1)
		{
			if (P_0 < 0)
			{
				return 0f;
			}
			if (P_1 == AxisDirection.Vertical)
			{
				if (P_0 > 27000 || P_0 < 9000)
				{
					return 1f;
				}
				if (P_0 < 27000 && P_0 > 9000)
				{
					return -1f;
				}
				return 0f;
			}
			if (P_0 > 0 && P_0 < 18000)
			{
				return 1f;
			}
			if (P_0 > 18000)
			{
				return -1f;
			}
			return 0f;
		}

		private bool tpIQPPXUwJqQJhezBEmBaMUBjqk(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData P_0, bool[] P_1, out bool P_2)
		{
			P_2 = false;
			if (P_0.sourceType != 0)
			{
				return false;
			}
			int sourceButton = P_0.sourceButton;
			if (sourceButton < 0 || sourceButton >= sTzXfOyWCNXZCDYOkqgPDWeTHnP || sourceButton >= 128)
			{
				return false;
			}
			P_2 = P_1[sourceButton];
			return true;
		}

		private bool GLJZCYcwPrWuHTmRalESCGkLPcD(HardwareJoystickMap.Platform_RawOrDirectInput.CustomCalculationSourceData P_0, out float P_1)
		{
			P_1 = 0f;
			if (P_0.sourceType != 1)
			{
				return false;
			}
			if (P_0.sourceAxis <= 0 || P_0.sourceAxis >= 32)
			{
				return false;
			}
			P_1 = WbUNdjrqDniDXYdirtEbXVOOxfO((DirectInputAxis)P_0.sourceAxis);
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
			if (P_0.axisCalibrationType == AxisCalibrationType.Default)
			{
				P_1 = InputTools.GetCalibratedAxisValueClamped(P_1, P_0.axisZero, -1f, 1f, P_0.axisDeadZone, P_0.invert, applySensitivity: false, AxisSensitivityType.Multiplier, 1f, null);
			}
			else if (P_0.axisCalibrationType == AxisCalibrationType.Custom)
			{
				P_1 = InputTools.GetCalibratedAxisValueClamped(P_1, P_0.axisZero, P_0.axisMin, P_0.axisMax, P_0.axisDeadZone, P_0.invert, applySensitivity: false, AxisSensitivityType.Multiplier, 1f, null);
			}
			else if (P_0.axisCalibrationType == AxisCalibrationType.Uncalibrated && P_0.axisDeadZone > 0f && MathTools.Abs(P_1) <= P_0.axisDeadZone)
			{
				P_1 = 0f;
			}
			return true;
		}

		private ControlDeviceType xDtArciGdOzXOFkfrhkYdAjcchBt(oePPRnxqcVcTAqByosGoUzBKaEw P_0)
		{
			return P_0 switch
			{
				oePPRnxqcVcTAqByosGoUzBKaEw.hOKSQsVFahbyPnFtHtuTEPcoMO => ControlDeviceType.VptHLZXdJfMsrxxJFwCBsNGGFnMF, 
				oePPRnxqcVcTAqByosGoUzBKaEw.etZBciYCDzeATdbPMkiCAYwMQZPf => ControlDeviceType.QIiFjjgvNmDRWWXPiwXfgdhsPuPT, 
				oePPRnxqcVcTAqByosGoUzBKaEw.pXUvLMZdfUPPpSKQFIjTzaejHeu => ControlDeviceType.HozKeFupbFMAkawChHxgYAvTwqs, 
				oePPRnxqcVcTAqByosGoUzBKaEw.QxDaIeQFcOJvuQfaIwlsuKcvYjM => ControlDeviceType.iBsunrzpmNRGjincwoFXBCjHvrY, 
				oePPRnxqcVcTAqByosGoUzBKaEw.JwAGBjbYdnvwcIoDlmUzAzcFAfv => ControlDeviceType.jYzSynCvforjneRqTbUUrrjfCkb, 
				oePPRnxqcVcTAqByosGoUzBKaEw.rqXrqgDfQPNUBjLmvaIgkGoQqjD => ControlDeviceType.lqgakDHZBSJngBTmBAAztgaHrLNO, 
				_ => ControlDeviceType.CCZTuwVJranWzEkxzHtKCBLLDDz, 
			};
		}

		private void DkCucBGofWqRioHvuuaHxGeOUvg()
		{
			FZCqfqZEBbHWoQxVVIkyNdAoiatI = rpvCjQaePXpGswKHxhwfamxRDIu(TdHuOOvtOeVJJeyOCtfLWYvpTOH());
			if (FZCqfqZEBbHWoQxVVIkyNdAoiatI == null)
			{
				Logger.LogError("Default hardware map not found!");
				return;
			}
			qfxfzVJncFGzpqWHPKYOQjSrVSc = FZCqfqZEBbHWoQxVVIkyNdAoiatI.axisCount;
			dueoAnsXDyCXiTcKgFRIJGbwAJdQ = FZCqfqZEBbHWoQxVVIkyNdAoiatI.buttonCount;
		}

		private void sZXebtvJlpbTBztXnlwrBTloEzi()
		{
		}

		private string VCBjwgWaCYIHvUQlThczfODazOUH()
		{
			return InputTools.FormatHardwareIdentifierString($"{ReInput.currentPlatform.ToString()}{InputSource.DirectInput}{((ZQJxEMiMjNdHQmVWxDtDCRrFHpRh && !string.IsNullOrEmpty(FfbgQkFEOHvMYGENpNQWUtsUWFC)) ? FfbgQkFEOHvMYGENpNQWUtsUWFC : UjlLMcJBUCEjQCPTUCFwbFmHYQxE)}{nWFtSCRFEzwWJAlKCuDmeqSLzvS}{enrHFMRQgCWUTcGBWcZaPNsNxwT}");
		}

		private void mcfuFPdUGFrLUTlWgAfDNLiDDwZ(BridgedControllerHWInfo P_0)
		{
			P_0.inputManagerSource = InputSource.DirectInput;
			P_0.inputSource = P_0.inputManagerSource;
			P_0.deviceType = xDtArciGdOzXOFkfrhkYdAjcchBt(qtuqOkhNAVUcfxFZgMaXjkkJIIlB);
			P_0.hardwareIdentifier = VCBjwgWaCYIHvUQlThczfODazOUH();
			P_0.hardwareAxisCount = rdAiJgjkWhiEydzQBaCRfzCVRNHM;
			P_0.hardwareButtonCount = sTzXfOyWCNXZCDYOkqgPDWeTHnP;
			P_0.hardwareHatCount = HtrgaJBhAduArjOzMjluWSwCPBqi;
			P_0.hw_productName = UjlLMcJBUCEjQCPTUCFwbFmHYQxE;
			P_0.hw_deviceGuid = instanceGuid;
			P_0.hw_productId = nWFtSCRFEzwWJAlKCuDmeqSLzvS;
			P_0.hw_pidVid = new PidVid(enrHFMRQgCWUTcGBWcZaPNsNxwT);
			P_0.hw_isBluetoothDevice = ZQJxEMiMjNdHQmVWxDtDCRrFHpRh;
			P_0.hw_bluetoothDeviceName = ((!string.IsNullOrEmpty(FfbgQkFEOHvMYGENpNQWUtsUWFC)) ? FfbgQkFEOHvMYGENpNQWUtsUWFC : string.Empty);
			P_0.definitionMatchTag = ezJUJpdVGuAyiRzzDPTNaIehacH;
		}

		private void mcfuFPdUGFrLUTlWgAfDNLiDDwZ(BridgedController P_0)
		{
			mcfuFPdUGFrLUTlWgAfDNLiDDwZ((BridgedControllerHWInfo)P_0);
			P_0.sourceJoystick = this;
			P_0.gameHardwareMap = FZCqfqZEBbHWoQxVVIkyNdAoiatI.ToGameHardwareControllerMap();
			P_0.instanceName = awueIOZppSsgBYIKhhnLggaAZAn;
			P_0.productName = UjlLMcJBUCEjQCPTUCFwbFmHYQxE;
			P_0.isXInputDevice = ElGbwvcoyOUnEXwgQgFRFCxZUkkb;
			P_0.axisCount = qfxfzVJncFGzpqWHPKYOQjSrVSc;
			P_0.buttonCount = dueoAnsXDyCXiTcKgFRIJGbwAJdQ;
			P_0.unknownControllerHats = NANSawXfTNGiVeqyfiYgTwMPhSb();
			P_0.controllerTypeGuid = FbSmcmcVOWowuyUiagueSMvFgly;
			P_0.controllerExtension = extension;
		}

		private void IStZgcKMzYGJKScWINoCKzxpnPK()
		{
			for (int i = 0; i < dueoAnsXDyCXiTcKgFRIJGbwAJdQ; i++)
			{
				zDdXRTONJmZUqqAiqtzcktIOAJw[i] = false;
			}
			for (int j = 0; j < qfxfzVJncFGzpqWHPKYOQjSrVSc; j++)
			{
				JdVEWmnshzhQhfQpWKygbxeaWPsN[j] = 0f;
			}
		}

		private UnknownControllerHat[] NANSawXfTNGiVeqyfiYgTwMPhSb()
		{
			if (!eiKbsRinsyNWKLFiiPPgjOvPBaj)
			{
				return null;
			}
			UnknownControllerHat[] array = new UnknownControllerHat[2];
			for (int i = 0; i < 2; i++)
			{
				int num = 128 + i * 8;
				UnknownControllerHat.HatButtons buttons = new UnknownControllerHat.HatButtons(new int[8]
				{
					num,
					num + 1,
					num + 2,
					num + 3,
					num + 4,
					num + 5,
					num + 6,
					num + 7
				});
				array[i] = new UnknownControllerHat(buttons);
			}
			return array;
		}

		public void PMzamCeIIFqnzgwGlxEbIeTHBFUL()
		{
			PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
			GC.SuppressFinalize(this);
		}

		~iHkeJQxMhCacNXSKKcHkJmGQjzU()
		{
			PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
		}

		protected virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
		{
			if (!jpnIPbpqmlecdiNqaFAxiNCsiMxs)
			{
				if (P_0 && qFTTgjZPRmbnvqCBGdmEDbfSPiSE != null)
				{
					qFTTgjZPRmbnvqCBGdmEDbfSPiSE.Dispose();
				}
				jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
			}
		}

		public static int sBorulmFfIIacZAhohMFFNzabbGA(iHkeJQxMhCacNXSKKcHkJmGQjzU P_0, iHkeJQxMhCacNXSKKcHkJmGQjzU P_1)
		{
			if (P_0.GMogOPiabkOgxkvSLwYiIgcbdeI < P_1.GMogOPiabkOgxkvSLwYiIgcbdeI)
			{
				return -1;
			}
			if (P_0.GMogOPiabkOgxkvSLwYiIgcbdeI > P_1.GMogOPiabkOgxkvSLwYiIgcbdeI)
			{
				return 1;
			}
			return 0;
		}

		public static int VIwhAhMGYzgeSCmSvoVckQcSdbGf(iHkeJQxMhCacNXSKKcHkJmGQjzU P_0, iHkeJQxMhCacNXSKKcHkJmGQjzU P_1)
		{
			if (P_0.qNPHPpgvRQEdsxgBWqwsRIjHSq < P_1.qNPHPpgvRQEdsxgBWqwsRIjHSq)
			{
				return -1;
			}
			if (P_0.qNPHPpgvRQEdsxgBWqwsRIjHSq > P_1.qNPHPpgvRQEdsxgBWqwsRIjHSq)
			{
				return 1;
			}
			return 0;
		}
	}

	private class apubADxSfJorcFkbCCCEczQVHYF : IDisposable
	{
		public class GIXNqmzZjgjyqWwoyPfRFlltdEF
		{
			public float xpumVntKTYPdUAcEeqwWhsPgirN;

			public float RTwQzyWgdmiDfVtyeEaNgdMceZg;

			public float TCogMmKASgopRYQJTNMtdAvdwtIe;

			public float EdlzUaIOdCOXEXPAWyQWBASofyY;

			public float DQysbbdoHDPlpAeeBSiYmmjBYbz;

			public float GLbyWguVoSuyBGnJfbXziXCsHPO;

			public float[] gljkmoyOBJrGQUmNqDaQBfHacODV;

			public readonly int[] mSeXMQpIolvHxXuiVLsSKBhIhGfH;

			public readonly bool[] OZXCbzyfeJVptcfXueOFPpFxErd;

			public float yqcjjMQvejIokWKMBapsKKiozwT;

			public float djKPQOAWngqnVpncpdtoeNFWLdhr;

			public float SiTAMlPnuqbVwhxyevgmJzerzzWq;

			public float oEHOYUnthFiMDrqwXfCuEDgFALxX;

			public float ACneJuXoJhfqxfOCtjZajhvCKdIg;

			public float rwZlWhqrMonenQBoRuRggMEBTaR;

			public readonly float[] FOhAAOAzmohUPgzASmfrbUHqKSxw;

			public float QtGVhGCdczHTabxrZzdRPrCmcFIk;

			public float maBbJvUkRsqitIlgaKjqrgDXgJh;

			public float HAPIvWFpMbTqoVxbfdBKGmEKjwMD;

			public float KnZRfKkpbOxfzlgtcOSnwIcFvoU;

			public float sgsDqvJTsHfsvOJsZeZXGduxWTE;

			public float BvlyDJjQGZkZVIWkSmDNcVOyJUe;

			public readonly float[] ZpABAkfHwHQDSOGXlKXhcmEydNqq;

			public float PMYsmgFkMdlUJldlnEfzdjaaJf;

			public float XFtrQkrNkPBxJEKYzmoSMULzujeL;

			public float OtUGEwCUrYfgLqGOZPAfTOWdcAl;

			public float ZmviqYAaSckrJAJfoMAKzAMBigO;

			public float TNSVOyeEanHBtTbVhWsGwnpMCRE;

			public float enAbylCthhDBABwXbZWLOsvRNbHd;

			public readonly float[] JUFhaMDmUXULJISwjxqzazZysjK;

			public GIXNqmzZjgjyqWwoyPfRFlltdEF()
			{
				gljkmoyOBJrGQUmNqDaQBfHacODV = new float[2];
				mSeXMQpIolvHxXuiVLsSKBhIhGfH = new int[4];
				OZXCbzyfeJVptcfXueOFPpFxErd = new bool[128];
				FOhAAOAzmohUPgzASmfrbUHqKSxw = new float[2];
				ZpABAkfHwHQDSOGXlKXhcmEydNqq = new float[2];
				JUFhaMDmUXULJISwjxqzazZysjK = new float[2];
			}

			public void xZveeqhZWQBoifJNrEKvhlbeSAk()
			{
				xpumVntKTYPdUAcEeqwWhsPgirN = 0f;
				RTwQzyWgdmiDfVtyeEaNgdMceZg = 0f;
				TCogMmKASgopRYQJTNMtdAvdwtIe = 0f;
				EdlzUaIOdCOXEXPAWyQWBASofyY = 0f;
				DQysbbdoHDPlpAeeBSiYmmjBYbz = 0f;
				GLbyWguVoSuyBGnJfbXziXCsHPO = 0f;
				for (int i = 0; i < gljkmoyOBJrGQUmNqDaQBfHacODV.Length; i++)
				{
					gljkmoyOBJrGQUmNqDaQBfHacODV[i] = 0f;
				}
				for (int j = 0; j < mSeXMQpIolvHxXuiVLsSKBhIhGfH.Length; j++)
				{
					mSeXMQpIolvHxXuiVLsSKBhIhGfH[j] = 0;
				}
				for (int k = 0; k < OZXCbzyfeJVptcfXueOFPpFxErd.Length; k++)
				{
					OZXCbzyfeJVptcfXueOFPpFxErd[k] = false;
				}
				yqcjjMQvejIokWKMBapsKKiozwT = 0f;
				djKPQOAWngqnVpncpdtoeNFWLdhr = 0f;
				SiTAMlPnuqbVwhxyevgmJzerzzWq = 0f;
				oEHOYUnthFiMDrqwXfCuEDgFALxX = 0f;
				ACneJuXoJhfqxfOCtjZajhvCKdIg = 0f;
				rwZlWhqrMonenQBoRuRggMEBTaR = 0f;
				for (int l = 0; l < FOhAAOAzmohUPgzASmfrbUHqKSxw.Length; l++)
				{
					FOhAAOAzmohUPgzASmfrbUHqKSxw[l] = 0f;
				}
				QtGVhGCdczHTabxrZzdRPrCmcFIk = 0f;
				maBbJvUkRsqitIlgaKjqrgDXgJh = 0f;
				HAPIvWFpMbTqoVxbfdBKGmEKjwMD = 0f;
				KnZRfKkpbOxfzlgtcOSnwIcFvoU = 0f;
				sgsDqvJTsHfsvOJsZeZXGduxWTE = 0f;
				BvlyDJjQGZkZVIWkSmDNcVOyJUe = 0f;
				for (int m = 0; m < ZpABAkfHwHQDSOGXlKXhcmEydNqq.Length; m++)
				{
					ZpABAkfHwHQDSOGXlKXhcmEydNqq[m] = 0f;
				}
				PMYsmgFkMdlUJldlnEfzdjaaJf = 0f;
				XFtrQkrNkPBxJEKYzmoSMULzujeL = 0f;
				OtUGEwCUrYfgLqGOZPAfTOWdcAl = 0f;
				ZmviqYAaSckrJAJfoMAKzAMBigO = 0f;
				TNSVOyeEanHBtTbVhWsGwnpMCRE = 0f;
				enAbylCthhDBABwXbZWLOsvRNbHd = 0f;
				for (int n = 0; n < JUFhaMDmUXULJISwjxqzazZysjK.Length; n++)
				{
					JUFhaMDmUXULJISwjxqzazZysjK[n] = 0f;
				}
			}

			public void TxqPmgQJJZQbZzjuubnQExXfSKBm(GIXNqmzZjgjyqWwoyPfRFlltdEF P_0)
			{
				xpumVntKTYPdUAcEeqwWhsPgirN = P_0.xpumVntKTYPdUAcEeqwWhsPgirN;
				RTwQzyWgdmiDfVtyeEaNgdMceZg = P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg;
				TCogMmKASgopRYQJTNMtdAvdwtIe = P_0.TCogMmKASgopRYQJTNMtdAvdwtIe;
				EdlzUaIOdCOXEXPAWyQWBASofyY = P_0.EdlzUaIOdCOXEXPAWyQWBASofyY;
				DQysbbdoHDPlpAeeBSiYmmjBYbz = P_0.DQysbbdoHDPlpAeeBSiYmmjBYbz;
				GLbyWguVoSuyBGnJfbXziXCsHPO = P_0.GLbyWguVoSuyBGnJfbXziXCsHPO;
				for (int i = 0; i < gljkmoyOBJrGQUmNqDaQBfHacODV.Length; i++)
				{
					gljkmoyOBJrGQUmNqDaQBfHacODV[i] = P_0.gljkmoyOBJrGQUmNqDaQBfHacODV[i];
				}
				for (int j = 0; j < mSeXMQpIolvHxXuiVLsSKBhIhGfH.Length; j++)
				{
					mSeXMQpIolvHxXuiVLsSKBhIhGfH[j] = P_0.mSeXMQpIolvHxXuiVLsSKBhIhGfH[j];
				}
				for (int k = 0; k < OZXCbzyfeJVptcfXueOFPpFxErd.Length; k++)
				{
					OZXCbzyfeJVptcfXueOFPpFxErd[k] = P_0.OZXCbzyfeJVptcfXueOFPpFxErd[k];
				}
				yqcjjMQvejIokWKMBapsKKiozwT = P_0.yqcjjMQvejIokWKMBapsKKiozwT;
				djKPQOAWngqnVpncpdtoeNFWLdhr = P_0.djKPQOAWngqnVpncpdtoeNFWLdhr;
				SiTAMlPnuqbVwhxyevgmJzerzzWq = P_0.SiTAMlPnuqbVwhxyevgmJzerzzWq;
				oEHOYUnthFiMDrqwXfCuEDgFALxX = P_0.oEHOYUnthFiMDrqwXfCuEDgFALxX;
				ACneJuXoJhfqxfOCtjZajhvCKdIg = P_0.ACneJuXoJhfqxfOCtjZajhvCKdIg;
				rwZlWhqrMonenQBoRuRggMEBTaR = P_0.rwZlWhqrMonenQBoRuRggMEBTaR;
				for (int l = 0; l < FOhAAOAzmohUPgzASmfrbUHqKSxw.Length; l++)
				{
					FOhAAOAzmohUPgzASmfrbUHqKSxw[l] = P_0.FOhAAOAzmohUPgzASmfrbUHqKSxw[l];
				}
				QtGVhGCdczHTabxrZzdRPrCmcFIk = P_0.QtGVhGCdczHTabxrZzdRPrCmcFIk;
				maBbJvUkRsqitIlgaKjqrgDXgJh = P_0.maBbJvUkRsqitIlgaKjqrgDXgJh;
				HAPIvWFpMbTqoVxbfdBKGmEKjwMD = P_0.HAPIvWFpMbTqoVxbfdBKGmEKjwMD;
				KnZRfKkpbOxfzlgtcOSnwIcFvoU = P_0.KnZRfKkpbOxfzlgtcOSnwIcFvoU;
				sgsDqvJTsHfsvOJsZeZXGduxWTE = P_0.sgsDqvJTsHfsvOJsZeZXGduxWTE;
				BvlyDJjQGZkZVIWkSmDNcVOyJUe = P_0.BvlyDJjQGZkZVIWkSmDNcVOyJUe;
				for (int m = 0; m < ZpABAkfHwHQDSOGXlKXhcmEydNqq.Length; m++)
				{
					ZpABAkfHwHQDSOGXlKXhcmEydNqq[m] = P_0.ZpABAkfHwHQDSOGXlKXhcmEydNqq[m];
				}
				PMYsmgFkMdlUJldlnEfzdjaaJf = P_0.PMYsmgFkMdlUJldlnEfzdjaaJf;
				XFtrQkrNkPBxJEKYzmoSMULzujeL = P_0.XFtrQkrNkPBxJEKYzmoSMULzujeL;
				OtUGEwCUrYfgLqGOZPAfTOWdcAl = P_0.OtUGEwCUrYfgLqGOZPAfTOWdcAl;
				ZmviqYAaSckrJAJfoMAKzAMBigO = P_0.ZmviqYAaSckrJAJfoMAKzAMBigO;
				TNSVOyeEanHBtTbVhWsGwnpMCRE = P_0.TNSVOyeEanHBtTbVhWsGwnpMCRE;
				enAbylCthhDBABwXbZWLOsvRNbHd = P_0.enAbylCthhDBABwXbZWLOsvRNbHd;
				for (int n = 0; n < JUFhaMDmUXULJISwjxqzazZysjK.Length; n++)
				{
					JUFhaMDmUXULJISwjxqzazZysjK[n] = P_0.JUFhaMDmUXULJISwjxqzazZysjK[n];
				}
			}

			public unsafe void TxqPmgQJJZQbZzjuubnQExXfSKBm(ref LowLevelInputEvent P_0)
			{
				for (int i = 0; i < 4; i++)
				{
					int num = *(int*)((byte*)(void*)P_0._buffer + P_0.byteIndex_buttonsStart + (long)i * 4L);
					for (int j = 0; j < 32; j++)
					{
						OZXCbzyfeJVptcfXueOFPpFxErd[i * 32 + j] = (num & (1 << j)) != 0;
					}
				}
				float* ptr = (float*)((byte*)(void*)P_0._buffer + P_0.byteIndex_axesStart);
				for (int k = 0; k < 2; k++)
				{
					ZpABAkfHwHQDSOGXlKXhcmEydNqq[k] = *ptr;
					ptr++;
				}
				QtGVhGCdczHTabxrZzdRPrCmcFIk = *ptr;
				ptr++;
				maBbJvUkRsqitIlgaKjqrgDXgJh = *ptr;
				ptr++;
				HAPIvWFpMbTqoVxbfdBKGmEKjwMD = *ptr;
				ptr++;
				KnZRfKkpbOxfzlgtcOSnwIcFvoU = *ptr;
				ptr++;
				sgsDqvJTsHfsvOJsZeZXGduxWTE = *ptr;
				ptr++;
				BvlyDJjQGZkZVIWkSmDNcVOyJUe = *ptr;
				ptr++;
				oEHOYUnthFiMDrqwXfCuEDgFALxX = *ptr;
				ptr++;
				ACneJuXoJhfqxfOCtjZajhvCKdIg = *ptr;
				ptr++;
				rwZlWhqrMonenQBoRuRggMEBTaR = *ptr;
				ptr++;
				for (int l = 0; l < 2; l++)
				{
					JUFhaMDmUXULJISwjxqzazZysjK[l] = *ptr;
					ptr++;
				}
				PMYsmgFkMdlUJldlnEfzdjaaJf = *ptr;
				ptr++;
				XFtrQkrNkPBxJEKYzmoSMULzujeL = *ptr;
				ptr++;
				OtUGEwCUrYfgLqGOZPAfTOWdcAl = *ptr;
				ptr++;
				EdlzUaIOdCOXEXPAWyQWBASofyY = *ptr;
				ptr++;
				DQysbbdoHDPlpAeeBSiYmmjBYbz = *ptr;
				ptr++;
				GLbyWguVoSuyBGnJfbXziXCsHPO = *ptr;
				ptr++;
				for (int m = 0; m < 2; m++)
				{
					gljkmoyOBJrGQUmNqDaQBfHacODV[m] = *ptr;
					ptr++;
				}
				ZmviqYAaSckrJAJfoMAKzAMBigO = *ptr;
				ptr++;
				TNSVOyeEanHBtTbVhWsGwnpMCRE = *ptr;
				ptr++;
				enAbylCthhDBABwXbZWLOsvRNbHd = *ptr;
				ptr++;
				for (int n = 0; n < 2; n++)
				{
					FOhAAOAzmohUPgzASmfrbUHqKSxw[n] = *ptr;
					ptr++;
				}
				yqcjjMQvejIokWKMBapsKKiozwT = *ptr;
				ptr++;
				djKPQOAWngqnVpncpdtoeNFWLdhr = *ptr;
				ptr++;
				SiTAMlPnuqbVwhxyevgmJzerzzWq = *ptr;
				ptr++;
				xpumVntKTYPdUAcEeqwWhsPgirN = *ptr;
				ptr++;
				RTwQzyWgdmiDfVtyeEaNgdMceZg = *ptr;
				ptr++;
				TCogMmKASgopRYQJTNMtdAvdwtIe = *ptr;
				ptr++;
				int* ptr2 = (int*)((byte*)(void*)P_0._buffer + P_0.byteIndex_hatsStart);
				for (int num2 = 0; num2 < 2; num2++)
				{
					mSeXMQpIolvHxXuiVLsSKBhIhGfH[num2] = *ptr2;
					ptr2++;
				}
			}

			public unsafe static void ypsuGzjdXJTqUlHfPRinEihLrWE(LsFqLAvQnLGDBdBDuCWOBAydFmq P_0, double P_1, LowLevelInputEvent P_2)
			{
				int[] pointOfViewControllers = P_0.mSeXMQpIolvHxXuiVLsSKBhIhGfH;
				int[] accelerationSliders = P_0.ZpABAkfHwHQDSOGXlKXhcmEydNqq;
				int[] forceSliders = P_0.JUFhaMDmUXULJISwjxqzazZysjK;
				int[] sliders = P_0.gljkmoyOBJrGQUmNqDaQBfHacODV;
				int[] velocitySliders = P_0.FOhAAOAzmohUPgzASmfrbUHqKSxw;
				*(double*)((byte*)(void*)P_2._buffer + 4) = P_1;
				int num = 0;
				int num2 = 0;
				int num3 = 0;
				for (int i = 0; i < 128; i++)
				{
					if (P_0.OZXCbzyfeJVptcfXueOFPpFxErd[i])
					{
						num |= 1 << num3;
					}
					num3++;
					if (num3 == 32)
					{
						*(int*)((byte*)(void*)P_2._buffer + P_2.byteIndex_buttonsStart + (long)num2 * 4L) = num;
						num3 = 0;
						num = 0;
						num2++;
					}
				}
				float* ptr = (float*)((byte*)(void*)P_2._buffer + P_2.byteIndex_axesStart);
				for (int j = 0; j < 2; j++)
				{
					*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(accelerationSliders[j]);
					ptr++;
				}
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.QtGVhGCdczHTabxrZzdRPrCmcFIk);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.maBbJvUkRsqitIlgaKjqrgDXgJh);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.HAPIvWFpMbTqoVxbfdBKGmEKjwMD);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.KnZRfKkpbOxfzlgtcOSnwIcFvoU);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.sgsDqvJTsHfsvOJsZeZXGduxWTE);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.BvlyDJjQGZkZVIWkSmDNcVOyJUe);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.oEHOYUnthFiMDrqwXfCuEDgFALxX);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.ACneJuXoJhfqxfOCtjZajhvCKdIg);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.rwZlWhqrMonenQBoRuRggMEBTaR);
				ptr++;
				for (int k = 0; k < 2; k++)
				{
					*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(forceSliders[k]);
					ptr++;
				}
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.PMYsmgFkMdlUJldlnEfzdjaaJf);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.XFtrQkrNkPBxJEKYzmoSMULzujeL);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.OtUGEwCUrYfgLqGOZPAfTOWdcAl);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.EdlzUaIOdCOXEXPAWyQWBASofyY);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.DQysbbdoHDPlpAeeBSiYmmjBYbz);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.GLbyWguVoSuyBGnJfbXziXCsHPO);
				ptr++;
				for (int l = 0; l < 2; l++)
				{
					*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(sliders[l]);
					ptr++;
				}
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.ZmviqYAaSckrJAJfoMAKzAMBigO);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.TNSVOyeEanHBtTbVhWsGwnpMCRE);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.enAbylCthhDBABwXbZWLOsvRNbHd);
				ptr++;
				for (int m = 0; m < 2; m++)
				{
					*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(velocitySliders[m]);
					ptr++;
				}
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.yqcjjMQvejIokWKMBapsKKiozwT);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.djKPQOAWngqnVpncpdtoeNFWLdhr);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.SiTAMlPnuqbVwhxyevgmJzerzzWq);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.xpumVntKTYPdUAcEeqwWhsPgirN);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg);
				ptr++;
				*ptr = tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.TCogMmKASgopRYQJTNMtdAvdwtIe);
				ptr++;
				int* ptr2 = (int*)((byte*)(void*)P_2._buffer + P_2.byteIndex_hatsStart);
				for (int n = 0; n < 2; n++)
				{
					*ptr2 = pointOfViewControllers[n];
					ptr2++;
				}
			}
		}

		private const int GaEHUFhloHHZXVNCnCMDcfihCeYs = 2;

		private const int soddiEoYCDrjyFbseHWgNKNSRsC = 2;

		private const int JOGOdJmxGblhEagzMwwDeSOKfTA = 128;

		private const int yZspyCMFndEAogKgewfxafgcDFCf = 32;

		private const int UPdFHXGqCVRWKvJaxkQeaPimxpg = 0;

		private const int yDQoSbHlRgpllIbCYINsBxRfqrqL = 264;

		private const int IZpyTxZDPGfDpJWzwxAvWyqjNBY = 272;

		private readonly int xtOVtWiRSwynUsAASZxCvWzqNLn;

		private readonly ButtonLoopSet pimGaxMynqiIGbxFRcEionkSvOj;

		private readonly DualThreadLowLevelInputEventQueue hkxQVbyJugMICBLKVxLAPGGthIHJ;

		private AbNGaKzZrMCfivoYMxAIGtiGDfJ zhfgXnOUpYdeptwhwzfEQaOgXYC;

		private readonly LsFqLAvQnLGDBdBDuCWOBAydFmq MwRINdhaFngjovTbpZQmJSjfUKs;

		private readonly LsFqLAvQnLGDBdBDuCWOBAydFmq FDOfFOFUnavoQQzcIwhIWIUZvqN;

		private readonly object tDbgVRmshvprTuFsEwttpQVIOkk;

		private bool tuVLllvCFeToSgCnpYdwTjlfWUq;

		public readonly nFospmxJfsUfwGENuIBuWbrCFAW MunZepaFKdYsUldLUBVBfpSOkuHK;

		private readonly GIXNqmzZjgjyqWwoyPfRFlltdEF LYkQppIcKPRFpePsChZPuQqFqQk;

		private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

		public bool[] LwmOfqNgIYjfTKnDoIWjaIBKeCxD => pimGaxMynqiIGbxFRcEionkSvOj.Current.effectiveValue;

		public GIXNqmzZjgjyqWwoyPfRFlltdEF uavJrsMjpaFotDyYjmdcDZVBwFWG => LYkQppIcKPRFpePsChZPuQqFqQk;

		public apubADxSfJorcFkbCCCEczQVHYF(nFospmxJfsUfwGENuIBuWbrCFAW source, UpdateLoopSetting updateLoops)
		{
			MunZepaFKdYsUldLUBVBfpSOkuHK = source;
			xtOVtWiRSwynUsAASZxCvWzqNLn = source.INkPMrgmFQHrPoFjcDSDiHJFEiNM.nhlHpZITRUjXvMxgnPukLkSwoEV;
			pimGaxMynqiIGbxFRcEionkSvOj = new ButtonLoopSet(updateLoops, xtOVtWiRSwynUsAASZxCvWzqNLn);
			hkxQVbyJugMICBLKVxLAPGGthIHJ = new DualThreadLowLevelInputEventQueue((int)((float)lnoFVvbmWwakViCuJntBYhJMonm.bdwnaKkumjoZqcfKWJSyUhZBBWaF * 0.25f), 128, 32, 2);
			LYkQppIcKPRFpePsChZPuQqFqQk = new GIXNqmzZjgjyqWwoyPfRFlltdEF();
			MwRINdhaFngjovTbpZQmJSjfUKs = new LsFqLAvQnLGDBdBDuCWOBAydFmq();
			FDOfFOFUnavoQQzcIwhIWIUZvqN = new LsFqLAvQnLGDBdBDuCWOBAydFmq();
			tDbgVRmshvprTuFsEwttpQVIOkk = new object();
			if (lnoFVvbmWwakViCuJntBYhJMonm.vASBewikQenvassTqAnBRckmkUcD != null)
			{
				lnoFVvbmWwakViCuJntBYhJMonm.vASBewikQenvassTqAnBRckmkUcD.ThreadUpdateEvent += DBRcdHlxLcHiHqHmMVJHGfrdCCOf;
			}
		}

		public void YYZBcNHuDDPbbahkHHyTHvUNFGE()
		{
			pimGaxMynqiIGbxFRcEionkSvOj.SetUpdateLoop(ReInput.currentUpdateLoop);
			LaQpKXVyhaVPIvtfXhlSfJCuDrKA();
		}

		public void aWoeUUEECkNImBpxjMjDHgymWpn()
		{
			pimGaxMynqiIGbxFRcEionkSvOj.Current.ClearWasTrueThisFrame();
		}

		public void QTjmhwTeuRVhauTKAbvNjtNMtgF()
		{
			OeUrnnZKFEfcUxLGqEbSdcenXWX();
			tuVLllvCFeToSgCnpYdwTjlfWUq = true;
		}

		public void nwwunQEtKXtRahhaVmgytaMELdz()
		{
			tuVLllvCFeToSgCnpYdwTjlfWUq = false;
			OeUrnnZKFEfcUxLGqEbSdcenXWX();
		}

		public void mBTEWwhZTVXHADiOGGiZHrhHDFU(apubADxSfJorcFkbCCCEczQVHYF P_0)
		{
			if (P_0 == null || P_0 == this || P_0.xtOVtWiRSwynUsAASZxCvWzqNLn != xtOVtWiRSwynUsAASZxCvWzqNLn)
			{
				return;
			}
			_ = ReInput.realTime;
			lock (tDbgVRmshvprTuFsEwttpQVIOkk)
			{
				lock (P_0.tDbgVRmshvprTuFsEwttpQVIOkk)
				{
					pimGaxMynqiIGbxFRcEionkSvOj.Import(P_0.pimGaxMynqiIGbxFRcEionkSvOj);
					LYkQppIcKPRFpePsChZPuQqFqQk.TxqPmgQJJZQbZzjuubnQExXfSKBm(P_0.LYkQppIcKPRFpePsChZPuQqFqQk);
					MwRINdhaFngjovTbpZQmJSjfUKs.TxqPmgQJJZQbZzjuubnQExXfSKBm(P_0.MwRINdhaFngjovTbpZQmJSjfUKs);
					FDOfFOFUnavoQQzcIwhIWIUZvqN.TxqPmgQJJZQbZzjuubnQExXfSKBm(P_0.FDOfFOFUnavoQQzcIwhIWIUZvqN);
					hkxQVbyJugMICBLKVxLAPGGthIHJ.ImportAll(P_0.hkxQVbyJugMICBLKVxLAPGGthIHJ);
					zhfgXnOUpYdeptwhwzfEQaOgXYC = AbNGaKzZrMCfivoYMxAIGtiGDfJ.JYwvyJHcipFncvRIstYsddtWcNW(P_0.zhfgXnOUpYdeptwhwzfEQaOgXYC, MwRINdhaFngjovTbpZQmJSjfUKs);
					tuVLllvCFeToSgCnpYdwTjlfWUq = P_0.tuVLllvCFeToSgCnpYdwTjlfWUq;
				}
			}
		}

		public void BhZZUjegEYgcTUtEfWQacLpJxqJ(int P_0, int P_1, int P_2, float P_3)
		{
			lock (tDbgVRmshvprTuFsEwttpQVIOkk)
			{
				zhfgXnOUpYdeptwhwzfEQaOgXYC = new AbNGaKzZrMCfivoYMxAIGtiGDfJ(MwRINdhaFngjovTbpZQmJSjfUKs, P_0, P_1, P_2, P_3);
			}
		}

		private void DBRcdHlxLcHiHqHmMVJHGfrdCCOf()
		{
			if (!tuVLllvCFeToSgCnpYdwTjlfWUq)
			{
				return;
			}
			double realTime;
			try
			{
				MunZepaFKdYsUldLUBVBfpSOkuHK.qKYEKtVAHBeycawCeYUnkrJHVZa(MwRINdhaFngjovTbpZQmJSjfUKs);
				realTime = ReInput.realTime;
			}
			catch
			{
				return;
			}
			lock (tDbgVRmshvprTuFsEwttpQVIOkk)
			{
				if (zhfgXnOUpYdeptwhwzfEQaOgXYC != null)
				{
					zhfgXnOUpYdeptwhwzfEQaOgXYC.EBZMKoSknSfzkSfokUzktanzxJf(realTime);
				}
				if (!MwRINdhaFngjovTbpZQmJSjfUKs.sCZbNtcKCGqccJJUJfPEAsDRsVD(FDOfFOFUnavoQQzcIwhIWIUZvqN))
				{
					using (DualThreadLowLevelInputEventQueue.INewEventWrapper newEventWrapper = hkxQVbyJugMICBLKVxLAPGGthIHJ.T_CreateEvent())
					{
						GIXNqmzZjgjyqWwoyPfRFlltdEF.ypsuGzjdXJTqUlHfPRinEihLrWE(MwRINdhaFngjovTbpZQmJSjfUKs, realTime, newEventWrapper.Event);
					}
					FDOfFOFUnavoQQzcIwhIWIUZvqN.TxqPmgQJJZQbZzjuubnQExXfSKBm(MwRINdhaFngjovTbpZQmJSjfUKs);
				}
			}
		}

		private void LaQpKXVyhaVPIvtfXhlSfJCuDrKA()
		{
			while (hkxQVbyJugMICBLKVxLAPGGthIHJ.ProcessNewEvents())
			{
				LYkQppIcKPRFpePsChZPuQqFqQk.TxqPmgQJJZQbZzjuubnQExXfSKBm(ref hkxQVbyJugMICBLKVxLAPGGthIHJ.currentEvent);
				for (int i = 0; i < xtOVtWiRSwynUsAASZxCvWzqNLn; i++)
				{
					pimGaxMynqiIGbxFRcEionkSvOj.SetValue(i, LYkQppIcKPRFpePsChZPuQqFqQk.OZXCbzyfeJVptcfXueOFPpFxErd[i], hkxQVbyJugMICBLKVxLAPGGthIHJ.currentEvent.GetTimestamp());
				}
			}
		}

		private void OeUrnnZKFEfcUxLGqEbSdcenXWX()
		{
			LYkQppIcKPRFpePsChZPuQqFqQk.xZveeqhZWQBoifJNrEKvhlbeSAk();
			lock (tDbgVRmshvprTuFsEwttpQVIOkk)
			{
				MwRINdhaFngjovTbpZQmJSjfUKs.xZveeqhZWQBoifJNrEKvhlbeSAk();
				FDOfFOFUnavoQQzcIwhIWIUZvqN.xZveeqhZWQBoifJNrEKvhlbeSAk();
				hkxQVbyJugMICBLKVxLAPGGthIHJ.Clear();
			}
			pimGaxMynqiIGbxFRcEionkSvOj.Clear();
		}

		public void Dispose()
		{
			PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
			GC.SuppressFinalize(this);
		}

		~apubADxSfJorcFkbCCCEczQVHYF()
		{
			PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
		}

		protected virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
		{
			if (!jpnIPbpqmlecdiNqaFAxiNCsiMxs)
			{
				if (P_0)
				{
					nwwunQEtKXtRahhaVmgytaMELdz();
					hkxQVbyJugMICBLKVxLAPGGthIHJ.Dispose();
				}
				if (lnoFVvbmWwakViCuJntBYhJMonm.vASBewikQenvassTqAnBRckmkUcD != null)
				{
					lnoFVvbmWwakViCuJntBYhJMonm.vASBewikQenvassTqAnBRckmkUcD.ThreadUpdateEvent -= DBRcdHlxLcHiHqHmMVJHGfrdCCOf;
				}
				jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
			}
		}

		private static float tRSsFucqdzXsNtvLSMlgIVxHHWP(int P_0)
		{
			if (P_0 == 0)
			{
				return 0f;
			}
			return MathTools.Clamp((float)MathTools.Abs(P_0) / 65535f * (float)MathTools.Sign(P_0), -1f, 1f);
		}
	}

	private class AbNGaKzZrMCfivoYMxAIGtiGDfJ
	{
		private LsFqLAvQnLGDBdBDuCWOBAydFmq AkOFMCTjcIfvfGkDIuGUSCCYHNs;

		private IVeOhppWlSdYiYcuZJCbKpxhInf qdrcFwDIYcQqwamdKdqoQPnuxEl;

		private int GWGjvmavdpMTzwmylqeQkkPlIHHF;

		private int LrRJPmwAwgSfDjmqgEJihyaNhcxE;

		private int DLCDglDTMeMxiTALHPrNTiDzdQYk;

		private float THfazvcqfiDNoauPgwcUBOqYfNVE;

		public LsFqLAvQnLGDBdBDuCWOBAydFmq dppVBsbnRfYftslzSqelpoQMcuf => AkOFMCTjcIfvfGkDIuGUSCCYHNs;

		public static AbNGaKzZrMCfivoYMxAIGtiGDfJ JYwvyJHcipFncvRIstYsddtWcNW(AbNGaKzZrMCfivoYMxAIGtiGDfJ P_0, LsFqLAvQnLGDBdBDuCWOBAydFmq P_1)
		{
			if (P_0 == null || P_1 == null)
			{
				return null;
			}
			return new AbNGaKzZrMCfivoYMxAIGtiGDfJ(P_0, P_1);
		}

		public AbNGaKzZrMCfivoYMxAIGtiGDfJ(LsFqLAvQnLGDBdBDuCWOBAydFmq state, int axisMin, int axisMax, int axisZero, float eventTimeout)
			: this(axisMin, axisMax, axisZero, eventTimeout)
		{
			qdrcFwDIYcQqwamdKdqoQPnuxEl = new IVeOhppWlSdYiYcuZJCbKpxhInf(state);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs = new LsFqLAvQnLGDBdBDuCWOBAydFmq();
		}

		private AbNGaKzZrMCfivoYMxAIGtiGDfJ(AbNGaKzZrMCfivoYMxAIGtiGDfJ source, LsFqLAvQnLGDBdBDuCWOBAydFmq state)
			: this(state, source.GWGjvmavdpMTzwmylqeQkkPlIHHF, source.LrRJPmwAwgSfDjmqgEJihyaNhcxE, source.DLCDglDTMeMxiTALHPrNTiDzdQYk, source.THfazvcqfiDNoauPgwcUBOqYfNVE)
		{
			TxqPmgQJJZQbZzjuubnQExXfSKBm(source);
		}

		private AbNGaKzZrMCfivoYMxAIGtiGDfJ(int axisMin, int axisMax, int axisZero, float axisTimeout)
		{
			GWGjvmavdpMTzwmylqeQkkPlIHHF = axisMin;
			LrRJPmwAwgSfDjmqgEJihyaNhcxE = axisMax;
			DLCDglDTMeMxiTALHPrNTiDzdQYk = axisZero;
			THfazvcqfiDNoauPgwcUBOqYfNVE = axisTimeout;
		}

		public void EBZMKoSknSfzkSfokUzktanzxJf(double P_0)
		{
			qdrcFwDIYcQqwamdKdqoQPnuxEl.EBZMKoSknSfzkSfokUzktanzxJf(P_0);
			if (!qdrcFwDIYcQqwamdKdqoQPnuxEl.mDpjkRnKWNBMYCTLlfgWmcPlPCRq)
			{
				if (P_0 >= qdrcFwDIYcQqwamdKdqoQPnuxEl.OqJfjTHdeRbznXLjExaQHmpNvRD + (double)THfazvcqfiDNoauPgwcUBOqYfNVE)
				{
					AkOFMCTjcIfvfGkDIuGUSCCYHNs.xZveeqhZWQBoifJNrEKvhlbeSAk();
				}
				return;
			}
			LsFqLAvQnLGDBdBDuCWOBAydFmq changedState = qdrcFwDIYcQqwamdKdqoQPnuxEl.LJUeamNYtStklAfqcqYZIUzupXN;
			LsFqLAvQnLGDBdBDuCWOBAydFmq sourceState = qdrcFwDIYcQqwamdKdqoQPnuxEl.lqEnRpJVeEsnDUQhXafVaKpYGBzA;
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.xpumVntKTYPdUAcEeqwWhsPgirN = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.xpumVntKTYPdUAcEeqwWhsPgirN);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.RTwQzyWgdmiDfVtyeEaNgdMceZg = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.RTwQzyWgdmiDfVtyeEaNgdMceZg);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.TCogMmKASgopRYQJTNMtdAvdwtIe = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.TCogMmKASgopRYQJTNMtdAvdwtIe);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.EdlzUaIOdCOXEXPAWyQWBASofyY = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.EdlzUaIOdCOXEXPAWyQWBASofyY);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.DQysbbdoHDPlpAeeBSiYmmjBYbz = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.DQysbbdoHDPlpAeeBSiYmmjBYbz);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.GLbyWguVoSuyBGnJfbXziXCsHPO = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.GLbyWguVoSuyBGnJfbXziXCsHPO);
			for (int i = 0; i < AkOFMCTjcIfvfGkDIuGUSCCYHNs.gljkmoyOBJrGQUmNqDaQBfHacODV.Length; i++)
			{
				AkOFMCTjcIfvfGkDIuGUSCCYHNs.gljkmoyOBJrGQUmNqDaQBfHacODV[i] = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.gljkmoyOBJrGQUmNqDaQBfHacODV[i]);
			}
			for (int j = 0; j < AkOFMCTjcIfvfGkDIuGUSCCYHNs.mSeXMQpIolvHxXuiVLsSKBhIhGfH.Length; j++)
			{
				AkOFMCTjcIfvfGkDIuGUSCCYHNs.mSeXMQpIolvHxXuiVLsSKBhIhGfH[j] = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.mSeXMQpIolvHxXuiVLsSKBhIhGfH[j]);
			}
			for (int k = 0; k < AkOFMCTjcIfvfGkDIuGUSCCYHNs.OZXCbzyfeJVptcfXueOFPpFxErd.Length; k++)
			{
				AkOFMCTjcIfvfGkDIuGUSCCYHNs.OZXCbzyfeJVptcfXueOFPpFxErd[k] = sourceState.OZXCbzyfeJVptcfXueOFPpFxErd[k];
			}
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.yqcjjMQvejIokWKMBapsKKiozwT = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.yqcjjMQvejIokWKMBapsKKiozwT);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.djKPQOAWngqnVpncpdtoeNFWLdhr = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.djKPQOAWngqnVpncpdtoeNFWLdhr);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.SiTAMlPnuqbVwhxyevgmJzerzzWq = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.SiTAMlPnuqbVwhxyevgmJzerzzWq);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.oEHOYUnthFiMDrqwXfCuEDgFALxX = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.oEHOYUnthFiMDrqwXfCuEDgFALxX);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.ACneJuXoJhfqxfOCtjZajhvCKdIg = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.ACneJuXoJhfqxfOCtjZajhvCKdIg);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.rwZlWhqrMonenQBoRuRggMEBTaR = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.rwZlWhqrMonenQBoRuRggMEBTaR);
			for (int l = 0; l < AkOFMCTjcIfvfGkDIuGUSCCYHNs.FOhAAOAzmohUPgzASmfrbUHqKSxw.Length; l++)
			{
				AkOFMCTjcIfvfGkDIuGUSCCYHNs.FOhAAOAzmohUPgzASmfrbUHqKSxw[l] = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.FOhAAOAzmohUPgzASmfrbUHqKSxw[l]);
			}
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.QtGVhGCdczHTabxrZzdRPrCmcFIk = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.QtGVhGCdczHTabxrZzdRPrCmcFIk);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.maBbJvUkRsqitIlgaKjqrgDXgJh = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.maBbJvUkRsqitIlgaKjqrgDXgJh);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.HAPIvWFpMbTqoVxbfdBKGmEKjwMD = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.HAPIvWFpMbTqoVxbfdBKGmEKjwMD);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.KnZRfKkpbOxfzlgtcOSnwIcFvoU = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.KnZRfKkpbOxfzlgtcOSnwIcFvoU);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.sgsDqvJTsHfsvOJsZeZXGduxWTE = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.sgsDqvJTsHfsvOJsZeZXGduxWTE);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.BvlyDJjQGZkZVIWkSmDNcVOyJUe = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.BvlyDJjQGZkZVIWkSmDNcVOyJUe);
			for (int m = 0; m < AkOFMCTjcIfvfGkDIuGUSCCYHNs.ZpABAkfHwHQDSOGXlKXhcmEydNqq.Length; m++)
			{
				AkOFMCTjcIfvfGkDIuGUSCCYHNs.ZpABAkfHwHQDSOGXlKXhcmEydNqq[m] = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.ZpABAkfHwHQDSOGXlKXhcmEydNqq[m]);
			}
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.PMYsmgFkMdlUJldlnEfzdjaaJf = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.PMYsmgFkMdlUJldlnEfzdjaaJf);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.XFtrQkrNkPBxJEKYzmoSMULzujeL = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.XFtrQkrNkPBxJEKYzmoSMULzujeL);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.OtUGEwCUrYfgLqGOZPAfTOWdcAl = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.OtUGEwCUrYfgLqGOZPAfTOWdcAl);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.ZmviqYAaSckrJAJfoMAKzAMBigO = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.ZmviqYAaSckrJAJfoMAKzAMBigO);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.TNSVOyeEanHBtTbVhWsGwnpMCRE = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.TNSVOyeEanHBtTbVhWsGwnpMCRE);
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.enAbylCthhDBABwXbZWLOsvRNbHd = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.enAbylCthhDBABwXbZWLOsvRNbHd);
			for (int n = 0; n < AkOFMCTjcIfvfGkDIuGUSCCYHNs.JUFhaMDmUXULJISwjxqzazZysjK.Length; n++)
			{
				AkOFMCTjcIfvfGkDIuGUSCCYHNs.JUFhaMDmUXULJISwjxqzazZysjK[n] = ZLUPEtuHHBtMPROEEkyCDeItangd(changedState.JUFhaMDmUXULJISwjxqzazZysjK[n]);
			}
		}

		public void TxqPmgQJJZQbZzjuubnQExXfSKBm(AbNGaKzZrMCfivoYMxAIGtiGDfJ P_0)
		{
			AkOFMCTjcIfvfGkDIuGUSCCYHNs.TxqPmgQJJZQbZzjuubnQExXfSKBm(P_0.AkOFMCTjcIfvfGkDIuGUSCCYHNs);
			qdrcFwDIYcQqwamdKdqoQPnuxEl.TxqPmgQJJZQbZzjuubnQExXfSKBm(P_0.qdrcFwDIYcQqwamdKdqoQPnuxEl);
			GWGjvmavdpMTzwmylqeQkkPlIHHF = P_0.GWGjvmavdpMTzwmylqeQkkPlIHHF;
			LrRJPmwAwgSfDjmqgEJihyaNhcxE = P_0.LrRJPmwAwgSfDjmqgEJihyaNhcxE;
			DLCDglDTMeMxiTALHPrNTiDzdQYk = P_0.DLCDglDTMeMxiTALHPrNTiDzdQYk;
			THfazvcqfiDNoauPgwcUBOqYfNVE = P_0.THfazvcqfiDNoauPgwcUBOqYfNVE;
		}

		private int ZLUPEtuHHBtMPROEEkyCDeItangd(int P_0)
		{
			return MathTools.ValueInNewRange(P_0, GWGjvmavdpMTzwmylqeQkkPlIHHF, LrRJPmwAwgSfDjmqgEJihyaNhcxE, -65535, 65535);
		}
	}

	private class IVeOhppWlSdYiYcuZJCbKpxhInf
	{
		private double uXdxcpWbDJEFJbQJYQsoRGfsqsU;

		private LsFqLAvQnLGDBdBDuCWOBAydFmq DivQmaVXvUrDaTTafeGwLhIzkfM;

		private LsFqLAvQnLGDBdBDuCWOBAydFmq YsxbcPhFadiLTsrXgJZsDBsqORkF;

		private LsFqLAvQnLGDBdBDuCWOBAydFmq CFLDKARPsQCFXiUPJNIIHuujClU;

		private bool dkKqhkkHKpsbTbCKIghRphYKxgi;

		private double rmHEVkHMGIGqgsxivYXMqBAQGjSo;

		public LsFqLAvQnLGDBdBDuCWOBAydFmq lqEnRpJVeEsnDUQhXafVaKpYGBzA => DivQmaVXvUrDaTTafeGwLhIzkfM;

		public LsFqLAvQnLGDBdBDuCWOBAydFmq LJUeamNYtStklAfqcqYZIUzupXN => CFLDKARPsQCFXiUPJNIIHuujClU;

		public bool mDpjkRnKWNBMYCTLlfgWmcPlPCRq => dkKqhkkHKpsbTbCKIghRphYKxgi;

		public double OqJfjTHdeRbznXLjExaQHmpNvRD => rmHEVkHMGIGqgsxivYXMqBAQGjSo;

		public IVeOhppWlSdYiYcuZJCbKpxhInf(LsFqLAvQnLGDBdBDuCWOBAydFmq sourceState)
		{
			DivQmaVXvUrDaTTafeGwLhIzkfM = sourceState;
			YsxbcPhFadiLTsrXgJZsDBsqORkF = new LsFqLAvQnLGDBdBDuCWOBAydFmq();
			CFLDKARPsQCFXiUPJNIIHuujClU = new LsFqLAvQnLGDBdBDuCWOBAydFmq();
		}

		public void EBZMKoSknSfzkSfokUzktanzxJf(double P_0)
		{
			uXdxcpWbDJEFJbQJYQsoRGfsqsU = P_0;
			CFLDKARPsQCFXiUPJNIIHuujClU.xpumVntKTYPdUAcEeqwWhsPgirN = DivQmaVXvUrDaTTafeGwLhIzkfM.xpumVntKTYPdUAcEeqwWhsPgirN - YsxbcPhFadiLTsrXgJZsDBsqORkF.xpumVntKTYPdUAcEeqwWhsPgirN;
			CFLDKARPsQCFXiUPJNIIHuujClU.RTwQzyWgdmiDfVtyeEaNgdMceZg = DivQmaVXvUrDaTTafeGwLhIzkfM.RTwQzyWgdmiDfVtyeEaNgdMceZg - YsxbcPhFadiLTsrXgJZsDBsqORkF.RTwQzyWgdmiDfVtyeEaNgdMceZg;
			CFLDKARPsQCFXiUPJNIIHuujClU.TCogMmKASgopRYQJTNMtdAvdwtIe = DivQmaVXvUrDaTTafeGwLhIzkfM.TCogMmKASgopRYQJTNMtdAvdwtIe - YsxbcPhFadiLTsrXgJZsDBsqORkF.TCogMmKASgopRYQJTNMtdAvdwtIe;
			CFLDKARPsQCFXiUPJNIIHuujClU.EdlzUaIOdCOXEXPAWyQWBASofyY = DivQmaVXvUrDaTTafeGwLhIzkfM.EdlzUaIOdCOXEXPAWyQWBASofyY - YsxbcPhFadiLTsrXgJZsDBsqORkF.EdlzUaIOdCOXEXPAWyQWBASofyY;
			CFLDKARPsQCFXiUPJNIIHuujClU.DQysbbdoHDPlpAeeBSiYmmjBYbz = DivQmaVXvUrDaTTafeGwLhIzkfM.DQysbbdoHDPlpAeeBSiYmmjBYbz - YsxbcPhFadiLTsrXgJZsDBsqORkF.DQysbbdoHDPlpAeeBSiYmmjBYbz;
			CFLDKARPsQCFXiUPJNIIHuujClU.GLbyWguVoSuyBGnJfbXziXCsHPO = DivQmaVXvUrDaTTafeGwLhIzkfM.GLbyWguVoSuyBGnJfbXziXCsHPO - YsxbcPhFadiLTsrXgJZsDBsqORkF.GLbyWguVoSuyBGnJfbXziXCsHPO;
			for (int i = 0; i < DivQmaVXvUrDaTTafeGwLhIzkfM.gljkmoyOBJrGQUmNqDaQBfHacODV.Length; i++)
			{
				CFLDKARPsQCFXiUPJNIIHuujClU.gljkmoyOBJrGQUmNqDaQBfHacODV[i] = DivQmaVXvUrDaTTafeGwLhIzkfM.gljkmoyOBJrGQUmNqDaQBfHacODV[i] - YsxbcPhFadiLTsrXgJZsDBsqORkF.gljkmoyOBJrGQUmNqDaQBfHacODV[i];
			}
			for (int j = 0; j < DivQmaVXvUrDaTTafeGwLhIzkfM.mSeXMQpIolvHxXuiVLsSKBhIhGfH.Length; j++)
			{
				CFLDKARPsQCFXiUPJNIIHuujClU.mSeXMQpIolvHxXuiVLsSKBhIhGfH[j] = DivQmaVXvUrDaTTafeGwLhIzkfM.mSeXMQpIolvHxXuiVLsSKBhIhGfH[j] - YsxbcPhFadiLTsrXgJZsDBsqORkF.mSeXMQpIolvHxXuiVLsSKBhIhGfH[j];
			}
			for (int k = 0; k < DivQmaVXvUrDaTTafeGwLhIzkfM.OZXCbzyfeJVptcfXueOFPpFxErd.Length; k++)
			{
				CFLDKARPsQCFXiUPJNIIHuujClU.OZXCbzyfeJVptcfXueOFPpFxErd[k] = DivQmaVXvUrDaTTafeGwLhIzkfM.OZXCbzyfeJVptcfXueOFPpFxErd[k] != YsxbcPhFadiLTsrXgJZsDBsqORkF.OZXCbzyfeJVptcfXueOFPpFxErd[k];
			}
			CFLDKARPsQCFXiUPJNIIHuujClU.yqcjjMQvejIokWKMBapsKKiozwT = DivQmaVXvUrDaTTafeGwLhIzkfM.yqcjjMQvejIokWKMBapsKKiozwT - YsxbcPhFadiLTsrXgJZsDBsqORkF.yqcjjMQvejIokWKMBapsKKiozwT;
			CFLDKARPsQCFXiUPJNIIHuujClU.djKPQOAWngqnVpncpdtoeNFWLdhr = DivQmaVXvUrDaTTafeGwLhIzkfM.djKPQOAWngqnVpncpdtoeNFWLdhr - YsxbcPhFadiLTsrXgJZsDBsqORkF.djKPQOAWngqnVpncpdtoeNFWLdhr;
			CFLDKARPsQCFXiUPJNIIHuujClU.SiTAMlPnuqbVwhxyevgmJzerzzWq = DivQmaVXvUrDaTTafeGwLhIzkfM.SiTAMlPnuqbVwhxyevgmJzerzzWq - YsxbcPhFadiLTsrXgJZsDBsqORkF.SiTAMlPnuqbVwhxyevgmJzerzzWq;
			CFLDKARPsQCFXiUPJNIIHuujClU.oEHOYUnthFiMDrqwXfCuEDgFALxX = DivQmaVXvUrDaTTafeGwLhIzkfM.oEHOYUnthFiMDrqwXfCuEDgFALxX - YsxbcPhFadiLTsrXgJZsDBsqORkF.oEHOYUnthFiMDrqwXfCuEDgFALxX;
			CFLDKARPsQCFXiUPJNIIHuujClU.ACneJuXoJhfqxfOCtjZajhvCKdIg = DivQmaVXvUrDaTTafeGwLhIzkfM.ACneJuXoJhfqxfOCtjZajhvCKdIg - YsxbcPhFadiLTsrXgJZsDBsqORkF.ACneJuXoJhfqxfOCtjZajhvCKdIg;
			CFLDKARPsQCFXiUPJNIIHuujClU.rwZlWhqrMonenQBoRuRggMEBTaR = DivQmaVXvUrDaTTafeGwLhIzkfM.rwZlWhqrMonenQBoRuRggMEBTaR - YsxbcPhFadiLTsrXgJZsDBsqORkF.rwZlWhqrMonenQBoRuRggMEBTaR;
			for (int l = 0; l < DivQmaVXvUrDaTTafeGwLhIzkfM.FOhAAOAzmohUPgzASmfrbUHqKSxw.Length; l++)
			{
				CFLDKARPsQCFXiUPJNIIHuujClU.FOhAAOAzmohUPgzASmfrbUHqKSxw[l] = DivQmaVXvUrDaTTafeGwLhIzkfM.FOhAAOAzmohUPgzASmfrbUHqKSxw[l] - YsxbcPhFadiLTsrXgJZsDBsqORkF.FOhAAOAzmohUPgzASmfrbUHqKSxw[l];
			}
			CFLDKARPsQCFXiUPJNIIHuujClU.QtGVhGCdczHTabxrZzdRPrCmcFIk = DivQmaVXvUrDaTTafeGwLhIzkfM.QtGVhGCdczHTabxrZzdRPrCmcFIk - YsxbcPhFadiLTsrXgJZsDBsqORkF.QtGVhGCdczHTabxrZzdRPrCmcFIk;
			CFLDKARPsQCFXiUPJNIIHuujClU.maBbJvUkRsqitIlgaKjqrgDXgJh = DivQmaVXvUrDaTTafeGwLhIzkfM.maBbJvUkRsqitIlgaKjqrgDXgJh - YsxbcPhFadiLTsrXgJZsDBsqORkF.maBbJvUkRsqitIlgaKjqrgDXgJh;
			CFLDKARPsQCFXiUPJNIIHuujClU.HAPIvWFpMbTqoVxbfdBKGmEKjwMD = DivQmaVXvUrDaTTafeGwLhIzkfM.HAPIvWFpMbTqoVxbfdBKGmEKjwMD - YsxbcPhFadiLTsrXgJZsDBsqORkF.HAPIvWFpMbTqoVxbfdBKGmEKjwMD;
			CFLDKARPsQCFXiUPJNIIHuujClU.KnZRfKkpbOxfzlgtcOSnwIcFvoU = DivQmaVXvUrDaTTafeGwLhIzkfM.KnZRfKkpbOxfzlgtcOSnwIcFvoU - YsxbcPhFadiLTsrXgJZsDBsqORkF.KnZRfKkpbOxfzlgtcOSnwIcFvoU;
			CFLDKARPsQCFXiUPJNIIHuujClU.sgsDqvJTsHfsvOJsZeZXGduxWTE = DivQmaVXvUrDaTTafeGwLhIzkfM.sgsDqvJTsHfsvOJsZeZXGduxWTE - YsxbcPhFadiLTsrXgJZsDBsqORkF.sgsDqvJTsHfsvOJsZeZXGduxWTE;
			CFLDKARPsQCFXiUPJNIIHuujClU.BvlyDJjQGZkZVIWkSmDNcVOyJUe = DivQmaVXvUrDaTTafeGwLhIzkfM.BvlyDJjQGZkZVIWkSmDNcVOyJUe - YsxbcPhFadiLTsrXgJZsDBsqORkF.BvlyDJjQGZkZVIWkSmDNcVOyJUe;
			for (int m = 0; m < DivQmaVXvUrDaTTafeGwLhIzkfM.ZpABAkfHwHQDSOGXlKXhcmEydNqq.Length; m++)
			{
				CFLDKARPsQCFXiUPJNIIHuujClU.ZpABAkfHwHQDSOGXlKXhcmEydNqq[m] = DivQmaVXvUrDaTTafeGwLhIzkfM.ZpABAkfHwHQDSOGXlKXhcmEydNqq[m] - YsxbcPhFadiLTsrXgJZsDBsqORkF.ZpABAkfHwHQDSOGXlKXhcmEydNqq[m];
			}
			CFLDKARPsQCFXiUPJNIIHuujClU.PMYsmgFkMdlUJldlnEfzdjaaJf = DivQmaVXvUrDaTTafeGwLhIzkfM.PMYsmgFkMdlUJldlnEfzdjaaJf - YsxbcPhFadiLTsrXgJZsDBsqORkF.PMYsmgFkMdlUJldlnEfzdjaaJf;
			CFLDKARPsQCFXiUPJNIIHuujClU.XFtrQkrNkPBxJEKYzmoSMULzujeL = DivQmaVXvUrDaTTafeGwLhIzkfM.XFtrQkrNkPBxJEKYzmoSMULzujeL - YsxbcPhFadiLTsrXgJZsDBsqORkF.XFtrQkrNkPBxJEKYzmoSMULzujeL;
			CFLDKARPsQCFXiUPJNIIHuujClU.OtUGEwCUrYfgLqGOZPAfTOWdcAl = DivQmaVXvUrDaTTafeGwLhIzkfM.OtUGEwCUrYfgLqGOZPAfTOWdcAl - YsxbcPhFadiLTsrXgJZsDBsqORkF.OtUGEwCUrYfgLqGOZPAfTOWdcAl;
			CFLDKARPsQCFXiUPJNIIHuujClU.ZmviqYAaSckrJAJfoMAKzAMBigO = DivQmaVXvUrDaTTafeGwLhIzkfM.ZmviqYAaSckrJAJfoMAKzAMBigO - YsxbcPhFadiLTsrXgJZsDBsqORkF.ZmviqYAaSckrJAJfoMAKzAMBigO;
			CFLDKARPsQCFXiUPJNIIHuujClU.TNSVOyeEanHBtTbVhWsGwnpMCRE = DivQmaVXvUrDaTTafeGwLhIzkfM.TNSVOyeEanHBtTbVhWsGwnpMCRE - YsxbcPhFadiLTsrXgJZsDBsqORkF.TNSVOyeEanHBtTbVhWsGwnpMCRE;
			CFLDKARPsQCFXiUPJNIIHuujClU.enAbylCthhDBABwXbZWLOsvRNbHd = DivQmaVXvUrDaTTafeGwLhIzkfM.enAbylCthhDBABwXbZWLOsvRNbHd - YsxbcPhFadiLTsrXgJZsDBsqORkF.enAbylCthhDBABwXbZWLOsvRNbHd;
			for (int n = 0; n < DivQmaVXvUrDaTTafeGwLhIzkfM.JUFhaMDmUXULJISwjxqzazZysjK.Length; n++)
			{
				CFLDKARPsQCFXiUPJNIIHuujClU.JUFhaMDmUXULJISwjxqzazZysjK[n] = DivQmaVXvUrDaTTafeGwLhIzkfM.JUFhaMDmUXULJISwjxqzazZysjK[n] - YsxbcPhFadiLTsrXgJZsDBsqORkF.JUFhaMDmUXULJISwjxqzazZysjK[n];
			}
			dkKqhkkHKpsbTbCKIghRphYKxgi = VScoMnvpvJwUxENHXUBWQPHCZpy();
			if (dkKqhkkHKpsbTbCKIghRphYKxgi)
			{
				rmHEVkHMGIGqgsxivYXMqBAQGjSo = P_0;
				YsxbcPhFadiLTsrXgJZsDBsqORkF.TxqPmgQJJZQbZzjuubnQExXfSKBm(DivQmaVXvUrDaTTafeGwLhIzkfM);
			}
		}

		public void TxqPmgQJJZQbZzjuubnQExXfSKBm(IVeOhppWlSdYiYcuZJCbKpxhInf P_0)
		{
			uXdxcpWbDJEFJbQJYQsoRGfsqsU = P_0.uXdxcpWbDJEFJbQJYQsoRGfsqsU;
			YsxbcPhFadiLTsrXgJZsDBsqORkF.TxqPmgQJJZQbZzjuubnQExXfSKBm(P_0.YsxbcPhFadiLTsrXgJZsDBsqORkF);
			CFLDKARPsQCFXiUPJNIIHuujClU.TxqPmgQJJZQbZzjuubnQExXfSKBm(P_0.CFLDKARPsQCFXiUPJNIIHuujClU);
		}

		private bool VScoMnvpvJwUxENHXUBWQPHCZpy()
		{
			if (CFLDKARPsQCFXiUPJNIIHuujClU.RTwQzyWgdmiDfVtyeEaNgdMceZg != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.TCogMmKASgopRYQJTNMtdAvdwtIe != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.EdlzUaIOdCOXEXPAWyQWBASofyY != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.DQysbbdoHDPlpAeeBSiYmmjBYbz != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.GLbyWguVoSuyBGnJfbXziXCsHPO != 0)
			{
				return true;
			}
			for (int i = 0; i < DivQmaVXvUrDaTTafeGwLhIzkfM.gljkmoyOBJrGQUmNqDaQBfHacODV.Length; i++)
			{
				if (CFLDKARPsQCFXiUPJNIIHuujClU.gljkmoyOBJrGQUmNqDaQBfHacODV[i] != 0)
				{
					return true;
				}
			}
			for (int j = 0; j < DivQmaVXvUrDaTTafeGwLhIzkfM.mSeXMQpIolvHxXuiVLsSKBhIhGfH.Length; j++)
			{
				if (CFLDKARPsQCFXiUPJNIIHuujClU.mSeXMQpIolvHxXuiVLsSKBhIhGfH[j] != 0)
				{
					return true;
				}
			}
			for (int k = 0; k < DivQmaVXvUrDaTTafeGwLhIzkfM.OZXCbzyfeJVptcfXueOFPpFxErd.Length; k++)
			{
				if (CFLDKARPsQCFXiUPJNIIHuujClU.OZXCbzyfeJVptcfXueOFPpFxErd[k])
				{
					return true;
				}
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.yqcjjMQvejIokWKMBapsKKiozwT != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.djKPQOAWngqnVpncpdtoeNFWLdhr != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.SiTAMlPnuqbVwhxyevgmJzerzzWq != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.oEHOYUnthFiMDrqwXfCuEDgFALxX != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.ACneJuXoJhfqxfOCtjZajhvCKdIg != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.rwZlWhqrMonenQBoRuRggMEBTaR != 0)
			{
				return true;
			}
			for (int l = 0; l < DivQmaVXvUrDaTTafeGwLhIzkfM.FOhAAOAzmohUPgzASmfrbUHqKSxw.Length; l++)
			{
				if (CFLDKARPsQCFXiUPJNIIHuujClU.FOhAAOAzmohUPgzASmfrbUHqKSxw[l] != 0)
				{
					return true;
				}
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.QtGVhGCdczHTabxrZzdRPrCmcFIk != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.maBbJvUkRsqitIlgaKjqrgDXgJh != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.HAPIvWFpMbTqoVxbfdBKGmEKjwMD != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.KnZRfKkpbOxfzlgtcOSnwIcFvoU != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.sgsDqvJTsHfsvOJsZeZXGduxWTE != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.BvlyDJjQGZkZVIWkSmDNcVOyJUe != 0)
			{
				return true;
			}
			for (int m = 0; m < DivQmaVXvUrDaTTafeGwLhIzkfM.ZpABAkfHwHQDSOGXlKXhcmEydNqq.Length; m++)
			{
				CFLDKARPsQCFXiUPJNIIHuujClU.ZpABAkfHwHQDSOGXlKXhcmEydNqq[m] = DivQmaVXvUrDaTTafeGwLhIzkfM.ZpABAkfHwHQDSOGXlKXhcmEydNqq[m] - YsxbcPhFadiLTsrXgJZsDBsqORkF.ZpABAkfHwHQDSOGXlKXhcmEydNqq[m];
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.PMYsmgFkMdlUJldlnEfzdjaaJf != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.XFtrQkrNkPBxJEKYzmoSMULzujeL != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.OtUGEwCUrYfgLqGOZPAfTOWdcAl != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.ZmviqYAaSckrJAJfoMAKzAMBigO != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.TNSVOyeEanHBtTbVhWsGwnpMCRE != 0)
			{
				return true;
			}
			if (CFLDKARPsQCFXiUPJNIIHuujClU.enAbylCthhDBABwXbZWLOsvRNbHd != 0)
			{
				return true;
			}
			for (int n = 0; n < DivQmaVXvUrDaTTafeGwLhIzkfM.JUFhaMDmUXULJISwjxqzazZysjK.Length; n++)
			{
				if (CFLDKARPsQCFXiUPJNIIHuujClU.JUFhaMDmUXULJISwjxqzazZysjK[n] != 0)
				{
					return true;
				}
			}
			return false;
		}
	}

	private class uonSwcgPfxmIYNLROxDhFiNofDV
	{
		public enum KgmfMkkkUAKJbblFaOlBgxZfZWLy
		{
			vwOfhEYipyOtQiesBaMULwuTJjR = 0,
			PxAZUthBoqKstLGGPnsAsvkTrpD = 1
		}

		public class SiYcHroIfhDCENoEPjbNiPNvxlSV
		{
			public int OyDnkOlVbHfuMnCTJaxdfguHXtY;

			public Guid UInlkenejuBpngBMzEcVuFHmxAw;

			public Guid KBeSAIfQuakWhKYXrKovLYpHcGg;

			public int WUtWdnEkcbOowTZyNYSAYqiqIsk;

			public int rdAiJgjkWhiEydzQBaCRfzCVRNHM;

			public int sTzXfOyWCNXZCDYOkqgPDWeTHnP;

			public int HtrgaJBhAduArjOzMjluWSwCPBqi;

			public bool QdqhDkpVZKgyndwhadmFgJdPnvx(iHkeJQxMhCacNXSKKcHkJmGQjzU P_0, KgmfMkkkUAKJbblFaOlBgxZfZWLy P_1)
			{
				if (P_0.rewiredId == OyDnkOlVbHfuMnCTJaxdfguHXtY)
				{
					return true;
				}
				if (rdAiJgjkWhiEydzQBaCRfzCVRNHM != P_0.rdAiJgjkWhiEydzQBaCRfzCVRNHM)
				{
					return false;
				}
				if (sTzXfOyWCNXZCDYOkqgPDWeTHnP != P_0.sTzXfOyWCNXZCDYOkqgPDWeTHnP)
				{
					return false;
				}
				if (HtrgaJBhAduArjOzMjluWSwCPBqi != P_0.HtrgaJBhAduArjOzMjluWSwCPBqi)
				{
					return false;
				}
				return P_1 switch
				{
					KgmfMkkkUAKJbblFaOlBgxZfZWLy.vwOfhEYipyOtQiesBaMULwuTJjR => UInlkenejuBpngBMzEcVuFHmxAw == P_0.instanceGuid, 
					KgmfMkkkUAKJbblFaOlBgxZfZWLy.PxAZUthBoqKstLGGPnsAsvkTrpD => KBeSAIfQuakWhKYXrKovLYpHcGg == P_0.KBeSAIfQuakWhKYXrKovLYpHcGg, 
					_ => throw new NotImplementedException(), 
				};
			}

			public override string ToString()
			{
				string text = "";
				object obj = text;
				text = string.Concat(obj, "rewiredId = ", OyDnkOlVbHfuMnCTJaxdfguHXtY, "\n");
				object obj2 = text;
				text = string.Concat(obj2, "instanceGuid = ", UInlkenejuBpngBMzEcVuFHmxAw, "\n");
				object obj3 = text;
				text = string.Concat(obj3, "typeIdentifierGuid = ", KBeSAIfQuakWhKYXrKovLYpHcGg, "\n");
				object obj4 = text;
				text = string.Concat(obj4, "lastInputManagerId = ", WUtWdnEkcbOowTZyNYSAYqiqIsk, "\n");
				object obj5 = text;
				text = string.Concat(obj5, "hardwareAxisCount = ", rdAiJgjkWhiEydzQBaCRfzCVRNHM, "\n");
				object obj6 = text;
				text = string.Concat(obj6, "hardwareButtonCount = ", sTzXfOyWCNXZCDYOkqgPDWeTHnP, "\n");
				object obj7 = text;
				return string.Concat(obj7, "hardwareHatCount = ", HtrgaJBhAduArjOzMjluWSwCPBqi, "\n");
			}
		}

		private List<SiYcHroIfhDCENoEPjbNiPNvxlSV> hMhaWfYUetzpHHbonWijivkdKiW;

		public uonSwcgPfxmIYNLROxDhFiNofDV()
		{
			hMhaWfYUetzpHHbonWijivkdKiW = new List<SiYcHroIfhDCENoEPjbNiPNvxlSV>();
		}

		public void tJzVKzbFmLbtbkPtOJIPqoQXsJj(iHkeJQxMhCacNXSKKcHkJmGQjzU P_0)
		{
			if (P_0 == null)
			{
				return;
			}
			int count = hMhaWfYUetzpHHbonWijivkdKiW.Count;
			for (int i = 0; i < count; i++)
			{
				if (hMhaWfYUetzpHHbonWijivkdKiW[i].QdqhDkpVZKgyndwhadmFgJdPnvx(P_0, KgmfMkkkUAKJbblFaOlBgxZfZWLy.vwOfhEYipyOtQiesBaMULwuTJjR))
				{
					hMhaWfYUetzpHHbonWijivkdKiW[i].OyDnkOlVbHfuMnCTJaxdfguHXtY = P_0.rewiredId;
					hMhaWfYUetzpHHbonWijivkdKiW[i].UInlkenejuBpngBMzEcVuFHmxAw = P_0.instanceGuid;
					hMhaWfYUetzpHHbonWijivkdKiW[i].KBeSAIfQuakWhKYXrKovLYpHcGg = P_0.KBeSAIfQuakWhKYXrKovLYpHcGg;
					hMhaWfYUetzpHHbonWijivkdKiW[i].WUtWdnEkcbOowTZyNYSAYqiqIsk = P_0.inputManagerId;
					hMhaWfYUetzpHHbonWijivkdKiW[i].rdAiJgjkWhiEydzQBaCRfzCVRNHM = P_0.rdAiJgjkWhiEydzQBaCRfzCVRNHM;
					hMhaWfYUetzpHHbonWijivkdKiW[i].sTzXfOyWCNXZCDYOkqgPDWeTHnP = P_0.sTzXfOyWCNXZCDYOkqgPDWeTHnP;
					hMhaWfYUetzpHHbonWijivkdKiW[i].HtrgaJBhAduArjOzMjluWSwCPBqi = P_0.HtrgaJBhAduArjOzMjluWSwCPBqi;
					PBzEvOTDzimlgqgULUtqaLYjbAF(P_0.rewiredId, P_0.instanceGuid, i);
					return;
				}
			}
			hMhaWfYUetzpHHbonWijivkdKiW.Add(new SiYcHroIfhDCENoEPjbNiPNvxlSV
			{
				OyDnkOlVbHfuMnCTJaxdfguHXtY = P_0.rewiredId,
				UInlkenejuBpngBMzEcVuFHmxAw = P_0.instanceGuid,
				KBeSAIfQuakWhKYXrKovLYpHcGg = P_0.KBeSAIfQuakWhKYXrKovLYpHcGg,
				WUtWdnEkcbOowTZyNYSAYqiqIsk = P_0.inputManagerId,
				rdAiJgjkWhiEydzQBaCRfzCVRNHM = P_0.rdAiJgjkWhiEydzQBaCRfzCVRNHM,
				sTzXfOyWCNXZCDYOkqgPDWeTHnP = P_0.sTzXfOyWCNXZCDYOkqgPDWeTHnP,
				HtrgaJBhAduArjOzMjluWSwCPBqi = P_0.HtrgaJBhAduArjOzMjluWSwCPBqi
			});
			PBzEvOTDzimlgqgULUtqaLYjbAF(P_0.rewiredId, P_0.instanceGuid, hMhaWfYUetzpHHbonWijivkdKiW.Count - 1);
		}

		public bool GhknXgQlkVQpCeAlkfPWNFpELSm(iHkeJQxMhCacNXSKKcHkJmGQjzU P_0, KgmfMkkkUAKJbblFaOlBgxZfZWLy P_1)
		{
			int count = hMhaWfYUetzpHHbonWijivkdKiW.Count;
			for (int i = 0; i < count; i++)
			{
				if (hMhaWfYUetzpHHbonWijivkdKiW[i].QdqhDkpVZKgyndwhadmFgJdPnvx(P_0, P_1))
				{
					return true;
				}
			}
			return false;
		}

		public IEnumerable<SiYcHroIfhDCENoEPjbNiPNvxlSV> kVbYiwIwEyRBOVIjRkdFFmyOTNz(iHkeJQxMhCacNXSKKcHkJmGQjzU P_0, KgmfMkkkUAKJbblFaOlBgxZfZWLy P_1)
		{
			int count = hMhaWfYUetzpHHbonWijivkdKiW.Count;
			for (int i = 0; i < count; i++)
			{
				if (hMhaWfYUetzpHHbonWijivkdKiW[i].QdqhDkpVZKgyndwhadmFgJdPnvx(P_0, P_1))
				{
					yield return hMhaWfYUetzpHHbonWijivkdKiW[i];
				}
			}
		}

		private void PBzEvOTDzimlgqgULUtqaLYjbAF(int P_0, Guid P_1, int P_2)
		{
			for (int num = hMhaWfYUetzpHHbonWijivkdKiW.Count - 1; num >= 0; num--)
			{
				if (num != P_2 && (hMhaWfYUetzpHHbonWijivkdKiW[num].OyDnkOlVbHfuMnCTJaxdfguHXtY == P_0 || hMhaWfYUetzpHHbonWijivkdKiW[num].UInlkenejuBpngBMzEcVuFHmxAw == P_1))
				{
					hMhaWfYUetzpHHbonWijivkdKiW.RemoveAt(num);
				}
			}
		}

		public override string ToString()
		{
			string text = "";
			object obj = text;
			text = string.Concat(obj, "Joystick records: ", hMhaWfYUetzpHHbonWijivkdKiW.Count, "\n");
			for (int i = 0; i < hMhaWfYUetzpHHbonWijivkdKiW.Count; i++)
			{
				object obj2 = text;
				text = string.Concat(obj2, "Record ", i, ":\n");
				text = text + hMhaWfYUetzpHHbonWijivkdKiW[i].ToString() + "\n\n";
			}
			return text;
		}
	}

	private class onuieZrnwJdPuFaILwstndpZItbr
	{
		public iHkeJQxMhCacNXSKKcHkJmGQjzU XpDCkyERZZKigIpRBBHbNOfnuRCB;

		public tvkecSTWbFlWcBbAxxdWaePZtgu qdKoEcPCccDwQFCtcjxhBBoBvWrh;

		public bool jYuOzlJtihpWwRTDsuTZYrbfQmE
		{
			get
			{
				if (XpDCkyERZZKigIpRBBHbNOfnuRCB != null)
				{
					return qdKoEcPCccDwQFCtcjxhBBoBvWrh != null;
				}
				return false;
			}
		}

		public onuieZrnwJdPuFaILwstndpZItbr(iHkeJQxMhCacNXSKKcHkJmGQjzU joystick, tvkecSTWbFlWcBbAxxdWaePZtgu deviceInstance)
		{
			XpDCkyERZZKigIpRBBHbNOfnuRCB = joystick;
			qdKoEcPCccDwQFCtcjxhBBoBvWrh = deviceInstance;
		}

		public static List<tvkecSTWbFlWcBbAxxdWaePZtgu> QZaecYFxROpVRlKLvHDqTilibpc(List<onuieZrnwJdPuFaILwstndpZItbr> P_0)
		{
			if (P_0 == null)
			{
				return new List<tvkecSTWbFlWcBbAxxdWaePZtgu>();
			}
			List<tvkecSTWbFlWcBbAxxdWaePZtgu> list = new List<tvkecSTWbFlWcBbAxxdWaePZtgu>();
			for (int i = 0; i < P_0.Count; i++)
			{
				if (P_0[i].jYuOzlJtihpWwRTDsuTZYrbfQmE)
				{
					list.Add(P_0[i].qdKoEcPCccDwQFCtcjxhBBoBvWrh);
				}
			}
			return list;
		}
	}

	private class kRZEChjzzblMipIltGoaAyUxnRXC
	{
		public nFospmxJfsUfwGENuIBuWbrCFAW qpcbiSDahljIgZEQqDgbyuVdvfyu;

		public kRZEChjzzblMipIltGoaAyUxnRXC(nFospmxJfsUfwGENuIBuWbrCFAW sdxJoystick)
		{
			qpcbiSDahljIgZEQqDgbyuVdvfyu = sdxJoystick;
		}
	}

	private class rfJBUEGxaZspdFEbLSxZScjJtq
	{
		private KSJklejSjRczvdDJaPlpSMisXAa.iTrlYJNPRfnlwJwFcpcVFCxGDEXg cwQDArCIAdIQkxOBSmgcGUsrMOgb;

		private KSJklejSjRczvdDJaPlpSMisXAa.lhOweqQgeBVkcNxcZbiefsqHevf eItGFrRgSQewBFoXogRXIqBiPLj;

		private NativeBuffer EoayvFUYcBUgtNEgiIcGVtiHzTi;

		private int DhdSRdNeymCjOfOgeUmQvZSVJNRI;

		public rfJBUEGxaZspdFEbLSxZScjJtq()
		{
			cwQDArCIAdIQkxOBSmgcGUsrMOgb = new KSJklejSjRczvdDJaPlpSMisXAa.iTrlYJNPRfnlwJwFcpcVFCxGDEXg
			{
				GXzXGWNfOQnVvTtRWSNdFASkppo = (uint)Marshal.SizeOf(typeof(KSJklejSjRczvdDJaPlpSMisXAa.iTrlYJNPRfnlwJwFcpcVFCxGDEXg)),
				IcxGLIhklvvQoQoKtcxmqoxhEvH = true,
				FVqwYyxrNVVUbagbnQWHlJyOsDE = true,
				xbuBMFhCNKPugQlemHgtkfBRtHR = false,
				CQkXEYtAhbFaYkOrUjlkkyHixADj = true,
				mCUytGiDxNfcZnpWicXGXgSVmos = IntPtr.Zero
			};
			eItGFrRgSQewBFoXogRXIqBiPLj = KSJklejSjRczvdDJaPlpSMisXAa.lhOweqQgeBVkcNxcZbiefsqHevf.AaITSTYmsSMRgQyjrgwNkXeIpsO();
			EoayvFUYcBUgtNEgiIcGVtiHzTi = new NativeBuffer((int)eItGFrRgSQewBFoXogRXIqBiPLj.GXzXGWNfOQnVvTtRWSNdFASkppo);
			EoayvFUYcBUgtNEgiIcGVtiHzTi.Write(eItGFrRgSQewBFoXogRXIqBiPLj.GXzXGWNfOQnVvTtRWSNdFASkppo, 0);
		}

		public bool SJCEFxQKNhAmDSKHBzlKlLkhcdd()
		{
			int num = KjOsSxzgXFWQPYaiNMWEMOdmLAE();
			if (num == DhdSRdNeymCjOfOgeUmQvZSVJNRI)
			{
				return false;
			}
			DhdSRdNeymCjOfOgeUmQvZSVJNRI = num;
			return true;
		}

		public void cJSEGWLQeyYABGUxAEOgwNxHFnS(int P_0)
		{
			DhdSRdNeymCjOfOgeUmQvZSVJNRI = P_0;
		}

		private int KjOsSxzgXFWQPYaiNMWEMOdmLAE()
		{
			try
			{
				return sYwCgmJInQorTFIIBkpIONhajGKy.VFEohVGjpKoiHHXQrfHvEoqRdGz(ref cwQDArCIAdIQkxOBSmgcGUsrMOgb, EoayvFUYcBUgtNEgiIcGVtiHzTi);
			}
			catch
			{
				return 0;
			}
		}
	}

	private enum oePPRnxqcVcTAqByosGoUzBKaEw
	{
		VhBTBMdAFpqaWuODnxKAnlMulqD = 17,
		QxDaIeQFcOJvuQfaIwlsuKcvYjM = 18,
		hOKSQsVFahbyPnFtHtuTEPcoMO = 19,
		etZBciYCDzeATdbPMkiCAYwMQZPf = 20,
		pXUvLMZdfUPPpSKQFIjTzaejHeu = 21,
		rqXrqgDfQPNUBjLmvaIgkGoQqjD = 22,
		JwAGBjbYdnvwcIoDlmUzAzcFAfv = 23,
		rXJVtbbhBUDYjkHcxaxVGgEqvUE = 24,
		MuvaMXFnYbxYkEUMrHQjxZSDwYb = 25,
		kNuiGlKzIJmYrSeymxAPPqmAgWa = 26,
		HLiouYFxIgJNouYqukosLLYTBEW = 27,
		eCsumuiyXhRfPuOXAvWoFgtJMyr = 28
	}

	private const FnrirBBrCqEzZffWHJpycBFJwosJ pFQAhPmLWHRaTLMgCWgynTxalCU = FnrirBBrCqEzZffWHJpycBFJwosJ.UvaLcJUctvCPobYgXUuBtTtpeXVB;

	private const nnLcxzlMtvpnesQPBfJOcQhMmpL iBYHulQerRtiIZpBofNmQvYOfcqb = nnLcxzlMtvpnesQPBfJOcQhMmpL.sdvQKHtDvxdfLARkaCRCfLfJDKDa;

	private IntPtr cydNPfNgnIKkNtZVdrByOJGWCUKA;

	private cLFlnHVsQfZirmsvltfLdtHKFo dPWcuMTmvbDZbtxvGfKdatZLIbG;

	private List<iHkeJQxMhCacNXSKKcHkJmGQjzU> MYIilGlzGtMSBPimluqBFDXADRJ;

	private int loHxsPzTnMgHxGoyDcWpTtzNQnO;

	private uonSwcgPfxmIYNLROxDhFiNofDV FATxLzcXldiDnUItlRTPAJuORDM;

	private bool ZaHdIQkaIKVVZtdbtetCjNuMBLP;

	private bool uGlRgnZIMzNMfAWVtsRmeydggPR;

	private UpdateLoopSetting TBvNogFQjrCLriqFrIjEYbpsDeSi;

	private Action<int, ControllerDataUpdater> UnhEVuhJFUEnfAsRXUSCacwcngnY;

	private PlatformInputManager GRPphNqBvejBLpdEjHfuUeLKHeo;

	private TimerRealTime XGUEehzhVvcIeAdTFNVkrDxzoqm;

	private global::PraFXApEzKrfLjKmeJGBIrwNdsGd<bool> TxOuahQkabUPnBodDAuqevjMgpfG;

	private rfJBUEGxaZspdFEbLSxZScjJtq sGlMksWVosYepTKljgGwvNbkLQx;

	private int KCWyiDDIRaBxrGgXuSyLlYxXAUMH;

	private int EabZgzogacUapwLsUHFGCzwKdcC;

	private global::PraFXApEzKrfLjKmeJGBIrwNdsGd<List<onuieZrnwJdPuFaILwstndpZItbr>> kcoiUACBncevuyrKJkLfepispgtW;

	private readonly object QnjPDsavPpORFdRFTiPBJdcwCnOc = new object();

	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> rpvCjQaePXpGswKHxhwfamxRDIu;

	private Func<int> ilAOFbKaMpyqndLrycyBBEQAMvEC;

	public bool fusuChFAnsQfBhWSvPtKWcjxdPNa
	{
		set
		{
			uGlRgnZIMzNMfAWVtsRmeydggPR = value;
		}
	}

	[CustomObfuscation(rename = false)]
	public override int deviceCount => loHxsPzTnMgHxGoyDcWpTtzNQnO;

	[CustomObfuscation(rename = false)]
	public override PlatformInputManager primaryInputManager => GRPphNqBvejBLpdEjHfuUeLKHeo;

	[CustomObfuscation(rename = false)]
	public override IInputSource inputSource => new InputSourceWrapper<cLFlnHVsQfZirmsvltfLdtHKFo>(dPWcuMTmvbDZbtxvGfKdatZLIbG);

	[CustomObfuscation(rename = false)]
	public override InputSource inputSourceType => InputSource.DirectInput;

	public lRfdZjIakBhyrwaGkefekSyEiXO(UpdateLoopSetting updateLoopSetting, bool useXInput, IntPtr windowHandle, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId)
	{
		try
		{
			TBvNogFQjrCLriqFrIjEYbpsDeSi = updateLoopSetting;
			uGlRgnZIMzNMfAWVtsRmeydggPR = useXInput;
			cydNPfNgnIKkNtZVdrByOJGWCUKA = windowHandle;
			rpvCjQaePXpGswKHxhwfamxRDIu = getHardwareJoystickMap_InputManager;
			ilAOFbKaMpyqndLrycyBBEQAMvEC = getNewJoystickId;
			GRPphNqBvejBLpdEjHfuUeLKHeo = this;
			dPWcuMTmvbDZbtxvGfKdatZLIbG = new cLFlnHVsQfZirmsvltfLdtHKFo();
			UnhEVuhJFUEnfAsRXUSCacwcngnY = UpdateControllerData;
			sGlMksWVosYepTKljgGwvNbkLQx = new rfJBUEGxaZspdFEbLSxZScjJtq();
			TxOuahQkabUPnBodDAuqevjMgpfG = new global::PraFXApEzKrfLjKmeJGBIrwNdsGd<bool>(useSharedThread: true, TEeCuhCMvpStgApRIpJvtadkDBup);
			kcoiUACBncevuyrKJkLfepispgtW = new global::PraFXApEzKrfLjKmeJGBIrwNdsGd<List<onuieZrnwJdPuFaILwstndpZItbr>>(useSharedThread: true, () => gMJwbhLuwAVxzBgKqqrgedHDSxj());
			tLqFENxHjSOacCzfowrjxfjBHb();
		}
		catch (Exception)
		{
			OnDestroy();
			throw;
		}
	}

	[CustomObfuscation(rename = false)]
	public override void Initialize()
	{
		FATxLzcXldiDnUItlRTPAJuORDM = new uonSwcgPfxmIYNLROxDhFiNofDV();
		XGUEehzhVvcIeAdTFNVkrDxzoqm = new TimerRealTime(1.0);
		XGUEehzhVvcIeAdTFNVkrDxzoqm.Start();
		gFyyAgSdwIcYivMuZYwqFenSwJE();
	}

	[CustomObfuscation(rename = false)]
	public override void Update(UpdateLoopType updateLoop)
	{
		AKsHxPSabRvnbiwYkULztlwxyno();
		bcRjnCjxDyUMfEPooNQtVhZjlFn();
		zmiSfwPHwVrmRSdAAPoYwaeqKjX();
	}

	[CustomObfuscation(rename = false)]
	public override void OnDestroy()
	{
		if (kcoiUACBncevuyrKJkLfepispgtW != null)
		{
			kcoiUACBncevuyrKJkLfepispgtW.PMzamCeIIFqnzgwGlxEbIeTHBFUL();
		}
		if (TxOuahQkabUPnBodDAuqevjMgpfG != null)
		{
			TxOuahQkabUPnBodDAuqevjMgpfG.PMzamCeIIFqnzgwGlxEbIeTHBFUL();
		}
		if (MYIilGlzGtMSBPimluqBFDXADRJ == null)
		{
			return;
		}
		lock (QnjPDsavPpORFdRFTiPBJdcwCnOc)
		{
			for (int i = 0; i < MYIilGlzGtMSBPimluqBFDXADRJ.Count; i++)
			{
				if (MYIilGlzGtMSBPimluqBFDXADRJ[i] != null)
				{
					MYIilGlzGtMSBPimluqBFDXADRJ[i].PiVpHzafoUMfSDFNLmfkEJnjpdO();
					MYIilGlzGtMSBPimluqBFDXADRJ[i].PMzamCeIIFqnzgwGlxEbIeTHBFUL();
				}
			}
		}
	}

	[CustomObfuscation(rename = false)]
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate()
	{
		return UnhEVuhJFUEnfAsRXUSCacwcngnY;
	}

	[CustomObfuscation(rename = false)]
	public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data)
	{
		lock (QnjPDsavPpORFdRFTiPBJdcwCnOc)
		{
			for (int i = 0; i < loHxsPzTnMgHxGoyDcWpTtzNQnO; i++)
			{
				if (MYIilGlzGtMSBPimluqBFDXADRJ[i].inputManagerId == inputManagerId)
				{
					MYIilGlzGtMSBPimluqBFDXADRJ[i].FillData(data);
					return;
				}
			}
		}
		Logger.LogError("Invalid joystick Id " + inputManagerId + "!");
	}

	[CustomObfuscation(rename = false)]
	public override void SystemDeviceConnected()
	{
		ZaHdIQkaIKVVZtdbtetCjNuMBLP = true;
		XGUEehzhVvcIeAdTFNVkrDxzoqm.Start();
		if (_SystemDeviceConnectedEvent != null)
		{
			_SystemDeviceConnectedEvent();
		}
	}

	[CustomObfuscation(rename = false)]
	public override void SystemDeviceDisconnected()
	{
		ZaHdIQkaIKVVZtdbtetCjNuMBLP = true;
		XGUEehzhVvcIeAdTFNVkrDxzoqm.Start();
		if (_SystemDeviceDisconnectedEvent != null)
		{
			_SystemDeviceDisconnectedEvent();
		}
	}

	[CustomObfuscation(rename = false)]
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId)
	{
	}

	[CustomObfuscation(rename = false)]
	public override IUnifiedMouseSource GetUnifiedMouseSource()
	{
		return null;
	}

	[CustomObfuscation(rename = false)]
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource()
	{
		return null;
	}

	private void AKsHxPSabRvnbiwYkULztlwxyno()
	{
		if (TxOuahQkabUPnBodDAuqevjMgpfG.bgLAKkuspNIyPudbNgPBgmqQVpJG)
		{
			if (TxOuahQkabUPnBodDAuqevjMgpfG.bXUJACnaYvOCANYOaVrTdSwcZxj() && !XGUEehzhVvcIeAdTFNVkrDxzoqm.running && !kcoiUACBncevuyrKJkLfepispgtW.bgLAKkuspNIyPudbNgPBgmqQVpJG)
			{
				if (TxOuahQkabUPnBodDAuqevjMgpfG.GWOwgIzmyVWsoVjleBNCERdBoQa)
				{
					ZaHdIQkaIKVVZtdbtetCjNuMBLP = true;
				}
				XGUEehzhVvcIeAdTFNVkrDxzoqm.Start();
			}
		}
		else if (!XGUEehzhVvcIeAdTFNVkrDxzoqm.running)
		{
			XGUEehzhVvcIeAdTFNVkrDxzoqm.Start();
		}
		else if (XGUEehzhVvcIeAdTFNVkrDxzoqm.Update())
		{
			TxOuahQkabUPnBodDAuqevjMgpfG.UBdDYFzJEaQOUTjUSMwjsblQggo();
		}
	}

	private List<onuieZrnwJdPuFaILwstndpZItbr> gMJwbhLuwAVxzBgKqqrgedHDSxj()
	{
		List<onuieZrnwJdPuFaILwstndpZItbr> list = new List<onuieZrnwJdPuFaILwstndpZItbr>();
		IList<tvkecSTWbFlWcBbAxxdWaePZtgu> list2 = zZqzMfnBahJRFLfDOwATkEMpuRK();
		int count = list2.Count;
		for (int i = 0; i < count; i++)
		{
			if (list2[i] == null)
			{
				continue;
			}
			try
			{
				tvkecSTWbFlWcBbAxxdWaePZtgu tvkecSTWbFlWcBbAxxdWaePZtgu2 = list2[i];
				Guid mXqEWIlGwHZPoKjhftGIspoptJq = tvkecSTWbFlWcBbAxxdWaePZtgu2.mXqEWIlGwHZPoKjhftGIspoptJq;
				nFospmxJfsUfwGENuIBuWbrCFAW nFospmxJfsUfwGENuIBuWbrCFAW2 = new nFospmxJfsUfwGENuIBuWbrCFAW(dPWcuMTmvbDZbtxvGfKdatZLIbG, mXqEWIlGwHZPoKjhftGIspoptJq);
				WfZgeuwdpOLattzRedXaTAeNEgnk properties = nFospmxJfsUfwGENuIBuWbrCFAW2.wNCzQbNQwDjnYqTfSqzTkofPJPa;
				bool flag = false;
				if (!uGlRgnZIMzNMfAWVtsRmeydggPR)
				{
					goto IL_008b;
				}
				flag = gNZLZmnOEqwqMNKfeNUJNfMypUC.NeDbvgznpqCICmoNVeTAmiXHgNF(properties.QlBuWbUNosVJBneanCFGUjsGpjK, StringTools.SanitizeDeviceString(tvkecSTWbFlWcBbAxxdWaePZtgu2.OrRFBEhjniNFYjbjMjbVqBtWjOHD), string.Empty, tvkecSTWbFlWcBbAxxdWaePZtgu2.dtMtLyAEDljqqsSOiaBeXhtoXUH);
				if (!flag)
				{
					goto IL_008b;
				}
				goto end_IL_0027;
				IL_008b:
				Guid guid = ((!string.IsNullOrEmpty(properties.QlBuWbUNosVJBneanCFGUjsGpjK)) ? MiscTools.CreateGuidHashSHA256(properties.QlBuWbUNosVJBneanCFGUjsGpjK) : tvkecSTWbFlWcBbAxxdWaePZtgu2.mXqEWIlGwHZPoKjhftGIspoptJq);
				bool flag2 = false;
				lock (QnjPDsavPpORFdRFTiPBJdcwCnOc)
				{
					if (MYIilGlzGtMSBPimluqBFDXADRJ != null)
					{
						for (int j = 0; j < MYIilGlzGtMSBPimluqBFDXADRJ.Count; j++)
						{
							if (MYIilGlzGtMSBPimluqBFDXADRJ[j] != null && MYIilGlzGtMSBPimluqBFDXADRJ[j].kmlrVkJoHAiVknTEjxTfehHxMGP == guid)
							{
								nFospmxJfsUfwGENuIBuWbrCFAW2 = MYIilGlzGtMSBPimluqBFDXADRJ[j].qFTTgjZPRmbnvqCBGdmEDbfSPiSE.MunZepaFKdYsUldLUBVBfpSOkuHK;
								flag2 = true;
								break;
							}
						}
					}
				}
				iHkeJQxMhCacNXSKKcHkJmGQjzU iHkeJQxMhCacNXSKKcHkJmGQjzU = new iHkeJQxMhCacNXSKKcHkJmGQjzU(new apubADxSfJorcFkbCCCEczQVHYF(nFospmxJfsUfwGENuIBuWbrCFAW2, TBvNogFQjrCLriqFrIjEYbpsDeSi), rpvCjQaePXpGswKHxhwfamxRDIu);
				iHkeJQxMhCacNXSKKcHkJmGQjzU.qdKoEcPCccDwQFCtcjxhBBoBvWrh = tvkecSTWbFlWcBbAxxdWaePZtgu2;
				iHkeJQxMhCacNXSKKcHkJmGQjzU.awueIOZppSsgBYIKhhnLggaAZAn = tvkecSTWbFlWcBbAxxdWaePZtgu2.UwIbNTcAlfOtWfQjRIkicVlrPGFC;
				iHkeJQxMhCacNXSKKcHkJmGQjzU.kmlrVkJoHAiVknTEjxTfehHxMGP = guid;
				iHkeJQxMhCacNXSKKcHkJmGQjzU.UjlLMcJBUCEjQCPTUCFwbFmHYQxE = StringTools.SanitizeDeviceString(tvkecSTWbFlWcBbAxxdWaePZtgu2.OrRFBEhjniNFYjbjMjbVqBtWjOHD);
				iHkeJQxMhCacNXSKKcHkJmGQjzU.enrHFMRQgCWUTcGBWcZaPNsNxwT = tvkecSTWbFlWcBbAxxdWaePZtgu2.dtMtLyAEDljqqsSOiaBeXhtoXUH;
				iHkeJQxMhCacNXSKKcHkJmGQjzU.qtuqOkhNAVUcfxFZgMaXjkkJIIlB = (oePPRnxqcVcTAqByosGoUzBKaEw)tvkecSTWbFlWcBbAxxdWaePZtgu2.HmQyuofUsvomGjtCuiqveOpNWlh;
				pBkAQiGddckZaAhAOQIfQjJTGSF capabilities = nFospmxJfsUfwGENuIBuWbrCFAW2.INkPMrgmFQHrPoFjcDSDiHJFEiNM;
				iHkeJQxMhCacNXSKKcHkJmGQjzU.nWFtSCRFEzwWJAlKCuDmeqSLzvS = properties.LLWNXygzETOTnJQyBltZKpktGJs;
				iHkeJQxMhCacNXSKKcHkJmGQjzU.ElGbwvcoyOUnEXwgQgFRFCxZUkkb = flag;
				try
				{
					iHkeJQxMhCacNXSKKcHkJmGQjzU.qNPHPpgvRQEdsxgBWqwsRIjHSq = properties.nyGmXtdUMFOjsJGtySPQenWHxwN;
				}
				catch (Exception)
				{
					iHkeJQxMhCacNXSKKcHkJmGQjzU.qNPHPpgvRQEdsxgBWqwsRIjHSq = 0;
				}
				iHkeJQxMhCacNXSKKcHkJmGQjzU.rdAiJgjkWhiEydzQBaCRfzCVRNHM = capabilities.bWlOTrKOqDwmrTVckOrGIxOXTbA;
				iHkeJQxMhCacNXSKKcHkJmGQjzU.sTzXfOyWCNXZCDYOkqgPDWeTHnP = capabilities.nhlHpZITRUjXvMxgnPukLkSwoEV;
				iHkeJQxMhCacNXSKKcHkJmGQjzU.HtrgaJBhAduArjOzMjluWSwCPBqi = capabilities.AfpHKsHHCTqDvPBVrkTydQaxZcPV;
				knwAJxJIwrGYgqjzCPmJzGNDnok(iHkeJQxMhCacNXSKKcHkJmGQjzU, properties, out iHkeJQxMhCacNXSKKcHkJmGQjzU.ezJUJpdVGuAyiRzzDPTNaIehacH);
				try
				{
					string productName;
					try
					{
						productName = properties.OrRFBEhjniNFYjbjMjbVqBtWjOHD;
					}
					catch
					{
						productName = iHkeJQxMhCacNXSKKcHkJmGQjzU.UjlLMcJBUCEjQCPTUCFwbFmHYQxE;
					}
					if (SpecialDevices.RequiresRelativeToAbsoluteAxisConversion((ushort)properties.XVuHkKcnbaTxiTZvxKQBLJaCehD, (ushort)properties.LLWNXygzETOTnJQyBltZKpktGJs, productName) && SpecialDevices.GetRelativeAxisRanges((ushort)properties.XVuHkKcnbaTxiTZvxKQBLJaCehD, (ushort)properties.LLWNXygzETOTnJQyBltZKpktGJs, productName, out var min, out var max, out var zero))
					{
						iHkeJQxMhCacNXSKKcHkJmGQjzU.qFTTgjZPRmbnvqCBGdmEDbfSPiSE.BhZZUjegEYgcTUtEfWQacLpJxqJ(min, max, zero, SpecialDevices.GetRelativeToAbsoluteAxisEventTimeout((ushort)properties.XVuHkKcnbaTxiTZvxKQBLJaCehD, (ushort)properties.LLWNXygzETOTnJQyBltZKpktGJs, productName));
					}
				}
				catch (Exception)
				{
				}
				if (!flag2)
				{
					IList<SXoDXAAkhtkcYIknHXlAohykBIm> list3 = nFospmxJfsUfwGENuIBuWbrCFAW2.VQQyXnfgrtOvBajtBJUBOKEMUgN();
					if (list3 != null)
					{
						for (int k = 0; k < list3.Count; k++)
						{
							if ((list3[k].ZQquZILPxTVWhnsQPGDNFGBEWHq.jMbdrySazXGxqBoUZJERaOtVVTv & aROXwdaxgbeVtmneibreFeVBHR.ZVxpXwigRIivluwlxUlCrgyvIVD) != 0)
							{
								nFospmxJfsUfwGENuIBuWbrCFAW2.wNCzQbNQwDjnYqTfSqzTkofPJPa.itttkpUpMreNpceEEMErAXCcMdEd = new XttynZfFZIAoxUqJaugDLvECWEU(-65535, 65535);
							}
						}
					}
					nFospmxJfsUfwGENuIBuWbrCFAW2.wNCzQbNQwDjnYqTfSqzTkofPJPa.FPZkucZMjISrUjpZxaBweRTSwyX = FHmRXHDSdVJjdggMJImezPRjoDp.IkKuBbQIWMFawdnyxatzErcJXkBf;
					nFospmxJfsUfwGENuIBuWbrCFAW2.pctdMLruoWbVzNtjVNcUfTTxHTH(cydNPfNgnIKkNtZVdrByOJGWCUKA, wSaokIVQxWukGPitetnJOuTAjEJ.FyPbqOeacnwdVUhbJHfBGFaYdME | wSaokIVQxWukGPitetnJOuTAjEJ.SOuHceqrcZELFxKsfOsNbCEgSd);
					nFospmxJfsUfwGENuIBuWbrCFAW2.OqhfOnkBvpKzLuKYYPKRUvpiUrOF();
				}
				list.Add(new onuieZrnwJdPuFaILwstndpZItbr(iHkeJQxMhCacNXSKKcHkJmGQjzU, tvkecSTWbFlWcBbAxxdWaePZtgu2));
				end_IL_0027:;
			}
			catch (Exception)
			{
			}
		}
		return list;
	}

	private void gFyyAgSdwIcYivMuZYwqFenSwJE()
	{
		LBRErFJZckbosgViZAxBsuCreoXk(gMJwbhLuwAVxzBgKqqrgedHDSxj());
	}

	private void LBRErFJZckbosgViZAxBsuCreoXk(List<onuieZrnwJdPuFaILwstndpZItbr> P_0)
	{
		List<iHkeJQxMhCacNXSKKcHkJmGQjzU> list = new List<iHkeJQxMhCacNXSKKcHkJmGQjzU>();
		KCWyiDDIRaBxrGgXuSyLlYxXAUMH = 0;
		int num = P_0?.Count ?? 0;
		for (int i = 0; i < num; i++)
		{
			if (P_0[i] == null || !P_0[i].jYuOzlJtihpWwRTDsuTZYrbfQmE)
			{
				continue;
			}
			try
			{
				iHkeJQxMhCacNXSKKcHkJmGQjzU xpDCkyERZZKigIpRBBHbNOfnuRCB = P_0[i].XpDCkyERZZKigIpRBBHbNOfnuRCB;
				xpDCkyERZZKigIpRBBHbNOfnuRCB.iZnBUcZPCYZUOuauoTTqYipxzmI();
				if (xpDCkyERZZKigIpRBBHbNOfnuRCB.ZQJxEMiMjNdHQmVWxDtDCRrFHpRh)
				{
					KCWyiDDIRaBxrGgXuSyLlYxXAUMH++;
				}
				list.Add(xpDCkyERZZKigIpRBBHbNOfnuRCB);
			}
			catch (Exception)
			{
			}
		}
		sGlMksWVosYepTKljgGwvNbkLQx.cJSEGWLQeyYABGUxAEOgwNxHFnS(KCWyiDDIRaBxrGgXuSyLlYxXAUMH);
		lock (QnjPDsavPpORFdRFTiPBJdcwCnOc)
		{
			List<iHkeJQxMhCacNXSKKcHkJmGQjzU> mYIilGlzGtMSBPimluqBFDXADRJ = MYIilGlzGtMSBPimluqBFDXADRJ;
			int num2 = loHxsPzTnMgHxGoyDcWpTtzNQnO;
			int count = list.Count;
			EeIuYvQhmSRZqiNcnKnGCxRWVku(num2, count, mYIilGlzGtMSBPimluqBFDXADRJ, list);
			for (int j = 0; j < count; j++)
			{
				if (_UpdateControllerInfoEvent != null)
				{
					_UpdateControllerInfoEvent(new UpdateControllerInfoEventArgs(list[j]));
				}
			}
			RPDdEqlBagdPQQsCXgjiZWIMRVB(mYIilGlzGtMSBPimluqBFDXADRJ, list, false);
			RPDdEqlBagdPQQsCXgjiZWIMRVB(list, mYIilGlzGtMSBPimluqBFDXADRJ, true);
			HsSGRYAQnHavnvQxDFeJjgyDfQMC(list, mYIilGlzGtMSBPimluqBFDXADRJ);
			MYIilGlzGtMSBPimluqBFDXADRJ = list;
			loHxsPzTnMgHxGoyDcWpTtzNQnO = list.Count;
		}
	}

	private void knwAJxJIwrGYgqjzCPmJzGNDnok(iHkeJQxMhCacNXSKKcHkJmGQjzU P_0, WfZgeuwdpOLattzRedXaTAeNEgnk P_1, out string P_2)
	{
		P_2 = string.Empty;
		if (P_0 == null || P_1 == null)
		{
			return;
		}
		string text = cmwBGCtbOdnPmdndepyeYPuXGzv.gjlkGeDluPtDgcBqsmPLwnmixfs(P_1.QlBuWbUNosVJBneanCFGUjsGpjK);
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		try
		{
			tJKAaDrvDYPmVdvOWTbYhAqgFPi tJKAaDrvDYPmVdvOWTbYhAqgFPi2 = sYwCgmJInQorTFIIBkpIONhajGKy.KXWlvxVPoglrUayGyPlGzgCbGgff(text.ToLower(CultureInfo.InvariantCulture));
			if (tJKAaDrvDYPmVdvOWTbYhAqgFPi2 != null)
			{
				P_0.ZQJxEMiMjNdHQmVWxDtDCRrFHpRh = tJKAaDrvDYPmVdvOWTbYhAqgFPi2.cjOWzBCMkHIxRWceNYEqTjupNms;
				P_0.FfbgQkFEOHvMYGENpNQWUtsUWFC = tJKAaDrvDYPmVdvOWTbYhAqgFPi2.AhHrqrQkLzCLgDcoKPqTNKyjQNgv;
				P_2 = ZhzEgYNkzSQYSkAsExZjzNVVOnu.QFJFOJiyXWgrKYfnpEuAlgWfgYVB(tJKAaDrvDYPmVdvOWTbYhAqgFPi2, P_0.enrHFMRQgCWUTcGBWcZaPNsNxwT, P_0.UjlLMcJBUCEjQCPTUCFwbFmHYQxE, P_0.FfbgQkFEOHvMYGENpNQWUtsUWFC);
				tJKAaDrvDYPmVdvOWTbYhAqgFPi2.Dispose();
			}
		}
		catch (Exception)
		{
		}
	}

	private void zmiSfwPHwVrmRSdAAPoYwaeqKjX()
	{
		lock (QnjPDsavPpORFdRFTiPBJdcwCnOc)
		{
			for (int i = 0; i < loHxsPzTnMgHxGoyDcWpTtzNQnO; i++)
			{
				try
				{
					iHkeJQxMhCacNXSKKcHkJmGQjzU iHkeJQxMhCacNXSKKcHkJmGQjzU = MYIilGlzGtMSBPimluqBFDXADRJ[i];
					if (iHkeJQxMhCacNXSKKcHkJmGQjzU != null && iHkeJQxMhCacNXSKKcHkJmGQjzU.OSjZQlsjtWjjULblHOgvsjwZwLn() && (!uGlRgnZIMzNMfAWVtsRmeydggPR || !iHkeJQxMhCacNXSKKcHkJmGQjzU.ElGbwvcoyOUnEXwgQgFRFCxZUkkb))
					{
						iHkeJQxMhCacNXSKKcHkJmGQjzU.Update();
					}
				}
				catch
				{
				}
			}
		}
	}

	private IList<tvkecSTWbFlWcBbAxxdWaePZtgu> zZqzMfnBahJRFLfDOwATkEMpuRK()
	{
		try
		{
			IList<tvkecSTWbFlWcBbAxxdWaePZtgu> list = dPWcuMTmvbDZbtxvGfKdatZLIbG.lpdhCcAesAIzAGEfNnVRtTZgAQra(FnrirBBrCqEzZffWHJpycBFJwosJ.UvaLcJUctvCPobYgXUuBtTtpeXVB, nnLcxzlMtvpnesQPBfJOcQhMmpL.sdvQKHtDvxdfLARkaCRCfLfJDKDa);
			EabZgzogacUapwLsUHFGCzwKdcC = list?.Count ?? 0;
			return list;
		}
		catch
		{
			Logger.LogError("Error getting devices from Direct Input!");
			EabZgzogacUapwLsUHFGCzwKdcC = 0;
			return EmptyObjects<tvkecSTWbFlWcBbAxxdWaePZtgu>.EmptyReadOnlyIListT;
		}
	}

	private void tLqFENxHjSOacCzfowrjxfjBHb()
	{
		dPWcuMTmvbDZbtxvGfKdatZLIbG.lpdhCcAesAIzAGEfNnVRtTZgAQra();
	}

	private void EeIuYvQhmSRZqiNcnKnGCxRWVku(int P_0, int P_1, List<iHkeJQxMhCacNXSKKcHkJmGQjzU> P_2, List<iHkeJQxMhCacNXSKKcHkJmGQjzU> P_3)
	{
		if (P_1 > 0)
		{
			P_3.Sort(iHkeJQxMhCacNXSKKcHkJmGQjzU.VIwhAhMGYzgeSCmSvoVckQcSdbGf);
		}
		if (P_0 > 0 && P_1 > 0)
		{
			OMYBfwtZZUdWKVEriFHivmoUKvI(P_1, P_3, P_0, P_2, uonSwcgPfxmIYNLROxDhFiNofDV.KgmfMkkkUAKJbblFaOlBgxZfZWLy.vwOfhEYipyOtQiesBaMULwuTJjR);
		}
		IvQeJDKJktPbHepRiTImDJaYBsFO(P_1, P_3, uonSwcgPfxmIYNLROxDhFiNofDV.KgmfMkkkUAKJbblFaOlBgxZfZWLy.vwOfhEYipyOtQiesBaMULwuTJjR);
		for (int i = 0; i < P_1; i++)
		{
			iHkeJQxMhCacNXSKKcHkJmGQjzU iHkeJQxMhCacNXSKKcHkJmGQjzU = P_3[i];
			if (iHkeJQxMhCacNXSKKcHkJmGQjzU != null && iHkeJQxMhCacNXSKKcHkJmGQjzU.inputManagerId < 0)
			{
				iHkeJQxMhCacNXSKKcHkJmGQjzU.inputManagerId = zPoCmfMnwfqtZwKNhlzPHZDbZWe(P_3);
				iHkeJQxMhCacNXSKKcHkJmGQjzU.rewiredId = ilAOFbKaMpyqndLrycyBBEQAMvEC();
				FATxLzcXldiDnUItlRTPAJuORDM.tJzVKzbFmLbtbkPtOJIPqoQXsJj(iHkeJQxMhCacNXSKKcHkJmGQjzU);
			}
		}
		P_3.Sort(iHkeJQxMhCacNXSKKcHkJmGQjzU.sBorulmFfIIacZAhohMFFNzabbGA);
	}

	private void zKvLaOvdCFSGsSNlDLWcbrwtKVw(List<iHkeJQxMhCacNXSKKcHkJmGQjzU> P_0, int P_1, int P_2)
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

	private bool AjBmLDSFXqEyPzqFqJamwkrBg(List<iHkeJQxMhCacNXSKKcHkJmGQjzU> P_0, int P_1)
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

	private int zPoCmfMnwfqtZwKNhlzPHZDbZWe(List<iHkeJQxMhCacNXSKKcHkJmGQjzU> P_0)
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

	private bool bgNHiSCBOuTUFKSAzvcDoOxcFWB(List<iHkeJQxMhCacNXSKKcHkJmGQjzU> P_0, int P_1)
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

	private void OMYBfwtZZUdWKVEriFHivmoUKvI(int P_0, List<iHkeJQxMhCacNXSKKcHkJmGQjzU> P_1, int P_2, List<iHkeJQxMhCacNXSKKcHkJmGQjzU> P_3, uonSwcgPfxmIYNLROxDhFiNofDV.KgmfMkkkUAKJbblFaOlBgxZfZWLy P_4)
	{
		int num = ((P_4 != 0) ? 1 : 2);
		for (int i = 0; i < P_0; i++)
		{
			iHkeJQxMhCacNXSKKcHkJmGQjzU iHkeJQxMhCacNXSKKcHkJmGQjzU = P_1[i];
			if (iHkeJQxMhCacNXSKKcHkJmGQjzU == null || iHkeJQxMhCacNXSKKcHkJmGQjzU.inputManagerId >= 0)
			{
				continue;
			}
			for (int j = 0; j < P_2; j++)
			{
				iHkeJQxMhCacNXSKKcHkJmGQjzU iHkeJQxMhCacNXSKKcHkJmGQjzU2 = P_3[j];
				if (iHkeJQxMhCacNXSKKcHkJmGQjzU2 != null && !bgNHiSCBOuTUFKSAzvcDoOxcFWB(P_1, iHkeJQxMhCacNXSKKcHkJmGQjzU2.rewiredId) && iHkeJQxMhCacNXSKKcHkJmGQjzU.QdqhDkpVZKgyndwhadmFgJdPnvx(iHkeJQxMhCacNXSKKcHkJmGQjzU2) >= num)
				{
					iHkeJQxMhCacNXSKKcHkJmGQjzU.mBTEWwhZTVXHADiOGGiZHrhHDFU(iHkeJQxMhCacNXSKKcHkJmGQjzU2);
					FATxLzcXldiDnUItlRTPAJuORDM.tJzVKzbFmLbtbkPtOJIPqoQXsJj(iHkeJQxMhCacNXSKKcHkJmGQjzU);
				}
			}
		}
	}

	private void IvQeJDKJktPbHepRiTImDJaYBsFO(int P_0, List<iHkeJQxMhCacNXSKKcHkJmGQjzU> P_1, uonSwcgPfxmIYNLROxDhFiNofDV.KgmfMkkkUAKJbblFaOlBgxZfZWLy P_2)
	{
		for (int i = 0; i < P_0; i++)
		{
			iHkeJQxMhCacNXSKKcHkJmGQjzU iHkeJQxMhCacNXSKKcHkJmGQjzU = P_1[i];
			if (iHkeJQxMhCacNXSKKcHkJmGQjzU == null || iHkeJQxMhCacNXSKKcHkJmGQjzU.inputManagerId >= 0)
			{
				continue;
			}
			uonSwcgPfxmIYNLROxDhFiNofDV.SiYcHroIfhDCENoEPjbNiPNvxlSV siYcHroIfhDCENoEPjbNiPNvxlSV = null;
			foreach (uonSwcgPfxmIYNLROxDhFiNofDV.SiYcHroIfhDCENoEPjbNiPNvxlSV item in FATxLzcXldiDnUItlRTPAJuORDM.kVbYiwIwEyRBOVIjRkdFFmyOTNz(iHkeJQxMhCacNXSKKcHkJmGQjzU, P_2))
			{
				if (!bgNHiSCBOuTUFKSAzvcDoOxcFWB(P_1, item.OyDnkOlVbHfuMnCTJaxdfguHXtY) && item.WUtWdnEkcbOowTZyNYSAYqiqIsk >= 0)
				{
					siYcHroIfhDCENoEPjbNiPNvxlSV = item;
					break;
				}
			}
			if (siYcHroIfhDCENoEPjbNiPNvxlSV != null)
			{
				int num = siYcHroIfhDCENoEPjbNiPNvxlSV.WUtWdnEkcbOowTZyNYSAYqiqIsk;
				if (!AjBmLDSFXqEyPzqFqJamwkrBg(P_1, num))
				{
					num = (siYcHroIfhDCENoEPjbNiPNvxlSV.WUtWdnEkcbOowTZyNYSAYqiqIsk = zPoCmfMnwfqtZwKNhlzPHZDbZWe(P_1));
				}
				iHkeJQxMhCacNXSKKcHkJmGQjzU.inputManagerId = num;
				iHkeJQxMhCacNXSKKcHkJmGQjzU.rewiredId = siYcHroIfhDCENoEPjbNiPNvxlSV.OyDnkOlVbHfuMnCTJaxdfguHXtY;
				FATxLzcXldiDnUItlRTPAJuORDM.tJzVKzbFmLbtbkPtOJIPqoQXsJj(iHkeJQxMhCacNXSKKcHkJmGQjzU);
			}
		}
	}

	private void bcRjnCjxDyUMfEPooNQtVhZjlFn()
	{
		if (ZaHdIQkaIKVVZtdbtetCjNuMBLP)
		{
			XihvHrtxMyuRBhzCdkQyIlBKnWD();
		}
		if (kcoiUACBncevuyrKJkLfepispgtW.bgLAKkuspNIyPudbNgPBgmqQVpJG && kcoiUACBncevuyrKJkLfepispgtW.bXUJACnaYvOCANYOaVrTdSwcZxj())
		{
			SOTIqsKhbfvRbDbUarlymqitvYq(kcoiUACBncevuyrKJkLfepispgtW.GWOwgIzmyVWsoVjleBNCERdBoQa);
		}
	}

	private void XihvHrtxMyuRBhzCdkQyIlBKnWD()
	{
		ZaHdIQkaIKVVZtdbtetCjNuMBLP = false;
		if (!kcoiUACBncevuyrKJkLfepispgtW.bgLAKkuspNIyPudbNgPBgmqQVpJG)
		{
			kcoiUACBncevuyrKJkLfepispgtW.UBdDYFzJEaQOUTjUSMwjsblQggo();
		}
	}

	private void SOTIqsKhbfvRbDbUarlymqitvYq(List<onuieZrnwJdPuFaILwstndpZItbr> P_0)
	{
		if (xPWYINmsCfqOgdDnchRrOMNwuJj(onuieZrnwJdPuFaILwstndpZItbr.QZaecYFxROpVRlKLvHDqTilibpc(P_0)))
		{
			LBRErFJZckbosgViZAxBsuCreoXk(P_0);
		}
	}

	private bool xPWYINmsCfqOgdDnchRrOMNwuJj(IList<tvkecSTWbFlWcBbAxxdWaePZtgu> P_0)
	{
		lock (QnjPDsavPpORFdRFTiPBJdcwCnOc)
		{
			int count = P_0.Count;
			for (int i = 0; i < count; i++)
			{
				if (P_0[i] != null && !sJrfbUJWzRlXGxjYfzRpYaLNqyu(P_0[i].mXqEWIlGwHZPoKjhftGIspoptJq))
				{
					return true;
				}
			}
			int count2 = MYIilGlzGtMSBPimluqBFDXADRJ.Count;
			for (int j = 0; j < count2; j++)
			{
				if (MYIilGlzGtMSBPimluqBFDXADRJ[j] != null && !TXpOYhQBUhUCqDnFGxmDUfVduUZ(P_0, MYIilGlzGtMSBPimluqBFDXADRJ[j].instanceGuid))
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool sJrfbUJWzRlXGxjYfzRpYaLNqyu(Guid P_0)
	{
		lock (QnjPDsavPpORFdRFTiPBJdcwCnOc)
		{
			int count = MYIilGlzGtMSBPimluqBFDXADRJ.Count;
			for (int i = 0; i < count; i++)
			{
				if (MYIilGlzGtMSBPimluqBFDXADRJ[i] != null && MYIilGlzGtMSBPimluqBFDXADRJ[i].instanceGuid == P_0)
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool TXpOYhQBUhUCqDnFGxmDUfVduUZ(IList<tvkecSTWbFlWcBbAxxdWaePZtgu> P_0, Guid P_1)
	{
		int count = P_0.Count;
		for (int i = 0; i < count; i++)
		{
			if (P_0[i] != null && P_0[i].mXqEWIlGwHZPoKjhftGIspoptJq == P_1)
			{
				return true;
			}
		}
		return false;
	}

	private void RPDdEqlBagdPQQsCXgjiZWIMRVB(List<iHkeJQxMhCacNXSKKcHkJmGQjzU> P_0, List<iHkeJQxMhCacNXSKKcHkJmGQjzU> P_1, bool P_2)
	{
		if (P_0 == null)
		{
			return;
		}
		int num = P_0?.Count ?? 0;
		int num2 = P_1?.Count ?? 0;
		for (int i = 0; i < num; i++)
		{
			iHkeJQxMhCacNXSKKcHkJmGQjzU iHkeJQxMhCacNXSKKcHkJmGQjzU = P_0[i];
			if (iHkeJQxMhCacNXSKKcHkJmGQjzU == null)
			{
				continue;
			}
			bool flag = false;
			if (P_1 != null)
			{
				for (int j = 0; j < num2; j++)
				{
					iHkeJQxMhCacNXSKKcHkJmGQjzU iHkeJQxMhCacNXSKKcHkJmGQjzU2 = P_1[j];
					if (iHkeJQxMhCacNXSKKcHkJmGQjzU2 != null && iHkeJQxMhCacNXSKKcHkJmGQjzU.instanceGuid == iHkeJQxMhCacNXSKKcHkJmGQjzU2.instanceGuid)
					{
						flag = true;
						break;
					}
				}
			}
			if (!flag)
			{
				vgdgoCexCwvDPdTnoaGlarCzHePe(P_0[i], P_2);
			}
		}
	}

	private void vgdgoCexCwvDPdTnoaGlarCzHePe(iHkeJQxMhCacNXSKKcHkJmGQjzU P_0, bool P_1)
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

	private bool TEeCuhCMvpStgApRIpJvtadkDBup()
	{
		int num = dPWcuMTmvbDZbtxvGfKdatZLIbG.oWiQwSTbxUPrKaexcvddXRGofgL(FnrirBBrCqEzZffWHJpycBFJwosJ.UvaLcJUctvCPobYgXUuBtTtpeXVB, nnLcxzlMtvpnesQPBfJOcQhMmpL.sdvQKHtDvxdfLARkaCRCfLfJDKDa);
		if (EabZgzogacUapwLsUHFGCzwKdcC != num)
		{
			EabZgzogacUapwLsUHFGCzwKdcC = num;
			return true;
		}
		if (KCWyiDDIRaBxrGgXuSyLlYxXAUMH > 0 && sGlMksWVosYepTKljgGwvNbkLQx.SJCEFxQKNhAmDSKHBzlKlLkhcdd())
		{
			return true;
		}
		return false;
	}

	private void HsSGRYAQnHavnvQxDFeJjgyDfQMC(List<iHkeJQxMhCacNXSKKcHkJmGQjzU> P_0, List<iHkeJQxMhCacNXSKKcHkJmGQjzU> P_1)
	{
		if (P_1 == null)
		{
			return;
		}
		for (int i = 0; i < P_1.Count; i++)
		{
			if (P_1[i] != null && (P_0 == null || !P_0.Contains(P_1[i])))
			{
				P_1[i].PMzamCeIIFqnzgwGlxEbIeTHBFUL();
			}
		}
	}

	[Conditional("DEBUGTHIS")]
	private void XPeKiRzFXOxDRVcGroJuayahDUo(string P_0)
	{
		Logger.Log(P_0);
	}

	[CompilerGenerated]
	private List<onuieZrnwJdPuFaILwstndpZItbr> tcgScBHSvhAwmZLQkvcKfRWuwzj()
	{
		return gMJwbhLuwAVxzBgKqqrgedHDSxj();
	}
}
