namespace Rewired
{
	[CustomObfuscation(rename = false)]
	internal enum InputSource
	{
		None = 0,
		DirectInput = 1,
		XInput = 2,
		OSX = 3,
		Fallback = 4,
		RawInput = 5,
		Fallback_PreConfigured = 6,
		Linux = 7,
		WindowsUWP = 8,
		WebGL = 9,
		Steam = 18,
		SDL2 = 19,
		Ouya = 20,
		XboxOne = 21,
		PS4 = 22,
		NintendoSwitch = 24,
		Stadia = 25,
		GameCoreXboxOne = 26,
		GameCoreScarlett = 27,
		PS5 = 28,
		InternalDriver = 49,
		UnityKeyboardAndMouse = 50,
		Custom = 100
	}
}
