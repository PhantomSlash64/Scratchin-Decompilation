using System;
using Rewired.Utils;

namespace Rewired
{
	public sealed class CustomController : ControllerWithAxes
	{
		private int hiziHmUCZqZbMkYgeNzYotFeKtK;

		private Func<int, float> ClzqnCGeeiLIMUzQZAPCLuIQGHh;

		private Func<int, bool> kyHvWZjHJxIPvASVMgQioVLHneg;

		private bool leyEAxsFvnDoLfeoXzqpJeEABDXA;

		private Guid fjSleAyNNzAAwUFQRDtsPmEVFPD;

		public int sourceControllerId => hiziHmUCZqZbMkYgeNzYotFeKtK;

		public override Guid deviceInstanceGuid
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return Guid.Empty;
				}
				return fjSleAyNNzAAwUFQRDtsPmEVFPD;
			}
		}

		internal CustomController(AFODjzKlpaHUZVznVrGUOLpAAzr data)
			: this(data.gNijVFSxPIkIXVEBfXiCOWbvkEY, data.BFniuQsiHoATkbVSQijmMnCGgfFF, data.DsvcrAsDzjKdOtdTrgwIMYaspWg, data.eEGdvsHFSoebDZTJoammOSBqiFV, data.kKDfGMxMvbfrZIlPuNxkGciRTym, data.QADfLjClYSqotoMLVgvUawAGYijP, data.NsmiaUIozmFmBaKTmrdloGVhDiE, data.beRmxTPYgeEljczGnIuTQeGMXoR, data.aumNItRblDdXZicbRkrPApteCjR, data.fznXTxzKbATxoxCDAIgWelhrXjn, null, new ControllerDataUpdater(data.eEGdvsHFSoebDZTJoammOSBqiFV, data.beRmxTPYgeEljczGnIuTQeGMXoR, data.aumNItRblDdXZicbRkrPApteCjR, null))
		{
		}

		private CustomController(int controllerId, int sourceControllerId, Guid hardwareTypeGuid, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, int axisCount, int buttonCount, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater)
			: base(controllerId, inputSource, name, hardwareName, hardwareIdentifier, ControllerType.Custom, hardwareTypeGuid, axisCount, buttonCount, null, hardwareMap, extension, dataUpdater)
		{
			hiziHmUCZqZbMkYgeNzYotFeKtK = sourceControllerId;
			fjSleAyNNzAAwUFQRDtsPmEVFPD = MiscTools.CreateGuidHashSHA1("CustomController device instance GUID: sourceId = " + hiziHmUCZqZbMkYgeNzYotFeKtK + ", controllerId = " + controllerId);
			GHVjMXbHizvmmwecacPaiHtKzHl();
		}

		internal void aUBASQMtPCHuIHMaOlMEaiZdWOe()
		{
			if (!leyEAxsFvnDoLfeoXzqpJeEABDXA)
			{
				return;
			}
			if (ClzqnCGeeiLIMUzQZAPCLuIQGHh != null)
			{
				for (int i = 0; i < _axisCount; i++)
				{
					OcGEaRzMecIeBFudxFTOaknZTFKe.axisValues[i] = ClzqnCGeeiLIMUzQZAPCLuIQGHh(i);
				}
			}
			if (kyHvWZjHJxIPvASVMgQioVLHneg != null)
			{
				for (int j = 0; j < _buttonCount; j++)
				{
					OcGEaRzMecIeBFudxFTOaknZTFKe.buttonValues[j] = kyHvWZjHJxIPvASVMgQioVLHneg(j);
				}
			}
		}

		public void SetAxisValue(int index, float value)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else if (base.enabled)
			{
				if (index < 0 || index >= _axisCount)
				{
					Logger.LogWarning(index + " is not a valid Axis index.");
				}
				else
				{
					OcGEaRzMecIeBFudxFTOaknZTFKe.axisValues[index] = value;
				}
			}
		}

		public void SetAxisValue(string elementName, float value)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else if (base.enabled)
			{
				int axisIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetAxisIndex(elementName);
				if (axisIndex < 0 || axisIndex >= _axisCount)
				{
					Logger.LogWarning("\"" + axisIndex + "\" is not a valid Axis name.");
				}
				else
				{
					OcGEaRzMecIeBFudxFTOaknZTFKe.axisValues[axisIndex] = value;
				}
			}
		}

		public void SetAxisValueById(int elementId, float value)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else if (base.enabled)
			{
				int axisIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetAxisIndex(elementId);
				if (axisIndex < 0 || axisIndex >= _axisCount)
				{
					Logger.LogWarning(elementId + " is not a valid Axis id.");
				}
				else
				{
					OcGEaRzMecIeBFudxFTOaknZTFKe.axisValues[axisIndex] = value;
				}
			}
		}

		public void SetButtonValue(int index, bool value)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else if (base.enabled)
			{
				if (index < 0 || index >= _buttonCount)
				{
					Logger.LogWarning(index + " is not a valid Button index.");
				}
				else
				{
					OcGEaRzMecIeBFudxFTOaknZTFKe.buttonValues[index] = value;
				}
			}
		}

		public void SetButtonValue(string elementName, bool value)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else if (base.enabled)
			{
				int buttonIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementName);
				if (buttonIndex < 0 || buttonIndex >= _buttonCount)
				{
					Logger.LogWarning("\"" + buttonIndex + "\" is not a valid Button name.");
				}
				else
				{
					OcGEaRzMecIeBFudxFTOaknZTFKe.buttonValues[buttonIndex] = value;
				}
			}
		}

		public void SetButtonValueById(int elementId, bool value)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else if (base.enabled)
			{
				int buttonIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementId);
				if (buttonIndex < 0 || buttonIndex >= _buttonCount)
				{
					Logger.LogWarning(elementId + " is not a valid Button id.");
				}
				else
				{
					OcGEaRzMecIeBFudxFTOaknZTFKe.buttonValues[buttonIndex] = value;
				}
			}
		}

		public void SetAxisUpdateCallback(Func<int, float> callback)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return;
			}
			ClzqnCGeeiLIMUzQZAPCLuIQGHh = callback;
			if (!leyEAxsFvnDoLfeoXzqpJeEABDXA)
			{
				leyEAxsFvnDoLfeoXzqpJeEABDXA = true;
			}
		}

		public void SetButtonUpdateCallback(Func<int, bool> callback)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return;
			}
			kyHvWZjHJxIPvASVMgQioVLHneg = callback;
			if (!leyEAxsFvnDoLfeoXzqpJeEABDXA)
			{
				leyEAxsFvnDoLfeoXzqpJeEABDXA = true;
			}
		}

		public void ClearAxisValue(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else if (base.enabled)
			{
				if (index < 0 || index >= _axisCount)
				{
					Logger.LogWarning(index + " is not a valid Axis index.");
					return;
				}
				float num = ((_calibrationMap != null) ? _calibrationMap.GetAxis(index).calibratedZero : 0f);
				OcGEaRzMecIeBFudxFTOaknZTFKe.axisValues[index] = num;
			}
		}

		public void ClearAxisValue(string elementName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else if (base.enabled)
			{
				int axisIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetAxisIndex(elementName);
				if (axisIndex < 0 || axisIndex >= _axisCount)
				{
					Logger.LogWarning("\"" + axisIndex + "\" is not a valid Axis name.");
				}
				else
				{
					ClearAxisValue(axisIndex);
				}
			}
		}

		public void ClearAxisValueById(int elementId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else if (base.enabled)
			{
				int axisIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetAxisIndex(elementId);
				if (axisIndex < 0 || axisIndex >= _axisCount)
				{
					Logger.LogWarning(elementId + " is not a valid Axis id.");
				}
				else
				{
					ClearAxisValue(axisIndex);
				}
			}
		}

		public void ClearButtonValue(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else if (base.enabled)
			{
				if (index < 0 || index >= _buttonCount)
				{
					Logger.LogWarning(index + " is not a valid Button index.");
					return;
				}
				OcGEaRzMecIeBFudxFTOaknZTFKe.buttonValues[index] = false;
				OcGEaRzMecIeBFudxFTOaknZTFKe.buttonPressureValues[index] = 0f;
			}
		}

		public void ClearButtonValue(string elementName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else if (base.enabled)
			{
				int buttonIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementName);
				if (buttonIndex < 0 || buttonIndex >= _buttonCount)
				{
					Logger.LogWarning("\"" + buttonIndex + "\" is not a valid Button name.");
				}
				else
				{
					ClearButtonValue(buttonIndex);
				}
			}
		}

		public void ClearButtonValueById(int elementId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else if (base.enabled)
			{
				int buttonIndex = pAhzhvigFoLFbwPDdcXHatZWRIl.GetButtonIndex(elementId);
				if (buttonIndex < 0 || buttonIndex >= _buttonCount)
				{
					Logger.LogWarning(elementId + " is not a valid Button id.");
				}
				else
				{
					ClearButtonValue(buttonIndex);
				}
			}
		}
	}
}
