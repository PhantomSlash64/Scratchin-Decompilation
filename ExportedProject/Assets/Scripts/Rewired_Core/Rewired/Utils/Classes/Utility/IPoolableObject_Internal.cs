using System;
using Rewired.Interfaces;

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface IPoolableObject_Internal : IDisposable, IPoolableObject
	{
		IObjectPool pool { get; set; }

		void Clear();
	}
}
