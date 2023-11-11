namespace Rewired.Data.Mapping
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface IControllerTemplateMapSpecialElement_Internal
	{
		T GetMapping<T>() where T : ControllerTemplateSpecialElementMapping;
	}
}
