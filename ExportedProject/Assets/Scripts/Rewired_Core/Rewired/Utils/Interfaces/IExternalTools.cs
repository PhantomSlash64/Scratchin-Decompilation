using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rewired.Utils.Interfaces
{
	public interface IExternalTools
	{
		bool isEditorPaused { get; }

		bool UnityInput_IsTouchPressureSupported { get; }

		event Action<bool> EditorPausedStateChangedEvent;

		event Action<uint, bool> XboxOneInput_OnGamepadStateChange;

		void Destroy();

		object GetPlatformInitializer();

		string GetFocusedEditorWindowTitle();

		bool IsEditorSceneViewFocused();

		bool LinuxInput_IsJoystickPreconfigured(string name);

		int XboxOneInput_GetUserIdForGamepad(uint id);

		ulong XboxOneInput_GetControllerId(uint unityJoystickId);

		bool XboxOneInput_IsGamepadActive(uint unityJoystickId);

		string XboxOneInput_GetControllerType(ulong xboxControllerId);

		uint XboxOneInput_GetJoystickId(ulong xboxControllerId);

		void XboxOne_Gamepad_UpdatePlugin();

		bool XboxOne_Gamepad_SetGamepadVibration(ulong xboxOneJoystickId, float leftMotor, float rightMotor, float leftTriggerLevel, float rightTriggerLevel);

		void XboxOne_Gamepad_PulseVibrateMotor(ulong xboxOneJoystickId, int motor, float startLevel, float endLevel, ulong durationMS);

		Vector3 PS4Input_GetLastAcceleration(int id);

		Vector3 PS4Input_GetLastGyro(int id);

		Vector4 PS4Input_GetLastOrientation(int id);

		void PS4Input_GetLastTouchData(int id, out int touchNum, out int touch0x, out int touch0y, out int touch0id, out int touch1x, out int touch1y, out int touch1id);

		void PS4Input_GetPadControllerInformation(int id, out float touchpixelDensity, out int touchResolutionX, out int touchResolutionY, out int analogDeadZoneLeft, out int analogDeadZoneright, out int connectionType);

		void PS4Input_PadSetMotionSensorState(int id, bool bEnable);

		void PS4Input_PadSetTiltCorrectionState(int id, bool bEnable);

		void PS4Input_PadSetAngularVelocityDeadbandState(int id, bool bEnable);

		void PS4Input_PadSetLightBar(int id, int red, int green, int blue);

		void PS4Input_PadResetLightBar(int id);

		void PS4Input_PadSetVibration(int id, int largeMotor, int smallMotor);

		void PS4Input_PadResetOrientation(int id);

		bool PS4Input_PadIsConnected(int id);

		void PS4Input_GetUsersDetails(int slot, object loggedInUser);

		int PS4Input_GetDeviceClassForHandle(int handle);

		string PS4Input_GetDeviceClassString(int intValue);

		int PS4Input_PadGetUsersHandles2(int maxControllers, int[] handles);

		void PS4Input_GetSpecialControllerInformation(int id, int padIndex, object controllerInformation);

		Vector3 PS4Input_SpecialGetLastAcceleration(int id);

		Vector3 PS4Input_SpecialGetLastGyro(int id);

		Vector4 PS4Input_SpecialGetLastOrientation(int id);

		int PS4Input_SpecialGetUsersHandles(int maxNumberControllers, int[] handles);

		int PS4Input_SpecialGetUsersHandles2(int maxNumberControllers, int[] handles);

		bool PS4Input_SpecialIsConnected(int id);

		void PS4Input_SpecialResetLightSphere(int id);

		void PS4Input_SpecialResetOrientation(int id);

		void PS4Input_SpecialSetAngularVelocityDeadbandState(int id, bool bEnable);

		void PS4Input_SpecialSetLightSphere(int id, int red, int green, int blue);

		void PS4Input_SpecialSetMotionSensorState(int id, bool bEnable);

		void PS4Input_SpecialSetTiltCorrectionState(int id, bool bEnable);

		void PS4Input_SpecialSetVibration(int id, int largeMotor, int smallMotor);

		Vector3 PS4Input_AimGetLastAcceleration(int id);

		Vector3 PS4Input_AimGetLastGyro(int id);

		Vector4 PS4Input_AimGetLastOrientation(int id);

		int PS4Input_AimGetUsersHandles(int maxNumberControllers, int[] handles);

		int PS4Input_AimGetUsersHandles2(int maxNumberControllers, int[] handles);

		bool PS4Input_AimIsConnected(int id);

		void PS4Input_AimResetLightSphere(int id);

		void PS4Input_AimResetOrientation(int id);

		void PS4Input_AimSetAngularVelocityDeadbandState(int id, bool bEnable);

		void PS4Input_AimSetLightSphere(int id, int red, int green, int blue);

		void PS4Input_AimSetMotionSensorState(int id, bool bEnable);

		void PS4Input_AimSetTiltCorrectionState(int id, bool bEnable);

		void PS4Input_AimSetVibration(int id, int largeMotor, int smallMotor);

		Vector3 PS4Input_GetLastMoveAcceleration(int id, int index);

		Vector3 PS4Input_GetLastMoveGyro(int id, int index);

		int PS4Input_MoveGetButtons(int id, int index);

		int PS4Input_MoveGetAnalogButton(int id, int index);

		bool PS4Input_MoveIsConnected(int id, int index);

		int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles, int[] secondaryHandles);

		int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers, int[] primaryHandles);

		int PS4Input_MoveGetUsersMoveHandles(int maxNumberControllers);

		IntPtr PS4Input_MoveGetControllerInputForTracking();

		int PS4Input_MoveSetLightSphere(int id, int index, int red, int green, int blue);

		int PS4Input_MoveSetVibration(int id, int index, int motor);

		void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids);

		int GetAndroidAPILevel();

		bool UnityUI_Graphic_GetRaycastTarget(object graphic);

		void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value);

		float UnityInput_GetTouchPressure(ref Touch touch);

		float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch);

		IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload);

		Type[] GetControllerTemplateTypes();

		Type[] GetControllerTemplateInterfaceTypes();
	}
}
