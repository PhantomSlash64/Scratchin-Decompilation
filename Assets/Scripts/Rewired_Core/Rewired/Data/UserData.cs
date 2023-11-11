using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Rewired.Config;
using Rewired.Data.Mapping;
using Rewired.Utils;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	public sealed class UserData
	{
		private static class kGhIqyKaCfwXRhNgnSFPxPwnDqy
		{
			[DefaultMember("Item")]
			private class seHDmnQDiSDJHjaCctbegGkUHmxS
			{
				public enum QwrRblAujsoBkXHpojAgfhfypRSY
				{
					vwTQzUDIdxLFgqhBgnjJOnSkEWE = 0,
					fvgSwEWVuLHXjsLhgRfQoPYMDsc = 1,
					ObhzDARdXnFTqWuCrmaAzeQjekX = 2
				}

				public int vwTQzUDIdxLFgqhBgnjJOnSkEWE;

				public int fvgSwEWVuLHXjsLhgRfQoPYMDsc;

				public int ObhzDARdXnFTqWuCrmaAzeQjekX;

				public int mFldAkWEWmHykRxiejPmGewpCka
				{
					get
					{
						return type switch
						{
							QwrRblAujsoBkXHpojAgfhfypRSY.vwTQzUDIdxLFgqhBgnjJOnSkEWE => vwTQzUDIdxLFgqhBgnjJOnSkEWE, 
							QwrRblAujsoBkXHpojAgfhfypRSY.fvgSwEWVuLHXjsLhgRfQoPYMDsc => fvgSwEWVuLHXjsLhgRfQoPYMDsc, 
							QwrRblAujsoBkXHpojAgfhfypRSY.ObhzDARdXnFTqWuCrmaAzeQjekX => ObhzDARdXnFTqWuCrmaAzeQjekX, 
							_ => throw new NotImplementedException(), 
						};
					}
					set
					{
						switch (type)
						{
						case QwrRblAujsoBkXHpojAgfhfypRSY.vwTQzUDIdxLFgqhBgnjJOnSkEWE:
							vwTQzUDIdxLFgqhBgnjJOnSkEWE = value;
							break;
						case QwrRblAujsoBkXHpojAgfhfypRSY.fvgSwEWVuLHXjsLhgRfQoPYMDsc:
							fvgSwEWVuLHXjsLhgRfQoPYMDsc = value;
							break;
						case QwrRblAujsoBkXHpojAgfhfypRSY.ObhzDARdXnFTqWuCrmaAzeQjekX:
							ObhzDARdXnFTqWuCrmaAzeQjekX = value;
							break;
						default:
							throw new NotImplementedException();
						}
					}
				}

				public seHDmnQDiSDJHjaCctbegGkUHmxS(int origId, int otherId, int finalId)
				{
					vwTQzUDIdxLFgqhBgnjJOnSkEWE = origId;
					fvgSwEWVuLHXjsLhgRfQoPYMDsc = otherId;
					ObhzDARdXnFTqWuCrmaAzeQjekX = finalId;
				}

				public override string ToString()
				{
					string text = "";
					text += StringTools.WriteVar("origId", vwTQzUDIdxLFgqhBgnjJOnSkEWE);
					text += StringTools.WriteVar("otherId", fvgSwEWVuLHXjsLhgRfQoPYMDsc);
					return text + StringTools.WriteVar("finalId", ObhzDARdXnFTqWuCrmaAzeQjekX);
				}
			}

			private class TvqENFFpkRmmDNlELiCANcttXNC<T>
			{
				public T PVvlSNRPruvLEyIUzSxfxpMFpze;

				public T MquqyDPztEbYjazCpwxPgorDFYC;

				public seHDmnQDiSDJHjaCctbegGkUHmxS.QwrRblAujsoBkXHpojAgfhfypRSY RhgqvxXeeAEVXiOSSbokhAXrufD;

				public IList<T> cTpyoseiLAuRTNhGTnxkxHkMjbz;

				public bool tyQDgvvvgkHmXxIMMILTdavtSRe;

				public TvqENFFpkRmmDNlELiCANcttXNC(T otherItem, T finalItem, seHDmnQDiSDJHjaCctbegGkUHmxS.QwrRblAujsoBkXHpojAgfhfypRSY idType, IList<T> finalItems, bool isCollision)
				{
					PVvlSNRPruvLEyIUzSxfxpMFpze = otherItem;
					MquqyDPztEbYjazCpwxPgorDFYC = finalItem;
					RhgqvxXeeAEVXiOSSbokhAXrufD = idType;
					cTpyoseiLAuRTNhGTnxkxHkMjbz = finalItems;
					tyQDgvvvgkHmXxIMMILTdavtSRe = isCollision;
				}
			}

			[CompilerGenerated]
			private sealed class ZEoOoaFFYglSmJQaAnzUXuVzUID
			{
				private sealed class VzbFIAXtUDnnIIcyxUFCEZpXNKr
				{
					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public TvqENFFpkRmmDNlELiCANcttXNC<InputAction> AqUzabFqyYiDcxoRQCjXJaYBGeti;

					public bool jvNrcRqMTltwtVYjzkmCeNprpJs(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == AqUzabFqyYiDcxoRQCjXJaYBGeti.PVvlSNRPruvLEyIUzSxfxpMFpze.categoryId;
					}

					public bool IEVdLnUiAUUVqcaGcMnsvTPHszj(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == AqUzabFqyYiDcxoRQCjXJaYBGeti.PVvlSNRPruvLEyIUzSxfxpMFpze.behaviorId;
					}
				}

				private sealed class XqdxHBvSZYMNzeDTxGbFpCljTiq
				{
					public TvqENFFpkRmmDNlELiCANcttXNC<ControllerMapLayoutManager_RuleSet_Editor> AqUzabFqyYiDcxoRQCjXJaYBGeti;
				}

				private sealed class lesFWNnMXBtvQUiDIkiPrgVbPSn
				{
					public XqdxHBvSZYMNzeDTxGbFpCljTiq lkNPPuuUkyDTutMxuFMuQeejKEq;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public int mWfxAMqKkxVJbPVWQZjasJUDDZX;

					public bool wGtNKMXHhhXYwLtHEKswXglBWj(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(lkNPPuuUkyDTutMxuFMuQeejKEq.AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX;
					}
				}

				private sealed class etfonwbhBPjooMQGEcpgTbbaZyh
				{
					public XqdxHBvSZYMNzeDTxGbFpCljTiq lkNPPuuUkyDTutMxuFMuQeejKEq;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public int mWfxAMqKkxVJbPVWQZjasJUDDZX;

					public bool SDDJajzGGKbSYdFtmPxxfQHfBexS(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(lkNPPuuUkyDTutMxuFMuQeejKEq.AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX;
					}
				}

				private sealed class kDMIPkJNGpIpSSBxqripKxleKm
				{
					public XqdxHBvSZYMNzeDTxGbFpCljTiq lkNPPuuUkyDTutMxuFMuQeejKEq;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public int mWfxAMqKkxVJbPVWQZjasJUDDZX;

					public bool tflPZzzuJtQRXGbbwzglXFLhoHt(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(lkNPPuuUkyDTutMxuFMuQeejKEq.AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX;
					}
				}

				private sealed class jLGEuCjTRfuqXNRocvvTgpVpfuU
				{
					public TvqENFFpkRmmDNlELiCANcttXNC<ControllerMapEnabler_RuleSet_Editor> AqUzabFqyYiDcxoRQCjXJaYBGeti;
				}

				private sealed class yevGYfMOWfpQPUTczFOuwCOQeRg
				{
					public jLGEuCjTRfuqXNRocvvTgpVpfuU JxIJGiQfxLxarCrqSAizTWauwOT;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public int mWfxAMqKkxVJbPVWQZjasJUDDZX;

					public bool yTjQGElGhYopolqFGgAgIFgUigK(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(JxIJGiQfxLxarCrqSAizTWauwOT.AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX;
					}
				}

				private sealed class GTbxmGZpgDIMnbGqEcBALwSrQBa
				{
					public jLGEuCjTRfuqXNRocvvTgpVpfuU JxIJGiQfxLxarCrqSAizTWauwOT;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public int mWfxAMqKkxVJbPVWQZjasJUDDZX;

					public bool HhlILZBaPSFZWzoAphuYHvTOqvtK(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(JxIJGiQfxLxarCrqSAizTWauwOT.AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX;
					}
				}

				private sealed class JFzhDfmXnKXZQglMZfzFCXeZKId
				{
					public jLGEuCjTRfuqXNRocvvTgpVpfuU JxIJGiQfxLxarCrqSAizTWauwOT;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public int mWfxAMqKkxVJbPVWQZjasJUDDZX;

					public bool amXYwmOncxKCKWxcdCOKQliSork(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(JxIJGiQfxLxarCrqSAizTWauwOT.AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX;
					}
				}

				private sealed class euOqDzbbfbFpAEQzckLqveRKACA
				{
					private sealed class wsLwFSIIrjSvjimzlbgIrjCUGBz
					{
						public euOqDzbbfbFpAEQzckLqveRKACA VezDvpPFGrvtikgHBFqPukWvJM;

						public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

						public Player_Editor.Mapping MBcARPFZxLOnVPBiVwerBuGBaiQh;

						public bool OuogbRATkcoKqwUYbQZFxOtSfxpH(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
						{
							return P_0.get_Item(VezDvpPFGrvtikgHBFqPukWvJM.AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh.categoryId;
						}

						public bool wcajUGhlYiPFbwoBKMBVbhiDrIoG(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
						{
							return P_0.get_Item(VezDvpPFGrvtikgHBFqPukWvJM.AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh.layoutId;
						}
					}

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public TvqENFFpkRmmDNlELiCANcttXNC<Player_Editor> AqUzabFqyYiDcxoRQCjXJaYBGeti;

					public void hBuoTwJglcACLccuamyjsxPbGav(List<Player_Editor.Mapping> P_0, List<seHDmnQDiSDJHjaCctbegGkUHmxS> P_1)
					{
						for (int i = 0; i < P_0.Count; i++)
						{
							ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx = this.KsRUDYIKGinSuPlaNkPzGuZKYnx;
							Player_Editor.Mapping MBcARPFZxLOnVPBiVwerBuGBaiQh = P_0[i];
							seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS = this.KsRUDYIKGinSuPlaNkPzGuZKYnx.cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh.categoryId);
							MBcARPFZxLOnVPBiVwerBuGBaiQh.categoryId = seHDmnQDiSDJHjaCctbegGkUHmxS?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
							seHDmnQDiSDJHjaCctbegGkUHmxS = P_1.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh.layoutId);
							MBcARPFZxLOnVPBiVwerBuGBaiQh.layoutId = seHDmnQDiSDJHjaCctbegGkUHmxS?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
						}
					}
				}

				private sealed class qEghUFiMVxjlzfHOOGdnDsLTNdCh
				{
					public euOqDzbbfbFpAEQzckLqveRKACA VezDvpPFGrvtikgHBFqPukWvJM;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public Player_Editor.CreateControllerInfo mAGYPlguIQeCUGOuYjJmhKPdaLH;

					public bool aCOwOkRdbepMyEEOjLPOSOiePBB(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(VezDvpPFGrvtikgHBFqPukWvJM.AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == mAGYPlguIQeCUGOuYjJmhKPdaLH.sourceId;
					}
				}

				private sealed class lCGMpiKFAKGuuDKQPJqrxwRHsot
				{
					public euOqDzbbfbFpAEQzckLqveRKACA VezDvpPFGrvtikgHBFqPukWvJM;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public int BlZsUkOGPQDnwzRAzcAFtbBWDaNH;

					public bool hYsgXoWsOfjRqXSinMnkQnhWqvs(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(VezDvpPFGrvtikgHBFqPukWvJM.AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == BlZsUkOGPQDnwzRAzcAFtbBWDaNH;
					}
				}

				private sealed class ulsHMxybOcBVaEkSyPSnCxTcMDzG
				{
					public euOqDzbbfbFpAEQzckLqveRKACA VezDvpPFGrvtikgHBFqPukWvJM;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public int BlZsUkOGPQDnwzRAzcAFtbBWDaNH;

					public bool SuYQJVNOfgbvUHHcUsRRKbCuUWcn(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(VezDvpPFGrvtikgHBFqPukWvJM.AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == BlZsUkOGPQDnwzRAzcAFtbBWDaNH;
					}
				}

				public UserData ISkmsCiBKkbTqyKMaVIsLGGdKou;

				public List<seHDmnQDiSDJHjaCctbegGkUHmxS> BFATZkUfJYyobLRHQKsfbmzIzA;

				public List<seHDmnQDiSDJHjaCctbegGkUHmxS> TJuoMRxpswmkeejUEZODiyLUCWc;

				public List<seHDmnQDiSDJHjaCctbegGkUHmxS> FvBmdXrivUPrVMcERZfhDmgEAfu;

				public List<seHDmnQDiSDJHjaCctbegGkUHmxS> cVBBEuktBkOWrDrCaQmPzhAlYoHZ;

				public List<seHDmnQDiSDJHjaCctbegGkUHmxS> ImfhhosyZPGUuICCnQBGgequFmP;

				public List<seHDmnQDiSDJHjaCctbegGkUHmxS> KYKflSZZfZevcykUTKJaEeIaARh;

				public List<seHDmnQDiSDJHjaCctbegGkUHmxS> obQUneKGVKRwAuEgsOBHNFFqvN;

				public List<seHDmnQDiSDJHjaCctbegGkUHmxS> lZusqqfJCZMAaPRIgYfBRHXKoCV;

				public Func<ControllerType, List<seHDmnQDiSDJHjaCctbegGkUHmxS>> zCKVbQcyWNLZSQaDOcIAizCoeoN;

				public List<seHDmnQDiSDJHjaCctbegGkUHmxS> ThtlaBGRMCFRogauOlyIPRCOlTJc;

				public List<seHDmnQDiSDJHjaCctbegGkUHmxS> YrFefFuZWCNFTmaYdepBBkFhEFDy;

				public List<seHDmnQDiSDJHjaCctbegGkUHmxS> VgpexWuHCaEqigdtrycAfddzsFP;

				private static Func<Player_Editor.Mapping, IList<Player_Editor.Mapping>, int> ePitkeOrlwABWpzCqEnaXRbRHaD;

				private static Func<Player_Editor.CreateControllerInfo, IList<Player_Editor.CreateControllerInfo>, int> xkXEycuSlFaNHbCZADBLSlwncKMG;

				public InputCategory rvCQMZMVPvSxrirJjuImTerdJRc(TvqENFFpkRmmDNlELiCANcttXNC<InputCategory> P_0)
				{
					InputCategory inputCategory = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					InputCategory inputCategory2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						inputCategory2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddActionCategory();
						inputCategory2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					inputCategory.id = inputCategory2.id;
					int index = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(inputCategory2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index] = inputCategory;
					return inputCategory;
				}

				public InputBehavior lUAcdEWcEGSUWSQJcKowbYwYTrR(TvqENFFpkRmmDNlELiCANcttXNC<InputBehavior> P_0)
				{
					InputBehavior inputBehavior = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					InputBehavior inputBehavior2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						inputBehavior2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddInputBehavior();
						inputBehavior2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					inputBehavior.id = inputBehavior2.id;
					int index = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(inputBehavior2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index] = inputBehavior;
					return inputBehavior;
				}

				public InputAction kLlvqjuDIDSVtJYmBBtWQQpXJyf(TvqENFFpkRmmDNlELiCANcttXNC<InputAction> P_0)
				{
					InputAction inputAction = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					int num = BFATZkUfJYyobLRHQKsfbmzIzA.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == P_0.PVvlSNRPruvLEyIUzSxfxpMFpze.categoryId)?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? 0;
					InputAction inputAction2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						inputAction2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddAction(num);
						inputAction2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					int behaviorId = TJuoMRxpswmkeejUEZODiyLUCWc.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == P_0.PVvlSNRPruvLEyIUzSxfxpMFpze.behaviorId)?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? 0;
					inputAction.id = inputAction2.id;
					if (num != inputAction2.categoryId)
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.ChangeActionCategory(inputAction2.id, num);
					}
					inputAction.categoryId = num;
					inputAction.behaviorId = behaviorId;
					int index = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(inputAction2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index] = inputAction;
					return inputAction;
				}

				public InputLayout iAJbHWSheDNbDMVYMOdDnPTMzKM(TvqENFFpkRmmDNlELiCANcttXNC<InputLayout> P_0)
				{
					InputLayout inputLayout = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					InputLayout inputLayout2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						inputLayout2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddKeyboardLayout();
						inputLayout2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					inputLayout.id = inputLayout2.id;
					int index = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(inputLayout2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index] = inputLayout;
					return inputLayout;
				}

				public InputLayout YdDsdnFVqLHpCvLETfpiuUebdri(TvqENFFpkRmmDNlELiCANcttXNC<InputLayout> P_0)
				{
					InputLayout inputLayout = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					InputLayout inputLayout2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						inputLayout2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddMouseLayout();
						inputLayout2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					inputLayout.id = inputLayout2.id;
					int index = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(inputLayout2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index] = inputLayout;
					return inputLayout;
				}

				public InputLayout memwHsEzAddRiSAcJWMheqQrKMu(TvqENFFpkRmmDNlELiCANcttXNC<InputLayout> P_0)
				{
					InputLayout inputLayout = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					InputLayout inputLayout2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						inputLayout2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddJoystickLayout();
						inputLayout2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					inputLayout.id = inputLayout2.id;
					int index = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(inputLayout2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index] = inputLayout;
					return inputLayout;
				}

				public InputLayout qmRnCAQEwJABeZVhbAtJpNOzHvV(TvqENFFpkRmmDNlELiCANcttXNC<InputLayout> P_0)
				{
					InputLayout inputLayout = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					InputLayout inputLayout2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						inputLayout2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddCustomControllerLayout();
						inputLayout2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					inputLayout.id = inputLayout2.id;
					int index = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(inputLayout2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index] = inputLayout;
					return inputLayout;
				}

				public List<seHDmnQDiSDJHjaCctbegGkUHmxS> bUPOlusgqQorWonzDBOtDwLAtfCr(ControllerType P_0)
				{
					return P_0 switch
					{
						ControllerType.Keyboard => ImfhhosyZPGUuICCnQBGgequFmP, 
						ControllerType.Mouse => KYKflSZZfZevcykUTKJaEeIaARh, 
						ControllerType.Joystick => obQUneKGVKRwAuEgsOBHNFFqvN, 
						ControllerType.Custom => lZusqqfJCZMAaPRIgYfBRHXKoCV, 
						_ => throw new NotImplementedException(), 
					};
				}

				public CustomController_Editor EVIWkGoWoybEiikQJRaFILpadXbG(TvqENFFpkRmmDNlELiCANcttXNC<CustomController_Editor> P_0)
				{
					CustomController_Editor customController_Editor = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					CustomController_Editor customController_Editor2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						customController_Editor2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddCustomController();
						customController_Editor2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					customController_Editor.id = customController_Editor2.id;
					int index = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(customController_Editor2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index] = customController_Editor;
					return customController_Editor;
				}

				public ControllerMapLayoutManager_RuleSet_Editor hPhCdIoLvzysdUhLjVycoihjeOw(TvqENFFpkRmmDNlELiCANcttXNC<ControllerMapLayoutManager_RuleSet_Editor> P_0)
				{
					ControllerMapLayoutManager_RuleSet_Editor controllerMapLayoutManager_RuleSet_Editor = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					int num = ((controllerMapLayoutManager_RuleSet_Editor.rules != null) ? controllerMapLayoutManager_RuleSet_Editor.rules.Count : 0);
					for (int i = 0; i < num; i++)
					{
						ControllerMapLayoutManager_Rule_Editor controllerMapLayoutManager_Rule_Editor = controllerMapLayoutManager_RuleSet_Editor.rules[i];
						if (controllerMapLayoutManager_Rule_Editor == null || controllerMapLayoutManager_Rule_Editor.categoryIds == null)
						{
							continue;
						}
						List<int> list = new List<int>();
						int num2 = ((controllerMapLayoutManager_Rule_Editor.categoryIds != null) ? controllerMapLayoutManager_Rule_Editor.categoryIds.Count : 0);
						for (int j = 0; j < num2; j++)
						{
							int mWfxAMqKkxVJbPVWQZjasJUDDZX3 = controllerMapLayoutManager_Rule_Editor.categoryIds[j];
							seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS = cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX3);
							if (seHDmnQDiSDJHjaCctbegGkUHmxS == null)
							{
								Logger.LogError("No new Map Category Id found for old id: " + mWfxAMqKkxVJbPVWQZjasJUDDZX3);
							}
							else
							{
								list.Add(seHDmnQDiSDJHjaCctbegGkUHmxS.ObhzDARdXnFTqWuCrmaAzeQjekX);
							}
						}
						controllerMapLayoutManager_Rule_Editor.categoryIds = list;
					}
					int num3 = ((controllerMapLayoutManager_RuleSet_Editor.rules != null) ? controllerMapLayoutManager_RuleSet_Editor.rules.Count : 0);
					for (int k = 0; k < num3; k++)
					{
						ControllerMapLayoutManager_Rule_Editor controllerMapLayoutManager_Rule_Editor2 = controllerMapLayoutManager_RuleSet_Editor.rules[k];
						if (controllerMapLayoutManager_Rule_Editor2 != null && controllerMapLayoutManager_Rule_Editor2.layoutId > 0)
						{
							ControllerType controllerType = controllerMapLayoutManager_Rule_Editor2.controllerSetSelector.controllerType;
							List<seHDmnQDiSDJHjaCctbegGkUHmxS> list2 = zCKVbQcyWNLZSQaDOcIAizCoeoN(controllerType);
							int mWfxAMqKkxVJbPVWQZjasJUDDZX2 = controllerMapLayoutManager_Rule_Editor2.layoutId;
							seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS2 = list2.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX2);
							if (seHDmnQDiSDJHjaCctbegGkUHmxS2 == null)
							{
								controllerMapLayoutManager_Rule_Editor2.layoutId = -1;
								Logger.LogError(string.Concat("No new ", controllerType, " Layout Id found for old id: ", mWfxAMqKkxVJbPVWQZjasJUDDZX2));
							}
							else
							{
								controllerMapLayoutManager_Rule_Editor2.layoutId = seHDmnQDiSDJHjaCctbegGkUHmxS2.ObhzDARdXnFTqWuCrmaAzeQjekX;
							}
						}
					}
					int num4 = ((controllerMapLayoutManager_RuleSet_Editor.rules != null) ? controllerMapLayoutManager_RuleSet_Editor.rules.Count : 0);
					for (int l = 0; l < num4; l++)
					{
						ControllerMapLayoutManager_Rule_Editor controllerMapLayoutManager_Rule_Editor3 = controllerMapLayoutManager_RuleSet_Editor.rules[l];
						if (controllerMapLayoutManager_Rule_Editor3 == null || controllerMapLayoutManager_Rule_Editor3.controllerSetSelector == null)
						{
							continue;
						}
						ControllerType controllerType2 = controllerMapLayoutManager_Rule_Editor3.controllerSetSelector.controllerType;
						if (controllerType2 == ControllerType.Custom)
						{
							List<seHDmnQDiSDJHjaCctbegGkUHmxS> thtlaBGRMCFRogauOlyIPRCOlTJc = ThtlaBGRMCFRogauOlyIPRCOlTJc;
							int mWfxAMqKkxVJbPVWQZjasJUDDZX = controllerMapLayoutManager_Rule_Editor3.controllerSetSelector.customControllerSourceId;
							seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS3 = thtlaBGRMCFRogauOlyIPRCOlTJc.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX);
							if (seHDmnQDiSDJHjaCctbegGkUHmxS3 == null)
							{
								controllerMapLayoutManager_Rule_Editor3.controllerSetSelector.customControllerSourceId = -1;
								Logger.LogError("No new Custom Controller found for old id: " + mWfxAMqKkxVJbPVWQZjasJUDDZX);
							}
							else
							{
								controllerMapLayoutManager_Rule_Editor3.controllerSetSelector.customControllerSourceId = seHDmnQDiSDJHjaCctbegGkUHmxS3.ObhzDARdXnFTqWuCrmaAzeQjekX;
							}
						}
					}
					ControllerMapLayoutManager_RuleSet_Editor controllerMapLayoutManager_RuleSet_Editor2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						controllerMapLayoutManager_RuleSet_Editor2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddControllerMapLayoutManagerRuleSet();
						controllerMapLayoutManager_RuleSet_Editor2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					controllerMapLayoutManager_RuleSet_Editor.id = controllerMapLayoutManager_RuleSet_Editor2.id;
					int index = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(controllerMapLayoutManager_RuleSet_Editor2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index] = controllerMapLayoutManager_RuleSet_Editor;
					return controllerMapLayoutManager_RuleSet_Editor;
				}

				public ControllerMapEnabler_RuleSet_Editor TeDdXUARtwcjBcXtfygpKldLGfq(TvqENFFpkRmmDNlELiCANcttXNC<ControllerMapEnabler_RuleSet_Editor> P_0)
				{
					ControllerMapEnabler_RuleSet_Editor controllerMapEnabler_RuleSet_Editor = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					int num = ((controllerMapEnabler_RuleSet_Editor.rules != null) ? controllerMapEnabler_RuleSet_Editor.rules.Count : 0);
					for (int i = 0; i < num; i++)
					{
						ControllerMapEnabler_Rule_Editor controllerMapEnabler_Rule_Editor = controllerMapEnabler_RuleSet_Editor.rules[i];
						if (controllerMapEnabler_Rule_Editor == null || controllerMapEnabler_Rule_Editor.categoryIds == null)
						{
							continue;
						}
						List<int> list = new List<int>();
						for (int j = 0; j < controllerMapEnabler_Rule_Editor.categoryIds.Count; j++)
						{
							int mWfxAMqKkxVJbPVWQZjasJUDDZX3 = controllerMapEnabler_Rule_Editor.categoryIds[j];
							seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS = cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX3);
							if (seHDmnQDiSDJHjaCctbegGkUHmxS == null)
							{
								Logger.LogError("No new Map Category Id found for old id: " + mWfxAMqKkxVJbPVWQZjasJUDDZX3);
							}
							else
							{
								list.Add(seHDmnQDiSDJHjaCctbegGkUHmxS.ObhzDARdXnFTqWuCrmaAzeQjekX);
							}
						}
						controllerMapEnabler_Rule_Editor.categoryIds = list;
					}
					int num2 = ((controllerMapEnabler_RuleSet_Editor.rules != null) ? controllerMapEnabler_RuleSet_Editor.rules.Count : 0);
					for (int k = 0; k < num2; k++)
					{
						ControllerMapEnabler_Rule_Editor controllerMapEnabler_Rule_Editor2 = controllerMapEnabler_RuleSet_Editor.rules[k];
						if (controllerMapEnabler_Rule_Editor2 == null || controllerMapEnabler_Rule_Editor2.layoutIds == null)
						{
							continue;
						}
						ControllerType controllerType = controllerMapEnabler_Rule_Editor2.controllerSetSelector.controllerType;
						List<seHDmnQDiSDJHjaCctbegGkUHmxS> list2 = zCKVbQcyWNLZSQaDOcIAizCoeoN(controllerType);
						List<int> list3 = new List<int>();
						int num3 = ((controllerMapEnabler_Rule_Editor2.layoutIds != null) ? controllerMapEnabler_Rule_Editor2.layoutIds.Count : 0);
						for (int l = 0; l < num3; l++)
						{
							int mWfxAMqKkxVJbPVWQZjasJUDDZX2 = controllerMapEnabler_Rule_Editor2.layoutIds[l];
							seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS2 = list2.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX2);
							if (seHDmnQDiSDJHjaCctbegGkUHmxS2 == null)
							{
								Logger.LogError(string.Concat("No new ", controllerType, " Layout Id found for old id: ", mWfxAMqKkxVJbPVWQZjasJUDDZX2));
							}
							else
							{
								list3.Add(seHDmnQDiSDJHjaCctbegGkUHmxS2.ObhzDARdXnFTqWuCrmaAzeQjekX);
							}
						}
						controllerMapEnabler_Rule_Editor2.layoutIds = list3;
					}
					int num4 = ((controllerMapEnabler_RuleSet_Editor.rules != null) ? controllerMapEnabler_RuleSet_Editor.rules.Count : 0);
					for (int m = 0; m < num4; m++)
					{
						ControllerMapEnabler_Rule_Editor controllerMapEnabler_Rule_Editor3 = controllerMapEnabler_RuleSet_Editor.rules[m];
						if (controllerMapEnabler_Rule_Editor3 == null || controllerMapEnabler_Rule_Editor3.controllerSetSelector == null)
						{
							continue;
						}
						ControllerType controllerType2 = controllerMapEnabler_Rule_Editor3.controllerSetSelector.controllerType;
						if (controllerType2 == ControllerType.Custom)
						{
							List<seHDmnQDiSDJHjaCctbegGkUHmxS> thtlaBGRMCFRogauOlyIPRCOlTJc = ThtlaBGRMCFRogauOlyIPRCOlTJc;
							int mWfxAMqKkxVJbPVWQZjasJUDDZX = controllerMapEnabler_Rule_Editor3.controllerSetSelector.customControllerSourceId;
							seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS3 = thtlaBGRMCFRogauOlyIPRCOlTJc.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX);
							if (seHDmnQDiSDJHjaCctbegGkUHmxS3 == null)
							{
								controllerMapEnabler_Rule_Editor3.controllerSetSelector.customControllerSourceId = -1;
								Logger.LogError("No new Custom Controller found for old id: " + mWfxAMqKkxVJbPVWQZjasJUDDZX);
							}
							else
							{
								controllerMapEnabler_Rule_Editor3.controllerSetSelector.customControllerSourceId = seHDmnQDiSDJHjaCctbegGkUHmxS3.ObhzDARdXnFTqWuCrmaAzeQjekX;
							}
						}
					}
					ControllerMapEnabler_RuleSet_Editor controllerMapEnabler_RuleSet_Editor2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						controllerMapEnabler_RuleSet_Editor2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddControllerMapEnablerRuleSet();
						controllerMapEnabler_RuleSet_Editor2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					controllerMapEnabler_RuleSet_Editor.id = controllerMapEnabler_RuleSet_Editor2.id;
					int index = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(controllerMapEnabler_RuleSet_Editor2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index] = controllerMapEnabler_RuleSet_Editor;
					return controllerMapEnabler_RuleSet_Editor;
				}

				public Player_Editor UKcdzouKZHtbiokzuocZxGKIPgA(TvqENFFpkRmmDNlELiCANcttXNC<Player_Editor> P_0)
				{
					Player_Editor player_Editor = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					Action<List<Player_Editor.Mapping>, List<seHDmnQDiSDJHjaCctbegGkUHmxS>> action = delegate(List<Player_Editor.Mapping> P_0, List<seHDmnQDiSDJHjaCctbegGkUHmxS> P_1)
					{
						for (int n = 0; n < P_0.Count; n++)
						{
							ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx = this;
							Player_Editor.Mapping MBcARPFZxLOnVPBiVwerBuGBaiQh = P_0[n];
							seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS4 = cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh.categoryId);
							MBcARPFZxLOnVPBiVwerBuGBaiQh.categoryId = seHDmnQDiSDJHjaCctbegGkUHmxS4?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
							seHDmnQDiSDJHjaCctbegGkUHmxS4 = P_1.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh.layoutId);
							MBcARPFZxLOnVPBiVwerBuGBaiQh.layoutId = seHDmnQDiSDJHjaCctbegGkUHmxS4?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
						}
					};
					action(player_Editor.defaultKeyboardMaps, ImfhhosyZPGUuICCnQBGgequFmP);
					action(player_Editor.defaultMouseMaps, KYKflSZZfZevcykUTKJaEeIaARh);
					action(player_Editor.defaultJoystickMaps, obQUneKGVKRwAuEgsOBHNFFqvN);
					action(player_Editor.defaultCustomControllerMaps, lZusqqfJCZMAaPRIgYfBRHXKoCV);
					for (int i = 0; i < player_Editor.startingCustomControllers.Count; i++)
					{
						Player_Editor.CreateControllerInfo mAGYPlguIQeCUGOuYjJmhKPdaLH = player_Editor.startingCustomControllers[i];
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS = ThtlaBGRMCFRogauOlyIPRCOlTJc.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == mAGYPlguIQeCUGOuYjJmhKPdaLH.sourceId);
						mAGYPlguIQeCUGOuYjJmhKPdaLH.sourceId = seHDmnQDiSDJHjaCctbegGkUHmxS?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					}
					List<Player_Editor.RuleSetMapping> list = new List<Player_Editor.RuleSetMapping>();
					List<Player_Editor.RuleSetMapping> ruleSets = player_Editor.controllerMapLayoutManagerSettings.ruleSets;
					for (int j = 0; j < ruleSets.Count; j++)
					{
						Player_Editor.RuleSetMapping ruleSetMapping = ruleSets[j];
						if (ruleSetMapping != null)
						{
							int BlZsUkOGPQDnwzRAzcAFtbBWDaNH2 = ruleSetMapping.id;
							seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS2 = YrFefFuZWCNFTmaYdepBBkFhEFDy.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == BlZsUkOGPQDnwzRAzcAFtbBWDaNH2);
							if (seHDmnQDiSDJHjaCctbegGkUHmxS2 == null)
							{
								Logger.LogError("No new Controller Map Layout Manager Set found for old id: " + BlZsUkOGPQDnwzRAzcAFtbBWDaNH2);
								continue;
							}
							ruleSetMapping = ruleSetMapping.Clone();
							ruleSetMapping.id = seHDmnQDiSDJHjaCctbegGkUHmxS2.ObhzDARdXnFTqWuCrmaAzeQjekX;
							list.Add(ruleSetMapping);
						}
					}
					player_Editor.controllerMapLayoutManagerSettings.ruleSets = list;
					List<Player_Editor.RuleSetMapping> list2 = new List<Player_Editor.RuleSetMapping>();
					List<Player_Editor.RuleSetMapping> ruleSets2 = player_Editor.controllerMapEnablerSettings.ruleSets;
					for (int k = 0; k < ruleSets2.Count; k++)
					{
						Player_Editor.RuleSetMapping ruleSetMapping2 = ruleSets2[k];
						if (ruleSetMapping2 != null)
						{
							int BlZsUkOGPQDnwzRAzcAFtbBWDaNH = ruleSetMapping2.id;
							seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS3 = VgpexWuHCaEqigdtrycAfddzsFP.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == BlZsUkOGPQDnwzRAzcAFtbBWDaNH);
							if (seHDmnQDiSDJHjaCctbegGkUHmxS3 == null)
							{
								Logger.LogError("No new Controller Map Enabler Set found for old id: " + BlZsUkOGPQDnwzRAzcAFtbBWDaNH);
								continue;
							}
							ruleSetMapping2 = ruleSetMapping2.Clone();
							ruleSetMapping2.id = seHDmnQDiSDJHjaCctbegGkUHmxS3.ObhzDARdXnFTqWuCrmaAzeQjekX;
							list2.Add(ruleSetMapping2);
						}
					}
					player_Editor.controllerMapEnablerSettings.ruleSets = list2;
					Player_Editor player_Editor2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						player_Editor2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
						Player_Editor player_Editor3 = JsonTools.Clone(player_Editor);
						player_Editor3.defaultKeyboardMaps.Clear();
						player_Editor3.defaultMouseMaps.Clear();
						player_Editor3.defaultJoystickMaps.Clear();
						player_Editor3.defaultCustomControllerMaps.Clear();
						player_Editor3.startingCustomControllers.Clear();
						Func<Player_Editor.Mapping, IList<Player_Editor.Mapping>, int> func = delegate(Player_Editor.Mapping P_0, IList<Player_Editor.Mapping> P_1)
						{
							for (int m = 0; m < P_1.Count; m++)
							{
								if (P_1[m].categoryId == P_0.categoryId && P_1[m].layoutId == P_0.layoutId)
								{
									return m;
								}
							}
							return -1;
						};
						BtQSnWhMZhgfMEqJthwNeWooLXH(player_Editor2.defaultKeyboardMaps, player_Editor.defaultKeyboardMaps, player_Editor3.defaultKeyboardMaps, func);
						BtQSnWhMZhgfMEqJthwNeWooLXH(player_Editor2.defaultMouseMaps, player_Editor.defaultMouseMaps, player_Editor3.defaultMouseMaps, func);
						BtQSnWhMZhgfMEqJthwNeWooLXH(player_Editor2.defaultJoystickMaps, player_Editor.defaultJoystickMaps, player_Editor3.defaultJoystickMaps, func);
						BtQSnWhMZhgfMEqJthwNeWooLXH(player_Editor2.defaultCustomControllerMaps, player_Editor.defaultCustomControllerMaps, player_Editor3.defaultCustomControllerMaps, func);
						BtQSnWhMZhgfMEqJthwNeWooLXH(player_Editor2.startingCustomControllers, player_Editor.startingCustomControllers, player_Editor3.startingCustomControllers, delegate(Player_Editor.CreateControllerInfo P_0, IList<Player_Editor.CreateControllerInfo> P_1)
						{
							for (int l = 0; l < P_1.Count; l++)
							{
								if (P_1[l].sourceId == P_0.sourceId)
								{
									return l;
								}
							}
							return -1;
						});
						player_Editor = player_Editor3;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddPlayer();
						player_Editor2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					player_Editor.id = player_Editor2.id;
					int index = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(player_Editor2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index] = player_Editor;
					return player_Editor;
				}

				private static int lvUlnASvRZiENhhKZCqubnRizUP(Player_Editor.Mapping P_0, IList<Player_Editor.Mapping> P_1)
				{
					for (int i = 0; i < P_1.Count; i++)
					{
						if (P_1[i].categoryId == P_0.categoryId && P_1[i].layoutId == P_0.layoutId)
						{
							return i;
						}
					}
					return -1;
				}

				private static int AClHldlLhggLljBjCJQupVVdFyj(Player_Editor.CreateControllerInfo P_0, IList<Player_Editor.CreateControllerInfo> P_1)
				{
					for (int i = 0; i < P_1.Count; i++)
					{
						if (P_1[i].sourceId == P_0.sourceId)
						{
							return i;
						}
					}
					return -1;
				}
			}

			[CompilerGenerated]
			private sealed class RBFzAGbvFczRguUGqokDhVAVjFH
			{
				public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

				public List<int> hZViYPIaaIHQrsYUWlcWOIpKjpO;

				public InputMapCategory DhlAClfSrJphJEOcKIpNFekIbJKX(TvqENFFpkRmmDNlELiCANcttXNC<InputMapCategory> P_0)
				{
					InputMapCategory inputMapCategory = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					InputMapCategory inputMapCategory2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						inputMapCategory2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						KsRUDYIKGinSuPlaNkPzGuZKYnx.ISkmsCiBKkbTqyKMaVIsLGGdKou.AddMapCategory();
						inputMapCategory2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					int num = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(inputMapCategory2);
					if (P_0.RhgqvxXeeAEVXiOSSbokhAXrufD == seHDmnQDiSDJHjaCctbegGkUHmxS.QwrRblAujsoBkXHpojAgfhfypRSY.fvgSwEWVuLHXjsLhgRfQoPYMDsc)
					{
						hZViYPIaaIHQrsYUWlcWOIpKjpO.Add(num);
					}
					inputMapCategory.id = inputMapCategory2.id;
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[num] = inputMapCategory;
					return inputMapCategory;
				}
			}

			[CompilerGenerated]
			private sealed class OyKAxXjhpfSSermyPhZnpdGwGZb
			{
				public RBFzAGbvFczRguUGqokDhVAVjFH yPIiqlCfVFJOPofKvjYDiuOHTrS;

				public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

				public int fvgSwEWVuLHXjsLhgRfQoPYMDsc;

				public bool zcrDxAWEASOryfxpDKoOptLafDI(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
				{
					return P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == fvgSwEWVuLHXjsLhgRfQoPYMDsc;
				}
			}

			[CompilerGenerated]
			private sealed class LfNmgyKYwicfCcqsiaANNHgItWT
			{
				private sealed class zzDhaRKlVRAqxpqEDrGaSDeAhkAb
				{
					public LfNmgyKYwicfCcqsiaANNHgItWT GuyQOMVTYJlfCQEWvyJTgEtJcRm;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public ControllerMap_Editor mAGYPlguIQeCUGOuYjJmhKPdaLH;

					public bool IvTmNBmKUCJvYyQItnDblXNeSoF(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == mAGYPlguIQeCUGOuYjJmhKPdaLH.categoryId;
					}

					public bool oAkICsmXRAATiOvSiFEJWrAfcTf(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == mAGYPlguIQeCUGOuYjJmhKPdaLH.layoutId;
					}
				}

				private sealed class YyGsRmrDnkLrnkHAFeCoqVJjBzEb
				{
					public LfNmgyKYwicfCcqsiaANNHgItWT GuyQOMVTYJlfCQEWvyJTgEtJcRm;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public ControllerMap_Editor JiPmnWqGoodLekCZtZTncBkMXVE;

					public TvqENFFpkRmmDNlELiCANcttXNC<ControllerMap_Editor> AqUzabFqyYiDcxoRQCjXJaYBGeti;

					public bool LRLmYbrVpuncxMmzxJvKbXqNmmV(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.categoryId;
					}

					public bool zcbJFuwEVgEXtXNMrHQeImBIWEZ(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.layoutId;
					}
				}

				private sealed class mOrvCjyMPkEXRPmFkkeqKIfNfOA
				{
					public YyGsRmrDnkLrnkHAFeCoqVJjBzEb ENJbmOaKqLUUPyIwUVomhxzBeDW;

					public LfNmgyKYwicfCcqsiaANNHgItWT GuyQOMVTYJlfCQEWvyJTgEtJcRm;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public ActionElementMap MBcARPFZxLOnVPBiVwerBuGBaiQh;

					public bool YCwsuiZDrPfvpIQbMvmBizIdilR(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(ENJbmOaKqLUUPyIwUVomhxzBeDW.AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId;
					}
				}

				public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

				public List<seHDmnQDiSDJHjaCctbegGkUHmxS> slXEjUxuEBlCBCGMdQtEbqClyVl;

				private static Func<ActionElementMap, IList<ActionElementMap>, int> IzAPkcROaeEKqElAjrafWTcJllgj;

				public int pCFsxxhGyVNsqaaFegOVjHJvcytJ(ControllerMap_Editor P_0, IList<ControllerMap_Editor> P_1)
				{
					ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx = this.KsRUDYIKGinSuPlaNkPzGuZKYnx;
					for (int i = 0; i < P_1.Count; i++)
					{
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS = this.KsRUDYIKGinSuPlaNkPzGuZKYnx.cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.categoryId);
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS2 = slXEjUxuEBlCBCGMdQtEbqClyVl.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.layoutId);
						if (seHDmnQDiSDJHjaCctbegGkUHmxS != null && seHDmnQDiSDJHjaCctbegGkUHmxS.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[i].categoryId && seHDmnQDiSDJHjaCctbegGkUHmxS2 != null && seHDmnQDiSDJHjaCctbegGkUHmxS2.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[i].layoutId)
						{
							return i;
						}
					}
					return -1;
				}

				public ControllerMap_Editor YkIxVjsyfWAUNTZokhQmzKcKdct(TvqENFFpkRmmDNlELiCANcttXNC<ControllerMap_Editor> P_0)
				{
					ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx2 = this.KsRUDYIKGinSuPlaNkPzGuZKYnx;
					ControllerMap_Editor JiPmnWqGoodLekCZtZTncBkMXVE = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS = this.KsRUDYIKGinSuPlaNkPzGuZKYnx.cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.categoryId);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS2 = slXEjUxuEBlCBCGMdQtEbqClyVl.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.layoutId);
					JiPmnWqGoodLekCZtZTncBkMXVE.categoryId = seHDmnQDiSDJHjaCctbegGkUHmxS?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					JiPmnWqGoodLekCZtZTncBkMXVE.layoutId = seHDmnQDiSDJHjaCctbegGkUHmxS2?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					for (int i = 0; i < JiPmnWqGoodLekCZtZTncBkMXVE.actionElementMaps.Count; i++)
					{
						ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx = this.KsRUDYIKGinSuPlaNkPzGuZKYnx;
						ActionElementMap MBcARPFZxLOnVPBiVwerBuGBaiQh = JiPmnWqGoodLekCZtZTncBkMXVE.actionElementMaps[i];
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS3 = this.KsRUDYIKGinSuPlaNkPzGuZKYnx.FvBmdXrivUPrVMcERZfhDmgEAfu.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId);
						MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId = seHDmnQDiSDJHjaCctbegGkUHmxS3?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
						MBcARPFZxLOnVPBiVwerBuGBaiQh._actionCategoryId = ((this.KsRUDYIKGinSuPlaNkPzGuZKYnx.ISkmsCiBKkbTqyKMaVIsLGGdKou.GetActionById(MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId) != null) ? this.KsRUDYIKGinSuPlaNkPzGuZKYnx.ISkmsCiBKkbTqyKMaVIsLGGdKou.GetActionById(MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId).categoryId : 0);
					}
					ControllerMap_Editor controllerMap_Editor;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						controllerMap_Editor = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
						ControllerMap_Editor controllerMap_Editor2 = JsonTools.Clone(JiPmnWqGoodLekCZtZTncBkMXVE);
						controllerMap_Editor2.actionElementMaps.Clear();
						Func<ActionElementMap, IList<ActionElementMap>, int> func = delegate(ActionElementMap P_0, IList<ActionElementMap> P_1)
						{
							for (int j = 0; j < P_1.Count; j++)
							{
								if (P_1[j]._keyboardKeyCode == P_0._keyboardKeyCode && P_1[j]._modifierKey1 == P_0._modifierKey1 && P_1[j]._modifierKey2 == P_0._modifierKey2 && P_1[j]._modifierKey3 == P_0._modifierKey3 && P_1[j]._axisContribution == P_0._axisContribution && P_1[j]._actionId == P_0._actionId)
								{
									return j;
								}
							}
							return -1;
						};
						BtQSnWhMZhgfMEqJthwNeWooLXH(controllerMap_Editor.actionElementMaps, JiPmnWqGoodLekCZtZTncBkMXVE.actionElementMaps, controllerMap_Editor2.actionElementMaps, func);
						JiPmnWqGoodLekCZtZTncBkMXVE = controllerMap_Editor2;
					}
					else
					{
						this.KsRUDYIKGinSuPlaNkPzGuZKYnx.ISkmsCiBKkbTqyKMaVIsLGGdKou.CreateKeyboardMap(JiPmnWqGoodLekCZtZTncBkMXVE.categoryId, JiPmnWqGoodLekCZtZTncBkMXVE.layoutId);
						controllerMap_Editor = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					JiPmnWqGoodLekCZtZTncBkMXVE.id = controllerMap_Editor.id;
					int index = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(controllerMap_Editor);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index] = JiPmnWqGoodLekCZtZTncBkMXVE;
					return JiPmnWqGoodLekCZtZTncBkMXVE;
				}

				private static int mkmUgCIGgjahgfKLaTOUjmpQFifG(ActionElementMap P_0, IList<ActionElementMap> P_1)
				{
					for (int i = 0; i < P_1.Count; i++)
					{
						if (P_1[i]._keyboardKeyCode == P_0._keyboardKeyCode && P_1[i]._modifierKey1 == P_0._modifierKey1 && P_1[i]._modifierKey2 == P_0._modifierKey2 && P_1[i]._modifierKey3 == P_0._modifierKey3 && P_1[i]._axisContribution == P_0._axisContribution && P_1[i]._actionId == P_0._actionId)
						{
							return i;
						}
					}
					return -1;
				}
			}

			[CompilerGenerated]
			private sealed class luDoOIXBgCCVHEixZBjqugnBFzNW
			{
				private sealed class aJGRXQJKWXltaHovuphEWkmniMd
				{
					public luDoOIXBgCCVHEixZBjqugnBFzNW qcNZbQYdykDurYuRdgtiQtuGrHc;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public ControllerMap_Editor mAGYPlguIQeCUGOuYjJmhKPdaLH;

					public bool AtpxxnbktNCYpeNMSLsSPChUZGK(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == mAGYPlguIQeCUGOuYjJmhKPdaLH.categoryId;
					}

					public bool JFKrHPJdehnWqgboDIiykVQhBFO(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == mAGYPlguIQeCUGOuYjJmhKPdaLH.layoutId;
					}
				}

				private sealed class NIyrSSmtmcdKQyQmVSZrTJVPDsq
				{
					public luDoOIXBgCCVHEixZBjqugnBFzNW qcNZbQYdykDurYuRdgtiQtuGrHc;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public ControllerMap_Editor JiPmnWqGoodLekCZtZTncBkMXVE;

					public TvqENFFpkRmmDNlELiCANcttXNC<ControllerMap_Editor> AqUzabFqyYiDcxoRQCjXJaYBGeti;

					public bool UgnAVkJpBiyDBCdDLgWXysKXtsK(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.categoryId;
					}

					public bool ZBeGURFChJEnhxoxRQypcqdYDny(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.layoutId;
					}
				}

				private sealed class YsHoSuwhxnkQjZgFFHmiJYxxbTZR
				{
					public NIyrSSmtmcdKQyQmVSZrTJVPDsq uCZpOnLiSKfFzGYpsOcQejQzPMwa;

					public luDoOIXBgCCVHEixZBjqugnBFzNW qcNZbQYdykDurYuRdgtiQtuGrHc;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public ActionElementMap MBcARPFZxLOnVPBiVwerBuGBaiQh;

					public bool YNOfvoEyhdIKyljHgUKDYrEiXwB(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(uCZpOnLiSKfFzGYpsOcQejQzPMwa.AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId;
					}
				}

				public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

				public List<seHDmnQDiSDJHjaCctbegGkUHmxS> slXEjUxuEBlCBCGMdQtEbqClyVl;

				private static Func<ActionElementMap, IList<ActionElementMap>, int> wAZuPNnwUGpdmXvqknUVIcSmRpz;

				public int pQleOxgzerbJXxWxeXAFULgsOlW(ControllerMap_Editor P_0, IList<ControllerMap_Editor> P_1)
				{
					ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx = this.KsRUDYIKGinSuPlaNkPzGuZKYnx;
					for (int i = 0; i < P_1.Count; i++)
					{
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS = this.KsRUDYIKGinSuPlaNkPzGuZKYnx.cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.categoryId);
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS2 = slXEjUxuEBlCBCGMdQtEbqClyVl.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.layoutId);
						if (seHDmnQDiSDJHjaCctbegGkUHmxS != null && seHDmnQDiSDJHjaCctbegGkUHmxS.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[i].categoryId && seHDmnQDiSDJHjaCctbegGkUHmxS2 != null && seHDmnQDiSDJHjaCctbegGkUHmxS2.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[i].layoutId)
						{
							return i;
						}
					}
					return -1;
				}

				public ControllerMap_Editor lvuMPNFhNlYlShyngSKClOliAXzc(TvqENFFpkRmmDNlELiCANcttXNC<ControllerMap_Editor> P_0)
				{
					ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx2 = this.KsRUDYIKGinSuPlaNkPzGuZKYnx;
					ControllerMap_Editor JiPmnWqGoodLekCZtZTncBkMXVE = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS = this.KsRUDYIKGinSuPlaNkPzGuZKYnx.cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.categoryId);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS2 = slXEjUxuEBlCBCGMdQtEbqClyVl.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.layoutId);
					JiPmnWqGoodLekCZtZTncBkMXVE.categoryId = seHDmnQDiSDJHjaCctbegGkUHmxS?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					JiPmnWqGoodLekCZtZTncBkMXVE.layoutId = seHDmnQDiSDJHjaCctbegGkUHmxS2?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					for (int i = 0; i < JiPmnWqGoodLekCZtZTncBkMXVE.actionElementMaps.Count; i++)
					{
						ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx = this.KsRUDYIKGinSuPlaNkPzGuZKYnx;
						ActionElementMap MBcARPFZxLOnVPBiVwerBuGBaiQh = JiPmnWqGoodLekCZtZTncBkMXVE.actionElementMaps[i];
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS3 = this.KsRUDYIKGinSuPlaNkPzGuZKYnx.FvBmdXrivUPrVMcERZfhDmgEAfu.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId);
						MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId = seHDmnQDiSDJHjaCctbegGkUHmxS3?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
						MBcARPFZxLOnVPBiVwerBuGBaiQh._actionCategoryId = ((this.KsRUDYIKGinSuPlaNkPzGuZKYnx.ISkmsCiBKkbTqyKMaVIsLGGdKou.GetActionById(MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId) != null) ? this.KsRUDYIKGinSuPlaNkPzGuZKYnx.ISkmsCiBKkbTqyKMaVIsLGGdKou.GetActionById(MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId).categoryId : 0);
					}
					ControllerMap_Editor controllerMap_Editor;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						controllerMap_Editor = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
						ControllerMap_Editor controllerMap_Editor2 = JsonTools.Clone(JiPmnWqGoodLekCZtZTncBkMXVE);
						controllerMap_Editor2.actionElementMaps.Clear();
						Func<ActionElementMap, IList<ActionElementMap>, int> func = delegate(ActionElementMap P_0, IList<ActionElementMap> P_1)
						{
							for (int j = 0; j < P_1.Count; j++)
							{
								if (P_1[j]._elementIdentifierId == P_0._elementIdentifierId && P_1[j]._axisRange == P_0._axisRange && P_1[j]._axisContribution == P_0._axisContribution && P_1[j]._actionId == P_0._actionId)
								{
									return j;
								}
							}
							return -1;
						};
						BtQSnWhMZhgfMEqJthwNeWooLXH(controllerMap_Editor.actionElementMaps, JiPmnWqGoodLekCZtZTncBkMXVE.actionElementMaps, controllerMap_Editor2.actionElementMaps, func);
						JiPmnWqGoodLekCZtZTncBkMXVE = controllerMap_Editor2;
					}
					else
					{
						this.KsRUDYIKGinSuPlaNkPzGuZKYnx.ISkmsCiBKkbTqyKMaVIsLGGdKou.CreateMouseMap(JiPmnWqGoodLekCZtZTncBkMXVE.categoryId, JiPmnWqGoodLekCZtZTncBkMXVE.layoutId);
						controllerMap_Editor = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					JiPmnWqGoodLekCZtZTncBkMXVE.id = controllerMap_Editor.id;
					int index = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(controllerMap_Editor);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index] = JiPmnWqGoodLekCZtZTncBkMXVE;
					return JiPmnWqGoodLekCZtZTncBkMXVE;
				}

				private static int lBdEyWGHfAlhmeErezHSaAlqTySu(ActionElementMap P_0, IList<ActionElementMap> P_1)
				{
					for (int i = 0; i < P_1.Count; i++)
					{
						if (P_1[i]._elementIdentifierId == P_0._elementIdentifierId && P_1[i]._axisRange == P_0._axisRange && P_1[i]._axisContribution == P_0._axisContribution && P_1[i]._actionId == P_0._actionId)
						{
							return i;
						}
					}
					return -1;
				}
			}

			[CompilerGenerated]
			private sealed class ZNoCecHbYafKZbSdnQDkfbQCOlcN
			{
				private sealed class pdDJlFcaabGgjwmMomfxLwfWLCF
				{
					public ZNoCecHbYafKZbSdnQDkfbQCOlcN XdjhXaplvTRetrIiUpRNBzKfbzp;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public ControllerMap_Editor mAGYPlguIQeCUGOuYjJmhKPdaLH;

					public bool zlfVlLwjdcBHCrfBIcJNjlyoErH(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == mAGYPlguIQeCUGOuYjJmhKPdaLH.categoryId;
					}

					public bool XKeFzhYHFzrPHmzQMBhHwqBiAYV(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == mAGYPlguIQeCUGOuYjJmhKPdaLH.layoutId;
					}
				}

				private sealed class nHdLYkHvOxHjdQsUZateeSLbZdX
				{
					public ZNoCecHbYafKZbSdnQDkfbQCOlcN XdjhXaplvTRetrIiUpRNBzKfbzp;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public ControllerMap_Editor JiPmnWqGoodLekCZtZTncBkMXVE;

					public TvqENFFpkRmmDNlELiCANcttXNC<ControllerMap_Editor> AqUzabFqyYiDcxoRQCjXJaYBGeti;

					public bool OceOdJjkiYdcYdigIOuPygZDgFPe(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.categoryId;
					}

					public bool pBPrWjEqLagzBDXrBSKKrHRLFAg(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.layoutId;
					}
				}

				private sealed class btRLogusniTLRgBjzmCgMTEsNbe
				{
					public nHdLYkHvOxHjdQsUZateeSLbZdX MeIQGnyrBwHePhQgAGlBnKAQXte;

					public ZNoCecHbYafKZbSdnQDkfbQCOlcN XdjhXaplvTRetrIiUpRNBzKfbzp;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public ActionElementMap MBcARPFZxLOnVPBiVwerBuGBaiQh;

					public bool oxJqbfovLEadHmiekGrNaWvhRaZf(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(MeIQGnyrBwHePhQgAGlBnKAQXte.AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId;
					}
				}

				public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

				public List<seHDmnQDiSDJHjaCctbegGkUHmxS> slXEjUxuEBlCBCGMdQtEbqClyVl;

				private static Func<ActionElementMap, IList<ActionElementMap>, int> pfdyXrhWQNrUpxDnutzuUwPQuPY;

				public int tnetXwUOxchMINojeWQLKPFNdea(ControllerMap_Editor P_0, IList<ControllerMap_Editor> P_1)
				{
					ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx = this.KsRUDYIKGinSuPlaNkPzGuZKYnx;
					for (int i = 0; i < P_1.Count; i++)
					{
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS = this.KsRUDYIKGinSuPlaNkPzGuZKYnx.cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.categoryId);
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS2 = slXEjUxuEBlCBCGMdQtEbqClyVl.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.layoutId);
						if (P_0.hardwareGuid == P_1[i].hardwareGuid && seHDmnQDiSDJHjaCctbegGkUHmxS != null && seHDmnQDiSDJHjaCctbegGkUHmxS.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[i].categoryId && seHDmnQDiSDJHjaCctbegGkUHmxS2 != null && seHDmnQDiSDJHjaCctbegGkUHmxS2.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[i].layoutId)
						{
							return i;
						}
					}
					return -1;
				}

				public ControllerMap_Editor nCCcazirjSOBpLeOFIWAQFearIDj(TvqENFFpkRmmDNlELiCANcttXNC<ControllerMap_Editor> P_0)
				{
					ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx2 = this.KsRUDYIKGinSuPlaNkPzGuZKYnx;
					ControllerMap_Editor JiPmnWqGoodLekCZtZTncBkMXVE = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS = this.KsRUDYIKGinSuPlaNkPzGuZKYnx.cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.categoryId);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS2 = slXEjUxuEBlCBCGMdQtEbqClyVl.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.layoutId);
					JiPmnWqGoodLekCZtZTncBkMXVE.categoryId = seHDmnQDiSDJHjaCctbegGkUHmxS?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					JiPmnWqGoodLekCZtZTncBkMXVE.layoutId = seHDmnQDiSDJHjaCctbegGkUHmxS2?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					for (int i = 0; i < JiPmnWqGoodLekCZtZTncBkMXVE.actionElementMaps.Count; i++)
					{
						ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx = this.KsRUDYIKGinSuPlaNkPzGuZKYnx;
						ActionElementMap MBcARPFZxLOnVPBiVwerBuGBaiQh = JiPmnWqGoodLekCZtZTncBkMXVE.actionElementMaps[i];
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS3 = this.KsRUDYIKGinSuPlaNkPzGuZKYnx.FvBmdXrivUPrVMcERZfhDmgEAfu.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId);
						MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId = seHDmnQDiSDJHjaCctbegGkUHmxS3?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
						MBcARPFZxLOnVPBiVwerBuGBaiQh._actionCategoryId = ((this.KsRUDYIKGinSuPlaNkPzGuZKYnx.ISkmsCiBKkbTqyKMaVIsLGGdKou.GetActionById(MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId) != null) ? this.KsRUDYIKGinSuPlaNkPzGuZKYnx.ISkmsCiBKkbTqyKMaVIsLGGdKou.GetActionById(MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId).categoryId : 0);
					}
					ControllerMap_Editor controllerMap_Editor;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						controllerMap_Editor = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
						ControllerMap_Editor controllerMap_Editor2 = JsonTools.Clone(JiPmnWqGoodLekCZtZTncBkMXVE);
						controllerMap_Editor2.actionElementMaps.Clear();
						Func<ActionElementMap, IList<ActionElementMap>, int> func = delegate(ActionElementMap P_0, IList<ActionElementMap> P_1)
						{
							for (int j = 0; j < P_1.Count; j++)
							{
								if (P_1[j]._elementIdentifierId == P_0._elementIdentifierId && P_1[j]._axisRange == P_0._axisRange && P_1[j]._axisContribution == P_0._axisContribution && P_1[j]._actionId == P_0._actionId)
								{
									return j;
								}
							}
							return -1;
						};
						BtQSnWhMZhgfMEqJthwNeWooLXH(controllerMap_Editor.actionElementMaps, JiPmnWqGoodLekCZtZTncBkMXVE.actionElementMaps, controllerMap_Editor2.actionElementMaps, func);
						JiPmnWqGoodLekCZtZTncBkMXVE = controllerMap_Editor2;
					}
					else
					{
						this.KsRUDYIKGinSuPlaNkPzGuZKYnx.ISkmsCiBKkbTqyKMaVIsLGGdKou.CreateJoystickMap(JiPmnWqGoodLekCZtZTncBkMXVE.categoryId, JiPmnWqGoodLekCZtZTncBkMXVE.hardwareGuid, JiPmnWqGoodLekCZtZTncBkMXVE.layoutId);
						controllerMap_Editor = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					JiPmnWqGoodLekCZtZTncBkMXVE.id = controllerMap_Editor.id;
					int index = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(controllerMap_Editor);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index] = JiPmnWqGoodLekCZtZTncBkMXVE;
					return JiPmnWqGoodLekCZtZTncBkMXVE;
				}

				private static int IIpenwZjvtFSdVEgjLLDwUIazKe(ActionElementMap P_0, IList<ActionElementMap> P_1)
				{
					for (int i = 0; i < P_1.Count; i++)
					{
						if (P_1[i]._elementIdentifierId == P_0._elementIdentifierId && P_1[i]._axisRange == P_0._axisRange && P_1[i]._axisContribution == P_0._axisContribution && P_1[i]._actionId == P_0._actionId)
						{
							return i;
						}
					}
					return -1;
				}
			}

			[CompilerGenerated]
			private sealed class PRfeHXcmAyuBLUvWilkwDKYXkmg
			{
				private sealed class SBPwtZafnjhLNBvtrLKYsmbMsBK
				{
					public PRfeHXcmAyuBLUvWilkwDKYXkmg bpmbTmooQnHXmDfYOxXyrinrTKc;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public ControllerMap_Editor mAGYPlguIQeCUGOuYjJmhKPdaLH;

					public bool oirdLqzMfHKLAUdYaJjrXgKLCNJ(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == mAGYPlguIQeCUGOuYjJmhKPdaLH.customControllerUid;
					}

					public bool LudVezXfvOUXuKbfIemvXZogonA(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == mAGYPlguIQeCUGOuYjJmhKPdaLH.categoryId;
					}

					public bool cgabVeDVarlbLBPLgQYuctbuRJUs(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == mAGYPlguIQeCUGOuYjJmhKPdaLH.layoutId;
					}
				}

				private sealed class tDVYltIcEqNGWZHyBveBySsFfmBg
				{
					public PRfeHXcmAyuBLUvWilkwDKYXkmg bpmbTmooQnHXmDfYOxXyrinrTKc;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public ControllerMap_Editor JiPmnWqGoodLekCZtZTncBkMXVE;

					public TvqENFFpkRmmDNlELiCANcttXNC<ControllerMap_Editor> AqUzabFqyYiDcxoRQCjXJaYBGeti;

					public bool nzeDgSKQzZMXOwMfJBYhufPwPyX(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.customControllerUid;
					}

					public bool bzZxRGNKDYiAZGtQaqMnLawtNTR(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.categoryId;
					}

					public bool DrZHOMdJNsMdIsukbTIYSfqGQzn(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.layoutId;
					}
				}

				private sealed class VSNYbyggqBpKHDAspTeLDTYqSBh
				{
					public tDVYltIcEqNGWZHyBveBySsFfmBg PXBfeCIyNybpxZgErDdQBvCoXHL;

					public PRfeHXcmAyuBLUvWilkwDKYXkmg bpmbTmooQnHXmDfYOxXyrinrTKc;

					public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

					public ActionElementMap MBcARPFZxLOnVPBiVwerBuGBaiQh;

					public bool cSKHnGgdiXbsqWWvqprqsNpcRxp(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
					{
						return P_0.get_Item(PXBfeCIyNybpxZgErDdQBvCoXHL.AqUzabFqyYiDcxoRQCjXJaYBGeti.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId;
					}
				}

				public ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx;

				public List<seHDmnQDiSDJHjaCctbegGkUHmxS> slXEjUxuEBlCBCGMdQtEbqClyVl;

				private static Func<ActionElementMap, IList<ActionElementMap>, int> sJIvWkSoeTgVksZRzkoMlFHjDUC;

				public int WSUPvYkMEYtsOACqTbQqbzbrybT(ControllerMap_Editor P_0, IList<ControllerMap_Editor> P_1)
				{
					ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx = this.KsRUDYIKGinSuPlaNkPzGuZKYnx;
					for (int i = 0; i < P_1.Count; i++)
					{
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS = this.KsRUDYIKGinSuPlaNkPzGuZKYnx.ThtlaBGRMCFRogauOlyIPRCOlTJc.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.customControllerUid);
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS2 = this.KsRUDYIKGinSuPlaNkPzGuZKYnx.cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.categoryId);
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS3 = slXEjUxuEBlCBCGMdQtEbqClyVl.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.layoutId);
						if (seHDmnQDiSDJHjaCctbegGkUHmxS != null && seHDmnQDiSDJHjaCctbegGkUHmxS.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[i].customControllerUid && seHDmnQDiSDJHjaCctbegGkUHmxS2 != null && seHDmnQDiSDJHjaCctbegGkUHmxS2.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[i].categoryId && seHDmnQDiSDJHjaCctbegGkUHmxS3 != null && seHDmnQDiSDJHjaCctbegGkUHmxS3.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[i].layoutId)
						{
							return i;
						}
					}
					return -1;
				}

				public ControllerMap_Editor wqXbbiioZafkfCUTAKatvfMRoSHK(TvqENFFpkRmmDNlELiCANcttXNC<ControllerMap_Editor> P_0)
				{
					ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx2 = this.KsRUDYIKGinSuPlaNkPzGuZKYnx;
					ControllerMap_Editor JiPmnWqGoodLekCZtZTncBkMXVE = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS = this.KsRUDYIKGinSuPlaNkPzGuZKYnx.ThtlaBGRMCFRogauOlyIPRCOlTJc.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.customControllerUid);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS2 = this.KsRUDYIKGinSuPlaNkPzGuZKYnx.cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.categoryId);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS3 = slXEjUxuEBlCBCGMdQtEbqClyVl.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.layoutId);
					JiPmnWqGoodLekCZtZTncBkMXVE.customControllerUid = seHDmnQDiSDJHjaCctbegGkUHmxS?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					JiPmnWqGoodLekCZtZTncBkMXVE.categoryId = seHDmnQDiSDJHjaCctbegGkUHmxS2?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					JiPmnWqGoodLekCZtZTncBkMXVE.layoutId = seHDmnQDiSDJHjaCctbegGkUHmxS3?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					for (int i = 0; i < JiPmnWqGoodLekCZtZTncBkMXVE.actionElementMaps.Count; i++)
					{
						ZEoOoaFFYglSmJQaAnzUXuVzUID KsRUDYIKGinSuPlaNkPzGuZKYnx = this.KsRUDYIKGinSuPlaNkPzGuZKYnx;
						ActionElementMap MBcARPFZxLOnVPBiVwerBuGBaiQh = JiPmnWqGoodLekCZtZTncBkMXVE.actionElementMaps[i];
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS4 = this.KsRUDYIKGinSuPlaNkPzGuZKYnx.FvBmdXrivUPrVMcERZfhDmgEAfu.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId);
						MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId = seHDmnQDiSDJHjaCctbegGkUHmxS4?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
						MBcARPFZxLOnVPBiVwerBuGBaiQh._actionCategoryId = ((this.KsRUDYIKGinSuPlaNkPzGuZKYnx.ISkmsCiBKkbTqyKMaVIsLGGdKou.GetActionById(MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId) != null) ? this.KsRUDYIKGinSuPlaNkPzGuZKYnx.ISkmsCiBKkbTqyKMaVIsLGGdKou.GetActionById(MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId).categoryId : 0);
					}
					ControllerMap_Editor controllerMap_Editor;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						controllerMap_Editor = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
						ControllerMap_Editor controllerMap_Editor2 = JsonTools.Clone(JiPmnWqGoodLekCZtZTncBkMXVE);
						controllerMap_Editor2.actionElementMaps.Clear();
						Func<ActionElementMap, IList<ActionElementMap>, int> func = delegate(ActionElementMap P_0, IList<ActionElementMap> P_1)
						{
							for (int j = 0; j < P_1.Count; j++)
							{
								if (P_1[j]._elementIdentifierId == P_0._elementIdentifierId && P_1[j]._axisRange == P_0._axisRange && P_1[j]._axisContribution == P_0._axisContribution && P_1[j]._actionId == P_0._actionId)
								{
									return j;
								}
							}
							return -1;
						};
						BtQSnWhMZhgfMEqJthwNeWooLXH(controllerMap_Editor.actionElementMaps, JiPmnWqGoodLekCZtZTncBkMXVE.actionElementMaps, controllerMap_Editor2.actionElementMaps, func);
						JiPmnWqGoodLekCZtZTncBkMXVE = controllerMap_Editor2;
					}
					else
					{
						this.KsRUDYIKGinSuPlaNkPzGuZKYnx.ISkmsCiBKkbTqyKMaVIsLGGdKou.CreateCustomControllerMap(JiPmnWqGoodLekCZtZTncBkMXVE.categoryId, JiPmnWqGoodLekCZtZTncBkMXVE.customControllerUid, JiPmnWqGoodLekCZtZTncBkMXVE.layoutId);
						controllerMap_Editor = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					JiPmnWqGoodLekCZtZTncBkMXVE.id = controllerMap_Editor.id;
					int index = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(controllerMap_Editor);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index] = JiPmnWqGoodLekCZtZTncBkMXVE;
					return JiPmnWqGoodLekCZtZTncBkMXVE;
				}

				private static int RYMuEZOQFrAdmpFwSagqgqTBPoC(ActionElementMap P_0, IList<ActionElementMap> P_1)
				{
					for (int i = 0; i < P_1.Count; i++)
					{
						if (P_1[i]._elementIdentifierId == P_0._elementIdentifierId && P_1[i]._axisRange == P_0._axisRange && P_1[i]._axisContribution == P_0._axisContribution && P_1[i]._actionId == P_0._actionId)
						{
							return i;
						}
					}
					return -1;
				}
			}

			[CompilerGenerated]
			private sealed class enVpTGsxIYTCwVSXZKSsfHNjfsB<T> where T : class
			{
				public Func<T, int> asFqYgSkhcabJijIvPFSwZLRKNY;
			}

			[CompilerGenerated]
			private sealed class iygMHmOpnloyxAWSnQrRMtGGquz<T> where T : class
			{
				public enVpTGsxIYTCwVSXZKSsfHNjfsB<T> dBJmXytkBDVfhKekjbVYCpCSxAKU;

				public T JiPmnWqGoodLekCZtZTncBkMXVE;

				public bool AJFlArpHHfBuIdQyAluYXHvaNixu(seHDmnQDiSDJHjaCctbegGkUHmxS P_0)
				{
					return P_0.ObhzDARdXnFTqWuCrmaAzeQjekX == dBJmXytkBDVfhKekjbVYCpCSxAKU.asFqYgSkhcabJijIvPFSwZLRKNY(JiPmnWqGoodLekCZtZTncBkMXVE);
				}
			}

			[CompilerGenerated]
			private static Func<InputCategory, int> XHbxTWrHgZFJnAGpZUfsKauASsO;

			[CompilerGenerated]
			private static Func<InputCategory, string> JtkJDNQWbWdcWWMWikYVmDfancJ;

			[CompilerGenerated]
			private static Func<InputCategory, IList<InputCategory>, int> MnpBMtsoSOGQEhrvMOUzkAgonQy;

			[CompilerGenerated]
			private static Func<InputBehavior, int> BQCfpSlKYtTUbxmRawUpJCrRNGc;

			[CompilerGenerated]
			private static Func<InputBehavior, string> dorilNuvpfaYZkBAAyhYBNyQdEJ;

			[CompilerGenerated]
			private static Func<InputBehavior, IList<InputBehavior>, int> yNDQlwgIhIHJXXCFuhxqyLcgfJc;

			[CompilerGenerated]
			private static Func<InputAction, int> pHyGttJpMUwOEPDuVCFZqfEnzBlK;

			[CompilerGenerated]
			private static Func<InputAction, string> cvDTNaMlWqYzoLzTOfEuAVjclob;

			[CompilerGenerated]
			private static Func<InputAction, IList<InputAction>, int> RmRSVCUgYkVdOtbWHKmGWkufBLo;

			[CompilerGenerated]
			private static Func<InputMapCategory, int> XBHcJJjOZIMWcvePCYiVjnOSXqt;

			[CompilerGenerated]
			private static Func<InputMapCategory, string> biWAcpscSQGMRjlyGcpVIUbYQDZ;

			[CompilerGenerated]
			private static Func<InputMapCategory, IList<InputMapCategory>, int> dLEDFjdlecIZupGAArOpjpUBTZFR;

			[CompilerGenerated]
			private static Func<InputLayout, int> PiMHGdQPWALSCrxSYgWENinzMll;

			[CompilerGenerated]
			private static Func<InputLayout, string> PMWhlaFPeZbfmecjhwlMVpQjogkh;

			[CompilerGenerated]
			private static Func<InputLayout, IList<InputLayout>, int> LoeFBBehkyxJqUgripvvBlbKJTQ;

			[CompilerGenerated]
			private static Func<InputLayout, int> rtfpWsRysYCTSEFmGmAlBoUFKlt;

			[CompilerGenerated]
			private static Func<InputLayout, string> IWihzKMoghvpvqhPhbnTaIQYIRF;

			[CompilerGenerated]
			private static Func<InputLayout, IList<InputLayout>, int> VXsZpVZCokNzlkfdPvpmJBfNtjH;

			[CompilerGenerated]
			private static Func<InputLayout, int> EtdBfztnTfaxFsXBJoGXaFimnSn;

			[CompilerGenerated]
			private static Func<InputLayout, string> BrVfUZBtVMPFpEqDJXvQuKXAGKKB;

			[CompilerGenerated]
			private static Func<InputLayout, IList<InputLayout>, int> xxYJMGvmxTCaPdDdNCwoNxTuHSr;

			[CompilerGenerated]
			private static Func<InputLayout, int> FnMiDJvZXbwsCIZpVdQXcyVyMjR;

			[CompilerGenerated]
			private static Func<InputLayout, string> NfYRnIsaZfWbdnPnCdNLheuZddDb;

			[CompilerGenerated]
			private static Func<InputLayout, IList<InputLayout>, int> NuxFNvueASsPfUdFXTZZetZNiFi;

			[CompilerGenerated]
			private static Func<CustomController_Editor, int> laJDOLQQwCAKUrQwzepnemPslDq;

			[CompilerGenerated]
			private static Func<CustomController_Editor, string> KHcOonUGNjJoyKzVKtIepwLXUtG;

			[CompilerGenerated]
			private static Func<CustomController_Editor, IList<CustomController_Editor>, int> lgFlyPhAHDdRfplWeIZSifXYoJQ;

			[CompilerGenerated]
			private static Func<ControllerMapLayoutManager_RuleSet_Editor, int> MjWVNKBLddrdyLwnYfInrtljUss;

			[CompilerGenerated]
			private static Func<ControllerMapLayoutManager_RuleSet_Editor, string> eGiTSwQADbAGEaBwalMPPlWCqzB;

			[CompilerGenerated]
			private static Func<ControllerMapLayoutManager_RuleSet_Editor, IList<ControllerMapLayoutManager_RuleSet_Editor>, int> agGOaqPHXwBAKbDUarsDIpHWVua;

			[CompilerGenerated]
			private static Func<ControllerMapEnabler_RuleSet_Editor, int> RfjFWEiWdbWNJNUcqnZpYQqncBb;

			[CompilerGenerated]
			private static Func<ControllerMapEnabler_RuleSet_Editor, string> yqtPnYynpRtQJZZtdzEvOhhSdUn;

			[CompilerGenerated]
			private static Func<ControllerMapEnabler_RuleSet_Editor, IList<ControllerMapEnabler_RuleSet_Editor>, int> ypTDmiMmymNadnKHFoVkHBUkmBL;

			[CompilerGenerated]
			private static Func<Player_Editor, int> OJFDzOJDveNnRAUAiAkGoPFoLKd;

			[CompilerGenerated]
			private static Func<Player_Editor, string> ifULubNjrkHnsImQHepLwooFQTi;

			[CompilerGenerated]
			private static Func<Player_Editor, IList<Player_Editor>, int> mzqtzpamKXpjcyTUNzMdBUbsGSX;

			[CompilerGenerated]
			private static Func<ControllerMap_Editor, int> ZOQWYrhHBaVaPqTCMtFyalmPQYa;

			[CompilerGenerated]
			private static Func<ControllerMap_Editor, string> xUYGbasnaRCYMaBQijMVNTsEiciW;

			[CompilerGenerated]
			private static Func<ControllerMap_Editor, int> IBqcszlAnnLCOzdiNnqBsjDwdSbi;

			[CompilerGenerated]
			private static Func<ControllerMap_Editor, string> mNAdjncXEVCmmGUayWetKsQldeMk;

			[CompilerGenerated]
			private static Func<ControllerMap_Editor, int> IOditGQByZxFvbiiOXGUpgnfTmF;

			[CompilerGenerated]
			private static Func<ControllerMap_Editor, string> ZTKrbadvvIuksRIAhYTvHGNiVPD;

			[CompilerGenerated]
			private static Func<ControllerMap_Editor, int> iOwOicynAlFbSnWFSDwpWmDUBQq;

			[CompilerGenerated]
			private static Func<ControllerMap_Editor, string> kwAufRpJomlGgYKrMdZxToqPtcY;

			public static UserData fXPhyUzKDetRtrRNdVKrqUJqTU(UserData P_0, UserData P_1, bool P_2)
			{
				if (P_0 == null)
				{
					throw new ArgumentNullException("orig");
				}
				P_0 = JsonTools.Clone(P_0);
				P_1 = ((P_1 != null) ? JsonTools.Clone(P_1) : null);
				UserData ISkmsCiBKkbTqyKMaVIsLGGdKou = (P_2 ? P_0 : new UserData(init: false));
				if (P_1 != null)
				{
					ISkmsCiBKkbTqyKMaVIsLGGdKou.configVars = JsonTools.Clone(P_1.configVars);
				}
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> BFATZkUfJYyobLRHQKsfbmzIzA = new List<seHDmnQDiSDJHjaCctbegGkUHmxS>();
				eSZCXboJyWyObXCGrOzViBIscQge("Action Category", P_0.actionCategories, P_1?.actionCategories, ISkmsCiBKkbTqyKMaVIsLGGdKou.actionCategories, P_2, BFATZkUfJYyobLRHQKsfbmzIzA, (InputCategory P_0) => P_0.id, (InputCategory P_0) => P_0.name, delegate(InputCategory P_0, IList<InputCategory> P_1)
				{
					for (int num45 = 0; num45 < P_1.Count; num45++)
					{
						if (string.Equals(P_0.name, P_1[num45].name, StringComparison.OrdinalIgnoreCase))
						{
							return num45;
						}
					}
					return -1;
				}, delegate(TvqENFFpkRmmDNlELiCANcttXNC<InputCategory> P_0)
				{
					InputCategory inputCategory = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					InputCategory inputCategory2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						inputCategory2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddActionCategory();
						inputCategory2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					inputCategory.id = inputCategory2.id;
					int index16 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(inputCategory2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index16] = inputCategory;
					return inputCategory;
				});
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> TJuoMRxpswmkeejUEZODiyLUCWc = new List<seHDmnQDiSDJHjaCctbegGkUHmxS>();
				eSZCXboJyWyObXCGrOzViBIscQge("Input Behavior", P_0.inputBehaviors, P_1?.inputBehaviors, ISkmsCiBKkbTqyKMaVIsLGGdKou.inputBehaviors, P_2, TJuoMRxpswmkeejUEZODiyLUCWc, (InputBehavior P_0) => P_0.id, (InputBehavior P_0) => P_0.name, delegate(InputBehavior P_0, IList<InputBehavior> P_1)
				{
					for (int num44 = 0; num44 < P_1.Count; num44++)
					{
						if (string.Equals(P_0.name, P_1[num44].name, StringComparison.OrdinalIgnoreCase))
						{
							return num44;
						}
					}
					return -1;
				}, delegate(TvqENFFpkRmmDNlELiCANcttXNC<InputBehavior> P_0)
				{
					InputBehavior inputBehavior = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					InputBehavior inputBehavior2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						inputBehavior2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddInputBehavior();
						inputBehavior2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					inputBehavior.id = inputBehavior2.id;
					int index15 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(inputBehavior2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index15] = inputBehavior;
					return inputBehavior;
				});
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> FvBmdXrivUPrVMcERZfhDmgEAfu = new List<seHDmnQDiSDJHjaCctbegGkUHmxS>();
				eSZCXboJyWyObXCGrOzViBIscQge("Action", P_0.actions, P_1?.actions, ISkmsCiBKkbTqyKMaVIsLGGdKou.actions, P_2, FvBmdXrivUPrVMcERZfhDmgEAfu, (InputAction P_0) => P_0.id, (InputAction P_0) => P_0.name, delegate(InputAction P_0, IList<InputAction> P_1)
				{
					for (int num43 = 0; num43 < P_1.Count; num43++)
					{
						if (string.Equals(P_0.name, P_1[num43].name, StringComparison.OrdinalIgnoreCase))
						{
							return num43;
						}
					}
					return -1;
				}, delegate(TvqENFFpkRmmDNlELiCANcttXNC<InputAction> P_0)
				{
					InputAction inputAction = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					int num42 = BFATZkUfJYyobLRHQKsfbmzIzA.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == P_0.PVvlSNRPruvLEyIUzSxfxpMFpze.categoryId)?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? 0;
					InputAction inputAction2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						inputAction2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddAction(num42);
						inputAction2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					int behaviorId = TJuoMRxpswmkeejUEZODiyLUCWc.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == P_0.PVvlSNRPruvLEyIUzSxfxpMFpze.behaviorId)?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? 0;
					inputAction.id = inputAction2.id;
					if (num42 != inputAction2.categoryId)
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.ChangeActionCategory(inputAction2.id, num42);
					}
					inputAction.categoryId = num42;
					inputAction.behaviorId = behaviorId;
					int index14 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(inputAction2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index14] = inputAction;
					return inputAction;
				});
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> cVBBEuktBkOWrDrCaQmPzhAlYoHZ = new List<seHDmnQDiSDJHjaCctbegGkUHmxS>();
				List<int> hZViYPIaaIHQrsYUWlcWOIpKjpO = new List<int>();
				eSZCXboJyWyObXCGrOzViBIscQge("Map Category", P_0.mapCategories, P_1?.mapCategories, ISkmsCiBKkbTqyKMaVIsLGGdKou.mapCategories, P_2, cVBBEuktBkOWrDrCaQmPzhAlYoHZ, (InputMapCategory P_0) => P_0.id, (InputMapCategory P_0) => P_0.name, delegate(InputMapCategory P_0, IList<InputMapCategory> P_1)
				{
					for (int num41 = 0; num41 < P_1.Count; num41++)
					{
						if (string.Equals(P_0.name, P_1[num41].name, StringComparison.OrdinalIgnoreCase))
						{
							return num41;
						}
					}
					return -1;
				}, delegate(TvqENFFpkRmmDNlELiCANcttXNC<InputMapCategory> P_0)
				{
					InputMapCategory inputMapCategory2 = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					InputMapCategory inputMapCategory3;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						inputMapCategory3 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddMapCategory();
						inputMapCategory3 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					int num40 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(inputMapCategory3);
					if (P_0.RhgqvxXeeAEVXiOSSbokhAXrufD == seHDmnQDiSDJHjaCctbegGkUHmxS.QwrRblAujsoBkXHpojAgfhfypRSY.fvgSwEWVuLHXjsLhgRfQoPYMDsc)
					{
						hZViYPIaaIHQrsYUWlcWOIpKjpO.Add(num40);
					}
					inputMapCategory2.id = inputMapCategory3.id;
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[num40] = inputMapCategory2;
					return inputMapCategory2;
				});
				for (int i = 0; i < hZViYPIaaIHQrsYUWlcWOIpKjpO.Count; i++)
				{
					int index = hZViYPIaaIHQrsYUWlcWOIpKjpO[i];
					InputMapCategory inputMapCategory = ISkmsCiBKkbTqyKMaVIsLGGdKou.mapCategories[index];
					for (int j = 0; j < inputMapCategory.checkConflictsCategoryIds_orig.Count; j++)
					{
						int fvgSwEWVuLHXjsLhgRfQoPYMDsc = inputMapCategory.checkConflictsCategoryIds_orig[j];
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS = cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == fvgSwEWVuLHXjsLhgRfQoPYMDsc);
						inputMapCategory.checkConflictsCategoryIds_orig[j] = seHDmnQDiSDJHjaCctbegGkUHmxS?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					}
				}
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> ImfhhosyZPGUuICCnQBGgequFmP = new List<seHDmnQDiSDJHjaCctbegGkUHmxS>();
				eSZCXboJyWyObXCGrOzViBIscQge("Keyboard Layout", P_0.keyboardLayouts, P_1?.keyboardLayouts, ISkmsCiBKkbTqyKMaVIsLGGdKou.keyboardLayouts, P_2, ImfhhosyZPGUuICCnQBGgequFmP, (InputLayout P_0) => P_0.id, (InputLayout P_0) => P_0.name, delegate(InputLayout P_0, IList<InputLayout> P_1)
				{
					for (int num39 = 0; num39 < P_1.Count; num39++)
					{
						if (string.Equals(P_0.name, P_1[num39].name, StringComparison.OrdinalIgnoreCase))
						{
							return num39;
						}
					}
					return -1;
				}, delegate(TvqENFFpkRmmDNlELiCANcttXNC<InputLayout> P_0)
				{
					InputLayout inputLayout7 = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					InputLayout inputLayout8;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						inputLayout8 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddKeyboardLayout();
						inputLayout8 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					inputLayout7.id = inputLayout8.id;
					int index13 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(inputLayout8);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index13] = inputLayout7;
					return inputLayout7;
				});
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> KYKflSZZfZevcykUTKJaEeIaARh = new List<seHDmnQDiSDJHjaCctbegGkUHmxS>();
				eSZCXboJyWyObXCGrOzViBIscQge("Mouse Layout", P_0.mouseLayouts, P_1?.mouseLayouts, ISkmsCiBKkbTqyKMaVIsLGGdKou.mouseLayouts, P_2, KYKflSZZfZevcykUTKJaEeIaARh, (InputLayout P_0) => P_0.id, (InputLayout P_0) => P_0.name, delegate(InputLayout P_0, IList<InputLayout> P_1)
				{
					for (int num38 = 0; num38 < P_1.Count; num38++)
					{
						if (string.Equals(P_0.name, P_1[num38].name, StringComparison.OrdinalIgnoreCase))
						{
							return num38;
						}
					}
					return -1;
				}, delegate(TvqENFFpkRmmDNlELiCANcttXNC<InputLayout> P_0)
				{
					InputLayout inputLayout5 = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					InputLayout inputLayout6;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						inputLayout6 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddMouseLayout();
						inputLayout6 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					inputLayout5.id = inputLayout6.id;
					int index12 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(inputLayout6);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index12] = inputLayout5;
					return inputLayout5;
				});
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> obQUneKGVKRwAuEgsOBHNFFqvN = new List<seHDmnQDiSDJHjaCctbegGkUHmxS>();
				eSZCXboJyWyObXCGrOzViBIscQge("Joystick Layout", P_0.joystickLayouts, P_1?.joystickLayouts, ISkmsCiBKkbTqyKMaVIsLGGdKou.joystickLayouts, P_2, obQUneKGVKRwAuEgsOBHNFFqvN, (InputLayout P_0) => P_0.id, (InputLayout P_0) => P_0.name, delegate(InputLayout P_0, IList<InputLayout> P_1)
				{
					for (int num37 = 0; num37 < P_1.Count; num37++)
					{
						if (string.Equals(P_0.name, P_1[num37].name, StringComparison.OrdinalIgnoreCase))
						{
							return num37;
						}
					}
					return -1;
				}, delegate(TvqENFFpkRmmDNlELiCANcttXNC<InputLayout> P_0)
				{
					InputLayout inputLayout3 = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					InputLayout inputLayout4;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						inputLayout4 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddJoystickLayout();
						inputLayout4 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					inputLayout3.id = inputLayout4.id;
					int index11 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(inputLayout4);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index11] = inputLayout3;
					return inputLayout3;
				});
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> lZusqqfJCZMAaPRIgYfBRHXKoCV = new List<seHDmnQDiSDJHjaCctbegGkUHmxS>();
				eSZCXboJyWyObXCGrOzViBIscQge("Custom Controller Layout", P_0.customControllerLayouts, P_1?.customControllerLayouts, ISkmsCiBKkbTqyKMaVIsLGGdKou.customControllerLayouts, P_2, lZusqqfJCZMAaPRIgYfBRHXKoCV, (InputLayout P_0) => P_0.id, (InputLayout P_0) => P_0.name, delegate(InputLayout P_0, IList<InputLayout> P_1)
				{
					for (int num36 = 0; num36 < P_1.Count; num36++)
					{
						if (string.Equals(P_0.name, P_1[num36].name, StringComparison.OrdinalIgnoreCase))
						{
							return num36;
						}
					}
					return -1;
				}, delegate(TvqENFFpkRmmDNlELiCANcttXNC<InputLayout> P_0)
				{
					InputLayout inputLayout = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					InputLayout inputLayout2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						inputLayout2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddCustomControllerLayout();
						inputLayout2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					inputLayout.id = inputLayout2.id;
					int index10 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(inputLayout2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index10] = inputLayout;
					return inputLayout;
				});
				Func<ControllerType, List<seHDmnQDiSDJHjaCctbegGkUHmxS>> zCKVbQcyWNLZSQaDOcIAizCoeoN = (ControllerType P_0) => P_0 switch
				{
					ControllerType.Keyboard => ImfhhosyZPGUuICCnQBGgequFmP, 
					ControllerType.Mouse => KYKflSZZfZevcykUTKJaEeIaARh, 
					ControllerType.Joystick => obQUneKGVKRwAuEgsOBHNFFqvN, 
					ControllerType.Custom => lZusqqfJCZMAaPRIgYfBRHXKoCV, 
					_ => throw new NotImplementedException(), 
				};
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> ThtlaBGRMCFRogauOlyIPRCOlTJc = new List<seHDmnQDiSDJHjaCctbegGkUHmxS>();
				eSZCXboJyWyObXCGrOzViBIscQge("Custom Controller", P_0.customControllers, P_1?.customControllers, ISkmsCiBKkbTqyKMaVIsLGGdKou.customControllers, P_2, ThtlaBGRMCFRogauOlyIPRCOlTJc, (CustomController_Editor P_0) => P_0.id, (CustomController_Editor P_0) => P_0.name, delegate(CustomController_Editor P_0, IList<CustomController_Editor> P_1)
				{
					for (int num35 = 0; num35 < P_1.Count; num35++)
					{
						if (string.Equals(P_0.name, P_1[num35].name, StringComparison.OrdinalIgnoreCase))
						{
							return num35;
						}
					}
					return -1;
				}, delegate(TvqENFFpkRmmDNlELiCANcttXNC<CustomController_Editor> P_0)
				{
					CustomController_Editor customController_Editor = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					CustomController_Editor customController_Editor2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						customController_Editor2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddCustomController();
						customController_Editor2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					customController_Editor.id = customController_Editor2.id;
					int index9 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(customController_Editor2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index9] = customController_Editor;
					return customController_Editor;
				});
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> YrFefFuZWCNFTmaYdepBBkFhEFDy = new List<seHDmnQDiSDJHjaCctbegGkUHmxS>();
				eSZCXboJyWyObXCGrOzViBIscQge("Layout Manager Set", P_0.controllerMapLayoutManagerRuleSets, P_1?.controllerMapLayoutManagerRuleSets, ISkmsCiBKkbTqyKMaVIsLGGdKou.controllerMapLayoutManagerRuleSets, P_2, YrFefFuZWCNFTmaYdepBBkFhEFDy, (ControllerMapLayoutManager_RuleSet_Editor P_0) => P_0.id, (ControllerMapLayoutManager_RuleSet_Editor P_0) => P_0.name, delegate(ControllerMapLayoutManager_RuleSet_Editor P_0, IList<ControllerMapLayoutManager_RuleSet_Editor> P_1)
				{
					for (int num34 = 0; num34 < P_1.Count; num34++)
					{
						if (string.Equals(P_0.name, P_1[num34].name, StringComparison.OrdinalIgnoreCase))
						{
							return num34;
						}
					}
					return -1;
				}, delegate(TvqENFFpkRmmDNlELiCANcttXNC<ControllerMapLayoutManager_RuleSet_Editor> P_0)
				{
					ControllerMapLayoutManager_RuleSet_Editor controllerMapLayoutManager_RuleSet_Editor = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					int num26 = ((controllerMapLayoutManager_RuleSet_Editor.rules != null) ? controllerMapLayoutManager_RuleSet_Editor.rules.Count : 0);
					for (int num27 = 0; num27 < num26; num27++)
					{
						ControllerMapLayoutManager_Rule_Editor controllerMapLayoutManager_Rule_Editor = controllerMapLayoutManager_RuleSet_Editor.rules[num27];
						if (controllerMapLayoutManager_Rule_Editor != null && controllerMapLayoutManager_Rule_Editor.categoryIds != null)
						{
							List<int> list12 = new List<int>();
							int num28 = ((controllerMapLayoutManager_Rule_Editor.categoryIds != null) ? controllerMapLayoutManager_Rule_Editor.categoryIds.Count : 0);
							for (int num29 = 0; num29 < num28; num29++)
							{
								int mWfxAMqKkxVJbPVWQZjasJUDDZX6 = controllerMapLayoutManager_Rule_Editor.categoryIds[num29];
								seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS31 = cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX6);
								if (seHDmnQDiSDJHjaCctbegGkUHmxS31 == null)
								{
									Logger.LogError("No new Map Category Id found for old id: " + mWfxAMqKkxVJbPVWQZjasJUDDZX6);
								}
								else
								{
									list12.Add(seHDmnQDiSDJHjaCctbegGkUHmxS31.ObhzDARdXnFTqWuCrmaAzeQjekX);
								}
							}
							controllerMapLayoutManager_Rule_Editor.categoryIds = list12;
						}
					}
					int num30 = ((controllerMapLayoutManager_RuleSet_Editor.rules != null) ? controllerMapLayoutManager_RuleSet_Editor.rules.Count : 0);
					for (int num31 = 0; num31 < num30; num31++)
					{
						ControllerMapLayoutManager_Rule_Editor controllerMapLayoutManager_Rule_Editor2 = controllerMapLayoutManager_RuleSet_Editor.rules[num31];
						if (controllerMapLayoutManager_Rule_Editor2 != null && controllerMapLayoutManager_Rule_Editor2.layoutId > 0)
						{
							ControllerType controllerType3 = controllerMapLayoutManager_Rule_Editor2.controllerSetSelector.controllerType;
							List<seHDmnQDiSDJHjaCctbegGkUHmxS> list13 = zCKVbQcyWNLZSQaDOcIAizCoeoN(controllerType3);
							int mWfxAMqKkxVJbPVWQZjasJUDDZX5 = controllerMapLayoutManager_Rule_Editor2.layoutId;
							seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS32 = list13.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX5);
							if (seHDmnQDiSDJHjaCctbegGkUHmxS32 == null)
							{
								controllerMapLayoutManager_Rule_Editor2.layoutId = -1;
								Logger.LogError(string.Concat("No new ", controllerType3, " Layout Id found for old id: ", mWfxAMqKkxVJbPVWQZjasJUDDZX5));
							}
							else
							{
								controllerMapLayoutManager_Rule_Editor2.layoutId = seHDmnQDiSDJHjaCctbegGkUHmxS32.ObhzDARdXnFTqWuCrmaAzeQjekX;
							}
						}
					}
					int num32 = ((controllerMapLayoutManager_RuleSet_Editor.rules != null) ? controllerMapLayoutManager_RuleSet_Editor.rules.Count : 0);
					for (int num33 = 0; num33 < num32; num33++)
					{
						ControllerMapLayoutManager_Rule_Editor controllerMapLayoutManager_Rule_Editor3 = controllerMapLayoutManager_RuleSet_Editor.rules[num33];
						if (controllerMapLayoutManager_Rule_Editor3 != null && controllerMapLayoutManager_Rule_Editor3.controllerSetSelector != null)
						{
							ControllerType controllerType4 = controllerMapLayoutManager_Rule_Editor3.controllerSetSelector.controllerType;
							if (controllerType4 == ControllerType.Custom)
							{
								List<seHDmnQDiSDJHjaCctbegGkUHmxS> list14 = ThtlaBGRMCFRogauOlyIPRCOlTJc;
								int mWfxAMqKkxVJbPVWQZjasJUDDZX4 = controllerMapLayoutManager_Rule_Editor3.controllerSetSelector.customControllerSourceId;
								seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS33 = list14.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX4);
								if (seHDmnQDiSDJHjaCctbegGkUHmxS33 == null)
								{
									controllerMapLayoutManager_Rule_Editor3.controllerSetSelector.customControllerSourceId = -1;
									Logger.LogError("No new Custom Controller found for old id: " + mWfxAMqKkxVJbPVWQZjasJUDDZX4);
								}
								else
								{
									controllerMapLayoutManager_Rule_Editor3.controllerSetSelector.customControllerSourceId = seHDmnQDiSDJHjaCctbegGkUHmxS33.ObhzDARdXnFTqWuCrmaAzeQjekX;
								}
							}
						}
					}
					ControllerMapLayoutManager_RuleSet_Editor controllerMapLayoutManager_RuleSet_Editor2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						controllerMapLayoutManager_RuleSet_Editor2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddControllerMapLayoutManagerRuleSet();
						controllerMapLayoutManager_RuleSet_Editor2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					controllerMapLayoutManager_RuleSet_Editor.id = controllerMapLayoutManager_RuleSet_Editor2.id;
					int index8 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(controllerMapLayoutManager_RuleSet_Editor2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index8] = controllerMapLayoutManager_RuleSet_Editor;
					return controllerMapLayoutManager_RuleSet_Editor;
				});
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> VgpexWuHCaEqigdtrycAfddzsFP = new List<seHDmnQDiSDJHjaCctbegGkUHmxS>();
				eSZCXboJyWyObXCGrOzViBIscQge("Controller Map Enabler Set", P_0.controllerMapEnablerRuleSets, P_1?.controllerMapEnablerRuleSets, ISkmsCiBKkbTqyKMaVIsLGGdKou.controllerMapEnablerRuleSets, P_2, VgpexWuHCaEqigdtrycAfddzsFP, (ControllerMapEnabler_RuleSet_Editor P_0) => P_0.id, (ControllerMapEnabler_RuleSet_Editor P_0) => P_0.name, delegate(ControllerMapEnabler_RuleSet_Editor P_0, IList<ControllerMapEnabler_RuleSet_Editor> P_1)
				{
					for (int num25 = 0; num25 < P_1.Count; num25++)
					{
						if (string.Equals(P_0.name, P_1[num25].name, StringComparison.OrdinalIgnoreCase))
						{
							return num25;
						}
					}
					return -1;
				}, delegate(TvqENFFpkRmmDNlELiCANcttXNC<ControllerMapEnabler_RuleSet_Editor> P_0)
				{
					ControllerMapEnabler_RuleSet_Editor controllerMapEnabler_RuleSet_Editor = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					int num16 = ((controllerMapEnabler_RuleSet_Editor.rules != null) ? controllerMapEnabler_RuleSet_Editor.rules.Count : 0);
					for (int num17 = 0; num17 < num16; num17++)
					{
						ControllerMapEnabler_Rule_Editor controllerMapEnabler_Rule_Editor = controllerMapEnabler_RuleSet_Editor.rules[num17];
						if (controllerMapEnabler_Rule_Editor != null && controllerMapEnabler_Rule_Editor.categoryIds != null)
						{
							List<int> list8 = new List<int>();
							for (int num18 = 0; num18 < controllerMapEnabler_Rule_Editor.categoryIds.Count; num18++)
							{
								int mWfxAMqKkxVJbPVWQZjasJUDDZX3 = controllerMapEnabler_Rule_Editor.categoryIds[num18];
								seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS28 = cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX3);
								if (seHDmnQDiSDJHjaCctbegGkUHmxS28 == null)
								{
									Logger.LogError("No new Map Category Id found for old id: " + mWfxAMqKkxVJbPVWQZjasJUDDZX3);
								}
								else
								{
									list8.Add(seHDmnQDiSDJHjaCctbegGkUHmxS28.ObhzDARdXnFTqWuCrmaAzeQjekX);
								}
							}
							controllerMapEnabler_Rule_Editor.categoryIds = list8;
						}
					}
					int num19 = ((controllerMapEnabler_RuleSet_Editor.rules != null) ? controllerMapEnabler_RuleSet_Editor.rules.Count : 0);
					for (int num20 = 0; num20 < num19; num20++)
					{
						ControllerMapEnabler_Rule_Editor controllerMapEnabler_Rule_Editor2 = controllerMapEnabler_RuleSet_Editor.rules[num20];
						if (controllerMapEnabler_Rule_Editor2 != null && controllerMapEnabler_Rule_Editor2.layoutIds != null)
						{
							ControllerType controllerType = controllerMapEnabler_Rule_Editor2.controllerSetSelector.controllerType;
							List<seHDmnQDiSDJHjaCctbegGkUHmxS> list9 = zCKVbQcyWNLZSQaDOcIAizCoeoN(controllerType);
							List<int> list10 = new List<int>();
							int num21 = ((controllerMapEnabler_Rule_Editor2.layoutIds != null) ? controllerMapEnabler_Rule_Editor2.layoutIds.Count : 0);
							for (int num22 = 0; num22 < num21; num22++)
							{
								int mWfxAMqKkxVJbPVWQZjasJUDDZX2 = controllerMapEnabler_Rule_Editor2.layoutIds[num22];
								seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS29 = list9.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX2);
								if (seHDmnQDiSDJHjaCctbegGkUHmxS29 == null)
								{
									Logger.LogError(string.Concat("No new ", controllerType, " Layout Id found for old id: ", mWfxAMqKkxVJbPVWQZjasJUDDZX2));
								}
								else
								{
									list10.Add(seHDmnQDiSDJHjaCctbegGkUHmxS29.ObhzDARdXnFTqWuCrmaAzeQjekX);
								}
							}
							controllerMapEnabler_Rule_Editor2.layoutIds = list10;
						}
					}
					int num23 = ((controllerMapEnabler_RuleSet_Editor.rules != null) ? controllerMapEnabler_RuleSet_Editor.rules.Count : 0);
					for (int num24 = 0; num24 < num23; num24++)
					{
						ControllerMapEnabler_Rule_Editor controllerMapEnabler_Rule_Editor3 = controllerMapEnabler_RuleSet_Editor.rules[num24];
						if (controllerMapEnabler_Rule_Editor3 != null && controllerMapEnabler_Rule_Editor3.controllerSetSelector != null)
						{
							ControllerType controllerType2 = controllerMapEnabler_Rule_Editor3.controllerSetSelector.controllerType;
							if (controllerType2 == ControllerType.Custom)
							{
								List<seHDmnQDiSDJHjaCctbegGkUHmxS> list11 = ThtlaBGRMCFRogauOlyIPRCOlTJc;
								int mWfxAMqKkxVJbPVWQZjasJUDDZX = controllerMapEnabler_Rule_Editor3.controllerSetSelector.customControllerSourceId;
								seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS30 = list11.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == mWfxAMqKkxVJbPVWQZjasJUDDZX);
								if (seHDmnQDiSDJHjaCctbegGkUHmxS30 == null)
								{
									controllerMapEnabler_Rule_Editor3.controllerSetSelector.customControllerSourceId = -1;
									Logger.LogError("No new Custom Controller found for old id: " + mWfxAMqKkxVJbPVWQZjasJUDDZX);
								}
								else
								{
									controllerMapEnabler_Rule_Editor3.controllerSetSelector.customControllerSourceId = seHDmnQDiSDJHjaCctbegGkUHmxS30.ObhzDARdXnFTqWuCrmaAzeQjekX;
								}
							}
						}
					}
					ControllerMapEnabler_RuleSet_Editor controllerMapEnabler_RuleSet_Editor2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						controllerMapEnabler_RuleSet_Editor2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddControllerMapEnablerRuleSet();
						controllerMapEnabler_RuleSet_Editor2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					controllerMapEnabler_RuleSet_Editor.id = controllerMapEnabler_RuleSet_Editor2.id;
					int index7 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(controllerMapEnabler_RuleSet_Editor2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index7] = controllerMapEnabler_RuleSet_Editor;
					return controllerMapEnabler_RuleSet_Editor;
				});
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> list = new List<seHDmnQDiSDJHjaCctbegGkUHmxS>();
				eSZCXboJyWyObXCGrOzViBIscQge("Player", P_0.players, P_1?.players, ISkmsCiBKkbTqyKMaVIsLGGdKou.players, P_2, list, (Player_Editor P_0) => P_0.id, (Player_Editor P_0) => P_0.name, delegate(Player_Editor P_0, IList<Player_Editor> P_1)
				{
					for (int num15 = 0; num15 < P_1.Count; num15++)
					{
						if (string.Equals(P_0.name, P_1[num15].name, StringComparison.OrdinalIgnoreCase))
						{
							return num15;
						}
					}
					return -1;
				}, delegate(TvqENFFpkRmmDNlELiCANcttXNC<Player_Editor> P_0)
				{
					Player_Editor player_Editor = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					Action<List<Player_Editor.Mapping>, List<seHDmnQDiSDJHjaCctbegGkUHmxS>> action = delegate(List<Player_Editor.Mapping> P_0, List<seHDmnQDiSDJHjaCctbegGkUHmxS> P_1)
					{
						for (int num14 = 0; num14 < P_0.Count; num14++)
						{
							Player_Editor.Mapping MBcARPFZxLOnVPBiVwerBuGBaiQh5 = P_0[num14];
							seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS27 = cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh5.categoryId);
							MBcARPFZxLOnVPBiVwerBuGBaiQh5.categoryId = seHDmnQDiSDJHjaCctbegGkUHmxS27?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
							seHDmnQDiSDJHjaCctbegGkUHmxS27 = P_1.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh5.layoutId);
							MBcARPFZxLOnVPBiVwerBuGBaiQh5.layoutId = seHDmnQDiSDJHjaCctbegGkUHmxS27?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
						}
					};
					action(player_Editor.defaultKeyboardMaps, ImfhhosyZPGUuICCnQBGgequFmP);
					action(player_Editor.defaultMouseMaps, KYKflSZZfZevcykUTKJaEeIaARh);
					action(player_Editor.defaultJoystickMaps, obQUneKGVKRwAuEgsOBHNFFqvN);
					action(player_Editor.defaultCustomControllerMaps, lZusqqfJCZMAaPRIgYfBRHXKoCV);
					for (int num9 = 0; num9 < player_Editor.startingCustomControllers.Count; num9++)
					{
						Player_Editor.CreateControllerInfo mAGYPlguIQeCUGOuYjJmhKPdaLH = player_Editor.startingCustomControllers[num9];
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS24 = ThtlaBGRMCFRogauOlyIPRCOlTJc.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == mAGYPlguIQeCUGOuYjJmhKPdaLH.sourceId);
						mAGYPlguIQeCUGOuYjJmhKPdaLH.sourceId = seHDmnQDiSDJHjaCctbegGkUHmxS24?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					}
					List<Player_Editor.RuleSetMapping> list6 = new List<Player_Editor.RuleSetMapping>();
					List<Player_Editor.RuleSetMapping> ruleSets = player_Editor.controllerMapLayoutManagerSettings.ruleSets;
					for (int num10 = 0; num10 < ruleSets.Count; num10++)
					{
						Player_Editor.RuleSetMapping ruleSetMapping = ruleSets[num10];
						if (ruleSetMapping != null)
						{
							int BlZsUkOGPQDnwzRAzcAFtbBWDaNH2 = ruleSetMapping.id;
							seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS25 = YrFefFuZWCNFTmaYdepBBkFhEFDy.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == BlZsUkOGPQDnwzRAzcAFtbBWDaNH2);
							if (seHDmnQDiSDJHjaCctbegGkUHmxS25 == null)
							{
								Logger.LogError("No new Controller Map Layout Manager Set found for old id: " + BlZsUkOGPQDnwzRAzcAFtbBWDaNH2);
							}
							else
							{
								ruleSetMapping = ruleSetMapping.Clone();
								ruleSetMapping.id = seHDmnQDiSDJHjaCctbegGkUHmxS25.ObhzDARdXnFTqWuCrmaAzeQjekX;
								list6.Add(ruleSetMapping);
							}
						}
					}
					player_Editor.controllerMapLayoutManagerSettings.ruleSets = list6;
					List<Player_Editor.RuleSetMapping> list7 = new List<Player_Editor.RuleSetMapping>();
					List<Player_Editor.RuleSetMapping> ruleSets2 = player_Editor.controllerMapEnablerSettings.ruleSets;
					for (int num11 = 0; num11 < ruleSets2.Count; num11++)
					{
						Player_Editor.RuleSetMapping ruleSetMapping2 = ruleSets2[num11];
						if (ruleSetMapping2 != null)
						{
							int BlZsUkOGPQDnwzRAzcAFtbBWDaNH = ruleSetMapping2.id;
							seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS26 = VgpexWuHCaEqigdtrycAfddzsFP.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == BlZsUkOGPQDnwzRAzcAFtbBWDaNH);
							if (seHDmnQDiSDJHjaCctbegGkUHmxS26 == null)
							{
								Logger.LogError("No new Controller Map Enabler Set found for old id: " + BlZsUkOGPQDnwzRAzcAFtbBWDaNH);
							}
							else
							{
								ruleSetMapping2 = ruleSetMapping2.Clone();
								ruleSetMapping2.id = seHDmnQDiSDJHjaCctbegGkUHmxS26.ObhzDARdXnFTqWuCrmaAzeQjekX;
								list7.Add(ruleSetMapping2);
							}
						}
					}
					player_Editor.controllerMapEnablerSettings.ruleSets = list7;
					Player_Editor player_Editor2;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						player_Editor2 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
						Player_Editor player_Editor3 = JsonTools.Clone(player_Editor);
						player_Editor3.defaultKeyboardMaps.Clear();
						player_Editor3.defaultMouseMaps.Clear();
						player_Editor3.defaultJoystickMaps.Clear();
						player_Editor3.defaultCustomControllerMaps.Clear();
						player_Editor3.startingCustomControllers.Clear();
						Func<Player_Editor.Mapping, IList<Player_Editor.Mapping>, int> func5 = delegate(Player_Editor.Mapping P_0, IList<Player_Editor.Mapping> P_1)
						{
							for (int num13 = 0; num13 < P_1.Count; num13++)
							{
								if (P_1[num13].categoryId == P_0.categoryId && P_1[num13].layoutId == P_0.layoutId)
								{
									return num13;
								}
							}
							return -1;
						};
						BtQSnWhMZhgfMEqJthwNeWooLXH(player_Editor2.defaultKeyboardMaps, player_Editor.defaultKeyboardMaps, player_Editor3.defaultKeyboardMaps, func5);
						BtQSnWhMZhgfMEqJthwNeWooLXH(player_Editor2.defaultMouseMaps, player_Editor.defaultMouseMaps, player_Editor3.defaultMouseMaps, func5);
						BtQSnWhMZhgfMEqJthwNeWooLXH(player_Editor2.defaultJoystickMaps, player_Editor.defaultJoystickMaps, player_Editor3.defaultJoystickMaps, func5);
						BtQSnWhMZhgfMEqJthwNeWooLXH(player_Editor2.defaultCustomControllerMaps, player_Editor.defaultCustomControllerMaps, player_Editor3.defaultCustomControllerMaps, func5);
						BtQSnWhMZhgfMEqJthwNeWooLXH(player_Editor2.startingCustomControllers, player_Editor.startingCustomControllers, player_Editor3.startingCustomControllers, delegate(Player_Editor.CreateControllerInfo P_0, IList<Player_Editor.CreateControllerInfo> P_1)
						{
							for (int num12 = 0; num12 < P_1.Count; num12++)
							{
								if (P_1[num12].sourceId == P_0.sourceId)
								{
									return num12;
								}
							}
							return -1;
						});
						player_Editor = player_Editor3;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.AddPlayer();
						player_Editor2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					player_Editor.id = player_Editor2.id;
					int index6 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(player_Editor2);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index6] = player_Editor;
					return player_Editor;
				});
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> list2 = new List<seHDmnQDiSDJHjaCctbegGkUHmxS>();
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> slXEjUxuEBlCBCGMdQtEbqClyVl4 = ImfhhosyZPGUuICCnQBGgequFmP;
				eSZCXboJyWyObXCGrOzViBIscQge("Keyboard Map", P_0.keyboardMaps, P_1?.keyboardMaps, ISkmsCiBKkbTqyKMaVIsLGGdKou.keyboardMaps, P_2, list2, (ControllerMap_Editor P_0) => P_0.id, (ControllerMap_Editor P_0) => P_0.name, delegate(ControllerMap_Editor P_0, IList<ControllerMap_Editor> P_1)
				{
					for (int num8 = 0; num8 < P_1.Count; num8++)
					{
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS22 = cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.categoryId);
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS23 = slXEjUxuEBlCBCGMdQtEbqClyVl4.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.layoutId);
						if (seHDmnQDiSDJHjaCctbegGkUHmxS22 != null && seHDmnQDiSDJHjaCctbegGkUHmxS22.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[num8].categoryId && seHDmnQDiSDJHjaCctbegGkUHmxS23 != null && seHDmnQDiSDJHjaCctbegGkUHmxS23.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[num8].layoutId)
						{
							return num8;
						}
					}
					return -1;
				}, delegate(TvqENFFpkRmmDNlELiCANcttXNC<ControllerMap_Editor> P_0)
				{
					ControllerMap_Editor JiPmnWqGoodLekCZtZTncBkMXVE4 = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS19 = cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE4.categoryId);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS20 = slXEjUxuEBlCBCGMdQtEbqClyVl4.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE4.layoutId);
					JiPmnWqGoodLekCZtZTncBkMXVE4.categoryId = seHDmnQDiSDJHjaCctbegGkUHmxS19?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					JiPmnWqGoodLekCZtZTncBkMXVE4.layoutId = seHDmnQDiSDJHjaCctbegGkUHmxS20?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					for (int num6 = 0; num6 < JiPmnWqGoodLekCZtZTncBkMXVE4.actionElementMaps.Count; num6++)
					{
						ActionElementMap MBcARPFZxLOnVPBiVwerBuGBaiQh4 = JiPmnWqGoodLekCZtZTncBkMXVE4.actionElementMaps[num6];
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS21 = FvBmdXrivUPrVMcERZfhDmgEAfu.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh4._actionId);
						MBcARPFZxLOnVPBiVwerBuGBaiQh4._actionId = seHDmnQDiSDJHjaCctbegGkUHmxS21?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
						MBcARPFZxLOnVPBiVwerBuGBaiQh4._actionCategoryId = ((ISkmsCiBKkbTqyKMaVIsLGGdKou.GetActionById(MBcARPFZxLOnVPBiVwerBuGBaiQh4._actionId) != null) ? ISkmsCiBKkbTqyKMaVIsLGGdKou.GetActionById(MBcARPFZxLOnVPBiVwerBuGBaiQh4._actionId).categoryId : 0);
					}
					ControllerMap_Editor controllerMap_Editor7;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						controllerMap_Editor7 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
						ControllerMap_Editor controllerMap_Editor8 = JsonTools.Clone(JiPmnWqGoodLekCZtZTncBkMXVE4);
						controllerMap_Editor8.actionElementMaps.Clear();
						Func<ActionElementMap, IList<ActionElementMap>, int> func4 = delegate(ActionElementMap P_0, IList<ActionElementMap> P_1)
						{
							for (int num7 = 0; num7 < P_1.Count; num7++)
							{
								if (P_1[num7]._keyboardKeyCode == P_0._keyboardKeyCode && P_1[num7]._modifierKey1 == P_0._modifierKey1 && P_1[num7]._modifierKey2 == P_0._modifierKey2 && P_1[num7]._modifierKey3 == P_0._modifierKey3 && P_1[num7]._axisContribution == P_0._axisContribution && P_1[num7]._actionId == P_0._actionId)
								{
									return num7;
								}
							}
							return -1;
						};
						BtQSnWhMZhgfMEqJthwNeWooLXH(controllerMap_Editor7.actionElementMaps, JiPmnWqGoodLekCZtZTncBkMXVE4.actionElementMaps, controllerMap_Editor8.actionElementMaps, func4);
						JiPmnWqGoodLekCZtZTncBkMXVE4 = controllerMap_Editor8;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.CreateKeyboardMap(JiPmnWqGoodLekCZtZTncBkMXVE4.categoryId, JiPmnWqGoodLekCZtZTncBkMXVE4.layoutId);
						controllerMap_Editor7 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					JiPmnWqGoodLekCZtZTncBkMXVE4.id = controllerMap_Editor7.id;
					int index5 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(controllerMap_Editor7);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index5] = JiPmnWqGoodLekCZtZTncBkMXVE4;
					return JiPmnWqGoodLekCZtZTncBkMXVE4;
				});
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> list3 = new List<seHDmnQDiSDJHjaCctbegGkUHmxS>();
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> slXEjUxuEBlCBCGMdQtEbqClyVl3 = KYKflSZZfZevcykUTKJaEeIaARh;
				eSZCXboJyWyObXCGrOzViBIscQge("Mouse Map", P_0.mouseMaps, P_1?.mouseMaps, ISkmsCiBKkbTqyKMaVIsLGGdKou.mouseMaps, P_2, list3, (ControllerMap_Editor P_0) => P_0.id, (ControllerMap_Editor P_0) => P_0.name, delegate(ControllerMap_Editor P_0, IList<ControllerMap_Editor> P_1)
				{
					for (int num5 = 0; num5 < P_1.Count; num5++)
					{
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS17 = cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.categoryId);
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS18 = slXEjUxuEBlCBCGMdQtEbqClyVl3.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.layoutId);
						if (seHDmnQDiSDJHjaCctbegGkUHmxS17 != null && seHDmnQDiSDJHjaCctbegGkUHmxS17.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[num5].categoryId && seHDmnQDiSDJHjaCctbegGkUHmxS18 != null && seHDmnQDiSDJHjaCctbegGkUHmxS18.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[num5].layoutId)
						{
							return num5;
						}
					}
					return -1;
				}, delegate(TvqENFFpkRmmDNlELiCANcttXNC<ControllerMap_Editor> P_0)
				{
					ControllerMap_Editor JiPmnWqGoodLekCZtZTncBkMXVE3 = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS14 = cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE3.categoryId);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS15 = slXEjUxuEBlCBCGMdQtEbqClyVl3.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE3.layoutId);
					JiPmnWqGoodLekCZtZTncBkMXVE3.categoryId = seHDmnQDiSDJHjaCctbegGkUHmxS14?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					JiPmnWqGoodLekCZtZTncBkMXVE3.layoutId = seHDmnQDiSDJHjaCctbegGkUHmxS15?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					for (int num3 = 0; num3 < JiPmnWqGoodLekCZtZTncBkMXVE3.actionElementMaps.Count; num3++)
					{
						ActionElementMap MBcARPFZxLOnVPBiVwerBuGBaiQh3 = JiPmnWqGoodLekCZtZTncBkMXVE3.actionElementMaps[num3];
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS16 = FvBmdXrivUPrVMcERZfhDmgEAfu.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh3._actionId);
						MBcARPFZxLOnVPBiVwerBuGBaiQh3._actionId = seHDmnQDiSDJHjaCctbegGkUHmxS16?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
						MBcARPFZxLOnVPBiVwerBuGBaiQh3._actionCategoryId = ((ISkmsCiBKkbTqyKMaVIsLGGdKou.GetActionById(MBcARPFZxLOnVPBiVwerBuGBaiQh3._actionId) != null) ? ISkmsCiBKkbTqyKMaVIsLGGdKou.GetActionById(MBcARPFZxLOnVPBiVwerBuGBaiQh3._actionId).categoryId : 0);
					}
					ControllerMap_Editor controllerMap_Editor5;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						controllerMap_Editor5 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
						ControllerMap_Editor controllerMap_Editor6 = JsonTools.Clone(JiPmnWqGoodLekCZtZTncBkMXVE3);
						controllerMap_Editor6.actionElementMaps.Clear();
						Func<ActionElementMap, IList<ActionElementMap>, int> func3 = delegate(ActionElementMap P_0, IList<ActionElementMap> P_1)
						{
							for (int num4 = 0; num4 < P_1.Count; num4++)
							{
								if (P_1[num4]._elementIdentifierId == P_0._elementIdentifierId && P_1[num4]._axisRange == P_0._axisRange && P_1[num4]._axisContribution == P_0._axisContribution && P_1[num4]._actionId == P_0._actionId)
								{
									return num4;
								}
							}
							return -1;
						};
						BtQSnWhMZhgfMEqJthwNeWooLXH(controllerMap_Editor5.actionElementMaps, JiPmnWqGoodLekCZtZTncBkMXVE3.actionElementMaps, controllerMap_Editor6.actionElementMaps, func3);
						JiPmnWqGoodLekCZtZTncBkMXVE3 = controllerMap_Editor6;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.CreateMouseMap(JiPmnWqGoodLekCZtZTncBkMXVE3.categoryId, JiPmnWqGoodLekCZtZTncBkMXVE3.layoutId);
						controllerMap_Editor5 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					JiPmnWqGoodLekCZtZTncBkMXVE3.id = controllerMap_Editor5.id;
					int index4 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(controllerMap_Editor5);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index4] = JiPmnWqGoodLekCZtZTncBkMXVE3;
					return JiPmnWqGoodLekCZtZTncBkMXVE3;
				});
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> list4 = new List<seHDmnQDiSDJHjaCctbegGkUHmxS>();
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> slXEjUxuEBlCBCGMdQtEbqClyVl2 = obQUneKGVKRwAuEgsOBHNFFqvN;
				eSZCXboJyWyObXCGrOzViBIscQge("Joystick Map", P_0.joystickMaps, P_1?.joystickMaps, ISkmsCiBKkbTqyKMaVIsLGGdKou.joystickMaps, P_2, list4, (ControllerMap_Editor P_0) => P_0.id, (ControllerMap_Editor P_0) => P_0.name, delegate(ControllerMap_Editor P_0, IList<ControllerMap_Editor> P_1)
				{
					for (int num2 = 0; num2 < P_1.Count; num2++)
					{
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS12 = cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.categoryId);
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS13 = slXEjUxuEBlCBCGMdQtEbqClyVl2.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.layoutId);
						if (P_0.hardwareGuid == P_1[num2].hardwareGuid && seHDmnQDiSDJHjaCctbegGkUHmxS12 != null && seHDmnQDiSDJHjaCctbegGkUHmxS12.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[num2].categoryId && seHDmnQDiSDJHjaCctbegGkUHmxS13 != null && seHDmnQDiSDJHjaCctbegGkUHmxS13.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[num2].layoutId)
						{
							return num2;
						}
					}
					return -1;
				}, delegate(TvqENFFpkRmmDNlELiCANcttXNC<ControllerMap_Editor> P_0)
				{
					ControllerMap_Editor JiPmnWqGoodLekCZtZTncBkMXVE2 = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS9 = cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE2.categoryId);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS10 = slXEjUxuEBlCBCGMdQtEbqClyVl2.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE2.layoutId);
					JiPmnWqGoodLekCZtZTncBkMXVE2.categoryId = seHDmnQDiSDJHjaCctbegGkUHmxS9?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					JiPmnWqGoodLekCZtZTncBkMXVE2.layoutId = seHDmnQDiSDJHjaCctbegGkUHmxS10?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					for (int n = 0; n < JiPmnWqGoodLekCZtZTncBkMXVE2.actionElementMaps.Count; n++)
					{
						ActionElementMap MBcARPFZxLOnVPBiVwerBuGBaiQh2 = JiPmnWqGoodLekCZtZTncBkMXVE2.actionElementMaps[n];
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS11 = FvBmdXrivUPrVMcERZfhDmgEAfu.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh2._actionId);
						MBcARPFZxLOnVPBiVwerBuGBaiQh2._actionId = seHDmnQDiSDJHjaCctbegGkUHmxS11?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
						MBcARPFZxLOnVPBiVwerBuGBaiQh2._actionCategoryId = ((ISkmsCiBKkbTqyKMaVIsLGGdKou.GetActionById(MBcARPFZxLOnVPBiVwerBuGBaiQh2._actionId) != null) ? ISkmsCiBKkbTqyKMaVIsLGGdKou.GetActionById(MBcARPFZxLOnVPBiVwerBuGBaiQh2._actionId).categoryId : 0);
					}
					ControllerMap_Editor controllerMap_Editor3;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						controllerMap_Editor3 = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
						ControllerMap_Editor controllerMap_Editor4 = JsonTools.Clone(JiPmnWqGoodLekCZtZTncBkMXVE2);
						controllerMap_Editor4.actionElementMaps.Clear();
						Func<ActionElementMap, IList<ActionElementMap>, int> func2 = delegate(ActionElementMap P_0, IList<ActionElementMap> P_1)
						{
							for (int num = 0; num < P_1.Count; num++)
							{
								if (P_1[num]._elementIdentifierId == P_0._elementIdentifierId && P_1[num]._axisRange == P_0._axisRange && P_1[num]._axisContribution == P_0._axisContribution && P_1[num]._actionId == P_0._actionId)
								{
									return num;
								}
							}
							return -1;
						};
						BtQSnWhMZhgfMEqJthwNeWooLXH(controllerMap_Editor3.actionElementMaps, JiPmnWqGoodLekCZtZTncBkMXVE2.actionElementMaps, controllerMap_Editor4.actionElementMaps, func2);
						JiPmnWqGoodLekCZtZTncBkMXVE2 = controllerMap_Editor4;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.CreateJoystickMap(JiPmnWqGoodLekCZtZTncBkMXVE2.categoryId, JiPmnWqGoodLekCZtZTncBkMXVE2.hardwareGuid, JiPmnWqGoodLekCZtZTncBkMXVE2.layoutId);
						controllerMap_Editor3 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					JiPmnWqGoodLekCZtZTncBkMXVE2.id = controllerMap_Editor3.id;
					int index3 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(controllerMap_Editor3);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index3] = JiPmnWqGoodLekCZtZTncBkMXVE2;
					return JiPmnWqGoodLekCZtZTncBkMXVE2;
				});
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> list5 = new List<seHDmnQDiSDJHjaCctbegGkUHmxS>();
				List<seHDmnQDiSDJHjaCctbegGkUHmxS> slXEjUxuEBlCBCGMdQtEbqClyVl = lZusqqfJCZMAaPRIgYfBRHXKoCV;
				eSZCXboJyWyObXCGrOzViBIscQge("Custom Controller Map", P_0.customControllerMaps, P_1?.customControllerMaps, ISkmsCiBKkbTqyKMaVIsLGGdKou.customControllerMaps, P_2, list5, (ControllerMap_Editor P_0) => P_0.id, (ControllerMap_Editor P_0) => P_0.name, delegate(ControllerMap_Editor P_0, IList<ControllerMap_Editor> P_1)
				{
					for (int m = 0; m < P_1.Count; m++)
					{
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS6 = ThtlaBGRMCFRogauOlyIPRCOlTJc.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.customControllerUid);
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS7 = cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.categoryId);
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS8 = slXEjUxuEBlCBCGMdQtEbqClyVl.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.fvgSwEWVuLHXjsLhgRfQoPYMDsc == P_0.layoutId);
						if (seHDmnQDiSDJHjaCctbegGkUHmxS6 != null && seHDmnQDiSDJHjaCctbegGkUHmxS6.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[m].customControllerUid && seHDmnQDiSDJHjaCctbegGkUHmxS7 != null && seHDmnQDiSDJHjaCctbegGkUHmxS7.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[m].categoryId && seHDmnQDiSDJHjaCctbegGkUHmxS8 != null && seHDmnQDiSDJHjaCctbegGkUHmxS8.ObhzDARdXnFTqWuCrmaAzeQjekX == P_1[m].layoutId)
						{
							return m;
						}
					}
					return -1;
				}, delegate(TvqENFFpkRmmDNlELiCANcttXNC<ControllerMap_Editor> P_0)
				{
					ControllerMap_Editor JiPmnWqGoodLekCZtZTncBkMXVE = JsonTools.Clone(P_0.PVvlSNRPruvLEyIUzSxfxpMFpze);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS2 = ThtlaBGRMCFRogauOlyIPRCOlTJc.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.customControllerUid);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS3 = cVBBEuktBkOWrDrCaQmPzhAlYoHZ.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.categoryId);
					seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS4 = slXEjUxuEBlCBCGMdQtEbqClyVl.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == JiPmnWqGoodLekCZtZTncBkMXVE.layoutId);
					JiPmnWqGoodLekCZtZTncBkMXVE.customControllerUid = seHDmnQDiSDJHjaCctbegGkUHmxS2?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					JiPmnWqGoodLekCZtZTncBkMXVE.categoryId = seHDmnQDiSDJHjaCctbegGkUHmxS3?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					JiPmnWqGoodLekCZtZTncBkMXVE.layoutId = seHDmnQDiSDJHjaCctbegGkUHmxS4?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
					for (int k = 0; k < JiPmnWqGoodLekCZtZTncBkMXVE.actionElementMaps.Count; k++)
					{
						ActionElementMap MBcARPFZxLOnVPBiVwerBuGBaiQh = JiPmnWqGoodLekCZtZTncBkMXVE.actionElementMaps[k];
						seHDmnQDiSDJHjaCctbegGkUHmxS seHDmnQDiSDJHjaCctbegGkUHmxS5 = FvBmdXrivUPrVMcERZfhDmgEAfu.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.get_Item(P_0.RhgqvxXeeAEVXiOSSbokhAXrufD) == MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId);
						MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId = seHDmnQDiSDJHjaCctbegGkUHmxS5?.ObhzDARdXnFTqWuCrmaAzeQjekX ?? (-1);
						MBcARPFZxLOnVPBiVwerBuGBaiQh._actionCategoryId = ((ISkmsCiBKkbTqyKMaVIsLGGdKou.GetActionById(MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId) != null) ? ISkmsCiBKkbTqyKMaVIsLGGdKou.GetActionById(MBcARPFZxLOnVPBiVwerBuGBaiQh._actionId).categoryId : 0);
					}
					ControllerMap_Editor controllerMap_Editor;
					if (P_0.tyQDgvvvgkHmXxIMMILTdavtSRe)
					{
						controllerMap_Editor = P_0.MquqyDPztEbYjazCpwxPgorDFYC;
						ControllerMap_Editor controllerMap_Editor2 = JsonTools.Clone(JiPmnWqGoodLekCZtZTncBkMXVE);
						controllerMap_Editor2.actionElementMaps.Clear();
						Func<ActionElementMap, IList<ActionElementMap>, int> func = delegate(ActionElementMap P_0, IList<ActionElementMap> P_1)
						{
							for (int l = 0; l < P_1.Count; l++)
							{
								if (P_1[l]._elementIdentifierId == P_0._elementIdentifierId && P_1[l]._axisRange == P_0._axisRange && P_1[l]._axisContribution == P_0._axisContribution && P_1[l]._actionId == P_0._actionId)
								{
									return l;
								}
							}
							return -1;
						};
						BtQSnWhMZhgfMEqJthwNeWooLXH(controllerMap_Editor.actionElementMaps, JiPmnWqGoodLekCZtZTncBkMXVE.actionElementMaps, controllerMap_Editor2.actionElementMaps, func);
						JiPmnWqGoodLekCZtZTncBkMXVE = controllerMap_Editor2;
					}
					else
					{
						ISkmsCiBKkbTqyKMaVIsLGGdKou.CreateCustomControllerMap(JiPmnWqGoodLekCZtZTncBkMXVE.categoryId, JiPmnWqGoodLekCZtZTncBkMXVE.customControllerUid, JiPmnWqGoodLekCZtZTncBkMXVE.layoutId);
						controllerMap_Editor = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.Count - 1];
					}
					JiPmnWqGoodLekCZtZTncBkMXVE.id = controllerMap_Editor.id;
					int index2 = P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz.IndexOf(controllerMap_Editor);
					P_0.cTpyoseiLAuRTNhGTnxkxHkMjbz[index2] = JiPmnWqGoodLekCZtZTncBkMXVE;
					return JiPmnWqGoodLekCZtZTncBkMXVE;
				});
				return ISkmsCiBKkbTqyKMaVIsLGGdKou;
			}

			[Conditional("DEBUG_IMPORT")]
			private static void eyltnHcNgAvNvkfeJwRsQYOSwAW(object P_0)
			{
				Logger.Log("[DEBUG_IMPORT] " + P_0);
			}

			private static void BtQSnWhMZhgfMEqJthwNeWooLXH<T>(IList<T> P_0, IList<T> P_1, IList<T> P_2, Func<T, IList<T>, int> P_3)
			{
				for (int i = 0; i < P_0.Count; i++)
				{
					P_2.Add(P_0[i]);
				}
				if (P_1 == null)
				{
					return;
				}
				for (int j = 0; j < P_1.Count; j++)
				{
					T val = P_1[j];
					int num = P_3(val, P_2);
					if (num >= 0)
					{
						P_2[num] = val;
					}
					else
					{
						P_2.Add(val);
					}
				}
			}

			private static void eSZCXboJyWyObXCGrOzViBIscQge<T>(string P_0, IList<T> P_1, IList<T> P_2, IList<T> P_3, bool P_4, List<seHDmnQDiSDJHjaCctbegGkUHmxS> P_5, Func<T, int> P_6, Func<T, string> P_7, Func<T, IList<T>, int> P_8, Func<TvqENFFpkRmmDNlELiCANcttXNC<T>, T> P_9) where T : class
			{
				for (int i = 0; i < P_1.Count; i++)
				{
					T val = P_1[i];
					if (P_4)
					{
						P_5.Add(new seHDmnQDiSDJHjaCctbegGkUHmxS(P_6(val), -1, P_6(val)));
						continue;
					}
					T arg = P_9(new TvqENFFpkRmmDNlELiCANcttXNC<T>(val, null, seHDmnQDiSDJHjaCctbegGkUHmxS.QwrRblAujsoBkXHpojAgfhfypRSY.vwTQzUDIdxLFgqhBgnjJOnSkEWE, P_3, isCollision: false));
					P_5.Add(new seHDmnQDiSDJHjaCctbegGkUHmxS(P_6(val), -1, P_6(arg)));
				}
				if (P_2 == null)
				{
					return;
				}
				for (int j = 0; j < P_2.Count; j++)
				{
					T val2 = P_2[j];
					int num = P_8(val2, P_3);
					if (num >= 0)
					{
						T finalItem = P_3[num];
						T JiPmnWqGoodLekCZtZTncBkMXVE = P_9(new TvqENFFpkRmmDNlELiCANcttXNC<T>(val2, finalItem, seHDmnQDiSDJHjaCctbegGkUHmxS.QwrRblAujsoBkXHpojAgfhfypRSY.fvgSwEWVuLHXjsLhgRfQoPYMDsc, P_3, isCollision: true));
						P_5.Find((seHDmnQDiSDJHjaCctbegGkUHmxS P_0) => P_0.ObhzDARdXnFTqWuCrmaAzeQjekX == P_6(JiPmnWqGoodLekCZtZTncBkMXVE)).fvgSwEWVuLHXjsLhgRfQoPYMDsc = P_6(val2);
						string text = ((!string.IsNullOrEmpty(P_7(val2))) ? ("\"" + P_7(val2) + "\"") : "");
						Logger.Log(P_0 + ((!string.IsNullOrEmpty(text)) ? (" " + text) : "") + " already exists. Imported data will replace original.");
					}
					else
					{
						T arg2 = P_9(new TvqENFFpkRmmDNlELiCANcttXNC<T>(val2, null, seHDmnQDiSDJHjaCctbegGkUHmxS.QwrRblAujsoBkXHpojAgfhfypRSY.fvgSwEWVuLHXjsLhgRfQoPYMDsc, P_3, isCollision: false));
						P_5.Add(new seHDmnQDiSDJHjaCctbegGkUHmxS(-1, P_6(val2), P_6(arg2)));
						string text2 = ((!string.IsNullOrEmpty(P_7(val2))) ? ("\"" + P_7(val2) + "\"") : "");
						Logger.Log("Imported new " + P_0 + ((!string.IsNullOrEmpty(text2)) ? (" " + text2) : "") + ".");
					}
				}
			}

			[CompilerGenerated]
			private static int uyEFvbFIPthmMeQxVgRGepHimZjL(InputCategory P_0)
			{
				return P_0.id;
			}

			[CompilerGenerated]
			private static string VmvEBnntGLcoDssHYlJBfIGRKDU(InputCategory P_0)
			{
				return P_0.name;
			}

			[CompilerGenerated]
			private static int VEcVpYkyJAHuWLrTmkPviNKtzUQ(InputCategory P_0, IList<InputCategory> P_1)
			{
				for (int i = 0; i < P_1.Count; i++)
				{
					if (string.Equals(P_0.name, P_1[i].name, StringComparison.OrdinalIgnoreCase))
					{
						return i;
					}
				}
				return -1;
			}

			[CompilerGenerated]
			private static int dSJHueGgbeknlaYdjJeOtgUDZZS(InputBehavior P_0)
			{
				return P_0.id;
			}

			[CompilerGenerated]
			private static string riyvObDlDSRCZCwrqwaLDySbZar(InputBehavior P_0)
			{
				return P_0.name;
			}

			[CompilerGenerated]
			private static int KXkbUfMEyStOBGRHShYgFknuMav(InputBehavior P_0, IList<InputBehavior> P_1)
			{
				for (int i = 0; i < P_1.Count; i++)
				{
					if (string.Equals(P_0.name, P_1[i].name, StringComparison.OrdinalIgnoreCase))
					{
						return i;
					}
				}
				return -1;
			}

			[CompilerGenerated]
			private static int XWXdOmFTRcJWXcHKCLZyevnaWCBe(InputAction P_0)
			{
				return P_0.id;
			}

			[CompilerGenerated]
			private static string VeGfzBALeatherlWeGtZinVjFCbF(InputAction P_0)
			{
				return P_0.name;
			}

			[CompilerGenerated]
			private static int MEugOFFzqSoytmVvEbuMcSlGhpCG(InputAction P_0, IList<InputAction> P_1)
			{
				for (int i = 0; i < P_1.Count; i++)
				{
					if (string.Equals(P_0.name, P_1[i].name, StringComparison.OrdinalIgnoreCase))
					{
						return i;
					}
				}
				return -1;
			}

			[CompilerGenerated]
			private static int EYghAQHmZIPBQahhfhbdNMUJzc(InputMapCategory P_0)
			{
				return P_0.id;
			}

			[CompilerGenerated]
			private static string ApsdHxzSFJyvBelfIJHOuHmopXm(InputMapCategory P_0)
			{
				return P_0.name;
			}

			[CompilerGenerated]
			private static int dsIIOraFMULSBnsCOLdxNEUgrnD(InputMapCategory P_0, IList<InputMapCategory> P_1)
			{
				for (int i = 0; i < P_1.Count; i++)
				{
					if (string.Equals(P_0.name, P_1[i].name, StringComparison.OrdinalIgnoreCase))
					{
						return i;
					}
				}
				return -1;
			}

			[CompilerGenerated]
			private static int teWgoTVnHvbCnjBnQKQEKkeEUKE(InputLayout P_0)
			{
				return P_0.id;
			}

			[CompilerGenerated]
			private static string gYzsehcHvegKPBbEDiLBZqvdoKQ(InputLayout P_0)
			{
				return P_0.name;
			}

			[CompilerGenerated]
			private static int GnvzquzgeVZLYhctTBUfNvPsdYU(InputLayout P_0, IList<InputLayout> P_1)
			{
				for (int i = 0; i < P_1.Count; i++)
				{
					if (string.Equals(P_0.name, P_1[i].name, StringComparison.OrdinalIgnoreCase))
					{
						return i;
					}
				}
				return -1;
			}

			[CompilerGenerated]
			private static int IftAGKfmQoHuFWGOOjyNpshbRaV(InputLayout P_0)
			{
				return P_0.id;
			}

			[CompilerGenerated]
			private static string fRNKbfpfLJORtYEYcfIGEtAvAJoj(InputLayout P_0)
			{
				return P_0.name;
			}

			[CompilerGenerated]
			private static int PZLWLDFPaIbAqSCRlCOSDlfUrugC(InputLayout P_0, IList<InputLayout> P_1)
			{
				for (int i = 0; i < P_1.Count; i++)
				{
					if (string.Equals(P_0.name, P_1[i].name, StringComparison.OrdinalIgnoreCase))
					{
						return i;
					}
				}
				return -1;
			}

			[CompilerGenerated]
			private static int ItNfmcGATQhkxFrvzgrLNgkzfRf(InputLayout P_0)
			{
				return P_0.id;
			}

			[CompilerGenerated]
			private static string sSYWbzRIKxZvkhHKeEGhASvqKjea(InputLayout P_0)
			{
				return P_0.name;
			}

			[CompilerGenerated]
			private static int hGLTdZGLBeDmEXuDfjiBDaKzVPI(InputLayout P_0, IList<InputLayout> P_1)
			{
				for (int i = 0; i < P_1.Count; i++)
				{
					if (string.Equals(P_0.name, P_1[i].name, StringComparison.OrdinalIgnoreCase))
					{
						return i;
					}
				}
				return -1;
			}

			[CompilerGenerated]
			private static int GFbgIDwBxavNIlFFGvvcLjwZUjz(InputLayout P_0)
			{
				return P_0.id;
			}

			[CompilerGenerated]
			private static string YWganRdcIlhvUZfLvKXNVOicjZVy(InputLayout P_0)
			{
				return P_0.name;
			}

			[CompilerGenerated]
			private static int wcqCqnFbpZTFilSYJbhGfoJhrtj(InputLayout P_0, IList<InputLayout> P_1)
			{
				for (int i = 0; i < P_1.Count; i++)
				{
					if (string.Equals(P_0.name, P_1[i].name, StringComparison.OrdinalIgnoreCase))
					{
						return i;
					}
				}
				return -1;
			}

			[CompilerGenerated]
			private static int PpcghhfwbDkXNGIkAFtSBkPCfkOO(CustomController_Editor P_0)
			{
				return P_0.id;
			}

			[CompilerGenerated]
			private static string JQrxWucNkWDGGRXIxEcUfmMUBhGH(CustomController_Editor P_0)
			{
				return P_0.name;
			}

			[CompilerGenerated]
			private static int RVCoXfUOvpSGZKgjLDzDcQsiBKlb(CustomController_Editor P_0, IList<CustomController_Editor> P_1)
			{
				for (int i = 0; i < P_1.Count; i++)
				{
					if (string.Equals(P_0.name, P_1[i].name, StringComparison.OrdinalIgnoreCase))
					{
						return i;
					}
				}
				return -1;
			}

			[CompilerGenerated]
			private static int iQobBYbxPMvXhcnPTCTWWQrGgQYe(ControllerMapLayoutManager_RuleSet_Editor P_0)
			{
				return P_0.id;
			}

			[CompilerGenerated]
			private static string TBhrLOMQZwCSpYIEBywTUWCYNPz(ControllerMapLayoutManager_RuleSet_Editor P_0)
			{
				return P_0.name;
			}

			[CompilerGenerated]
			private static int GJzOGLPvnWhtWnEHGvuNKVCoBOS(ControllerMapLayoutManager_RuleSet_Editor P_0, IList<ControllerMapLayoutManager_RuleSet_Editor> P_1)
			{
				for (int i = 0; i < P_1.Count; i++)
				{
					if (string.Equals(P_0.name, P_1[i].name, StringComparison.OrdinalIgnoreCase))
					{
						return i;
					}
				}
				return -1;
			}

			[CompilerGenerated]
			private static int qmrvrbDBNNUmZvhlFgQApeMtECU(ControllerMapEnabler_RuleSet_Editor P_0)
			{
				return P_0.id;
			}

			[CompilerGenerated]
			private static string CgOLhkaqqDRqRCEokiGquRdYAak(ControllerMapEnabler_RuleSet_Editor P_0)
			{
				return P_0.name;
			}

			[CompilerGenerated]
			private static int tjvIDOcaCasVPKpLJofpqMLleJd(ControllerMapEnabler_RuleSet_Editor P_0, IList<ControllerMapEnabler_RuleSet_Editor> P_1)
			{
				for (int i = 0; i < P_1.Count; i++)
				{
					if (string.Equals(P_0.name, P_1[i].name, StringComparison.OrdinalIgnoreCase))
					{
						return i;
					}
				}
				return -1;
			}

			[CompilerGenerated]
			private static int LivLelEQtgkXtkeBcaPpwWPTUBx(Player_Editor P_0)
			{
				return P_0.id;
			}

			[CompilerGenerated]
			private static string fyFZjyywZjUUYACTAvRNuZGZdhy(Player_Editor P_0)
			{
				return P_0.name;
			}

			[CompilerGenerated]
			private static int tWvvBeOvPAGvouIURsuWOyMCqHx(Player_Editor P_0, IList<Player_Editor> P_1)
			{
				for (int i = 0; i < P_1.Count; i++)
				{
					if (string.Equals(P_0.name, P_1[i].name, StringComparison.OrdinalIgnoreCase))
					{
						return i;
					}
				}
				return -1;
			}

			[CompilerGenerated]
			private static int cssAPyDkWttmBxUQvosjqAoGGyBy(ControllerMap_Editor P_0)
			{
				return P_0.id;
			}

			[CompilerGenerated]
			private static string HbcdIbkiaccNrLZxXCqjVvugyEW(ControllerMap_Editor P_0)
			{
				return P_0.name;
			}

			[CompilerGenerated]
			private static int mJksyifGNgTTlOWejPKtcEnXeWM(ControllerMap_Editor P_0)
			{
				return P_0.id;
			}

			[CompilerGenerated]
			private static string dfFTzwUCIEORgaFARtYHFfESpwG(ControllerMap_Editor P_0)
			{
				return P_0.name;
			}

			[CompilerGenerated]
			private static int XVqLAjdadbHSOuTEiVIABAbiELF(ControllerMap_Editor P_0)
			{
				return P_0.id;
			}

			[CompilerGenerated]
			private static string rTwroCExjEFEgxNtjENBjBSNGkV(ControllerMap_Editor P_0)
			{
				return P_0.name;
			}

			[CompilerGenerated]
			private static int BGFRastJSrvqQETGFMGDMUgRFTp(ControllerMap_Editor P_0)
			{
				return P_0.id;
			}

			[CompilerGenerated]
			private static string OVoJpMPteSSAKrdIDQDPfofmBmZ(ControllerMap_Editor P_0)
			{
				return P_0.name;
			}
		}

		[CompilerGenerated]
		private sealed class halJhYbyaoxzVlIUUkClKGBjoUX
		{
			private sealed class MLXfMnWaOyvkxfiFXlYfckAkiF
			{
				public halJhYbyaoxzVlIUUkClKGBjoUX cuhirLpmHeHFDVDriDiMBgVjbvEb;

				public ControllerMap_Editor BMNgtthGpqCSTnlmLgeEDQRCdItL;

				public ControllerMap_Editor pTKbMhixySNJoEdgwZWgQxGJIbx;

				public bool KgXFUZNJCkKvuNMOtsQhWtABgpN(InputLayout P_0)
				{
					return P_0.id == BMNgtthGpqCSTnlmLgeEDQRCdItL.id;
				}

				public bool hBYDrxEBDGsFhmtvFQvumcJDxTw(InputLayout P_0)
				{
					return P_0.id == pTKbMhixySNJoEdgwZWgQxGJIbx.id;
				}
			}

			public List<InputLayout> FhCEnelCuecSNSRdJXoaYWOPlkb;

			public int NxIIoawcsELdnIXUITkmYykOWvQ(ControllerMap_Editor P_0, ControllerMap_Editor P_1)
			{
				int num = FhCEnelCuecSNSRdJXoaYWOPlkb.FindIndex((InputLayout P_0) => P_0.id == P_0.id);
				int num2 = FhCEnelCuecSNSRdJXoaYWOPlkb.FindIndex((InputLayout P_0) => P_0.id == P_1.id);
				if (num > num2)
				{
					return 1;
				}
				if (num < num2)
				{
					return -1;
				}
				return 0;
			}
		}

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private ConfigVars configVars = new ConfigVars();

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private List<Player_Editor> players = new List<Player_Editor>();

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private List<InputAction> actions = new List<InputAction>();

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private List<InputCategory> actionCategories = new List<InputCategory>();

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private ActionCategoryMap actionCategoryMap = new ActionCategoryMap();

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private List<InputBehavior> inputBehaviors = new List<InputBehavior>();

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private List<InputMapCategory> mapCategories = new List<InputMapCategory>();

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private List<InputLayout> joystickLayouts = new List<InputLayout>();

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private List<InputLayout> keyboardLayouts = new List<InputLayout>();

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private List<InputLayout> mouseLayouts = new List<InputLayout>();

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private List<InputLayout> customControllerLayouts = new List<InputLayout>();

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private List<ControllerMap_Editor> joystickMaps = new List<ControllerMap_Editor>();

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private List<ControllerMap_Editor> keyboardMaps = new List<ControllerMap_Editor>();

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private List<ControllerMap_Editor> mouseMaps = new List<ControllerMap_Editor>();

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private List<ControllerMap_Editor> customControllerMaps = new List<ControllerMap_Editor>();

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private List<CustomController_Editor> customControllers = new List<CustomController_Editor>();

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private List<ControllerMapLayoutManager_RuleSet_Editor> controllerMapLayoutManagerRuleSets = new List<ControllerMapLayoutManager_RuleSet_Editor>();

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private List<ControllerMapEnabler_RuleSet_Editor> controllerMapEnablerRuleSets = new List<ControllerMapEnabler_RuleSet_Editor>();

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private int playerIdCounter;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private int actionIdCounter;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private int actionCategoryIdCounter;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private int inputBehaviorIdCounter;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private int mapCategoryIdCounter;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private int joystickLayoutIdCounter;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private int keyboardLayoutIdCounter;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private int mouseLayoutIdCounter;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private int customControllerLayoutIdCounter;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private int joystickMapIdCounter;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private int keyboardMapIdCounter;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private int mouseMapIdCounter;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private int customControllerMapIdCounter;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private int customControllerIdCounter;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private int controllerMapLayoutManagerSetIdCounter;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private int controllerMapEnablerSetIdCounter;

		private Func<int, bool> containsActionDelegate;

		internal IList<Player_Editor> Players_readOnly { get; private set; }

		internal IList<InputAction> Actions_readOnly { get; private set; }

		internal IList<InputCategory> ActionCategories_readOnly { get; private set; }

		internal IList<InputBehavior> InputBehaviors_readOnly { get; private set; }

		internal IList<InputMapCategory> MapCategories_readOnly { get; private set; }

		internal IList<InputLayout> JoystickLayouts_readOnly { get; private set; }

		internal IList<InputLayout> KeyboardLayouts_readOnly { get; private set; }

		internal IList<InputLayout> MouseLayouts_readOnly { get; private set; }

		internal IList<InputLayout> CustomControllerLayouts_readOnly { get; private set; }

		internal IList<ControllerMap_Editor> JoystickMaps_readOnly { get; private set; }

		internal IList<ControllerMap_Editor> KeyboardMaps_readOnly { get; private set; }

		internal IList<ControllerMap_Editor> MouseMaps_readOnly { get; private set; }

		internal IList<ControllerMap_Editor> CustomControllerMaps_readOnly { get; private set; }

		internal IList<ControllerMapLayoutManager_RuleSet_Editor> ControllerMapLayoutManagerRuleSets_readOnly { get; private set; }

		internal IList<ControllerMapEnabler_RuleSet_Editor> ControllerMapEnablerRuleSets_readOnly { get; private set; }

		public ConfigVars ConfigVars => configVars;

		internal IEnumerable<InputMapCategory> UserAssignableMapCategories
		{
			get
			{
				if (mapCategories == null)
				{
					yield break;
				}
				for (int i = 0; i < mapCategories.Count; i++)
				{
					if (mapCategories[i].userAssignable)
					{
						yield return mapCategories[i];
					}
				}
			}
		}

		internal IEnumerable<InputCategory> UserAssignableActionCategories
		{
			get
			{
				if (actionCategories == null)
				{
					yield break;
				}
				for (int i = 0; i < actionCategories.Count; i++)
				{
					if (actionCategories[i].userAssignable)
					{
						yield return actionCategories[i];
					}
				}
			}
		}

		internal IEnumerable<InputAction> UserAssignableActions
		{
			get
			{
				if (actions == null)
				{
					yield break;
				}
				for (int i = 0; i < actions.Count; i++)
				{
					InputAction inputAction = actions[i];
					InputCategory actionCategoryById = GetActionCategoryById(inputAction.categoryId);
					if (actionCategoryById != null && actionCategoryById.userAssignable && inputAction.userAssignable)
					{
						yield return inputAction;
					}
				}
			}
		}

		public int playerCount
		{
			get
			{
				if (players == null)
				{
					return 0;
				}
				return players.Count;
			}
		}

		internal IEnumerable<InputMapCategory> omMeSAgRILbFGysHCiijxiOCwjhG(string P_0)
		{
			if (P_0 == null || P_0 == string.Empty || mapCategories == null)
			{
				yield break;
			}
			for (int i = 0; i < mapCategories.Count; i++)
			{
				if (mapCategories[i].tag.Equals(P_0, StringComparison.OrdinalIgnoreCase))
				{
					yield return mapCategories[i];
				}
			}
		}

		internal IEnumerable<InputMapCategory> EQWXTXhBrWcbZxvqlHenKOZtezh(string P_0)
		{
			if (P_0 == null || P_0 == string.Empty || mapCategories == null)
			{
				yield break;
			}
			for (int i = 0; i < mapCategories.Count; i++)
			{
				if (mapCategories[i].userAssignable && mapCategories[i].tag.Equals(P_0, StringComparison.OrdinalIgnoreCase))
				{
					yield return mapCategories[i];
				}
			}
		}

		internal IEnumerable<InputCategory> UUxmdpMwgZXPVUocMoXINdHNmjG(string P_0)
		{
			if (P_0 == null || P_0 == string.Empty || actionCategories == null)
			{
				yield break;
			}
			for (int i = 0; i < actionCategories.Count; i++)
			{
				if (actionCategories[i].tag.Equals(P_0, StringComparison.OrdinalIgnoreCase))
				{
					yield return actionCategories[i];
				}
			}
		}

		internal IEnumerable<InputCategory> iTUxJGNZJxkllXnqqcvUGuiVTTpa(string P_0)
		{
			if (P_0 == null || P_0 == string.Empty || actionCategories == null)
			{
				yield break;
			}
			for (int i = 0; i < actionCategories.Count; i++)
			{
				if (actionCategories[i].userAssignable && actionCategories[i].tag.Equals(P_0, StringComparison.OrdinalIgnoreCase))
				{
					yield return actionCategories[i];
				}
			}
		}

		internal IEnumerable<InputAction> FbMTMfclPyrIMgWdUJtTfcwVTEx(int P_0, bool P_1)
		{
			if (actions == null || actionCategories == null)
			{
				yield break;
			}
			if (P_1)
			{
				foreach (int item in SortedActionIdsInCategory(P_0))
				{
					InputAction actionById = GetActionById(item);
					if (actionById != null)
					{
						yield return actionById;
					}
				}
				yield break;
			}
			for (int i = 0; i < actions.Count; i++)
			{
				if (actions[i].categoryId == P_0)
				{
					yield return actions[i];
				}
			}
		}

		internal IEnumerable<InputAction> FbMTMfclPyrIMgWdUJtTfcwVTEx(string P_0, bool P_1)
		{
			if (actions == null || actionCategories == null || P_0 == null || P_0 == string.Empty)
			{
				yield break;
			}
			int num = IndexOfActionCategory(P_0);
			if (num < 0)
			{
				yield break;
			}
			InputCategory actionCategory = GetActionCategory(num);
			if (P_1)
			{
				foreach (int item in SortedActionIdsInCategory(actionCategory.id))
				{
					InputAction actionById = GetActionById(item);
					if (actionById != null)
					{
						yield return actionById;
					}
				}
				yield break;
			}
			for (int i = 0; i < actions.Count; i++)
			{
				if (actions[i].categoryId == actionCategory.id)
				{
					yield return actions[i];
				}
			}
		}

		internal IEnumerable<InputAction> UBpHgnbvoMgQneSuFrajdsXWOOGJ(string P_0)
		{
			if (actions == null || actionCategories == null || P_0 == null || P_0 == string.Empty)
			{
				yield break;
			}
			int count = actions.Count;
			for (int i = 0; i < actionCategories.Count; i++)
			{
				if (!actionCategories[i].tag.Equals(P_0, StringComparison.OrdinalIgnoreCase))
				{
					continue;
				}
				InputCategory inputCategory = actionCategories[i];
				for (int j = 0; j < count; j++)
				{
					if (inputCategory.id == actions[j].categoryId)
					{
						yield return actions[j];
					}
				}
			}
		}

		internal IEnumerable<InputAction> eAcenbsjwJTMmxncYwLRKgaIAVj(int P_0, bool P_1)
		{
			if (actions == null || actionCategories == null)
			{
				yield break;
			}
			InputCategory actionCategoryById = GetActionCategoryById(P_0);
			if (actionCategoryById == null || !actionCategoryById.userAssignable)
			{
				yield break;
			}
			if (P_1)
			{
				foreach (int item in SortedActionIdsInCategory(actionCategoryById.id))
				{
					InputAction actionById = GetActionById(item);
					if (actionById != null && actionById.userAssignable)
					{
						yield return actionById;
					}
				}
				yield break;
			}
			for (int i = 0; i < actions.Count; i++)
			{
				InputAction inputAction = actions[i];
				if (inputAction.categoryId == actionCategoryById.id && inputAction.userAssignable)
				{
					yield return inputAction;
				}
			}
		}

		internal IEnumerable<InputAction> eAcenbsjwJTMmxncYwLRKgaIAVj(string P_0, bool P_1)
		{
			if (actions == null || actionCategories == null)
			{
				yield break;
			}
			InputCategory actionCategory = GetActionCategory(P_0);
			if (actionCategory == null || !actionCategory.userAssignable)
			{
				yield break;
			}
			if (P_1)
			{
				foreach (int item in SortedActionIdsInCategory(actionCategory.id))
				{
					InputAction actionById = GetActionById(item);
					if (actionById != null && actionById.userAssignable)
					{
						yield return actionById;
					}
				}
				yield break;
			}
			for (int i = 0; i < actions.Count; i++)
			{
				InputAction inputAction = actions[i];
				if (inputAction.categoryId == actionCategory.id && inputAction.userAssignable)
				{
					yield return inputAction;
				}
			}
		}

		public UserData()
			: this(init: true)
		{
		}

		private UserData(bool init)
		{
			if (init)
			{
				configVars.updateLoop = UpdateLoopSetting.Update;
				configVars.defaultJoystickAxis2DDeadZoneType = DeadZone2DType.Radial;
				configVars.defaultJoystickAxis2DSensitivityType = AxisSensitivity2DType.Radial;
				Player_Editor player_Editor = aAltqjYcdwwTUslukyvBnpOgfuL();
				player_Editor.name = "System";
				player_Editor.descriptiveName = player_Editor.name;
				player_Editor.id = 9999999;
				player_Editor.startPlaying = true;
				player_Editor.assignMouseOnStart = true;
				player_Editor.assignKeyboardOnStart = true;
				player_Editor.excludeFromControllerAutoAssignment = true;
				players.Add(player_Editor);
				InputCategory inputCategory = hNvnukDSENvHZQlIAAyFHTSLQeQJ();
				inputCategory.name = "Default";
				inputCategory.descriptiveName = inputCategory.name;
				actionCategories.Add(inputCategory);
				actionCategoryMap.AddCategory(inputCategory.id);
				InputBehavior inputBehavior = AXXqXFurVLGrkSvrtkBqyYZhfbO();
				inputBehavior.name = "Default";
				inputBehaviors.Add(inputBehavior);
				InputMapCategory inputMapCategory = CjigcWKkXuPQIoMVFurArKZRGgi();
				inputMapCategory.name = "Default";
				inputMapCategory.descriptiveName = inputMapCategory.name;
				mapCategories.Add(inputMapCategory);
				InputLayout inputLayout = DxAuZbwceYYzJybuCXnHnrWeHOm();
				inputLayout.name = "Default";
				inputLayout.descriptiveName = inputLayout.name;
				joystickLayouts.Add(inputLayout);
				InputLayout inputLayout2 = gZlkYLWAePxqzyDKJaWRMvlfedOF();
				inputLayout2.name = "Default";
				inputLayout2.descriptiveName = inputLayout2.name;
				keyboardLayouts.Add(inputLayout2);
				InputLayout inputLayout3 = ELeFZkPPoLFIBkDZCHmOFmqEWFii();
				inputLayout3.name = "Default";
				inputLayout3.descriptiveName = inputLayout3.name;
				mouseLayouts.Add(inputLayout3);
				InputLayout inputLayout4 = FEoHVHNLtbBjQHpnWSDFfOnvScls();
				inputLayout4.name = "Default";
				inputLayout4.descriptiveName = inputLayout4.name;
				customControllerLayouts.Add(inputLayout3);
			}
		}

		public List<InputAction> GetActions_Copy()
		{
			List<InputAction> list = new List<InputAction>();
			for (int i = 0; i < actions.Count; i++)
			{
				list.Add(actions[i]);
			}
			return list;
		}

		public List<InputBehavior> GetInputBehaviors_Copy()
		{
			List<InputBehavior> list = new List<InputBehavior>();
			for (int i = 0; i < inputBehaviors.Count; i++)
			{
				list.Add(inputBehaviors[i].Clone());
			}
			return list;
		}

		public List<KeyboardMap> GetKeyboardMaps_Copy()
		{
			List<KeyboardMap> list = new List<KeyboardMap>();
			for (int i = 0; i < keyboardMaps.Count; i++)
			{
				KeyboardMap item = keyboardMaps[i].qxIxfrIfXCdWrMeQFwEWVyXIlZc(containsActionDelegate);
				list.Add(item);
			}
			return list;
		}

		public List<MouseMap> GetMouseMaps_Copy()
		{
			List<MouseMap> list = new List<MouseMap>();
			for (int i = 0; i < mouseMaps.Count; i++)
			{
				MouseMap item = mouseMaps[i].lwWJkrZeZWFgmwrRFwpDWhFRRNe(containsActionDelegate);
				list.Add(item);
			}
			return list;
		}

		public void AddPlayer()
		{
			players.Add(aAltqjYcdwwTUslukyvBnpOgfuL());
		}

		public void InsertPlayer(int index)
		{
			if (index < 0 || index >= players.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			players.Insert(index, aAltqjYcdwwTUslukyvBnpOgfuL());
		}

		public void DeletePlayer(int index)
		{
			if (players == null || index < 0 || index >= players.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			players.RemoveAt(index);
		}

		public bool ReorderPlayer(int index, bool offsetDown, bool offsetNow)
		{
			return ListTools.OffsetAtIndex(players, index, offsetDown, offsetNow);
		}

		public void DuplicatePlayer(int index)
		{
			if (players == null || index < 0 || index >= players.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			Player_Editor player_Editor = players[index].Clone();
			player_Editor.id = GetNewPlayerId();
			player_Editor.name = StringTools.IterateName(player_Editor.name, -1, GetPlayerNames());
			player_Editor.assignMouseOnStart = false;
			if (index == players.Count - 1)
			{
				players.Add(player_Editor);
			}
			else
			{
				players.Insert(index + 1, player_Editor);
			}
		}

		public string[] GetPlayerNames()
		{
			if (players == null)
			{
				return null;
			}
			string[] array = new string[players.Count];
			for (int i = 0; i < players.Count; i++)
			{
				array[i] = players[i].name;
			}
			return array;
		}

		public int GetPlayerNames(IList<string> results)
		{
			if (results == null)
			{
				throw new ArgumentNullException("results");
			}
			results.Clear();
			if (players == null)
			{
				return 0;
			}
			for (int i = 0; i < players.Count; i++)
			{
				results.Add(players[i].name);
			}
			return results.Count;
		}

		public int[] GetPlayerIds()
		{
			if (players == null)
			{
				return null;
			}
			int[] array = new int[players.Count];
			for (int i = 0; i < players.Count; i++)
			{
				array[i] = players[i].id;
			}
			return array;
		}

		public int[] GetPlayerRuntimeIds()
		{
			if (players == null)
			{
				return null;
			}
			int[] array = new int[players.Count];
			for (int i = 0; i < players.Count; i++)
			{
				if (i == 0)
				{
					array[i] = 9999999;
				}
				else
				{
					array[i] = i - 1;
				}
			}
			return array;
		}

		public int GetPlayerRuntimeIds(IList<int> results)
		{
			if (results == null)
			{
				throw new ArgumentNullException("results");
			}
			results.Clear();
			if (players == null)
			{
				return 0;
			}
			for (int i = 0; i < players.Count; i++)
			{
				if (i == 0)
				{
					results.Add(9999999);
				}
				else
				{
					results.Add(i - 1);
				}
			}
			return results.Count;
		}

		public string GetPlayerNameById(int id)
		{
			if (players == null)
			{
				return string.Empty;
			}
			for (int i = 0; i < players.Count; i++)
			{
				if (players[i].id == id)
				{
					return players[i].name;
				}
			}
			return string.Empty;
		}

		public Player_Editor GetPlayer(int index)
		{
			if (players == null || index < 0 || index >= players.Count)
			{
				return null;
			}
			return players[index];
		}

		public int GetPlayerId(string name)
		{
			if (players == null)
			{
				return -1;
			}
			for (int i = 0; i < players.Count; i++)
			{
				if (players[i].name.Equals(name, StringComparison.OrdinalIgnoreCase))
				{
					return players[i].id;
				}
			}
			return -1;
		}

		public bool IsMouseAssigned()
		{
			if (players == null)
			{
				return false;
			}
			int count = players.Count;
			for (int i = 0; i < count; i++)
			{
				if (players[i].assignMouseOnStart)
				{
					return true;
				}
			}
			return false;
		}

		public void ClearMouseAssignments()
		{
			if (players != null)
			{
				int count = players.Count;
				for (int i = 0; i < count; i++)
				{
					players[i].assignMouseOnStart = false;
				}
			}
		}

		public bool IsKeyboardAssigned()
		{
			if (players == null)
			{
				return false;
			}
			int count = players.Count;
			for (int i = 0; i < count; i++)
			{
				if (players[i].assignKeyboardOnStart)
				{
					return true;
				}
			}
			return false;
		}

		public void ClearKeyboardAssignments()
		{
			if (players != null)
			{
				int count = players.Count;
				for (int i = 0; i < count; i++)
				{
					players[i].assignKeyboardOnStart = false;
				}
			}
		}

		public void AddAction(int categoryId)
		{
			InputAction inputAction = ELYbXuHvWHcWAmBZtwnhJvbNpvST();
			inputAction.categoryId = categoryId;
			actions.Add(inputAction);
			actionCategoryMap.AddAction(categoryId, inputAction.id);
		}

		public void InsertAction(int categoryId, int actionId)
		{
			if (actions != null)
			{
				InputAction inputAction = ELYbXuHvWHcWAmBZtwnhJvbNpvST();
				inputAction.categoryId = categoryId;
				actions.Add(inputAction);
				int index = actionCategoryMap.IndexOfAction(categoryId, actionId);
				actionCategoryMap.InsertAction(categoryId, inputAction.id, index);
			}
		}

		public void DeleteAction(int categoryId, int actionId)
		{
			int num = IndexOfActionCategory(categoryId);
			if (num >= 0)
			{
				int num2 = IndexOfAction(actionId);
				if (num2 >= 0)
				{
					actions.RemoveAt(num2);
					actionCategoryMap.RemoveAction(categoryId, actionId);
				}
			}
		}

		public bool ReorderAction(int categoryId, int actionId, bool offsetDown, bool offsetNow)
		{
			return actionCategoryMap.ReorderAction(categoryId, actionId, offsetDown, offsetNow);
		}

		public int DuplicateAction_FromButton(int categoryId, int actionId)
		{
			int num = IndexOfActionCategory(categoryId);
			if (num < 0)
			{
				return -1;
			}
			int num2 = IndexOfAction(actionId);
			if (num2 < 0)
			{
				return -1;
			}
			InputAction actionById = GetActionById(actionId);
			if (actionById == null)
			{
				return -1;
			}
			InputAction inputAction = actionById.Clone();
			inputAction.id = GetNewActionId();
			inputAction.name = StringTools.IterateName(inputAction.name, -1, GetActionNames());
			if (num2 == actions.Count - 1)
			{
				actions.Add(inputAction);
				actionCategoryMap.AddAction(categoryId, inputAction.id);
				return actions.Count - 1;
			}
			actions.Insert(num2 + 1, inputAction);
			int num3 = actionCategoryMap.IndexOfAction(categoryId, actionId);
			actionCategoryMap.InsertAction(categoryId, inputAction.id, num3 + 1);
			return num2 + 1;
		}

		private int PYNvoWrYrhrniUVNDtMTdUMMfzF(int P_0, InputAction P_1)
		{
			int num = IndexOfActionCategory(P_0);
			if (num < 0)
			{
				return -1;
			}
			InputAction inputAction = P_1.Clone();
			inputAction.id = GetNewActionId();
			inputAction.name = StringTools.IterateName(inputAction.name, -1, GetActionNames());
			actions.Add(inputAction);
			return actions.Count - 1;
		}

		public string[] GetActionNames()
		{
			if (actions == null)
			{
				return null;
			}
			string[] array = new string[actions.Count];
			for (int i = 0; i < actions.Count; i++)
			{
				array[i] = actions[i].name;
			}
			return array;
		}

		public int GetActionNames(IList<string> results)
		{
			if (results == null)
			{
				throw new ArgumentNullException("results");
			}
			results.Clear();
			if (actions == null)
			{
				return 0;
			}
			for (int i = 0; i < actions.Count; i++)
			{
				results.Add(actions[i].name);
			}
			return results.Count;
		}

		public int[] GetActionIds()
		{
			if (actions == null)
			{
				return null;
			}
			int[] array = new int[actions.Count];
			for (int i = 0; i < actions.Count; i++)
			{
				array[i] = actions[i].id;
			}
			return array;
		}

		public int GetActionIds(IList<int> results)
		{
			if (results == null)
			{
				throw new ArgumentNullException("results");
			}
			results.Clear();
			if (actions == null)
			{
				return 0;
			}
			for (int i = 0; i < actions.Count; i++)
			{
				results.Add(actions[i].id);
			}
			return results.Count;
		}

		public string GetActionNameById(int id)
		{
			if (actions == null)
			{
				return string.Empty;
			}
			for (int i = 0; i < actions.Count; i++)
			{
				if (actions[i].id == id)
				{
					return actions[i].name;
				}
			}
			return string.Empty;
		}

		public InputAction GetAction(int index)
		{
			if (actions == null || index < 0 || index >= actions.Count)
			{
				return null;
			}
			return actions[index];
		}

		public InputAction GetAction(string name)
		{
			if (actions == null)
			{
				return null;
			}
			int num = IndexOfAction(name);
			if (num < 0)
			{
				return null;
			}
			return actions[num];
		}

		public InputAction GetActionById(int id)
		{
			if (actions == null)
			{
				return null;
			}
			for (int i = 0; i < actions.Count; i++)
			{
				if (actions[i].id == id)
				{
					return actions[i];
				}
			}
			return null;
		}

		public int GetActionId(string name)
		{
			if (actions == null)
			{
				return -1;
			}
			int num = IndexOfAction(name);
			if (num < 0)
			{
				return -1;
			}
			return actions[num].id;
		}

		public string[] GetSortedActionNamesInCategory(int id)
		{
			if (actionCategories == null || actions == null)
			{
				return null;
			}
			List<string> list = new List<string>();
			foreach (int item in actionCategoryMap.ActionIdsInCategory(id))
			{
				InputAction actionById = GetActionById(item);
				if (actionById != null)
				{
					list.Add(actionById.name);
				}
			}
			return list.ToArray();
		}

		public IEnumerable<string> SortedActionNamesInCategory(int id)
		{
			if (actionCategories == null || actions == null)
			{
				yield break;
			}
			foreach (int item in actionCategoryMap.ActionIdsInCategory(id))
			{
				InputAction actionById = GetActionById(item);
				if (actionById != null)
				{
					yield return actionById.name;
				}
			}
		}

		public string[] GetSortedActionDescriptiveNamesInCategory(int id)
		{
			if (actionCategories == null || actions == null)
			{
				return null;
			}
			List<string> list = new List<string>();
			foreach (int item in actionCategoryMap.ActionIdsInCategory(id))
			{
				InputAction actionById = GetActionById(item);
				if (actionById != null)
				{
					list.Add(actionById.descriptiveName);
				}
			}
			return list.ToArray();
		}

		public IEnumerable<string> SortedActionDescriptiveNamesInCategory(int id)
		{
			if (actionCategories == null || actions == null)
			{
				yield break;
			}
			foreach (int item in actionCategoryMap.ActionIdsInCategory(id))
			{
				InputAction actionById = GetActionById(item);
				if (actionById != null)
				{
					yield return actionById.descriptiveName;
				}
			}
		}

		public int[] GetSortedActionIdsInCategory(int id)
		{
			if (actionCategories == null || actions == null)
			{
				return null;
			}
			List<int> list = new List<int>();
			foreach (int item in actionCategoryMap.ActionIdsInCategory(id))
			{
				list.Add(item);
			}
			return list.ToArray();
		}

		public IEnumerable<int> SortedActionIdsInCategory(int id)
		{
			if (actionCategories == null || actions == null)
			{
				yield break;
			}
			foreach (int item in actionCategoryMap.ActionIdsInCategory(id))
			{
				yield return item;
			}
		}

		public bool ContainsAction(int id)
		{
			return IndexOfAction(id) >= 0;
		}

		public int IndexOfAction(int id)
		{
			if (actions == null)
			{
				return -1;
			}
			for (int i = 0; i < actions.Count; i++)
			{
				if (actions[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public int IndexOfAction(string name)
		{
			if (actions == null)
			{
				return -1;
			}
			if (name == null || name == string.Empty)
			{
				return -1;
			}
			for (int i = 0; i < actions.Count; i++)
			{
				if (actions[i].name.Equals(name, StringComparison.OrdinalIgnoreCase))
				{
					return i;
				}
			}
			return -1;
		}

		public void AddActionCategory()
		{
			InputCategory inputCategory = hNvnukDSENvHZQlIAAyFHTSLQeQJ();
			actionCategories.Add(inputCategory);
			actionCategoryMap.AddCategory(inputCategory.id);
		}

		public void InsertActionCategory(int index)
		{
			if (index < 0 || index >= actionCategories.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			InputCategory inputCategory = hNvnukDSENvHZQlIAAyFHTSLQeQJ();
			actionCategories.Insert(index, inputCategory);
			actionCategoryMap.AddCategory(inputCategory.id);
		}

		public void DeleteActionCategory(int index)
		{
			if (actionCategories == null || index < 0 || index >= actionCategories.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int id = actionCategories[index].id;
			actionCategoryMap.RemoveCategory(id);
			if (actions != null)
			{
				for (int num = actions.Count - 1; num >= 0; num--)
				{
					if (actions[num].categoryId == id)
					{
						actions.RemoveAt(num);
					}
				}
			}
			actionCategories.RemoveAt(index);
		}

		public bool ReorderActionCategory(int index, bool offsetDown, bool offsetNow)
		{
			if (index < 0 || index >= actionCategories.Count)
			{
				return false;
			}
			return ListTools.OffsetAtIndex(actionCategories, index, offsetDown, offsetNow);
		}

		public void DuplicateActionCategory(int index, bool duplicateActions)
		{
			if (actionCategories == null || index < 0 || index >= actionCategories.Count)
			{
				return;
			}
			InputCategory inputCategory = new InputCategory(actionCategories[index]);
			inputCategory.id = GetNewActionCategoryId();
			inputCategory.name = StringTools.IterateName(inputCategory.name, -1, GetActionCategoryNames());
			if (index == actionCategories.Count - 1)
			{
				actionCategories.Add(inputCategory);
			}
			else
			{
				actionCategories.Insert(index + 1, inputCategory);
			}
			actionCategoryMap.AddCategory(inputCategory.id);
			if (!duplicateActions || actions == null)
			{
				return;
			}
			int id = inputCategory.id;
			int id2 = actionCategories[index].id;
			List<int> list = new List<int>();
			for (int i = 0; i < actions.Count; i++)
			{
				if (actions[i].categoryId == id2)
				{
					list.Add(i);
				}
			}
			Dictionary<int, int> dictionary = new Dictionary<int, int>(list.Count);
			for (int j = 0; j < list.Count; j++)
			{
				InputAction inputAction = actions[list[j]];
				int num = PYNvoWrYrhrniUVNDtMTdUMMfzF(id2, inputAction);
				if (num >= 0)
				{
					InputAction inputAction2 = actions[num];
					inputAction2.categoryId = id;
					dictionary.Add(inputAction.id, inputAction2.id);
				}
			}
			foreach (int item in actionCategoryMap.ActionIdsInCategory(id2))
			{
				if (dictionary.TryGetValue(item, out var value))
				{
					actionCategoryMap.AddAction(id, value);
				}
			}
		}

		public void ChangeActionCategory(int actionId, int newCategoryId)
		{
			int num = IndexOfAction(actionId);
			if (num >= 0 && actions[num].categoryId != newCategoryId)
			{
				actionCategoryMap.ChangeCategory(actionId, newCategoryId);
				actions[num].categoryId = newCategoryId;
			}
		}

		public int GetActionCategoryCount(int id)
		{
			if (actionCategories == null)
			{
				return 0;
			}
			int num = 0;
			if (actions != null)
			{
				for (int i = 0; i < actions.Count; i++)
				{
					if (actions[i].categoryId == id)
					{
						num++;
					}
				}
			}
			return num;
		}

		public int GetActionCategoryIndex(int id)
		{
			if (actionCategories == null)
			{
				return 0;
			}
			for (int i = 0; i < actionCategories.Count; i++)
			{
				if (actionCategories[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public string[] GetActionCategoryNames()
		{
			if (actionCategories == null)
			{
				return null;
			}
			string[] array = new string[actionCategories.Count];
			for (int i = 0; i < actionCategories.Count; i++)
			{
				array[i] = actionCategories[i].name;
			}
			return array;
		}

		public int[] GetActionCategoryIds()
		{
			if (actionCategories == null)
			{
				return null;
			}
			int[] array = new int[actionCategories.Count];
			for (int i = 0; i < actionCategories.Count; i++)
			{
				array[i] = actionCategories[i].id;
			}
			return array;
		}

		public InputCategory GetActionCategory(int index)
		{
			if (actionCategories == null || index < 0 || index >= actionCategories.Count)
			{
				return null;
			}
			return actionCategories[index];
		}

		public InputCategory GetActionCategory(string name)
		{
			if (actionCategories == null)
			{
				return null;
			}
			int num = IndexOfActionCategory(name);
			if (num < 0)
			{
				return null;
			}
			return actionCategories[num];
		}

		public InputCategory GetActionCategoryById(int id)
		{
			int num = IndexOfActionCategory(id);
			if (num < 0)
			{
				return null;
			}
			return actionCategories[num];
		}

		public int GetActionCategoryId(string name)
		{
			if (actionCategories == null)
			{
				return -1;
			}
			int num = IndexOfActionCategory(name);
			if (num < 0)
			{
				return -1;
			}
			return actionCategories[num].id;
		}

		public string GetActionCategoryNameById(int id)
		{
			if (actionCategories == null)
			{
				return string.Empty;
			}
			for (int i = 0; i < actionCategories.Count; i++)
			{
				if (actionCategories[i].id == id)
				{
					return actionCategories[i].name;
				}
			}
			return string.Empty;
		}

		public int IndexOfActionCategory(int id)
		{
			if (actionCategories == null)
			{
				return -1;
			}
			for (int i = 0; i < actionCategories.Count; i++)
			{
				if (actionCategories[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public int IndexOfActionCategory(string name)
		{
			if (name == null || name == string.Empty)
			{
				return -1;
			}
			if (actionCategories == null)
			{
				return -1;
			}
			for (int i = 0; i < actionCategories.Count; i++)
			{
				if (actionCategories[i].name.Equals(name, StringComparison.OrdinalIgnoreCase))
				{
					return i;
				}
			}
			return -1;
		}

		public int GetActionCategoryCount()
		{
			if (actionCategories == null)
			{
				return 0;
			}
			return actionCategories.Count;
		}

		public void AddInputBehavior()
		{
			inputBehaviors.Add(AXXqXFurVLGrkSvrtkBqyYZhfbO());
		}

		public void InsertInputBehavior(int index)
		{
			if (index < 0 || index >= inputBehaviors.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			inputBehaviors.Insert(index, AXXqXFurVLGrkSvrtkBqyYZhfbO());
		}

		public void DeleteInputBehavior(int index)
		{
			if (inputBehaviors == null || index < 0 || index >= inputBehaviors.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int id = inputBehaviors[index].id;
			if (actions != null)
			{
				for (int i = 0; i < actions.Count; i++)
				{
					if (actions[i].behaviorId == id)
					{
						actions[i].behaviorId = 0;
					}
				}
			}
			inputBehaviors.RemoveAt(index);
		}

		public bool ReorderInputBehavior(int index, bool offsetDown, bool offsetNow)
		{
			return ListTools.OffsetAtIndex(inputBehaviors, index, offsetDown, offsetNow);
		}

		public void DuplicateInputBehavior(int index)
		{
			if (inputBehaviors == null || index < 0 || index >= inputBehaviors.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			InputBehavior inputBehavior = inputBehaviors[index].Clone();
			inputBehavior.id = GetNewInputBehaviorId();
			inputBehavior.name = StringTools.IterateName(inputBehavior.name, -1, GetInputBehaviorNames());
			if (index == inputBehaviors.Count - 1)
			{
				inputBehaviors.Add(inputBehavior);
			}
			else
			{
				inputBehaviors.Insert(index + 1, inputBehavior);
			}
		}

		public string[] GetInputBehaviorNames()
		{
			if (inputBehaviors == null)
			{
				return null;
			}
			string[] array = new string[inputBehaviors.Count];
			for (int i = 0; i < inputBehaviors.Count; i++)
			{
				array[i] = inputBehaviors[i].name;
			}
			return array;
		}

		public int[] GetInputBehaviorIds()
		{
			if (inputBehaviors == null)
			{
				return null;
			}
			int[] array = new int[inputBehaviors.Count];
			for (int i = 0; i < inputBehaviors.Count; i++)
			{
				array[i] = inputBehaviors[i].id;
			}
			return array;
		}

		public InputBehavior GetInputBehavior(int index)
		{
			if (inputBehaviors == null || index < 0 || index >= inputBehaviors.Count)
			{
				return null;
			}
			return inputBehaviors[index];
		}

		public InputBehavior GetInputBehavior(string name)
		{
			if (inputBehaviors == null)
			{
				return null;
			}
			int num = IndexOfInputBehavior(name);
			if (num < 0)
			{
				return null;
			}
			return inputBehaviors[num];
		}

		public InputBehavior GetInputBehaviorById(int id)
		{
			if (inputBehaviors == null)
			{
				return null;
			}
			for (int i = 0; i < inputBehaviors.Count; i++)
			{
				if (inputBehaviors[i].id == id)
				{
					return inputBehaviors[i];
				}
			}
			return null;
		}

		public int GetInputBehaviorId(string name)
		{
			if (inputBehaviors == null)
			{
				return -1;
			}
			int num = IndexOfInputBehavior(name);
			if (num < 0)
			{
				return -1;
			}
			return inputBehaviors[num].id;
		}

		public int IndexOfInputBehavior(int id)
		{
			if (inputBehaviors == null)
			{
				return -1;
			}
			for (int i = 0; i < inputBehaviors.Count; i++)
			{
				if (inputBehaviors[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public int IndexOfInputBehavior(string name)
		{
			if (inputBehaviors == null)
			{
				return -1;
			}
			if (name == null || name == string.Empty)
			{
				return -1;
			}
			for (int i = 0; i < inputBehaviors.Count; i++)
			{
				if (inputBehaviors[i].name.Equals(name, StringComparison.OrdinalIgnoreCase))
				{
					return i;
				}
			}
			return -1;
		}

		public void AddMapCategory()
		{
			mapCategories.Add(CjigcWKkXuPQIoMVFurArKZRGgi());
		}

		public void InsertMapCategory(int index)
		{
			if (index < 0 || index >= mapCategories.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			mapCategories.Insert(index, CjigcWKkXuPQIoMVFurArKZRGgi());
		}

		public void DeleteMapCategory(int index)
		{
			if (mapCategories == null || index < 0 || index >= mapCategories.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int id = mapCategories[index].id;
			if (joystickMaps != null)
			{
				for (int num = joystickMaps.Count - 1; num >= 0; num--)
				{
					if (joystickMaps[num].categoryId == id)
					{
						joystickMaps.RemoveAt(num);
					}
				}
			}
			if (keyboardMaps != null)
			{
				for (int num2 = keyboardMaps.Count - 1; num2 >= 0; num2--)
				{
					if (keyboardMaps[num2].categoryId == id)
					{
						keyboardMaps.RemoveAt(num2);
					}
				}
			}
			if (mouseMaps != null)
			{
				for (int num3 = mouseMaps.Count - 1; num3 >= 0; num3--)
				{
					if (mouseMaps[num3].categoryId == id)
					{
						mouseMaps.RemoveAt(num3);
					}
				}
			}
			if (customControllerMaps != null)
			{
				for (int num4 = customControllerMaps.Count - 1; num4 >= 0; num4--)
				{
					if (customControllerMaps[num4].categoryId == id)
					{
						customControllerMaps.RemoveAt(num4);
					}
				}
			}
			if (mapCategories != null)
			{
				for (int i = 0; i < mapCategories.Count; i++)
				{
					InputMapCategory inputMapCategory = mapCategories[i];
					if (inputMapCategory.checkConflictsCategoryIds == null)
					{
						continue;
					}
					for (int j = 0; j < inputMapCategory.checkConflictsCategoryIds.Count; j++)
					{
						if (inputMapCategory.checkConflictsCategoryIds[j] == id)
						{
							inputMapCategory.checkConflictsCategoryIds.RemoveAt(j);
						}
					}
				}
			}
			if (players != null)
			{
				Action<List<Player_Editor.Mapping>, int> action = delegate(List<Player_Editor.Mapping> P_0, int P_1)
				{
					if (P_0 != null)
					{
						for (int num5 = P_0.Count - 1; num5 >= 0; num5--)
						{
							if (P_0[num5] == null || P_0[num5].categoryId == P_1)
							{
								P_0.RemoveAt(num5);
							}
						}
					}
				};
				for (int k = 0; k < players.Count; k++)
				{
					Player_Editor player_Editor = players[k];
					if (player_Editor != null)
					{
						action(player_Editor.defaultKeyboardMaps, id);
						action(player_Editor.defaultMouseMaps, id);
						action(player_Editor.defaultJoystickMaps, id);
						action(player_Editor.defaultCustomControllerMaps, id);
					}
				}
			}
			mapCategories.RemoveAt(index);
		}

		public bool ReorderMapCategory(int index, bool offsetDown, bool offsetNow)
		{
			return ListTools.OffsetAtIndex(mapCategories, index, offsetDown, offsetNow);
		}

		public void DuplicateMapCategory(int index, bool duplicateMaps)
		{
			if (mapCategories == null || index < 0 || index >= mapCategories.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			InputMapCategory inputMapCategory = new InputMapCategory(mapCategories[index]);
			inputMapCategory.id = GetNewMapCategoryId();
			inputMapCategory.name = StringTools.IterateName(inputMapCategory.name, -1, GetMapCategoryNames());
			if (index == mapCategories.Count - 1)
			{
				mapCategories.Add(inputMapCategory);
			}
			else
			{
				mapCategories.Insert(index + 1, inputMapCategory);
			}
			if (!duplicateMaps)
			{
				return;
			}
			int id = inputMapCategory.id;
			int id2 = mapCategories[index].id;
			if (joystickMaps != null)
			{
				for (int num = joystickMaps.Count - 1; num >= 0; num--)
				{
					if (joystickMaps[num].categoryId == id2)
					{
						int num2 = DuplicateJoystickMap(num);
						if (num2 >= 0)
						{
							joystickMaps[num2].categoryId = id;
						}
					}
				}
			}
			if (keyboardMaps != null)
			{
				for (int num3 = keyboardMaps.Count - 1; num3 >= 0; num3--)
				{
					if (keyboardMaps[num3].categoryId == id2)
					{
						int num4 = DuplicateKeyboardMap(num3);
						if (num4 >= 0)
						{
							keyboardMaps[num4].categoryId = id;
						}
					}
				}
			}
			if (mouseMaps != null)
			{
				for (int num5 = mouseMaps.Count - 1; num5 >= 0; num5--)
				{
					if (mouseMaps[num5].categoryId == id2)
					{
						int num6 = DuplicateMouseMap(num5);
						if (num6 >= 0)
						{
							mouseMaps[num6].categoryId = id;
						}
					}
				}
			}
			if (customControllerMaps == null)
			{
				return;
			}
			for (int num7 = customControllerMaps.Count - 1; num7 >= 0; num7--)
			{
				if (customControllerMaps[num7].categoryId == id2)
				{
					int num8 = DuplicateCustomControllerMap(num7);
					if (num8 >= 0)
					{
						customControllerMaps[num8].categoryId = id;
					}
				}
			}
		}

		public int GetMapCategoryMapCount(int id)
		{
			if (mapCategories == null)
			{
				return 0;
			}
			int num = 0;
			if (joystickMaps != null)
			{
				for (int i = 0; i < joystickMaps.Count; i++)
				{
					if (joystickMaps[i].categoryId == id)
					{
						num++;
					}
				}
			}
			if (keyboardMaps != null)
			{
				for (int j = 0; j < keyboardMaps.Count; j++)
				{
					if (keyboardMaps[j].categoryId == id)
					{
						num++;
					}
				}
			}
			if (mouseMaps != null)
			{
				for (int k = 0; k < mouseMaps.Count; k++)
				{
					if (mouseMaps[k].categoryId == id)
					{
						num++;
					}
				}
			}
			if (customControllerMaps != null)
			{
				for (int l = 0; l < customControllerMaps.Count; l++)
				{
					if (customControllerMaps[l].categoryId == id)
					{
						num++;
					}
				}
			}
			return num;
		}

		public int GetMapCategoryIndex(int id)
		{
			if (mapCategories == null)
			{
				return 0;
			}
			for (int i = 0; i < mapCategories.Count; i++)
			{
				if (mapCategories[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public string[] GetMapCategoryNames()
		{
			if (mapCategories == null)
			{
				return null;
			}
			string[] array = new string[mapCategories.Count];
			for (int i = 0; i < mapCategories.Count; i++)
			{
				array[i] = mapCategories[i].name;
			}
			return array;
		}

		public int[] GetMapCategoryIds()
		{
			if (mapCategories == null)
			{
				return null;
			}
			int[] array = new int[mapCategories.Count];
			for (int i = 0; i < mapCategories.Count; i++)
			{
				array[i] = mapCategories[i].id;
			}
			return array;
		}

		public InputMapCategory GetMapCategory(int index)
		{
			if (mapCategories == null || index < 0 || index >= mapCategories.Count)
			{
				return null;
			}
			return mapCategories[index];
		}

		public InputMapCategory GetMapCategory(string name)
		{
			if (mapCategories == null)
			{
				return null;
			}
			int num = IndexOfMapCategory(name);
			if (num < 0)
			{
				return null;
			}
			return mapCategories[num];
		}

		public InputMapCategory GetMapCategoryById(int id)
		{
			if (mapCategories == null)
			{
				return null;
			}
			for (int i = 0; i < mapCategories.Count; i++)
			{
				if (mapCategories[i].id == id)
				{
					return mapCategories[i];
				}
			}
			return null;
		}

		public int GetMapCategoryId(string name)
		{
			if (mapCategories == null)
			{
				return -1;
			}
			int num = IndexOfMapCategory(name);
			if (num < 0)
			{
				return -1;
			}
			return mapCategories[num].id;
		}

		public string GetMapCategoryNameById(int id)
		{
			if (mapCategories == null)
			{
				return string.Empty;
			}
			for (int i = 0; i < mapCategories.Count; i++)
			{
				if (mapCategories[i].id == id)
				{
					return mapCategories[i].name;
				}
			}
			return string.Empty;
		}

		public int IndexOfMapCategory(int id)
		{
			if (mapCategories == null)
			{
				return -1;
			}
			for (int i = 0; i < mapCategories.Count; i++)
			{
				if (mapCategories[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public int IndexOfMapCategory(string name)
		{
			if (name == null || name == string.Empty)
			{
				return -1;
			}
			if (mapCategories == null)
			{
				return -1;
			}
			for (int i = 0; i < mapCategories.Count; i++)
			{
				if (mapCategories[i].name.Equals(name, StringComparison.OrdinalIgnoreCase))
				{
					return i;
				}
			}
			return -1;
		}

		public string[] GetLayoutNames(ControllerType controllerType)
		{
			return controllerType switch
			{
				ControllerType.Keyboard => GetKeyboardLayoutNames(), 
				ControllerType.Mouse => GetMouseLayoutNames(), 
				ControllerType.Joystick => GetJoystickLayoutNames(), 
				ControllerType.Custom => GetCustomControllerLayoutNames(), 
				_ => throw new NotImplementedException(), 
			};
		}

		public int[] GetLayoutIds(ControllerType controllerType)
		{
			return controllerType switch
			{
				ControllerType.Keyboard => GetKeyboardLayoutIds(), 
				ControllerType.Mouse => GetMouseLayoutIds(), 
				ControllerType.Joystick => GetJoystickLayoutIds(), 
				ControllerType.Custom => GetCustomControllerLayoutIds(), 
				_ => throw new NotImplementedException(), 
			};
		}

		public void AddJoystickLayout()
		{
			joystickLayouts.Add(DxAuZbwceYYzJybuCXnHnrWeHOm());
		}

		public void InsertJoystickLayout(int index)
		{
			if (index < 0 || index >= joystickLayouts.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			joystickLayouts.Insert(index, DxAuZbwceYYzJybuCXnHnrWeHOm());
		}

		public void DeleteJoystickLayout(int index)
		{
			if (joystickLayouts == null || index < 0 || index >= joystickLayouts.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int id = joystickLayouts[index].id;
			if (joystickMaps != null)
			{
				for (int num = joystickMaps.Count - 1; num >= 0; num--)
				{
					if (joystickMaps[num].layoutId == id)
					{
						joystickMaps.RemoveAt(num);
					}
				}
			}
			if (players != null)
			{
				Action<List<Player_Editor.Mapping>, int> action = delegate(List<Player_Editor.Mapping> P_0, int P_1)
				{
					if (P_0 != null)
					{
						for (int num2 = P_0.Count - 1; num2 >= 0; num2--)
						{
							if (P_0[num2] == null || P_0[num2].layoutId == P_1)
							{
								P_0.RemoveAt(num2);
							}
						}
					}
				};
				for (int i = 0; i < players.Count; i++)
				{
					Player_Editor player_Editor = players[i];
					if (player_Editor != null)
					{
						action(player_Editor.defaultJoystickMaps, id);
					}
				}
			}
			joystickLayouts.RemoveAt(index);
		}

		public bool ReorderJoystickLayout(int index, bool offsetDown, bool offsetNow)
		{
			return ListTools.OffsetAtIndex(joystickLayouts, index, offsetDown, offsetNow);
		}

		public void DuplicateJoystickLayout(int index, bool duplicateMaps)
		{
			if (joystickLayouts == null || index < 0 || index >= joystickLayouts.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			InputLayout inputLayout = joystickLayouts[index].Clone();
			inputLayout.id = GetNewJoystickLayoutId();
			inputLayout.name = StringTools.IterateName(inputLayout.name, -1, GetJoystickLayoutNames());
			if (index == joystickLayouts.Count - 1)
			{
				joystickLayouts.Add(inputLayout);
			}
			else
			{
				joystickLayouts.Insert(index + 1, inputLayout);
			}
			if (!duplicateMaps)
			{
				return;
			}
			int id = inputLayout.id;
			int id2 = joystickLayouts[index].id;
			if (joystickMaps == null)
			{
				return;
			}
			for (int num = joystickMaps.Count - 1; num >= 0; num--)
			{
				if (joystickMaps[num].layoutId == id2)
				{
					int num2 = DuplicateJoystickMap(num);
					if (num2 >= 0)
					{
						joystickMaps[num2].layoutId = id;
					}
				}
			}
		}

		public int GetJoystickLayoutMapCount(int id)
		{
			if (joystickLayouts == null)
			{
				return 0;
			}
			int num = 0;
			if (joystickMaps != null)
			{
				for (int i = 0; i < joystickMaps.Count; i++)
				{
					if (joystickMaps[i].layoutId == id)
					{
						num++;
					}
				}
			}
			return num;
		}

		public int GetJoystickLayoutIndex(int id)
		{
			if (joystickLayouts == null)
			{
				return 0;
			}
			for (int i = 0; i < joystickLayouts.Count; i++)
			{
				if (joystickLayouts[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public string[] GetJoystickLayoutNames()
		{
			if (joystickLayouts == null)
			{
				return null;
			}
			string[] array = new string[joystickLayouts.Count];
			for (int i = 0; i < joystickLayouts.Count; i++)
			{
				array[i] = joystickLayouts[i].name;
			}
			return array;
		}

		public int[] GetJoystickLayoutIds()
		{
			if (joystickLayouts == null)
			{
				return null;
			}
			int[] array = new int[joystickLayouts.Count];
			for (int i = 0; i < joystickLayouts.Count; i++)
			{
				array[i] = joystickLayouts[i].id;
			}
			return array;
		}

		public InputLayout GetJoystickLayout(int index)
		{
			if (joystickLayouts == null || index < 0 || index >= joystickLayouts.Count)
			{
				return null;
			}
			return joystickLayouts[index];
		}

		public InputLayout GetJoystickLayout(string name)
		{
			if (joystickLayouts == null)
			{
				return null;
			}
			int num = IndexOfJoystickLayout(name);
			if (num < 0)
			{
				return null;
			}
			return joystickLayouts[num];
		}

		public InputLayout GetJoystickLayoutById(int id)
		{
			if (joystickLayouts == null)
			{
				return null;
			}
			int num = IndexOfJoystickLayout(id);
			if (num < 0)
			{
				return null;
			}
			return joystickLayouts[num];
		}

		public int GetJoystickLayoutId(string name)
		{
			if (joystickLayouts == null)
			{
				return -1;
			}
			int num = IndexOfJoystickLayout(name);
			if (num < 0)
			{
				return -1;
			}
			return joystickLayouts[num].id;
		}

		public int IndexOfJoystickLayout(int id)
		{
			if (joystickLayouts == null)
			{
				return -1;
			}
			for (int i = 0; i < joystickLayouts.Count; i++)
			{
				if (joystickLayouts[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public int IndexOfJoystickLayout(string name)
		{
			if (name == null || name == string.Empty)
			{
				return -1;
			}
			if (joystickLayouts == null)
			{
				return -1;
			}
			for (int i = 0; i < joystickLayouts.Count; i++)
			{
				if (joystickLayouts[i].name.Equals(name, StringComparison.OrdinalIgnoreCase))
				{
					return i;
				}
			}
			return -1;
		}

		public string GetJoystickLayoutNameById(int id)
		{
			if (joystickLayouts != null)
			{
				for (int i = 0; i < joystickLayouts.Count; i++)
				{
					if (joystickLayouts[i].id == id)
					{
						return joystickLayouts[i].name;
					}
				}
			}
			return "Unknown";
		}

		public void AddKeyboardLayout()
		{
			keyboardLayouts.Add(gZlkYLWAePxqzyDKJaWRMvlfedOF());
		}

		public void InsertKeyboardLayout(int index)
		{
			if (index < 0 || index >= keyboardLayouts.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			keyboardLayouts.Insert(index, gZlkYLWAePxqzyDKJaWRMvlfedOF());
		}

		public void DeleteKeyboardLayout(int index)
		{
			if (keyboardLayouts == null || index < 0 || index >= keyboardLayouts.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int id = keyboardLayouts[index].id;
			if (keyboardMaps != null)
			{
				for (int num = keyboardMaps.Count - 1; num >= 0; num--)
				{
					if (keyboardMaps[num].layoutId == id)
					{
						keyboardMaps.RemoveAt(num);
					}
				}
			}
			if (players != null)
			{
				Action<List<Player_Editor.Mapping>, int> action = delegate(List<Player_Editor.Mapping> P_0, int P_1)
				{
					if (P_0 != null)
					{
						for (int num2 = P_0.Count - 1; num2 >= 0; num2--)
						{
							if (P_0[num2] == null || P_0[num2].layoutId == P_1)
							{
								P_0.RemoveAt(num2);
							}
						}
					}
				};
				for (int i = 0; i < players.Count; i++)
				{
					Player_Editor player_Editor = players[i];
					if (player_Editor != null)
					{
						action(player_Editor.defaultKeyboardMaps, id);
					}
				}
			}
			keyboardLayouts.RemoveAt(index);
		}

		public bool ReorderKeyboardLayout(int index, bool offsetDown, bool offsetNow)
		{
			return ListTools.OffsetAtIndex(keyboardLayouts, index, offsetDown, offsetNow);
		}

		public void DuplicateKeyboardLayout(int index, bool duplicateMaps)
		{
			if (keyboardLayouts == null || index < 0 || index >= keyboardLayouts.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			InputLayout inputLayout = keyboardLayouts[index].Clone();
			inputLayout.id = GetNewKeyboardLayoutId();
			inputLayout.name = StringTools.IterateName(inputLayout.name, -1, GetKeyboardLayoutNames());
			if (index == keyboardLayouts.Count - 1)
			{
				keyboardLayouts.Add(inputLayout);
			}
			else
			{
				keyboardLayouts.Insert(index + 1, inputLayout);
			}
			if (!duplicateMaps)
			{
				return;
			}
			int id = inputLayout.id;
			int id2 = keyboardLayouts[index].id;
			if (keyboardMaps == null)
			{
				return;
			}
			for (int num = keyboardMaps.Count - 1; num >= 0; num--)
			{
				if (keyboardMaps[num].layoutId == id2)
				{
					int num2 = DuplicateKeyboardMap(num);
					if (num2 >= 0)
					{
						keyboardMaps[num2].layoutId = id;
					}
				}
			}
		}

		public int GetKeyboardLayoutMapCount(int id)
		{
			if (keyboardLayouts == null)
			{
				return 0;
			}
			int num = 0;
			if (keyboardMaps != null)
			{
				for (int i = 0; i < keyboardMaps.Count; i++)
				{
					if (keyboardMaps[i].layoutId == id)
					{
						num++;
					}
				}
			}
			return num;
		}

		public int GetKeyboardLayoutIndex(int id)
		{
			if (keyboardLayouts == null)
			{
				return 0;
			}
			for (int i = 0; i < keyboardLayouts.Count; i++)
			{
				if (keyboardLayouts[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public string[] GetKeyboardLayoutNames()
		{
			if (keyboardLayouts == null)
			{
				return null;
			}
			string[] array = new string[keyboardLayouts.Count];
			for (int i = 0; i < keyboardLayouts.Count; i++)
			{
				array[i] = keyboardLayouts[i].name;
			}
			return array;
		}

		public int[] GetKeyboardLayoutIds()
		{
			if (keyboardLayouts == null)
			{
				return null;
			}
			int[] array = new int[keyboardLayouts.Count];
			for (int i = 0; i < keyboardLayouts.Count; i++)
			{
				array[i] = keyboardLayouts[i].id;
			}
			return array;
		}

		public InputLayout GetKeyboardLayout(int index)
		{
			if (keyboardLayouts == null || index < 0 || index >= keyboardLayouts.Count)
			{
				return null;
			}
			return keyboardLayouts[index];
		}

		public InputLayout GetKeyboardLayout(string name)
		{
			if (keyboardLayouts == null)
			{
				return null;
			}
			int num = IndexOfKeyboardLayout(name);
			if (num < 0)
			{
				return null;
			}
			return keyboardLayouts[num];
		}

		public InputLayout GetKeyboardLayoutById(int id)
		{
			if (keyboardLayouts == null)
			{
				return null;
			}
			int num = IndexOfKeyboardLayout(id);
			if (num < 0)
			{
				return null;
			}
			return keyboardLayouts[num];
		}

		public int GetKeyboardLayoutId(string name)
		{
			if (keyboardLayouts == null)
			{
				return -1;
			}
			int num = IndexOfKeyboardLayout(name);
			if (num < 0)
			{
				return -1;
			}
			return keyboardLayouts[num].id;
		}

		public int IndexOfKeyboardLayout(int id)
		{
			if (keyboardLayouts == null)
			{
				return -1;
			}
			for (int i = 0; i < keyboardLayouts.Count; i++)
			{
				if (keyboardLayouts[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public int IndexOfKeyboardLayout(string name)
		{
			if (name == null || name == string.Empty)
			{
				return -1;
			}
			if (keyboardLayouts == null)
			{
				return -1;
			}
			for (int i = 0; i < keyboardLayouts.Count; i++)
			{
				if (keyboardLayouts[i].name.Equals(name, StringComparison.OrdinalIgnoreCase))
				{
					return i;
				}
			}
			return -1;
		}

		public string GetKeyboardLayoutNameById(int id)
		{
			if (keyboardLayouts != null)
			{
				for (int i = 0; i < keyboardLayouts.Count; i++)
				{
					if (keyboardLayouts[i].id == id)
					{
						return keyboardLayouts[i].name;
					}
				}
			}
			return "Unknown";
		}

		public void AddMouseLayout()
		{
			mouseLayouts.Add(ELeFZkPPoLFIBkDZCHmOFmqEWFii());
		}

		public void InsertMouseLayout(int index)
		{
			if (index < 0 || index >= mouseLayouts.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			mouseLayouts.Insert(index, ELeFZkPPoLFIBkDZCHmOFmqEWFii());
		}

		public void DeleteMouseLayout(int index)
		{
			if (mouseLayouts == null || index < 0 || index >= mouseLayouts.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int id = mouseLayouts[index].id;
			if (mouseMaps != null)
			{
				for (int num = mouseMaps.Count - 1; num >= 0; num--)
				{
					if (mouseMaps[num].layoutId == id)
					{
						mouseMaps.RemoveAt(num);
					}
				}
			}
			if (players != null)
			{
				Action<List<Player_Editor.Mapping>, int> action = delegate(List<Player_Editor.Mapping> P_0, int P_1)
				{
					if (P_0 != null)
					{
						for (int num2 = P_0.Count - 1; num2 >= 0; num2--)
						{
							if (P_0[num2] == null || P_0[num2].layoutId == P_1)
							{
								P_0.RemoveAt(num2);
							}
						}
					}
				};
				for (int i = 0; i < players.Count; i++)
				{
					Player_Editor player_Editor = players[i];
					if (player_Editor != null)
					{
						action(player_Editor.defaultMouseMaps, id);
					}
				}
			}
			mouseLayouts.RemoveAt(index);
		}

		public bool ReorderMouseLayout(int index, bool offsetDown, bool offsetNow)
		{
			return ListTools.OffsetAtIndex(mouseLayouts, index, offsetDown, offsetNow);
		}

		public void DuplicateMouseLayout(int index, bool duplicateMaps)
		{
			if (mouseLayouts == null || index < 0 || index >= mouseLayouts.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			InputLayout inputLayout = mouseLayouts[index].Clone();
			inputLayout.id = GetNewMouseLayoutId();
			inputLayout.name = StringTools.IterateName(inputLayout.name, -1, GetMouseLayoutNames());
			if (index == mouseLayouts.Count - 1)
			{
				mouseLayouts.Add(inputLayout);
			}
			else
			{
				mouseLayouts.Insert(index + 1, inputLayout);
			}
			if (!duplicateMaps)
			{
				return;
			}
			int id = inputLayout.id;
			int id2 = mouseLayouts[index].id;
			if (mouseMaps == null)
			{
				return;
			}
			for (int num = mouseMaps.Count - 1; num >= 0; num--)
			{
				if (mouseMaps[num].layoutId == id2)
				{
					int num2 = DuplicateMouseMap(num);
					if (num2 >= 0)
					{
						mouseMaps[num2].layoutId = id;
					}
				}
			}
		}

		public int GetMouseLayoutMapCount(int id)
		{
			if (mouseLayouts == null)
			{
				return 0;
			}
			int num = 0;
			if (mouseMaps != null)
			{
				for (int i = 0; i < mouseMaps.Count; i++)
				{
					if (mouseMaps[i].layoutId == id)
					{
						num++;
					}
				}
			}
			return num;
		}

		public int GetMouseLayoutIndex(int id)
		{
			if (mouseLayouts == null)
			{
				return 0;
			}
			for (int i = 0; i < mouseLayouts.Count; i++)
			{
				if (mouseLayouts[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public string[] GetMouseLayoutNames()
		{
			if (mouseLayouts == null)
			{
				return null;
			}
			string[] array = new string[mouseLayouts.Count];
			for (int i = 0; i < mouseLayouts.Count; i++)
			{
				array[i] = mouseLayouts[i].name;
			}
			return array;
		}

		public int[] GetMouseLayoutIds()
		{
			if (mouseLayouts == null)
			{
				return null;
			}
			int[] array = new int[mouseLayouts.Count];
			for (int i = 0; i < mouseLayouts.Count; i++)
			{
				array[i] = mouseLayouts[i].id;
			}
			return array;
		}

		public InputLayout GetMouseLayout(int index)
		{
			if (mouseLayouts == null || index < 0 || index >= mouseLayouts.Count)
			{
				return null;
			}
			return mouseLayouts[index];
		}

		public InputLayout GetMouseLayout(string name)
		{
			if (mouseLayouts == null)
			{
				return null;
			}
			int num = IndexOfMouseLayout(name);
			if (num < 0)
			{
				return null;
			}
			return mouseLayouts[num];
		}

		public InputLayout GetMouseLayoutById(int id)
		{
			if (mouseLayouts == null)
			{
				return null;
			}
			int num = IndexOfMouseLayout(id);
			if (num < 0)
			{
				return null;
			}
			return mouseLayouts[num];
		}

		public int GetMouseLayoutId(string name)
		{
			if (mouseLayouts == null)
			{
				return -1;
			}
			int num = IndexOfMouseLayout(name);
			if (num < 0)
			{
				return -1;
			}
			return mouseLayouts[num].id;
		}

		public int IndexOfMouseLayout(int id)
		{
			if (mouseLayouts == null)
			{
				return -1;
			}
			for (int i = 0; i < mouseLayouts.Count; i++)
			{
				if (mouseLayouts[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public int IndexOfMouseLayout(string name)
		{
			if (name == null || name == string.Empty)
			{
				return -1;
			}
			if (mouseLayouts == null)
			{
				return -1;
			}
			for (int i = 0; i < mouseLayouts.Count; i++)
			{
				if (mouseLayouts[i].name.Equals(name, StringComparison.OrdinalIgnoreCase))
				{
					return i;
				}
			}
			return -1;
		}

		public string GetMouseLayoutNameById(int id)
		{
			if (mouseLayouts != null)
			{
				for (int i = 0; i < mouseLayouts.Count; i++)
				{
					if (mouseLayouts[i].id == id)
					{
						return mouseLayouts[i].name;
					}
				}
			}
			return "Unknown";
		}

		public void AddCustomControllerLayout()
		{
			customControllerLayouts.Add(FEoHVHNLtbBjQHpnWSDFfOnvScls());
		}

		public void InsertCustomControllerLayout(int index)
		{
			if (index < 0 || index >= customControllerLayouts.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			customControllerLayouts.Insert(index, FEoHVHNLtbBjQHpnWSDFfOnvScls());
		}

		public void DeleteCustomControllerLayout(int index)
		{
			if (customControllerLayouts == null || index < 0 || index >= customControllerLayouts.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int id = customControllerLayouts[index].id;
			if (customControllerMaps != null)
			{
				for (int num = customControllerMaps.Count - 1; num >= 0; num--)
				{
					if (customControllerMaps[num].layoutId == id)
					{
						customControllerMaps.RemoveAt(num);
					}
				}
			}
			if (players != null)
			{
				Action<List<Player_Editor.Mapping>, int> action = delegate(List<Player_Editor.Mapping> P_0, int P_1)
				{
					if (P_0 != null)
					{
						for (int num2 = P_0.Count - 1; num2 >= 0; num2--)
						{
							if (P_0[num2] == null || P_0[num2].layoutId == P_1)
							{
								P_0.RemoveAt(num2);
							}
						}
					}
				};
				for (int i = 0; i < players.Count; i++)
				{
					Player_Editor player_Editor = players[i];
					if (player_Editor != null)
					{
						action(player_Editor.defaultCustomControllerMaps, id);
					}
				}
			}
			customControllerLayouts.RemoveAt(index);
		}

		public bool ReorderCustomControllerLayout(int index, bool offsetDown, bool offsetNow)
		{
			return ListTools.OffsetAtIndex(customControllerLayouts, index, offsetDown, offsetNow);
		}

		public void DuplicateCustomControllerLayout(int index, bool duplicateMaps)
		{
			if (customControllerLayouts == null || index < 0 || index >= customControllerLayouts.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			InputLayout inputLayout = customControllerLayouts[index].Clone();
			inputLayout.id = GetNewCustomControllerLayoutId();
			inputLayout.name = StringTools.IterateName(inputLayout.name, -1, GetCustomControllerLayoutNames());
			if (index == customControllerLayouts.Count - 1)
			{
				customControllerLayouts.Add(inputLayout);
			}
			else
			{
				customControllerLayouts.Insert(index + 1, inputLayout);
			}
			if (!duplicateMaps)
			{
				return;
			}
			int id = inputLayout.id;
			int id2 = customControllerLayouts[index].id;
			if (customControllerMaps == null)
			{
				return;
			}
			for (int num = customControllerMaps.Count - 1; num >= 0; num--)
			{
				if (customControllerMaps[num].layoutId == id2)
				{
					int num2 = DuplicateCustomControllerMap(num);
					if (num2 >= 0)
					{
						customControllerMaps[num2].layoutId = id;
					}
				}
			}
		}

		public int GetCustomControllerLayoutMapCount(int id)
		{
			if (customControllerLayouts == null)
			{
				return 0;
			}
			int num = 0;
			if (customControllerMaps != null)
			{
				for (int i = 0; i < customControllerMaps.Count; i++)
				{
					if (customControllerMaps[i].layoutId == id)
					{
						num++;
					}
				}
			}
			return num;
		}

		public int GetCustomControllerLayoutIndex(int id)
		{
			if (customControllerLayouts == null)
			{
				return 0;
			}
			for (int i = 0; i < customControllerLayouts.Count; i++)
			{
				if (customControllerLayouts[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public string[] GetCustomControllerLayoutNames()
		{
			if (customControllerLayouts == null)
			{
				return null;
			}
			string[] array = new string[customControllerLayouts.Count];
			for (int i = 0; i < customControllerLayouts.Count; i++)
			{
				array[i] = customControllerLayouts[i].name;
			}
			return array;
		}

		public int[] GetCustomControllerLayoutIds()
		{
			if (customControllerLayouts == null)
			{
				return null;
			}
			int[] array = new int[customControllerLayouts.Count];
			for (int i = 0; i < customControllerLayouts.Count; i++)
			{
				array[i] = customControllerLayouts[i].id;
			}
			return array;
		}

		public InputLayout GetCustomControllerLayout(int index)
		{
			if (customControllerLayouts == null || index < 0 || index >= customControllerLayouts.Count)
			{
				return null;
			}
			return customControllerLayouts[index];
		}

		public InputLayout GetCustomControllerLayout(string name)
		{
			if (customControllerLayouts == null)
			{
				return null;
			}
			int num = IndexOfCustomControllerLayout(name);
			if (num < 0)
			{
				return null;
			}
			return customControllerLayouts[num];
		}

		public InputLayout GetCustomControllerLayoutById(int id)
		{
			if (customControllerLayouts == null)
			{
				return null;
			}
			int num = IndexOfCustomControllerLayout(id);
			if (num < 0)
			{
				return null;
			}
			return customControllerLayouts[num];
		}

		public int GetCustomControllerLayoutId(string name)
		{
			if (customControllerLayouts == null)
			{
				return -1;
			}
			int num = IndexOfCustomControllerLayout(name);
			if (num < 0)
			{
				return -1;
			}
			return customControllerLayouts[num].id;
		}

		public int IndexOfCustomControllerLayout(int id)
		{
			if (customControllerLayouts == null)
			{
				return -1;
			}
			for (int i = 0; i < customControllerLayouts.Count; i++)
			{
				if (customControllerLayouts[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public int IndexOfCustomControllerLayout(string name)
		{
			if (name == null || name == string.Empty)
			{
				return -1;
			}
			if (customControllerLayouts == null)
			{
				return -1;
			}
			for (int i = 0; i < customControllerLayouts.Count; i++)
			{
				if (customControllerLayouts[i].name.Equals(name, StringComparison.OrdinalIgnoreCase))
				{
					return i;
				}
			}
			return -1;
		}

		public string GetCustomControllerLayoutNameById(int id)
		{
			if (customControllerLayouts != null)
			{
				for (int i = 0; i < customControllerLayouts.Count; i++)
				{
					if (customControllerLayouts[i].id == id)
					{
						return customControllerLayouts[i].name;
					}
				}
			}
			return "Unknown";
		}

		public string GetLayoutNameById(ControllerType controllerType, int id)
		{
			return controllerType switch
			{
				ControllerType.Joystick => GetJoystickLayoutNameById(id), 
				ControllerType.Keyboard => GetKeyboardLayoutNameById(id), 
				ControllerType.Mouse => GetMouseLayoutNameById(id), 
				ControllerType.Custom => GetCustomControllerLayoutNameById(id), 
				_ => throw new NotImplementedException(), 
			};
		}

		internal ControllerMap eMNDXjeZJyzUonVPAgoxHeuDFqlc(Controller P_0, int P_1, int P_2)
		{
			if (P_0 == null)
			{
				return null;
			}
			return P_0.type switch
			{
				ControllerType.Joystick => DaCIomEMClXMJhjaggiJvZhjxKp((Joystick)P_0, P_1, P_2), 
				ControllerType.Keyboard => FindKeyboardMap_Game((Keyboard)P_0, P_1, P_2), 
				ControllerType.Mouse => FindMouseMap_Game((Mouse)P_0, P_1, P_2), 
				ControllerType.Custom => ktNOMocJCadznhndNYZtJNgVSGi(P_1, ((CustomController)P_0).sourceControllerId, P_2), 
				_ => throw new NotImplementedException(), 
			};
		}

		public ControllerMap_Editor GetJoystickMap(int categoryId, Guid hardwareGuid, int layoutId)
		{
			if (joystickMaps == null)
			{
				return null;
			}
			for (int i = 0; i < joystickMaps.Count; i++)
			{
				if (joystickMaps[i].categoryId == categoryId && joystickMaps[i].layoutId == layoutId && StringTools.ToGuid(joystickMaps[i].hardwareGuidString) == hardwareGuid)
				{
					return joystickMaps[i];
				}
			}
			return null;
		}

		public ControllerMap_Editor GetJoystickMapById(int id, out int joystickMapIndex)
		{
			joystickMapIndex = -1;
			if (joystickMaps == null)
			{
				return null;
			}
			for (int i = 0; i < joystickMaps.Count; i++)
			{
				if (joystickMaps[i].id == id)
				{
					joystickMapIndex = i;
					return joystickMaps[i];
				}
			}
			return null;
		}

		public List<ControllerMap_Editor> GetJoystickMaps(Guid hardwareGuid)
		{
			if (joystickMaps == null)
			{
				return null;
			}
			List<ControllerMap_Editor> list = new List<ControllerMap_Editor>();
			for (int i = 0; i < joystickMaps.Count; i++)
			{
				if (StringTools.ToGuid(joystickMaps[i].hardwareGuidString) == hardwareGuid)
				{
					list.Add(joystickMaps[i]);
				}
			}
			return list;
		}

		public int GetJoystickMapId(int categoryId, Guid hardwareGuid, int layoutId)
		{
			if (joystickMaps == null)
			{
				return -1;
			}
			for (int i = 0; i < joystickMaps.Count; i++)
			{
				if (joystickMaps[i].categoryId == categoryId && joystickMaps[i].layoutId == layoutId && StringTools.ToGuid(joystickMaps[i].hardwareGuidString) == hardwareGuid)
				{
					return joystickMaps[i].id;
				}
			}
			return -1;
		}

		public bool HasJoystickMap(int categoryId, Guid hardwareGuid, int layoutId)
		{
			if (joystickMaps == null)
			{
				return false;
			}
			for (int i = 0; i < joystickMaps.Count; i++)
			{
				if (joystickMaps[i].categoryId == categoryId && joystickMaps[i].layoutId == layoutId && StringTools.ToGuid(joystickMaps[i].hardwareGuidString) == hardwareGuid)
				{
					return true;
				}
			}
			return false;
		}

		public bool HasJoystickMap(Guid hardwareGuid)
		{
			if (joystickMaps == null)
			{
				return false;
			}
			for (int i = 0; i < joystickMaps.Count; i++)
			{
				if (StringTools.ToGuid(joystickMaps[i].hardwareGuidString) == hardwareGuid)
				{
					return true;
				}
			}
			return false;
		}

		public bool HasJoystickMapInCategory(Guid hardwareGuid, int categoryId)
		{
			if (joystickMaps == null)
			{
				return false;
			}
			for (int i = 0; i < joystickMaps.Count; i++)
			{
				if (StringTools.ToGuid(joystickMaps[i].hardwareGuidString) == hardwareGuid && joystickMaps[i].categoryId == categoryId)
				{
					return true;
				}
			}
			return false;
		}

		public bool CreateJoystickMap(int categoryId, Guid joystickOrTemplateGuid, int layoutId)
		{
			if (joystickMaps == null)
			{
				joystickMaps = new List<ControllerMap_Editor>();
			}
			ControllerMap_Editor controllerMap_Editor = new ControllerMap_Editor();
			controllerMap_Editor.id = GetNewJoystickMapId();
			controllerMap_Editor.categoryId = categoryId;
			controllerMap_Editor.layoutId = layoutId;
			controllerMap_Editor.hardwareGuidString = joystickOrTemplateGuid.ToString();
			joystickMaps.Add(controllerMap_Editor);
			return false;
		}

		public void DeleteJoystickMap(int id)
		{
			if (joystickMaps == null)
			{
				return;
			}
			for (int num = joystickMaps.Count - 1; num >= 0; num--)
			{
				if (joystickMaps[num].id == id)
				{
					joystickMaps.RemoveAt(num);
				}
			}
		}

		public int DuplicateJoystickMap(int index)
		{
			if (joystickMaps == null || index < 0 || index >= joystickMaps.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			ControllerMap_Editor controllerMap_Editor = joystickMaps[index].Clone();
			controllerMap_Editor.id = GetNewJoystickMapId();
			joystickMaps.Add(controllerMap_Editor);
			return joystickMaps.Count - 1;
		}

		internal JoystickMap wHsihrNeanPbUMDqVsLFUifEqLU(HardwareControllerMapIdentifier P_0, int P_1, int P_2)
		{
			return DaCIomEMClXMJhjaggiJvZhjxKp(new HardwareControllerMapIdentifier(P_0.guid, P_0.inputSource, P_0.actualInputPlatform, P_0.variantIndex), P_1, P_2);
		}

		internal JoystickMap DaCIomEMClXMJhjaggiJvZhjxKp(Joystick P_0, int P_1, int P_2)
		{
			if (P_0 == null)
			{
				return null;
			}
			return DaCIomEMClXMJhjaggiJvZhjxKp(P_0.hardwareJoystickMapIdentifier, P_1, P_2);
		}

		private JoystickMap DaCIomEMClXMJhjaggiJvZhjxKp(HardwareControllerMapIdentifier P_0, int P_1, int P_2)
		{
			Guid guid = P_0.guid;
			HardwareJoystickMap hardwareJoystickMap = ReInput.aBicjEfMjycUGLQZRmiDUTZajuJp(guid);
			ControllerMap_Editor controllerMap_Editor = LyVJjqmPUCLhEeyerXTfmlsRLyk(P_1, guid, P_2, false);
			if (controllerMap_Editor != null)
			{
				JoystickMap joystickMap = controllerMap_Editor.tXyeReAYQCytCHABallyfMLEthz(containsActionDelegate, P_0, hardwareJoystickMap, controllerMap_Editor.hardwareGuid == ReInput.defaultHardwareJoystickMapGuid);
				joystickMap.VHccjfEMNntOyUjHbKfsjtKQWZf(guid, P_1, P_2);
				return joystickMap;
			}
			if (hardwareJoystickMap != null)
			{
				foreach (Guid templateGuid in hardwareJoystickMap.TemplateGuids)
				{
					if (templateGuid == Guid.Empty)
					{
						continue;
					}
					HardwareJoystickTemplateMap hardwareJoystickTemplateMap = ReInput.wxaUFJksCtJSWyNVQsKBejbBmBq(templateGuid);
					if (!(hardwareJoystickTemplateMap != null))
					{
						continue;
					}
					controllerMap_Editor = LyVJjqmPUCLhEeyerXTfmlsRLyk(P_1, templateGuid, P_2, false);
					if (controllerMap_Editor != null)
					{
						JoystickMap joystickMap = POuAnmhZYSCIIPevNEqvXNAgkPV(P_0, controllerMap_Editor, hardwareJoystickTemplateMap, hardwareJoystickMap, P_1, P_2);
						if (joystickMap != null)
						{
							joystickMap.VHccjfEMNntOyUjHbKfsjtKQWZf(guid, P_1, P_2);
							return joystickMap;
						}
					}
				}
			}
			if (guid == Guid.Empty && 0 == 0)
			{
				controllerMap_Editor = LyVJjqmPUCLhEeyerXTfmlsRLyk(P_1, Guid.Empty, P_2, false);
				if (controllerMap_Editor != null)
				{
					JoystickMap joystickMap = controllerMap_Editor.tXyeReAYQCytCHABallyfMLEthz(containsActionDelegate, P_0, null, controllerMap_Editor.hardwareGuid == ReInput.defaultHardwareJoystickMapGuid);
					joystickMap.VHccjfEMNntOyUjHbKfsjtKQWZf(guid, P_1, P_2);
					if (joystickMap != null)
					{
						return joystickMap;
					}
				}
			}
			return JoystickMap.EOKwQcxsIwIbTLRXRRCTTzrEDPK(guid, P_1, P_2);
		}

		private ControllerMap_Editor LyVJjqmPUCLhEeyerXTfmlsRLyk(int P_0, Guid P_1, int P_2, bool P_3)
		{
			ControllerMap_Editor joystickMap = GetJoystickMap(P_0, P_1, P_2);
			if (joystickMap != null)
			{
				return joystickMap;
			}
			if (P_3)
			{
				joystickMap = OxEaAvhWnzuoeeEKSVDRHrXxspkl(P_0, P_1, P_2);
				if (joystickMap != null)
				{
					return joystickMap;
				}
			}
			return null;
		}

		private ControllerMap_Editor OxEaAvhWnzuoeeEKSVDRHrXxspkl(int P_0, Guid P_1, int P_2)
		{
			List<ControllerMap_Editor> list = GetJoystickMaps(P_1);
			if (list != null && list.Count > 0)
			{
				AIoFmtCTlzXHaNtbYhHVCoRNBtaP(list, joystickLayouts);
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].categoryId == P_0)
					{
						return list[i];
					}
				}
				for (int j = 0; j < list.Count; j++)
				{
					if (list[j].categoryId == 0)
					{
						return list[j];
					}
				}
			}
			return null;
		}

		private JoystickMap POuAnmhZYSCIIPevNEqvXNAgkPV(HardwareControllerMapIdentifier P_0, ControllerMap_Editor P_1, HardwareJoystickTemplateMap P_2, HardwareJoystickMap P_3, int P_4, int P_5)
		{
			if (P_2 == null)
			{
				return null;
			}
			ControllerMap_Editor controllerMap_Editor = P_1.Clone();
			if (!P_2.SfyAhBSYWWhcSTiEKWWxnXYvQGK(controllerMap_Editor, P_3, P_0.guid, out var text))
			{
				Logger.LogError(string.Concat("Error remapping joystick template ", P_2.Guid, " to joystick ", P_0.guid, "\nReason: ", text));
				return null;
			}
			return controllerMap_Editor.tXyeReAYQCytCHABallyfMLEthz(containsActionDelegate, P_0, P_3, controllerMap_Editor.hardwareGuid == ReInput.defaultHardwareJoystickMapGuid);
		}

		private JoystickMap gWZZgaEbNQqzsrawSMOagXhgwIj(JoystickMap P_0, HardwareControllerMapIdentifier P_1)
		{
			if (P_0 == null)
			{
				return null;
			}
			HardwareJoystickMap hardwareJoystickMap = ReInput.aBicjEfMjycUGLQZRmiDUTZajuJp(P_0.hardwareGuid);
			if (hardwareJoystickMap == null)
			{
				return null;
			}
			HardwareJoystickMap hardwareJoystickMap2 = ReInput.aBicjEfMjycUGLQZRmiDUTZajuJp(Guid.Empty);
			if (hardwareJoystickMap2 == null)
			{
				return null;
			}
			hardwareJoystickMap.GetElementIdentifiersForControllerElements(P_1, isDefaultMap: false, out var buttons, out var axes);
			if (buttons == null && axes == null)
			{
				return null;
			}
			bool flag = false;
			List<int> list = new List<int>();
			foreach (ActionElementMap allMap in P_0.AllMaps)
			{
				ControllerElementIdentifier elementIdentifier = hardwareJoystickMap2.GetElementIdentifier(allMap._elementIdentifierId);
				if (elementIdentifier != null)
				{
					string name = elementIdentifier.name;
					if (!string.IsNullOrEmpty(name))
					{
						int num = 0;
						int num2 = name.IndexOf("button", 0, StringComparison.OrdinalIgnoreCase);
						if (num2 < 0)
						{
							num2 = name.IndexOf("axis", 0, StringComparison.OrdinalIgnoreCase);
							num = 1;
						}
						if (num2 >= 0 && (num != 0 || buttons != null) && (num != 1 || axes != null))
						{
							string text = Regex.Replace(name, "[^0-9]+", "");
							Logger.Log(text);
							if (int.TryParse(text, out var result))
							{
								if (num == 0)
								{
									if (result < buttons.Length)
									{
										allMap._elementIdentifierId = buttons[result];
										goto IL_0124;
									}
								}
								else if (result < axes.Length)
								{
									allMap._elementIdentifierId = axes[result];
									goto IL_0124;
								}
							}
						}
					}
				}
				list.Add(allMap.BoMCLeauexjolkkRqzIpOQOAGri);
				continue;
				IL_0124:
				flag = true;
			}
			for (int i = 0; i < list.Count; i++)
			{
				P_0.DeleteElementMap(list[i]);
			}
			if (!flag)
			{
				return null;
			}
			return P_0;
		}

		public ControllerMap_Editor GetKeyboardMap(int categoryId, int layoutId)
		{
			if (keyboardMaps == null)
			{
				return null;
			}
			for (int i = 0; i < keyboardMaps.Count; i++)
			{
				if (keyboardMaps[i].categoryId == categoryId && keyboardMaps[i].layoutId == layoutId)
				{
					return keyboardMaps[i];
				}
			}
			return null;
		}

		public int GetKeyboardMapId(int categoryId, int layoutId)
		{
			if (keyboardMaps == null)
			{
				return -1;
			}
			for (int i = 0; i < keyboardMaps.Count; i++)
			{
				if (keyboardMaps[i].categoryId == categoryId && keyboardMaps[i].layoutId == layoutId)
				{
					return keyboardMaps[i].id;
				}
			}
			return -1;
		}

		public bool HasKeyboardMap(int categoryId, Guid hardwareGuid, int layoutId)
		{
			if (keyboardMaps == null)
			{
				return false;
			}
			for (int i = 0; i < keyboardMaps.Count; i++)
			{
				if (keyboardMaps[i].categoryId == categoryId && keyboardMaps[i].layoutId == layoutId && StringTools.ToGuid(keyboardMaps[i].hardwareGuidString) == hardwareGuid)
				{
					return true;
				}
			}
			return false;
		}

		public bool CreateKeyboardMap(int categoryId, int layoutId)
		{
			if (keyboardMaps == null)
			{
				keyboardMaps = new List<ControllerMap_Editor>();
			}
			ControllerMap_Editor controllerMap_Editor = new ControllerMap_Editor();
			controllerMap_Editor.id = GetNewKeyboardMapId();
			controllerMap_Editor.categoryId = categoryId;
			controllerMap_Editor.layoutId = layoutId;
			keyboardMaps.Add(controllerMap_Editor);
			return false;
		}

		public void DeleteKeyboardMap(int id)
		{
			if (keyboardMaps == null)
			{
				return;
			}
			for (int num = keyboardMaps.Count - 1; num >= 0; num--)
			{
				if (keyboardMaps[num].id == id)
				{
					keyboardMaps.RemoveAt(num);
				}
			}
		}

		public int DuplicateKeyboardMap(int index)
		{
			if (keyboardMaps == null || index < 0 || index >= keyboardMaps.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			ControllerMap_Editor controllerMap_Editor = keyboardMaps[index].Clone();
			controllerMap_Editor.id = GetNewKeyboardMapId();
			keyboardMaps.Add(controllerMap_Editor);
			return keyboardMaps.Count - 1;
		}

		public ControllerMap_Editor GetKeyboardMapById(int id, out int keyboardMapIndex)
		{
			keyboardMapIndex = -1;
			if (keyboardMaps == null)
			{
				return null;
			}
			for (int i = 0; i < keyboardMaps.Count; i++)
			{
				if (keyboardMaps[i].id == id)
				{
					keyboardMapIndex = i;
					return keyboardMaps[i];
				}
			}
			return null;
		}

		public KeyboardMap FindKeyboardMap_Game(Keyboard keyboard, int categoryId, int layoutId)
		{
			ControllerMap_Editor controllerMap_Editor = caTtGDToxDJIAwPpeSjfgpusLYd(keyboardMaps, keyboardLayouts, categoryId, layoutId, false);
			KeyboardMap keyboardMap;
			if (controllerMap_Editor != null)
			{
				keyboardMap = controllerMap_Editor.qxIxfrIfXCdWrMeQFwEWVyXIlZc(containsActionDelegate);
				keyboardMap.VHccjfEMNntOyUjHbKfsjtKQWZf(keyboard.cBbvDblDdxYvWIffImKZKlfGJPE, categoryId, layoutId);
			}
			else
			{
				keyboardMap = KeyboardMap.EOKwQcxsIwIbTLRXRRCTTzrEDPK(keyboard.cBbvDblDdxYvWIffImKZKlfGJPE, categoryId, layoutId);
			}
			return keyboardMap;
		}

		public bool HasKeyboardMapInCategory(int categoryId)
		{
			if (keyboardMaps == null)
			{
				return false;
			}
			for (int i = 0; i < keyboardMaps.Count; i++)
			{
				if (keyboardMaps[i].categoryId == categoryId)
				{
					return true;
				}
			}
			return false;
		}

		public bool HasKeyboardMapInLayout(int categoryId, int layoutId)
		{
			if (keyboardMaps == null)
			{
				return false;
			}
			for (int i = 0; i < keyboardMaps.Count; i++)
			{
				if (keyboardMaps[i].categoryId == categoryId && keyboardMaps[i].layoutId == layoutId)
				{
					return true;
				}
			}
			return false;
		}

		public ControllerMap_Editor GetMouseMap(int categoryId, int layoutId)
		{
			if (mouseMaps == null)
			{
				return null;
			}
			for (int i = 0; i < mouseMaps.Count; i++)
			{
				if (mouseMaps[i].categoryId == categoryId && mouseMaps[i].layoutId == layoutId)
				{
					return mouseMaps[i];
				}
			}
			return null;
		}

		public int GetMouseMapId(int categoryId, int layoutId)
		{
			if (mouseMaps == null)
			{
				return -1;
			}
			for (int i = 0; i < mouseMaps.Count; i++)
			{
				if (mouseMaps[i].categoryId == categoryId && mouseMaps[i].layoutId == layoutId)
				{
					return mouseMaps[i].id;
				}
			}
			return -1;
		}

		public bool HasMouseMap(int categoryId, Guid hardwareGuid, int layoutId)
		{
			if (mouseMaps == null)
			{
				return false;
			}
			for (int i = 0; i < mouseMaps.Count; i++)
			{
				if (mouseMaps[i].categoryId == categoryId && mouseMaps[i].layoutId == layoutId && StringTools.ToGuid(mouseMaps[i].hardwareGuidString) == hardwareGuid)
				{
					return true;
				}
			}
			return false;
		}

		public bool CreateMouseMap(int categoryId, int layoutId)
		{
			if (mouseMaps == null)
			{
				mouseMaps = new List<ControllerMap_Editor>();
			}
			ControllerMap_Editor controllerMap_Editor = new ControllerMap_Editor();
			controllerMap_Editor.id = GetNewMouseMapId();
			controllerMap_Editor.categoryId = categoryId;
			controllerMap_Editor.layoutId = layoutId;
			mouseMaps.Add(controllerMap_Editor);
			return false;
		}

		public void DeleteMouseMap(int id)
		{
			if (mouseMaps == null)
			{
				return;
			}
			for (int num = mouseMaps.Count - 1; num >= 0; num--)
			{
				if (mouseMaps[num].id == id)
				{
					mouseMaps.RemoveAt(num);
				}
			}
		}

		public int DuplicateMouseMap(int index)
		{
			if (mouseMaps == null || index < 0 || index >= mouseMaps.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			ControllerMap_Editor controllerMap_Editor = mouseMaps[index].Clone();
			controllerMap_Editor.id = GetNewMouseMapId();
			mouseMaps.Add(controllerMap_Editor);
			return mouseMaps.Count - 1;
		}

		public ControllerMap_Editor GetMouseMapById(int id, out int mouseMapIndex)
		{
			mouseMapIndex = -1;
			if (mouseMaps == null)
			{
				return null;
			}
			for (int i = 0; i < mouseMaps.Count; i++)
			{
				if (mouseMaps[i].id == id)
				{
					mouseMapIndex = i;
					return mouseMaps[i];
				}
			}
			return null;
		}

		public MouseMap FindMouseMap_Game(Mouse mouse, int categoryId, int layoutId)
		{
			ControllerMap_Editor controllerMap_Editor = caTtGDToxDJIAwPpeSjfgpusLYd(mouseMaps, mouseLayouts, categoryId, layoutId, false);
			MouseMap mouseMap;
			if (controllerMap_Editor != null)
			{
				mouseMap = controllerMap_Editor.lwWJkrZeZWFgmwrRFwpDWhFRRNe(containsActionDelegate);
				mouseMap.VHccjfEMNntOyUjHbKfsjtKQWZf(mouse.cBbvDblDdxYvWIffImKZKlfGJPE, categoryId, layoutId);
			}
			else
			{
				mouseMap = MouseMap.EOKwQcxsIwIbTLRXRRCTTzrEDPK(mouse.cBbvDblDdxYvWIffImKZKlfGJPE, categoryId, layoutId);
			}
			return mouseMap;
		}

		public bool HasMouseMapInCategory(int categoryId)
		{
			if (mouseMaps == null)
			{
				return false;
			}
			for (int i = 0; i < mouseMaps.Count; i++)
			{
				if (mouseMaps[i].categoryId == categoryId)
				{
					return true;
				}
			}
			return false;
		}

		public bool HasMouseMapInLayout(int categoryId, int layoutId)
		{
			if (mouseMaps == null)
			{
				return false;
			}
			for (int i = 0; i < mouseMaps.Count; i++)
			{
				if (mouseMaps[i].categoryId == categoryId && mouseMaps[i].layoutId == layoutId)
				{
					return true;
				}
			}
			return false;
		}

		public ControllerMap_Editor GetCustomControllerMap(int categoryId, int controllerUid, int layoutId)
		{
			if (customControllerMaps == null)
			{
				return null;
			}
			for (int i = 0; i < customControllerMaps.Count; i++)
			{
				if (customControllerMaps[i].categoryId == categoryId && customControllerMaps[i].layoutId == layoutId && customControllerMaps[i].customControllerUid == controllerUid)
				{
					return customControllerMaps[i];
				}
			}
			return null;
		}

		public ControllerMap_Editor GetCustomControllerMapById(int mapId, out int customControllerMapIndex)
		{
			customControllerMapIndex = -1;
			if (customControllerMaps == null)
			{
				return null;
			}
			for (int i = 0; i < customControllerMaps.Count; i++)
			{
				if (customControllerMaps[i].id == mapId)
				{
					customControllerMapIndex = i;
					return customControllerMaps[i];
				}
			}
			return null;
		}

		public List<ControllerMap_Editor> GetCustomControllerMaps(int controllerUid)
		{
			if (customControllerMaps == null)
			{
				return null;
			}
			List<ControllerMap_Editor> list = new List<ControllerMap_Editor>();
			for (int i = 0; i < customControllerMaps.Count; i++)
			{
				if (customControllerMaps[i].customControllerUid == controllerUid)
				{
					list.Add(customControllerMaps[i]);
				}
			}
			return list;
		}

		public int GetCustomControllerMapId(int categoryId, int controllerUid, int layoutId)
		{
			if (customControllerMaps == null)
			{
				return -1;
			}
			for (int i = 0; i < customControllerMaps.Count; i++)
			{
				if (customControllerMaps[i].categoryId == categoryId && customControllerMaps[i].layoutId == layoutId && customControllerMaps[i].customControllerUid == controllerUid)
				{
					return customControllerMaps[i].id;
				}
			}
			return -1;
		}

		public bool HasCustomControllerMap(int mapId, int categoryId, int layoutId)
		{
			if (customControllerMaps == null)
			{
				return false;
			}
			for (int i = 0; i < customControllerMaps.Count; i++)
			{
				if (customControllerMaps[i].categoryId == categoryId && customControllerMaps[i].layoutId == layoutId && customControllerMaps[i].id == mapId)
				{
					return true;
				}
			}
			return false;
		}

		public bool HasCustomControllerMap(int mapId)
		{
			if (customControllerMaps == null)
			{
				return false;
			}
			for (int i = 0; i < customControllerMaps.Count; i++)
			{
				if (customControllerMaps[i].id == mapId)
				{
					return true;
				}
			}
			return false;
		}

		public bool HasCustomControllerMapInCategory(int controllerUid, int categoryId)
		{
			if (customControllerMaps == null)
			{
				return false;
			}
			for (int i = 0; i < customControllerMaps.Count; i++)
			{
				if (customControllerMaps[i].customControllerUid == controllerUid && customControllerMaps[i].categoryId == categoryId)
				{
					return true;
				}
			}
			return false;
		}

		public bool CreateCustomControllerMap(int categoryId, int controllerUid, int layoutId)
		{
			if (customControllerMaps == null)
			{
				customControllerMaps = new List<ControllerMap_Editor>();
			}
			ControllerMap_Editor controllerMap_Editor = new ControllerMap_Editor();
			controllerMap_Editor.id = GetNewCustomControllerMapId();
			controllerMap_Editor.categoryId = categoryId;
			controllerMap_Editor.layoutId = layoutId;
			controllerMap_Editor.hardwareGuidString = string.Empty;
			controllerMap_Editor.customControllerUid = controllerUid;
			customControllerMaps.Add(controllerMap_Editor);
			return false;
		}

		public void DeleteCustomControllerMap(int mapId)
		{
			if (customControllerMaps == null)
			{
				return;
			}
			for (int num = customControllerMaps.Count - 1; num >= 0; num--)
			{
				if (customControllerMaps[num].id == mapId)
				{
					customControllerMaps.RemoveAt(num);
				}
			}
		}

		public int DuplicateCustomControllerMap(int index)
		{
			if (customControllerMaps == null || index < 0 || index >= customControllerMaps.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			ControllerMap_Editor controllerMap_Editor = customControllerMaps[index].Clone();
			controllerMap_Editor.id = GetNewCustomControllerMapId();
			customControllerMaps.Add(controllerMap_Editor);
			return customControllerMaps.Count - 1;
		}

		internal CustomControllerMap ktNOMocJCadznhndNYZtJNgVSGi(Guid P_0, int P_1, int P_2)
		{
			return ktNOMocJCadznhndNYZtJNgVSGi(GetCustomControllerByHardwareTypeGuid(P_0), P_1, P_2);
		}

		internal CustomControllerMap ktNOMocJCadznhndNYZtJNgVSGi(int P_0, int P_1, int P_2)
		{
			return ktNOMocJCadznhndNYZtJNgVSGi(GetCustomControllerById(P_1), P_0, P_2);
		}

		private CustomControllerMap ktNOMocJCadznhndNYZtJNgVSGi(CustomController_Editor P_0, int P_1, int P_2)
		{
			if (P_0 == null)
			{
				return null;
			}
			int id = P_0.id;
			ControllerMap_Editor controllerMap_Editor = OOKmWpMKqgdtekoWuAFYzBcjDel(P_1, id, P_2, false);
			CustomControllerMap customControllerMap;
			if (controllerMap_Editor != null)
			{
				customControllerMap = controllerMap_Editor.TrBaDbIudOGmpOHyUZNnOHRIjyn(ContainsAction, P_0);
				customControllerMap.VHccjfEMNntOyUjHbKfsjtKQWZf(P_0.typeGuid, id, P_1, P_2);
				return customControllerMap;
			}
			customControllerMap = CustomControllerMap.EOKwQcxsIwIbTLRXRRCTTzrEDPK(P_0.typeGuid, id, P_1, P_2);
			customControllerMap.VHccjfEMNntOyUjHbKfsjtKQWZf(P_0.typeGuid, id, P_1, P_2);
			return customControllerMap;
		}

		private ControllerMap_Editor OOKmWpMKqgdtekoWuAFYzBcjDel(int P_0, int P_1, int P_2, bool P_3)
		{
			ControllerMap_Editor customControllerMap = GetCustomControllerMap(P_0, P_1, P_2);
			if (customControllerMap != null)
			{
				return customControllerMap;
			}
			if (P_3)
			{
				customControllerMap = uZderfnvrDMnIkAewTKAzwvYKTq(P_0, P_1, P_2);
				if (customControllerMap != null)
				{
					return customControllerMap;
				}
			}
			return null;
		}

		private ControllerMap_Editor uZderfnvrDMnIkAewTKAzwvYKTq(int P_0, int P_1, int P_2)
		{
			List<ControllerMap_Editor> list = GetCustomControllerMaps(P_1);
			if (list != null && list.Count > 0)
			{
				AIoFmtCTlzXHaNtbYhHVCoRNBtaP(list, customControllerLayouts);
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].categoryId == P_0)
					{
						return list[i];
					}
				}
				for (int j = 0; j < list.Count; j++)
				{
					if (list[j].categoryId == 0)
					{
						return list[j];
					}
				}
			}
			return null;
		}

		public void DeleteControllerMap(ControllerType controllerType, int id)
		{
			switch (controllerType)
			{
			case ControllerType.Joystick:
				DeleteJoystickMap(id);
				break;
			case ControllerType.Keyboard:
				DeleteKeyboardMap(id);
				break;
			case ControllerType.Mouse:
				DeleteMouseMap(id);
				break;
			case ControllerType.Custom:
				DeleteCustomControllerMap(id);
				break;
			default:
				throw new NotImplementedException();
			}
		}

		public ControllerMap_Editor GetControllerMapByIndex(ControllerType controllerType, int index)
		{
			switch (controllerType)
			{
			case ControllerType.Joystick:
				if (joystickMaps == null)
				{
					return null;
				}
				return joystickMaps[index];
			case ControllerType.Keyboard:
				if (keyboardMaps == null)
				{
					return null;
				}
				return keyboardMaps[index];
			case ControllerType.Mouse:
				if (mouseMaps == null)
				{
					return null;
				}
				return mouseMaps[index];
			case ControllerType.Custom:
				if (customControllerMaps == null)
				{
					return null;
				}
				return customControllerMaps[index];
			default:
				throw new NotImplementedException();
			}
		}

		public ControllerMap_Editor GetControllerMapById(ControllerType controllerType, int id, out int controllerMapIndex)
		{
			return controllerType switch
			{
				ControllerType.Joystick => GetJoystickMapById(id, out controllerMapIndex), 
				ControllerType.Keyboard => GetKeyboardMapById(id, out controllerMapIndex), 
				ControllerType.Mouse => GetMouseMapById(id, out controllerMapIndex), 
				ControllerType.Custom => GetCustomControllerMapById(id, out controllerMapIndex), 
				_ => throw new NotImplementedException(), 
			};
		}

		public int DuplicateControllerMap(ControllerType controllerType, int index)
		{
			return controllerType switch
			{
				ControllerType.Joystick => DuplicateJoystickMap(index), 
				ControllerType.Keyboard => DuplicateKeyboardMap(index), 
				ControllerType.Mouse => DuplicateMouseMap(index), 
				ControllerType.Custom => DuplicateCustomControllerMap(index), 
				_ => throw new NotImplementedException(), 
			};
		}

		internal ControllerTemplateMap AIldkDBWMJDzNtyPfNmdAwQlGeLp(Guid P_0, int P_1, int P_2)
		{
			return GetJoystickMap(P_1, P_0, P_2)?.yncxKarZAGIOIbwBDrINLjJZBoX();
		}

		public void AddCustomController()
		{
			if (customControllers == null)
			{
				customControllers = new List<CustomController_Editor>();
			}
			customControllers.Add(RNfPVYXapTTONepYDHTrZmcvqoo());
		}

		public void InsertCustomController(int index)
		{
			if (customControllers == null)
			{
				customControllers = new List<CustomController_Editor>();
			}
			if (index < 0 || index >= customControllers.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			customControllers.Insert(index, RNfPVYXapTTONepYDHTrZmcvqoo());
		}

		public void DeleteCustomController(int index)
		{
			if (customControllers == null || index < 0 || index >= customControllers.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int id = customControllers[index].id;
			if (customControllerMaps != null)
			{
				for (int num = customControllerMaps.Count - 1; num >= 0; num--)
				{
					if (customControllerMaps[num].customControllerUid == id)
					{
						customControllerMaps.RemoveAt(num);
					}
				}
			}
			customControllers.RemoveAt(index);
		}

		public bool ReorderCustomController(int index, bool offsetDown, bool offsetNow)
		{
			return ListTools.OffsetAtIndex(customControllers, index, offsetDown, offsetNow);
		}

		public void DuplicateCustomController(int index, bool duplicateMaps)
		{
			if (customControllers == null || index < 0 || index >= customControllers.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			CustomController_Editor customController_Editor = customControllers[index].Clone();
			customController_Editor.id = GetNewCustomControllerId();
			customController_Editor.typeGuid = Guid.NewGuid();
			customController_Editor.name = StringTools.IterateName(customController_Editor.name, -1, GetCustomControllerNames());
			if (index == customControllers.Count - 1)
			{
				customControllers.Add(customController_Editor);
			}
			else
			{
				customControllers.Insert(index + 1, customController_Editor);
			}
			if (!duplicateMaps)
			{
				return;
			}
			int id = customController_Editor.id;
			int id2 = customControllers[index].id;
			if (customControllerMaps == null)
			{
				return;
			}
			for (int num = customControllerMaps.Count - 1; num >= 0; num--)
			{
				if (customControllerMaps[num].customControllerUid == id2)
				{
					int num2 = DuplicateCustomControllerMap(num);
					if (num2 >= 0)
					{
						customControllerMaps[num2].customControllerUid = id;
					}
				}
			}
		}

		public int GetCustomControllerMapCount(int controllerUid)
		{
			if (customControllers == null)
			{
				return 0;
			}
			int num = 0;
			if (customControllerMaps != null)
			{
				for (int i = 0; i < customControllerMaps.Count; i++)
				{
					if (customControllerMaps[i].customControllerUid == controllerUid)
					{
						num++;
					}
				}
			}
			return num;
		}

		public int GetCustomControllerIndex(int id)
		{
			if (customControllers == null)
			{
				return 0;
			}
			for (int i = 0; i < customControllers.Count; i++)
			{
				if (customControllers[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public string[] GetCustomControllerNames()
		{
			if (customControllers == null)
			{
				return null;
			}
			string[] array = new string[customControllers.Count];
			for (int i = 0; i < customControllers.Count; i++)
			{
				array[i] = customControllers[i].name;
			}
			return array;
		}

		public int[] GetCustomControllerIds()
		{
			if (customControllers == null)
			{
				return null;
			}
			int[] array = new int[customControllers.Count];
			for (int i = 0; i < customControllers.Count; i++)
			{
				array[i] = customControllers[i].id;
			}
			return array;
		}

		public Guid[] GetCustomControllerGuids()
		{
			if (customControllers == null)
			{
				return null;
			}
			Guid[] array = new Guid[customControllers.Count];
			for (int i = 0; i < customControllers.Count; i++)
			{
				ref Guid reference = ref array[i];
				reference = customControllers[i].typeGuid;
			}
			return array;
		}

		public CustomController_Editor GetCustomController(int index)
		{
			if (customControllers == null || index < 0 || index >= customControllers.Count)
			{
				return null;
			}
			return customControllers[index];
		}

		public CustomController_Editor GetCustomController(string name)
		{
			if (customControllers == null)
			{
				return null;
			}
			int num = IndexOfCustomController(name);
			if (num < 0)
			{
				return null;
			}
			return customControllers[num];
		}

		public CustomController_Editor GetCustomControllerById(int id)
		{
			if (customControllers == null)
			{
				return null;
			}
			int num = IndexOfCustomController(id);
			if (num < 0)
			{
				return null;
			}
			return customControllers[num];
		}

		public CustomController_Editor GetCustomControllerByHardwareTypeGuid(Guid hardwareTypeGuid)
		{
			if (customControllers == null)
			{
				return null;
			}
			int num = IndexOfCustomController(hardwareTypeGuid);
			if (num < 0)
			{
				return null;
			}
			return customControllers[num];
		}

		public int GetCustomControllerId(string name)
		{
			if (customControllers == null)
			{
				return -1;
			}
			int num = IndexOfCustomController(name);
			if (num < 0)
			{
				return -1;
			}
			return customControllers[num].id;
		}

		public int IndexOfCustomController(int id)
		{
			if (customControllers == null)
			{
				return -1;
			}
			for (int i = 0; i < customControllers.Count; i++)
			{
				if (customControllers[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public int IndexOfCustomController(string name)
		{
			if (name == null || name == string.Empty)
			{
				return -1;
			}
			if (customControllers == null)
			{
				return -1;
			}
			for (int i = 0; i < customControllers.Count; i++)
			{
				if (customControllers[i].name.Equals(name, StringComparison.OrdinalIgnoreCase))
				{
					return i;
				}
			}
			return -1;
		}

		public int IndexOfCustomController(Guid hardwareTypeGuid)
		{
			if (customControllers == null)
			{
				return -1;
			}
			for (int i = 0; i < customControllers.Count; i++)
			{
				if (customControllers[i].typeGuid == hardwareTypeGuid)
				{
					return i;
				}
			}
			return -1;
		}

		public string GetCustomControllerNameById(int id)
		{
			if (customControllers != null)
			{
				for (int i = 0; i < customControllers.Count; i++)
				{
					if (customControllers[i].id == id)
					{
						return customControllers[i].name;
					}
				}
			}
			return "Unknown";
		}

		public void AddControllerMapLayoutManagerRuleSet()
		{
			controllerMapLayoutManagerRuleSets.Add(PEVOtpVhMgJYNlhTkKzlkuIgiPg());
		}

		public void InsertControllerMapLayoutManagerRuleSet(int index)
		{
			if (index < 0 || index >= controllerMapLayoutManagerRuleSets.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			controllerMapLayoutManagerRuleSets.Insert(index, PEVOtpVhMgJYNlhTkKzlkuIgiPg());
		}

		public void DeleteControllerMapLayoutManagerRuleSet(int index)
		{
			if (controllerMapLayoutManagerRuleSets == null || index < 0 || index >= controllerMapLayoutManagerRuleSets.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int id = controllerMapLayoutManagerRuleSets[index].id;
			if (players != null)
			{
				for (int i = 0; i < players.Count; i++)
				{
					Player_Editor player_Editor = players[i];
					if (player_Editor == null)
					{
						continue;
					}
					List<Player_Editor.RuleSetMapping> ruleSets = player_Editor.controllerMapLayoutManagerSettings.ruleSets;
					if (ruleSets == null)
					{
						continue;
					}
					for (int num = ruleSets.Count - 1; num >= 0; num--)
					{
						if (ruleSets[num] != null && ruleSets[num].id == id)
						{
							ruleSets.RemoveAt(num);
						}
					}
				}
			}
			controllerMapLayoutManagerRuleSets.RemoveAt(index);
		}

		public bool ReorderControllerMapLayoutManagerRuleSet(int index, bool offsetDown, bool offsetNow)
		{
			return ListTools.OffsetAtIndex(controllerMapLayoutManagerRuleSets, index, offsetDown, offsetNow);
		}

		public void DuplicateControllerMapLayoutManagerRuleSet(int index)
		{
			if (controllerMapLayoutManagerRuleSets == null || index < 0 || index >= controllerMapLayoutManagerRuleSets.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			ControllerMapLayoutManager_RuleSet_Editor controllerMapLayoutManager_RuleSet_Editor = controllerMapLayoutManagerRuleSets[index].Clone();
			controllerMapLayoutManager_RuleSet_Editor.id = GetNewControllerMapLayoutManagerRuleSetId();
			controllerMapLayoutManager_RuleSet_Editor.name = StringTools.IterateName(controllerMapLayoutManager_RuleSet_Editor.name, -1, GetControllerMapLayoutManagerRuleSetNames());
			if (index == controllerMapLayoutManagerRuleSets.Count - 1)
			{
				controllerMapLayoutManagerRuleSets.Add(controllerMapLayoutManager_RuleSet_Editor);
			}
			else
			{
				controllerMapLayoutManagerRuleSets.Insert(index + 1, controllerMapLayoutManager_RuleSet_Editor);
			}
		}

		public int GetControllerMapLayoutManagerRuleSetUsedCount(int id)
		{
			if (controllerMapLayoutManagerRuleSets == null)
			{
				return 0;
			}
			int num = 0;
			if (players != null)
			{
				for (int i = 0; i < players.Count; i++)
				{
					Player_Editor player_Editor = players[i];
					if (player_Editor == null)
					{
						continue;
					}
					List<Player_Editor.RuleSetMapping> ruleSets = player_Editor.controllerMapLayoutManagerSettings.ruleSets;
					if (ruleSets == null)
					{
						continue;
					}
					for (int num2 = ruleSets.Count - 1; num2 >= 0; num2--)
					{
						if (ruleSets[num2] != null && ruleSets[num2].id == id)
						{
							num++;
						}
					}
				}
			}
			return num;
		}

		public int GetControllerMapLayoutManagerRuleSetIndex(int id)
		{
			if (controllerMapLayoutManagerRuleSets == null)
			{
				return 0;
			}
			for (int i = 0; i < controllerMapLayoutManagerRuleSets.Count; i++)
			{
				if (controllerMapLayoutManagerRuleSets[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public string[] GetControllerMapLayoutManagerRuleSetNames()
		{
			if (controllerMapLayoutManagerRuleSets == null)
			{
				return null;
			}
			string[] array = new string[controllerMapLayoutManagerRuleSets.Count];
			for (int i = 0; i < controllerMapLayoutManagerRuleSets.Count; i++)
			{
				array[i] = controllerMapLayoutManagerRuleSets[i].name;
			}
			return array;
		}

		public int[] GetControllerMapLayoutManagerRuleSetIds()
		{
			if (controllerMapLayoutManagerRuleSets == null)
			{
				return null;
			}
			int[] array = new int[controllerMapLayoutManagerRuleSets.Count];
			for (int i = 0; i < controllerMapLayoutManagerRuleSets.Count; i++)
			{
				array[i] = controllerMapLayoutManagerRuleSets[i].id;
			}
			return array;
		}

		public ControllerMapLayoutManager_RuleSet_Editor GetControllerMapLayoutManagerRuleSet(int index)
		{
			if (controllerMapLayoutManagerRuleSets == null || index < 0 || index >= controllerMapLayoutManagerRuleSets.Count)
			{
				return null;
			}
			return controllerMapLayoutManagerRuleSets[index];
		}

		public ControllerMapLayoutManager_RuleSet_Editor GetControllerMapLayoutManagerRuleSet(string name)
		{
			if (controllerMapLayoutManagerRuleSets == null)
			{
				return null;
			}
			int num = IndexOfControllerMapLayoutManagerRuleSet(name);
			if (num < 0)
			{
				return null;
			}
			return controllerMapLayoutManagerRuleSets[num];
		}

		public ControllerMapLayoutManager_RuleSet_Editor GetControllerMapLayoutManagerRuleSetById(int id)
		{
			if (controllerMapLayoutManagerRuleSets == null)
			{
				return null;
			}
			int num = IndexOfControllerMapLayoutManagerRuleSet(id);
			if (num < 0)
			{
				return null;
			}
			return controllerMapLayoutManagerRuleSets[num];
		}

		public int GetControllerMapLayoutManagerRuleSetId(string name)
		{
			if (controllerMapLayoutManagerRuleSets == null)
			{
				return -1;
			}
			int num = IndexOfControllerMapLayoutManagerRuleSet(name);
			if (num < 0)
			{
				return -1;
			}
			return controllerMapLayoutManagerRuleSets[num].id;
		}

		public int IndexOfControllerMapLayoutManagerRuleSet(int id)
		{
			if (controllerMapLayoutManagerRuleSets == null)
			{
				return -1;
			}
			for (int i = 0; i < controllerMapLayoutManagerRuleSets.Count; i++)
			{
				if (controllerMapLayoutManagerRuleSets[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public int IndexOfControllerMapLayoutManagerRuleSet(string name)
		{
			if (name == null || name == string.Empty)
			{
				return -1;
			}
			if (controllerMapLayoutManagerRuleSets == null)
			{
				return -1;
			}
			for (int i = 0; i < controllerMapLayoutManagerRuleSets.Count; i++)
			{
				if (controllerMapLayoutManagerRuleSets[i].name.Equals(name, StringComparison.OrdinalIgnoreCase))
				{
					return i;
				}
			}
			return -1;
		}

		public string GetControllerMapLayoutManagerRuleSetNameById(int id)
		{
			if (controllerMapLayoutManagerRuleSets != null)
			{
				for (int i = 0; i < controllerMapLayoutManagerRuleSets.Count; i++)
				{
					if (controllerMapLayoutManagerRuleSets[i].id == id)
					{
						return controllerMapLayoutManagerRuleSets[i].name;
					}
				}
			}
			return "Unknown";
		}

		public int GetControllerMapLayoutManagerRuleSetCount()
		{
			if (controllerMapLayoutManagerRuleSets == null)
			{
				return 0;
			}
			return controllerMapLayoutManagerRuleSets.Count;
		}

		public void AddControllerMapEnablerRuleSet()
		{
			controllerMapEnablerRuleSets.Add(OdDEAgGKRVUvcaYDTvmFsZKSMGwk());
		}

		public void InsertControllerMapEnablerRuleSet(int index)
		{
			if (index < 0 || index >= controllerMapEnablerRuleSets.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			controllerMapEnablerRuleSets.Insert(index, OdDEAgGKRVUvcaYDTvmFsZKSMGwk());
		}

		public void DeleteControllerMapEnablerRuleSet(int index)
		{
			if (controllerMapEnablerRuleSets == null || index < 0 || index >= controllerMapEnablerRuleSets.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			int id = controllerMapEnablerRuleSets[index].id;
			if (players != null)
			{
				for (int i = 0; i < players.Count; i++)
				{
					Player_Editor player_Editor = players[i];
					if (player_Editor == null)
					{
						continue;
					}
					List<Player_Editor.RuleSetMapping> ruleSets = player_Editor.controllerMapEnablerSettings.ruleSets;
					if (ruleSets == null)
					{
						continue;
					}
					for (int num = ruleSets.Count - 1; num >= 0; num--)
					{
						if (ruleSets[num] != null && ruleSets[num].id == id)
						{
							ruleSets.RemoveAt(num);
						}
					}
				}
			}
			controllerMapEnablerRuleSets.RemoveAt(index);
		}

		public bool ReorderControllerMapEnablerRuleSet(int index, bool offsetDown, bool offsetNow)
		{
			return ListTools.OffsetAtIndex(controllerMapEnablerRuleSets, index, offsetDown, offsetNow);
		}

		public void DuplicateControllerMapEnablerRuleSet(int index)
		{
			if (controllerMapEnablerRuleSets == null || index < 0 || index >= controllerMapEnablerRuleSets.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			ControllerMapEnabler_RuleSet_Editor controllerMapEnabler_RuleSet_Editor = controllerMapEnablerRuleSets[index].Clone();
			controllerMapEnabler_RuleSet_Editor.id = GetNewControllerMapEnablerRuleSetId();
			controllerMapEnabler_RuleSet_Editor.name = StringTools.IterateName(controllerMapEnabler_RuleSet_Editor.name, -1, GetControllerMapEnablerRuleSetNames());
			if (index == controllerMapEnablerRuleSets.Count - 1)
			{
				controllerMapEnablerRuleSets.Add(controllerMapEnabler_RuleSet_Editor);
			}
			else
			{
				controllerMapEnablerRuleSets.Insert(index + 1, controllerMapEnabler_RuleSet_Editor);
			}
		}

		public int GetControllerMapEnablerRuleSetUsedCount(int id)
		{
			if (controllerMapEnablerRuleSets == null)
			{
				return 0;
			}
			int num = 0;
			if (players != null)
			{
				for (int i = 0; i < players.Count; i++)
				{
					Player_Editor player_Editor = players[i];
					if (player_Editor == null)
					{
						continue;
					}
					List<Player_Editor.RuleSetMapping> ruleSets = player_Editor.controllerMapEnablerSettings.ruleSets;
					if (ruleSets == null)
					{
						continue;
					}
					for (int num2 = ruleSets.Count - 1; num2 >= 0; num2--)
					{
						if (ruleSets[num2] != null && ruleSets[num2].id == id)
						{
							num++;
						}
					}
				}
			}
			return num;
		}

		public int GetControllerMapEnablerRuleSetIndex(int id)
		{
			if (controllerMapEnablerRuleSets == null)
			{
				return 0;
			}
			for (int i = 0; i < controllerMapEnablerRuleSets.Count; i++)
			{
				if (controllerMapEnablerRuleSets[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public string[] GetControllerMapEnablerRuleSetNames()
		{
			if (controllerMapEnablerRuleSets == null)
			{
				return null;
			}
			string[] array = new string[controllerMapEnablerRuleSets.Count];
			for (int i = 0; i < controllerMapEnablerRuleSets.Count; i++)
			{
				array[i] = controllerMapEnablerRuleSets[i].name;
			}
			return array;
		}

		public int[] GetControllerMapEnablerRuleSetIds()
		{
			if (controllerMapEnablerRuleSets == null)
			{
				return null;
			}
			int[] array = new int[controllerMapEnablerRuleSets.Count];
			for (int i = 0; i < controllerMapEnablerRuleSets.Count; i++)
			{
				array[i] = controllerMapEnablerRuleSets[i].id;
			}
			return array;
		}

		public ControllerMapEnabler_RuleSet_Editor GetControllerMapEnablerRuleSet(int index)
		{
			if (controllerMapEnablerRuleSets == null || index < 0 || index >= controllerMapEnablerRuleSets.Count)
			{
				return null;
			}
			return controllerMapEnablerRuleSets[index];
		}

		public ControllerMapEnabler_RuleSet_Editor GetControllerMapEnablerRuleSet(string name)
		{
			if (controllerMapEnablerRuleSets == null)
			{
				return null;
			}
			int num = IndexOfControllerMapEnablerRuleSet(name);
			if (num < 0)
			{
				return null;
			}
			return controllerMapEnablerRuleSets[num];
		}

		public ControllerMapEnabler_RuleSet_Editor GetControllerMapEnablerRuleSetById(int id)
		{
			if (controllerMapEnablerRuleSets == null)
			{
				return null;
			}
			int num = IndexOfControllerMapEnablerRuleSet(id);
			if (num < 0)
			{
				return null;
			}
			return controllerMapEnablerRuleSets[num];
		}

		public int GetControllerMapEnablerRuleSetId(string name)
		{
			if (controllerMapEnablerRuleSets == null)
			{
				return -1;
			}
			int num = IndexOfControllerMapEnablerRuleSet(name);
			if (num < 0)
			{
				return -1;
			}
			return controllerMapEnablerRuleSets[num].id;
		}

		public int IndexOfControllerMapEnablerRuleSet(int id)
		{
			if (controllerMapEnablerRuleSets == null)
			{
				return -1;
			}
			for (int i = 0; i < controllerMapEnablerRuleSets.Count; i++)
			{
				if (controllerMapEnablerRuleSets[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public int IndexOfControllerMapEnablerRuleSet(string name)
		{
			if (name == null || name == string.Empty)
			{
				return -1;
			}
			if (controllerMapEnablerRuleSets == null)
			{
				return -1;
			}
			for (int i = 0; i < controllerMapEnablerRuleSets.Count; i++)
			{
				if (controllerMapEnablerRuleSets[i].name.Equals(name, StringComparison.OrdinalIgnoreCase))
				{
					return i;
				}
			}
			return -1;
		}

		public string GetControllerMapEnablerRuleSetNameById(int id)
		{
			if (controllerMapEnablerRuleSets != null)
			{
				for (int i = 0; i < controllerMapEnablerRuleSets.Count; i++)
				{
					if (controllerMapEnablerRuleSets[i].id == id)
					{
						return controllerMapEnablerRuleSets[i].name;
					}
				}
			}
			return "Unknown";
		}

		public int GetControllerMapEnablerRuleSetCount()
		{
			if (controllerMapEnablerRuleSets == null)
			{
				return 0;
			}
			return controllerMapEnablerRuleSets.Count;
		}

		public int GetNewPlayerId()
		{
			int result = playerIdCounter;
			playerIdCounter++;
			return result;
		}

		public int GetNewActionId()
		{
			int result = actionIdCounter;
			actionIdCounter++;
			return result;
		}

		public int GetNewActionCategoryId()
		{
			int result = actionCategoryIdCounter;
			actionCategoryIdCounter++;
			return result;
		}

		public int GetNewInputBehaviorId()
		{
			int result = inputBehaviorIdCounter;
			inputBehaviorIdCounter++;
			return result;
		}

		public int GetNewMapCategoryId()
		{
			int result = mapCategoryIdCounter;
			mapCategoryIdCounter++;
			return result;
		}

		public int GetNewJoystickLayoutId()
		{
			int result = joystickLayoutIdCounter;
			joystickLayoutIdCounter++;
			return result;
		}

		public int GetNewKeyboardLayoutId()
		{
			int result = keyboardLayoutIdCounter;
			keyboardLayoutIdCounter++;
			return result;
		}

		public int GetNewMouseLayoutId()
		{
			int result = mouseLayoutIdCounter;
			mouseLayoutIdCounter++;
			return result;
		}

		public int GetNewCustomControllerLayoutId()
		{
			int result = customControllerLayoutIdCounter;
			customControllerLayoutIdCounter++;
			return result;
		}

		public int GetNewJoystickMapId()
		{
			int result = joystickMapIdCounter;
			joystickMapIdCounter++;
			return result;
		}

		public int GetNewKeyboardMapId()
		{
			int result = keyboardMapIdCounter;
			keyboardMapIdCounter++;
			return result;
		}

		public int GetNewMouseMapId()
		{
			int result = mouseMapIdCounter;
			mouseMapIdCounter++;
			return result;
		}

		public int GetNewCustomControllerMapId()
		{
			int result = customControllerMapIdCounter;
			customControllerMapIdCounter++;
			return result;
		}

		public int GetNewCustomControllerId()
		{
			int result = customControllerIdCounter;
			customControllerIdCounter++;
			return result;
		}

		public int GetNewControllerMapLayoutManagerRuleSetId()
		{
			int result = controllerMapLayoutManagerSetIdCounter;
			controllerMapLayoutManagerSetIdCounter++;
			return result;
		}

		public int GetNewControllerMapEnablerRuleSetId()
		{
			int result = controllerMapEnablerSetIdCounter;
			controllerMapEnablerSetIdCounter++;
			return result;
		}

		private Player_Editor aAltqjYcdwwTUslukyvBnpOgfuL()
		{
			Player_Editor player_Editor = new Player_Editor();
			player_Editor.id = GetNewPlayerId();
			player_Editor.name = StringTools.IterateName("Player", -1, GetPlayerNames());
			player_Editor.descriptiveName = player_Editor.name;
			player_Editor.startPlaying = true;
			if (players.Count == 1)
			{
				player_Editor.assignMouseOnStart = true;
			}
			player_Editor.assignKeyboardOnStart = true;
			player_Editor.controllerMapEnablerSettings = new Player_Editor.ControllerMapEnablerSettings();
			player_Editor.controllerMapLayoutManagerSettings = new Player_Editor.ControllerMapLayoutManagerSettings();
			return player_Editor;
		}

		private InputAction ELYbXuHvWHcWAmBZtwnhJvbNpvST()
		{
			InputAction inputAction = new InputAction();
			inputAction.id = GetNewActionId();
			inputAction.name = StringTools.IterateName("Action", -1, GetActionNames());
			inputAction.descriptiveName = inputAction.name;
			inputAction.type = InputActionType.Button;
			inputAction.userAssignable = true;
			inputAction.behaviorId = 0;
			return inputAction;
		}

		private InputCategory hNvnukDSENvHZQlIAAyFHTSLQeQJ()
		{
			InputCategory inputCategory = new InputCategory();
			inputCategory.id = GetNewActionCategoryId();
			inputCategory.name = StringTools.IterateName("Category", -1, GetActionCategoryNames());
			inputCategory.descriptiveName = inputCategory.name;
			inputCategory.userAssignable = true;
			return inputCategory;
		}

		private InputBehavior AXXqXFurVLGrkSvrtkBqyYZhfbO()
		{
			InputBehavior inputBehavior = new InputBehavior();
			inputBehavior.id = GetNewInputBehaviorId();
			inputBehavior.name = StringTools.IterateName("Behavior", -1, GetInputBehaviorNames());
			inputBehavior.digitalAxisSimulation = true;
			inputBehavior.digitalAxisSnap = true;
			inputBehavior.digitalAxisInstantReverse = false;
			inputBehavior.digitalAxisGravity = 3f;
			inputBehavior.digitalAxisSensitivity = 3f;
			inputBehavior.mouseXYAxisMode = MouseXYAxisMode.MouseAxis;
			inputBehavior.mouseXYAxisSensitivity = 1f;
			inputBehavior.mouseOtherAxisMode = MouseOtherAxisMode.MouseAxis;
			inputBehavior.mouseOtherAxisSensitivity = 1f;
			inputBehavior.buttonDoublePressSpeed = 0.3f;
			inputBehavior.buttonShortPressTime = 0.25f;
			inputBehavior.buttonShortPressExpiresIn = 0f;
			inputBehavior.buttonLongPressTime = 1f;
			inputBehavior.buttonLongPressExpiresIn = 0f;
			inputBehavior.buttonDeadZone = 0.5f;
			inputBehavior.buttonDownBuffer = 0f;
			return inputBehavior;
		}

		private InputMapCategory CjigcWKkXuPQIoMVFurArKZRGgi()
		{
			InputMapCategory inputMapCategory = new InputMapCategory();
			inputMapCategory.id = GetNewMapCategoryId();
			inputMapCategory.name = StringTools.IterateName("Category", -1, GetMapCategoryNames());
			inputMapCategory.descriptiveName = inputMapCategory.name;
			inputMapCategory.userAssignable = true;
			inputMapCategory.checkConflictsWithAllCategories = true;
			return inputMapCategory;
		}

		private InputLayout DxAuZbwceYYzJybuCXnHnrWeHOm()
		{
			InputLayout inputLayout = new InputLayout();
			inputLayout.id = GetNewJoystickLayoutId();
			inputLayout.name = StringTools.IterateName("Layout", -1, GetJoystickLayoutNames());
			inputLayout.descriptiveName = inputLayout.name;
			return inputLayout;
		}

		private InputLayout gZlkYLWAePxqzyDKJaWRMvlfedOF()
		{
			InputLayout inputLayout = new InputLayout();
			inputLayout.id = GetNewKeyboardLayoutId();
			inputLayout.name = StringTools.IterateName("Layout", -1, GetKeyboardLayoutNames());
			inputLayout.descriptiveName = inputLayout.name;
			return inputLayout;
		}

		private InputLayout ELeFZkPPoLFIBkDZCHmOFmqEWFii()
		{
			InputLayout inputLayout = new InputLayout();
			inputLayout.id = GetNewMouseLayoutId();
			inputLayout.name = StringTools.IterateName("Layout", -1, GetMouseLayoutNames());
			inputLayout.descriptiveName = inputLayout.name;
			return inputLayout;
		}

		private InputLayout FEoHVHNLtbBjQHpnWSDFfOnvScls()
		{
			InputLayout inputLayout = new InputLayout();
			inputLayout.id = GetNewCustomControllerLayoutId();
			inputLayout.name = StringTools.IterateName("Layout", -1, GetCustomControllerLayoutNames());
			inputLayout.descriptiveName = inputLayout.name;
			return inputLayout;
		}

		private CustomController_Editor RNfPVYXapTTONepYDHTrZmcvqoo()
		{
			CustomController_Editor customController_Editor = new CustomController_Editor();
			customController_Editor.id = GetNewCustomControllerId();
			customController_Editor.typeGuid = Guid.NewGuid();
			customController_Editor.name = StringTools.IterateName("CustomController", -1, GetCustomControllerNames());
			customController_Editor.descriptiveName = customController_Editor.name;
			return customController_Editor;
		}

		private ControllerMapLayoutManager_RuleSet_Editor PEVOtpVhMgJYNlhTkKzlkuIgiPg()
		{
			ControllerMapLayoutManager_RuleSet_Editor controllerMapLayoutManager_RuleSet_Editor = new ControllerMapLayoutManager_RuleSet_Editor();
			controllerMapLayoutManager_RuleSet_Editor.id = GetNewControllerMapLayoutManagerRuleSetId();
			controllerMapLayoutManager_RuleSet_Editor.name = StringTools.IterateName("RuleSet", -1, GetControllerMapLayoutManagerRuleSetNames());
			return controllerMapLayoutManager_RuleSet_Editor;
		}

		private ControllerMapEnabler_RuleSet_Editor OdDEAgGKRVUvcaYDTvmFsZKSMGwk()
		{
			ControllerMapEnabler_RuleSet_Editor controllerMapEnabler_RuleSet_Editor = new ControllerMapEnabler_RuleSet_Editor();
			controllerMapEnabler_RuleSet_Editor.id = GetNewControllerMapEnablerRuleSetId();
			controllerMapEnabler_RuleSet_Editor.name = StringTools.IterateName("RuleSet", -1, GetControllerMapEnablerRuleSetNames());
			return controllerMapEnabler_RuleSet_Editor;
		}

		private ControllerMap_Editor MoJkeWtcKsmQfKVqlcQGFbDFoNs(List<ControllerMap_Editor> P_0, int P_1, int P_2)
		{
			if (P_0 == null)
			{
				return null;
			}
			for (int i = 0; i < P_0.Count; i++)
			{
				if (P_0[i].categoryId == P_1 && P_0[i].layoutId == P_2)
				{
					return P_0[i];
				}
			}
			return null;
		}

		private ControllerMap_Editor caTtGDToxDJIAwPpeSjfgpusLYd(List<ControllerMap_Editor> P_0, List<InputLayout> P_1, int P_2, int P_3, bool P_4)
		{
			ControllerMap_Editor controllerMap_Editor = MoJkeWtcKsmQfKVqlcQGFbDFoNs(P_0, P_2, P_3);
			if (controllerMap_Editor != null)
			{
				return controllerMap_Editor;
			}
			if (P_4)
			{
				controllerMap_Editor = NOuChjJOXrEktcRMiCcXSVhJqPlp(P_0, P_1, P_2, P_3);
				if (controllerMap_Editor != null)
				{
					return controllerMap_Editor;
				}
			}
			return null;
		}

		private ControllerMap_Editor NOuChjJOXrEktcRMiCcXSVhJqPlp(List<ControllerMap_Editor> P_0, List<InputLayout> P_1, int P_2, int P_3)
		{
			List<ControllerMap_Editor> list = ListTools.ShallowCopy(P_0);
			if (list != null && list.Count > 0)
			{
				AIoFmtCTlzXHaNtbYhHVCoRNBtaP(list, P_1);
				for (int i = 0; i < list.Count; i++)
				{
					if (list[i].categoryId == P_2)
					{
						return list[i];
					}
				}
				for (int j = 0; j < list.Count; j++)
				{
					if (list[j].categoryId == 0)
					{
						return list[j];
					}
				}
			}
			return null;
		}

		private void AIoFmtCTlzXHaNtbYhHVCoRNBtaP(List<ControllerMap_Editor> P_0, List<InputLayout> P_1)
		{
			if (P_0 == null || P_1 == null)
			{
				return;
			}
			P_0.Sort(delegate(ControllerMap_Editor P_0, ControllerMap_Editor P_1)
			{
				int num = P_1.FindIndex((InputLayout P_0) => P_0.id == P_0.id);
				int num2 = P_1.FindIndex((InputLayout P_0) => P_0.id == P_1.id);
				if (num > num2)
				{
					return 1;
				}
				return (num < num2) ? (-1) : 0;
			});
		}

		internal void ijQPrfbohIDtyfCSvLMVhrlmSpB()
		{
			Players_readOnly = new ReadOnlyCollection<Player_Editor>(players);
			Actions_readOnly = new ReadOnlyCollection<InputAction>(actions);
			ActionCategories_readOnly = new ReadOnlyCollection<InputCategory>(actionCategories);
			InputBehaviors_readOnly = new ReadOnlyCollection<InputBehavior>(inputBehaviors);
			MapCategories_readOnly = new ReadOnlyCollection<InputMapCategory>(mapCategories);
			JoystickLayouts_readOnly = new ReadOnlyCollection<InputLayout>(joystickLayouts);
			KeyboardLayouts_readOnly = new ReadOnlyCollection<InputLayout>(keyboardLayouts);
			MouseLayouts_readOnly = new ReadOnlyCollection<InputLayout>(mouseLayouts);
			CustomControllerLayouts_readOnly = new ReadOnlyCollection<InputLayout>(customControllerLayouts);
			JoystickMaps_readOnly = new ReadOnlyCollection<ControllerMap_Editor>(joystickMaps);
			KeyboardMaps_readOnly = new ReadOnlyCollection<ControllerMap_Editor>(keyboardMaps);
			MouseMaps_readOnly = new ReadOnlyCollection<ControllerMap_Editor>(mouseMaps);
			CustomControllerMaps_readOnly = new ReadOnlyCollection<ControllerMap_Editor>(customControllerMaps);
			ControllerMapLayoutManagerRuleSets_readOnly = new ReadOnlyCollection<ControllerMapLayoutManager_RuleSet_Editor>(controllerMapLayoutManagerRuleSets);
			ControllerMapEnablerRuleSets_readOnly = new ReadOnlyCollection<ControllerMapEnabler_RuleSet_Editor>(controllerMapEnablerRuleSets);
			if (mapCategories != null)
			{
				for (int i = 0; i < mapCategories.Count; i++)
				{
					mapCategories[i].ijQPrfbohIDtyfCSvLMVhrlmSpB();
				}
			}
			containsActionDelegate = ContainsAction;
		}

		[CustomObfuscation(rename = false)]
		internal static UserData Merge(UserData orig, UserData other, bool preserveOrigIds)
		{
			return kGhIqyKaCfwXRhNgnSFPxPwnDqy.fXPhyUzKDetRtrRNdVKrqUJqTU(orig, other, preserveOrigIds);
		}

		[CustomObfuscation(rename = false)]
		internal static UserData Compact(UserData orig)
		{
			return kGhIqyKaCfwXRhNgnSFPxPwnDqy.fXPhyUzKDetRtrRNdVKrqUJqTU(orig, null, false);
		}

		[CompilerGenerated]
		private static void yeFGfJfEtEAfkXpHxvxtubkfCpMz(List<Player_Editor.Mapping> P_0, int P_1)
		{
			if (P_0 == null)
			{
				return;
			}
			for (int num = P_0.Count - 1; num >= 0; num--)
			{
				if (P_0[num] == null || P_0[num].categoryId == P_1)
				{
					P_0.RemoveAt(num);
				}
			}
		}

		[CompilerGenerated]
		private static void yRHYdBejfBFsOCQgEnMLaVLvXUc(List<Player_Editor.Mapping> P_0, int P_1)
		{
			if (P_0 == null)
			{
				return;
			}
			for (int num = P_0.Count - 1; num >= 0; num--)
			{
				if (P_0[num] == null || P_0[num].layoutId == P_1)
				{
					P_0.RemoveAt(num);
				}
			}
		}

		[CompilerGenerated]
		private static void hYgOtIREpzGtZLtzsfOBPrHIBXgb(List<Player_Editor.Mapping> P_0, int P_1)
		{
			if (P_0 == null)
			{
				return;
			}
			for (int num = P_0.Count - 1; num >= 0; num--)
			{
				if (P_0[num] == null || P_0[num].layoutId == P_1)
				{
					P_0.RemoveAt(num);
				}
			}
		}

		[CompilerGenerated]
		private static void BLwvBabHqIDqfbaMQoItfOFIKTSN(List<Player_Editor.Mapping> P_0, int P_1)
		{
			if (P_0 == null)
			{
				return;
			}
			for (int num = P_0.Count - 1; num >= 0; num--)
			{
				if (P_0[num] == null || P_0[num].layoutId == P_1)
				{
					P_0.RemoveAt(num);
				}
			}
		}

		[CompilerGenerated]
		private static void niYjMASvfITDckqAiAiOhHHZMRR(List<Player_Editor.Mapping> P_0, int P_1)
		{
			if (P_0 == null)
			{
				return;
			}
			for (int num = P_0.Count - 1; num >= 0; num--)
			{
				if (P_0[num] == null || P_0[num].layoutId == P_1)
				{
					P_0.RemoveAt(num);
				}
			}
		}
	}
}
