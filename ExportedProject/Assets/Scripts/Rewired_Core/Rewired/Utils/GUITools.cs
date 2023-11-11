using System;
using System.Collections.Generic;
using UnityEngine;

namespace Rewired.Utils
{
	public static class GUITools
	{
		public static class Solid
		{
			private static bool gopdXXXoXoDvBeCZBnmfuHyipmz = false;

			private static Texture2D skGnPuDghAwTcSgsUIxmxPGSoIV;

			private static Color oFiqPeEvpPlBNgMzvAKuAfihVIC;

			public static Color color
			{
				get
				{
					return GUI.color;
				}
				set
				{
					GUI.color = value;
				}
			}

			public static float colorR
			{
				get
				{
					return GUI.color.r;
				}
				set
				{
					Color color = GUI.color;
					color.r = value;
					Solid.color = color;
				}
			}

			public static float colorG
			{
				get
				{
					return GUI.color.g;
				}
				set
				{
					Color color = GUI.color;
					color.g = value;
					Solid.color = color;
				}
			}

			public static float colorB
			{
				get
				{
					return GUI.color.b;
				}
				set
				{
					Color color = GUI.color;
					color.b = value;
					Solid.color = color;
				}
			}

			public static float colorA
			{
				get
				{
					return GUI.color.a;
				}
				set
				{
					Color color = GUI.color;
					color.a = value;
					Solid.color = color;
				}
			}

			public static void Draw(Rect rect)
			{
				if (skGnPuDghAwTcSgsUIxmxPGSoIV == null)
				{
					skGnPuDghAwTcSgsUIxmxPGSoIV = new Texture2D(1, 1);
					skGnPuDghAwTcSgsUIxmxPGSoIV.SetPixel(0, 0, Color.white);
					skGnPuDghAwTcSgsUIxmxPGSoIV.Apply();
					skGnPuDghAwTcSgsUIxmxPGSoIV.hideFlags = HideFlags.DontSave;
				}
				GUI.DrawTexture(rect, skGnPuDghAwTcSgsUIxmxPGSoIV, ScaleMode.StretchToFill);
			}

			public static void Draw(Rect rect, Color color)
			{
				if (gopdXXXoXoDvBeCZBnmfuHyipmz)
				{
					Solid.color = color;
					Draw(rect);
					return;
				}
				BeginDrawSet();
				Solid.color = color;
				Draw(rect);
				EndDrawSet();
			}

			public static void DrawRotated(Rect rect, float rotation)
			{
				bool flag = rotation != 0f;
				Matrix4x4 matrix = GUI.matrix;
				if (flag)
				{
					GUIUtility.RotateAroundPivot(360f - rotation, rect.center);
				}
				Draw(rect);
				if (flag)
				{
					GUI.matrix = matrix;
				}
			}

			public static void DrawRotated(Rect rect, Color color, float rotation)
			{
				bool flag = rotation != 0f;
				Matrix4x4 matrix = GUI.matrix;
				if (flag)
				{
					GUIUtility.RotateAroundPivot(360f - rotation, rect.center);
				}
				Draw(rect, color);
				if (flag)
				{
					GUI.matrix = matrix;
				}
			}

			public static Texture2D DrawToTexture(Rect rect)
			{
				Texture2D texture2D = new Texture2D(1, 1);
				texture2D.SetPixel(0, 0, Color.white);
				texture2D.Resize((int)rect.width, (int)rect.height);
				texture2D.Apply();
				texture2D.hideFlags = HideFlags.DontSave;
				return texture2D;
			}

			public static void BeginDrawSet()
			{
				gopdXXXoXoDvBeCZBnmfuHyipmz = true;
				oFiqPeEvpPlBNgMzvAKuAfihVIC = GUI.color;
			}

			public static void EndDrawSet()
			{
				gopdXXXoXoDvBeCZBnmfuHyipmz = false;
				GUI.color = oFiqPeEvpPlBNgMzvAKuAfihVIC;
			}

			public static void DrawBox(Rect rect, Color color, float lineWidth = 1f)
			{
				if (gopdXXXoXoDvBeCZBnmfuHyipmz)
				{
					Solid.color = color;
					DrawBox(rect, lineWidth);
					return;
				}
				BeginDrawSet();
				Solid.color = color;
				DrawBox(rect, lineWidth);
				EndDrawSet();
			}

			public static void DrawBox(Rect rect, float lineWidth = 1f)
			{
				Draw(new Rect(rect.x, rect.y, rect.width, lineWidth));
				Draw(new Rect(rect.x, rect.y + rect.height - lineWidth, rect.width, lineWidth));
				Draw(new Rect(rect.x, rect.y + lineWidth, lineWidth, rect.height - lineWidth * 2f));
				Draw(new Rect(rect.x + rect.width - lineWidth, rect.y + lineWidth, lineWidth, rect.height - lineWidth * 2f));
			}

			public static void DrawBoxRotated(Rect rect, float rotation, float lineWidth = 1f)
			{
				bool flag = rotation != 0f;
				Matrix4x4 matrix = GUI.matrix;
				if (flag)
				{
					GUIUtility.RotateAroundPivot(360f - rotation, rect.center);
				}
				Draw(new Rect(rect.x, rect.y, rect.width, lineWidth));
				Draw(new Rect(rect.x, rect.y + rect.height - lineWidth, rect.width, lineWidth));
				Draw(new Rect(rect.x, rect.y + lineWidth, lineWidth, rect.height - lineWidth * 2f));
				Draw(new Rect(rect.x + rect.width - lineWidth, rect.y + lineWidth, lineWidth, rect.height - lineWidth * 2f));
				if (flag)
				{
					GUI.matrix = matrix;
				}
			}
		}

		internal class fLkZgrrKKBfqJUEgRegLiHRojRi
		{
			private EYbHpUDawhVtBYIrlIgfRxQamsq MisCFGawHIIwKPbckNBFhewdALr;

			private Rect EJBBfgczogzgOVLGEPBTMZoGOTo;

			private float PECFqYvKxJIjEVrxoxTtIUuNufj;

			public fLkZgrrKKBfqJUEgRegLiHRojRi()
			{
				MisCFGawHIIwKPbckNBFhewdALr = new EYbHpUDawhVtBYIrlIgfRxQamsq();
			}

			public void aEpfSZLoJsOEzitBGNfwYbILgHd(Rect P_0, float P_1)
			{
				if (P_0 != EJBBfgczogzgOVLGEPBTMZoGOTo || PECFqYvKxJIjEVrxoxTtIUuNufj != P_1)
				{
					float num = P_0.width / P_0.height;
					Texture2D texture2D = Solid.DrawToTexture(new Rect(0f, 0f, num * 100f, 100f));
					pcdEfDnNSvaGxAXqEXUEhQYLFbw(texture2D);
					OMZUeAiagvTvSakoMWbWqQMfqmh(P_1);
				}
				Rect position;
				if (P_1 == 0f)
				{
					position = P_0;
				}
				else
				{
					Rect rect = JiwgXrLJtehqNteDTZRoICAfKTP(P_0, P_1);
					rect.center = P_0.center;
					position = rect;
				}
				GUI.DrawTexture(position, MisCFGawHIIwKPbckNBFhewdALr.skGnPuDghAwTcSgsUIxmxPGSoIV, ScaleMode.StretchToFill);
				EJBBfgczogzgOVLGEPBTMZoGOTo = P_0;
				PECFqYvKxJIjEVrxoxTtIUuNufj = P_1;
			}

			private void pcdEfDnNSvaGxAXqEXUEhQYLFbw(Texture2D P_0)
			{
				MisCFGawHIIwKPbckNBFhewdALr.DbGUwhOLBDPtooapRRrajLlxieog(true);
				MisCFGawHIIwKPbckNBFhewdALr.skeOSBSqSPGPnIZySfEhxuCHbTXM(P_0);
			}

			private void OMZUeAiagvTvSakoMWbWqQMfqmh(float P_0)
			{
				MisCFGawHIIwKPbckNBFhewdALr.OMZUeAiagvTvSakoMWbWqQMfqmh(P_0);
			}

			private Rect JiwgXrLJtehqNteDTZRoICAfKTP(Rect P_0, float P_1)
			{
				float value = (float)Math.PI / 180f * P_1;
				int num = (int)P_0.height;
				int num2 = (int)P_0.width;
				float num3 = MathTools.Cos(value);
				float num4 = MathTools.Sin(value);
				int a = (int)((float)(-num) * num4);
				int a2 = (int)((float)num * num3);
				int a3 = (int)((float)num2 * num3 - (float)num * num4);
				int a4 = (int)((float)num * num3 + (float)num2 * num4);
				int b = (int)((float)num2 * num3);
				int b2 = (int)((float)num2 * num4);
				int num5 = MathTools.Min(0, MathTools.Min(a, MathTools.Min(a3, b)));
				int num6 = MathTools.Min(0, MathTools.Min(a2, MathTools.Min(a4, b2)));
				int num7 = MathTools.Max(0, MathTools.Max(a, MathTools.Max(a3, b)));
				int num8 = MathTools.Max(0, MathTools.Max(a2, MathTools.Max(a4, b2)));
				int num9 = num7 - num5 + 1;
				int num10 = num8 - num6 + 1;
				return new Rect(0f, 0f, num9, num10);
			}

			public void DbGUwhOLBDPtooapRRrajLlxieog()
			{
				if (MisCFGawHIIwKPbckNBFhewdALr != null)
				{
					MisCFGawHIIwKPbckNBFhewdALr.DbGUwhOLBDPtooapRRrajLlxieog(true);
				}
			}
		}

		internal class EYbHpUDawhVtBYIrlIgfRxQamsq
		{
			private Texture2D LCWcjjvpsqhssYeZZdFYuUJCfdvG;

			private Texture2D ioiZpZzCFdZOcpHkedPXZeMRMve;

			private bool rBIhkhgbbLizqyCwUGNwiYknDCHH;

			public Texture2D skGnPuDghAwTcSgsUIxmxPGSoIV
			{
				get
				{
					if (rBIhkhgbbLizqyCwUGNwiYknDCHH)
					{
						return ioiZpZzCFdZOcpHkedPXZeMRMve;
					}
					return LCWcjjvpsqhssYeZZdFYuUJCfdvG;
				}
			}

			public Rect xMEDZjgUMMOtEUUMAGgtjJXqYxJ
			{
				get
				{
					if (rBIhkhgbbLizqyCwUGNwiYknDCHH)
					{
						if (ioiZpZzCFdZOcpHkedPXZeMRMve != null)
						{
							return new Rect(0f, 0f, ioiZpZzCFdZOcpHkedPXZeMRMve.width, ioiZpZzCFdZOcpHkedPXZeMRMve.height);
						}
					}
					else if (LCWcjjvpsqhssYeZZdFYuUJCfdvG != null)
					{
						return new Rect(0f, 0f, LCWcjjvpsqhssYeZZdFYuUJCfdvG.width, LCWcjjvpsqhssYeZZdFYuUJCfdvG.height);
					}
					return default(Rect);
				}
			}

			public EYbHpUDawhVtBYIrlIgfRxQamsq()
			{
			}

			public EYbHpUDawhVtBYIrlIgfRxQamsq(Texture2D texture)
			{
				skeOSBSqSPGPnIZySfEhxuCHbTXM(texture);
			}

			public void skeOSBSqSPGPnIZySfEhxuCHbTXM(Texture2D P_0)
			{
				DbGUwhOLBDPtooapRRrajLlxieog();
				LCWcjjvpsqhssYeZZdFYuUJCfdvG = P_0;
				weWaUexrwaxcYLxiaVRHBSpgaDx();
				rBIhkhgbbLizqyCwUGNwiYknDCHH = false;
			}

			private void weWaUexrwaxcYLxiaVRHBSpgaDx()
			{
				if (LCWcjjvpsqhssYeZZdFYuUJCfdvG == null)
				{
					throw new Exception("Texture cannot be null!");
				}
			}

			public void OMZUeAiagvTvSakoMWbWqQMfqmh(float P_0)
			{
				weWaUexrwaxcYLxiaVRHBSpgaDx();
				if (P_0 == 0f)
				{
					rBIhkhgbbLizqyCwUGNwiYknDCHH = false;
					return;
				}
				rBIhkhgbbLizqyCwUGNwiYknDCHH = true;
				DbGUwhOLBDPtooapRRrajLlxieog();
				ioiZpZzCFdZOcpHkedPXZeMRMve = GetRotatedTexture(LCWcjjvpsqhssYeZZdFYuUJCfdvG, P_0, Color.clear);
			}

			public void DbGUwhOLBDPtooapRRrajLlxieog(bool P_0 = false)
			{
				if (ioiZpZzCFdZOcpHkedPXZeMRMve != null)
				{
					UnityEngine.Object.DestroyImmediate(ioiZpZzCFdZOcpHkedPXZeMRMve);
				}
				if (P_0 && LCWcjjvpsqhssYeZZdFYuUJCfdvG != null)
				{
					UnityEngine.Object.DestroyImmediate(LCWcjjvpsqhssYeZZdFYuUJCfdvG);
				}
			}
		}

		public static Texture2D GetRotatedTexture(Texture2D texture, float angle, Color backgroundColor)
		{
			float value = (float)Math.PI / 180f * angle;
			int height = texture.height;
			int width = texture.width;
			float num = MathTools.Cos(value);
			float num2 = MathTools.Sin(value);
			int a = (int)((float)(-height) * num2);
			int a2 = (int)((float)height * num);
			int a3 = (int)((float)width * num - (float)height * num2);
			int a4 = (int)((float)height * num + (float)width * num2);
			int b = (int)((float)width * num);
			int b2 = (int)((float)width * num2);
			int num3 = MathTools.Min(0, MathTools.Min(a, MathTools.Min(a3, b)));
			int num4 = MathTools.Min(0, MathTools.Min(a2, MathTools.Min(a4, b2)));
			int num5 = MathTools.Max(0, MathTools.Max(a, MathTools.Max(a3, b)));
			int num6 = MathTools.Max(0, MathTools.Max(a2, MathTools.Max(a4, b2)));
			int num7 = num5 - num3 + 1;
			int num8 = num6 - num4 + 1;
			Color[] array = new Color[num7 * num8];
			Color[] pixels = texture.GetPixels();
			for (int i = 0; i < num8; i++)
			{
				for (int j = 0; j < num7; j++)
				{
					int num9 = i * num7 + j;
					int num10 = (int)((float)(j + num3) * num + (float)(i + num4) * num2);
					int num11 = (int)((float)(i + num4) * num - (float)(j + num3) * num2);
					int num12 = num11 * width + num10;
					if (num10 >= 0 && num10 < width && num11 >= 0 && num11 < height)
					{
						ref Color reference = ref array[num9];
						reference = pixels[num12];
					}
					else
					{
						array[num9] = backgroundColor;
					}
				}
			}
			Texture2D texture2D = new Texture2D(num7, num8);
			texture2D.SetPixels(array);
			texture2D.Apply();
			texture2D.hideFlags = HideFlags.DontSave;
			return texture2D;
		}

		public static GUIContent[] ToGUIContentArray(string[] items)
		{
			if (items == null)
			{
				return null;
			}
			GUIContent[] array = new GUIContent[items.Length];
			for (int i = 0; i < items.Length; i++)
			{
				array[i] = new GUIContent(items[i]);
			}
			return array;
		}

		public static GUIContent[] ToGUIContentArray(IList<string> items)
		{
			if (items == null)
			{
				return null;
			}
			GUIContent[] array = new GUIContent[items.Count];
			for (int i = 0; i < items.Count; i++)
			{
				array[i] = new GUIContent(items[i]);
			}
			return array;
		}
	}
}
