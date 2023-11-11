using System;
using System.Runtime.CompilerServices;
using Rewired.Data.Mapping;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class UnityUnifiedMouseSource : IDisposable, IUnifiedMouseSource
	{
		private class qmlJxYGzRkizGQPiFMWFEuofmPe
		{
			private float[] JWSTmXxylewMCJbzJgQEaiPlrlVe;

			private bool[] lBRchCPBrWJOBnDlrdljokFSuOQ;

			public qmlJxYGzRkizGQPiFMWFEuofmPe(int buttonCount, int axisCount)
			{
				lBRchCPBrWJOBnDlrdljokFSuOQ = new bool[buttonCount];
				JWSTmXxylewMCJbzJgQEaiPlrlVe = new float[axisCount];
			}

			public void nTJUqhNpCBebjlXaomJUgjRFSTS(bool[] P_0, float[] P_1)
			{
				Array.Copy(P_0, lBRchCPBrWJOBnDlrdljokFSuOQ, P_0.Length);
				for (int i = 0; i < JWSTmXxylewMCJbzJgQEaiPlrlVe.Length; i++)
				{
					JWSTmXxylewMCJbzJgQEaiPlrlVe[i] += P_1[i];
				}
			}

			public void nyWGdaLNQgMQwHqMBrKPaGPJzTO(ControllerDataUpdater P_0)
			{
				Array.Copy(JWSTmXxylewMCJbzJgQEaiPlrlVe, P_0.axisValues, JWSTmXxylewMCJbzJgQEaiPlrlVe.Length);
				Array.Copy(lBRchCPBrWJOBnDlrdljokFSuOQ, P_0.buttonValues, lBRchCPBrWJOBnDlrdljokFSuOQ.Length);
			}

			public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
			{
				Array.Clear(JWSTmXxylewMCJbzJgQEaiPlrlVe, 0, JWSTmXxylewMCJbzJgQEaiPlrlVe.Length);
				Array.Clear(lBRchCPBrWJOBnDlrdljokFSuOQ, 0, lBRchCPBrWJOBnDlrdljokFSuOQ.Length);
			}

			public void GkdjzJiUjbeIsxLKAOujPPZxJnJ()
			{
				Array.Clear(JWSTmXxylewMCJbzJgQEaiPlrlVe, 0, JWSTmXxylewMCJbzJgQEaiPlrlVe.Length);
			}
		}

		private static HardwareControllerMap_Game YEvBlnoHrAIKQwXfVdVquxCCbOI;

		private UpdateLoopDataSet<qmlJxYGzRkizGQPiFMWFEuofmPe> GhZDISgmGOXECgBmhWKTlfRBgRzq;

		private float[] JWSTmXxylewMCJbzJgQEaiPlrlVe;

		private bool[] lBRchCPBrWJOBnDlrdljokFSuOQ;

		private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

		[CompilerGenerated]
		private static Func<qmlJxYGzRkizGQPiFMWFEuofmPe> feNsFZUOhAfDWJOQenHKxUwAcDTR;

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

		public int buttonCount => 7;

		public int axisCount => 4;

		public Vector2 mousePosition => ThreadSafeUnityInput.mouse.mousePosition;

		public Controller.Extension controllerExtension => null;

		public UnityUnifiedMouseSource()
		{
			ThreadSafeUnityInput.mouse.Monitor(state: true);
			GhZDISgmGOXECgBmhWKTlfRBgRzq = new UpdateLoopDataSet<qmlJxYGzRkizGQPiFMWFEuofmPe>(ReInput.configVars.updateLoop, () => new qmlJxYGzRkizGQPiFMWFEuofmPe(7, 4));
			JWSTmXxylewMCJbzJgQEaiPlrlVe = new float[4];
			lBRchCPBrWJOBnDlrdljokFSuOQ = new bool[7];
			ReInput.UpdateEndedEvent += QKnPiXsJFJFPyUPdspIxACyXqik;
			ReInput.EarlyUpdateEvent += IGLvsvkDDRWUbMIVGQstJSNKtrQ;
		}

		public void UpdateInputData(ControllerDataUpdater dataUpdater)
		{
			GhZDISgmGOXECgBmhWKTlfRBgRzq.Get(ReInput.currentUpdateLoop).nyWGdaLNQgMQwHqMBrKPaGPJzTO(dataUpdater);
		}

		public void Clear()
		{
			int count = GhZDISgmGOXECgBmhWKTlfRBgRzq.Count;
			for (int i = 0; i < count; i++)
			{
				GhZDISgmGOXECgBmhWKTlfRBgRzq.Get(i).LlCkzvOeJVaCziTDPktzBWuYotAZ();
			}
		}

		private void IGLvsvkDDRWUbMIVGQstJSNKtrQ()
		{
			ThreadSafeUnityInput.mouse.GetAxisRawValues(JWSTmXxylewMCJbzJgQEaiPlrlVe);
			ThreadSafeUnityInput.mouse.GetButtonValues(lBRchCPBrWJOBnDlrdljokFSuOQ);
			int count = GhZDISgmGOXECgBmhWKTlfRBgRzq.Count;
			for (int i = 0; i < count; i++)
			{
				GhZDISgmGOXECgBmhWKTlfRBgRzq.Get(i).nTJUqhNpCBebjlXaomJUgjRFSTS(lBRchCPBrWJOBnDlrdljokFSuOQ, JWSTmXxylewMCJbzJgQEaiPlrlVe);
			}
		}

		private void QKnPiXsJFJFPyUPdspIxACyXqik(UpdateLoopType P_0)
		{
			GhZDISgmGOXECgBmhWKTlfRBgRzq.Get(P_0).GkdjzJiUjbeIsxLKAOujPPZxJnJ();
		}

		private static HardwareControllerMap_Game EkATihgNzpqJyNHvEpvnKmlFEseC()
		{
			ControllerElementIdentifier[] array = new ControllerElementIdentifier[Consts.unityUnifiedMouseElementIdentifiers.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = new ControllerElementIdentifier(Consts.unityUnifiedMouseElementIdentifiers[i]);
			}
			int[] array2 = new int[7];
			int[] array3 = new int[4];
			int num = 0;
			int num2 = 0;
			for (int j = 0; j < array.Length; j++)
			{
				if (array[j].elementType == ControllerElementType.Axis)
				{
					array3[num2++] = array[j].id;
				}
				else if (array[j].elementType == ControllerElementType.Button)
				{
					array2[num++] = array[j].id;
				}
			}
			AxisCalibrationData[] array4 = new AxisCalibrationData[4];
			AxisRange[] array5 = new AxisRange[4];
			HardwareAxisInfo[] array6 = new HardwareAxisInfo[4];
			HardwareButtonInfo[] array7 = new HardwareButtonInfo[7];
			for (int k = 0; k < 4; k++)
			{
				ref AxisCalibrationData reference = ref array4[k];
				reference = AxisCalibrationData.Raw;
				array5[k] = AxisRange.Full;
				float pollingDeadZone;
				switch (k)
				{
				case 0:
				case 1:
					pollingDeadZone = 100f;
					break;
				default:
					pollingDeadZone = 2f;
					break;
				}
				array6[k] = new HardwareAxisInfo(AxisCoordinateMode.Relative, excludeFromPolling: false, pollingDeadZone, SpecialAxisType.None);
			}
			for (int l = 0; l < 7; l++)
			{
				array7[l] = new HardwareButtonInfo();
			}
			return new HardwareControllerMap_Game("Mouse", default(HardwareControllerMapIdentifier), array, array2, array3, array4, array5, array6, array7, null);
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		~UnityUnifiedMouseSource()
		{
			Dispose(disposing: false);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!RFSEgUYkCipDyWyLEnlGiNDUlzz)
			{
				if (disposing)
				{
					ThreadSafeUnityInput.mouse.Monitor(state: false);
					ReInput.UpdateEndedEvent -= QKnPiXsJFJFPyUPdspIxACyXqik;
					ReInput.EarlyUpdateEvent -= IGLvsvkDDRWUbMIVGQstJSNKtrQ;
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

		[CompilerGenerated]
		private static qmlJxYGzRkizGQPiFMWFEuofmPe XKFWLQwxvyuZhvVFOpYzEIQENLl()
		{
			return new qmlJxYGzRkizGQPiFMWFEuofmPe(7, 4);
		}
	}
}
