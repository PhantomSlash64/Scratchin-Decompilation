using System;
using UnityEngine;

namespace Rewired.Utils.Classes.Utility
{
	[Serializable]
	[CustomObfuscation(rename = false)]
	internal class FrameTimer
	{
		public bool running;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private double timeRemaining;

		public double length;

		public double overrunBuffer;

		public FrameTimer()
		{
		}

		public FrameTimer(double inLength)
		{
			length = inLength;
		}

		public void tvCBgIPnqjaOIPTXBTydmcrRbzF()
		{
			running = true;
			timeRemaining = length;
		}

		public void tvCBgIPnqjaOIPTXBTydmcrRbzF(double P_0)
		{
			running = true;
			length = P_0;
			timeRemaining = length;
		}

		public bool mtiNfGzpXHszOwiOIAVYQuMZclV(double P_0, double P_1)
		{
			if (!running)
			{
				return false;
			}
			double num = ((P_1 > 0.0) ? (timeRemaining / P_1) : timeRemaining);
			num -= P_0;
			if (overrunBuffer > 0.0)
			{
				num -= overrunBuffer;
			}
			if (num <= 0.0)
			{
				running = false;
				if (num < 0.0)
				{
					overrunBuffer = num * -1.0;
				}
				else
				{
					overrunBuffer = 0.0;
				}
				return true;
			}
			timeRemaining = num * P_1;
			overrunBuffer = 0.0;
			return false;
		}

		public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
		{
			running = false;
			timeRemaining = 0.0;
			overrunBuffer = 0.0;
		}

		public void qysJfHSKWZgOoBehkAlcBLlZgpM(double P_0)
		{
			length = P_0;
		}

		public FrameTimer krDHfhzemQsdElTTOFwBBCKPvNI()
		{
			return (FrameTimer)MemberwiseClone();
		}
	}
}
