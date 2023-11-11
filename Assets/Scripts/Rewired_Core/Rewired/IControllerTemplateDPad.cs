using UnityEngine;

namespace Rewired
{
	public interface IControllerTemplateDPad : IControllerTemplateElement
	{
		Vector2 value { get; }

		Vector2 valuePrev { get; }

		IControllerTemplateButton up { get; }

		IControllerTemplateButton right { get; }

		IControllerTemplateButton down { get; }

		IControllerTemplateButton left { get; }

		IControllerTemplateButton press { get; }
	}
}
