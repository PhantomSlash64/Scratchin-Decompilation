using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[AddComponentMenu("VFX/Property Binders/Input Button Binder")]
	[VFXBinder("Input/Button")]
	internal class VFXInputButtonBinder : VFXBinderBase
	{
		[VFXPropertyBinding(new string[] { "System.Boolean" })]
		[SerializeField]
		[FormerlySerializedAs("m_ButtonParameter")]
		protected ExposedProperty m_ButtonProperty = "ButtonDown";

		[VFXPropertyBinding(new string[] { "System.Single" })]
		[SerializeField]
		[FormerlySerializedAs("m_ButtonSmoothParameter")]
		protected ExposedProperty m_ButtonSmoothProperty = "KeySmooth";

		public string ButtonName = "Action";

		public float SmoothSpeed = 2f;

		public bool UseButtonSmooth = true;

		private float m_CachedSmoothValue;

		public string ButtonProperty
		{
			get
			{
				return (string)m_ButtonProperty;
			}
			set
			{
				m_ButtonProperty = value;
			}
		}

		public string ButtonSmoothProperty
		{
			get
			{
				return (string)m_ButtonSmoothProperty;
			}
			set
			{
				m_ButtonSmoothProperty = value;
			}
		}

		public override bool IsValid(VisualEffect component)
		{
			if (component.HasBool(m_ButtonProperty))
			{
				if (!UseButtonSmooth)
				{
					return true;
				}
				return component.HasFloat(m_ButtonSmoothProperty);
			}
			return false;
		}

		private void Start()
		{
			if (UseButtonSmooth)
			{
				m_CachedSmoothValue = (Input.GetButton(ButtonName) ? 1f : 0f);
			}
		}

		public override void UpdateBinding(VisualEffect component)
		{
			bool button = Input.GetButton(ButtonName);
			component.SetBool(m_ButtonProperty, button);
			if (UseButtonSmooth)
			{
				m_CachedSmoothValue += SmoothSpeed * Time.deltaTime * (button ? 1f : (-1f));
				m_CachedSmoothValue = Mathf.Clamp01(m_CachedSmoothValue);
				component.SetFloat(m_ButtonSmoothProperty, m_CachedSmoothValue);
			}
		}

		public override string ToString()
		{
			return $"Input Button: '{m_ButtonSmoothProperty}' -> {ButtonName.ToString()}";
		}
	}
}
