using System;
using Rewired.Utils;
using UnityEngine;

namespace Rewired.Internal
{
	[Serializable]
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal sealed class StandaloneAxis2D
	{
		[CustomObfuscation(rename = false)]
		public delegate void ValueChangedEventHandler(Vector2 value);

		[SerializeField]
		[CustomObfuscation(rename = false)]
		[Tooltip("Contains calibration settings for the 2D axis.")]
		private Axis2DCalibration _calibration = new Axis2DCalibration();

		[CustomObfuscation(rename = false)]
		[SerializeField]
		[Tooltip("The X axis.")]
		private StandaloneAxis _xAxis = new StandaloneAxis();

		[Tooltip("The Y axis.")]
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private StandaloneAxis _yAxis = new StandaloneAxis();

		private bool _allowEvents = true;

		public Axis2DCalibration calibration => _calibration;

		public StandaloneAxis xAxis => _xAxis;

		public StandaloneAxis yAxis => _yAxis;

		public Vector2 value => GetCalibratedValue(_xAxis, _yAxis);

		public Vector2 valuePrev => GetCalibratedValuePrev(_xAxis, _yAxis);

		public Vector2 valueDelta => value - valuePrev;

		public Vector2 rawValue => new Vector2((_xAxis != null) ? _xAxis.value : 0f, (_yAxis != null) ? _yAxis.value : 0f);

		public Vector2 rawValuePrev => new Vector2((_xAxis != null) ? _xAxis.valuePrev : 0f, (_yAxis != null) ? _yAxis.valuePrev : 0f);

		public Vector2 rawValueDelta => rawValue - rawValuePrev;

		internal Vector2 rawZero => new Vector2((_xAxis != null) ? _xAxis.rawZero : 0f, (_yAxis != null) ? _yAxis.rawZero : 0f);

		private event ValueChangedEventHandler _ValueChangedEvent;

		public event ValueChangedEventHandler ValueChangedEvent
		{
			add
			{
				_ValueChangedEvent += value;
			}
			remove
			{
				_ValueChangedEvent -= value;
			}
		}

		private event ValueChangedEventHandler _RawValueChangedEvent;

		public event ValueChangedEventHandler RawValueChangedEvent
		{
			add
			{
				_RawValueChangedEvent += value;
			}
			remove
			{
				_RawValueChangedEvent -= value;
			}
		}

		internal StandaloneAxis2D()
		{
		}

		internal StandaloneAxis2D(StandaloneAxis xAxis, StandaloneAxis yAxis)
		{
			_xAxis = xAxis;
			_yAxis = yAxis;
		}

		public void SetRawValue(float x, float y)
		{
			bool allowEvents = _allowEvents;
			_allowEvents = false;
			if (_xAxis != null)
			{
				_xAxis.SetRawValue(x);
			}
			if (_yAxis != null)
			{
				_yAxis.SetRawValue(y);
			}
			_allowEvents = allowEvents;
			EvalAndSendValueChangeEvents();
		}

		public void SetRawValue(Vector2 value)
		{
			SetRawValue(value.x, value.y);
		}

		public void Clear()
		{
			bool allowEvents = _allowEvents;
			_allowEvents = false;
			if (_xAxis != null)
			{
				_xAxis.Clear();
			}
			if (_yAxis != null)
			{
				_yAxis.Clear();
			}
			_allowEvents = allowEvents;
			EvalAndSendValueChangeEvents();
		}

		internal void Initialize()
		{
			Subscribe();
		}

		internal void Deinitialize()
		{
			Unsubscribe();
		}

		private void EvalAndSendValueChangeEvents()
		{
			if (!_allowEvents)
			{
				Vector2 vector = rawValueDelta;
				if (!MathTools.ApproximatelyZero(vector.x) && !MathTools.ApproximatelyZero(vector.y) && this._RawValueChangedEvent != null)
				{
					this._RawValueChangedEvent(rawValue);
				}
				Vector2 vector2 = valueDelta;
				if (!MathTools.ApproximatelyZero(vector2.x) && !MathTools.ApproximatelyZero(vector2.y) && this._ValueChangedEvent != null)
				{
					this._ValueChangedEvent(value);
				}
			}
		}

		private void Subscribe()
		{
			Unsubscribe();
			if (_xAxis != null)
			{
				_xAxis.AxisValueChangedEvent += OnAxisValueChanged;
				_xAxis.RawAxisValueChangedEvent += OnAxisRawValueChanged;
			}
			if (_yAxis != null)
			{
				_yAxis.AxisValueChangedEvent += OnAxisValueChanged;
				_yAxis.RawAxisValueChangedEvent += OnAxisRawValueChanged;
			}
		}

		private void Unsubscribe()
		{
			if (_xAxis != null)
			{
				_xAxis.AxisValueChangedEvent -= OnAxisValueChanged;
				_xAxis.RawAxisValueChangedEvent -= OnAxisRawValueChanged;
			}
			if (_yAxis != null)
			{
				_yAxis.AxisValueChangedEvent -= OnAxisValueChanged;
				_yAxis.RawAxisValueChangedEvent -= OnAxisRawValueChanged;
			}
		}

		private Vector2 GetCalibratedValue(StandaloneAxis xAxis, StandaloneAxis yAxis)
		{
			if (_calibration == null)
			{
				return Vector2.zero;
			}
			AxisCalibration axisCalibration;
			float valueRawX;
			if (xAxis != null)
			{
				axisCalibration = xAxis.calibration;
				valueRawX = xAxis.valueRaw;
			}
			else
			{
				axisCalibration = null;
				valueRawX = 0f;
			}
			AxisCalibration axisCalibration2;
			float valueRawY;
			if (yAxis != null)
			{
				axisCalibration2 = yAxis.calibration;
				valueRawY = yAxis.valueRaw;
			}
			else
			{
				axisCalibration2 = null;
				valueRawY = 0f;
			}
			return _calibration.GetCalibrated2DValue(valueRawX, valueRawY, axisCalibration, axisCalibration2);
		}

		private Vector2 GetCalibratedValuePrev(StandaloneAxis xAxis, StandaloneAxis yAxis)
		{
			if (_calibration == null)
			{
				return Vector2.zero;
			}
			AxisCalibration axisCalibration;
			float valueRawX;
			if (xAxis != null)
			{
				axisCalibration = xAxis.calibration;
				valueRawX = xAxis.valueRawPrev;
			}
			else
			{
				axisCalibration = null;
				valueRawX = 0f;
			}
			AxisCalibration axisCalibration2;
			float valueRawY;
			if (yAxis != null)
			{
				axisCalibration2 = yAxis.calibration;
				valueRawY = yAxis.valueRawPrev;
			}
			else
			{
				axisCalibration2 = null;
				valueRawY = 0f;
			}
			return _calibration.GetCalibrated2DValue(valueRawX, valueRawY, axisCalibration, axisCalibration2);
		}

		private void OnAxisValueChanged(float value)
		{
			if (!_allowEvents && this._ValueChangedEvent != null)
			{
				this._ValueChangedEvent(this.value);
			}
		}

		private void OnAxisRawValueChanged(float value)
		{
			if (!_allowEvents && this._RawValueChangedEvent != null)
			{
				this._RawValueChangedEvent(rawValue);
			}
		}

		internal static StandaloneAxis2D CreateRelative()
		{
			StandaloneAxis2D standaloneAxis2D = new StandaloneAxis2D(StandaloneAxis.CreateRelative(), StandaloneAxis.CreateRelative());
			standaloneAxis2D.calibration.deadZoneType = DeadZone2DType.Radial;
			standaloneAxis2D.calibration.sensitivityType = AxisSensitivity2DType.Radial;
			return standaloneAxis2D;
		}
	}
}
