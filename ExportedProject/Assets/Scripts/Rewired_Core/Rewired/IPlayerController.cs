using System;
using System.Collections.Generic;

namespace Rewired
{
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface IPlayerController
	{
		bool enabled { get; set; }

		int playerId { get; set; }

		IList<PlayerController.Button> buttons { get; }

		IList<PlayerController.Axis> axes { get; }

		IList<PlayerController.Element> elements { get; }

		int buttonCount { get; }

		int axisCount { get; }

		int elementCount { get; }

		event Action<int, bool> ButtonStateChangedEvent;

		event Action<int, float> AxisValueChangedEvent;

		event Action<bool> EnabledStateChangedEvent;

		bool GetButton(int index);

		bool GetButtonDown(int index);

		bool GetButtonUp(int index);

		float GetAxis(int index);

		float GetAxisRaw(int index);

		PlayerController.Element GetElement(int index);

		T GetElement<T>(int index) where T : PlayerController.Element;
	}
}
