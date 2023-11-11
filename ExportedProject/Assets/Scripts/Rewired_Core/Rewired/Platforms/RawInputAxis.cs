using System.ComponentModel;

namespace Rewired.Platforms
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public enum RawInputAxis
	{
		None = 0,
		X = 1,
		Y = 2,
		Z = 3,
		RotationX = 4,
		RotationY = 5,
		RotationZ = 6,
		Slider0 = 7,
		Slider1 = 8,
		VelocityX = 9,
		VelocityY = 10,
		VelocityZ = 11,
		Other = 1000
	}
}
