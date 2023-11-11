using System;
using UnityEngine;

namespace SonicBloom.Koreo.Players
{
	public class AudioVisor : VisorBase
	{
		protected struct FrameStats
		{
			public int dspBufferCount;

			public int sourceSampleTime;

			public float pitch;
		}

		private static double S_EstimationWindowBufferCount = 1.0;

		private static double S_FuzzFactor;

		private static double S_OverEstimationPercent;

		protected AudioSource audioCom;

		protected AudioClipID clipID;

		protected double dspPlayStartTime;

		protected double estimatedSamplePosition;

		protected double expectedSamplePosition;

		protected FrameStats lastFrameStats;

		protected bool bDidLoop;

		protected int dspBufferSize;

		protected int dspBufferCount;

		protected int outputSampleRate;

		public static double EstimationWindowBufferCount
		{
			get
			{
				return S_EstimationWindowBufferCount;
			}
			set
			{
				AudioSettings.GetDSPBufferSize(out var _, out var numBuffers);
				if (value < 1.0)
				{
					Debug.LogError("Attempting to set the Estimation Window Buffer Count below 1 buffer in length. The minimum value is 1.");
					S_EstimationWindowBufferCount = 1.0;
				}
				else if (value > (double)(numBuffers * 2))
				{
					Debug.LogError("Attempting to set the Estimation Window Buffer Count above 2x the overall size of the Audio Ring Buffer. The maximum value in the current environment is " + numBuffers * 2 + ".");
					S_EstimationWindowBufferCount = numBuffers * 2;
				}
				else
				{
					S_EstimationWindowBufferCount = value;
				}
			}
		}

		public static double FuzzFactor
		{
			get
			{
				return S_FuzzFactor;
			}
			set
			{
				double num = 0.0;
				double num2 = 1.0;
				S_FuzzFactor = Clamp(value, num, num2);
				if (value != S_FuzzFactor)
				{
					Debug.LogError("Attempted to set the Fuzz Factor value out of range. Accepted values are between " + num + " and " + num2 + ". Current value is now: " + S_FuzzFactor + ".");
				}
			}
		}

		public static double OverEstimationPercent
		{
			get
			{
				return S_OverEstimationPercent;
			}
			set
			{
				double num = 0.0;
				double num2 = 1.0;
				S_OverEstimationPercent = Clamp(value, num, num2);
				if (value != S_OverEstimationPercent)
				{
					Debug.LogError("Attempted to set the Over Estimation Percent value out of the expected range. Accepted values are between " + num + " and " + num2 + ". Current value is now: " + S_OverEstimationPercent + ".");
				}
			}
		}

		public double ScheduledPlayTime
		{
			get
			{
				return dspPlayStartTime;
			}
			set
			{
				dspPlayStartTime = value;
			}
		}

		private AudioVisor()
		{
		}

		public AudioVisor(AudioSource sourceCom, Koreographer targetKoreographer = null)
		{
			koreographerCom = targetKoreographer;
			if (koreographerCom == null)
			{
				koreographerCom = Koreographer.Instance;
			}
			audioCom = sourceCom;
			if (audioCom == null)
			{
				NullReferenceException ex = new NullReferenceException("AudioVisor does not work with a null AudioSource.");
				throw ex;
			}
			AudioSettings.OnAudioConfigurationChanged += UpdateAudioConfiguration;
			UpdateAudioConfiguration(deviceChanged: false);
			lastFrameStats = GetFrameStats();
			sourceSampleTime = GetAudioSampleTime();
		}

		~AudioVisor()
		{
			AudioSettings.OnAudioConfigurationChanged -= UpdateAudioConfiguration;
		}

		public static double Clamp(double value, double min, double max)
		{
			return (value < min) ? min : ((!(value > max)) ? value : max);
		}

		private static double SmoothClamp(double value, double min, double max)
		{
			double num = (value - min) / (max - min);
			num = ((num <= 0.0) ? 0.0 : ((!(num >= 1.0)) ? (3.0 * Math.Pow(num, 2.0) - 2.0 * Math.Pow(num, 3.0)) : 1.0));
			return min + num * (max - min);
		}

		private static double GraviticClamp(double value, double min, double max)
		{
			double num = (value - min) / (max - min);
			num = ((num <= 0.0) ? 0.0 : ((!(num >= 1.0)) ? (num - (3.0 * Math.Pow(num, 2.0) - 2.0 * Math.Pow(num, 3.0) - num)) : 1.0));
			return min + num * (max - min);
		}

		public override void Update()
		{
			if (GetIsAudioPlaying())
			{
				ProcessUpdate();
				base.Update();
			}
		}

		private void ProcessUpdate()
		{
			FrameStats frameStats = GetFrameStats();
			bDidLoop = false;
			int num = frameStats.dspBufferCount - lastFrameStats.dspBufferCount;
			double bufferSampleLength = GetBufferSampleLength(frameStats.pitch);
			double bufferSampleLength2 = GetBufferSampleLength(lastFrameStats.pitch);
			int audioEndSampleExtent = GetAudioEndSampleExtent();
			int audioStartSampleExtent = GetAudioStartSampleExtent();
			int num2 = audioEndSampleExtent - audioStartSampleExtent + 1;
			double num3 = expectedSamplePosition + (double)num * Math.Max(bufferSampleLength, bufferSampleLength2);
			double num4 = ((!GetIsAudioLooping()) ? num3 : (num3 % (double)num2));
			double num5 = dspBufferCount;
			double num6 = Math.Max(bufferSampleLength, bufferSampleLength2) * (num5 + S_FuzzFactor);
			double num7 = num4 - num6;
			double num8 = num4 + num6;
			if ((num8 <= (double)num2 && ((double)frameStats.sourceSampleTime > num8 || (double)frameStats.sourceSampleTime < num7)) || (num8 > (double)num2 && frameStats.sourceSampleTime < lastFrameStats.sourceSampleTime && ((double)(frameStats.sourceSampleTime + num2) > num8 || (double)(frameStats.sourceSampleTime + num2) < num7)))
			{
				estimatedSamplePosition = frameStats.sourceSampleTime;
			}
			else
			{
				double num9 = bufferSampleLength * S_EstimationWindowBufferCount;
				double num10 = num9 * S_OverEstimationPercent;
				double num11 = num9 * (1.0 - S_OverEstimationPercent);
				double num12 = bufferSampleLength * S_FuzzFactor;
				num10 += num12;
				num11 += num12;
				double num13 = bufferSampleLength2 * (S_EstimationWindowBufferCount * S_OverEstimationPercent + S_FuzzFactor);
				double num14 = frameStats.sourceSampleTime;
				double num15 = estimatedSamplePosition + (double)GetRawFrameTime() * (double)audioCom.clip.frequency * (double)frameStats.pitch;
				if (num14 < estimatedSamplePosition)
				{
					if (num14 + num13 >= estimatedSamplePosition)
					{
						num15 = Clamp(num15, num14 - num11, num14 + num10);
					}
					else
					{
						num14 += (double)num2;
						num15 = Clamp(num15, num14 - num11, num14 + num10);
					}
				}
				else if (num14 > estimatedSamplePosition)
				{
					if (num14 + num13 >= estimatedSamplePosition + (double)num2)
					{
						num15 += (double)num2;
						num15 = Clamp(num15, num14 - num11, num14 + num10);
						num15 -= (double)num2;
					}
					else
					{
						num15 = Clamp(num15, num14 - num11, num14 + num10);
					}
				}
				else
				{
					num15 = Clamp(num15, num14 - num11, num14 + num10);
				}
				if (num15 >= (double)num2)
				{
					num15 -= (double)num2;
					bDidLoop = true;
				}
				estimatedSamplePosition = num15;
			}
			expectedSamplePosition = ((frameStats.sourceSampleTime != lastFrameStats.sourceSampleTime) ? ((double)frameStats.sourceSampleTime) : num4);
			lastFrameStats = frameStats;
		}

		public void ResyncTimings()
		{
			ResyncTimings(GetAudioSampleTime());
		}

		public void ResyncTimings(int targetSampleTime)
		{
			Mathf.Clamp(targetSampleTime, 0, GetAudioEndSampleExtent());
			sourceSampleTime = targetSampleTime;
			sampleTime = sourceSampleTime - 1;
			estimatedSamplePosition = targetSampleTime;
		}

		public int GetCurrentTimeInSamples()
		{
			return Mathf.Max(0, sampleTime);
		}

		private void UpdateAudioConfiguration(bool deviceChanged)
		{
			AudioSettings.GetDSPBufferSize(out dspBufferSize, out dspBufferCount);
			outputSampleRate = AudioSettings.outputSampleRate;
		}

		private double GetBufferSampleLength(float pitch)
		{
			double num = (double)dspBufferSize * ((double)audioCom.clip.frequency / (double)outputSampleRate);
			return num * (double)pitch;
		}

		private int GetTotalDSPBufferCount(double atTime = 0.0)
		{
			atTime = ((atTime != 0.0) ? atTime : AudioSettings.dspTime);
			return Convert.ToInt32((double)outputSampleRate * atTime / (double)dspBufferSize);
		}

		private FrameStats GetFrameStats()
		{
			FrameStats result = default(FrameStats);
			result.pitch = audioCom.pitch;
			result.sourceSampleTime = audioCom.timeSamples;
			result.dspBufferCount = GetTotalDSPBufferCount();
			return result;
		}

		protected override string GetAudioName()
		{
			int instanceID = audioCom.clip.GetInstanceID();
			if (instanceID != clipID.instanceID)
			{
				clipID.instanceID = instanceID;
				clipID.name = audioCom.clip.name;
			}
			return clipID.name;
		}

		protected override bool GetIsAudioPlaying()
		{
			return audioCom.isPlaying && dspPlayStartTime <= AudioSettings.dspTime;
		}

		protected override bool GetIsAudioLooping()
		{
			return audioCom.loop;
		}

		protected override bool GetDidAudioLoop()
		{
			return bDidLoop;
		}

		protected override int GetAudioSampleTime()
		{
			return Convert.ToInt32(estimatedSamplePosition);
		}

		protected override int GetAudioStartSampleExtent()
		{
			return 0;
		}

		protected override int GetAudioEndSampleExtent()
		{
			return audioCom.clip.samples - 1;
		}

		protected override int GetDeltaTimeInSamples()
		{
			return (int)((double)audioCom.clip.frequency * (double)audioCom.pitch * (double)GetRawFrameTime());
		}
	}
}
