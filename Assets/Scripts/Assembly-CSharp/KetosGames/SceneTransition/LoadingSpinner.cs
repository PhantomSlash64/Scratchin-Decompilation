using UnityEngine;

namespace KetosGames.SceneTransition
{
	public class LoadingSpinner : MonoBehaviour
	{
		public float halfRotationTime = 0.5f;

		private Quaternion startRotation;

		private Quaternion targetRotation;

		private float timeCount;

		private void Start()
		{
			startRotation = Quaternion.AngleAxis(0f, Vector3.forward);
			targetRotation = Quaternion.AngleAxis(180f, Vector3.forward);
		}

		private void Update()
		{
			base.transform.rotation = Quaternion.Slerp(startRotation, targetRotation, timeCount / halfRotationTime);
			timeCount += Time.deltaTime;
			if (Quaternion.Angle(base.transform.rotation, targetRotation) < 1f)
			{
				base.transform.rotation = Quaternion.AngleAxis(0f, Vector3.forward);
				timeCount -= halfRotationTime;
			}
		}
	}
}
