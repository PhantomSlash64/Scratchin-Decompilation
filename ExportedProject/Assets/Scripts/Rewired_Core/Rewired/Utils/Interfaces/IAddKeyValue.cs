namespace Rewired.Utils.Interfaces
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface IAddKeyValue<TKey, TValue>
	{
		void Add(TKey key, TValue value);
	}
}
