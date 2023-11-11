using System;
using System.Collections.Generic;
using Rewired.Interfaces;
using Rewired.Utils;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	public sealed class HardwareJoystickTemplateMap : HardwareControllerTemplateMap, IHardwareControllerMap, IHardwareControllerMap_Internal, IHardwareControllerTemplateMap, IHardwareControllerTemplateMap_Internal
	{
		[Serializable]
		public sealed class Entry
		{
			public int id;

			public string name;

			public string joystickGuid;

			public string fileGuid;

			public List<ElementIdentifierMap> elementIdentifierMappings;

			public Guid JoystickGuid
			{
				get
				{
					try
					{
						return new Guid(joystickGuid);
					}
					catch
					{
						Logger.LogWarning("Error converting string to Guid due to invalid characters or bad Guid string format. Guid string = \"" + joystickGuid + "\"");
						return Guid.Empty;
					}
				}
			}

			public int GetJoystickElementId(int templateElementId)
			{
				if (elementIdentifierMappings == null)
				{
					return -1;
				}
				for (int i = 0; i < elementIdentifierMappings.Count; i++)
				{
					if (elementIdentifierMappings[i].templateId == templateElementId)
					{
						return elementIdentifierMappings[i].joystickId;
					}
				}
				return -1;
			}

			public int GetTemplateElementId(int joystickElementId)
			{
				if (elementIdentifierMappings == null)
				{
					return -1;
				}
				for (int i = 0; i < elementIdentifierMappings.Count; i++)
				{
					if (elementIdentifierMappings[i].joystickId == joystickElementId)
					{
						return elementIdentifierMappings[i].templateId;
					}
				}
				return -1;
			}

			public ElementIdentifierMap GetElementIdentifierMap(int templateId)
			{
				if (elementIdentifierMappings == null)
				{
					return null;
				}
				for (int i = 0; i < elementIdentifierMappings.Count; i++)
				{
					if (elementIdentifierMappings[i].templateId == templateId)
					{
						return elementIdentifierMappings[i];
					}
				}
				return null;
			}

			public void GetElementIdentifierMaps(int templateId, List<ElementIdentifierMap> results)
			{
				if (results == null || elementIdentifierMappings == null)
				{
					return;
				}
				for (int i = 0; i < elementIdentifierMappings.Count; i++)
				{
					if (elementIdentifierMappings[i].templateId == templateId)
					{
						results.Add(elementIdentifierMappings[i]);
					}
				}
			}
		}

		[Serializable]
		public sealed class ElementIdentifierMap
		{
			public int templateId;

			public int joystickId;

			public int joystickId2;

			public bool splitAxis;
		}

		[Serializable]
		public sealed class SpecialElementEntry : IControllerTemplateMapSpecialElement_Internal
		{
			public int elementIdentifierId = -1;

			public string data;

			private T VtwbTesxpgdylaVYREFNwOopsdk<T>() where T : ControllerTemplateSpecialElementMapping
			{
				JsonParser.TryFromJson<T>(data, out var value);
				return value;
			}

			T IControllerTemplateMapSpecialElement_Internal.GetMapping<T>() where T : ControllerTemplateSpecialElementMapping
			{
				//ILSpy generated this explicit interface implementation from .override directive in VtwbTesxpgdylaVYREFNwOopsdk
				return this.VtwbTesxpgdylaVYREFNwOopsdk<T>();
			}
		}

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private string controllerName;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private string description;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private string templateGuid;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private string className;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private ControllerTemplateElementIdentifier_Editor[] elementIdentifiers;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private List<Entry> joysticks;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private SpecialElementEntry[] specialElements = new SpecialElementEntry[0];

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private int elementIdentifierIdCounter;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private int joystickIdCounter;

		public override Guid Guid => StringTools.ToGuid(templateGuid);

		public string ControllerName => controllerName;

		public string ClassName => className;

		public IEnumerable<ControllerTemplateElementIdentifier> ElementIdentifiers
		{
			get
			{
				if (elementIdentifiers != null)
				{
					for (int i = 0; i < elementIdentifiers.Length; i++)
					{
						yield return elementIdentifiers[i];
					}
				}
			}
		}

		IEnumerable<IControllerElementIdentifierCommon_Internal> IHardwareControllerMap_Internal.ElementIdentifiers
		{
			get
			{
				if (elementIdentifiers != null)
				{
					for (int i = 0; i < elementIdentifiers.Length; i++)
					{
						yield return elementIdentifiers[i];
					}
				}
			}
		}

		string IHardwareControllerTemplateMap_Internal.name => controllerName;

		Guid IHardwareControllerTemplateMap_Internal.typeGuid => Guid;

		[CustomObfuscation(rename = false)]
		public ControllerTemplateElementIdentifier GetElementIdentifier(int id)
		{
			int num = zrDKDHzHNnENLEVxsZEFNhRJoWDo(id);
			if (num < 0 || num >= elementIdentifiers.Length)
			{
				return null;
			}
			return elementIdentifiers[num];
		}

		[CustomObfuscation(rename = false)]
		public bool ContainsElementIdentifier(int id)
		{
			return zrDKDHzHNnENLEVxsZEFNhRJoWDo(id) >= 0;
		}

		[CustomObfuscation(rename = false)]
		public string[] GetElementIdentifierNames()
		{
			int num = ((elementIdentifiers != null) ? elementIdentifiers.Length : 0);
			string[] array = new string[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = elementIdentifiers[i].name;
			}
			return array;
		}

		[CustomObfuscation(rename = false)]
		public int[] GetElementIdentifierIds()
		{
			int num = ((elementIdentifiers != null) ? elementIdentifiers.Length : 0);
			int[] array = new int[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = elementIdentifiers[i].id;
			}
			return array;
		}

		[CustomObfuscation(rename = false)]
		internal string[] GetElementIdentifierScriptingNames(bool useAlternate)
		{
			int num = ((elementIdentifiers != null) ? elementIdentifiers.Length : 0);
			string[] array = new string[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = (useAlternate ? elementIdentifiers[i].alternateScriptingName : elementIdentifiers[i].scriptingName);
			}
			return array;
		}

		public int GetMappableElementIdentifierInfo(out string[] names, out int[] ids)
		{
			names = EmptyObjects<string>.array;
			ids = EmptyObjects<int>.array;
			int num = ((elementIdentifiers != null) ? elementIdentifiers.Length : 0);
			if (num == 0)
			{
				return 0;
			}
			List<ControllerTemplateElementIdentifier> list = new List<ControllerTemplateElementIdentifier>();
			for (int i = 0; i < num; i++)
			{
				if (elementIdentifiers[i] != null && InputTools.IsMappableType(elementIdentifiers[i].elementType))
				{
					list.Add(elementIdentifiers[i]);
				}
			}
			int count = list.Count;
			if (count == 0)
			{
				return 0;
			}
			names = new string[count];
			ids = new int[count];
			for (int j = 0; j < count; j++)
			{
				names[j] = list[j].name;
				ids[j] = list[j].id;
			}
			return count;
		}

		public int GetNonMappableElementIdentifierInfo(out string[] names, out int[] ids)
		{
			names = EmptyObjects<string>.array;
			ids = EmptyObjects<int>.array;
			int num = ((elementIdentifiers != null) ? elementIdentifiers.Length : 0);
			if (num == 0)
			{
				return 0;
			}
			List<ControllerTemplateElementIdentifier> list = new List<ControllerTemplateElementIdentifier>();
			for (int i = 0; i < num; i++)
			{
				if (elementIdentifiers[i] != null && !InputTools.IsMappableType(elementIdentifiers[i].elementType))
				{
					list.Add(elementIdentifiers[i]);
				}
			}
			int count = list.Count;
			if (count == 0)
			{
				return 0;
			}
			names = new string[count];
			ids = new int[count];
			for (int j = 0; j < count; j++)
			{
				names[j] = list[j].name;
				ids[j] = list[j].id;
			}
			return count;
		}

		public string[] GetJoystickNames()
		{
			int num = ((joysticks != null) ? joysticks.Count : 0);
			string[] array = new string[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = joysticks[i].name;
			}
			return array;
		}

		public int[] GetJoystickIds()
		{
			int num = ((joysticks != null) ? joysticks.Count : 0);
			int[] array = new int[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = joysticks[i].id;
			}
			return array;
		}

		public Guid GetJoystickGuid(int joystickId)
		{
			if (joysticks == null)
			{
				return Guid.Empty;
			}
			for (int i = 0; i < joysticks.Count; i++)
			{
				if (joysticks[i].id == joystickId)
				{
					return StringTools.ToGuid(joysticks[i].joystickGuid);
				}
			}
			return Guid.Empty;
		}

		public int GetJoystickId(Guid guid)
		{
			for (int i = 0; i < joysticks.Count; i++)
			{
				if (StringTools.ToGuid(joysticks[i].joystickGuid) == guid)
				{
					return joysticks[i].id;
				}
			}
			return -1;
		}

		public string GetJoystickFileGuidString(int joystickId)
		{
			if (joysticks == null)
			{
				return string.Empty;
			}
			for (int i = 0; i < joysticks.Count; i++)
			{
				if (joysticks[i].id == joystickId)
				{
					return joysticks[i].fileGuid;
				}
			}
			return string.Empty;
		}

		internal bool SfyAhBSYWWhcSTiEKWWxnXYvQGK(ControllerMap_Editor P_0, HardwareJoystickMap P_1, Guid P_2, out string P_3)
		{
			if (P_0 == null)
			{
				P_3 = "Template Map was null.";
				return false;
			}
			P_0.hardwareGuidString = P_2.ToString();
			Entry entry = UHzLoQtWuAoHLAFsVljNrYZrrEC(P_2);
			if (entry == null)
			{
				P_3 = string.Concat("Hardware guid not found in ControllerDataFiles: ", P_2, "\nThis error should never happen. Please contact support.");
				return false;
			}
			List<ActionElementMap> actionElementMaps = P_0.actionElementMaps;
			using (TempListPool.TList<ActionElementMap> tList = TempListPool.GetTList<ActionElementMap>())
			{
				List<ActionElementMap> list = tList.list;
				using (TempListPool.TList<ElementIdentifierMap> tList2 = TempListPool.GetTList<ElementIdentifierMap>())
				{
					List<ElementIdentifierMap> list2 = tList2.list;
					for (int i = 0; i < actionElementMaps.Count; i++)
					{
						list2.Clear();
						ActionElementMap actionElementMap = actionElementMaps[i];
						int elementIdentifierId = actionElementMap._elementIdentifierId;
						entry.GetElementIdentifierMaps(elementIdentifierId, list2);
						for (int j = 0; j < list2.Count; j++)
						{
							ElementIdentifierMap elementIdentifierMap = list2[j];
							if (elementIdentifierMap == null || elementIdentifierMap.joystickId < 0)
							{
								continue;
							}
							ActionElementMap actionElementMap2 = new ActionElementMap(actionElementMap);
							ActionElementMap actionElementMap3 = null;
							bool flag = false;
							int num = zrDKDHzHNnENLEVxsZEFNhRJoWDo(elementIdentifierId);
							if (num >= 0 && num < elementIdentifiers.Length)
							{
								ControllerElementIdentifier elementIdentifier = P_1.GetElementIdentifier(elementIdentifierMap.joystickId);
								ControllerTemplateElementIdentifier_Editor controllerTemplateElementIdentifier_Editor = elementIdentifiers[num];
								if (elementIdentifier != null && controllerTemplateElementIdentifier_Editor != null)
								{
									ControllerTemplateElementType effectiveElementType = controllerTemplateElementIdentifier_Editor.effectiveElementType;
									if (!BbpfTcGSZRHmltstKOfXrucHPJO.sRrGplMHNlzmCBfgKNqGViUdGhN(effectiveElementType, elementIdentifier.elementType))
									{
										if (effectiveElementType == ControllerTemplateElementType.Axis && elementIdentifier.elementType == ControllerElementType.Button)
										{
											if (elementIdentifierMap.splitAxis)
											{
												if (actionElementMap2.axisType == AxisType.Normal && actionElementMap2._axisRange == AxisRange.Full)
												{
													actionElementMap3 = new ActionElementMap(actionElementMap2);
													actionElementMap3._elementType = ControllerElementType.Button;
													actionElementMap3._elementIdentifierId = elementIdentifierMap.joystickId2;
													if (actionElementMap2._invert)
													{
														actionElementMap2._axisContribution = Pole.Negative;
														actionElementMap3._axisContribution = Pole.Positive;
													}
													else
													{
														actionElementMap2._axisContribution = Pole.Positive;
														actionElementMap3._axisContribution = Pole.Negative;
													}
												}
												else if (actionElementMap2.axisType == AxisType.Split)
												{
													if (actionElementMap2._axisRange == AxisRange.Positive)
													{
														actionElementMap2._elementIdentifierId = elementIdentifierMap.joystickId;
													}
													else if (actionElementMap2._axisRange == AxisRange.Negative)
													{
														actionElementMap2._elementIdentifierId = elementIdentifierMap.joystickId2;
													}
													flag = true;
												}
											}
											actionElementMap2._elementType = ControllerElementType.Button;
										}
										else
										{
											if (effectiveElementType != ControllerTemplateElementType.Button || elementIdentifier.elementType != 0)
											{
												throw new NotImplementedException();
											}
											actionElementMap2._axisRange = AxisRange.Positive;
											actionElementMap2._elementType = ControllerElementType.Axis;
										}
									}
								}
							}
							if (!flag)
							{
								actionElementMap2._elementIdentifierId = elementIdentifierMap.joystickId;
							}
							list.Add(actionElementMap2);
							if (actionElementMap3 != null)
							{
								list.Add(actionElementMap3);
							}
						}
					}
				}
				actionElementMaps.Clear();
				ListTools.CopyTo(list, actionElementMaps);
			}
			P_3 = null;
			return true;
		}

		internal ControllerTemplateElementIdentifier CmSKuWHNjixLGRzLinrqxfVeCrT(Guid P_0, int P_1)
		{
			if (P_0 == Guid.Empty || P_1 < 0)
			{
				return null;
			}
			if (joysticks == null)
			{
				return null;
			}
			int num = -1;
			for (int i = 0; i < joysticks.Count; i++)
			{
				if (joysticks[i] != null && joysticks[i].JoystickGuid == P_0)
				{
					num = i;
					break;
				}
			}
			if (num < 0)
			{
				return null;
			}
			Entry entry = joysticks[num];
			if (entry == null)
			{
				return null;
			}
			int templateElementId = entry.GetTemplateElementId(P_1);
			if (templateElementId < 0)
			{
				return null;
			}
			return GetElementIdentifier(templateElementId);
		}

		[CustomObfuscation(rename = false)]
		internal SpecialElementEntry[] GetSpecialElementsOrig()
		{
			return specialElements;
		}

		private Entry UHzLoQtWuAoHLAFsVljNrYZrrEC(Guid P_0)
		{
			if (joysticks == null)
			{
				return null;
			}
			for (int i = 0; i < joysticks.Count; i++)
			{
				if (joysticks[i].JoystickGuid == P_0)
				{
					return joysticks[i];
				}
			}
			return null;
		}

		private int zrDKDHzHNnENLEVxsZEFNhRJoWDo(int P_0)
		{
			if (elementIdentifiers == null)
			{
				return -1;
			}
			for (int i = 0; i < elementIdentifiers.Length; i++)
			{
				if (elementIdentifiers[i].id == P_0)
				{
					return i;
				}
			}
			return -1;
		}

		private IControllerElementIdentifierCommon_Internal FWTpugPSQTMvKDrqegMfFqzEdnQC(int P_0)
		{
			return GetElementIdentifier(P_0);
		}

		IControllerElementIdentifierCommon_Internal IHardwareControllerMap_Internal.GetElementIdentifier(int P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in FWTpugPSQTMvKDrqegMfFqzEdnQC
			return this.FWTpugPSQTMvKDrqegMfFqzEdnQC(P_0);
		}

		private int psJlWvUrJqsnCsctAfhsFPKZlph()
		{
			if (elementIdentifiers == null)
			{
				return 0;
			}
			return elementIdentifiers.Length;
		}

		int IHardwareControllerTemplateMap_Internal.GetElementIdentifierCount()
		{
			//ILSpy generated this explicit interface implementation from .override directive in psJlWvUrJqsnCsctAfhsFPKZlph
			return this.psJlWvUrJqsnCsctAfhsFPKZlph();
		}

		private IControllerTemplateElementIdentifier otBoomaZkBhHpgdTcFoaMXedJxf(int P_0)
		{
			if (elementIdentifiers == null)
			{
				return null;
			}
			return elementIdentifiers[P_0];
		}

		IControllerTemplateElementIdentifier IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifier(int P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in otBoomaZkBhHpgdTcFoaMXedJxf
			return this.otBoomaZkBhHpgdTcFoaMXedJxf(P_0);
		}

		private IControllerTemplateElementIdentifier XtRLqZmbxTClpwldZaXsUyyqqZe(int P_0)
		{
			return GetElementIdentifier(P_0);
		}

		IControllerTemplateElementIdentifier IHardwareControllerTemplateMap_Internal.GetTemplateElementIdentifierById(int P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in XtRLqZmbxTClpwldZaXsUyyqqZe
			return this.XtRLqZmbxTClpwldZaXsUyyqqZe(P_0);
		}

		private IControllerTemplateMapSpecialElement_Internal obiWHXrKiOecPsDaODhtBsAcVxI(int P_0)
		{
			if (specialElements == null)
			{
				return null;
			}
			for (int i = 0; i < specialElements.Length; i++)
			{
				if (specialElements[i] != null && specialElements[i].elementIdentifierId == P_0)
				{
					return specialElements[i];
				}
			}
			return null;
		}

		IControllerTemplateMapSpecialElement_Internal IHardwareControllerTemplateMap_Internal.GetSpecialTemplateElementByElementIdentifierId(int P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in obiWHXrKiOecPsDaODhtBsAcVxI
			return this.obiWHXrKiOecPsDaODhtBsAcVxI(P_0);
		}

		private UsMQnVXJOgAELSCkvEBzkFdKjFNq QxRCpFYNfFoBBpoEDTnDIiKVhAh(Controller P_0, int P_1)
		{
			ControllerTemplateElementIdentifier elementIdentifier = GetElementIdentifier(P_1);
			if (elementIdentifier == null)
			{
				return null;
			}
			if (elementIdentifier.elementType != 0)
			{
				return null;
			}
			if (P_0 == null)
			{
				return null;
			}
			Entry entry = UHzLoQtWuAoHLAFsVljNrYZrrEC(P_0.cBbvDblDdxYvWIffImKZKlfGJPE);
			if (entry == null)
			{
				return null;
			}
			List<ElementIdentifierMap> elementIdentifierMappings = entry.elementIdentifierMappings;
			if (elementIdentifierMappings == null)
			{
				return null;
			}
			int count = elementIdentifierMappings.Count;
			for (int i = 0; i < count; i++)
			{
				ElementIdentifierMap elementIdentifierMap = elementIdentifierMappings[i];
				if (elementIdentifierMap != null && elementIdentifierMap.templateId == P_1)
				{
					if (elementIdentifierMap.splitAxis)
					{
						return new UsMQnVXJOgAELSCkvEBzkFdKjFNq(ControllerTemplateElementType.Axis, splitAxis: true, new bjWEjHBROAVpeyUanBwIblyUmUNK(P_0, -1, AxisRange.Full), new bjWEjHBROAVpeyUanBwIblyUmUNK(P_0, elementIdentifierMap.joystickId, AxisRange.Positive), new bjWEjHBROAVpeyUanBwIblyUmUNK(P_0, elementIdentifierMap.joystickId2, AxisRange.Positive));
					}
					return new UsMQnVXJOgAELSCkvEBzkFdKjFNq(ControllerTemplateElementType.Axis, splitAxis: false, new bjWEjHBROAVpeyUanBwIblyUmUNK(P_0, elementIdentifierMap.joystickId, AxisRange.Full), new bjWEjHBROAVpeyUanBwIblyUmUNK(P_0, -1, AxisRange.Positive), new bjWEjHBROAVpeyUanBwIblyUmUNK(P_0, -1, AxisRange.Positive));
				}
			}
			return null;
		}

		UsMQnVXJOgAELSCkvEBzkFdKjFNq IHardwareControllerTemplateMap_Internal.GetAxisTarget(Controller P_0, int P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in QxRCpFYNfFoBBpoEDTnDIiKVhAh
			return this.QxRCpFYNfFoBBpoEDTnDIiKVhAh(P_0, P_1);
		}

		private UsMQnVXJOgAELSCkvEBzkFdKjFNq dmTVStbMDdHfbpCoHMNIBSvnOqi(Controller P_0, int P_1)
		{
			ControllerTemplateElementIdentifier elementIdentifier = GetElementIdentifier(P_1);
			if (elementIdentifier == null)
			{
				return null;
			}
			if (elementIdentifier.elementType != ControllerTemplateElementType.Button)
			{
				return null;
			}
			if (P_0 == null)
			{
				return null;
			}
			Entry entry = UHzLoQtWuAoHLAFsVljNrYZrrEC(P_0.cBbvDblDdxYvWIffImKZKlfGJPE);
			if (entry == null)
			{
				return null;
			}
			List<ElementIdentifierMap> elementIdentifierMappings = entry.elementIdentifierMappings;
			if (elementIdentifierMappings == null)
			{
				return null;
			}
			int count = elementIdentifierMappings.Count;
			for (int i = 0; i < count; i++)
			{
				ElementIdentifierMap elementIdentifierMap = elementIdentifierMappings[i];
				if (elementIdentifierMap != null && elementIdentifierMap.templateId == P_1)
				{
					return new UsMQnVXJOgAELSCkvEBzkFdKjFNq(ControllerTemplateElementType.Button, splitAxis: false, new bjWEjHBROAVpeyUanBwIblyUmUNK(P_0, elementIdentifierMap.joystickId, AxisRange.Full), new bjWEjHBROAVpeyUanBwIblyUmUNK(P_0, -1, AxisRange.Positive), new bjWEjHBROAVpeyUanBwIblyUmUNK(P_0, -1, AxisRange.Positive));
				}
			}
			return null;
		}

		UsMQnVXJOgAELSCkvEBzkFdKjFNq IHardwareControllerTemplateMap_Internal.GetButtonTarget(Controller P_0, int P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in dmTVStbMDdHfbpCoHMNIBSvnOqi
			return this.dmTVStbMDdHfbpCoHMNIBSvnOqi(P_0, P_1);
		}
	}
}
