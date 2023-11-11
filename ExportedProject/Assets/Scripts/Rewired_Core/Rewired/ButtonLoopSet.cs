using System;
using Rewired.Config;
using Rewired.Utils;

namespace Rewired
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	[CustomObfuscation(rename = false)]
	internal class ButtonLoopSet : UpdateLoopDataSet<ButtonLoopSet.ButtonData>
	{
		[CustomObfuscation(rename = false)]
		[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
		public class ButtonData
		{
			public readonly UpdateLoopType updateLoop;

			public readonly bool[] values;

			public readonly bool[] wasTrueThisFrame;

			private bool[] WZImAmkKJOPqmAhNvBGTSqjYxpo;

			private int LCpiwNbmoAmDaPeaucVTWXBzllI;

			private readonly bool[] yoBPUxrQiKQqpSGNyFUsFRcwIsw;

			private readonly bool[] PyySlQeXFmXxFbWXZLbGsaGZDCT;

			public bool[] effectiveValue
			{
				get
				{
					if (updateLoop == UpdateLoopType.FixedUpdate)
					{
						jygDiHgbbzzxjNgNSTGkzXasQeZ();
					}
					return WZImAmkKJOPqmAhNvBGTSqjYxpo;
				}
			}

			public ButtonData(int count, UpdateLoopType updateLoop)
			{
				this.updateLoop = updateLoop;
				values = new bool[count];
				PyySlQeXFmXxFbWXZLbGsaGZDCT = new bool[count];
				wasTrueThisFrame = new bool[count];
				yoBPUxrQiKQqpSGNyFUsFRcwIsw = new bool[count];
				WZImAmkKJOPqmAhNvBGTSqjYxpo = new bool[count];
				LCpiwNbmoAmDaPeaucVTWXBzllI = ReInput.timeScalePauseChangedCount;
			}

			public void SetValue(int index, bool value)
			{
				if (updateLoop == UpdateLoopType.FixedUpdate)
				{
					jygDiHgbbzzxjNgNSTGkzXasQeZ();
				}
				values[index] = value;
				if (value)
				{
					wasTrueThisFrame[index] = true;
					if (!PyySlQeXFmXxFbWXZLbGsaGZDCT[index])
					{
						yoBPUxrQiKQqpSGNyFUsFRcwIsw[index] = true;
					}
				}
				WZImAmkKJOPqmAhNvBGTSqjYxpo[index] = value | yoBPUxrQiKQqpSGNyFUsFRcwIsw[index];
				PyySlQeXFmXxFbWXZLbGsaGZDCT[index] = value;
			}

			public void ClearWasTrueThisFrame()
			{
				for (int i = 0; i < values.Length; i++)
				{
					wasTrueThisFrame[i] = false;
					yoBPUxrQiKQqpSGNyFUsFRcwIsw[i] = false;
					WZImAmkKJOPqmAhNvBGTSqjYxpo[i] = values[i];
				}
			}

			public void Clear()
			{
				Array.Clear(values, 0, values.Length);
				Array.Clear(PyySlQeXFmXxFbWXZLbGsaGZDCT, 0, values.Length);
				Array.Clear(wasTrueThisFrame, 0, wasTrueThisFrame.Length);
				Array.Clear(yoBPUxrQiKQqpSGNyFUsFRcwIsw, 0, yoBPUxrQiKQqpSGNyFUsFRcwIsw.Length);
				Array.Clear(WZImAmkKJOPqmAhNvBGTSqjYxpo, 0, WZImAmkKJOPqmAhNvBGTSqjYxpo.Length);
				LCpiwNbmoAmDaPeaucVTWXBzllI = ReInput.timeScalePauseChangedCount;
			}

			public void Import(ButtonData source)
			{
				if (source != null)
				{
					int num = MathTools.Min(values.Length, source.values.Length);
					for (int i = 0; i < num; i++)
					{
						values[i] = source.values[i];
						PyySlQeXFmXxFbWXZLbGsaGZDCT[i] = source.PyySlQeXFmXxFbWXZLbGsaGZDCT[i];
						wasTrueThisFrame[i] = source.wasTrueThisFrame[i];
						yoBPUxrQiKQqpSGNyFUsFRcwIsw[i] = source.yoBPUxrQiKQqpSGNyFUsFRcwIsw[i];
						WZImAmkKJOPqmAhNvBGTSqjYxpo[i] = source.WZImAmkKJOPqmAhNvBGTSqjYxpo[i];
						LCpiwNbmoAmDaPeaucVTWXBzllI = source.LCpiwNbmoAmDaPeaucVTWXBzllI;
					}
				}
			}

			private void jygDiHgbbzzxjNgNSTGkzXasQeZ()
			{
				if (ReInput.timeScalePauseChangedCount != LCpiwNbmoAmDaPeaucVTWXBzllI)
				{
					ClearWasTrueThisFrame();
					LCpiwNbmoAmDaPeaucVTWXBzllI = ReInput.timeScalePauseChangedCount;
				}
			}
		}

		public readonly int buttonCount;

		public ButtonLoopSet(UpdateLoopSetting updateLoops, int buttonCount)
			: base(updateLoops)
		{
			this.buttonCount = buttonCount;
			for (int i = 0; i < base.Count; i++)
			{
				base[i] = new ButtonData(buttonCount, GetUpdateLoopType(i));
			}
		}

		public void SetValue(int index, bool value, double timestamp)
		{
			int count = base.Count;
			for (int i = 0; i < count; i++)
			{
				base[i].SetValue(index, value);
			}
		}

		public void Clear()
		{
			int count = base.Count;
			for (int i = 0; i < count; i++)
			{
				base[i].Clear();
			}
		}

		public void Import(ButtonLoopSet set)
		{
			if (set == null)
			{
				throw new ArgumentNullException("set");
			}
			if (set.buttonCount != buttonCount)
			{
				throw new Exception("Cannot import from a set with a different button count.");
			}
			for (int i = 0; i < base.Count; i++)
			{
				base[i].Import(set[i]);
			}
		}
	}
}
