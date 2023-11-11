using System;
using UnityEngine;

namespace SonicBloom.Koreo
{
	[Serializable]
	public class GradientPayload : IPayload
	{
		[Tooltip("The gradient value that makes up the payload.")]
		[SerializeField]
		private Gradient mGradientData = new Gradient();

		public Gradient GradientData
		{
			get
			{
				return mGradientData;
			}
			set
			{
				mGradientData = value;
			}
		}

		public static string GetFriendlyName()
		{
			return "Gradient";
		}

		public IPayload GetCopy()
		{
			GradientPayload gradientPayload = new GradientPayload();
			gradientPayload.GradientData = GradientData;
			return gradientPayload;
		}
	}
}
