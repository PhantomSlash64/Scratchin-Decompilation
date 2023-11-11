using UnityEngine;

namespace Rewired.UI
{
	public interface ITouchInputSource
	{
		int playerId { get; }

		bool touchSupported { get; }

		int touchCount { get; }

		Touch GetTouch(int index);
	}
}
