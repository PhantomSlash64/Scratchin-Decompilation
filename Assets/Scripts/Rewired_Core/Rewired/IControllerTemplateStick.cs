using UnityEngine;

namespace Rewired
{
	public interface IControllerTemplateStick : IControllerTemplateElement
	{
		Vector3 value { get; }

		Vector3 valuePrev { get; }

		IControllerTemplateAxis horizontal { get; }

		IControllerTemplateAxis vertical { get; }

		IControllerTemplateAxis rotation { get; }
	}
}
