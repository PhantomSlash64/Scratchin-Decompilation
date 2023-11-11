using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class cCsOBykrHMUgKHMvCdjhYMSKHte : sXMRGCQcXzxOmcumzBGPmYEKWMf
{
	private readonly Dictionary<Guid, vZFOqLaBPAcreLnfEEpSYkhmXUb> vdThabJafftEHTuaSlGLcJoxCiU = new Dictionary<Guid, vZFOqLaBPAcreLnfEEpSYkhmXUb>();

	private static readonly Dictionary<Type, List<Type>> BahZauAaeiWHmmmqGOCMtgWEvhF = new Dictionary<Type, List<Type>>();

	private IntPtr kZRuZtjsiEjlcACdZDOSkBueFbG;

	[CompilerGenerated]
	private IntPtr[] DHWvLNRzckXwsVbRVDrkkHvZelAC;

	public IntPtr[] hdvIfLJGJjkkoGQOKTOIycvcfRbk
	{
		[CompilerGenerated]
		get
		{
			return DHWvLNRzckXwsVbRVDrkkHvZelAC;
		}
		[CompilerGenerated]
		private set
		{
			DHWvLNRzckXwsVbRVDrkkHvZelAC = value;
		}
	}

	public void MGdUCgKavLcKdZVSFfqcdWqSuzTp(JyVcVsFwWkiykZTchJaCeoITDeB P_0)
	{
		P_0.voZvybzwnHmEoRhkjcyloiQMzsa = this;
		Type type = P_0.GetType();
		List<Type> value;
		lock (BahZauAaeiWHmmmqGOCMtgWEvhF)
		{
			if (!BahZauAaeiWHmmmqGOCMtgWEvhF.TryGetValue(type, out value))
			{
				Type[] interfaces = type.GetInterfaces();
				value = new List<Type>();
				value.AddRange(interfaces);
				BahZauAaeiWHmmmqGOCMtgWEvhF.Add(type, value);
				Type[] array = interfaces;
				foreach (Type type2 in array)
				{
					KCbsLoiHUHnrKXuGbFVWUFHZCrj kCbsLoiHUHnrKXuGbFVWUFHZCrj = KCbsLoiHUHnrKXuGbFVWUFHZCrj.NuvzugUZDfrUIDfyWDWrzXgIdAZ(type2);
					if (kCbsLoiHUHnrKXuGbFVWUFHZCrj == null)
					{
						value.Remove(type2);
						continue;
					}
					Type[] interfaces2 = type2.GetInterfaces();
					Type[] array2 = interfaces2;
					foreach (Type item in array2)
					{
						value.Remove(item);
					}
				}
			}
		}
		vZFOqLaBPAcreLnfEEpSYkhmXUb vZFOqLaBPAcreLnfEEpSYkhmXUb2 = null;
		foreach (Type item2 in value)
		{
			KCbsLoiHUHnrKXuGbFVWUFHZCrj kCbsLoiHUHnrKXuGbFVWUFHZCrj2 = KCbsLoiHUHnrKXuGbFVWUFHZCrj.NuvzugUZDfrUIDfyWDWrzXgIdAZ(item2);
			vZFOqLaBPAcreLnfEEpSYkhmXUb vZFOqLaBPAcreLnfEEpSYkhmXUb3 = (vZFOqLaBPAcreLnfEEpSYkhmXUb)Activator.CreateInstance(kCbsLoiHUHnrKXuGbFVWUFHZCrj2.HmQyuofUsvomGjtCuiqveOpNWlh);
			vZFOqLaBPAcreLnfEEpSYkhmXUb3.MGdUCgKavLcKdZVSFfqcdWqSuzTp(P_0);
			if (vZFOqLaBPAcreLnfEEpSYkhmXUb2 == null)
			{
				vZFOqLaBPAcreLnfEEpSYkhmXUb2 = vZFOqLaBPAcreLnfEEpSYkhmXUb3;
				vdThabJafftEHTuaSlGLcJoxCiU.Add(VKSEPfpoatJOvGtbnPXBrmRqcxz.AONwgNiNrvYnbuqiAereGdVHJqk, vZFOqLaBPAcreLnfEEpSYkhmXUb2);
			}
			vdThabJafftEHTuaSlGLcJoxCiU.Add(WdABqngzfChtFJSJGeObIpoDQOet.iuyeKPGBqkKFnBWwYcRFPixoyazU(item2), vZFOqLaBPAcreLnfEEpSYkhmXUb3);
			Type[] interfaces3 = item2.GetInterfaces();
			Type[] array3 = interfaces3;
			foreach (Type type3 in array3)
			{
				KCbsLoiHUHnrKXuGbFVWUFHZCrj kCbsLoiHUHnrKXuGbFVWUFHZCrj3 = KCbsLoiHUHnrKXuGbFVWUFHZCrj.NuvzugUZDfrUIDfyWDWrzXgIdAZ(type3);
				if (kCbsLoiHUHnrKXuGbFVWUFHZCrj3 != null)
				{
					vdThabJafftEHTuaSlGLcJoxCiU.Add(WdABqngzfChtFJSJGeObIpoDQOet.iuyeKPGBqkKFnBWwYcRFPixoyazU(type3), vZFOqLaBPAcreLnfEEpSYkhmXUb3);
				}
			}
		}
	}

	internal IntPtr STpqmXEZECgfkLPDXPwNnDRIEiMG(Type P_0)
	{
		return STpqmXEZECgfkLPDXPwNnDRIEiMG(WdABqngzfChtFJSJGeObIpoDQOet.iuyeKPGBqkKFnBWwYcRFPixoyazU(P_0));
	}

	internal IntPtr STpqmXEZECgfkLPDXPwNnDRIEiMG(Guid P_0)
	{
		return ZZqRZlBaBvJPLJyupfBRdfOixdg(P_0)?.qNCdusATkxKqHGKMOPeqBcgaeFqZ ?? IntPtr.Zero;
	}

	internal vZFOqLaBPAcreLnfEEpSYkhmXUb ZZqRZlBaBvJPLJyupfBRdfOixdg(Guid P_0)
	{
		vdThabJafftEHTuaSlGLcJoxCiU.TryGetValue(P_0, out var value);
		return value;
	}

	protected override void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (!P_0)
		{
			return;
		}
		foreach (vZFOqLaBPAcreLnfEEpSYkhmXUb value in vdThabJafftEHTuaSlGLcJoxCiU.Values)
		{
			value.Dispose();
		}
		vdThabJafftEHTuaSlGLcJoxCiU.Clear();
		if (kZRuZtjsiEjlcACdZDOSkBueFbG != IntPtr.Zero)
		{
			Marshal.FreeHGlobal(kZRuZtjsiEjlcACdZDOSkBueFbG);
			kZRuZtjsiEjlcACdZDOSkBueFbG = IntPtr.Zero;
		}
	}
}
