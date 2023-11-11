using System;
using System.Collections.Generic;
using UnityEngine;

namespace SonicBloom.Koreo
{
	[Serializable]
	public class KoreographyTrack : KoreographyTrackBase
	{
		[SerializeField]
		[HideInInspector]
		protected List<AssetPayload> _AssetPayloads;

		[SerializeField]
		[HideInInspector]
		protected List<int> _AssetPayloadIdxs;

		[SerializeField]
		[HideInInspector]
		protected List<ColorPayload> _ColorPayloads;

		[HideInInspector]
		[SerializeField]
		protected List<int> _ColorPayloadIdxs;

		[SerializeField]
		[HideInInspector]
		protected List<CurvePayload> _CurvePayloads;

		[HideInInspector]
		[SerializeField]
		protected List<int> _CurvePayloadIdxs;

		[HideInInspector]
		[SerializeField]
		protected List<FloatPayload> _FloatPayloads;

		[SerializeField]
		[HideInInspector]
		protected List<int> _FloatPayloadIdxs;

		[HideInInspector]
		[SerializeField]
		protected List<GradientPayload> _GradientPayloads;

		[SerializeField]
		[HideInInspector]
		protected List<int> _GradientPayloadIdxs;

		[HideInInspector]
		[SerializeField]
		protected List<IntPayload> _IntPayloads;

		[HideInInspector]
		[SerializeField]
		protected List<int> _IntPayloadIdxs;

		[HideInInspector]
		[SerializeField]
		protected List<SpectrumPayload> _SpectrumPayloads;

		[HideInInspector]
		[SerializeField]
		protected List<int> _SpectrumPayloadIdxs;

		[SerializeField]
		[HideInInspector]
		protected List<TextPayload> _TextPayloads;

		[SerializeField]
		[HideInInspector]
		protected List<int> _TextPayloadIdxs;
	}
}
