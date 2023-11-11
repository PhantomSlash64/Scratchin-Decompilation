using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using Rewired;
using Rewired.Data;
using Rewired.Utils;
using UnityEngine;

internal static class XGlzZxXeJIZWLxkQirgkskjObTg
{
	private static class ItKfaQhltkYXNyUmAssDdAxziZr
	{
		private static class ayaSavMzjjUrGQVIojOkCwucsCF
		{
			public static byte[] SExRntFeCOAFkaOQjVPCfMDmhQn(TextAsset P_0, long P_1)
			{
				if (P_0 == null)
				{
					return null;
				}
				byte[] bytes = P_0.bytes;
				if (bytes.Length == 0)
				{
					return null;
				}
				return SExRntFeCOAFkaOQjVPCfMDmhQn(bytes, P_1);
			}

			public static byte[] SExRntFeCOAFkaOQjVPCfMDmhQn(byte[] P_0, long P_1)
			{
				byte[] bytes = BitConverter.GetBytes(P_1);
				DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
				dESCryptoServiceProvider.Key = bytes;
				dESCryptoServiceProvider.IV = bytes;
				ICryptoTransform transform = dESCryptoServiceProvider.CreateDecryptor();
				byte[] array = null;
				using MemoryStream stream = new MemoryStream(P_0);
				using MemoryStream memoryStream = new MemoryStream();
				using (CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read))
				{
					byte[] array2 = new byte[4096];
					for (int num = cryptoStream.Read(array2, 0, array2.Length); num > 0; num = cryptoStream.Read(array2, 0, array2.Length))
					{
						memoryStream.Write(array2, 0, num);
					}
					cryptoStream.Flush();
				}
				return memoryStream.ToArray();
			}

			private static byte[] SExRntFeCOAFkaOQjVPCfMDmhQn(byte[] P_0, string P_1)
			{
				DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
				dESCryptoServiceProvider.Key = Encoding.ASCII.GetBytes(P_1);
				dESCryptoServiceProvider.IV = Encoding.ASCII.GetBytes(P_1);
				ICryptoTransform transform = dESCryptoServiceProvider.CreateDecryptor();
				int i = 0;
				byte[] array = null;
				using Stream stream = GbhcwUWsbGTjZoAbLLaVKQZsosE(P_1, Encoding.ASCII);
				using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
				for (array = new byte[cryptoStream.Length]; cryptoStream.Read(array, i, 4096) > 0; i += 4096)
				{
				}
				return array;
			}

			public static Stream GbhcwUWsbGTjZoAbLLaVKQZsosE(string P_0, Encoding P_1)
			{
				MemoryStream memoryStream = new MemoryStream();
				StreamWriter streamWriter = new StreamWriter(memoryStream, P_1);
				streamWriter.Write(P_0);
				streamWriter.Flush();
				memoryStream.Position = 0L;
				return memoryStream;
			}
		}

		private const string YYfyHPZhClJgCKOuYEcISKGGGtR = "Rewired.Decrypter.bin";

		public static List<Assembly> VKkfMsgijYcssqXSVfsjFxPKSZB(List<TextAsset> P_0, bool P_1, string P_2, long P_3)
		{
			try
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				byte[] array = null;
				using (MemoryStream memoryStream = new MemoryStream())
				{
					using Stream stream = executingAssembly.GetManifestResourceStream("Rewired.Decrypter.bin");
					SRSlDaYgwncDvGWEIBpipbrgORUe(stream, memoryStream);
					array = memoryStream.ToArray();
				}
				byte[] rawAssembly = ayaSavMzjjUrGQVIojOkCwucsCF.SExRntFeCOAFkaOQjVPCfMDmhQn(array, P_3);
				Assembly assembly = Assembly.Load(rawAssembly);
				long num = tZWjMTznYPtCWLeuGnVBYQYtOPi(assembly, P_3);
				return VKkfMsgijYcssqXSVfsjFxPKSZB(P_0, P_1, num);
			}
			catch
			{
				return null;
			}
		}

		private static void SRSlDaYgwncDvGWEIBpipbrgORUe(Stream P_0, Stream P_1)
		{
			byte[] array = new byte[32768];
			int count;
			while ((count = P_0.Read(array, 0, array.Length)) > 0)
			{
				P_1.Write(array, 0, count);
			}
		}

		private static long tZWjMTznYPtCWLeuGnVBYQYtOPi(Assembly P_0, long P_1)
		{
			try
			{
				Type type = P_0.GetType("Rewired.Security.KeyDecrypter");
				return (long)type.InvokeMember("Decrypt", BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.InvokeMethod, null, null, new object[2] { "MU>SOe2)EH[T<)gNSVyMG.\\gO|q>{]!h&,4A(ty{QbSXT@j6V<n^],cupp3t5[)qL?B&SL:fv^8s.YLA,?qZ98A0,wPS%~j>'rXVep66'&6<IxB[mY!L}b@:LRB?!)*<lV%Gn$5K'UF<+,El)OIYzM[+2FElC1AZ^?nU,k?x~~g8eGTUim8aJm.Kv|8qEDn|xI&4mU?^Y!L?bOZ|SD7b};Ya4^?/kOE93S:)6h:!0JX+?88$l8X+9#km1$zV:H\\AlFmPmmJ44]4gS{sk3+e/+Cx1^4b,P^agN^P_e{k\\Z@SVs7,w)b]Ll^/ufmPr#wEt;viv'&|a1w8.~/CKw%RE,!O{RlruVDPxh>3;2;NySeW*Niu%zCs^<KplfF>@JWG47z3*JJ>xHQ`!a*9*0uL4Z`'?o\\|)X].UMa4649kDQozevQcHBMg.+l'0:I+z{JYf5VxhhU}:Ft62SGEs}_Ufx0o$wxoe<AF8Y_0fMwlSu3]oqN|pUEPXQ|(A6%],*s/e+/2mR|&G>A|J18!0&jvrv)4P%Lr2&(i*77v!?E1EJ),)(SPuY7lfi5zm&s!tp_U$hj6WK8jL`L)cEFw4Ukg^9zR`fO>|cg3:]GmkW)Kc^K`YAM(`KxI%PG;?H\\f[y[p^mChqGT#_&(/Cl$}/4mPVtCRMpsBtggTl$$9&w7]i1?ncp;JDk9cZhyzDPXg#7[b#[][bZ@$4$,mD#Si'1$%bZkxw]Fn#tf<14SQPEN,lmL%:<8f1bMax{/5T`nF$f!1iOJ4gA\\7&9ZU3zl/hGz'`>Tu)CwL|hZjYBgT<kOQA't[24~&eRFX89Rw8H'gWOwShCxqC|wy1>Sqi]#GfO:!SRwsLFJR(0)p:3R[hk4>v*]VPwpWZ?f;V5Jn4j`^UxSaKL,B6tFK0vqe'xY#uo3PL\\MkkY%;>n83GKXLwz~t,orJx71sHIH}JlX!$Pz'[Ok\\*AKB&E5J>jqOA~^1`7]n&,[42PBaq]:Z!+zG%kx%5C\\F[BT;}a4}UX#%eEm0C&A+@x0&{kl`!YW(97S!~v7KF*0@44x8x4bR\\.G<1#'[#y4pkSx^,\\qf#YEy*CFCg$u?nZ*fAn`t6<r?H!:;$F3R61h&$.3~8AP\\F,QEsJ@|.h,o#YW5e7$i8to{P%BO%rXKqZ\\ut<hY6RE7YM|v#]NnWB'BMYUsr[T~LC&(Y?)xVbl`T:^)<p{lajJUghu<C`*){`fK5D>jL$/vv[g}IoFvFD`83E4<\\3S'DQrX<!w8a+cYZWRmHtOscY(DT&2w`}WBrGf2$<\\.'1;'g/MKLBOH9;1f|*2T[wnQL^e[lROs2tur?W!)U/1|u$\\j^W1I1xA]i8TGkGU5x(`iD[#<>woZFr:HTmM)Tfh+<8uh(fi_rDU$x[`ZU%*qr?~2^8Hp]pQczbLGuy~b/qrG&#j*I;5{yUH]%/'j>iq{ya+08xrVC1FsIx?&c.8)6ZTux<66!,}l(XZj^Db_vH+~U0/;'DmIJMs&V2/nRD}Zqb,K`2CscXo$8EO|xr<]xz,9$h{)T*U_4J}Zzao*7w;}kp7)%}Of1'x.&kaj'%bTJXu;<Zfg!]`<*]4i$DYqZH^9RMo`+{stC'i[x`PKPPGou6xcr4Cz0NmXS`)Y@7S}npvE&*M|QOknF!PhUk!i,)5Zh0^7~x%#r8Y.'U^)_TAQ8QG,g\\#b%H7#'#.nP3DeuNy7G>s)f_:.G6.H2XBWDa7{$EK([&b^2|yc<h}om,@tCZ#K>;)4x`xM.@CsY$#S^,*e%0Ml$Y>m0CE6D:?8K}_Ml\\shxlAF&S:_ikAEmJI5|W<<o?fO9eIRN8~Kw:[tvOX3LK*C[^;J^Y[Vaw9QAA]n:`s,@/#F1|4ge@.4Z}vYp*QXuMEUmL.|aB}M?'5eEtYfpc!VW;#_J:[l.}TLTk|XE_&E0Pf%$\\##rsp$+g$fJWb8A$hpe90E\\]u3Mq9F/?.Ex<#^]6+j)qB~oLsn//_?F7.``BEUW}eXkBc+m.?m6JF2(bo&pmFS_{42J+T9%pRxm`3K9./LYao~3a4jY&HHj?/k,l<:0sN(4vY:8J#CVeG(n_tuH)`i^#,c&0}P*iywKAU|U}I`w9\\[`xjt7Sf\\5iO5pf}*><$n3Mv0zLWFj7Yzwej[5p_L2yonxNY5Nc`;&SFWPXp1Y\\3[|}`TN\\kO^_sF!*<xrGr3<*K0,}H[@>Wb$sw.}wf/eu>R1TfAyS78@hf%lr`10'}0SDD#h4W*casB[WEQ%>K7439)Xy0<GXA[LFiqn\\,/hWnUm@8Hxv1YgHctRs!m7}?uTy@E1~LS3'uCk7[ONXsomzGg,clj9+8W6~P^;lZy%A#C:z2ybXs*`SYp~/'Uus;rtKYS^~BDr,q3'F7i|(\\?,\\@#0U,C^.#t^Da8Y+}ep,:s)>IX7Dzse2sw8^R_~|C7jANFaW7F.+ZWf>G^.MN_<T[7+8ED3`Mw3h3Tl!gktN?MRvFW1ymOz:rg2Xv|/+&z(ZrKGWr'v']m?FW|].Il|6B#fIX|lSJ^+,*ihNS`4O@%%)}a0bgm0o'|yVvU$X?@8j/vwyF<'J;[y3p'>a*m*hmB'Z{$bOaz,X.nFS5(]OSyF_x/XF^_IujNvYWDYgN&LpGjXn6E)Yzv~6>Aoq6r%lk}#G2,^.QTZ0j,q{ul,,1!tpB\\Ut_bQ!2l;CVY<78gz0W_I&mZ9A]N+k}{$^%c8#i^9sZ2G:w@s!h'ge)@KRW`M?T.ThUo#EPsHGEGM19@B\\.6h{&w8scf:2WK(e4Jv}O&6jJ%O7Tb0A/G7F68vfg}gegzO,S/PmNnOIwO8wJ(oG|Hgm$CO!t99`z0tTfWCOOU')P]brSeUUzp3<mK&a56oMM@hP.P16NGPCi\\|r<>fTKZ%vt~Z8tZ%@iP(.5e$C*}0VJGRh>S\\Y}E2]pkOF$'RW0$'CNmuV/]sQ8Q*LP\\7[/}Taq3zS_C./_%|T>IG/7\\]?UWMA9Fzzm9j2k><\\0$2D0T,lZ>y`s;~&p#$L$s>En'NnH.I", P_1 });
			}
			catch
			{
				return 0L;
			}
		}

		public static List<Assembly> VKkfMsgijYcssqXSVfsjFxPKSZB(List<TextAsset> P_0, bool P_1, long P_2 = 0L)
		{
			if (P_0 == null)
			{
				return null;
			}
			List<Assembly> list = new List<Assembly>();
			for (int i = 0; i < P_0.Count; i++)
			{
				if (!(P_0[i] == null))
				{
					Assembly item = TWdxxnFJApWHtbNPhloGosILjAx(P_0[i], P_1, P_2);
					list.Add(item);
				}
			}
			return list;
		}

		private static Assembly TWdxxnFJApWHtbNPhloGosILjAx(TextAsset P_0, bool P_1, long P_2)
		{
			if (P_0 == null)
			{
				throw new DllNotFoundException("A required assembly is missing!");
			}
			byte[] rawAssembly;
			try
			{
				rawAssembly = ((!P_1) ? P_0.bytes : ayaSavMzjjUrGQVIojOkCwucsCF.SExRntFeCOAFkaOQjVPCfMDmhQn(P_0, P_2));
			}
			catch
			{
				throw new Exception("A required assembly is corrupt!");
			}
			try
			{
				return Assembly.Load(rawAssembly);
			}
			catch
			{
				throw new DllNotFoundException("A required assembly is corrupt!");
			}
		}
	}

	private const string biLncctXLguUeDZaMhoTQiPGfXt = "Rewired.InputManagers.Initializer";

	private const string myUdmwNwlPcHMBfaPqfPHQWFiPmK = "MU>SOe2)EH[T<)gNSVyMG.\\gO|q>{]!h&,4A(ty{QbSXT@j6V<n^],cupp3t5[)qL?B&SL:fv^8s.YLA,?qZ98A0,wPS%~j>'rXVep66'&6<IxB[mY!L}b@:LRB?!)*<lV%Gn$5K'UF<+,El)OIYzM[+2FElC1AZ^?nU,k?x~~g8eGTUim8aJm.Kv|8qEDn|xI&4mU?^Y!L?bOZ|SD7b};Ya4^?/kOE93S:)6h:!0JX+?88$l8X+9#km1$zV:H\\AlFmPmmJ44]4gS{sk3+e/+Cx1^4b,P^agN^P_e{k\\Z@SVs7,w)b]Ll^/ufmPr#wEt;viv'&|a1w8.~/CKw%RE,!O{RlruVDPxh>3;2;NySeW*Niu%zCs^<KplfF>@JWG47z3*JJ>xHQ`!a*9*0uL4Z`'?o\\|)X].UMa4649kDQozevQcHBMg.+l'0:I+z{JYf5VxhhU}:Ft62SGEs}_Ufx0o$wxoe<AF8Y_0fMwlSu3]oqN|pUEPXQ|(A6%],*s/e+/2mR|&G>A|J18!0&jvrv)4P%Lr2&(i*77v!?E1EJ),)(SPuY7lfi5zm&s!tp_U$hj6WK8jL`L)cEFw4Ukg^9zR`fO>|cg3:]GmkW)Kc^K`YAM(`KxI%PG;?H\\f[y[p^mChqGT#_&(/Cl$}/4mPVtCRMpsBtggTl$$9&w7]i1?ncp;JDk9cZhyzDPXg#7[b#[][bZ@$4$,mD#Si'1$%bZkxw]Fn#tf<14SQPEN,lmL%:<8f1bMax{/5T`nF$f!1iOJ4gA\\7&9ZU3zl/hGz'`>Tu)CwL|hZjYBgT<kOQA't[24~&eRFX89Rw8H'gWOwShCxqC|wy1>Sqi]#GfO:!SRwsLFJR(0)p:3R[hk4>v*]VPwpWZ?f;V5Jn4j`^UxSaKL,B6tFK0vqe'xY#uo3PL\\MkkY%;>n83GKXLwz~t,orJx71sHIH}JlX!$Pz'[Ok\\*AKB&E5J>jqOA~^1`7]n&,[42PBaq]:Z!+zG%kx%5C\\F[BT;}a4}UX#%eEm0C&A+@x0&{kl`!YW(97S!~v7KF*0@44x8x4bR\\.G<1#'[#y4pkSx^,\\qf#YEy*CFCg$u?nZ*fAn`t6<r?H!:;$F3R61h&$.3~8AP\\F,QEsJ@|.h,o#YW5e7$i8to{P%BO%rXKqZ\\ut<hY6RE7YM|v#]NnWB'BMYUsr[T~LC&(Y?)xVbl`T:^)<p{lajJUghu<C`*){`fK5D>jL$/vv[g}IoFvFD`83E4<\\3S'DQrX<!w8a+cYZWRmHtOscY(DT&2w`}WBrGf2$<\\.'1;'g/MKLBOH9;1f|*2T[wnQL^e[lROs2tur?W!)U/1|u$\\j^W1I1xA]i8TGkGU5x(`iD[#<>woZFr:HTmM)Tfh+<8uh(fi_rDU$x[`ZU%*qr?~2^8Hp]pQczbLGuy~b/qrG&#j*I;5{yUH]%/'j>iq{ya+08xrVC1FsIx?&c.8)6ZTux<66!,}l(XZj^Db_vH+~U0/;'DmIJMs&V2/nRD}Zqb,K`2CscXo$8EO|xr<]xz,9$h{)T*U_4J}Zzao*7w;}kp7)%}Of1'x.&kaj'%bTJXu;<Zfg!]`<*]4i$DYqZH^9RMo`+{stC'i[x`PKPPGou6xcr4Cz0NmXS`)Y@7S}npvE&*M|QOknF!PhUk!i,)5Zh0^7~x%#r8Y.'U^)_TAQ8QG,g\\#b%H7#'#.nP3DeuNy7G>s)f_:.G6.H2XBWDa7{$EK([&b^2|yc<h}om,@tCZ#K>;)4x`xM.@CsY$#S^,*e%0Ml$Y>m0CE6D:?8K}_Ml\\shxlAF&S:_ikAEmJI5|W<<o?fO9eIRN8~Kw:[tvOX3LK*C[^;J^Y[Vaw9QAA]n:`s,@/#F1|4ge@.4Z}vYp*QXuMEUmL.|aB}M?'5eEtYfpc!VW;#_J:[l.}TLTk|XE_&E0Pf%$\\##rsp$+g$fJWb8A$hpe90E\\]u3Mq9F/?.Ex<#^]6+j)qB~oLsn//_?F7.``BEUW}eXkBc+m.?m6JF2(bo&pmFS_{42J+T9%pRxm`3K9./LYao~3a4jY&HHj?/k,l<:0sN(4vY:8J#CVeG(n_tuH)`i^#,c&0}P*iywKAU|U}I`w9\\[`xjt7Sf\\5iO5pf}*><$n3Mv0zLWFj7Yzwej[5p_L2yonxNY5Nc`;&SFWPXp1Y\\3[|}`TN\\kO^_sF!*<xrGr3<*K0,}H[@>Wb$sw.}wf/eu>R1TfAyS78@hf%lr`10'}0SDD#h4W*casB[WEQ%>K7439)Xy0<GXA[LFiqn\\,/hWnUm@8Hxv1YgHctRs!m7}?uTy@E1~LS3'uCk7[ONXsomzGg,clj9+8W6~P^;lZy%A#C:z2ybXs*`SYp~/'Uus;rtKYS^~BDr,q3'F7i|(\\?,\\@#0U,C^.#t^Da8Y+}ep,:s)>IX7Dzse2sw8^R_~|C7jANFaW7F.+ZWf>G^.MN_<T[7+8ED3`Mw3h3Tl!gktN?MRvFW1ymOz:rg2Xv|/+&z(ZrKGWr'v']m?FW|].Il|6B#fIX|lSJ^+,*ihNS`4O@%%)}a0bgm0o'|yVvU$X?@8j/vwyF<'J;[y3p'>a*m*hmB'Z{$bOaz,X.nFS5(]OSyF_x/XF^_IujNvYWDYgN&LpGjXn6E)Yzv~6>Aoq6r%lk}#G2,^.QTZ0j,q{ul,,1!tpB\\Ut_bQ!2l;CVY<78gz0W_I&mZ9A]N+k}{$^%c8#i^9sZ2G:w@s!h'ge)@KRW`M?T.ThUo#EPsHGEGM19@B\\.6h{&w8scf:2WK(e4Jv}O&6jJ%O7Tb0A/G7F68vfg}gegzO,S/PmNnOIwO8wJ(oG|Hgm$CO!t99`z0tTfWCOOU')P]brSeUUzp3<mK&a56oMM@hP.P16NGPCi\\|r<>fTKZ%vt~Z8tZ%@iP(.5e$C*}0VJGRh>S\\Y}E2]pkOF$'RW0$'CNmuV/]sQ8Q*LP\\7[/}Taq3zS_C./_%|T>IG/7\\]?UWMA9Fzzm9j2k><\\0$2D0T,lZ>y`s;~&p#$L$s>En'NnH.I";

	private const long WXOUDlLeeGCFCtHIKlBxlTgpkrw = -239732958399843948L;

	private static int jowUrWBHFvosHxRWwlDqRQwoDxd;

	private static int dNdMYFXeIPoDGVkqmdYpANbJHKo;

	private static int yiwWqnUHZWLRAKacPaiMhyRheQTe;

	private static string MnzzSTnNlmVxDToVWQRWBeRPava = "Rewired/Internal/Data/enc.bin";

	private static List<Assembly> VeCcbxcCsCfXhFQQWRiUvfHQZAzI;

	public static object ijQPrfbohIDtyfCSvLMVhrlmSpB(string P_0, List<TextAsset> P_1, ConfigVars P_2, bool P_3)
	{
		List<Assembly> list = ItKfaQhltkYXNyUmAssDdAxziZr.VKkfMsgijYcssqXSVfsjFxPKSZB(P_1, P_3, "MU>SOe2)EH[T<)gNSVyMG.\\gO|q>{]!h&,4A(ty{QbSXT@j6V<n^],cupp3t5[)qL?B&SL:fv^8s.YLA,?qZ98A0,wPS%~j>'rXVep66'&6<IxB[mY!L}b@:LRB?!)*<lV%Gn$5K'UF<+,El)OIYzM[+2FElC1AZ^?nU,k?x~~g8eGTUim8aJm.Kv|8qEDn|xI&4mU?^Y!L?bOZ|SD7b};Ya4^?/kOE93S:)6h:!0JX+?88$l8X+9#km1$zV:H\\AlFmPmmJ44]4gS{sk3+e/+Cx1^4b,P^agN^P_e{k\\Z@SVs7,w)b]Ll^/ufmPr#wEt;viv'&|a1w8.~/CKw%RE,!O{RlruVDPxh>3;2;NySeW*Niu%zCs^<KplfF>@JWG47z3*JJ>xHQ`!a*9*0uL4Z`'?o\\|)X].UMa4649kDQozevQcHBMg.+l'0:I+z{JYf5VxhhU}:Ft62SGEs}_Ufx0o$wxoe<AF8Y_0fMwlSu3]oqN|pUEPXQ|(A6%],*s/e+/2mR|&G>A|J18!0&jvrv)4P%Lr2&(i*77v!?E1EJ),)(SPuY7lfi5zm&s!tp_U$hj6WK8jL`L)cEFw4Ukg^9zR`fO>|cg3:]GmkW)Kc^K`YAM(`KxI%PG;?H\\f[y[p^mChqGT#_&(/Cl$}/4mPVtCRMpsBtggTl$$9&w7]i1?ncp;JDk9cZhyzDPXg#7[b#[][bZ@$4$,mD#Si'1$%bZkxw]Fn#tf<14SQPEN,lmL%:<8f1bMax{/5T`nF$f!1iOJ4gA\\7&9ZU3zl/hGz'`>Tu)CwL|hZjYBgT<kOQA't[24~&eRFX89Rw8H'gWOwShCxqC|wy1>Sqi]#GfO:!SRwsLFJR(0)p:3R[hk4>v*]VPwpWZ?f;V5Jn4j`^UxSaKL,B6tFK0vqe'xY#uo3PL\\MkkY%;>n83GKXLwz~t,orJx71sHIH}JlX!$Pz'[Ok\\*AKB&E5J>jqOA~^1`7]n&,[42PBaq]:Z!+zG%kx%5C\\F[BT;}a4}UX#%eEm0C&A+@x0&{kl`!YW(97S!~v7KF*0@44x8x4bR\\.G<1#'[#y4pkSx^,\\qf#YEy*CFCg$u?nZ*fAn`t6<r?H!:;$F3R61h&$.3~8AP\\F,QEsJ@|.h,o#YW5e7$i8to{P%BO%rXKqZ\\ut<hY6RE7YM|v#]NnWB'BMYUsr[T~LC&(Y?)xVbl`T:^)<p{lajJUghu<C`*){`fK5D>jL$/vv[g}IoFvFD`83E4<\\3S'DQrX<!w8a+cYZWRmHtOscY(DT&2w`}WBrGf2$<\\.'1;'g/MKLBOH9;1f|*2T[wnQL^e[lROs2tur?W!)U/1|u$\\j^W1I1xA]i8TGkGU5x(`iD[#<>woZFr:HTmM)Tfh+<8uh(fi_rDU$x[`ZU%*qr?~2^8Hp]pQczbLGuy~b/qrG&#j*I;5{yUH]%/'j>iq{ya+08xrVC1FsIx?&c.8)6ZTux<66!,}l(XZj^Db_vH+~U0/;'DmIJMs&V2/nRD}Zqb,K`2CscXo$8EO|xr<]xz,9$h{)T*U_4J}Zzao*7w;}kp7)%}Of1'x.&kaj'%bTJXu;<Zfg!]`<*]4i$DYqZH^9RMo`+{stC'i[x`PKPPGou6xcr4Cz0NmXS`)Y@7S}npvE&*M|QOknF!PhUk!i,)5Zh0^7~x%#r8Y.'U^)_TAQ8QG,g\\#b%H7#'#.nP3DeuNy7G>s)f_:.G6.H2XBWDa7{$EK([&b^2|yc<h}om,@tCZ#K>;)4x`xM.@CsY$#S^,*e%0Ml$Y>m0CE6D:?8K}_Ml\\shxlAF&S:_ikAEmJI5|W<<o?fO9eIRN8~Kw:[tvOX3LK*C[^;J^Y[Vaw9QAA]n:`s,@/#F1|4ge@.4Z}vYp*QXuMEUmL.|aB}M?'5eEtYfpc!VW;#_J:[l.}TLTk|XE_&E0Pf%$\\##rsp$+g$fJWb8A$hpe90E\\]u3Mq9F/?.Ex<#^]6+j)qB~oLsn//_?F7.``BEUW}eXkBc+m.?m6JF2(bo&pmFS_{42J+T9%pRxm`3K9./LYao~3a4jY&HHj?/k,l<:0sN(4vY:8J#CVeG(n_tuH)`i^#,c&0}P*iywKAU|U}I`w9\\[`xjt7Sf\\5iO5pf}*><$n3Mv0zLWFj7Yzwej[5p_L2yonxNY5Nc`;&SFWPXp1Y\\3[|}`TN\\kO^_sF!*<xrGr3<*K0,}H[@>Wb$sw.}wf/eu>R1TfAyS78@hf%lr`10'}0SDD#h4W*casB[WEQ%>K7439)Xy0<GXA[LFiqn\\,/hWnUm@8Hxv1YgHctRs!m7}?uTy@E1~LS3'uCk7[ONXsomzGg,clj9+8W6~P^;lZy%A#C:z2ybXs*`SYp~/'Uus;rtKYS^~BDr,q3'F7i|(\\?,\\@#0U,C^.#t^Da8Y+}ep,:s)>IX7Dzse2sw8^R_~|C7jANFaW7F.+ZWf>G^.MN_<T[7+8ED3`Mw3h3Tl!gktN?MRvFW1ymOz:rg2Xv|/+&z(ZrKGWr'v']m?FW|].Il|6B#fIX|lSJ^+,*ihNS`4O@%%)}a0bgm0o'|yVvU$X?@8j/vwyF<'J;[y3p'>a*m*hmB'Z{$bOaz,X.nFS5(]OSyF_x/XF^_IujNvYWDYgN&LpGjXn6E)Yzv~6>Aoq6r%lk}#G2,^.QTZ0j,q{ul,,1!tpB\\Ut_bQ!2l;CVY<78gz0W_I&mZ9A]N+k}{$^%c8#i^9sZ2G:w@s!h'ge)@KRW`M?T.ThUo#EPsHGEGM19@B\\.6h{&w8scf:2WK(e4Jv}O&6jJ%O7Tb0A/G7F68vfg}gegzO,S/PmNnOIwO8wJ(oG|Hgm$CO!t99`z0tTfWCOOU')P]brSeUUzp3<mK&a56oMM@hP.P16NGPCi\\|r<>fTKZ%vt~Z8tZ%@iP(.5e$C*}0VJGRh>S\\Y}E2]pkOF$'RW0$'CNmuV/]sQ8Q*LP\\7[/}Taq3zS_C./_%|T>IG/7\\]?UWMA9Fzzm9j2k><\\0$2D0T,lZ>y`s;~&p#$L$s>En'NnH.I", -239732958399843948L);
		int num = list?.Count ?? 0;
		_ = yiwWqnUHZWLRAKacPaiMhyRheQTe;
		yiwWqnUHZWLRAKacPaiMhyRheQTe = num;
		for (int i = 0; i < num; i++)
		{
			Assembly assembly = list[i];
			if ((object)assembly != null && assembly.FullName.StartsWith(P_0, StringComparison.OrdinalIgnoreCase))
			{
				Type type = assembly.GetType("Rewired.InputManagers.Initializer");
				if ((object)type != null)
				{
					return LvbRoFLwfsOxovKDAAXSEIbtTrG(type)?.Initialize(P_2);
				}
			}
		}
		return null;
	}

	public static object ijQPrfbohIDtyfCSvLMVhrlmSpB(string P_0, List<Assembly> P_1, ConfigVars P_2)
	{
		VeCcbxcCsCfXhFQQWRiUvfHQZAzI = P_1;
		int num = P_1?.Count ?? 0;
		if (num == 0)
		{
			if (!(UnityTools.externalTools.GetPlatformInitializer() is PlatformInitializer platformInitializer))
			{
				return null;
			}
			return platformInitializer.Initialize(P_2);
		}
		for (int i = 0; i < num; i++)
		{
			Assembly assembly = P_1[i];
			if ((object)assembly != null && assembly.FullName.StartsWith(P_0, StringComparison.OrdinalIgnoreCase))
			{
				Type type = assembly.GetType("Rewired.InputManagers.Initializer");
				if ((object)type != null)
				{
					return LvbRoFLwfsOxovKDAAXSEIbtTrG(type)?.Initialize(P_2);
				}
			}
		}
		return null;
	}

	public static object alotxluMWAUxHKeMGSCozzOoqGZ(string P_0, string P_1)
	{
		List<Assembly> veCcbxcCsCfXhFQQWRiUvfHQZAzI = VeCcbxcCsCfXhFQQWRiUvfHQZAzI;
		int num = veCcbxcCsCfXhFQQWRiUvfHQZAzI?.Count ?? 0;
		if (num == 0)
		{
			if (!(UnityTools.externalTools.GetPlatformInitializer() is PlatformInitializer platformInitializer))
			{
				return null;
			}
			return platformInitializer.CreateTool(P_1);
		}
		for (int i = 0; i < num; i++)
		{
			Assembly assembly = veCcbxcCsCfXhFQQWRiUvfHQZAzI[i];
			if ((object)assembly != null && assembly.FullName.StartsWith(P_0, StringComparison.OrdinalIgnoreCase))
			{
				Type type = assembly.GetType("Rewired.InputManagers.Initializer");
				if ((object)type != null)
				{
					return LvbRoFLwfsOxovKDAAXSEIbtTrG(type)?.CreateTool(P_1);
				}
			}
		}
		return null;
	}

	public static PlatformInitializer LvbRoFLwfsOxovKDAAXSEIbtTrG(Type P_0)
	{
		try
		{
			object obj = P_0.InvokeMember("GetPlatformInitializer", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
			return obj as PlatformInitializer;
		}
		catch
		{
			return null;
		}
	}
}
