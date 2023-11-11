using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public struct GlobalDynamicResolutionSettings
	{
		public bool enabled;

		public float maxPercentage;

		public float minPercentage;

		public DynamicResolutionType dynResType;

		public DynamicResUpscaleFilter upsampleFilter;

		public bool forceResolution;

		public float forcedPercentage;

		public static GlobalDynamicResolutionSettings NewDefault()
		{
			GlobalDynamicResolutionSettings result = default(GlobalDynamicResolutionSettings);
			result.maxPercentage = 100f;
			result.minPercentage = 100f;
			result.dynResType = DynamicResolutionType.Hardware;
			result.upsampleFilter = DynamicResUpscaleFilter.CatmullRom;
			result.forcedPercentage = 100f;
			return result;
		}
	}
}
