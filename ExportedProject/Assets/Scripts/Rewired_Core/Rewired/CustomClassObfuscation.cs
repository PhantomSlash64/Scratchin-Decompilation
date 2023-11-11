using System;
using System.Runtime.InteropServices;

namespace Rewired
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface, AllowMultiple = false, Inherited = false)]
	[ComVisible(false)]
	internal sealed class CustomClassObfuscation : Attribute
	{
		public bool renamePubIntMembers;

		public bool renamePrivateMembers = true;
	}
}
