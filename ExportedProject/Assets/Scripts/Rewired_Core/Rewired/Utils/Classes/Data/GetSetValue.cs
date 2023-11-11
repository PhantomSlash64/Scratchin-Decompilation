using System;
using Rewired.Utils.Interfaces;

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal sealed class GetSetValue<T> : IGetValue<T>, ISetValue<T>, IGetSetValue<T>
	{
		private Func<T> UlxWrVyfgMOLSZkugzZmBoaKGPJ;

		private Action<T> rIQsYHjLRilQeMsgoJardiCLpRu;

		public Func<T> getValueDelegate
		{
			get
			{
				return UlxWrVyfgMOLSZkugzZmBoaKGPJ;
			}
			set
			{
				UlxWrVyfgMOLSZkugzZmBoaKGPJ = value;
			}
		}

		public Action<T> setValueDelegate
		{
			get
			{
				return rIQsYHjLRilQeMsgoJardiCLpRu;
			}
			set
			{
				rIQsYHjLRilQeMsgoJardiCLpRu = value;
			}
		}

		public GetSetValue(Func<T> getValueDelegate, Action<T> setValueDelegate)
		{
			UlxWrVyfgMOLSZkugzZmBoaKGPJ = getValueDelegate;
			rIQsYHjLRilQeMsgoJardiCLpRu = setValueDelegate;
		}

		public T GetValue()
		{
			if (UlxWrVyfgMOLSZkugzZmBoaKGPJ == null)
			{
				throw new ArgumentNullException("getValueDelegate");
			}
			return UlxWrVyfgMOLSZkugzZmBoaKGPJ();
		}

		public void SetValue(T value)
		{
			if (rIQsYHjLRilQeMsgoJardiCLpRu == null)
			{
				throw new ArgumentNullException("setValueDelegate");
			}
			rIQsYHjLRilQeMsgoJardiCLpRu(value);
		}
	}
}
