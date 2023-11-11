using System;
using Rewired.Utils.Attributes;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[CustomObfuscation(rename = false)]
	[Preserve]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	internal abstract class ControllerTemplateSpecialElementMapping
	{
		public ControllerTemplateSpecialElementMapping()
		{
		}
	}
}
