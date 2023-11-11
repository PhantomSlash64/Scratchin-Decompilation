using System;
using System.Collections.Generic;
using Rewired.Utils.Classes.Data;

namespace Rewired
{
	public sealed class ControllerTemplateActionButtonMap : ControllerTemplateActionElementMap
	{
		private Pole jckWePjtDojAsJrNXFQutnaCtuW;

		public Pole axisContribution => jckWePjtDojAsJrNXFQutnaCtuW;

		internal ControllerTemplateActionButtonMap(SerializedObject serializedObject)
			: base(ControllerTemplateElementType.Button)
		{
			if (serializedObject == null)
			{
				throw new ArgumentNullException("serializedObject");
			}
			jzPtspnkZAgrKJfuKATzOhURnEB(serializedObject);
		}

		internal ControllerTemplateActionButtonMap(int templateElementIdentifierId, ActionElementMap actionElementMap)
			: base(ControllerTemplateElementType.Button, templateElementIdentifierId, actionElementMap)
		{
			jckWePjtDojAsJrNXFQutnaCtuW = actionElementMap.axisContribution;
		}

		internal ControllerTemplateActionButtonMap(int elementIdentifierId, int actionId, Pole axisContribution, bool enabled)
			: base(ControllerTemplateElementType.Button, elementIdentifierId, actionId, enabled)
		{
			jckWePjtDojAsJrNXFQutnaCtuW = axisContribution;
		}

		internal override void KmsZJAaClfxbOKcqKGgeMqITFsc(SerializedObject P_0)
		{
			base.KmsZJAaClfxbOKcqKGgeMqITFsc(P_0);
			P_0.Add("axisContribution", jckWePjtDojAsJrNXFQutnaCtuW);
		}

		internal override void jzPtspnkZAgrKJfuKATzOhURnEB(SerializedObject P_0)
		{
			base.jzPtspnkZAgrKJfuKATzOhURnEB(P_0);
			P_0.TryGetDeserializedValueByRef("axisContribution", ref jckWePjtDojAsJrNXFQutnaCtuW);
		}

		internal override void LlCkzvOeJVaCziTDPktzBWuYotAZ()
		{
			jckWePjtDojAsJrNXFQutnaCtuW = Pole.Positive;
		}

		internal override int zWRGcjmWmObusbwICvXLcdSRbPZS(IControllerTemplateElementSource P_0, List<ActionElementMap> P_1, bool P_2)
		{
			if (!(P_0 is IControllerTemplateButtonSource controllerTemplateButtonSource))
			{
				return 0;
			}
			int num = 0;
			ActionElementMap actionElementMap = aJDZrNWChJSsPgWFfEXtbwnGCwE(controllerTemplateButtonSource.target, jckWePjtDojAsJrNXFQutnaCtuW);
			if (actionElementMap != null)
			{
				P_1.Add(actionElementMap);
				num++;
			}
			return num;
		}

		private ActionElementMap aJDZrNWChJSsPgWFfEXtbwnGCwE(IControllerElementTarget P_0, Pole P_1)
		{
			if (P_0 == null || P_0.element == null)
			{
				return null;
			}
			ControllerElementType controllerElementType = P_0.elementType;
			AxisRange axisRange = P_0.axisRange;
			ActionElementMap actionElementMap = new ActionElementMap();
			actionElementMap._elementIdentifierId = P_0.elementIdentifierId;
			actionElementMap._elementType = controllerElementType;
			actionElementMap._axisRange = axisRange;
			if ((controllerElementType != 0 || axisRange != 0) && (controllerElementType == ControllerElementType.Axis || controllerElementType == ControllerElementType.Button))
			{
				actionElementMap._axisContribution = P_1;
			}
			return actionElementMap;
		}
	}
}
