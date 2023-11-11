using System;
using UnityEngine;

namespace SonicBloom.Koreo
{
	[Serializable]
	public class FloatPayload : IPayload
	{
		[SerializeField]
		[Tooltip("The float value that makes up the payload.")]
		private float mFloatVal;

		public float FloatVal
		{
			get
			{
				return mFloatVal;
			}
			set
			{
				mFloatVal = value;
			}
		}

		public static string GetFriendlyName()
		{
			return "Float";
		}

		public IPayload GetCopy()
		{
			FloatPayload floatPayload = new FloatPayload();
			floatPayload.FloatVal = FloatVal;
			return floatPayload;
		}
	}
}
