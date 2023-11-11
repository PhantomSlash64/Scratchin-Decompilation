using System;
using System.Collections.Generic;
using UnityEngine;

namespace SonicBloom.Koreo
{
	[AddComponentMenu("Koreographer/Koreographer")]
	public class Koreographer : MonoBehaviour
	{
		private static Koreographer _instance;

		public IKoreographedPlayer musicPlaybackController;

		[SerializeField]
		[Tooltip("Koreography that should be auto-loaded by this Koreographer at start.")]
		private List<Koreography> loadedKoreography = new List<Koreography>();

		[SerializeField]
		[Tooltip("The amount of time in seconds that event processing should be delayed.")]
		private float eventDelayInSeconds;

		private List<KeyValuePair<Koreography, List<TimingRecord>>> delayQueue = new List<KeyValuePair<Koreography, List<TimingRecord>>>();

		private List<KeyValuePair<string, EventObj>> eventBoard = new List<KeyValuePair<string, EventObj>>();

		private List<Koreography> koreographyToProcess = new List<Koreography>();

		private List<KoreographyTrackBase> trackProcessingHelper;

		public static Koreographer Instance => _instance;

		public float EventDelayInSeconds
		{
			get
			{
				return eventDelayInSeconds;
			}
			set
			{
				eventDelayInSeconds = Mathf.Max(0f, value);
			}
		}

		private void Awake()
		{
			_instance = this;
			eventDelayInSeconds = Mathf.Max(0f, eventDelayInSeconds);
			for (int i = 0; i < loadedKoreography.Count; i++)
			{
				loadedKoreography[i].ResetTimings();
			}
		}

		private void OnDestroy()
		{
			ClearEventRegister();
			if (_instance == this)
			{
				_instance = null;
			}
		}

		private void Update()
		{
			if (delayQueue.Count > 0)
			{
				ProcessDelayQueue(Time.unscaledDeltaTime);
			}
		}

		[Obsolete("Please use Koreographer.ProcessKoreography instead.  This method will disappear in a future release.", false)]
		public void ProcessChoreography(AudioClip clip, int startTime, int endTime, DeltaSlice deltaSlice)
		{
			ProcessKoreography(clip.name, startTime, endTime, deltaSlice);
		}

		public void ProcessKoreography(string clipName, int startTime, int endTime, DeltaSlice deltaSlice)
		{
			if (koreographyToProcess.Count > 0)
			{
				Debug.LogWarning("Beginning to Process Koreography with a list of Koreography that should have been processed. Please check that you are not calling ProcessKoreography during another ProcessKoreography pass.  Alternatively, please verify that an Exception did not occur during the previous attempt to Process Koreography.");
				koreographyToProcess.Clear();
			}
			for (int i = 0; i < loadedKoreography.Count; i++)
			{
				koreographyToProcess.Add(loadedKoreography[i]);
			}
			if (eventDelayInSeconds > 0f)
			{
				for (int num = koreographyToProcess.Count - 1; num >= 0; num--)
				{
					Koreography koreography = koreographyToProcess[num];
					if (koreography.SourceClipName == clipName)
					{
						if (!koreography.IgnoreLatencyOffset)
						{
							AddRecordToDelayQueue(koreography, startTime, endTime, deltaSlice);
						}
						else
						{
							koreography.UpdateTrackTime(startTime, endTime, deltaSlice);
						}
					}
				}
			}
			else
			{
				for (int num2 = koreographyToProcess.Count - 1; num2 >= 0; num2--)
				{
					Koreography koreography2 = koreographyToProcess[num2];
					if (koreography2.SourceClipName == clipName)
					{
						koreography2.UpdateTrackTime(startTime, endTime, deltaSlice);
					}
				}
			}
			koreographyToProcess.Clear();
		}

		private void AddRecordToDelayQueue(Koreography koreo, int startTime, int endTime, DeltaSlice deltaSlice)
		{
			int i;
			for (i = 0; i < delayQueue.Count && !(delayQueue[i].Key == koreo); i++)
			{
			}
			if (i == delayQueue.Count)
			{
				delayQueue.Add(new KeyValuePair<Koreography, List<TimingRecord>>(koreo, new List<TimingRecord>()));
			}
			TimingRecord timingRecord = default(TimingRecord);
			timingRecord.playTime = deltaSlice.deltaLength;
			timingRecord.timeLeft = deltaSlice.deltaLength + eventDelayInSeconds + Time.unscaledDeltaTime * deltaSlice.deltaOffset;
			timingRecord.startSample = startTime;
			timingRecord.endSample = endTime;
			TimingRecord item = timingRecord;
			delayQueue[i].Value.Add(item);
		}

		private void ProcessDelayQueue(double timeToProcess)
		{
			DeltaSlice deltaSlice = default(DeltaSlice);
			for (int num = delayQueue.Count - 1; num >= 0; num--)
			{
				KeyValuePair<Koreography, List<TimingRecord>> keyValuePair = delayQueue[num];
				List<TimingRecord> value = keyValuePair.Value;
				int num2 = 0;
				deltaSlice.deltaLength = (float)timeToProcess;
				deltaSlice.deltaOffset = 0f;
				double num3 = 0.0;
				for (int i = 0; i < value.Count; i++)
				{
					TimingRecord value2 = value[i];
					value2.timeLeft -= timeToProcess;
					if (value2.timeLeft < 0.0)
					{
						value2.timeLeft = 0.0;
					}
					if (value2.timeLeft < value2.playTime)
					{
						double num4 = value2.playTime - value2.timeLeft;
						double num5 = value2.endSample - value2.startSample;
						int num6 = value2.startSample + (int)(num5 * (num4 / value2.playTime));
						if (num6 == value2.startSample)
						{
							num6++;
						}
						if (value2.endSample - num6 == 1)
						{
							num6++;
							value2.timeLeft = 0.0;
						}
						deltaSlice.deltaLength = (float)num4;
						keyValuePair.Key.UpdateTrackTime(value2.startSample, num6, deltaSlice);
						num3 += num4;
						deltaSlice.deltaOffset += Mathf.Clamp01((float)(num3 / timeToProcess));
						if (value2.timeLeft > 0.0)
						{
							value2.playTime = value2.timeLeft;
							value2.startSample = num6 + 1;
						}
						else
						{
							num2++;
						}
					}
					value[i] = value2;
				}
				value.RemoveRange(0, num2);
				if (value.Count == 0 && !IsKoreographyLoaded(keyValuePair.Key))
				{
					delayQueue.RemoveAt(num);
				}
			}
		}

		public bool FlushDelayQueue(Koreography targetKoreography)
		{
			bool result = false;
			for (int i = 0; i < delayQueue.Count; i++)
			{
				KeyValuePair<Koreography, List<TimingRecord>> item = delayQueue[i];
				if (item.Key == targetKoreography)
				{
					delayQueue.Remove(item);
					result = true;
					break;
				}
			}
			return result;
		}

		public void LoadKoreography(Koreography koreo)
		{
			if (!(koreo != null) || loadedKoreography.Contains(koreo))
			{
				return;
			}
			for (int i = 0; i < eventBoard.Count; i++)
			{
				KeyValuePair<string, EventObj> keyValuePair = eventBoard[i];
				if (koreo.DoesTrackWithEventIDExist(keyValuePair.Key))
				{
					koreo.RegisterForEventsWithTime(keyValuePair.Key, keyValuePair.Value.Trigger);
				}
			}
			koreo.ResetTimings();
			loadedKoreography.Add(koreo);
		}

		public void UnloadKoreography(Koreography koreo)
		{
			if (!(koreo != null) || !loadedKoreography.Contains(koreo))
			{
				return;
			}
			for (int i = 0; i < eventBoard.Count; i++)
			{
				KeyValuePair<string, EventObj> keyValuePair = eventBoard[i];
				if (koreo.DoesTrackWithEventIDExist(keyValuePair.Key))
				{
					koreo.UnregisterForEventsWithTime(keyValuePair.Key, keyValuePair.Value.Trigger);
				}
			}
			loadedKoreography.Remove(koreo);
		}

		public bool IsKoreographyLoaded(Koreography koreo)
		{
			return loadedKoreography.Contains(koreo);
		}

		public int GetNumLoadedKoreography()
		{
			return loadedKoreography.Count;
		}

		public Koreography GetKoreographyAtIndex(int index)
		{
			return (index < 0 || index >= loadedKoreography.Count) ? null : loadedKoreography[index];
		}

		public void GetAllLoadedKoreography(List<Koreography> listToFill)
		{
			listToFill.AddRange(loadedKoreography);
		}

		private KeyValuePair<string, EventObj> FindMappingWithEventID(string eventID)
		{
			KeyValuePair<string, EventObj> result = default(KeyValuePair<string, EventObj>);
			for (int i = 0; i < eventBoard.Count; i++)
			{
				if (eventBoard[i].Key == eventID)
				{
					return eventBoard[i];
				}
			}
			return result;
		}

		public void RegisterForEvents(string eventID, KoreographyEventCallback callback)
		{
			if (string.IsNullOrEmpty(eventID))
			{
				Debug.LogError("Cannot register for events with an empty event identifier!");
				return;
			}
			KeyValuePair<string, EventObj> keyValuePair = FindMappingWithEventID(eventID);
			if (string.IsNullOrEmpty(keyValuePair.Key))
			{
				keyValuePair = new KeyValuePair<string, EventObj>(eventID, new EventObj());
				eventBoard.Add(keyValuePair);
				ConnectEventToLoadedKoreography(keyValuePair);
			}
			keyValuePair.Value.Register(callback);
		}

		public void RegisterForEventsWithTime(string eventID, KoreographyEventCallbackWithTime callback)
		{
			if (string.IsNullOrEmpty(eventID))
			{
				Debug.LogError("Cannot register for events with an empty event identifier!");
				return;
			}
			KeyValuePair<string, EventObj> keyValuePair = FindMappingWithEventID(eventID);
			if (string.IsNullOrEmpty(keyValuePair.Key))
			{
				keyValuePair = new KeyValuePair<string, EventObj>(eventID, new EventObj());
				eventBoard.Add(keyValuePair);
				ConnectEventToLoadedKoreography(keyValuePair);
			}
			keyValuePair.Value.Register(callback);
		}

		public void UnregisterForEvents(string eventID, KoreographyEventCallback callback)
		{
			if (string.IsNullOrEmpty(eventID))
			{
				Debug.LogError("Cannot unregister for events with an empty event identifier!");
				return;
			}
			KeyValuePair<string, EventObj> keyValuePair = FindMappingWithEventID(eventID);
			if (!string.IsNullOrEmpty(keyValuePair.Key))
			{
				keyValuePair.Value.Unregister(callback);
				if (keyValuePair.Value.IsClear())
				{
					DisconnectEventFromLoadedKoreography(keyValuePair);
					eventBoard.Remove(keyValuePair);
				}
			}
		}

		public void UnregisterForEvents(string eventID, KoreographyEventCallbackWithTime callback)
		{
			if (string.IsNullOrEmpty(eventID))
			{
				Debug.LogError("Cannot unregister for events with an empty event identifier!");
				return;
			}
			KeyValuePair<string, EventObj> keyValuePair = FindMappingWithEventID(eventID);
			if (!string.IsNullOrEmpty(keyValuePair.Key))
			{
				keyValuePair.Value.Unregister(callback);
				if (keyValuePair.Value.IsClear())
				{
					DisconnectEventFromLoadedKoreography(keyValuePair);
					eventBoard.Remove(keyValuePair);
				}
			}
		}

		public void UnregisterForAllEvents(object obj)
		{
			for (int num = eventBoard.Count - 1; num >= 0; num--)
			{
				KeyValuePair<string, EventObj> keyValuePair = eventBoard[num];
				keyValuePair.Value.UnregisterByObject(obj);
				if (keyValuePair.Value.IsClear())
				{
					DisconnectEventFromLoadedKoreography(keyValuePair);
					eventBoard.Remove(keyValuePair);
				}
			}
		}

		public void ClearEventRegister()
		{
			for (int i = 0; i < eventBoard.Count; i++)
			{
				KeyValuePair<string, EventObj> mapping = eventBoard[i];
				mapping.Value.ClearRegistrations();
				DisconnectEventFromLoadedKoreography(mapping);
			}
			eventBoard.Clear();
		}

		private void ConnectEventToLoadedKoreography(KeyValuePair<string, EventObj> mapping)
		{
			for (int i = 0; i < loadedKoreography.Count; i++)
			{
				Koreography koreography = loadedKoreography[i];
				if (koreography.DoesTrackWithEventIDExist(mapping.Key))
				{
					koreography.RegisterForEventsWithTime(mapping.Key, mapping.Value.Trigger);
				}
			}
		}

		private void DisconnectEventFromLoadedKoreography(KeyValuePair<string, EventObj> mapping)
		{
			for (int i = 0; i < loadedKoreography.Count; i++)
			{
				Koreography koreography = loadedKoreography[i];
				if (koreography.DoesTrackWithEventIDExist(mapping.Key))
				{
					koreography.UnregisterForEventsWithTime(mapping.Key, mapping.Value.Trigger);
				}
			}
		}

		[Obsolete("This method will be removed in a future version.  Please use GetAllEventsInRange(string, string, int, int, List) instead.")]
		public List<KoreographyEvent> GetAllEventsInRange(string clipName, string eventID, int startPos, int endPos)
		{
			List<KoreographyEvent> list = new List<KoreographyEvent>();
			GetAllEventsInRange(clipName, eventID, startPos, endPos, list);
			return list;
		}

		public void GetAllEventsInRange(string clipName, string eventID, int startPos, int endPos, List<KoreographyEvent> listToFill)
		{
			if (trackProcessingHelper == null)
			{
				trackProcessingHelper = new List<KoreographyTrackBase>();
			}
			for (int i = 0; i < loadedKoreography.Count; i++)
			{
				Koreography koreography = loadedKoreography[i];
				if (koreography.SourceClipName == clipName)
				{
					KoreographyTrackBase trackByID = koreography.GetTrackByID(eventID);
					if (trackByID != null && !trackProcessingHelper.Contains(trackByID))
					{
						trackByID.GetEventsInRange(startPos, endPos, listToFill);
						trackProcessingHelper.Add(trackByID);
					}
				}
			}
			trackProcessingHelper.Clear();
		}

		public int GetMusicSampleRate(string clipName = null)
		{
			int result = 44100;
			Koreography musicKoreographyWithAudioName = GetMusicKoreographyWithAudioName(clipName);
			if (musicKoreographyWithAudioName != null)
			{
				result = musicKoreographyWithAudioName.SampleRate;
			}
			return result;
		}

		public int GetMusicSampleLength(string clipName = null)
		{
			int result = 0;
			if (musicPlaybackController != null)
			{
				if (string.IsNullOrEmpty(clipName))
				{
					clipName = musicPlaybackController.GetCurrentClipName();
				}
				if (!string.IsNullOrEmpty(clipName))
				{
					result = musicPlaybackController.GetTotalSampleTimeForClip(clipName);
				}
			}
			return result;
		}

		public int GetMusicSampleTime(string clipName = null)
		{
			int result = -1;
			Koreography musicKoreographyWithAudioName = GetMusicKoreographyWithAudioName(clipName);
			if (musicKoreographyWithAudioName != null)
			{
				result = musicKoreographyWithAudioName.GetLatestSampleTime();
			}
			return result;
		}

		public int GetMusicSampleTimeDelta(string clipName = null)
		{
			int result = 0;
			Koreography musicKoreographyWithAudioName = GetMusicKoreographyWithAudioName(clipName);
			if (musicKoreographyWithAudioName != null)
			{
				result = musicKoreographyWithAudioName.GetLatestSampleTimeDelta();
			}
			return result;
		}

		public double GetMusicSecondsLength(string clipName = null)
		{
			double result = 0.0;
			Koreography musicKoreographyWithAudioName = GetMusicKoreographyWithAudioName(clipName);
			if (musicKoreographyWithAudioName != null)
			{
				result = (double)GetMusicSampleLength(clipName) / (double)musicKoreographyWithAudioName.SampleRate;
			}
			return result;
		}

		public double GetMusicSecondsTime(string clipName = null)
		{
			double result = -1.0;
			Koreography musicKoreographyWithAudioName = GetMusicKoreographyWithAudioName(clipName);
			if (musicKoreographyWithAudioName != null)
			{
				result = (double)musicKoreographyWithAudioName.GetLatestSampleTime() / (double)musicKoreographyWithAudioName.SampleRate;
			}
			return result;
		}

		public double GetMusicSecondsTimeDelta(string clipName = null)
		{
			double result = 0.0;
			Koreography musicKoreographyWithAudioName = GetMusicKoreographyWithAudioName(clipName);
			if (musicKoreographyWithAudioName != null)
			{
				result = (double)musicKoreographyWithAudioName.GetLatestSampleTimeDelta() / (double)musicKoreographyWithAudioName.SampleRate;
			}
			return result;
		}

		public double GetMusicBPM(string clipName = null)
		{
			double result = 0.0;
			Koreography musicKoreographyWithAudioName = GetMusicKoreographyWithAudioName(clipName);
			if (musicKoreographyWithAudioName != null)
			{
				int latestSampleTime = musicKoreographyWithAudioName.GetLatestSampleTime();
				result = musicKoreographyWithAudioName.GetBPM(latestSampleTime);
			}
			return result;
		}

		public double GetMusicBeatLength(string clipName = null, int subdivisions = 1)
		{
			double result = 0.0;
			Koreography musicKoreographyWithAudioName = GetMusicKoreographyWithAudioName(clipName);
			if (musicKoreographyWithAudioName != null)
			{
				int totalSampleTime = GetTotalSampleTime(clipName);
				result = musicKoreographyWithAudioName.GetBeatTimeFromSampleTime(totalSampleTime, subdivisions);
			}
			return result;
		}

		public double GetMusicBeatTime(string clipName = null, int subdivisions = 1)
		{
			double result = -1.0;
			Koreography musicKoreographyWithAudioName = GetMusicKoreographyWithAudioName(clipName);
			if (musicKoreographyWithAudioName != null)
			{
				int latestSampleTime = musicKoreographyWithAudioName.GetLatestSampleTime();
				result = musicKoreographyWithAudioName.GetBeatTimeFromSampleTime(latestSampleTime, subdivisions);
			}
			return result;
		}

		public double GetMusicBeatTimeDelta(string clipName = null, int subdivisions = 1)
		{
			double result = 0.0;
			Koreography musicKoreographyWithAudioName = GetMusicKoreographyWithAudioName(clipName);
			if (musicKoreographyWithAudioName != null)
			{
				result = musicKoreographyWithAudioName.GetBeatTimeDelta(subdivisions);
			}
			return result;
		}

		public double GetMusicBeatTimeNormalized(string clipName = null, int subdivisions = 1)
		{
			return GetMusicBeatTime(clipName, subdivisions) % 1.0;
		}

		protected Koreography GetMusicKoreographyWithAudioName(string clipName)
		{
			Koreography result = null;
			if (musicPlaybackController != null)
			{
				if (string.IsNullOrEmpty(clipName))
				{
					clipName = musicPlaybackController.GetCurrentClipName();
				}
				if (!string.IsNullOrEmpty(clipName))
				{
					result = GetLoadedKoreographyWithAudioName(clipName);
				}
			}
			return result;
		}

		protected Koreography GetLoadedKoreographyWithAudioName(string clipName)
		{
			Koreography result = null;
			for (int i = 0; i < loadedKoreography.Count; i++)
			{
				Koreography koreography = loadedKoreography[i];
				if (koreography.SourceClipName == clipName)
				{
					result = koreography;
					break;
				}
			}
			return result;
		}

		public static int GetSampleRate(string clipName = null)
		{
			Koreographer instance = Instance;
			int result = 44100;
			if (instance != null)
			{
				result = instance.GetMusicSampleRate(clipName);
			}
			return result;
		}

		public static int GetTotalSampleTime(string clipName = null)
		{
			Koreographer instance = Instance;
			int result = 0;
			if (instance != null)
			{
				result = instance.GetMusicSampleLength(clipName);
			}
			return result;
		}

		public static int GetSampleTime(string clipName = null)
		{
			Koreographer instance = Instance;
			int result = -1;
			if (instance != null)
			{
				result = instance.GetMusicSampleTime(clipName);
			}
			return result;
		}

		public static float GetBeatTime(string clipName = null, int subdivisions = 1)
		{
			Koreographer instance = Instance;
			float result = -1f;
			if (instance != null)
			{
				result = (float)instance.GetMusicBeatTime(clipName, subdivisions);
			}
			return result;
		}

		public static float GetBeatTimeDelta(string clipName = null, int subdivisions = 1)
		{
			Koreographer instance = Instance;
			float result = 0f;
			if (instance != null)
			{
				result = (float)instance.GetMusicBeatTimeDelta(clipName, subdivisions);
			}
			return result;
		}

		public static float GetBeatTimeNormalized(string clipName = null, int subdivisions = 1)
		{
			Koreographer instance = Instance;
			float result = 0f;
			if (instance != null)
			{
				result = (float)instance.GetMusicBeatTimeNormalized(clipName, subdivisions);
			}
			return result;
		}
	}
}
