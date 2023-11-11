using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired.Data.Mapping;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;

namespace Rewired
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	[CustomObfuscation(rename = false)]
	internal class HardwareControllerMap_Game
	{
		public readonly string controllerName;

		public readonly HardwareControllerMapIdentifier hardwareMapIdentifier;

		public readonly int customControllerSourceId;

		public readonly ADictionary<int, ControllerElementIdentifier> elementIdentifiers;

		public readonly ControllerElementIdentifier[] elementIdentifiers_cache;

		public readonly ControllerElementIdentifier[] buttonElementIdentifiers_cache;

		public readonly ControllerElementIdentifier[] axisElementIdentifiers_cache;

		public readonly ControllerElementIdentifier[] axis2DElementIdentifiers_cache;

		public readonly ControllerElementIdentifier[] hatElementIdentifiers_cache;

		public readonly IList<ControllerElementIdentifier> elementIdentifiers_readOnly;

		public readonly IList<ControllerElementIdentifier> buttonElementIdentifiers_readOnly;

		public readonly IList<ControllerElementIdentifier> axisElementIdentifiers_readOnly;

		public readonly IList<ControllerElementIdentifier> axis2DElementIdentifiers_readOnly;

		public readonly IList<ControllerElementIdentifier> hatElementIdentifiers_readOnly;

		public readonly int[] buttonElementIdentifierIds;

		public readonly int[] axisElementIdentifierIds;

		public readonly int[] axis2DElementIdentifierIds;

		public readonly int[] hatElementIdentifierIds;

		public readonly int elementIdentifierCount;

		public readonly int axisCount;

		public readonly int buttonCount;

		public readonly int compoundElementCount;

		public readonly int axis2DCount;

		public readonly int hatCount;

		public readonly JoystickType[] joystickTypes;

		public readonly AxisCalibrationData[] hwAxisCalibrationData;

		public readonly AxisRange[] hwAxisRanges;

		public readonly HardwareAxisInfo[] hwAxisInfo;

		public readonly HardwareButtonInfo[] hwButtonInfo;

		public readonly HardwareJoystickMap.CompoundElement[] compoundElements;

		private HardwareControllerMap_Game(string controllerName)
		{
			this.controllerName = controllerName;
		}

		public HardwareControllerMap_Game(string controllerName, int customControllerSourceId, ControllerElementIdentifier[] hardwareElementIdentifiers, int[] buttonElementIdentifierIds, int[] axisElementIdentifierIds, AxisCalibrationData[] hwAxisCalibrationData, AxisRange[] hwAxisRanges, HardwareAxisInfo[] hwAxisInfo, HardwareButtonInfo[] hwButtonInfo, HardwareJoystickMap.CompoundElement[] compoundElements)
			: this(controllerName, hardwareElementIdentifiers, buttonElementIdentifierIds, axisElementIdentifierIds, hwAxisCalibrationData, hwAxisRanges, hwAxisInfo, hwButtonInfo, compoundElements)
		{
			this.customControllerSourceId = customControllerSourceId;
		}

		public HardwareControllerMap_Game(string controllerName, HardwareControllerMapIdentifier hardwareMapIdentifier, JoystickType[] joystickTypes, ControllerElementIdentifier[] hardwareElementIdentifiers, int[] buttonElementIdentifierIds, int[] axisElementIdentifierIds, AxisCalibrationData[] hwAxisCalibrationData, AxisRange[] hwAxisRanges, HardwareAxisInfo[] hwAxisInfo, HardwareButtonInfo[] hwButtonInfo, HardwareJoystickMap.CompoundElement[] compoundElements)
			: this(controllerName, hardwareElementIdentifiers, buttonElementIdentifierIds, axisElementIdentifierIds, hwAxisCalibrationData, hwAxisRanges, hwAxisInfo, hwButtonInfo, compoundElements)
		{
			this.hardwareMapIdentifier = hardwareMapIdentifier;
			if (joystickTypes == null)
			{
				JoystickType[] array = new JoystickType[1];
				this.joystickTypes = array;
			}
			else
			{
				this.joystickTypes = ArrayTools.ShallowCopy(joystickTypes);
			}
		}

		public HardwareControllerMap_Game(string controllerName, HardwareControllerMapIdentifier hardwareMapIdentifier, ControllerElementIdentifier[] hardwareElementIdentifiers, int[] buttonElementIdentifierIds, int[] axisElementIdentifierIds, AxisCalibrationData[] hwAxisCalibrationData, AxisRange[] hwAxisRanges, HardwareAxisInfo[] hwAxisInfo, HardwareButtonInfo[] hwButtonInfo, HardwareJoystickMap.CompoundElement[] compoundElements)
			: this(controllerName, hardwareMapIdentifier, null, hardwareElementIdentifiers, buttonElementIdentifierIds, axisElementIdentifierIds, hwAxisCalibrationData, hwAxisRanges, hwAxisInfo, hwButtonInfo, compoundElements)
		{
		}

		private HardwareControllerMap_Game(string controllerName, ControllerElementIdentifier[] hardwareElementIdentifiers, int[] buttonElementIdentifierIds, int[] axisElementIdentifierIds, AxisCalibrationData[] hwAxisCalibrationData, AxisRange[] hwAxisRanges, HardwareAxisInfo[] hwAxisInfo, HardwareButtonInfo[] hwButtonInfo, HardwareJoystickMap.CompoundElement[] compoundElements)
			: this(controllerName)
		{
			elementIdentifierCount = ((hardwareElementIdentifiers != null) ? hardwareElementIdentifiers.Length : 0);
			int num = ((buttonElementIdentifierIds != null) ? buttonElementIdentifierIds.Length : 0);
			int num2 = ((axisElementIdentifierIds != null) ? axisElementIdentifierIds.Length : 0);
			compoundElements = ArrayTools.DeepClone(compoundElements);
			this.compoundElements = compoundElements;
			compoundElementCount = ((compoundElements != null) ? compoundElements.Length : 0);
			int num3 = 0;
			int num4 = 0;
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			for (int i = 0; i < compoundElementCount; i++)
			{
				if (compoundElements[i] != null)
				{
					if (compoundElements[i].type == CompoundControllerElementType.Axis2D)
					{
						num3++;
						list.Add(compoundElements[i].elementIdentifier);
					}
					else if (compoundElements[i].type == CompoundControllerElementType.Hat)
					{
						num4++;
						list2.Add(compoundElements[i].elementIdentifier);
						HardwareJoystickMap.CompoundElement.SortHatElementsClockwise(compoundElements[i]);
					}
				}
			}
			int[] array = list.ToArray();
			int[] array2 = list2.ToArray();
			elementIdentifiers = new ADictionary<int, ControllerElementIdentifier>(elementIdentifierCount);
			elementIdentifiers_cache = new ControllerElementIdentifier[elementIdentifierCount];
			buttonElementIdentifiers_cache = new ControllerElementIdentifier[num];
			axisElementIdentifiers_cache = new ControllerElementIdentifier[num2];
			axis2DElementIdentifiers_cache = new ControllerElementIdentifier[num3];
			hatElementIdentifiers_cache = new ControllerElementIdentifier[num4];
			elementIdentifiers_readOnly = new ReadOnlyCollection<ControllerElementIdentifier>(elementIdentifiers_cache);
			buttonElementIdentifiers_readOnly = new ReadOnlyCollection<ControllerElementIdentifier>(buttonElementIdentifiers_cache);
			axisElementIdentifiers_readOnly = new ReadOnlyCollection<ControllerElementIdentifier>(axisElementIdentifiers_cache);
			axis2DElementIdentifiers_readOnly = new ReadOnlyCollection<ControllerElementIdentifier>(axis2DElementIdentifiers_cache);
			hatElementIdentifiers_readOnly = new ReadOnlyCollection<ControllerElementIdentifier>(hatElementIdentifiers_cache);
			for (int j = 0; j < elementIdentifierCount; j++)
			{
				elementIdentifiers_cache[j] = hardwareElementIdentifiers[j];
				elementIdentifiers.Add(hardwareElementIdentifiers[j].id, hardwareElementIdentifiers[j]);
			}
			for (int k = 0; k < num; k++)
			{
				int num5 = tIMrKJmCeNEgepAPNjufZqRYeQg(hardwareElementIdentifiers, buttonElementIdentifierIds[k]);
				if (num5 < 0)
				{
					Logger.LogError("Invalid hardware element identifier id!");
				}
				else
				{
					buttonElementIdentifiers_cache[k] = hardwareElementIdentifiers[num5];
				}
			}
			for (int l = 0; l < num2; l++)
			{
				int num6 = tIMrKJmCeNEgepAPNjufZqRYeQg(hardwareElementIdentifiers, axisElementIdentifierIds[l]);
				if (num6 < 0)
				{
					Logger.LogError("Invalid hardware element identifier id!");
				}
				else
				{
					axisElementIdentifiers_cache[l] = hardwareElementIdentifiers[num6];
				}
			}
			for (int m = 0; m < num3; m++)
			{
				int num7 = tIMrKJmCeNEgepAPNjufZqRYeQg(hardwareElementIdentifiers, array[m]);
				if (num7 < 0)
				{
					Logger.LogError("Invalid hardware element identifier id!");
				}
				else
				{
					axis2DElementIdentifiers_cache[m] = hardwareElementIdentifiers[num7];
				}
			}
			for (int n = 0; n < num4; n++)
			{
				int num8 = tIMrKJmCeNEgepAPNjufZqRYeQg(hardwareElementIdentifiers, array2[n]);
				if (num8 < 0)
				{
					Logger.LogError("Invalid hardware element identifier id!");
				}
				else
				{
					hatElementIdentifiers_cache[n] = hardwareElementIdentifiers[num8];
				}
			}
			this.buttonElementIdentifierIds = buttonElementIdentifierIds;
			this.axisElementIdentifierIds = axisElementIdentifierIds;
			axis2DElementIdentifierIds = array;
			hatElementIdentifierIds = array2;
			elementIdentifierCount = ((elementIdentifiers != null) ? elementIdentifiers.Count : 0);
			buttonCount = ((buttonElementIdentifierIds != null) ? buttonElementIdentifierIds.Length : 0);
			axisCount = ((axisElementIdentifierIds != null) ? axisElementIdentifierIds.Length : 0);
			axis2DCount = num3;
			hatCount = num4;
			this.hwAxisCalibrationData = hwAxisCalibrationData;
			this.hwAxisRanges = hwAxisRanges;
			this.hwAxisInfo = hwAxisInfo;
			this.hwButtonInfo = hwButtonInfo;
		}

		public string GetElementIdentifierName(int elementIdentifierId)
		{
			if (!elementIdentifiers.ContainsKey(elementIdentifierId))
			{
				return string.Empty;
			}
			return elementIdentifiers[elementIdentifierId].name;
		}

		public string GetElementIdentifierPositiveName(int elementIdentifierId)
		{
			if (!elementIdentifiers.ContainsKey(elementIdentifierId))
			{
				return string.Empty;
			}
			return elementIdentifiers[elementIdentifierId].positiveName;
		}

		public string GetElementIdentifierNegativeName(int elementIdentifierId)
		{
			if (!elementIdentifiers.ContainsKey(elementIdentifierId))
			{
				return string.Empty;
			}
			return elementIdentifiers[elementIdentifierId].negativeName;
		}

		public int GetAxisIndex(int elementIdentifierId)
		{
			for (int i = 0; i < axisCount; i++)
			{
				if (axisElementIdentifierIds[i] == elementIdentifierId)
				{
					return i;
				}
			}
			return -1;
		}

		public int GetAxisIndex(string elementIdentifierName)
		{
			if (elementIdentifierName == null || elementIdentifierName == string.Empty)
			{
				return -1;
			}
			int count = elementIdentifiers.Count;
			for (int i = 0; i < count; i++)
			{
				if (elementIdentifiers_cache[i].name.Equals(elementIdentifierName, StringComparison.OrdinalIgnoreCase))
				{
					return GetAxisIndex(elementIdentifiers_cache[i].id);
				}
			}
			return -1;
		}

		public int GetButtonIndex(int elementIdentifierId)
		{
			for (int i = 0; i < buttonCount; i++)
			{
				if (buttonElementIdentifierIds[i] == elementIdentifierId)
				{
					return i;
				}
			}
			return -1;
		}

		public int GetButtonIndex(string elementIdentifierName)
		{
			if (elementIdentifierName == null || elementIdentifierName == string.Empty)
			{
				return -1;
			}
			int count = elementIdentifiers.Count;
			for (int i = 0; i < count; i++)
			{
				if (elementIdentifiers_cache[i].name.Equals(elementIdentifierName, StringComparison.OrdinalIgnoreCase))
				{
					return GetButtonIndex(elementIdentifiers_cache[i].id);
				}
			}
			return -1;
		}

		public ControllerElementIdentifier GetElementIdentifierById(int id)
		{
			int count = elementIdentifiers.Count;
			for (int i = 0; i < count; i++)
			{
				if (elementIdentifiers_cache[i].id == id)
				{
					return elementIdentifiers_cache[i];
				}
			}
			return null;
		}

		public ControllerElementIdentifier GetButtonElementIdentifierById(int id)
		{
			int num = buttonCount;
			for (int i = 0; i < num; i++)
			{
				if (buttonElementIdentifierIds[i] == id)
				{
					return buttonElementIdentifiers_cache[i];
				}
			}
			return null;
		}

		public ControllerElementIdentifier GetAxisElementIdentifierById(int id)
		{
			int num = axisCount;
			for (int i = 0; i < num; i++)
			{
				if (axisElementIdentifierIds[i] == id)
				{
					return axisElementIdentifiers_cache[i];
				}
			}
			return null;
		}

		public HardwareJoystickMap.CompoundElement GetAxis2DData(int index)
		{
			if (compoundElements == null)
			{
				return null;
			}
			int num = 0;
			for (int i = 0; i < compoundElements.Length; i++)
			{
				if (compoundElements[i] != null && compoundElements[i].type == CompoundControllerElementType.Axis2D)
				{
					if (num == index)
					{
						return compoundElements[i];
					}
					num++;
				}
			}
			return null;
		}

		public HardwareJoystickMap.CompoundElement GetHatData(int index)
		{
			if (compoundElements == null)
			{
				return null;
			}
			int num = 0;
			for (int i = 0; i < compoundElements.Length; i++)
			{
				if (compoundElements[i] != null && compoundElements[i].type == CompoundControllerElementType.Hat)
				{
					if (num == index)
					{
						return compoundElements[i];
					}
					num++;
				}
			}
			return null;
		}

		public ControllerElementType GetElementType(int elementIdentifierId)
		{
			if (!elementIdentifiers.ContainsKey(elementIdentifierId))
			{
				return ControllerElementType.Button;
			}
			return elementIdentifiers[elementIdentifierId].elementType;
		}

		private int tIMrKJmCeNEgepAPNjufZqRYeQg(ControllerElementIdentifier[] P_0, int P_1)
		{
			if (P_0 == null)
			{
				return -1;
			}
			int result = -1;
			for (int i = 0; i < P_0.Length; i++)
			{
				if (P_0[i].id == P_1)
				{
					result = i;
					break;
				}
			}
			return result;
		}
	}
}
