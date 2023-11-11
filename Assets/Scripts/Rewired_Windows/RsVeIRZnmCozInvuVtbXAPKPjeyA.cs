using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Rewired;
using Rewired.Config;
using Rewired.Data;
using Rewired.HID;
using Rewired.HID.Drivers;
using Rewired.Interfaces;
using Rewired.Internal;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

internal class RsVeIRZnmCozInvuVtbXAPKPjeyA : IDisposable, IInputSource
{
	private class cKnKPKNzJUtauPqUPrerTSauJIU
	{
		public ushort VVKhEsoxaVNbDlJnFgkkijTVHVU;

		public ushort WkPmqxywNefzhmrRdLSQnLATPQH;

		public cKnKPKNzJUtauPqUPrerTSauJIU(ushort usagePage, ushort usage)
		{
			VVKhEsoxaVNbDlJnFgkkijTVHVU = usagePage;
			WkPmqxywNefzhmrRdLSQnLATPQH = usage;
		}
	}

	internal class lcAiWSDmOiUVKJMbHShlNTWioRYu : IDisposable, RAOzdEPdgYzXSunXnEJayhNPEZI
	{
		public const int SUQdEtguzyaZgumQJkGpwARdjNwD = 255;

		private IntPtr lzeDpmAAOiNqLOvyCfFLUFYOFSSX;

		private IntPtr CGqXOdPFpJcSGBPpeSAMSUNWdjFV;

		private CvkFOOwkDoiVMzwmEqmdSMCeKaf cAEjiDbeCAnZGUyPfOvmKOcvlvec;

		private readonly string egYBSoMnTyVkiflXQglpQUBztFC;

		private readonly string oldsdxcMxBkPydmymVttShNUbRDF;

		private readonly string kaXybkqFOhgHSjyeEBvZSHdrHTbD;

		private readonly string QcXbsFUjQlzmdlmNnRCVrSyNbTZ;

		private readonly gkAiPNxlIoLdjalciCqMaecpYwQc TYbNUNClNcUIDpBLYESBSHBQfcCj;

		private readonly string YdOVoRNSvcdeAXvCCYGoQWkLfPr;

		private readonly int wMlFCqBOWevPDhdcebtWgTvRgep;

		private readonly int rbXWPihRiyTNdjvLOxGmwbkLpn;

		private readonly bool kmIeXfwNjbYjBztSPVZwUDFdnFp;

		private readonly string YpbgVUZOzJgJSHnMAehqqZcwvdp;

		private readonly bool ojJtjPgRvQOAKKCWjZWdAsbmcNx;

		private readonly CvkFOOwkDoiVMzwmEqmdSMCeKaf HrFwyYyCDfEpvjipoxWAcpuXhhoh;

		private readonly bcWjvzEjjbIVOGSuNzJcTLmGvjgB[] NQdvGZFnqAtZBRvqzQjQGbPCajh;

		private readonly CZYFsMkvSkgWfFTKtdOnLXPfMqJK[] NgdrGdCGDDbqeBjEFPjXYZUneZO;

		private xNxlsfJtdmLgsLpXvJXvKtxFFzn QDZJbtElXsGykqqSZtDcdQRLBtHh;

		private xNxlsfJtdmLgsLpXvJXvKtxFFzn NNnzDWAdqQQEpVbbPMDuykkglSm;

		[CompilerGenerated]
		private bool QaXahYDvppcDEbLlzezpdsrXOfGb;

		public IntPtr APllICJNRJmhlyPnfYfDTmikppa => CGqXOdPFpJcSGBPpeSAMSUNWdjFV;

		public bool cXanRILtgcmsaTGOGXADvpTxCdda
		{
			[CompilerGenerated]
			get
			{
				return QaXahYDvppcDEbLlzezpdsrXOfGb;
			}
			[CompilerGenerated]
			private set
			{
				QaXahYDvppcDEbLlzezpdsrXOfGb = value;
			}
		}

		public bool fGcvLiXbUIhveYuKHpUprbEcdtk => true;

		public string qRzhgqdfsMGDjWPnzjIyTYzrZEJ => "";

		public CvkFOOwkDoiVMzwmEqmdSMCeKaf INkPMrgmFQHrPoFjcDSDiHJFEiNM => cAEjiDbeCAnZGUyPfOvmKOcvlvec;

		public gkAiPNxlIoLdjalciCqMaecpYwQc KLZsENHavCrIAofHXOTHKQQcpRK => TYbNUNClNcUIDpBLYESBSHBQfcCj;

		public string FbhbjmvDJXhmcRNTPxCMljeDYKl => oldsdxcMxBkPydmymVttShNUbRDF;

		public bool qohGwlGbfglXFJjyfAOYMWFGXGRO
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bcWjvzEjjbIVOGSuNzJcTLmGvjgB[] crZjOGqnQDRcyLAhAdynEGNnLpTI => NQdvGZFnqAtZBRvqzQjQGbPCajh;

		public CZYFsMkvSkgWfFTKtdOnLXPfMqJK[] QHBRMxWXeAijfXWAxOTnsamBcbtK => NgdrGdCGDDbqeBjEFPjXYZUneZO;

		public string OXURyerpNtaSwtnJAUFkhICjCGm => kaXybkqFOhgHSjyeEBvZSHdrHTbD;

		public string HWpkoLElvmTfaUmHEmBxsOPncRl => QcXbsFUjQlzmdlmNnRCVrSyNbTZ;

		public string LWqGjrmjrdoEvwlpDmluwkYhGtf => YdOVoRNSvcdeAXvCCYGoQWkLfPr;

		public int xYsppkfjaolZMHUcQNpbPXOTiSP => wMlFCqBOWevPDhdcebtWgTvRgep;

		public int RfSQCsUPTyQuJvOlwOqZtTDxEw => rbXWPihRiyTNdjvLOxGmwbkLpn;

		public bool cjOWzBCMkHIxRWceNYEqTjupNms => kmIeXfwNjbYjBztSPVZwUDFdnFp;

		public string AhHrqrQkLzCLgDcoKPqTNKyjQNgv => YpbgVUZOzJgJSHnMAehqqZcwvdp;

		public bool OCWCmPnHcwOcAmdfXmQbdEPNbPl => false;

		public event QOFKuFZRXUvbOejdxqOyqEDlFes fyRODQZvhKNUDvfwaBKNUqYQxJV;

		public event LCfWSPslAJOivMfOEnedlPHyoUi VvYvdNYqBDaKiaHHcgPFkOwqjfyH;

		public static lcAiWSDmOiUVKJMbHShlNTWioRYu njKYlSTeKHbMBadDXNjngjveJjCo(IntPtr P_0, string P_1)
		{
			return new lcAiWSDmOiUVKJMbHShlNTWioRYu(P_0, P_1, P_1, "", "", 0, 0, isBluetoothDevice: false, "");
		}

		public lcAiWSDmOiUVKJMbHShlNTWioRYu(IntPtr rawInputDeviceHandle, string devicePath, string instanceId, string description, string manufacturer, int hubId, int portId, bool isBluetoothDevice, string bluetoothDeviceName)
		{
			lzeDpmAAOiNqLOvyCfFLUFYOFSSX = rawInputDeviceHandle;
			try
			{
				oldsdxcMxBkPydmymVttShNUbRDF = devicePath;
				kaXybkqFOhgHSjyeEBvZSHdrHTbD = cmwBGCtbOdnPmdndepyeYPuXGzv.gjlkGeDluPtDgcBqsmPLwnmixfs(devicePath);
				QcXbsFUjQlzmdlmNnRCVrSyNbTZ = instanceId;
				egYBSoMnTyVkiflXQglpQUBztFC = StringTools.SanitizeDeviceString(description);
				YdOVoRNSvcdeAXvCCYGoQWkLfPr = StringTools.SanitizeDeviceString(manufacturer);
				wMlFCqBOWevPDhdcebtWgTvRgep = hubId;
				rbXWPihRiyTNdjvLOxGmwbkLpn = portId;
				kmIeXfwNjbYjBztSPVZwUDFdnFp = isBluetoothDevice;
				YpbgVUZOzJgJSHnMAehqqZcwvdp = StringTools.SanitizeDeviceString(bluetoothDeviceName);
				if (!cXanRILtgcmsaTGOGXADvpTxCdda)
				{
					ojJtjPgRvQOAKKCWjZWdAsbmcNx = true;
					CGqXOdPFpJcSGBPpeSAMSUNWdjFV = rawInputDeviceHandle;
					cXanRILtgcmsaTGOGXADvpTxCdda = true;
				}
				IntPtr cGqXOdPFpJcSGBPpeSAMSUNWdjFV = CGqXOdPFpJcSGBPpeSAMSUNWdjFV;
				cAEjiDbeCAnZGUyPfOvmKOcvlvec = tJKAaDrvDYPmVdvOWTbYhAqgFPi.jctHEbDpqvnsjMxyrebeLnuZCOR(cGqXOdPFpJcSGBPpeSAMSUNWdjFV);
				TYbNUNClNcUIDpBLYESBSHBQfcCj = tJKAaDrvDYPmVdvOWTbYhAqgFPi.dJLAgnDCDeGhnzVGfZnfEAHavpx(cGqXOdPFpJcSGBPpeSAMSUNWdjFV);
				HrFwyYyCDfEpvjipoxWAcpuXhhoh = tJKAaDrvDYPmVdvOWTbYhAqgFPi.jctHEbDpqvnsjMxyrebeLnuZCOR(cGqXOdPFpJcSGBPpeSAMSUNWdjFV);
				NQdvGZFnqAtZBRvqzQjQGbPCajh = tJKAaDrvDYPmVdvOWTbYhAqgFPi.ZFwCAAhWHBecmaMykZfzOruLwZFg(cGqXOdPFpJcSGBPpeSAMSUNWdjFV, 0, HrFwyYyCDfEpvjipoxWAcpuXhhoh.aMsuVHfMHBfNnkZXtZKXkmpjPam);
				NgdrGdCGDDbqeBjEFPjXYZUneZO = tJKAaDrvDYPmVdvOWTbYhAqgFPi.afHrwpqJZRkMSTCUJdgXFlovbeDS(cGqXOdPFpJcSGBPpeSAMSUNWdjFV, 0, HrFwyYyCDfEpvjipoxWAcpuXhhoh.upufVhprprARMODgtaQrkSizdFIA);
				_ = TYbNUNClNcUIDpBLYESBSHBQfcCj;
				_ = HrFwyYyCDfEpvjipoxWAcpuXhhoh;
				_ = NQdvGZFnqAtZBRvqzQjQGbPCajh;
				_ = NgdrGdCGDDbqeBjEFPjXYZUneZO;
			}
			catch (Exception ex)
			{
				throw new Exception($"Error querying HID device \"{devicePath}\" at location {CGqXOdPFpJcSGBPpeSAMSUNWdjFV}.\nException Message: {ex.Message}\nStack Trace: {ex.StackTrace}", ex);
			}
			finally
			{
				try
				{
					JkEpjVookWTcfTioKIiBoqRdEfn();
				}
				catch
				{
				}
			}
		}

		public void yBoBAgfvoDbLIKfCHVvbfaecLSlN()
		{
			yBoBAgfvoDbLIKfCHVvbfaecLSlN(xNxlsfJtdmLgsLpXvJXvKtxFFzn.hpMCzWILToKFZQFQqBmwAbuwPAX, xNxlsfJtdmLgsLpXvJXvKtxFFzn.hpMCzWILToKFZQFQqBmwAbuwPAX, onJfdTGjmuCrmsdvUkFvIZyefBlQ.CGmxvAXqZVdlwwfTOeTPkIDeTOC);
		}

		void RAOzdEPdgYzXSunXnEJayhNPEZI.yBoBAgfvoDbLIKfCHVvbfaecLSlN()
		{
			//ILSpy generated this explicit interface implementation from .override directive in yBoBAgfvoDbLIKfCHVvbfaecLSlN
			this.yBoBAgfvoDbLIKfCHVvbfaecLSlN();
		}

		public void yBoBAgfvoDbLIKfCHVvbfaecLSlN(xNxlsfJtdmLgsLpXvJXvKtxFFzn P_0, xNxlsfJtdmLgsLpXvJXvKtxFFzn P_1, onJfdTGjmuCrmsdvUkFvIZyefBlQ P_2)
		{
			if (ojJtjPgRvQOAKKCWjZWdAsbmcNx)
			{
				cXanRILtgcmsaTGOGXADvpTxCdda = true;
				return;
			}
			QDZJbtElXsGykqqSZtDcdQRLBtHh = P_0;
			NNnzDWAdqQQEpVbbPMDuykkglSm = P_1;
			try
			{
				CGqXOdPFpJcSGBPpeSAMSUNWdjFV = tJKAaDrvDYPmVdvOWTbYhAqgFPi.MzoYxfOdCxFlOXCkNPJXAEKRpwN(oldsdxcMxBkPydmymVttShNUbRDF, P_0, 2147483648u, P_2);
			}
			catch (Exception innerException)
			{
				cXanRILtgcmsaTGOGXADvpTxCdda = false;
				throw new Exception("Error opening HID device.", innerException);
			}
			cXanRILtgcmsaTGOGXADvpTxCdda = CGqXOdPFpJcSGBPpeSAMSUNWdjFV.ToInt32() != -1;
			_ = cXanRILtgcmsaTGOGXADvpTxCdda;
		}

		void RAOzdEPdgYzXSunXnEJayhNPEZI.yBoBAgfvoDbLIKfCHVvbfaecLSlN(xNxlsfJtdmLgsLpXvJXvKtxFFzn P_0, xNxlsfJtdmLgsLpXvJXvKtxFFzn P_1, onJfdTGjmuCrmsdvUkFvIZyefBlQ P_2)
		{
			//ILSpy generated this explicit interface implementation from .override directive in yBoBAgfvoDbLIKfCHVvbfaecLSlN
			this.yBoBAgfvoDbLIKfCHVvbfaecLSlN(P_0, P_1, P_2);
		}

		public void JkEpjVookWTcfTioKIiBoqRdEfn()
		{
			if (ojJtjPgRvQOAKKCWjZWdAsbmcNx)
			{
				cXanRILtgcmsaTGOGXADvpTxCdda = false;
			}
			else if (cXanRILtgcmsaTGOGXADvpTxCdda)
			{
				if (CGqXOdPFpJcSGBPpeSAMSUNWdjFV != IntPtr.Zero)
				{
					tJKAaDrvDYPmVdvOWTbYhAqgFPi.BKZtrMellduMDpkmiJpwOwRCNXs(CGqXOdPFpJcSGBPpeSAMSUNWdjFV);
				}
				cXanRILtgcmsaTGOGXADvpTxCdda = false;
				CGqXOdPFpJcSGBPpeSAMSUNWdjFV = IntPtr.Zero;
			}
		}

		void RAOzdEPdgYzXSunXnEJayhNPEZI.JkEpjVookWTcfTioKIiBoqRdEfn()
		{
			//ILSpy generated this explicit interface implementation from .override directive in JkEpjVookWTcfTioKIiBoqRdEfn
			this.JkEpjVookWTcfTioKIiBoqRdEfn();
		}

		public VuyNBgYHyJnrsISOyMaOknkdeBy BJrAAaIAGcmOVdfUIHHCJXemriPD()
		{
			return null;
		}

		VuyNBgYHyJnrsISOyMaOknkdeBy RAOzdEPdgYzXSunXnEJayhNPEZI.BJrAAaIAGcmOVdfUIHHCJXemriPD()
		{
			//ILSpy generated this explicit interface implementation from .override directive in BJrAAaIAGcmOVdfUIHHCJXemriPD
			return this.BJrAAaIAGcmOVdfUIHHCJXemriPD();
		}

		public void BJrAAaIAGcmOVdfUIHHCJXemriPD(JMrYSJaDLqzSnDVXoDoGIAKBYRl P_0)
		{
		}

		void RAOzdEPdgYzXSunXnEJayhNPEZI.BJrAAaIAGcmOVdfUIHHCJXemriPD(JMrYSJaDLqzSnDVXoDoGIAKBYRl P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in BJrAAaIAGcmOVdfUIHHCJXemriPD
			this.BJrAAaIAGcmOVdfUIHHCJXemriPD(P_0);
		}

		public VuyNBgYHyJnrsISOyMaOknkdeBy BJrAAaIAGcmOVdfUIHHCJXemriPD(int P_0)
		{
			return null;
		}

		VuyNBgYHyJnrsISOyMaOknkdeBy RAOzdEPdgYzXSunXnEJayhNPEZI.BJrAAaIAGcmOVdfUIHHCJXemriPD(int P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in BJrAAaIAGcmOVdfUIHHCJXemriPD
			return this.BJrAAaIAGcmOVdfUIHHCJXemriPD(P_0);
		}

		public void bOdURZibPXuaCCcXsyLwFMGIprJ(hNbLqGVEUUGeJyXGsbluBskPBFnF P_0)
		{
		}

		void RAOzdEPdgYzXSunXnEJayhNPEZI.bOdURZibPXuaCCcXsyLwFMGIprJ(hNbLqGVEUUGeJyXGsbluBskPBFnF P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in bOdURZibPXuaCCcXsyLwFMGIprJ
			this.bOdURZibPXuaCCcXsyLwFMGIprJ(P_0);
		}

		public aFqhkbCvLIRpNtuindhxODvGngeT bOdURZibPXuaCCcXsyLwFMGIprJ(int P_0)
		{
			return null;
		}

		aFqhkbCvLIRpNtuindhxODvGngeT RAOzdEPdgYzXSunXnEJayhNPEZI.bOdURZibPXuaCCcXsyLwFMGIprJ(int P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in bOdURZibPXuaCCcXsyLwFMGIprJ
			return this.bOdURZibPXuaCCcXsyLwFMGIprJ(P_0);
		}

		public aFqhkbCvLIRpNtuindhxODvGngeT bOdURZibPXuaCCcXsyLwFMGIprJ()
		{
			return null;
		}

		aFqhkbCvLIRpNtuindhxODvGngeT RAOzdEPdgYzXSunXnEJayhNPEZI.bOdURZibPXuaCCcXsyLwFMGIprJ()
		{
			//ILSpy generated this explicit interface implementation from .override directive in bOdURZibPXuaCCcXsyLwFMGIprJ
			return this.bOdURZibPXuaCCcXsyLwFMGIprJ();
		}

		public bool ttKgMiVjmboGrHWEjBPYEXevCMK(out byte[] P_0, byte P_1 = 0)
		{
			if (ojJtjPgRvQOAKKCWjZWdAsbmcNx)
			{
				P_0 = null;
				return false;
			}
			if (HrFwyYyCDfEpvjipoxWAcpuXhhoh.QsfDgRITPMzaePotWraKEIzOjvw <= 0)
			{
				P_0 = new byte[0];
				return false;
			}
			P_0 = new byte[HrFwyYyCDfEpvjipoxWAcpuXhhoh.QsfDgRITPMzaePotWraKEIzOjvw];
			byte[] array = iyZWuywAGdVdEsxVNmxJcahQYzg();
			array[0] = P_1;
			IntPtr intPtr = IntPtr.Zero;
			bool flag = false;
			try
			{
				if (cXanRILtgcmsaTGOGXADvpTxCdda)
				{
					intPtr = APllICJNRJmhlyPnfYfDTmikppa;
				}
				else
				{
					intPtr = tJKAaDrvDYPmVdvOWTbYhAqgFPi.MzoYxfOdCxFlOXCkNPJXAEKRpwN(oldsdxcMxBkPydmymVttShNUbRDF, 0u);
					if (intPtr.ToInt32() == -1)
					{
						return false;
					}
				}
				flag = BhcxpsOxjdSjSDyqakqjSUDsNCD.MhYmEQEgEWUlnTCRjPVRLcAOIaG(intPtr, array, array.Length);
				if (flag)
				{
					Array.Copy(array, 0, P_0, 0, Math.Min(P_0.Length, HrFwyYyCDfEpvjipoxWAcpuXhhoh.QsfDgRITPMzaePotWraKEIzOjvw));
					return flag;
				}
				return flag;
			}
			catch (Exception innerException)
			{
				throw new Exception($"Error accessing HID device '{oldsdxcMxBkPydmymVttShNUbRDF}'.", innerException);
			}
			finally
			{
				if (!cXanRILtgcmsaTGOGXADvpTxCdda && intPtr.ToInt32() != -1)
				{
					tJKAaDrvDYPmVdvOWTbYhAqgFPi.BKZtrMellduMDpkmiJpwOwRCNXs(intPtr);
				}
			}
		}

		bool RAOzdEPdgYzXSunXnEJayhNPEZI.ttKgMiVjmboGrHWEjBPYEXevCMK(out byte[] P_0, byte P_1 = 0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in ttKgMiVjmboGrHWEjBPYEXevCMK
			return this.ttKgMiVjmboGrHWEjBPYEXevCMK(out P_0, P_1);
		}

		public string nEasBJFqEhSbcpbFCPuctlxPYDE()
		{
			if (ojJtjPgRvQOAKKCWjZWdAsbmcNx)
			{
				return string.Empty;
			}
			try
			{
				if (!nEasBJFqEhSbcpbFCPuctlxPYDE(out var bytes))
				{
					return string.Empty;
				}
				return StringTools.SanitizeDeviceString(StringTools.GetNullTerminatedUnicodeString(bytes));
			}
			catch (Exception)
			{
				return string.Empty;
			}
		}

		string RAOzdEPdgYzXSunXnEJayhNPEZI.nEasBJFqEhSbcpbFCPuctlxPYDE()
		{
			//ILSpy generated this explicit interface implementation from .override directive in nEasBJFqEhSbcpbFCPuctlxPYDE
			return this.nEasBJFqEhSbcpbFCPuctlxPYDE();
		}

		public unsafe bool nEasBJFqEhSbcpbFCPuctlxPYDE(out byte[] P_0)
		{
			if (ojJtjPgRvQOAKKCWjZWdAsbmcNx)
			{
				P_0 = null;
				return false;
			}
			P_0 = new byte[255];
			IntPtr intPtr = IntPtr.Zero;
			bool flag = false;
			try
			{
				if (cXanRILtgcmsaTGOGXADvpTxCdda)
				{
					intPtr = APllICJNRJmhlyPnfYfDTmikppa;
				}
				else
				{
					intPtr = tJKAaDrvDYPmVdvOWTbYhAqgFPi.MzoYxfOdCxFlOXCkNPJXAEKRpwN(oldsdxcMxBkPydmymVttShNUbRDF, 0u);
					if (intPtr.ToInt32() == -1)
					{
						return false;
					}
				}
				fixed (IntPtr* ptr = P_0)
				{
					return BhcxpsOxjdSjSDyqakqjSUDsNCD.VZUdahfqKpMmZaOqXINFveMbGPW(intPtr, (IntPtr)ptr, P_0.Length);
				}
			}
			catch (Exception innerException)
			{
				throw new Exception($"Error accessing HID device '{oldsdxcMxBkPydmymVttShNUbRDF}'.", innerException);
			}
			finally
			{
				if (!cXanRILtgcmsaTGOGXADvpTxCdda && intPtr.ToInt32() != -1)
				{
					tJKAaDrvDYPmVdvOWTbYhAqgFPi.BKZtrMellduMDpkmiJpwOwRCNXs(intPtr);
				}
			}
		}

		bool RAOzdEPdgYzXSunXnEJayhNPEZI.nEasBJFqEhSbcpbFCPuctlxPYDE(out byte[] P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in nEasBJFqEhSbcpbFCPuctlxPYDE
			return this.nEasBJFqEhSbcpbFCPuctlxPYDE(out P_0);
		}

		public string fswGixpMLCFOsklHTygAnZQbFvN()
		{
			if (ojJtjPgRvQOAKKCWjZWdAsbmcNx)
			{
				return string.Empty;
			}
			fswGixpMLCFOsklHTygAnZQbFvN(out var bytes);
			return StringTools.SanitizeDeviceString(StringTools.GetNullTerminatedUnicodeString(bytes));
		}

		string RAOzdEPdgYzXSunXnEJayhNPEZI.fswGixpMLCFOsklHTygAnZQbFvN()
		{
			//ILSpy generated this explicit interface implementation from .override directive in fswGixpMLCFOsklHTygAnZQbFvN
			return this.fswGixpMLCFOsklHTygAnZQbFvN();
		}

		public bool fswGixpMLCFOsklHTygAnZQbFvN(out byte[] P_0)
		{
			if (ojJtjPgRvQOAKKCWjZWdAsbmcNx)
			{
				P_0 = null;
				return false;
			}
			P_0 = new byte[255];
			IntPtr intPtr = IntPtr.Zero;
			bool flag = false;
			try
			{
				if (cXanRILtgcmsaTGOGXADvpTxCdda)
				{
					intPtr = APllICJNRJmhlyPnfYfDTmikppa;
				}
				else
				{
					intPtr = tJKAaDrvDYPmVdvOWTbYhAqgFPi.MzoYxfOdCxFlOXCkNPJXAEKRpwN(oldsdxcMxBkPydmymVttShNUbRDF, 0u);
					if (intPtr.ToInt32() == -1)
					{
						return false;
					}
				}
				GCHandle gCHandle = GCHandle.Alloc(P_0, GCHandleType.Pinned);
				flag = BhcxpsOxjdSjSDyqakqjSUDsNCD.BadeqPGSioAsLYGJvvkWJqgarJmo(intPtr, gCHandle.AddrOfPinnedObject(), P_0.Length);
				GC.KeepAlive(gCHandle);
				gCHandle.Free();
				return flag;
			}
			catch (Exception innerException)
			{
				throw new Exception($"Error accessing HID device '{oldsdxcMxBkPydmymVttShNUbRDF}'.", innerException);
			}
			finally
			{
				if (!cXanRILtgcmsaTGOGXADvpTxCdda && intPtr.ToInt32() != -1)
				{
					tJKAaDrvDYPmVdvOWTbYhAqgFPi.BKZtrMellduMDpkmiJpwOwRCNXs(intPtr);
				}
			}
		}

		bool RAOzdEPdgYzXSunXnEJayhNPEZI.fswGixpMLCFOsklHTygAnZQbFvN(out byte[] P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in fswGixpMLCFOsklHTygAnZQbFvN
			return this.fswGixpMLCFOsklHTygAnZQbFvN(out P_0);
		}

		public string MCnhPwQsPweeoGCMVvFKmkJzwMS()
		{
			if (ojJtjPgRvQOAKKCWjZWdAsbmcNx)
			{
				return string.Empty;
			}
			MCnhPwQsPweeoGCMVvFKmkJzwMS(out var bytes);
			return StringTools.SanitizeDeviceString(StringTools.GetNullTerminatedUnicodeString(bytes));
		}

		string RAOzdEPdgYzXSunXnEJayhNPEZI.MCnhPwQsPweeoGCMVvFKmkJzwMS()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MCnhPwQsPweeoGCMVvFKmkJzwMS
			return this.MCnhPwQsPweeoGCMVvFKmkJzwMS();
		}

		public bool MCnhPwQsPweeoGCMVvFKmkJzwMS(out byte[] P_0)
		{
			if (ojJtjPgRvQOAKKCWjZWdAsbmcNx)
			{
				P_0 = null;
				return false;
			}
			IntPtr intPtr = IntPtr.Zero;
			bool flag = false;
			try
			{
				if (cXanRILtgcmsaTGOGXADvpTxCdda)
				{
					intPtr = APllICJNRJmhlyPnfYfDTmikppa;
				}
				else
				{
					intPtr = tJKAaDrvDYPmVdvOWTbYhAqgFPi.MzoYxfOdCxFlOXCkNPJXAEKRpwN(oldsdxcMxBkPydmymVttShNUbRDF, 0u);
					if (intPtr.ToInt32() == -1)
					{
						P_0 = null;
						return false;
					}
				}
				return tJKAaDrvDYPmVdvOWTbYhAqgFPi.MCnhPwQsPweeoGCMVvFKmkJzwMS(intPtr, out P_0);
			}
			catch (Exception innerException)
			{
				throw new Exception($"Error accessing HID device '{oldsdxcMxBkPydmymVttShNUbRDF}'.", innerException);
			}
			finally
			{
				if (!cXanRILtgcmsaTGOGXADvpTxCdda && intPtr.ToInt32() != -1)
				{
					tJKAaDrvDYPmVdvOWTbYhAqgFPi.BKZtrMellduMDpkmiJpwOwRCNXs(intPtr);
				}
			}
		}

		bool RAOzdEPdgYzXSunXnEJayhNPEZI.MCnhPwQsPweeoGCMVvFKmkJzwMS(out byte[] P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in MCnhPwQsPweeoGCMVvFKmkJzwMS
			return this.MCnhPwQsPweeoGCMVvFKmkJzwMS(out P_0);
		}

		public string UrRqRbafBwEVfBoDpoOnCfahglNt()
		{
			return "";
		}

		string RAOzdEPdgYzXSunXnEJayhNPEZI.UrRqRbafBwEVfBoDpoOnCfahglNt()
		{
			//ILSpy generated this explicit interface implementation from .override directive in UrRqRbafBwEVfBoDpoOnCfahglNt
			return this.UrRqRbafBwEVfBoDpoOnCfahglNt();
		}

		public bool UrRqRbafBwEVfBoDpoOnCfahglNt(out byte[] P_0)
		{
			P_0 = null;
			return false;
		}

		bool RAOzdEPdgYzXSunXnEJayhNPEZI.UrRqRbafBwEVfBoDpoOnCfahglNt(out byte[] P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in UrRqRbafBwEVfBoDpoOnCfahglNt
			return this.UrRqRbafBwEVfBoDpoOnCfahglNt(out P_0);
		}

		public void klxMdkMazIUJPUlFFCZeFKzabgc(byte[] P_0, CQsRwIhVXJgFpxfBKwGqgnjBCmV P_1)
		{
		}

		void RAOzdEPdgYzXSunXnEJayhNPEZI.klxMdkMazIUJPUlFFCZeFKzabgc(byte[] P_0, CQsRwIhVXJgFpxfBKwGqgnjBCmV P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in klxMdkMazIUJPUlFFCZeFKzabgc
			this.klxMdkMazIUJPUlFFCZeFKzabgc(P_0, P_1);
		}

		public bool klxMdkMazIUJPUlFFCZeFKzabgc(byte[] P_0)
		{
			return false;
		}

		bool RAOzdEPdgYzXSunXnEJayhNPEZI.klxMdkMazIUJPUlFFCZeFKzabgc(byte[] P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in klxMdkMazIUJPUlFFCZeFKzabgc
			return this.klxMdkMazIUJPUlFFCZeFKzabgc(P_0);
		}

		public bool klxMdkMazIUJPUlFFCZeFKzabgc(byte[] P_0, int P_1)
		{
			return false;
		}

		bool RAOzdEPdgYzXSunXnEJayhNPEZI.klxMdkMazIUJPUlFFCZeFKzabgc(byte[] P_0, int P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in klxMdkMazIUJPUlFFCZeFKzabgc
			return this.klxMdkMazIUJPUlFFCZeFKzabgc(P_0, P_1);
		}

		public void cfMZQkyLvZbZtRKScwmjVjlefdR(aFqhkbCvLIRpNtuindhxODvGngeT P_0, CQsRwIhVXJgFpxfBKwGqgnjBCmV P_1)
		{
		}

		void RAOzdEPdgYzXSunXnEJayhNPEZI.cfMZQkyLvZbZtRKScwmjVjlefdR(aFqhkbCvLIRpNtuindhxODvGngeT P_0, CQsRwIhVXJgFpxfBKwGqgnjBCmV P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in cfMZQkyLvZbZtRKScwmjVjlefdR
			this.cfMZQkyLvZbZtRKScwmjVjlefdR(P_0, P_1);
		}

		public bool cfMZQkyLvZbZtRKScwmjVjlefdR(aFqhkbCvLIRpNtuindhxODvGngeT P_0)
		{
			return false;
		}

		bool RAOzdEPdgYzXSunXnEJayhNPEZI.cfMZQkyLvZbZtRKScwmjVjlefdR(aFqhkbCvLIRpNtuindhxODvGngeT P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in cfMZQkyLvZbZtRKScwmjVjlefdR
			return this.cfMZQkyLvZbZtRKScwmjVjlefdR(P_0);
		}

		public bool cfMZQkyLvZbZtRKScwmjVjlefdR(aFqhkbCvLIRpNtuindhxODvGngeT P_0, int P_1)
		{
			return false;
		}

		bool RAOzdEPdgYzXSunXnEJayhNPEZI.cfMZQkyLvZbZtRKScwmjVjlefdR(aFqhkbCvLIRpNtuindhxODvGngeT P_0, int P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in cfMZQkyLvZbZtRKScwmjVjlefdR
			return this.cfMZQkyLvZbZtRKScwmjVjlefdR(P_0, P_1);
		}

		public aFqhkbCvLIRpNtuindhxODvGngeT SOKtcmbiQFMpzUKqUoJzBYKORPo()
		{
			return null;
		}

		aFqhkbCvLIRpNtuindhxODvGngeT RAOzdEPdgYzXSunXnEJayhNPEZI.SOKtcmbiQFMpzUKqUoJzBYKORPo()
		{
			//ILSpy generated this explicit interface implementation from .override directive in SOKtcmbiQFMpzUKqUoJzBYKORPo
			return this.SOKtcmbiQFMpzUKqUoJzBYKORPo();
		}

		public bool JAoLhxRfmQEWtJSoeBalpQDuLLY(byte[] P_0)
		{
			return false;
		}

		bool RAOzdEPdgYzXSunXnEJayhNPEZI.JAoLhxRfmQEWtJSoeBalpQDuLLY(byte[] P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in JAoLhxRfmQEWtJSoeBalpQDuLLY
			return this.JAoLhxRfmQEWtJSoeBalpQDuLLY(P_0);
		}

		public void Dispose()
		{
		}

		public bool CzNVjrKdRSDpqbOtCpPyrLKKAXdE(OutputReport P_0)
		{
			return false;
		}

		bool RAOzdEPdgYzXSunXnEJayhNPEZI.CzNVjrKdRSDpqbOtCpPyrLKKAXdE(OutputReport P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in CzNVjrKdRSDpqbOtCpPyrLKKAXdE
			return this.CzNVjrKdRSDpqbOtCpPyrLKKAXdE(P_0);
		}

		private byte[] bIHleTrbRUyRaJsWxEUwetyupoSm()
		{
			return LKsPJWbSIPtUFsJdICZDoCUoveS(INkPMrgmFQHrPoFjcDSDiHJFEiNM.raHmdvKpmDzDhFVQwjMIbPuhFjpk - 1);
		}

		private byte[] EqyhFBdmjkOxzBMeAWTgMhksdas()
		{
			return LKsPJWbSIPtUFsJdICZDoCUoveS(INkPMrgmFQHrPoFjcDSDiHJFEiNM.msrPOboQEjhoRAbnHEdkARQpghx - 1);
		}

		private byte[] iyZWuywAGdVdEsxVNmxJcahQYzg()
		{
			return LKsPJWbSIPtUFsJdICZDoCUoveS(INkPMrgmFQHrPoFjcDSDiHJFEiNM.QsfDgRITPMzaePotWraKEIzOjvw - 1);
		}

		private static byte[] LKsPJWbSIPtUFsJdICZDoCUoveS(int P_0)
		{
			byte[] array = null;
			Array.Resize(ref array, P_0 + 1);
			return array;
		}
	}

	[CompilerGenerated]
	private sealed class yfjuLzuCXLOIhYzbXGbCXplHCeKa
	{
		public IList<sYwCgmJInQorTFIIBkpIONhajGKy.kMLkQRKYstAbZAxsysaYBfvsVfD> JAIpEqrDiPgvzooIPyFBANrJQaL;
	}

	[CompilerGenerated]
	private sealed class pmDHJRhLKZuRrcyKPcvzpBrXlde
	{
		public yfjuLzuCXLOIhYzbXGbCXplHCeKa MHKhPwWMzLuYqFoLTvGQnQoKFpE;

		public int WDYLohLGyDgYypJPFSZYNlEBbEt;

		public bool VfprRcDrmYZrKGuIJzNECgnwbBN(string P_0)
		{
			return P_0.Equals(MHKhPwWMzLuYqFoLTvGQnQoKFpE.JAIpEqrDiPgvzooIPyFBANrJQaL[WDYLohLGyDgYypJPFSZYNlEBbEt].WrNGLcwSAEjjKVmOFJJAncYJRVq, StringComparison.OrdinalIgnoreCase);
		}
	}

	[CompilerGenerated]
	private sealed class opSMkyudkqfCZSHMCLIHHovEftj
	{
		public KXNanfFdezOfVOeIdsOvMHQobbRn AppmZZNJIgTHSGlPsrPwLqVWugJ;

		public bool qRCXbMZhkHKqTcEMbfiCmBeyKAP(KXNanfFdezOfVOeIdsOvMHQobbRn P_0)
		{
			return P_0.mXqEWIlGwHZPoKjhftGIspoptJq == AppmZZNJIgTHSGlPsrPwLqVWugJ.mXqEWIlGwHZPoKjhftGIspoptJq;
		}
	}

	[CompilerGenerated]
	private sealed class uCmZwFnOUPCRGWFcuhQvzYUqZHW
	{
		public RAOzdEPdgYzXSunXnEJayhNPEZI uOYPotTIrwGCDJZFyhIOHGDecSJv;

		public byte[] YzVFkwtaXJTXtIWhiscWPPjldcg(byte P_0)
		{
			uOYPotTIrwGCDJZFyhIOHGDecSJv.ttKgMiVjmboGrHWEjBPYEXevCMK(out var result, P_0);
			return result;
		}
	}

	[CompilerGenerated]
	private sealed class zLYbshbuULhygeScxNIdvoanXHQP
	{
		public bool KdbcDclniAHwcHRcqIKpBGfZpsEA;

		public RsVeIRZnmCozInvuVtbXAPKPjeyA uNPbQXVvzYIwDwQbShpWecRbcpNC;

		public void ZXnuxhXrgCAGAtVAGTdmRqNGcli()
		{
			try
			{
				RvMHQisOjyvanvlgzEycFiIzSxN.WmcAFiXIcgzudeMuZFkSiTIyezSz((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)4, jsjfPGYHvJosyLMTZZuHNbEmlut.nyAShQdNKjMlyrkXvEOtZJJJmOJ | jsjfPGYHvJosyLMTZZuHNbEmlut.VAOTDZGpFyiYBCVeiGuPSlhsNrA, uNPbQXVvzYIwDwQbShpWecRbcpNC.EVwOOSIMTJQwAVGTPoUvLIidogS.APllICJNRJmhlyPnfYfDTmikppa);
				RvMHQisOjyvanvlgzEycFiIzSxN.WmcAFiXIcgzudeMuZFkSiTIyezSz((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)5, jsjfPGYHvJosyLMTZZuHNbEmlut.nyAShQdNKjMlyrkXvEOtZJJJmOJ | jsjfPGYHvJosyLMTZZuHNbEmlut.VAOTDZGpFyiYBCVeiGuPSlhsNrA, uNPbQXVvzYIwDwQbShpWecRbcpNC.EVwOOSIMTJQwAVGTPoUvLIidogS.APllICJNRJmhlyPnfYfDTmikppa);
				RvMHQisOjyvanvlgzEycFiIzSxN.WmcAFiXIcgzudeMuZFkSiTIyezSz((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)8, jsjfPGYHvJosyLMTZZuHNbEmlut.nyAShQdNKjMlyrkXvEOtZJJJmOJ | jsjfPGYHvJosyLMTZZuHNbEmlut.VAOTDZGpFyiYBCVeiGuPSlhsNrA, uNPbQXVvzYIwDwQbShpWecRbcpNC.EVwOOSIMTJQwAVGTPoUvLIidogS.APllICJNRJmhlyPnfYfDTmikppa);
				RvMHQisOjyvanvlgzEycFiIzSxN.WmcAFiXIcgzudeMuZFkSiTIyezSz((zUcsEXgRrpTTuylslYMZNHbGVwI)12, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)1, jsjfPGYHvJosyLMTZZuHNbEmlut.nyAShQdNKjMlyrkXvEOtZJJJmOJ | jsjfPGYHvJosyLMTZZuHNbEmlut.VAOTDZGpFyiYBCVeiGuPSlhsNrA, uNPbQXVvzYIwDwQbShpWecRbcpNC.EVwOOSIMTJQwAVGTPoUvLIidogS.APllICJNRJmhlyPnfYfDTmikppa);
			}
			catch
			{
				KdbcDclniAHwcHRcqIKpBGfZpsEA = true;
			}
		}
	}

	[CompilerGenerated]
	private sealed class FZoaoPjvcpFGvitXyMOJrhZFLqF
	{
		public bool KdbcDclniAHwcHRcqIKpBGfZpsEA;

		public void xAwJNCiEAvUYFjQtEYGRPJIJlod()
		{
			try
			{
				RvMHQisOjyvanvlgzEycFiIzSxN.jJQQTqnRxKlreJHDbdGXKirRlUT((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)4);
				RvMHQisOjyvanvlgzEycFiIzSxN.jJQQTqnRxKlreJHDbdGXKirRlUT((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)5);
				RvMHQisOjyvanvlgzEycFiIzSxN.jJQQTqnRxKlreJHDbdGXKirRlUT((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)8);
				RvMHQisOjyvanvlgzEycFiIzSxN.jJQQTqnRxKlreJHDbdGXKirRlUT((zUcsEXgRrpTTuylslYMZNHbGVwI)12, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)1);
			}
			catch
			{
				KdbcDclniAHwcHRcqIKpBGfZpsEA = true;
			}
		}
	}

	[CompilerGenerated]
	private sealed class TDJQMnUvZQIAiHGsMkwMUsPLNwy
	{
		public bool KdbcDclniAHwcHRcqIKpBGfZpsEA;

		public void SWiKgotKTPIEgEzTWJuFohmqwOZ()
		{
			try
			{
				RvMHQisOjyvanvlgzEycFiIzSxN.jJQQTqnRxKlreJHDbdGXKirRlUT((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)2);
			}
			catch
			{
				KdbcDclniAHwcHRcqIKpBGfZpsEA = true;
			}
		}
	}

	[CompilerGenerated]
	private sealed class LGAiXHDCIJktaDiRLzdXsxBUNSX
	{
		public bool KdbcDclniAHwcHRcqIKpBGfZpsEA;

		public RsVeIRZnmCozInvuVtbXAPKPjeyA uNPbQXVvzYIwDwQbShpWecRbcpNC;

		public void XYAbzMyWSHfGJzgKTUJYCnpjyRI()
		{
			try
			{
				RvMHQisOjyvanvlgzEycFiIzSxN.WmcAFiXIcgzudeMuZFkSiTIyezSz((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)2, jsjfPGYHvJosyLMTZZuHNbEmlut.nyAShQdNKjMlyrkXvEOtZJJJmOJ, uNPbQXVvzYIwDwQbShpWecRbcpNC.EVwOOSIMTJQwAVGTPoUvLIidogS.APllICJNRJmhlyPnfYfDTmikppa);
			}
			catch
			{
				KdbcDclniAHwcHRcqIKpBGfZpsEA = true;
			}
		}
	}

	[CompilerGenerated]
	private sealed class EjcEavvwSkMNPKwShXbvujoymw
	{
		public bool KdbcDclniAHwcHRcqIKpBGfZpsEA;

		public RsVeIRZnmCozInvuVtbXAPKPjeyA uNPbQXVvzYIwDwQbShpWecRbcpNC;

		public void fveQwBoaOuAUlyjeIvtFMZeIFXe()
		{
			try
			{
				RvMHQisOjyvanvlgzEycFiIzSxN.WmcAFiXIcgzudeMuZFkSiTIyezSz((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)6, jsjfPGYHvJosyLMTZZuHNbEmlut.nyAShQdNKjMlyrkXvEOtZJJJmOJ, uNPbQXVvzYIwDwQbShpWecRbcpNC.EVwOOSIMTJQwAVGTPoUvLIidogS.APllICJNRJmhlyPnfYfDTmikppa);
			}
			catch
			{
				KdbcDclniAHwcHRcqIKpBGfZpsEA = true;
			}
		}
	}

	[CompilerGenerated]
	private sealed class gjCGcFeCzxEUkGGlSJoYlsgfhGUT
	{
		public bool KdbcDclniAHwcHRcqIKpBGfZpsEA;

		public void clvWAPOfiRFjcjtwukrJnBYGGpgE()
		{
			try
			{
				RvMHQisOjyvanvlgzEycFiIzSxN.jJQQTqnRxKlreJHDbdGXKirRlUT((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)6);
			}
			catch
			{
				KdbcDclniAHwcHRcqIKpBGfZpsEA = true;
			}
		}
	}

	[CompilerGenerated]
	private sealed class TCQIYtERvJDmGBEHgJDElWuotAYD
	{
		public bool KdbcDclniAHwcHRcqIKpBGfZpsEA;

		public RsVeIRZnmCozInvuVtbXAPKPjeyA uNPbQXVvzYIwDwQbShpWecRbcpNC;

		public iDxdeTNcZIetTcswDuZFhoDBYPo.KKIEjjaeKeXuNtYqIevqXZTWmry tBbnbXzCneJwJLuDRilSJSfGSRA;

		public void wJfnqCeIIsBuisJmePExKqoIVhC()
		{
			try
			{
				uNPbQXVvzYIwDwQbShpWecRbcpNC.EVwOOSIMTJQwAVGTPoUvLIidogS = asqLHFOXxfKabJWoXmingDpjhui(tBbnbXzCneJwJLuDRilSJSfGSRA);
				if (uNPbQXVvzYIwDwQbShpWecRbcpNC.EVwOOSIMTJQwAVGTPoUvLIidogS == null)
				{
					throw new Exception();
				}
			}
			catch
			{
				KdbcDclniAHwcHRcqIKpBGfZpsEA = true;
			}
		}
	}

	private const float sYbDRUPZgNKAzaslfoaLMCKHJhA = 0.25f;

	private const float UzUzAyzrOeVOADvvgXbwENALoJr = 1f;

	private List<KXNanfFdezOfVOeIdsOvMHQobbRn> MYIilGlzGtMSBPimluqBFDXADRJ;

	private List<KXNanfFdezOfVOeIdsOvMHQobbRn> dVfQHZBQlRoGgBVZMntUHOsYKhm;

	private ReadOnlyCollection<KXNanfFdezOfVOeIdsOvMHQobbRn> dtbyRUBqedycGjHcAPgFBorWqdE;

	private XDeDuePBuHGGFsspnAzWcBdsCZTB eaBTyDyzTScWXkTAyfSAFNdVACC;

	private xzvsFEmOigBoTAImyDAGzDeOvoX TMjgRIUfmiDNubEorZTytoDVyld;

	private ConfigVars QxJGAIdIaYwUdmeAotwGjhMlngRb;

	private UpdateLoopSetting SUWFuaPhXRNpjQqOeummtAiJjncj;

	private readonly bool VUjjFdeMXVjpMKMhYRosEXhUuLM;

	private readonly bool bERdxQEMngIKTcdezlFBctUJBera;

	private readonly bool ZSJeoeAgfltDyiGQZOstfnhVwtkF;

	private readonly bool iIwUOirxOAPopNHowMFDfsCjcgB;

	private readonly bool zWZMsCvzKDkPpYLNOCFCvmaaPOq;

	private bool ItjCccIbgxppPbpmRVRgfxkXkOLV;

	private bool eVfWUxWGHGlAaYTdzrUYWXftojD;

	private bool sYrdvydtfjLHszVUYNTHmQsLpkB;

	private bool uJoiugGnSiZQnVqgxHdKXSrispe;

	private int TvRNAnoaHwMVCzfXMHwarftPYm;

	private readonly object sASCLGHuXbDiqdETFUiqWNTTBYcm = new object();

	private readonly jPUUxBbiBalctdVqpNrsXDeuyAB aDrIATaHiKqPeBhrEXyogjFIeXCC;

	private int tiQGcKKTPHKqeDUGdLkldoTbuXDe = -1;

	private oSOUlQdLYlWXufXtmhhLTsjyryU pESAFpQGBoTlVGdWQfwAzqmPjIO;

	private IntPtr UapZSQjYJXfytPCzBNUlPGzDeLE;

	private IntPtr IKdgojlJUuCLVAkHaTBeoQGILhCr;

	private ValueWatcher<IntPtr> ACNbYRPUxrBoFdJdUOGFerqBoPfQ;

	private ValueWatcher[] cARGzYpulwIjmdeZOgLNNxAVRgIl;

	private double uXXIqeTWqDSqYYhaFjezIcpWeKQ;

	private iDxdeTNcZIetTcswDuZFhoDBYPo EVwOOSIMTJQwAVGTPoUvLIidogS;

	private RfxKZyetXxToAWAzQvGHXLJrcpQf KhdthfnJoMeaodwdaAsGnSaOzSJ;

	private static KSJklejSjRczvdDJaPlpSMisXAa.iTrlYJNPRfnlwJwFcpcVFCxGDEXg qMclpCKKpzqkHOWOpsKfhWgCyGw;

	private KSJklejSjRczvdDJaPlpSMisXAa.lhOweqQgeBVkcNxcZbiefsqHevf MNpTRkPpWfSEWaPlcEOSixdhdRc;

	private NativeBuffer haneUxMuPPRRrqoFtfIAJVWjzhwb;

	private static Rewired.Internal.GUIText TaIhJmHcIeCkAtoQIBhmCBiIUpLr;

	private static cKnKPKNzJUtauPqUPrerTSauJIU[] hZUrEfFXiHaVjCifApKCXuFiRlp = new cKnKPKNzJUtauPqUPrerTSauJIU[4]
	{
		new cKnKPKNzJUtauPqUPrerTSauJIU(1, 4),
		new cKnKPKNzJUtauPqUPrerTSauJIU(1, 5),
		new cKnKPKNzJUtauPqUPrerTSauJIU(1, 8),
		new cKnKPKNzJUtauPqUPrerTSauJIU(12, 1)
	};

	private readonly MYwKmedBLcNvIZZHCnRMIWoJnsa qaOQzZEmmCWEObGtdbAErZfBpxs = new MYwKmedBLcNvIZZHCnRMIWoJnsa();

	private readonly fEwvYsosGHESMUTjAtCcjZZuQJI nDfyronUGTNreUSTFIFZSmgjkri = new fEwvYsosGHESMUTjAtCcjZZuQJI();

	private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

	[CompilerGenerated]
	private static Action<KXNanfFdezOfVOeIdsOvMHQobbRn> AlWAFLdTLxOsRRQCpXXFGGnUzDVB;

	public static Rewired.Internal.GUIText aQCKkNVqqLvtChZyMGYTgOFWFYc
	{
		get
		{
			if (TaIhJmHcIeCkAtoQIBhmCBiIUpLr != null)
			{
				return TaIhJmHcIeCkAtoQIBhmCBiIUpLr;
			}
			GameObject gameObject = GameObject.Find("DebugScreenLog");
			if (gameObject != null)
			{
				TaIhJmHcIeCkAtoQIBhmCBiIUpLr = gameObject.GetComponent<Rewired.Internal.GUIText>();
			}
			else
			{
				gameObject = new GameObject("DebugScreenLog");
				gameObject.transform.position = Vector3.zero;
				TaIhJmHcIeCkAtoQIBhmCBiIUpLr = gameObject.AddComponent<Rewired.Internal.GUIText>();
				TaIhJmHcIeCkAtoQIBhmCBiIUpLr.anchor = TextAnchor.LowerLeft;
				TaIhJmHcIeCkAtoQIBhmCBiIUpLr.alignment = TextAlignment.Left;
				TaIhJmHcIeCkAtoQIBhmCBiIUpLr.pixelOffset = new Vector2(1200f, 0f);
			}
			return TaIhJmHcIeCkAtoQIBhmCBiIUpLr;
		}
	}

	public event Action OAZXKPPQnwKwiyiwNbDaNUbxQIC
	{
		add
		{
			throw new NotImplementedException();
		}
		remove
		{
			throw new NotImplementedException();
		}
	}

	public RsVeIRZnmCozInvuVtbXAPKPjeyA(ConfigVars configVars, bool handleJoysticks, bool useCustomDrivers, XDeDuePBuHGGFsspnAzWcBdsCZTB unifiedMouse, xzvsFEmOigBoTAImyDAGzDeOvoX unifiedKeyboard)
	{
		try
		{
			QxJGAIdIaYwUdmeAotwGjhMlngRb = configVars;
			SUWFuaPhXRNpjQqOeummtAiJjncj = configVars.updateLoop;
			ACNbYRPUxrBoFdJdUOGFerqBoPfQ = new ValueWatcher<IntPtr>(FzngAIhKGFOAkXUDRNTZlbDTVEc.NPKxqbrJOXBOjYozsbheDTjQCapS(), FzngAIhKGFOAkXUDRNTZlbDTVEc.NPKxqbrJOXBOjYozsbheDTjQCapS, autoTriggerEvent: true);
			ACNbYRPUxrBoFdJdUOGFerqBoPfQ.ChangedEvent += GMwNzuKvvRguCFdANBBvMBVNGXH;
			cARGzYpulwIjmdeZOgLNNxAVRgIl = new ValueWatcher[1] { ACNbYRPUxrBoFdJdUOGFerqBoPfQ };
			bERdxQEMngIKTcdezlFBctUJBera = handleJoysticks;
			zWZMsCvzKDkPpYLNOCFCvmaaPOq = useCustomDrivers;
			eaBTyDyzTScWXkTAyfSAFNdVACC = unifiedMouse;
			TMjgRIUfmiDNubEorZTytoDVyld = unifiedKeyboard;
			ZSJeoeAgfltDyiGQZOstfnhVwtkF = unifiedMouse != null;
			iIwUOirxOAPopNHowMFDfsCjcgB = unifiedKeyboard != null;
			VUjjFdeMXVjpMKMhYRosEXhUuLM = ReInput.isEditor;
			MYIilGlzGtMSBPimluqBFDXADRJ = new List<KXNanfFdezOfVOeIdsOvMHQobbRn>();
			dtbyRUBqedycGjHcAPgFBorWqdE = new ReadOnlyCollection<KXNanfFdezOfVOeIdsOvMHQobbRn>(MYIilGlzGtMSBPimluqBFDXADRJ);
			dVfQHZBQlRoGgBVZMntUHOsYKhm = new List<KXNanfFdezOfVOeIdsOvMHQobbRn>();
			qMclpCKKpzqkHOWOpsKfhWgCyGw = new KSJklejSjRczvdDJaPlpSMisXAa.iTrlYJNPRfnlwJwFcpcVFCxGDEXg
			{
				GXzXGWNfOQnVvTtRWSNdFASkppo = (uint)Marshal.SizeOf(typeof(KSJklejSjRczvdDJaPlpSMisXAa.iTrlYJNPRfnlwJwFcpcVFCxGDEXg)),
				IcxGLIhklvvQoQoKtcxmqoxhEvH = true,
				FVqwYyxrNVVUbagbnQWHlJyOsDE = true,
				xbuBMFhCNKPugQlemHgtkfBRtHR = false,
				CQkXEYtAhbFaYkOrUjlkkyHixADj = true,
				mCUytGiDxNfcZnpWicXGXgSVmos = IntPtr.Zero
			};
			MNpTRkPpWfSEWaPlcEOSixdhdRc = KSJklejSjRczvdDJaPlpSMisXAa.lhOweqQgeBVkcNxcZbiefsqHevf.AaITSTYmsSMRgQyjrgwNkXeIpsO();
			haneUxMuPPRRrqoFtfIAJVWjzhwb = new NativeBuffer((int)MNpTRkPpWfSEWaPlcEOSixdhdRc.GXzXGWNfOQnVvTtRWSNdFASkppo);
			haneUxMuPPRRrqoFtfIAJVWjzhwb.Write(MNpTRkPpWfSEWaPlcEOSixdhdRc.GXzXGWNfOQnVvTtRWSNdFASkppo, 0);
			if (aDrIATaHiKqPeBhrEXyogjFIeXCC == jPUUxBbiBalctdVqpNrsXDeuyAB.PaOcfufLRIZBzQjEkZXeGChdtNp)
			{
				dBKVowJCOvAQAnyqNBQgssIgXRI(FIfrRxulAJbEPMZezWjIEInngCc);
				LgLbgrXSqTFWhSjHUEZwMRZFBAyG();
			}
			if (handleJoysticks)
			{
				try
				{
					BVltvFgdpKRuuHZyAOlJbTkVDuZ();
					VVFslsjlWzNaXlrpOOZJcrMpdcZ(ref MYIilGlzGtMSBPimluqBFDXADRJ, mQkVQsZRGCOLwLaQRXsXJyvotcw(true));
				}
				catch (Exception ex)
				{
					if (ex.Data != null && ex.Data.Contains(1))
					{
						string text = ex.Data[1] as string;
						if (text == "sandbox")
						{
							Rewired.Logger.LogWarning("Detected possible sandbox. Raw Input does not work correctly in a sandbox with default security settings.");
						}
					}
					throw;
				}
			}
			cYEtxwxJcohewrZpEQAxCTxiaCX();
			ReInput.ApplicationIsFullScreenChangedEvent += DqxtysakswXnmJvCUDCRDZHwEjX;
			ReInput.ApplicationFullScreenModeChangedEvent += XuwRtZUIFZwTMvgosiGZtTZvTlG;
		}
		catch (Exception)
		{
			Dispose();
			throw;
		}
	}

	public void BVltvFgdpKRuuHZyAOlJbTkVDuZ()
	{
	}

	public void mMxswVERpzWiDjcfWExqXqDIqqA()
	{
		if (bERdxQEMngIKTcdezlFBctUJBera)
		{
			lock (sASCLGHuXbDiqdETFUiqWNTTBYcm)
			{
				VVFslsjlWzNaXlrpOOZJcrMpdcZ(ref MYIilGlzGtMSBPimluqBFDXADRJ, dVfQHZBQlRoGgBVZMntUHOsYKhm);
				dVfQHZBQlRoGgBVZMntUHOsYKhm.Clear();
			}
		}
		if (iIwUOirxOAPopNHowMFDfsCjcgB)
		{
			macfYwHfTTEAHtsnBkfHiNWmbJI();
		}
		sYrdvydtfjLHszVUYNTHmQsLpkB = false;
	}

	public bool IZkZusjYYXgkLoXXuWHYixfqKRQ()
	{
		lock (sASCLGHuXbDiqdETFUiqWNTTBYcm)
		{
			if (OCMyDtErcQlvXJRtPGkcSdJpOMp())
			{
				Thread.Sleep(250);
			}
			dVfQHZBQlRoGgBVZMntUHOsYKhm = mQkVQsZRGCOLwLaQRXsXJyvotcw(false);
			return true;
		}
	}

	public bool ehMeFMHHieuObmRMYMhUegjgCRgC()
	{
		int num = KjOsSxzgXFWQPYaiNMWEMOdmLAE();
		if (num == TvRNAnoaHwMVCzfXMHwarftPYm)
		{
			return false;
		}
		TvRNAnoaHwMVCzfXMHwarftPYm = num;
		return true;
	}

	public bool OCMyDtErcQlvXJRtPGkcSdJpOMp()
	{
		try
		{
			return sYwCgmJInQorTFIIBkpIONhajGKy.OCMyDtErcQlvXJRtPGkcSdJpOMp();
		}
		catch
		{
		}
		return false;
	}

	public bool EchuHkSOHaqDACgFGkRkZDjBkNy(bool P_0)
	{
		bool result = uJoiugGnSiZQnVqgxHdKXSrispe;
		if (P_0)
		{
			uJoiugGnSiZQnVqgxHdKXSrispe = false;
		}
		return result;
	}

	public void SystemDeviceDisconnected()
	{
		if (bERdxQEMngIKTcdezlFBctUJBera)
		{
			sYrdvydtfjLHszVUYNTHmQsLpkB = true;
		}
	}

	public void SystemDeviceConnected()
	{
		if (bERdxQEMngIKTcdezlFBctUJBera)
		{
			sYrdvydtfjLHszVUYNTHmQsLpkB = true;
		}
	}

	public void Update()
	{
		for (int i = 0; i < cARGzYpulwIjmdeZOgLNNxAVRgIl.Length; i++)
		{
			cARGzYpulwIjmdeZOgLNNxAVRgIl[i].Update();
		}
		if (tiQGcKKTPHKqeDUGdLkldoTbuXDe >= 0)
		{
			wXDBnbcPpgZoKvKMlZWZJCIYeQs();
		}
		if (VUjjFdeMXVjpMKMhYRosEXhUuLM)
		{
			if (tiQGcKKTPHKqeDUGdLkldoTbuXDe < 0 && (iIwUOirxOAPopNHowMFDfsCjcgB || ZSJeoeAgfltDyiGQZOstfnhVwtkF))
			{
				JHBNcsfLgNTnYKqUuFbWFYaThTp();
			}
		}
		else if (iIwUOirxOAPopNHowMFDfsCjcgB || ZSJeoeAgfltDyiGQZOstfnhVwtkF)
		{
			babDVhEoyfZLMAczUYFJJzkleVUx();
		}
	}

	public void UpdateDevices(UpdateLoopType updateLoop)
	{
		if (bERdxQEMngIKTcdezlFBctUJBera)
		{
			int count = MYIilGlzGtMSBPimluqBFDXADRJ.Count;
			for (int i = 0; i < count; i++)
			{
				MYIilGlzGtMSBPimluqBFDXADRJ[i]?.EBZMKoSknSfzkSfokUzktanzxJf(updateLoop);
			}
		}
	}

	public void UpdateFinished()
	{
		if (bERdxQEMngIKTcdezlFBctUJBera)
		{
			int count = MYIilGlzGtMSBPimluqBFDXADRJ.Count;
			for (int i = 0; i < count; i++)
			{
				MYIilGlzGtMSBPimluqBFDXADRJ[i]?.aWoeUUEECkNImBpxjMjDHgymWpn();
			}
		}
	}

	public IList<T> GetJoysticks<T>() where T : class
	{
		return dtbyRUBqedycGjHcAPgFBorWqdE as IList<T>;
	}

	private List<KXNanfFdezOfVOeIdsOvMHQobbRn> mQkVQsZRGCOLwLaQRXsXJyvotcw(bool P_0)
	{
		if (!bERdxQEMngIKTcdezlFBctUJBera)
		{
			return new List<KXNanfFdezOfVOeIdsOvMHQobbRn>();
		}
		ObNGuKuHQeiteAcmPGizFwpuqcX();
		List<fdBZRDbybZMtjAcgxmMymPFpolh> list = null;
		List<KXNanfFdezOfVOeIdsOvMHQobbRn> list2 = new List<KXNanfFdezOfVOeIdsOvMHQobbRn>();
		TvRNAnoaHwMVCzfXMHwarftPYm = NPqBHQarUvCWzghxFCYfHMidkqrk();
		if (0 == 0)
		{
			list = RvMHQisOjyvanvlgzEycFiIzSxN.lpdhCcAesAIzAGEfNnVRtTZgAQra(P_0);
			bool flag = true;
		}
		if (list == null)
		{
			list = new List<fdBZRDbybZMtjAcgxmMymPFpolh>();
		}
		IList<sYwCgmJInQorTFIIBkpIONhajGKy.kMLkQRKYstAbZAxsysaYBfvsVfD> JAIpEqrDiPgvzooIPyFBANrJQaL;
		try
		{
			JAIpEqrDiPgvzooIPyFBANrJQaL = sYwCgmJInQorTFIIBkpIONhajGKy.YBymhQEcgDzNgzZVSNwPwCwwjCb();
		}
		catch (Exception ex)
		{
			JAIpEqrDiPgvzooIPyFBANrJQaL = new List<sYwCgmJInQorTFIIBkpIONhajGKy.kMLkQRKYstAbZAxsysaYBfvsVfD>();
			Rewired.Logger.LogError("Exception getting HID device list.\n" + ex);
		}
		List<string> list3 = new List<string>();
		int num = 0;
		for (int i = 0; i < list.Count; i++)
		{
			KXNanfFdezOfVOeIdsOvMHQobbRn kXNanfFdezOfVOeIdsOvMHQobbRn = null;
			try
			{
				fdBZRDbybZMtjAcgxmMymPFpolh fdBZRDbybZMtjAcgxmMymPFpolh2 = list[i];
				if (list[i] != null && fdBZRDbybZMtjAcgxmMymPFpolh2.yrBKgxgwtsXACurkrpnBjVvVoyl == ZLCskcBqtJByBhszckujrsvBGnPh.QhiUZlGNJdolWUoQUQntAIYIgCni && fdBZRDbybZMtjAcgxmMymPFpolh2 is jXKUXtOzftWhWoEPbDERxvvCcew jXKUXtOzftWhWoEPbDERxvvCcew2)
				{
					kXNanfFdezOfVOeIdsOvMHQobbRn = xiIanAzoIKKdmiidOqeEOzGoRnB(fdBZRDbybZMtjAcgxmMymPFpolh2.APllICJNRJmhlyPnfYfDTmikppa, jXKUXtOzftWhWoEPbDERxvvCcew2, JAIpEqrDiPgvzooIPyFBANrJQaL, list3, num);
					if (kXNanfFdezOfVOeIdsOvMHQobbRn != null)
					{
						list2.Add(kXNanfFdezOfVOeIdsOvMHQobbRn);
						num++;
					}
				}
			}
			catch (Exception ex2)
			{
				Rewired.Logger.LogError("An exception occurred while initializing HID device! This device will be non-functional.\n" + ex2.Message);
			}
		}
		if (!QxJGAIdIaYwUdmeAotwGjhMlngRb.useXInput)
		{
			int WDYLohLGyDgYypJPFSZYNlEBbEt;
			for (WDYLohLGyDgYypJPFSZYNlEBbEt = 0; WDYLohLGyDgYypJPFSZYNlEBbEt < JAIpEqrDiPgvzooIPyFBANrJQaL.Count; WDYLohLGyDgYypJPFSZYNlEBbEt++)
			{
				KXNanfFdezOfVOeIdsOvMHQobbRn kXNanfFdezOfVOeIdsOvMHQobbRn2 = null;
				try
				{
					if (string.IsNullOrEmpty(list3.Find((string P_0) => P_0.Equals(JAIpEqrDiPgvzooIPyFBANrJQaL[WDYLohLGyDgYypJPFSZYNlEBbEt].WrNGLcwSAEjjKVmOFJJAncYJRVq, StringComparison.OrdinalIgnoreCase))))
					{
						kXNanfFdezOfVOeIdsOvMHQobbRn2 = FCJSuHMnmaplWdwmqdmDDvUinvu(JAIpEqrDiPgvzooIPyFBANrJQaL[WDYLohLGyDgYypJPFSZYNlEBbEt], num);
						if (kXNanfFdezOfVOeIdsOvMHQobbRn2 != null)
						{
							list2.Add(kXNanfFdezOfVOeIdsOvMHQobbRn2);
							num++;
						}
					}
				}
				catch (Exception ex3)
				{
					Rewired.Logger.LogError("An exception occurred while initializing HID device! This device will be non-functional." + ex3.Message);
				}
			}
		}
		return list2;
	}

	private static void VVFslsjlWzNaXlrpOOZJcrMpdcZ(ref List<KXNanfFdezOfVOeIdsOvMHQobbRn> P_0, List<KXNanfFdezOfVOeIdsOvMHQobbRn> P_1)
	{
		if (P_0 == null)
		{
			P_0 = new List<KXNanfFdezOfVOeIdsOvMHQobbRn>();
		}
		if (P_1 == null)
		{
			P_1 = new List<KXNanfFdezOfVOeIdsOvMHQobbRn>();
		}
		if (P_1.Count == 0)
		{
			P_0.ForEach(delegate(KXNanfFdezOfVOeIdsOvMHQobbRn P_0)
			{
				P_0.Dispose();
			});
			P_0.Clear();
			return;
		}
		int count = P_1.Count;
		int count2 = P_0.Count;
		KXNanfFdezOfVOeIdsOvMHQobbRn[] array = P_1.ToArray();
		if (array.Length > 0)
		{
			Array.Sort(array, HamSnjQKHSvfxibgTwwwdqRDwah);
		}
		for (int i = 0; i < count2; i++)
		{
			KXNanfFdezOfVOeIdsOvMHQobbRn AppmZZNJIgTHSGlPsrPwLqVWugJ = P_0[i];
			if (AppmZZNJIgTHSGlPsrPwLqVWugJ != null && Array.Find(array, (KXNanfFdezOfVOeIdsOvMHQobbRn P_0) => P_0.mXqEWIlGwHZPoKjhftGIspoptJq == AppmZZNJIgTHSGlPsrPwLqVWugJ.mXqEWIlGwHZPoKjhftGIspoptJq) == null)
			{
				AppmZZNJIgTHSGlPsrPwLqVWugJ.Dispose();
			}
		}
		P_0.Clear();
		for (int j = 0; j < count; j++)
		{
			if (array[j] != null)
			{
				array[j].kyUFGDyfVfGIBBZxImEmetWSOnXJ(j);
				P_0.Add(array[j]);
			}
		}
	}

	private List<fdBZRDbybZMtjAcgxmMymPFpolh> aiNbSFfNXZgnerJJdWmzlThELiHm()
	{
		List<fdBZRDbybZMtjAcgxmMymPFpolh> list = new List<fdBZRDbybZMtjAcgxmMymPFpolh>();
		try
		{
			foreach (tJKAaDrvDYPmVdvOWTbYhAqgFPi item in sYwCgmJInQorTFIIBkpIONhajGKy.JdUDtJMOxlNUpArYEAfecqBSASZ())
			{
				try
				{
					list.Add(new jXKUXtOzftWhWoEPbDERxvvCcew
					{
						dwXOCjlGTMEtQuFitVyMfqHPogm = cmwBGCtbOdnPmdndepyeYPuXGzv.gjlkGeDluPtDgcBqsmPLwnmixfs(item.FbhbjmvDJXhmcRNTPxCMljeDYKl),
						yrBKgxgwtsXACurkrpnBjVvVoyl = ZLCskcBqtJByBhszckujrsvBGnPh.QhiUZlGNJdolWUoQUQntAIYIgCni,
						APllICJNRJmhlyPnfYfDTmikppa = IntPtr.Zero,
						LLWNXygzETOTnJQyBltZKpktGJs = item.KLZsENHavCrIAofHXOTHKQQcpRK.LLWNXygzETOTnJQyBltZKpktGJs,
						XVuHkKcnbaTxiTZvxKQBLJaCehD = item.KLZsENHavCrIAofHXOTHKQQcpRK.XVuHkKcnbaTxiTZvxKQBLJaCehD,
						hohBIdhLiFcknEuoyySqtjwFCVb = item.KLZsENHavCrIAofHXOTHKQQcpRK.byOEyWsZkXDdnQKpGelPoKLjDwu,
						YxVFJDmgAkRgCcCvUfhmITfzYBad = (zUcsEXgRrpTTuylslYMZNHbGVwI)item.INkPMrgmFQHrPoFjcDSDiHJFEiNM.YxVFJDmgAkRgCcCvUfhmITfzYBad,
						MNRaihHKuqDsUzvPGSYEtAEmyqK = (QZaHVGYkaaUvpuhZHPmbaNhDycJ)item.INkPMrgmFQHrPoFjcDSDiHJFEiNM.MNRaihHKuqDsUzvPGSYEtAEmyqK
					});
				}
				catch
				{
				}
			}
			return list;
		}
		catch
		{
			return list;
		}
	}

	private KXNanfFdezOfVOeIdsOvMHQobbRn xiIanAzoIKKdmiidOqeEOzGoRnB(IntPtr P_0, jXKUXtOzftWhWoEPbDERxvvCcew P_1, IList<sYwCgmJInQorTFIIBkpIONhajGKy.kMLkQRKYstAbZAxsysaYBfvsVfD> P_2, List<string> P_3, int P_4)
	{
		ushort num = (ushort)P_1.YxVFJDmgAkRgCcCvUfhmITfzYBad;
		ushort num2 = (ushort)P_1.MNRaihHKuqDsUzvPGSYEtAEmyqK;
		string deviceName = P_1.dwXOCjlGTMEtQuFitVyMfqHPogm;
		if (!fXMxXcOmGFAhomadTJHfyJPwgVLf(num, num2))
		{
			return null;
		}
		string text = cmwBGCtbOdnPmdndepyeYPuXGzv.gjlkGeDluPtDgcBqsmPLwnmixfs(deviceName);
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		P_3.Add(text);
		RAOzdEPdgYzXSunXnEJayhNPEZI rAOzdEPdgYzXSunXnEJayhNPEZI = sYwCgmJInQorTFIIBkpIONhajGKy.wsTMUsSVNpVsSukTcakkCYepIog(P_2, text, StringComparison.OrdinalIgnoreCase);
		if (rAOzdEPdgYzXSunXnEJayhNPEZI == null)
		{
			rAOzdEPdgYzXSunXnEJayhNPEZI = lcAiWSDmOiUVKJMbHShlNTWioRYu.njKYlSTeKHbMBadDXNjngjveJjCo(P_0, deviceName);
		}
		if (num == 1 && (num2 == 4 || num2 == 5))
		{
			string text2 = rAOzdEPdgYzXSunXnEJayhNPEZI.nEasBJFqEhSbcpbFCPuctlxPYDE();
			string bluetoothDeviceName = rAOzdEPdgYzXSunXnEJayhNPEZI.AhHrqrQkLzCLgDcoKPqTNKyjQNgv;
			Guid guid = MiscTools.CreateHIDProductGuid(rAOzdEPdgYzXSunXnEJayhNPEZI.KLZsENHavCrIAofHXOTHKQQcpRK.XVuHkKcnbaTxiTZvxKQBLJaCehD, rAOzdEPdgYzXSunXnEJayhNPEZI.KLZsENHavCrIAofHXOTHKQQcpRK.LLWNXygzETOTnJQyBltZKpktGJs);
			if (ZhzEgYNkzSQYSkAsExZjzNVVOnu.FpdjMWjxNYeuTwQMrhDlVgzLxqE(guid, text2, bluetoothDeviceName))
			{
				P_3.RemoveAt(P_3.Count - 1);
				return null;
			}
		}
		return gJNqlakUdZAxdDjNDrMyUGeIUij(edIjNHJxgLBHXzZHkFeKSgvMhRu.gliAULEhtyLvundYTBKaYhdMYjkP, rAOzdEPdgYzXSunXnEJayhNPEZI, P_0, num, num2, P_4);
	}

	private KXNanfFdezOfVOeIdsOvMHQobbRn FCJSuHMnmaplWdwmqdmDDvUinvu(sYwCgmJInQorTFIIBkpIONhajGKy.kMLkQRKYstAbZAxsysaYBfvsVfD P_0, int P_1)
	{
		tJKAaDrvDYPmVdvOWTbYhAqgFPi tJKAaDrvDYPmVdvOWTbYhAqgFPi2 = sYwCgmJInQorTFIIBkpIONhajGKy.gxIGTNbMTlNZdcyVXIQufOyySbf(P_0);
		if (tJKAaDrvDYPmVdvOWTbYhAqgFPi2 == null)
		{
			return null;
		}
		ushort num = (ushort)tJKAaDrvDYPmVdvOWTbYhAqgFPi2.INkPMrgmFQHrPoFjcDSDiHJFEiNM.YxVFJDmgAkRgCcCvUfhmITfzYBad;
		ushort num2 = (ushort)tJKAaDrvDYPmVdvOWTbYhAqgFPi2.INkPMrgmFQHrPoFjcDSDiHJFEiNM.MNRaihHKuqDsUzvPGSYEtAEmyqK;
		if (!fXMxXcOmGFAhomadTJHfyJPwgVLf(num, num2))
		{
			return null;
		}
		bool flag = false;
		if (num == 1 && (num2 == 4 || num2 == 5))
		{
			flag = ZhzEgYNkzSQYSkAsExZjzNVVOnu.FpdjMWjxNYeuTwQMrhDlVgzLxqE(MiscTools.CreateHIDProductGuid(tJKAaDrvDYPmVdvOWTbYhAqgFPi2.KLZsENHavCrIAofHXOTHKQQcpRK.XVuHkKcnbaTxiTZvxKQBLJaCehD, tJKAaDrvDYPmVdvOWTbYhAqgFPi2.KLZsENHavCrIAofHXOTHKQQcpRK.LLWNXygzETOTnJQyBltZKpktGJs), tJKAaDrvDYPmVdvOWTbYhAqgFPi2.nEasBJFqEhSbcpbFCPuctlxPYDE(), tJKAaDrvDYPmVdvOWTbYhAqgFPi2.AhHrqrQkLzCLgDcoKPqTNKyjQNgv);
		}
		if (!flag)
		{
			return null;
		}
		return gJNqlakUdZAxdDjNDrMyUGeIUij(edIjNHJxgLBHXzZHkFeKSgvMhRu.MvnIKPJhkzIumPiyqhGYvAOYjpz, tJKAaDrvDYPmVdvOWTbYhAqgFPi2, IntPtr.Zero, num, num2, P_1);
	}

	private KXNanfFdezOfVOeIdsOvMHQobbRn gJNqlakUdZAxdDjNDrMyUGeIUij(edIjNHJxgLBHXzZHkFeKSgvMhRu P_0, RAOzdEPdgYzXSunXnEJayhNPEZI P_1, IntPtr P_2, ushort P_3, ushort P_4, int P_5)
	{
		bool flag = P_3 != 1 || !GizYjyDnNJcYIyixdgjEIHBRMNmK.fpFBVBNfnrEreFZUnxPxbPZClxrx.KcYCUUcWquqrcDTDZfJvgZUgeJZo(P_4);
		if (QxJGAIdIaYwUdmeAotwGjhMlngRb.useXInput && P_3 == 1 && (P_4 == 4 || P_4 == 5))
		{
			string text = P_1.nEasBJFqEhSbcpbFCPuctlxPYDE();
			string bluetoothDeviceName = P_1.AhHrqrQkLzCLgDcoKPqTNKyjQNgv;
			Guid guid = MiscTools.CreateHIDProductGuid(P_1.KLZsENHavCrIAofHXOTHKQQcpRK.XVuHkKcnbaTxiTZvxKQBLJaCehD, P_1.KLZsENHavCrIAofHXOTHKQQcpRK.LLWNXygzETOTnJQyBltZKpktGJs);
			if (gNZLZmnOEqwqMNKfeNUJNfMypUC.NeDbvgznpqCICmoNVeTAmiXHgNF(P_1.FbhbjmvDJXhmcRNTPxCMljeDYKl, text, bluetoothDeviceName, guid))
			{
				return null;
			}
		}
		KXNanfFdezOfVOeIdsOvMHQobbRn kXNanfFdezOfVOeIdsOvMHQobbRn = PHJfdoCLdHhpnkxgmvEGLIvUkwfC(P_0, P_2, P_5, P_1, MYIilGlzGtMSBPimluqBFDXADRJ, flag);
		if (kXNanfFdezOfVOeIdsOvMHQobbRn == null || !kXNanfFdezOfVOeIdsOvMHQobbRn.NyNissJrezIHEYEWYiMbOJlhOtY)
		{
			if (kXNanfFdezOfVOeIdsOvMHQobbRn != null && !kXNanfFdezOfVOeIdsOvMHQobbRn.NyNissJrezIHEYEWYiMbOJlhOtY)
			{
				kXNanfFdezOfVOeIdsOvMHQobbRn.Dispose();
			}
			return null;
		}
		return kXNanfFdezOfVOeIdsOvMHQobbRn;
	}

	private bool fXMxXcOmGFAhomadTJHfyJPwgVLf(ushort P_0, ushort P_1)
	{
		for (int i = 0; i < hZUrEfFXiHaVjCifApKCXuFiRlp.Length; i++)
		{
			if (hZUrEfFXiHaVjCifApKCXuFiRlp[i].VVKhEsoxaVNbDlJnFgkkijTVHVU == P_0 && hZUrEfFXiHaVjCifApKCXuFiRlp[i].WkPmqxywNefzhmrRdLSQnLATPQH == P_1)
			{
				return true;
			}
		}
		return false;
	}

	private int NPqBHQarUvCWzghxFCYfHMidkqrk()
	{
		try
		{
			return sYwCgmJInQorTFIIBkpIONhajGKy.VFEohVGjpKoiHHXQrfHvEoqRdGz();
		}
		catch
		{
			return 0;
		}
	}

	private int KjOsSxzgXFWQPYaiNMWEMOdmLAE()
	{
		try
		{
			return sYwCgmJInQorTFIIBkpIONhajGKy.VFEohVGjpKoiHHXQrfHvEoqRdGz(ref qMclpCKKpzqkHOWOpsKfhWgCyGw, haneUxMuPPRRrqoFtfIAJVWjzhwb);
		}
		catch (Exception)
		{
			return 0;
		}
	}

	private KXNanfFdezOfVOeIdsOvMHQobbRn PHJfdoCLdHhpnkxgmvEGLIvUkwfC(edIjNHJxgLBHXzZHkFeKSgvMhRu P_0, IntPtr P_1, int P_2, RAOzdEPdgYzXSunXnEJayhNPEZI P_3, List<KXNanfFdezOfVOeIdsOvMHQobbRn> P_4, bool P_5)
	{
		if (P_5 && !zWZMsCvzKDkPpYLNOCFCvmaaPOq)
		{
			return null;
		}
		try
		{
			if (zWZMsCvzKDkPpYLNOCFCvmaaPOq)
			{
				if (P_4 != null)
				{
					for (int i = 0; i < P_4.Count; i++)
					{
						if (P_4[i] is dfllRGQXaCLWtJKAXCdESlJwigCi dfllRGQXaCLWtJKAXCdESlJwigCi2 && dfllRGQXaCLWtJKAXCdESlJwigCi2.FvCxHidPaUCtnjMuXlsGPKWUDOiD != null && !(P_3.HWpkoLElvmTfaUmHEmBxsOPncRl != dfllRGQXaCLWtJKAXCdESlJwigCi2.LPwHpgkDYfIlwxkmYbtXZxinGpb.HWpkoLElvmTfaUmHEmBxsOPncRl))
						{
							dfllRGQXaCLWtJKAXCdESlJwigCi2.kyUFGDyfVfGIBBZxImEmetWSOnXJ(P_2);
							return dfllRGQXaCLWtJKAXCdESlJwigCi2;
						}
					}
				}
				HIDDeviceDriver.DriverType driverType = HIDDeviceDriver.FindDriverId(P_3.KLZsENHavCrIAofHXOTHKQQcpRK.XVuHkKcnbaTxiTZvxKQBLJaCehD, P_3.KLZsENHavCrIAofHXOTHKQQcpRK.LLWNXygzETOTnJQyBltZKpktGJs);
				if (driverType != 0)
				{
					HidOutputReportHandler hidOutputReportHandler = new HidOutputReportHandler(P_3.CzNVjrKdRSDpqbOtCpPyrLKKAXdE);
					HIDDeviceDriver driver = HIDDeviceDriver.GetDriver(driverType, new HIDDeviceDriver.InitArgs(SUWFuaPhXRNpjQqOeummtAiJjncj, (!P_3.cjOWzBCMkHIxRWceNYEqTjupNms) ? DeviceConnectionType.gGlAwjqOwnYEknoVbJxOlTQouZG : DeviceConnectionType.CabkzYmwkSoeZRQBHEfOFiOxqlo, 65535, -65535, -1, 4500, P_3.INkPMrgmFQHrPoFjcDSDiHJFEiNM.raHmdvKpmDzDhFVQwjMIbPuhFjpk, P_3.INkPMrgmFQHrPoFjcDSDiHJFEiNM.msrPOboQEjhoRAbnHEdkARQpghx, P_3.CzNVjrKdRSDpqbOtCpPyrLKKAXdE, hidOutputReportHandler.WriteReport, delegate(byte P_0)
					{
						P_3.ttKgMiVjmboGrHWEjBPYEXevCMK(out var result, P_0);
						return result;
					}));
					if (driver != null)
					{
						return new dfllRGQXaCLWtJKAXCdESlJwigCi(P_2, P_0, P_1, P_3, driver, hidOutputReportHandler);
					}
				}
				if (P_5)
				{
					return null;
				}
			}
		}
		catch
		{
			Rewired.Logger.LogWarning("Exception creating custom driver joystick. Will fall back to normal HID joystick.");
		}
		try
		{
			if (P_4 != null)
			{
				for (int j = 0; j < P_4.Count; j++)
				{
					if (P_4[j] is gChgGxyRrVUYhHHtgkUFLhNTvGO gChgGxyRrVUYhHHtgkUFLhNTvGO2 && !(P_3.HWpkoLElvmTfaUmHEmBxsOPncRl != gChgGxyRrVUYhHHtgkUFLhNTvGO2.LPwHpgkDYfIlwxkmYbtXZxinGpb.HWpkoLElvmTfaUmHEmBxsOPncRl))
					{
						gChgGxyRrVUYhHHtgkUFLhNTvGO2.kyUFGDyfVfGIBBZxImEmetWSOnXJ(P_2);
						return gChgGxyRrVUYhHHtgkUFLhNTvGO2;
					}
				}
			}
			return new gChgGxyRrVUYhHHtgkUFLhNTvGO(P_2, P_0, P_1, P_3);
		}
		catch
		{
			return null;
		}
	}

	private KXNanfFdezOfVOeIdsOvMHQobbRn mzzdzBQHifxmhJLULaMnmJppewG(edIjNHJxgLBHXzZHkFeKSgvMhRu P_0, IntPtr P_1)
	{
		if (MYIilGlzGtMSBPimluqBFDXADRJ == null)
		{
			return null;
		}
		for (int i = 0; i < MYIilGlzGtMSBPimluqBFDXADRJ.Count; i++)
		{
			KXNanfFdezOfVOeIdsOvMHQobbRn kXNanfFdezOfVOeIdsOvMHQobbRn = MYIilGlzGtMSBPimluqBFDXADRJ[i];
			if (kXNanfFdezOfVOeIdsOvMHQobbRn.ygdAGuzWXQmtUDeKrsQEpqRiuFF == P_0 && !(kXNanfFdezOfVOeIdsOvMHQobbRn.xXBFwebtUVoAYaVmghtoNmYZrLV != P_1))
			{
				return kXNanfFdezOfVOeIdsOvMHQobbRn;
			}
		}
		return null;
	}

	private unsafe KXNanfFdezOfVOeIdsOvMHQobbRn zOEIHAoLgZicEYUjOigSDVzLOPu(IntPtr P_0)
	{
		FzngAIhKGFOAkXUDRNTZlbDTVEc.PaopCcVlJBmtHQzJbhsQyjbdoAc(P_0, 536870919u, IntPtr.Zero, out var num);
		if (num == 0)
		{
			return null;
		}
		char* value = stackalloc char[(int)num];
		FzngAIhKGFOAkXUDRNTZlbDTVEc.PaopCcVlJBmtHQzJbhsQyjbdoAc(P_0, 536870919u, new IntPtr(value), out num);
		int length = (int)(((int)num > 0) ? (num - 1) : 0);
		string text = new string(value, 0, length);
		if (text.Length == 0)
		{
			text = string.Empty;
		}
		if (MYIilGlzGtMSBPimluqBFDXADRJ == null)
		{
			return null;
		}
		text = cmwBGCtbOdnPmdndepyeYPuXGzv.gjlkGeDluPtDgcBqsmPLwnmixfs(text);
		for (int i = 0; i < MYIilGlzGtMSBPimluqBFDXADRJ.Count; i++)
		{
			KXNanfFdezOfVOeIdsOvMHQobbRn kXNanfFdezOfVOeIdsOvMHQobbRn = MYIilGlzGtMSBPimluqBFDXADRJ[i];
			if (kXNanfFdezOfVOeIdsOvMHQobbRn.ygdAGuzWXQmtUDeKrsQEpqRiuFF == edIjNHJxgLBHXzZHkFeKSgvMhRu.gliAULEhtyLvundYTBKaYhdMYjkP && kXNanfFdezOfVOeIdsOvMHQobbRn.LPwHpgkDYfIlwxkmYbtXZxinGpb.OXURyerpNtaSwtnJAUFkhICjCGm.Equals(text, StringComparison.OrdinalIgnoreCase))
			{
				kXNanfFdezOfVOeIdsOvMHQobbRn.TZZendhYActytkYPtwqJctWjPlp(P_0);
				return kXNanfFdezOfVOeIdsOvMHQobbRn;
			}
		}
		return null;
	}

	private static int HamSnjQKHSvfxibgTwwwdqRDwah(KXNanfFdezOfVOeIdsOvMHQobbRn P_0, KXNanfFdezOfVOeIdsOvMHQobbRn P_1)
	{
		if (!P_0.LPwHpgkDYfIlwxkmYbtXZxinGpb.OCWCmPnHcwOcAmdfXmQbdEPNbPl)
		{
			return 1;
		}
		if (!P_1.LPwHpgkDYfIlwxkmYbtXZxinGpb.OCWCmPnHcwOcAmdfXmQbdEPNbPl)
		{
			return -1;
		}
		int hubId = P_0.LPwHpgkDYfIlwxkmYbtXZxinGpb.xYsppkfjaolZMHUcQNpbPXOTiSP;
		int hubId2 = P_1.LPwHpgkDYfIlwxkmYbtXZxinGpb.xYsppkfjaolZMHUcQNpbPXOTiSP;
		if (hubId < hubId2)
		{
			return -1;
		}
		if (hubId > hubId2)
		{
			return 1;
		}
		int portId = P_0.LPwHpgkDYfIlwxkmYbtXZxinGpb.RfSQCsUPTyQuJvOlwOqZtTDxEw;
		int portId2 = P_1.LPwHpgkDYfIlwxkmYbtXZxinGpb.RfSQCsUPTyQuJvOlwOqZtTDxEw;
		if (portId < portId2)
		{
			return -1;
		}
		if (portId > portId2)
		{
			return 1;
		}
		return 0;
	}

	private void ObNGuKuHQeiteAcmPGizFwpuqcX()
	{
		if (aDrIATaHiKqPeBhrEXyogjFIeXCC != 0)
		{
			return;
		}
		bool KdbcDclniAHwcHRcqIKpBGfZpsEA = false;
		dfRmoZIQwVcWHSVxnTYedFzmfjLj(delegate
		{
			try
			{
				RvMHQisOjyvanvlgzEycFiIzSxN.WmcAFiXIcgzudeMuZFkSiTIyezSz((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)4, jsjfPGYHvJosyLMTZZuHNbEmlut.nyAShQdNKjMlyrkXvEOtZJJJmOJ | jsjfPGYHvJosyLMTZZuHNbEmlut.VAOTDZGpFyiYBCVeiGuPSlhsNrA, EVwOOSIMTJQwAVGTPoUvLIidogS.APllICJNRJmhlyPnfYfDTmikppa);
				RvMHQisOjyvanvlgzEycFiIzSxN.WmcAFiXIcgzudeMuZFkSiTIyezSz((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)5, jsjfPGYHvJosyLMTZZuHNbEmlut.nyAShQdNKjMlyrkXvEOtZJJJmOJ | jsjfPGYHvJosyLMTZZuHNbEmlut.VAOTDZGpFyiYBCVeiGuPSlhsNrA, EVwOOSIMTJQwAVGTPoUvLIidogS.APllICJNRJmhlyPnfYfDTmikppa);
				RvMHQisOjyvanvlgzEycFiIzSxN.WmcAFiXIcgzudeMuZFkSiTIyezSz((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)8, jsjfPGYHvJosyLMTZZuHNbEmlut.nyAShQdNKjMlyrkXvEOtZJJJmOJ | jsjfPGYHvJosyLMTZZuHNbEmlut.VAOTDZGpFyiYBCVeiGuPSlhsNrA, EVwOOSIMTJQwAVGTPoUvLIidogS.APllICJNRJmhlyPnfYfDTmikppa);
				RvMHQisOjyvanvlgzEycFiIzSxN.WmcAFiXIcgzudeMuZFkSiTIyezSz((zUcsEXgRrpTTuylslYMZNHbGVwI)12, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)1, jsjfPGYHvJosyLMTZZuHNbEmlut.nyAShQdNKjMlyrkXvEOtZJJJmOJ | jsjfPGYHvJosyLMTZZuHNbEmlut.VAOTDZGpFyiYBCVeiGuPSlhsNrA, EVwOOSIMTJQwAVGTPoUvLIidogS.APllICJNRJmhlyPnfYfDTmikppa);
			}
			catch
			{
				KdbcDclniAHwcHRcqIKpBGfZpsEA = true;
			}
		}, true);
		if (KdbcDclniAHwcHRcqIKpBGfZpsEA)
		{
			Rewired.Logger.LogError("Failed to register HID devices.", requiredThreadSafety: true);
		}
	}

	private void QDOgqXghQUKVCENoHkfCpprCqEBc()
	{
		if (aDrIATaHiKqPeBhrEXyogjFIeXCC != 0)
		{
			return;
		}
		bool KdbcDclniAHwcHRcqIKpBGfZpsEA = false;
		dfRmoZIQwVcWHSVxnTYedFzmfjLj(delegate
		{
			try
			{
				RvMHQisOjyvanvlgzEycFiIzSxN.jJQQTqnRxKlreJHDbdGXKirRlUT((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)4);
				RvMHQisOjyvanvlgzEycFiIzSxN.jJQQTqnRxKlreJHDbdGXKirRlUT((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)5);
				RvMHQisOjyvanvlgzEycFiIzSxN.jJQQTqnRxKlreJHDbdGXKirRlUT((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)8);
				RvMHQisOjyvanvlgzEycFiIzSxN.jJQQTqnRxKlreJHDbdGXKirRlUT((zUcsEXgRrpTTuylslYMZNHbGVwI)12, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)1);
			}
			catch
			{
				KdbcDclniAHwcHRcqIKpBGfZpsEA = true;
			}
		}, true);
		if (KdbcDclniAHwcHRcqIKpBGfZpsEA)
		{
			Rewired.Logger.LogError("Failed to unregister HID devices.", requiredThreadSafety: true);
		}
	}

	private void JHBNcsfLgNTnYKqUuFbWFYaThTp()
	{
		if (ReInput.isAllowedEditorWindowFocused)
		{
			if (aDrIATaHiKqPeBhrEXyogjFIeXCC == jPUUxBbiBalctdVqpNrsXDeuyAB.PaOcfufLRIZBzQjEkZXeGChdtNp)
			{
				jbFEuENbVgmYUSpSznqKLhZMxXB(pESAFpQGBoTlVGdWQfwAzqmPjIO, out var num);
				if (ZSJeoeAgfltDyiGQZOstfnhVwtkF)
				{
					IntPtr uapZSQjYJXfytPCzBNUlPGzDeLE;
					bool flag = !hKGmwtVLbAiLNsOtgTgBzwbQWPg(ControllerType.Mouse, pESAFpQGBoTlVGdWQfwAzqmPjIO, num, out uapZSQjYJXfytPCzBNUlPGzDeLE);
					if (!ItjCccIbgxppPbpmRVRgfxkXkOLV || !flag)
					{
						if (uapZSQjYJXfytPCzBNUlPGzDeLE == IntPtr.Zero)
						{
							uapZSQjYJXfytPCzBNUlPGzDeLE = UapZSQjYJXfytPCzBNUlPGzDeLE;
						}
						ndQgXZunngCtkKBGxFccaIpcrXLV(uapZSQjYJXfytPCzBNUlPGzDeLE);
					}
				}
				if (!iIwUOirxOAPopNHowMFDfsCjcgB)
				{
					return;
				}
				IntPtr iKdgojlJUuCLVAkHaTBeoQGILhCr;
				bool flag2 = !hKGmwtVLbAiLNsOtgTgBzwbQWPg(ControllerType.Keyboard, pESAFpQGBoTlVGdWQfwAzqmPjIO, num, out iKdgojlJUuCLVAkHaTBeoQGILhCr);
				if (!eVfWUxWGHGlAaYTdzrUYWXftojD || !flag2)
				{
					if (iKdgojlJUuCLVAkHaTBeoQGILhCr == IntPtr.Zero)
					{
						iKdgojlJUuCLVAkHaTBeoQGILhCr = IKdgojlJUuCLVAkHaTBeoQGILhCr;
					}
					IcnAiByfnHidcNaysDPSaqbCiFRe(iKdgojlJUuCLVAkHaTBeoQGILhCr);
				}
			}
			else
			{
				if (ZSJeoeAgfltDyiGQZOstfnhVwtkF && !ItjCccIbgxppPbpmRVRgfxkXkOLV)
				{
					sbeGwUfBiGeuEcoLFCmAUCzdiQQD();
				}
				if (iIwUOirxOAPopNHowMFDfsCjcgB && !eVfWUxWGHGlAaYTdzrUYWXftojD)
				{
					macfYwHfTTEAHtsnBkfHiNWmbJI();
				}
			}
		}
		else
		{
			if (ItjCccIbgxppPbpmRVRgfxkXkOLV)
			{
				ErSHdDsvZJjLStLJyEAocrqViAb();
			}
			if (eVfWUxWGHGlAaYTdzrUYWXftojD)
			{
				zBbKHwMnkzrrAlgHWmnaXFEkWNo();
			}
		}
	}

	private void babDVhEoyfZLMAczUYFJJzkleVUx()
	{
		double realTime = ReInput.realTime;
		if (realTime < uXXIqeTWqDSqYYhaFjezIcpWeKQ + 1.0)
		{
			return;
		}
		uXXIqeTWqDSqYYhaFjezIcpWeKQ = realTime;
		if (aDrIATaHiKqPeBhrEXyogjFIeXCC == jPUUxBbiBalctdVqpNrsXDeuyAB.PaOcfufLRIZBzQjEkZXeGChdtNp)
		{
			jbFEuENbVgmYUSpSznqKLhZMxXB(pESAFpQGBoTlVGdWQfwAzqmPjIO, out var num);
			if (ZSJeoeAgfltDyiGQZOstfnhVwtkF)
			{
				IntPtr intPtr;
				bool flag = !hKGmwtVLbAiLNsOtgTgBzwbQWPg(ControllerType.Mouse, pESAFpQGBoTlVGdWQfwAzqmPjIO, num, out intPtr);
				if (!ItjCccIbgxppPbpmRVRgfxkXkOLV || !flag)
				{
					if (intPtr == IntPtr.Zero)
					{
						intPtr = UapZSQjYJXfytPCzBNUlPGzDeLE;
					}
					AWrPZlrwjCoRHHjznVwVBnPgyBh();
				}
			}
			if (!iIwUOirxOAPopNHowMFDfsCjcgB)
			{
				return;
			}
			IntPtr intPtr2;
			bool flag2 = !hKGmwtVLbAiLNsOtgTgBzwbQWPg(ControllerType.Keyboard, pESAFpQGBoTlVGdWQfwAzqmPjIO, num, out intPtr2);
			if (!eVfWUxWGHGlAaYTdzrUYWXftojD || !flag2)
			{
				if (intPtr2 == IntPtr.Zero)
				{
					intPtr2 = IKdgojlJUuCLVAkHaTBeoQGILhCr;
				}
				xNhaAxYAFCCKUDOIwTEMmYPBpGA();
			}
		}
		else
		{
			if (ZSJeoeAgfltDyiGQZOstfnhVwtkF && !ItjCccIbgxppPbpmRVRgfxkXkOLV)
			{
				sbeGwUfBiGeuEcoLFCmAUCzdiQQD();
			}
			if (iIwUOirxOAPopNHowMFDfsCjcgB && !eVfWUxWGHGlAaYTdzrUYWXftojD)
			{
				macfYwHfTTEAHtsnBkfHiNWmbJI();
			}
		}
	}

	private void QVYxBwIdXNTUBZJkgEappZaLuLr()
	{
		if (aDrIATaHiKqPeBhrEXyogjFIeXCC == jPUUxBbiBalctdVqpNrsXDeuyAB.PaOcfufLRIZBzQjEkZXeGChdtNp)
		{
			jbFEuENbVgmYUSpSznqKLhZMxXB(pESAFpQGBoTlVGdWQfwAzqmPjIO, out var num);
			if (ZSJeoeAgfltDyiGQZOstfnhVwtkF && hKGmwtVLbAiLNsOtgTgBzwbQWPg(ControllerType.Mouse, pESAFpQGBoTlVGdWQfwAzqmPjIO, num, out var _))
			{
				if (ItjCccIbgxppPbpmRVRgfxkXkOLV)
				{
					ItjCccIbgxppPbpmRVRgfxkXkOLV = false;
					eaBTyDyzTScWXkTAyfSAFNdVACC.lniiWJwGWtadnDScpppWlpTlmzW(false);
				}
				AWrPZlrwjCoRHHjznVwVBnPgyBh();
			}
		}
		else if (ZSJeoeAgfltDyiGQZOstfnhVwtkF && !ItjCccIbgxppPbpmRVRgfxkXkOLV)
		{
			sbeGwUfBiGeuEcoLFCmAUCzdiQQD();
		}
	}

	private void ErSHdDsvZJjLStLJyEAocrqViAb()
	{
		if (aDrIATaHiKqPeBhrEXyogjFIeXCC == jPUUxBbiBalctdVqpNrsXDeuyAB.PaOcfufLRIZBzQjEkZXeGChdtNp)
		{
			QGLaeTPOeSSuDzhYEWsEYDPBwjT.cWquWjOBHQFVGgHHXmdhvCIMcrN(false);
			FZMDSCECwduYutpyKOXjbDjAsFDs();
		}
		ItjCccIbgxppPbpmRVRgfxkXkOLV = false;
		eaBTyDyzTScWXkTAyfSAFNdVACC.lniiWJwGWtadnDScpppWlpTlmzW(false);
	}

	private void FZMDSCECwduYutpyKOXjbDjAsFDs()
	{
		if (!ZSJeoeAgfltDyiGQZOstfnhVwtkF || aDrIATaHiKqPeBhrEXyogjFIeXCC != 0)
		{
			return;
		}
		IntPtr intPtr;
		if (VUjjFdeMXVjpMKMhYRosEXhUuLM)
		{
			jbFEuENbVgmYUSpSznqKLhZMxXB(pESAFpQGBoTlVGdWQfwAzqmPjIO, out var num);
			if (hKGmwtVLbAiLNsOtgTgBzwbQWPg(ControllerType.Mouse, pESAFpQGBoTlVGdWQfwAzqmPjIO, num, out var uapZSQjYJXfytPCzBNUlPGzDeLE))
			{
				UapZSQjYJXfytPCzBNUlPGzDeLE = uapZSQjYJXfytPCzBNUlPGzDeLE;
			}
			intPtr = UapZSQjYJXfytPCzBNUlPGzDeLE;
		}
		else
		{
			intPtr = FzngAIhKGFOAkXUDRNTZlbDTVEc.NPKxqbrJOXBOjYozsbheDTjQCapS();
		}
		if (intPtr != IntPtr.Zero)
		{
			bool flag = false;
			try
			{
				RvMHQisOjyvanvlgzEycFiIzSxN.WmcAFiXIcgzudeMuZFkSiTIyezSz((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)2, jsjfPGYHvJosyLMTZZuHNbEmlut.nyAShQdNKjMlyrkXvEOtZJJJmOJ, intPtr);
			}
			catch
			{
				flag = true;
			}
			if (flag)
			{
				Rewired.Logger.LogError("Failed to unregister mouse.", requiredThreadSafety: true);
			}
		}
		else
		{
			if (!ItjCccIbgxppPbpmRVRgfxkXkOLV)
			{
				return;
			}
			bool KdbcDclniAHwcHRcqIKpBGfZpsEA = false;
			dfRmoZIQwVcWHSVxnTYedFzmfjLj(delegate
			{
				try
				{
					RvMHQisOjyvanvlgzEycFiIzSxN.jJQQTqnRxKlreJHDbdGXKirRlUT((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)2);
				}
				catch
				{
					KdbcDclniAHwcHRcqIKpBGfZpsEA = true;
				}
			}, true);
			if (KdbcDclniAHwcHRcqIKpBGfZpsEA)
			{
				Rewired.Logger.LogError("Failed to unregister mouse.", requiredThreadSafety: true);
			}
		}
	}

	private void ndQgXZunngCtkKBGxFccaIpcrXLV(IntPtr P_0)
	{
		if (aDrIATaHiKqPeBhrEXyogjFIeXCC == jPUUxBbiBalctdVqpNrsXDeuyAB.PaOcfufLRIZBzQjEkZXeGChdtNp)
		{
			sbeGwUfBiGeuEcoLFCmAUCzdiQQD();
			if (P_0 != IntPtr.Zero && P_0 != EVwOOSIMTJQwAVGTPoUvLIidogS.APllICJNRJmhlyPnfYfDTmikppa)
			{
				UapZSQjYJXfytPCzBNUlPGzDeLE = P_0;
				QGLaeTPOeSSuDzhYEWsEYDPBwjT.OANGfGCqzCDTJYxXyCguRviSeSLQ(UapZSQjYJXfytPCzBNUlPGzDeLE, true);
			}
		}
	}

	private void AWrPZlrwjCoRHHjznVwVBnPgyBh()
	{
		if (aDrIATaHiKqPeBhrEXyogjFIeXCC == jPUUxBbiBalctdVqpNrsXDeuyAB.PaOcfufLRIZBzQjEkZXeGChdtNp)
		{
			sbeGwUfBiGeuEcoLFCmAUCzdiQQD();
			QGLaeTPOeSSuDzhYEWsEYDPBwjT.OANGfGCqzCDTJYxXyCguRviSeSLQ(ACNbYRPUxrBoFdJdUOGFerqBoPfQ.value, true);
		}
	}

	private void sbeGwUfBiGeuEcoLFCmAUCzdiQQD()
	{
		if (aDrIATaHiKqPeBhrEXyogjFIeXCC == jPUUxBbiBalctdVqpNrsXDeuyAB.PaOcfufLRIZBzQjEkZXeGChdtNp)
		{
			bool KdbcDclniAHwcHRcqIKpBGfZpsEA = false;
			dfRmoZIQwVcWHSVxnTYedFzmfjLj(delegate
			{
				try
				{
					RvMHQisOjyvanvlgzEycFiIzSxN.WmcAFiXIcgzudeMuZFkSiTIyezSz((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)2, jsjfPGYHvJosyLMTZZuHNbEmlut.nyAShQdNKjMlyrkXvEOtZJJJmOJ, EVwOOSIMTJQwAVGTPoUvLIidogS.APllICJNRJmhlyPnfYfDTmikppa);
				}
				catch
				{
					KdbcDclniAHwcHRcqIKpBGfZpsEA = true;
				}
			}, true);
			if (KdbcDclniAHwcHRcqIKpBGfZpsEA)
			{
				Rewired.Logger.LogError("Failed to register mouse.", requiredThreadSafety: true);
				ItjCccIbgxppPbpmRVRgfxkXkOLV = false;
				eaBTyDyzTScWXkTAyfSAFNdVACC.lniiWJwGWtadnDScpppWlpTlmzW(false);
				return;
			}
		}
		if (!ItjCccIbgxppPbpmRVRgfxkXkOLV)
		{
			ItjCccIbgxppPbpmRVRgfxkXkOLV = true;
			eaBTyDyzTScWXkTAyfSAFNdVACC.lniiWJwGWtadnDScpppWlpTlmzW(true);
		}
	}

	public static bool jbFEuENbVgmYUSpSznqKLhZMxXB(oSOUlQdLYlWXufXtmhhLTsjyryU P_0, out uint P_1)
	{
		P_1 = 0u;
		if (P_0 == null)
		{
			return false;
		}
		uint maxDevices = (uint)P_0.UbpGAWLLXpWbGXsnOkgbdRsWzPC;
		P_1 = FzngAIhKGFOAkXUDRNTZlbDTVEc.jbFEuENbVgmYUSpSznqKLhZMxXB(P_0, ref maxDevices, (uint)P_0.wfEurdUvNJPuAygkopkwOhzVSTL);
		return P_1 != 0;
	}

	private unsafe bool hKGmwtVLbAiLNsOtgTgBzwbQWPg(ControllerType P_0, oSOUlQdLYlWXufXtmhhLTsjyryU P_1, uint P_2, out IntPtr P_3)
	{
		P_3 = IntPtr.Zero;
		if (P_1 == null)
		{
			return false;
		}
		for (int i = 0; i < P_2; i++)
		{
			IntPtr pointer = P_1.GetPointer(i * P_1.wfEurdUvNJPuAygkopkwOhzVSTL);
			hVMoguTLozmBMSscMlXBhfvSOUa* ptr = (hVMoguTLozmBMSscMlXBhfvSOUa*)(void*)pointer;
			switch (P_0)
			{
			case ControllerType.Keyboard:
				if (ptr->YxVFJDmgAkRgCcCvUfhmITfzYBad == 1 && ptr->MNRaihHKuqDsUzvPGSYEtAEmyqK == 6 && ptr->KAKTuIuNEBRZqzhZxRcoMnBKJbR != IntPtr.Zero && ptr->KAKTuIuNEBRZqzhZxRcoMnBKJbR != EVwOOSIMTJQwAVGTPoUvLIidogS.APllICJNRJmhlyPnfYfDTmikppa)
				{
					P_3 = ptr->KAKTuIuNEBRZqzhZxRcoMnBKJbR;
					return true;
				}
				break;
			case ControllerType.Mouse:
				if (ptr->YxVFJDmgAkRgCcCvUfhmITfzYBad == 1 && ptr->MNRaihHKuqDsUzvPGSYEtAEmyqK == 2 && ptr->KAKTuIuNEBRZqzhZxRcoMnBKJbR != IntPtr.Zero && ptr->KAKTuIuNEBRZqzhZxRcoMnBKJbR != EVwOOSIMTJQwAVGTPoUvLIidogS.APllICJNRJmhlyPnfYfDTmikppa)
				{
					P_3 = ptr->KAKTuIuNEBRZqzhZxRcoMnBKJbR;
					return true;
				}
				break;
			}
		}
		return false;
	}

	private unsafe IntPtr iYHGTpXvXRDvbHvhSNzUBTobLES()
	{
		oSOUlQdLYlWXufXtmhhLTsjyryU oSOUlQdLYlWXufXtmhhLTsjyryU2 = null;
		try
		{
			oSOUlQdLYlWXufXtmhhLTsjyryU2 = new oSOUlQdLYlWXufXtmhhLTsjyryU(hVMoguTLozmBMSscMlXBhfvSOUa.FTFnRnACjJSaBVoElVrLcditcJX, 100);
			uint maxDevices = (uint)oSOUlQdLYlWXufXtmhhLTsjyryU2.UbpGAWLLXpWbGXsnOkgbdRsWzPC;
			uint num = FzngAIhKGFOAkXUDRNTZlbDTVEc.jbFEuENbVgmYUSpSznqKLhZMxXB(oSOUlQdLYlWXufXtmhhLTsjyryU2, ref maxDevices, (uint)oSOUlQdLYlWXufXtmhhLTsjyryU2.wfEurdUvNJPuAygkopkwOhzVSTL);
			if (num == 0)
			{
				return IntPtr.Zero;
			}
			for (int i = 0; i < num; i++)
			{
				IntPtr pointer = oSOUlQdLYlWXufXtmhhLTsjyryU2.GetPointer(i * oSOUlQdLYlWXufXtmhhLTsjyryU2.wfEurdUvNJPuAygkopkwOhzVSTL);
				hVMoguTLozmBMSscMlXBhfvSOUa* ptr = (hVMoguTLozmBMSscMlXBhfvSOUa*)(void*)pointer;
				Rewired.Logger.Log("RI DEVICE " + i);
				Rewired.Logger.Log("usage = " + ptr->MNRaihHKuqDsUzvPGSYEtAEmyqK);
				Rewired.Logger.Log("usagePage = " + ptr->YxVFJDmgAkRgCcCvUfhmITfzYBad);
				Rewired.Logger.Log("flags = " + ptr->jMbdrySazXGxqBoUZJERaOtVVTv);
				Rewired.Logger.Log("target = " + ptr->KAKTuIuNEBRZqzhZxRcoMnBKJbR);
				if (ptr->YxVFJDmgAkRgCcCvUfhmITfzYBad == 1 && ptr->MNRaihHKuqDsUzvPGSYEtAEmyqK == 2 && ptr->KAKTuIuNEBRZqzhZxRcoMnBKJbR != IntPtr.Zero && ptr->KAKTuIuNEBRZqzhZxRcoMnBKJbR != EVwOOSIMTJQwAVGTPoUvLIidogS.APllICJNRJmhlyPnfYfDTmikppa)
				{
					return ptr->KAKTuIuNEBRZqzhZxRcoMnBKJbR;
				}
			}
			return IntPtr.Zero;
		}
		catch
		{
			return IntPtr.Zero;
		}
		finally
		{
			oSOUlQdLYlWXufXtmhhLTsjyryU2?.Dispose();
		}
	}

	private void IcnAiByfnHidcNaysDPSaqbCiFRe(IntPtr P_0)
	{
		if (aDrIATaHiKqPeBhrEXyogjFIeXCC == jPUUxBbiBalctdVqpNrsXDeuyAB.PaOcfufLRIZBzQjEkZXeGChdtNp)
		{
			macfYwHfTTEAHtsnBkfHiNWmbJI();
			if (P_0 != IntPtr.Zero && P_0 != EVwOOSIMTJQwAVGTPoUvLIidogS.APllICJNRJmhlyPnfYfDTmikppa)
			{
				IKdgojlJUuCLVAkHaTBeoQGILhCr = P_0;
			}
		}
	}

	private void xNhaAxYAFCCKUDOIwTEMmYPBpGA()
	{
		if (aDrIATaHiKqPeBhrEXyogjFIeXCC == jPUUxBbiBalctdVqpNrsXDeuyAB.PaOcfufLRIZBzQjEkZXeGChdtNp)
		{
			macfYwHfTTEAHtsnBkfHiNWmbJI();
		}
	}

	private void macfYwHfTTEAHtsnBkfHiNWmbJI()
	{
		if (aDrIATaHiKqPeBhrEXyogjFIeXCC == jPUUxBbiBalctdVqpNrsXDeuyAB.PaOcfufLRIZBzQjEkZXeGChdtNp)
		{
			bool KdbcDclniAHwcHRcqIKpBGfZpsEA = false;
			dfRmoZIQwVcWHSVxnTYedFzmfjLj(delegate
			{
				try
				{
					RvMHQisOjyvanvlgzEycFiIzSxN.WmcAFiXIcgzudeMuZFkSiTIyezSz((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)6, jsjfPGYHvJosyLMTZZuHNbEmlut.nyAShQdNKjMlyrkXvEOtZJJJmOJ, EVwOOSIMTJQwAVGTPoUvLIidogS.APllICJNRJmhlyPnfYfDTmikppa);
				}
				catch
				{
					KdbcDclniAHwcHRcqIKpBGfZpsEA = true;
				}
			}, true);
			if (KdbcDclniAHwcHRcqIKpBGfZpsEA)
			{
				Rewired.Logger.LogError("Failed to register keyboard.", requiredThreadSafety: true);
				eVfWUxWGHGlAaYTdzrUYWXftojD = false;
				TMjgRIUfmiDNubEorZTytoDVyld.lniiWJwGWtadnDScpppWlpTlmzW(false);
				return;
			}
		}
		if (!eVfWUxWGHGlAaYTdzrUYWXftojD)
		{
			eVfWUxWGHGlAaYTdzrUYWXftojD = true;
			TMjgRIUfmiDNubEorZTytoDVyld.lniiWJwGWtadnDScpppWlpTlmzW(true);
		}
	}

	private void zBbKHwMnkzrrAlgHWmnaXFEkWNo()
	{
		if (aDrIATaHiKqPeBhrEXyogjFIeXCC == jPUUxBbiBalctdVqpNrsXDeuyAB.PaOcfufLRIZBzQjEkZXeGChdtNp)
		{
			xFjXbxDKuEoTeAzhoiyQPRvMGQI();
		}
		eVfWUxWGHGlAaYTdzrUYWXftojD = false;
		TMjgRIUfmiDNubEorZTytoDVyld.lniiWJwGWtadnDScpppWlpTlmzW(false);
	}

	private void xFjXbxDKuEoTeAzhoiyQPRvMGQI()
	{
		if (!iIwUOirxOAPopNHowMFDfsCjcgB || aDrIATaHiKqPeBhrEXyogjFIeXCC != 0)
		{
			return;
		}
		IntPtr intPtr;
		if (VUjjFdeMXVjpMKMhYRosEXhUuLM)
		{
			jbFEuENbVgmYUSpSznqKLhZMxXB(pESAFpQGBoTlVGdWQfwAzqmPjIO, out var num);
			if (hKGmwtVLbAiLNsOtgTgBzwbQWPg(ControllerType.Keyboard, pESAFpQGBoTlVGdWQfwAzqmPjIO, num, out var iKdgojlJUuCLVAkHaTBeoQGILhCr))
			{
				IKdgojlJUuCLVAkHaTBeoQGILhCr = iKdgojlJUuCLVAkHaTBeoQGILhCr;
			}
			intPtr = IKdgojlJUuCLVAkHaTBeoQGILhCr;
		}
		else
		{
			intPtr = FzngAIhKGFOAkXUDRNTZlbDTVEc.NPKxqbrJOXBOjYozsbheDTjQCapS();
		}
		if (intPtr != IntPtr.Zero)
		{
			bool flag = false;
			try
			{
				RvMHQisOjyvanvlgzEycFiIzSxN.WmcAFiXIcgzudeMuZFkSiTIyezSz((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)6, jsjfPGYHvJosyLMTZZuHNbEmlut.nyAShQdNKjMlyrkXvEOtZJJJmOJ, intPtr);
			}
			catch
			{
				flag = true;
			}
			if (flag)
			{
				Rewired.Logger.LogError("Failed to unregister keyboard.", requiredThreadSafety: true);
			}
		}
		else
		{
			if (!eVfWUxWGHGlAaYTdzrUYWXftojD)
			{
				return;
			}
			bool KdbcDclniAHwcHRcqIKpBGfZpsEA = false;
			dfRmoZIQwVcWHSVxnTYedFzmfjLj(delegate
			{
				try
				{
					RvMHQisOjyvanvlgzEycFiIzSxN.jJQQTqnRxKlreJHDbdGXKirRlUT((zUcsEXgRrpTTuylslYMZNHbGVwI)1, (QZaHVGYkaaUvpuhZHPmbaNhDycJ)6);
				}
				catch
				{
					KdbcDclniAHwcHRcqIKpBGfZpsEA = true;
				}
			}, true);
			if (KdbcDclniAHwcHRcqIKpBGfZpsEA)
			{
				Rewired.Logger.LogError("Failed to unregister keyboard.", requiredThreadSafety: true);
			}
		}
	}

	private void UWhUtGzbQCyGuHnjVeeztWtauBQ()
	{
		if (aDrIATaHiKqPeBhrEXyogjFIeXCC == jPUUxBbiBalctdVqpNrsXDeuyAB.PaOcfufLRIZBzQjEkZXeGChdtNp)
		{
			if (ZSJeoeAgfltDyiGQZOstfnhVwtkF)
			{
				ErSHdDsvZJjLStLJyEAocrqViAb();
			}
			QDOgqXghQUKVCENoHkfCpprCqEBc();
			if (iIwUOirxOAPopNHowMFDfsCjcgB)
			{
				zBbKHwMnkzrrAlgHWmnaXFEkWNo();
			}
		}
		else if (ZSJeoeAgfltDyiGQZOstfnhVwtkF)
		{
			ErSHdDsvZJjLStLJyEAocrqViAb();
		}
	}

	private void cYEtxwxJcohewrZpEQAxCTxiaCX()
	{
		if (bERdxQEMngIKTcdezlFBctUJBera)
		{
			RvMHQisOjyvanvlgzEycFiIzSxN.gliAULEhtyLvundYTBKaYhdMYjkP += VqOBHSukZZNjXjwBtBRERtJZPWD;
		}
		if (ZSJeoeAgfltDyiGQZOstfnhVwtkF)
		{
			RvMHQisOjyvanvlgzEycFiIzSxN.SkWKXsPByreWkfIZphOgCdACJDv += FwUGNrguNRzmQTyyXQtYsCaasJcj;
		}
		if (iIwUOirxOAPopNHowMFDfsCjcgB)
		{
			RvMHQisOjyvanvlgzEycFiIzSxN.ZpeABHKRNsJUGIkdLqkIcOgjkINj += fOaCeASOmITRQnzQcSgpPXajAes;
		}
		if (bERdxQEMngIKTcdezlFBctUJBera || ZSJeoeAgfltDyiGQZOstfnhVwtkF || iIwUOirxOAPopNHowMFDfsCjcgB)
		{
			RvMHQisOjyvanvlgzEycFiIzSxN.cnPtxUsrfEsgVOLONDxTccaVcpp += rcHWWridruGobAhpqzWfsjAULyXj;
			RvMHQisOjyvanvlgzEycFiIzSxN.znXDINUcaSpSLBQsoaQnnXtWxYE += oKrgvxUmeHHhuIofnqVpZSCewprE;
		}
	}

	private void FjpgjofZWPlveaqhwTRpjRKySRlg()
	{
		if (bERdxQEMngIKTcdezlFBctUJBera)
		{
			RvMHQisOjyvanvlgzEycFiIzSxN.gliAULEhtyLvundYTBKaYhdMYjkP -= VqOBHSukZZNjXjwBtBRERtJZPWD;
		}
		if (ZSJeoeAgfltDyiGQZOstfnhVwtkF)
		{
			RvMHQisOjyvanvlgzEycFiIzSxN.SkWKXsPByreWkfIZphOgCdACJDv -= FwUGNrguNRzmQTyyXQtYsCaasJcj;
		}
		if (iIwUOirxOAPopNHowMFDfsCjcgB)
		{
			RvMHQisOjyvanvlgzEycFiIzSxN.ZpeABHKRNsJUGIkdLqkIcOgjkINj -= fOaCeASOmITRQnzQcSgpPXajAes;
		}
		if (bERdxQEMngIKTcdezlFBctUJBera || ZSJeoeAgfltDyiGQZOstfnhVwtkF || iIwUOirxOAPopNHowMFDfsCjcgB)
		{
			RvMHQisOjyvanvlgzEycFiIzSxN.cnPtxUsrfEsgVOLONDxTccaVcpp -= rcHWWridruGobAhpqzWfsjAULyXj;
			RvMHQisOjyvanvlgzEycFiIzSxN.znXDINUcaSpSLBQsoaQnnXtWxYE -= oKrgvxUmeHHhuIofnqVpZSCewprE;
		}
	}

	private void dBKVowJCOvAQAnyqNBQgssIgXRI(iDxdeTNcZIetTcswDuZFhoDBYPo.KKIEjjaeKeXuNtYqIevqXZTWmry P_0)
	{
		bool KdbcDclniAHwcHRcqIKpBGfZpsEA = false;
		dfRmoZIQwVcWHSVxnTYedFzmfjLj(delegate
		{
			try
			{
				EVwOOSIMTJQwAVGTPoUvLIidogS = asqLHFOXxfKabJWoXmingDpjhui(P_0);
				if (EVwOOSIMTJQwAVGTPoUvLIidogS == null)
				{
					throw new Exception();
				}
			}
			catch
			{
				KdbcDclniAHwcHRcqIKpBGfZpsEA = true;
			}
		}, true);
		if (KdbcDclniAHwcHRcqIKpBGfZpsEA)
		{
			throw new Exception("Error creating message window.");
		}
	}

	private static iDxdeTNcZIetTcswDuZFhoDBYPo asqLHFOXxfKabJWoXmingDpjhui(iDxdeTNcZIetTcswDuZFhoDBYPo.KKIEjjaeKeXuNtYqIevqXZTWmry P_0)
	{
		iDxdeTNcZIetTcswDuZFhoDBYPo iDxdeTNcZIetTcswDuZFhoDBYPo2 = new iDxdeTNcZIetTcswDuZFhoDBYPo("RewiredMesssageWindow", createMessageOnlyWindow: true, P_0);
		if (iDxdeTNcZIetTcswDuZFhoDBYPo2.APllICJNRJmhlyPnfYfDTmikppa == IntPtr.Zero)
		{
			iDxdeTNcZIetTcswDuZFhoDBYPo2.Dispose();
			return null;
		}
		return iDxdeTNcZIetTcswDuZFhoDBYPo2;
	}

	private void LgLbgrXSqTFWhSjHUEZwMRZFBAyG()
	{
		if (aDrIATaHiKqPeBhrEXyogjFIeXCC != 0)
		{
			return;
		}
		QGLaeTPOeSSuDzhYEWsEYDPBwjT.MGdUCgKavLcKdZVSFfqcdWqSuzTp();
		if (bERdxQEMngIKTcdezlFBctUJBera)
		{
			ObNGuKuHQeiteAcmPGizFwpuqcX();
		}
		if (ZSJeoeAgfltDyiGQZOstfnhVwtkF || iIwUOirxOAPopNHowMFDfsCjcgB)
		{
			pESAFpQGBoTlVGdWQfwAzqmPjIO = new oSOUlQdLYlWXufXtmhhLTsjyryU(hVMoguTLozmBMSscMlXBhfvSOUa.FTFnRnACjJSaBVoElVrLcditcJX, 100);
			if (VUjjFdeMXVjpMKMhYRosEXhUuLM)
			{
				tiQGcKKTPHKqeDUGdLkldoTbuXDe = 1;
			}
			else
			{
				if (ZSJeoeAgfltDyiGQZOstfnhVwtkF)
				{
					AWrPZlrwjCoRHHjznVwVBnPgyBh();
				}
				if (iIwUOirxOAPopNHowMFDfsCjcgB)
				{
					xNhaAxYAFCCKUDOIwTEMmYPBpGA();
				}
			}
		}
		KhdthfnJoMeaodwdaAsGnSaOzSJ = QGLaeTPOeSSuDzhYEWsEYDPBwjT.fSGilUBupDgqsHmMHIijyhrAWjK();
	}

	private void wXDBnbcPpgZoKvKMlZWZJCIYeQs()
	{
		if (!VUjjFdeMXVjpMKMhYRosEXhUuLM || aDrIATaHiKqPeBhrEXyogjFIeXCC != 0)
		{
			return;
		}
		if (tiQGcKKTPHKqeDUGdLkldoTbuXDe > 0)
		{
			tiQGcKKTPHKqeDUGdLkldoTbuXDe--;
			return;
		}
		jbFEuENbVgmYUSpSznqKLhZMxXB(pESAFpQGBoTlVGdWQfwAzqmPjIO, out var num);
		if (ZSJeoeAgfltDyiGQZOstfnhVwtkF)
		{
			hKGmwtVLbAiLNsOtgTgBzwbQWPg(ControllerType.Mouse, pESAFpQGBoTlVGdWQfwAzqmPjIO, num, out var intPtr);
			ndQgXZunngCtkKBGxFccaIpcrXLV(intPtr);
		}
		if (iIwUOirxOAPopNHowMFDfsCjcgB)
		{
			hKGmwtVLbAiLNsOtgTgBzwbQWPg(ControllerType.Keyboard, pESAFpQGBoTlVGdWQfwAzqmPjIO, num, out var intPtr2);
			IcnAiByfnHidcNaysDPSaqbCiFRe(intPtr2);
		}
		tiQGcKKTPHKqeDUGdLkldoTbuXDe = -1;
	}

	private void DqxtysakswXnmJvCUDCRDZHwEjX(bool P_0)
	{
		if (ZSJeoeAgfltDyiGQZOstfnhVwtkF)
		{
			AWrPZlrwjCoRHHjznVwVBnPgyBh();
		}
		if (iIwUOirxOAPopNHowMFDfsCjcgB)
		{
			macfYwHfTTEAHtsnBkfHiNWmbJI();
		}
	}

	private void XuwRtZUIFZwTMvgosiGZtTZvTlG(FullScreenMode P_0)
	{
		if (ZSJeoeAgfltDyiGQZOstfnhVwtkF)
		{
			QVYxBwIdXNTUBZJkgEappZaLuLr();
		}
	}

	private void GMwNzuKvvRguCFdANBBvMBVNGXH(IntPtr P_0)
	{
		if (!VUjjFdeMXVjpMKMhYRosEXhUuLM)
		{
			if (ZSJeoeAgfltDyiGQZOstfnhVwtkF)
			{
				AWrPZlrwjCoRHHjznVwVBnPgyBh();
			}
			if (iIwUOirxOAPopNHowMFDfsCjcgB)
			{
				xNhaAxYAFCCKUDOIwTEMmYPBpGA();
			}
		}
	}

	private IntPtr FIfrRxulAJbEPMZezWjIEInngCc(IntPtr P_0, uint P_1, IntPtr P_2, IntPtr P_3)
	{
		if (jpnIPbpqmlecdiNqaFAxiNCsiMxs)
		{
			return IntPtr.Zero;
		}
		if (KhdthfnJoMeaodwdaAsGnSaOzSJ != null)
		{
			KhdthfnJoMeaodwdaAsGnSaOzSJ(P_0, P_1, P_2, P_3);
		}
		return IntPtr.Zero;
	}

	private void dfRmoZIQwVcWHSVxnTYedFzmfjLj(Action P_0, bool P_1)
	{
		P_0?.Invoke();
	}

	private void VqOBHSukZZNjXjwBtBRERtJZPWD(arqwvMUuunLbDqdcqHYDaxGWWsC P_0, double P_1)
	{
		try
		{
			mzzdzBQHifxmhJLULaMnmJppewG(edIjNHJxgLBHXzZHkFeKSgvMhRu.gliAULEhtyLvundYTBKaYhdMYjkP, P_0.VhBTBMdAFpqaWuODnxKAnlMulqD)?.TPCPMwmmloEvGakccpOtGdgkPDqZ(P_0.ZBGrZUldPcIiWuwkUFVkEUPgRLj, P_0.dxZDKATDnZQnTqSLUlpzQjjjZkn, P_0.UsbDFKzTViCdeDmSneiJKBYbdnj, P_0.rHgvAWfvcVetfzBNIUSpjxABFaI, P_1);
		}
		catch
		{
		}
	}

	private void cPUDqYkrrfqYbSxnYBePfnbKMNKn(CpWakiVnNiNXfxCUhKtwwgUaftG P_0)
	{
		try
		{
			mzzdzBQHifxmhJLULaMnmJppewG(edIjNHJxgLBHXzZHkFeKSgvMhRu.gliAULEhtyLvundYTBKaYhdMYjkP, P_0.GimIILJmyeYgyOLgHcSzyDOWuaf)?.TPCPMwmmloEvGakccpOtGdgkPDqZ(P_0.WGgJCJiomCkXJLMybnKhadhaHXu, P_0.mIxZuxUjngFKhjyGRAYyyKAUWEd, P_0.XBGgLTtTUVjPgdLFNjczDGxUMZx, P_0.IEvGOBtiUKfekuHgiGUTHMRACLM, P_0.whnSCgYhOHHdijUNBdmxeaEVvKvd);
		}
		catch
		{
		}
	}

	private void FwUGNrguNRzmQTyyXQtYsCaasJcj(AcUaPQzGWdWYaglJmWnskdiCgNK P_0, double P_1)
	{
		qaOQzZEmmCWEObGtdbAErZfBpxs.TxqPmgQJJZQbZzjuubnQExXfSKBm(ref P_0);
		nNEbyrwBuhwYcXfsWDmUbhiJEPX(qaOQzZEmmCWEObGtdbAErZfBpxs, P_1);
	}

	private void nNEbyrwBuhwYcXfsWDmUbhiJEPX(MYwKmedBLcNvIZZHCnRMIWoJnsa P_0, double P_1)
	{
		try
		{
			eaBTyDyzTScWXkTAyfSAFNdVACC.kcpIBCdrZEFAOcZMterMlSZVafR(P_0);
		}
		catch (Exception)
		{
		}
	}

	private void fOaCeASOmITRQnzQcSgpPXajAes(rqqboATdKanXVBANwiRWmVDCWLd P_0, double P_1)
	{
		nDfyronUGTNreUSTFIFZSmgjkri.TxqPmgQJJZQbZzjuubnQExXfSKBm(ref P_0);
		ikRVbTZeXgUfipbYFomqZqlBuZo(nDfyronUGTNreUSTFIFZSmgjkri, P_1);
	}

	private void ikRVbTZeXgUfipbYFomqZqlBuZo(fEwvYsosGHESMUTjAtCcjZZuQJI P_0, double P_1)
	{
		try
		{
			TMjgRIUfmiDNubEorZTytoDVyld.kcpIBCdrZEFAOcZMterMlSZVafR(P_0);
		}
		catch
		{
		}
	}

	private void rcHWWridruGobAhpqzWfsjAULyXj(IntPtr P_0)
	{
		uJoiugGnSiZQnVqgxHdKXSrispe = true;
	}

	private void oKrgvxUmeHHhuIofnqVpZSCewprE()
	{
		uJoiugGnSiZQnVqgxHdKXSrispe = true;
	}

	public void Dispose()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
		GC.SuppressFinalize(this);
	}

	~RsVeIRZnmCozInvuVtbXAPKPjeyA()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
	}

	protected virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (jpnIPbpqmlecdiNqaFAxiNCsiMxs)
		{
			return;
		}
		FjpgjofZWPlveaqhwTRpjRKySRlg();
		ReInput.ApplicationIsFullScreenChangedEvent -= DqxtysakswXnmJvCUDCRDZHwEjX;
		ReInput.ApplicationFullScreenModeChangedEvent -= XuwRtZUIFZwTMvgosiGZtTZvTlG;
		lock (sASCLGHuXbDiqdETFUiqWNTTBYcm)
		{
			if (P_0 && MYIilGlzGtMSBPimluqBFDXADRJ != null)
			{
				for (int i = 0; i < MYIilGlzGtMSBPimluqBFDXADRJ.Count; i++)
				{
					if (MYIilGlzGtMSBPimluqBFDXADRJ[i] != null)
					{
						MYIilGlzGtMSBPimluqBFDXADRJ[i].PiVpHzafoUMfSDFNLmfkEJnjpdO();
						MYIilGlzGtMSBPimluqBFDXADRJ[i].Dispose();
					}
				}
			}
			UWhUtGzbQCyGuHnjVeeztWtauBQ();
			if (EVwOOSIMTJQwAVGTPoUvLIidogS != null)
			{
				EVwOOSIMTJQwAVGTPoUvLIidogS.Dispose();
				EVwOOSIMTJQwAVGTPoUvLIidogS = null;
			}
			if (ZSJeoeAgfltDyiGQZOstfnhVwtkF && eaBTyDyzTScWXkTAyfSAFNdVACC != null)
			{
				eaBTyDyzTScWXkTAyfSAFNdVACC.Dispose();
			}
			if (iIwUOirxOAPopNHowMFDfsCjcgB && TMjgRIUfmiDNubEorZTytoDVyld != null)
			{
				TMjgRIUfmiDNubEorZTytoDVyld.Dispose();
			}
			QGLaeTPOeSSuDzhYEWsEYDPBwjT.PMzamCeIIFqnzgwGlxEbIeTHBFUL();
		}
		if (pESAFpQGBoTlVGdWQfwAzqmPjIO != null)
		{
			pESAFpQGBoTlVGdWQfwAzqmPjIO.Dispose();
		}
		jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
	}

	public unsafe static bool yOGBVwgQmTPAYhDSekCIUhJNbFUc(ZLCskcBqtJByBhszckujrsvBGnPh P_0, out int P_1)
	{
		P_1 = 0;
		uint num = 0u;
		FzngAIhKGFOAkXUDRNTZlbDTVEc.BltnqxmiIvdSyCqPYnANAHSIvHzq(IntPtr.Zero, ref num, (uint)Marshal.SizeOf(typeof(XejzeUvgutfbSkwWeQaFpJwCZEW)));
		if (num == 0)
		{
			return false;
		}
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		XejzeUvgutfbSkwWeQaFpJwCZEW* ptr = stackalloc XejzeUvgutfbSkwWeQaFpJwCZEW[(int)num];
		FzngAIhKGFOAkXUDRNTZlbDTVEc.BltnqxmiIvdSyCqPYnANAHSIvHzq((IntPtr)ptr, ref num, (uint)Marshal.SizeOf(typeof(XejzeUvgutfbSkwWeQaFpJwCZEW)));
		for (int i = 0; i < num; i++)
		{
			IntPtr vhBTBMdAFpqaWuODnxKAnlMulqD = ptr[i].VhBTBMdAFpqaWuODnxKAnlMulqD;
			int num5 = 0;
			int num6 = cZEAfFusPwtBncvnGcfLrVnBtky.hjcQwblPdzEbaTqLtBnrbTrCilj(vhBTBMdAFpqaWuODnxKAnlMulqD, lpgIqBFTWuIztCWtjjIgfcnwVpA.XJZVwRYqmzWKUzForhiqBEJJVZm, IntPtr.Zero, ref num5);
			if (num5 == 0)
			{
				num4++;
				continue;
			}
			num3++;
			byte* ptr2 = stackalloc byte[(int)(uint)num5];
			*(int*)ptr2 = num5;
			num6 = cZEAfFusPwtBncvnGcfLrVnBtky.hjcQwblPdzEbaTqLtBnrbTrCilj(vhBTBMdAFpqaWuODnxKAnlMulqD, lpgIqBFTWuIztCWtjjIgfcnwVpA.XJZVwRYqmzWKUzForhiqBEJJVZm, (IntPtr)ptr2, ref num5);
			if (num6 >= 0)
			{
				vVQLmLaBCsCDuCoyfffTHKgYEAE vVQLmLaBCsCDuCoyfffTHKgYEAE2 = *(vVQLmLaBCsCDuCoyfffTHKgYEAE*)ptr2;
				if (vVQLmLaBCsCDuCoyfffTHKgYEAE2.HmQyuofUsvomGjtCuiqveOpNWlh == P_0)
				{
					num2++;
				}
			}
		}
		if (num4 > 0 && num3 == 0)
		{
			return false;
		}
		P_1 = num2;
		return true;
	}

	[CompilerGenerated]
	private static void XXldDxSNmgAQbWvPMUEegTEFxrK(KXNanfFdezOfVOeIdsOvMHQobbRn P_0)
	{
		P_0.Dispose();
	}
}
