using System;
using System.Collections;
using Rewired.Utils;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	public abstract class ComponentControl : MonoBehaviour, IComponentControl
	{
		private IComponentController _controller;

		[NonSerialized]
		private bool vqjuhdYKKuBgDKqCJHOYrBTbbEX;

		[NonSerialized]
		private bool SpDcvncXEXnfkshNloHRcVgBcmMk;

		private int _lastUpdateFrame = -1;

		internal abstract bool hasController { get; }

		internal bool initialized => vqjuhdYKKuBgDKqCJHOYrBTbbEX;

		[CustomObfuscation(rename = false)]
		internal ComponentControl()
		{
		}

		public abstract void ClearValue();

		private void mzZtbaiTAjkalvHDspuTPryDDMx()
		{
			int frameCount = Time.frameCount;
			if (_lastUpdateFrame != frameCount)
			{
				_lastUpdateFrame = frameCount;
				EsMhoPqAHoBFPBeDrJCrkGzDsbv();
			}
		}

		void IComponentControl.Update()
		{
			//ILSpy generated this explicit interface implementation from .override directive in mzZtbaiTAjkalvHDspuTPryDDMx
			this.mzZtbaiTAjkalvHDspuTPryDDMx();
		}

		[CustomObfuscation(rename = false)]
		internal virtual void Awake()
		{
			SpDcvncXEXnfkshNloHRcVgBcmMk = true;
		}

		[CustomObfuscation(rename = false)]
		internal virtual void Start()
		{
		}

		[CustomObfuscation(rename = false)]
		internal virtual void OnEnable()
		{
			if (!SpDcvncXEXnfkshNloHRcVgBcmMk)
			{
				vqjuhdYKKuBgDKqCJHOYrBTbbEX = false;
				StartCoroutine(sThlWkzexgasMWtEHUpLHLZTSip());
				SpDcvncXEXnfkshNloHRcVgBcmMk = true;
			}
			else if (Application.isPlaying)
			{
				dmyjjERgjQIVlakFlHoYvIKBXOi();
			}
		}

		[CustomObfuscation(rename = false)]
		internal virtual void OnDisable()
		{
			if (Application.isPlaying)
			{
				qtzhhZOCKStrBjEmBbSptjfacMc();
			}
		}

		[CustomObfuscation(rename = false)]
		internal virtual void OnDestroy()
		{
		}

		[CustomObfuscation(rename = false)]
		internal virtual void OnValidate()
		{
			if (vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				rcguwOLFHMwsDhYAeVEUHWpWuqg();
			}
		}

		[CustomObfuscation(rename = false)]
		internal virtual void OnCanvasGroupChanged()
		{
			if (vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				kVBQGZMwTJReeCPPNgEwMRFzUIf(false, false);
			}
		}

		[CustomObfuscation(rename = false)]
		internal virtual void OnTransformParentChanged()
		{
			if (vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				kVBQGZMwTJReeCPPNgEwMRFzUIf(false, false);
			}
		}

		[CustomObfuscation(rename = false)]
		internal virtual void OnDidApplyAnimationProperties()
		{
			_ = vqjuhdYKKuBgDKqCJHOYrBTbbEX;
		}

		[CustomObfuscation(rename = false)]
		internal virtual void Reset()
		{
			_ = vqjuhdYKKuBgDKqCJHOYrBTbbEX;
		}

		internal virtual void EsMhoPqAHoBFPBeDrJCrkGzDsbv()
		{
		}

		internal virtual bool sTGamvWFKxGXQiXUVibUDPQNCmv()
		{
			vqjuhdYKKuBgDKqCJHOYrBTbbEX = false;
			if (!kVBQGZMwTJReeCPPNgEwMRFzUIf(true, true))
			{
				return false;
			}
			_controller.Register(this);
			return true;
		}

		internal virtual void qtzhhZOCKStrBjEmBbSptjfacMc()
		{
			ClearValue();
			if (!_controller.IsNullOrDestroyed())
			{
				_controller.Deregister(this);
			}
			YWpzYbuwLnICLOIxYOdSdgrbQWU();
			vqjuhdYKKuBgDKqCJHOYrBTbbEX = false;
		}

		internal virtual void vVOkBAFOLrFCgxJvZTjUEsBzcRV()
		{
			if (!_controller.IsNullOrDestroyed())
			{
				YWpzYbuwLnICLOIxYOdSdgrbQWU();
			}
		}

		internal virtual void YWpzYbuwLnICLOIxYOdSdgrbQWU()
		{
			_controller.IsNullOrDestroyed();
		}

		internal virtual void QCALZHBveTZKrIACkwpJsrxWoUa()
		{
			if (vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				rcguwOLFHMwsDhYAeVEUHWpWuqg();
			}
		}

		internal virtual void oFSQYqtEFhhpifGSweyvNVNjYvX()
		{
			_ = vqjuhdYKKuBgDKqCJHOYrBTbbEX;
		}

		internal virtual void ZzMvpwUqDySbOkAZoByNfUfTDITo()
		{
		}

		internal bool XBsbLTtXGPImfIaItQCdVxhsKkCf()
		{
			return UnityTools.IsActiveAndEnabled(this);
		}

		internal bool ANUWGBsjdhAHhWzQiCPQkIHZcKO()
		{
			return this == null;
		}

		internal IComponentController jDfrNqIZbnNpNZYLlGezNVBaGsv()
		{
			return _controller;
		}

		[CustomObfuscation(rename = false)]
		internal abstract IComponentController FindController();

		[CustomObfuscation(rename = false)]
		internal abstract Type GetRequiredControllerType();

		private IEnumerator sThlWkzexgasMWtEHUpLHLZTSip()
		{
			yield return null;
			if (XBsbLTtXGPImfIaItQCdVxhsKkCf())
			{
				OnEnable();
			}
		}

		private void dmyjjERgjQIVlakFlHoYvIKBXOi()
		{
			if (sTGamvWFKxGXQiXUVibUDPQNCmv())
			{
				ZzMvpwUqDySbOkAZoByNfUfTDITo();
				vqjuhdYKKuBgDKqCJHOYrBTbbEX = true;
				vVOkBAFOLrFCgxJvZTjUEsBzcRV();
			}
		}

		private bool kVBQGZMwTJReeCPPNgEwMRFzUIf(bool P_0, bool P_1)
		{
			bool flag = false;
			try
			{
				IComponentController componentController = FindController();
				if (!_controller.IsNullOrDestroyed() && _controller != componentController)
				{
					flag = true;
				}
				_controller = componentController;
				if (_controller == null)
				{
					Type type = GetRequiredControllerType();
					if ((object)type == null)
					{
						type = typeof(IComponentController);
					}
					if (P_1)
					{
						Logger.LogError(type.Name + " could not be found. You must have a component that extends from " + type.Name + " on this or a parent GameObject.");
					}
					throw new Exception();
				}
				if (!P_0 && flag)
				{
					dmyjjERgjQIVlakFlHoYvIKBXOi();
				}
				return true;
			}
			catch
			{
				qtzhhZOCKStrBjEmBbSptjfacMc();
				return false;
			}
		}

		private void rcguwOLFHMwsDhYAeVEUHWpWuqg()
		{
			kVBQGZMwTJReeCPPNgEwMRFzUIf(false, true);
		}

		private void hjgYmHyJQCnqtYbcFFyUangrMibw()
		{
			if (!ANUWGBsjdhAHhWzQiCPQkIHZcKO() && XBsbLTtXGPImfIaItQCdVxhsKkCf())
			{
				EsMhoPqAHoBFPBeDrJCrkGzDsbv();
			}
		}
	}
}
