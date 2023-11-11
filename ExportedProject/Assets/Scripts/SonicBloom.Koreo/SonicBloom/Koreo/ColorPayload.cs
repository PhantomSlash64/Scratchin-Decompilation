using System;
using UnityEngine;

namespace SonicBloom.Koreo
{
	[Serializable]
	public class ColorPayload : IPayload
	{
		[SerializeField]
		[Tooltip("The color value that makes up the payload.")]
		private Color mColorVal = Color.white;

		public Color ColorVal
		{
			get
			{
				return mColorVal;
			}
			set
			{
				mColorVal = value;
			}
		}

		public static string GetFriendlyName()
		{
			return "Color";
		}

		public IPayload GetCopy()
		{
			ColorPayload colorPayload = new ColorPayload();
			colorPayload.ColorVal = ColorVal;
			return colorPayload;
		}
	}
}
