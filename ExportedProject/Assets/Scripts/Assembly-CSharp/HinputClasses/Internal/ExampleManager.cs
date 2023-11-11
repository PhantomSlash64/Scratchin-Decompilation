using System.Linq;
using UnityEngine;

namespace HinputClasses.Internal
{
	public class ExampleManager : MonoBehaviour
	{
		[Header("STATE")]
		public GameObject currentPanel;

		[Header("REFERENCES")]
		public GameObject oneGamepad;

		public GameObject twoGamepads;

		public GameObject fourGamepads;

		public GameObject eightGamepads;

		public void Start()
		{
			currentPanel = oneGamepad;
		}

		public void Update()
		{
			int num;
			try
			{
				num = (from gamepad in Hinput.gamepad
					where gamepad.isConnected
					select gamepad.index).Max();
			}
			catch
			{
				return;
			}
			if (num < 1)
			{
				ActivatePanel(oneGamepad);
			}
			else if (num < 2)
			{
				ActivatePanel(twoGamepads);
			}
			else if (num < 4)
			{
				ActivatePanel(fourGamepads);
			}
			else
			{
				ActivatePanel(eightGamepads);
			}
		}

		private void ActivatePanel(GameObject panel)
		{
			if (!(panel == currentPanel))
			{
				currentPanel.SetActive(value: false);
				panel.SetActive(value: true);
				currentPanel = panel;
			}
		}
	}
}
