using Rewired.Interfaces;
using UnityEngine;

namespace Rewired.ControllerExtensions
{
	public interface IDualShock4Extension : IControllerVibrator
	{
		int maxTouches { get; }

		int touchCount { get; }

		Vector3 GetAccelerometerValue();

		Vector3 GetAccelerometerValueRaw();

		Vector3 GetGyroscopeValueRaw();

		Vector3 GetGyroscopeValue();

		Quaternion GetOrientation();

		void ResetOrientation();

		void SetLightColor(Color color);

		void SetLightColor(float red, float green, float blue);

		void SetLightColor(float red, float green, float blue, float intensity);

		int GetTouchId(int index);

		bool GetTouchPosition(int index, out Vector2 position);

		bool GetTouchPositionByTouchId(int touchId, out Vector2 position);

		bool IsTouching(int index);

		bool IsTouchingByTouchId(int touchId);

		void SetVibration(float leftMotorLevel, float rightMotorLevel);

		void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration);
	}
}
