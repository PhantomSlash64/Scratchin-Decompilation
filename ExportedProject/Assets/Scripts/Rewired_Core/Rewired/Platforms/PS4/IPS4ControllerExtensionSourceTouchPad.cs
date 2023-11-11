using UnityEngine;

namespace Rewired.Platforms.PS4
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	internal interface IPS4ControllerExtensionSourceTouchPad
	{
		int maxTouches { get; }

		float GetTouchPixelDensity();

		int GetTouchpadResolutionX();

		int GetTouchpadResolutionY();

		int GetTouchCount();

		int GetTouchId(int index);

		bool GetTouchPositionByIndex(int index, out Vector2 position);

		bool GetTouchPositionAbsByIndex(int index, out Vector2 position);

		bool GetTouchPositionByTouchId(int touchId, out Vector2 position);

		bool GetTouchPositionAbsByTouchId(int touchId, out Vector2 position);

		bool IsTouchingByIndex(int index);

		bool IsTouchingByTouchId(int touchId);
	}
}
