using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Rewired;
using Rewired.Config;
using Rewired.Data;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Classes.Utility;
using Rewired.Windows.RawInput;

internal class PVHplNLarjGPjadzMDzXAgLHfzpK : PlatformInputManager, cAvjFIuogOpSRXxMsntCvEcAHqvj
{
	private class xhJrHyyHHQLYujqCJSgxyNWlCnjK : IInputManagerJoystick, IInputManagerJoystickPublic
	{
		private int HDUfrfQaCtWbjEQjslQVHYtxamY;

		private int GMogOPiabkOgxkvSLwYiIgcbdeI;

		public Guid FbSmcmcVOWowuyUiagueSMvFgly;

		public string DcCSwoiCsPKVmzyhfFwghvYDsbp;

		private readonly KXNanfFdezOfVOeIdsOvMHQobbRn XpDCkyERZZKigIpRBBHbNOfnuRCB;

		private readonly DeviceType DwQVqdylgiMTMzmPyTEVsChyDWRb;

		public string awueIOZppSsgBYIKhhnLggaAZAn;

		public string UjlLMcJBUCEjQCPTUCFwbFmHYQxE;

		public string FfbgQkFEOHvMYGENpNQWUtsUWFC;

		public int nWFtSCRFEzwWJAlKCuDmeqSLzvS;

		public int XEcyhhhJkxUMgVxECvasAHFnuwD;

		public Guid kmlrVkJoHAiVknTEjxTfehHxMGP;

		public Guid enrHFMRQgCWUTcGBWcZaPNsNxwT;

		public Guid KBeSAIfQuakWhKYXrKovLYpHcGg;

		public int qNPHPpgvRQEdsxgBWqwsRIjHSq;

		public int qfxfzVJncFGzpqWHPKYOQjSrVSc;

		public int dueoAnsXDyCXiTcKgFRIJGbwAJdQ;

		public int rdAiJgjkWhiEydzQBaCRfzCVRNHM;

		public int sTzXfOyWCNXZCDYOkqgPDWeTHnP;

		public int HtrgaJBhAduArjOzMjluWSwCPBqi;

		public bool ElGbwvcoyOUnEXwgQgFRFCxZUkkb;

		public bool ZQJxEMiMjNdHQmVWxDtDCRrFHpRh;

		public bool mUncBBKjUAbEBhJbCqRQJvpQDWom;

		public int pIfHtthDGBGwKzxQqqRIDOZlHWV;

		private float[] JdVEWmnshzhQhfQpWKygbxeaWPsN;

		private float[] zDdXRTONJmZUqqAiqtzcktIOAJw;

		private bool[] kquYalVDjtuQsvwoBPzAYiEipLG;

		private HardwareJoystickMap_InputManager FZCqfqZEBbHWoQxVVIkyNdAoiatI;

		private bAzvngVOSxcOOtKyDFyEOmarEWE LsDGPiKmEKAvYdxuZbgUVknDBtmE;

		private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> rpvCjQaePXpGswKHxhwfamxRDIu;

		private bool eiKbsRinsyNWKLFiiPPgjOvPBaj;

		private bool RtEBtfhoklZnMgNMZfcTKWlNBQe;

		private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

		[CompilerGenerated]
		private Controller.Extension OCmoYZuXHdqjzBexosOtjjddwgn;

		public bool AvKwFYrqAOInEkZZEMUJxDwiNdn
		{
			get
			{
				if (XpDCkyERZZKigIpRBBHbNOfnuRCB == null)
				{
					return false;
				}
				return XpDCkyERZZKigIpRBBHbNOfnuRCB.FvCxHidPaUCtnjMuXlsGPKWUDOiD != null;
			}
		}

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
		public Controller.Extension extension
		{
			[CompilerGenerated]
			get
			{
				return OCmoYZuXHdqjzBexosOtjjddwgn;
			}
			[CompilerGenerated]
			set
			{
				OCmoYZuXHdqjzBexosOtjjddwgn = value;
			}
		}

		[CustomObfuscation(rename = false)]
		public Guid instanceGuid => kmlrVkJoHAiVknTEjxTfehHxMGP;

		[CustomObfuscation(rename = false)]
		public Guid persistentGuid => instanceGuid;

		public bool jYuOzlJtihpWwRTDsuTZYrbfQmE
		{
			get
			{
				if (!jpnIPbpqmlecdiNqaFAxiNCsiMxs && XpDCkyERZZKigIpRBBHbNOfnuRCB != null)
				{
					return XpDCkyERZZKigIpRBBHbNOfnuRCB.jYuOzlJtihpWwRTDsuTZYrbfQmE;
				}
				return false;
			}
		}

		[CustomObfuscation(rename = false)]
		public void SetVibration(float amount, int motorIndex)
		{
			_ = jYuOzlJtihpWwRTDsuTZYrbfQmE;
		}

		[CustomObfuscation(rename = false)]
		public void StopVibration()
		{
			_ = jYuOzlJtihpWwRTDsuTZYrbfQmE;
		}

		public xhJrHyyHHQLYujqCJSgxyNWlCnjK(KXNanfFdezOfVOeIdsOvMHQobbRn joystick, DeviceType riDeviceType, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager)
		{
			XpDCkyERZZKigIpRBBHbNOfnuRCB = joystick;
			DwQVqdylgiMTMzmPyTEVsChyDWRb = riDeviceType;
			rpvCjQaePXpGswKHxhwfamxRDIu = getHardwareJoystickMap_InputManager;
			GMogOPiabkOgxkvSLwYiIgcbdeI = -1;
			HDUfrfQaCtWbjEQjslQVHYtxamY = -1;
		}

		public void iZnBUcZPCYZUOuauoTTqYipxzmI()
		{
			if (!jYuOzlJtihpWwRTDsuTZYrbfQmE)
			{
				return;
			}
			KBeSAIfQuakWhKYXrKovLYpHcGg = MiscTools.CreateGuidHashSHA1(((!string.IsNullOrEmpty(FfbgQkFEOHvMYGENpNQWUtsUWFC)) ? FfbgQkFEOHvMYGENpNQWUtsUWFC : UjlLMcJBUCEjQCPTUCFwbFmHYQxE) + enrHFMRQgCWUTcGBWcZaPNsNxwT);
			qfxfzVJncFGzpqWHPKYOQjSrVSc = rdAiJgjkWhiEydzQBaCRfzCVRNHM;
			dueoAnsXDyCXiTcKgFRIJGbwAJdQ = sTzXfOyWCNXZCDYOkqgPDWeTHnP + HtrgaJBhAduArjOzMjluWSwCPBqi * 8;
			DkCucBGofWqRioHvuuaHxGeOUvg();
			FbSmcmcVOWowuyUiagueSMvFgly = FZCqfqZEBbHWoQxVVIkyNdAoiatI.hardwareMapIdentifier.guid;
			DcCSwoiCsPKVmzyhfFwghvYDsbp = FZCqfqZEBbHWoQxVVIkyNdAoiatI.controllerName;
			eiKbsRinsyNWKLFiiPPgjOvPBaj = ((FbSmcmcVOWowuyUiagueSMvFgly == Guid.Empty) ? true : false);
			JdVEWmnshzhQhfQpWKygbxeaWPsN = new float[qfxfzVJncFGzpqWHPKYOQjSrVSc];
			zDdXRTONJmZUqqAiqtzcktIOAJw = new float[dueoAnsXDyCXiTcKgFRIJGbwAJdQ];
			kquYalVDjtuQsvwoBPzAYiEipLG = new bool[dueoAnsXDyCXiTcKgFRIJGbwAJdQ];
			if (FZCqfqZEBbHWoQxVVIkyNdAoiatI != null && dueoAnsXDyCXiTcKgFRIJGbwAJdQ > 0)
			{
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
							kquYalVDjtuQsvwoBPzAYiEipLG[j] = buttons_orig2[j].buttonInfo.isPressureSensitive;
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
							kquYalVDjtuQsvwoBPzAYiEipLG[i] = buttons_orig[i].buttonInfo.isPressureSensitive;
						}
					}
					break;
				}
				}
			}
			LsDGPiKmEKAvYdxuZbgUVknDBtmE = XpDCkyERZZKigIpRBBHbNOfnuRCB.aULIdCPnoKcahlmTKaJufZBJrFxf;
			Update();
		}

		public void mBTEWwhZTVXHADiOGGiZHrhHDFU(xhJrHyyHHQLYujqCJSgxyNWlCnjK P_0)
		{
			if (jYuOzlJtihpWwRTDsuTZYrbfQmE && P_0 != null)
			{
				GMogOPiabkOgxkvSLwYiIgcbdeI = P_0.GMogOPiabkOgxkvSLwYiIgcbdeI;
				HDUfrfQaCtWbjEQjslQVHYtxamY = P_0.HDUfrfQaCtWbjEQjslQVHYtxamY;
				for (int i = 0; i < MathTools.Min(zDdXRTONJmZUqqAiqtzcktIOAJw.Length, P_0.zDdXRTONJmZUqqAiqtzcktIOAJw.Length); i++)
				{
					zDdXRTONJmZUqqAiqtzcktIOAJw[i] = P_0.zDdXRTONJmZUqqAiqtzcktIOAJw[i];
				}
				for (int j = 0; j < MathTools.Min(kquYalVDjtuQsvwoBPzAYiEipLG.Length, P_0.kquYalVDjtuQsvwoBPzAYiEipLG.Length); j++)
				{
					kquYalVDjtuQsvwoBPzAYiEipLG[j] = P_0.kquYalVDjtuQsvwoBPzAYiEipLG[j];
				}
				for (int k = 0; k < MathTools.Min(JdVEWmnshzhQhfQpWKygbxeaWPsN.Length, P_0.JdVEWmnshzhQhfQpWKygbxeaWPsN.Length); k++)
				{
					JdVEWmnshzhQhfQpWKygbxeaWPsN[k] = P_0.JdVEWmnshzhQhfQpWKygbxeaWPsN[k];
				}
				RtEBtfhoklZnMgNMZfcTKWlNBQe = P_0.RtEBtfhoklZnMgNMZfcTKWlNBQe;
			}
		}

		[CustomObfuscation(rename = false)]
		public void Update()
		{
			if (jYuOzlJtihpWwRTDsuTZYrbfQmE)
			{
				bool[] buttons = XpDCkyERZZKigIpRBBHbNOfnuRCB.OZXCbzyfeJVptcfXueOFPpFxErd;
				int[] hatValues = XpDCkyERZZKigIpRBBHbNOfnuRCB.qIIdusxdnSOeOAjfnhjxlMrFQsM;
				QAJCSlFtoGBRITqPqBBrQqVEeBT(buttons, hatValues);
				ldPMgFaEItHhAAPdUPIqVhZTNOL(buttons, hatValues);
			}
		}

		[CustomObfuscation(rename = false)]
		public void FillData(ControllerDataUpdater dataUpdater)
		{
			if (!jYuOzlJtihpWwRTDsuTZYrbfQmE)
			{
				return;
			}
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
				if (kquYalVDjtuQsvwoBPzAYiEipLG[j])
				{
					dataUpdater.buttonPressureValues[j] = zDdXRTONJmZUqqAiqtzcktIOAJw[j];
				}
				else
				{
					dataUpdater.buttonValues[j] = zDdXRTONJmZUqqAiqtzcktIOAJw[j] > 0f;
				}
			}
			if (RtEBtfhoklZnMgNMZfcTKWlNBQe && !dataUpdater.hasReceivedInput)
			{
				dataUpdater.hasReceivedInput = true;
			}
		}

		public int QdqhDkpVZKgyndwhadmFgJdPnvx(xhJrHyyHHQLYujqCJSgxyNWlCnjK P_0)
		{
			if (!jYuOzlJtihpWwRTDsuTZYrbfQmE)
			{
				return 0;
			}
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
			if (AvKwFYrqAOInEkZZEMUJxDwiNdn != P_0.AvKwFYrqAOInEkZZEMUJxDwiNdn)
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
			if (!jYuOzlJtihpWwRTDsuTZYrbfQmE)
			{
				return null;
			}
			BridgedController bridgedController = new BridgedController();
			mcfuFPdUGFrLUTlWgAfDNLiDDwZ(bridgedController);
			return bridgedController;
		}

		[CustomObfuscation(rename = false)]
		public ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs()
		{
			return new ControllerDisconnectedEventArgs(HDUfrfQaCtWbjEQjslQVHYtxamY);
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
				HardwareJoystickMap.Platform_RawInput_Base.Axis[] axes_orig3 = platform_RawInput_Base.Axes_orig;
				if (axes_orig3 != null)
				{
					for (int k = 0; k < axes_orig3.Length; k++)
					{
						PgBiTZcLgnGgQgBxgVfbEdeObiMW(axes_orig3[k], k, P_0, P_1);
					}
				}
				break;
			}
			case InputPlatform.VJDsrfiTpGRdzQKJnkPsFSIDvJQ:
			{
				HardwareJoystickMap.Platform_DirectInput_Base platform_DirectInput_Base = (HardwareJoystickMap.Platform_DirectInput_Base)FZCqfqZEBbHWoQxVVIkyNdAoiatI.map;
				HardwareJoystickMap.Platform_DirectInput_Base.Axis[] axes_orig2 = platform_DirectInput_Base.Axes_orig;
				if (axes_orig2 != null)
				{
					for (int j = 0; j < axes_orig2.Length; j++)
					{
						PgBiTZcLgnGgQgBxgVfbEdeObiMW(axes_orig2[j], j, P_0, P_1);
					}
				}
				break;
			}
			case InputPlatform.hgTyGSNrXsceWPdpSnLeplqqpsT:
			{
				HardwareJoystickMap.Platform_InternalDriver_Base platform_InternalDriver_Base = (HardwareJoystickMap.Platform_InternalDriver_Base)FZCqfqZEBbHWoQxVVIkyNdAoiatI.map;
				HardwareJoystickMap.Platform_InternalDriver_Base.Axis[] axes_orig = platform_InternalDriver_Base.Axes_orig;
				if (axes_orig != null)
				{
					for (int i = 0; i < axes_orig.Length; i++)
					{
						HcybRqLCMAWoowDzsNPHQOEXNBG(axes_orig[i], i, P_0, P_1);
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
				HardwareJoystickMap.Platform_RawInput_Base.Button[] buttons_orig3 = platform_RawInput_Base.Buttons_orig;
				if (buttons_orig3 != null)
				{
					for (int k = 0; k < buttons_orig3.Length; k++)
					{
						LXUbHihsbIHDfayNTWVNKvbxsOEf(buttons_orig3[k], k, P_0, P_1);
					}
				}
				break;
			}
			case InputPlatform.VJDsrfiTpGRdzQKJnkPsFSIDvJQ:
			{
				HardwareJoystickMap.Platform_DirectInput_Base platform_DirectInput_Base = (HardwareJoystickMap.Platform_DirectInput_Base)FZCqfqZEBbHWoQxVVIkyNdAoiatI.map;
				HardwareJoystickMap.Platform_DirectInput_Base.Button[] buttons_orig2 = platform_DirectInput_Base.Buttons_orig;
				if (buttons_orig2 != null)
				{
					for (int j = 0; j < buttons_orig2.Length; j++)
					{
						LXUbHihsbIHDfayNTWVNKvbxsOEf(buttons_orig2[j], j, P_0, P_1);
					}
				}
				break;
			}
			case InputPlatform.hgTyGSNrXsceWPdpSnLeplqqpsT:
			{
				HardwareJoystickMap.Platform_InternalDriver_Base platform_InternalDriver_Base = (HardwareJoystickMap.Platform_InternalDriver_Base)FZCqfqZEBbHWoQxVVIkyNdAoiatI.map;
				HardwareJoystickMap.Platform_InternalDriver_Base.Button[] buttons_orig = platform_InternalDriver_Base.Buttons_orig;
				if (buttons_orig != null)
				{
					for (int i = 0; i < buttons_orig.Length; i++)
					{
						sVGIdYThAOdZOYSHPjpGXzOMqSq(buttons_orig[i], i, P_0, P_1);
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
			if (!RtEBtfhoklZnMgNMZfcTKWlNBQe && zDdXRTONJmZUqqAiqtzcktIOAJw[P_1] != 0f)
			{
				RtEBtfhoklZnMgNMZfcTKWlNBQe = true;
			}
		}

		private float WbUNdjrqDniDXYdirtEbXVOOxfO(HardwareJoystickMap.Platform_RawOrDirectInput.Axis_Base P_0, bool[] P_1, int[] P_2)
		{
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Axis)
			{
				int sourceAxis = P_0.sourceAxis;
				int num;
				switch (sourceAxis)
				{
				case 0:
					return 0f;
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				case 11:
					num = 0;
					break;
				default:
					if (sourceAxis == 1000)
					{
						if (!(P_0 is HardwareJoystickMap.Platform_RawInput_Base.Axis axis))
						{
							return 0f;
						}
						num = axis.sourceOtherAxis;
						break;
					}
					return 0f;
				}
				return WbUNdjrqDniDXYdirtEbXVOOxfO((RawInputAxis)sourceAxis, num);
			}
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Button)
			{
				int sourceButton = P_0.sourceButton;
				if (sourceButton < 0 || sourceButton >= sTzXfOyWCNXZCDYOkqgPDWeTHnP || sourceButton >= 256)
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
				int num2 = P_2[sourceHat];
				if (num2 < 0)
				{
					return 0f;
				}
				float num3;
				if (P_0.sourceHatDirection == AxisDirection.Horizontal)
				{
					num3 = bmQYKGgKrUqNjnarxlXMrBxKClu(num2, AxisDirection.Horizontal);
					if (P_0.sourceHatRange != 0)
					{
						if (P_0.sourceHatRange == AxisRange.Positive)
						{
							if (num3 < 0f)
							{
								return 0f;
							}
						}
						else if (num3 > 0f)
						{
							return 0f;
						}
					}
				}
				else
				{
					num3 = bmQYKGgKrUqNjnarxlXMrBxKClu(num2, AxisDirection.Vertical);
					if (P_0.sourceHatRange != 0)
					{
						if (P_0.sourceHatRange == AxisRange.Positive)
						{
							if (num3 < 0f)
							{
								return 0f;
							}
						}
						else if (num3 > 0f)
						{
							return 0f;
						}
					}
				}
				if (P_0.invert)
				{
					num3 *= -1f;
				}
				return num3;
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

		private float WbUNdjrqDniDXYdirtEbXVOOxfO(RawInputAxis P_0, int P_1)
		{
			return tRSsFucqdzXsNtvLSMlgIVxHHWP((LsDGPiKmEKAvYdxuZbgUVknDBtmE as motgBtqJibKySxJNjhgkDyeccgE).WbUNdjrqDniDXYdirtEbXVOOxfO(P_0, P_1));
		}

		private float kXRepGCTsYPuBnCuTSPcGaXqgpDv(HardwareJoystickMap.Platform_RawOrDirectInput.Button_Base P_0, bool[] P_1, int[] P_2)
		{
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Button)
			{
				if (P_0.ignoreIfButtonsActive)
				{
					for (int i = 0; i < P_0.ignoreIfButtonsActiveButtons.Length; i++)
					{
						if (P_1[P_0.ignoreIfButtonsActiveButtons[i]])
						{
							return 0f;
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
							return 0f;
						}
						flag = true;
					}
					if (flag)
					{
						return 1f;
					}
					return 0f;
				}
				int sourceButton = P_0.sourceButton;
				if (sourceButton < 0 || sourceButton >= sTzXfOyWCNXZCDYOkqgPDWeTHnP || sourceButton >= 256)
				{
					return 0f;
				}
				if (!P_1[sourceButton])
				{
					return 0f;
				}
				return 1f;
			}
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Axis)
			{
				int sourceAxis = P_0.sourceAxis;
				int num;
				switch (sourceAxis)
				{
				case 0:
					return 0f;
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				case 11:
					num = 0;
					break;
				default:
					if (sourceAxis == 1000)
					{
						if (!(P_0 is HardwareJoystickMap.Platform_RawInput_Base.Button button))
						{
							return 0f;
						}
						num = button.sourceOtherAxis;
						break;
					}
					return 0f;
				}
				float num2 = WbUNdjrqDniDXYdirtEbXVOOxfO((RawInputAxis)sourceAxis, num);
				float num3 = MathTools.Abs(num2);
				if (num3 <= P_0.axisDeadZone)
				{
					return 0f;
				}
				if (P_0.sourceAxisPole == Pole.Positive)
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
				return num3;
			}
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Hat)
			{
				int sourceHat = P_0.sourceHat;
				if (sourceHat < 0 || sourceHat >= HtrgaJBhAduArjOzMjluWSwCPBqi || sourceHat >= 4)
				{
					return 0f;
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
						if (GLJZCYcwPrWuHTmRalESCGkLPcD(customCalculationSourceData[k], out var num4))
						{
							customCalculation.AddData((num4 != 0f) ? 1f : 0f);
						}
						break;
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
				if ((float)customCalculation.Result == 0f)
				{
					return 0f;
				}
				return 1f;
			}
			return 0f;
		}

		private float tRSsFucqdzXsNtvLSMlgIVxHHWP(int P_0)
		{
			if (P_0 == 0)
			{
				return 0f;
			}
			return MathTools.Clamp((float)MathTools.Abs(P_0) / 65535f * (float)MathTools.Sign(P_0), -1f, 1f);
		}

		private float arYETMBOlYsDyioxqUOrsTqFbdC(int P_0, int P_1, HatType P_2)
		{
			if (P_0 < 0)
			{
				return 0f;
			}
			if (FZCqfqZEBbHWoQxVVIkyNdAoiatI.isUnknownController && !InputTools.HandleForced4WayHatsOnUnknownControllers(P_1, ref P_2))
			{
				return 0f;
			}
			int num = 4500;
			int num2 = num * P_1;
			if (P_2 == HatType.EightWay && P_0 != num2)
			{
				return 0f;
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
				return 1f;
			}
			return 0f;
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
			if (sourceButton < 0 || sourceButton >= sTzXfOyWCNXZCDYOkqgPDWeTHnP || sourceButton >= 256)
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
			if (P_0.sourceAxis == 0)
			{
				return false;
			}
			P_1 = WbUNdjrqDniDXYdirtEbXVOOxfO((RawInputAxis)P_0.sourceAxis, P_0.sourceOtherAxis);
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

		private ControlDeviceType qyvFlshPbDrARTSPflpRGRsjMUH(DeviceType P_0)
		{
			return P_0 switch
			{
				DeviceType.Keyboard => ControlDeviceType.VptHLZXdJfMsrxxJFwCBsNGGFnMF, 
				DeviceType.Joystick => ControlDeviceType.QIiFjjgvNmDRWWXPiwXfgdhsPuPT, 
				DeviceType.Gamepad => ControlDeviceType.HozKeFupbFMAkawChHxgYAvTwqs, 
				DeviceType.Mouse => ControlDeviceType.iBsunrzpmNRGjincwoFXBCjHvrY, 
				DeviceType.MultiAxisController => ControlDeviceType.QIiFjjgvNmDRWWXPiwXfgdhsPuPT, 
				_ => ControlDeviceType.CCZTuwVJranWzEkxzHtKCBLLDDz, 
			};
		}

		private void HcybRqLCMAWoowDzsNPHQOEXNBG(HardwareJoystickMap.Platform_InternalDriver_Base.Axis P_0, int P_1, bool[] P_2, int[] P_3)
		{
			if (P_1 >= qfxfzVJncFGzpqWHPKYOQjSrVSc)
			{
				throw new Exception("Number of axes in hardware map does not match number of axes found in controller!");
			}
			JdVEWmnshzhQhfQpWKygbxeaWPsN[P_1] = creWWjAvJqGmAPPWeAJFEgBWIMfg(P_0, P_2, P_3);
			if (!RtEBtfhoklZnMgNMZfcTKWlNBQe && JdVEWmnshzhQhfQpWKygbxeaWPsN[P_1] != 0f)
			{
				RtEBtfhoklZnMgNMZfcTKWlNBQe = true;
			}
		}

		private void sVGIdYThAOdZOYSHPjpGXzOMqSq(HardwareJoystickMap.Platform_InternalDriver_Base.Button P_0, int P_1, bool[] P_2, int[] P_3)
		{
			if (P_1 >= dueoAnsXDyCXiTcKgFRIJGbwAJdQ)
			{
				throw new Exception("Number of buttons in hardware map does not match number of buttons found in controller!");
			}
			zDdXRTONJmZUqqAiqtzcktIOAJw[P_1] = UUNfDHjZhgRSGeEnqMaQXlFctIdD(P_0, P_2, P_3);
			if (!RtEBtfhoklZnMgNMZfcTKWlNBQe && zDdXRTONJmZUqqAiqtzcktIOAJw[P_1] != 0f)
			{
				RtEBtfhoklZnMgNMZfcTKWlNBQe = true;
			}
		}

		private float creWWjAvJqGmAPPWeAJFEgBWIMfg(HardwareJoystickMap.Platform_InternalDriver_Base.Axis P_0, bool[] P_1, int[] P_2)
		{
			if (P_0.sourceType == 1)
			{
				int sourceAxis = P_0.sourceAxis;
				if (sourceAxis < 0 || sourceAxis >= rdAiJgjkWhiEydzQBaCRfzCVRNHM || sourceAxis >= 56)
				{
					return 0f;
				}
				return creWWjAvJqGmAPPWeAJFEgBWIMfg(sourceAxis);
			}
			if (P_0.sourceType == 0)
			{
				int sourceButton = P_0.sourceButton;
				if (sourceButton < 0 || sourceButton >= sTzXfOyWCNXZCDYOkqgPDWeTHnP || sourceButton >= 256)
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
			if (P_0.sourceType == 2)
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
			return 0f;
		}

		private float creWWjAvJqGmAPPWeAJFEgBWIMfg(int P_0)
		{
			return (LsDGPiKmEKAvYdxuZbgUVknDBtmE as ifndHOoqZsBPMNDcrjlvbinoYGSv).WbUNdjrqDniDXYdirtEbXVOOxfO(P_0);
		}

		private float UUNfDHjZhgRSGeEnqMaQXlFctIdD(HardwareJoystickMap.Platform_InternalDriver_Base.Button P_0, bool[] P_1, int[] P_2)
		{
			if (P_0.sourceType == 0)
			{
				int sourceButton = P_0.sourceButton;
				if (sourceButton < 0 || sourceButton >= sTzXfOyWCNXZCDYOkqgPDWeTHnP || sourceButton >= 256)
				{
					return 0f;
				}
				if (!P_1[sourceButton])
				{
					return 0f;
				}
				return 1f;
			}
			if (P_0.sourceType == 1)
			{
				int sourceAxis = P_0.sourceAxis;
				if (sourceAxis < 0 || sourceAxis >= rdAiJgjkWhiEydzQBaCRfzCVRNHM || sourceAxis >= 56)
				{
					return 0f;
				}
				float num = creWWjAvJqGmAPPWeAJFEgBWIMfg(sourceAxis);
				if (MathTools.Abs(num) <= P_0.axisDeadZone)
				{
					return 0f;
				}
				if (P_0.sourceAxisPole == Pole.Positive)
				{
					if (num < 0f)
					{
						return 0f;
					}
				}
				else if (num > 0f)
				{
					return 0f;
				}
				return 1f;
			}
			if (P_0.sourceType == 2)
			{
				int sourceHat = P_0.sourceHat;
				if (sourceHat < 0 || sourceHat >= HtrgaJBhAduArjOzMjluWSwCPBqi || sourceHat >= 4)
				{
					return 0f;
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
			return 0f;
		}

		private bool EELhZxcLuScXQOXkkbnSUKbSdAXH(int P_0, int P_1, HatType P_2)
		{
			if (P_0 < 0)
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

		private float TEdnkHzqPpbcpKBoutLBFuQAcKTp(int P_0, AxisDirection P_1)
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

		private string PPJcSQzVaDAexHmAkgFfuRztqdju()
		{
			return InputTools.FormatHardwareIdentifierString($"{ReInput.currentPlatform.ToString()}{InputSource.RawInput}{((ZQJxEMiMjNdHQmVWxDtDCRrFHpRh && !string.IsNullOrEmpty(FfbgQkFEOHvMYGENpNQWUtsUWFC)) ? FfbgQkFEOHvMYGENpNQWUtsUWFC : UjlLMcJBUCEjQCPTUCFwbFmHYQxE)}{nWFtSCRFEzwWJAlKCuDmeqSLzvS}{enrHFMRQgCWUTcGBWcZaPNsNxwT}");
		}

		private void mcfuFPdUGFrLUTlWgAfDNLiDDwZ(BridgedControllerHWInfo P_0)
		{
			P_0.inputManagerSource = InputSource.RawInput;
			P_0.inputSource = XpDCkyERZZKigIpRBBHbNOfnuRCB.gDwqhSQfaYZFZHxNnvQwnNtbvOF;
			P_0.deviceType = qyvFlshPbDrARTSPflpRGRsjMUH(DwQVqdylgiMTMzmPyTEVsChyDWRb);
			P_0.hardwareIdentifier = PPJcSQzVaDAexHmAkgFfuRztqdju();
			P_0.hardwareAxisCount = rdAiJgjkWhiEydzQBaCRfzCVRNHM;
			P_0.hardwareButtonCount = sTzXfOyWCNXZCDYOkqgPDWeTHnP;
			P_0.hardwareHatCount = HtrgaJBhAduArjOzMjluWSwCPBqi;
			P_0.hw_productName = UjlLMcJBUCEjQCPTUCFwbFmHYQxE;
			P_0.hw_deviceGuid = instanceGuid;
			P_0.hw_vendorId = XEcyhhhJkxUMgVxECvasAHFnuwD;
			P_0.hw_productId = nWFtSCRFEzwWJAlKCuDmeqSLzvS;
			P_0.hw_pidVid = new PidVid(enrHFMRQgCWUTcGBWcZaPNsNxwT);
			P_0.hw_isBluetoothDevice = ZQJxEMiMjNdHQmVWxDtDCRrFHpRh;
			P_0.hw_bluetoothDeviceName = FfbgQkFEOHvMYGENpNQWUtsUWFC;
			P_0.hw_supportsVibration = mUncBBKjUAbEBhJbCqRQJvpQDWom;
			P_0.hw_localVibrationMotorCount = pIfHtthDGBGwKzxQqqRIDOZlHWV;
			P_0.definitionMatchTag = XpDCkyERZZKigIpRBBHbNOfnuRCB.iZspREnWqpdoftlgcsVXSMWbwAx;
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
			P_0.isButtonPressureSensitive = new bool[dueoAnsXDyCXiTcKgFRIJGbwAJdQ];
			Array.Copy(kquYalVDjtuQsvwoBPzAYiEipLG, P_0.isButtonPressureSensitive, dueoAnsXDyCXiTcKgFRIJGbwAJdQ);
			P_0.unknownControllerHats = NANSawXfTNGiVeqyfiYgTwMPhSb();
			P_0.controllerTypeGuid = FbSmcmcVOWowuyUiagueSMvFgly;
			P_0.controllerExtension = extension;
		}

		private void IStZgcKMzYGJKScWINoCKzxpnPK()
		{
			for (int i = 0; i < dueoAnsXDyCXiTcKgFRIJGbwAJdQ; i++)
			{
				zDdXRTONJmZUqqAiqtzcktIOAJw[i] = 0f;
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

		~xhJrHyyHHQLYujqCJSgxyNWlCnjK()
		{
			PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
		}

		protected virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
		{
			if (!jpnIPbpqmlecdiNqaFAxiNCsiMxs)
			{
				jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
			}
		}

		public static int OoPvRsOhPSBhUDBjOWyqfJWZamP(xhJrHyyHHQLYujqCJSgxyNWlCnjK P_0, xhJrHyyHHQLYujqCJSgxyNWlCnjK P_1)
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

		public static int ExjTEObjHqlevKjXuhIEFSCUmsH(xhJrHyyHHQLYujqCJSgxyNWlCnjK P_0, xhJrHyyHHQLYujqCJSgxyNWlCnjK P_1)
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

	private class WeCbTLfYgNYSCuupGxKGOLUkciRz
	{
		public enum dxrsWETyvdhCMttxWrrNbSUXOzU
		{
			vwOfhEYipyOtQiesBaMULwuTJjR = 0,
			PxAZUthBoqKstLGGPnsAsvkTrpD = 1
		}

		public class XgyePKUdLhtBDCodhtUDMPjLCMb
		{
			public int OyDnkOlVbHfuMnCTJaxdfguHXtY;

			public Guid UInlkenejuBpngBMzEcVuFHmxAw;

			public Guid KBeSAIfQuakWhKYXrKovLYpHcGg;

			public int WUtWdnEkcbOowTZyNYSAYqiqIsk;

			public int rdAiJgjkWhiEydzQBaCRfzCVRNHM;

			public int sTzXfOyWCNXZCDYOkqgPDWeTHnP;

			public int HtrgaJBhAduArjOzMjluWSwCPBqi;

			public int dueoAnsXDyCXiTcKgFRIJGbwAJdQ;

			public int qfxfzVJncFGzpqWHPKYOQjSrVSc;

			public bool AvKwFYrqAOInEkZZEMUJxDwiNdn;

			public bool QdqhDkpVZKgyndwhadmFgJdPnvx(xhJrHyyHHQLYujqCJSgxyNWlCnjK P_0, dxrsWETyvdhCMttxWrrNbSUXOzU P_1)
			{
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
				if (dueoAnsXDyCXiTcKgFRIJGbwAJdQ != P_0.dueoAnsXDyCXiTcKgFRIJGbwAJdQ)
				{
					return false;
				}
				if (qfxfzVJncFGzpqWHPKYOQjSrVSc != P_0.qfxfzVJncFGzpqWHPKYOQjSrVSc)
				{
					return false;
				}
				if (AvKwFYrqAOInEkZZEMUJxDwiNdn != P_0.AvKwFYrqAOInEkZZEMUJxDwiNdn)
				{
					return false;
				}
				if (P_0.rewiredId == OyDnkOlVbHfuMnCTJaxdfguHXtY)
				{
					return true;
				}
				return P_1 switch
				{
					dxrsWETyvdhCMttxWrrNbSUXOzU.vwOfhEYipyOtQiesBaMULwuTJjR => UInlkenejuBpngBMzEcVuFHmxAw == P_0.instanceGuid, 
					dxrsWETyvdhCMttxWrrNbSUXOzU.PxAZUthBoqKstLGGPnsAsvkTrpD => KBeSAIfQuakWhKYXrKovLYpHcGg == P_0.KBeSAIfQuakWhKYXrKovLYpHcGg, 
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
				text = string.Concat(obj7, "hardwareHatCount = ", HtrgaJBhAduArjOzMjluWSwCPBqi, "\n");
				object obj8 = text;
				text = string.Concat(obj8, "gameButtonCount = ", dueoAnsXDyCXiTcKgFRIJGbwAJdQ, "\n");
				object obj9 = text;
				text = string.Concat(obj9, "gameAxisCount = ", qfxfzVJncFGzpqWHPKYOQjSrVSc, "\n");
				object obj10 = text;
				return string.Concat(obj10, "hasDriver = ", AvKwFYrqAOInEkZZEMUJxDwiNdn, "\n");
			}
		}

		private List<XgyePKUdLhtBDCodhtUDMPjLCMb> hMhaWfYUetzpHHbonWijivkdKiW;

		public WeCbTLfYgNYSCuupGxKGOLUkciRz()
		{
			hMhaWfYUetzpHHbonWijivkdKiW = new List<XgyePKUdLhtBDCodhtUDMPjLCMb>();
		}

		public void tJzVKzbFmLbtbkPtOJIPqoQXsJj(xhJrHyyHHQLYujqCJSgxyNWlCnjK P_0)
		{
			if (P_0 == null)
			{
				return;
			}
			int count = hMhaWfYUetzpHHbonWijivkdKiW.Count;
			for (int i = 0; i < count; i++)
			{
				if (hMhaWfYUetzpHHbonWijivkdKiW[i].QdqhDkpVZKgyndwhadmFgJdPnvx(P_0, dxrsWETyvdhCMttxWrrNbSUXOzU.vwOfhEYipyOtQiesBaMULwuTJjR))
				{
					hMhaWfYUetzpHHbonWijivkdKiW[i].OyDnkOlVbHfuMnCTJaxdfguHXtY = P_0.rewiredId;
					hMhaWfYUetzpHHbonWijivkdKiW[i].UInlkenejuBpngBMzEcVuFHmxAw = P_0.instanceGuid;
					hMhaWfYUetzpHHbonWijivkdKiW[i].KBeSAIfQuakWhKYXrKovLYpHcGg = P_0.KBeSAIfQuakWhKYXrKovLYpHcGg;
					hMhaWfYUetzpHHbonWijivkdKiW[i].WUtWdnEkcbOowTZyNYSAYqiqIsk = P_0.inputManagerId;
					hMhaWfYUetzpHHbonWijivkdKiW[i].rdAiJgjkWhiEydzQBaCRfzCVRNHM = P_0.rdAiJgjkWhiEydzQBaCRfzCVRNHM;
					hMhaWfYUetzpHHbonWijivkdKiW[i].sTzXfOyWCNXZCDYOkqgPDWeTHnP = P_0.sTzXfOyWCNXZCDYOkqgPDWeTHnP;
					hMhaWfYUetzpHHbonWijivkdKiW[i].HtrgaJBhAduArjOzMjluWSwCPBqi = P_0.HtrgaJBhAduArjOzMjluWSwCPBqi;
					hMhaWfYUetzpHHbonWijivkdKiW[i].dueoAnsXDyCXiTcKgFRIJGbwAJdQ = P_0.dueoAnsXDyCXiTcKgFRIJGbwAJdQ;
					hMhaWfYUetzpHHbonWijivkdKiW[i].qfxfzVJncFGzpqWHPKYOQjSrVSc = P_0.qfxfzVJncFGzpqWHPKYOQjSrVSc;
					hMhaWfYUetzpHHbonWijivkdKiW[i].AvKwFYrqAOInEkZZEMUJxDwiNdn = P_0.AvKwFYrqAOInEkZZEMUJxDwiNdn;
					PBzEvOTDzimlgqgULUtqaLYjbAF(P_0.rewiredId, P_0.instanceGuid, i);
					return;
				}
			}
			hMhaWfYUetzpHHbonWijivkdKiW.Add(new XgyePKUdLhtBDCodhtUDMPjLCMb
			{
				OyDnkOlVbHfuMnCTJaxdfguHXtY = P_0.rewiredId,
				UInlkenejuBpngBMzEcVuFHmxAw = P_0.instanceGuid,
				KBeSAIfQuakWhKYXrKovLYpHcGg = P_0.KBeSAIfQuakWhKYXrKovLYpHcGg,
				WUtWdnEkcbOowTZyNYSAYqiqIsk = P_0.inputManagerId,
				rdAiJgjkWhiEydzQBaCRfzCVRNHM = P_0.rdAiJgjkWhiEydzQBaCRfzCVRNHM,
				sTzXfOyWCNXZCDYOkqgPDWeTHnP = P_0.sTzXfOyWCNXZCDYOkqgPDWeTHnP,
				HtrgaJBhAduArjOzMjluWSwCPBqi = P_0.HtrgaJBhAduArjOzMjluWSwCPBqi,
				dueoAnsXDyCXiTcKgFRIJGbwAJdQ = P_0.dueoAnsXDyCXiTcKgFRIJGbwAJdQ,
				qfxfzVJncFGzpqWHPKYOQjSrVSc = P_0.qfxfzVJncFGzpqWHPKYOQjSrVSc,
				AvKwFYrqAOInEkZZEMUJxDwiNdn = P_0.AvKwFYrqAOInEkZZEMUJxDwiNdn
			});
			PBzEvOTDzimlgqgULUtqaLYjbAF(P_0.rewiredId, P_0.instanceGuid, hMhaWfYUetzpHHbonWijivkdKiW.Count - 1);
		}

		public bool GhknXgQlkVQpCeAlkfPWNFpELSm(xhJrHyyHHQLYujqCJSgxyNWlCnjK P_0, dxrsWETyvdhCMttxWrrNbSUXOzU P_1)
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

		public IEnumerable<XgyePKUdLhtBDCodhtUDMPjLCMb> kVbYiwIwEyRBOVIjRkdFFmyOTNz(xhJrHyyHHQLYujqCJSgxyNWlCnjK P_0, dxrsWETyvdhCMttxWrrNbSUXOzU P_1)
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

	private RsVeIRZnmCozInvuVtbXAPKPjeyA kshxMxHAgRziwVCbzmgfJlWuXby;

	private List<xhJrHyyHHQLYujqCJSgxyNWlCnjK> MYIilGlzGtMSBPimluqBFDXADRJ;

	private int loHxsPzTnMgHxGoyDcWpTtzNQnO;

	private WeCbTLfYgNYSCuupGxKGOLUkciRz FATxLzcXldiDnUItlRTPAJuORDM;

	private bool kVDfJThkeGwTSHhStQtVTudtJBXD;

	private TimerRealTime XGUEehzhVvcIeAdTFNVkrDxzoqm;

	private global::PraFXApEzKrfLjKmeJGBIrwNdsGd<bool> TxOuahQkabUPnBodDAuqevjMgpfG;

	private global::PraFXApEzKrfLjKmeJGBIrwNdsGd<bool> kcoiUACBncevuyrKJkLfepispgtW;

	private int bPYIqtxYVbmGowUMiCDshAvlQYt;

	private int YoFcOFrjxhCCqgjmFqdBNCYGPLM;

	private ConfigVars QxJGAIdIaYwUdmeAotwGjhMlngRb;

	private bool uGlRgnZIMzNMfAWVtsRmeydggPR;

	private Action<int, ControllerDataUpdater> UnhEVuhJFUEnfAsRXUSCacwcngnY;

	private PlatformInputManager GRPphNqBvejBLpdEjHfuUeLKHeo;

	private readonly XDeDuePBuHGGFsspnAzWcBdsCZTB QLEazHgGtbKbEcYYfafIPIMIjvbw;

	private readonly xzvsFEmOigBoTAImyDAGzDeOvoX ZaxbqErnRbaYGABuDMJBIUTGadhe;

	private readonly bool bERdxQEMngIKTcdezlFBctUJBera;

	private readonly bool ZSJeoeAgfltDyiGQZOstfnhVwtkF;

	private readonly bool iIwUOirxOAPopNHowMFDfsCjcgB;

	private readonly Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> rpvCjQaePXpGswKHxhwfamxRDIu;

	private readonly Func<int> ilAOFbKaMpyqndLrycyBBEQAMvEC;

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
	public override IInputSource inputSource => kshxMxHAgRziwVCbzmgfJlWuXby;

	[CustomObfuscation(rename = false)]
	public override InputSource inputSourceType => InputSource.RawInput;

	public PVHplNLarjGPjadzMDzXAgLHfzpK(ConfigVars configVars, bool useXInput, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId, bool handleJoysticks, bool handleUnifiedMouse, bool handleUnifiedKeyboard, bool useCustomDrivers)
	{
		try
		{
			QxJGAIdIaYwUdmeAotwGjhMlngRb = configVars;
			uGlRgnZIMzNMfAWVtsRmeydggPR = useXInput;
			rpvCjQaePXpGswKHxhwfamxRDIu = getHardwareJoystickMap_InputManager;
			ilAOFbKaMpyqndLrycyBBEQAMvEC = getNewJoystickId;
			bERdxQEMngIKTcdezlFBctUJBera = handleJoysticks;
			ZSJeoeAgfltDyiGQZOstfnhVwtkF = handleUnifiedMouse;
			iIwUOirxOAPopNHowMFDfsCjcgB = handleUnifiedKeyboard;
			GRPphNqBvejBLpdEjHfuUeLKHeo = this;
			UpdateLoopSetting updateLoop = configVars.updateLoop;
			if (handleUnifiedKeyboard)
			{
				ZaxbqErnRbaYGABuDMJBIUTGadhe = new xzvsFEmOigBoTAImyDAGzDeOvoX(updateLoop);
			}
			if (handleUnifiedMouse)
			{
				QLEazHgGtbKbEcYYfafIPIMIjvbw = new XDeDuePBuHGGFsspnAzWcBdsCZTB(updateLoop);
			}
			kshxMxHAgRziwVCbzmgfJlWuXby = new RsVeIRZnmCozInvuVtbXAPKPjeyA(configVars, handleJoysticks, useCustomDrivers, QLEazHgGtbKbEcYYfafIPIMIjvbw, ZaxbqErnRbaYGABuDMJBIUTGadhe);
			UnhEVuhJFUEnfAsRXUSCacwcngnY = UpdateControllerData;
			TxOuahQkabUPnBodDAuqevjMgpfG = new global::PraFXApEzKrfLjKmeJGBIrwNdsGd<bool>(useSharedThread: true, TEeCuhCMvpStgApRIpJvtadkDBup);
			kcoiUACBncevuyrKJkLfepispgtW = new global::PraFXApEzKrfLjKmeJGBIrwNdsGd<bool>(useSharedThread: true, kshxMxHAgRziwVCbzmgfJlWuXby.IZkZusjYYXgkLoXXuWHYixfqKRQ);
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
		if (bERdxQEMngIKTcdezlFBctUJBera)
		{
			FATxLzcXldiDnUItlRTPAJuORDM = new WeCbTLfYgNYSCuupGxKGOLUkciRz();
			XGUEehzhVvcIeAdTFNVkrDxzoqm = new TimerRealTime(1.0);
			XGUEehzhVvcIeAdTFNVkrDxzoqm.Start();
			WdJQAvAvlcMwhYQEBmFYuSUKhPM();
		}
	}

	[CustomObfuscation(rename = false)]
	public override void Update(UpdateLoopType updateLoop)
	{
		if (bERdxQEMngIKTcdezlFBctUJBera)
		{
			AKsHxPSabRvnbiwYkULztlwxyno();
		}
		if (kshxMxHAgRziwVCbzmgfJlWuXby != null)
		{
			kshxMxHAgRziwVCbzmgfJlWuXby.Update();
		}
		lVRAeEubyuRQhRJWTDKYJvxzBamF();
		if (bERdxQEMngIKTcdezlFBctUJBera)
		{
			if (kshxMxHAgRziwVCbzmgfJlWuXby != null)
			{
				kshxMxHAgRziwVCbzmgfJlWuXby.UpdateDevices(updateLoop);
			}
			zmiSfwPHwVrmRSdAAPoYwaeqKjX();
			if (kshxMxHAgRziwVCbzmgfJlWuXby != null)
			{
				kshxMxHAgRziwVCbzmgfJlWuXby.UpdateFinished();
			}
		}
		if (ZSJeoeAgfltDyiGQZOstfnhVwtkF)
		{
			QLEazHgGtbKbEcYYfafIPIMIjvbw.EBZMKoSknSfzkSfokUzktanzxJf(updateLoop);
		}
		if (iIwUOirxOAPopNHowMFDfsCjcgB)
		{
			ZaxbqErnRbaYGABuDMJBIUTGadhe.EBZMKoSknSfzkSfokUzktanzxJf(updateLoop);
		}
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
		if (MYIilGlzGtMSBPimluqBFDXADRJ != null)
		{
			int count = MYIilGlzGtMSBPimluqBFDXADRJ.Count;
			for (int i = 0; i < count; i++)
			{
				if (MYIilGlzGtMSBPimluqBFDXADRJ[i] != null)
				{
					MYIilGlzGtMSBPimluqBFDXADRJ[i].PMzamCeIIFqnzgwGlxEbIeTHBFUL();
				}
			}
		}
		if (ZaxbqErnRbaYGABuDMJBIUTGadhe != null)
		{
			ZaxbqErnRbaYGABuDMJBIUTGadhe.Dispose();
		}
		if (QLEazHgGtbKbEcYYfafIPIMIjvbw != null)
		{
			QLEazHgGtbKbEcYYfafIPIMIjvbw.Dispose();
		}
		if (kshxMxHAgRziwVCbzmgfJlWuXby != null)
		{
			kshxMxHAgRziwVCbzmgfJlWuXby.Dispose();
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
		if (!bERdxQEMngIKTcdezlFBctUJBera)
		{
			return;
		}
		for (int i = 0; i < loHxsPzTnMgHxGoyDcWpTtzNQnO; i++)
		{
			if (MYIilGlzGtMSBPimluqBFDXADRJ[i].inputManagerId == inputManagerId)
			{
				MYIilGlzGtMSBPimluqBFDXADRJ[i].FillData(data);
				return;
			}
		}
		Logger.LogError("Invalid joystick Id " + inputManagerId + "!");
	}

	[CustomObfuscation(rename = false)]
	public override void SystemDeviceConnected()
	{
		kshxMxHAgRziwVCbzmgfJlWuXby.SystemDeviceConnected();
		kVDfJThkeGwTSHhStQtVTudtJBXD = true;
		if (bERdxQEMngIKTcdezlFBctUJBera)
		{
			XGUEehzhVvcIeAdTFNVkrDxzoqm.Start();
		}
		if (iIwUOirxOAPopNHowMFDfsCjcgB)
		{
			ZaxbqErnRbaYGABuDMJBIUTGadhe.MlHrxkPdRhzTRtMsoFxLakiJNnhv(true);
		}
		if (ZSJeoeAgfltDyiGQZOstfnhVwtkF)
		{
			QLEazHgGtbKbEcYYfafIPIMIjvbw.MlHrxkPdRhzTRtMsoFxLakiJNnhv(true);
		}
		if (_SystemDeviceConnectedEvent != null)
		{
			_SystemDeviceConnectedEvent();
		}
	}

	[CustomObfuscation(rename = false)]
	public override void SystemDeviceDisconnected()
	{
		kshxMxHAgRziwVCbzmgfJlWuXby.SystemDeviceDisconnected();
		kVDfJThkeGwTSHhStQtVTudtJBXD = true;
		if (bERdxQEMngIKTcdezlFBctUJBera)
		{
			XGUEehzhVvcIeAdTFNVkrDxzoqm.Start();
		}
		if (iIwUOirxOAPopNHowMFDfsCjcgB)
		{
			ZaxbqErnRbaYGABuDMJBIUTGadhe.MlHrxkPdRhzTRtMsoFxLakiJNnhv(false);
		}
		if (ZSJeoeAgfltDyiGQZOstfnhVwtkF)
		{
			QLEazHgGtbKbEcYYfafIPIMIjvbw.MlHrxkPdRhzTRtMsoFxLakiJNnhv(false);
		}
		if (_SystemDeviceDisconnectedEvent != null)
		{
			_SystemDeviceDisconnectedEvent();
		}
	}

	[CustomObfuscation(rename = false)]
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId)
	{
		_ = bERdxQEMngIKTcdezlFBctUJBera;
	}

	[CustomObfuscation(rename = false)]
	public override IUnifiedMouseSource GetUnifiedMouseSource()
	{
		return QLEazHgGtbKbEcYYfafIPIMIjvbw;
	}

	[CustomObfuscation(rename = false)]
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource()
	{
		return ZaxbqErnRbaYGABuDMJBIUTGadhe;
	}

	public void BcqkVlPOBxPuJKSJNPWkUqCoTvT(EewfJPiHasEmIcMTTMpQEfUhPRej P_0, DyFiWUvcefuGqAjWbnTJbGBhzSo P_1)
	{
	}

	private void AKsHxPSabRvnbiwYkULztlwxyno()
	{
		if (TxOuahQkabUPnBodDAuqevjMgpfG.bgLAKkuspNIyPudbNgPBgmqQVpJG)
		{
			if (TxOuahQkabUPnBodDAuqevjMgpfG.bXUJACnaYvOCANYOaVrTdSwcZxj() && !XGUEehzhVvcIeAdTFNVkrDxzoqm.running && !kcoiUACBncevuyrKJkLfepispgtW.bgLAKkuspNIyPudbNgPBgmqQVpJG)
			{
				if (TxOuahQkabUPnBodDAuqevjMgpfG.GWOwgIzmyVWsoVjleBNCERdBoQa)
				{
					kVDfJThkeGwTSHhStQtVTudtJBXD = true;
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

	private void WdJQAvAvlcMwhYQEBmFYuSUKhPM()
	{
		WdJQAvAvlcMwhYQEBmFYuSUKhPM(ZQHZYiLLQRltqqcrBygNvmuVjPo());
	}

	private void WdJQAvAvlcMwhYQEBmFYuSUKhPM(IList<KXNanfFdezOfVOeIdsOvMHQobbRn> P_0)
	{
		int num = 0;
		List<xhJrHyyHHQLYujqCJSgxyNWlCnjK> mYIilGlzGtMSBPimluqBFDXADRJ = MYIilGlzGtMSBPimluqBFDXADRJ;
		int num2 = loHxsPzTnMgHxGoyDcWpTtzNQnO;
		MYIilGlzGtMSBPimluqBFDXADRJ = new List<xhJrHyyHHQLYujqCJSgxyNWlCnjK>();
		bPYIqtxYVbmGowUMiCDshAvlQYt = 0;
		List<xhJrHyyHHQLYujqCJSgxyNWlCnjK> list = new List<xhJrHyyHHQLYujqCJSgxyNWlCnjK>();
		for (int num3 = num2 - 1; num3 >= 0; num3--)
		{
			if (mYIilGlzGtMSBPimluqBFDXADRJ[num3] != null && !mYIilGlzGtMSBPimluqBFDXADRJ[num3].jYuOzlJtihpWwRTDsuTZYrbfQmE)
			{
				list.Add(mYIilGlzGtMSBPimluqBFDXADRJ[num3]);
				mYIilGlzGtMSBPimluqBFDXADRJ.RemoveAt(num3);
			}
		}
		num2 = mYIilGlzGtMSBPimluqBFDXADRJ?.Count ?? 0;
		int count = P_0.Count;
		for (int i = 0; i < count; i++)
		{
			if (P_0[i] == null)
			{
				continue;
			}
			KXNanfFdezOfVOeIdsOvMHQobbRn kXNanfFdezOfVOeIdsOvMHQobbRn = P_0[i];
			if (kXNanfFdezOfVOeIdsOvMHQobbRn != null)
			{
				xhJrHyyHHQLYujqCJSgxyNWlCnjK xhJrHyyHHQLYujqCJSgxyNWlCnjK = new xhJrHyyHHQLYujqCJSgxyNWlCnjK(kXNanfFdezOfVOeIdsOvMHQobbRn, kXNanfFdezOfVOeIdsOvMHQobbRn.yrBKgxgwtsXACurkrpnBjVvVoyl, rpvCjQaePXpGswKHxhwfamxRDIu);
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.kmlrVkJoHAiVknTEjxTfehHxMGP = kXNanfFdezOfVOeIdsOvMHQobbRn.mXqEWIlGwHZPoKjhftGIspoptJq;
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.awueIOZppSsgBYIKhhnLggaAZAn = kXNanfFdezOfVOeIdsOvMHQobbRn.OrRFBEhjniNFYjbjMjbVqBtWjOHD;
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.UjlLMcJBUCEjQCPTUCFwbFmHYQxE = kXNanfFdezOfVOeIdsOvMHQobbRn.OrRFBEhjniNFYjbjMjbVqBtWjOHD;
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.enrHFMRQgCWUTcGBWcZaPNsNxwT = kXNanfFdezOfVOeIdsOvMHQobbRn.dtMtLyAEDljqqsSOiaBeXhtoXUH;
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.nWFtSCRFEzwWJAlKCuDmeqSLzvS = kXNanfFdezOfVOeIdsOvMHQobbRn.LLWNXygzETOTnJQyBltZKpktGJs;
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.XEcyhhhJkxUMgVxECvasAHFnuwD = kXNanfFdezOfVOeIdsOvMHQobbRn.XVuHkKcnbaTxiTZvxKQBLJaCehD;
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.qNPHPpgvRQEdsxgBWqwsRIjHSq = kXNanfFdezOfVOeIdsOvMHQobbRn.nyGmXtdUMFOjsJGtySPQenWHxwN;
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.rdAiJgjkWhiEydzQBaCRfzCVRNHM = kXNanfFdezOfVOeIdsOvMHQobbRn.sUizFAHmyIDvjcdULcHAokTPxOo;
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.sTzXfOyWCNXZCDYOkqgPDWeTHnP = kXNanfFdezOfVOeIdsOvMHQobbRn.nhlHpZITRUjXvMxgnPukLkSwoEV;
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.HtrgaJBhAduArjOzMjluWSwCPBqi = kXNanfFdezOfVOeIdsOvMHQobbRn.BzboSoxCQIbRyFecbRupUypRPUE;
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.ElGbwvcoyOUnEXwgQgFRFCxZUkkb = false;
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.ZQJxEMiMjNdHQmVWxDtDCRrFHpRh = kXNanfFdezOfVOeIdsOvMHQobbRn.cjOWzBCMkHIxRWceNYEqTjupNms;
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.FfbgQkFEOHvMYGENpNQWUtsUWFC = kXNanfFdezOfVOeIdsOvMHQobbRn.AhHrqrQkLzCLgDcoKPqTNKyjQNgv;
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.mUncBBKjUAbEBhJbCqRQJvpQDWom = kXNanfFdezOfVOeIdsOvMHQobbRn.aopAguzVfxvEKIwhDMhrQjSkhKX;
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.pIfHtthDGBGwKzxQqqRIDOZlHWV = kXNanfFdezOfVOeIdsOvMHQobbRn.IyeVZxyGhmfqMIZajBFUPuzNtsM;
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.extension = kXNanfFdezOfVOeIdsOvMHQobbRn.kkfxdZagPkvTpYnlFlBTkZZMvfD;
				kXNanfFdezOfVOeIdsOvMHQobbRn.OqhfOnkBvpKzLuKYYPKRUvpiUrOF();
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.iZnBUcZPCYZUOuauoTTqYipxzmI();
				MYIilGlzGtMSBPimluqBFDXADRJ.Add(xhJrHyyHHQLYujqCJSgxyNWlCnjK);
				num++;
				if (xhJrHyyHHQLYujqCJSgxyNWlCnjK.ZQJxEMiMjNdHQmVWxDtDCRrFHpRh)
				{
					bPYIqtxYVbmGowUMiCDshAvlQYt++;
				}
			}
		}
		loHxsPzTnMgHxGoyDcWpTtzNQnO = num;
		EeIuYvQhmSRZqiNcnKnGCxRWVku(num2, num, mYIilGlzGtMSBPimluqBFDXADRJ, MYIilGlzGtMSBPimluqBFDXADRJ);
		for (int j = 0; j < num; j++)
		{
			if (_UpdateControllerInfoEvent != null)
			{
				_UpdateControllerInfoEvent(new UpdateControllerInfoEventArgs(MYIilGlzGtMSBPimluqBFDXADRJ[j]));
			}
		}
		list.ForEach(delegate(xhJrHyyHHQLYujqCJSgxyNWlCnjK P_0)
		{
			vgdgoCexCwvDPdTnoaGlarCzHePe(P_0, false);
		});
		RPDdEqlBagdPQQsCXgjiZWIMRVB(mYIilGlzGtMSBPimluqBFDXADRJ, MYIilGlzGtMSBPimluqBFDXADRJ, false);
		RPDdEqlBagdPQQsCXgjiZWIMRVB(MYIilGlzGtMSBPimluqBFDXADRJ, mYIilGlzGtMSBPimluqBFDXADRJ, true);
	}

	private void zmiSfwPHwVrmRSdAAPoYwaeqKjX()
	{
		for (int i = 0; i < loHxsPzTnMgHxGoyDcWpTtzNQnO; i++)
		{
			xhJrHyyHHQLYujqCJSgxyNWlCnjK xhJrHyyHHQLYujqCJSgxyNWlCnjK = MYIilGlzGtMSBPimluqBFDXADRJ[i];
			if (xhJrHyyHHQLYujqCJSgxyNWlCnjK != null && (!uGlRgnZIMzNMfAWVtsRmeydggPR || !xhJrHyyHHQLYujqCJSgxyNWlCnjK.ElGbwvcoyOUnEXwgQgFRFCxZUkkb))
			{
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.Update();
			}
		}
	}

	private bool OSjZQlsjtWjjULblHOgvsjwZwLn(gChgGxyRrVUYhHHtgkUFLhNTvGO P_0)
	{
		try
		{
			return P_0.juJWqvRsbSxoEnvwjiYrRthoEMx();
		}
		catch
		{
			return false;
		}
	}

	private IList<KXNanfFdezOfVOeIdsOvMHQobbRn> ZQHZYiLLQRltqqcrBygNvmuVjPo()
	{
		return kshxMxHAgRziwVCbzmgfJlWuXby.GetJoysticks<KXNanfFdezOfVOeIdsOvMHQobbRn>();
	}

	private void EeIuYvQhmSRZqiNcnKnGCxRWVku(int P_0, int P_1, List<xhJrHyyHHQLYujqCJSgxyNWlCnjK> P_2, List<xhJrHyyHHQLYujqCJSgxyNWlCnjK> P_3)
	{
		if (P_1 > 0)
		{
			P_3.Sort(xhJrHyyHHQLYujqCJSgxyNWlCnjK.ExjTEObjHqlevKjXuhIEFSCUmsH);
		}
		if (P_0 > 0 && P_1 > 0)
		{
			OMYBfwtZZUdWKVEriFHivmoUKvI(P_1, P_3, P_0, P_2, WeCbTLfYgNYSCuupGxKGOLUkciRz.dxrsWETyvdhCMttxWrrNbSUXOzU.vwOfhEYipyOtQiesBaMULwuTJjR);
		}
		IvQeJDKJktPbHepRiTImDJaYBsFO(P_1, P_3, WeCbTLfYgNYSCuupGxKGOLUkciRz.dxrsWETyvdhCMttxWrrNbSUXOzU.vwOfhEYipyOtQiesBaMULwuTJjR);
		for (int i = 0; i < P_1; i++)
		{
			xhJrHyyHHQLYujqCJSgxyNWlCnjK xhJrHyyHHQLYujqCJSgxyNWlCnjK = P_3[i];
			if (xhJrHyyHHQLYujqCJSgxyNWlCnjK != null && xhJrHyyHHQLYujqCJSgxyNWlCnjK.inputManagerId < 0)
			{
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.inputManagerId = zPoCmfMnwfqtZwKNhlzPHZDbZWe(P_3);
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.rewiredId = ilAOFbKaMpyqndLrycyBBEQAMvEC();
				FATxLzcXldiDnUItlRTPAJuORDM.tJzVKzbFmLbtbkPtOJIPqoQXsJj(xhJrHyyHHQLYujqCJSgxyNWlCnjK);
			}
		}
		P_3.Sort(xhJrHyyHHQLYujqCJSgxyNWlCnjK.OoPvRsOhPSBhUDBjOWyqfJWZamP);
	}

	private void zKvLaOvdCFSGsSNlDLWcbrwtKVw(List<xhJrHyyHHQLYujqCJSgxyNWlCnjK> P_0, int P_1, int P_2)
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

	private bool AjBmLDSFXqEyPzqFqJamwkrBg(List<xhJrHyyHHQLYujqCJSgxyNWlCnjK> P_0, int P_1)
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

	private int zPoCmfMnwfqtZwKNhlzPHZDbZWe(List<xhJrHyyHHQLYujqCJSgxyNWlCnjK> P_0)
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

	private bool bgNHiSCBOuTUFKSAzvcDoOxcFWB(List<xhJrHyyHHQLYujqCJSgxyNWlCnjK> P_0, int P_1)
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

	private void OMYBfwtZZUdWKVEriFHivmoUKvI(int P_0, List<xhJrHyyHHQLYujqCJSgxyNWlCnjK> P_1, int P_2, List<xhJrHyyHHQLYujqCJSgxyNWlCnjK> P_3, WeCbTLfYgNYSCuupGxKGOLUkciRz.dxrsWETyvdhCMttxWrrNbSUXOzU P_4)
	{
		int num = ((P_4 != 0) ? 1 : 2);
		for (int i = 0; i < P_0; i++)
		{
			xhJrHyyHHQLYujqCJSgxyNWlCnjK xhJrHyyHHQLYujqCJSgxyNWlCnjK = P_1[i];
			if (xhJrHyyHHQLYujqCJSgxyNWlCnjK == null || xhJrHyyHHQLYujqCJSgxyNWlCnjK.inputManagerId >= 0)
			{
				continue;
			}
			for (int j = 0; j < P_2; j++)
			{
				xhJrHyyHHQLYujqCJSgxyNWlCnjK xhJrHyyHHQLYujqCJSgxyNWlCnjK2 = P_3[j];
				if (xhJrHyyHHQLYujqCJSgxyNWlCnjK2 != null && !bgNHiSCBOuTUFKSAzvcDoOxcFWB(P_1, xhJrHyyHHQLYujqCJSgxyNWlCnjK2.rewiredId) && xhJrHyyHHQLYujqCJSgxyNWlCnjK.QdqhDkpVZKgyndwhadmFgJdPnvx(xhJrHyyHHQLYujqCJSgxyNWlCnjK2) >= num)
				{
					xhJrHyyHHQLYujqCJSgxyNWlCnjK.mBTEWwhZTVXHADiOGGiZHrhHDFU(xhJrHyyHHQLYujqCJSgxyNWlCnjK2);
					FATxLzcXldiDnUItlRTPAJuORDM.tJzVKzbFmLbtbkPtOJIPqoQXsJj(xhJrHyyHHQLYujqCJSgxyNWlCnjK);
				}
			}
		}
	}

	private void IvQeJDKJktPbHepRiTImDJaYBsFO(int P_0, List<xhJrHyyHHQLYujqCJSgxyNWlCnjK> P_1, WeCbTLfYgNYSCuupGxKGOLUkciRz.dxrsWETyvdhCMttxWrrNbSUXOzU P_2)
	{
		for (int i = 0; i < P_0; i++)
		{
			xhJrHyyHHQLYujqCJSgxyNWlCnjK xhJrHyyHHQLYujqCJSgxyNWlCnjK = P_1[i];
			if (xhJrHyyHHQLYujqCJSgxyNWlCnjK == null || xhJrHyyHHQLYujqCJSgxyNWlCnjK.inputManagerId >= 0)
			{
				continue;
			}
			WeCbTLfYgNYSCuupGxKGOLUkciRz.XgyePKUdLhtBDCodhtUDMPjLCMb xgyePKUdLhtBDCodhtUDMPjLCMb = null;
			foreach (WeCbTLfYgNYSCuupGxKGOLUkciRz.XgyePKUdLhtBDCodhtUDMPjLCMb item in FATxLzcXldiDnUItlRTPAJuORDM.kVbYiwIwEyRBOVIjRkdFFmyOTNz(xhJrHyyHHQLYujqCJSgxyNWlCnjK, P_2))
			{
				if (!bgNHiSCBOuTUFKSAzvcDoOxcFWB(P_1, item.OyDnkOlVbHfuMnCTJaxdfguHXtY) && item.WUtWdnEkcbOowTZyNYSAYqiqIsk >= 0)
				{
					xgyePKUdLhtBDCodhtUDMPjLCMb = item;
					break;
				}
			}
			if (xgyePKUdLhtBDCodhtUDMPjLCMb != null)
			{
				int num = xgyePKUdLhtBDCodhtUDMPjLCMb.WUtWdnEkcbOowTZyNYSAYqiqIsk;
				if (!AjBmLDSFXqEyPzqFqJamwkrBg(P_1, num))
				{
					num = (xgyePKUdLhtBDCodhtUDMPjLCMb.WUtWdnEkcbOowTZyNYSAYqiqIsk = zPoCmfMnwfqtZwKNhlzPHZDbZWe(P_1));
				}
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.inputManagerId = num;
				xhJrHyyHHQLYujqCJSgxyNWlCnjK.rewiredId = xgyePKUdLhtBDCodhtUDMPjLCMb.OyDnkOlVbHfuMnCTJaxdfguHXtY;
				FATxLzcXldiDnUItlRTPAJuORDM.tJzVKzbFmLbtbkPtOJIPqoQXsJj(xhJrHyyHHQLYujqCJSgxyNWlCnjK);
			}
		}
	}

	private void lVRAeEubyuRQhRJWTDKYJvxzBamF()
	{
		if (kshxMxHAgRziwVCbzmgfJlWuXby.EchuHkSOHaqDACgFGkRkZDjBkNy(true))
		{
			kVDfJThkeGwTSHhStQtVTudtJBXD = true;
		}
		if (kVDfJThkeGwTSHhStQtVTudtJBXD)
		{
			jzWWMxJsJTaGwCQISiwXcqMzXklR();
		}
		if (bERdxQEMngIKTcdezlFBctUJBera && kcoiUACBncevuyrKJkLfepispgtW.bgLAKkuspNIyPudbNgPBgmqQVpJG && kcoiUACBncevuyrKJkLfepispgtW.bXUJACnaYvOCANYOaVrTdSwcZxj())
		{
			SOTIqsKhbfvRbDbUarlymqitvYq();
		}
	}

	private void jzWWMxJsJTaGwCQISiwXcqMzXklR()
	{
		kVDfJThkeGwTSHhStQtVTudtJBXD = false;
		if (!kcoiUACBncevuyrKJkLfepispgtW.bgLAKkuspNIyPudbNgPBgmqQVpJG)
		{
			kshxMxHAgRziwVCbzmgfJlWuXby.BVltvFgdpKRuuHZyAOlJbTkVDuZ();
			kcoiUACBncevuyrKJkLfepispgtW.UBdDYFzJEaQOUTjUSMwjsblQggo();
		}
	}

	private void SOTIqsKhbfvRbDbUarlymqitvYq()
	{
		kshxMxHAgRziwVCbzmgfJlWuXby.mMxswVERpzWiDjcfWExqXqDIqqA();
		if (bERdxQEMngIKTcdezlFBctUJBera)
		{
			IList<KXNanfFdezOfVOeIdsOvMHQobbRn> list = ZQHZYiLLQRltqqcrBygNvmuVjPo();
			if (xPWYINmsCfqOgdDnchRrOMNwuJj(list))
			{
				WdJQAvAvlcMwhYQEBmFYuSUKhPM(list);
			}
		}
	}

	private bool xPWYINmsCfqOgdDnchRrOMNwuJj(IList<KXNanfFdezOfVOeIdsOvMHQobbRn> P_0)
	{
		for (int i = 0; i < MYIilGlzGtMSBPimluqBFDXADRJ.Count; i++)
		{
			if (MYIilGlzGtMSBPimluqBFDXADRJ[i] != null && !MYIilGlzGtMSBPimluqBFDXADRJ[i].jYuOzlJtihpWwRTDsuTZYrbfQmE)
			{
				return true;
			}
		}
		int count = P_0.Count;
		for (int j = 0; j < count; j++)
		{
			if (P_0[j] != null && !sJrfbUJWzRlXGxjYfzRpYaLNqyu(P_0[j].mXqEWIlGwHZPoKjhftGIspoptJq))
			{
				return true;
			}
		}
		int count2 = MYIilGlzGtMSBPimluqBFDXADRJ.Count;
		for (int k = 0; k < count2; k++)
		{
			if (MYIilGlzGtMSBPimluqBFDXADRJ[k] != null && !TXpOYhQBUhUCqDnFGxmDUfVduUZ(P_0, MYIilGlzGtMSBPimluqBFDXADRJ[k].instanceGuid))
			{
				return true;
			}
		}
		return false;
	}

	private bool sJrfbUJWzRlXGxjYfzRpYaLNqyu(Guid P_0)
	{
		int count = MYIilGlzGtMSBPimluqBFDXADRJ.Count;
		for (int i = 0; i < count; i++)
		{
			if (MYIilGlzGtMSBPimluqBFDXADRJ[i] != null && MYIilGlzGtMSBPimluqBFDXADRJ[i].instanceGuid == P_0)
			{
				return true;
			}
		}
		return false;
	}

	private bool TXpOYhQBUhUCqDnFGxmDUfVduUZ(IList<KXNanfFdezOfVOeIdsOvMHQobbRn> P_0, Guid P_1)
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

	private void RPDdEqlBagdPQQsCXgjiZWIMRVB(List<xhJrHyyHHQLYujqCJSgxyNWlCnjK> P_0, List<xhJrHyyHHQLYujqCJSgxyNWlCnjK> P_1, bool P_2)
	{
		if (P_0 == null)
		{
			return;
		}
		int num = P_0?.Count ?? 0;
		int num2 = P_1?.Count ?? 0;
		for (int i = 0; i < num; i++)
		{
			xhJrHyyHHQLYujqCJSgxyNWlCnjK xhJrHyyHHQLYujqCJSgxyNWlCnjK = P_0[i];
			if (xhJrHyyHHQLYujqCJSgxyNWlCnjK == null)
			{
				continue;
			}
			bool flag = false;
			if (P_1 != null)
			{
				for (int j = 0; j < num2; j++)
				{
					xhJrHyyHHQLYujqCJSgxyNWlCnjK xhJrHyyHHQLYujqCJSgxyNWlCnjK2 = P_1[j];
					if (xhJrHyyHHQLYujqCJSgxyNWlCnjK2 != null && xhJrHyyHHQLYujqCJSgxyNWlCnjK.instanceGuid == xhJrHyyHHQLYujqCJSgxyNWlCnjK2.instanceGuid)
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

	private void vgdgoCexCwvDPdTnoaGlarCzHePe(xhJrHyyHHQLYujqCJSgxyNWlCnjK P_0, bool P_1)
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
		try
		{
			int num = 0;
			cZEAfFusPwtBncvnGcfLrVnBtky.BltnqxmiIvdSyCqPYnANAHSIvHzq(null, ref num, WdABqngzfChtFJSJGeObIpoDQOet.BSrOqfyRTTNMvjOTEoJRNXUWoPI<XejzeUvgutfbSkwWeQaFpJwCZEW>());
			if (YoFcOFrjxhCCqgjmFqdBNCYGPLM != num)
			{
				YoFcOFrjxhCCqgjmFqdBNCYGPLM = num;
				return true;
			}
		}
		catch (Exception ex)
		{
			Logger.Log("Exception getting Raw Input Device List.\n" + ex);
		}
		if (bPYIqtxYVbmGowUMiCDshAvlQYt > 0 && kshxMxHAgRziwVCbzmgfJlWuXby.ehMeFMHHieuObmRMYMhUegjgCRgC())
		{
			return true;
		}
		return false;
	}

	[Conditional("DEBUGTHIS")]
	private void XPeKiRzFXOxDRVcGroJuayahDUo(string P_0)
	{
		Logger.Log(P_0);
	}

	[CompilerGenerated]
	private void uOunMRKfsnmaRvcQhEacPlRLJTq(xhJrHyyHHQLYujqCJSgxyNWlCnjK P_0)
	{
		vgdgoCexCwvDPdTnoaGlarCzHePe(P_0, false);
	}
}
