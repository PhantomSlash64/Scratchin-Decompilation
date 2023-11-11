using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
internal struct TJlAwiQapyjSBxkvhUWLcPDrjJf
{
	[FieldOffset(0)]
	public int uRzGXdtvMiFBPVOOvOLRnOmUrvt;

	[FieldOffset(0)]
	public float xpgopNfshxLoWBInXaTotelWpDa;

	public TJlAwiQapyjSBxkvhUWLcPDrjJf(int item)
	{
		xpgopNfshxLoWBInXaTotelWpDa = 0f;
		uRzGXdtvMiFBPVOOvOLRnOmUrvt = item;
	}

	public TJlAwiQapyjSBxkvhUWLcPDrjJf(float item)
	{
		uRzGXdtvMiFBPVOOvOLRnOmUrvt = 0;
		xpgopNfshxLoWBInXaTotelWpDa = item;
	}

	public static implicit operator int(TJlAwiQapyjSBxkvhUWLcPDrjJf obj)
	{
		return obj.uRzGXdtvMiFBPVOOvOLRnOmUrvt;
	}

	public static implicit operator float(TJlAwiQapyjSBxkvhUWLcPDrjJf obj)
	{
		return obj.xpgopNfshxLoWBInXaTotelWpDa;
	}

	public static implicit operator TJlAwiQapyjSBxkvhUWLcPDrjJf(int obj)
	{
		return new TJlAwiQapyjSBxkvhUWLcPDrjJf(obj);
	}

	public static implicit operator TJlAwiQapyjSBxkvhUWLcPDrjJf(float obj)
	{
		return new TJlAwiQapyjSBxkvhUWLcPDrjJf(obj);
	}
}
