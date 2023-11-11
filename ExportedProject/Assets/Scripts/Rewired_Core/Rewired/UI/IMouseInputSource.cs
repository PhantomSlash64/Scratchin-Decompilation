using UnityEngine;

namespace Rewired.UI
{
	public interface IMouseInputSource
	{
		int playerId { get; }

		bool enabled { get; }

		bool locked { get; }

		int buttonCount { get; }

		Vector2 screenPosition { get; }

		Vector2 screenPositionDelta { get; }

		Vector2 wheelDelta { get; }

		bool GetButtonDown(int button);

		bool GetButtonUp(int button);

		bool GetButton(int button);
	}
}
