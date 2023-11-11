using System;
using System.Collections.Generic;
using Rewired.Config;
using Rewired.Utils;

namespace Rewired.HID
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal abstract class HIDControllerElementWithDataSet : HIDControllerElement
	{
		internal abstract class rYwbSHvKTiZqJfpYSdFFgfYJtSH
		{
			private int qPfvFrkwURVHXDFWfbMPknHWwMC;

			private int[] HVcadcjmFPZQDshVQEWqNcNuPjrx;

			protected JtaFFVKvFThjEsKLpRpTnNuAmnZ[] EWoddpLmOVAVehNObYQCwzxxzbG;

			public JtaFFVKvFThjEsKLpRpTnNuAmnZ HBFpvdVSEToPvyDvjayPiQyuurNQ;

			private int dNOdUInaodFiUtCCqNVAVCVTTGl;

			private int pGdFhtIDBujVREblgTVumQrDDssM = -1;

			private bool sQTBWTNxxjaWNFsekFBPFIwaffDK;

			protected int yiagAdjmjzavWfNAtzbnrNRjzWw => qPfvFrkwURVHXDFWfbMPknHWwMC;

			protected int[] aGIULMrkHyzNxxickXxtMZbJIyW => HVcadcjmFPZQDshVQEWqNcNuPjrx;

			public UpdateLoopType EtMuBRTmVzCBLcuxYRMlwUqRdAzD
			{
				set
				{
					if (pGdFhtIDBujVREblgTVumQrDDssM != (int)value)
					{
						pGdFhtIDBujVREblgTVumQrDDssM = (int)value;
						dNOdUInaodFiUtCCqNVAVCVTTGl = HVcadcjmFPZQDshVQEWqNcNuPjrx[(int)value];
						HBFpvdVSEToPvyDvjayPiQyuurNQ = EWoddpLmOVAVehNObYQCwzxxzbG[dNOdUInaodFiUtCCqNVAVCVTTGl];
					}
				}
			}

			public rYwbSHvKTiZqJfpYSdFFgfYJtSH()
			{
			}

			public void iBHEWVKAPFltFrKKCqTzvxwUOOQ(UpdateLoopSetting P_0, Func<UpdateLoopType, JtaFFVKvFThjEsKLpRpTnNuAmnZ> P_1)
			{
				if (sQTBWTNxxjaWNFsekFBPFIwaffDK)
				{
					Logger.LogError("Already initialized!");
					return;
				}
				HVcadcjmFPZQDshVQEWqNcNuPjrx = new int[3];
				qPfvFrkwURVHXDFWfbMPknHWwMC = 0;
				List<JtaFFVKvFThjEsKLpRpTnNuAmnZ> list = new List<JtaFFVKvFThjEsKLpRpTnNuAmnZ>();
				using (TempListPool.TList<UpdateLoopType> tList = TempListPool.GetTList<UpdateLoopType>(3))
				{
					List<UpdateLoopType> list2 = tList.list;
					EnumConverter.ToUpdateLoopTypes(P_0, list2);
					for (int i = 0; i < list2.Count; i++)
					{
						HVcadcjmFPZQDshVQEWqNcNuPjrx[(int)list2[i]] = qPfvFrkwURVHXDFWfbMPknHWwMC;
						qPfvFrkwURVHXDFWfbMPknHWwMC++;
						list.Add(P_1(list2[i]));
					}
				}
				EWoddpLmOVAVehNObYQCwzxxzbG = list.ToArray();
				sQTBWTNxxjaWNFsekFBPFIwaffDK = true;
			}

			private void DLdFgaYsaooCiQUHoDXVKAFlwuU(UpdateLoopType P_0, JtaFFVKvFThjEsKLpRpTnNuAmnZ P_1)
			{
				EWoddpLmOVAVehNObYQCwzxxzbG[HVcadcjmFPZQDshVQEWqNcNuPjrx[(int)P_0]] = P_1;
			}

			public virtual void mtiNfGzpXHszOwiOIAVYQuMZclV(UpdateLoopType P_0)
			{
				if (pGdFhtIDBujVREblgTVumQrDDssM != (int)P_0)
				{
					EtMuBRTmVzCBLcuxYRMlwUqRdAzD = P_0;
				}
			}

			public void skeOSBSqSPGPnIZySfEhxuCHbTXM()
			{
				for (int i = 0; i < qPfvFrkwURVHXDFWfbMPknHWwMC; i++)
				{
					EWoddpLmOVAVehNObYQCwzxxzbG[i].skeOSBSqSPGPnIZySfEhxuCHbTXM();
				}
			}
		}

		internal abstract class JtaFFVKvFThjEsKLpRpTnNuAmnZ
		{
			public readonly UpdateLoopType EtMuBRTmVzCBLcuxYRMlwUqRdAzD;

			public JtaFFVKvFThjEsKLpRpTnNuAmnZ(UpdateLoopType updateLoop)
			{
				EtMuBRTmVzCBLcuxYRMlwUqRdAzD = updateLoop;
			}

			public abstract void skeOSBSqSPGPnIZySfEhxuCHbTXM();
		}

		internal rYwbSHvKTiZqJfpYSdFFgfYJtSH dataSet;

		public HIDControllerElementWithDataSet(rYwbSHvKTiZqJfpYSdFFgfYJtSH dataSet, byte reportId, HIDInfo hidInfo)
			: base(reportId, hidInfo)
		{
			this.dataSet = dataSet;
		}

		public virtual void Update(UpdateLoopType updateLoop)
		{
			if (dataSet != null)
			{
				dataSet.mtiNfGzpXHszOwiOIAVYQuMZclV(updateLoop);
			}
		}
	}
}
