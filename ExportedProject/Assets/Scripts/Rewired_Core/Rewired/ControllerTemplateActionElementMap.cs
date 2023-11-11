using System;
using System.Collections.Generic;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;

namespace Rewired
{
	public abstract class ControllerTemplateActionElementMap
	{
		private readonly int BoMCLeauexjolkkRqzIpOQOAGri;

		private readonly ControllerTemplateElementType CWgkufixEoUdwdpwyiLRHFzgLqi;

		private bool nZTtfeZBpthDaoAvSONdTABGEaM;

		private int ARWjGDZdsNDKyFWsMDftBeVIijxg;

		private int AlqqKkRsWUkTOzkmxGfVDUZYXTSf;

		private static int qpnnVHPUqObnkVSivpdERmzoElSJ;

		public int id => BoMCLeauexjolkkRqzIpOQOAGri;

		public ControllerTemplateElementType elementType => CWgkufixEoUdwdpwyiLRHFzgLqi;

		public bool enabled
		{
			get
			{
				return nZTtfeZBpthDaoAvSONdTABGEaM;
			}
			set
			{
				nZTtfeZBpthDaoAvSONdTABGEaM = value;
			}
		}

		public int actionId
		{
			get
			{
				return ARWjGDZdsNDKyFWsMDftBeVIijxg;
			}
			set
			{
				ARWjGDZdsNDKyFWsMDftBeVIijxg = value;
			}
		}

		public int elementIdentifierId
		{
			get
			{
				return AlqqKkRsWUkTOzkmxGfVDUZYXTSf;
			}
			set
			{
				AlqqKkRsWUkTOzkmxGfVDUZYXTSf = value;
			}
		}

		internal ControllerTemplateActionElementMap(ControllerTemplateElementType elementType)
		{
			if (!InputTools.IsMappableType(elementType))
			{
				throw new ArgumentException(string.Concat(elementType, " is not a supported mappable Controller Template element type."));
			}
			CWgkufixEoUdwdpwyiLRHFzgLqi = elementType;
			BoMCLeauexjolkkRqzIpOQOAGri = qpnnVHPUqObnkVSivpdERmzoElSJ++;
		}

		internal ControllerTemplateActionElementMap(ControllerTemplateElementType elementType, int elementIdentifierId, ActionElementMap actionElementMap)
			: this(elementType)
		{
			if (actionElementMap == null)
			{
				throw new ArgumentNullException("actionElementMap");
			}
			ARWjGDZdsNDKyFWsMDftBeVIijxg = actionElementMap._actionId;
			AlqqKkRsWUkTOzkmxGfVDUZYXTSf = elementIdentifierId;
			nZTtfeZBpthDaoAvSONdTABGEaM = actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM;
		}

		internal ControllerTemplateActionElementMap(ControllerTemplateElementType elementType, int elementIdentifierId, int actionId, bool enabled)
			: this(elementType)
		{
			ARWjGDZdsNDKyFWsMDftBeVIijxg = actionId;
			AlqqKkRsWUkTOzkmxGfVDUZYXTSf = elementIdentifierId;
			nZTtfeZBpthDaoAvSONdTABGEaM = enabled;
		}

		protected ControllerTemplateActionElementMap(ActionElementMap actionElementMap)
		{
		}

		internal int SFYKsTrGwtnUtUknKDYjfkBNAKY(IControllerTemplate P_0, List<ActionElementMap> P_1, bool P_2)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException("controllerTemplate");
			}
			if (P_1 == null)
			{
				throw new ArgumentNullException("results");
			}
			if (!P_2)
			{
				P_1.Clear();
			}
			int num = PuYTSBJNHHdTlXxvOOPVHFgvBEd(P_0, P_1, P_2);
			if (num == 0)
			{
				return 0;
			}
			int num2 = P_1.Count - num;
			for (int i = 0; i < num; i++)
			{
				int index = num2 + i;
				P_1[index].nZTtfeZBpthDaoAvSONdTABGEaM = nZTtfeZBpthDaoAvSONdTABGEaM;
				P_1[index]._actionId = ARWjGDZdsNDKyFWsMDftBeVIijxg;
			}
			return num;
		}

		internal SerializedObject KmsZJAaClfxbOKcqKGgeMqITFsc()
		{
			SerializedObject serializedObject = new SerializedObject(GetType(), SerializedObject.ObjectType.Object);
			KmsZJAaClfxbOKcqKGgeMqITFsc(serializedObject);
			return serializedObject;
		}

		internal virtual void KmsZJAaClfxbOKcqKGgeMqITFsc(SerializedObject P_0)
		{
			P_0.Add("elementType", CWgkufixEoUdwdpwyiLRHFzgLqi);
			P_0.Add("enabled", nZTtfeZBpthDaoAvSONdTABGEaM);
			P_0.Add("elementIdentifierId", AlqqKkRsWUkTOzkmxGfVDUZYXTSf);
			P_0.Add("actionId", ARWjGDZdsNDKyFWsMDftBeVIijxg);
		}

		internal virtual void jzPtspnkZAgrKJfuKATzOhURnEB(SerializedObject P_0)
		{
			LlCkzvOeJVaCziTDPktzBWuYotAZ();
			P_0.TryGetDeserializedValueByRef("enabled", ref nZTtfeZBpthDaoAvSONdTABGEaM);
			P_0.TryGetDeserializedValueByRef("elementIdentifierId", ref AlqqKkRsWUkTOzkmxGfVDUZYXTSf);
			P_0.TryGetDeserializedValueByRef("actionId", ref ARWjGDZdsNDKyFWsMDftBeVIijxg);
		}

		internal virtual void LlCkzvOeJVaCziTDPktzBWuYotAZ()
		{
			nZTtfeZBpthDaoAvSONdTABGEaM = true;
			AlqqKkRsWUkTOzkmxGfVDUZYXTSf = -1;
			ARWjGDZdsNDKyFWsMDftBeVIijxg = -1;
		}

		internal abstract int zWRGcjmWmObusbwICvXLcdSRbPZS(IControllerTemplateElementSource P_0, List<ActionElementMap> P_1, bool P_2);

		private int PuYTSBJNHHdTlXxvOOPVHFgvBEd(IControllerTemplate P_0, List<ActionElementMap> P_1, bool P_2)
		{
			if (P_1 == null)
			{
				throw new ArgumentNullException("results");
			}
			if (!P_2)
			{
				P_1.Clear();
			}
			IControllerTemplateElement element = P_0.GetElement(AlqqKkRsWUkTOzkmxGfVDUZYXTSf);
			if (element == null)
			{
				return 0;
			}
			IControllerTemplateElementSource source = element.source;
			if (source == null)
			{
				return 0;
			}
			return zWRGcjmWmObusbwICvXLcdSRbPZS(source, P_1, P_2);
		}

		internal static ControllerTemplateActionElementMap aWlEKFrTmxgBGgRqJDXRHeKwHYg(SerializedObject P_0)
		{
			if (P_0 == null)
			{
				return null;
			}
			if (!P_0.TryGetDeserializedValue<ControllerTemplateElementType>("elementType", out var value))
			{
				return null;
			}
			return value switch
			{
				ControllerTemplateElementType.Axis => new ControllerTemplateActionAxisMap(P_0), 
				ControllerTemplateElementType.Button => new ControllerTemplateActionButtonMap(P_0), 
				_ => throw new NotImplementedException(), 
			};
		}

		internal static ControllerTemplateActionElementMap aWlEKFrTmxgBGgRqJDXRHeKwHYg(ControllerTemplateElementTarget P_0, ActionElementMap P_1)
		{
			if (P_1 == null)
			{
				throw new ArgumentNullException("actionElementMap");
			}
			if (P_0.elementType == ControllerTemplateElementType.Axis)
			{
				return new ControllerTemplateActionAxisMap(P_0.element.id, P_0.axisRange, P_1);
			}
			if (P_0.elementType == ControllerTemplateElementType.Button)
			{
				return new ControllerTemplateActionButtonMap(P_0.element.id, P_1);
			}
			throw new NotImplementedException();
		}

		internal static ControllerTemplateActionElementMap aWlEKFrTmxgBGgRqJDXRHeKwHYg(ActionElementMap P_0)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException("actionElementMap");
			}
			ControllerTemplateElementType controllerTemplateElementType = BbpfTcGSZRHmltstKOfXrucHPJO.nudKFIJmOVjJPNopdgOxQThceWi(P_0._elementType, false);
			if (!InputTools.IsMappableType(controllerTemplateElementType))
			{
				return null;
			}
			return controllerTemplateElementType switch
			{
				ControllerTemplateElementType.Axis => new ControllerTemplateActionAxisMap(P_0._elementIdentifierId, P_0._actionId, P_0._axisRange, P_0._axisContribution, P_0._invert, P_0.nZTtfeZBpthDaoAvSONdTABGEaM), 
				ControllerTemplateElementType.Button => new ControllerTemplateActionButtonMap(P_0._elementIdentifierId, P_0._actionId, P_0._axisContribution, P_0.nZTtfeZBpthDaoAvSONdTABGEaM), 
				_ => throw new NotImplementedException(), 
			};
		}
	}
}
