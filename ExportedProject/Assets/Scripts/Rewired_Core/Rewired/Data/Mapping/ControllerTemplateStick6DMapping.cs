using System;
using Rewired.Utils.Attributes;

namespace Rewired.Data.Mapping
{
	[Serializable]
	[Preserve]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class ControllerTemplateStick6DMapping : ControllerTemplateSpecialElementMapping
	{
		public int eid_positionX = -1;

		public int eid_positionY = -1;

		public int eid_positionZ = -1;

		public int eid_rotationX = -1;

		public int eid_rotationY = -1;

		public int eid_rotationZ = -1;
	}
}
