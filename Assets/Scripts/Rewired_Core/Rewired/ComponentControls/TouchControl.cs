using System;
using Rewired.Utils;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(RectTransform))]
	public abstract class TouchControl : CustomControllerControl
	{
		private Canvas _canvas;

		private RectTransform __rectTransform;

		internal TouchController touchController => jDfrNqIZbnNpNZYLlGezNVBaGsv() as TouchController;

		internal Canvas canvas => _canvas;

		internal RectTransform canvasTransform
		{
			get
			{
				Canvas canvas = this.canvas;
				if (canvas == null)
				{
					return null;
				}
				return canvas.transform as RectTransform;
			}
		}

		internal RectTransform rectTransform => __rectTransform ?? (__rectTransform = GetComponent<RectTransform>());

		internal override bool hasController => jDfrNqIZbnNpNZYLlGezNVBaGsv() as TouchController != null;

		[CustomObfuscation(rename = false)]
		internal TouchControl()
		{
		}

		[CustomObfuscation(rename = false)]
		internal override void OnValidate()
		{
			base.OnValidate();
			if (base.initialized)
			{
				kVBQGZMwTJReeCPPNgEwMRFzUIf(true, false);
			}
		}

		[CustomObfuscation(rename = false)]
		internal override void OnCanvasGroupChanged()
		{
			base.OnCanvasGroupChanged();
			if (base.initialized)
			{
				kVBQGZMwTJReeCPPNgEwMRFzUIf(false, true);
			}
		}

		[CustomObfuscation(rename = false)]
		internal override void OnTransformParentChanged()
		{
			base.OnTransformParentChanged();
			if (base.initialized)
			{
				kVBQGZMwTJReeCPPNgEwMRFzUIf(false, true);
			}
		}

		internal override bool sTGamvWFKxGXQiXUVibUDPQNCmv()
		{
			if (!base.sTGamvWFKxGXQiXUVibUDPQNCmv())
			{
				return false;
			}
			if (!kVBQGZMwTJReeCPPNgEwMRFzUIf(true, true))
			{
				return false;
			}
			return true;
		}

		internal override void QCALZHBveTZKrIACkwpJsrxWoUa()
		{
			base.QCALZHBveTZKrIACkwpJsrxWoUa();
			if (base.initialized)
			{
				kVBQGZMwTJReeCPPNgEwMRFzUIf(true, true);
			}
		}

		[CustomObfuscation(rename = false)]
		internal override IComponentController FindController()
		{
			return UnityTools.GetComponentInSelfOrParents<CustomController>(base.transform);
		}

		[CustomObfuscation(rename = false)]
		internal override Type GetRequiredControllerType()
		{
			return typeof(TouchController);
		}

		private bool kVBQGZMwTJReeCPPNgEwMRFzUIf(bool P_0, bool P_1)
		{
			_canvas = UnityTools.GetComponentInSelfOrParents<Canvas>(base.gameObject);
			if (_canvas == null)
			{
				if (P_0)
				{
					Logger.LogError("No Canvas was found. Touch controls must be a child of a Canvas.");
				}
				return false;
			}
			if (_canvas.renderMode == RenderMode.WorldSpace)
			{
				if (P_1)
				{
					Logger.LogError("Touch controls cannot be used with a world space Canvas. Change the canvas render mode to screen space.");
				}
				return false;
			}
			return true;
		}
	}
}
