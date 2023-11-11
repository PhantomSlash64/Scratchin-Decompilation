using System;
using Rewired.Interfaces;
using Rewired.Utils;
using Rewired.Utils.Classes.Utility;

namespace Rewired.Platforms.XboxOne
{
	public sealed class XboxOneGamepadExtension : Controller.Extension, IControllerVibrator
	{
		private class kSYlvvuKHGQYlxMOxlZwRlNAnVk : IControllerExtensionSource
		{
			public const int DgKZIwUKWYpoRBbYIharycQNYrN = 4;

			public LbhiVMAGGlMXhcUfcRjbBFoDceTt nPdBHKtrKvJPEwAqISSUGadqiXD;

			public readonly IXboxOneInputSource RawBiaEaPelifgZgKaQilfWbjWMB;

			public readonly bool YxSCQUilOVOVIAbfGmstlMmXgrqk;

			public kSYlvvuKHGQYlxMOxlZwRlNAnVk(bool supportsVibration, IXboxOneInputSource xboxOneInputSource, LbhiVMAGGlMXhcUfcRjbBFoDceTt vibrationData)
			{
				nPdBHKtrKvJPEwAqISSUGadqiXD = vibrationData;
				RawBiaEaPelifgZgKaQilfWbjWMB = xboxOneInputSource;
				YxSCQUilOVOVIAbfGmstlMmXgrqk = supportsVibration;
			}
		}

		private kSYlvvuKHGQYlxMOxlZwRlNAnVk eEGdvsHFSoebDZTJoammOSBqiFV;

		private TimerAbs[] TaRSsOMgbSAfYayUBvRbfmXaMjyi;

		private Joystick joystick => GetController<Joystick>();

		public int xboxOneUserId
		{
			get
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
					return -1;
				}
				if (eEGdvsHFSoebDZTJoammOSBqiFV.RawBiaEaPelifgZgKaQilfWbjWMB == null || joystick == null)
				{
					return -1;
				}
				return eEGdvsHFSoebDZTJoammOSBqiFV.RawBiaEaPelifgZgKaQilfWbjWMB.GetXboxOneUserIdFromUnityJoystick(joystick.unityId);
			}
		}

		public ulong xboxOneJoystickId
		{
			get
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
					return 0uL;
				}
				if (joystick == null)
				{
					return 0uL;
				}
				long? systemId = joystick.systemId;
				if (!systemId.HasValue)
				{
					return 0uL;
				}
				return (ulong)systemId.Value;
			}
		}

		public int vibrationMotorCount
		{
			get
			{
				if (ReInput._id != _reInputId)
				{
					ReInput.CheckInitialized(_reInputId);
					return 0;
				}
				return 4;
			}
		}

		internal XboxOneGamepadExtension(bool supportsVibration, IXboxOneInputSource xboxOneInputSource)
			: base(new kSYlvvuKHGQYlxMOxlZwRlNAnVk(supportsVibration, xboxOneInputSource, default(LbhiVMAGGlMXhcUfcRjbBFoDceTt)))
		{
			if (xboxOneInputSource == null)
			{
				throw new ArgumentNullException("xboxOneInputSource");
			}
			TaRSsOMgbSAfYayUBvRbfmXaMjyi = new TimerAbs[4];
			ArrayTools.Populate(TaRSsOMgbSAfYayUBvRbfmXaMjyi, 0, TaRSsOMgbSAfYayUBvRbfmXaMjyi.Length);
		}

		private XboxOneGamepadExtension(XboxOneGamepadExtension source)
			: base(source)
		{
			TaRSsOMgbSAfYayUBvRbfmXaMjyi = new TimerAbs[4];
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
			else if (motorIndex >= 0 && motorIndex < 4)
			{
				SetVibration(motorIndex switch
				{
					0 => XboxOneGamepadMotorType.LeftMotor, 
					1 => XboxOneGamepadMotorType.RightMotor, 
					2 => XboxOneGamepadMotorType.LeftTriggerMotor, 
					3 => XboxOneGamepadMotorType.RightTriggerMotor, 
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
			if (!eEGdvsHFSoebDZTJoammOSBqiFV.YxSCQUilOVOVIAbfGmstlMmXgrqk)
			{
				return 0f;
			}
			return motorIndex switch
			{
				0 => eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.dGxjKhnytjNHvsOIZjFLjcsgGbip, 
				1 => eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.pdfZdEwqLUgequAHOokegpZXFyg, 
				2 => eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.dmCuYmCWCZIpjGCygOoQUQUYqiW, 
				3 => eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.qMFemiBWVOGfgxWkBVdjNaRDdeog, 
				_ => 0f, 
			};
		}

		public float GetVibration(XboxOneGamepadMotorType motor)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
				return 0f;
			}
			if (!eEGdvsHFSoebDZTJoammOSBqiFV.YxSCQUilOVOVIAbfGmstlMmXgrqk)
			{
				return 0f;
			}
			return motor switch
			{
				XboxOneGamepadMotorType.LeftMotor => eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.dGxjKhnytjNHvsOIZjFLjcsgGbip, 
				XboxOneGamepadMotorType.RightMotor => eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.pdfZdEwqLUgequAHOokegpZXFyg, 
				XboxOneGamepadMotorType.LeftTriggerMotor => eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.dmCuYmCWCZIpjGCygOoQUQUYqiW, 
				XboxOneGamepadMotorType.RightTriggerMotor => eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.qMFemiBWVOGfgxWkBVdjNaRDdeog, 
				_ => throw new NotImplementedException(), 
			};
		}

		public void StopVibration()
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else if (eEGdvsHFSoebDZTJoammOSBqiFV.YxSCQUilOVOVIAbfGmstlMmXgrqk)
			{
				eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.JGdqJczxIdgcZylOXhRqWBZNbrc();
				for (int i = 0; i < 4; i++)
				{
					TaRSsOMgbSAfYayUBvRbfmXaMjyi[i].Clear();
				}
				lUasvIHEepBCvBQZRjWedrClqos();
			}
		}

		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel)
		{
			SetVibration(motor, motorLevel, 0f, stopOtherMotors: false);
		}

		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration)
		{
			SetVibration(motor, motorLevel, duration, stopOtherMotors: false);
		}

		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, bool stopOtherMotors)
		{
			SetVibration(motor, motorLevel, 0f, stopOtherMotors);
		}

		public void SetVibration(XboxOneGamepadMotorType motor, float motorLevel, float duration, bool stopOtherMotors)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else
			{
				if (!eEGdvsHFSoebDZTJoammOSBqiFV.YxSCQUilOVOVIAbfGmstlMmXgrqk)
				{
					return;
				}
				if (stopOtherMotors)
				{
					eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.JGdqJczxIdgcZylOXhRqWBZNbrc();
					for (int i = 0; i < 4; i++)
					{
						TaRSsOMgbSAfYayUBvRbfmXaMjyi[i].Clear();
					}
				}
				motorLevel = MathTools.Clamp01(motorLevel);
				switch (motor)
				{
				case XboxOneGamepadMotorType.LeftMotor:
					eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.dGxjKhnytjNHvsOIZjFLjcsgGbip = motorLevel;
					break;
				case XboxOneGamepadMotorType.RightMotor:
					eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.pdfZdEwqLUgequAHOokegpZXFyg = motorLevel;
					break;
				case XboxOneGamepadMotorType.LeftTriggerMotor:
					eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.dmCuYmCWCZIpjGCygOoQUQUYqiW = motorLevel;
					break;
				case XboxOneGamepadMotorType.RightTriggerMotor:
					eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.qMFemiBWVOGfgxWkBVdjNaRDdeog = motorLevel;
					break;
				default:
					throw new NotImplementedException();
				}
				nqHWUyjRVDRyWfBjzFsuxGBaQtd(motor, motorLevel, duration);
				lUasvIHEepBCvBQZRjWedrClqos();
			}
		}

		public void SetVibration(float leftMotorLevel, float rightMotorLevel)
		{
			SetVibration(leftMotorLevel, rightMotorLevel, stopOtherMotors: false);
		}

		public void SetVibration(float leftMotorLevel, float rightMotorLevel, bool stopOtherMotors)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else
			{
				if (!eEGdvsHFSoebDZTJoammOSBqiFV.YxSCQUilOVOVIAbfGmstlMmXgrqk)
				{
					return;
				}
				if (stopOtherMotors)
				{
					eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.JGdqJczxIdgcZylOXhRqWBZNbrc();
					for (int i = 0; i < 4; i++)
					{
						TaRSsOMgbSAfYayUBvRbfmXaMjyi[i].Clear();
					}
				}
				eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.NJjJYxjIOhuZZkRCjPCTsAHLasu = xboxOneJoystickId;
				eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.dGxjKhnytjNHvsOIZjFLjcsgGbip = MathTools.Clamp01(leftMotorLevel);
				eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.pdfZdEwqLUgequAHOokegpZXFyg = MathTools.Clamp01(rightMotorLevel);
				TaRSsOMgbSAfYayUBvRbfmXaMjyi[0].Clear();
				TaRSsOMgbSAfYayUBvRbfmXaMjyi[1].Clear();
				lUasvIHEepBCvBQZRjWedrClqos();
			}
		}

		public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftTriggerLevel, float rightTriggerLevel)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else if (eEGdvsHFSoebDZTJoammOSBqiFV.YxSCQUilOVOVIAbfGmstlMmXgrqk)
			{
				eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.NJjJYxjIOhuZZkRCjPCTsAHLasu = xboxOneJoystickId;
				eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.dGxjKhnytjNHvsOIZjFLjcsgGbip = MathTools.Clamp01(leftMotorLevel);
				eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.pdfZdEwqLUgequAHOokegpZXFyg = MathTools.Clamp01(rightMotorLevel);
				eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.dmCuYmCWCZIpjGCygOoQUQUYqiW = MathTools.Clamp01(leftTriggerLevel);
				eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD.qMFemiBWVOGfgxWkBVdjNaRDdeog = MathTools.Clamp01(rightTriggerLevel);
				for (int i = 0; i < 4; i++)
				{
					TaRSsOMgbSAfYayUBvRbfmXaMjyi[i].Clear();
				}
				lUasvIHEepBCvBQZRjWedrClqos();
			}
		}

		public void PulseVibrateMotor(XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration)
		{
			if (ReInput._id != _reInputId)
			{
				ReInput.CheckInitialized(_reInputId);
			}
			else if (base.isJoystickConnected && eEGdvsHFSoebDZTJoammOSBqiFV.YxSCQUilOVOVIAbfGmstlMmXgrqk)
			{
				nqHWUyjRVDRyWfBjzFsuxGBaQtd(motor, 0f, 0f);
				eEGdvsHFSoebDZTJoammOSBqiFV.RawBiaEaPelifgZgKaQilfWbjWMB.PulseVibrateMotor(xboxOneJoystickId, motor, startLevel, endLevel, duration);
			}
		}

		internal void MlEQHREVxHLTuUCANSxPMEKvYTk(UpdateLoopType P_0)
		{
			KpbwJNcuwWkNyuMDipKdKvsTxou();
		}

		internal void RpeYzeyVaxOdApEhVGfVRjeBofC(IControllerExtensionSource P_0)
		{
			eEGdvsHFSoebDZTJoammOSBqiFV = P_0 as kSYlvvuKHGQYlxMOxlZwRlNAnVk;
		}

		internal Controller.Extension krDHfhzemQsdElTTOFwBBCKPvNI()
		{
			return new XboxOneGamepadExtension(this);
		}

		private void KpbwJNcuwWkNyuMDipKdKvsTxou()
		{
			if (!eEGdvsHFSoebDZTJoammOSBqiFV.YxSCQUilOVOVIAbfGmstlMmXgrqk)
			{
				return;
			}
			for (int i = 0; i < 4; i++)
			{
				if (TaRSsOMgbSAfYayUBvRbfmXaMjyi[i].Update())
				{
					SetVibration(i, 0f, stopOtherMotors: false);
				}
			}
		}

		private void nqHWUyjRVDRyWfBjzFsuxGBaQtd(XboxOneGamepadMotorType P_0, float P_1, float P_2)
		{
			int num = P_0 switch
			{
				XboxOneGamepadMotorType.LeftMotor => 0, 
				XboxOneGamepadMotorType.RightMotor => 1, 
				XboxOneGamepadMotorType.LeftTriggerMotor => 2, 
				XboxOneGamepadMotorType.RightTriggerMotor => 3, 
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

		private void lUasvIHEepBCvBQZRjWedrClqos()
		{
			if (base.isJoystickConnected)
			{
				eEGdvsHFSoebDZTJoammOSBqiFV.RawBiaEaPelifgZgKaQilfWbjWMB.SetXboxOneVibration(xboxOneJoystickId, eEGdvsHFSoebDZTJoammOSBqiFV.nPdBHKtrKvJPEwAqISSUGadqiXD);
			}
		}
	}
}
