using System;
using System.Threading;
using Rewired.Utils;

namespace Rewired.HID
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class HIDVibrationMotor
	{
		private int SNPcIOSWmwVreEHylnVduhdIbxE;

		private int ZtpgXagcJbIEWNwYMNsBhFPlrRco;

		private int HSqpLhrHsvUSigjyUxvsjCKNxUZ;

		private Action bmcgPuilHqIwCKxxmdESjQTUENT;

		public float Speed
		{
			get
			{
				return sxawhTpBHBUPbiAVUVyjJHSgpez(SNPcIOSWmwVreEHylnVduhdIbxE);
			}
			set
			{
				SNPcIOSWmwVreEHylnVduhdIbxE = PbOVwejsLEasdCaYzjcJiyYjtlB(value);
				if (bmcgPuilHqIwCKxxmdESjQTUENT != null)
				{
					bmcgPuilHqIwCKxxmdESjQTUENT();
				}
			}
		}

		public int SpeedRaw
		{
			get
			{
				return SNPcIOSWmwVreEHylnVduhdIbxE;
			}
			set
			{
				SNPcIOSWmwVreEHylnVduhdIbxE = value;
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

		public HIDVibrationMotor(int minSpeedRaw, int maxSpeedRaw)
		{
			ZtpgXagcJbIEWNwYMNsBhFPlrRco = minSpeedRaw;
			HSqpLhrHsvUSigjyUxvsjCKNxUZ = maxSpeedRaw;
		}

		private float sxawhTpBHBUPbiAVUVyjJHSgpez(int P_0)
		{
			return MathTools.Clamp((float)P_0 / (float)HSqpLhrHsvUSigjyUxvsjCKNxUZ, 0f, 1f);
		}

		private int PbOVwejsLEasdCaYzjcJiyYjtlB(float P_0)
		{
			return MathTools.Clamp((int)(P_0 * (float)HSqpLhrHsvUSigjyUxvsjCKNxUZ), ZtpgXagcJbIEWNwYMNsBhFPlrRco, HSqpLhrHsvUSigjyUxvsjCKNxUZ);
		}
	}
}
