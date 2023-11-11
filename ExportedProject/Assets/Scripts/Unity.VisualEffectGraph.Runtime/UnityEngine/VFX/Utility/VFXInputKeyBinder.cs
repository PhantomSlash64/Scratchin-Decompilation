using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[AddComponentMenu("VFX/Property Binders/Input Key Press Binder")]
	[VFXBinder("Input/Key")]
	internal class VFXInputKeyBinder : VFXBinderBase
	{
		[VFXPropertyBinding(new string[] { "System.Boolean" })]
		[SerializeField]
		[FormerlySerializedAs("m_KeyParameter")]
		protected ExposedProperty m_KeyProperty = "KeyDown";

		[VFXPropertyBinding(new string[] { "System.Single" })]
		[SerializeField]
		[FormerlySerializedAs("m_KeySmoothParameter")]
		protected ExposedProperty m_KeySmoothProperty = "KeySmooth";

		public KeyCode Key = KeyCode.Space;

		public float SmoothSpeed = 2f;

		public bool UseKeySmooth = true;

		private float m_CachedSmoothValue;

		public string KeyProperty
		{
			get
			{
				return (string)m_KeyProperty;
			}
			set
			{
				m_KeyProperty = value;
			}
		}

		public string KeySmoothProperty
		{
			get
			{
				return (string)m_KeySmoothProperty;
			}
			set
			{
				m_KeySmoothProperty = value;
			}
		}

		public override bool IsValid(VisualEffect component)
		{
			if (component.HasBool(m_KeyProperty))
			{
				if (!UseKeySmooth)
				{
					return true;
				}
				return component.HasFloat(m_KeySmoothProperty);
			}
			return false;
		}

		private void Start()
		{
			if (UseKeySmooth)
			{
				m_CachedSmoothValue = (Input.GetKeyDown(Key) ? 1f : 0f);
			}
		}

		public override void UpdateBinding(VisualEffect component)
		{
			bool key = Input.GetKey(Key);
			component.SetBool(m_KeyProperty, key);
			if (UseKeySmooth)
			{
				m_CachedSmoothValue += SmoothSpeed * Time.deltaTime * (key ? 1f : (-1f));
				m_CachedSmoothValue = Mathf.Clamp01(m_CachedSmoothValue);
				component.SetFloat(m_KeySmoothProperty, m_CachedSmoothValue);
			}
		}

		public override string ToString()
		{
			return $"Key: '{m_KeySmoothProperty}' -> {Key.ToString()}";
		}
	}
}
