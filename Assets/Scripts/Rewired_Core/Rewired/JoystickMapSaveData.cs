using System;

namespace Rewired
{
	public sealed class JoystickMapSaveData : ControllerMapSaveData
	{
		public Joystick joystick
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return _controller as Joystick;
			}
		}

		public JoystickMap joystickMap
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return _map as JoystickMap;
			}
		}

		public Guid joystickHardwareTypeGuid
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return Guid.Empty;
				}
				return joystick.hardwareTypeGuid;
			}
		}

		internal JoystickMapSaveData(Joystick joystick, JoystickMap map)
			: base(joystick, map)
		{
		}
	}
}
