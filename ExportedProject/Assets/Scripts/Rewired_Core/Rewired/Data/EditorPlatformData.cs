using System;
using Rewired.Platforms;
using UnityEngine;

namespace Rewired.Data
{
	public class EditorPlatformData : ScriptableObject
	{
		[Serializable]
		public class Platform
		{
			public TextAsset[] libraries;
		}

		[CustomObfuscation(rename = false)]
		public Platform windowsStandalone;

		[CustomObfuscation(rename = false)]
		public Platform windowsStore;

		[CustomObfuscation(rename = false)]
		public Platform osxStandalone;

		[CustomObfuscation(rename = false)]
		public Platform linuxStandalone;

		[CustomObfuscation(rename = false)]
		public Platform webplayer;

		[CustomObfuscation(rename = false)]
		public Platform fallback;

		public TextAsset[] GetLibraries(Rewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform)
		{
			return GetPlatform(platform, webplayerPlatform, editorPlatform).libraries;
		}

		public Platform GetPlatform(Rewired.Platforms.Platform platform, WebplayerPlatform webplayerPlatform, EditorPlatform editorPlatform)
		{
			if (webplayerPlatform != 0)
			{
				return webplayer;
			}
			return platform switch
			{
				Rewired.Platforms.Platform.Windows => windowsStandalone, 
				Rewired.Platforms.Platform.OSX => osxStandalone, 
				Rewired.Platforms.Platform.Linux => linuxStandalone, 
				Rewired.Platforms.Platform.WindowsAppStore => windowsStore, 
				_ => fallback, 
			};
		}
	}
}
