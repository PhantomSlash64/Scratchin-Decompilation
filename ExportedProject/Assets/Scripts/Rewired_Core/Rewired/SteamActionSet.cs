using System;
using System.Collections.Generic;

namespace Rewired
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	internal class SteamActionSet
	{
		public readonly string name;

		public readonly ulong handle;

		public readonly Dictionary<string, SteamAction> actions;

		public SteamActionSet(string name, ulong handle)
		{
			this.name = name;
			this.handle = handle;
			actions = new Dictionary<string, SteamAction>();
		}

		public void AddAction(SteamAction action)
		{
			if (action == null)
			{
				throw new ArgumentNullException();
			}
			actions.Add(action.name, action);
		}
	}
}
