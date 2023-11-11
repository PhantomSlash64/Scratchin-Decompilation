using System.ComponentModel;

namespace Rewired.Platforms.PS4.Internal
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public struct PadControllerInformation
	{
		public PadTouchPadInformation touchPadInfo;

		public PadStickInformation stickInfo;

		public byte connectionType;

		public byte connectedCount;

		public int connected;

		public int deviceClass;

		public byte reserve0;

		public byte reserve1;

		public byte reserve2;

		public byte reserve3;

		public byte reserve4;

		public byte reserve5;

		public byte reserve6;

		public byte reserve7;
	}
}
