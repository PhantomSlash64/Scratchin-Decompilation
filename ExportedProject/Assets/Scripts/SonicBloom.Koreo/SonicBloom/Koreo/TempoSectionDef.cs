using System;
using UnityEngine;

namespace SonicBloom.Koreo
{
	[Serializable]
	public class TempoSectionDef
	{
		[SerializeField]
		[Tooltip("The name of the Tempo Section.")]
		private string sectionName = "New Section";

		[SerializeField]
		[Tooltip("The sample position at which this Tempo Section begins.")]
		private int startSample;

		[SerializeField]
		[Tooltip("The number of samples in a beat for this Tempo Section.")]
		private double samplesPerBeat = 22050.0;

		[SerializeField]
		[Tooltip("The number of beats in a measure for this Tempo Section.")]
		private int beatsPerMeasure = 4;

		[SerializeField]
		[Tooltip("Whether or not this section forces the beginning of a new measure.")]
		private bool bStartNewMeasure = true;

		public string SectionName
		{
			get
			{
				return sectionName;
			}
			set
			{
				sectionName = value;
			}
		}

		public int StartSample
		{
			get
			{
				return startSample;
			}
			set
			{
				if (value < 0)
				{
					startSample = 0;
				}
				else
				{
					startSample = value;
				}
			}
		}

		public double SamplesPerBeat
		{
			get
			{
				return samplesPerBeat;
			}
			set
			{
				if (value <= 0.0)
				{
					samplesPerBeat = 1.0;
				}
				else
				{
					samplesPerBeat = value;
				}
			}
		}

		public int BeatsPerMeasure
		{
			get
			{
				return beatsPerMeasure;
			}
			set
			{
				if (value <= 0)
				{
					beatsPerMeasure = 1;
				}
				else
				{
					beatsPerMeasure = value;
				}
			}
		}

		public double SamplesPerMeasure => samplesPerBeat * (double)beatsPerMeasure;

		public bool DoesStartNewMeasure
		{
			get
			{
				return bStartNewMeasure;
			}
			set
			{
				bStartNewMeasure = value;
			}
		}

		public static int CompareByStartSample(TempoSectionDef first, TempoSectionDef second)
		{
			if (first.StartSample < second.StartSample)
			{
				return -1;
			}
			if (first.StartSample == second.StartSample)
			{
				return 0;
			}
			return 1;
		}

		public double GetSamplesPerBeatSection(int subdivisions = 1)
		{
			return SamplesPerBeat / (double)subdivisions;
		}

		public double GetBeatTimeFromSampleTime(int sampleTime, int subdivisions = 1)
		{
			double result = 0.0;
			if (sampleTime > startSample)
			{
				result = (double)(sampleTime - startSample) / GetSamplesPerBeatSection(subdivisions);
			}
			return result;
		}

		public double GetMeasureTimeFromSampleTime(int sampleTime)
		{
			return GetBeatTimeFromSampleTime(sampleTime) / (double)BeatsPerMeasure;
		}

		public double GetBPM(int sampleRate)
		{
			return (double)sampleRate / samplesPerBeat * 60.0;
		}
	}
}
