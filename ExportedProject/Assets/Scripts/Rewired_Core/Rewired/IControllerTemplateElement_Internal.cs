using System.Collections.Generic;

namespace Rewired
{
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface IControllerTemplateElement_Internal
	{
		IControllerTemplate parent { get; }

		int elementCount { get; }

		IControllerTemplateElement GetElement(int index);

		int GetElementTargets(ControllerElementTarget find, ref IList<ControllerTemplateElementTarget> list);
	}
}
