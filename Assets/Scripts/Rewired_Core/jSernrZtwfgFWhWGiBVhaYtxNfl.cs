using System;
using System.Runtime.CompilerServices;
using Rewired;
using Rewired.Utils.Classes.Utility;

internal class jSernrZtwfgFWhWGiBVhaYtxNfl
{
	private class iUTLwatQwAGRdacuhWiJicbKGbD
	{
		[Flags]
		private enum QQadMaMdDUrfoszqbVIMzwaQelg : byte
		{
			fUyeeVFhkdEderlnmYYFoAwmZEL = 0,
			cMadHwBPAxwLXjqsolvChbWhcysm = 1,
			MptAKHGCfBqoHyvWYJOXQjhZnWz = 2,
			TdIhzZusivVpejQnfeGJgRgKbCC = 4,
			ObvAlAcgkcoqdjUSsKfCWQaTGSQa = 8
		}

		private QQadMaMdDUrfoszqbVIMzwaQelg bvCAKWIqWpqXDpHqoSmmOfdNAgMo;

		private uint LajtUdijipjhSdcWrGlfaqpPBxFf;

		private bool AoCBqFmMAhRTERFsQyKaWpIlUpK;

		public bool cbQVAkHLGVGfcmZtueMCAtGukkd => AoCBqFmMAhRTERFsQyKaWpIlUpK;

		public ButtonStateFlags WMPgPQJeUOrYvQehNDottdeoomhB(bool P_0)
		{
			ButtonStateFlags buttonStateFlags = ButtonStateFlags.DyTkQiNnAPnZlOxrECHYhBSslIv;
			if (P_0)
			{
				if ((bvCAKWIqWpqXDpHqoSmmOfdNAgMo & QQadMaMdDUrfoszqbVIMzwaQelg.cMadHwBPAxwLXjqsolvChbWhcysm) != 0)
				{
					buttonStateFlags |= ButtonStateFlags.AgsjzxPUGELGeHFAPrimMZoZTDX;
					if ((bvCAKWIqWpqXDpHqoSmmOfdNAgMo & QQadMaMdDUrfoszqbVIMzwaQelg.TdIhzZusivVpejQnfeGJgRgKbCC) == 0)
					{
						buttonStateFlags |= ButtonStateFlags.hETjdkpgSiFPkwdEDdKSivclaArr;
					}
				}
				else if ((bvCAKWIqWpqXDpHqoSmmOfdNAgMo & QQadMaMdDUrfoszqbVIMzwaQelg.TdIhzZusivVpejQnfeGJgRgKbCC) != 0)
				{
					buttonStateFlags |= ButtonStateFlags.KCDWeODdPSdTyfVHhGgQWADLelYa;
				}
			}
			else if ((bvCAKWIqWpqXDpHqoSmmOfdNAgMo & QQadMaMdDUrfoszqbVIMzwaQelg.MptAKHGCfBqoHyvWYJOXQjhZnWz) != 0)
			{
				buttonStateFlags |= ButtonStateFlags.AgsjzxPUGELGeHFAPrimMZoZTDX;
				if ((bvCAKWIqWpqXDpHqoSmmOfdNAgMo & QQadMaMdDUrfoszqbVIMzwaQelg.ObvAlAcgkcoqdjUSsKfCWQaTGSQa) == 0)
				{
					buttonStateFlags |= ButtonStateFlags.hETjdkpgSiFPkwdEDdKSivclaArr;
				}
			}
			else if ((bvCAKWIqWpqXDpHqoSmmOfdNAgMo & QQadMaMdDUrfoszqbVIMzwaQelg.ObvAlAcgkcoqdjUSsKfCWQaTGSQa) != 0)
			{
				buttonStateFlags |= ButtonStateFlags.KCDWeODdPSdTyfVHhGgQWADLelYa;
			}
			return buttonStateFlags;
		}

		public void mtiNfGzpXHszOwiOIAVYQuMZclV()
		{
			QQadMaMdDUrfoszqbVIMzwaQelg qQadMaMdDUrfoszqbVIMzwaQelg = QQadMaMdDUrfoszqbVIMzwaQelg.fUyeeVFhkdEderlnmYYFoAwmZEL;
			if ((bvCAKWIqWpqXDpHqoSmmOfdNAgMo & QQadMaMdDUrfoszqbVIMzwaQelg.cMadHwBPAxwLXjqsolvChbWhcysm) != 0)
			{
				qQadMaMdDUrfoszqbVIMzwaQelg |= QQadMaMdDUrfoszqbVIMzwaQelg.TdIhzZusivVpejQnfeGJgRgKbCC;
			}
			if ((bvCAKWIqWpqXDpHqoSmmOfdNAgMo & QQadMaMdDUrfoszqbVIMzwaQelg.MptAKHGCfBqoHyvWYJOXQjhZnWz) != 0)
			{
				qQadMaMdDUrfoszqbVIMzwaQelg |= QQadMaMdDUrfoszqbVIMzwaQelg.ObvAlAcgkcoqdjUSsKfCWQaTGSQa;
			}
			bvCAKWIqWpqXDpHqoSmmOfdNAgMo = qQadMaMdDUrfoszqbVIMzwaQelg;
		}

		public void OAFlvPdHOjXWTvxfZdnCaGjIult(uint P_0)
		{
			if (LajtUdijipjhSdcWrGlfaqpPBxFf < P_0 - 1)
			{
				AoCBqFmMAhRTERFsQyKaWpIlUpK = false;
			}
		}

		public void YToveGdcRHkKMwBHduKuPAzLFOu(bool P_0)
		{
			if (P_0)
			{
				bvCAKWIqWpqXDpHqoSmmOfdNAgMo |= QQadMaMdDUrfoszqbVIMzwaQelg.cMadHwBPAxwLXjqsolvChbWhcysm;
			}
			else
			{
				bvCAKWIqWpqXDpHqoSmmOfdNAgMo |= QQadMaMdDUrfoszqbVIMzwaQelg.MptAKHGCfBqoHyvWYJOXQjhZnWz;
			}
			LajtUdijipjhSdcWrGlfaqpPBxFf = ReInput.currentFrame;
			if (!AoCBqFmMAhRTERFsQyKaWpIlUpK)
			{
				AoCBqFmMAhRTERFsQyKaWpIlUpK = true;
			}
		}

		public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
		{
			bvCAKWIqWpqXDpHqoSmmOfdNAgMo = QQadMaMdDUrfoszqbVIMzwaQelg.fUyeeVFhkdEderlnmYYFoAwmZEL;
			LajtUdijipjhSdcWrGlfaqpPBxFf = 0u;
			AoCBqFmMAhRTERFsQyKaWpIlUpK = false;
		}
	}

	private const int mZbkYpyBaVIglcwfVrYINwlIOAL = 20;

	private const int pmeiIiKSnOlvuztaGjOsNeGnrlD = 10;

	private static ObjectPool<jSernrZtwfgFWhWGiBVhaYtxNfl> QXADTtrfJyOGeEzcRqspcdIhAgW;

	private static jSernrZtwfgFWhWGiBVhaYtxNfl[] MCVBtDkFRzlVythmhZclZvaNVQU;

	private static int FvjHfdbGMMwdANnAsqTYPLRaHKh;

	public int BUkOtBllnCuPgNIQlDKlhrTtyytP;

	private UpdateLoopDataSet<iUTLwatQwAGRdacuhWiJicbKGbD> GZiKkeidqaTfqSdbqalEscYeqpT;

	[CompilerGenerated]
	private static Func<jSernrZtwfgFWhWGiBVhaYtxNfl> suQFSecMyJYdyKWXbLbVEMkNddOe;

	[CompilerGenerated]
	private static Action<jSernrZtwfgFWhWGiBVhaYtxNfl> kcHgEtKYhqtwzTPOvvORFEUwYnJ;

	[CompilerGenerated]
	private static Func<iUTLwatQwAGRdacuhWiJicbKGbD> pectuQcVPqrHcaPDJtuIjnCUgQY;

	public bool cbQVAkHLGVGfcmZtueMCAtGukkd
	{
		get
		{
			int count = GZiKkeidqaTfqSdbqalEscYeqpT.Count;
			for (int i = 0; i < count; i++)
			{
				if (GZiKkeidqaTfqSdbqalEscYeqpT[i].cbQVAkHLGVGfcmZtueMCAtGukkd)
				{
					return true;
				}
			}
			return false;
		}
	}

	static jSernrZtwfgFWhWGiBVhaYtxNfl()
	{
		QXADTtrfJyOGeEzcRqspcdIhAgW = new ObjectPool<jSernrZtwfgFWhWGiBVhaYtxNfl>(20, () => new jSernrZtwfgFWhWGiBVhaYtxNfl(), delegate(jSernrZtwfgFWhWGiBVhaYtxNfl P_0)
		{
			P_0.LlCkzvOeJVaCziTDPktzBWuYotAZ();
		});
		MCVBtDkFRzlVythmhZclZvaNVQU = new jSernrZtwfgFWhWGiBVhaYtxNfl[20];
	}

	public static void skeOSBSqSPGPnIZySfEhxuCHbTXM()
	{
		FvjHfdbGMMwdANnAsqTYPLRaHKh = 0;
		Array.Clear(MCVBtDkFRzlVythmhZclZvaNVQU, 0, MCVBtDkFRzlVythmhZclZvaNVQU.Length);
	}

	public static jSernrZtwfgFWhWGiBVhaYtxNfl sezeDwIhqSxIrrYLXmDBFGqFFqh(int P_0)
	{
		for (int i = 0; i < FvjHfdbGMMwdANnAsqTYPLRaHKh; i++)
		{
			if (MCVBtDkFRzlVythmhZclZvaNVQU[i] != null && MCVBtDkFRzlVythmhZclZvaNVQU[i].BUkOtBllnCuPgNIQlDKlhrTtyytP == P_0)
			{
				return MCVBtDkFRzlVythmhZclZvaNVQU[i];
			}
		}
		return null;
	}

	public static jSernrZtwfgFWhWGiBVhaYtxNfl bxMoFoqvmPaQLIJckPsRmJGDrlE(int P_0)
	{
		jSernrZtwfgFWhWGiBVhaYtxNfl jSernrZtwfgFWhWGiBVhaYtxNfl2 = sezeDwIhqSxIrrYLXmDBFGqFFqh(P_0);
		if (jSernrZtwfgFWhWGiBVhaYtxNfl2 != null)
		{
			return jSernrZtwfgFWhWGiBVhaYtxNfl2;
		}
		jSernrZtwfgFWhWGiBVhaYtxNfl2 = QXADTtrfJyOGeEzcRqspcdIhAgW.Get();
		jSernrZtwfgFWhWGiBVhaYtxNfl2.VHccjfEMNntOyUjHbKfsjtKQWZf(P_0);
		jSernrZtwfgFWhWGiBVhaYtxNfl2.GZiKkeidqaTfqSdbqalEscYeqpT.SetUpdateLoop(ReInput.currentUpdateLoop);
		ZIfLqgwRjYUgtmPmqmqURNWkkFF(jSernrZtwfgFWhWGiBVhaYtxNfl2);
		return jSernrZtwfgFWhWGiBVhaYtxNfl2;
	}

	public static void oQcTSAoJFGLAsIpqhKNaiLZrNmQ(UpdateLoopType P_0)
	{
		for (int i = 0; i < FvjHfdbGMMwdANnAsqTYPLRaHKh; i++)
		{
			if (MCVBtDkFRzlVythmhZclZvaNVQU[i] != null)
			{
				MCVBtDkFRzlVythmhZclZvaNVQU[i].mtiNfGzpXHszOwiOIAVYQuMZclV(P_0);
			}
		}
	}

	public static void OAFlvPdHOjXWTvxfZdnCaGjIult(UpdateLoopType P_0, uint P_1)
	{
		for (int num = FvjHfdbGMMwdANnAsqTYPLRaHKh - 1; num >= 0; num--)
		{
			if (MCVBtDkFRzlVythmhZclZvaNVQU[num] == null)
			{
				if (num == FvjHfdbGMMwdANnAsqTYPLRaHKh - 1)
				{
					FvjHfdbGMMwdANnAsqTYPLRaHKh--;
				}
			}
			else
			{
				MCVBtDkFRzlVythmhZclZvaNVQU[num].OAFlvPdHOjXWTvxfZdnCaGjIult(P_1);
				if (!MCVBtDkFRzlVythmhZclZvaNVQU[num].cbQVAkHLGVGfcmZtueMCAtGukkd)
				{
					JONJawocaCltcmNtSApCKGHYMlPb(num);
				}
			}
		}
	}

	private static void ZIfLqgwRjYUgtmPmqmqURNWkkFF(jSernrZtwfgFWhWGiBVhaYtxNfl P_0)
	{
		int num = XkPCVlbsAlisvdfmmMIwGBIiKZwS();
		if (num < 0)
		{
			if (FvjHfdbGMMwdANnAsqTYPLRaHKh == MCVBtDkFRzlVythmhZclZvaNVQU.Length)
			{
				jSernrZtwfgFWhWGiBVhaYtxNfl[] mCVBtDkFRzlVythmhZclZvaNVQU = MCVBtDkFRzlVythmhZclZvaNVQU;
				MCVBtDkFRzlVythmhZclZvaNVQU = new jSernrZtwfgFWhWGiBVhaYtxNfl[MCVBtDkFRzlVythmhZclZvaNVQU.Length + 10];
				Array.Copy(mCVBtDkFRzlVythmhZclZvaNVQU, MCVBtDkFRzlVythmhZclZvaNVQU, mCVBtDkFRzlVythmhZclZvaNVQU.Length);
			}
			num = FvjHfdbGMMwdANnAsqTYPLRaHKh;
			FvjHfdbGMMwdANnAsqTYPLRaHKh++;
		}
		MCVBtDkFRzlVythmhZclZvaNVQU[num] = P_0;
	}

	private static void JONJawocaCltcmNtSApCKGHYMlPb(int P_0)
	{
		if (P_0 >= 0 && P_0 < FvjHfdbGMMwdANnAsqTYPLRaHKh)
		{
			jSernrZtwfgFWhWGiBVhaYtxNfl jSernrZtwfgFWhWGiBVhaYtxNfl2 = MCVBtDkFRzlVythmhZclZvaNVQU[P_0];
			if (jSernrZtwfgFWhWGiBVhaYtxNfl2 != null)
			{
				QXADTtrfJyOGeEzcRqspcdIhAgW.Return(jSernrZtwfgFWhWGiBVhaYtxNfl2);
				MCVBtDkFRzlVythmhZclZvaNVQU[P_0] = null;
			}
			if (P_0 == FvjHfdbGMMwdANnAsqTYPLRaHKh - 1)
			{
				FvjHfdbGMMwdANnAsqTYPLRaHKh--;
			}
		}
	}

	private static int XkPCVlbsAlisvdfmmMIwGBIiKZwS()
	{
		for (int i = 0; i < FvjHfdbGMMwdANnAsqTYPLRaHKh; i++)
		{
			if (MCVBtDkFRzlVythmhZclZvaNVQU[i] == null)
			{
				return i;
			}
		}
		if (FvjHfdbGMMwdANnAsqTYPLRaHKh >= MCVBtDkFRzlVythmhZclZvaNVQU.Length)
		{
			return -1;
		}
		int fvjHfdbGMMwdANnAsqTYPLRaHKh = FvjHfdbGMMwdANnAsqTYPLRaHKh;
		FvjHfdbGMMwdANnAsqTYPLRaHKh++;
		return fvjHfdbGMMwdANnAsqTYPLRaHKh;
	}

	public ButtonStateFlags WMPgPQJeUOrYvQehNDottdeoomhB(bool P_0)
	{
		return GZiKkeidqaTfqSdbqalEscYeqpT.Current.WMPgPQJeUOrYvQehNDottdeoomhB(P_0);
	}

	public jSernrZtwfgFWhWGiBVhaYtxNfl()
	{
		GZiKkeidqaTfqSdbqalEscYeqpT = new UpdateLoopDataSet<iUTLwatQwAGRdacuhWiJicbKGbD>(ReInput.UserData.ConfigVars.updateLoop, () => new iUTLwatQwAGRdacuhWiJicbKGbD());
		LlCkzvOeJVaCziTDPktzBWuYotAZ();
	}

	public void mtiNfGzpXHszOwiOIAVYQuMZclV(UpdateLoopType P_0)
	{
		GZiKkeidqaTfqSdbqalEscYeqpT.SetUpdateLoop(P_0);
		GZiKkeidqaTfqSdbqalEscYeqpT.Current.mtiNfGzpXHszOwiOIAVYQuMZclV();
	}

	public void OAFlvPdHOjXWTvxfZdnCaGjIult(uint P_0)
	{
		GZiKkeidqaTfqSdbqalEscYeqpT.Current.OAFlvPdHOjXWTvxfZdnCaGjIult(P_0);
	}

	public void YToveGdcRHkKMwBHduKuPAzLFOu(UpdateLoopType P_0, bool P_1)
	{
		GZiKkeidqaTfqSdbqalEscYeqpT.Current.YToveGdcRHkKMwBHduKuPAzLFOu(P_1);
	}

	private void VHccjfEMNntOyUjHbKfsjtKQWZf(int P_0)
	{
		BUkOtBllnCuPgNIQlDKlhrTtyytP = P_0;
	}

	private void LlCkzvOeJVaCziTDPktzBWuYotAZ()
	{
		BUkOtBllnCuPgNIQlDKlhrTtyytP = -1;
		for (int i = 0; i < GZiKkeidqaTfqSdbqalEscYeqpT.Count; i++)
		{
			GZiKkeidqaTfqSdbqalEscYeqpT[i].LlCkzvOeJVaCziTDPktzBWuYotAZ();
		}
	}

	[CompilerGenerated]
	private static jSernrZtwfgFWhWGiBVhaYtxNfl oAKlRQNwkOIHzpPOoVkfKBFcKhN()
	{
		return new jSernrZtwfgFWhWGiBVhaYtxNfl();
	}

	[CompilerGenerated]
	private static void ZoGnwBWbOLMDwejCGueQpLvZRaZ(jSernrZtwfgFWhWGiBVhaYtxNfl P_0)
	{
		P_0.LlCkzvOeJVaCziTDPktzBWuYotAZ();
	}

	[CompilerGenerated]
	private static iUTLwatQwAGRdacuhWiJicbKGbD iyjznoUUReUEdOgPozQHhmVAKCB()
	{
		return new iUTLwatQwAGRdacuhWiJicbKGbD();
	}
}
