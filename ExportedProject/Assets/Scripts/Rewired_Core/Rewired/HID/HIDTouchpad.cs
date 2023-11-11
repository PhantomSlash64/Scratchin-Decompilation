using System;
using System.Collections.Generic;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;

namespace Rewired.HID
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class HIDTouchpad : HIDControllerElement
	{
		[CustomObfuscation(rename = false)]
		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		internal class TouchpadInfo
		{
			public int maxTouches;

			public int minX;

			public int maxX;

			public int minY;

			public int maxY;

			public bool invertY;

			public bool reverseY;

			public TouchpadInfo(int maxTouches, int minX, int maxX, int minY, int maxY, bool invertY, bool reverseY)
			{
				this.maxTouches = maxTouches;
				this.minX = minX;
				this.maxX = maxX;
				this.minY = minY;
				this.maxY = maxY;
				this.invertY = invertY;
				this.reverseY = reverseY;
			}

			public void CalculateTouch(ref TouchData data)
			{
				int num = (reverseY ? (maxY - data.positionRawY) : data.positionRawY);
				data.positionX = MathTools.ValueInNewRange(data.positionRawX, minX, maxX, 0f, 1f);
				data.positionY = MathTools.ValueInNewRange(num, minY, maxY, 0f, 1f);
				data.positionAbsX = data.positionRawX;
				data.positionAbsY = num;
				if (data.positionAbsX > maxX)
				{
					data.positionAbsX = maxX;
				}
				if (data.positionAbsY > maxY)
				{
					data.positionAbsY = maxY;
				}
				if (data.positionAbsX < minX)
				{
					data.positionAbsX = minX;
				}
				if (data.positionAbsY < minY)
				{
					data.positionAbsY = minY;
				}
				if (invertY)
				{
					data.positionY *= -1f;
					data.positionAbsY *= -1;
				}
			}
		}

		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		[CustomObfuscation(rename = false)]
		internal struct TouchData
		{
			public int touchId;

			public float timeStamp;

			public bool isTouching;

			public int positionRawX;

			public int positionRawY;

			public float positionX;

			public float positionY;

			public int positionAbsX;

			public int positionAbsY;

			public void Clear()
			{
				touchId = -1;
				timeStamp = 0f;
				isTouching = false;
				positionRawX = 0;
				positionRawY = 0;
				positionX = 0f;
				positionY = 0f;
				positionAbsX = 0;
				positionAbsY = 0;
			}
		}

		private TouchpadInfo yRaNHDsqIuRYqAbeIavmvLvRPES;

		private Queue<TouchData> mERiILpMUCCvDzHSLfnneFxLoYp;

		private TouchData[] NqbjuhmNjCgEEJDgZcvpcKtiAHE;

		private Action<NativeBuffer, TouchData[]> rxwfiFIqTEbnPtPaGotkCeUKiRwT;

		public TouchData[] values;

		public HIDTouchpad(byte reportId, TouchpadInfo info, HIDInfo hidInfo, Action<NativeBuffer, TouchData[]> calcValueDelegate)
			: base(reportId, hidInfo)
		{
			yRaNHDsqIuRYqAbeIavmvLvRPES = info;
			rxwfiFIqTEbnPtPaGotkCeUKiRwT = calcValueDelegate;
			mERiILpMUCCvDzHSLfnneFxLoYp = new Queue<TouchData>(10);
			NqbjuhmNjCgEEJDgZcvpcKtiAHE = new TouchData[info.maxTouches];
			values = new TouchData[info.maxTouches];
			for (int i = 0; i < values.Length; i++)
			{
				values[i].Clear();
			}
		}

		public override void UpdateValue(NativeBuffer inputReport, double timestamp)
		{
			if (rxwfiFIqTEbnPtPaGotkCeUKiRwT == null)
			{
				return;
			}
			rxwfiFIqTEbnPtPaGotkCeUKiRwT(inputReport, NqbjuhmNjCgEEJDgZcvpcKtiAHE);
			lock (mERiILpMUCCvDzHSLfnneFxLoYp)
			{
				for (int i = 0; i < yRaNHDsqIuRYqAbeIavmvLvRPES.maxTouches; i++)
				{
					mERiILpMUCCvDzHSLfnneFxLoYp.Enqueue(NqbjuhmNjCgEEJDgZcvpcKtiAHE[i]);
				}
			}
			ProcessQueue();
		}

		public void ProcessQueue()
		{
			int num = 0;
			for (int i = 0; i < values.Length; i++)
			{
				values[i].Clear();
			}
			lock (mERiILpMUCCvDzHSLfnneFxLoYp)
			{
				int num2 = mERiILpMUCCvDzHSLfnneFxLoYp.Count;
				while (num2 > 0)
				{
					TouchData data = mERiILpMUCCvDzHSLfnneFxLoYp.Dequeue();
					num2--;
					yRaNHDsqIuRYqAbeIavmvLvRPES.CalculateTouch(ref data);
					values[num] = data;
					num++;
				}
			}
		}

		public bool IsTouching(int touchId)
		{
			for (int i = 0; i < values.Length; i++)
			{
				if (values[i].isTouching && values[i].touchId == touchId)
				{
					return true;
				}
			}
			return false;
		}
	}
}
