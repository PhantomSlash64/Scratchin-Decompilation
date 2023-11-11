using System.Collections.Generic;
using UnityEngine;

namespace SonicBloom.Koreo.Demos
{
	[AddComponentMenu("Koreographer/Demos/Rhythm Game/Rhythm Game Controller")]
	public class RhythmGameController : MonoBehaviour
	{
		[Tooltip("The Event ID of the track to use for target generation.")]
		[EventID]
		public string eventID;

		[Tooltip("The number of milliseconds (both early and late) within which input will be detected as a Hit.")]
		[Range(8f, 150f)]
		public float hitWindowRangeInMS = 80f;

		[Tooltip("The number of units traversed per second by Note Objects.")]
		public float noteSpeed = 1f;

		[Tooltip("The archetype (blueprints) to use for generating notes.  Can be a prefab.")]
		public NoteObject noteObjectArchetype;

		[Tooltip("The list of Lane Controller objects that represent a lane for an event to travel down.")]
		public List<LaneController> noteLanes = new List<LaneController>();

		[Tooltip("The amount of time in seconds to provide before playback of the audio begins.  Changes to this value are not immediately handled during the lead-in phase while playing in the Editor.")]
		public float leadInTime;

		[Tooltip("The Audio Source through which the Koreographed audio will be played.  Be sure to disable 'Auto Play On Awake' in the Music Player.")]
		public AudioSource audioCom;

		private float leadInTimeLeft;

		private float timeLeftToPlay;

		private Koreography playingKoreo;

		private int hitWindowRangeInSamples;

		private Stack<NoteObject> noteObjectPool = new Stack<NoteObject>();

		public int HitWindowSampleWidth => hitWindowRangeInSamples;

		public float WindowSizeInUnits => noteSpeed * (hitWindowRangeInMS * 0.001f);

		public int SampleRate => playingKoreo.SampleRate;

		public int DelayedSampleTime => playingKoreo.GetLatestSampleTime() - (int)(audioCom.pitch * leadInTimeLeft * (float)SampleRate);

		private void Start()
		{
			InitializeLeadIn();
			for (int i = 0; i < noteLanes.Count; i++)
			{
				noteLanes[i].Initialize(this);
			}
			playingKoreo = Koreographer.Instance.GetKoreographyAtIndex(0);
			List<KoreographyEvent> allEvents = playingKoreo.GetTrackByID(eventID).GetAllEvents();
			for (int j = 0; j < allEvents.Count; j++)
			{
				KoreographyEvent koreographyEvent = allEvents[j];
				string textValue = koreographyEvent.GetTextValue();
				for (int k = 0; k < noteLanes.Count; k++)
				{
					LaneController laneController = noteLanes[k];
					if (laneController.DoesMatchPayload(textValue))
					{
						laneController.AddEventToLane(koreographyEvent);
						break;
					}
				}
			}
		}

		private void InitializeLeadIn()
		{
			if (leadInTime > 0f)
			{
				leadInTimeLeft = leadInTime;
				timeLeftToPlay = leadInTime - Koreographer.Instance.EventDelayInSeconds;
			}
			else
			{
				audioCom.time = 0f - leadInTime;
				audioCom.Play();
			}
		}

		private void Update()
		{
			UpdateInternalValues();
			if (leadInTimeLeft > 0f)
			{
				leadInTimeLeft = Mathf.Max(leadInTimeLeft - Time.unscaledDeltaTime, 0f);
			}
			if (timeLeftToPlay > 0f)
			{
				timeLeftToPlay -= Time.unscaledDeltaTime;
				if (timeLeftToPlay <= 0f)
				{
					audioCom.time = 0f - timeLeftToPlay;
					audioCom.Play();
					timeLeftToPlay = 0f;
				}
			}
		}

		private void UpdateInternalValues()
		{
			hitWindowRangeInSamples = (int)(0.001f * hitWindowRangeInMS * (float)SampleRate);
		}

		public NoteObject GetFreshNoteObject()
		{
			NoteObject noteObject = ((noteObjectPool.Count <= 0) ? Object.Instantiate(noteObjectArchetype) : noteObjectPool.Pop());
			noteObject.gameObject.SetActive(value: true);
			noteObject.enabled = true;
			return noteObject;
		}

		public void ReturnNoteObjectToPool(NoteObject obj)
		{
			if (obj != null)
			{
				obj.enabled = false;
				obj.gameObject.SetActive(value: false);
				noteObjectPool.Push(obj);
			}
		}

		public void Restart()
		{
			audioCom.Stop();
			audioCom.time = 0f;
			Koreographer.Instance.FlushDelayQueue(playingKoreo);
			playingKoreo.ResetTimings();
			for (int i = 0; i < noteLanes.Count; i++)
			{
				noteLanes[i].Restart();
			}
			InitializeLeadIn();
		}
	}
}
