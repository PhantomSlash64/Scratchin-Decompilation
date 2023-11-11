using System;

namespace SonicBloom.Koreo
{
	internal class EventObj
	{
		private event KoreographyEventCallback basicEvent;

		private event KoreographyEventCallbackWithTime timedEvent;

		public void Register(KoreographyEventCallback callback)
		{
			this.basicEvent = (KoreographyEventCallback)Delegate.Combine(this.basicEvent, callback);
		}

		public void Register(KoreographyEventCallbackWithTime callback)
		{
			this.timedEvent = (KoreographyEventCallbackWithTime)Delegate.Combine(this.timedEvent, callback);
		}

		public void Unregister(KoreographyEventCallback callback)
		{
			this.basicEvent = (KoreographyEventCallback)Delegate.Remove(this.basicEvent, callback);
		}

		public void Unregister(KoreographyEventCallbackWithTime callback)
		{
			this.timedEvent = (KoreographyEventCallbackWithTime)Delegate.Remove(this.timedEvent, callback);
		}

		public void UnregisterByObject(object obj)
		{
			Delegate[] invocationList;
			if (this.basicEvent != null)
			{
				invocationList = this.basicEvent.GetInvocationList();
				for (int i = 0; i < invocationList.Length; i++)
				{
					if (invocationList[i].Target == obj)
					{
						this.basicEvent = (KoreographyEventCallback)Delegate.Remove(this.basicEvent, (KoreographyEventCallback)invocationList[i]);
						break;
					}
				}
			}
			if (this.timedEvent == null)
			{
				return;
			}
			invocationList = this.timedEvent.GetInvocationList();
			for (int j = 0; j < invocationList.Length; j++)
			{
				if (invocationList[j].Target == obj)
				{
					this.timedEvent = (KoreographyEventCallbackWithTime)Delegate.Remove(this.timedEvent, (KoreographyEventCallbackWithTime)invocationList[j]);
					break;
				}
			}
		}

		public void ClearRegistrations()
		{
			this.basicEvent = null;
			this.timedEvent = null;
		}

		public bool IsClear()
		{
			return this.basicEvent == null && this.timedEvent == null;
		}

		public void Trigger(KoreographyEvent evt, int sampleTime, int sampleDelta, DeltaSlice deltaSlice)
		{
			if (this.basicEvent != null)
			{
				this.basicEvent(evt);
			}
			if (this.timedEvent != null)
			{
				this.timedEvent(evt, sampleTime, sampleDelta, deltaSlice);
			}
		}
	}
}
