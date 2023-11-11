using System;
using UnityEngine;

namespace SonicBloom.Koreo
{
	[Serializable]
	public class AssetPayload : IPayload
	{
		[Tooltip("The Asset reference stored in the payload.")]
		[SerializeField]
		private UnityEngine.Object mAssetVal;

		public UnityEngine.Object AssetVal
		{
			get
			{
				return mAssetVal;
			}
			set
			{
				mAssetVal = value;
			}
		}

		public static string GetFriendlyName()
		{
			return "Asset";
		}

		public IPayload GetCopy()
		{
			AssetPayload assetPayload = new AssetPayload();
			assetPayload.AssetVal = AssetVal;
			return assetPayload;
		}
	}
}
