using UnityEngine;

namespace Rewired
{
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface IControllerTemplateAxis3D : IControllerTemplateElement
	{
		Vector3 value { get; }

		Vector3 valuePrev { get; }

		IControllerTemplateAxis horizontal { get; }

		IControllerTemplateAxis vertical { get; }

		IControllerTemplateAxis depth { get; }
	}
}
