namespace Rewired.Interfaces
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	internal interface IControllerElementIdentifierCommon_Internal
	{
		int id { get; }

		string name { get; }

		string positiveName { get; }

		string negativeName { get; }

		object elementType { get; }

		bool useEditorElementTypeOverride { get; }

		ControllerElementType editorElementTypeOverride { get; }
	}
}
