using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired.Interfaces;
using Rewired.Platforms.Custom;
using Rewired.Platforms.PS4.Internal;
using Rewired.Utils;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Platforms.PS4
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal sealed class PS4InputSource : CustomInputSource, IControllerAssigner
	{
		private class ZNWRpaZUPczFNbvALtTETNpkcWE
		{
			public struct kJUblSElzSdBwWbikNVHiOEDnsy
			{
				public int MjneFLkKUwoxlcJMhdolMzbLNxaE;

				public int cdutLQQMhPjGwflAJdLFJDGNnqx;

				public int RzFpBgOUOOaOMRJfAolyIFFSEDu;

				public WLVuCRcKtsuzZbsXPesHPMemkkF.BaseControllerType TbljTJdnUyByvBmAcVlblnMstNJL;

				public kJUblSElzSdBwWbikNVHiOEDnsy(int playerId, int handle, int deviceClass, WLVuCRcKtsuzZbsXPesHPMemkkF.BaseControllerType baseControllerType)
				{
					MjneFLkKUwoxlcJMhdolMzbLNxaE = playerId;
					cdutLQQMhPjGwflAJdLFJDGNnqx = handle;
					RzFpBgOUOOaOMRJfAolyIFFSEDu = deviceClass;
					TbljTJdnUyByvBmAcVlblnMstNJL = baseControllerType;
				}
			}

			public struct VtFcslVdTmOaEhoCXgsdDSHOuvW
			{
				public int MjneFLkKUwoxlcJMhdolMzbLNxaE;

				public int cdutLQQMhPjGwflAJdLFJDGNnqx;

				public WLVuCRcKtsuzZbsXPesHPMemkkF.BaseControllerType TbljTJdnUyByvBmAcVlblnMstNJL;

				public VtFcslVdTmOaEhoCXgsdDSHOuvW(int playerId, int handle, WLVuCRcKtsuzZbsXPesHPMemkkF.BaseControllerType baseControllerType)
				{
					MjneFLkKUwoxlcJMhdolMzbLNxaE = playerId;
					cdutLQQMhPjGwflAJdLFJDGNnqx = handle;
					TbljTJdnUyByvBmAcVlblnMstNJL = baseControllerType;
				}
			}

			private class CsDrwxVLeEylzrgcYBKLbeWtfJb
			{
				public readonly WLVuCRcKtsuzZbsXPesHPMemkkF.BaseControllerType TbljTJdnUyByvBmAcVlblnMstNJL;

				public bool ROwiEnjcGJcjWhtTSzcbzuIyfLi;

				public int cdutLQQMhPjGwflAJdLFJDGNnqx;

				public int RzFpBgOUOOaOMRJfAolyIFFSEDu;

				public CsDrwxVLeEylzrgcYBKLbeWtfJb(WLVuCRcKtsuzZbsXPesHPMemkkF.BaseControllerType baseControllerType)
				{
					TbljTJdnUyByvBmAcVlblnMstNJL = baseControllerType;
					LlCkzvOeJVaCziTDPktzBWuYotAZ();
				}

				public ChangeType kcazFpqFBOzqBvoeQAfFdQlnYEH(bool P_0, int P_1, int P_2)
				{
					ChangeType changeType = ChangeType.None;
					if (ROwiEnjcGJcjWhtTSzcbzuIyfLi != P_0)
					{
						ROwiEnjcGJcjWhtTSzcbzuIyfLi = P_0;
						changeType |= (P_0 ? ChangeType.Connected : ChangeType.Disconnected);
						if (P_0)
						{
							cdutLQQMhPjGwflAJdLFJDGNnqx = P_1;
							RzFpBgOUOOaOMRJfAolyIFFSEDu = P_2;
							return changeType;
						}
						LlCkzvOeJVaCziTDPktzBWuYotAZ();
						return changeType;
					}
					if (cdutLQQMhPjGwflAJdLFJDGNnqx != P_1)
					{
						cdutLQQMhPjGwflAJdLFJDGNnqx = P_1;
						changeType |= ChangeType.IdentityChanged;
					}
					if (RzFpBgOUOOaOMRJfAolyIFFSEDu != P_2)
					{
						RzFpBgOUOOaOMRJfAolyIFFSEDu = P_2;
						changeType |= ChangeType.IdentityChanged;
					}
					return changeType;
				}

				private void LlCkzvOeJVaCziTDPktzBWuYotAZ()
				{
					ROwiEnjcGJcjWhtTSzcbzuIyfLi = false;
					cdutLQQMhPjGwflAJdLFJDGNnqx = -1;
					RzFpBgOUOOaOMRJfAolyIFFSEDu = -1;
				}
			}

			[Flags]
			[CustomObfuscation(rename = false)]
			private enum ChangeType
			{
				[CustomObfuscation(rename = false)]
				None = 0,
				[CustomObfuscation(rename = false)]
				Connected = 1,
				[CustomObfuscation(rename = false)]
				Disconnected = 2,
				[CustomObfuscation(rename = false)]
				IdentityChanged = 4
			}

			private readonly int BEBwieNJYwWTmtNbLWHfHUSYFhn;

			private readonly int[] mIUePgjeWZQlKlLlJcbHbEIjGYpl;

			private readonly int[] WJVxsYGTgolramKEfELxFiPChoEe;

			private readonly int[] GtpigfAXnTouKYcXawpbNoAUpDB;

			private readonly IExternalTools PIxmdAYLcWhIteruQBndYCOfEEb;

			private readonly CsDrwxVLeEylzrgcYBKLbeWtfJb[] ymFgomeldDFpyGehhqndZZnmexhf;

			private readonly CsDrwxVLeEylzrgcYBKLbeWtfJb[] EqHzqdOdMvGrFFharGHoHpKjvgb;

			private readonly CsDrwxVLeEylzrgcYBKLbeWtfJb[] hOlETZhssvxtzXdklBeygmTHlkiF;

			private readonly List<kJUblSElzSdBwWbikNVHiOEDnsy> QlRKDcOTlqkoeZOzErTqEEjbgYf;

			private readonly List<VtFcslVdTmOaEhoCXgsdDSHOuvW> rjklRGjIQdioAJhgDXlhrOzqAnT;

			[CompilerGenerated]
			private static Func<CsDrwxVLeEylzrgcYBKLbeWtfJb> kcHgEtKYhqtwzTPOvvORFEUwYnJ;

			[CompilerGenerated]
			private static Func<CsDrwxVLeEylzrgcYBKLbeWtfJb> LotWtnPDJdoYmvZxratQvQagYKU;

			[CompilerGenerated]
			private static Func<CsDrwxVLeEylzrgcYBKLbeWtfJb> pectuQcVPqrHcaPDJtuIjnCUgQY;

			public event Action<kJUblSElzSdBwWbikNVHiOEDnsy> SuvTUfskVUQhJpEKOlCpYyTKrhq;

			public event Action<VtFcslVdTmOaEhoCXgsdDSHOuvW> hezQeTAfzrYiSocaPYiHcljkBYI;

			public ZNWRpaZUPczFNbvALtTETNpkcWE(int maxPlayers)
			{
				BEBwieNJYwWTmtNbLWHfHUSYFhn = maxPlayers;
				mIUePgjeWZQlKlLlJcbHbEIjGYpl = new int[maxPlayers];
				WJVxsYGTgolramKEfELxFiPChoEe = new int[maxPlayers];
				GtpigfAXnTouKYcXawpbNoAUpDB = new int[maxPlayers];
				PIxmdAYLcWhIteruQBndYCOfEEb = UnityTools.externalTools;
				ymFgomeldDFpyGehhqndZZnmexhf = new CsDrwxVLeEylzrgcYBKLbeWtfJb[maxPlayers];
				ArrayTools.Populate(ymFgomeldDFpyGehhqndZZnmexhf, () => new CsDrwxVLeEylzrgcYBKLbeWtfJb(WLVuCRcKtsuzZbsXPesHPMemkkF.BaseControllerType.Gamepad));
				EqHzqdOdMvGrFFharGHoHpKjvgb = new CsDrwxVLeEylzrgcYBKLbeWtfJb[maxPlayers];
				ArrayTools.Populate(EqHzqdOdMvGrFFharGHoHpKjvgb, () => new CsDrwxVLeEylzrgcYBKLbeWtfJb(WLVuCRcKtsuzZbsXPesHPMemkkF.BaseControllerType.Special));
				hOlETZhssvxtzXdklBeygmTHlkiF = new CsDrwxVLeEylzrgcYBKLbeWtfJb[maxPlayers];
				ArrayTools.Populate(hOlETZhssvxtzXdklBeygmTHlkiF, () => new CsDrwxVLeEylzrgcYBKLbeWtfJb(WLVuCRcKtsuzZbsXPesHPMemkkF.BaseControllerType.Aim));
				QlRKDcOTlqkoeZOzErTqEEjbgYf = new List<kJUblSElzSdBwWbikNVHiOEDnsy>(2);
				rjklRGjIQdioAJhgDXlhrOzqAnT = new List<VtFcslVdTmOaEhoCXgsdDSHOuvW>(2);
			}

			public void mtiNfGzpXHszOwiOIAVYQuMZclV()
			{
				PIxmdAYLcWhIteruQBndYCOfEEb.PS4Input_PadGetUsersHandles2(BEBwieNJYwWTmtNbLWHfHUSYFhn, mIUePgjeWZQlKlLlJcbHbEIjGYpl);
				PIxmdAYLcWhIteruQBndYCOfEEb.PS4Input_SpecialGetUsersHandles2(BEBwieNJYwWTmtNbLWHfHUSYFhn, WJVxsYGTgolramKEfELxFiPChoEe);
				PIxmdAYLcWhIteruQBndYCOfEEb.PS4Input_AimGetUsersHandles2(BEBwieNJYwWTmtNbLWHfHUSYFhn, GtpigfAXnTouKYcXawpbNoAUpDB);
				for (int i = 0; i < BEBwieNJYwWTmtNbLWHfHUSYFhn; i++)
				{
					try
					{
						CsDrwxVLeEylzrgcYBKLbeWtfJb csDrwxVLeEylzrgcYBKLbeWtfJb = ymFgomeldDFpyGehhqndZZnmexhf[i];
						bool flag = PIxmdAYLcWhIteruQBndYCOfEEb.PS4Input_PadIsConnected(i);
						if (csDrwxVLeEylzrgcYBKLbeWtfJb.ROwiEnjcGJcjWhtTSzcbzuIyfLi || flag)
						{
							gWfWANbYXSDzocrzIKAyDZOrocr(i, csDrwxVLeEylzrgcYBKLbeWtfJb, mIUePgjeWZQlKlLlJcbHbEIjGYpl[i], flag, "Gamepad");
						}
						CsDrwxVLeEylzrgcYBKLbeWtfJb csDrwxVLeEylzrgcYBKLbeWtfJb2 = EqHzqdOdMvGrFFharGHoHpKjvgb[i];
						bool flag2 = PIxmdAYLcWhIteruQBndYCOfEEb.PS4Input_SpecialIsConnected(i);
						if (csDrwxVLeEylzrgcYBKLbeWtfJb2.ROwiEnjcGJcjWhtTSzcbzuIyfLi || flag2)
						{
							gWfWANbYXSDzocrzIKAyDZOrocr(i, csDrwxVLeEylzrgcYBKLbeWtfJb2, WJVxsYGTgolramKEfELxFiPChoEe[i], flag2, "Special");
						}
						CsDrwxVLeEylzrgcYBKLbeWtfJb csDrwxVLeEylzrgcYBKLbeWtfJb3 = hOlETZhssvxtzXdklBeygmTHlkiF[i];
						bool flag3 = PIxmdAYLcWhIteruQBndYCOfEEb.PS4Input_AimIsConnected(i);
						if (csDrwxVLeEylzrgcYBKLbeWtfJb3.ROwiEnjcGJcjWhtTSzcbzuIyfLi || flag3)
						{
							gWfWANbYXSDzocrzIKAyDZOrocr(i, csDrwxVLeEylzrgcYBKLbeWtfJb3, GtpigfAXnTouKYcXawpbNoAUpDB[i], flag3, "Aim");
						}
						if (rjklRGjIQdioAJhgDXlhrOzqAnT.Count > 0)
						{
							for (int j = 0; j < rjklRGjIQdioAJhgDXlhrOzqAnT.Count; j++)
							{
								try
								{
									this.hezQeTAfzrYiSocaPYiHcljkBYI(rjklRGjIQdioAJhgDXlhrOzqAnT[j]);
								}
								catch (Exception ex)
								{
									Logger.LogError("An exception occurred in controller monitor Controller Disconnect Event callback.\n" + ex);
								}
							}
							rjklRGjIQdioAJhgDXlhrOzqAnT.Clear();
						}
						if (QlRKDcOTlqkoeZOzErTqEEjbgYf.Count <= 0)
						{
							continue;
						}
						for (int k = 0; k < QlRKDcOTlqkoeZOzErTqEEjbgYf.Count; k++)
						{
							try
							{
								this.SuvTUfskVUQhJpEKOlCpYyTKrhq(QlRKDcOTlqkoeZOzErTqEEjbgYf[k]);
							}
							catch (Exception ex2)
							{
								Logger.LogError("An exception occurred in controller monitor Controller Connect Event callback.\n" + ex2);
							}
						}
						QlRKDcOTlqkoeZOzErTqEEjbgYf.Clear();
					}
					catch (Exception ex3)
					{
						Logger.LogError("An exception occurred during controller monitor update.\n" + ex3);
					}
				}
			}

			private void gWfWANbYXSDzocrzIKAyDZOrocr(int P_0, CsDrwxVLeEylzrgcYBKLbeWtfJb P_1, int P_2, bool P_3, string P_4)
			{
				int num = PIxmdAYLcWhIteruQBndYCOfEEb.PS4Input_GetDeviceClassForHandle(P_2);
				int cdutLQQMhPjGwflAJdLFJDGNnqx = P_1.cdutLQQMhPjGwflAJdLFJDGNnqx;
				ChangeType changeType = P_1.kcazFpqFBOzqBvoeQAfFdQlnYEH(P_3, P_2, num);
				if (changeType != 0)
				{
					if ((changeType & ChangeType.Disconnected) != 0 || (P_1.ROwiEnjcGJcjWhtTSzcbzuIyfLi && (changeType & ChangeType.IdentityChanged) != 0))
					{
						rjklRGjIQdioAJhgDXlhrOzqAnT.Add(new VtFcslVdTmOaEhoCXgsdDSHOuvW(P_0, cdutLQQMhPjGwflAJdLFJDGNnqx, P_1.TbljTJdnUyByvBmAcVlblnMstNJL));
					}
					if ((changeType & ChangeType.Connected) != 0 || (P_1.ROwiEnjcGJcjWhtTSzcbzuIyfLi && (changeType & ChangeType.IdentityChanged) != 0))
					{
						QlRKDcOTlqkoeZOzErTqEEjbgYf.Add(new kJUblSElzSdBwWbikNVHiOEDnsy(P_0, P_1.cdutLQQMhPjGwflAJdLFJDGNnqx, P_1.RzFpBgOUOOaOMRJfAolyIFFSEDu, P_1.TbljTJdnUyByvBmAcVlblnMstNJL));
					}
				}
			}

			[CompilerGenerated]
			private static CsDrwxVLeEylzrgcYBKLbeWtfJb XKFWLQwxvyuZhvVFOpYzEIQENLl()
			{
				return new CsDrwxVLeEylzrgcYBKLbeWtfJb(WLVuCRcKtsuzZbsXPesHPMemkkF.BaseControllerType.Gamepad);
			}

			[CompilerGenerated]
			private static CsDrwxVLeEylzrgcYBKLbeWtfJb XcuoTWNFxxdouUPmpRRTrlPQmTK()
			{
				return new CsDrwxVLeEylzrgcYBKLbeWtfJb(WLVuCRcKtsuzZbsXPesHPMemkkF.BaseControllerType.Special);
			}

			[CompilerGenerated]
			private static CsDrwxVLeEylzrgcYBKLbeWtfJb gvGKktYMgRGljFlTtOsYCScsNxR()
			{
				return new CsDrwxVLeEylzrgcYBKLbeWtfJb(WLVuCRcKtsuzZbsXPesHPMemkkF.BaseControllerType.Aim);
			}
		}

		private abstract class WLVuCRcKtsuzZbsXPesHPMemkkF : Joystick, yQeUbDoGgKyVpbADuAvpvGwKHgS, IPS4ControllerExtensionSourceSixAxisSensor, IPS4ControllerExtensionSourceVibrator, IPS4ControllerExtensionSourceLight, IPS4ControllerExtensionSource
		{
			[CustomObfuscation(rename = false)]
			public enum ControllerType
			{
				[CustomObfuscation(rename = false)]
				Unknown = 0,
				[CustomObfuscation(rename = false)]
				Gamepad = 1,
				[CustomObfuscation(rename = false)]
				Aim = 2,
				[CustomObfuscation(rename = false)]
				Guitar = 3,
				[CustomObfuscation(rename = false)]
				Drum = 4,
				[CustomObfuscation(rename = false)]
				DjTurntable = 5,
				[CustomObfuscation(rename = false)]
				DanceMat = 6,
				[CustomObfuscation(rename = false)]
				Navigation = 7,
				[CustomObfuscation(rename = false)]
				SteeringWheel = 8,
				[CustomObfuscation(rename = false)]
				Stick = 9,
				[CustomObfuscation(rename = false)]
				FlightStick = 10,
				[CustomObfuscation(rename = false)]
				Gun = 11
			}

			protected enum LkNNHeSIGJrZeoANhhNaziAdFRE
			{
				ybRArxXioIxcFklVOBLcaRjDXxo = 0,
				tApfGeGeaxcKZWXTKTghSBqInYT = 1,
				DDNtkePZXlCpQSXPlxYPxETDrdq = 2
			}

			[CustomObfuscation(rename = false)]
			public enum BaseControllerType
			{
				[CustomObfuscation(rename = false)]
				Gamepad = 0,
				[CustomObfuscation(rename = false)]
				Special = 1,
				[CustomObfuscation(rename = false)]
				Aim = 2
			}

			public class UNBlcGizJtLfiNUaAMtAxDiSDoT
			{
				public readonly int beRmxTPYgeEljczGnIuTQeGMXoR;

				public readonly int aumNItRblDdXZicbRkrPApteCjR;

				public readonly float haVNonecWBDHUBwTqBWQBcAKclsW;

				public readonly int DgKZIwUKWYpoRBbYIharycQNYrN;

				public readonly int juNAMYsmEWqlKpTnTfrVPDXHGmfH;

				public UNBlcGizJtLfiNUaAMtAxDiSDoT(int axisCount, int buttonCount, float dpadDeadzone, int vibrationMotorCount, int maxTouches)
				{
					beRmxTPYgeEljczGnIuTQeGMXoR = axisCount;
					aumNItRblDdXZicbRkrPApteCjR = buttonCount;
					haVNonecWBDHUBwTqBWQBcAKclsW = dpadDeadzone;
					DgKZIwUKWYpoRBbYIharycQNYrN = vibrationMotorCount;
					juNAMYsmEWqlKpTnTfrVPDXHGmfH = maxTouches;
				}
			}

			private static int SGsFFsjzPsNUJjbquTCehKhjun;

			protected readonly int IUWpTXMJPIJwDJdybAJNwpRpcYp;

			protected readonly int yMdFTTcBLUhUTzFfMHLCMbBiZFAH;

			protected readonly BaseControllerType tPnCLlwbEKLuSPWujYwkpWZvqEG;

			protected readonly UNBlcGizJtLfiNUaAMtAxDiSDoT yPJsmqLdVMpGaFweuksVFXMYxmQ;

			protected readonly int pqMExzQXMHxPhjePgBsVkpjmHaPc;

			protected readonly float[] MPKttYEugZrEJEzQGCTfTnimiIHG;

			private readonly LoggedInUser pSwrFBGrmJCCWSOQfqhbjfiwAFY;

			protected readonly ControllerType YApegNposatXaqxKKfTqnMxXGsJ;

			private readonly Func<int, bool> smmEaYVUDzBIwIAOUqKXLHWlhQP;

			private readonly Action<int, int, int> DdAgAaduABObCdbnixFePNCzOvH;

			private readonly Action<int, int, int, int> QDmSqSyndbdPDIDipBcqmwzLgSW;

			private readonly Action<int> YraCdlouZtIPXKIAkXeDKuvchtB;

			private Action<int, bool> zhZzUVGIyZaGfswdlgrjAeVgutE;

			private Action<int, bool> frIVTIKfEsWfHRZtrLMtLslRNNn;

			private Action<int, bool> LeRFXfTnTMvbJIpZuMRvXiQPCVr;

			private Action<int> GbJnrfSfDTFoGwWNTuorMePGujS;

			private Func<int, Vector3> cmROlUYDHeMexbSyJlRZELGbjAQ;

			private Func<int, Vector3> gxhADZBRYhuNhyshBpBfLZuetjW;

			private Func<int, Vector4> EGsesEgIDCdxzEohWtbORGqMrxQF;

			private static int KDWpgeFBcbDvwEugVnYpsqNUEgyv
			{
				get
				{
					int sGsFFsjzPsNUJjbquTCehKhjun = SGsFFsjzPsNUJjbquTCehKhjun;
					SGsFFsjzPsNUJjbquTCehKhjun++;
					return sGsFFsjzPsNUJjbquTCehKhjun;
				}
			}

			protected LoggedInUser PuPgRLaLdIGqlxvCsXgSCBVMOkAj
			{
				get
				{
					UnityTools.externalTools.PS4Input_GetUsersDetails(IUWpTXMJPIJwDJdybAJNwpRpcYp, pSwrFBGrmJCCWSOQfqhbjfiwAFY);
					return pSwrFBGrmJCCWSOQfqhbjfiwAFY;
				}
			}

			public ControllerType flYmSKXdxEbrkbApyjuUarnstyO => YApegNposatXaqxKKfTqnMxXGsJ;

			public int MjneFLkKUwoxlcJMhdolMzbLNxaE => IUWpTXMJPIJwDJdybAJNwpRpcYp;

			public int cdutLQQMhPjGwflAJdLFJDGNnqx => yMdFTTcBLUhUTzFfMHLCMbBiZFAH;

			public BaseControllerType TbljTJdnUyByvBmAcVlblnMstNJL => tPnCLlwbEKLuSPWujYwkpWZvqEG;

			private bool vTzTcNbKsTBSyHwEcAxbuVsvBTzG => smmEaYVUDzBIwIAOUqKXLHWlhQP(IUWpTXMJPIJwDJdybAJNwpRpcYp);

			public int vibrationMotorCount => yPJsmqLdVMpGaFweuksVFXMYxmQ.DgKZIwUKWYpoRBbYIharycQNYrN;

			public static WLVuCRcKtsuzZbsXPesHPMemkkF aWlEKFrTmxgBGgRqJDXRHeKwHYg(ControllerType P_0, int P_1, int P_2, int P_3)
			{
				return P_0 switch
				{
					ControllerType.Unknown => null, 
					ControllerType.Gamepad => new ThQFmWcWTFJTojpVpbiPKBNOZhk("Controller " + (P_2 + 1), P_2, P_2 + 1, P_3), 
					ControllerType.Aim => new vwsOOZwQyVHTBDSnqgDmKwKZprvt("PS VR Aim Controller " + (P_2 + 1), P_2, P_2 + 13, P_3), 
					_ => iMWprodYMlxbTxmJbcGuAHETefbI.aWlEKFrTmxgBGgRqJDXRHeKwHYg(P_1, P_2, P_3), 
				};
			}

			protected WLVuCRcKtsuzZbsXPesHPMemkkF(ControllerType type, BaseControllerType baseControllerType, string name, int playerId, int unityJoystickId, int handle, UNBlcGizJtLfiNUaAMtAxDiSDoT capabilities)
				: base(name, KDWpgeFBcbDvwEugVnYpsqNUEgyv, unityJoystickId, capabilities.beRmxTPYgeEljczGnIuTQeGMXoR, capabilities.aumNItRblDdXZicbRkrPApteCjR)
			{
				if (capabilities == null)
				{
					throw new ArgumentNullException("capabilities");
				}
				YApegNposatXaqxKKfTqnMxXGsJ = type;
				tPnCLlwbEKLuSPWujYwkpWZvqEG = baseControllerType;
				IUWpTXMJPIJwDJdybAJNwpRpcYp = playerId;
				pqMExzQXMHxPhjePgBsVkpjmHaPc = unityJoystickId - 1;
				yPJsmqLdVMpGaFweuksVFXMYxmQ = capabilities;
				yMdFTTcBLUhUTzFfMHLCMbBiZFAH = handle;
				pSwrFBGrmJCCWSOQfqhbjfiwAFY = new LoggedInUser();
				_customName = name;
				MPKttYEugZrEJEzQGCTfTnimiIHG = new float[capabilities.DgKZIwUKWYpoRBbYIharycQNYrN];
				base.supportsVibration = capabilities.DgKZIwUKWYpoRBbYIharycQNYrN > 0;
				switch (tPnCLlwbEKLuSPWujYwkpWZvqEG)
				{
				case BaseControllerType.Gamepad:
					smmEaYVUDzBIwIAOUqKXLHWlhQP = UnityTools.externalTools.PS4Input_PadIsConnected;
					DdAgAaduABObCdbnixFePNCzOvH = UnityTools.externalTools.PS4Input_PadSetVibration;
					QDmSqSyndbdPDIDipBcqmwzLgSW = UnityTools.externalTools.PS4Input_PadSetLightBar;
					YraCdlouZtIPXKIAkXeDKuvchtB = UnityTools.externalTools.PS4Input_PadResetLightBar;
					zhZzUVGIyZaGfswdlgrjAeVgutE = UnityTools.externalTools.PS4Input_PadSetMotionSensorState;
					frIVTIKfEsWfHRZtrLMtLslRNNn = UnityTools.externalTools.PS4Input_PadSetTiltCorrectionState;
					LeRFXfTnTMvbJIpZuMRvXiQPCVr = UnityTools.externalTools.PS4Input_PadSetAngularVelocityDeadbandState;
					GbJnrfSfDTFoGwWNTuorMePGujS = UnityTools.externalTools.PS4Input_PadResetOrientation;
					cmROlUYDHeMexbSyJlRZELGbjAQ = UnityTools.externalTools.PS4Input_GetLastAcceleration;
					gxhADZBRYhuNhyshBpBfLZuetjW = UnityTools.externalTools.PS4Input_GetLastGyro;
					EGsesEgIDCdxzEohWtbORGqMrxQF = UnityTools.externalTools.PS4Input_GetLastOrientation;
					break;
				case BaseControllerType.Special:
					smmEaYVUDzBIwIAOUqKXLHWlhQP = UnityTools.externalTools.PS4Input_SpecialIsConnected;
					DdAgAaduABObCdbnixFePNCzOvH = UnityTools.externalTools.PS4Input_SpecialSetVibration;
					QDmSqSyndbdPDIDipBcqmwzLgSW = UnityTools.externalTools.PS4Input_SpecialSetLightSphere;
					YraCdlouZtIPXKIAkXeDKuvchtB = UnityTools.externalTools.PS4Input_SpecialResetLightSphere;
					zhZzUVGIyZaGfswdlgrjAeVgutE = UnityTools.externalTools.PS4Input_SpecialSetMotionSensorState;
					frIVTIKfEsWfHRZtrLMtLslRNNn = UnityTools.externalTools.PS4Input_SpecialSetTiltCorrectionState;
					LeRFXfTnTMvbJIpZuMRvXiQPCVr = UnityTools.externalTools.PS4Input_SpecialSetAngularVelocityDeadbandState;
					GbJnrfSfDTFoGwWNTuorMePGujS = UnityTools.externalTools.PS4Input_SpecialResetOrientation;
					cmROlUYDHeMexbSyJlRZELGbjAQ = UnityTools.externalTools.PS4Input_SpecialGetLastAcceleration;
					gxhADZBRYhuNhyshBpBfLZuetjW = UnityTools.externalTools.PS4Input_SpecialGetLastGyro;
					EGsesEgIDCdxzEohWtbORGqMrxQF = UnityTools.externalTools.PS4Input_SpecialGetLastOrientation;
					break;
				case BaseControllerType.Aim:
					smmEaYVUDzBIwIAOUqKXLHWlhQP = UnityTools.externalTools.PS4Input_AimIsConnected;
					DdAgAaduABObCdbnixFePNCzOvH = UnityTools.externalTools.PS4Input_AimSetVibration;
					QDmSqSyndbdPDIDipBcqmwzLgSW = UnityTools.externalTools.PS4Input_AimSetLightSphere;
					YraCdlouZtIPXKIAkXeDKuvchtB = UnityTools.externalTools.PS4Input_AimResetLightSphere;
					zhZzUVGIyZaGfswdlgrjAeVgutE = UnityTools.externalTools.PS4Input_AimSetMotionSensorState;
					frIVTIKfEsWfHRZtrLMtLslRNNn = UnityTools.externalTools.PS4Input_AimSetTiltCorrectionState;
					LeRFXfTnTMvbJIpZuMRvXiQPCVr = UnityTools.externalTools.PS4Input_AimSetAngularVelocityDeadbandState;
					GbJnrfSfDTFoGwWNTuorMePGujS = UnityTools.externalTools.PS4Input_AimResetOrientation;
					cmROlUYDHeMexbSyJlRZELGbjAQ = UnityTools.externalTools.PS4Input_GetLastAcceleration;
					gxhADZBRYhuNhyshBpBfLZuetjW = UnityTools.externalTools.PS4Input_GetLastGyro;
					EGsesEgIDCdxzEohWtbORGqMrxQF = UnityTools.externalTools.PS4Input_GetLastOrientation;
					break;
				default:
					throw new NotImplementedException();
				}
			}

			public virtual void mtiNfGzpXHszOwiOIAVYQuMZclV()
			{
				UbbXxIvnKSHiQKQTSsjWdyNPIVw();
			}

			public int yomSuiYlAekYRScsvSXlHqnqqGV()
			{
				return yMdFTTcBLUhUTzFfMHLCMbBiZFAH;
			}

			int yQeUbDoGgKyVpbADuAvpvGwKHgS.yomSuiYlAekYRScsvSXlHqnqqGV()
			{
				//ILSpy generated this explicit interface implementation from .override directive in yomSuiYlAekYRScsvSXlHqnqqGV
				return this.yomSuiYlAekYRScsvSXlHqnqqGV();
			}

			public int tOloaSFjAPYoCKyAbcIDRrnLVGL()
			{
				return PuPgRLaLdIGqlxvCsXgSCBVMOkAj.userId;
			}

			int yQeUbDoGgKyVpbADuAvpvGwKHgS.tOloaSFjAPYoCKyAbcIDRrnLVGL()
			{
				//ILSpy generated this explicit interface implementation from .override directive in tOloaSFjAPYoCKyAbcIDRrnLVGL
				return this.tOloaSFjAPYoCKyAbcIDRrnLVGL();
			}

			public int dHEYeXLQjKRNiMLXyKihGHCFCby()
			{
				return PuPgRLaLdIGqlxvCsXgSCBVMOkAj.status;
			}

			int yQeUbDoGgKyVpbADuAvpvGwKHgS.dHEYeXLQjKRNiMLXyKihGHCFCby()
			{
				//ILSpy generated this explicit interface implementation from .override directive in dHEYeXLQjKRNiMLXyKihGHCFCby
				return this.dHEYeXLQjKRNiMLXyKihGHCFCby();
			}

			public bool lFnzljIEhdApvAcmccwveekplMfq()
			{
				return PuPgRLaLdIGqlxvCsXgSCBVMOkAj.primaryUser;
			}

			bool yQeUbDoGgKyVpbADuAvpvGwKHgS.lFnzljIEhdApvAcmccwveekplMfq()
			{
				//ILSpy generated this explicit interface implementation from .override directive in lFnzljIEhdApvAcmccwveekplMfq
				return this.lFnzljIEhdApvAcmccwveekplMfq();
			}

			public Color jNWfnqyGxYyqWADuUfjvcZSkSHAL()
			{
				LoggedInUser user = PuPgRLaLdIGqlxvCsXgSCBVMOkAj;
				return user.color switch
				{
					0 => Color.blue, 
					1 => Color.red, 
					2 => Color.green, 
					3 => Color.magenta, 
					_ => Color.black, 
				};
			}

			Color yQeUbDoGgKyVpbADuAvpvGwKHgS.jNWfnqyGxYyqWADuUfjvcZSkSHAL()
			{
				//ILSpy generated this explicit interface implementation from .override directive in jNWfnqyGxYyqWADuUfjvcZSkSHAL
				return this.jNWfnqyGxYyqWADuUfjvcZSkSHAL();
			}

			public int ChoJFjdYiTwnDiQerYoXwZhUhWV()
			{
				return PuPgRLaLdIGqlxvCsXgSCBVMOkAj.color;
			}

			int yQeUbDoGgKyVpbADuAvpvGwKHgS.ChoJFjdYiTwnDiQerYoXwZhUhWV()
			{
				//ILSpy generated this explicit interface implementation from .override directive in ChoJFjdYiTwnDiQerYoXwZhUhWV
				return this.ChoJFjdYiTwnDiQerYoXwZhUhWV();
			}

			public string htWimcOqCZccmSkxtoEYhrwLbMI()
			{
				return PuPgRLaLdIGqlxvCsXgSCBVMOkAj.userName;
			}

			string yQeUbDoGgKyVpbADuAvpvGwKHgS.htWimcOqCZccmSkxtoEYhrwLbMI()
			{
				//ILSpy generated this explicit interface implementation from .override directive in htWimcOqCZccmSkxtoEYhrwLbMI
				return this.htWimcOqCZccmSkxtoEYhrwLbMI();
			}

			public void StopVibration()
			{
				Array.Clear(MPKttYEugZrEJEzQGCTfTnimiIHG, 0, MPKttYEugZrEJEzQGCTfTnimiIHG.Length);
				wrcXNedwpkUVZbiRSzkXFQmKGxSg();
			}

			public void SetVibration(int motorIndex, float value)
			{
				if ((uint)motorIndex <= (uint)yPJsmqLdVMpGaFweuksVFXMYxmQ.DgKZIwUKWYpoRBbYIharycQNYrN)
				{
					MPKttYEugZrEJEzQGCTfTnimiIHG[motorIndex] = value;
					wrcXNedwpkUVZbiRSzkXFQmKGxSg();
				}
			}

			public float GetVibration(int motorIndex)
			{
				if ((uint)motorIndex > (uint)yPJsmqLdVMpGaFweuksVFXMYxmQ.DgKZIwUKWYpoRBbYIharycQNYrN)
				{
					return 0f;
				}
				return MPKttYEugZrEJEzQGCTfTnimiIHG[motorIndex];
			}

			public void SetMotionSensorState(bool enabled)
			{
				zhZzUVGIyZaGfswdlgrjAeVgutE(IUWpTXMJPIJwDJdybAJNwpRpcYp, enabled);
			}

			public void SetTiltCorrectionState(bool enabled)
			{
				frIVTIKfEsWfHRZtrLMtLslRNNn(IUWpTXMJPIJwDJdybAJNwpRpcYp, enabled);
			}

			public void SetAngularVelocityDeadbandState(bool enabled)
			{
				LeRFXfTnTMvbJIpZuMRvXiQPCVr(IUWpTXMJPIJwDJdybAJNwpRpcYp, enabled);
			}

			public void ResetOrientation()
			{
				GbJnrfSfDTFoGwWNTuorMePGujS(IUWpTXMJPIJwDJdybAJNwpRpcYp);
			}

			public Vector3 GetLastAcceleration()
			{
				if (!vTzTcNbKsTBSyHwEcAxbuVsvBTzG)
				{
					return Vector3.zero;
				}
				Vector3 result = cmROlUYDHeMexbSyJlRZELGbjAQ(IUWpTXMJPIJwDJdybAJNwpRpcYp);
				CLuukNAEFqxQWqhizEBDQusnqWr(ref result);
				return result;
			}

			public Vector3 GetLastAccelerationRaw()
			{
				if (!vTzTcNbKsTBSyHwEcAxbuVsvBTzG)
				{
					return Vector3.zero;
				}
				return cmROlUYDHeMexbSyJlRZELGbjAQ(IUWpTXMJPIJwDJdybAJNwpRpcYp);
			}

			public Vector3 GetLastGyro()
			{
				if (!vTzTcNbKsTBSyHwEcAxbuVsvBTzG)
				{
					return Vector3.zero;
				}
				Vector3 result = gxhADZBRYhuNhyshBpBfLZuetjW(IUWpTXMJPIJwDJdybAJNwpRpcYp);
				KZgkGkZwHwNjQThWMeHENsQzDft(ref result);
				return result;
			}

			public Vector3 GetLastGyroRaw()
			{
				if (!vTzTcNbKsTBSyHwEcAxbuVsvBTzG)
				{
					return Vector3.zero;
				}
				return gxhADZBRYhuNhyshBpBfLZuetjW(IUWpTXMJPIJwDJdybAJNwpRpcYp);
			}

			public Quaternion GetLastOrientation()
			{
				if (!vTzTcNbKsTBSyHwEcAxbuVsvBTzG)
				{
					return Quaternion.identity;
				}
				Vector4 vector = EGsesEgIDCdxzEohWtbORGqMrxQF(IUWpTXMJPIJwDJdybAJNwpRpcYp);
				return new Quaternion(vector.x * -1f, vector.y, vector.z, vector.w);
			}

			public Quaternion GetLastOrientationRaw()
			{
				if (!vTzTcNbKsTBSyHwEcAxbuVsvBTzG)
				{
					return Quaternion.identity;
				}
				Vector4 vector = EGsesEgIDCdxzEohWtbORGqMrxQF(IUWpTXMJPIJwDJdybAJNwpRpcYp);
				return new Quaternion(vector.x, vector.y, vector.z, vector.w);
			}

			public void SetLightColor(int red, int green, int blue)
			{
				QDmSqSyndbdPDIDipBcqmwzLgSW(IUWpTXMJPIJwDJdybAJNwpRpcYp, red, green, blue);
			}

			public void ResetLight()
			{
				YraCdlouZtIPXKIAkXeDKuvchtB(IUWpTXMJPIJwDJdybAJNwpRpcYp);
			}

			protected virtual void UbbXxIvnKSHiQKQTSsjWdyNPIVw()
			{
				int joystickId = pqMExzQXMHxPhjePgBsVkpjmHaPc + 1;
				IList<Button> buttons = base.Buttons;
				buttons[0].value = UnityInputHelper.GetJoystickButtonValueByJoystickId(joystickId, 0);
				buttons[1].value = UnityInputHelper.GetJoystickButtonValueByJoystickId(joystickId, 1);
				buttons[2].value = UnityInputHelper.GetJoystickButtonValueByJoystickId(joystickId, 2);
				buttons[3].value = UnityInputHelper.GetJoystickButtonValueByJoystickId(joystickId, 3);
				buttons[4].value = UnityInputHelper.GetJoystickButtonValueByJoystickId(joystickId, 4);
				buttons[5].value = UnityInputHelper.GetJoystickButtonValueByJoystickId(joystickId, 5);
				buttons[6].value = UnityInputHelper.GetJoystickButtonValueByJoystickId(joystickId, 6);
				buttons[7].value = UnityInputHelper.GetJoystickButtonValueByJoystickId(joystickId, 7);
				buttons[8].value = UnityInputHelper.GetJoystickButtonValueByJoystickId(joystickId, 8);
				buttons[9].value = UnityInputHelper.GetJoystickButtonValueByJoystickId(joystickId, 9);
				float joystickAxisValueByJoystickId = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 5);
				float joystickAxisValueByJoystickId2 = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 6);
				buttons[10].value = joystickAxisValueByJoystickId2 > yPJsmqLdVMpGaFweuksVFXMYxmQ.haVNonecWBDHUBwTqBWQBcAKclsW;
				buttons[11].value = joystickAxisValueByJoystickId > yPJsmqLdVMpGaFweuksVFXMYxmQ.haVNonecWBDHUBwTqBWQBcAKclsW;
				buttons[12].value = joystickAxisValueByJoystickId2 < 0f - yPJsmqLdVMpGaFweuksVFXMYxmQ.haVNonecWBDHUBwTqBWQBcAKclsW;
				buttons[13].value = joystickAxisValueByJoystickId < 0f - yPJsmqLdVMpGaFweuksVFXMYxmQ.haVNonecWBDHUBwTqBWQBcAKclsW;
				IList<Axis> axes = base.Axes;
				axes[0].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 0);
				axes[1].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 1);
				axes[2].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 3);
				axes[3].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 4);
				axes[4].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 7);
				axes[5].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 2);
			}

			protected void wrcXNedwpkUVZbiRSzkXFQmKGxSg()
			{
				if (yPJsmqLdVMpGaFweuksVFXMYxmQ.DgKZIwUKWYpoRBbYIharycQNYrN != 0)
				{
					DdAgAaduABObCdbnixFePNCzOvH(IUWpTXMJPIJwDJdybAJNwpRpcYp, sGiGGJgDdHRjDDOmaVZKPTJadnGK(MPKttYEugZrEJEzQGCTfTnimiIHG[0]), sGiGGJgDdHRjDDOmaVZKPTJadnGK(MPKttYEugZrEJEzQGCTfTnimiIHG[1]));
				}
			}

			public static int sGiGGJgDdHRjDDOmaVZKPTJadnGK(float P_0)
			{
				if (P_0 <= 0f)
				{
					return 0;
				}
				if (P_0 >= 1f)
				{
					return 255;
				}
				return (int)(P_0 * 255f);
			}

			public static void CLuukNAEFqxQWqhizEBDQusnqWr(ref Vector3 P_0)
			{
				P_0.x *= -1f;
				P_0.y *= -1f;
			}

			public static void KZgkGkZwHwNjQThWMeHENsQzDft(ref Vector3 P_0)
			{
				P_0.x *= -1f;
				P_0.y *= -1f;
			}

			public static bool PNADVnBZSzRqIoIyUPIJiSdpvSpn(int P_0, out ControllerType P_1)
			{
				string text = UnityTools.externalTools.PS4Input_GetDeviceClassString(P_0);
				if (string.IsNullOrEmpty(text))
				{
					P_1 = ControllerType.Unknown;
					return false;
				}
				if (text.Equals("Standard", StringComparison.OrdinalIgnoreCase))
				{
					P_1 = ControllerType.Gamepad;
					return true;
				}
				if (text.Equals("FlightStick", StringComparison.OrdinalIgnoreCase) || text.Equals("hotas", StringComparison.OrdinalIgnoreCase))
				{
					P_1 = ControllerType.FlightStick;
					return true;
				}
				if (text.Equals("Stick", StringComparison.OrdinalIgnoreCase) || text.Equals("hotas", StringComparison.OrdinalIgnoreCase))
				{
					P_1 = ControllerType.FlightStick;
					return true;
				}
				if (text.Equals("SteeringWheel", StringComparison.OrdinalIgnoreCase))
				{
					P_1 = ControllerType.SteeringWheel;
					return true;
				}
				if (text.Equals("Guitar", StringComparison.OrdinalIgnoreCase))
				{
					P_1 = ControllerType.Guitar;
					return true;
				}
				if (text.Equals("Drum", StringComparison.OrdinalIgnoreCase))
				{
					P_1 = ControllerType.Drum;
					return true;
				}
				if (text.Equals("Gun", StringComparison.OrdinalIgnoreCase))
				{
					P_1 = ControllerType.Gun;
					return true;
				}
				if (text.Equals("DjTurntable", StringComparison.OrdinalIgnoreCase))
				{
					P_1 = ControllerType.DjTurntable;
					return true;
				}
				if (text.Equals("Dancemat", StringComparison.OrdinalIgnoreCase))
				{
					P_1 = ControllerType.DanceMat;
					return true;
				}
				if (text.Equals("Navigation", StringComparison.OrdinalIgnoreCase))
				{
					P_1 = ControllerType.Navigation;
					return true;
				}
				P_1 = ControllerType.Unknown;
				return false;
			}
		}

		private sealed class ThQFmWcWTFJTojpVpbiPKBNOZhk : WLVuCRcKtsuzZbsXPesHPMemkkF, yQeUbDoGgKyVpbADuAvpvGwKHgS, IPS4ControllerExtensionSourceSixAxisSensor, IPS4ControllerExtensionSourceVibrator, IPS4ControllerExtensionSourceLight, IPS4ControllerExtensionSource, IPS4ControllerExtensionSourceTouchPad, IPS4GamepadExtensionSource
		{
			private const int YlTbBOggPtVFjPOpUYhcWgDPoyVS = 6;

			private const int MIYoAXxJmUicNKAfsvlLFppMumFk = 14;

			private const float OfKeraHEVJkjChYbckWxptAmAwtX = 0.05f;

			private const int MPxqxUdgsOlegUoFNQGlmivakAf = 2;

			private const int eSPXvOTZUIiVbKhODMsyPjfdEhQ = 2;

			private int wMRvcjTBfUldSOzGdhRqyYCDLZy;

			private int BjqfYyDZAiRtDUOnIifpDiOhbOkq;

			private Vector2 jDIUgDEPiVGBMfszEqdTAmATZFWe;

			private int CfKSNVFIgogSLdpPswWhzcyMZWf;

			private Vector2 nGWnPhIyJQdtWoMBwZtQliqVGgZ;

			private LkNNHeSIGJrZeoANhhNaziAdFRE wPQbTwflmzskqWbDohUeoJNqjonE;

			private int StLrvioFHJQGVOGMEPdvNxorWbA;

			private int COBjIyxdYdeRyTQpXtiXDgOorQR;

			private int KJVJmxgrcbIyLtoATHbTDfGbFxC;

			private int bJAiFuDWApGfLJfKTXsUYPouMfe;

			private float bYimBNMlGuXwDPUAVHUrYOECLVt;

			public int maxTouches => yPJsmqLdVMpGaFweuksVFXMYxmQ.juNAMYsmEWqlKpTnTfrVPDXHGmfH;

			public ThQFmWcWTFJTojpVpbiPKBNOZhk(string name, int playerId, int unityJoystickId, int handle)
				: base(ControllerType.Gamepad, BaseControllerType.Gamepad, name, playerId, unityJoystickId, handle, new UNBlcGizJtLfiNUaAMtAxDiSDoT(6, 14, 0.05f, 2, 2))
			{
				VRXOHRqlwbKPGDdjQDqqixMHZHq();
				base.extension = new PS4GamepadExtension(this);
			}

			public int GetConnectionType()
			{
				return (int)wPQbTwflmzskqWbDohUeoJNqjonE;
			}

			public int GetAnalogDeadZoneLeft()
			{
				return KJVJmxgrcbIyLtoATHbTDfGbFxC;
			}

			public int GetAnalogDeadZoneRight()
			{
				return bJAiFuDWApGfLJfKTXsUYPouMfe;
			}

			public float GetTouchPixelDensity()
			{
				return bYimBNMlGuXwDPUAVHUrYOECLVt;
			}

			public int GetTouchpadResolutionX()
			{
				return StLrvioFHJQGVOGMEPdvNxorWbA;
			}

			public int GetTouchpadResolutionY()
			{
				return COBjIyxdYdeRyTQpXtiXDgOorQR;
			}

			public int GetTouchCount()
			{
				return wMRvcjTBfUldSOzGdhRqyYCDLZy;
			}

			public int GetTouchId(int index)
			{
				if (index < 0 || index >= yPJsmqLdVMpGaFweuksVFXMYxmQ.juNAMYsmEWqlKpTnTfrVPDXHGmfH)
				{
					return -1;
				}
				return index switch
				{
					0 => BjqfYyDZAiRtDUOnIifpDiOhbOkq, 
					1 => CfKSNVFIgogSLdpPswWhzcyMZWf, 
					_ => -1, 
				};
			}

			public bool GetTouchPositionAbsByIndex(int index, out Vector2 position)
			{
				if (index < 0 || index >= yPJsmqLdVMpGaFweuksVFXMYxmQ.juNAMYsmEWqlKpTnTfrVPDXHGmfH || !IsTouchingByIndex(index))
				{
					position = default(Vector2);
					return false;
				}
				switch (index)
				{
				case 0:
					position = jDIUgDEPiVGBMfszEqdTAmATZFWe;
					break;
				case 1:
					position = nGWnPhIyJQdtWoMBwZtQliqVGgZ;
					break;
				default:
					position = default(Vector2);
					return false;
				}
				return true;
			}

			public bool GetTouchPositionAbsByTouchId(int touchId, out Vector2 position)
			{
				int num = ytmFgjAOSDCTfEFyVRdhSGZknOfW(touchId);
				if (num < 0)
				{
					position = default(Vector2);
					return false;
				}
				return GetTouchPositionAbsByIndex(num, out position);
			}

			public bool GetTouchPositionByIndex(int index, out Vector2 position)
			{
				if (index < 0 || index >= yPJsmqLdVMpGaFweuksVFXMYxmQ.juNAMYsmEWqlKpTnTfrVPDXHGmfH || !IsTouchingByIndex(index))
				{
					position = default(Vector2);
					return false;
				}
				switch (index)
				{
				case 0:
					position = new Vector2(jDIUgDEPiVGBMfszEqdTAmATZFWe.x, jDIUgDEPiVGBMfszEqdTAmATZFWe.y);
					break;
				case 1:
					position = new Vector2(nGWnPhIyJQdtWoMBwZtQliqVGgZ.x, nGWnPhIyJQdtWoMBwZtQliqVGgZ.y);
					break;
				default:
					position = default(Vector2);
					return false;
				}
				position.x /= StLrvioFHJQGVOGMEPdvNxorWbA;
				position.y /= COBjIyxdYdeRyTQpXtiXDgOorQR;
				return true;
			}

			public bool GetTouchPositionByTouchId(int touchId, out Vector2 position)
			{
				int num = ytmFgjAOSDCTfEFyVRdhSGZknOfW(touchId);
				if (num < 0)
				{
					position = default(Vector2);
					return false;
				}
				return GetTouchPositionByIndex(num, out position);
			}

			public bool IsTouchingByIndex(int index)
			{
				if (index < 0 || index >= yPJsmqLdVMpGaFweuksVFXMYxmQ.juNAMYsmEWqlKpTnTfrVPDXHGmfH)
				{
					return false;
				}
				return index < wMRvcjTBfUldSOzGdhRqyYCDLZy;
			}

			public bool IsTouchingByTouchId(int touchId)
			{
				if (touchId < 0)
				{
					return false;
				}
				int num = ytmFgjAOSDCTfEFyVRdhSGZknOfW(touchId);
				return num >= 0;
			}

			protected override void UbbXxIvnKSHiQKQTSsjWdyNPIVw()
			{
				base.UbbXxIvnKSHiQKQTSsjWdyNPIVw();
				UnityTools.externalTools.PS4Input_GetLastTouchData(IUWpTXMJPIJwDJdybAJNwpRpcYp, out wMRvcjTBfUldSOzGdhRqyYCDLZy, out var touch0x, out var touch0y, out BjqfYyDZAiRtDUOnIifpDiOhbOkq, out var touch1x, out var touch1y, out CfKSNVFIgogSLdpPswWhzcyMZWf);
				jDIUgDEPiVGBMfszEqdTAmATZFWe.x = touch0x;
				jDIUgDEPiVGBMfszEqdTAmATZFWe.y = COBjIyxdYdeRyTQpXtiXDgOorQR - touch0y;
				nGWnPhIyJQdtWoMBwZtQliqVGgZ.x = touch1x;
				nGWnPhIyJQdtWoMBwZtQliqVGgZ.y = COBjIyxdYdeRyTQpXtiXDgOorQR - touch1y;
			}

			private void VRXOHRqlwbKPGDdjQDqqixMHZHq()
			{
				IExternalTools externalTools = UnityTools.externalTools;
				externalTools.PS4Input_GetPadControllerInformation(IUWpTXMJPIJwDJdybAJNwpRpcYp, out bYimBNMlGuXwDPUAVHUrYOECLVt, out StLrvioFHJQGVOGMEPdvNxorWbA, out COBjIyxdYdeRyTQpXtiXDgOorQR, out KJVJmxgrcbIyLtoATHbTDfGbFxC, out bJAiFuDWApGfLJfKTXsUYPouMfe, out var connectionType);
				wPQbTwflmzskqWbDohUeoJNqjonE = (LkNNHeSIGJrZeoANhhNaziAdFRE)connectionType;
				externalTools.PS4Input_PadResetOrientation(IUWpTXMJPIJwDJdybAJNwpRpcYp);
			}

			private int ytmFgjAOSDCTfEFyVRdhSGZknOfW(int P_0)
			{
				if (P_0 < 0)
				{
					return -1;
				}
				if (wMRvcjTBfUldSOzGdhRqyYCDLZy > 0 && BjqfYyDZAiRtDUOnIifpDiOhbOkq == P_0)
				{
					return 0;
				}
				if (wMRvcjTBfUldSOzGdhRqyYCDLZy > 1 && CfKSNVFIgogSLdpPswWhzcyMZWf == P_0)
				{
					return 1;
				}
				return -1;
			}
		}

		private sealed class vwsOOZwQyVHTBDSnqgDmKwKZprvt : WLVuCRcKtsuzZbsXPesHPMemkkF, yQeUbDoGgKyVpbADuAvpvGwKHgS, IPS4ControllerExtensionSourceSixAxisSensor, IPS4ControllerExtensionSourceVibrator, IPS4ControllerExtensionSourceLight, IPS4ControllerExtensionSource, IPS4AimExtensionSource
		{
			private const int YlTbBOggPtVFjPOpUYhcWgDPoyVS = 6;

			private const int MIYoAXxJmUicNKAfsvlLFppMumFk = 14;

			private const float OfKeraHEVJkjChYbckWxptAmAwtX = 0.05f;

			private const int MPxqxUdgsOlegUoFNQGlmivakAf = 2;

			private const int eSPXvOTZUIiVbKhODMsyPjfdEhQ = 2;

			private int wMRvcjTBfUldSOzGdhRqyYCDLZy;

			private int BjqfYyDZAiRtDUOnIifpDiOhbOkq;

			private Vector2 jDIUgDEPiVGBMfszEqdTAmATZFWe;

			private int CfKSNVFIgogSLdpPswWhzcyMZWf;

			private Vector2 nGWnPhIyJQdtWoMBwZtQliqVGgZ;

			private LkNNHeSIGJrZeoANhhNaziAdFRE wPQbTwflmzskqWbDohUeoJNqjonE;

			private int StLrvioFHJQGVOGMEPdvNxorWbA;

			private int COBjIyxdYdeRyTQpXtiXDgOorQR;

			private int KJVJmxgrcbIyLtoATHbTDfGbFxC;

			private int bJAiFuDWApGfLJfKTXsUYPouMfe;

			private float bYimBNMlGuXwDPUAVHUrYOECLVt;

			public vwsOOZwQyVHTBDSnqgDmKwKZprvt(string name, int playerId, int unityJoystickId, int handle)
				: base(ControllerType.Aim, BaseControllerType.Aim, name, playerId, unityJoystickId, handle, new UNBlcGizJtLfiNUaAMtAxDiSDoT(6, 14, 0.05f, 2, 2))
			{
				base.extension = new PS4AimExtension(this);
			}
		}

		private abstract class iMWprodYMlxbTxmJbcGuAHETefbI : WLVuCRcKtsuzZbsXPesHPMemkkF
		{
			protected iMWprodYMlxbTxmJbcGuAHETefbI(ControllerType controllerType, string name, int playerId, int unityJoystickId, int handle, UNBlcGizJtLfiNUaAMtAxDiSDoT capabilities)
				: base(controllerType, BaseControllerType.Special, name, playerId, unityJoystickId, handle, capabilities)
			{
			}

			public static iMWprodYMlxbTxmJbcGuAHETefbI aWlEKFrTmxgBGgRqJDXRHeKwHYg(int P_0, int P_1, int P_2)
			{
				if (!WLVuCRcKtsuzZbsXPesHPMemkkF.PNADVnBZSzRqIoIyUPIJiSdpvSpn(P_0, out var controllerType))
				{
					return null;
				}
				return aWlEKFrTmxgBGgRqJDXRHeKwHYg(controllerType, P_1, P_2);
			}

			public static iMWprodYMlxbTxmJbcGuAHETefbI aWlEKFrTmxgBGgRqJDXRHeKwHYg(ControllerType P_0, int P_1, int P_2)
			{
				int unityJoystickId = P_1 + 13;
				switch (P_0)
				{
				case ControllerType.Unknown:
				case ControllerType.Gamepad:
				case ControllerType.Aim:
					return null;
				case ControllerType.Drum:
					return new JcEqrSsDgugeoKOHYjCGtSwhfPLy("Drums " + (P_1 + 1), P_1, unityJoystickId, P_2);
				case ControllerType.FlightStick:
					return new XlnfQPiQycZoIxXCRdlOAhbZuamQ("Flight Stick " + (P_1 + 1), P_1, unityJoystickId, P_2);
				case ControllerType.Guitar:
					return new LLlQFjEQyAmdDyOhmbERYcdCKoQ("Guitar " + (P_1 + 1), P_1, unityJoystickId, P_2);
				case ControllerType.SteeringWheel:
					return new gGwDMuCuivGtiEjSIbHrDzFIAlMq("Steering Wheel " + (P_1 + 1), P_1, unityJoystickId, P_2);
				case ControllerType.DjTurntable:
				case ControllerType.DanceMat:
				case ControllerType.Navigation:
				case ControllerType.Stick:
				case ControllerType.Gun:
					return null;
				default:
					throw new NotImplementedException();
				}
			}
		}

		private sealed class gGwDMuCuivGtiEjSIbHrDzFIAlMq : iMWprodYMlxbTxmJbcGuAHETefbI
		{
			private const int YlTbBOggPtVFjPOpUYhcWgDPoyVS = 13;

			private const int MIYoAXxJmUicNKAfsvlLFppMumFk = 14;

			private const float OfKeraHEVJkjChYbckWxptAmAwtX = 0.05f;

			private const int MPxqxUdgsOlegUoFNQGlmivakAf = 2;

			private const int eSPXvOTZUIiVbKhODMsyPjfdEhQ = 0;

			public gGwDMuCuivGtiEjSIbHrDzFIAlMq(string name, int playerId, int unityJoystickId, int handle)
				: base(ControllerType.SteeringWheel, name, playerId, unityJoystickId, handle, new UNBlcGizJtLfiNUaAMtAxDiSDoT(13, 14, 0.05f, 2, 0))
			{
				base.extension = new PS4ControllerExtension(this);
			}

			protected override void UbbXxIvnKSHiQKQTSsjWdyNPIVw()
			{
				base.UbbXxIvnKSHiQKQTSsjWdyNPIVw();
				int joystickId = pqMExzQXMHxPhjePgBsVkpjmHaPc + 1;
				IList<Axis> axes = base.Axes;
				axes[6].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 10);
				axes[7].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 11);
				axes[8].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 12);
				axes[9].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 13);
				axes[10].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 14);
				axes[11].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 15);
				axes[12].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 16);
			}
		}

		private sealed class LLlQFjEQyAmdDyOhmbERYcdCKoQ : iMWprodYMlxbTxmJbcGuAHETefbI
		{
			private const int YlTbBOggPtVFjPOpUYhcWgDPoyVS = 11;

			private const int MIYoAXxJmUicNKAfsvlLFppMumFk = 14;

			private const float OfKeraHEVJkjChYbckWxptAmAwtX = 0.05f;

			private const int MPxqxUdgsOlegUoFNQGlmivakAf = 2;

			private const int eSPXvOTZUIiVbKhODMsyPjfdEhQ = 0;

			public LLlQFjEQyAmdDyOhmbERYcdCKoQ(string name, int playerId, int unityJoystickId, int handle)
				: base(ControllerType.Guitar, name, playerId, unityJoystickId, handle, new UNBlcGizJtLfiNUaAMtAxDiSDoT(11, 14, 0.05f, 2, 0))
			{
				base.extension = new PS4ControllerExtension(this);
			}

			protected override void UbbXxIvnKSHiQKQTSsjWdyNPIVw()
			{
				base.UbbXxIvnKSHiQKQTSsjWdyNPIVw();
				int joystickId = pqMExzQXMHxPhjePgBsVkpjmHaPc + 1;
				IList<Axis> axes = base.Axes;
				axes[6].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 10);
				axes[7].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 11);
				axes[8].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 12);
				axes[9].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 13);
				axes[10].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 14);
			}
		}

		private sealed class JcEqrSsDgugeoKOHYjCGtSwhfPLy : iMWprodYMlxbTxmJbcGuAHETefbI
		{
			private const int YlTbBOggPtVFjPOpUYhcWgDPoyVS = 13;

			private const int MIYoAXxJmUicNKAfsvlLFppMumFk = 14;

			private const float OfKeraHEVJkjChYbckWxptAmAwtX = 0.05f;

			private const int MPxqxUdgsOlegUoFNQGlmivakAf = 2;

			private const int eSPXvOTZUIiVbKhODMsyPjfdEhQ = 0;

			public JcEqrSsDgugeoKOHYjCGtSwhfPLy(string name, int playerId, int unityJoystickId, int handle)
				: base(ControllerType.Drum, name, playerId, unityJoystickId, handle, new UNBlcGizJtLfiNUaAMtAxDiSDoT(13, 14, 0.05f, 2, 0))
			{
				base.extension = new PS4ControllerExtension(this);
			}

			protected override void UbbXxIvnKSHiQKQTSsjWdyNPIVw()
			{
				base.UbbXxIvnKSHiQKQTSsjWdyNPIVw();
				int joystickId = pqMExzQXMHxPhjePgBsVkpjmHaPc + 1;
				IList<Axis> axes = base.Axes;
				axes[6].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 10);
				axes[7].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 11);
				axes[8].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 12);
				axes[9].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 13);
				axes[10].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 14);
				axes[11].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 15);
				axes[12].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 16);
			}
		}

		private sealed class XlnfQPiQycZoIxXCRdlOAhbZuamQ : iMWprodYMlxbTxmJbcGuAHETefbI
		{
			private const int YlTbBOggPtVFjPOpUYhcWgDPoyVS = 16;

			private const int MIYoAXxJmUicNKAfsvlLFppMumFk = 14;

			private const float OfKeraHEVJkjChYbckWxptAmAwtX = 0.05f;

			private const int MPxqxUdgsOlegUoFNQGlmivakAf = 2;

			private const int eSPXvOTZUIiVbKhODMsyPjfdEhQ = 0;

			public XlnfQPiQycZoIxXCRdlOAhbZuamQ(string name, int playerId, int unityJoystickId, int handle)
				: base(ControllerType.FlightStick, name, playerId, unityJoystickId, handle, new UNBlcGizJtLfiNUaAMtAxDiSDoT(16, 14, 0.05f, 2, 0))
			{
				base.extension = new PS4ControllerExtension(this);
			}

			protected override void UbbXxIvnKSHiQKQTSsjWdyNPIVw()
			{
				base.UbbXxIvnKSHiQKQTSsjWdyNPIVw();
				int joystickId = pqMExzQXMHxPhjePgBsVkpjmHaPc + 1;
				IList<Axis> axes = base.Axes;
				axes[6].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 10);
				axes[7].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 11);
				axes[8].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 12);
				axes[9].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 13);
				axes[10].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 14);
				axes[11].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 15);
				axes[12].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 16);
				axes[13].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 17);
				axes[14].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 18);
				axes[15].value = UnityInputHelper.GetJoystickAxisValueByJoystickId(joystickId, 19);
			}
		}

		private ZNWRpaZUPczFNbvALtTETNpkcWE oPNQlVOZzciLujxLfVfmpptDhYV;

		private bool UczGbQElrumwJfmUcrEKGoaHpKEX = true;

		private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

		public override bool isReady => true;

		bool IControllerAssigner.enabled
		{
			get
			{
				return UczGbQElrumwJfmUcrEKGoaHpKEX;
			}
			set
			{
				UczGbQElrumwJfmUcrEKGoaHpKEX = value;
			}
		}

		public PS4InputSource()
			: base(22)
		{
			ReInput.controllerAssigner = this;
			oPNQlVOZzciLujxLfVfmpptDhYV = new ZNWRpaZUPczFNbvALtTETNpkcWE(4);
			oPNQlVOZzciLujxLfVfmpptDhYV.SuvTUfskVUQhJpEKOlCpYyTKrhq += gzkxvSLpjzYsrlqUhKGIytBwlwn;
			oPNQlVOZzciLujxLfVfmpptDhYV.hezQeTAfzrYiSocaPYiHcljkBYI += xbXdvFChdMROMONQpupgCiHhSn;
		}

		public override void Update()
		{
			oPNQlVOZzciLujxLfVfmpptDhYV.mtiNfGzpXHszOwiOIAVYQuMZclV();
			IList<Joystick> joysticks = GetJoysticks();
			int count = joysticks.Count;
			for (int i = 0; i < count; i++)
			{
				try
				{
					joysticks[i].Update();
				}
				catch (Exception ex)
				{
					Logger.LogError("An exception occurred during source joystick update.\n" + ex);
				}
			}
		}

		private static int JXomKWJyuHyOfZpXepPRbXSxhYx(int P_0)
		{
			if (P_0 >= 13)
			{
				return P_0 - 13;
			}
			return P_0 - 1;
		}

		private void gzkxvSLpjzYsrlqUhKGIytBwlwn(ZNWRpaZUPczFNbvALtTETNpkcWE.kJUblSElzSdBwWbikNVHiOEDnsy P_0)
		{
			WLVuCRcKtsuzZbsXPesHPMemkkF wLVuCRcKtsuzZbsXPesHPMemkkF;
			switch (P_0.TbljTJdnUyByvBmAcVlblnMstNJL)
			{
			case WLVuCRcKtsuzZbsXPesHPMemkkF.BaseControllerType.Gamepad:
				wLVuCRcKtsuzZbsXPesHPMemkkF = WLVuCRcKtsuzZbsXPesHPMemkkF.aWlEKFrTmxgBGgRqJDXRHeKwHYg(WLVuCRcKtsuzZbsXPesHPMemkkF.ControllerType.Gamepad, P_0.RzFpBgOUOOaOMRJfAolyIFFSEDu, P_0.MjneFLkKUwoxlcJMhdolMzbLNxaE, P_0.cdutLQQMhPjGwflAJdLFJDGNnqx);
				if (wLVuCRcKtsuzZbsXPesHPMemkkF == null)
				{
					return;
				}
				break;
			case WLVuCRcKtsuzZbsXPesHPMemkkF.BaseControllerType.Special:
				wLVuCRcKtsuzZbsXPesHPMemkkF = iMWprodYMlxbTxmJbcGuAHETefbI.aWlEKFrTmxgBGgRqJDXRHeKwHYg(P_0.RzFpBgOUOOaOMRJfAolyIFFSEDu, P_0.MjneFLkKUwoxlcJMhdolMzbLNxaE, P_0.cdutLQQMhPjGwflAJdLFJDGNnqx);
				if (wLVuCRcKtsuzZbsXPesHPMemkkF == null)
				{
					return;
				}
				break;
			case WLVuCRcKtsuzZbsXPesHPMemkkF.BaseControllerType.Aim:
				wLVuCRcKtsuzZbsXPesHPMemkkF = WLVuCRcKtsuzZbsXPesHPMemkkF.aWlEKFrTmxgBGgRqJDXRHeKwHYg(WLVuCRcKtsuzZbsXPesHPMemkkF.ControllerType.Aim, P_0.RzFpBgOUOOaOMRJfAolyIFFSEDu, P_0.MjneFLkKUwoxlcJMhdolMzbLNxaE, P_0.cdutLQQMhPjGwflAJdLFJDGNnqx);
				if (wLVuCRcKtsuzZbsXPesHPMemkkF == null)
				{
					return;
				}
				break;
			default:
				throw new NotImplementedException();
			}
			FgZdsaXSnQTJwnkUZEwaQdRkDyqH(wLVuCRcKtsuzZbsXPesHPMemkkF);
		}

		private void FgZdsaXSnQTJwnkUZEwaQdRkDyqH(WLVuCRcKtsuzZbsXPesHPMemkkF P_0)
		{
			AddJoystick(P_0);
			P_0.Connect();
			OnJoystickConnected();
		}

		private void xbXdvFChdMROMONQpupgCiHhSn(ZNWRpaZUPczFNbvALtTETNpkcWE.VtFcslVdTmOaEhoCXgsdDSHOuvW P_0)
		{
			IList<Joystick> joysticks = GetJoysticks();
			int count = joysticks.Count;
			for (int num = count - 1; num >= 0; num--)
			{
				WLVuCRcKtsuzZbsXPesHPMemkkF wLVuCRcKtsuzZbsXPesHPMemkkF = joysticks[num] as WLVuCRcKtsuzZbsXPesHPMemkkF;
				if (P_0.TbljTJdnUyByvBmAcVlblnMstNJL == wLVuCRcKtsuzZbsXPesHPMemkkF.TbljTJdnUyByvBmAcVlblnMstNJL && wLVuCRcKtsuzZbsXPesHPMemkkF.MjneFLkKUwoxlcJMhdolMzbLNxaE == P_0.MjneFLkKUwoxlcJMhdolMzbLNxaE && wLVuCRcKtsuzZbsXPesHPMemkkF.cdutLQQMhPjGwflAJdLFJDGNnqx == P_0.cdutLQQMhPjGwflAJdLFJDGNnqx)
				{
					wLVuCRcKtsuzZbsXPesHPMemkkF.Disconnect();
					RemoveJoystick(wLVuCRcKtsuzZbsXPesHPMemkkF);
				}
			}
			OnJoystickDisconnected();
		}

		private bool wYUjPsnyQfYjkJzAWZNzxmxZjst(ControllerType P_0, Rewired.Controller P_1)
		{
			if (!UczGbQElrumwJfmUcrEKGoaHpKEX)
			{
				return false;
			}
			if (P_0 != ControllerType.Joystick)
			{
				return false;
			}
			return ReInput.configVars.ps4_assignJoysticksByPS4JoyId;
		}

		bool IControllerAssigner.CanHandleAssignment(ControllerType P_0, Rewired.Controller P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in wYUjPsnyQfYjkJzAWZNzxmxZjst
			return this.wYUjPsnyQfYjkJzAWZNzxmxZjst(P_0, P_1);
		}

		private void yfGbaINRmwGvQIurbQGnubVduXM(ControllerType P_0, Rewired.Controller P_1)
		{
			if (!((IControllerAssigner)this).CanHandleAssignment(P_0, P_1))
			{
				return;
			}
			Rewired.Joystick joystick = P_1 as Rewired.Joystick;
			if (!ReInput.controllers.IsJoystickAssigned(joystick))
			{
				int num = JXomKWJyuHyOfZpXepPRbXSxhYx(joystick.unityId);
				if (num < ReInput.players.playerCount && ReInput.players.GetPlayer(num) != null && (!ReInput.configVars.assignJoysticksToPlayingPlayersOnly || ReInput.players.GetPlayer(num).isPlaying))
				{
					ReInput.players.GetPlayer(num).controllers.AddController(joystick, removeFromOtherPlayers: true);
				}
			}
		}

		void IControllerAssigner.AssignController(ControllerType P_0, Rewired.Controller P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in yfGbaINRmwGvQIurbQGnubVduXM
			this.yfGbaINRmwGvQIurbQGnubVduXM(P_0, P_1);
		}

		~PS4InputSource()
		{
			Dispose(disposing: false);
		}

		protected override void Dispose(bool disposing)
		{
			if (!RFSEgUYkCipDyWyLEnlGiNDUlzz)
			{
				RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
			}
		}
	}
}
