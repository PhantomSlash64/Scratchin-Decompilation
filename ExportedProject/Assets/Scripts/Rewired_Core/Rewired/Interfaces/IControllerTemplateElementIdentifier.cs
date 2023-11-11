namespace Rewired.Interfaces
{
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface IControllerTemplateElementIdentifier : IControllerElementIdentifierCommon_Internal
	{
		new ControllerTemplateElementType elementType { get; }
	}
}
