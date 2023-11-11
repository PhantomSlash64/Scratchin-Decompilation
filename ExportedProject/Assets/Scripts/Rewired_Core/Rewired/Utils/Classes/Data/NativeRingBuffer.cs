using System;

namespace Rewired.Utils.Classes.Data
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class NativeRingBuffer : IDisposable
	{
		private readonly NativeBuffer vsYfOtbYOjMAnAjcjAveBMNaFSiw;

		private readonly int nfDdeELnrQwKNlRDjFNLWWngAhc;

		private long QtjobTKVLyjHsrPieyDyCIQEbUt;

		private long DUndgkjlhdXIcpMpKSDjzSlhNxI;

		private int DTYPKUyuHFRdYjEeshALSuzUdaq;

		private bool lGVohtghaMnjZcBUIuCAsygqDjP;

		private uint qyFPRvidXCioTrlpLgPCGEAsLKcM;

		private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

		public int Capacity => nfDdeELnrQwKNlRDjFNLWWngAhc;

		public int BytesInBuffer => DTYPKUyuHFRdYjEeshALSuzUdaq;

		public bool BufferOverrun => lGVohtghaMnjZcBUIuCAsygqDjP;

		public int ReadPosition => (int)DUndgkjlhdXIcpMpKSDjzSlhNxI;

		public long WritePosition => QtjobTKVLyjHsrPieyDyCIQEbUt;

		public NativeRingBuffer(int capacity)
		{
			nfDdeELnrQwKNlRDjFNLWWngAhc = capacity;
			if (capacity <= 0)
			{
				throw new ArgumentOutOfRangeException("sizeInBytes");
			}
			vsYfOtbYOjMAnAjcjAveBMNaFSiw = new NativeBuffer(capacity);
		}

		public IntPtr Allocate(int bufferLength, bool zeroFill, out uint passId)
		{
			IntPtr pointer = vsYfOtbYOjMAnAjcjAveBMNaFSiw.GetPointer((int)QtjobTKVLyjHsrPieyDyCIQEbUt);
			passId = qyFPRvidXCioTrlpLgPCGEAsLKcM;
			if (zeroFill)
			{
				int num = 0;
				vsYfOtbYOjMAnAjcjAveBMNaFSiw.TryFill(0, bufferLength, (int)QtjobTKVLyjHsrPieyDyCIQEbUt);
				if (num == 0)
				{
					return IntPtr.Zero;
				}
				if (num < bufferLength)
				{
					num += vsYfOtbYOjMAnAjcjAveBMNaFSiw.TryFill(0, bufferLength - num, num);
				}
			}
			xRDzsPTlVmFZqigsUYmlcNtVYolR(bufferLength);
			return pointer;
		}

		public int Write(IntPtr buffer, int bufferLength, int numBytesToWrite, out int startOffset, out uint passId)
		{
			startOffset = (int)QtjobTKVLyjHsrPieyDyCIQEbUt;
			passId = qyFPRvidXCioTrlpLgPCGEAsLKcM;
			if (buffer == IntPtr.Zero || bufferLength <= 0 || numBytesToWrite <= 0)
			{
				return 0;
			}
			if (numBytesToWrite > bufferLength)
			{
				numBytesToWrite = bufferLength;
			}
			int num = vsYfOtbYOjMAnAjcjAveBMNaFSiw.TryWriteBytes(buffer, bufferLength, numBytesToWrite, (int)QtjobTKVLyjHsrPieyDyCIQEbUt);
			if (num == 0)
			{
				return 0;
			}
			if (num < numBytesToWrite)
			{
				num += vsYfOtbYOjMAnAjcjAveBMNaFSiw.TryWriteBytes(buffer, bufferLength, numBytesToWrite - num, 0, num);
			}
			xRDzsPTlVmFZqigsUYmlcNtVYolR(num);
			return num;
		}

		public int Write(byte[] buffer, int numBytesToWrite, out int startOffset, out uint passId)
		{
			startOffset = (int)QtjobTKVLyjHsrPieyDyCIQEbUt;
			passId = qyFPRvidXCioTrlpLgPCGEAsLKcM;
			if (buffer == null)
			{
				return 0;
			}
			int num = buffer.Length;
			if (num <= 0 || numBytesToWrite <= 0)
			{
				return 0;
			}
			if (numBytesToWrite > num)
			{
				numBytesToWrite = num;
			}
			int num2 = vsYfOtbYOjMAnAjcjAveBMNaFSiw.TryWriteBytes(buffer, numBytesToWrite, (int)QtjobTKVLyjHsrPieyDyCIQEbUt);
			if (num2 == 0)
			{
				return 0;
			}
			if (num2 < numBytesToWrite)
			{
				num2 += vsYfOtbYOjMAnAjcjAveBMNaFSiw.TryWriteBytes(buffer, numBytesToWrite - num2, 0, num2);
			}
			xRDzsPTlVmFZqigsUYmlcNtVYolR(num2);
			return num2;
		}

		public int Write(IntPtr buffer, int bufferLength, int numBytesToWrite)
		{
			int startOffset;
			uint passId;
			return Write(buffer, bufferLength, numBytesToWrite, out startOffset, out passId);
		}

		public int Write(byte[] buffer, int numBytesToWrite)
		{
			int startOffset;
			uint passId;
			return Write(buffer, numBytesToWrite, out startOffset, out passId);
		}

		public int Read(IntPtr buffer, int bufferLength, int numBytesToRead)
		{
			if (buffer == IntPtr.Zero || bufferLength <= 0 || numBytesToRead <= 0 || DTYPKUyuHFRdYjEeshALSuzUdaq == 0)
			{
				return 0;
			}
			if (numBytesToRead > bufferLength)
			{
				numBytesToRead = bufferLength;
			}
			if (numBytesToRead > DTYPKUyuHFRdYjEeshALSuzUdaq)
			{
				numBytesToRead = DTYPKUyuHFRdYjEeshALSuzUdaq;
			}
			int num = vsYfOtbYOjMAnAjcjAveBMNaFSiw.TryReadBytes(buffer, bufferLength, numBytesToRead, (int)DUndgkjlhdXIcpMpKSDjzSlhNxI);
			if (num <= 0)
			{
				return 0;
			}
			if (num < numBytesToRead)
			{
				num += vsYfOtbYOjMAnAjcjAveBMNaFSiw.TryReadBytes(buffer, bufferLength, numBytesToRead - num, 0, num);
			}
			TADnBaaSuOFJWjdPQDrNKrCUuPy(num);
			return num;
		}

		public int Read(byte[] buffer, int numBytesToRead)
		{
			if (buffer == null)
			{
				return 0;
			}
			int num = buffer.Length;
			if (num <= 0 || numBytesToRead <= 0 || DTYPKUyuHFRdYjEeshALSuzUdaq == 0)
			{
				return 0;
			}
			if (numBytesToRead > num)
			{
				numBytesToRead = num;
			}
			if (numBytesToRead > DTYPKUyuHFRdYjEeshALSuzUdaq)
			{
				numBytesToRead = DTYPKUyuHFRdYjEeshALSuzUdaq;
			}
			int num2 = vsYfOtbYOjMAnAjcjAveBMNaFSiw.TryReadBytes(buffer, numBytesToRead, (int)DUndgkjlhdXIcpMpKSDjzSlhNxI);
			if (num2 <= 0)
			{
				return 0;
			}
			if (num2 < numBytesToRead)
			{
				num2 += vsYfOtbYOjMAnAjcjAveBMNaFSiw.TryReadBytes(buffer, numBytesToRead - num2, 0, num2);
			}
			TADnBaaSuOFJWjdPQDrNKrCUuPy(num2);
			return num2;
		}

		public int RandomRead(IntPtr buffer, int bufferLength, int numBytesToRead, int readStartIndex)
		{
			if (buffer == IntPtr.Zero || bufferLength <= 0 || numBytesToRead <= 0 || DTYPKUyuHFRdYjEeshALSuzUdaq == 0 || readStartIndex < 0 || readStartIndex >= nfDdeELnrQwKNlRDjFNLWWngAhc)
			{
				return 0;
			}
			if (numBytesToRead > bufferLength)
			{
				numBytesToRead = bufferLength;
			}
			if (numBytesToRead > DTYPKUyuHFRdYjEeshALSuzUdaq)
			{
				numBytesToRead = DTYPKUyuHFRdYjEeshALSuzUdaq;
			}
			int num = vsYfOtbYOjMAnAjcjAveBMNaFSiw.TryReadBytes(buffer, bufferLength, numBytesToRead, readStartIndex);
			if (num <= 0)
			{
				return 0;
			}
			if (num < numBytesToRead)
			{
				num += vsYfOtbYOjMAnAjcjAveBMNaFSiw.TryReadBytes(buffer, bufferLength, numBytesToRead - num, 0, num);
			}
			return num;
		}

		public int RandomRead(byte[] buffer, int numBytesToRead, int readStartIndex)
		{
			if (buffer == null)
			{
				return 0;
			}
			int num = buffer.Length;
			if (num <= 0 || numBytesToRead <= 0 || DTYPKUyuHFRdYjEeshALSuzUdaq == 0 || readStartIndex < 0 || readStartIndex >= nfDdeELnrQwKNlRDjFNLWWngAhc)
			{
				return 0;
			}
			if (numBytesToRead > num)
			{
				numBytesToRead = num;
			}
			if (numBytesToRead > DTYPKUyuHFRdYjEeshALSuzUdaq)
			{
				numBytesToRead = DTYPKUyuHFRdYjEeshALSuzUdaq;
			}
			int num2 = vsYfOtbYOjMAnAjcjAveBMNaFSiw.TryReadBytes(buffer, numBytesToRead, readStartIndex);
			if (num2 <= 0)
			{
				return 0;
			}
			if (num2 < numBytesToRead)
			{
				num2 += vsYfOtbYOjMAnAjcjAveBMNaFSiw.TryReadBytes(buffer, numBytesToRead - num2, 0, num2);
			}
			return num2;
		}

		public IntPtr GetPointerFromReadPosition(int offset)
		{
			int offsetFromReadPosition = GetOffsetFromReadPosition(offset);
			if (offsetFromReadPosition < 0)
			{
				return IntPtr.Zero;
			}
			return vsYfOtbYOjMAnAjcjAveBMNaFSiw.GetPointer(offsetFromReadPosition);
		}

		public int GetOffsetFromReadPosition(int offset)
		{
			int num = (int)DUndgkjlhdXIcpMpKSDjzSlhNxI + offset;
			if (num >= nfDdeELnrQwKNlRDjFNLWWngAhc)
			{
				num -= nfDdeELnrQwKNlRDjFNLWWngAhc;
			}
			else if (num < 0)
			{
				num += nfDdeELnrQwKNlRDjFNLWWngAhc;
			}
			if (num < 0 || num >= nfDdeELnrQwKNlRDjFNLWWngAhc)
			{
				return -1;
			}
			return num;
		}

		public bool IsValid(int startIndex, uint passId)
		{
			if (startIndex < 0 || startIndex >= nfDdeELnrQwKNlRDjFNLWWngAhc)
			{
				return false;
			}
			if (startIndex < QtjobTKVLyjHsrPieyDyCIQEbUt)
			{
				if (passId == qyFPRvidXCioTrlpLgPCGEAsLKcM)
				{
					return true;
				}
			}
			else if (startIndex >= QtjobTKVLyjHsrPieyDyCIQEbUt)
			{
				if (qyFPRvidXCioTrlpLgPCGEAsLKcM == 0)
				{
					return false;
				}
				if (qyFPRvidXCioTrlpLgPCGEAsLKcM - 1 == passId)
				{
					return true;
				}
			}
			return false;
		}

		public void CopyFrom(NativeRingBuffer other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			if (nfDdeELnrQwKNlRDjFNLWWngAhc != other.nfDdeELnrQwKNlRDjFNLWWngAhc)
			{
				throw new Exception("Buffer does not have the same capacity. Cannot copy.");
			}
			QtjobTKVLyjHsrPieyDyCIQEbUt = other.QtjobTKVLyjHsrPieyDyCIQEbUt;
			DUndgkjlhdXIcpMpKSDjzSlhNxI = other.DUndgkjlhdXIcpMpKSDjzSlhNxI;
			DTYPKUyuHFRdYjEeshALSuzUdaq = other.DTYPKUyuHFRdYjEeshALSuzUdaq;
			lGVohtghaMnjZcBUIuCAsygqDjP = other.lGVohtghaMnjZcBUIuCAsygqDjP;
			qyFPRvidXCioTrlpLgPCGEAsLKcM = other.qyFPRvidXCioTrlpLgPCGEAsLKcM;
			vsYfOtbYOjMAnAjcjAveBMNaFSiw.CopyFrom(other.vsYfOtbYOjMAnAjcjAveBMNaFSiw);
		}

		public void Reset()
		{
			QtjobTKVLyjHsrPieyDyCIQEbUt = 0L;
			DUndgkjlhdXIcpMpKSDjzSlhNxI = 0L;
			DTYPKUyuHFRdYjEeshALSuzUdaq = 0;
			lGVohtghaMnjZcBUIuCAsygqDjP = false;
			qyFPRvidXCioTrlpLgPCGEAsLKcM = 0u;
		}

		private void xRDzsPTlVmFZqigsUYmlcNtVYolR(int P_0)
		{
			if (P_0 <= 0)
			{
				return;
			}
			int num = (int)QtjobTKVLyjHsrPieyDyCIQEbUt;
			QtjobTKVLyjHsrPieyDyCIQEbUt += P_0;
			bool flag = false;
			if (num < DUndgkjlhdXIcpMpKSDjzSlhNxI)
			{
				if (QtjobTKVLyjHsrPieyDyCIQEbUt > DUndgkjlhdXIcpMpKSDjzSlhNxI)
				{
					flag = true;
				}
			}
			else if (num > DUndgkjlhdXIcpMpKSDjzSlhNxI)
			{
				if (QtjobTKVLyjHsrPieyDyCIQEbUt - nfDdeELnrQwKNlRDjFNLWWngAhc > DUndgkjlhdXIcpMpKSDjzSlhNxI)
				{
					flag = true;
				}
			}
			else if (DTYPKUyuHFRdYjEeshALSuzUdaq > 0)
			{
				flag = true;
			}
			if (flag)
			{
				lGVohtghaMnjZcBUIuCAsygqDjP = true;
				DUndgkjlhdXIcpMpKSDjzSlhNxI = QtjobTKVLyjHsrPieyDyCIQEbUt;
				if (DUndgkjlhdXIcpMpKSDjzSlhNxI >= nfDdeELnrQwKNlRDjFNLWWngAhc)
				{
					DUndgkjlhdXIcpMpKSDjzSlhNxI -= nfDdeELnrQwKNlRDjFNLWWngAhc;
				}
			}
			if (QtjobTKVLyjHsrPieyDyCIQEbUt >= nfDdeELnrQwKNlRDjFNLWWngAhc)
			{
				QtjobTKVLyjHsrPieyDyCIQEbUt -= nfDdeELnrQwKNlRDjFNLWWngAhc;
				BXRNbemzHRvvSxzXDiMEpaxJCKrI();
			}
			DTYPKUyuHFRdYjEeshALSuzUdaq = (int)MathTools.Clamp((long)DTYPKUyuHFRdYjEeshALSuzUdaq + (long)P_0, 0L, nfDdeELnrQwKNlRDjFNLWWngAhc);
		}

		private void TADnBaaSuOFJWjdPQDrNKrCUuPy(int P_0)
		{
			if (P_0 > 0)
			{
				if (lGVohtghaMnjZcBUIuCAsygqDjP)
				{
					lGVohtghaMnjZcBUIuCAsygqDjP = false;
				}
				DUndgkjlhdXIcpMpKSDjzSlhNxI += P_0;
				if (DUndgkjlhdXIcpMpKSDjzSlhNxI >= nfDdeELnrQwKNlRDjFNLWWngAhc)
				{
					DUndgkjlhdXIcpMpKSDjzSlhNxI -= nfDdeELnrQwKNlRDjFNLWWngAhc;
				}
				long num = (long)DTYPKUyuHFRdYjEeshALSuzUdaq - (long)P_0;
				DTYPKUyuHFRdYjEeshALSuzUdaq = (int)((num >= 0) ? num : 0);
			}
		}

		private void BXRNbemzHRvvSxzXDiMEpaxJCKrI()
		{
			if (qyFPRvidXCioTrlpLgPCGEAsLKcM == uint.MaxValue)
			{
				qyFPRvidXCioTrlpLgPCGEAsLKcM = 0u;
			}
			else
			{
				qyFPRvidXCioTrlpLgPCGEAsLKcM++;
			}
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		~NativeRingBuffer()
		{
			Dispose(disposing: false);
		}

		protected void Dispose(bool disposing)
		{
			if (!RFSEgUYkCipDyWyLEnlGiNDUlzz)
			{
				if (disposing && vsYfOtbYOjMAnAjcjAveBMNaFSiw != null)
				{
					vsYfOtbYOjMAnAjcjAveBMNaFSiw.Dispose();
				}
				RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
			}
		}
	}
}
