namespace Rewired
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	internal class SteamAction
	{
		public readonly string name;

		public readonly ulong handle;

		public SteamAction(string name, ulong handle)
		{
			this.name = name;
			this.handle = handle;
		}
	}
}
