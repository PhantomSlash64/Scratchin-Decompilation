using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[AddComponentMenu("VFX/Property Binders/Position Binder")]
	[VFXBinder("Transform/Position")]
	internal class VFXPositionBinder : VFXBinderBase
	{
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Position", "UnityEngine.Vector3" })]
		[SerializeField]
		[FormerlySerializedAs("m_Parameter")]
		protected ExposedProperty m_Property = "Position";

		public Transform Target;

		public string Property
		{
			get
			{
				return (string)m_Property;
			}
			set
			{
				m_Property = value;
			}
		}

		public override bool IsValid(VisualEffect component)
		{
			if (Target != null)
			{
				return component.HasVector3(m_Property);
			}
			return false;
		}

		public override void UpdateBinding(VisualEffect component)
		{
			component.SetVector3(m_Property, Target.transform.position);
		}

		public override string ToString()
		{
			return string.Format("Position : '{0}' -> {1}", m_Property, (Target == null) ? "(null)" : Target.name);
		}
	}
}
