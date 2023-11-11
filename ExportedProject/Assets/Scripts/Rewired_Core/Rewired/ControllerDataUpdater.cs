using System;

namespace Rewired
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	internal class ControllerDataUpdater
	{
		public readonly InputSource source;

		public readonly int axisCount;

		public readonly int buttonCount;

		public readonly float[] axisValues;

		public readonly bool[] buttonValues;

		public readonly float[] buttonPressureValues;

		public readonly bool[] axisHasBeenPressedOSXLinux;

		private readonly UnknownControllerHat[] oSsyqVWejZrdafFezKQDtgwSudm;

		public bool hasReceivedInput;

		public ControllerDataUpdater(InputSource source, int axisCount, int buttonCount, UnknownControllerHat[] unknownControllerHats)
		{
			if (axisCount < 0 || buttonCount < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			this.source = source;
			this.axisCount = axisCount;
			this.buttonCount = buttonCount;
			oSsyqVWejZrdafFezKQDtgwSudm = unknownControllerHats;
			axisValues = new float[axisCount];
			buttonValues = new bool[buttonCount];
			buttonPressureValues = new float[buttonCount];
			axisHasBeenPressedOSXLinux = new bool[axisCount];
		}

		public bool IsUnknownHatCardinal(int buttonIndex)
		{
			if (oSsyqVWejZrdafFezKQDtgwSudm == null)
			{
				return false;
			}
			for (int i = 0; i < oSsyqVWejZrdafFezKQDtgwSudm.Length; i++)
			{
				if (oSsyqVWejZrdafFezKQDtgwSudm[i].IsButtonIndexCardinal(buttonIndex))
				{
					return true;
				}
			}
			return false;
		}

		public UnknownControllerHat.HatButtons GetUnknownHatButtons(int buttonIndex)
		{
			if (oSsyqVWejZrdafFezKQDtgwSudm == null)
			{
				return null;
			}
			for (int i = 0; i < oSsyqVWejZrdafFezKQDtgwSudm.Length; i++)
			{
				if (oSsyqVWejZrdafFezKQDtgwSudm[i].ContainsButtonIndex(buttonIndex))
				{
					return oSsyqVWejZrdafFezKQDtgwSudm[i].GetButtons();
				}
			}
			return null;
		}

		public void ClearData()
		{
			Array.Clear(axisValues, 0, axisValues.Length);
			Array.Clear(buttonValues, 0, buttonValues.Length);
			Array.Clear(buttonPressureValues, 0, buttonPressureValues.Length);
			Array.Clear(axisHasBeenPressedOSXLinux, 0, axisHasBeenPressedOSXLinux.Length);
			hasReceivedInput = false;
		}
	}
}
