using System;
using Rewired.Config;
using Rewired.Drivers.Interfaces;
using Rewired.Platforms;
using Rewired.Utils;

namespace Rewired.HID.Drivers
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal abstract class HIDDeviceDriver : IDisposable, IControllerDriver
	{
		[CustomObfuscation(rename = false)]
		public enum DriverType
		{
			fUyeeVFhkdEderlnmYYFoAwmZEL = 0,
			owoBXGhsurVWXPsLIXnjkEKIxTb = 1,
			kTaoDqsQgiDztJibzUBzwSmXBZu = 2,
			rpuierYHGtrFbTxBgiicSDbLzfQ = 3
		}

		[CustomObfuscation(rename = false)]
		internal delegate byte[] GetHidFeatureData(byte reportId);

		[CustomObfuscation(rename = false)]
		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		internal class InitArgs
		{
			public UpdateLoopSetting updateLoopSetting;

			public DeviceConnectionType connectionType;

			public int minAxisValue;

			public int maxAxisValue;

			public int hatZeroValue;

			public int hatSpan;

			public int inputReportLength;

			public int outputReportLength;

			public Func<OutputReport, bool> synchronousWriteOutputReportDelegate;

			public Action<OutputReport> asynchronousWriteOutputReportDelegate;

			public GetHidFeatureData getFeatureReportDelegate;

			public InitArgs(UpdateLoopSetting updateLoopSetting, DeviceConnectionType connectionType, int minAxisValue, int maxAxisValue, int hatZeroValue, int hatSpan, int inputReportLength, int outputReportLength, Func<OutputReport, bool> synchronousWriteOutputReportDelegate, Action<OutputReport> asynchronousWriteOutputReportDelegate, GetHidFeatureData getFeatureReportDelegate)
			{
				this.updateLoopSetting = updateLoopSetting;
				this.connectionType = connectionType;
				this.minAxisValue = minAxisValue;
				this.maxAxisValue = maxAxisValue;
				this.hatZeroValue = hatZeroValue;
				this.hatSpan = hatSpan;
				this.inputReportLength = inputReportLength;
				this.outputReportLength = outputReportLength;
				this.synchronousWriteOutputReportDelegate = synchronousWriteOutputReportDelegate;
				this.asynchronousWriteOutputReportDelegate = asynchronousWriteOutputReportDelegate;
				this.getFeatureReportDelegate = getFeatureReportDelegate;
			}
		}

		public HIDAxis[] axes;

		public HIDButton[] buttons;

		public HIDHat[] hats;

		public HIDAccelerometer[] accelerometers;

		public HIDGyroscope[] gyroscopes;

		public HIDTouchpad[] touchpads;

		public HIDVibrationMotor[] vibrationMotors;

		public HIDLight[] lights;

		private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

		public int AxisCount
		{
			get
			{
				if (axes == null)
				{
					return 0;
				}
				return axes.Length;
			}
		}

		public int ButtonCount
		{
			get
			{
				if (buttons == null)
				{
					return 0;
				}
				return buttons.Length;
			}
		}

		public int HatCount
		{
			get
			{
				if (hats == null)
				{
					return 0;
				}
				return hats.Length;
			}
		}

		public int AccelerometerCount
		{
			get
			{
				if (accelerometers == null)
				{
					return 0;
				}
				return accelerometers.Length;
			}
		}

		public int GyroscopeCount
		{
			get
			{
				if (gyroscopes == null)
				{
					return 0;
				}
				return gyroscopes.Length;
			}
		}

		public int TouchpadCount
		{
			get
			{
				if (touchpads == null)
				{
					return 0;
				}
				return touchpads.Length;
			}
		}

		public int LightCount
		{
			get
			{
				if (lights == null)
				{
					return 0;
				}
				return lights.Length;
			}
		}

		public int VibrationMotorCount
		{
			get
			{
				if (vibrationMotors == null)
				{
					return 0;
				}
				return vibrationMotors.Length;
			}
		}

		protected bool disposed => RFSEgUYkCipDyWyLEnlGiNDUlzz;

		public HIDDeviceDriver()
		{
		}

		public abstract void Update(UpdateLoopType updateLoop);

		public abstract bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp);

		public abstract Controller.Extension CreateControllerExtension();

		public static HIDDeviceDriver GetDriver(DriverType driverId, InitArgs hidDriverInitArgs)
		{
			if (hidDriverInitArgs == null)
			{
				return null;
			}
			switch (driverId)
			{
			case DriverType.owoBXGhsurVWXPsLIXnjkEKIxTb:
				if (UnityTools.effectivePlatform == Platform.OSX && hidDriverInitArgs.connectionType == DeviceConnectionType.CabkzYmwkSoeZRQBHEfOFiOxqlo)
				{
					return null;
				}
				return new DualShock4Driver(hidDriverInitArgs);
			case DriverType.kTaoDqsQgiDztJibzUBzwSmXBZu:
				return new DualSenseDriver(hidDriverInitArgs);
			case DriverType.rpuierYHGtrFbTxBgiicSDbLzfQ:
				return new RailDriverDriver(hidDriverInitArgs);
			default:
				return null;
			}
		}

		public static DriverType FindDriverId(int vendorId, int productId)
		{
			if (DualShock4Driver.Matches(vendorId, productId))
			{
				return DriverType.owoBXGhsurVWXPsLIXnjkEKIxTb;
			}
			if (DualSenseDriver.Matches(vendorId, productId))
			{
				return DriverType.kTaoDqsQgiDztJibzUBzwSmXBZu;
			}
			if (RailDriverDriver.Matches(vendorId, productId))
			{
				return DriverType.rpuierYHGtrFbTxBgiicSDbLzfQ;
			}
			return DriverType.fUyeeVFhkdEderlnmYYFoAwmZEL;
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		~HIDDeviceDriver()
		{
			Dispose(disposing: false);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!RFSEgUYkCipDyWyLEnlGiNDUlzz)
			{
				RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
			}
		}
	}
}
