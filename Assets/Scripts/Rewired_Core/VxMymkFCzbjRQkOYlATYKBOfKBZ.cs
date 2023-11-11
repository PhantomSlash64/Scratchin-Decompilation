using System.Collections.Generic;
using Rewired;
using Rewired.Config;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using UnityEngine;

internal class VxMymkFCzbjRQkOYlATYKBOfKBZ
{
	private class zaNCfJfnCedZqEtqIMNOKMMyedcI
	{
		private class GtczvMeCUpjsGOqGZRodNNXGorr
		{
			private int QIzoBncePxUUbbqEfLpERqPqJaL;

			private oaRbTjTOYZjtXkpiSNFTCgZcBwz[] ifqVRInjAzRYJsVFyORpqnnqXsX;

			private rpRgRkjOMkzTzeNwcDGdRQgoYxN[] bFcmhobRSzSgJJkcPcrVLHPiWbm;

			public GtczvMeCUpjsGOqGZRodNNXGorr(int index)
			{
				QIzoBncePxUUbbqEfLpERqPqJaL = index;
				ifqVRInjAzRYJsVFyORpqnnqXsX = new oaRbTjTOYZjtXkpiSNFTCgZcBwz[20];
				for (int i = 0; i < ifqVRInjAzRYJsVFyORpqnnqXsX.Length; i++)
				{
					ifqVRInjAzRYJsVFyORpqnnqXsX[i] = new oaRbTjTOYZjtXkpiSNFTCgZcBwz();
				}
				bFcmhobRSzSgJJkcPcrVLHPiWbm = new rpRgRkjOMkzTzeNwcDGdRQgoYxN[29];
				for (int j = 0; j < bFcmhobRSzSgJJkcPcrVLHPiWbm.Length; j++)
				{
					bFcmhobRSzSgJJkcPcrVLHPiWbm[j] = new rpRgRkjOMkzTzeNwcDGdRQgoYxN(j);
				}
			}

			public void brtDRRhixkprTggVKNatDRbDZZMJ()
			{
				for (int i = 0; i < ifqVRInjAzRYJsVFyORpqnnqXsX.Length; i++)
				{
					bool joystickButtonValueByJoystickIndex = UnityInputHelper.GetJoystickButtonValueByJoystickIndex(QIzoBncePxUUbbqEfLpERqPqJaL, i);
					ifqVRInjAzRYJsVFyORpqnnqXsX[i].brtDRRhixkprTggVKNatDRbDZZMJ(joystickButtonValueByJoystickIndex);
				}
				for (int j = 0; j < bFcmhobRSzSgJJkcPcrVLHPiWbm.Length; j++)
				{
					float joystickAxisRawValueByJoystickIndex = UnityInputHelper.GetJoystickAxisRawValueByJoystickIndex(QIzoBncePxUUbbqEfLpERqPqJaL, j);
					bFcmhobRSzSgJJkcPcrVLHPiWbm[j].brtDRRhixkprTggVKNatDRbDZZMJ(joystickAxisRawValueByJoystickIndex);
				}
			}

			public void mtiNfGzpXHszOwiOIAVYQuMZclV()
			{
				for (int i = 0; i < ifqVRInjAzRYJsVFyORpqnnqXsX.Length; i++)
				{
					ifqVRInjAzRYJsVFyORpqnnqXsX[i].foSRcEqSuRsWnadDiKcGnhBewOU = UnityInputHelper.GetJoystickButtonValueByJoystickIndex(QIzoBncePxUUbbqEfLpERqPqJaL, i);
				}
				for (int j = 0; j < bFcmhobRSzSgJJkcPcrVLHPiWbm.Length; j++)
				{
					bFcmhobRSzSgJJkcPcrVLHPiWbm[j].foSRcEqSuRsWnadDiKcGnhBewOU = UnityInputHelper.GetJoystickAxisRawValueByJoystickIndex(QIzoBncePxUUbbqEfLpERqPqJaL, j);
				}
			}

			public bool TCWvrlpYTrIwTmaFZCrFglGyZdS(int P_0)
			{
				if (P_0 < 0 || P_0 >= ifqVRInjAzRYJsVFyORpqnnqXsX.Length)
				{
					return false;
				}
				return ifqVRInjAzRYJsVFyORpqnnqXsX[P_0].foSRcEqSuRsWnadDiKcGnhBewOU;
			}

			public bool UzfAMThVYdqMudGicKGhMmcVLNfe(int P_0)
			{
				if (P_0 < 0 || P_0 >= ifqVRInjAzRYJsVFyORpqnnqXsX.Length)
				{
					return false;
				}
				return ifqVRInjAzRYJsVFyORpqnnqXsX[P_0].ackAfqTveINRnSkXedYMDkCbEItF;
			}

			public bool oRveQXtNmlxxfdFQcBcgiXXDnHhU(int P_0)
			{
				if (P_0 < 0 || P_0 >= ifqVRInjAzRYJsVFyORpqnnqXsX.Length)
				{
					return false;
				}
				return ifqVRInjAzRYJsVFyORpqnnqXsX[P_0].lwYGtHhLAvocvsdFvNxxGuUzHyh;
			}

			public float GLWgPekOoFtzAmRRNYWNkzKdCZgc(int P_0)
			{
				if (P_0 < 0 || P_0 >= bFcmhobRSzSgJJkcPcrVLHPiWbm.Length)
				{
					return 0f;
				}
				return bFcmhobRSzSgJJkcPcrVLHPiWbm[P_0].foSRcEqSuRsWnadDiKcGnhBewOU;
			}

			public bool bULLGqCvnZRwzISvjjPzpcdeYxE(int P_0, bool P_1)
			{
				if (P_0 < 0 || P_0 >= bFcmhobRSzSgJJkcPcrVLHPiWbm.Length)
				{
					return false;
				}
				return bFcmhobRSzSgJJkcPcrVLHPiWbm[P_0].cwUajFhVQYBWmVCCNsfIithjoxwz(P_1);
			}

			public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
			{
				for (int i = 0; i < ifqVRInjAzRYJsVFyORpqnnqXsX.Length; i++)
				{
					ifqVRInjAzRYJsVFyORpqnnqXsX[i].LlCkzvOeJVaCziTDPktzBWuYotAZ();
				}
				for (int j = 0; j < bFcmhobRSzSgJJkcPcrVLHPiWbm.Length; j++)
				{
					bFcmhobRSzSgJJkcPcrVLHPiWbm[j].LlCkzvOeJVaCziTDPktzBWuYotAZ();
				}
			}
		}

		private class mqkqLmfwfGdWwEAJWAcpDlXnptCy
		{
			private oaRbTjTOYZjtXkpiSNFTCgZcBwz[] ifqVRInjAzRYJsVFyORpqnnqXsX;

			public mqkqLmfwfGdWwEAJWAcpDlXnptCy()
			{
				ifqVRInjAzRYJsVFyORpqnnqXsX = new oaRbTjTOYZjtXkpiSNFTCgZcBwz[7];
				for (int i = 0; i < ifqVRInjAzRYJsVFyORpqnnqXsX.Length; i++)
				{
					ifqVRInjAzRYJsVFyORpqnnqXsX[i] = new oaRbTjTOYZjtXkpiSNFTCgZcBwz();
				}
			}

			public void mtiNfGzpXHszOwiOIAVYQuMZclV()
			{
				for (int i = 0; i < ifqVRInjAzRYJsVFyORpqnnqXsX.Length; i++)
				{
					ifqVRInjAzRYJsVFyORpqnnqXsX[i].foSRcEqSuRsWnadDiKcGnhBewOU = Input.GetButton("MouseButton" + i);
				}
			}

			public bool TCWvrlpYTrIwTmaFZCrFglGyZdS(int P_0)
			{
				if (P_0 < 0 || P_0 >= ifqVRInjAzRYJsVFyORpqnnqXsX.Length)
				{
					return false;
				}
				return ifqVRInjAzRYJsVFyORpqnnqXsX[P_0].foSRcEqSuRsWnadDiKcGnhBewOU;
			}

			public bool UzfAMThVYdqMudGicKGhMmcVLNfe(int P_0)
			{
				if (P_0 < 0 || P_0 >= ifqVRInjAzRYJsVFyORpqnnqXsX.Length)
				{
					return false;
				}
				return ifqVRInjAzRYJsVFyORpqnnqXsX[P_0].ackAfqTveINRnSkXedYMDkCbEItF;
			}

			public bool oRveQXtNmlxxfdFQcBcgiXXDnHhU(int P_0)
			{
				if (P_0 < 0 || P_0 >= ifqVRInjAzRYJsVFyORpqnnqXsX.Length)
				{
					return false;
				}
				return ifqVRInjAzRYJsVFyORpqnnqXsX[P_0].lwYGtHhLAvocvsdFvNxxGuUzHyh;
			}

			public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
			{
				for (int i = 0; i < ifqVRInjAzRYJsVFyORpqnnqXsX.Length; i++)
				{
					ifqVRInjAzRYJsVFyORpqnnqXsX[i].LlCkzvOeJVaCziTDPktzBWuYotAZ();
				}
			}
		}

		private class oaRbTjTOYZjtXkpiSNFTCgZcBwz
		{
			private bool bvCAKWIqWpqXDpHqoSmmOfdNAgMo;

			private bool EWHUzvWsiaScbWZIgWPBDMFaAhcE;

			public bool foSRcEqSuRsWnadDiKcGnhBewOU
			{
				get
				{
					return bvCAKWIqWpqXDpHqoSmmOfdNAgMo;
				}
				set
				{
					EWHUzvWsiaScbWZIgWPBDMFaAhcE = bvCAKWIqWpqXDpHqoSmmOfdNAgMo;
					bvCAKWIqWpqXDpHqoSmmOfdNAgMo = value;
				}
			}

			public bool ackAfqTveINRnSkXedYMDkCbEItF
			{
				get
				{
					if (bvCAKWIqWpqXDpHqoSmmOfdNAgMo)
					{
						return !EWHUzvWsiaScbWZIgWPBDMFaAhcE;
					}
					return false;
				}
			}

			public bool lwYGtHhLAvocvsdFvNxxGuUzHyh
			{
				get
				{
					if (EWHUzvWsiaScbWZIgWPBDMFaAhcE)
					{
						return !bvCAKWIqWpqXDpHqoSmmOfdNAgMo;
					}
					return false;
				}
			}

			public void brtDRRhixkprTggVKNatDRbDZZMJ(bool P_0)
			{
				bvCAKWIqWpqXDpHqoSmmOfdNAgMo = P_0;
				EWHUzvWsiaScbWZIgWPBDMFaAhcE = P_0;
			}

			public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
			{
				bvCAKWIqWpqXDpHqoSmmOfdNAgMo = false;
				EWHUzvWsiaScbWZIgWPBDMFaAhcE = false;
			}
		}

		private class rpRgRkjOMkzTzeNwcDGdRQgoYxN
		{
			private int jSYCUymPwaeXNpPqaXTjxAHEaRv;

			private float bvCAKWIqWpqXDpHqoSmmOfdNAgMo;

			private float CqSGJPpOcjzGIcaeuENkHhwsFNXV;

			public float foSRcEqSuRsWnadDiKcGnhBewOU
			{
				get
				{
					return bvCAKWIqWpqXDpHqoSmmOfdNAgMo;
				}
				set
				{
					bvCAKWIqWpqXDpHqoSmmOfdNAgMo = value;
				}
			}

			public rpRgRkjOMkzTzeNwcDGdRQgoYxN(int axisIndex)
			{
				jSYCUymPwaeXNpPqaXTjxAHEaRv = axisIndex;
			}

			public void brtDRRhixkprTggVKNatDRbDZZMJ(float P_0)
			{
				CqSGJPpOcjzGIcaeuENkHhwsFNXV = P_0;
				bvCAKWIqWpqXDpHqoSmmOfdNAgMo = P_0;
			}

			public bool cwUajFhVQYBWmVCCNsfIithjoxwz(bool P_0)
			{
				float num = bvCAKWIqWpqXDpHqoSmmOfdNAgMo - CqSGJPpOcjzGIcaeuENkHhwsFNXV;
				if (P_0 && num < 0f)
				{
					return false;
				}
				if (MathTools.Abs(num) > 0.7f)
				{
					return true;
				}
				return false;
			}

			public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
			{
				bvCAKWIqWpqXDpHqoSmmOfdNAgMo = 0f;
				CqSGJPpOcjzGIcaeuENkHhwsFNXV = 0f;
			}
		}

		private GtczvMeCUpjsGOqGZRodNNXGorr[] mqdAbRkCKsLDODrmCZPalaGwyaPz;

		private mqkqLmfwfGdWwEAJWAcpDlXnptCy ojmdTJoYFMPLFmIeEmAuAwjFqsY;

		public zaNCfJfnCedZqEtqIMNOKMMyedcI()
		{
			mqdAbRkCKsLDODrmCZPalaGwyaPz = new GtczvMeCUpjsGOqGZRodNNXGorr[16];
			for (int i = 0; i < mqdAbRkCKsLDODrmCZPalaGwyaPz.Length; i++)
			{
				mqdAbRkCKsLDODrmCZPalaGwyaPz[i] = new GtczvMeCUpjsGOqGZRodNNXGorr(i);
			}
			ojmdTJoYFMPLFmIeEmAuAwjFqsY = new mqkqLmfwfGdWwEAJWAcpDlXnptCy();
		}

		public void brtDRRhixkprTggVKNatDRbDZZMJ()
		{
			for (int i = 0; i < mqdAbRkCKsLDODrmCZPalaGwyaPz.Length; i++)
			{
				mqdAbRkCKsLDODrmCZPalaGwyaPz[i].brtDRRhixkprTggVKNatDRbDZZMJ();
			}
		}

		public void mtiNfGzpXHszOwiOIAVYQuMZclV()
		{
			for (int i = 0; i < mqdAbRkCKsLDODrmCZPalaGwyaPz.Length; i++)
			{
				mqdAbRkCKsLDODrmCZPalaGwyaPz[i].mtiNfGzpXHszOwiOIAVYQuMZclV();
			}
			ojmdTJoYFMPLFmIeEmAuAwjFqsY.mtiNfGzpXHszOwiOIAVYQuMZclV();
		}

		public bool DujBXFqADzEtiZPffoiHhRaYDCn(int P_0, int P_1)
		{
			if (P_0 < 0 || P_0 >= mqdAbRkCKsLDODrmCZPalaGwyaPz.Length)
			{
				return false;
			}
			return mqdAbRkCKsLDODrmCZPalaGwyaPz[P_0].TCWvrlpYTrIwTmaFZCrFglGyZdS(P_1);
		}

		public bool uQgqaNSvAqvaRaxNjuYjmDwtLln(int P_0, int P_1)
		{
			if (P_0 < 0 || P_0 >= mqdAbRkCKsLDODrmCZPalaGwyaPz.Length)
			{
				return false;
			}
			return mqdAbRkCKsLDODrmCZPalaGwyaPz[P_0].UzfAMThVYdqMudGicKGhMmcVLNfe(P_1);
		}

		public bool REqYOOxvWDwhUTcPzNbngTNDPAn(int P_0, int P_1)
		{
			if (P_0 < 0 || P_0 >= mqdAbRkCKsLDODrmCZPalaGwyaPz.Length)
			{
				return false;
			}
			return mqdAbRkCKsLDODrmCZPalaGwyaPz[P_0].oRveQXtNmlxxfdFQcBcgiXXDnHhU(P_1);
		}

		public bool WtKOSrvtHwHUjqpJJilbibyhooI(int P_0, int P_1, bool P_2)
		{
			if (P_0 < 0 || P_0 >= mqdAbRkCKsLDODrmCZPalaGwyaPz.Length)
			{
				return false;
			}
			return mqdAbRkCKsLDODrmCZPalaGwyaPz[P_0].bULLGqCvnZRwzISvjjPzpcdeYxE(P_1, P_2);
		}

		public bool MHLQGBJSvKvicluegRZtaxFVCOz(int P_0)
		{
			return ojmdTJoYFMPLFmIeEmAuAwjFqsY.TCWvrlpYTrIwTmaFZCrFglGyZdS(P_0);
		}

		public bool FWVmxXgLxJMNpdrYpdJbQPkWgzk(int P_0)
		{
			return ojmdTJoYFMPLFmIeEmAuAwjFqsY.UzfAMThVYdqMudGicKGhMmcVLNfe(P_0);
		}

		public bool YmUgmRexBxaFvxCpmGgUZfjErQtE(int P_0)
		{
			return ojmdTJoYFMPLFmIeEmAuAwjFqsY.oRveQXtNmlxxfdFQcBcgiXXDnHhU(P_0);
		}

		public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
		{
			for (int i = 0; i < mqdAbRkCKsLDODrmCZPalaGwyaPz.Length; i++)
			{
				mqdAbRkCKsLDODrmCZPalaGwyaPz[i].LlCkzvOeJVaCziTDPktzBWuYotAZ();
			}
			ojmdTJoYFMPLFmIeEmAuAwjFqsY.LlCkzvOeJVaCziTDPktzBWuYotAZ();
		}
	}

	private UpdateLoopType TnidRhAIPvMICseBcUJBQDrSFxL;

	private zaNCfJfnCedZqEtqIMNOKMMyedcI OzLaHUpNYIgGyHPoaRhkpxizlbas;

	private IndexedDictionary<int, zaNCfJfnCedZqEtqIMNOKMMyedcI> GZiKkeidqaTfqSdbqalEscYeqpT;

	public VxMymkFCzbjRQkOYlATYKBOfKBZ(UpdateLoopSetting updateLoopSetting)
	{
		GZiKkeidqaTfqSdbqalEscYeqpT = new IndexedDictionary<int, zaNCfJfnCedZqEtqIMNOKMMyedcI>();
		using (TempListPool.TList<UpdateLoopType> tList = TempListPool.GetTList<UpdateLoopType>(3))
		{
			List<UpdateLoopType> list = tList.list;
			EnumConverter.ToUpdateLoopTypes(updateLoopSetting, list);
			for (int i = 0; i < list.Count; i++)
			{
				GZiKkeidqaTfqSdbqalEscYeqpT.Add((int)list[i], new zaNCfJfnCedZqEtqIMNOKMMyedcI());
			}
		}
		TnidRhAIPvMICseBcUJBQDrSFxL = UpdateLoopType.Update;
		OzLaHUpNYIgGyHPoaRhkpxizlbas = GZiKkeidqaTfqSdbqalEscYeqpT.GetValue(0);
	}

	public void brtDRRhixkprTggVKNatDRbDZZMJ()
	{
		TWgHaYmxyJDmtIdmRggXxfqUjph(ReInput.currentUpdateLoop);
		OzLaHUpNYIgGyHPoaRhkpxizlbas.brtDRRhixkprTggVKNatDRbDZZMJ();
	}

	public void mtiNfGzpXHszOwiOIAVYQuMZclV(UpdateLoopType P_0)
	{
		TWgHaYmxyJDmtIdmRggXxfqUjph(P_0);
		OzLaHUpNYIgGyHPoaRhkpxizlbas.mtiNfGzpXHszOwiOIAVYQuMZclV();
	}

	public bool DujBXFqADzEtiZPffoiHhRaYDCn(int P_0, int P_1)
	{
		return OzLaHUpNYIgGyHPoaRhkpxizlbas.DujBXFqADzEtiZPffoiHhRaYDCn(P_0, P_1);
	}

	public bool uQgqaNSvAqvaRaxNjuYjmDwtLln(int P_0, int P_1)
	{
		return OzLaHUpNYIgGyHPoaRhkpxizlbas.uQgqaNSvAqvaRaxNjuYjmDwtLln(P_0, P_1);
	}

	public bool REqYOOxvWDwhUTcPzNbngTNDPAn(int P_0, int P_1)
	{
		return OzLaHUpNYIgGyHPoaRhkpxizlbas.REqYOOxvWDwhUTcPzNbngTNDPAn(P_0, P_1);
	}

	public bool WtKOSrvtHwHUjqpJJilbibyhooI(int P_0, int P_1, bool P_2)
	{
		return OzLaHUpNYIgGyHPoaRhkpxizlbas.WtKOSrvtHwHUjqpJJilbibyhooI(P_0, P_1, P_2);
	}

	public bool MHLQGBJSvKvicluegRZtaxFVCOz(int P_0)
	{
		return OzLaHUpNYIgGyHPoaRhkpxizlbas.MHLQGBJSvKvicluegRZtaxFVCOz(P_0);
	}

	public bool FWVmxXgLxJMNpdrYpdJbQPkWgzk(int P_0)
	{
		return OzLaHUpNYIgGyHPoaRhkpxizlbas.FWVmxXgLxJMNpdrYpdJbQPkWgzk(P_0);
	}

	public bool YmUgmRexBxaFvxCpmGgUZfjErQtE(int P_0)
	{
		return OzLaHUpNYIgGyHPoaRhkpxizlbas.YmUgmRexBxaFvxCpmGgUZfjErQtE(P_0);
	}

	public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
	{
		for (int i = 0; i < GZiKkeidqaTfqSdbqalEscYeqpT.Count; i++)
		{
			GZiKkeidqaTfqSdbqalEscYeqpT[i].LlCkzvOeJVaCziTDPktzBWuYotAZ();
		}
	}

	private void TWgHaYmxyJDmtIdmRggXxfqUjph(UpdateLoopType P_0)
	{
		if (TnidRhAIPvMICseBcUJBQDrSFxL != P_0)
		{
			TnidRhAIPvMICseBcUJBQDrSFxL = P_0;
			OzLaHUpNYIgGyHPoaRhkpxizlbas = GZiKkeidqaTfqSdbqalEscYeqpT.GetValue((int)P_0);
		}
	}
}
