using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	[AddComponentMenu("Rewired/Touch Region")]
	public sealed class TouchRegion : TouchInteractable
	{
		[Serializable]
		private class fsXbqltWQtenWcJbymFqVLLMTMgd : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class uICLYBYLZBtIvvtWmkYTSKerJCY : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class NpNLWUZvEiUnqhDwPsbUFoeLVBq : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class fdhBlrqNeDZMwcXSUlyqsJMLZgJ : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class qrherfRNAMuewCUuyieBqXlSjxr : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class YUbTcbtRvqhFqhjmTxZoMDCIkhS : UnityEvent<PointerEventData>
		{
		}

		[Serializable]
		private class ZANRlLLgkqRySJWELQtbsgKmMFO : UnityEvent<PointerEventData>
		{
		}

		[SerializeField]
		[Tooltip("If enabled, the Touch Region will be hidden when gameplay starts.")]
		[CustomObfuscation(rename = false)]
		private bool _hideAtRuntime = true;

		private fsXbqltWQtenWcJbymFqVLLMTMgd _onPointerDown = new fsXbqltWQtenWcJbymFqVLLMTMgd();

		private uICLYBYLZBtIvvtWmkYTSKerJCY _onPointerUp = new uICLYBYLZBtIvvtWmkYTSKerJCY();

		private NpNLWUZvEiUnqhDwPsbUFoeLVBq _onPointerEnter = new NpNLWUZvEiUnqhDwPsbUFoeLVBq();

		private fdhBlrqNeDZMwcXSUlyqsJMLZgJ _onPointerExit = new fdhBlrqNeDZMwcXSUlyqsJMLZgJ();

		private qrherfRNAMuewCUuyieBqXlSjxr _onBeginDrag = new qrherfRNAMuewCUuyieBqXlSjxr();

		private YUbTcbtRvqhFqhjmTxZoMDCIkhS _onDrag = new YUbTcbtRvqhFqhjmTxZoMDCIkhS();

		private ZANRlLLgkqRySJWELQtbsgKmMFO _onEndDrag = new ZANRlLLgkqRySJWELQtbsgKmMFO();

		public bool hideAtRuntime
		{
			get
			{
				return _hideAtRuntime;
			}
			set
			{
				if (!(_hideAtRuntime = value))
				{
					_hideAtRuntime = true;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public event UnityAction<PointerEventData> PointerDownEvent
		{
			add
			{
				_onPointerDown.AddListener(value);
			}
			remove
			{
				_onPointerDown.RemoveListener(value);
			}
		}

		public event UnityAction<PointerEventData> PointerUpEvent
		{
			add
			{
				_onPointerUp.AddListener(value);
			}
			remove
			{
				_onPointerUp.RemoveListener(value);
			}
		}

		public event UnityAction<PointerEventData> PointerEnterEvent
		{
			add
			{
				_onPointerEnter.AddListener(value);
			}
			remove
			{
				_onPointerEnter.RemoveListener(value);
			}
		}

		public event UnityAction<PointerEventData> PointerExitEvent
		{
			add
			{
				_onPointerExit.AddListener(value);
			}
			remove
			{
				_onPointerExit.RemoveListener(value);
			}
		}

		public event UnityAction<PointerEventData> BeginDragEvent
		{
			add
			{
				_onBeginDrag.AddListener(value);
			}
			remove
			{
				_onBeginDrag.RemoveListener(value);
			}
		}

		public event UnityAction<PointerEventData> DragEvent
		{
			add
			{
				_onDrag.AddListener(value);
			}
			remove
			{
				_onDrag.RemoveListener(value);
			}
		}

		public event UnityAction<PointerEventData> EndDragEvent
		{
			add
			{
				_onEndDrag.AddListener(value);
			}
			remove
			{
				_onEndDrag.RemoveListener(value);
			}
		}

		[CustomObfuscation(rename = false)]
		private TouchRegion()
		{
		}

		[CustomObfuscation(rename = false)]
		internal override void Awake()
		{
			base.Awake();
			if (Application.isPlaying && _hideAtRuntime)
			{
				base.visible = false;
			}
		}

		public override void ClearValue()
		{
		}

		internal override void mmZvUkQigzMnepEREFECJZiFGep()
		{
		}

		internal override void OnPointerDown(PointerEventData eventData)
		{
			base.OnPointerDown(eventData);
			if (base.initialized && XBsbLTtXGPImfIaItQCdVxhsKkCf() && IsInteractable() && TouchInteractable.DrebNyFyDDBAsDuDivulZyHbKPQe(eventData.pointerId, base.allowedMouseButtons, EventTriggerType.PointerDown) && _onPointerDown != null)
			{
				_onPointerDown.Invoke(eventData);
			}
		}

		internal override void OnPointerUp(PointerEventData eventData)
		{
			base.OnPointerUp(eventData);
			if (base.initialized && XBsbLTtXGPImfIaItQCdVxhsKkCf() && IsInteractable() && TouchInteractable.DrebNyFyDDBAsDuDivulZyHbKPQe(eventData.pointerId, base.allowedMouseButtons, EventTriggerType.PointerUp) && _onPointerUp != null)
			{
				_onPointerUp.Invoke(eventData);
			}
		}

		internal override void OnPointerEnter(PointerEventData eventData)
		{
			base.OnPointerEnter(eventData);
			if (base.initialized && XBsbLTtXGPImfIaItQCdVxhsKkCf() && IsInteractable() && TouchInteractable.DrebNyFyDDBAsDuDivulZyHbKPQe(eventData.pointerId, base.allowedMouseButtons, EventTriggerType.PointerEnter) && _onPointerEnter != null)
			{
				_onPointerEnter.Invoke(eventData);
			}
		}

		internal override void OnPointerExit(PointerEventData eventData)
		{
			base.OnPointerExit(eventData);
			if (base.initialized && XBsbLTtXGPImfIaItQCdVxhsKkCf() && IsInteractable() && TouchInteractable.DrebNyFyDDBAsDuDivulZyHbKPQe(eventData.pointerId, base.allowedMouseButtons, EventTriggerType.PointerExit) && _onPointerExit != null)
			{
				_onPointerExit.Invoke(eventData);
			}
		}

		internal override void OnBeginDrag(PointerEventData eventData)
		{
			base.OnBeginDrag(eventData);
			if (base.initialized && XBsbLTtXGPImfIaItQCdVxhsKkCf() && IsInteractable() && TouchInteractable.DrebNyFyDDBAsDuDivulZyHbKPQe(eventData.pointerId, base.allowedMouseButtons, EventTriggerType.BeginDrag) && _onBeginDrag != null)
			{
				_onBeginDrag.Invoke(eventData);
			}
		}

		internal override void OnDrag(PointerEventData eventData)
		{
			base.OnDrag(eventData);
			if (base.initialized && XBsbLTtXGPImfIaItQCdVxhsKkCf() && IsInteractable() && TouchInteractable.DrebNyFyDDBAsDuDivulZyHbKPQe(eventData.pointerId, base.allowedMouseButtons, EventTriggerType.Drag) && _onDrag != null)
			{
				_onDrag.Invoke(eventData);
			}
		}

		internal override void OnEndDrag(PointerEventData eventData)
		{
			base.OnEndDrag(eventData);
			if (base.initialized && XBsbLTtXGPImfIaItQCdVxhsKkCf() && IsInteractable() && TouchInteractable.DrebNyFyDDBAsDuDivulZyHbKPQe(eventData.pointerId, base.allowedMouseButtons, EventTriggerType.EndDrag) && _onEndDrag != null)
			{
				_onEndDrag.Invoke(eventData);
			}
		}
	}
}
