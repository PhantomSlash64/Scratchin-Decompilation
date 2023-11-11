using Rewired.Interfaces;
using Rewired.Internal;
using UnityEngine;

namespace Rewired.Dev.Tools
{
	[AddComponentMenu("")]
	[RequireComponent(typeof(Rewired.Internal.GUIText))]
	public sealed class UnityJoystickElementIdentifier : MonoBehaviour
	{
		private IElementIdentifierTool jUbelwfMtzSFWdthhbIWGekKNOm;

		public void Awake()
		{
			jUbelwfMtzSFWdthhbIWGekKNOm = new MidhwdEpAgeQchCqDaHVqRFpvaY();
			jUbelwfMtzSFWdthhbIWGekKNOm.Initialize(Rewired.Internal.GUIText.CreateLogger(base.gameObject));
		}

		public void Start()
		{
			jUbelwfMtzSFWdthhbIWGekKNOm.Start();
		}

		public void Update()
		{
			jUbelwfMtzSFWdthhbIWGekKNOm.Update();
		}

		public void OnDestroy()
		{
			jUbelwfMtzSFWdthhbIWGekKNOm.OnDestroy();
		}
	}
}
