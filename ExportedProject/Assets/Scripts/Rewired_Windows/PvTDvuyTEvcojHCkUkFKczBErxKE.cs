using System;

internal static class PvTDvuyTEvcojHCkUkFKczBErxKE
{
	public const float cgbeGNamGqUWewPwnHfbBWvWTRN = 1E-06f;

	public const float gSWsZRfDaDFMdjVEqCDPtHYvpDCC = (float)Math.PI;

	public const float ppPyMSLirBwhADwrwGdQzCVFGCu = (float)Math.PI * 2f;

	public const float QuPsNXSFfCkdhXxguvDlFszWrci = (float)Math.PI / 2f;

	public const float VfpAVnaGgioJzKheClukgPzepIJf = (float)Math.PI / 4f;

	public unsafe static bool jqkUhMXgVVQBZnbEKgZQNVEYBzxf(float P_0, float P_1)
	{
		if (FjhSjATXPgHVADnRhwechHIilJe(P_0 - P_1))
		{
			return true;
		}
		int num = *(int*)(&P_0);
		int num2 = *(int*)(&P_1);
		if (num < 0 != num2 < 0)
		{
			return false;
		}
		int num3 = Math.Abs(num - num2);
		return num3 <= 4;
	}

	public static bool FjhSjATXPgHVADnRhwechHIilJe(float P_0)
	{
		return Math.Abs(P_0) < 1E-06f;
	}

	public static bool RFIYmnKMAtHndKGUMEjAnkJtELlX(float P_0)
	{
		return FjhSjATXPgHVADnRhwechHIilJe(P_0 - 1f);
	}

	public static bool rZIKnDTfZkCGTbOySNyHJbmhylo(float P_0, float P_1, float P_2)
	{
		float num = P_0 - P_1;
		if (0f - P_2 <= num)
		{
			return num <= P_2;
		}
		return false;
	}

	public static float QIXezZNtkoGTPJcumYTkABzEvDX(float P_0)
	{
		return P_0 * 360f;
	}

	public static float eDwwMkTxSAohZLpnXbzqsCialeK(float P_0)
	{
		return P_0 * ((float)Math.PI * 2f);
	}

	public static float NcnEfJgRYJbPWwRqtHTBfGLhSGUk(float P_0)
	{
		return P_0 * 400f;
	}

	public static float itPIGYdWQlDrPrFQhCsaKeaZOhKt(float P_0)
	{
		return P_0 / 360f;
	}

	public static float DCanszNgNckpzxoQIxMrMnHwFmIC(float P_0)
	{
		return P_0 * ((float)Math.PI / 180f);
	}

	public static float VhNxbYAdnkfVANmRhtayrjoujeT(float P_0)
	{
		return P_0 / ((float)Math.PI * 2f);
	}

	public static float OtVfzxufMfkhHpoENalxkdkhalXf(float P_0)
	{
		return P_0 * (200f / (float)Math.PI);
	}

	public static float eMYjEDGsPcEMANCAVBETiJubREQ(float P_0)
	{
		return P_0 / 400f;
	}

	public static float BcNrcDPGnJMglSKuIvbfTisYCqe(float P_0)
	{
		return P_0 * 0.9f;
	}

	public static float EICKzHTxTEtMPfYkqrJgkgIErsb(float P_0)
	{
		return P_0 * ((float)Math.PI / 200f);
	}

	public static float HDwMkHTBFoFkHkVtRwUjKUTNFleL(float P_0)
	{
		return P_0 * (180f / (float)Math.PI);
	}

	public static float kXrOdtMyQfTEwowXBikPcAqfELw(float P_0, float P_1, float P_2)
	{
		if (!(P_0 < P_1))
		{
			if (!(P_0 > P_2))
			{
				return P_0;
			}
			return P_2;
		}
		return P_1;
	}

	public static int kXrOdtMyQfTEwowXBikPcAqfELw(int P_0, int P_1, int P_2)
	{
		if (P_0 >= P_1)
		{
			if (P_0 <= P_2)
			{
				return P_0;
			}
			return P_2;
		}
		return P_1;
	}

	public static double aJzzJwwbYWeFOgTneyVKFMJcUrXW(double P_0, double P_1, double P_2)
	{
		return (1.0 - P_2) * P_0 + P_2 * P_1;
	}

	public static float aJzzJwwbYWeFOgTneyVKFMJcUrXW(float P_0, float P_1, float P_2)
	{
		return (1f - P_2) * P_0 + P_2 * P_1;
	}

	public static byte aJzzJwwbYWeFOgTneyVKFMJcUrXW(byte P_0, byte P_1, float P_2)
	{
		return (byte)aJzzJwwbYWeFOgTneyVKFMJcUrXW((int)P_0, (int)P_1, P_2);
	}

	public static float aecQHRIrVfqdPvtEWUdBhNCUYKp(float P_0)
	{
		if (!(P_0 <= 0f))
		{
			if (!(P_0 >= 1f))
			{
				return P_0 * P_0 * (3f - 2f * P_0);
			}
			return 1f;
		}
		return 0f;
	}

	public static float BtGaEWdyIdDNsDxyBNHPDXSAWW(float P_0)
	{
		if (!(P_0 <= 0f))
		{
			if (!(P_0 >= 1f))
			{
				return P_0 * P_0 * P_0 * (P_0 * (P_0 * 6f - 15f) + 10f);
			}
			return 1f;
		}
		return 0f;
	}

	public static float qHnKGYodUbXGEjTyiNGSeoSxcXN(float P_0, float P_1)
	{
		if (P_1 == 0f)
		{
			return P_0;
		}
		return P_0 % P_1;
	}

	public static float TnagdOABaVQTAAhUJBjcaUnWVDWv(float P_0)
	{
		return qHnKGYodUbXGEjTyiNGSeoSxcXN(P_0, (float)Math.PI * 2f);
	}

	public static int wWHLVIjsKlbrhoqVkwpPLXbpCti(int P_0, int P_1, int P_2)
	{
		if (P_1 > P_2)
		{
			throw new ArgumentException($"min {P_1} should be less than or equal to max {P_2}", "min");
		}
		int num = P_2 - P_1 + 1;
		if (P_0 < P_1)
		{
			P_0 += num * ((P_1 - P_0) / num + 1);
		}
		return P_1 + (P_0 - P_1) % num;
	}

	public static float wWHLVIjsKlbrhoqVkwpPLXbpCti(float P_0, float P_1, float P_2)
	{
		if (jqkUhMXgVVQBZnbEKgZQNVEYBzxf(P_1, P_2))
		{
			return P_1;
		}
		double num = P_1;
		double num2 = P_2;
		double num3 = P_0;
		if (num > num2)
		{
			throw new ArgumentException($"min {P_1} should be less than or equal to max {P_2}", "min");
		}
		double num4 = num2 - num;
		return (float)(num + (num3 - num) - num4 * Math.Floor((num3 - num) / num4));
	}

	public static float fGkNcHhycADusypHUVBwhlFIgMA(float P_0, float P_1, float P_2, float P_3, float P_4, float P_5, float P_6)
	{
		return (float)fGkNcHhycADusypHUVBwhlFIgMA((double)P_0, (double)P_1, (double)P_2, (double)P_3, (double)P_4, (double)P_5, (double)P_6);
	}

	public static double fGkNcHhycADusypHUVBwhlFIgMA(double P_0, double P_1, double P_2, double P_3, double P_4, double P_5, double P_6)
	{
		return P_0 * Math.E - (Math.Pow(P_1 - P_3 / 2.0, 2.0) / (2.0 * Math.Pow(P_5, 2.0)) + Math.Pow(P_2 - P_4 / 2.0, 2.0) / (2.0 * Math.Pow(P_6, 2.0)));
	}
}
