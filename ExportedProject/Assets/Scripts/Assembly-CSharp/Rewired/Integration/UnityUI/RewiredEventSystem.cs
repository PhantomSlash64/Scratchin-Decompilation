using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
	[AddComponentMenu("Rewired/Rewired Event System")]
	public class RewiredEventSystem : EventSystem
	{
		[Tooltip("If enabled, the Event System will be updated every frame even if other Event Systems are enabled. Otherwise, only EventSystem.current will be updated.")]
		[SerializeField]
		private bool _alwaysUpdate;

		public bool alwaysUpdate
		{
			get
			{
				return _alwaysUpdate;
			}
			set
			{
				_alwaysUpdate = value;
			}
		}

		protected override void Update()
		{
			if (alwaysUpdate)
			{
				EventSystem eventSystem = EventSystem.current;
				if (eventSystem != this)
				{
					EventSystem.current = this;
				}
				try
				{
					base.Update();
					return;
				}
				finally
				{
					if (eventSystem != this)
					{
						EventSystem.current = eventSystem;
					}
				}
			}
			base.Update();
		}
	}
}
