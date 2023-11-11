namespace Rewired.Interfaces
{
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface IControllerTemplateElementIdentifier_Editor : IControllerElementIdentifierCommon_Internal, IControllerTemplateElementIdentifier
	{
		string scriptingName { get; }

		string alternateScriptingName { get; }
	}
}
