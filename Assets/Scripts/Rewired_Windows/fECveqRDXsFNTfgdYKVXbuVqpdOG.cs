using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

internal static class fECveqRDXsFNTfgdYKVXbuVqpdOG
{
	public unsafe static int OlnhbrDBNbKMFtYTynGVPRNomKN(int P_0, int P_1, out qomXTqkdqnxrVAFzVlinpbDHCbn P_2)
	{
		if (TMbQezmaCdrQdaUPTidokyxxlgC.zIflZzLzCoeygkWXSUmehAtmeiX >= FfhchLVRtXvbFSLPIuTTTAbQgdH.PtwheSqQzfIQEbQnCjFJHQuNduus)
		{
			P_2 = default(qomXTqkdqnxrVAFzVlinpbDHCbn);
			return 0;
		}
		P_2 = default(qomXTqkdqnxrVAFzVlinpbDHCbn);
		int result;
		fixed (IntPtr* ptr = &System.Runtime.CompilerServices.Unsafe.As<qomXTqkdqnxrVAFzVlinpbDHCbn, IntPtr>(ref P_2))
		{
			result = VNpGmvZEnWdgPACIwkLyPUfxQEh(P_0, P_1, ptr);
		}
		return result;
	}

	private unsafe static int VNpGmvZEnWdgPACIwkLyPUfxQEh(int P_0, int P_1, void* P_2)
	{
		return TMbQezmaCdrQdaUPTidokyxxlgC.zIflZzLzCoeygkWXSUmehAtmeiX switch
		{
			FfhchLVRtXvbFSLPIuTTTAbQgdH.WiPetAAHSdpdxXhmYQajHMhVFrd => sIWCnbsuWGkOksyLftagoJBvYgo(P_0, P_1, P_2), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.HgMBQPrarJURYOnszEwZkNAQeoz => YcJxtByiZKFafZHVPLoGxnEDEKE(P_0, P_1, P_2), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.ZDHeANZlTnXdSggQsOJZPfnkdst => nwGFfeaZAptSRcrwLTjvEJBLlQx(P_0, P_1, P_2), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.kjLfBrqcAPuvxOtdpMHkyQDNprr => EWLCfGuxiMZWruwYHUrCyeRtSMo(P_0, P_1, P_2), 
			_ => 0, 
		};
	}

	[DllImport("xinput9_1_0.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetKeystroke")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int EWLCfGuxiMZWruwYHUrCyeRtSMo(int P_0, int P_1, void* P_2);

	[DllImport("xinput1_1.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetKeystroke")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int nwGFfeaZAptSRcrwLTjvEJBLlQx(int P_0, int P_1, void* P_2);

	[DllImport("xinput1_2.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetKeystroke")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int YcJxtByiZKFafZHVPLoGxnEDEKE(int P_0, int P_1, void* P_2);

	[DllImport("xinput1_3.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetKeystroke")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int sIWCnbsuWGkOksyLftagoJBvYgo(int P_0, int P_1, void* P_2);

	public unsafe static int zSedZBaCKhZMpcEpYpbMaDtwMFAg(int P_0, FAIBoIXMzneqbVBBCMdcaRKySdU P_1)
	{
		return ztKykeilkkcNUtmyEZbEwPIGJOx(P_0, &P_1);
	}

	private unsafe static int ztKykeilkkcNUtmyEZbEwPIGJOx(int P_0, void* P_1)
	{
		return TMbQezmaCdrQdaUPTidokyxxlgC.zIflZzLzCoeygkWXSUmehAtmeiX switch
		{
			FfhchLVRtXvbFSLPIuTTTAbQgdH.PtwheSqQzfIQEbQnCjFJHQuNduus => PGwJCykRLJRLVesJGtRNFUQxTmP(P_0, P_1), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.WiPetAAHSdpdxXhmYQajHMhVFrd => kUcddMqoLdVArqwFzKQnZDORfdpj(P_0, P_1), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.HgMBQPrarJURYOnszEwZkNAQeoz => tQeEdreLURcAVumhYNPrIOwwCJV(P_0, P_1), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.ZDHeANZlTnXdSggQsOJZPfnkdst => bhVRSsKEKaCJBanVQyxhFqOqoNz(P_0, P_1), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.kjLfBrqcAPuvxOtdpMHkyQDNprr => mtuAmvYuDwYfpdmUaCfSAoMLgWtc(P_0, P_1), 
			_ => 0, 
		};
	}

	[DllImport("xinput9_1_0.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputSetState")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int mtuAmvYuDwYfpdmUaCfSAoMLgWtc(int P_0, void* P_1);

	[DllImport("xinput1_1.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputSetState")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int bhVRSsKEKaCJBanVQyxhFqOqoNz(int P_0, void* P_1);

	[DllImport("xinput1_2.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputSetState")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int tQeEdreLURcAVumhYNPrIOwwCJV(int P_0, void* P_1);

	[DllImport("xinput1_3.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputSetState")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int kUcddMqoLdVArqwFzKQnZDORfdpj(int P_0, void* P_1);

	[DllImport("xinput1_4.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputSetState")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int PGwJCykRLJRLVesJGtRNFUQxTmP(int P_0, void* P_1);

	public unsafe static int XZvXHeVZVHfcheRTRClpxNvtDWj(int P_0, out Guid P_1, out Guid P_2)
	{
		P_1 = default(Guid);
		P_2 = default(Guid);
		int result;
		fixed (IntPtr* ptr = &System.Runtime.CompilerServices.Unsafe.As<Guid, IntPtr>(ref P_1))
		{
			fixed (IntPtr* ptr2 = &System.Runtime.CompilerServices.Unsafe.As<Guid, IntPtr>(ref P_2))
			{
				result = MCzmMRkBqSPBisigicCrYRdZsXd(P_0, ptr, ptr2);
			}
		}
		return result;
	}

	private unsafe static int MCzmMRkBqSPBisigicCrYRdZsXd(int P_0, void* P_1, void* P_2)
	{
		return TMbQezmaCdrQdaUPTidokyxxlgC.zIflZzLzCoeygkWXSUmehAtmeiX switch
		{
			FfhchLVRtXvbFSLPIuTTTAbQgdH.WiPetAAHSdpdxXhmYQajHMhVFrd => pqjcZrxcppaRoHkshvnxVjXUUIH(P_0, P_1, P_2), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.HgMBQPrarJURYOnszEwZkNAQeoz => URXBkUUituBIDKSZLqgpfNoDXwqA(P_0, P_1, P_2), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.ZDHeANZlTnXdSggQsOJZPfnkdst => PSrmPMuHujeRUMmUouyjIKcbDSg(P_0, P_1, P_2), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.kjLfBrqcAPuvxOtdpMHkyQDNprr => gJsqdwZnbKpwFaFSIpSkqTpkdYV(P_0, P_1, P_2), 
			_ => 0, 
		};
	}

	[DllImport("xinput9_1_0.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetDSoundAudioDeviceGuids")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int gJsqdwZnbKpwFaFSIpSkqTpkdYV(int P_0, void* P_1, void* P_2);

	[DllImport("xinput1_1.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetDSoundAudioDeviceGuids")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int PSrmPMuHujeRUMmUouyjIKcbDSg(int P_0, void* P_1, void* P_2);

	[DllImport("xinput1_2.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetDSoundAudioDeviceGuids")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int URXBkUUituBIDKSZLqgpfNoDXwqA(int P_0, void* P_1, void* P_2);

	[DllImport("xinput1_3.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetDSoundAudioDeviceGuids")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int pqjcZrxcppaRoHkshvnxVjXUUIH(int P_0, void* P_1, void* P_2);

	[SuppressUnmanagedCodeSecurity]
	public unsafe static int cvACUqIbwuMhYbiUaWpcVeXVeVQ(int P_0, out CFwUXCQJkWGIyLatIBIUVDNybqMD P_1)
	{
		P_1 = default(CFwUXCQJkWGIyLatIBIUVDNybqMD);
		int result;
		fixed (IntPtr* ptr = &System.Runtime.CompilerServices.Unsafe.As<CFwUXCQJkWGIyLatIBIUVDNybqMD, IntPtr>(ref P_1))
		{
			result = fFRKGbYDctZFqdvlpugIaHXIQSx(P_0, ptr);
		}
		return result;
	}

	private unsafe static int fFRKGbYDctZFqdvlpugIaHXIQSx(int P_0, void* P_1)
	{
		if (TMbQezmaCdrQdaUPTidokyxxlgC.jnogiZDQAYmpbpicZbxLSFiWIRRc && TMbQezmaCdrQdaUPTidokyxxlgC.ujCEFfDhQNZleMfgdePiBtpbPojF != null)
		{
			return TMbQezmaCdrQdaUPTidokyxxlgC.ujCEFfDhQNZleMfgdePiBtpbPojF(P_0, P_1);
		}
		return TMbQezmaCdrQdaUPTidokyxxlgC.zIflZzLzCoeygkWXSUmehAtmeiX switch
		{
			FfhchLVRtXvbFSLPIuTTTAbQgdH.PtwheSqQzfIQEbQnCjFJHQuNduus => KoyaAjZnoAegRiIRjDyYopaXcWkA(P_0, P_1), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.WiPetAAHSdpdxXhmYQajHMhVFrd => zFDozSFqRRGusokraJwtTWnEuAg(P_0, P_1), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.HgMBQPrarJURYOnszEwZkNAQeoz => efpeKNfPzKiPkEQHAdUDGjiAQduX(P_0, P_1), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.ZDHeANZlTnXdSggQsOJZPfnkdst => trNywCCAbnvSSrLzOcgMZpRBfKNi(P_0, P_1), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.kjLfBrqcAPuvxOtdpMHkyQDNprr => bglmnHgTukqaZQAPUCXBCZIkBpgK(P_0, P_1), 
			_ => 0, 
		};
	}

	[DllImport("xinput9_1_0.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetState")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int bglmnHgTukqaZQAPUCXBCZIkBpgK(int P_0, void* P_1);

	[DllImport("xinput1_1.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetState")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int trNywCCAbnvSSrLzOcgMZpRBfKNi(int P_0, void* P_1);

	[DllImport("xinput1_2.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetState")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int efpeKNfPzKiPkEQHAdUDGjiAQduX(int P_0, void* P_1);

	[DllImport("xinput1_3.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetState")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int zFDozSFqRRGusokraJwtTWnEuAg(int P_0, void* P_1);

	[DllImport("xinput1_4.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetState")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int KoyaAjZnoAegRiIRjDyYopaXcWkA(int P_0, void* P_1);

	public unsafe static int wLbnzAZySvkrnSCUXCDNwgcLpCf(int P_0, kPwuVFbDHHcxFAmkShCRzOChlEQ P_1, out LKFgASYGbtDLaslZsYWGfaIBzyU P_2)
	{
		P_2 = default(LKFgASYGbtDLaslZsYWGfaIBzyU);
		int result;
		fixed (IntPtr* ptr = &System.Runtime.CompilerServices.Unsafe.As<LKFgASYGbtDLaslZsYWGfaIBzyU, IntPtr>(ref P_2))
		{
			result = vPyhmySvGFKiXRvvBSSCHxMWcek(P_0, (int)P_1, ptr);
		}
		return result;
	}

	private unsafe static int vPyhmySvGFKiXRvvBSSCHxMWcek(int P_0, int P_1, void* P_2)
	{
		return TMbQezmaCdrQdaUPTidokyxxlgC.zIflZzLzCoeygkWXSUmehAtmeiX switch
		{
			FfhchLVRtXvbFSLPIuTTTAbQgdH.PtwheSqQzfIQEbQnCjFJHQuNduus => cejfZLmrXFoaFzdNXqmskXIIPLK(P_0, P_1, P_2), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.WiPetAAHSdpdxXhmYQajHMhVFrd => RIopMvUFmEdrVWhvxURcwQuVNWu(P_0, P_1, P_2), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.HgMBQPrarJURYOnszEwZkNAQeoz => njGATARNuExcnCkbYXYvWFYGsjk(P_0, P_1, P_2), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.ZDHeANZlTnXdSggQsOJZPfnkdst => RtOKQoFSECOQjWHTrYJVkedYkUv(P_0, P_1, P_2), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.kjLfBrqcAPuvxOtdpMHkyQDNprr => zxdsKytZUVLyaCYgjzAdaiaBCDu(P_0, P_1, P_2), 
			_ => 0, 
		};
	}

	[DllImport("xinput9_1_0.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetCapabilities")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int zxdsKytZUVLyaCYgjzAdaiaBCDu(int P_0, int P_1, void* P_2);

	[DllImport("xinput1_1.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetCapabilities")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int RtOKQoFSECOQjWHTrYJVkedYkUv(int P_0, int P_1, void* P_2);

	[DllImport("xinput1_2.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetCapabilities")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int njGATARNuExcnCkbYXYvWFYGsjk(int P_0, int P_1, void* P_2);

	[DllImport("xinput1_3.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetCapabilities")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int RIopMvUFmEdrVWhvxURcwQuVNWu(int P_0, int P_1, void* P_2);

	[DllImport("xinput1_4.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetCapabilities")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int cejfZLmrXFoaFzdNXqmskXIIPLK(int P_0, int P_1, void* P_2);

	public unsafe static int aonUGxQGXEpyAjfweZhKTJzwZEB(int P_0, XIknRXpqNpJpjomMjUKnahfnyvm P_1, out YGSGBfBYOPoMwfMLkEunqQKnEatd P_2)
	{
		P_2 = default(YGSGBfBYOPoMwfMLkEunqQKnEatd);
		int result;
		fixed (IntPtr* ptr = &System.Runtime.CompilerServices.Unsafe.As<YGSGBfBYOPoMwfMLkEunqQKnEatd, IntPtr>(ref P_2))
		{
			result = gaaLITnKAFrLllNhLtIaltkflCJ(P_0, (int)P_1, ptr);
		}
		return result;
	}

	private unsafe static int gaaLITnKAFrLllNhLtIaltkflCJ(int P_0, int P_1, void* P_2)
	{
		return TMbQezmaCdrQdaUPTidokyxxlgC.zIflZzLzCoeygkWXSUmehAtmeiX switch
		{
			FfhchLVRtXvbFSLPIuTTTAbQgdH.WiPetAAHSdpdxXhmYQajHMhVFrd => ZcBhRHGYBHqqJshjQPnRCvUDVLQ(P_0, P_1, P_2), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.HgMBQPrarJURYOnszEwZkNAQeoz => RGtcQGxLvCTsVhKmkUdmKRieEvQ(P_0, P_1, P_2), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.ZDHeANZlTnXdSggQsOJZPfnkdst => yjtybJEeTcprpKnEmcwgmPEVcsd(P_0, P_1, P_2), 
			FfhchLVRtXvbFSLPIuTTTAbQgdH.kjLfBrqcAPuvxOtdpMHkyQDNprr => noUPvyPBLfpIxsTOvRZUZCpabiF(P_0, P_1, P_2), 
			_ => 0, 
		};
	}

	[DllImport("xinput9_1_0.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetBatteryInformation")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int noUPvyPBLfpIxsTOvRZUZCpabiF(int P_0, int P_1, void* P_2);

	[DllImport("xinput1_1.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetBatteryInformation")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int yjtybJEeTcprpKnEmcwgmPEVcsd(int P_0, int P_1, void* P_2);

	[DllImport("xinput1_2.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetBatteryInformation")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int RGtcQGxLvCTsVhKmkUdmKRieEvQ(int P_0, int P_1, void* P_2);

	[DllImport("xinput1_3.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputGetBatteryInformation")]
	[SuppressUnmanagedCodeSecurity]
	private unsafe static extern int ZcBhRHGYBHqqJshjQPnRCvUDVLQ(int P_0, int P_1, void* P_2);

	public static void xCQcapgFZGqAveKsZJsjeEveZVHO(dPPahGKYiKvHsQXyXuviFuLVknZL P_0)
	{
		XTdqBwcIamEFwfkXVGqtSDzpaLxG(P_0);
	}

	private static void XTdqBwcIamEFwfkXVGqtSDzpaLxG(dPPahGKYiKvHsQXyXuviFuLVknZL P_0)
	{
		switch (TMbQezmaCdrQdaUPTidokyxxlgC.zIflZzLzCoeygkWXSUmehAtmeiX)
		{
		case FfhchLVRtXvbFSLPIuTTTAbQgdH.WiPetAAHSdpdxXhmYQajHMhVFrd:
			RaIOwyKtgOTjjCfYycPhSLRJBNI(P_0);
			break;
		case FfhchLVRtXvbFSLPIuTTTAbQgdH.HgMBQPrarJURYOnszEwZkNAQeoz:
			goDDqpaLyGotwlHCvtEfgkkTSUH(P_0);
			break;
		case FfhchLVRtXvbFSLPIuTTTAbQgdH.ZDHeANZlTnXdSggQsOJZPfnkdst:
			BzmcirfcsfeLmjVEecdAJLvaJXpO(P_0);
			break;
		case FfhchLVRtXvbFSLPIuTTTAbQgdH.kjLfBrqcAPuvxOtdpMHkyQDNprr:
			NTYmUNXbBtqhrQrUdBywYcICnGZ(P_0);
			break;
		}
	}

	[DllImport("xinput9_1_0.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputEnable")]
	[SuppressUnmanagedCodeSecurity]
	private static extern void NTYmUNXbBtqhrQrUdBywYcICnGZ(dPPahGKYiKvHsQXyXuviFuLVknZL P_0);

	[DllImport("xinput1_1.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputEnable")]
	[SuppressUnmanagedCodeSecurity]
	private static extern void BzmcirfcsfeLmjVEecdAJLvaJXpO(dPPahGKYiKvHsQXyXuviFuLVknZL P_0);

	[DllImport("xinput1_2.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputEnable")]
	[SuppressUnmanagedCodeSecurity]
	private static extern void goDDqpaLyGotwlHCvtEfgkkTSUH(dPPahGKYiKvHsQXyXuviFuLVknZL P_0);

	[DllImport("xinput1_3.dll", CallingConvention = CallingConvention.StdCall, EntryPoint = "XInputEnable")]
	[SuppressUnmanagedCodeSecurity]
	private static extern void RaIOwyKtgOTjjCfYycPhSLRJBNI(dPPahGKYiKvHsQXyXuviFuLVknZL P_0);
}
