using System;
using System.Runtime.InteropServices;
using System.Security;
using Rewired.Utils.Attributes;
using Rewired.Utils.Classes.Utility;

internal class iDxdeTNcZIetTcswDuZFhoDBYPo : IDisposable
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate IntPtr KKIEjjaeKeXuNtYqIevqXZTWmry(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct asPhmQCotZtHbOWhTVuJOsphxzm
	{
		public uint yhcdexDNnoLDQHpZuPAVXlrGaSg;

		public IntPtr DTouShrMogvmfwhgXBlQgkCtKNxP;

		public int zUJkGEAQRiGThIDVZQTiliPDvIp;

		public int ezgRGwhEmQzDixEpofBzYFBVSUO;

		public IntPtr ORzFPknksURMDhFVYFlmsNPbYVL;

		public IntPtr IGsbZKeIBJmKWvLBpYaCNMZFMPrP;

		public IntPtr RkjHdiJNfJyiGtbWhuLwPhOhOdm;

		public IntPtr WtVHHMVqykNoJCUQhAsOQoMkMLZ;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string sEZPiiYjnVqVxQujlynKKRgZAZT;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string pthlCXAxEWImjzBFNQCwgoMVtRS;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct YFoxOUZxPgmjvucnehcHLGRLzfj
	{
		public IntPtr bHMLjJxRbMRonHpGUCKpFdfhzaJE;

		public IntPtr ORzFPknksURMDhFVYFlmsNPbYVL;

		public IntPtr DNgbMXspwvzIJeFWPMDmoEtfjmo;

		public IntPtr hhwKVrwskvAeWjQQxiMqPuftSku;

		public int gBKNeKSCElhdlVCSINiQVmEWAPW;

		public int JhVhiFpZjPOokmggYUDrOfrtyBY;

		public int ZVnCDqHFiPtAfFwySHfFJzLdSYpt;

		public int fdcCcwdHpvxPYBpcdbZdtoGFAzzB;

		public int yhcdexDNnoLDQHpZuPAVXlrGaSg;

		public IntPtr cgfhdjEFqgkOFEdZOPXRafEpqLsi;

		public IntPtr QPrSkRUQxzhnSWMRttUwWhqfQPj;

		public uint tMgoglRtAaCRfVlpjWfhijyhAGMB;
	}

	private const int pRkRcTSRbgjCuojQLtjKhltQelu = 20;

	private const int SQUuuAlLyEHGAICZDdVzgoswkgOL = 1410;

	private readonly ushort YQFTSDnOgbaVMvOlRIPWIzqCQgm;

	private readonly string hwqqVLLfAcsmiqoVhTVdLfBMcBUj;

	private bool VXEyLVzyPGDSVmwOLkjYmKSqhqC;

	private IntPtr pphczesYQSqmIqKtwfFrdYwgiQQK;

	private int MxMCKyKEjPaiIiSVtAmSLNBNNeB;

	private uint QcXbsFUjQlzmdlmNnRCVrSyNbTZ;

	private KKIEjjaeKeXuNtYqIevqXZTWmry CTqXlJhpOAFHgmjAuxdGaXGfCmX;

	private KKIEjjaeKeXuNtYqIevqXZTWmry BkflVaowixmYtWDukstFkEyzCWwG;

	public IntPtr APllICJNRJmhlyPnfYfDTmikppa => pphczesYQSqmIqKtwfFrdYwgiQQK;

	public uint hkuuticbdaiiOEKiYDjQVEiTXcS => QcXbsFUjQlzmdlmNnRCVrSyNbTZ;

	public bool tmBlyWxWyTEpQvVAqPrCTldYDHSB
	{
		get
		{
			if (!(pphczesYQSqmIqKtwfFrdYwgiQQK != IntPtr.Zero))
			{
				return false;
			}
			return wikLmTMDckfCnLHsfewfHRzwciM(pphczesYQSqmIqKtwfFrdYwgiQQK);
		}
	}

	[DllImport("user32.dll", EntryPoint = "RegisterClassW", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern ushort QJhrzHidIRHDyAbReKvVpKIjliM([In] ref asPhmQCotZtHbOWhTVuJOsphxzm P_0);

	[DllImport("user32.dll", EntryPoint = "UnregisterClassW", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool YTKaMMgqZDwngFbqLxMcmsWehCqY([MarshalAs(UnmanagedType.LPWStr)] string P_0, IntPtr P_1);

	[DllImport("user32.dll", EntryPoint = "CreateWindowExW", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern IntPtr xuWdNkLJmxBPPhsjIdJOmYNyGCm(uint P_0, [MarshalAs(UnmanagedType.LPWStr)] string P_1, [MarshalAs(UnmanagedType.LPWStr)] string P_2, uint P_3, int P_4, int P_5, int P_6, int P_7, IntPtr P_8, IntPtr P_9, IntPtr P_10, IntPtr P_11);

	[DllImport("user32.dll", EntryPoint = "DefWindowProcW", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern IntPtr bOAFXwPIWfsCDUTdGttotaaLpKV(IntPtr P_0, uint P_1, IntPtr P_2, IntPtr P_3);

	[DllImport("user32.dll", EntryPoint = "DestroyWindow", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool BAjDBPJxNfbgzOwSkqImdgIYdtUQ(IntPtr P_0);

	[DllImport("user32.dll", EntryPoint = "IsWindow", SetLastError = true)]
	[SuppressUnmanagedCodeSecurity]
	private static extern bool wikLmTMDckfCnLHsfewfHRzwciM(IntPtr P_0);

	public void Dispose()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
		GC.SuppressFinalize(this);
	}

	~iDxdeTNcZIetTcswDuZFhoDBYPo()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
	}

	private void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (!VXEyLVzyPGDSVmwOLkjYmKSqhqC)
		{
			if (P_0)
			{
				ObjectInstanceTracker.Default.Unregister(QcXbsFUjQlzmdlmNnRCVrSyNbTZ);
			}
			if (pphczesYQSqmIqKtwfFrdYwgiQQK != IntPtr.Zero)
			{
				BAjDBPJxNfbgzOwSkqImdgIYdtUQ(pphczesYQSqmIqKtwfFrdYwgiQQK);
				pphczesYQSqmIqKtwfFrdYwgiQQK = IntPtr.Zero;
			}
			if (YQFTSDnOgbaVMvOlRIPWIzqCQgm != 0 && !string.IsNullOrEmpty(hwqqVLLfAcsmiqoVhTVdLfBMcBUj))
			{
				YTKaMMgqZDwngFbqLxMcmsWehCqY(hwqqVLLfAcsmiqoVhTVdLfBMcBUj, IntPtr.Zero);
			}
			VXEyLVzyPGDSVmwOLkjYmKSqhqC = true;
		}
	}

	public iDxdeTNcZIetTcswDuZFhoDBYPo(string className, bool createMessageOnlyWindow, KKIEjjaeKeXuNtYqIevqXZTWmry staticCustomWndProcDelegate)
	{
		if (string.IsNullOrEmpty(className))
		{
			throw new ArgumentNullException("className");
		}
		if (staticCustomWndProcDelegate == null)
		{
			throw new ArgumentNullException("staticCustomWndProcDelegate");
		}
		QcXbsFUjQlzmdlmNnRCVrSyNbTZ = ObjectInstanceTracker.Default.Register(this);
		hwqqVLLfAcsmiqoVhTVdLfBMcBUj = className;
		CTqXlJhpOAFHgmjAuxdGaXGfCmX = rOBSZUolRfSVmjSLFOJlwJkRCpR;
		BkflVaowixmYtWDukstFkEyzCWwG = staticCustomWndProcDelegate;
		MxMCKyKEjPaiIiSVtAmSLNBNNeB = 0;
		asPhmQCotZtHbOWhTVuJOsphxzm asPhmQCotZtHbOWhTVuJOsphxzm = new asPhmQCotZtHbOWhTVuJOsphxzm
		{
			DTouShrMogvmfwhgXBlQgkCtKNxP = Marshal.GetFunctionPointerForDelegate((Delegate)CTqXlJhpOAFHgmjAuxdGaXGfCmX)
		};
		while (YQFTSDnOgbaVMvOlRIPWIzqCQgm == 0 && MxMCKyKEjPaiIiSVtAmSLNBNNeB < 20)
		{
			asPhmQCotZtHbOWhTVuJOsphxzm.pthlCXAxEWImjzBFNQCwgoMVtRS = className;
			YQFTSDnOgbaVMvOlRIPWIzqCQgm = QJhrzHidIRHDyAbReKvVpKIjliM(ref asPhmQCotZtHbOWhTVuJOsphxzm);
			if (YQFTSDnOgbaVMvOlRIPWIzqCQgm != 0)
			{
				break;
			}
			MxMCKyKEjPaiIiSVtAmSLNBNNeB++;
			className = hwqqVLLfAcsmiqoVhTVdLfBMcBUj + MxMCKyKEjPaiIiSVtAmSLNBNNeB;
		}
		if (YQFTSDnOgbaVMvOlRIPWIzqCQgm == 0)
		{
			throw new Exception("Could not register window class!");
		}
		if (hwqqVLLfAcsmiqoVhTVdLfBMcBUj != className)
		{
			hwqqVLLfAcsmiqoVhTVdLfBMcBUj = className;
		}
		if (createMessageOnlyWindow)
		{
			pphczesYQSqmIqKtwfFrdYwgiQQK = dBKVowJCOvAQAnyqNBQgssIgXRI(className, new IntPtr((int)QcXbsFUjQlzmdlmNnRCVrSyNbTZ));
		}
		else
		{
			pphczesYQSqmIqKtwfFrdYwgiQQK = lKgVRghQPZjlFDCTQsfOjWichzz(className, new IntPtr((int)QcXbsFUjQlzmdlmNnRCVrSyNbTZ));
		}
	}

	private IntPtr lKgVRghQPZjlFDCTQsfOjWichzz(string P_0, IntPtr P_1)
	{
		return xuWdNkLJmxBPPhsjIdJOmYNyGCm(0u, P_0, string.Empty, 0u, 0, 0, 0, 0, IntPtr.Zero, IntPtr.Zero, IntPtr.Zero, P_1);
	}

	private IntPtr dBKVowJCOvAQAnyqNBQgssIgXRI(string P_0, IntPtr P_1)
	{
		return xuWdNkLJmxBPPhsjIdJOmYNyGCm(0u, P_0, string.Empty, 0u, 0, 0, 0, 0, VEdhoLaqZqTiAlYgElsfdGsPTuKQ.IMdLIojGRDZHYlwcnNWvwpGeMCZ, IntPtr.Zero, IntPtr.Zero, P_1);
	}

	[MonoPInvokeCallback(typeof(KKIEjjaeKeXuNtYqIevqXZTWmry))]
	private unsafe static IntPtr rOBSZUolRfSVmjSLFOJlwJkRCpR(IntPtr P_0, uint P_1, IntPtr P_2, IntPtr P_3)
	{
		if (P_0 == IntPtr.Zero)
		{
			return bOAFXwPIWfsCDUTdGttotaaLpKV(P_0, P_1, P_2, P_3);
		}
		bool flag = false;
		uint instanceId = 0u;
		if (P_1 == 1)
		{
			YFoxOUZxPgmjvucnehcHLGRLzfj* ptr = (YFoxOUZxPgmjvucnehcHLGRLzfj*)(void*)P_3;
			if (ptr->bHMLjJxRbMRonHpGUCKpFdfhzaJE != IntPtr.Zero)
			{
				FzngAIhKGFOAkXUDRNTZlbDTVEc.YwHvapTITEIctfMeLfSODRrCQwr(P_0, -21, ptr->bHMLjJxRbMRonHpGUCKpFdfhzaJE);
			}
		}
		else
		{
			instanceId = (uint)FzngAIhKGFOAkXUDRNTZlbDTVEc.bXplLxoFqlRTkexeZFjbBcnMMNh(P_0, -21).ToInt32();
			flag = true;
		}
		if (flag && ObjectInstanceTracker.Default.TryGetInstance<iDxdeTNcZIetTcswDuZFhoDBYPo>(instanceId, out var instance))
		{
			instance.BkflVaowixmYtWDukstFkEyzCWwG(P_0, P_1, P_2, P_3);
		}
		return bOAFXwPIWfsCDUTdGttotaaLpKV(P_0, P_1, P_2, P_3);
	}

	public void JefgVwyclCCYjHhdlmUcjDeZlSDO(KKIEjjaeKeXuNtYqIevqXZTWmry P_0)
	{
		BkflVaowixmYtWDukstFkEyzCWwG = P_0;
	}
}
