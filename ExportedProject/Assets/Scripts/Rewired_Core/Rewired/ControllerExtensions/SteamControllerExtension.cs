using System.Collections.Generic;
using Rewired.Interfaces;
using Rewired.Utils;
using UnityEngine;

namespace Rewired.ControllerExtensions
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class SteamControllerExtension : Controller.Extension
	{
		private class maMlbwHtLdEBVCwsuDOPISenCYd : IControllerExtensionSource
		{
			public readonly ISteamControllerInternal zVVIHmTkphrvFwRyTabUsqVzASa;

			public maMlbwHtLdEBVCwsuDOPISenCYd(ISteamControllerInternal internalController)
			{
				zVVIHmTkphrvFwRyTabUsqVzASa = internalController;
			}
		}

		private maMlbwHtLdEBVCwsuDOPISenCYd eEGdvsHFSoebDZTJoammOSBqiFV;

		private Joystick joystick => GetController<Joystick>();

		internal ISteamControllerInternal internalController => eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa;

		internal SteamControllerExtension(ISteamControllerInternal internalController)
			: base(new maMlbwHtLdEBVCwsuDOPISenCYd(internalController))
		{
			ijQPrfbohIDtyfCSvLMVhrlmSpB();
		}

		private SteamControllerExtension(SteamControllerExtension source)
			: base(source)
		{
			ijQPrfbohIDtyfCSvLMVhrlmSpB();
		}

		public ulong GetActionSetHandle(string actionSetName)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return 0uL;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.GetActionSetHandle(ref actionSetName);
		}

		public ulong GetAnalogActionHandle(string actionName)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return 0uL;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.GetAnalogActionHandle(ref actionName);
		}

		public ulong GetDigitalActionHandle(string actionName)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return 0uL;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.GetDigitalActionHandle(ref actionName);
		}

		public string GetActionSetName(ulong actionSetHandle)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return string.Empty;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.GetActionSetName(actionSetHandle);
		}

		public string GetAnalogActionName(ulong actionHandle)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return string.Empty;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.GetAnalogActionName(actionHandle);
		}

		public string GetDigitalActionName(ulong actionHandle)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return string.Empty;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.GetDigitalActionName(actionHandle);
		}

		public Vector2 GetAnalogActionValue(string actionName)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return Vector2.zero;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.GetAnalogActionValue(ref actionName);
		}

		public Vector2 GetAnalogActionValue(ulong actionHandle)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return Vector2.zero;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.GetAnalogActionValue(actionHandle);
		}

		public bool GetDigitalActionValue(string actionName)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return false;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.GetDigitalActionValue(ref actionName);
		}

		public bool GetDigitalActionValue(ulong actionHandle)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return false;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.GetDigitalActionValue(actionHandle);
		}

		public bool SetActiveActionSet(ulong actionSetHandle)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return false;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.SetActiveActionSet(actionSetHandle);
		}

		public bool SetActiveActionSet(string actionSetName)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return false;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.SetActiveActionSet(ref actionSetName);
		}

		public ulong GetActiveActionSetHandle()
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return 0uL;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.GetActiveActionSetHandle();
		}

		public string GetActiveActionSetName()
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return string.Empty;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.GetActiveActionSetName();
		}

		public void ShowBindingPanel()
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else
			{
				eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.ShowBindingPanel();
			}
		}

		public void SetHapticPulse(SteamControllerPadType targePad, float durationSeconds)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else
			{
				eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.SetHapticPulse(targePad, durationSeconds);
			}
		}

		public void SetHapticPulse(SteamControllerPadType targePad, ushort durationMicroSeconds)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else
			{
				eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.SetHapticPulse(targePad, durationMicroSeconds);
			}
		}

		public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(string actionSetName, string actionName)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return EmptyObjects<SteamControllerActionOrigin>.EmptyReadOnlyIListT;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.GetDigitalActionOrigins(ref actionSetName, ref actionName);
		}

		public IList<SteamControllerActionOrigin> GetDigitalActionOrigins(ulong actionSetHandle, ulong actionHandle)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return EmptyObjects<SteamControllerActionOrigin>.EmptyReadOnlyIListT;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.GetDigitalActionOrigins(actionSetHandle, actionHandle);
		}

		public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(string actionSetName, string actionName)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return EmptyObjects<SteamControllerActionOrigin>.EmptyReadOnlyIListT;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.GetAnalogActionOrigins(ref actionSetName, ref actionName);
		}

		public IList<SteamControllerActionOrigin> GetAnalogActionOrigins(ulong actionSetHandle, ulong actionHandle)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return EmptyObjects<SteamControllerActionOrigin>.EmptyReadOnlyIListT;
			}
			return eEGdvsHFSoebDZTJoammOSBqiFV.zVVIHmTkphrvFwRyTabUsqVzASa.GetAnalogActionOrigins(actionSetHandle, actionHandle);
		}

		internal override void UpdateData(UpdateLoopType updateLoop)
		{
		}

		internal override void SourceUpdated(IControllerExtensionSource source)
		{
			eEGdvsHFSoebDZTJoammOSBqiFV = source as maMlbwHtLdEBVCwsuDOPISenCYd;
		}

		internal override Controller.Extension Clone()
		{
			return new SteamControllerExtension(this);
		}

		private void ijQPrfbohIDtyfCSvLMVhrlmSpB()
		{
		}
	}
}
