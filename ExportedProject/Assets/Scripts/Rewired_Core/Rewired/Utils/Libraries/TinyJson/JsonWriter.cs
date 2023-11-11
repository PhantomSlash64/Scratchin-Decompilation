using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Utils.Libraries.TinyJson
{
	public static class JsonWriter
	{
		private static Action<StringBuilder, object> aPeDuOYLhbfvBJlHAWbUbQIxvZl;

		private static Action<StringBuilder, object> appendValueDelegate => DofkUqTjgirRnVYesiFQSqpvxaq;

		public static string ToJson(object item)
		{
			StringBuilder stringBuilder = new StringBuilder();
			DofkUqTjgirRnVYesiFQSqpvxaq(stringBuilder, item);
			return stringBuilder.ToString();
		}

		private static void DofkUqTjgirRnVYesiFQSqpvxaq(StringBuilder P_0, object P_1)
		{
			if (P_1 == null)
			{
				P_0.Append("null");
				return;
			}
			if (P_1 is ISerializationCallbackReceiver serializationCallbackReceiver)
			{
				try
				{
					serializationCallbackReceiver.OnBeforeSerialize();
				}
				catch (Exception ex)
				{
					Logger.LogError(ex.ToString(), requiredThreadSafety: true);
				}
			}
			Type type = P_1.GetType();
			if (ReflectionTools.DoesTypeImplement(type, typeof(IExportToJson)))
			{
				((IExportToJson)P_1).WriteJson(P_0, appendValueDelegate);
				return;
			}
			if (object.ReferenceEquals(type, typeof(string)))
			{
				P_0.Append('"');
				P_0.Append((string)P_1);
				P_0.Append('"');
				return;
			}
			if (object.ReferenceEquals(type, typeof(int)) || object.ReferenceEquals(type, typeof(uint)) || object.ReferenceEquals(type, typeof(long)) || object.ReferenceEquals(type, typeof(ulong)) || object.ReferenceEquals(type, typeof(short)) || object.ReferenceEquals(type, typeof(ushort)) || object.ReferenceEquals(type, typeof(byte)) || object.ReferenceEquals(type, typeof(sbyte)))
			{
				P_0.Append(P_1.ToString());
				return;
			}
			if (object.ReferenceEquals(type, typeof(float)))
			{
				P_0.Append(((float)P_1).ToString(CultureInfo.InvariantCulture));
				return;
			}
			if (object.ReferenceEquals(type, typeof(double)))
			{
				P_0.Append(((double)P_1).ToString(CultureInfo.InvariantCulture));
				return;
			}
			if (object.ReferenceEquals(type, typeof(decimal)))
			{
				P_0.Append(((decimal)P_1).ToString(CultureInfo.InvariantCulture));
				return;
			}
			if (object.ReferenceEquals(type, typeof(bool)))
			{
				P_0.Append(((bool)P_1) ? "true" : "false");
				return;
			}
			if (object.ReferenceEquals(type, typeof(Guid)))
			{
				DofkUqTjgirRnVYesiFQSqpvxaq(P_0, P_1.ToString());
				return;
			}
			if (ReflectionTools.IsEnum(type))
			{
				Type underlyingType = Enum.GetUnderlyingType(type);
				DofkUqTjgirRnVYesiFQSqpvxaq(P_0, Convert.ChangeType(P_1, underlyingType));
				return;
			}
			if (ReflectionTools.DoesTypeImplement(type, typeof(IList)))
			{
				P_0.Append('[');
				bool flag = true;
				IList list = P_1 as IList;
				for (int i = 0; i < list.Count; i++)
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						P_0.Append(',');
					}
					DofkUqTjgirRnVYesiFQSqpvxaq(P_0, list[i]);
				}
				P_0.Append(']');
				return;
			}
			if (ReflectionTools.IsGenericType(type) && ReflectionTools.DoesTypeImplement(type, typeof(IDictionary)))
			{
				Type type2 = ReflectionTools.GetGenericArguments(type)[0];
				bool flag2 = false;
				Type conversionType = null;
				if (ReflectionTools.IsEnum(type2))
				{
					flag2 = true;
					conversionType = ReflectionTools.GetUnderlyingEnumType(type2);
				}
				P_0.Append('{');
				IDictionary dictionary = P_1 as IDictionary;
				bool flag3 = true;
				foreach (object key in dictionary.Keys)
				{
					if (flag3)
					{
						flag3 = false;
					}
					else
					{
						P_0.Append(',');
					}
					P_0.Append('"');
					P_0.Append(flag2 ? Convert.ChangeType(key, conversionType).ToString() : key.ToString());
					P_0.Append("\":");
					DofkUqTjgirRnVYesiFQSqpvxaq(P_0, dictionary[key]);
				}
				P_0.Append('}');
				return;
			}
			P_0.Append('{');
			bool flag4 = true;
			IEnumerable<FieldInfo> fields = ReflectionTools.GetFields(type, ReflectionTools.BindingFlags.Instance | ReflectionTools.BindingFlags.Public | ReflectionTools.BindingFlags.NonPublic);
			foreach (FieldInfo item in fields)
			{
				if (item.IsDefined(typeof(NonSerializedAttribute), inherit: true) || item.IsDefined(typeof(DoNotSerializeAttribute), inherit: true) || (!item.IsPublic && !item.IsDefined(typeof(SerializeAttribute), inherit: true) && !item.IsDefined(typeof(SerializeField), inherit: true)))
				{
					continue;
				}
				object value = item.GetValue(P_1);
				if (value != null)
				{
					if (flag4)
					{
						flag4 = false;
					}
					else
					{
						P_0.Append(',');
					}
					P_0.Append('"');
					string name;
					if (!item.IsDefined(typeof(SerializeAttribute), inherit: true) || string.IsNullOrEmpty(name = (CollectionTools.GetValue(item.GetCustomAttributes(typeof(SerializeAttribute), inherit: true), 0) as SerializeAttribute).Name))
					{
						name = item.Name;
					}
					P_0.Append(name);
					P_0.Append("\":");
					DofkUqTjgirRnVYesiFQSqpvxaq(P_0, value);
				}
			}
			IEnumerable<PropertyInfo> properties = ReflectionTools.GetProperties(type, ReflectionTools.BindingFlags.Instance | ReflectionTools.BindingFlags.Public | ReflectionTools.BindingFlags.NonPublic);
			foreach (PropertyInfo item2 in properties)
			{
				if (!item2.CanWrite || !item2.IsDefined(typeof(SerializeAttribute), inherit: true) || item2.IsDefined(typeof(DoNotSerializeAttribute), inherit: true) || !item2.CanRead)
				{
					continue;
				}
				object value2 = item2.GetValue(P_1, null);
				if (value2 != null)
				{
					if (flag4)
					{
						flag4 = false;
					}
					else
					{
						P_0.Append(',');
					}
					P_0.Append('"');
					string name2;
					if (!item2.IsDefined(typeof(SerializeAttribute), inherit: true) || string.IsNullOrEmpty(name2 = (CollectionTools.GetValue(item2.GetCustomAttributes(typeof(SerializeAttribute), inherit: true), 0) as SerializeAttribute).Name))
					{
						name2 = item2.Name;
					}
					P_0.Append(name2);
					P_0.Append("\":");
					DofkUqTjgirRnVYesiFQSqpvxaq(P_0, value2);
				}
			}
			P_0.Append('}');
		}
	}
}
