using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired.Platforms;
using Rewired.Utils;
using UnityEngine;

namespace Rewired.Dev.Tools
{
	public class DebugInformation : MonoBehaviour
	{
		private class SxRtYdfyQVQDsfjlazIKPhpUXrX : IDisposable
		{
			public readonly bool BKryQPIIljiORNYFaafBUdnhsoo;

			public SxRtYdfyQVQDsfjlazIKPhpUXrX(string label, string key, IDictionary<string, bool> foldouts)
			{
				BKryQPIIljiORNYFaafBUdnhsoo = OwHNNKaTaLRstKCCLYYLlFvpDpA(label, key, foldouts);
				CPEsXtCPTTATILowlgngzjTVeuL.uYwprRUnAAXzkmKHKbIjwTqZjlr++;
			}

			private bool OwHNNKaTaLRstKCCLYYLlFvpDpA(string P_0, string P_1, IDictionary<string, bool> P_2)
			{
				return IdKIBcBhaKqxcyTWlmyHajcFoVF(P_1, GUILayout.Toggle(aOkNzwUhrfuKaOAjXwStDIRfmjX(P_1, P_2), new GUIContent(P_0, P_0), GetToggleStyle()), P_2);
			}

			private bool aOkNzwUhrfuKaOAjXwStDIRfmjX(string P_0, IDictionary<string, bool> P_1)
			{
				if (!P_1.ContainsKey(P_0))
				{
					P_1.Add(P_0, value: false);
				}
				return P_1[P_0];
			}

			private bool IdKIBcBhaKqxcyTWlmyHajcFoVF(string P_0, bool P_1, IDictionary<string, bool> P_2)
			{
				if (!P_2.ContainsKey(P_0))
				{
					P_2.Add(P_0, P_1);
				}
				else
				{
					P_2[P_0] = P_1;
				}
				return P_1;
			}

			public void Dispose()
			{
				CPEsXtCPTTATILowlgngzjTVeuL.uYwprRUnAAXzkmKHKbIjwTqZjlr--;
			}
		}

		private static class CPEsXtCPTTATILowlgngzjTVeuL
		{
			private static int pocsozaNjaDEiHCxJsikNGeKVghA;

			public static int uYwprRUnAAXzkmKHKbIjwTqZjlr
			{
				get
				{
					return pocsozaNjaDEiHCxJsikNGeKVghA;
				}
				set
				{
					pocsozaNjaDEiHCxJsikNGeKVghA = Mathf.Max(0, value);
				}
			}
		}

		private static class DJMGXyDsfrcGEVSAeoJzPTarblfn
		{
			public static void TbVbbJCPGqYRQeBjABDBXeCtzFce()
			{
				GUILayout.BeginHorizontal();
			}

			public static void GhyWeUgvFeMfrVtrsDVGArQAJIv()
			{
				GUILayout.EndHorizontal();
			}

			public static void GuZZQGJeNmaUwGfLePcgQvZvdhrd()
			{
				GUILayout.BeginVertical();
			}

			public static void kuAfBrAlSqAbrKSQRYpcBHSYGUcr()
			{
				GUILayout.EndVertical();
			}

			public static void tIIBfizvzomWMOEaCkPstfSTurI(string P_0, TOqOmJbtpCWeEVEMqNeyPTcwJrT P_1)
			{
				GUILayout.Label(P_0, mYeJYgYBBZOufalmWnViPpLofEs());
			}

			public static void lEDaazWgUfQwtchdTEzSafsbkoj(string P_0, string P_1)
			{
				GUILayout.Label(P_0 + ": " + P_1, mYeJYgYBBZOufalmWnViPpLofEs());
			}

			public static void HihmqdKdyvkCgbcAyHBwfzLQJyP(string P_0, AnimationCurve P_1)
			{
				GUILayout.Label(P_0 + ": Curves are not visualized by this tool.");
			}

			public static bool sRChMhLEinpJeatjXPHLKnLYdbv(string P_0, bool P_1)
			{
				return GUILayout.Toggle(P_1, P_0, mYeJYgYBBZOufalmWnViPpLofEs());
			}
		}

		private static class phyfIrHiEWReGFxVUANKUgXDsNko
		{
			[CompilerGenerated]
			private static float gcmXzPmQTHHGQAdliAiSkhCoNHqi;

			[CompilerGenerated]
			private static float iWEHZtajmjyVVHQTDNjZcrBJSis;

			public static float zEeNvQQftYRblmZmGsVoXCKLmtJ
			{
				[CompilerGenerated]
				get
				{
					return gcmXzPmQTHHGQAdliAiSkhCoNHqi;
				}
				[CompilerGenerated]
				set
				{
					gcmXzPmQTHHGQAdliAiSkhCoNHqi = value;
				}
			}

			public static float eGbMNGTdiVYKSKOgCotnAOiWrqh
			{
				[CompilerGenerated]
				get
				{
					return iWEHZtajmjyVVHQTDNjZcrBJSis;
				}
				[CompilerGenerated]
				set
				{
					iWEHZtajmjyVVHQTDNjZcrBJSis = value;
				}
			}
		}

		internal enum TOqOmJbtpCWeEVEMqNeyPTcwJrT
		{
			fUyeeVFhkdEderlnmYYFoAwmZEL = 0,
			jkIlUPhRLrERIFyPjxdKDmKKeQH = 1,
			ANHdxEzIBFbNLTtXEMDgQzEYtr = 2,
			thaJMcxCEfniPKfeXdMNDPzzNjYh = 3
		}

		[CompilerGenerated]
		private sealed class bGKqiTtNVmdNeFEAMpMSMuYbGdM
		{
			public InputCategory CAcCUmHYOrLQQgZmGHobWsJWSru;

			public bool iefMFofuFAjhTirUbFwIBcUHfDF(InputAction P_0)
			{
				return P_0.categoryId == CAcCUmHYOrLQQgZmGHobWsJWSru.id;
			}
		}

		private const string sjtdhSDjgfiNeCaqtBZUfpNziaQr = "Rewired_DebugInformation";

		private const string UowEHVaznzRIVnAEuyLIlOCMlgI = "Rewired Debug Information";

		private const int iYYDsjqgVWwsbmAxEmnnneHldFM = 20;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private int _fontSize = 13;

		private static DebugInformation GclIwrgVrnJKTEKbDVzknvtphRgP;

		private IDictionary<string, bool> zYkqWxibpOGzSDTstCvhALjmvlTi = new Dictionary<string, bool>();

		private static Vector2 FpDGhGApsokgUaDFieYmXYktDFkF;

		[CompilerGenerated]
		private static Comparison<InputAction> suQFSecMyJYdyKWXbLbVEMkNddOe;

		[CustomObfuscation(rename = false)]
		private void OnEnable()
		{
			GclIwrgVrnJKTEKbDVzknvtphRgP = this;
			if (zYkqWxibpOGzSDTstCvhALjmvlTi.Count == 0)
			{
				zYkqWxibpOGzSDTstCvhALjmvlTi.Add("Rewired_DebugInformation", value: true);
			}
		}

		[CustomObfuscation(rename = false)]
		private void OnDisable()
		{
			if (GclIwrgVrnJKTEKbDVzknvtphRgP == this)
			{
				GclIwrgVrnJKTEKbDVzknvtphRgP = null;
			}
		}

		[CustomObfuscation(rename = false)]
		private void OnGUI()
		{
			CPEsXtCPTTATILowlgngzjTVeuL.uYwprRUnAAXzkmKHKbIjwTqZjlr = 0;
			GUILayout.BeginArea(new Rect(0f, 0f, Screen.width, Screen.height));
			FpDGhGApsokgUaDFieYmXYktDFkF = GUILayout.BeginScrollView(FpDGhGApsokgUaDFieYmXYktDFkF, GUILayout.ExpandWidth(expand: true), GUILayout.ExpandHeight(expand: true));
			DrawDebugInformation(enabled: true, zYkqWxibpOGzSDTstCvhALjmvlTi);
			GUILayout.EndScrollView();
			GUILayout.EndArea();
		}

		public static void DrawDebugInformation(bool enabled, IDictionary<string, bool> foldouts)
		{
			bool flag = GUI.enabled;
			if (!ReInput.isReady || !enabled)
			{
				GUI.enabled = false;
			}
			DJMGXyDsfrcGEVSAeoJzPTarblfn.TbVbbJCPGqYRQeBjABDBXeCtzFce();
			GUILayout.FlexibleSpace();
			DJMGXyDsfrcGEVSAeoJzPTarblfn.GhyWeUgvFeMfrVtrsDVGArQAJIv();
			Rect lastRect = GUILayoutUtility.GetLastRect();
			float num = lastRect.width / 3f;
			phyfIrHiEWReGFxVUANKUgXDsNko.zEeNvQQftYRblmZmGsVoXCKLmtJ = lastRect.width - num;
			phyfIrHiEWReGFxVUANKUgXDsNko.eGbMNGTdiVYKSKOgCotnAOiWrqh = num;
			MTTLYpKWjxzOdRQHaLJAegxKdds(enabled, foldouts);
			GUI.enabled = flag;
			phyfIrHiEWReGFxVUANKUgXDsNko.zEeNvQQftYRblmZmGsVoXCKLmtJ = 0f;
			phyfIrHiEWReGFxVUANKUgXDsNko.eGbMNGTdiVYKSKOgCotnAOiWrqh = 0f;
		}

		private static void MTTLYpKWjxzOdRQHaLJAegxKdds(bool P_0, IDictionary<string, bool> P_1)
		{
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Rewired Debug Information", "Rewired_DebugInformation", P_1);
			if (!ReInput.isReady || !P_0)
			{
				GUILayout.Label("There is no active Rewired Input Manager in the scene.");
			}
			else
			{
				if (!sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
				{
					return;
				}
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Rewired Version", ReInput.programVersion);
				bool flag = ReInput.configuration.disableNativeInput;
				if (!flag && (ReInput.currentPlatform == Platform.Windows || ReInput.currentPlatform == Platform.OSX) && ReInput.primaryInputManager.inputSourceType == InputSource.Fallback)
				{
					flag = true;
				}
				if (flag)
				{
					DJMGXyDsfrcGEVSAeoJzPTarblfn.tIIBfizvzomWMOEaCkPstfSTurI("Native input is disabled. Many special features are unavailable without native input.", TOqOmJbtpCWeEVEMqNeyPTcwJrT.ANHdxEzIBFbNLTtXEMDgQzEYtr);
				}
				yEDcRUPqsGQhdwrAvZrSRnXRnTn(P_1, "Rewired_DebugInformation");
				string text = "Rewired_DebugInformation_controllers";
				using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX2 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Controllers", text, P_1);
				if (sxRtYdfyQVQDsfjlazIKPhpUXrX2.BKryQPIIljiORNYFaafBUdnhsoo)
				{
					CHuFKljYJmvpAblIkunLKLeSJFu(ReInput.controllers.Joysticks, P_1, text);
					UWKhKLJyKccwfUcOwUUevzBoQlZ(ReInput.controllers.CustomControllers, P_1, text);
					VOTfRgPLwljdmoNgJhCvEhGuBkU(P_1, "Rewired_DebugInformation");
					hvDdQtKYSCikQWMgzLuCidROJXe(P_1, "Rewired_DebugInformation");
				}
				return;
			}
		}

		private static void yEDcRUPqsGQhdwrAvZrSRnXRnTn(IDictionary<string, bool> P_0, string P_1)
		{
			string text = P_1 + "_players";
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Players (" + ReInput.players.allPlayerCount + ")", text, P_0);
			if (sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				int playerCount = ReInput.players.playerCount;
				for (int i = 0; i < playerCount; i++)
				{
					Player player = ReInput.players.GetPlayer(i);
					yjMabtidEvAcMBhzWiCGZsufCgya(player, i, P_0, text);
				}
				yjMabtidEvAcMBhzWiCGZsufCgya(ReInput.players.SystemPlayer, -1, P_0, text);
			}
		}

		private static void CHuFKljYJmvpAblIkunLKLeSJFu(IList<Joystick> P_0, IDictionary<string, bool> P_1, string P_2)
		{
			int num = P_0?.Count ?? 0;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Joysticks (" + num + ")", P_2 + "_joysticks", P_1);
			if (!sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				return;
			}
			for (int i = 0; i < num; i++)
			{
				Joystick joystick = P_0[i];
				string text = P_2 + "_joystick" + joystick.id;
				using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX2 = new SxRtYdfyQVQDsfjlazIKPhpUXrX(i + ": " + ((joystick.name == "Unknown Controller") ? joystick.hardwareName : joystick.name), text, P_1);
				if (!sxRtYdfyQVQDsfjlazIKPhpUXrX2.BKryQPIIljiORNYFaafBUdnhsoo)
				{
					continue;
				}
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Id (unique id)", joystick.id.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Name", joystick.name);
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Hardware Name", joystick.hardwareName);
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Is Recognized", (joystick.hardwareTypeGuid != Guid.Empty).ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Enabled", joystick.enabled.ToString());
				string text2 = string.Empty;
				for (int j = 0; j < ReInput.players.allPlayerCount; j++)
				{
					Player player = ReInput.players.AllPlayers[j];
					if (ReInput.controllers.IsJoystickAssignedToPlayer(joystick.id, player.id))
					{
						if (text2 != string.Empty)
						{
							text2 += ", ";
						}
						text2 += ((player.id == 9999999) ? "System" : player.id.ToString());
					}
				}
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Assigned to Players", (!string.IsNullOrEmpty(text2)) ? text2 : "None");
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("System Id", joystick.systemId.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Unity Id", ReInput.usingUnityInput ? joystick.unityId.ToString() : "--");
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Hardware Type Guid", joystick.hardwareTypeGuid.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Hardware Identifier", joystick.hardwareIdentifier);
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Device Instance Guid", joystick.deviceInstanceGuid.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Tag", joystick.tag);
				IlRegUQwyQZsXcPuVwgnWaksBkF(joystick.Axes, P_1, text);
				QCdOurMUdAkDsJTeltKshcmIUGR(joystick.Buttons, ControllerType.Joystick, P_1, text);
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Axis2D Count", joystick.axis2DCount.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Hat Count", joystick.hatCount.ToString());
				sGpDmDybdpmdmpEgLGbiFFPNqJt(joystick, P_1, text);
				CalibrationMap calibrationMap = joystick.calibrationMap;
				using (SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX3 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Calibration Map", text + "_calibrationMap", P_1))
				{
					if (sxRtYdfyQVQDsfjlazIKPhpUXrX3.BKryQPIIljiORNYFaafBUdnhsoo)
					{
						int axisCount = calibrationMap.axisCount;
						for (int k = 0; k < axisCount; k++)
						{
							AxisCalibration axisCalibration = calibrationMap.Axes[k];
							using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX4 = new SxRtYdfyQVQDsfjlazIKPhpUXrX(k + ": Axis Calibration (" + (axisCalibration.enabled ? "Enabled" : "Disabled") + ")", text + "_AxisCalibration" + k, P_1);
							if (sxRtYdfyQVQDsfjlazIKPhpUXrX4.BKryQPIIljiORNYFaafBUdnhsoo)
							{
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Enabled", axisCalibration.enabled.ToString());
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Apply Range Calibration", axisCalibration.applyRangeCalibration.ToString());
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Calibrated Max", axisCalibration.calibratedMax.ToString());
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Calibrated Min", axisCalibration.calibratedMin.ToString());
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Calibrated Zero", axisCalibration.calibratedZero.ToString());
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Dead Zone", axisCalibration.deadZone.ToString());
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Invert", axisCalibration.invert.ToString());
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Sensitivity Type", axisCalibration.sensitivityType.ToString());
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Sensitivity", axisCalibration.sensitivity.ToString());
								if (axisCalibration.sensitivityCurve != null)
								{
									bool flag = GUI.enabled;
									GUI.enabled = false;
									DJMGXyDsfrcGEVSAeoJzPTarblfn.HihmqdKdyvkCgbcAyHBwfzLQJyP("Sensitivity Curve", axisCalibration.sensitivityCurve);
									GUI.enabled = flag;
								}
								else
								{
									DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Sensitivity Curve", "--");
								}
							}
						}
					}
				}
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Supports Vibration", joystick.supportsVibration.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Vibration Motor Count", joystick.vibrationMotorCount.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Has Extension", (joystick.extension != null).ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Extension Type", (joystick.extension != null) ? joystick.extension.GetType().Name : "--");
				FYCowjTfNBSPAbMkCfQPIqYudKm(joystick, P_1, text);
			}
		}

		private static void VOTfRgPLwljdmoNgJhCvEhGuBkU(IDictionary<string, bool> P_0, string P_1)
		{
			string text = P_1 + "_mouse";
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Mouse", text, P_0);
			if (!sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				return;
			}
			Mouse mouse = ReInput.controllers.Mouse;
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Enabled", mouse.enabled.ToString());
			string text2 = string.Empty;
			for (int i = 0; i < ReInput.players.allPlayerCount; i++)
			{
				Player player = ReInput.players.AllPlayers[i];
				if (player.controllers.hasMouse)
				{
					if (text2 != string.Empty)
					{
						text2 += ", ";
					}
					text2 += ((player.id == 9999999) ? "System" : player.id.ToString());
				}
			}
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Assigned to Players", (!string.IsNullOrEmpty(text2)) ? text2 : "None");
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Screen Position", mouse.screenPosition.ToString());
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Screen Position Prev", mouse.screenPositionPrev.ToString());
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Screen Position Delta", mouse.screenPositionDelta.ToString());
			IlRegUQwyQZsXcPuVwgnWaksBkF(mouse.Axes, P_0, text);
			QCdOurMUdAkDsJTeltKshcmIUGR(mouse.Buttons, ControllerType.Mouse, P_0, text);
			sGpDmDybdpmdmpEgLGbiFFPNqJt(mouse, P_0, text);
			FYCowjTfNBSPAbMkCfQPIqYudKm(mouse, P_0, text);
		}

		private static void hvDdQtKYSCikQWMgzLuCidROJXe(IDictionary<string, bool> P_0, string P_1)
		{
			string text = P_1 + "_keyboard";
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Keyboard", text, P_0);
			if (!sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				return;
			}
			Keyboard keyboard = ReInput.controllers.Keyboard;
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Enabled", keyboard.enabled.ToString());
			string text2 = string.Empty;
			for (int i = 0; i < ReInput.players.allPlayerCount; i++)
			{
				Player player = ReInput.players.AllPlayers[i];
				if (player.controllers.hasKeyboard)
				{
					if (text2 != string.Empty)
					{
						text2 += ", ";
					}
					text2 += ((player.id == 9999999) ? "System" : player.id.ToString());
				}
			}
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Assigned to Players", (!string.IsNullOrEmpty(text2)) ? text2 : "None");
			QCdOurMUdAkDsJTeltKshcmIUGR(keyboard.Buttons, ControllerType.Keyboard, P_0, text);
			sGpDmDybdpmdmpEgLGbiFFPNqJt(keyboard, P_0, text);
			FYCowjTfNBSPAbMkCfQPIqYudKm(keyboard, P_0, text);
		}

		private static void UWKhKLJyKccwfUcOwUUevzBoQlZ(IList<CustomController> P_0, IDictionary<string, bool> P_1, string P_2)
		{
			int num = P_0?.Count ?? 0;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Custom Controllers (" + num + ")", P_2 + "_customControllers", P_1);
			if (!sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				return;
			}
			for (int i = 0; i < num; i++)
			{
				CustomController customController = P_0[i];
				string text = P_2 + "_customController" + customController.id;
				using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX2 = new SxRtYdfyQVQDsfjlazIKPhpUXrX(i + ": " + customController.name, text, P_1);
				if (!sxRtYdfyQVQDsfjlazIKPhpUXrX2.BKryQPIIljiORNYFaafBUdnhsoo)
				{
					continue;
				}
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Id", customController.id.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Name", customController.name);
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Hardware Name", customController.hardwareName);
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Tag", customController.tag);
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Hardware Identifier", customController.hardwareIdentifier);
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Enabled", customController.enabled.ToString());
				string text2 = string.Empty;
				for (int j = 0; j < ReInput.players.allPlayerCount; j++)
				{
					Player player = ReInput.players.AllPlayers[j];
					if (ReInput.controllers.IsCustomControllerAssignedToPlayer(customController.id, player.id))
					{
						if (text2 != string.Empty)
						{
							text2 += ", ";
						}
						text2 += ((player.id == 9999999) ? "System" : player.id.ToString());
					}
				}
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Assigned to Players", (!string.IsNullOrEmpty(text2)) ? text2 : "None");
				IlRegUQwyQZsXcPuVwgnWaksBkF(customController.Axes, P_1, text);
				QCdOurMUdAkDsJTeltKshcmIUGR(customController.Buttons, ControllerType.Custom, P_1, text);
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Axis2D Count", customController.axis2DCount.ToString());
				using (SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX3 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Element Identifiers", text + "_elementIdentifiers", P_1))
				{
					if (sxRtYdfyQVQDsfjlazIKPhpUXrX3.BKryQPIIljiORNYFaafBUdnhsoo)
					{
						int num2 = ((customController.AxisElementIdentifiers != null) ? customController.AxisElementIdentifiers.Count : 0);
						using (SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX4 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Axis Element Identifiers (" + num2 + ")", text + "_axisEIs", P_1))
						{
							if (sxRtYdfyQVQDsfjlazIKPhpUXrX4.BKryQPIIljiORNYFaafBUdnhsoo)
							{
								for (int k = 0; k < num2; k++)
								{
									ControllerElementIdentifier controllerElementIdentifier = customController.AxisElementIdentifiers[k];
									using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX5 = new SxRtYdfyQVQDsfjlazIKPhpUXrX(k + ": " + controllerElementIdentifier.name + " (id: " + controllerElementIdentifier.id + ")", text + "_AxisEI" + k + "_" + controllerElementIdentifier.name, P_1);
									if (sxRtYdfyQVQDsfjlazIKPhpUXrX5.BKryQPIIljiORNYFaafBUdnhsoo)
									{
										DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Id", controllerElementIdentifier.id.ToString());
										DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Name", controllerElementIdentifier.name);
									}
								}
							}
						}
						num2 = ((customController.ButtonElementIdentifiers != null) ? customController.ButtonElementIdentifiers.Count : 0);
						using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX6 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Button Element Identifiers (" + num2 + ")", text + "_buttonEIs", P_1);
						if (sxRtYdfyQVQDsfjlazIKPhpUXrX6.BKryQPIIljiORNYFaafBUdnhsoo)
						{
							for (int l = 0; l < num2; l++)
							{
								ControllerElementIdentifier controllerElementIdentifier2 = customController.ButtonElementIdentifiers[l];
								using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX7 = new SxRtYdfyQVQDsfjlazIKPhpUXrX(l + ": " + controllerElementIdentifier2.name + " (id: " + controllerElementIdentifier2.id + ")", text + "_ButtonEI" + l + "_" + controllerElementIdentifier2.name, P_1);
								if (sxRtYdfyQVQDsfjlazIKPhpUXrX7.BKryQPIIljiORNYFaafBUdnhsoo)
								{
									DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Id", controllerElementIdentifier2.id.ToString());
									DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Name", controllerElementIdentifier2.name);
								}
							}
						}
					}
				}
				CalibrationMap calibrationMap = customController.calibrationMap;
				using (SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX8 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Calibration Map", text + "_calibrationMap", P_1))
				{
					if (sxRtYdfyQVQDsfjlazIKPhpUXrX8.BKryQPIIljiORNYFaafBUdnhsoo)
					{
						int num2 = calibrationMap.axisCount;
						for (int m = 0; m < num2; m++)
						{
							AxisCalibration axisCalibration = calibrationMap.Axes[m];
							using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX9 = new SxRtYdfyQVQDsfjlazIKPhpUXrX(m + ": Axis Calibration (" + (axisCalibration.enabled ? "Enabled" : "Disabled") + ")", text + "_AxisCalibration" + m, P_1);
							if (sxRtYdfyQVQDsfjlazIKPhpUXrX9.BKryQPIIljiORNYFaafBUdnhsoo)
							{
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Enabled", axisCalibration.enabled.ToString());
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Apply Range Calibration", axisCalibration.applyRangeCalibration.ToString());
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Calibrated Max", axisCalibration.calibratedMax.ToString());
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Calibrated Min", axisCalibration.calibratedMin.ToString());
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Calibrated Zero", axisCalibration.calibratedZero.ToString());
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Dead Zone", axisCalibration.deadZone.ToString());
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Invert", axisCalibration.invert.ToString());
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Sensitivity Type", axisCalibration.sensitivityType.ToString());
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Sensitivity", axisCalibration.sensitivity.ToString());
								if (axisCalibration.sensitivityCurve != null)
								{
									bool flag = GUI.enabled;
									GUI.enabled = false;
									DJMGXyDsfrcGEVSAeoJzPTarblfn.HihmqdKdyvkCgbcAyHBwfzLQJyP("Sensitivity Curve", axisCalibration.sensitivityCurve);
									GUI.enabled = flag;
								}
								else
								{
									DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Sensitivity Curve", "--");
								}
							}
						}
					}
				}
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Has Extension", (customController.extension != null).ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Extension Type", (customController.extension != null) ? customController.extension.GetType().Name : "--");
				FYCowjTfNBSPAbMkCfQPIqYudKm(customController, P_1, text);
			}
		}

		private static void yjMabtidEvAcMBhzWiCGZsufCgya(Player P_0, int P_1, IDictionary<string, bool> P_2, string P_3)
		{
			string text = P_3 + "_player" + P_0.id;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX((P_0.id == 9999999) ? "System Player" : (P_1 + ": " + P_0.name), text, P_2);
			if (!sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				return;
			}
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Player Id", P_0.id.ToString());
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Name", P_0.name);
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Descriptive Name", P_0.descriptiveName);
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Is Playing", P_0.isPlaying.ToString());
			using (SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX2 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Controllers", text + "_controllers", P_2))
			{
				if (sxRtYdfyQVQDsfjlazIKPhpUXrX2.BKryQPIIljiORNYFaafBUdnhsoo)
				{
					Player.ControllerHelper controllers = P_0.controllers;
					CHuFKljYJmvpAblIkunLKLeSJFu(controllers.Joysticks, P_2, text);
					UWKhKLJyKccwfUcOwUUevzBoQlZ(controllers.CustomControllers, P_2, text);
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Has Mouse", controllers.hasMouse.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Has Keyboard", controllers.hasKeyboard.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Exclude From Controller Auto Assignment", controllers.excludeFromControllerAutoAssignment.ToString());
				}
			}
			string text2 = text + "_controllerMaps";
			using (SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX3 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Controller Maps", text2, P_2))
			{
				if (sxRtYdfyQVQDsfjlazIKPhpUXrX3.BKryQPIIljiORNYFaafBUdnhsoo)
				{
					aPDSsyCctIckmghlDNQqCNqrjEov(ControllerType.Keyboard, P_0.controllers.maps.GetMaps<KeyboardMap>(0), "Keyboard Maps", P_2, text2 + "_keyboard");
					aPDSsyCctIckmghlDNQqCNqrjEov(ControllerType.Mouse, P_0.controllers.maps.GetMaps<MouseMap>(0), "Mouse Maps", P_2, text2 + "_mouse");
					string text3 = text2 + "_joystickMaps";
					using (SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX4 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Joysticks (" + P_0.controllers.joystickCount + ")", text3, P_2))
					{
						if (sxRtYdfyQVQDsfjlazIKPhpUXrX4.BKryQPIIljiORNYFaafBUdnhsoo)
						{
							for (int i = 0; i < P_0.controllers.joystickCount; i++)
							{
								Joystick joystick = P_0.controllers.Joysticks[i];
								IList<JoystickMap> maps = P_0.controllers.maps.GetMaps<JoystickMap>(joystick.id);
								text3 = text3 + "_joystickId" + joystick.id;
								aPDSsyCctIckmghlDNQqCNqrjEov(ControllerType.Joystick, maps, (joystick.name != "Unknown Controller") ? joystick.name : joystick.hardwareName, P_2, text3);
							}
						}
					}
					text3 = text2 + "_customControllerMaps";
					using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX5 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Custom Controllers (" + P_0.controllers.customControllerCount + ")", text3, P_2);
					if (sxRtYdfyQVQDsfjlazIKPhpUXrX5.BKryQPIIljiORNYFaafBUdnhsoo)
					{
						for (int j = 0; j < P_0.controllers.customControllerCount; j++)
						{
							CustomController customController = P_0.controllers.CustomControllers[j];
							IList<CustomControllerMap> maps2 = P_0.controllers.maps.GetMaps<CustomControllerMap>(customController.id);
							text3 = text3 + "_customControllerId" + customController.id;
							aPDSsyCctIckmghlDNQqCNqrjEov(ControllerType.Custom, maps2, customController.name, P_2, text3);
						}
					}
				}
			}
			text2 = text + "_controllerMapLayoutManager";
			using (SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX6 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Layout Manager", text2, P_2))
			{
				if (sxRtYdfyQVQDsfjlazIKPhpUXrX6.BKryQPIIljiORNYFaafBUdnhsoo)
				{
					HLsrbThDnCeZCEGCZdUEilDkKMZ(P_0.controllers.maps.layoutManager, P_2, text2);
				}
			}
			text2 = text + "_controllerMapEnabler";
			using (SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX7 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Map Enabler", text2, P_2))
			{
				if (sxRtYdfyQVQDsfjlazIKPhpUXrX7.BKryQPIIljiORNYFaafBUdnhsoo)
				{
					QdnyoZmVEQAIrnxGazFUsfVkxE(P_0.controllers.maps.mapEnabler, P_2, text2);
				}
			}
			text2 = text + "_inputBehaviors";
			dMIiDLQljwFpGCFLIebrniUAOXD(P_0.controllers.maps.InputBehaviors, P_2, text2);
			text2 = text + "_actions";
			List<InputAction> list = new List<InputAction>(ReInput.mapping.Actions);
			list.Sort((InputAction P_0, InputAction P_1) => P_0.name.CompareTo(P_1.name));
			IList<InputCategory> actionCategories = ReInput.mapping.ActionCategories;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX8 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Actions (" + list.Count + ")", text2, P_2);
			if (!sxRtYdfyQVQDsfjlazIKPhpUXrX8.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				return;
			}
			for (int k = 0; k < actionCategories.Count; k++)
			{
				InputCategory CAcCUmHYOrLQQgZmGHobWsJWSru = actionCategories[k];
				string text4 = text2 + "_actionCat" + CAcCUmHYOrLQQgZmGHobWsJWSru.id;
				int num = ListTools.Count(list, (InputAction P_0) => P_0.categoryId == CAcCUmHYOrLQQgZmGHobWsJWSru.id);
				using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX9 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("id " + CAcCUmHYOrLQQgZmGHobWsJWSru.id + ": " + CAcCUmHYOrLQQgZmGHobWsJWSru.name + " (" + num + ")", text4, P_2);
				if (!sxRtYdfyQVQDsfjlazIKPhpUXrX9.BKryQPIIljiORNYFaafBUdnhsoo)
				{
					continue;
				}
				for (int l = 0; l < list.Count; l++)
				{
					InputAction inputAction = list[l];
					if (inputAction.categoryId != CAcCUmHYOrLQQgZmGHobWsJWSru.id)
					{
						continue;
					}
					string key = text4 + "_actionId" + inputAction.id;
					using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX10 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("id " + inputAction.id + ": " + inputAction.name + ": " + P_0.GetAxis(inputAction.id).ToString("f3"), key, P_2);
					if (sxRtYdfyQVQDsfjlazIKPhpUXrX10.BKryQPIIljiORNYFaafBUdnhsoo)
					{
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Axis Value", P_0.GetAxis(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Axis Raw Value", P_0.GetAxisRaw(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Button Value", P_0.GetButton(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Button Double Press Value", P_0.GetButtonDoublePressHold(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Button Short Press Value", P_0.GetButtonShortPress(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Button Long Press Value", P_0.GetButtonLongPress(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Button Repeating Value", P_0.GetButtonRepeating(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Negative Button Value", P_0.GetNegativeButton(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Negative Button Double Press Value", P_0.GetNegativeButtonDoublePressHold(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Negative Button Short Press Value", P_0.GetNegativeButtonShortPress(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Negative Button Long Press Value", P_0.GetNegativeButtonLongPress(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Negative Button Repeating Value", P_0.GetNegativeButtonRepeating(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Axis Time Active", P_0.GetAxisTimeActive(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Axis Time Inactive", P_0.GetAxisTimeInactive(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Axis Raw Time Active", P_0.GetAxisRawTimeActive(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Axis Raw Time Inactive", P_0.GetAxisRawTimeInactive(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Button Time Pressed", P_0.GetButtonTimePressed(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Button Time Unpressed", P_0.GetButtonTimeUnpressed(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Negative Button Time Pressed", P_0.GetNegativeButtonTimePressed(inputAction.id).ToString());
						DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Negative Button Time Unpressed", P_0.GetNegativeButtonTimeUnpressed(inputAction.id).ToString());
					}
				}
			}
		}

		private static void dMIiDLQljwFpGCFLIebrniUAOXD(IList<InputBehavior> P_0, IDictionary<string, bool> P_1, string P_2)
		{
			int num = P_0?.Count ?? 0;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Input Behaviors (" + num + ")", P_2 + "_inputBehaviors", P_1);
			if (sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				for (int i = 0; i < num; i++)
				{
					InputBehavior inputBehavior = P_0[i];
					lPJPAJUSPXDXDwiENPigncefewKh(inputBehavior, i, P_1, P_2);
				}
			}
		}

		private static void lPJPAJUSPXDXDwiENPigncefewKh(InputBehavior P_0, int P_1, IDictionary<string, bool> P_2, string P_3)
		{
			string key = P_3 + "_inputBehavior" + P_0.id;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX(P_1 + ": " + P_0.name, key, P_2);
			if (sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Id", P_0.id.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Name", P_0.name);
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Digital Axis Gravity", P_0.digitalAxisGravity.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Digital Axis Instant Reverse", P_0.digitalAxisInstantReverse.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Digital Axis Sensitivity", P_0.digitalAxisSensitivity.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Digital Axis Snap", P_0.digitalAxisSnap.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Joystick Axis Sensitivity", P_0.joystickAxisSensitivity.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Custom Controller Axis Sensitivity", P_0.customControllerAxisSensitivity.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Mouse XY Axis Mode", P_0.mouseXYAxisMode.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Mouse XY Axis Sensitivity", P_0.mouseXYAxisSensitivity.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Mouse XY Axis Delta Calc", P_0.mouseXYAxisDeltaCalc.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Mouse Other Axis Mode", P_0.mouseOtherAxisMode.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Mouse Other Axis Sensitivity", P_0.mouseOtherAxisSensitivity.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Button Dead Zone", P_0.buttonDeadZone.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Button Double Press Speed", P_0.buttonDoublePressSpeed.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Button Short Press Time", P_0.buttonShortPressTime.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Button Short Press Expires In", P_0.buttonShortPressExpiresIn.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Button Long Press Time", P_0.buttonLongPressTime.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Button Long Press Expires In", P_0.buttonLongPressExpiresIn.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Button Down Buffer", P_0.buttonDownBuffer.ToString());
			}
		}

		private static void sGpDmDybdpmdmpEgLGbiFFPNqJt(Controller P_0, IDictionary<string, bool> P_1, string P_2)
		{
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Element Identifiers", P_2 + "_elementIdentifiers", P_1);
			if (!sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				return;
			}
			int num;
			if (P_0 is ControllerWithAxes)
			{
				ControllerWithAxes controllerWithAxes = P_0 as ControllerWithAxes;
				num = ((controllerWithAxes.AxisElementIdentifiers != null) ? controllerWithAxes.AxisElementIdentifiers.Count : 0);
				using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX2 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Axis Element Identifiers (" + num + ")", P_2 + "_axisEIs", P_1);
				if (sxRtYdfyQVQDsfjlazIKPhpUXrX2.BKryQPIIljiORNYFaafBUdnhsoo)
				{
					for (int i = 0; i < num; i++)
					{
						ControllerElementIdentifier controllerElementIdentifier = controllerWithAxes.AxisElementIdentifiers[i];
						using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX3 = new SxRtYdfyQVQDsfjlazIKPhpUXrX(i + ": " + controllerElementIdentifier.name + " (id: " + controllerElementIdentifier.id + ")", P_2 + "_AxisEI" + i + "_" + controllerElementIdentifier.name, P_1);
						if (sxRtYdfyQVQDsfjlazIKPhpUXrX3.BKryQPIIljiORNYFaafBUdnhsoo)
						{
							DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Id", controllerElementIdentifier.id.ToString());
							DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Name", controllerElementIdentifier.name);
						}
					}
				}
			}
			if (P_0 == null)
			{
				return;
			}
			num = ((P_0.ButtonElementIdentifiers != null) ? P_0.ButtonElementIdentifiers.Count : 0);
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX4 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Button Element Identifiers (" + num + ")", P_2 + "_buttonEIs", P_1);
			if (!sxRtYdfyQVQDsfjlazIKPhpUXrX4.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				return;
			}
			for (int j = 0; j < num; j++)
			{
				ControllerElementIdentifier controllerElementIdentifier2 = P_0.ButtonElementIdentifiers[j];
				using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX5 = new SxRtYdfyQVQDsfjlazIKPhpUXrX(j + ": " + controllerElementIdentifier2.name + " (id: " + controllerElementIdentifier2.id + ")", P_2 + "_ButtonEI" + j + "_" + controllerElementIdentifier2.name, P_1);
				if (sxRtYdfyQVQDsfjlazIKPhpUXrX5.BKryQPIIljiORNYFaafBUdnhsoo)
				{
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Id", controllerElementIdentifier2.id.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Name", controllerElementIdentifier2.name);
				}
			}
		}

		private static void QCdOurMUdAkDsJTeltKshcmIUGR(IList<Controller.Button> P_0, ControllerType P_1, IDictionary<string, bool> P_2, string P_3)
		{
			string text = ((P_1 == ControllerType.Keyboard) ? "Key" : "Button");
			int num = P_0?.Count ?? 0;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX(text + "s (" + num + ")", P_3 + "_Buttons", P_2);
			if (!sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				return;
			}
			for (int i = 0; i < num; i++)
			{
				Controller.Button button = P_0[i];
				using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX2 = new SxRtYdfyQVQDsfjlazIKPhpUXrX(i + ": " + ((P_1 == ControllerType.Keyboard) ? (Keyboard.GetKeyboardKeyCodeByButtonIndex(i).ToString() + " (" + Keyboard.GetKeyName((KeyCode)Keyboard.GetKeyboardKeyCodeByButtonIndex(i)) + ")") : button.elementIdentifier.name) + ": " + (button.value ? "Pressed" : "") + " (" + button.pressure.ToString("f3") + ")", P_3 + "_" + button.name, P_2);
				if (sxRtYdfyQVQDsfjlazIKPhpUXrX2.BKryQPIIljiORNYFaafBUdnhsoo)
				{
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Is Member Element", button.isMemberElement.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Is Pressure Sensitive", button.isPressureSensitive.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value", button.value.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value Prev", button.valuePrev.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Pressure", button.pressure.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Pressure Prev", button.pressurePrev.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Just Pressed", button.justPressed.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Just Released", button.justReleased.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Just Double Pressed", button.justDoublePressed.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Double Pressed And Held", button.doublePressedAndHeld.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Time Pressed", button.timePressed.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Time Unpressed", button.timeUnpressed.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Last Time Pressed", button.lastTimePressed.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Last Time Unpressed", button.lastTimeUnpressed.ToString());
				}
			}
		}

		private static void IlRegUQwyQZsXcPuVwgnWaksBkF(IList<Controller.Axis> P_0, IDictionary<string, bool> P_1, string P_2)
		{
			int num = P_0?.Count ?? 0;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Axes (" + num + ")", P_2 + "_Axes", P_1);
			if (!sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				return;
			}
			for (int i = 0; i < num; i++)
			{
				Controller.Axis axis = P_0[i];
				using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX2 = new SxRtYdfyQVQDsfjlazIKPhpUXrX(i + ": " + axis.elementIdentifier.name + ": " + axis.value.ToString("f3") + " (" + axis.valueRaw.ToString("f3") + ")", P_2 + "_" + axis.name, P_1);
				if (sxRtYdfyQVQDsfjlazIKPhpUXrX2.BKryQPIIljiORNYFaafBUdnhsoo)
				{
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Is Member Element", axis.isMemberElement.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value", axis.value.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value Raw", axis.valueRaw.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value Prev", axis.valuePrev.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value Raw Prev", axis.valueRawPrev.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value Delta", axis.valueDelta.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value Delta Raw", axis.valueDeltaRaw.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Time Active", axis.timeActive.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Time Active Raw", axis.timeActiveRaw.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Time Inactive", axis.timeInactive.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Time Inactive Raw", axis.timeInactiveRaw.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Last Time Active", axis.lastTimeActive.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Last Time Active Raw", axis.lastTimeActiveRaw.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Last Time Inactive", axis.lastTimeInactive.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Last Time Inactive Raw", axis.lastTimeInactiveRaw.ToString());
				}
			}
		}

		private static void aPDSsyCctIckmghlDNQqCNqrjEov<T>(ControllerType P_0, IList<T> P_1, string P_2, IDictionary<string, bool> P_3, string P_4) where T : ControllerMap
		{
			string text = P_4 + "_controllerMaps";
			int num = P_1?.Count ?? 0;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX(P_2 + " (" + num + ")", text, P_3);
			if (!sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				return;
			}
			for (int i = 0; i < num; i++)
			{
				T val = P_1[i];
				string text2 = (val.enabled ? "Enabled" : "Disabled");
				ReInput.MappingHelper mapping = ReInput.mapping;
				T val2 = P_1[i];
				InputMapCategory mapCategory = mapping.GetMapCategory(val2.categoryId);
				ReInput.MappingHelper mapping2 = ReInput.mapping;
				T val3 = P_1[i];
				InputLayout layout = mapping2.GetLayout(P_0, val3.layoutId);
				string text3 = ((mapCategory != null) ? mapCategory.name : "n/a");
				string text4 = ((layout != null) ? layout.name : "n/a");
				using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX2 = new SxRtYdfyQVQDsfjlazIKPhpUXrX(i + ": " + text3 + ", " + text4 + ": " + text2, P_4 + "_index" + i, P_3);
				if (sxRtYdfyQVQDsfjlazIKPhpUXrX2.BKryQPIIljiORNYFaafBUdnhsoo)
				{
					if (P_1[i] is ControllerMapWithAxes)
					{
						nXrUdgKgYDjyfkozIyqHNTmclWL(P_1[i] as ControllerMapWithAxes, P_3, text + i);
					}
					else
					{
						nXrUdgKgYDjyfkozIyqHNTmclWL(P_1[i], P_3, text + i);
					}
				}
			}
		}

		private static void nXrUdgKgYDjyfkozIyqHNTmclWL(ControllerMap P_0, IDictionary<string, bool> P_1, string P_2)
		{
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Id (unique id)", P_0.id.ToString());
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Source Map Id", P_0.sourceMapId.ToString());
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Enabled", P_0.enabled.ToString());
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Controller Type", P_0.controllerType.ToString());
			if (P_0.controllerType == ControllerType.Joystick || P_0.controllerType == ControllerType.Custom)
			{
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Controller Id", P_0.controllerId.ToString());
			}
			string text = P_0.categoryId.ToString();
			if (P_0.categoryId >= 0)
			{
				try
				{
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(P_0.categoryId);
					if (mapCategory != null)
					{
						text = text + " (" + mapCategory.name + ")";
					}
				}
				catch
				{
				}
			}
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Category Id", text);
			string text2 = P_0.layoutId.ToString();
			if (P_0.layoutId >= 0)
			{
				try
				{
					InputLayout layout = ReInput.mapping.GetLayout(P_0.controllerType, P_0.layoutId);
					if (layout != null)
					{
						text2 = text2 + " (" + layout.name + ")";
					}
				}
				catch
				{
				}
			}
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Layout Id", text2);
			int buttonMapCount = P_0.buttonMapCount;
			string text3 = P_2 + "_buttonMaps";
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Button Maps (" + buttonMapCount + ")", text3, P_1);
			if (sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				for (int i = 0; i < buttonMapCount; i++)
				{
					mTHcIDQzNYyWYagpLJRtxPdvovq(P_0.controllerType, P_0.ButtonMaps[i], i, P_1, text3 + i);
				}
			}
		}

		private static void nXrUdgKgYDjyfkozIyqHNTmclWL(ControllerMapWithAxes P_0, IDictionary<string, bool> P_1, string P_2)
		{
			nXrUdgKgYDjyfkozIyqHNTmclWL((ControllerMap)P_0, P_1, P_2);
			string text = P_2 + "_axisMaps";
			int axisMapCount = P_0.axisMapCount;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Axis Maps (" + axisMapCount + ")", text, P_1);
			if (sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				for (int i = 0; i < axisMapCount; i++)
				{
					mTHcIDQzNYyWYagpLJRtxPdvovq(P_0.controllerType, P_0.AxisMaps[i], i, P_1, text + i);
				}
			}
		}

		private static void mTHcIDQzNYyWYagpLJRtxPdvovq(ControllerType P_0, ActionElementMap P_1, int P_2, IDictionary<string, bool> P_3, string P_4)
		{
			string text = "Action Element Map";
			InputAction action = ReInput.mapping.GetAction(P_1.actionId);
			string text2 = ((action != null) ? action.name : string.Empty);
			string text3 = cepNezLCIShuXiQNSUiCDBBrEGs(P_1);
			if (!string.IsNullOrEmpty(text3))
			{
				text = P_1.elementIdentifierName + " (" + text3 + ")";
			}
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX(P_2 + ": " + text, P_4 + "_" + P_2, P_3);
			if (!sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				return;
			}
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Id (unique id)", P_1.id.ToString());
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Enabled", P_1.enabled.ToString());
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Element Type", P_1.elementType.ToString());
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Action Id", P_1.actionId + " " + ((action != null) ? ("(" + text2 + ")") : ""));
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Element Identifier Id", P_1.elementIdentifierId.ToString());
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Element Identifier Name", P_1.elementIdentifierName);
			if (P_1.elementType == ControllerElementType.Axis)
			{
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Element Index", P_1.elementIndex.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Axis Range", P_1.axisRange.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Axis Type", P_1.axisType.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Invert", P_1.invert.ToString());
			}
			else if (P_1.elementType == ControllerElementType.Button)
			{
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Element Index", P_1.elementIndex.ToString());
				if (P_0 == ControllerType.Keyboard)
				{
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Key Code", P_1.keyCode.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Keyboard Key Code", P_1.keyboardKeyCode.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Has Modifiers", P_1.hasModifiers.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Modifier Key 1", P_1.modifierKey1.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Modifier Key 2", P_1.modifierKey2.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Modifier Key 3", P_1.modifierKey3.ToString());
				}
			}
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Axis Contribution", P_1.axisContribution.ToString());
		}

		private static string cepNezLCIShuXiQNSUiCDBBrEGs(ActionElementMap P_0)
		{
			InputAction action = ReInput.mapping.GetAction(P_0.actionId);
			if (action == null)
			{
				return string.Empty;
			}
			string text = string.Empty;
			if (P_0.elementType == ControllerElementType.Button || (P_0.elementType == ControllerElementType.Axis && P_0.axisType == AxisType.Split))
			{
				if (P_0.axisContribution == Pole.Positive)
				{
					text = action.positiveDescriptiveName;
					if (string.IsNullOrEmpty(text))
					{
						text = ((!string.IsNullOrEmpty(action.descriptiveName)) ? (action.descriptiveName + " +") : (action.name + " +"));
					}
				}
				else
				{
					text = action.negativeDescriptiveName;
					if (string.IsNullOrEmpty(text))
					{
						text = ((!string.IsNullOrEmpty(action.descriptiveName)) ? (action.descriptiveName + " -") : (action.name + " -"));
					}
				}
			}
			else if (P_0.elementType == ControllerElementType.Axis && P_0.axisType == AxisType.Normal)
			{
				text = ((!string.IsNullOrEmpty(action.descriptiveName)) ? action.descriptiveName : action.name);
			}
			return text;
		}

		private static void HLsrbThDnCeZCEGCZdUEilDkKMZ(ControllerMapLayoutManager P_0, IDictionary<string, bool> P_1, string P_2)
		{
			if (sRChMhLEinpJeatjXPHLKnLYdbv("Enabled", P_0.enabled))
			{
				P_0.enabled = !P_0.enabled;
			}
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Load from User Data Store", P_0.loadFromUserDataStore.ToString());
			string text = P_2 + "_ruleSets";
			int count = P_0.ruleSets.Count;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Rule Sets (" + count + ")", text, P_1);
			if (sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				for (int i = 0; i < count; i++)
				{
					PQkmlgwjUFWIJupsAaGtXqwhdRN(P_0.ruleSets[i], i, P_1, text + i);
				}
			}
		}

		private static void PQkmlgwjUFWIJupsAaGtXqwhdRN(ControllerMapLayoutManager.RuleSet P_0, int P_1, IDictionary<string, bool> P_2, string P_3)
		{
			int num = P_0?.Count ?? 0;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX(P_1 + ": " + ((!string.IsNullOrEmpty(P_0.tag)) ? (P_0.tag + ", ") : "") + (P_0.enabled ? "Enabled" : "Disabled"), P_3, P_2);
			if (!sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				return;
			}
			if (sRChMhLEinpJeatjXPHLKnLYdbv("Enabled", P_0.enabled))
			{
				P_0.enabled = !P_0.enabled;
			}
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Tag", P_0.tag);
			string text = P_3 + "_rules";
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX2 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Rules (" + P_0.Count + ")", text, P_2);
			if (!sxRtYdfyQVQDsfjlazIKPhpUXrX2.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				return;
			}
			for (int i = 0; i < num; i++)
			{
				ControllerMapLayoutManager.Rule rule = P_0[i];
				string text2 = text + i;
				using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX3 = new SxRtYdfyQVQDsfjlazIKPhpUXrX(i + ": " + ((!string.IsNullOrEmpty(rule.tag)) ? rule.tag : ""), text2, P_2);
				if (!sxRtYdfyQVQDsfjlazIKPhpUXrX3.BKryQPIIljiORNYFaafBUdnhsoo)
				{
					continue;
				}
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Tag", rule.tag);
				ZHJPxFAvMCMAonwABbxZJpOjUUz(rule.controllerSetSelector, P_2, text2);
				int[] categoryIds = rule.categoryIds;
				int num2 = ((categoryIds != null) ? categoryIds.Length : 0);
				using (SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX4 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Map Categories (" + num2 + ")", text2 + "_categoryIds", P_2))
				{
					if (sxRtYdfyQVQDsfjlazIKPhpUXrX4.BKryQPIIljiORNYFaafBUdnhsoo)
					{
						if (num2 == 0)
						{
							DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Category", "All Map Categories");
						}
						else
						{
							for (int j = 0; j < categoryIds.Length; j++)
							{
								InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(categoryIds[j]);
								string text3 = ((mapCategory != null) ? (mapCategory.name + " (" + mapCategory.id + ")") : "[INVALID]");
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Category " + j, text3);
							}
						}
					}
				}
				InputLayout layout = ReInput.mapping.GetLayout(rule.controllerSetSelector.controllerType, rule.layoutId);
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj(rule.controllerSetSelector.controllerType.ToString() + " Layout", (layout != null) ? (layout.name + " (" + layout.id + ")") : "[INVALID]");
			}
		}

		private static void QdnyoZmVEQAIrnxGazFUsfVkxE(ControllerMapEnabler P_0, IDictionary<string, bool> P_1, string P_2)
		{
			if (sRChMhLEinpJeatjXPHLKnLYdbv("Enabled", P_0.enabled))
			{
				P_0.enabled = !P_0.enabled;
			}
			string text = P_2 + "_ruleSets";
			int count = P_0.ruleSets.Count;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Rule Sets (" + count + ")", text, P_1);
			if (sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				for (int i = 0; i < count; i++)
				{
					sKHJYXRFhhWsTxZalLwnQVOKgPC(P_0.ruleSets[i], i, P_1, text + i);
				}
			}
		}

		private static void sKHJYXRFhhWsTxZalLwnQVOKgPC(ControllerMapEnabler.RuleSet P_0, int P_1, IDictionary<string, bool> P_2, string P_3)
		{
			int num = P_0?.Count ?? 0;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX(P_1 + ": " + ((!string.IsNullOrEmpty(P_0.tag)) ? (P_0.tag + ", ") : "") + (P_0.enabled ? "Enabled" : "Disabled"), P_3, P_2);
			if (!sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				return;
			}
			if (sRChMhLEinpJeatjXPHLKnLYdbv("Enabled", P_0.enabled))
			{
				P_0.enabled = !P_0.enabled;
			}
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Tag", P_0.tag);
			string text = P_3 + "_rules";
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX2 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Rules (" + P_0.Count + ")", text, P_2);
			if (!sxRtYdfyQVQDsfjlazIKPhpUXrX2.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				return;
			}
			for (int i = 0; i < num; i++)
			{
				ControllerMapEnabler.Rule rule = P_0[i];
				string text2 = text + i;
				using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX3 = new SxRtYdfyQVQDsfjlazIKPhpUXrX(i + ": " + ((!string.IsNullOrEmpty(rule.tag)) ? rule.tag : ""), text2, P_2);
				if (!sxRtYdfyQVQDsfjlazIKPhpUXrX3.BKryQPIIljiORNYFaafBUdnhsoo)
				{
					continue;
				}
				if (sRChMhLEinpJeatjXPHLKnLYdbv("Enable", rule.enable))
				{
					rule.enable = !rule.enable;
				}
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Tag", rule.tag);
				ZHJPxFAvMCMAonwABbxZJpOjUUz(rule.controllerSetSelector, P_2, text2);
				int[] categoryIds = rule.categoryIds;
				int num2 = ((categoryIds != null) ? categoryIds.Length : 0);
				using (SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX4 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Map Categories (" + num2 + ")", text2 + "_categoryIds", P_2))
				{
					if (sxRtYdfyQVQDsfjlazIKPhpUXrX4.BKryQPIIljiORNYFaafBUdnhsoo)
					{
						if (num2 == 0)
						{
							DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Category", "All Map Categories");
						}
						else
						{
							for (int j = 0; j < categoryIds.Length; j++)
							{
								InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(categoryIds[j]);
								string text3 = ((mapCategory != null) ? (mapCategory.name + " (" + mapCategory.id + ")") : "[INVALID]");
								DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Category " + j, text3);
							}
						}
					}
				}
				int[] layoutIds = rule.layoutIds;
				int num3 = ((layoutIds != null) ? layoutIds.Length : 0);
				using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX5 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Layouts (" + num3 + ")", text2 + "_layoutIds", P_2);
				if (!sxRtYdfyQVQDsfjlazIKPhpUXrX5.BKryQPIIljiORNYFaafBUdnhsoo)
				{
					continue;
				}
				if (num3 == 0)
				{
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Layout", (rule.controllerSetSelector.type == ControllerSetSelector.Type.All) ? "All Layouts" : string.Concat("All ", rule.controllerSetSelector.controllerType, " Layouts"));
					continue;
				}
				for (int k = 0; k < layoutIds.Length; k++)
				{
					InputLayout layout = ReInput.mapping.GetLayout(rule.controllerSetSelector.controllerType, layoutIds[k]);
					string text4 = ((layout != null) ? (layout.name + " (" + layout.id + ")") : "[INVALID]");
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj(string.Concat(rule.controllerSetSelector.controllerType, " Layout ", k.ToString()), text4);
				}
			}
		}

		private static void ZHJPxFAvMCMAonwABbxZJpOjUUz(ControllerSetSelector P_0, IDictionary<string, bool> P_1, string P_2)
		{
			string key = P_2 + "_controllerSetSelector";
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Controller Set Selector", key, P_1);
			if (sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Type", StringTools.AddSpacesToSentence(P_0.type.ToString(), preserveAcronyms: false));
				if (P_0.type != 0)
				{
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Controller Type", P_0.controllerType.ToString());
				}
				if (P_0.type == ControllerSetSelector.Type.HardwareType)
				{
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Hardware Type Guid", P_0.hardwareTypeGuid.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Hardware Identifier", P_0.hardwareIdentifier);
				}
				if (P_0.type == ControllerSetSelector.Type.ControllerTemplateType)
				{
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Controller Template Type Guid", P_0.controllerTemplateTypeGuid.ToString());
				}
				if (P_0.type == ControllerSetSelector.Type.PersistentControllerInstance)
				{
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Device Instance Guid", P_0.deviceInstanceGuid.ToString());
				}
				if (P_0.type == ControllerSetSelector.Type.SessionControllerInstance)
				{
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Controller Id", P_0.controllerId.ToString());
				}
			}
		}

		private static void FYCowjTfNBSPAbMkCfQPIqYudKm(Controller P_0, IDictionary<string, bool> P_1, string P_2)
		{
			P_2 += "_templates";
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Templates (" + P_0.templateCount + ")", P_2, P_1);
			if (sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				for (int i = 0; i < P_0.templateCount; i++)
				{
					LnAHRMyePnwjkFlTdzMJtFlhwbn(P_0.Templates[i], i, P_2, P_1);
				}
			}
		}

		private static void LnAHRMyePnwjkFlTdzMJtFlhwbn(IControllerTemplate P_0, int P_1, string P_2, IDictionary<string, bool> P_3)
		{
			P_2 += ((P_1 >= 0) ? ("_" + P_1) : "");
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX(((P_1 >= 0) ? (P_1 + ": ") : "") + P_0.name, P_2, P_3);
			if (!sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				return;
			}
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Type GUID", P_0.typeGuid.ToString());
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Class Type", P_0.GetType().ToString());
			P_2 += "_elements";
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX2 = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Elements (" + P_0.elementCount + ")", P_2, P_3);
			if (sxRtYdfyQVQDsfjlazIKPhpUXrX2.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				for (int i = 0; i < P_0.elementCount; i++)
				{
					KYIymCeEctFCDUmYZcIlqowGrOQ(P_0.elements[i], i, P_2, P_3);
				}
			}
		}

		private static void KYIymCeEctFCDUmYZcIlqowGrOQ(IControllerTemplateElement P_0, int P_1, string P_2, IDictionary<string, bool> P_3)
		{
			P_2 += ((P_1 >= 0) ? ("_" + P_1) : "");
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX(((P_1 >= 0) ? ": " : "") + P_0.descriptiveName + " (id: " + P_0.id + ")", P_2, P_3);
			if (sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Id", P_0.id.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Name", P_0.descriptiveName.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Type", P_0.type.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Exists", P_0.exists.ToString());
				if (P_0.type == ControllerTemplateElementType.Button)
				{
					IControllerTemplateButton controllerTemplateButton = P_0 as IControllerTemplateButton;
					JXbrRaLolBAhVJYygvcAguJqema(controllerTemplateButton, P_2, P_3);
				}
				else if (P_0.type == ControllerTemplateElementType.Axis)
				{
					IControllerTemplateAxis controllerTemplateAxis = P_0 as IControllerTemplateAxis;
					SrMDRxCifjiTETYVmPoVuteIThld(controllerTemplateAxis, P_2, P_3);
				}
				else if (P_0.type == ControllerTemplateElementType.DPad)
				{
					IControllerTemplateDPad controllerTemplateDPad = P_0 as IControllerTemplateDPad;
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value", controllerTemplateDPad.value.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value Prev", controllerTemplateDPad.valuePrev.ToString());
					fjBvsHkCADPYnAYYMesVUbCvUQZ(controllerTemplateDPad.up, "Up", P_2, P_3);
					fjBvsHkCADPYnAYYMesVUbCvUQZ(controllerTemplateDPad.right, "Right", P_2, P_3);
					fjBvsHkCADPYnAYYMesVUbCvUQZ(controllerTemplateDPad.down, "Down", P_2, P_3);
					fjBvsHkCADPYnAYYMesVUbCvUQZ(controllerTemplateDPad.left, "Left", P_2, P_3);
				}
				else if (P_0.type == ControllerTemplateElementType.Hat)
				{
					IControllerTemplateHat controllerTemplateHat = P_0 as IControllerTemplateHat;
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value", controllerTemplateHat.value.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value Prev", controllerTemplateHat.valuePrev.ToString());
					fjBvsHkCADPYnAYYMesVUbCvUQZ(controllerTemplateHat.up, "up", P_2, P_3);
					fjBvsHkCADPYnAYYMesVUbCvUQZ(controllerTemplateHat.upRight, "upRight", P_2, P_3);
					fjBvsHkCADPYnAYYMesVUbCvUQZ(controllerTemplateHat.right, "right", P_2, P_3);
					fjBvsHkCADPYnAYYMesVUbCvUQZ(controllerTemplateHat.downRight, "downRight", P_2, P_3);
					fjBvsHkCADPYnAYYMesVUbCvUQZ(controllerTemplateHat.down, "down", P_2, P_3);
					fjBvsHkCADPYnAYYMesVUbCvUQZ(controllerTemplateHat.downLeft, "downLeft", P_2, P_3);
					fjBvsHkCADPYnAYYMesVUbCvUQZ(controllerTemplateHat.left, "left", P_2, P_3);
					fjBvsHkCADPYnAYYMesVUbCvUQZ(controllerTemplateHat.upLeft, "upLeft", P_2, P_3);
				}
				else if (P_0.type == ControllerTemplateElementType.Stick)
				{
					IControllerTemplateStick controllerTemplateStick = P_0 as IControllerTemplateStick;
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value", controllerTemplateStick.value.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value Prev", controllerTemplateStick.valuePrev.ToString());
					BGfdsAdyNlOVwtOYCxBtUfRHtVkk(controllerTemplateStick.horizontal, "horizontal", P_2, P_3);
					BGfdsAdyNlOVwtOYCxBtUfRHtVkk(controllerTemplateStick.vertical, "vertical", P_2, P_3);
					BGfdsAdyNlOVwtOYCxBtUfRHtVkk(controllerTemplateStick.rotation, "rotation", P_2, P_3);
				}
				else if (P_0.type == ControllerTemplateElementType.Throttle)
				{
					IControllerTemplateThrottle controllerTemplateThrottle = P_0 as IControllerTemplateThrottle;
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value", controllerTemplateThrottle.value.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value Prev", controllerTemplateThrottle.valuePrev.ToString());
					BGfdsAdyNlOVwtOYCxBtUfRHtVkk(controllerTemplateThrottle.throttle, "throttle", P_2, P_3);
					fjBvsHkCADPYnAYYMesVUbCvUQZ(controllerTemplateThrottle.minDetent, "zeroDetent", P_2, P_3);
				}
				else if (P_0.type == ControllerTemplateElementType.ThumbStick)
				{
					IControllerTemplateThumbStick controllerTemplateThumbStick = P_0 as IControllerTemplateThumbStick;
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value", controllerTemplateThumbStick.value.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value Prev", controllerTemplateThumbStick.valuePrev.ToString());
					BGfdsAdyNlOVwtOYCxBtUfRHtVkk(controllerTemplateThumbStick.horizontal, "horizontal", P_2, P_3);
					BGfdsAdyNlOVwtOYCxBtUfRHtVkk(controllerTemplateThumbStick.vertical, "vertical", P_2, P_3);
					fjBvsHkCADPYnAYYMesVUbCvUQZ(controllerTemplateThumbStick.press, "press", P_2, P_3);
				}
				else if (P_0.type == ControllerTemplateElementType.Yoke)
				{
					IControllerTemplateYoke controllerTemplateYoke = P_0 as IControllerTemplateYoke;
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value", controllerTemplateYoke.value.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value Prev", controllerTemplateYoke.valuePrev.ToString());
					BGfdsAdyNlOVwtOYCxBtUfRHtVkk(controllerTemplateYoke.rotation, "rotation", P_2, P_3);
					BGfdsAdyNlOVwtOYCxBtUfRHtVkk(controllerTemplateYoke.pushPull, "pushPull", P_2, P_3);
				}
				else if (P_0.type == ControllerTemplateElementType.Stick6D)
				{
					IControllerTemplateStick6D controllerTemplateStick6D = P_0 as IControllerTemplateStick6D;
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Position", controllerTemplateStick6D.position.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Position Prev", controllerTemplateStick6D.positionPrev.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Rotation", controllerTemplateStick6D.rotation.ToString());
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Rotation Prev", controllerTemplateStick6D.rotationPrev.ToString());
					BGfdsAdyNlOVwtOYCxBtUfRHtVkk(controllerTemplateStick6D.positionX, "PositionX", P_2, P_3);
					BGfdsAdyNlOVwtOYCxBtUfRHtVkk(controllerTemplateStick6D.positionY, "PositionY", P_2, P_3);
					BGfdsAdyNlOVwtOYCxBtUfRHtVkk(controllerTemplateStick6D.positionZ, "PositionZ", P_2, P_3);
					BGfdsAdyNlOVwtOYCxBtUfRHtVkk(controllerTemplateStick6D.rotationX, "RotationX", P_2, P_3);
					BGfdsAdyNlOVwtOYCxBtUfRHtVkk(controllerTemplateStick6D.rotationY, "RotationY", P_2, P_3);
					BGfdsAdyNlOVwtOYCxBtUfRHtVkk(controllerTemplateStick6D.rotationZ, "RotationZ", P_2, P_3);
				}
				else
				{
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Unknown element type", P_0.type.ToString());
				}
			}
		}

		private static void BGfdsAdyNlOVwtOYCxBtUfRHtVkk(IControllerTemplateAxis P_0, string P_1, string P_2, IDictionary<string, bool> P_3)
		{
			P_2 = P_2 + "_" + P_1;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX(StringTools.VariableNameToDisplayName(P_1), P_2, P_3);
			if (sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				SrMDRxCifjiTETYVmPoVuteIThld(P_0, P_2, P_3);
			}
		}

		private static void fjBvsHkCADPYnAYYMesVUbCvUQZ(IControllerTemplateButton P_0, string P_1, string P_2, IDictionary<string, bool> P_3)
		{
			P_2 = P_2 + "_" + P_1;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX(StringTools.VariableNameToDisplayName(P_1), P_2, P_3);
			if (sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				JXbrRaLolBAhVJYygvcAguJqema(P_0, P_2, P_3);
			}
		}

		private static void SrMDRxCifjiTETYVmPoVuteIThld(IControllerTemplateAxis P_0, string P_1, IDictionary<string, bool> P_2)
		{
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value", P_0.value.ToString());
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value Prev", P_0.valuePrev.ToString());
			MJwWconPwyAIkzSbKonPJINqBvU(P_0.source, "target", P_1, P_2);
		}

		private static void JXbrRaLolBAhVJYygvcAguJqema(IControllerTemplateButton P_0, string P_1, IDictionary<string, bool> P_2)
		{
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value", P_0.value.ToString());
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Value Prev", P_0.valuePrev.ToString());
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Pressure", P_0.pressure.ToString());
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Pressure Prev", P_0.pressurePrev.ToString());
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Just Pressed", P_0.justPressed.ToString());
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Just Released", P_0.justReleased.ToString());
			ukYeOBTfWpeWXEOMfcryCYxZHQO(P_0.source, "target", P_1, P_2);
		}

		private static void MJwWconPwyAIkzSbKonPJINqBvU(IControllerTemplateAxisSource P_0, string P_1, string P_2, IDictionary<string, bool> P_3)
		{
			P_2 = P_2 + "_" + P_1;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX("Axis Target", P_2, P_3);
			if (sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Split Axis", P_0.splitAxis.ToString());
				iVkQYsTuOhnYKaWZBdLCwqphRJg(P_0.fullTarget, "target", P_2, P_3);
				iVkQYsTuOhnYKaWZBdLCwqphRJg(P_0.positiveTarget, "positiveTarget", P_2, P_3);
				iVkQYsTuOhnYKaWZBdLCwqphRJg(P_0.negativeTarget, "negativeTarget", P_2, P_3);
			}
		}

		private static void ukYeOBTfWpeWXEOMfcryCYxZHQO(IControllerTemplateButtonSource P_0, string P_1, string P_2, IDictionary<string, bool> P_3)
		{
			P_2 = P_2 + "_" + P_1;
			iVkQYsTuOhnYKaWZBdLCwqphRJg(P_0.target, "target", P_2, P_3);
		}

		private static void iVkQYsTuOhnYKaWZBdLCwqphRJg(IControllerElementTarget P_0, string P_1, string P_2, IDictionary<string, bool> P_3)
		{
			P_2 = P_2 + "_" + P_1;
			using SxRtYdfyQVQDsfjlazIKPhpUXrX sxRtYdfyQVQDsfjlazIKPhpUXrX = new SxRtYdfyQVQDsfjlazIKPhpUXrX(StringTools.VariableNameToDisplayName(P_1), P_2, P_3);
			if (sxRtYdfyQVQDsfjlazIKPhpUXrX.BKryQPIIljiORNYFaafBUdnhsoo)
			{
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Element Identifier Id", P_0.elementIdentifierId.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Axis Range", P_0.axisRange.ToString());
				DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Has Target", P_0.hasTarget.ToString());
				if (P_0.hasTarget)
				{
					DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj("Target Element", P_0.descriptiveName);
				}
			}
		}

		private static bool sRChMhLEinpJeatjXPHLKnLYdbv(string P_0, bool P_1)
		{
			DJMGXyDsfrcGEVSAeoJzPTarblfn.lEDaazWgUfQwtchdTEzSafsbkoj(P_0, P_1.ToString());
			return false;
		}

		private static GUIStyle mYeJYgYBBZOufalmWnViPpLofEs()
		{
			GUIStyle gUIStyle = new GUIStyle(GUI.skin.label);
			gUIStyle.margin.top = 1;
			gUIStyle.margin.bottom = 1;
			gUIStyle.fontSize = GclIwrgVrnJKTEKbDVzknvtphRgP._fontSize;
			return fvUpfzmNxxdPNdJAFfUpljUeAzsd(gUIStyle);
		}

		public static GUIStyle GetToggleStyle()
		{
			GUIStyle gUIStyle = new GUIStyle(GUI.skin.toggle);
			gUIStyle.margin.top = 0;
			gUIStyle.margin.bottom = 0;
			gUIStyle = fvUpfzmNxxdPNdJAFfUpljUeAzsd(gUIStyle);
			gUIStyle.fontSize = GclIwrgVrnJKTEKbDVzknvtphRgP._fontSize;
			return gUIStyle;
		}

		private static GUIStyle fvUpfzmNxxdPNdJAFfUpljUeAzsd(GUIStyle P_0)
		{
			P_0 = new GUIStyle(P_0);
			P_0.margin.left = CPEsXtCPTTATILowlgngzjTVeuL.uYwprRUnAAXzkmKHKbIjwTqZjlr * 20;
			return P_0;
		}

		[CompilerGenerated]
		private static int GgIZqAtEyMWDqAgLjMOyGKIOJgg(InputAction P_0, InputAction P_1)
		{
			return P_0.name.CompareTo(P_1.name);
		}
	}
}
