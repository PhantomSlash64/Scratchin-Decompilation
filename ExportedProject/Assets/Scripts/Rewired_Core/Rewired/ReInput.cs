using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Rewired.Config;
using Rewired.Data;
using Rewired.Data.Mapping;
using Rewired.InputManagers;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Platforms.Custom;
using Rewired.Platforms.PS4;
using Rewired.Platforms.XboxOne;
using Rewired.Utils;
using Rewired.Utils.Classes;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Classes.Utility;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired
{
	public static class ReInput
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public sealed class ConfigHelper : CodeHelper
		{
			private static ConfigHelper GclIwrgVrnJKTEKbDVzknvtphRgP;

			private float mAPdZUBGuGPjqfmGlVYNrYbKTQKS = 0.7f;

			private float PRqHJWQUXGBbHNOrOgTZFtaJEmtM = 100f;

			internal static ConfigHelper Instance => GclIwrgVrnJKTEKbDVzknvtphRgP ?? (GclIwrgVrnJKTEKbDVzknvtphRgP = new ConfigHelper());

			public bool useXInput
			{
				get
				{
					if (!CheckInitialized())
					{
						return false;
					}
					if (UnityTools.platform == Platform.Windows && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.windowsStandalonePrimaryInputSource == WindowsStandalonePrimaryInputSource.XInput)
					{
						return true;
					}
					if (UnityTools.platform == Platform.WindowsUWP)
					{
						return (hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.GetPlatformVars(Platform.WindowsUWP) as ConfigVars.PlatformVars_WindowsUWP).useGamepadAPI;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.useXInput;
				}
				set
				{
					if (!CheckInitialized())
					{
						return;
					}
					if (UnityTools.platform == Platform.WindowsUWP)
					{
						ConfigVars.PlatformVars_WindowsUWP platformVars_WindowsUWP = hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.GetPlatformVars(Platform.WindowsUWP) as ConfigVars.PlatformVars_WindowsUWP;
						if (platformVars_WindowsUWP.useGamepadAPI != value)
						{
							platformVars_WindowsUWP.useGamepadAPI = value;
							if (AdpjYGRLHiVIDWJZGBdZJhLTsHYd != null)
							{
								AdpjYGRLHiVIDWJZGBdZJhLTsHYd.ResetAll();
							}
						}
					}
					else if (hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.useXInput != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.useXInput = value;
						if (!value && UnityTools.platform == Platform.Windows && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.windowsStandalonePrimaryInputSource == WindowsStandalonePrimaryInputSource.XInput)
						{
							windowsStandalonePrimaryInputSource = WindowsStandalonePrimaryInputSource.RawInput;
							Logger.Log("The primary input source has been changed to Raw Input.");
						}
						else if (AdpjYGRLHiVIDWJZGBdZJhLTsHYd != null)
						{
							AdpjYGRLHiVIDWJZGBdZJhLTsHYd.ResetAll();
						}
					}
				}
			}

			public UpdateLoopSetting updateLoop
			{
				get
				{
					if (!CheckInitialized())
					{
						return UpdateLoopSetting.Update;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.updateLoop;
				}
				set
				{
					if (CheckInitialized() && value != hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.updateLoop)
					{
						if ((value & UpdateLoopSetting.Update) == 0)
						{
							value |= UpdateLoopSetting.Update;
						}
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.updateLoop = value;
						if (AdpjYGRLHiVIDWJZGBdZJhLTsHYd != null)
						{
							AdpjYGRLHiVIDWJZGBdZJhLTsHYd.ResetAll();
						}
					}
				}
			}

			public WindowsStandalonePrimaryInputSource windowsStandalonePrimaryInputSource
			{
				get
				{
					if (!CheckInitialized())
					{
						return WindowsStandalonePrimaryInputSource.RawInput;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.windowsStandalonePrimaryInputSource;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.windowsStandalonePrimaryInputSource != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.windowsStandalonePrimaryInputSource = value;
						if (UnityTools.platform == Platform.Windows && value == WindowsStandalonePrimaryInputSource.XInput)
						{
							hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.useXInput = true;
						}
						if (AdpjYGRLHiVIDWJZGBdZJhLTsHYd != null)
						{
							AdpjYGRLHiVIDWJZGBdZJhLTsHYd.ResetAll();
						}
					}
				}
			}

			public OSXStandalonePrimaryInputSource osxStandalonePrimaryInputSource
			{
				get
				{
					if (!CheckInitialized())
					{
						return OSXStandalonePrimaryInputSource.Native;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.osx_primaryInputSource;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.osx_primaryInputSource != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.osx_primaryInputSource = value;
						if (AdpjYGRLHiVIDWJZGBdZJhLTsHYd != null)
						{
							AdpjYGRLHiVIDWJZGBdZJhLTsHYd.ResetAll();
						}
					}
				}
			}

			public LinuxStandalonePrimaryInputSource linuxStandalonePrimaryInputSource
			{
				get
				{
					if (!CheckInitialized())
					{
						return LinuxStandalonePrimaryInputSource.Native;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.linux_primaryInputSource;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.linux_primaryInputSource != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.linux_primaryInputSource = value;
						if (AdpjYGRLHiVIDWJZGBdZJhLTsHYd != null)
						{
							AdpjYGRLHiVIDWJZGBdZJhLTsHYd.ResetAll();
						}
					}
				}
			}

			public WindowsUWPPrimaryInputSource windowsUWPPrimaryInputSource
			{
				get
				{
					if (!CheckInitialized())
					{
						return WindowsUWPPrimaryInputSource.Native;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.windowsUWP_primaryInputSource;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.windowsUWP_primaryInputSource != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.windowsUWP_primaryInputSource = value;
						if (AdpjYGRLHiVIDWJZGBdZJhLTsHYd != null)
						{
							AdpjYGRLHiVIDWJZGBdZJhLTsHYd.ResetAll();
						}
					}
				}
			}

			public bool windowsUWPSupportHIDDevices
			{
				get
				{
					if (!CheckInitialized())
					{
						return false;
					}
					ConfigVars.PlatformVars_WindowsUWP platformVars_WindowsUWP = hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.GetPlatformVars(Platform.WindowsUWP) as ConfigVars.PlatformVars_WindowsUWP;
					return platformVars_WindowsUWP.useHIDAPI;
				}
				set
				{
					if (!CheckInitialized())
					{
						return;
					}
					ConfigVars.PlatformVars_WindowsUWP platformVars_WindowsUWP = hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.GetPlatformVars(Platform.WindowsUWP) as ConfigVars.PlatformVars_WindowsUWP;
					if (platformVars_WindowsUWP.useHIDAPI != value)
					{
						platformVars_WindowsUWP.useHIDAPI = value;
						if (AdpjYGRLHiVIDWJZGBdZJhLTsHYd != null)
						{
							AdpjYGRLHiVIDWJZGBdZJhLTsHYd.ResetAll();
						}
					}
				}
			}

			public XboxOnePrimaryInputSource xboxOnePrimaryInputSource
			{
				get
				{
					if (!CheckInitialized())
					{
						return XboxOnePrimaryInputSource.Native;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.xboxOne_primaryInputSource;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.xboxOne_primaryInputSource != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.xboxOne_primaryInputSource = value;
						if (AdpjYGRLHiVIDWJZGBdZJhLTsHYd != null)
						{
							AdpjYGRLHiVIDWJZGBdZJhLTsHYd.ResetAll();
						}
					}
				}
			}

			public PS4PrimaryInputSource ps4PrimaryInputSource
			{
				get
				{
					if (!CheckInitialized())
					{
						return PS4PrimaryInputSource.Native;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.ps4_primaryInputSource;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.ps4_primaryInputSource != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.ps4_primaryInputSource = value;
						if (AdpjYGRLHiVIDWJZGBdZJhLTsHYd != null)
						{
							AdpjYGRLHiVIDWJZGBdZJhLTsHYd.ResetAll();
						}
					}
				}
			}

			public WebGLPrimaryInputSource webGLPrimaryInputSource
			{
				get
				{
					if (!CheckInitialized())
					{
						return WebGLPrimaryInputSource.Native;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.webGL_primaryInputSource;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.webGL_primaryInputSource != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.webGL_primaryInputSource = value;
						if (AdpjYGRLHiVIDWJZGBdZJhLTsHYd != null)
						{
							AdpjYGRLHiVIDWJZGBdZJhLTsHYd.ResetAll();
						}
					}
				}
			}

			public bool alwaysUseUnityInput
			{
				get
				{
					if (!CheckInitialized())
					{
						return false;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.alwaysUseUnityInput;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.alwaysUseUnityInput != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.alwaysUseUnityInput = value;
						if (AdpjYGRLHiVIDWJZGBdZJhLTsHYd != null)
						{
							AdpjYGRLHiVIDWJZGBdZJhLTsHYd.ResetAll();
						}
					}
				}
			}

			public bool disableNativeInput
			{
				get
				{
					return alwaysUseUnityInput;
				}
				set
				{
					alwaysUseUnityInput = value;
				}
			}

			public bool nativeMouseSupport
			{
				get
				{
					if (!CheckInitialized())
					{
						return false;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.GetPlatformVar_useNativeMouse();
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.SetPlatformVar_useNativeMouse(value) && AdpjYGRLHiVIDWJZGBdZJhLTsHYd != null)
					{
						AdpjYGRLHiVIDWJZGBdZJhLTsHYd.ResetAll();
					}
				}
			}

			public bool nativeKeyboardSupport
			{
				get
				{
					if (!CheckInitialized())
					{
						return false;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.GetPlatformVar_useNativeKeyboard();
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.SetPlatformVar_useNativeKeyboard(value) && AdpjYGRLHiVIDWJZGBdZJhLTsHYd != null)
					{
						AdpjYGRLHiVIDWJZGBdZJhLTsHYd.ResetAll();
					}
				}
			}

			public bool enhancedDeviceSupport
			{
				get
				{
					if (!CheckInitialized())
					{
						return false;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.GetPlatformVar_useEnhancedDeviceSupport();
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.SetPlatformVar_useEnhancedDeviceSupport(value) && AdpjYGRLHiVIDWJZGBdZJhLTsHYd != null)
					{
						AdpjYGRLHiVIDWJZGBdZJhLTsHYd.ResetAll();
					}
				}
			}

			public int joystickRefreshRate
			{
				get
				{
					if (!CheckInitialized())
					{
						return 0;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.GetPlatformVar_joystickRefreshRate();
				}
				set
				{
					if (CheckInitialized())
					{
						value = MathTools.Clamp(value, 0, 2000);
						if (value == 0)
						{
							value = 240;
						}
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.SetPlatformVar_joystickRefreshRate(value);
					}
				}
			}

			public bool ignoreInputWhenAppNotInFocus
			{
				get
				{
					if (!CheckInitialized())
					{
						return false;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.GetPlatformVar_ignoreInputWhenAppNotInFocus();
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.SetPlatformVar_ignoreInputWhenAppNotInFocus(value))
					{
						xsNcGJXrMHAqxvmJhainDJvBMIZk();
					}
				}
			}

			public bool android_supportUnknownGamepads
			{
				get
				{
					if (!CheckInitialized())
					{
						return false;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.android_supportUnknownGamepads;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.android_supportUnknownGamepads != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.android_supportUnknownGamepads = value;
						if (AdpjYGRLHiVIDWJZGBdZJhLTsHYd != null)
						{
							AdpjYGRLHiVIDWJZGBdZJhLTsHYd.ResetAll();
						}
					}
				}
			}

			public DeadZone2DType defaultJoystickAxis2DDeadZoneType
			{
				get
				{
					if (!CheckInitialized())
					{
						return DeadZone2DType.Radial;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.defaultJoystickAxis2DDeadZoneType;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.defaultJoystickAxis2DDeadZoneType != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.defaultJoystickAxis2DDeadZoneType = value;
					}
				}
			}

			public AxisSensitivity2DType defaultJoystickAxis2DSensitivityType
			{
				get
				{
					if (!CheckInitialized())
					{
						return AxisSensitivity2DType.Radial;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.defaultJoystickAxis2DSensitivityType;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.defaultJoystickAxis2DSensitivityType != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.defaultJoystickAxis2DSensitivityType = value;
					}
				}
			}

			public AxisSensitivityType defaultAxisSensitivityType
			{
				get
				{
					if (!CheckInitialized())
					{
						return AxisSensitivityType.Multiplier;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.defaultAxisSensitivityType;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.defaultAxisSensitivityType != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.defaultAxisSensitivityType = value;
					}
				}
			}

			public bool force4WayHats
			{
				get
				{
					if (!CheckInitialized())
					{
						return false;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.force4WayHats;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.force4WayHats != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.force4WayHats = value;
					}
				}
			}

			public float defaultAbsoluteAxisPollingDeadZone
			{
				get
				{
					if (!CheckInitialized())
					{
						return 0.7f;
					}
					return mAPdZUBGuGPjqfmGlVYNrYbKTQKS;
				}
				set
				{
					if (CheckInitialized())
					{
						if (value < 0f)
						{
							value = 0f;
						}
						if (mAPdZUBGuGPjqfmGlVYNrYbKTQKS != value)
						{
							mAPdZUBGuGPjqfmGlVYNrYbKTQKS = value;
						}
					}
				}
			}

			public float defaultRelativeAxisPollingDeadZone
			{
				get
				{
					if (!CheckInitialized())
					{
						return 100f;
					}
					return PRqHJWQUXGBbHNOrOgTZFtaJEmtM;
				}
				set
				{
					if (CheckInitialized())
					{
						if (value < 0f)
						{
							value = 0f;
						}
						if (PRqHJWQUXGBbHNOrOgTZFtaJEmtM != value)
						{
							PRqHJWQUXGBbHNOrOgTZFtaJEmtM = value;
						}
					}
				}
			}

			public bool activateActionButtonsOnNegativeValue
			{
				get
				{
					if (!CheckInitialized())
					{
						return false;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.activateActionButtonsOnNegativeValue;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.activateActionButtonsOnNegativeValue != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.activateActionButtonsOnNegativeValue = value;
					}
				}
			}

			public ThrottleCalibrationMode throttleCalibrationMode
			{
				get
				{
					if (!CheckInitialized())
					{
						return ThrottleCalibrationMode.ZeroToOne;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.throttleCalibrationMode;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.throttleCalibrationMode != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.throttleCalibrationMode = value;
						CoyPNJHWMheFytmTMQdqyctMRFl.gHuKdJWHONKmkRrOipoirdsktpB(value);
					}
				}
			}

			public bool deferControllerConnectedEventsOnStart
			{
				get
				{
					if (!CheckInitialized())
					{
						return false;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.deferControllerConnectedEventsOnStart;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.deferControllerConnectedEventsOnStart != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.deferControllerConnectedEventsOnStart = value;
					}
				}
			}

			public bool autoAssignJoysticks
			{
				get
				{
					if (!CheckInitialized())
					{
						return false;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.autoAssignJoysticks;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.autoAssignJoysticks != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.autoAssignJoysticks = value;
					}
				}
			}

			public int maxJoysticksPerPlayer
			{
				get
				{
					if (!CheckInitialized())
					{
						return 0;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.maxJoysticksPerPlayer;
				}
				set
				{
					if (CheckInitialized())
					{
						if (value < 1)
						{
							value = 1;
						}
						if (hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.maxJoysticksPerPlayer != value)
						{
							hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.maxJoysticksPerPlayer = value;
						}
					}
				}
			}

			public bool distributeJoysticksEvenly
			{
				get
				{
					if (!CheckInitialized())
					{
						return false;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.distributeJoysticksEvenly;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.distributeJoysticksEvenly != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.distributeJoysticksEvenly = value;
					}
				}
			}

			public bool assignJoysticksToPlayingPlayersOnly
			{
				get
				{
					if (!CheckInitialized())
					{
						return false;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.assignJoysticksToPlayingPlayersOnly;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.assignJoysticksToPlayingPlayersOnly != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.assignJoysticksToPlayingPlayersOnly = value;
					}
				}
			}

			public bool reassignJoystickToPreviousOwnerOnReconnect
			{
				get
				{
					if (!CheckInitialized())
					{
						return false;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.reassignJoystickToPreviousOwnerOnReconnect;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.reassignJoystickToPreviousOwnerOnReconnect != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.reassignJoystickToPreviousOwnerOnReconnect = value;
					}
				}
			}

			public LogLevelFlags logLevel
			{
				get
				{
					if (!CheckInitialized())
					{
						return LogLevelFlags.Off;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.logLevel;
				}
				set
				{
					if (CheckInitialized() && hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.logLevel != value)
					{
						hxqbdqzxiQgQaiRpIPHaudXzLll.ConfigVars.logLevel = value;
					}
				}
			}

			private ConfigHelper()
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public sealed class ControllerHelper : CodeHelper
		{
			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public sealed class PollingHelper : CodeHelper
			{
				private static PollingHelper GclIwrgVrnJKTEKbDVzknvtphRgP;

				internal static PollingHelper Instance => GclIwrgVrnJKTEKbDVzknvtphRgP ?? (GclIwrgVrnJKTEKbDVzknvtphRgP = new PollingHelper());

				private PollingHelper()
				{
				}

				public ControllerPollingInfo PollAllControllersForFirstElement()
				{
					if (!CheckInitialized())
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					ControllerPollingInfo result = BPbBTtVObmgXNwUwpliGxSWnECJ();
					if (result.success)
					{
						return result;
					}
					result = lQLJhbEfcNBpedPNxNFzjfsgToLX();
					if (result.success)
					{
						return result;
					}
					result = NZgCGvSQdAcxwOsJhcPYZrtlZtP();
					if (result.success)
					{
						return result;
					}
					result = GWmZWnlHxFEUXieGzCzMXyqSnuO();
					if (result.success)
					{
						return result;
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				public ControllerPollingInfo PollAllControllersForFirstElementDown()
				{
					if (!CheckInitialized())
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					ControllerPollingInfo result = VfLYSZjkQXiMjnsjxcZJGATBiGa();
					if (result.success)
					{
						return result;
					}
					result = SeblWPqDnAwVQgRSeiLCKHnatdj();
					if (result.success)
					{
						return result;
					}
					result = CvbMVrTXhYHDrZIKlqJuHDkmKiC();
					if (result.success)
					{
						return result;
					}
					result = tTXahHrgTVligFjVfbqIqtLOsQW();
					if (result.success)
					{
						return result;
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				public ControllerPollingInfo PollAllControllersForFirstButton()
				{
					if (!CheckInitialized())
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					ControllerPollingInfo result = hKGvFBMZdfTHLXvbpEwKgahVKKY();
					if (result.success)
					{
						return result;
					}
					result = lQLJhbEfcNBpedPNxNFzjfsgToLX();
					if (result.success)
					{
						return result;
					}
					result = ObTeBSvMSaaDdnPPqAbhskKZHAdC();
					if (result.success)
					{
						return result;
					}
					result = TeEcjHksFDwZLuxeBsznKVzDVrn();
					if (result.success)
					{
						return result;
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				public ControllerPollingInfo PollAllControllersForFirstButtonDown()
				{
					if (!CheckInitialized())
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					ControllerPollingInfo result = zcFsYwMOpAENHfhLAKmpPnxiFbY();
					if (result.success)
					{
						return result;
					}
					result = SeblWPqDnAwVQgRSeiLCKHnatdj();
					if (result.success)
					{
						return result;
					}
					result = sGHuqzQOGzcrfEGQoLNvfBTntnea();
					if (result.success)
					{
						return result;
					}
					result = vvIEmvquKUQmjMeXbFoiRcSXWZH();
					if (result.success)
					{
						return result;
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				public ControllerPollingInfo PollAllControllersForFirstAxis()
				{
					if (!CheckInitialized())
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					ControllerPollingInfo result = wooBmHpbqPpndBLyQIDyvHKjBTN();
					if (result.success)
					{
						return result;
					}
					result = ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					if (result.success)
					{
						return result;
					}
					result = GWhvCPrVslWzDoGyWALfdiLKRDO();
					if (result.success)
					{
						return result;
					}
					result = UKQZncxGBDkovrkuDNVNTIVgZGh();
					if (result.success)
					{
						return result;
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstElement(ControllerType controllerType)
				{
					if (!CheckInitialized())
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Joystick => BPbBTtVObmgXNwUwpliGxSWnECJ(), 
						ControllerType.Keyboard => lQLJhbEfcNBpedPNxNFzjfsgToLX(), 
						ControllerType.Mouse => NZgCGvSQdAcxwOsJhcPYZrtlZtP(), 
						ControllerType.Custom => GWmZWnlHxFEUXieGzCzMXyqSnuO(), 
						_ => throw new NotImplementedException(), 
					};
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstElementDown(ControllerType controllerType)
				{
					if (!CheckInitialized())
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Joystick => VfLYSZjkQXiMjnsjxcZJGATBiGa(), 
						ControllerType.Keyboard => SeblWPqDnAwVQgRSeiLCKHnatdj(), 
						ControllerType.Mouse => CvbMVrTXhYHDrZIKlqJuHDkmKiC(), 
						ControllerType.Custom => tTXahHrgTVligFjVfbqIqtLOsQW(), 
						_ => throw new NotImplementedException(), 
					};
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstButton(ControllerType controllerType)
				{
					if (!CheckInitialized())
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Joystick => hKGvFBMZdfTHLXvbpEwKgahVKKY(), 
						ControllerType.Keyboard => lQLJhbEfcNBpedPNxNFzjfsgToLX(), 
						ControllerType.Mouse => ObTeBSvMSaaDdnPPqAbhskKZHAdC(), 
						ControllerType.Custom => TeEcjHksFDwZLuxeBsznKVzDVrn(), 
						_ => throw new NotImplementedException(), 
					};
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstButtonDown(ControllerType controllerType)
				{
					if (!CheckInitialized())
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Joystick => zcFsYwMOpAENHfhLAKmpPnxiFbY(), 
						ControllerType.Keyboard => SeblWPqDnAwVQgRSeiLCKHnatdj(), 
						ControllerType.Mouse => sGHuqzQOGzcrfEGQoLNvfBTntnea(), 
						ControllerType.Custom => vvIEmvquKUQmjMeXbFoiRcSXWZH(), 
						_ => throw new NotImplementedException(), 
					};
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstAxis(ControllerType controllerType)
				{
					if (!CheckInitialized())
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Joystick => wooBmHpbqPpndBLyQIDyvHKjBTN(), 
						ControllerType.Keyboard => ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf(), 
						ControllerType.Mouse => GWhvCPrVslWzDoGyWALfdiLKRDO(), 
						ControllerType.Custom => UKQZncxGBDkovrkuDNVNTIVgZGh(), 
						_ => throw new NotImplementedException(), 
					};
				}

				public ControllerPollingInfo PollControllerForFirstElement(ControllerType controllerType, int controllerId)
				{
					if (!CheckInitialized())
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Joystick => LczkahoKDJlieveHKCdxcwEFjKs(controllerId), 
						ControllerType.Keyboard => lQLJhbEfcNBpedPNxNFzjfsgToLX(), 
						ControllerType.Mouse => NZgCGvSQdAcxwOsJhcPYZrtlZtP(), 
						ControllerType.Custom => EjjcotHQwjOrcjDCNdOiZhRJao(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public ControllerPollingInfo PollControllerForFirstElementDown(ControllerType controllerType, int controllerId)
				{
					if (!CheckInitialized())
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Joystick => PINRdbgCNHgbBBophHjmKFebSPL(controllerId), 
						ControllerType.Keyboard => SeblWPqDnAwVQgRSeiLCKHnatdj(), 
						ControllerType.Mouse => CvbMVrTXhYHDrZIKlqJuHDkmKiC(), 
						ControllerType.Custom => mDTDlLnbANrUcKCXBAiHMgZsubb(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public ControllerPollingInfo PollControllerForFirstButton(ControllerType controllerType, int controllerId)
				{
					if (!CheckInitialized())
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Joystick => jXGyRogRekagpnPbsovMZcORmlz(controllerId), 
						ControllerType.Keyboard => lQLJhbEfcNBpedPNxNFzjfsgToLX(), 
						ControllerType.Mouse => ObTeBSvMSaaDdnPPqAbhskKZHAdC(), 
						ControllerType.Custom => zarblPCArDmlgkrGigwXkLLcoSB(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public ControllerPollingInfo PollControllerForFirstButtonDown(ControllerType controllerType, int controllerId)
				{
					if (!CheckInitialized())
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Joystick => bzErKaudNUvvRVXzcBcTzoynwJS(controllerId), 
						ControllerType.Keyboard => SeblWPqDnAwVQgRSeiLCKHnatdj(), 
						ControllerType.Mouse => sGHuqzQOGzcrfEGQoLNvfBTntnea(), 
						ControllerType.Custom => gnHfMCLpAFYVnLppXwqccWNuFJL(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public ControllerPollingInfo PollControllerForFirstAxis(ControllerType controllerType, int controllerId)
				{
					if (!CheckInitialized())
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Joystick => QdhsUuUATkmjfEEmEDKBEqczBoST(controllerId), 
						ControllerType.Keyboard => ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf(), 
						ControllerType.Mouse => GWhvCPrVslWzDoGyWALfdiLKRDO(), 
						ControllerType.Custom => AhjiLtixSxCgsmHtcYKddubNNGQ(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllElements()
				{
					if (!CheckInitialized())
					{
						yield break;
					}
					foreach (ControllerPollingInfo item in AzVqsenrgyjMFPcZwzHqOwexZ())
					{
						yield return item;
					}
					foreach (ControllerPollingInfo item2 in IZSVrgfNDwGCdgvessMRhggZLQgY())
					{
						yield return item2;
					}
					foreach (ControllerPollingInfo item3 in jPLyPLzcSArYFOTUKzvTQkUkbJp())
					{
						yield return item3;
					}
					foreach (ControllerPollingInfo item4 in FJsdirYVehxggDNSpATebPqSyUL())
					{
						yield return item4;
					}
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllElementsDown()
				{
					if (!CheckInitialized())
					{
						yield break;
					}
					foreach (ControllerPollingInfo item in NszfsFfWjchsTlWOMKKPqghYedHD())
					{
						yield return item;
					}
					foreach (ControllerPollingInfo item2 in apQRyVyUghxUmSBkAuvbdyHXPep())
					{
						yield return item2;
					}
					foreach (ControllerPollingInfo item3 in bTPHzlFyxXdnZzalVQcCJOTrnLU())
					{
						yield return item3;
					}
					foreach (ControllerPollingInfo item4 in flTRoHvnTZQDXDPFONfTCBadGuK())
					{
						yield return item4;
					}
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllButtons()
				{
					if (!CheckInitialized())
					{
						yield break;
					}
					foreach (ControllerPollingInfo item in dKtaKDnZSUiuRZZqwpYqFFNprOI())
					{
						yield return item;
					}
					foreach (ControllerPollingInfo item2 in IZSVrgfNDwGCdgvessMRhggZLQgY())
					{
						yield return item2;
					}
					foreach (ControllerPollingInfo item3 in IVbwFLpVnCkALhUvotTfVyfcovQ())
					{
						yield return item3;
					}
					foreach (ControllerPollingInfo item4 in uRbYFjBCCoODZEUnbkZRjIAjbUS())
					{
						yield return item4;
					}
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllButtonsDown()
				{
					if (!CheckInitialized())
					{
						yield break;
					}
					foreach (ControllerPollingInfo item in ABxExjalTAYSjARAGvGqFrwzEJX())
					{
						yield return item;
					}
					foreach (ControllerPollingInfo item2 in apQRyVyUghxUmSBkAuvbdyHXPep())
					{
						yield return item2;
					}
					foreach (ControllerPollingInfo item3 in klwBobIERIaKmQrJbuIRqXnCDdx())
					{
						yield return item3;
					}
					foreach (ControllerPollingInfo item4 in EnxdkYulKwfpxyFmfgQJAIYPqeZV())
					{
						yield return item4;
					}
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersForAllAxes()
				{
					if (!CheckInitialized())
					{
						yield break;
					}
					foreach (ControllerPollingInfo item in weRLHaWslOoGuMJDDvVgqpbuILF())
					{
						yield return item;
					}
					foreach (ControllerPollingInfo item2 in iQzhrBuoddEtyLIrXIKpafbXLYG())
					{
						yield return item2;
					}
					foreach (ControllerPollingInfo item3 in GsGSsIYMnOWfesNExUbMzDxaLMb())
					{
						yield return item3;
					}
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllElements(ControllerType controllerType, int controllerId)
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return controllerType switch
					{
						ControllerType.Joystick => xpDUdxqSuaTPBBnHlLwVOegJYFo(controllerId), 
						ControllerType.Keyboard => IZSVrgfNDwGCdgvessMRhggZLQgY(), 
						ControllerType.Mouse => jPLyPLzcSArYFOTUKzvTQkUkbJp(), 
						ControllerType.Custom => IaBOVUDboXOIbBLjBJAwjnfYgBE(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllElementsDown(ControllerType controllerType, int controllerId)
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return controllerType switch
					{
						ControllerType.Joystick => lLAtBllNQBhsvTvRnJvLvReRhEW(controllerId), 
						ControllerType.Keyboard => apQRyVyUghxUmSBkAuvbdyHXPep(), 
						ControllerType.Mouse => bTPHzlFyxXdnZzalVQcCJOTrnLU(), 
						ControllerType.Custom => xKzBrkaSqCaXLhjlQPXoecQynjm(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtons(ControllerType controllerType, int controllerId)
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return controllerType switch
					{
						ControllerType.Joystick => VRujVIWJTMntXvwGsGDplKkxXny(controllerId), 
						ControllerType.Keyboard => IZSVrgfNDwGCdgvessMRhggZLQgY(), 
						ControllerType.Mouse => IVbwFLpVnCkALhUvotTfVyfcovQ(), 
						ControllerType.Custom => kRYqsNOSSrRYeaLmeLUQrDufBYp(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtonsDown(ControllerType controllerType, int controllerId)
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return controllerType switch
					{
						ControllerType.Joystick => szOpKikkzpaEIcUHFehTguzgPMof(controllerId), 
						ControllerType.Keyboard => apQRyVyUghxUmSBkAuvbdyHXPep(), 
						ControllerType.Mouse => klwBobIERIaKmQrJbuIRqXnCDdx(), 
						ControllerType.Custom => kfGQZXiEzkPHzVsTtdnEwTduphS(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllAxes(ControllerType controllerType, int controllerId)
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return controllerType switch
					{
						ControllerType.Joystick => wSHzXdHCCCkZVjhgKzQvGcEhMzd(controllerId), 
						ControllerType.Keyboard => new List<ControllerPollingInfo>(), 
						ControllerType.Mouse => iQzhrBuoddEtyLIrXIKpafbXLYG(), 
						ControllerType.Custom => lvpLGtUELtSBrrbPLfUjdDVukXp(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				private ControllerPollingInfo BPbBTtVObmgXNwUwpliGxSWnECJ()
				{
					IList<Joystick> joysticks_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.QuGhzrzWRShGlIBQnTYoDJgwRuJ;
					for (int i = 0; i < joysticks_readOnly.Count; i++)
					{
						ControllerPollingInfo result = joysticks_readOnly[i].PollForFirstElement();
						if (result.success)
						{
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo VfLYSZjkQXiMjnsjxcZJGATBiGa()
				{
					IList<Joystick> joysticks_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.QuGhzrzWRShGlIBQnTYoDJgwRuJ;
					for (int i = 0; i < joysticks_readOnly.Count; i++)
					{
						ControllerPollingInfo result = joysticks_readOnly[i].PollForFirstElementDown();
						if (result.success)
						{
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo hKGvFBMZdfTHLXvbpEwKgahVKKY()
				{
					IList<Joystick> joysticks_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.QuGhzrzWRShGlIBQnTYoDJgwRuJ;
					for (int i = 0; i < joysticks_readOnly.Count; i++)
					{
						ControllerPollingInfo result = joysticks_readOnly[i].PollForFirstButton();
						if (result.success)
						{
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo zcFsYwMOpAENHfhLAKmpPnxiFbY()
				{
					IList<Joystick> joysticks_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.QuGhzrzWRShGlIBQnTYoDJgwRuJ;
					for (int i = 0; i < joysticks_readOnly.Count; i++)
					{
						ControllerPollingInfo result = joysticks_readOnly[i].PollForFirstButtonDown();
						if (result.success)
						{
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo wooBmHpbqPpndBLyQIDyvHKjBTN()
				{
					IList<Joystick> joysticks_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.QuGhzrzWRShGlIBQnTYoDJgwRuJ;
					for (int i = 0; i < joysticks_readOnly.Count; i++)
					{
						ControllerPollingInfo result = joysticks_readOnly[i].PollForFirstAxis();
						if (result.success)
						{
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo LczkahoKDJlieveHKCdxcwEFjKs(int P_0)
				{
					return ControllerHelper.Instance.GetJoystick(P_0)?.PollForFirstElement() ?? ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo PINRdbgCNHgbBBophHjmKFebSPL(int P_0)
				{
					return ControllerHelper.Instance.GetJoystick(P_0)?.PollForFirstElementDown() ?? ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo jXGyRogRekagpnPbsovMZcORmlz(int P_0)
				{
					return ControllerHelper.Instance.GetJoystick(P_0)?.PollForFirstButton() ?? ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo bzErKaudNUvvRVXzcBcTzoynwJS(int P_0)
				{
					return ControllerHelper.Instance.GetJoystick(P_0)?.PollForFirstButtonDown() ?? ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo QdhsUuUATkmjfEEmEDKBEqczBoST(int P_0)
				{
					return ControllerHelper.Instance.GetJoystick(P_0)?.PollForFirstAxis() ?? ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo lQLJhbEfcNBpedPNxNFzjfsgToLX()
				{
					return ControllerHelper.Instance.Keyboard.PollForFirstKey();
				}

				private ControllerPollingInfo SeblWPqDnAwVQgRSeiLCKHnatdj()
				{
					return ControllerHelper.Instance.Keyboard.PollForFirstKeyDown();
				}

				private ControllerPollingInfo NZgCGvSQdAcxwOsJhcPYZrtlZtP()
				{
					return ControllerHelper.Instance.Mouse.PollForFirstElement();
				}

				private ControllerPollingInfo CvbMVrTXhYHDrZIKlqJuHDkmKiC()
				{
					return ControllerHelper.Instance.Mouse.PollForFirstElementDown();
				}

				private ControllerPollingInfo ObTeBSvMSaaDdnPPqAbhskKZHAdC()
				{
					return ControllerHelper.Instance.Mouse.PollForFirstButton();
				}

				private ControllerPollingInfo sGHuqzQOGzcrfEGQoLNvfBTntnea()
				{
					return ControllerHelper.Instance.Mouse.PollForFirstButtonDown();
				}

				private ControllerPollingInfo GWhvCPrVslWzDoGyWALfdiLKRDO()
				{
					return ControllerHelper.Instance.Mouse.PollForFirstAxis();
				}

				private ControllerPollingInfo GWmZWnlHxFEUXieGzCzMXyqSnuO()
				{
					IList<CustomController> customControllers_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.UdNZzQLwzZqRhoPLnGarHXcAtGx;
					for (int i = 0; i < customControllers_readOnly.Count; i++)
					{
						ControllerPollingInfo result = customControllers_readOnly[i].PollForFirstElement();
						if (result.success)
						{
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo tTXahHrgTVligFjVfbqIqtLOsQW()
				{
					IList<CustomController> customControllers_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.UdNZzQLwzZqRhoPLnGarHXcAtGx;
					for (int i = 0; i < customControllers_readOnly.Count; i++)
					{
						ControllerPollingInfo result = customControllers_readOnly[i].PollForFirstElementDown();
						if (result.success)
						{
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo TeEcjHksFDwZLuxeBsznKVzDVrn()
				{
					IList<CustomController> customControllers_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.UdNZzQLwzZqRhoPLnGarHXcAtGx;
					for (int i = 0; i < customControllers_readOnly.Count; i++)
					{
						ControllerPollingInfo result = customControllers_readOnly[i].PollForFirstButton();
						if (result.success)
						{
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo vvIEmvquKUQmjMeXbFoiRcSXWZH()
				{
					IList<CustomController> customControllers_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.UdNZzQLwzZqRhoPLnGarHXcAtGx;
					for (int i = 0; i < customControllers_readOnly.Count; i++)
					{
						ControllerPollingInfo result = customControllers_readOnly[i].PollForFirstButtonDown();
						if (result.success)
						{
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo UKQZncxGBDkovrkuDNVNTIVgZGh()
				{
					IList<CustomController> customControllers_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.UdNZzQLwzZqRhoPLnGarHXcAtGx;
					for (int i = 0; i < customControllers_readOnly.Count; i++)
					{
						ControllerPollingInfo result = customControllers_readOnly[i].PollForFirstAxis();
						if (result.success)
						{
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo EjjcotHQwjOrcjDCNdOiZhRJao(int P_0)
				{
					return ControllerHelper.Instance.GetCustomController(P_0)?.PollForFirstElement() ?? ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo mDTDlLnbANrUcKCXBAiHMgZsubb(int P_0)
				{
					return ControllerHelper.Instance.GetCustomController(P_0)?.PollForFirstElementDown() ?? ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo zarblPCArDmlgkrGigwXkLLcoSB(int P_0)
				{
					return ControllerHelper.Instance.GetCustomController(P_0)?.PollForFirstButton() ?? ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo gnHfMCLpAFYVnLppXwqccWNuFJL(int P_0)
				{
					return ControllerHelper.Instance.GetCustomController(P_0)?.PollForFirstButtonDown() ?? ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo AhjiLtixSxCgsmHtcYKddubNNGQ(int P_0)
				{
					return ControllerHelper.Instance.GetCustomController(P_0)?.PollForFirstAxis() ?? ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private IEnumerable<ControllerPollingInfo> AzVqsenrgyjMFPcZwzHqOwexZ()
				{
					IList<Joystick> joysticks_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.QuGhzrzWRShGlIBQnTYoDJgwRuJ;
					for (int i = 0; i < joysticks_readOnly.Count; i++)
					{
						foreach (ControllerPollingInfo item in joysticks_readOnly[i].PollForAllElements())
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> NszfsFfWjchsTlWOMKKPqghYedHD()
				{
					IList<Joystick> joysticks_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.QuGhzrzWRShGlIBQnTYoDJgwRuJ;
					for (int i = 0; i < joysticks_readOnly.Count; i++)
					{
						foreach (ControllerPollingInfo item in joysticks_readOnly[i].PollForAllElementsDown())
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> dKtaKDnZSUiuRZZqwpYqFFNprOI()
				{
					IList<Joystick> joysticks_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.QuGhzrzWRShGlIBQnTYoDJgwRuJ;
					for (int i = 0; i < joysticks_readOnly.Count; i++)
					{
						foreach (ControllerPollingInfo item in joysticks_readOnly[i].PollForAllButtons())
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> ABxExjalTAYSjARAGvGqFrwzEJX()
				{
					IList<Joystick> joysticks_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.QuGhzrzWRShGlIBQnTYoDJgwRuJ;
					for (int i = 0; i < joysticks_readOnly.Count; i++)
					{
						foreach (ControllerPollingInfo item in joysticks_readOnly[i].PollForAllButtonsDown())
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> weRLHaWslOoGuMJDDvVgqpbuILF()
				{
					IList<Joystick> joysticks_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.QuGhzrzWRShGlIBQnTYoDJgwRuJ;
					for (int i = 0; i < joysticks_readOnly.Count; i++)
					{
						foreach (ControllerPollingInfo item in joysticks_readOnly[i].PollForAllAxes())
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> xpDUdxqSuaTPBBnHlLwVOegJYFo(int P_0)
				{
					Joystick joystick = ControllerHelper.Instance.GetJoystick(P_0);
					if (joystick == null)
					{
						return new List<ControllerPollingInfo>();
					}
					return joystick.PollForAllElements();
				}

				private IEnumerable<ControllerPollingInfo> lLAtBllNQBhsvTvRnJvLvReRhEW(int P_0)
				{
					Joystick joystick = ControllerHelper.Instance.GetJoystick(P_0);
					if (joystick == null)
					{
						return new List<ControllerPollingInfo>();
					}
					return joystick.PollForAllElementsDown();
				}

				private IEnumerable<ControllerPollingInfo> VRujVIWJTMntXvwGsGDplKkxXny(int P_0)
				{
					Joystick joystick = ControllerHelper.Instance.GetJoystick(P_0);
					if (joystick == null)
					{
						return new List<ControllerPollingInfo>();
					}
					return joystick.PollForAllButtons();
				}

				private IEnumerable<ControllerPollingInfo> szOpKikkzpaEIcUHFehTguzgPMof(int P_0)
				{
					Joystick joystick = ControllerHelper.Instance.GetJoystick(P_0);
					if (joystick == null)
					{
						return new List<ControllerPollingInfo>();
					}
					return joystick.PollForAllButtonsDown();
				}

				private IEnumerable<ControllerPollingInfo> wSHzXdHCCCkZVjhgKzQvGcEhMzd(int P_0)
				{
					Joystick joystick = ControllerHelper.Instance.GetJoystick(P_0);
					if (joystick == null)
					{
						return new List<ControllerPollingInfo>();
					}
					return joystick.PollForAllAxes();
				}

				private IEnumerable<ControllerPollingInfo> IZSVrgfNDwGCdgvessMRhggZLQgY()
				{
					return ControllerHelper.Instance.Keyboard.PollForAllKeys();
				}

				private IEnumerable<ControllerPollingInfo> apQRyVyUghxUmSBkAuvbdyHXPep()
				{
					return ControllerHelper.Instance.Keyboard.PollForAllKeysDown();
				}

				private IEnumerable<ControllerPollingInfo> jPLyPLzcSArYFOTUKzvTQkUkbJp()
				{
					return ControllerHelper.Instance.Mouse.PollForAllElements();
				}

				private IEnumerable<ControllerPollingInfo> bTPHzlFyxXdnZzalVQcCJOTrnLU()
				{
					return ControllerHelper.Instance.Mouse.PollForAllElementsDown();
				}

				private IEnumerable<ControllerPollingInfo> IVbwFLpVnCkALhUvotTfVyfcovQ()
				{
					return ControllerHelper.Instance.Mouse.PollForAllButtons();
				}

				private IEnumerable<ControllerPollingInfo> klwBobIERIaKmQrJbuIRqXnCDdx()
				{
					return ControllerHelper.Instance.Mouse.PollForAllButtonsDown();
				}

				private IEnumerable<ControllerPollingInfo> iQzhrBuoddEtyLIrXIKpafbXLYG()
				{
					return ControllerHelper.Instance.Mouse.PollForAllAxes();
				}

				private IEnumerable<ControllerPollingInfo> FJsdirYVehxggDNSpATebPqSyUL()
				{
					IList<CustomController> customControllers_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.UdNZzQLwzZqRhoPLnGarHXcAtGx;
					for (int i = 0; i < customControllers_readOnly.Count; i++)
					{
						foreach (ControllerPollingInfo item in customControllers_readOnly[i].PollForAllElements())
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> flTRoHvnTZQDXDPFONfTCBadGuK()
				{
					IList<CustomController> customControllers_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.UdNZzQLwzZqRhoPLnGarHXcAtGx;
					for (int i = 0; i < customControllers_readOnly.Count; i++)
					{
						foreach (ControllerPollingInfo item in customControllers_readOnly[i].PollForAllElementsDown())
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> uRbYFjBCCoODZEUnbkZRjIAjbUS()
				{
					IList<CustomController> customControllers_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.UdNZzQLwzZqRhoPLnGarHXcAtGx;
					for (int i = 0; i < customControllers_readOnly.Count; i++)
					{
						foreach (ControllerPollingInfo item in customControllers_readOnly[i].PollForAllButtons())
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> EnxdkYulKwfpxyFmfgQJAIYPqeZV()
				{
					IList<CustomController> customControllers_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.UdNZzQLwzZqRhoPLnGarHXcAtGx;
					for (int i = 0; i < customControllers_readOnly.Count; i++)
					{
						foreach (ControllerPollingInfo item in customControllers_readOnly[i].PollForAllButtonsDown())
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> GsGSsIYMnOWfesNExUbMzDxaLMb()
				{
					IList<CustomController> customControllers_readOnly = CoyPNJHWMheFytmTMQdqyctMRFl.UdNZzQLwzZqRhoPLnGarHXcAtGx;
					for (int i = 0; i < customControllers_readOnly.Count; i++)
					{
						foreach (ControllerPollingInfo item in customControllers_readOnly[i].PollForAllAxes())
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> IaBOVUDboXOIbBLjBJAwjnfYgBE(int P_0)
				{
					CustomController customController = ControllerHelper.Instance.GetCustomController(P_0);
					if (customController == null)
					{
						return new List<ControllerPollingInfo>();
					}
					return customController.PollForAllElements();
				}

				private IEnumerable<ControllerPollingInfo> xKzBrkaSqCaXLhjlQPXoecQynjm(int P_0)
				{
					CustomController customController = ControllerHelper.Instance.GetCustomController(P_0);
					if (customController == null)
					{
						return new List<ControllerPollingInfo>();
					}
					return customController.PollForAllElementsDown();
				}

				private IEnumerable<ControllerPollingInfo> kRYqsNOSSrRYeaLmeLUQrDufBYp(int P_0)
				{
					CustomController customController = ControllerHelper.Instance.GetCustomController(P_0);
					if (customController == null)
					{
						return new List<ControllerPollingInfo>();
					}
					return customController.PollForAllButtons();
				}

				private IEnumerable<ControllerPollingInfo> kfGQZXiEzkPHzVsTtdnEwTduphS(int P_0)
				{
					CustomController customController = ControllerHelper.Instance.GetCustomController(P_0);
					if (customController == null)
					{
						return new List<ControllerPollingInfo>();
					}
					return customController.PollForAllButtonsDown();
				}

				private IEnumerable<ControllerPollingInfo> lvpLGtUELtSBrrbPLfUjdDVukXp(int P_0)
				{
					CustomController customController = ControllerHelper.Instance.GetCustomController(P_0);
					if (customController == null)
					{
						return new List<ControllerPollingInfo>();
					}
					return customController.PollForAllAxes();
				}
			}

			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public sealed class ConflictCheckingHelper : CodeHelper
			{
				private static ConflictCheckingHelper GclIwrgVrnJKTEKbDVzknvtphRgP;

				internal static ConflictCheckingHelper Instance => GclIwrgVrnJKTEKbDVzknvtphRgP ?? (GclIwrgVrnJKTEKbDVzknvtphRgP = new ConflictCheckingHelper());

				private ConflictCheckingHelper()
				{
				}

				public bool DoesAnyElementAssignmentConflict()
				{
					return DoesAnyElementAssignmentConflict(skipDisabledMaps: false, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public bool DoesAnyElementAssignmentConflict(bool skipDisabledMaps)
				{
					return DoesAnyElementAssignmentConflict(skipDisabledMaps, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public bool DoesAnyElementAssignmentConflict(bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return DoesAnyElementAssignmentConflict(skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer: true);
				}

				public bool DoesAnyElementAssignmentConflict(bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					if (!CheckInitialized())
					{
						return false;
					}
					IList<Player> list = (includeSystemPlayer ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					int count = list.Count;
					for (int i = 0; i < count; i++)
					{
						Player player = list[i];
						int num = (forceCheckAllCategories ? i : 0);
						IList<Joystick> joysticks = player.controllers.Joysticks;
						for (int j = 0; j < joysticks.Count; j++)
						{
							Joystick joystick = joysticks[j];
							IList<JoystickMap> maps = player.controllers.maps.GetMaps<JoystickMap>(joystick.id);
							if (maps == null)
							{
								continue;
							}
							int count2 = maps.Count;
							for (int k = num; k < count; k++)
							{
								Player player2 = list[k];
								for (int l = 0; l < count2; l++)
								{
									if (player2.controllers.conflictChecking.DoesElementAssignmentConflict(ControllerType.Joystick, joystick.id, maps[l], skipDisabledMaps, forceCheckAllCategories))
									{
										return true;
									}
								}
							}
						}
						IList<KeyboardMap> maps2 = player.controllers.maps.GetMaps<KeyboardMap>(0);
						for (int m = 0; m < maps2.Count; m++)
						{
							for (int n = num; n < count; n++)
							{
								Player player3 = list[n];
								if (player3.controllers.conflictChecking.DoesElementAssignmentConflict(ControllerType.Keyboard, 0, maps2[m], skipDisabledMaps, forceCheckAllCategories))
								{
									return true;
								}
							}
						}
						IList<MouseMap> maps3 = player.controllers.maps.GetMaps<MouseMap>(0);
						for (int num2 = 0; num2 < maps3.Count; num2++)
						{
							for (int num3 = num; num3 < count; num3++)
							{
								Player player4 = list[num3];
								if (player4.controllers.conflictChecking.DoesElementAssignmentConflict(ControllerType.Mouse, 0, maps3[num2], skipDisabledMaps, forceCheckAllCategories))
								{
									return true;
								}
							}
						}
						IList<CustomController> customControllers = player.controllers.CustomControllers;
						for (int num4 = 0; num4 < customControllers.Count; num4++)
						{
							CustomController customController = customControllers[num4];
							IList<CustomControllerMap> maps4 = player.controllers.maps.GetMaps<CustomControllerMap>(customController.id);
							if (maps4 == null)
							{
								continue;
							}
							int count3 = maps4.Count;
							for (int num5 = num; num5 < count; num5++)
							{
								Player player5 = list[num5];
								for (int num6 = 0; num6 < count3; num6++)
								{
									if (player5.controllers.conflictChecking.DoesElementAssignmentConflict(ControllerType.Custom, customController.id, maps4[num6], skipDisabledMaps, forceCheckAllCategories))
									{
										return true;
									}
								}
							}
						}
					}
					return false;
				}

				public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap)
				{
					return DoesElementAssignmentConflict(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps: false, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps)
				{
					return DoesElementAssignmentConflict(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return DoesElementAssignmentConflict(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer: true);
				}

				public bool DoesElementAssignmentConflict(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					if (!CheckInitialized())
					{
						return false;
					}
					if (playerId < 0 || elementMap == null)
					{
						return false;
					}
					return controllerType switch
					{
						ControllerType.Joystick => nEhbukTxJoogeoYMPiDFXtMdURf(playerId, controllerId, controllerMap as JoystickMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer), 
						ControllerType.Keyboard => GRBaNcJXMVhcTkXjgxiAmKaPlSn(playerId, controllerMap as KeyboardMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer), 
						ControllerType.Mouse => YKieasQQVrKzfohxaiObfdVbINK(playerId, controllerMap as MouseMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer), 
						ControllerType.Custom => nGGUGsJicNGXFSgERmmfjmFrGIO(playerId, controllerId, controllerMap as CustomControllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer), 
						_ => throw new NotImplementedException(), 
					};
				}

				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck)
				{
					return DoesElementAssignmentConflict(conflictCheck, skipDisabledMaps: false, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
				{
					return DoesElementAssignmentConflict(conflictCheck, skipDisabledMaps, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return DoesElementAssignmentConflict(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer: true);
				}

				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					if (!CheckInitialized())
					{
						return false;
					}
					if (conflictCheck.playerId < 0)
					{
						return false;
					}
					if (conflictCheck.controllerType == ControllerType.Joystick)
					{
						return nEhbukTxJoogeoYMPiDFXtMdURf(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
					}
					if (conflictCheck.controllerType == ControllerType.Keyboard)
					{
						return GRBaNcJXMVhcTkXjgxiAmKaPlSn(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
					}
					if (conflictCheck.controllerType == ControllerType.Mouse)
					{
						return YKieasQQVrKzfohxaiObfdVbINK(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
					}
					if (conflictCheck.controllerType == ControllerType.Custom)
					{
						return nGGUGsJicNGXFSgERmmfjmFrGIO(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
					}
					throw new NotImplementedException();
				}

				private bool nEhbukTxJoogeoYMPiDFXtMdURf(int P_0, int P_1, JoystickMap P_2, ActionElementMap P_3, bool P_4 = false, bool P_5 = false, bool P_6 = true)
				{
					if (P_0 < 0 || P_3 == null)
					{
						return false;
					}
					IList<Player> list = (P_6 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i].controllers.conflictChecking.DoesElementAssignmentConflict(ControllerType.Joystick, P_1, P_2, P_3, P_4, P_5))
						{
							return true;
						}
					}
					return false;
				}

				private bool nEhbukTxJoogeoYMPiDFXtMdURf(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					if (P_0.playerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return false;
					}
					IList<Player> list = (P_3 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i].controllers.conflictChecking.DoesElementAssignmentConflict(P_0, P_1, P_2))
						{
							return true;
						}
					}
					return false;
				}

				private bool GRBaNcJXMVhcTkXjgxiAmKaPlSn(int P_0, KeyboardMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, bool P_5 = true)
				{
					if (P_0 < 0 || P_2 == null)
					{
						return false;
					}
					IList<Player> list = (P_5 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i].controllers.conflictChecking.DoesElementAssignmentConflict(ControllerType.Keyboard, 0, P_1, P_2, P_3, P_4))
						{
							return true;
						}
					}
					return false;
				}

				private bool GRBaNcJXMVhcTkXjgxiAmKaPlSn(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					if (P_0.playerId < 0 || P_0.elementAssignmentType != ElementAssignmentType.KeyboardKey)
					{
						return false;
					}
					IList<Player> list = (P_3 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i].controllers.conflictChecking.DoesElementAssignmentConflict(P_0, P_1, P_2))
						{
							return true;
						}
					}
					return false;
				}

				private bool YKieasQQVrKzfohxaiObfdVbINK(int P_0, MouseMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, bool P_5 = true)
				{
					if (P_0 < 0 || P_2 == null)
					{
						return false;
					}
					IList<Player> list = (P_5 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i].controllers.conflictChecking.DoesElementAssignmentConflict(ControllerType.Mouse, 0, P_1, P_2, P_3, P_4))
						{
							return true;
						}
					}
					return false;
				}

				private bool YKieasQQVrKzfohxaiObfdVbINK(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					if (P_0.playerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return false;
					}
					IList<Player> list = (P_3 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i].controllers.conflictChecking.DoesElementAssignmentConflict(P_0, P_1, P_2))
						{
							return true;
						}
					}
					return false;
				}

				private bool nGGUGsJicNGXFSgERmmfjmFrGIO(int P_0, int P_1, CustomControllerMap P_2, ActionElementMap P_3, bool P_4 = false, bool P_5 = false, bool P_6 = true)
				{
					if (P_0 < 0 || P_3 == null)
					{
						return false;
					}
					IList<Player> list = (P_6 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i].controllers.conflictChecking.DoesElementAssignmentConflict(ControllerType.Custom, P_1, P_2, P_3, P_4, P_5))
						{
							return true;
						}
					}
					return false;
				}

				private bool nGGUGsJicNGXFSgERmmfjmFrGIO(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					if (P_0.playerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return false;
					}
					IList<Player> list = (P_3 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					for (int i = 0; i < list.Count; i++)
					{
						if (list[i].controllers.conflictChecking.DoesElementAssignmentConflict(P_0, P_1, P_2))
						{
							return true;
						}
					}
					return false;
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap)
				{
					return ElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps: false, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps)
				{
					return ElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return ElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer: true);
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<ElementAssignmentConflictInfo>.EmptyReadOnlyIListT;
					}
					if (playerId < 0 || elementMap == null)
					{
						return new List<ElementAssignmentConflictInfo>();
					}
					return controllerType switch
					{
						ControllerType.Joystick => ovVhMPUGdKMyeIHUpnYEeSAVoWK(playerId, controllerId, controllerMap as JoystickMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer), 
						ControllerType.Keyboard => ZtwVhrXLSmVwJBLVomdQQKBJiGVJ(playerId, controllerMap as KeyboardMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer), 
						ControllerType.Mouse => yzUxeeiyTvyPpMILyGefFtVWraB(playerId, controllerMap as MouseMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer), 
						ControllerType.Custom => LbCfSwQIwvnTAsieuPticQfySkh(playerId, controllerId, controllerMap as CustomControllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
				{
					return ElementAssignmentConflicts(conflictCheck, skipDisabledMaps: false, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
				{
					return ElementAssignmentConflicts(conflictCheck, skipDisabledMaps, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return ElementAssignmentConflicts(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer: true);
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<ElementAssignmentConflictInfo>.EmptyReadOnlyIListT;
					}
					if (conflictCheck.playerId < 0)
					{
						return new List<ElementAssignmentConflictInfo>();
					}
					if (conflictCheck.controllerType == ControllerType.Joystick)
					{
						return ovVhMPUGdKMyeIHUpnYEeSAVoWK(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
					}
					if (conflictCheck.controllerType == ControllerType.Keyboard)
					{
						return ZtwVhrXLSmVwJBLVomdQQKBJiGVJ(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
					}
					if (conflictCheck.controllerType == ControllerType.Mouse)
					{
						return yzUxeeiyTvyPpMILyGefFtVWraB(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
					}
					if (conflictCheck.controllerType == ControllerType.Custom)
					{
						return LbCfSwQIwvnTAsieuPticQfySkh(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
					}
					throw new NotImplementedException();
				}

				private IEnumerable<ElementAssignmentConflictInfo> ovVhMPUGdKMyeIHUpnYEeSAVoWK(int P_0, int P_1, JoystickMap P_2, ActionElementMap P_3, bool P_4 = false, bool P_5 = false, bool P_6 = true)
				{
					if (P_0 < 0 || P_3 == null)
					{
						yield break;
					}
					IList<Player> list = (P_6 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					for (int i = 0; i < list.Count; i++)
					{
						foreach (ElementAssignmentConflictInfo item in list[i].controllers.conflictChecking.ElementAssignmentConflicts(ControllerType.Joystick, P_1, P_2, P_3, P_4, P_5))
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ElementAssignmentConflictInfo> ovVhMPUGdKMyeIHUpnYEeSAVoWK(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					if (P_0.playerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						yield break;
					}
					IList<Player> list = (P_3 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					for (int i = 0; i < list.Count; i++)
					{
						foreach (ElementAssignmentConflictInfo item in list[i].controllers.conflictChecking.ElementAssignmentConflicts(P_0, P_1, P_2))
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ElementAssignmentConflictInfo> ZtwVhrXLSmVwJBLVomdQQKBJiGVJ(int P_0, KeyboardMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, bool P_5 = true)
				{
					if (P_0 < 0 || P_2 == null)
					{
						yield break;
					}
					IList<Player> list = (P_5 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					for (int i = 0; i < list.Count; i++)
					{
						foreach (ElementAssignmentConflictInfo item in list[i].controllers.conflictChecking.ElementAssignmentConflicts(ControllerType.Keyboard, 0, P_1, P_2, P_3, P_4))
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ElementAssignmentConflictInfo> ZtwVhrXLSmVwJBLVomdQQKBJiGVJ(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					if (P_0.playerId < 0 || P_0.elementAssignmentType != ElementAssignmentType.KeyboardKey)
					{
						yield break;
					}
					IList<Player> list = (P_3 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					for (int i = 0; i < list.Count; i++)
					{
						foreach (ElementAssignmentConflictInfo item in list[i].controllers.conflictChecking.ElementAssignmentConflicts(P_0, P_1, P_2))
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ElementAssignmentConflictInfo> yzUxeeiyTvyPpMILyGefFtVWraB(int P_0, MouseMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, bool P_5 = true)
				{
					if (P_0 < 0 || P_2 == null)
					{
						yield break;
					}
					IList<Player> list = (P_5 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					for (int i = 0; i < list.Count; i++)
					{
						foreach (ElementAssignmentConflictInfo item in list[i].controllers.conflictChecking.ElementAssignmentConflicts(ControllerType.Mouse, 0, P_1, P_2, P_3, P_4))
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ElementAssignmentConflictInfo> yzUxeeiyTvyPpMILyGefFtVWraB(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					if (P_0.playerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						yield break;
					}
					IList<Player> list = (P_3 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					for (int i = 0; i < list.Count; i++)
					{
						foreach (ElementAssignmentConflictInfo item in list[i].controllers.conflictChecking.ElementAssignmentConflicts(P_0, P_1, P_2))
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ElementAssignmentConflictInfo> LbCfSwQIwvnTAsieuPticQfySkh(int P_0, int P_1, CustomControllerMap P_2, ActionElementMap P_3, bool P_4 = false, bool P_5 = false, bool P_6 = true)
				{
					if (P_0 < 0 || P_3 == null)
					{
						yield break;
					}
					IList<Player> list = (P_6 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					for (int i = 0; i < list.Count; i++)
					{
						foreach (ElementAssignmentConflictInfo item in list[i].controllers.conflictChecking.ElementAssignmentConflicts(ControllerType.Custom, P_1, P_2, P_3, P_4, P_5))
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ElementAssignmentConflictInfo> LbCfSwQIwvnTAsieuPticQfySkh(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					if (P_0.playerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						yield break;
					}
					IList<Player> list = (P_3 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					for (int i = 0; i < list.Count; i++)
					{
						foreach (ElementAssignmentConflictInfo item in list[i].controllers.conflictChecking.ElementAssignmentConflicts(P_0, P_1, P_2))
						{
							yield return item;
						}
					}
				}

				public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap)
				{
					return RemoveElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps: false, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps)
				{
					return RemoveElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return RemoveElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer: true);
				}

				public int RemoveElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					if (!CheckInitialized())
					{
						return 0;
					}
					if (playerId < 0 || elementMap == null)
					{
						return 0;
					}
					return controllerType switch
					{
						ControllerType.Joystick => XrBSFaLDuPvaOITiDPJZWXQhLdb(playerId, controllerId, controllerMap as JoystickMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer), 
						ControllerType.Keyboard => gnWsOLADmvFPsglRVUyXoIdgycDi(playerId, controllerMap as KeyboardMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer), 
						ControllerType.Mouse => WOuyksrfrZXvkbYZHtnkerIDHyl(playerId, controllerMap as MouseMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer), 
						ControllerType.Custom => QDRERpSVHOvlOLheWFpyEHUNVUNE(playerId, controllerId, controllerMap as CustomControllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer), 
						_ => throw new NotImplementedException(), 
					};
				}

				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
				{
					return RemoveElementAssignmentConflicts(conflictCheck, skipDisabledMaps: false, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
				{
					return RemoveElementAssignmentConflicts(conflictCheck, skipDisabledMaps, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return RemoveElementAssignmentConflicts(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer: true);
				}

				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					if (!CheckInitialized())
					{
						return 0;
					}
					if (conflictCheck.playerId < 0)
					{
						return 0;
					}
					if (conflictCheck.controllerType == ControllerType.Joystick)
					{
						return XrBSFaLDuPvaOITiDPJZWXQhLdb(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
					}
					if (conflictCheck.controllerType == ControllerType.Keyboard)
					{
						return gnWsOLADmvFPsglRVUyXoIdgycDi(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
					}
					if (conflictCheck.controllerType == ControllerType.Mouse)
					{
						return WOuyksrfrZXvkbYZHtnkerIDHyl(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
					}
					if (conflictCheck.controllerType == ControllerType.Custom)
					{
						return QDRERpSVHOvlOLheWFpyEHUNVUNE(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
					}
					throw new NotImplementedException();
				}

				private int XrBSFaLDuPvaOITiDPJZWXQhLdb(int P_0, int P_1, JoystickMap P_2, ActionElementMap P_3, bool P_4 = false, bool P_5 = false, bool P_6 = true)
				{
					if (P_0 < 0 || P_3 == null)
					{
						return 0;
					}
					IList<Player> list = (P_6 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					int num = 0;
					for (int i = 0; i < list.Count; i++)
					{
						num += list[i].controllers.conflictChecking.RemoveElementAssignmentConflicts(ControllerType.Joystick, P_1, P_2, P_3, P_4, P_5);
					}
					return num;
				}

				private int XrBSFaLDuPvaOITiDPJZWXQhLdb(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					if (P_0.playerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return 0;
					}
					IList<Player> list = (P_3 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					int num = 0;
					for (int i = 0; i < list.Count; i++)
					{
						num += list[i].controllers.conflictChecking.RemoveElementAssignmentConflicts(P_0, P_1, P_2);
					}
					return num;
				}

				private int gnWsOLADmvFPsglRVUyXoIdgycDi(int P_0, KeyboardMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, bool P_5 = true)
				{
					if (P_0 < 0 || P_2 == null)
					{
						return 0;
					}
					IList<Player> list = (P_5 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					int num = 0;
					for (int i = 0; i < list.Count; i++)
					{
						num += list[i].controllers.conflictChecking.RemoveElementAssignmentConflicts(ControllerType.Keyboard, 0, P_1, P_2, P_3, P_4);
					}
					return num;
				}

				private int gnWsOLADmvFPsglRVUyXoIdgycDi(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					if (P_0.playerId < 0 || P_0.elementAssignmentType != ElementAssignmentType.KeyboardKey)
					{
						return 0;
					}
					IList<Player> list = (P_3 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					int num = 0;
					for (int i = 0; i < list.Count; i++)
					{
						num += list[i].controllers.conflictChecking.RemoveElementAssignmentConflicts(P_0, P_1, P_2);
					}
					return num;
				}

				private int WOuyksrfrZXvkbYZHtnkerIDHyl(int P_0, MouseMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, bool P_5 = true)
				{
					if (P_0 < 0 || P_2 == null)
					{
						return 0;
					}
					IList<Player> list = (P_5 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					int num = 0;
					for (int i = 0; i < list.Count; i++)
					{
						num += list[i].controllers.conflictChecking.RemoveElementAssignmentConflicts(ControllerType.Mouse, 0, P_1, P_2, P_3, P_4);
					}
					return num;
				}

				private int WOuyksrfrZXvkbYZHtnkerIDHyl(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					if (P_0.playerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return 0;
					}
					IList<Player> list = (P_3 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					int num = 0;
					for (int i = 0; i < list.Count; i++)
					{
						num += list[i].controllers.conflictChecking.RemoveElementAssignmentConflicts(P_0, P_1, P_2);
					}
					return num;
				}

				private int QDRERpSVHOvlOLheWFpyEHUNVUNE(int P_0, int P_1, CustomControllerMap P_2, ActionElementMap P_3, bool P_4 = false, bool P_5 = false, bool P_6 = true)
				{
					if (P_0 < 0 || P_3 == null)
					{
						return 0;
					}
					IList<Player> list = (P_6 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					int num = 0;
					for (int i = 0; i < list.Count; i++)
					{
						num += list[i].controllers.conflictChecking.RemoveElementAssignmentConflicts(ControllerType.Custom, P_1, P_2, P_3, P_4, P_5);
					}
					return num;
				}

				private int QDRERpSVHOvlOLheWFpyEHUNVUNE(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					if (P_0.playerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return 0;
					}
					IList<Player> list = (P_3 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					int num = 0;
					for (int i = 0; i < list.Count; i++)
					{
						num += list[i].controllers.conflictChecking.RemoveElementAssignmentConflicts(P_0, P_1, P_2);
					}
					return num;
				}

				public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap)
				{
					return DisableElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps: false, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps)
				{
					return DisableElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return DisableElementAssignmentConflicts(playerId, controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer: true);
				}

				public int DisableElementAssignmentConflicts(int playerId, ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					if (!CheckInitialized())
					{
						return 0;
					}
					if (playerId < 0 || elementMap == null)
					{
						return 0;
					}
					return controllerType switch
					{
						ControllerType.Joystick => xROTkvKCYEEhqCGQlCygddnTHGp(playerId, controllerId, controllerMap as JoystickMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer), 
						ControllerType.Keyboard => mLWHAWdmtdBqFyWKBGUIqzNNUYI(playerId, controllerMap as KeyboardMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer), 
						ControllerType.Mouse => JEEekeKFReIWkGTEKeDemfveetl(playerId, controllerMap as MouseMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer), 
						ControllerType.Custom => GDcDJxAxhlFNPZOHoLDBFMRxjYIY(playerId, controllerId, controllerMap as CustomControllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer), 
						_ => throw new NotImplementedException(), 
					};
				}

				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
				{
					return DisableElementAssignmentConflicts(conflictCheck, skipDisabledMaps: false, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
				{
					return DisableElementAssignmentConflicts(conflictCheck, skipDisabledMaps, forceCheckAllCategories: false, includeSystemPlayer: true);
				}

				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					return DisableElementAssignmentConflicts(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer: true);
				}

				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories, bool includeSystemPlayer)
				{
					if (!CheckInitialized())
					{
						return 0;
					}
					if (conflictCheck.playerId < 0)
					{
						return 0;
					}
					if (conflictCheck.controllerType == ControllerType.Joystick)
					{
						return xROTkvKCYEEhqCGQlCygddnTHGp(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
					}
					if (conflictCheck.controllerType == ControllerType.Keyboard)
					{
						return mLWHAWdmtdBqFyWKBGUIqzNNUYI(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
					}
					if (conflictCheck.controllerType == ControllerType.Mouse)
					{
						return JEEekeKFReIWkGTEKeDemfveetl(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
					}
					if (conflictCheck.controllerType == ControllerType.Custom)
					{
						return GDcDJxAxhlFNPZOHoLDBFMRxjYIY(conflictCheck, skipDisabledMaps, forceCheckAllCategories, includeSystemPlayer);
					}
					throw new NotImplementedException();
				}

				private int xROTkvKCYEEhqCGQlCygddnTHGp(int P_0, int P_1, JoystickMap P_2, ActionElementMap P_3, bool P_4 = false, bool P_5 = false, bool P_6 = true)
				{
					if (P_0 < 0 || P_3 == null)
					{
						return 0;
					}
					IList<Player> list = (P_6 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					int num = 0;
					for (int i = 0; i < list.Count; i++)
					{
						num += list[i].controllers.conflictChecking.DisableElementAssignmentConflicts(ControllerType.Joystick, P_1, P_2, P_3, P_4, P_5);
					}
					return num;
				}

				private int xROTkvKCYEEhqCGQlCygddnTHGp(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					if (P_0.playerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return 0;
					}
					IList<Player> list = (P_3 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					int num = 0;
					for (int i = 0; i < list.Count; i++)
					{
						num += list[i].controllers.conflictChecking.DisableElementAssignmentConflicts(P_0, P_1, P_2);
					}
					return num;
				}

				private int mLWHAWdmtdBqFyWKBGUIqzNNUYI(int P_0, KeyboardMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, bool P_5 = true)
				{
					if (P_0 < 0 || P_2 == null)
					{
						return 0;
					}
					IList<Player> list = (P_5 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					int num = 0;
					for (int i = 0; i < list.Count; i++)
					{
						num += list[i].controllers.conflictChecking.DisableElementAssignmentConflicts(ControllerType.Keyboard, 0, P_1, P_2, P_3, P_4);
					}
					return num;
				}

				private int mLWHAWdmtdBqFyWKBGUIqzNNUYI(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					if (P_0.playerId < 0 || P_0.elementAssignmentType != ElementAssignmentType.KeyboardKey)
					{
						return 0;
					}
					IList<Player> list = (P_3 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					int num = 0;
					for (int i = 0; i < list.Count; i++)
					{
						num += list[i].controllers.conflictChecking.DisableElementAssignmentConflicts(P_0, P_1, P_2);
					}
					return num;
				}

				private int JEEekeKFReIWkGTEKeDemfveetl(int P_0, MouseMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, bool P_5 = true)
				{
					if (P_0 < 0 || P_2 == null)
					{
						return 0;
					}
					IList<Player> list = (P_5 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					int num = 0;
					for (int i = 0; i < list.Count; i++)
					{
						num += list[i].controllers.conflictChecking.DisableElementAssignmentConflicts(ControllerType.Mouse, 0, P_1, P_2, P_3, P_4);
					}
					return num;
				}

				private int JEEekeKFReIWkGTEKeDemfveetl(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					if (P_0.playerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return 0;
					}
					IList<Player> list = (P_3 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					int num = 0;
					for (int i = 0; i < list.Count; i++)
					{
						num += list[i].controllers.conflictChecking.DisableElementAssignmentConflicts(P_0, P_1, P_2);
					}
					return num;
				}

				private int GDcDJxAxhlFNPZOHoLDBFMRxjYIY(int P_0, int P_1, CustomControllerMap P_2, ActionElementMap P_3, bool P_4 = false, bool P_5 = false, bool P_6 = true)
				{
					if (P_0 < 0 || P_3 == null)
					{
						return 0;
					}
					IList<Player> list = (P_6 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					int num = 0;
					for (int i = 0; i < list.Count; i++)
					{
						num += list[i].controllers.conflictChecking.DisableElementAssignmentConflicts(ControllerType.Custom, P_1, P_2, P_3, P_4, P_5);
					}
					return num;
				}

				private int GDcDJxAxhlFNPZOHoLDBFMRxjYIY(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, bool P_3 = true)
				{
					if (P_0.playerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return 0;
					}
					IList<Player> list = (P_3 ? kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms : kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw);
					int num = 0;
					for (int i = 0; i < list.Count; i++)
					{
						num += list[i].controllers.conflictChecking.DisableElementAssignmentConflicts(P_0, P_1, P_2);
					}
					return num;
				}
			}

			private static ControllerHelper GclIwrgVrnJKTEKbDVzknvtphRgP;

			public readonly PollingHelper polling = PollingHelper.Instance;

			public readonly ConflictCheckingHelper conflictChecking = ConflictCheckingHelper.Instance;

			internal static ControllerHelper Instance => GclIwrgVrnJKTEKbDVzknvtphRgP ?? (GclIwrgVrnJKTEKbDVzknvtphRgP = new ControllerHelper());

			public int controllerCount
			{
				get
				{
					if (!CheckInitialized())
					{
						return 0;
					}
					return CoyPNJHWMheFytmTMQdqyctMRFl.GqxgSOBfzUXDMaSlhNOHGJqoAwd;
				}
			}

			public IList<Controller> Controllers
			{
				get
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<Controller>.EmptyReadOnlyIListT;
					}
					return CoyPNJHWMheFytmTMQdqyctMRFl.QzgERmDVGIXnuuyqvtyKFDdIeFF;
				}
			}

			public Mouse Mouse
			{
				get
				{
					if (!CheckInitialized())
					{
						return null;
					}
					return CoyPNJHWMheFytmTMQdqyctMRFl.iBsunrzpmNRGjincwoFXBCjHvrY;
				}
			}

			public Keyboard Keyboard
			{
				get
				{
					if (!CheckInitialized())
					{
						return null;
					}
					return CoyPNJHWMheFytmTMQdqyctMRFl.VptHLZXdJfMsrxxJFwCBsNGGFnMF;
				}
			}

			[Obsolete("Deprecated: Use Controller.enabled instead. For example, to disable keyboard input: ReInput.controllers.Keyboard.enabled = false.")]
			public bool keyboardEnabled
			{
				get
				{
					if (!CheckInitialized())
					{
						return false;
					}
					return Keyboard.enabled;
				}
				set
				{
					if (CheckInitialized())
					{
						Keyboard.enabled = value;
					}
				}
			}

			public int joystickCount
			{
				get
				{
					if (!CheckInitialized())
					{
						return 0;
					}
					return CoyPNJHWMheFytmTMQdqyctMRFl.XIizDAIvfXWSeeEunnkOyCetKzC;
				}
			}

			public IList<Joystick> Joysticks
			{
				get
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<Joystick>.EmptyReadOnlyIListT;
					}
					return CoyPNJHWMheFytmTMQdqyctMRFl.QuGhzrzWRShGlIBQnTYoDJgwRuJ;
				}
			}

			public int customControllerCount
			{
				get
				{
					if (!CheckInitialized())
					{
						return 0;
					}
					return CoyPNJHWMheFytmTMQdqyctMRFl.XMEhzWyjczynJhPspwNBRqhUnS;
				}
			}

			public IList<CustomController> CustomControllers
			{
				get
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<CustomController>.EmptyReadOnlyIListT;
					}
					return CoyPNJHWMheFytmTMQdqyctMRFl.UdNZzQLwzZqRhoPLnGarHXcAtGx;
				}
			}

			private ControllerHelper()
			{
			}

			public T GetController<T>(int controllerId) where T : Controller
			{
				if (!CheckInitialized())
				{
					return null;
				}
				if (controllerId < 0)
				{
					return null;
				}
				Type typeFromHandle = typeof(T);
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Joystick)))
				{
					return GetJoystick(controllerId) as T;
				}
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Keyboard)))
				{
					return CoyPNJHWMheFytmTMQdqyctMRFl.VptHLZXdJfMsrxxJFwCBsNGGFnMF as T;
				}
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(CustomController)))
				{
					return GetCustomController(controllerId) as T;
				}
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Mouse)))
				{
					return CoyPNJHWMheFytmTMQdqyctMRFl.iBsunrzpmNRGjincwoFXBCjHvrY as T;
				}
				throw new NotImplementedException();
			}

			public int GetControllerCount(ControllerType controllerType)
			{
				if (!CheckInitialized())
				{
					return 0;
				}
				return controllerType switch
				{
					ControllerType.Joystick => joystickCount, 
					ControllerType.Keyboard => 1, 
					ControllerType.Mouse => 1, 
					ControllerType.Custom => customControllerCount, 
					_ => throw new NotImplementedException(), 
				};
			}

			public Controller GetController(ControllerType controllerType, int controllerId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.RAcjlNtCncziVZzKMoHKTIJjxln(controllerType, controllerId);
			}

			public Controller GetController(ControllerIdentifier controllerIdentifier)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.RAcjlNtCncziVZzKMoHKTIJjxln(controllerIdentifier);
			}

			public Controller[] GetControllers(ControllerType controllerType)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<Controller>.array;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.geGbEHNFdnhRHHaaUPdbhXpoYjI(controllerType);
			}

			public string[] GetControllerNames(ControllerType controllerType)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<string>.array;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.BTDsPxxWLIvxcYrZABBLATPOQdh(controllerType);
			}

			public bool IsControllerAssigned(ControllerType controllerType, Controller controller)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return kRIMscNTqYOjJDgtnNDWfmLNvzj.SlsYfLFiuIuKBaQKiUdIlrKVgwt(controller);
			}

			public bool IsControllerAssigned(ControllerType controllerType, int controllerId)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return kRIMscNTqYOjJDgtnNDWfmLNvzj.SlsYfLFiuIuKBaQKiUdIlrKVgwt(controllerType, controllerId);
			}

			public bool IsControllerAssignedToPlayer(ControllerType controllerType, int controllerId, int playerId)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return kRIMscNTqYOjJDgtnNDWfmLNvzj.bKntgmyGjyazWFJbYvPqjxmirnBN(controllerType, controllerId, playerId);
			}

			public void RemoveControllerFromAllPlayers(Controller controller, bool includeSystemPlayer = true)
			{
				if (CheckInitialized())
				{
					kRIMscNTqYOjJDgtnNDWfmLNvzj.EHrbNUBocfEQVxXyOIOUDfWyOaXa(controller, includeSystemPlayer);
				}
			}

			public void RemoveControllerFromAllPlayers(ControllerType controllerType, int controllerId, bool includeSystemPlayer = true)
			{
				if (CheckInitialized())
				{
					kRIMscNTqYOjJDgtnNDWfmLNvzj.EHrbNUBocfEQVxXyOIOUDfWyOaXa(controllerType, controllerId, includeSystemPlayer);
				}
			}

			public Joystick GetJoystick(int joystickId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.zivwXGnUcYgxVcgorNBReCMkWkS(joystickId);
			}

			public Joystick[] GetJoysticks()
			{
				return CoyPNJHWMheFytmTMQdqyctMRFl.WgaoQSurPxefrtoArFJIIVcXTVP();
			}

			public string[] GetJoystickNames()
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<string>.array;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.rlLFZrJtfesbyecFVJBQUMMFeUw();
			}

			public bool IsJoystickAssigned(Joystick joystick)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return kRIMscNTqYOjJDgtnNDWfmLNvzj.kwUmQWagqcFRBBbxAyNgkOFtWUOb(joystick);
			}

			public bool IsJoystickAssigned(int joystickId)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return kRIMscNTqYOjJDgtnNDWfmLNvzj.kwUmQWagqcFRBBbxAyNgkOFtWUOb(joystickId);
			}

			public bool IsJoystickAssignedToPlayer(int joystickId, int playerId)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return kRIMscNTqYOjJDgtnNDWfmLNvzj.QbbwFfJhffUmWMJOrFbXaAhwmhC(joystickId, playerId);
			}

			public void RemoveJoystickFromAllPlayers(Joystick joystick, bool includeSystemPlayer = true)
			{
				if (CheckInitialized())
				{
					kRIMscNTqYOjJDgtnNDWfmLNvzj.GapalyaAwKpNlcbqgsiwPGaCKKnG(joystick, includeSystemPlayer);
				}
			}

			public void RemoveJoystickFromAllPlayers(int joystickId, bool includeSystemPlayer = true)
			{
				if (CheckInitialized())
				{
					kRIMscNTqYOjJDgtnNDWfmLNvzj.GapalyaAwKpNlcbqgsiwPGaCKKnG(joystickId, includeSystemPlayer);
				}
			}

			public int GetUnityJoystickIdFromAnyButtonPress()
			{
				if (!CheckInitialized())
				{
					return -1;
				}
				if (!xJurUJejHKNQiSCecRomlUYUKdh)
				{
					Logger.LogWarning("This can only used when Unity Input is handling input. This has no effect on this platform.");
					return -1;
				}
				sdrkavHBBWrEWmQUnluniKthCLc();
				for (int i = 0; i < 16; i++)
				{
					for (int j = 0; j < 20; j++)
					{
						if (unityInputBuffer.uQgqaNSvAqvaRaxNjuYjmDwtLln(i, j))
						{
							return i + 1;
						}
					}
				}
				return -1;
			}

			public int GetUnityJoystickIdFromAnyButtonOrAxisPress(float axisThreshold, bool positiveAxesOnly)
			{
				if (!CheckInitialized())
				{
					return -1;
				}
				if (!xJurUJejHKNQiSCecRomlUYUKdh)
				{
					Logger.LogWarning("This can only used when Unity Input is handling input. This has no effect on this platform.");
					return -1;
				}
				sdrkavHBBWrEWmQUnluniKthCLc();
				for (int i = 0; i < 16; i++)
				{
					for (int j = 0; j < 20; j++)
					{
						if (unityInputBuffer.uQgqaNSvAqvaRaxNjuYjmDwtLln(i, j))
						{
							return i + 1;
						}
					}
					for (int k = 0; k < 29; k++)
					{
						if (unityInputBuffer.WtKOSrvtHwHUjqpJJilbibyhooI(i, k, positiveAxesOnly))
						{
							return i + 1;
						}
					}
				}
				return -1;
			}

			public void SetUnityJoystickId(int joystickId, int unityJoystickId)
			{
				if (CheckInitialized())
				{
					if (!xJurUJejHKNQiSCecRomlUYUKdh)
					{
						Logger.LogWarning("This can only used when Unity Input is handling input. This has no effect on this platform.");
					}
					else
					{
						NIbjgVXnyQjOQkqfXoodfUsgkUI.SetUnityJoystickId(joystickId, unityJoystickId);
					}
				}
			}

			public bool SetUnityJoystickIdFromAnyButtonPress(int joystickId)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				int unityJoystickIdFromAnyButtonPress = GetUnityJoystickIdFromAnyButtonPress();
				if (unityJoystickIdFromAnyButtonPress < 1)
				{
					return false;
				}
				SetUnityJoystickId(joystickId, unityJoystickIdFromAnyButtonPress);
				return true;
			}

			public bool SetUnityJoystickIdFromAnyButtonOrAxisPress(int joystickId, float axisThreshold, bool positiveAxesOnly)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				int unityJoystickIdFromAnyButtonOrAxisPress = GetUnityJoystickIdFromAnyButtonOrAxisPress(axisThreshold, positiveAxesOnly);
				if (unityJoystickIdFromAnyButtonOrAxisPress < 1)
				{
					return false;
				}
				SetUnityJoystickId(joystickId, unityJoystickIdFromAnyButtonOrAxisPress);
				return true;
			}

			public CustomController GetCustomController(int customControllerId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.FWZkRMuknthenkBjRBPUsZyMEpF(customControllerId);
			}

			public CustomController[] GetCustomControllers()
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<CustomController>.array;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.gnoIDWojUNAxHrceKFeSYSdjYhW();
			}

			public string[] GetCustomControllerNames()
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<string>.array;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.oOyuCJUjhdBMIdevEuAblmQFQlVj();
			}

			public bool IsCustomControllerAssigned(CustomController customController)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return kRIMscNTqYOjJDgtnNDWfmLNvzj.bkoftzdrzQyGVqwFyrrPXquXqCO(customController);
			}

			public bool IsCustomControllerAssigned(int customControllerId)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return kRIMscNTqYOjJDgtnNDWfmLNvzj.bkoftzdrzQyGVqwFyrrPXquXqCO(customControllerId);
			}

			public bool IsCustomControllerAssignedToPlayer(int customControllerId, int playerId)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return kRIMscNTqYOjJDgtnNDWfmLNvzj.eNWBkTEhPScqFKjrgRdEuHrKcRlA(customControllerId, playerId);
			}

			public void RemoveCustomControllerFromAllPlayers(CustomController customController, bool includeSystemPlayer = true)
			{
				if (CheckInitialized())
				{
					kRIMscNTqYOjJDgtnNDWfmLNvzj.JNaLNXRUyUdbrEjqRgXrQDdCTtg(customController, includeSystemPlayer);
				}
			}

			public void RemoveCustomControllerFromAllPlayers(int customControllerId, bool includeSystemPlayer = true)
			{
				if (CheckInitialized())
				{
					kRIMscNTqYOjJDgtnNDWfmLNvzj.JNaLNXRUyUdbrEjqRgXrQDdCTtg(customControllerId, includeSystemPlayer);
				}
			}

			public CustomController CreateCustomController(int sourceControllerId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.udmwaShPdzxbUpFVwBKjiHdbMIeF(sourceControllerId);
			}

			public CustomController CreateCustomController(int sourceControllerId, string tag)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				CustomController customController = CoyPNJHWMheFytmTMQdqyctMRFl.udmwaShPdzxbUpFVwBKjiHdbMIeF(sourceControllerId);
				if (customController == null)
				{
					return null;
				}
				customController.tag = tag;
				return customController;
			}

			public bool DestroyCustomController(CustomController customController)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				if (customController == null)
				{
					return false;
				}
				RemoveCustomControllerFromAllPlayers(customController);
				return CoyPNJHWMheFytmTMQdqyctMRFl.evJzcCBCQhJrCrkEyiIaVRTzVWk(customController);
			}

			public CustomController GetFirstCustomControllerWithSourceId(int sourceId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.jmTMRSVjftYhQyxRaFksWJEWTbW(sourceId);
			}

			public CustomController GetFirstCustomControllerWithTag(string tag)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.qNFbGqbaSrLMufXgTvDnLsuXykSM(tag);
			}

			public IEnumerable<CustomController> CustomControllersWithSourceId(int sourceId)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<CustomController>.EmptyReadOnlyIListT;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.nmBTqqVBVKCzowzsojMoreUtMrv(sourceId);
			}

			public IEnumerable<CustomController> CustomControllersWithTag(string tag)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<CustomController>.EmptyReadOnlyIListT;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.TKgGscaoOwdnRsKYBPXMezCKuCJD(tag);
			}

			public IList<TInterface> GetControllerTemplates<TInterface>() where TInterface : IControllerTemplate
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<TInterface>.EmptyReadOnlyIListT;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.bTkDmLfyrtYGfFgrcutCcpQubhvo<TInterface>();
			}

			public Controller GetLastActiveController()
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.aGkfxefwVdRHelPOPNuzYZlUGKwI();
			}

			public Controller GetLastActiveController(ControllerType controllerType)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.aGkfxefwVdRHelPOPNuzYZlUGKwI(controllerType);
			}

			public T GetLastActiveController<T>() where T : Controller
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.aGkfxefwVdRHelPOPNuzYZlUGKwI<T>();
			}

			public ControllerType GetLastActiveControllerType()
			{
				if (!CheckInitialized())
				{
					return ControllerType.Keyboard;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.yiJxrVAsBxNxWHeZHtpMdxsmAkO();
			}

			public void AddLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback)
			{
				if (CheckInitialized())
				{
					CoyPNJHWMheFytmTMQdqyctMRFl.ouxUDDBduHJbdBSMXcegTHpIIOy(callback);
				}
			}

			public void AddLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback, ControllerType controllerType)
			{
				if (CheckInitialized())
				{
					CoyPNJHWMheFytmTMQdqyctMRFl.ouxUDDBduHJbdBSMXcegTHpIIOy(callback, controllerType);
				}
			}

			public void RemoveLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback)
			{
				if (CheckInitialized())
				{
					CoyPNJHWMheFytmTMQdqyctMRFl.yYpaOdJbPCSCDaDDXsrqJjzhQNs(callback);
				}
			}

			public void RemoveLastActiveControllerChangedDelegate(ActiveControllerChangedDelegate callback, ControllerType controllerType)
			{
				if (CheckInitialized())
				{
					CoyPNJHWMheFytmTMQdqyctMRFl.RpafhFXdRHzTBCHcEGoIPFgErzR(callback, controllerType);
				}
			}

			public void ClearLastActiveControllerChangedDelegates()
			{
				if (CheckInitialized())
				{
					CoyPNJHWMheFytmTMQdqyctMRFl.PCAliDlBQkIBjxLpZAIBzFcEAjc();
				}
			}

			public bool GetAnyButton()
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.KDUAfUIJfewqXTsDvFcFEztzzvC();
			}

			public bool GetAnyButton(ControllerType controllerType)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.KDUAfUIJfewqXTsDvFcFEztzzvC(controllerType);
			}

			public bool GetAnyButtonDown()
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.KDNxNlfcGVOlsYYbFJuLFWrKFxt();
			}

			public bool GetAnyButtonDown(ControllerType controllerType)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.KDNxNlfcGVOlsYYbFJuLFWrKFxt(controllerType);
			}

			public bool GetAnyButtonUp()
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.mpCrovLLdebWlGIoVmuaFcSinjze();
			}

			public bool GetAnyButtonUp(ControllerType controllerType)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.mpCrovLLdebWlGIoVmuaFcSinjze(controllerType);
			}

			public bool GetAnyButtonChanged()
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.noACDaGyfHGudvTADgVJiBAtGpr();
			}

			public bool GetAnyButtonChanged(ControllerType controllerType)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.noACDaGyfHGudvTADgVJiBAtGpr(controllerType);
			}

			public bool GetAnyButtonPrev()
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.ocAxveKgnwVHNGOLMIeckGigELcy();
			}

			public bool GetAnyButtonPrev(ControllerType controllerType)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.ocAxveKgnwVHNGOLMIeckGigELcy(controllerType);
			}

			public bool AutoAssignJoystick(Joystick joystick)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				if (joystick == null)
				{
					return false;
				}
				if (IsJoystickAssigned(joystick))
				{
					return true;
				}
				kRIMscNTqYOjJDgtnNDWfmLNvzj.VyWIhItGhSxSEjJCkrmWFbQURHc(joystick);
				return IsJoystickAssigned(joystick);
			}

			public void AutoAssignJoysticks()
			{
				if (CheckInitialized())
				{
					int num = joystickCount;
					IList<Joystick> joysticks = Joysticks;
					for (int i = 0; i < num; i++)
					{
						AutoAssignJoystick(joysticks[i]);
					}
				}
			}
		}

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public sealed class MappingHelper : CodeHelper
		{
			private static MappingHelper GclIwrgVrnJKTEKbDVzknvtphRgP;

			internal static MappingHelper Instance => GclIwrgVrnJKTEKbDVzknvtphRgP ?? (GclIwrgVrnJKTEKbDVzknvtphRgP = new MappingHelper());

			public IList<InputMapCategory> MapCategories
			{
				get
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<InputMapCategory>.EmptyReadOnlyIListT;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.MapCategories_readOnly;
				}
			}

			public IEnumerable<InputMapCategory> UserAssignableMapCategories
			{
				get
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<InputMapCategory>.EmptyReadOnlyIListT;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.UserAssignableMapCategories;
				}
			}

			public IList<InputCategory> ActionCategories
			{
				get
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<InputCategory>.EmptyReadOnlyIListT;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.ActionCategories_readOnly;
				}
			}

			public IEnumerable<InputCategory> UserAssignableActionCategories
			{
				get
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<InputCategory>.EmptyReadOnlyIListT;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.UserAssignableActionCategories;
				}
			}

			public IList<InputLayout> JoystickLayouts
			{
				get
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<InputLayout>.EmptyReadOnlyIListT;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.JoystickLayouts_readOnly;
				}
			}

			public IList<InputLayout> KeyboardLayouts
			{
				get
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<InputLayout>.EmptyReadOnlyIListT;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.KeyboardLayouts_readOnly;
				}
			}

			public IList<InputLayout> MouseLayouts
			{
				get
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<InputLayout>.EmptyReadOnlyIListT;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.MouseLayouts_readOnly;
				}
			}

			public IList<InputLayout> CustomControllerLayouts
			{
				get
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<InputLayout>.EmptyReadOnlyIListT;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.CustomControllerLayouts_readOnly;
				}
			}

			public IList<InputAction> Actions
			{
				get
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<InputAction>.EmptyReadOnlyIListT;
					}
					return JLezATTKNEMVFfHVAgRNIpvVfYV.yZSrNHqZKswEViXPXSJxQuBsxwA;
				}
			}

			public IEnumerable<InputAction> UserAssignableActions
			{
				get
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<InputAction>.EmptyReadOnlyIListT;
					}
					return hxqbdqzxiQgQaiRpIPHaudXzLll.UserAssignableActions;
				}
			}

			private MappingHelper()
			{
			}

			public InputMapCategory GetMapCategory(int mapCategoryId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetMapCategoryById(mapCategoryId);
			}

			public InputMapCategory GetMapCategory(string name)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetMapCategory(name);
			}

			public int GetMapCategoryId(string name)
			{
				if (!CheckInitialized())
				{
					return -1;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetMapCategoryId(name);
			}

			public IEnumerable<InputMapCategory> MapCategoriesWithTag(string tag)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<InputMapCategory>.EmptyReadOnlyIListT;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.omMeSAgRILbFGysHCiijxiOCwjhG(tag);
			}

			public IEnumerable<InputMapCategory> UserAssignableMapCategoriesWithTag(string tag)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<InputMapCategory>.EmptyReadOnlyIListT;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.EQWXTXhBrWcbZxvqlHenKOZtezh(tag);
			}

			public bool IsMapCategoryUserAssignable(int mapCategoryId)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return GetMapCategory(mapCategoryId)?.userAssignable ?? false;
			}

			public InputCategory GetActionCategory(int mapCategoryId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetActionCategoryById(mapCategoryId);
			}

			public InputCategory GetActionCategory(string name)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetActionCategory(name);
			}

			public int GetActionCategoryId(string name)
			{
				if (!CheckInitialized())
				{
					return -1;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetActionCategoryId(name);
			}

			public IEnumerable<InputCategory> ActionCategoriesWithTag(string tag)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<InputCategory>.EmptyReadOnlyIListT;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.UUxmdpMwgZXPVUocMoXINdHNmjG(tag);
			}

			public IEnumerable<InputCategory> UserAssignableActionCategoriesWithTag(string tag)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<InputCategory>.EmptyReadOnlyIListT;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.iTUxJGNZJxkllXnqqcvUGuiVTTpa(tag);
			}

			public bool IsActionCategoryUserAssignable(int mapCategoryId)
			{
				if (!CheckInitialized())
				{
					return false;
				}
				return GetActionCategory(mapCategoryId)?.userAssignable ?? false;
			}

			public InputLayout GetLayout(ControllerType controllerType, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return controllerType switch
				{
					ControllerType.Joystick => hxqbdqzxiQgQaiRpIPHaudXzLll.GetJoystickLayoutById(layoutId), 
					ControllerType.Keyboard => hxqbdqzxiQgQaiRpIPHaudXzLll.GetKeyboardLayoutById(layoutId), 
					ControllerType.Mouse => hxqbdqzxiQgQaiRpIPHaudXzLll.GetMouseLayoutById(layoutId), 
					ControllerType.Custom => hxqbdqzxiQgQaiRpIPHaudXzLll.GetCustomControllerLayoutById(layoutId), 
					_ => throw new NotImplementedException(), 
				};
			}

			public InputLayout GetLayout(ControllerType controllerType, string name)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return controllerType switch
				{
					ControllerType.Joystick => hxqbdqzxiQgQaiRpIPHaudXzLll.GetJoystickLayout(name), 
					ControllerType.Keyboard => hxqbdqzxiQgQaiRpIPHaudXzLll.GetKeyboardLayout(name), 
					ControllerType.Mouse => hxqbdqzxiQgQaiRpIPHaudXzLll.GetMouseLayout(name), 
					ControllerType.Custom => hxqbdqzxiQgQaiRpIPHaudXzLll.GetCustomControllerLayout(name), 
					_ => throw new NotImplementedException(), 
				};
			}

			public int GetLayoutId(ControllerType controllerType, string name)
			{
				if (!CheckInitialized())
				{
					return -1;
				}
				return controllerType switch
				{
					ControllerType.Joystick => hxqbdqzxiQgQaiRpIPHaudXzLll.GetJoystickLayoutId(name), 
					ControllerType.Keyboard => hxqbdqzxiQgQaiRpIPHaudXzLll.GetKeyboardLayoutId(name), 
					ControllerType.Mouse => hxqbdqzxiQgQaiRpIPHaudXzLll.GetMouseLayoutId(name), 
					ControllerType.Custom => hxqbdqzxiQgQaiRpIPHaudXzLll.GetCustomControllerLayoutId(name), 
					_ => throw new NotImplementedException(), 
				};
			}

			public InputLayout GetJoystickLayout(int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetJoystickLayoutById(layoutId);
			}

			public InputLayout GetJoystickLayout(string name)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetJoystickLayout(name);
			}

			public int GetJoystickLayoutId(string name)
			{
				if (!CheckInitialized())
				{
					return -1;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetJoystickLayoutId(name);
			}

			public InputLayout GetKeyboardLayout(int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetKeyboardLayoutById(layoutId);
			}

			public InputLayout GetKeyboardLayout(string name)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetKeyboardLayout(name);
			}

			public int GetKeyboardLayoutId(string name)
			{
				if (!CheckInitialized())
				{
					return -1;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetKeyboardLayoutId(name);
			}

			public InputLayout GetMouseLayout(int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetMouseLayoutById(layoutId);
			}

			public InputLayout GetMouseLayout(string name)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetMouseLayout(name);
			}

			public int GetMouseLayoutId(string name)
			{
				if (!CheckInitialized())
				{
					return -1;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetMouseLayoutId(name);
			}

			public InputLayout GetCustomControllerLayout(int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetCustomControllerLayoutById(layoutId);
			}

			public InputLayout GetCustomControllerLayout(string name)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetCustomControllerLayout(name);
			}

			public int GetCustomControllerLayoutId(string name)
			{
				if (!CheckInitialized())
				{
					return -1;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetCustomControllerLayoutId(name);
			}

			public IList<InputLayout> MapLayouts(ControllerType controllerType)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<InputLayout>.EmptyReadOnlyIListT;
				}
				return controllerType switch
				{
					ControllerType.Joystick => JoystickLayouts, 
					ControllerType.Keyboard => KeyboardLayouts, 
					ControllerType.Mouse => MouseLayouts, 
					ControllerType.Custom => CustomControllerLayouts, 
					_ => throw new NotImplementedException(), 
				};
			}

			public InputAction GetAction(int actionId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetActionById(actionId);
			}

			public InputAction GetAction(string name)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetAction(name);
			}

			public int GetActionId(string name)
			{
				if (!CheckInitialized())
				{
					return -1;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetActionId(name);
			}

			public IEnumerable<InputAction> ActionsInCategory(string mapCategoryName)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<InputAction>.EmptyReadOnlyIListT;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.FbMTMfclPyrIMgWdUJtTfcwVTEx(mapCategoryName, false);
			}

			public IEnumerable<InputAction> ActionsInCategory(string mapCategoryName, bool sort)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<InputAction>.EmptyReadOnlyIListT;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.FbMTMfclPyrIMgWdUJtTfcwVTEx(mapCategoryName, sort);
			}

			public IEnumerable<InputAction> ActionsInCategory(int mapCategoryId)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<InputAction>.EmptyReadOnlyIListT;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.FbMTMfclPyrIMgWdUJtTfcwVTEx(mapCategoryId, false);
			}

			public IEnumerable<InputAction> ActionsInCategory(int mapCategoryId, bool sort)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<InputAction>.EmptyReadOnlyIListT;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.FbMTMfclPyrIMgWdUJtTfcwVTEx(mapCategoryId, sort);
			}

			public IEnumerable<InputAction> ActionsInCategoriesWithTag(string tag)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<InputAction>.EmptyReadOnlyIListT;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.UBpHgnbvoMgQneSuFrajdsXWOOGJ(tag);
			}

			public IEnumerable<InputAction> UserAssignableActionsInCategory(int mapCategoryId)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<InputAction>.EmptyReadOnlyIListT;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.eAcenbsjwJTMmxncYwLRKgaIAVj(mapCategoryId, false);
			}

			public IEnumerable<InputAction> UserAssignableActionsInCategory(int mapCategoryId, bool sort)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<InputAction>.EmptyReadOnlyIListT;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.eAcenbsjwJTMmxncYwLRKgaIAVj(mapCategoryId, sort);
			}

			public IEnumerable<InputAction> UserAssignableActionsInCategory(string mapCategoryName)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<InputAction>.EmptyReadOnlyIListT;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.eAcenbsjwJTMmxncYwLRKgaIAVj(mapCategoryName, false);
			}

			public IEnumerable<InputAction> UserAssignableActionsInCategory(string mapCategoryName, bool sort)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<InputAction>.EmptyReadOnlyIListT;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.eAcenbsjwJTMmxncYwLRKgaIAVj(mapCategoryName, sort);
			}

			public IList<InputBehavior> GetInputBehaviors(int playerId)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<InputBehavior>.EmptyReadOnlyIListT;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.umHQUsjkrukJGdByYFaLhrPTnXQ(playerId);
			}

			public IList<InputBehavior> GetSystemPlayerInputBehaviors()
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<InputBehavior>.EmptyReadOnlyIListT;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.umHQUsjkrukJGdByYFaLhrPTnXQ(9999999);
			}

			public InputBehavior GetInputBehavior(int playerId, int behaviorId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.phwbKHKomUfIkFaLFXJBEZIqWcnG(playerId, behaviorId);
			}

			public InputBehavior GetInputBehavior(int playerId, string behaviorName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return CoyPNJHWMheFytmTMQdqyctMRFl.phwbKHKomUfIkFaLFXJBEZIqWcnG(playerId, behaviorName);
			}

			public InputBehavior GetSystemPlayerInputBehavior(int behaviorId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return GetInputBehavior(9999999, behaviorId);
			}

			public InputBehavior GetSystemPlayerInputBehavior(string behaviorName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return GetInputBehavior(9999999, behaviorName);
			}

			public int GetInputBehaviorId(string behaviorName)
			{
				if (!CheckInitialized())
				{
					return -1;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetInputBehaviorId(behaviorName);
			}

			internal InputBehavior hqlzrbLJgYemJobDFvOYgEihuSx(int P_0)
			{
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetInputBehaviorById(P_0);
			}

			internal InputBehavior hqlzrbLJgYemJobDFvOYgEihuSx(string P_0)
			{
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetInputBehavior(P_0);
			}

			public ControllerMap GetControllerMap(int id)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				IList<Player> allPlayers = players.AllPlayers;
				for (int i = 0; i < allPlayers.Count; i++)
				{
					ControllerMap map = allPlayers[i].controllers.maps.GetMap(id);
					if (map != null)
					{
						return map;
					}
				}
				return null;
			}

			public ActionElementMap GetActionElementMap(int id)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				IList<Player> allPlayers = players.AllPlayers;
				for (int i = 0; i < allPlayers.Count; i++)
				{
					foreach (ControllerMap allMap in allPlayers[i].controllers.maps.GetAllMaps())
					{
						if (allMap != null)
						{
							ActionElementMap elementMap = allMap.GetElementMap(id);
							if (elementMap != null)
							{
								return elementMap;
							}
						}
					}
				}
				return null;
			}

			public ControllerMap GetControllerMapInstance(Controller controller, int mapCategoryId, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				if (controller == null)
				{
					return null;
				}
				return controller.type switch
				{
					ControllerType.Joystick => GetJoystickMapInstance((Joystick)controller, mapCategoryId, layoutId), 
					ControllerType.Keyboard => GetKeyboardMapInstance(mapCategoryId, layoutId), 
					ControllerType.Mouse => GetMouseMapInstance(mapCategoryId, layoutId), 
					ControllerType.Custom => GetCustomControllerMapInstance((CustomController)controller, mapCategoryId, layoutId), 
					_ => throw new NotImplementedException(), 
				};
			}

			public ControllerMap GetControllerMapInstance(Controller controller, string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				if (controller == null)
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(controller.type, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetControllerMapInstance(controller, mapCategoryId, layoutId);
			}

			public ControllerMap GetControllerMapInstance(ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(controllerIdentifier.controllerType, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetControllerMapInstance(controllerIdentifier, mapCategoryId, layoutId);
			}

			public ControllerMap GetControllerMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				Controller controller = CoyPNJHWMheFytmTMQdqyctMRFl.RAcjlNtCncziVZzKMoHKTIJjxln(controllerIdentifier);
				if (controller != null)
				{
					return GetControllerMapInstance(controller, mapCategoryId, layoutId);
				}
				return controllerIdentifier.controllerType switch
				{
					ControllerType.Joystick => GetJoystickMapInstance(controllerIdentifier, mapCategoryId, layoutId), 
					ControllerType.Custom => GetCustomControllerMapInstance(controllerIdentifier, mapCategoryId, layoutId), 
					ControllerType.Keyboard => GetKeyboardMapInstance(mapCategoryId, layoutId), 
					ControllerType.Mouse => GetMouseMapInstance(mapCategoryId, layoutId), 
					_ => throw new NotImplementedException(), 
				};
			}

			public JoystickMap GetJoystickMapInstance(Joystick joystick, int mapCategoryId, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				if (joystick == null)
				{
					return null;
				}
				JoystickMap joystickMap = hxqbdqzxiQgQaiRpIPHaudXzLll.DaCIomEMClXMJhjaggiJvZhjxKp(joystick, mapCategoryId, layoutId);
				if (joystickMap != null)
				{
					joystick.qQYfIAJgvloChayYXVFBMdlJuGrp(joystickMap);
				}
				return joystickMap;
			}

			public JoystickMap GetJoystickMapInstance(Joystick joystick, string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(ControllerType.Joystick, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetJoystickMapInstance(joystick, mapCategoryId, layoutId);
			}

			public JoystickMap GetJoystickMapInstance(Guid joystickTypeGuid, int mapCategoryId, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				if (joystickTypeGuid == Guid.Empty)
				{
					return null;
				}
				InputSource inputSourceType = NIbjgVXnyQjOQkqfXoodfUsgkUI.inputSourceType;
				HardwareJoystickMap_InputManager hardwareJoystickMap_InputManager = ytlEooerRTdysEAPDtAKhGdaWSGa.tsbJlFSFeAtlDSuvfupzvtoliMa(joystickTypeGuid, inputSourceType);
				if (hardwareJoystickMap_InputManager == null)
				{
					Logger.LogError("No hardware map found.");
					return null;
				}
				JoystickMap joystickMap = hxqbdqzxiQgQaiRpIPHaudXzLll.wHsihrNeanPbUMDqVsLFUifEqLU(hardwareJoystickMap_InputManager.hardwareMapIdentifier, mapCategoryId, layoutId);
				if (joystickMap != null)
				{
					joystickMap.controllerType = ControllerType.Joystick;
					HardwareControllerMap_Game hardwareControllerMap_Game = hardwareJoystickMap_InputManager.ToGameHardwareControllerMap();
					{
						foreach (ActionElementMap allMap in joystickMap.AllMaps)
						{
							allMap.AoIDokffkOIEeMiGpVwewpwPAksj(joystickMap, hardwareControllerMap_Game);
						}
						return joystickMap;
					}
				}
				return joystickMap;
			}

			public JoystickMap GetJoystickMapInstance(Guid joystickTypeGuid, string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				if (joystickTypeGuid == Guid.Empty)
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(ControllerType.Joystick, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetJoystickMapInstance(joystickTypeGuid, mapCategoryId, layoutId);
			}

			public JoystickMap GetJoystickMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				if (controllerIdentifier.controllerType != ControllerType.Joystick)
				{
					return null;
				}
				if (CoyPNJHWMheFytmTMQdqyctMRFl.RAcjlNtCncziVZzKMoHKTIJjxln(controllerIdentifier) is Joystick joystick)
				{
					return GetJoystickMapInstance(joystick, mapCategoryId, layoutId);
				}
				return GetJoystickMapInstance(controllerIdentifier.hardwareTypeGuid, mapCategoryId, layoutId);
			}

			public JoystickMap GetJoystickMapInstance(ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(ControllerType.Joystick, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetJoystickMapInstance(controllerIdentifier, mapCategoryId, layoutId);
			}

			public KeyboardMap GetKeyboardMapInstance(int mapCategoryId, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				KeyboardMap keyboardMap = hxqbdqzxiQgQaiRpIPHaudXzLll.FindKeyboardMap_Game(controllers.Keyboard, mapCategoryId, layoutId);
				if (keyboardMap != null)
				{
					controllers.Keyboard.qQYfIAJgvloChayYXVFBMdlJuGrp(keyboardMap);
				}
				return keyboardMap;
			}

			public KeyboardMap GetKeyboardMapInstance(string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(ControllerType.Keyboard, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetKeyboardMapInstance(mapCategoryId, layoutId);
			}

			public MouseMap GetMouseMapInstance(int mapCategoryId, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				MouseMap mouseMap = hxqbdqzxiQgQaiRpIPHaudXzLll.FindMouseMap_Game(controllers.Mouse, mapCategoryId, layoutId);
				if (mouseMap != null)
				{
					controllers.Mouse.qQYfIAJgvloChayYXVFBMdlJuGrp(mouseMap);
				}
				return mouseMap;
			}

			public MouseMap GetMouseMapInstance(string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(ControllerType.Mouse, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetMouseMapInstance(mapCategoryId, layoutId);
			}

			public CustomControllerMap GetCustomControllerMapInstance(CustomController customController, int mapCategoryId, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				CustomControllerMap customControllerMap = hxqbdqzxiQgQaiRpIPHaudXzLll.ktNOMocJCadznhndNYZtJNgVSGi(customController.sourceControllerId, mapCategoryId, layoutId);
				if (customControllerMap != null)
				{
					customController.qQYfIAJgvloChayYXVFBMdlJuGrp(customControllerMap);
				}
				return customControllerMap;
			}

			public CustomControllerMap GetCustomControllerMapInstance(CustomController customController, string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(ControllerType.Custom, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetCustomControllerMapInstance(customController, mapCategoryId, layoutId);
			}

			public CustomControllerMap GetCustomControllerMapInstance(ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				if (controllerIdentifier.controllerType != ControllerType.Custom)
				{
					return null;
				}
				if (CoyPNJHWMheFytmTMQdqyctMRFl.RAcjlNtCncziVZzKMoHKTIJjxln(controllerIdentifier) is CustomController customController)
				{
					return GetCustomControllerMapInstance(customController, mapCategoryId, layoutId);
				}
				if (controllerIdentifier.hardwareTypeGuid == Guid.Empty)
				{
					return null;
				}
				CustomController_Editor customControllerByHardwareTypeGuid = hxqbdqzxiQgQaiRpIPHaudXzLll.GetCustomControllerByHardwareTypeGuid(controllerIdentifier.hardwareTypeGuid);
				if (customControllerByHardwareTypeGuid == null)
				{
					return null;
				}
				CustomControllerMap customControllerMap = hxqbdqzxiQgQaiRpIPHaudXzLll.ktNOMocJCadznhndNYZtJNgVSGi(controllerIdentifier.hardwareTypeGuid, mapCategoryId, layoutId);
				if (customControllerMap != null)
				{
					HardwareControllerMap_Game hardwareControllerMap_Game = customControllerByHardwareTypeGuid.qEYKqHdCkIFmZIOUZoOJxsUkurRn();
					if (hardwareControllerMap_Game == null)
					{
						Logger.LogError("No hardware map found.");
						return null;
					}
					customControllerMap.controllerType = ControllerType.Custom;
					{
						foreach (ActionElementMap allMap in customControllerMap.AllMaps)
						{
							allMap.AoIDokffkOIEeMiGpVwewpwPAksj(customControllerMap, hardwareControllerMap_Game);
						}
						return customControllerMap;
					}
				}
				return customControllerMap;
			}

			public CustomControllerMap GetCustomControllerMapInstance(ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(ControllerType.Custom, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetCustomControllerMapInstance(controllerIdentifier, mapCategoryId, layoutId);
			}

			public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, Controller controller, int mapCategoryId, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				if (controller == null)
				{
					return null;
				}
				ControllerMap controllerMap = null;
				if (userDataStore is IControllerMapStore controllerMapStore)
				{
					controllerMap = controllerMapStore.LoadControllerMap(playerId, controller.identifier, mapCategoryId, layoutId);
				}
				if (controllerMap == null)
				{
					controllerMap = hxqbdqzxiQgQaiRpIPHaudXzLll.eMNDXjeZJyzUonVPAgoxHeuDFqlc(controller, mapCategoryId, layoutId);
				}
				if (controllerMap != null)
				{
					Player player = players.GetPlayer(playerId);
					if (player != null)
					{
						player.controllers.maps.qQYfIAJgvloChayYXVFBMdlJuGrp(controller, controllerMap);
					}
					else
					{
						controller.qQYfIAJgvloChayYXVFBMdlJuGrp(controllerMap);
					}
				}
				return controllerMap;
			}

			public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, Controller controller, string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				if (controller == null)
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(controller.type, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetControllerMapInstanceSavedOrDefault(playerId, controller, mapCategoryId, layoutId);
			}

			public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return controllerIdentifier.controllerType switch
				{
					ControllerType.Joystick => GetJoystickMapInstanceSavedOrDefault(playerId, controllerIdentifier, mapCategoryId, layoutId), 
					ControllerType.Custom => GetCustomControllerMapInstanceSavedOrDefault(playerId, controllerIdentifier, mapCategoryId, layoutId), 
					ControllerType.Keyboard => GetKeyboardMapInstanceSavedOrDefault(playerId, mapCategoryId, layoutId), 
					ControllerType.Mouse => GetMouseMapInstanceSavedOrDefault(playerId, mapCategoryId, layoutId), 
					_ => throw new NotImplementedException(), 
				};
			}

			public ControllerMap GetControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(controllerIdentifier.controllerType, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetControllerMapInstanceSavedOrDefault(playerId, controllerIdentifier, mapCategoryId, layoutId);
			}

			public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, Joystick joystick, int mapCategoryId, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return GetControllerMapInstanceSavedOrDefault(playerId, joystick, mapCategoryId, layoutId) as JoystickMap;
			}

			public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, Joystick joystick, string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(ControllerType.Joystick, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetJoystickMapInstanceSavedOrDefault(playerId, joystick, mapCategoryId, layoutId);
			}

			public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				if (CoyPNJHWMheFytmTMQdqyctMRFl.RAcjlNtCncziVZzKMoHKTIJjxln(controllerIdentifier) is Joystick joystick)
				{
					return GetJoystickMapInstanceSavedOrDefault(playerId, joystick, mapCategoryId, layoutId);
				}
				InputSource inputSourceType = NIbjgVXnyQjOQkqfXoodfUsgkUI.inputSourceType;
				HardwareJoystickMap_InputManager hardwareJoystickMap_InputManager = ytlEooerRTdysEAPDtAKhGdaWSGa.tsbJlFSFeAtlDSuvfupzvtoliMa(controllerIdentifier.hardwareTypeGuid, inputSourceType);
				if (hardwareJoystickMap_InputManager == null)
				{
					Logger.LogError("No hardware map found.");
					return null;
				}
				JoystickMap joystickMap = null;
				if (userDataStore is IControllerMapStore controllerMapStore)
				{
					joystickMap = controllerMapStore.LoadControllerMap(playerId, controllerIdentifier, mapCategoryId, layoutId) as JoystickMap;
				}
				if (joystickMap == null)
				{
					joystickMap = hxqbdqzxiQgQaiRpIPHaudXzLll.wHsihrNeanPbUMDqVsLFUifEqLU(hardwareJoystickMap_InputManager.hardwareMapIdentifier, mapCategoryId, layoutId);
				}
				if (joystickMap != null)
				{
					joystickMap.controllerType = ControllerType.Joystick;
					if (players.GetPlayer(playerId) != null)
					{
						joystickMap.playerId = playerId;
					}
					HardwareControllerMap_Game hardwareControllerMap_Game = hardwareJoystickMap_InputManager.ToGameHardwareControllerMap();
					{
						foreach (ActionElementMap allMap in joystickMap.AllMaps)
						{
							allMap.AoIDokffkOIEeMiGpVwewpwPAksj(joystickMap, hardwareControllerMap_Game);
						}
						return joystickMap;
					}
				}
				return joystickMap;
			}

			public JoystickMap GetJoystickMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(ControllerType.Joystick, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetJoystickMapInstanceSavedOrDefault(playerId, controllerIdentifier, mapCategoryId, layoutId);
			}

			public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, CustomController customController, int mapCategoryId, int layoutId)
			{
				return GetControllerMapInstanceSavedOrDefault(playerId, customController, mapCategoryId, layoutId) as CustomControllerMap;
			}

			public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, CustomController customController, string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(ControllerType.Custom, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetCustomControllerMapInstanceSavedOrDefault(playerId, customController, mapCategoryId, layoutId);
			}

			public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, int mapCategoryId, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				if (CoyPNJHWMheFytmTMQdqyctMRFl.RAcjlNtCncziVZzKMoHKTIJjxln(controllerIdentifier) is CustomController customController)
				{
					return GetCustomControllerMapInstanceSavedOrDefault(playerId, customController, mapCategoryId, layoutId);
				}
				CustomController_Editor customControllerByHardwareTypeGuid = hxqbdqzxiQgQaiRpIPHaudXzLll.GetCustomControllerByHardwareTypeGuid(controllerIdentifier.hardwareTypeGuid);
				if (customControllerByHardwareTypeGuid == null)
				{
					return null;
				}
				CustomControllerMap customControllerMap = null;
				if (userDataStore is IControllerMapStore controllerMapStore)
				{
					customControllerMap = controllerMapStore.LoadControllerMap(playerId, controllerIdentifier, mapCategoryId, layoutId) as CustomControllerMap;
				}
				if (customControllerMap == null)
				{
					customControllerMap = hxqbdqzxiQgQaiRpIPHaudXzLll.ktNOMocJCadznhndNYZtJNgVSGi(controllerIdentifier.hardwareTypeGuid, mapCategoryId, layoutId);
				}
				if (customControllerMap != null)
				{
					HardwareControllerMap_Game hardwareControllerMap_Game = customControllerByHardwareTypeGuid.qEYKqHdCkIFmZIOUZoOJxsUkurRn();
					if (hardwareControllerMap_Game == null)
					{
						Logger.LogError("No hardware map found.");
						return null;
					}
					customControllerMap.controllerType = ControllerType.Custom;
					if (players.GetPlayer(playerId) != null)
					{
						customControllerMap.playerId = playerId;
					}
					{
						foreach (ActionElementMap allMap in customControllerMap.AllMaps)
						{
							allMap.AoIDokffkOIEeMiGpVwewpwPAksj(customControllerMap, hardwareControllerMap_Game);
						}
						return customControllerMap;
					}
				}
				return customControllerMap;
			}

			public CustomControllerMap GetCustomControllerMapInstanceSavedOrDefault(int playerId, ControllerIdentifier controllerIdentifier, string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(ControllerType.Custom, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetCustomControllerMapInstanceSavedOrDefault(playerId, controllerIdentifier, mapCategoryId, layoutId);
			}

			public KeyboardMap GetKeyboardMapInstanceSavedOrDefault(int playerId, int mapCategoryId, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				Controller keyboard = controllers.Keyboard;
				KeyboardMap keyboardMap = null;
				if (userDataStore is IControllerMapStore controllerMapStore)
				{
					keyboardMap = controllerMapStore.LoadControllerMap(playerId, keyboard.identifier, mapCategoryId, layoutId) as KeyboardMap;
				}
				if (keyboardMap == null)
				{
					keyboardMap = hxqbdqzxiQgQaiRpIPHaudXzLll.FindKeyboardMap_Game(controllers.Keyboard, mapCategoryId, layoutId);
				}
				if (keyboardMap != null)
				{
					Player player = players.GetPlayer(playerId);
					if (player != null)
					{
						player.controllers.maps.qQYfIAJgvloChayYXVFBMdlJuGrp(keyboard, keyboardMap);
					}
					else
					{
						keyboard.qQYfIAJgvloChayYXVFBMdlJuGrp(keyboardMap);
					}
				}
				return keyboardMap;
			}

			public KeyboardMap GetKeyboardMapInstanceSavedOrDefault(int playerId, string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(ControllerType.Keyboard, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetKeyboardMapInstanceSavedOrDefault(playerId, mapCategoryId, layoutId);
			}

			public MouseMap GetMouseMapInstanceSavedOrDefault(int playerId, int mapCategoryId, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				Controller mouse = controllers.Mouse;
				MouseMap mouseMap = null;
				if (userDataStore is IControllerMapStore controllerMapStore)
				{
					mouseMap = controllerMapStore.LoadControllerMap(playerId, mouse.identifier, mapCategoryId, layoutId) as MouseMap;
				}
				if (mouseMap == null)
				{
					mouseMap = hxqbdqzxiQgQaiRpIPHaudXzLll.FindMouseMap_Game(controllers.Mouse, mapCategoryId, layoutId);
				}
				if (mouseMap != null)
				{
					Player player = players.GetPlayer(playerId);
					if (player != null)
					{
						player.controllers.maps.qQYfIAJgvloChayYXVFBMdlJuGrp(mouse, mouseMap);
					}
					else
					{
						mouse.qQYfIAJgvloChayYXVFBMdlJuGrp(mouseMap);
					}
				}
				return mouseMap;
			}

			public MouseMap GetMouseMapInstanceSavedOrDefault(int playerId, string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(ControllerType.Mouse, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetMouseMapInstanceSavedOrDefault(playerId, mapCategoryId, layoutId);
			}

			[Obsolete("This method has been deprecated. Use the Controller Template system instead.", false)]
			public ControllerElementIdentifier GetFirstJoystickTemplateElementIdentifier(Joystick joystick, int joystickElementIdentifierId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				if (joystick == null)
				{
					return null;
				}
				return LPVghKoUxjeCTfLtGsFKjvVWPNN(joystick.hardwareTypeGuid, joystickElementIdentifierId);
			}

			private ControllerElementIdentifier LPVghKoUxjeCTfLtGsFKjvVWPNN(Guid P_0, int P_1)
			{
				return ytlEooerRTdysEAPDtAKhGdaWSGa.LPVghKoUxjeCTfLtGsFKjvVWPNN(P_0, P_1)?.ToControllerElementIdentifier();
			}

			public ControllerTemplateMap GetControllerTemplateMapInstance(Guid templateTypeGuid, int mapCategoryId, int layoutId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.AIldkDBWMJDzNtyPfNmdAwQlGeLp(templateTypeGuid, mapCategoryId, layoutId);
			}

			public ControllerTemplateMap GetControllerTemplateMapInstance(Guid templateTypeGuid, string mapCategoryName, string layoutName)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				int mapCategoryId = GetMapCategoryId(mapCategoryName);
				if (mapCategoryId < 0)
				{
					return null;
				}
				int layoutId = GetLayoutId(ControllerType.Custom, layoutName);
				if (layoutId < 0)
				{
					return null;
				}
				return GetControllerTemplateMapInstance(templateTypeGuid, mapCategoryId, layoutId);
			}

			public ControllerMapLayoutManager.RuleSet GetControllerMapLayoutManagerRuleSetInstance(int id)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetControllerMapLayoutManagerRuleSetById(id)?.ToRuntime();
			}

			public ControllerMapLayoutManager.RuleSet GetControllerMapLayoutManagerRuleSetInstance(string name)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				int controllerMapLayoutManagerRuleSetId = hxqbdqzxiQgQaiRpIPHaudXzLll.GetControllerMapLayoutManagerRuleSetId(name);
				if (controllerMapLayoutManagerRuleSetId < 0)
				{
					return null;
				}
				return GetControllerMapLayoutManagerRuleSetInstance(controllerMapLayoutManagerRuleSetId);
			}

			public ControllerMapEnabler.RuleSet GetControllerMapEnablerRuleSetInstance(int id)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return hxqbdqzxiQgQaiRpIPHaudXzLll.GetControllerMapEnablerRuleSetById(id)?.ToRuntime();
			}

			public ControllerMapEnabler.RuleSet GetControllerMapEnablerRuleSetInstance(string name)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				int controllerMapEnablerRuleSetId = hxqbdqzxiQgQaiRpIPHaudXzLll.GetControllerMapEnablerRuleSetId(name);
				if (controllerMapEnablerRuleSetId < 0)
				{
					return null;
				}
				return GetControllerMapEnablerRuleSetInstance(controllerMapEnablerRuleSetId);
			}
		}

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public sealed class PlayerHelper : CodeHelper
		{
			private static PlayerHelper GclIwrgVrnJKTEKbDVzknvtphRgP;

			internal static PlayerHelper Instance => GclIwrgVrnJKTEKbDVzknvtphRgP ?? (GclIwrgVrnJKTEKbDVzknvtphRgP = new PlayerHelper());

			public int playerCount
			{
				get
				{
					if (!CheckInitialized())
					{
						return 0;
					}
					return kRIMscNTqYOjJDgtnNDWfmLNvzj.NLEpalNfODFjJdDoCFTTlDEgNFWP;
				}
			}

			public int allPlayerCount
			{
				get
				{
					if (!CheckInitialized())
					{
						return 0;
					}
					return kRIMscNTqYOjJDgtnNDWfmLNvzj.oSarMBcfjNTXBjKUPFrfGRvrNvg;
				}
			}

			public IList<Player> Players
			{
				get
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<Player>.EmptyReadOnlyIListT;
					}
					return kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw;
				}
			}

			public IList<Player> AllPlayers
			{
				get
				{
					if (!CheckInitialized())
					{
						return EmptyObjects<Player>.EmptyReadOnlyIListT;
					}
					return kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms;
				}
			}

			public Player SystemPlayer
			{
				get
				{
					if (!CheckInitialized())
					{
						return null;
					}
					return kRIMscNTqYOjJDgtnNDWfmLNvzj.iZJWprFjAAltkususAHsWjhtNDP();
				}
			}

			private PlayerHelper()
			{
			}

			public IList<Player> GetPlayers(bool includeSystemPlayer = false)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<Player>.EmptyReadOnlyIListT;
				}
				if (!includeSystemPlayer)
				{
					return kRIMscNTqYOjJDgtnNDWfmLNvzj.TdDjMQjxsetnDFRTEyCUGBlCNULw;
				}
				return kRIMscNTqYOjJDgtnNDWfmLNvzj.XBmQMIGjKCKiWxZTMiAxCRnDpms;
			}

			public Player GetPlayer(int playerId)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return kRIMscNTqYOjJDgtnNDWfmLNvzj.fFKuoGTmbMrpFMTwXsWqdvvrhNG(playerId);
			}

			public Player GetPlayer(string name)
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return kRIMscNTqYOjJDgtnNDWfmLNvzj.fFKuoGTmbMrpFMTwXsWqdvvrhNG(name);
			}

			public Player GetSystemPlayer()
			{
				if (!CheckInitialized())
				{
					return null;
				}
				return kRIMscNTqYOjJDgtnNDWfmLNvzj.iZJWprFjAAltkususAHsWjhtNDP();
			}

			public int GetPlayerId(string playerName)
			{
				if (!CheckInitialized())
				{
					return -1;
				}
				return kRIMscNTqYOjJDgtnNDWfmLNvzj.OHuyewEnBAsmCWItZdFIiMcmJbz(playerName);
			}

			public string[] GetPlayerNames(bool includeSystemPlayer = false)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<string>.array;
				}
				return kRIMscNTqYOjJDgtnNDWfmLNvzj.TLBTsonOINiALJclXjrIXNhexfSu(includeSystemPlayer);
			}

			public string[] GetPlayerDescriptiveNames(bool includeSystemPlayer = false)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<string>.array;
				}
				return kRIMscNTqYOjJDgtnNDWfmLNvzj.JAYziTJCEcBpGZqNzRahpKnXIhfd(includeSystemPlayer);
			}

			public int[] GetPlayerIds(bool includeSystemPlayer = false)
			{
				if (!CheckInitialized())
				{
					return EmptyObjects<int>.array;
				}
				return kRIMscNTqYOjJDgtnNDWfmLNvzj.RGLYuWhbxxOTozqOgdFuhsKmkxR(includeSystemPlayer);
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public sealed class TimeHelper : CodeHelper
		{
			private static TimeHelper GclIwrgVrnJKTEKbDVzknvtphRgP;

			internal static TimeHelper Instance => GclIwrgVrnJKTEKbDVzknvtphRgP ?? (GclIwrgVrnJKTEKbDVzknvtphRgP = new TimeHelper());

			public float unscaledDeltaTime
			{
				get
				{
					if (!CheckInitialized())
					{
						return 0f;
					}
					return (float)LyNclYHYHXKFxZgnbiNEISkbAkYE.pShflJlEalzVlXfYfXFXKdZEKKH;
				}
			}

			public double unscaledTime
			{
				get
				{
					if (!CheckInitialized())
					{
						return 0.0;
					}
					return LyNclYHYHXKFxZgnbiNEISkbAkYE.GCwgDdqytcsdqcvxuiixUcRVeFm;
				}
			}

			public uint currentFrame
			{
				get
				{
					if (!CheckInitialized())
					{
						return 0u;
					}
					return LyNclYHYHXKFxZgnbiNEISkbAkYE.UsGwHXtMUNCrZXGfCMaMzrOwvzF;
				}
			}

			private TimeHelper()
			{
			}
		}

		private class uLLVkeYyPzsBcHIMbAchcIFgPOMw
		{
			private class rLIbmTXyZYGzsAbADGihRoRAhSX
			{
				public readonly UpdateLoopType EtMuBRTmVzCBLcuxYRMlwUqRdAzD;

				private double YMYTaTajBfiVzHUrZjYZlFSZEzw;

				private double EBIttHTFSXzrTiiDDBVtBoscnzr;

				private double lyBydcWcKSploRFtOFUCCuxEcswX;

				private double YwHorTitbGsmNRsSkobcfJBrIGnC;

				private uint EkGxDOFKRFNkLXPowKxgcxyUjJS;

				private uint JGncqhAqcatRBcQdKXJTOalgQUtg;

				private float eUeUZsnrmrmWwYWxUubOgegTPWY;

				private float XwMeXEcTeJuaeHFBKyBQFGGizZs;

				public double GCwgDdqytcsdqcvxuiixUcRVeFm => YMYTaTajBfiVzHUrZjYZlFSZEzw;

				public double qQiGClLTifwpXcFFIGllpQJtLTi => EBIttHTFSXzrTiiDDBVtBoscnzr;

				public double pShflJlEalzVlXfYfXFXKdZEKKH => lyBydcWcKSploRFtOFUCCuxEcswX;

				public uint UsGwHXtMUNCrZXGfCMaMzrOwvzF => EkGxDOFKRFNkLXPowKxgcxyUjJS;

				public uint utjuyWlsaObrsvNtTQCCYbbXgat => JGncqhAqcatRBcQdKXJTOalgQUtg;

				public float RFAschjPztyQpuUaztuASDLqXlb => eUeUZsnrmrmWwYWxUubOgegTPWY;

				public float dxlsTGrqpdnrPLoxyefxqogUFWS => XwMeXEcTeJuaeHFBKyBQFGGizZs;

				public rLIbmTXyZYGzsAbADGihRoRAhSX(UpdateLoopType updateLoop)
				{
					EtMuBRTmVzCBLcuxYRMlwUqRdAzD = updateLoop;
					YwHorTitbGsmNRsSkobcfJBrIGnC = Time.realtimeSinceStartup;
					EkGxDOFKRFNkLXPowKxgcxyUjJS = 0u;
				}

				public void mtiNfGzpXHszOwiOIAVYQuMZclV()
				{
					EBIttHTFSXzrTiiDDBVtBoscnzr = YMYTaTajBfiVzHUrZjYZlFSZEzw;
					YMYTaTajBfiVzHUrZjYZlFSZEzw = realTime;
					if (YwHorTitbGsmNRsSkobcfJBrIGnC > YMYTaTajBfiVzHUrZjYZlFSZEzw)
					{
						YwHorTitbGsmNRsSkobcfJBrIGnC = 0.0;
					}
					lyBydcWcKSploRFtOFUCCuxEcswX = YMYTaTajBfiVzHUrZjYZlFSZEzw - YwHorTitbGsmNRsSkobcfJBrIGnC;
					YwHorTitbGsmNRsSkobcfJBrIGnC = YMYTaTajBfiVzHUrZjYZlFSZEzw;
					JGncqhAqcatRBcQdKXJTOalgQUtg = EkGxDOFKRFNkLXPowKxgcxyUjJS;
					EkGxDOFKRFNkLXPowKxgcxyUjJS = MiscTools.Tick(EkGxDOFKRFNkLXPowKxgcxyUjJS);
					XwMeXEcTeJuaeHFBKyBQFGGizZs = eUeUZsnrmrmWwYWxUubOgegTPWY;
					eUeUZsnrmrmWwYWxUubOgegTPWY = ExRgnWaBueNAucLnVbDaADqvVNzc();
					previousFrame = JGncqhAqcatRBcQdKXJTOalgQUtg;
					currentFrame = EkGxDOFKRFNkLXPowKxgcxyUjJS;
					unscaledTime = YMYTaTajBfiVzHUrZjYZlFSZEzw;
					unscaledTimePrev = EBIttHTFSXzrTiiDDBVtBoscnzr;
					unscaledDeltaTime = lyBydcWcKSploRFtOFUCCuxEcswX;
				}
			}

			private static class pnRakpMlUdhYpdKWQRKwCEBZezM
			{
				public static StopwatchBase iifrJgOBxdBjBAnwPdgbERehdMbW
				{
					get
					{
						if (!UnityTools.isEditor && UnityTools.platform == Platform.XboxOne)
						{
							return UnityStopwatch.Global;
						}
						return Stopwatch.Global;
					}
				}

				public static StopwatchBase aWlEKFrTmxgBGgRqJDXRHeKwHYg()
				{
					if (!UnityTools.isEditor && UnityTools.platform == Platform.XboxOne)
					{
						return new UnityStopwatch();
					}
					return new Stopwatch();
				}

				public static StopwatchBase KrtbSaFVqVylgTOjVMhlTLyCwnz()
				{
					if (!UnityTools.isEditor && UnityTools.platform == Platform.XboxOne)
					{
						return UnityStopwatch.StartNew();
					}
					return Stopwatch.StartNew();
				}
			}

			private StopwatchBase yVjrtGXvhZheUOHIZHlniSfjQZWG;

			private double vmQlOxdOUhMPpHcnjzGGVPcVeysg;

			private rLIbmTXyZYGzsAbADGihRoRAhSX RXULDmNVpivDuyQDlktTMnqGxbW;

			private ADictionary<int, rLIbmTXyZYGzsAbADGihRoRAhSX> qWJOLmRRxKVSFCowfatooKRWAdb;

			private uint VecFhsWplPFJVByxPLyrTLPxjyRf;

			public double GCwgDdqytcsdqcvxuiixUcRVeFm => RXULDmNVpivDuyQDlktTMnqGxbW.GCwgDdqytcsdqcvxuiixUcRVeFm;

			public double qQiGClLTifwpXcFFIGllpQJtLTi => RXULDmNVpivDuyQDlktTMnqGxbW.qQiGClLTifwpXcFFIGllpQJtLTi;

			public double pShflJlEalzVlXfYfXFXKdZEKKH => RXULDmNVpivDuyQDlktTMnqGxbW.pShflJlEalzVlXfYfXFXKdZEKKH;

			public float RFAschjPztyQpuUaztuASDLqXlb => RXULDmNVpivDuyQDlktTMnqGxbW.RFAschjPztyQpuUaztuASDLqXlb;

			public float dxlsTGrqpdnrPLoxyefxqogUFWS => RXULDmNVpivDuyQDlktTMnqGxbW.dxlsTGrqpdnrPLoxyefxqogUFWS;

			internal double lxaRDQbgFoGTjRLdkHxFCmGoIRWI => yVjrtGXvhZheUOHIZHlniSfjQZWG.elapsedSeconds + vmQlOxdOUhMPpHcnjzGGVPcVeysg;

			public uint UsGwHXtMUNCrZXGfCMaMzrOwvzF => RXULDmNVpivDuyQDlktTMnqGxbW.UsGwHXtMUNCrZXGfCMaMzrOwvzF;

			public uint utjuyWlsaObrsvNtTQCCYbbXgat => RXULDmNVpivDuyQDlktTMnqGxbW.utjuyWlsaObrsvNtTQCCYbbXgat;

			public uint IQsonIHNwVaWddRXdHnvRmcDlSmT => VecFhsWplPFJVByxPLyrTLPxjyRf;

			public uLLVkeYyPzsBcHIMbAchcIFgPOMw()
			{
				yVjrtGXvhZheUOHIZHlniSfjQZWG = pnRakpMlUdhYpdKWQRKwCEBZezM.iifrJgOBxdBjBAnwPdgbERehdMbW;
				skeOSBSqSPGPnIZySfEhxuCHbTXM();
			}

			public void gKgciFGmJUDriAduDqYflaCIeoeQ()
			{
				vmQlOxdOUhMPpHcnjzGGVPcVeysg = Time.realtimeSinceStartup;
			}

			public void skeOSBSqSPGPnIZySfEhxuCHbTXM()
			{
				RXULDmNVpivDuyQDlktTMnqGxbW = null;
				qWJOLmRRxKVSFCowfatooKRWAdb = new ADictionary<int, rLIbmTXyZYGzsAbADGihRoRAhSX>();
				using TempListPool.TList<UpdateLoopType> tList = TempListPool.GetTList<UpdateLoopType>(3);
				List<UpdateLoopType> list = tList.list;
				EnumConverter.ToUpdateLoopTypes((UpdateLoopSetting)2147483647, list);
				for (int i = 0; i < list.Count; i++)
				{
					rLIbmTXyZYGzsAbADGihRoRAhSX rLIbmTXyZYGzsAbADGihRoRAhSX = new rLIbmTXyZYGzsAbADGihRoRAhSX(list[i]);
					qWJOLmRRxKVSFCowfatooKRWAdb.Add((int)list[i], rLIbmTXyZYGzsAbADGihRoRAhSX);
					if (RXULDmNVpivDuyQDlktTMnqGxbW == null)
					{
						RXULDmNVpivDuyQDlktTMnqGxbW = rLIbmTXyZYGzsAbADGihRoRAhSX;
					}
				}
			}

			public void mtiNfGzpXHszOwiOIAVYQuMZclV(UpdateLoopType P_0)
			{
				if (RXULDmNVpivDuyQDlktTMnqGxbW.EtMuBRTmVzCBLcuxYRMlwUqRdAzD != P_0)
				{
					RXULDmNVpivDuyQDlktTMnqGxbW = qWJOLmRRxKVSFCowfatooKRWAdb[(int)P_0];
				}
				if (P_0 != UpdateLoopType.OnGUI || Event.current.rawType == EventType.Layout)
				{
					RXULDmNVpivDuyQDlktTMnqGxbW.mtiNfGzpXHszOwiOIAVYQuMZclV();
					VecFhsWplPFJVByxPLyrTLPxjyRf = MiscTools.Tick(VecFhsWplPFJVByxPLyrTLPxjyRf);
					absFrame = VecFhsWplPFJVByxPLyrTLPxjyRf;
				}
			}
		}

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public sealed class UnityTouch : CodeHelper
		{
			private static UnityTouch GclIwrgVrnJKTEKbDVzknvtphRgP;

			internal static UnityTouch Instance => GclIwrgVrnJKTEKbDVzknvtphRgP ?? (GclIwrgVrnJKTEKbDVzknvtphRgP = new UnityTouch());

			public int touchCount => Input.touchCount;

			public Touch[] touches => Input.touches;

			public bool simulateMouseWithTouches
			{
				get
				{
					return Input.simulateMouseWithTouches;
				}
				set
				{
					Input.simulateMouseWithTouches = value;
				}
			}

			public bool multiTouchEnabled
			{
				get
				{
					return Input.multiTouchEnabled;
				}
				set
				{
					Input.multiTouchEnabled = value;
				}
			}

			private UnityTouch()
			{
			}

			public Touch GetTouch(int index)
			{
				return Input.GetTouch(index);
			}
		}

		internal class VRCvcBTFbvrMaAwvQTpJxuZpEHa
		{
			public readonly ValueWatcher<bool> HMvlQnzqXxdfzjOdwdzDAfVOcG;

			public readonly ValueWatcher<bool> RQodkTEXhVLxRjGVfqViuoyJJay;

			public readonly ValueWatcher<bool> kdWCnSsBpsgkryWtwBzbBCFFTtH;

			public readonly ValueWatcher<int> qdsbfKLkMIHclELvehRmvmaFZbX;

			public readonly ValueWatcher<float> pShflJlEalzVlXfYfXFXKdZEKKH;

			public readonly ValueWatcher<string> XwsaKELqFHJDbJQBqLkSevGYnpS;

			public readonly ValueWatcher<bool> jDCxGNnaIZEWOGiRqYmgsrtvMYz;

			private int YlunHgektYmRUqJQJbmjGTYEiOHH;

			private readonly ValueWatcher[] PHCcRznwUPKOJXxpSrnuuZfBqDf;

			[CompilerGenerated]
			private static Func<bool> EtdBfztnTfaxFsXBJoGXaFimnSn;

			[CompilerGenerated]
			private static Func<bool> BrVfUZBtVMPFpEqDJXvQuKXAGKKB;

			[CompilerGenerated]
			private static Func<int> xxYJMGvmxTCaPdDdNCwoNxTuHSr;

			[CompilerGenerated]
			private static Func<float> mwHTwUQvJZJMUScisyzYsKqZfwg;

			[CompilerGenerated]
			private static Func<bool> FnMiDJvZXbwsCIZpVdQXcyVyMjR;

			[CompilerGenerated]
			private static Func<string> NfYRnIsaZfWbdnPnCdNLheuZddDb;

			public int fWuDjxoNMlbgWhwduhBnnzAbEOlE => YlunHgektYmRUqJQJbmjGTYEiOHH;

			public VRCvcBTFbvrMaAwvQTpJxuZpEHa()
			{
				List<ValueWatcher> list = new List<ValueWatcher>
				{
					HMvlQnzqXxdfzjOdwdzDAfVOcG = new ValueWatcher<bool>(initialValue: true, autoTriggerEvent: false),
					RQodkTEXhVLxRjGVfqViuoyJJay = new ValueWatcher<bool>(Screen.fullScreen, () => Screen.fullScreen, autoTriggerEvent: false),
					kdWCnSsBpsgkryWtwBzbBCFFTtH = new ValueWatcher<bool>(Application.runInBackground, () => Application.runInBackground, autoTriggerEvent: false),
					qdsbfKLkMIHclELvehRmvmaFZbX = new ValueWatcher<int>((int)Screen.fullScreenMode, () => (int)Screen.fullScreenMode, autoTriggerEvent: false),
					pShflJlEalzVlXfYfXFXKdZEKKH = new ValueWatcher<float>(Time.unscaledDeltaTime, () => Time.unscaledDeltaTime, autoTriggerEvent: false),
					jDCxGNnaIZEWOGiRqYmgsrtvMYz = new ValueWatcher<bool>(MathTools.ApproximatelyZero(Time.timeScale), () => MathTools.ApproximatelyZero(Time.timeScale), MathTools.ApproximatelyZero(Time.timeScale))
				};
				if (editorPlatform != 0)
				{
					list.Add(XwsaKELqFHJDbJQBqLkSevGYnpS = new ValueWatcher<string>(UnityTools.externalTools.GetFocusedEditorWindowTitle(), () => UnityTools.externalTools.GetFocusedEditorWindowTitle(), autoTriggerEvent: false));
				}
				PHCcRznwUPKOJXxpSrnuuZfBqDf = list.ToArray();
				mtiNfGzpXHszOwiOIAVYQuMZclV();
			}

			public void mtiNfGzpXHszOwiOIAVYQuMZclV()
			{
				for (int i = 0; i < PHCcRznwUPKOJXxpSrnuuZfBqDf.Length; i++)
				{
					PHCcRznwUPKOJXxpSrnuuZfBqDf[i].Update();
				}
				YlunHgektYmRUqJQJbmjGTYEiOHH = Time.frameCount;
			}

			public void pVilXFzFXmXaLTpVPEpxMBpKEFnc()
			{
				for (int i = 0; i < PHCcRznwUPKOJXxpSrnuuZfBqDf.Length; i++)
				{
					PHCcRznwUPKOJXxpSrnuuZfBqDf[i].TriggerEvent();
				}
			}

			[CompilerGenerated]
			private static bool ljvwCVmoAPAZtDCptQZhBKCYicJ()
			{
				return Screen.fullScreen;
			}

			[CompilerGenerated]
			private static bool dNyKEgPbVpVOmiANclGvzIPMCWO()
			{
				return Application.runInBackground;
			}

			[CompilerGenerated]
			private static int wHBRNcnMxOyHJwCaafOtRUjsLT()
			{
				return (int)Screen.fullScreenMode;
			}

			[CompilerGenerated]
			private static float jASQjApUjVjHpoHQoxIfPHuzYsQ()
			{
				return Time.unscaledDeltaTime;
			}

			[CompilerGenerated]
			private static bool VUjMYyEYreimNhSJvogbdDTxVnK()
			{
				return MathTools.ApproximatelyZero(Time.timeScale);
			}

			[CompilerGenerated]
			private static string ZftbpxiwByjizWJHznACQauDUWCq()
			{
				return UnityTools.externalTools.GetFocusedEditorWindowTitle();
			}
		}

		[CustomObfuscation(rename = false)]
		internal const int programVersion1 = 1;

		[CustomObfuscation(rename = false)]
		internal const int programVersion2 = 1;

		[CustomObfuscation(rename = false)]
		internal const int programVersion3 = 40;

		[CustomObfuscation(rename = false)]
		internal const int programVersion4 = 0;

		[CustomObfuscation(rename = false)]
		internal const int dataVersion = 1;

		[CustomObfuscation(rename = false)]
		internal const bool isTrial = false;

		[CustomObfuscation(rename = false)]
		internal const string majorBranch = "U2021";

		private static InputManager_Base AdpjYGRLHiVIDWJZGBdZJhLTsHYd;

		private static PlatformInputManager NIbjgVXnyQjOQkqfXoodfUsgkUI;

		internal static kLMNgAaaWPjwLSfBhKqJsCvkZws JLezATTKNEMVFfHVAgRNIpvVfYV;

		internal static uhjoXbTonsTOuVJOQAQlbMAgzIYW CoyPNJHWMheFytmTMQdqyctMRFl;

		internal static IgaBaIZucbxpplxyQFPTbarjdUW kRIMscNTqYOjJDgtnNDWfmLNvzj;

		private static ControllerDataFiles ytlEooerRTdysEAPDtAKhGdaWSGa;

		private static UserData hxqbdqzxiQgQaiRpIPHaudXzLll;

		private static bool vqjuhdYKKuBgDKqCJHOYrBTbbEX;

		private static ConfigVars HehCWeotwUMdbOxHQPtFQrTEOmz;

		private static UpdateLoopType QeSkCjKHJJFgSnLThoPbfSIQDAd;

		private static bool xJurUJejHKNQiSCecRomlUYUKdh;

		private static Platform nclCooBBSIHvMgETCcQliiIhqrLp;

		private static WebplayerPlatform DLLPKIBfqPmGcNCmZVKwRhKVqqz;

		private static EditorPlatform lpKROTnUkBsRgnUVlurlFnkpNIn;

		private static bool rLudkxbsubVXxHRyDDwksYKhBjmv;

		private static TimerAbs OQZywUdvSrhokhmhpvyofsetAAc;

		private static uLLVkeYyPzsBcHIMbAchcIFgPOMw LyNclYHYHXKFxZgnbiNEISkbAkYE;

		private static string fTWFIAjMJvLbZcIwAMSYPQmwLiRE;

		private static bool yXeDwQdSiSrAdHseoslxkawKdVLG;

		private static bool TRglUNiFhQgfjdZRfIECAiYSOsjj;

		private static bool naudnRIfsEkdsbBZUTmSqiALBkv;

		private static int LPNbaBGJFAONKKCfzJNHCkavuHJf;

		[CustomObfuscation(rename = false)]
		internal static int _id;

		private static int nJVXstkBqURfKgMkyCEmSAivMdF;

		private static int BLLLlyOjXPHkCWLrqiONTYYDkDp;

		private static bool MvrxkTZPKNoHjnecWuqeluBxGsi;

		private static readonly UnityTouch dvHVdZWfSpoWqWKQETGCxTNIDqR;

		private static readonly PlayerHelper ZbgdevbwZINThCMbnrJpecOWWEcf;

		private static readonly ControllerHelper HxhodIwCilHFNIWyGBcCfynKYdIG;

		private static readonly MappingHelper fehhyuOhLBkOegIfvSlKGoXKbAOa;

		private static readonly TimeHelper taheheFhpZyCgpxAxCtdBUNoEkCC;

		private static readonly ConfigHelper ebxLCnzXBYJMzJHkFjgNxVUptmu;

		private static VxMymkFCzbjRQkOYlATYKBOfKBZ vZUcfpfaNwPEIgHwaJHnLuBNnAYE;

		private static UserDataStore GobdtmbruEJNYCIxWnhBgZLINlvg;

		private static IControllerAssigner VYkmIQSoqzGiilkTquOEHSRJNlg;

		private static VRCvcBTFbvrMaAwvQTpJxuZpEHa XhfUNdIHEJxTPmfAWhXgTZWtcPF;

		private static SafeAction<ControllerStatusChangedEventArgs> bGaxUCCrdNJDGxbNgwWlkgnVIPP;

		private static SafeAction<ControllerStatusChangedEventArgs> GXWgmgKuhczIhTmKnUdTVtIsdwz;

		private static SafeAction<ControllerStatusChangedEventArgs> YdZehWzFPwcXIXTEkpfcQKPRaHp;

		private static SafeAction OzIXwsUkOqbKUhMpEKRhEetjcIdH;

		private static SafeAction WVGNwxhOBFqhXhZaMjgunyzlKqr;

		private static SafeAction AmHxuSqizUEjnXcNPQqIRCINKyW;

		private static SafeAction EfcIkYSFAlTHIywPdDqQJewwjll;

		private static SafeAction gUIiCVppIHpbLsJmhhLjcJCVnfMF;

		[CustomObfuscation(rename = false)]
		private static Action<bool> _ApplicationFocusChangedEvent;

		private static Action RAHpIqsIIkQwMyBhGCpKCVjnLMf;

		private static Action<UpdateLoopType> YmYjSfvfHUEgzEQianjULpiixOyi;

		private static Action<UpdateLoopType> EWNtLACmKZFsaNRVKTLFAVHBEiZ;

		private static Action<UpdateLoopType> ALKQKUZJadldOleZoIhfQRGRyHn;

		private static Action oWwHdzkYNqutnOHHdoEhlCPIIuP;

		private static Action<bool> jmtxJyXAsHNbocMITyjArPDiGgHK;

		private static Action<bool> MkBQpFtstCbcIfYbaALaBVuhQrKp;

		private static Action<bool> XDPWeaJzgqMwVayHYRvDdPAGoRY;

		private static Action<FullScreenMode> HBXFOsdcOKqCAfJlsjrpUaWnnYeY;

		private static Action prHfhcFoddIUMsJEZtIfPlAYWdLD;

		private static Action<bool> ImxPflkaciKBuzBFDSHdSkUGpBs;

		[CustomObfuscation(rename = false)]
		internal static double unscaledDeltaTime;

		[CustomObfuscation(rename = false)]
		internal static double unscaledTime;

		[CustomObfuscation(rename = false)]
		internal static double unscaledTimePrev;

		[CustomObfuscation(rename = false)]
		internal static uint currentFrame;

		[CustomObfuscation(rename = false)]
		internal static uint previousFrame;

		[CustomObfuscation(rename = false)]
		internal static uint absFrame;

		[CompilerGenerated]
		private static Action<Exception> qNraOOiURizrKsGQRcoqxyiwekF;

		[CompilerGenerated]
		private static Action<Exception> HyCmcTHyAhdXLHXzIFmQOMIzjFh;

		[CompilerGenerated]
		private static Action<Exception> gTYRrCnrkVCmudsUsPBUUohWrzM;

		[CompilerGenerated]
		private static Action<Exception> MggiWmlpzhFVcvVyBoVFxcbimgr;

		[CompilerGenerated]
		private static Action<Exception> zBhuNuuEsfwsipThsXHBQeslDqD;

		[CompilerGenerated]
		private static Action<Exception> gvArhGOBWpDcohRlpqsSfXndgoC;

		[CompilerGenerated]
		private static Action<Exception> KDukIKOmvJrtHzIVeoHFVpPLCZd;

		[CompilerGenerated]
		private static Action<Exception> mKQCrCmgNNDGvCWoLRJbRTDvKuH;

		[CompilerGenerated]
		private static Action<Exception> hPrdchDdbBaxSlQsicKoymsAGgzE;

		[CompilerGenerated]
		private static Func<bool> UHBYUPhpMAaxtfJMWcATONZDSkJq;

		private static VxMymkFCzbjRQkOYlATYKBOfKBZ unityInputBuffer => vZUcfpfaNwPEIgHwaJHnLuBNnAYE ?? (vZUcfpfaNwPEIgHwaJHnLuBNnAYE = new VxMymkFCzbjRQkOYlATYKBOfKBZ(HehCWeotwUMdbOxHQPtFQrTEOmz.updateLoop));

		public static PlayerHelper players
		{
			get
			{
				if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					IRZGSkWsFxwQwgDqGrxCgkUucgM();
					return null;
				}
				return ZbgdevbwZINThCMbnrJpecOWWEcf;
			}
		}

		public static ControllerHelper controllers
		{
			get
			{
				if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					IRZGSkWsFxwQwgDqGrxCgkUucgM();
					return null;
				}
				return HxhodIwCilHFNIWyGBcCfynKYdIG;
			}
		}

		public static MappingHelper mapping
		{
			get
			{
				if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					IRZGSkWsFxwQwgDqGrxCgkUucgM();
					return null;
				}
				return fehhyuOhLBkOegIfvSlKGoXKbAOa;
			}
		}

		public static UnityTouch touch
		{
			get
			{
				if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					IRZGSkWsFxwQwgDqGrxCgkUucgM();
					return null;
				}
				return dvHVdZWfSpoWqWKQETGCxTNIDqR;
			}
		}

		public static TimeHelper time
		{
			get
			{
				if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					IRZGSkWsFxwQwgDqGrxCgkUucgM();
					return null;
				}
				return taheheFhpZyCgpxAxCtdBUNoEkCC;
			}
		}

		public static IUserDataStore userDataStore
		{
			get
			{
				if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					IRZGSkWsFxwQwgDqGrxCgkUucgM();
					return null;
				}
				return GobdtmbruEJNYCIxWnhBgZLINlvg;
			}
		}

		public static ConfigHelper configuration
		{
			get
			{
				if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					IRZGSkWsFxwQwgDqGrxCgkUucgM();
					return null;
				}
				return ebxLCnzXBYJMzJHkFjgNxVUptmu;
			}
		}

		public static string programVersion => 1 + "." + 1 + "." + 40 + "." + 0 + ".U2021";

		public static bool usingUnityInput => xJurUJejHKNQiSCecRomlUYUKdh;

		public static bool unityJoystickIdentificationRequired
		{
			get
			{
				if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					return false;
				}
				if (isWindowsStandaloneWebplayerOrEditorPlatform && !UnityTools.windowsJoystickNamesReturnsEmptyStringsIfJoystickNull)
				{
					return true;
				}
				return false;
			}
		}

		public static bool isReady => vqjuhdYKKuBgDKqCJHOYrBTbbEX;

		[CustomObfuscation(rename = false)]
		internal static int id => _id;

		[CustomObfuscation(rename = false)]
		internal static bool initialized => vqjuhdYKKuBgDKqCJHOYrBTbbEX;

		[CustomObfuscation(rename = false)]
		internal static UpdateLoopType currentUpdateLoop => QeSkCjKHJJFgSnLThoPbfSIQDAd;

		[CustomObfuscation(rename = false)]
		internal static ConfigVars configVars => HehCWeotwUMdbOxHQPtFQrTEOmz;

		[CustomObfuscation(rename = false)]
		internal static IConfigVars_Internal pluginConfigVars => HehCWeotwUMdbOxHQPtFQrTEOmz;

		[CustomObfuscation(rename = false)]
		internal static UserData UserData => hxqbdqzxiQgQaiRpIPHaudXzLll;

		[CustomObfuscation(rename = false)]
		internal static Platform currentPlatform => nclCooBBSIHvMgETCcQliiIhqrLp;

		[CustomObfuscation(rename = false)]
		internal static WebplayerPlatform webplayerPlatform => DLLPKIBfqPmGcNCmZVKwRhKVqqz;

		[CustomObfuscation(rename = false)]
		internal static EditorPlatform editorPlatform => lpKROTnUkBsRgnUVlurlFnkpNIn;

		[CustomObfuscation(rename = false)]
		internal static bool checkNeverPressed
		{
			get
			{
				if (nclCooBBSIHvMgETCcQliiIhqrLp == Platform.Linux && xJurUJejHKNQiSCecRomlUYUKdh)
				{
					return true;
				}
				if (nclCooBBSIHvMgETCcQliiIhqrLp == Platform.OSX && (xJurUJejHKNQiSCecRomlUYUKdh || primaryInputManager.inputSourceType == InputSource.OSX))
				{
					return true;
				}
				if (UnityTools.isAndroidPlatform && xJurUJejHKNQiSCecRomlUYUKdh)
				{
					return true;
				}
				if (nclCooBBSIHvMgETCcQliiIhqrLp == Platform.Webplayer && DLLPKIBfqPmGcNCmZVKwRhKVqqz == WebplayerPlatform.OSX)
				{
					return true;
				}
				if (nclCooBBSIHvMgETCcQliiIhqrLp == Platform.WebGL)
				{
					return true;
				}
				return false;
			}
		}

		[CustomObfuscation(rename = false)]
		internal static bool isEditor => lpKROTnUkBsRgnUVlurlFnkpNIn != EditorPlatform.None;

		[CustomObfuscation(rename = false)]
		internal static Guid defaultHardwareJoystickMapGuid
		{
			get
			{
				if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					return Guid.Empty;
				}
				return ytlEooerRTdysEAPDtAKhGdaWSGa.defaultHardwareJoystickMapGuid;
			}
		}

		[CustomObfuscation(rename = false)]
		internal static bool isRunningInEditMode => TRglUNiFhQgfjdZRfIECAiYSOsjj;

		[CustomObfuscation(rename = false)]
		internal static bool isEditorPaused => UnityTools.externalTools.isEditorPaused;

		[CustomObfuscation(rename = false)]
		internal static float unityUnscaledDeltaTime => LyNclYHYHXKFxZgnbiNEISkbAkYE.RFAschjPztyQpuUaztuASDLqXlb;

		[CustomObfuscation(rename = false)]
		internal static float unityUnscaledDeltaTimePrev => LyNclYHYHXKFxZgnbiNEISkbAkYE.dxlsTGrqpdnrPLoxyefxqogUFWS;

		[CustomObfuscation(rename = false)]
		internal static double realTime
		{
			get
			{
				if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					return 0.0;
				}
				return LyNclYHYHXKFxZgnbiNEISkbAkYE.lxaRDQbgFoGTjRLdkHxFCmGoIRWI;
			}
		}

		[CustomObfuscation(rename = false)]
		internal static int currentUnityFrame
		{
			get
			{
				if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					return 0;
				}
				return XhfUNdIHEJxTPmfAWhXgTZWtcPF.fWuDjxoNMlbgWhwduhBnnzAbEOlE;
			}
		}

		private static bool isEditorGameViewFocused
		{
			get
			{
				if (UnityTools.unityVersion >= UnityTools.UnityVersion.UNITY_5_1)
				{
					return fTWFIAjMJvLbZcIwAMSYPQmwLiRE == "Game";
				}
				return fTWFIAjMJvLbZcIwAMSYPQmwLiRE == "UnityEditor.GameView";
			}
		}

		[CustomObfuscation(rename = false)]
		internal static bool isAllowedEditorWindowFocused
		{
			get
			{
				if (HehCWeotwUMdbOxHQPtFQrTEOmz.allowInputInEditorSceneView && UnityTools.externalTools.IsEditorSceneViewFocused())
				{
					return true;
				}
				if (!naudnRIfsEkdsbBZUTmSqiALBkv)
				{
					return isEditorGameViewFocused;
				}
				return true;
			}
		}

		[CustomObfuscation(rename = false)]
		internal static bool isUnityEditorFocused
		{
			get
			{
				if (NIbjgVXnyQjOQkqfXoodfUsgkUI is INativePlatformHelper nativePlatformHelper)
				{
					return nativePlatformHelper.isApplicationFocused;
				}
				return naudnRIfsEkdsbBZUTmSqiALBkv;
			}
		}

		[CustomObfuscation(rename = false)]
		internal static bool isWindowsStandaloneWebplayerOrEditorPlatform
		{
			get
			{
				if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					return false;
				}
				if (!xJurUJejHKNQiSCecRomlUYUKdh)
				{
					return false;
				}
				if (nclCooBBSIHvMgETCcQliiIhqrLp != Platform.Windows && (nclCooBBSIHvMgETCcQliiIhqrLp != Platform.Webplayer || DLLPKIBfqPmGcNCmZVKwRhKVqqz != WebplayerPlatform.Windows))
				{
					return lpKROTnUkBsRgnUVlurlFnkpNIn == EditorPlatform.Windows;
				}
				return true;
			}
		}

		private static bool inputAllowed
		{
			get
			{
				if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					return false;
				}
				if (!XhfUNdIHEJxTPmfAWhXgTZWtcPF.HMvlQnzqXxdfzjOdwdzDAfVOcG.value)
				{
					if (MvrxkTZPKNoHjnecWuqeluBxGsi)
					{
						return false;
					}
					if (!isEditor && !XhfUNdIHEJxTPmfAWhXgTZWtcPF.kdWCnSsBpsgkryWtwBzbBCFFTtH.value)
					{
						return false;
					}
				}
				return true;
			}
		}

		[CustomObfuscation(rename = false)]
		internal static bool applicationIsFocused
		{
			get
			{
				if (vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					return XhfUNdIHEJxTPmfAWhXgTZWtcPF.HMvlQnzqXxdfzjOdwdzDAfVOcG.value;
				}
				return false;
			}
		}

		[CustomObfuscation(rename = false)]
		internal static bool applicationIsFullScreen
		{
			get
			{
				if (vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					return XhfUNdIHEJxTPmfAWhXgTZWtcPF.RQodkTEXhVLxRjGVfqViuoyJJay.value;
				}
				return false;
			}
		}

		[CustomObfuscation(rename = false)]
		internal static bool applicationRunInBackground
		{
			get
			{
				if (vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					return XhfUNdIHEJxTPmfAWhXgTZWtcPF.kdWCnSsBpsgkryWtwBzbBCFFTtH.value;
				}
				return false;
			}
		}

		[CustomObfuscation(rename = false)]
		internal static bool timeScaleIsPaused
		{
			get
			{
				if (vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					return XhfUNdIHEJxTPmfAWhXgTZWtcPF.jDCxGNnaIZEWOGiRqYmgsrtvMYz.value;
				}
				return false;
			}
		}

		[CustomObfuscation(rename = false)]
		internal static InputManager_Base rewiredInputManager => AdpjYGRLHiVIDWJZGBdZJhLTsHYd;

		[CustomObfuscation(rename = false)]
		internal static PlatformInputManager primaryInputManager
		{
			get
			{
				if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
				{
					IRZGSkWsFxwQwgDqGrxCgkUucgM();
					return null;
				}
				return NIbjgVXnyQjOQkqfXoodfUsgkUI.primaryInputManager;
			}
		}

		[CustomObfuscation(rename = false)]
		internal static IControllerAssigner controllerAssigner
		{
			get
			{
				return VYkmIQSoqzGiilkTquOEHSRJNlg;
			}
			set
			{
				VYkmIQSoqzGiilkTquOEHSRJNlg = value;
			}
		}

		[CustomObfuscation(rename = false)]
		internal static RewiredVersion rewiredVersion => new RewiredVersion(programVersion);

		[CustomObfuscation(rename = false)]
		internal static int timeScalePauseChangedCount => BLLLlyOjXPHkCWLrqiONTYYDkDp;

		public static event Action<ControllerStatusChangedEventArgs> ControllerConnectedEvent
		{
			add
			{
				bGaxUCCrdNJDGxbNgwWlkgnVIPP += value;
			}
			remove
			{
				bGaxUCCrdNJDGxbNgwWlkgnVIPP -= value;
			}
		}

		public static event Action<ControllerStatusChangedEventArgs> ControllerPreDisconnectEvent
		{
			add
			{
				GXWgmgKuhczIhTmKnUdTVtIsdwz += value;
			}
			remove
			{
				GXWgmgKuhczIhTmKnUdTVtIsdwz -= value;
			}
		}

		public static event Action<ControllerStatusChangedEventArgs> ControllerDisconnectedEvent
		{
			add
			{
				YdZehWzFPwcXIXTEkpfcQKPRaHp += value;
			}
			remove
			{
				YdZehWzFPwcXIXTEkpfcQKPRaHp -= value;
			}
		}

		public static event Action InputSourceUpdateEvent
		{
			add
			{
				OzIXwsUkOqbKUhMpEKRhEetjcIdH += value;
			}
			remove
			{
				OzIXwsUkOqbKUhMpEKRhEetjcIdH -= value;
			}
		}

		public static event Action EditorRecompileEvent
		{
			add
			{
				WVGNwxhOBFqhXhZaMjgunyzlKqr += value;
			}
			remove
			{
				WVGNwxhOBFqhXhZaMjgunyzlKqr -= value;
			}
		}

		public static event Action PreShutDownEvent
		{
			add
			{
				AmHxuSqizUEjnXcNPQqIRCINKyW += value;
			}
			remove
			{
				AmHxuSqizUEjnXcNPQqIRCINKyW -= value;
			}
		}

		public static event Action ShutDownEvent
		{
			add
			{
				EfcIkYSFAlTHIywPdDqQJewwjll += value;
			}
			remove
			{
				EfcIkYSFAlTHIywPdDqQJewwjll -= value;
			}
		}

		public static event Action InitializedEvent
		{
			add
			{
				gUIiCVppIHpbLsJmhhLjcJCVnfMF += value;
			}
			remove
			{
				gUIiCVppIHpbLsJmhhLjcJCVnfMF -= value;
			}
		}

		[CustomObfuscation(rename = false)]
		internal static event Action<bool> ApplicationFocusChangedEvent
		{
			add
			{
				_ApplicationFocusChangedEvent = (Action<bool>)Delegate.Combine(_ApplicationFocusChangedEvent, value);
			}
			remove
			{
				_ApplicationFocusChangedEvent = (Action<bool>)Delegate.Remove(_ApplicationFocusChangedEvent, value);
			}
		}

		[CustomObfuscation(rename = false)]
		internal static event Action EarlyUpdateEvent
		{
			add
			{
				RAHpIqsIIkQwMyBhGCpKCVjnLMf = (Action)Delegate.Combine(RAHpIqsIIkQwMyBhGCpKCVjnLMf, value);
			}
			remove
			{
				RAHpIqsIIkQwMyBhGCpKCVjnLMf = (Action)Delegate.Remove(RAHpIqsIIkQwMyBhGCpKCVjnLMf, value);
			}
		}

		[CustomObfuscation(rename = false)]
		internal static event Action<UpdateLoopType> BeforeTimeManagerUpdateEvent
		{
			add
			{
				YmYjSfvfHUEgzEQianjULpiixOyi = (Action<UpdateLoopType>)Delegate.Combine(YmYjSfvfHUEgzEQianjULpiixOyi, value);
			}
			remove
			{
				YmYjSfvfHUEgzEQianjULpiixOyi = (Action<UpdateLoopType>)Delegate.Remove(YmYjSfvfHUEgzEQianjULpiixOyi, value);
			}
		}

		[CustomObfuscation(rename = false)]
		internal static event Action<UpdateLoopType> UpdateStartedEvent
		{
			add
			{
				EWNtLACmKZFsaNRVKTLFAVHBEiZ = (Action<UpdateLoopType>)Delegate.Combine(EWNtLACmKZFsaNRVKTLFAVHBEiZ, value);
			}
			remove
			{
				EWNtLACmKZFsaNRVKTLFAVHBEiZ = (Action<UpdateLoopType>)Delegate.Remove(EWNtLACmKZFsaNRVKTLFAVHBEiZ, value);
			}
		}

		[CustomObfuscation(rename = false)]
		internal static event Action<UpdateLoopType> UpdateEndedEvent
		{
			add
			{
				ALKQKUZJadldOleZoIhfQRGRyHn = (Action<UpdateLoopType>)Delegate.Combine(ALKQKUZJadldOleZoIhfQRGRyHn, value);
			}
			remove
			{
				ALKQKUZJadldOleZoIhfQRGRyHn = (Action<UpdateLoopType>)Delegate.Remove(ALKQKUZJadldOleZoIhfQRGRyHn, value);
			}
		}

		[CustomObfuscation(rename = false)]
		internal static event Action LateUpdateEvent
		{
			add
			{
				oWwHdzkYNqutnOHHdoEhlCPIIuP = (Action)Delegate.Combine(oWwHdzkYNqutnOHHdoEhlCPIIuP, value);
			}
			remove
			{
				oWwHdzkYNqutnOHHdoEhlCPIIuP = (Action)Delegate.Remove(oWwHdzkYNqutnOHHdoEhlCPIIuP, value);
			}
		}

		[CustomObfuscation(rename = false)]
		internal static event Action<bool> ApplicationIsFullScreenChangedEvent
		{
			add
			{
				jmtxJyXAsHNbocMITyjArPDiGgHK = (Action<bool>)Delegate.Combine(jmtxJyXAsHNbocMITyjArPDiGgHK, value);
			}
			remove
			{
				jmtxJyXAsHNbocMITyjArPDiGgHK = (Action<bool>)Delegate.Remove(jmtxJyXAsHNbocMITyjArPDiGgHK, value);
			}
		}

		[CustomObfuscation(rename = false)]
		internal static event Action<bool> ApplicationRunInBackgroundChangedEvent
		{
			add
			{
				MkBQpFtstCbcIfYbaALaBVuhQrKp = (Action<bool>)Delegate.Combine(MkBQpFtstCbcIfYbaALaBVuhQrKp, value);
			}
			remove
			{
				MkBQpFtstCbcIfYbaALaBVuhQrKp = (Action<bool>)Delegate.Remove(MkBQpFtstCbcIfYbaALaBVuhQrKp, value);
			}
		}

		[CustomObfuscation(rename = false)]
		internal static event Action<bool> TimeScalePauseChangedEvent
		{
			add
			{
				XDPWeaJzgqMwVayHYRvDdPAGoRY = (Action<bool>)Delegate.Combine(XDPWeaJzgqMwVayHYRvDdPAGoRY, value);
			}
			remove
			{
				XDPWeaJzgqMwVayHYRvDdPAGoRY = (Action<bool>)Delegate.Remove(XDPWeaJzgqMwVayHYRvDdPAGoRY, value);
			}
		}

		[CustomObfuscation(rename = false)]
		internal static event Action<FullScreenMode> ApplicationFullScreenModeChangedEvent
		{
			add
			{
				HBXFOsdcOKqCAfJlsjrpUaWnnYeY = (Action<FullScreenMode>)Delegate.Combine(HBXFOsdcOKqCAfJlsjrpUaWnnYeY, value);
			}
			remove
			{
				HBXFOsdcOKqCAfJlsjrpUaWnnYeY = (Action<FullScreenMode>)Delegate.Remove(HBXFOsdcOKqCAfJlsjrpUaWnnYeY, value);
			}
		}

		[CustomObfuscation(rename = false)]
		internal static event Action SceneLoadedEvent
		{
			add
			{
				prHfhcFoddIUMsJEZtIfPlAYWdLD = (Action)Delegate.Combine(prHfhcFoddIUMsJEZtIfPlAYWdLD, value);
			}
			remove
			{
				prHfhcFoddIUMsJEZtIfPlAYWdLD = (Action)Delegate.Remove(prHfhcFoddIUMsJEZtIfPlAYWdLD, value);
			}
		}

		[CustomObfuscation(rename = false)]
		internal static event Action<bool> EditorPauseChangedEvent
		{
			add
			{
				ImxPflkaciKBuzBFDSHdSkUGpBs = (Action<bool>)Delegate.Combine(ImxPflkaciKBuzBFDSHdSkUGpBs, value);
			}
			remove
			{
				ImxPflkaciKBuzBFDSHdSkUGpBs = (Action<bool>)Delegate.Remove(ImxPflkaciKBuzBFDSHdSkUGpBs, value);
			}
		}

		static ReInput()
		{
			naudnRIfsEkdsbBZUTmSqiALBkv = true;
			LPNbaBGJFAONKKCfzJNHCkavuHJf = -1;
			_id = -1;
			nJVXstkBqURfKgMkyCEmSAivMdF = 0;
			dvHVdZWfSpoWqWKQETGCxTNIDqR = UnityTouch.Instance;
			ZbgdevbwZINThCMbnrJpecOWWEcf = PlayerHelper.Instance;
			HxhodIwCilHFNIWyGBcCfynKYdIG = ControllerHelper.Instance;
			fehhyuOhLBkOegIfvSlKGoXKbAOa = MappingHelper.Instance;
			taheheFhpZyCgpxAxCtdBUNoEkCC = TimeHelper.Instance;
			ebxLCnzXBYJMzJHkFjgNxVUptmu = ConfigHelper.Instance;
			bGaxUCCrdNJDGxbNgwWlkgnVIPP = new SafeAction<ControllerStatusChangedEventArgs>(delegate(Exception P_0)
			{
				HandleCallbackException("Rewired.ReInput.ControllerConnectedEvent", P_0);
			});
			GXWgmgKuhczIhTmKnUdTVtIsdwz = new SafeAction<ControllerStatusChangedEventArgs>(delegate(Exception P_0)
			{
				HandleCallbackException("Rewired.ReInput.ControllerPreDisconnectEvent", P_0);
			});
			YdZehWzFPwcXIXTEkpfcQKPRaHp = new SafeAction<ControllerStatusChangedEventArgs>(delegate(Exception P_0)
			{
				HandleCallbackException("Rewired.ReInput.ControllerDisconnectedEvent", P_0);
			});
			OzIXwsUkOqbKUhMpEKRhEetjcIdH = new SafeAction(delegate(Exception P_0)
			{
				HandleCallbackException("Rewired.ReInput.InputSourceUpdateEvent", P_0);
			});
			WVGNwxhOBFqhXhZaMjgunyzlKqr = new SafeAction(delegate(Exception P_0)
			{
				HandleCallbackException("Rewired.ReInput.EditorRecompileEvent", P_0);
			});
			AmHxuSqizUEjnXcNPQqIRCINKyW = new SafeAction(delegate(Exception P_0)
			{
				HandleCallbackException("Rewired.ReInput.PreShutDownEvent", P_0);
			});
			EfcIkYSFAlTHIywPdDqQJewwjll = new SafeAction(delegate(Exception P_0)
			{
				HandleCallbackException("Rewired.ReInput.ShutDownEvent", P_0);
			});
			gUIiCVppIHpbLsJmhhLjcJCVnfMF = new SafeAction(delegate(Exception P_0)
			{
				HandleCallbackException("Rewired.ReInput.InitializedEvent", P_0);
			});
			SafeDelegate.S_ExceptionHandler = delegate(Exception P_0)
			{
				HandleCallbackException("", P_0);
			};
		}

		public static void Reset()
		{
			if (vqjuhdYKKuBgDKqCJHOYrBTbbEX && !(AdpjYGRLHiVIDWJZGBdZJhLTsHYd == null))
			{
				AdpjYGRLHiVIDWJZGBdZJhLTsHYd.ResetAll();
			}
		}

		[CustomObfuscation(rename = false)]
		internal static bool IsInputAllowed(ControllerType controllerType)
		{
			if (!inputAllowed)
			{
				return false;
			}
			if (lpKROTnUkBsRgnUVlurlFnkpNIn != 0 && (controllerType == ControllerType.Keyboard || controllerType == ControllerType.Mouse))
			{
				if (MvrxkTZPKNoHjnecWuqeluBxGsi)
				{
					if (!XhfUNdIHEJxTPmfAWhXgTZWtcPF.HMvlQnzqXxdfzjOdwdzDAfVOcG.value)
					{
						return false;
					}
				}
				else
				{
					if (!isAllowedEditorWindowFocused)
					{
						return false;
					}
					if (controllerType == ControllerType.Mouse && !isUnityEditorFocused)
					{
						return false;
					}
				}
			}
			return true;
		}

		internal static void ijQPrfbohIDtyfCSvLMVhrlmSpB(InputManager_Base P_0, Func<ConfigVars, object> P_1, ConfigVars P_2, ControllerDataFiles P_3, UserData P_4)
		{
			try
			{
				_id = nJVXstkBqURfKgMkyCEmSAivMdF;
				nJVXstkBqURfKgMkyCEmSAivMdF++;
				vqjuhdYKKuBgDKqCJHOYrBTbbEX = true;
				yXeDwQdSiSrAdHseoslxkawKdVLG = true;
				TRglUNiFhQgfjdZRfIECAiYSOsjj = UnityTools.isEditor && !Application.isPlaying;
				if (UnityTools.isEditor)
				{
					CheckRewiredVersionCompatibility();
				}
				AdpjYGRLHiVIDWJZGBdZJhLTsHYd = P_0;
				HehCWeotwUMdbOxHQPtFQrTEOmz = P_2;
				nclCooBBSIHvMgETCcQliiIhqrLp = UnityTools.platform;
				DLLPKIBfqPmGcNCmZVKwRhKVqqz = UnityTools.webplayerPlatform;
				lpKROTnUkBsRgnUVlurlFnkpNIn = UnityTools.editorPlatform;
				if (P_2.logToScreen)
				{
					Logger.logToScreen = true;
				}
				UnityTools.externalTools.EditorPausedStateChangedEvent += zPmLdxdQdUQzPQvNpjBloVNxlLi;
				ytlEooerRTdysEAPDtAKhGdaWSGa = P_3;
				hxqbdqzxiQgQaiRpIPHaudXzLll = P_4;
				P_4.ijQPrfbohIDtyfCSvLMVhrlmSpB();
				ThreadSafeUnityInput.Initialize();
				XhfUNdIHEJxTPmfAWhXgTZWtcPF = new VRCvcBTFbvrMaAwvQTpJxuZpEHa();
				XhfUNdIHEJxTPmfAWhXgTZWtcPF.HMvlQnzqXxdfzjOdwdzDAfVOcG.Set(naudnRIfsEkdsbBZUTmSqiALBkv);
				XhfUNdIHEJxTPmfAWhXgTZWtcPF.HMvlQnzqXxdfzjOdwdzDAfVOcG.Use();
				if (lpKROTnUkBsRgnUVlurlFnkpNIn != 0)
				{
					XhfUNdIHEJxTPmfAWhXgTZWtcPF.HMvlQnzqXxdfzjOdwdzDAfVOcG.getValueDelegate = () => isUnityEditorFocused && isAllowedEditorWindowFocused;
					if (TRglUNiFhQgfjdZRfIECAiYSOsjj)
					{
						naudnRIfsEkdsbBZUTmSqiALBkv = isEditorGameViewFocused;
					}
					XhfUNdIHEJxTPmfAWhXgTZWtcPF.HMvlQnzqXxdfzjOdwdzDAfVOcG.Set(isUnityEditorFocused && isAllowedEditorWindowFocused);
				}
				AVvqopjklwJvluFGEFrGAzJIQdP();
				OQZywUdvSrhokhmhpvyofsetAAc = new TimerAbs(1.0);
				LyNclYHYHXKFxZgnbiNEISkbAkYE = new uLLVkeYyPzsBcHIMbAchcIFgPOMw();
				JMuXpWpQiLkIxUAZdUFVuojWHoRh(P_1);
				JLezATTKNEMVFfHVAgRNIpvVfYV = new kLMNgAaaWPjwLSfBhKqJsCvkZws(P_4.GetActions_Copy());
				CoyPNJHWMheFytmTMQdqyctMRFl = new uhjoXbTonsTOuVJOQAQlbMAgzIYW(P_2, NIbjgVXnyQjOQkqfXoodfUsgkUI);
				kRIMscNTqYOjJDgtnNDWfmLNvzj = new IgaBaIZucbxpplxyQFPTbarjdUW(P_2);
				NIbjgVXnyQjOQkqfXoodfUsgkUI.DeviceConnectedEvent += ztqErKDZrqvFjUEMMpxFaUfiAcNK;
				NIbjgVXnyQjOQkqfXoodfUsgkUI.DeviceDisconnectedEvent += UmnAyzGSGkTrJktBIzjAsNUxEAC;
				NIbjgVXnyQjOQkqfXoodfUsgkUI.UpdateControllerInfoEvent += WncDSNUvZrxakywRfrDiDrDQPNb;
				CoyPNJHWMheFytmTMQdqyctMRFl.bpcdexfyaquuCBGdoCpSVMUiQgQi += zroHmsmzVvwwOmtcHwKmtuHSPEE;
				CoyPNJHWMheFytmTMQdqyctMRFl.xVuJfHacqKOiraKRiMMvWvLiSIl += kRIMscNTqYOjJDgtnNDWfmLNvzj.dtXEdAqZRgEMhsrbkILgSLkCBYHB;
				ThreadSafeUnityInput.PostInitialize();
				ojMYjWaxRYOnrKqOvposjOOGboSE();
				ThreadSafeUnityInput.PostInitialize2();
				GobdtmbruEJNYCIxWnhBgZLINlvg = UnityTools.GetComponent<UserDataStore>(AdpjYGRLHiVIDWJZGBdZJhLTsHYd);
				if (GobdtmbruEJNYCIxWnhBgZLINlvg != null)
				{
					GobdtmbruEJNYCIxWnhBgZLINlvg.Initialize();
				}
				jCGhtwQCnUkjgUqyEBlwoTCGgGt();
				yXeDwQdSiSrAdHseoslxkawKdVLG = false;
				if (TRglUNiFhQgfjdZRfIECAiYSOsjj)
				{
					Logger.Log("Rewired is running in Edit mode.");
				}
				if (gUIiCVppIHpbLsJmhhLjcJCVnfMF != null)
				{
					gUIiCVppIHpbLsJmhhLjcJCVnfMF.Invoke();
				}
			}
			catch (Exception)
			{
				vqjuhdYKKuBgDKqCJHOYrBTbbEX = false;
				yXeDwQdSiSrAdHseoslxkawKdVLG = false;
				throw;
			}
		}

		internal static void tvCBgIPnqjaOIPTXBTydmcrRbzF()
		{
			if (LyNclYHYHXKFxZgnbiNEISkbAkYE != null)
			{
				LyNclYHYHXKFxZgnbiNEISkbAkYE.gKgciFGmJUDriAduDqYflaCIeoeQ();
			}
			if (configVars.deferControllerConnectedEventsOnStart)
			{
				for (int i = 0; i < CoyPNJHWMheFytmTMQdqyctMRFl.XIizDAIvfXWSeeEunnkOyCetKzC; i++)
				{
					Joystick joystick = CoyPNJHWMheFytmTMQdqyctMRFl.QuGhzrzWRShGlIBQnTYoDJgwRuJ[i];
					CneeWPoezBrvqVGKzHSfoABHCeU(new ControllerStatusChangedEventArgs(joystick.name, joystick.id, joystick.type));
				}
			}
		}

		internal static void WyhLRkOPKWHpFKDIzikMFaCAcXhY(UpdateLoopType P_0)
		{
			if (vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				sgQAVBZQKPyBMRDpDdNBGqxrnQDw(P_0);
				switch (P_0)
				{
				case UpdateLoopType.Update:
				case UpdateLoopType.FixedUpdate:
					KzMFzwdFnDcjzBtWlQVXsWAeqEZ();
					break;
				}
			}
		}

		private static void sgQAVBZQKPyBMRDpDdNBGqxrnQDw(UpdateLoopType P_0)
		{
			if (XhfUNdIHEJxTPmfAWhXgTZWtcPF != null)
			{
				XhfUNdIHEJxTPmfAWhXgTZWtcPF.mtiNfGzpXHszOwiOIAVYQuMZclV();
			}
			Action<UpdateLoopType> ymYjSfvfHUEgzEQianjULpiixOyi = YmYjSfvfHUEgzEQianjULpiixOyi;
			if (ymYjSfvfHUEgzEQianjULpiixOyi != null)
			{
				try
				{
					ymYjSfvfHUEgzEQianjULpiixOyi(P_0);
				}
				catch (Exception exception)
				{
					HandleCallbackException("ReInput.BeforeTimeManagerUpdateEvent", exception);
				}
			}
			LyNclYHYHXKFxZgnbiNEISkbAkYE.mtiNfGzpXHszOwiOIAVYQuMZclV(P_0);
		}

		private static void KzMFzwdFnDcjzBtWlQVXsWAeqEZ()
		{
			int frameCount = Time.frameCount;
			if (LPNbaBGJFAONKKCfzJNHCkavuHJf == frameCount)
			{
				return;
			}
			LPNbaBGJFAONKKCfzJNHCkavuHJf = frameCount;
			ThreadSafeUnityInput.Update();
			Action rAHpIqsIIkQwMyBhGCpKCVjnLMf = RAHpIqsIIkQwMyBhGCpKCVjnLMf;
			if (rAHpIqsIIkQwMyBhGCpKCVjnLMf == null)
			{
				return;
			}
			try
			{
				rAHpIqsIIkQwMyBhGCpKCVjnLMf();
			}
			catch (Exception exception)
			{
				HandleCallbackException("ReInput.EarlyUpdateEvent", exception);
			}
		}

		internal static void mtiNfGzpXHszOwiOIAVYQuMZclV(UpdateLoopType P_0)
		{
			if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				return;
			}
			if (QeSkCjKHJJFgSnLThoPbfSIQDAd != P_0)
			{
				QeSkCjKHJJFgSnLThoPbfSIQDAd = P_0;
			}
			if (editorPlatform != 0)
			{
				fTWFIAjMJvLbZcIwAMSYPQmwLiRE = XhfUNdIHEJxTPmfAWhXgTZWtcPF.XwsaKELqFHJDbJQBqLkSevGYnpS.value;
			}
			if (rLudkxbsubVXxHRyDDwksYKhBjmv)
			{
				if (OQZywUdvSrhokhmhpvyofsetAAc.Update())
				{
					rLudkxbsubVXxHRyDDwksYKhBjmv = false;
					OQZywUdvSrhokhmhpvyofsetAAc.Clear();
				}
				else
				{
					unityInputBuffer.mtiNfGzpXHszOwiOIAVYQuMZclV(P_0);
				}
			}
			XhfUNdIHEJxTPmfAWhXgTZWtcPF.pVilXFzFXmXaLTpVPEpxMBpKEFnc();
			Action<UpdateLoopType> eWNtLACmKZFsaNRVKTLFAVHBEiZ = EWNtLACmKZFsaNRVKTLFAVHBEiZ;
			if (eWNtLACmKZFsaNRVKTLFAVHBEiZ != null)
			{
				try
				{
					eWNtLACmKZFsaNRVKTLFAVHBEiZ(P_0);
				}
				catch (Exception exception)
				{
					HandleCallbackException("ReInput.UpdateStartedEvent", exception);
				}
			}
			NIbjgVXnyQjOQkqfXoodfUsgkUI.Update(P_0);
			if (OzIXwsUkOqbKUhMpEKRhEetjcIdH != null)
			{
				OzIXwsUkOqbKUhMpEKRhEetjcIdH.Invoke();
			}
			CoyPNJHWMheFytmTMQdqyctMRFl.mtiNfGzpXHszOwiOIAVYQuMZclV(P_0);
			Action<UpdateLoopType> aLKQKUZJadldOleZoIhfQRGRyHn = ALKQKUZJadldOleZoIhfQRGRyHn;
			if (aLKQKUZJadldOleZoIhfQRGRyHn == null)
			{
				return;
			}
			try
			{
				aLKQKUZJadldOleZoIhfQRGRyHn(P_0);
			}
			catch (Exception exception2)
			{
				HandleCallbackException("ReInput.UpdateEndedEvent", exception2);
			}
		}

		internal static void qPwLLCyhkvfVmGokgUWJFwygMHJ()
		{
			Action action = oWwHdzkYNqutnOHHdoEhlCPIIuP;
			if (action != null)
			{
				try
				{
					action();
				}
				catch (Exception exception)
				{
					HandleCallbackException("ReInput.LateUpdateEvent", exception);
				}
			}
		}

		[CustomObfuscation(rename = false)]
		internal static void EditorUpdate()
		{
			if (vqjuhdYKKuBgDKqCJHOYrBTbbEX && TRglUNiFhQgfjdZRfIECAiYSOsjj)
			{
				WyhLRkOPKWHpFKDIzikMFaCAcXhY(UpdateLoopType.Update);
				mtiNfGzpXHszOwiOIAVYQuMZclV(UpdateLoopType.Update);
				qPwLLCyhkvfVmGokgUWJFwygMHJ();
			}
		}

		internal static void WbYCFyWLioAJIjMgDknxRpSBjqYP()
		{
			if (AmHxuSqizUEjnXcNPQqIRCINKyW != null)
			{
				AmHxuSqizUEjnXcNPQqIRCINKyW.Invoke();
			}
			if (NIbjgVXnyQjOQkqfXoodfUsgkUI != null)
			{
				NIbjgVXnyQjOQkqfXoodfUsgkUI.OnDestroy();
			}
			HjwNLriFjhySrGDVnEedMSPugHX();
			if (EfcIkYSFAlTHIywPdDqQJewwjll != null)
			{
				EfcIkYSFAlTHIywPdDqQJewwjll.Invoke();
				EfcIkYSFAlTHIywPdDqQJewwjll = null;
			}
		}

		internal static void iACXpAjJKACApIQcKaAMCmvlOYh()
		{
			if (WVGNwxhOBFqhXhZaMjgunyzlKqr != null)
			{
				WVGNwxhOBFqhXhZaMjgunyzlKqr.Invoke();
			}
		}

		internal static void sfdoNiMxpAanslBSOdyXiEaUwJGo(bool P_0)
		{
			naudnRIfsEkdsbBZUTmSqiALBkv = P_0;
			if (lpKROTnUkBsRgnUVlurlFnkpNIn == EditorPlatform.None && vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				XhfUNdIHEJxTPmfAWhXgTZWtcPF.HMvlQnzqXxdfzjOdwdzDAfVOcG.Set(P_0);
				XhfUNdIHEJxTPmfAWhXgTZWtcPF.HMvlQnzqXxdfzjOdwdzDAfVOcG.TriggerEvent();
			}
		}

		internal static void wmqGqJagoBFVmFxwCforiQwDPgVh()
		{
			if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				return;
			}
			Action action = prHfhcFoddIUMsJEZtIfPlAYWdLD;
			if (action == null)
			{
				return;
			}
			try
			{
				action();
			}
			catch (Exception exception)
			{
				HandleCallbackException("ReInput.SceneLoadedEvent", exception);
			}
		}

		[CustomObfuscation(rename = false)]
		internal static HardwareJoystickMap_InputManager GetHardwareJoystickMap_InputManager(BridgedControllerHWInfo bridgedController)
		{
			return ytlEooerRTdysEAPDtAKhGdaWSGa.BNncPUNDkYiPJuxzxNfwYgZzxHn(bridgedController);
		}

		internal static HardwareJoystickMap aBicjEfMjycUGLQZRmiDUTZajuJp(Guid P_0)
		{
			return ytlEooerRTdysEAPDtAKhGdaWSGa.GetHardwareJoystickMap(P_0);
		}

		internal static HardwareJoystickTemplateMap wxaUFJksCtJSWyNVQsKBejbBmBq(Guid P_0)
		{
			return ytlEooerRTdysEAPDtAKhGdaWSGa.GetJoystickTemplate(P_0);
		}

		internal static IHardwareControllerTemplateMap HddpMdoDakAZuEyosHjdGbkFaHl(Guid P_0)
		{
			return ytlEooerRTdysEAPDtAKhGdaWSGa.GetControllerTemplate(P_0);
		}

		internal static IList<HardwareJoystickTemplateMap> SqSnCRwBXviNgdaFyBLeBjIkaBXg(Guid P_0)
		{
			HardwareJoystickMap hardwareJoystickMap = ytlEooerRTdysEAPDtAKhGdaWSGa.GetHardwareJoystickMap(P_0);
			if (hardwareJoystickMap == null)
			{
				return EmptyObjects<HardwareJoystickTemplateMap>.EmptyReadOnlyIListT;
			}
			string[] templateGuidsOrig = hardwareJoystickMap.GetTemplateGuidsOrig();
			if (templateGuidsOrig == null || templateGuidsOrig.Length == 0)
			{
				return EmptyObjects<HardwareJoystickTemplateMap>.EmptyReadOnlyIListT;
			}
			List<HardwareJoystickTemplateMap> list = null;
			for (int i = 0; i < templateGuidsOrig.Length; i++)
			{
				Guid guid;
				try
				{
					guid = new Guid(templateGuidsOrig[i]);
				}
				catch
				{
					Logger.LogWarning("Controller Template GUID is invalid: " + templateGuidsOrig[i]);
					continue;
				}
				HardwareJoystickTemplateMap hardwareJoystickTemplateMap = wxaUFJksCtJSWyNVQsKBejbBmBq(guid);
				if (hardwareJoystickTemplateMap == null)
				{
					Logger.LogWarning("Controller Template was not found for GUID " + guid.ToString());
					continue;
				}
				if (list == null)
				{
					list = new List<HardwareJoystickTemplateMap>();
				}
				ListTools.AddIfUnique(list, hardwareJoystickTemplateMap);
			}
			if (list == null)
			{
				return EmptyObjects<HardwareJoystickTemplateMap>.EmptyReadOnlyIListT;
			}
			return list;
		}

		[CustomObfuscation(rename = false)]
		internal static int GetNewJoystickId()
		{
			return CoyPNJHWMheFytmTMQdqyctMRFl.mcRUKUpDpLukICEujUamAUTqcnF();
		}

		[CustomObfuscation(rename = false)]
		internal static void HandleCallbackException(string source, Exception exception)
		{
			string msg = "An exception occurred inside an event handler or callback.\nSource: " + source + "\n\nThis happens if your event handler/callback code throws an exception. This means the error in your code, not Rewired. Read the exception message and the stack trace carefully to find the source of the exception being thrown by your code.\n\nThis can also happen if you forget to unsubscribe to an event in a MonoBehaviour class and that object gets destroyed. Make sure you unsubscribe to events in OnDisable or OnDestroy. Rewired will attempt to continue running.\n\nException:\n" + ((exception.InnerException != null) ? exception.InnerException : exception);
			Logger.LogError(msg, requiredThreadSafety: true);
		}

		[CustomObfuscation(rename = false)]
		internal static void HandleExternException(string source, Exception exception)
		{
		}

		[CustomObfuscation(rename = false)]
		internal static void HandleExternalInterfaceException(string source, Exception exception)
		{
			string msg = "An exception occurred inside an external function call.\nSource: " + source + "\n\nThis happens if the external function throws an exception. This could indicate the error is in your code if Rewired is calling a function in an interface implementation you created. Read the exception message and the stack trace carefully to find the source of the exception being thrown.\n\nThis can also happen if you forget to unsubscribe to an event in a MonoBehaviour class and that object gets destroyed.\n\nException:\n" + ((exception.InnerException != null) ? exception.InnerException : exception);
			Logger.LogError(msg, requiredThreadSafety: true);
		}

		internal static void xsNcGJXrMHAqxvmJhainDJvBMIZk()
		{
			if (vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				jCGhtwQCnUkjgUqyEBlwoTCGgGt();
			}
		}

		[CustomObfuscation(rename = false)]
		internal static void CheckRewiredVersionCompatibility()
		{
			if (UnityTools.unityVersionObj != null && 2021 != UnityTools.unityVersionObj.major)
			{
				gZgobyiqEqaEdRWzPPeNSMcLvLH();
			}
		}

		internal static float ExRgnWaBueNAucLnVbDaADqvVNzc()
		{
			return XhfUNdIHEJxTPmfAWhXgTZWtcPF.pShflJlEalzVlXfYfXFXKdZEKKH.value;
		}

		[CustomObfuscation(rename = false)]
		internal static bool CheckInitialized()
		{
			if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				Logger.LogError("Rewired is not initialized. You must have an active and enabled Rewired Input Manager in the scene before calling any part of the Rewired API.");
				return false;
			}
			return true;
		}

		[CustomObfuscation(rename = false)]
		internal static bool CheckInitialized(int reInputId)
		{
			if (!CheckInitialized())
			{
				return false;
			}
			if (_id != reInputId)
			{
				Logger.LogError("You are attemping to access an object that was created by a previous session or different instance of Rewired and is no longer valid. When Rewired is reset or the Rewired Input Manager is disabled or destroyed, all old object references become invalid and can no longer be used. If you deinitialize Rewired, you cannot use locally stored Rewired objects obtained prior to deinitialization and you must get new objects from the Rewired API.");
				return false;
			}
			return true;
		}

		private static void ojMYjWaxRYOnrKqOvposjOOGboSE()
		{
			kRIMscNTqYOjJDgtnNDWfmLNvzj.ijQPrfbohIDtyfCSvLMVhrlmSpB();
			CoyPNJHWMheFytmTMQdqyctMRFl.ijQPrfbohIDtyfCSvLMVhrlmSpB(NIbjgVXnyQjOQkqfXoodfUsgkUI.GetInputDataUpdateDelegate(), hxqbdqzxiQgQaiRpIPHaudXzLll.GetInputBehaviors_Copy());
			NIbjgVXnyQjOQkqfXoodfUsgkUI.Initialize();
		}

		private static void HjwNLriFjhySrGDVnEedMSPugHX()
		{
			if (AdpjYGRLHiVIDWJZGBdZJhLTsHYd != null)
			{
				List<IExternalInputManager> componentsInSelfAndChildren = UnityTools.GetComponentsInSelfAndChildren<IExternalInputManager>(AdpjYGRLHiVIDWJZGBdZJhLTsHYd);
				for (int i = 0; i < componentsInSelfAndChildren.Count; i++)
				{
					componentsInSelfAndChildren[i].Deinitialize();
				}
			}
			AdpjYGRLHiVIDWJZGBdZJhLTsHYd = null;
			NIbjgVXnyQjOQkqfXoodfUsgkUI = null;
			JLezATTKNEMVFfHVAgRNIpvVfYV = null;
			if (CoyPNJHWMheFytmTMQdqyctMRFl != null)
			{
				CoyPNJHWMheFytmTMQdqyctMRFl.Dispose();
			}
			CoyPNJHWMheFytmTMQdqyctMRFl = null;
			kRIMscNTqYOjJDgtnNDWfmLNvzj = null;
			ytlEooerRTdysEAPDtAKhGdaWSGa = null;
			hxqbdqzxiQgQaiRpIPHaudXzLll = null;
			VYkmIQSoqzGiilkTquOEHSRJNlg = null;
			vqjuhdYKKuBgDKqCJHOYrBTbbEX = false;
			HehCWeotwUMdbOxHQPtFQrTEOmz = null;
			QeSkCjKHJJFgSnLThoPbfSIQDAd = UpdateLoopType.Update;
			xJurUJejHKNQiSCecRomlUYUKdh = false;
			nclCooBBSIHvMgETCcQliiIhqrLp = Platform.Windows;
			DLLPKIBfqPmGcNCmZVKwRhKVqqz = WebplayerPlatform.None;
			lpKROTnUkBsRgnUVlurlFnkpNIn = EditorPlatform.None;
			rLudkxbsubVXxHRyDDwksYKhBjmv = false;
			OQZywUdvSrhokhmhpvyofsetAAc = null;
			LyNclYHYHXKFxZgnbiNEISkbAkYE = null;
			fTWFIAjMJvLbZcIwAMSYPQmwLiRE = null;
			MvrxkTZPKNoHjnecWuqeluBxGsi = false;
			TRglUNiFhQgfjdZRfIECAiYSOsjj = false;
			naudnRIfsEkdsbBZUTmSqiALBkv = true;
			LPNbaBGJFAONKKCfzJNHCkavuHJf = -1;
			_id = -1;
			BLLLlyOjXPHkCWLrqiONTYYDkDp = 0;
			bGaxUCCrdNJDGxbNgwWlkgnVIPP.Clear();
			GXWgmgKuhczIhTmKnUdTVtIsdwz.Clear();
			YdZehWzFPwcXIXTEkpfcQKPRaHp.Clear();
			OzIXwsUkOqbKUhMpEKRhEetjcIdH.Clear();
			WVGNwxhOBFqhXhZaMjgunyzlKqr.Clear();
			_ApplicationFocusChangedEvent = null;
			jmtxJyXAsHNbocMITyjArPDiGgHK = null;
			MkBQpFtstCbcIfYbaALaBVuhQrKp = null;
			HBXFOsdcOKqCAfJlsjrpUaWnnYeY = null;
			XDPWeaJzgqMwVayHYRvDdPAGoRY = null;
			RAHpIqsIIkQwMyBhGCpKCVjnLMf = null;
			EWNtLACmKZFsaNRVKTLFAVHBEiZ = null;
			ALKQKUZJadldOleZoIhfQRGRyHn = null;
			oWwHdzkYNqutnOHHdoEhlCPIIuP = null;
			AmHxuSqizUEjnXcNPQqIRCINKyW = null;
			prHfhcFoddIUMsJEZtIfPlAYWdLD = null;
			ImxPflkaciKBuzBFDSHdSkUGpBs = null;
			HktSoPXaQiaYNbuvEoiCcknNQQVj();
			XhfUNdIHEJxTPmfAWhXgTZWtcPF = null;
			ThreadSafeUnityInput.Deinitialize();
			if (UnityTools.externalTools != null)
			{
				UnityTools.externalTools.EditorPausedStateChangedEvent -= zPmLdxdQdUQzPQvNpjBloVNxlLi;
			}
		}

		private static void RydcLWJerEZPPcdtYshtlUYGSSH(string P_0 = null)
		{
			string text = ((P_0 == null) ? "This function" : P_0);
			Logger.LogError(text + " can only be called in Play mode!");
		}

		private static void sdrkavHBBWrEWmQUnluniKthCLc()
		{
			if (!rLudkxbsubVXxHRyDDwksYKhBjmv)
			{
				rLudkxbsubVXxHRyDDwksYKhBjmv = true;
				unityInputBuffer.LlCkzvOeJVaCziTDPktzBWuYotAZ();
				unityInputBuffer.brtDRRhixkprTggVKNatDRbDZZMJ();
			}
			OQZywUdvSrhokhmhpvyofsetAAc.Start();
		}

		private static void IRZGSkWsFxwQwgDqGrxCgkUucgM()
		{
			Logger.LogError("Rewired is not initialized. Do you have a Rewired Input Manager in the scene and enabled?");
		}

		private static void ztqErKDZrqvFjUEMMpxFaUfiAcNK(BridgedController P_0)
		{
			if (P_0.sourceJoystick == null)
			{
				return;
			}
			CoyPNJHWMheFytmTMQdqyctMRFl.gCoNsxqDpuRmajGZvsULzeogvfc(P_0);
			Joystick joystick = CoyPNJHWMheFytmTMQdqyctMRFl.zivwXGnUcYgxVcgorNBReCMkWkS(P_0.sourceJoystick.rewiredId);
			if (joystick != null)
			{
				kRIMscNTqYOjJDgtnNDWfmLNvzj.aZWbkiBOxODPcIADgntnipJaMwue(joystick);
				if (!configVars.deferControllerConnectedEventsOnStart || !yXeDwQdSiSrAdHseoslxkawKdVLG)
				{
					CneeWPoezBrvqVGKzHSfoABHCeU(new ControllerStatusChangedEventArgs(joystick.name, joystick.id, joystick.type));
				}
			}
		}

		private static void UmnAyzGSGkTrJktBIzjAsNUxEAC(ControllerDisconnectedEventArgs P_0)
		{
			if (P_0 != null)
			{
				Joystick joystick = CoyPNJHWMheFytmTMQdqyctMRFl.zivwXGnUcYgxVcgorNBReCMkWkS(P_0.rewiredId);
				if (joystick != null)
				{
					CoyPNJHWMheFytmTMQdqyctMRFl.QiXeGqGvYOUhnCNpZvNxFPcHbNU(P_0.rewiredId);
					qRXnkNGDCojiAFzAGrbuQkWxbBaV(new ControllerStatusChangedEventArgs(joystick.name, joystick.id, joystick.type));
				}
			}
		}

		private static void CneeWPoezBrvqVGKzHSfoABHCeU(ControllerStatusChangedEventArgs P_0)
		{
			if (bGaxUCCrdNJDGxbNgwWlkgnVIPP != null)
			{
				bGaxUCCrdNJDGxbNgwWlkgnVIPP.Invoke(P_0);
			}
		}

		private static void zroHmsmzVvwwOmtcHwKmtuHSPEE(ControllerStatusChangedEventArgs P_0)
		{
			if (GXWgmgKuhczIhTmKnUdTVtIsdwz != null)
			{
				GXWgmgKuhczIhTmKnUdTVtIsdwz.Invoke(P_0);
			}
		}

		private static void qRXnkNGDCojiAFzAGrbuQkWxbBaV(ControllerStatusChangedEventArgs P_0)
		{
			if (YdZehWzFPwcXIXTEkpfcQKPRaHp != null)
			{
				YdZehWzFPwcXIXTEkpfcQKPRaHp.Invoke(P_0);
			}
		}

		private static void WncDSNUvZrxakywRfrDiDrDQPNb(UpdateControllerInfoEventArgs P_0)
		{
			CoyPNJHWMheFytmTMQdqyctMRFl.gVpzkMvUGUNFyPhRiDiKdeXjeud(P_0);
		}

		private static void gaVcyOUkQcFnMOoDshSRsfGlDmS(bool P_0)
		{
			if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				return;
			}
			Action<bool> applicationFocusChangedEvent = _ApplicationFocusChangedEvent;
			if (applicationFocusChangedEvent == null)
			{
				return;
			}
			try
			{
				applicationFocusChangedEvent(P_0);
			}
			catch (Exception exception)
			{
				HandleCallbackException("ReInput.ApplicationFocusChangedEvent", exception);
			}
		}

		private static void rijpwBGmcqNUnpBEszMPHTYYnXZ(bool P_0)
		{
			Action<bool> action = jmtxJyXAsHNbocMITyjArPDiGgHK;
			if (action != null)
			{
				try
				{
					action(P_0);
				}
				catch (Exception exception)
				{
					HandleCallbackException("ReInput.ApplicationIsFullScreenChangedEvent", exception);
				}
			}
		}

		private static void dEDwTUhHBKtAPLEiSftcQnAVcMU(int P_0)
		{
			if (HBXFOsdcOKqCAfJlsjrpUaWnnYeY != null)
			{
				try
				{
					HBXFOsdcOKqCAfJlsjrpUaWnnYeY((FullScreenMode)P_0);
				}
				catch (Exception exception)
				{
					HandleCallbackException("ReInput.ApplicationFullScreenModeChangedEvent", exception);
				}
			}
		}

		private static void tGifyhhVHYFzMZxMHggCfilPdAwh(bool P_0)
		{
			Action<bool> mkBQpFtstCbcIfYbaALaBVuhQrKp = MkBQpFtstCbcIfYbaALaBVuhQrKp;
			if (mkBQpFtstCbcIfYbaALaBVuhQrKp != null)
			{
				try
				{
					mkBQpFtstCbcIfYbaALaBVuhQrKp(P_0);
				}
				catch (Exception exception)
				{
					HandleCallbackException("ReInput.ApplicationRunInBackgroundChangedEvent", exception);
				}
			}
		}

		private static void HmlDrquWoGIxmqmbWmcEfAEFBVZ(bool P_0)
		{
			BLLLlyOjXPHkCWLrqiONTYYDkDp++;
			Action<bool> xDPWeaJzgqMwVayHYRvDdPAGoRY = XDPWeaJzgqMwVayHYRvDdPAGoRY;
			if (xDPWeaJzgqMwVayHYRvDdPAGoRY != null)
			{
				try
				{
					xDPWeaJzgqMwVayHYRvDdPAGoRY(P_0);
				}
				catch (Exception exception)
				{
					HandleCallbackException("ReInput.TimeScalePauseChangedEvent", exception);
				}
			}
		}

		private static void AVvqopjklwJvluFGEFrGAzJIQdP()
		{
			if (XhfUNdIHEJxTPmfAWhXgTZWtcPF != null)
			{
				HktSoPXaQiaYNbuvEoiCcknNQQVj();
				XhfUNdIHEJxTPmfAWhXgTZWtcPF.HMvlQnzqXxdfzjOdwdzDAfVOcG.ChangedEvent += gaVcyOUkQcFnMOoDshSRsfGlDmS;
				XhfUNdIHEJxTPmfAWhXgTZWtcPF.RQodkTEXhVLxRjGVfqViuoyJJay.ChangedEvent += rijpwBGmcqNUnpBEszMPHTYYnXZ;
				XhfUNdIHEJxTPmfAWhXgTZWtcPF.kdWCnSsBpsgkryWtwBzbBCFFTtH.ChangedEvent += tGifyhhVHYFzMZxMHggCfilPdAwh;
				XhfUNdIHEJxTPmfAWhXgTZWtcPF.qdsbfKLkMIHclELvehRmvmaFZbX.ChangedEvent += dEDwTUhHBKtAPLEiSftcQnAVcMU;
				XhfUNdIHEJxTPmfAWhXgTZWtcPF.jDCxGNnaIZEWOGiRqYmgsrtvMYz.ChangedEvent += HmlDrquWoGIxmqmbWmcEfAEFBVZ;
			}
		}

		private static void HktSoPXaQiaYNbuvEoiCcknNQQVj()
		{
			if (XhfUNdIHEJxTPmfAWhXgTZWtcPF != null)
			{
				XhfUNdIHEJxTPmfAWhXgTZWtcPF.HMvlQnzqXxdfzjOdwdzDAfVOcG.ChangedEvent -= gaVcyOUkQcFnMOoDshSRsfGlDmS;
				XhfUNdIHEJxTPmfAWhXgTZWtcPF.RQodkTEXhVLxRjGVfqViuoyJJay.ChangedEvent -= rijpwBGmcqNUnpBEszMPHTYYnXZ;
				XhfUNdIHEJxTPmfAWhXgTZWtcPF.kdWCnSsBpsgkryWtwBzbBCFFTtH.ChangedEvent -= tGifyhhVHYFzMZxMHggCfilPdAwh;
				XhfUNdIHEJxTPmfAWhXgTZWtcPF.qdsbfKLkMIHclELvehRmvmaFZbX.ChangedEvent -= dEDwTUhHBKtAPLEiSftcQnAVcMU;
				XhfUNdIHEJxTPmfAWhXgTZWtcPF.jDCxGNnaIZEWOGiRqYmgsrtvMYz.ChangedEvent -= HmlDrquWoGIxmqmbWmcEfAEFBVZ;
			}
		}

		private static void zPmLdxdQdUQzPQvNpjBloVNxlLi(bool P_0)
		{
			Action<bool> imxPflkaciKBuzBFDSHdSkUGpBs = ImxPflkaciKBuzBFDSHdSkUGpBs;
			if (imxPflkaciKBuzBFDSHdSkUGpBs != null)
			{
				try
				{
					imxPflkaciKBuzBFDSHdSkUGpBs(P_0);
				}
				catch (Exception exception)
				{
					HandleCallbackException("ReInput.EditorPauseChangedEvent", exception);
				}
			}
		}

		private static void JMuXpWpQiLkIxUAZdUFVuojWHoRh(Func<ConfigVars, object> P_0)
		{
			bool flag = configVars.DoesPlatformUseFallback(UnityTools.platform, UnityTools.webplayerPlatform, isEditor);
			if (!flag)
			{
				List<IExternalInputManager> componentsInSelfAndChildren = UnityTools.GetComponentsInSelfAndChildren<IExternalInputManager>(AdpjYGRLHiVIDWJZGBdZJhLTsHYd);
				for (int i = 0; i < componentsInSelfAndChildren.Count; i++)
				{
					if (componentsInSelfAndChildren[i].Initialize(UnityTools.platform, HehCWeotwUMdbOxHQPtFQrTEOmz) is PlatformInputManager nIbjgVXnyQjOQkqfXoodfUsgkUI)
					{
						NIbjgVXnyQjOQkqfXoodfUsgkUI = nIbjgVXnyQjOQkqfXoodfUsgkUI;
						return;
					}
				}
			}
			if (flag)
			{
				xJurUJejHKNQiSCecRomlUYUKdh = true;
				NIbjgVXnyQjOQkqfXoodfUsgkUI = new SixoesdehMBTLhdCUzhvkfIAMwel(HehCWeotwUMdbOxHQPtFQrTEOmz.updateLoop);
			}
			else if (configVars.DoesPlatformUseSDL2(UnityTools.platform, UnityTools.webplayerPlatform, isEditor))
			{
				try
				{
					NIbjgVXnyQjOQkqfXoodfUsgkUI = new lfWAkuOTJbfALchOQejzQHLPmoS(HehCWeotwUMdbOxHQPtFQrTEOmz, GetHardwareJoystickMap_InputManager, GetNewJoystickId, handleJoysticks: true, handleUnifiedMouse: false, handleUnifiedKeyboard: false);
					if (NIbjgVXnyQjOQkqfXoodfUsgkUI == null)
					{
						throw new Exception();
					}
				}
				catch
				{
					Logger.LogError("SDL2 could not be initialized! Make sure you have the SDL2 library installed. Please see the documentation for more information. Rewired will fall back to Unity input. Certain features may not be available.");
					NIbjgVXnyQjOQkqfXoodfUsgkUI = null;
				}
			}
			else if (UnityTools.platform == Platform.Windows || UnityTools.platform == Platform.WindowsAppStore || UnityTools.platform == Platform.WindowsUWP || UnityTools.platform == Platform.OSX || UnityTools.platform == Platform.Linux)
			{
				NIbjgVXnyQjOQkqfXoodfUsgkUI = P_0(HehCWeotwUMdbOxHQPtFQrTEOmz) as PlatformInputManager;
			}
			else if (UnityTools.platform == Platform.WebGL && !isEditor)
			{
				try
				{
					NIbjgVXnyQjOQkqfXoodfUsgkUI = P_0(HehCWeotwUMdbOxHQPtFQrTEOmz) as PlatformInputManager;
					if (NIbjgVXnyQjOQkqfXoodfUsgkUI == null)
					{
						throw new Exception();
					}
				}
				catch
				{
					Logger.LogError("WebGL platform could not be initialized! Is the Rewired WebGL library installed? See the documentation for more information.");
					NIbjgVXnyQjOQkqfXoodfUsgkUI = null;
				}
			}
			else if (UnityTools.platform == Platform.XboxOne && !isEditor)
			{
				try
				{
					XboxOneInputSource customInputSource = new XboxOneInputSource();
					NIbjgVXnyQjOQkqfXoodfUsgkUI = new CustomInputManager(customInputSource, HehCWeotwUMdbOxHQPtFQrTEOmz.updateLoop, GetHardwareJoystickMap_InputManager, GetNewJoystickId);
					if (NIbjgVXnyQjOQkqfXoodfUsgkUI == null)
					{
						throw new Exception();
					}
				}
				catch
				{
					Logger.LogError("Xbox One platform could not be initialized! Is the Rewired Xbox One library installed? See the documentation for more information.");
					NIbjgVXnyQjOQkqfXoodfUsgkUI = null;
				}
			}
			else if (UnityTools.platform == Platform.PS4 && !isEditor)
			{
				try
				{
					PS4InputSource customInputSource2 = new PS4InputSource();
					NIbjgVXnyQjOQkqfXoodfUsgkUI = new CustomInputManager(customInputSource2, HehCWeotwUMdbOxHQPtFQrTEOmz.updateLoop, GetHardwareJoystickMap_InputManager, GetNewJoystickId);
					if (NIbjgVXnyQjOQkqfXoodfUsgkUI == null)
					{
						throw new Exception();
					}
				}
				catch
				{
					Logger.LogError("PS4 platform could not be initialized!");
					NIbjgVXnyQjOQkqfXoodfUsgkUI = null;
				}
			}
			else if (UnityTools.platform == Platform.Stadia && !isEditor)
			{
				try
				{
					NIbjgVXnyQjOQkqfXoodfUsgkUI = P_0(HehCWeotwUMdbOxHQPtFQrTEOmz) as PlatformInputManager;
					if (NIbjgVXnyQjOQkqfXoodfUsgkUI == null)
					{
						throw new Exception("Input Manager was null.");
					}
				}
				catch (Exception msg)
				{
					Logger.LogError("Stadia platform could not be initialized! Is the Rewired Stadia library installed? See the documentation for more information.");
					Logger.LogError(msg);
					NIbjgVXnyQjOQkqfXoodfUsgkUI = null;
				}
			}
			else if ((UnityTools.platform == Platform.GameCoreXboxOne || UnityTools.platform == Platform.GameCoreScarlett) && !isEditor)
			{
				try
				{
					NIbjgVXnyQjOQkqfXoodfUsgkUI = P_0(HehCWeotwUMdbOxHQPtFQrTEOmz) as PlatformInputManager;
					if (NIbjgVXnyQjOQkqfXoodfUsgkUI == null)
					{
						throw new Exception("Input Manager was null.");
					}
				}
				catch (Exception msg2)
				{
					string text = ((UnityTools.platform == Platform.GameCoreXboxOne) ? "Xbox One" : "Xbox Series X");
					Logger.LogError(text + " platform could not be initialized! Is the Rewired " + text + " library installed? See the documentation for more information.");
					Logger.LogError(msg2);
					NIbjgVXnyQjOQkqfXoodfUsgkUI = null;
				}
			}
			else if (UnityTools.platform == Platform.Ouya && !isEditor)
			{
				try
				{
					Type typeInUnityBuildAssembly = ReflectionTools.GetTypeInUnityBuildAssembly("OuyaSDK", ignoreCase: true);
					if ((object)typeInUnityBuildAssembly == null)
					{
						Logger.LogError("OuyaEverywhereSDK was not found! Input may not function. See the documentation for building to the Ouya platform.");
						throw new Exception();
					}
					typeInUnityBuildAssembly = ReflectionTools.GetTypeInUnityBuildAssembly("Rewired.Platforms.Ouya.OuyaInputSource", ignoreCase: true);
					if ((object)typeInUnityBuildAssembly == null)
					{
						Logger.LogError("Required files for Ouya support are missing. Input may not function. Please completely reinstall Rewired.");
						throw new Exception();
					}
					CustomInputSource customInputSource3 = (CustomInputSource)Assembly.GetAssembly(typeInUnityBuildAssembly).CreateInstance(typeInUnityBuildAssembly.FullName, ignoreCase: false);
					NIbjgVXnyQjOQkqfXoodfUsgkUI = new CustomInputManager(customInputSource3, HehCWeotwUMdbOxHQPtFQrTEOmz.updateLoop, GetHardwareJoystickMap_InputManager, GetNewJoystickId);
					if (NIbjgVXnyQjOQkqfXoodfUsgkUI == null)
					{
						throw new Exception();
					}
				}
				catch
				{
					Logger.LogError("Ouya platform could not be initialized! Please see the documentation for required dependencies. Rewired will fall back to Unity input. All features may not be available.");
					NIbjgVXnyQjOQkqfXoodfUsgkUI = null;
				}
			}
			else if (UnityTools.isAndroidPlatform && !isEditor)
			{
				try
				{
					UnityTools.androidFallbackPlatformHelper = P_0(HehCWeotwUMdbOxHQPtFQrTEOmz) as IAndroidFallbackPlatformHelper;
				}
				catch (Exception msg3)
				{
					Logger.LogError(msg3);
				}
			}
			if (NIbjgVXnyQjOQkqfXoodfUsgkUI == null)
			{
				xJurUJejHKNQiSCecRomlUYUKdh = true;
				NIbjgVXnyQjOQkqfXoodfUsgkUI = new SixoesdehMBTLhdCUzhvkfIAMwel(HehCWeotwUMdbOxHQPtFQrTEOmz.updateLoop);
			}
		}

		private static void jCGhtwQCnUkjgUqyEBlwoTCGgGt()
		{
			if (MvrxkTZPKNoHjnecWuqeluBxGsi != HehCWeotwUMdbOxHQPtFQrTEOmz.GetPlatformVar_ignoreInputWhenAppNotInFocus())
			{
				MvrxkTZPKNoHjnecWuqeluBxGsi = !MvrxkTZPKNoHjnecWuqeluBxGsi;
			}
		}

		private static void gZgobyiqEqaEdRWzPPeNSMcLvLH()
		{
			if (!(UnityTools.unityVersionObj == null))
			{
				Logger.LogWarning("The version of Rewired installed (" + programVersion + ") was not designed for Unity " + UnityTools.unityVersionObj.major + ". Please install Rewired for Unity " + UnityTools.unityVersionObj.major + ".\n\nThis warning does not mean that Rewired will not function, but it may not function optimally.\n\nSome different major versions of Unity download Asset Store assets to the same folder location on disk, so if you download an asset in one version of the Unity editor, then open another version of the Unity editor and install the asset without re-downloading it, the wrong asset version will be installed. To fix this, manually re-download Rewired in the Unity Asset Store panel in this version of the Unity Editor, then install it.\n\nIf you are using a beta version of a new major version of Unity, you will have to wait until the release of the final version before a compatible version of Rewired can be uploaded to the Asset Store. When the new version is ready, it will be available through the Unity Asset Store for download as usual.");
			}
		}

		[CompilerGenerated]
		private static void oAKlRQNwkOIHzpPOoVkfKBFcKhN(Exception P_0)
		{
			HandleCallbackException("Rewired.ReInput.ControllerConnectedEvent", P_0);
		}

		[CompilerGenerated]
		private static void ZoGnwBWbOLMDwejCGueQpLvZRaZ(Exception P_0)
		{
			HandleCallbackException("Rewired.ReInput.ControllerPreDisconnectEvent", P_0);
		}

		[CompilerGenerated]
		private static void sBMGDNFbjWHFfRjfOPgkiZDVRGKO(Exception P_0)
		{
			HandleCallbackException("Rewired.ReInput.ControllerDisconnectedEvent", P_0);
		}

		[CompilerGenerated]
		private static void JJGHHTzDDKQFczetCEIAAideJaeK(Exception P_0)
		{
			HandleCallbackException("Rewired.ReInput.InputSourceUpdateEvent", P_0);
		}

		[CompilerGenerated]
		private static void tYaboeJUrNwbBpAGJIPZvEhjaKD(Exception P_0)
		{
			HandleCallbackException("Rewired.ReInput.EditorRecompileEvent", P_0);
		}

		[CompilerGenerated]
		private static void ycgxlORCVepxBMfhOUDZpmtGQG(Exception P_0)
		{
			HandleCallbackException("Rewired.ReInput.PreShutDownEvent", P_0);
		}

		[CompilerGenerated]
		private static void oAnsPulSPnDGyvXZRHpuoORRDfY(Exception P_0)
		{
			HandleCallbackException("Rewired.ReInput.ShutDownEvent", P_0);
		}

		[CompilerGenerated]
		private static void oydCTBgtunniJHdFCJQmVLeKVcnh(Exception P_0)
		{
			HandleCallbackException("Rewired.ReInput.InitializedEvent", P_0);
		}

		[CompilerGenerated]
		private static void gaDQlHsOYLPxzOsklnUmPffGAhV(Exception P_0)
		{
			HandleCallbackException("", P_0);
		}

		[CompilerGenerated]
		private static bool QkklXCLETLKLSqUqWaOPKpuBgWw()
		{
			if (isUnityEditorFocused)
			{
				return isAllowedEditorWindowFocused;
			}
			return false;
		}
	}
}
