using System;
using System.Diagnostics;

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal sealed class Stopwatch : StopwatchBase
	{
		private const long gNjqnnuQVOZHHoSYMdVdoBqSfHW = 10000000L;

		public static readonly Stopwatch Global;

		private static long LdwxqtydBpHBVnMpqIRMJPclBOM;

		private System.Diagnostics.Stopwatch fQPWZrRCnzcxWOLdDHQzbedwMBDI;

		private long tbzVeJmNNocaTkdAlrJTBKCxEJr;

		public static long frequency => LdwxqtydBpHBVnMpqIRMJPclBOM;

		public override double offsetSeconds
		{
			get
			{
				return (double)tbzVeJmNNocaTkdAlrJTBKCxEJr / (double)LdwxqtydBpHBVnMpqIRMJPclBOM;
			}
			set
			{
				tbzVeJmNNocaTkdAlrJTBKCxEJr = (long)(value * (double)LdwxqtydBpHBVnMpqIRMJPclBOM);
			}
		}

		public override long offsetTicks
		{
			get
			{
				return tbzVeJmNNocaTkdAlrJTBKCxEJr;
			}
			set
			{
				tbzVeJmNNocaTkdAlrJTBKCxEJr = value;
			}
		}

		public override double elapsedSeconds => (double)(fQPWZrRCnzcxWOLdDHQzbedwMBDI.ElapsedTicks + offsetTicks) / (double)LdwxqtydBpHBVnMpqIRMJPclBOM;

		public override double elapsedSecondsRaw => (double)fQPWZrRCnzcxWOLdDHQzbedwMBDI.ElapsedTicks / (double)LdwxqtydBpHBVnMpqIRMJPclBOM;

		public override long elapsedMilliseconds => (long)((double)(fQPWZrRCnzcxWOLdDHQzbedwMBDI.ElapsedTicks + offsetTicks) / (double)LdwxqtydBpHBVnMpqIRMJPclBOM * 1000.0);

		public override long elapsedMillisecondsRaw => fQPWZrRCnzcxWOLdDHQzbedwMBDI.ElapsedMilliseconds;

		public override long elapsedTicks => fQPWZrRCnzcxWOLdDHQzbedwMBDI.ElapsedTicks + tbzVeJmNNocaTkdAlrJTBKCxEJr;

		public override long elapsedTicksRaw => fQPWZrRCnzcxWOLdDHQzbedwMBDI.ElapsedTicks;

		public override bool isRunning => fQPWZrRCnzcxWOLdDHQzbedwMBDI.IsRunning;

		static Stopwatch()
		{
			LdwxqtydBpHBVnMpqIRMJPclBOM = System.Diagnostics.Stopwatch.Frequency;
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			Global = stopwatch;
		}

		public static Stopwatch StartNew()
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			return stopwatch;
		}

		public static long ConvertTo100NSTicks(long ticks)
		{
			if (LdwxqtydBpHBVnMpqIRMJPclBOM == 10000000)
			{
				return ticks;
			}
			return 10000000 / LdwxqtydBpHBVnMpqIRMJPclBOM;
		}

		public Stopwatch()
		{
			fQPWZrRCnzcxWOLdDHQzbedwMBDI = new System.Diagnostics.Stopwatch();
		}

		public override void Stop()
		{
			if (this == Global)
			{
				throw new Exception("The Global Stopwatch cannot be stopped.");
			}
			fQPWZrRCnzcxWOLdDHQzbedwMBDI.Stop();
		}

		public override void Start()
		{
			if (this != Global)
			{
				fQPWZrRCnzcxWOLdDHQzbedwMBDI.Start();
			}
		}

		public override void Reset()
		{
			if (this == Global)
			{
				throw new Exception("The Global Stopwatch cannot be reset.");
			}
			fQPWZrRCnzcxWOLdDHQzbedwMBDI.Reset();
		}
	}
}
