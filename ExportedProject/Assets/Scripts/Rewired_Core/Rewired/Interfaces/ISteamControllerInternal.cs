using System.Collections.Generic;
using Rewired.ControllerExtensions;
using UnityEngine;

namespace Rewired.Interfaces
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	[CustomObfuscation(rename = false)]
	internal interface ISteamControllerInternal
	{
		int MaxActionSourceCount { get; }

		bool IsConnected { get; }

		string GetActionSetName(ulong handle);

		string GetDigitalActionName(ulong handle);

		string GetAnalogActionName(ulong handle);

		ulong GetActionSetHandle(ref string actionSetName);

		ulong GetDigitalActionHandle(ref string actionName);

		ulong GetAnalogActionHandle(ref string actionName);

		bool GetDigitalActionValue(ulong actionHandle);

		bool GetDigitalActionValue(ref string actionName);

		Vector2 GetAnalogActionValue(ulong actionHandle);

		Vector2 GetAnalogActionValue(ref string actionName);

		bool SetActiveActionSet(ulong actionSetHandle);

		bool SetActiveActionSet(ref string actionSetName);

		ulong GetActiveActionSetHandle();

		string GetActiveActionSetName();

		void ShowBindingPanel();

		void SetHapticPulse(SteamControllerPadType targetPad, float durationSeconds);

		void SetHapticPulse(SteamControllerPadType targetPad, ushort durationMicroSeconds);

		IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ref string actionSetName, ref string actionName);

		IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ulong actionSetHandle, ulong actionHandle);

		IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ref string actionSetName, ref string actionName);

		IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ulong actionSetHandle, ulong actionHandle);
	}
}
