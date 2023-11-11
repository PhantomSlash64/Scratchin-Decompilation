using UnityEngine.Serialization;

namespace UnityEngine.VFX.Utility
{
	[AddComponentMenu("VFX/Property Binders/Previous Position Binder")]
	[VFXBinder("Transform/Position (Previous)")]
	internal class VFXPreviousPositionBinder : VFXBinderBase
	{
		[VFXPropertyBinding(new string[] { "UnityEngine.Vector3" })]
		[FormerlySerializedAs("m_Parameter")]
		public ExposedProperty m_Property = "PreviousPosition";

		public Transform Target;

		private Vector3 oldPosition;

		protected override void OnEnable()
		{
			base.OnEnable();
			oldPosition = ((Target != null) ? Target.position : Vector3.zero);
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
			component.SetVector3(m_Property, oldPosition);
			oldPosition = Target.position;
		}

		public override string ToString()
		{
			return string.Format("Previous Position : '{0}' -> {1}", m_Property, (Target == null) ? "(null)" : Target.name);
		}
	}
}
