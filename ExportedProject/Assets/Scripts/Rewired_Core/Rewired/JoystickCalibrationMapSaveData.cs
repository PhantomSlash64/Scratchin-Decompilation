using System;

namespace Rewired
{
	public sealed class JoystickCalibrationMapSaveData : CalibrationMapSaveData
	{
		private Guid INxgrcPxSOoNrukEUaFYjxeKCMgK;

		public Guid joystickHardwareTypeGuid => INxgrcPxSOoNrukEUaFYjxeKCMgK;

		public JoystickCalibrationMapSaveData(CalibrationMap calibrationMap, ControllerType controllerType, string hardwareIdentifier, Guid joystickHardwareTypeGuid)
			: base(calibrationMap, controllerType, hardwareIdentifier)
		{
			INxgrcPxSOoNrukEUaFYjxeKCMgK = joystickHardwareTypeGuid;
		}
	}
}
