using System;
using System.Collections.Generic;
using Rewired.Config;
using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Attributes;
using Rewired.Utils.Classes.Data;

namespace Rewired.Data
{
	[Serializable]
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	public sealed class ConfigVars : IConfigVars_Internal
	{
		private static class TWjfuzhJsVXrWAgPONKVFdMkQfm
		{
			public const string EtMuBRTmVzCBLcuxYRMlwUqRdAzD = "updateLoop";

			public const string LjfhBRJByuDGoCcHpSYXdNEqUoKl = "alwaysUseUnityInput";

			public const string ujoXGWooyDnPremnUgKUXSAvaOa = "windowsStandalonePrimaryInputSource";

			public const string fvkOqkkyhPDtrUaUUEdzHIeACqB = "osx_primaryInputSource";

			public const string oHrudMHsxvJSyIxdTHxAyFAJGnw = "linux_primaryInputSource";

			public const string BOuAHufIchCEBRogmFOcytZZWLzg = "windowsUWP_primaryInputSource";

			public const string MbvRyMQqbInrkrrGLRmDSCCdksQ = "xboxOne_primaryInputSource";

			public const string dIBkKOlmANOefScAMaPZpOFbTTc = "gameCoreXboxOne_primaryInputSource";

			public const string LxqctZayNshflmnBhvGNIEcIsFVM = "gameCoreScarlett_primaryInputSource";

			public const string giMWzQdrcOacIAXjaBZPKNgliho = "ps4_primaryInputSource";

			public const string yZCMUQbBZBWQLKFdoVEfXunJYSZ = "ps5_primaryInputSource";

			public const string dwnJjwYiDOCKFNgfwFlOmSqJzZe = "webGL_primaryInputSource";

			public const string lspCvcUdrxdDPAvZcGfHHsLvmay = "stadia_primaryInputSource";

			public const string LdXZPimsdxoBQLLCVUhfpdyLCsX = "useXInput";

			public const string wjAgqLueNlJQiRNSjhUSSvJdsm = "windowsStandalone_useSteamRawInputControllerWorkaround";

			public const string NGfcmpeMheIkDUVCVKiiAJGTaWzC = "osxStandalone_useEnhancedDeviceSupport";

			public const string hSgSYmJaMlGFqjLJVzKyLYEbJgc = "android_supportUnknownGamepads";

			public const string JLAUPcnUbohgmQshrrzfQNUmVgD = "ps4_assignJoysticksByPS4JoyId";

			public const string zQoERYroDSIXorFiPjWYCfLpVxa = "useSteamControllerSupport";

			public const string BaNPYeVLRUvDsbzWcUjClQpkAfv = "logToScreen";

			public const string eGoSFOMpRZfpMJLVtsunqIkPhTxA = "runInEditMode";

			public const string jNgKEGshgnzmWnFaKKknvIQMKpV = "allowInputInEditorSceneView";

			public const string SnwyTKVIgtHDbHHABWkBACVQUCiE = "maxJoysticksPerPlayer";

			public const string OsxWpAyObpZkMrxOaDBGRUEoCiz = "autoAssignJoysticks";

			public const string IZwLOFgbmkDQHxsbNUQomulWILw = "assignJoysticksToPlayingPlayersOnly";

			public const string vEKoLunRpMKvEoytTTtQQSTywyq = "distributeJoysticksEvenly";

			public const string qUyYtEpHgkrcegdWBjajSzlLJBz = "reassignJoystickToPreviousOwnerOnReconnect";

			public const string IvLYNETFlbSyRUaSGgmqwkcszOR = "defaultJoystickAxis2DDeadZoneType";

			public const string XuwFxfcrOcoNVAQDcPYgZacEunJ = "defaultJoystickAxis2DSensitivityType";

			public const string pYWURczScIrxrvVaIpSZKaJBiWy = "defaultAxisSensitivityType";

			public const string WuNzJcFeeErQbLfiXirITqOFJLG = "force4WayHats";

			public const string KzaUBqerGxFHCJlAchIVbTtfseR = "throttleCalibrationMode";

			public const string MbBHGUWchNkAjvnucmACxHZHLRR = "activateActionButtonsOnNegativeValue";

			public const string OmYEEJTvLFSRNahoBGATRvbgaSBf = "deferControllerConnectedEventsOnStart";

			public const string gNbhTaFTfsMCNgXYQuMfBFcDchFM = "logLevel";

			public const string pXWvPHNCunoXXQKPsaFByLFNwIy = "disableKeyboard";

			public const string hrjYXbAaqAgCPeAUlOTqmvMJHRc = "ignoreInputWhenAppNotInFocus";

			public const string mvAgyZTxfAIogIhleRlULkfbAxm = "useEnhancedDeviceSupport";

			public const string sKPCGKEiDrjOjkLACmYVAiYaeeGF = "useNativeMouse";

			public const string TPzgIAenqcfiqtKvFbJTWiefkkd = "useNativeKeyboard";

			public const string NSVhMFZuqoAepAHGkddVtUShzoc = "joystickRefreshRate";

			public const string rtldfdXOvWVVaYbaXECaOrZDpCF = "assignJoysticksBySystemId";
		}

		[Serializable]
		public class PlatformVars
		{
			public bool disableKeyboard;

			public bool ignoreInputWhenAppNotInFocus = true;
		}

		[Serializable]
		public class PlatformVars_WindowsStandalone : PlatformVars
		{
			public bool useNativeKeyboard = true;

			public int joystickRefreshRate = 240;
		}

		[Serializable]
		public class PlatformVars_WindowsUWP : PlatformVars
		{
			public bool useGamepadAPI = true;

			public bool useHIDAPI = true;
		}

		[Serializable]
		public class PlatformVars_Stadia : PlatformVars
		{
			public bool useNativeKeyboard = true;

			public bool useNativeMouse = true;
		}

		[Serializable]
		public class PlatformVars_GameCoreXboxOne : PlatformVars
		{
			public bool assignJoysticksByUserId;
		}

		[Serializable]
		public class PlatformVars_GameCoreScarlett : PlatformVars
		{
			public bool assignJoysticksByUserId;
		}

		[Serializable]
		public sealed class EditorVars
		{
			public bool exportConsts_useParentClass;

			public string exportConsts_parentClassName = "RewiredConsts";

			public bool exportConsts_useNamespace = true;

			public string exportConsts_namespace = "RewiredConsts";

			public bool exportConsts_actions = true;

			public string exportConsts_actionsClassName = "Action";

			public bool exportConsts_actionsIncludeActionCategory;

			public bool exportConsts_actionsCreateClassesForActionCategories;

			public bool exportConsts_mapCategories = true;

			public string exportConsts_mapCategoriesClassName = "Category";

			public bool exportConsts_layouts = true;

			public string exportConsts_layoutsClassName = "Layout";

			public bool exportConsts_players = true;

			public string exportConsts_playersClassName = "Player";

			public bool exportConsts_inputBehaviors;

			public string exportConsts_inputBehaviorsClassName = "InputBehavior";

			public bool exportConsts_customControllers = true;

			public string exportConsts_customControllersClassName = "CustomController";

			public string exportConsts_customControllersAxesClassName = "Axis";

			public string exportConsts_customControllersButtonsClassName = "Button";

			public bool exportConsts_layoutManagerRuleSets = true;

			public string exportConsts_layoutManagerRuleSetsClassName = "LayoutManagerRuleSet";

			public bool exportConsts_mapEnablerRuleSets = true;

			public string exportConsts_mapEnablerRuleSetsClassName = "MapEnablerRuleSet";

			public bool exportConsts_allCapsConstantNames;
		}

		private class JxemSQTOnhkehGMLYGAYqGVWnJM
		{
			public Func<PlatformVars> ZrMIKVJCcOEHseNKEKaenSBrkIra;

			public string xFQCSeJJxiIYcdhJhKHXIBlFAUse;

			public JxemSQTOnhkehGMLYGAYqGVWnJM(Func<PlatformVars> getDelegate, string dataPath)
			{
				ZrMIKVJCcOEHseNKEKaenSBrkIra = getDelegate;
				xFQCSeJJxiIYcdhJhKHXIBlFAUse = dataPath;
			}
		}

		private class IDjNekQnRFNEngxvOHIbogZTBQf
		{
			public Func<Platform, object> ZrMIKVJCcOEHseNKEKaenSBrkIra;

			public Action<Platform, object> JFnfxNhVwUUtZbWQNbibPwjxwxb;

			public IDjNekQnRFNEngxvOHIbogZTBQf(Func<Platform, object> getDelegate, Action<Platform, object> setDelegate)
			{
				ZrMIKVJCcOEHseNKEKaenSBrkIra = getDelegate;
				JFnfxNhVwUUtZbWQNbibPwjxwxb = setDelegate;
			}
		}

		[CustomObfuscation(rename = false)]
		internal enum AllPlatformVar
		{
			[CustomObfuscation(rename = false)]
			DisableKeyboard = 0,
			[CustomObfuscation(rename = false)]
			IgnoreInputWhenAppNotInFocus = 1
		}

		public UpdateLoopSetting updateLoop = UpdateLoopSetting.Update;

		public bool alwaysUseUnityInput;

		public WindowsStandalonePrimaryInputSource windowsStandalonePrimaryInputSource;

		public OSXStandalonePrimaryInputSource osx_primaryInputSource;

		public LinuxStandalonePrimaryInputSource linux_primaryInputSource;

		public WindowsUWPPrimaryInputSource windowsUWP_primaryInputSource;

		public XboxOnePrimaryInputSource xboxOne_primaryInputSource;

		public GameCoreXboxOnePrimaryInputSource gameCoreXboxOne_primaryInputSource;

		public GameCoreScarlettPrimaryInputSource gameCoreScarlett_primaryInputSource;

		public PS4PrimaryInputSource ps4_primaryInputSource;

		public PS5PrimaryInputSource ps5_primaryInputSource;

		public WebGLPrimaryInputSource webGL_primaryInputSource;

		public StadiaPrimaryInputSource stadia_primaryInputSource;

		public bool useXInput = true;

		public bool useNativeMouse = true;

		public bool useEnhancedDeviceSupport = true;

		public bool windowsStandalone_useSteamRawInputControllerWorkaround;

		public bool osxStandalone_useEnhancedDeviceSupport = true;

		public bool android_supportUnknownGamepads = true;

		public bool ps4_assignJoysticksByPS4JoyId = true;

		public bool useSteamControllerSupport = true;

		public bool logToScreen;

		public bool runInEditMode;

		public bool allowInputInEditorSceneView;

		public PlatformVars_WindowsStandalone platformVars_windowsStandalone;

		public PlatformVars platformVars_linuxStandalone;

		public PlatformVars platformVars_osxStandalone;

		public PlatformVars platformVars_windows8Store;

		public PlatformVars_WindowsUWP platformVars_windowsUWP;

		public PlatformVars platformVars_iOS;

		public PlatformVars platformVars_tvOS;

		public PlatformVars platformVars_android;

		public PlatformVars platformVars_ps3;

		public PlatformVars platformVars_ps4;

		public PlatformVars platformVars_ps5;

		public PlatformVars platformVars_psVita;

		public PlatformVars platformVars_xbox360;

		public PlatformVars platformVars_xboxOne;

		public PlatformVars_GameCoreXboxOne platformVars_gameCoreXboxOne;

		public PlatformVars_GameCoreScarlett platformVars_gameCoreScarlett;

		public PlatformVars platformVars_wii;

		public PlatformVars platformVars_wiiu;

		public PlatformVars platformVars_switch;

		public PlatformVars platformVars_webGL;

		public PlatformVars_Stadia platformVars_stadia;

		[NonSerialized]
		private PlatformVars platformVars_unknown;

		public int maxJoysticksPerPlayer = 1;

		public bool autoAssignJoysticks = true;

		public bool assignJoysticksToPlayingPlayersOnly;

		public bool distributeJoysticksEvenly = true;

		public bool reassignJoystickToPreviousOwnerOnReconnect = true;

		public DeadZone2DType defaultJoystickAxis2DDeadZoneType = DeadZone2DType.Radial;

		public AxisSensitivity2DType defaultJoystickAxis2DSensitivityType;

		public AxisSensitivityType defaultAxisSensitivityType;

		public bool force4WayHats;

		public ThrottleCalibrationMode throttleCalibrationMode;

		public bool activateActionButtonsOnNegativeValue;

		public bool deferControllerConnectedEventsOnStart;

		public LogLevelFlags logLevel = LogLevelFlags.Info | LogLevelFlags.Warning | LogLevelFlags.Error;

		public EditorVars editorSettings;

		private Dictionary<int, JxemSQTOnhkehGMLYGAYqGVWnJM> __platformVarsDict;

		private Dictionary<int, IDjNekQnRFNEngxvOHIbogZTBQf> __getSetPlatformVariableDict;

		private KeyedGetSetValueStore<string> __configVarsValues;

		private Dictionary<string, object> __valueDelegates;

		private Dictionary<int, JxemSQTOnhkehGMLYGAYqGVWnJM> platformVarsDict => __platformVarsDict ?? (__platformVarsDict = new Dictionary<int, JxemSQTOnhkehGMLYGAYqGVWnJM>
		{
			{
				1,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_windowsStandalone), "platformVars_windowsStandalone")
			},
			{
				2,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_windows8Store), "platformVars_windows8Store")
			},
			{
				3,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_windows8Store), "platformVars_windows8Store")
			},
			{
				29,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_windowsUWP), "platformVars_windowsUWP")
			},
			{
				6,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_linuxStandalone), "platformVars_linuxStandalone")
			},
			{
				4,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_osxStandalone), "platformVars_osxStandalone")
			},
			{
				5,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_iOS), "platformVars_iOS")
			},
			{
				28,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_tvOS), "platformVars_tvOS")
			},
			{
				12,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_ps3), "platformVars_ps3")
			},
			{
				13,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_ps4), "platformVars_ps4")
			},
			{
				106,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_ps5), "platformVars_ps5")
			},
			{
				15,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_psVita), "platformVars_psVita")
			},
			{
				14,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_psVita), "platformVars_psVita")
			},
			{
				16,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_wii), "platformVars_wii")
			},
			{
				18,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_wiiu), "platformVars_wiiu")
			},
			{
				32,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_switch), "platformVars_switch")
			},
			{
				10,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_xbox360), "platformVars_xbox360")
			},
			{
				11,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_xboxOne), "platformVars_xboxOne")
			},
			{
				104,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_gameCoreXboxOne), "platformVars_gameCoreXboxOne")
			},
			{
				105,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_gameCoreScarlett), "platformVars_gameCoreScarlett")
			},
			{
				19,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_webGL), "platformVars_webGL")
			},
			{
				103,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_stadia), "platformVars_stadia")
			},
			{
				7,
				new JxemSQTOnhkehGMLYGAYqGVWnJM(() => GetOrCreatePlatformVars(ref platformVars_android), "platformVars_android")
			}
		});

		private Dictionary<int, IDjNekQnRFNEngxvOHIbogZTBQf> getSetPlatformVariableDict => __getSetPlatformVariableDict ?? (__getSetPlatformVariableDict = new Dictionary<int, IDjNekQnRFNEngxvOHIbogZTBQf>
		{
			{
				0,
				new IDjNekQnRFNEngxvOHIbogZTBQf((Platform p) => GetPlatformVars(p).disableKeyboard, delegate(Platform platform, object value)
				{
					GetPlatformVars(platform).disableKeyboard = (bool)value;
				})
			},
			{
				1,
				new IDjNekQnRFNEngxvOHIbogZTBQf((Platform platform) => GetPlatformVars(platform).ignoreInputWhenAppNotInFocus, delegate(Platform platform, object value)
				{
					GetPlatformVars(platform).ignoreInputWhenAppNotInFocus = (bool)value;
				})
			}
		});

		KeyedGetSetValueStore<string> IConfigVars_Internal.values
		{
			get
			{
				if (__configVarsValues == null)
				{
					__configVarsValues = new KeyedGetSetValueStore<string>(valueDelegates, isReadOnlyCollection: true);
				}
				return __configVarsValues;
			}
		}

		private Dictionary<string, object> valueDelegates
		{
			get
			{
				if (__valueDelegates == null)
				{
					__valueDelegates = new Dictionary<string, object>
					{
						{
							"updateLoop",
							new GetSetValue<UpdateLoopSetting>(() => updateLoop, delegate(UpdateLoopSetting x)
							{
								updateLoop = x;
							})
						},
						{
							"alwaysUseUnityInput",
							new GetSetValue<bool>(() => alwaysUseUnityInput, delegate(bool x)
							{
								alwaysUseUnityInput = x;
							})
						},
						{
							"windowsStandalonePrimaryInputSource",
							new GetSetValue<WindowsStandalonePrimaryInputSource>(() => windowsStandalonePrimaryInputSource, delegate(WindowsStandalonePrimaryInputSource x)
							{
								windowsStandalonePrimaryInputSource = x;
							})
						},
						{
							"osx_primaryInputSource",
							new GetSetValue<OSXStandalonePrimaryInputSource>(() => osx_primaryInputSource, delegate(OSXStandalonePrimaryInputSource x)
							{
								osx_primaryInputSource = x;
							})
						},
						{
							"linux_primaryInputSource",
							new GetSetValue<LinuxStandalonePrimaryInputSource>(() => linux_primaryInputSource, delegate(LinuxStandalonePrimaryInputSource x)
							{
								linux_primaryInputSource = x;
							})
						},
						{
							"windowsUWP_primaryInputSource",
							new GetSetValue<WindowsUWPPrimaryInputSource>(() => windowsUWP_primaryInputSource, delegate(WindowsUWPPrimaryInputSource x)
							{
								windowsUWP_primaryInputSource = x;
							})
						},
						{
							"xboxOne_primaryInputSource",
							new GetSetValue<XboxOnePrimaryInputSource>(() => xboxOne_primaryInputSource, delegate(XboxOnePrimaryInputSource x)
							{
								xboxOne_primaryInputSource = x;
							})
						},
						{
							"gameCoreXboxOne_primaryInputSource",
							new GetSetValue<GameCoreXboxOnePrimaryInputSource>(() => gameCoreXboxOne_primaryInputSource, delegate(GameCoreXboxOnePrimaryInputSource x)
							{
								gameCoreXboxOne_primaryInputSource = x;
							})
						},
						{
							"gameCoreScarlett_primaryInputSource",
							new GetSetValue<GameCoreScarlettPrimaryInputSource>(() => gameCoreScarlett_primaryInputSource, delegate(GameCoreScarlettPrimaryInputSource x)
							{
								gameCoreScarlett_primaryInputSource = x;
							})
						},
						{
							"ps4_primaryInputSource",
							new GetSetValue<PS4PrimaryInputSource>(() => ps4_primaryInputSource, delegate(PS4PrimaryInputSource x)
							{
								ps4_primaryInputSource = x;
							})
						},
						{
							"ps5_primaryInputSource",
							new GetSetValue<PS5PrimaryInputSource>(() => ps5_primaryInputSource, delegate(PS5PrimaryInputSource x)
							{
								ps5_primaryInputSource = x;
							})
						},
						{
							"webGL_primaryInputSource",
							new GetSetValue<WebGLPrimaryInputSource>(() => webGL_primaryInputSource, delegate(WebGLPrimaryInputSource x)
							{
								webGL_primaryInputSource = x;
							})
						},
						{
							"stadia_primaryInputSource",
							new GetSetValue<StadiaPrimaryInputSource>(() => stadia_primaryInputSource, delegate(StadiaPrimaryInputSource x)
							{
								stadia_primaryInputSource = x;
							})
						},
						{
							"useXInput",
							new GetSetValue<bool>(() => useXInput, delegate(bool x)
							{
								useXInput = x;
							})
						},
						{
							"windowsStandalone_useSteamRawInputControllerWorkaround",
							new GetSetValue<bool>(() => windowsStandalone_useSteamRawInputControllerWorkaround, delegate(bool x)
							{
								windowsStandalone_useSteamRawInputControllerWorkaround = x;
							})
						},
						{
							"osxStandalone_useEnhancedDeviceSupport",
							new GetSetValue<bool>(() => osxStandalone_useEnhancedDeviceSupport, delegate(bool x)
							{
								osxStandalone_useEnhancedDeviceSupport = x;
							})
						},
						{
							"android_supportUnknownGamepads",
							new GetSetValue<bool>(() => android_supportUnknownGamepads, delegate(bool x)
							{
								android_supportUnknownGamepads = x;
							})
						},
						{
							"ps4_assignJoysticksByPS4JoyId",
							new GetSetValue<bool>(() => ps4_assignJoysticksByPS4JoyId, delegate(bool x)
							{
								ps4_assignJoysticksByPS4JoyId = x;
							})
						},
						{
							"useSteamControllerSupport",
							new GetSetValue<bool>(() => useSteamControllerSupport, delegate(bool x)
							{
								useSteamControllerSupport = x;
							})
						},
						{
							"logToScreen",
							new GetSetValue<bool>(() => logToScreen, delegate(bool x)
							{
								logToScreen = x;
							})
						},
						{
							"runInEditMode",
							new GetSetValue<bool>(() => runInEditMode, delegate(bool x)
							{
								runInEditMode = x;
							})
						},
						{
							"allowInputInEditorSceneView",
							new GetSetValue<bool>(() => allowInputInEditorSceneView, delegate(bool x)
							{
								allowInputInEditorSceneView = x;
							})
						},
						{
							"maxJoysticksPerPlayer",
							new GetSetValue<int>(() => maxJoysticksPerPlayer, delegate(int x)
							{
								maxJoysticksPerPlayer = x;
							})
						},
						{
							"autoAssignJoysticks",
							new GetSetValue<bool>(() => autoAssignJoysticks, delegate(bool x)
							{
								autoAssignJoysticks = x;
							})
						},
						{
							"assignJoysticksToPlayingPlayersOnly",
							new GetSetValue<bool>(() => assignJoysticksToPlayingPlayersOnly, delegate(bool x)
							{
								assignJoysticksToPlayingPlayersOnly = x;
							})
						},
						{
							"distributeJoysticksEvenly",
							new GetSetValue<bool>(() => distributeJoysticksEvenly, delegate(bool x)
							{
								distributeJoysticksEvenly = x;
							})
						},
						{
							"reassignJoystickToPreviousOwnerOnReconnect",
							new GetSetValue<bool>(() => reassignJoystickToPreviousOwnerOnReconnect, delegate(bool x)
							{
								reassignJoystickToPreviousOwnerOnReconnect = x;
							})
						},
						{
							"defaultJoystickAxis2DDeadZoneType",
							new GetSetValue<DeadZone2DType>(() => defaultJoystickAxis2DDeadZoneType, delegate(DeadZone2DType x)
							{
								defaultJoystickAxis2DDeadZoneType = x;
							})
						},
						{
							"defaultJoystickAxis2DSensitivityType",
							new GetSetValue<AxisSensitivity2DType>(() => defaultJoystickAxis2DSensitivityType, delegate(AxisSensitivity2DType x)
							{
								defaultJoystickAxis2DSensitivityType = x;
							})
						},
						{
							"defaultAxisSensitivityType",
							new GetSetValue<AxisSensitivityType>(() => defaultAxisSensitivityType, delegate(AxisSensitivityType x)
							{
								defaultAxisSensitivityType = x;
							})
						},
						{
							"force4WayHats",
							new GetSetValue<bool>(() => force4WayHats, delegate(bool x)
							{
								force4WayHats = x;
							})
						},
						{
							"throttleCalibrationMode",
							new GetSetValue<ThrottleCalibrationMode>(() => throttleCalibrationMode, delegate(ThrottleCalibrationMode x)
							{
								throttleCalibrationMode = x;
							})
						},
						{
							"activateActionButtonsOnNegativeValue",
							new GetSetValue<bool>(() => activateActionButtonsOnNegativeValue, delegate(bool x)
							{
								activateActionButtonsOnNegativeValue = x;
							})
						},
						{
							"deferControllerConnectedEventsOnStart",
							new GetSetValue<bool>(() => deferControllerConnectedEventsOnStart, delegate(bool x)
							{
								deferControllerConnectedEventsOnStart = x;
							})
						},
						{
							"logLevel",
							new GetSetValue<LogLevelFlags>(() => logLevel, delegate(LogLevelFlags x)
							{
								logLevel = x;
							})
						},
						{
							"disableKeyboard",
							new GetSetValue<bool>(() => GetPlatformVar_disableKeyboard(), delegate(bool x)
							{
								SetPlatformVar_disableKeyboard(x);
							})
						},
						{
							"ignoreInputWhenAppNotInFocus",
							new GetSetValue<bool>(() => GetPlatformVar_ignoreInputWhenAppNotInFocus(), delegate(bool x)
							{
								SetPlatformVar_ignoreInputWhenAppNotInFocus(x);
							})
						},
						{
							"useEnhancedDeviceSupport",
							new GetSetValue<bool>(() => GetPlatformVar_useEnhancedDeviceSupport(), delegate(bool x)
							{
								SetPlatformVar_useEnhancedDeviceSupport(x);
							})
						},
						{
							"useNativeMouse",
							new GetSetValue<bool>(() => GetPlatformVar_useNativeMouse(), delegate(bool x)
							{
								SetPlatformVar_useNativeMouse(x);
							})
						},
						{
							"useNativeKeyboard",
							new GetSetValue<bool>(() => GetPlatformVar_useNativeKeyboard(), delegate(bool x)
							{
								SetPlatformVar_useNativeKeyboard(x);
							})
						},
						{
							"joystickRefreshRate",
							new GetSetValue<int>(() => GetPlatformVar_joystickRefreshRate(), delegate(int x)
							{
								SetPlatformVar_joystickRefreshRate(x);
							})
						},
						{
							"assignJoysticksBySystemId",
							new GetSetValue<bool>(() => GetPlatformVar_assignJoysticksBySystemId(), delegate(bool x)
							{
								SetPlatformVar_assignJoysticksBySystemId(x);
							})
						}
					};
				}
				return __valueDelegates;
			}
		}

		[Preserve]
		public ConfigVars()
		{
		}

		internal bool DoesPlatformUseFallback(Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor)
		{
			if (alwaysUseUnityInput)
			{
				return true;
			}
			if (!isEditor && webplayerPlatform != 0)
			{
				return true;
			}
			return platform switch
			{
				Platform.Windows => windowsStandalonePrimaryInputSource == WindowsStandalonePrimaryInputSource.Unity, 
				Platform.OSX => osx_primaryInputSource == OSXStandalonePrimaryInputSource.Unity, 
				Platform.Linux => linux_primaryInputSource == LinuxStandalonePrimaryInputSource.Unity, 
				Platform.WindowsUWP => windowsUWP_primaryInputSource == WindowsUWPPrimaryInputSource.Unity, 
				Platform.WebGL => webGL_primaryInputSource == WebGLPrimaryInputSource.Unity, 
				Platform.XboxOne => xboxOne_primaryInputSource == XboxOnePrimaryInputSource.Unity, 
				Platform.PS4 => ps4_primaryInputSource == PS4PrimaryInputSource.Unity, 
				_ => false, 
			};
		}

		internal bool DoesPlatformUseSDL2(Platform platform, WebplayerPlatform webplayerPlatform, bool isEditor)
		{
			if (alwaysUseUnityInput)
			{
				return false;
			}
			if (!isEditor && webplayerPlatform != 0)
			{
				return false;
			}
			return platform switch
			{
				Platform.Windows => windowsStandalonePrimaryInputSource == WindowsStandalonePrimaryInputSource.SDL2, 
				Platform.OSX => osx_primaryInputSource == OSXStandalonePrimaryInputSource.SDL2, 
				Platform.Linux => linux_primaryInputSource == LinuxStandalonePrimaryInputSource.SDL2, 
				_ => false, 
			};
		}

		internal string GetDebugConfigSettings()
		{
			string text = "";
			switch (UnityTools.platform)
			{
			case Platform.Windows:
			{
				object obj11 = text;
				text = string.Concat(obj11, "Primary input source: ", windowsStandalonePrimaryInputSource, "\n");
				object obj12 = text;
				text = string.Concat(obj12, "Use XInput: ", useXInput, "\n");
				break;
			}
			case Platform.OSX:
			{
				object obj10 = text;
				text = string.Concat(obj10, "Primary input source: ", osx_primaryInputSource, "\n");
				break;
			}
			case Platform.Linux:
			{
				object obj9 = text;
				text = string.Concat(obj9, "Primary input source: ", linux_primaryInputSource, "\n");
				break;
			}
			case Platform.WindowsUWP:
			{
				object obj8 = text;
				text = string.Concat(obj8, "Primary input source: ", windowsUWP_primaryInputSource, "\n");
				break;
			}
			case Platform.XboxOne:
			{
				object obj7 = text;
				text = string.Concat(obj7, "Primary input source: ", xboxOne_primaryInputSource, "\n");
				break;
			}
			case Platform.GameCoreXboxOne:
			{
				object obj6 = text;
				text = string.Concat(obj6, "Primary input source: ", gameCoreXboxOne_primaryInputSource, "\n");
				break;
			}
			case Platform.GameCoreScarlett:
			{
				object obj5 = text;
				text = string.Concat(obj5, "Primary input source: ", gameCoreScarlett_primaryInputSource, "\n");
				break;
			}
			case Platform.PS4:
			{
				object obj4 = text;
				text = string.Concat(obj4, "Primary input source: ", ps4_primaryInputSource, "\n");
				break;
			}
			case Platform.PS5:
			{
				object obj3 = text;
				text = string.Concat(obj3, "Primary input source: ", ps5_primaryInputSource, "\n");
				break;
			}
			case Platform.Stadia:
			{
				object obj2 = text;
				text = string.Concat(obj2, "Primary input source: ", stadia_primaryInputSource, "\n");
				break;
			}
			case Platform.WebGL:
			{
				object obj = text;
				text = string.Concat(obj, "Primary input source: ", webGL_primaryInputSource, "\n");
				break;
			}
			}
			object obj13 = text;
			text = string.Concat(obj13, "Native mouse handling: ", GetPlatformVar_useNativeMouse(), "\n");
			object obj14 = text;
			text = string.Concat(obj14, "Enhanced device support: ", GetPlatformVar_useEnhancedDeviceSupport(), "\n");
			if (UnityTools.isAndroidPlatform)
			{
				object obj15 = text;
				text = string.Concat(obj15, "Android: Support Unknown Gamepads: ", android_supportUnknownGamepads, "\n");
			}
			return text;
		}

		[CustomObfuscation(rename = false)]
		internal string GetPlatformVarsRelPath(Platform platform)
		{
			if (platformVarsDict.ContainsKey((int)platform))
			{
				return platformVarsDict[(int)platform].xFQCSeJJxiIYcdhJhKHXIBlFAUse;
			}
			throw new NotImplementedException();
		}

		[CustomObfuscation(rename = false)]
		internal PlatformVars GetPlatformVars(Platform platform)
		{
			PlatformVars platformVars = ((!platformVarsDict.ContainsKey((int)platform)) ? GetOrCreatePlatformVars(ref platformVars_unknown) : platformVarsDict[(int)platform].ZrMIKVJCcOEHseNKEKaenSBrkIra());
			if (platformVars == null)
			{
				platformVars = new PlatformVars();
			}
			return platformVars;
		}

		[CustomObfuscation(rename = false)]
		internal T Editor_GetAllSerializedPlatformVar<T>(AllPlatformVar var)
		{
			Type typeFromHandle = typeof(T);
			if (object.ReferenceEquals(typeFromHandle, typeof(MultiBoolValue)))
			{
				return (T)(object)GetAllSerializedPlatformVar_multiBool(var);
			}
			throw new NotImplementedException();
		}

		[CustomObfuscation(rename = false)]
		internal void Editor_SetAllSerializedPlatformVar(AllPlatformVar var, object value)
		{
			foreach (KeyValuePair<int, JxemSQTOnhkehGMLYGAYqGVWnJM> item in platformVarsDict)
			{
				if (getSetPlatformVariableDict.ContainsKey((int)var))
				{
					getSetPlatformVariableDict[(int)var].JFnfxNhVwUUtZbWQNbibPwjxwxb((Platform)item.Key, value);
				}
			}
		}

		internal bool GetPlatformVar_disableKeyboard()
		{
			return GetPlatformVars().disableKeyboard;
		}

		internal bool SetPlatformVar_disableKeyboard(bool value)
		{
			return GetPlatformVars().disableKeyboard = value;
		}

		internal bool GetPlatformVar_ignoreInputWhenAppNotInFocus()
		{
			return GetPlatformVars().ignoreInputWhenAppNotInFocus;
		}

		internal bool GetPlatformVar_useEnhancedDeviceSupport()
		{
			return UnityTools.effectivePlatform switch
			{
				Platform.Windows => useEnhancedDeviceSupport, 
				Platform.OSX => osxStandalone_useEnhancedDeviceSupport, 
				_ => false, 
			};
		}

		internal bool GetPlatformVar_useNativeMouse()
		{
			Platform effectivePlatform = UnityTools.effectivePlatform;
			PlatformVars platformVars = GetPlatformVars(effectivePlatform);
			if (platformVars == null)
			{
				return false;
			}
			switch (effectivePlatform)
			{
			case Platform.Windows:
				return useNativeMouse;
			case Platform.Stadia:
				if (!(platformVars is PlatformVars_Stadia))
				{
					return true;
				}
				return (platformVars as PlatformVars_Stadia).useNativeMouse;
			default:
				return false;
			}
		}

		internal bool GetPlatformVar_useNativeKeyboard()
		{
			Platform effectivePlatform = UnityTools.effectivePlatform;
			PlatformVars platformVars = GetPlatformVars(effectivePlatform);
			if (platformVars == null)
			{
				return false;
			}
			switch (effectivePlatform)
			{
			case Platform.Windows:
				if (!(platformVars is PlatformVars_WindowsStandalone))
				{
					return true;
				}
				return (platformVars as PlatformVars_WindowsStandalone).useNativeKeyboard;
			case Platform.Stadia:
				if (!(platformVars is PlatformVars_Stadia))
				{
					return true;
				}
				return (platformVars as PlatformVars_Stadia).useNativeKeyboard;
			default:
				return false;
			}
		}

		internal int GetPlatformVar_joystickRefreshRate()
		{
			Platform effectivePlatform = UnityTools.effectivePlatform;
			PlatformVars platformVars = GetPlatformVars(effectivePlatform);
			if (platformVars == null)
			{
				return 240;
			}
			Platform platform = effectivePlatform;
			if (platform == Platform.Windows)
			{
				if (!(platformVars is PlatformVars_WindowsStandalone))
				{
					return 240;
				}
				return (platformVars as PlatformVars_WindowsStandalone).joystickRefreshRate;
			}
			return 240;
		}

		internal bool GetPlatformVar_assignJoysticksBySystemId()
		{
			Platform effectivePlatform = UnityTools.effectivePlatform;
			PlatformVars platformVars = GetPlatformVars(effectivePlatform);
			if (platformVars == null)
			{
				return false;
			}
			switch (effectivePlatform)
			{
			case Platform.PS4:
				return ps4_assignJoysticksByPS4JoyId;
			case Platform.GameCoreXboxOne:
				if (!(platformVars is PlatformVars_GameCoreXboxOne))
				{
					return false;
				}
				return (platformVars as PlatformVars_GameCoreXboxOne).assignJoysticksByUserId;
			case Platform.GameCoreScarlett:
				if (!(platformVars is PlatformVars_GameCoreScarlett))
				{
					return false;
				}
				return (platformVars as PlatformVars_GameCoreScarlett).assignJoysticksByUserId;
			default:
				return false;
			}
		}

		internal bool SetPlatformVar_ignoreInputWhenAppNotInFocus(bool value)
		{
			if (GetPlatformVars().ignoreInputWhenAppNotInFocus == value)
			{
				return false;
			}
			GetPlatformVars().ignoreInputWhenAppNotInFocus = value;
			return true;
		}

		internal bool SetPlatformVar_useEnhancedDeviceSupport(bool value)
		{
			switch (UnityTools.effectivePlatform)
			{
			case Platform.Windows:
				if (useEnhancedDeviceSupport == value)
				{
					return false;
				}
				useEnhancedDeviceSupport = value;
				return true;
			case Platform.OSX:
				if (osxStandalone_useEnhancedDeviceSupport == value)
				{
					return false;
				}
				osxStandalone_useEnhancedDeviceSupport = value;
				return true;
			default:
				return false;
			}
		}

		internal bool SetPlatformVar_useNativeMouse(bool value)
		{
			Platform effectivePlatform = UnityTools.effectivePlatform;
			Platform platform = effectivePlatform;
			if (platform == Platform.Windows)
			{
				if (useNativeMouse == value)
				{
					return false;
				}
				useNativeMouse = value;
				return true;
			}
			return false;
		}

		internal bool SetPlatformVar_useNativeKeyboard(bool value)
		{
			Platform effectivePlatform = UnityTools.effectivePlatform;
			PlatformVars platformVars = GetPlatformVars(effectivePlatform);
			if (platformVars == null)
			{
				return false;
			}
			switch (effectivePlatform)
			{
			case Platform.Windows:
				if (platformVars is PlatformVars_WindowsStandalone)
				{
					(platformVars as PlatformVars_WindowsStandalone).useNativeKeyboard = value;
				}
				return true;
			case Platform.Stadia:
				if (platformVars is PlatformVars_Stadia)
				{
					(platformVars as PlatformVars_Stadia).useNativeKeyboard = value;
				}
				return true;
			default:
				return false;
			}
		}

		internal bool SetPlatformVar_joystickRefreshRate(int value)
		{
			Platform effectivePlatform = UnityTools.effectivePlatform;
			PlatformVars platformVars = GetPlatformVars(effectivePlatform);
			if (platformVars == null)
			{
				return false;
			}
			Platform platform = effectivePlatform;
			if (platform == Platform.Windows)
			{
				if (platformVars is PlatformVars_WindowsStandalone)
				{
					(platformVars as PlatformVars_WindowsStandalone).joystickRefreshRate = value;
				}
				return true;
			}
			return false;
		}

		internal bool SetPlatformVar_assignJoysticksBySystemId(bool value)
		{
			Platform effectivePlatform = UnityTools.effectivePlatform;
			PlatformVars platformVars = GetPlatformVars(effectivePlatform);
			if (platformVars == null)
			{
				return false;
			}
			switch (effectivePlatform)
			{
			case Platform.PS4:
				ps4_assignJoysticksByPS4JoyId = value;
				return true;
			case Platform.GameCoreXboxOne:
				if (platformVars is PlatformVars_GameCoreXboxOne)
				{
					(platformVars as PlatformVars_GameCoreXboxOne).assignJoysticksByUserId = value;
				}
				return false;
			case Platform.GameCoreScarlett:
				if (platformVars is PlatformVars_GameCoreScarlett)
				{
					(platformVars as PlatformVars_GameCoreScarlett).assignJoysticksByUserId = value;
				}
				return true;
			default:
				return false;
			}
		}

		private PlatformVars GetPlatformVars()
		{
			Platform platform = UnityTools.effectivePlatform;
			if (!UnityTools.isEditor && UnityTools.isAndroidPlatform)
			{
				platform = Platform.Android;
			}
			return GetPlatformVars(platform);
		}

		private T GetOrCreatePlatformVars<T>(ref T var) where T : PlatformVars, new()
		{
			if (var == null)
			{
				var = new T();
			}
			return var;
		}

		private MultiBoolValue GetAllSerializedPlatformVar_multiBool(AllPlatformVar var)
		{
			bool flag = false;
			bool flag2 = true;
			foreach (KeyValuePair<int, JxemSQTOnhkehGMLYGAYqGVWnJM> item in platformVarsDict)
			{
				if (!getSetPlatformVariableDict.ContainsKey((int)var))
				{
					continue;
				}
				object obj = getSetPlatformVariableDict[(int)var].ZrMIKVJCcOEHseNKEKaenSBrkIra((Platform)item.Key);
				if (obj == null)
				{
					continue;
				}
				if (!object.ReferenceEquals(obj.GetType(), typeof(bool)))
				{
					Logger.LogWarning("Incorrect type. Expecting bool, got " + obj.GetType().Name);
					continue;
				}
				bool flag3 = (bool)obj;
				if (flag2)
				{
					flag = flag3;
					flag2 = false;
				}
				else if (flag3 != flag)
				{
					return MultiBoolValue.SxlGSjxsodeehfDOvlRfipjjhfO;
				}
			}
			if (!flag)
			{
				return MultiBoolValue.DyTkQiNnAPnZlOxrECHYhBSslIv;
			}
			return MultiBoolValue.AgsjzxPUGELGeHFAPrimMZoZTDX;
		}

		internal bool IsEditModeInputSupported(ControllerType controllerType, EditorPlatform editorPlatform)
		{
			if (alwaysUseUnityInput)
			{
				return false;
			}
			switch (controllerType)
			{
			case ControllerType.Keyboard:
			case ControllerType.Mouse:
				switch (editorPlatform)
				{
				case EditorPlatform.OSX:
				case EditorPlatform.Linux:
					return false;
				case EditorPlatform.Windows:
					if (windowsStandalonePrimaryInputSource == WindowsStandalonePrimaryInputSource.RawInput || windowsStandalonePrimaryInputSource == WindowsStandalonePrimaryInputSource.DirectInput || windowsStandalonePrimaryInputSource == WindowsStandalonePrimaryInputSource.XInput)
					{
						if (controllerType != 0)
						{
							return useNativeMouse;
						}
						return platformVars_windowsStandalone.useNativeKeyboard;
					}
					return false;
				default:
					return false;
				}
			case ControllerType.Joystick:
				switch (editorPlatform)
				{
				case EditorPlatform.Linux:
					if (linux_primaryInputSource != 0)
					{
						return linux_primaryInputSource == LinuxStandalonePrimaryInputSource.SDL2;
					}
					return true;
				case EditorPlatform.OSX:
					if (osx_primaryInputSource != 0)
					{
						return osx_primaryInputSource == OSXStandalonePrimaryInputSource.SDL2;
					}
					return true;
				case EditorPlatform.Windows:
					if (windowsStandalonePrimaryInputSource != 0 && windowsStandalonePrimaryInputSource != WindowsStandalonePrimaryInputSource.DirectInput && windowsStandalonePrimaryInputSource != WindowsStandalonePrimaryInputSource.XInput)
					{
						return windowsStandalonePrimaryInputSource == WindowsStandalonePrimaryInputSource.SDL2;
					}
					return true;
				default:
					return false;
				}
			default:
				return false;
			}
		}
	}
}
