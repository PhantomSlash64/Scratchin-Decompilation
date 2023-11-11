using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace HinputClasses.Internal
{
	public class AnyGamepadStick : Stick
	{
		private readonly List<Stick> sticks;

		public AnyGamepadStick(string stickName, Gamepad gamepad, int index)
			: base(stickName, gamepad, index, isEnabled: true)
		{
			sticks = Hinput.gamepad.Select((Gamepad g) => g.sticks[index]).ToList();
		}

		protected override Vector2 GetPosition()
		{
			List<Stick> list = sticks.Where((Stick s) => s.distance.IsNotEqualTo(0f)).ToList();
			if (list.Count == 0)
			{
				return Vector2.zero;
			}
			return new Vector2(list.Average((Stick stick) => stick.horizontal), list.Average((Stick stick) => stick.vertical));
		}
	}
}
