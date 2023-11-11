using System;

namespace Rewired
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	[CustomObfuscation(rename = false)]
	internal struct HardwareControllerMapIdentifier
	{
		public readonly Guid guid;

		public readonly InputSource inputSource;

		public readonly InputPlatform actualInputPlatform;

		public readonly int variantIndex;

		public HardwareControllerMapIdentifier(Guid guid, InputSource inputSource, InputPlatform actualInputPlatform, int variantIndex)
		{
			this.guid = guid;
			this.inputSource = inputSource;
			this.actualInputPlatform = actualInputPlatform;
			this.variantIndex = variantIndex;
		}
	}
}
