using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired.ControllerExtensions;
using Rewired.Interfaces;
using Rewired.Utils;
using UnityEngine;

internal class soeQCwsPFXcazbxluoLmAPPtcouD : ISteamControllerInternal
{
	private static Dictionary<string, ulong> JrklOIJegwQXurVVFKHlxPVxoWe;

	private static Dictionary<string, ulong> WqGivGkGSnacCmaXvGLUznLOfTH;

	private static Dictionary<string, ulong> nkruQtfUiCItofrRVkiwBtAbxOA;

	private static Dictionary<ulong, string> BBgNMkDDPLUYtLcPIUvxJMCHLeM;

	private static Dictionary<ulong, string> CrUEBXufsmnbjPuRLBrUSPdRJCL;

	private static Dictionary<ulong, string> pNAcpUBdWbBrVSwbpXHrkoelLTYZ;

	public readonly ulong MuBtsDburIuclBwCxoOiaWPnkKr;

	private yJQKsnzzJLvURHKNUvhdxNITVux[] nzyDLmjEPOXLXHTGthmCziWYcanp;

	private List<SteamControllerActionOrigin> kjRomHEpCGaWwXRjgBrEcMTDROm;

	private ReadOnlyCollection<SteamControllerActionOrigin> FhPONMTZCUbawyKQgbPLeHlcsVXu;

	public int MaxActionSourceCount => 8;

	public bool IsConnected => dPUMtxLhWgMhyWtqVfzzecldFeR.tGQnKdmzFYAfhXdRJgdyiDeTTax(MuBtsDburIuclBwCxoOiaWPnkKr);

	public static void OdsVQSQAvqXteSpyYKkpULcmOed(Dictionary<string, ulong> P_0)
	{
		if (P_0 != null && P_0.Count != 0)
		{
			JrklOIJegwQXurVVFKHlxPVxoWe = P_0;
			BBgNMkDDPLUYtLcPIUvxJMCHLeM = CollectionTools.CreateInverseDictionary(P_0);
		}
	}

	public static void lfZaaEatfgdQKRipBnjDqTXbavp(Dictionary<string, ulong> P_0)
	{
		if (P_0 != null && P_0.Count != 0)
		{
			WqGivGkGSnacCmaXvGLUznLOfTH = P_0;
			CrUEBXufsmnbjPuRLBrUSPdRJCL = CollectionTools.CreateInverseDictionary(P_0);
		}
	}

	public static void JStCXLPQsXpgNzGvbCoacHFvOdkW(Dictionary<string, ulong> P_0)
	{
		if (P_0 != null && P_0.Count != 0)
		{
			nkruQtfUiCItofrRVkiwBtAbxOA = P_0;
			pNAcpUBdWbBrVSwbpXHrkoelLTYZ = CollectionTools.CreateInverseDictionary(P_0);
		}
	}

	public soeQCwsPFXcazbxluoLmAPPtcouD(ulong handle)
	{
		MuBtsDburIuclBwCxoOiaWPnkKr = handle;
		nzyDLmjEPOXLXHTGthmCziWYcanp = new yJQKsnzzJLvURHKNUvhdxNITVux[8];
		kjRomHEpCGaWwXRjgBrEcMTDROm = new List<SteamControllerActionOrigin>(8);
		FhPONMTZCUbawyKQgbPLeHlcsVXu = new ReadOnlyCollection<SteamControllerActionOrigin>(kjRomHEpCGaWwXRjgBrEcMTDROm);
	}

	public string GetActionSetName(ulong handle)
	{
		return TLdINgSyVpKrkqfxcczDceMeJbh(BBgNMkDDPLUYtLcPIUvxJMCHLeM, handle);
	}

	public string GetDigitalActionName(ulong handle)
	{
		return TLdINgSyVpKrkqfxcczDceMeJbh(pNAcpUBdWbBrVSwbpXHrkoelLTYZ, handle);
	}

	public string GetAnalogActionName(ulong handle)
	{
		return TLdINgSyVpKrkqfxcczDceMeJbh(CrUEBXufsmnbjPuRLBrUSPdRJCL, handle);
	}

	public ulong GetActionSetHandle(ref string actionSetName)
	{
		return lBSFZrRpcVlgUCoVjnhwZMBasRR(JrklOIJegwQXurVVFKHlxPVxoWe, ref actionSetName);
	}

	public ulong GetDigitalActionHandle(ref string actionName)
	{
		return lBSFZrRpcVlgUCoVjnhwZMBasRR(nkruQtfUiCItofrRVkiwBtAbxOA, ref actionName);
	}

	public ulong GetAnalogActionHandle(ref string actionName)
	{
		return lBSFZrRpcVlgUCoVjnhwZMBasRR(WqGivGkGSnacCmaXvGLUznLOfTH, ref actionName);
	}

	public Vector2 GetAnalogActionValue(ulong actionHandle)
	{
		if (actionHandle == 0)
		{
			return default(Vector2);
		}
		try
		{
			rWIcZZxwpokbuXXxBlWcAQWpmLy rWIcZZxwpokbuXXxBlWcAQWpmLy2 = dPUMtxLhWgMhyWtqVfzzecldFeR.FoiIpQjbHtRCxMwMrawLFpXLMKn.vWmgwfrggkVNwPNpMFnEOwtuIGO(MuBtsDburIuclBwCxoOiaWPnkKr, actionHandle);
			if (!rWIcZZxwpokbuXXxBlWcAQWpmLy2.uUjbLbsyWNBZRUdZVHXgZzenrBJ)
			{
				return default(Vector2);
			}
			return new Vector2(rWIcZZxwpokbuXXxBlWcAQWpmLy2.fdcCcwdHpvxPYBpcdbZdtoGFAzzB, rWIcZZxwpokbuXXxBlWcAQWpmLy2.ZVnCDqHFiPtAfFwySHfFJzLdSYpt);
		}
		catch
		{
			return default(Vector2);
		}
	}

	public Vector2 GetAnalogActionValue(ref string actionName)
	{
		ulong analogActionHandle = GetAnalogActionHandle(ref actionName);
		return GetAnalogActionValue(analogActionHandle);
	}

	public bool GetDigitalActionValue(ulong actionHandle)
	{
		if (actionHandle == 0)
		{
			return false;
		}
		try
		{
			MKzyVKbndTufEcrwxcKkkOyVMhlX mKzyVKbndTufEcrwxcKkkOyVMhlX = dPUMtxLhWgMhyWtqVfzzecldFeR.FoiIpQjbHtRCxMwMrawLFpXLMKn.RNDctqwLQVdhnoLlVgTyBEeqMkYp(MuBtsDburIuclBwCxoOiaWPnkKr, actionHandle);
			Debug.Log(actionHandle + " state = " + mKzyVKbndTufEcrwxcKkkOyVMhlX.QLKZPhgXqlKZKmiesRsCxcFQXTK + " active = " + mKzyVKbndTufEcrwxcKkkOyVMhlX.uUjbLbsyWNBZRUdZVHXgZzenrBJ);
			return mKzyVKbndTufEcrwxcKkkOyVMhlX.uUjbLbsyWNBZRUdZVHXgZzenrBJ && mKzyVKbndTufEcrwxcKkkOyVMhlX.QLKZPhgXqlKZKmiesRsCxcFQXTK;
		}
		catch
		{
			return false;
		}
	}

	public bool GetDigitalActionValue(ref string actionName)
	{
		ulong digitalActionHandle = GetDigitalActionHandle(ref actionName);
		return GetDigitalActionValue(digitalActionHandle);
	}

	public bool SetActiveActionSet(ulong actionSetHandle)
	{
		if (actionSetHandle == 0)
		{
			return false;
		}
		try
		{
			dPUMtxLhWgMhyWtqVfzzecldFeR.FoiIpQjbHtRCxMwMrawLFpXLMKn.YmRWpGXOOWFqLwdPxHIvJywDszh(MuBtsDburIuclBwCxoOiaWPnkKr, actionSetHandle);
			return true;
		}
		catch
		{
			return false;
		}
	}

	public bool SetActiveActionSet(ref string actionSetName)
	{
		ulong actionSetHandle = GetActionSetHandle(ref actionSetName);
		return SetActiveActionSet(actionSetHandle);
	}

	public ulong GetActiveActionSetHandle()
	{
		return dPUMtxLhWgMhyWtqVfzzecldFeR.FoiIpQjbHtRCxMwMrawLFpXLMKn.vFrEBSwKBhNTaXGsaRGjsNybHHh(MuBtsDburIuclBwCxoOiaWPnkKr);
	}

	public string GetActiveActionSetName()
	{
		return TLdINgSyVpKrkqfxcczDceMeJbh(BBgNMkDDPLUYtLcPIUvxJMCHLeM, dPUMtxLhWgMhyWtqVfzzecldFeR.FoiIpQjbHtRCxMwMrawLFpXLMKn.vFrEBSwKBhNTaXGsaRGjsNybHHh(MuBtsDburIuclBwCxoOiaWPnkKr));
	}

	public void ShowBindingPanel()
	{
		dPUMtxLhWgMhyWtqVfzzecldFeR.FoiIpQjbHtRCxMwMrawLFpXLMKn.nuvAjTvJTwAjWkmYvkhgfeXujuy(MuBtsDburIuclBwCxoOiaWPnkKr);
	}

	public void SetHapticPulse(SteamControllerPadType triggerPad, float durationSeconds)
	{
		if (durationSeconds < 0f)
		{
			durationSeconds = 0f;
		}
		dPUMtxLhWgMhyWtqVfzzecldFeR.FoiIpQjbHtRCxMwMrawLFpXLMKn.aefgLficRpjTJfriRXBqjqzEkOA(MuBtsDburIuclBwCxoOiaWPnkKr, (uint)triggerPad, (ushort)(durationSeconds * 1000000f));
	}

	public void SetHapticPulse(SteamControllerPadType triggerPad, ushort durationMicroSeconds)
	{
		dPUMtxLhWgMhyWtqVfzzecldFeR.FoiIpQjbHtRCxMwMrawLFpXLMKn.aefgLficRpjTJfriRXBqjqzEkOA(MuBtsDburIuclBwCxoOiaWPnkKr, (uint)triggerPad, durationMicroSeconds);
	}

	public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ref string actionSetName, ref string actionName)
	{
		return GetDigitalActionOrigins(lBSFZrRpcVlgUCoVjnhwZMBasRR(JrklOIJegwQXurVVFKHlxPVxoWe, ref actionSetName), lBSFZrRpcVlgUCoVjnhwZMBasRR(nkruQtfUiCItofrRVkiwBtAbxOA, ref actionName));
	}

	public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ulong actionSetHandle, ulong actionHandle)
	{
		kjRomHEpCGaWwXRjgBrEcMTDROm.Clear();
		if (actionSetHandle == 0 || actionHandle == 0)
		{
			return FhPONMTZCUbawyKQgbPLeHlcsVXu;
		}
		int num = dPUMtxLhWgMhyWtqVfzzecldFeR.FoiIpQjbHtRCxMwMrawLFpXLMKn.OJozOUhHfCGsnHoTJJSAdEBhxckE(MuBtsDburIuclBwCxoOiaWPnkKr, actionSetHandle, actionHandle, nzyDLmjEPOXLXHTGthmCziWYcanp);
		for (int i = 0; i < num; i++)
		{
			kjRomHEpCGaWwXRjgBrEcMTDROm.Add((SteamControllerActionOrigin)nzyDLmjEPOXLXHTGthmCziWYcanp[i]);
		}
		return FhPONMTZCUbawyKQgbPLeHlcsVXu;
	}

	public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ref string actionSetName, ref string actionName)
	{
		return GetAnalogActionOrigins(lBSFZrRpcVlgUCoVjnhwZMBasRR(JrklOIJegwQXurVVFKHlxPVxoWe, ref actionSetName), lBSFZrRpcVlgUCoVjnhwZMBasRR(WqGivGkGSnacCmaXvGLUznLOfTH, ref actionName));
	}

	public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ulong actionSetHandle, ulong actionHandle)
	{
		kjRomHEpCGaWwXRjgBrEcMTDROm.Clear();
		if (actionSetHandle == 0 || actionHandle == 0)
		{
			return FhPONMTZCUbawyKQgbPLeHlcsVXu;
		}
		int num = dPUMtxLhWgMhyWtqVfzzecldFeR.FoiIpQjbHtRCxMwMrawLFpXLMKn.AaOdqsdSXOMfNRpJZsngdSspGsr(MuBtsDburIuclBwCxoOiaWPnkKr, actionSetHandle, actionHandle, nzyDLmjEPOXLXHTGthmCziWYcanp);
		for (int i = 0; i < num; i++)
		{
			kjRomHEpCGaWwXRjgBrEcMTDROm.Add((SteamControllerActionOrigin)nzyDLmjEPOXLXHTGthmCziWYcanp[i]);
		}
		return FhPONMTZCUbawyKQgbPLeHlcsVXu;
	}

	private ulong lBSFZrRpcVlgUCoVjnhwZMBasRR(Dictionary<string, ulong> P_0, ref string P_1)
	{
		if (P_0 == null || string.IsNullOrEmpty(P_1))
		{
			return 0uL;
		}
		if (!P_0.TryGetValue(P_1, out var value))
		{
			return 0uL;
		}
		return value;
	}

	private string TLdINgSyVpKrkqfxcczDceMeJbh(Dictionary<ulong, string> P_0, ulong P_1)
	{
		if (P_0 == null || P_1 == 0)
		{
			return string.Empty;
		}
		if (!P_0.TryGetValue(P_1, out var value))
		{
			return string.Empty;
		}
		return value;
	}
}
