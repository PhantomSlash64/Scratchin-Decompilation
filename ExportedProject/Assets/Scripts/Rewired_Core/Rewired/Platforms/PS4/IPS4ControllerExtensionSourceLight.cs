namespace Rewired.Platforms.PS4
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface IPS4ControllerExtensionSourceLight
	{
		void SetLightColor(int red, int green, int blue);

		void ResetLight();
	}
}
