using System;
using System.Globalization;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential)]
internal class GKaTaXXuGGxejnrjgddGkaDcBvc
{
	public IntPtr ONOzRUELvkhUJSYbdUptBCQVURI;

	public GKaTaXXuGGxejnrjgddGkaDcBvc(IntPtr pointer)
	{
		ONOzRUELvkhUJSYbdUptBCQVURI = pointer;
	}

	public unsafe GKaTaXXuGGxejnrjgddGkaDcBvc(void* pointer)
	{
		ONOzRUELvkhUJSYbdUptBCQVURI = new IntPtr(pointer);
	}

	public static explicit operator IntPtr(GKaTaXXuGGxejnrjgddGkaDcBvc value)
	{
		return value.ONOzRUELvkhUJSYbdUptBCQVURI;
	}

	public static implicit operator GKaTaXXuGGxejnrjgddGkaDcBvc(IntPtr value)
	{
		return new GKaTaXXuGGxejnrjgddGkaDcBvc(value);
	}

	public unsafe static implicit operator void*(GKaTaXXuGGxejnrjgddGkaDcBvc value)
	{
		return (void*)value.ONOzRUELvkhUJSYbdUptBCQVURI;
	}

	public unsafe static explicit operator GKaTaXXuGGxejnrjgddGkaDcBvc(void* value)
	{
		return new GKaTaXXuGGxejnrjgddGkaDcBvc(value);
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.CurrentCulture, "{0}", new object[1] { ONOzRUELvkhUJSYbdUptBCQVURI });
	}

	public string umnBZHBwpNvgsKPzDHsitCHPMNK(string P_0)
	{
		if (P_0 == null)
		{
			return ToString();
		}
		return string.Format(CultureInfo.CurrentCulture, "{0}", new object[1] { ONOzRUELvkhUJSYbdUptBCQVURI.ToString(P_0) });
	}

	public override int GetHashCode()
	{
		return ONOzRUELvkhUJSYbdUptBCQVURI.ToInt32();
	}

	public bool pIBapvbJVOSPdWupDvkQdQSXKYP(GKaTaXXuGGxejnrjgddGkaDcBvc P_0)
	{
		return ONOzRUELvkhUJSYbdUptBCQVURI == P_0.ONOzRUELvkhUJSYbdUptBCQVURI;
	}

	public override bool Equals(object value)
	{
		if (value == null)
		{
			return false;
		}
		if (!object.ReferenceEquals(value.GetType(), typeof(GKaTaXXuGGxejnrjgddGkaDcBvc)))
		{
			return false;
		}
		return pIBapvbJVOSPdWupDvkQdQSXKYP((GKaTaXXuGGxejnrjgddGkaDcBvc)value);
	}
}
