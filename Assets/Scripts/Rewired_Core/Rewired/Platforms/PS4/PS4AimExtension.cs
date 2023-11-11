namespace Rewired.Platforms.PS4
{
	public sealed class PS4AimExtension : PS4ControllerExtension
	{
		private IPS4AimExtensionSource Source => (GetSource() as sXNLeeixPMqJPUtZBdXDdAalhIfh).eEGdvsHFSoebDZTJoammOSBqiFV as IPS4AimExtensionSource;

		internal PS4AimExtension(IPS4AimExtensionSource source)
			: base(source)
		{
		}

		private PS4AimExtension(PS4AimExtension source)
			: base(source)
		{
		}

		public float GetVibration(PS4AimMotorType motor)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return 0f;
			}
			return GetVibration(gPmJOyJHjcjJwFWeEntNkEmUiFo(motor));
		}

		public void SetVibration(PS4AimMotorType motor, float motorLevel)
		{
			SetVibration(motor, motorLevel, 0f, stopOtherMotors: false);
		}

		public void SetVibration(PS4AimMotorType motor, float motorLevel, bool stopOtherMotors)
		{
			SetVibration(motor, motorLevel, 0f, stopOtherMotors);
		}

		public void SetVibration(PS4AimMotorType motor, float motorLevel, float duration, bool stopOtherMotors)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else
			{
				SetVibration(gPmJOyJHjcjJwFWeEntNkEmUiFo(motor), motorLevel, duration, stopOtherMotors);
			}
		}

		public void SetVibration(float strongMotorLevel, float weakMotorLevel)
		{
			SetVibration(strongMotorLevel, weakMotorLevel, 0f, 0f);
		}

		public void SetVibration(float strongMotorLevel, float weakMotorLevel, float strongMotorDuration, float weakMotorDuration)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return;
			}
			SetVibration(gPmJOyJHjcjJwFWeEntNkEmUiFo(PS4AimMotorType.StrongMotor), strongMotorLevel, strongMotorDuration, stopOtherMotors: false);
			SetVibration(gPmJOyJHjcjJwFWeEntNkEmUiFo(PS4AimMotorType.WeakMotor), weakMotorLevel, weakMotorDuration, stopOtherMotors: false);
		}

		internal override Controller.Extension krDHfhzemQsdElTTOFwBBCKPvNI()
		{
			return new PS4AimExtension(this);
		}

		private static int gPmJOyJHjcjJwFWeEntNkEmUiFo(PS4AimMotorType P_0)
		{
			return (int)P_0;
		}
	}
}
