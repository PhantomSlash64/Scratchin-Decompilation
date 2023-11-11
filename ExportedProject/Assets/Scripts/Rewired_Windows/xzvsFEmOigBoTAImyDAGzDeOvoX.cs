using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Config;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Utils;
using UnityEngine;

internal class xzvsFEmOigBoTAImyDAGzDeOvoX : IDisposable, IUnifiedKeyboardSource
{
	private class VZGWIMjiASyeXfiLlAlEYqlSVso
	{
		private enum jYcXmMuSDHhoDPLXRnzPiWxuBcQ
		{
			HRwhOziqklijDWtMBlqDBzEDePP = 0,
			PtmzwbWJMjlItMPMbSdtIbhDUhv = 1,
			knedCXyjRFMRrbiLFBVjfsQvMRO = 2
		}

		private const int NVCTgvbeEhFfVADzGojtYDcYhAW = 2;

		private static readonly KeyCode[] iWRSEQrWzZLzDequpIpmhIewcvv = new KeyCode[2];

		private readonly UpdateLoopType iWjEHYioHkUQEUDdwzaMtFztafj;

		private bool[] jYpFNafrKewgWVUhMLEYAHngxQgt;

		private bool[] YxjKESsJoLbtdZlViRYJgbJcRcM;

		private uint tYNiisVGAUJVJLIultlWNLNAPas;

		public VZGWIMjiASyeXfiLlAlEYqlSVso(UpdateLoopType updateLoop)
		{
			iWjEHYioHkUQEUDdwzaMtFztafj = updateLoop;
			jYpFNafrKewgWVUhMLEYAHngxQgt = new bool[132];
			YxjKESsJoLbtdZlViRYJgbJcRcM = new bool[132];
		}

		public void NWlacreQZdPelbINrpysXKCfkWG(fEwvYsosGHESMUTjAtCcjZZuQJI P_0)
		{
			int num = MqmOGSLCopIzBPoAeYGZWXwXjam(P_0, iWRSEQrWzZLzDequpIpmhIewcvv);
			for (int i = 0; i < num; i++)
			{
				int num2 = (int)iWRSEQrWzZLzDequpIpmhIewcvv[i];
				if (num2 >= 0 && num2 < HsVYNKsdOwYiumAnKQNCAIyrQXT.Length)
				{
					zqwrcrfPBjjcRqllhxjGsfGYjVOD dppVBsbnRfYftslzSqelpoQMcuf = P_0.dppVBsbnRfYftslzSqelpoQMcuf;
					zqwrcrfPBjjcRqllhxjGsfGYjVOD zqwrcrfPBjjcRqllhxjGsfGYjVOD2 = dppVBsbnRfYftslzSqelpoQMcuf;
					bool flag = ((zqwrcrfPBjjcRqllhxjGsfGYjVOD2 == zqwrcrfPBjjcRqllhxjGsfGYjVOD.FnpyYbWKGuMauKhpfZEJTivDEGn || zqwrcrfPBjjcRqllhxjGsfGYjVOD2 == zqwrcrfPBjjcRqllhxjGsfGYjVOD.TGKadxUJPrGqipzkyJjMZWjsyfZ) ? true : false);
					int num3 = HsVYNKsdOwYiumAnKQNCAIyrQXT[num2];
					bool flag2 = jYpFNafrKewgWVUhMLEYAHngxQgt[num3];
					jYpFNafrKewgWVUhMLEYAHngxQgt[num3] = flag;
					if (!flag2 && flag)
					{
						YxjKESsJoLbtdZlViRYJgbJcRcM[num3] = true;
					}
				}
			}
		}

		public void AqSHUwrsGAehycDXTjkPSOPFauPD(ControllerDataUpdater P_0)
		{
			bool[] buttonValues = P_0.buttonValues;
			for (int i = 0; i < 132; i++)
			{
				buttonValues[i] = jYpFNafrKewgWVUhMLEYAHngxQgt[i] || YxjKESsJoLbtdZlViRYJgbJcRcM[i];
			}
			tANYPPmjmFRGWnDkeBsNpdYspJd();
		}

		public void aWoeUUEECkNImBpxjMjDHgymWpn()
		{
			tANYPPmjmFRGWnDkeBsNpdYspJd();
		}

		private void tANYPPmjmFRGWnDkeBsNpdYspJd()
		{
			if (tYNiisVGAUJVJLIultlWNLNAPas != ReInput.absFrame)
			{
				TsrfECfqBPAXlCyKCQeZcCSgdDRO();
				tYNiisVGAUJVJLIultlWNLNAPas = ReInput.absFrame;
			}
		}

		public void TsrfECfqBPAXlCyKCQeZcCSgdDRO()
		{
			Array.Clear(YxjKESsJoLbtdZlViRYJgbJcRcM, 0, 132);
		}

		public void OeUrnnZKFEfcUxLGqEbSdcenXWX()
		{
			Array.Clear(jYpFNafrKewgWVUhMLEYAHngxQgt, 0, 132);
			Array.Clear(YxjKESsJoLbtdZlViRYJgbJcRcM, 0, 132);
		}
	}

	private const int bmlbwDUOPdeVBuVLqMwizToMkTz = 132;

	private const int dVSlqsFeAogKuDYuCdCghEJGSiZn = 256;

	private readonly object QnjPDsavPpORFdRFTiPBJdcwCnOc = new object();

	private UpdateLoopDataSet<VZGWIMjiASyeXfiLlAlEYqlSVso> uWFNPnNCyvNGhsbdEcSfiNPOhORz;

	private HardwareControllerMap_Game sJSDCsgTzLXPDeYdpaIPQRLscSKQ;

	private bool LYxRDDNdamSvSMBeWWmuRJkYcxA;

	private int vsYREYONSiIiWFyaUwZIwpDXwrX;

	private bool[] GWpOJDUadyAqdZcwGEUupNPBJTi = new bool[256];

	private readonly fEwvYsosGHESMUTjAtCcjZZuQJI IvOSqiSqBGzSsBmrJyPMSBicSuC = new fEwvYsosGHESMUTjAtCcjZZuQJI();

	private static readonly int[] HsVYNKsdOwYiumAnKQNCAIyrQXT;

	private static readonly int NekxhBNjHryQKxRqhRVmvDeyLgv;

	private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

	private static IntPtr FeJjrhpKygMbjhuDvOSThYQbfFZ;

	private static VEdhoLaqZqTiAlYgElsfdGsPTuKQ.lzjcGnlovMdHBWhNGlGpIvHvUPe FCOlyCdrcutMXrNhJixZhJluEKWl;

	private static readonly int[] MsmOEUXvhlvHTKZUufZHbORUALw;

	private static Dictionary<int, Dictionary<int, KeyCode>> wwaROlKAKAMjnVbRvDRkwfMRPjm;

	private static readonly int[] YioEcBGnRXDIErtHVbOqUWtBAZWC;

	public InputSource inputSource => InputSource.RawInput;

	public HardwareControllerMap_Game hardwareMap
	{
		get
		{
			if (sJSDCsgTzLXPDeYdpaIPQRLscSKQ == null)
			{
				sJSDCsgTzLXPDeYdpaIPQRLscSKQ = knzljgRNjcKvhfxVmMiOjJypPea();
			}
			return sJSDCsgTzLXPDeYdpaIPQRLscSKQ;
		}
	}

	public int buttonCount => 132;

	public Controller.Extension controllerExtension => null;

	static xzvsFEmOigBoTAImyDAGzDeOvoX()
	{
		FCOlyCdrcutMXrNhJixZhJluEKWl = VEdhoLaqZqTiAlYgElsfdGsPTuKQ.lzjcGnlovMdHBWhNGlGpIvHvUPe.zhqPcUOWBuYcldeoxEhrKvdvMiO;
		MsmOEUXvhlvHTKZUufZHbORUALw = (int[])Enum.GetValues(typeof(VEdhoLaqZqTiAlYgElsfdGsPTuKQ.lzjcGnlovMdHBWhNGlGpIvHvUPe));
		wwaROlKAKAMjnVbRvDRkwfMRPjm = new Dictionary<int, Dictionary<int, KeyCode>>
		{
			{
				1033,
				new Dictionary<int, KeyCode>
				{
					{
						222,
						KeyCode.Quote
					},
					{
						188,
						KeyCode.Comma
					},
					{
						189,
						KeyCode.Minus
					},
					{
						190,
						KeyCode.Period
					},
					{
						191,
						KeyCode.Slash
					},
					{
						186,
						KeyCode.Semicolon
					},
					{
						187,
						KeyCode.Equals
					},
					{
						219,
						KeyCode.LeftBracket
					},
					{
						220,
						KeyCode.Backslash
					},
					{
						221,
						KeyCode.RightBracket
					},
					{
						192,
						KeyCode.BackQuote
					},
					{
						223,
						KeyCode.BackQuote
					}
				}
			},
			{
				2057,
				new Dictionary<int, KeyCode>
				{
					{
						223,
						KeyCode.BackQuote
					},
					{
						192,
						KeyCode.Quote
					}
				}
			},
			{
				1106,
				new Dictionary<int, KeyCode>
				{
					{
						223,
						KeyCode.BackQuote
					},
					{
						192,
						KeyCode.Quote
					}
				}
			},
			{
				1031,
				new Dictionary<int, KeyCode>
				{
					{
						219,
						KeyCode.Backslash
					},
					{
						221,
						KeyCode.BackQuote
					}
				}
			}
		};
		YioEcBGnRXDIErtHVbOqUWtBAZWC = new int[22]
		{
			186, 191, 192, 219, 220, 221, 222, 223, 226, 226,
			254, 221, 188, 189, 219, 190, 220, 187, 191, 222,
			186, 192
		};
		int[] keyboardKeyValues = Consts._keyboardKeyValues;
		int num = keyboardKeyValues.Length;
		for (int i = 0; i < num; i++)
		{
			if (keyboardKeyValues[i] > NekxhBNjHryQKxRqhRVmvDeyLgv)
			{
				NekxhBNjHryQKxRqhRVmvDeyLgv = keyboardKeyValues[i];
			}
		}
		HsVYNKsdOwYiumAnKQNCAIyrQXT = new int[NekxhBNjHryQKxRqhRVmvDeyLgv + 1];
		ArrayTools.Fill(HsVYNKsdOwYiumAnKQNCAIyrQXT, -1);
		for (int j = 0; j < num; j++)
		{
			HsVYNKsdOwYiumAnKQNCAIyrQXT[keyboardKeyValues[j]] = j;
		}
	}

	public xzvsFEmOigBoTAImyDAGzDeOvoX(UpdateLoopSetting updateLoopSetting)
	{
		ITwKRLraQMaFkahkXMtiYTarHYY();
		uWFNPnNCyvNGhsbdEcSfiNPOhORz = new UpdateLoopDataSet<VZGWIMjiASyeXfiLlAlEYqlSVso>(updateLoopSetting);
		using (TempListPool.TList<UpdateLoopType> tList = TempListPool.GetTList<UpdateLoopType>(3))
		{
			List<UpdateLoopType> list = tList.list;
			EnumConverter.ToUpdateLoopTypes(updateLoopSetting, list);
			for (int i = 0; i < list.Count; i++)
			{
				uWFNPnNCyvNGhsbdEcSfiNPOhORz[i] = new VZGWIMjiASyeXfiLlAlEYqlSVso(list[i]);
			}
		}
		LYxRDDNdamSvSMBeWWmuRJkYcxA = ReInput.IsInputAllowed(ControllerType.Keyboard);
		ReInput.ApplicationFocusChangedEvent += UwyorDvIWzXQBkzFUOYiPtXNewU;
		ReInput.EditorPauseChangedEvent += FoGJrdVhRFJXGtnwGtshsbWOxVL;
		ReInput.UpdateEndedEvent += omilOcNkEThsOcELZzuoCnYZNdun;
		ReInput.TimeScalePauseChangedEvent += hNMUQdFkaBMDdEhbgIFpgIJjTmFJ;
	}

	public unsafe void EBZMKoSknSfzkSfokUzktanzxJf(UpdateLoopType P_0)
	{
		uWFNPnNCyvNGhsbdEcSfiNPOhORz.SetUpdateLoop(P_0);
		LYxRDDNdamSvSMBeWWmuRJkYcxA = ReInput.IsInputAllowed(ControllerType.Keyboard);
		lock (QnjPDsavPpORFdRFTiPBJdcwCnOc)
		{
			try
			{
				byte* ptr = stackalloc byte[256];
				if (!FzngAIhKGFOAkXUDRNTZlbDTVEc.wRFhMEAaFQmJnqBItOycfFxahiCh((IntPtr)ptr))
				{
					return;
				}
				for (int i = 0; i < 256; i++)
				{
					switch (i)
					{
					case 1:
					case 2:
					case 4:
					case 5:
					case 6:
					case 16:
					case 17:
					case 18:
					case 65536:
					case 131072:
						continue;
					}
					if ((ptr[i] & 0x80) == 0)
					{
						if (GWpOJDUadyAqdZcwGEUupNPBJTi[i])
						{
							IvOSqiSqBGzSsBmrJyPMSBicSuC.yXtbQoGixuQSGXVAmsnwhfKJRzx();
							IvOSqiSqBGzSsBmrJyPMSBicSuC.whnSCgYhOHHdijUNBdmxeaEVvKvd = ReInput.realTime;
							IvOSqiSqBGzSsBmrJyPMSBicSuC.GimIILJmyeYgyOLgHcSzyDOWuaf = IntPtr.Zero;
							IvOSqiSqBGzSsBmrJyPMSBicSuC.JlBSDhmiitSTmVNZRTBRTPmyoAf = (zvemIpuEoAzRNyBIqsNzMAXZEiyJ)i;
							IvOSqiSqBGzSsBmrJyPMSBicSuC.rAmboqpswIeKHuTEAAucsqGXiigH = 0;
							IvOSqiSqBGzSsBmrJyPMSBicSuC.mEdElWhlzNEtJlueuzwJxcgYMue = pzBCExfDfEahFIZrIkzvfugCKKmO.QhrICmHupEUnBJwsCyCKfsiUHws;
							IvOSqiSqBGzSsBmrJyPMSBicSuC.dppVBsbnRfYftslzSqelpoQMcuf = zqwrcrfPBjjcRqllhxjGsfGYjVOD.ppkZDuXLpSDGbTFWPutxhFWvSAi;
							IvOSqiSqBGzSsBmrJyPMSBicSuC.dRlKolLFRTDGBpGJleoNyVEFiPp = 0;
							kcpIBCdrZEFAOcZMterMlSZVafR(IvOSqiSqBGzSsBmrJyPMSBicSuC);
						}
					}
					else if (!GWpOJDUadyAqdZcwGEUupNPBJTi[i])
					{
						IvOSqiSqBGzSsBmrJyPMSBicSuC.yXtbQoGixuQSGXVAmsnwhfKJRzx();
						IvOSqiSqBGzSsBmrJyPMSBicSuC.whnSCgYhOHHdijUNBdmxeaEVvKvd = ReInput.realTime;
						IvOSqiSqBGzSsBmrJyPMSBicSuC.GimIILJmyeYgyOLgHcSzyDOWuaf = IntPtr.Zero;
						IvOSqiSqBGzSsBmrJyPMSBicSuC.JlBSDhmiitSTmVNZRTBRTPmyoAf = (zvemIpuEoAzRNyBIqsNzMAXZEiyJ)i;
						IvOSqiSqBGzSsBmrJyPMSBicSuC.rAmboqpswIeKHuTEAAucsqGXiigH = 0;
						IvOSqiSqBGzSsBmrJyPMSBicSuC.mEdElWhlzNEtJlueuzwJxcgYMue = pzBCExfDfEahFIZrIkzvfugCKKmO.ymqUmXkAkxAGyBTOHVKMfyhZVXp;
						IvOSqiSqBGzSsBmrJyPMSBicSuC.dppVBsbnRfYftslzSqelpoQMcuf = zqwrcrfPBjjcRqllhxjGsfGYjVOD.FnpyYbWKGuMauKhpfZEJTivDEGn;
						IvOSqiSqBGzSsBmrJyPMSBicSuC.dRlKolLFRTDGBpGJleoNyVEFiPp = 0;
						kcpIBCdrZEFAOcZMterMlSZVafR(IvOSqiSqBGzSsBmrJyPMSBicSuC);
					}
				}
			}
			catch
			{
			}
		}
	}

	public void kcpIBCdrZEFAOcZMterMlSZVafR(fEwvYsosGHESMUTjAtCcjZZuQJI P_0)
	{
		if (!LYxRDDNdamSvSMBeWWmuRJkYcxA)
		{
			return;
		}
		switch (P_0.JlBSDhmiitSTmVNZRTBRTPmyoAf)
		{
		case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.vBYajnKBNalhSCsIrfGgBUQZDCH:
		{
			zvemIpuEoAzRNyBIqsNzMAXZEiyJ zvemIpuEoAzRNyBIqsNzMAXZEiyJ2 = (zvemIpuEoAzRNyBIqsNzMAXZEiyJ)FzngAIhKGFOAkXUDRNTZlbDTVEc.XWRezCqSzxtiaHRznBqIRpikaTw((uint)P_0.rAmboqpswIeKHuTEAAucsqGXiigH, VEdhoLaqZqTiAlYgElsfdGsPTuKQ.ejskzBuwBLvufJjTTZSeswexsHs);
			if (zvemIpuEoAzRNyBIqsNzMAXZEiyJ2 != zvemIpuEoAzRNyBIqsNzMAXZEiyJ.CotvmesfFHuWPBnZIslOJYGyvNX && zvemIpuEoAzRNyBIqsNzMAXZEiyJ2 != zvemIpuEoAzRNyBIqsNzMAXZEiyJ.aYqadEfvhrntdkrfpftdykqQPrmL)
			{
				return;
			}
			P_0.JlBSDhmiitSTmVNZRTBRTPmyoAf = (((P_0.mEdElWhlzNEtJlueuzwJxcgYMue & pzBCExfDfEahFIZrIkzvfugCKKmO.uNKrMFRkYWZvEcQCumijLGZtFNRd) != 0) ? zvemIpuEoAzRNyBIqsNzMAXZEiyJ.aYqadEfvhrntdkrfpftdykqQPrmL : zvemIpuEoAzRNyBIqsNzMAXZEiyJ.CotvmesfFHuWPBnZIslOJYGyvNX);
			break;
		}
		case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.GWkUgQWDsPTAKLbXczggOqSCllL:
			P_0.JlBSDhmiitSTmVNZRTBRTPmyoAf = (((P_0.mEdElWhlzNEtJlueuzwJxcgYMue & pzBCExfDfEahFIZrIkzvfugCKKmO.uNKrMFRkYWZvEcQCumijLGZtFNRd) != 0) ? zvemIpuEoAzRNyBIqsNzMAXZEiyJ.FClCUJcECFXHnPRwdJueDvghnHkk : zvemIpuEoAzRNyBIqsNzMAXZEiyJ.sShDtWhBuFPDTaSJgZTwIDPPazJd);
			break;
		case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.XXfYslJmFVRMpzaEkZRFPJMGyMv:
		{
			P_0.JlBSDhmiitSTmVNZRTBRTPmyoAf = (zvemIpuEoAzRNyBIqsNzMAXZEiyJ)FzngAIhKGFOAkXUDRNTZlbDTVEc.XWRezCqSzxtiaHRznBqIRpikaTw((uint)P_0.rAmboqpswIeKHuTEAAucsqGXiigH, VEdhoLaqZqTiAlYgElsfdGsPTuKQ.ejskzBuwBLvufJjTTZSeswexsHs);
			if (P_0.JlBSDhmiitSTmVNZRTBRTPmyoAf == zvemIpuEoAzRNyBIqsNzMAXZEiyJ.ohVitSkLrIbJfNScLueumbMmXpE || P_0.JlBSDhmiitSTmVNZRTBRTPmyoAf == zvemIpuEoAzRNyBIqsNzMAXZEiyJ.aSUwXfIHwytfJjALiarDTSXKfdcC)
			{
				break;
			}
			zqwrcrfPBjjcRqllhxjGsfGYjVOD dppVBsbnRfYftslzSqelpoQMcuf = P_0.dppVBsbnRfYftslzSqelpoQMcuf;
			bool flag = ((dppVBsbnRfYftslzSqelpoQMcuf == zqwrcrfPBjjcRqllhxjGsfGYjVOD.FnpyYbWKGuMauKhpfZEJTivDEGn || dppVBsbnRfYftslzSqelpoQMcuf == zqwrcrfPBjjcRqllhxjGsfGYjVOD.TGKadxUJPrGqipzkyJjMZWjsyfZ || dppVBsbnRfYftslzSqelpoQMcuf == zqwrcrfPBjjcRqllhxjGsfGYjVOD.NGSVsMgCFCDNFBQacpnSzBBgYHIH) ? true : false);
			bool flag2 = (FzngAIhKGFOAkXUDRNTZlbDTVEc.igCVSoHDdblNlHLAZbsoGxxAhvw(160) & 0x8000) != 0;
			bool flag3 = (FzngAIhKGFOAkXUDRNTZlbDTVEc.igCVSoHDdblNlHLAZbsoGxxAhvw(161) & 0x8000) != 0;
			if (flag)
			{
				bool flag4 = (FzngAIhKGFOAkXUDRNTZlbDTVEc.RrefBqeGJtougTLPjNxoydEGAklq(160) & 0x8000) != 0;
				bool flag5 = (FzngAIhKGFOAkXUDRNTZlbDTVEc.RrefBqeGJtougTLPjNxoydEGAklq(161) & 0x8000) != 0;
				if (flag4)
				{
					P_0.JlBSDhmiitSTmVNZRTBRTPmyoAf = zvemIpuEoAzRNyBIqsNzMAXZEiyJ.ohVitSkLrIbJfNScLueumbMmXpE;
					kcpIBCdrZEFAOcZMterMlSZVafR(P_0);
				}
				if (flag5)
				{
					P_0.JlBSDhmiitSTmVNZRTBRTPmyoAf = zvemIpuEoAzRNyBIqsNzMAXZEiyJ.aSUwXfIHwytfJjALiarDTSXKfdcC;
					kcpIBCdrZEFAOcZMterMlSZVafR(P_0);
				}
				return;
			}
			if (flag2 && flag3)
			{
				return;
			}
			if (flag2)
			{
				P_0.JlBSDhmiitSTmVNZRTBRTPmyoAf = zvemIpuEoAzRNyBIqsNzMAXZEiyJ.ohVitSkLrIbJfNScLueumbMmXpE;
				break;
			}
			if (flag3)
			{
				P_0.JlBSDhmiitSTmVNZRTBRTPmyoAf = zvemIpuEoAzRNyBIqsNzMAXZEiyJ.aSUwXfIHwytfJjALiarDTSXKfdcC;
				break;
			}
			P_0.JlBSDhmiitSTmVNZRTBRTPmyoAf = zvemIpuEoAzRNyBIqsNzMAXZEiyJ.ohVitSkLrIbJfNScLueumbMmXpE;
			kcpIBCdrZEFAOcZMterMlSZVafR(P_0);
			P_0.JlBSDhmiitSTmVNZRTBRTPmyoAf = zvemIpuEoAzRNyBIqsNzMAXZEiyJ.aSUwXfIHwytfJjALiarDTSXKfdcC;
			kcpIBCdrZEFAOcZMterMlSZVafR(P_0);
			return;
		}
		}
		lock (QnjPDsavPpORFdRFTiPBJdcwCnOc)
		{
			zqwrcrfPBjjcRqllhxjGsfGYjVOD dppVBsbnRfYftslzSqelpoQMcuf2 = P_0.dppVBsbnRfYftslzSqelpoQMcuf;
			if (dppVBsbnRfYftslzSqelpoQMcuf2 == zqwrcrfPBjjcRqllhxjGsfGYjVOD.FnpyYbWKGuMauKhpfZEJTivDEGn || dppVBsbnRfYftslzSqelpoQMcuf2 == zqwrcrfPBjjcRqllhxjGsfGYjVOD.TGKadxUJPrGqipzkyJjMZWjsyfZ)
			{
				GWpOJDUadyAqdZcwGEUupNPBJTi[(int)P_0.JlBSDhmiitSTmVNZRTBRTPmyoAf] = true;
			}
			else
			{
				GWpOJDUadyAqdZcwGEUupNPBJTi[(int)P_0.JlBSDhmiitSTmVNZRTBRTPmyoAf] = false;
			}
			int count = uWFNPnNCyvNGhsbdEcSfiNPOhORz.Count;
			for (int i = 0; i < count; i++)
			{
				uWFNPnNCyvNGhsbdEcSfiNPOhORz[i].NWlacreQZdPelbINrpysXKCfkWG(P_0);
			}
		}
	}

	public void lniiWJwGWtadnDScpppWlpTlmzW(bool P_0)
	{
		DZSnmSGVYWIuMFiZXjzWxXasKYN();
	}

	public void MlHrxkPdRhzTRtMsoFxLakiJNnhv(bool P_0)
	{
		int num = ITwKRLraQMaFkahkXMtiYTarHYY();
		if (num < 0)
		{
			DZSnmSGVYWIuMFiZXjzWxXasKYN();
		}
	}

	private int ITwKRLraQMaFkahkXMtiYTarHYY()
	{
		int num = vsYREYONSiIiWFyaUwZIwpDXwrX;
		if (RsVeIRZnmCozInvuVtbXAPKPjeyA.yOGBVwgQmTPAYhDSekCIUhJNbFUc(ZLCskcBqtJByBhszckujrsvBGnPh.hOKSQsVFahbyPnFtHtuTEPcoMO, out var num2))
		{
			vsYREYONSiIiWFyaUwZIwpDXwrX = num2;
		}
		else
		{
			vsYREYONSiIiWFyaUwZIwpDXwrX = 1;
		}
		return vsYREYONSiIiWFyaUwZIwpDXwrX - num;
	}

	private void UwyorDvIWzXQBkzFUOYiPtXNewU(bool P_0)
	{
		LYxRDDNdamSvSMBeWWmuRJkYcxA = ReInput.IsInputAllowed(ControllerType.Keyboard);
		if (!P_0 && !LYxRDDNdamSvSMBeWWmuRJkYcxA)
		{
			DZSnmSGVYWIuMFiZXjzWxXasKYN();
		}
	}

	private void FoGJrdVhRFJXGtnwGtshsbWOxVL(bool P_0)
	{
	}

	private void hNMUQdFkaBMDdEhbgIFpgIJjTmFJ(bool P_0)
	{
		if ((ReInput.configVars.updateLoop & UpdateLoopSetting.FixedUpdate) == 0)
		{
			return;
		}
		LYxRDDNdamSvSMBeWWmuRJkYcxA = ReInput.IsInputAllowed(ControllerType.Keyboard);
		lock (QnjPDsavPpORFdRFTiPBJdcwCnOc)
		{
			uWFNPnNCyvNGhsbdEcSfiNPOhORz[uWFNPnNCyvNGhsbdEcSfiNPOhORz.fixedUpdateSetIndex].TsrfECfqBPAXlCyKCQeZcCSgdDRO();
		}
	}

	private void omilOcNkEThsOcELZzuoCnYZNdun(UpdateLoopType P_0)
	{
		lock (QnjPDsavPpORFdRFTiPBJdcwCnOc)
		{
			uWFNPnNCyvNGhsbdEcSfiNPOhORz.Get(P_0).aWoeUUEECkNImBpxjMjDHgymWpn();
		}
	}

	private void DZSnmSGVYWIuMFiZXjzWxXasKYN()
	{
		lock (QnjPDsavPpORFdRFTiPBJdcwCnOc)
		{
			int count = uWFNPnNCyvNGhsbdEcSfiNPOhORz.Count;
			for (int i = 0; i < count; i++)
			{
				uWFNPnNCyvNGhsbdEcSfiNPOhORz[i].OeUrnnZKFEfcUxLGqEbSdcenXWX();
			}
		}
	}

	public void UpdateInputData(ControllerDataUpdater dataUpdater)
	{
		uWFNPnNCyvNGhsbdEcSfiNPOhORz.Current.AqSHUwrsGAehycDXTjkPSOPFauPD(dataUpdater);
	}

	public void Clear()
	{
		DZSnmSGVYWIuMFiZXjzWxXasKYN();
	}

	private static HardwareControllerMap_Game knzljgRNjcKvhfxVmMiOjJypPea()
	{
		ControllerElementIdentifier[] array = new ControllerElementIdentifier[132];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = new ControllerElementIdentifier(i, Consts.keyboardKeyNames[i], Consts.keyboardKeyNames[i], string.Empty, ControllerElementType.Button, isMappableOnPlatform: true);
		}
		int[] array2 = new int[132];
		for (int j = 0; j < 132; j++)
		{
			array2[j] = array[j].id;
		}
		HardwareButtonInfo[] array3 = new HardwareButtonInfo[132];
		for (int k = 0; k < 132; k++)
		{
			array3[k] = new HardwareButtonInfo();
		}
		return new HardwareControllerMap_Game("Keyboard", default(HardwareControllerMapIdentifier), array, array2, new int[0], new AxisCalibrationData[0], new AxisRange[0], new HardwareAxisInfo[0], array3, null);
	}

	public void Dispose()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
		GC.SuppressFinalize(this);
	}

	~xzvsFEmOigBoTAImyDAGzDeOvoX()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
	}

	protected virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (!jpnIPbpqmlecdiNqaFAxiNCsiMxs)
		{
			ReInput.ApplicationFocusChangedEvent -= UwyorDvIWzXQBkzFUOYiPtXNewU;
			ReInput.EditorPauseChangedEvent -= FoGJrdVhRFJXGtnwGtshsbWOxVL;
			ReInput.UpdateEndedEvent -= omilOcNkEThsOcELZzuoCnYZNdun;
			ReInput.TimeScalePauseChangedEvent -= hNMUQdFkaBMDdEhbgIFpgIJjTmFJ;
			jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
		}
	}

	public static int MqmOGSLCopIzBPoAeYGZWXwXjam(fEwvYsosGHESMUTjAtCcjZZuQJI P_0, KeyCode[] P_1)
	{
		zvemIpuEoAzRNyBIqsNzMAXZEiyJ jlBSDhmiitSTmVNZRTBRTPmyoAf = P_0.JlBSDhmiitSTmVNZRTBRTPmyoAf;
		int result = 0;
		VEdhoLaqZqTiAlYgElsfdGsPTuKQ.lzjcGnlovMdHBWhNGlGpIvHvUPe lzjcGnlovMdHBWhNGlGpIvHvUPe = MMRAdEcuklTWiHiLNWjqRdFPlki();
		_ = FeJjrhpKygMbjhuDvOSThYQbfFZ;
		FzngAIhKGFOAkXUDRNTZlbDTVEc.XWRezCqSzxtiaHRznBqIRpikaTw((uint)P_0.JlBSDhmiitSTmVNZRTBRTPmyoAf, VEdhoLaqZqTiAlYgElsfdGsPTuKQ.hyeagCedWfpkoCBAXCcyznukpRs);
		if (tKjyHRayUAGRoJCzZrUNyNjhbaC(jlBSDhmiitSTmVNZRTBRTPmyoAf))
		{
			if (pvLAwyABJjkQQJMnagscDcaMPHs(jlBSDhmiitSTmVNZRTBRTPmyoAf, lzjcGnlovMdHBWhNGlGpIvHvUPe, out var keyCode))
			{
				P_1[result++] = keyCode;
			}
		}
		else
		{
			switch (jlBSDhmiitSTmVNZRTBRTPmyoAf)
			{
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.HRwhOziqklijDWtMBlqDBzEDePP:
				P_1[result++] = KeyCode.None;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.SWHemgmIKgKBqisLCzVIzacevFT:
				P_1[result++] = KeyCode.A;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.JfCvJkWaXQtwhEHCboBLogVxRMi:
				P_1[result++] = KeyCode.B;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.CfCeyTHrydomIXHNWAeBonFbDAG:
				P_1[result++] = KeyCode.C;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.MYYTFWmdEAJsFOvTuhOUmwZuzJR:
				P_1[result++] = KeyCode.D;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.woNEoxUkyQmdYjaMlOamCNIdGHO:
				P_1[result++] = KeyCode.E;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.NiMDPHRzQRrXDghdusRAndvwcCtj:
				P_1[result++] = KeyCode.F;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.hyftlkUYNttttSGkzFELpkVkBeV:
				P_1[result++] = KeyCode.G;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.KiGdHNpvvgLALVFTqgveWPtblqA:
				P_1[result++] = KeyCode.H;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.JOvOXJotzLHxCkpfdlRXpjgsUSU:
				P_1[result++] = KeyCode.I;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.tTFmrsMJMTEfgNsatDOEgMiDvAS:
				P_1[result++] = KeyCode.J;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.bnWsMxiPNfjCHdikmoodHUPhDHOf:
				P_1[result++] = KeyCode.K;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.mFURxHbgyzySYoIrVgsrtOIGudK:
				P_1[result++] = KeyCode.L;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.fKXMPrMrrZvvhrIybgLcfYhMAroS:
				P_1[result++] = KeyCode.M;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.zVEVQudtilcpRmURJVjhSrnZRwU:
				P_1[result++] = KeyCode.N;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.OgWFsYeabBDjXPqEXDIomWntrsB:
				P_1[result++] = KeyCode.O;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.YBvMPqTdnWboaLdXELpEgFqXLZS:
				P_1[result++] = KeyCode.P;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.YwPLpxhXRrbBITEyFjaSWmQyCTTA:
				P_1[result++] = KeyCode.Q;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.NjwoGaMBLQfiFNiMJlpkSLlJcLw:
				P_1[result++] = KeyCode.R;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.bRZlIhpyvWszewmbZoxQydziqbx:
				P_1[result++] = KeyCode.S;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.MtalwQzjFRazUyXaESHwONOqtsP:
				P_1[result++] = KeyCode.T;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.VhEZymnjZsjbmyudIiPIKyIBjZf:
				P_1[result++] = KeyCode.U;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.tKRoBrEIqReIEaeoRemwyNuUUnVB:
				P_1[result++] = KeyCode.V;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.MTCEGFUJLZHlkEsXFhPPwpchqhpH:
				P_1[result++] = KeyCode.W;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.xpumVntKTYPdUAcEeqwWhsPgirN:
				P_1[result++] = KeyCode.X;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.RTwQzyWgdmiDfVtyeEaNgdMceZg:
				P_1[result++] = KeyCode.Y;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.TCogMmKASgopRYQJTNMtdAvdwtIe:
				P_1[result++] = KeyCode.Z;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.yixtPicrJvOLGUKGlldaVvPVBQw:
				P_1[result++] = KeyCode.Alpha0;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.rXylzuESvAqSayOrdWhyPLwKacO:
				P_1[result++] = KeyCode.Alpha1;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.ojLDEYBhRXOwheMIBiGaLCeujIK:
				P_1[result++] = KeyCode.Alpha2;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.GSzndAVYWmdttwKIqivjkAvffcx:
				P_1[result++] = KeyCode.Alpha3;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.InfJvxUvPIUgPevzEwlPEAnFRQT:
				P_1[result++] = KeyCode.Alpha4;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.kvbNHpIaPEZblPjgwleLTbljbOG:
				P_1[result++] = KeyCode.Alpha5;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.FBuUxXwEpPEyXtZDoQpuCJMfJFy:
				P_1[result++] = KeyCode.Alpha6;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.qiffpwGUkzmkBFDXnkVpQmiLiMKT:
				P_1[result++] = KeyCode.Alpha7;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.VfnUXuCANtiThiNgyoiynKaMTsN:
				P_1[result++] = KeyCode.Alpha8;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.bxctdtISdMutcPLbjmGwguuhAlY:
				P_1[result++] = KeyCode.Alpha9;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.OmawOHnXJgPRmKNscajCrkWiEmX:
				P_1[result++] = KeyCode.Keypad0;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.OhOMmutXtGhXJhljeRsTCrHlNPX:
				P_1[result++] = KeyCode.Keypad1;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.TqZyRmblwChNWdpTMQdslCAwgYDK:
				P_1[result++] = KeyCode.Keypad2;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.pNPDNFWluXtZThPFgOzWDavHmRK:
				P_1[result++] = KeyCode.Keypad3;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.YWUBFhjhgnVmJSXXiCpCfDmRusIE:
				P_1[result++] = KeyCode.Keypad4;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.GZXDjuAnduFqFAXTgKwhiiZwTETO:
				P_1[result++] = KeyCode.Keypad5;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.VqPDGqeRzqfubRJmQjKoSEtalXCb:
				P_1[result++] = KeyCode.Keypad6;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.YqsOxIOcRVUUcceNXsoeFHdnAaNI:
				P_1[result++] = KeyCode.Keypad7;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.SSOpzHHlJbZREIakkebDJOMmnLk:
				P_1[result++] = KeyCode.Keypad8;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.cMPcneHHhvKkvgBkQWaGpuWjWdL:
				P_1[result++] = KeyCode.Keypad9;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.NDZEnEaLXMRbtIqALHKKSnIrHfp:
				P_1[result++] = KeyCode.KeypadPeriod;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.zbnduCsouGqSPbiSBGtmGuStPDlt:
				P_1[result++] = KeyCode.KeypadDivide;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.hiOxCLoPKoHWgsCePmKfichSyKS:
				P_1[result++] = KeyCode.KeypadMultiply;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.RfeVJxRAhmzvJoZtHrSILbpRnQV:
				P_1[result++] = KeyCode.KeypadMinus;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.awMsSJTFCLycCsTVXgMchYNLLXw:
				P_1[result++] = KeyCode.KeypadPlus;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.iCRyCgCToUhELUrtkSukmQoFVoU:
				if ((P_0.mEdElWhlzNEtJlueuzwJxcgYMue & pzBCExfDfEahFIZrIkzvfugCKKmO.uNKrMFRkYWZvEcQCumijLGZtFNRd) != 0)
				{
					P_1[result++] = KeyCode.KeypadEnter;
				}
				else
				{
					P_1[result++] = KeyCode.Return;
				}
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.HwPUGTVNgVfzYhMVGKXbzgfUCImR:
				P_1[result++] = KeyCode.Backspace;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.rqfKxogSeafGJLkiniMmOdrQPKc:
				P_1[result++] = KeyCode.Tab;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.xZveeqhZWQBoifJNrEKvhlbeSAk:
				P_1[result++] = KeyCode.Clear;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.WsmrdifKRWoQOtKBSXcGkJRENSl:
				P_1[result++] = KeyCode.Pause;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.LSqWbmkAuuApAKDssICvXubAGzLw:
				P_1[result++] = KeyCode.Escape;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.mzFaoBrRQswcXKREgcwhvQatijk:
				P_1[result++] = KeyCode.Space;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.CWRhnAwmbgIhLUxqlrmVOQNvWDz:
				P_1[result++] = KeyCode.Delete;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.knedCXyjRFMRrbiLFBVjfsQvMRO:
				P_1[result++] = KeyCode.UpArrow;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.PtmzwbWJMjlItMPMbSdtIbhDUhv:
				P_1[result++] = KeyCode.DownArrow;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.IxJDCUJJHgAjSSldiYWDrZoWPCb:
				P_1[result++] = KeyCode.RightArrow;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.QObEKpHtzPeseDsrFKvAGuKHgauF:
				P_1[result++] = KeyCode.LeftArrow;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.ovucsrIdnrGTpBDRkVbfJGALZCIO:
				P_1[result++] = KeyCode.Insert;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.wyrkRPPsmGabLWsrTEFkqigZZWX:
				P_1[result++] = KeyCode.Home;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.ZTwTvKWXycDCvHDUoKZmWWLbNah:
				P_1[result++] = KeyCode.End;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.kAfEMleGBoPFIMpXdBnrndvlBPWB:
				P_1[result++] = KeyCode.PageUp;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.yLiXAnEKyxXbdqDpOmaoYMrImkC:
				P_1[result++] = KeyCode.PageDown;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.ZjgDtbhnsmNMNULQzjKlfdecWmMK:
				P_1[result++] = KeyCode.F1;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.AzIfitfrLfMoBdAtJmWKXLapoAGj:
				P_1[result++] = KeyCode.F2;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.UsZYQqyAXdkGayWySPLyzWTgdzO:
				P_1[result++] = KeyCode.F3;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.tBTQZEtmqMjfNcsGcMCTUGPlFdNC:
				P_1[result++] = KeyCode.F4;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.LvzWIxESQrErqLcEyDTAiUJNHkx:
				P_1[result++] = KeyCode.F5;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.ZgtPYUEKFqNxNaYuNbkLxAeeWpf:
				P_1[result++] = KeyCode.F6;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.eziPhkXOjPFyxbLjjvhhkMhxXFFk:
				P_1[result++] = KeyCode.F7;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.iZpZLIEqFQMfKSitKnqDJWjKOPp:
				P_1[result++] = KeyCode.F8;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.MFWprMKPVglzNMAlKpRTRfHoZRh:
				P_1[result++] = KeyCode.F9;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.ILsAIGGPbEhBgqlGHxyOeGjuqeUn:
				P_1[result++] = KeyCode.F10;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.HYcyicOqkGHhBLQaYLZnxGUyqzU:
				P_1[result++] = KeyCode.F11;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.duDflJDsKMFVKPCRNKtFHtNYSbu:
				P_1[result++] = KeyCode.F12;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.NwYoFgnrERCwHbqSAQHOooIvhbm:
				P_1[result++] = KeyCode.F13;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.wJfaCObwMywqrfNdOOxIFZguJaQv:
				P_1[result++] = KeyCode.F14;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.JFXBnBjmQSJfTjXOXEaDruqKNGYL:
				P_1[result++] = KeyCode.F15;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.XpiFjzfTAuZUleFquCvTyefiFyv:
				P_1[result++] = KeyCode.Numlock;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.snXBqGuMObDuFiMoZQPrUAThAce:
				P_1[result++] = KeyCode.CapsLock;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.jJKjSGhiKWGxgTlSjItxstxOaGx:
				P_1[result++] = KeyCode.ScrollLock;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.aSUwXfIHwytfJjALiarDTSXKfdcC:
				P_1[result++] = KeyCode.RightShift;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.ohVitSkLrIbJfNScLueumbMmXpE:
				P_1[result++] = KeyCode.LeftShift;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.aYqadEfvhrntdkrfpftdykqQPrmL:
				P_1[result++] = KeyCode.RightControl;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.CotvmesfFHuWPBnZIslOJYGyvNX:
				P_1[result++] = KeyCode.LeftControl;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.FClCUJcECFXHnPRwdJueDvghnHkk:
				P_1[result++] = KeyCode.AltGr;
				P_1[result++] = KeyCode.RightAlt;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.sShDtWhBuFPDTaSJgZTwIDPPazJd:
				P_1[result++] = KeyCode.LeftAlt;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.BPUAPRylmbiJfzhGHQWyWXqarSB:
				P_1[result++] = KeyCode.RightCommand;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.dRDevIGmLkFTFnwJqftESyaLWxF:
				P_1[result++] = KeyCode.LeftCommand;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.pgyMAAHvhHJJrmqguwuFatXbnDf:
				P_1[result++] = KeyCode.Help;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.jAJpXNEGgXqiceiNMtJFoJFmUHO:
				P_1[result++] = KeyCode.Print;
				break;
			case zvemIpuEoAzRNyBIqsNzMAXZEiyJ.FXMQbhTKmIICfpgRRwYJFrwztfG:
				P_1[result++] = KeyCode.Menu;
				break;
			}
		}
		return result;
	}

	private unsafe static VEdhoLaqZqTiAlYgElsfdGsPTuKQ.lzjcGnlovMdHBWhNGlGpIvHvUPe MMRAdEcuklTWiHiLNWjqRdFPlki()
	{
		IntPtr intPtr = FzngAIhKGFOAkXUDRNTZlbDTVEc.JxutsXPGMvpyXUnbVPuJltkGiio(0);
		if (intPtr == FeJjrhpKygMbjhuDvOSThYQbfFZ)
		{
			return FCOlyCdrcutMXrNhJixZhJluEKWl;
		}
		VEdhoLaqZqTiAlYgElsfdGsPTuKQ.lzjcGnlovMdHBWhNGlGpIvHvUPe lzjcGnlovMdHBWhNGlGpIvHvUPe = VEdhoLaqZqTiAlYgElsfdGsPTuKQ.lzjcGnlovMdHBWhNGlGpIvHvUPe.zhqPcUOWBuYcldeoxEhrKvdvMiO;
		byte* ptr = stackalloc byte[128];
		FzngAIhKGFOAkXUDRNTZlbDTVEc.oyQTVSUxcJgWNTrvebQSOTKOosN((IntPtr)ptr);
		string s = Marshal.PtrToStringUni((IntPtr)ptr);
		if (int.TryParse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out var result))
		{
			int num = ArrayTools.IndexOf(MsmOEUXvhlvHTKZUufZHbORUALw, result);
			if (num >= 0)
			{
				lzjcGnlovMdHBWhNGlGpIvHvUPe = (VEdhoLaqZqTiAlYgElsfdGsPTuKQ.lzjcGnlovMdHBWhNGlGpIvHvUPe)MsmOEUXvhlvHTKZUufZHbORUALw[num];
			}
		}
		FeJjrhpKygMbjhuDvOSThYQbfFZ = intPtr;
		FCOlyCdrcutMXrNhJixZhJluEKWl = lzjcGnlovMdHBWhNGlGpIvHvUPe;
		return lzjcGnlovMdHBWhNGlGpIvHvUPe;
	}

	private static bool pvLAwyABJjkQQJMnagscDcaMPHs(zvemIpuEoAzRNyBIqsNzMAXZEiyJ P_0, VEdhoLaqZqTiAlYgElsfdGsPTuKQ.lzjcGnlovMdHBWhNGlGpIvHvUPe P_1, out KeyCode P_2)
	{
		P_2 = KeyCode.None;
		if (!wwaROlKAKAMjnVbRvDRkwfMRPjm.TryGetValue((int)P_1, out var value))
		{
			value = wwaROlKAKAMjnVbRvDRkwfMRPjm[1033];
		}
		bool flag = value.TryGetValue((int)P_0, out P_2);
		if (!flag && P_1 != VEdhoLaqZqTiAlYgElsfdGsPTuKQ.lzjcGnlovMdHBWhNGlGpIvHvUPe.zhqPcUOWBuYcldeoxEhrKvdvMiO)
		{
			value = wwaROlKAKAMjnVbRvDRkwfMRPjm[1033];
			flag = value.TryGetValue((int)P_0, out P_2);
		}
		return flag;
	}

	private static bool tKjyHRayUAGRoJCzZrUNyNjhbaC(zvemIpuEoAzRNyBIqsNzMAXZEiyJ P_0)
	{
		return ArrayTools.Contains(YioEcBGnRXDIErtHVbOqUWtBAZWC, (int)P_0);
	}
}
