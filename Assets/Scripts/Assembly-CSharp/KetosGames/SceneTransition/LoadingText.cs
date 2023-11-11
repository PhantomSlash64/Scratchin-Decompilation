using UnityEngine;
using UnityEngine.UI;

namespace KetosGames.SceneTransition
{
	public class LoadingText : MonoBehaviour
	{
		private float lastUpdate;

		private int numElipses = 1;

		private void Update()
		{
			if (lastUpdate == 0f || Time.unscaledTime > lastUpdate + 0.3f)
			{
				string text = "Loading";
				for (int i = 0; i < numElipses; i++)
				{
					text += ".";
				}
				GetComponent<Text>().text = text;
				numElipses = ((numElipses != 3) ? (numElipses + 1) : 0);
				lastUpdate = Time.unscaledTime;
			}
		}
	}
}
