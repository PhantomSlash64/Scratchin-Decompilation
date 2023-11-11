using Rewired.Utils.Classes.Data;

namespace Rewired.HID
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class HIDButton : HIDControllerElement
	{
		public bool rawValue;

		public double timestamp;

		public HIDButton(byte reportId, HIDInfo hidInfo)
			: base(reportId, hidInfo)
		{
		}

		public void SetValue(bool rawValue, double timestamp)
		{
			this.rawValue = rawValue;
			this.timestamp = timestamp;
		}

		public override void UpdateValue(NativeBuffer inputReport, double timestamp)
		{
			if (inputReport != null && inputReport[0] == reportId)
			{
				this.timestamp = timestamp;
			}
		}
	}
}
