using System;

namespace Rewired.Interfaces
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	[CustomObfuscation(rename = false)]
	internal interface IAndroidFallbackPlatformHelper
	{
		IAndroidFallbackDS4Helper ds4Helper { get; }

		event Action DeviceChangedEvent;

		string GetUniqueDeviceIdentifier(string unityJoystickName, int unityArrayIndex);
	}
}
