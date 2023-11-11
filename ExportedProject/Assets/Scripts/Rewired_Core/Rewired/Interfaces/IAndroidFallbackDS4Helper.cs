namespace Rewired.Interfaces
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	internal interface IAndroidFallbackDS4Helper
	{
		bool IsDS4KeyMapped(int unityJoystickArrayIndex);

		bool IsDS4(string name);
	}
}
