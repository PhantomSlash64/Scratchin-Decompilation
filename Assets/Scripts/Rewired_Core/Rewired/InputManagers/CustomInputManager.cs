using System;
using System.Collections.Generic;
using Rewired.Config;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Platforms.Custom;
using Rewired.Utils;

namespace Rewired.InputManagers
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class CustomInputManager : PlatformInputManager
	{
		private class VejAWXSRMctRclJIqGlrFcoadSul : IInputManagerJoystickPublic, IInputManagerJoystick
		{
			private readonly InputSource qhnYJqFPpPHTJjpxtkZKYxgPeLP;

			private readonly CustomInputSource jNeXbbXHzpFbwCRcRezbqitHBfb;

			private readonly Controller.Extension hmZLUQBpfeonCDoNcFmKCFWkaEcl;

			private int xUifcgfakaZXegCEIyIvyNVPONw;

			private int yCFCZIHUtxubaOkYtznBnuzDsZQ;

			private long? zjGrlRpLFjJQPLJfBgshkcIHtSr;

			private int cHGGtPQmQEdFSaIvpIgqFYTwIUM;

			public Guid lwdxrsNKwLhtAYwqCDFXheqlLse;

			public string nDHKPuQQwJPaggZzQvBqiNLObgA;

			public string PVUAjfJBpoLoKMWVQZjXcaFJzqy;

			private int beRmxTPYgeEljczGnIuTQeGMXoR;

			private int aumNItRblDdXZicbRkrPApteCjR;

			private float[] fMaBRrMSrsdNukczypLZCirAhksd;

			private bool[] PVITKWpmXlCUxbOeOgCPsJPiOjmf;

			private HardwareJoystickMap_InputManager pAhzhvigFoLFbwPDdcXHatZWRIl;

			public CustomInputSource.Joystick IdsxFSPnJmcueyZDdCGRKoNaEYNC;

			private bool xwlciijKucqyJFICAlBeQdiMzfmY;

			private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> PkYFoJbHDSFVrSOHBVJAgJwpYncH;

			public int GrUhAFHLKEgABIxWQoBcgoHzLeBJ
			{
				get
				{
					if (IdsxFSPnJmcueyZDdCGRKoNaEYNC == null)
					{
						return 0;
					}
					return IdsxFSPnJmcueyZDdCGRKoNaEYNC.buttonCount;
				}
			}

			public int NYvYvrFEEijFdVCAIndoQIHvsaN
			{
				get
				{
					if (IdsxFSPnJmcueyZDdCGRKoNaEYNC == null)
					{
						return 0;
					}
					return IdsxFSPnJmcueyZDdCGRKoNaEYNC.axisCount;
				}
			}

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
					string text = ((!string.IsNullOrEmpty(IdsxFSPnJmcueyZDdCGRKoNaEYNC.customName)) ? IdsxFSPnJmcueyZDdCGRKoNaEYNC.customName : nDHKPuQQwJPaggZzQvBqiNLObgA);
					if (text == "Unknown Controller")
					{
						text = PVUAjfJBpoLoKMWVQZjXcaFJzqy;
					}
					return text;
				}
			}

			[CustomObfuscation(rename = false)]
			public long? systemId => zjGrlRpLFjJQPLJfBgshkcIHtSr;

			[CustomObfuscation(rename = false)]
			public int unityId => cHGGtPQmQEdFSaIvpIgqFYTwIUM;

			[CustomObfuscation(rename = false)]
			public Guid instanceGuid
			{
				get
				{
					if (!zjGrlRpLFjJQPLJfBgshkcIHtSr.HasValue)
					{
						return Guid.Empty;
					}
					return MiscTools.CreateGuidHashSHA1(name + "_" + zjGrlRpLFjJQPLJfBgshkcIHtSr);
				}
			}

			[CustomObfuscation(rename = false)]
			public Guid persistentGuid => instanceGuid;

			[CustomObfuscation(rename = false)]
			public Controller.Extension extension => hmZLUQBpfeonCDoNcFmKCFWkaEcl;

			[CustomObfuscation(rename = false)]
			public void SetVibration(float amount, int motorIndex)
			{
			}

			[CustomObfuscation(rename = false)]
			public void StopVibration()
			{
			}

			public VejAWXSRMctRclJIqGlrFcoadSul(CustomInputSource customInputSource, long? systemJoystickId, int unityJoystickId, CustomInputSource.Joystick joystick, InputSource inputSource, Controller.Extension controllerExtension, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager)
			{
				jNeXbbXHzpFbwCRcRezbqitHBfb = customInputSource;
				qhnYJqFPpPHTJjpxtkZKYxgPeLP = inputSource;
				zjGrlRpLFjJQPLJfBgshkcIHtSr = systemJoystickId;
				IdsxFSPnJmcueyZDdCGRKoNaEYNC = joystick;
				cHGGtPQmQEdFSaIvpIgqFYTwIUM = unityJoystickId;
				hmZLUQBpfeonCDoNcFmKCFWkaEcl = controllerExtension;
				PkYFoJbHDSFVrSOHBVJAgJwpYncH = getHardwareJoystickMap_InputManager;
				yCFCZIHUtxubaOkYtznBnuzDsZQ = -1;
				xUifcgfakaZXegCEIyIvyNVPONw = -1;
				bkgEYhHIcUmSMKTTycbOUwNiaJIk();
				fnbWnKnajTExrfChSQLkKMdqfpwH();
				lwdxrsNKwLhtAYwqCDFXheqlLse = pAhzhvigFoLFbwPDdcXHatZWRIl.hardwareMapIdentifier.guid;
				nDHKPuQQwJPaggZzQvBqiNLObgA = pAhzhvigFoLFbwPDdcXHatZWRIl.controllerName;
				fMaBRrMSrsdNukczypLZCirAhksd = new float[beRmxTPYgeEljczGnIuTQeGMXoR];
				PVITKWpmXlCUxbOeOgCPsJPiOjmf = new bool[aumNItRblDdXZicbRkrPApteCjR];
				Update();
			}

			public void bkgEYhHIcUmSMKTTycbOUwNiaJIk()
			{
				PVUAjfJBpoLoKMWVQZjXcaFJzqy = IdsxFSPnJmcueyZDdCGRKoNaEYNC.deviceName;
			}

			[CustomObfuscation(rename = false)]
			public void Update()
			{
				if (IdsxFSPnJmcueyZDdCGRKoNaEYNC.isConnected)
				{
					mrcgZsySeBJGLJfZMFgQRpWqKcPu();
					ZoEfBvZLEHeQeEqRqOmhOcalkaSu();
				}
			}

			public int sRrGplMHNlzmCBfgKNqGViUdGhN(VejAWXSRMctRclJIqGlrFcoadSul P_0)
			{
				if (P_0.PVUAjfJBpoLoKMWVQZjXcaFJzqy == PVUAjfJBpoLoKMWVQZjXcaFJzqy && P_0.zjGrlRpLFjJQPLJfBgshkcIHtSr == zjGrlRpLFjJQPLJfBgshkcIHtSr)
				{
					return 2;
				}
				if (P_0.PVUAjfJBpoLoKMWVQZjXcaFJzqy == PVUAjfJBpoLoKMWVQZjXcaFJzqy)
				{
					return 1;
				}
				return 0;
			}

			private void OuIWDEMIWYGLVnMRQYdgmCxlPxR(BridgedControllerHWInfo P_0)
			{
				P_0.inputManagerSource = qhnYJqFPpPHTJjpxtkZKYxgPeLP;
				P_0.inputSource = qhnYJqFPpPHTJjpxtkZKYxgPeLP;
				P_0.hardwareIdentifier = bLgThVKCoYJbgKRAATyCovcPExh();
				P_0.hardwareAxisCount = beRmxTPYgeEljczGnIuTQeGMXoR;
				P_0.hardwareButtonCount = aumNItRblDdXZicbRkrPApteCjR;
				P_0.hardwareHatCount = 0;
				P_0.hw_productName = PVUAjfJBpoLoKMWVQZjXcaFJzqy;
				P_0.hw_supportsVibration = IdsxFSPnJmcueyZDdCGRKoNaEYNC.supportsVibration;
			}

			private void OuIWDEMIWYGLVnMRQYdgmCxlPxR(BridgedController P_0)
			{
				OuIWDEMIWYGLVnMRQYdgmCxlPxR((BridgedControllerHWInfo)P_0);
				P_0.sourceJoystick = this;
				P_0.gameHardwareMap = pAhzhvigFoLFbwPDdcXHatZWRIl.ToGameHardwareControllerMap();
				P_0.instanceName = PVUAjfJBpoLoKMWVQZjXcaFJzqy;
				P_0.productName = PVUAjfJBpoLoKMWVQZjXcaFJzqy;
				P_0.isXInputDevice = false;
				P_0.axisCount = beRmxTPYgeEljczGnIuTQeGMXoR;
				P_0.buttonCount = aumNItRblDdXZicbRkrPApteCjR;
				P_0.controllerTypeGuid = lwdxrsNKwLhtAYwqCDFXheqlLse;
				P_0.customInputSource = jNeXbbXHzpFbwCRcRezbqitHBfb;
				P_0.controllerExtension = hmZLUQBpfeonCDoNcFmKCFWkaEcl;
			}

			[CustomObfuscation(rename = false)]
			public void FillData(ControllerDataUpdater dataUpdater)
			{
				if (beRmxTPYgeEljczGnIuTQeGMXoR != dataUpdater.axisCount || aumNItRblDdXZicbRkrPApteCjR != dataUpdater.buttonCount)
				{
					throw new Exception("This controller signature does not match the data object!");
				}
				for (int i = 0; i < beRmxTPYgeEljczGnIuTQeGMXoR; i++)
				{
					dataUpdater.axisValues[i] = fMaBRrMSrsdNukczypLZCirAhksd[i];
				}
				for (int j = 0; j < aumNItRblDdXZicbRkrPApteCjR; j++)
				{
					dataUpdater.buttonValues[j] = PVITKWpmXlCUxbOeOgCPsJPiOjmf[j];
				}
				if (xwlciijKucqyJFICAlBeQdiMzfmY && !dataUpdater.hasReceivedInput)
				{
					dataUpdater.hasReceivedInput = true;
				}
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

			private void mrcgZsySeBJGLJfZMFgQRpWqKcPu()
			{
				HardwareJoystickMap.Platform_Custom.Axis[] axes = ((HardwareJoystickMap.Platform_Custom)pAhzhvigFoLFbwPDdcXHatZWRIl.map).Axes;
				if (axes == null)
				{
					return;
				}
				for (int i = 0; i < axes.Length; i++)
				{
					if (axes[i] != null)
					{
						if (i >= beRmxTPYgeEljczGnIuTQeGMXoR)
						{
							throw new Exception("Number of axes in hardware map does not match number of axes found in controller!");
						}
						fMaBRrMSrsdNukczypLZCirAhksd[i] = gSbFUoUKksdvWoYrVCrMmdUmQbI(axes[i]);
						if (!xwlciijKucqyJFICAlBeQdiMzfmY && fMaBRrMSrsdNukczypLZCirAhksd[i] != 0f)
						{
							xwlciijKucqyJFICAlBeQdiMzfmY = true;
						}
					}
				}
			}

			private void ZoEfBvZLEHeQeEqRqOmhOcalkaSu()
			{
				HardwareJoystickMap.Platform_Custom.Button[] buttons = ((HardwareJoystickMap.Platform_Custom)pAhzhvigFoLFbwPDdcXHatZWRIl.map).Buttons;
				if (buttons == null)
				{
					return;
				}
				for (int i = 0; i < buttons.Length; i++)
				{
					if (i >= aumNItRblDdXZicbRkrPApteCjR)
					{
						throw new Exception("Number of buttons in hardware map does not match number of buttons found in controller!");
					}
					PVITKWpmXlCUxbOeOgCPsJPiOjmf[i] = MBcFiZeZyRdrKwPqvdeFcRGWuORk(buttons[i]);
					if (!xwlciijKucqyJFICAlBeQdiMzfmY && PVITKWpmXlCUxbOeOgCPsJPiOjmf[i])
					{
						xwlciijKucqyJFICAlBeQdiMzfmY = true;
					}
				}
			}

			private bool MBcFiZeZyRdrKwPqvdeFcRGWuORk(HardwareJoystickMap.Platform_Custom.Button P_0)
			{
				if (P_0.sourceType == 0)
				{
					return MBcFiZeZyRdrKwPqvdeFcRGWuORk(P_0.sourceButton);
				}
				if (P_0.sourceType == 1)
				{
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
				return false;
			}

			private bool zgofQtbkAmxfsjEmowfnIuOzhfme(float P_0, float P_1)
			{
				return MathTools.IsNear(P_1, P_0, 0.1f);
			}

			private float gSbFUoUKksdvWoYrVCrMmdUmQbI(HardwareJoystickMap.Platform_Custom.Axis P_0)
			{
				if (P_0.sourceType == 1)
				{
					return gSbFUoUKksdvWoYrVCrMmdUmQbI(P_0.sourceAxis);
				}
				if (P_0.sourceType == 0)
				{
					if (!MBcFiZeZyRdrKwPqvdeFcRGWuORk(P_0.sourceButton))
					{
						return 0f;
					}
					if (P_0.buttonAxisContribution == Pole.Positive)
					{
						return 1f;
					}
					return -1f;
				}
				throw new NotImplementedException();
			}

			private float gSbFUoUKksdvWoYrVCrMmdUmQbI(int P_0)
			{
				return IdsxFSPnJmcueyZDdCGRKoNaEYNC.GetAxisValue(P_0);
			}

			private bool MBcFiZeZyRdrKwPqvdeFcRGWuORk(int P_0)
			{
				return IdsxFSPnJmcueyZDdCGRKoNaEYNC.GetButtonValue(P_0);
			}

			private void fnbWnKnajTExrfChSQLkKMdqfpwH()
			{
				pAhzhvigFoLFbwPDdcXHatZWRIl = PkYFoJbHDSFVrSOHBVJAgJwpYncH(rtmepNGyphMMGYpeiwSMrmBNGeQC());
				if (pAhzhvigFoLFbwPDdcXHatZWRIl == null)
				{
					Logger.LogError("Default hardware map not found!");
					return;
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
					return InputTools.FormatHardwareIdentifierString($"{ReInput.currentPlatform.ToString()}{ReInput.webplayerPlatform.ToString()}{qhnYJqFPpPHTJjpxtkZKYxgPeLP.ToString()}{PVUAjfJBpoLoKMWVQZjXcaFJzqy}");
				}
				return InputTools.FormatHardwareIdentifierString($"{ReInput.currentPlatform.ToString()}{qhnYJqFPpPHTJjpxtkZKYxgPeLP.ToString()}{PVUAjfJBpoLoKMWVQZjXcaFJzqy}");
			}

			public static int QWRAqqDVdRarhOjzSpdusXmYAGUC(VejAWXSRMctRclJIqGlrFcoadSul P_0, VejAWXSRMctRclJIqGlrFcoadSul P_1)
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

			public static int frBYFaDROjIWmQIiGDxniOluCiaH(VejAWXSRMctRclJIqGlrFcoadSul P_0, VejAWXSRMctRclJIqGlrFcoadSul P_1)
			{
				if (P_0.zjGrlRpLFjJQPLJfBgshkcIHtSr < P_1.zjGrlRpLFjJQPLJfBgshkcIHtSr)
				{
					return -1;
				}
				if (P_0.zjGrlRpLFjJQPLJfBgshkcIHtSr > P_1.zjGrlRpLFjJQPLJfBgshkcIHtSr)
				{
					return 1;
				}
				return 0;
			}
		}

		private class fqqCpbSMrueuJOOzTFUbiGnTdSq
		{
			public enum oCnKZoKtxJwBouHcmCTMIHwNYP
			{
				FSpAuHtupjDZXhUqvazjlutzPIHg = 0,
				zolnAcOnXpGZenMMlAIrNiahLST = 1
			}

			public class zBIwceIOCNlsQfzhTfrJTUjseRB
			{
				public int gNijVFSxPIkIXVEBfXiCOWbvkEY;

				public long? UicuxxJsbKFHYowetKwMpKcrfHk;

				public string ueeEIliAfDJvbLjXlOyWMalYqyKe;

				public int uDYTVizJuwnXvzyofQhbtGjAJpaE;

				public int aumNItRblDdXZicbRkrPApteCjR;

				public int beRmxTPYgeEljczGnIuTQeGMXoR;

				public zBIwceIOCNlsQfzhTfrJTUjseRB(int rewiredId, long? systemId, string systemControllerName, int lastInputManagerId, int buttonCount, int axisCount)
				{
					gNijVFSxPIkIXVEBfXiCOWbvkEY = rewiredId;
					UicuxxJsbKFHYowetKwMpKcrfHk = systemId;
					ueeEIliAfDJvbLjXlOyWMalYqyKe = systemControllerName;
					uDYTVizJuwnXvzyofQhbtGjAJpaE = lastInputManagerId;
					aumNItRblDdXZicbRkrPApteCjR = buttonCount;
					beRmxTPYgeEljczGnIuTQeGMXoR = axisCount;
				}

				public bool sRrGplMHNlzmCBfgKNqGViUdGhN(VejAWXSRMctRclJIqGlrFcoadSul P_0, oCnKZoKtxJwBouHcmCTMIHwNYP P_1)
				{
					if (P_0.rewiredId == gNijVFSxPIkIXVEBfXiCOWbvkEY)
					{
						return true;
					}
					if (P_0.GrUhAFHLKEgABIxWQoBcgoHzLeBJ != aumNItRblDdXZicbRkrPApteCjR)
					{
						return false;
					}
					if (P_0.NYvYvrFEEijFdVCAIndoQIHvsaN != beRmxTPYgeEljczGnIuTQeGMXoR)
					{
						return false;
					}
					switch (P_1)
					{
					case oCnKZoKtxJwBouHcmCTMIHwNYP.FSpAuHtupjDZXhUqvazjlutzPIHg:
						if (UicuxxJsbKFHYowetKwMpKcrfHk == P_0.systemId)
						{
							return ueeEIliAfDJvbLjXlOyWMalYqyKe == P_0.PVUAjfJBpoLoKMWVQZjXcaFJzqy;
						}
						return false;
					case oCnKZoKtxJwBouHcmCTMIHwNYP.zolnAcOnXpGZenMMlAIrNiahLST:
						return ueeEIliAfDJvbLjXlOyWMalYqyKe == P_0.PVUAjfJBpoLoKMWVQZjXcaFJzqy;
					default:
						throw new NotImplementedException();
					}
				}
			}

			private List<zBIwceIOCNlsQfzhTfrJTUjseRB> BOUZQgfjcmguYdmiFTTQVpzRKHM;

			public int ioXgUGjpFGeVuGnqwbPHBeKgnSzF => BOUZQgfjcmguYdmiFTTQVpzRKHM.Count;

			public fqqCpbSMrueuJOOzTFUbiGnTdSq()
			{
				BOUZQgfjcmguYdmiFTTQVpzRKHM = new List<zBIwceIOCNlsQfzhTfrJTUjseRB>();
			}

			public void ROWDMagIyIfgsVWhoSroKVHpUgvW(VejAWXSRMctRclJIqGlrFcoadSul P_0)
			{
				if (P_0 == null)
				{
					return;
				}
				int count = BOUZQgfjcmguYdmiFTTQVpzRKHM.Count;
				for (int i = 0; i < count; i++)
				{
					if (BOUZQgfjcmguYdmiFTTQVpzRKHM[i].sRrGplMHNlzmCBfgKNqGViUdGhN(P_0, oCnKZoKtxJwBouHcmCTMIHwNYP.FSpAuHtupjDZXhUqvazjlutzPIHg))
					{
						BOUZQgfjcmguYdmiFTTQVpzRKHM[i].gNijVFSxPIkIXVEBfXiCOWbvkEY = P_0.rewiredId;
						BOUZQgfjcmguYdmiFTTQVpzRKHM[i].UicuxxJsbKFHYowetKwMpKcrfHk = P_0.systemId;
						BOUZQgfjcmguYdmiFTTQVpzRKHM[i].ueeEIliAfDJvbLjXlOyWMalYqyKe = P_0.PVUAjfJBpoLoKMWVQZjXcaFJzqy;
						BOUZQgfjcmguYdmiFTTQVpzRKHM[i].uDYTVizJuwnXvzyofQhbtGjAJpaE = P_0.inputManagerId;
						BOUZQgfjcmguYdmiFTTQVpzRKHM[i].aumNItRblDdXZicbRkrPApteCjR = P_0.GrUhAFHLKEgABIxWQoBcgoHzLeBJ;
						BOUZQgfjcmguYdmiFTTQVpzRKHM[i].beRmxTPYgeEljczGnIuTQeGMXoR = P_0.NYvYvrFEEijFdVCAIndoQIHvsaN;
						jLGvBZyUjbsddWQKdQjBFPHHJQN(P_0.rewiredId, i);
						return;
					}
				}
				BOUZQgfjcmguYdmiFTTQVpzRKHM.Add(new zBIwceIOCNlsQfzhTfrJTUjseRB(P_0.rewiredId, P_0.systemId, P_0.PVUAjfJBpoLoKMWVQZjXcaFJzqy, P_0.inputManagerId, P_0.GrUhAFHLKEgABIxWQoBcgoHzLeBJ, P_0.NYvYvrFEEijFdVCAIndoQIHvsaN));
				jLGvBZyUjbsddWQKdQjBFPHHJQN(P_0.rewiredId, BOUZQgfjcmguYdmiFTTQVpzRKHM.Count - 1);
			}

			public bool oQFygjrDaMtXNUGnYpOhqPuoBesB(VejAWXSRMctRclJIqGlrFcoadSul P_0, oCnKZoKtxJwBouHcmCTMIHwNYP P_1)
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

			public IEnumerable<zBIwceIOCNlsQfzhTfrJTUjseRB> WfScZfFnYvGYNnfxpPOcIypkwcfV(VejAWXSRMctRclJIqGlrFcoadSul P_0, oCnKZoKtxJwBouHcmCTMIHwNYP P_1)
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

			public int eaOrStrSOuOlEEMmganiuTHlvbL(zBIwceIOCNlsQfzhTfrJTUjseRB P_0)
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

		private List<VejAWXSRMctRclJIqGlrFcoadSul> mqdAbRkCKsLDODrmCZPalaGwyaPz;

		private int XIizDAIvfXWSeeEunnkOyCetKzC;

		private fqqCpbSMrueuJOOzTFUbiGnTdSq tWaggyJPBcRxwyAUFZkujNIcHgO;

		private UpdateLoopType TnidRhAIPvMICseBcUJBQDrSFxL;

		private Action<int, ControllerDataUpdater> kcCBEvsiDFcwqeYRbhjvVDrLnNvd;

		private PlatformInputManager aTqiuENnHjmuSZPlDcgXHhWiQkqb;

		private CustomInputSource jNeXbbXHzpFbwCRcRezbqitHBfb;

		private bool dwsDsPDKgHTKQVAjREDWSXOsYkJ;

		private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> PkYFoJbHDSFVrSOHBVJAgJwpYncH;

		private Func<int> KddIpovQxcbGiTnkUHPijPNcARO;

		[CustomObfuscation(rename = false)]
		public override int deviceCount => XIizDAIvfXWSeeEunnkOyCetKzC;

		[CustomObfuscation(rename = false)]
		public override PlatformInputManager primaryInputManager => aTqiuENnHjmuSZPlDcgXHhWiQkqb;

		[CustomObfuscation(rename = false)]
		public override IInputSource inputSource => null;

		[CustomObfuscation(rename = false)]
		public override InputSource inputSourceType => jNeXbbXHzpFbwCRcRezbqitHBfb.inputSource;

		public CustomInputManager(CustomInputSource customInputSource, UpdateLoopSetting updateLoopSetting, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId)
		{
			jNeXbbXHzpFbwCRcRezbqitHBfb = customInputSource;
			PkYFoJbHDSFVrSOHBVJAgJwpYncH = getHardwareJoystickMap_InputManager;
			KddIpovQxcbGiTnkUHPijPNcARO = getNewJoystickId;
			aTqiuENnHjmuSZPlDcgXHhWiQkqb = this;
			try
			{
				kcCBEvsiDFcwqeYRbhjvVDrLnNvd = UpdateControllerData;
				customInputSource.JoystickConnectedEvent += SystemDeviceConnected;
				customInputSource.JoystickDisconnectedEvent += SystemDeviceDisconnected;
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
			tWaggyJPBcRxwyAUFZkujNIcHgO = new fqqCpbSMrueuJOOzTFUbiGnTdSq();
			mqdAbRkCKsLDODrmCZPalaGwyaPz = new List<VejAWXSRMctRclJIqGlrFcoadSul>();
			dwsDsPDKgHTKQVAjREDWSXOsYkJ = true;
		}

		[CustomObfuscation(rename = false)]
		public override void Update(UpdateLoopType updateLoop)
		{
			TnidRhAIPvMICseBcUJBQDrSFxL = updateLoop;
			if (jNeXbbXHzpFbwCRcRezbqitHBfb.isReady)
			{
				jNeXbbXHzpFbwCRcRezbqitHBfb.Update();
				if (dwsDsPDKgHTKQVAjREDWSXOsYkJ)
				{
					wCDaVFQPEORUeWyoEnGRkTcDqlD();
				}
				HjPmTvcviOfgWiHOydmvDBtIjMVH();
			}
		}

		[CustomObfuscation(rename = false)]
		public override void OnDestroy()
		{
			if (jNeXbbXHzpFbwCRcRezbqitHBfb != null)
			{
				jNeXbbXHzpFbwCRcRezbqitHBfb.Dispose();
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
			for (int i = 0; i < XIizDAIvfXWSeeEunnkOyCetKzC; i++)
			{
				if (mqdAbRkCKsLDODrmCZPalaGwyaPz[i].inputManagerId == inputManagerId)
				{
					mqdAbRkCKsLDODrmCZPalaGwyaPz[i].FillData(data);
					return;
				}
			}
			Logger.LogError("Invalid joystick Id " + inputManagerId + "!");
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

		[CustomObfuscation(rename = false)]
		public override void SetUnityJoystickId(int joystickId, int unityJoystickIndex)
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

		private void ensYNqjPxhKHeyOUbkLdLoRguEI(CustomInputSource.Joystick[] P_0)
		{
			int num = 0;
			List<VejAWXSRMctRclJIqGlrFcoadSul> list = mqdAbRkCKsLDODrmCZPalaGwyaPz;
			int xIizDAIvfXWSeeEunnkOyCetKzC = XIizDAIvfXWSeeEunnkOyCetKzC;
			mqdAbRkCKsLDODrmCZPalaGwyaPz = new List<VejAWXSRMctRclJIqGlrFcoadSul>();
			for (int i = 0; i < P_0.Length; i++)
			{
				if (P_0[i] != null)
				{
					VejAWXSRMctRclJIqGlrFcoadSul item = new VejAWXSRMctRclJIqGlrFcoadSul(jNeXbbXHzpFbwCRcRezbqitHBfb, P_0[i].systemId, P_0[i].unityId, P_0[i], jNeXbbXHzpFbwCRcRezbqitHBfb.inputSource, P_0[i].extension, PkYFoJbHDSFVrSOHBVJAgJwpYncH);
					mqdAbRkCKsLDODrmCZPalaGwyaPz.Add(item);
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
				mqdAbRkCKsLDODrmCZPalaGwyaPz[i].Update();
			}
		}

		private void uUjXiurHcZMVvSbyRINtfLKgLmy(int P_0, int P_1, List<VejAWXSRMctRclJIqGlrFcoadSul> P_2, List<VejAWXSRMctRclJIqGlrFcoadSul> P_3)
		{
			if (P_1 > 0)
			{
				P_3.Sort(VejAWXSRMctRclJIqGlrFcoadSul.frBYFaDROjIWmQIiGDxniOluCiaH);
			}
			if (P_0 > 0 && P_1 > 0)
			{
				qCjFkjCKBBayHefbiUiJnQdNyEAc(P_1, P_3, P_0, P_2, fqqCpbSMrueuJOOzTFUbiGnTdSq.oCnKZoKtxJwBouHcmCTMIHwNYP.FSpAuHtupjDZXhUqvazjlutzPIHg);
				if (jNeXbbXHzpFbwCRcRezbqitHBfb.useApproximateMatching)
				{
					qCjFkjCKBBayHefbiUiJnQdNyEAc(P_1, P_3, P_0, P_2, fqqCpbSMrueuJOOzTFUbiGnTdSq.oCnKZoKtxJwBouHcmCTMIHwNYP.zolnAcOnXpGZenMMlAIrNiahLST);
				}
			}
			cxfdSKgGqqAkSHDXxofROylxYBHG(P_1, P_3, fqqCpbSMrueuJOOzTFUbiGnTdSq.oCnKZoKtxJwBouHcmCTMIHwNYP.FSpAuHtupjDZXhUqvazjlutzPIHg);
			if (jNeXbbXHzpFbwCRcRezbqitHBfb.useApproximateMatching)
			{
				cxfdSKgGqqAkSHDXxofROylxYBHG(P_1, P_3, fqqCpbSMrueuJOOzTFUbiGnTdSq.oCnKZoKtxJwBouHcmCTMIHwNYP.zolnAcOnXpGZenMMlAIrNiahLST);
			}
			for (int i = 0; i < P_1; i++)
			{
				VejAWXSRMctRclJIqGlrFcoadSul vejAWXSRMctRclJIqGlrFcoadSul = P_3[i];
				if (vejAWXSRMctRclJIqGlrFcoadSul != null && vejAWXSRMctRclJIqGlrFcoadSul.inputManagerId < 0)
				{
					vejAWXSRMctRclJIqGlrFcoadSul.inputManagerId = NyHyNinRgcrbSYtQTeIqkUCRiko(P_3);
					vejAWXSRMctRclJIqGlrFcoadSul.rewiredId = ReInput.GetNewJoystickId();
					tWaggyJPBcRxwyAUFZkujNIcHgO.ROWDMagIyIfgsVWhoSroKVHpUgvW(vejAWXSRMctRclJIqGlrFcoadSul);
				}
			}
			P_3.Sort(VejAWXSRMctRclJIqGlrFcoadSul.QWRAqqDVdRarhOjzSpdusXmYAGUC);
		}

		private void FnIfaDIUQWVgbiivtjTLYkhLkpq(List<VejAWXSRMctRclJIqGlrFcoadSul> P_0, int P_1, int P_2)
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

		private bool NkfgIpcuIAsjZIJbIIBeJvbMbagI(List<VejAWXSRMctRclJIqGlrFcoadSul> P_0, int P_1)
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

		private int NyHyNinRgcrbSYtQTeIqkUCRiko(List<VejAWXSRMctRclJIqGlrFcoadSul> P_0)
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

		private bool BaEnDOhUnzNYdsILLLieXmcUjHl(List<VejAWXSRMctRclJIqGlrFcoadSul> P_0, int P_1)
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

		private void qCjFkjCKBBayHefbiUiJnQdNyEAc(int P_0, List<VejAWXSRMctRclJIqGlrFcoadSul> P_1, int P_2, List<VejAWXSRMctRclJIqGlrFcoadSul> P_3, fqqCpbSMrueuJOOzTFUbiGnTdSq.oCnKZoKtxJwBouHcmCTMIHwNYP P_4)
		{
			int num = ((P_4 != 0) ? 1 : 2);
			for (int i = 0; i < P_0; i++)
			{
				VejAWXSRMctRclJIqGlrFcoadSul vejAWXSRMctRclJIqGlrFcoadSul = P_1[i];
				if (vejAWXSRMctRclJIqGlrFcoadSul == null || vejAWXSRMctRclJIqGlrFcoadSul.inputManagerId >= 0)
				{
					continue;
				}
				for (int j = 0; j < P_2; j++)
				{
					VejAWXSRMctRclJIqGlrFcoadSul vejAWXSRMctRclJIqGlrFcoadSul2 = P_3[j];
					if (vejAWXSRMctRclJIqGlrFcoadSul2 != null && !BaEnDOhUnzNYdsILLLieXmcUjHl(P_1, vejAWXSRMctRclJIqGlrFcoadSul2.rewiredId) && vejAWXSRMctRclJIqGlrFcoadSul.sRrGplMHNlzmCBfgKNqGViUdGhN(vejAWXSRMctRclJIqGlrFcoadSul2) >= num)
					{
						vejAWXSRMctRclJIqGlrFcoadSul.inputManagerId = vejAWXSRMctRclJIqGlrFcoadSul2.inputManagerId;
						vejAWXSRMctRclJIqGlrFcoadSul.rewiredId = vejAWXSRMctRclJIqGlrFcoadSul2.rewiredId;
						tWaggyJPBcRxwyAUFZkujNIcHgO.ROWDMagIyIfgsVWhoSroKVHpUgvW(vejAWXSRMctRclJIqGlrFcoadSul);
					}
				}
			}
		}

		private void cxfdSKgGqqAkSHDXxofROylxYBHG(int P_0, List<VejAWXSRMctRclJIqGlrFcoadSul> P_1, fqqCpbSMrueuJOOzTFUbiGnTdSq.oCnKZoKtxJwBouHcmCTMIHwNYP P_2)
		{
			for (int i = 0; i < P_0; i++)
			{
				VejAWXSRMctRclJIqGlrFcoadSul vejAWXSRMctRclJIqGlrFcoadSul = P_1[i];
				if (vejAWXSRMctRclJIqGlrFcoadSul == null || vejAWXSRMctRclJIqGlrFcoadSul.inputManagerId >= 0)
				{
					continue;
				}
				fqqCpbSMrueuJOOzTFUbiGnTdSq.zBIwceIOCNlsQfzhTfrJTUjseRB zBIwceIOCNlsQfzhTfrJTUjseRB = null;
				foreach (fqqCpbSMrueuJOOzTFUbiGnTdSq.zBIwceIOCNlsQfzhTfrJTUjseRB item in tWaggyJPBcRxwyAUFZkujNIcHgO.WfScZfFnYvGYNnfxpPOcIypkwcfV(vejAWXSRMctRclJIqGlrFcoadSul, P_2))
				{
					if (!BaEnDOhUnzNYdsILLLieXmcUjHl(P_1, item.gNijVFSxPIkIXVEBfXiCOWbvkEY) && item.uDYTVizJuwnXvzyofQhbtGjAJpaE >= 0)
					{
						zBIwceIOCNlsQfzhTfrJTUjseRB = item;
						break;
					}
				}
				if (zBIwceIOCNlsQfzhTfrJTUjseRB != null)
				{
					int num = zBIwceIOCNlsQfzhTfrJTUjseRB.uDYTVizJuwnXvzyofQhbtGjAJpaE;
					if (!NkfgIpcuIAsjZIJbIIBeJvbMbagI(P_1, num))
					{
						num = (zBIwceIOCNlsQfzhTfrJTUjseRB.uDYTVizJuwnXvzyofQhbtGjAJpaE = NyHyNinRgcrbSYtQTeIqkUCRiko(P_1));
					}
					vejAWXSRMctRclJIqGlrFcoadSul.inputManagerId = num;
					vejAWXSRMctRclJIqGlrFcoadSul.rewiredId = zBIwceIOCNlsQfzhTfrJTUjseRB.gNijVFSxPIkIXVEBfXiCOWbvkEY;
					tWaggyJPBcRxwyAUFZkujNIcHgO.ROWDMagIyIfgsVWhoSroKVHpUgvW(vejAWXSRMctRclJIqGlrFcoadSul);
				}
			}
		}

		private void wCDaVFQPEORUeWyoEnGRkTcDqlD()
		{
			CustomInputSource.Joystick[] array = jNeXbbXHzpFbwCRcRezbqitHBfb.KQofPLAjTuJuhepcqipQzhiuXed();
			if (RFvNRIRPwwcpvBALOSCUnYLABFH(array))
			{
				ensYNqjPxhKHeyOUbkLdLoRguEI(array);
			}
			dwsDsPDKgHTKQVAjREDWSXOsYkJ = false;
		}

		private bool RFvNRIRPwwcpvBALOSCUnYLABFH(CustomInputSource.Joystick[] P_0)
		{
			int num = P_0.Length;
			int count = mqdAbRkCKsLDODrmCZPalaGwyaPz.Count;
			if (num != count)
			{
				return true;
			}
			for (int i = 0; i < num; i++)
			{
				if (P_0[i] == null)
				{
					continue;
				}
				long? systemId = P_0[i].systemId;
				bool flag = false;
				for (int j = 0; j < count; j++)
				{
					if (mqdAbRkCKsLDODrmCZPalaGwyaPz[j] != null && systemId == mqdAbRkCKsLDODrmCZPalaGwyaPz[j].systemId)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					return true;
				}
			}
			for (int k = 0; k < count; k++)
			{
				if (mqdAbRkCKsLDODrmCZPalaGwyaPz[k] == null)
				{
					continue;
				}
				long? systemId2 = mqdAbRkCKsLDODrmCZPalaGwyaPz[k].systemId;
				bool flag2 = false;
				for (int l = 0; l < num; l++)
				{
					if (P_0[l] != null && systemId2 == P_0[l].systemId)
					{
						flag2 = true;
						break;
					}
				}
				if (!flag2)
				{
					return true;
				}
			}
			return false;
		}

		private void lKgzcfQSolDGPyoEdiWHqTPwByFB(List<VejAWXSRMctRclJIqGlrFcoadSul> P_0, List<VejAWXSRMctRclJIqGlrFcoadSul> P_1, bool P_2)
		{
			if (P_0 == null)
			{
				return;
			}
			int num = P_0?.Count ?? 0;
			int num2 = P_1?.Count ?? 0;
			for (int i = 0; i < num; i++)
			{
				VejAWXSRMctRclJIqGlrFcoadSul vejAWXSRMctRclJIqGlrFcoadSul = P_0[i];
				if (vejAWXSRMctRclJIqGlrFcoadSul == null)
				{
					continue;
				}
				bool flag = false;
				if (P_1 != null)
				{
					for (int j = 0; j < num2; j++)
					{
						VejAWXSRMctRclJIqGlrFcoadSul vejAWXSRMctRclJIqGlrFcoadSul2 = P_1[j];
						if (vejAWXSRMctRclJIqGlrFcoadSul2 != null && vejAWXSRMctRclJIqGlrFcoadSul.rewiredId == vejAWXSRMctRclJIqGlrFcoadSul2.rewiredId)
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

		private void RLICzZUPMdNWULVjCmtEQTTFtRN(VejAWXSRMctRclJIqGlrFcoadSul P_0, bool P_1)
		{
			if (P_1)
			{
				P_0.bkgEYhHIcUmSMKTTycbOUwNiaJIk();
			}
			qdhDAoqCgaitJfFBFVZjtDilWIuA(P_0, P_1);
		}

		private void qdhDAoqCgaitJfFBFVZjtDilWIuA(VejAWXSRMctRclJIqGlrFcoadSul P_0, bool P_1)
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
	}
}
