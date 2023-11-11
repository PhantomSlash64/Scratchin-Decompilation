using System;
using Rewired.Utils.Attributes;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	[Preserve]
	[CustomObfuscation(rename = false)]
	internal class ControllerTemplateThrottleMapping : ControllerTemplateSpecialElementMapping
	{
		public int eid_axis = -1;

		public int eid_minDetent = -1;
	}
}
