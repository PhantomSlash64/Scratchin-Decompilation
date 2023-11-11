using Rewired.Interfaces;
using Rewired.Internal;
using UnityEngine;

namespace Rewired.Dev.Tools
{
	[RequireComponent(typeof(Rewired.Internal.GUIText))]
	[AddComponentMenu("")]
	public sealed class DirectInputJoystickElementIdentifier : MonoBehaviour
	{
		private IElementIdentifierTool jUbelwfMtzSFWdthhbIWGekKNOm;

		public void Awake()
		{
			if (nNQBlJwxmrDyUwEPEFQDeMnXLFde())
			{
				if (base.transform.position != Vector3.zero)
				{
					base.transform.position = Vector3.zero;
				}
				jUbelwfMtzSFWdthhbIWGekKNOm = XGlzZxXeJIZWLxkQirgkskjObTg.alotxluMWAUxHKeMGSCozzOoqGZ("Rewired_Windows", "DirectInput") as IElementIdentifierTool;
				if (jUbelwfMtzSFWdthhbIWGekKNOm == null)
				{
					Logger.LogError("DirectInput Tool could not be initialized! Make sure the correct platform mode is chosen in Unity's Build Settings.");
				}
				else
				{
					jUbelwfMtzSFWdthhbIWGekKNOm.Initialize(Rewired.Internal.GUIText.CreateLogger(base.gameObject));
				}
			}
		}

		public void Start()
		{
			if (jUbelwfMtzSFWdthhbIWGekKNOm != null)
			{
				jUbelwfMtzSFWdthhbIWGekKNOm.Start();
			}
		}

		public void Update()
		{
			if (jUbelwfMtzSFWdthhbIWGekKNOm != null)
			{
				jUbelwfMtzSFWdthhbIWGekKNOm.Update();
			}
		}

		public void OnDestroy()
		{
			if (jUbelwfMtzSFWdthhbIWGekKNOm != null)
			{
				jUbelwfMtzSFWdthhbIWGekKNOm.OnDestroy();
			}
			jUbelwfMtzSFWdthhbIWGekKNOm = null;
		}

		private bool nNQBlJwxmrDyUwEPEFQDeMnXLFde()
		{
			InputManager_Base[] array = (InputManager_Base[])Object.FindObjectsOfType(typeof(InputManager_Base));
			if (array == null || array.Length == 0)
			{
				Logger.LogError("No active Rewired Input Manager was found in the scene! You must create a Rewired Input Manager for the tool to function.");
				return false;
			}
			return true;
		}
	}
}
