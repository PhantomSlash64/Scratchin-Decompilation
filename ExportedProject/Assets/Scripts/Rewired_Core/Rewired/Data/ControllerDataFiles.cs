using System;
using System.Collections.Generic;
using Rewired.Data.Mapping;
using Rewired.Utils;
using UnityEngine;

namespace Rewired.Data
{
	public sealed class ControllerDataFiles : ScriptableObject
	{
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private HardwareJoystickMap defaultHardwareJoystickMap;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private HardwareJoystickMap[] hardwareJoystickMaps;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private HardwareJoystickTemplateMap[] joystickTemplates;

		[NonSerialized]
		private bool xnQXeaNYaabCgdRxcFdAVAtCkrI;

		public Guid defaultHardwareJoystickMapGuid
		{
			get
			{
				if (!(defaultHardwareJoystickMap == null))
				{
					return defaultHardwareJoystickMap.Guid;
				}
				return Guid.Empty;
			}
		}

		public HardwareJoystickTemplateMap[] JoystickTemplates
		{
			get
			{
				return joystickTemplates;
			}
			set
			{
				joystickTemplates = value;
			}
		}

		public HardwareJoystickMap[] HardwareJoystickMaps
		{
			get
			{
				return hardwareJoystickMaps;
			}
			set
			{
				hardwareJoystickMaps = value;
			}
		}

		public HardwareJoystickMap DefaultHardwareJoystickMap
		{
			get
			{
				return defaultHardwareJoystickMap;
			}
			set
			{
				defaultHardwareJoystickMap = value;
			}
		}

		public string[] GetJoystickNames()
		{
			if (hardwareJoystickMaps == null)
			{
				return null;
			}
			List<string> list = new List<string>();
			for (int i = 0; i < hardwareJoystickMaps.Length; i++)
			{
				if (!(hardwareJoystickMaps[i] == null) && !hardwareJoystickMaps[i].HideInLists)
				{
					list.Add(hardwareJoystickMaps[i].ControllerName);
				}
			}
			list.Insert(0, defaultHardwareJoystickMap.ControllerName);
			return list.ToArray();
		}

		public string[] GetEditorJoystickNames()
		{
			if (hardwareJoystickMaps == null)
			{
				return null;
			}
			List<string> list = new List<string>();
			for (int i = 0; i < hardwareJoystickMaps.Length; i++)
			{
				if (!(hardwareJoystickMaps[i] == null) && !hardwareJoystickMaps[i].HideInLists)
				{
					if (!string.IsNullOrEmpty(hardwareJoystickMaps[i].EditorControllerName))
					{
						list.Add(hardwareJoystickMaps[i].EditorControllerName);
					}
					else
					{
						list.Add(hardwareJoystickMaps[i].ControllerName);
					}
				}
			}
			list.Insert(0, defaultHardwareJoystickMap.ControllerName);
			return list.ToArray();
		}

		public Guid[] GetJoystickGuids()
		{
			if (hardwareJoystickMaps == null)
			{
				return null;
			}
			List<Guid> list = new List<Guid>();
			for (int i = 0; i < hardwareJoystickMaps.Length; i++)
			{
				if (!(hardwareJoystickMaps[i] == null) && !hardwareJoystickMaps[i].HideInLists)
				{
					list.Add(hardwareJoystickMaps[i].Guid);
				}
			}
			list.Insert(0, defaultHardwareJoystickMap.Guid);
			return list.ToArray();
		}

		public string[] GetJoystickTemplateNames()
		{
			if (joystickTemplates == null)
			{
				return null;
			}
			List<string> list = new List<string>();
			for (int i = 0; i < joystickTemplates.Length; i++)
			{
				if (!(joystickTemplates[i] == null))
				{
					list.Add(joystickTemplates[i].ControllerName);
				}
			}
			return list.ToArray();
		}

		public Guid[] GetJoystickTemplateGuids()
		{
			if (joystickTemplates == null)
			{
				return null;
			}
			List<Guid> list = new List<Guid>();
			for (int i = 0; i < joystickTemplates.Length; i++)
			{
				if (!(joystickTemplates[i] == null))
				{
					list.Add(joystickTemplates[i].Guid);
				}
			}
			return list.ToArray();
		}

		public HardwareJoystickMap GetHardwareJoystickMap(Guid guid)
		{
			if (hardwareJoystickMaps == null)
			{
				return null;
			}
			if (guid == defaultHardwareJoystickMap.Guid)
			{
				return defaultHardwareJoystickMap;
			}
			for (int i = 0; i < hardwareJoystickMaps.Length; i++)
			{
				if (!(hardwareJoystickMaps[i] == null) && hardwareJoystickMaps[i].Guid == guid)
				{
					return hardwareJoystickMaps[i];
				}
			}
			return null;
		}

		public HardwareJoystickTemplateMap GetJoystickTemplate(Guid guid)
		{
			if (joystickTemplates == null)
			{
				return null;
			}
			for (int i = 0; i < joystickTemplates.Length; i++)
			{
				if (!(joystickTemplates[i] == null) && joystickTemplates[i].Guid == guid)
				{
					return joystickTemplates[i];
				}
			}
			return null;
		}

		public IHardwareControllerTemplateMap GetControllerTemplate(Guid guid)
		{
			return GetJoystickTemplate(guid);
		}

		public IHardwareControllerMap GetHardwareJoystickOrTemplateMap(Guid guid)
		{
			HardwareJoystickMap hardwareJoystickMap = GetHardwareJoystickMap(guid);
			if (hardwareJoystickMap != null)
			{
				return hardwareJoystickMap;
			}
			return GetJoystickTemplate(guid);
		}

		internal ControllerTemplateElementIdentifier LPVghKoUxjeCTfLtGsFKjvVWPNN(Guid P_0, int P_1)
		{
			if (P_1 < 0)
			{
				return null;
			}
			if (P_0 == Guid.Empty)
			{
				return null;
			}
			HardwareJoystickMap hardwareJoystickMap = GetHardwareJoystickMap(P_0);
			if (hardwareJoystickMap == null)
			{
				return null;
			}
			foreach (Guid templateGuid in hardwareJoystickMap.TemplateGuids)
			{
				HardwareJoystickTemplateMap joystickTemplate = GetJoystickTemplate(templateGuid);
				if (!(joystickTemplate == null))
				{
					ControllerTemplateElementIdentifier controllerTemplateElementIdentifier = joystickTemplate.CmSKuWHNjixLGRzLinrqxfVeCrT(P_0, P_1);
					if (controllerTemplateElementIdentifier != null)
					{
						return controllerTemplateElementIdentifier;
					}
				}
			}
			return null;
		}

		internal HardwareJoystickMap_InputManager tsbJlFSFeAtlDSuvfupzvtoliMa(Guid P_0, InputSource P_1)
		{
			qYGszGwALwFPxCTMwrVcXirfWnj();
			BridgedController bridgedController = new BridgedController();
			bridgedController.isMock = true;
			bridgedController.inputManagerSource = P_1;
			bridgedController.inputSource = P_1;
			BridgedController bridgedController2 = bridgedController;
			HardwareJoystickMap hardwareJoystickMap = GetHardwareJoystickMap(P_0);
			if (hardwareJoystickMap != null)
			{
				InputPlatform inputPlatform;
				int num;
				HardwareJoystickMap.Platform platform;
				HardwareJoystickMap_InputManager hardwareJoystickMap_InputManager = tEjsjbGPPPudwVIETWTySPiXjYS(hardwareJoystickMap, bridgedController2, true, out inputPlatform, out num, out platform);
				if (hardwareJoystickMap_InputManager != null)
				{
					return hardwareJoystickMap_InputManager;
				}
			}
			return defaultHardwareJoystickMap.GetDefaultHardwareJoystickMap_InputManager(bridgedController2);
		}

		internal HardwareJoystickMap_InputManager BNncPUNDkYiPJuxzxNfwYgZzxHn(BridgedControllerHWInfo P_0)
		{
			if (P_0 == null)
			{
				return null;
			}
			qYGszGwALwFPxCTMwrVcXirfWnj();
			if (P_0.inputSource == InputSource.SDL2 && P_0.hw_isSDL2Gamepad)
			{
				HardwareJoystickMap_InputManager hardwareJoystickMap_InputManager = eTmDBveFSUHoTkxhzlHbTakAlkE(P_0);
				if (hardwareJoystickMap_InputManager != null)
				{
					return hardwareJoystickMap_InputManager;
				}
			}
			for (int i = 0; i < hardwareJoystickMaps.Length; i++)
			{
				InputPlatform inputPlatform;
				int num;
				HardwareJoystickMap.Platform platform;
				HardwareJoystickMap_InputManager hardwareJoystickMap_InputManager2 = tEjsjbGPPPudwVIETWTySPiXjYS(hardwareJoystickMaps[i], P_0, true, out inputPlatform, out num, out platform);
				if (hardwareJoystickMap_InputManager2 != null)
				{
					return hardwareJoystickMap_InputManager2;
				}
			}
			for (int j = 0; j < hardwareJoystickMaps.Length; j++)
			{
				InputPlatform inputPlatform2;
				int num2;
				HardwareJoystickMap.Platform platform2;
				HardwareJoystickMap_InputManager hardwareJoystickMap_InputManager3 = tEjsjbGPPPudwVIETWTySPiXjYS(hardwareJoystickMaps[j], P_0, false, out inputPlatform2, out num2, out platform2);
				if (hardwareJoystickMap_InputManager3 != null)
				{
					return hardwareJoystickMap_InputManager3;
				}
			}
			if (P_0.inputSource == InputSource.Fallback_PreConfigured)
			{
				HardwareJoystickMap_InputManager hardwareJoystickMap_InputManager4 = SwTfmVbfHFDKVdoTgfSNnZVMlnnC(P_0, "[UNITY PRECONFIGURED JOYSTICK]");
				if (hardwareJoystickMap_InputManager4 != null)
				{
					hardwareJoystickMap_InputManager4.useSystemName = true;
					return hardwareJoystickMap_InputManager4;
				}
			}
			if (UnityTools.isAndroidPlatform && ReInput.configVars.android_supportUnknownGamepads)
			{
				HardwareJoystickMap_InputManager hardwareJoystickMap_InputManager5 = eTmDBveFSUHoTkxhzlHbTakAlkE(P_0);
				if (hardwareJoystickMap_InputManager5 != null)
				{
					return hardwareJoystickMap_InputManager5;
				}
			}
			return defaultHardwareJoystickMap.GetDefaultHardwareJoystickMap_InputManager(P_0);
		}

		private HardwareJoystickMap_InputManager tEjsjbGPPPudwVIETWTySPiXjYS(HardwareJoystickMap P_0, BridgedControllerHWInfo P_1, bool P_2, out InputPlatform P_3, out int P_4, out HardwareJoystickMap.Platform P_5)
		{
			P_3 = InputPlatform.CCZTuwVJranWzEkxzHtKCBLLDDz;
			P_4 = -1;
			P_5 = null;
			if (P_0 == null)
			{
				return null;
			}
			if (!P_0.Matches(P_1, P_2, isDefaultMap: false, out P_3, out P_4, out P_5))
			{
				return null;
			}
			HardwareJoystickMap_InputManager hardwareJoystickMap_InputManager = P_5.ToHardwareJoystickMap_InputManager(P_0, P_1.inputSource, P_3, P_4);
			if (hardwareJoystickMap_InputManager == null)
			{
				return null;
			}
			return hardwareJoystickMap_InputManager;
		}

		private HardwareJoystickMap_InputManager SwTfmVbfHFDKVdoTgfSNnZVMlnnC(BridgedControllerHWInfo P_0, string P_1)
		{
			BridgedControllerHWInfo bridgedControllerHWInfo = new BridgedControllerHWInfo(P_0);
			bridgedControllerHWInfo.hw_productName = P_1;
			bridgedControllerHWInfo.hardwareButtonCount = 0;
			bridgedControllerHWInfo.hardwareAxisCount = 0;
			bridgedControllerHWInfo.hardwareHatCount = 0;
			for (int i = 0; i < hardwareJoystickMaps.Length; i++)
			{
				if (!(hardwareJoystickMaps[i] == null) && hardwareJoystickMaps[i].Matches(bridgedControllerHWInfo, strictMatch: false, isDefaultMap: false, out var actualInputPlatform, out var variantIndex, out var platformMap))
				{
					HardwareJoystickMap_InputManager hardwareJoystickMap_InputManager = platformMap.ToHardwareJoystickMap_InputManager(hardwareJoystickMaps[i], P_0.inputSource, actualInputPlatform, variantIndex);
					if (hardwareJoystickMap_InputManager != null)
					{
						return hardwareJoystickMap_InputManager;
					}
				}
			}
			return null;
		}

		private HardwareJoystickMap_InputManager eTmDBveFSUHoTkxhzlHbTakAlkE(BridgedControllerHWInfo P_0)
		{
			HardwareJoystickMap_InputManager hardwareJoystickMap_InputManager = SwTfmVbfHFDKVdoTgfSNnZVMlnnC(P_0, "[STANDARDIZED GAMEPAD]");
			if (hardwareJoystickMap_InputManager == null)
			{
				return null;
			}
			hardwareJoystickMap_InputManager.useSystemName = true;
			return hardwareJoystickMap_InputManager;
		}

		private void qYGszGwALwFPxCTMwrVcXirfWnj()
		{
			if (!xnQXeaNYaabCgdRxcFdAVAtCkrI)
			{
				if (ArrayTools.IsNullOrEmpty(hardwareJoystickMaps) || defaultHardwareJoystickMap == null || ArrayTools.IsNullOrEmpty(joystickTemplates))
				{
					Logger.LogError("ControllerDataFiles is missing critical data! The serialized data may have been corrupted. Please see the Known Issues in the documentation for possible causes and solutions.");
				}
				else
				{
					xnQXeaNYaabCgdRxcFdAVAtCkrI = true;
				}
			}
		}
	}
}
