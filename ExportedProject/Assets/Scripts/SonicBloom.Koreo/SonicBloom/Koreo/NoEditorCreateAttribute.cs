using System;

namespace SonicBloom.Koreo
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = true, AllowMultiple = false)]
	public class NoEditorCreateAttribute : Attribute
	{
	}
}
