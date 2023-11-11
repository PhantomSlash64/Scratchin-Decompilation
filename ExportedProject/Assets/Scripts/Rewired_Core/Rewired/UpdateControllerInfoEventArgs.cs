using System;
using Rewired.Interfaces;

namespace Rewired
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	internal class UpdateControllerInfoEventArgs : EventArgs
	{
		public readonly IInputManagerJoystickPublic sourceJoystick;

		public UpdateControllerInfoEventArgs(IInputManagerJoystickPublic sourceJoystick)
		{
			this.sourceJoystick = sourceJoystick;
		}
	}
}
