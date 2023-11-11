using System;
using System.Threading;
using Rewired.Utils;

namespace Rewired.HID
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class HIDLight
	{
		private byte VAwHVreqXYNBHoxPEZzTGurjHhzD;

		private byte dKbnPtOeSHHlpvDjVbWnFyXZHthq;

		private byte ENfCzZOPYsrqsCtgHijXXZQbmgT;

		private Action bmcgPuilHqIwCKxxmdESjQTUENT;

		public float ColorR
		{
			get
			{
				return (float)(int)VAwHVreqXYNBHoxPEZzTGurjHhzD / 255f;
			}
			set
			{
				ColorRRaw = (byte)MathTools.Clamp((int)(value * 255f), 0, 255);
			}
		}

		public float ColorG
		{
			get
			{
				return (float)(int)dKbnPtOeSHHlpvDjVbWnFyXZHthq / 255f;
			}
			set
			{
				ColorGRaw = (byte)MathTools.Clamp((int)(value * 255f), 0, 255);
			}
		}

		public float ColorB
		{
			get
			{
				return (float)(int)ENfCzZOPYsrqsCtgHijXXZQbmgT / 255f;
			}
			set
			{
				ColorBRaw = (byte)MathTools.Clamp((int)(value * 255f), 0, 255);
			}
		}

		public byte ColorRRaw
		{
			get
			{
				return VAwHVreqXYNBHoxPEZzTGurjHhzD;
			}
			set
			{
				VAwHVreqXYNBHoxPEZzTGurjHhzD = value;
				if (bmcgPuilHqIwCKxxmdESjQTUENT != null)
				{
					bmcgPuilHqIwCKxxmdESjQTUENT();
				}
			}
		}

		public byte ColorGRaw
		{
			get
			{
				return dKbnPtOeSHHlpvDjVbWnFyXZHthq;
			}
			set
			{
				dKbnPtOeSHHlpvDjVbWnFyXZHthq = value;
				if (bmcgPuilHqIwCKxxmdESjQTUENT != null)
				{
					bmcgPuilHqIwCKxxmdESjQTUENT();
				}
			}
		}

		public byte ColorBRaw
		{
			get
			{
				return ENfCzZOPYsrqsCtgHijXXZQbmgT;
			}
			set
			{
				ENfCzZOPYsrqsCtgHijXXZQbmgT = value;
				if (bmcgPuilHqIwCKxxmdESjQTUENT != null)
				{
					bmcgPuilHqIwCKxxmdESjQTUENT();
				}
			}
		}

		public event Action ValueChangedEvent
		{
			add
			{
				Action action = bmcgPuilHqIwCKxxmdESjQTUENT;
				Action action2;
				do
				{
					action2 = action;
					Action value2 = (Action)Delegate.Combine(action2, value);
					action = Interlocked.CompareExchange(ref bmcgPuilHqIwCKxxmdESjQTUENT, value2, action2);
				}
				while ((object)action != action2);
			}
			remove
			{
				Action action = bmcgPuilHqIwCKxxmdESjQTUENT;
				Action action2;
				do
				{
					action2 = action;
					Action value2 = (Action)Delegate.Remove(action2, value);
					action = Interlocked.CompareExchange(ref bmcgPuilHqIwCKxxmdESjQTUENT, value2, action2);
				}
				while ((object)action != action2);
			}
		}

		public HIDLight()
		{
		}

		public HIDLight(byte colorRRaw, byte colorGRaw, byte colorBRaw)
		{
			VAwHVreqXYNBHoxPEZzTGurjHhzD = colorRRaw;
			dKbnPtOeSHHlpvDjVbWnFyXZHthq = colorGRaw;
			ENfCzZOPYsrqsCtgHijXXZQbmgT = colorBRaw;
		}
	}
}
