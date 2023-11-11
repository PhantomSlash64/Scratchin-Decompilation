using System;

namespace Rewired.Dev
{
	[AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public class PlayerIdFieldInfoAttribute : Attribute
	{
		public string friendlyName;
	}
}
