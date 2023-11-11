using System;
using Rewired;
using Rewired.Platforms;
using Rewired.Utils;

internal class jMKaPgLzGvaHTAThgsaZcxGXSyF
{
	public int QIzoBncePxUUbbqEfLpERqPqJaL;

	public int mwTxXrbbhfRpdwAUSEMlptKkOji;

	public bool PxBLFWvQDgtBnhXjHtzZfVMPnUN;

	public string YnFDimKfsuivjwaGSApbpFmhYUi;

	public string cwXKEfmJwgVuncJVtimNSLaSlwa;

	public Guid QILzOfqCHZbqrubdcbPjBcElyHOf;

	public Guid QLFuWFmTJTboLBFWpXydEiPkQqb;

	public int aumNItRblDdXZicbRkrPApteCjR;

	public int beRmxTPYgeEljczGnIuTQeGMXoR;

	public int EAGWFmBKpkybcagmIjuwLbeGjsr;

	public int StdYsitlniAVVqdtCruyjpWnHBB;

	public PidVid bxkXdlCJVCfVuquTGeTMqKnvsia;

	public Guid kEQkcrKZuzTYwGDFBLjiTrWERMu;

	public int vPXJpqINRqPFfbvxiOgRleAPgZX;

	public int HobfqJsoBexlFijbsSVcDQthfKhI;

	public void UcMFLlIeEVgVHdWycYuHxpkWVTYD()
	{
		byte[] value = QILzOfqCHZbqrubdcbPjBcElyHOf.ToByteArray();
		int startIndex;
		int startIndex2;
		switch (UnityTools.effectivePlatform)
		{
		case Platform.Windows:
			startIndex = 0;
			startIndex2 = 2;
			break;
		case Platform.OSX:
			startIndex = 0;
			startIndex2 = 8;
			break;
		case Platform.Linux:
			startIndex = 4;
			startIndex2 = 8;
			break;
		default:
			throw new NotImplementedException();
		}
		vPXJpqINRqPFfbvxiOgRleAPgZX = BitConverter.ToUInt16(value, startIndex);
		HobfqJsoBexlFijbsSVcDQthfKhI = BitConverter.ToUInt16(value, startIndex2);
		bxkXdlCJVCfVuquTGeTMqKnvsia = new PidVid((ushort)HobfqJsoBexlFijbsSVcDQthfKhI, (ushort)vPXJpqINRqPFfbvxiOgRleAPgZX);
		kEQkcrKZuzTYwGDFBLjiTrWERMu = MiscTools.CreateGuidHashSHA1(YnFDimKfsuivjwaGSApbpFmhYUi + bxkXdlCJVCfVuquTGeTMqKnvsia.ToString() + mwTxXrbbhfRpdwAUSEMlptKkOji);
		if (string.IsNullOrEmpty(cwXKEfmJwgVuncJVtimNSLaSlwa))
		{
			cwXKEfmJwgVuncJVtimNSLaSlwa = YnFDimKfsuivjwaGSApbpFmhYUi;
		}
	}

	public override string ToString()
	{
		string text = "";
		object obj = text;
		text = string.Concat(obj, "joystickIndex = ", QIzoBncePxUUbbqEfLpERqPqJaL, "\n");
		object obj2 = text;
		text = string.Concat(obj2, "joystickId = ", mwTxXrbbhfRpdwAUSEMlptKkOji, "\n");
		object obj3 = text;
		text = string.Concat(obj3, "isGameController = ", PxBLFWvQDgtBnhXjHtzZfVMPnUN, "\n");
		text = text + "hardwareName = " + YnFDimKfsuivjwaGSApbpFmhYUi + "\n";
		text = text + "friendlyName = " + cwXKEfmJwgVuncJVtimNSLaSlwa + "\n";
		object obj4 = text;
		text = string.Concat(obj4, "sdlJoystickGuid = ", QILzOfqCHZbqrubdcbPjBcElyHOf, "\n");
		object obj5 = text;
		text = string.Concat(obj5, "sdlDeviceGuid = ", QLFuWFmTJTboLBFWpXydEiPkQqb, "\n");
		object obj6 = text;
		text = string.Concat(obj6, "buttonCount = ", aumNItRblDdXZicbRkrPApteCjR, "\n");
		object obj7 = text;
		text = string.Concat(obj7, "axisCount = ", beRmxTPYgeEljczGnIuTQeGMXoR, "\n");
		object obj8 = text;
		text = string.Concat(obj8, "hatCount = ", EAGWFmBKpkybcagmIjuwLbeGjsr, "\n");
		object obj9 = text;
		text = string.Concat(obj9, "ballCount = ", StdYsitlniAVVqdtCruyjpWnHBB, "\n");
		object obj10 = text;
		text = string.Concat(obj10, "pidVid = ", bxkXdlCJVCfVuquTGeTMqKnvsia, "\n");
		object obj11 = text;
		text = string.Concat(obj11, "instanceGuid = ", kEQkcrKZuzTYwGDFBLjiTrWERMu, "\n");
		object obj12 = text;
		text = string.Concat(obj12, "vendorId = ", vPXJpqINRqPFfbvxiOgRleAPgZX, "\n");
		object obj13 = text;
		return string.Concat(obj13, "productId = ", HobfqJsoBexlFijbsSVcDQthfKhI, "\n");
	}
}
