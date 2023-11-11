using UnityEngine;

namespace SonicBloom.Koreo
{
	public static class AssetPayloadEventExtensions
	{
		public static bool HasAssetPayload(this KoreographyEvent koreoEvent)
		{
			return koreoEvent.Payload is AssetPayload;
		}

		public static Object GetAssetValue(this KoreographyEvent koreoEvent)
		{
			Object result = null;
			if (koreoEvent.Payload is AssetPayload assetPayload)
			{
				result = assetPayload.AssetVal;
			}
			return result;
		}
	}
}
