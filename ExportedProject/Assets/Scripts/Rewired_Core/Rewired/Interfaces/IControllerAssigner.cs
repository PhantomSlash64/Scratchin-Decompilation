namespace Rewired.Interfaces
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	[CustomObfuscation(rename = false)]
	internal interface IControllerAssigner
	{
		bool enabled { get; set; }

		bool CanHandleAssignment(ControllerType controllerType, Controller controller);

		void AssignController(ControllerType controllerType, Controller controller);
	}
}
