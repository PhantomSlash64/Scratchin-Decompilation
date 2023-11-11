using System.ComponentModel;
using Rewired.InputManagers;

namespace Rewired.Utils.Platforms.Windows
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public static class Main
	{
		public static object GetPlatformInitializer()
		{
			return Rewired.InputManagers.Initializer.GetPlatformInitializer();
		}
	}
}
