using System.Collections.Generic;
using System.Linq;

namespace HinputClasses.Internal
{
	public class AnyGamepadButton : Button
	{
		private readonly List<Pressable> buttons;

		public AnyGamepadButton(string pressableName, Gamepad gamepad, int index, bool isEnabled)
			: base(pressableName, gamepad, index, isEnabled)
		{
			buttons = Hinput.gamepad.Select((Gamepad g) => g.buttons[index]).ToList();
		}

		protected override bool GetPressed()
		{
			return buttons.Any((Pressable button) => button.simplePress.pressed);
		}
	}
}
