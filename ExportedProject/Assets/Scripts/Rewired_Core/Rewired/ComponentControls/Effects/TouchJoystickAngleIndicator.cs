using Rewired.UI;
using Rewired.Utils;
using Rewired.Utils.Interfaces;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.ComponentControls.Effects
{
	[ExecuteInEditMode]
	[AddComponentMenu("Rewired/Touch Joystick Angle Indicator")]
	[RequireComponent(typeof(RectTransform))]
	[RequireComponent(typeof(Image))]
	[DisallowMultipleComponent]
	public sealed class TouchJoystickAngleIndicator : MonoBehaviour, IVisibilityChangedHandler, TouchJoystick.IStickPositionChangedHandler
	{
		[CustomObfuscation(rename = false)]
		[SerializeField]
		[Tooltip("Toggles visibility.")]
		private bool _visible = true;

		[Tooltip("If enabled, the target angle will be determined by the transform's Local Rotation Z. Otherwise, the activation angle must be manually set.")]
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private bool _targetAngleFromRotation = true;

		[CustomObfuscation(rename = false)]
		[Range(0f, -360f)]
		[Tooltip("The joystick angle at which this object should be considered fully active.\n0 = up with negative values increase rotating clockwise. Example: -45 degrees = up-right.")]
		[SerializeField]
		private float _targetAngle;

		[Tooltip("If enabled, the color will fade in and out based on the current joystick value.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private bool _fadeWithValue = true;

		[Tooltip("If enabled, the color will fade in and out based on the current joystick angle. As the angle approaches the Target Angle, the color will become more intense.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private bool _fadeWithAngle = true;

		[Tooltip("The angle of rotation away from the Target Angle where the color fully fades out. If Fade with Angle is enabled, this is used to determine when the color will fully fade out when the joystick angle rotates away from the the Target Angle. This should be set to 1/2 of the complete rotation arc. Example: A value of 45 degrees would make the color fully fade out when the joystick angle is 45 degrees away from the Target Angle on either side, giving a complete arc of 90 degrees.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		[Range(0f, 360f)]
		private float _fadeRange = 45f;

		[SerializeField]
		[Tooltip("The color when fully active.")]
		[CustomObfuscation(rename = false)]
		private Color _activeColor = new Color(1f, 1f, 1f, 1f);

		[Tooltip("The color when not active.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private Color _normalColor = new Color(1f, 1f, 1f, 0.3f);

		private Image klYAbqgLmMfwYjhkbaIdHosZeDpE;

		private RectTransform BcIAwJgSnLFxVbKeBcwrOGXvzwTM;

		private Vector2 rqQpfJTPpXicjejhddZdinXkfpoA;

		private bool VSRpyeZHBrstdqXMUTJAxiROgGB;

		private IRegistrar<TouchJoystickAngleIndicator> knahbdAwJeAgBIoUDORVlRERkJn;

		public bool visible
		{
			get
			{
				return _visible;
			}
			set
			{
				if (visible != value)
				{
					gsBWXLHgffgyumxKGHWadDMtmCl(value, false);
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool targetAngleFromRotation
		{
			get
			{
				return _targetAngleFromRotation;
			}
			set
			{
				if (_targetAngleFromRotation != value)
				{
					_targetAngleFromRotation = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public float targetAngle
		{
			get
			{
				if (!_targetAngleFromRotation)
				{
					return _targetAngle;
				}
				return base.transform.localEulerAngles.z;
			}
			set
			{
				if (_targetAngle != value)
				{
					_targetAngle = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool fadeWithValue
		{
			get
			{
				return _fadeWithValue;
			}
			set
			{
				if (_fadeWithValue != value)
				{
					_fadeWithValue = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool fadeWithAngle
		{
			get
			{
				return _fadeWithAngle;
			}
			set
			{
				if (_fadeWithAngle != value)
				{
					_fadeWithAngle = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public float fadeRange
		{
			get
			{
				return _fadeRange;
			}
			set
			{
				if (_fadeRange != value)
				{
					_fadeRange = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public Color activeColor
		{
			get
			{
				return _activeColor;
			}
			set
			{
				_activeColor = value;
				QCALZHBveTZKrIACkwpJsrxWoUa();
			}
		}

		public Color normalColor
		{
			get
			{
				return _normalColor;
			}
			set
			{
				_normalColor = value;
				QCALZHBveTZKrIACkwpJsrxWoUa();
			}
		}

		internal Image image => klYAbqgLmMfwYjhkbaIdHosZeDpE ?? (klYAbqgLmMfwYjhkbaIdHosZeDpE = GetComponent<Image>());

		internal Sprite currentSprite
		{
			get
			{
				if (image == null)
				{
					return null;
				}
				if (klYAbqgLmMfwYjhkbaIdHosZeDpE.overrideSprite != null)
				{
					return klYAbqgLmMfwYjhkbaIdHosZeDpE.overrideSprite;
				}
				return klYAbqgLmMfwYjhkbaIdHosZeDpE.sprite;
			}
		}

		internal RectTransform rectTransform => BcIAwJgSnLFxVbKeBcwrOGXvzwTM ?? (BcIAwJgSnLFxVbKeBcwrOGXvzwTM = GetComponent<RectTransform>());

		[CustomObfuscation(rename = false)]
		private TouchJoystickAngleIndicator()
		{
		}

		internal bool jfKAJWpVbRiZcBdRDInMeTSZkLnI(out Vector2 P_0)
		{
			P_0 = Vector2.zero;
			if (image == null)
			{
				return false;
			}
			Sprite sprite = klYAbqgLmMfwYjhkbaIdHosZeDpE.overrideSprite ?? klYAbqgLmMfwYjhkbaIdHosZeDpE.sprite;
			if (sprite == null)
			{
				return false;
			}
			Rect textureRect = sprite.textureRect;
			P_0.x = textureRect.width;
			P_0.y = textureRect.height;
			return true;
		}

		[CustomObfuscation(rename = false)]
		private void Awake()
		{
			OnTouchJoystickStickPositionChanged(Vector2.zero);
			WZPeFoCBZnPVDMdblWQzSIxmNYWb();
		}

		[CustomObfuscation(rename = false)]
		private void OnEnable()
		{
			if (!Application.isPlaying)
			{
				WZPeFoCBZnPVDMdblWQzSIxmNYWb();
				IPafiGqiDgzIAKGKGzuESxpFegQ();
			}
			aEpfSZLoJsOEzitBGNfwYbILgHd(rqQpfJTPpXicjejhddZdinXkfpoA);
		}

		[CustomObfuscation(rename = false)]
		private void OnDisable()
		{
			dfpDcGeWVcWivVAcwCAIytkZofUa();
		}

		[CustomObfuscation(rename = false)]
		private void OnValidate()
		{
			WPUbSrkLzPwInKgvbMqbWlBJhpcg();
			aEpfSZLoJsOEzitBGNfwYbILgHd(rqQpfJTPpXicjejhddZdinXkfpoA);
		}

		[CustomObfuscation(rename = false)]
		private void OnTransformParentChanged()
		{
			IPafiGqiDgzIAKGKGzuESxpFegQ();
		}

		private void gsBWXLHgffgyumxKGHWadDMtmCl(bool P_0, bool P_1)
		{
			if (_visible != P_0 || P_1)
			{
				_visible = P_0;
				if (!P_0)
				{
					Color targetColor = _normalColor;
					targetColor.a = 0f;
					image.CrossFadeColor(targetColor, 0f, ignoreTimeScale: true, useAlpha: true);
				}
				else
				{
					aEpfSZLoJsOEzitBGNfwYbILgHd(rqQpfJTPpXicjejhddZdinXkfpoA);
				}
			}
		}

		private void aEpfSZLoJsOEzitBGNfwYbILgHd(Vector2 P_0)
		{
			if (!_visible)
			{
				Color targetColor = _normalColor;
				targetColor.a = 0f;
				image.CrossFadeColor(targetColor, 0f, ignoreTimeScale: true, useAlpha: true);
			}
			else if (!MathTools.ApproximatelyZero(P_0.sqrMagnitude))
			{
				float magnitude = P_0.magnitude;
				float num = Vector2.Angle(Vector2.up, P_0);
				float target = (_targetAngleFromRotation ? base.transform.localEulerAngles.z : _targetAngle) * -1f;
				float num2 = ((P_0.x < 0f) ? (360f - num) : num);
				Color targetColor2;
				if (_fadeWithAngle || _fadeWithValue)
				{
					float num3 = 1f;
					if (_fadeWithValue)
					{
						num3 *= magnitude;
					}
					if (_fadeWithAngle)
					{
						float num4 = Mathf.Abs(MathTools.DeltaAngle(num2, target));
						float num5 = ((_fadeRange != 0f) ? MathTools.Clamp01(1f - num4 / _fadeRange) : 1f);
						num3 *= num5;
					}
					targetColor2 = Color.Lerp(_normalColor, _activeColor, num3);
				}
				else
				{
					targetColor2 = (MathTools.AngleIsNear(num2, target, _fadeRange) ? _activeColor : _normalColor);
				}
				image.CrossFadeColor(targetColor2, 0f, ignoreTimeScale: true, useAlpha: true);
			}
			else
			{
				image.CrossFadeColor(_normalColor, 0f, ignoreTimeScale: true, useAlpha: true);
			}
		}

		private void WZPeFoCBZnPVDMdblWQzSIxmNYWb()
		{
			VSRpyeZHBrstdqXMUTJAxiROgGB = _visible;
		}

		private void WPUbSrkLzPwInKgvbMqbWlBJhpcg()
		{
			if (VSRpyeZHBrstdqXMUTJAxiROgGB != _visible)
			{
				VSRpyeZHBrstdqXMUTJAxiROgGB = _visible;
				gsBWXLHgffgyumxKGHWadDMtmCl(_visible, true);
			}
		}

		private void QCALZHBveTZKrIACkwpJsrxWoUa()
		{
		}

		private void IPafiGqiDgzIAKGKGzuESxpFegQ()
		{
			dfpDcGeWVcWivVAcwCAIytkZofUa();
			IRegistrar<TouchJoystickAngleIndicator> componentInSelfOrParents = UnityTools.GetComponentInSelfOrParents<IRegistrar<TouchJoystickAngleIndicator>>(base.transform);
			if (!componentInSelfOrParents.IsNullOrDestroyed())
			{
				componentInSelfOrParents.Register(this);
				knahbdAwJeAgBIoUDORVlRERkJn = componentInSelfOrParents;
			}
		}

		private void dfpDcGeWVcWivVAcwCAIytkZofUa()
		{
			if (knahbdAwJeAgBIoUDORVlRERkJn.IsNullOrDestroyed())
			{
				if (knahbdAwJeAgBIoUDORVlRERkJn != null)
				{
					knahbdAwJeAgBIoUDORVlRERkJn = null;
				}
			}
			else
			{
				knahbdAwJeAgBIoUDORVlRERkJn.Deregister(this);
				knahbdAwJeAgBIoUDORVlRERkJn = null;
			}
		}

		public void OnVisibilityChanged(bool state)
		{
			gsBWXLHgffgyumxKGHWadDMtmCl(state, false);
		}

		public void OnTouchJoystickStickPositionChanged(Vector2 value)
		{
			if (!(this == null))
			{
				rqQpfJTPpXicjejhddZdinXkfpoA = value;
				if (UnityTools.IsActiveAndEnabled(this) && _visible)
				{
					aEpfSZLoJsOEzitBGNfwYbILgHd(value);
				}
			}
		}

		private void kfPeDtZVVWzxDHFkfxYSqwEmeeo(Vector2 P_0)
		{
			OnTouchJoystickStickPositionChanged(P_0);
		}

		void TouchJoystick.IStickPositionChangedHandler.OnStickPositionChanged(Vector2 P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in kfPeDtZVVWzxDHFkfxYSqwEmeeo
			this.kfPeDtZVVWzxDHFkfxYSqwEmeeo(P_0);
		}
	}
}
