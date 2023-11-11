using System;

namespace Rewired.Utils.Classes.Utility
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal struct SetAndRestoreVar<T> : IDisposable
	{
		private readonly Action<T> rIQsYHjLRilQeMsgoJardiCLpRu;

		private readonly T rBByKsGOxSjQxRIreVKEBJwvsY;

		public SetAndRestoreVar(T oldValue, T newValue, Action<T> setValueDelegate)
		{
			if (setValueDelegate == null)
			{
				throw new ArgumentNullException("setValueDelegate");
			}
			rIQsYHjLRilQeMsgoJardiCLpRu = setValueDelegate;
			rBByKsGOxSjQxRIreVKEBJwvsY = oldValue;
			setValueDelegate(newValue);
		}

		public void Dispose()
		{
			rIQsYHjLRilQeMsgoJardiCLpRu(rBByKsGOxSjQxRIreVKEBJwvsY);
		}
	}
}
