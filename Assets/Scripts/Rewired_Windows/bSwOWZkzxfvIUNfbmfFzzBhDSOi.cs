using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 4)]
[DefaultMember("Item")]
internal struct bSwOWZkzxfvIUNfbmfFzzBhDSOi : IEquatable<bSwOWZkzxfvIUNfbmfFzzBhDSOi>, IFormattable
{
	public static readonly int FTFnRnACjJSaBVoElVrLcditcJX = Marshal.SizeOf(typeof(bSwOWZkzxfvIUNfbmfFzzBhDSOi));

	public static readonly bSwOWZkzxfvIUNfbmfFzzBhDSOi rgExYoaILOXxuNGUtChhrvFJQlU = default(bSwOWZkzxfvIUNfbmfFzzBhDSOi);

	public static readonly bSwOWZkzxfvIUNfbmfFzzBhDSOi OzRYinxVxXTywBxriYRUnZpdlyp = new bSwOWZkzxfvIUNfbmfFzzBhDSOi(1f, 0f);

	public static readonly bSwOWZkzxfvIUNfbmfFzzBhDSOi fGNpHLIpdFxEUUuUWPXEiMEJQgI = new bSwOWZkzxfvIUNfbmfFzzBhDSOi(0f, 1f);

	public static readonly bSwOWZkzxfvIUNfbmfFzzBhDSOi FURVdqWlDUEwTChYSzlJPAcYNKGa = new bSwOWZkzxfvIUNfbmfFzzBhDSOi(1f, 1f);

	public float xpumVntKTYPdUAcEeqwWhsPgirN;

	public float RTwQzyWgdmiDfVtyeEaNgdMceZg;

	public bool fduRpsPKVbdppGrcAFUDXuDUBSV => PvTDvuyTEvcojHCkUkFKczBErxKE.RFIYmnKMAtHndKGUMEjAnkJtELlX(xpumVntKTYPdUAcEeqwWhsPgirN * xpumVntKTYPdUAcEeqwWhsPgirN + RTwQzyWgdmiDfVtyeEaNgdMceZg * RTwQzyWgdmiDfVtyeEaNgdMceZg);

	public bool FjhSjATXPgHVADnRhwechHIilJe
	{
		get
		{
			if (xpumVntKTYPdUAcEeqwWhsPgirN == 0f)
			{
				return RTwQzyWgdmiDfVtyeEaNgdMceZg == 0f;
			}
			return false;
		}
	}

	public float GXwEwVpxCBxQxjtzWDWsvqrEoza
	{
		get
		{
			return index switch
			{
				0 => xpumVntKTYPdUAcEeqwWhsPgirN, 
				1 => RTwQzyWgdmiDfVtyeEaNgdMceZg, 
				_ => throw new ArgumentOutOfRangeException("index", "Indices for Vector2 run from 0 to 1, inclusive."), 
			};
		}
		set
		{
			switch (index)
			{
			case 0:
				xpumVntKTYPdUAcEeqwWhsPgirN = value;
				break;
			case 1:
				RTwQzyWgdmiDfVtyeEaNgdMceZg = value;
				break;
			default:
				throw new ArgumentOutOfRangeException("index", "Indices for Vector2 run from 0 to 1, inclusive.");
			}
		}
	}

	public bSwOWZkzxfvIUNfbmfFzzBhDSOi(float value)
	{
		xpumVntKTYPdUAcEeqwWhsPgirN = value;
		RTwQzyWgdmiDfVtyeEaNgdMceZg = value;
	}

	public bSwOWZkzxfvIUNfbmfFzzBhDSOi(float x, float y)
	{
		xpumVntKTYPdUAcEeqwWhsPgirN = x;
		RTwQzyWgdmiDfVtyeEaNgdMceZg = y;
	}

	public bSwOWZkzxfvIUNfbmfFzzBhDSOi(float[] values)
	{
		if (values == null)
		{
			throw new ArgumentNullException("values");
		}
		if (values.Length != 2)
		{
			throw new ArgumentOutOfRangeException("values", "There must be two and only two input values for Vector2.");
		}
		xpumVntKTYPdUAcEeqwWhsPgirN = values[0];
		RTwQzyWgdmiDfVtyeEaNgdMceZg = values[1];
	}

	public float MaluonABdyiloPnZCFkVkPsyOJnR()
	{
		return (float)Math.Sqrt(xpumVntKTYPdUAcEeqwWhsPgirN * xpumVntKTYPdUAcEeqwWhsPgirN + RTwQzyWgdmiDfVtyeEaNgdMceZg * RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public float GemwLbscNpNAwyIMTpgUfrSYXjt()
	{
		return xpumVntKTYPdUAcEeqwWhsPgirN * xpumVntKTYPdUAcEeqwWhsPgirN + RTwQzyWgdmiDfVtyeEaNgdMceZg * RTwQzyWgdmiDfVtyeEaNgdMceZg;
	}

	public void YaMiFtGaKdMLfCaBzotoQMbKGHv()
	{
		float num = MaluonABdyiloPnZCFkVkPsyOJnR();
		if (!PvTDvuyTEvcojHCkUkFKczBErxKE.FjhSjATXPgHVADnRhwechHIilJe(num))
		{
			float num2 = 1f / num;
			xpumVntKTYPdUAcEeqwWhsPgirN *= num2;
			RTwQzyWgdmiDfVtyeEaNgdMceZg *= num2;
		}
	}

	public float[] tezKlAdhfDCtvCNbrhpfZpIApSGv()
	{
		return new float[2] { xpumVntKTYPdUAcEeqwWhsPgirN, RTwQzyWgdmiDfVtyeEaNgdMceZg };
	}

	public static void awMsSJTFCLycCsTVXgMchYNLLXw(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2)
	{
		P_2 = new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0.xpumVntKTYPdUAcEeqwWhsPgirN + P_1.xpumVntKTYPdUAcEeqwWhsPgirN, P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg + P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi awMsSJTFCLycCsTVXgMchYNLLXw(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0.xpumVntKTYPdUAcEeqwWhsPgirN + P_1.xpumVntKTYPdUAcEeqwWhsPgirN, P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg + P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static void awMsSJTFCLycCsTVXgMchYNLLXw(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, ref float P_1, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2)
	{
		P_2 = new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0.xpumVntKTYPdUAcEeqwWhsPgirN + P_1, P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg + P_1);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi awMsSJTFCLycCsTVXgMchYNLLXw(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, float P_1)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0.xpumVntKTYPdUAcEeqwWhsPgirN + P_1, P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg + P_1);
	}

	public static void RfeVJxRAhmzvJoZtHrSILbpRnQV(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2)
	{
		P_2 = new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0.xpumVntKTYPdUAcEeqwWhsPgirN - P_1.xpumVntKTYPdUAcEeqwWhsPgirN, P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg - P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi RfeVJxRAhmzvJoZtHrSILbpRnQV(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0.xpumVntKTYPdUAcEeqwWhsPgirN - P_1.xpumVntKTYPdUAcEeqwWhsPgirN, P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg - P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static void RfeVJxRAhmzvJoZtHrSILbpRnQV(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, ref float P_1, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2)
	{
		P_2 = new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0.xpumVntKTYPdUAcEeqwWhsPgirN - P_1, P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg - P_1);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi RfeVJxRAhmzvJoZtHrSILbpRnQV(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, float P_1)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0.xpumVntKTYPdUAcEeqwWhsPgirN - P_1, P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg - P_1);
	}

	public static void RfeVJxRAhmzvJoZtHrSILbpRnQV(ref float P_0, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2)
	{
		P_2 = new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0 - P_1.xpumVntKTYPdUAcEeqwWhsPgirN, P_0 - P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi RfeVJxRAhmzvJoZtHrSILbpRnQV(float P_0, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0 - P_1.xpumVntKTYPdUAcEeqwWhsPgirN, P_0 - P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static void hiOxCLoPKoHWgsCePmKfichSyKS(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, float P_1, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2)
	{
		P_2 = new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0.xpumVntKTYPdUAcEeqwWhsPgirN * P_1, P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg * P_1);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi hiOxCLoPKoHWgsCePmKfichSyKS(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, float P_1)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0.xpumVntKTYPdUAcEeqwWhsPgirN * P_1, P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg * P_1);
	}

	public static void hiOxCLoPKoHWgsCePmKfichSyKS(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2)
	{
		P_2 = new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0.xpumVntKTYPdUAcEeqwWhsPgirN * P_1.xpumVntKTYPdUAcEeqwWhsPgirN, P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg * P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi hiOxCLoPKoHWgsCePmKfichSyKS(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0.xpumVntKTYPdUAcEeqwWhsPgirN * P_1.xpumVntKTYPdUAcEeqwWhsPgirN, P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg * P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static void zbnduCsouGqSPbiSBGtmGuStPDlt(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, float P_1, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2)
	{
		P_2 = new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0.xpumVntKTYPdUAcEeqwWhsPgirN / P_1, P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg / P_1);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi zbnduCsouGqSPbiSBGtmGuStPDlt(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, float P_1)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0.xpumVntKTYPdUAcEeqwWhsPgirN / P_1, P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg / P_1);
	}

	public static void zbnduCsouGqSPbiSBGtmGuStPDlt(float P_0, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2)
	{
		P_2 = new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0 / P_1.xpumVntKTYPdUAcEeqwWhsPgirN, P_0 / P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi zbnduCsouGqSPbiSBGtmGuStPDlt(float P_0, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0 / P_1.xpumVntKTYPdUAcEeqwWhsPgirN, P_0 / P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static void QGcdlYXoLNFNZEAngkgYWpLXyKjp(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1)
	{
		P_1 = new bSwOWZkzxfvIUNfbmfFzzBhDSOi(0f - P_0.xpumVntKTYPdUAcEeqwWhsPgirN, 0f - P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi QGcdlYXoLNFNZEAngkgYWpLXyKjp(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(0f - P_0.xpumVntKTYPdUAcEeqwWhsPgirN, 0f - P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static void mueBXJiezyLLcpnGIIoZWtfSCXF(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2, float P_3, float P_4, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_5)
	{
		P_5 = new bSwOWZkzxfvIUNfbmfFzzBhDSOi(P_0.xpumVntKTYPdUAcEeqwWhsPgirN + P_3 * (P_1.xpumVntKTYPdUAcEeqwWhsPgirN - P_0.xpumVntKTYPdUAcEeqwWhsPgirN) + P_4 * (P_2.xpumVntKTYPdUAcEeqwWhsPgirN - P_0.xpumVntKTYPdUAcEeqwWhsPgirN), P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg + P_3 * (P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg - P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg) + P_4 * (P_2.RTwQzyWgdmiDfVtyeEaNgdMceZg - P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg));
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi mueBXJiezyLLcpnGIIoZWtfSCXF(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2, float P_3, float P_4)
	{
		mueBXJiezyLLcpnGIIoZWtfSCXF(ref P_0, ref P_1, ref P_2, P_3, P_4, out var result);
		return result;
	}

	public static void kXrOdtMyQfTEwowXBikPcAqfELw(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_3)
	{
		float num = P_0.xpumVntKTYPdUAcEeqwWhsPgirN;
		num = ((num > P_2.xpumVntKTYPdUAcEeqwWhsPgirN) ? P_2.xpumVntKTYPdUAcEeqwWhsPgirN : num);
		num = ((num < P_1.xpumVntKTYPdUAcEeqwWhsPgirN) ? P_1.xpumVntKTYPdUAcEeqwWhsPgirN : num);
		float rTwQzyWgdmiDfVtyeEaNgdMceZg = P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg;
		rTwQzyWgdmiDfVtyeEaNgdMceZg = ((rTwQzyWgdmiDfVtyeEaNgdMceZg > P_2.RTwQzyWgdmiDfVtyeEaNgdMceZg) ? P_2.RTwQzyWgdmiDfVtyeEaNgdMceZg : rTwQzyWgdmiDfVtyeEaNgdMceZg);
		rTwQzyWgdmiDfVtyeEaNgdMceZg = ((rTwQzyWgdmiDfVtyeEaNgdMceZg < P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg) ? P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg : rTwQzyWgdmiDfVtyeEaNgdMceZg);
		P_3 = new bSwOWZkzxfvIUNfbmfFzzBhDSOi(num, rTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi kXrOdtMyQfTEwowXBikPcAqfELw(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2)
	{
		kXrOdtMyQfTEwowXBikPcAqfELw(ref P_0, ref P_1, ref P_2, out var result);
		return result;
	}

	public void cOrudizlRAgOoIscAdMPlrCvqQc()
	{
		xpumVntKTYPdUAcEeqwWhsPgirN = ((xpumVntKTYPdUAcEeqwWhsPgirN < 0f) ? 0f : ((xpumVntKTYPdUAcEeqwWhsPgirN > 1f) ? 1f : xpumVntKTYPdUAcEeqwWhsPgirN));
		RTwQzyWgdmiDfVtyeEaNgdMceZg = ((RTwQzyWgdmiDfVtyeEaNgdMceZg < 0f) ? 0f : ((RTwQzyWgdmiDfVtyeEaNgdMceZg > 1f) ? 1f : RTwQzyWgdmiDfVtyeEaNgdMceZg));
	}

	public static void prYRLuTPBBTEppgRRrPHWZTFilF(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, out float P_2)
	{
		float num = P_0.xpumVntKTYPdUAcEeqwWhsPgirN - P_1.xpumVntKTYPdUAcEeqwWhsPgirN;
		float num2 = P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg - P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg;
		P_2 = (float)Math.Sqrt(num * num + num2 * num2);
	}

	public static float prYRLuTPBBTEppgRRrPHWZTFilF(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1)
	{
		float num = P_0.xpumVntKTYPdUAcEeqwWhsPgirN - P_1.xpumVntKTYPdUAcEeqwWhsPgirN;
		float num2 = P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg - P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg;
		return (float)Math.Sqrt(num * num + num2 * num2);
	}

	public static void SETqScJuUQoUsklauOLRNUHETdW(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, out float P_2)
	{
		float num = P_0.xpumVntKTYPdUAcEeqwWhsPgirN - P_1.xpumVntKTYPdUAcEeqwWhsPgirN;
		float num2 = P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg - P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg;
		P_2 = num * num + num2 * num2;
	}

	public static float SETqScJuUQoUsklauOLRNUHETdW(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1)
	{
		float num = P_0.xpumVntKTYPdUAcEeqwWhsPgirN - P_1.xpumVntKTYPdUAcEeqwWhsPgirN;
		float num2 = P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg - P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg;
		return num * num + num2 * num2;
	}

	public static void KFpWOVFUMXrnsnvzVIQBctqFhrf(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, out float P_2)
	{
		P_2 = P_0.xpumVntKTYPdUAcEeqwWhsPgirN * P_1.xpumVntKTYPdUAcEeqwWhsPgirN + P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg * P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg;
	}

	public static float KFpWOVFUMXrnsnvzVIQBctqFhrf(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1)
	{
		return P_0.xpumVntKTYPdUAcEeqwWhsPgirN * P_1.xpumVntKTYPdUAcEeqwWhsPgirN + P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg * P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg;
	}

	public static void YaMiFtGaKdMLfCaBzotoQMbKGHv(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1)
	{
		P_1 = P_0;
		P_1.YaMiFtGaKdMLfCaBzotoQMbKGHv();
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi YaMiFtGaKdMLfCaBzotoQMbKGHv(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0)
	{
		P_0.YaMiFtGaKdMLfCaBzotoQMbKGHv();
		return P_0;
	}

	public static void aJzzJwwbYWeFOgTneyVKFMJcUrXW(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, float P_2, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_3)
	{
		P_3.xpumVntKTYPdUAcEeqwWhsPgirN = PvTDvuyTEvcojHCkUkFKczBErxKE.aJzzJwwbYWeFOgTneyVKFMJcUrXW(P_0.xpumVntKTYPdUAcEeqwWhsPgirN, P_1.xpumVntKTYPdUAcEeqwWhsPgirN, P_2);
		P_3.RTwQzyWgdmiDfVtyeEaNgdMceZg = PvTDvuyTEvcojHCkUkFKczBErxKE.aJzzJwwbYWeFOgTneyVKFMJcUrXW(P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg, P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg, P_2);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi aJzzJwwbYWeFOgTneyVKFMJcUrXW(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, float P_2)
	{
		aJzzJwwbYWeFOgTneyVKFMJcUrXW(ref P_0, ref P_1, P_2, out var result);
		return result;
	}

	public static void aecQHRIrVfqdPvtEWUdBhNCUYKp(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, float P_2, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_3)
	{
		P_2 = PvTDvuyTEvcojHCkUkFKczBErxKE.aecQHRIrVfqdPvtEWUdBhNCUYKp(P_2);
		aJzzJwwbYWeFOgTneyVKFMJcUrXW(ref P_0, ref P_1, P_2, out P_3);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi aecQHRIrVfqdPvtEWUdBhNCUYKp(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, float P_2)
	{
		aecQHRIrVfqdPvtEWUdBhNCUYKp(ref P_0, ref P_1, P_2, out var result);
		return result;
	}

	public static void uAZIuCCySDIhmjFmILeMERVupcbb(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_3, float P_4, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_5)
	{
		float num = P_4 * P_4;
		float num2 = P_4 * num;
		float num3 = 2f * num2 - 3f * num + 1f;
		float num4 = -2f * num2 + 3f * num;
		float num5 = num2 - 2f * num + P_4;
		float num6 = num2 - num;
		P_5.xpumVntKTYPdUAcEeqwWhsPgirN = P_0.xpumVntKTYPdUAcEeqwWhsPgirN * num3 + P_2.xpumVntKTYPdUAcEeqwWhsPgirN * num4 + P_1.xpumVntKTYPdUAcEeqwWhsPgirN * num5 + P_3.xpumVntKTYPdUAcEeqwWhsPgirN * num6;
		P_5.RTwQzyWgdmiDfVtyeEaNgdMceZg = P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg * num3 + P_2.RTwQzyWgdmiDfVtyeEaNgdMceZg * num4 + P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg * num5 + P_3.RTwQzyWgdmiDfVtyeEaNgdMceZg * num6;
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi uAZIuCCySDIhmjFmILeMERVupcbb(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_3, float P_4)
	{
		uAZIuCCySDIhmjFmILeMERVupcbb(ref P_0, ref P_1, ref P_2, ref P_3, P_4, out var result);
		return result;
	}

	public static void vunFwLUKcjymRCmdRdtocqpAeyB(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_3, float P_4, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_5)
	{
		float num = P_4 * P_4;
		float num2 = P_4 * num;
		P_5.xpumVntKTYPdUAcEeqwWhsPgirN = 0.5f * (2f * P_1.xpumVntKTYPdUAcEeqwWhsPgirN + (0f - P_0.xpumVntKTYPdUAcEeqwWhsPgirN + P_2.xpumVntKTYPdUAcEeqwWhsPgirN) * P_4 + (2f * P_0.xpumVntKTYPdUAcEeqwWhsPgirN - 5f * P_1.xpumVntKTYPdUAcEeqwWhsPgirN + 4f * P_2.xpumVntKTYPdUAcEeqwWhsPgirN - P_3.xpumVntKTYPdUAcEeqwWhsPgirN) * num + (0f - P_0.xpumVntKTYPdUAcEeqwWhsPgirN + 3f * P_1.xpumVntKTYPdUAcEeqwWhsPgirN - 3f * P_2.xpumVntKTYPdUAcEeqwWhsPgirN + P_3.xpumVntKTYPdUAcEeqwWhsPgirN) * num2);
		P_5.RTwQzyWgdmiDfVtyeEaNgdMceZg = 0.5f * (2f * P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg + (0f - P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg + P_2.RTwQzyWgdmiDfVtyeEaNgdMceZg) * P_4 + (2f * P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg - 5f * P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg + 4f * P_2.RTwQzyWgdmiDfVtyeEaNgdMceZg - P_3.RTwQzyWgdmiDfVtyeEaNgdMceZg) * num + (0f - P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg + 3f * P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg - 3f * P_2.RTwQzyWgdmiDfVtyeEaNgdMceZg + P_3.RTwQzyWgdmiDfVtyeEaNgdMceZg) * num2);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi vunFwLUKcjymRCmdRdtocqpAeyB(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_3, float P_4)
	{
		vunFwLUKcjymRCmdRdtocqpAeyB(ref P_0, ref P_1, ref P_2, ref P_3, P_4, out var result);
		return result;
	}

	public static void lMywsoBhHNYVGyaaLoEOIAqRqzM(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2)
	{
		P_2.xpumVntKTYPdUAcEeqwWhsPgirN = ((P_0.xpumVntKTYPdUAcEeqwWhsPgirN > P_1.xpumVntKTYPdUAcEeqwWhsPgirN) ? P_0.xpumVntKTYPdUAcEeqwWhsPgirN : P_1.xpumVntKTYPdUAcEeqwWhsPgirN);
		P_2.RTwQzyWgdmiDfVtyeEaNgdMceZg = ((P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg > P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg) ? P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg : P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi lMywsoBhHNYVGyaaLoEOIAqRqzM(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1)
	{
		lMywsoBhHNYVGyaaLoEOIAqRqzM(ref P_0, ref P_1, out var result);
		return result;
	}

	public static void aMRpkMRlRNGhQJocPbCmicSnRqK(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2)
	{
		P_2.xpumVntKTYPdUAcEeqwWhsPgirN = ((P_0.xpumVntKTYPdUAcEeqwWhsPgirN < P_1.xpumVntKTYPdUAcEeqwWhsPgirN) ? P_0.xpumVntKTYPdUAcEeqwWhsPgirN : P_1.xpumVntKTYPdUAcEeqwWhsPgirN);
		P_2.RTwQzyWgdmiDfVtyeEaNgdMceZg = ((P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg < P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg) ? P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg : P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi aMRpkMRlRNGhQJocPbCmicSnRqK(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1)
	{
		aMRpkMRlRNGhQJocPbCmicSnRqK(ref P_0, ref P_1, out var result);
		return result;
	}

	public static void QcwcNyVwKaBOFMPLCiEmHHHwAWfj(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1, out bSwOWZkzxfvIUNfbmfFzzBhDSOi P_2)
	{
		float num = P_0.xpumVntKTYPdUAcEeqwWhsPgirN * P_1.xpumVntKTYPdUAcEeqwWhsPgirN + P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg * P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg;
		P_2.xpumVntKTYPdUAcEeqwWhsPgirN = P_0.xpumVntKTYPdUAcEeqwWhsPgirN - 2f * num * P_1.xpumVntKTYPdUAcEeqwWhsPgirN;
		P_2.RTwQzyWgdmiDfVtyeEaNgdMceZg = P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg - 2f * num * P_1.RTwQzyWgdmiDfVtyeEaNgdMceZg;
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi QcwcNyVwKaBOFMPLCiEmHHHwAWfj(bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0, bSwOWZkzxfvIUNfbmfFzzBhDSOi P_1)
	{
		QcwcNyVwKaBOFMPLCiEmHHHwAWfj(ref P_0, ref P_1, out var result);
		return result;
	}

	public static void FqCgSnDTBUbNpNtvxKxenATHqnj(bSwOWZkzxfvIUNfbmfFzzBhDSOi[] P_0, params bSwOWZkzxfvIUNfbmfFzzBhDSOi[] P_1)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException("source");
		}
		if (P_0 == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (P_0.Length < P_1.Length)
		{
			throw new ArgumentOutOfRangeException("destination", "The destination array must be of same length or larger length than the source array.");
		}
		for (int i = 0; i < P_1.Length; i++)
		{
			bSwOWZkzxfvIUNfbmfFzzBhDSOi bSwOWZkzxfvIUNfbmfFzzBhDSOi2 = P_1[i];
			for (int j = 0; j < i; j++)
			{
				bSwOWZkzxfvIUNfbmfFzzBhDSOi2 -= KFpWOVFUMXrnsnvzVIQBctqFhrf(P_0[j], bSwOWZkzxfvIUNfbmfFzzBhDSOi2) / KFpWOVFUMXrnsnvzVIQBctqFhrf(P_0[j], P_0[j]) * P_0[j];
			}
			P_0[i] = bSwOWZkzxfvIUNfbmfFzzBhDSOi2;
		}
	}

	public static void QNlXHxykjWNItgPOTKGuGwbBBOa(bSwOWZkzxfvIUNfbmfFzzBhDSOi[] P_0, params bSwOWZkzxfvIUNfbmfFzzBhDSOi[] P_1)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException("source");
		}
		if (P_0 == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (P_0.Length < P_1.Length)
		{
			throw new ArgumentOutOfRangeException("destination", "The destination array must be of same length or larger length than the source array.");
		}
		for (int i = 0; i < P_1.Length; i++)
		{
			bSwOWZkzxfvIUNfbmfFzzBhDSOi bSwOWZkzxfvIUNfbmfFzzBhDSOi2 = P_1[i];
			for (int j = 0; j < i; j++)
			{
				bSwOWZkzxfvIUNfbmfFzzBhDSOi2 -= KFpWOVFUMXrnsnvzVIQBctqFhrf(P_0[j], bSwOWZkzxfvIUNfbmfFzzBhDSOi2) * P_0[j];
			}
			bSwOWZkzxfvIUNfbmfFzzBhDSOi2.YaMiFtGaKdMLfCaBzotoQMbKGHv();
			P_0[i] = bSwOWZkzxfvIUNfbmfFzzBhDSOi2;
		}
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi operator +(bSwOWZkzxfvIUNfbmfFzzBhDSOi left, bSwOWZkzxfvIUNfbmfFzzBhDSOi right)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(left.xpumVntKTYPdUAcEeqwWhsPgirN + right.xpumVntKTYPdUAcEeqwWhsPgirN, left.RTwQzyWgdmiDfVtyeEaNgdMceZg + right.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi operator *(bSwOWZkzxfvIUNfbmfFzzBhDSOi left, bSwOWZkzxfvIUNfbmfFzzBhDSOi right)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(left.xpumVntKTYPdUAcEeqwWhsPgirN * right.xpumVntKTYPdUAcEeqwWhsPgirN, left.RTwQzyWgdmiDfVtyeEaNgdMceZg * right.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi operator +(bSwOWZkzxfvIUNfbmfFzzBhDSOi value)
	{
		return value;
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi operator -(bSwOWZkzxfvIUNfbmfFzzBhDSOi left, bSwOWZkzxfvIUNfbmfFzzBhDSOi right)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(left.xpumVntKTYPdUAcEeqwWhsPgirN - right.xpumVntKTYPdUAcEeqwWhsPgirN, left.RTwQzyWgdmiDfVtyeEaNgdMceZg - right.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi operator -(bSwOWZkzxfvIUNfbmfFzzBhDSOi value)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(0f - value.xpumVntKTYPdUAcEeqwWhsPgirN, 0f - value.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi operator *(float scale, bSwOWZkzxfvIUNfbmfFzzBhDSOi value)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(value.xpumVntKTYPdUAcEeqwWhsPgirN * scale, value.RTwQzyWgdmiDfVtyeEaNgdMceZg * scale);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi operator *(bSwOWZkzxfvIUNfbmfFzzBhDSOi value, float scale)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(value.xpumVntKTYPdUAcEeqwWhsPgirN * scale, value.RTwQzyWgdmiDfVtyeEaNgdMceZg * scale);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi operator /(bSwOWZkzxfvIUNfbmfFzzBhDSOi value, float scale)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(value.xpumVntKTYPdUAcEeqwWhsPgirN / scale, value.RTwQzyWgdmiDfVtyeEaNgdMceZg / scale);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi operator /(float scale, bSwOWZkzxfvIUNfbmfFzzBhDSOi value)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(scale / value.xpumVntKTYPdUAcEeqwWhsPgirN, scale / value.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi operator /(bSwOWZkzxfvIUNfbmfFzzBhDSOi value, bSwOWZkzxfvIUNfbmfFzzBhDSOi scale)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(value.xpumVntKTYPdUAcEeqwWhsPgirN / scale.xpumVntKTYPdUAcEeqwWhsPgirN, value.RTwQzyWgdmiDfVtyeEaNgdMceZg / scale.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi operator +(bSwOWZkzxfvIUNfbmfFzzBhDSOi value, float scalar)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(value.xpumVntKTYPdUAcEeqwWhsPgirN + scalar, value.RTwQzyWgdmiDfVtyeEaNgdMceZg + scalar);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi operator +(float scalar, bSwOWZkzxfvIUNfbmfFzzBhDSOi value)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(scalar + value.xpumVntKTYPdUAcEeqwWhsPgirN, scalar + value.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi operator -(bSwOWZkzxfvIUNfbmfFzzBhDSOi value, float scalar)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(value.xpumVntKTYPdUAcEeqwWhsPgirN - scalar, value.RTwQzyWgdmiDfVtyeEaNgdMceZg - scalar);
	}

	public static bSwOWZkzxfvIUNfbmfFzzBhDSOi operator -(float scalar, bSwOWZkzxfvIUNfbmfFzzBhDSOi value)
	{
		return new bSwOWZkzxfvIUNfbmfFzzBhDSOi(scalar - value.xpumVntKTYPdUAcEeqwWhsPgirN, scalar - value.RTwQzyWgdmiDfVtyeEaNgdMceZg);
	}

	public static bool operator ==(bSwOWZkzxfvIUNfbmfFzzBhDSOi left, bSwOWZkzxfvIUNfbmfFzzBhDSOi right)
	{
		return left.pIBapvbJVOSPdWupDvkQdQSXKYP(ref right);
	}

	public static bool operator !=(bSwOWZkzxfvIUNfbmfFzzBhDSOi left, bSwOWZkzxfvIUNfbmfFzzBhDSOi right)
	{
		return !left.pIBapvbJVOSPdWupDvkQdQSXKYP(ref right);
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1}", new object[2] { xpumVntKTYPdUAcEeqwWhsPgirN, RTwQzyWgdmiDfVtyeEaNgdMceZg });
	}

	public string umnBZHBwpNvgsKPzDHsitCHPMNK(string P_0)
	{
		if (P_0 == null)
		{
			return ToString();
		}
		return string.Format(CultureInfo.CurrentCulture, "X:{0} Y:{1}", new object[2]
		{
			xpumVntKTYPdUAcEeqwWhsPgirN.ToString(P_0, CultureInfo.CurrentCulture),
			RTwQzyWgdmiDfVtyeEaNgdMceZg.ToString(P_0, CultureInfo.CurrentCulture)
		});
	}

	public string umnBZHBwpNvgsKPzDHsitCHPMNK(IFormatProvider P_0)
	{
		return string.Format(P_0, "X:{0} Y:{1}", new object[2] { xpumVntKTYPdUAcEeqwWhsPgirN, RTwQzyWgdmiDfVtyeEaNgdMceZg });
	}

	public string ToString(string format, IFormatProvider formatProvider)
	{
		if (format == null)
		{
			umnBZHBwpNvgsKPzDHsitCHPMNK(formatProvider);
		}
		return string.Format(formatProvider, "X:{0} Y:{1}", new object[2]
		{
			xpumVntKTYPdUAcEeqwWhsPgirN.ToString(format, formatProvider),
			RTwQzyWgdmiDfVtyeEaNgdMceZg.ToString(format, formatProvider)
		});
	}

	public override int GetHashCode()
	{
		return (xpumVntKTYPdUAcEeqwWhsPgirN.GetHashCode() * 397) ^ RTwQzyWgdmiDfVtyeEaNgdMceZg.GetHashCode();
	}

	public bool pIBapvbJVOSPdWupDvkQdQSXKYP(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi P_0)
	{
		if (PvTDvuyTEvcojHCkUkFKczBErxKE.jqkUhMXgVVQBZnbEKgZQNVEYBzxf(P_0.xpumVntKTYPdUAcEeqwWhsPgirN, xpumVntKTYPdUAcEeqwWhsPgirN))
		{
			return PvTDvuyTEvcojHCkUkFKczBErxKE.jqkUhMXgVVQBZnbEKgZQNVEYBzxf(P_0.RTwQzyWgdmiDfVtyeEaNgdMceZg, RTwQzyWgdmiDfVtyeEaNgdMceZg);
		}
		return false;
	}

	public bool Equals(bSwOWZkzxfvIUNfbmfFzzBhDSOi other)
	{
		return pIBapvbJVOSPdWupDvkQdQSXKYP(ref other);
	}

	public override bool Equals(object value)
	{
		if (!(value is bSwOWZkzxfvIUNfbmfFzzBhDSOi bSwOWZkzxfvIUNfbmfFzzBhDSOi2))
		{
			return false;
		}
		return pIBapvbJVOSPdWupDvkQdQSXKYP(ref bSwOWZkzxfvIUNfbmfFzzBhDSOi2);
	}
}
