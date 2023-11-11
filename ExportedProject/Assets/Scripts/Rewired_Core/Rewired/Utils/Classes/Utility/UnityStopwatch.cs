using System;
using UnityEngine;

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal sealed class UnityStopwatch : StopwatchBase
	{
		private class quGIHynwiBpQSOAGzEUTiagNNEGR
		{
			public const long vdkFlAFaipbJrrGdsYvrzzIJdqM = 10000000L;

			private double LsolnxRkZUgtBvkdPIfhCLbAFYm;

			private bool ChCbRyIZHWEtbcoyhqxGJRCujLn;

			private double DfiJduYcmfxbZUygkFhhmwBiUVv;

			private double UEZLqNoVJswwFkhjUVMkgmppBhQ;

			public bool UEvPTSMKbUnBYLxicJggDNgVlzC => ChCbRyIZHWEtbcoyhqxGJRCujLn;

			public double iwgcecjWzTrjVwuOcEbVHNYhnkOM
			{
				get
				{
					if (!ChCbRyIZHWEtbcoyhqxGJRCujLn)
					{
						return UEZLqNoVJswwFkhjUVMkgmppBhQ;
					}
					return (double)Time.realtimeSinceStartup - DfiJduYcmfxbZUygkFhhmwBiUVv;
				}
			}

			public void mtiNfGzpXHszOwiOIAVYQuMZclV()
			{
				LsolnxRkZUgtBvkdPIfhCLbAFYm = Time.realtimeSinceStartup;
			}

			public void tvCBgIPnqjaOIPTXBTydmcrRbzF()
			{
				if (!ChCbRyIZHWEtbcoyhqxGJRCujLn)
				{
					ChCbRyIZHWEtbcoyhqxGJRCujLn = true;
					DfiJduYcmfxbZUygkFhhmwBiUVv = LsolnxRkZUgtBvkdPIfhCLbAFYm;
				}
			}

			public void yIdByDKOOIBtDKUNHTJwNjHwPBV()
			{
				if (ChCbRyIZHWEtbcoyhqxGJRCujLn)
				{
					ChCbRyIZHWEtbcoyhqxGJRCujLn = false;
					UEZLqNoVJswwFkhjUVMkgmppBhQ += LsolnxRkZUgtBvkdPIfhCLbAFYm - DfiJduYcmfxbZUygkFhhmwBiUVv;
				}
			}

			public void skeOSBSqSPGPnIZySfEhxuCHbTXM()
			{
				DfiJduYcmfxbZUygkFhhmwBiUVv = 0.0;
				UEZLqNoVJswwFkhjUVMkgmppBhQ = 0.0;
				bool chCbRyIZHWEtbcoyhqxGJRCujLn = ChCbRyIZHWEtbcoyhqxGJRCujLn;
				ChCbRyIZHWEtbcoyhqxGJRCujLn = false;
				if (chCbRyIZHWEtbcoyhqxGJRCujLn)
				{
					tvCBgIPnqjaOIPTXBTydmcrRbzF();
				}
			}
		}

		private const long gNjqnnuQVOZHHoSYMdVdoBqSfHW = 10000000L;

		private static UnityStopwatch hFJKcUsuLLrlHhDkoRZbpXrTpxe;

		private readonly quGIHynwiBpQSOAGzEUTiagNNEGR fQPWZrRCnzcxWOLdDHQzbedwMBDI;

		private readonly bool wKWfIohcBSItjodnorxgoelvelB;

		private double NGUcxhJgXqvXMmxuRDvaPrTaBJa;

		public static UnityStopwatch Global => hFJKcUsuLLrlHhDkoRZbpXrTpxe ?? (hFJKcUsuLLrlHhDkoRZbpXrTpxe = new UnityStopwatch(isGlobal: true));

		public static long frequency => 10000000L;

		public override double offsetSeconds
		{
			get
			{
				return NGUcxhJgXqvXMmxuRDvaPrTaBJa;
			}
			set
			{
				NGUcxhJgXqvXMmxuRDvaPrTaBJa = value;
			}
		}

		public override long offsetTicks
		{
			get
			{
				return (long)(NGUcxhJgXqvXMmxuRDvaPrTaBJa * 10000000.0);
			}
			set
			{
				NGUcxhJgXqvXMmxuRDvaPrTaBJa = (double)value / 10000000.0;
			}
		}

		public override double elapsedSeconds => fQPWZrRCnzcxWOLdDHQzbedwMBDI.iwgcecjWzTrjVwuOcEbVHNYhnkOM + offsetSeconds;

		public override double elapsedSecondsRaw => fQPWZrRCnzcxWOLdDHQzbedwMBDI.iwgcecjWzTrjVwuOcEbVHNYhnkOM;

		public override long elapsedMilliseconds => (long)((fQPWZrRCnzcxWOLdDHQzbedwMBDI.iwgcecjWzTrjVwuOcEbVHNYhnkOM + NGUcxhJgXqvXMmxuRDvaPrTaBJa) * 1000.0);

		public override long elapsedMillisecondsRaw => (long)(fQPWZrRCnzcxWOLdDHQzbedwMBDI.iwgcecjWzTrjVwuOcEbVHNYhnkOM * 1000.0);

		public override long elapsedTicks => (long)(elapsedSeconds * 10000000.0);

		public override long elapsedTicksRaw => (long)(elapsedSecondsRaw * 10000000.0);

		public override bool isRunning => fQPWZrRCnzcxWOLdDHQzbedwMBDI.UEvPTSMKbUnBYLxicJggDNgVlzC;

		public static UnityStopwatch StartNew()
		{
			UnityStopwatch unityStopwatch = new UnityStopwatch(isGlobal: false);
			unityStopwatch.Start();
			return unityStopwatch;
		}

		public static long ConvertTo100NSTicks(long ticks)
		{
			return ticks;
		}

		public UnityStopwatch()
			: this(isGlobal: false)
		{
		}

		private UnityStopwatch(bool isGlobal)
		{
			fQPWZrRCnzcxWOLdDHQzbedwMBDI = new quGIHynwiBpQSOAGzEUTiagNNEGR();
			EaAqwAnbDHaHHOabLilFJilXEPxA();
			if (isGlobal)
			{
				Start();
			}
			wKWfIohcBSItjodnorxgoelvelB = isGlobal;
		}

		~UnityStopwatch()
		{
			MCbAfFjWjCNSiFRLQjJMUZWaKAx();
		}

		public override void Stop()
		{
			if (wKWfIohcBSItjodnorxgoelvelB)
			{
				throw new Exception("The Global Stopwatch cannot be stopped.");
			}
			fQPWZrRCnzcxWOLdDHQzbedwMBDI.yIdByDKOOIBtDKUNHTJwNjHwPBV();
		}

		public override void Start()
		{
			if (!wKWfIohcBSItjodnorxgoelvelB)
			{
				fQPWZrRCnzcxWOLdDHQzbedwMBDI.tvCBgIPnqjaOIPTXBTydmcrRbzF();
			}
		}

		public override void Reset()
		{
			if (wKWfIohcBSItjodnorxgoelvelB)
			{
				throw new Exception("The Global Stopwatch cannot be reset.");
			}
			fQPWZrRCnzcxWOLdDHQzbedwMBDI.skeOSBSqSPGPnIZySfEhxuCHbTXM();
		}

		private void EaAqwAnbDHaHHOabLilFJilXEPxA()
		{
			MCbAfFjWjCNSiFRLQjJMUZWaKAx();
			ReInput.BeforeTimeManagerUpdateEvent += EsMhoPqAHoBFPBeDrJCrkGzDsbv;
		}

		private void MCbAfFjWjCNSiFRLQjJMUZWaKAx()
		{
			ReInput.BeforeTimeManagerUpdateEvent -= EsMhoPqAHoBFPBeDrJCrkGzDsbv;
		}

		private void EsMhoPqAHoBFPBeDrJCrkGzDsbv(UpdateLoopType P_0)
		{
			fQPWZrRCnzcxWOLdDHQzbedwMBDI.mtiNfGzpXHszOwiOIAVYQuMZclV();
		}
	}
}
