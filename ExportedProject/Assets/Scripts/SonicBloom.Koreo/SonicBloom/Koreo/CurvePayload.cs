using System;
using UnityEngine;

namespace SonicBloom.Koreo
{
	[Serializable]
	public class CurvePayload : IPayload
	{
		[SerializeField]
		[Tooltip("The curve value that makes up the payload.")]
		private AnimationCurve mCurveData;

		public AnimationCurve CurveData
		{
			get
			{
				return mCurveData;
			}
			set
			{
				mCurveData = value;
			}
		}

		public CurvePayload()
		{
			mCurveData = GetNewCurve();
		}

		public static string GetFriendlyName()
		{
			return "Curve";
		}

		private AnimationCurve GetNewCurve()
		{
			AnimationCurve animationCurve = new AnimationCurve();
			animationCurve.AddKey(0f, 0f);
			animationCurve.AddKey(1f, 1f);
			return animationCurve;
		}

		public float GetValueAtDelta(float delta)
		{
			float time = mCurveData[0].time;
			float time2 = mCurveData[mCurveData.length - 1].time;
			return mCurveData.Evaluate(Mathf.Lerp(time, time2, delta));
		}

		public IPayload GetCopy()
		{
			CurvePayload curvePayload = new CurvePayload();
			curvePayload.CurveData = new AnimationCurve(CurveData.keys);
			return curvePayload;
		}
	}
}
