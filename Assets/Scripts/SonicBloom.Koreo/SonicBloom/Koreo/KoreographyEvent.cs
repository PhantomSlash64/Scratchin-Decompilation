using System;
using UnityEngine;

namespace SonicBloom.Koreo
{
	[Serializable]
	public class KoreographyEvent
	{
		[Tooltip("The sample position at which this event starts.")]
		[SerializeField]
		private int mStartSample;

		[Tooltip("The sample position at which this event ends.")]
		[SerializeField]
		private int mEndSample;

		private IPayload mPayload;

		public int StartSample
		{
			get
			{
				return mStartSample;
			}
			set
			{
				mStartSample = Mathf.Max(0, value);
				if (mStartSample > mEndSample)
				{
					mEndSample = mStartSample;
				}
			}
		}

		public int EndSample
		{
			get
			{
				return mEndSample;
			}
			set
			{
				mEndSample = Mathf.Max(0, value);
				if (mEndSample < mStartSample)
				{
					mStartSample = mEndSample;
				}
			}
		}

		public IPayload Payload
		{
			get
			{
				return mPayload;
			}
			set
			{
				mPayload = value;
			}
		}

		public static int CompareByStartSample(KoreographyEvent first, KoreographyEvent second)
		{
			if (first.StartSample < second.StartSample)
			{
				return -1;
			}
			if (first.StartSample == second.StartSample)
			{
				return 0;
			}
			return 1;
		}

		public bool IsOneOff()
		{
			return StartSample == EndSample;
		}

		public float GetEventDeltaAtSampleTime(int sampleTime)
		{
			float num = -1f;
			if (sampleTime < StartSample)
			{
				return 0f;
			}
			if (sampleTime > EndSample || IsOneOff())
			{
				return 1f;
			}
			return (float)((double)(sampleTime - StartSample) / (double)(EndSample - StartSample));
		}
	}
}
