using Rewired.Utils;
using UnityEngine;

namespace Rewired
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	internal static class UnityInputHelper
	{
		private class gEsdgVBZHTOvdDAbwMJTZRLvPxOl
		{
			public string[] bFcmhobRSzSgJJkcPcrVLHPiWbm;

			public string[] ifqVRInjAzRYJsVFyORpqnnqXsX;

			public gEsdgVBZHTOvdDAbwMJTZRLvPxOl(int joystickIndex)
			{
				bFcmhobRSzSgJJkcPcrVLHPiWbm = new string[29];
				for (int i = 0; i < bFcmhobRSzSgJJkcPcrVLHPiWbm.Length; i++)
				{
					bFcmhobRSzSgJJkcPcrVLHPiWbm[i] = UnityTools.GetUnityInputAxisName(joystickIndex, i);
				}
				if (joystickIndex + 1 > 16)
				{
					ifqVRInjAzRYJsVFyORpqnnqXsX = new string[20];
					for (int j = 0; j < ifqVRInjAzRYJsVFyORpqnnqXsX.Length; j++)
					{
						ifqVRInjAzRYJsVFyORpqnnqXsX[j] = UnityTools.GetUnityInputButtonName(joystickIndex, j);
					}
				}
			}
		}

		private static gEsdgVBZHTOvdDAbwMJTZRLvPxOl[] mqdAbRkCKsLDODrmCZPalaGwyaPz;

		static UnityInputHelper()
		{
			mqdAbRkCKsLDODrmCZPalaGwyaPz = new gEsdgVBZHTOvdDAbwMJTZRLvPxOl[16];
			for (int i = 0; i < mqdAbRkCKsLDODrmCZPalaGwyaPz.Length; i++)
			{
				mqdAbRkCKsLDODrmCZPalaGwyaPz[i] = new gEsdgVBZHTOvdDAbwMJTZRLvPxOl(i);
			}
		}

		public static float GetJoystickAxisValueByJoystickId(int joystickId, int axisIndex)
		{
			if (joystickId <= 0 || joystickId > 16)
			{
				return 0f;
			}
			if (axisIndex >= 29)
			{
				return 0f;
			}
			return Input.GetAxis(mqdAbRkCKsLDODrmCZPalaGwyaPz[joystickId - 1].bFcmhobRSzSgJJkcPcrVLHPiWbm[axisIndex]);
		}

		public static float GetJoystickAxisRawValueByJoystickId(int joystickId, int axisIndex)
		{
			if (joystickId <= 0 || joystickId > 16)
			{
				return 0f;
			}
			if (axisIndex >= 29)
			{
				return 0f;
			}
			return Input.GetAxisRaw(mqdAbRkCKsLDODrmCZPalaGwyaPz[joystickId - 1].bFcmhobRSzSgJJkcPcrVLHPiWbm[axisIndex]);
		}

		public static float GetJoystickAxisValueByJoystickIndex(int joystickIndex, int axisIndex)
		{
			return GetJoystickAxisValueByJoystickId(joystickIndex + 1, axisIndex);
		}

		public static float GetJoystickAxisRawValueByJoystickIndex(int joystickIndex, int axisIndex)
		{
			return GetJoystickAxisRawValueByJoystickId(joystickIndex + 1, axisIndex);
		}

		public static bool GetJoystickButtonValueByJoystickId(int joystickId, int buttonIndex)
		{
			if (joystickId <= 0 || joystickId > 16)
			{
				return false;
			}
			if (buttonIndex >= 20)
			{
				return false;
			}
			int num = joystickId - 1;
			if (joystickId <= 16)
			{
				KeyCode key = (KeyCode)(350 + 20 * num + buttonIndex);
				return Input.GetKey(key);
			}
			return Input.GetButton(mqdAbRkCKsLDODrmCZPalaGwyaPz[num].ifqVRInjAzRYJsVFyORpqnnqXsX[buttonIndex]);
		}

		public static bool GetJoystickButtonValueByJoystickIndex(int joystickIndex, int buttonIndex)
		{
			return GetJoystickButtonValueByJoystickId(joystickIndex + 1, buttonIndex);
		}
	}
}
