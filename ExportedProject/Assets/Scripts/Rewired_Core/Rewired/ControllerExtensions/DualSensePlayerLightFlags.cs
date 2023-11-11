using System;

namespace Rewired.ControllerExtensions
{
	[Flags]
	public enum DualSensePlayerLightFlags : byte
	{
		None = 0,
		One = 1,
		Two = 2,
		Three = 4,
		Four = 8,
		Five = 0x10
	}
}
