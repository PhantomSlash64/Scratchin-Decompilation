namespace SonicBloom.Koreo
{
	public static class IntPayloadEventExtensions
	{
		public static bool HasIntPayload(this KoreographyEvent koreoEvent)
		{
			return koreoEvent.Payload is IntPayload;
		}

		public static int GetIntValue(this KoreographyEvent koreoEvent)
		{
			int result = 0;
			if (koreoEvent.Payload is IntPayload intPayload)
			{
				result = intPayload.IntVal;
			}
			return result;
		}
	}
}
