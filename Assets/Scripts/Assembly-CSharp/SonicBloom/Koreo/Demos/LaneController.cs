using System.Collections.Generic;
using UnityEngine;

namespace SonicBloom.Koreo.Demos
{
	[AddComponentMenu("Koreographer/Demos/Rhythm Game/Lane Controller")]
	public class LaneController : MonoBehaviour
	{
		[Tooltip("The Color of Note Objects and Buttons in this Lane.")]
		public Color color = Color.blue;

		[Tooltip("A reference to the visuals for the \"target\" location.")]
		public SpriteRenderer targetVisuals;

		[Tooltip("The Keyboard Button used by this lane.")]
		public KeyCode keyboardButton;

		[Tooltip("A list of Payload strings that Koreography Events will contain for this Lane.")]
		public List<string> matchedPayloads = new List<string>();

		private List<KoreographyEvent> laneEvents = new List<KoreographyEvent>();

		private Queue<NoteObject> trackedNotes = new Queue<NoteObject>();

		private RhythmGameController gameController;

		private float spawnY;

		private float despawnY;

		private int pendingEventIdx;

		private Vector3 defaultScale;

		private float scaleNormal = 1f;

		private float scalePress = 1.4f;

		private float scaleHold = 1.2f;

		public Vector3 SpawnPosition => new Vector3(base.transform.position.x, spawnY);

		public Vector3 TargetPosition => new Vector3(base.transform.position.x, base.transform.position.y);

		public float DespawnY => despawnY;

		public void Initialize(RhythmGameController controller)
		{
			gameController = controller;
		}

		public void Restart(int newSampleTime = 0)
		{
			for (int i = 0; i < laneEvents.Count; i++)
			{
				if (laneEvents[i].StartSample >= newSampleTime)
				{
					pendingEventIdx = i;
					break;
				}
			}
			int count = trackedNotes.Count;
			for (int j = 0; j < count; j++)
			{
				trackedNotes.Dequeue().OnClear();
			}
		}

		private void Start()
		{
			float z = 0f - Camera.main.transform.position.z;
			spawnY = Camera.main.ViewportToWorldPoint(new Vector3(0f, 1f, z)).y + 1f;
			despawnY = Camera.main.ViewportToWorldPoint(new Vector3(0f, 0f, z)).y - 1f;
			targetVisuals.color = color;
			defaultScale = targetVisuals.transform.localScale;
		}

		private void Update()
		{
			while (trackedNotes.Count > 0 && trackedNotes.Peek().IsNoteMissed())
			{
				trackedNotes.Dequeue();
			}
			CheckSpawnNext();
			if (Input.GetKeyDown(keyboardButton))
			{
				CheckNoteHit();
				SetScalePress();
			}
			else if (Input.GetKey(keyboardButton))
			{
				SetScaleHold();
			}
			else if (Input.GetKeyUp(keyboardButton))
			{
				SetScaleDefault();
			}
		}

		private void AdjustScale(float multiplier)
		{
			targetVisuals.transform.localScale = defaultScale * multiplier;
		}

		private int GetSpawnSampleOffset()
		{
			return (int)((double)(spawnY - base.transform.position.y) / (double)gameController.noteSpeed * (double)gameController.SampleRate);
		}

		public void CheckNoteHit()
		{
			if (trackedNotes.Count > 0 && trackedNotes.Peek().IsNoteHittable())
			{
				trackedNotes.Dequeue().OnHit();
			}
		}

		private void CheckSpawnNext()
		{
			int spawnSampleOffset = GetSpawnSampleOffset();
			int delayedSampleTime = gameController.DelayedSampleTime;
			while (pendingEventIdx < laneEvents.Count && laneEvents[pendingEventIdx].StartSample < delayedSampleTime + spawnSampleOffset)
			{
				KoreographyEvent evt = laneEvents[pendingEventIdx];
				NoteObject freshNoteObject = gameController.GetFreshNoteObject();
				freshNoteObject.Initialize(evt, color, this, gameController);
				trackedNotes.Enqueue(freshNoteObject);
				pendingEventIdx++;
			}
		}

		public void AddEventToLane(KoreographyEvent evt)
		{
			laneEvents.Add(evt);
		}

		public bool DoesMatchPayload(string payload)
		{
			bool result = false;
			for (int i = 0; i < matchedPayloads.Count; i++)
			{
				if (payload == matchedPayloads[i])
				{
					result = true;
					break;
				}
			}
			return result;
		}

		public void SetScaleDefault()
		{
			AdjustScale(scaleNormal);
		}

		public void SetScalePress()
		{
			AdjustScale(scalePress);
		}

		public void SetScaleHold()
		{
			AdjustScale(scaleHold);
		}
	}
}
