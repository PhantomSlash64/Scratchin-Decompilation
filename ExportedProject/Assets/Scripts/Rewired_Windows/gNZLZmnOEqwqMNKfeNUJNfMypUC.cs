using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Rewired;
using Rewired.Config;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Libraries.SharpDX.XInput;
using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

internal class gNZLZmnOEqwqMNKfeNUJNfMypUC : PlatformInputManager
{
	private class IHKymFjiuOAWDftVknObotjRfvu : IDisposable, IInputManagerJoystick, IInputManagerJoystickPublic
	{
		private bool edxLkSKgSrFSxSJTtkxDkJziiWA;

		private int HDUfrfQaCtWbjEQjslQVHYtxamY;

		private readonly int XgttqEWgLatQKtTjzdTUVERleMvd;

		public Guid FbSmcmcVOWowuyUiagueSMvFgly;

		public string DcCSwoiCsPKVmzyhfFwghvYDsbp;

		public Guid kmlrVkJoHAiVknTEjxTfehHxMGP;

		public Rewired.Libraries.SharpDX.XInput.DeviceType WxVnkLFPWfCbnxtPfvHrJfxyDCx;

		public XInputDeviceSubType uEUQyyHHPDWVxiEMAuEGURvglkz;

		public bool mUncBBKjUAbEBhJbCqRQJvpQDWom;

		public bool xSzgsyIqdoqVvBLZfrMaBViRfbdy;

		public bool ycUGdCjZQhckbAkuclTQKcQUIVbc;

		public bool MIcFDKFmbcoLIWvmEwicNqnQGGHh;

		private int JUwazOFkydwVuIEENNzuHlTwjeP;

		private int IEPcCkkotYAaQYIjlAWcbfoCVCPY;

		private int rdAiJgjkWhiEydzQBaCRfzCVRNHM;

		private int sTzXfOyWCNXZCDYOkqgPDWeTHnP;

		private readonly float[] JdVEWmnshzhQhfQpWKygbxeaWPsN;

		private readonly bool[] zDdXRTONJmZUqqAiqtzcktIOAJw;

		private HardwareJoystickMap_InputManager FZCqfqZEBbHWoQxVVIkyNdAoiatI;

		public readonly fNgBoMIxVbPxaDHBzrikXjSCIPco qFTTgjZPRmbnvqCBGdmEDbfSPiSE;

		private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> rpvCjQaePXpGswKHxhwfamxRDIu;

		private Action xloHmAClPCRsuTNHGzllobzqsSv;

		private bool tuVLllvCFeToSgCnpYdwTjlfWUq;

		private bool RtEBtfhoklZnMgNMZfcTKWlNBQe;

		private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

		public string awueIOZppSsgBYIKhhnLggaAZAn
		{
			get
			{
				string productName = UjlLMcJBUCEjQCPTUCFwbFmHYQxE;
				if (productName == string.Empty)
				{
					return string.Empty;
				}
				return productName + " " + XgttqEWgLatQKtTjzdTUVERleMvd;
			}
		}

		public string UjlLMcJBUCEjQCPTUCFwbFmHYQxE
		{
			get
			{
				if (!lXFsjgWpSMizRNRJknYKAvVKfYm)
				{
					return string.Empty;
				}
				return uEUQyyHHPDWVxiEMAuEGURvglkz.ToString();
			}
		}

		public bool lXFsjgWpSMizRNRJknYKAvVKfYm
		{
			get
			{
				if (qFTTgjZPRmbnvqCBGdmEDbfSPiSE == null || !MIcFDKFmbcoLIWvmEwicNqnQGGHh)
				{
					return false;
				}
				if (tuVLllvCFeToSgCnpYdwTjlfWUq && !CKXxDkQUaSOMxwlDbJWLFEdgRcPY(QUIZKudlqAinLhGdIvvzESzJkmn.ZnIRZKHwOzRCMRozodrqGWdVYED))
				{
					ctMqQvkMqhbLKIxyJJkOEHFInSG();
				}
				return tuVLllvCFeToSgCnpYdwTjlfWUq;
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
		public int inputManagerId => XgttqEWgLatQKtTjzdTUVERleMvd;

		[CustomObfuscation(rename = false)]
		public string name
		{
			get
			{
				if (edxLkSKgSrFSxSJTtkxDkJziiWA)
				{
					return uEUQyyHHPDWVxiEMAuEGURvglkz.ToString() + " " + (XgttqEWgLatQKtTjzdTUVERleMvd + 1);
				}
				return "XInput " + uEUQyyHHPDWVxiEMAuEGURvglkz.ToString() + " " + (XgttqEWgLatQKtTjzdTUVERleMvd + 1);
			}
		}

		[CustomObfuscation(rename = false)]
		public long? systemId => XgttqEWgLatQKtTjzdTUVERleMvd;

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
			qFTTgjZPRmbnvqCBGdmEDbfSPiSE.aMoGEhQMMAcMjGgtviDVOaoivvU(amount, motorIndex);
		}

		[CustomObfuscation(rename = false)]
		public void StopVibration()
		{
			qFTTgjZPRmbnvqCBGdmEDbfSPiSE.hQKemQafyAcZUNnJrJewstjaxjpV();
		}

		public IHKymFjiuOAWDftVknObotjRfvu(int systemId, bool isWin8AppStore, fNgBoMIxVbPxaDHBzrikXjSCIPco sourceJoystick, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Action deviceDisconnectedDelegate)
		{
			qFTTgjZPRmbnvqCBGdmEDbfSPiSE = sourceJoystick;
			edxLkSKgSrFSxSJTtkxDkJziiWA = isWin8AppStore;
			XgttqEWgLatQKtTjzdTUVERleMvd = systemId;
			rpvCjQaePXpGswKHxhwfamxRDIu = getHardwareJoystickMap_InputManager;
			xloHmAClPCRsuTNHGzllobzqsSv = deviceDisconnectedDelegate;
			HDUfrfQaCtWbjEQjslQVHYtxamY = -1;
			JUwazOFkydwVuIEENNzuHlTwjeP = 6;
			IEPcCkkotYAaQYIjlAWcbfoCVCPY = 15;
			rdAiJgjkWhiEydzQBaCRfzCVRNHM = JUwazOFkydwVuIEENNzuHlTwjeP;
			sTzXfOyWCNXZCDYOkqgPDWeTHnP = IEPcCkkotYAaQYIjlAWcbfoCVCPY;
			JdVEWmnshzhQhfQpWKygbxeaWPsN = new float[JUwazOFkydwVuIEENNzuHlTwjeP];
			zDdXRTONJmZUqqAiqtzcktIOAJw = new bool[IEPcCkkotYAaQYIjlAWcbfoCVCPY];
			FpHdiZjcdFzIgvKBVuBvPUFbqfyS();
		}

		[CustomObfuscation(rename = false)]
		public void Update()
		{
			qFTTgjZPRmbnvqCBGdmEDbfSPiSE.YYZBcNHuDDPbbahkHHyTHvUNFGE();
			bool[] currentButtonValues = qFTTgjZPRmbnvqCBGdmEDbfSPiSE.LwmOfqNgIYjfTKnDoIWjaIBKeCxD;
			QAJCSlFtoGBRITqPqBBrQqVEeBT(currentButtonValues, ref qFTTgjZPRmbnvqCBGdmEDbfSPiSE.bNsTKZFodKIwwfvFzIUkHfSyQxne);
			ldPMgFaEItHhAAPdUPIqVhZTNOL(currentButtonValues, ref qFTTgjZPRmbnvqCBGdmEDbfSPiSE.bNsTKZFodKIwwfvFzIUkHfSyQxne);
			qFTTgjZPRmbnvqCBGdmEDbfSPiSE.aWoeUUEECkNImBpxjMjDHgymWpn();
		}

		public void DuLzdBiIRJtyMFbYAfIhcMogLuq(bool P_0)
		{
			if (qFTTgjZPRmbnvqCBGdmEDbfSPiSE != null)
			{
				ycUGdCjZQhckbAkuclTQKcQUIVbc = P_0;
			}
		}

		public bool CKXxDkQUaSOMxwlDbJWLFEdgRcPY(QUIZKudlqAinLhGdIvvzESzJkmn P_0)
		{
			AUjpiWJYqxOjcoGwuXPfcZSGuCq(JsKwgzgEGffAZfkTDHUconrRwJy(P_0));
			return tuVLllvCFeToSgCnpYdwTjlfWUq;
		}

		public bool JsKwgzgEGffAZfkTDHUconrRwJy(QUIZKudlqAinLhGdIvvzESzJkmn P_0)
		{
			if (qFTTgjZPRmbnvqCBGdmEDbfSPiSE == null)
			{
				return false;
			}
			return qFTTgjZPRmbnvqCBGdmEDbfSPiSE.JsKwgzgEGffAZfkTDHUconrRwJy(P_0);
		}

		public void AUjpiWJYqxOjcoGwuXPfcZSGuCq(bool P_0)
		{
			tuVLllvCFeToSgCnpYdwTjlfWUq = P_0;
		}

		public void moBAhMeVbIBmfztITzmSbBSfEHUp()
		{
			if (!MIcFDKFmbcoLIWvmEwicNqnQGGHh || rFkfeDrsogApGkYPKpatwaLnLLyC())
			{
				FpHdiZjcdFzIgvKBVuBvPUFbqfyS();
			}
			if (MIcFDKFmbcoLIWvmEwicNqnQGGHh && tuVLllvCFeToSgCnpYdwTjlfWUq)
			{
				qFTTgjZPRmbnvqCBGdmEDbfSPiSE.QTjmhwTeuRVhauTKAbvNjtNMtgF();
			}
		}

		public void JbagTVLJqlRcDShDKgcVdnYilVJ()
		{
			HDUfrfQaCtWbjEQjslQVHYtxamY = -1;
			MIcFDKFmbcoLIWvmEwicNqnQGGHh = false;
			qFTTgjZPRmbnvqCBGdmEDbfSPiSE.nwwunQEtKXtRahhaVmgytaMELdz();
			Array.Clear(JdVEWmnshzhQhfQpWKygbxeaWPsN, 0, JdVEWmnshzhQhfQpWKygbxeaWPsN.Length);
			Array.Clear(zDdXRTONJmZUqqAiqtzcktIOAJw, 0, zDdXRTONJmZUqqAiqtzcktIOAJw.Length);
		}

		[CustomObfuscation(rename = false)]
		public void FillData(ControllerDataUpdater dataUpdater)
		{
			if (JUwazOFkydwVuIEENNzuHlTwjeP != dataUpdater.axisCount || IEPcCkkotYAaQYIjlAWcbfoCVCPY != dataUpdater.buttonCount)
			{
				throw new Exception("This controller signature does not match the data object!");
			}
			for (int i = 0; i < JUwazOFkydwVuIEENNzuHlTwjeP; i++)
			{
				dataUpdater.axisValues[i] = JdVEWmnshzhQhfQpWKygbxeaWPsN[i];
			}
			for (int j = 0; j < IEPcCkkotYAaQYIjlAWcbfoCVCPY; j++)
			{
				dataUpdater.buttonValues[j] = zDdXRTONJmZUqqAiqtzcktIOAJw[j];
			}
			if (RtEBtfhoklZnMgNMZfcTKWlNBQe && !dataUpdater.hasReceivedInput)
			{
				dataUpdater.hasReceivedInput = true;
			}
		}

		public BridgedControllerHWInfo TdHuOOvtOeVJJeyOCtfLWYvpTOH()
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

		private void FpHdiZjcdFzIgvKBVuBvPUFbqfyS()
		{
			if (qFTTgjZPRmbnvqCBGdmEDbfSPiSE == null || !CKXxDkQUaSOMxwlDbJWLFEdgRcPY(QUIZKudlqAinLhGdIvvzESzJkmn.vvuDxMkaGvgjyFPtTynZcBmcdWk))
			{
				return;
			}
			try
			{
				ZkcPHmGuayULgomEgAVCFcCcyhga();
				LKFgASYGbtDLaslZsYWGfaIBzyU lKFgASYGbtDLaslZsYWGfaIBzyU = qFTTgjZPRmbnvqCBGdmEDbfSPiSE.iZCqFryezOSqhTIWpCmmHqhmwGB.YOwgxhbkdznSMauQKFMqZQKfNwge(kPwuVFbDHHcxFAmkShCRzOChlEQ.mfOKyrrlsNaDxmAuOAcIUwAslJT);
				WxVnkLFPWfCbnxtPfvHrJfxyDCx = lKFgASYGbtDLaslZsYWGfaIBzyU.HmQyuofUsvomGjtCuiqveOpNWlh;
				uEUQyyHHPDWVxiEMAuEGURvglkz = (XInputDeviceSubType)lKFgASYGbtDLaslZsYWGfaIBzyU.HvzewbAgImJhaCOtbRQxEdLdPxco;
				if (qFTTgjZPRmbnvqCBGdmEDbfSPiSE.iZCqFryezOSqhTIWpCmmHqhmwGB.aMoGEhQMMAcMjGgtviDVOaoivvU(default(FAIBoIXMzneqbVBBCMdcaRKySdU)).yPNTsfZPfPfRRkdmtjaEgkfNPay)
				{
					mUncBBKjUAbEBhJbCqRQJvpQDWom = true;
				}
				xSzgsyIqdoqVvBLZfrMaBViRfbdy = (lKFgASYGbtDLaslZsYWGfaIBzyU.jMbdrySazXGxqBoUZJERaOtVVTv & tcKduxDHWnxbvdsGSHevWqzQzeFq.NXPVnmJaNrvPbkOeHDGSjjzqJvwZ) == tcKduxDHWnxbvdsGSHevWqzQzeFq.NXPVnmJaNrvPbkOeHDGSjjzqJvwZ;
				DkCucBGofWqRioHvuuaHxGeOUvg();
				FbSmcmcVOWowuyUiagueSMvFgly = FZCqfqZEBbHWoQxVVIkyNdAoiatI.hardwareMapIdentifier.guid;
				DcCSwoiCsPKVmzyhfFwghvYDsbp = FZCqfqZEBbHWoQxVVIkyNdAoiatI.controllerName;
				qFTTgjZPRmbnvqCBGdmEDbfSPiSE.QTjmhwTeuRVhauTKAbvNjtNMtgF();
				kmlrVkJoHAiVknTEjxTfehHxMGP = MiscTools.CreateGuidHashSHA1(string.Concat(WxVnkLFPWfCbnxtPfvHrJfxyDCx, uEUQyyHHPDWVxiEMAuEGURvglkz, XgttqEWgLatQKtTjzdTUVERleMvd));
				MIcFDKFmbcoLIWvmEwicNqnQGGHh = true;
			}
			catch (Exception)
			{
				MIcFDKFmbcoLIWvmEwicNqnQGGHh = false;
				tuVLllvCFeToSgCnpYdwTjlfWUq = false;
				kmlrVkJoHAiVknTEjxTfehHxMGP = Guid.Empty;
			}
		}

		private bool rFkfeDrsogApGkYPKpatwaLnLLyC()
		{
			try
			{
				if (uEUQyyHHPDWVxiEMAuEGURvglkz != (XInputDeviceSubType)qFTTgjZPRmbnvqCBGdmEDbfSPiSE.iZCqFryezOSqhTIWpCmmHqhmwGB.YOwgxhbkdznSMauQKFMqZQKfNwge(kPwuVFbDHHcxFAmkShCRzOChlEQ.mfOKyrrlsNaDxmAuOAcIUwAslJT).HvzewbAgImJhaCOtbRQxEdLdPxco)
				{
					return true;
				}
			}
			catch
			{
			}
			return false;
		}

		private void ZkcPHmGuayULgomEgAVCFcCcyhga()
		{
			xSzgsyIqdoqVvBLZfrMaBViRfbdy = false;
			mUncBBKjUAbEBhJbCqRQJvpQDWom = false;
			ycUGdCjZQhckbAkuclTQKcQUIVbc = false;
			MIcFDKFmbcoLIWvmEwicNqnQGGHh = false;
		}

		private void ctMqQvkMqhbLKIxyJJkOEHFInSG()
		{
			if (xloHmAClPCRsuTNHGzllobzqsSv != null)
			{
				xloHmAClPCRsuTNHGzllobzqsSv();
			}
			qFTTgjZPRmbnvqCBGdmEDbfSPiSE.nwwunQEtKXtRahhaVmgytaMELdz();
		}

		private void QAJCSlFtoGBRITqPqBBrQqVEeBT(bool[] P_0, ref scFasMTOMyuPvtwtXJcRBphZjWU P_1)
		{
			HardwareJoystickMap.Platform_XInput_Base.Axis[] axes_orig = ((HardwareJoystickMap.Platform_XInput_Base)FZCqfqZEBbHWoQxVVIkyNdAoiatI.map).Axes_orig;
			if (axes_orig == null)
			{
				return;
			}
			for (int i = 0; i < axes_orig.Length; i++)
			{
				if (i >= JUwazOFkydwVuIEENNzuHlTwjeP)
				{
					throw new Exception("Number of axes in hardware map does not match number of axes found in controller!");
				}
				JdVEWmnshzhQhfQpWKygbxeaWPsN[i] = WbUNdjrqDniDXYdirtEbXVOOxfO(axes_orig[i], P_0, ref P_1);
				if (!RtEBtfhoklZnMgNMZfcTKWlNBQe && JdVEWmnshzhQhfQpWKygbxeaWPsN[i] != 0f)
				{
					RtEBtfhoklZnMgNMZfcTKWlNBQe = true;
				}
			}
		}

		private void ldPMgFaEItHhAAPdUPIqVhZTNOL(bool[] P_0, ref scFasMTOMyuPvtwtXJcRBphZjWU P_1)
		{
			HardwareJoystickMap.Platform_XInput_Base.Button[] buttons_orig = ((HardwareJoystickMap.Platform_XInput_Base)FZCqfqZEBbHWoQxVVIkyNdAoiatI.map).Buttons_orig;
			if (buttons_orig == null)
			{
				return;
			}
			for (int i = 0; i < buttons_orig.Length; i++)
			{
				if (i >= IEPcCkkotYAaQYIjlAWcbfoCVCPY)
				{
					throw new Exception("Number of buttons in hardware map does not match number of buttons found in controller!");
				}
				zDdXRTONJmZUqqAiqtzcktIOAJw[i] = kXRepGCTsYPuBnCuTSPcGaXqgpDv(buttons_orig[i], P_0, ref P_1);
				if (!RtEBtfhoklZnMgNMZfcTKWlNBQe && zDdXRTONJmZUqqAiqtzcktIOAJw[i])
				{
					RtEBtfhoklZnMgNMZfcTKWlNBQe = true;
				}
			}
		}

		private float WbUNdjrqDniDXYdirtEbXVOOxfO(HardwareJoystickMap.Platform_XInput_Base.Axis P_0, bool[] P_1, ref scFasMTOMyuPvtwtXJcRBphZjWU P_2)
		{
			if (P_0.sourceType == HardwareElementSourceType.Axis)
			{
				if (P_0.sourceAxis == XInputAxis.None)
				{
					return 0f;
				}
				return WbUNdjrqDniDXYdirtEbXVOOxfO(P_0.sourceAxis, ref P_2);
			}
			if (P_0.sourceType == HardwareElementSourceType.Button)
			{
				if (P_0.sourceButton == XInputButton.None)
				{
					return 0f;
				}
				if (!kXRepGCTsYPuBnCuTSPcGaXqgpDv(P_0.sourceButton, P_1))
				{
					return 0f;
				}
				if (P_0.buttonAxisContribution == Pole.Positive)
				{
					return 1f;
				}
				return -1f;
			}
			return 0f;
		}

		private float WbUNdjrqDniDXYdirtEbXVOOxfO(XInputAxis P_0, ref scFasMTOMyuPvtwtXJcRBphZjWU P_1)
		{
			return P_0 switch
			{
				XInputAxis.LeftThumbX => fNgBoMIxVbPxaDHBzrikXjSCIPco.tRSsFucqdzXsNtvLSMlgIVxHHWP(P_1.aXagYoOhLDHhnhBupgKgaQGSnzlS), 
				XInputAxis.LeftThumbY => fNgBoMIxVbPxaDHBzrikXjSCIPco.tRSsFucqdzXsNtvLSMlgIVxHHWP(P_1.KlIOWfEYAuSXUJeNOdZLWdcuoRj), 
				XInputAxis.RightThumbX => fNgBoMIxVbPxaDHBzrikXjSCIPco.tRSsFucqdzXsNtvLSMlgIVxHHWP(P_1.AVWofYivXwjVWEsQMSKGCHWsGly), 
				XInputAxis.RightThumbY => fNgBoMIxVbPxaDHBzrikXjSCIPco.tRSsFucqdzXsNtvLSMlgIVxHHWP(P_1.gihvzqaqpRHbgXMhBPYdPaBoixF), 
				XInputAxis.LeftTrigger => fNgBoMIxVbPxaDHBzrikXjSCIPco.sAyqCnrfBioMysxnPQNnTRQxbMo(P_1.QdydfPumXSWcthmXJyNnRJGNWxw), 
				XInputAxis.RightTrigger => fNgBoMIxVbPxaDHBzrikXjSCIPco.sAyqCnrfBioMysxnPQNnTRQxbMo(P_1.meonCNvzOMjlzmbegtLVdRBGPEP), 
				_ => 0f, 
			};
		}

		private bool kXRepGCTsYPuBnCuTSPcGaXqgpDv(HardwareJoystickMap.Platform_XInput_Base.Button P_0, bool[] P_1, ref scFasMTOMyuPvtwtXJcRBphZjWU P_2)
		{
			if (P_0.sourceType == HardwareElementSourceType.Button)
			{
				if (P_0.sourceButton == XInputButton.None)
				{
					return false;
				}
				return kXRepGCTsYPuBnCuTSPcGaXqgpDv(P_0.sourceButton, P_1);
			}
			if (P_0.sourceType == HardwareElementSourceType.Axis)
			{
				if (P_0.sourceAxis == XInputAxis.None)
				{
					return false;
				}
				float num = WbUNdjrqDniDXYdirtEbXVOOxfO(P_0.sourceAxis, ref P_2);
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
			return false;
		}

		private bool kXRepGCTsYPuBnCuTSPcGaXqgpDv(XInputButton P_0, bool[] P_1)
		{
			return P_0 switch
			{
				XInputButton.DPadUp => P_1[0], 
				XInputButton.DPadDown => P_1[1], 
				XInputButton.DPadLeft => P_1[2], 
				XInputButton.DPadRight => P_1[3], 
				XInputButton.Start => P_1[4], 
				XInputButton.Back => P_1[5], 
				XInputButton.LeftThumb => P_1[6], 
				XInputButton.RightThumb => P_1[7], 
				XInputButton.LeftShoulder => P_1[8], 
				XInputButton.RightShoulder => P_1[9], 
				XInputButton.Guide => P_1[10], 
				XInputButton.A => P_1[11], 
				XInputButton.B => P_1[12], 
				XInputButton.X => P_1[13], 
				XInputButton.Y => P_1[14], 
				_ => false, 
			};
		}

		private void DkCucBGofWqRioHvuuaHxGeOUvg()
		{
			FZCqfqZEBbHWoQxVVIkyNdAoiatI = rpvCjQaePXpGswKHxhwfamxRDIu(TdHuOOvtOeVJJeyOCtfLWYvpTOH());
			if (FZCqfqZEBbHWoQxVVIkyNdAoiatI == null)
			{
				Rewired.Logger.LogError("Default hardware map not found!");
				return;
			}
			JUwazOFkydwVuIEENNzuHlTwjeP = FZCqfqZEBbHWoQxVVIkyNdAoiatI.axisCount;
			IEPcCkkotYAaQYIjlAWcbfoCVCPY = FZCqfqZEBbHWoQxVVIkyNdAoiatI.buttonCount;
		}

		private bool BojmOoNWSwnoAqdCtuGbMXFWFvN(ref FAIBoIXMzneqbVBBCMdcaRKySdU P_0)
		{
			if (P_0.PvOCABSUCkoxLSqleOaRBxMRQiH > 0 || P_0.WESSHDHRPXsNFuEMRHfDxdTfZMe > 0)
			{
				return true;
			}
			return false;
		}

		private void iYZoBwBWZcLuBDYvRMgadgOjmKz(ref FAIBoIXMzneqbVBBCMdcaRKySdU P_0)
		{
			P_0.PvOCABSUCkoxLSqleOaRBxMRQiH = 0;
			P_0.WESSHDHRPXsNFuEMRHfDxdTfZMe = 0;
		}

		private void moowglrmPOHVAbIutBkUXOnRCun(ref FAIBoIXMzneqbVBBCMdcaRKySdU P_0, ref FAIBoIXMzneqbVBBCMdcaRKySdU P_1)
		{
			P_1.PvOCABSUCkoxLSqleOaRBxMRQiH = P_0.PvOCABSUCkoxLSqleOaRBxMRQiH;
			P_1.WESSHDHRPXsNFuEMRHfDxdTfZMe = P_0.WESSHDHRPXsNFuEMRHfDxdTfZMe;
		}

		private string PPJcSQzVaDAexHmAkgFfuRztqdju()
		{
			return InputTools.FormatHardwareIdentifierString($"{ReInput.currentPlatform.ToString()}{InputSource.XInput.ToString()}{WxVnkLFPWfCbnxtPfvHrJfxyDCx.ToString()}{uEUQyyHHPDWVxiEMAuEGURvglkz.ToString()}");
		}

		private void mcfuFPdUGFrLUTlWgAfDNLiDDwZ(BridgedControllerHWInfo P_0)
		{
			P_0.inputManagerSource = InputSource.XInput;
			P_0.inputSource = P_0.inputManagerSource;
			P_0.deviceType = ControlDeviceType.CCZTuwVJranWzEkxzHtKCBLLDDz;
			P_0.hardwareIdentifier = PPJcSQzVaDAexHmAkgFfuRztqdju();
			P_0.hardwareAxisCount = rdAiJgjkWhiEydzQBaCRfzCVRNHM;
			P_0.hardwareButtonCount = sTzXfOyWCNXZCDYOkqgPDWeTHnP;
			P_0.hardwareHatCount = 0;
			P_0.hw_productName = UjlLMcJBUCEjQCPTUCFwbFmHYQxE;
			P_0.hw_supportsVoice = xSzgsyIqdoqVvBLZfrMaBViRfbdy;
			P_0.hw_supportsVibration = mUncBBKjUAbEBhJbCqRQJvpQDWom;
			P_0.hw_localVibrationMotorCount = (mUncBBKjUAbEBhJbCqRQJvpQDWom ? 2 : 0);
			P_0.hw_xInputSubType = uEUQyyHHPDWVxiEMAuEGURvglkz;
		}

		private void mcfuFPdUGFrLUTlWgAfDNLiDDwZ(BridgedController P_0)
		{
			mcfuFPdUGFrLUTlWgAfDNLiDDwZ((BridgedControllerHWInfo)P_0);
			P_0.sourceJoystick = this;
			P_0.gameHardwareMap = FZCqfqZEBbHWoQxVVIkyNdAoiatI.ToGameHardwareControllerMap();
			P_0.instanceName = "XInput " + awueIOZppSsgBYIKhhnLggaAZAn;
			P_0.productName = "XInput " + UjlLMcJBUCEjQCPTUCFwbFmHYQxE;
			P_0.isXInputDevice = true;
			P_0.axisCount = JUwazOFkydwVuIEENNzuHlTwjeP;
			P_0.buttonCount = IEPcCkkotYAaQYIjlAWcbfoCVCPY;
			P_0.controllerTypeGuid = FbSmcmcVOWowuyUiagueSMvFgly;
			P_0.controllerExtension = extension;
		}

		public void Dispose()
		{
			PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
			GC.SuppressFinalize(this);
		}

		~IHKymFjiuOAWDftVknObotjRfvu()
		{
			PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
		}

		protected virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
		{
			if (jpnIPbpqmlecdiNqaFAxiNCsiMxs)
			{
				return;
			}
			if (P_0)
			{
				if (lXFsjgWpSMizRNRJknYKAvVKfYm)
				{
					qFTTgjZPRmbnvqCBGdmEDbfSPiSE.YGWIBjdifZgniGduRPTQAIfvnBQh();
				}
				if (qFTTgjZPRmbnvqCBGdmEDbfSPiSE != null)
				{
					qFTTgjZPRmbnvqCBGdmEDbfSPiSE.Dispose();
				}
			}
			jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
		}
	}

	private class VvAEkdcfiyaXeklKyzqbFbePeZKH
	{
		private class IdZXrhJOPyaezkyWpKGlhbrQtDh
		{
			public bool phWKYXoxuZSqWEBuYGghhXhsAGn;

			public int OyDnkOlVbHfuMnCTJaxdfguHXtY;

			public XInputDeviceSubType uEUQyyHHPDWVxiEMAuEGURvglkz;

			public void EBZMKoSknSfzkSfokUzktanzxJf(IHKymFjiuOAWDftVknObotjRfvu P_0, bool P_1)
			{
				phWKYXoxuZSqWEBuYGghhXhsAGn = P_1;
				OyDnkOlVbHfuMnCTJaxdfguHXtY = P_0.rewiredId;
				uEUQyyHHPDWVxiEMAuEGURvglkz = P_0.uEUQyyHHPDWVxiEMAuEGURvglkz;
			}

			public IdZXrhJOPyaezkyWpKGlhbrQtDh(int rewiredId, XInputDeviceSubType deviceSubType)
			{
				OyDnkOlVbHfuMnCTJaxdfguHXtY = rewiredId;
				uEUQyyHHPDWVxiEMAuEGURvglkz = deviceSubType;
			}
		}

		private List<IdZXrhJOPyaezkyWpKGlhbrQtDh> hMhaWfYUetzpHHbonWijivkdKiW;

		public VvAEkdcfiyaXeklKyzqbFbePeZKH()
		{
			hMhaWfYUetzpHHbonWijivkdKiW = new List<IdZXrhJOPyaezkyWpKGlhbrQtDh>();
		}

		public void pqYjtzKFMmHfzjSGGAqSJobyoop(IHKymFjiuOAWDftVknObotjRfvu P_0, bool P_1)
		{
			int num = UYvBQuGGMbqlNcbsGdYBZFCHCRB(P_0.rewiredId, P_0.uEUQyyHHPDWVxiEMAuEGURvglkz, true);
			if (num < 0)
			{
				IdZXrhJOPyaezkyWpKGlhbrQtDh idZXrhJOPyaezkyWpKGlhbrQtDh = new IdZXrhJOPyaezkyWpKGlhbrQtDh(P_0.rewiredId, P_0.uEUQyyHHPDWVxiEMAuEGURvglkz);
				idZXrhJOPyaezkyWpKGlhbrQtDh.phWKYXoxuZSqWEBuYGghhXhsAGn = P_1;
				hMhaWfYUetzpHHbonWijivkdKiW.Add(idZXrhJOPyaezkyWpKGlhbrQtDh);
			}
		}

		public void EBZMKoSknSfzkSfokUzktanzxJf(int P_0, IHKymFjiuOAWDftVknObotjRfvu P_1, bool P_2)
		{
			if (P_0 >= 0 && P_0 < hMhaWfYUetzpHHbonWijivkdKiW.Count)
			{
				hMhaWfYUetzpHHbonWijivkdKiW[P_0].EBZMKoSknSfzkSfokUzktanzxJf(P_1, P_2);
			}
		}

		public int xsUExAACzSdBhHUtEbTfEPilMZFZ(XInputDeviceSubType P_0, bool P_1)
		{
			int count = hMhaWfYUetzpHHbonWijivkdKiW.Count;
			for (int i = 0; i < count; i++)
			{
				if ((P_1 || !hMhaWfYUetzpHHbonWijivkdKiW[i].phWKYXoxuZSqWEBuYGghhXhsAGn) && hMhaWfYUetzpHHbonWijivkdKiW[i].uEUQyyHHPDWVxiEMAuEGURvglkz == P_0)
				{
					return i;
				}
			}
			return -1;
		}

		public int UYvBQuGGMbqlNcbsGdYBZFCHCRB(int P_0, XInputDeviceSubType P_1, bool P_2)
		{
			int count = hMhaWfYUetzpHHbonWijivkdKiW.Count;
			for (int i = 0; i < count; i++)
			{
				if ((P_2 || !hMhaWfYUetzpHHbonWijivkdKiW[i].phWKYXoxuZSqWEBuYGghhXhsAGn) && hMhaWfYUetzpHHbonWijivkdKiW[i].OyDnkOlVbHfuMnCTJaxdfguHXtY == P_0 && hMhaWfYUetzpHHbonWijivkdKiW[i].uEUQyyHHPDWVxiEMAuEGURvglkz == P_1)
				{
					return i;
				}
			}
			return -1;
		}

		public int SiBEDoFQySFRGIBcstyuOyBGECRM(int P_0)
		{
			if (P_0 < 0 || P_0 >= hMhaWfYUetzpHHbonWijivkdKiW.Count)
			{
				throw new ArgumentOutOfRangeException();
			}
			return hMhaWfYUetzpHHbonWijivkdKiW[P_0].OyDnkOlVbHfuMnCTJaxdfguHXtY;
		}

		public void riJgsmtxpIInWlTyRLalBYuYHnv(int P_0, bool P_1)
		{
			if (P_0 >= 0 && P_0 < hMhaWfYUetzpHHbonWijivkdKiW.Count)
			{
				hMhaWfYUetzpHHbonWijivkdKiW[P_0].phWKYXoxuZSqWEBuYGghhXhsAGn = P_1;
			}
		}
	}

	private class XFFhnyZjgXdfBVnMQbwfORYkoGz
	{
		public bool EKyrdYodkeFfXMWbGHPYpralRqm;

		private double APfDPuVrmyNiRggOPOjkMCXvABlJ;

		public float ennUaNXGzFdNTPUKCLPLQGDndiK;

		public XFFhnyZjgXdfBVnMQbwfORYkoGz()
		{
		}

		public XFFhnyZjgXdfBVnMQbwfORYkoGz(float inLength)
		{
			ennUaNXGzFdNTPUKCLPLQGDndiK = inLength;
		}

		public void TWjcxXgKqgdHVddNzOLYDFcnDAXL()
		{
			EKyrdYodkeFfXMWbGHPYpralRqm = true;
			APfDPuVrmyNiRggOPOjkMCXvABlJ = (double)ennUaNXGzFdNTPUKCLPLQGDndiK + ReInput.unscaledTime;
		}

		public void TWjcxXgKqgdHVddNzOLYDFcnDAXL(float P_0)
		{
			EKyrdYodkeFfXMWbGHPYpralRqm = true;
			ennUaNXGzFdNTPUKCLPLQGDndiK = P_0;
			APfDPuVrmyNiRggOPOjkMCXvABlJ = (double)ennUaNXGzFdNTPUKCLPLQGDndiK + ReInput.unscaledTime;
		}

		public bool EBZMKoSknSfzkSfokUzktanzxJf()
		{
			if (!EKyrdYodkeFfXMWbGHPYpralRqm)
			{
				return false;
			}
			if (ReInput.unscaledTime >= APfDPuVrmyNiRggOPOjkMCXvABlJ)
			{
				EKyrdYodkeFfXMWbGHPYpralRqm = false;
				return true;
			}
			return false;
		}

		public void xZveeqhZWQBoifJNrEKvhlbeSAk()
		{
			EKyrdYodkeFfXMWbGHPYpralRqm = false;
			APfDPuVrmyNiRggOPOjkMCXvABlJ = 0.0;
		}

		public void GpByWuvCRYhtUbteSMPNimQnEEp(float P_0)
		{
			ennUaNXGzFdNTPUKCLPLQGDndiK = P_0;
		}

		public XFFhnyZjgXdfBVnMQbwfORYkoGz YverQsEPeHIxBJcHwyyomMTnOQG()
		{
			return (XFFhnyZjgXdfBVnMQbwfORYkoGz)MemberwiseClone();
		}
	}

	public class fNgBoMIxVbPxaDHBzrikXjSCIPco : IDisposable
	{
		public readonly wMVcQWfKmOojyaRfBdNYpZXlVVef iZCqFryezOSqhTIWpCmmHqhmwGB;

		public scFasMTOMyuPvtwtXJcRBphZjWU bNsTKZFodKIwwfvFzIUkHfSyQxne;

		private bool tuVLllvCFeToSgCnpYdwTjlfWUq;

		private readonly ButtonLoopSet pimGaxMynqiIGbxFRcEionkSvOj;

		private scFasMTOMyuPvtwtXJcRBphZjWU XwcVqQmPjMMAYhtFNHoutAhAPXj;

		private bool ZyjqidiYYjlTqbHJQncNDNCAkXI;

		private DualThreadLowLevelInputEventQueue hkxQVbyJugMICBLKVxLAPGGthIHJ;

		private readonly object QnjPDsavPpORFdRFTiPBJdcwCnOc;

		private RingBuffer<FAIBoIXMzneqbVBBCMdcaRKySdU> MtLgPhXQhLChNLDXOxLyAhlgEAe = new RingBuffer<FAIBoIXMzneqbVBBCMdcaRKySdU>(5);

		private RingBuffer<FAIBoIXMzneqbVBBCMdcaRKySdU> YTMeppewbBmaSCJUbYCynQZbfTKE = new RingBuffer<FAIBoIXMzneqbVBBCMdcaRKySdU>(5);

		private readonly object owQxZjbLEUoZXrMTyQjuZjLcfANi = new object();

		private readonly object pWtIPEsOtTUmYypBfKPSNtjtMCi = new object();

		private FAIBoIXMzneqbVBBCMdcaRKySdU DOiyEqMjTVSDEhbsmDwxxqLtGudF;

		private double jNWEsNwhNzeRzgXlBoZMucMybOi;

		private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

		public bool[] LwmOfqNgIYjfTKnDoIWjaIBKeCxD => pimGaxMynqiIGbxFRcEionkSvOj.Current.effectiveValue;

		public fNgBoMIxVbPxaDHBzrikXjSCIPco(int controllerIndex, UpdateLoopSetting updateLoops)
		{
			iZCqFryezOSqhTIWpCmmHqhmwGB = new wMVcQWfKmOojyaRfBdNYpZXlVVef((ExJzKGzHQiSMINEBsmMSWsnrVTw)controllerIndex);
			pimGaxMynqiIGbxFRcEionkSvOj = new ButtonLoopSet(updateLoops, 15);
			QnjPDsavPpORFdRFTiPBJdcwCnOc = new object();
			hkxQVbyJugMICBLKVxLAPGGthIHJ = new DualThreadLowLevelInputEventQueue((int)((float)lnoFVvbmWwakViCuJntBYhJMonm.bdwnaKkumjoZqcfKWJSyUhZBBWaF * 0.25f), 15, 6, 0);
		}

		public void YYZBcNHuDDPbbahkHHyTHvUNFGE()
		{
			pimGaxMynqiIGbxFRcEionkSvOj.SetUpdateLoop(ReInput.currentUpdateLoop);
			UHFEhLSawpiOlIgVyQuXRKTyfvUH(ref bNsTKZFodKIwwfvFzIUkHfSyQxne);
		}

		public void aWoeUUEECkNImBpxjMjDHgymWpn()
		{
			lBeptjeBLPjkdyiUVsygQzOccPV();
			pimGaxMynqiIGbxFRcEionkSvOj.Current.ClearWasTrueThisFrame();
		}

		public void QTjmhwTeuRVhauTKAbvNjtNMtgF()
		{
			OeUrnnZKFEfcUxLGqEbSdcenXWX();
			tuVLllvCFeToSgCnpYdwTjlfWUq = true;
			ZyjqidiYYjlTqbHJQncNDNCAkXI = iZCqFryezOSqhTIWpCmmHqhmwGB.fGcvLiXbUIhveYuKHpUprbEcdtk;
		}

		public void nwwunQEtKXtRahhaVmgytaMELdz()
		{
			tuVLllvCFeToSgCnpYdwTjlfWUq = false;
			ZyjqidiYYjlTqbHJQncNDNCAkXI = false;
			OeUrnnZKFEfcUxLGqEbSdcenXWX();
		}

		public bool JsKwgzgEGffAZfkTDHUconrRwJy(QUIZKudlqAinLhGdIvvzESzJkmn P_0)
		{
			return P_0 switch
			{
				QUIZKudlqAinLhGdIvvzESzJkmn.vvuDxMkaGvgjyFPtTynZcBmcdWk => ZyjqidiYYjlTqbHJQncNDNCAkXI = iZCqFryezOSqhTIWpCmmHqhmwGB.fGcvLiXbUIhveYuKHpUprbEcdtk, 
				QUIZKudlqAinLhGdIvvzESzJkmn.ZnIRZKHwOzRCMRozodrqGWdVYED => ZyjqidiYYjlTqbHJQncNDNCAkXI, 
				_ => throw new NotImplementedException(), 
			};
		}

		public void aMoGEhQMMAcMjGgtviDVOaoivvU(float P_0, int P_1)
		{
			switch (P_1)
			{
			case 0:
				DOiyEqMjTVSDEhbsmDwxxqLtGudF.PvOCABSUCkoxLSqleOaRBxMRQiH = (ushort)(MathTools.Clamp01(P_0) * 65535f);
				break;
			case 1:
				DOiyEqMjTVSDEhbsmDwxxqLtGudF.WESSHDHRPXsNFuEMRHfDxdTfZMe = (ushort)(MathTools.Clamp01(P_0) * 65535f);
				break;
			}
			uNTuXVvYNmTijnRcwNiSWTETbAm();
		}

		public void hQKemQafyAcZUNnJrJewstjaxjpV()
		{
			DOiyEqMjTVSDEhbsmDwxxqLtGudF.PvOCABSUCkoxLSqleOaRBxMRQiH = 0;
			DOiyEqMjTVSDEhbsmDwxxqLtGudF.WESSHDHRPXsNFuEMRHfDxdTfZMe = 0;
			uNTuXVvYNmTijnRcwNiSWTETbAm();
		}

		public void YGWIBjdifZgniGduRPTQAIfvnBQh()
		{
			DOiyEqMjTVSDEhbsmDwxxqLtGudF.PvOCABSUCkoxLSqleOaRBxMRQiH = 0;
			DOiyEqMjTVSDEhbsmDwxxqLtGudF.WESSHDHRPXsNFuEMRHfDxdTfZMe = 0;
			lock (pWtIPEsOtTUmYypBfKPSNtjtMCi)
			{
				lock (owQxZjbLEUoZXrMTyQjuZjLcfANi)
				{
					MtLgPhXQhLChNLDXOxLyAhlgEAe.Clear();
					YTMeppewbBmaSCJUbYCynQZbfTKE.Clear();
					VJraZPHMianMqlsWQeVcJApvGLfs(iZCqFryezOSqhTIWpCmmHqhmwGB, DOiyEqMjTVSDEhbsmDwxxqLtGudF, ref jNWEsNwhNzeRzgXlBoZMucMybOi);
				}
			}
		}

		public void PcvxBYspnIVMFewWoGMbcmMuGvSf()
		{
			if (!tuVLllvCFeToSgCnpYdwTjlfWUq || !ZyjqidiYYjlTqbHJQncNDNCAkXI)
			{
				return;
			}
			CFwUXCQJkWGIyLatIBIUVDNybqMD cFwUXCQJkWGIyLatIBIUVDNybqMD;
			double realTime;
			try
			{
				if (!iZCqFryezOSqhTIWpCmmHqhmwGB.iCeCIXLHGPAVacOvxkZQXSjYiJfN(out cFwUXCQJkWGIyLatIBIUVDNybqMD))
				{
					ZyjqidiYYjlTqbHJQncNDNCAkXI = false;
					return;
				}
				realTime = ReInput.realTime;
			}
			catch
			{
				ZyjqidiYYjlTqbHJQncNDNCAkXI = false;
				return;
			}
			lock (QnjPDsavPpORFdRFTiPBJdcwCnOc)
			{
				if (!HBgcFyGidfWfTptgjdDDgdVDvUPQ(cFwUXCQJkWGIyLatIBIUVDNybqMD.pXUvLMZdfUPPpSKQFIjTzaejHeu, XwcVqQmPjMMAYhtFNHoutAhAPXj))
				{
					using (DualThreadLowLevelInputEventQueue.INewEventWrapper newEventWrapper = hkxQVbyJugMICBLKVxLAPGGthIHJ.T_CreateEvent())
					{
						VUQJCdFETpqZVVVZJJdGfciJxrz(ref cFwUXCQJkWGIyLatIBIUVDNybqMD.pXUvLMZdfUPPpSKQFIjTzaejHeu, realTime, newEventWrapper.Event);
					}
					XwcVqQmPjMMAYhtFNHoutAhAPXj = cFwUXCQJkWGIyLatIBIUVDNybqMD.pXUvLMZdfUPPpSKQFIjTzaejHeu;
				}
			}
		}

		public void cSaAZROxldIRNbnSWrrrrKjRlKqI()
		{
			if (!tuVLllvCFeToSgCnpYdwTjlfWUq || !ZyjqidiYYjlTqbHJQncNDNCAkXI || ReInput.realTime < jNWEsNwhNzeRzgXlBoZMucMybOi + 0.009999999776482582)
			{
				return;
			}
			lock (pWtIPEsOtTUmYypBfKPSNtjtMCi)
			{
				lock (owQxZjbLEUoZXrMTyQjuZjLcfANi)
				{
					MiscTools.Swap(ref MtLgPhXQhLChNLDXOxLyAhlgEAe, ref YTMeppewbBmaSCJUbYCynQZbfTKE);
				}
				hGQLpFCbMbcqIEOzIFBjbvpepYY(YTMeppewbBmaSCJUbYCynQZbfTKE, iZCqFryezOSqhTIWpCmmHqhmwGB, ref jNWEsNwhNzeRzgXlBoZMucMybOi);
			}
		}

		private void lBeptjeBLPjkdyiUVsygQzOccPV()
		{
			GGOjtbnmhyNnJgpZgSbBEaefklU();
		}

		private void GGOjtbnmhyNnJgpZgSbBEaefklU()
		{
			if (!(ReInput.realTime < jNWEsNwhNzeRzgXlBoZMucMybOi + 1.5) && (!Mathf.Approximately((int)DOiyEqMjTVSDEhbsmDwxxqLtGudF.PvOCABSUCkoxLSqleOaRBxMRQiH, 0f) || !Mathf.Approximately((int)DOiyEqMjTVSDEhbsmDwxxqLtGudF.WESSHDHRPXsNFuEMRHfDxdTfZMe, 0f)))
			{
				uNTuXVvYNmTijnRcwNiSWTETbAm();
			}
		}

		private void uNTuXVvYNmTijnRcwNiSWTETbAm()
		{
			lock (owQxZjbLEUoZXrMTyQjuZjLcfANi)
			{
				MtLgPhXQhLChNLDXOxLyAhlgEAe.Enqueue(DOiyEqMjTVSDEhbsmDwxxqLtGudF);
			}
		}

		private static void hGQLpFCbMbcqIEOzIFBjbvpepYY(RingBuffer<FAIBoIXMzneqbVBBCMdcaRKySdU> P_0, wMVcQWfKmOojyaRfBdNYpZXlVVef P_1, ref double P_2)
		{
			if (P_0.Count > 0)
			{
				VJraZPHMianMqlsWQeVcJApvGLfs(P_1, P_0[P_0.Count - 1], ref P_2);
				P_0.Clear();
			}
		}

		private static void VJraZPHMianMqlsWQeVcJApvGLfs(wMVcQWfKmOojyaRfBdNYpZXlVVef P_0, FAIBoIXMzneqbVBBCMdcaRKySdU P_1, ref double P_2)
		{
			try
			{
				P_0.aMoGEhQMMAcMjGgtviDVOaoivvU(P_1);
			}
			catch
			{
			}
			P_2 = ReInput.realTime;
		}

		private void UHFEhLSawpiOlIgVyQuXRKTyfvUH(ref scFasMTOMyuPvtwtXJcRBphZjWU P_0)
		{
			while (hkxQVbyJugMICBLKVxLAPGGthIHJ.ProcessNewEvents())
			{
				wsovFvHihlMQGOruBDKRDteqBHz(ref P_0, ref hkxQVbyJugMICBLKVxLAPGGthIHJ.currentEvent);
				for (int i = 0; i < 15; i++)
				{
					pimGaxMynqiIGbxFRcEionkSvOj.SetValue(i, kXRepGCTsYPuBnCuTSPcGaXqgpDv((int)P_0.OZXCbzyfeJVptcfXueOFPpFxErd, i), hkxQVbyJugMICBLKVxLAPGGthIHJ.currentEvent.GetTimestamp());
				}
			}
		}

		private void VUQJCdFETpqZVVVZJJdGfciJxrz(ref scFasMTOMyuPvtwtXJcRBphZjWU P_0, double P_1, LowLevelInputEvent P_2)
		{
			P_2.SetTimestamp(P_1);
			int oZXCbzyfeJVptcfXueOFPpFxErd = (int)P_0.OZXCbzyfeJVptcfXueOFPpFxErd;
			P_2.SetButtonsBitMask((oZXCbzyfeJVptcfXueOFPpFxErd & 0x7FF) | ((oZXCbzyfeJVptcfXueOFPpFxErd & (oZXCbzyfeJVptcfXueOFPpFxErd & -4096)) >> 1), 0);
			P_2.SetAxisValue(0, tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.aXagYoOhLDHhnhBupgKgaQGSnzlS));
			P_2.SetAxisValue(1, tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.KlIOWfEYAuSXUJeNOdZLWdcuoRj));
			P_2.SetAxisValue(2, tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.AVWofYivXwjVWEsQMSKGCHWsGly));
			P_2.SetAxisValue(3, tRSsFucqdzXsNtvLSMlgIVxHHWP(P_0.gihvzqaqpRHbgXMhBPYdPaBoixF));
			P_2.SetAxisValue(4, sAyqCnrfBioMysxnPQNnTRQxbMo(P_0.QdydfPumXSWcthmXJyNnRJGNWxw));
			P_2.SetAxisValue(5, sAyqCnrfBioMysxnPQNnTRQxbMo(P_0.meonCNvzOMjlzmbegtLVdRBGPEP));
		}

		private void wsovFvHihlMQGOruBDKRDteqBHz(ref scFasMTOMyuPvtwtXJcRBphZjWU P_0, ref LowLevelInputEvent P_1)
		{
			int buttonsBitMask = P_1.GetButtonsBitMask(0);
			P_0.OZXCbzyfeJVptcfXueOFPpFxErd = (dUHqxhnIAkeXJTvWhnyOljEDfUN)((buttonsBitMask & 0x7FF) | ((buttonsBitMask & (buttonsBitMask & -2048)) << 1));
			P_0.aXagYoOhLDHhnhBupgKgaQGSnzlS = (short)(P_1.GetAxisValue(0) * 32768f);
			P_0.KlIOWfEYAuSXUJeNOdZLWdcuoRj = (short)(P_1.GetAxisValue(1) * 32768f);
			P_0.AVWofYivXwjVWEsQMSKGCHWsGly = (short)(P_1.GetAxisValue(2) * 32768f);
			P_0.gihvzqaqpRHbgXMhBPYdPaBoixF = (short)(P_1.GetAxisValue(3) * 32768f);
			P_0.QdydfPumXSWcthmXJyNnRJGNWxw = (byte)(P_1.GetAxisValue(4) * 255f);
			P_0.meonCNvzOMjlzmbegtLVdRBGPEP = (byte)(P_1.GetAxisValue(5) * 255f);
		}

		private static bool kXRepGCTsYPuBnCuTSPcGaXqgpDv(int P_0, int P_1)
		{
			if (P_1 > 10)
			{
				P_1++;
			}
			return (P_0 & (1 << P_1)) != 0;
		}

		private void OeUrnnZKFEfcUxLGqEbSdcenXWX()
		{
			lock (QnjPDsavPpORFdRFTiPBJdcwCnOc)
			{
				bNsTKZFodKIwwfvFzIUkHfSyQxne = default(scFasMTOMyuPvtwtXJcRBphZjWU);
				XwcVqQmPjMMAYhtFNHoutAhAPXj = default(scFasMTOMyuPvtwtXJcRBphZjWU);
				pimGaxMynqiIGbxFRcEionkSvOj.Clear();
				hkxQVbyJugMICBLKVxLAPGGthIHJ.Clear();
			}
		}

		public void Dispose()
		{
			PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
			GC.SuppressFinalize(this);
		}

		~fNgBoMIxVbPxaDHBzrikXjSCIPco()
		{
			PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
		}

		protected virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
		{
			if (!jpnIPbpqmlecdiNqaFAxiNCsiMxs)
			{
				if (P_0)
				{
					hkxQVbyJugMICBLKVxLAPGGthIHJ.Dispose();
				}
				jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
			}
		}

		public static float tRSsFucqdzXsNtvLSMlgIVxHHWP(int P_0)
		{
			if (P_0 == 0)
			{
				return 0f;
			}
			return MathTools.Clamp((float)MathTools.Abs(P_0) / 32768f * (float)MathTools.Sign(P_0), -1f, 1f);
		}

		public static float sAyqCnrfBioMysxnPQNnTRQxbMo(int P_0)
		{
			if (P_0 == 0)
			{
				return 0f;
			}
			return MathTools.Clamp((float)MathTools.Abs(P_0) / 255f * (float)MathTools.Sign(P_0), -1f, 1f);
		}

		private static bool HBgcFyGidfWfTptgjdDDgdVDvUPQ(scFasMTOMyuPvtwtXJcRBphZjWU P_0, scFasMTOMyuPvtwtXJcRBphZjWU P_1)
		{
			if (P_0.OZXCbzyfeJVptcfXueOFPpFxErd == P_1.OZXCbzyfeJVptcfXueOFPpFxErd && P_0.QdydfPumXSWcthmXJyNnRJGNWxw == P_1.QdydfPumXSWcthmXJyNnRJGNWxw && P_0.meonCNvzOMjlzmbegtLVdRBGPEP == P_1.meonCNvzOMjlzmbegtLVdRBGPEP && P_0.aXagYoOhLDHhnhBupgKgaQGSnzlS == P_1.aXagYoOhLDHhnhBupgKgaQGSnzlS && P_0.KlIOWfEYAuSXUJeNOdZLWdcuoRj == P_1.KlIOWfEYAuSXUJeNOdZLWdcuoRj && P_0.AVWofYivXwjVWEsQMSKGCHWsGly == P_1.AVWofYivXwjVWEsQMSKGCHWsGly)
			{
				return P_0.gihvzqaqpRHbgXMhBPYdPaBoixF == P_1.gihvzqaqpRHbgXMhBPYdPaBoixF;
			}
			return false;
		}
	}

	public enum QUIZKudlqAinLhGdIvvzESzJkmn
	{
		vvuDxMkaGvgjyFPtTynZcBmcdWk = 0,
		ZnIRZKHwOzRCMRozodrqGWdVYED = 1
	}

	public const int YnvdkbCvwnnAWCfVbsPUEJPbjciS = 4;

	public const int khyubPXfEgCSobsLxAhQQhUETNkV = 32768;

	public const int vxNEZEdDvGHFhcxKnCkzemGiNlP = -32768;

	public const int bUTXJrRXmtjoNUOYTHVnEbFOgATK = 255;

	public const int GoHmYltXprxoXiblnPcxqrleaMC = 0;

	public const int LYVQPeuBxEFUXSxKCweWAAVkqTN = 18;

	public const int yDQoSbHlRgpllIbCYINsBxRfqrqL = 14;

	public const int VmMJeTJXhAPtzjnAUrOdiNGvTSZ = 6;

	public const int mxcWjJxLoFfGNHYKnndtzYTSKTT = 15;

	private IHKymFjiuOAWDftVknObotjRfvu[] bHUEwEqejQaMDEqpbfDDVSpZChq;

	private bool ICuepaXlZxZzDMJYyZrwcIOhGOs;

	private XFFhnyZjgXdfBVnMQbwfORYkoGz avMZSBMmGVKjgzipnFYBbfatdZtt;

	private VvAEkdcfiyaXeklKyzqbFbePeZKH cpsLJLsVkidwjpeYTDDwAeKdjlIh;

	private global::PraFXApEzKrfLjKmeJGBIrwNdsGd<bool> kcoiUACBncevuyrKJkLfepispgtW;

	private bool[] kQIuWXPXWucicAjgmqinDLGrSMC;

	private bool[] JdiqGTQdUViyjiksKrReYGoAcdB;

	private bool edxLkSKgSrFSxSJTtkxDkJziiWA;

	private readonly bool IzpJlBLkPDkFOtDllYWLdyPyGBp;

	private readonly UpdateLoopSetting SUWFuaPhXRNpjQqOeummtAiJjncj;

	private UpdateLoopType jjJsmqbwRaFBVQMDIobapvkysqL;

	private UpdateLoopType LSnAYKidcFTbZHieLRNAbqHCMZcO;

	private Action<int, ControllerDataUpdater> UnhEVuhJFUEnfAsRXUSCacwcngnY;

	private bool NLbGwkbnSWRfGeuNwXoqQwpQrzx;

	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> rpvCjQaePXpGswKHxhwfamxRDIu;

	private Func<int> ilAOFbKaMpyqndLrycyBBEQAMvEC;

	private static Guid[] aRMbxyytoWfMukziuPitiTewCcsh;

	private static string[] IoGXjfQKDEIOzYKnBLcKjdWkuvC;

	private static string[] SbCFpAkZWDvDsEAgdwguQVfQmRwa;

	[CustomObfuscation(rename = false)]
	public override int deviceCount
	{
		get
		{
			int num = 0;
			for (int i = 0; i < 4; i++)
			{
				if (bHUEwEqejQaMDEqpbfDDVSpZChq[i].lXFsjgWpSMizRNRJknYKAvVKfYm)
				{
					num++;
				}
			}
			return num;
		}
	}

	[CustomObfuscation(rename = false)]
	public override PlatformInputManager primaryInputManager => this;

	[CustomObfuscation(rename = false)]
	public override IInputSource inputSource => null;

	[CustomObfuscation(rename = false)]
	public override InputSource inputSourceType => InputSource.XInput;

	public gNZLZmnOEqwqMNKfeNUJNfMypUC(bool isWin10AUHack, UpdateLoopSetting updateLoop, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId)
	{
		IzpJlBLkPDkFOtDllYWLdyPyGBp = isWin10AUHack;
		SUWFuaPhXRNpjQqOeummtAiJjncj = updateLoop;
		NLbGwkbnSWRfGeuNwXoqQwpQrzx = true;
		try
		{
			if (!TMbQezmaCdrQdaUPTidokyxxlgC.FpHdiZjcdFzIgvKBVuBvPUFbqfyS(out var ffhchLVRtXvbFSLPIuTTTAbQgdH, out var text, out var _))
			{
				throw new Exception("XInput is not available.");
			}
			if (ffhchLVRtXvbFSLPIuTTTAbQgdH < FfhchLVRtXvbFSLPIuTTTAbQgdH.WiPetAAHSdpdxXhmYQajHMhVFrd)
			{
				Rewired.Logger.LogWarning("The version of XInput (" + text + ") detected on your system is out of date. Please update to the latest version of XInput. Input will still function, but all features may not be available. See the documentation for required dependencies.");
			}
			else
			{
				_ = 4;
			}
			rpvCjQaePXpGswKHxhwfamxRDIu = getHardwareJoystickMap_InputManager;
			ilAOFbKaMpyqndLrycyBBEQAMvEC = getNewJoystickId;
			edxLkSKgSrFSxSJTtkxDkJziiWA = UnityTools.platform == Platform.WindowsAppStore;
			using (TempListPool.TList<UpdateLoopType> tList = TempListPool.GetTList<UpdateLoopType>(3))
			{
				List<UpdateLoopType> list = tList.list;
				EnumConverter.ToUpdateLoopTypes(SUWFuaPhXRNpjQqOeummtAiJjncj, list);
				int num2 = 0;
				if (num2 < list.Count)
				{
					LSnAYKidcFTbZHieLRNAbqHCMZcO = list[num2];
				}
			}
			kcoiUACBncevuyrKJkLfepispgtW = new global::PraFXApEzKrfLjKmeJGBIrwNdsGd<bool>(useSharedThread: true, qzaVEjICGrbfeFngNzwFJPIyXDO);
			kQIuWXPXWucicAjgmqinDLGrSMC = new bool[4];
			JdiqGTQdUViyjiksKrReYGoAcdB = new bool[4];
			UnhEVuhJFUEnfAsRXUSCacwcngnY = UpdateControllerData;
			if (edxLkSKgSrFSxSJTtkxDkJziiWA)
			{
				tLqFENxHjSOacCzfowrjxfjBHb();
			}
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
		if (NLbGwkbnSWRfGeuNwXoqQwpQrzx)
		{
			avMZSBMmGVKjgzipnFYBbfatdZtt = new XFFhnyZjgXdfBVnMQbwfORYkoGz(1f);
		}
		cpsLJLsVkidwjpeYTDDwAeKdjlIh = new VvAEkdcfiyaXeklKyzqbFbePeZKH();
		if (bHUEwEqejQaMDEqpbfDDVSpZChq == null)
		{
			bHUEwEqejQaMDEqpbfDDVSpZChq = new IHKymFjiuOAWDftVknObotjRfvu[4];
			for (int i = 0; i < 4; i++)
			{
				fNgBoMIxVbPxaDHBzrikXjSCIPco fNgBoMIxVbPxaDHBzrikXjSCIPco = new fNgBoMIxVbPxaDHBzrikXjSCIPco(i, SUWFuaPhXRNpjQqOeummtAiJjncj);
				lnoFVvbmWwakViCuJntBYhJMonm.vASBewikQenvassTqAnBRckmkUcD.ThreadUpdateEvent += fNgBoMIxVbPxaDHBzrikXjSCIPco.PcvxBYspnIVMFewWoGMbcmMuGvSf;
				lnoFVvbmWwakViCuJntBYhJMonm.MYNiYSGhJNfIotfVQsakmqkmhLUH.ThreadUpdateEvent += fNgBoMIxVbPxaDHBzrikXjSCIPco.cSaAZROxldIRNbnSWrrrrKjRlKqI;
				bHUEwEqejQaMDEqpbfDDVSpZChq[i] = new IHKymFjiuOAWDftVknObotjRfvu(i, edxLkSKgSrFSxSJTtkxDkJziiWA, fNgBoMIxVbPxaDHBzrikXjSCIPco, rpvCjQaePXpGswKHxhwfamxRDIu, SystemDeviceDisconnected);
			}
		}
		sfUfgnMKsYqOirXLBOjvpaqrJGj(true);
		Update(UpdateLoopType.Update);
	}

	[CustomObfuscation(rename = false)]
	public override void Update(UpdateLoopType currentUpdateLoop)
	{
		jjJsmqbwRaFBVQMDIobapvkysqL = currentUpdateLoop;
		bcRjnCjxDyUMfEPooNQtVhZjlFn();
		for (int i = 0; i < 4; i++)
		{
			if (bHUEwEqejQaMDEqpbfDDVSpZChq[i] != null && bHUEwEqejQaMDEqpbfDDVSpZChq[i].lXFsjgWpSMizRNRJknYKAvVKfYm)
			{
				bHUEwEqejQaMDEqpbfDDVSpZChq[i].Update();
			}
		}
	}

	[CustomObfuscation(rename = false)]
	public override void OnDestroy()
	{
		if (kcoiUACBncevuyrKJkLfepispgtW != null)
		{
			kcoiUACBncevuyrKJkLfepispgtW.PMzamCeIIFqnzgwGlxEbIeTHBFUL();
		}
		if (bHUEwEqejQaMDEqpbfDDVSpZChq != null)
		{
			for (int i = 0; i < 4; i++)
			{
				if (bHUEwEqejQaMDEqpbfDDVSpZChq[i] != null)
				{
					if (lnoFVvbmWwakViCuJntBYhJMonm.vASBewikQenvassTqAnBRckmkUcD != null)
					{
						lnoFVvbmWwakViCuJntBYhJMonm.vASBewikQenvassTqAnBRckmkUcD.ThreadUpdateEvent -= bHUEwEqejQaMDEqpbfDDVSpZChq[i].qFTTgjZPRmbnvqCBGdmEDbfSPiSE.PcvxBYspnIVMFewWoGMbcmMuGvSf;
					}
					if (lnoFVvbmWwakViCuJntBYhJMonm.MYNiYSGhJNfIotfVQsakmqkmhLUH != null)
					{
						lnoFVvbmWwakViCuJntBYhJMonm.MYNiYSGhJNfIotfVQsakmqkmhLUH.ThreadUpdateEvent -= bHUEwEqejQaMDEqpbfDDVSpZChq[i].qFTTgjZPRmbnvqCBGdmEDbfSPiSE.cSaAZROxldIRNbnSWrrrrKjRlKqI;
					}
					bHUEwEqejQaMDEqpbfDDVSpZChq[i].Dispose();
				}
			}
		}
		TMbQezmaCdrQdaUPTidokyxxlgC.xXlxFifEPAoirUAxphCRWhcZmBc();
	}

	[CustomObfuscation(rename = false)]
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate()
	{
		return UnhEVuhJFUEnfAsRXUSCacwcngnY;
	}

	[CustomObfuscation(rename = false)]
	public override void UpdateControllerData(int assignedControllerId, ControllerDataUpdater data)
	{
		bHUEwEqejQaMDEqpbfDDVSpZChq[assignedControllerId].FillData(data);
	}

	[CustomObfuscation(rename = false)]
	public override void SystemDeviceConnected()
	{
		sfUfgnMKsYqOirXLBOjvpaqrJGj(true);
		iVuwsQmFTTGFrVNSZBEpfQbWCIO();
		if (_SystemDeviceConnectedEvent != null)
		{
			_SystemDeviceConnectedEvent();
		}
	}

	[CustomObfuscation(rename = false)]
	public override void SystemDeviceDisconnected()
	{
		sfUfgnMKsYqOirXLBOjvpaqrJGj(true);
		iVuwsQmFTTGFrVNSZBEpfQbWCIO();
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

	private bool SNaFHPJAwQzKgjxvHrGTwtIVyHr()
	{
		if (jjJsmqbwRaFBVQMDIobapvkysqL != LSnAYKidcFTbZHieLRNAbqHCMZcO)
		{
			return false;
		}
		bool flag = avMZSBMmGVKjgzipnFYBbfatdZtt.EBZMKoSknSfzkSfokUzktanzxJf();
		if (flag)
		{
			sfUfgnMKsYqOirXLBOjvpaqrJGj(true);
		}
		return flag;
	}

	private void sfUfgnMKsYqOirXLBOjvpaqrJGj(bool P_0)
	{
		ICuepaXlZxZzDMJYyZrwcIOhGOs = P_0;
		if (NLbGwkbnSWRfGeuNwXoqQwpQrzx)
		{
			avMZSBMmGVKjgzipnFYBbfatdZtt.TWjcxXgKqgdHVddNzOLYDFcnDAXL();
		}
	}

	private void iVuwsQmFTTGFrVNSZBEpfQbWCIO()
	{
		if (kcoiUACBncevuyrKJkLfepispgtW != null)
		{
			kcoiUACBncevuyrKJkLfepispgtW.xZveeqhZWQBoifJNrEKvhlbeSAk();
		}
	}

	private void tLqFENxHjSOacCzfowrjxfjBHb()
	{
		wMVcQWfKmOojyaRfBdNYpZXlVVef wMVcQWfKmOojyaRfBdNYpZXlVVef2 = new wMVcQWfKmOojyaRfBdNYpZXlVVef();
		_ = wMVcQWfKmOojyaRfBdNYpZXlVVef2.fGcvLiXbUIhveYuKHpUprbEcdtk;
	}

	private void bcRjnCjxDyUMfEPooNQtVhZjlFn()
	{
		bool flag = false;
		if (NLbGwkbnSWRfGeuNwXoqQwpQrzx)
		{
			flag = SNaFHPJAwQzKgjxvHrGTwtIVyHr();
		}
		if (!flag && ICuepaXlZxZzDMJYyZrwcIOhGOs)
		{
			OgsvAtiMxVrLcoSEGpayDTwvtkE(eajjwZPrXxeacjJCLDvvfAEFTHbc());
			sfUfgnMKsYqOirXLBOjvpaqrJGj(false);
			iVuwsQmFTTGFrVNSZBEpfQbWCIO();
			return;
		}
		if (ICuepaXlZxZzDMJYyZrwcIOhGOs)
		{
			XihvHrtxMyuRBhzCdkQyIlBKnWD();
		}
		if (kcoiUACBncevuyrKJkLfepispgtW.bgLAKkuspNIyPudbNgPBgmqQVpJG && kcoiUACBncevuyrKJkLfepispgtW.bXUJACnaYvOCANYOaVrTdSwcZxj())
		{
			SOTIqsKhbfvRbDbUarlymqitvYq();
		}
	}

	private void XihvHrtxMyuRBhzCdkQyIlBKnWD()
	{
		ICuepaXlZxZzDMJYyZrwcIOhGOs = false;
		if (!kcoiUACBncevuyrKJkLfepispgtW.bgLAKkuspNIyPudbNgPBgmqQVpJG)
		{
			kcoiUACBncevuyrKJkLfepispgtW.UBdDYFzJEaQOUTjUSMwjsblQggo();
		}
	}

	private void SOTIqsKhbfvRbDbUarlymqitvYq()
	{
		lock (kQIuWXPXWucicAjgmqinDLGrSMC)
		{
			Array.Copy(kQIuWXPXWucicAjgmqinDLGrSMC, JdiqGTQdUViyjiksKrReYGoAcdB, 4);
		}
		OgsvAtiMxVrLcoSEGpayDTwvtkE(JdiqGTQdUViyjiksKrReYGoAcdB);
	}

	private bool qzaVEjICGrbfeFngNzwFJPIyXDO()
	{
		lock (kQIuWXPXWucicAjgmqinDLGrSMC)
		{
			for (int i = 0; i < 4; i++)
			{
				if (bHUEwEqejQaMDEqpbfDDVSpZChq[i] != null)
				{
					kQIuWXPXWucicAjgmqinDLGrSMC[i] = bHUEwEqejQaMDEqpbfDDVSpZChq[i].JsKwgzgEGffAZfkTDHUconrRwJy(QUIZKudlqAinLhGdIvvzESzJkmn.vvuDxMkaGvgjyFPtTynZcBmcdWk);
				}
			}
		}
		return true;
	}

	private bool[] eajjwZPrXxeacjJCLDvvfAEFTHbc()
	{
		for (int i = 0; i < 4; i++)
		{
			JdiqGTQdUViyjiksKrReYGoAcdB[i] = bHUEwEqejQaMDEqpbfDDVSpZChq[i].JsKwgzgEGffAZfkTDHUconrRwJy(QUIZKudlqAinLhGdIvvzESzJkmn.vvuDxMkaGvgjyFPtTynZcBmcdWk);
		}
		return JdiqGTQdUViyjiksKrReYGoAcdB;
	}

	private void OgsvAtiMxVrLcoSEGpayDTwvtkE(bool[] P_0)
	{
		int num = 0;
		for (int i = 0; i < 4; i++)
		{
			if (bHUEwEqejQaMDEqpbfDDVSpZChq[i] != null && bHUEwEqejQaMDEqpbfDDVSpZChq[i].ycUGdCjZQhckbAkuclTQKcQUIVbc)
			{
				bool flag = P_0[i];
				bHUEwEqejQaMDEqpbfDDVSpZChq[i].AUjpiWJYqxOjcoGwuXPfcZSGuCq(flag);
				if (!flag)
				{
					vgdgoCexCwvDPdTnoaGlarCzHePe(bHUEwEqejQaMDEqpbfDDVSpZChq[i], false);
				}
			}
		}
		for (int j = 0; j < 4; j++)
		{
			if (bHUEwEqejQaMDEqpbfDDVSpZChq[j] != null && !bHUEwEqejQaMDEqpbfDDVSpZChq[j].ycUGdCjZQhckbAkuclTQKcQUIVbc)
			{
				bool flag2 = P_0[j];
				bHUEwEqejQaMDEqpbfDDVSpZChq[j].AUjpiWJYqxOjcoGwuXPfcZSGuCq(flag2);
				if (flag2 && !vgdgoCexCwvDPdTnoaGlarCzHePe(bHUEwEqejQaMDEqpbfDDVSpZChq[j], true))
				{
					num |= ((j == 0) ? 1 : (1 << j));
				}
			}
		}
		for (int k = 0; k < 4; k++)
		{
			if (bHUEwEqejQaMDEqpbfDDVSpZChq[k] != null)
			{
				int num2 = ((k == 0) ? 1 : (1 << k));
				if ((num & num2) != 1 << k)
				{
					bHUEwEqejQaMDEqpbfDDVSpZChq[k].DuLzdBiIRJtyMFbYAfIhcMogLuq(P_0[k]);
				}
			}
		}
	}

	private bool vgdgoCexCwvDPdTnoaGlarCzHePe(IHKymFjiuOAWDftVknObotjRfvu P_0, bool P_1)
	{
		if (P_1)
		{
			P_0.moBAhMeVbIBmfztITzmSbBSfEHUp();
			if (!P_0.MIcFDKFmbcoLIWvmEwicNqnQGGHh)
			{
				return false;
			}
			int num = cpsLJLsVkidwjpeYTDDwAeKdjlIh.xsUExAACzSdBhHUtEbTfEPilMZFZ(P_0.uEUQyyHHPDWVxiEMAuEGURvglkz, false);
			if (num >= 0)
			{
				P_0.rewiredId = cpsLJLsVkidwjpeYTDDwAeKdjlIh.SiBEDoFQySFRGIBcstyuOyBGECRM(num);
				cpsLJLsVkidwjpeYTDDwAeKdjlIh.EBZMKoSknSfzkSfokUzktanzxJf(num, P_0, true);
			}
			else
			{
				P_0.rewiredId = ilAOFbKaMpyqndLrycyBBEQAMvEC();
				cpsLJLsVkidwjpeYTDDwAeKdjlIh.pqYjtzKFMmHfzjSGGAqSJobyoop(P_0, true);
			}
			if (_UpdateControllerInfoEvent != null)
			{
				_UpdateControllerInfoEvent(new UpdateControllerInfoEventArgs(P_0));
			}
			BridgedController obj = P_0.ToBridgedController();
			if (_DeviceConnectedEvent != null)
			{
				_DeviceConnectedEvent(obj);
			}
		}
		else
		{
			int num2 = cpsLJLsVkidwjpeYTDDwAeKdjlIh.UYvBQuGGMbqlNcbsGdYBZFCHCRB(P_0.rewiredId, P_0.uEUQyyHHPDWVxiEMAuEGURvglkz, true);
			if (num2 >= 0)
			{
				cpsLJLsVkidwjpeYTDDwAeKdjlIh.riJgsmtxpIInWlTyRLalBYuYHnv(num2, false);
			}
			ControllerDisconnectedEventArgs obj2 = P_0.ToControllerDisconnectedEventArgs();
			P_0.JbagTVLJqlRcDShDKgcVdnYilVJ();
			if (_DeviceDisconnectedEvent != null)
			{
				_DeviceDisconnectedEvent(obj2);
			}
		}
		return true;
	}

	static gNZLZmnOEqwqMNKfeNUJNfMypUC()
	{
		aRMbxyytoWfMukziuPitiTewCcsh = new Guid[2]
		{
			new Guid("72100955-0000-0000-0000-504944564944"),
			new Guid("02e0045e-0000-0000-0000-504944564944")
		};
		IoGXjfQKDEIOzYKnBLcKjdWkuvC = new string[1] { "Xbox Bluetooth Gamepad" };
		SbCFpAkZWDvDsEAgdwguQVfQmRwa = new string[1] { "Xbox Wireless Controller.*" };
	}

	public static bool NeDbvgznpqCICmoNVeTAmiXHgNF(string P_0, string P_1, string P_2, Guid P_3)
	{
		if (ArrayTools.Contains(aRMbxyytoWfMukziuPitiTewCcsh, P_3))
		{
			return true;
		}
		if (!string.IsNullOrEmpty(P_1))
		{
			for (int i = 0; i < IoGXjfQKDEIOzYKnBLcKjdWkuvC.Length; i++)
			{
				if (P_1.Equals(IoGXjfQKDEIOzYKnBLcKjdWkuvC[i], StringComparison.OrdinalIgnoreCase))
				{
					return true;
				}
			}
		}
		if (!string.IsNullOrEmpty(P_2))
		{
			for (int j = 0; j < SbCFpAkZWDvDsEAgdwguQVfQmRwa.Length; j++)
			{
				if (Regex.IsMatch(P_2, SbCFpAkZWDvDsEAgdwguQVfQmRwa[j], RegexOptions.IgnoreCase))
				{
					return true;
				}
			}
		}
		P_0 = P_0.ToLower();
		int num = P_0.IndexOf("vid_");
		if (num < 0)
		{
			return false;
		}
		if (P_0.IndexOf("ig_") < num)
		{
			return false;
		}
		return true;
	}
}
