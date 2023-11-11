using System;
using Rewired.Data.Mapping;
using Rewired.Interfaces;

namespace Rewired
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class UnityUnifiedKeyboardSource : IDisposable, IUnifiedKeyboardSource
	{
		private const int FDKfnAfwXcZCMUJTWcLPAAliFJlC = 132;

		private static HardwareControllerMap_Game YEvBlnoHrAIKQwXfVdVquxCCbOI;

		private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

		public InputSource inputSource => InputSource.UnityKeyboardAndMouse;

		public HardwareControllerMap_Game hardwareMap
		{
			get
			{
				if (YEvBlnoHrAIKQwXfVdVquxCCbOI == null)
				{
					YEvBlnoHrAIKQwXfVdVquxCCbOI = EkATihgNzpqJyNHvEpvnKmlFEseC();
				}
				return YEvBlnoHrAIKQwXfVdVquxCCbOI;
			}
		}

		public int buttonCount => 132;

		public Controller.Extension controllerExtension => null;

		public UnityUnifiedKeyboardSource()
		{
			ThreadSafeUnityInput.keyboard.Monitor(state: true);
		}

		public void UpdateInputData(ControllerDataUpdater dataUpdater)
		{
			ThreadSafeUnityInput.keyboard.GetKeyValues(dataUpdater.buttonValues);
		}

		public void Clear()
		{
		}

		private static HardwareControllerMap_Game EkATihgNzpqJyNHvEpvnKmlFEseC()
		{
			ControllerElementIdentifier[] array = new ControllerElementIdentifier[132];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new ControllerElementIdentifier(i, Consts.keyboardKeyNames[i], Consts.keyboardKeyNames[i], string.Empty, ControllerElementType.Button, isMappableOnPlatform: true);
			}
			int[] array2 = new int[132];
			for (int j = 0; j < 132; j++)
			{
				array2[j] = array[j].id;
			}
			HardwareButtonInfo[] array3 = new HardwareButtonInfo[132];
			for (int k = 0; k < 132; k++)
			{
				array3[k] = new HardwareButtonInfo();
			}
			return new HardwareControllerMap_Game("Keyboard", default(HardwareControllerMapIdentifier), array, array2, new int[0], new AxisCalibrationData[0], new AxisRange[0], new HardwareAxisInfo[0], array3, null);
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		~UnityUnifiedKeyboardSource()
		{
			Dispose(disposing: false);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!RFSEgUYkCipDyWyLEnlGiNDUlzz)
			{
				if (disposing)
				{
					ThreadSafeUnityInput.keyboard.Monitor(state: false);
				}
				RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
			}
		}

		public static ControllerElementType GetHardwareElementType(int elementIdentifierId)
		{
			if (YEvBlnoHrAIKQwXfVdVquxCCbOI == null)
			{
				YEvBlnoHrAIKQwXfVdVquxCCbOI = EkATihgNzpqJyNHvEpvnKmlFEseC();
			}
			return YEvBlnoHrAIKQwXfVdVquxCCbOI.GetElementType(elementIdentifierId);
		}
	}
}
