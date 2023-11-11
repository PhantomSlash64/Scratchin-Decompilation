namespace SonicBloom.Koreo
{
	public static class SpectrumPayloadEventExtensions
	{
		public static bool HasSpectrumPayload(this KoreographyEvent koreoEvent)
		{
			return koreoEvent.Payload is SpectrumPayload;
		}

		public static void GetSpectrumAtTime(this KoreographyEvent koreoEvent, int sampleTime, ref float[] spectrum, int maxBinCount = 0)
		{
			if (koreoEvent.Payload is SpectrumPayload spectrumPayload)
			{
				spectrumPayload.GetSpectrumAtDelta(ref spectrum, koreoEvent.GetEventDeltaAtSampleTime(sampleTime), maxBinCount);
			}
		}
	}
}
