using System.Collections.Generic;
using Rewired.Interfaces;

namespace Rewired.Data.Mapping
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	internal interface IHardwareControllerMap_Internal
	{
		IEnumerable<IControllerElementIdentifierCommon_Internal> ElementIdentifiers { get; }

		IControllerElementIdentifierCommon_Internal GetElementIdentifier(int id);
	}
}
