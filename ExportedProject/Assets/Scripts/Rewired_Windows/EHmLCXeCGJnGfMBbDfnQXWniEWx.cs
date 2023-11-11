using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using Rewired.Utils;

[DefaultMember("Item")]
internal class EHmLCXeCGJnGfMBbDfnQXWniEWx : IEnumerable<byte>, IDisposable, IEnumerable
{
	private struct wIIuRqQPpCSotIKotUtwaSKcGzZ : IEnumerator<byte>, IDisposable, IEnumerator
	{
		private EHmLCXeCGJnGfMBbDfnQXWniEWx MTmrGVsUnwpaXkZjulSnjouaXgm;

		private int DWGzeURffHRKYjiBmbFOkCadibY;

		public byte aCVtGGLpRhphxEagrZJNGKhIoVf => MTmrGVsUnwpaXkZjulSnjouaXgm.get_Item(DWGzeURffHRKYjiBmbFOkCadibY);

		object IEnumerator.dpDWUOawbuZpaVeRAhRUzynXraU => MTmrGVsUnwpaXkZjulSnjouaXgm.get_Item(DWGzeURffHRKYjiBmbFOkCadibY);

		public wIIuRqQPpCSotIKotUtwaSKcGzZ(EHmLCXeCGJnGfMBbDfnQXWniEWx array)
		{
			MTmrGVsUnwpaXkZjulSnjouaXgm = array;
			DWGzeURffHRKYjiBmbFOkCadibY = -1;
		}

		public void Dispose()
		{
		}

		public bool MoveNext()
		{
			if (DWGzeURffHRKYjiBmbFOkCadibY >= MTmrGVsUnwpaXkZjulSnjouaXgm.qyNyXGREMzpucVvRZwjBQRCIORc - 1)
			{
				return false;
			}
			DWGzeURffHRKYjiBmbFOkCadibY++;
			return true;
		}

		public void Reset()
		{
			DWGzeURffHRKYjiBmbFOkCadibY = 0;
		}
	}

	private int qyNyXGREMzpucVvRZwjBQRCIORc;

	private unsafe byte* yxqNAesSuAgdwwIXHSRTmXuEixl;

	public int MaluonABdyiloPnZCFkVkPsyOJnR => qyNyXGREMzpucVvRZwjBQRCIORc;

	public unsafe bool jYuOzlJtihpWwRTDsuTZYrbfQmE
	{
		get
		{
			if (qyNyXGREMzpucVvRZwjBQRCIORc <= 0)
			{
				return true;
			}
			return yxqNAesSuAgdwwIXHSRTmXuEixl != null;
		}
	}

	public unsafe byte GXwEwVpxCBxQxjtzWDWsvqrEoza
	{
		get
		{
			if (index < 0 || index >= qyNyXGREMzpucVvRZwjBQRCIORc)
			{
				throw new IndexOutOfRangeException();
			}
			return yxqNAesSuAgdwwIXHSRTmXuEixl[index];
		}
		set
		{
			if (index < 0 || index >= qyNyXGREMzpucVvRZwjBQRCIORc)
			{
				throw new IndexOutOfRangeException();
			}
			yxqNAesSuAgdwwIXHSRTmXuEixl[index] = value;
		}
	}

	public EHmLCXeCGJnGfMBbDfnQXWniEWx(int length)
	{
		rFIeeoCOnxuyYUiWNbHnOwpRPVS(length);
	}

	public unsafe EHmLCXeCGJnGfMBbDfnQXWniEWx(params byte[] source)
		: this(source.Length)
	{
		Marshal.Copy(source, 0, (IntPtr)yxqNAesSuAgdwwIXHSRTmXuEixl, source.Length);
	}

	public EHmLCXeCGJnGfMBbDfnQXWniEWx(EHmLCXeCGJnGfMBbDfnQXWniEWx source)
		: this(source.qyNyXGREMzpucVvRZwjBQRCIORc)
	{
		source.rHcytPUuIbVYhHfmZvdcnpvFEhL(this, 0, source.qyNyXGREMzpucVvRZwjBQRCIORc);
	}

	public unsafe EHmLCXeCGJnGfMBbDfnQXWniEWx(byte* source, int sourceLength)
		: this(sourceLength)
	{
		mmoBmgIgfOZxbJwkxOjqnWXjRHNq.rdErrbQiKPgCHcdXppfcnDcrDPZ(source, yxqNAesSuAgdwwIXHSRTmXuEixl, 0, 0, sourceLength);
	}

	public unsafe bool rHcytPUuIbVYhHfmZvdcnpvFEhL(byte* P_0, int P_1, int P_2, int P_3, bool P_4 = true)
	{
		if (P_0 == null)
		{
			if (P_4)
			{
				throw new ArgumentNullException("destination");
			}
			return false;
		}
		if (P_2 < 0 || P_2 >= qyNyXGREMzpucVvRZwjBQRCIORc || P_2 >= P_1)
		{
			if (P_4)
			{
				throw new IndexOutOfRangeException("startIndex");
			}
			return false;
		}
		if (P_3 <= 0 || P_3 > qyNyXGREMzpucVvRZwjBQRCIORc || P_3 > P_1)
		{
			if (P_4)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			return false;
		}
		int num = P_3 + P_2;
		if (num >= qyNyXGREMzpucVvRZwjBQRCIORc || num >= P_1)
		{
			if (P_4)
			{
				throw new ArgumentOutOfRangeException("startIndex + length must be < Length of either array");
			}
			return false;
		}
		return mmoBmgIgfOZxbJwkxOjqnWXjRHNq.rdErrbQiKPgCHcdXppfcnDcrDPZ(yxqNAesSuAgdwwIXHSRTmXuEixl, P_0, P_2, P_2, P_3);
	}

	public unsafe bool rHcytPUuIbVYhHfmZvdcnpvFEhL(EHmLCXeCGJnGfMBbDfnQXWniEWx P_0, int P_1, int P_2, bool P_3 = true)
	{
		if (P_0 == null)
		{
			if (P_3)
			{
				throw new ArgumentNullException("destination");
			}
			return false;
		}
		return rHcytPUuIbVYhHfmZvdcnpvFEhL(P_0.yxqNAesSuAgdwwIXHSRTmXuEixl, P_0.qyNyXGREMzpucVvRZwjBQRCIORc, P_1, P_2, P_3);
	}

	public unsafe bool rHcytPUuIbVYhHfmZvdcnpvFEhL(byte[] P_0, int P_1, int P_2, bool P_3 = true)
	{
		if (P_0 == null)
		{
			if (P_3)
			{
				throw new ArgumentNullException("destination");
			}
			return false;
		}
		if (P_1 < 0 || P_1 >= qyNyXGREMzpucVvRZwjBQRCIORc || P_1 >= P_0.Length)
		{
			if (P_3)
			{
				throw new IndexOutOfRangeException("startIndex");
			}
			return false;
		}
		if (P_2 <= 0 || P_2 > qyNyXGREMzpucVvRZwjBQRCIORc || P_2 > P_0.Length)
		{
			if (P_3)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			return false;
		}
		int num = P_2 + P_1;
		if (num >= qyNyXGREMzpucVvRZwjBQRCIORc || num >= P_0.Length)
		{
			if (P_3)
			{
				throw new ArgumentOutOfRangeException("startIndex + length must be < Length of either array");
			}
			return false;
		}
		return NativeTools.CopyMemory((IntPtr)yxqNAesSuAgdwwIXHSRTmXuEixl, P_0, P_1, P_1, P_2, P_3);
	}

	public unsafe bool rHcytPUuIbVYhHfmZvdcnpvFEhL(byte* P_0, int P_1, int P_2, int P_3, int P_4, bool P_5 = true)
	{
		if (P_0 == null)
		{
			if (P_5)
			{
				throw new ArgumentNullException("destination");
			}
			return false;
		}
		if (P_2 < 0 || P_2 >= qyNyXGREMzpucVvRZwjBQRCIORc)
		{
			if (P_5)
			{
				throw new IndexOutOfRangeException("startIndex");
			}
			return false;
		}
		if (P_3 < 0 || P_3 >= P_1)
		{
			if (P_5)
			{
				throw new IndexOutOfRangeException("startIndex");
			}
			return false;
		}
		if (P_4 <= 0 || P_4 > qyNyXGREMzpucVvRZwjBQRCIORc || P_4 > P_1)
		{
			if (P_5)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			return false;
		}
		if (P_4 + P_2 >= qyNyXGREMzpucVvRZwjBQRCIORc)
		{
			if (P_5)
			{
				throw new ArgumentOutOfRangeException("sourceStartIndex + length must be < source.Length");
			}
			return false;
		}
		if (P_4 + P_3 >= P_1)
		{
			if (P_5)
			{
				throw new ArgumentOutOfRangeException("destinationStartIndex + length must be < destination.Length");
			}
			return false;
		}
		return mmoBmgIgfOZxbJwkxOjqnWXjRHNq.rdErrbQiKPgCHcdXppfcnDcrDPZ(yxqNAesSuAgdwwIXHSRTmXuEixl, P_0, P_2, P_3, P_4);
	}

	public unsafe bool rHcytPUuIbVYhHfmZvdcnpvFEhL(EHmLCXeCGJnGfMBbDfnQXWniEWx P_0, int P_1, int P_2, int P_3, bool P_4 = true)
	{
		if (P_0 == null)
		{
			if (P_4)
			{
				throw new ArgumentNullException("destination");
			}
			return false;
		}
		return rHcytPUuIbVYhHfmZvdcnpvFEhL(P_0.yxqNAesSuAgdwwIXHSRTmXuEixl, P_0.qyNyXGREMzpucVvRZwjBQRCIORc, P_1, P_2, P_3, P_4);
	}

	public unsafe bool rHcytPUuIbVYhHfmZvdcnpvFEhL(byte[] P_0, int P_1, int P_2, int P_3, bool P_4 = true)
	{
		if (P_0 == null)
		{
			if (P_4)
			{
				throw new ArgumentNullException("destination");
			}
			return false;
		}
		if (P_1 < 0 || P_1 >= qyNyXGREMzpucVvRZwjBQRCIORc)
		{
			if (P_4)
			{
				throw new IndexOutOfRangeException("startIndex");
			}
			return false;
		}
		if (P_2 < 0 || P_2 >= P_0.Length)
		{
			if (P_4)
			{
				throw new IndexOutOfRangeException("startIndex");
			}
			return false;
		}
		if (P_3 <= 0 || P_3 > qyNyXGREMzpucVvRZwjBQRCIORc || P_3 > P_0.Length)
		{
			if (P_4)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			return false;
		}
		if (P_3 + P_1 >= qyNyXGREMzpucVvRZwjBQRCIORc)
		{
			if (P_4)
			{
				throw new ArgumentOutOfRangeException("sourceStartIndex + length must be < source.Length");
			}
			return false;
		}
		if (P_3 + P_2 >= P_0.Length)
		{
			if (P_4)
			{
				throw new ArgumentOutOfRangeException("destinationStartIndex + length must be < destination.Length");
			}
			return false;
		}
		return NativeTools.CopyMemory((IntPtr)yxqNAesSuAgdwwIXHSRTmXuEixl, P_0, P_1, P_2, P_3, P_4);
	}

	public unsafe bool nZkoBwUthyKWIvAWwWtOlxnPoZB(byte* P_0, int P_1, int P_2, int P_3)
	{
		if (P_0 == null)
		{
			return false;
		}
		if (P_2 >= qyNyXGREMzpucVvRZwjBQRCIORc || P_2 >= P_1)
		{
			return false;
		}
		if (P_2 < 0)
		{
			P_2 = 0;
		}
		int num = P_3 + P_2;
		if (num >= qyNyXGREMzpucVvRZwjBQRCIORc)
		{
			P_3 = qyNyXGREMzpucVvRZwjBQRCIORc - P_2;
		}
		if (num >= P_1)
		{
			P_3 = P_1 - P_2;
		}
		if (P_3 <= 0)
		{
			return false;
		}
		return mmoBmgIgfOZxbJwkxOjqnWXjRHNq.rdErrbQiKPgCHcdXppfcnDcrDPZ(yxqNAesSuAgdwwIXHSRTmXuEixl, P_0, P_2, P_2, P_3);
	}

	public unsafe bool nZkoBwUthyKWIvAWwWtOlxnPoZB(EHmLCXeCGJnGfMBbDfnQXWniEWx P_0, int P_1, int P_2)
	{
		if (P_0 == null)
		{
			return false;
		}
		return nZkoBwUthyKWIvAWwWtOlxnPoZB(P_0.yxqNAesSuAgdwwIXHSRTmXuEixl, P_0.qyNyXGREMzpucVvRZwjBQRCIORc, P_1, P_2);
	}

	public unsafe bool nZkoBwUthyKWIvAWwWtOlxnPoZB(byte[] P_0, int P_1, int P_2)
	{
		if (P_0 == null)
		{
			return false;
		}
		if (P_1 >= qyNyXGREMzpucVvRZwjBQRCIORc || P_1 >= P_0.Length)
		{
			return false;
		}
		if (P_1 < 0)
		{
			P_1 = 0;
		}
		int num = P_2 + P_1;
		if (num >= qyNyXGREMzpucVvRZwjBQRCIORc)
		{
			P_2 = qyNyXGREMzpucVvRZwjBQRCIORc - P_1;
		}
		if (num >= P_0.Length)
		{
			P_2 = P_0.Length - P_1;
		}
		if (P_2 <= 0)
		{
			return false;
		}
		return NativeTools.CopyMemory((IntPtr)yxqNAesSuAgdwwIXHSRTmXuEixl, P_0, P_1, P_1, P_2, throwOnError: false);
	}

	public unsafe bool nZkoBwUthyKWIvAWwWtOlxnPoZB(byte* P_0, int P_1, int P_2, int P_3, int P_4)
	{
		if (P_0 == null)
		{
			return false;
		}
		if (P_2 >= qyNyXGREMzpucVvRZwjBQRCIORc)
		{
			return false;
		}
		if (P_3 >= P_1)
		{
			return false;
		}
		if (P_2 < 0)
		{
			P_2 = 0;
		}
		if (P_3 < 0)
		{
			P_3 = 0;
		}
		if (P_4 + P_2 >= qyNyXGREMzpucVvRZwjBQRCIORc)
		{
			P_4 = qyNyXGREMzpucVvRZwjBQRCIORc - P_2;
		}
		if (P_4 + P_3 >= P_1)
		{
			P_4 = P_1 - P_3;
		}
		if (P_4 <= 0)
		{
			return false;
		}
		return mmoBmgIgfOZxbJwkxOjqnWXjRHNq.rdErrbQiKPgCHcdXppfcnDcrDPZ(yxqNAesSuAgdwwIXHSRTmXuEixl, P_0, P_2, P_3, P_4);
	}

	public unsafe bool nZkoBwUthyKWIvAWwWtOlxnPoZB(EHmLCXeCGJnGfMBbDfnQXWniEWx P_0, int P_1, int P_2, int P_3)
	{
		if (P_0 == null)
		{
			return false;
		}
		return nZkoBwUthyKWIvAWwWtOlxnPoZB(P_0.yxqNAesSuAgdwwIXHSRTmXuEixl, P_0.qyNyXGREMzpucVvRZwjBQRCIORc, P_1, P_2, P_3);
	}

	public unsafe bool nZkoBwUthyKWIvAWwWtOlxnPoZB(byte[] P_0, int P_1, int P_2, int P_3)
	{
		if (P_0 == null)
		{
			return false;
		}
		if (P_1 >= qyNyXGREMzpucVvRZwjBQRCIORc)
		{
			return false;
		}
		if (P_2 >= P_0.Length)
		{
			return false;
		}
		if (P_1 < 0)
		{
			P_1 = 0;
		}
		if (P_2 < 0)
		{
			P_2 = 0;
		}
		if (P_3 + P_1 >= qyNyXGREMzpucVvRZwjBQRCIORc)
		{
			P_3 = qyNyXGREMzpucVvRZwjBQRCIORc - P_1;
		}
		if (P_3 + P_2 >= P_0.Length)
		{
			P_3 = P_0.Length - P_2;
		}
		if (P_3 <= 0)
		{
			return false;
		}
		return NativeTools.CopyMemory((IntPtr)yxqNAesSuAgdwwIXHSRTmXuEixl, P_0, P_1, P_2, P_3, throwOnError: false);
	}

	public void CUriAZlnkhHKWMbqmUZRRQCwExz(int P_0)
	{
		if (P_0 < 0)
		{
			throw new ArgumentOutOfRangeException("length must be >= 0");
		}
		if (qyNyXGREMzpucVvRZwjBQRCIORc != P_0)
		{
			rFIeeoCOnxuyYUiWNbHnOwpRPVS(P_0);
		}
	}

	public unsafe void xZveeqhZWQBoifJNrEKvhlbeSAk()
	{
		if (qyNyXGREMzpucVvRZwjBQRCIORc != 0 && yxqNAesSuAgdwwIXHSRTmXuEixl != null)
		{
			mmoBmgIgfOZxbJwkxOjqnWXjRHNq.bGpIVheXGTlHwcOjeZjjwzNPsjN(yxqNAesSuAgdwwIXHSRTmXuEixl, qyNyXGREMzpucVvRZwjBQRCIORc);
		}
	}

	private unsafe void rFIeeoCOnxuyYUiWNbHnOwpRPVS(int P_0)
	{
		if (P_0 == qyNyXGREMzpucVvRZwjBQRCIORc)
		{
			xZveeqhZWQBoifJNrEKvhlbeSAk();
			return;
		}
		if (qyNyXGREMzpucVvRZwjBQRCIORc > 0)
		{
			ikNikjZpFVgJxtEYtCKCkLfaVaC();
		}
		yxqNAesSuAgdwwIXHSRTmXuEixl = (byte*)(void*)Marshal.AllocHGlobal(P_0);
		if (yxqNAesSuAgdwwIXHSRTmXuEixl == null)
		{
			throw new Exception("Could not allocate memory for array.");
		}
		qyNyXGREMzpucVvRZwjBQRCIORc = P_0;
		xZveeqhZWQBoifJNrEKvhlbeSAk();
	}

	private unsafe void ikNikjZpFVgJxtEYtCKCkLfaVaC()
	{
		if (yxqNAesSuAgdwwIXHSRTmXuEixl != null)
		{
			Marshal.FreeHGlobal((IntPtr)yxqNAesSuAgdwwIXHSRTmXuEixl);
		}
		yxqNAesSuAgdwwIXHSRTmXuEixl = null;
		qyNyXGREMzpucVvRZwjBQRCIORc = 0;
	}

	public void Dispose()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(true);
		GC.SuppressFinalize(this);
	}

	~EHmLCXeCGJnGfMBbDfnQXWniEWx()
	{
		PMzamCeIIFqnzgwGlxEbIeTHBFUL(false);
	}

	protected void PMzamCeIIFqnzgwGlxEbIeTHBFUL(bool P_0)
	{
		ikNikjZpFVgJxtEYtCKCkLfaVaC();
	}

	public IEnumerator<byte> GetEnumerator()
	{
		return new wIIuRqQPpCSotIKotUtwaSKcGzZ(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return new wIIuRqQPpCSotIKotUtwaSKcGzZ(this);
	}
}
