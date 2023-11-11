using UnityEngine;
using UnityEngine.UI;

namespace SonicBloom.Koreo.Demos
{
	[AddComponentMenu("Koreographer/Demos/Rhythm Game/Demo Pitch Display UI")]
	public class DemoPitchDisplayUI : MonoBehaviour
	{
		[Tooltip("The AudioSource component to track/update for pitch settings.")]
		public AudioSource audioCom;

		[Tooltip("The Text Component that will display the Pitch number.")]
		public Text readoutText;

		[Tooltip("The Slider that controls the Pitch number.")]
		public Slider slider;

		private void Start()
		{
			float pitch = audioCom.pitch;
			slider.value = pitch;
			SetNewPitch(slider.value);
		}

		public void SetNewPitch(float newPitch)
		{
			audioCom.pitch = newPitch;
			readoutText.text = newPitch.ToString("0.####") + "x";
		}
	}
}
