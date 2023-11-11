using UnityEngine;

namespace Rewired
{
	public interface IControllerTemplateHat : IControllerTemplateElement
	{
		Vector2 value { get; }

		Vector2 valuePrev { get; }

		IControllerTemplateButton up { get; }

		IControllerTemplateButton upRight { get; }

		IControllerTemplateButton right { get; }

		IControllerTemplateButton downRight { get; }

		IControllerTemplateButton down { get; }

		IControllerTemplateButton downLeft { get; }

		IControllerTemplateButton left { get; }

		IControllerTemplateButton upLeft { get; }
	}
}
