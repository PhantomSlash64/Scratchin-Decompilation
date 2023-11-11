using System.ComponentModel;

namespace Rewired.Platforms.PS4.Internal
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class ControllerInformation
	{
		public PadControllerInformation padControllerInformation;

		public PadDeviceClassExtendedInformation padDeviceClassExtendedInformation;
	}
}
