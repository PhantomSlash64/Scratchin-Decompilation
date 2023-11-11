using UnityEngine;

namespace Rewired
{
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface IControllerTemplateAxis2D : IControllerTemplateElement
	{
		Vector2 value { get; }

		Vector2 valuePrev { get; }

		IControllerTemplateAxis horizontal { get; }

		IControllerTemplateAxis vertical { get; }
	}
}
