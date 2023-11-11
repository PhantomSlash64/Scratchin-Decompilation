using System;
using Rewired.Config;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired.HID
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class HIDGyroscope : HIDControllerElementWithDataSet
	{
		internal class RBuzuNFbOSamEghQRbFWPmoFDarj : rYwbSHvKTiZqJfpYSdFFgfYJtSH
		{
			private int ILZtTDdeOMGdAHVlKVbzUgncZPR;

			private int QzunehbcKXnkNttewGIcKdbIFAW;

			public float[] QRDpwPykAQowLDZXAdYlFwGxNGI => (HBFpvdVSEToPvyDvjayPiQyuurNQ as aiBHDFfiMeVOFLOFgClDirwEsmx).QRDpwPykAQowLDZXAdYlFwGxNGI;

			public ExpandableArray_DataContainer<ePopPcSKOyxPfeOuQZJrekpiocw> mDLiSWYwiVbkMETzjeOTcgDRppd => (HBFpvdVSEToPvyDvjayPiQyuurNQ as aiBHDFfiMeVOFLOFgClDirwEsmx).mDLiSWYwiVbkMETzjeOTcgDRppd;

			public RBuzuNFbOSamEghQRbFWPmoFDarj(UpdateLoopSetting updateLoopSetting, int valueLength, int eventCapacity)
			{
				ILZtTDdeOMGdAHVlKVbzUgncZPR = valueLength;
				QzunehbcKXnkNttewGIcKdbIFAW = eventCapacity;
				iBHEWVKAPFltFrKKCqTzvxwUOOQ(updateLoopSetting, RqLRmFfgpwZLqMDStaMayZkElNj);
			}

			public override void mtiNfGzpXHszOwiOIAVYQuMZclV(UpdateLoopType P_0)
			{
				base.mtiNfGzpXHszOwiOIAVYQuMZclV(P_0);
				(HBFpvdVSEToPvyDvjayPiQyuurNQ as aiBHDFfiMeVOFLOFgClDirwEsmx).mtiNfGzpXHszOwiOIAVYQuMZclV();
			}

			public void wuJiFxIHpunygwghobkYAvoBUnFB(float[] P_0, float P_1)
			{
				for (int i = 0; i < EWoddpLmOVAVehNObYQCwzxxzbG.Length; i++)
				{
					(EWoddpLmOVAVehNObYQCwzxxzbG[i] as aiBHDFfiMeVOFLOFgClDirwEsmx).nFvNUxLxWzqiTEuLEjLMGfabcdc(P_0, P_1);
				}
			}

			private JtaFFVKvFThjEsKLpRpTnNuAmnZ RqLRmFfgpwZLqMDStaMayZkElNj(UpdateLoopType P_0)
			{
				return new aiBHDFfiMeVOFLOFgClDirwEsmx(P_0, ILZtTDdeOMGdAHVlKVbzUgncZPR, QzunehbcKXnkNttewGIcKdbIFAW);
			}
		}

		internal class aiBHDFfiMeVOFLOFgClDirwEsmx : JtaFFVKvFThjEsKLpRpTnNuAmnZ
		{
			private float[] nzzKRmsoqtksxwmTvPUwSOXITMg;

			public float[] QRDpwPykAQowLDZXAdYlFwGxNGI;

			public ExpandableArray_DataContainer<ePopPcSKOyxPfeOuQZJrekpiocw> mDLiSWYwiVbkMETzjeOTcgDRppd;

			private ExpandableArray_DataContainer<ePopPcSKOyxPfeOuQZJrekpiocw> GZBBFnBUOMLdnjvMbpSSRmZOCxWP;

			public aiBHDFfiMeVOFLOFgClDirwEsmx(UpdateLoopType updateLoop, int valueLength, int eventCapacity)
				: base(updateLoop)
			{
				QRDpwPykAQowLDZXAdYlFwGxNGI = new float[valueLength];
				nzzKRmsoqtksxwmTvPUwSOXITMg = new float[valueLength];
				mDLiSWYwiVbkMETzjeOTcgDRppd = new ExpandableArray_DataContainer<ePopPcSKOyxPfeOuQZJrekpiocw>(eventCapacity, clearData: false, 20);
				GZBBFnBUOMLdnjvMbpSSRmZOCxWP = new ExpandableArray_DataContainer<ePopPcSKOyxPfeOuQZJrekpiocw>(eventCapacity, clearData: false, 20);
			}

			public void mtiNfGzpXHszOwiOIAVYQuMZclV()
			{
				for (int i = 0; i < nzzKRmsoqtksxwmTvPUwSOXITMg.Length; i++)
				{
					QRDpwPykAQowLDZXAdYlFwGxNGI[i] = nzzKRmsoqtksxwmTvPUwSOXITMg[i];
					nzzKRmsoqtksxwmTvPUwSOXITMg[i] = 0f;
				}
				mDLiSWYwiVbkMETzjeOTcgDRppd.Clear();
				int count = GZBBFnBUOMLdnjvMbpSSRmZOCxWP.Count;
				for (int j = 0; j < count; j++)
				{
					mDLiSWYwiVbkMETzjeOTcgDRppd.AddData(GZBBFnBUOMLdnjvMbpSSRmZOCxWP[j]);
				}
				GZBBFnBUOMLdnjvMbpSSRmZOCxWP.Clear();
			}

			public void nFvNUxLxWzqiTEuLEjLMGfabcdc(float[] P_0, float P_1)
			{
				for (int i = 0; i < nzzKRmsoqtksxwmTvPUwSOXITMg.Length; i++)
				{
					nzzKRmsoqtksxwmTvPUwSOXITMg[i] += P_0[i];
				}
				ePopPcSKOyxPfeOuQZJrekpiocw injector = GZBBFnBUOMLdnjvMbpSSRmZOCxWP.injector;
				injector.BlEpJzKrARSmsemSZuRuhnNljiDf(P_0, P_1);
				GZBBFnBUOMLdnjvMbpSSRmZOCxWP.Inject();
			}

			public override void skeOSBSqSPGPnIZySfEhxuCHbTXM()
			{
				Array.Clear(QRDpwPykAQowLDZXAdYlFwGxNGI, 0, QRDpwPykAQowLDZXAdYlFwGxNGI.Length);
				GZBBFnBUOMLdnjvMbpSSRmZOCxWP.Clear();
				mDLiSWYwiVbkMETzjeOTcgDRppd.Clear();
			}
		}

		public class ePopPcSKOyxPfeOuQZJrekpiocw : ExpandableArray_DataContainer<ePopPcSKOyxPfeOuQZJrekpiocw>.dCHFaZShTBabDEGADjARTEvjaeF, IComparable<ePopPcSKOyxPfeOuQZJrekpiocw>
		{
			public Vector3 QRDpwPykAQowLDZXAdYlFwGxNGI;

			public float nMELmVyDurcOmgrvmwRzYQUNdch;

			public ePopPcSKOyxPfeOuQZJrekpiocw()
			{
			}

			public ePopPcSKOyxPfeOuQZJrekpiocw(float[] rawValues, float deltaTime)
			{
				BlEpJzKrARSmsemSZuRuhnNljiDf(rawValues, deltaTime);
			}

			public void BlEpJzKrARSmsemSZuRuhnNljiDf(float[] P_0, float P_1)
			{
				int num = MathTools.Min(P_0.Length, 3);
				for (int i = 0; i < num; i++)
				{
					QRDpwPykAQowLDZXAdYlFwGxNGI[i] = P_0[i];
				}
				nMELmVyDurcOmgrvmwRzYQUNdch = P_1;
			}

			public void BlEpJzKrARSmsemSZuRuhnNljiDf(ePopPcSKOyxPfeOuQZJrekpiocw P_0)
			{
				QRDpwPykAQowLDZXAdYlFwGxNGI = P_0.QRDpwPykAQowLDZXAdYlFwGxNGI;
				nMELmVyDurcOmgrvmwRzYQUNdch = P_0.nMELmVyDurcOmgrvmwRzYQUNdch;
			}

			void ExpandableArray_DataContainer<ePopPcSKOyxPfeOuQZJrekpiocw>.dCHFaZShTBabDEGADjARTEvjaeF.BlEpJzKrARSmsemSZuRuhnNljiDf(ePopPcSKOyxPfeOuQZJrekpiocw P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in BlEpJzKrARSmsemSZuRuhnNljiDf
				this.BlEpJzKrARSmsemSZuRuhnNljiDf(P_0);
			}

			public bool DgmbuafWJZMEqPkddeXpJOTtrvLd(ePopPcSKOyxPfeOuQZJrekpiocw P_0)
			{
				if (nMELmVyDurcOmgrvmwRzYQUNdch == P_0.nMELmVyDurcOmgrvmwRzYQUNdch)
				{
					return QRDpwPykAQowLDZXAdYlFwGxNGI == P_0.QRDpwPykAQowLDZXAdYlFwGxNGI;
				}
				return false;
			}

			bool ExpandableArray_DataContainer<ePopPcSKOyxPfeOuQZJrekpiocw>.dCHFaZShTBabDEGADjARTEvjaeF.DgmbuafWJZMEqPkddeXpJOTtrvLd(ePopPcSKOyxPfeOuQZJrekpiocw P_0)
			{
				//ILSpy generated this explicit interface implementation from .override directive in DgmbuafWJZMEqPkddeXpJOTtrvLd
				return this.DgmbuafWJZMEqPkddeXpJOTtrvLd(P_0);
			}

			public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
			{
				QRDpwPykAQowLDZXAdYlFwGxNGI.x = 0f;
				QRDpwPykAQowLDZXAdYlFwGxNGI.y = 0f;
				QRDpwPykAQowLDZXAdYlFwGxNGI.z = 0f;
				nMELmVyDurcOmgrvmwRzYQUNdch = 0f;
			}

			void ExpandableArray_DataContainer<ePopPcSKOyxPfeOuQZJrekpiocw>.dCHFaZShTBabDEGADjARTEvjaeF.LlCkzvOeJVaCziTDPktzBWuYotAZ()
			{
				//ILSpy generated this explicit interface implementation from .override directive in LlCkzvOeJVaCziTDPktzBWuYotAZ
				this.LlCkzvOeJVaCziTDPktzBWuYotAZ();
			}

			public int CompareTo(ePopPcSKOyxPfeOuQZJrekpiocw other)
			{
				return 0;
			}
		}

		public double timestamp;

		public readonly float[] lastRawValue;

		public readonly int valueLength;

		private readonly byte[] AFsAGvoENXAOYWyexqhHCWyJHGd;

		private readonly float[] yjPAJwJXppqvWdYcGCtmDtRdVmko;

		private readonly int DrCFybjMOpDbzbOPwGwiYjQRUIu;

		private readonly int DDwfHNlBhPbHLCOwiZJvzFdsZIr;

		private readonly Action<byte[], float[]> rxwfiFIqTEbnPtPaGotkCeUKiRwT;

		private readonly Func<float> qBBDuOCNZrVTpawnmlZGbwhIeCFz;

		public float[] rawValue => (dataSet as RBuzuNFbOSamEghQRbFWPmoFDarj).QRDpwPykAQowLDZXAdYlFwGxNGI;

		public ExpandableArray_DataContainer<ePopPcSKOyxPfeOuQZJrekpiocw> events => (dataSet as RBuzuNFbOSamEghQRbFWPmoFDarj).mDLiSWYwiVbkMETzjeOTcgDRppd;

		public HIDGyroscope(UpdateLoopSetting updateLoopSetting, byte reportId, HIDInfo hidInfo, int valueLength, int startingEventCapacity, Action<byte[], float[]> calcValueDelegate, Func<float> getSensorDeltaTimeDelegate)
			: base(new RBuzuNFbOSamEghQRbFWPmoFDarj(updateLoopSetting, valueLength, startingEventCapacity), reportId, hidInfo)
		{
			this.valueLength = valueLength;
			rxwfiFIqTEbnPtPaGotkCeUKiRwT = calcValueDelegate;
			qBBDuOCNZrVTpawnmlZGbwhIeCFz = getSensorDeltaTimeDelegate;
			DrCFybjMOpDbzbOPwGwiYjQRUIu = ((hidInfo.bitSize > 0) ? ((hidInfo.bitSize + 8 - 1) / 8) : 0);
			DDwfHNlBhPbHLCOwiZJvzFdsZIr = hidInfo.dataIndex;
			AFsAGvoENXAOYWyexqhHCWyJHGd = new byte[DrCFybjMOpDbzbOPwGwiYjQRUIu];
			yjPAJwJXppqvWdYcGCtmDtRdVmko = new float[valueLength];
			lastRawValue = new float[valueLength];
		}

		public override void UpdateValue(NativeBuffer inputReport, double timestamp)
		{
			if (inputReport != null && inputReport[0] == reportId)
			{
				this.timestamp = timestamp;
				for (int i = 0; i < DrCFybjMOpDbzbOPwGwiYjQRUIu; i++)
				{
					AFsAGvoENXAOYWyexqhHCWyJHGd[i] = inputReport[DDwfHNlBhPbHLCOwiZJvzFdsZIr + i];
				}
				if (rxwfiFIqTEbnPtPaGotkCeUKiRwT != null)
				{
					rxwfiFIqTEbnPtPaGotkCeUKiRwT(AFsAGvoENXAOYWyexqhHCWyJHGd, yjPAJwJXppqvWdYcGCtmDtRdVmko);
				}
				float num = ((qBBDuOCNZrVTpawnmlZGbwhIeCFz != null) ? qBBDuOCNZrVTpawnmlZGbwhIeCFz() : 0f);
				(dataSet as RBuzuNFbOSamEghQRbFWPmoFDarj).wuJiFxIHpunygwghobkYAvoBUnFB(yjPAJwJXppqvWdYcGCtmDtRdVmko, num);
				for (int j = 0; j < valueLength; j++)
				{
					lastRawValue[j] = yjPAJwJXppqvWdYcGCtmDtRdVmko[j];
				}
			}
		}

		public void UpdateValueManual(float[] value, double timestamp)
		{
			this.timestamp = timestamp;
			float num = ((qBBDuOCNZrVTpawnmlZGbwhIeCFz != null) ? qBBDuOCNZrVTpawnmlZGbwhIeCFz() : 0f);
			for (int i = 0; i < valueLength; i++)
			{
				yjPAJwJXppqvWdYcGCtmDtRdVmko[i] = value[i];
			}
			(dataSet as RBuzuNFbOSamEghQRbFWPmoFDarj).wuJiFxIHpunygwghobkYAvoBUnFB(yjPAJwJXppqvWdYcGCtmDtRdVmko, num);
			for (int j = 0; j < valueLength; j++)
			{
				lastRawValue[j] = yjPAJwJXppqvWdYcGCtmDtRdVmko[j];
			}
		}
	}
}
