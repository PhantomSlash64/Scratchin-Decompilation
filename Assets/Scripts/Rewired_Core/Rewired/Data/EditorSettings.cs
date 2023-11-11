using UnityEngine;

namespace Rewired.Data
{
	public class EditorSettings : ScriptableObject
	{
		[CustomObfuscation(rename = false)]
		public int programVersion1;

		[CustomObfuscation(rename = false)]
		public int programVersion2;

		[CustomObfuscation(rename = false)]
		public int programVersion3;

		[CustomObfuscation(rename = false)]
		public int programVersion4;

		[CustomObfuscation(rename = false)]
		public int dataVersion;
	}
}
