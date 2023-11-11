using System;

namespace Rewired
{
	[Flags]
	public enum ModifierKeyFlags
	{
		None = 0,
		LeftControl = 1,
		RightControl = 2,
		LeftAlt = 4,
		RightAlt = 8,
		LeftShift = 0x10,
		RightShift = 0x20,
		LeftCommand = 0x40,
		RightCommand = 0x80
	}
}
