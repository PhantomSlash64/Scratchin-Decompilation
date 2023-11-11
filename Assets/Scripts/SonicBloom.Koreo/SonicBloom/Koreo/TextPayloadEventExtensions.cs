namespace SonicBloom.Koreo
{
	public static class TextPayloadEventExtensions
	{
		public static bool HasTextPayload(this KoreographyEvent koreoEvent)
		{
			return koreoEvent.Payload is TextPayload;
		}

		public static string GetTextValue(this KoreographyEvent koreoEvent)
		{
			string result = string.Empty;
			if (koreoEvent.Payload is TextPayload textPayload)
			{
				result = textPayload.TextVal;
			}
			return result;
		}
	}
}
