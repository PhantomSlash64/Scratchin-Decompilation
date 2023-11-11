using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Rewired.Config;

namespace Rewired
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	public static class Consts
	{
		public const int systemPlayerId = 9999999;

		public const string menuRoot = "Window/Rewired";

		internal const int programVersion1 = 1;

		internal const int programVersion2 = 1;

		internal const int programVersion3 = 40;

		internal const int programVersion4 = 0;

		internal const int dataVersion = 1;

		internal const int unityMajorVersion = 2021;

		internal const string unityMajorVersionIdentifier = "U2021";

		internal const bool isTrial = false;

		internal const string copyrightYear = "2021";

		internal const string defaultNamespace = "Rewired";

		internal const LogLevelFlags defaultLogLevel = LogLevelFlags.Info | LogLevelFlags.Warning | LogLevelFlags.Error;

		internal const bool allowInputWhenEditorPaused = true;

		internal const string hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_splitTriggers = "[SplitTriggers]";

		internal const string hwDefinitionVariantTag_RawInputDirectInput_xboxOneController_combinedTriggers = "[CombinedTriggers]";

		internal const float editorGUIUpdateInterval = 0.5f;

		internal const float joystickRefreshPollCheckTimeout = 1f;

		internal const float controllerRefreshWaitTimeout = 0.5f;

		internal const int buttonsPerHat = 8;

		internal const int keyboardKeyCount = 132;

		internal const int keyboardModifierKeyCount = 8;

		internal const int unityMouseButtonCount = 7;

		internal const int unityMouseAxisCount = 4;

		internal const int unityMaxJoysticks = 16;

		internal const int unityJoystickButtonCount = 20;

		internal const int unityJoystickStartingButtonKeycodeValue = 350;

		internal const int unityJoystickAxisCount = 29;

		internal const int unityJoystickLastJoystickIdWithButtonKeyCodes = 16;

		internal const string unityJoystickPrefix = "Joy";

		internal const string unityJoystickAxisSuffix = "Axis";

		internal const string unityJoystickButtonSuffix = "Button";

		internal const int directInputMaxButtons = 128;

		internal const int directInputMaxAxes = 32;

		internal const int directInputMaxHats = 4;

		internal const int directInputMaxSliders = 2;

		internal const int directInputMaxAxisValue = 65535;

		internal const int directInputMinAxisValue = -65535;

		internal const int directInputMaxHatValue = 36000;

		internal const int directInputHatZeroValue = -1;

		internal const int directInputHatSpan = 4500;

		internal const int directInputHatSpan4Way = 9000;

		internal const int directInput_hatValue_up = 0;

		internal const int directInput_hatValue_right = 9000;

		internal const int directInput_hatValue_down = 18000;

		internal const int directInput_hatValue_left = 27000;

		internal const int directInputLastDirectionValue = 31500;

		internal const int directInputLastDirectionValue4Way = 27000;

		internal const int directInputUnknownJoystickHatCount = 2;

		internal const int directInputUnknownJoystickHatButtonStartIndex = 128;

		internal const int directInputJoystickStateByteSize = 264;

		internal const int rawInputMaxButtons = 256;

		internal const int rawInputMaxAxes = 56;

		internal const int rawInputMaxHats = 4;

		internal const int rawInputMaxSliders = 2;

		internal const int rawInputMaxAxisValue = 65535;

		internal const int rawInputMinAxisValue = -65535;

		internal const int rawInputMaxHatValue = 36000;

		internal const int rawInputHatZeroValue = -1;

		internal const int rawInputHatSpan = 4500;

		internal const int rawInputHatSpan4Way = 9000;

		internal const int rawInput_hatValue_up = 0;

		internal const int rawInput_hatValue_right = 9000;

		internal const int rawInput_hatValue_down = 18000;

		internal const int rawInput_hatValue_left = 27000;

		internal const int rawInputLastDirectionValue = 31500;

		internal const int rawInputLastDirectionValue4Way = 27000;

		internal const int rawInputUnknownJoystickHatCount = 2;

		internal const int rawInputUnknownJoystickHatButtonStartIndex = 128;

		internal const int rawInputUnifiedMouseButtonCount = 5;

		internal const int rawInputUnifiedMouseAxisCount = 4;

		internal const float rawInputUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f;

		internal const int rawInputUnifiedKeyboardButtonCount = 132;

		internal const int osxMaxSticks = 4;

		internal const int osxMaxButtons = 128;

		internal const int osxMaxAxesPerStick = 14;

		internal const int osxMaxHatsPerStick = 4;

		internal const int osxMaxAxisValue = 65536;

		internal const int osxMinAxisValue = -65536;

		internal const int osxMaxPressureSensitiveButtonValue = 65536;

		internal const int osxMinPressureSensitiveButtonValue = 0;

		internal const int osxMaxHatValue = 36000;

		internal const int osxInputHatZeroValue = -1;

		internal const int osxHatSpan = 4500;

		internal const int osxHatSpan4Way = 9000;

		internal const int osx_hatValue_up = 0;

		internal const int osx_hatValue_right = 9000;

		internal const int osx_hatValue_down = 18000;

		internal const int osx_hatValue_left = 27000;

		internal const int osxLastDirectionValue = 31500;

		internal const int osxLastDirectionValue4Way = 27000;

		internal const int osxUnknownJoystickHatCount = 16;

		internal const int osxUnknownJoystickHatButtonStartIndex = 128;

		internal const int linuxMaxButtons = 256;

		internal const int linuxMaxAxes = 56;

		internal const int linuxMaxHats = 4;

		internal const int linuxMaxSliders = 2;

		internal const int linuxMaxAxisValue = 32767;

		internal const int linuxMinAxisValue = -32768;

		internal const int linuxMaxHatValue = 36000;

		internal const int linuxHatZeroValue = -1;

		internal const int linuxHatSpan = 4500;

		internal const int linuxHatSpan4Way = 9000;

		internal const int linux_hatValue_up = 0;

		internal const int linux_hatValue_right = 9000;

		internal const int linux_hatValue_down = 18000;

		internal const int linux_hatValue_left = 27000;

		internal const int linuxLastDirectionValue = 31500;

		internal const int linuxLastDirectionValue4Way = 27000;

		internal const int linuxUnknownJoystickHatCount = 2;

		internal const int linuxUnknownJoystickHatButtonStartIndex = 128;

		internal const int linuxUnifiedMouseButtonCount = 5;

		internal const int linuxUnifiedMouseAxisCount = 3;

		internal const float linuxUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f;

		internal const int sdl2MaxButtons = 256;

		internal const int sdl2MaxAxes = 56;

		internal const int sdl2MaxHats = 4;

		internal const int sdl2MaxSliders = 2;

		internal const int sdl2MaxAxisValue = 32768;

		internal const int sdl2MinAxisValue = -32767;

		internal const int sdl2AxisZeroValue = 0;

		internal const int sdl2MaxHatValue = 36000;

		internal const int sdl2HatZeroValue = -1;

		internal const int sdl2HatSpan = 4500;

		internal const int sdl2HatSpan4Way = 9000;

		internal const int sdl2_hatValue_up = 0;

		internal const int sdl2_hatValue_right = 9000;

		internal const int sdl2_hatValue_down = 18000;

		internal const int sdl2_hatValue_left = 27000;

		internal const int sdl2LastDirectionValue = 31500;

		internal const int sdl2LastDirectionValue4Way = 27000;

		internal const int sdl2UnknownJoystickHatCount = 2;

		internal const int sdl2UnknownJoystickHatButtonStartIndex = 128;

		internal const int sdl2UnifiedMouseButtonCount = 5;

		internal const int sdl2UnifiedMouseAxisCount = 3;

		internal const float sdl2UnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f;

		internal const int windowsUWPMaxButtons = 256;

		internal const int windowsUWPMaxAxes = 56;

		internal const int windowsUWPMaxHats = 4;

		internal const int windowsUWPMaxSliders = 2;

		internal const int windowsUWPMaxAxisValue = 32767;

		internal const int windowsUWPMinAxisValue = -32768;

		internal const int windowsUWPMaxHatValue = 36000;

		internal const int windowsUWPHatZeroValue = -1;

		internal const int windowsUWPDirectionsPerHat = 8;

		internal const int windowsUWPHatSpan = 4500;

		internal const int windowsUWPHatSpan4Way = 9000;

		internal const int windowsUWPLastDirectionValue = 31500;

		internal const int windowsUWPLastDirectionValue4Way = 27000;

		internal const int windowsUWPUnknownJoystickHatCount = 2;

		internal const int windowsUWPUnknownJoystickHatButtonStartIndex = 128;

		internal const int windowsUWPUnifiedMouseButtonCount = 5;

		internal const int windowsUWPUnifiedMouseAxisCount = 3;

		internal const float windowsUWPUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f;

		internal const int xInputMaxVibration = 65535;

		internal const int xInputMinVibration = 0;

		internal const float xInputAllowedVibrationInterval = 0.01f;

		internal const int customPlatformMaxButtons = 256;

		internal const int customPlatformMaxAxes = 128;

		internal const int internalDriverMaxButtons = 256;

		internal const int internalDriverMaxAxes = 56;

		internal const int internalDriverMaxHats = 4;

		internal const int internalDriverMaxSliders = 2;

		internal const int internalDriverMaxAxisValue = 65535;

		internal const int internalDriverMinAxisValue = -65535;

		internal const int internalDriverMaxHatValue = 36000;

		internal const int internalDriverHatZeroValue = -1;

		internal const int internalDriverHatSpan = 4500;

		internal const int internalDriverHatSpan4Way = 9000;

		internal const int internalDriver_hatValue_up = 0;

		internal const int internalDriver_hatValue_right = 9000;

		internal const int internalDriver_hatValue_down = 18000;

		internal const int internalDriver_hatValue_left = 27000;

		internal const int internalDriverLastDirectionValue = 31500;

		internal const int internalDriverLastDirectionValue4Way = 27000;

		internal const int internalDriverUnknownJoystickHatCount = 2;

		internal const int internalDriverUnknownJoystickHatButtonStartIndex = 128;

		internal const int internalDriverUnifiedMouseButtonCount = 5;

		internal const int internalDriverUnifiedMouseAxisCount = 3;

		internal const float internalDriverUnifiedMouseAxisUnityEquivalencyMultiplier = 0.5f;

		internal const int webGLMaxButtons = 256;

		internal const int webGLMaxAxes = 128;

		internal const int gameCoreMaxButtons = 256;

		internal const int gameCoreMaxAxes = 32;

		internal const int gameCoreMaxHats = 4;

		internal const int gameCoreUnknownJoystickButtonCount = 128;

		internal const int gameCoreUnknownJoystickAxisCount = 32;

		internal const int gameCoreUnknownJoystickHatCount = 2;

		internal const int unknownJoystickMaxButtons = 128;

		internal const int unknownJoystickMaxAxes = 32;

		internal const int unknownJoystickMaxHats = 16;

		internal const int unknownJoystickButtonsPerHat = 8;

		internal const int unknownJoystickAxisElementIdentifierStartIndex = 0;

		internal const int unknownJoystickButtonElementIdentifierStartIndex = 32;

		internal const int unknownJoystickHatElementIdentifierStartIndex = 160;

		internal const float unknownJoystickDefaultAxisDeadZone = 0.1f;

		internal const float defaultAbsoluteAxisPollingDeadZone = 0.7f;

		internal const float defaultRelativeAxisPollingDeadZone = 100f;

		internal const float defaultMouseXYAxisPollingDeadzone = 100f;

		internal const float defaultMouseOtherAxisPollingDeadzone = 2f;

		internal const float defaultButtonDeadZone = 0.5f;

		internal const float hardwareButtonDeadZone = 0.01f;

		internal const float axisDefaultSensitivity = 1f;

		internal const AxisSensitivityType axisDefaultSensitivityType = AxisSensitivityType.Multiplier;

		internal const float defaultButtonDoublePressSpeed = 0.3f;

		internal const float minDoubleButtonPressSpeed = 0.01f;

		internal const float maxDoubleButtonPressSpeed = 10f;

		internal const float defaultButtonShortPressTime = 0.25f;

		internal const float minButtonShortPressTime = 0f;

		internal const float maxButtonShortPressTime = float.MaxValue;

		internal const float defaultButtonShortPressExpiresIn = 0f;

		internal const float minButtonShortPressExpiresIn = 0f;

		internal const float maxButtonShortPressExpiresIn = float.MaxValue;

		internal const float defaultButtonLongPressTime = 1f;

		internal const float minButtonLongPressTime = 0f;

		internal const float maxButtonLongPressTime = float.MaxValue;

		internal const float defaultButtonLongPressExpiresIn = 0f;

		internal const float minButtonLongPressExpiresIn = 0f;

		internal const float maxButtonLongPressExpiresIn = float.MaxValue;

		internal const float defaultButtonRepeatDelay = 0f;

		internal const float defaultButtonRepeatRate = 30f;

		internal const float minButtonRepeatRate = 0.001f;

		internal const float mouseAxisPollingTimerLength = 1f;

		internal const float fallbackPollingTimeout = 1f;

		internal const string unknownJoystickName = "Unknown Controller";

		internal const float xInputControllerVibrationRenewalInterval = 1.5f;

		internal const int defaultInputThreadUpdateRateFPS = 240;

		internal const int maxInputThreadUpdateRateFPS = 2000;

		internal const int osxXInputOutputReportRefreshRateFPS = 60;

		internal const int defaultOutputRefreshRateFPS = 100;

		internal const int hidOutputReportRefreshRateFPS = 100;

		internal const int hidOutputReportThreadKillTimeout = 10000;

		internal const int joystickInputReportRingBufferCapacity = 60;

		internal const float joystickInputReportRingBufferCapacityDuration = 0.25f;

		internal const string resourecesDLLPath_windowsStandalone = "Libs/Rewired_Windows";

		internal const string resourecesDLLPath_osxStandalone = "Libs/Rewired_OSX";

		internal const string resourecesDLLPath_linux = "Libs/Rewired_Linux";

		internal const float defaultInputBehaviorAxisSensitivity = 1f;

		internal const float defaultInputBehaviorAxisSimulation_gravity = 3f;

		internal const float defaultInputBehaviorAxisSimulation_sensitivity = 3f;

		internal const bool defaultInputBehaviorAxisSmoothing_snap = true;

		internal const bool defaultInputBehaviorAxisSmoothing_instantReverse = false;

		internal const bool defaultInputBehaviorAxisSimulation_enabled = true;

		internal const int allFlagsIntEnum = -1;

		internal const float osxPreventSystemSleepInterval = 30f;

		internal const string schemaNameSpace = "http://guavaman.com/rewired";

		internal const string schemaBaseLocation = "http://guavaman.com/schemas/rewired/";

		internal const string schemaVersionControllerMap = "1.1";

		internal const string schemaVersionCalibrationMap = "1.3";

		internal const string schemaVersionInputBehavior = "1.4";

		internal const string schemaVersionControllerTemplateMap = "1.0";

		internal const string schemaVersionPlayerEnabledMapsHelperData = "1.0";

		internal const string schemaVersionPlayerControllerMapLayoutManagerData = "1.0";

		internal const int controllerMapDataVersion = 2;

		internal const int calibrationMapDataVersion = 4;

		internal const int inputBehaviorDataVersion = 5;

		internal const int controllerTemplateMapDataVersion = 1;

		internal const int playerMapEnablerDataVersion = 1;

		internal const int playerControllerMapLayoutManagerDataVersion = 1;

		internal const int controllerElementType_trueElements_minValue = 0;

		internal const int controllerElementType_trueElements_maxValue = 99;

		internal const float pressureSensitiveButtonDeadZone = 0.001f;

		internal const string rewiredEditorAssembly = "Rewired_Editor";

		internal const string rewiredEditorInputEditorClassFullName = "Rewired.Editor.InputEditor";

		internal const string nintendoSwitchPluginEditorRuntimeAssembly = "Rewired_NintendoSwitch_EditorRuntime";

		internal const string nintendoSwitchPluginInputManagerFullClassPath = "Rewired.Platforms.Switch.NintendoSwitchInputManager";

		internal const string nintendoSwitchPluginHWJoystickMapGuid_JoyConDual = "521b808c-0248-4526-bc10-f1d16ee76bf1";

		internal const string nintendoSwitchPluginHWJoystickMapGuid_Handheld = "1fbdd13b-0795-4173-8a95-a2a75de9d204";

		internal const string stadiaPluginEditorRuntimeAssembly = "Rewired_Stadia_EditorRuntime";

		internal const string stadiaPluginInputManagerFullClassPath = "Rewired.Platforms.Stadia.StadiaInputManager";

		internal const string gameCorePluginEditorRuntimeAssembly = "Rewired_GameCore_EditorRuntime";

		internal const string gameCorePluginInputManagerFullClassPath = "Rewired.Platforms.GameCore.GameCoreInputManager";

		internal const string ps5PluginEditorRuntimeAssembly = "Rewired_PS5_EditorRuntime";

		internal const string ps5PluginInputManagerFullClassPath = "Rewired.Platforms.PS5.PS5InputManager";

		public const int vendorId_sony = 1356;

		internal const int updateLoopTypeCount = 3;

		internal static readonly PidVid[] questionablePidVids;

		internal static readonly int[] questionableVIDs;

		internal static Guid joystickGuid_unknownController;

		internal static Guid joystickGuid_appleMFiController;

		internal static Guid joystickGuid_standardizedGamepad;

		internal static Guid joystickGuid_SonyDualShock4;

		internal static Guid joystickGuid_SonyPS4AimController;

		internal static Guid hardwareTypeGuid_universalKeyboard;

		internal static Guid hardwareTypeGuid_universalMouse;

		private static ReadOnlyCollection<ControllerElementIdentifier> UqwzfVnlrAzrnNeNKwUuwntZozJ;

		private static ReadOnlyCollection<ControllerElementIdentifier> NqtjhDPqRYlCxMGNRjezQBhDmpK;

		internal static readonly IList<string> mouseAxisUnityNames;

		private static readonly string[] PjkzMnJgMilDnIaYCSiTIDOtGPPB;

		internal static readonly IList<string> mouseButtonUnityNames;

		private static readonly string[] iUZBzVWvWNUaOwXyYSzTeeiTZCq;

		internal static readonly IList<string> keyboardKeyNames;

		private static readonly string[] pgxZRdzXOPooKWHRAAelSnAuRcu;

		internal static readonly IList<int> keyboardKeyValues;

		internal static readonly int[] _keyboardKeyValues;

		internal static readonly IList<string> modifierKeyShortNames;

		private static readonly string[] WxZsGkloxVnHXCkFViAWIjOEjmX;

		internal static readonly IList<PidVid> pidVids_sony_dualShock4;

		private static readonly PidVid[] INTCyqGHBuNWzlxeNicqSqaznGb;

		internal static readonly IList<string> productNames_sony_dualShock4;

		private static readonly string[] DZNIAJcnsYunZBXUnUaDUUXYDvC;

		private static readonly ControllerElementIdentifier[] geGAvxhitngcluyzEnfXBLWxhOG;

		internal static int nintendoSwitchPlugin_minPluginVersion => 22;

		internal static int stadiaPlugin_minPluginVersion => 11;

		internal static int gameCorePlugin_minPluginVersion => 1;

		internal static IList<ControllerElementIdentifier> unityUnifiedMouseElementIdentifiers => UqwzfVnlrAzrnNeNKwUuwntZozJ ?? (UqwzfVnlrAzrnNeNKwUuwntZozJ = new ReadOnlyCollection<ControllerElementIdentifier>(new ControllerElementIdentifier[11]
		{
			new ControllerElementIdentifier(0, "Mouse Horizontal", "Mouse Right", "Mouse Left", ControllerElementType.Axis, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(1, "Mouse Vertical", "Mouse Up", "Mouse Down", ControllerElementType.Axis, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(2, "Mouse Wheel", "Mouse Wheel Up", "Mouse Wheel Down", ControllerElementType.Axis, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(10, "Mouse Wheel Horizontal", "Mouse Wheel Right", "Mouse Wheel Left", ControllerElementType.Axis, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(3, "Left Mouse Button", "", "", ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(4, "Right Mouse Button", "", "", ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(5, "Mouse Button 3", "", "", ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(6, "Mouse Button 4", "", "", ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(7, "Mouse Button 5", "", "", ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(8, "Mouse Button 6", "", "", ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(9, "Mouse Button 7", "", "", ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true)
		}));

		internal static IList<ControllerElementIdentifier> rawInputUnifiedMouseElementIdentifiers => NqtjhDPqRYlCxMGNRjezQBhDmpK ?? (NqtjhDPqRYlCxMGNRjezQBhDmpK = new ReadOnlyCollection<ControllerElementIdentifier>(new ControllerElementIdentifier[9]
		{
			new ControllerElementIdentifier(0, "Mouse Horizontal", "Mouse Right", "Mouse Left", ControllerElementType.Axis, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(1, "Mouse Vertical", "Mouse Up", "Mouse Down", ControllerElementType.Axis, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(2, "Mouse Wheel", "Mouse Wheel Up", "Mouse Wheel Down", ControllerElementType.Axis, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(3, "Left Mouse Button", "", "", ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(4, "Right Mouse Button", "", "", ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(5, "Mouse Button 3", "", "", ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(6, "Mouse Button 4", "", "", ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(7, "Mouse Button 5", "", "", ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true),
			new ControllerElementIdentifier(10, "Mouse Wheel Horizontal", "Mouse Wheel Right", "Mouse Wheel Left", ControllerElementType.Axis, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true)
		}));

		internal static ControllerElementIdentifier[] unknownJoystickElementIdentifiers_orig => geGAvxhitngcluyzEnfXBLWxhOG;

		static Consts()
		{
			joystickGuid_unknownController = Guid.Empty;
			joystickGuid_appleMFiController = new Guid("3d919cfa-468e-49f4-bce9-f6c43f2e7e62");
			joystickGuid_standardizedGamepad = new Guid("04c23ab3-2b99-4404-a5c4-f0df7e62938f");
			joystickGuid_SonyDualShock4 = new Guid("cd9718bf-a87a-44bc-8716-60a0def28a9f");
			joystickGuid_SonyPS4AimController = new Guid("65ea105c-6390-4d11-a49b-13a402b1f2d9");
			hardwareTypeGuid_universalKeyboard = new Guid("ae4830f963db4d4c90b31beb46ecaf49");
			hardwareTypeGuid_universalMouse = new Guid("ad60107cea394d9cb90656d39d07be95");
			PjkzMnJgMilDnIaYCSiTIDOtGPPB = new string[3] { "MouseAxis1", "MouseAxis2", "MouseAxis3" };
			iUZBzVWvWNUaOwXyYSzTeeiTZCq = new string[7] { "MouseButton0", "MouseButton1", "MouseButton2", "MouseButton3", "MouseButton4", "MouseButton5", "MouseButton6" };
			pgxZRdzXOPooKWHRAAelSnAuRcu = new string[132]
			{
				"None", "A", "B", "C", "D", "E", "F", "G", "H", "I",
				"J", "K", "L", "M", "N", "O", "P", "Q", "R", "S",
				"T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2",
				"3", "4", "5", "6", "7", "8", "9", "Keypad 0", "Keypad 1", "Keypad 2",
				"Keypad 3", "Keypad 4", "Keypad 5", "Keypad 6", "Keypad 7", "Keypad 8", "Keypad 9", "Keypad .", "Keypad /", "Keypad *",
				"Keypad -", "Keypad +", "Keypad Enter", "Keypad =", "Space", "Backspace", "Tab", "Clear", "Return", "Pause",
				"ESC", "!", "\"", "#", "$", "&", "'", "(", ")", "*",
				"+", ",", "-", ".", "/", ":", ";", "<", "=", ">",
				"?", "@", "[", "\\", "]", "^", "_", "Back Quote", "Delete", "Up Arrow",
				"Down Arrow", "Right Arrow", "Left Arrow", "Insert", "Home", "End", "Page Up", "Page Down", "F1", "F2",
				"F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12",
				"F13", "F14", "F15", "Numlock", "Caps Lock", "Scroll Lock", "Right Shift", "Left Shift", "Right Control", "Left Control",
				"Right Alt", "Left Alt", "Right Command", "Left Command", "Left Windows", "Right Windows", "AltGr", "Help", "Print", "SysReq",
				"Break", "Menu"
			};
			_keyboardKeyValues = new int[132]
			{
				0, 97, 98, 99, 100, 101, 102, 103, 104, 105,
				106, 107, 108, 109, 110, 111, 112, 113, 114, 115,
				116, 117, 118, 119, 120, 121, 122, 48, 49, 50,
				51, 52, 53, 54, 55, 56, 57, 256, 257, 258,
				259, 260, 261, 262, 263, 264, 265, 266, 267, 268,
				269, 270, 271, 272, 32, 8, 9, 12, 13, 19,
				27, 33, 34, 35, 36, 38, 39, 40, 41, 42,
				43, 44, 45, 46, 47, 58, 59, 60, 61, 62,
				63, 64, 91, 92, 93, 94, 95, 96, 127, 273,
				274, 275, 276, 277, 278, 279, 280, 281, 282, 283,
				284, 285, 286, 287, 288, 289, 290, 291, 292, 293,
				294, 295, 296, 300, 301, 302, 303, 304, 305, 306,
				307, 308, 309, 310, 311, 312, 313, 315, 316, 317,
				318, 319
			};
			WxZsGkloxVnHXCkFViAWIjOEjmX = new string[5] { "", "Ctrl", "Alt", "Shift", "Cmd" };
			INTCyqGHBuNWzlxeNicqSqaznGb = new PidVid[3]
			{
				new PidVid(1476, 1356),
				new PidVid(2976, 1356),
				new PidVid(2508, 1356)
			};
			DZNIAJcnsYunZBXUnUaDUUXYDvC = new string[4] { "Sony Computer Entertainment Wireless Controller", "Sony Interactive Entertainment DUALSHOCK®4 USB Wireless Adaptor", "Wireless Controller", "Sony Interactive Entertainment Wireless Controller" };
			mouseAxisUnityNames = new ReadOnlyCollection<string>(PjkzMnJgMilDnIaYCSiTIDOtGPPB);
			mouseButtonUnityNames = new ReadOnlyCollection<string>(iUZBzVWvWNUaOwXyYSzTeeiTZCq);
			keyboardKeyNames = new ReadOnlyCollection<string>(pgxZRdzXOPooKWHRAAelSnAuRcu);
			keyboardKeyValues = new ReadOnlyCollection<int>(_keyboardKeyValues);
			modifierKeyShortNames = new ReadOnlyCollection<string>(WxZsGkloxVnHXCkFViAWIjOEjmX);
			pidVids_sony_dualShock4 = new ReadOnlyCollection<PidVid>(INTCyqGHBuNWzlxeNicqSqaznGb);
			productNames_sony_dualShock4 = new ReadOnlyCollection<string>(DZNIAJcnsYunZBXUnUaDUUXYDvC);
			questionablePidVids = new PidVid[4]
			{
				new PidVid(0, 0),
				new PidVid(0, ushort.MaxValue),
				new PidVid(ushort.MaxValue, ushort.MaxValue),
				new PidVid(ushort.MaxValue, 0)
			};
			questionableVIDs = new int[2] { 0, 65535 };
			geGAvxhitngcluyzEnfXBLWxhOG = rTQaysXbVNuXLqwtaapSVuBJaor();
			if (132 != pgxZRdzXOPooKWHRAAelSnAuRcu.Length)
			{
				Logger.LogError("Consts.keyboardKeyCount does not match _keyboardKeyNames.Length!");
			}
			if (132 != _keyboardKeyValues.Length)
			{
				Logger.LogError("Consts.keyboardKeyCount does not match _keyboardKeyValues.Length!");
			}
		}

		private static ControllerElementIdentifier[] rTQaysXbVNuXLqwtaapSVuBJaor()
		{
			int num = 0;
			List<ControllerElementIdentifier> list = new List<ControllerElementIdentifier>(288);
			for (int i = 0; i < 32; i++)
			{
				list.Add(new ControllerElementIdentifier(num, "Axis " + i, string.Empty, string.Empty, ControllerElementType.Axis, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true));
				num++;
			}
			for (int j = 0; j < 128; j++)
			{
				list.Add(new ControllerElementIdentifier(num, "Button " + j, string.Empty, string.Empty, ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true));
				num++;
			}
			int num2 = num;
			int num3 = num + 64;
			for (int k = 0; k < 16; k++)
			{
				list.Add(new ControllerElementIdentifier(num2++, "Hat " + k + " Up", string.Empty, string.Empty, ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true));
				list.Add(new ControllerElementIdentifier(num3++, "Hat " + k + " Up Right", string.Empty, string.Empty, ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true));
				list.Add(new ControllerElementIdentifier(num2++, "Hat " + k + " Right", string.Empty, string.Empty, ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true));
				list.Add(new ControllerElementIdentifier(num3++, "Hat " + k + " Down Right", string.Empty, string.Empty, ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true));
				list.Add(new ControllerElementIdentifier(num2++, "Hat " + k + " Down", string.Empty, string.Empty, ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true));
				list.Add(new ControllerElementIdentifier(num3++, "Hat " + k + " Down Left", string.Empty, string.Empty, ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true));
				list.Add(new ControllerElementIdentifier(num2++, "Hat " + k + " Left", string.Empty, string.Empty, ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true));
				list.Add(new ControllerElementIdentifier(num3++, "Hat " + k + " Up Left", string.Empty, string.Empty, ControllerElementType.Button, CompoundControllerElementType.Axis2D, isMappableOnPlatform: true));
			}
			return list.ToArray();
		}
	}
}
