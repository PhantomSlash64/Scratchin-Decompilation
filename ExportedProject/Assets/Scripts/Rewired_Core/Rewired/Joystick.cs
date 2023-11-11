using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using Rewired.Utils;
using Rewired.Utils.Classes.Utility;

namespace Rewired
{
	public class Joystick : ControllerWithAxes
	{
		private const int DCnHbelHsrysPrpgDCEaJGojURz = 0;

		private const int eIIFhBbqSojkPGORCghzIVsxJOqM = 1;

		private IInputManagerJoystickPublic REdHEDREevCvSFXTgOChyycUUQS;

		private readonly JoystickType[] ClJdhzdQRrgXoTdwWpcFfMFvXjN;

		private readonly ReadOnlyCollection<JoystickType> tSOImdvPCjxfOYXZrISLryHDKPI;

		private readonly bool BxmfGIMUjjyBvyrhaODhxOdxZeV;

		private readonly bool dsijKPslVIxdWanOtBcouabvOrt;

		private readonly bool oqOLiUnpVNxgLQkVxCKTKvPVHBRz;

		private readonly int CyODFPusZoMgZWYWNTqkZXRYGK;

		private readonly float[] vCWlHsLIVWsGnAtiwReomiSBvcl;

		private readonly TimerAbs[] rGTPHXuGbNCmCiSQKiWROoibURE;

		private readonly int kVzZTbScCFNqnGUvhyjODzBRGOE;

		private readonly Hat[] wvGIqCELhZyllMozbJeDLFcdBtR;

		private readonly ReadOnlyCollection<Hat> EYNGRZigLvuCOvyMvPeULBuzwLNN;

		internal IList<JoystickType> joystickTypes
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return EmptyObjects<JoystickType>.EmptyReadOnlyIListT;
				}
				return tSOImdvPCjxfOYXZrISLryHDKPI;
			}
		}

		public long? systemId
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return -1L;
				}
				return REdHEDREevCvSFXTgOChyycUUQS.systemId;
			}
		}

		public int unityId
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return -1;
				}
				return REdHEDREevCvSFXTgOChyycUUQS.unityId;
			}
		}

		public override Guid deviceInstanceGuid
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return Guid.Empty;
				}
				return REdHEDREevCvSFXTgOChyycUUQS.persistentGuid;
			}
		}

		public bool supportsVibration
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return false;
				}
				return BxmfGIMUjjyBvyrhaODhxOdxZeV;
			}
		}

		public float vibrationLeftMotor
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return 0f;
				}
				if (!BxmfGIMUjjyBvyrhaODhxOdxZeV)
				{
					return 0f;
				}
				if (base.extension is IControllerVibrator controllerVibrator && controllerVibrator.vibrationMotorCount > 0)
				{
					return controllerVibrator.GetVibration(0);
				}
				if (!dsijKPslVIxdWanOtBcouabvOrt)
				{
					return 0f;
				}
				if (CyODFPusZoMgZWYWNTqkZXRYGK > 0)
				{
					return vCWlHsLIVWsGnAtiwReomiSBvcl[0];
				}
				return 0f;
			}
			set
			{
				if (BxmfGIMUjjyBvyrhaODhxOdxZeV)
				{
					value = MathTools.Clamp(value, 0f, 1f);
					if (base.extension is IControllerVibrator controllerVibrator && controllerVibrator.vibrationMotorCount > 0)
					{
						controllerVibrator.SetVibration(0, value);
					}
					else if (dsijKPslVIxdWanOtBcouabvOrt && 0 < CyODFPusZoMgZWYWNTqkZXRYGK)
					{
						cZDYJDKhKueCaWCQzQYjFdZqoRB(0, value, 0f, false, true);
					}
				}
			}
		}

		public float vibrationRightMotor
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return 0f;
				}
				if (!BxmfGIMUjjyBvyrhaODhxOdxZeV)
				{
					return 0f;
				}
				if (base.extension is IControllerVibrator controllerVibrator && controllerVibrator.vibrationMotorCount > 1)
				{
					return controllerVibrator.GetVibration(1);
				}
				if (!dsijKPslVIxdWanOtBcouabvOrt)
				{
					return 0f;
				}
				if (CyODFPusZoMgZWYWNTqkZXRYGK > 1)
				{
					return vCWlHsLIVWsGnAtiwReomiSBvcl[1];
				}
				return 0f;
			}
			set
			{
				if (BxmfGIMUjjyBvyrhaODhxOdxZeV)
				{
					value = MathTools.Clamp(value, 0f, 1f);
					if (base.extension is IControllerVibrator controllerVibrator && controllerVibrator.vibrationMotorCount > 1)
					{
						controllerVibrator.SetVibration(1, value);
					}
					else if (dsijKPslVIxdWanOtBcouabvOrt && 1 < CyODFPusZoMgZWYWNTqkZXRYGK)
					{
						cZDYJDKhKueCaWCQzQYjFdZqoRB(1, value, 0f, false, true);
					}
				}
			}
		}

		public int vibrationMotorCount
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return 0;
				}
				if (base.extension is IControllerVibrator)
				{
					return (base.extension as IControllerVibrator).vibrationMotorCount;
				}
				return CyODFPusZoMgZWYWNTqkZXRYGK;
			}
		}

		public int hatCount
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return 0;
				}
				return kVzZTbScCFNqnGUvhyjODzBRGOE;
			}
		}

		public IList<Hat> Hats
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return EmptyObjects<Hat>.EmptyReadOnlyIListT;
				}
				return EYNGRZigLvuCOvyMvPeULBuzwLNN;
			}
		}

		internal int inputManagerId => REdHEDREevCvSFXTgOChyycUUQS.inputManagerId;

		internal HardwareControllerMapIdentifier hardwareJoystickMapIdentifier
		{
			get
			{
				if (pAhzhvigFoLFbwPDdcXHatZWRIl == null)
				{
					return default(HardwareControllerMapIdentifier);
				}
				return pAhzhvigFoLFbwPDdcXHatZWRIl.hardwareMapIdentifier;
			}
		}

		internal Joystick(BridgedController controller)
			: this(controller.sourceJoystick.rewiredId, controller.inputSource, controller.sourceJoystick.name, (controller.hw_isBluetoothDevice && !string.IsNullOrEmpty(controller.hw_bluetoothDeviceName)) ? controller.hw_bluetoothDeviceName : controller.productName, controller.hardwareIdentifier, controller.controllerTypeGuid, controller.axisCount, controller.buttonCount, controller.isButtonPressureSensitive, controller.gameHardwareMap, controller.controllerExtension, new ControllerDataUpdater(controller.inputManagerSource, controller.axisCount, controller.buttonCount, controller.unknownControllerHats))
		{
			REdHEDREevCvSFXTgOChyycUUQS = controller.sourceJoystick;
			BxmfGIMUjjyBvyrhaODhxOdxZeV = controller.hw_supportsVibration;
			oqOLiUnpVNxgLQkVxCKTKvPVHBRz = controller.hw_supportsVoice;
			CyODFPusZoMgZWYWNTqkZXRYGK = ((!(controller.controllerExtension is IControllerVibrator)) ? controller.hw_localVibrationMotorCount : 0);
			if (BxmfGIMUjjyBvyrhaODhxOdxZeV && CyODFPusZoMgZWYWNTqkZXRYGK > 0)
			{
				vCWlHsLIVWsGnAtiwReomiSBvcl = new float[CyODFPusZoMgZWYWNTqkZXRYGK];
				rGTPHXuGbNCmCiSQKiWROoibURE = new TimerAbs[CyODFPusZoMgZWYWNTqkZXRYGK];
				ArrayTools.Populate(rGTPHXuGbNCmCiSQKiWROoibURE, 0, CyODFPusZoMgZWYWNTqkZXRYGK);
				dsijKPslVIxdWanOtBcouabvOrt = true;
			}
			if (cBbvDblDdxYvWIffImKZKlfGJPE != Guid.Empty)
			{
				IList<HardwareJoystickTemplateMap> list = ReInput.SqSnCRwBXviNgdaFyBLeBjIkaBXg(cBbvDblDdxYvWIffImKZKlfGJPE);
				if (list != null)
				{
					List<IControllerTemplate> list2 = null;
					for (int i = 0; i < list.Count; i++)
					{
						HardwareJoystickTemplateMap hardwareJoystickTemplateMap = list[i];
						if (hardwareJoystickTemplateMap == null)
						{
							continue;
						}
						IControllerTemplate controllerTemplate;
						try
						{
							controllerTemplate = UnityTools.externalTools.CreateControllerTemplate(hardwareJoystickTemplateMap.Guid, new ControllerTemplate.zuyOybsNXzJDbboyfSNQaXayOHC(this, hardwareJoystickTemplateMap));
							if (controllerTemplate == null)
							{
								throw new Exception(string.Concat("Controller Template for guid ", hardwareJoystickTemplateMap.Guid, " was not found. If you are using custom Controller Templates, did you export the Controller Templates from the Controller Data Files inspector?"));
							}
						}
						catch (Exception ex)
						{
							Logger.LogErrorEditor(ex.Message);
							continue;
						}
						if (list2 == null)
						{
							list2 = new List<IControllerTemplate>();
						}
						list2.Add(controllerTemplate);
					}
					if (list2 != null)
					{
						TTvIpamiUEWLyYGxFHloUKOHlJO(list2.ToArray());
					}
				}
			}
			GHVjMXbHizvmmwecacPaiHtKzHl();
		}

		private Joystick(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, Guid hardwareTypeGuid, int axisCount, int buttonCount, bool[] isButtonPressureSensitive, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater)
			: base(controllerId, inputSource, name, hardwareName, hardwareIdentifier, ControllerType.Joystick, hardwareTypeGuid, axisCount, buttonCount, isButtonPressureSensitive, hardwareMap, extension, dataUpdater)
		{
			if (hardwareMap == null || hardwareMap.joystickTypes == null || hardwareMap.joystickTypes.Length == 0)
			{
				JoystickType[] clJdhzdQRrgXoTdwWpcFfMFvXjN = new JoystickType[1];
				ClJdhzdQRrgXoTdwWpcFfMFvXjN = clJdhzdQRrgXoTdwWpcFfMFvXjN;
			}
			else
			{
				ClJdhzdQRrgXoTdwWpcFfMFvXjN = hardwareMap.joystickTypes;
			}
			tSOImdvPCjxfOYXZrISLryHDKPI = new ReadOnlyCollection<JoystickType>(ClJdhzdQRrgXoTdwWpcFfMFvXjN);
			kVzZTbScCFNqnGUvhyjODzBRGOE = hardwareMap.hatCount;
			wvGIqCELhZyllMozbJeDLFcdBtR = new Hat[kVzZTbScCFNqnGUvhyjODzBRGOE];
			for (int i = 0; i < kVzZTbScCFNqnGUvhyjODzBRGOE; i++)
			{
				HardwareJoystickMap.CompoundElement hatData = hardwareMap.GetHatData(i);
				if (hatData == null)
				{
					Logger.LogError("Error creating Hat from hardware map! CompoundElement is null!");
					wvGIqCELhZyllMozbJeDLFcdBtR[i] = new Hat(this, hatData.elementIdentifier, "Hat " + i, new Button[0], new int[0]);
					continue;
				}
				List<Button> list = new List<Button>();
				List<int> list2 = new List<int>();
				for (int j = 0; j < hatData.elementCount; j++)
				{
					int componentElementIdentifierId = hatData.GetComponentElementIdentifierId(j);
					if (!ArrayTools.Contains(hardwareMap.buttonElementIdentifierIds, componentElementIdentifierId))
					{
						list.Add(null);
						list2.Add(-1);
						continue;
					}
					int buttonIndex = hardwareMap.GetButtonIndex(componentElementIdentifierId);
					if (buttonIndex < 0)
					{
						list.Add(null);
						list2.Add(-1);
					}
					else
					{
						list.Add(buttons[buttonIndex]);
						list2.Add(buttonIndex);
					}
				}
				try
				{
					wvGIqCELhZyllMozbJeDLFcdBtR[i] = new Hat(this, hatData.elementIdentifier, "Hat " + i, list.ToArray(), list2.ToArray());
				}
				catch
				{
					Logger.LogError("Error creating Hat from hardware map! Exception thrown when creating Hat.");
					wvGIqCELhZyllMozbJeDLFcdBtR[i] = new Hat(this, hatData.elementIdentifier, "Hat " + i, new Button[0], new int[0]);
				}
			}
			EYNGRZigLvuCOvyMvPeULBuzwLNN = new ReadOnlyCollection<Hat>(wvGIqCELhZyllMozbJeDLFcdBtR);
		}

		internal bool sCPkKyNwgxXWbAIDedUVCfBskcb(JoystickType P_0)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			int num = ClJdhzdQRrgXoTdwWpcFfMFvXjN.Length;
			for (int i = 0; i < num; i++)
			{
				if (ClJdhzdQRrgXoTdwWpcFfMFvXjN[i] == P_0)
				{
					return true;
				}
			}
			return false;
		}

		public JoystickCalibrationMapSaveData GetCalibrationMapSaveData()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			return new JoystickCalibrationMapSaveData(base.calibrationMap, _type, _hardwareIdentifier, base.hardwareTypeGuid);
		}

		public void SetVibration(float leftMotorLevel, float rightMotorLevel)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else
			{
				SetVibration(leftMotorLevel, rightMotorLevel, 0f, 0f);
			}
		}

		public void SetVibration(float leftMotorLevel, float rightMotorLevel, float leftMotorDuration, float rightMotorDuration)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else
			{
				if (!BxmfGIMUjjyBvyrhaODhxOdxZeV)
				{
					return;
				}
				if (base.extension is IControllerVibrator controllerVibrator)
				{
					int num = controllerVibrator.vibrationMotorCount;
					if (num > 0)
					{
						controllerVibrator.SetVibration(0, leftMotorLevel, leftMotorDuration);
					}
					if (num > 1)
					{
						controllerVibrator.SetVibration(1, rightMotorLevel, rightMotorDuration);
					}
				}
				if (dsijKPslVIxdWanOtBcouabvOrt)
				{
					if (CyODFPusZoMgZWYWNTqkZXRYGK > 0)
					{
						cZDYJDKhKueCaWCQzQYjFdZqoRB(0, leftMotorLevel, leftMotorDuration, false, false);
					}
					if (CyODFPusZoMgZWYWNTqkZXRYGK > 1)
					{
						cZDYJDKhKueCaWCQzQYjFdZqoRB(1, rightMotorLevel, rightMotorDuration, false, false);
					}
					SbriOsQfWkCTAbVyAHCSBeMAYQDn();
				}
			}
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
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else if (BxmfGIMUjjyBvyrhaODhxOdxZeV && motorIndex >= 0)
			{
				if (base.extension is IControllerVibrator controllerVibrator)
				{
					controllerVibrator.SetVibration(motorIndex, motorLevel, duration, stopOtherMotors);
				}
				if (dsijKPslVIxdWanOtBcouabvOrt && motorIndex < CyODFPusZoMgZWYWNTqkZXRYGK)
				{
					cZDYJDKhKueCaWCQzQYjFdZqoRB(motorIndex, motorLevel, duration, stopOtherMotors, true);
				}
			}
		}

		public float GetVibration(int motorIndex)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0f;
			}
			if (!BxmfGIMUjjyBvyrhaODhxOdxZeV || motorIndex < 0)
			{
				return 0f;
			}
			if (base.extension is IControllerVibrator controllerVibrator && motorIndex < controllerVibrator.vibrationMotorCount)
			{
				return controllerVibrator.GetVibration(motorIndex);
			}
			if (!dsijKPslVIxdWanOtBcouabvOrt)
			{
				return 0f;
			}
			if (motorIndex >= CyODFPusZoMgZWYWNTqkZXRYGK)
			{
				return 0f;
			}
			return vCWlHsLIVWsGnAtiwReomiSBvcl[motorIndex];
		}

		public void StopVibration()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else
			{
				if (!BxmfGIMUjjyBvyrhaODhxOdxZeV)
				{
					return;
				}
				if (base.extension is IControllerVibrator controllerVibrator)
				{
					controllerVibrator.StopVibration();
				}
				if (dsijKPslVIxdWanOtBcouabvOrt)
				{
					Array.Clear(vCWlHsLIVWsGnAtiwReomiSBvcl, 0, vCWlHsLIVWsGnAtiwReomiSBvcl.Length);
					for (int i = 0; i < CyODFPusZoMgZWYWNTqkZXRYGK; i++)
					{
						rGTPHXuGbNCmCiSQKiWROoibURE[i].Clear();
					}
				}
				if (REdHEDREevCvSFXTgOChyycUUQS != null)
				{
					REdHEDREevCvSFXTgOChyycUUQS.StopVibration();
				}
			}
		}

		internal override void MlEQHREVxHLTuUCANSxPMEKvYTk(UpdateLoopType P_0)
		{
			base.MlEQHREVxHLTuUCANSxPMEKvYTk(P_0);
			for (int i = 0; i < kVzZTbScCFNqnGUvhyjODzBRGOE; i++)
			{
				if (wvGIqCELhZyllMozbJeDLFcdBtR[i] != null)
				{
					wvGIqCELhZyllMozbJeDLFcdBtR[i].DAJzqdfwzCTZStXkEMKmKOxyqdV(P_0, OcGEaRzMecIeBFudxFTOaknZTFKe);
				}
			}
			KpbwJNcuwWkNyuMDipKdKvsTxou();
		}

		internal void NawDrBiFtihWvqZtlfFzOTHFrgRq(UpdateControllerInfoEventArgs P_0)
		{
			if (P_0 != null)
			{
				NawDrBiFtihWvqZtlfFzOTHFrgRq(P_0.sourceJoystick);
			}
		}

		internal void NawDrBiFtihWvqZtlfFzOTHFrgRq(BridgedController P_0)
		{
			if (P_0 != null)
			{
				NawDrBiFtihWvqZtlfFzOTHFrgRq(P_0.sourceJoystick);
			}
		}

		private void NawDrBiFtihWvqZtlfFzOTHFrgRq(IInputManagerJoystickPublic P_0)
		{
			REdHEDREevCvSFXTgOChyycUUQS = P_0;
			if (P_0 != null)
			{
				if (base.extension != null)
				{
					MUdrzCGqazHwzKMunKArfQcPCFd(P_0.extension);
				}
				else
				{
					EyudLnaJxSCTjRsYXBQCHZHZVXjs(P_0.extension);
				}
				if (P_0.name != string.Empty)
				{
					_name = P_0.name;
				}
			}
		}

		internal override void LlCkzvOeJVaCziTDPktzBWuYotAZ()
		{
			base.LlCkzvOeJVaCziTDPktzBWuYotAZ();
			StopVibration();
		}

		protected override void Disconnected()
		{
			base.Disconnected();
			if (dsijKPslVIxdWanOtBcouabvOrt)
			{
				Array.Clear(vCWlHsLIVWsGnAtiwReomiSBvcl, 0, vCWlHsLIVWsGnAtiwReomiSBvcl.Length);
				for (int i = 0; i < CyODFPusZoMgZWYWNTqkZXRYGK; i++)
				{
					rGTPHXuGbNCmCiSQKiWROoibURE[i].Clear();
				}
			}
			if (base.extension is IControllerVibrator controllerVibrator)
			{
				controllerVibrator.StopVibration();
			}
		}

		private void KpbwJNcuwWkNyuMDipKdKvsTxou()
		{
			if (!BxmfGIMUjjyBvyrhaODhxOdxZeV || !dsijKPslVIxdWanOtBcouabvOrt)
			{
				return;
			}
			for (int i = 0; i < CyODFPusZoMgZWYWNTqkZXRYGK; i++)
			{
				if (rGTPHXuGbNCmCiSQKiWROoibURE[i].Update())
				{
					SetVibration(i, 0f, stopOtherMotors: false);
				}
			}
		}

		private void cZDYJDKhKueCaWCQzQYjFdZqoRB(int P_0, float P_1, float P_2, bool P_3, bool P_4)
		{
			if (!dsijKPslVIxdWanOtBcouabvOrt || P_0 < 0 || P_0 >= CyODFPusZoMgZWYWNTqkZXRYGK)
			{
				return;
			}
			if (P_3)
			{
				Array.Clear(vCWlHsLIVWsGnAtiwReomiSBvcl, 0, vCWlHsLIVWsGnAtiwReomiSBvcl.Length);
				for (int i = 0; i < CyODFPusZoMgZWYWNTqkZXRYGK; i++)
				{
					rGTPHXuGbNCmCiSQKiWROoibURE[i].Clear();
				}
			}
			vCWlHsLIVWsGnAtiwReomiSBvcl[P_0] = MathTools.Clamp01(P_1);
			if (P_1 <= 0f || P_2 <= 0f)
			{
				rGTPHXuGbNCmCiSQKiWROoibURE[P_0].Clear();
			}
			else
			{
				rGTPHXuGbNCmCiSQKiWROoibURE[P_0].Start(P_2);
			}
			if (P_4)
			{
				SbriOsQfWkCTAbVyAHCSBeMAYQDn();
			}
		}

		private void SbriOsQfWkCTAbVyAHCSBeMAYQDn()
		{
			if (BxmfGIMUjjyBvyrhaODhxOdxZeV && dsijKPslVIxdWanOtBcouabvOrt && REdHEDREevCvSFXTgOChyycUUQS != null)
			{
				for (int i = 0; i < vCWlHsLIVWsGnAtiwReomiSBvcl.Length; i++)
				{
					REdHEDREevCvSFXTgOChyycUUQS.SetVibration(vCWlHsLIVWsGnAtiwReomiSBvcl[i], i);
				}
			}
		}

		private void cLIndNvzUSpNefvHjLIEdqyXYdk()
		{
		}

		internal static int EnXrqwOiOlQcCNmvWwnyxNBgiYQ(Joystick P_0, Joystick P_1)
		{
			if (P_0.inputManagerId < P_1.inputManagerId)
			{
				return -1;
			}
			if (P_0.inputManagerId > P_1.inputManagerId)
			{
				return 1;
			}
			return 0;
		}
	}
}
