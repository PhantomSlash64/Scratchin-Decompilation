using System;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	public abstract class HardwareControllerTemplateMap : ScriptableObject
	{
		public abstract Guid Guid { get; }
	}
}
