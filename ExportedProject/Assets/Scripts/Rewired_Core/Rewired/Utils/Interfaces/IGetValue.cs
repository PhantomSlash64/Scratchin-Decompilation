namespace Rewired.Utils.Interfaces
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal interface IGetValue<T>
	{
		T GetValue();
	}
}
