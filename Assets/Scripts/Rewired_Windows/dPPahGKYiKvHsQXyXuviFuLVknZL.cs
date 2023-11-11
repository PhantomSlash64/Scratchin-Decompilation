using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Size = 4)]
internal struct dPPahGKYiKvHsQXyXuviFuLVknZL : IEquatable<dPPahGKYiKvHsQXyXuviFuLVknZL>
{
	private int SjGMZDpwFuNLgiSmUOKKWEqKqjN;

	public dPPahGKYiKvHsQXyXuviFuLVknZL(bool boolValue)
	{
		SjGMZDpwFuNLgiSmUOKKWEqKqjN = (boolValue ? 1 : 0);
	}

	public bool Equals(dPPahGKYiKvHsQXyXuviFuLVknZL other)
	{
		return SjGMZDpwFuNLgiSmUOKKWEqKqjN == other.SjGMZDpwFuNLgiSmUOKKWEqKqjN;
	}

	public override bool Equals(object obj)
	{
		if (object.ReferenceEquals(null, obj))
		{
			return false;
		}
		if (obj is dPPahGKYiKvHsQXyXuviFuLVknZL)
		{
			return Equals((dPPahGKYiKvHsQXyXuviFuLVknZL)obj);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return SjGMZDpwFuNLgiSmUOKKWEqKqjN;
	}

	public static bool operator ==(dPPahGKYiKvHsQXyXuviFuLVknZL left, dPPahGKYiKvHsQXyXuviFuLVknZL right)
	{
		return left.Equals(right);
	}

	public static bool operator !=(dPPahGKYiKvHsQXyXuviFuLVknZL left, dPPahGKYiKvHsQXyXuviFuLVknZL right)
	{
		return !left.Equals(right);
	}

	public static implicit operator bool(dPPahGKYiKvHsQXyXuviFuLVknZL booleanValue)
	{
		return booleanValue.SjGMZDpwFuNLgiSmUOKKWEqKqjN != 0;
	}

	public static implicit operator dPPahGKYiKvHsQXyXuviFuLVknZL(bool boolValue)
	{
		return new dPPahGKYiKvHsQXyXuviFuLVknZL(boolValue);
	}

	public override string ToString()
	{
		return $"{SjGMZDpwFuNLgiSmUOKKWEqKqjN != 0}";
	}
}
