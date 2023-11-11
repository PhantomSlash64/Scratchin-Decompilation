using System;
using System.Collections.Generic;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.UI;

internal class btMacetbbUufnQlkwuoHEIUZUaP
{
	[Flags]
	public enum cPqezULHQXJKixCrlGZWkJDPxxn
	{
		fUyeeVFhkdEderlnmYYFoAwmZEL = 0,
		BHfTRXTrjZGLuAZypWqahpfSYuB = 1,
		bAHCoppFcbVUVUHFRZFzvQzTYCM = 2
	}

	private class TjNIeiYytiSmrSbdIxhawVrFdWJ
	{
		public bool OikpsSWFJzDVtprgBDrCmXWDjle;

		public bool ZJjKcQcRusgjGMHBJHPXsKzvZwf;

		public bool NlnTmrvhHpHiSOQEwxLshwBrGWy;
	}

	private Dictionary<int, TjNIeiYytiSmrSbdIxhawVrFdWJ> WtptYyxYJqmgjVPGBGiPNRrNFcA;

	public cPqezULHQXJKixCrlGZWkJDPxxn zbbHhMeJoTqqmpumtHNylRPHNJrH;

	private bool SUieynyjoelHWxONjYlBAYlrJqa => UnityTools.supportsUnityUIGraphicRaycastTarget;

	public btMacetbbUufnQlkwuoHEIUZUaP()
		: this(cPqezULHQXJKixCrlGZWkJDPxxn.BHfTRXTrjZGLuAZypWqahpfSYuB | cPqezULHQXJKixCrlGZWkJDPxxn.bAHCoppFcbVUVUHFRZFzvQzTYCM)
	{
	}

	public btMacetbbUufnQlkwuoHEIUZUaP(cPqezULHQXJKixCrlGZWkJDPxxn targets)
	{
		zbbHhMeJoTqqmpumtHNylRPHNJrH = targets;
		WtptYyxYJqmgjVPGBGiPNRrNFcA = new Dictionary<int, TjNIeiYytiSmrSbdIxhawVrFdWJ>();
	}

	public void vpXZlWYkCIxIaoVUFqhUjPYIuhq(Transform P_0, bool P_1)
	{
		if (!SUieynyjoelHWxONjYlBAYlrJqa)
		{
			return;
		}
		if ((zbbHhMeJoTqqmpumtHNylRPHNJrH & cPqezULHQXJKixCrlGZWkJDPxxn.BHfTRXTrjZGLuAZypWqahpfSYuB) != 0)
		{
			if ((zbbHhMeJoTqqmpumtHNylRPHNJrH & cPqezULHQXJKixCrlGZWkJDPxxn.bAHCoppFcbVUVUHFRZFzvQzTYCM) != 0)
			{
				VrxyvSRMLheLLGJYXfLWHwcEuvJT(P_0, P_1, WtptYyxYJqmgjVPGBGiPNRrNFcA);
			}
			else
			{
				vpXZlWYkCIxIaoVUFqhUjPYIuhq(P_0, P_1, WtptYyxYJqmgjVPGBGiPNRrNFcA);
			}
		}
		else if ((zbbHhMeJoTqqmpumtHNylRPHNJrH & cPqezULHQXJKixCrlGZWkJDPxxn.bAHCoppFcbVUVUHFRZFzvQzTYCM) != 0)
		{
			LpJtXoWuFYfcVcBofotYHOowOiv(P_0, P_1, WtptYyxYJqmgjVPGBGiPNRrNFcA);
		}
	}

	public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
	{
		if (SUieynyjoelHWxONjYlBAYlrJqa)
		{
			WtptYyxYJqmgjVPGBGiPNRrNFcA.Clear();
		}
	}

	private static void VrxyvSRMLheLLGJYXfLWHwcEuvJT(Transform P_0, bool P_1, Dictionary<int, TjNIeiYytiSmrSbdIxhawVrFdWJ> P_2)
	{
		if (!(P_0 == null))
		{
			vpXZlWYkCIxIaoVUFqhUjPYIuhq(P_0, P_1, P_2);
			LpJtXoWuFYfcVcBofotYHOowOiv(P_0, P_1, P_2);
		}
	}

	private static void LpJtXoWuFYfcVcBofotYHOowOiv(Transform P_0, bool P_1, Dictionary<int, TjNIeiYytiSmrSbdIxhawVrFdWJ> P_2)
	{
		if (!(P_0 == null))
		{
			int childCount = P_0.childCount;
			for (int i = 0; i < childCount; i++)
			{
				VrxyvSRMLheLLGJYXfLWHwcEuvJT(P_0.GetChild(i), P_1, P_2);
			}
		}
	}

	private static void vpXZlWYkCIxIaoVUFqhUjPYIuhq(Transform P_0, bool P_1, Dictionary<int, TjNIeiYytiSmrSbdIxhawVrFdWJ> P_2)
	{
		if (P_0 == null)
		{
			return;
		}
		Graphic component = P_0.GetComponent<Graphic>();
		if (component == null)
		{
			return;
		}
		bool flag = UnityTools.externalTools.UnityUI_Graphic_GetRaycastTarget(component);
		int instanceID = component.GetInstanceID();
		if (!P_2.TryGetValue(instanceID, out var value))
		{
			if (!flag)
			{
				return;
			}
			value = new TjNIeiYytiSmrSbdIxhawVrFdWJ();
			value.OikpsSWFJzDVtprgBDrCmXWDjle = flag;
			P_2.Add(instanceID, value);
		}
		if ((value.ZJjKcQcRusgjGMHBJHPXsKzvZwf && flag == value.OikpsSWFJzDVtprgBDrCmXWDjle) || (!value.ZJjKcQcRusgjGMHBJHPXsKzvZwf && flag != value.OikpsSWFJzDVtprgBDrCmXWDjle))
		{
			value.ZJjKcQcRusgjGMHBJHPXsKzvZwf = false;
			value.NlnTmrvhHpHiSOQEwxLshwBrGWy = false;
			value.OikpsSWFJzDVtprgBDrCmXWDjle = flag;
			if (!flag)
			{
				P_2.Remove(instanceID);
				return;
			}
		}
		if (P_1 != flag && value.OikpsSWFJzDVtprgBDrCmXWDjle)
		{
			if (value.OikpsSWFJzDVtprgBDrCmXWDjle == P_1)
			{
				value.ZJjKcQcRusgjGMHBJHPXsKzvZwf = false;
				value.NlnTmrvhHpHiSOQEwxLshwBrGWy = false;
			}
			else
			{
				value.ZJjKcQcRusgjGMHBJHPXsKzvZwf = true;
				value.NlnTmrvhHpHiSOQEwxLshwBrGWy = P_1;
			}
			UnityTools.externalTools.UnityUI_Graphic_SetRaycastTarget(component, P_1);
		}
	}
}
