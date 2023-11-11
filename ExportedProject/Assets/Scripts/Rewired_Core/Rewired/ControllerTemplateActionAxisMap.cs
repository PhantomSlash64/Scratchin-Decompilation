using System;
using System.Collections.Generic;
using Rewired.Utils.Classes.Data;

namespace Rewired
{
	public sealed class ControllerTemplateActionAxisMap : ControllerTemplateActionElementMap
	{
		private AxisRange gOyrPUAIUSFpmOhLYqogcFQxBEg;

		private Pole jckWePjtDojAsJrNXFQutnaCtuW;

		private bool VQpcVtTJPYgoqRhVGoJfEqRmCnl;

		public AxisRange axisRange => gOyrPUAIUSFpmOhLYqogcFQxBEg;

		public Pole axisContribution => jckWePjtDojAsJrNXFQutnaCtuW;

		public bool invert => VQpcVtTJPYgoqRhVGoJfEqRmCnl;

		internal ControllerTemplateActionAxisMap(SerializedObject serializedObject)
			: base(ControllerTemplateElementType.Axis)
		{
			if (serializedObject == null)
			{
				throw new ArgumentNullException("serializedObject");
			}
			jzPtspnkZAgrKJfuKATzOhURnEB(serializedObject);
		}

		internal ControllerTemplateActionAxisMap(int templateElementIdentifierId, AxisRange axisRange, ActionElementMap actionElementMap)
			: base(ControllerTemplateElementType.Axis, templateElementIdentifierId, actionElementMap)
		{
			gOyrPUAIUSFpmOhLYqogcFQxBEg = axisRange;
			jckWePjtDojAsJrNXFQutnaCtuW = actionElementMap.axisContribution;
			VQpcVtTJPYgoqRhVGoJfEqRmCnl = actionElementMap._invert;
		}

		internal ControllerTemplateActionAxisMap(int elementIdentifierId, int actionId, AxisRange axisRange, Pole axisContribution, bool invert, bool enabled)
			: base(ControllerTemplateElementType.Axis, elementIdentifierId, actionId, enabled)
		{
			gOyrPUAIUSFpmOhLYqogcFQxBEg = axisRange;
			jckWePjtDojAsJrNXFQutnaCtuW = axisContribution;
			VQpcVtTJPYgoqRhVGoJfEqRmCnl = invert;
		}

		internal override void KmsZJAaClfxbOKcqKGgeMqITFsc(SerializedObject P_0)
		{
			base.KmsZJAaClfxbOKcqKGgeMqITFsc(P_0);
			P_0.Add("axisContribution", jckWePjtDojAsJrNXFQutnaCtuW);
			P_0.Add("axisRange", gOyrPUAIUSFpmOhLYqogcFQxBEg);
			P_0.Add("invert", VQpcVtTJPYgoqRhVGoJfEqRmCnl);
		}

		internal override void jzPtspnkZAgrKJfuKATzOhURnEB(SerializedObject P_0)
		{
			base.jzPtspnkZAgrKJfuKATzOhURnEB(P_0);
			P_0.TryGetDeserializedValueByRef("axisContribution", ref jckWePjtDojAsJrNXFQutnaCtuW);
			P_0.TryGetDeserializedValueByRef("axisRange", ref gOyrPUAIUSFpmOhLYqogcFQxBEg);
			P_0.TryGetDeserializedValueByRef("invert", ref VQpcVtTJPYgoqRhVGoJfEqRmCnl);
		}

		internal override void LlCkzvOeJVaCziTDPktzBWuYotAZ()
		{
			gOyrPUAIUSFpmOhLYqogcFQxBEg = AxisRange.Full;
			jckWePjtDojAsJrNXFQutnaCtuW = Pole.Positive;
			VQpcVtTJPYgoqRhVGoJfEqRmCnl = false;
		}

		internal override int zWRGcjmWmObusbwICvXLcdSRbPZS(IControllerTemplateElementSource P_0, List<ActionElementMap> P_1, bool P_2)
		{
			if (!(P_0 is IControllerTemplateAxisSource controllerTemplateAxisSource))
			{
				return 0;
			}
			int num = 0;
			if (gOyrPUAIUSFpmOhLYqogcFQxBEg == AxisRange.Full)
			{
				if (controllerTemplateAxisSource.splitAxis)
				{
					ActionElementMap actionElementMap = KdtnXSwdXDBiiAJNaDaZCJqVxJVN(controllerTemplateAxisSource.positiveTarget, (!VQpcVtTJPYgoqRhVGoJfEqRmCnl) ? AxisRange.Positive : AxisRange.Negative);
					if (actionElementMap != null)
					{
						P_1.Add(actionElementMap);
						num++;
					}
					actionElementMap = KdtnXSwdXDBiiAJNaDaZCJqVxJVN(controllerTemplateAxisSource.negativeTarget, VQpcVtTJPYgoqRhVGoJfEqRmCnl ? AxisRange.Positive : AxisRange.Negative);
					if (actionElementMap != null)
					{
						P_1.Add(actionElementMap);
						num++;
					}
				}
				else
				{
					ActionElementMap actionElementMap = KdtnXSwdXDBiiAJNaDaZCJqVxJVN(controllerTemplateAxisSource.fullTarget, AxisRange.Full);
					if (actionElementMap != null)
					{
						P_1.Add(actionElementMap);
						num++;
					}
				}
			}
			else if (controllerTemplateAxisSource.splitAxis)
			{
				if (gOyrPUAIUSFpmOhLYqogcFQxBEg == AxisRange.Positive)
				{
					ActionElementMap actionElementMap = tDVXbDWoPChchzbMWUTsWjOeijU(controllerTemplateAxisSource.positiveTarget, Pole.Positive, jckWePjtDojAsJrNXFQutnaCtuW);
					if (actionElementMap != null)
					{
						P_1.Add(actionElementMap);
						num++;
					}
				}
				else
				{
					ActionElementMap actionElementMap = tDVXbDWoPChchzbMWUTsWjOeijU(controllerTemplateAxisSource.negativeTarget, Pole.Negative, jckWePjtDojAsJrNXFQutnaCtuW);
					if (actionElementMap != null)
					{
						P_1.Add(actionElementMap);
						num++;
					}
				}
			}
			else
			{
				ActionElementMap actionElementMap = tDVXbDWoPChchzbMWUTsWjOeijU(controllerTemplateAxisSource.fullTarget, (gOyrPUAIUSFpmOhLYqogcFQxBEg == AxisRange.Negative) ? Pole.Negative : Pole.Positive, jckWePjtDojAsJrNXFQutnaCtuW);
				if (actionElementMap != null)
				{
					P_1.Add(actionElementMap);
					num++;
				}
			}
			return num;
		}

		private ActionElementMap KdtnXSwdXDBiiAJNaDaZCJqVxJVN(IControllerElementTarget P_0, AxisRange P_1)
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
			if (controllerElementType == ControllerElementType.Axis && axisRange == AxisRange.Full)
			{
				actionElementMap._invert = VQpcVtTJPYgoqRhVGoJfEqRmCnl;
			}
			else if (controllerElementType == ControllerElementType.Axis || controllerElementType == ControllerElementType.Button)
			{
				Pole pole = ((P_1 == AxisRange.Negative) ? Pole.Negative : Pole.Positive);
				actionElementMap._axisContribution = pole;
			}
			return actionElementMap;
		}

		private ActionElementMap tDVXbDWoPChchzbMWUTsWjOeijU(IControllerElementTarget P_0, Pole P_1, Pole P_2)
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
			if (controllerElementType == ControllerElementType.Axis && axisRange == AxisRange.Full)
			{
				actionElementMap._axisRange = ((P_1 == Pole.Positive) ? AxisRange.Positive : AxisRange.Negative);
				actionElementMap._axisContribution = P_2;
			}
			else if (controllerElementType == ControllerElementType.Axis || controllerElementType == ControllerElementType.Button)
			{
				actionElementMap._axisContribution = P_2;
			}
			return actionElementMap;
		}
	}
}
