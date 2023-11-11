using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Rewired.Utils;

[DefaultMember("Item")]
internal class lBtCqyMMPoOESvOySJrJDmKGcDL : IDisposable
{
	private readonly byte[] RBtRonCEgaNDwiemTOAXtCdIbNk;

	public readonly int MaluonABdyiloPnZCFkVkPsyOJnR;

	private GCHandle GCSBCEymLHrTIzqdggaviCSGOwYq;

	private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

	public bool hmtFCWkETKjOeEVvCLIAQpSjJYCa => GCSBCEymLHrTIzqdggaviCSGOwYq.IsAllocated;

	public byte GXwEwVpxCBxQxjtzWDWsvqrEoza
	{
		get
		{
			return RBtRonCEgaNDwiemTOAXtCdIbNk[index];
		}
		set
		{
			RBtRonCEgaNDwiemTOAXtCdIbNk[index] = value;
		}
	}

	public lBtCqyMMPoOESvOySJrJDmKGcDL(int size)
	{
		if (size < 0)
		{
			throw new ArgumentOutOfRangeException("size must be > 0");
		}
		MaluonABdyiloPnZCFkVkPsyOJnR = size;
		RBtRonCEgaNDwiemTOAXtCdIbNk = new byte[size];
	}

	public IntPtr IMQgdodeaMKykSQFguKRutQHRjOs()
	{
		if (GCSBCEymLHrTIzqdggaviCSGOwYq.IsAllocated)
		{
			return GCSBCEymLHrTIzqdggaviCSGOwYq.AddrOfPinnedObject();
		}
		GCSBCEymLHrTIzqdggaviCSGOwYq = GCHandle.Alloc(RBtRonCEgaNDwiemTOAXtCdIbNk, GCHandleType.Pinned);
		return GCSBCEymLHrTIzqdggaviCSGOwYq.AddrOfPinnedObject();
	}

	public void nAHWlQfnxYOIfStOwuSoxGSGdhp()
	{
		if (GCSBCEymLHrTIzqdggaviCSGOwYq.IsAllocated)
		{
			GCSBCEymLHrTIzqdggaviCSGOwYq.Free();
		}
	}

	public string YtleImjCPmDHfZTQJsNERqPlpwY()
	{
		string text = "";
		for (int i = 0; i < MaluonABdyiloPnZCFkVkPsyOJnR; i++)
		{
			text = text + RBtRonCEgaNDwiemTOAXtCdIbNk[i].ToString("x2") + " ";
		}
		return text;
	}

	public bool EjHceJbxNPSegSyaBKTbdfigrogM(int P_0, byte P_1)
	{
		if (1 + P_0 > MaluonABdyiloPnZCFkVkPsyOJnR || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("byteIndex");
		}
		if (P_1 >= 8)
		{
			throw new ArgumentOutOfRangeException("bit");
		}
		return (RBtRonCEgaNDwiemTOAXtCdIbNk[P_0] & (1 << (int)P_1)) != 0;
	}

	public byte yVjbZKGhFbPVCUPDDAGVfgBuXHG(int P_0)
	{
		if (1 + P_0 > MaluonABdyiloPnZCFkVkPsyOJnR || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		return RBtRonCEgaNDwiemTOAXtCdIbNk[P_0];
	}

	public unsafe short zViBYeBHdzTnYPFMTjboQJAJXzG(int P_0)
	{
		if (2 + P_0 > MaluonABdyiloPnZCFkVkPsyOJnR || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		fixed (byte* ptr = RBtRonCEgaNDwiemTOAXtCdIbNk)
		{
			return *(short*)(ptr + P_0);
		}
	}

	public unsafe ushort xFEnNDCHXMwYycuwTbRRaVPJuen(int P_0)
	{
		if (2 + P_0 > MaluonABdyiloPnZCFkVkPsyOJnR || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		fixed (byte* ptr = RBtRonCEgaNDwiemTOAXtCdIbNk)
		{
			return *(ushort*)(ptr + P_0);
		}
	}

	public unsafe int uJELFssVtNDhscqCvkBwSNPRnmF(int P_0)
	{
		if (4 + P_0 > MaluonABdyiloPnZCFkVkPsyOJnR || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		fixed (byte* ptr = RBtRonCEgaNDwiemTOAXtCdIbNk)
		{
			return *(int*)(ptr + P_0);
		}
	}

	public unsafe uint SywQpLSMLMVMHauHwAQQSVWJJwb(int P_0)
	{
		if (4 + P_0 > MaluonABdyiloPnZCFkVkPsyOJnR || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		fixed (byte* ptr = RBtRonCEgaNDwiemTOAXtCdIbNk)
		{
			return *(uint*)(ptr + P_0);
		}
	}

	public unsafe long XMdHyrnlBdtBbNJyklZkCnEwFrf(int P_0)
	{
		if (8 + P_0 > MaluonABdyiloPnZCFkVkPsyOJnR || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		fixed (byte* ptr = RBtRonCEgaNDwiemTOAXtCdIbNk)
		{
			return *(long*)(ptr + P_0);
		}
	}

	public unsafe ulong XYHhJZmgzSCTNKFUIqspGjtqqhrR(int P_0)
	{
		if (8 + P_0 > MaluonABdyiloPnZCFkVkPsyOJnR || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		fixed (byte* ptr = RBtRonCEgaNDwiemTOAXtCdIbNk)
		{
			return *(ulong*)(ptr + P_0);
		}
	}

	public void BJrAAaIAGcmOVdfUIHHCJXemriPD(byte[] P_0, int P_1, int P_2 = 0, int P_3 = 0)
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
		if (P_1 > MaluonABdyiloPnZCFkVkPsyOJnR)
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
		if (P_2 >= MaluonABdyiloPnZCFkVkPsyOJnR)
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
		if (P_1 + P_2 > MaluonABdyiloPnZCFkVkPsyOJnR)
		{
			throw new ArgumentOutOfRangeException("numBytesToRead + readStartIndex must be < Length.");
		}
		Array.Copy(RBtRonCEgaNDwiemTOAXtCdIbNk, P_2, P_0, P_3, P_1);
	}

	public void BJrAAaIAGcmOVdfUIHHCJXemriPD(IntPtr P_0, int P_1, int P_2, int P_3 = 0, int P_4 = 0)
	{
		if (P_0 == IntPtr.Zero)
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
		if (P_2 > MaluonABdyiloPnZCFkVkPsyOJnR)
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
		if (P_3 >= MaluonABdyiloPnZCFkVkPsyOJnR)
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
		if (P_2 + P_3 > MaluonABdyiloPnZCFkVkPsyOJnR)
		{
			throw new ArgumentOutOfRangeException("numBytesToRead + readStartIndex must be < Length.");
		}
		NativeTools.CopyMemory(RBtRonCEgaNDwiemTOAXtCdIbNk, P_0, P_3, P_4, P_2);
	}

	public int KtdFVPWbuczWQlMquhIGGlqiuHS(byte[] P_0, int P_1, int P_2 = 0, int P_3 = 0)
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
		if (P_2 >= MaluonABdyiloPnZCFkVkPsyOJnR)
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
		if (P_2 + P_1 > MaluonABdyiloPnZCFkVkPsyOJnR)
		{
			P_1 = MaluonABdyiloPnZCFkVkPsyOJnR - P_2;
		}
		if (P_3 + P_1 > num)
		{
			P_1 = num - P_3;
		}
		if (P_1 == 0)
		{
			return 0;
		}
		Array.Copy(RBtRonCEgaNDwiemTOAXtCdIbNk, P_2, P_0, P_3, P_1);
		return P_1;
	}

	public int KtdFVPWbuczWQlMquhIGGlqiuHS(IntPtr P_0, int P_1, int P_2, int P_3 = 0, int P_4 = 0)
	{
		if (P_0 == IntPtr.Zero || P_2 <= 0)
		{
			return 0;
		}
		if (P_3 >= MaluonABdyiloPnZCFkVkPsyOJnR)
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
		if (P_3 + P_2 > MaluonABdyiloPnZCFkVkPsyOJnR)
		{
			P_2 = MaluonABdyiloPnZCFkVkPsyOJnR - P_3;
		}
		if (P_4 + P_2 > P_1)
		{
			P_2 = P_1 - P_4;
		}
		NativeTools.CopyMemory(RBtRonCEgaNDwiemTOAXtCdIbNk, P_0, P_3, P_4, P_2);
		return P_2;
	}

	public void iLXYCLxdusFkzaetKgcdZJqZMKuF(int P_0, byte P_1, bool P_2)
	{
		if (1 + P_0 > MaluonABdyiloPnZCFkVkPsyOJnR || P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("byteIndex");
		}
		if (P_1 >= 8)
		{
			throw new ArgumentOutOfRangeException("bit");
		}
		if (P_2)
		{
			RBtRonCEgaNDwiemTOAXtCdIbNk[P_0] |= (byte)(1 << (int)P_1);
		}
		else
		{
			RBtRonCEgaNDwiemTOAXtCdIbNk[P_0] &= (byte)(~(1 << (int)P_1));
		}
	}

	public void klxMdkMazIUJPUlFFCZeFKzabgc(byte P_0, int P_1)
	{
		if (1 + P_1 > MaluonABdyiloPnZCFkVkPsyOJnR || P_1 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		RBtRonCEgaNDwiemTOAXtCdIbNk[P_1] = P_0;
	}

	public unsafe void klxMdkMazIUJPUlFFCZeFKzabgc(short P_0, int P_1)
	{
		if (2 + P_1 > MaluonABdyiloPnZCFkVkPsyOJnR || P_1 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		fixed (byte* ptr = RBtRonCEgaNDwiemTOAXtCdIbNk)
		{
			*(short*)(ptr + P_1) = P_0;
		}
	}

	public unsafe void klxMdkMazIUJPUlFFCZeFKzabgc(ushort P_0, int P_1)
	{
		if (2 + P_1 > MaluonABdyiloPnZCFkVkPsyOJnR || P_1 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		fixed (byte* ptr = RBtRonCEgaNDwiemTOAXtCdIbNk)
		{
			*(ushort*)(ptr + P_1) = P_0;
		}
	}

	public unsafe void klxMdkMazIUJPUlFFCZeFKzabgc(int P_0, int P_1)
	{
		if (4 + P_1 > MaluonABdyiloPnZCFkVkPsyOJnR || P_1 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		fixed (byte* ptr = RBtRonCEgaNDwiemTOAXtCdIbNk)
		{
			*(int*)(ptr + P_1) = P_0;
		}
	}

	public unsafe void klxMdkMazIUJPUlFFCZeFKzabgc(uint P_0, int P_1)
	{
		if (4 + P_1 > MaluonABdyiloPnZCFkVkPsyOJnR || P_1 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		fixed (byte* ptr = RBtRonCEgaNDwiemTOAXtCdIbNk)
		{
			*(uint*)(ptr + P_1) = P_0;
		}
	}

	public unsafe void klxMdkMazIUJPUlFFCZeFKzabgc(long P_0, int P_1)
	{
		if (8 + P_1 > MaluonABdyiloPnZCFkVkPsyOJnR || P_1 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		fixed (byte* ptr = RBtRonCEgaNDwiemTOAXtCdIbNk)
		{
			*(long*)(ptr + P_1) = P_0;
		}
	}

	public unsafe void klxMdkMazIUJPUlFFCZeFKzabgc(ulong P_0, int P_1)
	{
		if (8 + P_1 > MaluonABdyiloPnZCFkVkPsyOJnR || P_1 < 0)
		{
			throw new ArgumentOutOfRangeException("startIndex");
		}
		fixed (byte* ptr = RBtRonCEgaNDwiemTOAXtCdIbNk)
		{
			*(ulong*)(ptr + P_1) = P_0;
		}
	}

	public void klxMdkMazIUJPUlFFCZeFKzabgc(byte[] P_0, int P_1, int P_2 = 0, int P_3 = 0)
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
		if (P_1 > MaluonABdyiloPnZCFkVkPsyOJnR)
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
		if (P_2 >= MaluonABdyiloPnZCFkVkPsyOJnR)
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
		if (P_1 + P_2 > MaluonABdyiloPnZCFkVkPsyOJnR)
		{
			throw new ArgumentOutOfRangeException("numBytesToWrite + writeStartIndex must be < Length.");
		}
		Array.Copy(P_0, P_3, RBtRonCEgaNDwiemTOAXtCdIbNk, P_2, P_1);
	}

	public void klxMdkMazIUJPUlFFCZeFKzabgc(IntPtr P_0, int P_1, int P_2, int P_3 = 0, int P_4 = 0)
	{
		if (P_0 == IntPtr.Zero)
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
		if (P_2 > MaluonABdyiloPnZCFkVkPsyOJnR)
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
		if (P_3 >= MaluonABdyiloPnZCFkVkPsyOJnR)
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
		if (P_2 + P_3 > MaluonABdyiloPnZCFkVkPsyOJnR)
		{
			throw new ArgumentOutOfRangeException("numBytesToWrite + writeStartIndex must be < Length.");
		}
		NativeTools.CopyMemory(P_0, RBtRonCEgaNDwiemTOAXtCdIbNk, P_4, P_3, P_2);
	}

	public int ogtAcQGaIHtxEbgvVwyqUNboON(byte[] P_0, int P_1, int P_2 = 0, int P_3 = 0)
	{
		if (P_0 == null)
		{
			return 0;
		}
		int num = P_0.Length;
		if (num == 0 || P_1 <= 0 || P_3 >= num || P_2 >= MaluonABdyiloPnZCFkVkPsyOJnR)
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
		if (P_1 + P_2 > MaluonABdyiloPnZCFkVkPsyOJnR)
		{
			P_1 = MaluonABdyiloPnZCFkVkPsyOJnR - P_2;
		}
		Array.Copy(P_0, P_3, RBtRonCEgaNDwiemTOAXtCdIbNk, P_2, P_1);
		return P_1;
	}

	public int ogtAcQGaIHtxEbgvVwyqUNboON(IntPtr P_0, int P_1, int P_2, int P_3 = 0, int P_4 = 0)
	{
		if (P_0 == IntPtr.Zero || P_1 <= 0 || P_2 <= 0 || P_4 >= P_1 || P_3 >= MaluonABdyiloPnZCFkVkPsyOJnR)
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
		if (P_2 + P_3 > MaluonABdyiloPnZCFkVkPsyOJnR)
		{
			P_2 = MaluonABdyiloPnZCFkVkPsyOJnR - P_3;
		}
		NativeTools.CopyMemory(P_0, RBtRonCEgaNDwiemTOAXtCdIbNk, P_4, P_3, P_2);
		return P_2;
	}

	public void xZveeqhZWQBoifJNrEKvhlbeSAk()
	{
		Array.Clear(RBtRonCEgaNDwiemTOAXtCdIbNk, 0, MaluonABdyiloPnZCFkVkPsyOJnR);
	}

	public override string ToString()
	{
		string text = "";
		for (int i = 0; i < MaluonABdyiloPnZCFkVkPsyOJnR; i++)
		{
			text = text + this.get_Item(i).ToString("x2") + " ";
		}
		return text;
	}

	public void Dispose()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
		GC.SuppressFinalize(this);
	}

	~lBtCqyMMPoOESvOySJrJDmKGcDL()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
	}

	protected virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (!jpnIPbpqmlecdiNqaFAxiNCsiMxs)
		{
			if (GCSBCEymLHrTIzqdggaviCSGOwYq.IsAllocated)
			{
				GCSBCEymLHrTIzqdggaviCSGOwYq.Free();
			}
			jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
		}
	}

	public static void aihWTPtNABTEsdOhuiIyFEfdHeSd(lBtCqyMMPoOESvOySJrJDmKGcDL P_0, lBtCqyMMPoOESvOySJrJDmKGcDL P_1, int P_2)
	{
		Array.Copy(P_0.RBtRonCEgaNDwiemTOAXtCdIbNk, P_1.RBtRonCEgaNDwiemTOAXtCdIbNk, P_2);
	}

	public static void aihWTPtNABTEsdOhuiIyFEfdHeSd(lBtCqyMMPoOESvOySJrJDmKGcDL P_0, int P_1, lBtCqyMMPoOESvOySJrJDmKGcDL P_2, int P_3, int P_4)
	{
		Array.Copy(P_0.RBtRonCEgaNDwiemTOAXtCdIbNk, P_1, P_2.RBtRonCEgaNDwiemTOAXtCdIbNk, P_3, P_4);
	}
}
