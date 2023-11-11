using System;
using System.Collections.Generic;

namespace Rewired
{
	public interface IControllerTemplate
	{
		Controller controller { get; }

		string name { get; }

		Guid typeGuid { get; }

		IList<IControllerTemplateElement> elements { get; }

		int elementCount { get; }

		IControllerTemplateElement GetElement(int id);

		T GetElement<T>(int id) where T : class, IControllerTemplateElement;

		int GetElementTargets(ControllerElementTarget target, IList<ControllerTemplateElementTarget> results);
	}
}
