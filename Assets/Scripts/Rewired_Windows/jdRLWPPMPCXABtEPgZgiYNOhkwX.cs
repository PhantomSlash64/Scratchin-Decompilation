using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired;
using Rewired.Config;
using Rewired.Data;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;

internal class jdRLWPPMPCXABtEPgZgiYNOhkwX : PlatformInputManager, INativePlatformHelper
{
	private class wKNhYaRKMsSmhxfXBiXuDTVomZv
	{
		private class txzHIYNelTTOejwPbcyohKODAnO
		{
			public int KGbDlEpidRgOHptdspOjOBLspxd;

			public int qkqfYZXJlOuMHmLFyEXJiqRPpfpq;

			public int rNkAdpgrNTIyhGDIJDbgIGIDsJfZ;

			public InputSource MunZepaFKdYsUldLUBVBfpSOkuHK;

			public txzHIYNelTTOejwPbcyohKODAnO(int mapperId, int managerId, int id, InputSource source)
			{
				KGbDlEpidRgOHptdspOjOBLspxd = mapperId;
				qkqfYZXJlOuMHmLFyEXJiqRPpfpq = managerId;
				rNkAdpgrNTIyhGDIJDbgIGIDsJfZ = id;
				MunZepaFKdYsUldLUBVBfpSOkuHK = source;
			}

			public void EBZMKoSknSfzkSfokUzktanzxJf(int P_0)
			{
				qkqfYZXJlOuMHmLFyEXJiqRPpfpq = P_0;
			}

			public xsgEcQKhZvWkrBuxwaSCbFLoShqb QeMkVDtSnrBaFcLrKDpVhfghRiN()
			{
				return new xsgEcQKhZvWkrBuxwaSCbFLoShqb(KGbDlEpidRgOHptdspOjOBLspxd, qkqfYZXJlOuMHmLFyEXJiqRPpfpq, MunZepaFKdYsUldLUBVBfpSOkuHK);
			}

			public static int sBtYRocyoHqMalpweneVAaqNfFa(txzHIYNelTTOejwPbcyohKODAnO P_0, txzHIYNelTTOejwPbcyohKODAnO P_1)
			{
				if (P_0.KGbDlEpidRgOHptdspOjOBLspxd < P_1.KGbDlEpidRgOHptdspOjOBLspxd)
				{
					return -1;
				}
				if (P_0.KGbDlEpidRgOHptdspOjOBLspxd > P_1.KGbDlEpidRgOHptdspOjOBLspxd)
				{
					return 1;
				}
				return 0;
			}
		}

		public struct xsgEcQKhZvWkrBuxwaSCbFLoShqb
		{
			public int KGbDlEpidRgOHptdspOjOBLspxd;

			public int qkqfYZXJlOuMHmLFyEXJiqRPpfpq;

			public InputSource MunZepaFKdYsUldLUBVBfpSOkuHK;

			public xsgEcQKhZvWkrBuxwaSCbFLoShqb(int mapperId, int managerId, InputSource source)
			{
				KGbDlEpidRgOHptdspOjOBLspxd = mapperId;
				qkqfYZXJlOuMHmLFyEXJiqRPpfpq = managerId;
				MunZepaFKdYsUldLUBVBfpSOkuHK = source;
			}
		}

		public enum pyDJgqIbDUFjgizuPoykGQSSLYx
		{
			QTjmhwTeuRVhauTKAbvNjtNMtgF = 0,
			nwwunQEtKXtRahhaVmgytaMELdz = 1
		}

		private List<txzHIYNelTTOejwPbcyohKODAnO> GKKvMqIeKcbgSUzSogjEEbHeIFZ;

		private List<txzHIYNelTTOejwPbcyohKODAnO> gocfcCWlntcYxeQfyGbxmcoXrFu;

		public int YiXOACpiATBJoRZEgmyqGXXGwrF => gocfcCWlntcYxeQfyGbxmcoXrFu.Count;

		public wKNhYaRKMsSmhxfXBiXuDTVomZv()
		{
			gocfcCWlntcYxeQfyGbxmcoXrFu = new List<txzHIYNelTTOejwPbcyohKODAnO>();
			GKKvMqIeKcbgSUzSogjEEbHeIFZ = new List<txzHIYNelTTOejwPbcyohKODAnO>();
		}

		public void NBhDoYHvqMyuDFwihqHtFflmaHzh(BridgedController P_0)
		{
			if (P_0 == null || P_0.sourceJoystick == null)
			{
				return;
			}
			IInputManagerJoystickPublic sourceJoystick = P_0.sourceJoystick;
			int num = UYvBQuGGMbqlNcbsGdYBZFCHCRB(sourceJoystick.rewiredId, pyDJgqIbDUFjgizuPoykGQSSLYx.QTjmhwTeuRVhauTKAbvNjtNMtgF);
			txzHIYNelTTOejwPbcyohKODAnO txzHIYNelTTOejwPbcyohKODAnO;
			if (num >= 0)
			{
				txzHIYNelTTOejwPbcyohKODAnO = gocfcCWlntcYxeQfyGbxmcoXrFu[num];
				txzHIYNelTTOejwPbcyohKODAnO.EBZMKoSknSfzkSfokUzktanzxJf(sourceJoystick.inputManagerId);
				P_0.sourceJoystick = new JaZHchaqIkiblDZMDuUldExAkTzG(sourceJoystick, txzHIYNelTTOejwPbcyohKODAnO.KGbDlEpidRgOHptdspOjOBLspxd);
				return;
			}
			num = UYvBQuGGMbqlNcbsGdYBZFCHCRB(sourceJoystick.rewiredId, pyDJgqIbDUFjgizuPoykGQSSLYx.nwwunQEtKXtRahhaVmgytaMELdz);
			if (num >= 0)
			{
				txzHIYNelTTOejwPbcyohKODAnO = GKKvMqIeKcbgSUzSogjEEbHeIFZ[num];
				GKKvMqIeKcbgSUzSogjEEbHeIFZ.RemoveAt(num);
				int kGbDlEpidRgOHptdspOjOBLspxd = TGofUIxVzjgxcvJdtLSpsJmTFuu(txzHIYNelTTOejwPbcyohKODAnO.KGbDlEpidRgOHptdspOjOBLspxd);
				txzHIYNelTTOejwPbcyohKODAnO.KGbDlEpidRgOHptdspOjOBLspxd = kGbDlEpidRgOHptdspOjOBLspxd;
			}
			else
			{
				txzHIYNelTTOejwPbcyohKODAnO = new txzHIYNelTTOejwPbcyohKODAnO(TGofUIxVzjgxcvJdtLSpsJmTFuu(), sourceJoystick.inputManagerId, sourceJoystick.rewiredId, P_0.inputManagerSource);
			}
			P_0.sourceJoystick = new JaZHchaqIkiblDZMDuUldExAkTzG(sourceJoystick, txzHIYNelTTOejwPbcyohKODAnO.KGbDlEpidRgOHptdspOjOBLspxd);
			gocfcCWlntcYxeQfyGbxmcoXrFu.Add(txzHIYNelTTOejwPbcyohKODAnO);
			gocfcCWlntcYxeQfyGbxmcoXrFu.Sort(txzHIYNelTTOejwPbcyohKODAnO.sBtYRocyoHqMalpweneVAaqNfFa);
		}

		public void kjqGVjHrCxLvQlXkpNFXdMmlwaeJ(ControllerDisconnectedEventArgs P_0)
		{
			if (P_0 != null)
			{
				int num = UYvBQuGGMbqlNcbsGdYBZFCHCRB(P_0.rewiredId, pyDJgqIbDUFjgizuPoykGQSSLYx.QTjmhwTeuRVhauTKAbvNjtNMtgF);
				if (num < 0)
				{
					Logger.LogError("Device was not in connected list! Cannot remove!");
					return;
				}
				txzHIYNelTTOejwPbcyohKODAnO item = gocfcCWlntcYxeQfyGbxmcoXrFu[num];
				gocfcCWlntcYxeQfyGbxmcoXrFu.RemoveAt(num);
				GKKvMqIeKcbgSUzSogjEEbHeIFZ.Add(item);
			}
		}

		public void YzHgkSGWyLWoxjmzzSRJEAwMyzrc(int P_0, int P_1)
		{
			int num = UYvBQuGGMbqlNcbsGdYBZFCHCRB(P_0, pyDJgqIbDUFjgizuPoykGQSSLYx.QTjmhwTeuRVhauTKAbvNjtNMtgF);
			if (num >= 0)
			{
				txzHIYNelTTOejwPbcyohKODAnO txzHIYNelTTOejwPbcyohKODAnO = gocfcCWlntcYxeQfyGbxmcoXrFu[num];
				txzHIYNelTTOejwPbcyohKODAnO.EBZMKoSknSfzkSfokUzktanzxJf(P_1);
				return;
			}
			num = UYvBQuGGMbqlNcbsGdYBZFCHCRB(P_0, pyDJgqIbDUFjgizuPoykGQSSLYx.nwwunQEtKXtRahhaVmgytaMELdz);
			if (num >= 0)
			{
				txzHIYNelTTOejwPbcyohKODAnO txzHIYNelTTOejwPbcyohKODAnO = GKKvMqIeKcbgSUzSogjEEbHeIFZ[num];
				txzHIYNelTTOejwPbcyohKODAnO.EBZMKoSknSfzkSfokUzktanzxJf(P_1);
			}
		}

		public bool GhknXgQlkVQpCeAlkfPWNFpELSm(int P_0, pyDJgqIbDUFjgizuPoykGQSSLYx P_1)
		{
			if (UYvBQuGGMbqlNcbsGdYBZFCHCRB(P_0, P_1) < 0)
			{
				return false;
			}
			return true;
		}

		public int UYvBQuGGMbqlNcbsGdYBZFCHCRB(int P_0, pyDJgqIbDUFjgizuPoykGQSSLYx P_1)
		{
			switch (P_1)
			{
			case pyDJgqIbDUFjgizuPoykGQSSLYx.QTjmhwTeuRVhauTKAbvNjtNMtgF:
			{
				int count2 = gocfcCWlntcYxeQfyGbxmcoXrFu.Count;
				for (int j = 0; j < count2; j++)
				{
					if (gocfcCWlntcYxeQfyGbxmcoXrFu[j].rNkAdpgrNTIyhGDIJDbgIGIDsJfZ == P_0)
					{
						return j;
					}
				}
				break;
			}
			case pyDJgqIbDUFjgizuPoykGQSSLYx.nwwunQEtKXtRahhaVmgytaMELdz:
			{
				int count = GKKvMqIeKcbgSUzSogjEEbHeIFZ.Count;
				for (int i = 0; i < count; i++)
				{
					if (GKKvMqIeKcbgSUzSogjEEbHeIFZ[i].rNkAdpgrNTIyhGDIJDbgIGIDsJfZ == P_0)
					{
						return i;
					}
				}
				break;
			}
			}
			return -1;
		}

		public int UYvBQuGGMbqlNcbsGdYBZFCHCRB(int P_0, InputSource P_1, pyDJgqIbDUFjgizuPoykGQSSLYx P_2)
		{
			switch (P_2)
			{
			case pyDJgqIbDUFjgizuPoykGQSSLYx.QTjmhwTeuRVhauTKAbvNjtNMtgF:
			{
				int count2 = gocfcCWlntcYxeQfyGbxmcoXrFu.Count;
				for (int j = 0; j < count2; j++)
				{
					if (gocfcCWlntcYxeQfyGbxmcoXrFu[j].KGbDlEpidRgOHptdspOjOBLspxd == P_0 && gocfcCWlntcYxeQfyGbxmcoXrFu[j].MunZepaFKdYsUldLUBVBfpSOkuHK == P_1)
					{
						return j;
					}
				}
				break;
			}
			case pyDJgqIbDUFjgizuPoykGQSSLYx.nwwunQEtKXtRahhaVmgytaMELdz:
			{
				int count = GKKvMqIeKcbgSUzSogjEEbHeIFZ.Count;
				for (int i = 0; i < count; i++)
				{
					if (GKKvMqIeKcbgSUzSogjEEbHeIFZ[i].KGbDlEpidRgOHptdspOjOBLspxd == P_0 && GKKvMqIeKcbgSUzSogjEEbHeIFZ[i].MunZepaFKdYsUldLUBVBfpSOkuHK == P_1)
					{
						return i;
					}
				}
				break;
			}
			}
			return -1;
		}

		public xsgEcQKhZvWkrBuxwaSCbFLoShqb QeMkVDtSnrBaFcLrKDpVhfghRiN(int P_0, pyDJgqIbDUFjgizuPoykGQSSLYx P_1)
		{
			if (P_1 == pyDJgqIbDUFjgizuPoykGQSSLYx.QTjmhwTeuRVhauTKAbvNjtNMtgF)
			{
				if (P_0 < 0 || P_0 >= gocfcCWlntcYxeQfyGbxmcoXrFu.Count)
				{
					throw new ArgumentOutOfRangeException();
				}
				return gocfcCWlntcYxeQfyGbxmcoXrFu[P_0].QeMkVDtSnrBaFcLrKDpVhfghRiN();
			}
			if (P_0 < 0 || P_0 >= GKKvMqIeKcbgSUzSogjEEbHeIFZ.Count)
			{
				throw new ArgumentOutOfRangeException();
			}
			return GKKvMqIeKcbgSUzSogjEEbHeIFZ[P_0].QeMkVDtSnrBaFcLrKDpVhfghRiN();
		}

		public int nHkhlOlyYzDcTdSjbgyKypVciRS(int P_0, InputSource P_1, pyDJgqIbDUFjgizuPoykGQSSLYx P_2)
		{
			int num = UYvBQuGGMbqlNcbsGdYBZFCHCRB(P_0, P_1, P_2);
			if (num < 0)
			{
				return -1;
			}
			return P_2 switch
			{
				pyDJgqIbDUFjgizuPoykGQSSLYx.QTjmhwTeuRVhauTKAbvNjtNMtgF => gocfcCWlntcYxeQfyGbxmcoXrFu[num].qkqfYZXJlOuMHmLFyEXJiqRPpfpq, 
				pyDJgqIbDUFjgizuPoykGQSSLYx.nwwunQEtKXtRahhaVmgytaMELdz => GKKvMqIeKcbgSUzSogjEEbHeIFZ[num].qkqfYZXJlOuMHmLFyEXJiqRPpfpq, 
				_ => -1, 
			};
		}

		private int TGofUIxVzjgxcvJdtLSpsJmTFuu(int P_0)
		{
			int count = gocfcCWlntcYxeQfyGbxmcoXrFu.Count;
			for (int i = 0; i < count; i++)
			{
				if (gocfcCWlntcYxeQfyGbxmcoXrFu[i].KGbDlEpidRgOHptdspOjOBLspxd == P_0)
				{
					return TGofUIxVzjgxcvJdtLSpsJmTFuu();
				}
			}
			return P_0;
		}

		private int TGofUIxVzjgxcvJdtLSpsJmTFuu()
		{
			int count = gocfcCWlntcYxeQfyGbxmcoXrFu.Count;
			int num = 0;
			while (true)
			{
				bool flag = false;
				for (int i = 0; i < count; i++)
				{
					if (gocfcCWlntcYxeQfyGbxmcoXrFu[i].KGbDlEpidRgOHptdspOjOBLspxd == num)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					break;
				}
				num++;
			}
			return num;
		}
	}

	private class JaZHchaqIkiblDZMDuUldExAkTzG : IInputManagerJoystickPublic
	{
		private IInputManagerJoystickPublic qFTTgjZPRmbnvqCBGdmEDbfSPiSE;

		private int aIFXzRstODekLIvFCFFXYjkrRZR;

		public int rewiredId => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.rewiredId;

		public int inputManagerId => aIFXzRstODekLIvFCFFXYjkrRZR;

		public string name => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.name;

		public long? systemId => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.systemId;

		public int unityId => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.unityId;

		public Guid instanceGuid => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.instanceGuid;

		public Guid persistentGuid => instanceGuid;

		public Controller.Extension extension => qFTTgjZPRmbnvqCBGdmEDbfSPiSE.extension;

		public JaZHchaqIkiblDZMDuUldExAkTzG(IInputManagerJoystickPublic sourceJoystick, int bridgeJoystickId)
		{
			qFTTgjZPRmbnvqCBGdmEDbfSPiSE = sourceJoystick;
			aIFXzRstODekLIvFCFFXYjkrRZR = bridgeJoystickId;
		}

		public void SetVibration(float amount, int motorIndex)
		{
			qFTTgjZPRmbnvqCBGdmEDbfSPiSE.SetVibration(amount, motorIndex);
		}

		public void StopVibration()
		{
			qFTTgjZPRmbnvqCBGdmEDbfSPiSE.StopVibration();
		}
	}

	[CompilerGenerated]
	private sealed class IIDxmAcdImROfKRKJNXglfZczPK
	{
		public int WDYLohLGyDgYypJPFSZYNlEBbEt;

		public int ltbfGycBAWJPyaEPKLEDSKPGdbXP()
		{
			return WDYLohLGyDgYypJPFSZYNlEBbEt++;
		}
	}

	private const bool vEJuAhnaHEaVuvHOWjuOgNmZYjX = false;

	private const bool nSzbQckAsApaWeZEHYkTRtJRAGcx = false;

	private const bool mtpdglgwLvkUyavoFsJOFVGFYwv = false;

	private const bool yJgZHyiiKPFPiacYTUiBeZAOlMi = false;

	private const bool gZahyhiVqrwmtLxYHkjxhmpwblYd = false;

	private bool MIcFDKFmbcoLIWvmEwicNqnQGGHh;

	private object YimAJZbAKPgDBIxhMSdYagbkecBU;

	private IndexedDictionary<int, PlatformInputManager> cuMzhpMascWuibmdvSSTxnyhyuG;

	private wKNhYaRKMsSmhxfXBiXuDTVomZv UUreqRBJjknbGibdiBcXmBhlpLc;

	private Action<int, ControllerDataUpdater> UnhEVuhJFUEnfAsRXUSCacwcngnY;

	private WindowsStandalonePrimaryInputSource XOhkAEDtdAddjhLKsseHipAvvUk;

	private bool fusuChFAnsQfBhWSvPtKWcjxdPNa;

	private PlatformInputManager GRPphNqBvejBLpdEjHfuUeLKHeo;

	private bool WoBhHYsAzmQjHvzuCDoxoJkWbYs;

	private Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> rpvCjQaePXpGswKHxhwfamxRDIu;

	private Func<int> ilAOFbKaMpyqndLrycyBBEQAMvEC;

	[CustomObfuscation(rename = false)]
	private int counter;

	bool INativePlatformHelper.fprhkcmJWMFkJdxuibIvTVYKPAQ
	{
		get
		{
			IntPtr intPtr = FzngAIhKGFOAkXUDRNTZlbDTVEc.WTNNozXbCzvAANAuXXjpSeDaTAD();
			IntPtr intPtr2 = FzngAIhKGFOAkXUDRNTZlbDTVEc.NPKxqbrJOXBOjYozsbheDTjQCapS();
			return intPtr2 != IntPtr.Zero && intPtr == intPtr2;
		}
	}

	[CustomObfuscation(rename = false)]
	public override int deviceCount => UUreqRBJjknbGibdiBcXmBhlpLc.YiXOACpiATBJoRZEgmyqGXXGwrF;

	[CustomObfuscation(rename = false)]
	public override PlatformInputManager primaryInputManager => GRPphNqBvejBLpdEjHfuUeLKHeo;

	[CustomObfuscation(rename = false)]
	public override IInputSource inputSource => GRPphNqBvejBLpdEjHfuUeLKHeo.inputSource;

	[CustomObfuscation(rename = false)]
	public override InputSource inputSourceType
	{
		get
		{
			if (GRPphNqBvejBLpdEjHfuUeLKHeo == null)
			{
				return InputSource.None;
			}
			return GRPphNqBvejBLpdEjHfuUeLKHeo.inputSourceType;
		}
	}

	public jdRLWPPMPCXABtEPgZgiYNOhkwX(ConfigVars configVars, Func<BridgedControllerHWInfo, HardwareJoystickMap_InputManager> getHardwareJoystickMap_InputManager, Func<int> getNewJoystickId)
	{
		XOhkAEDtdAddjhLKsseHipAvvUk = configVars.windowsStandalonePrimaryInputSource;
		fusuChFAnsQfBhWSvPtKWcjxdPNa = configVars.useXInput;
		rpvCjQaePXpGswKHxhwfamxRDIu = getHardwareJoystickMap_InputManager;
		ilAOFbKaMpyqndLrycyBBEQAMvEC = getNewJoystickId;
		bool flag = false;
		cuMzhpMascWuibmdvSSTxnyhyuG = new IndexedDictionary<int, PlatformInputManager>();
		if (UnityTools.platform != Platform.WindowsAppStore)
		{
			try
			{
				lnoFVvbmWwakViCuJntBYhJMonm.MGdUCgKavLcKdZVSFfqcdWqSuzTp();
				eHhFvRASFyFXeJYsXFOQiqQetFL eHhFvRASFyFXeJYsXFOQiqQetFL2 = (eHhFvRASFyFXeJYsXFOQiqQetFL)(YimAJZbAKPgDBIxhMSdYagbkecBU = new eHhFvRASFyFXeJYsXFOQiqQetFL());
				bool flag2 = false;
				if (XOhkAEDtdAddjhLKsseHipAvvUk == WindowsStandalonePrimaryInputSource.DirectInput)
				{
					flag2 = fjXZVEsNwGcoLYKUjiONAIhiiIma(configVars, eHhFvRASFyFXeJYsXFOQiqQetFL2);
					if (!flag2)
					{
						Logger.Log("Attempting to fallback to Raw Input...");
						flag2 = XfmCeAxFCDVNCTPRbqrDiTOEIWO(configVars, eHhFvRASFyFXeJYsXFOQiqQetFL2);
						if (flag2)
						{
							configVars.windowsStandalonePrimaryInputSource = WindowsStandalonePrimaryInputSource.RawInput;
							XOhkAEDtdAddjhLKsseHipAvvUk = configVars.windowsStandalonePrimaryInputSource;
							Logger.Log("Raw Input initialized!");
						}
					}
				}
				else if (XOhkAEDtdAddjhLKsseHipAvvUk == WindowsStandalonePrimaryInputSource.RawInput)
				{
					flag2 = XfmCeAxFCDVNCTPRbqrDiTOEIWO(configVars, eHhFvRASFyFXeJYsXFOQiqQetFL2);
					if (!flag2)
					{
						Logger.Log("Attempting to fallback to Direct Input...");
						flag2 = fjXZVEsNwGcoLYKUjiONAIhiiIma(configVars, eHhFvRASFyFXeJYsXFOQiqQetFL2);
						if (flag2)
						{
							configVars.windowsStandalonePrimaryInputSource = WindowsStandalonePrimaryInputSource.DirectInput;
							XOhkAEDtdAddjhLKsseHipAvvUk = configVars.windowsStandalonePrimaryInputSource;
							Logger.Log("Direct Input initialized!");
						}
					}
				}
				else if (XOhkAEDtdAddjhLKsseHipAvvUk == WindowsStandalonePrimaryInputSource.XInput)
				{
					flag2 = TIhQqwGRdUWOTtzwYKUfCxWhuqt(configVars, false);
					if (flag2)
					{
						OFddfwdQoeXvBGwqtejSKjLtoqAI(configVars, eHhFvRASFyFXeJYsXFOQiqQetFL2);
					}
					flag = flag2;
				}
				if (!flag2)
				{
					throw new Exception();
				}
				eHhFvRASFyFXeJYsXFOQiqQetFL2.cnPtxUsrfEsgVOLONDxTccaVcpp += RBKmFiLfLNfzkgZjIEnUEIPSWTvE;
				eHhFvRASFyFXeJYsXFOQiqQetFL2.znXDINUcaSpSLBQsoaQnnXtWxYE += JarXOCRCXOaaWdfFanwgfLeFoQoM;
				for (int i = 0; i < cuMzhpMascWuibmdvSSTxnyhyuG.Count; i++)
				{
					PlatformInputManager platformInputManager = cuMzhpMascWuibmdvSSTxnyhyuG[i];
					platformInputManager.DeviceConnectedEvent += FIXbkLwrlpwCgctSuqQqbKwgZNV;
					platformInputManager.DeviceDisconnectedEvent += uOAxxglfCpdkIEIHwAQpDPXXmvUl;
					platformInputManager.UpdateControllerInfoEvent += sDLPmSteNwkvrOWZXHqHmNUieenJ;
				}
			}
			catch (Exception ex)
			{
				OnDestroy();
				Logger.LogWarning("Unable to initialize input source!\n" + ex.Message);
				throw;
			}
		}
		if (!flag)
		{
			TIhQqwGRdUWOTtzwYKUfCxWhuqt(configVars, true);
		}
		UnhEVuhJFUEnfAsRXUSCacwcngnY = UpdateControllerData;
	}

	private bool fjXZVEsNwGcoLYKUjiONAIhiiIma(ConfigVars P_0, eHhFvRASFyFXeJYsXFOQiqQetFL P_1)
	{
		PVHplNLarjGPjadzMDzXAgLHfzpK pVHplNLarjGPjadzMDzXAgLHfzpK = null;
		lRfdZjIakBhyrwaGkefekSyEiXO lRfdZjIakBhyrwaGkefekSyEiXO2 = null;
		try
		{
			pVHplNLarjGPjadzMDzXAgLHfzpK = new PVHplNLarjGPjadzMDzXAgLHfzpK(P_0, useXInput: false, null, null, handleJoysticks: false, P_0.GetPlatformVar_useNativeMouse(), P_0.GetPlatformVar_useNativeKeyboard(), P_0.GetPlatformVar_useEnhancedDeviceSupport());
			lRfdZjIakBhyrwaGkefekSyEiXO2 = (lRfdZjIakBhyrwaGkefekSyEiXO)(GRPphNqBvejBLpdEjHfuUeLKHeo = new lRfdZjIakBhyrwaGkefekSyEiXO(P_0.updateLoop, fusuChFAnsQfBhWSvPtKWcjxdPNa, ((eHhFvRASFyFXeJYsXFOQiqQetFL)YimAJZbAKPgDBIxhMSdYagbkecBU).cydNPfNgnIKkNtZVdrByOJGWCUKA, rpvCjQaePXpGswKHxhwfamxRDIu, ilAOFbKaMpyqndLrycyBBEQAMvEC));
			cuMzhpMascWuibmdvSSTxnyhyuG.Add(5, pVHplNLarjGPjadzMDzXAgLHfzpK);
			cuMzhpMascWuibmdvSSTxnyhyuG.Add(1, GRPphNqBvejBLpdEjHfuUeLKHeo);
			P_1.IyvwYukxIQplJvCAncFEhcNJUDlU += pVHplNLarjGPjadzMDzXAgLHfzpK.BcqkVlPOBxPuJKSJNPWkUqCoTvT;
			return true;
		}
		catch (Exception)
		{
			lRfdZjIakBhyrwaGkefekSyEiXO2?.OnDestroy();
			pVHplNLarjGPjadzMDzXAgLHfzpK?.OnDestroy();
			Logger.LogWarning("Unable to initialize Direct Input! Please see the Installation section of the documentation for information on required libraries. Documentation can be found in the menu: Window -> Rewired -> Help -> Documentation.");
		}
		return false;
	}

	private bool XfmCeAxFCDVNCTPRbqrDiTOEIWO(ConfigVars P_0, eHhFvRASFyFXeJYsXFOQiqQetFL P_1)
	{
		PVHplNLarjGPjadzMDzXAgLHfzpK pVHplNLarjGPjadzMDzXAgLHfzpK = null;
		try
		{
			pVHplNLarjGPjadzMDzXAgLHfzpK = new PVHplNLarjGPjadzMDzXAgLHfzpK(P_0, P_0.useXInput, rpvCjQaePXpGswKHxhwfamxRDIu, ilAOFbKaMpyqndLrycyBBEQAMvEC, handleJoysticks: true, P_0.GetPlatformVar_useNativeMouse(), P_0.GetPlatformVar_useNativeKeyboard(), P_0.GetPlatformVar_useEnhancedDeviceSupport());
			cuMzhpMascWuibmdvSSTxnyhyuG.Add(5, pVHplNLarjGPjadzMDzXAgLHfzpK);
			P_1.IyvwYukxIQplJvCAncFEhcNJUDlU += pVHplNLarjGPjadzMDzXAgLHfzpK.BcqkVlPOBxPuJKSJNPWkUqCoTvT;
			GRPphNqBvejBLpdEjHfuUeLKHeo = pVHplNLarjGPjadzMDzXAgLHfzpK;
			return true;
		}
		catch (Exception)
		{
			Logger.LogWarning("Unable to initialize Raw Input! This error can be caused by running Unity sandboxed.");
			pVHplNLarjGPjadzMDzXAgLHfzpK?.OnDestroy();
		}
		return false;
	}

	private bool OFddfwdQoeXvBGwqtejSKjLtoqAI(ConfigVars P_0, eHhFvRASFyFXeJYsXFOQiqQetFL P_1)
	{
		bool platformVar_useNativeMouse = P_0.GetPlatformVar_useNativeMouse();
		bool platformVar_useNativeKeyboard = P_0.GetPlatformVar_useNativeKeyboard();
		if (!platformVar_useNativeMouse && !platformVar_useNativeKeyboard)
		{
			return false;
		}
		PVHplNLarjGPjadzMDzXAgLHfzpK pVHplNLarjGPjadzMDzXAgLHfzpK = null;
		try
		{
			pVHplNLarjGPjadzMDzXAgLHfzpK = new PVHplNLarjGPjadzMDzXAgLHfzpK(P_0, useXInput: false, null, null, handleJoysticks: false, platformVar_useNativeMouse, platformVar_useNativeKeyboard, P_0.GetPlatformVar_useEnhancedDeviceSupport());
			P_1.IyvwYukxIQplJvCAncFEhcNJUDlU += pVHplNLarjGPjadzMDzXAgLHfzpK.BcqkVlPOBxPuJKSJNPWkUqCoTvT;
			cuMzhpMascWuibmdvSSTxnyhyuG.Add(5, pVHplNLarjGPjadzMDzXAgLHfzpK);
			return true;
		}
		catch
		{
			Logger.LogWarning("Unable to initialize Raw Input for native mouse handling! Unity mouse input will be used instead.");
			pVHplNLarjGPjadzMDzXAgLHfzpK?.OnDestroy();
			pVHplNLarjGPjadzMDzXAgLHfzpK = null;
			return false;
		}
	}

	private bool TIhQqwGRdUWOTtzwYKUfCxWhuqt(ConfigVars P_0, bool P_1)
	{
		UpdateLoopSetting updateLoop = P_0.updateLoop;
		bool useXInput = P_0.useXInput;
		bool flag = GRPphNqBvejBLpdEjHfuUeLKHeo == null;
		bool flag2 = useXInput || flag || ReInput.currentPlatform == Platform.WindowsAppStore;
		bool flag3 = false;
		if (!flag2)
		{
			return false;
		}
		try
		{
			if (flag3)
			{
				int WDYLohLGyDgYypJPFSZYNlEBbEt = 0;
				gNZLZmnOEqwqMNKfeNUJNfMypUC value = new gNZLZmnOEqwqMNKfeNUJNfMypUC(flag3, updateLoop, rpvCjQaePXpGswKHxhwfamxRDIu, () => WDYLohLGyDgYypJPFSZYNlEBbEt++);
				cuMzhpMascWuibmdvSSTxnyhyuG.Add(2, value);
			}
			else
			{
				gNZLZmnOEqwqMNKfeNUJNfMypUC gNZLZmnOEqwqMNKfeNUJNfMypUC2 = new gNZLZmnOEqwqMNKfeNUJNfMypUC(flag3, updateLoop, rpvCjQaePXpGswKHxhwfamxRDIu, ilAOFbKaMpyqndLrycyBBEQAMvEC);
				if (flag)
				{
					GRPphNqBvejBLpdEjHfuUeLKHeo = gNZLZmnOEqwqMNKfeNUJNfMypUC2;
				}
				cuMzhpMascWuibmdvSSTxnyhyuG.Add(2, gNZLZmnOEqwqMNKfeNUJNfMypUC2);
				if (P_1)
				{
					gNZLZmnOEqwqMNKfeNUJNfMypUC2.DeviceConnectedEvent += FIXbkLwrlpwCgctSuqQqbKwgZNV;
					gNZLZmnOEqwqMNKfeNUJNfMypUC2.DeviceDisconnectedEvent += uOAxxglfCpdkIEIHwAQpDPXXmvUl;
					gNZLZmnOEqwqMNKfeNUJNfMypUC2.UpdateControllerInfoEvent += sDLPmSteNwkvrOWZXHqHmNUieenJ;
				}
			}
			return true;
		}
		catch (Exception)
		{
			if (flag)
			{
				OnDestroy();
				Logger.LogWarning("Unable to initialize XInput!");
				throw;
			}
			if (!flag3)
			{
				Logger.LogWarning("Unable to initialize XInput! XInput controllers will be handled by " + XOhkAEDtdAddjhLKsseHipAvvUk.ToString() + " instead. The L/R triggers are treated as a single axis and input cannot be detected when both are pressed simultaneously. Please see the Installation section of the documentation for information on required libraries. Documentation can be found in the menu: Window -> Rewired -> Help -> Documentation.");
				P_0.useXInput = false;
				for (int i = 0; i < cuMzhpMascWuibmdvSSTxnyhyuG.Count; i++)
				{
					if (cuMzhpMascWuibmdvSSTxnyhyuG[i] != null && cuMzhpMascWuibmdvSSTxnyhyuG[i] is cAvjFIuogOpSRXxMsntCvEcAHqvj cAvjFIuogOpSRXxMsntCvEcAHqvj2)
					{
						cAvjFIuogOpSRXxMsntCvEcAHqvj2.fusuChFAnsQfBhWSvPtKWcjxdPNa = false;
					}
				}
				Logger.LogWarning("Unable to initialize XInput! Please see the Installation section of the documentation for information on required libraries. Documentation can be found in the menu: Window -> Rewired -> Help -> Documentation.");
			}
			return false;
		}
	}

	[CustomObfuscation(rename = false)]
	public override void Initialize()
	{
		MIcFDKFmbcoLIWvmEwicNqnQGGHh = true;
		UUreqRBJjknbGibdiBcXmBhlpLc = new wKNhYaRKMsSmhxfXBiXuDTVomZv();
		for (int i = 0; i < cuMzhpMascWuibmdvSSTxnyhyuG.Count; i++)
		{
			cuMzhpMascWuibmdvSSTxnyhyuG[i].Initialize();
		}
	}

	public override void Update(UpdateLoopType currentUpdateLoop)
	{
		for (int i = 0; i < cuMzhpMascWuibmdvSSTxnyhyuG.Count; i++)
		{
			cuMzhpMascWuibmdvSSTxnyhyuG[i].Update(currentUpdateLoop);
		}
	}

	[CustomObfuscation(rename = false)]
	public override void OnDestroy()
	{
		for (int num = cuMzhpMascWuibmdvSSTxnyhyuG.Count - 1; num >= 0; num--)
		{
			cuMzhpMascWuibmdvSSTxnyhyuG[num].OnDestroy();
		}
		if (YimAJZbAKPgDBIxhMSdYagbkecBU != null)
		{
			((eHhFvRASFyFXeJYsXFOQiqQetFL)YimAJZbAKPgDBIxhMSdYagbkecBU).gQzGUxGfahvQPeTsdbAWUxXpdVCF();
			YimAJZbAKPgDBIxhMSdYagbkecBU = null;
		}
		lnoFVvbmWwakViCuJntBYhJMonm.PMzamCeIIFqnzgwGlxEbIeTHBFUL();
	}

	[CustomObfuscation(rename = false)]
	public override Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate()
	{
		return UnhEVuhJFUEnfAsRXUSCacwcngnY;
	}

	[CustomObfuscation(rename = false)]
	public override void UpdateControllerData(int controllerId, ControllerDataUpdater data)
	{
		cuMzhpMascWuibmdvSSTxnyhyuG.GetValue((int)data.source).UpdateControllerData(UUreqRBJjknbGibdiBcXmBhlpLc.nHkhlOlyYzDcTdSjbgyKypVciRS(controllerId, data.source, wKNhYaRKMsSmhxfXBiXuDTVomZv.pyDJgqIbDUFjgizuPoykGQSSLYx.QTjmhwTeuRVhauTKAbvNjtNMtgF), data);
	}

	[CustomObfuscation(rename = false)]
	public override void SystemDeviceConnected()
	{
	}

	[CustomObfuscation(rename = false)]
	public override void SystemDeviceDisconnected()
	{
	}

	[CustomObfuscation(rename = false)]
	public override void SetUnityJoystickId(int joystickId, int unityJoystickId)
	{
	}

	[CustomObfuscation(rename = false)]
	public override IUnifiedMouseSource GetUnifiedMouseSource()
	{
		for (int i = 0; i < cuMzhpMascWuibmdvSSTxnyhyuG.Count; i++)
		{
			IUnifiedMouseSource unifiedMouseSource = cuMzhpMascWuibmdvSSTxnyhyuG[i].GetUnifiedMouseSource();
			if (unifiedMouseSource != null)
			{
				return unifiedMouseSource;
			}
		}
		return null;
	}

	[CustomObfuscation(rename = false)]
	public override IUnifiedKeyboardSource GetUnifiedKeyboardSource()
	{
		for (int i = 0; i < cuMzhpMascWuibmdvSSTxnyhyuG.Count; i++)
		{
			IUnifiedKeyboardSource unifiedKeyboardSource = cuMzhpMascWuibmdvSSTxnyhyuG[i].GetUnifiedKeyboardSource();
			if (unifiedKeyboardSource != null)
			{
				return unifiedKeyboardSource;
			}
		}
		return null;
	}

	private void FIXbkLwrlpwCgctSuqQqbKwgZNV(BridgedController P_0)
	{
		if (P_0 != null)
		{
			UUreqRBJjknbGibdiBcXmBhlpLc.NBhDoYHvqMyuDFwihqHtFflmaHzh(P_0);
			if (_DeviceConnectedEvent != null)
			{
				_DeviceConnectedEvent(P_0);
			}
		}
	}

	private void uOAxxglfCpdkIEIHwAQpDPXXmvUl(ControllerDisconnectedEventArgs P_0)
	{
		if (P_0 != null)
		{
			UUreqRBJjknbGibdiBcXmBhlpLc.kjqGVjHrCxLvQlXkpNFXdMmlwaeJ(P_0);
			if (_DeviceDisconnectedEvent != null)
			{
				_DeviceDisconnectedEvent(P_0);
			}
		}
	}

	private void RBKmFiLfLNfzkgZjIEnUEIPSWTvE(EventArgs P_0)
	{
		if (MIcFDKFmbcoLIWvmEwicNqnQGGHh)
		{
			for (int i = 0; i < cuMzhpMascWuibmdvSSTxnyhyuG.Count; i++)
			{
				cuMzhpMascWuibmdvSSTxnyhyuG[i].SystemDeviceConnected();
			}
		}
	}

	private void JarXOCRCXOaaWdfFanwgfLeFoQoM(EventArgs P_0)
	{
		if (MIcFDKFmbcoLIWvmEwicNqnQGGHh)
		{
			for (int i = 0; i < cuMzhpMascWuibmdvSSTxnyhyuG.Count; i++)
			{
				cuMzhpMascWuibmdvSSTxnyhyuG[i].SystemDeviceDisconnected();
			}
		}
	}

	private void sDLPmSteNwkvrOWZXHqHmNUieenJ(UpdateControllerInfoEventArgs P_0)
	{
		if (P_0 == null || P_0.sourceJoystick == null)
		{
			return;
		}
		UUreqRBJjknbGibdiBcXmBhlpLc.YzHgkSGWyLWoxjmzzSRJEAwMyzrc(P_0.sourceJoystick.rewiredId, P_0.sourceJoystick.inputManagerId);
		wKNhYaRKMsSmhxfXBiXuDTVomZv.pyDJgqIbDUFjgizuPoykGQSSLYx pyDJgqIbDUFjgizuPoykGQSSLYx = wKNhYaRKMsSmhxfXBiXuDTVomZv.pyDJgqIbDUFjgizuPoykGQSSLYx.QTjmhwTeuRVhauTKAbvNjtNMtgF;
		int num = UUreqRBJjknbGibdiBcXmBhlpLc.UYvBQuGGMbqlNcbsGdYBZFCHCRB(P_0.sourceJoystick.rewiredId, pyDJgqIbDUFjgizuPoykGQSSLYx);
		if (num < 0)
		{
			pyDJgqIbDUFjgizuPoykGQSSLYx = wKNhYaRKMsSmhxfXBiXuDTVomZv.pyDJgqIbDUFjgizuPoykGQSSLYx.nwwunQEtKXtRahhaVmgytaMELdz;
			num = UUreqRBJjknbGibdiBcXmBhlpLc.UYvBQuGGMbqlNcbsGdYBZFCHCRB(P_0.sourceJoystick.rewiredId, pyDJgqIbDUFjgizuPoykGQSSLYx);
		}
		if (num >= 0)
		{
			wKNhYaRKMsSmhxfXBiXuDTVomZv.xsgEcQKhZvWkrBuxwaSCbFLoShqb xsgEcQKhZvWkrBuxwaSCbFLoShqb = UUreqRBJjknbGibdiBcXmBhlpLc.QeMkVDtSnrBaFcLrKDpVhfghRiN(num, pyDJgqIbDUFjgizuPoykGQSSLYx);
			if (_UpdateControllerInfoEvent != null)
			{
				_UpdateControllerInfoEvent(new UpdateControllerInfoEventArgs(new JaZHchaqIkiblDZMDuUldExAkTzG(P_0.sourceJoystick, xsgEcQKhZvWkrBuxwaSCbFLoShqb.KGbDlEpidRgOHptdspOjOBLspxd)));
			}
		}
	}
}
