using System.Xml;

namespace Rewired.Utils.Interfaces
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface IExportToXml
	{
		bool writesOwnElementTag { get; }

		void WriteXml(XmlWriter writer);
	}
}
