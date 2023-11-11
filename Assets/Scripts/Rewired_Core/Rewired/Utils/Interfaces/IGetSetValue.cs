namespace Rewired.Utils.Interfaces
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface IGetSetValue<T> : IGetValue<T>, ISetValue<T>
	{
	}
}
