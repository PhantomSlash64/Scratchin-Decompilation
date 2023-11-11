using System.ComponentModel;

namespace Rewired.Platforms
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public enum ScriptingAPILevel
	{
		Net20 = 0,
		Net20Subset = 1,
		Net46 = 2,
		NetStandard20 = 3
	}
}
