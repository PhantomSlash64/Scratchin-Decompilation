using System;
using System.Runtime.InteropServices;

namespace Rewired.Utils
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal static class BitTools
	{
		private static byte[] VaVnmzjIYsccIhwWkIUOahNimDH;

		private static byte[] intToFloatBuffer => VaVnmzjIYsccIhwWkIUOahNimDH ?? (VaVnmzjIYsccIhwWkIUOahNimDH = new byte[4]);

		public static void GetBytes(short value, byte[] buffer)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("bytes");
			}
			if (buffer.Length < 2)
			{
				throw new Exception("bytes.Length must be >= 2.");
			}
			buffer[0] = (byte)value;
			buffer[1] = (byte)(value >> 8);
		}

		public static void GetBytes(int value, byte[] buffer)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("bytes");
			}
			if (buffer.Length < 4)
			{
				throw new Exception("bytes.Length must be >= 4.");
			}
			buffer[0] = (byte)value;
			buffer[1] = (byte)(value >> 8);
			buffer[2] = (byte)(value >> 16);
			buffer[3] = (byte)(value >> 24);
		}

		public static void GetBytes(long value, byte[] buffer)
		{
			if (buffer == null)
			{
				throw new ArgumentNullException("bytes");
			}
			if (buffer.Length < 8)
			{
				throw new Exception("bytes.Length must be >= 8.");
			}
			buffer[0] = (byte)value;
			buffer[1] = (byte)(value >> 8);
			buffer[2] = (byte)(value >> 16);
			buffer[3] = (byte)(value >> 24);
			buffer[4] = (byte)(value >> 32);
			buffer[5] = (byte)(value >> 40);
			buffer[6] = (byte)(value >> 48);
			buffer[7] = (byte)(value >> 56);
		}

		public static float IntToFloat(IntPtr pointer, int offset = 0)
		{
			if (pointer == IntPtr.Zero)
			{
				throw new Exception("pointer is null");
			}
			byte[] array = intToFloatBuffer;
			lock (array)
			{
				Marshal.Copy(pointer, array, offset, 4);
				return BitConverter.ToSingle(array, 0);
			}
		}
	}
}
