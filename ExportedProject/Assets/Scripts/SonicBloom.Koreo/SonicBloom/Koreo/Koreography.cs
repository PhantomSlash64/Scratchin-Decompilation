using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

namespace SonicBloom.Koreo
{
	public class Koreography : ScriptableObject
	{
		[Tooltip("The AudioClip to which this Koreography refers.  Koreograhpy tracks should describe events matched to this AudioClip.")]
		[SerializeField]
		private AudioClip mSourceClip;

		[Tooltip("The URI of the location of the Audio file to use for this Koreography.")]
		[SerializeField]
		private string mAudioFilePath = string.Empty;

		[SerializeField]
		[Tooltip("The Sample Rate of the audio data that Koreography Tracks were authored against.")]
		private int mSampleRate = -1;

		[SerializeField]
		[Tooltip("Whether or not this Koreography should ignore any configured Latency/Delay Offset set on the Koreographer component.")]
		private bool mIgnoreLatencyOffset;

		[Tooltip("The Tempo Map for this Koreography that describes the tempo throughout the referenced AudioClip.")]
		[SerializeField]
		private List<TempoSectionDef> mTempoSections = new List<TempoSectionDef>(new TempoSectionDef[1]
		{
			new TempoSectionDef()
		});

		[SerializeField]
		[Tooltip("The Koreography Tracks associated with this Koreography.")]
		private List<KoreographyTrackBase> mTracks = new List<KoreographyTrackBase>();

		private string clipName;

		private int lastUpdateStart;

		private int lastUpdateEnd;

		public AudioClip SourceClip
		{
			get
			{
				return mSourceClip;
			}
			set
			{
				mSourceClip = value;
				mAudioFilePath = string.Empty;
				if (value == null)
				{
					clipName = string.Empty;
				}
				else
				{
					clipName = mSourceClip.name;
				}
			}
		}

		public string SourceClipPath
		{
			get
			{
				return mAudioFilePath;
			}
			set
			{
				mAudioFilePath = value;
				mSourceClip = null;
				clipName = Path.GetFileNameWithoutExtension(mAudioFilePath);
			}
		}

		public string SourceClipName
		{
			get
			{
				if (string.IsNullOrEmpty(clipName))
				{
					clipName = ((!(SourceClip != null)) ? Path.GetFileNameWithoutExtension(mAudioFilePath) : SourceClip.name);
				}
				return clipName;
			}
		}

		public int SampleRate
		{
			get
			{
				if (mSampleRate == -1 && mSourceClip != null)
				{
					mSampleRate = mSourceClip.frequency;
				}
				return mSampleRate;
			}
			set
			{
				if (mSampleRate != -1 && value != mSampleRate && mTracks.Count > 0)
				{
					Debug.LogWarning("Changing the Sample Rate may break KoreographyEvents in previously configured KoreographyTracks.  Please verify data in the Koreography Editor.");
				}
				mSampleRate = value;
			}
		}

		public bool IgnoreLatencyOffset
		{
			get
			{
				return mIgnoreLatencyOffset;
			}
			set
			{
				mIgnoreLatencyOffset = value;
			}
		}

		public List<KoreographyTrackBase> Tracks => new List<KoreographyTrackBase>(mTracks);

		public bool CheckTrackListIntegrity()
		{
			int count = mTracks.Count;
			mTracks.RemoveAll((KoreographyTrackBase track) => track == null);
			return count != mTracks.Count;
		}

		public bool CheckTempoSectionListIntegrity()
		{
			int count = mTempoSections.Count;
			mTempoSections.RemoveAll((TempoSectionDef section) => section == null);
			EnsureTempoSectionOrder();
			bool flag = false;
			if (mTempoSections[0].StartSample > 0)
			{
				mTempoSections[0].StartSample = 0;
				flag = true;
			}
			return flag || count != mTracks.Count;
		}

		public void OverwriteTempoSections(List<TempoSectionDef> newSections)
		{
			if (mTempoSections.Count > 0)
			{
				mTempoSections = newSections;
			}
			EnsureTempoSectionOrder();
			if (mTempoSections[0].StartSample != 0)
			{
				Debug.LogWarning("The new Tempo Sections don't start at 0.  This is required!  Overwriting.");
				mTempoSections[0].StartSample = 0;
			}
		}

		public int GetIndexOfTempoSection(TempoSectionDef sectionDef)
		{
			return mTempoSections.IndexOf(sectionDef);
		}

		public TempoSectionDef InsertTempoSectionAtIndex(int idxToInsert)
		{
			TempoSectionDef tempoSectionDef = null;
			if (idxToInsert >= 0 && idxToInsert <= mTempoSections.Count)
			{
				tempoSectionDef = new TempoSectionDef();
				if (idxToInsert == mTempoSections.Count)
				{
					mTempoSections.Add(tempoSectionDef);
				}
				else
				{
					mTempoSections.Insert(idxToInsert, tempoSectionDef);
				}
			}
			return tempoSectionDef;
		}

		public bool RemoveTempoSectionAtIndex(int idxToRemove)
		{
			bool result = false;
			if (mTempoSections.Count > 1 && idxToRemove < mTempoSections.Count)
			{
				mTempoSections.RemoveAt(idxToRemove);
				result = true;
				if (idxToRemove == 0)
				{
					mTempoSections[0].StartSample = 0;
				}
			}
			return result;
		}

		public bool RemoveTempoSection(TempoSectionDef sectionDef)
		{
			return RemoveTempoSectionAtIndex(GetIndexOfTempoSection(sectionDef));
		}

		public string[] GetTempoSectionNames()
		{
			return mTempoSections.Select((TempoSectionDef section) => section.SectionName).ToArray();
		}

		public TempoSectionDef GetTempoSectionAtIndex(int sectionIdx)
		{
			return (sectionIdx < 0 || sectionIdx >= mTempoSections.Count) ? null : mTempoSections[sectionIdx];
		}

		public int GetNumTempoSections()
		{
			return mTempoSections.Count;
		}

		public void EnsureTempoSectionOrder()
		{
			mTempoSections.Sort(TempoSectionDef.CompareByStartSample);
		}

		public bool CanAddTrack(KoreographyTrackBase track)
		{
			return !DoesTrackWithEventIDExist(track.EventID);
		}

		public bool AddTrack(KoreographyTrackBase track)
		{
			bool result = false;
			if (CanAddTrack(track))
			{
				mTracks.Add(track);
				result = true;
			}
			return result;
		}

		public void RemoveTrack(KoreographyTrackBase track)
		{
			mTracks.Remove(track);
		}

		public void RemoveTrack(string eventID)
		{
			mTracks.Remove(GetTrackByID(eventID));
		}

		public string[] GetEventIDs()
		{
			return (mTracks.Count > 0) ? mTracks.Select((KoreographyTrackBase track) => track.EventID).ToArray() : new string[1] { string.Empty };
		}

		public KoreographyTrackBase GetTrackByID(string eventID)
		{
			KoreographyTrackBase result = null;
			for (int i = 0; i < mTracks.Count; i++)
			{
				if (mTracks[i].EventID == eventID)
				{
					result = mTracks[i];
					break;
				}
			}
			return result;
		}

		public KoreographyTrackBase GetTrackAtIndex(int trackIdx)
		{
			return (trackIdx < 0 || trackIdx >= mTracks.Count) ? null : mTracks[trackIdx];
		}

		public int GetIndexOfTrack(KoreographyTrackBase track)
		{
			return mTracks.IndexOf(track);
		}

		public bool HasTrack(KoreographyTrackBase track)
		{
			return mTracks.Contains(track);
		}

		public int GetNumTracks()
		{
			return mTracks.Count;
		}

		public bool DoesTrackWithEventIDExist(string eventID)
		{
			return GetTrackByID(eventID) != null;
		}

		public void ResetTimings()
		{
			lastUpdateStart = 0;
			lastUpdateEnd = 0;
		}

		public float GetBeatTimeDelta(int subdivisions = 1)
		{
			int tempoSectionIndexForSample = GetTempoSectionIndexForSample(lastUpdateStart);
			int tempoSectionIndexForSample2 = GetTempoSectionIndexForSample(lastUpdateEnd);
			double num = 0.0;
			int startSample = lastUpdateStart;
			int i;
			for (i = tempoSectionIndexForSample; i < tempoSectionIndexForSample2; i++)
			{
				TempoSectionDef tempoSectionDef = mTempoSections[i + 1];
				TempoSectionDef tempoSectionDef2 = mTempoSections[i];
				num += (double)(tempoSectionDef.StartSample - startSample) / (tempoSectionDef2.SamplesPerBeat / (double)subdivisions);
				startSample = tempoSectionDef.StartSample;
			}
			num += (double)(lastUpdateEnd - startSample) / (mTempoSections[i].SamplesPerBeat / (double)(float)subdivisions);
			return (float)num;
		}

		public int GetLatestSampleTime()
		{
			return lastUpdateEnd;
		}

		public int GetLatestSampleTimeDelta()
		{
			return 1 + (lastUpdateEnd - lastUpdateStart);
		}

		[Obsolete("This method will be removed in an upcoming version.  Please update to use the more descriptive \"GetLatestSampleTimeDelta\" version.")]
		public int GetSampleTimeDelta()
		{
			return GetLatestSampleTimeDelta();
		}

		[Obsolete("Internal refactoring has made this \"Lite\" version obsolete.  Please use the main GetBeatTimeFromSampleTime version instead.")]
		public double GetBeatTimeFromSampleTimeLite(int sampleTime, int subdivisions = 1)
		{
			return GetBeatTimeFromSampleTime(sampleTime, subdivisions);
		}

		public double GetBeatTimeFromSampleTime(int sampleTime, int subdivisions = 1)
		{
			double num = 0.0;
			int tempoSectionIndexForSample = GetTempoSectionIndexForSample(sampleTime);
			TempoSectionDef tempoSectionDef = mTempoSections[0];
			for (int i = 1; i <= tempoSectionIndexForSample; i++)
			{
				TempoSectionDef tempoSectionDef2 = mTempoSections[i];
				num += tempoSectionDef.GetBeatTimeFromSampleTime(tempoSectionDef2.StartSample, subdivisions);
				if (tempoSectionDef2.DoesStartNewMeasure)
				{
					double num2 = num % 1.0;
					double num3 = 1.0 / tempoSectionDef.SamplesPerBeat;
					if (num2 >= num3 && 1.0 - num2 >= num3)
					{
						num = Math.Floor(num) + 1.0;
					}
				}
				tempoSectionDef = tempoSectionDef2;
			}
			return num + tempoSectionDef.GetBeatTimeFromSampleTime(sampleTime, subdivisions);
		}

		public int GetSampleTimeFromBeatTime(double beatTime, int subdivisions = 1)
		{
			int i = 1;
			int numTempoSections = GetNumTempoSections();
			double num = 0.0;
			TempoSectionDef tempoSectionDef = mTempoSections[0];
			for (; i < numTempoSections; i++)
			{
				TempoSectionDef tempoSectionDef2 = mTempoSections[i];
				double beatTimeFromSampleTime = tempoSectionDef.GetBeatTimeFromSampleTime(tempoSectionDef2.StartSample, subdivisions);
				if (beatTime <= num + beatTimeFromSampleTime)
				{
					break;
				}
				num += beatTimeFromSampleTime;
				if (tempoSectionDef2.DoesStartNewMeasure)
				{
					double num2 = num % 1.0;
					double num3 = 1.0 / tempoSectionDef.SamplesPerBeat;
					if (num2 >= num3 && 1.0 - num2 >= num3)
					{
						double num4 = Math.Floor(num) + 1.0 - num;
						if (beatTime <= num + num4)
						{
							num = beatTime;
							tempoSectionDef = tempoSectionDef2;
							break;
						}
						num += num4;
					}
				}
				tempoSectionDef = tempoSectionDef2;
			}
			beatTime -= num;
			return tempoSectionDef.StartSample + (int)(beatTime * tempoSectionDef.GetSamplesPerBeatSection(subdivisions));
		}

		public double GetMeasureTimeFromSampleTime(int sampleTime)
		{
			double num = 0.0;
			int tempoSectionIndexForSample = GetTempoSectionIndexForSample(sampleTime);
			TempoSectionDef tempoSectionDef = mTempoSections[0];
			for (int i = 1; i <= tempoSectionIndexForSample; i++)
			{
				TempoSectionDef tempoSectionDef2 = mTempoSections[i];
				num += tempoSectionDef.GetMeasureTimeFromSampleTime(tempoSectionDef2.StartSample);
				if (tempoSectionDef2.DoesStartNewMeasure)
				{
					double num2 = num % 1.0;
					double num3 = 1.0 / tempoSectionDef.SamplesPerMeasure;
					if (num2 >= num3 && 1.0 - num2 >= num3)
					{
						num = Math.Floor(num) + 1.0;
					}
				}
				tempoSectionDef = tempoSectionDef2;
			}
			return num + tempoSectionDef.GetMeasureTimeFromSampleTime(sampleTime);
		}

		public int GetSampleTimeFromMeasureTime(double measureTime)
		{
			int i = 1;
			int numTempoSections = GetNumTempoSections();
			double num = 0.0;
			TempoSectionDef tempoSectionDef = mTempoSections[0];
			for (; i < numTempoSections; i++)
			{
				TempoSectionDef tempoSectionDef2 = mTempoSections[i];
				double measureTimeFromSampleTime = tempoSectionDef.GetMeasureTimeFromSampleTime(tempoSectionDef2.StartSample);
				if (measureTime <= num + measureTimeFromSampleTime)
				{
					break;
				}
				num += measureTimeFromSampleTime;
				if (tempoSectionDef2.DoesStartNewMeasure)
				{
					double num2 = num % 1.0;
					double num3 = 1.0 / tempoSectionDef.SamplesPerMeasure;
					if (num2 >= num3 && 1.0 - num2 >= num3)
					{
						double num4 = Math.Floor(num) + 1.0 - num;
						if (measureTime <= num + num4)
						{
							num = measureTime;
							tempoSectionDef = tempoSectionDef2;
							break;
						}
						num += num4;
					}
				}
				tempoSectionDef = tempoSectionDef2;
			}
			measureTime -= num;
			return tempoSectionDef.StartSample + (int)(measureTime * ((double)tempoSectionDef.BeatsPerMeasure * tempoSectionDef.SamplesPerBeat));
		}

		public int GetSampleTimeFromMeasureTime(int measure)
		{
			return GetSampleTimeFromMeasureTime((double)measure);
		}

		public double GetBeatCountInMeasureFromSampleTime(int sampleTime)
		{
			double measureTimeFromSampleTime = GetMeasureTimeFromSampleTime(sampleTime);
			return measureTimeFromSampleTime % 1.0 * (double)GetTempoSectionForSample(sampleTime).BeatsPerMeasure;
		}

		public double GetSamplesPerBeat(int checkSample, int subdivisions = 1)
		{
			TempoSectionDef tempoSectionForSample = GetTempoSectionForSample(checkSample);
			return tempoSectionForSample.GetSamplesPerBeatSection(subdivisions);
		}

		public double GetBPM(int checkSample)
		{
			TempoSectionDef tempoSectionForSample = GetTempoSectionForSample(checkSample);
			return tempoSectionForSample.GetBPM(mSampleRate);
		}

		public int GetSampleOfNearestBeat(int checkSample, int subdivisions = 1)
		{
			double beatTimeFromSampleTime = GetBeatTimeFromSampleTime(checkSample, subdivisions);
			return GetSampleTimeFromBeatTime(Math.Round(beatTimeFromSampleTime), subdivisions);
		}

		public TempoSectionDef GetTempoSectionForSample(int checkSample)
		{
			int tempoSectionIndexForSample = GetTempoSectionIndexForSample(checkSample);
			return (tempoSectionIndexForSample < 0) ? null : mTempoSections[tempoSectionIndexForSample];
		}

		public int GetTempoSectionIndexForSample(int checkSample)
		{
			int result = -1;
			if (checkSample >= 0)
			{
				if (mTempoSections.Count == 1)
				{
					result = 0;
				}
				else
				{
					int i;
					for (i = 0; i < mTempoSections.Count && checkSample >= mTempoSections[i].StartSample; i++)
					{
					}
					result = i - 1;
				}
			}
			return result;
		}

		public void UpdateTrackTime(int startTime, int endTime, DeltaSlice deltaSlice)
		{
			lastUpdateStart = startTime;
			lastUpdateEnd = endTime;
			for (int i = 0; i < mTracks.Count; i++)
			{
				mTracks[i].CheckForEvents(startTime, endTime, deltaSlice);
			}
		}

		internal void RegisterForEvents(string eventDef, KoreographyEventCallback callback)
		{
			KoreographyTrackBase trackByID = GetTrackByID(eventDef);
			if (trackByID != null)
			{
				trackByID.RegisterForEvents(callback);
			}
			else
			{
				Debug.LogWarning("WARNING: no Koreography Track with event definition '" + eventDef + "' to register with.");
			}
		}

		internal void RegisterForEventsWithTime(string eventDef, KoreographyEventCallbackWithTime callback)
		{
			KoreographyTrackBase trackByID = GetTrackByID(eventDef);
			if (trackByID != null)
			{
				trackByID.RegisterForEventsWithTime(callback);
			}
			else
			{
				Debug.LogWarning("WARNING: no Koreography Track with event definition '" + eventDef + "' to register with.");
			}
		}

		internal void UnregisterForEvents(string eventDef, KoreographyEventCallback callback)
		{
			KoreographyTrackBase trackByID = GetTrackByID(eventDef);
			if (trackByID != null)
			{
				trackByID.UnregisterForEvents(callback);
			}
			else
			{
				Debug.LogWarning("WARNING: no Koreography Track with event definition '" + eventDef + "' to unregister from.");
			}
		}

		internal void UnregisterForEventsWithTime(string eventDef, KoreographyEventCallbackWithTime callback)
		{
			KoreographyTrackBase trackByID = GetTrackByID(eventDef);
			if (trackByID != null)
			{
				trackByID.UnregisterForEventsWithTime(callback);
			}
			else
			{
				Debug.LogWarning("WARNING: no Koreography Track with event definition '" + eventDef + "' to unregister from.");
			}
		}

		internal void ClearEventRegister()
		{
			for (int i = 0; i < mTracks.Count; i++)
			{
				mTracks[i].ClearEventRegister();
			}
		}
	}
}
