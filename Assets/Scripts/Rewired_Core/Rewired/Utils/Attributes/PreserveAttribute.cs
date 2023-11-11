using System;

namespace Rewired.Utils.Attributes
{
	[CustomObfuscation(rename = false)]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	public class PreserveAttribute : Attribute
	{
	}
}
