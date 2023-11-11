using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Text;

internal static class KRrImRonJnIBgiADaoeicVHBVcwg
{
	private static Dictionary<IntPtr, List<DSYkfxCJvReEbuXJjlEMTSbkFy>> MsDIBUlwCDAYesOmTpxMSMcznTH;

	[ThreadStatic]
	private static Dictionary<IntPtr, List<DSYkfxCJvReEbuXJjlEMTSbkFy>> jZIzqihLvQoZYsMttHIDSYTwPmj;

	private static Dictionary<IntPtr, List<DSYkfxCJvReEbuXJjlEMTSbkFy>> lDoWTyCHLbpAtxbeObMBAfSpTUn
	{
		get
		{
			if (QavFRvcFVaxmGgVToPhqGGvLhVw.GaLPPuJdFKdnAIlyEwXinpEKAUt)
			{
				if (jZIzqihLvQoZYsMttHIDSYTwPmj == null)
				{
					jZIzqihLvQoZYsMttHIDSYTwPmj = new Dictionary<IntPtr, List<DSYkfxCJvReEbuXJjlEMTSbkFy>>(lkZOpgvEDfXDFpyrfVbufPNrzAQ.WnEJoQipmxDcfoHCTHELOLyWybE);
				}
				return jZIzqihLvQoZYsMttHIDSYTwPmj;
			}
			if (MsDIBUlwCDAYesOmTpxMSMcznTH == null)
			{
				MsDIBUlwCDAYesOmTpxMSMcznTH = new Dictionary<IntPtr, List<DSYkfxCJvReEbuXJjlEMTSbkFy>>(lkZOpgvEDfXDFpyrfVbufPNrzAQ.WnEJoQipmxDcfoHCTHELOLyWybE);
			}
			return MsDIBUlwCDAYesOmTpxMSMcznTH;
		}
	}

	public static event EventHandler<lSGiXokKSMqkIxzXegJVtmzApRx> BSsHvrkFHBeRxGFTlJxIkryfYwcU;

	public static event EventHandler<lSGiXokKSMqkIxzXegJVtmzApRx> EzFkiGjnnSQJMzDLLPePLcATGTP;

	static KRrImRonJnIBgiADaoeicVHBVcwg()
	{
		AppDomain.CurrentDomain.DomainUnload += eDaupsbkKNspigBDgaRADdWeoikb;
		AppDomain.CurrentDomain.ProcessExit += eDaupsbkKNspigBDgaRADdWeoikb;
	}

	private static void eDaupsbkKNspigBDgaRADdWeoikb(object P_0, EventArgs P_1)
	{
		if (QavFRvcFVaxmGgVToPhqGGvLhVw.QLrPPnfcFBNfEORTULEyYeVdqfn)
		{
			string value = EoggxAfDsYnLGOtzZKiXrSpRzPrs();
			if (!string.IsNullOrEmpty(value))
			{
				Console.WriteLine(value);
			}
		}
	}

	public static void WEhYSDdNJLcDaCFHDkGCstkUsAG(qFZgaejGInJCCmTgEqQEEiVAcXBC P_0)
	{
		if (P_0 == null || P_0.qNCdusATkxKqHGKMOPeqBcgaeFqZ == IntPtr.Zero)
		{
			return;
		}
		lock (lDoWTyCHLbpAtxbeObMBAfSpTUn)
		{
			if (!lDoWTyCHLbpAtxbeObMBAfSpTUn.TryGetValue(P_0.qNCdusATkxKqHGKMOPeqBcgaeFqZ, out var value))
			{
				value = new List<DSYkfxCJvReEbuXJjlEMTSbkFy>();
				lDoWTyCHLbpAtxbeObMBAfSpTUn.Add(P_0.qNCdusATkxKqHGKMOPeqBcgaeFqZ, value);
			}
			StringBuilder stringBuilder = new StringBuilder();
			StackTrace stackTrace = new StackTrace(3, fNeedFileInfo: true);
			StackFrame[] frames = stackTrace.GetFrames();
			foreach (StackFrame stackFrame in frames)
			{
				if (stackFrame.GetFileLineNumber() != 0)
				{
					stringBuilder.AppendFormat(CultureInfo.InvariantCulture, "\t{0}({1},{2}) : {3}", stackFrame.GetFileName(), stackFrame.GetFileLineNumber(), stackFrame.GetFileColumnNumber(), stackFrame.GetMethod()).AppendLine();
				}
			}
			value.Add(new DSYkfxCJvReEbuXJjlEMTSbkFy(DateTime.Now, P_0, stringBuilder.ToString()));
			PgFmbJyeRypasznORcrKJlKULkV(P_0);
		}
	}

	public static List<DSYkfxCJvReEbuXJjlEMTSbkFy> STpqmXEZECgfkLPDXPwNnDRIEiMG(IntPtr P_0)
	{
		lock (lDoWTyCHLbpAtxbeObMBAfSpTUn)
		{
			if (lDoWTyCHLbpAtxbeObMBAfSpTUn.TryGetValue(P_0, out var value))
			{
				return new List<DSYkfxCJvReEbuXJjlEMTSbkFy>(value);
			}
		}
		return new List<DSYkfxCJvReEbuXJjlEMTSbkFy>();
	}

	public static DSYkfxCJvReEbuXJjlEMTSbkFy STpqmXEZECgfkLPDXPwNnDRIEiMG(qFZgaejGInJCCmTgEqQEEiVAcXBC P_0)
	{
		lock (lDoWTyCHLbpAtxbeObMBAfSpTUn)
		{
			if (lDoWTyCHLbpAtxbeObMBAfSpTUn.TryGetValue(P_0.qNCdusATkxKqHGKMOPeqBcgaeFqZ, out var value))
			{
				foreach (DSYkfxCJvReEbuXJjlEMTSbkFy item in value)
				{
					if (object.ReferenceEquals(item.HfgXrOplmvlvTLqdbZmywVQWyzL.Target, P_0))
					{
						return item;
					}
				}
			}
		}
		return null;
	}

	public static void BATPKAaUOYjBAXLHIUmXCVxwpBc(qFZgaejGInJCCmTgEqQEEiVAcXBC P_0)
	{
		if (P_0 == null || P_0.qNCdusATkxKqHGKMOPeqBcgaeFqZ == IntPtr.Zero)
		{
			return;
		}
		lock (lDoWTyCHLbpAtxbeObMBAfSpTUn)
		{
			if (!lDoWTyCHLbpAtxbeObMBAfSpTUn.TryGetValue(P_0.qNCdusATkxKqHGKMOPeqBcgaeFqZ, out var value))
			{
				return;
			}
			for (int num = value.Count - 1; num >= 0; num--)
			{
				DSYkfxCJvReEbuXJjlEMTSbkFy dSYkfxCJvReEbuXJjlEMTSbkFy = value[num];
				if (object.ReferenceEquals(dSYkfxCJvReEbuXJjlEMTSbkFy.HfgXrOplmvlvTLqdbZmywVQWyzL.Target, P_0))
				{
					value.RemoveAt(num);
				}
				else if (!dSYkfxCJvReEbuXJjlEMTSbkFy.TZxesclPaPyfIKONVQTgVkeUTJJ)
				{
					value.RemoveAt(num);
				}
			}
			if (value.Count == 0)
			{
				lDoWTyCHLbpAtxbeObMBAfSpTUn.Remove(P_0.qNCdusATkxKqHGKMOPeqBcgaeFqZ);
			}
			PiuPykrhqKDHjpUdnWhNfnbOWBF(P_0);
		}
	}

	public static List<DSYkfxCJvReEbuXJjlEMTSbkFy> VvkebVENWljsiAxUIQKHTaqeCylL()
	{
		List<DSYkfxCJvReEbuXJjlEMTSbkFy> list = new List<DSYkfxCJvReEbuXJjlEMTSbkFy>();
		lock (lDoWTyCHLbpAtxbeObMBAfSpTUn)
		{
			foreach (List<DSYkfxCJvReEbuXJjlEMTSbkFy> value in lDoWTyCHLbpAtxbeObMBAfSpTUn.Values)
			{
				foreach (DSYkfxCJvReEbuXJjlEMTSbkFy item in value)
				{
					if (item.TZxesclPaPyfIKONVQTgVkeUTJJ)
					{
						list.Add(item);
					}
				}
			}
			return list;
		}
	}

	public static string EoggxAfDsYnLGOtzZKiXrSpRzPrs()
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		Dictionary<string, int> dictionary = new Dictionary<string, int>();
		foreach (DSYkfxCJvReEbuXJjlEMTSbkFy item in VvkebVENWljsiAxUIQKHTaqeCylL())
		{
			string text = item.ToString();
			if (!string.IsNullOrEmpty(text))
			{
				stringBuilder.AppendFormat("[{0}]: {1}", num, text);
				object target = item.HfgXrOplmvlvTLqdbZmywVQWyzL.Target;
				if (target != null)
				{
					string name = target.GetType().Name;
					if (!dictionary.TryGetValue(name, out var value))
					{
						dictionary[name] = 0;
					}
					dictionary[name] = value + 1;
				}
			}
			num++;
		}
		List<string> list = new List<string>(dictionary.Keys);
		list.Sort();
		stringBuilder.AppendLine();
		stringBuilder.AppendLine("Count per Type:");
		foreach (string item2 in list)
		{
			stringBuilder.AppendFormat("{0} : {1}", item2, dictionary[item2]);
			stringBuilder.AppendLine();
		}
		return stringBuilder.ToString();
	}

	private static void PgFmbJyeRypasznORcrKJlKULkV(qFZgaejGInJCCmTgEqQEEiVAcXBC P_0)
	{
		KRrImRonJnIBgiADaoeicVHBVcwg.BSsHvrkFHBeRxGFTlJxIkryfYwcU?.Invoke(null, new lSGiXokKSMqkIxzXegJVtmzApRx(P_0));
	}

	private static void PiuPykrhqKDHjpUdnWhNfnbOWBF(qFZgaejGInJCCmTgEqQEEiVAcXBC P_0)
	{
		KRrImRonJnIBgiADaoeicVHBVcwg.EzFkiGjnnSQJMzDLLPePLcATGTP?.Invoke(null, new lSGiXokKSMqkIxzXegJVtmzApRx(P_0));
	}
}
