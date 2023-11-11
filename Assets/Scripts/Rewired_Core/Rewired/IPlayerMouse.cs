using System;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	internal interface IPlayerMouse : IPlayerController
	{
		bool defaultToCenter { get; }

		ScreenRect movementArea { get; set; }

		PlayerMouse.MovementAreaUnit movementAreaUnit { get; set; }

		Vector2 screenPosition { get; }

		Vector2 screenPositionPrev { get; }

		Vector2 screenPositionDelta { get; }

		PlayerController.MouseAxis xAxis { get; }

		PlayerController.MouseAxis yAxis { get; }

		PlayerController.MouseWheel wheel { get; }

		PlayerController.Button leftButton { get; }

		PlayerController.Button rightButton { get; }

		PlayerController.Button middleButton { get; }

		float pointerSpeed { get; }

		bool useHardwarePointerPosition { get; }

		event Action<Vector2> ScreenPositionChangedEvent;
	}
}
