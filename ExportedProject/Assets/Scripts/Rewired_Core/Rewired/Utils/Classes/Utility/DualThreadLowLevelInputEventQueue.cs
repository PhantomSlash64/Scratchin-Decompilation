using System;

namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class DualThreadLowLevelInputEventQueue : IDisposable
	{
		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		[CustomObfuscation(rename = false)]
		public interface INewEventWrapper : IDisposable
		{
			LowLevelInputEvent Event { get; set; }
		}

		private class poOxOWWHKGYSvkPPdSTRgFwJGIY : LockedObject<LowLevelInputEvent>, IDisposable, INewEventWrapper
		{
			public LowLevelInputEvent Event
			{
				get
				{
					return item;
				}
				set
				{
					item = value;
				}
			}

			public poOxOWWHKGYSvkPPdSTRgFwJGIY(object lockObject)
				: base(lockObject)
			{
			}
		}

		private readonly LowLevelInputEventQueue tbtNoAnJJXoqGvMhQEkQAjOxHYlH;

		private readonly LowLevelInputEventQueue AuwGeYIRmZJEQfrJSOfhiAYIfSUV;

		private readonly object iavWrTleASACJAUwzTFxpVtvDBVI;

		private uint ZljazCoYzNgVgPnaoRaOfNuebMrh;

		private bool xGtjRgpAJvjrGRSAHfnvuisjyrC;

		private int THuKiZchnKJPiuOUtzJgqLYHEAxI;

		private int STmQpkJkhmndfDeHNTBQCeUOYtz;

		private poOxOWWHKGYSvkPPdSTRgFwJGIY VCJAeNAqeztmJaToaHfRhVYPWPT;

		public LowLevelInputEvent currentEvent;

		private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

		public uint lastProcessedEventId => ZljazCoYzNgVgPnaoRaOfNuebMrh;

		public int count
		{
			get
			{
				lock (iavWrTleASACJAUwzTFxpVtvDBVI)
				{
					return tbtNoAnJJXoqGvMhQEkQAjOxHYlH.Count;
				}
			}
		}

		public DualThreadLowLevelInputEventQueue(int capacity, int buttonCount, int axisCount, int hatCount)
		{
			tbtNoAnJJXoqGvMhQEkQAjOxHYlH = new LowLevelInputEventQueue(capacity, buttonCount, axisCount, hatCount);
			AuwGeYIRmZJEQfrJSOfhiAYIfSUV = new LowLevelInputEventQueue(capacity, buttonCount, axisCount, hatCount);
			iavWrTleASACJAUwzTFxpVtvDBVI = new object();
			VCJAeNAqeztmJaToaHfRhVYPWPT = new poOxOWWHKGYSvkPPdSTRgFwJGIY(iavWrTleASACJAUwzTFxpVtvDBVI);
		}

		public INewEventWrapper T_CreateEvent()
		{
			VCJAeNAqeztmJaToaHfRhVYPWPT.Lock();
			VCJAeNAqeztmJaToaHfRhVYPWPT.item = AuwGeYIRmZJEQfrJSOfhiAYIfSUV.CreateEvent();
			return VCJAeNAqeztmJaToaHfRhVYPWPT;
		}

		public void Update()
		{
			lock (iavWrTleASACJAUwzTFxpVtvDBVI)
			{
				tbtNoAnJJXoqGvMhQEkQAjOxHYlH.CopyNewEventsFrom(AuwGeYIRmZJEQfrJSOfhiAYIfSUV);
			}
		}

		public void Clear()
		{
			lock (iavWrTleASACJAUwzTFxpVtvDBVI)
			{
				StopProcessingEvents();
				tbtNoAnJJXoqGvMhQEkQAjOxHYlH.Clear();
				AuwGeYIRmZJEQfrJSOfhiAYIfSUV.Clear();
			}
		}

		public bool ProcessNewEvents()
		{
			if (STmQpkJkhmndfDeHNTBQCeUOYtz == 0)
			{
				Update();
				int num = tbtNoAnJJXoqGvMhQEkQAjOxHYlH.FindNextIndex(ZljazCoYzNgVgPnaoRaOfNuebMrh);
				if (num < 0)
				{
					currentEvent = default(LowLevelInputEvent);
					return false;
				}
				STmQpkJkhmndfDeHNTBQCeUOYtz = num;
				xGtjRgpAJvjrGRSAHfnvuisjyrC = true;
				THuKiZchnKJPiuOUtzJgqLYHEAxI = tbtNoAnJJXoqGvMhQEkQAjOxHYlH.Count;
			}
			if (STmQpkJkhmndfDeHNTBQCeUOYtz >= THuKiZchnKJPiuOUtzJgqLYHEAxI)
			{
				currentEvent = default(LowLevelInputEvent);
				xGtjRgpAJvjrGRSAHfnvuisjyrC = false;
				STmQpkJkhmndfDeHNTBQCeUOYtz = 0;
				return false;
			}
			if (tbtNoAnJJXoqGvMhQEkQAjOxHYlH.TryGetNext(STmQpkJkhmndfDeHNTBQCeUOYtz, out currentEvent))
			{
				ZljazCoYzNgVgPnaoRaOfNuebMrh = currentEvent.GetId();
				STmQpkJkhmndfDeHNTBQCeUOYtz++;
				return true;
			}
			currentEvent = default(LowLevelInputEvent);
			xGtjRgpAJvjrGRSAHfnvuisjyrC = false;
			STmQpkJkhmndfDeHNTBQCeUOYtz = 0;
			return false;
		}

		public void StopProcessingEvents()
		{
			xGtjRgpAJvjrGRSAHfnvuisjyrC = false;
			STmQpkJkhmndfDeHNTBQCeUOYtz = 0;
		}

		public void ImportAll(DualThreadLowLevelInputEventQueue other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			if (other == this)
			{
				return;
			}
			lock (iavWrTleASACJAUwzTFxpVtvDBVI)
			{
				lock (other.iavWrTleASACJAUwzTFxpVtvDBVI)
				{
					tbtNoAnJJXoqGvMhQEkQAjOxHYlH.CopyAllFrom(other.tbtNoAnJJXoqGvMhQEkQAjOxHYlH);
					AuwGeYIRmZJEQfrJSOfhiAYIfSUV.CopyAllFrom(other.AuwGeYIRmZJEQfrJSOfhiAYIfSUV);
					ZljazCoYzNgVgPnaoRaOfNuebMrh = other.ZljazCoYzNgVgPnaoRaOfNuebMrh;
					xGtjRgpAJvjrGRSAHfnvuisjyrC = other.xGtjRgpAJvjrGRSAHfnvuisjyrC;
					THuKiZchnKJPiuOUtzJgqLYHEAxI = other.THuKiZchnKJPiuOUtzJgqLYHEAxI;
					STmQpkJkhmndfDeHNTBQCeUOYtz = other.STmQpkJkhmndfDeHNTBQCeUOYtz;
				}
			}
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		~DualThreadLowLevelInputEventQueue()
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
				lock (iavWrTleASACJAUwzTFxpVtvDBVI)
				{
					tbtNoAnJJXoqGvMhQEkQAjOxHYlH.Dispose();
					AuwGeYIRmZJEQfrJSOfhiAYIfSUV.Dispose();
				}
			}
			RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
		}
	}
}
