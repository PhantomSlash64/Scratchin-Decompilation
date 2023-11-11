namespace Rewired.HID
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class HidAsyncState
	{
		private readonly object lSBtPLjDnDCyVRXIIumkyTnOWaE;

		private readonly object DEtjYQFjlSsKcFiBtixFFqXFtGvH;

		public object CallerDelegate => lSBtPLjDnDCyVRXIIumkyTnOWaE;

		public object CallbackDelegate => DEtjYQFjlSsKcFiBtixFFqXFtGvH;

		public HidAsyncState(object callerDelegate, object callbackDelegate)
		{
			lSBtPLjDnDCyVRXIIumkyTnOWaE = callerDelegate;
			DEtjYQFjlSsKcFiBtixFFqXFtGvH = callbackDelegate;
		}
	}
}
