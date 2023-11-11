using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Utils.Classes.Data;

internal class sYwCgmJInQorTFIIBkpIONhajGKy
{
	public struct kMLkQRKYstAbZAxsysaYBfvsVfD
	{
		public string lAwMHnSHLfaOPMNsYlOuvaGzOWt;

		public string WrNGLcwSAEjjKVmOFJJAncYJRVq;

		public string HWpkoLElvmTfaUmHEmBxsOPncRl;

		public string qRzhgqdfsMGDjWPnzjIyTYzrZEJ;

		public string LWqGjrmjrdoEvwlpDmluwkYhGtf;

		public string yjBuHEuWYgOjtbiPFOlhJIKqKia;

		public int xYsppkfjaolZMHUcQNpbPXOTiSP;

		public int RfSQCsUPTyQuJvOlwOqZtTDxEw;

		public bool cjOWzBCMkHIxRWceNYEqTjupNms;

		public string AhHrqrQkLzCLgDcoKPqTNKyjQNgv;

		public kMLkQRKYstAbZAxsysaYBfvsVfD(string path, string instanceId, string description, string manufacturer, string locationInfo, bool isBluetoothDevice, string bluetoothDeviceName)
		{
			lAwMHnSHLfaOPMNsYlOuvaGzOWt = path;
			WrNGLcwSAEjjKVmOFJJAncYJRVq = cmwBGCtbOdnPmdndepyeYPuXGzv.gjlkGeDluPtDgcBqsmPLwnmixfs(path);
			HWpkoLElvmTfaUmHEmBxsOPncRl = instanceId;
			qRzhgqdfsMGDjWPnzjIyTYzrZEJ = description;
			LWqGjrmjrdoEvwlpDmluwkYhGtf = manufacturer;
			yjBuHEuWYgOjtbiPFOlhJIKqKia = locationInfo;
			RfSQCsUPTyQuJvOlwOqZtTDxEw = -1;
			xYsppkfjaolZMHUcQNpbPXOTiSP = -1;
			cjOWzBCMkHIxRWceNYEqTjupNms = isBluetoothDevice;
			AhHrqrQkLzCLgDcoKPqTNKyjQNgv = bluetoothDeviceName;
			OPdXrlXobJyxyuwdFFmtTIFrwVi();
		}

		private void OPdXrlXobJyxyuwdFFmtTIFrwVi()
		{
			if (!string.IsNullOrEmpty(yjBuHEuWYgOjtbiPFOlhJIKqKia))
			{
				int num = yjBuHEuWYgOjtbiPFOlhJIKqKia.IndexOf("port_#", StringComparison.OrdinalIgnoreCase);
				int num2 = yjBuHEuWYgOjtbiPFOlhJIKqKia.IndexOf("hub_#", StringComparison.OrdinalIgnoreCase);
				if (num >= 0 && num2 >= 0)
				{
					int.TryParse(yjBuHEuWYgOjtbiPFOlhJIKqKia.Substring(num + 6, 4), out RfSQCsUPTyQuJvOlwOqZtTDxEw);
					int.TryParse(yjBuHEuWYgOjtbiPFOlhJIKqKia.Substring(num2 + 5, 4), out xYsppkfjaolZMHUcQNpbPXOTiSP);
				}
			}
		}
	}

	private struct CdYvjZVOKzLoPbTVlOfkjJmdokI
	{
		public int ZgQFEjHRMdRErGSgCeVRaBOAyBAx;

		public uint MsXEmjrzAmVgWlslfQWXHMqtphv;

		public string yjBuHEuWYgOjtbiPFOlhJIKqKia;

		public CdYvjZVOKzLoPbTVlOfkjJmdokI(int parentIndex, uint deviceInstanceHandle, string locationInfo)
		{
			ZgQFEjHRMdRErGSgCeVRaBOAyBAx = parentIndex;
			MsXEmjrzAmVgWlslfQWXHMqtphv = deviceInstanceHandle;
			yjBuHEuWYgOjtbiPFOlhJIKqKia = locationInfo;
		}
	}

	private struct jmASdZKESDPvbLYotopBmtonbAL
	{
		public readonly uint MsXEmjrzAmVgWlslfQWXHMqtphv;

		public readonly string HAHEWxhqmiBDkRsyORTJPNLgFZdf;

		public jmASdZKESDPvbLYotopBmtonbAL(uint deviceInstanceHandle, string friendlyName)
		{
			MsXEmjrzAmVgWlslfQWXHMqtphv = deviceInstanceHandle;
			HAHEWxhqmiBDkRsyORTJPNLgFZdf = ((friendlyName == null) ? string.Empty : friendlyName);
		}
	}

	[CompilerGenerated]
	private sealed class RbqukMrNwXMvobRUKHAiCJOKmbh
	{
		public string DUXEkgfQEoXedLYkbaoGwCFovcp;

		public StringComparison nrPYAwhFDJdRtNQxjgndlEvUlMw;

		public bool lpDfeOUqVoFAaUlmfcMHAivBoLaE(kMLkQRKYstAbZAxsysaYBfvsVfD P_0)
		{
			return P_0.WrNGLcwSAEjjKVmOFJJAncYJRVq.Equals(DUXEkgfQEoXedLYkbaoGwCFovcp, nrPYAwhFDJdRtNQxjgndlEvUlMw);
		}
	}

	[CompilerGenerated]
	private sealed class bhufcWhmXBDMOzRBCWJFwEHWJifF
	{
		public string DUXEkgfQEoXedLYkbaoGwCFovcp;

		public bool WzYsarwxlsdeXeapMcQSjniyGWR(kMLkQRKYstAbZAxsysaYBfvsVfD P_0)
		{
			return P_0.WrNGLcwSAEjjKVmOFJJAncYJRVq == DUXEkgfQEoXedLYkbaoGwCFovcp;
		}
	}

	[CompilerGenerated]
	private sealed class dFUXyvbNLjPUopSUrwbrTgoklYi
	{
		public int XEcyhhhJkxUMgVxECvasAHFnuwD;

		public int[] iFdAuajJOLSifrYVtXmOaKIlNzN;

		public bool iWOKWwbPxMEYtCMMBFqihXgDhau(tJKAaDrvDYPmVdvOWTbYhAqgFPi P_0)
		{
			if (P_0.KLZsENHavCrIAofHXOTHKQQcpRK.XVuHkKcnbaTxiTZvxKQBLJaCehD == XEcyhhhJkxUMgVxECvasAHFnuwD)
			{
				return iFdAuajJOLSifrYVtXmOaKIlNzN.Contains(P_0.KLZsENHavCrIAofHXOTHKQQcpRK.LLWNXygzETOTnJQyBltZKpktGJs);
			}
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class DPLhhJqAduTGxfSYXeNXbnsJESh
	{
		public int XEcyhhhJkxUMgVxECvasAHFnuwD;

		public bool tnkLZYRUOGmtqMLBtslYZfYhAVJ(tJKAaDrvDYPmVdvOWTbYhAqgFPi P_0)
		{
			return P_0.KLZsENHavCrIAofHXOTHKQQcpRK.XVuHkKcnbaTxiTZvxKQBLJaCehD == XEcyhhhJkxUMgVxECvasAHFnuwD;
		}
	}

	private const string VhwzYVqfxLLGqrmzhoFOlMMWXGd = "BTHENUM";

	private static Guid pRycQlNbRiDkJmmEoasfrTjQBXx;

	private static List<tJKAaDrvDYPmVdvOWTbYhAqgFPi> yxglsQmOpYTDPCYIEzPTrzPxhAG;

	private static List<CdYvjZVOKzLoPbTVlOfkjJmdokI> sVpRBOtPyNyZpZfBqowTPWsfCuP;

	private static List<kMLkQRKYstAbZAxsysaYBfvsVfD> uECIwCOZetiPlltuRDbPVgyNycX;

	private static List<jmASdZKESDPvbLYotopBmtonbAL> GAOfjAkWbZXSJQoNFnacestBULWE;

	private static KSJklejSjRczvdDJaPlpSMisXAa.iTrlYJNPRfnlwJwFcpcVFCxGDEXg hunPHKspYigeDVzMSHCDZhxKQv;

	private static KSJklejSjRczvdDJaPlpSMisXAa.lhOweqQgeBVkcNxcZbiefsqHevf bRZbNwsQSuQPXSphqPvnUKQQApD;

	private static NativeBuffer tDOUXRqeeWRfOKFIdBVIDTMTfWi;

	[CompilerGenerated]
	private static Func<kMLkQRKYstAbZAxsysaYBfvsVfD, tJKAaDrvDYPmVdvOWTbYhAqgFPi> LUDneXBEPlONlOeNrXFxMvLqhUQ;

	[CompilerGenerated]
	private static Func<kMLkQRKYstAbZAxsysaYBfvsVfD, tJKAaDrvDYPmVdvOWTbYhAqgFPi> saRHuMzlKGlPaIfPspwpnytyLVB;

	[CompilerGenerated]
	private static Func<kMLkQRKYstAbZAxsysaYBfvsVfD, tJKAaDrvDYPmVdvOWTbYhAqgFPi> JnQQbrNiikXnvFmhWacoIlxJoyL;

	[CompilerGenerated]
	private static Func<kMLkQRKYstAbZAxsysaYBfvsVfD, tJKAaDrvDYPmVdvOWTbYhAqgFPi> mZSPokLxbPUzPRDGQiJMdLFlMQx;

	private static Guid uCtwknRXVpPYztYGNohUlioWYpe
	{
		get
		{
			if (pRycQlNbRiDkJmmEoasfrTjQBXx.Equals(Guid.Empty))
			{
				BhcxpsOxjdSjSDyqakqjSUDsNCD.RaNEDZIEuRJdChZxOUuLFoRFohEd(ref pRycQlNbRiDkJmmEoasfrTjQBXx);
			}
			return pRycQlNbRiDkJmmEoasfrTjQBXx;
		}
	}

	static sYwCgmJInQorTFIIBkpIONhajGKy()
	{
		pRycQlNbRiDkJmmEoasfrTjQBXx = Guid.Empty;
		yxglsQmOpYTDPCYIEzPTrzPxhAG = new List<tJKAaDrvDYPmVdvOWTbYhAqgFPi>();
		sVpRBOtPyNyZpZfBqowTPWsfCuP = new List<CdYvjZVOKzLoPbTVlOfkjJmdokI>();
		uECIwCOZetiPlltuRDbPVgyNycX = new List<kMLkQRKYstAbZAxsysaYBfvsVfD>();
		GAOfjAkWbZXSJQoNFnacestBULWE = new List<jmASdZKESDPvbLYotopBmtonbAL>();
		hunPHKspYigeDVzMSHCDZhxKQv = new KSJklejSjRczvdDJaPlpSMisXAa.iTrlYJNPRfnlwJwFcpcVFCxGDEXg
		{
			GXzXGWNfOQnVvTtRWSNdFASkppo = (uint)Marshal.SizeOf(typeof(KSJklejSjRczvdDJaPlpSMisXAa.iTrlYJNPRfnlwJwFcpcVFCxGDEXg)),
			IcxGLIhklvvQoQoKtcxmqoxhEvH = true,
			FVqwYyxrNVVUbagbnQWHlJyOsDE = true,
			xbuBMFhCNKPugQlemHgtkfBRtHR = false,
			CQkXEYtAhbFaYkOrUjlkkyHixADj = true,
			mCUytGiDxNfcZnpWicXGXgSVmos = IntPtr.Zero
		};
		bRZbNwsQSuQPXSphqPvnUKQQApD = KSJklejSjRczvdDJaPlpSMisXAa.lhOweqQgeBVkcNxcZbiefsqHevf.AaITSTYmsSMRgQyjrgwNkXeIpsO();
		tDOUXRqeeWRfOKFIdBVIDTMTfWi = new NativeBuffer((int)bRZbNwsQSuQPXSphqPvnUKQQApD.GXzXGWNfOQnVvTtRWSNdFASkppo);
		tDOUXRqeeWRfOKFIdBVIDTMTfWi.Write(bRZbNwsQSuQPXSphqPvnUKQQApD.GXzXGWNfOQnVvTtRWSNdFASkppo, 0);
	}

	public static bool fGcvLiXbUIhveYuKHpUprbEcdtk(string P_0)
	{
		bool flag = false;
		Guid hidClassGuid = uCtwknRXVpPYztYGNohUlioWYpe;
		IntPtr intPtr = BhcxpsOxjdSjSDyqakqjSUDsNCD.WLRAjmIjHuaLlpBpPJXkcDBgVIP(ref hidClassGuid, null, 0, 18);
		if (intPtr.ToInt64() != -1)
		{
			BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH taMBfaJbQIRDdYNzXGCGskaYhLH = WtJDcGxOtegkwxjACCHYeYxevIaf();
			int num = 0;
			while (BhcxpsOxjdSjSDyqakqjSUDsNCD.EnJxBRbQRqEDlNwvdeQmtIDrILA(intPtr, num, ref taMBfaJbQIRDdYNzXGCGskaYhLH))
			{
				num++;
				BhcxpsOxjdSjSDyqakqjSUDsNCD.XArbkxiAhjOSmfCbflAevJBNomED xArbkxiAhjOSmfCbflAevJBNomED = default(BhcxpsOxjdSjSDyqakqjSUDsNCD.XArbkxiAhjOSmfCbflAevJBNomED);
				xArbkxiAhjOSmfCbflAevJBNomED.IdROcMfbOEYQXgcHlEPBORGzcmC = Marshal.SizeOf((object)xArbkxiAhjOSmfCbflAevJBNomED);
				int num2 = 0;
				while (BhcxpsOxjdSjSDyqakqjSUDsNCD.yNOqZXOmthfXnfjRZpAmnGtlydH(intPtr, ref taMBfaJbQIRDdYNzXGCGskaYhLH, ref hidClassGuid, num2, ref xArbkxiAhjOSmfCbflAevJBNomED))
				{
					num2++;
					if (P_0 == JVIVDNvXXHRmmNtIqhNSzgLfOlc(intPtr, xArbkxiAhjOSmfCbflAevJBNomED))
					{
						flag = true;
						break;
					}
				}
				if (flag)
				{
					break;
				}
			}
			BhcxpsOxjdSjSDyqakqjSUDsNCD.PLIdYNMsMTvvRyPqwmrxAOYUtsl(intPtr);
		}
		return flag;
	}

	public static IList<kMLkQRKYstAbZAxsysaYBfvsVfD> YBymhQEcgDzNgzZVSNwPwCwwjCb()
	{
		return asKCtOXqFUvPlObPherBxdgLDsi();
	}

	public static tJKAaDrvDYPmVdvOWTbYhAqgFPi wsTMUsSVNpVsSukTcakkCYepIog(IList<kMLkQRKYstAbZAxsysaYBfvsVfD> P_0, string P_1, StringComparison P_2)
	{
		if (P_0 == null)
		{
			return null;
		}
		return gxIGTNbMTlNZdcyVXIQufOyySbf(P_0.FirstOrDefault((kMLkQRKYstAbZAxsysaYBfvsVfD P_0) => P_0.WrNGLcwSAEjjKVmOFJJAncYJRVq.Equals(P_1, P_2)));
	}

	public static tJKAaDrvDYPmVdvOWTbYhAqgFPi gxIGTNbMTlNZdcyVXIQufOyySbf(kMLkQRKYstAbZAxsysaYBfvsVfD P_0)
	{
		try
		{
			if (string.IsNullOrEmpty(P_0.WrNGLcwSAEjjKVmOFJJAncYJRVq))
			{
				return null;
			}
			return new tJKAaDrvDYPmVdvOWTbYhAqgFPi(P_0.lAwMHnSHLfaOPMNsYlOuvaGzOWt, P_0.HWpkoLElvmTfaUmHEmBxsOPncRl, P_0.qRzhgqdfsMGDjWPnzjIyTYzrZEJ, P_0.LWqGjrmjrdoEvwlpDmluwkYhGtf, P_0.xYsppkfjaolZMHUcQNpbPXOTiSP, P_0.RfSQCsUPTyQuJvOlwOqZtTDxEw, P_0.cjOWzBCMkHIxRWceNYEqTjupNms, P_0.AhHrqrQkLzCLgDcoKPqTNKyjQNgv);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static tJKAaDrvDYPmVdvOWTbYhAqgFPi KXWlvxVPoglrUayGyPlGzgCbGgff(string P_0)
	{
		return JdUDtJMOxlNUpArYEAfecqBSASZ(P_0).FirstOrDefault();
	}

	public static IEnumerable<tJKAaDrvDYPmVdvOWTbYhAqgFPi> JdUDtJMOxlNUpArYEAfecqBSASZ()
	{
		return from P_0 in asKCtOXqFUvPlObPherBxdgLDsi()
			select new tJKAaDrvDYPmVdvOWTbYhAqgFPi(P_0.lAwMHnSHLfaOPMNsYlOuvaGzOWt, P_0.HWpkoLElvmTfaUmHEmBxsOPncRl, P_0.qRzhgqdfsMGDjWPnzjIyTYzrZEJ, P_0.LWqGjrmjrdoEvwlpDmluwkYhGtf, P_0.xYsppkfjaolZMHUcQNpbPXOTiSP, P_0.RfSQCsUPTyQuJvOlwOqZtTDxEw, P_0.cjOWzBCMkHIxRWceNYEqTjupNms, P_0.AhHrqrQkLzCLgDcoKPqTNKyjQNgv);
	}

	public static IEnumerable<tJKAaDrvDYPmVdvOWTbYhAqgFPi> JdUDtJMOxlNUpArYEAfecqBSASZ(string P_0)
	{
		return from P_0 in asKCtOXqFUvPlObPherBxdgLDsi()
			where P_0.WrNGLcwSAEjjKVmOFJJAncYJRVq == P_0
			select new tJKAaDrvDYPmVdvOWTbYhAqgFPi(P_0.lAwMHnSHLfaOPMNsYlOuvaGzOWt, P_0.HWpkoLElvmTfaUmHEmBxsOPncRl, P_0.qRzhgqdfsMGDjWPnzjIyTYzrZEJ, P_0.LWqGjrmjrdoEvwlpDmluwkYhGtf, P_0.xYsppkfjaolZMHUcQNpbPXOTiSP, P_0.RfSQCsUPTyQuJvOlwOqZtTDxEw, P_0.cjOWzBCMkHIxRWceNYEqTjupNms, P_0.AhHrqrQkLzCLgDcoKPqTNKyjQNgv);
	}

	public static IEnumerable<tJKAaDrvDYPmVdvOWTbYhAqgFPi> JdUDtJMOxlNUpArYEAfecqBSASZ(int P_0, params int[] P_1)
	{
		return from P_0 in asKCtOXqFUvPlObPherBxdgLDsi()
			select new tJKAaDrvDYPmVdvOWTbYhAqgFPi(P_0.lAwMHnSHLfaOPMNsYlOuvaGzOWt, P_0.HWpkoLElvmTfaUmHEmBxsOPncRl, P_0.qRzhgqdfsMGDjWPnzjIyTYzrZEJ, P_0.LWqGjrmjrdoEvwlpDmluwkYhGtf, P_0.xYsppkfjaolZMHUcQNpbPXOTiSP, P_0.RfSQCsUPTyQuJvOlwOqZtTDxEw, P_0.cjOWzBCMkHIxRWceNYEqTjupNms, P_0.AhHrqrQkLzCLgDcoKPqTNKyjQNgv) into P_0
			where P_0.KLZsENHavCrIAofHXOTHKQQcpRK.XVuHkKcnbaTxiTZvxKQBLJaCehD == P_0 && P_1.Contains(P_0.KLZsENHavCrIAofHXOTHKQQcpRK.LLWNXygzETOTnJQyBltZKpktGJs)
			select P_0;
	}

	public static IEnumerable<tJKAaDrvDYPmVdvOWTbYhAqgFPi> JdUDtJMOxlNUpArYEAfecqBSASZ(int P_0)
	{
		return from P_0 in asKCtOXqFUvPlObPherBxdgLDsi()
			select new tJKAaDrvDYPmVdvOWTbYhAqgFPi(P_0.lAwMHnSHLfaOPMNsYlOuvaGzOWt, P_0.HWpkoLElvmTfaUmHEmBxsOPncRl, P_0.qRzhgqdfsMGDjWPnzjIyTYzrZEJ, P_0.LWqGjrmjrdoEvwlpDmluwkYhGtf, P_0.xYsppkfjaolZMHUcQNpbPXOTiSP, P_0.RfSQCsUPTyQuJvOlwOqZtTDxEw, P_0.cjOWzBCMkHIxRWceNYEqTjupNms, P_0.AhHrqrQkLzCLgDcoKPqTNKyjQNgv) into P_0
			where P_0.KLZsENHavCrIAofHXOTHKQQcpRK.XVuHkKcnbaTxiTZvxKQBLJaCehD == P_0
			select P_0;
	}

	public static bool OCMyDtErcQlvXJRtPGkcSdJpOMp()
	{
		foreach (tJKAaDrvDYPmVdvOWTbYhAqgFPi item in JdUDtJMOxlNUpArYEAfecqBSASZ())
		{
			if (item.cjOWzBCMkHIxRWceNYEqTjupNms)
			{
				return true;
			}
		}
		return false;
	}

	public static int VFEohVGjpKoiHHXQrfHvEoqRdGz()
	{
		return VFEohVGjpKoiHHXQrfHvEoqRdGz(ref hunPHKspYigeDVzMSHCDZhxKQv, tDOUXRqeeWRfOKFIdBVIDTMTfWi);
	}

	public static int VFEohVGjpKoiHHXQrfHvEoqRdGz(ref KSJklejSjRczvdDJaPlpSMisXAa.iTrlYJNPRfnlwJwFcpcVFCxGDEXg P_0, NativeBuffer P_1)
	{
		int num = 0;
		try
		{
			IntPtr intPtr = KSJklejSjRczvdDJaPlpSMisXAa.DVGTaEhICfoTfmUmparNLHQFaDB(ref P_0, P_1);
			while (intPtr != IntPtr.Zero)
			{
				if (P_1.ReadInt(20) > 0)
				{
					num++;
				}
				if (!KSJklejSjRczvdDJaPlpSMisXAa.boBFXqOMgeIQcIApUpdBAxgiNKap(intPtr, P_1))
				{
					KSJklejSjRczvdDJaPlpSMisXAa.eibfoMpxmgGwQtNXEarWvQGSmSF(intPtr);
					return num;
				}
			}
			return num;
		}
		catch (Exception)
		{
			return num;
		}
	}

	private static IList<kMLkQRKYstAbZAxsysaYBfvsVfD> asKCtOXqFUvPlObPherBxdgLDsi()
	{
		yxglsQmOpYTDPCYIEzPTrzPxhAG.Clear();
		uECIwCOZetiPlltuRDbPVgyNycX.Clear();
		Guid hidClassGuid = uCtwknRXVpPYztYGNohUlioWYpe;
		IntPtr intPtr = BhcxpsOxjdSjSDyqakqjSUDsNCD.WLRAjmIjHuaLlpBpPJXkcDBgVIP(ref hidClassGuid, null, 0, 18);
		if (intPtr.ToInt64() != -1)
		{
			BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH taMBfaJbQIRDdYNzXGCGskaYhLH = WtJDcGxOtegkwxjACCHYeYxevIaf();
			int num = 0;
			sVpRBOtPyNyZpZfBqowTPWsfCuP.Clear();
			GKYKsCZTzHDgzExCsnHhAlcUwdf(sVpRBOtPyNyZpZfBqowTPWsfCuP);
			List<CdYvjZVOKzLoPbTVlOfkjJmdokI> list = sVpRBOtPyNyZpZfBqowTPWsfCuP;
			GAOfjAkWbZXSJQoNFnacestBULWE.Clear();
			List<jmASdZKESDPvbLYotopBmtonbAL> gAOfjAkWbZXSJQoNFnacestBULWE = GAOfjAkWbZXSJQoNFnacestBULWE;
			while (BhcxpsOxjdSjSDyqakqjSUDsNCD.EnJxBRbQRqEDlNwvdeQmtIDrILA(intPtr, num, ref taMBfaJbQIRDdYNzXGCGskaYhLH))
			{
				num++;
				BhcxpsOxjdSjSDyqakqjSUDsNCD.XArbkxiAhjOSmfCbflAevJBNomED xArbkxiAhjOSmfCbflAevJBNomED = default(BhcxpsOxjdSjSDyqakqjSUDsNCD.XArbkxiAhjOSmfCbflAevJBNomED);
				xArbkxiAhjOSmfCbflAevJBNomED.IdROcMfbOEYQXgcHlEPBORGzcmC = xArbkxiAhjOSmfCbflAevJBNomED.FsbRBYqJkiVgWCSTYQjKxIKiyqH;
				int num2 = 0;
				while (BhcxpsOxjdSjSDyqakqjSUDsNCD.yNOqZXOmthfXnfjRZpAmnGtlydH(intPtr, ref taMBfaJbQIRDdYNzXGCGskaYhLH, ref hidClassGuid, num2, ref xArbkxiAhjOSmfCbflAevJBNomED))
				{
					num2++;
					string text = JVIVDNvXXHRmmNtIqhNSzgLfOlc(intPtr, xArbkxiAhjOSmfCbflAevJBNomED);
					string instanceId = oyxuwJuFPFCsQVyNpbNKSptHWwV(intPtr, ref taMBfaJbQIRDdYNzXGCGskaYhLH);
					string description = iRPcXFBZlnSlvNORvIGXYrBmCDIC(intPtr, ref taMBfaJbQIRDdYNzXGCGskaYhLH) ?? LDJkVqzjLEwNcZQswqyQUAsZsQQ(intPtr, ref taMBfaJbQIRDdYNzXGCGskaYhLH);
					string manufacturer = GofNpKognrDILGfnygJTUtmCLpXE(intPtr, ref taMBfaJbQIRDdYNzXGCGskaYhLH);
					string locationInfo = string.Empty;
					uint uuWjunphPVmpNAdBvSDAdOvGDkH = (uint)taMBfaJbQIRDdYNzXGCGskaYhLH.UuWjunphPVmpNAdBvSDAdOvGDkH;
					int count = list.Count;
					for (int i = 0; i < count; i++)
					{
						if (list[i].MsXEmjrzAmVgWlslfQWXHMqtphv == uuWjunphPVmpNAdBvSDAdOvGDkH)
						{
							int zgQFEjHRMdRErGSgCeVRaBOAyBAx = list[i].ZgQFEjHRMdRErGSgCeVRaBOAyBAx;
							if (zgQFEjHRMdRErGSgCeVRaBOAyBAx >= 0 && zgQFEjHRMdRErGSgCeVRaBOAyBAx < count)
							{
								locationInfo = list[zgQFEjHRMdRErGSgCeVRaBOAyBAx].yjBuHEuWYgOjtbiPFOlhJIKqKia;
								break;
							}
							Logger.LogError("USB device index out of range.");
						}
					}
					JcXFqGoLDFcBgpwDBhMubUijoAy(uuWjunphPVmpNAdBvSDAdOvGDkH, ref gAOfjAkWbZXSJQoNFnacestBULWE, out var flag, out var bluetoothDeviceName);
					bool flag2 = false;
					if (flag)
					{
						flag2 = !MBRgDHTBiQXPvHSCnePmXpDZkBm(text);
					}
					if (!flag2)
					{
						uECIwCOZetiPlltuRDbPVgyNycX.Add(new kMLkQRKYstAbZAxsysaYBfvsVfD(text, instanceId, description, manufacturer, locationInfo, flag, bluetoothDeviceName));
					}
				}
			}
			BhcxpsOxjdSjSDyqakqjSUDsNCD.PLIdYNMsMTvvRyPqwmrxAOYUtsl(intPtr);
		}
		return uECIwCOZetiPlltuRDbPVgyNycX;
	}

	private static void GKYKsCZTzHDgzExCsnHhAlcUwdf(List<CdYvjZVOKzLoPbTVlOfkjJmdokI> P_0)
	{
		Guid gUID_DEVINTERFACE_USB_DEVICE = BhcxpsOxjdSjSDyqakqjSUDsNCD.VArmJRlFfCniaFvjgOLGYxTWMWx;
		IntPtr intPtr = BhcxpsOxjdSjSDyqakqjSUDsNCD.WLRAjmIjHuaLlpBpPJXkcDBgVIP(ref gUID_DEVINTERFACE_USB_DEVICE, null, 0, 18);
		if (intPtr.ToInt64() == -1)
		{
			return;
		}
		BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH taMBfaJbQIRDdYNzXGCGskaYhLH = WtJDcGxOtegkwxjACCHYeYxevIaf();
		int num = 0;
		while (BhcxpsOxjdSjSDyqakqjSUDsNCD.EnJxBRbQRqEDlNwvdeQmtIDrILA(intPtr, num, ref taMBfaJbQIRDdYNzXGCGskaYhLH))
		{
			num++;
			BhcxpsOxjdSjSDyqakqjSUDsNCD.XArbkxiAhjOSmfCbflAevJBNomED xArbkxiAhjOSmfCbflAevJBNomED = default(BhcxpsOxjdSjSDyqakqjSUDsNCD.XArbkxiAhjOSmfCbflAevJBNomED);
			xArbkxiAhjOSmfCbflAevJBNomED.IdROcMfbOEYQXgcHlEPBORGzcmC = xArbkxiAhjOSmfCbflAevJBNomED.FsbRBYqJkiVgWCSTYQjKxIKiyqH;
			int num2 = 0;
			while (BhcxpsOxjdSjSDyqakqjSUDsNCD.yNOqZXOmthfXnfjRZpAmnGtlydH(intPtr, ref taMBfaJbQIRDdYNzXGCGskaYhLH, ref gUID_DEVINTERFACE_USB_DEVICE, num2, ref xArbkxiAhjOSmfCbflAevJBNomED))
			{
				num2++;
				string locationInfo = HYccqjaDJwIGnYNObGajcbPhVknB(intPtr, ref taMBfaJbQIRDdYNzXGCGskaYhLH);
				P_0.Add(new CdYvjZVOKzLoPbTVlOfkjJmdokI(-1, (uint)taMBfaJbQIRDdYNzXGCGskaYhLH.UuWjunphPVmpNAdBvSDAdOvGDkH, locationInfo));
				int parentIndex = P_0.Count - 1;
				List<uint> list = YXdvuxhBkOGavIUzFAdGHPZfQAs((uint)taMBfaJbQIRDdYNzXGCGskaYhLH.UuWjunphPVmpNAdBvSDAdOvGDkH);
				if (list != null)
				{
					for (int i = 0; i < list.Count; i++)
					{
						P_0.Add(new CdYvjZVOKzLoPbTVlOfkjJmdokI(parentIndex, list[i], null));
					}
				}
			}
		}
		BhcxpsOxjdSjSDyqakqjSUDsNCD.PLIdYNMsMTvvRyPqwmrxAOYUtsl(intPtr);
	}

	private static List<jmASdZKESDPvbLYotopBmtonbAL> yRWuSpIIaRgnzyZglDrOGXMkUTW(List<jmASdZKESDPvbLYotopBmtonbAL> P_0)
	{
		Guid gUID_BluetoothClassGuid = BhcxpsOxjdSjSDyqakqjSUDsNCD.UwGuHdSrLeMSHbHczLHSjRLJfCr;
		IntPtr intPtr = BhcxpsOxjdSjSDyqakqjSUDsNCD.WLRAjmIjHuaLlpBpPJXkcDBgVIP(ref gUID_BluetoothClassGuid, null, 0, 2);
		if (intPtr.ToInt64() != -1)
		{
			BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH taMBfaJbQIRDdYNzXGCGskaYhLH = WtJDcGxOtegkwxjACCHYeYxevIaf();
			int num = 0;
			while (BhcxpsOxjdSjSDyqakqjSUDsNCD.EnJxBRbQRqEDlNwvdeQmtIDrILA(intPtr, num, ref taMBfaJbQIRDdYNzXGCGskaYhLH))
			{
				num++;
				P_0.Add(new jmASdZKESDPvbLYotopBmtonbAL((uint)taMBfaJbQIRDdYNzXGCGskaYhLH.UuWjunphPVmpNAdBvSDAdOvGDkH, RhUhDmKUompZEFWvHibQaAslUGL(intPtr, ref taMBfaJbQIRDdYNzXGCGskaYhLH)));
			}
			BhcxpsOxjdSjSDyqakqjSUDsNCD.PLIdYNMsMTvvRyPqwmrxAOYUtsl(intPtr);
		}
		return P_0;
	}

	private static string yrOprQAKlggRJVTVltKXwMMeubF(uint P_0)
	{
		string empty = string.Empty;
		yrOprQAKlggRJVTVltKXwMMeubF(P_0, 0, ref empty);
		return empty;
	}

	private static bool yrOprQAKlggRJVTVltKXwMMeubF(uint P_0, int P_1, ref string P_2)
	{
		List<uint> list = vcQNevgsCAaYbpPyNSHpYcoyaxa(P_0);
		if (list == null)
		{
			return false;
		}
		string text = "";
		for (int i = 0; i < P_1; i++)
		{
			text += "_____";
		}
		for (int j = 0; j < list.Count; j++)
		{
			object obj = P_2;
			P_2 = string.Concat(obj, text, "(", list[j], ") ", lArXNMdWqqjJweHnSoVQRMDKYQt(list[j]), "\n");
			yrOprQAKlggRJVTVltKXwMMeubF(list[j], P_1 + 1, ref P_2);
		}
		return true;
	}

	private static List<string> jWnQroVUXPLmsMihamPObrohrzn(uint P_0)
	{
		List<uint> list = YXdvuxhBkOGavIUzFAdGHPZfQAs(P_0);
		if (list == null)
		{
			return null;
		}
		List<string> list2 = new List<string>();
		for (int i = 0; i < list.Count; i++)
		{
			list2.Add(lArXNMdWqqjJweHnSoVQRMDKYQt(list[i]));
		}
		return list2;
	}

	private static List<uint> YXdvuxhBkOGavIUzFAdGHPZfQAs(uint P_0)
	{
		List<uint> list = vcQNevgsCAaYbpPyNSHpYcoyaxa(P_0);
		if (list == null)
		{
			return null;
		}
		Queue<uint> queue = new Queue<uint>(list);
		List<uint> list2 = new List<uint>();
		while (queue.Count > 0)
		{
			uint num = queue.Dequeue();
			list2.Add(num);
			List<uint> list3 = vcQNevgsCAaYbpPyNSHpYcoyaxa(num);
			if (list3 != null)
			{
				for (int i = 0; i < list3.Count; i++)
				{
					queue.Enqueue(list3[i]);
				}
			}
		}
		return list2;
	}

	private static List<string> VpvraNAmjqExTeroUqacshRJJks(uint P_0)
	{
		if (BhcxpsOxjdSjSDyqakqjSUDsNCD.aWQcYxdTpCNKucJuizLnTrPfAIOG(out var num, P_0, 0u) != 0)
		{
			return null;
		}
		List<string> list = new List<string>();
		list.Add(lArXNMdWqqjJweHnSoVQRMDKYQt(num));
		while (BhcxpsOxjdSjSDyqakqjSUDsNCD.gLNTuBcldysVQQqRbeVTATmrCqy(out num, num, 0u) == 0)
		{
			list.Add(lArXNMdWqqjJweHnSoVQRMDKYQt(num));
		}
		return list;
	}

	private static List<uint> vcQNevgsCAaYbpPyNSHpYcoyaxa(uint P_0)
	{
		if (BhcxpsOxjdSjSDyqakqjSUDsNCD.aWQcYxdTpCNKucJuizLnTrPfAIOG(out var num, P_0, 0u) != 0)
		{
			return null;
		}
		List<uint> list = new List<uint>();
		list.Add(num);
		while (BhcxpsOxjdSjSDyqakqjSUDsNCD.gLNTuBcldysVQQqRbeVTATmrCqy(out num, num, 0u) == 0)
		{
			list.Add(num);
		}
		return list;
	}

	private static string lArXNMdWqqjJweHnSoVQRMDKYQt(uint P_0)
	{
		if (BhcxpsOxjdSjSDyqakqjSUDsNCD.yOEsAbUbiuFKntACnbdFdhWbvWh(out var num, P_0, 0u) != 0)
		{
			return string.Empty;
		}
		if (num == 0)
		{
			return string.Empty;
		}
		num++;
		int cb = (int)num * Marshal.SystemDefaultCharSize;
		IntPtr intPtr = Marshal.AllocHGlobal(cb);
		if (BhcxpsOxjdSjSDyqakqjSUDsNCD.TlfykVkUdPkiwxflMXgEOQQSCvt(P_0, intPtr, (int)num, 0u) != 0)
		{
			return string.Empty;
		}
		try
		{
			return Marshal.PtrToStringUni(intPtr, (int)num);
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	private static bool EOAlIcITziTbffyXEmHjWGNJkmB(uint P_0, uint P_1)
	{
		List<uint> list = YXdvuxhBkOGavIUzFAdGHPZfQAs(P_0);
		if (list == null)
		{
			return false;
		}
		int count = list.Count;
		for (int i = 0; i < count; i++)
		{
			if (list[i] == P_1)
			{
				return true;
			}
		}
		return false;
	}

	private static void JcXFqGoLDFcBgpwDBhMubUijoAy(uint P_0, ref List<jmASdZKESDPvbLYotopBmtonbAL> P_1, out bool P_2, out string P_3)
	{
		P_3 = string.Empty;
		try
		{
			if (!yakRMxUrlQPYBGmIHvRjLPowvXt(P_0, ref P_1, out P_2, out var num) || P_1 == null)
			{
				return;
			}
			for (int i = 0; i < P_1.Count; i++)
			{
				if (P_1[i].MsXEmjrzAmVgWlslfQWXHMqtphv == num)
				{
					P_3 = P_1[i].HAHEWxhqmiBDkRsyORTJPNLgFZdf;
					break;
				}
			}
		}
		catch
		{
			P_2 = false;
		}
	}

	private static bool yakRMxUrlQPYBGmIHvRjLPowvXt(uint P_0, ref List<jmASdZKESDPvbLYotopBmtonbAL> P_1, out bool P_2, out uint P_3)
	{
		P_2 = false;
		P_3 = 0u;
		if (AYDBXjSgWsqMMmcAWeRfMcqmdbs(P_0, "BTHENUM", out var text, out var num))
		{
			P_2 = true;
			if (P_1.Count == 0)
			{
				yRWuSpIIaRgnzyZglDrOGXMkUTW(P_1);
			}
			if (zvjYivaVZRXaeRAavaEOCxcyHCk(text, out var text2) && jhDKqTZYLBfmLrSbCOMZcoObJhHh(num, text2, out var num2))
			{
				P_3 = num2;
				return true;
			}
		}
		return false;
	}

	private static bool AYDBXjSgWsqMMmcAWeRfMcqmdbs(uint P_0, string P_1, out string P_2, out uint P_3)
	{
		P_2 = string.Empty;
		P_3 = 0u;
		uint num = P_0;
		uint num2;
		while (BhcxpsOxjdSjSDyqakqjSUDsNCD.eDsHmxpFsAwnaGKRyNHgcQMcpUb(out num2, num, 0u) == 0)
		{
			string text = lArXNMdWqqjJweHnSoVQRMDKYQt(num2);
			if (text == string.Empty)
			{
				break;
			}
			if (text.StartsWith(P_1, StringComparison.OrdinalIgnoreCase))
			{
				P_2 = text;
				P_3 = num2;
				return true;
			}
			num = num2;
		}
		return false;
	}

	private static bool zvjYivaVZRXaeRAavaEOCxcyHCk(string P_0, out string P_1)
	{
		P_1 = null;
		if (string.IsNullOrEmpty(P_0))
		{
			return false;
		}
		int num = P_0.LastIndexOf('\\');
		if (num <= 0 || num >= P_0.Length - 1)
		{
			return false;
		}
		string text = P_0.Substring(num + 1);
		num = text.LastIndexOf('_');
		if (num <= 0 || num >= text.Length - 1)
		{
			return false;
		}
		text = text.Substring(0, num);
		num = text.LastIndexOf('&');
		if (num <= 0 || num >= text.Length - 1)
		{
			return false;
		}
		text = text.Substring(num + 1);
		if (text.Length <= 1)
		{
			return false;
		}
		P_1 = text;
		return true;
	}

	private static bool jhDKqTZYLBfmLrSbCOMZcoObJhHh(uint P_0, string P_1, out uint P_2)
	{
		P_2 = 0u;
		if (string.IsNullOrEmpty(P_1))
		{
			return false;
		}
		if (BhcxpsOxjdSjSDyqakqjSUDsNCD.eDsHmxpFsAwnaGKRyNHgcQMcpUb(out var num, P_0, 0u) != 0)
		{
			return false;
		}
		if (BhcxpsOxjdSjSDyqakqjSUDsNCD.aWQcYxdTpCNKucJuizLnTrPfAIOG(out var num2, num, 0u) != 0)
		{
			return false;
		}
		uint num3 = num2;
		if (num3 == P_0 && BhcxpsOxjdSjSDyqakqjSUDsNCD.gLNTuBcldysVQQqRbeVTATmrCqy(out num3, num3, 0u) != 0)
		{
			return false;
		}
		do
		{
			string text = lArXNMdWqqjJweHnSoVQRMDKYQt(num3);
			if (text == string.Empty)
			{
				return false;
			}
			if (text.EndsWith(P_1, StringComparison.OrdinalIgnoreCase))
			{
				P_2 = num3;
				return true;
			}
		}
		while (BhcxpsOxjdSjSDyqakqjSUDsNCD.gLNTuBcldysVQQqRbeVTATmrCqy(out num3, num3, 0u) == 0);
		return false;
	}

	private static bool MBRgDHTBiQXPvHSCnePmXpDZkBm(string P_0, bool P_1 = true)
	{
		bool flag = false;
		IntPtr intPtr = IntPtr.Zero;
		string text = string.Empty;
		try
		{
			intPtr = tJKAaDrvDYPmVdvOWTbYhAqgFPi.MzoYxfOdCxFlOXCkNPJXAEKRpwN(P_0, xNxlsfJtdmLgsLpXvJXvKtxFFzn.hpMCzWILToKFZQFQqBmwAbuwPAX, 3221225472u, onJfdTGjmuCrmsdvUkFvIZyefBlQ.CGmxvAXqZVdlwwfTOeTPkIDeTOC | onJfdTGjmuCrmsdvUkFvIZyefBlQ.mnsxsXARiylESkmzvxWpWQOciSp);
			if (intPtr != IntPtr.Zero)
			{
				text = tJKAaDrvDYPmVdvOWTbYhAqgFPi.MCnhPwQsPweeoGCMVvFKmkJzwMS(intPtr);
				flag = true;
			}
		}
		catch
		{
			if (intPtr != IntPtr.Zero)
			{
				tJKAaDrvDYPmVdvOWTbYhAqgFPi.BKZtrMellduMDpkmiJpwOwRCNXs(intPtr);
			}
			return false;
		}
		if (!flag)
		{
			return false;
		}
		if (string.IsNullOrEmpty(text))
		{
			if (intPtr != IntPtr.Zero)
			{
				tJKAaDrvDYPmVdvOWTbYhAqgFPi.BKZtrMellduMDpkmiJpwOwRCNXs(intPtr);
			}
			return true;
		}
		KSJklejSjRczvdDJaPlpSMisXAa.yQCuUxShTgzwXVHZTJzxqxhNJoI yQCuUxShTgzwXVHZTJzxqxhNJoI = KSJklejSjRczvdDJaPlpSMisXAa.yQCuUxShTgzwXVHZTJzxqxhNJoI.JOcErveRSJpChJtfddvsswxNEpPJ(text, out flag);
		if (!flag)
		{
			if (intPtr != IntPtr.Zero)
			{
				tJKAaDrvDYPmVdvOWTbYhAqgFPi.BKZtrMellduMDpkmiJpwOwRCNXs(intPtr);
			}
			return true;
		}
		bool flag2 = false;
		try
		{
			IntPtr intPtr2 = KSJklejSjRczvdDJaPlpSMisXAa.DVGTaEhICfoTfmUmparNLHQFaDB(ref hunPHKspYigeDVzMSHCDZhxKQv, ref bRZbNwsQSuQPXSphqPvnUKQQApD);
			if (intPtr2 == IntPtr.Zero)
			{
			}
			while (true)
			{
				if (intPtr2 != IntPtr.Zero)
				{
					if (bRZbNwsQSuQPXSphqPvnUKQQApD.XZzOOJVRuLRjXKfxaFkeflPigSkU.MQTCepEULnfLzBngwyxfLRrjDAVl(ref yQCuUxShTgzwXVHZTJzxqxhNJoI))
					{
						flag2 = bRZbNwsQSuQPXSphqPvnUKQQApD.KyrzWNQcbQJImUvkeGDYfiWafXO;
						KSJklejSjRczvdDJaPlpSMisXAa.eibfoMpxmgGwQtNXEarWvQGSmSF(intPtr2);
						if (!P_1)
						{
							break;
						}
						if (!flag2)
						{
							CvkFOOwkDoiVMzwmEqmdSMCeKaf cvkFOOwkDoiVMzwmEqmdSMCeKaf = tJKAaDrvDYPmVdvOWTbYhAqgFPi.jctHEbDpqvnsjMxyrebeLnuZCOR(intPtr);
							if (cvkFOOwkDoiVMzwmEqmdSMCeKaf.raHmdvKpmDzDhFVQwjMIbPuhFjpk > 0)
							{
								int inputReportByteLength = cvkFOOwkDoiVMzwmEqmdSMCeKaf.raHmdvKpmDzDhFVQwjMIbPuhFjpk;
								IntPtr intPtr3 = Marshal.AllocHGlobal(inputReportByteLength);
								try
								{
									if (!BhcxpsOxjdSjSDyqakqjSUDsNCD.WXLNazozTCRnzMdirHqwGkqVGQiw(intPtr, intPtr3, inputReportByteLength))
									{
										Marshal.WriteByte(intPtr3, 1);
										BhcxpsOxjdSjSDyqakqjSUDsNCD.WXLNazozTCRnzMdirHqwGkqVGQiw(intPtr, intPtr3, inputReportByteLength);
										return flag2;
									}
									return flag2;
								}
								catch
								{
									return flag2;
								}
								finally
								{
									Marshal.FreeHGlobal(intPtr3);
								}
							}
							return flag2;
						}
						return flag2;
					}
					if (!KSJklejSjRczvdDJaPlpSMisXAa.boBFXqOMgeIQcIApUpdBAxgiNKap(intPtr2, ref bRZbNwsQSuQPXSphqPvnUKQQApD))
					{
						KSJklejSjRczvdDJaPlpSMisXAa.eibfoMpxmgGwQtNXEarWvQGSmSF(intPtr2);
						return flag2;
					}
					continue;
				}
				return flag2;
			}
			return flag2;
		}
		catch
		{
			return flag2;
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				tJKAaDrvDYPmVdvOWTbYhAqgFPi.BKZtrMellduMDpkmiJpwOwRCNXs(intPtr);
			}
		}
	}

	private static BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH WtJDcGxOtegkwxjACCHYeYxevIaf()
	{
		BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH result = default(BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH);
		result.IdROcMfbOEYQXgcHlEPBORGzcmC = result.FsbRBYqJkiVgWCSTYQjKxIKiyqH;
		result.UuWjunphPVmpNAdBvSDAdOvGDkH = 0;
		result.UEbINbYOIsEMMrTskfCeDEUHOsWB = Guid.Empty;
		result.ltMhmIaxLmZNawAPllSWxysDUR = IntPtr.Zero;
		return result;
	}

	private static string JVIVDNvXXHRmmNtIqhNSzgLfOlc(IntPtr P_0, BhcxpsOxjdSjSDyqakqjSUDsNCD.XArbkxiAhjOSmfCbflAevJBNomED P_1)
	{
		int num = 0;
		BhcxpsOxjdSjSDyqakqjSUDsNCD.fDlhYtliwKEDTTOQJhpMZRZspys fDlhYtliwKEDTTOQJhpMZRZspys = default(BhcxpsOxjdSjSDyqakqjSUDsNCD.fDlhYtliwKEDTTOQJhpMZRZspys);
		fDlhYtliwKEDTTOQJhpMZRZspys.OAxxiRRJUwaMLNmFaPAXfzgmRpb = ((IntPtr.Size == 4) ? (4 + Marshal.SystemDefaultCharSize) : 8);
		BhcxpsOxjdSjSDyqakqjSUDsNCD.fDlhYtliwKEDTTOQJhpMZRZspys fDlhYtliwKEDTTOQJhpMZRZspys2 = fDlhYtliwKEDTTOQJhpMZRZspys;
		BhcxpsOxjdSjSDyqakqjSUDsNCD.WrNsWGTMpOPnkHSRNLzJRAgNfUF(P_0, ref P_1, IntPtr.Zero, 0, ref num, IntPtr.Zero);
		if (!BhcxpsOxjdSjSDyqakqjSUDsNCD.WrNsWGTMpOPnkHSRNLzJRAgNfUF(P_0, ref P_1, ref fDlhYtliwKEDTTOQJhpMZRZspys2, num, ref num, IntPtr.Zero))
		{
			return null;
		}
		return fDlhYtliwKEDTTOQJhpMZRZspys2.FbhbjmvDJXhmcRNTPxCMljeDYKl;
	}

	private static string oyxuwJuFPFCsQVyNpbNKSptHWwV(IntPtr P_0, ref BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH P_1)
	{
		IntPtr intPtr = Marshal.AllocHGlobal(BhcxpsOxjdSjSDyqakqjSUDsNCD.YjBbdjbfUBwvbMXyxIMhWZmccrL);
		uint len;
		string result = (BhcxpsOxjdSjSDyqakqjSUDsNCD.anTwYQTESCjALuwqxiJlHhlGBqq(P_0, ref P_1, intPtr, (uint)BhcxpsOxjdSjSDyqakqjSUDsNCD.fSiIIjOyZetNAHFCSXBDHiQsQOT, out len) ? Marshal.PtrToStringUni(intPtr, (int)len) : "FAILED");
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	private static string LDJkVqzjLEwNcZQswqyQUAsZsQQ(IntPtr P_0, ref BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH P_1)
	{
		return aVeBOiJBxrIBKeVmhUpuojwguHXF(P_0, ref P_1, 0);
	}

	private static string RhUhDmKUompZEFWvHibQaAslUGL(IntPtr P_0, ref BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH P_1)
	{
		return aVeBOiJBxrIBKeVmhUpuojwguHXF(P_0, ref P_1, 12);
	}

	private static string fKmbcsvkLCILRvtCAsvkSnNkdmO(IntPtr P_0, ref BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH P_1)
	{
		return aVeBOiJBxrIBKeVmhUpuojwguHXF(P_0, ref P_1, 14);
	}

	private static string EZJCJxhbFmoLAgWcbiRRHjYYUEA(IntPtr P_0, ref BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH P_1)
	{
		return aVeBOiJBxrIBKeVmhUpuojwguHXF(P_0, ref P_1, 28);
	}

	private static string sEtaOUZcEBCVXXyfuYKEuZCRlYX(IntPtr P_0, ref BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH P_1)
	{
		return aVeBOiJBxrIBKeVmhUpuojwguHXF(P_0, ref P_1, 21);
	}

	private static string zJnndurvUmIkWvTncCvzkNGPugr(IntPtr P_0, ref BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH P_1)
	{
		return aVeBOiJBxrIBKeVmhUpuojwguHXF(P_0, ref P_1, 1);
	}

	private static string HYccqjaDJwIGnYNObGajcbPhVknB(IntPtr P_0, ref BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH P_1)
	{
		return aVeBOiJBxrIBKeVmhUpuojwguHXF(P_0, ref P_1, 13);
	}

	private static string GofNpKognrDILGfnygJTUtmCLpXE(IntPtr P_0, ref BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH P_1)
	{
		return aVeBOiJBxrIBKeVmhUpuojwguHXF(P_0, ref P_1, 11);
	}

	private static string aVeBOiJBxrIBKeVmhUpuojwguHXF(IntPtr P_0, ref BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH P_1, int P_2)
	{
		int num = 0;
		int num2 = 0;
		BhcxpsOxjdSjSDyqakqjSUDsNCD.ISKgzfAXxceCnDPnbpjdhIJmJcIm(P_0, ref P_1, P_2, ref num2, IntPtr.Zero, 0, ref num);
		if (num == 0)
		{
			return null;
		}
		int num3 = num;
		IntPtr intPtr = Marshal.AllocHGlobal(num3);
		string result = (BhcxpsOxjdSjSDyqakqjSUDsNCD.ISKgzfAXxceCnDPnbpjdhIJmJcIm(P_0, ref P_1, P_2, ref num2, intPtr, num3, ref num) ? XVEfoIWWMSXgvofMnpQvssAyLAW.veqmoECEegRaWsEZjvSbfJUuBZa(intPtr, num3) : string.Empty);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	private static string iRPcXFBZlnSlvNORvIGXYrBmCDIC(IntPtr P_0, ref BhcxpsOxjdSjSDyqakqjSUDsNCD.TaMBfaJbQIRDdYNzXGCGskaYhLH P_1)
	{
		if (Environment.OSVersion.Version.Major <= 5)
		{
			return null;
		}
		ulong num = 0uL;
		int num2 = 0;
		BhcxpsOxjdSjSDyqakqjSUDsNCD.lRpKZYNDWTxOQYZIiwQtZSMHKTH(P_0, ref P_1, ref BhcxpsOxjdSjSDyqakqjSUDsNCD.LVDqTbgdIjmrnoxKZGKvWCSLAVi, ref num, IntPtr.Zero, 0, ref num2, 0u);
		if (num2 == 0)
		{
			return string.Empty;
		}
		int num3 = num2;
		IntPtr intPtr = Marshal.AllocHGlobal(num3);
		string result = (BhcxpsOxjdSjSDyqakqjSUDsNCD.lRpKZYNDWTxOQYZIiwQtZSMHKTH(P_0, ref P_1, ref BhcxpsOxjdSjSDyqakqjSUDsNCD.LVDqTbgdIjmrnoxKZGKvWCSLAVi, ref num, intPtr, num3, ref num2, 0u) ? XVEfoIWWMSXgvofMnpQvssAyLAW.veqmoECEegRaWsEZjvSbfJUuBZa(intPtr, num3) : null);
		Marshal.FreeHGlobal(intPtr);
		return result;
	}

	[CompilerGenerated]
	private static tJKAaDrvDYPmVdvOWTbYhAqgFPi HeKGonHHxSLvvzUehHBKAZWKoDMh(kMLkQRKYstAbZAxsysaYBfvsVfD P_0)
	{
		return new tJKAaDrvDYPmVdvOWTbYhAqgFPi(P_0.lAwMHnSHLfaOPMNsYlOuvaGzOWt, P_0.HWpkoLElvmTfaUmHEmBxsOPncRl, P_0.qRzhgqdfsMGDjWPnzjIyTYzrZEJ, P_0.LWqGjrmjrdoEvwlpDmluwkYhGtf, P_0.xYsppkfjaolZMHUcQNpbPXOTiSP, P_0.RfSQCsUPTyQuJvOlwOqZtTDxEw, P_0.cjOWzBCMkHIxRWceNYEqTjupNms, P_0.AhHrqrQkLzCLgDcoKPqTNKyjQNgv);
	}

	[CompilerGenerated]
	private static tJKAaDrvDYPmVdvOWTbYhAqgFPi prBDPlqmvHVcdBfMoLsdnBNjETp(kMLkQRKYstAbZAxsysaYBfvsVfD P_0)
	{
		return new tJKAaDrvDYPmVdvOWTbYhAqgFPi(P_0.lAwMHnSHLfaOPMNsYlOuvaGzOWt, P_0.HWpkoLElvmTfaUmHEmBxsOPncRl, P_0.qRzhgqdfsMGDjWPnzjIyTYzrZEJ, P_0.LWqGjrmjrdoEvwlpDmluwkYhGtf, P_0.xYsppkfjaolZMHUcQNpbPXOTiSP, P_0.RfSQCsUPTyQuJvOlwOqZtTDxEw, P_0.cjOWzBCMkHIxRWceNYEqTjupNms, P_0.AhHrqrQkLzCLgDcoKPqTNKyjQNgv);
	}

	[CompilerGenerated]
	private static tJKAaDrvDYPmVdvOWTbYhAqgFPi fPGPIZLpyKQkWFuOhPjoQKJriTm(kMLkQRKYstAbZAxsysaYBfvsVfD P_0)
	{
		return new tJKAaDrvDYPmVdvOWTbYhAqgFPi(P_0.lAwMHnSHLfaOPMNsYlOuvaGzOWt, P_0.HWpkoLElvmTfaUmHEmBxsOPncRl, P_0.qRzhgqdfsMGDjWPnzjIyTYzrZEJ, P_0.LWqGjrmjrdoEvwlpDmluwkYhGtf, P_0.xYsppkfjaolZMHUcQNpbPXOTiSP, P_0.RfSQCsUPTyQuJvOlwOqZtTDxEw, P_0.cjOWzBCMkHIxRWceNYEqTjupNms, P_0.AhHrqrQkLzCLgDcoKPqTNKyjQNgv);
	}

	[CompilerGenerated]
	private static tJKAaDrvDYPmVdvOWTbYhAqgFPi IMpPXUlxOWQQYnEPUIlLAxyjDHs(kMLkQRKYstAbZAxsysaYBfvsVfD P_0)
	{
		return new tJKAaDrvDYPmVdvOWTbYhAqgFPi(P_0.lAwMHnSHLfaOPMNsYlOuvaGzOWt, P_0.HWpkoLElvmTfaUmHEmBxsOPncRl, P_0.qRzhgqdfsMGDjWPnzjIyTYzrZEJ, P_0.LWqGjrmjrdoEvwlpDmluwkYhGtf, P_0.xYsppkfjaolZMHUcQNpbPXOTiSP, P_0.RfSQCsUPTyQuJvOlwOqZtTDxEw, P_0.cjOWzBCMkHIxRWceNYEqTjupNms, P_0.AhHrqrQkLzCLgDcoKPqTNKyjQNgv);
	}
}
