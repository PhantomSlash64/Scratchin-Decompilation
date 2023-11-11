using UnityEngine;

namespace Rewired.Platforms.PS4
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	internal interface IPS4ControllerExtensionSourceSixAxisSensor
	{
		void SetMotionSensorState(bool enabled);

		void SetTiltCorrectionState(bool enabled);

		void SetAngularVelocityDeadbandState(bool enabled);

		void ResetOrientation();

		Vector3 GetLastAcceleration();

		Vector3 GetLastAccelerationRaw();

		Vector3 GetLastGyro();

		Vector3 GetLastGyroRaw();

		Quaternion GetLastOrientation();

		Quaternion GetLastOrientationRaw();
	}
}
