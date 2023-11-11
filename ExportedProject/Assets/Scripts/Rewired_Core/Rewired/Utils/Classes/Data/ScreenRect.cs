using System;
using UnityEngine;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	public struct ScreenRect
	{
		public float xMin;

		public float yMin;

		public float width;

		public float height;

		public float xMax
		{
			get
			{
				return xMin + width;
			}
			set
			{
				width = value - xMin;
			}
		}

		public float yMax
		{
			get
			{
				return yMin + height;
			}
			set
			{
				height = value - yMin;
			}
		}

		public Vector2 center => new Vector2(xMin + 0.5f * width, yMin + 0.5f * height);

		public ScreenRect(float left, float bottom, float width, float height)
		{
			xMin = left;
			yMin = bottom;
			this.width = width;
			this.height = height;
		}

		public override string ToString()
		{
			return $"xMin: {xMin}, yMin: {xMax}, width: {width}, height: {height}";
		}

		public static implicit operator Rect(ScreenRect o)
		{
			return new Rect(o.xMin, o.yMax, o.width, o.height);
		}

		public static implicit operator ScreenRect(Rect o)
		{
			return new ScreenRect(o.xMin, o.yMax, o.width, o.height);
		}
	}
}
