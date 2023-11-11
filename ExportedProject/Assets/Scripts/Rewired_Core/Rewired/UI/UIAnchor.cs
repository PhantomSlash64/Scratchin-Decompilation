using UnityEngine;

namespace Rewired.UI
{
	public struct UIAnchor
	{
		public Vector2 min;

		public Vector2 max;

		public static UIAnchor TopLeft => new UIAnchor(0f, 1f, 0f, 1f);

		public static UIAnchor TopCenter => new UIAnchor(0.5f, 1f, 0.5f, 1f);

		public static UIAnchor TopRight => new UIAnchor(1f, 1f, 1f, 1f);

		public static UIAnchor MiddleLeft => new UIAnchor(0f, 0.5f, 0f, 0.5f);

		public static UIAnchor MiddleCenter => new UIAnchor(0.5f, 0.5f, 0.5f, 0.5f);

		public static UIAnchor MiddleRight => new UIAnchor(1f, 0.5f, 1f, 0.5f);

		public static UIAnchor BottomLeft => new UIAnchor(0f, 0f, 0f, 0f);

		public static UIAnchor BottomCenter => new UIAnchor(0.5f, 0f, 0.5f, 0f);

		public static UIAnchor BottomRight => new UIAnchor(1f, 0f, 1f, 0f);

		public static UIAnchor TopHStretch => new UIAnchor(0f, 1f, 1f, 1f);

		public static UIAnchor MiddleHStretch => new UIAnchor(0f, 0.5f, 1f, 0.5f);

		public static UIAnchor BottomHStretch => new UIAnchor(0f, 0f, 1f, 0f);

		public static UIAnchor LeftVStretch => new UIAnchor(0f, 0f, 0f, 1f);

		public static UIAnchor CenterVStretch => new UIAnchor(0.5f, 0f, 0.5f, 1f);

		public static UIAnchor RightVStretch => new UIAnchor(1f, 0f, 1f, 1f);

		public static UIAnchor Stretch => new UIAnchor(0f, 0f, 1f, 1f);

		public UIAnchor(float minX, float minY, float maxX, float maxY)
		{
			if (minX < 0f)
			{
				minX = 0f;
			}
			if (minY < 0f)
			{
				minY = 0f;
			}
			if (maxX < 0f)
			{
				maxX = 0f;
			}
			if (maxY < 0f)
			{
				maxY = 0f;
			}
			min = new Vector2(minX, minY);
			max = new Vector2(maxX, maxY);
		}

		public UIAnchor(Vector2 min, Vector2 max)
		{
			if (min.x < 0f)
			{
				min.x = 0f;
			}
			if (min.y < 0f)
			{
				min.y = 0f;
			}
			if (max.x < 0f)
			{
				max.x = 0f;
			}
			if (max.y < 0f)
			{
				max.y = 0f;
			}
			this.min = min;
			this.max = max;
		}
	}
}
