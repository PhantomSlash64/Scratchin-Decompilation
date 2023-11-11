namespace Rewired.Interfaces
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface IUnifiedKeyboardSource
	{
		InputSource inputSource { get; }

		HardwareControllerMap_Game hardwareMap { get; }

		int buttonCount { get; }

		Controller.Extension controllerExtension { get; }

		void UpdateInputData(ControllerDataUpdater dataUpdater);

		void Clear();
	}
}
