namespace Rewired.Platforms.PS4
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	internal interface IPS4ControllerSetExtensionSource : yQeUbDoGgKyVpbADuAvpvGwKHgS
	{
		int controllerCount { get; }

		IPS4ControllerExtensionSource GetController(int index);
	}
}
