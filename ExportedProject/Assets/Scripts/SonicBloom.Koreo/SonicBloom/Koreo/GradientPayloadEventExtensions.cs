using UnityEngine;

namespace SonicBloom.Koreo
{
	public static class GradientPayloadEventExtensions
	{
		public static bool HasGradientPayload(this KoreographyEvent koreoEvent)
		{
			return koreoEvent.Payload is GradientPayload;
		}

		public static Gradient GetGradientData(this KoreographyEvent koreoEvent)
		{
			Gradient result = null;
			if (koreoEvent.Payload is GradientPayload gradientPayload)
			{
				result = gradientPayload.GradientData;
			}
			return result;
		}

		public static Color GetColorOfGradientAtTime(this KoreographyEvent koreoEvent, int sampleTime)
		{
			Color result = Color.white;
			if (koreoEvent.Payload is GradientPayload gradientPayload)
			{
				result = gradientPayload.GradientData.Evaluate(koreoEvent.GetEventDeltaAtSampleTime(sampleTime));
			}
			return result;
		}
	}
}
