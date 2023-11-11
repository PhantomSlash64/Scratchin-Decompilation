using Rewired.Utils.Classes.Data;

namespace Rewired.Data
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface IConfigVars_Internal
	{
		KeyedGetSetValueStore<string> values { get; }
	}
}
