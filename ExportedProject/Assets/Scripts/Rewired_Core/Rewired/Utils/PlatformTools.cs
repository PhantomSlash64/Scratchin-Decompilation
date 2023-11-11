namespace Rewired.Utils
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal static class PlatformTools
	{
		public static bool IsSysVersionInRange(string min, string max)
		{
			bool flag = !string.IsNullOrEmpty(min);
			bool flag2 = !string.IsNullOrEmpty(max);
			if (!flag && !flag2)
			{
				return true;
			}
			if (UnityTools.isAndroidPlatform)
			{
				if (flag)
				{
					try
					{
						int num = int.Parse(min);
						int androidAPILevel = UnityTools.externalTools.GetAndroidAPILevel();
						if (androidAPILevel < num)
						{
							return false;
						}
					}
					catch
					{
						Logger.LogError("Error parsing minimum OS version.");
						flag = false;
					}
				}
				if (flag2)
				{
					try
					{
						int num2 = int.Parse(max);
						int androidAPILevel2 = UnityTools.externalTools.GetAndroidAPILevel();
						if (androidAPILevel2 > num2)
						{
							return false;
						}
					}
					catch
					{
						Logger.LogError("Error parsing maximum OS version.");
						flag = false;
					}
				}
			}
			return true;
		}
	}
}
