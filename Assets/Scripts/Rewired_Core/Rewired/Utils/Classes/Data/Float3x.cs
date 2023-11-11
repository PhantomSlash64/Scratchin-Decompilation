using System;
using UnityEngine;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	public struct Float3x : IEquatable<Float3x>
	{
		public const int Length = 3;

		public float a;

		public float b;

		public float c;

		private static Func<Float3x, Float3x, Float3x> _additionDelegate;

		private static Func<Float3x, Float3x, Float3x> _subtractionDelegate;

		private static Func<Float3x, Float3x, Float3x> _multiplicationDelegate;

		private static Func<Float3x, Float3x, Float3x> _divisionDelegate;

		public float this[int index]
		{
			get
			{
				return index switch
				{
					0 => a, 
					1 => b, 
					2 => c, 
					_ => throw new ArgumentOutOfRangeException("index"), 
				};
			}
			set
			{
				switch (index)
				{
				case 0:
					a = value;
					break;
				case 1:
					b = value;
					break;
				case 2:
					c = value;
					break;
				default:
					throw new ArgumentOutOfRangeException("index");
				}
			}
		}

		public static Float3x Zero => default(Float3x);

		public Float3x(float x, float y, float z)
		{
			a = x;
			b = y;
			c = z;
		}

		public Float3x Clone()
		{
			return new Float3x(a, b, c);
		}

		public static Float3x Clone(Float3x obj)
		{
			return obj.Clone();
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Float3x float3x))
			{
				return false;
			}
			if (float3x.a == a && float3x.b == b)
			{
				return float3x.c == c;
			}
			return false;
		}

		public override int GetHashCode()
		{
			int num = 17;
			num = num * 29 + a.GetHashCode();
			num = num * 29 + b.GetHashCode();
			return num * 29 + c.GetHashCode();
		}

		public bool Equals(Float3x other)
		{
			if (a == other.a && b == other.b)
			{
				return c == other.c;
			}
			return false;
		}

		public override string ToString()
		{
			return a + ", " + b + ", " + c;
		}

		public static Float3x Add(Float3x value1, Float3x value2)
		{
			return value1 + value2;
		}

		public static Float3x Subtract(Float3x value1, Float3x value2)
		{
			return value1 - value2;
		}

		public static Float3x Multiply(Float3x value1, Float3x value2)
		{
			return value1 * value2;
		}

		public static Float3x Divide(Float3x value1, Float3x value2)
		{
			return value1 / value2;
		}

		public static Func<Float3x, Float3x, Float3x> GetAdditionDelegate()
		{
			if (_additionDelegate == null)
			{
				_additionDelegate = Add;
			}
			return _additionDelegate;
		}

		public static Func<Float3x, Float3x, Float3x> GetSubtractionDelegate()
		{
			if (_subtractionDelegate == null)
			{
				_subtractionDelegate = Subtract;
			}
			return _subtractionDelegate;
		}

		public static Func<Float3x, Float3x, Float3x> GetMultiplicationDelegate()
		{
			if (_multiplicationDelegate == null)
			{
				_multiplicationDelegate = Multiply;
			}
			return _multiplicationDelegate;
		}

		public static Func<Float3x, Float3x, Float3x> GetDivisionDelegate()
		{
			if (_divisionDelegate == null)
			{
				_divisionDelegate = Multiply;
			}
			return _divisionDelegate;
		}

		public static implicit operator Float3x(Vector3 obj)
		{
			return new Float3x(obj.x, obj.y, obj.z);
		}

		public static implicit operator Vector3(Float3x obj)
		{
			return new Vector3(obj.a, obj.b, obj.c);
		}

		public static Float3x operator +(Float3x value1, Float3x value2)
		{
			return new Float3x(value1.a + value2.a, value1.b + value2.b, value1.c + value2.c);
		}

		public static Float3x operator -(Float3x value1, Float3x value2)
		{
			return new Float3x(value1.a - value2.a, value1.b - value2.b, value1.c - value2.c);
		}

		public static Float3x operator *(Float3x value1, Float3x value2)
		{
			return new Float3x(value1.a * value2.a, value1.b * value2.b, value1.c * value2.c);
		}

		public static Float3x operator /(Float3x value1, Float3x value2)
		{
			return new Float3x(value1.a / value2.a, value1.b / value2.b, value1.c / value2.c);
		}

		public static Float3x operator +(Float3x value1, float value2)
		{
			return new Float3x(value1.a + value2, value1.b + value2, value1.c + value2);
		}

		public static Float3x operator -(Float3x value1, float value2)
		{
			return new Float3x(value1.a - value2, value1.b - value2, value1.c - value2);
		}

		public static Float3x operator *(Float3x value1, float value2)
		{
			return new Float3x(value1.a * value2, value1.b * value2, value1.c * value2);
		}

		public static Float3x operator /(Float3x value1, float value2)
		{
			return new Float3x(value1.a / value2, value1.b / value2, value1.c / value2);
		}
	}
}
