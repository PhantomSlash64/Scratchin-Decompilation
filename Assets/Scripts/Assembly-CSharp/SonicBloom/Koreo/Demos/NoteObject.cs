using UnityEngine;

namespace SonicBloom.Koreo.Demos
{
	[AddComponentMenu("Koreographer/Demos/Rhythm Game/Note Object")]
	public class NoteObject : MonoBehaviour
	{
		[Tooltip("The visual to use for this Note Object.")]
		public SpriteRenderer visuals;

		private KoreographyEvent trackedEvent;

		private LaneController laneController;

		private RhythmGameController gameController;

		private static Vector3 Lerp(Vector3 from, Vector3 to, float t)
		{
			return new Vector3(from.x + (to.x - from.x) * t, from.y + (to.y - from.y) * t, from.z + (to.z - from.z) * t);
		}

		public void Initialize(KoreographyEvent evt, Color color, LaneController laneCont, RhythmGameController gameCont)
		{
			trackedEvent = evt;
			visuals.color = color;
			laneController = laneCont;
			gameController = gameCont;
			UpdatePosition();
		}

		private void Reset()
		{
			trackedEvent = null;
			laneController = null;
			gameController = null;
		}

		private void Update()
		{
			UpdateHeight();
			UpdatePosition();
			if (base.transform.position.y <= laneController.DespawnY)
			{
				gameController.ReturnNoteObjectToPool(this);
				Reset();
			}
		}

		private void UpdateHeight()
		{
			float num = visuals.sprite.rect.height / visuals.sprite.pixelsPerUnit;
			float num2 = gameController.WindowSizeInUnits * 2f;
			Vector3 localScale = base.transform.localScale;
			localScale.y = num2 / num;
			base.transform.localScale = localScale;
		}

		private void UpdatePosition()
		{
			float num = (float)gameController.SampleRate / gameController.noteSpeed;
			Vector3 targetPosition = laneController.TargetPosition;
			targetPosition.y -= (float)(gameController.DelayedSampleTime - trackedEvent.StartSample) / num;
			base.transform.position = targetPosition;
		}

		public bool IsNoteHittable()
		{
			int startSample = trackedEvent.StartSample;
			int delayedSampleTime = gameController.DelayedSampleTime;
			int hitWindowSampleWidth = gameController.HitWindowSampleWidth;
			return Mathf.Abs(startSample - delayedSampleTime) <= hitWindowSampleWidth;
		}

		public bool IsNoteMissed()
		{
			bool result = true;
			if (base.enabled)
			{
				int startSample = trackedEvent.StartSample;
				int delayedSampleTime = gameController.DelayedSampleTime;
				int hitWindowSampleWidth = gameController.HitWindowSampleWidth;
				result = delayedSampleTime - startSample > hitWindowSampleWidth;
			}
			return result;
		}

		private void ReturnToPool()
		{
			gameController.ReturnNoteObjectToPool(this);
			Reset();
		}

		public void OnHit()
		{
			ReturnToPool();
		}

		public void OnClear()
		{
			ReturnToPool();
		}
	}
}
