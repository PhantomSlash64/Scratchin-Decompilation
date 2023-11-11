namespace Rewired.Interfaces
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	internal interface IInputManagerJoystick : IInputManagerJoystickPublic
	{
		void Update();

		void FillData(ControllerDataUpdater dataUpdater);

		BridgedController ToBridgedController();

		ControllerDisconnectedEventArgs ToControllerDisconnectedEventArgs();
	}
}
