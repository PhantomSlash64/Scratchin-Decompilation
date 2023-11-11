using System;
using Rewired.Utils.Attributes;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[CustomObfuscation(rename = false)]
	[Preserve]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	internal class ControllerTemplateYokeMapping : ControllerTemplateSpecialElementMapping
	{
		public int eid_axisX = -1;

		public int eid_axisZ = -1;
	}
}
