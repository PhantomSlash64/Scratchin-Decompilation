using System;
using Rewired.Utils;

internal static class mmoBmgIgfOZxbJwkxOjqnWXjRHNq
{
	private unsafe static void nhfhJycJgKrySnrEUPZeTPnIBbB(byte* P_0, byte* P_1, int P_2)
	{
		if (P_2 < 0)
		{
			throw new Exception("Negative length in memcopy!");
		}
		if (SystemInfo.is64Bit)
		{
			CdXGjYeSEywimTGxzjRcZloYoeze(P_0, P_1, (ulong)P_2);
		}
		else
		{
			CdXGjYeSEywimTGxzjRcZloYoeze(P_0, P_1, (uint)P_2);
		}
	}

	private unsafe static void CdXGjYeSEywimTGxzjRcZloYoeze(byte* P_0, byte* P_1, uint P_2)
	{
		if ((uint)((int)P_0 - (int)P_1) < P_2)
		{
			throw new Exception("Overlapping buffers not supported!");
		}
		switch (P_2)
		{
		case 0u:
			return;
		case 1u:
			*P_0 = *P_1;
			return;
		case 2u:
			*(short*)P_0 = *(short*)P_1;
			return;
		case 3u:
			*(short*)P_0 = *(short*)P_1;
			P_0[2] = P_1[2];
			return;
		case 4u:
			*(int*)P_0 = *(int*)P_1;
			return;
		case 5u:
			*(int*)P_0 = *(int*)P_1;
			P_0[4] = P_1[4];
			return;
		case 6u:
			*(int*)P_0 = *(int*)P_1;
			*(short*)(P_0 + 4) = *(short*)(P_1 + 4);
			return;
		case 7u:
			*(int*)P_0 = *(int*)P_1;
			*(short*)(P_0 + 4) = *(short*)(P_1 + 4);
			P_0[6] = P_1[6];
			return;
		case 8u:
			*(int*)P_0 = *(int*)P_1;
			*(int*)(P_0 + 4) = *(int*)(P_1 + 4);
			return;
		case 9u:
			*(int*)P_0 = *(int*)P_1;
			*(int*)(P_0 + 4) = *(int*)(P_1 + 4);
			P_0[8] = P_1[8];
			return;
		case 10u:
			*(int*)P_0 = *(int*)P_1;
			*(int*)(P_0 + 4) = *(int*)(P_1 + 4);
			*(short*)(P_0 + 8) = *(short*)(P_1 + 8);
			return;
		case 11u:
			*(int*)P_0 = *(int*)P_1;
			*(int*)(P_0 + 4) = *(int*)(P_1 + 4);
			*(short*)(P_0 + 8) = *(short*)(P_1 + 8);
			P_0[10] = P_1[10];
			return;
		case 12u:
			*(int*)P_0 = *(int*)P_1;
			*(int*)(P_0 + 4) = *(int*)(P_1 + 4);
			*(int*)(P_0 + 8) = *(int*)(P_1 + 8);
			return;
		case 13u:
			*(int*)P_0 = *(int*)P_1;
			*(int*)(P_0 + 4) = *(int*)(P_1 + 4);
			*(int*)(P_0 + 8) = *(int*)(P_1 + 8);
			P_0[12] = P_1[12];
			return;
		case 14u:
			*(int*)P_0 = *(int*)P_1;
			*(int*)(P_0 + 4) = *(int*)(P_1 + 4);
			*(int*)(P_0 + 8) = *(int*)(P_1 + 8);
			*(short*)(P_0 + 12) = *(short*)(P_1 + 12);
			return;
		case 15u:
			*(int*)P_0 = *(int*)P_1;
			*(int*)(P_0 + 4) = *(int*)(P_1 + 4);
			*(int*)(P_0 + 8) = *(int*)(P_1 + 8);
			*(short*)(P_0 + 12) = *(short*)(P_1 + 12);
			P_0[14] = P_1[14];
			return;
		case 16u:
			*(int*)P_0 = *(int*)P_1;
			*(int*)(P_0 + 4) = *(int*)(P_1 + 4);
			*(int*)(P_0 + 8) = *(int*)(P_1 + 8);
			*(int*)(P_0 + 12) = *(int*)(P_1 + 12);
			return;
		}
		if (((uint)(int)P_0 & 3u) != 0)
		{
			if (((uint)(int)P_0 & (true ? 1u : 0u)) != 0)
			{
				*P_0 = *P_1;
				P_1++;
				P_0++;
				P_2--;
				if (((int)P_0 & 2) == 0)
				{
					goto IL_0215;
				}
			}
			*(short*)P_0 = *(short*)P_1;
			P_1 += 2;
			P_0 += 2;
			P_2 -= 2;
		}
		goto IL_0215;
		IL_0215:
		for (uint num = P_2 / 16u; num != 0; num--)
		{
			*(int*)P_0 = *(int*)P_1;
			*(int*)(P_0 + 4) = *(int*)(P_1 + 4);
			*(int*)(P_0 + 8) = *(int*)(P_1 + 8);
			*(int*)(P_0 + 12) = *(int*)(P_1 + 12);
			P_0 += 16;
			P_1 += 16;
		}
		if ((P_2 & 8u) != 0)
		{
			*(int*)P_0 = *(int*)P_1;
			*(int*)(P_0 + 4) = *(int*)(P_1 + 4);
			P_0 += 8;
			P_1 += 8;
		}
		if ((P_2 & 4u) != 0)
		{
			*(int*)P_0 = *(int*)P_1;
			P_0 += 4;
			P_1 += 4;
		}
		if ((P_2 & 2u) != 0)
		{
			*(short*)P_0 = *(short*)P_1;
			P_0 += 2;
			P_1 += 2;
		}
		if ((P_2 & (true ? 1u : 0u)) != 0)
		{
			*P_0 = *P_1;
		}
	}

	private unsafe static void CdXGjYeSEywimTGxzjRcZloYoeze(byte* P_0, byte* P_1, ulong P_2)
	{
		if ((ulong)((long)P_0 - (long)P_1) < P_2)
		{
			throw new Exception("Overlapping buffers not supported!");
		}
		ulong num = P_2;
		if ((long)num <= 16L && (long)num >= 0L)
		{
			switch (num)
			{
			case 0uL:
				return;
			case 1uL:
				*P_0 = *P_1;
				return;
			case 2uL:
				*(short*)P_0 = *(short*)P_1;
				return;
			case 3uL:
				*(short*)P_0 = *(short*)P_1;
				P_0[2] = P_1[2];
				return;
			case 4uL:
				*(int*)P_0 = *(int*)P_1;
				return;
			case 5uL:
				*(int*)P_0 = *(int*)P_1;
				P_0[4] = P_1[4];
				return;
			case 6uL:
				*(int*)P_0 = *(int*)P_1;
				*(short*)(P_0 + 4) = *(short*)(P_1 + 4);
				return;
			case 7uL:
				*(int*)P_0 = *(int*)P_1;
				*(short*)(P_0 + 4) = *(short*)(P_1 + 4);
				P_0[6] = P_1[6];
				return;
			case 8uL:
				*(long*)P_0 = *(long*)P_1;
				return;
			case 9uL:
				*(long*)P_0 = *(long*)P_1;
				P_0[8] = P_1[8];
				return;
			case 10uL:
				*(long*)P_0 = *(long*)P_1;
				*(short*)(P_0 + 8) = *(short*)(P_1 + 8);
				return;
			case 11uL:
				*(long*)P_0 = *(long*)P_1;
				*(short*)(P_0 + 8) = *(short*)(P_1 + 8);
				P_0[10] = P_1[10];
				return;
			case 12uL:
				*(long*)P_0 = *(long*)P_1;
				*(int*)(P_0 + 8) = *(int*)(P_1 + 8);
				return;
			case 13uL:
				*(long*)P_0 = *(long*)P_1;
				*(int*)(P_0 + 8) = *(int*)(P_1 + 8);
				P_0[12] = P_1[12];
				return;
			case 14uL:
				*(long*)P_0 = *(long*)P_1;
				*(int*)(P_0 + 8) = *(int*)(P_1 + 8);
				*(short*)(P_0 + 12) = *(short*)(P_1 + 12);
				return;
			case 15uL:
				*(long*)P_0 = *(long*)P_1;
				*(int*)(P_0 + 8) = *(int*)(P_1 + 8);
				*(short*)(P_0 + 12) = *(short*)(P_1 + 12);
				P_0[14] = P_1[14];
				return;
			case 16uL:
				*(long*)P_0 = *(long*)P_1;
				*(long*)(P_0 + 8) = *(long*)(P_1 + 8);
				return;
			}
		}
		if (((uint)(int)P_0 & 3u) != 0)
		{
			if (((uint)(int)P_0 & (true ? 1u : 0u)) != 0)
			{
				*P_0 = *P_1;
				P_1++;
				P_0++;
				P_2--;
				if (((int)P_0 & 2) == 0)
				{
					goto IL_01c3;
				}
			}
			*(short*)P_0 = *(short*)P_1;
			P_1 += 2;
			P_0 += 2;
			P_2 -= 2;
		}
		goto IL_01c3;
		IL_01c3:
		if (((uint)(int)P_0 & 4u) != 0)
		{
			*(int*)P_0 = *(int*)P_1;
			P_1 += 4;
			P_0 += 4;
			P_2 -= 4;
		}
		for (ulong num2 = P_2 / 16uL; num2 != 0; num2--)
		{
			*(long*)P_0 = *(long*)P_1;
			*(long*)(P_0 + 8) = *(long*)(P_1 + 8);
			P_0 += 16;
			P_1 += 16;
		}
		if ((P_2 & 8) != 0)
		{
			*(long*)P_0 = *(long*)P_1;
			P_0 += 8;
			P_1 += 8;
		}
		if ((P_2 & 4) != 0)
		{
			*(int*)P_0 = *(int*)P_1;
			P_0 += 4;
			P_1 += 4;
		}
		if ((P_2 & 2) != 0)
		{
			*(short*)P_0 = *(short*)P_1;
			P_0 += 2;
			P_1 += 2;
		}
		if ((P_2 & 1) != 0)
		{
			*P_0 = *P_1;
		}
	}

	public unsafe static bool rdErrbQiKPgCHcdXppfcnDcrDPZ(byte* P_0, byte* P_1, int P_2, int P_3, int P_4)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException("source");
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (P_2 < 0 || P_3 < 0 || P_4 < 0)
		{
			throw new Exception("Index and bytesToCopy must be non-negative!");
		}
		checked
		{
			if (SystemInfo.is64Bit)
			{
				CdXGjYeSEywimTGxzjRcZloYoeze(P_1 + P_3, P_0 + P_2, (ulong)P_4);
			}
			else
			{
				CdXGjYeSEywimTGxzjRcZloYoeze(P_1 + P_3, P_0 + P_2, (uint)P_4);
			}
			return true;
		}
	}

	public unsafe static bool rdErrbQiKPgCHcdXppfcnDcrDPZ(IntPtr P_0, IntPtr P_1, int P_2, int P_3, int P_4)
	{
		return rdErrbQiKPgCHcdXppfcnDcrDPZ((byte*)(void*)P_0, (byte*)(void*)P_1, P_2, P_3, P_4);
	}

	public unsafe static void bGpIVheXGTlHwcOjeZjjwzNPsjN(byte* P_0, int P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (P_1 >= 8)
		{
			int num = P_1 / 8 * 8;
			for (int i = 0; i < num; i += 8)
			{
				*(long*)(P_0 + i) = 0L;
			}
			for (int j = num; j < P_1; j++)
			{
				P_0[j] = 0;
			}
		}
		else
		{
			for (int k = 0; k < P_1; k++)
			{
				P_0[k] = 0;
			}
		}
	}

	public unsafe static void bGpIVheXGTlHwcOjeZjjwzNPsjN(IntPtr P_0, int P_1)
	{
		bGpIVheXGTlHwcOjeZjjwzNPsjN((byte*)(void*)P_0, P_1);
	}

	public unsafe static bool UgKvMMpkeNvHkMsMoamEsThjmNo(byte* P_0, int P_1, byte P_2, bool P_3 = true)
	{
		return UgKvMMpkeNvHkMsMoamEsThjmNo(P_0, P_1, 0, P_1, P_2, P_3);
	}

	public unsafe static bool UgKvMMpkeNvHkMsMoamEsThjmNo(byte* P_0, int P_1, int P_2, int P_3, byte P_4, bool P_5 = true)
	{
		if (!P_5)
		{
			if (P_0 == null)
			{
				return false;
			}
			if (P_1 <= 0)
			{
				return false;
			}
			if (P_2 < 0)
			{
				P_2 = 0;
			}
			if (P_3 <= 0)
			{
				return false;
			}
			if (P_2 + P_3 > P_1)
			{
				return false;
			}
		}
		else
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (P_1 <= 0)
			{
				throw new Exception("bufferLength must be > 0");
			}
			if (P_2 < 0)
			{
				throw new ArgumentOutOfRangeException("sourceStartIndex");
			}
			if (P_3 <= 0)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			if (P_2 + P_3 > P_1)
			{
				throw new Exception("startIndex + length must be less than or equal to bufferLength.");
			}
		}
		if (P_2 > 0)
		{
			P_0 += P_2;
		}
		if (P_3 >= 8)
		{
			long* ptr = (long*)P_0;
			int num = P_3 / 8;
			if (P_4 != 0)
			{
				long num2 = 0L;
				byte* ptr2 = (byte*)(&num2);
				for (int i = 0; i < 8; i++)
				{
					ptr2[i] = P_4;
				}
				for (int j = 0; j < num; j++)
				{
					ptr[j] = num2;
				}
			}
			else
			{
				for (int k = 0; k < num; k++)
				{
					ptr[k] = 0L;
				}
			}
			for (int l = num * 8; l < P_3; l++)
			{
				P_0[l] = P_4;
			}
		}
		else
		{
			for (int m = 0; m < P_3; m++)
			{
				P_0[m] = P_4;
			}
		}
		return true;
	}

	public unsafe static bool UgKvMMpkeNvHkMsMoamEsThjmNo(IntPtr P_0, int P_1, byte P_2, bool P_3 = true)
	{
		return UgKvMMpkeNvHkMsMoamEsThjmNo((byte*)(void*)P_0, P_1, 0, P_1, P_2, P_3);
	}

	public unsafe static bool UgKvMMpkeNvHkMsMoamEsThjmNo(IntPtr P_0, int P_1, int P_2, int P_3, byte P_4, bool P_5 = true)
	{
		return UgKvMMpkeNvHkMsMoamEsThjmNo((byte*)(void*)P_0, P_1, P_2, P_3, P_4, P_5);
	}
}
