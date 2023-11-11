using System.Collections.Generic;
using Rewired.Utils;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.ComponentControls.Effects
{
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("Rewired/Touch Joystick Radial Indicator")]
	[DisallowMultipleComponent]
	public sealed class TouchJoystickRadialIndicator : MonoBehaviour, IRegistrar<TouchJoystickAngleIndicator>
	{
		[Tooltip("If enabled, the indicators will be scaled based on the size of the RectTransform.")]
		public bool _scale = true;

		[Tooltip("If enabled, the aspect ratio will be determined from the Sprite's texture.")]
		public bool _preserveSpriteAspectRatio;

		[Tooltip("The scale ratio of the indicators to the current RectTransform's height. A ratio of 0.1 means the indicator will be 0.1 times the size of the RectTransform's height. This is useful if you need to be able to scale the transform and have the indicators also scale with it.")]
		[Range(0.01f, 1f)]
		public float _scaleRatio = 0.1f;

		[Tooltip("The horizontal component of the desired aspect ratio of the indicator.")]
		[Range(0.01f, 10f)]
		public float _aspectRatioX = 1f;

		[Tooltip("The vertical component of the desired aspect ratio of the indicator.")]
		[Range(0.01f, 10f)]
		public float _aspectRatioY = 1f;

		[Tooltip("Offsets the indicator position up by this proportion of its height. 1.0 = 1 unit high offset.")]
		public float _offset;

		private static readonly Vector2 ZfPxlKAoqLzBKyBYZGCwaCiIjOcf = new Vector2(0.5f, 0.5f);

		private RectTransform BcIAwJgSnLFxVbKeBcwrOGXvzwTM;

		private List<TouchJoystickAngleIndicator> HBHDGAVuCFgyoTwJewSIoHUAaFV = new List<TouchJoystickAngleIndicator>(8);

		public bool scale
		{
			get
			{
				return _scale;
			}
			set
			{
				if (_scale != value)
				{
					_scale = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool preserveSpriteAspectRatio
		{
			get
			{
				return _preserveSpriteAspectRatio;
			}
			set
			{
				if (_preserveSpriteAspectRatio != value)
				{
					_preserveSpriteAspectRatio = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public float scaleRatio
		{
			get
			{
				return _scaleRatio;
			}
			set
			{
				value = MathTools.Clamp(value, 0.01f, 1f);
				if (_scaleRatio != value)
				{
					_scaleRatio = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public float aspectRatioX
		{
			get
			{
				return _aspectRatioX;
			}
			set
			{
				value = MathTools.Clamp(value, 0.01f, 10f);
				if (_aspectRatioX != value)
				{
					_aspectRatioX = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public float aspectRatioY
		{
			get
			{
				return _aspectRatioY;
			}
			set
			{
				value = MathTools.Clamp(value, 0.01f, 10f);
				if (_aspectRatioY != value)
				{
					_aspectRatioY = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public float offset
		{
			get
			{
				return _offset;
			}
			set
			{
				if (_offset != value)
				{
					_offset = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		private RectTransform rectTransform => BcIAwJgSnLFxVbKeBcwrOGXvzwTM ?? (BcIAwJgSnLFxVbKeBcwrOGXvzwTM = GetComponent<RectTransform>());

		private void ASoTaPNAaevtgrJWbkkxNjzQkbo(TouchJoystickAngleIndicator P_0)
		{
			if (!(P_0 == null) && ListTools.AddIfUnique(HBHDGAVuCFgyoTwJewSIoHUAaFV, P_0) && base.enabled)
			{
				aEpfSZLoJsOEzitBGNfwYbILgHd(P_0);
			}
		}

		void IRegistrar<TouchJoystickAngleIndicator>.Register(TouchJoystickAngleIndicator P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in ASoTaPNAaevtgrJWbkkxNjzQkbo
			this.ASoTaPNAaevtgrJWbkkxNjzQkbo(P_0);
		}

		private void xeUioCWJHfDPXBVcgiFoTJCMLrRA(TouchJoystickAngleIndicator P_0)
		{
			if (!(P_0 == null))
			{
				HBHDGAVuCFgyoTwJewSIoHUAaFV.Remove(P_0);
			}
		}

		void IRegistrar<TouchJoystickAngleIndicator>.Deregister(TouchJoystickAngleIndicator P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in xeUioCWJHfDPXBVcgiFoTJCMLrRA
			this.xeUioCWJHfDPXBVcgiFoTJCMLrRA(P_0);
		}

		[CustomObfuscation(rename = false)]
		private void Update()
		{
			kYnxYdZvVIFjSDFCphKrSBUYzpG();
		}

		[CustomObfuscation(rename = false)]
		private void OnValidate()
		{
			if (base.enabled)
			{
				PNfJYrapMCtTFxIAmRFpRIVgZrq();
				kYnxYdZvVIFjSDFCphKrSBUYzpG();
			}
		}

		[CustomObfuscation(rename = false)]
		private void OnEnable()
		{
			kYnxYdZvVIFjSDFCphKrSBUYzpG();
		}

		[CustomObfuscation(rename = false)]
		private void OnDestroy()
		{
			HBHDGAVuCFgyoTwJewSIoHUAaFV.Clear();
		}

		private void kYnxYdZvVIFjSDFCphKrSBUYzpG()
		{
			for (int num = HBHDGAVuCFgyoTwJewSIoHUAaFV.Count - 1; num >= 0; num--)
			{
				TouchJoystickAngleIndicator touchJoystickAngleIndicator = HBHDGAVuCFgyoTwJewSIoHUAaFV[num];
				if (touchJoystickAngleIndicator.image.IsNullOrDestroyed())
				{
					HBHDGAVuCFgyoTwJewSIoHUAaFV.RemoveAt(num);
				}
				else
				{
					aEpfSZLoJsOEzitBGNfwYbILgHd(touchJoystickAngleIndicator);
				}
			}
		}

		private void aEpfSZLoJsOEzitBGNfwYbILgHd(TouchJoystickAngleIndicator P_0)
		{
			if (!UnityTools.IsActiveAndEnabled(P_0.image))
			{
				return;
			}
			RectTransform rectTransform = P_0.rectTransform;
			if (rectTransform == this.rectTransform || rectTransform == null)
			{
				return;
			}
			Rect rect = this.rectTransform.rect;
			if (_scale)
			{
				float num = (num = _aspectRatioX / _aspectRatioY);
				if (_preserveSpriteAspectRatio && P_0.jfKAJWpVbRiZcBdRDInMeTSZkLnI(out var vector))
				{
					num = vector.x / vector.y;
				}
				Vector2 sizeDelta = new Vector2(rect.height * _scaleRatio * num, rect.height * _scaleRatio);
				rectTransform.sizeDelta = sizeDelta;
			}
			float num2 = (rect.height / 2f / rectTransform.rect.height - 1f) * -1f;
			if (rectTransform.anchorMin != ZfPxlKAoqLzBKyBYZGCwaCiIjOcf)
			{
				rectTransform.anchorMin = ZfPxlKAoqLzBKyBYZGCwaCiIjOcf;
			}
			if (rectTransform.anchorMax != ZfPxlKAoqLzBKyBYZGCwaCiIjOcf)
			{
				rectTransform.anchorMax = ZfPxlKAoqLzBKyBYZGCwaCiIjOcf;
			}
			Vector2 pivot = rectTransform.pivot;
			pivot.x = 0.5f;
			pivot.y = num2 + _offset * -1f;
			rectTransform.pivot = pivot;
		}

		private void QCALZHBveTZKrIACkwpJsrxWoUa()
		{
			kYnxYdZvVIFjSDFCphKrSBUYzpG();
		}

		private void PNfJYrapMCtTFxIAmRFpRIVgZrq()
		{
			Transform transform = base.transform;
			HBHDGAVuCFgyoTwJewSIoHUAaFV.Clear();
			int childCount = transform.childCount;
			for (int i = 0; i < childCount; i++)
			{
				Transform child = transform.GetChild(i);
				TouchJoystickAngleIndicator component = child.GetComponent<TouchJoystickAngleIndicator>();
				if (component != null)
				{
					HBHDGAVuCFgyoTwJewSIoHUAaFV.Add(component);
				}
			}
		}
	}
}
