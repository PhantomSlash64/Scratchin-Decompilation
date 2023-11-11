namespace Rewired.Drivers.Interfaces
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	internal interface IControllerDriver
	{
		int AxisCount { get; }

		int ButtonCount { get; }

		int HatCount { get; }

		int AccelerometerCount { get; }

		int GyroscopeCount { get; }

		int TouchpadCount { get; }

		int LightCount { get; }

		int VibrationMotorCount { get; }
	}
}
