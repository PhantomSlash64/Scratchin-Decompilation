using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Rewired.Utils
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class EnumValueHelper<TEnum>
	{
		private static EnumValueHelper<TEnum> jSlMHYpliVFUzTfJqvhklMtlwTN;

		private TEnum[] CZFRtBCUTwsgoIUOeTOEpgxMkqp;

		private ReadOnlyCollection<TEnum> aMkVummVkGLByHSnmrAdfazzVpq;

		private string[] uaGEgJaPGnnIACsmFThKulzCQmwH;

		private ReadOnlyCollection<string> czDbeMjAAxfScMfGoPHlcPZLwqPD;

		public static EnumValueHelper<TEnum> Default => jSlMHYpliVFUzTfJqvhklMtlwTN ?? (jSlMHYpliVFUzTfJqvhklMtlwTN = new EnumValueHelper<TEnum>());

		public IList<TEnum> values => aMkVummVkGLByHSnmrAdfazzVpq;

		public IList<string> names
		{
			get
			{
				if (czDbeMjAAxfScMfGoPHlcPZLwqPD == null)
				{
					uaGEgJaPGnnIACsmFThKulzCQmwH = Enum.GetNames(typeof(TEnum));
					czDbeMjAAxfScMfGoPHlcPZLwqPD = new ReadOnlyCollection<string>(uaGEgJaPGnnIACsmFThKulzCQmwH);
				}
				return czDbeMjAAxfScMfGoPHlcPZLwqPD;
			}
		}

		public EnumValueHelper()
		{
			if (!EnumTools.IsEnum(typeof(TEnum)))
			{
				throw new ArgumentException("TEnum must be an enum type.");
			}
			CZFRtBCUTwsgoIUOeTOEpgxMkqp = (TEnum[])Enum.GetValues(typeof(TEnum));
			aMkVummVkGLByHSnmrAdfazzVpq = new ReadOnlyCollection<TEnum>(CZFRtBCUTwsgoIUOeTOEpgxMkqp);
		}
	}
}
