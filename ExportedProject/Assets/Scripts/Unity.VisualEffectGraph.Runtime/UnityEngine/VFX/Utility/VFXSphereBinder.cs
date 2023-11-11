using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[AddComponentMenu("VFX/Property Binders/Sphere Collider Binder")]
	[VFXBinder("Collider/Sphere")]
	internal class VFXSphereBinder : VFXBinderBase
	{
		[VFXPropertyBinding(new string[] { "UnityEditor.VFX.Sphere" })]
		[SerializeField]
		[FormerlySerializedAs("m_Parameter")]
		protected ExposedProperty m_Property = "Sphere";

		public SphereCollider Target;

		private ExposedProperty Center;

		private ExposedProperty Radius;

		public string Property
		{
			get
			{
				return (string)m_Property;
			}
			set
			{
				m_Property = value;
				UpdateSubProperties();
			}
		}

		protected override void OnEnable()
		{
			base.OnEnable();
			UpdateSubProperties();
		}

		private void OnValidate()
		{
			UpdateSubProperties();
		}

		private void UpdateSubProperties()
		{
			Center = m_Property + "_center";
			Radius = m_Property + "_radius";
		}

		public override bool IsValid(VisualEffect component)
		{
			if (Target != null && component.HasVector3(Center))
			{
				return component.HasFloat(Radius);
			}
			return false;
		}

		public override void UpdateBinding(VisualEffect component)
		{
			component.SetVector3(Center, Target.transform.position + Target.center);
			component.SetFloat(Radius, Target.radius * GetSphereColliderScale(Target.transform.localScale));
		}

		public float GetSphereColliderScale(Vector3 scale)
		{
			return Mathf.Max(scale.x, Mathf.Max(scale.y, scale.z));
		}

		public override string ToString()
		{
			return string.Format("Sphere : '{0}' -> {1}", m_Property, (Target == null) ? "(null)" : Target.name);
		}
	}
}
