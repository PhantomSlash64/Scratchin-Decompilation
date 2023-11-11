using System.ComponentModel;
using System.Text.RegularExpressions;
using Rewired.Platforms;
using Rewired.Utils;
using Rewired.Utils.Interfaces;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Rewired
{
	[AddComponentMenu("Rewired/Input Manager")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sealed class InputManager : InputManager_Base
	{
		private bool ignoreRecompile;

		protected override void OnInitialized()
		{
			SubscribeEvents();
		}

		protected override void OnDeinitialized()
		{
			UnsubscribeEvents();
		}

		protected override void DetectPlatform()
		{
			scriptingBackend = ScriptingBackend.Mono;
			scriptingAPILevel = ScriptingAPILevel.Net20;
			editorPlatform = EditorPlatform.None;
			platform = Platform.Unknown;
			webplayerPlatform = WebplayerPlatform.None;
			isEditor = false;
			if (SystemInfo.deviceName == null)
			{
				_ = string.Empty;
			}
			if (SystemInfo.deviceModel == null)
			{
				_ = string.Empty;
			}
			platform = Platform.Windows;
			scriptingBackend = ScriptingBackend.Mono;
			scriptingAPILevel = ScriptingAPILevel.NetStandard20;
		}

		protected override void CheckRecompile()
		{
		}

		protected override IExternalTools GetExternalTools()
		{
			return new ExternalTools();
		}

		private bool CheckDeviceName(string searchPattern, string deviceName, string deviceModel)
		{
			if (!Regex.IsMatch(deviceName, searchPattern, RegexOptions.IgnoreCase))
			{
				return Regex.IsMatch(deviceModel, searchPattern, RegexOptions.IgnoreCase);
			}
			return true;
		}

		private void SubscribeEvents()
		{
			UnsubscribeEvents();
			SceneManager.sceneLoaded += OnSceneLoaded;
		}

		private void UnsubscribeEvents()
		{
			SceneManager.sceneLoaded -= OnSceneLoaded;
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
			OnSceneLoaded();
		}
	}
}
