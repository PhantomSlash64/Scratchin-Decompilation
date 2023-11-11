namespace Rewired.Drivers.Interfaces
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	internal interface IDriver_RailDriver : IControllerDriver
	{
		bool SpeakerEnabled { get; set; }

		void SetLEDDisplay(int digitIndex, byte digitBitValues);

		void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues);
	}
}
