using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired.Data.Mapping;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	public abstract class ControllerMap
	{
		private class dZciLkdEXGehrFRWUnwXzpJoUzL : IComparer<ActionElementMap>
		{
			public static dZciLkdEXGehrFRWUnwXzpJoUzL jSlMHYpliVFUzTfJqvhklMtlwTN;

			public static dZciLkdEXGehrFRWUnwXzpJoUzL iZRfKKTEZrbyLvwfdbhJgLEHTxh => jSlMHYpliVFUzTfJqvhklMtlwTN ?? (jSlMHYpliVFUzTfJqvhklMtlwTN = new dZciLkdEXGehrFRWUnwXzpJoUzL());

			public int Compare(ActionElementMap x, ActionElementMap y)
			{
				if (x == null)
				{
					if (y == null)
					{
						return 0;
					}
					return -1;
				}
				if (y == null)
				{
					return 1;
				}
				if (x._elementType == y._elementType)
				{
					return x.id.CompareTo(y.id);
				}
				if (x._elementType switch
				{
					ControllerElementType.Button => 0, 
					ControllerElementType.Axis => 1, 
					ControllerElementType.CompoundElement => 2, 
					_ => throw new NotImplementedException(), 
				} <= y._elementType switch
				{
					ControllerElementType.Button => 0, 
					ControllerElementType.Axis => 1, 
					ControllerElementType.CompoundElement => 2, 
					_ => throw new NotImplementedException(), 
				})
				{
					return -1;
				}
				return 1;
			}
		}

		protected int _id;

		protected int _sourceMapId;

		protected int _categoryId;

		protected int _layoutId;

		protected string _name;

		protected Guid _hardwareGuid;

		protected bool _enabled;

		internal readonly int PivQvdYMhUssuLwaglJVqkqXMSH;

		private readonly AList<ActionElementMap> YILJekTondgbpvWXnoVWVPjfRCy;

		private readonly ReadOnlyCollection<ActionElementMap> UXfcArMNrnnFQlmwDuGwyqRWEsj;

		private readonly AList<ActionElementMap> rmEZzdVeJPtxyMsETjWuoDiOhqY;

		private readonly ReadOnlyCollection<ActionElementMap> rJMGBVspeEtvZOInwjElORkodre;

		protected int _playerId;

		protected int _controllerId;

		protected ControllerType _controllerType;

		private static int MXnVsTDVjUGBtCRZAFArwtWmoTA;

		private static int nextUid
		{
			get
			{
				int mXnVsTDVjUGBtCRZAFArwtWmoTA = MXnVsTDVjUGBtCRZAFArwtWmoTA;
				if (MXnVsTDVjUGBtCRZAFArwtWmoTA == int.MaxValue)
				{
					MXnVsTDVjUGBtCRZAFArwtWmoTA = 0;
				}
				else
				{
					MXnVsTDVjUGBtCRZAFArwtWmoTA++;
				}
				return mXnVsTDVjUGBtCRZAFArwtWmoTA;
			}
		}

		public int id
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return -1;
				}
				return _id;
			}
		}

		public int sourceMapId
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return -1;
				}
				return _sourceMapId;
			}
			internal set
			{
				_sourceMapId = value;
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
				return _categoryId;
			}
			internal set
			{
				_categoryId = value;
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
				return _layoutId;
			}
			internal set
			{
				_layoutId = value;
			}
		}

		public string name
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return string.Empty;
				}
				return _name;
			}
			internal set
			{
				_name = value;
			}
		}

		public Guid hardwareGuid
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return Guid.Empty;
				}
				return _hardwareGuid;
			}
			internal set
			{
				_hardwareGuid = value;
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
				return _enabled;
			}
			set
			{
				_enabled = value;
			}
		}

		public int playerId
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return -1;
				}
				return _playerId;
			}
			internal set
			{
				_playerId = value;
			}
		}

		public int controllerId
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return -1;
				}
				return _controllerId;
			}
			internal set
			{
				_controllerId = value;
			}
		}

		public Controller controller
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return ReInput.controllers.GetController(_controllerType, _controllerId);
			}
		}

		public ControllerType controllerType
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return ControllerType.Keyboard;
				}
				return _controllerType;
			}
			internal set
			{
				_controllerType = value;
			}
		}

		public Player player
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return ReInput.players.GetPlayer(_playerId);
			}
		}

		public int elementMapCount
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return 0;
				}
				return rmEZzdVeJPtxyMsETjWuoDiOhqY.Count;
			}
		}

		public int buttonMapCount
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return 0;
				}
				return YILJekTondgbpvWXnoVWVPjfRCy.Count;
			}
		}

		public IList<ActionElementMap> AllMaps
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
				}
				return rJMGBVspeEtvZOInwjElORkodre;
			}
		}

		public IList<ActionElementMap> ButtonMaps
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
				}
				return UXfcArMNrnnFQlmwDuGwyqRWEsj;
			}
		}

		internal AList<ActionElementMap> ButtonMaps_orig => YILJekTondgbpvWXnoVWVPjfRCy;

		public ControllerMap()
		{
			_id = nextUid;
			_sourceMapId = -1;
			YILJekTondgbpvWXnoVWVPjfRCy = new AList<ActionElementMap>();
			UXfcArMNrnnFQlmwDuGwyqRWEsj = new ReadOnlyCollection<ActionElementMap>(YILJekTondgbpvWXnoVWVPjfRCy);
			rmEZzdVeJPtxyMsETjWuoDiOhqY = new AList<ActionElementMap>();
			rJMGBVspeEtvZOInwjElORkodre = new ReadOnlyCollection<ActionElementMap>(rmEZzdVeJPtxyMsETjWuoDiOhqY);
			PivQvdYMhUssuLwaglJVqkqXMSH = ReInput.id;
		}

		public ControllerMap(ControllerMap source)
			: this()
		{
			_id = nextUid;
			_sourceMapId = source._sourceMapId;
			_categoryId = source._categoryId;
			_layoutId = source._layoutId;
			_name = source._name;
			_hardwareGuid = source._hardwareGuid;
			_enabled = source._enabled;
			_playerId = source._playerId;
			_controllerId = source._controllerId;
			_controllerType = source._controllerType;
			if (source.YILJekTondgbpvWXnoVWVPjfRCy != null)
			{
				int count = source.YILJekTondgbpvWXnoVWVPjfRCy.Count;
				for (int i = 0; i < count; i++)
				{
					JgxqZpNclObWiLHhocKCZuxUurf(new ActionElementMap(source.YILJekTondgbpvWXnoVWVPjfRCy[i]));
				}
			}
		}

		public bool ContainsAction(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			InputAction inputAction = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.nYlDpDffCkjRccBgMgyGeVRBCsz(actionName, true);
			if (inputAction == null)
			{
				return false;
			}
			return ContainsAction(inputAction.id);
		}

		public virtual bool ContainsAction(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (actionId < 0)
			{
				return false;
			}
			int num = buttonMapCount;
			for (int i = 0; i < num; i++)
			{
				if (YILJekTondgbpvWXnoVWVPjfRCy[i]._actionId == actionId)
				{
					return true;
				}
			}
			return false;
		}

		public bool ContainsElementIdentifier(int elementIdentifierId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			AList<ActionElementMap> aList = rmEZzdVeJPtxyMsETjWuoDiOhqY;
			for (int i = 0; i < aList.Count; i++)
			{
				if (rmEZzdVeJPtxyMsETjWuoDiOhqY[i].elementIdentifierId == elementIdentifierId)
				{
					return true;
				}
			}
			return false;
		}

		public bool ContainsKeyboardKey(KeyCode keyCode, ModifierKeyFlags modifierKeys)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			AList<ActionElementMap> aList = rmEZzdVeJPtxyMsETjWuoDiOhqY;
			for (int i = 0; i < aList.Count; i++)
			{
				if (rmEZzdVeJPtxyMsETjWuoDiOhqY[i].keyCode == keyCode && rmEZzdVeJPtxyMsETjWuoDiOhqY[i].modifierKeyFlags == modifierKeys)
				{
					return true;
				}
			}
			return false;
		}

		public bool ContainsElementMap(ActionElementMap elementMap)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (elementMap == null)
			{
				return false;
			}
			AList<ActionElementMap> aList = rmEZzdVeJPtxyMsETjWuoDiOhqY;
			for (int i = 0; i < aList.Count; i++)
			{
				if (rmEZzdVeJPtxyMsETjWuoDiOhqY[i].BoMCLeauexjolkkRqzIpOQOAGri == elementMap.id)
				{
					return true;
				}
			}
			return false;
		}

		public bool ContainsElementMap(int elementMapId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			AList<ActionElementMap> aList = rmEZzdVeJPtxyMsETjWuoDiOhqY;
			for (int i = 0; i < aList.Count; i++)
			{
				if (rmEZzdVeJPtxyMsETjWuoDiOhqY[i].BoMCLeauexjolkkRqzIpOQOAGri == elementMapId)
				{
					return true;
				}
			}
			return false;
		}

		public bool ReplaceOrCreateElementMap(ElementAssignment elementAssignment)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			ActionElementMap result;
			return ReplaceOrCreateElementMap(elementAssignment, out result);
		}

		public bool ReplaceOrCreateElementMap(ElementAssignment elementAssignment, out ActionElementMap result)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				result = null;
				return false;
			}
			ActionElementMap elementMap = GetElementMap(elementAssignment.elementMapId);
			if (elementMap == null)
			{
				return CreateElementMap(elementAssignment, out result);
			}
			return ReplaceElementMap(elementAssignment, out result);
		}

		public bool CreateElementMap(ElementAssignment elementAssignment)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			ActionElementMap result;
			return CreateElementMap(elementAssignment, out result);
		}

		public bool CreateElementMap(ElementAssignment elementAssignment, out ActionElementMap result)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				result = null;
				return false;
			}
			if (_controllerType == ControllerType.Keyboard)
			{
				return CreateElementMap(elementAssignment.actionId, elementAssignment.axisContribution, elementAssignment.keyboardKey, elementAssignment.modifierKeyFlags, out result);
			}
			if (_controllerType == ControllerType.Joystick || _controllerType == ControllerType.Mouse || _controllerType == ControllerType.Custom)
			{
				return CreateElementMap(elementAssignment.actionId, elementAssignment.axisContribution, elementAssignment.elementIdentifierId, BbpfTcGSZRHmltstKOfXrucHPJO.kldXmPFoOIQiSRQnQLvavtAnQcs(elementAssignment.type), elementAssignment.axisRange, elementAssignment.invert, out result);
			}
			throw new NotImplementedException();
		}

		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3)
		{
			ActionElementMap result;
			return CreateElementMap(actionId, axisContribution, keyCode, modifierKey1, modifierKey2, modifierKey3, out result);
		}

		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3, out ActionElementMap result)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				result = null;
				return false;
			}
			ActionElementMap actionElementMap = new ActionElementMap(actionId, ControllerElementType.Button, axisContribution, (KeyboardKeyCode)keyCode, modifierKey1, modifierKey2, modifierKey3);
			ReInput.controllers.Keyboard.UTvazqIZLDwOPLfFaGTxhGSydhT(this, actionElementMap);
			JgxqZpNclObWiLHhocKCZuxUurf(actionElementMap);
			result = actionElementMap;
			return true;
		}

		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags)
		{
			ActionElementMap result;
			return CreateElementMap(actionId, axisContribution, keyCode, modifierKeyFlags, out result);
		}

		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags, out ActionElementMap result)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				result = null;
				return false;
			}
			vXNcrzzMXIFAnnkDivMNYDqnXqP vXNcrzzMXIFAnnkDivMNYDqnXqP = vXNcrzzMXIFAnnkDivMNYDqnXqP.XkSYUAelKYptqQSiUpoDCQZaJiY(modifierKeyFlags);
			return CreateElementMap(actionId, axisContribution, keyCode, vXNcrzzMXIFAnnkDivMNYDqnXqP.pBOItftNnYIXiGHBBoNDskFSbdJg, vXNcrzzMXIFAnnkDivMNYDqnXqP.IwdxopucklVhghZuedOEVRAToqn, vXNcrzzMXIFAnnkDivMNYDqnXqP.auChswPsWWQTcnYMenvrOHMdkZD, out result);
		}

		public bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert)
		{
			ActionElementMap result;
			return CreateElementMap(actionId, axisContribution, elementIdentifierId, elementType, axisRange, invert, out result);
		}

		public virtual bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				result = null;
				return false;
			}
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(elementType))
			{
				result = null;
				return false;
			}
			ActionElementMap actionElementMap = new ActionElementMap(actionId, elementType, elementIdentifierId, axisContribution, axisRange);
			BakeElementMap(actionElementMap);
			JgxqZpNclObWiLHhocKCZuxUurf(actionElementMap);
			result = actionElementMap;
			return true;
		}

		public bool ReplaceElementMap(ElementAssignment elementAssignment)
		{
			ActionElementMap result;
			return ReplaceElementMap(elementAssignment, out result);
		}

		public bool ReplaceElementMap(ElementAssignment elementAssignment, out ActionElementMap result)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				result = null;
				return false;
			}
			if (_controllerType == ControllerType.Keyboard)
			{
				return ReplaceElementMap(elementAssignment.elementMapId, elementAssignment.actionId, elementAssignment.axisContribution, elementAssignment.keyboardKey, elementAssignment.modifierKeyFlags, out result);
			}
			if (_controllerType == ControllerType.Joystick || _controllerType == ControllerType.Mouse || _controllerType == ControllerType.Custom)
			{
				return ReplaceElementMap(elementAssignment.elementMapId, elementAssignment.actionId, elementAssignment.axisContribution, elementAssignment.elementIdentifierId, BbpfTcGSZRHmltstKOfXrucHPJO.kldXmPFoOIQiSRQnQLvavtAnQcs(elementAssignment.type), elementAssignment.axisRange, elementAssignment.invert, out result);
			}
			throw new NotImplementedException();
		}

		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3)
		{
			ActionElementMap result;
			return ReplaceElementMap(elementMapId, actionId, axisContribution, keyCode, modifierKey1, modifierKey2, modifierKey3, out result);
		}

		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3, out ActionElementMap result)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				result = null;
				return false;
			}
			ActionElementMap elementMap = GetElementMap(elementMapId);
			if (elementMap == null)
			{
				result = null;
				return false;
			}
			int num = czSBdbEZIzmWCEwoUuHHZBpBahg(elementMapId);
			if (num < 0)
			{
				DeleteElementMap(elementMapId);
				elementMap._elementType = ControllerElementType.Button;
				JgxqZpNclObWiLHhocKCZuxUurf(elementMap);
			}
			num = czSBdbEZIzmWCEwoUuHHZBpBahg(elementMapId);
			if (num < 0)
			{
				result = null;
				return false;
			}
			elementMap.LlCkzvOeJVaCziTDPktzBWuYotAZ();
			elementMap._actionId = actionId;
			elementMap._elementType = ControllerElementType.Button;
			elementMap._axisContribution = axisContribution;
			elementMap._keyboardKeyCode = (KeyboardKeyCode)keyCode;
			elementMap._modifierKey1 = modifierKey1;
			elementMap._modifierKey2 = modifierKey2;
			elementMap._modifierKey3 = modifierKey3;
			ReInput.controllers.Keyboard.UTvazqIZLDwOPLfFaGTxhGSydhT(this, elementMap);
			result = elementMap;
			return true;
		}

		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags)
		{
			ActionElementMap result;
			return ReplaceElementMap(elementMapId, actionId, axisContribution, keyCode, modifierKeyFlags, out result);
		}

		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags, out ActionElementMap result)
		{
			vXNcrzzMXIFAnnkDivMNYDqnXqP vXNcrzzMXIFAnnkDivMNYDqnXqP = vXNcrzzMXIFAnnkDivMNYDqnXqP.XkSYUAelKYptqQSiUpoDCQZaJiY(modifierKeyFlags);
			return ReplaceElementMap(elementMapId, actionId, axisContribution, keyCode, vXNcrzzMXIFAnnkDivMNYDqnXqP.pBOItftNnYIXiGHBBoNDskFSbdJg, vXNcrzzMXIFAnnkDivMNYDqnXqP.IwdxopucklVhghZuedOEVRAToqn, vXNcrzzMXIFAnnkDivMNYDqnXqP.auChswPsWWQTcnYMenvrOHMdkZD, out result);
		}

		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert)
		{
			ActionElementMap result;
			return ReplaceElementMap(elementMapId, actionId, axisContribution, elementIdentifierId, elementType, axisRange, invert, out result);
		}

		public virtual bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				result = null;
				return false;
			}
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(elementType))
			{
				result = null;
				return false;
			}
			ActionElementMap elementMap = GetElementMap(elementMapId);
			if (elementMap == null)
			{
				result = null;
				return false;
			}
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(elementMap._elementType))
			{
				DeleteElementMap(elementMapId);
				elementMap._elementType = ControllerElementType.Button;
				JgxqZpNclObWiLHhocKCZuxUurf(elementMap);
			}
			int num = czSBdbEZIzmWCEwoUuHHZBpBahg(elementMapId);
			if (num < 0)
			{
				result = null;
				return false;
			}
			VbYTsEAPoQgdcsYwtmTpEeMSVQY(elementMap, actionId, axisContribution, elementIdentifierId, elementType, axisRange, invert);
			BakeElementMap(elementMap);
			result = elementMap;
			return true;
		}

		public virtual bool DeleteElementMap(int elementMapId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			int num = czSBdbEZIzmWCEwoUuHHZBpBahg(elementMapId);
			if (num < 0)
			{
				return false;
			}
			kBNGxEDTlQojrgBCfSmFXzKKvQX(elementMapId, num);
			return true;
		}

		public virtual bool DeleteElementMapsWithAction(string actionName)
		{
			return DeleteElementMapsWithAction(ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName));
		}

		public virtual bool DeleteElementMapsWithAction(int actionId)
		{
			return DeleteButtonMapsWithAction(actionId);
		}

		public virtual ActionElementMap GetElementMap(int elementMapId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			if (elementMapId < 0)
			{
				return null;
			}
			int num = buttonMapCount;
			for (int i = 0; i < num; i++)
			{
				if (YILJekTondgbpvWXnoVWVPjfRCy[i].BoMCLeauexjolkkRqzIpOQOAGri == elementMapId)
				{
					return YILJekTondgbpvWXnoVWVPjfRCy[i];
				}
			}
			return null;
		}

		public ActionElementMap[] GetElementMaps()
		{
			return GetElementMaps(skipDisabledMaps: false);
		}

		public ActionElementMap[] GetElementMaps(bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.array;
			}
			int num = elementMapCount;
			if (num == 0)
			{
				return EmptyObjects<ActionElementMap>.array;
			}
			List<ActionElementMap> list = new List<ActionElementMap>(num);
			foreach (ActionElementMap allMap in AllMaps)
			{
				if (!skipDisabledMaps || allMap.nZTtfeZBpthDaoAvSONdTABGEaM)
				{
					list.Add(allMap);
				}
			}
			return list.ToArray();
		}

		public int GetElementMaps(List<ActionElementMap> results)
		{
			return GetElementMaps(skipDisabledMaps: false, results);
		}

		public int GetElementMaps(bool skipDisabledMaps, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			if (results == null)
			{
				throw new ArgumentNullException("results");
			}
			results.Clear();
			return ZaUNnOLPcrdqeSVoeoRcJfoOcuPh(results, skipDisabledMaps);
		}

		public ActionElementMap[] GetElementMapsWithAction(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.array;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return GetElementMapsWithAction(actionId);
		}

		public ActionElementMap[] GetElementMapsWithAction(int actionId)
		{
			return GetElementMapsWithAction(actionId, skipDisabledMaps: false);
		}

		public ActionElementMap[] GetElementMapsWithAction(string actionName, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.array;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return GetElementMapsWithAction(actionId, skipDisabledMaps);
		}

		public ActionElementMap[] GetElementMapsWithAction(int actionId, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.array;
			}
			if (actionId < 0)
			{
				return EmptyObjects<ActionElementMap>.array;
			}
			if (elementMapCount == 0)
			{
				return EmptyObjects<ActionElementMap>.array;
			}
			int num = 0;
			foreach (ActionElementMap allMap in AllMaps)
			{
				if (allMap._actionId == actionId && (!skipDisabledMaps || allMap.nZTtfeZBpthDaoAvSONdTABGEaM))
				{
					num++;
				}
			}
			if (num == 0)
			{
				return EmptyObjects<ActionElementMap>.array;
			}
			ActionElementMap[] array = new ActionElementMap[num];
			int num2 = 0;
			foreach (ActionElementMap allMap2 in AllMaps)
			{
				if (allMap2._actionId == actionId && (!skipDisabledMaps || allMap2.nZTtfeZBpthDaoAvSONdTABGEaM))
				{
					array[num2] = allMap2;
					num2++;
				}
			}
			return array;
		}

		public int GetElementMapsWithAction(string actionName, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return GetElementMapsWithAction(actionId, results);
		}

		public int GetElementMapsWithAction(int actionId, List<ActionElementMap> results)
		{
			return GetElementMapsWithAction(actionId, skipDisabledMaps: false, results);
		}

		public int GetElementMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return GetElementMapsWithAction(actionId, skipDisabledMaps, results);
		}

		public int GetElementMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			return hHAktoEzTjklPLyzcjMCfmqeriO(actionId, skipDisabledMaps, results, false);
		}

		public IEnumerable<ActionElementMap> ElementMapsWithAction(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return ElementMapsWithAction(actionId);
		}

		public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId)
		{
			return ElementMapsWithAction(actionId, skipDisabledMaps: false);
		}

		public IEnumerable<ActionElementMap> ElementMapsWithAction(string actionName, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return ElementMapsWithAction(actionId, skipDisabledMaps);
		}

		public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				yield break;
			}
			foreach (ActionElementMap allMap in AllMaps)
			{
				if (allMap._actionId == actionId && (!skipDisabledMaps || allMap.nZTtfeZBpthDaoAvSONdTABGEaM))
				{
					yield return allMap;
				}
			}
		}

		public virtual ActionElementMap GetFirstElementMapWithAction(int actionId)
		{
			return GetFirstElementMapWithAction(actionId, skipDisabledMaps: false);
		}

		public virtual ActionElementMap GetFirstElementMapWithAction(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return GetFirstElementMapWithAction(actionId);
		}

		public virtual ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			if (actionId < 0)
			{
				return null;
			}
			int num = buttonMapCount;
			for (int i = 0; i < num; i++)
			{
				if (YILJekTondgbpvWXnoVWVPjfRCy[i]._actionId == actionId && (!skipDisabledMaps || YILJekTondgbpvWXnoVWVPjfRCy[i].nZTtfeZBpthDaoAvSONdTABGEaM))
				{
					return YILJekTondgbpvWXnoVWVPjfRCy[i];
				}
			}
			return null;
		}

		public ActionElementMap GetFirstElementMapWithAction(string actionName, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return GetFirstElementMapWithAction(actionId, skipDisabledMaps);
		}

		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
			}
			bjWEjHBROAVpeyUanBwIblyUmUNK bjWEjHBROAVpeyUanBwIblyUmUNK = bjWEjHBROAVpeyUanBwIblyUmUNK.UKQvGkzCJAbJnKtAMsajOiGhqqO(elementTarget);
			IEnumerable<ActionElementMap> result = ElementMapsWithElementTarget(bjWEjHBROAVpeyUanBwIblyUmUNK, skipDisabledMaps);
			bjWEjHBROAVpeyUanBwIblyUmUNK.FiATKxCfZoUkEvsaOqFpRJSJFZtH(bjWEjHBROAVpeyUanBwIblyUmUNK);
			return result;
		}

		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				yield break;
			}
			using TempListPool.TList<ActionElementMap> tList = TempListPool.GetTList<ActionElementMap>();
			List<ActionElementMap> list = tList.list;
			JzTnuZQPeJZpOCUTrCSLHdIycSYG(elementTarget, false, -1, skipDisabledMaps, list, false, out var _);
			foreach (ActionElementMap item in list)
			{
				yield return item;
			}
		}

		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
			}
			bjWEjHBROAVpeyUanBwIblyUmUNK bjWEjHBROAVpeyUanBwIblyUmUNK = bjWEjHBROAVpeyUanBwIblyUmUNK.UKQvGkzCJAbJnKtAMsajOiGhqqO(elementTarget);
			IEnumerable<ActionElementMap> result = ElementMapsWithElementTarget(bjWEjHBROAVpeyUanBwIblyUmUNK, actionId, skipDisabledMaps);
			bjWEjHBROAVpeyUanBwIblyUmUNK.FiATKxCfZoUkEvsaOqFpRJSJFZtH(bjWEjHBROAVpeyUanBwIblyUmUNK);
			return result;
		}

		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return ElementMapsWithElementTarget(elementTarget, actionId, skipDisabledMaps);
		}

		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				yield break;
			}
			using TempListPool.TList<ActionElementMap> tList = TempListPool.GetTList<ActionElementMap>();
			List<ActionElementMap> list = tList.list;
			JzTnuZQPeJZpOCUTrCSLHdIycSYG(elementTarget, true, actionId, skipDisabledMaps, list, false, out var _);
			foreach (ActionElementMap item in list)
			{
				yield return item;
			}
		}

		public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return ElementMapsWithElementTarget(elementTarget, actionId, skipDisabledMaps);
		}

		public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			bjWEjHBROAVpeyUanBwIblyUmUNK bjWEjHBROAVpeyUanBwIblyUmUNK = bjWEjHBROAVpeyUanBwIblyUmUNK.UKQvGkzCJAbJnKtAMsajOiGhqqO(elementTarget);
			ActionElementMap firstElementMapWithElementTarget = GetFirstElementMapWithElementTarget(bjWEjHBROAVpeyUanBwIblyUmUNK, skipDisabledMaps);
			bjWEjHBROAVpeyUanBwIblyUmUNK.FiATKxCfZoUkEvsaOqFpRJSJFZtH(bjWEjHBROAVpeyUanBwIblyUmUNK);
			return firstElementMapWithElementTarget;
		}

		public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			bool flag;
			return VfcfyKNKnGeUcaZTKcbxEoucaoFO(elementTarget, false, -1, skipDisabledMaps, out flag);
		}

		public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			bjWEjHBROAVpeyUanBwIblyUmUNK bjWEjHBROAVpeyUanBwIblyUmUNK = bjWEjHBROAVpeyUanBwIblyUmUNK.UKQvGkzCJAbJnKtAMsajOiGhqqO(elementTarget);
			ActionElementMap firstElementMapWithElementTarget = GetFirstElementMapWithElementTarget(bjWEjHBROAVpeyUanBwIblyUmUNK, actionId, skipDisabledMaps);
			bjWEjHBROAVpeyUanBwIblyUmUNK.FiATKxCfZoUkEvsaOqFpRJSJFZtH(bjWEjHBROAVpeyUanBwIblyUmUNK);
			return firstElementMapWithElementTarget;
		}

		public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return GetFirstElementMapWithElementTarget(elementTarget, actionId, skipDisabledMaps);
		}

		public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			bool flag;
			return VfcfyKNKnGeUcaZTKcbxEoucaoFO(elementTarget, true, actionId, skipDisabledMaps, out flag);
		}

		public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return GetFirstElementMapWithElementTarget(elementTarget, actionId, skipDisabledMaps);
		}

		public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			bjWEjHBROAVpeyUanBwIblyUmUNK bjWEjHBROAVpeyUanBwIblyUmUNK = bjWEjHBROAVpeyUanBwIblyUmUNK.UKQvGkzCJAbJnKtAMsajOiGhqqO(elementTarget);
			int elementMapsWithElementTarget = GetElementMapsWithElementTarget(bjWEjHBROAVpeyUanBwIblyUmUNK, skipDisabledMaps, results);
			bjWEjHBROAVpeyUanBwIblyUmUNK.FiATKxCfZoUkEvsaOqFpRJSJFZtH(bjWEjHBROAVpeyUanBwIblyUmUNK);
			return elementMapsWithElementTarget;
		}

		public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			bool flag;
			return JzTnuZQPeJZpOCUTrCSLHdIycSYG(elementTarget, false, -1, skipDisabledMaps, results, false, out flag);
		}

		public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			bjWEjHBROAVpeyUanBwIblyUmUNK bjWEjHBROAVpeyUanBwIblyUmUNK = bjWEjHBROAVpeyUanBwIblyUmUNK.UKQvGkzCJAbJnKtAMsajOiGhqqO(elementTarget);
			int elementMapsWithElementTarget = GetElementMapsWithElementTarget(bjWEjHBROAVpeyUanBwIblyUmUNK, actionId, skipDisabledMaps, results);
			bjWEjHBROAVpeyUanBwIblyUmUNK.FiATKxCfZoUkEvsaOqFpRJSJFZtH(bjWEjHBROAVpeyUanBwIblyUmUNK);
			return elementMapsWithElementTarget;
		}

		public int GetElementMapsWithElementTarget(ControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return GetElementMapsWithElementTarget(elementTarget, actionId, skipDisabledMaps, results);
		}

		public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			bool flag;
			return JzTnuZQPeJZpOCUTrCSLHdIycSYG(elementTarget, true, actionId, skipDisabledMaps, results, false, out flag);
		}

		public int GetElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return GetElementMapsWithElementTarget(elementTarget, actionId, skipDisabledMaps, results);
		}

		public ActionElementMap GetFirstElementMapMatch(Predicate<ActionElementMap> predicate)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			return XJElERBtNBGdisiZeKGfVQVgXJL(predicate, false);
		}

		internal virtual ActionElementMap XJElERBtNBGdisiZeKGfVQVgXJL(Predicate<ActionElementMap> P_0, bool P_1)
		{
			return KtIOArmQgQTQoieeyKIjKivHWCl(P_0, P_1);
		}

		public int GetElementMapMatches(Predicate<ActionElementMap> predicate, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			return nYxHWYBhzcSPnNGDLPIYfSoccJt(predicate, false, results, false);
		}

		internal virtual int nYxHWYBhzcSPnNGDLPIYfSoccJt(Predicate<ActionElementMap> P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			return cGmqOtRbeAJnMPemGDvrNKqRaZvF(P_0, P_1, P_2, P_3);
		}

		public void ForEachElementMapMatch(Predicate<ActionElementMap> predicate, Action<ActionElementMap> actionToPerform)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return;
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			if (actionToPerform == null)
			{
				throw new ArgumentNullException("actionToPerform");
			}
			int count = rmEZzdVeJPtxyMsETjWuoDiOhqY.Count;
			try
			{
				for (int i = 0; i < count; i++)
				{
					ActionElementMap obj = rmEZzdVeJPtxyMsETjWuoDiOhqY[i];
					if (predicate(obj))
					{
						actionToPerform(obj);
					}
				}
			}
			catch (Exception exception)
			{
				ReInput.HandleCallbackException("ControllerMap.ForEachElementMapMatch", exception);
			}
		}

		public virtual void ClearElementMaps()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return;
			}
			YILJekTondgbpvWXnoVWVPjfRCy.Clear();
			rmEZzdVeJPtxyMsETjWuoDiOhqY.Clear();
		}

		public int SetAllElementMapsEnabled(bool state)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			int num = 0;
			int count = rmEZzdVeJPtxyMsETjWuoDiOhqY.Count;
			for (int i = 0; i < count; i++)
			{
				ActionElementMap actionElementMap = rmEZzdVeJPtxyMsETjWuoDiOhqY[i];
				if (actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM != state)
				{
					actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM = state;
					num++;
				}
			}
			return num;
		}

		public ActionElementMap GetButtonMap(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			if (YILJekTondgbpvWXnoVWVPjfRCy == null || index < 0 || index >= YILJekTondgbpvWXnoVWVPjfRCy.Count)
			{
				return null;
			}
			return YILJekTondgbpvWXnoVWVPjfRCy[index];
		}

		public ActionElementMap[] GetButtonMaps()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.array;
			}
			return ListTools.ToArray(YILJekTondgbpvWXnoVWVPjfRCy);
		}

		public ActionElementMap[] GetButtonMaps(bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.array;
			}
			int count = YILJekTondgbpvWXnoVWVPjfRCy.Count;
			List<ActionElementMap> list = new List<ActionElementMap>(count);
			for (int i = 0; i < count; i++)
			{
				ActionElementMap actionElementMap = YILJekTondgbpvWXnoVWVPjfRCy[i];
				if (!skipDisabledMaps || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM)
				{
					list.Add(actionElementMap);
				}
			}
			return list.ToArray();
		}

		public int GetButtonMaps(bool skipDisabledMaps, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			return OpWksTfOQfoVeqCCYYsKnGmsYRE(skipDisabledMaps, results, false);
		}

		public ActionElementMap[] GetButtonMapsWithAction(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.array;
			}
			InputAction inputAction = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.nYlDpDffCkjRccBgMgyGeVRBCsz(actionName, true);
			if (inputAction == null)
			{
				return EmptyObjects<ActionElementMap>.array;
			}
			return GetButtonMapsWithAction(inputAction.id);
		}

		public ActionElementMap[] GetButtonMapsWithAction(int actionId)
		{
			return GetButtonMapsWithAction(actionId, skipDisabledMaps: false);
		}

		public ActionElementMap[] GetButtonMapsWithAction(string actionName, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.array;
			}
			InputAction inputAction = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.nYlDpDffCkjRccBgMgyGeVRBCsz(actionName, true);
			if (inputAction == null)
			{
				return EmptyObjects<ActionElementMap>.array;
			}
			return GetButtonMapsWithAction(inputAction.id, skipDisabledMaps);
		}

		public ActionElementMap[] GetButtonMapsWithAction(int actionId, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.array;
			}
			int num = buttonMapCount;
			if (num == 0)
			{
				return EmptyObjects<ActionElementMap>.array;
			}
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				ActionElementMap actionElementMap = YILJekTondgbpvWXnoVWVPjfRCy[i];
				if (actionElementMap._actionId == actionId && (!skipDisabledMaps || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM))
				{
					num2++;
				}
			}
			if (num2 == 0)
			{
				return EmptyObjects<ActionElementMap>.array;
			}
			ActionElementMap[] array = new ActionElementMap[num2];
			int num3 = 0;
			for (int j = 0; j < num; j++)
			{
				ActionElementMap actionElementMap2 = YILJekTondgbpvWXnoVWVPjfRCy[j];
				if (actionElementMap2._actionId == actionId && (!skipDisabledMaps || actionElementMap2.nZTtfeZBpthDaoAvSONdTABGEaM))
				{
					array[num3] = actionElementMap2;
					num3++;
				}
			}
			return array;
		}

		public int GetButtonMapsWithAction(string actionName, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			InputAction inputAction = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.nYlDpDffCkjRccBgMgyGeVRBCsz(actionName, true);
			if (inputAction == null)
			{
				ListTools.TryClear(results);
				return 0;
			}
			return GetButtonMapsWithAction(inputAction.id, results);
		}

		public int GetButtonMapsWithAction(int actionId, List<ActionElementMap> results)
		{
			return GetButtonMapsWithAction(actionId, skipDisabledMaps: false, results);
		}

		public int GetButtonMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			InputAction inputAction = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.nYlDpDffCkjRccBgMgyGeVRBCsz(actionName, true);
			if (inputAction == null)
			{
				ListTools.TryClear(results);
				return 0;
			}
			return GetButtonMapsWithAction(inputAction.id, skipDisabledMaps, results);
		}

		public int GetButtonMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			return OkcRCEckXtWYjyMQBguTtVlxtFz(actionId, skipDisabledMaps, results, false);
		}

		public IEnumerable<ActionElementMap> ButtonMapsWithAction(int actionId)
		{
			return ButtonMapsWithAction(actionId, skipDisabledMaps: false);
		}

		public IEnumerable<ActionElementMap> ButtonMapsWithAction(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return ButtonMapsWithAction(actionId);
		}

		public IEnumerable<ActionElementMap> ButtonMapsWithAction(int actionId, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else
			{
				if (actionId < 0)
				{
					yield break;
				}
				IList<ActionElementMap> buttonMaps = ButtonMaps;
				int num = buttonMapCount;
				for (int i = 0; i < num; i++)
				{
					ActionElementMap actionElementMap = buttonMaps[i];
					if (actionElementMap._actionId == actionId && (!skipDisabledMaps || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM))
					{
						yield return actionElementMap;
					}
				}
			}
		}

		public IEnumerable<ActionElementMap> ButtonMapsWithAction(string actionName, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return ButtonMapsWithAction(actionId, skipDisabledMaps);
		}

		public ActionElementMap GetFirstButtonMapWithAction(int actionId)
		{
			return GetFirstButtonMapWithAction(actionId, skipDisabledMaps: false);
		}

		public ActionElementMap GetFirstButtonMapWithAction(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return GetFirstButtonMapWithAction(actionId);
		}

		public ActionElementMap GetFirstButtonMapWithAction(int actionId, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			if (actionId < 0)
			{
				return null;
			}
			IList<ActionElementMap> buttonMaps = ButtonMaps;
			int num = buttonMapCount;
			for (int i = 0; i < num; i++)
			{
				ActionElementMap actionElementMap = buttonMaps[i];
				if (actionElementMap._actionId == actionId && (!skipDisabledMaps || actionElementMap.enabled))
				{
					return actionElementMap;
				}
			}
			return null;
		}

		public ActionElementMap GetFirstButtonMapWithAction(string actionName, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return GetFirstButtonMapWithAction(actionId, skipDisabledMaps);
		}

		public ActionElementMap GetFirstButtonMapMatch(Predicate<ActionElementMap> predicate)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			return KtIOArmQgQTQoieeyKIjKivHWCl(predicate, false);
		}

		internal ActionElementMap KtIOArmQgQTQoieeyKIjKivHWCl(Predicate<ActionElementMap> P_0, bool P_1)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			if (P_0 == null)
			{
				throw new ArgumentNullException("predicate");
			}
			IList<ActionElementMap> buttonMaps = ButtonMaps;
			int num = buttonMapCount;
			try
			{
				for (int i = 0; i < num; i++)
				{
					ActionElementMap actionElementMap = buttonMaps[i];
					if ((!P_1 || actionElementMap.enabled) && P_0(actionElementMap))
					{
						return actionElementMap;
					}
				}
			}
			catch (Exception exception)
			{
				ReInput.HandleCallbackException("ControllerMap.GetFirstButtonMapMatch", exception);
			}
			return null;
		}

		public int GetButtonMapMatches(Predicate<ActionElementMap> predicate, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			return cGmqOtRbeAJnMPemGDvrNKqRaZvF(predicate, false, results, false);
		}

		internal int cGmqOtRbeAJnMPemGDvrNKqRaZvF(Predicate<ActionElementMap> P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException("predicate");
			}
			if (P_2 == null)
			{
				throw new ArgumentNullException("results");
			}
			int num = 0;
			if (!P_3)
			{
				P_2.Clear();
			}
			else
			{
				num = P_2.Count;
			}
			IList<ActionElementMap> buttonMaps = ButtonMaps;
			int num2 = buttonMapCount;
			try
			{
				for (int i = 0; i < num2; i++)
				{
					ActionElementMap actionElementMap = buttonMaps[i];
					if ((!P_1 || actionElementMap.enabled) && P_0(actionElementMap))
					{
						P_2.Add(actionElementMap);
					}
				}
			}
			catch (Exception exception)
			{
				ReInput.HandleCallbackException("ControllerMap.GetButtonMapMatches", exception);
			}
			return P_2.Count - num;
		}

		public void ForEachButtonMapMatch(Predicate<ActionElementMap> predicate, Action<ActionElementMap> actionToPerform)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return;
			}
			if (predicate == null)
			{
				throw new ArgumentNullException("predicate");
			}
			if (actionToPerform == null)
			{
				throw new ArgumentNullException("actionToPerform");
			}
			int count = YILJekTondgbpvWXnoVWVPjfRCy.Count;
			try
			{
				for (int i = 0; i < count; i++)
				{
					ActionElementMap obj = YILJekTondgbpvWXnoVWVPjfRCy[i];
					if (predicate(obj))
					{
						actionToPerform(obj);
					}
				}
			}
			catch (Exception exception)
			{
				ReInput.HandleCallbackException("ControllerMap.GetButtonMapMatches", exception);
			}
		}

		public bool DeleteButtonMapsWithAction(string actionName)
		{
			return DeleteButtonMapsWithAction(ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName));
		}

		public bool DeleteButtonMapsWithAction(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (actionId < 0)
			{
				return false;
			}
			int num = buttonMapCount;
			if (num == 0)
			{
				return false;
			}
			bool result = false;
			for (int num2 = num - 1; num2 >= 0; num2--)
			{
				ActionElementMap actionElementMap = YILJekTondgbpvWXnoVWVPjfRCy[num2];
				if (actionElementMap != null && actionElementMap._actionId == actionId)
				{
					kBNGxEDTlQojrgBCfSmFXzKKvQX(actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri, num2);
					result = true;
				}
			}
			return result;
		}

		public int SetAllButtonMapsEnabled(bool state)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			int num = 0;
			int count = YILJekTondgbpvWXnoVWVPjfRCy.Count;
			for (int i = 0; i < count; i++)
			{
				ActionElementMap actionElementMap = YILJekTondgbpvWXnoVWVPjfRCy[i];
				if (actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM != state)
				{
					actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM = state;
					num++;
				}
			}
			return num;
		}

		public bool DoesElementAssignmentConflict(ControllerMap controllerMap)
		{
			return DoesElementAssignmentConflict(controllerMap, skipDisabledMaps: false);
		}

		public bool DoesElementAssignmentConflict(ActionElementMap actionElementMap)
		{
			return DoesElementAssignmentConflict(actionElementMap, skipDisabledMaps: false);
		}

		public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck)
		{
			return DoesElementAssignmentConflict(conflictCheck, skipDisabledMaps: false);
		}

		public virtual bool DoesElementAssignmentConflict(ControllerMap controllerMap, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (controllerMap == null)
			{
				return false;
			}
			if (skipDisabledMaps && (!_enabled || !controllerMap._enabled))
			{
				return false;
			}
			if (YILJekTondgbpvWXnoVWVPjfRCy == null)
			{
				return false;
			}
			IList<ActionElementMap> buttonMaps = controllerMap.ButtonMaps;
			if (buttonMaps == null)
			{
				return false;
			}
			int num = buttonMapCount;
			int count = buttonMaps.Count;
			for (int i = 0; i < num; i++)
			{
				ActionElementMap actionElementMap = YILJekTondgbpvWXnoVWVPjfRCy[i];
				if (skipDisabledMaps && !actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM)
				{
					continue;
				}
				for (int j = 0; j < count; j++)
				{
					ActionElementMap actionElementMap2 = buttonMaps[j];
					if ((!skipDisabledMaps || actionElementMap2.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap != actionElementMap2 && actionElementMap.CheckForAssignmentConflict(actionElementMap2))
					{
						return true;
					}
				}
			}
			return false;
		}

		public virtual bool DoesElementAssignmentConflict(ActionElementMap actionElementMap, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (actionElementMap == null || YILJekTondgbpvWXnoVWVPjfRCy == null)
			{
				return false;
			}
			if (skipDisabledMaps && (!_enabled || !actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM))
			{
				return false;
			}
			for (int i = 0; i < YILJekTondgbpvWXnoVWVPjfRCy.Count; i++)
			{
				ActionElementMap actionElementMap2 = YILJekTondgbpvWXnoVWVPjfRCy[i];
				if ((!skipDisabledMaps || actionElementMap2.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap2 != actionElementMap && actionElementMap2.CheckForAssignmentConflict(actionElementMap))
				{
					return true;
				}
			}
			return false;
		}

		public virtual bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (YILJekTondgbpvWXnoVWVPjfRCy == null)
			{
				return false;
			}
			if (skipDisabledMaps && !_enabled)
			{
				return false;
			}
			if (conflictCheck.elementAssignmentType != ElementAssignmentType.Button && conflictCheck.elementAssignmentType != ElementAssignmentType.KeyboardKey)
			{
				return false;
			}
			ElementAssignment elementAssignment = conflictCheck.ToElementAssignment();
			for (int i = 0; i < YILJekTondgbpvWXnoVWVPjfRCy.Count; i++)
			{
				ActionElementMap actionElementMap = YILJekTondgbpvWXnoVWVPjfRCy[i];
				if ((!skipDisabledMaps || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri != conflictCheck.elementMapId && actionElementMap.CheckForAssignmentConflict(elementAssignment))
				{
					return true;
				}
			}
			return false;
		}

		public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerMap controllerMap)
		{
			return ElementAssignmentConflicts(controllerMap, skipDisabledMaps: false);
		}

		public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ActionElementMap actionElementMap)
		{
			return ElementAssignmentConflicts(actionElementMap, skipDisabledMaps: false);
		}

		public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
		{
			return ElementAssignmentConflicts(conflictCheck, skipDisabledMaps: false);
		}

		public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else
			{
				if (controllerMap == null || YILJekTondgbpvWXnoVWVPjfRCy == null || (skipDisabledMaps && (!_enabled || !controllerMap._enabled)))
				{
					yield break;
				}
				IList<ActionElementMap> buttonMaps = controllerMap.ButtonMaps;
				if (buttonMaps == null)
				{
					yield break;
				}
				int count = buttonMaps.Count;
				for (int i = 0; i < YILJekTondgbpvWXnoVWVPjfRCy.Count; i++)
				{
					ActionElementMap actionElementMap = YILJekTondgbpvWXnoVWVPjfRCy[i];
					if (skipDisabledMaps && !actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM)
					{
						continue;
					}
					for (int j = 0; j < count; j++)
					{
						ActionElementMap actionElementMap2 = buttonMaps[j];
						if ((!skipDisabledMaps || actionElementMap2.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap.CheckForAssignmentConflict(actionElementMap2))
						{
							yield return new ElementAssignmentConflictInfo(isConflict: true, ReInput.mapping.GetMapCategory(_categoryId).userAssignable, -1, _controllerType, _controllerId, _id, actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri, actionElementMap._actionId, actionElementMap._elementType, actionElementMap._elementIdentifierId, actionElementMap.keyCode, actionElementMap.modifierKeyFlags);
						}
					}
				}
			}
		}

		public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else
			{
				if (actionElementMap == null || YILJekTondgbpvWXnoVWVPjfRCy == null || (skipDisabledMaps && (!_enabled || !actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM)))
				{
					yield break;
				}
				for (int i = 0; i < YILJekTondgbpvWXnoVWVPjfRCy.Count; i++)
				{
					ActionElementMap actionElementMap2 = YILJekTondgbpvWXnoVWVPjfRCy[i];
					if ((!skipDisabledMaps || actionElementMap2.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap2.CheckForAssignmentConflict(actionElementMap))
					{
						yield return new ElementAssignmentConflictInfo(isConflict: true, ReInput.mapping.GetMapCategory(_categoryId).userAssignable, -1, _controllerType, _controllerId, _id, actionElementMap2.BoMCLeauexjolkkRqzIpOQOAGri, actionElementMap2._actionId, actionElementMap2._elementType, actionElementMap2._elementIdentifierId, actionElementMap2.keyCode, actionElementMap2.modifierKeyFlags);
					}
				}
			}
		}

		public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else
			{
				if ((skipDisabledMaps && !_enabled) || YILJekTondgbpvWXnoVWVPjfRCy == null)
				{
					yield break;
				}
				ElementAssignment elementAssignment = conflictCheck.ToElementAssignment();
				for (int i = 0; i < YILJekTondgbpvWXnoVWVPjfRCy.Count; i++)
				{
					ActionElementMap actionElementMap = YILJekTondgbpvWXnoVWVPjfRCy[i];
					if ((!skipDisabledMaps || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri != conflictCheck.elementMapId && actionElementMap.CheckForAssignmentConflict(elementAssignment))
					{
						yield return new ElementAssignmentConflictInfo(isConflict: true, ReInput.mapping.GetMapCategory(_categoryId).userAssignable, -1, _controllerType, _controllerId, _id, actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri, actionElementMap._actionId, actionElementMap._elementType, actionElementMap._elementIdentifierId, actionElementMap.keyCode, actionElementMap.modifierKeyFlags);
					}
				}
			}
		}

		public int RemoveElementAssignmentConflicts(ControllerMap controllerMap)
		{
			return RemoveElementAssignmentConflicts(controllerMap, skipDisabledMaps: false);
		}

		public int RemoveElementAssignmentConflicts(ActionElementMap actionElementMap)
		{
			return RemoveElementAssignmentConflicts(actionElementMap, skipDisabledMaps: false);
		}

		public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
		{
			return RemoveElementAssignmentConflicts(conflictCheck, skipDisabledMaps: false);
		}

		public virtual int RemoveElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			if (controllerMap == null)
			{
				return 0;
			}
			if (skipDisabledMaps && (!_enabled || !controllerMap._enabled))
			{
				return 0;
			}
			int num = 0;
			if (YILJekTondgbpvWXnoVWVPjfRCy == null)
			{
				return num;
			}
			IList<ActionElementMap> yILJekTondgbpvWXnoVWVPjfRCy = controllerMap.YILJekTondgbpvWXnoVWVPjfRCy;
			if (yILJekTondgbpvWXnoVWVPjfRCy == null)
			{
				return num;
			}
			InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(_categoryId);
			if (mapCategory != null && !mapCategory.userAssignable)
			{
				return num;
			}
			_ = buttonMapCount;
			int count = yILJekTondgbpvWXnoVWVPjfRCy.Count;
			for (int num2 = YILJekTondgbpvWXnoVWVPjfRCy.Count - 1; num2 >= 0; num2--)
			{
				ActionElementMap actionElementMap = YILJekTondgbpvWXnoVWVPjfRCy[num2];
				if (!skipDisabledMaps || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM)
				{
					for (int i = 0; i < count; i++)
					{
						if ((!skipDisabledMaps || yILJekTondgbpvWXnoVWVPjfRCy[i].nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap.CheckForAssignmentConflict(yILJekTondgbpvWXnoVWVPjfRCy[i]))
						{
							kBNGxEDTlQojrgBCfSmFXzKKvQX(actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri, num2);
							num++;
							break;
						}
					}
				}
			}
			return num;
		}

		public virtual int RemoveElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			if (actionElementMap == null)
			{
				return 0;
			}
			if (skipDisabledMaps && (!_enabled || !actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM))
			{
				return 0;
			}
			int num = 0;
			InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(_categoryId);
			if (mapCategory == null)
			{
				return num;
			}
			if (!mapCategory.userAssignable)
			{
				return num;
			}
			if (YILJekTondgbpvWXnoVWVPjfRCy == null)
			{
				return num;
			}
			for (int num2 = YILJekTondgbpvWXnoVWVPjfRCy.Count - 1; num2 >= 0; num2--)
			{
				ActionElementMap actionElementMap2 = YILJekTondgbpvWXnoVWVPjfRCy[num2];
				if ((!skipDisabledMaps || actionElementMap2.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap2.CheckForAssignmentConflict(actionElementMap))
				{
					kBNGxEDTlQojrgBCfSmFXzKKvQX(actionElementMap2.BoMCLeauexjolkkRqzIpOQOAGri, num2);
					num++;
				}
			}
			return num;
		}

		public virtual int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			if (skipDisabledMaps && !_enabled)
			{
				return 0;
			}
			if (YILJekTondgbpvWXnoVWVPjfRCy == null)
			{
				return 0;
			}
			if (conflictCheck.elementAssignmentType != ElementAssignmentType.Button && conflictCheck.elementAssignmentType != ElementAssignmentType.KeyboardKey)
			{
				return 0;
			}
			InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(_categoryId);
			if (mapCategory == null)
			{
				return 0;
			}
			if (!mapCategory.userAssignable)
			{
				return 0;
			}
			ElementAssignment elementAssignment = conflictCheck.ToElementAssignment();
			int num = 0;
			for (int num2 = YILJekTondgbpvWXnoVWVPjfRCy.Count - 1; num2 >= 0; num2--)
			{
				ActionElementMap actionElementMap = YILJekTondgbpvWXnoVWVPjfRCy[num2];
				if ((!skipDisabledMaps || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri != conflictCheck.elementMapId && actionElementMap.CheckForAssignmentConflict(elementAssignment))
				{
					kBNGxEDTlQojrgBCfSmFXzKKvQX(actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri, num2);
					num++;
				}
			}
			return num;
		}

		public int DisableElementAssignmentConflicts(ControllerMap controllerMap)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			return mhZadScPRZEsWIyiakthekVNlGBG(controllerMap, false, null, false);
		}

		public int DisableElementAssignmentConflicts(ActionElementMap actionElementMap)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			return mhZadScPRZEsWIyiakthekVNlGBG(actionElementMap, false, null, false);
		}

		public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			return mhZadScPRZEsWIyiakthekVNlGBG(conflictCheck, false, null, false);
		}

		public int DisableElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			return mhZadScPRZEsWIyiakthekVNlGBG(controllerMap, skipDisabledMaps, null, false);
		}

		public int DisableElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			return mhZadScPRZEsWIyiakthekVNlGBG(actionElementMap, skipDisabledMaps, null, false);
		}

		public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			return mhZadScPRZEsWIyiakthekVNlGBG(conflictCheck, skipDisabledMaps, null, false);
		}

		internal virtual int mhZadScPRZEsWIyiakthekVNlGBG(ControllerMap P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			if (P_2 != null && !P_3)
			{
				P_2.Clear();
			}
			if (P_0 == null)
			{
				return 0;
			}
			if (P_1 && (!_enabled || !P_0._enabled))
			{
				return 0;
			}
			int num = 0;
			if (YILJekTondgbpvWXnoVWVPjfRCy == null)
			{
				return num;
			}
			IList<ActionElementMap> yILJekTondgbpvWXnoVWVPjfRCy = P_0.YILJekTondgbpvWXnoVWVPjfRCy;
			if (yILJekTondgbpvWXnoVWVPjfRCy == null)
			{
				return num;
			}
			InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(_categoryId);
			if (mapCategory != null && !mapCategory.userAssignable)
			{
				return num;
			}
			int num2 = buttonMapCount;
			int count = yILJekTondgbpvWXnoVWVPjfRCy.Count;
			for (int i = 0; i < num2; i++)
			{
				ActionElementMap actionElementMap = YILJekTondgbpvWXnoVWVPjfRCy[i];
				if (!actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM)
				{
					continue;
				}
				for (int j = 0; j < count; j++)
				{
					ActionElementMap actionElementMap2 = yILJekTondgbpvWXnoVWVPjfRCy[j];
					if ((!P_1 || actionElementMap2.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap.CheckForAssignmentConflict(actionElementMap2))
					{
						actionElementMap.enabled = false;
						P_2?.Add(actionElementMap);
						num++;
						break;
					}
				}
			}
			return num;
		}

		internal virtual int mhZadScPRZEsWIyiakthekVNlGBG(ActionElementMap P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			if (P_2 != null && !P_3)
			{
				P_2.Clear();
			}
			if (P_0 == null)
			{
				return 0;
			}
			if (P_1 && (!_enabled || !P_0.nZTtfeZBpthDaoAvSONdTABGEaM))
			{
				return 0;
			}
			int num = 0;
			if (P_0.elementIdentifierId < 0)
			{
				return num;
			}
			InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(_categoryId);
			if (mapCategory == null)
			{
				return num;
			}
			if (!mapCategory.userAssignable)
			{
				return num;
			}
			int num2 = buttonMapCount;
			for (int i = 0; i < num2; i++)
			{
				ActionElementMap actionElementMap = YILJekTondgbpvWXnoVWVPjfRCy[i];
				if (actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM && P_0.CheckForAssignmentConflict(actionElementMap))
				{
					actionElementMap.enabled = false;
					P_2?.Add(actionElementMap);
					num++;
				}
			}
			return num;
		}

		internal virtual int mhZadScPRZEsWIyiakthekVNlGBG(ElementAssignmentConflictCheck P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			if (P_2 != null && !P_3)
			{
				P_2.Clear();
			}
			if (P_1 && !_enabled)
			{
				return 0;
			}
			if (YILJekTondgbpvWXnoVWVPjfRCy == null)
			{
				return 0;
			}
			if (P_0.elementAssignmentType != ElementAssignmentType.Button && P_0.elementAssignmentType != ElementAssignmentType.KeyboardKey)
			{
				return 0;
			}
			InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(_categoryId);
			if (mapCategory == null)
			{
				return 0;
			}
			if (!mapCategory.userAssignable)
			{
				return 0;
			}
			ElementAssignment elementAssignment = P_0.ToElementAssignment();
			int num = 0;
			int num2 = buttonMapCount;
			for (int i = 0; i < num2; i++)
			{
				ActionElementMap actionElementMap = YILJekTondgbpvWXnoVWVPjfRCy[i];
				if (actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM && actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri != P_0.elementMapId && actionElementMap.CheckForAssignmentConflict(elementAssignment))
				{
					actionElementMap.enabled = false;
					P_2?.Add(actionElementMap);
					num++;
				}
			}
			return num;
		}

		public int ForEachElementAssignmentConflict(ControllerMap controllerMap, Action<ActionElementMap> actionToPerform)
		{
			return ForEachElementAssignmentConflict(controllerMap, actionToPerform, skipDisabledMaps: false);
		}

		public int ForEachElementAssignmentConflict(ActionElementMap actionElementMap, Action<ActionElementMap> actionToPerform)
		{
			return ForEachElementAssignmentConflict(actionElementMap, actionToPerform, skipDisabledMaps: false);
		}

		public int ForEachElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, Action<ActionElementMap> actionToPerform)
		{
			return ForEachElementAssignmentConflict(conflictCheck, actionToPerform, skipDisabledMaps: false);
		}

		public int ForEachElementAssignmentConflict(ControllerMap controllerMap, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			if (actionToPerform == null)
			{
				throw new ArgumentNullException("actionToPerform");
			}
			if (controllerMap == null)
			{
				return 0;
			}
			if (skipDisabledMaps && (!_enabled || !controllerMap._enabled))
			{
				return 0;
			}
			int num = 0;
			if (rmEZzdVeJPtxyMsETjWuoDiOhqY == null)
			{
				return num;
			}
			IList<ActionElementMap> list = controllerMap.rmEZzdVeJPtxyMsETjWuoDiOhqY;
			if (list == null)
			{
				return num;
			}
			InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(_categoryId);
			if (mapCategory != null && !mapCategory.userAssignable)
			{
				return num;
			}
			int count = list.Count;
			for (int num2 = rmEZzdVeJPtxyMsETjWuoDiOhqY.Count - 1; num2 >= 0; num2--)
			{
				ActionElementMap actionElementMap = rmEZzdVeJPtxyMsETjWuoDiOhqY[num2];
				if (!skipDisabledMaps || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM)
				{
					for (int i = 0; i < count; i++)
					{
						if ((!skipDisabledMaps || list[i].nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap.CheckForAssignmentConflict(list[i]))
						{
							try
							{
								actionToPerform(actionElementMap);
							}
							catch (Exception exception)
							{
								ReInput.HandleCallbackException("ControllerMap.ForEachElementAssignmentConflict", exception);
								return num;
							}
							num++;
							break;
						}
					}
				}
			}
			return num;
		}

		public int ForEachElementAssignmentConflict(ActionElementMap actionElementMap, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			if (actionToPerform == null)
			{
				throw new ArgumentNullException("actionToPerform");
			}
			if (actionElementMap == null)
			{
				return 0;
			}
			if (skipDisabledMaps && (!_enabled || !actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM))
			{
				return 0;
			}
			int num = 0;
			InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(_categoryId);
			if (mapCategory == null)
			{
				return num;
			}
			if (!mapCategory.userAssignable)
			{
				return num;
			}
			if (rmEZzdVeJPtxyMsETjWuoDiOhqY == null)
			{
				return num;
			}
			for (int num2 = rmEZzdVeJPtxyMsETjWuoDiOhqY.Count - 1; num2 >= 0; num2--)
			{
				ActionElementMap actionElementMap2 = rmEZzdVeJPtxyMsETjWuoDiOhqY[num2];
				if ((!skipDisabledMaps || actionElementMap2.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap2.CheckForAssignmentConflict(actionElementMap))
				{
					try
					{
						actionToPerform(actionElementMap2);
					}
					catch (Exception exception)
					{
						ReInput.HandleCallbackException("ControllerMap.ForEachElementAssignmentConflict", exception);
						return num;
					}
					num++;
				}
			}
			return num;
		}

		public int ForEachElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, Action<ActionElementMap> actionToPerform, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			if (actionToPerform == null)
			{
				throw new ArgumentNullException("actionToPerform");
			}
			if (skipDisabledMaps && !_enabled)
			{
				return 0;
			}
			if (rmEZzdVeJPtxyMsETjWuoDiOhqY == null)
			{
				return 0;
			}
			if (conflictCheck.elementAssignmentType != ElementAssignmentType.Button && conflictCheck.elementAssignmentType != ElementAssignmentType.KeyboardKey)
			{
				return 0;
			}
			InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(_categoryId);
			if (mapCategory == null)
			{
				return 0;
			}
			if (!mapCategory.userAssignable)
			{
				return 0;
			}
			ElementAssignment elementAssignment = conflictCheck.ToElementAssignment();
			int num = 0;
			for (int num2 = rmEZzdVeJPtxyMsETjWuoDiOhqY.Count - 1; num2 >= 0; num2--)
			{
				ActionElementMap actionElementMap = rmEZzdVeJPtxyMsETjWuoDiOhqY[num2];
				if ((!skipDisabledMaps || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri != conflictCheck.elementMapId && actionElementMap.CheckForAssignmentConflict(elementAssignment))
				{
					try
					{
						actionToPerform(actionElementMap);
					}
					catch (Exception exception)
					{
						ReInput.HandleCallbackException("ControllerMap.ForEachElementAssignmentConflict", exception);
						return num;
					}
					num++;
				}
			}
			return num;
		}

		public string[] GetButtonNames()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<string>.array;
			}
			int num = buttonMapCount;
			if (num == 0)
			{
				return new string[0];
			}
			string[] array = new string[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = YILJekTondgbpvWXnoVWVPjfRCy[i].elementIdentifierName;
			}
			return array;
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

		public ControllerTemplateMap ToControllerTemplateMap(Guid templateTypeGuid)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			if (controller == null)
			{
				Logger.LogError("The Controller Map is not associated with a Controller. This method can only be used with a Controller Map that is associated with a Controller.", requiredThreadSafety: true);
				return null;
			}
			IControllerTemplate controllerTemplate = controller.GetTemplate(templateTypeGuid) ?? (controller.GetTemplate(templateTypeGuid) as ControllerTemplate);
			if (controllerTemplate == null)
			{
				HardwareJoystickTemplateMap hardwareJoystickTemplateMap = ReInput.wxaUFJksCtJSWyNVQsKBejbBmBq(templateTypeGuid);
				string text = ((hardwareJoystickTemplateMap != null) ? hardwareJoystickTemplateMap.ClassName : templateTypeGuid.ToString());
				Logger.LogError("The Controller does not implement " + text + ".", requiredThreadSafety: true);
				return null;
			}
			return ControllerTemplateMap.OQMGrgFYKbdWJiatgRqdthoAyqOh(controllerTemplate, this);
		}

		public ControllerTemplateMap ToControllerTemplateMap<T>() where T : class
		{
			return ToControllerTemplateMap(typeof(T));
		}

		public ControllerTemplateMap ToControllerTemplateMap(Type templateInterfaceType)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			if ((object)templateInterfaceType == null)
			{
				throw new ArgumentNullException("templateInterfaceType");
			}
			if (controller == null)
			{
				Logger.LogError("The Controller Map is not associated with a Controller. This method can only be used with a Controller Map that is associated with a Controller.", requiredThreadSafety: true);
				return null;
			}
			IControllerTemplate controllerTemplate = controller.GetTemplate(templateInterfaceType) ?? (controller.GetTemplate(templateInterfaceType) as ControllerTemplate);
			if (controllerTemplate == null)
			{
				Logger.LogError("The Controller does not implement " + templateInterfaceType.Name + ".", requiredThreadSafety: true);
				return null;
			}
			return ControllerTemplateMap.OQMGrgFYKbdWJiatgRqdthoAyqOh(controllerTemplate, this);
		}

		private ControllerTemplateMap yncxKarZAGIOIbwBDrINLjJZBoX(IControllerTemplate P_0)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			if (P_0 == null)
			{
				throw new ArgumentNullException("controllerTemplate");
			}
			return ControllerTemplateMap.OQMGrgFYKbdWJiatgRqdthoAyqOh(P_0, this);
		}

		internal virtual bool cOYCFliSLtjGEfDRHMGzdQVtdteA(ActionElementMap P_0)
		{
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(P_0._elementType))
			{
				return false;
			}
			JgxqZpNclObWiLHhocKCZuxUurf(P_0);
			return true;
		}

		internal virtual int ZaUNnOLPcrdqeSVoeoRcJfoOcuPh(List<ActionElementMap> P_0, bool P_1)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException("results");
			}
			int count = P_0.Count;
			int count2 = YILJekTondgbpvWXnoVWVPjfRCy.Count;
			for (int i = 0; i < count2; i++)
			{
				if (!P_1 || YILJekTondgbpvWXnoVWVPjfRCy[i].nZTtfeZBpthDaoAvSONdTABGEaM)
				{
					P_0.Add(YILJekTondgbpvWXnoVWVPjfRCy[i]);
				}
			}
			return P_0.Count - count;
		}

		internal virtual ActionElementMap qDpyvMYMDLWpNKBJMgFRdiaXOOH(int P_0, int P_1, ControllerElementType P_2)
		{
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(P_2))
			{
				return null;
			}
			int num = oXhvPiImtukIdYWWZiEgypBcgXV(P_0, P_1, P_2);
			if (num < 0)
			{
				return null;
			}
			return YILJekTondgbpvWXnoVWVPjfRCy[num];
		}

		internal virtual int PTVivKfqnzQRgshXiLmalPsimLJ(int P_0, List<ActionElementMap> P_1, bool P_2)
		{
			if (P_1 == null)
			{
				throw new ArgumentNullException("results");
			}
			int num = 0;
			if (!P_2)
			{
				P_1.Clear();
			}
			else
			{
				num = P_1.Count;
			}
			if (YILJekTondgbpvWXnoVWVPjfRCy == null)
			{
				return 0;
			}
			int num2 = buttonMapCount;
			for (int i = 0; i < num2; i++)
			{
				if (YILJekTondgbpvWXnoVWVPjfRCy[i]._elementIdentifierId == P_0)
				{
					P_1.Add(YILJekTondgbpvWXnoVWVPjfRCy[i]);
				}
			}
			return P_1.Count - num;
		}

		internal virtual bool RDdGNLBIHpxzHQrHimunxgfPPHub(int P_0, int P_1, ControllerElementType P_2)
		{
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(P_2))
			{
				return false;
			}
			int num = buttonMapCount;
			for (int i = 0; i < num; i++)
			{
				if (YILJekTondgbpvWXnoVWVPjfRCy[i]._elementIdentifierId == P_0 && YILJekTondgbpvWXnoVWVPjfRCy[i]._actionId == P_1)
				{
					return true;
				}
			}
			return false;
		}

		internal virtual int oXhvPiImtukIdYWWZiEgypBcgXV(int P_0, int P_1, ControllerElementType P_2)
		{
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(P_2))
			{
				return -1;
			}
			if (YILJekTondgbpvWXnoVWVPjfRCy == null)
			{
				return -1;
			}
			int num = buttonMapCount;
			for (int i = 0; i < num; i++)
			{
				if (YILJekTondgbpvWXnoVWVPjfRCy[i]._elementIdentifierId == P_0 && YILJekTondgbpvWXnoVWVPjfRCy[i]._actionId == P_1)
				{
					return i;
				}
			}
			return -1;
		}

		internal int czSBdbEZIzmWCEwoUuHHZBpBahg(int P_0)
		{
			if (YILJekTondgbpvWXnoVWVPjfRCy == null)
			{
				return -1;
			}
			int num = buttonMapCount;
			for (int i = 0; i < num; i++)
			{
				if (YILJekTondgbpvWXnoVWVPjfRCy[i].BoMCLeauexjolkkRqzIpOQOAGri == P_0)
				{
					return i;
				}
			}
			return -1;
		}

		internal int OpWksTfOQfoVeqCCYYsKnGmsYRE(bool P_0, List<ActionElementMap> P_1, bool P_2)
		{
			if (P_1 == null)
			{
				throw new ArgumentNullException("results");
			}
			if (!P_2)
			{
				P_1.Clear();
			}
			int num = buttonMapCount;
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				ActionElementMap actionElementMap = YILJekTondgbpvWXnoVWVPjfRCy[i];
				if (!P_0 || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM)
				{
					P_1.Add(actionElementMap);
					num2++;
				}
			}
			return num2;
		}

		internal int OkcRCEckXtWYjyMQBguTtVlxtFz(int P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			if (P_2 == null)
			{
				throw new ArgumentNullException("results");
			}
			if (!P_3)
			{
				P_2.Clear();
			}
			int num = buttonMapCount;
			if (num == 0)
			{
				return 0;
			}
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				ActionElementMap actionElementMap = YILJekTondgbpvWXnoVWVPjfRCy[i];
				if (actionElementMap._actionId == P_0 && (!P_1 || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM))
				{
					P_2.Add(actionElementMap);
					num2++;
				}
			}
			return num2;
		}

		internal virtual int hHAktoEzTjklPLyzcjMCfmqeriO(int P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			if (P_2 == null)
			{
				throw new ArgumentNullException("results");
			}
			if (!P_3)
			{
				P_2.Clear();
			}
			if (P_0 < 0)
			{
				return 0;
			}
			int num = 0;
			int num2 = buttonMapCount;
			for (int i = 0; i < num2; i++)
			{
				ActionElementMap actionElementMap = YILJekTondgbpvWXnoVWVPjfRCy[i];
				if (actionElementMap._actionId == P_0 && (!P_1 || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM))
				{
					P_2.Add(actionElementMap);
					num++;
				}
			}
			return num;
		}

		internal virtual ActionElementMap VfcfyKNKnGeUcaZTKcbxEoucaoFO(IControllerElementTarget P_0, bool P_1, int P_2, bool P_3, out bool P_4)
		{
			P_4 = false;
			if (P_1 && P_2 < 0)
			{
				P_4 = true;
				return null;
			}
			if (!pHMCKeXDIpNmbnxToeYKtyDTRTL(P_0))
			{
				P_4 = true;
				return null;
			}
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(P_0.elementType))
			{
				return null;
			}
			int num = buttonMapCount;
			_ = P_0.elementIdentifierId;
			for (int i = 0; i < num; i++)
			{
				if ((!P_1 || YILJekTondgbpvWXnoVWVPjfRCy[i]._actionId == P_2) && (!P_3 || YILJekTondgbpvWXnoVWVPjfRCy[i].nZTtfeZBpthDaoAvSONdTABGEaM) && YILJekTondgbpvWXnoVWVPjfRCy[i].IsTarget(P_0))
				{
					return YILJekTondgbpvWXnoVWVPjfRCy[i];
				}
			}
			return null;
		}

		internal virtual int JzTnuZQPeJZpOCUTrCSLHdIycSYG(IControllerElementTarget P_0, bool P_1, int P_2, bool P_3, List<ActionElementMap> P_4, bool P_5, out bool P_6)
		{
			if (P_4 == null)
			{
				throw new ArgumentNullException("results");
			}
			int num = 0;
			if (!P_5)
			{
				P_4.Clear();
			}
			P_6 = false;
			if (P_1 && P_2 < 0)
			{
				P_6 = true;
				return num;
			}
			if (!pHMCKeXDIpNmbnxToeYKtyDTRTL(P_0))
			{
				P_6 = true;
				return num;
			}
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(P_0.elementType))
			{
				return num;
			}
			int num2 = buttonMapCount;
			_ = P_0.elementIdentifierId;
			for (int i = 0; i < num2; i++)
			{
				if ((!P_1 || YILJekTondgbpvWXnoVWVPjfRCy[i]._actionId == P_2) && (!P_3 || YILJekTondgbpvWXnoVWVPjfRCy[i].nZTtfeZBpthDaoAvSONdTABGEaM) && YILJekTondgbpvWXnoVWVPjfRCy[i].IsTarget(P_0))
				{
					P_4.Add(YILJekTondgbpvWXnoVWVPjfRCy[i]);
					num++;
				}
			}
			return num;
		}

		internal void UrHUOjyElHcKAPctOzlyFlOLJRR(int P_0, ControllerElementType P_1)
		{
			ActionElementMap elementMap = GetElementMap(P_0);
			if (elementMap != null && elementMap._elementType != P_1)
			{
				elementMap._elementType = P_1;
				if (P_1 == ControllerElementType.Button)
				{
					elementMap._axisRange = AxisRange.Full;
					elementMap._invert = false;
				}
				DeleteElementMap(P_0);
				AMitEmYOawZwzTNfMPWFEkGrtco(elementMap);
			}
		}

		internal virtual bool AMitEmYOawZwzTNfMPWFEkGrtco(ActionElementMap P_0)
		{
			if (P_0 == null)
			{
				return false;
			}
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(P_0._elementType))
			{
				return false;
			}
			YILJekTondgbpvWXnoVWVPjfRCy.Add(P_0);
			lSbAFMHMYMOJTotcLFYtToDjlaDq(P_0);
			return true;
		}

		internal bool pHMCKeXDIpNmbnxToeYKtyDTRTL(IControllerElementTarget P_0)
		{
			if (P_0 == null)
			{
				return false;
			}
			Controller controller = P_0.controller;
			if (controller == null || controller.type != _controllerType || controller.id != _controllerId)
			{
				return false;
			}
			return true;
		}

		internal bool EQNqypfYROzsRQVzLjfDZphqifV(string P_0)
		{
			try
			{
				jzPtspnkZAgrKJfuKATzOhURnEB(SerializedObject.FromXml(GetType(), P_0));
				return true;
			}
			catch (Exception ex)
			{
				Logger.LogError("Error creating  " + GetType().Name + "  from XML. " + ex.Message);
				return false;
			}
		}

		internal bool KiDoHelkINssqKBSYcLiESiAqzn(string P_0)
		{
			try
			{
				jzPtspnkZAgrKJfuKATzOhURnEB(SerializedObject.FromJson(GetType(), P_0));
				return true;
			}
			catch (Exception ex)
			{
				Logger.LogError("Error creating  " + GetType().Name + "  from JSON. " + ex.Message);
				return false;
			}
		}

		internal void lSbAFMHMYMOJTotcLFYtToDjlaDq(ActionElementMap P_0)
		{
			if (P_0 != null)
			{
				rmEZzdVeJPtxyMsETjWuoDiOhqY.Add(P_0);
				rmEZzdVeJPtxyMsETjWuoDiOhqY.Sort(dZciLkdEXGehrFRWUnwXzpJoUzL.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
			}
		}

		internal void bxwBSedWxwfoPPptVOhvKHrgnQKL(int P_0)
		{
			int num = tbDekwNjeIGNNbKWNjSJtcxKoNj(P_0);
			if (num >= 0)
			{
				rmEZzdVeJPtxyMsETjWuoDiOhqY.RemoveAt(num);
			}
		}

		internal void wfZdzOlcgjiGUhXNfevhWBxcQcvD(int P_0, ActionElementMap P_1)
		{
			if (P_1 != null)
			{
				int num = tbDekwNjeIGNNbKWNjSJtcxKoNj(P_0);
				if (num >= 0)
				{
					rmEZzdVeJPtxyMsETjWuoDiOhqY[num] = P_1;
					rmEZzdVeJPtxyMsETjWuoDiOhqY.Sort(dZciLkdEXGehrFRWUnwXzpJoUzL.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
				}
			}
		}

		internal static void VbYTsEAPoQgdcsYwtmTpEeMSVQY(ActionElementMap P_0, int P_1, Pole P_2, int P_3, ControllerElementType P_4, AxisRange P_5, bool P_6)
		{
			P_0.LlCkzvOeJVaCziTDPktzBWuYotAZ();
			P_0._actionId = P_1;
			P_0._elementType = P_4;
			P_0._elementIdentifierId = P_3;
			P_0._axisContribution = P_2;
			P_0._axisRange = P_5;
			if (P_4 == ControllerElementType.Axis)
			{
				P_0._invert = P_6;
			}
		}

		protected void BakeElementMap(ActionElementMap map)
		{
			if (map != null)
			{
				ReInput.controllers.GetController(_controllerType, _controllerId).UTvazqIZLDwOPLfFaGTxhGSydhT(this, map);
			}
		}

		internal virtual bool jzPtspnkZAgrKJfuKATzOhURnEB(SerializedObject P_0)
		{
			bool flag = false;
			_sourceMapId = -1;
			_categoryId = -1;
			_layoutId = -1;
			_name = string.Empty;
			_hardwareGuid = Guid.Empty;
			_enabled = true;
			P_0.TryGetDeserializedValueByRef("sourceMapId", ref _sourceMapId);
			P_0.TryGetDeserializedValueByRef("categoryId", ref _categoryId);
			P_0.TryGetDeserializedValueByRef("layoutId", ref _layoutId);
			P_0.TryGetDeserializedValueByRef("name", ref _name);
			P_0.TryGetDeserializedValueByRef("hardwareGuid", ref _hardwareGuid);
			P_0.TryGetDeserializedValueByRef("enabled", ref _enabled);
			if (!flag)
			{
				ClearElementMaps();
				flag = true;
			}
			SerializedObject value = null;
			if (P_0.TryGetDeserializedValueByRef("buttonMaps", ref value) && value != null)
			{
				for (int i = 0; i < value.count; i++)
				{
					if (value.TryGetDeserializedValue<SerializedObject>(i, out var value2) || value2 == null)
					{
						ActionElementMap actionElementMap = new ActionElementMap();
						actionElementMap.jzPtspnkZAgrKJfuKATzOhURnEB(value2);
						if (ActionElementMap.DELMeXKAfFIGOFYSEfHUJAflYci(actionElementMap))
						{
							JgxqZpNclObWiLHhocKCZuxUurf(actionElementMap);
						}
					}
				}
			}
			return flag;
		}

		internal virtual void tobyAseOeexEQBYeyNriFyhLxKv(SerializedObject P_0)
		{
			if (P_0.xmlInfo == null)
			{
				P_0.xmlInfo = new SerializedObject.XmlInfo();
			}
			P_0.Add("dataVersion", 2, SerializedObject.FieldOptions.ExculdeFromXml);
			P_0.xmlInfo.attributes.Add(new SerializedObject.XmlInfo.kwLxndskJikCtPGLslSPWsTXCTW
			{
				FaRCzmOJYwGVoyOIjhyHpMferPo = "dataVersion",
				foSRcEqSuRsWnadDiKcGnhBewOU = 2.ToString()
			});
			if (object.ReferenceEquals(GetType(), typeof(JoystickMap)))
			{
				Joystick joystick = ReInput.controllers.GetJoystick(_controllerId);
				Guid guid = joystick?.hardwareTypeGuid ?? Guid.Empty;
				string foSRcEqSuRsWnadDiKcGnhBewOU = ((joystick != null) ? SerializationTools.CleanInvalidXmlChars(joystick.hardwareName) : "Unknown");
				P_0.xmlInfo.attributes.Add(new SerializedObject.XmlInfo.kwLxndskJikCtPGLslSPWsTXCTW
				{
					FaRCzmOJYwGVoyOIjhyHpMferPo = "hardwareGuid",
					foSRcEqSuRsWnadDiKcGnhBewOU = guid.ToString()
				});
				P_0.xmlInfo.attributes.Add(new SerializedObject.XmlInfo.kwLxndskJikCtPGLslSPWsTXCTW
				{
					FaRCzmOJYwGVoyOIjhyHpMferPo = "hardwareName",
					foSRcEqSuRsWnadDiKcGnhBewOU = foSRcEqSuRsWnadDiKcGnhBewOU
				});
			}
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
				foSRcEqSuRsWnadDiKcGnhBewOU = string.Format("{0} {1}{2}{3}{4}{5}", "http://guavaman.com/rewired", "http://guavaman.com/schemas/rewired/", "1.1", "/", GetType().Name, ".xsd")
			});
			P_0.Add("sourceMapId", _sourceMapId);
			P_0.Add("categoryId", _categoryId);
			P_0.Add("layoutId", _layoutId);
			P_0.Add("name", _name);
			P_0.Add("hardwareGuid", _hardwareGuid);
			P_0.Add("enabled", _enabled);
			int num = buttonMapCount;
			List<object> list = new List<object>();
			P_0.Add("buttonMaps", list);
			for (int i = 0; i < num; i++)
			{
				if (YILJekTondgbpvWXnoVWVPjfRCy[i] != null)
				{
					list.Add(YILJekTondgbpvWXnoVWVPjfRCy[i].KmsZJAaClfxbOKcqKGgeMqITFsc());
				}
			}
		}

		private bool bVLuZgVxltodTscOsEIfKtFHBdt(ControllerElementType P_0)
		{
			if (P_0 != ControllerElementType.Button)
			{
				return false;
			}
			return true;
		}

		private void kBNGxEDTlQojrgBCfSmFXzKKvQX(int P_0, int P_1)
		{
			bxwBSedWxwfoPPptVOhvKHrgnQKL(P_0);
			if (P_1 >= 0 && P_1 < buttonMapCount)
			{
				YILJekTondgbpvWXnoVWVPjfRCy.RemoveAt(P_1);
			}
		}

		private void JgxqZpNclObWiLHhocKCZuxUurf(ActionElementMap P_0)
		{
			if (P_0 != null)
			{
				YILJekTondgbpvWXnoVWVPjfRCy.Add(P_0);
				lSbAFMHMYMOJTotcLFYtToDjlaDq(P_0);
			}
		}

		private void FRBVmPzIahZZhmLLGCXsfaMSjRN(ActionElementMap P_0, int P_1)
		{
			if (P_0 != null && P_1 >= 0 && P_1 < buttonMapCount)
			{
				wfZdzOlcgjiGUhXNfevhWBxcQcvD(YILJekTondgbpvWXnoVWVPjfRCy[P_1].BoMCLeauexjolkkRqzIpOQOAGri, P_0);
				YILJekTondgbpvWXnoVWVPjfRCy[P_1] = P_0;
			}
		}

		private int tbDekwNjeIGNNbKWNjSJtcxKoNj(int P_0)
		{
			if (rmEZzdVeJPtxyMsETjWuoDiOhqY == null)
			{
				return -1;
			}
			int count = rmEZzdVeJPtxyMsETjWuoDiOhqY.Count;
			for (int i = 0; i < count; i++)
			{
				if (rmEZzdVeJPtxyMsETjWuoDiOhqY[i].BoMCLeauexjolkkRqzIpOQOAGri == P_0)
				{
					return i;
				}
			}
			return -1;
		}

		private SerializedObject KmsZJAaClfxbOKcqKGgeMqITFsc()
		{
			SerializedObject serializedObject = new SerializedObject(GetType(), SerializedObject.ObjectType.Object);
			tobyAseOeexEQBYeyNriFyhLxKv(serializedObject);
			return serializedObject;
		}

		internal static ControllerMap aWlEKFrTmxgBGgRqJDXRHeKwHYg(ControllerType P_0)
		{
			return P_0 switch
			{
				ControllerType.Keyboard => new KeyboardMap(), 
				ControllerType.Mouse => new MouseMap(), 
				ControllerType.Joystick => new JoystickMap(), 
				ControllerType.Custom => new CustomControllerMap(), 
				_ => throw new NotImplementedException(), 
			};
		}

		internal static ControllerMap EOKwQcxsIwIbTLRXRRCTTzrEDPK(Controller P_0, int P_1, int P_2)
		{
			if (P_0 == null)
			{
				return null;
			}
			return P_0.type switch
			{
				ControllerType.Keyboard => KeyboardMap.EOKwQcxsIwIbTLRXRRCTTzrEDPK(P_0.hardwareTypeGuid, P_1, P_2), 
				ControllerType.Mouse => MouseMap.EOKwQcxsIwIbTLRXRRCTTzrEDPK(P_0.hardwareTypeGuid, P_1, P_2), 
				ControllerType.Joystick => JoystickMap.EOKwQcxsIwIbTLRXRRCTTzrEDPK(P_0.hardwareTypeGuid, P_1, P_2), 
				ControllerType.Custom => CustomControllerMap.EOKwQcxsIwIbTLRXRRCTTzrEDPK(P_0.hardwareTypeGuid, ((CustomController)P_0).sourceControllerId, P_1, P_2), 
				_ => throw new NotImplementedException(), 
			};
		}

		public static ControllerMap CreateFromXml(ControllerType controllerType, string xmlString)
		{
			if (string.IsNullOrEmpty(xmlString))
			{
				return null;
			}
			ControllerMap controllerMap = aWlEKFrTmxgBGgRqJDXRHeKwHYg(controllerType);
			try
			{
				controllerMap.EQNqypfYROzsRQVzLjfDZphqifV(xmlString);
				return controllerMap;
			}
			catch
			{
				return null;
			}
		}
	}
}
