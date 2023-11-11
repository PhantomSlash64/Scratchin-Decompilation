using System.ComponentModel;

namespace Rewired.Platforms
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public enum WindowsStandalonePrimaryInputSource
	{
		RawInput = 0,
		DirectInput = 1,
		XInput = 2,
		SDL2 = 10,
		Unity = 100
	}
}
