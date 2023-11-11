using System.ComponentModel;
using UnityEngine;

namespace Rewired.Internal
{
	[RequireComponent(typeof(InputManager_Base))]
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public class OnGUIHelper : MonoBehaviour
	{
		private InputManager_Base PXoaWZfLoapsgtctcTOzaohJoYM;

		[CustomObfuscation(rename = false)]
		private void Awake()
		{
			PXoaWZfLoapsgtctcTOzaohJoYM = GetComponent<InputManager_Base>();
		}

		[CustomObfuscation(rename = false)]
		private void OnGUI()
		{
			if (!(PXoaWZfLoapsgtctcTOzaohJoYM == null))
			{
				PXoaWZfLoapsgtctcTOzaohJoYM.OnGUIUpdate();
			}
		}
	}
}
