using UnityEngine;

namespace Rewired.Drivers.Interfaces
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	internal interface IDriver_DualShock4 : IControllerDriver
	{
		float BatteryLevel { get; }

		float LeftMotor { get; set; }

		float RightMotor { get; set; }

		float LightColorR { get; set; }

		float LightColorG { get; set; }

		float LightColorB { get; set; }

		float LightFlashOnDuration { get; set; }

		float LightFlashOffDuration { get; set; }

		Vector3 AccelerometerValue { get; }

		Vector3 AccelerometerValueRaw { get; }

		Vector3 GyroscopeValue { get; }

		Vector3 GyroscopeValueRaw { get; }

		Vector3 LastGyroscopeValue { get; }

		Vector3 LastGyroscopeValueRaw { get; }

		Quaternion Orientation { get; }

		int MaxTouches { get; }

		void ResetOrientation();

		int GetTouchCount();

		bool IsTouchingAtTouchId(int touchId);

		bool IsTouchingAtIndex(int index);

		int GetTouchIdAtIndex(int index);

		bool GetTouchPositionByIndex(int index, out Vector2 position);

		bool GetTouchPositionByTouchId(int touchId, out Vector2 position);

		bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY);

		bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY);

		void StopLightFlash();

		void StopVibration();
	}
}
