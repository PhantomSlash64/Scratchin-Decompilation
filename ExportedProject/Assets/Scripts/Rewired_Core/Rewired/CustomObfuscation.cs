using System;
using System.Runtime.InteropServices;

namespace Rewired
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
	[ComVisible(false)]
	internal sealed class CustomObfuscation : Attribute
	{
		public bool rename;
	}
}
