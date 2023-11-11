using System;

namespace Rewired.Dev
{
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public class ActionIdFieldInfoAttribute : Attribute
	{
		public string categoryName;

		public string friendlyName;
	}
}
