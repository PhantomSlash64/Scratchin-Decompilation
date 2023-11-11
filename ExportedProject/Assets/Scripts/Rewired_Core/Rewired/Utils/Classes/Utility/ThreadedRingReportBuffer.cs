using System;
using Rewired.Utils.Classes.Data;

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class ThreadedRingReportBuffer : IDisposable
	{
		private readonly int hryHklCokACsCauYvPNuNNwvXSia;

		private readonly int rnDAMBIAzKUjIgNTZMPRtJgkYivJ;

		private readonly int kNIBOKHFmPGDpCgOcEMXVwTLWUFz;

		private readonly int kjjorxbSbjbYIIfRoSjrqIqIFNo;

		private readonly int AsCQkOXLuaQbYytpbdmlLvvbQVC;

		private readonly bool vaDaGjEXhutJaDNVEKbuxaApAkYB;

		private ThreadHelper LzOmxoEMyXdHGDFTmboJhhMxKvwE;

		private NativeRingBuffer uRAKzggHymGneIxJhgQpBsNGlop;

		private NativeRingBuffer ZBtbQkibbbUsOaiYCHfysZOajxY;

		private Action<byte[]> NukgNudLmgOTPgFjOiyMgptxvtdE;

		private byte[] TCiFXgAsJTEKMJyGAcwNHCgcFxJA;

		private byte[] QYZNwzCxARqdMVHrGJGgRifgzan;

		private bool dtKvbBomMBtVPJMfTXGUVEWnVdn;

		private bool vqjuhdYKKuBgDKqCJHOYrBTbbEX;

		private int zIIrvsCFkxPOLUGquitIRFgzlIV;

		private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

		public bool IsRunning => LzOmxoEMyXdHGDFTmboJhhMxKvwE.isRunning;

		public int BufferLength => hryHklCokACsCauYvPNuNNwvXSia;

		public int BytesInBuffer => ZBtbQkibbbUsOaiYCHfysZOajxY.BytesInBuffer;

		public int EntriesInBuffer => ZBtbQkibbbUsOaiYCHfysZOajxY.BytesInBuffer / rnDAMBIAzKUjIgNTZMPRtJgkYivJ;

		public byte[] ReadBuffer => QYZNwzCxARqdMVHrGJGgRifgzan;

		public int LastNumBytesRead => zIIrvsCFkxPOLUGquitIRFgzlIV;

		public ThreadedRingReportBuffer(int entryByteLength, int entryCapacity, int threadRefreshRateFPS, int threadAutoKillTimeoutMS, bool threadBlockOnStartAndStop, Action<byte[]> threadRetrieveDataDelegate)
		{
			if (entryByteLength <= 0)
			{
				throw new ArgumentOutOfRangeException("entryByteLength must be > 0.");
			}
			if (entryCapacity < 1)
			{
				throw new ArgumentOutOfRangeException("entryCapacity must be >= 1.");
			}
			if (threadRefreshRateFPS < 0)
			{
				threadRefreshRateFPS = 0;
			}
			if (threadAutoKillTimeoutMS < 0)
			{
				threadAutoKillTimeoutMS = 0;
			}
			if (threadRetrieveDataDelegate == null)
			{
				throw new ArgumentNullException("threadRetrieveDataDelegate");
			}
			rnDAMBIAzKUjIgNTZMPRtJgkYivJ = entryByteLength;
			kNIBOKHFmPGDpCgOcEMXVwTLWUFz = entryCapacity;
			hryHklCokACsCauYvPNuNNwvXSia = entryByteLength * entryCapacity;
			kjjorxbSbjbYIIfRoSjrqIqIFNo = threadRefreshRateFPS;
			AsCQkOXLuaQbYytpbdmlLvvbQVC = threadAutoKillTimeoutMS;
			vaDaGjEXhutJaDNVEKbuxaApAkYB = threadBlockOnStartAndStop;
			NukgNudLmgOTPgFjOiyMgptxvtdE = threadRetrieveDataDelegate;
			uRAKzggHymGneIxJhgQpBsNGlop = new NativeRingBuffer(hryHklCokACsCauYvPNuNNwvXSia);
			ZBtbQkibbbUsOaiYCHfysZOajxY = new NativeRingBuffer(hryHklCokACsCauYvPNuNNwvXSia);
			TCiFXgAsJTEKMJyGAcwNHCgcFxJA = new byte[entryByteLength];
			QYZNwzCxARqdMVHrGJGgRifgzan = new byte[entryByteLength];
			if (!dmyjjERgjQIVlakFlHoYvIKBXOi())
			{
				throw new Exception("Could not initialize thread.");
			}
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

		public int Read(byte[] buffer)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("buffer");
			}
			int result = 0;
			lock (ZBtbQkibbbUsOaiYCHfysZOajxY)
			{
				result = ZBtbQkibbbUsOaiYCHfysZOajxY.Read(buffer, buffer.Length);
			}
			zIIrvsCFkxPOLUGquitIRFgzlIV = result;
			return result;
		}

		public int Read(IntPtr buffer, int bufferLength)
		{
			if (buffer == IntPtr.Zero)
			{
				throw new ArgumentNullException("buffer");
			}
			if (bufferLength <= 0)
			{
				throw new ArgumentOutOfRangeException("bufferLength");
			}
			int result = 0;
			lock (ZBtbQkibbbUsOaiYCHfysZOajxY)
			{
				result = ZBtbQkibbbUsOaiYCHfysZOajxY.Read(buffer, bufferLength, bufferLength);
			}
			zIIrvsCFkxPOLUGquitIRFgzlIV = result;
			return result;
		}

		public int StartRead()
		{
			ineVhIDuXjdPIcgEsdmdguWqRbh();
			return ZBtbQkibbbUsOaiYCHfysZOajxY.BytesInBuffer;
		}

		public void StartThread()
		{
			if (LzOmxoEMyXdHGDFTmboJhhMxKvwE.isRunning)
			{
				return;
			}
			try
			{
				LzOmxoEMyXdHGDFTmboJhhMxKvwE.Start(vaDaGjEXhutJaDNVEKbuxaApAkYB);
			}
			catch
			{
			}
		}

		public void StopThread()
		{
			if (LzOmxoEMyXdHGDFTmboJhhMxKvwE.isStopped)
			{
				return;
			}
			try
			{
				LzOmxoEMyXdHGDFTmboJhhMxKvwE.Stop(vaDaGjEXhutJaDNVEKbuxaApAkYB);
			}
			catch
			{
			}
		}

		private bool dmyjjERgjQIVlakFlHoYvIKBXOi()
		{
			if (dtKvbBomMBtVPJMfTXGUVEWnVdn)
			{
				return false;
			}
			if (!vcEbiDGFdqSPNcGYdZknHnYExfTl())
			{
				return false;
			}
			if (vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				return true;
			}
			vqjuhdYKKuBgDKqCJHOYrBTbbEX = true;
			return true;
		}

		private bool vcEbiDGFdqSPNcGYdZknHnYExfTl()
		{
			if (dtKvbBomMBtVPJMfTXGUVEWnVdn)
			{
				return false;
			}
			if (LzOmxoEMyXdHGDFTmboJhhMxKvwE == null)
			{
				try
				{
					LzOmxoEMyXdHGDFTmboJhhMxKvwE = ThreadHelper.CreateFixedTimeStep(kjjorxbSbjbYIIfRoSjrqIqIFNo, AsCQkOXLuaQbYytpbdmlLvvbQVC);
					LzOmxoEMyXdHGDFTmboJhhMxKvwE.ThreadUpdateEvent += bQqgsAbWRjGlMsAyaNueMnaBOfCE;
					return true;
				}
				catch (Exception ex)
				{
					Logger.LogError("Exception occurred while creating thread!\n" + ex, requiredThreadSafety: true);
					if (LzOmxoEMyXdHGDFTmboJhhMxKvwE != null)
					{
						LzOmxoEMyXdHGDFTmboJhhMxKvwE.Stop(vaDaGjEXhutJaDNVEKbuxaApAkYB);
					}
					dtKvbBomMBtVPJMfTXGUVEWnVdn = true;
					return false;
				}
			}
			if (!LzOmxoEMyXdHGDFTmboJhhMxKvwE.isRunning)
			{
				LzOmxoEMyXdHGDFTmboJhhMxKvwE.Start(vaDaGjEXhutJaDNVEKbuxaApAkYB);
			}
			else if (AsCQkOXLuaQbYytpbdmlLvvbQVC > 0)
			{
				LzOmxoEMyXdHGDFTmboJhhMxKvwE.ResetTimeout();
			}
			return true;
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

		private void bQqgsAbWRjGlMsAyaNueMnaBOfCE()
		{
			try
			{
				lock (uRAKzggHymGneIxJhgQpBsNGlop)
				{
					NukgNudLmgOTPgFjOiyMgptxvtdE(TCiFXgAsJTEKMJyGAcwNHCgcFxJA);
					uRAKzggHymGneIxJhgQpBsNGlop.Write(TCiFXgAsJTEKMJyGAcwNHCgcFxJA, rnDAMBIAzKUjIgNTZMPRtJgkYivJ);
				}
			}
			catch
			{
			}
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		~ThreadedRingReportBuffer()
		{
			Dispose(disposing: false);
		}

		protected void Dispose(bool disposing)
		{
			if (!RFSEgUYkCipDyWyLEnlGiNDUlzz)
			{
				if (disposing && LzOmxoEMyXdHGDFTmboJhhMxKvwE != null)
				{
					LzOmxoEMyXdHGDFTmboJhhMxKvwE.Dispose();
				}
				RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
			}
		}
	}
}
