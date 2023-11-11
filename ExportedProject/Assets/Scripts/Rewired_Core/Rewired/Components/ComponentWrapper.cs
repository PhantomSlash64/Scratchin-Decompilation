using System;
using UnityEngine;

namespace Rewired.Components
{
	[Serializable]
	[AddComponentMenu("")]
	public abstract class ComponentWrapper<T> : MonoBehaviour where T : class
	{
		[NonSerialized]
		private T ptgshdhzmBqmpwQkacMBSGAyXPI;

		[NonSerialized]
		private bool vqjuhdYKKuBgDKqCJHOYrBTbbEX;

		protected T source => ptgshdhzmBqmpwQkacMBSGAyXPI;

		protected bool initialized => vqjuhdYKKuBgDKqCJHOYrBTbbEX;

		[CustomObfuscation(rename = false)]
		private void Awake()
		{
			OnAwake();
			OnAwakeFinished();
		}

		[CustomObfuscation(rename = false)]
		private void Start()
		{
			OnStart();
		}

		[CustomObfuscation(rename = false)]
		private void OnEnable()
		{
			OnEnabled();
		}

		[CustomObfuscation(rename = false)]
		private void OnDisable()
		{
			OnDisabled();
		}

		[CustomObfuscation(rename = false)]
		private void OnDestroy()
		{
			OnDestroyed();
		}

		[CustomObfuscation(rename = false)]
		private void Reset()
		{
			OnReset();
		}

		[CustomObfuscation(rename = false)]
		private void OnValidate()
		{
			OnValidated();
		}

		protected virtual void OnAwake()
		{
			ReInput.InitializedEvent += xChikSLnENcVhEoIFMkxyTJFkBIe;
			Initialize();
		}

		protected virtual void OnAwakeFinished()
		{
		}

		protected virtual void OnStart()
		{
		}

		protected virtual void OnEnabled()
		{
		}

		protected virtual void OnDisabled()
		{
		}

		protected virtual void OnDestroyed()
		{
			Unsubscribe();
			ReInput.InitializedEvent -= xChikSLnENcVhEoIFMkxyTJFkBIe;
		}

		protected virtual void OnReset()
		{
		}

		protected virtual void OnValidated()
		{
		}

		protected virtual void Initialize()
		{
			if (TryInitialize())
			{
				vqjuhdYKKuBgDKqCJHOYrBTbbEX = true;
				PostInitialize();
			}
		}

		protected virtual bool TryInitialize()
		{
			if (vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				return false;
			}
			ptgshdhzmBqmpwQkacMBSGAyXPI = CreateSource(GetCreateSourceArgs());
			if (ptgshdhzmBqmpwQkacMBSGAyXPI == null)
			{
				Logger.LogError("Failed to create source object.");
				return false;
			}
			vqjuhdYKKuBgDKqCJHOYrBTbbEX = true;
			return true;
		}

		protected abstract T CreateSource(object args);

		protected abstract object GetCreateSourceArgs();

		protected virtual void PostInitialize()
		{
			Subscribe();
		}

		protected virtual void Deinitialize()
		{
			vqjuhdYKKuBgDKqCJHOYrBTbbEX = false;
			Unsubscribe();
			ptgshdhzmBqmpwQkacMBSGAyXPI = null;
		}

		protected virtual void Subscribe()
		{
			Unsubscribe();
			ReInput.ShutDownEvent += lXRRydHJhlWGLFvnaJJCBMpYEXz;
		}

		protected virtual void Unsubscribe()
		{
			ReInput.ShutDownEvent -= lXRRydHJhlWGLFvnaJJCBMpYEXz;
		}

		private void lXRRydHJhlWGLFvnaJJCBMpYEXz()
		{
			Deinitialize();
		}

		private void xChikSLnENcVhEoIFMkxyTJFkBIe()
		{
			Initialize();
		}
	}
}
