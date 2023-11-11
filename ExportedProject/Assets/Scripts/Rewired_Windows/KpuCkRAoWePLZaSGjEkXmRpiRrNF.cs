using System.Globalization;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Size = 4)]
internal struct KpuCkRAoWePLZaSGjEkXmRpiRrNF
{
	private const int qwoqWlBBeglOdPFKuNvJvhdmiGe = 65534;

	private const int JxXjjJQCEmkoTZgfkvWDuosUQqh = 16776960;

	private int ontsFBhsqRLKhgpTKkivTJMoLSG;

	public aROXwdaxgbeVtmneibreFeVBHR jMbdrySazXGxqBoUZJERaOtVVTv => (aROXwdaxgbeVtmneibreFeVBHR)(ontsFBhsqRLKhgpTKkivTJMoLSG & -16776961);

	public int ObJgzgrcuhyzRiXNptqyCxuZWkL => (ontsFBhsqRLKhgpTKkivTJMoLSG >> 8) & 0xFFFF;

	public KpuCkRAoWePLZaSGjEkXmRpiRrNF(aROXwdaxgbeVtmneibreFeVBHR typeFlags, int instanceNumber)
	{
		this = default(KpuCkRAoWePLZaSGjEkXmRpiRrNF);
		ontsFBhsqRLKhgpTKkivTJMoLSG = (int)(typeFlags & ~aROXwdaxgbeVtmneibreFeVBHR.ivCuYLFEFmsbUbmMjKaFcznnbBJ) | ((!(instanceNumber < 0 || instanceNumber > 65534)) ? ((instanceNumber & 0xFFFF) << 8) : 0);
	}

	public static explicit operator int(KpuCkRAoWePLZaSGjEkXmRpiRrNF type)
	{
		return type.ontsFBhsqRLKhgpTKkivTJMoLSG;
	}

	public bool pIBapvbJVOSPdWupDvkQdQSXKYP(KpuCkRAoWePLZaSGjEkXmRpiRrNF P_0)
	{
		return P_0.ontsFBhsqRLKhgpTKkivTJMoLSG == ontsFBhsqRLKhgpTKkivTJMoLSG;
	}

	public override bool Equals(object obj)
	{
		if (object.ReferenceEquals(null, obj))
		{
			return false;
		}
		if ((object)obj.GetType() != typeof(KpuCkRAoWePLZaSGjEkXmRpiRrNF))
		{
			return false;
		}
		return pIBapvbJVOSPdWupDvkQdQSXKYP((KpuCkRAoWePLZaSGjEkXmRpiRrNF)obj);
	}

	public override int GetHashCode()
	{
		return ontsFBhsqRLKhgpTKkivTJMoLSG;
	}

	public override string ToString()
	{
		return string.Format(CultureInfo.InvariantCulture, "Flags: {0} InstanceNumber: {1} RawId: 0x{2:X8}", new object[3] { jMbdrySazXGxqBoUZJERaOtVVTv, ObJgzgrcuhyzRiXNptqyCxuZWkL, ontsFBhsqRLKhgpTKkivTJMoLSG });
	}
}
