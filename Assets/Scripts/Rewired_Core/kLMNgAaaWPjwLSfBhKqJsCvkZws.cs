using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired;
using Rewired.Utils.Classes.Data;

internal class kLMNgAaaWPjwLSfBhKqJsCvkZws
{
	private class HvDLRMlHGRDhutMWIKnofSvcwuX
	{
		public readonly InputAction nyxXdFxRTzDGvlsLDbXZfxZmGjf;

		public readonly int BlZsUkOGPQDnwzRAzcAFtbBWDaNH;

		public readonly int rwgadCCtosdpSxOWMOPfZKMDoRc;

		public HvDLRMlHGRDhutMWIKnofSvcwuX(InputAction action, int arrayIndex)
		{
			nyxXdFxRTzDGvlsLDbXZfxZmGjf = action;
			BlZsUkOGPQDnwzRAzcAFtbBWDaNH = action.id;
			rwgadCCtosdpSxOWMOPfZKMDoRc = arrayIndex;
		}
	}

	private InputAction[] dUuXTQcSllqTHMjPkcKnpLWchaib;

	private ADictionary<string, HvDLRMlHGRDhutMWIKnofSvcwuX> QIQDEYhznWjPIDsXSpPzmEqigLz;

	private HvDLRMlHGRDhutMWIKnofSvcwuX[] GmXZBAZlMqXzZCHHACmsSHAzzaA;

	private ReadOnlyCollection<InputAction> QZuNxNpKTtkVdemLUzwkLXNOTqc;

	private int auMEYQyRrbGWTAeVHHjsiOtEbzCD;

	private int OuQVDAINktbEevsWKGMKFXhcuCr;

	private List<string> uSryDOgWmNaPoPxhKGlJoosxgrh;

	private List<int> hiUrXMxRJSvnKmiShAhZchSaNqh;

	public IList<InputAction> yZSrNHqZKswEViXPXSJxQuBsxwA => QZuNxNpKTtkVdemLUzwkLXNOTqc;

	public int rwHTLHmPeQUKdXrAUDBtBNrghsN => auMEYQyRrbGWTAeVHHjsiOtEbzCD;

	public int vsSdGwIcqfOhQEwPAxfsjlJAtjgH => OuQVDAINktbEevsWKGMKFXhcuCr;

	public kLMNgAaaWPjwLSfBhKqJsCvkZws(List<InputAction> actions)
	{
		uSryDOgWmNaPoPxhKGlJoosxgrh = new List<string>();
		hiUrXMxRJSvnKmiShAhZchSaNqh = new List<int>();
		dUuXTQcSllqTHMjPkcKnpLWchaib = actions.ToArray();
		auMEYQyRrbGWTAeVHHjsiOtEbzCD = dUuXTQcSllqTHMjPkcKnpLWchaib.Length;
		int num = -1;
		for (int i = 0; i < auMEYQyRrbGWTAeVHHjsiOtEbzCD; i++)
		{
			int id = dUuXTQcSllqTHMjPkcKnpLWchaib[i].id;
			if (id > num)
			{
				num = id;
			}
		}
		OuQVDAINktbEevsWKGMKFXhcuCr = num;
		GmXZBAZlMqXzZCHHACmsSHAzzaA = new HvDLRMlHGRDhutMWIKnofSvcwuX[num + 1];
		for (int j = 0; j < auMEYQyRrbGWTAeVHHjsiOtEbzCD; j++)
		{
			InputAction inputAction = dUuXTQcSllqTHMjPkcKnpLWchaib[j];
			GmXZBAZlMqXzZCHHACmsSHAzzaA[inputAction.id] = new HvDLRMlHGRDhutMWIKnofSvcwuX(inputAction, j);
		}
		QIQDEYhznWjPIDsXSpPzmEqigLz = new ADictionary<string, HvDLRMlHGRDhutMWIKnofSvcwuX>(auMEYQyRrbGWTAeVHHjsiOtEbzCD, StringComparer.OrdinalIgnoreCase);
		for (int k = 0; k < auMEYQyRrbGWTAeVHHjsiOtEbzCD; k++)
		{
			InputAction inputAction2 = dUuXTQcSllqTHMjPkcKnpLWchaib[k];
			try
			{
				QIQDEYhznWjPIDsXSpPzmEqigLz.Add(inputAction2.name, GmXZBAZlMqXzZCHHACmsSHAzzaA[inputAction2.id]);
			}
			catch
			{
				Logger.LogError("Duplicate Action name \"" + inputAction2.name + "\" found in Action list. Duplicate Action names are not allowed. If you have edited the data manually outside the Rewired Input Manager, remove any duplicate Actions.");
			}
		}
		QZuNxNpKTtkVdemLUzwkLXNOTqc = new ReadOnlyCollection<InputAction>(dUuXTQcSllqTHMjPkcKnpLWchaib);
	}

	public InputAction nYlDpDffCkjRccBgMgyGeVRBCsz(string P_0, bool P_1 = false)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return null;
		}
		if (!QIQDEYhznWjPIDsXSpPzmEqigLz.TryGetValue(P_0, out var value))
		{
			if (P_1)
			{
				tZpPsboIuMYOSvIojcnXgggZPNnx(P_0);
			}
			return null;
		}
		return value.nyxXdFxRTzDGvlsLDbXZfxZmGjf;
	}

	public InputAction RqJdcHsAxUbtTwkILZedHAbEBKb(int P_0)
	{
		if (P_0 < 0)
		{
			return null;
		}
		if (P_0 > OuQVDAINktbEevsWKGMKFXhcuCr)
		{
			return null;
		}
		if (GmXZBAZlMqXzZCHHACmsSHAzzaA[P_0] == null)
		{
			return null;
		}
		return GmXZBAZlMqXzZCHHACmsSHAzzaA[P_0].nyxXdFxRTzDGvlsLDbXZfxZmGjf;
	}

	public InputAction bzJqLVraxTcTEuuzzdFzDFqpCeUB(int P_0)
	{
		if (P_0 < 0 || P_0 >= auMEYQyRrbGWTAeVHHjsiOtEbzCD)
		{
			return null;
		}
		return dUuXTQcSllqTHMjPkcKnpLWchaib[P_0];
	}

	public int eaOrStrSOuOlEEMmganiuTHlvbL(string P_0, bool P_1 = false)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return -1;
		}
		if (!QIQDEYhznWjPIDsXSpPzmEqigLz.TryGetValue(P_0, out var value))
		{
			if (P_1)
			{
				tZpPsboIuMYOSvIojcnXgggZPNnx(P_0);
			}
			return -1;
		}
		return value.rwgadCCtosdpSxOWMOPfZKMDoRc;
	}

	public int eaOrStrSOuOlEEMmganiuTHlvbL(int P_0, bool P_1 = false)
	{
		if (P_0 < 0 || P_0 > OuQVDAINktbEevsWKGMKFXhcuCr)
		{
			if (P_0 >= 0 && P_1)
			{
				tZpPsboIuMYOSvIojcnXgggZPNnx(P_0);
			}
			return -1;
		}
		HvDLRMlHGRDhutMWIKnofSvcwuX hvDLRMlHGRDhutMWIKnofSvcwuX = GmXZBAZlMqXzZCHHACmsSHAzzaA[P_0];
		if (hvDLRMlHGRDhutMWIKnofSvcwuX == null)
		{
			if (P_1)
			{
				tZpPsboIuMYOSvIojcnXgggZPNnx(P_0);
			}
			return -1;
		}
		return hvDLRMlHGRDhutMWIKnofSvcwuX.rwgadCCtosdpSxOWMOPfZKMDoRc;
	}

	public bool oQFygjrDaMtXNUGnYpOhqPuoBesB(string P_0, bool P_1 = false)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return false;
		}
		if (!QIQDEYhznWjPIDsXSpPzmEqigLz.ContainsKey(P_0))
		{
			if (P_1)
			{
				tZpPsboIuMYOSvIojcnXgggZPNnx(P_0);
			}
			return false;
		}
		return true;
	}

	public bool oQFygjrDaMtXNUGnYpOhqPuoBesB(int P_0)
	{
		if (P_0 < 0 || P_0 > OuQVDAINktbEevsWKGMKFXhcuCr)
		{
			return false;
		}
		return GmXZBAZlMqXzZCHHACmsSHAzzaA[P_0] != null;
	}

	public int wDbPGBsfwyAzxAEZTjUyFzvfvMu(string P_0, bool P_1 = false)
	{
		if (string.IsNullOrEmpty(P_0))
		{
			return -1;
		}
		if (!QIQDEYhznWjPIDsXSpPzmEqigLz.TryGetValue(P_0, out var value))
		{
			if (P_1)
			{
				tZpPsboIuMYOSvIojcnXgggZPNnx(P_0);
			}
			return -1;
		}
		return value.BlZsUkOGPQDnwzRAzcAFtbBWDaNH;
	}

	private void tZpPsboIuMYOSvIojcnXgggZPNnx(string P_0)
	{
		if (!uSryDOgWmNaPoPxhKGlJoosxgrh.Contains(P_0))
		{
			uSryDOgWmNaPoPxhKGlJoosxgrh.Add(P_0);
			Logger.LogWarning("The Action \"" + P_0 + "\" does not exist. You can create Actions in the editor.");
		}
	}

	private void tZpPsboIuMYOSvIojcnXgggZPNnx(int P_0)
	{
		if (!hiUrXMxRJSvnKmiShAhZchSaNqh.Contains(P_0))
		{
			hiUrXMxRJSvnKmiShAhZchSaNqh.Add(P_0);
			Logger.LogWarning("No Action exists for Action Id " + P_0 + ". You can create Actions in the editor.");
		}
	}
}
