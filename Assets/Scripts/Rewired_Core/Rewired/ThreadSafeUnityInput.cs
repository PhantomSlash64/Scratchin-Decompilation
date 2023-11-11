using System;
using Rewired.Utils;
using UnityEngine;

namespace Rewired
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	[CustomObfuscation(rename = false)]
	internal static class ThreadSafeUnityInput
	{
		[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
		[CustomObfuscation(rename = false)]
		public sealed class Keyboard
		{
			private const int FDKfnAfwXcZCMUJTWcLPAAliFJlC = 132;

			public static readonly int keyValueIndex_Escape;

			public static readonly int keyValueIndex_Menu;

			public static readonly int keyValueIndex_F2;

			public static readonly int keyValueIndex_UpArrow;

			public static readonly int keyValueIndex_RightArrow;

			public static readonly int keyValueIndex_DownArrow;

			public static readonly int keyValueIndex_LeftArrow;

			private static readonly int[] cRZewoBqgbrcOAsuBRXnKNJQiLYA;

			private readonly int dtNcFIcqHwHaLRfyRiiJQLjKHLp;

			private readonly int[] vikAbZFwYtxLdEQxsaszxofZoxX;

			private readonly bool[] dWBakvwRNaeXHZTwqDturfEhOTq;

			private bool nZTtfeZBpthDaoAvSONdTABGEaM;

			private int ftwpGdaCEqoRUOvSphWCUqulKCQ;

			private readonly bool nCHYhyJVuOgauyGTGcWtTfTJbDs;

			private bool dCKdpuWFkAEyNCteaTqBnXuIPcs;

			public bool enabled
			{
				get
				{
					return nZTtfeZBpthDaoAvSONdTABGEaM;
				}
				set
				{
					if (value != nZTtfeZBpthDaoAvSONdTABGEaM)
					{
						nZTtfeZBpthDaoAvSONdTABGEaM = value;
						if (!nZTtfeZBpthDaoAvSONdTABGEaM)
						{
							Clear();
						}
					}
				}
			}

			public bool monitoring => ftwpGdaCEqoRUOvSphWCUqulKCQ > 0;

			public int keyCount => 132;

			static Keyboard()
			{
				if (UnityTools.isAndroidPlatform)
				{
					int[] keyboardKeyValues = Consts._keyboardKeyValues;
					cRZewoBqgbrcOAsuBRXnKNJQiLYA = new int[7]
					{
						keyValueIndex_Escape = ArrayTools.IndexOf(keyboardKeyValues, 27),
						keyValueIndex_Menu = ArrayTools.IndexOf(keyboardKeyValues, 319),
						keyValueIndex_F2 = ArrayTools.IndexOf(keyboardKeyValues, 283),
						keyValueIndex_UpArrow = ArrayTools.IndexOf(keyboardKeyValues, 273),
						keyValueIndex_RightArrow = ArrayTools.IndexOf(keyboardKeyValues, 275),
						keyValueIndex_DownArrow = ArrayTools.IndexOf(keyboardKeyValues, 274),
						keyValueIndex_LeftArrow = ArrayTools.IndexOf(keyboardKeyValues, 276)
					};
				}
			}

			public Keyboard()
			{
				dWBakvwRNaeXHZTwqDturfEhOTq = new bool[132];
				int[] keyboardKeyValues = Consts._keyboardKeyValues;
				int num = keyboardKeyValues.Length;
				for (int i = 0; i < num; i++)
				{
					if (keyboardKeyValues[i] > dtNcFIcqHwHaLRfyRiiJQLjKHLp)
					{
						dtNcFIcqHwHaLRfyRiiJQLjKHLp = keyboardKeyValues[i];
					}
				}
				vikAbZFwYtxLdEQxsaszxofZoxX = new int[dtNcFIcqHwHaLRfyRiiJQLjKHLp + 1];
				ArrayTools.Fill(vikAbZFwYtxLdEQxsaszxofZoxX, -1);
				for (int j = 0; j < num; j++)
				{
					vikAbZFwYtxLdEQxsaszxofZoxX[keyboardKeyValues[j]] = j;
				}
			}

			public void Initialize()
			{
				if (ftwpGdaCEqoRUOvSphWCUqulKCQ != 0)
				{
					FvJdLDQEsLVCuUoWZJSKubtDcA();
				}
				uileOmkJVJtYTHLCMEDfKtvVrfX();
			}

			public void PostInitialize()
			{
				Update();
			}

			public void Update()
			{
				if (ftwpGdaCEqoRUOvSphWCUqulKCQ == 0)
				{
					return;
				}
				if (Input.anyKey)
				{
					dCKdpuWFkAEyNCteaTqBnXuIPcs = true;
					if (nZTtfeZBpthDaoAvSONdTABGEaM)
					{
						int[] keyboardKeyValues = Consts._keyboardKeyValues;
						for (int i = 0; i < 132; i++)
						{
							dWBakvwRNaeXHZTwqDturfEhOTq[i] = Input.GetKey((KeyCode)keyboardKeyValues[i]);
						}
					}
					else if (nCHYhyJVuOgauyGTGcWtTfTJbDs)
					{
						dWBakvwRNaeXHZTwqDturfEhOTq[keyValueIndex_Escape] = GetKey(KeyCode.Escape);
						dWBakvwRNaeXHZTwqDturfEhOTq[keyValueIndex_Menu] = GetKey(KeyCode.Menu);
						dWBakvwRNaeXHZTwqDturfEhOTq[keyValueIndex_F2] = GetKey(KeyCode.F2);
						dWBakvwRNaeXHZTwqDturfEhOTq[keyValueIndex_UpArrow] = GetKey(KeyCode.UpArrow);
						dWBakvwRNaeXHZTwqDturfEhOTq[keyValueIndex_RightArrow] = GetKey(KeyCode.RightArrow);
						dWBakvwRNaeXHZTwqDturfEhOTq[keyValueIndex_DownArrow] = GetKey(KeyCode.DownArrow);
						dWBakvwRNaeXHZTwqDturfEhOTq[keyValueIndex_LeftArrow] = GetKey(KeyCode.LeftArrow);
					}
				}
				else if (dCKdpuWFkAEyNCteaTqBnXuIPcs)
				{
					Array.Clear(dWBakvwRNaeXHZTwqDturfEhOTq, 0, dWBakvwRNaeXHZTwqDturfEhOTq.Length);
				}
			}

			public void Monitor(bool state)
			{
				if (state)
				{
					ftwpGdaCEqoRUOvSphWCUqulKCQ++;
					if (ftwpGdaCEqoRUOvSphWCUqulKCQ == 1)
					{
						BIdAEiDINZnNvEkOmrJvkrQDRvt();
					}
					return;
				}
				ftwpGdaCEqoRUOvSphWCUqulKCQ--;
				if (ftwpGdaCEqoRUOvSphWCUqulKCQ < 0)
				{
					ftwpGdaCEqoRUOvSphWCUqulKCQ = 0;
					KlrMixLCNdkvLXrwUvscNyAEzhc();
				}
				if (ftwpGdaCEqoRUOvSphWCUqulKCQ == 0)
				{
					vYOezREwnRfLYQgWFlpkcmSiWXlI();
				}
			}

			public bool GetKey(KeyCode keyCode)
			{
				if (ftwpGdaCEqoRUOvSphWCUqulKCQ == 0)
				{
					eWBtElPvfZEpLjKWHPUxfgcsUnN();
					return false;
				}
				if ((uint)keyCode > (uint)dtNcFIcqHwHaLRfyRiiJQLjKHLp)
				{
					return false;
				}
				return dWBakvwRNaeXHZTwqDturfEhOTq[vikAbZFwYtxLdEQxsaszxofZoxX[(int)keyCode]];
			}

			public void GetKeyValues(bool[] values)
			{
				if (ftwpGdaCEqoRUOvSphWCUqulKCQ == 0)
				{
					eWBtElPvfZEpLjKWHPUxfgcsUnN();
				}
				else if (values != null && values.Length >= 132)
				{
					Array.Copy(dWBakvwRNaeXHZTwqDturfEhOTq, values, 132);
				}
			}

			public void Clear()
			{
				if (nCHYhyJVuOgauyGTGcWtTfTJbDs)
				{
					for (int i = 0; i < 132; i++)
					{
						if (Array.IndexOf(cRZewoBqgbrcOAsuBRXnKNJQiLYA, i) < 0)
						{
							dWBakvwRNaeXHZTwqDturfEhOTq[i] = false;
						}
					}
				}
				else
				{
					Array.Clear(dWBakvwRNaeXHZTwqDturfEhOTq, 0, 132);
				}
			}

			private void FvJdLDQEsLVCuUoWZJSKubtDcA()
			{
				Array.Clear(dWBakvwRNaeXHZTwqDturfEhOTq, 0, 132);
			}

			private void uileOmkJVJtYTHLCMEDfKtvVrfX()
			{
				ftwpGdaCEqoRUOvSphWCUqulKCQ = 0;
				nZTtfeZBpthDaoAvSONdTABGEaM = true;
			}

			private void BIdAEiDINZnNvEkOmrJvkrQDRvt()
			{
			}

			private void vYOezREwnRfLYQgWFlpkcmSiWXlI()
			{
				FvJdLDQEsLVCuUoWZJSKubtDcA();
			}

			private void eWBtElPvfZEpLjKWHPUxfgcsUnN()
			{
				Logger.LogWarning("You are trying to use Keyboard without incrementing the monitor count.", requiredThreadSafety: true);
			}

			private void KlrMixLCNdkvLXrwUvscNyAEzhc()
			{
				Logger.LogWarning("You are decrementing the Keyboard monitor count more than you are incrementing it.", requiredThreadSafety: true);
			}
		}

		[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
		[CustomObfuscation(rename = false)]
		public sealed class Mouse
		{
			private const int MIYoAXxJmUicNKAfsvlLFppMumFk = 7;

			private const int YlTbBOggPtVFjPOpUYhcWgDPoyVS = 4;

			private readonly bool[] XMmeKfLALLiqakhkZdFxAjspFgaC;

			private readonly float[] ohQDQHhCqchGQOcxtOwgeQTpwLrJ;

			private int ftwpGdaCEqoRUOvSphWCUqulKCQ;

			private Vector3 zxuyEWEQSlOxcNvGaCUAxitQKra;

			private bool efGLZGhgHNZEWCEzXsBjneRtede;

			private bool anccSNtpxUBijGUopmPBkFcJvSBD;

			public bool monitoring => ftwpGdaCEqoRUOvSphWCUqulKCQ > 0;

			public Vector3 mousePosition => zxuyEWEQSlOxcNvGaCUAxitQKra;

			public bool mousePresent => efGLZGhgHNZEWCEzXsBjneRtede;

			public Mouse()
			{
				XMmeKfLALLiqakhkZdFxAjspFgaC = new bool[7];
				ohQDQHhCqchGQOcxtOwgeQTpwLrJ = new float[4];
				uileOmkJVJtYTHLCMEDfKtvVrfX();
			}

			public void PostInitialize()
			{
				Update();
			}

			public void Update()
			{
				if (ftwpGdaCEqoRUOvSphWCUqulKCQ == 0)
				{
					return;
				}
				if (!anccSNtpxUBijGUopmPBkFcJvSBD)
				{
					try
					{
						for (int i = 0; i < 7; i++)
						{
							XMmeKfLALLiqakhkZdFxAjspFgaC[i] = Input.GetButton(Consts.mouseButtonUnityNames[i]);
						}
						for (int j = 0; j < 3; j++)
						{
							ohQDQHhCqchGQOcxtOwgeQTpwLrJ[j] = Input.GetAxisRaw(Consts.mouseAxisUnityNames[j]);
						}
					}
					catch
					{
						Logger.LogError("Unity Input Manager mouse entries are missing. Rewired was not installed properly or was canceled during installation, preventing it from installing the necessary Unity Input Manager entries for mouse input or the input manager entries may have been overwritten by another package installed in your project. Mouse input will not function if native mouse input is disabled or is unavailable on this platform.");
						anccSNtpxUBijGUopmPBkFcJvSBD = true;
					}
				}
				ohQDQHhCqchGQOcxtOwgeQTpwLrJ[3] = Input.mouseScrollDelta.x;
				zxuyEWEQSlOxcNvGaCUAxitQKra = Input.mousePosition;
				efGLZGhgHNZEWCEzXsBjneRtede = Input.mousePresent;
			}

			public void Monitor(bool state)
			{
				if (state)
				{
					ftwpGdaCEqoRUOvSphWCUqulKCQ++;
					if (ftwpGdaCEqoRUOvSphWCUqulKCQ == 1)
					{
						BIdAEiDINZnNvEkOmrJvkrQDRvt();
					}
					return;
				}
				ftwpGdaCEqoRUOvSphWCUqulKCQ--;
				if (ftwpGdaCEqoRUOvSphWCUqulKCQ < 0)
				{
					ftwpGdaCEqoRUOvSphWCUqulKCQ = 0;
					KlrMixLCNdkvLXrwUvscNyAEzhc();
				}
				if (ftwpGdaCEqoRUOvSphWCUqulKCQ == 0)
				{
					vYOezREwnRfLYQgWFlpkcmSiWXlI();
				}
			}

			public bool GetButton(int index)
			{
				if (ftwpGdaCEqoRUOvSphWCUqulKCQ == 0)
				{
					sHhvmBNLoOoGpMBaDLAAUJLybNo();
					return false;
				}
				if ((uint)index >= 7u)
				{
					return false;
				}
				return XMmeKfLALLiqakhkZdFxAjspFgaC[index];
			}

			public float GetAxisRaw(int index)
			{
				if (ftwpGdaCEqoRUOvSphWCUqulKCQ == 0)
				{
					sHhvmBNLoOoGpMBaDLAAUJLybNo();
					return 0f;
				}
				if ((uint)index >= 4u)
				{
					return 0f;
				}
				return ohQDQHhCqchGQOcxtOwgeQTpwLrJ[index];
			}

			public void GetButtonValues(bool[] buttons)
			{
				if (ftwpGdaCEqoRUOvSphWCUqulKCQ == 0)
				{
					sHhvmBNLoOoGpMBaDLAAUJLybNo();
				}
				else if (buttons != null && buttons.Length >= 7)
				{
					Array.Copy(XMmeKfLALLiqakhkZdFxAjspFgaC, buttons, 7);
				}
			}

			public void GetAxisRawValues(float[] axes)
			{
				if (ftwpGdaCEqoRUOvSphWCUqulKCQ == 0)
				{
					sHhvmBNLoOoGpMBaDLAAUJLybNo();
				}
				else if (axes != null && axes.Length >= 4)
				{
					Array.Copy(ohQDQHhCqchGQOcxtOwgeQTpwLrJ, axes, 4);
				}
			}

			private void FvJdLDQEsLVCuUoWZJSKubtDcA()
			{
				Array.Clear(XMmeKfLALLiqakhkZdFxAjspFgaC, 0, 7);
				Array.Clear(ohQDQHhCqchGQOcxtOwgeQTpwLrJ, 0, 4);
			}

			private void uileOmkJVJtYTHLCMEDfKtvVrfX()
			{
				ftwpGdaCEqoRUOvSphWCUqulKCQ = 0;
				zxuyEWEQSlOxcNvGaCUAxitQKra = Vector3.zero;
				efGLZGhgHNZEWCEzXsBjneRtede = false;
			}

			private void BIdAEiDINZnNvEkOmrJvkrQDRvt()
			{
			}

			private void vYOezREwnRfLYQgWFlpkcmSiWXlI()
			{
				FvJdLDQEsLVCuUoWZJSKubtDcA();
			}

			private void sHhvmBNLoOoGpMBaDLAAUJLybNo()
			{
				Logger.LogWarning("You are trying to use Mouse without incrementing the monitor count.", requiredThreadSafety: true);
			}

			private void KlrMixLCNdkvLXrwUvscNyAEzhc()
			{
				Logger.LogWarning("You are decrementing the Mouse monitor count more than you are incrementing it.", requiredThreadSafety: true);
			}
		}

		private static Mouse sImClLfAakEpdozudgAtmXPqdcYT;

		private static Keyboard JLibuDkHFfHKRFoJIHKvzgIWAUD;

		public static Mouse mouse => sImClLfAakEpdozudgAtmXPqdcYT ?? (sImClLfAakEpdozudgAtmXPqdcYT = new Mouse());

		public static Keyboard keyboard => JLibuDkHFfHKRFoJIHKvzgIWAUD ?? (JLibuDkHFfHKRFoJIHKvzgIWAUD = new Keyboard());

		public static void Initialize()
		{
		}

		public static void PostInitialize()
		{
			if (JLibuDkHFfHKRFoJIHKvzgIWAUD != null)
			{
				JLibuDkHFfHKRFoJIHKvzgIWAUD.PostInitialize();
			}
			if (sImClLfAakEpdozudgAtmXPqdcYT != null)
			{
				sImClLfAakEpdozudgAtmXPqdcYT.PostInitialize();
			}
		}

		public static void PostInitialize2()
		{
		}

		public static void Deinitialize()
		{
			if (JLibuDkHFfHKRFoJIHKvzgIWAUD != null)
			{
				JLibuDkHFfHKRFoJIHKvzgIWAUD = null;
			}
			if (sImClLfAakEpdozudgAtmXPqdcYT != null)
			{
				sImClLfAakEpdozudgAtmXPqdcYT = null;
			}
		}

		public static void Update()
		{
			if (JLibuDkHFfHKRFoJIHKvzgIWAUD != null)
			{
				JLibuDkHFfHKRFoJIHKvzgIWAUD.enabled = ReInput.controllers.Keyboard.enabled;
				JLibuDkHFfHKRFoJIHKvzgIWAUD.Update();
			}
			if (sImClLfAakEpdozudgAtmXPqdcYT != null)
			{
				sImClLfAakEpdozudgAtmXPqdcYT.Update();
			}
		}
	}
}
