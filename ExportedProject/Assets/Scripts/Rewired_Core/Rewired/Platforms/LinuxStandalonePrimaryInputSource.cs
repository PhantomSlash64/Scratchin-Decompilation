using System.ComponentModel;

namespace Rewired.Platforms
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public enum LinuxStandalonePrimaryInputSource
	{
		Native = 0,
		SDL2 = 10,
		Unity = 100
	}
}
