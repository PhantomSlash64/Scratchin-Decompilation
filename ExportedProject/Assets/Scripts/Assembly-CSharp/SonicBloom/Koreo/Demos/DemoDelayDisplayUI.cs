using UnityEngine;
using UnityEngine.UI;

namespace SonicBloom.Koreo.Demos
{
	[AddComponentMenu("Koreographer/Demos/Rhythm Game/Demo Delay Display UI")]
	public class DemoDelayDisplayUI : MonoBehaviour
	{
		[Tooltip("The Text Component that will display the Event Delay number.")]
		public Text readoutText;

		[Tooltip("The Slider that controls the Event Delay number.")]
		public Slider slider;

		private void Start()
		{
			float eventDelayInSeconds = Koreographer.Instance.EventDelayInSeconds;
			slider.value = eventDelayInSeconds;
			SetNewDelay(slider.value);
		}

		public void SetNewDelay(float newDelay)
		{
			Koreographer.Instance.EventDelayInSeconds = newDelay;
			readoutText.text = newDelay.ToString("0.####") + "s";
		}
	}
}
