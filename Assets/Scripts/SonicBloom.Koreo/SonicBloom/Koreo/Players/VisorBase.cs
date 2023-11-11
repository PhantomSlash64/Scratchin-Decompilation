using UnityEngine;

namespace SonicBloom.Koreo.Players
{
	public abstract class VisorBase
	{
		protected Koreographer koreographerCom;

		protected int sampleTime = -1;

		protected int sourceSampleTime = -1;

		protected abstract string GetAudioName();

		protected abstract bool GetIsAudioPlaying();

		protected abstract bool GetIsAudioLooping();

		protected abstract bool GetDidAudioLoop();

		protected abstract int GetAudioSampleTime();

		protected abstract int GetAudioStartSampleExtent();

		protected abstract int GetAudioEndSampleExtent();

		protected abstract int GetDeltaTimeInSamples();

		public virtual void Update()
		{
			if (!GetIsAudioPlaying())
			{
				return;
			}
			int num = sampleTime;
			int audioSampleTime = GetAudioSampleTime();
			float rawFrameTime = GetRawFrameTime();
			DeltaSlice deltaSlice = default(DeltaSlice);
			deltaSlice.deltaLength = rawFrameTime;
			if (sourceSampleTime == audioSampleTime)
			{
				int deltaTimeInSamples = GetDeltaTimeInSamples();
				int num2 = num + deltaTimeInSamples;
				int audioEndSampleExtent = GetAudioEndSampleExtent();
				if (num2 > audioEndSampleExtent)
				{
					if (GetIsAudioLooping())
					{
						sampleTime = audioEndSampleExtent;
						num++;
						double num3 = (double)(sampleTime - num) / (double)deltaTimeInSamples;
						deltaSlice.deltaLength = (float)(num3 * (double)rawFrameTime);
						koreographerCom.ProcessKoreography(GetAudioName(), num, sampleTime, deltaSlice);
						num = -1;
						sampleTime = num2 - sampleTime;
						deltaSlice.deltaOffset = (float)num3;
						deltaSlice.deltaLength = rawFrameTime - deltaSlice.deltaLength;
					}
					else
					{
						sampleTime = audioEndSampleExtent;
					}
				}
				else
				{
					sampleTime = num2;
				}
			}
			else if (audioSampleTime < sourceSampleTime)
			{
				if (GetDidAudioLoop())
				{
					if (sourceSampleTime <= num)
					{
						sampleTime = GetAudioEndSampleExtent();
						int num4 = sampleTime - num + audioSampleTime;
						num++;
						double num5 = (double)(sampleTime - num) / (double)num4;
						deltaSlice.deltaLength = (float)(num5 * (double)rawFrameTime);
						koreographerCom.ProcessKoreography(GetAudioName(), num, sampleTime, deltaSlice);
						num = -1;
						deltaSlice.deltaOffset = (float)num5;
						deltaSlice.deltaLength = rawFrameTime - deltaSlice.deltaLength;
					}
				}
				else
				{
					int deltaTimeInSamples2 = GetDeltaTimeInSamples();
					num = Mathf.Max(0, audioSampleTime - deltaTimeInSamples2) - 1;
				}
				sampleTime = audioSampleTime;
			}
			else
			{
				sampleTime = audioSampleTime;
			}
			koreographerCom.ProcessKoreography(GetAudioName(), num + 1, sampleTime, deltaSlice);
			sourceSampleTime = audioSampleTime;
		}

		protected int GetTotalPlaybackSamples()
		{
			return 1 + (GetAudioEndSampleExtent() - GetAudioStartSampleExtent());
		}

		protected float GetRawFrameTime()
		{
			float result = Time.unscaledDeltaTime;
			if (Time.unscaledDeltaTime >= Time.maximumDeltaTime && Time.deltaTime < Time.maximumDeltaTime && Time.timeScale != 0f)
			{
				result = Time.deltaTime / Time.timeScale;
			}
			return result;
		}
	}
}
