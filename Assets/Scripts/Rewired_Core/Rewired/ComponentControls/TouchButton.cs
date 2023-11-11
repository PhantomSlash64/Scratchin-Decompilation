using System;
using System.Collections;
using System.Collections.Generic;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using Rewired.Utils;
using Rewired.Utils.Attributes;
using Rewired.Utils.UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Rewired.ComponentControls
{
	[Serializable]
	[AddComponentMenu("Rewired/Touch Button")]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[DisallowMultipleComponent]
	public sealed class TouchButton : TouchInteractable
	{
		public enum ButtonType
		{
			Standard = 0,
			ToggleSwitch = 1
		}

		private enum DKgkxBRfjuoGdnlJsQlTSAZjmMR
		{
			fUyeeVFhkdEderlnmYYFoAwmZEL = 0,
			KhjBlxXinizwmagcfMFQaHmMgQnA = 1,
			rvaVqjySZruGVZXxEuHSTaiRBTv = 2
		}

		private enum BPcAXmWgSdqhAqXnbMmsAafeiBM
		{
			ybRArxXioIxcFklVOBLcaRjDXxo = 0,
			UwJRECeDJpehOggKHfbGPdQtLFv = 1
		}

		[Serializable]
		public class AxisValueChangedEventHandler : UnityEvent<float>
		{
		}

		[Serializable]
		public class ButtonValueChangedEventHandler : UnityEvent<bool>
		{
		}

		[Serializable]
		public class ButtonDownEventHandler : UnityEvent
		{
		}

		[Serializable]
		public class ButtonUpEventHandler : UnityEvent
		{
		}

		private const float BEEYiTwDXWXqnxUMIicLHdQZVfc = 20f;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		[Tooltip("The Custom Controller element that will receive input values from this control.")]
		private CustomControllerElementTargetSetForFloat _targetCustomControllerElement = new CustomControllerElementTargetSetForFloat(new CustomControllerElementTarget(new CustomControllerElementSelector
		{
			elementType = CustomControllerElementSelector.ElementType.Button
		}));

		[SerializeField]
		[Tooltip("The type of button.\nStandard: A momentary switch. Returns True while the button is pressed down.\nToggle Switch: Alternately turns on and off with each press.")]
		[CustomObfuscation(rename = false)]
		private ButtonType _buttonType;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		[Tooltip("If true, the button can be turned on by a touch swipe that began in an area outside the button region. If false, the button can only be turned on by a direct press.")]
		private bool _activateOnSwipeIn;

		[Tooltip("If true, the button will stay on even if the touch that activated it moves outside the button region. If false, the button will turn off once the touch that activated it moves outside the button region.")]
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private bool _stayActiveOnSwipeOut = true;

		[CustomObfuscation(rename = false)]
		[Tooltip("Makes the axis value gradually change over time based on gravity and sensitivity as the button is pressed.")]
		[SerializeField]
		private bool _useDigitalAxisSimulation;

		[Tooltip("Speed (units/sec) that the axis value falls toward 0 when not pressed. A value of 1.0 means an axis value of 1 will drain to 0 over 1 second. A value of 3 equates to 1/3 of a second, and so on.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		[FieldRange(0f, float.PositiveInfinity)]
		private float _digitalAxisGravity = 3f;

		[CustomObfuscation(rename = false)]
		[Tooltip("Speed to move toward an axis value of 1.0 in units/sec when pressed. A value of 1.0 means an axis value of 0 will reach 1 over 1 second. A value of 3 equates to 1/3 of a second, and so on.")]
		[SerializeField]
		[FieldRange(0f, float.PositiveInfinity)]
		private float _digitalAxisSensitivity = 3f;

		[SerializeField]
		[Tooltip("The internal axis of the button. The axis is used for all value calculations.")]
		[CustomObfuscation(rename = false)]
		private StandaloneAxis _axis = new StandaloneAxis();

		[Tooltip("Optional external region to use for hover/click/touch detection. If set, this region will be used for touch detection instead of or in addition to the button's RectTransform. This can be useful if you want a larger area of the screen to act as a button.")]
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private TouchRegion _touchRegion;

		[SerializeField]
		[Tooltip("If True, hovers/clicks/touches on the local button will be ignored and only Touch Region touches will be used. Otherwise, both touches on the button and on the Touch Region will be used. This also applies to mouse hover. This setting has no effect if no Touch Region is set.")]
		[CustomObfuscation(rename = false)]
		private bool _useTouchRegionOnly = true;

		[SerializeField]
		[Tooltip("If True, the button will move to the location of the current touch in the Touch Region. This can be used to designate an area of the screen as a hot-spot for a button and have the button graphics follow the users touches. This only has an effect if a Touch Region is set.")]
		[CustomObfuscation(rename = false)]
		private bool _moveToTouchPosition;

		[Tooltip("If Move To Touch Position is enabled, this will make the button return to its original position after the press is released. This only has an effect if a Touch Region is set.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private bool _returnOnRelease = true;

		[Tooltip("If True, the button will follow the touch around until released. This setting overrides Move To Touch Position.")]
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private bool _followTouchPosition;

		[Tooltip("Should the button animate when moving to the touch point? This only has an effect if Move To Touch Position is True and a Touch Region is set. This setting is ignored if Follow Touch Position is True.")]
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private bool _animateOnMoveToTouch = true;

		[Range(0f, 20f)]
		[SerializeField]
		[Tooltip("The speed at which the button will move toward the touch position measured in screens per second (based on the larger of width and height). [1.0 = Move 1 screen/sec]. This only has an effect if Move To Touch Position is True, Animate On Move To Touch is true, and a Touch Region is set. This setting is ignored if Follow Touch Position is True.")]
		[CustomObfuscation(rename = false)]
		private float _moveToTouchSpeed = 2f;

		[CustomObfuscation(rename = false)]
		[Tooltip("Should the button animate when moving back to its original position? This only has an effect if Follow Touch Position is True, or if Move To Touch Position is True and a Touch Region is set, and Return on Release is True.")]
		[SerializeField]
		private bool _animateOnReturn = true;

		[SerializeField]
		[Range(0f, 20f)]
		[CustomObfuscation(rename = false)]
		[Tooltip("The speed at which the button will move back toward its original position measured in screens per second (based on the larger of width and height). [1.0 = Move 1 screen/sec]. This only has an effect if Follow Touch Position is True, or if Move To Touch Position is True and a Touch Region is set, and Return on Release and Animate on Return are both True.")]
		private float _returnSpeed = 2f;

		[Tooltip("If True, it will attempt to automatically manage Graphic component raycasting for best results based on your current settings.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private bool _manageRaycasting = true;

		private float THsrYFORtQFSmhZQumnZSmHZxJN;

		private float KcWJxPvPkhLHHweKpzrGuYEBGqU;

		private TouchRegion SNGSCYxQlfoJtdlbvXfVhgfYTzp;

		private Vector2 asiTgVzNNYsbgdCqYTMKbgwHUWu;

		private bool wLCTnlmMhlDWhLjpUVNokRixNIu;

		private bool nYkabKHSOkvYvFLCDsBqzemGzHJ;

		private DKgkxBRfjuoGdnlJsQlTSAZjmMR jiqeEbFAJSRczAUDteEMXiVywpXp;

		private int fzAAAwrCMxjPkwAZmjGBjngMgax = int.MinValue;

		private int YYSdVajBytGSIDwFtJDcLJUwUOx = int.MinValue;

		[NonSerialized]
		private bool JqTIgZURPqnlerMkXgRHIjZBjHc;

		[NonSerialized]
		private bool srFaSPXNbqBcgqmZShehFnYKaFM;

		private IEnumerator GrqnKuQioBxCtoRZJopumsiJWLS;

		private btMacetbbUufnQlkwuoHEIUZUaP GvyGVwdOZGjjbcoXmkZmOKIYJxJ = new btMacetbbUufnQlkwuoHEIUZUaP();

		private Action<DKgkxBRfjuoGdnlJsQlTSAZjmMR> qFAZHQufgvtqbFcQGhcFCGlhmkI;

		private Action<DKgkxBRfjuoGdnlJsQlTSAZjmMR> BFHplFrraezmIbNkqexeqTUCUMd;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		[Tooltip("Event sent when the axis value changes.")]
		private AxisValueChangedEventHandler _onAxisValueChanged = new AxisValueChangedEventHandler();

		[CustomObfuscation(rename = false)]
		[Tooltip("Event sent when the button value changes.")]
		[SerializeField]
		private ButtonValueChangedEventHandler _onButtonValueChanged = new ButtonValueChangedEventHandler();

		[CustomObfuscation(rename = false)]
		[Tooltip("Event sent when the button is pressed.")]
		[SerializeField]
		private ButtonDownEventHandler _onButtonDown = new ButtonDownEventHandler();

		[SerializeField]
		[Tooltip("Event sent when the button is released.")]
		[CustomObfuscation(rename = false)]
		private ButtonUpEventHandler _onButtonUp = new ButtonUpEventHandler();

		private Dictionary<int, PointerEventData> TcJheMbNzQMMyZHRzXmHOQSdkIDh;

		public CustomControllerElementTargetSetForFloat targetCustomControllerElement => _targetCustomControllerElement;

		public ButtonType buttonType
		{
			get
			{
				return _buttonType;
			}
			set
			{
				if (_buttonType != value)
				{
					_buttonType = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool activateOnSwipeIn
		{
			get
			{
				return _activateOnSwipeIn;
			}
			set
			{
				if (_activateOnSwipeIn != value)
				{
					_activateOnSwipeIn = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool stayActiveOnSwipeOut
		{
			get
			{
				if (EcrdjcIwViUQuKjQUfhYwrmmwrzt())
				{
					return true;
				}
				return _stayActiveOnSwipeOut;
			}
			set
			{
				if (_stayActiveOnSwipeOut != value)
				{
					_stayActiveOnSwipeOut = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool useDigitalAxisSimulation
		{
			get
			{
				return _useDigitalAxisSimulation;
			}
			set
			{
				if (_useDigitalAxisSimulation != value)
				{
					_useDigitalAxisSimulation = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public float digitalAxisGravity
		{
			get
			{
				return _digitalAxisGravity;
			}
			set
			{
				if (_digitalAxisGravity != value)
				{
					_digitalAxisGravity = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public float digitalAxisSensitivity
		{
			get
			{
				return _digitalAxisSensitivity;
			}
			set
			{
				if (_digitalAxisSensitivity != value)
				{
					_digitalAxisSensitivity = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public TouchRegion touchRegion
		{
			get
			{
				return _touchRegion;
			}
			set
			{
				if (!(_touchRegion == value))
				{
					_touchRegion = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool useTouchRegionOnly
		{
			get
			{
				return _useTouchRegionOnly;
			}
			set
			{
				if (_useTouchRegionOnly != value)
				{
					_useTouchRegionOnly = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool moveToTouchPosition
		{
			get
			{
				return _moveToTouchPosition;
			}
			set
			{
				if (_moveToTouchPosition != value)
				{
					_moveToTouchPosition = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool returnOnRelease
		{
			get
			{
				return _returnOnRelease;
			}
			set
			{
				if (_returnOnRelease != value)
				{
					_returnOnRelease = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool followTouchPosition
		{
			get
			{
				return _followTouchPosition;
			}
			set
			{
				if (_followTouchPosition != value)
				{
					_followTouchPosition = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool animateOnMoveToTouch
		{
			get
			{
				return _animateOnMoveToTouch;
			}
			set
			{
				if (_animateOnMoveToTouch != value)
				{
					_animateOnMoveToTouch = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public float moveToTouchSpeed
		{
			get
			{
				return _moveToTouchSpeed;
			}
			set
			{
				value = MathTools.Clamp(value, 0f, 20f);
				if (_moveToTouchSpeed != value)
				{
					_moveToTouchSpeed = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool animateOnReturn
		{
			get
			{
				return _animateOnReturn;
			}
			set
			{
				if (_animateOnReturn != value)
				{
					_animateOnReturn = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public float returnSpeed
		{
			get
			{
				return _returnSpeed;
			}
			set
			{
				value = MathTools.Clamp(value, 0f, 20f);
				if (_returnSpeed != value)
				{
					_returnSpeed = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool manageRaycasting
		{
			get
			{
				return _manageRaycasting;
			}
			set
			{
				if (_manageRaycasting != value)
				{
					_manageRaycasting = value;
					if (value)
					{
						rByfgOIBCbfGujmRjLxEmRIEkpH();
					}
					else
					{
						GvyGVwdOZGjjbcoXmkZmOKIYJxJ.LlCkzvOeJVaCziTDPktzBWuYotAZ();
					}
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public int pointerId
		{
			get
			{
				return fzAAAwrCMxjPkwAZmjGBjngMgax;
			}
			set
			{
				fzAAAwrCMxjPkwAZmjGBjngMgax = value;
			}
		}

		public bool hasPointer => fzAAAwrCMxjPkwAZmjGBjngMgax != int.MinValue;

		internal StandaloneAxis axis => _axis;

		private Action<DKgkxBRfjuoGdnlJsQlTSAZjmMR> moveStartedDelegate
		{
			get
			{
				if (qFAZHQufgvtqbFcQGhcFCGlhmkI == null)
				{
					return qFAZHQufgvtqbFcQGhcFCGlhmkI = ISUKmgpwRgZmIDnkNWdwkNMFmfb;
				}
				return qFAZHQufgvtqbFcQGhcFCGlhmkI;
			}
		}

		private Action<DKgkxBRfjuoGdnlJsQlTSAZjmMR> moveEndedDelegate
		{
			get
			{
				if (BFHplFrraezmIbNkqexeqTUCUMd == null)
				{
					return BFHplFrraezmIbNkqexeqTUCUMd = FFhguODgdngzafSWRnNDQKbcGjgb;
				}
				return BFHplFrraezmIbNkqexeqTUCUMd;
			}
		}

		private float axisValue
		{
			get
			{
				if (!_useDigitalAxisSimulation)
				{
					return _axis.value;
				}
				return THsrYFORtQFSmhZQumnZSmHZxJN;
			}
		}

		private float axisValuePrev
		{
			get
			{
				if (!_useDigitalAxisSimulation)
				{
					return _axis.valuePrev;
				}
				return KcWJxPvPkhLHHweKpzrGuYEBGqU;
			}
		}

		private bool buttonValue => _axis.buttonValue;

		private bool buttonValuePrev => _axis.buttonValuePrev;

		private int effectivePointerId
		{
			get
			{
				if (fzAAAwrCMxjPkwAZmjGBjngMgax == int.MinValue)
				{
					return int.MinValue;
				}
				if (YYSdVajBytGSIDwFtJDcLJUwUOx != int.MinValue)
				{
					return YYSdVajBytGSIDwFtJDcLJUwUOx;
				}
				return fzAAAwrCMxjPkwAZmjGBjngMgax;
			}
		}

		public event UnityAction<float> AxisValueChangedEvent
		{
			add
			{
				_onAxisValueChanged.AddListener(value);
			}
			remove
			{
				_onAxisValueChanged.RemoveListener(value);
			}
		}

		public event UnityAction<bool> ButtonValueChangedEvent
		{
			add
			{
				_onButtonValueChanged.AddListener(value);
			}
			remove
			{
				_onButtonValueChanged.RemoveListener(value);
			}
		}

		public event UnityAction ButtonDownEvent
		{
			add
			{
				_onButtonDown.AddListener(value);
			}
			remove
			{
				_onButtonDown.RemoveListener(value);
			}
		}

		public event UnityAction ButtonUpEvent
		{
			add
			{
				_onButtonUp.AddListener(value);
			}
			remove
			{
				_onButtonUp.RemoveListener(value);
			}
		}

		[CustomObfuscation(rename = false)]
		private TouchButton()
		{
		}

		public void SetRawValue(float value)
		{
			if (base.initialized)
			{
				_axis.SetRawValue(value);
			}
		}

		public void SetDefaultPosition()
		{
			ZwgbeSHqmLiplaNlDGMDQUQGFraZ(base.rectTransform.anchoredPosition);
		}

		private void ZwgbeSHqmLiplaNlDGMDQUQGFraZ(Vector2 P_0)
		{
			if (base.initialized)
			{
				asiTgVzNNYsbgdCqYTMKbgwHUWu = P_0;
			}
		}

		public void ReturnToDefaultPosition(bool instant)
		{
			if (base.initialized)
			{
				mPufZpPedugYJoQxTAKyXvjxTzD(asiTgVzNNYsbgdCqYTMKbgwHUWu, PositionType.uTfqQUlNosGAYHuwTDumRbzQnsBy, !instant && _animateOnReturn, _returnSpeed, DKgkxBRfjuoGdnlJsQlTSAZjmMR.rvaVqjySZruGVZXxEuHSTaiRBTv);
			}
		}

		public void ReturnToDefaultPosition()
		{
			if (base.initialized)
			{
				ReturnToDefaultPosition(instant: false);
			}
		}

		[CustomObfuscation(rename = false)]
		internal override void Awake()
		{
			base.Awake();
			if (Application.isPlaying)
			{
				asiTgVzNNYsbgdCqYTMKbgwHUWu = base.rectTransform.anchoredPosition;
			}
		}

		[CustomObfuscation(rename = false)]
		internal override void OnEnable()
		{
			base.OnEnable();
			if (base.initialized)
			{
				rcguwOLFHMwsDhYAeVEUHWpWuqg();
			}
		}

		[CustomObfuscation(rename = false)]
		internal override void OnDisable()
		{
			base.OnDisable();
			if (base.initialized)
			{
				oFSQYqtEFhhpifGSweyvNVNjYvX();
			}
		}

		[CustomObfuscation(rename = false)]
		internal override void OnValidate()
		{
			base.OnValidate();
			if (base.initialized)
			{
				rcguwOLFHMwsDhYAeVEUHWpWuqg();
			}
		}

		[CustomObfuscation(rename = false)]
		internal override void Reset()
		{
			base.Reset();
			base.transitionType = TransitionTypeFlags.ColorTint;
		}

		internal void OnUpdate()
		{
			base.EsMhoPqAHoBFPBeDrJCrkGzDsbv();
			if (base.initialized)
			{
				kfDrDnuJmAhZNBzfsAxKxridBfwH();
				BWIbemKEeobRELtQbzbkghYhSup();
				ztxFguCRtoKnvxqMmfjEdDuIdFhn();
				if (_followTouchPosition)
				{
					PQgcmjOsGyPBypqlObRxBiRHPwq(effectivePointerId);
				}
			}
		}

		internal bool OnInitialize()
		{
			if (!sTGamvWFKxGXQiXUVibUDPQNCmv())
			{
				return false;
			}
			return true;
		}

		internal void OnCustomControllerUpdate()
		{
			if (base.initialized && hasController)
			{
				PoPxMfVjbMVVIVtkgNooWLPvukf(_targetCustomControllerElement, axisValue, _axis.buttonActivationThreshold);
			}
		}

		internal void OnSubscribeEvents()
		{
			vVOkBAFOLrFCgxJvZTjUEsBzcRV();
			_axis.AxisValueChangedEvent += bpolpxoeTDDDJApzKZFzruQYlpUb;
			_axis.ButtonValueChangedEvent += xxCtHxojhYDbVZnDZABUYIVwuwv;
			_axis.ButtonDownEvent += semaiPkuwnSlvoHZHgEuFXNccjtB;
			_axis.ButtonUpEvent += HgFwIsAPmEwLwElhNVDKbQXXCGRH;
		}

		internal void OnUnsubscribeEvents()
		{
			YWpzYbuwLnICLOIxYOdSdgrbQWU();
			_axis.AxisValueChangedEvent -= bpolpxoeTDDDJApzKZFzruQYlpUb;
			_axis.ButtonValueChangedEvent -= xxCtHxojhYDbVZnDZABUYIVwuwv;
			_axis.ButtonDownEvent -= semaiPkuwnSlvoHZHgEuFXNccjtB;
			_axis.ButtonUpEvent -= HgFwIsAPmEwLwElhNVDKbQXXCGRH;
		}

		internal void OnSetProperty()
		{
			QCALZHBveTZKrIACkwpJsrxWoUa();
			if (base.initialized)
			{
				rcguwOLFHMwsDhYAeVEUHWpWuqg();
			}
		}

		internal void OnClear()
		{
			if (base.initialized)
			{
				fzAAAwrCMxjPkwAZmjGBjngMgax = int.MinValue;
				YYSdVajBytGSIDwFtJDcLJUwUOx = int.MinValue;
				JqTIgZURPqnlerMkXgRHIjZBjHc = false;
				srFaSPXNbqBcgqmZShehFnYKaFM = false;
				if (_returnOnRelease && nYkabKHSOkvYvFLCDsBqzemGzHJ && (_moveToTouchPosition || _followTouchPosition))
				{
					ReturnToDefaultPosition(instant: true);
				}
				nYkabKHSOkvYvFLCDsBqzemGzHJ = false;
				wLCTnlmMhlDWhLjpUVNokRixNIu = false;
				jiqeEbFAJSRczAUDteEMXiVywpXp = DKgkxBRfjuoGdnlJsQlTSAZjmMR.fUyeeVFhkdEderlnmYYFoAwmZEL;
				wEYGVRWGmlgHryFtdPzRgvcIyOM();
				_axis.Clear();
				THsrYFORtQFSmhZQumnZSmHZxJN = 0f;
				KcWJxPvPkhLHHweKpzrGuYEBGqU = 0f;
				rcguwOLFHMwsDhYAeVEUHWpWuqg();
			}
		}

		public override void ClearValue()
		{
			if (base.initialized)
			{
				_axis.Clear();
				THsrYFORtQFSmhZQumnZSmHZxJN = 0f;
				if (hasController)
				{
					base.controller.ClearElementValue(_targetCustomControllerElement);
				}
			}
		}

		internal bool IsPressed()
		{
			if (!base.initialized)
			{
				return false;
			}
			if (!XBsbLTtXGPImfIaItQCdVxhsKkCf())
			{
				return false;
			}
			if (!_axis.buttonValue)
			{
				return _axis.value != 0f;
			}
			return true;
		}

		internal bool IsThisOrTouchRegionGameObject(GameObject gameObject)
		{
			if (gameObject == null)
			{
				return false;
			}
			if (base.hcwbeUTIznYgrDGdahyYvNhUIsV(gameObject))
			{
				return true;
			}
			if (SNGSCYxQlfoJtdlbvXfVhgfYTzp != null)
			{
				return SNGSCYxQlfoJtdlbvXfVhgfYTzp.gameObject == gameObject;
			}
			return false;
		}

		private void ztxFguCRtoKnvxqMmfjEdDuIdFhn()
		{
			if (_useDigitalAxisSimulation)
			{
				if (_axis.buttonValue)
				{
					XcwRGohTGnaMqCwymJlCrbJeUjn();
				}
				else
				{
					tNwYHzAnqterXcZwBQWnNnFzixZ();
				}
			}
		}

		private void XcwRGohTGnaMqCwymJlCrbJeUjn()
		{
			float num = ((_axis.value >= 0f) ? 1f : (-1f));
			float num2 = MathTools.Abs(_digitalAxisSensitivity);
			num *= num2 * Time.unscaledDeltaTime;
			num += THsrYFORtQFSmhZQumnZSmHZxJN;
			num = MathTools.Clamp(num, -1f, 1f);
			VOskVrZQAJKfiFsXQVEeciXxMr(num, true);
		}

		private void tNwYHzAnqterXcZwBQWnNnFzixZ()
		{
			float num = _digitalAxisGravity;
			if (num == 0f)
			{
				return;
			}
			float tHsrYFORtQFSmhZQumnZSmHZxJN = THsrYFORtQFSmhZQumnZSmHZxJN;
			if (tHsrYFORtQFSmhZQumnZSmHZxJN != 0f)
			{
				float num2 = num * Time.unscaledDeltaTime;
				float num3;
				if (MathTools.Abs(num2) >= MathTools.Abs(tHsrYFORtQFSmhZQumnZSmHZxJN))
				{
					num3 = 0f;
				}
				else
				{
					float num4 = ((tHsrYFORtQFSmhZQumnZSmHZxJN > 0f) ? (-1f) : 1f);
					num3 = tHsrYFORtQFSmhZQumnZSmHZxJN + num4 * num2;
				}
				VOskVrZQAJKfiFsXQVEeciXxMr(num3, true);
			}
		}

		private void VOskVrZQAJKfiFsXQVEeciXxMr(float P_0, bool P_1)
		{
			KcWJxPvPkhLHHweKpzrGuYEBGqU = THsrYFORtQFSmhZQumnZSmHZxJN;
			THsrYFORtQFSmhZQumnZSmHZxJN = P_0;
			if (P_0 != KcWJxPvPkhLHHweKpzrGuYEBGqU)
			{
				BWTYBldZMpFDcLZggqvnVZiKTQd(null);
			}
			if (P_1 && P_0 != KcWJxPvPkhLHHweKpzrGuYEBGqU)
			{
				_onAxisValueChanged.Invoke(P_0);
			}
		}

		private void qwzSFhoFvLLUTtbhFCkNkvgkzBx()
		{
			if (_buttonType == ButtonType.ToggleSwitch)
			{
				if (buttonValue)
				{
					_axis.SetRawValue(_axis.rawZero);
				}
				else
				{
					_axis.SetRawValue(_axis.rawMax);
				}
			}
			else if (_buttonType == ButtonType.Standard)
			{
				_axis.SetRawValue(_axis.rawMax);
			}
		}

		private void iIwPdRbwedbtNRoZmaozHXLBMcG()
		{
			if (_buttonType == ButtonType.Standard)
			{
				_axis.SetRawValue(_axis.rawZero);
			}
		}

		private void rcguwOLFHMwsDhYAeVEUHWpWuqg()
		{
			_targetCustomControllerElement.ClearElementCaches();
			BWIbemKEeobRELtQbzbkghYhSup();
			rByfgOIBCbfGujmRjLxEmRIEkpH();
		}

		private void rByfgOIBCbfGujmRjLxEmRIEkpH()
		{
			if (_manageRaycasting)
			{
				GvyGVwdOZGjjbcoXmkZmOKIYJxJ.vpXZlWYkCIxIaoVUFqhUjPYIuhq(base.transform, LEccQWLrMOyUhRxtygOGqCUobzX());
			}
		}

		private bool LEccQWLrMOyUhRxtygOGqCUobzX()
		{
			if (SNGSCYxQlfoJtdlbvXfVhgfYTzp != null && _useTouchRegionOnly)
			{
				return false;
			}
			return true;
		}

		private void useyiYLQSzOHLDNgbqjxmlpgCeL(TouchRegion P_0)
		{
			if (!(P_0 == null))
			{
				mjfDdkdZGbAVdGRNevABqbhiRldP(P_0);
				P_0.PointerDownEvent += yOWvDkNRePpXDlgqQocWHwvLKAP;
				P_0.PointerUpEvent += RYIxSxOExUfMMEeNWaJAWkrayjD;
				P_0.PointerEnterEvent += TQqqRdPAqtBgOkAYkMtExlUkktl;
				P_0.PointerExitEvent += MyLuMwEnqlRgbmTdLTEmHTvJicZ;
			}
		}

		private void mjfDdkdZGbAVdGRNevABqbhiRldP(TouchRegion P_0)
		{
			if (!(P_0 == null))
			{
				P_0.PointerDownEvent -= yOWvDkNRePpXDlgqQocWHwvLKAP;
				P_0.PointerUpEvent -= RYIxSxOExUfMMEeNWaJAWkrayjD;
				P_0.PointerEnterEvent -= TQqqRdPAqtBgOkAYkMtExlUkktl;
				P_0.PointerExitEvent -= MyLuMwEnqlRgbmTdLTEmHTvJicZ;
			}
		}

		private void BWIbemKEeobRELtQbzbkghYhSup()
		{
			if (!(SNGSCYxQlfoJtdlbvXfVhgfYTzp == _touchRegion))
			{
				mjfDdkdZGbAVdGRNevABqbhiRldP(SNGSCYxQlfoJtdlbvXfVhgfYTzp);
				SNGSCYxQlfoJtdlbvXfVhgfYTzp = _touchRegion;
				useyiYLQSzOHLDNgbqjxmlpgCeL(SNGSCYxQlfoJtdlbvXfVhgfYTzp);
			}
		}

		private void uFUoXCHbBlbliSaiABwkmsSYuLy(Vector2 P_0, bool P_1, float P_2, DKgkxBRfjuoGdnlJsQlTSAZjmMR P_3)
		{
			RectTransform rectTransform = base.transform.parent as RectTransform;
			Vector2 vector = jymGRyibtaURHbcICHlhSiuscVd.YRImbPBXrbYYGlgsARczAHiAkNR(base.canvas, rectTransform, P_0);
			Vector2 pivot = base.rectTransform.pivot;
			Vector2 sizeDelta = base.rectTransform.sizeDelta;
			Vector3 localScale = base.rectTransform.localScale;
			vector += new Vector2((pivot.x - 0.5f) * sizeDelta.x * localScale.x, (pivot.y - 0.5f) * sizeDelta.y * localScale.y);
			mPufZpPedugYJoQxTAKyXvjxTzD(vector, PositionType.ybRArxXioIxcFklVOBLcaRjDXxo, P_1, P_2, P_3);
		}

		private void mPufZpPedugYJoQxTAKyXvjxTzD(Vector2 P_0, PositionType P_1, bool P_2, float P_3, DKgkxBRfjuoGdnlJsQlTSAZjmMR P_4)
		{
			if (wLCTnlmMhlDWhLjpUVNokRixNIu && P_2 && jiqeEbFAJSRczAUDteEMXiVywpXp == P_4)
			{
				return;
			}
			if (wLCTnlmMhlDWhLjpUVNokRixNIu && GrqnKuQioBxCtoRZJopumsiJWLS != null)
			{
				wEYGVRWGmlgHryFtdPzRgvcIyOM();
				wLCTnlmMhlDWhLjpUVNokRixNIu = false;
				jiqeEbFAJSRczAUDteEMXiVywpXp = DKgkxBRfjuoGdnlJsQlTSAZjmMR.fUyeeVFhkdEderlnmYYFoAwmZEL;
			}
			if (base.canvas == null)
			{
				Logger.LogWarning("Animation cannot be used without a Canvas.");
				P_2 = false;
			}
			else if (base.canvas.renderMode == RenderMode.WorldSpace)
			{
				Logger.LogWarning("Animation can only be used with a screen space Canvas.");
				P_2 = false;
			}
			if (P_2)
			{
				Transform parent = base.transform;
				RectTransform rectTransform = base.canvasTransform;
				Vector2 one = Vector2.one;
				while ((parent = parent.parent) != rectTransform && !(parent == null))
				{
					one.x *= parent.localScale.x;
					one.y *= parent.localScale.y;
				}
				Vector2 sizeDelta = rectTransform.sizeDelta;
				bool flag = sizeDelta.x < sizeDelta.y;
				float num = MathTools.Max(sizeDelta.x, sizeDelta.y);
				float num2 = (flag ? one.y : one.x);
				if (num2 == 0f)
				{
					num2 = 0.0001f;
				}
				P_3 = P_3 / num2 * num;
				GrqnKuQioBxCtoRZJopumsiJWLS = cevshessvXMDRgOThBjiKjuuALWa(P_0, P_1, P_3, P_4);
				StartCoroutine(GrqnKuQioBxCtoRZJopumsiJWLS);
				jiqeEbFAJSRczAUDteEMXiVywpXp = P_4;
				nYkabKHSOkvYvFLCDsBqzemGzHJ = true;
				moveStartedDelegate(P_4);
			}
			else
			{
				moveStartedDelegate(P_4);
				IniezKpgmFCaNJdJcSQvPfpJiYDZ(P_4, P_0, P_1);
			}
		}

		private IEnumerator cevshessvXMDRgOThBjiKjuuALWa(Vector2 P_0, PositionType P_1, float P_2, DKgkxBRfjuoGdnlJsQlTSAZjmMR P_3)
		{
			if (!(P_2 <= 0f))
			{
				RectTransform rectTransform = base.rectTransform;
				Vector2 vector = jymGRyibtaURHbcICHlhSiuscVd.zxytvutKAMOKcgVemlYrwYYYaZu(rectTransform, P_1);
				float magnitude = (P_0 - vector).magnitude;
				if (!(magnitude < 0.01f))
				{
					wLCTnlmMhlDWhLjpUVNokRixNIu = true;
					float num = magnitude / P_2;
					float num2 = 0f;
					while (num2 <= 1f)
					{
						num2 += Time.unscaledDeltaTime / num;
						jymGRyibtaURHbcICHlhSiuscVd.ovLTstsqEfluDDaquBXFlrrofUB(rectTransform, Vector2.Lerp(vector, P_0, Mathf.SmoothStep(0f, 1f, num2)), P_1);
						yield return null;
					}
				}
			}
			IniezKpgmFCaNJdJcSQvPfpJiYDZ(P_3, P_0, P_1);
		}

		private void IniezKpgmFCaNJdJcSQvPfpJiYDZ(DKgkxBRfjuoGdnlJsQlTSAZjmMR P_0, Vector2 P_1, PositionType P_2)
		{
			jymGRyibtaURHbcICHlhSiuscVd.ovLTstsqEfluDDaquBXFlrrofUB(base.rectTransform, P_1, P_2);
			wLCTnlmMhlDWhLjpUVNokRixNIu = false;
			jiqeEbFAJSRczAUDteEMXiVywpXp = DKgkxBRfjuoGdnlJsQlTSAZjmMR.fUyeeVFhkdEderlnmYYFoAwmZEL;
			switch (P_0)
			{
			case DKgkxBRfjuoGdnlJsQlTSAZjmMR.rvaVqjySZruGVZXxEuHSTaiRBTv:
				nYkabKHSOkvYvFLCDsBqzemGzHJ = false;
				break;
			case DKgkxBRfjuoGdnlJsQlTSAZjmMR.KhjBlxXinizwmagcfMFQaHmMgQnA:
				nYkabKHSOkvYvFLCDsBqzemGzHJ = true;
				break;
			}
			wEYGVRWGmlgHryFtdPzRgvcIyOM();
			moveEndedDelegate(P_0);
		}

		private void ISUKmgpwRgZmIDnkNWdwkNMFmfb(DKgkxBRfjuoGdnlJsQlTSAZjmMR P_0)
		{
			if (_manageRaycasting)
			{
				bool flag = false;
				bool flag2 = false;
				if (((_followTouchPosition && stayActiveOnSwipeOut) || (!_followTouchPosition && SNGSCYxQlfoJtdlbvXfVhgfYTzp != null && !_useTouchRegionOnly && _moveToTouchPosition)) && _returnOnRelease && P_0 == DKgkxBRfjuoGdnlJsQlTSAZjmMR.KhjBlxXinizwmagcfMFQaHmMgQnA)
				{
					flag = true;
					flag2 = false;
				}
				if (flag)
				{
					GvyGVwdOZGjjbcoXmkZmOKIYJxJ.vpXZlWYkCIxIaoVUFqhUjPYIuhq(base.transform, flag2);
				}
			}
		}

		private void FFhguODgdngzafSWRnNDQKbcGjgb(DKgkxBRfjuoGdnlJsQlTSAZjmMR P_0)
		{
			if (_manageRaycasting)
			{
				bool flag = false;
				bool flag2 = false;
				if (((_followTouchPosition && stayActiveOnSwipeOut) || (!_followTouchPosition && SNGSCYxQlfoJtdlbvXfVhgfYTzp != null && !_useTouchRegionOnly && _moveToTouchPosition)) && _returnOnRelease && P_0 == DKgkxBRfjuoGdnlJsQlTSAZjmMR.rvaVqjySZruGVZXxEuHSTaiRBTv)
				{
					flag = true;
					flag2 = LEccQWLrMOyUhRxtygOGqCUobzX();
				}
				if (flag)
				{
					GvyGVwdOZGjjbcoXmkZmOKIYJxJ.vpXZlWYkCIxIaoVUFqhUjPYIuhq(base.transform, flag2);
				}
			}
		}

		private void PQgcmjOsGyPBypqlObRxBiRHPwq(int P_0)
		{
			if (TouchInteractable.bOoaroltYBOVjhIHdhreKsAonNvK(P_0))
			{
				uFUoXCHbBlbliSaiABwkmsSYuLy(TouchInteractable.GBMnUsstGEVGmOGsqXQbEdQHMvO(P_0), false, 0f, DKgkxBRfjuoGdnlJsQlTSAZjmMR.KhjBlxXinizwmagcfMFQaHmMgQnA);
			}
		}

		private void wEYGVRWGmlgHryFtdPzRgvcIyOM()
		{
			if (GrqnKuQioBxCtoRZJopumsiJWLS != null)
			{
				try
				{
					StopCoroutine(GrqnKuQioBxCtoRZJopumsiJWLS);
				}
				catch
				{
				}
				GrqnKuQioBxCtoRZJopumsiJWLS = null;
			}
		}

		private void kfDrDnuJmAhZNBzfsAxKxridBfwH()
		{
			if (hasPointer && !TouchInteractable.bOoaroltYBOVjhIHdhreKsAonNvK(effectivePointerId))
			{
				PointerEventData pointerEventData = WIGByaehXzLuwXJcAcYLdUgeATuB(effectivePointerId);
				if (pointerEventData != null && pointerEventData.pointerPress != null)
				{
					WvHPksyWKbtibITGhYcAkYxKrsK(pointerEventData);
				}
				else
				{
					BdetLhqQEMAQkEfUPAwbaHVgeAWp();
				}
			}
		}

		private bool EcrdjcIwViUQuKjQUfhYwrmmwrzt()
		{
			if (!_followTouchPosition)
			{
				return false;
			}
			if (_touchRegion != null && _useTouchRegionOnly)
			{
				return false;
			}
			return true;
		}

		private void idcIobbzTvcsrguJiTvrfIALPnMW()
		{
			fzAAAwrCMxjPkwAZmjGBjngMgax = int.MinValue;
			YYSdVajBytGSIDwFtJDcLJUwUOx = int.MinValue;
		}

		private bool JvCJLssRkpazuSjNnVeNMsqAtp(int P_0)
		{
			if (P_0 == int.MinValue)
			{
				return false;
			}
			if (fzAAAwrCMxjPkwAZmjGBjngMgax == int.MinValue)
			{
				return false;
			}
			if (fzAAAwrCMxjPkwAZmjGBjngMgax == P_0)
			{
				return true;
			}
			if (TouchInteractable.fBDaCJUGHMKyzFPPnJLLYPSUSOm(P_0) && YYSdVajBytGSIDwFtJDcLJUwUOx != int.MinValue && P_0 == YYSdVajBytGSIDwFtJDcLJUwUOx)
			{
				return true;
			}
			return false;
		}

		private PointerEventData nObkvTSHzuhJJYsVLILNtMtfUUI(int P_0, GameObject P_1)
		{
			PointerEventData pointerEventData = WIGByaehXzLuwXJcAcYLdUgeATuB(P_0);
			if (pointerEventData == null)
			{
				return null;
			}
			pointerEventData.position = TouchInteractable.GBMnUsstGEVGmOGsqXQbEdQHMvO(P_0);
			if (TouchInteractable.aueGJRnEIGvykBdXScvxHGjvKPO(P_0))
			{
				pointerEventData.eligibleForClick = true;
				pointerEventData.delta = Vector2.zero;
				pointerEventData.dragging = false;
				pointerEventData.useDragThreshold = true;
				pointerEventData.pressPosition = pointerEventData.position;
				pointerEventData.pointerPressRaycast = pointerEventData.pointerCurrentRaycast;
				if (pointerEventData.pointerEnter != P_1)
				{
					pointerEventData.pointerEnter = P_1;
				}
				float unscaledTime = Time.unscaledTime;
				if (P_1 == pointerEventData.lastPress)
				{
					float num = unscaledTime - pointerEventData.clickTime;
					if (num < 0.3f)
					{
						pointerEventData.clickCount++;
					}
					else
					{
						pointerEventData.clickCount = 1;
					}
					pointerEventData.clickTime = unscaledTime;
				}
				else
				{
					pointerEventData.clickCount = 1;
				}
				pointerEventData.pointerPress = P_1;
				pointerEventData.rawPointerPress = P_1;
				pointerEventData.clickTime = unscaledTime;
				pointerEventData.pointerDrag = P_1;
			}
			else
			{
				if (!TouchInteractable.fBDaCJUGHMKyzFPPnJLLYPSUSOm(P_0))
				{
					Logger.LogWarning("Unsupported pointerId: " + P_0);
					return null;
				}
				pointerEventData.eligibleForClick = true;
				pointerEventData.delta = Vector2.zero;
				pointerEventData.dragging = false;
				pointerEventData.useDragThreshold = true;
				pointerEventData.pressPosition = pointerEventData.position;
				pointerEventData.pointerPressRaycast = pointerEventData.pointerCurrentRaycast;
				float unscaledTime2 = Time.unscaledTime;
				if (P_1 == pointerEventData.lastPress)
				{
					float num2 = unscaledTime2 - pointerEventData.clickTime;
					if (num2 < 0.3f)
					{
						pointerEventData.clickCount++;
					}
					else
					{
						pointerEventData.clickCount = 1;
					}
					pointerEventData.clickTime = unscaledTime2;
				}
				else
				{
					pointerEventData.clickCount = 1;
				}
				pointerEventData.pointerPress = P_1;
				pointerEventData.rawPointerPress = P_1;
				pointerEventData.clickTime = unscaledTime2;
				pointerEventData.pointerDrag = P_1;
			}
			return pointerEventData;
		}

		private PointerEventData uNtUsebbOJdooGkiOYohpQwMaph(int P_0)
		{
			PointerEventData pointerEventData = WIGByaehXzLuwXJcAcYLdUgeATuB(P_0);
			if (pointerEventData == null)
			{
				return null;
			}
			if (TouchInteractable.aueGJRnEIGvykBdXScvxHGjvKPO(P_0))
			{
				pointerEventData.eligibleForClick = false;
				pointerEventData.pointerPress = null;
				pointerEventData.rawPointerPress = null;
				pointerEventData.dragging = false;
				pointerEventData.pointerDrag = null;
				pointerEventData.pointerEnter = null;
			}
			else
			{
				if (!TouchInteractable.fBDaCJUGHMKyzFPPnJLLYPSUSOm(P_0))
				{
					Logger.LogWarning("Unsupported pointerId: " + P_0);
					return null;
				}
				pointerEventData.eligibleForClick = false;
				pointerEventData.pointerPress = null;
				pointerEventData.rawPointerPress = null;
				pointerEventData.dragging = false;
				pointerEventData.pointerDrag = null;
			}
			return pointerEventData;
		}

		private void WvHPksyWKbtibITGhYcAkYxKrsK(PointerEventData P_0)
		{
			if (P_0 != null)
			{
				OnPointerUp(P_0);
				uNtUsebbOJdooGkiOYohpQwMaph(effectivePointerId);
			}
		}

		private PointerEventData WIGByaehXzLuwXJcAcYLdUgeATuB(int P_0)
		{
			if (P_0 == int.MinValue)
			{
				return null;
			}
			if (TcJheMbNzQMMyZHRzXmHOQSdkIDh == null)
			{
				TcJheMbNzQMMyZHRzXmHOQSdkIDh = new Dictionary<int, PointerEventData>();
			}
			if (!TcJheMbNzQMMyZHRzXmHOQSdkIDh.TryGetValue(P_0, out var value))
			{
				value = new PointerEventData(EventSystem.current);
				value.pointerId = P_0;
				TcJheMbNzQMMyZHRzXmHOQSdkIDh.Add(P_0, value);
				if (TouchInteractable.fBDaCJUGHMKyzFPPnJLLYPSUSOm(P_0))
				{
					PointerEventData.InputButton button = P_0 switch
					{
						-1 => PointerEventData.InputButton.Left, 
						-2 => PointerEventData.InputButton.Right, 
						-3 => PointerEventData.InputButton.Middle, 
						_ => throw new NotImplementedException(), 
					};
					value.button = button;
				}
			}
			return value;
		}

		private void zzrkaxnturidqqMjgraipqOTmUd(PointerEventData P_0, BPcAXmWgSdqhAqXnbMmsAafeiBM P_1)
		{
			if (!hasPointer || JvCJLssRkpazuSjNnVeNMsqAtp(P_0.pointerId))
			{
				if (XBsbLTtXGPImfIaItQCdVxhsKkCf() && IsInteractable())
				{
					GwPqSRmIjUapgxyDBkmHAbkOwqZ(P_0.pointerId, P_0.pressPosition, P_1);
				}
				base.OnPointerDown(P_0);
			}
		}

		private void WPjusxqaVfapPbgoWDxXXzbxpbSs(PointerEventData P_0, BPcAXmWgSdqhAqXnbMmsAafeiBM P_1)
		{
			if ((!hasPointer || JvCJLssRkpazuSjNnVeNMsqAtp(P_0.pointerId)) && !TouchInteractable.bOoaroltYBOVjhIHdhreKsAonNvK(effectivePointerId))
			{
				BdetLhqQEMAQkEfUPAwbaHVgeAWp();
				base.OnPointerUp(P_0);
			}
		}

		private void KYCVoPCBzkDlHGLGqSdTRXEhtrF(PointerEventData P_0, BPcAXmWgSdqhAqXnbMmsAafeiBM P_1)
		{
			if (hasPointer && !JvCJLssRkpazuSjNnVeNMsqAtp(P_0.pointerId))
			{
				return;
			}
			bool flag = TouchInteractable.fBDaCJUGHMKyzFPPnJLLYPSUSOm(P_0.pointerId);
			bool flag2 = false;
			MouseButtonFlags mouseButtonFlags = P_1 switch
			{
				BPcAXmWgSdqhAqXnbMmsAafeiBM.ybRArxXioIxcFklVOBLcaRjDXxo => base.allowedMouseButtons, 
				BPcAXmWgSdqhAqXnbMmsAafeiBM.UwJRECeDJpehOggKHfbGPdQtLFv => _touchRegion.allowedMouseButtons, 
				_ => throw new NotImplementedException(), 
			};
			if (_activateOnSwipeIn && XBsbLTtXGPImfIaItQCdVxhsKkCf() && IsInteractable() && (!flag || TouchInteractable.UIAJDiawRYceATgCEufNYDyAAug(mouseButtonFlags)) && !JqTIgZURPqnlerMkXgRHIjZBjHc)
			{
				if (flag)
				{
					if (TouchInteractable.SmCfOOFVihfMKElPbVnuHVRaFpEx(mouseButtonFlags, out var yYSdVajBytGSIDwFtJDcLJUwUOx))
					{
						YYSdVajBytGSIDwFtJDcLJUwUOx = yYSdVajBytGSIDwFtJDcLJUwUOx;
					}
					else
					{
						YYSdVajBytGSIDwFtJDcLJUwUOx = P_0.pointerId;
					}
				}
				flag2 = true;
			}
			base.OnPointerEnter(P_0);
			if (flag2)
			{
				GameObject gameObject = P_1 switch
				{
					BPcAXmWgSdqhAqXnbMmsAafeiBM.ybRArxXioIxcFklVOBLcaRjDXxo => base.gameObject, 
					BPcAXmWgSdqhAqXnbMmsAafeiBM.UwJRECeDJpehOggKHfbGPdQtLFv => SNGSCYxQlfoJtdlbvXfVhgfYTzp.gameObject, 
					_ => throw new NotImplementedException(), 
				};
				PointerEventData pointerEventData = nObkvTSHzuhJJYsVLILNtMtfUUI((YYSdVajBytGSIDwFtJDcLJUwUOx != int.MinValue) ? YYSdVajBytGSIDwFtJDcLJUwUOx : P_0.pointerId, gameObject);
				if (pointerEventData != null)
				{
					zzrkaxnturidqqMjgraipqOTmUd(pointerEventData, P_1);
				}
			}
			srFaSPXNbqBcgqmZShehFnYKaFM = true;
		}

		private void wWwWoRfaNqJMPqaPcULexWSwZGt(PointerEventData P_0, BPcAXmWgSdqhAqXnbMmsAafeiBM P_1)
		{
			if (hasPointer && !JvCJLssRkpazuSjNnVeNMsqAtp(P_0.pointerId))
			{
				base.OnPointerExit(P_0);
				return;
			}
			if (!stayActiveOnSwipeOut && JqTIgZURPqnlerMkXgRHIjZBjHc)
			{
				BdetLhqQEMAQkEfUPAwbaHVgeAWp();
			}
			base.OnPointerExit(P_0);
			srFaSPXNbqBcgqmZShehFnYKaFM = false;
		}

		private void GwPqSRmIjUapgxyDBkmHAbkOwqZ(int P_0, Vector2 P_1, BPcAXmWgSdqhAqXnbMmsAafeiBM P_2)
		{
			fzAAAwrCMxjPkwAZmjGBjngMgax = P_0;
			JqTIgZURPqnlerMkXgRHIjZBjHc = true;
			if (_followTouchPosition)
			{
				PQgcmjOsGyPBypqlObRxBiRHPwq(P_0);
			}
			else if (P_2 == BPcAXmWgSdqhAqXnbMmsAafeiBM.UwJRECeDJpehOggKHfbGPdQtLFv && _moveToTouchPosition)
			{
				uFUoXCHbBlbliSaiABwkmsSYuLy(P_1, _animateOnMoveToTouch, _moveToTouchSpeed, DKgkxBRfjuoGdnlJsQlTSAZjmMR.KhjBlxXinizwmagcfMFQaHmMgQnA);
			}
			qwzSFhoFvLLUTtbhFCkNkvgkzBx();
		}

		private void BdetLhqQEMAQkEfUPAwbaHVgeAWp()
		{
			idcIobbzTvcsrguJiTvrfIALPnMW();
			JqTIgZURPqnlerMkXgRHIjZBjHc = false;
			if ((_followTouchPosition || _moveToTouchPosition) && _returnOnRelease && nYkabKHSOkvYvFLCDsBqzemGzHJ)
			{
				ReturnToDefaultPosition();
			}
			iIwPdRbwedbtNRoZmaozHXLBMcG();
		}

		internal override void OnPointerDown(PointerEventData eventData)
		{
			if (base.initialized && TouchInteractable.DrebNyFyDDBAsDuDivulZyHbKPQe(eventData.pointerId, base.allowedMouseButtons, EventTriggerType.PointerDown) && (!(SNGSCYxQlfoJtdlbvXfVhgfYTzp != null) || !_useTouchRegionOnly))
			{
				zzrkaxnturidqqMjgraipqOTmUd(eventData, BPcAXmWgSdqhAqXnbMmsAafeiBM.ybRArxXioIxcFklVOBLcaRjDXxo);
			}
		}

		internal override void OnPointerUp(PointerEventData eventData)
		{
			if (base.initialized && TouchInteractable.DrebNyFyDDBAsDuDivulZyHbKPQe(eventData.pointerId, base.allowedMouseButtons, EventTriggerType.PointerUp) && (!(SNGSCYxQlfoJtdlbvXfVhgfYTzp != null) || !_useTouchRegionOnly))
			{
				WPjusxqaVfapPbgoWDxXXzbxpbSs(eventData, BPcAXmWgSdqhAqXnbMmsAafeiBM.ybRArxXioIxcFklVOBLcaRjDXxo);
			}
		}

		internal override void OnPointerEnter(PointerEventData eventData)
		{
			if (base.initialized && TouchInteractable.DrebNyFyDDBAsDuDivulZyHbKPQe(eventData.pointerId, base.allowedMouseButtons, EventTriggerType.PointerEnter) && (!(SNGSCYxQlfoJtdlbvXfVhgfYTzp != null) || !_useTouchRegionOnly))
			{
				KYCVoPCBzkDlHGLGqSdTRXEhtrF(eventData, BPcAXmWgSdqhAqXnbMmsAafeiBM.ybRArxXioIxcFklVOBLcaRjDXxo);
			}
		}

		internal override void OnPointerExit(PointerEventData eventData)
		{
			if (base.initialized && TouchInteractable.DrebNyFyDDBAsDuDivulZyHbKPQe(eventData.pointerId, base.allowedMouseButtons, EventTriggerType.PointerExit) && (!(SNGSCYxQlfoJtdlbvXfVhgfYTzp != null) || !_useTouchRegionOnly))
			{
				wWwWoRfaNqJMPqaPcULexWSwZGt(eventData, BPcAXmWgSdqhAqXnbMmsAafeiBM.ybRArxXioIxcFklVOBLcaRjDXxo);
			}
		}

		private void yOWvDkNRePpXDlgqQocWHwvLKAP(PointerEventData P_0)
		{
			if (base.initialized && TouchInteractable.DrebNyFyDDBAsDuDivulZyHbKPQe(P_0.pointerId, _touchRegion.allowedMouseButtons, EventTriggerType.PointerDown))
			{
				zzrkaxnturidqqMjgraipqOTmUd(P_0, BPcAXmWgSdqhAqXnbMmsAafeiBM.UwJRECeDJpehOggKHfbGPdQtLFv);
			}
		}

		private void RYIxSxOExUfMMEeNWaJAWkrayjD(PointerEventData P_0)
		{
			if (base.initialized && TouchInteractable.DrebNyFyDDBAsDuDivulZyHbKPQe(P_0.pointerId, _touchRegion.allowedMouseButtons, EventTriggerType.PointerUp))
			{
				WPjusxqaVfapPbgoWDxXXzbxpbSs(P_0, BPcAXmWgSdqhAqXnbMmsAafeiBM.UwJRECeDJpehOggKHfbGPdQtLFv);
			}
		}

		private void TQqqRdPAqtBgOkAYkMtExlUkktl(PointerEventData P_0)
		{
			if (base.initialized && TouchInteractable.DrebNyFyDDBAsDuDivulZyHbKPQe(P_0.pointerId, _touchRegion.allowedMouseButtons, EventTriggerType.PointerEnter))
			{
				KYCVoPCBzkDlHGLGqSdTRXEhtrF(P_0, BPcAXmWgSdqhAqXnbMmsAafeiBM.UwJRECeDJpehOggKHfbGPdQtLFv);
			}
		}

		private void MyLuMwEnqlRgbmTdLTEmHTvJicZ(PointerEventData P_0)
		{
			if (base.initialized && TouchInteractable.DrebNyFyDDBAsDuDivulZyHbKPQe(P_0.pointerId, _touchRegion.allowedMouseButtons, EventTriggerType.PointerExit))
			{
				wWwWoRfaNqJMPqaPcULexWSwZGt(P_0, BPcAXmWgSdqhAqXnbMmsAafeiBM.UwJRECeDJpehOggKHfbGPdQtLFv);
			}
		}

		private void bpolpxoeTDDDJApzKZFzruQYlpUb(float P_0)
		{
			if (base.initialized && !_useDigitalAxisSimulation)
			{
				BWTYBldZMpFDcLZggqvnVZiKTQd(null);
				_onAxisValueChanged.Invoke(P_0);
			}
		}

		private void xxCtHxojhYDbVZnDZABUYIVwuwv(bool P_0)
		{
			if (base.initialized)
			{
				BWTYBldZMpFDcLZggqvnVZiKTQd(null);
				_onButtonValueChanged.Invoke(P_0);
			}
		}

		private void semaiPkuwnSlvoHZHgEuFXNccjtB()
		{
			if (base.initialized)
			{
				BWTYBldZMpFDcLZggqvnVZiKTQd(null);
				_onButtonDown.Invoke();
			}
		}

		private void HgFwIsAPmEwLwElhNVDKbQXXCGRH()
		{
			if (base.initialized)
			{
				BWTYBldZMpFDcLZggqvnVZiKTQd(null);
				_onButtonUp.Invoke();
			}
		}
	}
}
