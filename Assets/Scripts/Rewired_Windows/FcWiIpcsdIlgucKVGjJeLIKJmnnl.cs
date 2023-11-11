using System;

internal struct FcWiIpcsdIlgucKVGjJeLIKJmnnl : IEquatable<FcWiIpcsdIlgucKVGjJeLIKJmnnl>
{
	public static readonly FcWiIpcsdIlgucKVGjJeLIKJmnnl rgExYoaILOXxuNGUtChhrvFJQlU = new FcWiIpcsdIlgucKVGjJeLIKJmnnl(0, 0);

	public int xpumVntKTYPdUAcEeqwWhsPgirN;

	public int RTwQzyWgdmiDfVtyeEaNgdMceZg;

	public FcWiIpcsdIlgucKVGjJeLIKJmnnl(int x, int y)
	{
		xpumVntKTYPdUAcEeqwWhsPgirN = x;
		RTwQzyWgdmiDfVtyeEaNgdMceZg = y;
	}

	public bool Equals(FcWiIpcsdIlgucKVGjJeLIKJmnnl other)
	{
		if (other.xpumVntKTYPdUAcEeqwWhsPgirN == xpumVntKTYPdUAcEeqwWhsPgirN)
		{
			return other.RTwQzyWgdmiDfVtyeEaNgdMceZg == RTwQzyWgdmiDfVtyeEaNgdMceZg;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (object.ReferenceEquals(null, obj))
		{
			return false;
		}
		if ((object)obj.GetType() != typeof(FcWiIpcsdIlgucKVGjJeLIKJmnnl))
		{
			return false;
		}
		return Equals((FcWiIpcsdIlgucKVGjJeLIKJmnnl)obj);
	}

	public override int GetHashCode()
	{
		return (xpumVntKTYPdUAcEeqwWhsPgirN * 397) ^ RTwQzyWgdmiDfVtyeEaNgdMceZg;
	}

	public static bool operator ==(FcWiIpcsdIlgucKVGjJeLIKJmnnl left, FcWiIpcsdIlgucKVGjJeLIKJmnnl right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(FcWiIpcsdIlgucKVGjJeLIKJmnnl left, FcWiIpcsdIlgucKVGjJeLIKJmnnl right)
	{
		return !left.Equals(right);
	}

	public override string ToString()
	{
		return $"({xpumVntKTYPdUAcEeqwWhsPgirN},{RTwQzyWgdmiDfVtyeEaNgdMceZg})";
	}
}
