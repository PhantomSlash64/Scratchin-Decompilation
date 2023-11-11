using System;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	public sealed class VolumeStack : IDisposable
	{
		internal Dictionary<Type, VolumeComponent> components;

		internal VolumeStack()
		{
		}

		internal void Reload(Type[] baseTypes)
		{
			if (components == null)
			{
				components = new Dictionary<Type, VolumeComponent>();
			}
			else
			{
				components.Clear();
			}
			foreach (Type type in baseTypes)
			{
				VolumeComponent value = (VolumeComponent)ScriptableObject.CreateInstance(type);
				components.Add(type, value);
			}
		}

		public T GetComponent<T>() where T : VolumeComponent
		{
			return (T)GetComponent(typeof(T));
		}

		public VolumeComponent GetComponent(Type type)
		{
			components.TryGetValue(type, out var value);
			return value;
		}

		public void Dispose()
		{
			foreach (KeyValuePair<Type, VolumeComponent> component in components)
			{
				CoreUtils.Destroy(component.Value);
			}
			components.Clear();
		}
	}
}
