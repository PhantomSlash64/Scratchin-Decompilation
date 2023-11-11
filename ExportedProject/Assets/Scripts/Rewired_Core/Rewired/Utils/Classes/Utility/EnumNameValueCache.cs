using System;
using Rewired.Utils.Classes.Data;

namespace Rewired.Utils.Classes.Utility
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal sealed class EnumNameValueCache<TEnum> where TEnum : struct, IComparable, IFormattable
	{
		private static EnumNameValueCache<TEnum> KinbtosjTwGONbtEYoxIaORPvTCY;

		private readonly ADictionary<string, TEnum> gBELeisoVGiNyubQEfwnigDnGTZe;

		private readonly string[] DEUvPjyHXNlEPnxYBuMraKQiFhH;

		private readonly long[] dMncOpKupTsyVgXhrsstruyovbjE;

		public static EnumNameValueCache<TEnum> Default => KinbtosjTwGONbtEYoxIaORPvTCY ?? (KinbtosjTwGONbtEYoxIaORPvTCY = new EnumNameValueCache<TEnum>());

		public int Count => dMncOpKupTsyVgXhrsstruyovbjE.Length;

		public static void Free()
		{
			KinbtosjTwGONbtEYoxIaORPvTCY = null;
		}

		private EnumNameValueCache()
		{
			Type typeFromHandle = typeof(TEnum);
			if (!EnumTools.IsEnum(typeFromHandle))
			{
				throw new Exception("enumType is not an enum type.");
			}
			Type underlyingEnumType = ReflectionTools.GetUnderlyingEnumType(typeFromHandle);
			DEUvPjyHXNlEPnxYBuMraKQiFhH = Enum.GetNames(typeFromHandle);
			TEnum[] array = (TEnum[])Enum.GetValues(typeFromHandle);
			gBELeisoVGiNyubQEfwnigDnGTZe = new ADictionary<string, TEnum>();
			dMncOpKupTsyVgXhrsstruyovbjE = new long[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				dMncOpKupTsyVgXhrsstruyovbjE[i] = MiscTools.ToLongUnchecked(Convert.ChangeType(array[i], underlyingEnumType));
				gBELeisoVGiNyubQEfwnigDnGTZe.Add(DEUvPjyHXNlEPnxYBuMraKQiFhH[i], array[i]);
			}
		}

		public TEnum GetValue(string name)
		{
			return gBELeisoVGiNyubQEfwnigDnGTZe[name];
		}

		public bool TryGetValue(string name, out TEnum value)
		{
			return gBELeisoVGiNyubQEfwnigDnGTZe.TryGetValue(name, out value);
		}

		public string GetName(long value)
		{
			int num = IndexOf(value);
			if (num < 0)
			{
				throw new Exception("The value does not exist in the enum.");
			}
			return DEUvPjyHXNlEPnxYBuMraKQiFhH[num];
		}

		public bool TryGetName(long value, out string name)
		{
			int num = IndexOf(value);
			if (num < 0)
			{
				name = string.Empty;
				return false;
			}
			name = DEUvPjyHXNlEPnxYBuMraKQiFhH[num];
			return true;
		}

		public TEnum GetValueAt(int index)
		{
			if ((uint)index >= (uint)dMncOpKupTsyVgXhrsstruyovbjE.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return gBELeisoVGiNyubQEfwnigDnGTZe[DEUvPjyHXNlEPnxYBuMraKQiFhH[index]];
		}

		public string GetNameAt(int index)
		{
			if ((uint)index >= (uint)dMncOpKupTsyVgXhrsstruyovbjE.Length)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			return DEUvPjyHXNlEPnxYBuMraKQiFhH[index];
		}

		public int IndexOf(string name)
		{
			return Array.IndexOf(DEUvPjyHXNlEPnxYBuMraKQiFhH, name);
		}

		public int IndexOf(long value)
		{
			return Array.IndexOf(dMncOpKupTsyVgXhrsstruyovbjE, value);
		}

		public bool Contains(string name)
		{
			return gBELeisoVGiNyubQEfwnigDnGTZe.ContainsKey(name);
		}

		public bool Contains(long value)
		{
			return IndexOf(value) >= 0;
		}
	}
}
