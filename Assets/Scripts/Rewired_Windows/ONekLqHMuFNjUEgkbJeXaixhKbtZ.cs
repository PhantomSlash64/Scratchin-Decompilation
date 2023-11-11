using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Rewired.Utils;

[DefaultMember("Item")]
internal class ONekLqHMuFNjUEgkbJeXaixhKbtZ : IDisposable
{
	private unsafe byte* yxqNAesSuAgdwwIXHSRTmXuEixl;

	private int AtLfpFiPJjASASrcRCUZTxBXBMX;

	private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

	public unsafe byte* BgIgKYDXyZJcXtYSatStOhUWMTup => yxqNAesSuAgdwwIXHSRTmXuEixl;

	public unsafe IntPtr ONOzRUELvkhUJSYbdUptBCQVURI => (IntPtr)yxqNAesSuAgdwwIXHSRTmXuEixl;

	public int MaluonABdyiloPnZCFkVkPsyOJnR => AtLfpFiPJjASASrcRCUZTxBXBMX;

	public unsafe byte GXwEwVpxCBxQxjtzWDWsvqrEoza
	{
		get
		{
			if (index < 0 || index >= AtLfpFiPJjASASrcRCUZTxBXBMX)
			{
				throw new IndexOutOfRangeException();
			}
			return yxqNAesSuAgdwwIXHSRTmXuEixl[index];
		}
		set
		{
			if (index < 0 || index >= AtLfpFiPJjASASrcRCUZTxBXBMX)
			{
				throw new IndexOutOfRangeException();
			}
			yxqNAesSuAgdwwIXHSRTmXuEixl[index] = value;
		}
	}

	public ONekLqHMuFNjUEgkbJeXaixhKbtZ(int size)
	{
		CUriAZlnkhHKWMbqmUZRRQCwExz(size);
	}

	public unsafe IntPtr dDCldMUgPoLAkgnBDCutarUTqUpy(int P_0 = 0)
	{
		if (P_0 == 0)
		{
			return (IntPtr)yxqNAesSuAgdwwIXHSRTmXuEixl;
		}
		if (P_0 < 0 || P_0 >= AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			throw new ArgumentOutOfRangeException("offset");
		}
		return (IntPtr)(yxqNAesSuAgdwwIXHSRTmXuEixl + P_0);
	}

	public unsafe string YtleImjCPmDHfZTQJsNERqPlpwY()
	{
		string text = "";
		for (int i = 0; i < AtLfpFiPJjASASrcRCUZTxBXBMX; i++)
		{
			text = text + yxqNAesSuAgdwwIXHSRTmXuEixl[i].ToString("x2") + " ";
		}
		return text;
	}

	public unsafe bool EjHceJbxNPSegSyaBKTbdfigrogM(int P_0, byte P_1)
	{
		if (1 + P_0 > AtLfpFiPJjASASrcRCUZTxBXBMX || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("byteIndex");
		}
		if (P_1 >= 8)
		{
			throw new ArgumentOutOfRangeException("bit");
		}
		return (yxqNAesSuAgdwwIXHSRTmXuEixl[P_0] & (1 << (int)P_1)) != 0;
	}

	public unsafe byte yVjbZKGhFbPVCUPDDAGVfgBuXHG(int P_0)
	{
		if (1 + P_0 > AtLfpFiPJjASASrcRCUZTxBXBMX || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		return yxqNAesSuAgdwwIXHSRTmXuEixl[P_0];
	}

	public unsafe short zViBYeBHdzTnYPFMTjboQJAJXzG(int P_0)
	{
		if (2 + P_0 > AtLfpFiPJjASASrcRCUZTxBXBMX || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		return *(short*)(yxqNAesSuAgdwwIXHSRTmXuEixl + P_0);
	}

	public unsafe ushort xFEnNDCHXMwYycuwTbRRaVPJuen(int P_0)
	{
		if (2 + P_0 > AtLfpFiPJjASASrcRCUZTxBXBMX || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		return *(ushort*)(yxqNAesSuAgdwwIXHSRTmXuEixl + P_0);
	}

	public unsafe int uJELFssVtNDhscqCvkBwSNPRnmF(int P_0)
	{
		if (4 + P_0 > AtLfpFiPJjASASrcRCUZTxBXBMX || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		return *(int*)(yxqNAesSuAgdwwIXHSRTmXuEixl + P_0);
	}

	public unsafe uint SywQpLSMLMVMHauHwAQQSVWJJwb(int P_0)
	{
		if (4 + P_0 > AtLfpFiPJjASASrcRCUZTxBXBMX || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		return *(uint*)(yxqNAesSuAgdwwIXHSRTmXuEixl + P_0);
	}

	public unsafe long XMdHyrnlBdtBbNJyklZkCnEwFrf(int P_0)
	{
		if (8 + P_0 > AtLfpFiPJjASASrcRCUZTxBXBMX || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		return *(long*)(yxqNAesSuAgdwwIXHSRTmXuEixl + P_0);
	}

	public unsafe ulong XYHhJZmgzSCTNKFUIqspGjtqqhrR(int P_0)
	{
		if (8 + P_0 > AtLfpFiPJjASASrcRCUZTxBXBMX || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		return *(ulong*)(yxqNAesSuAgdwwIXHSRTmXuEixl + P_0);
	}

	public unsafe void BJrAAaIAGcmOVdfUIHHCJXemriPD(byte[] P_0, int P_1, int P_2 = 0, int P_3 = 0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException("bytes");
		}
		int num = P_0.Length;
		if (num <= 0)
		{
			throw new ArgumentOutOfRangeException("bytes.Length must be > 0.");
		}
		if (P_1 <= 0)
		{
			throw new ArgumentOutOfRangeException("numBytesToRead must be > 0");
		}
		if (P_1 > num)
		{
			throw new ArgumentOutOfRangeException("numBytesToRead must be <= bufferLength.");
		}
		if (P_1 > AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			throw new ArgumentOutOfRangeException("numBytesToRead must be <= Length.");
		}
		if (P_3 >= num)
		{
			throw new ArgumentOutOfRangeException("writeStartIndex must be < bufferLength.");
		}
		if (P_3 < 0)
		{
			throw new ArgumentOutOfRangeException("writeStartIndex must be >= 0.");
		}
		if (P_2 >= AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			throw new ArgumentOutOfRangeException("readStartIndex must be < Length.");
		}
		if (P_2 < 0)
		{
			throw new ArgumentOutOfRangeException("readStartIndex must be >= 0.");
		}
		if (P_3 + P_1 > num)
		{
			throw new ArgumentOutOfRangeException("writeStartIndex + numBytesToRead must be < bufferLength.");
		}
		if (P_1 + P_2 > AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			throw new ArgumentOutOfRangeException("numBytesToRead + readStartIndex must be < Length.");
		}
		NativeTools.CopyMemory((IntPtr)yxqNAesSuAgdwwIXHSRTmXuEixl, P_0, P_2, P_3, P_1);
	}

	public unsafe void BJrAAaIAGcmOVdfUIHHCJXemriPD(byte* P_0, int P_1, int P_2, int P_3 = 0, int P_4 = 0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException("bytes");
		}
		if (P_1 <= 0)
		{
			throw new ArgumentOutOfRangeException("bufferLength must be > 0.");
		}
		if (P_2 <= 0)
		{
			throw new ArgumentOutOfRangeException("numBytesToRead must be > 0");
		}
		if (P_2 > P_1)
		{
			throw new ArgumentOutOfRangeException("numBytesToRead must be <= bufferLength.");
		}
		if (P_2 > AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			throw new ArgumentOutOfRangeException("numBytesToRead must be <= Length.");
		}
		if (P_4 >= P_1)
		{
			throw new ArgumentOutOfRangeException("writeStartIndex must be < bufferLength.");
		}
		if (P_4 < 0)
		{
			throw new ArgumentOutOfRangeException("writeStartIndex must be >= 0.");
		}
		if (P_3 >= AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			throw new ArgumentOutOfRangeException("readStartIndex must be < Length.");
		}
		if (P_3 < 0)
		{
			throw new ArgumentOutOfRangeException("readStartIndex must be >= 0.");
		}
		if (P_4 + P_2 > P_1)
		{
			throw new ArgumentOutOfRangeException("writeStartIndex + numBytesToRead must be < bufferLength.");
		}
		if (P_2 + P_3 > AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			throw new ArgumentOutOfRangeException("numBytesToRead + readStartIndex must be < Length.");
		}
		mmoBmgIgfOZxbJwkxOjqnWXjRHNq.rdErrbQiKPgCHcdXppfcnDcrDPZ(yxqNAesSuAgdwwIXHSRTmXuEixl, P_0, P_3, P_4, P_2);
	}

	public unsafe void BJrAAaIAGcmOVdfUIHHCJXemriPD(IntPtr P_0, int P_1, int P_2, int P_3 = 0, int P_4 = 0)
	{
		BJrAAaIAGcmOVdfUIHHCJXemriPD((byte*)(void*)P_0, P_1, P_2, P_3, P_4);
	}

	public unsafe int KtdFVPWbuczWQlMquhIGGlqiuHS(byte[] P_0, int P_1, int P_2 = 0, int P_3 = 0)
	{
		if (P_0 == null || P_1 <= 0)
		{
			return 0;
		}
		int num = P_0.Length;
		if (num == 0)
		{
			return 0;
		}
		if (P_2 >= AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			return 0;
		}
		if (P_3 >= num)
		{
			return 0;
		}
		if (P_2 < 0)
		{
			P_2 = 0;
		}
		if (P_3 < 0)
		{
			P_3 = 0;
		}
		if (P_2 + P_1 > AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			P_1 = AtLfpFiPJjASASrcRCUZTxBXBMX - P_2;
		}
		if (P_3 + P_1 > num)
		{
			P_1 = num - P_3;
		}
		if (P_1 == 0)
		{
			return 0;
		}
		NativeTools.CopyMemory((IntPtr)yxqNAesSuAgdwwIXHSRTmXuEixl, P_0, P_2, P_3, P_1);
		return P_1;
	}

	public unsafe int KtdFVPWbuczWQlMquhIGGlqiuHS(byte* P_0, int P_1, int P_2, int P_3 = 0, int P_4 = 0)
	{
		if (P_0 == null || P_2 <= 0)
		{
			return 0;
		}
		if (P_3 >= AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			return 0;
		}
		if (P_4 >= P_1)
		{
			return 0;
		}
		if (P_3 < 0)
		{
			P_3 = 0;
		}
		if (P_4 < 0)
		{
			P_4 = 0;
		}
		if (P_3 + P_2 > AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			P_2 = AtLfpFiPJjASASrcRCUZTxBXBMX - P_3;
		}
		if (P_4 + P_2 > P_1)
		{
			P_2 = P_1 - P_4;
		}
		mmoBmgIgfOZxbJwkxOjqnWXjRHNq.rdErrbQiKPgCHcdXppfcnDcrDPZ(yxqNAesSuAgdwwIXHSRTmXuEixl, P_0, P_3, P_4, P_2);
		return P_2;
	}

	public unsafe int KtdFVPWbuczWQlMquhIGGlqiuHS(IntPtr P_0, int P_1, int P_2, int P_3 = 0, int P_4 = 0)
	{
		if (P_0 == IntPtr.Zero)
		{
			return 0;
		}
		return KtdFVPWbuczWQlMquhIGGlqiuHS((byte*)(void*)P_0, P_1, P_2, P_3, P_4);
	}

	public unsafe void iLXYCLxdusFkzaetKgcdZJqZMKuF(int P_0, byte P_1, bool P_2)
	{
		if (1 + P_0 > AtLfpFiPJjASASrcRCUZTxBXBMX || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("byteIndex");
		}
		if (P_1 >= 8)
		{
			throw new ArgumentOutOfRangeException("bit");
		}
		if (P_2)
		{
			byte* intPtr = yxqNAesSuAgdwwIXHSRTmXuEixl + P_0;
			*intPtr = (byte)(*intPtr | (byte)(1 << (int)P_1));
		}
		else
		{
			byte* intPtr2 = yxqNAesSuAgdwwIXHSRTmXuEixl + P_0;
			*intPtr2 = (byte)(*intPtr2 & (byte)(~(1 << (int)P_1)));
		}
	}

	public unsafe void klxMdkMazIUJPUlFFCZeFKzabgc(byte P_0, int P_1)
	{
		if (1 + P_1 > AtLfpFiPJjASASrcRCUZTxBXBMX || P_1 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		yxqNAesSuAgdwwIXHSRTmXuEixl[P_1] = P_0;
	}

	public unsafe void klxMdkMazIUJPUlFFCZeFKzabgc(short P_0, int P_1)
	{
		if (2 + P_1 > AtLfpFiPJjASASrcRCUZTxBXBMX || P_1 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		*(short*)(yxqNAesSuAgdwwIXHSRTmXuEixl + P_1) = P_0;
	}

	public unsafe void klxMdkMazIUJPUlFFCZeFKzabgc(ushort P_0, int P_1)
	{
		if (2 + P_1 > AtLfpFiPJjASASrcRCUZTxBXBMX || P_1 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		*(ushort*)(yxqNAesSuAgdwwIXHSRTmXuEixl + P_1) = P_0;
	}

	public unsafe void klxMdkMazIUJPUlFFCZeFKzabgc(int P_0, int P_1)
	{
		if (4 + P_1 > AtLfpFiPJjASASrcRCUZTxBXBMX || P_1 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		*(int*)(yxqNAesSuAgdwwIXHSRTmXuEixl + P_1) = P_0;
	}

	public unsafe void klxMdkMazIUJPUlFFCZeFKzabgc(uint P_0, int P_1)
	{
		if (4 + P_1 > AtLfpFiPJjASASrcRCUZTxBXBMX || P_1 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		*(uint*)(yxqNAesSuAgdwwIXHSRTmXuEixl + P_1) = P_0;
	}

	public unsafe void klxMdkMazIUJPUlFFCZeFKzabgc(long P_0, int P_1)
	{
		if (8 + P_1 > AtLfpFiPJjASASrcRCUZTxBXBMX || P_1 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		*(long*)(yxqNAesSuAgdwwIXHSRTmXuEixl + P_1) = P_0;
	}

	public unsafe void klxMdkMazIUJPUlFFCZeFKzabgc(ulong P_0, int P_1)
	{
		if (8 + P_1 > AtLfpFiPJjASASrcRCUZTxBXBMX || P_1 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		*(ulong*)(yxqNAesSuAgdwwIXHSRTmXuEixl + P_1) = P_0;
	}

	public unsafe void klxMdkMazIUJPUlFFCZeFKzabgc(byte[] P_0, int P_1, int P_2 = 0, int P_3 = 0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException("bytes");
		}
		int num = P_0.Length;
		if (num <= 0)
		{
			throw new ArgumentOutOfRangeException("bytes.Length must be > 0.");
		}
		if (P_1 <= 0)
		{
			throw new ArgumentOutOfRangeException("numBytesToWrite must be > 0");
		}
		if (P_1 > num)
		{
			throw new ArgumentOutOfRangeException("numBytesToWrite must be <= bufferLength.");
		}
		if (P_1 > AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			throw new ArgumentOutOfRangeException("numBytesToWrite must be <= Length.");
		}
		if (P_3 >= num)
		{
			throw new ArgumentOutOfRangeException("readStartIndex must be < bufferLength.");
		}
		if (P_3 < 0)
		{
			throw new ArgumentOutOfRangeException("readStartIndex must be >= 0.");
		}
		if (P_2 >= AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			throw new ArgumentOutOfRangeException("writeStartIndex must be < Length.");
		}
		if (P_2 < 0)
		{
			throw new ArgumentOutOfRangeException("writeStartIndex must be >= 0.");
		}
		if (P_3 + P_1 > num)
		{
			throw new ArgumentOutOfRangeException("readStartIndex + numBytesToWrite must be < bufferLength.");
		}
		if (P_1 + P_2 > AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			throw new ArgumentOutOfRangeException("numBytesToWrite + writeStartIndex must be < Length.");
		}
		NativeTools.CopyMemory(P_0, (IntPtr)yxqNAesSuAgdwwIXHSRTmXuEixl, P_3, P_2, P_1);
	}

	public unsafe void klxMdkMazIUJPUlFFCZeFKzabgc(byte* P_0, int P_1, int P_2, int P_3 = 0, int P_4 = 0)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException("bytes");
		}
		if (P_1 <= 0)
		{
			throw new ArgumentOutOfRangeException("bufferLength must be > 0.");
		}
		if (P_2 <= 0)
		{
			throw new ArgumentOutOfRangeException("numBytesToWrite must be > 0");
		}
		if (P_2 > P_1)
		{
			throw new ArgumentOutOfRangeException("numBytesToWrite must be <= bufferLength.");
		}
		if (P_2 > AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			throw new ArgumentOutOfRangeException("numBytesToWrite must be <= Length.");
		}
		if (P_4 >= P_1)
		{
			throw new ArgumentOutOfRangeException("readStartIndex must be < bufferLength.");
		}
		if (P_4 < 0)
		{
			throw new ArgumentOutOfRangeException("readStartIndex must be >= 0.");
		}
		if (P_3 >= AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			throw new ArgumentOutOfRangeException("writeStartIndex must be < Length.");
		}
		if (P_3 < 0)
		{
			throw new ArgumentOutOfRangeException("writeStartIndex must be >= 0.");
		}
		if (P_4 + P_2 > P_1)
		{
			throw new ArgumentOutOfRangeException("readStartIndex + numBytesToWrite must be < bufferLength.");
		}
		if (P_2 + P_3 > AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			throw new ArgumentOutOfRangeException("numBytesToWrite + writeStartIndex must be < Length.");
		}
		mmoBmgIgfOZxbJwkxOjqnWXjRHNq.rdErrbQiKPgCHcdXppfcnDcrDPZ(P_0, yxqNAesSuAgdwwIXHSRTmXuEixl, P_4, P_3, P_2);
	}

	public unsafe void klxMdkMazIUJPUlFFCZeFKzabgc(IntPtr P_0, int P_1, int P_2, int P_3 = 0, int P_4 = 0)
	{
		klxMdkMazIUJPUlFFCZeFKzabgc((byte*)(void*)P_0, P_1, P_2, P_3, P_4);
	}

	public unsafe int ogtAcQGaIHtxEbgvVwyqUNboON(byte[] P_0, int P_1, int P_2 = 0, int P_3 = 0)
	{
		if (P_0 == null)
		{
			return 0;
		}
		int num = P_0.Length;
		if (num == 0 || P_1 <= 0 || P_3 >= num || P_2 >= AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			return 0;
		}
		if (P_3 < 0)
		{
			P_3 = 0;
		}
		if (P_2 < 0)
		{
			P_2 = 0;
		}
		if (P_3 + P_1 > num)
		{
			P_1 = num - P_3;
		}
		if (P_1 + P_2 > AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			P_1 = AtLfpFiPJjASASrcRCUZTxBXBMX - P_2;
		}
		NativeTools.CopyMemory(P_0, (IntPtr)yxqNAesSuAgdwwIXHSRTmXuEixl, P_3, P_2, P_1);
		return P_1;
	}

	public unsafe int ogtAcQGaIHtxEbgvVwyqUNboON(byte* P_0, int P_1, int P_2, int P_3 = 0, int P_4 = 0)
	{
		if (P_0 == null || P_1 <= 0 || P_2 <= 0 || P_4 >= P_1 || P_3 >= AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			return 0;
		}
		if (P_4 < 0)
		{
			P_4 = 0;
		}
		if (P_3 < 0)
		{
			P_3 = 0;
		}
		if (P_4 + P_2 > P_1)
		{
			P_2 = P_1 - P_4;
		}
		if (P_2 + P_3 > AtLfpFiPJjASASrcRCUZTxBXBMX)
		{
			P_2 = AtLfpFiPJjASASrcRCUZTxBXBMX - P_3;
		}
		mmoBmgIgfOZxbJwkxOjqnWXjRHNq.rdErrbQiKPgCHcdXppfcnDcrDPZ(P_0, yxqNAesSuAgdwwIXHSRTmXuEixl, P_4, P_3, P_2);
		return P_2;
	}

	public unsafe int ogtAcQGaIHtxEbgvVwyqUNboON(IntPtr P_0, int P_1, int P_2, int P_3 = 0, int P_4 = 0)
	{
		return ogtAcQGaIHtxEbgvVwyqUNboON((byte*)(void*)P_0, P_1, P_2, P_3, P_4);
	}

	public unsafe bool CUriAZlnkhHKWMbqmUZRRQCwExz(int P_0)
	{
		if (P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("size");
		}
		if (AtLfpFiPJjASASrcRCUZTxBXBMX == P_0)
		{
			return true;
		}
		LSRowmkkqZrInkpBTVaIdpEXBCR();
		if (P_0 == 0)
		{
			return true;
		}
		AtLfpFiPJjASASrcRCUZTxBXBMX = P_0;
		yxqNAesSuAgdwwIXHSRTmXuEixl = (byte*)(void*)Marshal.AllocHGlobal(P_0);
		xZveeqhZWQBoifJNrEKvhlbeSAk();
		return true;
	}

	public unsafe void xZveeqhZWQBoifJNrEKvhlbeSAk()
	{
		if (AtLfpFiPJjASASrcRCUZTxBXBMX != 0)
		{
			mmoBmgIgfOZxbJwkxOjqnWXjRHNq.bGpIVheXGTlHwcOjeZjjwzNPsjN(yxqNAesSuAgdwwIXHSRTmXuEixl, AtLfpFiPJjASASrcRCUZTxBXBMX);
		}
	}

	public unsafe void LSRowmkkqZrInkpBTVaIdpEXBCR()
	{
		if (AtLfpFiPJjASASrcRCUZTxBXBMX == 0)
		{
			return;
		}
		try
		{
			if (yxqNAesSuAgdwwIXHSRTmXuEixl != null)
			{
				Marshal.FreeHGlobal(ONOzRUELvkhUJSYbdUptBCQVURI);
			}
		}
		catch
		{
		}
		yxqNAesSuAgdwwIXHSRTmXuEixl = null;
		AtLfpFiPJjASASrcRCUZTxBXBMX = 0;
	}

	public override string ToString()
	{
		string text = "";
		for (int i = 0; i < AtLfpFiPJjASASrcRCUZTxBXBMX; i++)
		{
			text = text + yVjbZKGhFbPVCUPDDAGVfgBuXHG(i).ToString("x2") + " ";
		}
		return text;
	}

	public void Dispose()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
		GC.SuppressFinalize(this);
	}

	~ONekLqHMuFNjUEgkbJeXaixhKbtZ()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
	}

	protected virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (!jpnIPbpqmlecdiNqaFAxiNCsiMxs)
		{
			LSRowmkkqZrInkpBTVaIdpEXBCR();
			jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
		}
	}

	public unsafe static implicit operator IntPtr(ONekLqHMuFNjUEgkbJeXaixhKbtZ buffer)
	{
		if (buffer == null)
		{
			return IntPtr.Zero;
		}
		return (IntPtr)buffer.yxqNAesSuAgdwwIXHSRTmXuEixl;
	}

	public unsafe static implicit operator void*(ONekLqHMuFNjUEgkbJeXaixhKbtZ buffer)
	{
		if (buffer == null)
		{
			return null;
		}
		return buffer.yxqNAesSuAgdwwIXHSRTmXuEixl;
	}

	public unsafe static bool aihWTPtNABTEsdOhuiIyFEfdHeSd(ONekLqHMuFNjUEgkbJeXaixhKbtZ P_0, ONekLqHMuFNjUEgkbJeXaixhKbtZ P_1)
	{
		if (P_0 == null)
		{
			throw new ArgumentNullException("source");
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException("destination");
		}
		if (P_0.AtLfpFiPJjASASrcRCUZTxBXBMX == 0)
		{
			P_1.LSRowmkkqZrInkpBTVaIdpEXBCR();
			return true;
		}
		if (P_1.CUriAZlnkhHKWMbqmUZRRQCwExz(P_0.AtLfpFiPJjASASrcRCUZTxBXBMX))
		{
			P_1.klxMdkMazIUJPUlFFCZeFKzabgc(P_0.yxqNAesSuAgdwwIXHSRTmXuEixl, P_0.AtLfpFiPJjASASrcRCUZTxBXBMX, P_0.AtLfpFiPJjASASrcRCUZTxBXBMX);
			return true;
		}
		return false;
	}
}
