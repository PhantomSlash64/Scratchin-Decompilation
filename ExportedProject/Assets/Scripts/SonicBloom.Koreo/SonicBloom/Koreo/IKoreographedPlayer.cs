namespace SonicBloom.Koreo
{
	public interface IKoreographedPlayer
	{
		int GetSampleTimeForClip(string clipName);

		int GetTotalSampleTimeForClip(string clipName);

		bool GetIsPlaying(string clipName);

		float GetPitch(string clipName);

		string GetCurrentClipName();
	}
}
