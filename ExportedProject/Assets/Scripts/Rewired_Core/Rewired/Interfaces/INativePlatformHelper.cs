namespace Rewired.Interfaces
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface INativePlatformHelper
	{
		bool isApplicationFocused { get; }
	}
}
