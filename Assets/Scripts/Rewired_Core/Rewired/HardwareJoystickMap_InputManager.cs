using System;
using Rewired.Data.Mapping;
using Rewired.Utils;

namespace Rewired
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	internal class HardwareJoystickMap_InputManager
	{
		public string controllerName;

		public readonly HardwareControllerMapIdentifier hardwareMapIdentifier;

		public readonly HardwareJoystickMap.Platform map;

		public readonly int buttonCount;

		public readonly int axisCount;

		public readonly ControllerElementIdentifier[] elementIdentifiers;

		public readonly HardwareJoystickMap.CompoundElement[] compoundElements;

		public bool useSystemName;

		public readonly bool isUnknownController;

		public readonly JoystickType[] joystickTypes;

		public string[] GetAxisNames()
		{
			return map.GetAxisNames(elementIdentifiers);
		}

		public string[] GetEffectiveButtonNames()
		{
			return map.GetEffectiveButtonNames(elementIdentifiers);
		}

		public HardwareJoystickMap_InputManager(HardwareControllerMapIdentifier hardwareMapIdentifier, JoystickType[] joystickTypes, HardwareJoystickMap.Platform hardwarePlatformMap, string controllerName, int buttonCount, int axisCount, int elementIdentifierCount, HardwareJoystickMap.CompoundElement[] compoundElements)
		{
			this.hardwareMapIdentifier = hardwareMapIdentifier;
			this.joystickTypes = joystickTypes;
			map = hardwarePlatformMap;
			this.controllerName = controllerName;
			this.buttonCount = buttonCount;
			this.axisCount = axisCount;
			elementIdentifiers = new ControllerElementIdentifier[elementIdentifierCount];
			this.compoundElements = compoundElements;
			isUnknownController = hardwareMapIdentifier.guid == Guid.Empty;
		}

		public HardwareControllerMap_Game ToGameHardwareControllerMap()
		{
			JoystickType[] array = ArrayTools.ShallowCopy(joystickTypes);
			map.GetGameElementIdentifierIdMappings(out var buttons, out var axes);
			AxisCalibrationData[] axisCalibrationData = map.GetAxisCalibrationData();
			if (axisCount > 0 && (axisCalibrationData == null || axisCalibrationData.Length != axisCount))
			{
				Logger.LogError("Axis mismatch!");
				return null;
			}
			map.GetAxisData(out var axisRanges, out var axisInfos);
			if (axisRanges == null || axisRanges.Length != axisCount)
			{
				Logger.LogWarning("Invalid AxisRange array returned by HardwareJoystickMap!");
				if (axisRanges != null)
				{
					AxisRange[] array2 = new AxisRange[axisCount];
					for (int i = 0; i < MathTools.Min(axisRanges.Length, axisCount); i++)
					{
						array2[i] = axisRanges[i];
					}
					axisRanges = array2;
				}
				else
				{
					axisRanges = new AxisRange[axisCount];
				}
			}
			if (axisInfos == null || axisInfos.Length != axisCount)
			{
				Logger.LogWarning("Invalid HardwareAxisInfo array returned by HardwareJoystickMap!");
				if (axisInfos != null)
				{
					HardwareAxisInfo[] array3 = new HardwareAxisInfo[axisCount];
					for (int j = 0; j < axisCount; j++)
					{
						if (j < axisInfos.Length)
						{
							array3[j] = axisInfos[j];
						}
						if (array3[j] == null)
						{
							array3[j] = new HardwareAxisInfo();
						}
					}
					axisInfos = array3;
				}
				else
				{
					axisInfos = new HardwareAxisInfo[axisCount];
					for (int k = 0; k < axisCount; k++)
					{
						axisInfos[k] = new HardwareAxisInfo();
					}
				}
			}
			map.GetButtonData(out var buttonInfos);
			if (buttonInfos == null || buttonInfos.Length != buttonCount)
			{
				Logger.LogWarning("Invalid HardwareButtonInfo array returned by HardwareJoystickMap!");
				if (buttonInfos != null)
				{
					HardwareButtonInfo[] array4 = new HardwareButtonInfo[buttonCount];
					for (int l = 0; l < buttonCount; l++)
					{
						if (l < buttonInfos.Length)
						{
							array4[l] = buttonInfos[l];
						}
						if (array4[l] == null)
						{
							array4[l] = new HardwareButtonInfo();
						}
					}
					buttonInfos = array4;
				}
				else
				{
					buttonInfos = new HardwareButtonInfo[buttonCount];
					for (int m = 0; m < buttonCount; m++)
					{
						buttonInfos[m] = new HardwareButtonInfo();
					}
				}
			}
			return new HardwareControllerMap_Game(controllerName, hardwareMapIdentifier, array, elementIdentifiers, buttons, axes, axisCalibrationData, axisRanges, axisInfos, buttonInfos, compoundElements);
		}
	}
}
