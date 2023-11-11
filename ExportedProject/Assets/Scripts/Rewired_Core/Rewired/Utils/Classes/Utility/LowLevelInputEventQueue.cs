using System;
using Rewired.Utils.Classes.Data;

namespace Rewired.Utils.Classes.Utility
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class LowLevelInputEventQueue : IDisposable
	{
		private LowLevelInputEvent sItuKiOWkqcqbDHRTwOuKGpQKPc;

		private readonly NativeRingBuffer liTAIBwFjuVhKgjwvrGMqhauoPI;

		private readonly int HUrvKXNmSdRrTKWEwIovQAsSEipJ;

		private readonly int jkUjRKTApmafglzOsRUiurZItVM;

		private readonly int kVzZTbScCFNqnGUvhyjODzBRGOE;

		private readonly int IfrYlVhtZxtMtNrkopEtfmLMkxN;

		private readonly int nfDdeELnrQwKNlRDjFNLWWngAhc;

		private uint xAntNVuNUqwLDeWRZKVhWKJUbjlA;

		private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

		public int Count => liTAIBwFjuVhKgjwvrGMqhauoPI.BytesInBuffer / IfrYlVhtZxtMtNrkopEtfmLMkxN;

		public int Capacity => nfDdeELnrQwKNlRDjFNLWWngAhc;

		public LowLevelInputEvent this[int index] => new LowLevelInputEvent(liTAIBwFjuVhKgjwvrGMqhauoPI.GetPointerFromReadPosition(index * IfrYlVhtZxtMtNrkopEtfmLMkxN), HUrvKXNmSdRrTKWEwIovQAsSEipJ, jkUjRKTApmafglzOsRUiurZItVM, kVzZTbScCFNqnGUvhyjODzBRGOE);

		public LowLevelInputEventQueue(int capacity, int buttonCount, int axisCount, int hatCount)
		{
			nfDdeELnrQwKNlRDjFNLWWngAhc = capacity;
			HUrvKXNmSdRrTKWEwIovQAsSEipJ = buttonCount;
			jkUjRKTApmafglzOsRUiurZItVM = axisCount;
			kVzZTbScCFNqnGUvhyjODzBRGOE = hatCount;
			IfrYlVhtZxtMtNrkopEtfmLMkxN = LowLevelInputEvent.GetReportSize(buttonCount, axisCount, hatCount);
			liTAIBwFjuVhKgjwvrGMqhauoPI = new NativeRingBuffer(nfDdeELnrQwKNlRDjFNLWWngAhc * IfrYlVhtZxtMtNrkopEtfmLMkxN);
			sItuKiOWkqcqbDHRTwOuKGpQKPc = new LowLevelInputEvent(IntPtr.Zero, HUrvKXNmSdRrTKWEwIovQAsSEipJ, jkUjRKTApmafglzOsRUiurZItVM, hatCount);
		}

		public LowLevelInputEvent CreateEvent()
		{
			uint passId;
			IntPtr buffer = liTAIBwFjuVhKgjwvrGMqhauoPI.Allocate(IfrYlVhtZxtMtNrkopEtfmLMkxN, zeroFill: false, out passId);
			LowLevelInputEvent result = new LowLevelInputEvent(buffer, HUrvKXNmSdRrTKWEwIovQAsSEipJ, jkUjRKTApmafglzOsRUiurZItVM, kVzZTbScCFNqnGUvhyjODzBRGOE);
			result.SetId(xAntNVuNUqwLDeWRZKVhWKJUbjlA = MiscTools.Tick(xAntNVuNUqwLDeWRZKVhWKJUbjlA));
			return result;
		}

		public int FindNextIndex(uint id)
		{
			int num = liTAIBwFjuVhKgjwvrGMqhauoPI.BytesInBuffer / IfrYlVhtZxtMtNrkopEtfmLMkxN;
			if (num == 0)
			{
				return -1;
			}
			sItuKiOWkqcqbDHRTwOuKGpQKPc._buffer = liTAIBwFjuVhKgjwvrGMqhauoPI.GetPointerFromReadPosition(0);
			uint num2 = sItuKiOWkqcqbDHRTwOuKGpQKPc.GetId();
			int num3 = 0;
			if (MiscTools.IsTickNewer(id, num2))
			{
				num3 = (int)MiscTools.TickDifference(id, num2) + 1;
				num2 = MiscTools.Tick(id);
			}
			for (int i = num3; i < num; i++)
			{
				if (!MiscTools.IsTickNewer(num2, id))
				{
					num2 = MiscTools.Tick(num2);
					continue;
				}
				return i;
			}
			return -1;
		}

		public bool TryGetNext(int index, out LowLevelInputEvent @event)
		{
			if (index < 0 || index >= liTAIBwFjuVhKgjwvrGMqhauoPI.BytesInBuffer / IfrYlVhtZxtMtNrkopEtfmLMkxN)
			{
				@event = default(LowLevelInputEvent);
				return false;
			}
			@event = new LowLevelInputEvent(liTAIBwFjuVhKgjwvrGMqhauoPI.GetPointerFromReadPosition(index * IfrYlVhtZxtMtNrkopEtfmLMkxN), HUrvKXNmSdRrTKWEwIovQAsSEipJ, jkUjRKTApmafglzOsRUiurZItVM, kVzZTbScCFNqnGUvhyjODzBRGOE);
			return true;
		}

		public void Clear()
		{
			liTAIBwFjuVhKgjwvrGMqhauoPI.Reset();
		}

		public void CopyAllFrom(LowLevelInputEventQueue other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			liTAIBwFjuVhKgjwvrGMqhauoPI.CopyFrom(other.liTAIBwFjuVhKgjwvrGMqhauoPI);
			xAntNVuNUqwLDeWRZKVhWKJUbjlA = other.xAntNVuNUqwLDeWRZKVhWKJUbjlA;
		}

		public void CopyNewEventsFrom(LowLevelInputEventQueue other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			int count = Count;
			int count2 = other.Count;
			if (count2 == 0)
			{
				return;
			}
			if (count == 0)
			{
				CopyAllFrom(other);
				return;
			}
			uint id = new LowLevelInputEvent(liTAIBwFjuVhKgjwvrGMqhauoPI.GetPointerFromReadPosition((count - 1) * IfrYlVhtZxtMtNrkopEtfmLMkxN), HUrvKXNmSdRrTKWEwIovQAsSEipJ, jkUjRKTApmafglzOsRUiurZItVM, kVzZTbScCFNqnGUvhyjODzBRGOE).GetId();
			int num = other.FindNextIndex(id);
			if (num < 0)
			{
				return;
			}
			int num2 = count2 - num;
			if (num2 != 0)
			{
				for (int i = 0; i < num2; i++)
				{
					uint passId;
					IntPtr buffer = liTAIBwFjuVhKgjwvrGMqhauoPI.Allocate(IfrYlVhtZxtMtNrkopEtfmLMkxN, zeroFill: false, out passId);
					other.liTAIBwFjuVhKgjwvrGMqhauoPI.RandomRead(buffer, IfrYlVhtZxtMtNrkopEtfmLMkxN, IfrYlVhtZxtMtNrkopEtfmLMkxN, other.liTAIBwFjuVhKgjwvrGMqhauoPI.GetOffsetFromReadPosition((num + i) * IfrYlVhtZxtMtNrkopEtfmLMkxN));
				}
				xAntNVuNUqwLDeWRZKVhWKJUbjlA = other.xAntNVuNUqwLDeWRZKVhWKJUbjlA;
			}
		}

		public void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		~LowLevelInputEventQueue()
		{
			Dispose(disposing: false);
		}

		protected void Dispose(bool disposing)
		{
			if (!RFSEgUYkCipDyWyLEnlGiNDUlzz)
			{
				if (disposing)
				{
					liTAIBwFjuVhKgjwvrGMqhauoPI.Dispose();
				}
				RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
			}
		}
	}
}
