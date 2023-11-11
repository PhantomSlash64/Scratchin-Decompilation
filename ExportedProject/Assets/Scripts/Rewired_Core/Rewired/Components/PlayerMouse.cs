using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired.UI;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using UnityEngine;
using UnityEngine.Events;

namespace Rewired.Components
{
	[Serializable]
	[AddComponentMenu("Rewired/Player Mouse")]
	public sealed class PlayerMouse : PlayerController, IPlayerController, IPlayerMouse, IMouseInputSource
	{
		[Serializable]
		public class ScreenPositionChangedHandler : UnityEvent<Vector2>
		{
		}

		[Tooltip("If enabled, the screen position will default to the center of the allowed movement area. Otherwise, it will default to the lower-left corner of the allowed movement area.")]
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private bool _defaultToCenter = true;

		[SerializeField]
		[Tooltip("The pointer speed. This does not affect the speed of input from the mouse x/y axes if useHardwarePointerPosition is enabled. It only affects the speed from input sources other than mouse x/y or if mouse x/y are mapped to Actions assigned to Axes. ")]
		[CustomObfuscation(rename = false)]
		private float _pointerSpeed = 1f;

		[CustomObfuscation(rename = false)]
		[Tooltip("If enabled, the hardware pointer position will be used for mouse input. Otherwise, the position of the pointer will be calculated only from the Axis Action values. The Player that owns this Player Mouse must have the physical mouse assigned to it in order for the hardware position to be used, ex: player.controllers.hasMouse == true.")]
		[SerializeField]
		private bool _useHardwarePointerPosition = true;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		[Tooltip("If enabled, movement will be clamped to the Movement Area.")]
		private bool _clampToMovementArea = true;

		[Tooltip("The allowed movement area for the mouse pointer. Set Movement Area Unit to determine the data format of this value. This rect is a screen-space rect with 0, 0 at the lower-left corner.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private Rect _movementArea = new Rect(0f, 0f, 1f, 1f);

		[CustomObfuscation(rename = false)]
		[SerializeField]
		[Tooltip("The unit format of the movement area. This is used to determine the data format of Movement Area.")]
		private Rewired.PlayerMouse.MovementAreaUnit _movementAreaUnit;

		[Tooltip("Triggered when the screen position changes. Link this to your pointer to drive its position.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private ScreenPositionChangedHandler _onScreenPositionChanged = new ScreenPositionChangedHandler();

		private new Rewired.PlayerMouse source => base.source as Rewired.PlayerMouse;

		public bool defaultToCenter
		{
			get
			{
				if (!base.initialized)
				{
					return _defaultToCenter;
				}
				return source.defaultToCenter;
			}
			set
			{
				if (source == null)
				{
					_defaultToCenter = value;
					return;
				}
				source.defaultToCenter = value;
				_defaultToCenter = source.defaultToCenter;
			}
		}

		public bool clampToMovementArea
		{
			get
			{
				if (!base.initialized)
				{
					return _clampToMovementArea;
				}
				return source.clampToMovementArea;
			}
			set
			{
				if (source == null)
				{
					_clampToMovementArea = value;
					return;
				}
				source.clampToMovementArea = value;
				_clampToMovementArea = source.clampToMovementArea;
			}
		}

		public ScreenRect movementArea
		{
			get
			{
				if (!base.initialized)
				{
					return new ScreenRect(_movementArea.xMin, _movementArea.yMin, _movementArea.width, _movementArea.height);
				}
				return source.movementArea;
			}
			set
			{
				if (source == null)
				{
					_movementArea = new Rect(value.xMin, value.yMin, value.width, value.height);
					return;
				}
				source.movementArea = value;
				_movementArea = new Rect(source.movementArea.xMin, source.movementArea.yMin, source.movementArea.width, source.movementArea.height);
			}
		}

		public Rewired.PlayerMouse.MovementAreaUnit movementAreaUnit
		{
			get
			{
				if (!base.initialized)
				{
					return _movementAreaUnit;
				}
				return source.movementAreaUnit;
			}
			set
			{
				if (source == null)
				{
					_movementAreaUnit = value;
					return;
				}
				source.movementAreaUnit = value;
				_movementAreaUnit = source.movementAreaUnit;
			}
		}

		public Vector2 screenPosition
		{
			get
			{
				if (!base.initialized)
				{
					return Vector2.zero;
				}
				return source.screenPosition;
			}
			set
			{
				if (source != null)
				{
					source.screenPosition = value;
				}
			}
		}

		public Vector2 screenPositionPrev
		{
			get
			{
				if (!base.initialized)
				{
					return Vector2.zero;
				}
				return source.screenPositionPrev;
			}
		}

		public Vector2 screenPositionDelta
		{
			get
			{
				if (!base.initialized)
				{
					return Vector2.zero;
				}
				return source.screenPositionDelta;
			}
		}

		public Rewired.PlayerController.MouseAxis xAxis
		{
			get
			{
				if (!base.initialized)
				{
					return null;
				}
				return source.xAxis;
			}
		}

		public Rewired.PlayerController.MouseAxis yAxis
		{
			get
			{
				if (!base.initialized)
				{
					return null;
				}
				return source.yAxis;
			}
		}

		public Rewired.PlayerController.MouseWheel wheel
		{
			get
			{
				if (!base.initialized)
				{
					return null;
				}
				return source.wheel;
			}
		}

		public Rewired.PlayerController.Button leftButton
		{
			get
			{
				if (!base.initialized)
				{
					return null;
				}
				return source.leftButton;
			}
		}

		public Rewired.PlayerController.Button rightButton
		{
			get
			{
				if (!base.initialized)
				{
					return null;
				}
				return source.rightButton;
			}
		}

		public Rewired.PlayerController.Button middleButton
		{
			get
			{
				if (!base.initialized)
				{
					return null;
				}
				return source.middleButton;
			}
		}

		public float pointerSpeed
		{
			get
			{
				if (!base.initialized)
				{
					return _pointerSpeed;
				}
				return source.pointerSpeed;
			}
			set
			{
				if (value < 0f)
				{
					value = 0f;
				}
				_pointerSpeed = value;
				if (base.initialized)
				{
					source.pointerSpeed = value;
					_pointerSpeed = source.pointerSpeed;
				}
			}
		}

		public bool useHardwarePointerPosition
		{
			get
			{
				if (!base.initialized)
				{
					return _useHardwarePointerPosition;
				}
				return source.useHardwarePointerPosition;
			}
			set
			{
				_useHardwarePointerPosition = value;
				if (base.initialized)
				{
					source.useHardwarePointerPosition = value;
				}
			}
		}

		bool IMouseInputSource.enabled
		{
			get
			{
				if (!base.initialized)
				{
					return false;
				}
				return ((IMouseInputSource)source).enabled;
			}
		}

		Vector2 IMouseInputSource.screenPosition
		{
			get
			{
				if (!base.initialized)
				{
					return Vector2.zero;
				}
				return ((IMouseInputSource)source).screenPosition;
			}
		}

		Vector2 IMouseInputSource.screenPositionDelta
		{
			get
			{
				if (!base.initialized)
				{
					return Vector2.zero;
				}
				return ((IMouseInputSource)source).screenPositionDelta;
			}
		}

		Vector2 IMouseInputSource.wheelDelta
		{
			get
			{
				if (!base.initialized)
				{
					return Vector2.zero;
				}
				return ((IMouseInputSource)source).wheelDelta;
			}
		}

		bool IMouseInputSource.locked
		{
			get
			{
				if (!base.initialized)
				{
					return false;
				}
				return ((IMouseInputSource)source).locked;
			}
		}

		public event Action<Vector2> ScreenPositionChangedEvent
		{
			add
			{
				if (base.initialized)
				{
					source.ScreenPositionChangedEvent += value;
				}
			}
			remove
			{
				if (base.initialized)
				{
					source.ScreenPositionChangedEvent -= value;
				}
			}
		}

		protected override void OnValidated()
		{
			base.OnValidated();
			defaultToCenter = _defaultToCenter;
			clampToMovementArea = _clampToMovementArea;
			movementArea = new ScreenRect(_movementArea.xMin, _movementArea.yMin, _movementArea.width, _movementArea.height);
			movementAreaUnit = _movementAreaUnit;
			pointerSpeed = _pointerSpeed;
			useHardwarePointerPosition = _useHardwarePointerPosition;
		}

		protected override void OnReset()
		{
			base.OnReset();
			_clampToMovementArea = true;
			_defaultToCenter = true;
			_pointerSpeed = 1f;
			_useHardwarePointerPosition = true;
			_movementArea = new Rect(0f, 0f, 1f, 1f);
			_movementAreaUnit = Rewired.PlayerMouse.MovementAreaUnit.Screen;
			_onScreenPositionChanged = new ScreenPositionChangedHandler();
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
			Rewired.PlayerMouse.Definition definition = new Rewired.PlayerMouse.Definition();
			definition.playerId = base.playerId;
			definition.elements = list2;
			definition.defaultToCenter = _defaultToCenter;
			definition.clampToMovementArea = _clampToMovementArea;
			definition.movementArea = new ScreenRect(_movementArea.xMin, _movementArea.yMin, _movementArea.width, _movementArea.height);
			definition.movementAreaUnit = _movementAreaUnit;
			definition.pointerSpeed = _pointerSpeed;
			definition.useHardwarePointerPosition = _useHardwarePointerPosition;
			return Rewired.PlayerMouse.Factory.Create(definition);
		}

		protected override void Deinitialize()
		{
			base.Deinitialize();
		}

		protected override void Subscribe()
		{
			base.Subscribe();
			if (source != null)
			{
				source.ScreenPositionChangedEvent += NvmeOyHOunwsZChwotCMykeIfrib;
			}
		}

		protected override void Unsubscribe()
		{
			base.Unsubscribe();
			if (source != null)
			{
				source.ScreenPositionChangedEvent -= NvmeOyHOunwsZChwotCMykeIfrib;
			}
		}

		internal override List<ElementInfo> YxRgrLXbmvaCklVEwGtqSaKVFdoH()
		{
			List<ElementInfo> list = new List<ElementInfo>();
			list.Add(new ElementInfo
			{
				name = "Movement",
				elementType = Rewired.PlayerController.Element.Type.MouseAxis2D,
				elements = new ElementWithSourceInfo[2]
				{
					new ElementWithSourceInfo
					{
						name = "Horizontal",
						elementType = Rewired.PlayerController.Element.TypeWithSource.MouseAxis,
						coordinateMode = AxisCoordinateMode.Relative,
						absoluteSourceSensitivity = 600f
					},
					new ElementWithSourceInfo
					{
						name = "Vertical",
						elementType = Rewired.PlayerController.Element.TypeWithSource.MouseAxis,
						coordinateMode = AxisCoordinateMode.Relative,
						absoluteSourceSensitivity = 600f
					}
				}
			});
			list.Add(new ElementInfo
			{
				name = "Wheel",
				elementType = Rewired.PlayerController.Element.Type.MouseWheel,
				elements = new ElementWithSourceInfo[2]
				{
					new ElementWithSourceInfo
					{
						name = "Wheel Horizontal",
						elementType = Rewired.PlayerController.Element.TypeWithSource.MouseWheelAxis,
						coordinateMode = AxisCoordinateMode.Relative
					},
					new ElementWithSourceInfo
					{
						name = "Wheel Vertical",
						elementType = Rewired.PlayerController.Element.TypeWithSource.MouseWheelAxis,
						coordinateMode = AxisCoordinateMode.Relative
					}
				}
			});
			list.Add(new ElementInfo
			{
				elements = new ElementWithSourceInfo[1]
				{
					new ElementWithSourceInfo
					{
						name = "Left Button",
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
						name = "Right Button",
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
						name = "Middle Button",
						elementType = Rewired.PlayerController.Element.TypeWithSource.Button
					}
				}
			});
			return list;
		}

		private void NvmeOyHOunwsZChwotCMykeIfrib(Vector2 P_0)
		{
			if (!UnityTools.IsActiveAndEnabled(this))
			{
				return;
			}
			try
			{
				if (_onScreenPositionChanged != null)
				{
					_onScreenPositionChanged.Invoke(P_0);
				}
			}
			catch (Exception ex)
			{
				Logger.LogError("An exception occurred in a listener of ScreenPositionChangedEvent. This means an exception was thrown by your code.\n" + ex);
			}
		}

		private bool QPejpvCySqYAJKgTdfYsbfuUKbR(int P_0)
		{
			if (!base.initialized)
			{
				return false;
			}
			return ((IMouseInputSource)source).GetButtonDown(P_0);
		}

		bool IMouseInputSource.GetButtonDown(int P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in QPejpvCySqYAJKgTdfYsbfuUKbR
			return this.QPejpvCySqYAJKgTdfYsbfuUKbR(P_0);
		}

		private bool xksCvEhWWSGxsuSvbWlrOBvHNlEq(int P_0)
		{
			if (!base.initialized)
			{
				return false;
			}
			return ((IMouseInputSource)source).GetButtonUp(P_0);
		}

		bool IMouseInputSource.GetButtonUp(int P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in xksCvEhWWSGxsuSvbWlrOBvHNlEq
			return this.xksCvEhWWSGxsuSvbWlrOBvHNlEq(P_0);
		}

		private bool RVICZPrpgdRAEFbwCGuEUHjtHQm(int P_0)
		{
			if (!base.initialized)
			{
				return false;
			}
			return ((IMouseInputSource)source).GetButton(P_0);
		}

		bool IMouseInputSource.GetButton(int P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in RVICZPrpgdRAEFbwCGuEUHjtHQm
			return this.RVICZPrpgdRAEFbwCGuEUHjtHQm(P_0);
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
