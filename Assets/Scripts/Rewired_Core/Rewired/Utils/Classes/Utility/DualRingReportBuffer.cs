using System;
using Rewired.Utils.Classes.Data;

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class DualRingReportBuffer : IDisposable
	{
		private readonly int hryHklCokACsCauYvPNuNNwvXSia;

		private readonly int rnDAMBIAzKUjIgNTZMPRtJgkYivJ;

		private readonly int kNIBOKHFmPGDpCgOcEMXVwTLWUFz;

		private NativeRingBuffer uRAKzggHymGneIxJhgQpBsNGlop;

		private NativeRingBuffer ZBtbQkibbbUsOaiYCHfysZOajxY;

		private byte[] TCiFXgAsJTEKMJyGAcwNHCgcFxJA;

		private byte[] QYZNwzCxARqdMVHrGJGgRifgzan;

		private int zIIrvsCFkxPOLUGquitIRFgzlIV;

		private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

		public int BufferLength => hryHklCokACsCauYvPNuNNwvXSia;

		public int BytesInBuffer => ZBtbQkibbbUsOaiYCHfysZOajxY.BytesInBuffer;

		public int EntriesInBuffer => ZBtbQkibbbUsOaiYCHfysZOajxY.BytesInBuffer / rnDAMBIAzKUjIgNTZMPRtJgkYivJ;

		public byte[] ReadBuffer => QYZNwzCxARqdMVHrGJGgRifgzan;

		public int LastNumBytesRead => zIIrvsCFkxPOLUGquitIRFgzlIV;

		public DualRingReportBuffer(int entryByteLength, int entryCapacity)
		{
			if (entryByteLength <= 0)
			{
				throw new ArgumentOutOfRangeException("entryByteLength must be > 0.");
			}
			if (entryCapacity < 1)
			{
				throw new ArgumentOutOfRangeException("entryCapacity must be >= 1.");
			}
			rnDAMBIAzKUjIgNTZMPRtJgkYivJ = entryByteLength;
			kNIBOKHFmPGDpCgOcEMXVwTLWUFz = entryCapacity;
			hryHklCokACsCauYvPNuNNwvXSia = entryByteLength * entryCapacity;
			uRAKzggHymGneIxJhgQpBsNGlop = new NativeRingBuffer(hryHklCokACsCauYvPNuNNwvXSia);
			ZBtbQkibbbUsOaiYCHfysZOajxY = new NativeRingBuffer(hryHklCokACsCauYvPNuNNwvXSia);
			TCiFXgAsJTEKMJyGAcwNHCgcFxJA = new byte[entryByteLength];
			QYZNwzCxARqdMVHrGJGgRifgzan = new byte[entryByteLength];
		}

		public int StartRead()
		{
			ineVhIDuXjdPIcgEsdmdguWqRbh();
			return ZBtbQkibbbUsOaiYCHfysZOajxY.BytesInBuffer;
		}

		public int Read()
		{
			int result = 0;
			lock (ZBtbQkibbbUsOaiYCHfysZOajxY)
			{
				result = ZBtbQkibbbUsOaiYCHfysZOajxY.Read(QYZNwzCxARqdMVHrGJGgRifgzan, rnDAMBIAzKUjIgNTZMPRtJgkYivJ);
			}
			zIIrvsCFkxPOLUGquitIRFgzlIV = result;
			return result;
		}

		public int Read(byte[] buffer, int numBytesToRead)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (numBytesToRead < 0 || numBytesToRead > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("numBytesToWrite");
			}
			int result = 0;
			lock (ZBtbQkibbbUsOaiYCHfysZOajxY)
			{
				result = ZBtbQkibbbUsOaiYCHfysZOajxY.Read(buffer, numBytesToRead);
			}
			zIIrvsCFkxPOLUGquitIRFgzlIV = result;
			return result;
		}

		public int Read(IntPtr buffer, int bufferLength, int numBytesToRead)
		{
			if (buffer == IntPtr.Zero)
			{
				throw new ArgumentNullException("buffer");
			}
			if (bufferLength <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferLength");
			}
			if (numBytesToRead < 0 || numBytesToRead > bufferLength)
			{
				throw new ArgumentOutOfRangeException("numBytesToWrite");
			}
			int result = 0;
			lock (ZBtbQkibbbUsOaiYCHfysZOajxY)
			{
				result = ZBtbQkibbbUsOaiYCHfysZOajxY.Read(buffer, bufferLength, bufferLength);
			}
			zIIrvsCFkxPOLUGquitIRFgzlIV = result;
			return result;
		}

		public int Write(byte[] buffer, int numBytesToWrite)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			if (numBytesToWrite < 0 || numBytesToWrite > buffer.Length)
			{
				throw new ArgumentOutOfRangeException("numBytesToWrite");
			}
			int num = 0;
			lock (uRAKzggHymGneIxJhgQpBsNGlop)
			{
				return uRAKzggHymGneIxJhgQpBsNGlop.Write(buffer, numBytesToWrite);
			}
		}

		public int Write(IntPtr buffer, int bufferLength, int numBytesToWrite)
		{
			if (buffer == IntPtr.Zero)
			{
				throw new ArgumentNullException("buffer");
			}
			if (bufferLength <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferLength");
			}
			if (numBytesToWrite < 0 || numBytesToWrite > bufferLength)
			{
				throw new ArgumentOutOfRangeException("numBytesToWrite");
			}
			int num = 0;
			lock (uRAKzggHymGneIxJhgQpBsNGlop)
			{
				return uRAKzggHymGneIxJhgQpBsNGlop.Write(buffer, bufferLength, numBytesToWrite);
			}
		}

		public void Clear()
		{
			lock (uRAKzggHymGneIxJhgQpBsNGlop)
			{
				lock (ZBtbQkibbbUsOaiYCHfysZOajxY)
				{
					ZBtbQkibbbUsOaiYCHfysZOajxY.Reset();
					uRAKzggHymGneIxJhgQpBsNGlop.Reset();
				}
			}
		}

		private void ineVhIDuXjdPIcgEsdmdguWqRbh()
		{
			lock (uRAKzggHymGneIxJhgQpBsNGlop)
			{
				lock (ZBtbQkibbbUsOaiYCHfysZOajxY)
				{
					MiscTools.Swap(ref uRAKzggHymGneIxJhgQpBsNGlop, ref ZBtbQkibbbUsOaiYCHfysZOajxY);
				}
			}
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		~DualRingReportBuffer()
		{
			Dispose(disposing: false);
		}

		protected void Dispose(bool disposing)
		{
			if (!RFSEgUYkCipDyWyLEnlGiNDUlzz)
			{
				RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
			}
		}
	}
}
