using System;
using System.Collections.Generic;
using UnityEngine;

namespace SonicBloom.Koreo
{
	[Serializable]
	[NoEditorCreate]
	public class SpectrumPayload : IPayload
	{
		[Serializable]
		public struct SpectrumInfo
		{
			[Tooltip("The frequency difference between consecutive bins.")]
			public float binFrequencyWidth;

			[Tooltip("The frequency of the bin at index zero.")]
			public float minBinFrequency;

			[Tooltip("The sample position of the first spectrum.")]
			public int startSample;

			[Tooltip("The sample position of the last spectrum.")]
			public int endSample;

			public float GetFrequencyForBin(int binIndex)
			{
				float result = 0f;
				if (binIndex > 0)
				{
					result = minBinFrequency + binFrequencyWidth * (float)binIndex;
				}
				return result;
			}
		}

		[Serializable]
		public class Spectrum
		{
			public List<float> data = new List<float>();
		}

		[SerializeField]
		[Tooltip("Metadata describing the spectra.")]
		private SpectrumInfo mSpectrumInfo;

		[Tooltip("The spectrum values that make up the payload.")]
		[SerializeField]
		private List<Spectrum> mSpectrumData = new List<Spectrum>();

		public List<Spectrum> SpectrumData
		{
			get
			{
				return mSpectrumData;
			}
			set
			{
				mSpectrumData = value;
			}
		}

		public SpectrumInfo SpectrumDataInfo
		{
			get
			{
				return mSpectrumInfo;
			}
			set
			{
				mSpectrumInfo = value;
			}
		}

		public int SpectrumEntryCount
		{
			get
			{
				int result = 0;
				if (mSpectrumData != null && mSpectrumData[0] != null)
				{
					result = mSpectrumData[0].data.Count;
				}
				return result;
			}
		}

		public static string GetFriendlyName()
		{
			return "Spectrum";
		}

		public void GetSpectrumAtDelta(ref float[] spectrum, float delta, int maxBinCount = 0)
		{
			float num = delta * (float)(mSpectrumData.Count - 1);
			int num2 = Mathf.FloorToInt(num);
			int index = Mathf.CeilToInt(num);
			List<float> data = mSpectrumData[num2].data;
			List<float> data2 = mSpectrumData[index].data;
			float t = num - (float)num2;
			int spectrumEntryCount = SpectrumEntryCount;
			int num3 = Mathf.Min(spectrumEntryCount, maxBinCount);
			if (num3 <= 0 || num3 == spectrumEntryCount)
			{
				int num4 = spectrumEntryCount;
				if (spectrum == null || spectrum.Length != num4)
				{
					spectrum = new float[num4];
				}
				for (int i = 0; i < num4; i++)
				{
					spectrum[i] = Mathf.Lerp(data[i], data2[i], t);
				}
				return;
			}
			int num5 = Mathf.CeilToInt((float)spectrumEntryCount / (float)num3);
			float f = (float)spectrumEntryCount / (float)num5;
			int num6 = Mathf.CeilToInt(f);
			int num7 = Mathf.FloorToInt(f);
			if (spectrum == null || spectrum.Length != num6)
			{
				spectrum = new float[num6];
			}
			int num8 = 0;
			int num9 = 0;
			while (num9 < num7)
			{
				float num10 = 0f;
				for (int j = 0; j < num5; j++)
				{
					num10 += Mathf.Lerp(data[num8 + j], data2[num8 + j], t);
				}
				spectrum[num9] = num10 / (float)num5;
				num9++;
				num8 += num5;
			}
			if (num8 < spectrumEntryCount)
			{
				float num11 = 0f;
				int num12 = 0;
				while (num8 < spectrumEntryCount)
				{
					num11 += Mathf.Lerp(data[num8], data2[num8], t);
					num8++;
					num12++;
				}
				spectrum[num9] = num11 / (float)num12;
			}
		}

		public void GetSpectrumAtSample(ref float[] spectrum, int sample, int maxBinCount = 0)
		{
			GetSpectrumAtDelta(ref spectrum, Mathf.InverseLerp(mSpectrumInfo.startSample, mSpectrumInfo.endSample, sample), maxBinCount);
		}

		public IPayload GetCopy()
		{
			SpectrumPayload spectrumPayload = new SpectrumPayload();
			spectrumPayload.SpectrumDataInfo = mSpectrumInfo;
			spectrumPayload.SpectrumData = new List<Spectrum>();
			for (int i = 0; i < mSpectrumData.Count; i++)
			{
				Spectrum spectrum = new Spectrum();
				spectrum.data.AddRange(mSpectrumData[i].data);
				spectrumPayload.SpectrumData.Add(spectrum);
			}
			return spectrumPayload;
		}
	}
}
