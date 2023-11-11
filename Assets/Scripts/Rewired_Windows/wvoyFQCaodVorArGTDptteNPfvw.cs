using System;

internal class wvoyFQCaodVorArGTDptteNPfvw : IDisposable
{
	private readonly ONekLqHMuFNjUEgkbJeXaixhKbtZ RBtRonCEgaNDwiemTOAXtCdIbNk;

	private bool[] pIuIcdFjTzwcbBldUldKAWoSeJK;

	protected readonly int POVZQdbtQUVoozxFCsmzIRLIYGS;

	protected readonly int qyNyXGREMzpucVvRZwjBQRCIORc;

	private bool jpnIPbpqmlecdiNqaFAxiNCsiMxs;

	public int zJhmePcAAIBIGjjAVoZbLCSDWXW => POVZQdbtQUVoozxFCsmzIRLIYGS;

	public int MaluonABdyiloPnZCFkVkPsyOJnR => qyNyXGREMzpucVvRZwjBQRCIORc;

	public bool[] fBEDawXfJQROZzavTBcsPYYrgse => pIuIcdFjTzwcbBldUldKAWoSeJK ?? (pIuIcdFjTzwcbBldUldKAWoSeJK = new bool[POVZQdbtQUVoozxFCsmzIRLIYGS]);

	public wvoyFQCaodVorArGTDptteNPfvw(int length, int valueBitSize)
	{
		if (length <= 0)
		{
			throw new ArgumentOutOfRangeException("length");
		}
		if (valueBitSize <= 0)
		{
			throw new ArgumentOutOfRangeException("entryBitSize");
		}
		qyNyXGREMzpucVvRZwjBQRCIORc = length;
		POVZQdbtQUVoozxFCsmzIRLIYGS = valueBitSize;
		int num = length * valueBitSize;
		RBtRonCEgaNDwiemTOAXtCdIbNk = new ONekLqHMuFNjUEgkbJeXaixhKbtZ(num / 8 + ((num % 8 != 0) ? 1 : 0));
	}

	public unsafe void NuvzugUZDfrUIDfyWDWrzXgIdAZ(int P_0, byte* P_1, int P_2)
	{
		if (P_0 < 0 || P_0 >= qyNyXGREMzpucVvRZwjBQRCIORc)
		{
			throw new IndexOutOfRangeException("index");
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (P_2 < POVZQdbtQUVoozxFCsmzIRLIYGS)
		{
			throw new Exception("Buffer is too small to hold the data. Must be at least " + POVZQdbtQUVoozxFCsmzIRLIYGS + " bits.");
		}
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < POVZQdbtQUVoozxFCsmzIRLIYGS; i++)
		{
			vnXlcWFFbVcZZFhxJnPynuIRdqg(P_0, i, out var num3, out var b);
			P_1[i] = (RBtRonCEgaNDwiemTOAXtCdIbNk.EjHceJbxNPSegSyaBKTbdfigrogM(num3, b) ? ((byte)(P_1[num] | (1 << num2))) : ((byte)(P_1[num] & ~(1 << num2))));
			num2++;
			if (num2 >= 8)
			{
				num++;
				num2 = 0;
			}
		}
	}

	public unsafe void NuvzugUZDfrUIDfyWDWrzXgIdAZ(int P_0, IntPtr P_1, int P_2)
	{
		if (P_1 == IntPtr.Zero)
		{
			throw new ArgumentNullException("buffer");
		}
		NuvzugUZDfrUIDfyWDWrzXgIdAZ(P_0, (byte*)(void*)P_1, P_2);
	}

	public unsafe void NuvzugUZDfrUIDfyWDWrzXgIdAZ(int P_0, out byte P_1)
	{
		byte b = 0;
		byte* ptr = &b;
		NuvzugUZDfrUIDfyWDWrzXgIdAZ(P_0, ptr, 64);
		P_1 = b;
	}

	public void NuvzugUZDfrUIDfyWDWrzXgIdAZ(int P_0, out sbyte P_1)
	{
		NuvzugUZDfrUIDfyWDWrzXgIdAZ(P_0, out byte b);
		P_1 = (sbyte)b;
	}

	public unsafe void NuvzugUZDfrUIDfyWDWrzXgIdAZ(int P_0, out short P_1)
	{
		short num = 0;
		byte* ptr = (byte*)(&num);
		NuvzugUZDfrUIDfyWDWrzXgIdAZ(P_0, ptr, 64);
		P_1 = num;
	}

	public void NuvzugUZDfrUIDfyWDWrzXgIdAZ(int P_0, out ushort P_1)
	{
		NuvzugUZDfrUIDfyWDWrzXgIdAZ(P_0, out short num);
		P_1 = (ushort)num;
	}

	public unsafe void NuvzugUZDfrUIDfyWDWrzXgIdAZ(int P_0, out int P_1)
	{
		int num = 0;
		byte* ptr = (byte*)(&num);
		NuvzugUZDfrUIDfyWDWrzXgIdAZ(P_0, ptr, 64);
		P_1 = num;
	}

	public void NuvzugUZDfrUIDfyWDWrzXgIdAZ(int P_0, out uint P_1)
	{
		NuvzugUZDfrUIDfyWDWrzXgIdAZ(P_0, out int num);
		P_1 = (uint)num;
	}

	public unsafe void NuvzugUZDfrUIDfyWDWrzXgIdAZ(int P_0, out long P_1)
	{
		long num = 0L;
		byte* ptr = (byte*)(&num);
		NuvzugUZDfrUIDfyWDWrzXgIdAZ(P_0, ptr, 64);
		P_1 = num;
	}

	public void NuvzugUZDfrUIDfyWDWrzXgIdAZ(int P_0, out ulong P_1)
	{
		NuvzugUZDfrUIDfyWDWrzXgIdAZ(P_0, out long num);
		P_1 = (ulong)num;
	}

	public void NuvzugUZDfrUIDfyWDWrzXgIdAZ(int P_0, bool[] P_1)
	{
		if (P_0 < 0 || P_0 >= qyNyXGREMzpucVvRZwjBQRCIORc)
		{
			throw new IndexOutOfRangeException("index");
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException("valueBuffer");
		}
		if (P_1.Length < POVZQdbtQUVoozxFCsmzIRLIYGS)
		{
			throw new Exception("valueBuffer.Length must be >= " + POVZQdbtQUVoozxFCsmzIRLIYGS);
		}
		for (int i = 0; i < POVZQdbtQUVoozxFCsmzIRLIYGS; i++)
		{
			vnXlcWFFbVcZZFhxJnPynuIRdqg(P_0, i, out var num, out var b);
			P_1[i] = RBtRonCEgaNDwiemTOAXtCdIbNk.EjHceJbxNPSegSyaBKTbdfigrogM(num, b);
		}
	}

	public unsafe void vAhUQyfIrMhjhGAJbutJOWoJXiD(int P_0, byte* P_1, int P_2)
	{
		if (P_0 < 0 || P_0 >= qyNyXGREMzpucVvRZwjBQRCIORc)
		{
			throw new IndexOutOfRangeException("index");
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException("buffer");
		}
		if (P_2 <= 0)
		{
			throw new Exception("bufferSize must be >= 0");
		}
		int num = 0;
		int num2 = 0;
		for (int i = 0; i < POVZQdbtQUVoozxFCsmzIRLIYGS; i++)
		{
			vnXlcWFFbVcZZFhxJnPynuIRdqg(P_0, i, out var num3, out var b);
			bool flag = i < P_2 && (flag = (P_1[num] & (1 << num2)) != 0);
			RBtRonCEgaNDwiemTOAXtCdIbNk.iLXYCLxdusFkzaetKgcdZJqZMKuF(num3, b, flag);
			num2++;
			if (num2 >= 8)
			{
				num++;
				num2 = 0;
			}
		}
	}

	public unsafe void vAhUQyfIrMhjhGAJbutJOWoJXiD(int P_0, IntPtr P_1, int P_2)
	{
		if (P_1 == IntPtr.Zero)
		{
			throw new ArgumentNullException("buffer");
		}
		vAhUQyfIrMhjhGAJbutJOWoJXiD(P_0, (byte*)(void*)P_1, P_2);
	}

	public unsafe void vAhUQyfIrMhjhGAJbutJOWoJXiD(int P_0, byte P_1)
	{
		byte* ptr = &P_1;
		vAhUQyfIrMhjhGAJbutJOWoJXiD(P_0, ptr, 8);
	}

	public void vAhUQyfIrMhjhGAJbutJOWoJXiD(int P_0, sbyte P_1)
	{
		vAhUQyfIrMhjhGAJbutJOWoJXiD(P_0, (byte)P_1);
	}

	public unsafe void vAhUQyfIrMhjhGAJbutJOWoJXiD(int P_0, short P_1)
	{
		byte* ptr = (byte*)(&P_1);
		vAhUQyfIrMhjhGAJbutJOWoJXiD(P_0, ptr, 16);
	}

	public void vAhUQyfIrMhjhGAJbutJOWoJXiD(int P_0, ushort P_1)
	{
		vAhUQyfIrMhjhGAJbutJOWoJXiD(P_0, (short)P_1);
	}

	public unsafe void vAhUQyfIrMhjhGAJbutJOWoJXiD(int P_0, int P_1)
	{
		byte* ptr = (byte*)(&P_1);
		vAhUQyfIrMhjhGAJbutJOWoJXiD(P_0, ptr, 32);
	}

	public void vAhUQyfIrMhjhGAJbutJOWoJXiD(int P_0, uint P_1)
	{
		vAhUQyfIrMhjhGAJbutJOWoJXiD(P_0, (int)P_1);
	}

	public unsafe void vAhUQyfIrMhjhGAJbutJOWoJXiD(int P_0, long P_1)
	{
		byte* ptr = (byte*)(&P_1);
		vAhUQyfIrMhjhGAJbutJOWoJXiD(P_0, ptr, 64);
	}

	public void vAhUQyfIrMhjhGAJbutJOWoJXiD(int P_0, ulong P_1)
	{
		vAhUQyfIrMhjhGAJbutJOWoJXiD(P_0, (long)P_1);
	}

	public void vAhUQyfIrMhjhGAJbutJOWoJXiD(int P_0, bool[] P_1)
	{
		if (P_0 < 0 || P_0 >= qyNyXGREMzpucVvRZwjBQRCIORc)
		{
			throw new IndexOutOfRangeException("index");
		}
		if (P_1 == null)
		{
			throw new ArgumentNullException("valueBuffer");
		}
		if (P_1.Length < POVZQdbtQUVoozxFCsmzIRLIYGS)
		{
			throw new Exception("valueBuffer.Length must be >= " + POVZQdbtQUVoozxFCsmzIRLIYGS);
		}
		for (int i = 0; i < POVZQdbtQUVoozxFCsmzIRLIYGS; i++)
		{
			vnXlcWFFbVcZZFhxJnPynuIRdqg(P_0, i, out var num, out var b);
			RBtRonCEgaNDwiemTOAXtCdIbNk.iLXYCLxdusFkzaetKgcdZJqZMKuF(num, b, P_1[i]);
		}
	}

	private void vnXlcWFFbVcZZFhxJnPynuIRdqg(int P_0, int P_1, out int P_2, out byte P_3)
	{
		if (P_0 < 0 || P_0 >= qyNyXGREMzpucVvRZwjBQRCIORc)
		{
			throw new IndexOutOfRangeException("entryIndex");
		}
		if (P_1 < 0 || P_1 >= POVZQdbtQUVoozxFCsmzIRLIYGS)
		{
			throw new ArgumentOutOfRangeException("bitOffset");
		}
		int num = P_0 * POVZQdbtQUVoozxFCsmzIRLIYGS + P_1;
		P_2 = num / POVZQdbtQUVoozxFCsmzIRLIYGS;
		P_3 = (byte)(num - P_2 * POVZQdbtQUVoozxFCsmzIRLIYGS);
	}

	private int zlmfQaFQquHiMaLnvhYcrWloqIF(int P_0, out byte P_1)
	{
		if (P_0 < 0 || P_0 >= qyNyXGREMzpucVvRZwjBQRCIORc * POVZQdbtQUVoozxFCsmzIRLIYGS)
		{
			throw new IndexOutOfRangeException("bitIndex");
		}
		int num = P_0 / POVZQdbtQUVoozxFCsmzIRLIYGS;
		P_1 = (byte)(P_0 - num * POVZQdbtQUVoozxFCsmzIRLIYGS);
		return num;
	}

	public void Dispose()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
		GC.SuppressFinalize(this);
	}

	~wvoyFQCaodVorArGTDptteNPfvw()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
	}

	protected virtual void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		if (!jpnIPbpqmlecdiNqaFAxiNCsiMxs)
		{
			if (P_0 && RBtRonCEgaNDwiemTOAXtCdIbNk != null)
			{
				RBtRonCEgaNDwiemTOAXtCdIbNk.Dispose();
			}
			jpnIPbpqmlecdiNqaFAxiNCsiMxs = true;
		}
	}
}
