using UnityEngine;
using UnityEngine.UI;

namespace KetosGames.SceneTransition
{
	public class LoadingBar : MonoBehaviour
	{
		private void Update()
		{
			GetComponent<Image>().fillAmount = SceneLoader.Instance.Progress;
		}
	}
}
