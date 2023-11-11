using System;
using System.Globalization;
using System.Text.RegularExpressions;
using Rewired.Utils;

namespace Rewired
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	[CustomObfuscation(rename = false)]
	internal struct PidVid : IEquatable<PidVid>
	{
		private const string QlkONjmIBPDxsCvYrIuGEYvEOmwN = "[^a-fA-F0-9]";

		public ushort productId;

		public ushort vendorId;

		public bool isZero
		{
			get
			{
				if (vendorId == 0)
				{
					return productId == 0;
				}
				return false;
			}
		}

		public PidVid(ushort productId, ushort vendorId)
		{
			this.productId = productId;
			this.vendorId = vendorId;
		}

		public PidVid(string pidVid)
		{
			if (string.IsNullOrEmpty(GiLTIKMuUDjEYJQJQBhzkUAotxI(pidVid)))
			{
				productId = 0;
				vendorId = 0;
				return;
			}
			try
			{
				productId = ushort.Parse(pidVid.Substring(0, 4), NumberStyles.AllowHexSpecifier);
				vendorId = ushort.Parse(pidVid.Substring(4, 4), NumberStyles.AllowHexSpecifier);
			}
			catch
			{
				productId = 0;
				vendorId = 0;
			}
		}

		public PidVid(Guid productGuid)
			: this(productGuid.ToString().Substring(0, 8))
		{
		}

		public bool Equals(string pidVid)
		{
			return bPptKTPKKtfnLYqqrBSuEkbhIgo(GiLTIKMuUDjEYJQJQBhzkUAotxI(pidVid));
		}

		public Guid ToProductGuid()
		{
			return MiscTools.CreateHIDProductGuid(vendorId, productId);
		}

		private bool bPptKTPKKtfnLYqqrBSuEkbhIgo(string P_0)
		{
			if (string.IsNullOrEmpty(P_0) || P_0.Length < 8)
			{
				return false;
			}
			try
			{
				if (productId != ushort.Parse(P_0.Substring(0, 4), NumberStyles.AllowHexSpecifier))
				{
					return false;
				}
				return vendorId == ushort.Parse(P_0.Substring(4, 4), NumberStyles.AllowHexSpecifier);
			}
			catch
			{
				return false;
			}
		}

		public override bool Equals(object obj)
		{
			if (!(obj is PidVid pidVid))
			{
				return false;
			}
			if (pidVid.vendorId == vendorId)
			{
				return pidVid.productId == productId;
			}
			return false;
		}

		public override int GetHashCode()
		{
			int num = 17;
			num = num * 29 + vendorId.GetHashCode();
			return num * 29 + productId.GetHashCode();
		}

		public bool Equals(PidVid other)
		{
			if (vendorId == other.vendorId)
			{
				return productId == other.productId;
			}
			return false;
		}

		public static bool operator ==(PidVid x, PidVid y)
		{
			if (x.vendorId == y.vendorId)
			{
				return x.productId == y.productId;
			}
			return false;
		}

		public static bool operator !=(PidVid x, PidVid y)
		{
			return !(x == y);
		}

		public override string ToString()
		{
			return productId.ToString("x4") + vendorId.ToString("x4");
		}

		public static bool ArrayContains(string[] pidVids, ref PidVid vidPid)
		{
			if (pidVids == null)
			{
				return false;
			}
			for (int i = 0; i < pidVids.Length; i++)
			{
				if (vidPid.Equals(pidVids[i]))
				{
					return true;
				}
			}
			return false;
		}

		private static string GiLTIKMuUDjEYJQJQBhzkUAotxI(string P_0)
		{
			if (string.IsNullOrEmpty(P_0))
			{
				return null;
			}
			if (Regex.IsMatch(P_0, "[^a-fA-F0-9]"))
			{
				P_0 = Regex.Replace(P_0, "[^a-fA-F0-9]", "");
			}
			if (string.IsNullOrEmpty(P_0))
			{
				return null;
			}
			if (P_0.Length < 8)
			{
				return null;
			}
			return P_0;
		}
	}
}
