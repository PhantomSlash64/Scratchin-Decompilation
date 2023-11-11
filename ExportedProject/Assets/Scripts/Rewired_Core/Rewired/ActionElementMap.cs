using System;
using System.Text;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	public sealed class ActionElementMap
	{
		[CustomObfuscation(rename = false)]
		[SerializeField]
		internal int _actionCategoryId;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		internal int _actionId;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		internal ControllerElementType _elementType;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		internal int _elementIdentifierId;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		internal AxisRange _axisRange;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		internal bool _invert;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		internal Pole _axisContribution;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		internal KeyboardKeyCode _keyboardKeyCode;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		internal ModifierKey _modifierKey1;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		internal ModifierKey _modifierKey2;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		internal ModifierKey _modifierKey3;

		[NonSerialized]
		internal ControllerMap dvELFlNCXsbUbhaEdTEhAKKKUbc;

		[NonSerialized]
		internal bool nZTtfeZBpthDaoAvSONdTABGEaM = true;

		[NonSerialized]
		private string MhdaHfzRbOGuyQcIBxhPRrKjlnp;

		[NonSerialized]
		internal string DBIbWkiTtDImiYmEkmtmfdVbcxev;

		[NonSerialized]
		internal int UgYKpPGXoJUWiIrkuIiAFetRZuI;

		[NonSerialized]
		internal readonly int BoMCLeauexjolkkRqzIpOQOAGri;

		[NonSerialized]
		private string gRuveBOlsfKRavsiAIjomWSnsQD;

		[NonSerialized]
		private ModifierKeyFlags cpwvXcvAOEWqopVlQJdmTgkCKoo;

		private static int uidCounter = 0;

		private static StringBuilder s_toStringSB;

		public int actionId
		{
			get
			{
				return _actionId;
			}
			set
			{
				if (value != _actionId)
				{
					_actionId = value;
					if (Application.isPlaying)
					{
						TfTBnAkDBRkjKyPeHSPwTuLQXVQ();
					}
				}
			}
		}

		public ControllerElementType elementType
		{
			get
			{
				return _elementType;
			}
			internal set
			{
				_elementType = value;
			}
		}

		public int elementIdentifierId
		{
			get
			{
				return _elementIdentifierId;
			}
			set
			{
				if (_elementIdentifierId == value)
				{
					return;
				}
				_elementIdentifierId = value;
				if (Application.isPlaying && dvELFlNCXsbUbhaEdTEhAKKKUbc != null)
				{
					Controller controller = ReInput.CoyPNJHWMheFytmTMQdqyctMRFl.RAcjlNtCncziVZzKMoHKTIJjxln(dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerType, dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerId, true);
					if (controller != null)
					{
						Controller.Element elementById = controller.GetElementById(value);
						if (elementById != null && elementById.type != _elementType)
						{
							dvELFlNCXsbUbhaEdTEhAKKKUbc.UrHUOjyElHcKAPctOzlyFlOLJRR(BoMCLeauexjolkkRqzIpOQOAGri, elementById.type);
						}
					}
				}
				if (Application.isPlaying)
				{
					sXMDOLeJaacTvhLZHNciRMUNwNbk(false);
				}
			}
		}

		public AxisRange axisRange
		{
			get
			{
				return _axisRange;
			}
			set
			{
				if (_axisRange == value)
				{
					return;
				}
				if (_elementType != 0 && Application.isPlaying)
				{
					Logger.LogWarning("You cannot change AxisRange of a non-Axis mapping.");
					return;
				}
				_axisRange = value;
				if (Application.isPlaying)
				{
					sXMDOLeJaacTvhLZHNciRMUNwNbk(false);
				}
			}
		}

		public bool invert
		{
			get
			{
				return _invert;
			}
			set
			{
				_invert = value;
			}
		}

		public Pole axisContribution
		{
			get
			{
				return _axisContribution;
			}
			set
			{
				if (_axisContribution != value)
				{
					_axisContribution = value;
					if (Application.isPlaying)
					{
						sXMDOLeJaacTvhLZHNciRMUNwNbk(false);
					}
				}
			}
		}

		public KeyboardKeyCode keyboardKeyCode
		{
			get
			{
				return _keyboardKeyCode;
			}
			set
			{
				if (_keyboardKeyCode == value)
				{
					return;
				}
				if (dvELFlNCXsbUbhaEdTEhAKKKUbc != null && dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerType != 0)
				{
					Logger.LogWarning("You cannot set the key code on a non-Keyboard mapping.");
					return;
				}
				_keyboardKeyCode = value;
				if (Application.isPlaying)
				{
					sXMDOLeJaacTvhLZHNciRMUNwNbk(true);
				}
			}
		}

		public ModifierKey modifierKey1
		{
			get
			{
				return _modifierKey1;
			}
			set
			{
				if (_modifierKey1 == value)
				{
					return;
				}
				if (dvELFlNCXsbUbhaEdTEhAKKKUbc != null && dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerType != 0)
				{
					Logger.LogWarning("You cannot set a modifier key on a non-Keyboard mapping.");
					return;
				}
				_modifierKey1 = value;
				if (Application.isPlaying)
				{
					HtXGKDGdumhvbkXELiTLeqCurYq();
					sXMDOLeJaacTvhLZHNciRMUNwNbk(true);
				}
			}
		}

		public ModifierKey modifierKey2
		{
			get
			{
				return _modifierKey2;
			}
			set
			{
				if (_modifierKey2 == value)
				{
					return;
				}
				if (dvELFlNCXsbUbhaEdTEhAKKKUbc != null && dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerType != 0)
				{
					Logger.LogWarning("You cannot set a modifier key on a non-Keyboard mapping.");
					return;
				}
				_modifierKey2 = value;
				if (Application.isPlaying)
				{
					HtXGKDGdumhvbkXELiTLeqCurYq();
					sXMDOLeJaacTvhLZHNciRMUNwNbk(true);
				}
			}
		}

		public ModifierKey modifierKey3
		{
			get
			{
				return _modifierKey3;
			}
			set
			{
				if (_modifierKey3 == value)
				{
					return;
				}
				if (dvELFlNCXsbUbhaEdTEhAKKKUbc != null && dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerType != 0)
				{
					Logger.LogWarning("You cannot set a modifier key on a non-Keyboard mapping.");
					return;
				}
				_modifierKey3 = value;
				if (Application.isPlaying)
				{
					HtXGKDGdumhvbkXELiTLeqCurYq();
					sXMDOLeJaacTvhLZHNciRMUNwNbk(true);
				}
			}
		}

		public AxisType axisType
		{
			get
			{
				if (_elementType != 0)
				{
					return AxisType.None;
				}
				if (_axisRange == AxisRange.Full)
				{
					return AxisType.Normal;
				}
				return AxisType.Split;
			}
		}

		public ModifierKeyFlags modifierKeyFlags
		{
			get
			{
				ModifierKeyFlags modifierKeyFlags = ModifierKeyFlags.None;
				modifierKeyFlags |= Keyboard.ModifierKeyToModifierKeyFlags(_modifierKey1);
				modifierKeyFlags |= Keyboard.ModifierKeyToModifierKeyFlags(_modifierKey2);
				return modifierKeyFlags | Keyboard.ModifierKeyToModifierKeyFlags(_modifierKey3);
			}
		}

		public KeyCode keyCode
		{
			get
			{
				return Keyboard.YPftdHaMGNRnmewmpKwzlpSDJvD(_keyboardKeyCode);
			}
			set
			{
				keyboardKeyCode = Keyboard.qwCIJpWERNZNAdssvCNfByJbIlVS(value);
			}
		}

		public bool hasModifiers
		{
			get
			{
				if (_keyboardKeyCode == KeyboardKeyCode.None)
				{
					return false;
				}
				if (_modifierKey1 != 0 || _modifierKey2 != 0 || _modifierKey3 != 0)
				{
					return true;
				}
				return false;
			}
		}

		public ControllerMap controllerMap => dvELFlNCXsbUbhaEdTEhAKKKUbc;

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

		public string elementIdentifierName
		{
			get
			{
				if (dvELFlNCXsbUbhaEdTEhAKKKUbc == null || dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerType != 0)
				{
					return MhdaHfzRbOGuyQcIBxhPRrKjlnp;
				}
				return QnACcKPwRbvLBOtomGApSuAEmnb();
			}
		}

		public string actionDescriptiveName => DBIbWkiTtDImiYmEkmtmfdVbcxev;

		public int elementIndex => UgYKpPGXoJUWiIrkuIiAFetRZuI;

		public int id => BoMCLeauexjolkkRqzIpOQOAGri;

		private bool isKeyboardMap
		{
			get
			{
				if (dvELFlNCXsbUbhaEdTEhAKKKUbc != null)
				{
					return dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerType == ControllerType.Keyboard;
				}
				return false;
			}
		}

		private static int nextUid
		{
			get
			{
				int result = uidCounter;
				if (uidCounter == int.MaxValue)
				{
					uidCounter = 0;
				}
				else
				{
					uidCounter++;
				}
				return result;
			}
		}

		internal static bool DELMeXKAfFIGOFYSEfHUJAflYci(ActionElementMap P_0)
		{
			if (P_0 == null)
			{
				return false;
			}
			if (P_0._actionId != -1 && !ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.oQFygjrDaMtXNUGnYpOhqPuoBesB(P_0._actionId))
			{
				return false;
			}
			return true;
		}

		internal static void EREWGEAQKELrjXJhCvBBdgsLhRO(ActionElementMap P_0, ActionElementMap P_1)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException("source");
			}
			if (P_1 == null)
			{
				throw new ArgumentNullException("destination");
			}
			P_1._actionId = P_0._actionId;
			P_1._actionCategoryId = P_0._actionCategoryId;
			P_1._elementType = P_0._elementType;
			P_1._elementIdentifierId = P_0._elementIdentifierId;
			P_1._axisRange = P_0._axisRange;
			P_1._invert = P_0._invert;
			P_1._axisContribution = P_0._axisContribution;
			P_1._keyboardKeyCode = P_0._keyboardKeyCode;
			P_1._modifierKey1 = P_0._modifierKey1;
			P_1._modifierKey2 = P_0._modifierKey2;
			P_1._modifierKey3 = P_0._modifierKey3;
			P_1.dvELFlNCXsbUbhaEdTEhAKKKUbc = P_0.dvELFlNCXsbUbhaEdTEhAKKKUbc;
			P_1.MhdaHfzRbOGuyQcIBxhPRrKjlnp = P_0.MhdaHfzRbOGuyQcIBxhPRrKjlnp;
			P_1.UgYKpPGXoJUWiIrkuIiAFetRZuI = P_0.UgYKpPGXoJUWiIrkuIiAFetRZuI;
			P_1.nZTtfeZBpthDaoAvSONdTABGEaM = P_0.nZTtfeZBpthDaoAvSONdTABGEaM;
			P_1.DBIbWkiTtDImiYmEkmtmfdVbcxev = P_0.DBIbWkiTtDImiYmEkmtmfdVbcxev;
		}

		public ActionElementMap()
		{
			BoMCLeauexjolkkRqzIpOQOAGri = nextUid;
			_actionId = -1;
			_elementIdentifierId = -1;
			nZTtfeZBpthDaoAvSONdTABGEaM = true;
		}

		public ActionElementMap(ActionElementMap map)
			: this()
		{
			EREWGEAQKELrjXJhCvBBdgsLhRO(map, this);
		}

		public ActionElementMap(int actionId, ControllerElementType elementType, int elementIdentifierId)
			: this()
		{
			_actionId = actionId;
			_elementType = elementType;
			_elementIdentifierId = elementIdentifierId;
		}

		public ActionElementMap(int actionId, ControllerElementType elementType, int elementIdentifierId, Pole axisContribution, AxisRange axisRange)
			: this()
		{
			_actionId = actionId;
			_elementType = elementType;
			_elementIdentifierId = elementIdentifierId;
			_axisContribution = axisContribution;
			_axisRange = axisRange;
		}

		public ActionElementMap(int actionId, ControllerElementType elementType, int elementIdentifierId, Pole axisContribution, AxisRange axisRange, bool invert)
			: this()
		{
			_actionId = actionId;
			_elementType = elementType;
			_elementIdentifierId = elementIdentifierId;
			_axisContribution = axisContribution;
			_axisRange = axisRange;
			_invert = invert;
		}

		public ActionElementMap(int actionId, ControllerElementType elementType, Pole axisContribution, KeyboardKeyCode keyboardKeyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3)
			: this()
		{
			_actionId = actionId;
			_elementType = elementType;
			_axisContribution = axisContribution;
			_keyboardKeyCode = keyboardKeyCode;
			_modifierKey1 = modifierKey1;
			_modifierKey2 = modifierKey2;
			_modifierKey3 = modifierKey3;
			BvQqUMsxdhEyIpWyGPdsBxWFxMU();
		}

		public bool CheckForAssignmentConflict(ElementAssignment elementAssignment)
		{
			if (!KLYHzWuPZMMJFOMUjDcceguUNPPf(elementAssignment.type))
			{
				return false;
			}
			if (isKeyboardMap || _keyboardKeyCode != 0)
			{
				KeyCode keyCode = elementAssignment.keyboardKey;
				if (keyCode == KeyCode.None)
				{
					keyCode = ReInput.CoyPNJHWMheFytmTMQdqyctMRFl.VptHLZXdJfMsrxxJFwCBsNGGFnMF.GetKeyCodeById(elementAssignment.elementIdentifierId);
				}
				return iyKtwSsdKMiOKzFELagIKlNLQRTg(Keyboard.qwCIJpWERNZNAdssvCNfByJbIlVS(keyCode), elementAssignment.modifierKeyFlags);
			}
			return GdSFTofWwFyfuHgemLEcXxzvNC(elementAssignment.elementIdentifierId, elementAssignment.axisRange);
		}

		public bool CheckForAssignmentConflict(ActionElementMap elementMap)
		{
			if (elementMap == null || elementMap == this)
			{
				return false;
			}
			if (_elementType != elementMap._elementType)
			{
				return false;
			}
			if (isKeyboardMap || _keyboardKeyCode != 0)
			{
				return iyKtwSsdKMiOKzFELagIKlNLQRTg(elementMap._keyboardKeyCode, elementMap.modifierKeyFlags);
			}
			return GdSFTofWwFyfuHgemLEcXxzvNC(elementMap._elementIdentifierId, elementMap._axisRange);
		}

		public bool ShowInField(AxisRange fieldActionRange)
		{
			if (!ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.oQFygjrDaMtXNUGnYpOhqPuoBesB(_actionId))
			{
				return false;
			}
			if (fieldActionRange == AxisRange.Full)
			{
				if (_elementType == ControllerElementType.Axis)
				{
					if (axisRange != 0)
					{
						return false;
					}
				}
				else if (_elementType == ControllerElementType.Button && ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.RqJdcHsAxUbtTwkILZedHAbEBKb(_actionId).type == InputActionType.Axis)
				{
					return false;
				}
			}
			else
			{
				if (elementType == ControllerElementType.Axis && axisRange == AxisRange.Full)
				{
					return false;
				}
				if (ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.RqJdcHsAxUbtTwkILZedHAbEBKb(_actionId).type == InputActionType.Axis)
				{
					if (fieldActionRange == AxisRange.Positive && axisContribution != 0)
					{
						return false;
					}
					if (fieldActionRange == AxisRange.Negative && axisContribution != Pole.Negative)
					{
						return false;
					}
				}
				else if (axisContribution != axisContribution)
				{
					return false;
				}
			}
			return true;
		}

		public bool IsTarget(ControllerElementTarget elementTarget)
		{
			bjWEjHBROAVpeyUanBwIblyUmUNK bjWEjHBROAVpeyUanBwIblyUmUNK = bjWEjHBROAVpeyUanBwIblyUmUNK.UKQvGkzCJAbJnKtAMsajOiGhqqO(elementTarget);
			bool result = IsTarget(bjWEjHBROAVpeyUanBwIblyUmUNK);
			bjWEjHBROAVpeyUanBwIblyUmUNK.FiATKxCfZoUkEvsaOqFpRJSJFZtH(bjWEjHBROAVpeyUanBwIblyUmUNK);
			return result;
		}

		public bool IsTarget(IControllerElementTarget elementTarget)
		{
			if (elementTarget == null)
			{
				return false;
			}
			if (dvELFlNCXsbUbhaEdTEhAKKKUbc != null)
			{
				Controller controller = elementTarget.controller;
				if (controller == null)
				{
					return false;
				}
				if (controller.id != dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerId || controller.type != dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerType)
				{
					return false;
				}
			}
			if (_elementType != elementTarget.elementType)
			{
				return false;
			}
			if (_elementType == ControllerElementType.Axis)
			{
				if (_elementIdentifierId == elementTarget.elementIdentifierId)
				{
					return _axisRange == elementTarget.axisRange;
				}
				return false;
			}
			if (_elementType == ControllerElementType.Button)
			{
				return _elementIdentifierId == elementTarget.elementIdentifierId;
			}
			throw new NotImplementedException();
		}

		internal void sXMDOLeJaacTvhLZHNciRMUNwNbk(ControllerMap P_0)
		{
			dvELFlNCXsbUbhaEdTEhAKKKUbc = P_0;
			ControllerType controllerType = P_0.controllerType;
			HardwareControllerMap_Game hardwareControllerMap_Game = ((P_0.controller != null) ? P_0.controller.pAhzhvigFoLFbwPDdcXHatZWRIl : null);
			sXMDOLeJaacTvhLZHNciRMUNwNbk(controllerType, hardwareControllerMap_Game, controllerType == ControllerType.Keyboard && _elementIdentifierId <= 0);
		}

		internal void AoIDokffkOIEeMiGpVwewpwPAksj(ControllerMap P_0, HardwareControllerMap_Game P_1)
		{
			dvELFlNCXsbUbhaEdTEhAKKKUbc = P_0;
			sXMDOLeJaacTvhLZHNciRMUNwNbk(P_0.controllerType, P_1, P_0.controllerType == ControllerType.Keyboard && _elementIdentifierId <= 0);
		}

		private void sXMDOLeJaacTvhLZHNciRMUNwNbk(bool P_0)
		{
			if (dvELFlNCXsbUbhaEdTEhAKKKUbc != null)
			{
				sXMDOLeJaacTvhLZHNciRMUNwNbk(dvELFlNCXsbUbhaEdTEhAKKKUbc.controllerType, (dvELFlNCXsbUbhaEdTEhAKKKUbc.controller != null) ? dvELFlNCXsbUbhaEdTEhAKKKUbc.controller.pAhzhvigFoLFbwPDdcXHatZWRIl : null, P_0);
			}
		}

		private void sXMDOLeJaacTvhLZHNciRMUNwNbk(ControllerType P_0, HardwareControllerMap_Game P_1, bool P_2)
		{
			if (dvELFlNCXsbUbhaEdTEhAKKKUbc == null)
			{
				return;
			}
			if (P_0 == ControllerType.Keyboard)
			{
				Keyboard keyboard = ReInput.controllers.Keyboard;
				if (P_2)
				{
					UgYKpPGXoJUWiIrkuIiAFetRZuI = keyboard.GetButtonIndex(_keyboardKeyCode);
					BvQqUMsxdhEyIpWyGPdsBxWFxMU();
				}
				else
				{
					UgYKpPGXoJUWiIrkuIiAFetRZuI = keyboard.GetButtonIndexById(_elementIdentifierId);
					kFTnvUlyLrAMfmmvTBUEvWvSPdV();
				}
			}
			else
			{
				if (P_1 == null)
				{
					return;
				}
				switch (_elementType)
				{
				case ControllerElementType.Axis:
					UgYKpPGXoJUWiIrkuIiAFetRZuI = P_1.GetAxisIndex(_elementIdentifierId);
					if (axisType == AxisType.Split)
					{
						if (_axisRange == AxisRange.Positive)
						{
							MhdaHfzRbOGuyQcIBxhPRrKjlnp = P_1.GetElementIdentifierPositiveName(_elementIdentifierId);
							if (string.IsNullOrEmpty(elementIdentifierName))
							{
								MhdaHfzRbOGuyQcIBxhPRrKjlnp = P_1.GetElementIdentifierName(_elementIdentifierId) + " +";
							}
						}
						else
						{
							MhdaHfzRbOGuyQcIBxhPRrKjlnp = P_1.GetElementIdentifierNegativeName(_elementIdentifierId);
							if (string.IsNullOrEmpty(elementIdentifierName))
							{
								MhdaHfzRbOGuyQcIBxhPRrKjlnp = P_1.GetElementIdentifierName(_elementIdentifierId) + " -";
							}
						}
					}
					else
					{
						MhdaHfzRbOGuyQcIBxhPRrKjlnp = P_1.GetElementIdentifierName(_elementIdentifierId);
					}
					break;
				case ControllerElementType.Button:
					UgYKpPGXoJUWiIrkuIiAFetRZuI = P_1.GetButtonIndex(_elementIdentifierId);
					MhdaHfzRbOGuyQcIBxhPRrKjlnp = P_1.GetElementIdentifierName(_elementIdentifierId);
					break;
				default:
					throw new NotImplementedException();
				}
			}
			TfTBnAkDBRkjKyPeHSPwTuLQXVQ();
		}

		private void TfTBnAkDBRkjKyPeHSPwTuLQXVQ()
		{
			InputAction inputAction = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.RqJdcHsAxUbtTwkILZedHAbEBKb(_actionId);
			if (inputAction == null)
			{
				DBIbWkiTtDImiYmEkmtmfdVbcxev = string.Empty;
				return;
			}
			if (inputAction.type == InputActionType.Axis)
			{
				if (_elementType == ControllerElementType.Axis && _axisRange == AxisRange.Full)
				{
					DBIbWkiTtDImiYmEkmtmfdVbcxev = inputAction.descriptiveName;
					return;
				}
				if (_elementType == ControllerElementType.Axis || _elementType == ControllerElementType.Button)
				{
					if (_axisContribution == Pole.Positive)
					{
						DBIbWkiTtDImiYmEkmtmfdVbcxev = inputAction.positiveDescriptiveName;
						return;
					}
					if (_axisContribution == Pole.Negative)
					{
						DBIbWkiTtDImiYmEkmtmfdVbcxev = inputAction.negativeDescriptiveName;
						return;
					}
					throw new NotImplementedException();
				}
				throw new NotImplementedException();
			}
			if (inputAction.type == InputActionType.Button)
			{
				if (_elementType == ControllerElementType.Axis && _axisRange == AxisRange.Full)
				{
					DBIbWkiTtDImiYmEkmtmfdVbcxev = inputAction.descriptiveName;
					return;
				}
				if (_elementType == ControllerElementType.Axis || _elementType == ControllerElementType.Button)
				{
					if (_axisContribution == Pole.Negative)
					{
						DBIbWkiTtDImiYmEkmtmfdVbcxev = inputAction.negativeDescriptiveName;
					}
					else
					{
						DBIbWkiTtDImiYmEkmtmfdVbcxev = inputAction.descriptiveName;
					}
					return;
				}
				throw new NotImplementedException();
			}
			throw new NotImplementedException();
		}

		private string QnACcKPwRbvLBOtomGApSuAEmnb()
		{
			string text = Keyboard.GetKeyName((KeyCode)_keyboardKeyCode);
			if (string.Equals(text, gRuveBOlsfKRavsiAIjomWSnsQD, StringComparison.Ordinal) && cpwvXcvAOEWqopVlQJdmTgkCKoo == modifierKeyFlags)
			{
				return MhdaHfzRbOGuyQcIBxhPRrKjlnp;
			}
			gRuveBOlsfKRavsiAIjomWSnsQD = text;
			cpwvXcvAOEWqopVlQJdmTgkCKoo = modifierKeyFlags;
			if (_modifierKey3 != 0)
			{
				text = $"{Consts.modifierKeyShortNames[(int)_modifierKey3]} + {text}";
			}
			if (_modifierKey2 != 0)
			{
				text = $"{Consts.modifierKeyShortNames[(int)_modifierKey2]} + {text}";
			}
			if (_modifierKey1 != 0)
			{
				text = $"{Consts.modifierKeyShortNames[(int)_modifierKey1]} + {text}";
			}
			MhdaHfzRbOGuyQcIBxhPRrKjlnp = text;
			return text;
		}

		internal void LlCkzvOeJVaCziTDPktzBWuYotAZ()
		{
			_actionCategoryId = -1;
			_actionId = -1;
			_elementType = ControllerElementType.Axis;
			_elementIdentifierId = -1;
			_axisRange = AxisRange.Full;
			_invert = false;
			_axisContribution = Pole.Positive;
			_keyboardKeyCode = KeyboardKeyCode.None;
			_modifierKey1 = ModifierKey.None;
			_modifierKey2 = ModifierKey.None;
			_modifierKey3 = ModifierKey.None;
			dvELFlNCXsbUbhaEdTEhAKKKUbc = null;
			nZTtfeZBpthDaoAvSONdTABGEaM = true;
			MhdaHfzRbOGuyQcIBxhPRrKjlnp = string.Empty;
			gRuveBOlsfKRavsiAIjomWSnsQD = null;
			cpwvXcvAOEWqopVlQJdmTgkCKoo = ModifierKeyFlags.None;
			UgYKpPGXoJUWiIrkuIiAFetRZuI = -1;
		}

		private bool iyKtwSsdKMiOKzFELagIKlNLQRTg(KeyboardKeyCode P_0, ModifierKeyFlags P_1)
		{
			if (_elementType != ControllerElementType.Button)
			{
				return false;
			}
			if (P_0 == KeyboardKeyCode.None)
			{
				return false;
			}
			if (_keyboardKeyCode != P_0)
			{
				return false;
			}
			if (Keyboard.vpXglKHwGnVaMSarFkcdvrKNtuE(modifierKeyFlags) != Keyboard.vpXglKHwGnVaMSarFkcdvrKNtuE(P_1))
			{
				return false;
			}
			return true;
		}

		private bool GdSFTofWwFyfuHgemLEcXxzvNC(int P_0, AxisRange P_1)
		{
			if (_elementIdentifierId != P_0)
			{
				return false;
			}
			if (_elementType == ControllerElementType.Button)
			{
				return true;
			}
			if (_elementType == ControllerElementType.Axis)
			{
				if (_axisRange == AxisRange.Full || P_1 == AxisRange.Full)
				{
					return true;
				}
				if (_axisRange == AxisRange.Positive && P_1 == AxisRange.Positive)
				{
					return true;
				}
				if (_axisRange == AxisRange.Negative && P_1 == AxisRange.Negative)
				{
					return true;
				}
				return false;
			}
			throw new NotImplementedException();
		}

		private bool KLYHzWuPZMMJFOMUjDcceguUNPPf(ElementAssignmentType P_0)
		{
			if (_elementType == ControllerElementType.Button)
			{
				if (P_0 == ElementAssignmentType.Button || P_0 == ElementAssignmentType.KeyboardKey)
				{
					return true;
				}
			}
			else
			{
				if (_elementType != 0)
				{
					throw new NotImplementedException();
				}
				if (P_0 == ElementAssignmentType.FullAxis || P_0 == ElementAssignmentType.SplitAxis)
				{
					return true;
				}
			}
			return false;
		}

		private void BvQqUMsxdhEyIpWyGPdsBxWFxMU()
		{
			_elementIdentifierId = Keyboard.zqaoVxjyFQoMohUwgDiEYFekzOS(_keyboardKeyCode);
		}

		private void kFTnvUlyLrAMfmmvTBUEvWvSPdV()
		{
			if (_elementIdentifierId < 0)
			{
				_keyboardKeyCode = KeyboardKeyCode.None;
			}
			else if (ReInput.isReady)
			{
				_keyboardKeyCode = Keyboard.qwCIJpWERNZNAdssvCNfByJbIlVS(ReInput.CoyPNJHWMheFytmTMQdqyctMRFl.VptHLZXdJfMsrxxJFwCBsNGGFnMF.GetKeyCodeById(_elementIdentifierId));
			}
		}

		private void HtXGKDGdumhvbkXELiTLeqCurYq()
		{
			if (_modifierKey1 != 0)
			{
				if (_modifierKey1 == _modifierKey2)
				{
					_modifierKey2 = ModifierKey.None;
				}
				if (_modifierKey1 == _modifierKey3)
				{
					_modifierKey3 = ModifierKey.None;
				}
			}
			if (_modifierKey2 != 0 && _modifierKey2 == _modifierKey3)
			{
				_modifierKey3 = ModifierKey.None;
			}
			if (_modifierKey3 != 0 && _modifierKey2 == ModifierKey.None)
			{
				_modifierKey2 = _modifierKey3;
				_modifierKey3 = ModifierKey.None;
			}
			if (_modifierKey2 != 0 && _modifierKey1 == ModifierKey.None)
			{
				_modifierKey1 = _modifierKey2;
				_modifierKey2 = ModifierKey.None;
			}
		}

		internal SerializedObject KmsZJAaClfxbOKcqKGgeMqITFsc()
		{
			SerializedObject serializedObject = new SerializedObject(GetType(), SerializedObject.ObjectType.Object);
			serializedObject.Add("actionCategoryId", _actionCategoryId);
			serializedObject.Add("actionId", _actionId);
			serializedObject.Add("elementType", _elementType);
			serializedObject.Add("elementIdentifierId", _elementIdentifierId);
			serializedObject.Add("axisRange", _axisRange);
			serializedObject.Add("invert", _invert);
			serializedObject.Add("axisContribution", _axisContribution);
			serializedObject.Add("keyboardKeyCode", _keyboardKeyCode);
			serializedObject.Add("modifierKey1", _modifierKey1);
			serializedObject.Add("modifierKey2", _modifierKey2);
			serializedObject.Add("modifierKey3", _modifierKey3);
			serializedObject.Add("enabled", nZTtfeZBpthDaoAvSONdTABGEaM);
			return serializedObject;
		}

		internal void jzPtspnkZAgrKJfuKATzOhURnEB(SerializedObject P_0)
		{
			_actionCategoryId = -1;
			_actionId = -1;
			_elementIdentifierId = -1;
			_axisRange = AxisRange.Full;
			_invert = false;
			_axisContribution = Pole.Positive;
			_keyboardKeyCode = KeyboardKeyCode.None;
			_modifierKey1 = ModifierKey.None;
			_modifierKey2 = ModifierKey.None;
			_modifierKey3 = ModifierKey.None;
			nZTtfeZBpthDaoAvSONdTABGEaM = true;
			P_0.TryGetDeserializedValueByRef("actionCategoryId", ref _actionCategoryId);
			P_0.TryGetDeserializedValueByRef("actionId", ref _actionId);
			P_0.TryGetDeserializedValueByRef("elementType", ref _elementType);
			P_0.TryGetDeserializedValueByRef("elementIdentifierId", ref _elementIdentifierId);
			P_0.TryGetDeserializedValueByRef("axisRange", ref _axisRange);
			P_0.TryGetDeserializedValueByRef("invert", ref _invert);
			P_0.TryGetDeserializedValueByRef("axisContribution", ref _axisContribution);
			P_0.TryGetDeserializedValueByRef("keyboardKeyCode", ref _keyboardKeyCode);
			P_0.TryGetDeserializedValueByRef("modifierKey1", ref _modifierKey1);
			P_0.TryGetDeserializedValueByRef("modifierKey2", ref _modifierKey2);
			P_0.TryGetDeserializedValueByRef("modifierKey3", ref _modifierKey3);
			P_0.TryGetDeserializedValueByRef("enabled", ref nZTtfeZBpthDaoAvSONdTABGEaM);
		}

		public override string ToString()
		{
			if (s_toStringSB == null)
			{
				s_toStringSB = new StringBuilder();
			}
			StringTools.WriteVar(s_toStringSB, "Id", BoMCLeauexjolkkRqzIpOQOAGri);
			StringTools.WriteVar(s_toStringSB, "Enabled", nZTtfeZBpthDaoAvSONdTABGEaM);
			StringTools.WriteVar(s_toStringSB, "Controller Map Id", (dvELFlNCXsbUbhaEdTEhAKKKUbc != null) ? dvELFlNCXsbUbhaEdTEhAKKKUbc.id : (-1));
			StringTools.WriteVar(s_toStringSB, "Action Id", _actionId);
			StringTools.WriteVar(s_toStringSB, "Action Descriptive Name", DBIbWkiTtDImiYmEkmtmfdVbcxev);
			StringTools.WriteVar(s_toStringSB, "Element Type", _elementType);
			StringTools.WriteVar(s_toStringSB, "Element Identifier Id", _elementIdentifierId);
			StringTools.WriteVar(s_toStringSB, "Element Identifier Name", MhdaHfzRbOGuyQcIBxhPRrKjlnp);
			StringTools.WriteVar(s_toStringSB, "Element Index", UgYKpPGXoJUWiIrkuIiAFetRZuI);
			StringTools.WriteVar(s_toStringSB, "Axis Range", _axisRange);
			StringTools.WriteVar(s_toStringSB, "Invert", _invert);
			StringTools.WriteVar(s_toStringSB, "Axis Contribution", _axisContribution);
			StringTools.WriteVar(s_toStringSB, "Keyboard Key Code", _keyboardKeyCode);
			StringTools.WriteVar(s_toStringSB, "Has Modifiers", hasModifiers);
			StringTools.WriteVar(s_toStringSB, "Modifier Key 1", _modifierKey1);
			StringTools.WriteVar(s_toStringSB, "modifier Key 2", _modifierKey2);
			StringTools.WriteVar(s_toStringSB, "modifier Key 3", _modifierKey3);
			StringTools.WriteVar(s_toStringSB, "modifier Key Flags", modifierKeyFlags);
			string result = s_toStringSB.ToString();
			s_toStringSB.Length = 0;
			return result;
		}
	}
}
