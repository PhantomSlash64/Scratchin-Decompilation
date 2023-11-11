using System;
using Rewired.Drivers.Interfaces;
using Rewired.Interfaces;
using Rewired.Utils;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

namespace Rewired.ControllerExtensions
{
	public sealed class DualSenseExtension : Controller.Extension, IControllerVibrator, IDualShock4Extension
	{
		private class sfRTHGPyNkwMduMFRBXJULCkOCb : IControllerExtensionSource
		{
			public readonly IDriver_DualSense HXdrpIalcqAYpAuAIDhnqyeoHAg;

			public readonly bool YxSCQUilOVOVIAbfGmstlMmXgrqk;

			public readonly int DgKZIwUKWYpoRBbYIharycQNYrN;

			public sfRTHGPyNkwMduMFRBXJULCkOCb(IDriver_DualSense driver, bool supportsVibration, int vibrationMotorCount)
			{
				HXdrpIalcqAYpAuAIDhnqyeoHAg = driver;
				YxSCQUilOVOVIAbfGmstlMmXgrqk = supportsVibration;
				DgKZIwUKWYpoRBbYIharycQNYrN = vibrationMotorCount;
			}
		}

		private sfRTHGPyNkwMduMFRBXJULCkOCb ptgshdhzmBqmpwQkacMBSGAyXPI;

		private bool BhyuisYWlCQCMQSIXrzMJaxECAD;

		private TimerAbs[] TaRSsOMgbSAfYayUBvRbfmXaMjyi;

		private Joystick joystick => GetController<Joystick>();

		public int vibrationMotorCount
		{
			get
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
					return 0;
				}
				if (!BhyuisYWlCQCMQSIXrzMJaxECAD)
				{
					return 0;
				}
				return ptgshdhzmBqmpwQkacMBSGAyXPI.DgKZIwUKWYpoRBbYIharycQNYrN;
			}
		}

		public float lightColorRed
		{
			get
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
					return 0f;
				}
				if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled)
				{
					return 0f;
				}
				return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LightColorR;
			}
			set
			{
				if (BhyuisYWlCQCMQSIXrzMJaxECAD)
				{
					ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LightColorR = value;
				}
			}
		}

		public float lightColorGreen
		{
			get
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
					return 0f;
				}
				if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled)
				{
					return 0f;
				}
				return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LightColorG;
			}
			set
			{
				if (BhyuisYWlCQCMQSIXrzMJaxECAD)
				{
					ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LightColorG = value;
				}
			}
		}

		public float lightColorBlue
		{
			get
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
					return 0f;
				}
				if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled)
				{
					return 0f;
				}
				return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LightColorB;
			}
			set
			{
				if (BhyuisYWlCQCMQSIXrzMJaxECAD)
				{
					ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LightColorB = value;
				}
			}
		}

		public DualSenseMicrophoneLightMode microphoneLightMode
		{
			get
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
					return DualSenseMicrophoneLightMode.Off;
				}
				if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled)
				{
					return DualSenseMicrophoneLightMode.Off;
				}
				return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.microphoneLightMode;
			}
			set
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
				}
				else if (BhyuisYWlCQCMQSIXrzMJaxECAD && base.enabled)
				{
					ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.microphoneLightMode = value;
				}
			}
		}

		public DualSenseOtherLightBrightness otherLightBrightness
		{
			get
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
					return DualSenseOtherLightBrightness.High;
				}
				if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled)
				{
					return DualSenseOtherLightBrightness.High;
				}
				return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.otherLightBrightness;
			}
			set
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
				}
				else if (BhyuisYWlCQCMQSIXrzMJaxECAD && base.enabled)
				{
					ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.otherLightBrightness = value;
				}
			}
		}

		public DualSensePlayerLightFlags playerLights
		{
			get
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
					return DualSensePlayerLightFlags.None;
				}
				if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled)
				{
					return DualSensePlayerLightFlags.None;
				}
				return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.playerLights;
			}
			set
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
				}
				else if (BhyuisYWlCQCMQSIXrzMJaxECAD && base.enabled)
				{
					ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.playerLights = value;
				}
			}
		}

		public int maxTouches
		{
			get
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
					return 0;
				}
				if (!BhyuisYWlCQCMQSIXrzMJaxECAD)
				{
					return 0;
				}
				return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.MaxTouches;
			}
		}

		public int touchCount
		{
			get
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
					return 0;
				}
				return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.GetTouchCount();
			}
		}

		public float batteryLevel
		{
			get
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
					return 0f;
				}
				if (!BhyuisYWlCQCMQSIXrzMJaxECAD)
				{
					return 0f;
				}
				return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.BatteryLevel;
			}
		}

		public bool batteryCharging
		{
			get
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
					return false;
				}
				if (!BhyuisYWlCQCMQSIXrzMJaxECAD)
				{
					return false;
				}
				return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.BatteryCharging;
			}
		}

		internal DualSenseExtension(IDriver_DualSense driver)
			: base(new sfRTHGPyNkwMduMFRBXJULCkOCb(driver, driver.VibrationMotorCount > 0, driver.VibrationMotorCount))
		{
			TaRSsOMgbSAfYayUBvRbfmXaMjyi = new TimerAbs[driver.VibrationMotorCount];
			ArrayTools.Populate(TaRSsOMgbSAfYayUBvRbfmXaMjyi, 0, TaRSsOMgbSAfYayUBvRbfmXaMjyi.Length);
		}

		private DualSenseExtension(DualSenseExtension source)
			: base(source)
		{
			try
			{
				TaRSsOMgbSAfYayUBvRbfmXaMjyi = new TimerAbs[source.vibrationMotorCount];
			}
			catch
			{
				TaRSsOMgbSAfYayUBvRbfmXaMjyi = new TimerAbs[0];
			}
			ArrayTools.Populate(TaRSsOMgbSAfYayUBvRbfmXaMjyi, 0, TaRSsOMgbSAfYayUBvRbfmXaMjyi.Length);
		}

		public void SetVibration(int motorIndex, float motorLevel)
		{
			SetVibration(motorIndex, motorLevel, 0f, stopOtherMotors: false);
		}

		public void SetVibration(int motorIndex, float motorLevel, float duration)
		{
			SetVibration(motorIndex, motorLevel, duration, stopOtherMotors: false);
		}

		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
		{
			SetVibration(motorIndex, motorLevel, 0f, stopOtherMotors);
		}

		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else if (BhyuisYWlCQCMQSIXrzMJaxECAD && base.enabled && motorIndex >= 0 && motorIndex < ptgshdhzmBqmpwQkacMBSGAyXPI.DgKZIwUKWYpoRBbYIharycQNYrN)
			{
				SetVibration(motorIndex switch
				{
					0 => DualShock4MotorType.LeftMotor, 
					1 => DualShock4MotorType.RightMotor, 
					_ => throw new NotImplementedException(), 
				}, motorLevel, duration, stopOtherMotors);
			}
		}

		public float GetVibration(int motorIndex)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return 0f;
			}
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled)
			{
				return 0f;
			}
			if (!ptgshdhzmBqmpwQkacMBSGAyXPI.YxSCQUilOVOVIAbfGmstlMmXgrqk)
			{
				return 0f;
			}
			return motorIndex switch
			{
				0 => ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LeftMotor, 
				1 => ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.RightMotor, 
				_ => 0f, 
			};
		}

		public void StopVibration()
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else if (BhyuisYWlCQCMQSIXrzMJaxECAD && base.enabled && ptgshdhzmBqmpwQkacMBSGAyXPI.YxSCQUilOVOVIAbfGmstlMmXgrqk)
			{
				for (int i = 0; i < ptgshdhzmBqmpwQkacMBSGAyXPI.DgKZIwUKWYpoRBbYIharycQNYrN; i++)
				{
					TaRSsOMgbSAfYayUBvRbfmXaMjyi[i].Clear();
				}
				ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.StopVibration();
			}
		}

		public float GetVibration(DualShock4MotorType motor)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return 0f;
			}
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled)
			{
				return 0f;
			}
			if (!ptgshdhzmBqmpwQkacMBSGAyXPI.YxSCQUilOVOVIAbfGmstlMmXgrqk)
			{
				return 0f;
			}
			return (int)motor switch
			{
				0 => ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LeftMotor, 
				1 => ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.RightMotor, 
				_ => throw new NotImplementedException(), 
			};
		}

		public void SetVibration(DualShock4MotorType motor, float motorLevel)
		{
			SetVibration(motor, motorLevel, 0f, stopOtherMotors: false);
		}

		public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration)
		{
			SetVibration(motor, motorLevel, duration, stopOtherMotors: false);
		}

		public void SetVibration(DualShock4MotorType motor, float motorLevel, bool stopOtherMotors)
		{
			SetVibration(motor, motorLevel, 0f, stopOtherMotors);
		}

		public void SetVibration(DualShock4MotorType motor, float motorLevel, float duration, bool stopOtherMotors)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else
			{
				if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled || !ptgshdhzmBqmpwQkacMBSGAyXPI.YxSCQUilOVOVIAbfGmstlMmXgrqk)
				{
					return;
				}
				if (stopOtherMotors)
				{
					for (int i = 0; i < ptgshdhzmBqmpwQkacMBSGAyXPI.DgKZIwUKWYpoRBbYIharycQNYrN; i++)
					{
						TaRSsOMgbSAfYayUBvRbfmXaMjyi[i].Clear();
					}
					ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.StopVibration();
				}
				motorLevel = MathTools.Clamp01(motorLevel);
				switch ((int)motor)
				{
				case 0:
					ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LeftMotor = motorLevel;
					break;
				case 1:
					ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.RightMotor = motorLevel;
					break;
				default:
					throw new NotImplementedException();
				}
				nqHWUyjRVDRyWfBjzFsuxGBaQtd(motor, motorLevel, duration);
			}
		}

		public void SetVibration(float leftMotorLevel, float rightMotorLevel)
		{
			SetVibration(leftMotorLevel, rightMotorLevel, 0f, 0f);
		}

		public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else if (BhyuisYWlCQCMQSIXrzMJaxECAD && base.enabled && ptgshdhzmBqmpwQkacMBSGAyXPI.YxSCQUilOVOVIAbfGmstlMmXgrqk)
			{
				ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LeftMotor = MathTools.Clamp01(leftMotorLevel);
				ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.RightMotor = MathTools.Clamp01(rightMotorLevel);
				nqHWUyjRVDRyWfBjzFsuxGBaQtd(DualShock4MotorType.LeftMotor, leftMotorLevel, leftMotorDuration);
				nqHWUyjRVDRyWfBjzFsuxGBaQtd(DualShock4MotorType.RightMotor, rightMotorLevel, rightMotorDuration);
			}
		}

		public Color GetLightColor()
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return default(Color);
			}
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD)
			{
				return default(Color);
			}
			return new Color(ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LightColorR, ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LightColorG, ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LightColorB, 1f);
		}

		public void SetLightColor(Color color)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else if (BhyuisYWlCQCMQSIXrzMJaxECAD && base.enabled)
			{
				ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LightColorR = color.r * color.a;
				ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LightColorG = color.g * color.a;
				ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LightColorB = color.b * color.a;
			}
		}

		public void SetLightColor(float red, float green, float blue)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else
			{
				SetLightColor(red, green, blue, 1f);
			}
		}

		public void SetLightColor(float red, float green, float blue, float intensity)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else if (BhyuisYWlCQCMQSIXrzMJaxECAD && base.enabled)
			{
				ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LightColorR = red * intensity;
				ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LightColorG = green * intensity;
				ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LightColorB = blue * intensity;
			}
		}

		public Vector3 GetAccelerometerValueRaw()
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return Vector3.zero;
			}
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled || !ReInput.IsInputAllowed(ControllerType.Joystick))
			{
				return Vector3.zero;
			}
			return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.AccelerometerValueRaw;
		}

		public Vector3 GetAccelerometerValue()
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return Vector3.zero;
			}
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled || !ReInput.IsInputAllowed(ControllerType.Joystick))
			{
				return Vector3.zero;
			}
			return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.AccelerometerValue;
		}

		public Vector3 GetLastGyroscopeValueRaw()
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return Vector3.zero;
			}
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled || !ReInput.IsInputAllowed(ControllerType.Joystick))
			{
				return Vector3.zero;
			}
			return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LastGyroscopeValueRaw;
		}

		public Vector3 GetLastGyroscopeValue()
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return Vector3.zero;
			}
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled || !ReInput.IsInputAllowed(ControllerType.Joystick))
			{
				return Vector3.zero;
			}
			return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.LastGyroscopeValue;
		}

		public Vector3 GetGyroscopeValueRaw()
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return Vector3.zero;
			}
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled || !ReInput.IsInputAllowed(ControllerType.Joystick))
			{
				return Vector3.zero;
			}
			return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.GyroscopeValueRaw;
		}

		public Vector3 GetGyroscopeValue()
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return Vector3.zero;
			}
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled || !ReInput.IsInputAllowed(ControllerType.Joystick))
			{
				return Vector3.zero;
			}
			return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.GyroscopeValue;
		}

		public Quaternion GetOrientation()
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return Quaternion.identity;
			}
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled || !ReInput.IsInputAllowed(ControllerType.Joystick))
			{
				return default(Quaternion);
			}
			return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.Orientation;
		}

		public void ResetOrientation()
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else if (BhyuisYWlCQCMQSIXrzMJaxECAD)
			{
				ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.ResetOrientation();
			}
		}

		public int GetTouchId(int index)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return -1;
			}
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled || !ReInput.IsInputAllowed(ControllerType.Joystick))
			{
				return -1;
			}
			return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.GetTouchIdAtIndex(index);
		}

		public bool GetTouchPosition(int index, out Vector2 position)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				position = Vector2.zero;
				return false;
			}
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled || !ReInput.IsInputAllowed(ControllerType.Joystick))
			{
				position = Vector2.zero;
				return false;
			}
			return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.GetTouchPositionByIndex(index, out position);
		}

		public bool GetTouchPositionByTouchId(int touchId, out Vector2 position)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				position = Vector2.zero;
				return false;
			}
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled || !ReInput.IsInputAllowed(ControllerType.Joystick))
			{
				position = Vector2.zero;
				return false;
			}
			return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.GetTouchPositionByTouchId(touchId, out position);
		}

		public bool GetTouchPositionAbsolute(int index, out Vector2 position)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				position = Vector2.zero;
				return false;
			}
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled || !ReInput.IsInputAllowed(ControllerType.Joystick))
			{
				position = Vector2.zero;
				return false;
			}
			int positionX;
			int positionY;
			bool touchPositionAbsoluteByIndex = ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.GetTouchPositionAbsoluteByIndex(index, out positionX, out positionY);
			position = new Vector2(positionX, positionY);
			return touchPositionAbsoluteByIndex;
		}

		public bool GetTouchPositionAbsoluteByTouchId(int touchId, out Vector2 position)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				position = Vector2.zero;
				return false;
			}
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled || !ReInput.IsInputAllowed(ControllerType.Joystick))
			{
				position = Vector2.zero;
				return false;
			}
			int positionX;
			int positionY;
			bool touchPositionAbsoluteByTouchId = ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.GetTouchPositionAbsoluteByTouchId(touchId, out positionX, out positionY);
			position = new Vector2(positionX, positionY);
			return touchPositionAbsoluteByTouchId;
		}

		public bool IsTouching(int index)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return false;
			}
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled || !ReInput.IsInputAllowed(ControllerType.Joystick))
			{
				return false;
			}
			return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.IsTouchingAtIndex(index);
		}

		public bool IsTouchingByTouchId(int touchId)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return false;
			}
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !base.enabled || !ReInput.IsInputAllowed(ControllerType.Joystick))
			{
				return false;
			}
			return ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg.IsTouchingAtTouchId(touchId);
		}

		private Vector3 KFoyokSyIlwNZPdFakVJvtkdGoJ()
		{
			return GetGyroscopeValue();
		}

		Vector3 IDualShock4Extension.GetGyroscopeValue()
		{
			//ILSpy generated this explicit interface implementation from .override directive in KFoyokSyIlwNZPdFakVJvtkdGoJ
			return this.KFoyokSyIlwNZPdFakVJvtkdGoJ();
		}

		private Vector3 qYrpOeYxNBgfRJmMuhoOGWFNvPu()
		{
			return GetGyroscopeValueRaw();
		}

		Vector3 IDualShock4Extension.GetGyroscopeValueRaw()
		{
			//ILSpy generated this explicit interface implementation from .override directive in qYrpOeYxNBgfRJmMuhoOGWFNvPu
			return this.qYrpOeYxNBgfRJmMuhoOGWFNvPu();
		}

		internal void MlEQHREVxHLTuUCANSxPMEKvYTk(UpdateLoopType P_0)
		{
			if (BhyuisYWlCQCMQSIXrzMJaxECAD && base.enabled)
			{
				KpbwJNcuwWkNyuMDipKdKvsTxou();
			}
		}

		internal void RpeYzeyVaxOdApEhVGfVRjeBofC(IControllerExtensionSource P_0)
		{
			ptgshdhzmBqmpwQkacMBSGAyXPI = P_0 as sfRTHGPyNkwMduMFRBXJULCkOCb;
			BhyuisYWlCQCMQSIXrzMJaxECAD = ptgshdhzmBqmpwQkacMBSGAyXPI != null && ptgshdhzmBqmpwQkacMBSGAyXPI.HXdrpIalcqAYpAuAIDhnqyeoHAg != null;
		}

		internal Controller.Extension krDHfhzemQsdElTTOFwBBCKPvNI()
		{
			return new DualSenseExtension(this);
		}

		private void KpbwJNcuwWkNyuMDipKdKvsTxou()
		{
			if (!BhyuisYWlCQCMQSIXrzMJaxECAD || !ptgshdhzmBqmpwQkacMBSGAyXPI.YxSCQUilOVOVIAbfGmstlMmXgrqk)
			{
				return;
			}
			for (int i = 0; i < ptgshdhzmBqmpwQkacMBSGAyXPI.DgKZIwUKWYpoRBbYIharycQNYrN; i++)
			{
				if (TaRSsOMgbSAfYayUBvRbfmXaMjyi[i].Update())
				{
					SetVibration(i, 0f, stopOtherMotors: false);
				}
			}
		}

		private void nqHWUyjRVDRyWfBjzFsuxGBaQtd(DualShock4MotorType P_0, float P_1, float P_2)
		{
			int num = P_0 switch
			{
				DualShock4MotorType.LeftMotor => 0, 
				DualShock4MotorType.RightMotor => 1, 
				_ => throw new NotImplementedException(), 
			};
			if (P_1 <= 0f || P_2 <= 0f)
			{
				TaRSsOMgbSAfYayUBvRbfmXaMjyi[num].Clear();
			}
			else
			{
				TaRSsOMgbSAfYayUBvRbfmXaMjyi[num].Start(P_2);
			}
		}
	}
}
