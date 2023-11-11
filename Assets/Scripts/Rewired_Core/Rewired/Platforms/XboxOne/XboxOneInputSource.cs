using System;
using System.Collections.Generic;
using Rewired.Platforms.Custom;
using Rewired.Utils;
using UnityEngine;

namespace Rewired.Platforms.XboxOne
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal sealed class XboxOneInputSource : CustomInputSource, IXboxOneInputSource
	{
		[CustomObfuscation(rename = false)]
		private enum BadConnectionReason
		{
			[CustomObfuscation(rename = false)]
			None = 0,
			[CustomObfuscation(rename = false)]
			GamepadNotActive = 1,
			[CustomObfuscation(rename = false)]
			InvalidName = 2
		}

		private struct VwYRyPNMwQIXITkZYQWUyMUcXDO
		{
			public uint EnPeIJWjToVVbuIEISSleYPzkbu;

			public uint bseZuqCTlhICHdRWAfXsoxxFrIc;

			public VwYRyPNMwQIXITkZYQWUyMUcXDO(uint unityJoystickId, uint connectedFrame)
			{
				EnPeIJWjToVVbuIEISSleYPzkbu = unityJoystickId;
				bseZuqCTlhICHdRWAfXsoxxFrIc = connectedFrame;
			}
		}

		private class pzNRFntIGTtVDzTrgePIcNUhfyO : Joystick
		{
			private const int jkUjRKTApmafglzOsRUiurZItVM = 6;

			private const int HUrvKXNmSdRrTKWEwIovQAsSEipJ = 14;

			private const string WoadXXzzHPInrglesullbgNTSZp = "Xbox One Controller";

			private const int fqyhYlWxrfhwTwTDMQaPDjCxzvQ = 0;

			private const int EOBisXvNrFIAVNXuoINwvEyooIv = 1;

			private const int nGBTiODhKYbjpLcrcmSOXwpGpPc = 2;

			private const int MMtFnbFhGHuqniSNjkRrDWhOlkoF = 3;

			private const int XnvdzbetHKhbgnxwhQuQvqZIvFO = 4;

			private const int gjFSTBYKBkZCTWANWSOFqLaXFIrG = 5;

			private const int QXoaMgMhokfYSAVVcymdziyfdYN = 6;

			private const int tYjlFcsPSAcTViPzYfZFhzIZoIEq = 7;

			private const int FoXnCSdXHOmYZomNWuEGzQDXdUU = 8;

			private const int bseXmTUwlHrqXlkFybZOiAfnOTkB = 9;

			private const int OEPiAjXolITzYKeawcJpzSjvcFwE = 12;

			private const int LBBmBGtWJoANDKKWYVYWGPgppJL = 13;

			private const int xoWOLyxhVVjmzMEbWFVZnCnGLiX = 14;

			private const int bJbBSSKKySWaXUlvJNYWeAHEFhEq = 15;

			private const int dLLPuCwSHBhhXFATxHeuaRaTGXcc = 0;

			private const int GBePDyQixlEUBkvUbyxSzXATUEu = 1;

			private const int TMDbErSCJdzsLPaISHABmwLVoFf = 3;

			private const int GEGWnLuRxySefstAXYMLsJmPDol = 4;

			private const int nyiAAUTbpHkMNEItyoAXRnvAgzeF = 8;

			private const int YZhEjDDdaicAfDLOsxwwjLBNGTu = 9;

			private readonly IXboxOneInputSource qhnYJqFPpPHTJjpxtkZKYxgPeLP;

			private int pqMExzQXMHxPhjePgBsVkpjmHaPc;

			private ulong yuiTtLDzcKBlNZmJdxEmhQAblvv;

			private string[] NXqlRyDCMOciHShWZTSySMBwTcn;

			public ulong fTYARuyGVZmzXJhlAWOOJfMbadK => yuiTtLDzcKBlNZmJdxEmhQAblvv;

			public pzNRFntIGTtVDzTrgePIcNUhfyO(IXboxOneInputSource inputSource, ulong xboxControllerId, int unityJoystickId, bool isConnected)
				: base(isConnected ? UnityTools.externalTools.XboxOneInput_GetControllerType(xboxControllerId) : "Xbox One Controller", (long)xboxControllerId, unityJoystickId, 6, 14)
			{
				qhnYJqFPpPHTJjpxtkZKYxgPeLP = inputSource;
				pqMExzQXMHxPhjePgBsVkpjmHaPc = unityJoystickId - 1;
				NXqlRyDCMOciHShWZTSySMBwTcn = new string[6];
				aorXmMxAHfuwavZzplCeIOEsGrBJ();
				base.extension = new XboxOneGamepadExtension(supportsVibration: true, inputSource);
				_isConnected = isConnected;
				if (_isConnected)
				{
					ijQPrfbohIDtyfCSvLMVhrlmSpB(xboxControllerId);
				}
				else
				{
					yuiTtLDzcKBlNZmJdxEmhQAblvv = xboxControllerId;
				}
			}

			public virtual void mtiNfGzpXHszOwiOIAVYQuMZclV()
			{
				if (_isConnected)
				{
					IList<Button> buttons = base.Buttons;
					buttons[0].value = TCWvrlpYTrIwTmaFZCrFglGyZdS(0);
					buttons[1].value = TCWvrlpYTrIwTmaFZCrFglGyZdS(1);
					buttons[2].value = TCWvrlpYTrIwTmaFZCrFglGyZdS(2);
					buttons[3].value = TCWvrlpYTrIwTmaFZCrFglGyZdS(3);
					buttons[4].value = TCWvrlpYTrIwTmaFZCrFglGyZdS(4);
					buttons[5].value = TCWvrlpYTrIwTmaFZCrFglGyZdS(5);
					buttons[6].value = TCWvrlpYTrIwTmaFZCrFglGyZdS(6);
					buttons[7].value = TCWvrlpYTrIwTmaFZCrFglGyZdS(7);
					buttons[8].value = TCWvrlpYTrIwTmaFZCrFglGyZdS(8);
					buttons[9].value = TCWvrlpYTrIwTmaFZCrFglGyZdS(9);
					buttons[10].value = TCWvrlpYTrIwTmaFZCrFglGyZdS(12);
					buttons[11].value = TCWvrlpYTrIwTmaFZCrFglGyZdS(15);
					buttons[12].value = TCWvrlpYTrIwTmaFZCrFglGyZdS(13);
					buttons[13].value = TCWvrlpYTrIwTmaFZCrFglGyZdS(14);
					IList<Axis> axes = base.Axes;
					axes[0].value = Input.GetAxisRaw(NXqlRyDCMOciHShWZTSySMBwTcn[0]);
					axes[1].value = Input.GetAxisRaw(NXqlRyDCMOciHShWZTSySMBwTcn[1]);
					axes[2].value = Input.GetAxisRaw(NXqlRyDCMOciHShWZTSySMBwTcn[2]);
					axes[3].value = Input.GetAxisRaw(NXqlRyDCMOciHShWZTSySMBwTcn[3]);
					axes[4].value = Input.GetAxisRaw(NXqlRyDCMOciHShWZTSySMBwTcn[4]);
					axes[5].value = Input.GetAxisRaw(NXqlRyDCMOciHShWZTSySMBwTcn[5]);
				}
			}

			public void ijQPrfbohIDtyfCSvLMVhrlmSpB(ulong P_0)
			{
				if (!_isConnected)
				{
					_isConnected = true;
					yuiTtLDzcKBlNZmJdxEmhQAblvv = P_0;
					base.systemId = (long)P_0;
					if (UnityTools.externalTools.XboxOneInput_GetJoystickId(P_0) != (uint)base.unityId)
					{
						Logger.LogError("Unity joystick id does not match expected id!");
						_isConnected = false;
					}
					else
					{
						VRXOHRqlwbKPGDdjQDqqixMHZHq();
					}
				}
			}

			private void VRXOHRqlwbKPGDdjQDqqixMHZHq()
			{
				if (_isConnected)
				{
					_deviceName = UnityTools.externalTools.XboxOneInput_GetControllerType(yuiTtLDzcKBlNZmJdxEmhQAblvv);
				}
				_customName = "Controller " + base.unityId;
			}

			private bool TCWvrlpYTrIwTmaFZCrFglGyZdS(int P_0)
			{
				int key = 350 + P_0 + pqMExzQXMHxPhjePgBsVkpjmHaPc * 20;
				return Input.GetKey((KeyCode)key);
			}

			private void aorXmMxAHfuwavZzplCeIOEsGrBJ()
			{
				NXqlRyDCMOciHShWZTSySMBwTcn[0] = UnityTools.GetUnityInputAxisNameByJoystickId(base.unityId, 0);
				NXqlRyDCMOciHShWZTSySMBwTcn[1] = UnityTools.GetUnityInputAxisNameByJoystickId(base.unityId, 1);
				NXqlRyDCMOciHShWZTSySMBwTcn[2] = UnityTools.GetUnityInputAxisNameByJoystickId(base.unityId, 3);
				NXqlRyDCMOciHShWZTSySMBwTcn[3] = UnityTools.GetUnityInputAxisNameByJoystickId(base.unityId, 4);
				NXqlRyDCMOciHShWZTSySMBwTcn[4] = UnityTools.GetUnityInputAxisNameByJoystickId(base.unityId, 8);
				NXqlRyDCMOciHShWZTSySMBwTcn[5] = UnityTools.GetUnityInputAxisNameByJoystickId(base.unityId, 9);
			}
		}

		private const int yDSrmcWBaeRxNDcTOCopuKATODU = 8;

		private readonly bool sQTBWTNxxjaWNFsekFBPFIwaffDK;

		private bool PobchLswPbkLDZcvvEGhuLoygBV;

		private Queue<VwYRyPNMwQIXITkZYQWUyMUcXDO> cJrybxEBOtKtBiczsyWcvaLYulf;

		private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

		public override bool isReady => sQTBWTNxxjaWNFsekFBPFIwaffDK;

		public XboxOneInputSource()
			: base(21)
		{
			try
			{
				cJrybxEBOtKtBiczsyWcvaLYulf = new Queue<VwYRyPNMwQIXITkZYQWUyMUcXDO>();
				base.useApproximateMatching = false;
				for (int i = 0; i < 8; i++)
				{
					int num = i + 1;
					BadConnectionReason badConnectionReason;
					bool flag = YDLtRqTgYrJXldKOgCqKKnUufgA((uint)num, true, out badConnectionReason);
					ulong xboxControllerId = (flag ? UnityTools.externalTools.XboxOneInput_GetControllerId((uint)num) : 0);
					AddJoystick(new pzNRFntIGTtVDzTrgePIcNUhfyO(this, xboxControllerId, num, flag)
					{
						supportsVibration = true
					});
				}
				UnityTools.externalTools.XboxOneInput_OnGamepadStateChange += wJCIseIDiCNKqCKKzjkSwgrSQiP;
				sQTBWTNxxjaWNFsekFBPFIwaffDK = true;
			}
			catch
			{
			}
		}

		public override void Update()
		{
			if (sQTBWTNxxjaWNFsekFBPFIwaffDK)
			{
				jfxPgithsBFzYaRMDJQxqYFNRnR();
				UnityTools.externalTools.XboxOne_Gamepad_UpdatePlugin();
				IList<Joystick> joysticks = GetJoysticks();
				int count = joysticks.Count;
				for (int i = 0; i < count; i++)
				{
					joysticks[i].Update();
				}
			}
		}

		private void wJCIseIDiCNKqCKKzjkSwgrSQiP(uint P_0, bool P_1)
		{
			if (!sQTBWTNxxjaWNFsekFBPFIwaffDK)
			{
				return;
			}
			if (P_0 == 0)
			{
				Logger.LogError("Invalid unity joystick id");
			}
			else if (P_1)
			{
				if (YDLtRqTgYrJXldKOgCqKKnUufgA(P_0, true, out var _))
				{
					AMmGxxEvxBcWTiBnfFfvwXMDwe(P_0, true);
				}
			}
			else
			{
				int index = (int)(P_0 - 1);
				pzNRFntIGTtVDzTrgePIcNUhfyO pzNRFntIGTtVDzTrgePIcNUhfyO = GetJoysticks()[index] as pzNRFntIGTtVDzTrgePIcNUhfyO;
				pzNRFntIGTtVDzTrgePIcNUhfyO.Disconnect();
				OnJoystickDisconnected();
			}
		}

		private void AMmGxxEvxBcWTiBnfFfvwXMDwe(uint P_0, bool P_1)
		{
			int index = (int)(P_0 - 1);
			pzNRFntIGTtVDzTrgePIcNUhfyO pzNRFntIGTtVDzTrgePIcNUhfyO = GetJoysticks()[index] as pzNRFntIGTtVDzTrgePIcNUhfyO;
			ulong num = UnityTools.externalTools.XboxOneInput_GetControllerId(P_0);
			pzNRFntIGTtVDzTrgePIcNUhfyO.ijQPrfbohIDtyfCSvLMVhrlmSpB(num);
			if (P_1)
			{
				OnJoystickConnected();
			}
		}

		private void jfxPgithsBFzYaRMDJQxqYFNRnR()
		{
			int num = cJrybxEBOtKtBiczsyWcvaLYulf.Count;
			if (num == 0)
			{
				return;
			}
			bool flag = false;
			uint currentFrame = ReInput.time.currentFrame;
			while (num > 0)
			{
				VwYRyPNMwQIXITkZYQWUyMUcXDO item = cJrybxEBOtKtBiczsyWcvaLYulf.Dequeue();
				if (currentFrame >= item.bseZuqCTlhICHdRWAfXsoxxFrIc + 1)
				{
					if (YDLtRqTgYrJXldKOgCqKKnUufgA(item.EnPeIJWjToVVbuIEISSleYPzkbu, true, out var _))
					{
						AMmGxxEvxBcWTiBnfFfvwXMDwe(item.EnPeIJWjToVVbuIEISSleYPzkbu, false);
						flag = true;
					}
				}
				else
				{
					cJrybxEBOtKtBiczsyWcvaLYulf.Enqueue(item);
				}
				num--;
			}
			if (flag)
			{
				OnJoystickConnected();
			}
		}

		private bool YDLtRqTgYrJXldKOgCqKKnUufgA(uint P_0, bool P_1, out BadConnectionReason P_2)
		{
			if (!UnityTools.externalTools.XboxOneInput_IsGamepadActive(P_0))
			{
				P_2 = BadConnectionReason.GamepadNotActive;
				return false;
			}
			string text = UnityTools.externalTools.XboxOneInput_GetControllerType(UnityTools.externalTools.XboxOneInput_GetControllerId(P_0));
			if (string.IsNullOrEmpty(text) || text == " ")
			{
				if (P_1)
				{
					cJrybxEBOtKtBiczsyWcvaLYulf.Enqueue(new VwYRyPNMwQIXITkZYQWUyMUcXDO(P_0, ReInput.time.currentFrame));
				}
				P_2 = BadConnectionReason.InvalidName;
				return false;
			}
			P_2 = BadConnectionReason.None;
			return true;
		}

		private void UMSbJbANXLBbPRkPyuRFavVjknu()
		{
			if (!PobchLswPbkLDZcvvEGhuLoygBV)
			{
				PobchLswPbkLDZcvvEGhuLoygBV = true;
				Logger.LogError("A required native library is missing! See documentation for Xbox One installation instructions.");
			}
		}

		public int GetXboxOneUserIdFromUnityJoystick(int unityJoystickId)
		{
			if (!sQTBWTNxxjaWNFsekFBPFIwaffDK)
			{
				return -1;
			}
			return UnityTools.externalTools.XboxOneInput_GetUserIdForGamepad((uint)unityJoystickId);
		}

		public void PulseVibrateMotor(ulong xboxOneJoystickId, XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration)
		{
			if (sQTBWTNxxjaWNFsekFBPFIwaffDK)
			{
				ulong durationMS = (ulong)(duration * 1000f);
				UnityTools.externalTools.XboxOne_Gamepad_PulseVibrateMotor(xboxOneJoystickId, (int)motor, startLevel, endLevel, durationMS);
			}
		}

		public bool SetXboxOneVibration(ulong xboxOneJoystickId, LbhiVMAGGlMXhcUfcRjbBFoDceTt vibration)
		{
			if (!sQTBWTNxxjaWNFsekFBPFIwaffDK)
			{
				return false;
			}
			return UnityTools.externalTools.XboxOne_Gamepad_SetGamepadVibration(xboxOneJoystickId, vibration.dGxjKhnytjNHvsOIZjFLjcsgGbip, vibration.pdfZdEwqLUgequAHOokegpZXFyg, vibration.dmCuYmCWCZIpjGCygOoQUQUYqiW, vibration.qMFemiBWVOGfgxWkBVdjNaRDdeog);
		}

		public override void Dispose()
		{
			base.Dispose();
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		~XboxOneInputSource()
		{
			Dispose(disposing: false);
		}

		protected override void Dispose(bool disposing)
		{
			if (!RFSEgUYkCipDyWyLEnlGiNDUlzz)
			{
				if (disposing)
				{
					UnityTools.externalTools.XboxOneInput_OnGamepadStateChange -= wJCIseIDiCNKqCKKzjkSwgrSQiP;
				}
				RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
			}
		}
	}
}
