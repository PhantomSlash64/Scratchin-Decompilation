using System.ComponentModel;

namespace Rewired.Platforms
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public enum EditorPlatform
	{
		None = 0,
		OSX = 1,
		Windows = 2,
		Linux = 3,
		Unknown = 100
	}
}
