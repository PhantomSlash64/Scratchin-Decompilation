using System;
using System.Runtime.InteropServices;

namespace Rewired.HID
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal struct OutputReport
	{
		public IntPtr buffer;

		public int bufferLength;

		public int reportLength;

		public OutputReportOptions options;

		public bool IsValid
		{
			get
			{
				if (buffer != IntPtr.Zero && bufferLength > 0)
				{
					return reportLength > 0;
				}
				return false;
			}
		}

		public OutputReport(IntPtr buffer, int bufferLength, int reportLength)
		{
			this.buffer = buffer;
			this.bufferLength = bufferLength;
			this.reportLength = reportLength;
			options = OutputReportOptions.fUyeeVFhkdEderlnmYYFoAwmZEL;
		}

		public void Clear()
		{
			buffer = IntPtr.Zero;
			bufferLength = 0;
			reportLength = 0;
			options = OutputReportOptions.fUyeeVFhkdEderlnmYYFoAwmZEL;
		}

		public override string ToString()
		{
			string text = "OutputReport:\n";
			text = text + "buffer = " + ((buffer == IntPtr.Zero) ? "NULL" : ("Is Valid (" + buffer + ")")) + "\n";
			object obj = text;
			text = string.Concat(obj, "bufferLength = ", bufferLength, "\n");
			object obj2 = text;
			text = string.Concat(obj2, "reportLength = ", reportLength, "\n");
			object obj3 = text;
			text = string.Concat(obj3, "options = ", (int)options, "\n");
			if (buffer != IntPtr.Zero)
			{
				text += "Buffer data:\n";
				for (int i = 0; i < reportLength; i++)
				{
					text += Marshal.ReadByte(buffer, i).ToString("X2");
					if (i < reportLength - 1)
					{
						text += ", ";
					}
				}
			}
			return text;
		}
	}
}
