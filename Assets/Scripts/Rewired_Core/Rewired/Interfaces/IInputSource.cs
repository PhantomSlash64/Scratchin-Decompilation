using System;
using System.Collections.Generic;

namespace Rewired.Interfaces
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	internal interface IInputSource : IDisposable
	{
		event Action DeviceChangedEvent;

		void SystemDeviceConnected();

		void SystemDeviceDisconnected();

		void Update();

		void UpdateDevices(UpdateLoopType updateLoop);

		void UpdateFinished();

		IList<TJoy> GetJoysticks<TJoy>() where TJoy : class;
	}
}
