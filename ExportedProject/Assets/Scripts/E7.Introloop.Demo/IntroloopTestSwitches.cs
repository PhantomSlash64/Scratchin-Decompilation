using UnityEngine;
using UnityEngine.UI;

public class IntroloopTestSwitches : MonoBehaviour
{
	public bool useFade;

	public float fadeTime;

	public Toggle fadeToggle;

	public Slider fadeTimeSlider;

	public void Awake()
	{
		UseFade();
		UpdateFadeTime();
	}

	public void UseFade()
	{
		useFade = fadeToggle.isOn;
	}

	public void UpdateFadeTime()
	{
		fadeTime = fadeTimeSlider.value;
	}
}
