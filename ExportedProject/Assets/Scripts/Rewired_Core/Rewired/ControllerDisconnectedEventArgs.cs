using System;

namespace Rewired
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	[CustomObfuscation(rename = false)]
	internal class ControllerDisconnectedEventArgs : EventArgs
	{
		public readonly int rewiredId;

		public ControllerDisconnectedEventArgs(int rewiredId)
		{
			this.rewiredId = rewiredId;
		}
	}
}
