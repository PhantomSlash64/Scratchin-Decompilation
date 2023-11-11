using UnityEngine;
using UnityEngine.UI;

public class IntroloopFadeTimeText : MonoBehaviour
{
	public Slider fadeTimeSlider;

	public Text text;

	private void Start()
	{
		UpdateFadeTimeText();
	}

	public void UpdateFadeTimeText()
	{
		text.text = fadeTimeSlider.value.ToString("0.00") + ((fadeTimeSlider.value == 0f) ? " second" : " seconds");
	}
}
