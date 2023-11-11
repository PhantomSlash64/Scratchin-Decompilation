using System;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using Rewired.Utils;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[AddComponentMenu("Rewired/Tilt Control")]
	[DisallowMultipleComponent]
	public sealed class TiltControl : CustomControllerControl
	{
		public enum TiltDirection
		{
			Both = 0,
			Horizontal = 1,
			Forward = 2
		}

		private const float maxFullTiltAngle = 180f;

		private const float maxAngleOffset = 90f;

		[Tooltip("The tilt directions in which movement is allowed. You can restrict movement to one or both directions.")]
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private TiltDirection _allowedTiltDirections;

		[CustomObfuscation(rename = false)]
		[Tooltip("The Custom Controller element that will receive input values from the X axis.")]
		[SerializeField]
		private CustomControllerElementTargetSetForFloat _horizontalTiltCustomControllerElement = new CustomControllerElementTargetSetForFloat();

		[SerializeField]
		[CustomObfuscation(rename = false)]
		[Range(0f, 180f)]
		[Tooltip("The maximum horizontal tilt angle in degrees. When the device is tilted to this angle or further in either direction, the axis will return a value of 1/-1.")]
		private float _horizontalTiltLimit = 25f;

		[Tooltip("The offset angle from horizontal which will be considered the resting angle. This represents the angle at which the user holds the device without generating tilt.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		[Range(-90f, 90f)]
		private float _horizontalRestAngle;

		[SerializeField]
		[Tooltip("The Custom Controller element that will receive input values from the Y axis.")]
		[CustomObfuscation(rename = false)]
		private CustomControllerElementTargetSetForFloat _forwardTiltCustomControllerElement = new CustomControllerElementTargetSetForFloat();

		[CustomObfuscation(rename = false)]
		[Tooltip("The maximum forward tilt angle in degrees. When the device is tilted to this angle or further in either direction, the axis will return a value of 1/-1.")]
		[Range(0f, 180f)]
		[SerializeField]
		private float _forwardTiltLimit = 25f;

		[Range(-90f, 90f)]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		[Tooltip("The offset angle from vertical which will be considered the resting angle. This represents the angle at which the user holds the device without generating tilt. A typical value would be around 40 degrees.")]
		private float _forwardRestAngle = 40f;

		[Tooltip("The underlying 2D axis.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private StandaloneAxis2D _axis2D = new StandaloneAxis2D();

		private bool _useHAxis;

		private bool _useFAxis;

		private Func<Vector3> _getAccelerationValue;

		public TiltDirection axesToUse
		{
			get
			{
				return _allowedTiltDirections;
			}
			set
			{
				if (_allowedTiltDirections != value)
				{
					XJXrPLMAhmINhFxIxGxogYJVNP(value);
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public CustomControllerElementTargetSetForFloat horizontalTiltCustomControllerElement => _horizontalTiltCustomControllerElement;

		public float horizontalTiltLimit
		{
			get
			{
				return _horizontalTiltLimit;
			}
			set
			{
				value = MathTools.Clamp(value, 0f, 180f);
				if (_horizontalTiltLimit != value)
				{
					_horizontalTiltLimit = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public float horizontalRestAngle
		{
			get
			{
				return _horizontalRestAngle;
			}
			set
			{
				value = MathTools.Clamp(value, -90f, 90f);
				if (_horizontalRestAngle != value)
				{
					_horizontalRestAngle = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public CustomControllerElementTargetSetForFloat forwardTiltCustomControllerElement => _forwardTiltCustomControllerElement;

		public float forwardTiltLimit
		{
			get
			{
				return _forwardTiltLimit;
			}
			set
			{
				value = MathTools.Clamp(value, 0f, 180f);
				if (_forwardTiltLimit != value)
				{
					_forwardTiltLimit = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public float forwardRestAngle
		{
			get
			{
				return _forwardRestAngle;
			}
			set
			{
				value = MathTools.Clamp(value, -90f, 90f);
				if (_forwardRestAngle != value)
				{
					_forwardRestAngle = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public AxisCalibration horizontalAxisCalibration => _axis2D.xAxis.calibration;

		public AxisCalibration verticalAxisCalibration => _axis2D.yAxis.calibration;

		[Obsolete("Use axis2DCalibration instead.", false)]
		public Axis2DCalibration deadZoneType => _axis2D.calibration;

		public Axis2DCalibration axis2DCalibration => _axis2D.calibration;

		internal StandaloneAxis2D axis2D => _axis2D;

		private Vector3 acceleration
		{
			get
			{
				if (_getAccelerationValue == null)
				{
					return Input.acceleration;
				}
				return _getAccelerationValue();
			}
		}

		[CustomObfuscation(rename = false)]
		internal TiltControl()
		{
		}

		public void SetAccelerationSourceCallback(Func<Vector3> callback)
		{
			_getAccelerationValue = callback;
		}

		public void SetRestOrientation()
		{
			Vector3 vector = acceleration;
			horizontalRestAngle = Mathf.Atan2(vector.x, 0f - vector.y) * 57.29578f * -1f;
			forwardRestAngle = Mathf.Atan2(vector.z, 0f - vector.y) * 57.29578f * -1f;
		}

		[CustomObfuscation(rename = false)]
		internal override void OnValidate()
		{
			base.OnValidate();
			if (base.initialized)
			{
				qLvLdQPJGtBHAeGzYStIlmzIJIwh();
			}
		}

		internal override bool sTGamvWFKxGXQiXUVibUDPQNCmv()
		{
			if (!base.sTGamvWFKxGXQiXUVibUDPQNCmv())
			{
				return false;
			}
			qLvLdQPJGtBHAeGzYStIlmzIJIwh();
			return true;
		}

		internal override void EsMhoPqAHoBFPBeDrJCrkGzDsbv()
		{
			base.EsMhoPqAHoBFPBeDrJCrkGzDsbv();
			if (base.initialized)
			{
				MlvAorYIIDArsICrUAeRJJGPMajJ();
			}
		}

		internal override void mmZvUkQigzMnepEREFECJZiFGep()
		{
			if (base.initialized && hasController)
			{
				if (_useFAxis)
				{
					PoPxMfVjbMVVIVtkgNooWLPvukf(_forwardTiltCustomControllerElement, _axis2D.yAxis.value, _axis2D.yAxis.buttonActivationThreshold);
				}
				if (_useHAxis)
				{
					PoPxMfVjbMVVIVtkgNooWLPvukf(_horizontalTiltCustomControllerElement, _axis2D.xAxis.value, _axis2D.xAxis.buttonActivationThreshold);
				}
			}
		}

		public override void ClearValue()
		{
			_axis2D.xAxis.Clear();
			_axis2D.yAxis.Clear();
			if (hasController)
			{
				base.controller.ClearElementValue(_horizontalTiltCustomControllerElement);
				base.controller.ClearElementValue(_forwardTiltCustomControllerElement);
			}
		}

		private void MlvAorYIIDArsICrUAeRJJGPMajJ()
		{
			if (_useHAxis)
			{
				float rawValue;
				if (acceleration == Vector3.zero)
				{
					rawValue = 0f;
				}
				else
				{
					float value = Mathf.Atan2(acceleration.x, 0f - acceleration.y) * 57.29578f + _horizontalRestAngle;
					rawValue = Mathf.InverseLerp(0f - _horizontalTiltLimit, _horizontalTiltLimit, value) * 2f - 1f;
				}
				_axis2D.xAxis.SetRawValue(rawValue);
			}
			if (_useFAxis)
			{
				float num;
				if (acceleration == Vector3.zero)
				{
					num = 0f;
				}
				else
				{
					float value2 = Mathf.Atan2(acceleration.z, 0f - acceleration.y) * 57.29578f + _forwardRestAngle;
					num = Mathf.InverseLerp(0f - _forwardTiltLimit, _forwardTiltLimit, value2) * 2f - 1f;
				}
				_axis2D.yAxis.SetRawValue(0f - num);
			}
		}

		private void qLvLdQPJGtBHAeGzYStIlmzIJIwh()
		{
			XJXrPLMAhmINhFxIxGxogYJVNP(_allowedTiltDirections);
			if (hasController)
			{
				if (_useHAxis)
				{
					base.controller.ValidateElements(_horizontalTiltCustomControllerElement);
				}
				if (_useFAxis)
				{
					base.controller.ValidateElements(_forwardTiltCustomControllerElement);
				}
			}
		}

		private void XJXrPLMAhmINhFxIxGxogYJVNP(TiltDirection P_0)
		{
			bool flag = P_0 == TiltDirection.Both || P_0 == TiltDirection.Horizontal;
			if (_useHAxis != flag)
			{
				_useHAxis = flag;
				if (!flag && hasController)
				{
					base.controller.ClearElementValue(_horizontalTiltCustomControllerElement);
				}
			}
			bool flag2 = P_0 == TiltDirection.Both || P_0 == TiltDirection.Forward;
			if (_useFAxis != flag2)
			{
				_useFAxis = flag2;
				if (!flag2 && hasController)
				{
					base.controller.ClearElementValue(_forwardTiltCustomControllerElement);
				}
			}
			_allowedTiltDirections = P_0;
		}
	}
}
