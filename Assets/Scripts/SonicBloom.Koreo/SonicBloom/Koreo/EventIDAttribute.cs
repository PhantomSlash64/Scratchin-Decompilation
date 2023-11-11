using System;
using UnityEngine;

namespace SonicBloom.Koreo
{
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public class EventIDAttribute : PropertyAttribute
	{
	}
}
