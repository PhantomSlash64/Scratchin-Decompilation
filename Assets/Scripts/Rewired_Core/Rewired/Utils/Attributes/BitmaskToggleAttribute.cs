using System;
using UnityEngine;

namespace Rewired.Utils.Attributes
{
	public class BitmaskToggleAttribute : PropertyAttribute
	{
		public Type propType;

		public bool showNone = true;

		public bool showAll = true;

		public BitmaskToggleAttribute(Type aType)
		{
			propType = aType;
		}
	}
}
