using System.ComponentModel;

namespace Rewired.Platforms.PS4.Internal
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public struct PadDeviceClassExtendedInformation
	{
		public int deviceClass;

		public int reserved;

		public byte capability;

		public byte quantityOfSelectorSwitch;

		public ushort maxPhysicalWheelAngle;
	}
}
