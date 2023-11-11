using System;
using Rewired.Utils;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	public sealed class Axis2DCalibration
	{
		[Tooltip("The calculation type for the dead zone.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private DeadZone2DType _deadZoneType = DeadZone2DType.Radial;

		[Tooltip("Calculation type for sensitivity on 2D axes.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private AxisSensitivity2DType _sensitivityType;

		public DeadZone2DType deadZoneType
		{
			get
			{
				return _deadZoneType;
			}
			set
			{
				_deadZoneType = value;
			}
		}

		public AxisSensitivity2DType sensitivityType
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

		internal Axis2DCalibration()
		{
		}

		internal Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis)
		{
			return GetCalibrated2DValue(valueRawX, valueRawY, xAxis, yAxis, _deadZoneType, _sensitivityType);
		}

		internal static Vector2 GetCalibrated2DValue(float valueRawX, float valueRawY, AxisCalibration xAxis, AxisCalibration yAxis, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType)
		{
			Vector2 value = default(Vector2);
			bool flag = xAxis != null;
			bool flag2 = yAxis != null;
			switch (deadZoneType)
			{
			case DeadZone2DType.Axial:
				value.x = (flag ? xAxis.GetCalibratedValue(valueRawX, xAxis.deadZone, applySensitivity: false, applyInversion: false) : valueRawX);
				value.y = (flag2 ? yAxis.GetCalibratedValue(valueRawY, yAxis.deadZone, applySensitivity: false, applyInversion: false) : valueRawY);
				break;
			case DeadZone2DType.Radial:
			{
				float num = (flag ? xAxis.deadZone : (flag2 ? yAxis.deadZone : 0f));
				if (MathTools.ApproximatelyZero(num))
				{
					value.x = (flag ? xAxis.GetCalibratedValue(valueRawX, xAxis.deadZone, applySensitivity: false, applyInversion: false) : valueRawX);
					value.y = (flag2 ? yAxis.GetCalibratedValue(valueRawY, yAxis.deadZone, applySensitivity: false, applyInversion: false) : valueRawY);
				}
				else
				{
					value.x = (flag ? InputTools.TransformAxis2DComponentValue(valueRawX, xAxis.calibratedZero, xAxis.calibratedMin, xAxis.calibratedMax) : valueRawX);
					value.y = (flag2 ? InputTools.TransformAxis2DComponentValue(valueRawY, yAxis.calibratedZero, yAxis.calibratedMin, yAxis.calibratedMax) : valueRawY);
					value = InputTools.ApplyRadialDeadZone(value.x, value.y, num);
				}
				break;
			}
			default:
				throw new NotImplementedException();
			}
			switch (sensitivityType)
			{
			case AxisSensitivity2DType.Axial:
				if (flag)
				{
					value.x = InputTools.ApplySensitivity(value.x, xAxis.sensitivityType, xAxis.sensitivity, xAxis.sensitivityCurve);
				}
				if (flag2)
				{
					value.y = InputTools.ApplySensitivity(value.y, yAxis.sensitivityType, yAxis.sensitivity, yAxis.sensitivityCurve);
				}
				break;
			case AxisSensitivity2DType.Radial:
			{
				AxisCalibration axisCalibration = (flag ? xAxis : yAxis);
				if (axisCalibration != null)
				{
					InputTools.ApplyRadialSensitivity(ref value, axisCalibration.sensitivityType, axisCalibration.sensitivity, axisCalibration.sensitivityCurve);
				}
				break;
			}
			default:
				throw new NotImplementedException();
			}
			if (flag && xAxis.applyRangeCalibration)
			{
				if (value.x > 0f)
				{
					if (value.x > 1f || 1f - value.x <= 0.001f)
					{
						value.x = 1f;
					}
				}
				else if (value.x < 0f && (value.x < -1f || value.x + 1f <= 0.001f))
				{
					value.x = -1f;
				}
			}
			if (flag2 && yAxis.applyRangeCalibration)
			{
				if (value.y > 0f)
				{
					if (value.y > 1f || 1f - value.y <= 0.001f)
					{
						value.y = 1f;
					}
				}
				else if (value.y < 0f && (value.y < -1f || value.y + 1f <= 0.001f))
				{
					value.y = -1f;
				}
			}
			if (flag && xAxis.invert)
			{
				value.x *= -1f;
			}
			if (flag2 && yAxis.invert)
			{
				value.y *= -1f;
			}
			return value;
		}
	}
}
