using Rewired.Data;
using Rewired.Interfaces;

namespace Rewired
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	[CustomObfuscation(rename = false)]
	internal abstract class PlatformInitializer
	{
		public abstract object Initialize(IConfigVars_Internal configVars);

		public abstract IElementIdentifierTool CreateTool(string inputSourceString);
	}
}
