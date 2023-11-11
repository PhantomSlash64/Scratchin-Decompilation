using Rewired.UI;
using Rewired.Utils;
using Rewired.Utils.Attributes;
using UnityEngine;
using UnityEngine.UI;

namespace Rewired.ComponentControls.Effects
{
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("Rewired/Touch Interactable Transitioner")]
	public sealed class TouchInteractableTransitioner : MonoBehaviour, IVisibilityChangedHandler, TouchInteractable.IInteractionStateTransitionHandler
	{
		[SerializeField]
		[Tooltip("Toggles visibility. An invisible control can still be interacted with. This property only has any effect when used with an Image Component.")]
		[CustomObfuscation(rename = false)]
		private bool _visible = true;

		[CustomObfuscation(rename = false)]
		[Bitmask(typeof(TouchInteractable.TransitionTypeFlags))]
		[Tooltip("The transition type(s) to be used when transitioning to various states. Multiple transition types can be used simultaneously.")]
		[SerializeField]
		private TouchInteractable.TransitionTypeFlags _transitionType;

		[Tooltip("Settings using for Color Tint transitions.")]
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private ColorBlock _transitionColorTint = new ColorBlock
		{
			colorMultiplier = 1f,
			disabledColor = new Color(25f / 32f, 25f / 32f, 25f / 32f, 0.5f),
			highlightedColor = Color.white,
			normalColor = Color.white,
			pressedColor = Color.white,
			fadeDuration = 0.1f
		};

		[Tooltip("Settings using for Sprite State transitions.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private SpriteState _transitionSpriteState;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		[Tooltip("Settings using for Animation Trigger transitions.")]
		private AnimationTriggers _transitionAnimationTriggers = new AnimationTriggers();

		[CustomObfuscation(rename = false)]
		[SerializeField]
		[Tooltip("The target Graphic component for interaction state transitions. This should normally be set to an Image component on this GameObject.")]
		private Graphic _targetGraphic;

		[Tooltip("Toggles whether the fade duration is set by incoming transition events. If enabled, the duration of fades for visibility and Color Tint transitions will be synchronized with the event sender.")]
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private bool _syncFadeDurationWithTransitionEvent = true;

		[Tooltip("Toggles whether the color tint is set by incoming transition events. If enabled, the color tint transition of the event sender will override any color tint setting here. This setting overrides Sync Fade Duration With Transition Event.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private bool _syncColorTintWithTransitionEvent;

		private TouchInteractable.InteractionState ULbwqOSIyBtkJxIvbjFvprWNLox;

		public bool visible
		{
			get
			{
				return _visible;
			}
			set
			{
				if (visible != value)
				{
					gsBWXLHgffgyumxKGHWadDMtmCl(value, false);
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public TouchInteractable.TransitionTypeFlags transitionType
		{
			get
			{
				return _transitionType;
			}
			set
			{
				if (_transitionType != value)
				{
					_transitionType = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public ColorBlock transitionColorTint
		{
			get
			{
				return _transitionColorTint;
			}
			set
			{
				_transitionColorTint = value;
				QCALZHBveTZKrIACkwpJsrxWoUa();
			}
		}

		public SpriteState transitionSpriteState
		{
			get
			{
				return _transitionSpriteState;
			}
			set
			{
				if (!_transitionSpriteState.Equals(value))
				{
					_transitionSpriteState = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public AnimationTriggers transitionAnimationTriggers
		{
			get
			{
				return _transitionAnimationTriggers;
			}
			set
			{
				if (_transitionAnimationTriggers != value)
				{
					_transitionAnimationTriggers = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public Graphic targetGraphic
		{
			get
			{
				return _targetGraphic;
			}
			set
			{
				if (!(_targetGraphic == value))
				{
					_targetGraphic = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool syncFadeDurationWithTransitionEvent
		{
			get
			{
				return _syncFadeDurationWithTransitionEvent;
			}
			set
			{
				if (_syncFadeDurationWithTransitionEvent != value)
				{
					_syncFadeDurationWithTransitionEvent = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public bool syncColorTintWithTransitionEvent
		{
			get
			{
				return _syncColorTintWithTransitionEvent;
			}
			set
			{
				if (_syncColorTintWithTransitionEvent != value)
				{
					_syncColorTintWithTransitionEvent = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public Image image
		{
			get
			{
				return _targetGraphic as Image;
			}
			set
			{
				if (!(_targetGraphic == value))
				{
					_targetGraphic = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public Animator animator => base.gameObject.GetComponent<Animator>();

		[CustomObfuscation(rename = false)]
		private TouchInteractableTransitioner()
		{
		}

		[CustomObfuscation(rename = false)]
		private void Awake()
		{
			if (Application.isPlaying)
			{
				if (_targetGraphic == null)
				{
					_targetGraphic = base.gameObject.GetComponent<Graphic>();
				}
				gsBWXLHgffgyumxKGHWadDMtmCl(_visible, true);
			}
		}

		[CustomObfuscation(rename = false)]
		private void OnEnable()
		{
			if (!Application.isPlaying)
			{
				gsBWXLHgffgyumxKGHWadDMtmCl(_visible, true);
			}
			RTzLKMUVXJNkNKQUIjISDSjjEmI(true);
		}

		[CustomObfuscation(rename = false)]
		private void OnDisable()
		{
			NpyQtxBImgFrolnpKEbXsDfFhPc();
		}

		[CustomObfuscation(rename = false)]
		private void OnValidate()
		{
			_transitionColorTint.fadeDuration = Mathf.Max(_transitionColorTint.fadeDuration, 0f);
			if (UnityTools.IsActiveAndEnabled(this))
			{
				fGZvoQzyCVMhmhNMFGvAFbvVRRue(null);
				uwiSqRTfEREYdNjYlgIhdIPaGVVt(Color.white, true);
				yjzxdOBzYdEnSkWigWIAviYvfmu(_transitionAnimationTriggers.normalTrigger);
				RTzLKMUVXJNkNKQUIjISDSjjEmI(true);
			}
			rcguwOLFHMwsDhYAeVEUHWpWuqg();
		}

		[CustomObfuscation(rename = false)]
		private void Reset()
		{
			_targetGraphic = base.gameObject.GetComponent<Graphic>();
		}

		[CustomObfuscation(rename = false)]
		private void OnCanvasGroupWasChanged()
		{
			rcguwOLFHMwsDhYAeVEUHWpWuqg();
		}

		[CustomObfuscation(rename = false)]
		private void OnAnimationPropertiesWereApplied()
		{
			rcguwOLFHMwsDhYAeVEUHWpWuqg();
		}

		private void QCALZHBveTZKrIACkwpJsrxWoUa()
		{
			rcguwOLFHMwsDhYAeVEUHWpWuqg();
		}

		private void rcguwOLFHMwsDhYAeVEUHWpWuqg()
		{
			if (!Application.isPlaying)
			{
				RTzLKMUVXJNkNKQUIjISDSjjEmI(true);
			}
			else
			{
				RTzLKMUVXJNkNKQUIjISDSjjEmI(false);
			}
		}

		private void RTzLKMUVXJNkNKQUIjISDSjjEmI(bool P_0)
		{
			mbnuIVcMFbzLglsOlticXCrOXsy(ULbwqOSIyBtkJxIvbjFvprWNLox, P_0);
		}

		private void gsBWXLHgffgyumxKGHWadDMtmCl(bool P_0, bool P_1)
		{
			if (_visible != P_0 || P_1)
			{
				_visible = P_0;
			}
		}

		private bool XHCmLqQbfbOQEHrLewtLvMLYyJY()
		{
			return UnityTools.IsActiveAndEnabled(this);
		}

		private void NpyQtxBImgFrolnpKEbXsDfFhPc()
		{
			string normalTrigger = _transitionAnimationTriggers.normalTrigger;
			if ((_transitionType & TouchInteractable.TransitionTypeFlags.ColorTint) != 0)
			{
				uwiSqRTfEREYdNjYlgIhdIPaGVVt(Color.white, true);
			}
			if ((_transitionType & TouchInteractable.TransitionTypeFlags.SpriteSwap) != 0)
			{
				fGZvoQzyCVMhmhNMFGvAFbvVRRue(null);
			}
			if ((_transitionType & TouchInteractable.TransitionTypeFlags.Animation) != 0)
			{
				yjzxdOBzYdEnSkWigWIAviYvfmu(normalTrigger);
			}
		}

		private void mbnuIVcMFbzLglsOlticXCrOXsy(TouchInteractable.InteractionState P_0, bool P_1)
		{
			Color color;
			Sprite sprite;
			string text;
			switch (P_0)
			{
			case TouchInteractable.InteractionState.Normal:
				color = _transitionColorTint.normalColor;
				sprite = null;
				text = _transitionAnimationTriggers.normalTrigger;
				break;
			case TouchInteractable.InteractionState.Highlighted:
				color = _transitionColorTint.highlightedColor;
				sprite = _transitionSpriteState.highlightedSprite;
				text = _transitionAnimationTriggers.highlightedTrigger;
				break;
			case TouchInteractable.InteractionState.Pressed:
				color = _transitionColorTint.pressedColor;
				sprite = _transitionSpriteState.pressedSprite;
				text = _transitionAnimationTriggers.pressedTrigger;
				break;
			case TouchInteractable.InteractionState.Disabled:
				color = _transitionColorTint.disabledColor;
				sprite = _transitionSpriteState.disabledSprite;
				text = _transitionAnimationTriggers.disabledTrigger;
				break;
			default:
				color = Color.black;
				sprite = null;
				text = string.Empty;
				break;
			}
			bool flag = (_transitionType & TouchInteractable.TransitionTypeFlags.ColorTint) != 0;
			if (!flag)
			{
				color = Color.white;
			}
			if (!_visible)
			{
				color.a = 0f;
			}
			if (base.gameObject.activeInHierarchy)
			{
				if (flag)
				{
					uwiSqRTfEREYdNjYlgIhdIPaGVVt(color * _transitionColorTint.colorMultiplier, P_1);
				}
				else
				{
					uwiSqRTfEREYdNjYlgIhdIPaGVVt(color, P_1);
				}
				if ((_transitionType & TouchInteractable.TransitionTypeFlags.SpriteSwap) != 0)
				{
					fGZvoQzyCVMhmhNMFGvAFbvVRRue(sprite);
				}
				if ((_transitionType & TouchInteractable.TransitionTypeFlags.Animation) != 0)
				{
					yjzxdOBzYdEnSkWigWIAviYvfmu(text);
				}
			}
		}

		private void uwiSqRTfEREYdNjYlgIhdIPaGVVt(Color P_0, bool P_1)
		{
			if (!(_targetGraphic == null))
			{
				_targetGraphic.CrossFadeColor(P_0, P_1 ? 0f : _transitionColorTint.fadeDuration, ignoreTimeScale: true, useAlpha: true);
			}
		}

		private void fGZvoQzyCVMhmhNMFGvAFbvVRRue(Sprite P_0)
		{
			if (!(image == null))
			{
				image.overrideSprite = P_0;
			}
		}

		private void yjzxdOBzYdEnSkWigWIAviYvfmu(string P_0)
		{
			if ((_transitionType & TouchInteractable.TransitionTypeFlags.Animation) != 0 && !(animator == null) && UnityTools.IsActiveAndEnabled(animator) && !(animator.runtimeAnimatorController == null) && !string.IsNullOrEmpty(P_0))
			{
				animator.ResetTrigger(_transitionAnimationTriggers.normalTrigger);
				animator.ResetTrigger(_transitionAnimationTriggers.pressedTrigger);
				animator.ResetTrigger(_transitionAnimationTriggers.highlightedTrigger);
				animator.ResetTrigger(_transitionAnimationTriggers.disabledTrigger);
				animator.SetTrigger(P_0);
			}
		}

		public void OnInteractionStateTransition(TouchInteractable.InteractionStateTransitionArgs args)
		{
			ULbwqOSIyBtkJxIvbjFvprWNLox = args.state;
			if (_syncFadeDurationWithTransitionEvent)
			{
				_transitionColorTint.fadeDuration = args.duration;
			}
			if (_syncColorTintWithTransitionEvent)
			{
				if ((_transitionType & TouchInteractable.TransitionTypeFlags.ColorTint) == 0)
				{
					_transitionType |= TouchInteractable.TransitionTypeFlags.ColorTint;
				}
				if (args.sender != null)
				{
					_transitionColorTint = args.sender.transitionColorTint;
				}
			}
			if (Application.isPlaying)
			{
				RTzLKMUVXJNkNKQUIjISDSjjEmI(false);
			}
			else
			{
				OnValidate();
			}
		}

		public void OnVisibilityChanged(bool state)
		{
			visible = state;
		}
	}
}
