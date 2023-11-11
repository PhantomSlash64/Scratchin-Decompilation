using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[Preserve]
	[CustomObfuscation(rename = false)]
	internal sealed class SerializedObject : IEnumerable, IEnumerable<SerializedObject.Field>, IAddValue<object>, IAddKeyValue<string, object>, IExportToXml, IExportToJson
	{
		[CustomObfuscation(rename = false)]
		public enum ObjectType
		{
			[CustomObfuscation(rename = false)]
			Object = 0,
			[CustomObfuscation(rename = false)]
			List = 1
		}

		[Flags]
		[CustomObfuscation(rename = false)]
		public enum FieldOptions
		{
			[CustomObfuscation(rename = false)]
			None = 0,
			[CustomObfuscation(rename = false)]
			ExculdeFromXml = 1
		}

		private struct LckSdujMDFsxiSrBnhMHWDIAxoX
		{
			public Type flYmSKXdxEbrkbApyjuUarnstyO;

			public object foSRcEqSuRsWnadDiKcGnhBewOU;

			public FieldOptions vMJrGnmziUNIcpRVnCigQssqgyZ;

			public LckSdujMDFsxiSrBnhMHWDIAxoX(Type type, object value, FieldOptions options)
			{
				flYmSKXdxEbrkbApyjuUarnstyO = type;
				foSRcEqSuRsWnadDiKcGnhBewOU = value;
				vMJrGnmziUNIcpRVnCigQssqgyZ = options;
			}

			public override string ToString()
			{
				string text = "";
				text = text + "type = " + (((object)flYmSKXdxEbrkbApyjuUarnstyO != null) ? flYmSKXdxEbrkbApyjuUarnstyO.Name : "NULL") + "\n";
				text = text + "value = " + ((foSRcEqSuRsWnadDiKcGnhBewOU != null) ? foSRcEqSuRsWnadDiKcGnhBewOU.ToString() : "NULL") + "\n";
				object obj = text;
				return string.Concat(obj, "options = ", vMJrGnmziUNIcpRVnCigQssqgyZ, "\n");
			}
		}

		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		[CustomObfuscation(rename = false)]
		public struct Field
		{
			public string name;

			public object value;

			public Type type;

			public FieldOptions options;

			public Field(string name, object value, Type type, FieldOptions options)
			{
				this.name = name;
				this.value = value;
				this.type = type;
				this.options = options;
			}

			public override string ToString()
			{
				string text = "name = " + ((name != null) ? name : "NULL") + "\n";
				text = text + "value = " + ((value != null) ? value.ToString() : "NULL") + "\n";
				text = text + "type = " + (((object)type != null) ? type.Name : "NULL") + "\n";
				object obj = text;
				return string.Concat(obj, "options = ", options, "\n");
			}
		}

		[CustomObfuscation(rename = false)]
		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		public class XmlInfo
		{
			public abstract class HDPGiVoBXLVCodlSiugSdJIEGou
			{
			}

			public class kwLxndskJikCtPGLslSPWsTXCTW : HDPGiVoBXLVCodlSiugSdJIEGou
			{
				public string jveufREDmiaHzvZNPCiXJKHYoFA;

				public string FaRCzmOJYwGVoyOIjhyHpMferPo;

				public string ErZkPlJPCSFziEkQUXjksErSMGjf;

				public string foSRcEqSuRsWnadDiKcGnhBewOU;

				public override string ToString()
				{
					string text = "";
					text = text + "prefix = " + jveufREDmiaHzvZNPCiXJKHYoFA + "\n";
					text = text + "localName = " + FaRCzmOJYwGVoyOIjhyHpMferPo + "\n";
					text = text + "ns = " + ErZkPlJPCSFziEkQUXjksErSMGjf + "\n";
					return text + "value = " + foSRcEqSuRsWnadDiKcGnhBewOU + "\n";
				}
			}

			private List<HDPGiVoBXLVCodlSiugSdJIEGou> uQpDzhizTXryPklvovEXFTZFwsKa;

			public List<HDPGiVoBXLVCodlSiugSdJIEGou> attributes => uQpDzhizTXryPklvovEXFTZFwsKa ?? (uQpDzhizTXryPklvovEXFTZFwsKa = new List<HDPGiVoBXLVCodlSiugSdJIEGou>());

			public override string ToString()
			{
				string text = "Attributes:\n";
				if (uQpDzhizTXryPklvovEXFTZFwsKa != null)
				{
					for (int i = 0; i < uQpDzhizTXryPklvovEXFTZFwsKa.Count; i++)
					{
						text = text + uQpDzhizTXryPklvovEXFTZFwsKa[i].ToString() + "\n";
					}
				}
				return text;
			}
		}

		[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
		[CustomObfuscation(rename = false)]
		public struct Enumerator : IDisposable, IEnumerator, IEnumerator<Field>
		{
			private IndexedDictionary<string, LckSdujMDFsxiSrBnhMHWDIAxoX> niSwIGuixCCwVvwckEvgBcZHWRr;

			private Field HBFpvdVSEToPvyDvjayPiQyuurNQ;

			private IEnumerator<KeyValuePair<string, LckSdujMDFsxiSrBnhMHWDIAxoX>> kcnyqxsvWKlttBDpgVBFKJqbyEN;

			public Field Current => HBFpvdVSEToPvyDvjayPiQyuurNQ;

			object IEnumerator.Current => HBFpvdVSEToPvyDvjayPiQyuurNQ;

			internal Enumerator(object dictionary)
			{
				niSwIGuixCCwVvwckEvgBcZHWRr = (IndexedDictionary<string, LckSdujMDFsxiSrBnhMHWDIAxoX>)dictionary;
				HBFpvdVSEToPvyDvjayPiQyuurNQ = default(Field);
				kcnyqxsvWKlttBDpgVBFKJqbyEN = niSwIGuixCCwVvwckEvgBcZHWRr.GetEnumerator();
			}

			public bool MoveNext()
			{
				if (!kcnyqxsvWKlttBDpgVBFKJqbyEN.MoveNext())
				{
					return false;
				}
				KeyValuePair<string, LckSdujMDFsxiSrBnhMHWDIAxoX> current = kcnyqxsvWKlttBDpgVBFKJqbyEN.Current;
				HBFpvdVSEToPvyDvjayPiQyuurNQ = new Field(current.Key, current.Value.foSRcEqSuRsWnadDiKcGnhBewOU, current.Value.flYmSKXdxEbrkbApyjuUarnstyO, current.Value.vMJrGnmziUNIcpRVnCigQssqgyZ);
				return true;
			}

			public void Dispose()
			{
			}

			void IEnumerator.Reset()
			{
				HBFpvdVSEToPvyDvjayPiQyuurNQ = default(Field);
				kcnyqxsvWKlttBDpgVBFKJqbyEN = niSwIGuixCCwVvwckEvgBcZHWRr.GetEnumerator();
			}
		}

		private class mQexZElgxheWivTdrfuznZgWdIZ
		{
			public class OHYePZWWPpLilrpHniDWRcaZSap
			{
				public readonly string kKDfGMxMvbfrZIlPuNxkGciRTym;

				public readonly OHYePZWWPpLilrpHniDWRcaZSap mQXiYotjnToDecfWIRfktslJAMQ;

				public string rNicKeGVINJHooQsSUZgLEEnLMk;

				public Dictionary<string, string> JWaUpfSdHFpjmGdrwiiKFHSWlnM;

				public List<OHYePZWWPpLilrpHniDWRcaZSap> UgMoOIlddBlMQwgaxMdXKRdXAge;

				public int SWUammnVJReCJYxUcFEwpgnqNPH
				{
					get
					{
						if (UgMoOIlddBlMQwgaxMdXKRdXAge == null)
						{
							return 0;
						}
						return UgMoOIlddBlMQwgaxMdXKRdXAge.Count;
					}
				}

				public int LUMWQPqVBecmopgJmLKgHHUIrHJ
				{
					get
					{
						if (JWaUpfSdHFpjmGdrwiiKFHSWlnM == null)
						{
							return 0;
						}
						return JWaUpfSdHFpjmGdrwiiKFHSWlnM.Count;
					}
				}

				public OHYePZWWPpLilrpHniDWRcaZSap(string name, OHYePZWWPpLilrpHniDWRcaZSap parent)
				{
					kKDfGMxMvbfrZIlPuNxkGciRTym = name;
					mQXiYotjnToDecfWIRfktslJAMQ = parent;
					parent?.MNocOGgnOjHKgIJmbWCTrKnAAKE(this);
				}

				public void MNocOGgnOjHKgIJmbWCTrKnAAKE(OHYePZWWPpLilrpHniDWRcaZSap P_0)
				{
					if (P_0 != null)
					{
						if (UgMoOIlddBlMQwgaxMdXKRdXAge == null)
						{
							UgMoOIlddBlMQwgaxMdXKRdXAge = new List<OHYePZWWPpLilrpHniDWRcaZSap>();
						}
						UgMoOIlddBlMQwgaxMdXKRdXAge.Add(P_0);
					}
				}

				public void IpVnOsYpylhcYmroeDQigpEJOwd(string P_0, string P_1)
				{
					if (!string.IsNullOrEmpty(P_0))
					{
						if (JWaUpfSdHFpjmGdrwiiKFHSWlnM == null)
						{
							JWaUpfSdHFpjmGdrwiiKFHSWlnM = new Dictionary<string, string>();
						}
						if (JWaUpfSdHFpjmGdrwiiKFHSWlnM.ContainsKey(P_0))
						{
							JWaUpfSdHFpjmGdrwiiKFHSWlnM[P_0] = P_1;
						}
						else
						{
							JWaUpfSdHFpjmGdrwiiKFHSWlnM.Add(P_0, P_1);
						}
					}
				}

				public bool ttdXVbZRAnZEsKCxPagjLdVJQlr(string P_0)
				{
					return XlQEovhLzUBhdMDXWlzjLtULJJeH(P_0) != null;
				}

				public OHYePZWWPpLilrpHniDWRcaZSap XlQEovhLzUBhdMDXWlzjLtULJJeH(string P_0)
				{
					if (SWUammnVJReCJYxUcFEwpgnqNPH == 0)
					{
						return null;
					}
					for (int i = 0; i < UgMoOIlddBlMQwgaxMdXKRdXAge.Count; i++)
					{
						if (string.Equals(UgMoOIlddBlMQwgaxMdXKRdXAge[i].kKDfGMxMvbfrZIlPuNxkGciRTym, P_0, StringComparison.Ordinal))
						{
							return UgMoOIlddBlMQwgaxMdXKRdXAge[i];
						}
					}
					return null;
				}

				public object zYRyxRRRqMqfMZVpIZNGuOSAjsW()
				{
					if (SWUammnVJReCJYxUcFEwpgnqNPH == 0)
					{
						return rNicKeGVINJHooQsSUZgLEEnLMk;
					}
					SerializedObject serializedObject = new SerializedObject(null, ObjectType.List);
					for (int i = 0; i < SWUammnVJReCJYxUcFEwpgnqNPH; i++)
					{
						OHYePZWWPpLilrpHniDWRcaZSap oHYePZWWPpLilrpHniDWRcaZSap = UgMoOIlddBlMQwgaxMdXKRdXAge[i];
						if (oHYePZWWPpLilrpHniDWRcaZSap != null)
						{
							serializedObject.Add(oHYePZWWPpLilrpHniDWRcaZSap.kKDfGMxMvbfrZIlPuNxkGciRTym, oHYePZWWPpLilrpHniDWRcaZSap.zYRyxRRRqMqfMZVpIZNGuOSAjsW());
						}
					}
					return serializedObject;
				}

				public override string ToString()
				{
					return SdMFOQikvQWvzTwnlQBRkSIpugCu("", 0);
				}

				private string SdMFOQikvQWvzTwnlQBRkSIpugCu(string P_0, int P_1)
				{
					string text = "";
					for (int i = 0; i < P_1; i++)
					{
						text += "    ";
					}
					string text2 = P_0;
					P_0 = text2 + text + "Name = " + kKDfGMxMvbfrZIlPuNxkGciRTym + "\n";
					string text3 = P_0;
					P_0 = text3 + text + "Content = " + ((rNicKeGVINJHooQsSUZgLEEnLMk == null) ? "NULL" : rNicKeGVINJHooQsSUZgLEEnLMk.ToString()) + "\n";
					object obj = P_0;
					P_0 = string.Concat(obj, text, "Attribute Count = ", LUMWQPqVBecmopgJmLKgHHUIrHJ, "\n");
					if (JWaUpfSdHFpjmGdrwiiKFHSWlnM != null)
					{
						foreach (KeyValuePair<string, string> item in JWaUpfSdHFpjmGdrwiiKFHSWlnM)
						{
							string text4 = P_0;
							P_0 = text4 + text + "Attribute " + item.Key + ": = " + item.Value + "\n";
						}
					}
					object obj2 = P_0;
					P_0 = string.Concat(obj2, text, "Child Count = ", SWUammnVJReCJYxUcFEwpgnqNPH, "\n");
					if (UgMoOIlddBlMQwgaxMdXKRdXAge != null)
					{
						string text5 = "";
						foreach (OHYePZWWPpLilrpHniDWRcaZSap item2 in UgMoOIlddBlMQwgaxMdXKRdXAge)
						{
							text5 += "\n";
							text5 = item2.SdMFOQikvQWvzTwnlQBRkSIpugCu(text5, P_1 + 1);
						}
						P_0 += text5;
					}
					return P_0;
				}
			}

			private readonly OHYePZWWPpLilrpHniDWRcaZSap dOSMOoJWCbYOFVloOFvJVxWtxMR;

			public OHYePZWWPpLilrpHniDWRcaZSap NBFgvNFECPNoPTEOiaLFiWnwwlQ => dOSMOoJWCbYOFVloOFvJVxWtxMR;

			public bool SUieynyjoelHWxONjYlBAYlrJqa => dOSMOoJWCbYOFVloOFvJVxWtxMR != null;

			public mQexZElgxheWivTdrfuznZgWdIZ(string xml)
			{
				if (string.IsNullOrEmpty(xml))
				{
					throw new ArgumentNullException("xml");
				}
				try
				{
					using StringReader input = new StringReader(xml);
					XmlReader xmlReader = XmlReader.Create(input);
					if (xmlReader == null)
					{
						throw new ArgumentNullException("reader");
					}
					dOSMOoJWCbYOFVloOFvJVxWtxMR = new OHYePZWWPpLilrpHniDWRcaZSap("Root", null);
					hhOaCGPrOjefTZIMrAJUqSRuNXc(xmlReader);
				}
				catch
				{
					dOSMOoJWCbYOFVloOFvJVxWtxMR = null;
				}
			}

			private void hhOaCGPrOjefTZIMrAJUqSRuNXc(XmlReader P_0)
			{
				OHYePZWWPpLilrpHniDWRcaZSap oHYePZWWPpLilrpHniDWRcaZSap = dOSMOoJWCbYOFVloOFvJVxWtxMR;
				int num = 0;
				while (P_0.Read())
				{
					XmlNodeType nodeType = P_0.NodeType;
					if (nodeType == XmlNodeType.Comment || nodeType == XmlNodeType.XmlDeclaration)
					{
						num++;
						continue;
					}
					bool flag = false;
					if (P_0.NodeType == XmlNodeType.Element)
					{
						if (P_0.IsStartElement())
						{
							_ = P_0.IsEmptyElement;
							oHYePZWWPpLilrpHniDWRcaZSap = new OHYePZWWPpLilrpHniDWRcaZSap(P_0.LocalName, oHYePZWWPpLilrpHniDWRcaZSap);
							for (int i = 0; i < P_0.AttributeCount; i++)
							{
								P_0.MoveToNextAttribute();
								oHYePZWWPpLilrpHniDWRcaZSap.IpVnOsYpylhcYmroeDQigpEJOwd(P_0.Name, P_0.Value);
							}
							if (P_0.IsEmptyElement)
							{
								flag = true;
							}
						}
					}
					else if (P_0.NodeType == XmlNodeType.Text)
					{
						if (!P_0.IsEmptyElement && P_0.HasValue)
						{
							oHYePZWWPpLilrpHniDWRcaZSap.rNicKeGVINJHooQsSUZgLEEnLMk = P_0.ReadContentAsString();
						}
						else
						{
							flag = true;
						}
					}
					else
					{
						_ = P_0.NodeType;
						_ = 15;
					}
					if ((flag || P_0.NodeType == XmlNodeType.EndElement) && oHYePZWWPpLilrpHniDWRcaZSap != null && oHYePZWWPpLilrpHniDWRcaZSap != dOSMOoJWCbYOFVloOFvJVxWtxMR && P_0.Name == oHYePZWWPpLilrpHniDWRcaZSap.kKDfGMxMvbfrZIlPuNxkGciRTym)
					{
						oHYePZWWPpLilrpHniDWRcaZSap = oHYePZWWPpLilrpHniDWRcaZSap.mQXiYotjnToDecfWIRfktslJAMQ;
					}
					num++;
				}
			}

			public override string ToString()
			{
				if (dOSMOoJWCbYOFVloOFvJVxWtxMR == null || dOSMOoJWCbYOFVloOFvJVxWtxMR.SWUammnVJReCJYxUcFEwpgnqNPH == 0)
				{
					return "Document is empty.";
				}
				return dOSMOoJWCbYOFVloOFvJVxWtxMR.ToString();
			}
		}

		private readonly IndexedDictionary<string, LckSdujMDFsxiSrBnhMHWDIAxoX> AWPWSlodgtgGrzrIXFFMDsqAOdPs;

		private XmlInfo IlpkgtSgnGdKyJNziIKaicYrLDNo;

		private Type YApegNposatXaqxKKfTqnMxXGsJ;

		private ObjectType XGvDPwLHSegIFnSPXazOheVWvpD;

		private static readonly Dictionary<Type, Dictionary<string, FieldInfo>> SRMDzuEyilNVowNyOvkOvckFzpw = new Dictionary<Type, Dictionary<string, FieldInfo>>();

		private static readonly Dictionary<Type, Dictionary<string, PropertyInfo>> yBVUjqPaMXjiGkkRYJXufFpCjFzQ = new Dictionary<Type, Dictionary<string, PropertyInfo>>();

		[CompilerGenerated]
		private static Func<FieldInfo, bool> LotWtnPDJdoYmvZxratQvQagYKU;

		[CompilerGenerated]
		private static Func<FieldInfo, string> pectuQcVPqrHcaPDJtuIjnCUgQY;

		[CompilerGenerated]
		private static Func<PropertyInfo, bool> SoDCtAMcNFytDwDaeWrtbQKsxmA;

		[CompilerGenerated]
		private static Func<PropertyInfo, string> spAMKMGEfrRzloDRkFHpzqSprJr;

		private bool allowDuplicateKeys => XGvDPwLHSegIFnSPXazOheVWvpD == ObjectType.List;

		public ObjectType objectType
		{
			get
			{
				return XGvDPwLHSegIFnSPXazOheVWvpD;
			}
			set
			{
				if (value != XGvDPwLHSegIFnSPXazOheVWvpD)
				{
					XGvDPwLHSegIFnSPXazOheVWvpD = value;
					AWPWSlodgtgGrzrIXFFMDsqAOdPs.AllowDuplicateKeys = allowDuplicateKeys;
				}
			}
		}

		public Type type => YApegNposatXaqxKKfTqnMxXGsJ;

		public XmlInfo xmlInfo
		{
			get
			{
				return IlpkgtSgnGdKyJNziIKaicYrLDNo;
			}
			set
			{
				IlpkgtSgnGdKyJNziIKaicYrLDNo = value;
			}
		}

		public int count => AWPWSlodgtgGrzrIXFFMDsqAOdPs.Count;

		public Field this[int index]
		{
			get
			{
				LckSdujMDFsxiSrBnhMHWDIAxoX lckSdujMDFsxiSrBnhMHWDIAxoX = AWPWSlodgtgGrzrIXFFMDsqAOdPs[index];
				string keyAt = AWPWSlodgtgGrzrIXFFMDsqAOdPs.GetKeyAt(index);
				return new Field(keyAt, lckSdujMDFsxiSrBnhMHWDIAxoX.foSRcEqSuRsWnadDiKcGnhBewOU, lckSdujMDFsxiSrBnhMHWDIAxoX.flYmSKXdxEbrkbApyjuUarnstyO, lckSdujMDFsxiSrBnhMHWDIAxoX.vMJrGnmziUNIcpRVnCigQssqgyZ);
			}
		}

		bool IExportToXml.writesOwnElementTag => true;

		[CustomObfuscation(rename = false)]
		private SerializedObject()
			: this(0)
		{
		}

		private SerializedObject(int capacity)
		{
			XGvDPwLHSegIFnSPXazOheVWvpD = ObjectType.List;
			AWPWSlodgtgGrzrIXFFMDsqAOdPs = new IndexedDictionary<string, LckSdujMDFsxiSrBnhMHWDIAxoX>(capacity, allowDuplicateKeys: true);
		}

		public SerializedObject(Type type, ObjectType objectType)
			: this(type, objectType, 0)
		{
		}

		public SerializedObject(Type type, ObjectType objectType, int capacity)
			: this(capacity)
		{
			YApegNposatXaqxKKfTqnMxXGsJ = type;
			this.objectType = objectType;
		}

		public SerializedObject(Type type, IDictionary<string, object> dictionary, ObjectType objectType)
			: this(type, objectType, dictionary?.Count ?? 0)
		{
			if ((object)type == null)
			{
				throw new ArgumentNullException("dictionary");
			}
			foreach (KeyValuePair<string, object> item in dictionary)
			{
				AWPWSlodgtgGrzrIXFFMDsqAOdPs.Add(item.Key, new LckSdujMDFsxiSrBnhMHWDIAxoX((item.Value != null) ? item.Value.GetType() : null, item.Value, FieldOptions.None));
			}
		}

		public void Add<T>(string fieldName, T value, FieldOptions options = FieldOptions.None)
		{
			Add(typeof(T), fieldName, value, options);
		}

		public void Add(Type type, string fieldName, object value, FieldOptions options = FieldOptions.None)
		{
			if ((object)type != null && value != null && !object.ReferenceEquals(type, value.GetType()))
			{
				throw new Exception("Type does not match value type.");
			}
			if (string.IsNullOrEmpty(fieldName))
			{
				if (XGvDPwLHSegIFnSPXazOheVWvpD != ObjectType.List)
				{
					throw new ArgumentNullException("fieldName");
				}
				fieldName = "value";
			}
			if (allowDuplicateKeys)
			{
				AWPWSlodgtgGrzrIXFFMDsqAOdPs.Add(fieldName, new LckSdujMDFsxiSrBnhMHWDIAxoX(type, value, options));
			}
			else if (!AWPWSlodgtgGrzrIXFFMDsqAOdPs.ContainsKey(fieldName))
			{
				AWPWSlodgtgGrzrIXFFMDsqAOdPs.Add(fieldName, new LckSdujMDFsxiSrBnhMHWDIAxoX(type, value, options));
			}
			else
			{
				AWPWSlodgtgGrzrIXFFMDsqAOdPs.SetValue(fieldName, new LckSdujMDFsxiSrBnhMHWDIAxoX(type, value, options));
			}
		}

		public void Add(string fieldName, object value)
		{
			Add(value?.GetType(), fieldName, value);
		}

		public bool Remove(string fieldName)
		{
			if (string.IsNullOrEmpty(fieldName))
			{
				return false;
			}
			return AWPWSlodgtgGrzrIXFFMDsqAOdPs.Remove(fieldName);
		}

		public bool Contains(string fieldName)
		{
			if (string.IsNullOrEmpty(fieldName))
			{
				return false;
			}
			return AWPWSlodgtgGrzrIXFFMDsqAOdPs.ContainsKey(fieldName);
		}

		public Type GetDataType(string fieldName)
		{
			if (string.IsNullOrEmpty(fieldName))
			{
				return null;
			}
			if (!AWPWSlodgtgGrzrIXFFMDsqAOdPs.TryGetValue(fieldName, out var value))
			{
				return null;
			}
			return value.flYmSKXdxEbrkbApyjuUarnstyO;
		}

		public bool TryGetOriginalValue(string fieldName, out object value)
		{
			value = null;
			if (string.IsNullOrEmpty(fieldName))
			{
				return false;
			}
			if (!AWPWSlodgtgGrzrIXFFMDsqAOdPs.TryGetValue(fieldName, out var value2))
			{
				return false;
			}
			value = value2.foSRcEqSuRsWnadDiKcGnhBewOU;
			return true;
		}

		public Field GetEntry(string fieldName)
		{
			KeyValuePair<string, LckSdujMDFsxiSrBnhMHWDIAxoX> entry = AWPWSlodgtgGrzrIXFFMDsqAOdPs.GetEntry(fieldName);
			return new Field(entry.Key, entry.Value.foSRcEqSuRsWnadDiKcGnhBewOU, entry.Value.flYmSKXdxEbrkbApyjuUarnstyO, entry.Value.vMJrGnmziUNIcpRVnCigQssqgyZ);
		}

		public object GetOriginalValue(string fieldName)
		{
			return AWPWSlodgtgGrzrIXFFMDsqAOdPs.GetEntry(fieldName).Value.foSRcEqSuRsWnadDiKcGnhBewOU;
		}

		public object GetOriginalValue(int index)
		{
			return AWPWSlodgtgGrzrIXFFMDsqAOdPs[index].foSRcEqSuRsWnadDiKcGnhBewOU;
		}

		public T GetOriginalValue<T>(string fieldName)
		{
			return (T)GetOriginalValue(fieldName);
		}

		public T GetOriginalValue<T>(int index)
		{
			return (T)GetOriginalValue(index);
		}

		public bool TryGetDeserializedValue<T>(string fieldName, out T value)
		{
			if (string.IsNullOrEmpty(fieldName))
			{
				value = default(T);
				return false;
			}
			if (!AWPWSlodgtgGrzrIXFFMDsqAOdPs.TryGetValue(fieldName, out var value2))
			{
				value = default(T);
				return false;
			}
			return IlORqCfBSzzprKbGKcccvXnXQFA<T>(value2.foSRcEqSuRsWnadDiKcGnhBewOU, out value, NumberStyles.Any, CultureInfo.InvariantCulture);
		}

		public bool TryGetDeserializedValue<T>(int index, out T value)
		{
			if ((uint)index > (uint)AWPWSlodgtgGrzrIXFFMDsqAOdPs.Count)
			{
				value = default(T);
				return false;
			}
			return IlORqCfBSzzprKbGKcccvXnXQFA<T>(AWPWSlodgtgGrzrIXFFMDsqAOdPs.GetEntryAt(index).Value.foSRcEqSuRsWnadDiKcGnhBewOU, out value, NumberStyles.Any, CultureInfo.InvariantCulture);
		}

		public bool TryGetDeserializedValueByRef<T>(string fieldName, ref T value)
		{
			if (string.IsNullOrEmpty(fieldName))
			{
				return false;
			}
			if (!TryGetDeserializedValue<T>(fieldName, out var value2))
			{
				return false;
			}
			value = value2;
			return true;
		}

		public bool TryGetDeserializedValueByRef<T>(int index, ref T value)
		{
			if ((uint)index > (uint)AWPWSlodgtgGrzrIXFFMDsqAOdPs.Count)
			{
				return false;
			}
			if (!TryGetDeserializedValue<T>(index, out var value2))
			{
				return false;
			}
			value = value2;
			return true;
		}

		public string ToXmlString(bool writeDocumentTag)
		{
			if (IlpkgtSgnGdKyJNziIKaicYrLDNo == null)
			{
				throw new Exception("XmlInfo is null. Cannot write Xml without XmlInfo.");
			}
			string empty = string.Empty;
			using StringWriter stringWriter = new StringWriter();
			using (XmlWriter xmlWriter = XmlWriter.Create(stringWriter))
			{
				if (writeDocumentTag)
				{
					xmlWriter.WriteStartDocument();
				}
				xMfVBCbgxofmtUGevnNtQLlWKKY(xmlWriter);
				xmlWriter.Flush();
			}
			return stringWriter.ToString();
		}

		public string ToJsonString()
		{
			return JsonWriter.ToJson(this);
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("count = ");
			stringBuilder.Append(count.ToString());
			stringBuilder.Append("\n");
			stringBuilder.Append("type = ");
			stringBuilder.Append(((object)YApegNposatXaqxKKfTqnMxXGsJ != null) ? YApegNposatXaqxKKfTqnMxXGsJ.Name : "NULL\n");
			stringBuilder.Append("objectType = ");
			stringBuilder.Append(XGvDPwLHSegIFnSPXazOheVWvpD.ToString());
			stringBuilder.Append("\n");
			stringBuilder.Append("xmlInfo = ");
			stringBuilder.Append((IlpkgtSgnGdKyJNziIKaicYrLDNo != null) ? IlpkgtSgnGdKyJNziIKaicYrLDNo.ToString() : "NULL\n");
			stringBuilder.Append("\n");
			for (int i = 0; i < AWPWSlodgtgGrzrIXFFMDsqAOdPs.Count; i++)
			{
				string keyAt = AWPWSlodgtgGrzrIXFFMDsqAOdPs.GetKeyAt(i);
				stringBuilder.Append("key = ");
				stringBuilder.Append((keyAt != null) ? keyAt : "NULL");
				stringBuilder.Append(", value = ");
				stringBuilder.Append(AWPWSlodgtgGrzrIXFFMDsqAOdPs[i].ToString());
				stringBuilder.Append("\n");
			}
			return stringBuilder.ToString();
		}

		private void xMfVBCbgxofmtUGevnNtQLlWKKY(XmlWriter P_0)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException("writer");
			}
			P_0.WriteStartElement(type.Name, "http://guavaman.com/rewired");
			ZeVAWWLIIntrTDyXuKjUTqTUqfY(P_0);
			P_0.WriteEndElement();
		}

		private void ZeVAWWLIIntrTDyXuKjUTqTUqfY(XmlWriter P_0)
		{
			int num = ((xmlInfo != null) ? xmlInfo.attributes.Count : 0);
			for (int i = 0; i < num; i++)
			{
				XmlInfo.HDPGiVoBXLVCodlSiugSdJIEGou hDPGiVoBXLVCodlSiugSdJIEGou = xmlInfo.attributes[i];
				if (hDPGiVoBXLVCodlSiugSdJIEGou is XmlInfo.kwLxndskJikCtPGLslSPWsTXCTW)
				{
					XmlInfo.kwLxndskJikCtPGLslSPWsTXCTW kwLxndskJikCtPGLslSPWsTXCTW = hDPGiVoBXLVCodlSiugSdJIEGou as XmlInfo.kwLxndskJikCtPGLslSPWsTXCTW;
					if (!string.IsNullOrEmpty(kwLxndskJikCtPGLslSPWsTXCTW.jveufREDmiaHzvZNPCiXJKHYoFA))
					{
						P_0.WriteAttributeString(kwLxndskJikCtPGLslSPWsTXCTW.jveufREDmiaHzvZNPCiXJKHYoFA, kwLxndskJikCtPGLslSPWsTXCTW.FaRCzmOJYwGVoyOIjhyHpMferPo, kwLxndskJikCtPGLslSPWsTXCTW.ErZkPlJPCSFziEkQUXjksErSMGjf, kwLxndskJikCtPGLslSPWsTXCTW.foSRcEqSuRsWnadDiKcGnhBewOU);
					}
					else if (!string.IsNullOrEmpty(kwLxndskJikCtPGLslSPWsTXCTW.ErZkPlJPCSFziEkQUXjksErSMGjf))
					{
						P_0.WriteAttributeString(kwLxndskJikCtPGLslSPWsTXCTW.FaRCzmOJYwGVoyOIjhyHpMferPo, kwLxndskJikCtPGLslSPWsTXCTW.ErZkPlJPCSFziEkQUXjksErSMGjf, kwLxndskJikCtPGLslSPWsTXCTW.foSRcEqSuRsWnadDiKcGnhBewOU);
					}
					else
					{
						P_0.WriteAttributeString(kwLxndskJikCtPGLslSPWsTXCTW.FaRCzmOJYwGVoyOIjhyHpMferPo, kwLxndskJikCtPGLslSPWsTXCTW.foSRcEqSuRsWnadDiKcGnhBewOU);
					}
					continue;
				}
				throw new NotImplementedException();
			}
			for (int j = 0; j < count; j++)
			{
				LckSdujMDFsxiSrBnhMHWDIAxoX lckSdujMDFsxiSrBnhMHWDIAxoX = AWPWSlodgtgGrzrIXFFMDsqAOdPs[j];
				string text = AWPWSlodgtgGrzrIXFFMDsqAOdPs.GetKeyAt(j);
				if ((lckSdujMDFsxiSrBnhMHWDIAxoX.vMJrGnmziUNIcpRVnCigQssqgyZ & FieldOptions.ExculdeFromXml) == 0)
				{
					if (string.IsNullOrEmpty(text))
					{
						text = (((object)lckSdujMDFsxiSrBnhMHWDIAxoX.flYmSKXdxEbrkbApyjuUarnstyO != null) ? lckSdujMDFsxiSrBnhMHWDIAxoX.GetType().Name : ((lckSdujMDFsxiSrBnhMHWDIAxoX.foSRcEqSuRsWnadDiKcGnhBewOU == null) ? "value" : lckSdujMDFsxiSrBnhMHWDIAxoX.foSRcEqSuRsWnadDiKcGnhBewOU.GetType().Name));
					}
					SerializationTools.WriteXmlElement(P_0, text, lckSdujMDFsxiSrBnhMHWDIAxoX.foSRcEqSuRsWnadDiKcGnhBewOU);
				}
			}
		}

		private void fQArbIiHzVPBhfWCjCzZaPRzsmZ(XmlWriter P_0)
		{
			xMfVBCbgxofmtUGevnNtQLlWKKY(P_0);
		}

		void IExportToXml.WriteXml(XmlWriter P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in fQArbIiHzVPBhfWCjCzZaPRzsmZ
			this.fQArbIiHzVPBhfWCjCzZaPRzsmZ(P_0);
		}

		private void hCORXvhtpJgWiIAEVhxtOsowmbM(StringBuilder P_0, Action<StringBuilder, object> P_1)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException("stringBuilder");
			}
			if (P_1 == null)
			{
				throw new ArgumentNullException("appendValueDelegate");
			}
			int num = AWPWSlodgtgGrzrIXFFMDsqAOdPs.Count;
			if (AWPWSlodgtgGrzrIXFFMDsqAOdPs.ContainsDuplicateKeys)
			{
				P_0.Append('[');
				bool flag = true;
				for (int i = 0; i < num; i++)
				{
					if (flag)
					{
						flag = false;
					}
					else
					{
						P_0.Append(',');
					}
					P_1(P_0, AWPWSlodgtgGrzrIXFFMDsqAOdPs[i].foSRcEqSuRsWnadDiKcGnhBewOU);
				}
				P_0.Append(']');
				return;
			}
			P_0.Append('{');
			bool flag2 = true;
			for (int j = 0; j < num; j++)
			{
				if (flag2)
				{
					flag2 = false;
				}
				else
				{
					P_0.Append(',');
				}
				LckSdujMDFsxiSrBnhMHWDIAxoX lckSdujMDFsxiSrBnhMHWDIAxoX = AWPWSlodgtgGrzrIXFFMDsqAOdPs[j];
				string value = AWPWSlodgtgGrzrIXFFMDsqAOdPs.GetKeyAt(j);
				if (string.IsNullOrEmpty(value))
				{
					value = j.ToString();
				}
				P_0.Append('"');
				P_0.Append(value);
				P_0.Append("\":");
				P_1(P_0, lckSdujMDFsxiSrBnhMHWDIAxoX.foSRcEqSuRsWnadDiKcGnhBewOU);
			}
			P_0.Append('}');
		}

		void IExportToJson.WriteJson(StringBuilder P_0, Action<StringBuilder, object> P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in hCORXvhtpJgWiIAEVhxtOsowmbM
			this.hCORXvhtpJgWiIAEVhxtOsowmbM(P_0, P_1);
		}

		private void VHlEdwAFwLiSfdvGPPNaMyfRjhxB(object P_0)
		{
			Add(null, P_0);
		}

		void IAddValue<object>.Add(object P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in VHlEdwAFwLiSfdvGPPNaMyfRjhxB
			this.VHlEdwAFwLiSfdvGPPNaMyfRjhxB(P_0);
		}

		private void boUwTquBCOxuIpGOFbgQerkTSIr(string P_0, object P_1)
		{
			Add(P_0, P_1);
		}

		void IAddKeyValue<string, object>.Add(string P_0, object P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in boUwTquBCOxuIpGOFbgQerkTSIr
			this.boUwTquBCOxuIpGOFbgQerkTSIr(P_0, P_1);
		}

		IEnumerator<Field> IEnumerable<Field>.GetEnumerator()
		{
			return new Enumerator(AWPWSlodgtgGrzrIXFFMDsqAOdPs);
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return new Enumerator(AWPWSlodgtgGrzrIXFFMDsqAOdPs);
		}

		private static bool IlORqCfBSzzprKbGKcccvXnXQFA<T>(object P_0, out T P_1, NumberStyles P_2 = NumberStyles.Any, CultureInfo P_3 = null)
		{
			if (!IlORqCfBSzzprKbGKcccvXnXQFA(typeof(T), P_0, out var obj, P_2, P_3))
			{
				P_1 = default(T);
				return false;
			}
			P_1 = (T)obj;
			return true;
		}

		private static bool IlORqCfBSzzprKbGKcccvXnXQFA(Type P_0, object P_1, out object P_2, NumberStyles P_3 = NumberStyles.Any, CultureInfo P_4 = null)
		{
			P_2 = null;
			if (P_1 == null)
			{
				if (object.ReferenceEquals(P_0, typeof(string)))
				{
					P_2 = string.Empty;
					return true;
				}
				if (!ReflectionTools.IsValueType(P_0))
				{
					return true;
				}
				if ((object)Nullable.GetUnderlyingType(P_0) != null)
				{
					return true;
				}
				return false;
			}
			Type type = P_1.GetType();
			if (object.ReferenceEquals(P_0, type))
			{
				P_2 = P_1;
				return true;
			}
			try
			{
				if (object.ReferenceEquals(P_0, typeof(string)))
				{
					P_2 = P_1.ToString();
					return true;
				}
				if (object.ReferenceEquals(P_0, typeof(int)))
				{
					if (object.ReferenceEquals(type, typeof(float)))
					{
						P_2 = (int)(float)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(uint)))
					{
						P_2 = (int)(uint)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(long)))
					{
						P_2 = (int)(long)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(ulong)))
					{
						P_2 = (int)(ulong)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(double)))
					{
						P_2 = (int)(double)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(decimal)))
					{
						P_2 = (int)(decimal)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(short)))
					{
						P_2 = (int)(short)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(ushort)))
					{
						P_2 = (int)(ushort)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(byte)))
					{
						P_2 = (int)(byte)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(sbyte)))
					{
						P_2 = (int)(sbyte)P_1;
					}
					else
					{
						if (!object.ReferenceEquals(type, typeof(string)))
						{
							return false;
						}
						int result;
						if (P_4 != null)
						{
							if (!int.TryParse(P_1.ToString(), P_3, P_4, out result))
							{
								return false;
							}
						}
						else if (!int.TryParse(P_1.ToString(), out result))
						{
							return false;
						}
						P_2 = result;
					}
					return true;
				}
				if (object.ReferenceEquals(P_0, typeof(float)))
				{
					if (object.ReferenceEquals(type, typeof(int)))
					{
						P_2 = (float)(int)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(uint)))
					{
						P_2 = (float)(uint)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(long)))
					{
						P_2 = (float)(long)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(ulong)))
					{
						P_2 = (float)(ulong)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(double)))
					{
						P_2 = (float)(double)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(decimal)))
					{
						P_2 = (float)(decimal)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(short)))
					{
						P_2 = (float)(short)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(ushort)))
					{
						P_2 = (float)(int)(ushort)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(byte)))
					{
						P_2 = (float)(int)(byte)P_1;
					}
					else if (object.ReferenceEquals(type, typeof(sbyte)))
					{
						P_2 = (float)(sbyte)P_1;
					}
					else
					{
						if (!object.ReferenceEquals(type, typeof(string)))
						{
							return false;
						}
						float result2;
						if (P_4 != null)
						{
							if (!float.TryParse(P_1.ToString(), P_3, P_4, out result2))
							{
								return false;
							}
						}
						else if (!float.TryParse(P_1.ToString(), out result2))
						{
							return false;
						}
						P_2 = result2;
					}
					return true;
				}
				if (ReflectionTools.IsEnum(P_0))
				{
					Type underlyingEnumType = ReflectionTools.GetUnderlyingEnumType(P_0);
					if (IlORqCfBSzzprKbGKcccvXnXQFA(underlyingEnumType, P_1, out var value, P_3, P_4))
					{
						P_2 = Enum.ToObject(P_0, value);
						return true;
					}
					if (object.ReferenceEquals(type, typeof(string)))
					{
						try
						{
							P_2 = Enum.Parse(P_0, (string)P_1, ignoreCase: true);
							return true;
						}
						catch
						{
							P_2 = null;
							return false;
						}
					}
				}
				else
				{
					if (object.ReferenceEquals(P_0, typeof(uint)))
					{
						if (object.ReferenceEquals(type, typeof(int)))
						{
							P_2 = (uint)(int)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(float)))
						{
							P_2 = (uint)(float)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(long)))
						{
							P_2 = (uint)(long)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(ulong)))
						{
							P_2 = (uint)(ulong)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(double)))
						{
							P_2 = (uint)(double)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(decimal)))
						{
							P_2 = (uint)(decimal)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(short)))
						{
							P_2 = (uint)(short)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(ushort)))
						{
							P_2 = (uint)(ushort)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(byte)))
						{
							P_2 = (uint)(byte)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(sbyte)))
						{
							P_2 = (uint)(sbyte)P_1;
						}
						else
						{
							if (!object.ReferenceEquals(type, typeof(string)))
							{
								return false;
							}
							uint result3;
							if (P_4 != null)
							{
								if (!uint.TryParse(P_1.ToString(), P_3, P_4, out result3))
								{
									return false;
								}
							}
							else if (!uint.TryParse(P_1.ToString(), out result3))
							{
								return false;
							}
							P_2 = result3;
						}
						return true;
					}
					if (object.ReferenceEquals(P_0, typeof(double)))
					{
						if (object.ReferenceEquals(type, typeof(float)))
						{
							P_2 = (double)(float)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(int)))
						{
							P_2 = (double)(int)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(uint)))
						{
							P_2 = (double)(uint)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(long)))
						{
							P_2 = (double)(long)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(ulong)))
						{
							P_2 = (double)(ulong)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(short)))
						{
							P_2 = (double)(short)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(ushort)))
						{
							P_2 = (double)(int)(ushort)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(byte)))
						{
							P_2 = (double)(int)(byte)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(sbyte)))
						{
							P_2 = (double)(sbyte)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(decimal)))
						{
							P_2 = (double)(decimal)P_1;
						}
						else
						{
							if (!object.ReferenceEquals(type, typeof(string)))
							{
								return false;
							}
							double result4;
							if (P_4 != null)
							{
								if (!double.TryParse(P_1.ToString(), P_3, P_4, out result4))
								{
									return false;
								}
							}
							else if (!double.TryParse(P_1.ToString(), out result4))
							{
								return false;
							}
							P_2 = result4;
						}
						return true;
					}
					if (object.ReferenceEquals(P_0, typeof(bool)))
					{
						if (object.ReferenceEquals(type, typeof(int)))
						{
							P_2 = (int)P_1 > 0;
						}
						else if (object.ReferenceEquals(type, typeof(float)))
						{
							P_2 = (float)P_1 > 0f;
						}
						else if (object.ReferenceEquals(type, typeof(uint)))
						{
							P_2 = (uint)P_1 != 0;
						}
						else if (object.ReferenceEquals(type, typeof(long)))
						{
							P_2 = (long)P_1 > 0;
						}
						else if (object.ReferenceEquals(type, typeof(ulong)))
						{
							P_2 = (ulong)P_1 != 0;
						}
						else if (object.ReferenceEquals(type, typeof(double)))
						{
							P_2 = (double)P_1 > 0.0;
						}
						else if (object.ReferenceEquals(type, typeof(decimal)))
						{
							P_2 = (decimal)P_1 > 0m;
						}
						else if (object.ReferenceEquals(type, typeof(short)))
						{
							P_2 = (short)P_1 > 0;
						}
						else if (object.ReferenceEquals(type, typeof(ushort)))
						{
							P_2 = (ushort)P_1 > 0;
						}
						else if (object.ReferenceEquals(type, typeof(byte)))
						{
							P_2 = (byte)P_1 > 0;
						}
						else if (object.ReferenceEquals(type, typeof(sbyte)))
						{
							P_2 = (sbyte)P_1 > 0;
						}
						else
						{
							if (!object.ReferenceEquals(type, typeof(string)))
							{
								return false;
							}
							if (string.Equals((string)P_1, "true", StringComparison.OrdinalIgnoreCase))
							{
								P_2 = true;
							}
							else
							{
								if (!string.Equals((string)P_1, "false", StringComparison.OrdinalIgnoreCase))
								{
									return false;
								}
								P_2 = false;
							}
						}
						return true;
					}
					if (object.ReferenceEquals(P_0, typeof(long)))
					{
						if (object.ReferenceEquals(type, typeof(int)))
						{
							P_2 = (long)(int)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(ulong)))
						{
							P_2 = (long)(ulong)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(float)))
						{
							P_2 = (long)(float)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(uint)))
						{
							P_2 = (long)(uint)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(double)))
						{
							P_2 = (long)(double)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(decimal)))
						{
							P_2 = (long)(decimal)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(short)))
						{
							P_2 = (long)(short)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(ushort)))
						{
							P_2 = (long)(ushort)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(byte)))
						{
							P_2 = (long)(byte)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(sbyte)))
						{
							P_2 = (long)(sbyte)P_1;
						}
						else
						{
							if (!object.ReferenceEquals(type, typeof(string)))
							{
								return false;
							}
							long result5;
							if (P_4 != null)
							{
								if (!long.TryParse(P_1.ToString(), P_3, P_4, out result5))
								{
									return false;
								}
							}
							else if (!long.TryParse(P_1.ToString(), out result5))
							{
								return false;
							}
							P_2 = result5;
						}
						return true;
					}
					if (object.ReferenceEquals(P_0, typeof(ulong)))
					{
						if (object.ReferenceEquals(type, typeof(long)))
						{
							P_2 = (ulong)(long)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(int)))
						{
							P_2 = (ulong)(int)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(float)))
						{
							P_2 = (ulong)(float)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(uint)))
						{
							P_2 = (ulong)(uint)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(double)))
						{
							P_2 = (ulong)(double)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(decimal)))
						{
							P_2 = (ulong)(decimal)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(short)))
						{
							P_2 = (ulong)(short)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(ushort)))
						{
							P_2 = (ulong)(ushort)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(byte)))
						{
							P_2 = (ulong)(byte)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(sbyte)))
						{
							P_2 = (ulong)(sbyte)P_1;
						}
						else
						{
							if (!object.ReferenceEquals(type, typeof(string)))
							{
								return false;
							}
							ulong result6;
							if (P_4 != null)
							{
								if (!ulong.TryParse(P_1.ToString(), P_3, P_4, out result6))
								{
									return false;
								}
							}
							else if (!ulong.TryParse(P_1.ToString(), out result6))
							{
								return false;
							}
							P_2 = result6;
						}
						return true;
					}
					if (object.ReferenceEquals(P_0, typeof(short)))
					{
						if (object.ReferenceEquals(type, typeof(ushort)))
						{
							P_2 = (short)(ushort)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(int)))
						{
							P_2 = (short)(int)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(uint)))
						{
							P_2 = (short)(uint)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(long)))
						{
							P_2 = (short)(long)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(ulong)))
						{
							P_2 = (short)(ulong)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(float)))
						{
							P_2 = (short)(float)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(double)))
						{
							P_2 = (short)(double)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(decimal)))
						{
							P_2 = (short)(decimal)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(byte)))
						{
							P_2 = (short)(byte)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(sbyte)))
						{
							P_2 = (short)(sbyte)P_1;
						}
						else
						{
							if (!object.ReferenceEquals(type, typeof(string)))
							{
								return false;
							}
							short result7;
							if (P_4 != null)
							{
								if (!short.TryParse(P_1.ToString(), P_3, P_4, out result7))
								{
									return false;
								}
							}
							else if (!short.TryParse(P_1.ToString(), out result7))
							{
								return false;
							}
							P_2 = result7;
						}
						return true;
					}
					if (object.ReferenceEquals(P_0, typeof(ushort)))
					{
						if (object.ReferenceEquals(type, typeof(short)))
						{
							P_2 = (ushort)(short)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(int)))
						{
							P_2 = (ushort)(int)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(uint)))
						{
							P_2 = (ushort)(uint)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(long)))
						{
							P_2 = (ushort)(long)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(ulong)))
						{
							P_2 = (ushort)(ulong)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(float)))
						{
							P_2 = (ushort)(float)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(double)))
						{
							P_2 = (ushort)(double)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(decimal)))
						{
							P_2 = (ushort)(decimal)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(byte)))
						{
							P_2 = (ushort)(byte)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(sbyte)))
						{
							P_2 = (ushort)(sbyte)P_1;
						}
						else
						{
							if (!object.ReferenceEquals(type, typeof(string)))
							{
								return false;
							}
							ushort result8;
							if (P_4 != null)
							{
								if (!ushort.TryParse(P_1.ToString(), P_3, P_4, out result8))
								{
									return false;
								}
							}
							else if (!ushort.TryParse(P_1.ToString(), out result8))
							{
								return false;
							}
							P_2 = result8;
						}
						return true;
					}
					if (object.ReferenceEquals(P_0, typeof(byte)))
					{
						if (object.ReferenceEquals(type, typeof(sbyte)))
						{
							P_2 = (byte)(sbyte)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(int)))
						{
							P_2 = (byte)(int)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(uint)))
						{
							P_2 = (byte)(uint)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(long)))
						{
							P_2 = (byte)(long)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(ulong)))
						{
							P_2 = (byte)(ulong)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(float)))
						{
							P_2 = (byte)(float)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(double)))
						{
							P_2 = (byte)(double)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(decimal)))
						{
							P_2 = (byte)(decimal)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(short)))
						{
							P_2 = (byte)(short)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(ushort)))
						{
							P_2 = (byte)(ushort)P_1;
						}
						else
						{
							if (!object.ReferenceEquals(type, typeof(string)))
							{
								return false;
							}
							byte result9;
							if (P_4 != null)
							{
								if (!byte.TryParse(P_1.ToString(), P_3, P_4, out result9))
								{
									return false;
								}
							}
							else if (!byte.TryParse(P_1.ToString(), out result9))
							{
								return false;
							}
							P_2 = result9;
						}
						return true;
					}
					if (object.ReferenceEquals(P_0, typeof(sbyte)))
					{
						if (object.ReferenceEquals(type, typeof(byte)))
						{
							P_2 = (sbyte)(byte)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(int)))
						{
							P_2 = (sbyte)(int)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(uint)))
						{
							P_2 = (sbyte)(uint)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(long)))
						{
							P_2 = (sbyte)(long)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(ulong)))
						{
							P_2 = (sbyte)(ulong)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(float)))
						{
							P_2 = (sbyte)(float)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(double)))
						{
							P_2 = (sbyte)(double)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(decimal)))
						{
							P_2 = (sbyte)(decimal)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(short)))
						{
							P_2 = (sbyte)(short)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(ushort)))
						{
							P_2 = (sbyte)(ushort)P_1;
						}
						else
						{
							if (!object.ReferenceEquals(type, typeof(string)))
							{
								return false;
							}
							sbyte result10;
							if (P_4 != null)
							{
								if (!sbyte.TryParse(P_1.ToString(), P_3, P_4, out result10))
								{
									return false;
								}
							}
							else if (!sbyte.TryParse(P_1.ToString(), out result10))
							{
								return false;
							}
							P_2 = result10;
						}
						return true;
					}
					if (object.ReferenceEquals(P_0, typeof(decimal)))
					{
						if (object.ReferenceEquals(type, typeof(float)))
						{
							P_2 = (decimal)(float)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(double)))
						{
							P_2 = (decimal)(double)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(int)))
						{
							P_2 = (decimal)(int)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(long)))
						{
							P_2 = (decimal)(long)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(uint)))
						{
							P_2 = (decimal)(uint)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(ulong)))
						{
							P_2 = (decimal)(ulong)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(short)))
						{
							P_2 = (decimal)(short)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(ushort)))
						{
							P_2 = (decimal)(ushort)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(byte)))
						{
							P_2 = (decimal)(byte)P_1;
						}
						else if (object.ReferenceEquals(type, typeof(sbyte)))
						{
							P_2 = (decimal)(sbyte)P_1;
						}
						else
						{
							if (!object.ReferenceEquals(type, typeof(string)))
							{
								return false;
							}
							decimal result11;
							if (P_4 != null)
							{
								if (!decimal.TryParse(P_1.ToString(), P_3, P_4, out result11))
								{
									return false;
								}
							}
							else if (!decimal.TryParse(P_1.ToString(), out result11))
							{
								return false;
							}
							P_2 = result11;
						}
						return true;
					}
					if (object.ReferenceEquals(P_0, typeof(char)))
					{
						P_2 = P_1.ToString();
						return true;
					}
					if (object.ReferenceEquals(P_0, typeof(Guid)))
					{
						if (object.ReferenceEquals(type, typeof(string)))
						{
							P_2 = StringTools.ToGuid((string)P_1);
							return true;
						}
						return false;
					}
					if (ReflectionTools.IsArray(P_0))
					{
						Type elementType = P_0.GetElementType();
						if (ReflectionTools.DoesTypeImplement(type, typeof(SerializedObject)))
						{
							if (!(P_1 is SerializedObject serializedObject))
							{
								return false;
							}
							Array array = Array.CreateInstance(elementType, serializedObject.count);
							for (int i = 0; i < serializedObject.count; i++)
							{
								if (IlORqCfBSzzprKbGKcccvXnXQFA(elementType, serializedObject[i].value, out var value2, P_3, P_4))
								{
									array.SetValue(value2, i);
								}
							}
							P_2 = array;
							return true;
						}
						if (ReflectionTools.DoesTypeImplement(type, typeof(IReadOnlyList)))
						{
							if (!(P_1 is IReadOnlyList readOnlyList))
							{
								return false;
							}
							Array array2 = Array.CreateInstance(elementType, readOnlyList.Count);
							for (int j = 0; j < readOnlyList.Count; j++)
							{
								if (IlORqCfBSzzprKbGKcccvXnXQFA(elementType, readOnlyList[j], out var value3, P_3, P_4))
								{
									array2.SetValue(value3, j);
								}
							}
							P_2 = array2;
							return true;
						}
						if (ReflectionTools.DoesTypeImplement(type, typeof(IList)))
						{
							if (!(P_1 is IList list))
							{
								return false;
							}
							Array array3 = Array.CreateInstance(elementType, list.Count);
							for (int k = 0; k < list.Count; k++)
							{
								if (IlORqCfBSzzprKbGKcccvXnXQFA(elementType, list[k], out var value4, P_3, P_4))
								{
									array3.SetValue(value4, k);
								}
							}
							P_2 = array3;
							return true;
						}
						if (ReflectionTools.DoesTypeImplement(type, typeof(Array)))
						{
							Array array4 = P_1 as Array;
							Array array5 = Array.CreateInstance(elementType, array4.Length);
							for (int l = 0; l < array4.Length; l++)
							{
								if (IlORqCfBSzzprKbGKcccvXnXQFA(elementType, array4.GetValue(l), out var value5, P_3, P_4))
								{
									array5.SetValue(value5, l);
								}
							}
							P_2 = array5;
							return true;
						}
						if (ReflectionTools.DoesTypeImplement(type, typeof(IDictionary)))
						{
							Type type2 = ReflectionTools.GetGenericArguments(P_0)[1];
							IDictionary dictionary = P_1 as IDictionary;
							Array array6 = Array.CreateInstance(elementType, dictionary.Count);
							int num = 0;
							foreach (object value15 in dictionary.Values)
							{
								if (IlORqCfBSzzprKbGKcccvXnXQFA(type2, value15, out var value6, P_3, P_4))
								{
									array6.SetValue(value6, num);
									num++;
								}
							}
							P_2 = array6;
							return true;
						}
						if (ReflectionTools.DoesTypeImplement(type, typeof(ICollection)))
						{
							ICollection collection = P_1 as ICollection;
							Array array7 = Array.CreateInstance(elementType, collection.Count);
							int num2 = 0;
							foreach (object item in collection)
							{
								if (IlORqCfBSzzprKbGKcccvXnXQFA(elementType, item, out var value7, P_3, P_4))
								{
									array7.SetValue(value7, num2);
									num2++;
								}
							}
							P_2 = array7;
							return true;
						}
						if (ReflectionTools.DoesTypeImplement(type, typeof(IEnumerable)))
						{
							IEnumerable enumerable = P_1 as IEnumerable;
							int num3 = 0;
							foreach (object item2 in enumerable)
							{
								_ = item2;
								num3++;
							}
							Array array8 = Array.CreateInstance(elementType, num3);
							int num4 = 0;
							foreach (object item3 in enumerable)
							{
								if (IlORqCfBSzzprKbGKcccvXnXQFA(elementType, item3, out var value8, P_3, P_4))
								{
									array8.SetValue(value8, num4);
									num4++;
								}
							}
							P_2 = array8;
							return true;
						}
						return false;
					}
					if (ReflectionTools.IsGenericType(P_0))
					{
						Type genericTypeDefinition = P_0.GetGenericTypeDefinition();
						if (ReflectionTools.DoesTypeImplement(P_0, typeof(IList)))
						{
							Type type3 = ReflectionTools.GetGenericArguments(P_0)[0];
							if (ReflectionTools.DoesTypeImplement(type, typeof(SerializedObject)))
							{
								SerializedObject serializedObject2 = P_1 as SerializedObject;
								IList list2 = (IList)Factory.CreateInstance(genericTypeDefinition.MakeGenericType(type3));
								for (int m = 0; m < serializedObject2.count; m++)
								{
									if (IlORqCfBSzzprKbGKcccvXnXQFA(type3, serializedObject2[m].value, out var value9, P_3, P_4))
									{
										list2.Add(value9);
									}
								}
								P_2 = list2;
								return true;
							}
							if (ReflectionTools.DoesTypeImplement(type, typeof(IReadOnlyList)))
							{
								IReadOnlyList readOnlyList2 = P_1 as IReadOnlyList;
								IList list3 = (IList)Factory.CreateInstance(genericTypeDefinition.MakeGenericType(type3));
								for (int n = 0; n < readOnlyList2.Count; n++)
								{
									if (IlORqCfBSzzprKbGKcccvXnXQFA(type3, readOnlyList2[n], out var value10, P_3, P_4))
									{
										list3.Add(value10);
									}
								}
								P_2 = list3;
								return true;
							}
							if (ReflectionTools.DoesTypeImplement(type, typeof(IList)))
							{
								IList list4 = P_1 as IList;
								IList list5 = (IList)Factory.CreateInstance(genericTypeDefinition.MakeGenericType(type3));
								for (int num5 = 0; num5 < list4.Count; num5++)
								{
									if (IlORqCfBSzzprKbGKcccvXnXQFA(type3, list4[num5], out var value11, P_3, P_4))
									{
										list5.Add(value11);
									}
								}
								P_2 = list5;
								return true;
							}
							if (ReflectionTools.DoesTypeImplement(type, typeof(Array)))
							{
								Array array9 = P_1 as Array;
								IList list6 = (IList)Factory.CreateInstance(genericTypeDefinition.MakeGenericType(type3));
								for (int num6 = 0; num6 < array9.Length; num6++)
								{
									if (IlORqCfBSzzprKbGKcccvXnXQFA(type3, array9.GetValue(num6), out var value12, P_3, P_4))
									{
										list6.Add(value12);
									}
								}
								P_2 = list6;
								return true;
							}
							if (ReflectionTools.DoesTypeImplement(type, typeof(IEnumerable)))
							{
								IEnumerable enumerable2 = P_1 as IEnumerable;
								IList list7 = (IList)Factory.CreateInstance(genericTypeDefinition.MakeGenericType(type3));
								foreach (object item4 in enumerable2)
								{
									if (IlORqCfBSzzprKbGKcccvXnXQFA(type3, item4, out var value13, P_3, P_4))
									{
										list7.Add(value13);
									}
								}
								P_2 = list7;
								return true;
							}
						}
						else if (ReflectionTools.DoesTypeImplement(genericTypeDefinition, typeof(IDictionary)))
						{
							Type[] genericArguments = ReflectionTools.GetGenericArguments(P_0);
							Type type4 = genericArguments[0];
							Type type5 = genericArguments[1];
							if (!(P_1 is IDictionary dictionary2))
							{
								return false;
							}
							IDictionary dictionary3 = (IDictionary)Factory.CreateInstance(genericTypeDefinition.MakeGenericType(type4, type5));
							foreach (object key2 in dictionary2.Keys)
							{
								if (IlORqCfBSzzprKbGKcccvXnXQFA(type4, key2, out var key, P_3, P_4) && IlORqCfBSzzprKbGKcccvXnXQFA(type5, dictionary2[key2], out var value14, P_3, P_4))
								{
									dictionary3.Add(key, value14);
								}
							}
							P_2 = dictionary3;
							return true;
						}
					}
				}
				if (object.ReferenceEquals(P_0, typeof(object)))
				{
					P_2 = P_1;
					return true;
				}
				if (ReflectionTools.DoesTypeImplement(type, typeof(SerializedObject)))
				{
					if (!vpFAtbfLsIkJlPkYPjVnygcOHXL(P_0, P_1 as SerializedObject, out P_1))
					{
						return false;
					}
					P_2 = P_1;
					return true;
				}
			}
			catch (Exception message)
			{
				Debug.LogError(message);
			}
			return false;
		}

		private static bool vpFAtbfLsIkJlPkYPjVnygcOHXL(Type P_0, SerializedObject P_1, out object P_2, NumberStyles P_3 = NumberStyles.Any, CultureInfo P_4 = null)
		{
			if (P_1 == null || (object)P_0 == null)
			{
				P_2 = null;
				return false;
			}
			P_2 = Factory.CreateInstance(P_0);
			if (!SRMDzuEyilNVowNyOvkOvckFzpw.TryGetValue(P_0, out var value))
			{
				string name3;
				value = (from P_0 in ReflectionTools.GetFields(P_0, ReflectionTools.BindingFlags.Instance | ReflectionTools.BindingFlags.Public | ReflectionTools.BindingFlags.NonPublic)
					where (P_0.IsPublic || P_0.IsDefined(typeof(SerializeAttribute), inherit: true) || P_0.IsDefined(typeof(SerializeField), inherit: true)) && !P_0.IsDefined(typeof(NonSerializedAttribute), inherit: true) && !P_0.IsDefined(typeof(DoNotSerializeAttribute), inherit: true)
					select P_0).ToDictionary((FieldInfo P_0) => (P_0.IsDefined(typeof(SerializeAttribute), inherit: true) && !string.IsNullOrEmpty(name3 = (CollectionTools.GetValue(P_0.GetCustomAttributes(typeof(SerializeAttribute), inherit: true), 0) as SerializeAttribute).Name)) ? name3 : P_0.Name);
				SRMDzuEyilNVowNyOvkOvckFzpw.Add(P_0, value);
			}
			if (!yBVUjqPaMXjiGkkRYJXufFpCjFzQ.TryGetValue(P_0, out var value2))
			{
				string name2;
				value2 = (from P_0 in ReflectionTools.GetProperties(P_0, ReflectionTools.BindingFlags.Instance | ReflectionTools.BindingFlags.Public | ReflectionTools.BindingFlags.NonPublic)
					where P_0.CanWrite && P_0.IsDefined(typeof(SerializeAttribute), inherit: true) && !P_0.IsDefined(typeof(DoNotSerializeAttribute), inherit: true)
					select P_0).ToDictionary((PropertyInfo P_0) => (P_0.IsDefined(typeof(SerializeAttribute), inherit: true) && !string.IsNullOrEmpty(name2 = (CollectionTools.GetValue(P_0.GetCustomAttributes(typeof(SerializeAttribute), inherit: true), 0) as SerializeAttribute).Name)) ? name2 : P_0.Name);
				yBVUjqPaMXjiGkkRYJXufFpCjFzQ.Add(P_0, value2);
			}
			foreach (Field item in (IEnumerable<Field>)P_1)
			{
				string name = item.name;
				object value3 = item.value;
				object value5;
				PropertyInfo value6;
				if (value.TryGetValue(name, out var value4))
				{
					if (IlORqCfBSzzprKbGKcccvXnXQFA(value4.FieldType, value3, out value5, P_3, P_4))
					{
						value4.SetValue(P_2, value5);
					}
				}
				else if (value2.TryGetValue(name, out value6) && value6.CanWrite && IlORqCfBSzzprKbGKcccvXnXQFA(value6.PropertyType, value3, out value5, P_3, P_4))
				{
					value6.SetValue(P_2, value5, null);
				}
			}
			if (P_2 is ISerializationCallbackReceiver serializationCallbackReceiver)
			{
				try
				{
					serializationCallbackReceiver.OnAfterDeserialize();
				}
				catch (Exception ex)
				{
					Logger.LogError(ex.ToString(), requiredThreadSafety: true);
				}
			}
			return true;
		}

		public static SerializedObject FromJson(Type type, string jsonString)
		{
			if ((object)type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (string.IsNullOrEmpty(jsonString))
			{
				throw new ArgumentNullException("jsonString");
			}
			SerializedObject serializedObject = JsonParser.FromJson<SerializedObject>(jsonString, typeof(SerializedObject));
			if (serializedObject == null || serializedObject.count == 0)
			{
				throw new Exception("No data found in Json string.");
			}
			return serializedObject;
		}

		public static SerializedObject FromXml(Type type, string xmlString)
		{
			if ((object)type == null)
			{
				throw new ArgumentNullException("type");
			}
			if (string.IsNullOrEmpty(xmlString))
			{
				throw new ArgumentNullException("xmlString");
			}
			mQexZElgxheWivTdrfuznZgWdIZ mQexZElgxheWivTdrfuznZgWdIZ = new mQexZElgxheWivTdrfuznZgWdIZ(xmlString);
			if (!mQexZElgxheWivTdrfuznZgWdIZ.SUieynyjoelHWxONjYlBAYlrJqa)
			{
				throw new Exception("Failed to parse XML string.");
			}
			if (mQexZElgxheWivTdrfuznZgWdIZ.NBFgvNFECPNoPTEOiaLFiWnwwlQ.SWUammnVJReCJYxUcFEwpgnqNPH == 0)
			{
				throw new Exception("No data found in XML string.");
			}
			mQexZElgxheWivTdrfuznZgWdIZ.OHYePZWWPpLilrpHniDWRcaZSap oHYePZWWPpLilrpHniDWRcaZSap = mQexZElgxheWivTdrfuznZgWdIZ.NBFgvNFECPNoPTEOiaLFiWnwwlQ.XlQEovhLzUBhdMDXWlzjLtULJJeH(type.Name);
			if (oHYePZWWPpLilrpHniDWRcaZSap == null)
			{
				throw new Exception("Main element not found in XML string.");
			}
			if (!(oHYePZWWPpLilrpHniDWRcaZSap.zYRyxRRRqMqfMZVpIZNGuOSAjsW() is SerializedObject serializedObject) || serializedObject.count == 0)
			{
				throw new Exception("No data found in XML string.");
			}
			return serializedObject;
		}

		[CompilerGenerated]
		private static bool HRdmFOplBByJtuUZjqvgqClXPAc(FieldInfo P_0)
		{
			if ((P_0.IsPublic || P_0.IsDefined(typeof(SerializeAttribute), inherit: true) || P_0.IsDefined(typeof(SerializeField), inherit: true)) && !P_0.IsDefined(typeof(NonSerializedAttribute), inherit: true))
			{
				return !P_0.IsDefined(typeof(DoNotSerializeAttribute), inherit: true);
			}
			return false;
		}

		[CompilerGenerated]
		private static string sFvRiYJMdgvKbtMcxnYoNuyOIuJ(FieldInfo P_0)
		{
			string name;
			if (P_0.IsDefined(typeof(SerializeAttribute), inherit: true) && !string.IsNullOrEmpty(name = (CollectionTools.GetValue(P_0.GetCustomAttributes(typeof(SerializeAttribute), inherit: true), 0) as SerializeAttribute).Name))
			{
				return name;
			}
			return P_0.Name;
		}

		[CompilerGenerated]
		private static bool TxIBEOsPbgzesChfqfshEipqwurm(PropertyInfo P_0)
		{
			if (P_0.CanWrite && P_0.IsDefined(typeof(SerializeAttribute), inherit: true))
			{
				return !P_0.IsDefined(typeof(DoNotSerializeAttribute), inherit: true);
			}
			return false;
		}

		[CompilerGenerated]
		private static string QPvomjSSdwtamYoTenEuVrPcKBV(PropertyInfo P_0)
		{
			string name;
			if (P_0.IsDefined(typeof(SerializeAttribute), inherit: true) && !string.IsNullOrEmpty(name = (CollectionTools.GetValue(P_0.GetCustomAttributes(typeof(SerializeAttribute), inherit: true), 0) as SerializeAttribute).Name))
			{
				return name;
			}
			return P_0.Name;
		}
	}
}
