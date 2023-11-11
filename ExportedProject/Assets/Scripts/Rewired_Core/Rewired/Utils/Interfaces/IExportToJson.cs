using System;
using System.Text;

namespace Rewired.Utils.Interfaces
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface IExportToJson
	{
		void WriteJson(StringBuilder stringBuilder, Action<StringBuilder, object> appendValueDelegate);
	}
}
