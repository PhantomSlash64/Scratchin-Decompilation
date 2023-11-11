using System.Collections.Generic;
using Rewired.Data.Mapping;
using UnityEngine;

namespace Rewired
{
	public struct AxisCalibrationData
	{
		public bool enabled;

		public float deadZone;

		public float zero;

		public float min;

		public float max;

		public bool invert;

		public AxisSensitivityType sensitivityType;

		public float sensitivity;

		public AnimationCurve sensitivityCurve;

		public bool applyRangeCalibration;

		[CustomObfuscation(rename = false)]
		internal Dictionary<int, AxisCalibrationInfo> calibrations;

		public static AxisCalibrationData Default
		{
			get
			{
				AxisSensitivityType axisSensitivityType = (ReInput.isReady ? ReInput.configVars.defaultAxisSensitivityType : AxisSensitivityType.Multiplier);
				return new AxisCalibrationData(enabled: true, 0f, 0f, -1f, 1f, invert: false, applyRangeCalibration: true, axisSensitivityType, 1f, (axisSensitivityType == AxisSensitivityType.Curve) ? AnimationCurve.Linear(-1f, 1f, 1f, 1f) : null);
			}
		}

		[CustomObfuscation(rename = false)]
		internal static AxisCalibrationData Raw
		{
			get
			{
				AxisSensitivityType axisSensitivityType = (ReInput.isReady ? ReInput.configVars.defaultAxisSensitivityType : AxisSensitivityType.Multiplier);
				return new AxisCalibrationData(enabled: true, 0f, 0f, -1f, 1f, invert: false, applyRangeCalibration: false, axisSensitivityType, 1f, (axisSensitivityType == AxisSensitivityType.Curve) ? AnimationCurve.Linear(-1f, 1f, 1f, 1f) : null);
			}
		}

		public AxisCalibrationData(bool enabled, float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration)
		{
			this.enabled = enabled;
			this.deadZone = deadZone;
			this.zero = zero;
			this.min = min;
			this.max = max;
			this.invert = invert;
			this.applyRangeCalibration = applyRangeCalibration;
			sensitivity = 1f;
			sensitivityType = (ReInput.isReady ? ReInput.configVars.defaultAxisSensitivityType : AxisSensitivityType.Multiplier);
			sensitivityCurve = ((sensitivityType == AxisSensitivityType.Curve) ? AnimationCurve.Linear(-1f, 1f, 1f, 1f) : null);
			calibrations = null;
		}

		public AxisCalibrationData(bool enabled, float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration, float sensitivity)
		{
			this.enabled = enabled;
			this.deadZone = deadZone;
			this.zero = zero;
			this.min = min;
			this.max = max;
			this.invert = invert;
			this.applyRangeCalibration = applyRangeCalibration;
			this.sensitivity = sensitivity;
			sensitivityType = (ReInput.isReady ? ReInput.configVars.defaultAxisSensitivityType : AxisSensitivityType.Multiplier);
			sensitivityCurve = ((sensitivityType == AxisSensitivityType.Curve) ? AnimationCurve.Linear(-1f, 1f, 1f, 1f) : null);
			calibrations = null;
		}

		public AxisCalibrationData(bool enabled, float deadZone, float zero, float min, float max, bool invert, bool applyRangeCalibration, AxisSensitivityType sensitivityType, float sensitivity, AnimationCurve sensitivityCurve)
		{
			this.enabled = enabled;
			this.deadZone = deadZone;
			this.zero = zero;
			this.min = min;
			this.max = max;
			this.invert = invert;
			this.applyRangeCalibration = applyRangeCalibration;
			this.sensitivityType = sensitivityType;
			this.sensitivity = sensitivity;
			this.sensitivityCurve = sensitivityCurve;
			calibrations = null;
		}
	}
}
