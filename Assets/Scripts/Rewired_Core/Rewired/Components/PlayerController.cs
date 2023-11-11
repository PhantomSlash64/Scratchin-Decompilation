using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired.Utils;
using Rewired.Utils.Attributes;
using UnityEngine;
using UnityEngine.Events;

namespace Rewired.Components
{
	[Serializable]
	[AddComponentMenu("Rewired/Player Controller")]
	public class PlayerController : ComponentWrapper<Rewired.PlayerController>, IPlayerController
	{
		[Serializable]
		public class ButtonStateChangedHandler : UnityEvent<int, bool>
		{
		}

		[Serializable]
		public class AxisValueChangedHandler : UnityEvent<int, float>
		{
		}

		[Serializable]
		public class EnabledStateChangedHandler : UnityEvent<bool>
		{
		}

		[Serializable]
		[CustomObfuscation(rename = false)]
		[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
		internal sealed class ElementWithSourceInfo
		{
			[SerializeField]
			[Tooltip("The name of the element.")]
			private string _name;

			[Tooltip("The element type.")]
			[SerializeField]
			private Rewired.PlayerController.Element.TypeWithSource _elementType;

			[Tooltip("Is this element enabled? Disabled elements return no value.")]
			[SerializeField]
			private bool _enabled = true;

			[SerializeField]
			[Tooltip("The Action id of the Action which will be used as the input source for the Element.")]
			private int _actionId = -1;

			[Tooltip("The output coordinate mode of the axis. An Absolute axis will only return value for input received from Absolute sources. A Relative axis will return value for input received from both Relative and Absolute sources. When converting from an Absolute input source to a Relative output, absoluteToRelativeSensitivity will be multiplied by the Absolute value to yield a simulated Relative value.")]
			[SerializeField]
			private AxisCoordinateMode _coordinateMode;

			[SerializeField]
			[Tooltip("The absolute to relative sensitivity multiplier. This is only applied when the axis coordinate mode is set to Relative and the axis receives Absolute coordinate mode input (joystick axes, keyboard keys, etc.).")]
			[FieldRange(0f, float.MaxValue)]
			private float _absoluteToRelativeSensitivity = 1f;

			[Tooltip("The number of times per second the wheel ticks when the value source is an absolute axis value.")]
			[FieldRange(0f, float.MaxValue)]
			[SerializeField]
			private float _repeatRate = 4f;

			public string name
			{
				get
				{
					return _name;
				}
				set
				{
					_name = value;
				}
			}

			public Rewired.PlayerController.Element.TypeWithSource elementType
			{
				get
				{
					return _elementType;
				}
				set
				{
					_elementType = value;
				}
			}

			public bool enabled
			{
				get
				{
					return _enabled;
				}
				set
				{
					_enabled = value;
				}
			}

			public int actionId
			{
				get
				{
					return _actionId;
				}
				set
				{
					_actionId = value;
				}
			}

			public AxisCoordinateMode coordinateMode
			{
				get
				{
					return _coordinateMode;
				}
				set
				{
					_coordinateMode = value;
				}
			}

			public float absoluteSourceSensitivity
			{
				get
				{
					return _absoluteToRelativeSensitivity;
				}
				set
				{
					_absoluteToRelativeSensitivity = value;
				}
			}

			public float repeatRate
			{
				get
				{
					return _repeatRate;
				}
				set
				{
					_repeatRate = value;
				}
			}

			public Rewired.PlayerController.Element.Definition ToDefinition()
			{
				Rewired.PlayerController.Element.Definition definition = Rewired.PlayerController.Element.CreateDefinition((Rewired.PlayerController.Element.Type)elementType);
				if (definition is Rewired.PlayerController.ElementWithSource.Definition)
				{
					Rewired.PlayerController.ElementWithSource.Definition definition2 = (Rewired.PlayerController.ElementWithSource.Definition)definition;
					definition2.actionId = actionId;
				}
				if (definition is Rewired.PlayerController.Axis.Definition)
				{
					Rewired.PlayerController.Axis.Definition definition3 = (Rewired.PlayerController.Axis.Definition)definition;
					definition3.coordinateMode = coordinateMode;
					definition3.absoluteToRelativeSensitivity = absoluteSourceSensitivity;
				}
				if (definition is Rewired.PlayerController.MouseWheelAxis.Definition)
				{
					Rewired.PlayerController.MouseWheelAxis.Definition definition4 = (Rewired.PlayerController.MouseWheelAxis.Definition)definition;
					definition4.repeatRate = repeatRate;
				}
				definition.enabled = enabled;
				definition.name = name;
				return definition;
			}
		}

		[Serializable]
		[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
		[CustomObfuscation(rename = false)]
		internal sealed class ElementInfo
		{
			[SerializeField]
			[Tooltip("The name of the element.")]
			private string _name;

			[SerializeField]
			[Tooltip("The element type.")]
			private Rewired.PlayerController.Element.Type _elementType;

			[SerializeField]
			[Tooltip("Is this element enabled? Disabled elements return no value.")]
			private bool _enabled = true;

			[SerializeField]
			private ElementWithSourceInfo[] _elements = new ElementWithSourceInfo[0];

			public string name
			{
				get
				{
					return _name;
				}
				set
				{
					_name = value;
				}
			}

			public Rewired.PlayerController.Element.Type elementType
			{
				get
				{
					return _elementType;
				}
				set
				{
					_elementType = value;
				}
			}

			public bool enabled
			{
				get
				{
					return _enabled;
				}
				set
				{
					_enabled = value;
				}
			}

			public ElementWithSourceInfo[] elements
			{
				get
				{
					return _elements;
				}
				set
				{
					_elements = value;
				}
			}

			public Rewired.PlayerController.Element.Definition ToDefinition()
			{
				Rewired.PlayerController.Element.Definition definition = Rewired.PlayerController.Element.CreateDefinition(elementType);
				if (definition is Rewired.PlayerController.ElementWithSource.Definition)
				{
					if (_elements == null || _elements.Length == 0)
					{
						Logger.LogError("No element source was found for element with source definition.");
						return null;
					}
					Rewired.PlayerController.ElementWithSource.Definition definition2 = (Rewired.PlayerController.ElementWithSource.Definition)definition;
					definition2.name = _elements[0].name;
					definition2.enabled = _elements[0].enabled;
					definition2.actionId = _elements[0].actionId;
				}
				if (definition is Rewired.PlayerController.Axis.Definition)
				{
					Rewired.PlayerController.Axis.Definition definition3 = (Rewired.PlayerController.Axis.Definition)definition;
					definition3.coordinateMode = _elements[0].coordinateMode;
					definition3.absoluteToRelativeSensitivity = _elements[0].absoluteSourceSensitivity;
				}
				if (definition is Rewired.PlayerController.MouseWheelAxis.Definition)
				{
					Rewired.PlayerController.MouseWheelAxis.Definition definition4 = (Rewired.PlayerController.MouseWheelAxis.Definition)definition;
					definition4.repeatRate = _elements[0].repeatRate;
				}
				if (definition is Rewired.PlayerController.CompoundElement.Definition)
				{
					definition.name = name;
					definition.enabled = enabled;
					if (_elements == null || _elements.Length == 0)
					{
						Logger.LogError("No element source was found for element with source definition.");
						return null;
					}
					if (definition is Rewired.PlayerController.MouseWheel.Definition)
					{
						Rewired.PlayerController.MouseWheel.Definition definition5 = definition as Rewired.PlayerController.MouseWheel.Definition;
						try
						{
							if (_elements.Length >= 1)
							{
								definition5.xAxis = (Rewired.PlayerController.MouseWheelAxis.Definition)_elements[0].ToDefinition();
							}
							if (_elements.Length >= 2)
							{
								definition5.yAxis = (Rewired.PlayerController.MouseWheelAxis.Definition)_elements[1].ToDefinition();
								return definition;
							}
							return definition;
						}
						catch
						{
							Logger.LogError("Incorrect element source type found. Expecting MouseWheelAxis.");
							return null;
						}
					}
					if (definition is Rewired.PlayerController.Axis2D.Definition)
					{
						Rewired.PlayerController.Axis2D.Definition definition6 = definition as Rewired.PlayerController.Axis2D.Definition;
						try
						{
							if (_elements.Length >= 1)
							{
								definition6.xAxis = (Rewired.PlayerController.Axis.Definition)_elements[0].ToDefinition();
							}
							if (_elements.Length >= 2)
							{
								definition6.yAxis = (Rewired.PlayerController.Axis.Definition)_elements[1].ToDefinition();
								return definition;
							}
							return definition;
						}
						catch
						{
							Logger.LogError("Incorrect element source type found. Expecting Axis.");
							return null;
						}
					}
					throw new NotImplementedException();
				}
				return definition;
			}
		}

		[CustomObfuscation(rename = false)]
		[SerializeField]
		[Tooltip("(Optional) Link the Rewired Input Manager here for easier access to Action ids, Player ids, etc.")]
		private InputManager_Base _rewiredInputManager;

		[Tooltip("The Player id of the Player used for the source of input.")]
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private int _playerId = -1;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		[Tooltip("The elements that will be created in the controller.")]
		private List<ElementInfo> _elements = new List<ElementInfo>();

		[CustomObfuscation(rename = false)]
		[SerializeField]
		[Tooltip("Triggered the first frame the button is pressed or released.")]
		private ButtonStateChangedHandler _onButtonStateChanged = new ButtonStateChangedHandler();

		[SerializeField]
		[CustomObfuscation(rename = false)]
		[Tooltip("Triggered when the axis value changes.")]
		private AxisValueChangedHandler _onAxisValueChanged = new AxisValueChangedHandler();

		[SerializeField]
		[CustomObfuscation(rename = false)]
		[Tooltip("Triggered when the controller is enabled or disabled.")]
		private EnabledStateChangedHandler _onEnabledStateChanged = new EnabledStateChangedHandler();

		public int playerId
		{
			get
			{
				if (!base.initialized)
				{
					return _playerId;
				}
				return base.source.playerId;
			}
			set
			{
				if (ReInput.isReady && ReInput.players.GetPlayer(value) == null)
				{
					Logger.LogWarning("Player id " + value + " does not exist.");
					return;
				}
				_playerId = value;
				if (base.initialized)
				{
					base.source.playerId = value;
				}
			}
		}

		public IList<Rewired.PlayerController.Button> buttons
		{
			get
			{
				if (!base.initialized)
				{
					return EmptyObjects<Rewired.PlayerController.Button>.EmptyReadOnlyIListT;
				}
				return base.source.buttons;
			}
		}

		public IList<Rewired.PlayerController.Axis> axes
		{
			get
			{
				if (!base.initialized)
				{
					return EmptyObjects<Rewired.PlayerController.Axis>.EmptyReadOnlyIListT;
				}
				return base.source.axes;
			}
		}

		public IList<Rewired.PlayerController.Element> elements
		{
			get
			{
				if (!base.initialized)
				{
					return EmptyObjects<Rewired.PlayerController.Element>.EmptyReadOnlyIListT;
				}
				return base.source.elements;
			}
		}

		public int buttonCount
		{
			get
			{
				if (!base.initialized)
				{
					return 0;
				}
				return base.source.buttonCount;
			}
		}

		public int axisCount
		{
			get
			{
				if (!base.initialized)
				{
					return 0;
				}
				return base.source.axisCount;
			}
		}

		public int elementCount
		{
			get
			{
				if (!base.initialized)
				{
					return 0;
				}
				return base.source.elementCount;
			}
		}

		public event Action<int, bool> ButtonStateChangedEvent
		{
			add
			{
				if (base.initialized)
				{
					base.source.ButtonStateChangedEvent += value;
				}
			}
			remove
			{
				if (base.initialized)
				{
					base.source.ButtonStateChangedEvent -= value;
				}
			}
		}

		public event Action<int, float> AxisValueChangedEvent
		{
			add
			{
				if (base.initialized)
				{
					base.source.AxisValueChangedEvent += value;
				}
			}
			remove
			{
				if (base.initialized)
				{
					base.source.AxisValueChangedEvent -= value;
				}
			}
		}

		public event Action<bool> EnabledStateChangedEvent
		{
			add
			{
				if (base.initialized)
				{
					base.source.EnabledStateChangedEvent += value;
				}
			}
			remove
			{
				if (base.initialized)
				{
					base.source.EnabledStateChangedEvent -= value;
				}
			}
		}

		public bool GetButton(int index)
		{
			if (!base.initialized)
			{
				return false;
			}
			return base.source.GetButton(index);
		}

		public bool GetButtonDown(int index)
		{
			if (!base.initialized)
			{
				return false;
			}
			return base.source.GetButtonDown(index);
		}

		public bool GetButtonUp(int index)
		{
			if (!base.initialized)
			{
				return false;
			}
			return base.source.GetButtonUp(index);
		}

		public float GetAxis(int index)
		{
			if (!base.initialized)
			{
				return 0f;
			}
			return base.source.GetAxis(index);
		}

		public float GetAxisRaw(int index)
		{
			if (!base.initialized)
			{
				return 0f;
			}
			return base.source.GetAxisRaw(index);
		}

		public Rewired.PlayerController.Element GetElement(int index)
		{
			if (!base.initialized)
			{
				return null;
			}
			return base.source.GetElement(index);
		}

		public T GetElement<T>(int index) where T : Rewired.PlayerController.Element
		{
			if (!base.initialized)
			{
				return null;
			}
			return base.source.GetElement<T>(index);
		}

		protected override void OnAwake()
		{
			aGSywsUCbuxbHYKYlhTmZnpVGXJ();
			base.OnAwake();
		}

		protected override void OnAwakeFinished()
		{
			base.OnAwakeFinished();
			if (base.initialized)
			{
				AyaHiOQmIfIMuCVNOowHWXqWQuX(true);
			}
		}

		protected override void OnEnabled()
		{
			base.OnEnabled();
			if (base.initialized && ReInput.isReady)
			{
				base.source.enabled = true;
			}
		}

		protected override void OnDisabled()
		{
			base.OnDisabled();
			if (base.initialized && ReInput.isReady)
			{
				base.source.enabled = false;
			}
		}

		protected override void OnValidated()
		{
			base.OnValidated();
			playerId = _playerId;
			_playerId = playerId;
		}

		protected override void OnReset()
		{
			base.OnReset();
			_rewiredInputManager = null;
			_playerId = -1;
			_elements = new List<ElementInfo>();
			_onButtonStateChanged = new ButtonStateChangedHandler();
			_onAxisValueChanged = new AxisValueChangedHandler();
			_onEnabledStateChanged = new EnabledStateChangedHandler();
			aGSywsUCbuxbHYKYlhTmZnpVGXJ();
		}

		protected override void Subscribe()
		{
			base.Subscribe();
			if (base.source != null)
			{
				base.source.ButtonStateChangedEvent += SVGDTJQaceipTBrIIafMHoQFLUwR;
				base.source.AxisValueChangedEvent += bpolpxoeTDDDJApzKZFzruQYlpUb;
				base.source.EnabledStateChangedEvent += AyaHiOQmIfIMuCVNOowHWXqWQuX;
			}
		}

		protected override void Unsubscribe()
		{
			base.Unsubscribe();
			if (base.source != null)
			{
				base.source.ButtonStateChangedEvent -= SVGDTJQaceipTBrIIafMHoQFLUwR;
				base.source.AxisValueChangedEvent -= bpolpxoeTDDDJApzKZFzruQYlpUb;
				base.source.EnabledStateChangedEvent -= AyaHiOQmIfIMuCVNOowHWXqWQuX;
			}
		}

		protected override object GetCreateSourceArgs()
		{
			return _elements;
		}

		protected override Rewired.PlayerController CreateSource(object args)
		{
			IList<ElementInfo> list = args as IList<ElementInfo>;
			if (list == null || list.Count == 0)
			{
				Logger.LogWarning("Invalid element information. Did you configure elements in the inspector? Using defaults.");
				list = YxRgrLXbmvaCklVEwGtqSaKVFdoH();
			}
			List<Rewired.PlayerController.Element.Definition> list2 = new List<Rewired.PlayerController.Element.Definition>(list.Count);
			foreach (ElementInfo item in list)
			{
				list2.Add(item.ToDefinition());
			}
			Rewired.PlayerController.Definition definition = new Rewired.PlayerController.Definition();
			definition.playerId = _playerId;
			definition.elements = list2;
			return Rewired.PlayerController.Factory.Create(definition);
		}

		internal virtual List<ElementInfo> YxRgrLXbmvaCklVEwGtqSaKVFdoH()
		{
			List<ElementInfo> list = new List<ElementInfo>();
			list.Add(new ElementInfo
			{
				name = "Stick",
				elementType = Rewired.PlayerController.Element.Type.Axis2D,
				elements = new ElementWithSourceInfo[2]
				{
					new ElementWithSourceInfo
					{
						name = "Stick Horizontal",
						elementType = Rewired.PlayerController.Element.TypeWithSource.Axis,
						coordinateMode = AxisCoordinateMode.Absolute
					},
					new ElementWithSourceInfo
					{
						name = "Stick Vertical",
						elementType = Rewired.PlayerController.Element.TypeWithSource.Axis,
						coordinateMode = AxisCoordinateMode.Absolute
					}
				}
			});
			list.Add(new ElementInfo
			{
				elements = new ElementWithSourceInfo[1]
				{
					new ElementWithSourceInfo
					{
						name = "Button 1",
						elementType = Rewired.PlayerController.Element.TypeWithSource.Button
					}
				}
			});
			list.Add(new ElementInfo
			{
				elements = new ElementWithSourceInfo[1]
				{
					new ElementWithSourceInfo
					{
						name = "Button 2",
						elementType = Rewired.PlayerController.Element.TypeWithSource.Button
					}
				}
			});
			list.Add(new ElementInfo
			{
				elements = new ElementWithSourceInfo[1]
				{
					new ElementWithSourceInfo
					{
						name = "Button 3",
						elementType = Rewired.PlayerController.Element.TypeWithSource.Button
					}
				}
			});
			list.Add(new ElementInfo
			{
				elements = new ElementWithSourceInfo[1]
				{
					new ElementWithSourceInfo
					{
						name = "Button 4",
						elementType = Rewired.PlayerController.Element.TypeWithSource.Button
					}
				}
			});
			return list;
		}

		private void SVGDTJQaceipTBrIIafMHoQFLUwR(int P_0, bool P_1)
		{
			if (!base.isActiveAndEnabled)
			{
				return;
			}
			try
			{
				if (_onButtonStateChanged != null)
				{
					_onButtonStateChanged.Invoke(P_0, P_1);
				}
			}
			catch (Exception ex)
			{
				Logger.LogError("An exception occurred in a listener of ButtonStateChangedEvent. This means an exception was thrown by your code.\n" + ex);
			}
		}

		private void bpolpxoeTDDDJApzKZFzruQYlpUb(int P_0, float P_1)
		{
			if (!base.isActiveAndEnabled)
			{
				return;
			}
			try
			{
				if (_onAxisValueChanged != null)
				{
					_onAxisValueChanged.Invoke(P_0, P_1);
				}
			}
			catch (Exception ex)
			{
				Logger.LogError("An exception occurred in a listener of AxisValueChangedEvent. This means an exception was thrown by your code.\n" + ex);
			}
		}

		private void AyaHiOQmIfIMuCVNOowHWXqWQuX(bool P_0)
		{
			try
			{
				if (_onEnabledStateChanged != null)
				{
					_onEnabledStateChanged.Invoke(P_0);
				}
			}
			catch (Exception ex)
			{
				Logger.LogError("An exception occurred in a listener of EnabledStateChangedEvent. This means an exception was thrown by your code.\n" + ex);
			}
		}

		private void aGSywsUCbuxbHYKYlhTmZnpVGXJ()
		{
			if (_elements == null || _elements.Count <= 0)
			{
				_elements = YxRgrLXbmvaCklVEwGtqSaKVFdoH();
			}
		}

		[SpecialName]
		bool IPlayerController.get_enabled()
		{
			return base.enabled;
		}

		[SpecialName]
		void IPlayerController.set_enabled(bool P_0)
		{
			base.enabled = P_0;
		}
	}
}
