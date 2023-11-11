using System;
using UnityEngine;

namespace Rewired
{
	public sealed class ElementAssignmentInfo
	{
		private readonly ControllerMap dvELFlNCXsbUbhaEdTEhAKKKUbc;

		private readonly ControllerElementType CWgkufixEoUdwdpwyiLRHFzgLqi;

		private readonly int coNcNHLlhcHQyBLHyIRQduhEOapW;

		private readonly int AlqqKkRsWUkTOzkmxGfVDUZYXTSf;

		private readonly AxisRange gOyrPUAIUSFpmOhLYqogcFQxBEg;

		private readonly KeyCode BZpPRYCLlPKiKqPjgmvcBCXKtRL;

		private readonly ModifierKeyFlags aBfAFwkVtDFVqNZcNtZjCBdzQNF;

		private readonly int ARWjGDZdsNDKyFWsMDftBeVIijxg;

		private readonly Pole jckWePjtDojAsJrNXFQutnaCtuW;

		private readonly bool VQpcVtTJPYgoqRhVGoJfEqRmCnl;

		public Player player
		{
			get
			{
				if (!ReInput.isReady)
				{
					return null;
				}
				if (dvELFlNCXsbUbhaEdTEhAKKKUbc == null)
				{
					return null;
				}
				return dvELFlNCXsbUbhaEdTEhAKKKUbc.player;
			}
		}

		public InputAction action
		{
			get
			{
				if (!ReInput.isReady)
				{
					return null;
				}
				return ReInput.mapping.GetAction(ARWjGDZdsNDKyFWsMDftBeVIijxg);
			}
		}

		public Controller controller
		{
			get
			{
				if (!ReInput.isReady)
				{
					return null;
				}
				if (dvELFlNCXsbUbhaEdTEhAKKKUbc == null)
				{
					return null;
				}
				return ReInput.controllers.GetController(dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerType, dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerId);
			}
		}

		public ControllerType controllerType
		{
			get
			{
				if (!ReInput.isReady || dvELFlNCXsbUbhaEdTEhAKKKUbc == null)
				{
					return ControllerType.Keyboard;
				}
				return dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerType;
			}
		}

		public int controllerId
		{
			get
			{
				if (!ReInput.isReady || dvELFlNCXsbUbhaEdTEhAKKKUbc == null)
				{
					return -1;
				}
				return dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerId;
			}
		}

		public ControllerMap controllerMap => dvELFlNCXsbUbhaEdTEhAKKKUbc;

		public ControllerElementIdentifier elementIdentifier
		{
			get
			{
				if (controller == null)
				{
					return null;
				}
				return controller.GetElementIdentifierById(AlqqKkRsWUkTOzkmxGfVDUZYXTSf);
			}
		}

		public ActionElementMap elementMap
		{
			get
			{
				if (dvELFlNCXsbUbhaEdTEhAKKKUbc == null)
				{
					return null;
				}
				return dvELFlNCXsbUbhaEdTEhAKKKUbc.GetElementMap(coNcNHLlhcHQyBLHyIRQduhEOapW);
			}
		}

		public ControllerElementType elementType => CWgkufixEoUdwdpwyiLRHFzgLqi;

		public Pole axisContribution => jckWePjtDojAsJrNXFQutnaCtuW;

		public AxisRange axisRange => gOyrPUAIUSFpmOhLYqogcFQxBEg;

		public bool invert => VQpcVtTJPYgoqRhVGoJfEqRmCnl;

		public KeyCode keyCode => BZpPRYCLlPKiKqPjgmvcBCXKtRL;

		public ModifierKeyFlags modifierKeyFlags => aBfAFwkVtDFVqNZcNtZjCBdzQNF;

		public string elementDisplayName
		{
			get
			{
				if (dvELFlNCXsbUbhaEdTEhAKKKUbc == null)
				{
					return string.Empty;
				}
				if (controllerType == ControllerType.Keyboard)
				{
					return Keyboard.GetKeyName(keyCode, modifierKeyFlags);
				}
				Controller controller = this.controller;
				if (controller == null)
				{
					return string.Empty;
				}
				ControllerElementIdentifier elementIdentifierById = controller.GetElementIdentifierById(AlqqKkRsWUkTOzkmxGfVDUZYXTSf);
				if (elementIdentifierById == null)
				{
					return string.Empty;
				}
				if (CWgkufixEoUdwdpwyiLRHFzgLqi == ControllerElementType.Axis)
				{
					if (gOyrPUAIUSFpmOhLYqogcFQxBEg == AxisRange.Full)
					{
						return elementIdentifierById.name;
					}
					if (gOyrPUAIUSFpmOhLYqogcFQxBEg == AxisRange.Positive)
					{
						return elementIdentifierById.positiveName;
					}
					if (gOyrPUAIUSFpmOhLYqogcFQxBEg == AxisRange.Negative)
					{
						return elementIdentifierById.negativeName;
					}
				}
				return elementIdentifierById.name;
			}
		}

		internal ElementAssignmentInfo(ControllerMap controllerMap, ElementAssignment assignment)
		{
			if (controllerMap == null)
			{
				throw new ArgumentNullException("controllerMap");
			}
			ARWjGDZdsNDKyFWsMDftBeVIijxg = assignment.actionId;
			dvELFlNCXsbUbhaEdTEhAKKKUbc = controllerMap;
			coNcNHLlhcHQyBLHyIRQduhEOapW = assignment.elementMapId;
			AlqqKkRsWUkTOzkmxGfVDUZYXTSf = assignment.elementIdentifierId;
			BZpPRYCLlPKiKqPjgmvcBCXKtRL = assignment.keyboardKey;
			aBfAFwkVtDFVqNZcNtZjCBdzQNF = assignment.modifierKeyFlags;
			VQpcVtTJPYgoqRhVGoJfEqRmCnl = assignment.invert;
			CWgkufixEoUdwdpwyiLRHFzgLqi = BbpfTcGSZRHmltstKOfXrucHPJO.kldXmPFoOIQiSRQnQLvavtAnQcs(assignment.type);
			jckWePjtDojAsJrNXFQutnaCtuW = assignment.axisContribution;
			gOyrPUAIUSFpmOhLYqogcFQxBEg = assignment.axisRange;
			if (dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerType == ControllerType.Keyboard)
			{
				Keyboard.RWUEsheKcmtjneidQMGzeuIcLcRA(ref AlqqKkRsWUkTOzkmxGfVDUZYXTSf, ref BZpPRYCLlPKiKqPjgmvcBCXKtRL);
			}
		}
	}
}
