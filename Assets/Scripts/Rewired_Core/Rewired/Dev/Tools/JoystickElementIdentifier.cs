using Rewired.Interfaces;
using Rewired.Internal;
using Rewired.Platforms;
using Rewired.Utils;
using UnityEngine;

namespace Rewired.Dev.Tools
{
	[RequireComponent(typeof(Rewired.Internal.GUIText))]
	[AddComponentMenu("")]
	public sealed class JoystickElementIdentifier : MonoBehaviour
	{
		private IElementIdentifierTool jUbelwfMtzSFWdthhbIWGekKNOm;

		public void Awake()
		{
			if (!xkpVjzKucJCigtSpnnPfSuaHfRK())
			{
				return;
			}
			if (base.transform.position != Vector3.zero)
			{
				base.transform.position = Vector3.zero;
			}
			if (ReInput.UserData.ConfigVars.alwaysUseUnityInput || ReInput.usingUnityInput)
			{
				jUbelwfMtzSFWdthhbIWGekKNOm = new MidhwdEpAgeQchCqDaHVqRFpvaY();
			}
			else
			{
				Platform platform = UnityTools.platform;
				if (UnityTools.isEditor)
				{
					switch (UnityTools.editorPlatform)
					{
					case EditorPlatform.Windows:
						platform = Platform.Windows;
						break;
					case EditorPlatform.OSX:
						platform = Platform.OSX;
						break;
					case EditorPlatform.Linux:
						platform = Platform.Linux;
						break;
					}
				}
				switch (ReInput.primaryInputManager.inputSourceType)
				{
				case InputSource.Fallback:
				case InputSource.Fallback_PreConfigured:
					jUbelwfMtzSFWdthhbIWGekKNOm = new MidhwdEpAgeQchCqDaHVqRFpvaY();
					break;
				}
				if (jUbelwfMtzSFWdthhbIWGekKNOm == null)
				{
					switch (platform)
					{
					case Platform.Windows:
						switch (ReInput.primaryInputManager.inputSourceType)
						{
						case InputSource.DirectInput:
							jUbelwfMtzSFWdthhbIWGekKNOm = XGlzZxXeJIZWLxkQirgkskjObTg.alotxluMWAUxHKeMGSCozzOoqGZ("Rewired_Windows", "DirectInput") as IElementIdentifierTool;
							break;
						case InputSource.RawInput:
							jUbelwfMtzSFWdthhbIWGekKNOm = XGlzZxXeJIZWLxkQirgkskjObTg.alotxluMWAUxHKeMGSCozzOoqGZ("Rewired_Windows", "RawInput") as IElementIdentifierTool;
							break;
						}
						break;
					case Platform.WindowsAppStore:
						jUbelwfMtzSFWdthhbIWGekKNOm = new MidhwdEpAgeQchCqDaHVqRFpvaY();
						break;
					case Platform.WindowsUWP:
						jUbelwfMtzSFWdthhbIWGekKNOm = XGlzZxXeJIZWLxkQirgkskjObTg.alotxluMWAUxHKeMGSCozzOoqGZ("", "WindowsUWP") as IElementIdentifierTool;
						break;
					case Platform.OSX:
						jUbelwfMtzSFWdthhbIWGekKNOm = XGlzZxXeJIZWLxkQirgkskjObTg.alotxluMWAUxHKeMGSCozzOoqGZ("Rewired_OSX", "OSX") as IElementIdentifierTool;
						break;
					case Platform.Linux:
						jUbelwfMtzSFWdthhbIWGekKNOm = XGlzZxXeJIZWLxkQirgkskjObTg.alotxluMWAUxHKeMGSCozzOoqGZ("Rewired_Linux", "Linux") as IElementIdentifierTool;
						break;
					case Platform.WebGL:
						jUbelwfMtzSFWdthhbIWGekKNOm = XGlzZxXeJIZWLxkQirgkskjObTg.alotxluMWAUxHKeMGSCozzOoqGZ("Rewired_WebGL", "WebGL") as IElementIdentifierTool;
						break;
					case Platform.Stadia:
						jUbelwfMtzSFWdthhbIWGekKNOm = XGlzZxXeJIZWLxkQirgkskjObTg.alotxluMWAUxHKeMGSCozzOoqGZ("Rewired_Stadia", "Stadia") as IElementIdentifierTool;
						break;
					case Platform.GameCoreXboxOne:
					case Platform.GameCoreScarlett:
						jUbelwfMtzSFWdthhbIWGekKNOm = XGlzZxXeJIZWLxkQirgkskjObTg.alotxluMWAUxHKeMGSCozzOoqGZ("Rewired_GameCore", "GameCore") as IElementIdentifierTool;
						break;
					}
				}
			}
			if (jUbelwfMtzSFWdthhbIWGekKNOm == null)
			{
				Logger.LogWarning("There was an error initializing the platform tool for the current platform and input source. Unity input will be shown instead.");
				jUbelwfMtzSFWdthhbIWGekKNOm = new MidhwdEpAgeQchCqDaHVqRFpvaY();
			}
			jUbelwfMtzSFWdthhbIWGekKNOm.Initialize(Rewired.Internal.GUIText.CreateLogger(base.gameObject));
		}

		public void Start()
		{
			if (jUbelwfMtzSFWdthhbIWGekKNOm != null)
			{
				jUbelwfMtzSFWdthhbIWGekKNOm.Start();
			}
		}

		public void Update()
		{
			if (jUbelwfMtzSFWdthhbIWGekKNOm != null)
			{
				jUbelwfMtzSFWdthhbIWGekKNOm.Update();
			}
		}

		public void OnDestroy()
		{
			if (jUbelwfMtzSFWdthhbIWGekKNOm != null)
			{
				jUbelwfMtzSFWdthhbIWGekKNOm.OnDestroy();
			}
			jUbelwfMtzSFWdthhbIWGekKNOm = null;
		}

		private bool xkpVjzKucJCigtSpnnPfSuaHfRK()
		{
			if (!ReInput.isReady)
			{
				Logger.LogError("No active Rewired Input Manager was found in the scene! You must create a Rewired Input Manager for the tool to function.");
				return false;
			}
			return true;
		}
	}
}
