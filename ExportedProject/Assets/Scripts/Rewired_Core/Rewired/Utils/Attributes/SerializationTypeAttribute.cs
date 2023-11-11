using System;

namespace Rewired.Utils.Attributes
{
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	[AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	public class SerializationTypeAttribute : Attribute
	{
		public enum SerializationType
		{
			Default = 0,
			Object = 1
		}

		private SerializationType _serializationType;

		public SerializationType serializationType => _serializationType;

		public SerializationTypeAttribute(SerializationType serializationType)
		{
			_serializationType = serializationType;
		}
	}
}
