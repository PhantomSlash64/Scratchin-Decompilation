using UnityEngine;

namespace KetosGames.SceneTransition
{
	public class ChangeSceneFromClick : MonoBehaviour
	{
		public string ToScene;

		public void GoToNextScene()
		{
			SceneLoader.LoadScene(ToScene);
		}
	}
}
