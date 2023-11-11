using System;
using System.Globalization;

internal struct cGJAaFHuCcUcQEHnLoUbDyyRwyb
{
	private IntPtr HcfdITYsHulBrNwitifSjfoDiNI;

	public static readonly cGJAaFHuCcUcQEHnLoUbDyyRwyb rgExYoaILOXxuNGUtChhrvFJQlU = new cGJAaFHuCcUcQEHnLoUbDyyRwyb(0);

	public cGJAaFHuCcUcQEHnLoUbDyyRwyb(IntPtr size)
	{
		HcfdITYsHulBrNwitifSjfoDiNI = size;
	}

	private unsafe cGJAaFHuCcUcQEHnLoUbDyyRwyb(void* size)
	{
		HcfdITYsHulBrNwitifSjfoDiNI = new IntPtr(size);
	}

	public cGJAaFHuCcUcQEHnLoUbDyyRwyb(int size)
	{
		HcfdITYsHulBrNwitifSjfoDiNI = new IntPtr(size);
	}

	public cGJAaFHuCcUcQEHnLoUbDyyRwyb(long size)
	{
		HcfdITYsHulBrNwitifSjfoDiNI = new IntPtr(size);
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, "{0}", new object[1] { HcfdITYsHulBrNwitifSjfoDiNI });
	}

	public string umnBZHBwpNvgsKPzDHsitCHPMNK(string P_0)
	{
		if (P_0 == null)
		{
			return ToString();
		}
		return string.Format(CultureInfo.CurrentCulture, "{0}", new object[1] { HcfdITYsHulBrNwitifSjfoDiNI.ToString(P_0) });
	}

	public override int GetHashCode()
	{
		return HcfdITYsHulBrNwitifSjfoDiNI.ToInt32();
	}

	public bool pIBapvbJVOSPdWupDvkQdQSXKYP(cGJAaFHuCcUcQEHnLoUbDyyRwyb P_0)
	{
		return HcfdITYsHulBrNwitifSjfoDiNI == P_0.HcfdITYsHulBrNwitifSjfoDiNI;
	}

	public override bool Equals(object value)
	{
		if (value == null)
		{
			return false;
		}
		if (!object.ReferenceEquals(value.GetType(), typeof(cGJAaFHuCcUcQEHnLoUbDyyRwyb)))
		{
			return false;
		}
		return pIBapvbJVOSPdWupDvkQdQSXKYP((cGJAaFHuCcUcQEHnLoUbDyyRwyb)value);
	}

	public static cGJAaFHuCcUcQEHnLoUbDyyRwyb operator +(cGJAaFHuCcUcQEHnLoUbDyyRwyb left, cGJAaFHuCcUcQEHnLoUbDyyRwyb right)
	{
		return new cGJAaFHuCcUcQEHnLoUbDyyRwyb(left.HcfdITYsHulBrNwitifSjfoDiNI.ToInt64() + right.HcfdITYsHulBrNwitifSjfoDiNI.ToInt64());
	}

	public static cGJAaFHuCcUcQEHnLoUbDyyRwyb operator +(cGJAaFHuCcUcQEHnLoUbDyyRwyb value)
	{
		return value;
	}

	public static cGJAaFHuCcUcQEHnLoUbDyyRwyb operator -(cGJAaFHuCcUcQEHnLoUbDyyRwyb left, cGJAaFHuCcUcQEHnLoUbDyyRwyb right)
	{
		return new cGJAaFHuCcUcQEHnLoUbDyyRwyb(left.HcfdITYsHulBrNwitifSjfoDiNI.ToInt64() - right.HcfdITYsHulBrNwitifSjfoDiNI.ToInt64());
	}

	public static cGJAaFHuCcUcQEHnLoUbDyyRwyb operator -(cGJAaFHuCcUcQEHnLoUbDyyRwyb value)
	{
		return new cGJAaFHuCcUcQEHnLoUbDyyRwyb(-value.HcfdITYsHulBrNwitifSjfoDiNI.ToInt64());
	}

	public static cGJAaFHuCcUcQEHnLoUbDyyRwyb operator *(int scale, cGJAaFHuCcUcQEHnLoUbDyyRwyb value)
	{
		return new cGJAaFHuCcUcQEHnLoUbDyyRwyb(scale * value.HcfdITYsHulBrNwitifSjfoDiNI.ToInt64());
	}

	public static cGJAaFHuCcUcQEHnLoUbDyyRwyb operator *(cGJAaFHuCcUcQEHnLoUbDyyRwyb value, int scale)
	{
		return new cGJAaFHuCcUcQEHnLoUbDyyRwyb(scale * value.HcfdITYsHulBrNwitifSjfoDiNI.ToInt64());
	}

	public static cGJAaFHuCcUcQEHnLoUbDyyRwyb operator /(cGJAaFHuCcUcQEHnLoUbDyyRwyb value, int scale)
	{
		return new cGJAaFHuCcUcQEHnLoUbDyyRwyb(value.HcfdITYsHulBrNwitifSjfoDiNI.ToInt64() / scale);
	}

	public static bool operator ==(cGJAaFHuCcUcQEHnLoUbDyyRwyb left, cGJAaFHuCcUcQEHnLoUbDyyRwyb right)
	{
		return left.pIBapvbJVOSPdWupDvkQdQSXKYP(right);
	}

	public static bool operator !=(cGJAaFHuCcUcQEHnLoUbDyyRwyb left, cGJAaFHuCcUcQEHnLoUbDyyRwyb right)
	{
		return !left.pIBapvbJVOSPdWupDvkQdQSXKYP(right);
	}

	public static implicit operator int(cGJAaFHuCcUcQEHnLoUbDyyRwyb value)
	{
		return value.HcfdITYsHulBrNwitifSjfoDiNI.ToInt32();
	}

	public static implicit operator long(cGJAaFHuCcUcQEHnLoUbDyyRwyb value)
	{
		return value.HcfdITYsHulBrNwitifSjfoDiNI.ToInt64();
	}

	public static implicit operator cGJAaFHuCcUcQEHnLoUbDyyRwyb(int value)
	{
		return new cGJAaFHuCcUcQEHnLoUbDyyRwyb(value);
	}

	public static implicit operator cGJAaFHuCcUcQEHnLoUbDyyRwyb(long value)
	{
		return new cGJAaFHuCcUcQEHnLoUbDyyRwyb(value);
	}

	public static implicit operator cGJAaFHuCcUcQEHnLoUbDyyRwyb(IntPtr value)
	{
		return new cGJAaFHuCcUcQEHnLoUbDyyRwyb(value);
	}

	public static implicit operator IntPtr(cGJAaFHuCcUcQEHnLoUbDyyRwyb value)
	{
		return value.HcfdITYsHulBrNwitifSjfoDiNI;
	}

	public unsafe static implicit operator cGJAaFHuCcUcQEHnLoUbDyyRwyb(void* value)
	{
		return new cGJAaFHuCcUcQEHnLoUbDyyRwyb(value);
	}

	public unsafe static implicit operator void*(cGJAaFHuCcUcQEHnLoUbDyyRwyb value)
	{
		return (void*)value.HcfdITYsHulBrNwitifSjfoDiNI;
	}
}
