using System;
using System.Collections.Generic;
using System.ComponentModel;
using Rewired.Data.Mapping;
using Rewired.Utils;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public sealed class CustomController_Editor
	{
		[Serializable]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public abstract class Element
		{
			public int elementIdentifierId;

			public string name;

			public Element()
			{
			}

			public Element(string name, int elementIdentifierId)
			{
				this.name = name;
				this.elementIdentifierId = elementIdentifierId;
			}

			public abstract Element Clone();
		}

		[Serializable]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public sealed class Button : Element
		{
			public Button()
			{
			}

			public Button(string name)
				: base(name, -1)
			{
			}

			public Button(string name, int elementIdentifierId)
				: base(name, elementIdentifierId)
			{
			}

			public Button(Button source)
				: base(source.name, source.elementIdentifierId)
			{
			}

			public override Element Clone()
			{
				return new Button(this);
			}
		}

		[Serializable]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public sealed class Axis : Element
		{
			public AxisRange range;

			public bool invert;

			public float deadZone;

			public float zero;

			public float min;

			public float max;

			public bool doNotCalibrateRange;

			public AxisSensitivityType sensitivityType;

			public float sensitivity = 1f;

			public AnimationCurve sensitivityCurve;

			public HardwareAxisInfo axisInfo = HardwareAxisInfo.Default;

			public Axis()
			{
			}

			public Axis(string name)
				: base(name, -1)
			{
				range = AxisRange.Full;
				invert = false;
				deadZone = 0f;
				zero = 0f;
				min = -1f;
				max = 1f;
				sensitivity = 1f;
				sensitivityType = AxisSensitivityType.Multiplier;
				sensitivityCurve = AnimationCurve.Linear(-1f, 1f, 1f, 1f);
				axisInfo = new HardwareAxisInfo(AxisCoordinateMode.Absolute, excludeFromPolling: false, -1f, SpecialAxisType.None);
			}

			[Obsolete("This constructor should not longer be used.", false)]
			public Axis(string name, string positiveName, string negativeName, int elementIdentifierId, AxisRange range, bool invert, float deadZone, float zero, float min, float max, bool doNotCalibrateRange, HardwareAxisInfo axisInfo)
				: base(name, elementIdentifierId)
			{
				this.range = range;
				this.invert = invert;
				this.deadZone = deadZone;
				this.zero = zero;
				this.min = min;
				this.max = max;
				this.doNotCalibrateRange = doNotCalibrateRange;
				this.axisInfo = MiscTools.DeepClone(axisInfo) ?? HardwareAxisInfo.Default;
				sensitivity = 1f;
				sensitivityType = AxisSensitivityType.Multiplier;
				sensitivityCurve = AnimationCurve.Linear(-1f, 1f, 1f, 1f);
			}

			public Axis(Axis source)
				: base(source.name, source.elementIdentifierId)
			{
				range = source.range;
				invert = source.invert;
				deadZone = source.deadZone;
				zero = source.zero;
				min = source.min;
				max = source.max;
				doNotCalibrateRange = source.doNotCalibrateRange;
				sensitivity = source.sensitivity;
				sensitivityType = source.sensitivityType;
				sensitivityCurve = UnityTools.Copy(source.sensitivityCurve);
				axisInfo = MiscTools.DeepClone(source.axisInfo) ?? HardwareAxisInfo.Default;
			}

			public override Element Clone()
			{
				return new Axis(this);
			}
		}

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private string _name;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private string _descriptiveName;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private int _id;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private string _typeGuidString;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private List<ControllerElementIdentifier> _elementIdentifiers;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private List<Axis> _axes;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private List<Button> _buttons;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private int _elementIdentifierIdCounter;

		public string name
		{
			get
			{
				return _name;
			}
			internal set
			{
				_name = value;
			}
		}

		public string descriptiveName
		{
			get
			{
				return _descriptiveName;
			}
			internal set
			{
				_descriptiveName = value;
			}
		}

		public int id
		{
			get
			{
				return _id;
			}
			internal set
			{
				_id = value;
			}
		}

		public Guid typeGuid
		{
			get
			{
				return StringTools.ToGuid(_typeGuidString);
			}
			internal set
			{
				_typeGuidString = value.ToString();
			}
		}

		internal string typeGuidString
		{
			get
			{
				return _typeGuidString;
			}
			set
			{
				_typeGuidString = value;
			}
		}

		public List<ControllerElementIdentifier> elementIdentifiers
		{
			get
			{
				return _elementIdentifiers;
			}
			internal set
			{
				_elementIdentifiers = value;
			}
		}

		public List<Axis> axes => _axes;

		public List<Button> buttons => _buttons;

		public int buttonCount
		{
			get
			{
				if (buttons == null)
				{
					return 0;
				}
				return buttons.Count;
			}
		}

		public int axisCount
		{
			get
			{
				if (axes == null)
				{
					return 0;
				}
				return axes.Count;
			}
		}

		public IEnumerable<ControllerElementIdentifier> ElementIdentifiers
		{
			get
			{
				if (_elementIdentifiers != null)
				{
					for (int i = 0; i < _elementIdentifiers.Count; i++)
					{
						yield return _elementIdentifiers[i];
					}
				}
			}
		}

		public CustomController_Editor()
		{
			_axes = new List<Axis>();
			_buttons = new List<Button>();
			_elementIdentifiers = new List<ControllerElementIdentifier>();
		}

		public CustomController_Editor(CustomController_Editor source)
		{
			_name = source._name;
			_descriptiveName = source._descriptiveName;
			_id = source._id;
			_typeGuidString = source._typeGuidString;
			if (source._elementIdentifiers != null)
			{
				_elementIdentifiers = new List<ControllerElementIdentifier>(source._elementIdentifiers.Count);
				for (int i = 0; i < source._elementIdentifiers.Count; i++)
				{
					_elementIdentifiers.Add(source._elementIdentifiers[i].Clone());
				}
			}
			if (source._axes != null)
			{
				_axes = new List<Axis>(source._axes.Count);
				for (int j = 0; j < source._axes.Count; j++)
				{
					_axes.Add((Axis)source._axes[j].Clone());
				}
			}
			if (source._buttons != null)
			{
				_buttons = new List<Button>(source._buttons.Count);
				for (int k = 0; k < source._buttons.Count; k++)
				{
					_buttons.Add((Button)source._buttons[k].Clone());
				}
			}
			_elementIdentifierIdCounter = source._elementIdentifierIdCounter;
		}

		public CustomController_Editor Clone()
		{
			return new CustomController_Editor(this);
		}

		public string[] GetElementIdentifierNames()
		{
			int num = ((_elementIdentifiers != null) ? _elementIdentifiers.Count : 0);
			string[] array = new string[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = _elementIdentifiers[i].name;
			}
			return array;
		}

		public int[] GetElementIdentifierIds()
		{
			int num = ((_elementIdentifiers != null) ? _elementIdentifiers.Count : 0);
			int[] array = new int[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = _elementIdentifiers[i].id;
			}
			return array;
		}

		public string[] GetElementIdentifierNamesTypeSorted()
		{
			List<string> list = new List<string>();
			List<string> list2 = new List<string>();
			int num = axisCount;
			for (int i = 0; i < num; i++)
			{
				int num2 = IndexOfElementIdentifier(axes[i].elementIdentifierId);
				if (num2 >= 0)
				{
					list2.Add(_elementIdentifiers[num2].name);
				}
			}
			int num3 = buttonCount;
			for (int j = 0; j < num3; j++)
			{
				int num4 = IndexOfElementIdentifier(buttons[j].elementIdentifierId);
				if (num4 >= 0)
				{
					list.Add(_elementIdentifiers[num4].name);
				}
			}
			List<string> list3 = ListTools.Combine(list2, list);
			return list3.ToArray();
		}

		public int[] GetElementIdentifierIdsTypeSorted()
		{
			List<int> list = new List<int>();
			List<int> list2 = new List<int>();
			int num = axisCount;
			for (int i = 0; i < num; i++)
			{
				list2.Add(axes[i].elementIdentifierId);
			}
			int num2 = buttonCount;
			for (int j = 0; j < num2; j++)
			{
				list.Add(buttons[j].elementIdentifierId);
			}
			List<int> list3 = ListTools.Combine(list2, list);
			return list3.ToArray();
		}

		public ControllerElementIdentifier[] GetElementIdentifiersTypeSorted()
		{
			List<ControllerElementIdentifier> list = new List<ControllerElementIdentifier>();
			List<ControllerElementIdentifier> list2 = new List<ControllerElementIdentifier>();
			int num = axisCount;
			for (int i = 0; i < num; i++)
			{
				int num2 = IndexOfElementIdentifier(axes[i].elementIdentifierId);
				if (num2 >= 0)
				{
					list2.Add(_elementIdentifiers[num2]);
				}
			}
			int num3 = buttonCount;
			for (int j = 0; j < num3; j++)
			{
				int num4 = IndexOfElementIdentifier(buttons[j].elementIdentifierId);
				if (num4 >= 0)
				{
					list.Add(_elementIdentifiers[num4]);
				}
			}
			List<ControllerElementIdentifier> list3 = ListTools.Combine(list2, list);
			return list3.ToArray();
		}

		public bool ContainsElementIdentifier(int id)
		{
			int num = ((_elementIdentifiers != null) ? _elementIdentifiers.Count : 0);
			for (int i = 0; i < num; i++)
			{
				if (_elementIdentifiers[i].id == id)
				{
					return true;
				}
			}
			return false;
		}

		public int IndexOfElementIdentifier(int id)
		{
			int num = ((_elementIdentifiers != null) ? _elementIdentifiers.Count : 0);
			for (int i = 0; i < num; i++)
			{
				if (_elementIdentifiers[i].id == id)
				{
					return i;
				}
			}
			return -1;
		}

		public ControllerElementIdentifier GetElementIdentifier(int id)
		{
			int num = IndexOfElementIdentifier(id);
			if (num < 0)
			{
				return null;
			}
			return _elementIdentifiers[num];
		}

		internal ControllerElementType JiCzfzGPtnuMezIXHxYzDgUoLaW(int P_0)
		{
			ControllerElementIdentifier elementIdentifier = GetElementIdentifier(P_0);
			if (elementIdentifier == null)
			{
				return ControllerElementType.Axis;
			}
			for (int i = 0; i < axisCount; i++)
			{
				if (axes[i].elementIdentifierId == elementIdentifier.id)
				{
					return ControllerElementType.Axis;
				}
			}
			for (int j = 0; j < buttonCount; j++)
			{
				if (buttons[j].elementIdentifierId == elementIdentifier.id)
				{
					return ControllerElementType.Button;
				}
			}
			return elementIdentifier.elementType;
		}

		internal bool FeSFLeUPmWPnNlIHjDvPOUFbwUd(int P_0, out AxisRange P_1)
		{
			ControllerElementIdentifier elementIdentifier = GetElementIdentifier(P_0);
			if (elementIdentifier == null)
			{
				P_1 = AxisRange.Full;
				return false;
			}
			for (int i = 0; i < axisCount; i++)
			{
				if (axes[i].elementIdentifierId == elementIdentifier.id)
				{
					P_1 = axes[i].range;
					if (axes[i].invert)
					{
						P_1 = InputTools.InvertAxisRange(P_1);
					}
					return true;
				}
			}
			P_1 = AxisRange.Full;
			return false;
		}

		public string[] GetButtonNames()
		{
			int num = ((_buttons != null) ? _buttons.Count : 0);
			string[] array = new string[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = _buttons[i].name;
			}
			return array;
		}

		public int[] GetButtonElementIdentifierIds()
		{
			int num = ((_buttons != null) ? _buttons.Count : 0);
			int[] array = new int[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = _buttons[i].elementIdentifierId;
			}
			return array;
		}

		public string[] GetAxisNames()
		{
			int num = ((_axes != null) ? _axes.Count : 0);
			string[] array = new string[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = _axes[i].name;
			}
			return array;
		}

		public int[] GetAxisElementIdentifierIds()
		{
			int num = ((_axes != null) ? _axes.Count : 0);
			int[] array = new int[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = _axes[i].elementIdentifierId;
			}
			return array;
		}

		public string[] GetElementNames<T>() where T : Element
		{
			if (object.ReferenceEquals(typeof(T), typeof(Axis)))
			{
				return GetAxisNames();
			}
			if (object.ReferenceEquals(typeof(T), typeof(Button)))
			{
				return GetButtonNames();
			}
			throw new NotImplementedException();
		}

		public string[] GetElementNames(ControllerElementType type)
		{
			return type switch
			{
				ControllerElementType.Axis => GetAxisNames(), 
				ControllerElementType.Button => GetButtonNames(), 
				_ => throw new NotImplementedException(), 
			};
		}

		public int[] GetElementElementIdentifierIds(ControllerElementType type)
		{
			return type switch
			{
				ControllerElementType.Axis => GetAxisElementIdentifierIds(), 
				ControllerElementType.Button => GetButtonElementIdentifierIds(), 
				_ => throw new NotImplementedException(), 
			};
		}

		public T GetElement<T>(int index) where T : Element
		{
			if (index < 0)
			{
				return null;
			}
			if (object.ReferenceEquals(typeof(T), typeof(Axis)))
			{
				if (index >= axisCount)
				{
					return null;
				}
				return _axes[index] as T;
			}
			if (object.ReferenceEquals(typeof(T), typeof(Button)))
			{
				if (index >= buttonCount)
				{
					return null;
				}
				return _buttons[index] as T;
			}
			throw new NotImplementedException();
		}

		public void AddElement(ControllerElementType type)
		{
			if (type == ControllerElementType.Axis)
			{
				AddAxis();
			}
			else
			{
				AddButton();
			}
		}

		public void AddAxis()
		{
			axes.Add((Axis)lQMIqlTWuuXJLaCYILcHqOlLBRC(ControllerElementType.Axis));
		}

		public void AddButton()
		{
			buttons.Add((Button)lQMIqlTWuuXJLaCYILcHqOlLBRC(ControllerElementType.Button));
		}

		public void InsertElement(ControllerElementType type, int index)
		{
			if (type == ControllerElementType.Axis)
			{
				InsertAxis(index);
			}
			else
			{
				InsertButton(index);
			}
		}

		public void InsertAxis(int index)
		{
			if (index < 0 || index >= axes.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			axes.Insert(index, (Axis)lQMIqlTWuuXJLaCYILcHqOlLBRC(ControllerElementType.Axis));
		}

		public void InsertButton(int index)
		{
			if (index < 0 || index >= buttons.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			buttons.Insert(index, (Button)lQMIqlTWuuXJLaCYILcHqOlLBRC(ControllerElementType.Button));
		}

		public void DeleteElement(ControllerElementType type, int index)
		{
			switch (type)
			{
			case ControllerElementType.Axis:
				DeleteElement<Axis>(index);
				break;
			case ControllerElementType.Button:
				DeleteElement<Button>(index);
				break;
			default:
				throw new NotImplementedException();
			}
		}

		public void DeleteElement<T>(int index) where T : Element
		{
			if (index < 0)
			{
				return;
			}
			T val;
			if (object.ReferenceEquals(typeof(T), typeof(Axis)))
			{
				if (index >= axisCount)
				{
					return;
				}
				val = _axes[index] as T;
				_axes.RemoveAt(index);
			}
			else
			{
				if (!object.ReferenceEquals(typeof(T), typeof(Button)))
				{
					throw new NotImplementedException();
				}
				if (index >= buttonCount)
				{
					return;
				}
				val = _buttons[index] as T;
				_buttons.RemoveAt(index);
			}
			if (_elementIdentifiers == null)
			{
				return;
			}
			for (int num = _elementIdentifiers.Count - 1; num >= 0; num--)
			{
				if (_elementIdentifiers[num].id == val.elementIdentifierId)
				{
					_elementIdentifiers.RemoveAt(num);
				}
			}
		}

		public bool ReorderElement(ControllerElementType type, int index, bool offsetDown, bool offsetNow)
		{
			switch (type)
			{
			case ControllerElementType.Axis:
			{
				List<Axis> list2 = _axes;
				if (list2 == null || index < 0 || index >= list2.Count)
				{
					return false;
				}
				return ListTools.OffsetAtIndex(list2, index, offsetDown, offsetNow);
			}
			case ControllerElementType.Button:
			{
				List<Button> list = _buttons;
				if (list == null || index < 0 || index >= list.Count)
				{
					return false;
				}
				return ListTools.OffsetAtIndex(list, index, offsetDown, offsetNow);
			}
			default:
				throw new NotImplementedException();
			}
		}

		public void DuplicateElement(ControllerElementType type, int index)
		{
			switch (type)
			{
			case ControllerElementType.Axis:
				oyJIXDujEmzyDJQcrpXqIrhsplE(index, axes);
				break;
			case ControllerElementType.Button:
				oyJIXDujEmzyDJQcrpXqIrhsplE(index, buttons);
				break;
			default:
				throw new NotImplementedException();
			}
		}

		private void oyJIXDujEmzyDJQcrpXqIrhsplE<T>(int P_0, List<T> P_1) where T : Element
		{
			if (P_1 == null || P_0 < 0 || P_0 >= P_1.Count)
			{
				throw new ArgumentOutOfRangeException("index");
			}
			T val = P_1[P_0];
			string text = StringTools.IterateName(val.name, -1, GetElementNames<T>());
			ControllerElementIdentifier controllerElementIdentifier = pCbzwGReiHKvtHoBOJHFhsJrZlx(val.elementIdentifierId, text);
			if (controllerElementIdentifier == null)
			{
				Logger.LogError("Element identifier is missing! Element cannot be duplicated!");
				return;
			}
			T val2 = (T)val.Clone();
			val2.elementIdentifierId = controllerElementIdentifier.id;
			val2.name = text;
			if (P_0 == P_1.Count - 1)
			{
				P_1.Add(val2);
			}
			else
			{
				P_1.Insert(P_0 + 1, val2);
			}
		}

		private ControllerElementIdentifier pCbzwGReiHKvtHoBOJHFhsJrZlx(int P_0, string P_1)
		{
			if (!ContainsElementIdentifier(P_0))
			{
				return null;
			}
			int num = IndexOfElementIdentifier(P_0);
			int elementIdentifierIdCounter = _elementIdentifierIdCounter;
			_elementIdentifierIdCounter++;
			ControllerElementIdentifier controllerElementIdentifier = new ControllerElementIdentifier(elementIdentifierIdCounter, P_1, _elementIdentifiers[num].positiveName, _elementIdentifiers[num].negativeName, _elementIdentifiers[num].elementType, _elementIdentifiers[num].compoundElementType, _elementIdentifiers[num].isMappableOnPlatform);
			if (num == _elementIdentifiers.Count - 1)
			{
				_elementIdentifiers.Add(controllerElementIdentifier);
			}
			else
			{
				_elementIdentifiers.Insert(num + 1, controllerElementIdentifier);
			}
			return controllerElementIdentifier;
		}

		private Element lQMIqlTWuuXJLaCYILcHqOlLBRC(ControllerElementType P_0)
		{
			switch (P_0)
			{
			case ControllerElementType.Axis:
			{
				string text2 = StringTools.IterateName("Axis", -1, GetAxisNames());
				ControllerElementIdentifier controllerElementIdentifier2 = wZIpyKtwzEBwAJaClBOYKXmQbQOh(P_0, text2, string.Empty, string.Empty);
				Axis axis = new Axis(text2);
				axis.elementIdentifierId = controllerElementIdentifier2.id;
				return axis;
			}
			case ControllerElementType.Button:
			{
				string text = StringTools.IterateName("Button", -1, GetButtonNames());
				ControllerElementIdentifier controllerElementIdentifier = wZIpyKtwzEBwAJaClBOYKXmQbQOh(P_0, text, string.Empty, string.Empty);
				Button button = new Button(text);
				button.elementIdentifierId = controllerElementIdentifier.id;
				return button;
			}
			default:
				throw new NotImplementedException();
			}
		}

		private ControllerElementIdentifier wZIpyKtwzEBwAJaClBOYKXmQbQOh(ControllerElementType P_0, string P_1, string P_2, string P_3)
		{
			int elementIdentifierIdCounter = _elementIdentifierIdCounter;
			_elementIdentifierIdCounter++;
			ControllerElementIdentifier controllerElementIdentifier = new ControllerElementIdentifier(elementIdentifierIdCounter, P_1, P_2, P_3, P_0, isMappableOnPlatform: true);
			_elementIdentifiers.Add(controllerElementIdentifier);
			return controllerElementIdentifier;
		}

		internal HardwareControllerMap_Game qEYKqHdCkIFmZIOUZoOJxsUkurRn()
		{
			int num = axisCount;
			int num2 = buttonCount;
			int[] array = new int[num2];
			int[] array2 = new int[num];
			AxisCalibrationData[] array3 = new AxisCalibrationData[num];
			AxisRange[] array4 = new AxisRange[num];
			HardwareAxisInfo[] array5 = new HardwareAxisInfo[num];
			HardwareButtonInfo[] array6 = new HardwareButtonInfo[num2];
			for (int i = 0; i < num2; i++)
			{
				array[i] = _buttons[i].elementIdentifierId;
				array6[i] = new HardwareButtonInfo();
			}
			for (int j = 0; j < num; j++)
			{
				array2[j] = _axes[j].elementIdentifierId;
				ref AxisCalibrationData reference = ref array3[j];
				reference = new AxisCalibrationData(enabled: true, _axes[j].deadZone, _axes[j].zero, _axes[j].min, _axes[j].max, _axes[j].invert, !_axes[j].doNotCalibrateRange, _axes[j].sensitivityType, _axes[j].sensitivity, UnityTools.Copy(_axes[j].sensitivityCurve));
				array4[j] = _axes[j].range;
				array5[j] = MiscTools.DeepClone(_axes[j].axisInfo) ?? HardwareAxisInfo.Default;
			}
			ControllerElementIdentifier[] elementIdentifiersTypeSorted = GetElementIdentifiersTypeSorted();
			return new HardwareControllerMap_Game(_name, _id, elementIdentifiersTypeSorted, array, array2, array3, array4, array5, array6, null);
		}
	}
}
