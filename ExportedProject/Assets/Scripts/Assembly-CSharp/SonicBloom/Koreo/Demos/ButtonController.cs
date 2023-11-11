using UnityEngine;
using UnityEngine.UI;

namespace SonicBloom.Koreo.Demos
{
	[AddComponentMenu("Koreographer/Demos/Rhythm Game/Button Controller")]
	public class ButtonController : MonoBehaviour
	{
		[Tooltip("The lane to which this button will send signals.")]
		public LaneController laneController;

		[Tooltip("The Image component for the button graphic.  The texture will be tinted using the lane's color.")]
		public Image imageCom;

		[Tooltip("The Text component for the button.  The text used is specified in the Lane Controller.")]
		public Text textCom;

		private void Start()
		{
			Color color = laneController.color;
			color.a = imageCom.color.a;
			imageCom.color = color;
			textCom.text = laneController.keyboardButton.ToString();
			textCom.color = Color.Lerp(Color.black, Color.white, 1f - color.grayscale);
		}
	}
}
