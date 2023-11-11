using UnityEngine;

namespace Rewired
{
	public struct ElementAssignmentConflictInfo
	{
		private bool wlQAkyaSRUjfKfxWaKeEVoDEEvL;

		private bool xvysOyhIKrDfGeEcGzmcDPqlsUE;

		private int IUWpTXMJPIJwDJdybAJNwpRpcYp;

		private ControllerType DdmGAhnWjBkGezCJigEsEoriSFLq;

		private int BUaVcuFwTcIVxSAyrnOfAxOjuhI;

		private int ncDDfxCiVNKFFLtiSpRZZnIoFoP;

		private int YfYWeKagwYlbBywqquMxPFfdrEd;

		private ControllerElementType CWgkufixEoUdwdpwyiLRHFzgLqi;

		private int AlqqKkRsWUkTOzkmxGfVDUZYXTSf;

		private KeyCode BZpPRYCLlPKiKqPjgmvcBCXKtRL;

		private ModifierKeyFlags aBfAFwkVtDFVqNZcNtZjCBdzQNF;

		private int ARWjGDZdsNDKyFWsMDftBeVIijxg;

		public bool isConflict
		{
			get
			{
				return wlQAkyaSRUjfKfxWaKeEVoDEEvL;
			}
			internal set
			{
				wlQAkyaSRUjfKfxWaKeEVoDEEvL = value;
			}
		}

		public bool isUserAssignable
		{
			get
			{
				return xvysOyhIKrDfGeEcGzmcDPqlsUE;
			}
			internal set
			{
				xvysOyhIKrDfGeEcGzmcDPqlsUE = value;
			}
		}

		public int playerId
		{
			get
			{
				return IUWpTXMJPIJwDJdybAJNwpRpcYp;
			}
			internal set
			{
				IUWpTXMJPIJwDJdybAJNwpRpcYp = value;
			}
		}

		public ControllerType controllerType
		{
			get
			{
				return DdmGAhnWjBkGezCJigEsEoriSFLq;
			}
			internal set
			{
				DdmGAhnWjBkGezCJigEsEoriSFLq = value;
			}
		}

		public int controllerId
		{
			get
			{
				return BUaVcuFwTcIVxSAyrnOfAxOjuhI;
			}
			internal set
			{
				BUaVcuFwTcIVxSAyrnOfAxOjuhI = value;
			}
		}

		public int controllerMapId
		{
			get
			{
				return ncDDfxCiVNKFFLtiSpRZZnIoFoP;
			}
			internal set
			{
				ncDDfxCiVNKFFLtiSpRZZnIoFoP = value;
			}
		}

		public int elementMapId
		{
			get
			{
				return YfYWeKagwYlbBywqquMxPFfdrEd;
			}
			internal set
			{
				YfYWeKagwYlbBywqquMxPFfdrEd = value;
			}
		}

		public ControllerElementType elementType
		{
			get
			{
				return CWgkufixEoUdwdpwyiLRHFzgLqi;
			}
			internal set
			{
				CWgkufixEoUdwdpwyiLRHFzgLqi = value;
			}
		}

		public int elementIdentifierId
		{
			get
			{
				return AlqqKkRsWUkTOzkmxGfVDUZYXTSf;
			}
			internal set
			{
				AlqqKkRsWUkTOzkmxGfVDUZYXTSf = value;
			}
		}

		public KeyCode keyCode
		{
			get
			{
				return BZpPRYCLlPKiKqPjgmvcBCXKtRL;
			}
			internal set
			{
				BZpPRYCLlPKiKqPjgmvcBCXKtRL = value;
			}
		}

		public ModifierKeyFlags modifierKeyFlags
		{
			get
			{
				return aBfAFwkVtDFVqNZcNtZjCBdzQNF;
			}
			internal set
			{
				aBfAFwkVtDFVqNZcNtZjCBdzQNF = value;
			}
		}

		public int actionId
		{
			get
			{
				return ARWjGDZdsNDKyFWsMDftBeVIijxg;
			}
			internal set
			{
				ARWjGDZdsNDKyFWsMDftBeVIijxg = value;
			}
		}

		public Player player
		{
			get
			{
				if (!ReInput.isReady)
				{
					return null;
				}
				return ReInput.players.GetPlayer(IUWpTXMJPIJwDJdybAJNwpRpcYp);
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
				return ReInput.controllers.GetController(DdmGAhnWjBkGezCJigEsEoriSFLq, BUaVcuFwTcIVxSAyrnOfAxOjuhI);
			}
		}

		public ControllerMap controllerMap
		{
			get
			{
				if (player == null)
				{
					return null;
				}
				return player.controllers.maps.GetMap(DdmGAhnWjBkGezCJigEsEoriSFLq, BUaVcuFwTcIVxSAyrnOfAxOjuhI, ncDDfxCiVNKFFLtiSpRZZnIoFoP);
			}
		}

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
				if (controllerMap == null)
				{
					return null;
				}
				return controllerMap.GetElementMap(YfYWeKagwYlbBywqquMxPFfdrEd);
			}
		}

		public string elementDisplayName
		{
			get
			{
				if (DdmGAhnWjBkGezCJigEsEoriSFLq == ControllerType.Keyboard)
				{
					return Keyboard.GetKeyName(BZpPRYCLlPKiKqPjgmvcBCXKtRL, aBfAFwkVtDFVqNZcNtZjCBdzQNF);
				}
				if (controller == null)
				{
					return string.Empty;
				}
				ControllerElementIdentifier elementIdentifierById = controller.GetElementIdentifierById(AlqqKkRsWUkTOzkmxGfVDUZYXTSf);
				if (elementIdentifierById == null)
				{
					return string.Empty;
				}
				return elementIdentifierById.name;
			}
		}

		public ElementAssignmentConflictInfo(bool isConflict, bool isUserAssignable, int playerId, ControllerType controllerType, int controllerId, int controllerMapId, int elementMapId, int actionId, ControllerElementType elementType, int elementIdentifierId, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags)
		{
			wlQAkyaSRUjfKfxWaKeEVoDEEvL = isConflict;
			xvysOyhIKrDfGeEcGzmcDPqlsUE = isUserAssignable;
			IUWpTXMJPIJwDJdybAJNwpRpcYp = playerId;
			DdmGAhnWjBkGezCJigEsEoriSFLq = controllerType;
			BUaVcuFwTcIVxSAyrnOfAxOjuhI = controllerId;
			ncDDfxCiVNKFFLtiSpRZZnIoFoP = controllerMapId;
			YfYWeKagwYlbBywqquMxPFfdrEd = elementMapId;
			ARWjGDZdsNDKyFWsMDftBeVIijxg = actionId;
			CWgkufixEoUdwdpwyiLRHFzgLqi = elementType;
			AlqqKkRsWUkTOzkmxGfVDUZYXTSf = elementIdentifierId;
			BZpPRYCLlPKiKqPjgmvcBCXKtRL = keyCode;
			aBfAFwkVtDFVqNZcNtZjCBdzQNF = modifierKeyFlags;
		}

		public ElementAssignmentConflictInfo(ElementAssignmentConflictInfo source)
		{
			wlQAkyaSRUjfKfxWaKeEVoDEEvL = source.wlQAkyaSRUjfKfxWaKeEVoDEEvL;
			xvysOyhIKrDfGeEcGzmcDPqlsUE = source.xvysOyhIKrDfGeEcGzmcDPqlsUE;
			IUWpTXMJPIJwDJdybAJNwpRpcYp = source.IUWpTXMJPIJwDJdybAJNwpRpcYp;
			DdmGAhnWjBkGezCJigEsEoriSFLq = source.DdmGAhnWjBkGezCJigEsEoriSFLq;
			BUaVcuFwTcIVxSAyrnOfAxOjuhI = source.BUaVcuFwTcIVxSAyrnOfAxOjuhI;
			ncDDfxCiVNKFFLtiSpRZZnIoFoP = source.ncDDfxCiVNKFFLtiSpRZZnIoFoP;
			YfYWeKagwYlbBywqquMxPFfdrEd = source.YfYWeKagwYlbBywqquMxPFfdrEd;
			ARWjGDZdsNDKyFWsMDftBeVIijxg = source.ARWjGDZdsNDKyFWsMDftBeVIijxg;
			CWgkufixEoUdwdpwyiLRHFzgLqi = source.CWgkufixEoUdwdpwyiLRHFzgLqi;
			AlqqKkRsWUkTOzkmxGfVDUZYXTSf = source.AlqqKkRsWUkTOzkmxGfVDUZYXTSf;
			BZpPRYCLlPKiKqPjgmvcBCXKtRL = source.BZpPRYCLlPKiKqPjgmvcBCXKtRL;
			aBfAFwkVtDFVqNZcNtZjCBdzQNF = source.aBfAFwkVtDFVqNZcNtZjCBdzQNF;
		}
	}
}
