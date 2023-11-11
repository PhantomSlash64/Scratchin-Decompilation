using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;

internal abstract class ALKBuhhhSYeZsaqszdbHQCLZfzA<T, TRaw, TUpdate> : GhKLEpmSVFpYgtzUptAQKwlIlec where T : class, global::qsJbIpdeTVuwXtKQVZhlcEJWMopL<TRaw, TUpdate>, new() where TRaw : struct where TUpdate : struct, dAZOeydvZQLfBfgWmmQhdqnMavn
{
	private UTeffynwqDgSvZsKPMJHBFjpmdg fXstwykwXsiYNQPGNavfkXfzUfv;

	private readonly Dictionary<string, EbHCWIaExpJRamFQcfxJwidDzPSq> fOwuwLDvWNAWnCYBDLPeeCqWESa = new Dictionary<string, EbHCWIaExpJRamFQcfxJwidDzPSq>();

	private static readonly TUpdate[] gLAdMuixBXUpoSxwWbdSGonkEcj = new TUpdate[0];

	protected ALKBuhhhSYeZsaqszdbHQCLZfzA(IntPtr nativePtr)
		: base(nativePtr)
	{
	}

	protected ALKBuhhhSYeZsaqszdbHQCLZfzA(cLFlnHVsQfZirmsvltfLdtHKFo directInput, Guid deviceGuid)
		: base(directInput, deviceGuid)
	{
		UTeffynwqDgSvZsKPMJHBFjpmdg uTeffynwqDgSvZsKPMJHBFjpmdg = YdPaLzeSNzbPeITUeVXwoGMdveiX();
		mlQQEyOLFleePGGNUvdwqMmyoBti(uTeffynwqDgSvZsKPMJHBFjpmdg);
	}

	public unsafe TUpdate[] PUxGBlTSyzciyfFqhCTpDStyxeKf()
	{
		TUpdate[] result = gLAdMuixBXUpoSxwWbdSGonkEcj;
		int num = WdABqngzfChtFJSJGeObIpoDQOet.BSrOqfyRTTNMvjOTEoJRNXUWoPI<cxaBnluxwbLBaQucTgCUAKWgQkl>();
		int num2 = -1;
		BXXhtcnPVwUJssdhcVDULvutAss(num, IntPtr.Zero, ref num2, 1);
		if (num2 == 0)
		{
			return result;
		}
		cxaBnluxwbLBaQucTgCUAKWgQkl* ptr = stackalloc cxaBnluxwbLBaQucTgCUAKWgQkl[num2];
		BXXhtcnPVwUJssdhcVDULvutAss(num, (IntPtr)ptr, ref num2, 0);
		if (num2 == 0)
		{
			return result;
		}
		result = new TUpdate[num2];
		for (int i = 0; i < num2; i++)
		{
			TUpdate val = default(TUpdate);
			val.gVPXRhFCOVeTsLinXJsXOgVuwFJ = ptr[i].hEboeGPdDGusdeKDhVfIMtWjlci;
			val.nczcPLcebmehYQZrGCkRTKERfERG = ptr[i].ygqDlcblBdHdDceQDJzibNhKqWEM;
			val.nWUcqxIXuCSjTUCAZwEkhxCkLKS = ptr[i].fFChrUtjRoLnpZHhLIfFJpuIoHbG;
			val.XHZsMPvenoOmWUlqIxbkCOiipQK = ptr[i].XHZsMPvenoOmWUlqIxbkCOiipQK;
			result[i] = val;
		}
		return result;
	}

	public void qKYEKtVAHBeycawCeYUnkrJHVZa(T P_0)
	{
		bGyAhxmDqyBnueQjAZjMPfKnBIXh(ref P_0);
	}

	public T bGyAhxmDqyBnueQjAZjMPfKnBIXh()
	{
		T result = new T();
		bGyAhxmDqyBnueQjAZjMPfKnBIXh(ref result);
		return result;
	}

	public unsafe void bGyAhxmDqyBnueQjAZjMPfKnBIXh(ref T P_0)
	{
		int num = WdABqngzfChtFJSJGeObIpoDQOet.BSrOqfyRTTNMvjOTEoJRNXUWoPI<TRaw>();
		byte* ptr = stackalloc byte[(int)(uint)(num * 2)];
		VnteScbqjqaLgFypExfaFHfwaRf(num, (IntPtr)ptr);
		P_0.fMyDiEWbVoVVRklJtHYIUVjCxXv((IntPtr)ptr);
	}

	public SXoDXAAkhtkcYIknHXlAohykBIm nwpWPGlkRmysmIDsKuOJoJZVxyy(string P_0)
	{
		return yziHJMvdmUIuadUzLbYXQZAwZjQ(rWXMcgqBAQAZRENctWRsvUmVevM(P_0).hEboeGPdDGusdeKDhVfIMtWjlci, nPcKHQXkDKXFVvnlaVTUmuEQrDN.yvYGMCKuXTmaPrKSwqOxavlmEDn);
	}

	public BnlHNQrDaovBhmLjtLHgUmlmYnQ OqCSaEorFUNDQuEhelPYLdwwfIh(string P_0)
	{
		return new BnlHNQrDaovBhmLjtLHgUmlmYnQ(this, rWXMcgqBAQAZRENctWRsvUmVevM(P_0).hEboeGPdDGusdeKDhVfIMtWjlci, nPcKHQXkDKXFVvnlaVTUmuEQrDN.yvYGMCKuXTmaPrKSwqOxavlmEDn);
	}

	private EbHCWIaExpJRamFQcfxJwidDzPSq rWXMcgqBAQAZRENctWRsvUmVevM(string P_0)
	{
		if (!fOwuwLDvWNAWnCYBDLPeeCqWESa.TryGetValue(P_0, out var value))
		{
			throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "Invalid name [{0}]. Must be in [{1}]", new object[2]
			{
				P_0,
				WdABqngzfChtFJSJGeObIpoDQOet.LNeDIBuozmidWcKSLzVEHudXmyO(";", fOwuwLDvWNAWnCYBDLPeeCqWESa.Keys)
			}));
		}
		return value;
	}

	private UTeffynwqDgSvZsKPMJHBFjpmdg YdPaLzeSNzbPeITUeVXwoGMdveiX()
	{
		if (fXstwykwXsiYNQPGNavfkXfzUfv == null)
		{
			if (typeof(QIafuHDgyyvwkzZlnbIXLBqetAw).IsAssignableFrom(typeof(TRaw)))
			{
				QIafuHDgyyvwkzZlnbIXLBqetAw qIafuHDgyyvwkzZlnbIXLBqetAw = (QIafuHDgyyvwkzZlnbIXLBqetAw)(object)default(TRaw);
				fXstwykwXsiYNQPGNavfkXfzUfv = new UTeffynwqDgSvZsKPMJHBFjpmdg(qIafuHDgyyvwkzZlnbIXLBqetAw.jMbdrySazXGxqBoUZJERaOtVVTv)
				{
					rHgvAWfvcVetfzBNIUSpjxABFaI = WdABqngzfChtFJSJGeObIpoDQOet.BSrOqfyRTTNMvjOTEoJRNXUWoPI<TRaw>(),
					fuCFbrBEbYBEBiLCkOPwwBcoefNz = qIafuHDgyyvwkzZlnbIXLBqetAw.fuCFbrBEbYBEBiLCkOPwwBcoefNz
				};
			}
			else
			{
				object[] customAttributes = typeof(TRaw).GetCustomAttributes(typeof(MPRcAuIPIMYWkcRGWUhSVhgfrJj), inherit: false);
				if (customAttributes.Length != 1)
				{
					throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "The structure [{0}] must be marked with DataFormatAttribute or provide a IDataFormatProvider", new object[1] { typeof(TRaw).FullName }));
				}
				fXstwykwXsiYNQPGNavfkXfzUfv = new UTeffynwqDgSvZsKPMJHBFjpmdg(((MPRcAuIPIMYWkcRGWUhSVhgfrJj)customAttributes[0]).jMbdrySazXGxqBoUZJERaOtVVTv)
				{
					rHgvAWfvcVetfzBNIUSpjxABFaI = WdABqngzfChtFJSJGeObIpoDQOet.BSrOqfyRTTNMvjOTEoJRNXUWoPI<TRaw>()
				};
				List<EbHCWIaExpJRamFQcfxJwidDzPSq> list = new List<EbHCWIaExpJRamFQcfxJwidDzPSq>();
				FieldInfo[] fields = typeof(TRaw).GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (FieldInfo fieldInfo in fields)
				{
					object[] customAttributes2 = fieldInfo.GetCustomAttributes(typeof(BGPwFQRyVttbjxawAxiynEHOQGP), inherit: false);
					if (customAttributes2.Length <= 0)
					{
						continue;
					}
					int num = Marshal.OffsetOf(typeof(TRaw), fieldInfo.Name).ToInt32();
					int num2 = Marshal.SizeOf(fieldInfo.FieldType);
					int num3 = num;
					int num4 = 0;
					for (int j = 0; j < customAttributes2.Length; j++)
					{
						BGPwFQRyVttbjxawAxiynEHOQGP bGPwFQRyVttbjxawAxiynEHOQGP = (BGPwFQRyVttbjxawAxiynEHOQGP)customAttributes2[j];
						num4 += ((bGPwFQRyVttbjxawAxiynEHOQGP.hHnMTofVnAnhoxdeFXJQManKMjd == 0) ? 1 : bGPwFQRyVttbjxawAxiynEHOQGP.hHnMTofVnAnhoxdeFXJQManKMjd);
					}
					int num5 = num2 / num4;
					if (num5 * num4 != num2)
					{
						throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Field [{0}] has incompatible size [{1}] and number of DataObjectAttributes [{2}]", new object[3]
						{
							fieldInfo.Name,
							(double)num2 / (double)num4,
							num4
						}));
					}
					int num6 = 0;
					for (int k = 0; k < customAttributes2.Length; k++)
					{
						BGPwFQRyVttbjxawAxiynEHOQGP bGPwFQRyVttbjxawAxiynEHOQGP2 = (BGPwFQRyVttbjxawAxiynEHOQGP)customAttributes2[k];
						num4 = ((bGPwFQRyVttbjxawAxiynEHOQGP2.hHnMTofVnAnhoxdeFXJQManKMjd == 0) ? 1 : bGPwFQRyVttbjxawAxiynEHOQGP2.hHnMTofVnAnhoxdeFXJQManKMjd);
						for (int l = 0; l < num4; l++)
						{
							EbHCWIaExpJRamFQcfxJwidDzPSq ebHCWIaExpJRamFQcfxJwidDzPSq = new EbHCWIaExpJRamFQcfxJwidDzPSq(string.IsNullOrEmpty(bGPwFQRyVttbjxawAxiynEHOQGP2.xTdGZwgiCKEXSLQazMJzOppDnvYm) ? Guid.Empty : new Guid(bGPwFQRyVttbjxawAxiynEHOQGP2.xTdGZwgiCKEXSLQazMJzOppDnvYm), num3, bGPwFQRyVttbjxawAxiynEHOQGP2.TETONeGvOFGXjLObsLekbkSPCbkJ, bGPwFQRyVttbjxawAxiynEHOQGP2.jMbdrySazXGxqBoUZJERaOtVVTv, bGPwFQRyVttbjxawAxiynEHOQGP2.ObJgzgrcuhyzRiXNptqyCxuZWkL);
							string text = (string.IsNullOrEmpty(bGPwFQRyVttbjxawAxiynEHOQGP2.bXjwznmhBpYblwUBYTWSOIeBUjj) ? fieldInfo.Name : bGPwFQRyVttbjxawAxiynEHOQGP2.bXjwznmhBpYblwUBYTWSOIeBUjj);
							text = ((num4 == 1) ? text : (text + num6));
							ebHCWIaExpJRamFQcfxJwidDzPSq.bXjwznmhBpYblwUBYTWSOIeBUjj = text;
							list.Add(ebHCWIaExpJRamFQcfxJwidDzPSq);
							num3 += num5;
							num6++;
						}
					}
				}
				fXstwykwXsiYNQPGNavfkXfzUfv.fuCFbrBEbYBEBiLCkOPwwBcoefNz = list.ToArray();
			}
			for (int m = 0; m < fXstwykwXsiYNQPGNavfkXfzUfv.fuCFbrBEbYBEBiLCkOPwwBcoefNz.Length; m++)
			{
				EbHCWIaExpJRamFQcfxJwidDzPSq ebHCWIaExpJRamFQcfxJwidDzPSq2 = fXstwykwXsiYNQPGNavfkXfzUfv.fuCFbrBEbYBEBiLCkOPwwBcoefNz[m];
				if (fOwuwLDvWNAWnCYBDLPeeCqWESa.ContainsKey(ebHCWIaExpJRamFQcfxJwidDzPSq2.bXjwznmhBpYblwUBYTWSOIeBUjj))
				{
					throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "Incorrect field name [{0}]. Field name must be unique", new object[1] { ebHCWIaExpJRamFQcfxJwidDzPSq2.bXjwznmhBpYblwUBYTWSOIeBUjj }));
				}
				fOwuwLDvWNAWnCYBDLPeeCqWESa.Add(ebHCWIaExpJRamFQcfxJwidDzPSq2.bXjwznmhBpYblwUBYTWSOIeBUjj, ebHCWIaExpJRamFQcfxJwidDzPSq2);
			}
		}
		return fXstwykwXsiYNQPGNavfkXfzUfv;
	}

	private unsafe void GKvFoxovmIIJLnXUCycEGmLqjlY(UTeffynwqDgSvZsKPMJHBFjpmdg P_0)
	{
		UTeffynwqDgSvZsKPMJHBFjpmdg.YOKaazVPIgdXKjOPdtfYJWCHmGD yOKaazVPIgdXKjOPdtfYJWCHmGD = default(UTeffynwqDgSvZsKPMJHBFjpmdg.YOKaazVPIgdXKjOPdtfYJWCHmGD);
		P_0.NsLbZkpplPuPIaPaULbMMeMZgKj(ref yOKaazVPIgdXKjOPdtfYJWCHmGD);
		string name = typeof(TRaw).Name;
		Console.WriteLine("{0}.dwSize     {1}", name, yOKaazVPIgdXKjOPdtfYJWCHmGD.OAxxiRRJUwaMLNmFaPAXfzgmRpb);
		Console.WriteLine("{0}.dwObjSize  {1}", name, yOKaazVPIgdXKjOPdtfYJWCHmGD.IJLqyVAxbWDlVdHoLbPkoSZXYZg);
		Console.WriteLine("{0}.dwFlags    {1} ({2})", name, (int)yOKaazVPIgdXKjOPdtfYJWCHmGD.jMbdrySazXGxqBoUZJERaOtVVTv, yOKaazVPIgdXKjOPdtfYJWCHmGD.jMbdrySazXGxqBoUZJERaOtVVTv);
		Console.WriteLine("{0}.dwDataSize {1}", name, yOKaazVPIgdXKjOPdtfYJWCHmGD.rHgvAWfvcVetfzBNIUSpjxABFaI);
		Console.WriteLine("{0}.dwNumObjs  {1}", name, yOKaazVPIgdXKjOPdtfYJWCHmGD.ntaMHLiPWehglJMQyxaCNKzSjBl);
		Console.WriteLine("{4,32};{0,38};{1,8},{2,8};{3,8}", "Guid", "Offset", "Type", "Flags", "Name");
		EbHCWIaExpJRamFQcfxJwidDzPSq.nQDKBEIjTpWFRwGlPFDUPiktUjF* ptr = (EbHCWIaExpJRamFQcfxJwidDzPSq.nQDKBEIjTpWFRwGlPFDUPiktUjF*)(void*)yOKaazVPIgdXKjOPdtfYJWCHmGD.rJNUQXOsifVsBaXuWboZuWdbnpL;
		for (int i = 0; i < yOKaazVPIgdXKjOPdtfYJWCHmGD.ntaMHLiPWehglJMQyxaCNKzSjBl; i++)
		{
			EbHCWIaExpJRamFQcfxJwidDzPSq.nQDKBEIjTpWFRwGlPFDUPiktUjF nQDKBEIjTpWFRwGlPFDUPiktUjF = ptr[i];
			string text = ((nQDKBEIjTpWFRwGlPFDUPiktUjF.iRPYfrJlJliKFSdzqaVEzNoRPip == IntPtr.Zero) ? "" : ((Guid*)(void*)nQDKBEIjTpWFRwGlPFDUPiktUjF.iRPYfrJlJliKFSdzqaVEzNoRPip)->ToString());
			Console.WriteLine("{5,32};{0,38};{1,8},{2:X8};{3:X8} ({4})", text, nQDKBEIjTpWFRwGlPFDUPiktUjF.hEboeGPdDGusdeKDhVfIMtWjlci, nQDKBEIjTpWFRwGlPFDUPiktUjF.HmQyuofUsvomGjtCuiqveOpNWlh, (int)nQDKBEIjTpWFRwGlPFDUPiktUjF.jMbdrySazXGxqBoUZJERaOtVVTv, nQDKBEIjTpWFRwGlPFDUPiktUjF.jMbdrySazXGxqBoUZJERaOtVVTv, P_0.fuCFbrBEbYBEBiLCkOPwwBcoefNz[i].bXjwznmhBpYblwUBYTWSOIeBUjj);
		}
		Console.WriteLine();
	}
}
