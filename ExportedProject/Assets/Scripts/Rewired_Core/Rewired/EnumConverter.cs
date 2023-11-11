using System;
using System.Collections.Generic;
using Rewired.Config;
using Rewired.Data.Mapping;
using Rewired.Utils.Classes.Utility;

namespace Rewired
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal static class EnumConverter
	{
		public static int ToUpdateLoopTypes(UpdateLoopSetting updateLoopSetting, List<UpdateLoopType> results)
		{
			if (results == null)
			{
				throw new ArgumentNullException("results");
			}
			results.Clear();
			EnumNameValueCache<UpdateLoopSetting> @default = EnumNameValueCache<UpdateLoopSetting>.Default;
			int count = @default.Count;
			for (int i = 0; i < count; i++)
			{
				UpdateLoopSetting valueAt = @default.GetValueAt(i);
				if (valueAt != 0 && (updateLoopSetting & valueAt) != 0)
				{
					results.Add(EnumNameValueCache<UpdateLoopType>.Default.GetValue(@default.GetName((long)valueAt)));
				}
			}
			return results.Count;
		}

		public static AlternateAxisCalibrationType ToAlternateAxisCalibrationType(ThrottleCalibrationMode throttleCalibrationMode)
		{
			return throttleCalibrationMode switch
			{
				ThrottleCalibrationMode.ZeroToOne => AlternateAxisCalibrationType.Default, 
				ThrottleCalibrationMode.NegativeOneToOne => AlternateAxisCalibrationType.ThrottleZeroCenter, 
				_ => throw new NotImplementedException(), 
			};
		}
	}
}
