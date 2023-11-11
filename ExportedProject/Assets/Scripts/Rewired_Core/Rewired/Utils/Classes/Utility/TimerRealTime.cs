using System;
using UnityEngine;

namespace Rewired.Utils.Classes.Utility
{
	[Serializable]
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class TimerRealTime
	{
		public bool running;

		[SerializeField]
		private double sWxSxqaudQjIEWQDdIBidIYNqhe;

		public double length;

		public TimerRealTime()
		{
		}

		public TimerRealTime(double inLength)
		{
			length = inLength;
		}

		public void Start()
		{
			running = true;
			sWxSxqaudQjIEWQDdIBidIYNqhe = length + ReInput.realTime;
		}

		public void Start(double inLength)
		{
			running = true;
			length = inLength;
			sWxSxqaudQjIEWQDdIBidIYNqhe = length + ReInput.realTime;
		}

		public bool Update()
		{
			if (!running)
			{
				return false;
			}
			if (ReInput.realTime >= sWxSxqaudQjIEWQDdIBidIYNqhe)
			{
				running = false;
				return true;
			}
			return false;
		}

		public void Clear()
		{
			running = false;
			sWxSxqaudQjIEWQDdIBidIYNqhe = 0.0;
		}

		public void SetLength(double inLength)
		{
			length = inLength;
		}

		public TimerAbs Clone()
		{
			return (TimerAbs)MemberwiseClone();
		}
	}
}
