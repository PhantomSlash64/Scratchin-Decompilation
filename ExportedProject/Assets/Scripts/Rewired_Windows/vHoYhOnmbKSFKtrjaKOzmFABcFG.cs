using System;

internal struct vHoYhOnmbKSFKtrjaKOzmFABcFG : IEquatable<vHoYhOnmbKSFKtrjaKOzmFABcFG>
{
	public static readonly vHoYhOnmbKSFKtrjaKOzmFABcFG rgExYoaILOXxuNGUtChhrvFJQlU = new vHoYhOnmbKSFKtrjaKOzmFABcFG(0f, 0f);

	public static readonly vHoYhOnmbKSFKtrjaKOzmFABcFG SdHccltCppaFNQaIwtUIPLwBooV = rgExYoaILOXxuNGUtChhrvFJQlU;

	public float IhdUbevnPACcpTjOmyFgdvWWgPa;

	public float ksbHcudDWCiqisLbSQkRhnqDJiG;

	public vHoYhOnmbKSFKtrjaKOzmFABcFG(float width, float height)
	{
		IhdUbevnPACcpTjOmyFgdvWWgPa = width;
		ksbHcudDWCiqisLbSQkRhnqDJiG = height;
	}

	public bool Equals(vHoYhOnmbKSFKtrjaKOzmFABcFG other)
	{
		if (other.IhdUbevnPACcpTjOmyFgdvWWgPa == IhdUbevnPACcpTjOmyFgdvWWgPa)
		{
			return other.ksbHcudDWCiqisLbSQkRhnqDJiG == ksbHcudDWCiqisLbSQkRhnqDJiG;
		}
		return false;
	}

	public override bool Equals(object obj)
	{
		if (object.ReferenceEquals(null, obj))
		{
			return false;
		}
		if ((object)obj.GetType() != typeof(vHoYhOnmbKSFKtrjaKOzmFABcFG))
		{
			return false;
		}
		return Equals((vHoYhOnmbKSFKtrjaKOzmFABcFG)obj);
	}

	public override int GetHashCode()
	{
		return (IhdUbevnPACcpTjOmyFgdvWWgPa.GetHashCode() * 397) ^ ksbHcudDWCiqisLbSQkRhnqDJiG.GetHashCode();
	}

	public static bool operator ==(vHoYhOnmbKSFKtrjaKOzmFABcFG left, vHoYhOnmbKSFKtrjaKOzmFABcFG right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(vHoYhOnmbKSFKtrjaKOzmFABcFG left, vHoYhOnmbKSFKtrjaKOzmFABcFG right)
	{
		return !left.Equals(right);
	}

	public override string ToString()
	{
		return $"({IhdUbevnPACcpTjOmyFgdvWWgPa},{ksbHcudDWCiqisLbSQkRhnqDJiG})";
	}
}
