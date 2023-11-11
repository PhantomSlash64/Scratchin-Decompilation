using UnityEngine;

namespace Rewired
{
	public interface IControllerTemplateThumbStick : IControllerTemplateElement
	{
		Vector2 value { get; }

		Vector2 valuePrev { get; }

		IControllerTemplateAxis horizontal { get; }

		IControllerTemplateAxis vertical { get; }

		IControllerTemplateButton press { get; }
	}
}
