using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Rewired.Utils.Classes.Utility
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class ThreadHelper : IDisposable
	{
		private const uint JjOVdcnnDdQVtbDtVcylQmomiali = 750u;

		private readonly Stopwatch fQPWZrRCnzcxWOLdDHQzbedwMBDI;

		private Thread LzOmxoEMyXdHGDFTmboJhhMxKvwE;

		private ManualResetEvent ljZbtvAOgsEYbQgwAmpJWLqetdL;

		private ManualResetEvent yarhMshJPcIIlPnYTSSgulUsvYo;

		private AutoResetEvent xruTJcLdWWCRShBFFHXtGpWBSyck;

		private bool LjPPYGJnQshbOiYarAwVdLoqHyO;

		private bool ChCbRyIZHWEtbcoyhqxGJRCujLn;

		private int mQCXTXLlAtbTSAkmRivNmogwEVe;

		private bool STvOpyYjRBYCuaitVxxYFidQTSE;

		private int NScXDPknqEIYejHQHSxCrRaXrMj;

		private long kjAgueblJJkGbkmzwHIJeakopVMv;

		private bool EDjUMVmaPEfPRJxuOCORKhihkCYv;

		private int FtCZlilTYyrMLddqdjphXeaXqOZ;

		private long EDuHAGAZfPmupMoDVNrnShCjuSq;

		private uint imrUWPyOeXsnwATglTIMIZLIvZe;

		private readonly object nLuFFzcSnThtkzUqpqhzRKgPHMnW;

		private Queue<Action> hJkETGUDlrquKPdcbJRVQfIktfb;

		private Queue<Action> STcEBdOOYafDpdqROKDvAjSIakVf;

		private bool sUELaJIkmxAoZKbueikQVDgJAnE;

		private Action NPuNUHKLWnEzxvgSFeCieVzSaCc;

		private Action oYMxpTCiahUDQvEgrgnLjlpohgcL;

		private Action qErdFZrBQxibrEtkOEGxOJoVxOu;

		private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

		public bool isRunning => ChCbRyIZHWEtbcoyhqxGJRCujLn;

		public bool isStopped
		{
			get
			{
				if (!ChCbRyIZHWEtbcoyhqxGJRCujLn)
				{
					if (LzOmxoEMyXdHGDFTmboJhhMxKvwE == null)
					{
						return true;
					}
					return !LzOmxoEMyXdHGDFTmboJhhMxKvwE.IsAlive;
				}
				return false;
			}
		}

		public bool useHighPrecitionTimer
		{
			get
			{
				if (!STvOpyYjRBYCuaitVxxYFidQTSE)
				{
					return (long)NScXDPknqEIYejHQHSxCrRaXrMj >= 750L;
				}
				return true;
			}
			set
			{
				if (value != STvOpyYjRBYCuaitVxxYFidQTSE)
				{
					STvOpyYjRBYCuaitVxxYFidQTSE = value;
					BqQFOUiMyxByYedSdsBdfnbOEpTq();
				}
			}
		}

		public bool useFixedTimeStep => EDjUMVmaPEfPRJxuOCORKhihkCYv;

		public int fixedTimeStepFPS
		{
			get
			{
				return NScXDPknqEIYejHQHSxCrRaXrMj;
			}
			set
			{
				NScXDPknqEIYejHQHSxCrRaXrMj = ((value > 0) ? value : 0);
				BqQFOUiMyxByYedSdsBdfnbOEpTq();
			}
		}

		public int timeoutMS
		{
			get
			{
				return FtCZlilTYyrMLddqdjphXeaXqOZ;
			}
			set
			{
				FtCZlilTYyrMLddqdjphXeaXqOZ = ((value > 0) ? value : 0);
				BqQFOUiMyxByYedSdsBdfnbOEpTq();
			}
		}

		public uint tick => imrUWPyOeXsnwATglTIMIZLIvZe;

		public event Action ThreadUpdateEvent
		{
			add
			{
				NPuNUHKLWnEzxvgSFeCieVzSaCc = (Action)Delegate.Combine(NPuNUHKLWnEzxvgSFeCieVzSaCc, value);
			}
			remove
			{
				NPuNUHKLWnEzxvgSFeCieVzSaCc = (Action)Delegate.Remove(NPuNUHKLWnEzxvgSFeCieVzSaCc, value);
			}
		}

		private event Action _ThreadStartedEvent
		{
			add
			{
				Action action = oYMxpTCiahUDQvEgrgnLjlpohgcL;
				Action action2;
				do
				{
					action2 = action;
					Action value2 = (Action)Delegate.Combine(action2, value);
					action = Interlocked.CompareExchange(ref oYMxpTCiahUDQvEgrgnLjlpohgcL, value2, action2);
				}
				while ((object)action != action2);
			}
			remove
			{
				Action action = oYMxpTCiahUDQvEgrgnLjlpohgcL;
				Action action2;
				do
				{
					action2 = action;
					Action value2 = (Action)Delegate.Remove(action2, value);
					action = Interlocked.CompareExchange(ref oYMxpTCiahUDQvEgrgnLjlpohgcL, value2, action2);
				}
				while ((object)action != action2);
			}
		}

		public event Action ThreadStartedEvent
		{
			add
			{
				_ThreadStartedEvent += value;
			}
			remove
			{
				_ThreadStartedEvent -= value;
			}
		}

		private event Action _ThreadPreStopEvent
		{
			add
			{
				Action action = qErdFZrBQxibrEtkOEGxOJoVxOu;
				Action action2;
				do
				{
					action2 = action;
					Action value2 = (Action)Delegate.Combine(action2, value);
					action = Interlocked.CompareExchange(ref qErdFZrBQxibrEtkOEGxOJoVxOu, value2, action2);
				}
				while ((object)action != action2);
			}
			remove
			{
				Action action = qErdFZrBQxibrEtkOEGxOJoVxOu;
				Action action2;
				do
				{
					action2 = action;
					Action value2 = (Action)Delegate.Remove(action2, value);
					action = Interlocked.CompareExchange(ref qErdFZrBQxibrEtkOEGxOJoVxOu, value2, action2);
				}
				while ((object)action != action2);
			}
		}

		public event Action ThreadPreStopEvent
		{
			add
			{
				_ThreadPreStopEvent += value;
			}
			remove
			{
				_ThreadPreStopEvent -= value;
			}
		}

		public static ThreadHelper Create(bool fixedTimeStep = false, int fixedTimeStepFPS = 100, bool useHighPrecisionTimer = false, int timeoutMS = 0)
		{
			if (fixedTimeStep)
			{
				return new ThreadHelper(fixedTimeStepFPS, useHighPrecisionTimer, timeoutMS);
			}
			return new ThreadHelper(timeoutMS);
		}

		public static ThreadHelper CreateFixedTimeStep(int timeStepFPS, int timeoutMS = 0)
		{
			return CreateFixedTimeStep(timeStepFPS, useHighPrecisionTimer: false, timeoutMS);
		}

		public static ThreadHelper CreateFixedTimeStep(int timeStepFPS, bool useHighPrecisionTimer = false, int timeoutMS = 0)
		{
			return new ThreadHelper(timeStepFPS, useHighPrecisionTimer, timeoutMS);
		}

		private ThreadHelper()
			: this(0)
		{
		}

		private ThreadHelper(int timeoutMS)
			: this(0, useHighPrecisionTimer: false, timeoutMS)
		{
		}

		private ThreadHelper(int fixedTimeStepFPS, bool useHighPrecisionTimer, int timeoutMS)
		{
			fQPWZrRCnzcxWOLdDHQzbedwMBDI = Stopwatch.Global;
			if (fixedTimeStepFPS < 0)
			{
				fixedTimeStepFPS = 0;
			}
			if (timeoutMS < 0)
			{
				timeoutMS = 0;
			}
			FtCZlilTYyrMLddqdjphXeaXqOZ = timeoutMS;
			NScXDPknqEIYejHQHSxCrRaXrMj = fixedTimeStepFPS;
			STvOpyYjRBYCuaitVxxYFidQTSE = useHighPrecisionTimer;
			BqQFOUiMyxByYedSdsBdfnbOEpTq();
			ljZbtvAOgsEYbQgwAmpJWLqetdL = new ManualResetEvent(initialState: false);
			yarhMshJPcIIlPnYTSSgulUsvYo = new ManualResetEvent(initialState: false);
			xruTJcLdWWCRShBFFHXtGpWBSyck = new AutoResetEvent(initialState: false);
			nLuFFzcSnThtkzUqpqhzRKgPHMnW = new object();
			hJkETGUDlrquKPdcbJRVQfIktfb = new Queue<Action>();
			STcEBdOOYafDpdqROKDvAjSIakVf = new Queue<Action>();
		}

		public bool Start(bool wait)
		{
			if (ChCbRyIZHWEtbcoyhqxGJRCujLn)
			{
				return false;
			}
			try
			{
				ljZbtvAOgsEYbQgwAmpJWLqetdL.Reset();
				xruTJcLdWWCRShBFFHXtGpWBSyck.Reset();
				LzOmxoEMyXdHGDFTmboJhhMxKvwE = new Thread(COvBkzWVFumRjqhpZBSHGfIsISV);
				LzOmxoEMyXdHGDFTmboJhhMxKvwE.Start();
				if (wait)
				{
					ljZbtvAOgsEYbQgwAmpJWLqetdL.WaitOne();
				}
				return true;
			}
			catch (Exception)
			{
				return false;
			}
		}

		public void Stop(bool wait)
		{
			if (LzOmxoEMyXdHGDFTmboJhhMxKvwE != null && ChCbRyIZHWEtbcoyhqxGJRCujLn && LjPPYGJnQshbOiYarAwVdLoqHyO)
			{
				ljZbtvAOgsEYbQgwAmpJWLqetdL.Reset();
				LjPPYGJnQshbOiYarAwVdLoqHyO = false;
				xruTJcLdWWCRShBFFHXtGpWBSyck.Set();
				if (wait)
				{
					ljZbtvAOgsEYbQgwAmpJWLqetdL.WaitOne();
				}
				OrtqCOFFOrtonVeKwJffJoiHExO();
			}
		}

		public bool EnqueueAction(Action action)
		{
			if (action == null)
			{
				return false;
			}
			if (!ChCbRyIZHWEtbcoyhqxGJRCujLn)
			{
				return false;
			}
			if (!LjPPYGJnQshbOiYarAwVdLoqHyO)
			{
				return false;
			}
			ResetTimeout();
			lock (nLuFFzcSnThtkzUqpqhzRKgPHMnW)
			{
				hJkETGUDlrquKPdcbJRVQfIktfb.Enqueue(action);
				sUELaJIkmxAoZKbueikQVDgJAnE = true;
				xruTJcLdWWCRShBFFHXtGpWBSyck.Set();
			}
			return true;
		}

		public bool InvokeActionSync(Action action)
		{
			if (!ChCbRyIZHWEtbcoyhqxGJRCujLn)
			{
				return false;
			}
			if (!LjPPYGJnQshbOiYarAwVdLoqHyO)
			{
				return false;
			}
			EnqueueAction(action);
			WaitForActionQueueToFinish();
			return true;
		}

		public void WaitForActionQueueToFinish()
		{
			if (!ChCbRyIZHWEtbcoyhqxGJRCujLn || !LjPPYGJnQshbOiYarAwVdLoqHyO)
			{
				return;
			}
			ResetTimeout();
			lock (nLuFFzcSnThtkzUqpqhzRKgPHMnW)
			{
				yarhMshJPcIIlPnYTSSgulUsvYo.Reset();
				mQCXTXLlAtbTSAkmRivNmogwEVe++;
			}
			xruTJcLdWWCRShBFFHXtGpWBSyck.Set();
			yarhMshJPcIIlPnYTSSgulUsvYo.WaitOne();
			lock (nLuFFzcSnThtkzUqpqhzRKgPHMnW)
			{
				mQCXTXLlAtbTSAkmRivNmogwEVe--;
			}
		}

		public void ResetTimeout()
		{
			EDuHAGAZfPmupMoDVNrnShCjuSq = ((FtCZlilTYyrMLddqdjphXeaXqOZ > 0) ? (fQPWZrRCnzcxWOLdDHQzbedwMBDI.elapsedMillisecondsRaw + FtCZlilTYyrMLddqdjphXeaXqOZ) : 0);
		}

		private void COvBkzWVFumRjqhpZBSHGfIsISV()
		{
			ResetTimeout();
			ChCbRyIZHWEtbcoyhqxGJRCujLn = true;
			LjPPYGJnQshbOiYarAwVdLoqHyO = true;
			ljZbtvAOgsEYbQgwAmpJWLqetdL.Set();
			if (oYMxpTCiahUDQvEgrgnLjlpohgcL != null)
			{
				lock (oYMxpTCiahUDQvEgrgnLjlpohgcL)
				{
					try
					{
						oYMxpTCiahUDQvEgrgnLjlpohgcL();
					}
					catch (Exception ex)
					{
						Logger.LogError("Caught exception in thread start event callback.\n" + ex, requiredThreadSafety: true);
					}
				}
			}
			while (LjPPYGJnQshbOiYarAwVdLoqHyO)
			{
				long elapsedTicksRaw = fQPWZrRCnzcxWOLdDHQzbedwMBDI.elapsedTicksRaw;
				long num = elapsedTicksRaw + kjAgueblJJkGbkmzwHIJeakopVMv;
				mWaCmonKVhbpaFjTKmWCXFRNpTi();
				lock (nLuFFzcSnThtkzUqpqhzRKgPHMnW)
				{
					if (!sUELaJIkmxAoZKbueikQVDgJAnE && mQCXTXLlAtbTSAkmRivNmogwEVe > 0)
					{
						yarhMshJPcIIlPnYTSSgulUsvYo.Set();
					}
				}
				if (NPuNUHKLWnEzxvgSFeCieVzSaCc != null)
				{
					try
					{
						NPuNUHKLWnEzxvgSFeCieVzSaCc();
					}
					catch (Exception ex2)
					{
						Logger.LogError("Exception occurred in a Thread Update Event callback.\n" + ex2, requiredThreadSafety: true);
					}
				}
				if (EDjUMVmaPEfPRJxuOCORKhihkCYv)
				{
					if (STvOpyYjRBYCuaitVxxYFidQTSE || (long)NScXDPknqEIYejHQHSxCrRaXrMj >= 750L)
					{
						while (fQPWZrRCnzcxWOLdDHQzbedwMBDI.elapsedTicksRaw < num)
						{
						}
					}
					else
					{
						long num2 = num - fQPWZrRCnzcxWOLdDHQzbedwMBDI.elapsedTicksRaw;
						if (num2 > 0)
						{
							xruTJcLdWWCRShBFFHXtGpWBSyck.WaitOne(TimeSpan.FromTicks(Stopwatch.ConvertTo100NSTicks(num2)));
						}
					}
				}
				imrUWPyOeXsnwATglTIMIZLIvZe = ((imrUWPyOeXsnwATglTIMIZLIvZe != uint.MaxValue) ? (imrUWPyOeXsnwATglTIMIZLIvZe + 1) : 0u);
				if (FtCZlilTYyrMLddqdjphXeaXqOZ > 0 && fQPWZrRCnzcxWOLdDHQzbedwMBDI.elapsedMillisecondsRaw >= EDuHAGAZfPmupMoDVNrnShCjuSq)
				{
					LjPPYGJnQshbOiYarAwVdLoqHyO = false;
				}
			}
			if (qErdFZrBQxibrEtkOEGxOJoVxOu != null)
			{
				lock (qErdFZrBQxibrEtkOEGxOJoVxOu)
				{
					try
					{
						qErdFZrBQxibrEtkOEGxOJoVxOu();
					}
					catch (Exception ex3)
					{
						Logger.LogError("Caught exception in thread pre-stop event event callback.\n" + ex3, requiredThreadSafety: true);
					}
				}
			}
			ChCbRyIZHWEtbcoyhqxGJRCujLn = false;
			ljZbtvAOgsEYbQgwAmpJWLqetdL.Set();
		}

		private void mWaCmonKVhbpaFjTKmWCXFRNpTi()
		{
			if (!sUELaJIkmxAoZKbueikQVDgJAnE)
			{
				return;
			}
			lock (nLuFFzcSnThtkzUqpqhzRKgPHMnW)
			{
				MiscTools.Swap(ref hJkETGUDlrquKPdcbJRVQfIktfb, ref STcEBdOOYafDpdqROKDvAjSIakVf);
				sUELaJIkmxAoZKbueikQVDgJAnE = false;
			}
			while (STcEBdOOYafDpdqROKDvAjSIakVf.Count > 0)
			{
				Action action = STcEBdOOYafDpdqROKDvAjSIakVf.Dequeue();
				try
				{
					action();
				}
				catch (Exception ex)
				{
					Logger.LogError("Exception occurred while processing thread Action queue.\n" + ex, requiredThreadSafety: true);
				}
			}
		}

		private void BqQFOUiMyxByYedSdsBdfnbOEpTq()
		{
			if (NScXDPknqEIYejHQHSxCrRaXrMj <= 0)
			{
				EDjUMVmaPEfPRJxuOCORKhihkCYv = false;
			}
			else
			{
				EDjUMVmaPEfPRJxuOCORKhihkCYv = true;
				kjAgueblJJkGbkmzwHIJeakopVMv = Stopwatch.frequency / NScXDPknqEIYejHQHSxCrRaXrMj;
			}
			ResetTimeout();
		}

		private void OrtqCOFFOrtonVeKwJffJoiHExO()
		{
			LzOmxoEMyXdHGDFTmboJhhMxKvwE = null;
			ChCbRyIZHWEtbcoyhqxGJRCujLn = false;
			LjPPYGJnQshbOiYarAwVdLoqHyO = false;
			hJkETGUDlrquKPdcbJRVQfIktfb.Clear();
			STcEBdOOYafDpdqROKDvAjSIakVf.Clear();
			sUELaJIkmxAoZKbueikQVDgJAnE = false;
			mQCXTXLlAtbTSAkmRivNmogwEVe = 0;
			ljZbtvAOgsEYbQgwAmpJWLqetdL.Reset();
			yarhMshJPcIIlPnYTSSgulUsvYo.Reset();
			EDuHAGAZfPmupMoDVNrnShCjuSq = 0L;
			imrUWPyOeXsnwATglTIMIZLIvZe = 0u;
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		~ThreadHelper()
		{
			Dispose(disposing: false);
		}

		protected void Dispose(bool disposing)
		{
			if (!RFSEgUYkCipDyWyLEnlGiNDUlzz)
			{
				if (disposing)
				{
					Stop(wait: true);
				}
				else
				{
					LjPPYGJnQshbOiYarAwVdLoqHyO = false;
				}
				RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
			}
		}

		[Conditional("DEBUG_THREAD_HELPER")]
		private static void PsBtDoqfrXPWdgiDNsYZsnttUhy(object P_0)
		{
			if (P_0 != null)
			{
				Logger.Log(P_0, requiredThreadSafety: true);
			}
		}
	}
}
