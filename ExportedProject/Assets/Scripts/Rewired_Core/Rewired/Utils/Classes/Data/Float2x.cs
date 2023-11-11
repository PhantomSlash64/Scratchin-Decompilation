using System;
using UnityEngine;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	public struct Float2x : IEquatable<Float2x>
	{
		public const int Length = 2;

		public float a;

		public float b;

		private static Func<Float2x, Float2x, Float2x> _additionDelegate;

		private static Func<Float2x, Float2x, Float2x> _subtractionDelegate;

		private static Func<Float2x, Float2x, Float2x> _multiplicationDelegate;

		private static Func<Float2x, Float2x, Float2x> _divisionDelegate;

		public float this[int index]
		{
			get
			{
				return index switch
				{
					0 => a, 
					1 => b, 
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
				default:
					throw new ArgumentOutOfRangeException("index");
				}
			}
		}

		public static Float2x Zero => default(Float2x);

		public Float2x(float a, float b)
		{
			this.a = a;
			this.b = b;
		}

		public Float2x Clone()
		{
			return new Float2x(a, b);
		}

		public static Float2x Clone(Float2x obj)
		{
			return obj.Clone();
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Float2x float2x))
			{
				return false;
			}
			if (float2x.a == a)
			{
				return float2x.b == b;
			}
			return false;
		}

		public override int GetHashCode()
		{
			int num = 17;
			num = num * 29 + a.GetHashCode();
			return num * 29 + b.GetHashCode();
		}

		public bool Equals(Float2x other)
		{
			if (a == other.a)
			{
				return b == other.b;
			}
			return false;
		}

		public override string ToString()
		{
			return a + ", " + b;
		}

		public static Float2x Add(Float2x value1, Float2x value2)
		{
			return value1 + value2;
		}

		public static Float2x Subtract(Float2x value1, Float2x value2)
		{
			return value1 - value2;
		}

		public static Float2x Multiply(Float2x value1, Float2x value2)
		{
			return value1 * value2;
		}

		public static Float2x Divide(Float2x value1, Float2x value2)
		{
			return value1 / value2;
		}

		public static Func<Float2x, Float2x, Float2x> GetAdditionDelegate()
		{
			if (_additionDelegate == null)
			{
				_additionDelegate = Add;
			}
			return _additionDelegate;
		}

		public static Func<Float2x, Float2x, Float2x> GetSubtractionDelegate()
		{
			if (_subtractionDelegate == null)
			{
				_subtractionDelegate = Subtract;
			}
			return _subtractionDelegate;
		}

		public static Func<Float2x, Float2x, Float2x> GetMultiplicationDelegate()
		{
			if (_multiplicationDelegate == null)
			{
				_multiplicationDelegate = Multiply;
			}
			return _multiplicationDelegate;
		}

		public static Func<Float2x, Float2x, Float2x> GetDivisionDelegate()
		{
			if (_divisionDelegate == null)
			{
				_divisionDelegate = Multiply;
			}
			return _divisionDelegate;
		}

		public static implicit operator Float2x(Vector2 obj)
		{
			return new Float2x(obj.x, obj.y);
		}

		public static implicit operator Vector2(Float2x obj)
		{
			return new Vector2(obj.a, obj.b);
		}

		public static Float2x operator +(Float2x value1, Float2x value2)
		{
			return new Float2x(value1.a + value2.a, value1.b + value2.b);
		}

		public static Float2x operator -(Float2x value1, Float2x value2)
		{
			return new Float2x(value1.a - value2.a, value1.b - value2.b);
		}

		public static Float2x operator *(Float2x value1, Float2x value2)
		{
			return new Float2x(value1.a * value2.a, value1.b * value2.b);
		}

		public static Float2x operator /(Float2x value1, Float2x value2)
		{
			return new Float2x(value1.a / value2.a, value1.b / value2.b);
		}

		public static Float2x operator +(Float2x value1, float value2)
		{
			return new Float2x(value1.a + value2, value1.b + value2);
		}

		public static Float2x operator -(Float2x value1, float value2)
		{
			return new Float2x(value1.a - value2, value1.b - value2);
		}

		public static Float2x operator *(Float2x value1, float value2)
		{
			return new Float2x(value1.a * value2, value1.b * value2);
		}

		public static Float2x operator /(Float2x value1, float value2)
		{
			return new Float2x(value1.a / value2, value1.b / value2);
		}
	}
}
