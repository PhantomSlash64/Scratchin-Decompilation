using System.Collections.Generic;
using Rewired.Platforms;
using UnityEngine;

namespace Rewired.Data
{
	public class RuntimeData : ScriptableObject
	{
		[CustomObfuscation(rename = false)]
		public Platform platform;

		[CustomObfuscation(rename = false)]
		public WebplayerPlatform webplayerPlatform;

		[CustomObfuscation(rename = false)]
		public EditorPlatform editorPlatform;

		[CustomObfuscation(rename = false)]
		public List<TextAsset> libraries;

		public void SetPlatform(Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform, List<TextAsset> libraries)
		{
			this.libraries = libraries;
			this.platform = platform;
			this.webplayerPlatform = webplayerPlatform;
			this.editorPlatform = editorPlatform;
		}
	}
}
