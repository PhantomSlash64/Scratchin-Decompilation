namespace Rewired
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	[CustomObfuscation(rename = false)]
	internal struct RewiredVersion
	{
		public int version1;

		public int version2;

		public int version3;

		public int version4;

		public string unityVersion;

		public RewiredVersion(int version1, int version2, int version3, int version4, string unityVersion)
		{
			this.version1 = version1;
			this.version2 = version2;
			this.version3 = version3;
			this.version4 = version4;
			this.unityVersion = unityVersion;
		}

		public RewiredVersion(string versionString)
		{
			if (!string.IsNullOrEmpty(versionString))
			{
				string[] array = versionString.Split('.');
				if (array.Length >= 4 && int.TryParse(array[0], out version1) && int.TryParse(array[1], out version2) && int.TryParse(array[2], out version3) && int.TryParse(array[3], out version4))
				{
					if (array.Length > 4)
					{
						unityVersion = array[4];
					}
					else
					{
						unityVersion = string.Empty;
					}
					return;
				}
			}
			version1 = 0;
			version2 = 0;
			version3 = 0;
			version4 = 0;
			unityVersion = string.Empty;
		}

		public override bool Equals(object obj)
		{
			if (object.ReferenceEquals(obj, null))
			{
				return false;
			}
			if (!(obj is RewiredVersion rewiredVersion))
			{
				return false;
			}
			return this == rewiredVersion;
		}

		public override int GetHashCode()
		{
			int num = 17;
			num = num * 29 + version1.GetHashCode();
			num = num * 29 + version2.GetHashCode();
			num = num * 29 + version3.GetHashCode();
			num = num * 29 + version4.GetHashCode();
			return num * 29 + unityVersion.GetHashCode();
		}

		public override string ToString()
		{
			string text = version1 + "." + version2 + "." + version3 + "." + version4;
			if (!string.IsNullOrEmpty(unityVersion))
			{
				text = text + "." + unityVersion;
			}
			return text;
		}

		public static bool operator ==(RewiredVersion a, RewiredVersion b)
		{
			if (object.ReferenceEquals(a, b))
			{
				return true;
			}
			if (a.version1 == b.version1 && a.version2 == b.version2 && a.version3 == b.version3 && a.version4 == b.version4)
			{
				return string.Equals(a.unityVersion, b.unityVersion);
			}
			return false;
		}

		public static bool operator !=(RewiredVersion a, RewiredVersion b)
		{
			return !(a == b);
		}

		public static bool operator >(RewiredVersion a, RewiredVersion b)
		{
			if (a == b)
			{
				return false;
			}
			if (a.version1 > b.version1)
			{
				return true;
			}
			if (a.version1 < b.version1)
			{
				return false;
			}
			if (a.version2 > b.version2)
			{
				return true;
			}
			if (a.version2 < b.version2)
			{
				return false;
			}
			if (a.version3 > b.version3)
			{
				return true;
			}
			if (a.version3 < b.version3)
			{
				return false;
			}
			if (a.version4 > b.version4)
			{
				return true;
			}
			if (a.version4 < b.version4)
			{
				return false;
			}
			return false;
		}

		public static bool operator <(RewiredVersion a, RewiredVersion b)
		{
			if (a == b)
			{
				return false;
			}
			if (a.version1 < b.version1)
			{
				return true;
			}
			if (a.version1 > b.version1)
			{
				return false;
			}
			if (a.version2 < b.version2)
			{
				return true;
			}
			if (a.version2 > b.version2)
			{
				return false;
			}
			if (a.version3 < b.version3)
			{
				return true;
			}
			if (a.version3 > b.version3)
			{
				return false;
			}
			if (a.version4 < b.version4)
			{
				return true;
			}
			if (a.version4 > b.version4)
			{
				return false;
			}
			return false;
		}
	}
}
