using System;
using System.ComponentModel;
using Rewired.Utils;
using UnityEngine;

namespace Rewired
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = false)]
	[Browsable(false)]
	public sealed class Initializer : MonoBehaviour
	{
		[SerializeField]
		private GameObject _inputManagerPrefab;

		[SerializeField]
		private bool _destroySelf = true;

		public GameObject inputManagerPrefab
		{
			get
			{
				return _inputManagerPrefab;
			}
			set
			{
				_inputManagerPrefab = value;
			}
		}

		public bool destroySelf
		{
			get
			{
				return _destroySelf;
			}
			set
			{
				_destroySelf = value;
			}
		}

		private void Awake()
		{
			Initialize();
		}

		public bool Initialize()
		{
			try
			{
				if (ReInput.isReady)
				{
					return false;
				}
				if (_inputManagerPrefab == null)
				{
					Logger.LogError("Rewired Input Manager prefab has not been set in the inspector. Cannot initialize Rewired.");
					return false;
				}
				if (UnityTools.GetComponentInSelfOrChildren<InputManager_Base>(_inputManagerPrefab) == null)
				{
					Logger.LogError("Rewired Input Manager component is missing on the prefab.");
					return false;
				}
				GameObject gameObject = UnityTools.Instantiate<GameObject>(_inputManagerPrefab, base.transform.parent, instantiateInWorldSpace: false);
				if (gameObject == null)
				{
					Logger.LogError("Error instantiating prefab.");
					return false;
				}
				string text = gameObject.name;
				if (text.EndsWith("(clone)", StringComparison.OrdinalIgnoreCase))
				{
					gameObject.name = text.Substring(0, text.Length - 7);
				}
				return true;
			}
			catch
			{
				return false;
			}
			finally
			{
				if (destroySelf)
				{
					UnityEngine.Object.Destroy(base.gameObject);
				}
			}
		}
	}
}
