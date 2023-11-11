using System;

namespace UnityEngine.Rendering
{
	[AttributeUsage(AttributeTargets.Field)]
	public class SurfaceDataAttributes : Attribute
	{
		public string[] displayNames;

		public bool isDirection;

		public bool sRGBDisplay;

		public FieldPrecision precision;

		public bool checkIsNormalized;

		public SurfaceDataAttributes(string displayName = "", bool isDirection = false, bool sRGBDisplay = false, FieldPrecision precision = FieldPrecision.Default, bool checkIsNormalized = false)
		{
			displayNames = new string[1];
			displayNames[0] = displayName;
			this.isDirection = isDirection;
			this.sRGBDisplay = sRGBDisplay;
			this.precision = precision;
			this.checkIsNormalized = checkIsNormalized;
		}

		public SurfaceDataAttributes(string[] displayNames, bool isDirection = false, bool sRGBDisplay = false, bool checkIsNormalized = false, FieldPrecision precision = FieldPrecision.Default)
		{
			this.displayNames = displayNames;
			this.isDirection = isDirection;
			this.sRGBDisplay = sRGBDisplay;
			this.precision = precision;
			this.checkIsNormalized = checkIsNormalized;
		}
	}
}
