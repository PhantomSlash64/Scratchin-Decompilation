using System;
using System.Runtime.InteropServices;

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class NativeMemoryBlock : IDisposable
	{
		private int xSTeYRGAgKrcmtkotlgWNMEGPCrl;

		private uint hNOGZAFrXrQQyIxeRTMdoGdnksKA;

		private IntPtr QlzvGIRxYwWdRwKSrvPrSbJYgyp;

		private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

		public uint size => hNOGZAFrXrQQyIxeRTMdoGdnksKA;

		public NativeMemoryBlock(uint size)
		{
			if (size == 0)
			{
				throw new Exception("size must be > 0!");
			}
			hNOGZAFrXrQQyIxeRTMdoGdnksKA = size;
			xSTeYRGAgKrcmtkotlgWNMEGPCrl = 0;
			try
			{
				QlzvGIRxYwWdRwKSrvPrSbJYgyp = Marshal.AllocHGlobal((int)size);
				if (QlzvGIRxYwWdRwKSrvPrSbJYgyp == IntPtr.Zero)
				{
					throw new Exception("Could not allocate native memory.");
				}
			}
			catch
			{
				throw;
			}
		}

		public IntPtr Allocate(uint bytes, IntPtr ptrToData)
		{
			if (RFSEgUYkCipDyWyLEnlGiNDUlzz)
			{
				return IntPtr.Zero;
			}
			if (bytes == 0)
			{
				return IntPtr.Zero;
			}
			if (bytes > hNOGZAFrXrQQyIxeRTMdoGdnksKA)
			{
				return IntPtr.Zero;
			}
			if (xSTeYRGAgKrcmtkotlgWNMEGPCrl + bytes >= hNOGZAFrXrQQyIxeRTMdoGdnksKA)
			{
				xSTeYRGAgKrcmtkotlgWNMEGPCrl = 0;
			}
			IntPtr intPtr = new IntPtr(QlzvGIRxYwWdRwKSrvPrSbJYgyp.ToInt64() + xSTeYRGAgKrcmtkotlgWNMEGPCrl);
			if (ptrToData != IntPtr.Zero)
			{
				NativeTools.CopyMemory(ptrToData, intPtr, 0, 0, (int)bytes);
			}
			xSTeYRGAgKrcmtkotlgWNMEGPCrl += (int)bytes;
			return intPtr;
		}

		public IntPtr Allocate(uint bytes)
		{
			return Allocate(bytes, IntPtr.Zero);
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		~NativeMemoryBlock()
		{
			Dispose(disposing: false);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!RFSEgUYkCipDyWyLEnlGiNDUlzz)
			{
				RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
				if (QlzvGIRxYwWdRwKSrvPrSbJYgyp != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(QlzvGIRxYwWdRwKSrvPrSbJYgyp);
					QlzvGIRxYwWdRwKSrvPrSbJYgyp = IntPtr.Zero;
				}
			}
		}
	}
}
