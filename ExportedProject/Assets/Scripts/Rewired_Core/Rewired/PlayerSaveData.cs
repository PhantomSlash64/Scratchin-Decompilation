using System.Collections.Generic;

namespace Rewired
{
	public struct PlayerSaveData
	{
		private JoystickMapSaveData[] mlcXwVthzmHKttluWkKlpfIGiRq;

		private KeyboardMapSaveData[] CaAmGpREElLbCLzkjsnSGbTSbvAd;

		private MouseMapSaveData[] aRDbAiGizHMTqbGpErkELMXEtzsi;

		private CustomControllerMapSaveData[] gMQIjwFZCUGYEyeRXVSGSPnXiwYf;

		private InputBehavior[] BUKMpuIowhbABQOsJAFSbsmlInK;

		public JoystickMapSaveData[] joystickMapSaveData => mlcXwVthzmHKttluWkKlpfIGiRq;

		public KeyboardMapSaveData[] keyboardMapSaveData => CaAmGpREElLbCLzkjsnSGbTSbvAd;

		public MouseMapSaveData[] mouseMapSaveData => aRDbAiGizHMTqbGpErkELMXEtzsi;

		public CustomControllerMapSaveData[] customControllerMapSaveData => gMQIjwFZCUGYEyeRXVSGSPnXiwYf;

		public InputBehavior[] inputBehaviors => BUKMpuIowhbABQOsJAFSbsmlInK;

		public int joystickMapCount
		{
			get
			{
				if (mlcXwVthzmHKttluWkKlpfIGiRq == null)
				{
					return 0;
				}
				return mlcXwVthzmHKttluWkKlpfIGiRq.Length;
			}
		}

		public int keyboardMapCount
		{
			get
			{
				if (CaAmGpREElLbCLzkjsnSGbTSbvAd == null)
				{
					return 0;
				}
				return CaAmGpREElLbCLzkjsnSGbTSbvAd.Length;
			}
		}

		public int mouseMapCount
		{
			get
			{
				if (aRDbAiGizHMTqbGpErkELMXEtzsi == null)
				{
					return 0;
				}
				return aRDbAiGizHMTqbGpErkELMXEtzsi.Length;
			}
		}

		public int customControllerMapCount
		{
			get
			{
				if (gMQIjwFZCUGYEyeRXVSGSPnXiwYf == null)
				{
					return 0;
				}
				return gMQIjwFZCUGYEyeRXVSGSPnXiwYf.Length;
			}
		}

		public int inputBehaviorCount
		{
			get
			{
				if (BUKMpuIowhbABQOsJAFSbsmlInK == null)
				{
					return 0;
				}
				return BUKMpuIowhbABQOsJAFSbsmlInK.Length;
			}
		}

		public IEnumerable<ControllerMapSaveData> AllControllerMapSaveData
		{
			get
			{
				if (mlcXwVthzmHKttluWkKlpfIGiRq != null)
				{
					for (int i = 0; i < mlcXwVthzmHKttluWkKlpfIGiRq.Length; i++)
					{
						if (mlcXwVthzmHKttluWkKlpfIGiRq[i] != null)
						{
							yield return mlcXwVthzmHKttluWkKlpfIGiRq[i];
						}
					}
				}
				if (CaAmGpREElLbCLzkjsnSGbTSbvAd != null)
				{
					for (int j = 0; j < CaAmGpREElLbCLzkjsnSGbTSbvAd.Length; j++)
					{
						if (CaAmGpREElLbCLzkjsnSGbTSbvAd[j] != null)
						{
							yield return CaAmGpREElLbCLzkjsnSGbTSbvAd[j];
						}
					}
				}
				if (aRDbAiGizHMTqbGpErkELMXEtzsi != null)
				{
					for (int k = 0; k < aRDbAiGizHMTqbGpErkELMXEtzsi.Length; k++)
					{
						if (aRDbAiGizHMTqbGpErkELMXEtzsi[k] != null)
						{
							yield return aRDbAiGizHMTqbGpErkELMXEtzsi[k];
						}
					}
				}
				if (gMQIjwFZCUGYEyeRXVSGSPnXiwYf == null)
				{
					yield break;
				}
				for (int l = 0; l < gMQIjwFZCUGYEyeRXVSGSPnXiwYf.Length; l++)
				{
					if (gMQIjwFZCUGYEyeRXVSGSPnXiwYf[l] != null)
					{
						yield return gMQIjwFZCUGYEyeRXVSGSPnXiwYf[l];
					}
				}
			}
		}

		internal PlayerSaveData(JoystickMapSaveData[] joystickMapSaveData, KeyboardMapSaveData[] keyboardMapSaveData, MouseMapSaveData[] mouseMapSaveData, CustomControllerMapSaveData[] customControllerMapSaveData, IList<InputBehavior> inputBehaviors)
		{
			mlcXwVthzmHKttluWkKlpfIGiRq = joystickMapSaveData;
			CaAmGpREElLbCLzkjsnSGbTSbvAd = keyboardMapSaveData;
			aRDbAiGizHMTqbGpErkELMXEtzsi = mouseMapSaveData;
			gMQIjwFZCUGYEyeRXVSGSPnXiwYf = customControllerMapSaveData;
			int num = inputBehaviors?.Count ?? 0;
			BUKMpuIowhbABQOsJAFSbsmlInK = new InputBehavior[num];
			for (int i = 0; i < num; i++)
			{
				BUKMpuIowhbABQOsJAFSbsmlInK[i] = inputBehaviors[i];
			}
		}
	}
}
