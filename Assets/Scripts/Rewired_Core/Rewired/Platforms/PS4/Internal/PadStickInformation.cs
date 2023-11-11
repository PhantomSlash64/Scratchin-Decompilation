using System.ComponentModel;

namespace Rewired.Platforms.PS4.Internal
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public struct PadStickInformation
	{
		public byte deadZoneLeft;

		public byte deadZoneRight;
	}
}
