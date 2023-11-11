using System;
using UnityEngine;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	public struct Float4x : IEquatable<Float4x>
	{
		public const int Length = 4;

		public float a;

		public float b;

		public float c;

		public float d;

		private static Func<Float4x, Float4x, Float4x> _additionDelegate;

		private static Func<Float4x, Float4x, Float4x> _subtractionDelegate;

		private static Func<Float4x, Float4x, Float4x> _multiplicationDelegate;

		private static Func<Float4x, Float4x, Float4x> _divisionDelegate;

		public float this[int index]
		{
			get
			{
				return index switch
				{
					0 => a, 
					1 => b, 
					2 => c, 
					3 => d, 
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
				case 3:
					d = value;
					break;
				default:
					throw new ArgumentOutOfRangeException("index");
				}
			}
		}

		public static Float4x Zero => default(Float4x);

		public Float4x(float a, float b, float c, float d)
		{
			this.a = a;
			this.b = b;
			this.c = c;
			this.d = d;
		}

		public Float4x Clone()
		{
			return new Float4x(a, b, c, d);
		}

		public static Float4x Clone(Float4x obj)
		{
			return obj.Clone();
		}

		public override bool Equals(object obj)
		{
			if (!(obj is Float4x float4x))
			{
				return false;
			}
			if (float4x.a == a && float4x.b == b && float4x.c == c)
			{
				return float4x.d == d;
			}
			return false;
		}

		public override int GetHashCode()
		{
			int num = 17;
			num = num * 29 + a.GetHashCode();
			num = num * 29 + b.GetHashCode();
			num = num * 29 + c.GetHashCode();
			return num * 29 + d.GetHashCode();
		}

		public bool Equals(Float4x other)
		{
			if (a == other.a && b == other.b && c == other.c)
			{
				return d == other.d;
			}
			return false;
		}

		public override string ToString()
		{
			return a + ", " + b + ", " + c + ", " + d;
		}

		public static Float4x Add(Float4x value1, Float4x value2)
		{
			return value1 + value2;
		}

		public static Float4x Subtract(Float4x value1, Float4x value2)
		{
			return value1 - value2;
		}

		public static Float4x Multiply(Float4x value1, Float4x value2)
		{
			return value1 * value2;
		}

		public static Float4x Divide(Float4x value1, Float4x value2)
		{
			return value1 / value2;
		}

		public static Func<Float4x, Float4x, Float4x> GetAdditionDelegate()
		{
			if (_additionDelegate == null)
			{
				_additionDelegate = Add;
			}
			return _additionDelegate;
		}

		public static Func<Float4x, Float4x, Float4x> GetSubtractionDelegate()
		{
			if (_subtractionDelegate == null)
			{
				_subtractionDelegate = Subtract;
			}
			return _subtractionDelegate;
		}

		public static Func<Float4x, Float4x, Float4x> GetMultiplicationDelegate()
		{
			if (_multiplicationDelegate == null)
			{
				_multiplicationDelegate = Multiply;
			}
			return _multiplicationDelegate;
		}

		public static Func<Float4x, Float4x, Float4x> GetDivisionDelegate()
		{
			if (_divisionDelegate == null)
			{
				_divisionDelegate = Multiply;
			}
			return _divisionDelegate;
		}

		public static implicit operator Float4x(Vector4 obj)
		{
			return new Float4x(obj.x, obj.y, obj.z, obj.w);
		}

		public static implicit operator Vector4(Float4x obj)
		{
			return new Vector4(obj.a, obj.b, obj.c, obj.d);
		}

		public static Float4x operator +(Float4x value1, Float4x value2)
		{
			return new Float4x(value1.a + value2.a, value1.b + value2.b, value1.c + value2.c, value1.d + value2.d);
		}

		public static Float4x operator -(Float4x value1, Float4x value2)
		{
			return new Float4x(value1.a - value2.a, value1.b - value2.b, value1.c - value2.c, value1.d - value2.d);
		}

		public static Float4x operator *(Float4x value1, Float4x value2)
		{
			return new Float4x(value1.a * value2.a, value1.b * value2.b, value1.c * value2.c, value1.d * value2.d);
		}

		public static Float4x operator /(Float4x value1, Float4x value2)
		{
			return new Float4x(value1.a / value2.a, value1.b / value2.b, value1.c / value2.c, value1.d / value2.d);
		}

		public static Float4x operator +(Float4x value1, float value2)
		{
			return new Float4x(value1.a + value2, value1.b + value2, value1.c + value2, value1.d + value2);
		}

		public static Float4x operator -(Float4x value1, float value2)
		{
			return new Float4x(value1.a - value2, value1.b - value2, value1.c - value2, value1.d - value2);
		}

		public static Float4x operator *(Float4x value1, float value2)
		{
			return new Float4x(value1.a * value2, value1.b * value2, value1.c * value2, value1.d * value2);
		}

		public static Float4x operator /(Float4x value1, float value2)
		{
			return new Float4x(value1.a / value2, value1.b / value2, value1.c / value2, value1.d / value2);
		}
	}
}
