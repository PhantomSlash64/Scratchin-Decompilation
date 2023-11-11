using System;
using System.Collections.Generic;

namespace Rewired.Utils.Classes.Utility
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class ThreadedMessageQueue<T> : IDisposable
	{
		private readonly int ZmAswzqeDirHkhkAZcNhgPmsUVQl;

		private readonly int kjjorxbSbjbYIIfRoSjrqIqIFNo;

		private readonly int AsCQkOXLuaQbYytpbdmlLvvbQVC;

		private readonly bool vaDaGjEXhutJaDNVEKbuxaApAkYB;

		private ThreadHelper LzOmxoEMyXdHGDFTmboJhhMxKvwE;

		private Queue<T> xdvVADKAWemwRtxTPKNbFgpcgfp;

		private Queue<T> AuwGeYIRmZJEQfrJSOfhiAYIfSUV;

		private bool dtKvbBomMBtVPJMfTXGUVEWnVdn;

		private bool vqjuhdYKKuBgDKqCJHOYrBTbbEX;

		private Action<T> NqsAQfAoCvcgOgRdOLZwYsEpYHo;

		private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

		public ThreadedMessageQueue(int maxQueueSize, int threadRefreshRateFPS, int threadAutoKillTimeoutMS, bool threadBlockOnStartAndStop, Action<T> messageReceiverDelegate)
		{
			if (messageReceiverDelegate == null)
			{
				throw new ArgumentNullException("messageReceiverDelegate");
			}
			if (maxQueueSize < 0)
			{
				maxQueueSize = 0;
			}
			if (threadRefreshRateFPS < 0)
			{
				threadRefreshRateFPS = 0;
			}
			if (threadAutoKillTimeoutMS < 0)
			{
				threadAutoKillTimeoutMS = 0;
			}
			ZmAswzqeDirHkhkAZcNhgPmsUVQl = maxQueueSize;
			kjjorxbSbjbYIIfRoSjrqIqIFNo = threadRefreshRateFPS;
			AsCQkOXLuaQbYytpbdmlLvvbQVC = threadAutoKillTimeoutMS;
			vaDaGjEXhutJaDNVEKbuxaApAkYB = threadBlockOnStartAndStop;
			NqsAQfAoCvcgOgRdOLZwYsEpYHo = messageReceiverDelegate;
			xdvVADKAWemwRtxTPKNbFgpcgfp = new Queue<T>(maxQueueSize);
			AuwGeYIRmZJEQfrJSOfhiAYIfSUV = new Queue<T>(maxQueueSize);
		}

		public void Enqueue(T message)
		{
			if (!dmyjjERgjQIVlakFlHoYvIKBXOi())
			{
				return;
			}
			lock (xdvVADKAWemwRtxTPKNbFgpcgfp)
			{
				if (ZmAswzqeDirHkhkAZcNhgPmsUVQl > 0)
				{
					while (xdvVADKAWemwRtxTPKNbFgpcgfp.Count >= ZmAswzqeDirHkhkAZcNhgPmsUVQl)
					{
						xdvVADKAWemwRtxTPKNbFgpcgfp.Dequeue();
					}
				}
				xdvVADKAWemwRtxTPKNbFgpcgfp.Enqueue(message);
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
					LzOmxoEMyXdHGDFTmboJhhMxKvwE.Start(vaDaGjEXhutJaDNVEKbuxaApAkYB);
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

		private void jBRKryZHNVFNkeWXPGLLPfeSXkS()
		{
			lock (xdvVADKAWemwRtxTPKNbFgpcgfp)
			{
				lock (AuwGeYIRmZJEQfrJSOfhiAYIfSUV)
				{
					MiscTools.Swap(ref xdvVADKAWemwRtxTPKNbFgpcgfp, ref AuwGeYIRmZJEQfrJSOfhiAYIfSUV);
				}
			}
		}

		private void bQqgsAbWRjGlMsAyaNueMnaBOfCE()
		{
			jBRKryZHNVFNkeWXPGLLPfeSXkS();
			lock (AuwGeYIRmZJEQfrJSOfhiAYIfSUV)
			{
				while (AuwGeYIRmZJEQfrJSOfhiAYIfSUV.Count > 0)
				{
					try
					{
						NqsAQfAoCvcgOgRdOLZwYsEpYHo(AuwGeYIRmZJEQfrJSOfhiAYIfSUV.Dequeue());
					}
					catch (Exception ex)
					{
						Logger.LogError("An exception occurred while sending message.\nMessage: " + ex.Message, requiredThreadSafety: true);
					}
				}
			}
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		~ThreadedMessageQueue()
		{
			Dispose(disposing: false);
		}

		protected void Dispose(bool disposing)
		{
			if (RFSEgUYkCipDyWyLEnlGiNDUlzz)
			{
				return;
			}
			if (disposing)
			{
				if (xdvVADKAWemwRtxTPKNbFgpcgfp != null)
				{
					if (AuwGeYIRmZJEQfrJSOfhiAYIfSUV != null)
					{
						lock (xdvVADKAWemwRtxTPKNbFgpcgfp)
						{
							lock (AuwGeYIRmZJEQfrJSOfhiAYIfSUV)
							{
								xdvVADKAWemwRtxTPKNbFgpcgfp.Clear();
								AuwGeYIRmZJEQfrJSOfhiAYIfSUV.Clear();
							}
						}
					}
					else
					{
						lock (xdvVADKAWemwRtxTPKNbFgpcgfp)
						{
							xdvVADKAWemwRtxTPKNbFgpcgfp.Clear();
						}
					}
				}
				else if (AuwGeYIRmZJEQfrJSOfhiAYIfSUV != null)
				{
					lock (AuwGeYIRmZJEQfrJSOfhiAYIfSUV)
					{
						AuwGeYIRmZJEQfrJSOfhiAYIfSUV.Clear();
					}
				}
				if (LzOmxoEMyXdHGDFTmboJhhMxKvwE != null)
				{
					LzOmxoEMyXdHGDFTmboJhhMxKvwE.Dispose();
				}
			}
			RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
		}
	}
}
