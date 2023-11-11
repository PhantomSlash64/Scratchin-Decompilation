using System;
using System.Collections.Generic;
using Rewired.Config;
using Rewired.Utils;

namespace Rewired
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	internal class UpdateLoopDataSet<T> where T : class
	{
		private class cNUijmIoxrsGKsLlcRdduCKGgkcj
		{
			public readonly UpdateLoopType EtMuBRTmVzCBLcuxYRMlwUqRdAzD;

			public T mAGYPlguIQeCUGOuYjJmhKPdaLH;

			public cNUijmIoxrsGKsLlcRdduCKGgkcj(UpdateLoopType updateLoop)
			{
				EtMuBRTmVzCBLcuxYRMlwUqRdAzD = updateLoop;
			}
		}

		private const int wYiHKSsVMaGelwkKMBUUtOjdyCC = 0;

		private cNUijmIoxrsGKsLlcRdduCKGgkcj qOfFlvORgxdCnaFQBxveHhHymfyK;

		private int OlNDKUfTXODfsuYHoRqmBeyGOdJC;

		public readonly int fixedUpdateSetIndex = -1;

		private readonly int[] HVcadcjmFPZQDshVQEWqNcNuPjrx;

		private readonly cNUijmIoxrsGKsLlcRdduCKGgkcj[] GhZDISgmGOXECgBmhWKTlfRBgRzq;

		private UpdateLoopType MMIkLTLdHJREWkCxDcphixmQiUzm = (UpdateLoopType)(-1);

		public T Current => qOfFlvORgxdCnaFQBxveHhHymfyK.mAGYPlguIQeCUGOuYjJmhKPdaLH;

		public int Count => OlNDKUfTXODfsuYHoRqmBeyGOdJC;

		public T this[int index]
		{
			get
			{
				if (index < 0 || index >= OlNDKUfTXODfsuYHoRqmBeyGOdJC)
				{
					throw new IndexOutOfRangeException();
				}
				return GhZDISgmGOXECgBmhWKTlfRBgRzq[index].mAGYPlguIQeCUGOuYjJmhKPdaLH;
			}
			set
			{
				if (index < 0 || index >= OlNDKUfTXODfsuYHoRqmBeyGOdJC)
				{
					throw new IndexOutOfRangeException();
				}
				GhZDISgmGOXECgBmhWKTlfRBgRzq[index].mAGYPlguIQeCUGOuYjJmhKPdaLH = value;
			}
		}

		public UpdateLoopDataSet(UpdateLoopSetting updateLoops)
			: this(updateLoops, (Func<T>)null)
		{
		}

		public UpdateLoopDataSet(UpdateLoopSetting updateLoops, Func<T> instantiatorDelegate)
		{
			HVcadcjmFPZQDshVQEWqNcNuPjrx = new int[3];
			ArrayTools.Fill(HVcadcjmFPZQDshVQEWqNcNuPjrx, -1);
			List<cNUijmIoxrsGKsLlcRdduCKGgkcj> list = new List<cNUijmIoxrsGKsLlcRdduCKGgkcj>();
			int num = 0;
			using (TempListPool.TList<UpdateLoopType> tList = TempListPool.GetTList<UpdateLoopType>(3))
			{
				List<UpdateLoopType> list2 = tList.list;
				EnumConverter.ToUpdateLoopTypes(updateLoops, list2);
				for (int i = 0; i < list2.Count; i++)
				{
					cNUijmIoxrsGKsLlcRdduCKGgkcj cNUijmIoxrsGKsLlcRdduCKGgkcj = new cNUijmIoxrsGKsLlcRdduCKGgkcj(list2[i]);
					if (instantiatorDelegate != null)
					{
						T mAGYPlguIQeCUGOuYjJmhKPdaLH = instantiatorDelegate();
						cNUijmIoxrsGKsLlcRdduCKGgkcj.mAGYPlguIQeCUGOuYjJmhKPdaLH = mAGYPlguIQeCUGOuYjJmhKPdaLH;
					}
					list.Add(cNUijmIoxrsGKsLlcRdduCKGgkcj);
					HVcadcjmFPZQDshVQEWqNcNuPjrx[(int)list2[i]] = num;
					if (list2[i] == UpdateLoopType.FixedUpdate)
					{
						fixedUpdateSetIndex = num;
					}
					num++;
				}
			}
			GhZDISgmGOXECgBmhWKTlfRBgRzq = list.ToArray();
			OlNDKUfTXODfsuYHoRqmBeyGOdJC = GhZDISgmGOXECgBmhWKTlfRBgRzq.Length;
			SetUpdateLoop(GhZDISgmGOXECgBmhWKTlfRBgRzq[0].EtMuBRTmVzCBLcuxYRMlwUqRdAzD);
		}

		public void SetUpdateLoop(UpdateLoopType updateLoop)
		{
			if (MMIkLTLdHJREWkCxDcphixmQiUzm != updateLoop)
			{
				MMIkLTLdHJREWkCxDcphixmQiUzm = updateLoop;
				qOfFlvORgxdCnaFQBxveHhHymfyK = GhZDISgmGOXECgBmhWKTlfRBgRzq[HVcadcjmFPZQDshVQEWqNcNuPjrx[(int)updateLoop]];
			}
		}

		public T Get(int index)
		{
			if (index < 0 || index >= OlNDKUfTXODfsuYHoRqmBeyGOdJC)
			{
				throw new IndexOutOfRangeException();
			}
			return GhZDISgmGOXECgBmhWKTlfRBgRzq[index].mAGYPlguIQeCUGOuYjJmhKPdaLH;
		}

		public T Get(UpdateLoopType updateLoop)
		{
			return GhZDISgmGOXECgBmhWKTlfRBgRzq[HVcadcjmFPZQDshVQEWqNcNuPjrx[(int)updateLoop]].mAGYPlguIQeCUGOuYjJmhKPdaLH;
		}

		public void Set(int index, T item)
		{
			if (index < 0 || index >= OlNDKUfTXODfsuYHoRqmBeyGOdJC)
			{
				throw new IndexOutOfRangeException();
			}
			GhZDISgmGOXECgBmhWKTlfRBgRzq[index].mAGYPlguIQeCUGOuYjJmhKPdaLH = item;
		}

		public UpdateLoopType GetUpdateLoopType(int index)
		{
			if (index < 0 || index >= OlNDKUfTXODfsuYHoRqmBeyGOdJC)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return GhZDISgmGOXECgBmhWKTlfRBgRzq[index].EtMuBRTmVzCBLcuxYRMlwUqRdAzD;
		}
	}
}
