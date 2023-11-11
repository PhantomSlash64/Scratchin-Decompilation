using System;
using UnityEngine;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	public class IntPadding
	{
		public int top;

		public int right;

		public int bottom;

		public int left;

		public IntPadding()
		{
			top = 0;
			right = 0;
			bottom = 0;
			left = 0;
		}

		public IntPadding(int inTop, int inRight, int inBottom, int inLeft)
		{
			top = inTop;
			right = inRight;
			bottom = inBottom;
			left = inLeft;
		}

		public IntPadding Clone()
		{
			return new IntPadding(top, right, bottom, left);
		}

		public static IntPadding operator +(IntPadding value1, IntPadding value2)
		{
			return new IntPadding(value1.top + value2.top, value1.right + value2.right, value1.bottom + value2.bottom, value1.left + value2.left);
		}

		public static IntPadding operator -(IntPadding value1, IntPadding value2)
		{
			return new IntPadding(value1.top - value2.top, value1.right - value2.right, value1.bottom - value2.bottom, value1.left - value2.left);
		}

		public static IntPadding operator *(IntPadding value1, IntPadding value2)
		{
			return new IntPadding(value1.top * value2.top, value1.right * value2.right, value1.bottom * value2.bottom, value1.left * value2.left);
		}

		public static IntPadding operator /(IntPadding value1, IntPadding value2)
		{
			return new IntPadding(value1.top / value2.top, value1.right / value2.right, value1.bottom / value2.bottom, value1.left / value2.left);
		}

		public static IntPadding operator +(IntPadding value1, int value2)
		{
			return new IntPadding(value1.top + value2, value1.right + value2, value1.bottom + value2, value1.left + value2);
		}

		public static IntPadding operator -(IntPadding value1, int value2)
		{
			return new IntPadding(value1.top - value2, value1.right - value2, value1.bottom - value2, value1.left - value2);
		}

		public static IntPadding operator *(IntPadding value1, int value2)
		{
			return new IntPadding(value1.top * value2, value1.right * value2, value1.bottom * value2, value1.left * value2);
		}

		public static IntPadding operator /(IntPadding value1, int value2)
		{
			return new IntPadding(value1.top / value2, value1.right / value2, value1.bottom / value2, value1.left / value2);
		}

		public static Vector4 operator +(IntPadding value1, float value2)
		{
			return new Vector4((float)value1.top + value2, (float)value1.right + value2, (float)value1.bottom + value2, (float)value1.left + value2);
		}

		public static Vector4 operator -(IntPadding value1, float value2)
		{
			return new Vector4((float)value1.top - value2, (float)value1.right - value2, (float)value1.bottom - value2, (float)value1.left - value2);
		}

		public static Vector4 operator *(IntPadding value1, float value2)
		{
			return new Vector4((float)value1.top * value2, (float)value1.right * value2, (float)value1.bottom * value2, (float)value1.left * value2);
		}

		public static Vector4 operator /(IntPadding value1, float value2)
		{
			return new Vector4((float)value1.top / value2, (float)value1.right / value2, (float)value1.bottom / value2, (float)value1.left / value2);
		}
	}
}
