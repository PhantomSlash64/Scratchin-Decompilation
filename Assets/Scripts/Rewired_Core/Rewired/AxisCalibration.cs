using System;
using System.Collections.Generic;
using Rewired.Config;
using Rewired.Data.Mapping;
using Rewired.Utils;
using Rewired.Utils.Attributes;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	public sealed class AxisCalibration
	{
		private AlternateAxisCalibrationType _calibrationMode;

		private Dictionary<int, AxisCalibrationInfo> _hardwareCalibrations = new Dictionary<int, AxisCalibrationInfo> { 
		{
			0,
			AxisCalibrationInfo.vgqYbrmLzrVFoydFudXrAyZggmn(AxisCalibrationData.Default)
		} };

		[SerializeField]
		[CustomObfuscation(rename = false)]
		[Tooltip("Enables or disables the Axis. A disabled Axis always returns a value of 0.")]
		private bool _enabled = true;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		[Tooltip("Enables or disables the Axis. A disabled Axis always returns a value of 0.")]
		private float _deadZone;

		[Tooltip("Enables or disables the Axis. A disabled Axis always returns a value of 0.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private float _calibratedZero;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		[Tooltip("Gets or sets the minimum value. This can be used to transform the value to a new range.")]
		private float _calibratedMin;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		[Tooltip("Gets or sets the maximum value. This can be used to transform the value to a new range.")]
		private float _calibratedMax;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		[Tooltip("If true, the final value will be multiplied by -1. This can be used to correct an inverted Axis.")]
		private bool _invert;

		[Tooltip("Determines how sensitivity will be calculated.\nIf sensitivityType is set to Multiplier or Power, the sensitivity property is used to calculate the value.\nIf sensitivityType is set to Curve, the sensitivityCurve property is used to calculate the value.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private AxisSensitivityType _sensitivityType;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		[Tooltip("Gets or sets the sensitivity value.")]
		[FieldRange(0f, float.PositiveInfinity)]
		private float _sensitivity;

		[SerializeField]
		[Tooltip("Gets or sets the sensitivity curve. The curve has no effect unless sensitivityType is set to Curve.")]
		[CustomObfuscation(rename = false)]
		private AnimationCurve _sensitivityCurve;

		[Tooltip("If enabled, calibratedMin, calibratedMax, and calibratedZero will be used to convert the value to a new range.\nIf disabled, calibratedMin, calibratedMax, and calibratedZero will have no effect on the final value.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private bool _applyRangeCalibration = true;

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

		public float deadZone
		{
			get
			{
				return _deadZone;
			}
			set
			{
				_deadZone = MathTools.Abs(value);
			}
		}

		public float calibratedZero
		{
			get
			{
				return _calibratedZero;
			}
			set
			{
				_calibratedZero = value;
			}
		}

		public float calibratedMin
		{
			get
			{
				return _calibratedMin;
			}
			set
			{
				_calibratedMin = value;
			}
		}

		public float calibratedMax
		{
			get
			{
				return _calibratedMax;
			}
			set
			{
				_calibratedMax = value;
			}
		}

		public bool invert
		{
			get
			{
				return _invert;
			}
			set
			{
				_invert = value;
			}
		}

		public AxisSensitivityType sensitivityType
		{
			get
			{
				return _sensitivityType;
			}
			set
			{
				_sensitivityType = value;
			}
		}

		public float sensitivity
		{
			get
			{
				return _sensitivity;
			}
			set
			{
				_sensitivity = value;
			}
		}

		public AnimationCurve sensitivityCurve
		{
			get
			{
				return _sensitivityCurve;
			}
			set
			{
				_sensitivityCurve = value;
			}
		}

		public bool applyRangeCalibration
		{
			get
			{
				return _applyRangeCalibration;
			}
			set
			{
				_applyRangeCalibration = value;
			}
		}

		internal AlternateAxisCalibrationType calibrationMode
		{
			get
			{
				return _calibrationMode;
			}
			set
			{
				if (value != _calibrationMode)
				{
					_calibrationMode = value;
					Reset();
				}
			}
		}

		internal AxisCalibration()
		{
			CreateDefaultHardwareCalibration(GetData());
			Reset();
		}

		internal AxisCalibration(bool enabled, Dictionary<int, AxisCalibrationInfo> hardwareCalibrations, float deadZone, float calibratedZero, float calibratedMin, float calibratedMax, bool invert, bool applyRangeCalibration, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve)
		{
			_enabled = enabled;
			_deadZone = deadZone;
			_calibratedZero = calibratedZero;
			_calibratedMin = calibratedMin;
			_calibratedMax = calibratedMax;
			_invert = invert;
			_sensitivityType = sensitivityType;
			_sensitivity = sensitivity;
			_sensitivityCurve = sensitivityCurve;
			_applyRangeCalibration = applyRangeCalibration;
			InitHardwareCalibrations(hardwareCalibrations, GetData());
			Reset();
		}

		internal AxisCalibration(AxisCalibrationData hardwareData)
		{
			_enabled = hardwareData.enabled;
			InitHardwareCalibrations(hardwareData.calibrations, hardwareData);
			Reset();
		}

		internal void CopyFrom(AxisCalibration data, bool copyHardwareData)
		{
			if (data != null)
			{
				if (copyHardwareData)
				{
					_hardwareCalibrations = MiscTools.DeepClone(data._hardwareCalibrations);
				}
				_enabled = data._enabled;
				_deadZone = MathTools.Abs(data._deadZone);
				_calibratedZero = data._calibratedZero;
				_calibratedMin = data._calibratedMin;
				_calibratedMax = data._calibratedMax;
				_invert = data._invert;
				_applyRangeCalibration = data._applyRangeCalibration;
				_sensitivityType = data._sensitivityType;
				_sensitivity = data._sensitivity;
				_sensitivityCurve = UnityTools.Copy(data._sensitivityCurve);
			}
		}

		public float GetCalibratedValue(float value)
		{
			return GetCalibratedValue(value, _deadZone, applySensitivity: true, applyInversion: true);
		}

		internal float GetCalibratedValue(float value, float customDeadzone, bool applySensitivity, bool applyInversion)
		{
			if (!_enabled)
			{
				return 0f;
			}
			if (_applyRangeCalibration)
			{
				return InputTools.GetCalibratedAxisValueClamped(value, _calibratedZero, _calibratedMin, _calibratedMax, customDeadzone, applyInversion && _invert, applySensitivity, _sensitivityType, _sensitivity, _sensitivityCurve);
			}
			return InputTools.GetCalibratedAxisValue(value, customDeadzone, applyInversion && _invert, applySensitivity, _sensitivityType, _sensitivity, _sensitivityCurve);
		}

		public float GetCalibratedValue(float value, AxisRange axisRange)
		{
			return GetCalibratedValue(value, axisRange, _deadZone, applySensitivity: true, applyInversion: true);
		}

		internal float GetCalibratedValue(float value, AxisRange axisRange, float customDeadzone, bool applySensitivity, bool applyInversion)
		{
			if (!_enabled)
			{
				return 0f;
			}
			value = ((!_applyRangeCalibration) ? InputTools.GetCalibratedAxisValue(value, customDeadzone, invert: false, applySensitivity, _sensitivityType, _sensitivity, _sensitivityCurve) : InputTools.GetCalibratedAxisValueClamped(value, _calibratedZero, _calibratedMin, _calibratedMax, customDeadzone, invert: false, applySensitivity, _sensitivityType, _sensitivity, _sensitivityCurve));
			switch (axisRange)
			{
			case AxisRange.Positive:
				if (value < 0f)
				{
					return 0f;
				}
				break;
			case AxisRange.Negative:
				if (value > 0f)
				{
					return 0f;
				}
				break;
			}
			if (MathTools.Approximately(value, 0f))
			{
				return 0f;
			}
			if (applyInversion && _invert)
			{
				value *= -1f;
			}
			return value;
		}

		public AxisCalibrationData GetData()
		{
			AxisCalibrationData result = new AxisCalibrationData(_enabled, _deadZone, _calibratedZero, _calibratedMin, _calibratedMax, _invert, _applyRangeCalibration, _sensitivityType, _sensitivity, _sensitivityCurve);
			result.calibrations = MiscTools.DeepClone(_hardwareCalibrations);
			return result;
		}

		public void SetData(AxisCalibrationData data)
		{
			_enabled = data.enabled;
			_deadZone = MathTools.Abs(data.deadZone);
			_calibratedZero = data.zero;
			_calibratedMin = data.min;
			_calibratedMax = data.max;
			_invert = data.invert;
			_applyRangeCalibration = data.applyRangeCalibration;
			_sensitivityType = data.sensitivityType;
			_sensitivity = data.sensitivity;
			_sensitivityCurve = data.sensitivityCurve;
		}

		public void Reset()
		{
			_enabled = true;
			AxisCalibrationInfo hardwareDefault = GetHardwareDefault();
			if (hardwareDefault == null)
			{
				Logger.LogError("Hardware default calibration info was not found.");
				return;
			}
			_deadZone = hardwareDefault.deadZone;
			_calibratedZero = hardwareDefault.zero;
			_calibratedMin = hardwareDefault.min;
			_calibratedMax = hardwareDefault.max;
			_invert = hardwareDefault.invert;
			_applyRangeCalibration = hardwareDefault.applyRangeCalibration;
			_sensitivityType = hardwareDefault.sensitivityType;
			_sensitivity = hardwareDefault.sensitivity;
			_sensitivityCurve = UnityTools.Copy(hardwareDefault.sensitivityCurve);
		}

		internal SerializedObject ExportData()
		{
			SerializedObject serializedObject = new SerializedObject(GetType(), SerializedObject.ObjectType.Object);
			serializedObject.Add("enabled", _enabled);
			serializedObject.Add("deadZone", _deadZone);
			serializedObject.Add("calibratedZero", _calibratedZero);
			serializedObject.Add("calibratedMin", _calibratedMin);
			serializedObject.Add("calibratedMax", _calibratedMax);
			serializedObject.Add("invert", _invert);
			serializedObject.Add("sensitivity", _sensitivity);
			serializedObject.Add("applyRangeCalibration", _applyRangeCalibration);
			serializedObject.Add("sensitivityType", _sensitivityType);
			serializedObject.Add("sensitivityCurve", _sensitivityCurve);
			return serializedObject;
		}

		internal void Import(SerializedObject serializedObject)
		{
			if (serializedObject != null)
			{
				Reset();
				serializedObject.TryGetDeserializedValueByRef("enabled", ref _enabled);
				serializedObject.TryGetDeserializedValueByRef("deadZone", ref _deadZone);
				serializedObject.TryGetDeserializedValueByRef("calibratedZero", ref _calibratedZero);
				serializedObject.TryGetDeserializedValueByRef("calibratedMin", ref _calibratedMin);
				serializedObject.TryGetDeserializedValueByRef("calibratedMax", ref _calibratedMax);
				serializedObject.TryGetDeserializedValueByRef("invert", ref _invert);
				serializedObject.TryGetDeserializedValueByRef("sensitivity", ref _sensitivity);
				serializedObject.TryGetDeserializedValueByRef("applyRangeCalibration", ref _applyRangeCalibration);
				serializedObject.TryGetDeserializedValueByRef("sensitivityType", ref _sensitivityType);
				serializedObject.TryGetDeserializedValueByRef("sensitivityCurve", ref _sensitivityCurve);
				_deadZone = MathTools.Abs(_deadZone);
			}
		}

		private void InitHardwareCalibrations(Dictionary<int, AxisCalibrationInfo> hardwareCalibrations, AxisCalibrationData defaultData)
		{
			_hardwareCalibrations.Clear();
			if (hardwareCalibrations != null)
			{
				foreach (KeyValuePair<int, AxisCalibrationInfo> hardwareCalibration in hardwareCalibrations)
				{
					_hardwareCalibrations.Add(hardwareCalibration.Key, MiscTools.DeepClone(hardwareCalibration.Value));
				}
			}
			CreateDefaultHardwareCalibration(defaultData);
		}

		private void CreateDefaultHardwareCalibration(AxisCalibrationData defaultData)
		{
			if (!_hardwareCalibrations.ContainsKey(0))
			{
				AxisCalibrationInfo value = AxisCalibrationInfo.vgqYbrmLzrVFoydFudXrAyZggmn(defaultData);
				_hardwareCalibrations.Add(0, value);
			}
		}

		private AxisCalibrationInfo GetHardwareDefault()
		{
			AxisCalibrationInfo value = null;
			if (_calibrationMode == AlternateAxisCalibrationType.ThrottleZeroCenter && ReInput.configVars.throttleCalibrationMode == ThrottleCalibrationMode.NegativeOneToOne && _hardwareCalibrations.TryGetValue(1, out value))
			{
				return value;
			}
			_hardwareCalibrations.TryGetValue(0, out value);
			return value;
		}

		internal static AxisCalibration CreateRelative()
		{
			AxisSensitivityType axisSensitivityType = (ReInput.isReady ? ReInput.configVars.defaultAxisSensitivityType : AxisSensitivityType.Multiplier);
			return new AxisCalibration(enabled: true, new Dictionary<int, AxisCalibrationInfo> { 
			{
				0,
				new AxisCalibrationInfo(0f, 0f, -1f, 1f, invert: false, applyRangeCalibration: false, axisSensitivityType, 1f, AnimationCurve.Linear(0f, 1f, 1f, 1f))
			} }, 0f, 0f, -1f, 1f, invert: false, applyRangeCalibration: false, axisSensitivityType, 1f, AnimationCurve.Linear(0f, 1f, 1f, 1f));
		}
	}
}
