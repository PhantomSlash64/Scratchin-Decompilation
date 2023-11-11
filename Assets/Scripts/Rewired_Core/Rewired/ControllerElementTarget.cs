using System;

namespace Rewired
{
	public struct ControllerElementTarget
	{
		private Controller.Element OErIvCXPTdADhAlPIsozzYvOKzG;

		private AxisRange gOyrPUAIUSFpmOhLYqogcFQxBEg;

		public int elementIdentifierId
		{
			get
			{
				if (OErIvCXPTdADhAlPIsozzYvOKzG == null)
				{
					return -1;
				}
				return OErIvCXPTdADhAlPIsozzYvOKzG.id;
			}
		}

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

		public bool hasTarget => OErIvCXPTdADhAlPIsozzYvOKzG != null;

		public ControllerElementType elementType
		{
			get
			{
				if (OErIvCXPTdADhAlPIsozzYvOKzG == null)
				{
					return ControllerElementType.Axis;
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
				ControllerElementIdentifier elementIdentifier = OErIvCXPTdADhAlPIsozzYvOKzG.elementIdentifier;
				if (elementIdentifier == null)
				{
					return string.Empty;
				}
				return elementIdentifier.GetDisplayName(OErIvCXPTdADhAlPIsozzYvOKzG.type, gOyrPUAIUSFpmOhLYqogcFQxBEg);
			}
		}

		public Controller controller
		{
			get
			{
				if (OErIvCXPTdADhAlPIsozzYvOKzG == null)
				{
					return null;
				}
				return OErIvCXPTdADhAlPIsozzYvOKzG.bGNJaBTbykivsIWbGpkIOAQalRn;
			}
		}

		public Controller.Element element
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

		public ControllerElementTarget(ActionElementMap actionElementMap)
		{
			if (actionElementMap == null)
			{
				throw new ArgumentNullException("actionElementMap");
			}
			if (actionElementMap.dvELFlNCXsbUbhaEdTEhAKKKUbc != null)
			{
				Controller controller = ReInput.CoyPNJHWMheFytmTMQdqyctMRFl.RAcjlNtCncziVZzKMoHKTIJjxln(actionElementMap.dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerType, actionElementMap.dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerId);
				OErIvCXPTdADhAlPIsozzYvOKzG = controller.GetElementById(actionElementMap._elementIdentifierId);
			}
			else
			{
				OErIvCXPTdADhAlPIsozzYvOKzG = null;
			}
			gOyrPUAIUSFpmOhLYqogcFQxBEg = actionElementMap._axisRange;
		}

		public ControllerElementTarget(ControllerElementTarget other)
		{
			OErIvCXPTdADhAlPIsozzYvOKzG = other.OErIvCXPTdADhAlPIsozzYvOKzG;
			gOyrPUAIUSFpmOhLYqogcFQxBEg = other.gOyrPUAIUSFpmOhLYqogcFQxBEg;
		}

		public ControllerElementTarget(IControllerElementTarget other)
		{
			if (other == null)
			{
				throw new ArgumentNullException("other");
			}
			OErIvCXPTdADhAlPIsozzYvOKzG = other.element;
			gOyrPUAIUSFpmOhLYqogcFQxBEg = other.axisRange;
		}

		public static implicit operator ControllerElementTarget(ActionElementMap actionElementMap)
		{
			if (actionElementMap == null)
			{
				return default(ControllerElementTarget);
			}
			return new ControllerElementTarget(actionElementMap);
		}
	}
}
