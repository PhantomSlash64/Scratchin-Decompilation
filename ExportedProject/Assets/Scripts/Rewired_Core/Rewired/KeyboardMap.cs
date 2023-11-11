using System;

namespace Rewired
{
	public sealed class KeyboardMap : ControllerMap
	{
		public KeyboardMap()
		{
		}

		public KeyboardMap(KeyboardMap keyboardMap)
			: base(keyboardMap)
		{
		}

		internal void VHccjfEMNntOyUjHbKfsjtKQWZf(Guid P_0, int P_1, int P_2)
		{
			_hardwareGuid = P_0;
			_categoryId = P_1;
			_layoutId = P_2;
		}

		internal static KeyboardMap EOKwQcxsIwIbTLRXRRCTTzrEDPK(Guid P_0, int P_1, int P_2)
		{
			KeyboardMap keyboardMap = new KeyboardMap();
			keyboardMap._hardwareGuid = P_0;
			keyboardMap._categoryId = P_1;
			keyboardMap._layoutId = P_2;
			keyboardMap._sourceMapId = -1;
			return keyboardMap;
		}
	}
}
