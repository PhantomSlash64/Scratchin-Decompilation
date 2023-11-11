using Rewired.Utils;

internal class MxfGstFPtBHbpfUjEEFJNYMfrDBl : mLYdXSCfdvTJPfbFyPlfaQsjeGM
{
	public readonly int thuJlvlhMnsYIIZSiqJThmvnlaM;

	public readonly int AAOJeePyEWffIKjyjjqgEyrfRnB;

	public readonly int kPWEDHFgmqJJToVYVfYEaIWJLZPC;

	public readonly int UKQvhvCjtqOuqFAHIJwRCYtEBoK;

	public readonly int XRXTvwcMatjwzJfnOTLaVFCmwAi;

	public readonly int GqvRfsKcLlhTHckYmVKbnKtyIMXe;

	public readonly uint vhoEVpbILbDqkwoWFurNaIIEVXdC;

	public readonly uint HjlFJJkVtoJKoSfaaUzCaroEqsnD;

	public readonly int CBSZaktaJVMayiuQLEaCWmTwwFB;

	private readonly int DpwmwKkJFzlqEjDLQJJPhcxXFLX;

	public uint wHkvcINXMZFnQrgJyfCUawhDiuKT;

	public int TjnjSTTKCWNlcCrnQklvYrKUrXW
	{
		get
		{
			if (wHkvcINXMZFnQrgJyfCUawhDiuKT < thuJlvlhMnsYIIZSiqJThmvnlaM || wHkvcINXMZFnQrgJyfCUawhDiuKT > AAOJeePyEWffIKjyjjqgEyrfRnB)
			{
				return -1;
			}
			int num = (int)((wHkvcINXMZFnQrgJyfCUawhDiuKT - thuJlvlhMnsYIIZSiqJThmvnlaM) / DpwmwKkJFzlqEjDLQJJPhcxXFLX * 4500);
			if (num >= 36000)
			{
				num = 0;
			}
			return num;
		}
	}

	public MxfGstFPtBHbpfUjEEFJNYMfrDBl(byte reportId, ushort usagePage, ushort usage, int dataIndex, int bitSize, int logicalMin, int logicalMax, int physicalMin, int physicalMax, uint units, uint unitsExp, int reportIndex)
		: base(reportId, usagePage, usage, dataIndex, bitSize)
	{
		thuJlvlhMnsYIIZSiqJThmvnlaM = logicalMin;
		AAOJeePyEWffIKjyjjqgEyrfRnB = logicalMax;
		vhoEVpbILbDqkwoWFurNaIIEVXdC = units;
		HjlFJJkVtoJKoSfaaUzCaroEqsnD = unitsExp;
		CBSZaktaJVMayiuQLEaCWmTwwFB = reportIndex;
		kPWEDHFgmqJJToVYVfYEaIWJLZPC = logicalMin - 1;
		if (kPWEDHFgmqJJToVYVfYEaIWJLZPC < 0)
		{
			kPWEDHFgmqJJToVYVfYEaIWJLZPC = logicalMax + 1;
		}
		GqvRfsKcLlhTHckYmVKbnKtyIMXe = -1;
		int num = logicalMax - logicalMin + 1;
		DpwmwKkJFzlqEjDLQJJPhcxXFLX = MathTools.Clamp(num / 8, 1, int.MaxValue);
		xZveeqhZWQBoifJNrEKvhlbeSAk();
	}

	public override void xZveeqhZWQBoifJNrEKvhlbeSAk()
	{
		wHkvcINXMZFnQrgJyfCUawhDiuKT = (uint)kPWEDHFgmqJJToVYVfYEaIWJLZPC;
	}
}
