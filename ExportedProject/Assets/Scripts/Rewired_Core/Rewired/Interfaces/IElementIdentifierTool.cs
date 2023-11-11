using Rewired.Internal;

namespace Rewired.Interfaces
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	internal interface IElementIdentifierTool
	{
		void Initialize(GUIText guiText);

		void Start();

		void Update();

		void OnDestroy();
	}
}
