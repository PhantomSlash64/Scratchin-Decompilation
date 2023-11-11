namespace SonicBloom.Koreo
{
	public static class FloatPayloadEventExtensions
	{
		public static bool HasFloatPayload(this KoreographyEvent koreoEvent)
		{
			return koreoEvent.Payload is FloatPayload;
		}

		public static float GetFloatValue(this KoreographyEvent koreoEvent)
		{
			float result = 0f;
			if (koreoEvent.Payload is FloatPayload floatPayload)
			{
				result = floatPayload.FloatVal;
			}
			return result;
		}
	}
}
