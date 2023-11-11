namespace Rewired.Platforms.PS4
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface IPS4ControllerExtensionSourceVibrator
	{
		bool supportsVibration { get; }

		int vibrationMotorCount { get; }

		void SetVibration(int motorIndex, float value);

		float GetVibration(int motorIndex);

		void StopVibration();
	}
}
