using System;

namespace XInputDotNetPure
{
	internal static class Utils
	{
		public const uint Success = 0u;

		public const uint NotConnected = 0u;

		private const int LeftStickDeadZone = 7849;

		private const int RightStickDeadZone = 8689;

		private const int TriggerDeadZone = 30;

		public static float ApplyTriggerDeadZone(byte value, GamePadDeadZone deadZoneMode)
		{
			if (deadZoneMode == GamePadDeadZone.None)
			{
				return ApplyDeadZone((int)value, 255f, 0f);
			}
			return ApplyDeadZone((int)value, 255f, 30f);
		}

		public static GamePadThumbSticks.StickValue ApplyLeftStickDeadZone(short valueX, short valueY, GamePadDeadZone deadZoneMode)
		{
			return ApplyStickDeadZone(valueX, valueY, deadZoneMode, 7849);
		}

		public static GamePadThumbSticks.StickValue ApplyRightStickDeadZone(short valueX, short valueY, GamePadDeadZone deadZoneMode)
		{
			return ApplyStickDeadZone(valueX, valueY, deadZoneMode, 8689);
		}

		private static GamePadThumbSticks.StickValue ApplyStickDeadZone(short valueX, short valueY, GamePadDeadZone deadZoneMode, int deadZoneSize)
		{
			switch (deadZoneMode)
			{
			case GamePadDeadZone.Circular:
			{
				float num = (float)Math.Sqrt((long)valueX * (long)valueX + (long)valueY * (long)valueY);
				float num2 = ApplyDeadZone(num, 32767f, deadZoneSize);
				num2 = ((num2 > 0f) ? (num2 / num) : 0f);
				return new GamePadThumbSticks.StickValue(Clamp((float)valueX * num2), Clamp((float)valueY * num2));
			}
			case GamePadDeadZone.IndependentAxes:
				return new GamePadThumbSticks.StickValue(ApplyDeadZone(valueX, 32767f, deadZoneSize), ApplyDeadZone(valueY, 32767f, deadZoneSize));
			default:
				return new GamePadThumbSticks.StickValue(ApplyDeadZone(valueX, 32767f, 0f), ApplyDeadZone(valueY, 32767f, 0f));
			}
		}

		private static float Clamp(float value)
		{
			if (!(value < -1f))
			{
				if (!(value > 1f))
				{
					return value;
				}
				return 1f;
			}
			return -1f;
		}

		private static float ApplyDeadZone(float value, float maxValue, float deadZoneSize)
		{
			if (value < 0f - deadZoneSize)
			{
				value += deadZoneSize;
			}
			else
			{
				if (!(value > deadZoneSize))
				{
					return 0f;
				}
				value -= deadZoneSize;
			}
			value /= maxValue - deadZoneSize;
			return Clamp(value);
		}
	}
}
