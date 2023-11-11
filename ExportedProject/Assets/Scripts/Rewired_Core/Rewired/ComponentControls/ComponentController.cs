using System;
using System.Collections;
using System.Collections.Generic;
using Rewired.Utils;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[DisallowMultipleComponent]
	public abstract class ComponentController : MonoBehaviour, IRegistrar<IComponentControl>, IComponentController
	{
		[NonSerialized]
		private bool vqjuhdYKKuBgDKqCJHOYrBTbbEX;

		[NonSerialized]
		private bool SpDcvncXEXnfkshNloHRcVgBcmMk;

		private List<IComponentControl> _controls = new List<IComponentControl>(10);

		internal bool initialized => vqjuhdYKKuBgDKqCJHOYrBTbbEX;

		[CustomObfuscation(rename = false)]
		internal ComponentController()
		{
		}

		[CustomObfuscation(rename = false)]
		internal virtual void Awake()
		{
			SpDcvncXEXnfkshNloHRcVgBcmMk = true;
		}

		[CustomObfuscation(rename = false)]
		internal virtual void Update()
		{
			if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				return;
			}
			for (int num = _controls.Count - 1; num >= 0; num--)
			{
				IComponentControl componentControl = _controls[num];
				if (componentControl.IsNullOrDestroyed())
				{
					_controls.RemoveAt(num);
				}
				else
				{
					componentControl.Update();
				}
			}
		}

		[CustomObfuscation(rename = false)]
		internal virtual void OnEnable()
		{
			if (!SpDcvncXEXnfkshNloHRcVgBcmMk)
			{
				StartCoroutine(msuhjgAjeciJYeNRfsiNBsfVQEJ());
				SpDcvncXEXnfkshNloHRcVgBcmMk = true;
			}
			else
			{
				dmyjjERgjQIVlakFlHoYvIKBXOi();
			}
		}

		[CustomObfuscation(rename = false)]
		internal virtual void OnDisable()
		{
			if (vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				YWpzYbuwLnICLOIxYOdSdgrbQWU();
			}
		}

		[CustomObfuscation(rename = false)]
		internal virtual void OnValidate()
		{
			if (vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				QCALZHBveTZKrIACkwpJsrxWoUa();
			}
		}

		[CustomObfuscation(rename = false)]
		internal virtual void OnDestroy()
		{
			_controls.Clear();
		}

		internal virtual bool sTGamvWFKxGXQiXUVibUDPQNCmv()
		{
			return true;
		}

		internal virtual void vVOkBAFOLrFCgxJvZTjUEsBzcRV()
		{
			YWpzYbuwLnICLOIxYOdSdgrbQWU();
		}

		internal virtual void YWpzYbuwLnICLOIxYOdSdgrbQWU()
		{
		}

		private void HUDUTFQLiHcZvqXpHBAyfnFgbuRa(IComponentControl P_0)
		{
			if (!P_0.IsNullOrDestroyed())
			{
				ListTools.AddIfUnique(_controls, P_0);
			}
		}

		void IRegistrar<IComponentControl>.Register(IComponentControl P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in HUDUTFQLiHcZvqXpHBAyfnFgbuRa
			this.HUDUTFQLiHcZvqXpHBAyfnFgbuRa(P_0);
		}

		private void yTaTnUmOkjbAvtxpKhFSHfndruY(IComponentControl P_0)
		{
			if (!P_0.IsNullOrDestroyed())
			{
				_controls.Remove(P_0);
			}
		}

		void IRegistrar<IComponentControl>.Deregister(IComponentControl P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in yTaTnUmOkjbAvtxpKhFSHfndruY
			this.yTaTnUmOkjbAvtxpKhFSHfndruY(P_0);
		}

		public virtual void ClearControlValues()
		{
			if (!vqjuhdYKKuBgDKqCJHOYrBTbbEX)
			{
				return;
			}
			for (int num = _controls.Count - 1; num >= 0; num--)
			{
				if (_controls[num].IsNullOrDestroyed())
				{
					_controls.RemoveAt(num);
				}
				else
				{
					_controls[num].ClearValue();
				}
			}
		}

		private void dmyjjERgjQIVlakFlHoYvIKBXOi()
		{
			if (sTGamvWFKxGXQiXUVibUDPQNCmv())
			{
				vqjuhdYKKuBgDKqCJHOYrBTbbEX = true;
				vVOkBAFOLrFCgxJvZTjUEsBzcRV();
			}
		}

		private void QCALZHBveTZKrIACkwpJsrxWoUa()
		{
			_ = initialized;
		}

		private IEnumerator msuhjgAjeciJYeNRfsiNBsfVQEJ()
		{
			yield return null;
			dmyjjERgjQIVlakFlHoYvIKBXOi();
		}
	}
}
