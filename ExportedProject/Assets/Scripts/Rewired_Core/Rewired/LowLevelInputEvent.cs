using System;
using System.Runtime.InteropServices;

namespace Rewired
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal struct LowLevelInputEvent
	{
		private const int wnPbBYZiSlFQUEjMPwBbjTqlSke = 4;

		private const int MvEBIsjKQCcdiMVwIGihjYBTfytr = 8;

		private const int NBqaojFgHyiNbAZxZdjWGZFojOu = 12;

		public const int buttonsPerPage = 32;

		public const int bytesPerButtonPage = 4;

		private const int evbAYKSgFiGVJWUFYGTyQGdhNXZ = 4;

		private const int BkQgfcHSNrBjGnaABIVMmpKzqzU = 4;

		public const int byteIndex_id = 0;

		public const int byteIndex_timestamp = 4;

		public const int byteIndex_elementsStart = 12;

		public IntPtr _buffer;

		private int gDXMqnwCwhCKwEWbXYfIdYmunKR;

		private int HUrvKXNmSdRrTKWEwIovQAsSEipJ;

		private int jkUjRKTApmafglzOsRUiurZItVM;

		private int sENigkHoSmheYFxTmqsiJwdCENSQ;

		private int GEAuHmMAyYFWaZjrTHMKojXbKFs;

		private int SUPreswcGZbGSxqfPpKlLJsTOcN;

		public bool isValid => _buffer != IntPtr.Zero;

		public int buttonCount => HUrvKXNmSdRrTKWEwIovQAsSEipJ;

		public int axisCount => jkUjRKTApmafglzOsRUiurZItVM;

		public int byteIndex_axesStart => sENigkHoSmheYFxTmqsiJwdCENSQ;

		public int byteIndex_buttonsStart => GEAuHmMAyYFWaZjrTHMKojXbKFs;

		public int byteIndex_hatsStart => SUPreswcGZbGSxqfPpKlLJsTOcN;

		public LowLevelInputEvent(IntPtr buffer, int buttonCount, int axisCount, int hatCount)
		{
			if (buttonCount == 0 && axisCount == 0)
			{
				throw new ArgumentOutOfRangeException("No elements defined in event.");
			}
			_buffer = buffer;
			HUrvKXNmSdRrTKWEwIovQAsSEipJ = buttonCount;
			jkUjRKTApmafglzOsRUiurZItVM = axisCount;
			GEAuHmMAyYFWaZjrTHMKojXbKFs = 12;
			sENigkHoSmheYFxTmqsiJwdCENSQ = GEAuHmMAyYFWaZjrTHMKojXbKFs + ((buttonCount > 0) ? (((buttonCount - 1) / 32 + 1) * 4) : 0);
			SUPreswcGZbGSxqfPpKlLJsTOcN = sENigkHoSmheYFxTmqsiJwdCENSQ + axisCount * 4;
			gDXMqnwCwhCKwEWbXYfIdYmunKR = GetReportSize(buttonCount, axisCount, hatCount);
		}

		public void SetButtonsBitMask(int bitMask, int startButtonIndex)
		{
			if (gDXMqnwCwhCKwEWbXYfIdYmunKR > 0)
			{
				if (startButtonIndex % 32 != 0)
				{
					throw new Exception("startIndex must be divisible by 32.");
				}
				Marshal.WriteInt32(_buffer, GEAuHmMAyYFWaZjrTHMKojXbKFs + startButtonIndex / 4, bitMask);
			}
		}

		public void SetAxisValue(int index, float value)
		{
			if (gDXMqnwCwhCKwEWbXYfIdYmunKR > 0)
			{
				Marshal.WriteInt32(_buffer, sENigkHoSmheYFxTmqsiJwdCENSQ + index * 4, new TJlAwiQapyjSBxkvhUWLcPDrjJf(value).uRzGXdtvMiFBPVOOvOLRnOmUrvt);
			}
		}

		public void SetId(uint id)
		{
			if (gDXMqnwCwhCKwEWbXYfIdYmunKR > 0)
			{
				Marshal.WriteInt32(_buffer, 0, (int)id);
			}
		}

		public void SetTimestamp(double value)
		{
			if (gDXMqnwCwhCKwEWbXYfIdYmunKR > 0)
			{
				Marshal.WriteInt64(_buffer, 4, new QHftpXnIBxjRtQHCvcETfBWNJIQ(value).WoeTWZNwXVFZTqCPxCjhxNhvYSS);
			}
		}

		public bool GetButtonValue(int index)
		{
			if (gDXMqnwCwhCKwEWbXYfIdYmunKR <= 0)
			{
				return false;
			}
			if (buttonCount == 0)
			{
				return false;
			}
			int num = index / 32;
			int num2 = (index - num * 32) / 8;
			int num3 = index % 8;
			return (Marshal.ReadByte(_buffer, GEAuHmMAyYFWaZjrTHMKojXbKFs + num * 4 + num2) & (1 << num3)) != 0;
		}

		public int GetButtonsBitMask(int startButtonIndex)
		{
			if (gDXMqnwCwhCKwEWbXYfIdYmunKR <= 0)
			{
				return 0;
			}
			if (startButtonIndex % 32 != 0)
			{
				throw new Exception("startIndex must be divisible by 32.");
			}
			return Marshal.ReadInt32(_buffer, GEAuHmMAyYFWaZjrTHMKojXbKFs + startButtonIndex / 4);
		}

		public float GetAxisValue(int index)
		{
			if (gDXMqnwCwhCKwEWbXYfIdYmunKR <= 0)
			{
				return 0f;
			}
			return new TJlAwiQapyjSBxkvhUWLcPDrjJf(Marshal.ReadInt32(_buffer, sENigkHoSmheYFxTmqsiJwdCENSQ + index * 4)).xpgopNfshxLoWBInXaTotelWpDa;
		}

		public uint GetId()
		{
			if (gDXMqnwCwhCKwEWbXYfIdYmunKR <= 0)
			{
				return 0u;
			}
			return (uint)Marshal.ReadInt32(_buffer, 0);
		}

		public double GetTimestamp()
		{
			if (gDXMqnwCwhCKwEWbXYfIdYmunKR <= 0)
			{
				return 0.0;
			}
			return new QHftpXnIBxjRtQHCvcETfBWNJIQ(Marshal.ReadInt64(_buffer, 4)).gATfKgGeQKaQJfiZmBjyhIvYwWL;
		}

		public static int GetReportSize(int buttonCount, int axisCount, int hatCount)
		{
			return 12 + ((buttonCount > 0) ? (((buttonCount - 1) / 32 + 1) * 4) : 0) + axisCount * 4 + hatCount * 4;
		}
	}
}
