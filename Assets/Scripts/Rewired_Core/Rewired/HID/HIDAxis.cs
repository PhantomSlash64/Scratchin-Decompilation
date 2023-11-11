using Rewired.Utils.Classes.Data;

namespace Rewired.HID
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class HIDAxis : HIDControllerElement
	{
		public int rawValue;

		public double timestamp;

		public readonly int byteLength;

		public readonly int startIndex;

		public readonly bool isSigned;

		public readonly int minValue;

		public readonly int maxValue;

		public readonly int zeroValue;

		public HIDAxis(byte reportId, HIDInfo hidInfo, bool isSigned, int zeroValue)
			: base(reportId, hidInfo)
		{
			byteLength = ((hidInfo.bitSize > 0) ? ((hidInfo.bitSize + 8 - 1) / 8) : 0);
			startIndex = hidInfo.dataIndex;
			this.isSigned = isSigned;
			minValue = hidInfo.logicalMin;
			maxValue = hidInfo.logicalMax;
			this.zeroValue = zeroValue;
		}

		public override void UpdateValue(NativeBuffer inputReport, double timestamp)
		{
			if (inputReport == null || inputReport[0] != reportId)
			{
				return;
			}
			this.timestamp = timestamp;
			int num = 0;
			if (byteLength > 1)
			{
				for (int i = 0; i < byteLength; i++)
				{
					num |= inputReport[startIndex + i] << 8 * i;
				}
			}
			else
			{
				num = inputReport[startIndex];
			}
			rawValue = num;
		}
	}
}
