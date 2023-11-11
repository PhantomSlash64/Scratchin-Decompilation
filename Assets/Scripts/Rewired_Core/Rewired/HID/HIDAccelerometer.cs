using System;
using Rewired.Utils.Classes.Data;

namespace Rewired.HID
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class HIDAccelerometer : HIDControllerElement
	{
		public readonly float[] rawValue;

		public double timestamp;

		public readonly int valueLength;

		private readonly byte[] AFsAGvoENXAOYWyexqhHCWyJHGd;

		private readonly int DrCFybjMOpDbzbOPwGwiYjQRUIu;

		private readonly int DDwfHNlBhPbHLCOwiZJvzFdsZIr;

		private readonly Action<byte[], float[]> rxwfiFIqTEbnPtPaGotkCeUKiRwT;

		public HIDAccelerometer(byte reportId, HIDInfo hidInfo, int valueLength, Action<byte[], float[]> calcValueDelegate)
			: base(reportId, hidInfo)
		{
			this.valueLength = valueLength;
			rxwfiFIqTEbnPtPaGotkCeUKiRwT = calcValueDelegate;
			DrCFybjMOpDbzbOPwGwiYjQRUIu = ((hidInfo.bitSize > 0) ? ((hidInfo.bitSize + 8 - 1) / 8) : 0);
			DDwfHNlBhPbHLCOwiZJvzFdsZIr = hidInfo.dataIndex;
			AFsAGvoENXAOYWyexqhHCWyJHGd = new byte[DrCFybjMOpDbzbOPwGwiYjQRUIu];
			rawValue = new float[valueLength];
		}

		public override void UpdateValue(NativeBuffer inputReport, double timestamp)
		{
			if (inputReport != null && inputReport[0] == reportId)
			{
				this.timestamp = timestamp;
				for (int i = 0; i < DrCFybjMOpDbzbOPwGwiYjQRUIu; i++)
				{
					AFsAGvoENXAOYWyexqhHCWyJHGd[i] = inputReport[DDwfHNlBhPbHLCOwiZJvzFdsZIr + i];
				}
				if (rxwfiFIqTEbnPtPaGotkCeUKiRwT != null)
				{
					rxwfiFIqTEbnPtPaGotkCeUKiRwT(AFsAGvoENXAOYWyexqhHCWyJHGd, rawValue);
				}
			}
		}

		public void UpdateValueManual(float[] value, double timestamp)
		{
			this.timestamp = timestamp;
			for (int i = 0; i < valueLength; i++)
			{
				rawValue[i] = value[i];
			}
		}
	}
}
