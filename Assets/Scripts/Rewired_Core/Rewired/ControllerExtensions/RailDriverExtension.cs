using Rewired.Drivers.Interfaces;
using Rewired.Interfaces;

namespace Rewired.ControllerExtensions
{
	public sealed class RailDriverExtension : Controller.Extension
	{
		private class kfslXrUGNhanitSUUtGlIYZdoL : IControllerExtensionSource
		{
			public readonly IDriver_RailDriver HXdrpIalcqAYpAuAIDhnqyeoHAg;

			public kfslXrUGNhanitSUUtGlIYZdoL(IDriver_RailDriver driver)
			{
				HXdrpIalcqAYpAuAIDhnqyeoHAg = driver;
			}
		}

		private kfslXrUGNhanitSUUtGlIYZdoL eEGdvsHFSoebDZTJoammOSBqiFV;

		private Joystick joystick => GetController<Joystick>();

		public bool speakerEnabled
		{
			get
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
					return false;
				}
				if (eEGdvsHFSoebDZTJoammOSBqiFV.HXdrpIalcqAYpAuAIDhnqyeoHAg == null)
				{
					return false;
				}
				return eEGdvsHFSoebDZTJoammOSBqiFV.HXdrpIalcqAYpAuAIDhnqyeoHAg.SpeakerEnabled;
			}
			set
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
				}
				else if (eEGdvsHFSoebDZTJoammOSBqiFV.HXdrpIalcqAYpAuAIDhnqyeoHAg != null)
				{
					eEGdvsHFSoebDZTJoammOSBqiFV.HXdrpIalcqAYpAuAIDhnqyeoHAg.SpeakerEnabled = value;
				}
			}
		}

		internal RailDriverExtension(IDriver_RailDriver driver)
			: base(new kfslXrUGNhanitSUUtGlIYZdoL(driver))
		{
		}

		private RailDriverExtension(RailDriverExtension source)
			: base(source)
		{
		}

		public void SetLEDDisplay(int digitIndex, byte digitBitValues)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else if (eEGdvsHFSoebDZTJoammOSBqiFV.HXdrpIalcqAYpAuAIDhnqyeoHAg != null && base.enabled)
			{
				eEGdvsHFSoebDZTJoammOSBqiFV.HXdrpIalcqAYpAuAIDhnqyeoHAg.SetLEDDisplay(digitIndex, digitBitValues);
			}
		}

		public void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else if (eEGdvsHFSoebDZTJoammOSBqiFV.HXdrpIalcqAYpAuAIDhnqyeoHAg != null && base.enabled)
			{
				eEGdvsHFSoebDZTJoammOSBqiFV.HXdrpIalcqAYpAuAIDhnqyeoHAg.SetLEDDisplay(digit1BitValues, digit2BitValues, digit3BitValues);
			}
		}

		internal void MlEQHREVxHLTuUCANSxPMEKvYTk(UpdateLoopType P_0)
		{
		}

		internal void RpeYzeyVaxOdApEhVGfVRjeBofC(IControllerExtensionSource P_0)
		{
			eEGdvsHFSoebDZTJoammOSBqiFV = P_0 as kfslXrUGNhanitSUUtGlIYZdoL;
		}

		internal Controller.Extension krDHfhzemQsdElTTOFwBBCKPvNI()
		{
			return new RailDriverExtension(this);
		}
	}
}
