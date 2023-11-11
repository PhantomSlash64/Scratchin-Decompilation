using System;

namespace Rewired
{
	public struct ControllerTemplateElementTarget
	{
		private IControllerTemplateElement OErIvCXPTdADhAlPIsozzYvOKzG;

		private AxisRange gOyrPUAIUSFpmOhLYqogcFQxBEg;

		public AxisRange axisRange
		{
			get
			{
				return gOyrPUAIUSFpmOhLYqogcFQxBEg;
			}
			set
			{
				gOyrPUAIUSFpmOhLYqogcFQxBEg = value;
			}
		}

		public ControllerTemplateElementType elementType
		{
			get
			{
				if (OErIvCXPTdADhAlPIsozzYvOKzG == null)
				{
					return ControllerTemplateElementType.Axis;
				}
				return OErIvCXPTdADhAlPIsozzYvOKzG.type;
			}
		}

		public string descriptiveName
		{
			get
			{
				if (OErIvCXPTdADhAlPIsozzYvOKzG == null)
				{
					return string.Empty;
				}
				return OErIvCXPTdADhAlPIsozzYvOKzG.type switch
				{
					ControllerTemplateElementType.Axis => ((IControllerTemplateAxis)OErIvCXPTdADhAlPIsozzYvOKzG).GetDescriptiveName(gOyrPUAIUSFpmOhLYqogcFQxBEg), 
					ControllerTemplateElementType.Button => ((IControllerTemplateButton)OErIvCXPTdADhAlPIsozzYvOKzG).descriptiveName, 
					_ => OErIvCXPTdADhAlPIsozzYvOKzG.descriptiveName, 
				};
			}
		}

		public IControllerTemplateElement element
		{
			get
			{
				return OErIvCXPTdADhAlPIsozzYvOKzG;
			}
			set
			{
				OErIvCXPTdADhAlPIsozzYvOKzG = value;
			}
		}

		public IControllerTemplate template
		{
			get
			{
				if (OErIvCXPTdADhAlPIsozzYvOKzG == null)
				{
					return null;
				}
				return (OErIvCXPTdADhAlPIsozzYvOKzG as IControllerTemplateElement_Internal).parent;
			}
		}

		public bool hasTarget => OErIvCXPTdADhAlPIsozzYvOKzG != null;

		internal ControllerTemplateElementTarget(IControllerTemplateElement element, AxisRange axisRange)
		{
			if (element == null)
			{
				throw new ArgumentNullException("element");
			}
			OErIvCXPTdADhAlPIsozzYvOKzG = element;
			gOyrPUAIUSFpmOhLYqogcFQxBEg = axisRange;
		}

		public ControllerTemplateElementTarget(ControllerTemplateElementTarget other)
		{
			OErIvCXPTdADhAlPIsozzYvOKzG = other.OErIvCXPTdADhAlPIsozzYvOKzG;
			gOyrPUAIUSFpmOhLYqogcFQxBEg = other.gOyrPUAIUSFpmOhLYqogcFQxBEg;
		}
	}
}
