using UnityEngine;

namespace Rewired
{
	public interface IControllerTemplateYoke : IControllerTemplateElement
	{
		Vector2 value { get; }

		Vector2 valuePrev { get; }

		IControllerTemplateAxis rotation { get; }

		IControllerTemplateAxis pushPull { get; }
	}
}
