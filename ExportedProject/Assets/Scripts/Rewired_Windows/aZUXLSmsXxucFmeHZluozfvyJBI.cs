using Rewired.Utils;

internal class aZUXLSmsXxucFmeHZluozfvyJBI : mLYdXSCfdvTJPfbFyPlfaQsjeGM
{
	public readonly bool YRoFoNIFaPgwbFXjxCUpUBKgwlvn;

	private int sFRiqehIGYlmwBKXrGKCdACIQIqm;

	private int RDAneNfCsgzgawvRGaJhWmVAdNU;

	private bool VQPHBlyuYsapGscLmHpokyNwzqX;

	public readonly int thuJlvlhMnsYIIZSiqJThmvnlaM;

	public readonly int AAOJeePyEWffIKjyjjqgEyrfRnB;

	public readonly int kPWEDHFgmqJJToVYVfYEaIWJLZPC;

	public readonly int UKQvhvCjtqOuqFAHIJwRCYtEBoK;

	public readonly int XRXTvwcMatjwzJfnOTLaVFCmwAi;

	public readonly int GqvRfsKcLlhTHckYmVKbnKtyIMXe;

	public readonly uint vhoEVpbILbDqkwoWFurNaIIEVXdC;

	public readonly uint iBMXhBsuLkHMhhBWnAoHPanwyjV;

	public readonly int CBSZaktaJVMayiuQLEaCWmTwwFB;

	public uint wHkvcINXMZFnQrgJyfCUawhDiuKT;

	public virtual int TjnjSTTKCWNlcCrnQklvYrKUrXW
	{
		get
		{
			int num = (int)wHkvcINXMZFnQrgJyfCUawhDiuKT;
			if (YRoFoNIFaPgwbFXjxCUpUBKgwlvn && VQPHBlyuYsapGscLmHpokyNwzqX && num > sFRiqehIGYlmwBKXrGKCdACIQIqm)
			{
				num += RDAneNfCsgzgawvRGaJhWmVAdNU;
			}
			if (num == kPWEDHFgmqJJToVYVfYEaIWJLZPC)
			{
				return GqvRfsKcLlhTHckYmVKbnKtyIMXe;
			}
			return (int)eesvOuRKnBEzEDweEIiJhzcCbEB((float)num, (float)thuJlvlhMnsYIIZSiqJThmvnlaM, (float)AAOJeePyEWffIKjyjjqgEyrfRnB, (float)UKQvhvCjtqOuqFAHIJwRCYtEBoK, (float)XRXTvwcMatjwzJfnOTLaVFCmwAi);
		}
	}

	public aZUXLSmsXxucFmeHZluozfvyJBI(byte reportId, ushort usagePage, ushort usage, int dataIndex, int bitSize, int logicalMin, int logicalMax, int physicalMin, int physicalMax, uint units, uint unitsExp, int reportIndex, bool isAxisButton)
		: base(reportId, usagePage, usage, dataIndex, bitSize)
	{
		thuJlvlhMnsYIIZSiqJThmvnlaM = logicalMin;
		AAOJeePyEWffIKjyjjqgEyrfRnB = logicalMax;
		vhoEVpbILbDqkwoWFurNaIIEVXdC = units;
		iBMXhBsuLkHMhhBWnAoHPanwyjV = unitsExp;
		CBSZaktaJVMayiuQLEaCWmTwwFB = reportIndex;
		YRoFoNIFaPgwbFXjxCUpUBKgwlvn = logicalMin < 0 || logicalMax < 0;
		if (logicalMin > logicalMax || logicalMax - logicalMin < 2)
		{
			if (logicalMin == 0 && logicalMax < 0 && physicalMin == 0 && physicalMax < 0)
			{
				YRoFoNIFaPgwbFXjxCUpUBKgwlvn = false;
			}
			if (bitSize > 1 && bitSize < 32)
			{
				int num = 1 << bitSize;
				if (YRoFoNIFaPgwbFXjxCUpUBKgwlvn)
				{
					kPWEDHFgmqJJToVYVfYEaIWJLZPC = 0;
					thuJlvlhMnsYIIZSiqJThmvnlaM = num * -1;
					AAOJeePyEWffIKjyjjqgEyrfRnB = num - 1;
				}
				else
				{
					kPWEDHFgmqJJToVYVfYEaIWJLZPC = num >> 1;
					thuJlvlhMnsYIIZSiqJThmvnlaM = 0;
					AAOJeePyEWffIKjyjjqgEyrfRnB = num - 1;
				}
			}
			else if (YRoFoNIFaPgwbFXjxCUpUBKgwlvn)
			{
				kPWEDHFgmqJJToVYVfYEaIWJLZPC = 0;
				thuJlvlhMnsYIIZSiqJThmvnlaM = -32768;
				AAOJeePyEWffIKjyjjqgEyrfRnB = 32767;
			}
			else
			{
				kPWEDHFgmqJJToVYVfYEaIWJLZPC = 32768;
				thuJlvlhMnsYIIZSiqJThmvnlaM = 0;
				AAOJeePyEWffIKjyjjqgEyrfRnB = 65535;
			}
		}
		else
		{
			kPWEDHFgmqJJToVYVfYEaIWJLZPC = (AAOJeePyEWffIKjyjjqgEyrfRnB - thuJlvlhMnsYIIZSiqJThmvnlaM) / 2;
		}
		GqvRfsKcLlhTHckYmVKbnKtyIMXe = 0;
		UKQvhvCjtqOuqFAHIJwRCYtEBoK = -65535;
		XRXTvwcMatjwzJfnOTLaVFCmwAi = 65535;
		if (YRoFoNIFaPgwbFXjxCUpUBKgwlvn)
		{
			GBwCkYevgaabVRwkiNNSAGPqoLle();
			kPWEDHFgmqJJToVYVfYEaIWJLZPC = logicalMax + 1 + logicalMin;
		}
		if (isAxisButton)
		{
			thuJlvlhMnsYIIZSiqJThmvnlaM = 0;
			kPWEDHFgmqJJToVYVfYEaIWJLZPC = 0;
			UKQvhvCjtqOuqFAHIJwRCYtEBoK = 0;
		}
		xZveeqhZWQBoifJNrEKvhlbeSAk();
	}

	public override void xZveeqhZWQBoifJNrEKvhlbeSAk()
	{
		wHkvcINXMZFnQrgJyfCUawhDiuKT = (uint)kPWEDHFgmqJJToVYVfYEaIWJLZPC;
	}

	private static float eesvOuRKnBEzEDweEIiJhzcCbEB(float P_0, float P_1, float P_2, float P_3, float P_4)
	{
		float num = P_2 - P_1;
		if (MathTools.Approximately(num, 0f))
		{
			return P_3;
		}
		float num2 = P_4 - P_3;
		return (P_0 - P_1) * num2 / num + P_3;
	}

	private static int eesvOuRKnBEzEDweEIiJhzcCbEB(int P_0, int P_1, int P_2, int P_3, int P_4)
	{
		int num = P_2 - P_1;
		long num2;
		if (num == 0)
		{
			num2 = P_3;
		}
		else
		{
			int num3 = P_4 - P_3;
			num2 = (long)(P_0 - P_1) * (long)num3 / num + P_3;
		}
		return (int)num2;
	}

	private void GBwCkYevgaabVRwkiNNSAGPqoLle()
	{
		if (DiOnkDzyCCjYexUVACgXoYdAmtE > 0 && DiOnkDzyCCjYexUVACgXoYdAmtE < 32)
		{
			int num = 1 << DiOnkDzyCCjYexUVACgXoYdAmtE;
			int num2 = num >> 1;
			sFRiqehIGYlmwBKXrGKCdACIQIqm = num2 - 1;
			RDAneNfCsgzgawvRGaJhWmVAdNU = num * -1;
			VQPHBlyuYsapGscLmHpokyNwzqX = true;
		}
	}
}
