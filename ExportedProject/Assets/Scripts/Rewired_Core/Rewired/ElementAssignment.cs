using UnityEngine;

namespace Rewired
{
	public struct ElementAssignment
	{
		public ElementAssignmentType type;

		public int elementMapId;

		public int elementIdentifierId;

		public AxisRange axisRange;

		public KeyCode keyboardKey;

		public ModifierKeyFlags modifierKeyFlags;

		public int actionId;

		public Pole axisContribution;

		public bool invert;

		public ElementAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId)
		{
			type = elementAssignmentType;
			this.elementIdentifierId = elementIdentifierId;
			this.axisRange = axisRange;
			this.keyboardKey = keyboardKey;
			this.modifierKeyFlags = modifierKeyFlags;
			this.actionId = actionId;
			this.axisContribution = axisContribution;
			this.invert = invert;
			this.elementMapId = elementMapId;
		}

		public ElementAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId)
		{
			type = BbpfTcGSZRHmltstKOfXrucHPJO.LtloEwFkFgjtPvWBKhPsOCuRzPY(controllerType, elementType, axisRange);
			this.elementIdentifierId = elementIdentifierId;
			this.axisRange = axisRange;
			this.keyboardKey = keyboardKey;
			this.modifierKeyFlags = modifierKeyFlags;
			this.actionId = actionId;
			this.axisContribution = axisContribution;
			this.invert = invert;
			this.elementMapId = elementMapId;
		}

		public ElementAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert)
		{
			type = elementAssignmentType;
			this.elementIdentifierId = elementIdentifierId;
			this.axisRange = axisRange;
			this.keyboardKey = keyboardKey;
			this.modifierKeyFlags = modifierKeyFlags;
			this.actionId = actionId;
			this.axisContribution = axisContribution;
			this.invert = invert;
			elementMapId = -1;
		}

		public ElementAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert)
		{
			type = BbpfTcGSZRHmltstKOfXrucHPJO.LtloEwFkFgjtPvWBKhPsOCuRzPY(controllerType, elementType, axisRange);
			this.elementIdentifierId = elementIdentifierId;
			this.axisRange = axisRange;
			this.keyboardKey = keyboardKey;
			this.modifierKeyFlags = modifierKeyFlags;
			this.actionId = actionId;
			this.axisContribution = axisContribution;
			this.invert = invert;
			elementMapId = -1;
		}

		public ElementAssignment(int elementIdentifierId, int actionId, bool invert)
		{
			type = ElementAssignmentType.FullAxis;
			this.elementIdentifierId = elementIdentifierId;
			axisRange = AxisRange.Full;
			keyboardKey = KeyCode.None;
			modifierKeyFlags = ModifierKeyFlags.None;
			this.actionId = actionId;
			axisContribution = Pole.Positive;
			this.invert = invert;
			elementMapId = -1;
		}

		public ElementAssignment(int elementIdentifierId, int actionId, bool invert, int elementMapId)
		{
			type = ElementAssignmentType.FullAxis;
			this.elementIdentifierId = elementIdentifierId;
			axisRange = AxisRange.Full;
			keyboardKey = KeyCode.None;
			modifierKeyFlags = ModifierKeyFlags.None;
			this.actionId = actionId;
			axisContribution = Pole.Positive;
			this.invert = invert;
			this.elementMapId = elementMapId;
		}

		public ElementAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution)
		{
			type = ElementAssignmentType.SplitAxis;
			this.elementIdentifierId = elementIdentifierId;
			this.axisRange = axisRange;
			keyboardKey = KeyCode.None;
			modifierKeyFlags = ModifierKeyFlags.None;
			this.actionId = actionId;
			this.axisContribution = axisContribution;
			invert = false;
			elementMapId = -1;
		}

		public ElementAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution, int elementMapId)
		{
			type = ElementAssignmentType.SplitAxis;
			this.elementIdentifierId = elementIdentifierId;
			this.axisRange = axisRange;
			keyboardKey = KeyCode.None;
			modifierKeyFlags = ModifierKeyFlags.None;
			this.actionId = actionId;
			this.axisContribution = axisContribution;
			invert = false;
			this.elementMapId = elementMapId;
		}

		public ElementAssignment(int elementIdentifierId, int actionId, Pole axisContribution)
		{
			type = ElementAssignmentType.Button;
			this.elementIdentifierId = elementIdentifierId;
			axisRange = AxisRange.Positive;
			keyboardKey = KeyCode.None;
			modifierKeyFlags = ModifierKeyFlags.None;
			this.actionId = actionId;
			this.axisContribution = axisContribution;
			invert = false;
			elementMapId = -1;
		}

		public ElementAssignment(int elementIdentifierId, int actionId, Pole axisContribution, int elementMapId)
		{
			type = ElementAssignmentType.Button;
			this.elementIdentifierId = elementIdentifierId;
			axisRange = AxisRange.Positive;
			keyboardKey = KeyCode.None;
			modifierKeyFlags = ModifierKeyFlags.None;
			this.actionId = actionId;
			this.axisContribution = axisContribution;
			invert = false;
			this.elementMapId = elementMapId;
		}

		public ElementAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution)
		{
			type = ElementAssignmentType.KeyboardKey;
			elementIdentifierId = Keyboard.zqaoVxjyFQoMohUwgDiEYFekzOS(Keyboard.qwCIJpWERNZNAdssvCNfByJbIlVS(keyboardKey));
			axisRange = AxisRange.Positive;
			this.keyboardKey = keyboardKey;
			this.modifierKeyFlags = modifierKeyFlags;
			this.actionId = actionId;
			this.axisContribution = axisContribution;
			invert = false;
			elementMapId = -1;
		}

		public ElementAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, int elementMapId)
		{
			type = ElementAssignmentType.KeyboardKey;
			elementIdentifierId = Keyboard.zqaoVxjyFQoMohUwgDiEYFekzOS(Keyboard.qwCIJpWERNZNAdssvCNfByJbIlVS(keyboardKey));
			axisRange = AxisRange.Positive;
			this.keyboardKey = keyboardKey;
			this.modifierKeyFlags = modifierKeyFlags;
			this.actionId = actionId;
			this.axisContribution = axisContribution;
			invert = false;
			this.elementMapId = elementMapId;
		}

		public static ElementAssignment CompleteAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId)
		{
			return new ElementAssignment(elementAssignmentType, elementIdentifierId, axisRange, keyboardKey, modifierKeyFlags, actionId, axisContribution, invert, elementMapId);
		}

		public static ElementAssignment CompleteAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId)
		{
			return new ElementAssignment(controllerType, elementType, elementIdentifierId, axisRange, keyboardKey, modifierKeyFlags, actionId, axisContribution, invert, elementMapId);
		}

		public static ElementAssignment CompleteAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert)
		{
			return new ElementAssignment(elementAssignmentType, elementIdentifierId, axisRange, keyboardKey, modifierKeyFlags, actionId, axisContribution, invert);
		}

		public static ElementAssignment CompleteAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert)
		{
			return new ElementAssignment(controllerType, elementType, elementIdentifierId, axisRange, keyboardKey, modifierKeyFlags, actionId, axisContribution, invert);
		}

		public static ElementAssignment FullAxisAssignment(int elementIdentifierId, int actionId, bool invert)
		{
			return new ElementAssignment(elementIdentifierId, actionId, invert);
		}

		public static ElementAssignment FullAxisAssignment(int elementIdentifierId, int actionId, bool invert, int elementMapId)
		{
			return new ElementAssignment(elementIdentifierId, actionId, invert, elementMapId);
		}

		public static ElementAssignment SplitAxisAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution)
		{
			return new ElementAssignment(elementIdentifierId, axisRange, actionId, axisContribution);
		}

		public static ElementAssignment SplitAxisAssignment(int elementIdentifierId, AxisRange axisRange, int actionId, Pole axisContribution, int elementMapId)
		{
			return new ElementAssignment(elementIdentifierId, axisRange, actionId, axisContribution, elementMapId);
		}

		public static ElementAssignment ButtonAssignment(int elementIdentifierId, int actionId, Pole axisContribution)
		{
			return new ElementAssignment(elementIdentifierId, actionId, axisContribution);
		}

		public static ElementAssignment ButtonAssignment(int elementIdentifierId, int actionId, Pole axisContribution, int elementMapId)
		{
			return new ElementAssignment(elementIdentifierId, actionId, axisContribution, elementMapId);
		}

		public static ElementAssignment KeyboardKeyAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution)
		{
			return new ElementAssignment(keyboardKey, modifierKeyFlags, actionId, axisContribution);
		}

		public static ElementAssignment KeyboardKeyAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, int elementMapId)
		{
			return new ElementAssignment(keyboardKey, modifierKeyFlags, actionId, axisContribution, elementMapId);
		}

		public ElementAssignmentConflictCheck ToElementAssignmentConflictCheck()
		{
			ElementAssignmentConflictCheck result = default(ElementAssignmentConflictCheck);
			result.playerId = -1;
			result.controllerType = ControllerType.Keyboard;
			result.controllerId = -1;
			result.controllerMapId = -1;
			result.controllerMapCategoryId = -1;
			result.elementAssignmentType = type;
			result.elementIdentifierId = elementIdentifierId;
			result.axisRange = axisRange;
			result.keyboardKey = keyboardKey;
			result.modifierKeyFlags = modifierKeyFlags;
			result.actionId = actionId;
			result.axisContribution = axisContribution;
			result.invert = invert;
			result.elementMapId = elementMapId;
			return result;
		}
	}
}
