namespace Rewired.HID
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal static class SpecialDevices
	{
		private class aCPevxCbbWdlJUAWXuMoNJoWIcQ
		{
			public readonly ushort vPXJpqINRqPFfbvxiOgRleAPgZX;

			public readonly ushort HobfqJsoBexlFijbsSVcDQthfKhI;

			public readonly string kmORblydGVuKLhgBcuwFyWnwxXz;

			public readonly bool ootKHwaWGQgsahmBjPBFhGGrIGq;

			public readonly int RokEBQWdLdIwDWSLuXYkZRSZIZT;

			public readonly int MgNwrUmtWjXUjUABBOjtWzPygLi;

			public readonly int UrHJWyAvtpczXBFuvoDWqcQMnWN;

			public readonly float WQITLIACAeFNMdNhleEVvsrIlYQ;

			public aCPevxCbbWdlJUAWXuMoNJoWIcQ(ushort vendorId, ushort productId, string productName, bool hasRelativeAxes, int axisMin, int axisMax, int axisZero, float relToAbsAxisConversionTimeout)
			{
				vPXJpqINRqPFfbvxiOgRleAPgZX = vendorId;
				HobfqJsoBexlFijbsSVcDQthfKhI = productId;
				if (string.IsNullOrEmpty(productName))
				{
					productName = string.Empty;
				}
				kmORblydGVuKLhgBcuwFyWnwxXz = productName;
				ootKHwaWGQgsahmBjPBFhGGrIGq = hasRelativeAxes;
				RokEBQWdLdIwDWSLuXYkZRSZIZT = axisMin;
				MgNwrUmtWjXUjUABBOjtWzPygLi = axisMax;
				UrHJWyAvtpczXBFuvoDWqcQMnWN = axisZero;
				WQITLIACAeFNMdNhleEVvsrIlYQ = relToAbsAxisConversionTimeout;
			}

			public bool fhXPHseQeXOLWfhnNareiFuyqyY(ushort P_0, ushort P_1)
			{
				if (vPXJpqINRqPFfbvxiOgRleAPgZX == P_0)
				{
					return HobfqJsoBexlFijbsSVcDQthfKhI == P_1;
				}
				return false;
			}

			public bool fhXPHseQeXOLWfhnNareiFuyqyY(ushort P_0, ushort P_1, string P_2)
			{
				if (vPXJpqINRqPFfbvxiOgRleAPgZX != P_0 || HobfqJsoBexlFijbsSVcDQthfKhI != P_1)
				{
					if (!string.IsNullOrEmpty(P_2))
					{
						return kmORblydGVuKLhgBcuwFyWnwxXz == P_2;
					}
					return false;
				}
				return true;
			}

			public bool fhXPHseQeXOLWfhnNareiFuyqyY(string P_0)
			{
				if (!string.IsNullOrEmpty(P_0))
				{
					return kmORblydGVuKLhgBcuwFyWnwxXz == P_0;
				}
				return false;
			}
		}

		private const float uVPcvAztCTwoaCRWDdCfjkIFkHwG = 0.034f;

		private static aCPevxCbbWdlJUAWXuMoNJoWIcQ[] RGygbqAcSCfbVpPZHvqvgwAfWNPv = new aCPevxCbbWdlJUAWXuMoNJoWIcQ[3]
		{
			new aCPevxCbbWdlJUAWXuMoNJoWIcQ(1133, 50726, "SpaceNavigator", hasRelativeAxes: true, -350, 350, 0, 0.034f),
			new aCPevxCbbWdlJUAWXuMoNJoWIcQ(1133, 50728, "SpaceNavigator for Notebooks", hasRelativeAxes: true, -350, 350, 0, 0.034f),
			new aCPevxCbbWdlJUAWXuMoNJoWIcQ(1133, 50727, "Space Explorer", hasRelativeAxes: true, -350, 350, 0, 0.034f)
		};

		public static bool RequiresRelativeToAbsoluteAxisConversion(ushort vendorId, ushort productId, string productName = null)
		{
			return jLSWmnbztddBqAjSSZlFQbLRqmm(vendorId, productId, productName)?.ootKHwaWGQgsahmBjPBFhGGrIGq ?? false;
		}

		public static float GetRelativeToAbsoluteAxisEventTimeout(ushort vendorId, ushort productId, string productName = null)
		{
			return jLSWmnbztddBqAjSSZlFQbLRqmm(vendorId, productId, productName)?.WQITLIACAeFNMdNhleEVvsrIlYQ ?? 0f;
		}

		public static bool GetRelativeAxisRanges(ushort vendorId, ushort productId, out int min, out int max, out int zero)
		{
			return GetRelativeAxisRanges(vendorId, productId, null, out min, out max, out zero);
		}

		public static bool GetRelativeAxisRanges(ushort vendorId, ushort productId, string productName, out int min, out int max, out int zero)
		{
			for (int i = 0; i < RGygbqAcSCfbVpPZHvqvgwAfWNPv.Length; i++)
			{
				if (RGygbqAcSCfbVpPZHvqvgwAfWNPv[i].fhXPHseQeXOLWfhnNareiFuyqyY(vendorId, productId) && RGygbqAcSCfbVpPZHvqvgwAfWNPv[i].ootKHwaWGQgsahmBjPBFhGGrIGq)
				{
					min = RGygbqAcSCfbVpPZHvqvgwAfWNPv[i].RokEBQWdLdIwDWSLuXYkZRSZIZT;
					max = RGygbqAcSCfbVpPZHvqvgwAfWNPv[i].MgNwrUmtWjXUjUABBOjtWzPygLi;
					zero = RGygbqAcSCfbVpPZHvqvgwAfWNPv[i].UrHJWyAvtpczXBFuvoDWqcQMnWN;
					return true;
				}
			}
			min = 0;
			max = 0;
			zero = 0;
			return false;
		}

		public static bool IsSupportedSpecialDevice(ushort vendorId, ushort productId, string productName = null)
		{
			return lMyRXbiyBQaVGXUWKVmNlLOpnNi(vendorId, productId, productName);
		}

		private static bool lMyRXbiyBQaVGXUWKVmNlLOpnNi(ushort P_0, ushort P_1, string P_2 = null)
		{
			for (int i = 0; i < RGygbqAcSCfbVpPZHvqvgwAfWNPv.Length; i++)
			{
				if (RGygbqAcSCfbVpPZHvqvgwAfWNPv[i].fhXPHseQeXOLWfhnNareiFuyqyY(P_0, P_1, P_2))
				{
					return true;
				}
			}
			return false;
		}

		private static aCPevxCbbWdlJUAWXuMoNJoWIcQ jLSWmnbztddBqAjSSZlFQbLRqmm(ushort P_0, ushort P_1, string P_2 = null)
		{
			for (int i = 0; i < RGygbqAcSCfbVpPZHvqvgwAfWNPv.Length; i++)
			{
				if (RGygbqAcSCfbVpPZHvqvgwAfWNPv[i].fhXPHseQeXOLWfhnNareiFuyqyY(P_0, P_1, P_2))
				{
					return RGygbqAcSCfbVpPZHvqvgwAfWNPv[i];
				}
			}
			return null;
		}
	}
}
