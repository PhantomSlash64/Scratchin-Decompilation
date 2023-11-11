using UnityEngine;

namespace SonicBloom.Koreo
{
	public static class ColorPayloadEventExtensions
	{
		public static bool HasColorPayload(this KoreographyEvent koreoEvent)
		{
			return koreoEvent.Payload is ColorPayload;
		}

		public static Color GetColorValue(this KoreographyEvent koreoEvent)
		{
			Color result = Color.white;
			if (koreoEvent.Payload is ColorPayload colorPayload)
			{
				result = colorPayload.ColorVal;
			}
			return result;
		}
	}
}
