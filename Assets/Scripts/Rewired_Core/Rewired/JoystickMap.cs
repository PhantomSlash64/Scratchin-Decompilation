using System;

namespace Rewired
{
	public sealed class JoystickMap : ControllerMapWithAxes
	{
		public JoystickMap()
		{
		}

		public JoystickMap(JoystickMap joystickMap)
			: base(joystickMap)
		{
		}

		internal void VHccjfEMNntOyUjHbKfsjtKQWZf(Guid P_0, int P_1, int P_2)
		{
			_hardwareGuid = P_0;
			_categoryId = P_1;
			_layoutId = P_2;
		}

		internal static JoystickMap EOKwQcxsIwIbTLRXRRCTTzrEDPK(Guid P_0, int P_1, int P_2)
		{
			JoystickMap joystickMap = new JoystickMap();
			joystickMap._hardwareGuid = P_0;
			joystickMap._categoryId = P_1;
			joystickMap._layoutId = P_2;
			joystickMap._sourceMapId = -1;
			return joystickMap;
		}
	}
}
