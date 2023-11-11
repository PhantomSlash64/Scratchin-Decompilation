using System.ComponentModel;

namespace Rewired.Platforms
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public enum WebplayerPlatform
	{
		None = 0,
		Windows = 1,
		OSX = 2,
		Unknown = 100
	}
}
