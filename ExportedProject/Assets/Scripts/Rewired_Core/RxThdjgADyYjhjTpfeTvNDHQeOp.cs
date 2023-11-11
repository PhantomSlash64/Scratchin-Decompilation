using UnityEngine;

internal static class RxThdjgADyYjhjTpfeTvNDHQeOp
{
	private static int vzqhGrAjYhJZTCPUvENTVXZsSdI;

	private static int dNOdUInaodFiUtCCqNVAVCVTTGl;

	private static double[] uwLeJIPsUdKaxPFXxxruWMtfGLbI;

	private static int JuKDhABQRjstEJkcmQfHraBKRGM;

	private static double yiMCjixAVIslBiNtbxAgWFRNkBX;

	private static int MpqSxcddYlFbbuXosLjVXmDtoZD;

	public static double VjCLpcaGSrBneDUzzNOPDanTCcVf => yiMCjixAVIslBiNtbxAgWFRNkBX;

	public static int zfnCFUzNKjMgKIoNHgeTOQjAOBH
	{
		get
		{
			return vzqhGrAjYhJZTCPUvENTVXZsSdI;
		}
		set
		{
			if (value <= 0)
			{
				value = 1;
			}
			if (value != vzqhGrAjYhJZTCPUvENTVXZsSdI)
			{
				vzqhGrAjYhJZTCPUvENTVXZsSdI = value;
				skeOSBSqSPGPnIZySfEhxuCHbTXM();
			}
		}
	}

	static RxThdjgADyYjhjTpfeTvNDHQeOp()
	{
		vzqhGrAjYhJZTCPUvENTVXZsSdI = 30;
		skeOSBSqSPGPnIZySfEhxuCHbTXM();
	}

	public static void mtiNfGzpXHszOwiOIAVYQuMZclV()
	{
		int frameCount = Time.frameCount;
		if (MpqSxcddYlFbbuXosLjVXmDtoZD < frameCount)
		{
			uwLeJIPsUdKaxPFXxxruWMtfGLbI[dNOdUInaodFiUtCCqNVAVCVTTGl] = Time.deltaTime;
			if (JuKDhABQRjstEJkcmQfHraBKRGM < vzqhGrAjYhJZTCPUvENTVXZsSdI)
			{
				JuKDhABQRjstEJkcmQfHraBKRGM++;
			}
			double num = 0.0;
			for (int i = 0; i < JuKDhABQRjstEJkcmQfHraBKRGM; i++)
			{
				num += uwLeJIPsUdKaxPFXxxruWMtfGLbI[i];
			}
			yiMCjixAVIslBiNtbxAgWFRNkBX = num / (double)JuKDhABQRjstEJkcmQfHraBKRGM;
			dNOdUInaodFiUtCCqNVAVCVTTGl++;
			if (dNOdUInaodFiUtCCqNVAVCVTTGl >= vzqhGrAjYhJZTCPUvENTVXZsSdI)
			{
				dNOdUInaodFiUtCCqNVAVCVTTGl = 0;
			}
			MpqSxcddYlFbbuXosLjVXmDtoZD = frameCount;
		}
	}

	public static void skeOSBSqSPGPnIZySfEhxuCHbTXM()
	{
		if (uwLeJIPsUdKaxPFXxxruWMtfGLbI == null || uwLeJIPsUdKaxPFXxxruWMtfGLbI.Length != vzqhGrAjYhJZTCPUvENTVXZsSdI)
		{
			uwLeJIPsUdKaxPFXxxruWMtfGLbI = new double[vzqhGrAjYhJZTCPUvENTVXZsSdI];
		}
		JuKDhABQRjstEJkcmQfHraBKRGM = 0;
		dNOdUInaodFiUtCCqNVAVCVTTGl = 0;
		MpqSxcddYlFbbuXosLjVXmDtoZD = 0;
	}
}
