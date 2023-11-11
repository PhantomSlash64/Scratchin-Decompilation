using System;
using UnityEngine;

namespace Rewired.Utils
{
	public class MathTools
	{
		private const float mqadVvaaMvmHRiytGZSSLnvBCleH = 1E-10f;

		private const double THWZaOjwnrclVBELxLSXvFhxRrs = 1E-10;

		private const float acLWsPZrhSzZglIKrrlWNeUMoE = 0.0001f;

		public const float PI = (float)Math.PI;

		public const float Infinity = float.PositiveInfinity;

		public const float NegativeInfinity = float.NegativeInfinity;

		public const float Deg2Rad = (float)Math.PI / 180f;

		public const float Rad2Deg = 57.29578f;

		public const float Epsilon = float.Epsilon;

		public static sbyte Abs(sbyte value)
		{
			if (value >= 0)
			{
				return value;
			}
			if (value == sbyte.MinValue)
			{
				throw new OverflowException("Cannot compute absolute value of sbyte.MinValue");
			}
			return (sbyte)(-value);
		}

		public static short Abs(short value)
		{
			if (value >= 0)
			{
				return value;
			}
			if (value == short.MinValue)
			{
				throw new OverflowException("Cannot compute absolute value of short.MinValue");
			}
			return (short)(-value);
		}

		public static int Abs(int value)
		{
			if (value >= 0)
			{
				return value;
			}
			if (value == int.MinValue)
			{
				throw new OverflowException("Cannot compute absolute value of int.MinValue");
			}
			return -value;
		}

		public static long Abs(long value)
		{
			if (value >= 0)
			{
				return value;
			}
			if (value == long.MinValue)
			{
				throw new OverflowException("Cannot compute absolute value of long.MinValue");
			}
			return -value;
		}

		public static float Abs(float value)
		{
			if (value >= 0f)
			{
				return value;
			}
			if (value == float.NaN)
			{
				throw new OverflowException("Cannot compute absolute value of float.NaN");
			}
			return 0f - value;
		}

		public static double Abs(double value)
		{
			if (value >= 0.0)
			{
				return value;
			}
			if (value == double.NaN)
			{
				throw new OverflowException("Cannot compute absolute value of double.NaN");
			}
			return 0.0 - value;
		}

		public static bool Approximately(float a, float b)
		{
			if (a == b)
			{
				return true;
			}
			float num = b - a;
			if (num < 0f)
			{
				num = 0f - num;
			}
			if (a < 0f)
			{
				a = 0f - a;
			}
			if (b < 0f)
			{
				b = 0f - b;
			}
			float num2 = ((a > b) ? a : b) * 1E-06f;
			return num < ((num2 > 1.1E-44f) ? num2 : 1.1E-44f);
		}

		public static bool ApproximatelyZero(float a)
		{
			if (a == 0f)
			{
				return true;
			}
			float num = ((a < 0f) ? (0f - a) : a);
			float num2 = num * 1E-06f;
			return num < ((num2 > 1.1E-44f) ? num2 : 1.1E-44f);
		}

		public static bool IsZero(float value)
		{
			if (value < 0f)
			{
				value = 0f - value;
			}
			return value < 1E-10f;
		}

		public static bool IsZero(float value, float threshold)
		{
			if (threshold < 0f)
			{
				threshold = 0f - threshold;
			}
			if (value < 0f)
			{
				value = 0f - value;
			}
			return value < threshold;
		}

		public static bool IsZero(double value)
		{
			if (value < 0.0)
			{
				value = 0.0 - value;
			}
			return value < 1E-10;
		}

		public static bool IsZero(double value, double threshold)
		{
			if (threshold < 0.0)
			{
				threshold = 0.0 - threshold;
			}
			if (value < 0.0)
			{
				value = 0.0 - value;
			}
			return value < threshold;
		}

		public static bool IsExactlyEqual(float a, float b)
		{
			if (a >= b - float.Epsilon && a <= b + float.Epsilon)
			{
				return true;
			}
			return false;
		}

		public static bool IsExactlyEqual(double a, double b)
		{
			if (a >= b - double.Epsilon && a <= b + double.Epsilon)
			{
				return true;
			}
			return false;
		}

		public static bool IsNear(float value, float targetValue)
		{
			float num = value - targetValue;
			if (!(num < 0f))
			{
				return num <= 0.0001f;
			}
			return 0f - num <= 0.0001f;
		}

		public static bool IsNear(float value, float targetValue, float threshold)
		{
			if (threshold < 0f)
			{
				threshold = 0f - threshold;
			}
			float num = value - targetValue;
			if (!(num < 0f))
			{
				return num <= threshold;
			}
			return 0f - num <= threshold;
		}

		public static bool IsNearZero(float value)
		{
			if (!(value < 0f))
			{
				return value <= 0.0001f;
			}
			return 0f - value <= 0.0001f;
		}

		public static bool IsNearZero(float value, float threshold)
		{
			if (threshold < 0f)
			{
				threshold = 0f - threshold;
			}
			if (!(value < 0f))
			{
				return value <= threshold;
			}
			return 0f - value <= threshold;
		}

		public static bool IsNearOrWholeNumber(float value)
		{
			float num = ((value < 0f) ? (0f - value) : value);
			if (Ceil(num) - num <= 0.0001f)
			{
				return true;
			}
			return false;
		}

		public static bool IsNearOrWholeNumber(float value, float threshold)
		{
			if (threshold < 0f)
			{
				threshold = 0f - threshold;
			}
			float num = ((value < 0f) ? (0f - value) : value);
			if (Ceil(num) - num <= threshold)
			{
				return true;
			}
			return false;
		}

		public static bool IsNearOrWholeNumber(float value, out int number)
		{
			float num = ((!(value < 0f)) ? value : (value *= -1f));
			int num2 = RoundToInt(num);
			float num3 = num - (float)num2;
			if (num3 < 0f)
			{
				num3 *= -1f;
			}
			number = ((value < 0f) ? (num2 * -1) : num2);
			if (num3 <= 0.0001f)
			{
				return true;
			}
			return false;
		}

		public static bool IsNearOrWholeNumber(float value, out int number, float threshold)
		{
			if (threshold < 0f)
			{
				threshold = 0f - threshold;
			}
			float num = ((!(value < 0f)) ? value : (value *= -1f));
			int num2 = RoundToInt(num);
			float num3 = num - (float)num2;
			if (num3 < 0f)
			{
				num3 *= -1f;
			}
			number = ((value < 0f) ? (num2 * -1) : num2);
			if (num3 <= threshold)
			{
				return true;
			}
			return false;
		}

		public static float RoundOffIfNearWholeNumber(float value)
		{
			if (IsNearOrWholeNumber(value))
			{
				return Round(value);
			}
			return value;
		}

		public static float RoundOffIfNearWholeNumber(float value, float threshold)
		{
			if (threshold < 0f)
			{
				threshold = 0f - threshold;
			}
			if (IsNearOrWholeNumber(value, threshold))
			{
				return Round(value);
			}
			return value;
		}

		public static bool IsEven(int value)
		{
			if (value % 2 == 0)
			{
				return true;
			}
			return false;
		}

		public static float ValueInNewRange(float oldValue, float oldMin, float oldMax, float newMin, float newMax)
		{
			if (oldValue < oldMin)
			{
				oldValue = oldMin;
			}
			else if (oldValue > oldMax)
			{
				oldValue = oldMax;
			}
			float num = oldMax - oldMin;
			if (Approximately(num, 0f))
			{
				return newMin;
			}
			float num2 = newMax - newMin;
			return (oldValue - oldMin) * num2 / num + newMin;
		}

		public static int ValueInNewRange(int oldValue, int oldMin, int oldMax, int newMin, int newMax)
		{
			if (oldValue < oldMin)
			{
				oldValue = oldMin;
			}
			else if (oldValue > oldMax)
			{
				oldValue = oldMax;
			}
			int num = oldMax - oldMin;
			if (num == 0)
			{
				return newMin;
			}
			int num2 = newMax - newMin;
			return (oldValue - oldMin) * num2 / num + newMin;
		}

		public static sbyte Max(sbyte a, sbyte b)
		{
			if (a < b)
			{
				return b;
			}
			return a;
		}

		public static byte Max(byte a, byte b)
		{
			if (a < b)
			{
				return b;
			}
			return a;
		}

		public static short Max(short a, short b)
		{
			if (a < b)
			{
				return b;
			}
			return a;
		}

		public static ushort Max(ushort a, ushort b)
		{
			if (a < b)
			{
				return b;
			}
			return a;
		}

		public static int Max(int a, int b)
		{
			if (a < b)
			{
				return b;
			}
			return a;
		}

		public static uint Max(uint a, uint b)
		{
			if (a < b)
			{
				return b;
			}
			return a;
		}

		public static long Max(long a, long b)
		{
			if (a < b)
			{
				return b;
			}
			return a;
		}

		public static ulong Max(ulong a, ulong b)
		{
			if (a < b)
			{
				return b;
			}
			return a;
		}

		public static float Max(float a, float b)
		{
			if (!(a >= b))
			{
				return b;
			}
			return a;
		}

		public static double Max(double a, double b)
		{
			if (!(a >= b))
			{
				return b;
			}
			return a;
		}

		public static sbyte Min(sbyte a, sbyte b)
		{
			if (a > b)
			{
				return b;
			}
			return a;
		}

		public static byte Min(byte a, byte b)
		{
			if (a > b)
			{
				return b;
			}
			return a;
		}

		public static short Min(short a, short b)
		{
			if (a > b)
			{
				return b;
			}
			return a;
		}

		public static ushort Min(ushort a, ushort b)
		{
			if (a > b)
			{
				return b;
			}
			return a;
		}

		public static int Min(int a, int b)
		{
			if (a > b)
			{
				return b;
			}
			return a;
		}

		public static uint Min(uint a, uint b)
		{
			if (a > b)
			{
				return b;
			}
			return a;
		}

		public static long Min(long a, long b)
		{
			if (a > b)
			{
				return b;
			}
			return a;
		}

		public static ulong Min(ulong a, ulong b)
		{
			if (a > b)
			{
				return b;
			}
			return a;
		}

		public static float Min(float a, float b)
		{
			if (!(a <= b))
			{
				return b;
			}
			return a;
		}

		public static double Min(double a, double b)
		{
			if (!(a <= b))
			{
				return b;
			}
			return a;
		}

		public static sbyte MaxMagnitude(sbyte a, sbyte b)
		{
			sbyte b2 = ((a < 0) ? ((sbyte)(-a)) : a);
			sbyte b3 = ((b < 0) ? ((sbyte)(-b)) : b);
			if (b2 < b3)
			{
				return b;
			}
			return a;
		}

		public static byte MaxMagnitude(byte a, byte b)
		{
			if (a < b)
			{
				return b;
			}
			return a;
		}

		public static short MaxMagnitude(short a, short b)
		{
			short num = ((a < 0) ? ((short)(-a)) : a);
			short num2 = ((b < 0) ? ((short)(-b)) : b);
			if (num < num2)
			{
				return b;
			}
			return a;
		}

		public static ushort MaxMagnitude(ushort a, ushort b)
		{
			if (a < b)
			{
				return b;
			}
			return a;
		}

		public static int MaxMagnitude(int a, int b)
		{
			int num = ((a < 0) ? (-a) : a);
			int num2 = ((b < 0) ? (-b) : b);
			if (num < num2)
			{
				return b;
			}
			return a;
		}

		public static uint MaxMagnitude(uint a, uint b)
		{
			if (a < b)
			{
				return b;
			}
			return a;
		}

		public static long MaxMagnitude(long a, long b)
		{
			long num = ((a < 0) ? (-a) : a);
			long num2 = ((b < 0) ? (-b) : b);
			if (num < num2)
			{
				return b;
			}
			return a;
		}

		public static ulong MaxMagnitude(ulong a, ulong b)
		{
			if (a < b)
			{
				return b;
			}
			return a;
		}

		public static float MaxMagnitude(float a, float b)
		{
			float num = ((a < 0f) ? (0f - a) : a);
			float num2 = ((b < 0f) ? (0f - b) : b);
			if (!(num >= num2))
			{
				return b;
			}
			return a;
		}

		public static double MaxMagnitude(double a, double b)
		{
			double num = ((a < 0.0) ? (0.0 - a) : a);
			double num2 = ((b < 0.0) ? (0.0 - b) : b);
			if (!(num >= num2))
			{
				return b;
			}
			return a;
		}

		public static sbyte MinMagnitude(sbyte a, sbyte b)
		{
			sbyte b2 = ((a < 0) ? ((sbyte)(-a)) : a);
			sbyte b3 = ((b < 0) ? ((sbyte)(-b)) : b);
			if (b2 > b3)
			{
				return b;
			}
			return a;
		}

		public static byte MinMagnitude(byte a, byte b)
		{
			if (a > b)
			{
				return b;
			}
			return a;
		}

		public static short MinMagnitude(short a, short b)
		{
			short num = ((a < 0) ? ((short)(-a)) : a);
			short num2 = ((b < 0) ? ((short)(-b)) : b);
			if (num > num2)
			{
				return b;
			}
			return a;
		}

		public static ushort MinMagnitude(ushort a, ushort b)
		{
			if (a > b)
			{
				return b;
			}
			return a;
		}

		public static int MinMagnitude(int a, int b)
		{
			int num = ((a < 0) ? (-a) : a);
			int num2 = ((b < 0) ? (-b) : b);
			if (num > num2)
			{
				return b;
			}
			return a;
		}

		public static uint MinMagnitude(uint a, uint b)
		{
			if (a > b)
			{
				return b;
			}
			return a;
		}

		public static long MinMagnitude(long a, long b)
		{
			long num = ((a < 0) ? (-a) : a);
			long num2 = ((b < 0) ? (-b) : b);
			if (num > num2)
			{
				return b;
			}
			return a;
		}

		public static ulong MinMagnitude(ulong a, ulong b)
		{
			if (a > b)
			{
				return b;
			}
			return a;
		}

		public static float MinMagnitude(float a, float b)
		{
			float num = ((a < 0f) ? (0f - a) : a);
			float num2 = ((b < 0f) ? (0f - b) : b);
			if (!(num <= num2))
			{
				return b;
			}
			return a;
		}

		public static double MinMagnitude(double a, double b)
		{
			double num = ((a < 0.0) ? (0.0 - a) : a);
			double num2 = ((b < 0.0) ? (0.0 - b) : b);
			if (!(num <= num2))
			{
				return b;
			}
			return a;
		}

		public static bool IsMoreMagnitudeOrEqual(sbyte a, sbyte b)
		{
			if (a < 0)
			{
				a = (sbyte)(-a);
			}
			if (b < 0)
			{
				b = (sbyte)(-b);
			}
			if (a >= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsMoreMagnitudeOrEqual(byte a, byte b)
		{
			if (a >= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsMoreMagnitudeOrEqual(short a, short b)
		{
			if (a < 0)
			{
				a = (short)(-a);
			}
			if (b < 0)
			{
				b = (short)(-b);
			}
			if (a >= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsMoreMagnitudeOrEqual(ushort a, ushort b)
		{
			if (a >= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsMoreMagnitudeOrEqual(int a, int b)
		{
			if (a < 0)
			{
				a = -a;
			}
			if (b < 0)
			{
				b = -b;
			}
			if (a >= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsMoreMagnitudeOrEqual(uint a, uint b)
		{
			if (a >= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsMoreMagnitudeOrEqual(long a, long b)
		{
			if (a < 0)
			{
				a = -a;
			}
			if (b < 0)
			{
				b = -b;
			}
			if (a >= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsMoreMagnitudeOrEqual(ulong a, ulong b)
		{
			if (a >= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsMoreMagnitudeOrEqual(float a, float b)
		{
			if (a < 0f)
			{
				a = 0f - a;
			}
			if (b < 0f)
			{
				b = 0f - b;
			}
			if (a >= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsMoreMagnitudeOrEqual(double a, double b)
		{
			if (a < 0.0)
			{
				a = 0.0 - a;
			}
			if (b < 0.0)
			{
				b = 0.0 - b;
			}
			if (a >= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsLessMagnitudeOrEqual(sbyte a, sbyte b)
		{
			if (a < 0)
			{
				a = (sbyte)(-a);
			}
			if (b < 0)
			{
				b = (sbyte)(-b);
			}
			if (a <= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsLessMagnitudeOrEqual(byte a, byte b)
		{
			if (a <= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsLessMagnitudeOrEqual(short a, short b)
		{
			if (a < 0)
			{
				a = (short)(-a);
			}
			if (b < 0)
			{
				b = (short)(-b);
			}
			if (a <= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsLessMagnitudeOrEqual(ushort a, ushort b)
		{
			if (a <= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsLessMagnitudeOrEqual(int a, int b)
		{
			if (a < 0)
			{
				a = -a;
			}
			if (b < 0)
			{
				b = -b;
			}
			if (a <= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsLessMagnitudeOrEqual(uint a, uint b)
		{
			if (a <= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsLessMagnitudeOrEqual(long a, long b)
		{
			if (a < 0)
			{
				a = -a;
			}
			if (b < 0)
			{
				b = -b;
			}
			if (a <= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsLessMagnitudeOrEqual(ulong a, ulong b)
		{
			if (a <= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsLessMagnitudeOrEqual(float a, float b)
		{
			if (a < 0f)
			{
				a = 0f - a;
			}
			if (b < 0f)
			{
				b = 0f - b;
			}
			if (a <= b)
			{
				return true;
			}
			return false;
		}

		public static bool IsLessMagnitudeOrEqual(double a, double b)
		{
			if (a < 0.0)
			{
				a = 0.0 - a;
			}
			if (b < 0.0)
			{
				b = 0.0 - b;
			}
			if (a <= b)
			{
				return true;
			}
			return false;
		}

		public static byte Clamp(byte value, byte min, byte max)
		{
			if (value < min)
			{
				value = min;
			}
			else if (value > max)
			{
				return max;
			}
			return value;
		}

		public static sbyte Clamp(sbyte value, sbyte min, sbyte max)
		{
			if (value < min)
			{
				value = min;
			}
			else if (value > max)
			{
				return max;
			}
			return value;
		}

		public static short Clamp(short value, short min, short max)
		{
			if (value < min)
			{
				value = min;
			}
			else if (value > max)
			{
				return max;
			}
			return value;
		}

		public static ushort Clamp(ushort value, ushort min, ushort max)
		{
			if (value < min)
			{
				value = min;
			}
			else if (value > max)
			{
				return max;
			}
			return value;
		}

		public static int Clamp(int value, int min, int max)
		{
			if (value < min)
			{
				value = min;
			}
			else if (value > max)
			{
				return max;
			}
			return value;
		}

		public static uint Clamp(uint value, uint min, uint max)
		{
			if (value < min)
			{
				value = min;
			}
			else if (value > max)
			{
				return max;
			}
			return value;
		}

		public static long Clamp(long value, long min, long max)
		{
			if (value < min)
			{
				value = min;
			}
			else if (value > max)
			{
				return max;
			}
			return value;
		}

		public static ulong Clamp(ulong value, ulong min, ulong max)
		{
			if (value < min)
			{
				value = min;
			}
			else if (value > max)
			{
				return max;
			}
			return value;
		}

		public static float Clamp(float value, float min, float max)
		{
			if (value < min)
			{
				value = min;
			}
			else if (value > max)
			{
				return max;
			}
			return value;
		}

		public static double Clamp(double value, double min, double max)
		{
			if (value < min)
			{
				value = min;
			}
			else if (value > max)
			{
				return max;
			}
			return value;
		}

		public static float Clamp01(float value)
		{
			if (value < 0f)
			{
				return 0f;
			}
			if (value > 1f)
			{
				return 1f;
			}
			return value;
		}

		public static float ClampAngle360(float angle)
		{
			float num = Abs(angle);
			if (num >= 360f)
			{
				float num2 = num / 360f;
				float num3 = Floor(num2);
				num2 -= num3;
				if (num2 == 0f)
				{
					return 0f;
				}
				if (num2 > 0f)
				{
					float num4 = num - num3 * 360f;
					angle = num4 * Sign(angle);
				}
			}
			if (angle < 0f)
			{
				angle = 360f + angle;
			}
			return angle;
		}

		public static float ReverseAngleRotationDirection(float angle)
		{
			if (angle == 0f)
			{
				return 180f;
			}
			if (angle == 180f)
			{
				return 0f;
			}
			return 360f - angle + 180f;
		}

		public static bool AngleIsNear(float angle, float targetAngle, float threshold)
		{
			if (threshold < 0f)
			{
				threshold = Mathf.Abs(threshold);
			}
			return AngleIsBetween(angle, targetAngle - threshold, targetAngle + threshold);
		}

		public static bool AngleIsBetween(float angle, float min, float max)
		{
			angle = ClampAngle360(angle);
			min = ClampAngle360(min);
			max = ClampAngle360(max);
			if (min < max)
			{
				if (min <= angle)
				{
					return angle <= max;
				}
				return false;
			}
			if (!(min <= angle))
			{
				return angle <= max;
			}
			return true;
		}

		internal static bool nIYqxPCEgduiAcFHOBYqDVpIzSGn(int P_0, int P_1)
		{
			if (P_0 == 0 && P_1 == 0)
			{
				return false;
			}
			return (P_0 & P_1) != 0;
		}

		public static int IntPow(int x, uint pow)
		{
			int num = 1;
			while (pow != 0)
			{
				if ((pow & 1) == 1)
				{
					num *= x;
				}
				x *= x;
				pow >>= 1;
			}
			return num;
		}

		public static uint RoundUpToPowerOf2(uint value)
		{
			if (value == 0)
			{
				return 1u;
			}
			value--;
			value |= value >> 1;
			value |= value >> 2;
			value |= value >> 4;
			value |= value >> 8;
			value |= value >> 16;
			value++;
			return value;
		}

		public static float BooleanToSign(bool b)
		{
			if (b)
			{
				return 1f;
			}
			return -1f;
		}

		public static bool SignToBoolean(float sign)
		{
			if (sign >= 1f)
			{
				return true;
			}
			return false;
		}

		public static float Sin(float value)
		{
			return (float)Math.Sin(value);
		}

		public static float Cos(float value)
		{
			return (float)Math.Cos(value);
		}

		public static float Tan(float value)
		{
			return (float)Math.Tan(value);
		}

		public static float Asin(float value)
		{
			return (float)Math.Asin(value);
		}

		public static float Acos(float value)
		{
			return (float)Math.Acos(value);
		}

		public static float Atan(float value)
		{
			return (float)Math.Atan(value);
		}

		public static float Atan2(float y, float x)
		{
			return (float)Math.Atan2(y, x);
		}

		public static float Sqrt(float value)
		{
			return (float)Math.Sqrt(value);
		}

		public static float Pow(float value, float p)
		{
			return (float)Math.Pow(value, p);
		}

		public static float Exp(float power)
		{
			return (float)Math.Exp(power);
		}

		public static float Log(float value, float p)
		{
			return (float)Math.Log(value, p);
		}

		public static float Log(float value)
		{
			return (float)Math.Log(value);
		}

		public static float Log10(float value)
		{
			return (float)Math.Log10(value);
		}

		public static float Ceil(float value)
		{
			return (float)Math.Ceiling(value);
		}

		public static float Floor(float value)
		{
			return (float)Math.Floor(value);
		}

		public static float Round(float value)
		{
			return (float)Math.Round(value);
		}

		public static int CeilToInt(float value)
		{
			return (int)Math.Ceiling(value);
		}

		public static int FloorToInt(float value)
		{
			return (int)Math.Floor(value);
		}

		public static int RoundToInt(float value)
		{
			return (int)Math.Round(value);
		}

		public static float Sign(float value)
		{
			if (!(value < 0f))
			{
				return 1f;
			}
			return -1f;
		}

		public static int Sign(int value)
		{
			if (value >= 0)
			{
				return 1;
			}
			return -1;
		}

		public static float Repeat(float t, float length)
		{
			return t - Floor(t / length) * length;
		}

		public static float DeltaAngle(float current, float target)
		{
			float num = Repeat(target - current, 360f);
			if (num > 180f)
			{
				num -= 360f;
			}
			return num;
		}

		public static Vector2 MaxMagnitude(Vector2 a, Vector2 b)
		{
			float sqrMagnitude = a.sqrMagnitude;
			float sqrMagnitude2 = b.sqrMagnitude;
			if (sqrMagnitude >= sqrMagnitude2)
			{
				return a;
			}
			return b;
		}

		public static Vector3 MaxMagnitude(Vector3 a, Vector3 b)
		{
			float sqrMagnitude = a.sqrMagnitude;
			float sqrMagnitude2 = b.sqrMagnitude;
			if (sqrMagnitude >= sqrMagnitude2)
			{
				return a;
			}
			return b;
		}

		public static Vector2 MinMagnitude(Vector2 a, Vector2 b)
		{
			float sqrMagnitude = a.sqrMagnitude;
			float sqrMagnitude2 = b.sqrMagnitude;
			if (sqrMagnitude <= sqrMagnitude2)
			{
				return a;
			}
			return b;
		}

		public static Vector3 MinMagnitude(Vector3 a, Vector3 b)
		{
			float sqrMagnitude = a.sqrMagnitude;
			float sqrMagnitude2 = b.sqrMagnitude;
			if (sqrMagnitude <= sqrMagnitude2)
			{
				return a;
			}
			return b;
		}

		public static Vector2 Clamp(Vector2 value, Vector2 min, Vector2 max)
		{
			return new Vector2((value.x < min.x) ? min.x : ((value.x > max.x) ? max.x : value.x), (value.y < min.y) ? min.y : ((value.y > max.y) ? max.y : value.y));
		}

		public static Vector2 Clamp(Vector2 value, float min, float max)
		{
			return new Vector2((value.x < min) ? min : ((value.x > max) ? max : value.x), (value.y < min) ? min : ((value.y > max) ? max : value.y));
		}

		public static Vector2 Clamp(Vector3 value, Vector3 min, Vector3 max)
		{
			return new Vector3((value.x < min.x) ? min.x : ((value.x > max.x) ? max.x : value.x), (value.y < min.y) ? min.y : ((value.y > max.y) ? max.y : value.y), (value.z < min.z) ? min.z : ((value.z > max.z) ? max.z : value.z));
		}

		public static Vector2 Clamp(Vector3 value, float min, float max)
		{
			return new Vector3((value.x < min) ? min : ((value.x > max) ? max : value.x), (value.y < min) ? min : ((value.y > max) ? max : value.y), (value.z < min) ? min : ((value.z > max) ? max : value.z));
		}

		public static float Cross(Vector2 a, Vector2 b)
		{
			return a.x * b.y - a.y * b.x;
		}

		public static float Multiply(Vector2 a, Vector2 b)
		{
			return a.x * b.x + a.y * b.y;
		}

		public static bool RectContains(Rect rect, Vector2 pos, float rotation = 0f)
		{
			if (rotation == 0f)
			{
				return rect.Contains(pos);
			}
			Vector2 point = RotateWorldPoint(pos, rect.center, 0f - rotation);
			return rect.Contains(point);
		}

		public static Vector2 RotateWorldPoint(Vector2 point, Vector2 center, float angle)
		{
			float num = point.x - center.x;
			float num2 = point.y - center.y;
			float value = (float)Math.PI / 180f * ClampAngle360(angle);
			float num3 = Cos(value);
			float num4 = Sin(value);
			float num5 = num * num3 - num2 * num4;
			float num6 = num * num4 + num2 * num3;
			return new Vector2(center.x + num5, center.y + num6);
		}

		public static Vector2 RotateLocalPoint(Vector2 point, float angle)
		{
			float x = point.x;
			float y = point.y;
			float value = (float)Math.PI / 180f * ClampAngle360(angle);
			float num = Cos(value);
			float num2 = Sin(value);
			float x2 = x * num - y * num2;
			float y2 = x * num2 + y * num;
			return new Vector2(x2, y2);
		}

		public static bool LineIntersectsRect(Vector2 point1, Vector2 point2, Rect rect, out float sqrMagnitude)
		{
			sqrMagnitude = float.PositiveInfinity;
			if (rect.Contains(point1) || rect.Contains(point2))
			{
				sqrMagnitude = 0f;
				return true;
			}
			Vector2 intersection;
			bool flag = LineSegementsIntersect(point1, point2, new Vector2(rect.xMin, rect.yMin), new Vector2(rect.xMin, rect.yMax), out intersection, collinearIntersects: true);
			Vector2 intersection2;
			bool flag2 = LineSegementsIntersect(point1, point2, new Vector2(rect.xMax, rect.yMin), new Vector2(rect.xMax, rect.yMax), out intersection2, collinearIntersects: true);
			Vector2 intersection3;
			bool flag3 = LineSegementsIntersect(point1, point2, new Vector2(rect.xMin, rect.yMax), new Vector2(rect.xMax, rect.yMax), out intersection3, collinearIntersects: true);
			Vector2 intersection4;
			bool flag4 = LineSegementsIntersect(point1, point2, new Vector2(rect.xMin, rect.yMin), new Vector2(rect.xMax, rect.yMax), out intersection4, collinearIntersects: true);
			if (!flag && !flag2 && !flag3 && !flag4)
			{
				return false;
			}
			if (flag)
			{
				sqrMagnitude = ((sqrMagnitude != float.PositiveInfinity) ? Min(sqrMagnitude, (intersection - point1).sqrMagnitude) : (intersection - point1).sqrMagnitude);
			}
			if (flag2)
			{
				sqrMagnitude = ((sqrMagnitude != float.PositiveInfinity) ? Min(sqrMagnitude, (intersection2 - point1).sqrMagnitude) : (intersection2 - point1).sqrMagnitude);
			}
			if (flag3)
			{
				sqrMagnitude = ((sqrMagnitude != float.PositiveInfinity) ? Min(sqrMagnitude, (intersection3 - point1).sqrMagnitude) : (intersection3 - point1).sqrMagnitude);
			}
			if (flag4)
			{
				sqrMagnitude = ((sqrMagnitude != float.PositiveInfinity) ? Min(sqrMagnitude, (intersection4 - point1).sqrMagnitude) : (intersection4 - point1).sqrMagnitude);
			}
			return true;
		}

		public static bool LineSegementsIntersect(Vector2 line1p1, Vector2 line1p2, Vector2 line2p1, Vector2 line2p2, out Vector2 intersection, bool collinearIntersects = false)
		{
			intersection = default(Vector2);
			Vector2 vector = line1p2 - line1p1;
			Vector2 vector2 = line2p2 - line2p1;
			float num = Cross(vector, vector2);
			float value = Cross(line2p1 - line1p1, vector);
			if (IsZero(num) && IsZero(value))
			{
				if (collinearIntersects && ((0f <= Multiply(line2p1 - line1p1, vector) && Multiply(line2p1 - line1p1, vector) <= Multiply(vector, vector)) || (0f <= Multiply(line1p1 - line2p1, vector2) && Multiply(line1p1 - line2p1, vector2) <= Multiply(vector2, vector2))))
				{
					return true;
				}
				return false;
			}
			if (IsZero(num) && !IsZero(value))
			{
				return false;
			}
			float num2 = Cross(line2p1 - line1p1, vector2) / num;
			float num3 = Cross(line2p1 - line1p1, vector) / num;
			if (!IsZero(num) && 0f <= num2 && num2 <= 1f && 0f <= num3 && num3 <= 1f)
			{
				intersection = line1p1 + num2 * vector;
				return true;
			}
			return false;
		}

		private static bool KSxcXZrHaGAsRzWWAnpWPTlhOTJ(Vector2 P_0, Vector2 P_1, Vector2 P_2, Vector2 P_3, out Vector2 P_4)
		{
			float num = P_1.y - P_0.y;
			float num2 = P_0.x - P_1.x;
			float num3 = num * P_0.x + num2 * P_0.y;
			float num4 = P_3.y - P_2.y;
			float num5 = P_2.x - P_3.x;
			float num6 = num4 * P_2.x + num5 * P_2.y;
			float num7 = num * num5 - num4 * num2;
			if (num7 == 0f)
			{
				P_4 = Vector2.zero;
				return false;
			}
			P_4 = new Vector2((num5 * num3 - num2 * num6) / num7, (num * num6 - num4 * num3) / num7);
			return true;
		}

		public static bool RectContains(Rect container, Rect child)
		{
			if (child.xMin < container.xMin)
			{
				return false;
			}
			if (child.xMax > container.xMax)
			{
				return false;
			}
			if (child.yMin < container.yMin)
			{
				return false;
			}
			if (child.yMax > container.yMax)
			{
				return false;
			}
			return true;
		}

		public static bool GetOffsetToContainRect(Rect container, Rect child, out Vector2 offset)
		{
			offset = default(Vector2);
			if (container.width < child.width || container.height < child.height)
			{
				return false;
			}
			if (child.xMin < container.xMin)
			{
				offset.x += container.xMin - child.xMin;
			}
			if (child.xMax > container.xMax)
			{
				offset.x += container.xMax - child.xMax;
			}
			if (child.yMin < container.yMin)
			{
				offset.y += container.yMin - child.yMin;
			}
			if (child.yMax > container.yMax)
			{
				offset.y += container.yMax - child.yMax;
			}
			return true;
		}

		public static Matrix4x4 TransformTo(Transform from, Transform to)
		{
			return to.worldToLocalMatrix * from.localToWorldMatrix;
		}

		public static Rect TransformRect(Rect fromRect, Transform from, Transform to)
		{
			Matrix4x4 matrix4x = TransformTo(from, to);
			Vector3 point = new Vector2(fromRect.xMin, fromRect.yMin);
			Vector3 point2 = new Vector2(fromRect.xMax, fromRect.yMax);
			point = matrix4x.MultiplyPoint(point);
			point2 = matrix4x.MultiplyPoint(point2);
			fromRect.xMin = point.x;
			fromRect.yMin = point.y;
			fromRect.xMax = point2.x;
			fromRect.yMax = point2.y;
			return fromRect;
		}

		public static Vector2 SnapVectorToNearestAngle(Vector2 vector, float angle)
		{
			float num = Vector2.Angle(vector, Vector3.up);
			if (num < angle / 2f)
			{
				return Vector2.up * vector.magnitude;
			}
			if (num > 180f - angle / 2f)
			{
				return -Vector2.up * vector.magnitude;
			}
			float num2 = Mathf.Round(num / angle);
			float angle2 = num2 * angle - num;
			Vector3 axis = Vector3.Cross(Vector3.up, vector);
			Quaternion quaternion = Quaternion.AngleAxis(angle2, axis);
			return quaternion * vector;
		}

		public static float SignedAngle(Vector3 from, Vector3 to, Vector3 axis)
		{
			float num = Vector3.Angle(from, to);
			float num2 = from.y * to.z - from.z * to.y;
			float num3 = from.z * to.x - from.x * to.z;
			float num4 = from.x * to.y - from.y * to.x;
			float num5 = Mathf.Sign(axis.x * num2 + axis.y * num3 + axis.z * num4);
			return num * num5;
		}
	}
}
