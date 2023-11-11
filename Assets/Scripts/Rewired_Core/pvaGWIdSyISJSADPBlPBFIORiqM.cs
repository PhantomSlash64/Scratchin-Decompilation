using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;

internal class pvaGWIdSyISJSADPBlPBFIORiqM
{
	public class tyvyzfSnwwrFpRhUrlSzRAnqxqh
	{
		public readonly Action<InputActionEventData> ntdQAYYKCISkDZMPhXhyiKDSvkD;

		public readonly UpdateLoopType EtMuBRTmVzCBLcuxYRMlwUqRdAzD;

		public readonly InputActionEventType RmVIgwjghCUZjaaGXmxHxOUTlGu;

		public readonly int cJTdHcaeBzqfrLPRWYuoPWTszLhk;

		public readonly bool CoPvheSgWqPpopqeVtkAWynYWDs;

		public float[] lczADgvMISqhqwzpgxwRHltrTCs;

		public tyvyzfSnwwrFpRhUrlSzRAnqxqh(Action<InputActionEventData> @delegate, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId, object[] arguments)
		{
			EtMuBRTmVzCBLcuxYRMlwUqRdAzD = updateLoop;
			RmVIgwjghCUZjaaGXmxHxOUTlGu = eventType;
			cJTdHcaeBzqfrLPRWYuoPWTszLhk = actionId;
			ntdQAYYKCISkDZMPhXhyiKDSvkD = @delegate;
			LCsgrkIxZPjbmwgZEVEFUkGLeor(arguments);
			switch (eventType)
			{
			case InputActionEventType.Update:
			case InputActionEventType.ButtonUnpressed:
			case InputActionEventType.NegativeButtonUnpressed:
			case InputActionEventType.AxisInactive:
			case InputActionEventType.AxisRawInactive:
				CoPvheSgWqPpopqeVtkAWynYWDs = true;
				break;
			}
		}

		public bool xPYvbzPQOuOafLwXxVWkEpywCv(int P_0, out float P_1)
		{
			if (lczADgvMISqhqwzpgxwRHltrTCs == null || lczADgvMISqhqwzpgxwRHltrTCs.Length <= P_0)
			{
				P_1 = 0f;
				return false;
			}
			P_1 = lczADgvMISqhqwzpgxwRHltrTCs[P_0];
			return true;
		}

		private void LCsgrkIxZPjbmwgZEVEFUkGLeor(object[] P_0)
		{
			switch (RmVIgwjghCUZjaaGXmxHxOUTlGu)
			{
			case InputActionEventType.ButtonPressedForTime:
			case InputActionEventType.ButtonPressedForTimeJustReleased:
			case InputActionEventType.NegativeButtonPressedForTime:
			case InputActionEventType.NegativeButtonPressedForTimeJustReleased:
				if (P_0 == null || P_0.Length < 1)
				{
					throw new Exception(string.Concat("Wrong number of arguments passed for Input event type \"", RmVIgwjghCUZjaaGXmxHxOUTlGu, "\". 1 required argument: time [float], 1 optional argument: expireIn [float]"));
				}
				lczADgvMISqhqwzpgxwRHltrTCs = new float[2];
				if (P_0[0] is float)
				{
					lczADgvMISqhqwzpgxwRHltrTCs[0] = (float)P_0[0];
				}
				else
				{
					if (!(P_0[0] is int))
					{
						throw new Exception(string.Concat("Wrong argument type passed for Input event type \"", RmVIgwjghCUZjaaGXmxHxOUTlGu, "\". Argument 0: time [float]"));
					}
					lczADgvMISqhqwzpgxwRHltrTCs[0] = (int)P_0[0];
				}
				if (P_0.Length <= 1)
				{
					break;
				}
				if (P_0[1] is float)
				{
					lczADgvMISqhqwzpgxwRHltrTCs[1] = (float)P_0[1];
					break;
				}
				if (P_0[1] is int)
				{
					lczADgvMISqhqwzpgxwRHltrTCs[1] = (int)P_0[1];
					break;
				}
				throw new Exception(string.Concat("Wrong argument type passed for Input event type \"", RmVIgwjghCUZjaaGXmxHxOUTlGu, "\". Argument 1 (optional): expireIn [float]"));
			case InputActionEventType.ButtonJustPressedForTime:
			case InputActionEventType.NegativeButtonJustPressedForTime:
				if (P_0 == null || P_0.Length < 1)
				{
					throw new Exception(string.Concat("Wrong number of arguments passed for Input event type \"", RmVIgwjghCUZjaaGXmxHxOUTlGu, "\". Requires 1 argument: time [float]"));
				}
				lczADgvMISqhqwzpgxwRHltrTCs = new float[1];
				if (P_0[0] is float)
				{
					lczADgvMISqhqwzpgxwRHltrTCs[0] = (float)P_0[0];
					break;
				}
				if (P_0[0] is int)
				{
					lczADgvMISqhqwzpgxwRHltrTCs[0] = (int)P_0[0];
					break;
				}
				throw new Exception(string.Concat("Wrong argument type passed for Input event type \"", RmVIgwjghCUZjaaGXmxHxOUTlGu, "\". Argument 0: time [float]"));
			case InputActionEventType.ButtonDoublePressed:
			case InputActionEventType.ButtonJustDoublePressed:
			case InputActionEventType.NegativeButtonDoublePressed:
			case InputActionEventType.NegativeButtonJustDoublePressed:
			case InputActionEventType.ButtonDoublePressJustReleased:
			case InputActionEventType.NegativeButtonDoublePressJustReleased:
				if (P_0 == null || P_0.Length < 1)
				{
					break;
				}
				lczADgvMISqhqwzpgxwRHltrTCs = new float[1];
				if (P_0[0] is float)
				{
					lczADgvMISqhqwzpgxwRHltrTCs[0] = (float)P_0[0];
					break;
				}
				if (P_0[0] is int)
				{
					lczADgvMISqhqwzpgxwRHltrTCs[0] = (int)P_0[0];
					break;
				}
				throw new Exception(string.Concat("Wrong argument type passed for Input event type \"", RmVIgwjghCUZjaaGXmxHxOUTlGu, "\". Argument 0 (optional): time [float]"));
			}
		}
	}

	[CompilerGenerated]
	private sealed class qNMeVrdXnoBZNHbvtxTMfLJKjcth
	{
		public Action<InputActionEventData> ntdQAYYKCISkDZMPhXhyiKDSvkD;

		public bool tVpcrxxNrxFauUwFjMIucmktHWrF(tyvyzfSnwwrFpRhUrlSzRAnqxqh P_0)
		{
			return P_0.ntdQAYYKCISkDZMPhXhyiKDSvkD == ntdQAYYKCISkDZMPhXhyiKDSvkD;
		}
	}

	[CompilerGenerated]
	private sealed class UaKVZyliUbniOlRJUOTyGrzQpOB
	{
		public Action<InputActionEventData> ntdQAYYKCISkDZMPhXhyiKDSvkD;

		public int cJTdHcaeBzqfrLPRWYuoPWTszLhk;

		public bool LXHoPSHVwpteBwpmrXDKdfdqYvC(tyvyzfSnwwrFpRhUrlSzRAnqxqh P_0)
		{
			if (P_0.ntdQAYYKCISkDZMPhXhyiKDSvkD == ntdQAYYKCISkDZMPhXhyiKDSvkD)
			{
				return P_0.cJTdHcaeBzqfrLPRWYuoPWTszLhk == cJTdHcaeBzqfrLPRWYuoPWTszLhk;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class pRxpFqmTNTtAwuPTGjdQyzFGCiQ
	{
		public Action<InputActionEventData> ntdQAYYKCISkDZMPhXhyiKDSvkD;

		public UpdateLoopType EtMuBRTmVzCBLcuxYRMlwUqRdAzD;

		public bool XXxOqsUUfQGWOzylJdugGakZhID(tyvyzfSnwwrFpRhUrlSzRAnqxqh P_0)
		{
			if (P_0.ntdQAYYKCISkDZMPhXhyiKDSvkD == ntdQAYYKCISkDZMPhXhyiKDSvkD)
			{
				return P_0.EtMuBRTmVzCBLcuxYRMlwUqRdAzD == EtMuBRTmVzCBLcuxYRMlwUqRdAzD;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class MiecWTsOfPSAlhPeBogcdpIkBhb
	{
		public Action<InputActionEventData> ntdQAYYKCISkDZMPhXhyiKDSvkD;

		public InputActionEventType RmVIgwjghCUZjaaGXmxHxOUTlGu;

		public bool CQupZFfnVZYcVRaIKbIPXnbyBfEF(tyvyzfSnwwrFpRhUrlSzRAnqxqh P_0)
		{
			if (P_0.ntdQAYYKCISkDZMPhXhyiKDSvkD == ntdQAYYKCISkDZMPhXhyiKDSvkD)
			{
				return P_0.RmVIgwjghCUZjaaGXmxHxOUTlGu == RmVIgwjghCUZjaaGXmxHxOUTlGu;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class BrYLJjQwqSXkZNRSQOJISinMGRf
	{
		public Action<InputActionEventData> ntdQAYYKCISkDZMPhXhyiKDSvkD;

		public UpdateLoopType EtMuBRTmVzCBLcuxYRMlwUqRdAzD;

		public int cJTdHcaeBzqfrLPRWYuoPWTszLhk;

		public bool KwwegxByxdudCRVPcEEQxyYNSfp(tyvyzfSnwwrFpRhUrlSzRAnqxqh P_0)
		{
			if (P_0.ntdQAYYKCISkDZMPhXhyiKDSvkD == ntdQAYYKCISkDZMPhXhyiKDSvkD && P_0.EtMuBRTmVzCBLcuxYRMlwUqRdAzD == EtMuBRTmVzCBLcuxYRMlwUqRdAzD)
			{
				return P_0.cJTdHcaeBzqfrLPRWYuoPWTszLhk == cJTdHcaeBzqfrLPRWYuoPWTszLhk;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class nKcWOtVLlMdcJjuosTGGxkuqKXBG
	{
		public Action<InputActionEventData> ntdQAYYKCISkDZMPhXhyiKDSvkD;

		public UpdateLoopType EtMuBRTmVzCBLcuxYRMlwUqRdAzD;

		public InputActionEventType RmVIgwjghCUZjaaGXmxHxOUTlGu;

		public int cJTdHcaeBzqfrLPRWYuoPWTszLhk;

		public bool ttHcunGbtsvZpAVGJoljjzzGPvls(tyvyzfSnwwrFpRhUrlSzRAnqxqh P_0)
		{
			if (P_0.ntdQAYYKCISkDZMPhXhyiKDSvkD == ntdQAYYKCISkDZMPhXhyiKDSvkD && P_0.EtMuBRTmVzCBLcuxYRMlwUqRdAzD == EtMuBRTmVzCBLcuxYRMlwUqRdAzD && P_0.cJTdHcaeBzqfrLPRWYuoPWTszLhk == cJTdHcaeBzqfrLPRWYuoPWTszLhk)
			{
				return P_0.RmVIgwjghCUZjaaGXmxHxOUTlGu == RmVIgwjghCUZjaaGXmxHxOUTlGu;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class DsunVIaliQIJhfjlHZFIzxRiDkd
	{
		public Action<InputActionEventData> ntdQAYYKCISkDZMPhXhyiKDSvkD;

		public UpdateLoopType EtMuBRTmVzCBLcuxYRMlwUqRdAzD;

		public InputActionEventType RmVIgwjghCUZjaaGXmxHxOUTlGu;

		public bool olynhRGfbCfLlEIyGdAvuQWnDxQB(tyvyzfSnwwrFpRhUrlSzRAnqxqh P_0)
		{
			if (P_0.ntdQAYYKCISkDZMPhXhyiKDSvkD == ntdQAYYKCISkDZMPhXhyiKDSvkD && P_0.EtMuBRTmVzCBLcuxYRMlwUqRdAzD == EtMuBRTmVzCBLcuxYRMlwUqRdAzD)
			{
				return P_0.RmVIgwjghCUZjaaGXmxHxOUTlGu == RmVIgwjghCUZjaaGXmxHxOUTlGu;
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class xnAaRldKEmLyEuBHTOidcYKdgnWL
	{
		public Action<InputActionEventData> ntdQAYYKCISkDZMPhXhyiKDSvkD;

		public InputActionEventType RmVIgwjghCUZjaaGXmxHxOUTlGu;

		public int cJTdHcaeBzqfrLPRWYuoPWTszLhk;

		public bool odcUAQdMToLSdmOrCafTIfoULvTz(tyvyzfSnwwrFpRhUrlSzRAnqxqh P_0)
		{
			if (P_0.ntdQAYYKCISkDZMPhXhyiKDSvkD == ntdQAYYKCISkDZMPhXhyiKDSvkD && P_0.cJTdHcaeBzqfrLPRWYuoPWTszLhk == cJTdHcaeBzqfrLPRWYuoPWTszLhk)
			{
				return P_0.RmVIgwjghCUZjaaGXmxHxOUTlGu == RmVIgwjghCUZjaaGXmxHxOUTlGu;
			}
			return false;
		}
	}

	private static tyvyzfSnwwrFpRhUrlSzRAnqxqh[] JqHOjrwJgahRdVfRHgOwTTBWOEU;

	private bool sQTBWTNxxjaWNFsekFBPFIwaffDK;

	private AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh>[] bDpLjeMyPqHfhoxioztCysiGRiy;

	private int[] sylUJNYrbqTKGcBZLNVoFAeINTI;

	private int YdkMlVuTsvlOvgdFkOjPpggkUuJ;

	public int ISdYIoHLHpRQaxTRDfBvRqXUAbU;

	[CompilerGenerated]
	private static Func<AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh>> feNsFZUOhAfDWJOQenHKxUwAcDTR;

	static pvaGWIdSyISJSADPBlPBFIORiqM()
	{
		JqHOjrwJgahRdVfRHgOwTTBWOEU = new tyvyzfSnwwrFpRhUrlSzRAnqxqh[100];
	}

	private void ijQPrfbohIDtyfCSvLMVhrlmSpB()
	{
		if (!sQTBWTNxxjaWNFsekFBPFIwaffDK)
		{
			IList<InputAction> actions = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.yZSrNHqZKswEViXPXSJxQuBsxwA;
			int num = actions?.Count ?? 0;
			bDpLjeMyPqHfhoxioztCysiGRiy = new AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh>[num + 1];
			sylUJNYrbqTKGcBZLNVoFAeINTI = new int[ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.vsSdGwIcqfOhQEwPAxfsjlJAtjgH + 1];
			ArrayTools.Populate(bDpLjeMyPqHfhoxioztCysiGRiy, 0, bDpLjeMyPqHfhoxioztCysiGRiy.Length, () => new AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh>());
			for (int i = 0; i < num; i++)
			{
				sylUJNYrbqTKGcBZLNVoFAeINTI[actions[i].id] = i;
			}
			YdkMlVuTsvlOvgdFkOjPpggkUuJ = num;
			sQTBWTNxxjaWNFsekFBPFIwaffDK = true;
		}
	}

	public void tVKqwXOFgvpSghOGdkclktQflDc(XrsxaFoSedDmSEVIidqjOjugISoF P_0, UpdateLoopType P_1)
	{
		AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh> aList = bDpLjeMyPqHfhoxioztCysiGRiy[sylUJNYrbqTKGcBZLNVoFAeINTI[P_0.ARWjGDZdsNDKyFWsMDftBeVIijxg]];
		for (int i = 0; i < 2; i++)
		{
			if (i == 1)
			{
				aList = bDpLjeMyPqHfhoxioztCysiGRiy[YdkMlVuTsvlOvgdFkOjPpggkUuJ];
			}
			int count = aList._count;
			if (JqHOjrwJgahRdVfRHgOwTTBWOEU.Length < count)
			{
				JqHOjrwJgahRdVfRHgOwTTBWOEU = new tyvyzfSnwwrFpRhUrlSzRAnqxqh[count + 50];
			}
			if (count > 0)
			{
				Array.Copy(aList._items, JqHOjrwJgahRdVfRHgOwTTBWOEU, count);
			}
			for (int j = 0; j < count; j++)
			{
				tyvyzfSnwwrFpRhUrlSzRAnqxqh tyvyzfSnwwrFpRhUrlSzRAnqxqh = JqHOjrwJgahRdVfRHgOwTTBWOEU[j];
				if (tyvyzfSnwwrFpRhUrlSzRAnqxqh == null || (!P_0.AoCBqFmMAhRTERFsQyKaWpIlUpK && !tyvyzfSnwwrFpRhUrlSzRAnqxqh.CoPvheSgWqPpopqeVtkAWynYWDs) || tyvyzfSnwwrFpRhUrlSzRAnqxqh.EtMuBRTmVzCBLcuxYRMlwUqRdAzD != P_1 || (tyvyzfSnwwrFpRhUrlSzRAnqxqh.cJTdHcaeBzqfrLPRWYuoPWTszLhk >= 0 && tyvyzfSnwwrFpRhUrlSzRAnqxqh.cJTdHcaeBzqfrLPRWYuoPWTszLhk != P_0.ARWjGDZdsNDKyFWsMDftBeVIijxg))
				{
					continue;
				}
				bool flag = false;
				switch (tyvyzfSnwwrFpRhUrlSzRAnqxqh.RmVIgwjghCUZjaaGXmxHxOUTlGu)
				{
				case InputActionEventType.Update:
					flag = true;
					break;
				case InputActionEventType.ButtonPressed:
					if (P_0.TCWvrlpYTrIwTmaFZCrFglGyZdS())
					{
						flag = true;
					}
					break;
				case InputActionEventType.ButtonUnpressed:
					if (!P_0.TCWvrlpYTrIwTmaFZCrFglGyZdS())
					{
						flag = true;
					}
					break;
				case InputActionEventType.ButtonDoublePressed:
				{
					tyvyzfSnwwrFpRhUrlSzRAnqxqh.xPYvbzPQOuOafLwXxVWkEpywCv(0, out var num5);
					if (P_0.AhQsMzwZFroUkeOHfbjXGYXbODnh(num5))
					{
						flag = true;
					}
					break;
				}
				case InputActionEventType.ButtonPressedForTime:
				{
					if (!tyvyzfSnwwrFpRhUrlSzRAnqxqh.xPYvbzPQOuOafLwXxVWkEpywCv(0, out var num11))
					{
						continue;
					}
					tyvyzfSnwwrFpRhUrlSzRAnqxqh.xPYvbzPQOuOafLwXxVWkEpywCv(1, out var num12);
					if (P_0.QcSsRGYaurUSMbZdwrdNkblYzgD(num11, num12))
					{
						flag = true;
					}
					break;
				}
				case InputActionEventType.ButtonShortPressed:
					if (P_0.XjEQMBXsuqxlOCwbuTvPIFeIlEJ())
					{
						flag = true;
					}
					break;
				case InputActionEventType.ButtonLongPressed:
					if (P_0.ZENUyIwPfAqUZEjrkaSfQmivFle())
					{
						flag = true;
					}
					break;
				case InputActionEventType.ButtonJustPressed:
					if (P_0.UzfAMThVYdqMudGicKGhMmcVLNfe())
					{
						flag = true;
					}
					break;
				case InputActionEventType.ButtonJustReleased:
					if (P_0.oRveQXtNmlxxfdFQcBcgiXXDnHhU())
					{
						flag = true;
					}
					break;
				case InputActionEventType.ButtonJustDoublePressed:
				{
					tyvyzfSnwwrFpRhUrlSzRAnqxqh.xPYvbzPQOuOafLwXxVWkEpywCv(0, out var num9);
					if (P_0.kciImsjuaZduDjovtWDEackQout(num9))
					{
						flag = true;
					}
					break;
				}
				case InputActionEventType.ButtonDoublePressJustReleased:
				{
					tyvyzfSnwwrFpRhUrlSzRAnqxqh.xPYvbzPQOuOafLwXxVWkEpywCv(0, out var num6);
					if (P_0.pSusZntwSjsVdQQqxBEiXNXUupH(num6))
					{
						flag = true;
					}
					break;
				}
				case InputActionEventType.ButtonJustPressedForTime:
				{
					if (!tyvyzfSnwwrFpRhUrlSzRAnqxqh.xPYvbzPQOuOafLwXxVWkEpywCv(0, out var num4))
					{
						continue;
					}
					if (P_0.ClafnqACuizCNDqExqMplQHtUXa(num4))
					{
						flag = true;
					}
					break;
				}
				case InputActionEventType.ButtonJustShortPressed:
					if (P_0.UVAdNNaPpzDMuxxLAngERrubVTN())
					{
						flag = true;
					}
					break;
				case InputActionEventType.ButtonJustLongPressed:
					if (P_0.AaPJBzAaAdepKVGqwSjcPqUDOAq())
					{
						flag = true;
					}
					break;
				case InputActionEventType.ButtonPressedForTimeJustReleased:
				{
					if (!tyvyzfSnwwrFpRhUrlSzRAnqxqh.xPYvbzPQOuOafLwXxVWkEpywCv(0, out var num15))
					{
						continue;
					}
					tyvyzfSnwwrFpRhUrlSzRAnqxqh.xPYvbzPQOuOafLwXxVWkEpywCv(1, out var num16);
					if (P_0.HdfhlkfxObSYEdkqLNHoJMzhtOCJ(num15, num16))
					{
						flag = true;
					}
					break;
				}
				case InputActionEventType.ButtonShortPressJustReleased:
					if (P_0.kDgrwblaRrSDwudvldfKtFtJepxE())
					{
						flag = true;
					}
					break;
				case InputActionEventType.ButtonLongPressJustReleased:
					if (P_0.OgSlBUwSYdXdkzGtWzRiodFcEHR())
					{
						flag = true;
					}
					break;
				case InputActionEventType.ButtonRepeating:
					if (P_0.zKKTDzHWahorsmhpqdKidxrhKXnd())
					{
						flag = true;
					}
					break;
				case InputActionEventType.ButtonSinglePressed:
					if (P_0.UgWvGCEaRDvBZoxWBqudkBbBhjb())
					{
						flag = true;
					}
					break;
				case InputActionEventType.ButtonJustSinglePressed:
					if (P_0.ZmwKxnwfnEcMkNHCruCKBGYKOhg())
					{
						flag = true;
					}
					break;
				case InputActionEventType.ButtonSinglePressJustReleased:
					if (P_0.SSKnYIpdXiHqRnjdcsPJXbGUzOK())
					{
						flag = true;
					}
					break;
				case InputActionEventType.NegativeButtonPressed:
					if (P_0.iqaAyEcHqdpsAZatEXcYRcIruvj())
					{
						flag = true;
					}
					break;
				case InputActionEventType.NegativeButtonUnpressed:
					if (!P_0.iqaAyEcHqdpsAZatEXcYRcIruvj())
					{
						flag = true;
					}
					break;
				case InputActionEventType.NegativeButtonDoublePressed:
				{
					tyvyzfSnwwrFpRhUrlSzRAnqxqh.xPYvbzPQOuOafLwXxVWkEpywCv(0, out var num3);
					if (P_0.iSJFayIvWnbWJxcHZtTjNyWVhdE(num3))
					{
						flag = true;
					}
					break;
				}
				case InputActionEventType.NegativeButtonPressedForTime:
				{
					if (!tyvyzfSnwwrFpRhUrlSzRAnqxqh.xPYvbzPQOuOafLwXxVWkEpywCv(0, out var num))
					{
						continue;
					}
					tyvyzfSnwwrFpRhUrlSzRAnqxqh.xPYvbzPQOuOafLwXxVWkEpywCv(1, out var num2);
					if (P_0.XLCIyyxbfnSdTlbUKFeatCFHPva(num, num2))
					{
						flag = true;
					}
					break;
				}
				case InputActionEventType.NegativeButtonShortPressed:
					if (P_0.rsbocuLgoXoAeksZdweGqFofKRx())
					{
						flag = true;
					}
					break;
				case InputActionEventType.NegativeButtonLongPressed:
					if (P_0.IABnWtyeoNnaZZDvIABOPjPtFNR())
					{
						flag = true;
					}
					break;
				case InputActionEventType.NegativeButtonJustPressed:
					if (P_0.oXMNVKNTpnOLUaguzJPKSnhoapa())
					{
						flag = true;
					}
					break;
				case InputActionEventType.NegativeButtonJustReleased:
					if (P_0.bVfrluEmiRTJoxAilUuhMBMaOpt())
					{
						flag = true;
					}
					break;
				case InputActionEventType.NegativeButtonJustDoublePressed:
				{
					tyvyzfSnwwrFpRhUrlSzRAnqxqh.xPYvbzPQOuOafLwXxVWkEpywCv(0, out var num14);
					if (P_0.uzgrHHrIlamtEugSmzAcHkYNQwr(num14))
					{
						flag = true;
					}
					break;
				}
				case InputActionEventType.NegativeButtonDoublePressJustReleased:
				{
					tyvyzfSnwwrFpRhUrlSzRAnqxqh.xPYvbzPQOuOafLwXxVWkEpywCv(0, out var num13);
					if (P_0.OivUvHDLEenAQaHVtLYeIVbTFUJ(num13))
					{
						flag = true;
					}
					break;
				}
				case InputActionEventType.NegativeButtonJustPressedForTime:
				{
					if (!tyvyzfSnwwrFpRhUrlSzRAnqxqh.xPYvbzPQOuOafLwXxVWkEpywCv(0, out var num10))
					{
						continue;
					}
					if (P_0.aUWUfhQcfxidmePDKGfSXLgbEhb(num10))
					{
						flag = true;
					}
					break;
				}
				case InputActionEventType.NegativeButtonJustShortPressed:
					if (P_0.AZnzlkEspdMDrbGiJQSNLiVdzzR())
					{
						flag = true;
					}
					break;
				case InputActionEventType.NegativeButtonJustLongPressed:
					if (P_0.NPfjTCkwvhbbXdkUfjqqxQvNQHF())
					{
						flag = true;
					}
					break;
				case InputActionEventType.NegativeButtonPressedForTimeJustReleased:
				{
					if (!tyvyzfSnwwrFpRhUrlSzRAnqxqh.xPYvbzPQOuOafLwXxVWkEpywCv(0, out var num7))
					{
						continue;
					}
					tyvyzfSnwwrFpRhUrlSzRAnqxqh.xPYvbzPQOuOafLwXxVWkEpywCv(1, out var num8);
					if (P_0.nJUBAbsoiUeNQoUWzwBULFKwmKR(num7, num8))
					{
						flag = true;
					}
					break;
				}
				case InputActionEventType.NegativeButtonShortPressJustReleased:
					if (P_0.XVYuYDBxqNNkZvpfdecmrPImZKw())
					{
						flag = true;
					}
					break;
				case InputActionEventType.NegativeButtonLongPressJustReleased:
					if (P_0.PSwwnFdnPtdjhfHOsFWWyZFMCgT())
					{
						flag = true;
					}
					break;
				case InputActionEventType.NegativeButtonRepeating:
					if (P_0.bTMzAABqqYNwnBmyXsXvNssMmTt())
					{
						flag = true;
					}
					break;
				case InputActionEventType.NegativeButtonSinglePressed:
					if (P_0.evvTokiijtmyrGAgUTPZQMOILub())
					{
						flag = true;
					}
					break;
				case InputActionEventType.NegativeButtonJustSinglePressed:
					if (P_0.hBcUdxdjwIVlURrzizRRgZUZvDk())
					{
						flag = true;
					}
					break;
				case InputActionEventType.NegativeButtonSinglePressJustReleased:
					if (P_0.JvVzCNDKjgfIOJKRDWqCKxHwCvlG())
					{
						flag = true;
					}
					break;
				case InputActionEventType.AxisActive:
					if (!MathTools.ApproximatelyZero(P_0.GLWgPekOoFtzAmRRNYWNkzKdCZgc()))
					{
						flag = true;
					}
					break;
				case InputActionEventType.AxisInactive:
					if (MathTools.ApproximatelyZero(P_0.GLWgPekOoFtzAmRRNYWNkzKdCZgc()))
					{
						flag = true;
					}
					break;
				case InputActionEventType.AxisRawActive:
					if (!MathTools.ApproximatelyZero(P_0.XveAiBhJdpBhkOGEyKTpyxPqkZw()))
					{
						flag = true;
					}
					break;
				case InputActionEventType.AxisRawInactive:
					if (MathTools.ApproximatelyZero(P_0.XveAiBhJdpBhkOGEyKTpyxPqkZw()))
					{
						flag = true;
					}
					break;
				case InputActionEventType.AxisActiveOrJustInactive:
					if (!MathTools.ApproximatelyZero(P_0.GLWgPekOoFtzAmRRNYWNkzKdCZgc()) || !MathTools.ApproximatelyZero(P_0.iVALatsHQUVsDgFZEPWWmyXrOke()))
					{
						flag = true;
					}
					break;
				case InputActionEventType.AxisRawActiveOrJustInactive:
					if (!MathTools.ApproximatelyZero(P_0.XveAiBhJdpBhkOGEyKTpyxPqkZw()) || !MathTools.ApproximatelyZero(P_0.WtXxJknRRwYqhWjAscFTChvwcYO()))
					{
						flag = true;
					}
					break;
				default:
					throw new NotImplementedException();
				}
				try
				{
					if (flag)
					{
						InputActionEventData obj = P_0.rEjCcaPZjiPjQAuRQNdrCdCmQOb(P_1);
						obj.eventType = tyvyzfSnwwrFpRhUrlSzRAnqxqh.RmVIgwjghCUZjaaGXmxHxOUTlGu;
						tyvyzfSnwwrFpRhUrlSzRAnqxqh.ntdQAYYKCISkDZMPhXhyiKDSvkD(obj);
					}
				}
				catch (Exception exception)
				{
					ReInput.HandleCallbackException("Player input event callback", exception);
				}
			}
		}
	}

	public void SxRenVshBREfxhMTnKRbfUFvwoJi(Action<InputActionEventData> P_0, UpdateLoopType P_1, InputActionEventType P_2, int P_3, object[] P_4)
	{
		if (!sQTBWTNxxjaWNFsekFBPFIwaffDK)
		{
			ijQPrfbohIDtyfCSvLMVhrlmSpB();
		}
		tyvyzfSnwwrFpRhUrlSzRAnqxqh item;
		try
		{
			if (P_3 > ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.vsSdGwIcqfOhQEwPAxfsjlJAtjgH)
			{
				throw new ArgumentOutOfRangeException("Invalid Action Id " + P_3);
			}
			item = new tyvyzfSnwwrFpRhUrlSzRAnqxqh(P_0, P_1, P_2, P_3, P_4);
		}
		catch (Exception ex)
		{
			Logger.LogWarning("Failed to add Input Event delegate. Reason: " + ex.Message);
			return;
		}
		if (P_3 < 0)
		{
			bDpLjeMyPqHfhoxioztCysiGRiy[YdkMlVuTsvlOvgdFkOjPpggkUuJ].Add(item);
		}
		else
		{
			bDpLjeMyPqHfhoxioztCysiGRiy[sylUJNYrbqTKGcBZLNVoFAeINTI[P_3]].Add(item);
		}
		RScoukorUvRxOkhMnRJljFsNdTN();
	}

	public void SxRenVshBREfxhMTnKRbfUFvwoJi(Action<InputActionEventData> P_0, UpdateLoopType P_1, InputActionEventType P_2, object[] P_3)
	{
		if (!sQTBWTNxxjaWNFsekFBPFIwaffDK)
		{
			ijQPrfbohIDtyfCSvLMVhrlmSpB();
		}
		tyvyzfSnwwrFpRhUrlSzRAnqxqh item;
		try
		{
			item = new tyvyzfSnwwrFpRhUrlSzRAnqxqh(P_0, P_1, P_2, -1, P_3);
		}
		catch (Exception ex)
		{
			Logger.LogWarning("Failed to add Input Event delegate. Reason: " + ex.Message);
			return;
		}
		bDpLjeMyPqHfhoxioztCysiGRiy[YdkMlVuTsvlOvgdFkOjPpggkUuJ].Add(item);
		RScoukorUvRxOkhMnRJljFsNdTN();
	}

	public void vtEeJHlHmADXshapyyaNEbLgpF(Action<InputActionEventData> P_0)
	{
		if (!sQTBWTNxxjaWNFsekFBPFIwaffDK)
		{
			return;
		}
		AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh>[] array = bDpLjeMyPqHfhoxioztCysiGRiy;
		foreach (AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh> aList in array)
		{
			aList.RemoveAll((tyvyzfSnwwrFpRhUrlSzRAnqxqh P_0) => P_0.ntdQAYYKCISkDZMPhXhyiKDSvkD == P_0);
		}
		RScoukorUvRxOkhMnRJljFsNdTN();
	}

	public void vtEeJHlHmADXshapyyaNEbLgpF(Action<InputActionEventData> P_0, int P_1)
	{
		if (!sQTBWTNxxjaWNFsekFBPFIwaffDK || P_1 > ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.vsSdGwIcqfOhQEwPAxfsjlJAtjgH)
		{
			return;
		}
		AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh>[] array = bDpLjeMyPqHfhoxioztCysiGRiy;
		foreach (AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh> aList in array)
		{
			aList.RemoveAll((tyvyzfSnwwrFpRhUrlSzRAnqxqh P_0) => P_0.ntdQAYYKCISkDZMPhXhyiKDSvkD == P_0 && P_0.cJTdHcaeBzqfrLPRWYuoPWTszLhk == P_1);
		}
		RScoukorUvRxOkhMnRJljFsNdTN();
	}

	public void vtEeJHlHmADXshapyyaNEbLgpF(Action<InputActionEventData> P_0, UpdateLoopType P_1)
	{
		if (!sQTBWTNxxjaWNFsekFBPFIwaffDK)
		{
			return;
		}
		AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh>[] array = bDpLjeMyPqHfhoxioztCysiGRiy;
		foreach (AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh> aList in array)
		{
			aList.RemoveAll((tyvyzfSnwwrFpRhUrlSzRAnqxqh P_0) => P_0.ntdQAYYKCISkDZMPhXhyiKDSvkD == P_0 && P_0.EtMuBRTmVzCBLcuxYRMlwUqRdAzD == P_1);
		}
		RScoukorUvRxOkhMnRJljFsNdTN();
	}

	public void vtEeJHlHmADXshapyyaNEbLgpF(Action<InputActionEventData> P_0, InputActionEventType P_1)
	{
		if (!sQTBWTNxxjaWNFsekFBPFIwaffDK)
		{
			return;
		}
		AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh>[] array = bDpLjeMyPqHfhoxioztCysiGRiy;
		foreach (AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh> aList in array)
		{
			aList.RemoveAll((tyvyzfSnwwrFpRhUrlSzRAnqxqh P_0) => P_0.ntdQAYYKCISkDZMPhXhyiKDSvkD == P_0 && P_0.RmVIgwjghCUZjaaGXmxHxOUTlGu == P_1);
		}
		RScoukorUvRxOkhMnRJljFsNdTN();
	}

	public void vtEeJHlHmADXshapyyaNEbLgpF(Action<InputActionEventData> P_0, UpdateLoopType P_1, int P_2)
	{
		if (!sQTBWTNxxjaWNFsekFBPFIwaffDK || P_2 > ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.vsSdGwIcqfOhQEwPAxfsjlJAtjgH)
		{
			return;
		}
		AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh>[] array = bDpLjeMyPqHfhoxioztCysiGRiy;
		foreach (AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh> aList in array)
		{
			aList.RemoveAll((tyvyzfSnwwrFpRhUrlSzRAnqxqh P_0) => P_0.ntdQAYYKCISkDZMPhXhyiKDSvkD == P_0 && P_0.EtMuBRTmVzCBLcuxYRMlwUqRdAzD == P_1 && P_0.cJTdHcaeBzqfrLPRWYuoPWTszLhk == P_2);
		}
		RScoukorUvRxOkhMnRJljFsNdTN();
	}

	public void vtEeJHlHmADXshapyyaNEbLgpF(Action<InputActionEventData> P_0, UpdateLoopType P_1, InputActionEventType P_2, int P_3)
	{
		if (!sQTBWTNxxjaWNFsekFBPFIwaffDK || P_3 > ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.vsSdGwIcqfOhQEwPAxfsjlJAtjgH)
		{
			return;
		}
		AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh>[] array = bDpLjeMyPqHfhoxioztCysiGRiy;
		foreach (AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh> aList in array)
		{
			aList.RemoveAll((tyvyzfSnwwrFpRhUrlSzRAnqxqh P_0) => P_0.ntdQAYYKCISkDZMPhXhyiKDSvkD == P_0 && P_0.EtMuBRTmVzCBLcuxYRMlwUqRdAzD == P_1 && P_0.cJTdHcaeBzqfrLPRWYuoPWTszLhk == P_3 && P_0.RmVIgwjghCUZjaaGXmxHxOUTlGu == P_2);
		}
		RScoukorUvRxOkhMnRJljFsNdTN();
	}

	public void vtEeJHlHmADXshapyyaNEbLgpF(Action<InputActionEventData> P_0, UpdateLoopType P_1, InputActionEventType P_2)
	{
		if (!sQTBWTNxxjaWNFsekFBPFIwaffDK)
		{
			return;
		}
		AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh>[] array = bDpLjeMyPqHfhoxioztCysiGRiy;
		foreach (AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh> aList in array)
		{
			aList.RemoveAll((tyvyzfSnwwrFpRhUrlSzRAnqxqh P_0) => P_0.ntdQAYYKCISkDZMPhXhyiKDSvkD == P_0 && P_0.EtMuBRTmVzCBLcuxYRMlwUqRdAzD == P_1 && P_0.RmVIgwjghCUZjaaGXmxHxOUTlGu == P_2);
		}
		RScoukorUvRxOkhMnRJljFsNdTN();
	}

	public void vtEeJHlHmADXshapyyaNEbLgpF(Action<InputActionEventData> P_0, InputActionEventType P_1, int P_2)
	{
		if (!sQTBWTNxxjaWNFsekFBPFIwaffDK || P_2 > ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.vsSdGwIcqfOhQEwPAxfsjlJAtjgH)
		{
			return;
		}
		AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh>[] array = bDpLjeMyPqHfhoxioztCysiGRiy;
		foreach (AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh> aList in array)
		{
			aList.RemoveAll((tyvyzfSnwwrFpRhUrlSzRAnqxqh P_0) => P_0.ntdQAYYKCISkDZMPhXhyiKDSvkD == P_0 && P_0.cJTdHcaeBzqfrLPRWYuoPWTszLhk == P_2 && P_0.RmVIgwjghCUZjaaGXmxHxOUTlGu == P_1);
		}
		RScoukorUvRxOkhMnRJljFsNdTN();
	}

	public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
	{
		if (sQTBWTNxxjaWNFsekFBPFIwaffDK)
		{
			AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh>[] array = bDpLjeMyPqHfhoxioztCysiGRiy;
			foreach (AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh> aList in array)
			{
				aList.Clear();
			}
			RScoukorUvRxOkhMnRJljFsNdTN();
		}
	}

	private void RScoukorUvRxOkhMnRJljFsNdTN()
	{
		int num = 0;
		for (int i = 0; i < bDpLjeMyPqHfhoxioztCysiGRiy.Length; i++)
		{
			num += bDpLjeMyPqHfhoxioztCysiGRiy[i]._count;
		}
		ISdYIoHLHpRQaxTRDfBvRqXUAbU = num;
	}

	[CompilerGenerated]
	private static AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh> lnzuOmlGTwKpvONdsYXMyqmMvVv()
	{
		return new AList<tyvyzfSnwwrFpRhUrlSzRAnqxqh>();
	}
}
