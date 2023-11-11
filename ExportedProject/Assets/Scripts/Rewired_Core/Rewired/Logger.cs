using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Rewired.Config;
using Rewired.Internal;
using Rewired.Utils;
using UnityEngine;

namespace Rewired
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	internal static class Logger
	{
		private const int screenLogLength = 50;

		private static List<string> __screenLog;

		private static Rewired.Internal.GUIText _guiText;

		private static bool _logToScreen;

		private static List<string> screenLog => __screenLog ?? (__screenLog = new List<string>());

		private static LogLevelFlags logLevel
		{
			get
			{
				if (!ReInput.isReady || ReInput.configVars == null)
				{
					return LogLevelFlags.Info | LogLevelFlags.Warning | LogLevelFlags.Error;
				}
				return ReInput.configVars.logLevel;
			}
		}

		public static bool logToScreen
		{
			get
			{
				return _logToScreen;
			}
			set
			{
				if (value != _logToScreen)
				{
					if (value)
					{
						GameObject gameObject = new GameObject("Screen Log");
						_guiText = gameObject.AddComponent<Rewired.Internal.GUIText>();
						_guiText.anchor = TextAnchor.LowerLeft;
					}
					else if (_guiText != null)
					{
						UnityEngine.Object.Destroy(_guiText.gameObject);
					}
					_logToScreen = value;
				}
			}
		}

		public static void LogEditor(object msg)
		{
			LogEditor(msg, requiredThreadSafety: false);
		}

		public static void LogEditor(object msg, bool requiredThreadSafety)
		{
			if ((requiredThreadSafety || Application.isEditor) && (!UnityTools.isInitialized || UnityTools.isEditor))
			{
				Log(msg, requiredThreadSafety);
			}
		}

		public static void LogWarningEditor(object msg)
		{
			LogWarningEditor(msg, requiredThreadSafety: false);
		}

		public static void LogWarningEditor(object msg, bool requiredThreadSafety)
		{
			if ((requiredThreadSafety || Application.isEditor) && (!UnityTools.isInitialized || UnityTools.isEditor))
			{
				LogWarning(msg, requiredThreadSafety);
			}
		}

		public static void LogErrorEditor(object msg)
		{
			LogErrorEditor(msg, requiredThreadSafety: false);
		}

		public static void LogErrorEditor(object msg, bool requiredThreadSafety)
		{
			if ((requiredThreadSafety || Application.isEditor) && (!UnityTools.isInitialized || UnityTools.isEditor))
			{
				LogError(msg, requiredThreadSafety);
			}
		}

		public static void Log(object msg)
		{
			Log(msg, requiredThreadSafety: false);
		}

		public static void Log(object msg, bool requiredThreadSafety)
		{
			if (IsLoggingAllowed(LogLevel.Info))
			{
				if (msg == null)
				{
					msg = string.Empty;
				}
				LogNow(msg, requiredThreadSafety);
				if (_logToScreen)
				{
					LogToScreen(msg);
				}
			}
		}

		public static void LogWarning(object msg)
		{
			LogWarning(msg, requiredThreadSafety: false);
		}

		public static void LogWarning(object msg, bool requiredThreadSafety)
		{
			if (IsLoggingAllowed(LogLevel.Warning))
			{
				if (msg == null)
				{
					msg = string.Empty;
				}
				if (ReInput.isReady && !UnityTools.isEditor)
				{
					msg = "[WARNING] " + msg;
				}
				LogWarningNow(msg, requiredThreadSafety);
				if (_logToScreen)
				{
					LogToScreen(msg);
				}
			}
		}

		public static void LogError(object msg)
		{
			LogError(msg, requiredThreadSafety: false);
		}

		public static void LogError(object msg, bool requiredThreadSafety)
		{
			if (IsLoggingAllowed(LogLevel.Error))
			{
				if (msg == null)
				{
					msg = string.Empty;
				}
				if (ReInput.isReady && !UnityTools.isEditor)
				{
					msg = "[ERROR] " + msg;
				}
				msg = string.Concat(msg, "\n------- Rewired System Info -------\n");
				object obj = msg;
				msg = string.Concat(obj, "Unity version: ", UnityTools.unityVersionString, "\n");
				object obj2 = msg;
				msg = string.Concat(obj2, "Rewired version: ", ReInput.programVersion, "\n");
				object obj3 = msg;
				msg = string.Concat(obj3, "Platform: ", UnityTools.platform, "\n");
				if (UnityTools.editorPlatform != 0)
				{
					object obj4 = msg;
					msg = string.Concat(obj4, "Editor Platform: ", UnityTools.editorPlatform, "\n");
				}
				if (UnityTools.webplayerPlatform != 0)
				{
					object obj5 = msg;
					msg = string.Concat(obj5, "Webplayer Platform: ", UnityTools.webplayerPlatform, "\n");
				}
				object obj6 = msg;
				msg = string.Concat(obj6, "Using Unity input: ", ReInput.usingUnityInput, "\n");
				if (ReInput.isReady && ReInput.UserData != null && ReInput.UserData.ConfigVars != null)
				{
					msg = string.Concat(msg, ReInput.UserData.ConfigVars.GetDebugConfigSettings());
				}
				LogErrorNow(msg, requiredThreadSafety);
				if (_logToScreen)
				{
					LogToScreen(msg);
				}
			}
		}

		private static void LogNow(object msg, bool requireThreadSafety)
		{
			if (requireThreadSafety)
			{
				UnityEngine.Debug.Log(msg);
			}
			else if (UnityTools.logToDebugLog)
			{
				UnityEngine.Debug.unityLogger.Log("Rewired", msg);
			}
			else
			{
				Console.WriteLine(msg);
			}
		}

		private static void LogWarningNow(object msg, bool requireThreadSafety)
		{
			if (requireThreadSafety)
			{
				UnityEngine.Debug.LogWarning(msg);
			}
			else if (UnityTools.logToDebugLog)
			{
				UnityEngine.Debug.unityLogger.LogWarning("Rewired", msg);
			}
			else
			{
				Console.WriteLine(msg);
			}
		}

		private static void LogErrorNow(object msg, bool requireThreadSafety)
		{
			if (requireThreadSafety)
			{
				UnityEngine.Debug.LogError(msg);
			}
			else if (UnityTools.logToDebugLog)
			{
				UnityEngine.Debug.unityLogger.LogError("Rewired", msg);
			}
			else
			{
				Console.WriteLine(msg);
			}
		}

		private static bool IsLoggingAllowed(LogLevel logLevel)
		{
			switch (logLevel)
			{
			case LogLevel.Info:
				if ((Logger.logLevel & LogLevelFlags.Info) != 0)
				{
					return true;
				}
				break;
			case LogLevel.Warning:
				if ((Logger.logLevel & LogLevelFlags.Warning) != 0)
				{
					return true;
				}
				break;
			case LogLevel.Error:
				if ((Logger.logLevel & LogLevelFlags.Error) != 0)
				{
					return true;
				}
				break;
			case LogLevel.Debug:
				if ((Logger.logLevel & LogLevelFlags.Debug) != 0)
				{
					return true;
				}
				break;
			default:
				throw new NotImplementedException();
			}
			return false;
		}

		private static void LogToScreen(object msg)
		{
			if (msg == null)
			{
				return;
			}
			string text = msg.ToString();
			if (Regex.IsMatch(text, "(\r\n|\r|\n)"))
			{
				Regex.Replace(text, "(\r\n|\r|\n)", "\n");
				string[] array = text.Split('\n');
				for (int i = 0; i < array.Length; i++)
				{
					if (!string.IsNullOrEmpty(array[i]))
					{
						array[i] = array[i].Trim();
						if (!string.IsNullOrEmpty(array[i]))
						{
							screenLog.Add(array[i]);
						}
					}
				}
			}
			else
			{
				screenLog.Add(text);
			}
			int num = screenLog.Count - 50;
			if (num > 0)
			{
				screenLog.RemoveRange(0, num);
			}
			_guiText.text = "";
			if (screenLog.Count > 0)
			{
				for (int j = 0; j < screenLog.Count; j++)
				{
					Rewired.Internal.GUIText guiText = _guiText;
					guiText.text = guiText.text + screenLog[j] + "\n";
				}
			}
		}

		[Conditional("LOG_INIT")]
		public static void LogInit(object o)
		{
			Log(o, requiredThreadSafety: true);
		}

		[Conditional("LOG_INIT")]
		public static void LogInitError(object o)
		{
			LogError(o, requiredThreadSafety: true);
		}

		[Conditional("LOG_INIT")]
		public static void LogInitWarning(object o)
		{
			LogWarning(o, requiredThreadSafety: true);
		}

		[Conditional("LOG_VC")]
		public static void Log_VCTest(object o)
		{
			Log(o);
		}

		[Conditional("LOG_UPDATE")]
		public static void LogUpdate(object o)
		{
			Log(o, requiredThreadSafety: true);
		}
	}
}
