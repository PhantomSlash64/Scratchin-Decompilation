using System;

namespace Rewired.Utils.Classes.Data
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class ExpandableArray_DataContainer<T> where T : class, ExpandableArray_DataContainer<T>.dCHFaZShTBabDEGADjARTEvjaeF, new()
	{
		public interface dCHFaZShTBabDEGADjARTEvjaeF : IComparable<T>
		{
			void BlEpJzKrARSmsemSZuRuhnNljiDf(T P_0);

			bool DgmbuafWJZMEqPkddeXpJOTtrvLd(T P_0);

			void LlCkzvOeJVaCziTDPktzBWuYotAZ();
		}

		public readonly T injector;

		private T[] HvKvadCgbnXngsjplWXUDmtVjkL;

		private int KoeqtTmBEgqebnpjhGHizlQsYtm;

		private int IJDFAjRFnvFQHazbBGEwYuuKPKIQ;

		private int UjnUbVEDCQLnZOeMFsCZYZuXjYo;

		private int ksQJQNYzMXcwZsoUDPYbdFBppLQ;

		private bool jZvTirclIKjxvJwHrrZkUAkSvNX;

		public int Count => KoeqtTmBEgqebnpjhGHizlQsYtm;

		public int Length => KoeqtTmBEgqebnpjhGHizlQsYtm;

		public int MaxLength => IJDFAjRFnvFQHazbBGEwYuuKPKIQ;

		public int FreeSpace => IJDFAjRFnvFQHazbBGEwYuuKPKIQ - KoeqtTmBEgqebnpjhGHizlQsYtm;

		public T this[int index]
		{
			get
			{
				if (index >= KoeqtTmBEgqebnpjhGHizlQsYtm)
				{
					throw new IndexOutOfRangeException();
				}
				return HvKvadCgbnXngsjplWXUDmtVjkL[index];
			}
		}

		public ExpandableArray_DataContainer(int startingMaxLength, bool clearData = true, int expansionIncrement = 0)
		{
			injector = new T();
			HvKvadCgbnXngsjplWXUDmtVjkL = new T[startingMaxLength];
			KoeqtTmBEgqebnpjhGHizlQsYtm = 0;
			IJDFAjRFnvFQHazbBGEwYuuKPKIQ = startingMaxLength;
			jZvTirclIKjxvJwHrrZkUAkSvNX = clearData;
			UjnUbVEDCQLnZOeMFsCZYZuXjYo = expansionIncrement;
			for (int i = 0; i < IJDFAjRFnvFQHazbBGEwYuuKPKIQ; i++)
			{
				HvKvadCgbnXngsjplWXUDmtVjkL[i] = new T();
			}
		}

		public int Inject()
		{
			int result = AddData(injector);
			if (jZvTirclIKjxvJwHrrZkUAkSvNX)
			{
				T val = injector;
				val.LlCkzvOeJVaCziTDPktzBWuYotAZ();
			}
			return result;
		}

		public int InjectIfUnique()
		{
			int result = AddIfUnique(injector);
			if (jZvTirclIKjxvJwHrrZkUAkSvNX)
			{
				T val = injector;
				val.LlCkzvOeJVaCziTDPktzBWuYotAZ();
			}
			return result;
		}

		public int AddData(T item)
		{
			if (KoeqtTmBEgqebnpjhGHizlQsYtm >= IJDFAjRFnvFQHazbBGEwYuuKPKIQ)
			{
				if (UjnUbVEDCQLnZOeMFsCZYZuXjYo <= 0)
				{
					return -1;
				}
				gTPAfewCVTtMcxQagOySgbSWvLj();
			}
			int koeqtTmBEgqebnpjhGHizlQsYtm = KoeqtTmBEgqebnpjhGHizlQsYtm;
			HvKvadCgbnXngsjplWXUDmtVjkL[koeqtTmBEgqebnpjhGHizlQsYtm].BlEpJzKrARSmsemSZuRuhnNljiDf(item);
			KoeqtTmBEgqebnpjhGHizlQsYtm = koeqtTmBEgqebnpjhGHizlQsYtm + 1;
			return koeqtTmBEgqebnpjhGHizlQsYtm;
		}

		public int AddIfUnique(T item)
		{
			int num = IndexOfData(item);
			if (num >= 0)
			{
				return num;
			}
			return AddData(item);
		}

		public bool ContainsData(T item)
		{
			for (int i = 0; i < KoeqtTmBEgqebnpjhGHizlQsYtm; i++)
			{
				if (HvKvadCgbnXngsjplWXUDmtVjkL[i].DgmbuafWJZMEqPkddeXpJOTtrvLd(item))
				{
					return true;
				}
			}
			return false;
		}

		public int IndexOfData(T item)
		{
			for (int i = 0; i < KoeqtTmBEgqebnpjhGHizlQsYtm; i++)
			{
				if (HvKvadCgbnXngsjplWXUDmtVjkL[i].DgmbuafWJZMEqPkddeXpJOTtrvLd(item))
				{
					return i;
				}
			}
			return -1;
		}

		public void Clear()
		{
			if (jZvTirclIKjxvJwHrrZkUAkSvNX)
			{
				T val = injector;
				val.LlCkzvOeJVaCziTDPktzBWuYotAZ();
				for (int i = 0; i < KoeqtTmBEgqebnpjhGHizlQsYtm; i++)
				{
					HvKvadCgbnXngsjplWXUDmtVjkL[i].LlCkzvOeJVaCziTDPktzBWuYotAZ();
				}
			}
			KoeqtTmBEgqebnpjhGHizlQsYtm = 0;
		}

		public void RemoveAt(int index)
		{
			if (index < 0 || index >= KoeqtTmBEgqebnpjhGHizlQsYtm)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			if (index == KoeqtTmBEgqebnpjhGHizlQsYtm - 1)
			{
				RemoveLast();
				return;
			}
			if (jZvTirclIKjxvJwHrrZkUAkSvNX)
			{
				HvKvadCgbnXngsjplWXUDmtVjkL[index].LlCkzvOeJVaCziTDPktzBWuYotAZ();
			}
			for (int i = index; i < KoeqtTmBEgqebnpjhGHizlQsYtm - 1; i++)
			{
				HvKvadCgbnXngsjplWXUDmtVjkL[i].BlEpJzKrARSmsemSZuRuhnNljiDf(HvKvadCgbnXngsjplWXUDmtVjkL[i + 1]);
			}
			if (jZvTirclIKjxvJwHrrZkUAkSvNX)
			{
				HvKvadCgbnXngsjplWXUDmtVjkL[KoeqtTmBEgqebnpjhGHizlQsYtm - 1].LlCkzvOeJVaCziTDPktzBWuYotAZ();
			}
			KoeqtTmBEgqebnpjhGHizlQsYtm--;
		}

		public void RemoveLast()
		{
			if (KoeqtTmBEgqebnpjhGHizlQsYtm != 0)
			{
				if (jZvTirclIKjxvJwHrrZkUAkSvNX)
				{
					HvKvadCgbnXngsjplWXUDmtVjkL[KoeqtTmBEgqebnpjhGHizlQsYtm - 1].LlCkzvOeJVaCziTDPktzBWuYotAZ();
				}
				KoeqtTmBEgqebnpjhGHizlQsYtm--;
			}
		}

		public void Resize(int size)
		{
			if (size <= 0)
			{
				throw new Exception("Size must be greater than 0.");
			}
			if (size == IJDFAjRFnvFQHazbBGEwYuuKPKIQ)
			{
				return;
			}
			T[] array = new T[size];
			int num = Math.Min(size, IJDFAjRFnvFQHazbBGEwYuuKPKIQ);
			for (int i = 0; i < num; i++)
			{
				array[i] = HvKvadCgbnXngsjplWXUDmtVjkL[i];
			}
			if (size > IJDFAjRFnvFQHazbBGEwYuuKPKIQ)
			{
				for (int j = num; j < size; j++)
				{
					array[j] = new T();
				}
			}
			else if (KoeqtTmBEgqebnpjhGHizlQsYtm > size)
			{
				KoeqtTmBEgqebnpjhGHizlQsYtm = size;
			}
			IJDFAjRFnvFQHazbBGEwYuuKPKIQ = size;
			HvKvadCgbnXngsjplWXUDmtVjkL = array;
		}

		public void SortAscending()
		{
			if (KoeqtTmBEgqebnpjhGHizlQsYtm == 0)
			{
				return;
			}
			for (int i = 0; i < KoeqtTmBEgqebnpjhGHizlQsYtm - 1; i++)
			{
				for (int j = i + 1; j < KoeqtTmBEgqebnpjhGHizlQsYtm; j++)
				{
					if (HvKvadCgbnXngsjplWXUDmtVjkL[j].CompareTo(HvKvadCgbnXngsjplWXUDmtVjkL[i]) < 0)
					{
						T val = HvKvadCgbnXngsjplWXUDmtVjkL[i];
						HvKvadCgbnXngsjplWXUDmtVjkL[i] = HvKvadCgbnXngsjplWXUDmtVjkL[j];
						HvKvadCgbnXngsjplWXUDmtVjkL[j] = val;
					}
				}
			}
		}

		public void SortDescending()
		{
			if (KoeqtTmBEgqebnpjhGHizlQsYtm == 0)
			{
				return;
			}
			for (int i = 0; i < KoeqtTmBEgqebnpjhGHizlQsYtm - 1; i++)
			{
				for (int j = i + 1; j < KoeqtTmBEgqebnpjhGHizlQsYtm; j++)
				{
					if (HvKvadCgbnXngsjplWXUDmtVjkL[j].CompareTo(HvKvadCgbnXngsjplWXUDmtVjkL[i]) > 0)
					{
						T val = HvKvadCgbnXngsjplWXUDmtVjkL[i];
						HvKvadCgbnXngsjplWXUDmtVjkL[i] = HvKvadCgbnXngsjplWXUDmtVjkL[j];
						HvKvadCgbnXngsjplWXUDmtVjkL[j] = val;
					}
				}
			}
		}

		private void gTPAfewCVTtMcxQagOySgbSWvLj()
		{
			ksQJQNYzMXcwZsoUDPYbdFBppLQ++;
			Resize(IJDFAjRFnvFQHazbBGEwYuuKPKIQ + ksQJQNYzMXcwZsoUDPYbdFBppLQ * UjnUbVEDCQLnZOeMFsCZYZuXjYo);
		}
	}
}
