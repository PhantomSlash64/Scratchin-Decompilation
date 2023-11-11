using System;

internal struct QouIElDSSqdWxAzgcXCMLHQoAQK : IEquatable<QouIElDSSqdWxAzgcXCMLHQoAQK>
{
	public static readonly QouIElDSSqdWxAzgcXCMLHQoAQK rgExYoaILOXxuNGUtChhrvFJQlU = new QouIElDSSqdWxAzgcXCMLHQoAQK(0, 0);

	public static readonly QouIElDSSqdWxAzgcXCMLHQoAQK SdHccltCppaFNQaIwtUIPLwBooV = rgExYoaILOXxuNGUtChhrvFJQlU;

	public int IhdUbevnPACcpTjOmyFgdvWWgPa;

	public int ksbHcudDWCiqisLbSQkRhnqDJiG;

	public QouIElDSSqdWxAzgcXCMLHQoAQK(int width, int height)
	{
		IhdUbevnPACcpTjOmyFgdvWWgPa = width;
		ksbHcudDWCiqisLbSQkRhnqDJiG = height;
	}

	public bool Equals(QouIElDSSqdWxAzgcXCMLHQoAQK other)
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
		if ((object)obj.GetType() != typeof(QouIElDSSqdWxAzgcXCMLHQoAQK))
		{
			return false;
		}
		return Equals((QouIElDSSqdWxAzgcXCMLHQoAQK)obj);
	}

	public override int GetHashCode()
	{
		return (IhdUbevnPACcpTjOmyFgdvWWgPa * 397) ^ ksbHcudDWCiqisLbSQkRhnqDJiG;
	}

	public static bool operator ==(QouIElDSSqdWxAzgcXCMLHQoAQK left, QouIElDSSqdWxAzgcXCMLHQoAQK right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(QouIElDSSqdWxAzgcXCMLHQoAQK left, QouIElDSSqdWxAzgcXCMLHQoAQK right)
	{
		return !left.Equals(right);
	}

	public override string ToString()
	{
		return $"({IhdUbevnPACcpTjOmyFgdvWWgPa},{ksbHcudDWCiqisLbSQkRhnqDJiG})";
	}
}
