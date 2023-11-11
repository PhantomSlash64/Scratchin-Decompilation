namespace Rewired.Utils.Interfaces
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal interface IAddValue<TValue>
	{
		void Add(TValue value);
	}
}
