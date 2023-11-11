using System;
using UnityEngine;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	public class IntVector4
	{
		public int x;

		public int y;

		public int z;

		public int q;

		public IntVector4()
		{
			x = 0;
			y = 0;
			z = 0;
			q = 0;
		}

		public IntVector4(int inX, int inY, int inZ, int inQ)
		{
			x = inX;
			y = inY;
			z = inZ;
			q = inQ;
		}

		public IntVector4 Clone()
		{
			return new IntVector4(x, y, z, q);
		}

		public static IntVector4 operator +(IntVector4 value1, IntVector4 value2)
		{
			return new IntVector4(value1.x + value2.x, value1.y + value2.y, value1.z + value2.z, value1.q + value2.q);
		}

		public static IntVector4 operator -(IntVector4 value1, IntVector4 value2)
		{
			return new IntVector4(value1.x - value2.x, value1.y - value2.y, value1.z - value2.z, value1.q - value2.q);
		}

		public static IntVector4 operator *(IntVector4 value1, IntVector4 value2)
		{
			return new IntVector4(value1.x * value2.x, value1.y * value2.y, value1.z * value2.z, value1.q * value2.q);
		}

		public static IntVector4 operator /(IntVector4 value1, IntVector4 value2)
		{
			return new IntVector4(value1.x / value2.x, value1.y / value2.y, value1.z / value2.z, value1.q / value2.q);
		}

		public static IntVector4 operator +(IntVector4 value1, int value2)
		{
			return new IntVector4(value1.x + value2, value1.y + value2, value1.z + value2, value1.q + value2);
		}

		public static IntVector4 operator -(IntVector4 value1, int value2)
		{
			return new IntVector4(value1.x - value2, value1.y - value2, value1.z - value2, value1.q - value2);
		}

		public static IntVector4 operator *(IntVector4 value1, int value2)
		{
			return new IntVector4(value1.x * value2, value1.y * value2, value1.z * value2, value1.q * value2);
		}

		public static IntVector4 operator /(IntVector4 value1, int value2)
		{
			return new IntVector4(value1.x / value2, value1.y / value2, value1.z / value2, value1.q / value2);
		}

		public static Vector4 operator +(IntVector4 value1, float value2)
		{
			return new Vector4((float)value1.x + value2, (float)value1.y + value2, (float)value1.z + value2, (float)value1.q + value2);
		}

		public static Vector4 operator -(IntVector4 value1, float value2)
		{
			return new Vector4((float)value1.x - value2, (float)value1.y - value2, (float)value1.z - value2, (float)value1.q - value2);
		}

		public static Vector4 operator *(IntVector4 value1, float value2)
		{
			return new Vector4((float)value1.x * value2, (float)value1.y * value2, (float)value1.z * value2, (float)value1.q * value2);
		}

		public static Vector4 operator /(IntVector4 value1, float value2)
		{
			return new Vector4((float)value1.x / value2, (float)value1.y / value2, (float)value1.z / value2, (float)value1.q / value2);
		}
	}
}
