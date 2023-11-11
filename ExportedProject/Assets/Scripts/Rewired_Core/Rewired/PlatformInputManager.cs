using System;
using Rewired.Interfaces;

namespace Rewired
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	[CustomObfuscation(rename = false)]
	internal abstract class PlatformInputManager
	{
		protected Action<BridgedController> _DeviceConnectedEvent;

		protected Action<ControllerDisconnectedEventArgs> _DeviceDisconnectedEvent;

		protected Action<UpdateControllerInfoEventArgs> _UpdateControllerInfoEvent;

		protected Action _SystemDeviceConnectedEvent;

		protected Action _SystemDeviceDisconnectedEvent;

		public abstract int deviceCount { get; }

		public abstract PlatformInputManager primaryInputManager { get; }

		public abstract IInputSource inputSource { get; }

		public abstract InputSource inputSourceType { get; }

		[CustomObfuscation(rename = false)]
		public event Action<BridgedController> DeviceConnectedEvent
		{
			add
			{
				_DeviceConnectedEvent = (Action<BridgedController>)Delegate.Combine(_DeviceConnectedEvent, value);
			}
			remove
			{
				_DeviceConnectedEvent = (Action<BridgedController>)Delegate.Remove(_DeviceConnectedEvent, value);
			}
		}

		[CustomObfuscation(rename = false)]
		public event Action<ControllerDisconnectedEventArgs> DeviceDisconnectedEvent
		{
			add
			{
				_DeviceDisconnectedEvent = (Action<ControllerDisconnectedEventArgs>)Delegate.Combine(_DeviceDisconnectedEvent, value);
			}
			remove
			{
				_DeviceDisconnectedEvent = (Action<ControllerDisconnectedEventArgs>)Delegate.Remove(_DeviceDisconnectedEvent, value);
			}
		}

		[CustomObfuscation(rename = false)]
		public event Action<UpdateControllerInfoEventArgs> UpdateControllerInfoEvent
		{
			add
			{
				_UpdateControllerInfoEvent = (Action<UpdateControllerInfoEventArgs>)Delegate.Combine(_UpdateControllerInfoEvent, value);
			}
			remove
			{
				_UpdateControllerInfoEvent = (Action<UpdateControllerInfoEventArgs>)Delegate.Remove(_UpdateControllerInfoEvent, value);
			}
		}

		[CustomObfuscation(rename = false)]
		public event Action SystemDeviceConnectedEvent
		{
			add
			{
				_SystemDeviceConnectedEvent = (Action)Delegate.Combine(_SystemDeviceConnectedEvent, value);
			}
			remove
			{
				_SystemDeviceConnectedEvent = (Action)Delegate.Remove(_SystemDeviceConnectedEvent, value);
			}
		}

		[CustomObfuscation(rename = false)]
		public event Action SystemDeviceDisconnectedEvent
		{
			add
			{
				_SystemDeviceDisconnectedEvent = (Action)Delegate.Combine(_SystemDeviceDisconnectedEvent, value);
			}
			remove
			{
				_SystemDeviceDisconnectedEvent = (Action)Delegate.Remove(_SystemDeviceDisconnectedEvent, value);
			}
		}

		public abstract void Initialize();

		public abstract void Update(UpdateLoopType currentUpdateLoop);

		public abstract void OnDestroy();

		public abstract void SystemDeviceConnected();

		public abstract void SystemDeviceDisconnected();

		public abstract void UpdateControllerData(int controllerId, ControllerDataUpdater data);

		public abstract Action<int, ControllerDataUpdater> GetInputDataUpdateDelegate();

		public abstract void SetUnityJoystickId(int joystickId, int unityJoystickId);

		public abstract IUnifiedMouseSource GetUnifiedMouseSource();

		public abstract IUnifiedKeyboardSource GetUnifiedKeyboardSource();
	}
}
