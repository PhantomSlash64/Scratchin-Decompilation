using UnityEngine;

namespace Rewired
{
	public struct ControllerPollingInfo
	{
		private bool EYRUjLheXxhryVtnVHImSmwDyBN;

		private int IUWpTXMJPIJwDJdybAJNwpRpcYp;

		private int BUaVcuFwTcIVxSAyrnOfAxOjuhI;

		private string wOsXuLJObLqqoaXCJQAaxjNuZGp;

		private ControllerType DdmGAhnWjBkGezCJigEsEoriSFLq;

		private ControllerElementType CWgkufixEoUdwdpwyiLRHFzgLqi;

		private int UgYKpPGXoJUWiIrkuIiAFetRZuI;

		private Pole dIzUOMGjOPoreSLcmbzuEJBkzIC;

		private string MhdaHfzRbOGuyQcIBxhPRrKjlnp;

		private int AlqqKkRsWUkTOzkmxGfVDUZYXTSf;

		private KeyCode PioAuqcQNZuFbtRlYnhamqjYykm;

		public bool success
		{
			get
			{
				return EYRUjLheXxhryVtnVHImSmwDyBN;
			}
			internal set
			{
				EYRUjLheXxhryVtnVHImSmwDyBN = value;
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

		public string controllerName
		{
			get
			{
				return wOsXuLJObLqqoaXCJQAaxjNuZGp;
			}
			internal set
			{
				wOsXuLJObLqqoaXCJQAaxjNuZGp = value;
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

		public int elementIndex
		{
			get
			{
				return UgYKpPGXoJUWiIrkuIiAFetRZuI;
			}
			internal set
			{
				UgYKpPGXoJUWiIrkuIiAFetRZuI = value;
			}
		}

		public Pole axisPole
		{
			get
			{
				return dIzUOMGjOPoreSLcmbzuEJBkzIC;
			}
			internal set
			{
				dIzUOMGjOPoreSLcmbzuEJBkzIC = value;
			}
		}

		public string elementIdentifierName
		{
			get
			{
				return MhdaHfzRbOGuyQcIBxhPRrKjlnp;
			}
			internal set
			{
				MhdaHfzRbOGuyQcIBxhPRrKjlnp = value;
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

		public KeyCode keyboardKey
		{
			get
			{
				return PioAuqcQNZuFbtRlYnhamqjYykm;
			}
			internal set
			{
				PioAuqcQNZuFbtRlYnhamqjYykm = value;
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
				if (!ReInput.kRIMscNTqYOjJDgtnNDWfmLNvzj.kKZHnwadKpinaoikthYpxtWlAkO(IUWpTXMJPIJwDJdybAJNwpRpcYp))
				{
					return null;
				}
				return ReInput.kRIMscNTqYOjJDgtnNDWfmLNvzj.fFKuoGTmbMrpFMTwXsWqdvvrhNG(IUWpTXMJPIJwDJdybAJNwpRpcYp);
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

		public ControllerElementIdentifier elementIdentifier
		{
			get
			{
				if (!ReInput.isReady)
				{
					return null;
				}
				return controller?.GetElementIdentifierById(AlqqKkRsWUkTOzkmxGfVDUZYXTSf);
			}
		}

		internal ControllerPollingInfo(bool success, int playerId, int controllerId, string controllerName, ControllerType controllerType, ControllerElementType elementType, int elementIndex, Pole axisPole, string elementIdentifierName, int elementIdentifierId, KeyCode keyboardKey)
		{
			EYRUjLheXxhryVtnVHImSmwDyBN = success;
			IUWpTXMJPIJwDJdybAJNwpRpcYp = playerId;
			BUaVcuFwTcIVxSAyrnOfAxOjuhI = controllerId;
			wOsXuLJObLqqoaXCJQAaxjNuZGp = controllerName;
			DdmGAhnWjBkGezCJigEsEoriSFLq = controllerType;
			CWgkufixEoUdwdpwyiLRHFzgLqi = elementType;
			UgYKpPGXoJUWiIrkuIiAFetRZuI = elementIndex;
			dIzUOMGjOPoreSLcmbzuEJBkzIC = axisPole;
			MhdaHfzRbOGuyQcIBxhPRrKjlnp = elementIdentifierName;
			AlqqKkRsWUkTOzkmxGfVDUZYXTSf = elementIdentifierId;
			PioAuqcQNZuFbtRlYnhamqjYykm = keyboardKey;
		}

		internal ControllerPollingInfo(ControllerPollingInfo source)
		{
			EYRUjLheXxhryVtnVHImSmwDyBN = source.EYRUjLheXxhryVtnVHImSmwDyBN;
			IUWpTXMJPIJwDJdybAJNwpRpcYp = source.IUWpTXMJPIJwDJdybAJNwpRpcYp;
			BUaVcuFwTcIVxSAyrnOfAxOjuhI = source.BUaVcuFwTcIVxSAyrnOfAxOjuhI;
			wOsXuLJObLqqoaXCJQAaxjNuZGp = source.wOsXuLJObLqqoaXCJQAaxjNuZGp;
			DdmGAhnWjBkGezCJigEsEoriSFLq = source.DdmGAhnWjBkGezCJigEsEoriSFLq;
			CWgkufixEoUdwdpwyiLRHFzgLqi = source.CWgkufixEoUdwdpwyiLRHFzgLqi;
			UgYKpPGXoJUWiIrkuIiAFetRZuI = source.UgYKpPGXoJUWiIrkuIiAFetRZuI;
			dIzUOMGjOPoreSLcmbzuEJBkzIC = source.dIzUOMGjOPoreSLcmbzuEJBkzIC;
			MhdaHfzRbOGuyQcIBxhPRrKjlnp = source.MhdaHfzRbOGuyQcIBxhPRrKjlnp;
			AlqqKkRsWUkTOzkmxGfVDUZYXTSf = source.AlqqKkRsWUkTOzkmxGfVDUZYXTSf;
			PioAuqcQNZuFbtRlYnhamqjYykm = source.PioAuqcQNZuFbtRlYnhamqjYykm;
		}

		internal static ControllerPollingInfo KOYWVvhauJtKnlvZgtMSFRXPIUf()
		{
			return new ControllerPollingInfo(success: false, -1, -1, string.Empty, ControllerType.Keyboard, ControllerElementType.Axis, -1, Pole.Positive, string.Empty, -1, KeyCode.None);
		}
	}
}
