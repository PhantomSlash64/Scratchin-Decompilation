using System;
using Rewired.Utils.Attributes;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[CustomObfuscation(rename = false)]
	[Preserve]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	internal class ControllerTemplateDPadMapping : ControllerTemplateSpecialElementMapping
	{
		public int eid_up = -1;

		public int eid_right = -1;

		public int eid_down = -1;

		public int eid_left = -1;

		public int eid_press = -1;
	}
}
