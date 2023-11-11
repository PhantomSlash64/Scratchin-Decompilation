using System.ComponentModel;

namespace Rewired.Platforms
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public enum Platform
	{
		Unknown = 0,
		Windows = 1,
		WindowsAppStore = 2,
		WindowsPhone8 = 3,
		OSX = 4,
		iOS = 5,
		Linux = 6,
		Android = 7,
		Blackberry = 8,
		Webplayer = 9,
		Xbox360 = 10,
		XboxOne = 11,
		PS3 = 12,
		PS4 = 13,
		PSVita = 14,
		PSMobile = 15,
		Wii = 16,
		Flash = 17,
		WiiU = 18,
		WebGL = 19,
		Tizen = 20,
		Xenon = 21,
		STV = 22,
		NACL = 23,
		NACL_Webplayer = 24,
		NACL_Chrome = 25,
		SamsungTV = 26,
		Pepper = 27,
		tvOS = 28,
		WindowsUWP = 29,
		Windows81Store = 30,
		N3DS = 31,
		Switch = 32,
		Ouya = 100,
		AmazonFireTV = 101,
		RazerForgeTV = 102,
		Stadia = 103,
		GameCoreXboxOne = 104,
		GameCoreScarlett = 105,
		PS5 = 106
	}
}
