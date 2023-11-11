using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;

namespace Rewired
{
	public class ControllerTemplateMap
	{
		private readonly int PivQvdYMhUssuLwaglJVqkqXMSH;

		private readonly int BoMCLeauexjolkkRqzIpOQOAGri;

		private readonly Guid lxWZgzSdVxcihesEydqWsMebqDl;

		private readonly List<ControllerTemplateActionElementMap> sOMNcaCwvnvTGFVUUppFVerSLrq;

		private readonly ReadOnlyCollection<ControllerTemplateActionElementMap> JNyURuHTQFYuhhfmNFldlLNbKeW;

		private bool nZTtfeZBpthDaoAvSONdTABGEaM;

		private int xycjdlRXmKfKzffLtupAeYxpGnq;

		private int WqReATiIhRsxvtfIshVFrhWugtr;

		private int xvBYLKzRmkrqgpdGRoHqcUpfXiv = -1;

		private static int qpnnVHPUqObnkVSivpdERmzoElSJ;

		public int id
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return -1;
				}
				return BoMCLeauexjolkkRqzIpOQOAGri;
			}
		}

		public Guid templateTypeGuid
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return Guid.Empty;
				}
				return lxWZgzSdVxcihesEydqWsMebqDl;
			}
		}

		public bool enabled
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return false;
				}
				return nZTtfeZBpthDaoAvSONdTABGEaM;
			}
			set
			{
				nZTtfeZBpthDaoAvSONdTABGEaM = value;
			}
		}

		public int categoryId
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return -1;
				}
				return xycjdlRXmKfKzffLtupAeYxpGnq;
			}
			internal set
			{
				xycjdlRXmKfKzffLtupAeYxpGnq = value;
			}
		}

		public int layoutId
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return -1;
				}
				return WqReATiIhRsxvtfIshVFrhWugtr;
			}
			internal set
			{
				WqReATiIhRsxvtfIshVFrhWugtr = value;
			}
		}

		public IList<ControllerTemplateActionElementMap> ElementMaps
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return EmptyObjects<ControllerTemplateActionElementMap>.EmptyReadOnlyIListT;
				}
				return JNyURuHTQFYuhhfmNFldlLNbKeW;
			}
		}

		internal ControllerTemplateMap(Guid templateTypeGuid)
		{
			BoMCLeauexjolkkRqzIpOQOAGri = qpnnVHPUqObnkVSivpdERmzoElSJ++;
			PivQvdYMhUssuLwaglJVqkqXMSH = ReInput._id;
			lxWZgzSdVxcihesEydqWsMebqDl = templateTypeGuid;
			sOMNcaCwvnvTGFVUUppFVerSLrq = new List<ControllerTemplateActionElementMap>();
			JNyURuHTQFYuhhfmNFldlLNbKeW = new ReadOnlyCollection<ControllerTemplateActionElementMap>(sOMNcaCwvnvTGFVUUppFVerSLrq);
			nZTtfeZBpthDaoAvSONdTABGEaM = true;
		}

		internal ControllerTemplateMap(Guid templateTypeGuid, int categoryId, int layoutId, int sourceMapId)
			: this(templateTypeGuid)
		{
			xycjdlRXmKfKzffLtupAeYxpGnq = categoryId;
			WqReATiIhRsxvtfIshVFrhWugtr = layoutId;
			xvBYLKzRmkrqgpdGRoHqcUpfXiv = sourceMapId;
		}

		public string ToXmlString()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return string.Empty;
			}
			try
			{
				return KmsZJAaClfxbOKcqKGgeMqITFsc().ToXmlString(writeDocumentTag: true);
			}
			catch (Exception ex)
			{
				Logger.LogWarning("Error writing " + GetType().Name + " to XML. " + ex.Message);
				return string.Empty;
			}
		}

		public string ToJsonString()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return string.Empty;
			}
			try
			{
				return KmsZJAaClfxbOKcqKGgeMqITFsc().ToJsonString();
			}
			catch (Exception ex)
			{
				Logger.LogWarning("Error writing " + GetType().Name + " to JSON. " + ex.Message);
				return string.Empty;
			}
		}

		public ControllerMap ToControllerMap(Controller controller)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			if (controller == null)
			{
				throw new ArgumentNullException("controller");
			}
			IControllerTemplate template = controller.GetTemplate(lxWZgzSdVxcihesEydqWsMebqDl);
			if (template == null)
			{
				Logger.LogError("The Controller does not implement the expected Controller Template.");
				return null;
			}
			ControllerMap controllerMap = ControllerMap.aWlEKFrTmxgBGgRqJDXRHeKwHYg(controller.type);
			controllerMap.categoryId = xycjdlRXmKfKzffLtupAeYxpGnq;
			controllerMap.layoutId = WqReATiIhRsxvtfIshVFrhWugtr;
			if (xvBYLKzRmkrqgpdGRoHqcUpfXiv >= 0)
			{
				controllerMap.sourceMapId = xvBYLKzRmkrqgpdGRoHqcUpfXiv;
			}
			controllerMap.controllerId = controller.id;
			controllerMap.controllerType = controller.type;
			controllerMap.enabled = nZTtfeZBpthDaoAvSONdTABGEaM;
			controllerMap.hardwareGuid = controller.cBbvDblDdxYvWIffImKZKlfGJPE;
			using TempListPool.TList<ActionElementMap> tList = TempListPool.GetTList<ActionElementMap>();
			List<ActionElementMap> list = tList.list;
			for (int i = 0; i < sOMNcaCwvnvTGFVUUppFVerSLrq.Count; i++)
			{
				sOMNcaCwvnvTGFVUUppFVerSLrq[i].SFYKsTrGwtnUtUknKDYjfkBNAKY(template, list, false);
				for (int j = 0; j < list.Count; j++)
				{
					controllerMap.cOYCFliSLtjGEfDRHMGzdQVtdteA(list[j]);
				}
			}
			return controllerMap;
		}

		internal virtual void tobyAseOeexEQBYeyNriFyhLxKv(SerializedObject P_0)
		{
			if (P_0.xmlInfo == null)
			{
				P_0.xmlInfo = new SerializedObject.XmlInfo();
			}
			P_0.Add("dataVersion", 1, SerializedObject.FieldOptions.ExculdeFromXml);
			P_0.xmlInfo.attributes.Add(new SerializedObject.XmlInfo.kwLxndskJikCtPGLslSPWsTXCTW
			{
				FaRCzmOJYwGVoyOIjhyHpMferPo = "dataVersion",
				foSRcEqSuRsWnadDiKcGnhBewOU = 1.ToString()
			});
			List<SerializedObject.XmlInfo.HDPGiVoBXLVCodlSiugSdJIEGou> attributes = P_0.xmlInfo.attributes;
			SerializedObject.XmlInfo.kwLxndskJikCtPGLslSPWsTXCTW kwLxndskJikCtPGLslSPWsTXCTW = new SerializedObject.XmlInfo.kwLxndskJikCtPGLslSPWsTXCTW
			{
				FaRCzmOJYwGVoyOIjhyHpMferPo = "templateTypeGuid"
			};
			Guid guid = lxWZgzSdVxcihesEydqWsMebqDl;
			kwLxndskJikCtPGLslSPWsTXCTW.foSRcEqSuRsWnadDiKcGnhBewOU = guid.ToString();
			attributes.Add(kwLxndskJikCtPGLslSPWsTXCTW);
			P_0.xmlInfo.attributes.Add(new SerializedObject.XmlInfo.kwLxndskJikCtPGLslSPWsTXCTW
			{
				jveufREDmiaHzvZNPCiXJKHYoFA = "xmlns",
				FaRCzmOJYwGVoyOIjhyHpMferPo = "xsi",
				ErZkPlJPCSFziEkQUXjksErSMGjf = null,
				foSRcEqSuRsWnadDiKcGnhBewOU = "http://www.w3.org/2001/XMLSchema-instance"
			});
			P_0.xmlInfo.attributes.Add(new SerializedObject.XmlInfo.kwLxndskJikCtPGLslSPWsTXCTW
			{
				jveufREDmiaHzvZNPCiXJKHYoFA = "xsi",
				FaRCzmOJYwGVoyOIjhyHpMferPo = "schemaLocation",
				ErZkPlJPCSFziEkQUXjksErSMGjf = null,
				foSRcEqSuRsWnadDiKcGnhBewOU = string.Format("{0} {1}{2}{3}{4}{5}", "http://guavaman.com/rewired", "http://guavaman.com/schemas/rewired/", "1.0", "/", GetType().Name, ".xsd")
			});
			P_0.Add("templateTypeGuid", lxWZgzSdVxcihesEydqWsMebqDl);
			P_0.Add("enabled", nZTtfeZBpthDaoAvSONdTABGEaM);
			P_0.Add("categoryId", xycjdlRXmKfKzffLtupAeYxpGnq);
			P_0.Add("layoutId", WqReATiIhRsxvtfIshVFrhWugtr);
			P_0.Add("sourceMapId", xvBYLKzRmkrqgpdGRoHqcUpfXiv);
			int count = sOMNcaCwvnvTGFVUUppFVerSLrq.Count;
			List<object> list = new List<object>();
			P_0.Add("elementMaps", list);
			for (int i = 0; i < count; i++)
			{
				if (sOMNcaCwvnvTGFVUUppFVerSLrq[i] != null)
				{
					list.Add(sOMNcaCwvnvTGFVUUppFVerSLrq[i].KmsZJAaClfxbOKcqKGgeMqITFsc());
				}
			}
		}

		internal virtual void jzPtspnkZAgrKJfuKATzOhURnEB(SerializedObject P_0)
		{
			LlCkzvOeJVaCziTDPktzBWuYotAZ();
			P_0.TryGetDeserializedValueByRef("enabled", ref nZTtfeZBpthDaoAvSONdTABGEaM);
			P_0.TryGetDeserializedValueByRef("categoryId", ref xycjdlRXmKfKzffLtupAeYxpGnq);
			P_0.TryGetDeserializedValueByRef("layoutId", ref WqReATiIhRsxvtfIshVFrhWugtr);
			P_0.TryGetDeserializedValueByRef("sourceMapId", ref xvBYLKzRmkrqgpdGRoHqcUpfXiv);
			SerializedObject value = null;
			if (!P_0.TryGetDeserializedValueByRef("elementMaps", ref value) || value == null)
			{
				return;
			}
			for (int i = 0; i < value.count; i++)
			{
				if (value.TryGetDeserializedValue<SerializedObject>(i, out var value2) || value2 == null)
				{
					ControllerTemplateActionElementMap controllerTemplateActionElementMap = ControllerTemplateActionElementMap.aWlEKFrTmxgBGgRqJDXRHeKwHYg(value2);
					if (controllerTemplateActionElementMap != null)
					{
						AMitEmYOawZwzTNfMPWFEkGrtco(controllerTemplateActionElementMap);
					}
				}
			}
		}

		private void LlCkzvOeJVaCziTDPktzBWuYotAZ()
		{
			nZTtfeZBpthDaoAvSONdTABGEaM = true;
			xycjdlRXmKfKzffLtupAeYxpGnq = -1;
			WqReATiIhRsxvtfIshVFrhWugtr = -1;
			xvBYLKzRmkrqgpdGRoHqcUpfXiv = -1;
			sOMNcaCwvnvTGFVUUppFVerSLrq.Clear();
		}

		private SerializedObject KmsZJAaClfxbOKcqKGgeMqITFsc()
		{
			SerializedObject serializedObject = new SerializedObject(GetType(), SerializedObject.ObjectType.Object);
			tobyAseOeexEQBYeyNriFyhLxKv(serializedObject);
			return serializedObject;
		}

		internal void AMitEmYOawZwzTNfMPWFEkGrtco(ControllerTemplateActionElementMap P_0)
		{
			if (P_0 != null)
			{
				sOMNcaCwvnvTGFVUUppFVerSLrq.Add(P_0);
			}
		}

		internal static ControllerTemplateMap OQMGrgFYKbdWJiatgRqdthoAyqOh(IControllerTemplate P_0, ControllerMap P_1)
		{
			if (P_1 == null)
			{
				throw new ArgumentNullException("controllerMap");
			}
			if (P_0 == null)
			{
				throw new ArgumentNullException("controllerTemplate");
			}
			if (!ReInput.isReady)
			{
				throw new Exception("Rewired is not initialized.");
			}
			Controller controller = ReInput.controllers.GetController(P_1.controllerType, P_1.controllerId);
			if (controller == null)
			{
				Logger.LogError("The Controller Map is not associated with a Controller. This method can only be used with a Controller Map that is associated with a Controller.", requiredThreadSafety: true);
				return null;
			}
			if (!controller.ImplementsTemplate(P_0.typeGuid))
			{
				Logger.LogError("The Controller does not implement the Controller Template.", requiredThreadSafety: true);
				return null;
			}
			ControllerTemplateMap controllerTemplateMap = new ControllerTemplateMap(P_0.typeGuid);
			controllerTemplateMap.nZTtfeZBpthDaoAvSONdTABGEaM = P_1.enabled;
			controllerTemplateMap.xycjdlRXmKfKzffLtupAeYxpGnq = P_1.categoryId;
			controllerTemplateMap.WqReATiIhRsxvtfIshVFrhWugtr = P_1.layoutId;
			controllerTemplateMap.xvBYLKzRmkrqgpdGRoHqcUpfXiv = P_1.sourceMapId;
			using TempListPool.TList<ControllerTemplateElementTarget> tList = TempListPool.GetTList<ControllerTemplateElementTarget>();
			List<ControllerTemplateElementTarget> list = tList.list;
			foreach (ActionElementMap allMap in P_1.AllMaps)
			{
				if (P_0.GetElementTargets(allMap, list) > 0)
				{
					for (int i = 0; i < list.Count; i++)
					{
						controllerTemplateMap.AMitEmYOawZwzTNfMPWFEkGrtco(ControllerTemplateActionElementMap.aWlEKFrTmxgBGgRqJDXRHeKwHYg(list[i], allMap));
					}
				}
			}
			return controllerTemplateMap;
		}

		public static ControllerTemplateMap FromXml(string xmlString)
		{
			try
			{
				return PVxnyjxpvVdUMYvPYaLudrDJdCy(SerializedObject.FromXml(typeof(ControllerTemplateMap), xmlString));
			}
			catch (Exception ex)
			{
				Logger.LogError("Error creating ControllerTemplateMap from XML! " + ex.Message);
				return null;
			}
		}

		public static ControllerTemplateMap FromJson(string jsonString)
		{
			try
			{
				return PVxnyjxpvVdUMYvPYaLudrDJdCy(SerializedObject.FromJson(typeof(ControllerTemplateMap), jsonString));
			}
			catch (Exception ex)
			{
				Logger.LogError("Error creating ControllerTemplateMap from JSON! " + ex.Message);
				return null;
			}
		}

		private static ControllerTemplateMap PVxnyjxpvVdUMYvPYaLudrDJdCy(SerializedObject P_0)
		{
			if (!P_0.TryGetDeserializedValue<Guid>("templateTypeGuid", out var value))
			{
				throw new Exception();
			}
			ControllerTemplateMap controllerTemplateMap = new ControllerTemplateMap(value);
			controllerTemplateMap.jzPtspnkZAgrKJfuKATzOhURnEB(P_0);
			return controllerTemplateMap;
		}
	}
}
