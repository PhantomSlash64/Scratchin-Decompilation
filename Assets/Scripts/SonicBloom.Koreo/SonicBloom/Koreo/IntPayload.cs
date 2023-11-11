using System;
using UnityEngine;

namespace SonicBloom.Koreo
{
	[Serializable]
	public class IntPayload : IPayload
	{
		[Tooltip("The int value that makes up the payload.")]
		[SerializeField]
		private int mIntVal;

		public int IntVal
		{
			get
			{
				return mIntVal;
			}
			set
			{
				mIntVal = value;
			}
		}

		public static string GetFriendlyName()
		{
			return "Int";
		}

		public IPayload GetCopy()
		{
			IntPayload intPayload = new IntPayload();
			intPayload.IntVal = IntVal;
			return intPayload;
		}
	}
}
