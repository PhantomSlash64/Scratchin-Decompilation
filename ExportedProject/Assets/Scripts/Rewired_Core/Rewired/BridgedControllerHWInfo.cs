using System;
using Rewired.Platforms;

namespace Rewired
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	internal class BridgedControllerHWInfo
	{
		public bool isMock;

		public InputSource inputManagerSource;

		public InputSource inputSource;

		public ControlDeviceType deviceType;

		public string hardwareIdentifier;

		public int hardwareAxisCount;

		public int hardwareButtonCount;

		public int hardwareHatCount;

		public string hw_productName;

		public PidVid hw_pidVid;

		public Guid hw_deviceGuid;

		public int hw_productId;

		public string hw_bluetoothDeviceName;

		public bool hw_isBluetoothDevice;

		public bool hw_supportsVoice;

		public bool hw_supportsVibration;

		public XInputDeviceSubType hw_xInputSubType;

		public string hw_manufacturer;

		public string hw_serialNumber;

		public int hw_vendorId;

		public int hw_version;

		public string hw_systemDeviceName;

		public bool hw_isSDL2Gamepad;

		public WebGLWebBrowserType webGL_webBrowserType;

		public WebGLOSType webGL_osType;

		public WebGLGamepadMappingType webGL_mappingType;

		public string[] webGL_webBrowserVersionSplit;

		public string[] webGL_osVersionSplit;

		public int hw_localVibrationMotorCount;

		public string definitionMatchTag;

		public BridgedControllerHWInfo()
		{
		}

		public BridgedControllerHWInfo(BridgedControllerHWInfo source)
		{
			source.VBxplkiOHoelBEkEUwVibMUKpSim(this);
		}

		private void VBxplkiOHoelBEkEUwVibMUKpSim(BridgedControllerHWInfo P_0)
		{
			P_0.isMock = isMock;
			P_0.inputManagerSource = inputManagerSource;
			P_0.inputSource = inputSource;
			P_0.deviceType = deviceType;
			P_0.hardwareIdentifier = hardwareIdentifier;
			P_0.hardwareAxisCount = hardwareAxisCount;
			P_0.hardwareButtonCount = hardwareButtonCount;
			P_0.hardwareHatCount = hardwareHatCount;
			P_0.hw_productName = hw_productName;
			P_0.hw_pidVid = hw_pidVid;
			P_0.hw_deviceGuid = hw_deviceGuid;
			P_0.hw_productId = hw_productId;
			P_0.hw_bluetoothDeviceName = hw_bluetoothDeviceName;
			P_0.hw_isBluetoothDevice = hw_isBluetoothDevice;
			P_0.hw_supportsVoice = hw_supportsVoice;
			P_0.hw_supportsVibration = hw_supportsVibration;
			P_0.hw_xInputSubType = hw_xInputSubType;
			P_0.hw_manufacturer = hw_manufacturer;
			P_0.hw_serialNumber = hw_serialNumber;
			P_0.hw_vendorId = hw_vendorId;
			P_0.hw_version = hw_version;
			P_0.hw_isSDL2Gamepad = hw_isSDL2Gamepad;
			P_0.webGL_webBrowserType = webGL_webBrowserType;
			P_0.webGL_osType = webGL_osType;
			P_0.webGL_mappingType = webGL_mappingType;
			P_0.hw_localVibrationMotorCount = hw_localVibrationMotorCount;
			P_0.definitionMatchTag = definitionMatchTag;
		}
	}
}
