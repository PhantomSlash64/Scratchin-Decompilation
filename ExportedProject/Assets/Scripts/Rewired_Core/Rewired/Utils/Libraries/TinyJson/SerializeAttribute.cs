using System;

namespace Rewired.Utils.Libraries.TinyJson
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public class SerializeAttribute : Attribute
	{
		public string Name;
	}
}
