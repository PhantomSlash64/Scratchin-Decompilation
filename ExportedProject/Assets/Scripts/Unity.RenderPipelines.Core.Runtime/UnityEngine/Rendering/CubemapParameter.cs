using System;
using System.Diagnostics;

namespace UnityEngine.Rendering
{
	[Serializable]
	[DebuggerDisplay("{m_Value} ({m_OverrideState})")]
	public class CubemapParameter : VolumeParameter<Texture>
	{
		public CubemapParameter(Texture value, bool overrideState = false)
			: base(value, overrideState)
		{
		}
	}
}
