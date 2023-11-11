using UnityEngine;

namespace KetosGames.SceneTransition
{
	public class ChangeSceneFromTrigger : MonoBehaviour
	{
		public string ChangeToScene;

		public GameObject WhenTriggeredBy;

		private void OnTriggerEnter(Collider other)
		{
			if (other.gameObject == WhenTriggeredBy)
			{
				SceneLoader.LoadScene(ChangeToScene);
			}
		}
	}
}
