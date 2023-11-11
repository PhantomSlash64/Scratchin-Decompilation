using UnityEngine;

namespace Rewired.Utils
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal static class ExtensionMethods
	{
		public static bool IsNullOrDestroyed(this object @object)
		{
			if (!object.ReferenceEquals(@object, null))
			{
				if (@object is Object)
				{
					return (Object)@object == null;
				}
				return false;
			}
			return true;
		}
	}
}
