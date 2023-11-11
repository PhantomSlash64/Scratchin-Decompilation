using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Rewired.Utils
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal static class NativeTools
	{
		private static byte[] vKbcObsylNeOcCLPtczeZIGiOzJ;

		public static IntPtr OffsetIntPtr(IntPtr intPtr, int offset)
		{
			if (offset == 0)
			{
				return intPtr;
			}
			if (SystemInfo.is64Bit)
			{
				return new IntPtr(intPtr.ToInt64() + offset);
			}
			return new IntPtr(intPtr.ToInt32() + offset);
		}

		public static bool CopyMemory(IntPtr source, IntPtr destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = true)
		{
			if (throwOnError)
			{
				if (source == IntPtr.Zero)
				{
					throw new ArgumentNullException("source");
				}
				if (destination == IntPtr.Zero)
				{
					throw new ArgumentNullException("destination");
				}
				if (sourceStartIndex < 0)
				{
					throw new ArgumentOutOfRangeException("sourceStartIndex");
				}
				if (destinationStartIndex < 0)
				{
					throw new ArgumentOutOfRangeException("destinationStartIndex");
				}
				if (bytesToCopy <= 0)
				{
					throw new ArgumentOutOfRangeException("length");
				}
			}
			else
			{
				if (source == IntPtr.Zero || destination == IntPtr.Zero)
				{
					return false;
				}
				if (sourceStartIndex < 0)
				{
					sourceStartIndex = 0;
				}
				if (destinationStartIndex < 0)
				{
					destinationStartIndex = 0;
				}
				if (bytesToCopy <= 0)
				{
					return false;
				}
			}
			try
			{
				int num = bytesToCopy;
				if (num >= 8)
				{
					int num2 = bytesToCopy / 8 * 8;
					for (int i = 0; i < num2; i += 8)
					{
						Marshal.WriteInt64(destination, i + destinationStartIndex, Marshal.ReadInt64(source, i + sourceStartIndex));
					}
					num %= 8;
				}
				if (num >= 4)
				{
					int num3 = bytesToCopy / 4 * 4;
					for (int j = bytesToCopy - num; j < num3; j += 4)
					{
						Marshal.WriteInt32(destination, j + destinationStartIndex, Marshal.ReadInt32(source, j + sourceStartIndex));
					}
					num %= 4;
				}
				if (num >= 2)
				{
					int num4 = bytesToCopy / 2 * 2;
					for (int k = bytesToCopy - num; k < num4; k += 2)
					{
						Marshal.WriteInt16(destination, k + destinationStartIndex, Marshal.ReadInt16(source, k + sourceStartIndex));
					}
					num %= 2;
				}
				for (int l = bytesToCopy - num; l < bytesToCopy; l++)
				{
					Marshal.WriteByte(destination, l + destinationStartIndex, Marshal.ReadByte(source, l + sourceStartIndex));
				}
				return true;
			}
			catch
			{
				if (throwOnError)
				{
					throw;
				}
				return false;
			}
		}

		public static bool CopyMemory(byte[] source, IntPtr destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = true)
		{
			if (throwOnError)
			{
				if (source == null)
				{
					throw new ArgumentNullException("source");
				}
				if (sourceStartIndex < 0 || sourceStartIndex >= source.Length)
				{
					throw new ArgumentOutOfRangeException("sourceStartIndex");
				}
				if (destinationStartIndex < 0)
				{
					throw new ArgumentOutOfRangeException("destinationStartIndex");
				}
				if (bytesToCopy > source.Length - sourceStartIndex)
				{
					throw new Exception("source.Length + souceStartIndex must be >= bytesToCopy");
				}
			}
			else
			{
				if (source == null)
				{
					return false;
				}
				if (sourceStartIndex < 0 || sourceStartIndex >= source.Length)
				{
					return false;
				}
				if (destinationStartIndex < 0)
				{
					return false;
				}
				if (bytesToCopy > source.Length - sourceStartIndex)
				{
					return false;
				}
			}
			try
			{
				if (destinationStartIndex == 0)
				{
					Marshal.Copy(source, sourceStartIndex, destination, bytesToCopy);
				}
				else
				{
					Marshal.Copy(source, sourceStartIndex, OffsetIntPtr(destination, destinationStartIndex), bytesToCopy);
				}
				return true;
			}
			catch
			{
				if (throwOnError)
				{
					throw;
				}
				return false;
			}
		}

		public static bool CopyMemory(IntPtr source, byte[] destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = true)
		{
			if (throwOnError)
			{
				if (destination == null)
				{
					throw new ArgumentNullException("destination");
				}
				if (sourceStartIndex < 0)
				{
					throw new ArgumentOutOfRangeException("sourceStartIndex");
				}
				if (destinationStartIndex < 0 || destinationStartIndex >= destination.Length)
				{
					throw new ArgumentOutOfRangeException("destinationStartIndex");
				}
				if (bytesToCopy > destination.Length - destinationStartIndex)
				{
					throw new Exception("destination.Length + destinationStartIndex must be >= bytesToCopy");
				}
			}
			else
			{
				if (destination == null)
				{
					return false;
				}
				if (sourceStartIndex < 0)
				{
					return false;
				}
				if (destinationStartIndex < 0 || destinationStartIndex >= destination.Length)
				{
					return false;
				}
				if (bytesToCopy > destination.Length - destinationStartIndex)
				{
					return false;
				}
			}
			try
			{
				if (sourceStartIndex == 0)
				{
					Marshal.Copy(source, destination, destinationStartIndex, bytesToCopy);
				}
				else
				{
					Marshal.Copy(OffsetIntPtr(source, sourceStartIndex), destination, destinationStartIndex, bytesToCopy);
				}
				return true;
			}
			catch
			{
				if (throwOnError)
				{
					throw;
				}
				return false;
			}
		}

		public static bool FillMemory(IntPtr buffer, int length, byte value, bool throwOnError = true)
		{
			return FillMemory(buffer, 0, length, value, throwOnError);
		}

		public static bool FillMemory(IntPtr buffer, int startIndex, int length, byte value, bool throwOnError = true)
		{
			if (throwOnError)
			{
				if (buffer == IntPtr.Zero)
				{
					throw new ArgumentNullException("buffer");
				}
				if (startIndex < 0)
				{
					throw new ArgumentOutOfRangeException("sourceStartIndex");
				}
				if (length <= 0)
				{
					throw new ArgumentOutOfRangeException("length");
				}
			}
			else
			{
				if (buffer == IntPtr.Zero)
				{
					return false;
				}
				if (startIndex < 0)
				{
					startIndex = 0;
				}
				if (length <= 0)
				{
					return false;
				}
			}
			int num = length;
			if (value != 0)
			{
				if (vKbcObsylNeOcCLPtczeZIGiOzJ == null)
				{
					vKbcObsylNeOcCLPtczeZIGiOzJ = new byte[8];
				}
				bool flag = false;
				if (num >= 8)
				{
					long val;
					lock (vKbcObsylNeOcCLPtczeZIGiOzJ)
					{
						for (int i = 0; i < 8; i++)
						{
							vKbcObsylNeOcCLPtczeZIGiOzJ[i] = value;
						}
						flag = true;
						val = BitConverter.ToInt64(vKbcObsylNeOcCLPtczeZIGiOzJ, 0);
					}
					int num2 = length / 8 * 8;
					for (int j = 0; j < num2; j += 8)
					{
						Marshal.WriteInt64(buffer, j + startIndex, val);
					}
					num %= 8;
				}
				if (num >= 4)
				{
					int val2;
					lock (vKbcObsylNeOcCLPtczeZIGiOzJ)
					{
						if (!flag)
						{
							for (int k = 0; k < 4; k++)
							{
								vKbcObsylNeOcCLPtczeZIGiOzJ[k] = value;
							}
							flag = true;
						}
						val2 = BitConverter.ToInt32(vKbcObsylNeOcCLPtczeZIGiOzJ, 0);
					}
					int num3 = length / 4 * 4;
					for (int l = length - num; l < num3; l += 4)
					{
						Marshal.WriteInt32(buffer, l + startIndex, val2);
					}
					num %= 4;
				}
				if (num >= 2)
				{
					short val3;
					lock (vKbcObsylNeOcCLPtczeZIGiOzJ)
					{
						if (!flag)
						{
							for (int m = 0; m < 2; m++)
							{
								vKbcObsylNeOcCLPtczeZIGiOzJ[m] = value;
							}
							flag = true;
						}
						val3 = BitConverter.ToInt16(vKbcObsylNeOcCLPtczeZIGiOzJ, 0);
					}
					int num4 = length / 2 * 2;
					for (int n = length - num; n < num4; n += 2)
					{
						Marshal.WriteInt16(buffer, n + startIndex, val3);
					}
					num %= 2;
				}
			}
			else
			{
				if (num >= 8)
				{
					int num5 = length / 8 * 8;
					for (int num6 = 0; num6 < num5; num6 += 8)
					{
						Marshal.WriteInt64(buffer, num6 + startIndex, 0L);
					}
					num %= 8;
				}
				if (num >= 4)
				{
					int num7 = length / 4 * 4;
					for (int num8 = length - num; num8 < num7; num8 += 4)
					{
						Marshal.WriteInt32(buffer, num8 + startIndex, 0);
					}
					num %= 4;
				}
				if (num >= 2)
				{
					int num9 = length / 2 * 2;
					for (int num10 = length - num; num10 < num9; num10 += 2)
					{
						Marshal.WriteInt16(buffer, num10 + startIndex, 0);
					}
					num %= 2;
				}
			}
			for (int num11 = length - num; num11 < length; num11++)
			{
				Marshal.WriteByte(buffer, num11 + startIndex, value);
			}
			return true;
		}

		public static bool FillMemory(byte[] buffer, int length, byte value, bool throwOnError = true)
		{
			return FillMemory(buffer, 0, length, value, throwOnError);
		}

		public static bool FillMemory(byte[] buffer, int startIndex, int length, byte value, bool throwOnError = true)
		{
			if (throwOnError)
			{
				if (buffer == null)
				{
					throw new ArgumentNullException("buffer");
				}
				if (startIndex < 0 || startIndex >= buffer.Length)
				{
					throw new ArgumentOutOfRangeException("startIndex");
				}
				if (length < 0 || length + startIndex > buffer.Length)
				{
					throw new ArgumentOutOfRangeException("length");
				}
			}
			else
			{
				if (buffer == null)
				{
					return false;
				}
				if (startIndex < 0 || startIndex >= buffer.Length)
				{
					return false;
				}
				if (length < 0 || length + startIndex > buffer.Length)
				{
					return false;
				}
			}
			try
			{
				bool result;
				lock (buffer)
				{
					GCHandle gCHandle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
					result = FillMemory(gCHandle.AddrOfPinnedObject(), startIndex, length, value, throwOnError);
					gCHandle.Free();
				}
				return result;
			}
			catch
			{
				if (throwOnError)
				{
					throw;
				}
				return false;
			}
		}

		public static void ZeroFillMemory(IntPtr buffer, int length)
		{
			if (buffer == IntPtr.Zero)
			{
				throw new ArgumentNullException("buffer");
			}
			if (length < 0)
			{
				throw new ArgumentOutOfRangeException("length");
			}
			int num = length;
			if (num >= 8)
			{
				int num2 = length / 8 * 8;
				for (int i = 0; i < num2; i += 8)
				{
					Marshal.WriteInt64(buffer, i, 0L);
				}
				num %= 8;
			}
			if (num >= 4)
			{
				int num3 = length / 4 * 4;
				for (int j = length - num; j < num3; j += 4)
				{
					Marshal.WriteInt32(buffer, j, 0);
				}
				num %= 4;
			}
			if (num >= 2)
			{
				int num4 = length / 2 * 2;
				for (int k = length - num; k < num4; k += 2)
				{
					Marshal.WriteInt16(buffer, k, 0);
				}
				num %= 2;
			}
			for (int l = length - num; l < length; l++)
			{
				Marshal.WriteByte(buffer, l, 0);
			}
		}

		public static string DumpToString(IntPtr buffer, int length, string stringFormat = "x2")
		{
			if (buffer == IntPtr.Zero)
			{
				return "Invalid buffer!";
			}
			try
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < length; i++)
				{
					stringBuilder.Append(Marshal.ReadByte(buffer, i).ToString(stringFormat));
					if (i < length - 1)
					{
						stringBuilder.Append(", ");
					}
				}
				return stringBuilder.ToString();
			}
			catch
			{
				return "Exception!";
			}
		}

		public static void FreeHGlobalSafe(ref IntPtr pointer)
		{
			if (!(pointer == IntPtr.Zero))
			{
				try
				{
					Marshal.FreeHGlobal(pointer);
				}
				catch
				{
				}
				pointer = IntPtr.Zero;
			}
		}
	}
}
