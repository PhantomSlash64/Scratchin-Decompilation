using System.ComponentModel;

namespace Rewired.Platforms.PS4.Internal
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public struct PadTouchPadInformation
	{
		public float pixelDensity;

		public ushort resolutionX;

		public ushort resolutionY;
	}
}
