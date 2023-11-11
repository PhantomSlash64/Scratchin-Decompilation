using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Rewired;
using Rewired.Data;
using Rewired.Data.Mapping;
using Rewired.InputSources.SDL2;
using Rewired.Interfaces;
using Rewired.Utils;

internal class lfWAkuOTJbfALchOQejzQHLPmoS : PlatformInputManager
{
	private class oPxlYzxmpKqCVdyTLGtmtYcnoIL : IInputManagerJoystickPublic, IInputManagerJoystick
	{
		private int xUifcgfakaZXegCEIyIvyNVPONw;

		private int yCFCZIHUtxubaOkYtznBnuzDsZQ;

		public Guid lwdxrsNKwLhtAYwqCDFXheqlLse;

		public string hWzaFpBPqOqXtgXfRusVaANlJNbS;

		public HpPUYiSsBwKxKGqHrpbgrhShPgI lLunFdsBZKbwbTGDtevQjFyRGyC;

		public fwfZKOZIrzVVMmsLWTqxjrPbdnz qouleEuZVsuDwHelRwYCaeeIDilH;

		public string nkjULWvORMLZzfOOzNIPKqWvsaF;

		public string cwXKEfmJwgVuncJVtimNSLaSlwa;

		public int HobfqJsoBexlFijbsSVcDQthfKhI;

		public int vPXJpqINRqPFfbvxiOgRleAPgZX;

		public Guid OCGARjuFZDQxfTIIHeiAPOePthL;

		public PidVid bxkXdlCJVCfVuquTGeTMqKnvsia;

		public Guid gxPXyJYkNvLbaqTgLRuQmqNdpBm;

		public int MLuHYSGDrYmZeQZcxiBDPZJHOrw;

		public int KvWYoUeQcKYRiSuZzzFxrcVXiqk;

		public int ZsZVmkTkPjWelvFISDijpisYNoj;

		public int NYvYvrFEEijFdVCAIndoQIHvsaN;

		public int GrUhAFHLKEgABIxWQoBcgoHzLeBJ;

		public int pIQcvYYQMqcLgcMdiKuLfdjyBeg;

		public bool hIkLfDXQbAOfZYOIZSqoiFglIWB;

		public bool YxSCQUilOVOVIAbfGmstlMmXgrqk;

		public int DgKZIwUKWYpoRBbYIharycQNYrN;

		private float[] fMaBRrMSrsdNukczypLZCirAhksd;

		private bool[] PVITKWpmXlCUxbOeOgCPsJPiOjmf;

		private HardwareJoystickMap_InputManager pAhzhvigFoLFbwPDdcXHatZWRIl;

		private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> PkYFoJbHDSFVrSOHBVJAgJwpYncH;

		private bool ARlfjKENsrtBRijsETyXRSanBDzS;

		private bool xwlciijKucqyJFICAlBeQdiMzfmY;

		[CompilerGenerated]
		private Controller.Extension qSJljWHcFqhviFjwYGHIYMoHmFhT;

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
		public string name => hWzaFpBPqOqXtgXfRusVaANlJNbS;

		[CustomObfuscation(rename = false)]
		public long? systemId
		{
			get
			{
				if (yCFCZIHUtxubaOkYtznBnuzDsZQ < 0)
				{
					return null;
				}
				return yCFCZIHUtxubaOkYtznBnuzDsZQ;
			}
		}

		[CustomObfuscation(rename = false)]
		public int unityId => 0;

		[CustomObfuscation(rename = false)]
		public Guid instanceGuid => OCGARjuFZDQxfTIIHeiAPOePthL;

		[CustomObfuscation(rename = false)]
		public Guid persistentGuid => instanceGuid;

		[CustomObfuscation(rename = false)]
		public Controller.Extension extension
		{
			[CompilerGenerated]
			get
			{
				return qSJljWHcFqhviFjwYGHIYMoHmFhT;
			}
			[CompilerGenerated]
			set
			{
				qSJljWHcFqhviFjwYGHIYMoHmFhT = value;
			}
		}

		[CustomObfuscation(rename = false)]
		public void SetVibration(float amount, int motorIndex)
		{
			lLunFdsBZKbwbTGDtevQjFyRGyC.AkBEJVrhYVwhTojcZyLajUzQQYz(motorIndex, amount, false);
		}

		[CustomObfuscation(rename = false)]
		public void StopVibration()
		{
		}

		public oPxlYzxmpKqCVdyTLGtmtYcnoIL(Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager)
		{
			PkYFoJbHDSFVrSOHBVJAgJwpYncH = getHardwareJoystickMap_InputManager;
			yCFCZIHUtxubaOkYtznBnuzDsZQ = -1;
			xUifcgfakaZXegCEIyIvyNVPONw = -1;
		}

		public void UcMFLlIeEVgVHdWycYuHxpkWVTYD()
		{
			gxPXyJYkNvLbaqTgLRuQmqNdpBm = MiscTools.CreateGuidHashSHA1(nkjULWvORMLZzfOOzNIPKqWvsaF + bxkXdlCJVCfVuquTGeTMqKnvsia.ToProductGuid());
			KvWYoUeQcKYRiSuZzzFxrcVXiqk = NYvYvrFEEijFdVCAIndoQIHvsaN;
			ZsZVmkTkPjWelvFISDijpisYNoj = GrUhAFHLKEgABIxWQoBcgoHzLeBJ + pIQcvYYQMqcLgcMdiKuLfdjyBeg * 8;
			fnbWnKnajTExrfChSQLkKMdqfpwH();
			lwdxrsNKwLhtAYwqCDFXheqlLse = pAhzhvigFoLFbwPDdcXHatZWRIl.hardwareMapIdentifier.guid;
			hWzaFpBPqOqXtgXfRusVaANlJNbS = pAhzhvigFoLFbwPDdcXHatZWRIl.controllerName;
			ARlfjKENsrtBRijsETyXRSanBDzS = ((lwdxrsNKwLhtAYwqCDFXheqlLse == Guid.Empty) ? true : false);
			fMaBRrMSrsdNukczypLZCirAhksd = new float[KvWYoUeQcKYRiSuZzzFxrcVXiqk];
			PVITKWpmXlCUxbOeOgCPsJPiOjmf = new bool[ZsZVmkTkPjWelvFISDijpisYNoj];
			Update();
		}

		public void QwulHzCeLMcALfriecpsBcgtEiTX(oPxlYzxmpKqCVdyTLGtmtYcnoIL P_0)
		{
			if (P_0 != null)
			{
				yCFCZIHUtxubaOkYtznBnuzDsZQ = P_0.yCFCZIHUtxubaOkYtznBnuzDsZQ;
				xUifcgfakaZXegCEIyIvyNVPONw = P_0.xUifcgfakaZXegCEIyIvyNVPONw;
				for (int i = 0; i < MathTools.Min(PVITKWpmXlCUxbOeOgCPsJPiOjmf.Length, P_0.PVITKWpmXlCUxbOeOgCPsJPiOjmf.Length); i++)
				{
					PVITKWpmXlCUxbOeOgCPsJPiOjmf[i] = P_0.PVITKWpmXlCUxbOeOgCPsJPiOjmf[i];
				}
				for (int j = 0; j < MathTools.Min(fMaBRrMSrsdNukczypLZCirAhksd.Length, P_0.fMaBRrMSrsdNukczypLZCirAhksd.Length); j++)
				{
					fMaBRrMSrsdNukczypLZCirAhksd[j] = P_0.fMaBRrMSrsdNukczypLZCirAhksd[j];
				}
				xwlciijKucqyJFICAlBeQdiMzfmY = P_0.xwlciijKucqyJFICAlBeQdiMzfmY;
			}
		}

		[CustomObfuscation(rename = false)]
		public void Update()
		{
			mrcgZsySeBJGLJfZMFgQRpWqKcPu();
			ZoEfBvZLEHeQeEqRqOmhOcalkaSu();
			if (!xwlciijKucqyJFICAlBeQdiMzfmY && lLunFdsBZKbwbTGDtevQjFyRGyC.VVvDugwQqcGqEPhjYBFKOHmpHAGI)
			{
				xwlciijKucqyJFICAlBeQdiMzfmY = true;
			}
		}

		[CustomObfuscation(rename = false)]
		public void FillData(ControllerDataUpdater dataUpdater)
		{
			if (KvWYoUeQcKYRiSuZzzFxrcVXiqk != dataUpdater.axisCount || ZsZVmkTkPjWelvFISDijpisYNoj != dataUpdater.buttonCount)
			{
				throw new Exception("This controller signature does not match the data object!");
			}
			for (int i = 0; i < KvWYoUeQcKYRiSuZzzFxrcVXiqk; i++)
			{
				dataUpdater.axisValues[i] = fMaBRrMSrsdNukczypLZCirAhksd[i];
			}
			for (int j = 0; j < ZsZVmkTkPjWelvFISDijpisYNoj; j++)
			{
				dataUpdater.buttonValues[j] = PVITKWpmXlCUxbOeOgCPsJPiOjmf[j];
			}
			if (xwlciijKucqyJFICAlBeQdiMzfmY && !dataUpdater.hasReceivedInput)
			{
				dataUpdater.hasReceivedInput = true;
			}
		}

		public int sRrGplMHNlzmCBfgKNqGViUdGhN(oPxlYzxmpKqCVdyTLGtmtYcnoIL P_0)
		{
			if (P_0.xUifcgfakaZXegCEIyIvyNVPONw == xUifcgfakaZXegCEIyIvyNVPONw)
			{
				return 2;
			}
			if (NYvYvrFEEijFdVCAIndoQIHvsaN != P_0.NYvYvrFEEijFdVCAIndoQIHvsaN)
			{
				return 0;
			}
			if (GrUhAFHLKEgABIxWQoBcgoHzLeBJ != P_0.GrUhAFHLKEgABIxWQoBcgoHzLeBJ)
			{
				return 0;
			}
			if (pIQcvYYQMqcLgcMdiKuLfdjyBeg != P_0.pIQcvYYQMqcLgcMdiKuLfdjyBeg)
			{
				return 0;
			}
			if (P_0.OCGARjuFZDQxfTIIHeiAPOePthL == OCGARjuFZDQxfTIIHeiAPOePthL)
			{
				return 2;
			}
			if (P_0.gxPXyJYkNvLbaqTgLRuQmqNdpBm == gxPXyJYkNvLbaqTgLRuQmqNdpBm)
			{
				return 1;
			}
			return 0;
		}

		private BridgedControllerHWInfo rtmepNGyphMMGYpeiwSMrmBNGeQC()
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

		private void mrcgZsySeBJGLJfZMFgQRpWqKcPu()
		{
			if (KvWYoUeQcKYRiSuZzzFxrcVXiqk <= 0)
			{
				return;
			}
			InputPlatform platform = pAhzhvigFoLFbwPDdcXHatZWRIl.map.platform;
			if (platform != InputPlatform.XMHoMMmBpsltlmFRkyGyIaozrbG)
			{
				return;
			}
			HardwareJoystickMap.Platform_SDL2_Base platform_SDL2_Base = (HardwareJoystickMap.Platform_SDL2_Base)pAhzhvigFoLFbwPDdcXHatZWRIl.map;
			HardwareJoystickMap.Platform_SDL2_Base.Axis[] axes_orig = platform_SDL2_Base.Axes_orig;
			if (axes_orig != null)
			{
				for (int i = 0; i < axes_orig.Length; i++)
				{
					vwCGEVJmcExHanreAGQEYnAiPAG(axes_orig[i], i);
				}
			}
		}

		private void ZoEfBvZLEHeQeEqRqOmhOcalkaSu()
		{
			if (ZsZVmkTkPjWelvFISDijpisYNoj <= 0)
			{
				return;
			}
			HardwareJoystickMap.Platform_SDL2_Base platform_SDL2_Base = (HardwareJoystickMap.Platform_SDL2_Base)pAhzhvigFoLFbwPDdcXHatZWRIl.map;
			HardwareJoystickMap.Platform_SDL2_Base.Button[] buttons_orig = platform_SDL2_Base.Buttons_orig;
			if (buttons_orig != null)
			{
				for (int i = 0; i < buttons_orig.Length; i++)
				{
					zAtEVxWFlZdWgQaBtDksfWeBahCr(buttons_orig[i], i);
				}
			}
		}

		private void vwCGEVJmcExHanreAGQEYnAiPAG(HardwareJoystickMap.Platform_SDL2_Base.Axis P_0, int P_1)
		{
			if (P_1 >= KvWYoUeQcKYRiSuZzzFxrcVXiqk)
			{
				throw new Exception("Number of axes in hardware map does not match number of axes found in controller!");
			}
			fMaBRrMSrsdNukczypLZCirAhksd[P_1] = gSbFUoUKksdvWoYrVCrMmdUmQbI(P_0);
		}

		private void zAtEVxWFlZdWgQaBtDksfWeBahCr(HardwareJoystickMap.Platform_SDL2_Base.Button P_0, int P_1)
		{
			if (P_1 >= ZsZVmkTkPjWelvFISDijpisYNoj)
			{
				throw new Exception("Number of buttons in hardware map does not match number of buttons found in controller!");
			}
			PVITKWpmXlCUxbOeOgCPsJPiOjmf[P_1] = MBcFiZeZyRdrKwPqvdeFcRGWuORk(P_0);
		}

		private float gSbFUoUKksdvWoYrVCrMmdUmQbI(HardwareJoystickMap.Platform_SDL2_Base.Axis P_0)
		{
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Axis)
			{
				int sourceAxis = P_0.sourceAxis;
				if (sourceAxis < 0 || sourceAxis >= NYvYvrFEEijFdVCAIndoQIHvsaN || sourceAxis >= 56)
				{
					return 0f;
				}
				return lLunFdsBZKbwbTGDtevQjFyRGyC.gSbFUoUKksdvWoYrVCrMmdUmQbI(sourceAxis);
			}
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Button)
			{
				int sourceButton = P_0.sourceButton;
				if (sourceButton < 0 || sourceButton >= GrUhAFHLKEgABIxWQoBcgoHzLeBJ || sourceButton >= 256)
				{
					return 0f;
				}
				if (!lLunFdsBZKbwbTGDtevQjFyRGyC.MBcFiZeZyRdrKwPqvdeFcRGWuORk(sourceButton))
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
				if (sourceHat < 0 || sourceHat >= pIQcvYYQMqcLgcMdiKuLfdjyBeg || sourceHat >= 4)
				{
					return 0f;
				}
				int num = lLunFdsBZKbwbTGDtevQjFyRGyC.jfPUflNnCZMeVqEBBFKeenCrTcU(sourceHat);
				if (num < 0)
				{
					return 0f;
				}
				float num2;
				if (P_0.sourceHatDirection == AxisDirection.Horizontal)
				{
					num2 = ZCvPNPBKdZoniRnxXCWvQUoqEMm(num, AxisDirection.Horizontal);
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
					num2 = ZCvPNPBKdZoniRnxXCWvQUoqEMm(num, AxisDirection.Vertical);
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

		private bool MBcFiZeZyRdrKwPqvdeFcRGWuORk(HardwareJoystickMap.Platform_SDL2_Base.Button P_0)
		{
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Button)
			{
				if (P_0.ignoreIfButtonsActive)
				{
					for (int i = 0; i < P_0.ignoreIfButtonsActiveButtons.Length; i++)
					{
						if (lLunFdsBZKbwbTGDtevQjFyRGyC.MBcFiZeZyRdrKwPqvdeFcRGWuORk(P_0.ignoreIfButtonsActiveButtons[i]))
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
						if (!lLunFdsBZKbwbTGDtevQjFyRGyC.MBcFiZeZyRdrKwPqvdeFcRGWuORk(P_0.requiredButtons[j]))
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
				if (sourceButton < 0 || sourceButton >= GrUhAFHLKEgABIxWQoBcgoHzLeBJ || sourceButton >= 256)
				{
					return false;
				}
				return lLunFdsBZKbwbTGDtevQjFyRGyC.MBcFiZeZyRdrKwPqvdeFcRGWuORk(sourceButton);
			}
			if (P_0.sourceType == HardwareElementSourceTypeWithHat.Axis)
			{
				int sourceAxis = P_0.sourceAxis;
				if (sourceAxis <= 0 || sourceAxis >= NYvYvrFEEijFdVCAIndoQIHvsaN || sourceAxis >= 56)
				{
					return false;
				}
				float num = lLunFdsBZKbwbTGDtevQjFyRGyC.gSbFUoUKksdvWoYrVCrMmdUmQbI(sourceAxis);
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
				if (sourceHat < 0 || sourceHat >= pIQcvYYQMqcLgcMdiKuLfdjyBeg || sourceHat >= 4)
				{
					return false;
				}
				switch (P_0.sourceHatDirection)
				{
				case HatDirection.Up:
					return QxdEPCijDBUnGCrfIfdOXfarCMM(lLunFdsBZKbwbTGDtevQjFyRGyC.jfPUflNnCZMeVqEBBFKeenCrTcU(sourceHat), 0, P_0.sourceHatType);
				case HatDirection.UpRight:
					return QxdEPCijDBUnGCrfIfdOXfarCMM(lLunFdsBZKbwbTGDtevQjFyRGyC.jfPUflNnCZMeVqEBBFKeenCrTcU(sourceHat), 1, P_0.sourceHatType);
				case HatDirection.Right:
					return QxdEPCijDBUnGCrfIfdOXfarCMM(lLunFdsBZKbwbTGDtevQjFyRGyC.jfPUflNnCZMeVqEBBFKeenCrTcU(sourceHat), 2, P_0.sourceHatType);
				case HatDirection.DownRight:
					return QxdEPCijDBUnGCrfIfdOXfarCMM(lLunFdsBZKbwbTGDtevQjFyRGyC.jfPUflNnCZMeVqEBBFKeenCrTcU(sourceHat), 3, P_0.sourceHatType);
				case HatDirection.Down:
					return QxdEPCijDBUnGCrfIfdOXfarCMM(lLunFdsBZKbwbTGDtevQjFyRGyC.jfPUflNnCZMeVqEBBFKeenCrTcU(sourceHat), 4, P_0.sourceHatType);
				case HatDirection.DownLeft:
					return QxdEPCijDBUnGCrfIfdOXfarCMM(lLunFdsBZKbwbTGDtevQjFyRGyC.jfPUflNnCZMeVqEBBFKeenCrTcU(sourceHat), 5, P_0.sourceHatType);
				case HatDirection.Left:
					return QxdEPCijDBUnGCrfIfdOXfarCMM(lLunFdsBZKbwbTGDtevQjFyRGyC.jfPUflNnCZMeVqEBBFKeenCrTcU(sourceHat), 6, P_0.sourceHatType);
				case HatDirection.UpLeft:
					return QxdEPCijDBUnGCrfIfdOXfarCMM(lLunFdsBZKbwbTGDtevQjFyRGyC.jfPUflNnCZMeVqEBBFKeenCrTcU(sourceHat), 7, P_0.sourceHatType);
				}
			}
			return false;
		}

		private bool QxdEPCijDBUnGCrfIfdOXfarCMM(int P_0, int P_1, HatType P_2)
		{
			if (P_0 < 0)
			{
				return false;
			}
			if (pAhzhvigFoLFbwPDdcXHatZWRIl.isUnknownController && !InputTools.HandleForced4WayHatsOnUnknownControllers(P_1, ref P_2))
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

		private float ZCvPNPBKdZoniRnxXCWvQUoqEMm(int P_0, AxisDirection P_1)
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

		private ControlDeviceType mWkEwUWjfWhlPyxPtpmHxkdtijqK(fwfZKOZIrzVVMmsLWTqxjrPbdnz P_0)
		{
			return P_0 switch
			{
				fwfZKOZIrzVVMmsLWTqxjrPbdnz.QIiFjjgvNmDRWWXPiwXfgdhsPuPT => ControlDeviceType.QIiFjjgvNmDRWWXPiwXfgdhsPuPT, 
				fwfZKOZIrzVVMmsLWTqxjrPbdnz.HozKeFupbFMAkawChHxgYAvTwqs => ControlDeviceType.HozKeFupbFMAkawChHxgYAvTwqs, 
				fwfZKOZIrzVVMmsLWTqxjrPbdnz.VptHLZXdJfMsrxxJFwCBsNGGFnMF => ControlDeviceType.VptHLZXdJfMsrxxJFwCBsNGGFnMF, 
				fwfZKOZIrzVVMmsLWTqxjrPbdnz.iBsunrzpmNRGjincwoFXBCjHvrY => ControlDeviceType.iBsunrzpmNRGjincwoFXBCjHvrY, 
				_ => ControlDeviceType.CCZTuwVJranWzEkxzHtKCBLLDDz, 
			};
		}

		private void fnbWnKnajTExrfChSQLkKMdqfpwH()
		{
			pAhzhvigFoLFbwPDdcXHatZWRIl = PkYFoJbHDSFVrSOHBVJAgJwpYncH(rtmepNGyphMMGYpeiwSMrmBNGeQC());
			if (pAhzhvigFoLFbwPDdcXHatZWRIl == null)
			{
				Logger.LogError("Default hardware map not found!");
				return;
			}
			if (pAhzhvigFoLFbwPDdcXHatZWRIl.useSystemName && !string.IsNullOrEmpty(cwXKEfmJwgVuncJVtimNSLaSlwa))
			{
				string text = Regex.Replace(cwXKEfmJwgVuncJVtimNSLaSlwa, "\\s+", " ");
				text = text.Trim();
				if (!string.IsNullOrEmpty(text))
				{
					pAhzhvigFoLFbwPDdcXHatZWRIl.controllerName = text;
				}
			}
			KvWYoUeQcKYRiSuZzzFxrcVXiqk = pAhzhvigFoLFbwPDdcXHatZWRIl.axisCount;
			ZsZVmkTkPjWelvFISDijpisYNoj = pAhzhvigFoLFbwPDdcXHatZWRIl.buttonCount;
		}

		private string nianAjxGzXKqoatgnVdWbUJStpK()
		{
			return InputTools.FormatHardwareIdentifierString($"{ReInput.currentPlatform.ToString()}{lLunFdsBZKbwbTGDtevQjFyRGyC.CjXujTlhqNIpInDJJhdZCrePvnB}{nkjULWvORMLZzfOOzNIPKqWvsaF}{HobfqJsoBexlFijbsSVcDQthfKhI}{bxkXdlCJVCfVuquTGeTMqKnvsia.ToProductGuid()}");
		}

		private void OuIWDEMIWYGLVnMRQYdgmCxlPxR(BridgedControllerHWInfo P_0)
		{
			P_0.inputManagerSource = InputSource.SDL2;
			P_0.inputSource = lLunFdsBZKbwbTGDtevQjFyRGyC.CjXujTlhqNIpInDJJhdZCrePvnB;
			P_0.deviceType = mWkEwUWjfWhlPyxPtpmHxkdtijqK(qouleEuZVsuDwHelRwYCaeeIDilH);
			P_0.hardwareIdentifier = nianAjxGzXKqoatgnVdWbUJStpK();
			P_0.hardwareAxisCount = NYvYvrFEEijFdVCAIndoQIHvsaN;
			P_0.hardwareButtonCount = GrUhAFHLKEgABIxWQoBcgoHzLeBJ;
			P_0.hardwareHatCount = pIQcvYYQMqcLgcMdiKuLfdjyBeg;
			P_0.hw_productName = nkjULWvORMLZzfOOzNIPKqWvsaF;
			P_0.hw_deviceGuid = OCGARjuFZDQxfTIIHeiAPOePthL;
			P_0.hw_productId = HobfqJsoBexlFijbsSVcDQthfKhI;
			P_0.hw_pidVid = bxkXdlCJVCfVuquTGeTMqKnvsia;
			P_0.hw_isBluetoothDevice = hIkLfDXQbAOfZYOIZSqoiFglIWB;
			P_0.hw_bluetoothDeviceName = nkjULWvORMLZzfOOzNIPKqWvsaF;
			P_0.hw_systemDeviceName = nkjULWvORMLZzfOOzNIPKqWvsaF;
			P_0.hw_supportsVibration = YxSCQUilOVOVIAbfGmstlMmXgrqk;
			P_0.hw_isSDL2Gamepad = lLunFdsBZKbwbTGDtevQjFyRGyC.CgUGHdRGuyaCZhYhUNAYUSQZnLwz == fwfZKOZIrzVVMmsLWTqxjrPbdnz.HozKeFupbFMAkawChHxgYAvTwqs;
			P_0.hw_localVibrationMotorCount = DgKZIwUKWYpoRBbYIharycQNYrN;
		}

		private void OuIWDEMIWYGLVnMRQYdgmCxlPxR(BridgedController P_0)
		{
			OuIWDEMIWYGLVnMRQYdgmCxlPxR((BridgedControllerHWInfo)P_0);
			P_0.sourceJoystick = this;
			P_0.gameHardwareMap = pAhzhvigFoLFbwPDdcXHatZWRIl.ToGameHardwareControllerMap();
			P_0.instanceName = nkjULWvORMLZzfOOzNIPKqWvsaF;
			P_0.productName = nkjULWvORMLZzfOOzNIPKqWvsaF;
			P_0.axisCount = KvWYoUeQcKYRiSuZzzFxrcVXiqk;
			P_0.buttonCount = ZsZVmkTkPjWelvFISDijpisYNoj;
			P_0.unknownControllerHats = xPgYFpqgDIrbOWLoDDlFJiFnmnjv();
			P_0.controllerTypeGuid = lwdxrsNKwLhtAYwqCDFXheqlLse;
			P_0.controllerExtension = extension;
		}

		private void iwYrenddvHCOLonQmLBtzUcDKiW()
		{
			for (int i = 0; i < ZsZVmkTkPjWelvFISDijpisYNoj; i++)
			{
				PVITKWpmXlCUxbOeOgCPsJPiOjmf[i] = false;
			}
			for (int j = 0; j < KvWYoUeQcKYRiSuZzzFxrcVXiqk; j++)
			{
				fMaBRrMSrsdNukczypLZCirAhksd[j] = 0f;
			}
		}

		private UnknownControllerHat[] xPgYFpqgDIrbOWLoDDlFJiFnmnjv()
		{
			if (!ARlfjKENsrtBRijsETyXRSanBDzS)
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

		public static int gXymsdjFpNECRixTcopJwUOdTHTe(oPxlYzxmpKqCVdyTLGtmtYcnoIL P_0, oPxlYzxmpKqCVdyTLGtmtYcnoIL P_1)
		{
			if (P_0.yCFCZIHUtxubaOkYtznBnuzDsZQ < P_1.yCFCZIHUtxubaOkYtznBnuzDsZQ)
			{
				return -1;
			}
			if (P_0.yCFCZIHUtxubaOkYtznBnuzDsZQ > P_1.yCFCZIHUtxubaOkYtznBnuzDsZQ)
			{
				return 1;
			}
			return 0;
		}

		public static int kaOlILCDhvzafuEdnRCfwyRedXy(oPxlYzxmpKqCVdyTLGtmtYcnoIL P_0, oPxlYzxmpKqCVdyTLGtmtYcnoIL P_1)
		{
			if (P_0.MLuHYSGDrYmZeQZcxiBDPZJHOrw < P_1.MLuHYSGDrYmZeQZcxiBDPZJHOrw)
			{
				return -1;
			}
			if (P_0.MLuHYSGDrYmZeQZcxiBDPZJHOrw > P_1.MLuHYSGDrYmZeQZcxiBDPZJHOrw)
			{
				return 1;
			}
			return 0;
		}
	}

	private class rjlOCULhpPNMHOfgFAkaLULJthV
	{
		public enum ZSZTnqsOyoeWHKfSnbCAPUZgoPZ
		{
			FSpAuHtupjDZXhUqvazjlutzPIHg = 0,
			zolnAcOnXpGZenMMlAIrNiahLST = 1
		}

		public class zLYnBjTVISrFIhGowMvBYpbHyns
		{
			public int gNijVFSxPIkIXVEBfXiCOWbvkEY;

			public Guid kEQkcrKZuzTYwGDFBLjiTrWERMu;

			public Guid gxPXyJYkNvLbaqTgLRuQmqNdpBm;

			public int uDYTVizJuwnXvzyofQhbtGjAJpaE;

			public int NYvYvrFEEijFdVCAIndoQIHvsaN;

			public int GrUhAFHLKEgABIxWQoBcgoHzLeBJ;

			public int pIQcvYYQMqcLgcMdiKuLfdjyBeg;

			public bool sRrGplMHNlzmCBfgKNqGViUdGhN(oPxlYzxmpKqCVdyTLGtmtYcnoIL P_0, ZSZTnqsOyoeWHKfSnbCAPUZgoPZ P_1)
			{
				if (P_0.rewiredId == gNijVFSxPIkIXVEBfXiCOWbvkEY)
				{
					return true;
				}
				if (NYvYvrFEEijFdVCAIndoQIHvsaN != P_0.NYvYvrFEEijFdVCAIndoQIHvsaN)
				{
					return false;
				}
				if (GrUhAFHLKEgABIxWQoBcgoHzLeBJ != P_0.GrUhAFHLKEgABIxWQoBcgoHzLeBJ)
				{
					return false;
				}
				if (pIQcvYYQMqcLgcMdiKuLfdjyBeg != P_0.pIQcvYYQMqcLgcMdiKuLfdjyBeg)
				{
					return false;
				}
				return P_1 switch
				{
					ZSZTnqsOyoeWHKfSnbCAPUZgoPZ.FSpAuHtupjDZXhUqvazjlutzPIHg => kEQkcrKZuzTYwGDFBLjiTrWERMu == P_0.OCGARjuFZDQxfTIIHeiAPOePthL, 
					ZSZTnqsOyoeWHKfSnbCAPUZgoPZ.zolnAcOnXpGZenMMlAIrNiahLST => gxPXyJYkNvLbaqTgLRuQmqNdpBm == P_0.gxPXyJYkNvLbaqTgLRuQmqNdpBm, 
					_ => throw new NotImplementedException(), 
				};
			}
		}

		private List<zLYnBjTVISrFIhGowMvBYpbHyns> BOUZQgfjcmguYdmiFTTQVpzRKHM;

		public rjlOCULhpPNMHOfgFAkaLULJthV()
		{
			BOUZQgfjcmguYdmiFTTQVpzRKHM = new List<zLYnBjTVISrFIhGowMvBYpbHyns>();
		}

		public void ROWDMagIyIfgsVWhoSroKVHpUgvW(oPxlYzxmpKqCVdyTLGtmtYcnoIL P_0)
		{
			if (P_0 == null)
			{
				return;
			}
			int count = BOUZQgfjcmguYdmiFTTQVpzRKHM.Count;
			for (int i = 0; i < count; i++)
			{
				if (BOUZQgfjcmguYdmiFTTQVpzRKHM[i].sRrGplMHNlzmCBfgKNqGViUdGhN(P_0, ZSZTnqsOyoeWHKfSnbCAPUZgoPZ.FSpAuHtupjDZXhUqvazjlutzPIHg))
				{
					BOUZQgfjcmguYdmiFTTQVpzRKHM[i].gNijVFSxPIkIXVEBfXiCOWbvkEY = P_0.rewiredId;
					BOUZQgfjcmguYdmiFTTQVpzRKHM[i].kEQkcrKZuzTYwGDFBLjiTrWERMu = P_0.OCGARjuFZDQxfTIIHeiAPOePthL;
					BOUZQgfjcmguYdmiFTTQVpzRKHM[i].gxPXyJYkNvLbaqTgLRuQmqNdpBm = P_0.gxPXyJYkNvLbaqTgLRuQmqNdpBm;
					BOUZQgfjcmguYdmiFTTQVpzRKHM[i].uDYTVizJuwnXvzyofQhbtGjAJpaE = P_0.inputManagerId;
					BOUZQgfjcmguYdmiFTTQVpzRKHM[i].NYvYvrFEEijFdVCAIndoQIHvsaN = P_0.NYvYvrFEEijFdVCAIndoQIHvsaN;
					BOUZQgfjcmguYdmiFTTQVpzRKHM[i].GrUhAFHLKEgABIxWQoBcgoHzLeBJ = P_0.GrUhAFHLKEgABIxWQoBcgoHzLeBJ;
					BOUZQgfjcmguYdmiFTTQVpzRKHM[i].pIQcvYYQMqcLgcMdiKuLfdjyBeg = P_0.pIQcvYYQMqcLgcMdiKuLfdjyBeg;
					jLGvBZyUjbsddWQKdQjBFPHHJQN(P_0.rewiredId, P_0.OCGARjuFZDQxfTIIHeiAPOePthL, i);
					return;
				}
			}
			BOUZQgfjcmguYdmiFTTQVpzRKHM.Add(new zLYnBjTVISrFIhGowMvBYpbHyns
			{
				gNijVFSxPIkIXVEBfXiCOWbvkEY = P_0.rewiredId,
				kEQkcrKZuzTYwGDFBLjiTrWERMu = P_0.OCGARjuFZDQxfTIIHeiAPOePthL,
				gxPXyJYkNvLbaqTgLRuQmqNdpBm = P_0.gxPXyJYkNvLbaqTgLRuQmqNdpBm,
				uDYTVizJuwnXvzyofQhbtGjAJpaE = P_0.inputManagerId,
				NYvYvrFEEijFdVCAIndoQIHvsaN = P_0.NYvYvrFEEijFdVCAIndoQIHvsaN,
				GrUhAFHLKEgABIxWQoBcgoHzLeBJ = P_0.GrUhAFHLKEgABIxWQoBcgoHzLeBJ,
				pIQcvYYQMqcLgcMdiKuLfdjyBeg = P_0.pIQcvYYQMqcLgcMdiKuLfdjyBeg
			});
			jLGvBZyUjbsddWQKdQjBFPHHJQN(P_0.rewiredId, P_0.OCGARjuFZDQxfTIIHeiAPOePthL, BOUZQgfjcmguYdmiFTTQVpzRKHM.Count - 1);
		}

		public bool oQFygjrDaMtXNUGnYpOhqPuoBesB(oPxlYzxmpKqCVdyTLGtmtYcnoIL P_0, ZSZTnqsOyoeWHKfSnbCAPUZgoPZ P_1)
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

		public IEnumerable<zLYnBjTVISrFIhGowMvBYpbHyns> WfScZfFnYvGYNnfxpPOcIypkwcfV(oPxlYzxmpKqCVdyTLGtmtYcnoIL P_0, ZSZTnqsOyoeWHKfSnbCAPUZgoPZ P_1)
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

		private void jLGvBZyUjbsddWQKdQjBFPHHJQN(int P_0, Guid P_1, int P_2)
		{
			for (int num = BOUZQgfjcmguYdmiFTTQVpzRKHM.Count - 1; num >= 0; num--)
			{
				if (num != P_2 && (BOUZQgfjcmguYdmiFTTQVpzRKHM[num].gNijVFSxPIkIXVEBfXiCOWbvkEY == P_0 || BOUZQgfjcmguYdmiFTTQVpzRKHM[num].kEQkcrKZuzTYwGDFBLjiTrWERMu == P_1))
				{
					BOUZQgfjcmguYdmiFTTQVpzRKHM.RemoveAt(num);
				}
			}
		}
	}

	internal const bool OPuozRtMQdvUoOWIwjDgdTyGIVa = true;

	private IInputSource pCAdqWRoodLcXGGlseBwWkZLpAh;

	private List<oPxlYzxmpKqCVdyTLGtmtYcnoIL> mqdAbRkCKsLDODrmCZPalaGwyaPz;

	private int XIizDAIvfXWSeeEunnkOyCetKzC;

	private rjlOCULhpPNMHOfgFAkaLULJthV tWaggyJPBcRxwyAUFZkujNIcHgO;

	private bool dwsDsPDKgHTKQVAjREDWSXOsYkJ;

	private Action<int, ControllerDataUpdater> kcCBEvsiDFcwqeYRbhjvVDrLnNvd;

	private PlatformInputManager aTqiuENnHjmuSZPlDcgXHhWiQkqb;

	private readonly bool JuswGXvahdcTCFokZmumGbXdbXtf;

	private readonly bool hWmdzzHhbaStzcVAzRSIWLqtMMc;

	private readonly bool GEFBXlEGMVbfwnVyMeceMvDFHXV;

	private readonly Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> PkYFoJbHDSFVrSOHBVJAgJwpYncH;

	private readonly Func<int> KddIpovQxcbGiTnkUHPijPNcARO;

	[CustomObfuscation(rename = false)]
	public override int deviceCount => XIizDAIvfXWSeeEunnkOyCetKzC;

	[CustomObfuscation(rename = false)]
	public override PlatformInputManager primaryInputManager => aTqiuENnHjmuSZPlDcgXHhWiQkqb;

	[CustomObfuscation(rename = false)]
	public override IInputSource inputSource => pCAdqWRoodLcXGGlseBwWkZLpAh;

	[CustomObfuscation(rename = false)]
	public override InputSource inputSourceType => InputSource.SDL2;

	public lfWAkuOTJbfALchOQejzQHLPmoS(ConfigVars configVars, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId, bool handleJoysticks, bool handleUnifiedMouse, bool handleUnifiedKeyboard)
	{
		try
		{
			PkYFoJbHDSFVrSOHBVJAgJwpYncH = getHardwareJoystickMap_InputManager;
			KddIpovQxcbGiTnkUHPijPNcARO = getNewJoystickId;
			JuswGXvahdcTCFokZmumGbXdbXtf = handleJoysticks;
			hWmdzzHhbaStzcVAzRSIWLqtMMc = handleUnifiedMouse;
			GEFBXlEGMVbfwnVyMeceMvDFHXV = handleUnifiedKeyboard;
			aTqiuENnHjmuSZPlDcgXHhWiQkqb = this;
			pCAdqWRoodLcXGGlseBwWkZLpAh = new SDL2InputSource(configVars.updateLoop, handleJoysticks, handleJoysticks, handleUnifiedMouse, handleUnifiedKeyboard);
			kcCBEvsiDFcwqeYRbhjvVDrLnNvd = UpdateControllerData;
			pCAdqWRoodLcXGGlseBwWkZLpAh.DeviceChangedEvent += pfXyTdjlyAcPHijISakyhiWEMvCL;
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
		if (JuswGXvahdcTCFokZmumGbXdbXtf)
		{
			tWaggyJPBcRxwyAUFZkujNIcHgO = new rjlOCULhpPNMHOfgFAkaLULJthV();
			ensYNqjPxhKHeyOUbkLdLoRguEI();
		}
	}

	[CustomObfuscation(rename = false)]
	public override void Update(UpdateLoopType updateLoop)
	{
		if (pCAdqWRoodLcXGGlseBwWkZLpAh != null)
		{
			pCAdqWRoodLcXGGlseBwWkZLpAh.Update();
		}
		if (JuswGXvahdcTCFokZmumGbXdbXtf)
		{
			if (dwsDsPDKgHTKQVAjREDWSXOsYkJ)
			{
				wCDaVFQPEORUeWyoEnGRkTcDqlD();
			}
			if (pCAdqWRoodLcXGGlseBwWkZLpAh != null)
			{
				for (int i = 0; i < XIizDAIvfXWSeeEunnkOyCetKzC; i++)
				{
					mqdAbRkCKsLDODrmCZPalaGwyaPz[i]?.lLunFdsBZKbwbTGDtevQjFyRGyC.mtiNfGzpXHszOwiOIAVYQuMZclV(updateLoop);
				}
				pCAdqWRoodLcXGGlseBwWkZLpAh.UpdateDevices(updateLoop);
			}
			HjPmTvcviOfgWiHOydmvDBtIjMVH();
			if (pCAdqWRoodLcXGGlseBwWkZLpAh != null)
			{
				pCAdqWRoodLcXGGlseBwWkZLpAh.UpdateFinished();
				for (int j = 0; j < XIizDAIvfXWSeeEunnkOyCetKzC; j++)
				{
					mqdAbRkCKsLDODrmCZPalaGwyaPz[j]?.lLunFdsBZKbwbTGDtevQjFyRGyC.OAFlvPdHOjXWTvxfZdnCaGjIult();
				}
			}
		}
		_ = hWmdzzHhbaStzcVAzRSIWLqtMMc;
	}

	[CustomObfuscation(rename = false)]
	public override void OnDestroy()
	{
		if (mqdAbRkCKsLDODrmCZPalaGwyaPz != null)
		{
			int count = mqdAbRkCKsLDODrmCZPalaGwyaPz.Count;
			for (int i = 0; i < count; i++)
			{
				if (mqdAbRkCKsLDODrmCZPalaGwyaPz[i] != null)
				{
					mqdAbRkCKsLDODrmCZPalaGwyaPz[i].lLunFdsBZKbwbTGDtevQjFyRGyC?.hDcEVaXmcZkJBpNHrWGTldoHAbU();
				}
			}
		}
		if (pCAdqWRoodLcXGGlseBwWkZLpAh != null)
		{
			pCAdqWRoodLcXGGlseBwWkZLpAh.Dispose();
		}
	}

	[CustomObfuscation(rename = false)]
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate()
	{
		return kcCBEvsiDFcwqeYRbhjvVDrLnNvd;
	}

	[CustomObfuscation(rename = false)]
	public override void UpdateControllerData(int inputManagerId, ControllerDataUpdater data)
	{
		if (!JuswGXvahdcTCFokZmumGbXdbXtf)
		{
			return;
		}
		for (int i = 0; i < XIizDAIvfXWSeeEunnkOyCetKzC; i++)
		{
			if (mqdAbRkCKsLDODrmCZPalaGwyaPz[i].inputManagerId == inputManagerId)
			{
				mqdAbRkCKsLDODrmCZPalaGwyaPz[i].FillData(data);
				break;
			}
		}
	}

	[CustomObfuscation(rename = false)]
	public override void SystemDeviceConnected()
	{
		if (JuswGXvahdcTCFokZmumGbXdbXtf)
		{
			dwsDsPDKgHTKQVAjREDWSXOsYkJ = true;
		}
		if (_SystemDeviceConnectedEvent != null)
		{
			_SystemDeviceConnectedEvent();
		}
	}

	[CustomObfuscation(rename = false)]
	public override void SystemDeviceDisconnected()
	{
		if (JuswGXvahdcTCFokZmumGbXdbXtf)
		{
			dwsDsPDKgHTKQVAjREDWSXOsYkJ = true;
		}
		if (_SystemDeviceDisconnectedEvent != null)
		{
			_SystemDeviceDisconnectedEvent();
		}
	}

	[CustomObfuscation(rename = false)]
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId)
	{
		_ = JuswGXvahdcTCFokZmumGbXdbXtf;
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

	private void ensYNqjPxhKHeyOUbkLdLoRguEI()
	{
		ensYNqjPxhKHeyOUbkLdLoRguEI(xGaySdaCOScsvCTfpYBoMlfhzSc());
	}

	private void ensYNqjPxhKHeyOUbkLdLoRguEI(IList<HpPUYiSsBwKxKGqHrpbgrhShPgI> P_0)
	{
		int num = 0;
		List<oPxlYzxmpKqCVdyTLGtmtYcnoIL> list = mqdAbRkCKsLDODrmCZPalaGwyaPz;
		int xIizDAIvfXWSeeEunnkOyCetKzC = XIizDAIvfXWSeeEunnkOyCetKzC;
		mqdAbRkCKsLDODrmCZPalaGwyaPz = new List<oPxlYzxmpKqCVdyTLGtmtYcnoIL>();
		int count = P_0.Count;
		for (int i = 0; i < count; i++)
		{
			if (P_0[i] != null)
			{
				HpPUYiSsBwKxKGqHrpbgrhShPgI hpPUYiSsBwKxKGqHrpbgrhShPgI = P_0[i];
				oPxlYzxmpKqCVdyTLGtmtYcnoIL oPxlYzxmpKqCVdyTLGtmtYcnoIL = new oPxlYzxmpKqCVdyTLGtmtYcnoIL(PkYFoJbHDSFVrSOHBVJAgJwpYncH);
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.lLunFdsBZKbwbTGDtevQjFyRGyC = hpPUYiSsBwKxKGqHrpbgrhShPgI;
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.OCGARjuFZDQxfTIIHeiAPOePthL = hpPUYiSsBwKxKGqHrpbgrhShPgI.QuZPQZUGoGeIpyXpLIvdNPjXXkg;
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.nkjULWvORMLZzfOOzNIPKqWvsaF = hpPUYiSsBwKxKGqHrpbgrhShPgI.qfkEsVAZmhLEnqPtJmqDCZcHEfyz;
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.cwXKEfmJwgVuncJVtimNSLaSlwa = hpPUYiSsBwKxKGqHrpbgrhShPgI.rYoCNmQxczjUlbtwoQeqRsEQIcxS;
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.bxkXdlCJVCfVuquTGeTMqKnvsia = hpPUYiSsBwKxKGqHrpbgrhShPgI.XQhtDFrECpkdvcxjleSBRpuIxMv;
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.HobfqJsoBexlFijbsSVcDQthfKhI = hpPUYiSsBwKxKGqHrpbgrhShPgI.bCzEKrFEiOIoedspzWyadrUPaSs;
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.vPXJpqINRqPFfbvxiOgRleAPgZX = hpPUYiSsBwKxKGqHrpbgrhShPgI.dzPdILVvmtCrrrrBDrVoijRmRTX;
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.qouleEuZVsuDwHelRwYCaeeIDilH = hpPUYiSsBwKxKGqHrpbgrhShPgI.CgUGHdRGuyaCZhYhUNAYUSQZnLwz;
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.MLuHYSGDrYmZeQZcxiBDPZJHOrw = hpPUYiSsBwKxKGqHrpbgrhShPgI.JNhAPwAUkIguzvzFCmzXXVGbDjJ;
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.NYvYvrFEEijFdVCAIndoQIHvsaN = hpPUYiSsBwKxKGqHrpbgrhShPgI.UELWeRwRkBeAwKhzhuLbNBQtgAyd;
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.GrUhAFHLKEgABIxWQoBcgoHzLeBJ = hpPUYiSsBwKxKGqHrpbgrhShPgI.ZCgpSfgJTUAyoOeHFrTeCLSnJX;
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.pIQcvYYQMqcLgcMdiKuLfdjyBeg = hpPUYiSsBwKxKGqHrpbgrhShPgI.zPEBnjjGCJHSfslkZIFAaxoHznSx;
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.hIkLfDXQbAOfZYOIZSqoiFglIWB = hpPUYiSsBwKxKGqHrpbgrhShPgI.UexeDQpqsQsdUiTqrdFXuNrPBha;
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.YxSCQUilOVOVIAbfGmstlMmXgrqk = hpPUYiSsBwKxKGqHrpbgrhShPgI.OjIIBzKCDgVkZaEwhkvSnnTSsIT;
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.DgKZIwUKWYpoRBbYIharycQNYrN = hpPUYiSsBwKxKGqHrpbgrhShPgI.kcHUjuXWxrvyVyNiTcldyOcbRZC;
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.extension = hpPUYiSsBwKxKGqHrpbgrhShPgI.OAEJiOXigpFuaBqzpoMmERQiUQJE;
				hpPUYiSsBwKxKGqHrpbgrhShPgI.wBGbJgukpiGiCAwWwpdseSaAvWCe();
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.UcMFLlIeEVgVHdWycYuHxpkWVTYD();
				mqdAbRkCKsLDODrmCZPalaGwyaPz.Add(oPxlYzxmpKqCVdyTLGtmtYcnoIL);
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
	}

	private void HjPmTvcviOfgWiHOydmvDBtIjMVH()
	{
		for (int i = 0; i < XIizDAIvfXWSeeEunnkOyCetKzC; i++)
		{
			mqdAbRkCKsLDODrmCZPalaGwyaPz[i]?.Update();
		}
	}

	private bool qWGfWaZvfNbmHfzxhHTUpHdlherW(vrTHBaPgbynUQfyrVtLqUVlMqkb P_0)
	{
		try
		{
			return P_0.NDecJkbixZRiRdLeBNTUmoiEuvnA();
		}
		catch
		{
			return false;
		}
	}

	private IList<HpPUYiSsBwKxKGqHrpbgrhShPgI> xGaySdaCOScsvCTfpYBoMlfhzSc()
	{
		return pCAdqWRoodLcXGGlseBwWkZLpAh.GetJoysticks<HpPUYiSsBwKxKGqHrpbgrhShPgI>();
	}

	private void uUjXiurHcZMVvSbyRINtfLKgLmy(int P_0, int P_1, List<oPxlYzxmpKqCVdyTLGtmtYcnoIL> P_2, List<oPxlYzxmpKqCVdyTLGtmtYcnoIL> P_3)
	{
		if (P_1 > 0)
		{
			P_3.Sort(oPxlYzxmpKqCVdyTLGtmtYcnoIL.kaOlILCDhvzafuEdnRCfwyRedXy);
		}
		if (P_0 > 0 && P_1 > 0)
		{
			qCjFkjCKBBayHefbiUiJnQdNyEAc(P_1, P_3, P_0, P_2, rjlOCULhpPNMHOfgFAkaLULJthV.ZSZTnqsOyoeWHKfSnbCAPUZgoPZ.FSpAuHtupjDZXhUqvazjlutzPIHg);
			qCjFkjCKBBayHefbiUiJnQdNyEAc(P_1, P_3, P_0, P_2, rjlOCULhpPNMHOfgFAkaLULJthV.ZSZTnqsOyoeWHKfSnbCAPUZgoPZ.zolnAcOnXpGZenMMlAIrNiahLST);
		}
		cxfdSKgGqqAkSHDXxofROylxYBHG(P_1, P_3, rjlOCULhpPNMHOfgFAkaLULJthV.ZSZTnqsOyoeWHKfSnbCAPUZgoPZ.FSpAuHtupjDZXhUqvazjlutzPIHg);
		cxfdSKgGqqAkSHDXxofROylxYBHG(P_1, P_3, rjlOCULhpPNMHOfgFAkaLULJthV.ZSZTnqsOyoeWHKfSnbCAPUZgoPZ.zolnAcOnXpGZenMMlAIrNiahLST);
		for (int i = 0; i < P_1; i++)
		{
			oPxlYzxmpKqCVdyTLGtmtYcnoIL oPxlYzxmpKqCVdyTLGtmtYcnoIL = P_3[i];
			if (oPxlYzxmpKqCVdyTLGtmtYcnoIL != null && oPxlYzxmpKqCVdyTLGtmtYcnoIL.inputManagerId < 0)
			{
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.inputManagerId = NyHyNinRgcrbSYtQTeIqkUCRiko(P_3);
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.rewiredId = KddIpovQxcbGiTnkUHPijPNcARO();
				tWaggyJPBcRxwyAUFZkujNIcHgO.ROWDMagIyIfgsVWhoSroKVHpUgvW(oPxlYzxmpKqCVdyTLGtmtYcnoIL);
			}
		}
		P_3.Sort(oPxlYzxmpKqCVdyTLGtmtYcnoIL.gXymsdjFpNECRixTcopJwUOdTHTe);
	}

	private void FnIfaDIUQWVgbiivtjTLYkhLkpq(List<oPxlYzxmpKqCVdyTLGtmtYcnoIL> P_0, int P_1, int P_2)
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

	private bool NkfgIpcuIAsjZIJbIIBeJvbMbagI(List<oPxlYzxmpKqCVdyTLGtmtYcnoIL> P_0, int P_1)
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

	private int NyHyNinRgcrbSYtQTeIqkUCRiko(List<oPxlYzxmpKqCVdyTLGtmtYcnoIL> P_0)
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

	private bool BaEnDOhUnzNYdsILLLieXmcUjHl(List<oPxlYzxmpKqCVdyTLGtmtYcnoIL> P_0, int P_1)
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

	private void qCjFkjCKBBayHefbiUiJnQdNyEAc(int P_0, List<oPxlYzxmpKqCVdyTLGtmtYcnoIL> P_1, int P_2, List<oPxlYzxmpKqCVdyTLGtmtYcnoIL> P_3, rjlOCULhpPNMHOfgFAkaLULJthV.ZSZTnqsOyoeWHKfSnbCAPUZgoPZ P_4)
	{
		int num = ((P_4 != 0) ? 1 : 2);
		for (int i = 0; i < P_0; i++)
		{
			oPxlYzxmpKqCVdyTLGtmtYcnoIL oPxlYzxmpKqCVdyTLGtmtYcnoIL = P_1[i];
			if (oPxlYzxmpKqCVdyTLGtmtYcnoIL == null || oPxlYzxmpKqCVdyTLGtmtYcnoIL.inputManagerId >= 0)
			{
				continue;
			}
			for (int j = 0; j < P_2; j++)
			{
				oPxlYzxmpKqCVdyTLGtmtYcnoIL oPxlYzxmpKqCVdyTLGtmtYcnoIL2 = P_3[j];
				if (oPxlYzxmpKqCVdyTLGtmtYcnoIL2 != null && !BaEnDOhUnzNYdsILLLieXmcUjHl(P_1, oPxlYzxmpKqCVdyTLGtmtYcnoIL2.rewiredId) && oPxlYzxmpKqCVdyTLGtmtYcnoIL.sRrGplMHNlzmCBfgKNqGViUdGhN(oPxlYzxmpKqCVdyTLGtmtYcnoIL2) >= num)
				{
					oPxlYzxmpKqCVdyTLGtmtYcnoIL.QwulHzCeLMcALfriecpsBcgtEiTX(oPxlYzxmpKqCVdyTLGtmtYcnoIL2);
					tWaggyJPBcRxwyAUFZkujNIcHgO.ROWDMagIyIfgsVWhoSroKVHpUgvW(oPxlYzxmpKqCVdyTLGtmtYcnoIL);
				}
			}
		}
	}

	private void cxfdSKgGqqAkSHDXxofROylxYBHG(int P_0, List<oPxlYzxmpKqCVdyTLGtmtYcnoIL> P_1, rjlOCULhpPNMHOfgFAkaLULJthV.ZSZTnqsOyoeWHKfSnbCAPUZgoPZ P_2)
	{
		for (int i = 0; i < P_0; i++)
		{
			oPxlYzxmpKqCVdyTLGtmtYcnoIL oPxlYzxmpKqCVdyTLGtmtYcnoIL = P_1[i];
			if (oPxlYzxmpKqCVdyTLGtmtYcnoIL == null || oPxlYzxmpKqCVdyTLGtmtYcnoIL.inputManagerId >= 0)
			{
				continue;
			}
			rjlOCULhpPNMHOfgFAkaLULJthV.zLYnBjTVISrFIhGowMvBYpbHyns zLYnBjTVISrFIhGowMvBYpbHyns = null;
			foreach (rjlOCULhpPNMHOfgFAkaLULJthV.zLYnBjTVISrFIhGowMvBYpbHyns item in tWaggyJPBcRxwyAUFZkujNIcHgO.WfScZfFnYvGYNnfxpPOcIypkwcfV(oPxlYzxmpKqCVdyTLGtmtYcnoIL, P_2))
			{
				if (!BaEnDOhUnzNYdsILLLieXmcUjHl(P_1, item.gNijVFSxPIkIXVEBfXiCOWbvkEY) && item.uDYTVizJuwnXvzyofQhbtGjAJpaE >= 0)
				{
					zLYnBjTVISrFIhGowMvBYpbHyns = item;
					break;
				}
			}
			if (zLYnBjTVISrFIhGowMvBYpbHyns != null)
			{
				int num = zLYnBjTVISrFIhGowMvBYpbHyns.uDYTVizJuwnXvzyofQhbtGjAJpaE;
				if (!NkfgIpcuIAsjZIJbIIBeJvbMbagI(P_1, num))
				{
					num = (zLYnBjTVISrFIhGowMvBYpbHyns.uDYTVizJuwnXvzyofQhbtGjAJpaE = NyHyNinRgcrbSYtQTeIqkUCRiko(P_1));
				}
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.inputManagerId = num;
				oPxlYzxmpKqCVdyTLGtmtYcnoIL.rewiredId = zLYnBjTVISrFIhGowMvBYpbHyns.gNijVFSxPIkIXVEBfXiCOWbvkEY;
				tWaggyJPBcRxwyAUFZkujNIcHgO.ROWDMagIyIfgsVWhoSroKVHpUgvW(oPxlYzxmpKqCVdyTLGtmtYcnoIL);
			}
		}
	}

	private void wCDaVFQPEORUeWyoEnGRkTcDqlD()
	{
		IList<HpPUYiSsBwKxKGqHrpbgrhShPgI> list = xGaySdaCOScsvCTfpYBoMlfhzSc();
		ensYNqjPxhKHeyOUbkLdLoRguEI(list);
		dwsDsPDKgHTKQVAjREDWSXOsYkJ = false;
	}

	private bool RFvNRIRPwwcpvBALOSCUnYLABFH(IList<HpPUYiSsBwKxKGqHrpbgrhShPgI> P_0)
	{
		int count = P_0.Count;
		for (int i = 0; i < count; i++)
		{
			if (P_0[i] != null && !CsMcuVrUnYVQLBYUPJeKviUnZBq(P_0[i].QuZPQZUGoGeIpyXpLIvdNPjXXkg))
			{
				return true;
			}
		}
		int count2 = mqdAbRkCKsLDODrmCZPalaGwyaPz.Count;
		for (int j = 0; j < count2; j++)
		{
			if (mqdAbRkCKsLDODrmCZPalaGwyaPz[j] != null && !zAESJidZPiTJdbLdioKivtqBFZZ(P_0, mqdAbRkCKsLDODrmCZPalaGwyaPz[j].OCGARjuFZDQxfTIIHeiAPOePthL))
			{
				return true;
			}
		}
		return false;
	}

	private bool CsMcuVrUnYVQLBYUPJeKviUnZBq(Guid P_0)
	{
		int count = mqdAbRkCKsLDODrmCZPalaGwyaPz.Count;
		for (int i = 0; i < count; i++)
		{
			if (mqdAbRkCKsLDODrmCZPalaGwyaPz[i] != null && mqdAbRkCKsLDODrmCZPalaGwyaPz[i].OCGARjuFZDQxfTIIHeiAPOePthL == P_0)
			{
				return true;
			}
		}
		return false;
	}

	private bool zAESJidZPiTJdbLdioKivtqBFZZ(IList<HpPUYiSsBwKxKGqHrpbgrhShPgI> P_0, Guid P_1)
	{
		int count = P_0.Count;
		for (int i = 0; i < count; i++)
		{
			if (P_0[i] != null && P_0[i].QuZPQZUGoGeIpyXpLIvdNPjXXkg == P_1)
			{
				return true;
			}
		}
		return false;
	}

	private void lKgzcfQSolDGPyoEdiWHqTPwByFB(List<oPxlYzxmpKqCVdyTLGtmtYcnoIL> P_0, List<oPxlYzxmpKqCVdyTLGtmtYcnoIL> P_1, bool P_2)
	{
		if (P_0 == null)
		{
			return;
		}
		int num = P_0?.Count ?? 0;
		int num2 = P_1?.Count ?? 0;
		for (int i = 0; i < num; i++)
		{
			oPxlYzxmpKqCVdyTLGtmtYcnoIL oPxlYzxmpKqCVdyTLGtmtYcnoIL = P_0[i];
			if (oPxlYzxmpKqCVdyTLGtmtYcnoIL == null)
			{
				continue;
			}
			bool flag = false;
			if (P_1 != null)
			{
				for (int j = 0; j < num2; j++)
				{
					oPxlYzxmpKqCVdyTLGtmtYcnoIL oPxlYzxmpKqCVdyTLGtmtYcnoIL2 = P_1[j];
					if (oPxlYzxmpKqCVdyTLGtmtYcnoIL2 != null && oPxlYzxmpKqCVdyTLGtmtYcnoIL.OCGARjuFZDQxfTIIHeiAPOePthL == oPxlYzxmpKqCVdyTLGtmtYcnoIL2.OCGARjuFZDQxfTIIHeiAPOePthL)
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

	private void RLICzZUPMdNWULVjCmtEQTTFtRN(oPxlYzxmpKqCVdyTLGtmtYcnoIL P_0, bool P_1)
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

	private void pfXyTdjlyAcPHijISakyhiWEMvCL()
	{
		if (JuswGXvahdcTCFokZmumGbXdbXtf)
		{
			dwsDsPDKgHTKQVAjREDWSXOsYkJ = true;
		}
		SystemDeviceConnected();
	}
}
