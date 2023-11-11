using System;

namespace Rewired.Config
{
	[Flags]
	public enum UpdateLoopSetting
	{
		None = 0,
		Update = 1,
		FixedUpdate = 2,
		OnGUI = 4
	}
}
