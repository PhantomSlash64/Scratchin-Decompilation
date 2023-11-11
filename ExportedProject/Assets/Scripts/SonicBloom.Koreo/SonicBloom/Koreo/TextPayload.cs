using System;
using UnityEngine;

namespace SonicBloom.Koreo
{
	[Serializable]
	public class TextPayload : IPayload
	{
		[Tooltip("The string value that makes up the payload.")]
		[SerializeField]
		private string mTextVal;

		public string TextVal
		{
			get
			{
				return mTextVal;
			}
			set
			{
				mTextVal = value;
			}
		}

		public static string GetFriendlyName()
		{
			return "Text";
		}

		public IPayload GetCopy()
		{
			TextPayload textPayload = new TextPayload();
			textPayload.TextVal = TextVal;
			return textPayload;
		}
	}
}
