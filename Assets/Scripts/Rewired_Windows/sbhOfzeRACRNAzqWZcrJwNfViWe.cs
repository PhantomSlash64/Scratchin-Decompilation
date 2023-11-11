using System;
using System.Runtime.InteropServices;

internal class sbhOfzeRACRNAzqWZcrJwNfViWe : IDisposable
{
	public struct mHnsrhcIXCCpcKRfvoxfCCQQNRYO
	{
		private byte vfQtGgUFjeCfNEtDdKsofiYFApfX;

		private uint dRNyFjypiJcnAElHEXkVaRpaaCU;

		private int qyNyXGREMzpucVvRZwjBQRCIORc;

		private static mHnsrhcIXCCpcKRfvoxfCCQQNRYO vVWEpUKUfLPelclwHHgqghdSAHfJ;

		public byte tQBfCwDPWlolxAGapAMkseoWayoD => vfQtGgUFjeCfNEtDdKsofiYFApfX;

		public uint lFITlgTHTLUUiJuJNVLYkVNYarE => dRNyFjypiJcnAElHEXkVaRpaaCU;

		public int ennUaNXGzFdNTPUKCLPLQGDndiK => qyNyXGREMzpucVvRZwjBQRCIORc;

		public static mHnsrhcIXCCpcKRfvoxfCCQQNRYO gpFFcazAsaWxRZVTMnFJwaCrBIR => vVWEpUKUfLPelclwHHgqghdSAHfJ;

		public mHnsrhcIXCCpcKRfvoxfCCQQNRYO(byte pass, uint offset, int length)
		{
			vfQtGgUFjeCfNEtDdKsofiYFApfX = pass;
			dRNyFjypiJcnAElHEXkVaRpaaCU = offset;
			qyNyXGREMzpucVvRZwjBQRCIORc = length;
			if (qyNyXGREMzpucVvRZwjBQRCIORc < 0)
			{
				qyNyXGREMzpucVvRZwjBQRCIORc = 0;
			}
		}
	}

	private const byte xRMYyXYHkyCTkBfmkvFxUUDywTA = 254;

	private uint JWgdTAdAyLAzhcWmFJTbhxDqUjpn;

	private int HcfdITYsHulBrNwitifSjfoDiNI;

	private unsafe byte* yPGdkDbmUprZQgIYBbQMXjWchZfv;

	private byte vfQtGgUFjeCfNEtDdKsofiYFApfX;

	private bool zryEsPRhLExAvzjypvMwvyDQdDn;

	private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

	public int fnXDHADGAIKLXUikmwkYcfoOkMJD => HcfdITYsHulBrNwitifSjfoDiNI;

	public unsafe sbhOfzeRACRNAzqWZcrJwNfViWe(int size)
	{
		if (size <= 0)
		{
			throw new Exception("size must be > 0!");
		}
		HcfdITYsHulBrNwitifSjfoDiNI = size;
		JWgdTAdAyLAzhcWmFJTbhxDqUjpn = 0u;
		yPGdkDbmUprZQgIYBbQMXjWchZfv = (byte*)(void*)Marshal.AllocHGlobal(size);
	}

	public unsafe bool klxMdkMazIUJPUlFFCZeFKzabgc(IntPtr P_0, int P_1, out mHnsrhcIXCCpcKRfvoxfCCQQNRYO P_2)
	{
		if (yPGdkDbmUprZQgIYBbQMXjWchZfv == null || P_1 <= 0)
		{
			P_2 = default(mHnsrhcIXCCpcKRfvoxfCCQQNRYO);
			return false;
		}
		if (P_1 > HcfdITYsHulBrNwitifSjfoDiNI)
		{
			throw new Exception("Length is larger than the buffer.");
		}
		uint num = JWgdTAdAyLAzhcWmFJTbhxDqUjpn + (uint)P_1;
		if (num >= HcfdITYsHulBrNwitifSjfoDiNI)
		{
			JWgdTAdAyLAzhcWmFJTbhxDqUjpn = 0u;
			if (vfQtGgUFjeCfNEtDdKsofiYFApfX == 254)
			{
				vfQtGgUFjeCfNEtDdKsofiYFApfX = 0;
				zryEsPRhLExAvzjypvMwvyDQdDn = true;
			}
			else
			{
				vfQtGgUFjeCfNEtDdKsofiYFApfX++;
			}
		}
		FzngAIhKGFOAkXUDRNTZlbDTVEc.nRejUqVGLjEXbqlcYAtLpuMbJQeF(yPGdkDbmUprZQgIYBbQMXjWchZfv + (int)JWgdTAdAyLAzhcWmFJTbhxDqUjpn, (void*)P_0, new UIntPtr((uint)P_1));
		P_2 = new mHnsrhcIXCCpcKRfvoxfCCQQNRYO(vfQtGgUFjeCfNEtDdKsofiYFApfX, JWgdTAdAyLAzhcWmFJTbhxDqUjpn, P_1);
		JWgdTAdAyLAzhcWmFJTbhxDqUjpn += (uint)P_1;
		return true;
	}

	public int BJrAAaIAGcmOVdfUIHHCJXemriPD(mHnsrhcIXCCpcKRfvoxfCCQQNRYO P_0, byte[] P_1)
	{
		if (P_1 == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (P_1.Length < P_0.ennUaNXGzFdNTPUKCLPLQGDndiK)
		{
			throw new Exception("Buffer is not large enough to hold the data.");
		}
		if (!AZaHSXWgOHFcPNiElFCpGFLQihnt(ref P_0))
		{
			return -1;
		}
		Marshal.Copy(dDCldMUgPoLAkgnBDCutarUTqUpy(P_0), P_1, 0, P_0.ennUaNXGzFdNTPUKCLPLQGDndiK);
		return P_0.ennUaNXGzFdNTPUKCLPLQGDndiK;
	}

	public unsafe int BJrAAaIAGcmOVdfUIHHCJXemriPD(mHnsrhcIXCCpcKRfvoxfCCQQNRYO P_0, IntPtr P_1, int P_2)
	{
		if (P_1 == IntPtr.Zero)
		{
			throw new Exception("Buffer pointer is invalid.");
		}
		if (P_2 <= 0)
		{
			return -1;
		}
		if (P_2 < P_0.ennUaNXGzFdNTPUKCLPLQGDndiK)
		{
			throw new Exception("Buffer is not large enough to hold the data.");
		}
		if (!AZaHSXWgOHFcPNiElFCpGFLQihnt(ref P_0))
		{
			return -1;
		}
		FzngAIhKGFOAkXUDRNTZlbDTVEc.nRejUqVGLjEXbqlcYAtLpuMbJQeF((void*)P_1, yPGdkDbmUprZQgIYBbQMXjWchZfv, new UIntPtr((uint)P_0.ennUaNXGzFdNTPUKCLPLQGDndiK));
		return P_0.ennUaNXGzFdNTPUKCLPLQGDndiK;
	}

	public unsafe IntPtr dDCldMUgPoLAkgnBDCutarUTqUpy(mHnsrhcIXCCpcKRfvoxfCCQQNRYO P_0)
	{
		if (yPGdkDbmUprZQgIYBbQMXjWchZfv == null || !AZaHSXWgOHFcPNiElFCpGFLQihnt(ref P_0))
		{
			return IntPtr.Zero;
		}
		return (IntPtr)(yPGdkDbmUprZQgIYBbQMXjWchZfv + (int)P_0.lFITlgTHTLUUiJuJNVLYkVNYarE);
	}

	public unsafe bool nSsinbPuVCUtyHiWXNkRPOuhiXk(mHnsrhcIXCCpcKRfvoxfCCQQNRYO P_0, out IntPtr P_1)
	{
		if (yPGdkDbmUprZQgIYBbQMXjWchZfv == null || !AZaHSXWgOHFcPNiElFCpGFLQihnt(ref P_0))
		{
			P_1 = IntPtr.Zero;
			return false;
		}
		P_1 = (IntPtr)(yPGdkDbmUprZQgIYBbQMXjWchZfv + (int)P_0.lFITlgTHTLUUiJuJNVLYkVNYarE);
		return true;
	}

	private bool AZaHSXWgOHFcPNiElFCpGFLQihnt(ref mHnsrhcIXCCpcKRfvoxfCCQQNRYO P_0)
	{
		int length = P_0.ennUaNXGzFdNTPUKCLPLQGDndiK;
		if (length <= 0)
		{
			return false;
		}
		uint pass = P_0.tQBfCwDPWlolxAGapAMkseoWayoD;
		if (pass > 254)
		{
			return false;
		}
		if (pass != vfQtGgUFjeCfNEtDdKsofiYFApfX)
		{
			if (!zryEsPRhLExAvzjypvMwvyDQdDn)
			{
				if (pass + 1 != vfQtGgUFjeCfNEtDdKsofiYFApfX)
				{
					return false;
				}
			}
			else if (pass > vfQtGgUFjeCfNEtDdKsofiYFApfX)
			{
				if (vfQtGgUFjeCfNEtDdKsofiYFApfX != 0 || pass != 254)
				{
					return false;
				}
			}
			else if (pass + 1 != vfQtGgUFjeCfNEtDdKsofiYFApfX)
			{
				return false;
			}
			if (P_0.lFITlgTHTLUUiJuJNVLYkVNYarE < JWgdTAdAyLAzhcWmFJTbhxDqUjpn)
			{
				return false;
			}
		}
		else if (P_0.lFITlgTHTLUUiJuJNVLYkVNYarE + length > JWgdTAdAyLAzhcWmFJTbhxDqUjpn)
		{
			return false;
		}
		if (P_0.lFITlgTHTLUUiJuJNVLYkVNYarE + length > HcfdITYsHulBrNwitifSjfoDiNI)
		{
			return false;
		}
		return true;
	}

	public void Dispose()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
		GC.SuppressFinalize(this);
	}

	~sbhOfzeRACRNAzqWZcrJwNfViWe()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
	}

	protected unsafe virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (!jpnIPbpqmlecdiNqaFAxiNCsiMxs)
		{
			if (yPGdkDbmUprZQgIYBbQMXjWchZfv != null)
			{
				Marshal.FreeHGlobal((IntPtr)yPGdkDbmUprZQgIYBbQMXjWchZfv);
			}
			jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
		}
	}
}
