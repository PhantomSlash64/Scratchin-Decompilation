using System.ComponentModel;
using Rewired.Utils;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.Internal
{
	[AddComponentMenu("")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public class GUIText : MonoBehaviour
	{
		private string uaValmAqRGfkOdCyrvmVTFUaBAi;

		private GUIStyle VIbIwzbfgdNTBlFUYDoSYIXGYoe;

		private TextAnchor tlamMqJmwyJzxXyKJIHzpSSnZAb;

		private TextAlignment uWdfwEHKSlZOWVAmdiMWsswoTWPP;

		private float ctXGARMIvValxiIKAFYbMfiYLkaB;

		private Font molCrERbBBEcLgJgCIdrRRWnonTF;

		private int OFgjaVgEpIEfUokKtNVqbEzfYOy = -1;

		private FontStyle MQQKddXekTTgdonoluielstmmyT;

		private Color SRiVQMBEPiowEgfqzXspHgjSnxY = Color.white;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private Vector2 _pixelOffset;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private bool _useUnityUI;

		private bool QKnryYPqLOhsTWKSZZbWZtNycsH;

		private bool ljDsevaNvguiXorBDCGdVnEdCOJ;

		private bool tbyiimUbNKSckVWFqPoecXlhbjD;

		private bool DaSWjaWqlxlXQGPRYzXdADicDKt;

		private bool JZYIVGpKGCpPMONgShQPNbUsqPs;

		private bool NBkgxZvdxcwNwxZlRuRZwLzgXtM;

		private bool PeWesQVvIVxCVcPffhjRdDJEBBi;

		private Text tZGGhPHlSFBWGYJIQYdqRTYNxTI;

		private bool vNPPdNgZhvVGmOXoMxFGtmFaJpc;

		private bool OMpLCwIqMoYhTtLXIuZNdLSUZzA;

		public string text
		{
			get
			{
				return uaValmAqRGfkOdCyrvmVTFUaBAi;
			}
			set
			{
				uaValmAqRGfkOdCyrvmVTFUaBAi = value;
			}
		}

		public TextAnchor anchor
		{
			get
			{
				return tlamMqJmwyJzxXyKJIHzpSSnZAb;
			}
			set
			{
				tlamMqJmwyJzxXyKJIHzpSSnZAb = value;
				QKnryYPqLOhsTWKSZZbWZtNycsH = true;
				if (VIbIwzbfgdNTBlFUYDoSYIXGYoe != null)
				{
					VIbIwzbfgdNTBlFUYDoSYIXGYoe.alignment = value;
				}
			}
		}

		public TextAlignment alignment
		{
			get
			{
				return uWdfwEHKSlZOWVAmdiMWsswoTWPP;
			}
			set
			{
				uWdfwEHKSlZOWVAmdiMWsswoTWPP = value;
				ljDsevaNvguiXorBDCGdVnEdCOJ = true;
			}
		}

		public float lineSpacing
		{
			get
			{
				return ctXGARMIvValxiIKAFYbMfiYLkaB;
			}
			set
			{
				ctXGARMIvValxiIKAFYbMfiYLkaB = value;
				tbyiimUbNKSckVWFqPoecXlhbjD = true;
				_ = VIbIwzbfgdNTBlFUYDoSYIXGYoe;
			}
		}

		public Font font
		{
			get
			{
				return molCrERbBBEcLgJgCIdrRRWnonTF;
			}
			set
			{
				DaSWjaWqlxlXQGPRYzXdADicDKt = true;
				molCrERbBBEcLgJgCIdrRRWnonTF = value;
				if (VIbIwzbfgdNTBlFUYDoSYIXGYoe != null)
				{
					VIbIwzbfgdNTBlFUYDoSYIXGYoe.font = value;
				}
			}
		}

		public int fontSize
		{
			get
			{
				return OFgjaVgEpIEfUokKtNVqbEzfYOy;
			}
			set
			{
				OFgjaVgEpIEfUokKtNVqbEzfYOy = value;
				JZYIVGpKGCpPMONgShQPNbUsqPs = true;
				if (VIbIwzbfgdNTBlFUYDoSYIXGYoe != null)
				{
					VIbIwzbfgdNTBlFUYDoSYIXGYoe.fontSize = value;
				}
			}
		}

		public FontStyle fontStyle
		{
			get
			{
				return MQQKddXekTTgdonoluielstmmyT;
			}
			set
			{
				MQQKddXekTTgdonoluielstmmyT = value;
				NBkgxZvdxcwNwxZlRuRZwLzgXtM = true;
				if (VIbIwzbfgdNTBlFUYDoSYIXGYoe != null)
				{
					VIbIwzbfgdNTBlFUYDoSYIXGYoe.fontStyle = value;
				}
			}
		}

		public Color color
		{
			get
			{
				return SRiVQMBEPiowEgfqzXspHgjSnxY;
			}
			set
			{
				SRiVQMBEPiowEgfqzXspHgjSnxY = value;
				PeWesQVvIVxCVcPffhjRdDJEBBi = true;
				if (VIbIwzbfgdNTBlFUYDoSYIXGYoe != null)
				{
					VIbIwzbfgdNTBlFUYDoSYIXGYoe.normal.textColor = value;
				}
			}
		}

		public Vector2 pixelOffset
		{
			get
			{
				return _pixelOffset;
			}
			set
			{
				_pixelOffset = value;
			}
		}

		public bool useUnityUI
		{
			get
			{
				return _useUnityUI;
			}
			set
			{
				if (_useUnityUI != value)
				{
					_useUnityUI = value;
					vNPPdNgZhvVGmOXoMxFGtmFaJpc = value;
					if (value)
					{
						YxxepTYdYBNPIauANTlQIrmTtRZ();
					}
					else
					{
						LtLHwpCUrPmXKXQGCxwjEbbPjgiC();
					}
				}
			}
		}

		[CustomObfuscation(rename = false)]
		private void Awake()
		{
			OMpLCwIqMoYhTtLXIuZNdLSUZzA = true;
		}

		[CustomObfuscation(rename = false)]
		private void Start()
		{
			vNPPdNgZhvVGmOXoMxFGtmFaJpc = _useUnityUI;
			if (_useUnityUI)
			{
				YxxepTYdYBNPIauANTlQIrmTtRZ();
			}
		}

		[CustomObfuscation(rename = false)]
		private void OnGUI()
		{
			if (!_useUnityUI)
			{
				if (VIbIwzbfgdNTBlFUYDoSYIXGYoe == null)
				{
					zRCbYEbNSQCAJMMYtnkwaBUAcKTb();
				}
				if (!string.IsNullOrEmpty(uaValmAqRGfkOdCyrvmVTFUaBAi))
				{
					Vector2 vector = base.transform.localPosition;
					Rect position = new Rect(vector.x * (float)Screen.width + _pixelOffset.x, vector.y * (float)Screen.height + _pixelOffset.y, MathTools.Clamp((float)Screen.width - vector.x * (float)Screen.width, 0f, float.MaxValue), MathTools.Clamp((float)Screen.height - vector.y * (float)Screen.height, 0f, float.MaxValue));
					GUI.Label(position, uaValmAqRGfkOdCyrvmVTFUaBAi, VIbIwzbfgdNTBlFUYDoSYIXGYoe);
				}
			}
		}

		[CustomObfuscation(rename = false)]
		private void Update()
		{
			if (!_useUnityUI)
			{
				return;
			}
			if (tZGGhPHlSFBWGYJIQYdqRTYNxTI == null)
			{
				Logger.LogError("Text component has been deleted.");
				return;
			}
			RectTransform component = tZGGhPHlSFBWGYJIQYdqRTYNxTI.GetComponent<RectTransform>();
			if (component.anchoredPosition != _pixelOffset)
			{
				component.anchoredPosition = _pixelOffset;
			}
			tZGGhPHlSFBWGYJIQYdqRTYNxTI.text = uaValmAqRGfkOdCyrvmVTFUaBAi;
		}

		[CustomObfuscation(rename = false)]
		private void OnValidate()
		{
			if (OMpLCwIqMoYhTtLXIuZNdLSUZzA && _useUnityUI != vNPPdNgZhvVGmOXoMxFGtmFaJpc)
			{
				vNPPdNgZhvVGmOXoMxFGtmFaJpc = _useUnityUI;
				if (_useUnityUI)
				{
					YxxepTYdYBNPIauANTlQIrmTtRZ();
				}
				else
				{
					LtLHwpCUrPmXKXQGCxwjEbbPjgiC();
				}
			}
		}

		private void YxxepTYdYBNPIauANTlQIrmTtRZ()
		{
			if (!Application.isPlaying)
			{
				return;
			}
			Canvas componentInSelfOrParents = UnityTools.GetComponentInSelfOrParents<Canvas>(base.transform);
			if (componentInSelfOrParents == null)
			{
				GameObject gameObject;
				if (base.transform.root == base.transform)
				{
					gameObject = new GameObject("Canvas");
					base.transform.SetParent(gameObject.transform, worldPositionStays: true);
				}
				else
				{
					gameObject = base.transform.root.gameObject;
				}
				componentInSelfOrParents = gameObject.AddComponent<Canvas>();
				componentInSelfOrParents.renderMode = RenderMode.ScreenSpaceOverlay;
				if (!(gameObject.GetComponent<CanvasScaler>() != null))
				{
					gameObject.AddComponent<CanvasScaler>();
				}
				else
				{
					gameObject.GetComponent<CanvasScaler>();
				}
			}
			tZGGhPHlSFBWGYJIQYdqRTYNxTI = GetComponent<Text>();
			if (tZGGhPHlSFBWGYJIQYdqRTYNxTI == null)
			{
				RectTransform rectTransform = base.gameObject.AddComponent<RectTransform>();
				rectTransform.anchorMax = new Vector2(1f, 1f);
				rectTransform.anchorMin = new Vector2(0f, 0f);
				rectTransform.localPosition = Vector2.zero;
				rectTransform.anchoredPosition = Vector2.zero;
				rectTransform.sizeDelta = Vector3.zero;
				tZGGhPHlSFBWGYJIQYdqRTYNxTI = base.gameObject.AddComponent<Text>();
				tZGGhPHlSFBWGYJIQYdqRTYNxTI.color = Color.white;
				tZGGhPHlSFBWGYJIQYdqRTYNxTI.font = Resources.GetBuiltinResource<Font>("Arial.ttf");
				tZGGhPHlSFBWGYJIQYdqRTYNxTI.fontSize = 13;
				if (QKnryYPqLOhsTWKSZZbWZtNycsH)
				{
					tZGGhPHlSFBWGYJIQYdqRTYNxTI.alignment = tlamMqJmwyJzxXyKJIHzpSSnZAb;
				}
				else
				{
					tlamMqJmwyJzxXyKJIHzpSSnZAb = tZGGhPHlSFBWGYJIQYdqRTYNxTI.alignment;
				}
				if (DaSWjaWqlxlXQGPRYzXdADicDKt)
				{
					tZGGhPHlSFBWGYJIQYdqRTYNxTI.font = molCrERbBBEcLgJgCIdrRRWnonTF;
				}
				else
				{
					molCrERbBBEcLgJgCIdrRRWnonTF = tZGGhPHlSFBWGYJIQYdqRTYNxTI.font;
				}
				if (JZYIVGpKGCpPMONgShQPNbUsqPs)
				{
					tZGGhPHlSFBWGYJIQYdqRTYNxTI.fontSize = OFgjaVgEpIEfUokKtNVqbEzfYOy;
				}
				else
				{
					OFgjaVgEpIEfUokKtNVqbEzfYOy = tZGGhPHlSFBWGYJIQYdqRTYNxTI.fontSize;
				}
				if (NBkgxZvdxcwNwxZlRuRZwLzgXtM)
				{
					tZGGhPHlSFBWGYJIQYdqRTYNxTI.fontStyle = MQQKddXekTTgdonoluielstmmyT;
				}
				else
				{
					MQQKddXekTTgdonoluielstmmyT = tZGGhPHlSFBWGYJIQYdqRTYNxTI.fontStyle;
				}
				if (PeWesQVvIVxCVcPffhjRdDJEBBi)
				{
					tZGGhPHlSFBWGYJIQYdqRTYNxTI.color = SRiVQMBEPiowEgfqzXspHgjSnxY;
				}
				else
				{
					SRiVQMBEPiowEgfqzXspHgjSnxY = tZGGhPHlSFBWGYJIQYdqRTYNxTI.color;
				}
			}
		}

		private void LtLHwpCUrPmXKXQGCxwjEbbPjgiC()
		{
			if (Application.isPlaying)
			{
				if (tZGGhPHlSFBWGYJIQYdqRTYNxTI != null)
				{
					tZGGhPHlSFBWGYJIQYdqRTYNxTI.text = string.Empty;
				}
				tZGGhPHlSFBWGYJIQYdqRTYNxTI = null;
			}
		}

		private void zRCbYEbNSQCAJMMYtnkwaBUAcKTb()
		{
			VIbIwzbfgdNTBlFUYDoSYIXGYoe = new GUIStyle(GUI.skin.label);
			if (QKnryYPqLOhsTWKSZZbWZtNycsH)
			{
				VIbIwzbfgdNTBlFUYDoSYIXGYoe.alignment = tlamMqJmwyJzxXyKJIHzpSSnZAb;
			}
			else
			{
				tlamMqJmwyJzxXyKJIHzpSSnZAb = VIbIwzbfgdNTBlFUYDoSYIXGYoe.alignment;
			}
			if (DaSWjaWqlxlXQGPRYzXdADicDKt)
			{
				VIbIwzbfgdNTBlFUYDoSYIXGYoe.font = molCrERbBBEcLgJgCIdrRRWnonTF;
			}
			else
			{
				molCrERbBBEcLgJgCIdrRRWnonTF = VIbIwzbfgdNTBlFUYDoSYIXGYoe.font;
			}
			if (JZYIVGpKGCpPMONgShQPNbUsqPs)
			{
				VIbIwzbfgdNTBlFUYDoSYIXGYoe.fontSize = OFgjaVgEpIEfUokKtNVqbEzfYOy;
			}
			else
			{
				OFgjaVgEpIEfUokKtNVqbEzfYOy = VIbIwzbfgdNTBlFUYDoSYIXGYoe.fontSize;
			}
			if (NBkgxZvdxcwNwxZlRuRZwLzgXtM)
			{
				VIbIwzbfgdNTBlFUYDoSYIXGYoe.fontStyle = MQQKddXekTTgdonoluielstmmyT;
			}
			else
			{
				MQQKddXekTTgdonoluielstmmyT = VIbIwzbfgdNTBlFUYDoSYIXGYoe.fontStyle;
			}
			if (PeWesQVvIVxCVcPffhjRdDJEBBi)
			{
				VIbIwzbfgdNTBlFUYDoSYIXGYoe.normal.textColor = SRiVQMBEPiowEgfqzXspHgjSnxY;
			}
			else
			{
				SRiVQMBEPiowEgfqzXspHgjSnxY = VIbIwzbfgdNTBlFUYDoSYIXGYoe.normal.textColor;
			}
		}

		[CustomObfuscation(rename = false)]
		internal static GUIText GetOrAddComponent(GameObject gameObject)
		{
			if (gameObject == null)
			{
				return null;
			}
			GUIText gUIText = gameObject.GetComponent<GUIText>();
			if (gUIText == null)
			{
				gUIText = gameObject.AddComponent<GUIText>();
			}
			return gUIText;
		}

		[CustomObfuscation(rename = false)]
		internal static GUIText CreateLogger(GameObject gameObject)
		{
			if (gameObject == null)
			{
				return null;
			}
			GUIText orAddComponent = GetOrAddComponent(gameObject);
			orAddComponent.anchor = TextAnchor.LowerLeft;
			return orAddComponent;
		}
	}
}
