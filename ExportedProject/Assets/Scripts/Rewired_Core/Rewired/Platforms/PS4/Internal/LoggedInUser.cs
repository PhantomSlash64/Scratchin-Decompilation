using System.ComponentModel;

namespace Rewired.Platforms.PS4.Internal
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public class LoggedInUser
	{
		public int status;

		public bool primaryUser;

		public int userId;

		public int color;

		public string userName;

		public int padHandle;

		public int move0Handle;

		public int move1Handle;

		public int aimHandle;
	}
}
