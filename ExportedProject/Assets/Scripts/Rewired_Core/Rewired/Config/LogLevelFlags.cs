using System;

namespace Rewired.Config
{
	[Flags]
	public enum LogLevelFlags
	{
		Off = 0,
		Info = 1,
		Warning = 2,
		Error = 4,
		Debug = 8
	}
}
