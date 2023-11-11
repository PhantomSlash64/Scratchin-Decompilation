using System.Collections.Generic;
using Rewired.Utils;

internal class ifndHOoqZsBPMNDcrjlvbinoYGSv : bAzvngVOSxcOOtKyDFyEOmarEWE
{
	private List<aZUXLSmsXxucFmeHZluozfvyJBI> AKsUUlVuNDLqjLEBrIUtMkySjAr;

	private aZUXLSmsXxucFmeHZluozfvyJBI[] TIBkAbKAIyhMOnnytQxemCbGSUo;

	private bool CzFeMWtjSLOHbinmhUkviAxSQaA;

	public ifndHOoqZsBPMNDcrjlvbinoYGSv()
	{
		AKsUUlVuNDLqjLEBrIUtMkySjAr = new List<aZUXLSmsXxucFmeHZluozfvyJBI>();
	}

	public override void foMDmgEgPXBkJGooEKnwEXmDjvce(aZUXLSmsXxucFmeHZluozfvyJBI P_0)
	{
		AKsUUlVuNDLqjLEBrIUtMkySjAr.Add(P_0);
	}

	public float WbUNdjrqDniDXYdirtEbXVOOxfO(int P_0)
	{
		if (P_0 < 0 || P_0 >= TIBkAbKAIyhMOnnytQxemCbGSUo.Length)
		{
			return 0f;
		}
		return tRSsFucqdzXsNtvLSMlgIVxHHWP(TIBkAbKAIyhMOnnytQxemCbGSUo[P_0].TjnjSTTKCWNlcCrnQklvYrKUrXW);
	}

	public int mUtNLjaBLqqvZxWxRSxbaRfYUFV(int P_0)
	{
		if (P_0 < 0 || P_0 >= TIBkAbKAIyhMOnnytQxemCbGSUo.Length)
		{
			return 0;
		}
		return (int)TIBkAbKAIyhMOnnytQxemCbGSUo[P_0].wHkvcINXMZFnQrgJyfCUawhDiuKT;
	}

	public override void TbZzPbXxsmlGVopxOXvnxFfgbkYH()
	{
		if (!CzFeMWtjSLOHbinmhUkviAxSQaA)
		{
			CzFeMWtjSLOHbinmhUkviAxSQaA = true;
			TIBkAbKAIyhMOnnytQxemCbGSUo = AKsUUlVuNDLqjLEBrIUtMkySjAr.ToArray();
			AKsUUlVuNDLqjLEBrIUtMkySjAr = null;
		}
	}

	private float tRSsFucqdzXsNtvLSMlgIVxHHWP(int P_0)
	{
		if (P_0 == 0)
		{
			return 0f;
		}
		return MathTools.Clamp((float)MathTools.Abs(P_0) / 65535f * (float)MathTools.Sign(P_0), -1f, 1f);
	}
}
