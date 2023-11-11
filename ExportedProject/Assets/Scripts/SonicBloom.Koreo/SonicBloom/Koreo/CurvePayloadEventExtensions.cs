using UnityEngine;

namespace SonicBloom.Koreo
{
	public static class CurvePayloadEventExtensions
	{
		public static bool HasCurvePayload(this KoreographyEvent koreoEvent)
		{
			return koreoEvent.Payload is CurvePayload;
		}

		public static AnimationCurve GetCurveValue(this KoreographyEvent koreoEvent)
		{
			AnimationCurve result = null;
			if (koreoEvent.Payload is CurvePayload curvePayload)
			{
				result = curvePayload.CurveData;
			}
			return result;
		}

		public static float GetValueOfCurveAtTime(this KoreographyEvent koreoEvent, int sampleTime)
		{
			float result = 0f;
			if (koreoEvent.Payload is CurvePayload curvePayload)
			{
				result = curvePayload.GetValueAtDelta(koreoEvent.GetEventDeltaAtSampleTime(sampleTime));
			}
			return result;
		}
	}
}
