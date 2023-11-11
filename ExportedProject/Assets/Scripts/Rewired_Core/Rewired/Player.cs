using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Rewired.Utils;
using Rewired.Utils.Classes;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	public sealed class Player
	{
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public sealed class ControllerHelper
		{
			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public sealed class ConflictCheckingHelper : CodeHelper
			{
				private readonly Player QFlXjfmiJabcsMblLziegHSMCLfJ;

				private readonly ControllerHelper mQXiYotjnToDecfWIRfktslJAMQ;

				private readonly int PivQvdYMhUssuLwaglJVqkqXMSH;

				internal ConflictCheckingHelper(Player player, ControllerHelper parent)
				{
					PivQvdYMhUssuLwaglJVqkqXMSH = ReInput.id;
					QFlXjfmiJabcsMblLziegHSMCLfJ = player;
					mQXiYotjnToDecfWIRfktslJAMQ = parent;
				}

				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap)
				{
					return DoesElementAssignmentConflict(controllerType, controllerId, controllerMap, skipDisabledMaps: false, forceCheckAllCategories: false);
				}

				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps)
				{
					return DoesElementAssignmentConflict(controllerType, controllerId, controllerMap, skipDisabledMaps, forceCheckAllCategories: false);
				}

				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps, bool forceCheckAllCategories)
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
					return controllerType switch
					{
						ControllerType.Joystick => nEhbukTxJoogeoYMPiDFXtMdURf(controllerId, controllerMap as JoystickMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Keyboard => GRBaNcJXMVhcTkXjgxiAmKaPlSn(controllerMap as KeyboardMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Mouse => YKieasQQVrKzfohxaiObfdVbINK(controllerMap as MouseMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Custom => nGGUGsJicNGXFSgERmmfjmFrGIO(controllerId, controllerMap as CustomControllerMap, skipDisabledMaps, forceCheckAllCategories), 
						_ => throw new NotImplementedException(), 
					};
				}

				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap)
				{
					return DoesElementAssignmentConflict(controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps: false, forceCheckAllCategories: false);
				}

				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps)
				{
					return DoesElementAssignmentConflict(controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories: false);
				}

				public bool DoesElementAssignmentConflict(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					if (controllerMap == null || elementMap == null)
					{
						return false;
					}
					return controllerType switch
					{
						ControllerType.Joystick => nEhbukTxJoogeoYMPiDFXtMdURf(controllerId, controllerMap as JoystickMap, elementMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Keyboard => GRBaNcJXMVhcTkXjgxiAmKaPlSn(controllerMap as KeyboardMap, elementMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Mouse => YKieasQQVrKzfohxaiObfdVbINK(controllerMap as MouseMap, elementMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Custom => nGGUGsJicNGXFSgERmmfjmFrGIO(controllerId, controllerMap as CustomControllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories), 
						_ => throw new NotImplementedException(), 
					};
				}

				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck)
				{
					return DoesElementAssignmentConflict(conflictCheck, skipDisabledMaps: false, forceCheckAllCategories: false);
				}

				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
				{
					return DoesElementAssignmentConflict(conflictCheck, skipDisabledMaps, forceCheckAllCategories: false);
				}

				public bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					if (conflictCheck.controllerType == ControllerType.Joystick)
					{
						return nEhbukTxJoogeoYMPiDFXtMdURf(conflictCheck, skipDisabledMaps, forceCheckAllCategories);
					}
					if (conflictCheck.controllerType == ControllerType.Keyboard)
					{
						return GRBaNcJXMVhcTkXjgxiAmKaPlSn(conflictCheck, skipDisabledMaps, forceCheckAllCategories);
					}
					if (conflictCheck.controllerType == ControllerType.Mouse)
					{
						return YKieasQQVrKzfohxaiObfdVbINK(conflictCheck, skipDisabledMaps, forceCheckAllCategories);
					}
					if (conflictCheck.controllerType == ControllerType.Custom)
					{
						return nGGUGsJicNGXFSgERmmfjmFrGIO(conflictCheck, skipDisabledMaps, forceCheckAllCategories);
					}
					throw new NotImplementedException();
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap)
				{
					return ElementAssignmentConflicts(controllerType, controllerId, controllerMap, skipDisabledMaps: false, forceCheckAllCategories: false);
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps)
				{
					return ElementAssignmentConflicts(controllerType, controllerId, controllerMap, skipDisabledMaps, forceCheckAllCategories: false);
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ElementAssignmentConflictInfo>.EmptyReadOnlyIListT;
					}
					if (controllerMap == null)
					{
						return new List<ElementAssignmentConflictInfo>();
					}
					return controllerType switch
					{
						ControllerType.Joystick => ovVhMPUGdKMyeIHUpnYEeSAVoWK(controllerId, controllerMap as JoystickMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Keyboard => ZtwVhrXLSmVwJBLVomdQQKBJiGVJ(controllerMap as KeyboardMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Mouse => yzUxeeiyTvyPpMILyGefFtVWraB(controllerMap as MouseMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Custom => LbCfSwQIwvnTAsieuPticQfySkh(controllerId, controllerMap as CustomControllerMap, skipDisabledMaps, forceCheckAllCategories), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap)
				{
					return ElementAssignmentConflicts(controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps: false, forceCheckAllCategories: false);
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps)
				{
					return ElementAssignmentConflicts(controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories: false);
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ElementAssignmentConflictInfo>.EmptyReadOnlyIListT;
					}
					if (controllerMap == null || elementMap == null)
					{
						return new List<ElementAssignmentConflictInfo>();
					}
					return controllerType switch
					{
						ControllerType.Joystick => ovVhMPUGdKMyeIHUpnYEeSAVoWK(controllerId, controllerMap as JoystickMap, elementMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Keyboard => ZtwVhrXLSmVwJBLVomdQQKBJiGVJ(controllerMap as KeyboardMap, elementMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Mouse => yzUxeeiyTvyPpMILyGefFtVWraB(controllerMap as MouseMap, elementMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Custom => LbCfSwQIwvnTAsieuPticQfySkh(controllerId, controllerMap as CustomControllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
				{
					return ElementAssignmentConflicts(conflictCheck, skipDisabledMaps: false, forceCheckAllCategories: false);
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
				{
					return ElementAssignmentConflicts(conflictCheck, skipDisabledMaps, forceCheckAllCategories: false);
				}

				public IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ElementAssignmentConflictInfo>.EmptyReadOnlyIListT;
					}
					if (conflictCheck.controllerType == ControllerType.Joystick)
					{
						return ovVhMPUGdKMyeIHUpnYEeSAVoWK(conflictCheck, skipDisabledMaps, forceCheckAllCategories);
					}
					if (conflictCheck.controllerType == ControllerType.Keyboard)
					{
						return ZtwVhrXLSmVwJBLVomdQQKBJiGVJ(conflictCheck, skipDisabledMaps, forceCheckAllCategories);
					}
					if (conflictCheck.controllerType == ControllerType.Mouse)
					{
						return yzUxeeiyTvyPpMILyGefFtVWraB(conflictCheck, skipDisabledMaps, forceCheckAllCategories);
					}
					if (conflictCheck.controllerType == ControllerType.Custom)
					{
						return LbCfSwQIwvnTAsieuPticQfySkh(conflictCheck, skipDisabledMaps, forceCheckAllCategories);
					}
					throw new NotImplementedException();
				}

				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap)
				{
					return RemoveElementAssignmentConflicts(controllerType, controllerId, controllerMap, skipRemovedMaps: false, forceCheckAllCategories: false);
				}

				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipRemovedMaps)
				{
					return RemoveElementAssignmentConflicts(controllerType, controllerId, controllerMap, skipRemovedMaps, forceCheckAllCategories: false);
				}

				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipRemovedMaps, bool forceCheckAllCategories)
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
					return controllerType switch
					{
						ControllerType.Joystick => XrBSFaLDuPvaOITiDPJZWXQhLdb(controllerId, controllerMap as JoystickMap, skipRemovedMaps, forceCheckAllCategories), 
						ControllerType.Keyboard => gnWsOLADmvFPsglRVUyXoIdgycDi(controllerMap as KeyboardMap, skipRemovedMaps, forceCheckAllCategories), 
						ControllerType.Mouse => WOuyksrfrZXvkbYZHtnkerIDHyl(controllerMap as MouseMap, skipRemovedMaps, forceCheckAllCategories), 
						ControllerType.Custom => QDRERpSVHOvlOLheWFpyEHUNVUNE(controllerId, controllerMap as CustomControllerMap, skipRemovedMaps, forceCheckAllCategories), 
						_ => throw new NotImplementedException(), 
					};
				}

				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap)
				{
					return RemoveElementAssignmentConflicts(controllerType, controllerId, controllerMap, elementMap, skipRemovedMaps: false, forceCheckAllCategories: false);
				}

				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipRemovedMaps)
				{
					return RemoveElementAssignmentConflicts(controllerType, controllerId, controllerMap, elementMap, skipRemovedMaps, forceCheckAllCategories: false);
				}

				public int RemoveElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipRemovedMaps, bool forceCheckAllCategories)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (controllerMap == null || elementMap == null)
					{
						return 0;
					}
					return controllerType switch
					{
						ControllerType.Joystick => XrBSFaLDuPvaOITiDPJZWXQhLdb(controllerId, controllerMap as JoystickMap, elementMap, skipRemovedMaps, forceCheckAllCategories), 
						ControllerType.Keyboard => gnWsOLADmvFPsglRVUyXoIdgycDi(controllerMap as KeyboardMap, elementMap, skipRemovedMaps, forceCheckAllCategories), 
						ControllerType.Mouse => WOuyksrfrZXvkbYZHtnkerIDHyl(controllerMap as MouseMap, elementMap, skipRemovedMaps, forceCheckAllCategories), 
						ControllerType.Custom => QDRERpSVHOvlOLheWFpyEHUNVUNE(controllerId, controllerMap as CustomControllerMap, elementMap, skipRemovedMaps, forceCheckAllCategories), 
						_ => throw new NotImplementedException(), 
					};
				}

				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
				{
					return RemoveElementAssignmentConflicts(conflictCheck, skipRemovedMaps: false, forceCheckAllCategories: false);
				}

				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipRemovedMaps)
				{
					return RemoveElementAssignmentConflicts(conflictCheck, skipRemovedMaps, forceCheckAllCategories: false);
				}

				public int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipRemovedMaps, bool forceCheckAllCategories)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (conflictCheck.controllerType == ControllerType.Joystick)
					{
						return XrBSFaLDuPvaOITiDPJZWXQhLdb(conflictCheck, skipRemovedMaps, forceCheckAllCategories);
					}
					if (conflictCheck.controllerType == ControllerType.Keyboard)
					{
						return gnWsOLADmvFPsglRVUyXoIdgycDi(conflictCheck, skipRemovedMaps, forceCheckAllCategories);
					}
					if (conflictCheck.controllerType == ControllerType.Mouse)
					{
						return WOuyksrfrZXvkbYZHtnkerIDHyl(conflictCheck, skipRemovedMaps, forceCheckAllCategories);
					}
					if (conflictCheck.controllerType == ControllerType.Custom)
					{
						return QDRERpSVHOvlOLheWFpyEHUNVUNE(conflictCheck, skipRemovedMaps, forceCheckAllCategories);
					}
					throw new NotImplementedException();
				}

				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap)
				{
					return DisableElementAssignmentConflicts(controllerType, controllerId, controllerMap, skipDisabledMaps: false, forceCheckAllCategories: false);
				}

				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps)
				{
					return DisableElementAssignmentConflicts(controllerType, controllerId, controllerMap, skipDisabledMaps, forceCheckAllCategories: false);
				}

				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, bool skipDisabledMaps, bool forceCheckAllCategories)
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
					return controllerType switch
					{
						ControllerType.Joystick => xROTkvKCYEEhqCGQlCygddnTHGp(controllerId, controllerMap as JoystickMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Keyboard => mLWHAWdmtdBqFyWKBGUIqzNNUYI(controllerMap as KeyboardMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Mouse => JEEekeKFReIWkGTEKeDemfveetl(controllerMap as MouseMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Custom => GDcDJxAxhlFNPZOHoLDBFMRxjYIY(controllerId, controllerMap as CustomControllerMap, skipDisabledMaps, forceCheckAllCategories), 
						_ => throw new NotImplementedException(), 
					};
				}

				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap)
				{
					return DisableElementAssignmentConflicts(controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps: false, forceCheckAllCategories: false);
				}

				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps)
				{
					return DisableElementAssignmentConflicts(controllerType, controllerId, controllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories: false);
				}

				public int DisableElementAssignmentConflicts(ControllerType controllerType, int controllerId, ControllerMap controllerMap, ActionElementMap elementMap, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (controllerMap == null || elementMap == null)
					{
						return 0;
					}
					return controllerType switch
					{
						ControllerType.Joystick => xROTkvKCYEEhqCGQlCygddnTHGp(controllerId, controllerMap as JoystickMap, elementMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Keyboard => mLWHAWdmtdBqFyWKBGUIqzNNUYI(controllerMap as KeyboardMap, elementMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Mouse => JEEekeKFReIWkGTEKeDemfveetl(controllerMap as MouseMap, elementMap, skipDisabledMaps, forceCheckAllCategories), 
						ControllerType.Custom => GDcDJxAxhlFNPZOHoLDBFMRxjYIY(controllerId, controllerMap as CustomControllerMap, elementMap, skipDisabledMaps, forceCheckAllCategories), 
						_ => throw new NotImplementedException(), 
					};
				}

				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck)
				{
					return DisableElementAssignmentConflicts(conflictCheck, skipDisabledMaps: false, forceCheckAllCategories: false);
				}

				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
				{
					return DisableElementAssignmentConflicts(conflictCheck, skipDisabledMaps, forceCheckAllCategories: false);
				}

				public int DisableElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps, bool forceCheckAllCategories)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (conflictCheck.controllerType == ControllerType.Joystick)
					{
						return xROTkvKCYEEhqCGQlCygddnTHGp(conflictCheck, skipDisabledMaps, forceCheckAllCategories);
					}
					if (conflictCheck.controllerType == ControllerType.Keyboard)
					{
						return mLWHAWdmtdBqFyWKBGUIqzNNUYI(conflictCheck, skipDisabledMaps, forceCheckAllCategories);
					}
					if (conflictCheck.controllerType == ControllerType.Mouse)
					{
						return JEEekeKFReIWkGTEKeDemfveetl(conflictCheck, skipDisabledMaps, forceCheckAllCategories);
					}
					if (conflictCheck.controllerType == ControllerType.Custom)
					{
						return GDcDJxAxhlFNPZOHoLDBFMRxjYIY(conflictCheck, skipDisabledMaps, forceCheckAllCategories);
					}
					throw new NotImplementedException();
				}

				private bool nEhbukTxJoogeoYMPiDFXtMdURf(int P_0, JoystickMap P_1, bool P_2 = false, bool P_3 = false)
				{
					if (P_0 < 0 || P_1 == null)
					{
						return false;
					}
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						Joystick tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0 && NVhONLTwqzwgrUxLNveEeWsWsCD(ControllerType.Joystick, P_0, P_1, P_2, P_3, mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE))
						{
							return true;
						}
					}
					return false;
				}

				private bool nEhbukTxJoogeoYMPiDFXtMdURf(int P_0, JoystickMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false)
				{
					if (P_0 < 0 || P_2 == null)
					{
						return false;
					}
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						Joystick tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0 && NVhONLTwqzwgrUxLNveEeWsWsCD(ControllerType.Joystick, P_0, P_1, P_2, P_3, P_4, mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE))
						{
							return true;
						}
					}
					return false;
				}

				private bool nEhbukTxJoogeoYMPiDFXtMdURf(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					if (P_0.controllerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return false;
					}
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						Joystick tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0.controllerId && NVhONLTwqzwgrUxLNveEeWsWsCD(P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE))
						{
							return true;
						}
					}
					return false;
				}

				private bool GRBaNcJXMVhcTkXjgxiAmKaPlSn(KeyboardMap P_0, bool P_1 = false, bool P_2 = false)
				{
					return NVhONLTwqzwgrUxLNveEeWsWsCD(ControllerType.Keyboard, 0, P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.keyboardMapSet);
				}

				private bool GRBaNcJXMVhcTkXjgxiAmKaPlSn(KeyboardMap P_0, ActionElementMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return NVhONLTwqzwgrUxLNveEeWsWsCD(ControllerType.Keyboard, 0, P_0, P_1, P_2, P_3, mQXiYotjnToDecfWIRfktslJAMQ.keyboardMapSet);
				}

				private bool GRBaNcJXMVhcTkXjgxiAmKaPlSn(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					if (P_0.elementAssignmentType != ElementAssignmentType.KeyboardKey)
					{
						return false;
					}
					return NVhONLTwqzwgrUxLNveEeWsWsCD(P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.keyboardMapSet);
				}

				private bool YKieasQQVrKzfohxaiObfdVbINK(MouseMap P_0, bool P_1 = false, bool P_2 = false)
				{
					return NVhONLTwqzwgrUxLNveEeWsWsCD(ControllerType.Mouse, 0, P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.mouseMapSet);
				}

				private bool YKieasQQVrKzfohxaiObfdVbINK(MouseMap P_0, ActionElementMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return NVhONLTwqzwgrUxLNveEeWsWsCD(ControllerType.Mouse, 0, P_0, P_1, P_2, P_3, mQXiYotjnToDecfWIRfktslJAMQ.mouseMapSet);
				}

				private bool YKieasQQVrKzfohxaiObfdVbINK(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					if (P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return false;
					}
					return NVhONLTwqzwgrUxLNveEeWsWsCD(P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.mouseMapSet);
				}

				private bool nGGUGsJicNGXFSgERmmfjmFrGIO(int P_0, CustomControllerMap P_1, bool P_2 = false, bool P_3 = false)
				{
					if (P_0 < 0 || P_1 == null)
					{
						return false;
					}
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						CustomController tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0 && NVhONLTwqzwgrUxLNveEeWsWsCD(ControllerType.Custom, P_0, P_1, P_2, P_3, mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE))
						{
							return true;
						}
					}
					return false;
				}

				private bool nGGUGsJicNGXFSgERmmfjmFrGIO(int P_0, CustomControllerMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false)
				{
					if (P_0 < 0 || P_2 == null)
					{
						return false;
					}
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						CustomController tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0 && NVhONLTwqzwgrUxLNveEeWsWsCD(ControllerType.Custom, P_0, P_1, P_2, P_3, P_4, mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE))
						{
							return true;
						}
					}
					return false;
				}

				private bool nGGUGsJicNGXFSgERmmfjmFrGIO(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					if (P_0.controllerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return false;
					}
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						CustomController tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0.controllerId && NVhONLTwqzwgrUxLNveEeWsWsCD(P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE))
						{
							return true;
						}
					}
					return false;
				}

				private IEnumerable<ElementAssignmentConflictInfo> ovVhMPUGdKMyeIHUpnYEeSAVoWK(int P_0, JoystickMap P_1, bool P_2 = false, bool P_3 = false)
				{
					if (P_0 < 0 || P_1 == null)
					{
						yield break;
					}
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						Joystick tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id != P_0)
						{
							continue;
						}
						foreach (ElementAssignmentConflictInfo item in rhtQFSPLAmqArisZfqlWTUYAdlR(ControllerType.Joystick, P_0, P_1, P_2, P_3, mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE))
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ElementAssignmentConflictInfo> ovVhMPUGdKMyeIHUpnYEeSAVoWK(int P_0, JoystickMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false)
				{
					if (P_0 < 0 || P_2 == null)
					{
						yield break;
					}
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						Joystick tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id != P_0)
						{
							continue;
						}
						foreach (ElementAssignmentConflictInfo item in rhtQFSPLAmqArisZfqlWTUYAdlR(ControllerType.Joystick, P_0, P_1, P_2, P_3, P_4, mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE))
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ElementAssignmentConflictInfo> ovVhMPUGdKMyeIHUpnYEeSAVoWK(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					if (P_0.controllerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						yield break;
					}
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						Joystick tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id != P_0.controllerId)
						{
							continue;
						}
						foreach (ElementAssignmentConflictInfo item in rhtQFSPLAmqArisZfqlWTUYAdlR(P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE))
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ElementAssignmentConflictInfo> ZtwVhrXLSmVwJBLVomdQQKBJiGVJ(KeyboardMap P_0, bool P_1 = false, bool P_2 = false)
				{
					return rhtQFSPLAmqArisZfqlWTUYAdlR(ControllerType.Keyboard, 0, P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.keyboardMapSet);
				}

				private IEnumerable<ElementAssignmentConflictInfo> ZtwVhrXLSmVwJBLVomdQQKBJiGVJ(KeyboardMap P_0, ActionElementMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return rhtQFSPLAmqArisZfqlWTUYAdlR(ControllerType.Keyboard, 0, P_0, P_1, P_2, P_3, mQXiYotjnToDecfWIRfktslJAMQ.keyboardMapSet);
				}

				private IEnumerable<ElementAssignmentConflictInfo> ZtwVhrXLSmVwJBLVomdQQKBJiGVJ(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					if (P_0.elementAssignmentType != ElementAssignmentType.KeyboardKey)
					{
						return new List<ElementAssignmentConflictInfo>();
					}
					return rhtQFSPLAmqArisZfqlWTUYAdlR(P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.keyboardMapSet);
				}

				private IEnumerable<ElementAssignmentConflictInfo> yzUxeeiyTvyPpMILyGefFtVWraB(MouseMap P_0, bool P_1 = false, bool P_2 = false)
				{
					return rhtQFSPLAmqArisZfqlWTUYAdlR(ControllerType.Mouse, 0, P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.mouseMapSet);
				}

				private IEnumerable<ElementAssignmentConflictInfo> yzUxeeiyTvyPpMILyGefFtVWraB(MouseMap P_0, ActionElementMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return rhtQFSPLAmqArisZfqlWTUYAdlR(ControllerType.Mouse, 0, P_0, P_1, P_2, P_3, mQXiYotjnToDecfWIRfktslJAMQ.mouseMapSet);
				}

				private IEnumerable<ElementAssignmentConflictInfo> yzUxeeiyTvyPpMILyGefFtVWraB(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					if (P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return new List<ElementAssignmentConflictInfo>();
					}
					return rhtQFSPLAmqArisZfqlWTUYAdlR(P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.mouseMapSet);
				}

				private IEnumerable<ElementAssignmentConflictInfo> LbCfSwQIwvnTAsieuPticQfySkh(int P_0, CustomControllerMap P_1, bool P_2 = false, bool P_3 = false)
				{
					if (P_0 < 0 || P_1 == null)
					{
						yield break;
					}
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						CustomController tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id != P_0)
						{
							continue;
						}
						foreach (ElementAssignmentConflictInfo item in rhtQFSPLAmqArisZfqlWTUYAdlR(ControllerType.Custom, P_0, P_1, P_2, P_3, mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE))
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ElementAssignmentConflictInfo> LbCfSwQIwvnTAsieuPticQfySkh(int P_0, CustomControllerMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false)
				{
					if (P_0 < 0 || P_2 == null)
					{
						yield break;
					}
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						CustomController tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id != P_0)
						{
							continue;
						}
						foreach (ElementAssignmentConflictInfo item in rhtQFSPLAmqArisZfqlWTUYAdlR(ControllerType.Custom, P_0, P_1, P_2, P_3, P_4, mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE))
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ElementAssignmentConflictInfo> LbCfSwQIwvnTAsieuPticQfySkh(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					if (P_0.controllerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						yield break;
					}
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						CustomController tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id != P_0.controllerId)
						{
							continue;
						}
						foreach (ElementAssignmentConflictInfo item in rhtQFSPLAmqArisZfqlWTUYAdlR(P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE))
						{
							yield return item;
						}
					}
				}

				private int XrBSFaLDuPvaOITiDPJZWXQhLdb(int P_0, JoystickMap P_1, bool P_2 = false, bool P_3 = false)
				{
					if (P_0 < 0 || P_1 == null)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						Joystick tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0)
						{
							num += scrZnPABZwCkofDCliWxbWxwTxN(ControllerType.Joystick, P_0, P_1, P_2, P_3, mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE);
						}
					}
					return num;
				}

				private int XrBSFaLDuPvaOITiDPJZWXQhLdb(int P_0, JoystickMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false)
				{
					if (P_0 < 0 || P_2 == null)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						Joystick tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0)
						{
							num += scrZnPABZwCkofDCliWxbWxwTxN(ControllerType.Joystick, P_0, P_1, P_2, P_3, P_4, mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE);
						}
					}
					return num;
				}

				private int XrBSFaLDuPvaOITiDPJZWXQhLdb(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					if (P_0.controllerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						Joystick tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0.controllerId)
						{
							num += scrZnPABZwCkofDCliWxbWxwTxN(P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE);
						}
					}
					return num;
				}

				private int gnWsOLADmvFPsglRVUyXoIdgycDi(KeyboardMap P_0, bool P_1 = false, bool P_2 = false)
				{
					return scrZnPABZwCkofDCliWxbWxwTxN(ControllerType.Keyboard, 0, P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.keyboardMapSet);
				}

				private int gnWsOLADmvFPsglRVUyXoIdgycDi(KeyboardMap P_0, ActionElementMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return scrZnPABZwCkofDCliWxbWxwTxN(ControllerType.Keyboard, 0, P_0, P_1, P_2, P_3, mQXiYotjnToDecfWIRfktslJAMQ.keyboardMapSet);
				}

				private int gnWsOLADmvFPsglRVUyXoIdgycDi(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					if (P_0.elementAssignmentType != ElementAssignmentType.KeyboardKey)
					{
						return 0;
					}
					return scrZnPABZwCkofDCliWxbWxwTxN(P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.keyboardMapSet);
				}

				private int WOuyksrfrZXvkbYZHtnkerIDHyl(MouseMap P_0, bool P_1 = false, bool P_2 = false)
				{
					return scrZnPABZwCkofDCliWxbWxwTxN(ControllerType.Mouse, 0, P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.mouseMapSet);
				}

				private int WOuyksrfrZXvkbYZHtnkerIDHyl(MouseMap P_0, ActionElementMap P_1, bool P_2 = false, bool P_3 = false)
				{
					return scrZnPABZwCkofDCliWxbWxwTxN(ControllerType.Mouse, 0, P_0, P_1, P_2, P_3, mQXiYotjnToDecfWIRfktslJAMQ.mouseMapSet);
				}

				private int WOuyksrfrZXvkbYZHtnkerIDHyl(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					if (P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return 0;
					}
					return scrZnPABZwCkofDCliWxbWxwTxN(P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.mouseMapSet);
				}

				private int QDRERpSVHOvlOLheWFpyEHUNVUNE(int P_0, CustomControllerMap P_1, bool P_2 = false, bool P_3 = false)
				{
					if (P_0 < 0 || P_1 == null)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						CustomController tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0)
						{
							num += scrZnPABZwCkofDCliWxbWxwTxN(ControllerType.Custom, P_0, P_1, P_2, P_3, mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE);
						}
					}
					return num;
				}

				private int QDRERpSVHOvlOLheWFpyEHUNVUNE(int P_0, CustomControllerMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false)
				{
					if (P_0 < 0 || P_2 == null)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						CustomController tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0)
						{
							num += scrZnPABZwCkofDCliWxbWxwTxN(ControllerType.Custom, P_0, P_1, P_2, P_3, P_4, mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE);
						}
					}
					return num;
				}

				private int QDRERpSVHOvlOLheWFpyEHUNVUNE(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false)
				{
					if (P_0.controllerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						CustomController tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0.controllerId)
						{
							num += scrZnPABZwCkofDCliWxbWxwTxN(P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE);
						}
					}
					return num;
				}

				private int xROTkvKCYEEhqCGQlCygddnTHGp(int P_0, JoystickMap P_1, bool P_2 = false, bool P_3 = false, List<ActionElementMap> P_4 = null)
				{
					if (P_0 < 0 || P_1 == null)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						Joystick tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0)
						{
							num += mhZadScPRZEsWIyiakthekVNlGBG(ControllerType.Joystick, P_0, P_1, P_2, P_3, mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE, P_4);
						}
					}
					return num;
				}

				private int xROTkvKCYEEhqCGQlCygddnTHGp(int P_0, JoystickMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, List<ActionElementMap> P_5 = null)
				{
					if (P_0 < 0 || P_2 == null)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						Joystick tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0)
						{
							num += mhZadScPRZEsWIyiakthekVNlGBG(ControllerType.Joystick, P_0, P_1, P_2, P_3, P_4, mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE, P_5);
						}
					}
					return num;
				}

				private int xROTkvKCYEEhqCGQlCygddnTHGp(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, List<ActionElementMap> P_3 = null)
				{
					if (P_0.controllerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						Joystick tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0.controllerId)
						{
							num += mhZadScPRZEsWIyiakthekVNlGBG(P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE, P_3);
						}
					}
					return num;
				}

				private int mLWHAWdmtdBqFyWKBGUIqzNNUYI(KeyboardMap P_0, bool P_1 = false, bool P_2 = false, List<ActionElementMap> P_3 = null)
				{
					return mhZadScPRZEsWIyiakthekVNlGBG(ControllerType.Keyboard, 0, P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.keyboardMapSet, P_3);
				}

				private int mLWHAWdmtdBqFyWKBGUIqzNNUYI(KeyboardMap P_0, ActionElementMap P_1, bool P_2 = false, bool P_3 = false, List<ActionElementMap> P_4 = null)
				{
					return mhZadScPRZEsWIyiakthekVNlGBG(ControllerType.Keyboard, 0, P_0, P_1, P_2, P_3, mQXiYotjnToDecfWIRfktslJAMQ.keyboardMapSet, P_4);
				}

				private int mLWHAWdmtdBqFyWKBGUIqzNNUYI(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, List<ActionElementMap> P_3 = null)
				{
					if (P_0.elementAssignmentType != ElementAssignmentType.KeyboardKey)
					{
						return 0;
					}
					return mhZadScPRZEsWIyiakthekVNlGBG(P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.keyboardMapSet, P_3);
				}

				private int JEEekeKFReIWkGTEKeDemfveetl(MouseMap P_0, bool P_1 = false, bool P_2 = false, List<ActionElementMap> P_3 = null)
				{
					return mhZadScPRZEsWIyiakthekVNlGBG(ControllerType.Mouse, 0, P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.mouseMapSet, P_3);
				}

				private int JEEekeKFReIWkGTEKeDemfveetl(MouseMap P_0, ActionElementMap P_1, bool P_2 = false, bool P_3 = false, List<ActionElementMap> P_4 = null)
				{
					return mhZadScPRZEsWIyiakthekVNlGBG(ControllerType.Mouse, 0, P_0, P_1, P_2, P_3, mQXiYotjnToDecfWIRfktslJAMQ.mouseMapSet, P_4);
				}

				private int JEEekeKFReIWkGTEKeDemfveetl(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, List<ActionElementMap> P_3 = null)
				{
					if (P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return 0;
					}
					return mhZadScPRZEsWIyiakthekVNlGBG(P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.mouseMapSet, P_3);
				}

				private int GDcDJxAxhlFNPZOHoLDBFMRxjYIY(int P_0, CustomControllerMap P_1, bool P_2 = false, bool P_3 = false, List<ActionElementMap> P_4 = null)
				{
					if (P_0 < 0 || P_1 == null)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						CustomController tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0)
						{
							num += mhZadScPRZEsWIyiakthekVNlGBG(ControllerType.Custom, P_0, P_1, P_2, P_3, mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE, P_4);
						}
					}
					return num;
				}

				private int GDcDJxAxhlFNPZOHoLDBFMRxjYIY(int P_0, CustomControllerMap P_1, ActionElementMap P_2, bool P_3 = false, bool P_4 = false, List<ActionElementMap> P_5 = null)
				{
					if (P_0 < 0 || P_2 == null)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						CustomController tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0)
						{
							num += mhZadScPRZEsWIyiakthekVNlGBG(ControllerType.Custom, P_0, P_1, P_2, P_3, P_4, mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE, P_5);
						}
					}
					return num;
				}

				private int GDcDJxAxhlFNPZOHoLDBFMRxjYIY(ElementAssignmentConflictCheck P_0, bool P_1 = false, bool P_2 = false, List<ActionElementMap> P_3 = null)
				{
					if (P_0.controllerId < 0 || P_0.elementAssignmentType == ElementAssignmentType.KeyboardKey)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						CustomController tWofsWdWcZrFDlgktqaiXknQuRD = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						if (tWofsWdWcZrFDlgktqaiXknQuRD.id == P_0.controllerId)
						{
							num += mhZadScPRZEsWIyiakthekVNlGBG(P_0, P_1, P_2, mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE, P_3);
						}
					}
					return num;
				}

				private bool NVhONLTwqzwgrUxLNveEeWsWsCD<T>(ControllerType P_0, int P_1, T P_2, bool P_3, bool P_4, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<T> P_5) where T : ControllerMap
				{
					if (P_5 == null || P_2 == null)
					{
						return false;
					}
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(P_2.categoryId);
					if (mapCategory == null)
					{
						return false;
					}
					for (int i = 0; i < P_5.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ControllerMap controllerMap = P_5.get_Item(i);
						if ((!P_3 || controllerMap.enabled) && (P_4 || !uygezaYnIQRuCPqtkaIeffChHWmG(mapCategory, controllerMap)) && controllerMap.DoesElementAssignmentConflict(P_2, P_3))
						{
							return true;
						}
					}
					return false;
				}

				private bool NVhONLTwqzwgrUxLNveEeWsWsCD<T>(ControllerType P_0, int P_1, T P_2, ActionElementMap P_3, bool P_4, bool P_5, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<T> P_6) where T : ControllerMap
				{
					if (P_6 == null || P_3 == null)
					{
						return false;
					}
					InputMapCategory inputMapCategory = ((P_2 != null) ? ReInput.mapping.GetMapCategory(P_2.categoryId) : null);
					for (int i = 0; i < P_6.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ControllerMap controllerMap = P_6.get_Item(i);
						if ((!P_4 || controllerMap.enabled) && (P_5 || !uygezaYnIQRuCPqtkaIeffChHWmG(inputMapCategory, controllerMap)) && controllerMap.DoesElementAssignmentConflict(P_3, P_4))
						{
							return true;
						}
					}
					return false;
				}

				private bool NVhONLTwqzwgrUxLNveEeWsWsCD<T>(ElementAssignmentConflictCheck P_0, bool P_1, bool P_2, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<T> P_3) where T : ControllerMap
				{
					if (P_3 == null)
					{
						return false;
					}
					Player player = ReInput.players.GetPlayer(P_0.playerId);
					if (player == null)
					{
						return false;
					}
					ControllerMap map = player.controllers.maps.GetMap(P_0.controllerType, P_0.controllerId, P_0.controllerMapId);
					InputMapCategory inputMapCategory = ((map != null) ? ReInput.mapping.GetMapCategory(map.categoryId) : ReInput.mapping.GetMapCategory(P_0.controllerMapCategoryId));
					if (inputMapCategory == null)
					{
						return false;
					}
					for (int i = 0; i < P_3.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ControllerMap controllerMap = P_3.get_Item(i);
						if ((!P_1 || controllerMap.enabled) && (P_2 || !uygezaYnIQRuCPqtkaIeffChHWmG(inputMapCategory, controllerMap)) && controllerMap.DoesElementAssignmentConflict(P_0, P_1))
						{
							return true;
						}
					}
					return false;
				}

				private IEnumerable<ElementAssignmentConflictInfo> rhtQFSPLAmqArisZfqlWTUYAdlR<T>(ControllerType P_0, int P_1, T P_2, bool P_3, bool P_4, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<T> P_5) where T : ControllerMap
				{
					if (P_5 == null || P_2 == null)
					{
						yield break;
					}
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(P_2.categoryId);
					if (mapCategory == null)
					{
						yield break;
					}
					for (int i = 0; i < P_5.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ControllerMap controllerMap = P_5.get_Item(i);
						if ((P_3 && !controllerMap.enabled) || (!P_4 && uygezaYnIQRuCPqtkaIeffChHWmG(mapCategory, controllerMap)))
						{
							continue;
						}
						foreach (ElementAssignmentConflictInfo item in controllerMap.ElementAssignmentConflicts(P_2, P_3))
						{
							yield return new ElementAssignmentConflictInfo(item)
							{
								playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri,
								controllerType = P_0,
								controllerId = P_1
							};
						}
					}
				}

				private IEnumerable<ElementAssignmentConflictInfo> rhtQFSPLAmqArisZfqlWTUYAdlR<T>(ControllerType P_0, int P_1, T P_2, ActionElementMap P_3, bool P_4, bool P_5, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<T> P_6) where T : ControllerMap
				{
					if (P_6 == null || P_3 == null)
					{
						yield break;
					}
					InputMapCategory inputMapCategory = ((P_2 != null) ? ReInput.mapping.GetMapCategory(P_2.categoryId) : null);
					for (int i = 0; i < P_6.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ControllerMap controllerMap = P_6.get_Item(i);
						if ((P_4 && !controllerMap.enabled) || (!P_5 && uygezaYnIQRuCPqtkaIeffChHWmG(inputMapCategory, controllerMap)))
						{
							continue;
						}
						foreach (ElementAssignmentConflictInfo item in controllerMap.ElementAssignmentConflicts(P_3, P_4))
						{
							yield return new ElementAssignmentConflictInfo(item)
							{
								playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri,
								controllerType = P_0,
								controllerId = P_1
							};
						}
					}
				}

				private IEnumerable<ElementAssignmentConflictInfo> rhtQFSPLAmqArisZfqlWTUYAdlR<T>(ElementAssignmentConflictCheck P_0, bool P_1, bool P_2, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<T> P_3) where T : ControllerMap
				{
					if (P_3 == null)
					{
						yield break;
					}
					Player player = ReInput.players.GetPlayer(P_0.playerId);
					if (player == null)
					{
						yield break;
					}
					ControllerMap map = player.controllers.maps.GetMap(P_0.controllerType, P_0.controllerId, P_0.controllerMapId);
					InputMapCategory inputMapCategory = ((map != null) ? ReInput.mapping.GetMapCategory(map.categoryId) : ReInput.mapping.GetMapCategory(P_0.controllerMapCategoryId));
					if (inputMapCategory == null)
					{
						yield break;
					}
					for (int i = 0; i < P_3.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ControllerMap controllerMap = P_3.get_Item(i);
						if ((P_1 && !controllerMap.enabled) || (!P_2 && uygezaYnIQRuCPqtkaIeffChHWmG(inputMapCategory, controllerMap)))
						{
							continue;
						}
						foreach (ElementAssignmentConflictInfo item in controllerMap.ElementAssignmentConflicts(P_0, P_1))
						{
							yield return new ElementAssignmentConflictInfo(item)
							{
								playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri,
								controllerType = P_0.controllerType,
								controllerId = P_0.controllerId
							};
						}
					}
				}

				private int scrZnPABZwCkofDCliWxbWxwTxN<T>(ControllerType P_0, int P_1, T P_2, bool P_3, bool P_4, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<T> P_5) where T : ControllerMap
				{
					if (P_5 == null || P_2 == null)
					{
						return 0;
					}
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(P_2.categoryId);
					if (mapCategory == null)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < P_5.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ControllerMap controllerMap = P_5.get_Item(i);
						if ((!P_3 || controllerMap.enabled) && (P_4 || !uygezaYnIQRuCPqtkaIeffChHWmG(mapCategory, controllerMap)))
						{
							num += controllerMap.RemoveElementAssignmentConflicts(P_2, P_3);
						}
					}
					return num;
				}

				private int scrZnPABZwCkofDCliWxbWxwTxN<T>(ControllerType P_0, int P_1, T P_2, ActionElementMap P_3, bool P_4, bool P_5, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<T> P_6) where T : ControllerMap
				{
					if (P_6 == null || P_3 == null)
					{
						return 0;
					}
					InputMapCategory inputMapCategory = ((P_2 != null) ? ReInput.mapping.GetMapCategory(P_2.categoryId) : null);
					int num = 0;
					for (int i = 0; i < P_6.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ControllerMap controllerMap = P_6.get_Item(i);
						if ((!P_4 || controllerMap.enabled) && (P_5 || !uygezaYnIQRuCPqtkaIeffChHWmG(inputMapCategory, controllerMap)))
						{
							num += controllerMap.RemoveElementAssignmentConflicts(P_3, P_4);
						}
					}
					return num;
				}

				private int scrZnPABZwCkofDCliWxbWxwTxN<T>(ElementAssignmentConflictCheck P_0, bool P_1, bool P_2, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<T> P_3) where T : ControllerMap
				{
					if (P_3 == null)
					{
						return 0;
					}
					Player player = ReInput.players.GetPlayer(P_0.playerId);
					if (player == null)
					{
						return 0;
					}
					ControllerMap map = player.controllers.maps.GetMap(P_0.controllerType, P_0.controllerId, P_0.controllerMapId);
					InputMapCategory inputMapCategory = ((map != null) ? ReInput.mapping.GetMapCategory(map.categoryId) : ReInput.mapping.GetMapCategory(P_0.controllerMapCategoryId));
					if (inputMapCategory == null)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < P_3.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ControllerMap controllerMap = P_3.get_Item(i);
						if ((!P_1 || controllerMap.enabled) && (P_2 || !uygezaYnIQRuCPqtkaIeffChHWmG(inputMapCategory, controllerMap)))
						{
							num += controllerMap.RemoveElementAssignmentConflicts(P_0, P_1);
						}
					}
					return num;
				}

				private int mhZadScPRZEsWIyiakthekVNlGBG<T>(ControllerType P_0, int P_1, T P_2, bool P_3, bool P_4, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<T> P_5, List<ActionElementMap> P_6 = null) where T : ControllerMap
				{
					P_6?.Clear();
					if (P_5 == null || P_2 == null)
					{
						return 0;
					}
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(P_2.categoryId);
					if (mapCategory == null)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < P_5.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ControllerMap controllerMap = P_5.get_Item(i);
						if ((!P_3 || controllerMap.enabled) && (P_4 || !uygezaYnIQRuCPqtkaIeffChHWmG(mapCategory, controllerMap)))
						{
							num += controllerMap.mhZadScPRZEsWIyiakthekVNlGBG(P_2, P_3, P_6, true);
						}
					}
					return num;
				}

				private int mhZadScPRZEsWIyiakthekVNlGBG<T>(ControllerType P_0, int P_1, T P_2, ActionElementMap P_3, bool P_4, bool P_5, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<T> P_6, List<ActionElementMap> P_7 = null) where T : ControllerMap
				{
					P_7?.Clear();
					if (P_6 == null || P_3 == null)
					{
						return 0;
					}
					InputMapCategory inputMapCategory = ((P_2 != null) ? ReInput.mapping.GetMapCategory(P_2.categoryId) : null);
					int num = 0;
					for (int i = 0; i < P_6.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ControllerMap controllerMap = P_6.get_Item(i);
						if ((!P_4 || controllerMap.enabled) && (P_5 || !uygezaYnIQRuCPqtkaIeffChHWmG(inputMapCategory, controllerMap)))
						{
							num += controllerMap.mhZadScPRZEsWIyiakthekVNlGBG(P_3, P_4, P_7, true);
						}
					}
					return num;
				}

				private int mhZadScPRZEsWIyiakthekVNlGBG<T>(ElementAssignmentConflictCheck P_0, bool P_1, bool P_2, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<T> P_3, List<ActionElementMap> P_4 = null) where T : ControllerMap
				{
					P_4?.Clear();
					if (P_3 == null)
					{
						return 0;
					}
					Player player = ReInput.players.GetPlayer(P_0.playerId);
					if (player == null)
					{
						return 0;
					}
					ControllerMap map = player.controllers.maps.GetMap(P_0.controllerType, P_0.controllerId, P_0.controllerMapId);
					InputMapCategory inputMapCategory = ((map != null) ? ReInput.mapping.GetMapCategory(map.categoryId) : ReInput.mapping.GetMapCategory(P_0.controllerMapCategoryId));
					if (inputMapCategory == null)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < P_3.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ControllerMap controllerMap = P_3.get_Item(i);
						if ((!P_1 || controllerMap.enabled) && (P_2 || !uygezaYnIQRuCPqtkaIeffChHWmG(inputMapCategory, controllerMap)))
						{
							num += controllerMap.mhZadScPRZEsWIyiakthekVNlGBG(P_0, P_1, P_4, true);
						}
					}
					return num;
				}

				private bool uygezaYnIQRuCPqtkaIeffChHWmG(InputMapCategory P_0, ControllerMap P_1)
				{
					if (P_0 == null || P_1 == null)
					{
						return false;
					}
					if (P_0.checkConflictsWithAllCategories)
					{
						return false;
					}
					IList<int> checkConflictsCategoryIds = P_0.checkConflictsCategoryIds;
					if (checkConflictsCategoryIds == null)
					{
						return true;
					}
					for (int i = 0; i < checkConflictsCategoryIds.Count; i++)
					{
						if (checkConflictsCategoryIds[i] == P_1.categoryId)
						{
							return false;
						}
					}
					return true;
				}
			}

			[DefaultMember("Item")]
			internal interface UatpsZKPeFXZcGHRylaqbbrOzNO
			{
				NIDNlJlEVxIbcsEQKbbgfFZhJwDB mFldAkWEWmHykRxiejPmGewpCka { get; }

				ControllerType kEHmRBonufPaXwWSSWlSciOdvWy { get; }

				int ioXgUGjpFGeVuGnqwbPHBeKgnSzF { get; }

				bool oQFygjrDaMtXNUGnYpOhqPuoBesB(Controller P_0);

				bool oQFygjrDaMtXNUGnYpOhqPuoBesB(int P_0);

				void trkLxqDkOLvKrmFNndzuxOPolzd(int P_0);

				void trkLxqDkOLvKrmFNndzuxOPolzd(Controller P_0);

				void OtHEMvEtwLDLiaSXftVcvELMffBm(int P_0);

				Controller RAcjlNtCncziVZzKMoHKTIJjxln(int P_0);

				Controller zMVBLXbZSXJvHEqgBWiFdbaslwo(string P_0);

				int eaOrStrSOuOlEEMmganiuTHlvbL(Controller P_0);

				int eaOrStrSOuOlEEMmganiuTHlvbL(int P_0);

				int oYrUpAXrOvAasGoXnJjqlinzpGTA(string P_0);

				void LlCkzvOeJVaCziTDPktzBWuYotAZ();

				NIDNlJlEVxIbcsEQKbbgfFZhJwDB UHzLoQtWuAoHLAFsVljNrYZrrEC(int P_0);

				NIDNlJlEVxIbcsEQKbbgfFZhJwDB UHzLoQtWuAoHLAFsVljNrYZrrEC(Controller P_0);

				void IZbaudhWyBbPeJpvcIZQLOAuOFCc(NIDNlJlEVxIbcsEQKbbgfFZhJwDB P_0);
			}

			internal interface NIDNlJlEVxIbcsEQKbbgfFZhJwDB
			{
				SXQDlPgGRIYIShDiTzLBebiUKvNw JYKAxzbcwrkvXFkdyALvVdvpDkeE { get; }

				Controller TWofsWdWcZrFDlgktqaiXknQuRD { get; }

				double uTRYjniBIJOmiFWRrBPmOajohcO { get; }
			}

			[DefaultMember("Item")]
			internal sealed class IcESaAjemNGWngcrzWaBSsruFXF<TController, TMap> : UatpsZKPeFXZcGHRylaqbbrOzNO where TController : Controller where TMap : ControllerMap
			{
				public class eQaARQwlcakzPaJCLRZmbjzCHZE : NIDNlJlEVxIbcsEQKbbgfFZhJwDB
				{
					public TController TWofsWdWcZrFDlgktqaiXknQuRD;

					public global::gHFgzSPsLtKjGAtobRtDQKtpUvu<TMap> JYKAxzbcwrkvXFkdyALvVdvpDkeE;

					public double uTRYjniBIJOmiFWRrBPmOajohcO;

					Controller NIDNlJlEVxIbcsEQKbbgfFZhJwDB.daogIYXQDvMAZQSUAJBuOjXDfDV => TWofsWdWcZrFDlgktqaiXknQuRD;

					SXQDlPgGRIYIShDiTzLBebiUKvNw NIDNlJlEVxIbcsEQKbbgfFZhJwDB.StUiRcgwOVyWCMYsOLiKLHpbMPm => JYKAxzbcwrkvXFkdyALvVdvpDkeE;

					double NIDNlJlEVxIbcsEQKbbgfFZhJwDB.wibMObrzBxmhqnBInEOvWFZFBkyI => uTRYjniBIJOmiFWRrBPmOajohcO;

					public eQaARQwlcakzPaJCLRZmbjzCHZE(TController controller, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<TMap> mapSet)
					{
						TWofsWdWcZrFDlgktqaiXknQuRD = controller;
						JYKAxzbcwrkvXFkdyALvVdvpDkeE = mapSet;
					}

					public void drlbfUDgyvPaiZWASoBBKrHpfBhE()
					{
						uTRYjniBIJOmiFWRrBPmOajohcO = ReInput.unscaledTime;
					}
				}

				private List<eQaARQwlcakzPaJCLRZmbjzCHZE> bcDhYTWaaaoMHhMjJexfmEnUBLh;

				private List<TController> YeljzzcngjfSmEQoeavFvbwUNGn;

				private ReadOnlyCollection<TController> zseANsczFtgYJflXhkbiQxKoSsnT;

				private readonly ControllerType DdmGAhnWjBkGezCJigEsEoriSFLq;

				public int ioXgUGjpFGeVuGnqwbPHBeKgnSzF => bcDhYTWaaaoMHhMjJexfmEnUBLh.Count;

				public IList<TController> ZwlsmACtCRubGDNUtxYtMjhmISC => zseANsczFtgYJflXhkbiQxKoSsnT;

				public eQaARQwlcakzPaJCLRZmbjzCHZE mFldAkWEWmHykRxiejPmGewpCka => bcDhYTWaaaoMHhMjJexfmEnUBLh[index];

				public ControllerType kEHmRBonufPaXwWSSWlSciOdvWy => DdmGAhnWjBkGezCJigEsEoriSFLq;

				NIDNlJlEVxIbcsEQKbbgfFZhJwDB UatpsZKPeFXZcGHRylaqbbrOzNO.nrObxyIDaqlFcaWUcjleSYKUEQT => bcDhYTWaaaoMHhMjJexfmEnUBLh[index];

				public IcESaAjemNGWngcrzWaBSsruFXF()
				{
					if (!object.ReferenceEquals(BbpfTcGSZRHmltstKOfXrucHPJO.gVqvqWKNvveTYIquTIkfLpZqMtl<TController>(), typeof(TMap)))
					{
						throw new Exception(typeof(TController).Name + " cannot be used with a map of type " + typeof(TMap).Name);
					}
					DdmGAhnWjBkGezCJigEsEoriSFLq = BbpfTcGSZRHmltstKOfXrucHPJO.MCqTpqfPfAfEfejTBeFbGkgGaXhu(typeof(TController));
					bcDhYTWaaaoMHhMjJexfmEnUBLh = new List<eQaARQwlcakzPaJCLRZmbjzCHZE>();
					YeljzzcngjfSmEQoeavFvbwUNGn = new List<TController>();
					zseANsczFtgYJflXhkbiQxKoSsnT = new ReadOnlyCollection<TController>(YeljzzcngjfSmEQoeavFvbwUNGn);
				}

				public eQaARQwlcakzPaJCLRZmbjzCHZE UHzLoQtWuAoHLAFsVljNrYZrrEC(int P_0)
				{
					if (DdmGAhnWjBkGezCJigEsEoriSFLq == ControllerType.Keyboard || DdmGAhnWjBkGezCJigEsEoriSFLq == ControllerType.Mouse)
					{
						P_0 = 0;
					}
					int num = eaOrStrSOuOlEEMmganiuTHlvbL(P_0);
					if (num < 0)
					{
						return null;
					}
					return bcDhYTWaaaoMHhMjJexfmEnUBLh[num];
				}

				public eQaARQwlcakzPaJCLRZmbjzCHZE UHzLoQtWuAoHLAFsVljNrYZrrEC(TController P_0)
				{
					if (P_0 == null)
					{
						return null;
					}
					return UHzLoQtWuAoHLAFsVljNrYZrrEC(P_0.id);
				}

				public void IZbaudhWyBbPeJpvcIZQLOAuOFCc(eQaARQwlcakzPaJCLRZmbjzCHZE P_0)
				{
					if (P_0 != null)
					{
						bcDhYTWaaaoMHhMjJexfmEnUBLh.Add(P_0);
						YeljzzcngjfSmEQoeavFvbwUNGn.Add(P_0.TWofsWdWcZrFDlgktqaiXknQuRD);
					}
				}

				public void trkLxqDkOLvKrmFNndzuxOPolzd(int P_0)
				{
					if (DdmGAhnWjBkGezCJigEsEoriSFLq == ControllerType.Keyboard || DdmGAhnWjBkGezCJigEsEoriSFLq == ControllerType.Mouse)
					{
						P_0 = 0;
					}
					int num = eaOrStrSOuOlEEMmganiuTHlvbL(P_0);
					if (num < 0)
					{
						return;
					}
					for (int i = 0; i < bcDhYTWaaaoMHhMjJexfmEnUBLh.Count; i++)
					{
						if (bcDhYTWaaaoMHhMjJexfmEnUBLh[i].TWofsWdWcZrFDlgktqaiXknQuRD.id == P_0)
						{
							OtHEMvEtwLDLiaSXftVcvELMffBm(i);
							break;
						}
					}
				}

				void UatpsZKPeFXZcGHRylaqbbrOzNO.trkLxqDkOLvKrmFNndzuxOPolzd(int P_0)
				{
					//ILSpy generated this explicit interface implementation from .override directive in trkLxqDkOLvKrmFNndzuxOPolzd
					this.trkLxqDkOLvKrmFNndzuxOPolzd(P_0);
				}

				public void trkLxqDkOLvKrmFNndzuxOPolzd(TController P_0)
				{
					if (P_0 != null && P_0.type == DdmGAhnWjBkGezCJigEsEoriSFLq)
					{
						trkLxqDkOLvKrmFNndzuxOPolzd(P_0.id);
					}
				}

				public void OtHEMvEtwLDLiaSXftVcvELMffBm(int P_0)
				{
					if (P_0 >= 0 && P_0 < bcDhYTWaaaoMHhMjJexfmEnUBLh.Count)
					{
						bcDhYTWaaaoMHhMjJexfmEnUBLh.RemoveAt(P_0);
						YeljzzcngjfSmEQoeavFvbwUNGn.RemoveAt(P_0);
					}
				}

				void UatpsZKPeFXZcGHRylaqbbrOzNO.OtHEMvEtwLDLiaSXftVcvELMffBm(int P_0)
				{
					//ILSpy generated this explicit interface implementation from .override directive in OtHEMvEtwLDLiaSXftVcvELMffBm
					this.OtHEMvEtwLDLiaSXftVcvELMffBm(P_0);
				}

				public TController RAcjlNtCncziVZzKMoHKTIJjxln(int P_0)
				{
					if (DdmGAhnWjBkGezCJigEsEoriSFLq == ControllerType.Keyboard || DdmGAhnWjBkGezCJigEsEoriSFLq == ControllerType.Mouse)
					{
						P_0 = 0;
					}
					int num = eaOrStrSOuOlEEMmganiuTHlvbL(P_0);
					if (num < 0)
					{
						return null;
					}
					return bcDhYTWaaaoMHhMjJexfmEnUBLh[num].TWofsWdWcZrFDlgktqaiXknQuRD;
				}

				public bool oQFygjrDaMtXNUGnYpOhqPuoBesB(int P_0)
				{
					if (DdmGAhnWjBkGezCJigEsEoriSFLq == ControllerType.Keyboard || DdmGAhnWjBkGezCJigEsEoriSFLq == ControllerType.Mouse)
					{
						P_0 = 0;
					}
					if (P_0 < 0)
					{
						return false;
					}
					for (int i = 0; i < bcDhYTWaaaoMHhMjJexfmEnUBLh.Count; i++)
					{
						if (bcDhYTWaaaoMHhMjJexfmEnUBLh[i].TWofsWdWcZrFDlgktqaiXknQuRD.id == P_0)
						{
							return true;
						}
					}
					return false;
				}

				bool UatpsZKPeFXZcGHRylaqbbrOzNO.oQFygjrDaMtXNUGnYpOhqPuoBesB(int P_0)
				{
					//ILSpy generated this explicit interface implementation from .override directive in oQFygjrDaMtXNUGnYpOhqPuoBesB
					return this.oQFygjrDaMtXNUGnYpOhqPuoBesB(P_0);
				}

				public bool oQFygjrDaMtXNUGnYpOhqPuoBesB(TController P_0)
				{
					if (P_0 == null)
					{
						return false;
					}
					if (P_0.type != DdmGAhnWjBkGezCJigEsEoriSFLq)
					{
						return false;
					}
					return oQFygjrDaMtXNUGnYpOhqPuoBesB(P_0.id);
				}

				public int eaOrStrSOuOlEEMmganiuTHlvbL(int P_0)
				{
					if (DdmGAhnWjBkGezCJigEsEoriSFLq == ControllerType.Keyboard || DdmGAhnWjBkGezCJigEsEoriSFLq == ControllerType.Mouse)
					{
						P_0 = 0;
					}
					if (P_0 < 0)
					{
						return -1;
					}
					for (int i = 0; i < bcDhYTWaaaoMHhMjJexfmEnUBLh.Count; i++)
					{
						if (bcDhYTWaaaoMHhMjJexfmEnUBLh[i].TWofsWdWcZrFDlgktqaiXknQuRD.id == P_0)
						{
							return i;
						}
					}
					return -1;
				}

				int UatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(int P_0)
				{
					//ILSpy generated this explicit interface implementation from .override directive in eaOrStrSOuOlEEMmganiuTHlvbL
					return this.eaOrStrSOuOlEEMmganiuTHlvbL(P_0);
				}

				public int eaOrStrSOuOlEEMmganiuTHlvbL(TController P_0)
				{
					if (P_0 == null)
					{
						return -1;
					}
					if (P_0.type != DdmGAhnWjBkGezCJigEsEoriSFLq)
					{
						return -1;
					}
					return eaOrStrSOuOlEEMmganiuTHlvbL(P_0.id);
				}

				public int oYrUpAXrOvAasGoXnJjqlinzpGTA(string P_0)
				{
					if (P_0 == null || P_0 == string.Empty)
					{
						return -1;
					}
					for (int i = 0; i < bcDhYTWaaaoMHhMjJexfmEnUBLh.Count; i++)
					{
						if (bcDhYTWaaaoMHhMjJexfmEnUBLh[i].TWofsWdWcZrFDlgktqaiXknQuRD.tag.Equals(P_0, StringComparison.OrdinalIgnoreCase))
						{
							return i;
						}
					}
					return -1;
				}

				int UatpsZKPeFXZcGHRylaqbbrOzNO.oYrUpAXrOvAasGoXnJjqlinzpGTA(string P_0)
				{
					//ILSpy generated this explicit interface implementation from .override directive in oYrUpAXrOvAasGoXnJjqlinzpGTA
					return this.oYrUpAXrOvAasGoXnJjqlinzpGTA(P_0);
				}

				public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
				{
					bcDhYTWaaaoMHhMjJexfmEnUBLh.Clear();
					YeljzzcngjfSmEQoeavFvbwUNGn.Clear();
				}

				void UatpsZKPeFXZcGHRylaqbbrOzNO.LlCkzvOeJVaCziTDPktzBWuYotAZ()
				{
					//ILSpy generated this explicit interface implementation from .override directive in LlCkzvOeJVaCziTDPktzBWuYotAZ
					this.LlCkzvOeJVaCziTDPktzBWuYotAZ();
				}

				private NIDNlJlEVxIbcsEQKbbgfFZhJwDB AsTxqrthuyWoFZBGrstghvMLlqc(int P_0)
				{
					return UHzLoQtWuAoHLAFsVljNrYZrrEC(P_0);
				}

				NIDNlJlEVxIbcsEQKbbgfFZhJwDB UatpsZKPeFXZcGHRylaqbbrOzNO.UHzLoQtWuAoHLAFsVljNrYZrrEC(int P_0)
				{
					//ILSpy generated this explicit interface implementation from .override directive in AsTxqrthuyWoFZBGrstghvMLlqc
					return this.AsTxqrthuyWoFZBGrstghvMLlqc(P_0);
				}

				private NIDNlJlEVxIbcsEQKbbgfFZhJwDB AsTxqrthuyWoFZBGrstghvMLlqc(Controller P_0)
				{
					if (P_0 as TController == null)
					{
						return null;
					}
					return UHzLoQtWuAoHLAFsVljNrYZrrEC(P_0 as TController);
				}

				NIDNlJlEVxIbcsEQKbbgfFZhJwDB UatpsZKPeFXZcGHRylaqbbrOzNO.UHzLoQtWuAoHLAFsVljNrYZrrEC(Controller P_0)
				{
					//ILSpy generated this explicit interface implementation from .override directive in AsTxqrthuyWoFZBGrstghvMLlqc
					return this.AsTxqrthuyWoFZBGrstghvMLlqc(P_0);
				}

				private void IIPMUxvNgPGuigQSsfSeWbdOMDkh(NIDNlJlEVxIbcsEQKbbgfFZhJwDB P_0)
				{
					IZbaudhWyBbPeJpvcIZQLOAuOFCc((eQaARQwlcakzPaJCLRZmbjzCHZE)P_0);
				}

				void UatpsZKPeFXZcGHRylaqbbrOzNO.IZbaudhWyBbPeJpvcIZQLOAuOFCc(NIDNlJlEVxIbcsEQKbbgfFZhJwDB P_0)
				{
					//ILSpy generated this explicit interface implementation from .override directive in IIPMUxvNgPGuigQSsfSeWbdOMDkh
					this.IIPMUxvNgPGuigQSsfSeWbdOMDkh(P_0);
				}

				private void hgwZipnIoZEzwOVLoRHvHOYIqHD(Controller P_0)
				{
					trkLxqDkOLvKrmFNndzuxOPolzd(P_0 as TController);
				}

				void UatpsZKPeFXZcGHRylaqbbrOzNO.trkLxqDkOLvKrmFNndzuxOPolzd(Controller P_0)
				{
					//ILSpy generated this explicit interface implementation from .override directive in hgwZipnIoZEzwOVLoRHvHOYIqHD
					this.hgwZipnIoZEzwOVLoRHvHOYIqHD(P_0);
				}

				private Controller wdawsYlJSMYRLkmgbAfEBvBvRVzQ(int P_0)
				{
					return RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
				}

				Controller UatpsZKPeFXZcGHRylaqbbrOzNO.RAcjlNtCncziVZzKMoHKTIJjxln(int P_0)
				{
					//ILSpy generated this explicit interface implementation from .override directive in wdawsYlJSMYRLkmgbAfEBvBvRVzQ
					return this.wdawsYlJSMYRLkmgbAfEBvBvRVzQ(P_0);
				}

				private bool AtPQqQIcmnAfznjyLmMDthJqCFu(Controller P_0)
				{
					return oQFygjrDaMtXNUGnYpOhqPuoBesB(P_0 as TController);
				}

				bool UatpsZKPeFXZcGHRylaqbbrOzNO.oQFygjrDaMtXNUGnYpOhqPuoBesB(Controller P_0)
				{
					//ILSpy generated this explicit interface implementation from .override directive in AtPQqQIcmnAfznjyLmMDthJqCFu
					return this.AtPQqQIcmnAfznjyLmMDthJqCFu(P_0);
				}

				private int oIwPMUArPPxGymKAqRKeRojHHOA(Controller P_0)
				{
					return eaOrStrSOuOlEEMmganiuTHlvbL(P_0 as TController);
				}

				int UatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(Controller P_0)
				{
					//ILSpy generated this explicit interface implementation from .override directive in oIwPMUArPPxGymKAqRKeRojHHOA
					return this.oIwPMUArPPxGymKAqRKeRojHHOA(P_0);
				}

				private Controller fKUBQyaKGFHbxcShUyihMSknNwqe(string P_0)
				{
					int num = oYrUpAXrOvAasGoXnJjqlinzpGTA(P_0);
					if (num < 0)
					{
						return null;
					}
					return bcDhYTWaaaoMHhMjJexfmEnUBLh[num].TWofsWdWcZrFDlgktqaiXknQuRD;
				}

				Controller UatpsZKPeFXZcGHRylaqbbrOzNO.zMVBLXbZSXJvHEqgBWiFdbaslwo(string P_0)
				{
					//ILSpy generated this explicit interface implementation from .override directive in fKUBQyaKGFHbxcShUyihMSknNwqe
					return this.fKUBQyaKGFHbxcShUyihMSknNwqe(P_0);
				}
			}

			internal class YjaFpcJTsgTKMFdMcpSeyatdmMem
			{
				public readonly int ioXgUGjpFGeVuGnqwbPHBeKgnSzF;

				private ControllerType[] YSapUtDVQsdyoJfWLSoRhhBccMDE;

				private UatpsZKPeFXZcGHRylaqbbrOzNO[] dMncOpKupTsyVgXhrsstruyovbjE;

				public UatpsZKPeFXZcGHRylaqbbrOzNO nGoeHQQFrJEctOmWrfOcOGAwdob(int P_0)
				{
					return dMncOpKupTsyVgXhrsstruyovbjE[P_0];
				}

				public ControllerType HurpQuBFJuSAymgLzSdtczYvHZA(int P_0)
				{
					return YSapUtDVQsdyoJfWLSoRhhBccMDE[P_0];
				}

				public YjaFpcJTsgTKMFdMcpSeyatdmMem(int length)
				{
					ioXgUGjpFGeVuGnqwbPHBeKgnSzF = MathTools.Max(0, length);
					YSapUtDVQsdyoJfWLSoRhhBccMDE = new ControllerType[length];
					dMncOpKupTsyVgXhrsstruyovbjE = new UatpsZKPeFXZcGHRylaqbbrOzNO[length];
				}

				public UatpsZKPeFXZcGHRylaqbbrOzNO rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType P_0)
				{
					for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						if (P_0 == YSapUtDVQsdyoJfWLSoRhhBccMDE[i])
						{
							return dMncOpKupTsyVgXhrsstruyovbjE[i];
						}
					}
					throw new Exception("Value is not in the set.");
				}

				public void IYxGjOMqHIcQgesHtAraamCepwNe(int P_0, ControllerType P_1, UatpsZKPeFXZcGHRylaqbbrOzNO P_2)
				{
					YSapUtDVQsdyoJfWLSoRhhBccMDE[P_0] = P_1;
					dMncOpKupTsyVgXhrsstruyovbjE[P_0] = P_2;
				}
			}

			private class VXBoNHtgnKLLBJDGZBmIlDeVkgE
			{
				public class IhutOmkxTxJFmqGgDPFKTuVBQbd
				{
					public int mwTxXrbbhfRpdwAUSEMlptKkOji;

					public global::gHFgzSPsLtKjGAtobRtDQKtpUvu<JoystickMap> JYKAxzbcwrkvXFkdyALvVdvpDkeE;

					public double FxyJuJaCCTESVvQMYBylPtXljFT;

					public IhutOmkxTxJFmqGgDPFKTuVBQbd(int joystickId, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<JoystickMap> mapSet, double lastConnectedTime)
					{
						mwTxXrbbhfRpdwAUSEMlptKkOji = joystickId;
						JYKAxzbcwrkvXFkdyALvVdvpDkeE = mapSet;
						FxyJuJaCCTESVvQMYBylPtXljFT = lastConnectedTime;
					}
				}

				private readonly List<IhutOmkxTxJFmqGgDPFKTuVBQbd> BOUZQgfjcmguYdmiFTTQVpzRKHM;

				private readonly Player QFlXjfmiJabcsMblLziegHSMCLfJ;

				public VXBoNHtgnKLLBJDGZBmIlDeVkgE(Player player)
				{
					QFlXjfmiJabcsMblLziegHSMCLfJ = player;
					BOUZQgfjcmguYdmiFTTQVpzRKHM = new List<IhutOmkxTxJFmqGgDPFKTuVBQbd>();
				}

				public void ROWDMagIyIfgsVWhoSroKVHpUgvW(Joystick P_0, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<JoystickMap> P_1)
				{
					for (int i = 0; i < BOUZQgfjcmguYdmiFTTQVpzRKHM.Count; i++)
					{
						IhutOmkxTxJFmqGgDPFKTuVBQbd ihutOmkxTxJFmqGgDPFKTuVBQbd = BOUZQgfjcmguYdmiFTTQVpzRKHM[i];
						if (ihutOmkxTxJFmqGgDPFKTuVBQbd.mwTxXrbbhfRpdwAUSEMlptKkOji == P_0.id)
						{
							ihutOmkxTxJFmqGgDPFKTuVBQbd.JYKAxzbcwrkvXFkdyALvVdvpDkeE = P_1;
							ihutOmkxTxJFmqGgDPFKTuVBQbd.FxyJuJaCCTESVvQMYBylPtXljFT = ReInput.realTime;
							return;
						}
					}
					IhutOmkxTxJFmqGgDPFKTuVBQbd item = new IhutOmkxTxJFmqGgDPFKTuVBQbd(P_0.id, P_1, ReInput.realTime);
					BOUZQgfjcmguYdmiFTTQVpzRKHM.Add(item);
				}

				public void ROWDMagIyIfgsVWhoSroKVHpUgvW(IcESaAjemNGWngcrzWaBSsruFXF<Joystick, JoystickMap>.eQaARQwlcakzPaJCLRZmbjzCHZE P_0)
				{
					ROWDMagIyIfgsVWhoSroKVHpUgvW(P_0.TWofsWdWcZrFDlgktqaiXknQuRD, P_0.JYKAxzbcwrkvXFkdyALvVdvpDkeE);
				}

				public void NPuccIFRsBNSlpfFXLwIuObSBNP()
				{
					for (int i = 0; i < BOUZQgfjcmguYdmiFTTQVpzRKHM.Count; i++)
					{
						if (!QFlXjfmiJabcsMblLziegHSMCLfJ.controllers.ContainsController(ControllerType.Joystick, BOUZQgfjcmguYdmiFTTQVpzRKHM[i].mwTxXrbbhfRpdwAUSEMlptKkOji))
						{
							BOUZQgfjcmguYdmiFTTQVpzRKHM[i].JYKAxzbcwrkvXFkdyALvVdvpDkeE = null;
						}
					}
				}

				public IhutOmkxTxJFmqGgDPFKTuVBQbd qsbDEOfbSUzywOGZSmnkKKrjfAW(int P_0)
				{
					int num = eaOrStrSOuOlEEMmganiuTHlvbL(P_0);
					if (num < 0)
					{
						return null;
					}
					return BOUZQgfjcmguYdmiFTTQVpzRKHM[num];
				}

				public bool oQFygjrDaMtXNUGnYpOhqPuoBesB(int P_0)
				{
					for (int i = 0; i < BOUZQgfjcmguYdmiFTTQVpzRKHM.Count; i++)
					{
						if (BOUZQgfjcmguYdmiFTTQVpzRKHM[i].mwTxXrbbhfRpdwAUSEMlptKkOji == P_0)
						{
							return true;
						}
					}
					return false;
				}

				public int eaOrStrSOuOlEEMmganiuTHlvbL(int P_0)
				{
					for (int i = 0; i < BOUZQgfjcmguYdmiFTTQVpzRKHM.Count; i++)
					{
						if (BOUZQgfjcmguYdmiFTTQVpzRKHM[i].mwTxXrbbhfRpdwAUSEMlptKkOji == P_0)
						{
							return i;
						}
					}
					return -1;
				}

				public void LlCkzvOeJVaCziTDPktzBWuYotAZ()
				{
					BOUZQgfjcmguYdmiFTTQVpzRKHM.Clear();
				}
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[Browsable(false)]
			public sealed class MapHelper : CodeHelper
			{
				private readonly hoGZGoKcYjvzMpyhYIdlAPtnxIh QIllBbwNoyeVMhiueNkitOxjwEjn;

				private Player QFlXjfmiJabcsMblLziegHSMCLfJ;

				private ControllerHelper mQXiYotjnToDecfWIRfktslJAMQ;

				private readonly ControllerMapEnabler EGgKASJhLqAeBBLgAmtBWBjevfmg;

				private readonly ControllerMapLayoutManager arlWAVyKcDIOfecrFqGgsdeCzdlj;

				private readonly int PivQvdYMhUssuLwaglJVqkqXMSH;

				public ControllerMapLayoutManager layoutManager => arlWAVyKcDIOfecrFqGgsdeCzdlj;

				public ControllerMapEnabler mapEnabler => EGgKASJhLqAeBBLgAmtBWBjevfmg;

				public IList<InputBehavior> InputBehaviors
				{
					get
					{
						if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
						{
							ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
							return EmptyObjects<InputBehavior>.EmptyReadOnlyIListT;
						}
						return QFlXjfmiJabcsMblLziegHSMCLfJ.mvrCdGRIOFGaMUOTuzwAwqCUSAr.umHQUsjkrukJGdByYFaLhrPTnXQ(QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri);
					}
				}

				internal MapHelper(Player player, ControllerHelper parent, hoGZGoKcYjvzMpyhYIdlAPtnxIh startingControllerMapInfo, ControllerMapLayoutManager.lRHvetoYBHZvdHTlYVwfdpCPcAs controllerMapLayoutManagerSettings, ControllerMapEnabler.xIhBRlVXbtrPkJZqdoJCRHAyPSc controllerMapEnablerSettings)
				{
					PivQvdYMhUssuLwaglJVqkqXMSH = ReInput.id;
					QFlXjfmiJabcsMblLziegHSMCLfJ = player;
					mQXiYotjnToDecfWIRfktslJAMQ = parent;
					QIllBbwNoyeVMhiueNkitOxjwEjn = startingControllerMapInfo;
					EGgKASJhLqAeBBLgAmtBWBjevfmg = new ControllerMapEnabler(player, controllerMapEnablerSettings);
					arlWAVyKcDIOfecrFqGgsdeCzdlj = new ControllerMapLayoutManager(player, controllerMapLayoutManagerSettings);
					arlWAVyKcDIOfecrFqGgsdeCzdlj.ApplyCalledEvent += EGgKASJhLqAeBBLgAmtBWBjevfmg.Apply;
				}

				public void LoadMap<T>(int controllerId, int categoryId, int layoutId) where T : ControllerMap
				{
					XqoSvNPGavWYCNbkwDWZGpzoHvZx<T>(controllerId, categoryId, layoutId, BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
				}

				public void LoadMap<T>(int controllerId, string categoryName, string layoutName) where T : ControllerMap
				{
					XqoSvNPGavWYCNbkwDWZGpzoHvZx<T>(controllerId, categoryName, layoutName, BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
				}

				public void LoadMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId)
				{
					XqoSvNPGavWYCNbkwDWZGpzoHvZx(controllerType, controllerId, categoryId, layoutId, BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
				}

				public void LoadMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName)
				{
					XqoSvNPGavWYCNbkwDWZGpzoHvZx(controllerType, controllerId, categoryName, layoutName, BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
				}

				public void LoadMap<T>(int controllerId, int categoryId, int layoutId, bool startEnabled) where T : ControllerMap
				{
					XqoSvNPGavWYCNbkwDWZGpzoHvZx<T>(controllerId, categoryId, layoutId, startEnabled ? BoolOption.vfktGKibKwJQmGkXtDsMhiPAPJr : BoolOption.mYTCLYyoUtlUIUYLAaZfeCqHKcW);
				}

				public void LoadMap<T>(int controllerId, string categoryName, string layoutName, bool startEnabled) where T : ControllerMap
				{
					XqoSvNPGavWYCNbkwDWZGpzoHvZx<T>(controllerId, categoryName, layoutName, startEnabled ? BoolOption.vfktGKibKwJQmGkXtDsMhiPAPJr : BoolOption.mYTCLYyoUtlUIUYLAaZfeCqHKcW);
				}

				public void LoadMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId, bool startEnabled)
				{
					XqoSvNPGavWYCNbkwDWZGpzoHvZx(controllerType, controllerId, categoryId, layoutId, startEnabled ? BoolOption.vfktGKibKwJQmGkXtDsMhiPAPJr : BoolOption.mYTCLYyoUtlUIUYLAaZfeCqHKcW);
				}

				public void LoadMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName, bool startEnabled)
				{
					XqoSvNPGavWYCNbkwDWZGpzoHvZx(controllerType, controllerId, categoryName, layoutName, startEnabled ? BoolOption.vfktGKibKwJQmGkXtDsMhiPAPJr : BoolOption.mYTCLYyoUtlUIUYLAaZfeCqHKcW);
				}

				private void XqoSvNPGavWYCNbkwDWZGpzoHvZx<T>(int P_0, int P_1, int P_2, BoolOption P_3) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						KCoiHPDBfncivsYMtDeuIMbjuAx(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), P_0, P_1, P_2, P_3);
					}
				}

				private void XqoSvNPGavWYCNbkwDWZGpzoHvZx<T>(int P_0, string P_1, string P_2, BoolOption P_3) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						KCoiHPDBfncivsYMtDeuIMbjuAx(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), P_0, P_1, P_2, P_3);
					}
				}

				private void XqoSvNPGavWYCNbkwDWZGpzoHvZx(ControllerType P_0, int P_1, int P_2, int P_3, BoolOption P_4)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						KCoiHPDBfncivsYMtDeuIMbjuAx(P_0, P_1, P_2, P_3, P_4);
					}
				}

				private void XqoSvNPGavWYCNbkwDWZGpzoHvZx(ControllerType P_0, int P_1, string P_2, string P_3, BoolOption P_4)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						KCoiHPDBfncivsYMtDeuIMbjuAx(P_0, P_1, P_2, P_3, P_4);
					}
				}

				public IEnumerable<ControllerMap> GetAllMaps()
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						yield break;
					}
					int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(i);
						int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int j = 0; j < count; j++)
						{
							SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(j).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
							int count2 = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
							for (int k = 0; k < count2; k++)
							{
								yield return mapSet.get_Item(k);
							}
						}
					}
				}

				public int GetAllMaps(List<ControllerMap> results)
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
					int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(i);
						int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int j = 0; j < count; j++)
						{
							uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(j).JYKAxzbcwrkvXFkdyALvVdvpDkeE.oUQuEQAgSUASfBxvUZViLorRwfUP(results, true);
						}
					}
					return results.Count;
				}

				public IEnumerable<T> GetAllMaps<T>() where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						yield break;
					}
					if (BbpfTcGSZRHmltstKOfXrucHPJO.wLXEcuVBmeohrCkfUTGEONyYHTV<T>(out var controllerType))
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
						int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int i = 0; i < count; i++)
						{
							SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
							int count2 = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
							for (int j = 0; j < count2; j++)
							{
								yield return (T)mapSet.get_Item(j);
							}
						}
						yield break;
					}
					int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int k = 0; k < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; k++)
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO2 = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(k);
						int count3 = uatpsZKPeFXZcGHRylaqbbrOzNO2.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int l = 0; l < count3; l++)
						{
							SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet2 = uatpsZKPeFXZcGHRylaqbbrOzNO2.get_Item(l).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
							int count4 = mapSet2.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
							for (int m = 0; m < count4; m++)
							{
								if (mapSet2.get_Item(m) is T val)
								{
									yield return val;
								}
							}
						}
					}
				}

				public int GetAllMaps<T>(List<T> results) where T : ControllerMap
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
					if (BbpfTcGSZRHmltstKOfXrucHPJO.wLXEcuVBmeohrCkfUTGEONyYHTV<T>(out var controllerType))
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
						int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int i = 0; i < count; i++)
						{
							uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.oUQuEQAgSUASfBxvUZViLorRwfUP(results, true);
						}
					}
					else
					{
						int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int j = 0; j < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; j++)
						{
							UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO2 = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(j);
							int count2 = uatpsZKPeFXZcGHRylaqbbrOzNO2.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
							for (int k = 0; k < count2; k++)
							{
								uatpsZKPeFXZcGHRylaqbbrOzNO2.get_Item(k).JYKAxzbcwrkvXFkdyALvVdvpDkeE.oUQuEQAgSUASfBxvUZViLorRwfUP(results, true);
							}
						}
					}
					return results.Count;
				}

				public IEnumerable<ControllerMap> GetAllMaps(ControllerType controllerType)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						yield break;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
					int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < count; i++)
					{
						SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
						int count2 = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int j = 0; j < count2; j++)
						{
							yield return mapSet.get_Item(j);
						}
					}
				}

				public int GetAllMaps(ControllerType controllerType, List<ControllerMap> results)
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
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
					int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < count; i++)
					{
						uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.oUQuEQAgSUASfBxvUZViLorRwfUP(results, true);
					}
					return results.Count;
				}

				public IEnumerable<ControllerMap> GetAllMapsInCategory(string categoryName)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerMap>.EmptyReadOnlyIListT;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return new List<ControllerMap>();
					}
					return GetAllMapsInCategory(mapCategoryId);
				}

				public IEnumerable<ControllerMap> GetAllMapsInCategory(int categoryId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						yield break;
					}
					int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(i);
						int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int j = 0; j < count; j++)
						{
							SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(j).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
							int count2 = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
							for (int k = 0; k < count2; k++)
							{
								ControllerMap controllerMap = mapSet.get_Item(k);
								if (controllerMap.categoryId == categoryId)
								{
									yield return controllerMap;
								}
							}
						}
					}
				}

				public IEnumerable<T> GetAllMapsInCategory<T>(string categoryName) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<T>.EmptyReadOnlyIListT;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return EmptyObjects<T>.EmptyReadOnlyIListT;
					}
					return GetAllMapsInCategory<T>(mapCategoryId);
				}

				public IEnumerable<T> GetAllMapsInCategory<T>(int categoryId) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						yield break;
					}
					if (BbpfTcGSZRHmltstKOfXrucHPJO.wLXEcuVBmeohrCkfUTGEONyYHTV<T>(out var _))
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = XnNEpeSUHwYbeEzItDPssHpBWDC<T>();
						int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int i = 0; i < count; i++)
						{
							SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
							int count2 = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
							for (int j = 0; j < count2; j++)
							{
								ControllerMap controllerMap = mapSet.get_Item(j);
								if (controllerMap.categoryId == categoryId)
								{
									yield return (T)controllerMap;
								}
							}
						}
						yield break;
					}
					int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int k = 0; k < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; k++)
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO2 = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(k);
						int count3 = uatpsZKPeFXZcGHRylaqbbrOzNO2.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int l = 0; l < count3; l++)
						{
							SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet2 = uatpsZKPeFXZcGHRylaqbbrOzNO2.get_Item(l).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
							int count4 = mapSet2.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
							for (int m = 0; m < count4; m++)
							{
								T val = mapSet2.get_Item(m) as T;
								if (val != null && val.categoryId == categoryId)
								{
									yield return val;
								}
							}
						}
					}
				}

				public IEnumerable<ControllerMap> GetAllMapsInCategory(string categoryName, ControllerType controllerType)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerMap>.EmptyReadOnlyIListT;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return new List<ControllerMap>();
					}
					return GetAllMapsInCategory(mapCategoryId, controllerType);
				}

				public IEnumerable<ControllerMap> GetAllMapsInCategory(int categoryId, ControllerType controllerType)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						yield break;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
					int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < count; i++)
					{
						SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
						int count2 = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int j = 0; j < count2; j++)
						{
							ControllerMap controllerMap = mapSet.get_Item(j);
							if (controllerMap.categoryId == categoryId)
							{
								yield return controllerMap;
							}
						}
					}
				}

				public int GetAllMapsInCategory(string categoryName, List<ControllerMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return 0;
					}
					return GetAllMapsInCategory(mapCategoryId, results);
				}

				public int GetAllMapsInCategory(int categoryId, List<ControllerMap> results)
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
					if (ReInput.mapping.GetMapCategory(categoryId) == null)
					{
						return 0;
					}
					int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(i);
						int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int j = 0; j < count; j++)
						{
							uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(j).JYKAxzbcwrkvXFkdyALvVdvpDkeE.wSkknMfcZANKmxiRSFsugsrKwqi(categoryId, results, true);
						}
					}
					return results.Count;
				}

				public int GetAllMapsInCategory<T>(string categoryName, List<T> results) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return 0;
					}
					return GetAllMapsInCategory(mapCategoryId, results);
				}

				public int GetAllMapsInCategory<T>(int categoryId, List<T> results) where T : ControllerMap
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
					if (ReInput.mapping.GetMapCategory(categoryId) == null)
					{
						return 0;
					}
					if (BbpfTcGSZRHmltstKOfXrucHPJO.wLXEcuVBmeohrCkfUTGEONyYHTV<T>(out var controllerType))
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
						int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int i = 0; i < count; i++)
						{
							uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.wSkknMfcZANKmxiRSFsugsrKwqi(categoryId, results, true);
						}
					}
					else
					{
						int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int j = 0; j < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; j++)
						{
							UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO2 = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(j);
							int count2 = uatpsZKPeFXZcGHRylaqbbrOzNO2.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
							for (int k = 0; k < count2; k++)
							{
								uatpsZKPeFXZcGHRylaqbbrOzNO2.get_Item(k).JYKAxzbcwrkvXFkdyALvVdvpDkeE.wSkknMfcZANKmxiRSFsugsrKwqi(categoryId, results, true);
							}
						}
					}
					return results.Count;
				}

				public int GetAllMapsInCategory(string categoryName, ControllerType controllerType, List<ControllerMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return 0;
					}
					return GetAllMapsInCategory(mapCategoryId, controllerType, results);
				}

				public int GetAllMapsInCategory(int categoryId, ControllerType controllerType, List<ControllerMap> results)
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
					if (ReInput.mapping.GetMapCategory(categoryId) == null)
					{
						return 0;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
					int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < count; i++)
					{
						uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.wSkknMfcZANKmxiRSFsugsrKwqi(categoryId, results, true);
					}
					return results.Count;
				}

				public IList<T> GetMaps<T>(int controllerId) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<T>.EmptyReadOnlyIListT;
					}
					return QOalkbNznfpJKPRRcqLDYCGGZXo<T>(controllerId);
				}

				public IList<ControllerMap> GetMaps(ControllerType controllerType, int controllerId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerMap>.EmptyReadOnlyIListT;
					}
					return QOalkbNznfpJKPRRcqLDYCGGZXo(controllerType, controllerId);
				}

				public IList<ControllerMap> GetMaps(Controller controller)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerMap>.EmptyReadOnlyIListT;
					}
					if (controller == null)
					{
						return EmptyObjects<ControllerMap>.EmptyReadOnlyIListT;
					}
					return GetMaps(controller.type, controller.id);
				}

				public IEnumerable<ControllerMap> GetMapsInCategory(ControllerType controllerType, int controllerId, int categoryId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerMap>.EmptyReadOnlyIListT;
					}
					if (controllerId < 0 || categoryId < 0)
					{
						return EmptyObjects<ControllerMap>.EmptyReadOnlyIListT;
					}
					if (ReInput.mapping.GetMapCategory(categoryId) == null)
					{
						return EmptyObjects<ControllerMap>.EmptyReadOnlyIListT;
					}
					return mOFosXbyeHjzmWoMtBphQKnpHrQ(controllerType, controllerId, categoryId);
				}

				public IEnumerable<ControllerMap> GetMapsInCategory(ControllerType controllerType, int controllerId, string categoryName)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerMap>.EmptyReadOnlyIListT;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return EmptyObjects<ControllerMap>.EmptyReadOnlyIListT;
					}
					return GetMapsInCategory(controllerType, controllerId, mapCategoryId);
				}

				public IEnumerable<ControllerMap> GetMapsInCategory(Controller controller, int categoryId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerMap>.EmptyReadOnlyIListT;
					}
					if (controller == null)
					{
						return EmptyObjects<ControllerMap>.EmptyReadOnlyIListT;
					}
					return GetMapsInCategory(controller.type, controller.id, categoryId);
				}

				public IEnumerable<ControllerMap> GetMapsInCategory(Controller controller, string categoryName)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerMap>.EmptyReadOnlyIListT;
					}
					if (controller == null)
					{
						return EmptyObjects<ControllerMap>.EmptyReadOnlyIListT;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return EmptyObjects<ControllerMap>.EmptyReadOnlyIListT;
					}
					return GetMapsInCategory(controller.type, controller.id, mapCategoryId);
				}

				public int GetMapsInCategory(ControllerType controllerType, int controllerId, int categoryId, List<ControllerMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					ListTools.TryClear(results);
					if (results == null)
					{
						throw new ArgumentNullException("results");
					}
					if (controllerId < 0 || categoryId < 0)
					{
						return 0;
					}
					if (ReInput.mapping.GetMapCategory(categoryId) == null)
					{
						return 0;
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType).UHzLoQtWuAoHLAFsVljNrYZrrEC(controllerId)?.JYKAxzbcwrkvXFkdyALvVdvpDkeE.wSkknMfcZANKmxiRSFsugsrKwqi(categoryId, results, false) ?? 0;
				}

				public int GetMapsInCategory(ControllerType controllerType, int controllerId, string categoryName, List<ControllerMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					ListTools.TryClear(results);
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return 0;
					}
					return GetMapsInCategory(controllerType, controllerId, mapCategoryId, results);
				}

				public int GetMapsInCategory(Controller controller, int categoryId, List<ControllerMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					ListTools.TryClear(results);
					if (controller == null)
					{
						return 0;
					}
					return GetMapsInCategory(controller.type, controller.id, categoryId, results);
				}

				public int GetMapsInCategory(Controller controller, string categoryName, List<ControllerMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					ListTools.TryClear(results);
					if (controller == null)
					{
						return 0;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return 0;
					}
					return GetMapsInCategory(controller.type, controller.id, mapCategoryId, results);
				}

				public IEnumerable<T> GetMapsInCategory<T>(int controllerId, int categoryId) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<T>.EmptyReadOnlyIListT;
					}
					return mOFosXbyeHjzmWoMtBphQKnpHrQ<T>(controllerId, categoryId);
				}

				public IEnumerable<T> GetMapsInCategory<T>(int controllerId, string categoryName) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<T>.EmptyReadOnlyIListT;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return EmptyObjects<T>.EmptyReadOnlyIListT;
					}
					return GetMapsInCategory<T>(controllerId, mapCategoryId);
				}

				public int GetMapsInCategory<T>(int controllerId, int categoryId, List<T> results) where T : ControllerMap
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
					if (ReInput.mapping.GetMapCategory(categoryId) == null)
					{
						return 0;
					}
					NIDNlJlEVxIbcsEQKbbgfFZhJwDB nIDNlJlEVxIbcsEQKbbgfFZhJwDB = XnNEpeSUHwYbeEzItDPssHpBWDC<T>().UHzLoQtWuAoHLAFsVljNrYZrrEC(controllerId);
					if (nIDNlJlEVxIbcsEQKbbgfFZhJwDB == null)
					{
						return 0;
					}
					nIDNlJlEVxIbcsEQKbbgfFZhJwDB.JYKAxzbcwrkvXFkdyALvVdvpDkeE.wSkknMfcZANKmxiRSFsugsrKwqi(categoryId, results, true);
					return results.Count;
				}

				public int GetMapsInCategory<T>(int controllerId, string categoryName, List<T> results) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					ListTools.TryClear(results);
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return 0;
					}
					return GetMapsInCategory(controllerId, mapCategoryId, results);
				}

				public T GetMap<T>(int controllerId, int mapId) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					if (mapId < 0)
					{
						return null;
					}
					return (T)RFheeFPACTMtdVTHXbeKnHCWIBw(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), controllerId, mapId);
				}

				public T GetMap<T>(int controllerId, int categoryId, int layoutId) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					if (categoryId < 0 || layoutId < 0)
					{
						return null;
					}
					return (T)RFheeFPACTMtdVTHXbeKnHCWIBw(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), controllerId, categoryId, layoutId);
				}

				public T GetMap<T>(int controllerId, string categoryName, string layoutName) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return (T)RFheeFPACTMtdVTHXbeKnHCWIBw(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), controllerId, categoryName, layoutName);
				}

				public ControllerMap GetMap(int mapId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					if (mapId < 0)
					{
						return null;
					}
					int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(i);
						int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int j = 0; j < count; j++)
						{
							SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(j).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
							ControllerMap controllerMap = mapSet.whppdOKQYknMWWyLmIsoKqqXCqJ(mapId);
							if (controllerMap != null)
							{
								return controllerMap;
							}
						}
					}
					return null;
				}

				public ControllerMap GetMap(ControllerType controllerType, int controllerId, int mapId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					if (mapId < 0)
					{
						return null;
					}
					return RFheeFPACTMtdVTHXbeKnHCWIBw(controllerType, controllerId, mapId);
				}

				public ControllerMap GetMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					if (categoryId < 0 || layoutId < 0)
					{
						return null;
					}
					return RFheeFPACTMtdVTHXbeKnHCWIBw(controllerType, controllerId, categoryId, layoutId);
				}

				public ControllerMap GetMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return RFheeFPACTMtdVTHXbeKnHCWIBw(controllerType, controllerId, categoryName, layoutName);
				}

				public ControllerMap GetMap(Controller controller, int mapId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					if (controller == null)
					{
						return null;
					}
					return GetMap(controller.type, controller.id, mapId);
				}

				public ControllerMap GetMap(Controller controller, int categoryId, int layoutId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					if (controller == null)
					{
						return null;
					}
					return GetMap(controller.type, controller.id, categoryId, layoutId);
				}

				public ControllerMap GetMap(Controller controller, string categoryName, string layoutName)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					if (controller == null)
					{
						return null;
					}
					return GetMap(controller.type, controller.id, categoryName, layoutName);
				}

				public T GetFirstMapInCategory<T>(int controllerId, string categoryName) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return null;
					}
					return GetFirstMapInCategory<T>(controllerId, mapCategoryId);
				}

				public T GetFirstMapInCategory<T>(int controllerId, int categoryId) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					if (categoryId < 0)
					{
						return null;
					}
					return (T)IrMBHygzPMxgxTCIaqqyBDcNDxza(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), controllerId, categoryId);
				}

				public ControllerMap GetFirstMapInCategory(ControllerType controllerType, int controllerId, string categoryName)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return null;
					}
					return GetFirstMapInCategory(controllerType, controllerId, mapCategoryId);
				}

				public ControllerMap GetFirstMapInCategory(ControllerType controllerType, int controllerId, int categoryId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					if (categoryId < 0)
					{
						return null;
					}
					return IrMBHygzPMxgxTCIaqqyBDcNDxza(controllerType, controllerId, categoryId);
				}

				public ControllerMap GetFirstMapInCategory(Controller controller, string categoryName)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					if (controller == null)
					{
						return null;
					}
					return GetFirstMapInCategory(controller.type, controller.id, categoryName);
				}

				public ControllerMap GetFirstMapInCategory(Controller controller, int categoryId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					if (controller == null)
					{
						return null;
					}
					return GetFirstMapInCategory(controller.type, controller.id, categoryId);
				}

				public void AddMap<T>(int controllerId, ControllerMap map) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						RSGDYijTcBxQgPcPkRoVLjUqYcZ(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), controllerId, map, BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
					}
				}

				public void AddMap(Controller controller, ControllerMap map)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						RSGDYijTcBxQgPcPkRoVLjUqYcZ(controller, map, BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
					}
				}

				public void AddMap(ControllerType controllerType, int controllerId, ControllerMap map)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						RSGDYijTcBxQgPcPkRoVLjUqYcZ(controllerType, controllerId, map, BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
					}
				}

				public void AddMap<T>(int controllerId, ControllerMap map, bool startEnabled) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						RSGDYijTcBxQgPcPkRoVLjUqYcZ(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), controllerId, map, startEnabled ? BoolOption.vfktGKibKwJQmGkXtDsMhiPAPJr : BoolOption.mYTCLYyoUtlUIUYLAaZfeCqHKcW);
					}
				}

				public void AddMap(Controller controller, ControllerMap map, bool startEnabled)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						RSGDYijTcBxQgPcPkRoVLjUqYcZ(controller, map, startEnabled ? BoolOption.vfktGKibKwJQmGkXtDsMhiPAPJr : BoolOption.mYTCLYyoUtlUIUYLAaZfeCqHKcW);
					}
				}

				public void AddMap(ControllerType controllerType, int controllerId, ControllerMap map, bool startEnabled)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						RSGDYijTcBxQgPcPkRoVLjUqYcZ(controllerType, controllerId, map, startEnabled ? BoolOption.vfktGKibKwJQmGkXtDsMhiPAPJr : BoolOption.mYTCLYyoUtlUIUYLAaZfeCqHKcW);
					}
				}

				public bool AddMapFromXml<T>(int controllerId, string xmlString) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					return CLjaIcFlxEIeseRzDQexsnNNeZPp(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), controllerId, xmlString);
				}

				public bool AddMapFromXml(ControllerType controllerType, int controllerId, string xmlString)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					return CLjaIcFlxEIeseRzDQexsnNNeZPp(controllerType, controllerId, xmlString);
				}

				public int AddMapsFromXml<T>(int controllerId, List<string> xmlStrings) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (xmlStrings == null)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < xmlStrings.Count; i++)
					{
						if (AddMapFromXml<T>(controllerId, xmlStrings[i]))
						{
							num++;
						}
					}
					return num;
				}

				public int AddMapsFromXml(ControllerType controllerType, int controllerId, List<string> xmlStrings)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (xmlStrings == null)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < xmlStrings.Count; i++)
					{
						if (AddMapFromXml(controllerType, controllerId, xmlStrings[i]))
						{
							num++;
						}
					}
					return num;
				}

				public bool AddMapFromJson<T>(int controllerId, string jsonString) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					return FZThJxHKIGTOAckRfiJTwzQflDg(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), controllerId, jsonString);
				}

				public bool AddMapFromJson(ControllerType controllerType, int controllerId, string jsonString)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					return FZThJxHKIGTOAckRfiJTwzQflDg(controllerType, controllerId, jsonString);
				}

				public int AddMapsFromJson<T>(int controllerId, List<string> jsonStrings) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (jsonStrings == null)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < jsonStrings.Count; i++)
					{
						if (AddMapFromJson<T>(controllerId, jsonStrings[i]))
						{
							num++;
						}
					}
					return num;
				}

				public int AddMapsFromJson(ControllerType controllerType, int controllerId, List<string> jsonStrings)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (jsonStrings == null)
					{
						return 0;
					}
					int num = 0;
					for (int i = 0; i < jsonStrings.Count; i++)
					{
						if (AddMapFromJson(controllerType, controllerId, jsonStrings[i]))
						{
							num++;
						}
					}
					return num;
				}

				public void AddEmptyMap<T>(int controllerId, int categoryId, int layoutId) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						qzrErZgLkkjcxaaTEYtBsCvNnIDh(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), controllerId, categoryId, layoutId);
					}
				}

				public void AddEmptyMap<T>(int controllerId, string categoryName, string layoutName) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						qzrErZgLkkjcxaaTEYtBsCvNnIDh(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), controllerId, categoryName, layoutName);
					}
				}

				public void AddEmptyMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						qzrErZgLkkjcxaaTEYtBsCvNnIDh(controllerType, controllerId, categoryId, layoutId);
					}
				}

				public void AddEmptyMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					int layoutId = ReInput.mapping.GetLayoutId(controllerType, layoutName);
					if (mapCategoryId >= 0 && layoutId >= 0)
					{
						AddEmptyMap(controllerType, controllerId, mapCategoryId, layoutId);
					}
				}

				public void RemoveMap<T>(int controllerId, int mapId) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else if (mapId >= 0)
					{
						SwgMOFoAxscYtpDGxAebEKHJGTJN(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), controllerId, mapId);
					}
				}

				public void RemoveMap<T>(int controllerId, int categoryId, int layoutId) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else if (categoryId >= 0 && layoutId >= 0)
					{
						SwgMOFoAxscYtpDGxAebEKHJGTJN(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), controllerId, categoryId, layoutId);
					}
				}

				public void RemoveMap<T>(int controllerId, string categoryName, string layoutName) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						SwgMOFoAxscYtpDGxAebEKHJGTJN(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), controllerId, categoryName, layoutName);
					}
				}

				public void RemoveMap(ControllerType controllerType, int controllerId, int mapId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else if (mapId >= 0)
					{
						SwgMOFoAxscYtpDGxAebEKHJGTJN(controllerType, controllerId, mapId);
					}
				}

				public void RemoveMap(ControllerType controllerType, int controllerId, int categoryId, int layoutId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else if (categoryId >= 0 && layoutId >= 0)
					{
						SwgMOFoAxscYtpDGxAebEKHJGTJN(controllerType, controllerId, categoryId, layoutId);
					}
				}

				public void RemoveMap(ControllerType controllerType, int controllerId, string categoryName, string layoutName)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						SwgMOFoAxscYtpDGxAebEKHJGTJN(controllerType, controllerId, categoryName, layoutName);
					}
				}

				public void ClearMaps<T>(bool userAssignableOnly) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						ClearMaps(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), userAssignableOnly);
					}
				}

				public void ClearMaps(ControllerType controllerType, bool userAssignableOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
					for (int i = 0; i < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.LlCkzvOeJVaCziTDPktzBWuYotAZ(userAssignableOnly);
					}
				}

				public void ClearMapsInCategory<T>(int categoryId, bool userAssignableOnly) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						ClearMapsInCategory(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), categoryId, userAssignableOnly);
					}
				}

				public void ClearMapsInCategory<T>(string categoryName, bool userAssignableOnly) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId >= 0)
					{
						ClearMapsInCategory<T>(mapCategoryId, userAssignableOnly);
					}
				}

				public void ClearMapsInCategory<T>(int categoryId, int layoutId, bool userAssignableOnly) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						ClearMapsInCategory(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), categoryId, layoutId, userAssignableOnly);
					}
				}

				public void ClearMapsInCategory<T>(string categoryName, string layoutName, bool userAssignableOnly) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId >= 0)
					{
						int layoutId = ReInput.mapping.GetLayoutId(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), layoutName);
						if (layoutId >= 0)
						{
							ClearMapsInCategory<T>(mapCategoryId, layoutId, userAssignableOnly);
						}
					}
				}

				public void ClearMapsInCategory(int categoryId, bool userAssignableOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.HurpQuBFJuSAymgLzSdtczYvHZA(i));
						for (int j = 0; j < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; j++)
						{
							uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(j).JYKAxzbcwrkvXFkdyALvVdvpDkeE.LlCkzvOeJVaCziTDPktzBWuYotAZ(categoryId, userAssignableOnly);
						}
					}
				}

				public void ClearMapsInCategory(string categoryName, bool userAssignableOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId >= 0)
					{
						ClearMapsInCategory(mapCategoryId, userAssignableOnly);
					}
				}

				public void ClearMapsInCategory(ControllerType controllerType, int categoryId, bool userAssignableOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
					for (int i = 0; i < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.LlCkzvOeJVaCziTDPktzBWuYotAZ(categoryId, userAssignableOnly);
					}
				}

				public void ClearMapsInCategory(ControllerType controllerType, string categoryName, bool userAssignableOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId >= 0)
					{
						ClearMapsInCategory(controllerType, mapCategoryId, userAssignableOnly);
					}
				}

				public void ClearMapsInCategory(ControllerType controllerType, int categoryId, int layoutId, bool userAssignableOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					InputCategory mapCategory = ReInput.mapping.GetMapCategory(categoryId);
					if (mapCategory != null && (!userAssignableOnly || mapCategory.userAssignable))
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
						for (int i = 0; i < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
						{
							uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.vtEeJHlHmADXshapyyaNEbLgpF(categoryId, layoutId);
						}
					}
				}

				public void ClearMapsInCategory(ControllerType controllerType, string categoryName, string layoutName, bool userAssignableOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId >= 0)
					{
						int layoutId = ReInput.mapping.GetLayoutId(controllerType, layoutName);
						if (layoutId >= 0)
						{
							ClearMapsInCategory(controllerType, mapCategoryId, layoutId, userAssignableOnly);
						}
					}
				}

				public void ClearMapsInLayout<T>(int layoutId, bool userAssignableOnly) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						ClearMapsInLayout(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), layoutId, userAssignableOnly);
					}
				}

				public void ClearMapsInLayout<T>(string layoutName, bool userAssignableOnly) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					int layoutId = ReInput.mapping.GetLayoutId(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), layoutName);
					if (layoutId >= 0)
					{
						ClearMapsInLayout<T>(layoutId, userAssignableOnly);
					}
				}

				public void ClearMapsInLayout(ControllerType controllerType, int layoutId, bool userAssignableOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
					for (int i = 0; i < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.OTonngefigalGOakeHwTFwQXTDI(layoutId, userAssignableOnly);
					}
				}

				public void ClearMapsInLayout(ControllerType controllerType, string layoutName, bool userAssignableOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					int layoutId = ReInput.mapping.GetLayoutId(controllerType, layoutName);
					if (layoutId >= 0)
					{
						ClearMapsInLayout(controllerType, layoutId, userAssignableOnly);
					}
				}

				public void ClearMapsForController<T>(int controllerId, bool userAssignableOnly) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						ClearMapsForController(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), controllerId, userAssignableOnly);
					}
				}

				public void ClearMapsForController<T>(int controllerId, int categoryId, bool userAssignableOnly) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						ClearMapsForController(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), controllerId, categoryId, userAssignableOnly);
					}
				}

				public void ClearMapsForController<T>(int controllerId, string categoryName, bool userAssignableOnly) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId >= 0)
					{
						ClearMapsForController<T>(controllerId, mapCategoryId, userAssignableOnly);
					}
				}

				public void ClearMapsForController(ControllerType controllerType, int controllerId, bool userAssignableOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(controllerId);
					if (num >= 0)
					{
						uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.LlCkzvOeJVaCziTDPktzBWuYotAZ(userAssignableOnly);
					}
				}

				public void ClearMapsForController(ControllerType controllerType, int controllerId, int categoryId, bool userAssignableOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(controllerId);
					if (num >= 0)
					{
						uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.LlCkzvOeJVaCziTDPktzBWuYotAZ(categoryId, userAssignableOnly);
					}
				}

				public void ClearMapsForController(ControllerType controllerType, int controllerId, string categoryName, bool userAssignableOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId >= 0)
					{
						ClearMapsForController(controllerType, controllerId, mapCategoryId, userAssignableOnly);
					}
				}

				public void ClearMapsForControllerInLayout<T>(int controllerId, int layoutId, bool userAssignableOnly) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						ClearMapsForControllerInLayout(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), controllerId, layoutId, userAssignableOnly);
					}
				}

				public void ClearMapsForControllerInLayout<T>(int controllerId, string layoutName, bool userAssignableOnly) where T : ControllerMap
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					int layoutId = ReInput.mapping.GetLayoutId(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>(), layoutName);
					if (layoutId >= 0)
					{
						ClearMapsForControllerInLayout<T>(controllerId, layoutId, userAssignableOnly);
					}
				}

				public void ClearMapsForControllerInLayout(ControllerType controllerType, int controllerId, int layoutId, bool userAssignableOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(controllerId);
					if (num >= 0)
					{
						uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.OTonngefigalGOakeHwTFwQXTDI(layoutId, userAssignableOnly);
					}
				}

				public void ClearMapsForControllerInLayout(ControllerType controllerType, int controllerId, string layoutName, bool userAssignableOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					int layoutId = ReInput.mapping.GetLayoutId(controllerType, layoutName);
					if (layoutId >= 0)
					{
						ClearMapsForControllerInLayout(controllerType, controllerId, layoutId, userAssignableOnly);
					}
				}

				public void ClearAllMaps(bool userAssignableOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ClearMaps(mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.HurpQuBFJuSAymgLzSdtczYvHZA(i), userAssignableOnly);
					}
				}

				public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps)
				{
					return GetFirstButtonMapWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionId, skipDisabledMaps);
				}

				public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps)
				{
					return GetFirstButtonMapWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionName, skipDisabledMaps);
				}

				public ActionElementMap GetFirstButtonMapWithAction(Controller controller, int actionId, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					if (controller == null)
					{
						return null;
					}
					return ZALpiOOzwPSnWFxHgyKxuRjQcgg(controller.type, controller.id, actionId, skipDisabledMaps);
				}

				public ActionElementMap GetFirstButtonMapWithAction(Controller controller, string actionName, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return GetFirstButtonMapWithAction(controller, actionId, skipDisabledMaps);
				}

				public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return ZALpiOOzwPSnWFxHgyKxuRjQcgg(controllerType, actionId, skipDisabledMaps);
				}

				public ActionElementMap GetFirstButtonMapWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return GetFirstButtonMapWithAction(controllerType, actionId, skipDisabledMaps);
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
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ActionElementMap actionElementMap = ZALpiOOzwPSnWFxHgyKxuRjQcgg(mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.HurpQuBFJuSAymgLzSdtczYvHZA(i), actionId, skipDisabledMaps);
						if (actionElementMap != null)
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

				public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps)
				{
					return ButtonMapsWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionId, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps)
				{
					return ButtonMapsWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionName, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> ButtonMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
					}
					if (controller == null)
					{
						return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
					}
					return tTQSLQLEvVEwQMofXXCmoOPosI(controller.type, controller.id, actionId, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> ButtonMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return ButtonMapsWithAction(controller, actionId, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
					}
					return tTQSLQLEvVEwQMofXXCmoOPosI(controllerType, actionId, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> ButtonMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return ButtonMapsWithAction(controllerType, actionId, skipDisabledMaps);
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
						int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
						{
							UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(i);
							int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
							for (int j = 0; j < count; j++)
							{
								SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(j).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
								int count2 = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
								for (int k = 0; k < count2; k++)
								{
									ControllerMap controllerMap = mapSet.get_Item(k);
									if ((skipDisabledMaps && !controllerMap.enabled) || !controllerMap.ContainsAction(actionId))
									{
										continue;
									}
									foreach (ActionElementMap item in controllerMap.ButtonMapsWithAction(actionId, skipDisabledMaps))
									{
										yield return item;
									}
								}
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

				public int GetButtonMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return GetButtonMapsWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionId, skipDisabledMaps, results);
				}

				public int GetButtonMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return GetButtonMapsWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionName, skipDisabledMaps, results);
				}

				public int GetButtonMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
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
					if (controller == null)
					{
						results.Clear();
						return 0;
					}
					return nXCwgMLEVQlISylqZWJsFapDSOC(controller.type, controller.id, actionId, skipDisabledMaps, results, false);
				}

				public int GetButtonMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return GetButtonMapsWithAction(controller, actionId, skipDisabledMaps, results);
				}

				public int GetButtonMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					return nXCwgMLEVQlISylqZWJsFapDSOC(controllerType, actionId, skipDisabledMaps, results, false);
				}

				public int GetButtonMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return GetButtonMapsWithAction(controllerType, actionId, skipDisabledMaps, results);
				}

				public int GetButtonMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return OkcRCEckXtWYjyMQBguTtVlxtFz(actionId, skipDisabledMaps, results, false);
				}

				public int GetButtonMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return GetButtonMapsWithAction(actionId, skipDisabledMaps, results);
				}

				public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps)
				{
					return GetFirstAxisMapWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionId, skipDisabledMaps);
				}

				public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps)
				{
					return GetFirstAxisMapWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionName, skipDisabledMaps);
				}

				public ActionElementMap GetFirstAxisMapWithAction(Controller controller, int actionId, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					if (controller == null)
					{
						return null;
					}
					return ZwVYuPRaWETiuzqIcTkJwRcigxE(controller.type, controller.id, actionId, skipDisabledMaps);
				}

				public ActionElementMap GetFirstAxisMapWithAction(Controller controller, string actionName, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return GetFirstAxisMapWithAction(controller, actionId, skipDisabledMaps);
				}

				public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return ZwVYuPRaWETiuzqIcTkJwRcigxE(controllerType, actionId, skipDisabledMaps);
				}

				public ActionElementMap GetFirstAxisMapWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return GetFirstAxisMapWithAction(controllerType, actionId, skipDisabledMaps);
				}

				public ActionElementMap GetFirstAxisMapWithAction(int actionId, bool skipDisabledMaps)
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
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ActionElementMap actionElementMap = ZwVYuPRaWETiuzqIcTkJwRcigxE(mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.HurpQuBFJuSAymgLzSdtczYvHZA(i), actionId, skipDisabledMaps);
						if (actionElementMap != null)
						{
							return actionElementMap;
						}
					}
					return null;
				}

				public ActionElementMap GetFirstAxisMapWithAction(string actionName, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return GetFirstAxisMapWithAction(actionId, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps)
				{
					return AxisMapsWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionId, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps)
				{
					return AxisMapsWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionName, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> AxisMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
					}
					if (controller == null)
					{
						return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
					}
					return mTiMOfxcIghkjNwYZYXMWUNjNbf(controller.type, controller.id, actionId, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> AxisMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return AxisMapsWithAction(controller, actionId, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
					}
					return mTiMOfxcIghkjNwYZYXMWUNjNbf(controllerType, actionId, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> AxisMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return AxisMapsWithAction(controllerType, actionId, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> AxisMapsWithAction(int actionId, bool skipDisabledMaps)
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
						int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
						{
							UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(i);
							int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
							for (int j = 0; j < count; j++)
							{
								SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(j).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
								int count2 = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
								for (int k = 0; k < count2; k++)
								{
									if (!(mapSet.get_Item(k) is ControllerMapWithAxes controllerMapWithAxes) || (skipDisabledMaps && !controllerMapWithAxes.enabled) || !controllerMapWithAxes.ContainsAction(actionId))
									{
										continue;
									}
									foreach (ActionElementMap item in controllerMapWithAxes.AxisMapsWithAction(actionId, skipDisabledMaps))
									{
										yield return item;
									}
								}
							}
						}
					}
				}

				public IEnumerable<ActionElementMap> AxisMapsWithAction(string actionName, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return AxisMapsWithAction(actionId, skipDisabledMaps);
				}

				public int GetAxisMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return GetAxisMapsWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionId, skipDisabledMaps, results);
				}

				public int GetAxisMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return GetAxisMapsWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionName, skipDisabledMaps, results);
				}

				public int GetAxisMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (controller == null)
					{
						return 0;
					}
					return EdYurEaPxANGkQlhgakABEMNMuK(controller.type, controller.id, actionId, skipDisabledMaps, results, false);
				}

				public int GetAxisMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return GetAxisMapsWithAction(controller, actionId, skipDisabledMaps, results);
				}

				public int GetAxisMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
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
					return EdYurEaPxANGkQlhgakABEMNMuK(controllerType, actionId, skipDisabledMaps, results, false);
				}

				public int GetAxisMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return GetAxisMapsWithAction(controllerType, actionId, skipDisabledMaps, results);
				}

				public int GetAxisMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return AFEuEUDCsmGMceBQdrVoJZTKsBP(actionId, skipDisabledMaps, results, false);
				}

				public int GetAxisMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return GetAxisMapsWithAction(actionId, skipDisabledMaps, results);
				}

				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps)
				{
					return GetFirstElementMapWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionId, skipDisabledMaps);
				}

				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps)
				{
					return GetFirstElementMapWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionName, skipDisabledMaps);
				}

				public ActionElementMap GetFirstElementMapWithAction(Controller controller, int actionId, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					if (controller == null)
					{
						return null;
					}
					return TWvjxgjJVFGCdFiIwioqZvaQHTs(controller.type, controller.id, actionId, skipDisabledMaps);
				}

				public ActionElementMap GetFirstElementMapWithAction(Controller controller, string actionName, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return GetFirstElementMapWithAction(controller, actionId, skipDisabledMaps);
				}

				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return TWvjxgjJVFGCdFiIwioqZvaQHTs(controllerType, actionId, skipDisabledMaps);
				}

				public ActionElementMap GetFirstElementMapWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return GetFirstElementMapWithAction(controllerType, actionId, skipDisabledMaps);
				}

				public ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps)
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
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ActionElementMap actionElementMap = TWvjxgjJVFGCdFiIwioqZvaQHTs(mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.HurpQuBFJuSAymgLzSdtczYvHZA(i), actionId, skipDisabledMaps);
						if (actionElementMap != null)
						{
							return actionElementMap;
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

				public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps)
				{
					return ElementMapsWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionId, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps)
				{
					return ElementMapsWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionName, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> ElementMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
					}
					if (controller == null)
					{
						return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
					}
					return uTxjyvtbIHExPZSfbMyeEZghtdm(controller.type, controller.id, actionId, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> ElementMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return ElementMapsWithAction(controller, actionId, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
					}
					return uTxjyvtbIHExPZSfbMyeEZghtdm(controllerType, actionId, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> ElementMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return ElementMapsWithAction(controllerType, actionId, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId, bool skipDisabledMaps)
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
						int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
						{
							UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(i);
							int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
							for (int j = 0; j < count; j++)
							{
								SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(j).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
								int count2 = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
								for (int k = 0; k < count2; k++)
								{
									ControllerMap controllerMap = mapSet.get_Item(k);
									if ((skipDisabledMaps && !controllerMap.enabled) || !controllerMap.ContainsAction(actionId))
									{
										continue;
									}
									foreach (ActionElementMap item in controllerMap.ElementMapsWithAction(actionId, skipDisabledMaps))
									{
										yield return item;
									}
								}
							}
						}
					}
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

				public int GetElementMapsWithAction(ControllerType controllerType, int controllerId, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return GetElementMapsWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionId, skipDisabledMaps, results);
				}

				public int GetElementMapsWithAction(ControllerType controllerType, int controllerId, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return GetElementMapsWithAction(ReInput.controllers.GetController(controllerType, controllerId), actionName, skipDisabledMaps, results);
				}

				public int GetElementMapsWithAction(Controller controller, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (controller == null)
					{
						return 0;
					}
					return KQScfgHqtRAiyiRXpGyUgvDcgJfK(controller.type, controller.id, actionId, skipDisabledMaps, results, false);
				}

				public int GetElementMapsWithAction(Controller controller, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return GetElementMapsWithAction(controller, actionId, skipDisabledMaps, results);
				}

				public int GetElementMapsWithAction(ControllerType controllerType, int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					return KQScfgHqtRAiyiRXpGyUgvDcgJfK(controllerType, actionId, skipDisabledMaps, results, false);
				}

				public int GetElementMapsWithAction(ControllerType controllerType, string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
					return GetElementMapsWithAction(controllerType, actionId, skipDisabledMaps, results);
				}

				public int GetElementMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
				{
					return hHAktoEzTjklPLyzcjMCfmqeriO(actionId, skipDisabledMaps, results, false);
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
					return inrTpaIDLKazOABUOxfZHUsLAjp(elementTarget, false, -1, skipDisabledMaps);
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
					return inrTpaIDLKazOABUOxfZHUsLAjp(elementTarget, true, actionId, skipDisabledMaps);
				}

				public IEnumerable<ActionElementMap> ElementMapsWithElementTarget(IControllerElementTarget elementTarget, string actionName, bool skipDisabledMaps)
				{
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
					return VfcfyKNKnGeUcaZTKcbxEoucaoFO(elementTarget, false, -1, skipDisabledMaps);
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
					return VfcfyKNKnGeUcaZTKcbxEoucaoFO(elementTarget, true, actionId, skipDisabledMaps);
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
					return JzTnuZQPeJZpOCUTrCSLHdIycSYG(elementTarget, false, -1, skipDisabledMaps, results, false);
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
					return JzTnuZQPeJZpOCUTrCSLHdIycSYG(elementTarget, true, actionId, skipDisabledMaps, results, false);
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

				public T[] GetMapSaveData<T>(int controllerId, bool userAssignableMapsOnly) where T : ControllerMapSaveData
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<T>.array;
					}
					return wOIfCFwBMIlUHlvQdEwJOXrwCck<T>(controllerId, userAssignableMapsOnly);
				}

				public ControllerMapSaveData[] GetMapSaveData(ControllerType controllerType, int controllerId, bool userAssignableMapsOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerMapSaveData>.array;
					}
					return wOIfCFwBMIlUHlvQdEwJOXrwCck(controllerType, controllerId, userAssignableMapsOnly);
				}

				public T[] GetAllMapSaveData<T>(bool userAssignableMapsOnly) where T : ControllerMapSaveData
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<T>.array;
					}
					return gwQuaLzMMCtouBScPEmCKgSGhXZ<T>(userAssignableMapsOnly);
				}

				public ControllerMapSaveData[] GetAllMapSaveData(ControllerType controllerType, bool userAssignableMapsOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerMapSaveData>.array;
					}
					return gwQuaLzMMCtouBScPEmCKgSGhXZ(controllerType, userAssignableMapsOnly);
				}

				public ControllerMapSaveData[] GetAllMapSaveData(bool userAssignableMapsOnly)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerMapSaveData>.array;
					}
					ControllerMapSaveData[] array = null;
					for (int i = 0; i < mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ArrayTools.Combine(ref array, gwQuaLzMMCtouBScPEmCKgSGhXZ(mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.HurpQuBFJuSAymgLzSdtczYvHZA(i), userAssignableMapsOnly));
					}
					return array;
				}

				public int SetAllMapsEnabled(bool state)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					int num = 0;
					int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(i);
						int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int j = 0; j < count; j++)
						{
							num += uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(j).JYKAxzbcwrkvXFkdyALvVdvpDkeE.BXCVTXRPqBzWnvVySOITdqalcAC(state);
						}
					}
					return num;
				}

				public int SetAllMapsEnabled(bool state, ControllerType controllerType)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					int num = 0;
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
					int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < count; i++)
					{
						num += uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.BXCVTXRPqBzWnvVySOITdqalcAC(state);
					}
					return num;
				}

				public int SetAllMapsEnabled(bool state, Controller controller)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (controller == null)
					{
						return 0;
					}
					return SetAllMapsEnabled(state, controller.type, controller.id);
				}

				public int SetAllMapsEnabled(bool state, ControllerType controllerType, int controllerId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType).UHzLoQtWuAoHLAFsVljNrYZrrEC(controllerId)?.JYKAxzbcwrkvXFkdyALvVdvpDkeE.BXCVTXRPqBzWnvVySOITdqalcAC(state) ?? 0;
				}

				public int SetMapsEnabled(bool state, int categoryId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (categoryId < 0)
					{
						return 0;
					}
					int num = 0;
					int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(i);
						int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int j = 0; j < count; j++)
						{
							num += uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(j).JYKAxzbcwrkvXFkdyALvVdvpDkeE.QEiKIcbGpRqgPghMWSHkHLebqY(state, categoryId);
						}
					}
					return num;
				}

				public int SetMapsEnabled(bool state, string categoryName)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return 0;
					}
					return SetMapsEnabled(state, mapCategoryId);
				}

				public int SetMapsEnabled(bool state, string categoryName, string layoutName)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return 0;
					}
					int num = 0;
					int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ControllerType controllerType = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.HurpQuBFJuSAymgLzSdtczYvHZA(i);
						int layoutId = ReInput.mapping.GetLayoutId(controllerType, layoutName);
						if (layoutId >= 0)
						{
							num += SetMapsEnabled(state, controllerType, mapCategoryId, layoutId);
						}
					}
					return num;
				}

				public int SetMapsEnabled(bool state, ControllerType controllerType, int categoryId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (categoryId < 0)
					{
						return 0;
					}
					int num = 0;
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
					int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < count; i++)
					{
						num += uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.QEiKIcbGpRqgPghMWSHkHLebqY(state, categoryId);
					}
					return num;
				}

				public int SetMapsEnabled(bool state, ControllerType controllerType, string categoryName)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return 0;
					}
					return SetMapsEnabled(state, controllerType, mapCategoryId);
				}

				public int SetMapsEnabled(bool state, ControllerType controllerType, int categoryId, int layoutId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (categoryId < 0 || layoutId < 0)
					{
						return 0;
					}
					int num = 0;
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
					int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < count; i++)
					{
						num += uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.QEiKIcbGpRqgPghMWSHkHLebqY(state, categoryId, layoutId);
					}
					return num;
				}

				public int SetMapsEnabled(bool state, ControllerType controllerType, string categoryName, string layoutName)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return 0;
					}
					int layoutId = ReInput.mapping.GetLayoutId(controllerType, layoutName);
					if (layoutId < 0)
					{
						return 0;
					}
					return SetMapsEnabled(state, controllerType, mapCategoryId, layoutId);
				}

				public int SetMapsEnabled(bool state, Controller controller, int categoryId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (controller == null)
					{
						return 0;
					}
					if (categoryId < 0)
					{
						return 0;
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controller.type).UHzLoQtWuAoHLAFsVljNrYZrrEC(controller.id)?.JYKAxzbcwrkvXFkdyALvVdvpDkeE.QEiKIcbGpRqgPghMWSHkHLebqY(state, categoryId) ?? 0;
				}

				public int SetMapsEnabled(bool state, Controller controller, int categoryId, int layoutId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (controller == null)
					{
						return 0;
					}
					if (categoryId < 0)
					{
						return 0;
					}
					if (layoutId < 0)
					{
						return 0;
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controller.type).UHzLoQtWuAoHLAFsVljNrYZrrEC(controller.id)?.JYKAxzbcwrkvXFkdyALvVdvpDkeE.QEiKIcbGpRqgPghMWSHkHLebqY(state, categoryId, layoutId) ?? 0;
				}

				public int SetMapsEnabled(bool state, Controller controller, string categoryName)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (controller == null)
					{
						return 0;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return 0;
					}
					return SetMapsEnabled(state, controller, mapCategoryId);
				}

				public int SetMapsEnabled(bool state, Controller controller, string categoryName, string layoutName)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					if (controller == null)
					{
						return 0;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return 0;
					}
					int layoutId = ReInput.mapping.GetLayoutId(controller.type, layoutName);
					if (layoutId < 0)
					{
						return 0;
					}
					return SetMapsEnabled(state, controller, mapCategoryId, layoutId);
				}

				public void LoadDefaultMaps(ControllerType controllerType)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return;
					}
					switch (controllerType)
					{
					case ControllerType.Joystick:
						DhDBOvcvAUoseQUYhsjqldnkxND(false);
						break;
					case ControllerType.Keyboard:
						pdsPntvZRmLdnPXkPsrHZHwBQMd(false);
						break;
					case ControllerType.Mouse:
						iDfbghcMlaGnlCtgBDgFLIJpUkWG(false);
						break;
					case ControllerType.Custom:
						BCvDmFqukWcMifalmAMVJyVijlc(false);
						break;
					default:
						throw new NotImplementedException();
					}
				}

				public bool ContainsMapInCategory(InputMapCategory category)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					if (category == null)
					{
						return false;
					}
					return ContainsMapInCategory(category.id);
				}

				public bool ContainsMapInCategory(int categoryId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					if (categoryId < 0)
					{
						return false;
					}
					int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(i);
						int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int j = 0; j < count; j++)
						{
							if (uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(j).JYKAxzbcwrkvXFkdyALvVdvpDkeE.lDRNRnNQjErzROwpybhvIlvFjmK(categoryId))
							{
								return true;
							}
						}
					}
					return false;
				}

				public bool ContainsMapInCategory(string categoryName)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(categoryName);
					if (mapCategoryId < 0)
					{
						return false;
					}
					return ContainsMapInCategory(mapCategoryId);
				}

				public bool ContainsMapInCategory(ControllerType controllerType, int categoryId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					if (categoryId < 0)
					{
						return false;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
					int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < count; i++)
					{
						if (uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.lDRNRnNQjErzROwpybhvIlvFjmK(categoryId))
						{
							return true;
						}
					}
					return false;
				}

				public InputBehavior GetInputBehavior(int behaviorId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return QFlXjfmiJabcsMblLziegHSMCLfJ.mvrCdGRIOFGaMUOTuzwAwqCUSAr.phwbKHKomUfIkFaLFXJBEZIqWcnG(QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri, behaviorId);
				}

				public InputBehavior GetInputBehavior(string behaviorName)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return QFlXjfmiJabcsMblLziegHSMCLfJ.mvrCdGRIOFGaMUOTuzwAwqCUSAr.phwbKHKomUfIkFaLFXJBEZIqWcnG(QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri, behaviorName);
				}

				internal void ijQPrfbohIDtyfCSvLMVhrlmSpB()
				{
					EGgKASJhLqAeBBLgAmtBWBjevfmg.LoadDefaults();
					arlWAVyKcDIOfecrFqGgsdeCzdlj.LoadDefaults();
				}

				internal void DhDBOvcvAUoseQUYhsjqldnkxND(bool P_0)
				{
					if (QIllBbwNoyeVMhiueNkitOxjwEjn.BCeAEnwaTgoPNwjzESyWkIAmOGk == null)
					{
						return;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Joystick);
					mQXiYotjnToDecfWIRfktslJAMQ.tWaggyJPBcRxwyAUFZkujNIcHgO.NPuccIFRsBNSlpfFXLwIuObSBNP();
					int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < count; i++)
					{
						IcESaAjemNGWngcrzWaBSsruFXF<Joystick, JoystickMap>.eQaARQwlcakzPaJCLRZmbjzCHZE eQaARQwlcakzPaJCLRZmbjzCHZE = (IcESaAjemNGWngcrzWaBSsruFXF<Joystick, JoystickMap>.eQaARQwlcakzPaJCLRZmbjzCHZE)uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i);
						bool[] array = null;
						if (!P_0)
						{
							int count2 = eQaARQwlcakzPaJCLRZmbjzCHZE.JYKAxzbcwrkvXFkdyALvVdvpDkeE.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
							array = new bool[count2];
							for (int j = 0; j < count2; j++)
							{
								array[j] = eQaARQwlcakzPaJCLRZmbjzCHZE.JYKAxzbcwrkvXFkdyALvVdvpDkeE.get_Item(j).enabled;
							}
						}
						eQaARQwlcakzPaJCLRZmbjzCHZE.JYKAxzbcwrkvXFkdyALvVdvpDkeE.LlCkzvOeJVaCziTDPktzBWuYotAZ(false);
						for (int k = 0; k < QIllBbwNoyeVMhiueNkitOxjwEjn.BCeAEnwaTgoPNwjzESyWkIAmOGk.Length; k++)
						{
							MWaBAbJrTDYtrkTTmKlnYwvpGGLN(eQaARQwlcakzPaJCLRZmbjzCHZE.TWofsWdWcZrFDlgktqaiXknQuRD, eQaARQwlcakzPaJCLRZmbjzCHZE.JYKAxzbcwrkvXFkdyALvVdvpDkeE, QIllBbwNoyeVMhiueNkitOxjwEjn.BCeAEnwaTgoPNwjzESyWkIAmOGk[k], P_0);
						}
						if (!P_0)
						{
							int num = MathTools.Min(array.Length, eQaARQwlcakzPaJCLRZmbjzCHZE.JYKAxzbcwrkvXFkdyALvVdvpDkeE.ioXgUGjpFGeVuGnqwbPHBeKgnSzF);
							for (int l = 0; l < num; l++)
							{
								eQaARQwlcakzPaJCLRZmbjzCHZE.JYKAxzbcwrkvXFkdyALvVdvpDkeE.get_Item(l).enabled = array[l];
							}
						}
					}
					bool loadFromUserDataStore = arlWAVyKcDIOfecrFqGgsdeCzdlj.loadFromUserDataStore;
					arlWAVyKcDIOfecrFqGgsdeCzdlj.loadFromUserDataStore = false;
					arlWAVyKcDIOfecrFqGgsdeCzdlj.Apply();
					arlWAVyKcDIOfecrFqGgsdeCzdlj.loadFromUserDataStore = loadFromUserDataStore;
				}

				internal void pdsPntvZRmLdnPXkPsrHZHwBQMd(bool P_0)
				{
					if (QIllBbwNoyeVMhiueNkitOxjwEjn.sBcEYtZdisINNkSpjKGClznojmn == null)
					{
						return;
					}
					SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Keyboard).UHzLoQtWuAoHLAFsVljNrYZrrEC(0).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
					bool[] array = null;
					if (!P_0)
					{
						int count = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						array = new bool[count];
						for (int i = 0; i < count; i++)
						{
							array[i] = mapSet.get_Item(i).enabled;
						}
					}
					mapSet.LlCkzvOeJVaCziTDPktzBWuYotAZ(false);
					for (int j = 0; j < QIllBbwNoyeVMhiueNkitOxjwEjn.sBcEYtZdisINNkSpjKGClznojmn.Length; j++)
					{
						dCUflXNeHsiDyiuKKNnJFvASoHlm dCUflXNeHsiDyiuKKNnJFvASoHlm = QIllBbwNoyeVMhiueNkitOxjwEjn.sBcEYtZdisINNkSpjKGClznojmn[j];
						if (dCUflXNeHsiDyiuKKNnJFvASoHlm.XpPUivfNiXIrmjJxnEyEsuVuHXHG >= 0 && dCUflXNeHsiDyiuKKNnJFvASoHlm.EQrDjbDCmnkGXFLBDIMWazThJSij >= 0)
						{
							KeyboardMap keyboardMap = ReInput.UserData.FindKeyboardMap_Game(ReInput.controllers.Keyboard, dCUflXNeHsiDyiuKKNnJFvASoHlm.XpPUivfNiXIrmjJxnEyEsuVuHXHG, dCUflXNeHsiDyiuKKNnJFvASoHlm.EQrDjbDCmnkGXFLBDIMWazThJSij);
							if (P_0)
							{
								keyboardMap.enabled = dCUflXNeHsiDyiuKKNnJFvASoHlm.ymsUnVrtgSJhBqqpdBJTGKspcCtS;
							}
							RSGDYijTcBxQgPcPkRoVLjUqYcZ(ControllerType.Keyboard, 0, keyboardMap, BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
						}
					}
					if (!P_0)
					{
						int num = MathTools.Min(array.Length, mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF);
						for (int k = 0; k < num; k++)
						{
							mapSet.get_Item(k).enabled = array[k];
						}
					}
					bool loadFromUserDataStore = arlWAVyKcDIOfecrFqGgsdeCzdlj.loadFromUserDataStore;
					arlWAVyKcDIOfecrFqGgsdeCzdlj.loadFromUserDataStore = false;
					arlWAVyKcDIOfecrFqGgsdeCzdlj.Apply();
					arlWAVyKcDIOfecrFqGgsdeCzdlj.loadFromUserDataStore = loadFromUserDataStore;
				}

				internal void iDfbghcMlaGnlCtgBDgFLIJpUkWG(bool P_0)
				{
					if (QIllBbwNoyeVMhiueNkitOxjwEjn.gsyFIgjEWBfUzDZWeNlidoekxaQt == null)
					{
						return;
					}
					SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Mouse).UHzLoQtWuAoHLAFsVljNrYZrrEC(0).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
					bool[] array = null;
					if (!P_0)
					{
						int count = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						array = new bool[count];
						for (int i = 0; i < count; i++)
						{
							array[i] = mapSet.get_Item(i).enabled;
						}
					}
					mapSet.LlCkzvOeJVaCziTDPktzBWuYotAZ(false);
					for (int j = 0; j < QIllBbwNoyeVMhiueNkitOxjwEjn.gsyFIgjEWBfUzDZWeNlidoekxaQt.Length; j++)
					{
						dCUflXNeHsiDyiuKKNnJFvASoHlm dCUflXNeHsiDyiuKKNnJFvASoHlm = QIllBbwNoyeVMhiueNkitOxjwEjn.gsyFIgjEWBfUzDZWeNlidoekxaQt[j];
						if (dCUflXNeHsiDyiuKKNnJFvASoHlm.XpPUivfNiXIrmjJxnEyEsuVuHXHG >= 0 && dCUflXNeHsiDyiuKKNnJFvASoHlm.EQrDjbDCmnkGXFLBDIMWazThJSij >= 0)
						{
							MouseMap mouseMap = ReInput.UserData.FindMouseMap_Game(ReInput.controllers.Mouse, dCUflXNeHsiDyiuKKNnJFvASoHlm.XpPUivfNiXIrmjJxnEyEsuVuHXHG, dCUflXNeHsiDyiuKKNnJFvASoHlm.EQrDjbDCmnkGXFLBDIMWazThJSij);
							if (P_0)
							{
								mouseMap.enabled = dCUflXNeHsiDyiuKKNnJFvASoHlm.ymsUnVrtgSJhBqqpdBJTGKspcCtS;
							}
							RSGDYijTcBxQgPcPkRoVLjUqYcZ(ControllerType.Mouse, 0, mouseMap, BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
						}
					}
					if (!P_0)
					{
						int num = MathTools.Min(array.Length, mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF);
						for (int k = 0; k < num; k++)
						{
							mapSet.get_Item(k).enabled = array[k];
						}
					}
					bool loadFromUserDataStore = arlWAVyKcDIOfecrFqGgsdeCzdlj.loadFromUserDataStore;
					arlWAVyKcDIOfecrFqGgsdeCzdlj.loadFromUserDataStore = false;
					arlWAVyKcDIOfecrFqGgsdeCzdlj.Apply();
					arlWAVyKcDIOfecrFqGgsdeCzdlj.loadFromUserDataStore = loadFromUserDataStore;
				}

				internal void BCvDmFqukWcMifalmAMVJyVijlc(bool P_0)
				{
					if (QIllBbwNoyeVMhiueNkitOxjwEjn.kaxCkmZoSeCDhPYjEKhschttLCI == null)
					{
						return;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Custom);
					int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < count; i++)
					{
						IcESaAjemNGWngcrzWaBSsruFXF<CustomController, CustomControllerMap>.eQaARQwlcakzPaJCLRZmbjzCHZE eQaARQwlcakzPaJCLRZmbjzCHZE = (IcESaAjemNGWngcrzWaBSsruFXF<CustomController, CustomControllerMap>.eQaARQwlcakzPaJCLRZmbjzCHZE)uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i);
						bool[] array = null;
						if (!P_0)
						{
							int count2 = eQaARQwlcakzPaJCLRZmbjzCHZE.JYKAxzbcwrkvXFkdyALvVdvpDkeE.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
							array = new bool[count2];
							for (int j = 0; j < count2; j++)
							{
								array[j] = eQaARQwlcakzPaJCLRZmbjzCHZE.JYKAxzbcwrkvXFkdyALvVdvpDkeE.get_Item(j).enabled;
							}
						}
						eQaARQwlcakzPaJCLRZmbjzCHZE.JYKAxzbcwrkvXFkdyALvVdvpDkeE.LlCkzvOeJVaCziTDPktzBWuYotAZ(false);
						for (int k = 0; k < QIllBbwNoyeVMhiueNkitOxjwEjn.kaxCkmZoSeCDhPYjEKhschttLCI.Length; k++)
						{
							WcVhgRUDrhoNuSIVcqDNdlBMBQj(eQaARQwlcakzPaJCLRZmbjzCHZE.TWofsWdWcZrFDlgktqaiXknQuRD, eQaARQwlcakzPaJCLRZmbjzCHZE.JYKAxzbcwrkvXFkdyALvVdvpDkeE, QIllBbwNoyeVMhiueNkitOxjwEjn.kaxCkmZoSeCDhPYjEKhschttLCI[k], P_0);
						}
						if (!P_0)
						{
							int num = MathTools.Min(array.Length, eQaARQwlcakzPaJCLRZmbjzCHZE.JYKAxzbcwrkvXFkdyALvVdvpDkeE.ioXgUGjpFGeVuGnqwbPHBeKgnSzF);
							for (int l = 0; l < num; l++)
							{
								eQaARQwlcakzPaJCLRZmbjzCHZE.JYKAxzbcwrkvXFkdyALvVdvpDkeE.get_Item(l).enabled = array[l];
							}
						}
					}
					bool loadFromUserDataStore = arlWAVyKcDIOfecrFqGgsdeCzdlj.loadFromUserDataStore;
					arlWAVyKcDIOfecrFqGgsdeCzdlj.loadFromUserDataStore = false;
					arlWAVyKcDIOfecrFqGgsdeCzdlj.Apply();
					arlWAVyKcDIOfecrFqGgsdeCzdlj.loadFromUserDataStore = loadFromUserDataStore;
				}

				private UatpsZKPeFXZcGHRylaqbbrOzNO XnNEpeSUHwYbeEzItDPssHpBWDC<T>() where T : ControllerMap
				{
					return mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>());
				}

				internal global::gHFgzSPsLtKjGAtobRtDQKtpUvu<JoystickMap> coprcYULrnmEHTxIxavieooLEsq(Joystick P_0, bool P_1)
				{
					if (P_0 == null || QIllBbwNoyeVMhiueNkitOxjwEjn.BCeAEnwaTgoPNwjzESyWkIAmOGk == null)
					{
						return null;
					}
					global::gHFgzSPsLtKjGAtobRtDQKtpUvu<JoystickMap> gHFgzSPsLtKjGAtobRtDQKtpUvu = new global::gHFgzSPsLtKjGAtobRtDQKtpUvu<JoystickMap>(P_0.id);
					for (int i = 0; i < QIllBbwNoyeVMhiueNkitOxjwEjn.BCeAEnwaTgoPNwjzESyWkIAmOGk.Length; i++)
					{
						MWaBAbJrTDYtrkTTmKlnYwvpGGLN(P_0, gHFgzSPsLtKjGAtobRtDQKtpUvu, QIllBbwNoyeVMhiueNkitOxjwEjn.BCeAEnwaTgoPNwjzESyWkIAmOGk[i], P_1);
					}
					if (gHFgzSPsLtKjGAtobRtDQKtpUvu.ioXgUGjpFGeVuGnqwbPHBeKgnSzF == 0)
					{
						return null;
					}
					return gHFgzSPsLtKjGAtobRtDQKtpUvu;
				}

				private void MWaBAbJrTDYtrkTTmKlnYwvpGGLN(Joystick P_0, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<JoystickMap> P_1, dCUflXNeHsiDyiuKKNnJFvASoHlm P_2, bool P_3)
				{
					if (P_0 != null && P_2 != null && P_2.XpPUivfNiXIrmjJxnEyEsuVuHXHG >= 0 && P_2.EQrDjbDCmnkGXFLBDIMWazThJSij >= 0)
					{
						JoystickMap joystickMap = ReInput.UserData.DaCIomEMClXMJhjaggiJvZhjxKp(P_0, P_2.XpPUivfNiXIrmjJxnEyEsuVuHXHG, P_2.EQrDjbDCmnkGXFLBDIMWazThJSij);
						qQYfIAJgvloChayYXVFBMdlJuGrp(P_0, joystickMap);
						BoolOption boolOption = BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh;
						if (P_3)
						{
							boolOption = (P_2.ymsUnVrtgSJhBqqpdBJTGKspcCtS ? BoolOption.vfktGKibKwJQmGkXtDsMhiPAPJr : BoolOption.mYTCLYyoUtlUIUYLAaZfeCqHKcW);
						}
						P_1.SxRenVshBREfxhMTnKRbfUFvwoJi(joystickMap, boolOption);
					}
				}

				internal global::gHFgzSPsLtKjGAtobRtDQKtpUvu<CustomControllerMap> nDyFEZHezZGUactAHTwZWHPhhIOE(CustomController P_0, bool P_1)
				{
					if (P_0 == null || QIllBbwNoyeVMhiueNkitOxjwEjn.kaxCkmZoSeCDhPYjEKhschttLCI == null)
					{
						return null;
					}
					global::gHFgzSPsLtKjGAtobRtDQKtpUvu<CustomControllerMap> gHFgzSPsLtKjGAtobRtDQKtpUvu = new global::gHFgzSPsLtKjGAtobRtDQKtpUvu<CustomControllerMap>(P_0.id);
					for (int i = 0; i < QIllBbwNoyeVMhiueNkitOxjwEjn.kaxCkmZoSeCDhPYjEKhschttLCI.Length; i++)
					{
						WcVhgRUDrhoNuSIVcqDNdlBMBQj(P_0, gHFgzSPsLtKjGAtobRtDQKtpUvu, QIllBbwNoyeVMhiueNkitOxjwEjn.kaxCkmZoSeCDhPYjEKhschttLCI[i], P_1);
					}
					if (gHFgzSPsLtKjGAtobRtDQKtpUvu.ioXgUGjpFGeVuGnqwbPHBeKgnSzF == 0)
					{
						return null;
					}
					return gHFgzSPsLtKjGAtobRtDQKtpUvu;
				}

				private void WcVhgRUDrhoNuSIVcqDNdlBMBQj(CustomController P_0, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<CustomControllerMap> P_1, dCUflXNeHsiDyiuKKNnJFvASoHlm P_2, bool P_3)
				{
					if (P_0 != null && P_2 != null && P_2.XpPUivfNiXIrmjJxnEyEsuVuHXHG >= 0 && P_2.EQrDjbDCmnkGXFLBDIMWazThJSij >= 0)
					{
						CustomControllerMap customControllerMap = ReInput.UserData.ktNOMocJCadznhndNYZtJNgVSGi(P_2.XpPUivfNiXIrmjJxnEyEsuVuHXHG, P_0.sourceControllerId, P_2.EQrDjbDCmnkGXFLBDIMWazThJSij);
						qQYfIAJgvloChayYXVFBMdlJuGrp(P_0, customControllerMap);
						BoolOption boolOption = BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh;
						if (P_3)
						{
							boolOption = (P_2.ymsUnVrtgSJhBqqpdBJTGKspcCtS ? BoolOption.vfktGKibKwJQmGkXtDsMhiPAPJr : BoolOption.mYTCLYyoUtlUIUYLAaZfeCqHKcW);
						}
						P_1.SxRenVshBREfxhMTnKRbfUFvwoJi(customControllerMap, boolOption);
					}
				}

				internal void qQYfIAJgvloChayYXVFBMdlJuGrp(Controller P_0, ControllerMap P_1)
				{
					if (P_0 != null && P_1 != null)
					{
						P_1.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
						P_0.qQYfIAJgvloChayYXVFBMdlJuGrp(P_1);
					}
				}

				private IList<T> QOalkbNznfpJKPRRcqLDYCGGZXo<T>(int P_0) where T : ControllerMap
				{
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = XnNEpeSUHwYbeEzItDPssHpBWDC<T>();
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_0);
					if (num < 0)
					{
						return EmptyObjects<T>.EmptyReadOnlyIListT;
					}
					return uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.oUQuEQAgSUASfBxvUZViLorRwfUP<T>();
				}

				private IList<T> QOalkbNznfpJKPRRcqLDYCGGZXo<T>(Controller P_0) where T : ControllerMap
				{
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = XnNEpeSUHwYbeEzItDPssHpBWDC<T>();
					return uatpsZKPeFXZcGHRylaqbbrOzNO.UHzLoQtWuAoHLAFsVljNrYZrrEC(P_0)?.JYKAxzbcwrkvXFkdyALvVdvpDkeE.oUQuEQAgSUASfBxvUZViLorRwfUP<T>();
				}

				private IList<ControllerMap> QOalkbNznfpJKPRRcqLDYCGGZXo(ControllerType P_0, int P_1)
				{
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						return EmptyObjects<ControllerMap>.EmptyReadOnlyIListT;
					}
					return uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
				}

				private IList<ControllerMap> QOalkbNznfpJKPRRcqLDYCGGZXo(Controller P_0)
				{
					return QOalkbNznfpJKPRRcqLDYCGGZXo(P_0.type, P_0.id);
				}

				private void KCoiHPDBfncivsYMtDeuIMbjuAx(ControllerType P_0, int P_1, int P_2, int P_3)
				{
					KCoiHPDBfncivsYMtDeuIMbjuAx(P_0, P_1, P_2, P_3, BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
				}

				private void KCoiHPDBfncivsYMtDeuIMbjuAx(Controller P_0, int P_1, int P_2)
				{
					KCoiHPDBfncivsYMtDeuIMbjuAx(P_0, P_1, P_2, BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
				}

				private void KCoiHPDBfncivsYMtDeuIMbjuAx(ControllerType P_0, int P_1, string P_2, string P_3)
				{
					KCoiHPDBfncivsYMtDeuIMbjuAx(P_0, P_1, P_2, P_3, BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
				}

				private void KCoiHPDBfncivsYMtDeuIMbjuAx(Controller P_0, string P_1, string P_2)
				{
					KCoiHPDBfncivsYMtDeuIMbjuAx(P_0, P_1, P_2, BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
				}

				private void KCoiHPDBfncivsYMtDeuIMbjuAx(ControllerType P_0, int P_1, int P_2, int P_3, BoolOption P_4)
				{
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num >= 0)
					{
						Controller controller = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).TWofsWdWcZrFDlgktqaiXknQuRD;
						ControllerMap controllerMap = ReInput.UserData.eMNDXjeZJyzUonVPAgoxHeuDFqlc(controller, P_2, P_3);
						RSGDYijTcBxQgPcPkRoVLjUqYcZ(controller.type, controller.id, controllerMap, P_4);
					}
				}

				private void KCoiHPDBfncivsYMtDeuIMbjuAx(Controller P_0, int P_1, int P_2, BoolOption P_3)
				{
					KCoiHPDBfncivsYMtDeuIMbjuAx(P_0.type, P_0.id, P_1, P_2, P_3);
				}

				private void KCoiHPDBfncivsYMtDeuIMbjuAx(ControllerType P_0, int P_1, string P_2, string P_3, BoolOption P_4)
				{
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(P_2);
					int layoutId = ReInput.mapping.GetLayoutId(P_0, P_3);
					if (mapCategoryId >= 0 && layoutId >= 0)
					{
						KCoiHPDBfncivsYMtDeuIMbjuAx(P_0, P_1, mapCategoryId, layoutId, P_4);
					}
				}

				private void KCoiHPDBfncivsYMtDeuIMbjuAx(Controller P_0, string P_1, string P_2, BoolOption P_3)
				{
					KCoiHPDBfncivsYMtDeuIMbjuAx(P_0.type, P_0.id, P_1, P_2, P_3);
				}

				private void RSGDYijTcBxQgPcPkRoVLjUqYcZ(Controller P_0, ControllerMap P_1, BoolOption P_2)
				{
					if (P_0 != null && P_1 != null)
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0.type);
						int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_0.id);
						if (num >= 0)
						{
							qQYfIAJgvloChayYXVFBMdlJuGrp(P_0, P_1);
							uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.SxRenVshBREfxhMTnKRbfUFvwoJi(P_1, P_2);
							EGgKASJhLqAeBBLgAmtBWBjevfmg.Apply();
						}
					}
				}

				private void RSGDYijTcBxQgPcPkRoVLjUqYcZ(ControllerType P_0, int P_1, ControllerMap P_2, BoolOption P_3)
				{
					Controller controller = ReInput.controllers.GetController(P_0, P_1);
					if (controller != null)
					{
						RSGDYijTcBxQgPcPkRoVLjUqYcZ(controller, P_2, P_3);
					}
				}

				private bool CLjaIcFlxEIeseRzDQexsnNNeZPp(ControllerType P_0, int P_1, string P_2)
				{
					if (P_2 == null || P_2 == string.Empty)
					{
						return false;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						return false;
					}
					ControllerMap controllerMap = ControllerMap.aWlEKFrTmxgBGgRqJDXRHeKwHYg(P_0);
					if (!controllerMap.EQNqypfYROzsRQVzLjfDZphqifV(P_2))
					{
						return false;
					}
					RSGDYijTcBxQgPcPkRoVLjUqYcZ(P_0, P_1, controllerMap, BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
					return true;
				}

				private int wTSwdKWtapxjJJrTKfXUOESZauL(ControllerType P_0, int P_1, List<string> P_2)
				{
					if (P_2 == null || P_2.Count == 0)
					{
						return 0;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						return 0;
					}
					int num2 = 0;
					for (int i = 0; i < P_2.Count; i++)
					{
						if (CLjaIcFlxEIeseRzDQexsnNNeZPp(P_0, P_1, P_2[i]))
						{
							num2++;
						}
					}
					return num2;
				}

				private bool FZThJxHKIGTOAckRfiJTwzQflDg(ControllerType P_0, int P_1, string P_2)
				{
					if (P_2 == null || P_2 == string.Empty)
					{
						return false;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						return false;
					}
					ControllerMap controllerMap = ControllerMap.aWlEKFrTmxgBGgRqJDXRHeKwHYg(P_0);
					if (!controllerMap.KiDoHelkINssqKBSYcLiESiAqzn(P_2))
					{
						return false;
					}
					RSGDYijTcBxQgPcPkRoVLjUqYcZ(P_0, P_1, controllerMap, BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
					return true;
				}

				private int kRznmRsFFLAfkrFDCGBBJPnrwHt(ControllerType P_0, int P_1, List<string> P_2)
				{
					if (P_2 == null || P_2.Count == 0)
					{
						return 0;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						return 0;
					}
					int num2 = 0;
					for (int i = 0; i < P_2.Count; i++)
					{
						if (FZThJxHKIGTOAckRfiJTwzQflDg(P_0, P_1, P_2[i]))
						{
							num2++;
						}
					}
					return num2;
				}

				private void qzrErZgLkkjcxaaTEYtBsCvNnIDh(ControllerType P_0, int P_1, int P_2, int P_3)
				{
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num >= 0)
					{
						Controller controller = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).TWofsWdWcZrFDlgktqaiXknQuRD;
						ControllerMap controllerMap = ControllerMap.EOKwQcxsIwIbTLRXRRCTTzrEDPK(controller, P_2, P_3);
						RSGDYijTcBxQgPcPkRoVLjUqYcZ(controller.type, controller.id, controllerMap, BoolOption.iZRfKKTEZrbyLvwfdbhJgLEHTxh);
					}
				}

				private void qzrErZgLkkjcxaaTEYtBsCvNnIDh(Controller P_0, int P_1, int P_2)
				{
					qzrErZgLkkjcxaaTEYtBsCvNnIDh(P_0.type, P_0.id, P_1, P_2);
				}

				private void qzrErZgLkkjcxaaTEYtBsCvNnIDh(ControllerType P_0, int P_1, string P_2, string P_3)
				{
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(P_2);
					int layoutId = ReInput.mapping.GetLayoutId(P_0, P_3);
					if (mapCategoryId >= 0 && layoutId >= 0)
					{
						qzrErZgLkkjcxaaTEYtBsCvNnIDh(P_0, P_1, mapCategoryId, layoutId);
					}
				}

				private void qzrErZgLkkjcxaaTEYtBsCvNnIDh(Controller P_0, string P_1, string P_2)
				{
					qzrErZgLkkjcxaaTEYtBsCvNnIDh(P_0.type, P_0.id, P_1, P_2);
				}

				private void SwgMOFoAxscYtpDGxAebEKHJGTJN(ControllerType P_0, int P_1, int P_2)
				{
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num >= 0)
					{
						uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.OBlrhcOAlFrNeOfskpYnqcxNmXz(P_2);
					}
				}

				private void SwgMOFoAxscYtpDGxAebEKHJGTJN(Controller P_0, int P_1)
				{
					SwgMOFoAxscYtpDGxAebEKHJGTJN(P_0.type, P_0.id, P_1);
				}

				private void SwgMOFoAxscYtpDGxAebEKHJGTJN(ControllerType P_0, int P_1, ControllerMap P_2)
				{
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num >= 0)
					{
						uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.vtEeJHlHmADXshapyyaNEbLgpF(P_2);
					}
				}

				private void SwgMOFoAxscYtpDGxAebEKHJGTJN(Controller P_0, ControllerMap P_1)
				{
					SwgMOFoAxscYtpDGxAebEKHJGTJN(P_0.type, P_0.id, P_1.id);
				}

				private void SwgMOFoAxscYtpDGxAebEKHJGTJN(ControllerType P_0, int P_1, int P_2, int P_3)
				{
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num >= 0)
					{
						uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.vtEeJHlHmADXshapyyaNEbLgpF(P_2, P_3);
					}
				}

				private void SwgMOFoAxscYtpDGxAebEKHJGTJN(Controller P_0, int P_1, int P_2)
				{
					SwgMOFoAxscYtpDGxAebEKHJGTJN(P_0.type, P_0.id, P_1, P_2);
				}

				private void SwgMOFoAxscYtpDGxAebEKHJGTJN(ControllerType P_0, int P_1, string P_2, string P_3)
				{
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num >= 0)
					{
						int mapCategoryId = ReInput.mapping.GetMapCategoryId(P_2);
						int layoutId = ReInput.mapping.GetLayoutId(P_0, P_3);
						if (mapCategoryId >= 0 && layoutId >= 0)
						{
							uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.vtEeJHlHmADXshapyyaNEbLgpF(mapCategoryId, layoutId);
						}
					}
				}

				private void SwgMOFoAxscYtpDGxAebEKHJGTJN(Controller P_0, string P_1, string P_2)
				{
					SwgMOFoAxscYtpDGxAebEKHJGTJN(P_0.type, P_0.id, P_1, P_2);
				}

				private ControllerMap RFheeFPACTMtdVTHXbeKnHCWIBw(ControllerType P_0, int P_1, int P_2)
				{
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						return null;
					}
					return uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.whppdOKQYknMWWyLmIsoKqqXCqJ(P_2);
				}

				private ControllerMap RFheeFPACTMtdVTHXbeKnHCWIBw(Controller P_0, int P_1)
				{
					return RFheeFPACTMtdVTHXbeKnHCWIBw(P_0.type, P_0.id, P_1);
				}

				private ControllerMap RFheeFPACTMtdVTHXbeKnHCWIBw(ControllerType P_0, int P_1, int P_2, int P_3)
				{
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						return null;
					}
					return uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.whppdOKQYknMWWyLmIsoKqqXCqJ(P_2, P_3);
				}

				private ControllerMap RFheeFPACTMtdVTHXbeKnHCWIBw(Controller P_0, int P_1, int P_2)
				{
					return RFheeFPACTMtdVTHXbeKnHCWIBw(P_0.type, P_0.id, P_1, P_2);
				}

				private ControllerMap RFheeFPACTMtdVTHXbeKnHCWIBw(ControllerType P_0, int P_1, string P_2, string P_3)
				{
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(P_2);
					int layoutId = ReInput.mapping.GetLayoutId(P_0, P_3);
					if (mapCategoryId < 0 || layoutId < 0)
					{
						return null;
					}
					return RFheeFPACTMtdVTHXbeKnHCWIBw(P_0, P_1, mapCategoryId, layoutId);
				}

				private ControllerMap RFheeFPACTMtdVTHXbeKnHCWIBw(Controller P_0, string P_1, string P_2)
				{
					return RFheeFPACTMtdVTHXbeKnHCWIBw(P_0.type, P_0.id, P_1, P_2);
				}

				private ControllerMap IrMBHygzPMxgxTCIaqqyBDcNDxza(ControllerType P_0, int P_1, int P_2)
				{
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						return null;
					}
					return uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.UzxixhTieFbVPzsdRYcxBWgKqGV(P_2);
				}

				private ControllerMap IrMBHygzPMxgxTCIaqqyBDcNDxza(Controller P_0, int P_1)
				{
					return IrMBHygzPMxgxTCIaqqyBDcNDxza(P_0.type, P_0.id, P_1);
				}

				private ControllerMap IrMBHygzPMxgxTCIaqqyBDcNDxza(ControllerType P_0, int P_1, string P_2)
				{
					int mapCategoryId = ReInput.UserData.GetMapCategoryId(P_2);
					if (mapCategoryId < 0)
					{
						return null;
					}
					return IrMBHygzPMxgxTCIaqqyBDcNDxza(P_0, P_1, mapCategoryId);
				}

				private ControllerMap IrMBHygzPMxgxTCIaqqyBDcNDxza(Controller P_0, string P_1)
				{
					return IrMBHygzPMxgxTCIaqqyBDcNDxza(P_0.type, P_0.id, P_1);
				}

				private ControllerMap[] ifyweyLdpsueGaCLtBAxqIGyfkia(ControllerType P_0)
				{
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = 0;
					for (int i = 0; i < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						num += uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					}
					ControllerMap[] array = new ControllerMap[num];
					num = 0;
					for (int j = 0; j < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; j++)
					{
						SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(j).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
						for (int k = 0; k < mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; k++)
						{
							array[num] = mapSet.get_Item(k);
							num++;
						}
					}
					return array;
				}

				private ControllerMapSaveData[] wOIfCFwBMIlUHlvQdEwJOXrwCck(ControllerType P_0, int P_1, bool P_2)
				{
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						return null;
					}
					List<ControllerMapSaveData> list = new List<ControllerMapSaveData>();
					SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
					for (int i = 0; i < mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ControllerMap controllerMap = mapSet.get_Item(i);
						if (P_2)
						{
							InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(controllerMap.categoryId);
							if (mapCategory != null && !mapCategory.userAssignable)
							{
								continue;
							}
						}
						Controller controller = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).TWofsWdWcZrFDlgktqaiXknQuRD;
						list.Add(ControllerMapSaveData.aWlEKFrTmxgBGgRqJDXRHeKwHYg(controller, controllerMap));
					}
					return list.ToArray();
				}

				private T[] wOIfCFwBMIlUHlvQdEwJOXrwCck<T>(int P_0, bool P_1) where T : ControllerMapSaveData
				{
					ControllerType controllerType = BbpfTcGSZRHmltstKOfXrucHPJO.oZAkoHEmFHHYzlBUgPrqyaNBpZm<T>();
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_0);
					if (num < 0)
					{
						return null;
					}
					List<T> list = new List<T>();
					SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
					for (int i = 0; i < mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						ControllerMap controllerMap = mapSet.get_Item(i);
						if (P_1)
						{
							InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(controllerMap.categoryId);
							if (mapCategory != null && !mapCategory.userAssignable)
							{
								continue;
							}
						}
						Controller controller = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).TWofsWdWcZrFDlgktqaiXknQuRD;
						list.Add(ControllerMapSaveData.aWlEKFrTmxgBGgRqJDXRHeKwHYg<T>(controller, controllerMap));
					}
					return list.ToArray();
				}

				private ControllerMapSaveData[] gwQuaLzMMCtouBScPEmCKgSGhXZ(ControllerType P_0, bool P_1)
				{
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					List<ControllerMapSaveData> list = new List<ControllerMapSaveData>();
					for (int i = 0; i < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
						for (int j = 0; j < mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; j++)
						{
							ControllerMap controllerMap = mapSet.get_Item(j);
							if (P_1)
							{
								InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(controllerMap.categoryId);
								if (mapCategory != null && !mapCategory.userAssignable)
								{
									continue;
								}
							}
							Controller controller = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
							list.Add(ControllerMapSaveData.aWlEKFrTmxgBGgRqJDXRHeKwHYg(controller, controllerMap));
						}
					}
					return list.ToArray();
				}

				private T[] gwQuaLzMMCtouBScPEmCKgSGhXZ<T>(bool P_0) where T : ControllerMapSaveData
				{
					ControllerType controllerType = BbpfTcGSZRHmltstKOfXrucHPJO.oZAkoHEmFHHYzlBUgPrqyaNBpZm<T>();
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
					List<T> list = new List<T>();
					for (int i = 0; i < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
						for (int j = 0; j < mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; j++)
						{
							ControllerMap controllerMap = mapSet.get_Item(j);
							if (P_0)
							{
								InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(controllerMap.categoryId);
								if (mapCategory != null && !mapCategory.userAssignable)
								{
									continue;
								}
							}
							Controller controller = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
							list.Add(ControllerMapSaveData.aWlEKFrTmxgBGgRqJDXRHeKwHYg<T>(controller, controllerMap));
						}
					}
					return list.ToArray();
				}

				private int NaFXbHYUikSmuekRXoAqsaMVbLxg(ControllerType P_0, int P_1, int P_2, List<ControllerMap> P_3)
				{
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						return 0;
					}
					return uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.wSkknMfcZANKmxiRSFsugsrKwqi(P_2, P_3, false);
				}

				private int NaFXbHYUikSmuekRXoAqsaMVbLxg(Controller P_0, int P_1, List<ControllerMap> P_2)
				{
					return NaFXbHYUikSmuekRXoAqsaMVbLxg(P_0.type, P_0.id, P_1, P_2);
				}

				private int NaFXbHYUikSmuekRXoAqsaMVbLxg(ControllerType P_0, int P_1, string P_2, List<ControllerMap> P_3)
				{
					int mapCategoryId = ReInput.UserData.GetMapCategoryId(P_2);
					if (mapCategoryId < 0)
					{
						return 0;
					}
					return NaFXbHYUikSmuekRXoAqsaMVbLxg(P_0, P_1, mapCategoryId, P_3);
				}

				private int NaFXbHYUikSmuekRXoAqsaMVbLxg(Controller P_0, string P_1, List<ControllerMap> P_2)
				{
					return NaFXbHYUikSmuekRXoAqsaMVbLxg(P_0.type, P_0.id, P_1, P_2);
				}

				private IEnumerable<ControllerMap> mOFosXbyeHjzmWoMtBphQKnpHrQ(ControllerType P_0, int P_1, int P_2)
				{
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						yield break;
					}
					IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
					for (int i = 0; i < maps.Count; i++)
					{
						if (maps[i].categoryId == P_2)
						{
							yield return maps[i];
						}
					}
				}

				private IEnumerable<T> mOFosXbyeHjzmWoMtBphQKnpHrQ<T>(int P_0, int P_1) where T : ControllerMap
				{
					ControllerType controllerType = BbpfTcGSZRHmltstKOfXrucHPJO.ipEBHjqihuskfnXqnsSfpaiQEoP<T>();
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_0);
					if (num < 0)
					{
						yield break;
					}
					IList<T> list = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.oUQuEQAgSUASfBxvUZViLorRwfUP<T>();
					for (int i = 0; i < list.Count; i++)
					{
						T val = list[i];
						if (val.categoryId == P_1)
						{
							yield return list[i];
						}
					}
				}

				private ActionElementMap ZALpiOOzwPSnWFxHgyKxuRjQcgg(ControllerType P_0, int P_1, bool P_2)
				{
					if (P_1 < 0)
					{
						return null;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					for (int i = 0; i < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
						for (int j = 0; j < maps.Count; j++)
						{
							if ((!P_2 || maps[j].enabled) && maps[j].ContainsAction(P_1))
							{
								ActionElementMap firstButtonMapWithAction = maps[j].GetFirstButtonMapWithAction(P_1, P_2);
								if (firstButtonMapWithAction != null)
								{
									return firstButtonMapWithAction;
								}
							}
						}
					}
					return null;
				}

				private ActionElementMap ZALpiOOzwPSnWFxHgyKxuRjQcgg(ControllerType P_0, string P_1, bool P_2)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_1);
					return ZALpiOOzwPSnWFxHgyKxuRjQcgg(P_0, num, P_2);
				}

				private IEnumerable<ActionElementMap> tTQSLQLEvVEwQMofXXCmoOPosI(ControllerType P_0, int P_1, bool P_2)
				{
					if (P_1 < 0)
					{
						yield break;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					for (int i = 0; i < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
						for (int j = 0; j < maps.Count; j++)
						{
							if ((P_2 && !maps[j].enabled) || !maps[j].ContainsAction(P_1))
							{
								continue;
							}
							foreach (ActionElementMap item in maps[j].ButtonMapsWithAction(P_1, P_2))
							{
								yield return item;
							}
						}
					}
				}

				private IEnumerable<ActionElementMap> tTQSLQLEvVEwQMofXXCmoOPosI(ControllerType P_0, string P_1, bool P_2)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_1);
					return tTQSLQLEvVEwQMofXXCmoOPosI(P_0, num, P_2);
				}

				private ActionElementMap ZwVYuPRaWETiuzqIcTkJwRcigxE(ControllerType P_0, int P_1, bool P_2)
				{
					if (P_1 < 0)
					{
						return null;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					for (int i = 0; i < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
						for (int j = 0; j < maps.Count; j++)
						{
							if (!(maps[j] is ControllerMapWithAxes))
							{
								return null;
							}
							if ((!P_2 || maps[j].enabled) && maps[j].ContainsAction(P_1))
							{
								ActionElementMap firstAxisMapWithAction = (maps[j] as ControllerMapWithAxes).GetFirstAxisMapWithAction(P_1, P_2);
								if (firstAxisMapWithAction != null)
								{
									return firstAxisMapWithAction;
								}
							}
						}
					}
					return null;
				}

				private ActionElementMap ZwVYuPRaWETiuzqIcTkJwRcigxE(ControllerType P_0, string P_1, bool P_2)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_1);
					return ZwVYuPRaWETiuzqIcTkJwRcigxE(P_0, num, P_2);
				}

				private IEnumerable<ActionElementMap> mTiMOfxcIghkjNwYZYXMWUNjNbf(ControllerType P_0, int P_1, bool P_2)
				{
					if (P_1 < 0)
					{
						yield break;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					for (int i = 0; i < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
						for (int j = 0; j < maps.Count; j++)
						{
							if (!(maps[j] is ControllerMapWithAxes))
							{
								yield break;
							}
							if ((P_2 && !maps[j].enabled) || !maps[j].ContainsAction(P_1))
							{
								continue;
							}
							foreach (ActionElementMap item in (maps[j] as ControllerMapWithAxes).AxisMapsWithAction(P_1, P_2))
							{
								yield return item;
							}
						}
					}
				}

				private IEnumerable<ActionElementMap> mTiMOfxcIghkjNwYZYXMWUNjNbf(ControllerType P_0, string P_1, bool P_2)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_1);
					return mTiMOfxcIghkjNwYZYXMWUNjNbf(P_0, num, P_2);
				}

				private ActionElementMap TWvjxgjJVFGCdFiIwioqZvaQHTs(ControllerType P_0, int P_1, bool P_2)
				{
					if (P_1 < 0)
					{
						return null;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					for (int i = 0; i < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
						for (int j = 0; j < maps.Count; j++)
						{
							if ((!P_2 || maps[j].enabled) && maps[j].ContainsAction(P_1))
							{
								ActionElementMap firstElementMapWithAction = maps[j].GetFirstElementMapWithAction(P_1, P_2);
								if (firstElementMapWithAction != null)
								{
									return firstElementMapWithAction;
								}
							}
						}
					}
					return null;
				}

				private ActionElementMap TWvjxgjJVFGCdFiIwioqZvaQHTs(ControllerType P_0, string P_1, bool P_2)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_1);
					return TWvjxgjJVFGCdFiIwioqZvaQHTs(P_0, num, P_2);
				}

				private IEnumerable<ActionElementMap> uTxjyvtbIHExPZSfbMyeEZghtdm(ControllerType P_0, int P_1, bool P_2)
				{
					if (P_1 < 0)
					{
						yield break;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					for (int i = 0; i < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
						for (int j = 0; j < maps.Count; j++)
						{
							if ((P_2 && !maps[j].enabled) || !maps[j].ContainsAction(P_1))
							{
								continue;
							}
							foreach (ActionElementMap item in maps[j].ElementMapsWithAction(P_1, P_2))
							{
								yield return item;
							}
						}
					}
				}

				private IEnumerable<ActionElementMap> uTxjyvtbIHExPZSfbMyeEZghtdm(ControllerType P_0, string P_1, bool P_2)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_1);
					return uTxjyvtbIHExPZSfbMyeEZghtdm(P_0, num, P_2);
				}

				private int OkcRCEckXtWYjyMQBguTtVlxtFz(int P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
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
					int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(i);
						int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int j = 0; j < count; j++)
						{
							SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(j).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
							int count2 = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
							for (int k = 0; k < count2; k++)
							{
								ControllerMap controllerMap = mapSet.get_Item(k);
								if ((!P_1 || controllerMap.enabled) && controllerMap.ContainsAction(P_0))
								{
									num += controllerMap.OkcRCEckXtWYjyMQBguTtVlxtFz(P_0, P_1, P_2, true);
								}
							}
						}
					}
					return num;
				}

				private int AFEuEUDCsmGMceBQdrVoJZTKsBP(int P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
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
					int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(i);
						int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int j = 0; j < count; j++)
						{
							SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(j).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
							int count2 = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
							for (int k = 0; k < count2; k++)
							{
								if (mapSet.get_Item(k) is ControllerMapWithAxes controllerMapWithAxes && (!P_1 || controllerMapWithAxes.enabled) && controllerMapWithAxes.ContainsAction(P_0))
								{
									num += controllerMapWithAxes.AFEuEUDCsmGMceBQdrVoJZTKsBP(P_0, P_1, P_2, true);
								}
							}
						}
					}
					return num;
				}

				private int hHAktoEzTjklPLyzcjMCfmqeriO(int P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
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
					int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(i);
						int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						for (int j = 0; j < count; j++)
						{
							SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(j).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
							int count2 = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
							for (int k = 0; k < count2; k++)
							{
								ControllerMap controllerMap = mapSet.get_Item(k);
								if ((!P_1 || controllerMap.enabled) && controllerMap.ContainsAction(P_0))
								{
									num += controllerMap.hHAktoEzTjklPLyzcjMCfmqeriO(P_0, P_1, P_2, true);
								}
							}
						}
					}
					return num;
				}

				private int nXCwgMLEVQlISylqZWJsFapDSOC(ControllerType P_0, int P_1, bool P_2, List<ActionElementMap> P_3, bool P_4)
				{
					if (P_3 == null)
					{
						throw new ArgumentNullException("results");
					}
					if (!P_4)
					{
						P_3.Clear();
					}
					if (P_1 < 0)
					{
						return 0;
					}
					int num = 0;
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					for (int i = 0; i < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
						for (int j = 0; j < maps.Count; j++)
						{
							if ((!P_2 || maps[j].enabled) && maps[j].ContainsAction(P_1))
							{
								num += maps[j].OkcRCEckXtWYjyMQBguTtVlxtFz(P_1, P_2, P_3, true);
							}
						}
					}
					return num;
				}

				private int nXCwgMLEVQlISylqZWJsFapDSOC(ControllerType P_0, string P_1, bool P_2, List<ActionElementMap> P_3, bool P_4)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_1);
					return nXCwgMLEVQlISylqZWJsFapDSOC(P_0, num, P_2, P_3, P_4);
				}

				private int EdYurEaPxANGkQlhgakABEMNMuK(ControllerType P_0, int P_1, bool P_2, List<ActionElementMap> P_3, bool P_4)
				{
					if (P_3 == null)
					{
						throw new ArgumentNullException("results");
					}
					if (!P_4)
					{
						P_3.Clear();
					}
					if (P_1 < 0)
					{
						return 0;
					}
					int num = 0;
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					for (int i = 0; i < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
						for (int j = 0; j < maps.Count; j++)
						{
							if (!(maps[j] is ControllerMapWithAxes))
							{
								return P_3.Count;
							}
							if ((!P_2 || maps[j].enabled) && maps[j].ContainsAction(P_1))
							{
								num += (maps[j] as ControllerMapWithAxes).AFEuEUDCsmGMceBQdrVoJZTKsBP(P_1, P_2, P_3, true);
							}
						}
					}
					return num;
				}

				private int EdYurEaPxANGkQlhgakABEMNMuK(ControllerType P_0, string P_1, bool P_2, List<ActionElementMap> P_3, bool P_4)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_1);
					return EdYurEaPxANGkQlhgakABEMNMuK(P_0, num, P_2, P_3, P_4);
				}

				private int KQScfgHqtRAiyiRXpGyUgvDcgJfK(ControllerType P_0, int P_1, bool P_2, List<ActionElementMap> P_3, bool P_4)
				{
					if (P_3 == null)
					{
						throw new ArgumentNullException("results");
					}
					if (!P_4)
					{
						P_3.Clear();
					}
					if (P_1 < 0)
					{
						return 0;
					}
					int num = 0;
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					for (int i = 0; i < uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
					{
						IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
						for (int j = 0; j < maps.Count; j++)
						{
							if ((!P_2 || maps[j].enabled) && maps[j].ContainsAction(P_1))
							{
								num += maps[j].hHAktoEzTjklPLyzcjMCfmqeriO(P_1, P_2, P_3, true);
							}
						}
					}
					return num;
				}

				private int KQScfgHqtRAiyiRXpGyUgvDcgJfK(ControllerType P_0, string P_1, bool P_2, List<ActionElementMap> P_3, bool P_4)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_1);
					return KQScfgHqtRAiyiRXpGyUgvDcgJfK(P_0, num, P_2, P_3, P_4);
				}

				private ActionElementMap ZALpiOOzwPSnWFxHgyKxuRjQcgg(ControllerType P_0, int P_1, int P_2, bool P_3)
				{
					if (P_2 < 0)
					{
						return null;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						return null;
					}
					IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
					for (int i = 0; i < maps.Count; i++)
					{
						if ((!P_3 || maps[i].enabled) && maps[i].ContainsAction(P_2))
						{
							ActionElementMap firstButtonMapWithAction = maps[i].GetFirstButtonMapWithAction(P_2, P_3);
							if (firstButtonMapWithAction != null)
							{
								return firstButtonMapWithAction;
							}
						}
					}
					return null;
				}

				private ActionElementMap ZALpiOOzwPSnWFxHgyKxuRjQcgg(ControllerType P_0, int P_1, string P_2, bool P_3)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_2);
					return ZALpiOOzwPSnWFxHgyKxuRjQcgg(P_0, P_1, num, P_3);
				}

				private IEnumerable<ActionElementMap> tTQSLQLEvVEwQMofXXCmoOPosI(ControllerType P_0, int P_1, int P_2, bool P_3)
				{
					if (P_2 < 0)
					{
						yield break;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						yield break;
					}
					IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
					for (int i = 0; i < maps.Count; i++)
					{
						if ((P_3 && !maps[i].enabled) || !maps[i].ContainsAction(P_2))
						{
							continue;
						}
						foreach (ActionElementMap item in maps[i].ButtonMapsWithAction(P_2, P_3))
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ActionElementMap> tTQSLQLEvVEwQMofXXCmoOPosI(ControllerType P_0, int P_1, string P_2, bool P_3)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_2);
					return tTQSLQLEvVEwQMofXXCmoOPosI(P_0, P_1, num, P_3);
				}

				private ActionElementMap ZwVYuPRaWETiuzqIcTkJwRcigxE(ControllerType P_0, int P_1, int P_2, bool P_3)
				{
					if (P_2 < 0)
					{
						return null;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						return null;
					}
					IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
					for (int i = 0; i < maps.Count; i++)
					{
						if (!(maps[i] is ControllerMapWithAxes))
						{
							return null;
						}
						if ((!P_3 || maps[i].enabled) && maps[i].ContainsAction(P_2))
						{
							ActionElementMap firstAxisMapWithAction = (maps[i] as ControllerMapWithAxes).GetFirstAxisMapWithAction(P_2, P_3);
							if (firstAxisMapWithAction != null)
							{
								return firstAxisMapWithAction;
							}
						}
					}
					return null;
				}

				private ActionElementMap ZwVYuPRaWETiuzqIcTkJwRcigxE(ControllerType P_0, int P_1, string P_2, bool P_3)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_2);
					return ZwVYuPRaWETiuzqIcTkJwRcigxE(P_0, P_1, num, P_3);
				}

				private IEnumerable<ActionElementMap> mTiMOfxcIghkjNwYZYXMWUNjNbf(ControllerType P_0, int P_1, int P_2, bool P_3)
				{
					if (P_2 < 0)
					{
						yield break;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						yield break;
					}
					IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
					for (int i = 0; i < maps.Count && maps[i] is ControllerMapWithAxes; i++)
					{
						if ((P_3 && !maps[i].enabled) || !maps[i].ContainsAction(P_2))
						{
							continue;
						}
						foreach (ActionElementMap item in (maps[i] as ControllerMapWithAxes).AxisMapsWithAction(P_2, P_3))
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ActionElementMap> mTiMOfxcIghkjNwYZYXMWUNjNbf(ControllerType P_0, int P_1, string P_2, bool P_3)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_2);
					return mTiMOfxcIghkjNwYZYXMWUNjNbf(P_0, P_1, num, P_3);
				}

				private ActionElementMap TWvjxgjJVFGCdFiIwioqZvaQHTs(ControllerType P_0, int P_1, int P_2, bool P_3)
				{
					if (P_2 < 0)
					{
						return null;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						return null;
					}
					IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
					for (int i = 0; i < maps.Count; i++)
					{
						if ((!P_3 || maps[i].enabled) && maps[i].ContainsAction(P_2))
						{
							ActionElementMap firstElementMapWithAction = maps[i].GetFirstElementMapWithAction(P_2, P_3);
							if (firstElementMapWithAction != null)
							{
								return firstElementMapWithAction;
							}
						}
					}
					return null;
				}

				private ActionElementMap TWvjxgjJVFGCdFiIwioqZvaQHTs(ControllerType P_0, int P_1, string P_2, bool P_3)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_2);
					return TWvjxgjJVFGCdFiIwioqZvaQHTs(P_0, P_1, num, P_3);
				}

				private IEnumerable<ActionElementMap> uTxjyvtbIHExPZSfbMyeEZghtdm(ControllerType P_0, int P_1, int P_2, bool P_3)
				{
					if (P_2 < 0)
					{
						yield break;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						yield break;
					}
					IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
					for (int i = 0; i < maps.Count; i++)
					{
						if ((P_3 && !maps[i].enabled) || !maps[i].ContainsAction(P_2))
						{
							continue;
						}
						foreach (ActionElementMap item in maps[i].ElementMapsWithAction(P_2, P_3))
						{
							yield return item;
						}
					}
				}

				private IEnumerable<ActionElementMap> uTxjyvtbIHExPZSfbMyeEZghtdm(ControllerType P_0, int P_1, string P_2, bool P_3)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_2);
					return uTxjyvtbIHExPZSfbMyeEZghtdm(P_0, P_1, num, P_3);
				}

				private int nXCwgMLEVQlISylqZWJsFapDSOC(ControllerType P_0, int P_1, int P_2, bool P_3, List<ActionElementMap> P_4, bool P_5)
				{
					if (P_4 == null)
					{
						throw new ArgumentNullException("results");
					}
					if (!P_5)
					{
						P_4.Clear();
					}
					if (P_2 < 0)
					{
						return 0;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						return 0;
					}
					int num2 = 0;
					IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
					for (int i = 0; i < maps.Count; i++)
					{
						ControllerMap controllerMap = maps[i];
						if ((!P_3 || controllerMap.enabled) && controllerMap.ContainsAction(P_2))
						{
							num2 += controllerMap.OkcRCEckXtWYjyMQBguTtVlxtFz(P_2, P_3, P_4, true);
						}
					}
					return num2;
				}

				private int nXCwgMLEVQlISylqZWJsFapDSOC(ControllerType P_0, int P_1, string P_2, bool P_3, List<ActionElementMap> P_4, bool P_5)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_2);
					return nXCwgMLEVQlISylqZWJsFapDSOC(P_0, P_1, num, P_3, P_4, P_5);
				}

				private int EdYurEaPxANGkQlhgakABEMNMuK(ControllerType P_0, int P_1, int P_2, bool P_3, List<ActionElementMap> P_4, bool P_5)
				{
					if (P_4 == null)
					{
						throw new ArgumentNullException("results");
					}
					if (!P_5)
					{
						P_4.Clear();
					}
					if (P_2 < 0)
					{
						return 0;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						return 0;
					}
					int num2 = 0;
					IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
					for (int i = 0; i < maps.Count; i++)
					{
						ControllerMapWithAxes controllerMapWithAxes = maps[i] as ControllerMapWithAxes;
						if (maps == null)
						{
							return num2;
						}
						if ((!P_3 || controllerMapWithAxes.enabled) && controllerMapWithAxes.ContainsAction(P_2))
						{
							num2 += controllerMapWithAxes.AFEuEUDCsmGMceBQdrVoJZTKsBP(P_2, P_3, P_4, true);
						}
					}
					return num2;
				}

				private int EdYurEaPxANGkQlhgakABEMNMuK(ControllerType P_0, int P_1, string P_2, bool P_3, List<ActionElementMap> P_4, bool P_5)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_2);
					return EdYurEaPxANGkQlhgakABEMNMuK(P_0, P_1, num, P_3, P_4, P_5);
				}

				private int KQScfgHqtRAiyiRXpGyUgvDcgJfK(ControllerType P_0, int P_1, int P_2, bool P_3, List<ActionElementMap> P_4, bool P_5)
				{
					if (P_4 == null)
					{
						throw new ArgumentNullException("results");
					}
					if (!P_5)
					{
						P_4.Clear();
					}
					if (P_2 < 0)
					{
						return 0;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
					int num = uatpsZKPeFXZcGHRylaqbbrOzNO.eaOrStrSOuOlEEMmganiuTHlvbL(P_1);
					if (num < 0)
					{
						return 0;
					}
					int num2 = 0;
					IList<ControllerMap> maps = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).JYKAxzbcwrkvXFkdyALvVdvpDkeE.rAtBsfmyhskHaUTPDmVjIaVEYas;
					for (int i = 0; i < maps.Count; i++)
					{
						if ((!P_3 || maps[i].enabled) && maps[i].ContainsAction(P_2))
						{
							num2 += maps[i].hHAktoEzTjklPLyzcjMCfmqeriO(P_2, P_3, P_4, true);
						}
					}
					return num2;
				}

				private int KQScfgHqtRAiyiRXpGyUgvDcgJfK(ControllerType P_0, int P_1, string P_2, bool P_3, List<ActionElementMap> P_4, bool P_5)
				{
					int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(P_2);
					return KQScfgHqtRAiyiRXpGyUgvDcgJfK(P_0, P_1, num, P_3, P_4, P_5);
				}

				private ActionElementMap VfcfyKNKnGeUcaZTKcbxEoucaoFO(IControllerElementTarget P_0, bool P_1, int P_2, bool P_3)
				{
					if (P_0 == null)
					{
						return null;
					}
					Controller controller = P_0.controller;
					if (controller == null)
					{
						return null;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controller.type);
					int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < count; i++)
					{
						SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
						_ = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						IList<ControllerMap> maps = mapSet.rAtBsfmyhskHaUTPDmVjIaVEYas;
						int count2 = maps.Count;
						for (int j = 0; j < count2; j++)
						{
							ControllerMap controllerMap = maps[j];
							if (!P_3 || controllerMap.enabled)
							{
								bool flag;
								ActionElementMap actionElementMap = controllerMap.VfcfyKNKnGeUcaZTKcbxEoucaoFO(P_0, P_1, P_2, P_3, out flag);
								if (actionElementMap != null)
								{
									return actionElementMap;
								}
							}
						}
					}
					return null;
				}

				private IEnumerable<ActionElementMap> inrTpaIDLKazOABUOxfZHUsLAjp(IControllerElementTarget P_0, bool P_1, int P_2, bool P_3)
				{
					if (P_0 == null)
					{
						yield break;
					}
					Controller controller = P_0.controller;
					if (controller == null)
					{
						yield break;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controller.type);
					int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int i = 0; i < count; i++)
					{
						SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
						_ = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						IList<ControllerMap> maps = mapSet.rAtBsfmyhskHaUTPDmVjIaVEYas;
						int count2 = maps.Count;
						for (int j = 0; j < count2; j++)
						{
							ControllerMap controllerMap = maps[j];
							if (P_3 && !controllerMap.enabled)
							{
								continue;
							}
							using TempListPool.TList<ActionElementMap> tList = TempListPool.GetTList<ActionElementMap>();
							List<ActionElementMap> list = tList.list;
							controllerMap.JzTnuZQPeJZpOCUTrCSLHdIycSYG(P_0, P_1, P_2, P_3, list, true, out var _);
							foreach (ActionElementMap item in list)
							{
								yield return item;
							}
						}
					}
				}

				private int JzTnuZQPeJZpOCUTrCSLHdIycSYG(IControllerElementTarget P_0, bool P_1, int P_2, bool P_3, List<ActionElementMap> P_4, bool P_5)
				{
					if (P_4 == null)
					{
						throw new ArgumentNullException("results");
					}
					if (!P_5)
					{
						P_4.Clear();
					}
					if (P_0 == null)
					{
						return 0;
					}
					Controller controller = P_0.controller;
					if (controller == null)
					{
						return 0;
					}
					UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = mQXiYotjnToDecfWIRfktslJAMQ.ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controller.type);
					int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					int num = 0;
					for (int i = 0; i < count; i++)
					{
						SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
						_ = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
						IList<ControllerMap> maps = mapSet.rAtBsfmyhskHaUTPDmVjIaVEYas;
						int count2 = maps.Count;
						for (int j = 0; j < count2; j++)
						{
							ControllerMap controllerMap = maps[j];
							if (!P_3 || controllerMap.enabled)
							{
								num += controllerMap.JzTnuZQPeJZpOCUTrCSLHdIycSYG(P_0, P_1, P_2, P_3, P_4, P_5, out var _);
							}
						}
					}
					return num;
				}
			}

			[Browsable(false)]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public sealed class PollingHelper : CodeHelper
			{
				private readonly Player QFlXjfmiJabcsMblLziegHSMCLfJ;

				private readonly ControllerHelper mQXiYotjnToDecfWIRfktslJAMQ;

				private readonly int PivQvdYMhUssuLwaglJVqkqXMSH;

				internal PollingHelper(Player player, ControllerHelper parent)
				{
					PivQvdYMhUssuLwaglJVqkqXMSH = ReInput.id;
					QFlXjfmiJabcsMblLziegHSMCLfJ = player;
					mQXiYotjnToDecfWIRfktslJAMQ = parent;
				}

				public ControllerPollingInfo PollControllerForFirstElement(ControllerType controllerType, int controllerId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Keyboard => lQLJhbEfcNBpedPNxNFzjfsgToLX(), 
						ControllerType.Joystick => LczkahoKDJlieveHKCdxcwEFjKs(controllerId), 
						ControllerType.Mouse => NZgCGvSQdAcxwOsJhcPYZrtlZtP(), 
						ControllerType.Custom => EjjcotHQwjOrcjDCNdOiZhRJao(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public ControllerPollingInfo PollControllerForFirstElementDown(ControllerType controllerType, int controllerId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Keyboard => SeblWPqDnAwVQgRSeiLCKHnatdj(), 
						ControllerType.Joystick => PINRdbgCNHgbBBophHjmKFebSPL(controllerId), 
						ControllerType.Mouse => CvbMVrTXhYHDrZIKlqJuHDkmKiC(), 
						ControllerType.Custom => mDTDlLnbANrUcKCXBAiHMgZsubb(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public ControllerPollingInfo PollControllerForFirstButton(ControllerType controllerType, int controllerId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Keyboard => lQLJhbEfcNBpedPNxNFzjfsgToLX(), 
						ControllerType.Joystick => jXGyRogRekagpnPbsovMZcORmlz(controllerId), 
						ControllerType.Mouse => ObTeBSvMSaaDdnPPqAbhskKZHAdC(), 
						ControllerType.Custom => zarblPCArDmlgkrGigwXkLLcoSB(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public ControllerPollingInfo PollControllerForFirstButtonDown(ControllerType controllerType, int controllerId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Keyboard => SeblWPqDnAwVQgRSeiLCKHnatdj(), 
						ControllerType.Joystick => bzErKaudNUvvRVXzcBcTzoynwJS(controllerId), 
						ControllerType.Mouse => sGHuqzQOGzcrfEGQoLNvfBTntnea(), 
						ControllerType.Custom => gnHfMCLpAFYVnLppXwqccWNuFJL(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public ControllerPollingInfo PollControllerForFirstAxis(ControllerType controllerType, int controllerId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Keyboard => ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf(), 
						ControllerType.Joystick => QdhsUuUATkmjfEEmEDKBEqczBoST(controllerId), 
						ControllerType.Mouse => GWhvCPrVslWzDoGyWALfdiLKRDO(), 
						ControllerType.Custom => AhjiLtixSxCgsmHtcYKddubNNGQ(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllElements(ControllerType controllerType, int controllerId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return controllerType switch
					{
						ControllerType.Keyboard => IZSVrgfNDwGCdgvessMRhggZLQgY(), 
						ControllerType.Joystick => xpDUdxqSuaTPBBnHlLwVOegJYFo(controllerId), 
						ControllerType.Mouse => jPLyPLzcSArYFOTUKzvTQkUkbJp(), 
						ControllerType.Custom => IaBOVUDboXOIbBLjBJAwjnfYgBE(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllElementsDown(ControllerType controllerType, int controllerId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return controllerType switch
					{
						ControllerType.Keyboard => apQRyVyUghxUmSBkAuvbdyHXPep(), 
						ControllerType.Joystick => lLAtBllNQBhsvTvRnJvLvReRhEW(controllerId), 
						ControllerType.Mouse => bTPHzlFyxXdnZzalVQcCJOTrnLU(), 
						ControllerType.Custom => xKzBrkaSqCaXLhjlQPXoecQynjm(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtons(ControllerType controllerType, int controllerId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return controllerType switch
					{
						ControllerType.Keyboard => IZSVrgfNDwGCdgvessMRhggZLQgY(), 
						ControllerType.Joystick => VRujVIWJTMntXvwGsGDplKkxXny(controllerId), 
						ControllerType.Mouse => IVbwFLpVnCkALhUvotTfVyfcovQ(), 
						ControllerType.Custom => kRYqsNOSSrRYeaLmeLUQrDufBYp(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllButtonsDown(ControllerType controllerType, int controllerId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return controllerType switch
					{
						ControllerType.Keyboard => apQRyVyUghxUmSBkAuvbdyHXPep(), 
						ControllerType.Joystick => szOpKikkzpaEIcUHFehTguzgPMof(controllerId), 
						ControllerType.Mouse => klwBobIERIaKmQrJbuIRqXnCDdx(), 
						ControllerType.Custom => kfGQZXiEzkPHzVsTtdnEwTduphS(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ControllerPollingInfo> PollControllerForAllAxes(ControllerType controllerType, int controllerId)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return controllerType switch
					{
						ControllerType.Keyboard => new List<ControllerPollingInfo>(), 
						ControllerType.Joystick => wSHzXdHCCCkZVjhgKzQvGcEhMzd(controllerId), 
						ControllerType.Mouse => iQzhrBuoddEtyLIrXIKpafbXLYG(), 
						ControllerType.Custom => lvpLGtUELtSBrrbPLfUjdDVukXp(controllerId), 
						_ => throw new NotImplementedException(), 
					};
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstElement(ControllerType controllerType)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Keyboard => lQLJhbEfcNBpedPNxNFzjfsgToLX(), 
						ControllerType.Joystick => BPbBTtVObmgXNwUwpliGxSWnECJ(), 
						ControllerType.Mouse => NZgCGvSQdAcxwOsJhcPYZrtlZtP(), 
						ControllerType.Custom => GWmZWnlHxFEUXieGzCzMXyqSnuO(), 
						_ => throw new NotImplementedException(), 
					};
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstButton(ControllerType controllerType)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Keyboard => lQLJhbEfcNBpedPNxNFzjfsgToLX(), 
						ControllerType.Joystick => hKGvFBMZdfTHLXvbpEwKgahVKKY(), 
						ControllerType.Mouse => ObTeBSvMSaaDdnPPqAbhskKZHAdC(), 
						ControllerType.Custom => TeEcjHksFDwZLuxeBsznKVzDVrn(), 
						_ => throw new NotImplementedException(), 
					};
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstButtonDown(ControllerType controllerType)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Keyboard => SeblWPqDnAwVQgRSeiLCKHnatdj(), 
						ControllerType.Joystick => zcFsYwMOpAENHfhLAKmpPnxiFbY(), 
						ControllerType.Mouse => sGHuqzQOGzcrfEGQoLNvfBTntnea(), 
						ControllerType.Custom => vvIEmvquKUQmjMeXbFoiRcSXWZH(), 
						_ => throw new NotImplementedException(), 
					};
				}

				public ControllerPollingInfo PollAllControllersOfTypeForFirstAxis(ControllerType controllerType)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return controllerType switch
					{
						ControllerType.Keyboard => ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf(), 
						ControllerType.Joystick => wooBmHpbqPpndBLyQIDyvHKjBTN(), 
						ControllerType.Mouse => GWhvCPrVslWzDoGyWALfdiLKRDO(), 
						ControllerType.Custom => UKQZncxGBDkovrkuDNVNTIVgZGh(), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllElements(ControllerType controllerType)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return controllerType switch
					{
						ControllerType.Keyboard => IZSVrgfNDwGCdgvessMRhggZLQgY(), 
						ControllerType.Joystick => AzVqsenrgyjMFPcZwzHqOwexZ(), 
						ControllerType.Mouse => jPLyPLzcSArYFOTUKzvTQkUkbJp(), 
						ControllerType.Custom => FJsdirYVehxggDNSpATebPqSyUL(), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllElementsDown(ControllerType controllerType)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return controllerType switch
					{
						ControllerType.Keyboard => apQRyVyUghxUmSBkAuvbdyHXPep(), 
						ControllerType.Joystick => NszfsFfWjchsTlWOMKKPqghYedHD(), 
						ControllerType.Mouse => bTPHzlFyxXdnZzalVQcCJOTrnLU(), 
						ControllerType.Custom => flTRoHvnTZQDXDPFONfTCBadGuK(), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllButtons(ControllerType controllerType)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return controllerType switch
					{
						ControllerType.Keyboard => IZSVrgfNDwGCdgvessMRhggZLQgY(), 
						ControllerType.Joystick => dKtaKDnZSUiuRZZqwpYqFFNprOI(), 
						ControllerType.Mouse => IVbwFLpVnCkALhUvotTfVyfcovQ(), 
						ControllerType.Custom => uRbYFjBCCoODZEUnbkZRjIAjbUS(), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllButtonsDown(ControllerType controllerType)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return controllerType switch
					{
						ControllerType.Keyboard => apQRyVyUghxUmSBkAuvbdyHXPep(), 
						ControllerType.Joystick => ABxExjalTAYSjARAGvGqFrwzEJX(), 
						ControllerType.Mouse => klwBobIERIaKmQrJbuIRqXnCDdx(), 
						ControllerType.Custom => EnxdkYulKwfpxyFmfgQJAIYPqeZV(), 
						_ => throw new NotImplementedException(), 
					};
				}

				public IEnumerable<ControllerPollingInfo> PollAllControllersOfTypeForAllAxes(ControllerType controllerType)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return controllerType switch
					{
						ControllerType.Keyboard => new List<ControllerPollingInfo>(), 
						ControllerType.Joystick => weRLHaWslOoGuMJDDvVgqpbuILF(), 
						ControllerType.Mouse => iQzhrBuoddEtyLIrXIKpafbXLYG(), 
						ControllerType.Custom => GsGSsIYMnOWfesNExUbMzDxaLMb(), 
						_ => throw new NotImplementedException(), 
					};
				}

				private ControllerPollingInfo LczkahoKDJlieveHKCdxcwEFjKs(int P_0)
				{
					if (P_0 < 0)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					Joystick joystick = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (joystick == null)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					ControllerPollingInfo result = joystick.PollForFirstElement();
					if (result.success)
					{
						result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
					}
					return result;
				}

				private ControllerPollingInfo PINRdbgCNHgbBBophHjmKFebSPL(int P_0)
				{
					if (P_0 < 0)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					Joystick joystick = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (joystick == null)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					ControllerPollingInfo result = joystick.PollForFirstElementDown();
					if (result.success)
					{
						result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
					}
					return result;
				}

				private ControllerPollingInfo jXGyRogRekagpnPbsovMZcORmlz(int P_0)
				{
					if (P_0 < 0)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					Joystick joystick = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (joystick == null)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					ControllerPollingInfo result = joystick.PollForFirstButton();
					if (result.success)
					{
						result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
					}
					return result;
				}

				private ControllerPollingInfo bzErKaudNUvvRVXzcBcTzoynwJS(int P_0)
				{
					if (P_0 < 0)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					Joystick joystick = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (joystick == null)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					ControllerPollingInfo result = joystick.PollForFirstButtonDown();
					if (result.success)
					{
						result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
					}
					return result;
				}

				private ControllerPollingInfo QdhsUuUATkmjfEEmEDKBEqczBoST(int P_0)
				{
					if (P_0 < 0)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					Joystick joystick = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (joystick == null)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					ControllerPollingInfo result = joystick.PollForFirstAxis();
					if (result.success)
					{
						result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
					}
					return result;
				}

				private IEnumerable<ControllerPollingInfo> xpDUdxqSuaTPBBnHlLwVOegJYFo(int P_0)
				{
					if (P_0 < 0)
					{
						yield break;
					}
					Joystick joystick = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (joystick == null)
					{
						yield break;
					}
					foreach (ControllerPollingInfo item in joystick.PollForAllElements())
					{
						yield return new ControllerPollingInfo(item)
						{
							playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
						};
					}
				}

				private IEnumerable<ControllerPollingInfo> lLAtBllNQBhsvTvRnJvLvReRhEW(int P_0)
				{
					if (P_0 < 0)
					{
						yield break;
					}
					Joystick joystick = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (joystick == null)
					{
						yield break;
					}
					foreach (ControllerPollingInfo item in joystick.PollForAllElementsDown())
					{
						yield return new ControllerPollingInfo(item)
						{
							playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
						};
					}
				}

				private IEnumerable<ControllerPollingInfo> VRujVIWJTMntXvwGsGDplKkxXny(int P_0)
				{
					if (P_0 < 0)
					{
						yield break;
					}
					Joystick joystick = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (joystick == null)
					{
						yield break;
					}
					foreach (ControllerPollingInfo item in joystick.PollForAllButtons())
					{
						yield return new ControllerPollingInfo(item)
						{
							playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
						};
					}
				}

				private IEnumerable<ControllerPollingInfo> szOpKikkzpaEIcUHFehTguzgPMof(int P_0)
				{
					if (P_0 < 0)
					{
						yield break;
					}
					Joystick joystick = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (joystick == null)
					{
						yield break;
					}
					foreach (ControllerPollingInfo item in joystick.PollForAllButtonsDown())
					{
						yield return new ControllerPollingInfo(item)
						{
							playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
						};
					}
				}

				private IEnumerable<ControllerPollingInfo> wSHzXdHCCCkZVjhgKzQvGcEhMzd(int P_0)
				{
					if (P_0 < 0)
					{
						yield break;
					}
					Joystick joystick = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (joystick == null)
					{
						yield break;
					}
					foreach (ControllerPollingInfo item in joystick.PollForAllAxes())
					{
						yield return new ControllerPollingInfo(item)
						{
							playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
						};
					}
				}

				private ControllerPollingInfo BPbBTtVObmgXNwUwpliGxSWnECJ()
				{
					IList<Joystick> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						ControllerPollingInfo result = controllers_readOnly[i].PollForFirstElement();
						if (result.success)
						{
							result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo VfLYSZjkQXiMjnsjxcZJGATBiGa()
				{
					IList<Joystick> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						ControllerPollingInfo result = controllers_readOnly[i].PollForFirstElementDown();
						if (result.success)
						{
							result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo hKGvFBMZdfTHLXvbpEwKgahVKKY()
				{
					IList<Joystick> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						ControllerPollingInfo result = controllers_readOnly[i].PollForFirstButton();
						if (result.success)
						{
							result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo zcFsYwMOpAENHfhLAKmpPnxiFbY()
				{
					IList<Joystick> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						ControllerPollingInfo result = controllers_readOnly[i].PollForFirstButtonDown();
						if (result.success)
						{
							result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo wooBmHpbqPpndBLyQIDyvHKjBTN()
				{
					IList<Joystick> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						Joystick joystick = controllers_readOnly[i];
						ControllerPollingInfo result = joystick.PollForFirstAxis();
						if (result.success)
						{
							result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private IEnumerable<ControllerPollingInfo> AzVqsenrgyjMFPcZwzHqOwexZ()
				{
					IList<Joystick> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						foreach (ControllerPollingInfo item in controllers_readOnly[i].PollForAllElements())
						{
							yield return new ControllerPollingInfo(item)
							{
								playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
							};
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> NszfsFfWjchsTlWOMKKPqghYedHD()
				{
					IList<Joystick> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						foreach (ControllerPollingInfo item in controllers_readOnly[i].PollForAllElementsDown())
						{
							yield return new ControllerPollingInfo(item)
							{
								playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
							};
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> dKtaKDnZSUiuRZZqwpYqFFNprOI()
				{
					IList<Joystick> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						foreach (ControllerPollingInfo item in controllers_readOnly[i].PollForAllButtons())
						{
							yield return new ControllerPollingInfo(item)
							{
								playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
							};
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> ABxExjalTAYSjARAGvGqFrwzEJX()
				{
					IList<Joystick> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						foreach (ControllerPollingInfo item in controllers_readOnly[i].PollForAllButtonsDown())
						{
							yield return new ControllerPollingInfo(item)
							{
								playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
							};
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> weRLHaWslOoGuMJDDvVgqpbuILF()
				{
					IList<Joystick> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.joystickSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						foreach (ControllerPollingInfo item in controllers_readOnly[i].PollForAllAxes())
						{
							yield return new ControllerPollingInfo(item)
							{
								playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
							};
						}
					}
				}

				private ControllerPollingInfo lQLJhbEfcNBpedPNxNFzjfsgToLX()
				{
					if (!mQXiYotjnToDecfWIRfktslJAMQ.AvUUXWlMnmDnSPiqlLZBlpDhtFM)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.Keyboard.PollForFirstKey();
				}

				private ControllerPollingInfo SeblWPqDnAwVQgRSeiLCKHnatdj()
				{
					if (!mQXiYotjnToDecfWIRfktslJAMQ.AvUUXWlMnmDnSPiqlLZBlpDhtFM)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.Keyboard.PollForFirstKeyDown();
				}

				private IEnumerable<ControllerPollingInfo> IZSVrgfNDwGCdgvessMRhggZLQgY()
				{
					if (!mQXiYotjnToDecfWIRfktslJAMQ.AvUUXWlMnmDnSPiqlLZBlpDhtFM)
					{
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.Keyboard.PollForAllKeys();
				}

				private IEnumerable<ControllerPollingInfo> apQRyVyUghxUmSBkAuvbdyHXPep()
				{
					if (!mQXiYotjnToDecfWIRfktslJAMQ.AvUUXWlMnmDnSPiqlLZBlpDhtFM)
					{
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.Keyboard.PollForAllKeysDown();
				}

				private ControllerPollingInfo NZgCGvSQdAcxwOsJhcPYZrtlZtP()
				{
					if (!mQXiYotjnToDecfWIRfktslJAMQ.vOUBXSpvHVbZCuutJoqhhChowtG)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.Mouse.PollForFirstElement();
				}

				private ControllerPollingInfo CvbMVrTXhYHDrZIKlqJuHDkmKiC()
				{
					if (!mQXiYotjnToDecfWIRfktslJAMQ.vOUBXSpvHVbZCuutJoqhhChowtG)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.Mouse.PollForFirstElementDown();
				}

				private ControllerPollingInfo ObTeBSvMSaaDdnPPqAbhskKZHAdC()
				{
					if (!mQXiYotjnToDecfWIRfktslJAMQ.vOUBXSpvHVbZCuutJoqhhChowtG)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.Mouse.PollForFirstButton();
				}

				private ControllerPollingInfo sGHuqzQOGzcrfEGQoLNvfBTntnea()
				{
					if (!mQXiYotjnToDecfWIRfktslJAMQ.vOUBXSpvHVbZCuutJoqhhChowtG)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.Mouse.PollForFirstButtonDown();
				}

				private ControllerPollingInfo GWhvCPrVslWzDoGyWALfdiLKRDO()
				{
					if (!mQXiYotjnToDecfWIRfktslJAMQ.vOUBXSpvHVbZCuutJoqhhChowtG)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.Mouse.PollForFirstAxis();
				}

				private IEnumerable<ControllerPollingInfo> jPLyPLzcSArYFOTUKzvTQkUkbJp()
				{
					if (!mQXiYotjnToDecfWIRfktslJAMQ.vOUBXSpvHVbZCuutJoqhhChowtG)
					{
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.Mouse.PollForAllElements();
				}

				private IEnumerable<ControllerPollingInfo> bTPHzlFyxXdnZzalVQcCJOTrnLU()
				{
					if (!mQXiYotjnToDecfWIRfktslJAMQ.vOUBXSpvHVbZCuutJoqhhChowtG)
					{
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.Mouse.PollForAllElementsDown();
				}

				private IEnumerable<ControllerPollingInfo> IVbwFLpVnCkALhUvotTfVyfcovQ()
				{
					if (!mQXiYotjnToDecfWIRfktslJAMQ.vOUBXSpvHVbZCuutJoqhhChowtG)
					{
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.Mouse.PollForAllButtons();
				}

				private IEnumerable<ControllerPollingInfo> klwBobIERIaKmQrJbuIRqXnCDdx()
				{
					if (!mQXiYotjnToDecfWIRfktslJAMQ.vOUBXSpvHVbZCuutJoqhhChowtG)
					{
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.Mouse.PollForAllButtonsDown();
				}

				private IEnumerable<ControllerPollingInfo> iQzhrBuoddEtyLIrXIKpafbXLYG()
				{
					if (!mQXiYotjnToDecfWIRfktslJAMQ.vOUBXSpvHVbZCuutJoqhhChowtG)
					{
						return EmptyObjects<ControllerPollingInfo>.EmptyReadOnlyIListT;
					}
					return mQXiYotjnToDecfWIRfktslJAMQ.Mouse.PollForAllAxes();
				}

				private ControllerPollingInfo EjjcotHQwjOrcjDCNdOiZhRJao(int P_0)
				{
					if (P_0 < 0)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					CustomController customController = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (customController == null)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					ControllerPollingInfo result = customController.PollForFirstElement();
					if (result.success)
					{
						result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
					}
					return result;
				}

				private ControllerPollingInfo mDTDlLnbANrUcKCXBAiHMgZsubb(int P_0)
				{
					if (P_0 < 0)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					CustomController customController = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (customController == null)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					ControllerPollingInfo result = customController.PollForFirstElementDown();
					if (result.success)
					{
						result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
					}
					return result;
				}

				private ControllerPollingInfo zarblPCArDmlgkrGigwXkLLcoSB(int P_0)
				{
					if (P_0 < 0)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					CustomController customController = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (customController == null)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					ControllerPollingInfo result = customController.PollForFirstButton();
					if (result.success)
					{
						result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
					}
					return result;
				}

				private ControllerPollingInfo gnHfMCLpAFYVnLppXwqccWNuFJL(int P_0)
				{
					if (P_0 < 0)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					CustomController customController = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (customController == null)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					ControllerPollingInfo result = customController.PollForFirstButtonDown();
					if (result.success)
					{
						result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
					}
					return result;
				}

				private ControllerPollingInfo AhjiLtixSxCgsmHtcYKddubNNGQ(int P_0)
				{
					if (P_0 < 0)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					CustomController customController = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (customController == null)
					{
						return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
					}
					ControllerPollingInfo result = customController.PollForFirstAxis();
					if (result.success)
					{
						result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
					}
					return result;
				}

				private IEnumerable<ControllerPollingInfo> IaBOVUDboXOIbBLjBJAwjnfYgBE(int P_0)
				{
					if (P_0 < 0)
					{
						yield break;
					}
					CustomController customController = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (customController == null)
					{
						yield break;
					}
					foreach (ControllerPollingInfo item in customController.PollForAllElements())
					{
						yield return new ControllerPollingInfo(item)
						{
							playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
						};
					}
				}

				private IEnumerable<ControllerPollingInfo> xKzBrkaSqCaXLhjlQPXoecQynjm(int P_0)
				{
					if (P_0 < 0)
					{
						yield break;
					}
					CustomController customController = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (customController == null)
					{
						yield break;
					}
					foreach (ControllerPollingInfo item in customController.PollForAllElementsDown())
					{
						yield return new ControllerPollingInfo(item)
						{
							playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
						};
					}
				}

				private IEnumerable<ControllerPollingInfo> kRYqsNOSSrRYeaLmeLUQrDufBYp(int P_0)
				{
					if (P_0 < 0)
					{
						yield break;
					}
					CustomController customController = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (customController == null)
					{
						yield break;
					}
					foreach (ControllerPollingInfo item in customController.PollForAllButtons())
					{
						yield return new ControllerPollingInfo(item)
						{
							playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
						};
					}
				}

				private IEnumerable<ControllerPollingInfo> kfGQZXiEzkPHzVsTtdnEwTduphS(int P_0)
				{
					if (P_0 < 0)
					{
						yield break;
					}
					CustomController customController = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (customController == null)
					{
						yield break;
					}
					foreach (ControllerPollingInfo item in customController.PollForAllButtonsDown())
					{
						yield return new ControllerPollingInfo(item)
						{
							playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
						};
					}
				}

				private IEnumerable<ControllerPollingInfo> lvpLGtUELtSBrrbPLfUjdDVukXp(int P_0)
				{
					if (P_0 < 0)
					{
						yield break;
					}
					CustomController customController = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.RAcjlNtCncziVZzKMoHKTIJjxln(P_0);
					if (customController == null)
					{
						yield break;
					}
					foreach (ControllerPollingInfo item in customController.PollForAllAxes())
					{
						yield return new ControllerPollingInfo(item)
						{
							playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
						};
					}
				}

				private ControllerPollingInfo GWmZWnlHxFEUXieGzCzMXyqSnuO()
				{
					IList<CustomController> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						ControllerPollingInfo result = controllers_readOnly[i].PollForFirstElement();
						if (result.success)
						{
							result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo tTXahHrgTVligFjVfbqIqtLOsQW()
				{
					IList<CustomController> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						ControllerPollingInfo result = controllers_readOnly[i].PollForFirstElementDown();
						if (result.success)
						{
							result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo TeEcjHksFDwZLuxeBsznKVzDVrn()
				{
					IList<CustomController> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						ControllerPollingInfo result = controllers_readOnly[i].PollForFirstButton();
						if (result.success)
						{
							result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo vvIEmvquKUQmjMeXbFoiRcSXWZH()
				{
					IList<CustomController> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						ControllerPollingInfo result = controllers_readOnly[i].PollForFirstButtonDown();
						if (result.success)
						{
							result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private ControllerPollingInfo UKQZncxGBDkovrkuDNVNTIVgZGh()
				{
					IList<CustomController> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						CustomController customController = controllers_readOnly[i];
						ControllerPollingInfo result = customController.PollForFirstAxis();
						if (result.success)
						{
							result.playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri;
							return result;
						}
					}
					return ControllerPollingInfo.KOYWVvhauJtKnlvZgtMSFRXPIUf();
				}

				private IEnumerable<ControllerPollingInfo> FJsdirYVehxggDNSpATebPqSyUL()
				{
					IList<CustomController> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						foreach (ControllerPollingInfo item in controllers_readOnly[i].PollForAllElements())
						{
							yield return new ControllerPollingInfo(item)
							{
								playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
							};
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> flTRoHvnTZQDXDPFONfTCBadGuK()
				{
					IList<CustomController> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						foreach (ControllerPollingInfo item in controllers_readOnly[i].PollForAllElementsDown())
						{
							yield return new ControllerPollingInfo(item)
							{
								playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
							};
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> uRbYFjBCCoODZEUnbkZRjIAjbUS()
				{
					IList<CustomController> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						foreach (ControllerPollingInfo item in controllers_readOnly[i].PollForAllButtons())
						{
							yield return new ControllerPollingInfo(item)
							{
								playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
							};
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> EnxdkYulKwfpxyFmfgQJAIYPqeZV()
				{
					IList<CustomController> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						foreach (ControllerPollingInfo item in controllers_readOnly[i].PollForAllButtonsDown())
						{
							yield return new ControllerPollingInfo(item)
							{
								playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
							};
						}
					}
				}

				private IEnumerable<ControllerPollingInfo> GsGSsIYMnOWfesNExUbMzDxaLMb()
				{
					IList<CustomController> controllers_readOnly = mQXiYotjnToDecfWIRfktslJAMQ.customControllerSet.ZwlsmACtCRubGDNUtxYtMjhmISC;
					int count = controllers_readOnly.Count;
					for (int i = 0; i < count; i++)
					{
						foreach (ControllerPollingInfo item in controllers_readOnly[i].PollForAllAxes())
						{
							yield return new ControllerPollingInfo(item)
							{
								playerId = QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri
							};
						}
					}
				}
			}

			private readonly YjaFpcJTsgTKMFdMcpSeyatdmMem ABFRtFGewGBlnFCXDBmfEJGKiLo;

			private bool vOUBXSpvHVbZCuutJoqhhChowtG;

			private bool AvUUXWlMnmDnSPiqlLZBlpDhtFM;

			private bool zFHFuVqDqJrSoiMNIuzlWRpbaAY;

			private double VNVFSKeJFsIEbzsVqKKuCGDWXhU;

			private double FYhaGsSrJROJNlrGnfBAmdGhiqmc;

			private SafeAction<ControllerAssignmentChangedEventArgs> RICNPBfGkKFgeHDiLBKIeIlKpvM = new SafeAction<ControllerAssignmentChangedEventArgs>(delegate(Exception P_0)
			{
				ReInput.HandleCallbackException("Player.ControllerHelper.ControllerAddedEvent", P_0);
			});

			private SafeAction<ControllerAssignmentChangedEventArgs> OMgxGCUBLiypPRuxmqVJpaLpTGv = new SafeAction<ControllerAssignmentChangedEventArgs>(delegate(Exception P_0)
			{
				ReInput.HandleCallbackException("Player.ControllerHelper.ControllerRemovedEvent", P_0);
			});

			private readonly VXBoNHtgnKLLBJDGZBmIlDeVkgE tWaggyJPBcRxwyAUFZkujNIcHgO;

			private readonly Player QFlXjfmiJabcsMblLziegHSMCLfJ;

			private readonly wochuutpqUYXkdPLzqHhRFuJCAO dkugfFkVCtTWFFqVQkfYWmwUgQB;

			private readonly int PivQvdYMhUssuLwaglJVqkqXMSH;

			public readonly MapHelper maps;

			public readonly ConflictCheckingHelper conflictChecking;

			public readonly PollingHelper polling;

			[CompilerGenerated]
			private static Action<Exception> suQFSecMyJYdyKWXbLbVEMkNddOe;

			[CompilerGenerated]
			private static Action<Exception> kcHgEtKYhqtwzTPOvvORFEUwYnJ;

			private IcESaAjemNGWngcrzWaBSsruFXF<Joystick, JoystickMap> joystickSet => (IcESaAjemNGWngcrzWaBSsruFXF<Joystick, JoystickMap>)ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Joystick);

			private global::gHFgzSPsLtKjGAtobRtDQKtpUvu<KeyboardMap> keyboardMapSet => (global::gHFgzSPsLtKjGAtobRtDQKtpUvu<KeyboardMap>)ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Keyboard).UHzLoQtWuAoHLAFsVljNrYZrrEC(0).JYKAxzbcwrkvXFkdyALvVdvpDkeE;

			private global::gHFgzSPsLtKjGAtobRtDQKtpUvu<MouseMap> mouseMapSet => (global::gHFgzSPsLtKjGAtobRtDQKtpUvu<MouseMap>)ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Mouse).UHzLoQtWuAoHLAFsVljNrYZrrEC(0).JYKAxzbcwrkvXFkdyALvVdvpDkeE;

			private IcESaAjemNGWngcrzWaBSsruFXF<CustomController, CustomControllerMap> customControllerSet => (IcESaAjemNGWngcrzWaBSsruFXF<CustomController, CustomControllerMap>)ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Custom);

			public bool hasMouse
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					return vOUBXSpvHVbZCuutJoqhhChowtG;
				}
				set
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						if (vOUBXSpvHVbZCuutJoqhhChowtG == value)
						{
							return;
						}
						vOUBXSpvHVbZCuutJoqhhChowtG = value;
						if (value)
						{
							dkugfFkVCtTWFFqVQkfYWmwUgQB.rXfrpsKYmqSvVJAFxhmUjsiGnVlp(Mouse);
						}
						else
						{
							dkugfFkVCtTWFFqVQkfYWmwUgQB.QGwSMXaWKSCNARuGHBNVpuHCjHs(Mouse);
						}
						if (value)
						{
							maps.layoutManager.Apply();
							if (RICNPBfGkKFgeHDiLBKIeIlKpvM.Count > 0)
							{
								RICNPBfGkKFgeHDiLBKIeIlKpvM.Invoke(new ControllerAssignmentChangedEventArgs(QFlXjfmiJabcsMblLziegHSMCLfJ.id, ReInput.controllers.Mouse.id, ControllerType.Mouse, value));
							}
						}
						else if (OMgxGCUBLiypPRuxmqVJpaLpTGv.Count > 0)
						{
							OMgxGCUBLiypPRuxmqVJpaLpTGv.Invoke(new ControllerAssignmentChangedEventArgs(QFlXjfmiJabcsMblLziegHSMCLfJ.id, ReInput.controllers.Mouse.id, ControllerType.Mouse, value));
						}
					}
				}
			}

			public bool hasKeyboard
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					return AvUUXWlMnmDnSPiqlLZBlpDhtFM;
				}
				set
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						if (AvUUXWlMnmDnSPiqlLZBlpDhtFM == value)
						{
							return;
						}
						AvUUXWlMnmDnSPiqlLZBlpDhtFM = value;
						if (value)
						{
							dkugfFkVCtTWFFqVQkfYWmwUgQB.rXfrpsKYmqSvVJAFxhmUjsiGnVlp(Keyboard);
						}
						else
						{
							dkugfFkVCtTWFFqVQkfYWmwUgQB.QGwSMXaWKSCNARuGHBNVpuHCjHs(Keyboard);
						}
						if (value)
						{
							maps.layoutManager.Apply();
							if (RICNPBfGkKFgeHDiLBKIeIlKpvM.Count > 0)
							{
								RICNPBfGkKFgeHDiLBKIeIlKpvM.Invoke(new ControllerAssignmentChangedEventArgs(QFlXjfmiJabcsMblLziegHSMCLfJ.id, ReInput.controllers.Keyboard.id, ControllerType.Keyboard, value));
							}
						}
						else if (OMgxGCUBLiypPRuxmqVJpaLpTGv.Count > 0)
						{
							OMgxGCUBLiypPRuxmqVJpaLpTGv.Invoke(new ControllerAssignmentChangedEventArgs(QFlXjfmiJabcsMblLziegHSMCLfJ.id, ReInput.controllers.Keyboard.id, ControllerType.Keyboard, value));
						}
					}
				}
			}

			public bool excludeFromControllerAutoAssignment
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return false;
					}
					return zFHFuVqDqJrSoiMNIuzlWRpbaAY;
				}
				set
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						zFHFuVqDqJrSoiMNIuzlWRpbaAY = value;
					}
				}
			}

			public Keyboard Keyboard
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return ReInput.controllers.Keyboard;
				}
			}

			public Mouse Mouse
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return null;
					}
					return ReInput.controllers.Mouse;
				}
			}

			public int joystickCount
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					return ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Joystick).ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
				}
			}

			public IList<Joystick> Joysticks
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<Joystick>.EmptyReadOnlyIListT;
					}
					return (ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Joystick) as IcESaAjemNGWngcrzWaBSsruFXF<Joystick, JoystickMap>).ZwlsmACtCRubGDNUtxYtMjhmISC;
				}
			}

			public int customControllerCount
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return 0;
					}
					return ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Custom).ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
				}
			}

			public IList<CustomController> CustomControllers
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						return EmptyObjects<CustomController>.EmptyReadOnlyIListT;
					}
					return (ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Custom) as IcESaAjemNGWngcrzWaBSsruFXF<CustomController, CustomControllerMap>).ZwlsmACtCRubGDNUtxYtMjhmISC;
				}
			}

			public IEnumerable<Controller> Controllers
			{
				get
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
						yield break;
					}
					if (vOUBXSpvHVbZCuutJoqhhChowtG)
					{
						yield return Mouse;
					}
					if (AvUUXWlMnmDnSPiqlLZBlpDhtFM)
					{
						yield return Keyboard;
					}
					int num = joystickCount;
					IList<Joystick> joysticks = Joysticks;
					for (int i = 0; i < num; i++)
					{
						yield return joysticks[i];
					}
					int num2 = customControllerCount;
					IList<CustomController> customControllers = CustomControllers;
					for (int j = 0; j < num2; j++)
					{
						yield return customControllers[j];
					}
				}
			}

			public event Action<ControllerAssignmentChangedEventArgs> ControllerAddedEvent
			{
				add
				{
					RICNPBfGkKFgeHDiLBKIeIlKpvM.AddDelegate(value);
				}
				remove
				{
					RICNPBfGkKFgeHDiLBKIeIlKpvM.RemoveDelegate(value);
				}
			}

			public event Action<ControllerAssignmentChangedEventArgs> ControllerRemovedEvent
			{
				add
				{
					OMgxGCUBLiypPRuxmqVJpaLpTGv.AddDelegate(value);
				}
				remove
				{
					OMgxGCUBLiypPRuxmqVJpaLpTGv.RemoveDelegate(value);
				}
			}

			internal ControllerHelper(Player player, hoGZGoKcYjvzMpyhYIdlAPtnxIh startingControllerMapInfo, ControllerMapLayoutManager.lRHvetoYBHZvdHTlYVwfdpCPcAs controllerMapLayoutManagerSettings, ControllerMapEnabler.xIhBRlVXbtrPkJZqdoJCRHAyPSc controllerMapEnablerSettings)
			{
				PivQvdYMhUssuLwaglJVqkqXMSH = ReInput.id;
				QFlXjfmiJabcsMblLziegHSMCLfJ = player;
				maps = new MapHelper(player, this, startingControllerMapInfo, controllerMapLayoutManagerSettings, controllerMapEnablerSettings);
				polling = new PollingHelper(player, this);
				conflictChecking = new ConflictCheckingHelper(player, this);
				ABFRtFGewGBlnFCXDBmfEJGKiLo = new YjaFpcJTsgTKMFdMcpSeyatdmMem(4);
				ABFRtFGewGBlnFCXDBmfEJGKiLo.IYxGjOMqHIcQgesHtAraamCepwNe(0, ControllerType.Joystick, new IcESaAjemNGWngcrzWaBSsruFXF<Joystick, JoystickMap>());
				ABFRtFGewGBlnFCXDBmfEJGKiLo.IYxGjOMqHIcQgesHtAraamCepwNe(1, ControllerType.Keyboard, new IcESaAjemNGWngcrzWaBSsruFXF<Keyboard, KeyboardMap>());
				ABFRtFGewGBlnFCXDBmfEJGKiLo.IYxGjOMqHIcQgesHtAraamCepwNe(2, ControllerType.Mouse, new IcESaAjemNGWngcrzWaBSsruFXF<Mouse, MouseMap>());
				ABFRtFGewGBlnFCXDBmfEJGKiLo.IYxGjOMqHIcQgesHtAraamCepwNe(3, ControllerType.Custom, new IcESaAjemNGWngcrzWaBSsruFXF<CustomController, CustomControllerMap>());
				tWaggyJPBcRxwyAUFZkujNIcHgO = new VXBoNHtgnKLLBJDGZBmIlDeVkgE(player);
				dkugfFkVCtTWFFqVQkfYWmwUgQB = new wochuutpqUYXkdPLzqHhRFuJCAO(UnityTools.externalTools.GetControllerTemplateTypes(), UnityTools.externalTools.GetControllerTemplateInterfaceTypes());
			}

			public T GetController<T>(int controllerId) where T : Controller
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return (T)ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(BbpfTcGSZRHmltstKOfXrucHPJO.MCqTpqfPfAfEfejTBeFbGkgGaXhu<T>()).RAcjlNtCncziVZzKMoHKTIJjxln(controllerId);
			}

			public Controller GetController(ControllerType controllerType, int controllerId)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType).RAcjlNtCncziVZzKMoHKTIJjxln(controllerId);
			}

			public T GetControllerWithTag<T>(string tag) where T : Controller
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return (T)ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(BbpfTcGSZRHmltstKOfXrucHPJO.MCqTpqfPfAfEfejTBeFbGkgGaXhu<T>()).zMVBLXbZSXJvHEqgBWiFdbaslwo(tag);
			}

			public Controller GetControllerWithTag(ControllerType controllerType, string tag)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(controllerType).zMVBLXbZSXJvHEqgBWiFdbaslwo(tag);
			}

			public void AddController<T>(int controllerId, bool removeFromOtherPlayers) where T : Controller
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return;
				}
				Type typeFromHandle = typeof(T);
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Joystick)))
				{
					jXcIleFqupiPcaNOuNJYVoHIGet(controllerId, removeFromOtherPlayers);
					return;
				}
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Keyboard)))
				{
					AddController(ControllerType.Keyboard, controllerId, removeFromOtherPlayers);
					return;
				}
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Mouse)))
				{
					AddController(ControllerType.Mouse, controllerId, removeFromOtherPlayers);
					return;
				}
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(CustomController)))
				{
					heurBGDGCDjNAitaNAkazXKYoIv(controllerId, removeFromOtherPlayers);
					return;
				}
				throw new NotImplementedException();
			}

			public void AddController(Controller controller, bool removeFromOtherPlayers)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else if (controller != null)
				{
					switch (controller.type)
					{
					case ControllerType.Joystick:
						jXcIleFqupiPcaNOuNJYVoHIGet(controller as Joystick, removeFromOtherPlayers);
						break;
					case ControllerType.Keyboard:
						AddController(controller.type, controller.id, removeFromOtherPlayers);
						break;
					case ControllerType.Mouse:
						AddController(controller.type, controller.id, removeFromOtherPlayers);
						break;
					case ControllerType.Custom:
						heurBGDGCDjNAitaNAkazXKYoIv(controller as CustomController, removeFromOtherPlayers);
						break;
					default:
						throw new NotImplementedException();
					}
				}
			}

			public void AddController(ControllerType controllerType, int controllerId, bool removeFromOtherPlayers)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return;
				}
				switch (controllerType)
				{
				case ControllerType.Joystick:
					jXcIleFqupiPcaNOuNJYVoHIGet(ReInput.controllers.GetController(controllerType, controllerId) as Joystick, removeFromOtherPlayers);
					break;
				case ControllerType.Keyboard:
					if (removeFromOtherPlayers)
					{
						ReInput.controllers.RemoveControllerFromAllPlayers(controllerType, controllerId);
					}
					hasKeyboard = true;
					break;
				case ControllerType.Mouse:
					if (removeFromOtherPlayers)
					{
						ReInput.controllers.RemoveControllerFromAllPlayers(controllerType, controllerId);
					}
					hasMouse = true;
					break;
				case ControllerType.Custom:
					heurBGDGCDjNAitaNAkazXKYoIv(ReInput.controllers.GetController(controllerType, controllerId) as CustomController, removeFromOtherPlayers);
					break;
				default:
					throw new NotImplementedException();
				}
			}

			public void RemoveController<T>(int controllerId) where T : Controller
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return;
				}
				Type typeFromHandle = typeof(T);
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Joystick)))
				{
					JWZmhyjAyCCSfFSFTwjTOGtVJIh(controllerId);
					return;
				}
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Keyboard)))
				{
					RemoveController(ControllerType.Keyboard, 0);
					return;
				}
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Mouse)))
				{
					RemoveController(ControllerType.Mouse, 0);
					return;
				}
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(CustomController)))
				{
					bPqJQkzKFDbRgIQpDdYVjahWPJBg(controllerId);
					return;
				}
				throw new NotImplementedException();
			}

			public void RemoveController(ControllerType controllerType, int controllerId)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return;
				}
				switch (controllerType)
				{
				case ControllerType.Joystick:
					JWZmhyjAyCCSfFSFTwjTOGtVJIh(controllerId);
					break;
				case ControllerType.Keyboard:
					hasKeyboard = false;
					break;
				case ControllerType.Mouse:
					hasMouse = false;
					break;
				case ControllerType.Custom:
					bPqJQkzKFDbRgIQpDdYVjahWPJBg(controllerId);
					break;
				default:
					throw new NotImplementedException();
				}
			}

			public void RemoveController(Controller controller)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else if (controller != null)
				{
					switch (controller.type)
					{
					case ControllerType.Joystick:
						JWZmhyjAyCCSfFSFTwjTOGtVJIh(controller as Joystick);
						break;
					case ControllerType.Keyboard:
						hasKeyboard = false;
						break;
					case ControllerType.Mouse:
						hasMouse = false;
						break;
					case ControllerType.Custom:
						bPqJQkzKFDbRgIQpDdYVjahWPJBg(controller as CustomController);
						break;
					default:
						throw new NotImplementedException();
					}
				}
			}

			public bool ContainsController<T>(int controllerId) where T : Controller
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return false;
				}
				Type typeFromHandle = typeof(T);
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Joystick)))
				{
					return ContainsController(ControllerType.Joystick, controllerId);
				}
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Keyboard)))
				{
					return AvUUXWlMnmDnSPiqlLZBlpDhtFM;
				}
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Mouse)))
				{
					return vOUBXSpvHVbZCuutJoqhhChowtG;
				}
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(CustomController)))
				{
					return ContainsController(ControllerType.Custom, controllerId);
				}
				throw new NotImplementedException();
			}

			public bool ContainsController(ControllerType controllerType, int controllerId)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return false;
				}
				return controllerType switch
				{
					ControllerType.Joystick => ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Joystick).oQFygjrDaMtXNUGnYpOhqPuoBesB(controllerId), 
					ControllerType.Keyboard => AvUUXWlMnmDnSPiqlLZBlpDhtFM, 
					ControllerType.Mouse => vOUBXSpvHVbZCuutJoqhhChowtG, 
					ControllerType.Custom => ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Custom).oQFygjrDaMtXNUGnYpOhqPuoBesB(controllerId), 
					_ => throw new NotImplementedException(), 
				};
			}

			public bool ContainsController(Controller controller)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return false;
				}
				if (controller == null)
				{
					return false;
				}
				return ContainsController(controller.type, controller.id);
			}

			public void ClearControllersOfType<T>() where T : Controller
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return;
				}
				Type typeFromHandle = typeof(T);
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Joystick)))
				{
					xoXlCkarddDqwdSNGEYQSspSqJq();
					return;
				}
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Keyboard)))
				{
					hasKeyboard = false;
					return;
				}
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(Mouse)))
				{
					hasMouse = false;
					return;
				}
				if (ReflectionTools.DoesTypeImplement(typeFromHandle, typeof(CustomController)))
				{
					ILAaOYbQIzDjkDLUVSqWkmgAKpka();
					return;
				}
				if (object.ReferenceEquals(typeFromHandle, typeof(Controller)))
				{
					ClearAllControllers();
					return;
				}
				throw new NotImplementedException();
			}

			public void ClearControllersOfType(ControllerType controllerType)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return;
				}
				switch (controllerType)
				{
				case ControllerType.Joystick:
					xoXlCkarddDqwdSNGEYQSspSqJq();
					break;
				case ControllerType.Keyboard:
					hasKeyboard = false;
					break;
				case ControllerType.Mouse:
					hasMouse = false;
					break;
				case ControllerType.Custom:
					ILAaOYbQIzDjkDLUVSqWkmgAKpka();
					break;
				default:
					throw new NotImplementedException();
				}
			}

			public void ClearAllControllers()
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return;
				}
				xoXlCkarddDqwdSNGEYQSspSqJq();
				ILAaOYbQIzDjkDLUVSqWkmgAKpka();
				hasMouse = false;
				hasKeyboard = false;
			}

			public Controller GetLastActiveController()
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				Controller result = null;
				double num = 0.0;
				khwzwOcakzDikccnveJzjAgUCGAB(ControllerType.Joystick, ref result, ref num);
				if (vOUBXSpvHVbZCuutJoqhhChowtG && VNVFSKeJFsIEbzsVqKKuCGDWXhU > num)
				{
					result = Mouse;
					num = VNVFSKeJFsIEbzsVqKKuCGDWXhU;
				}
				if (AvUUXWlMnmDnSPiqlLZBlpDhtFM && FYhaGsSrJROJNlrGnfBAmdGhiqmc > num)
				{
					result = Keyboard;
					num = FYhaGsSrJROJNlrGnfBAmdGhiqmc;
				}
				khwzwOcakzDikccnveJzjAgUCGAB(ControllerType.Custom, ref result, ref num);
				return result;
			}

			public Controller GetLastActiveController(ControllerType controllerType)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				Controller result = null;
				double num = 0.0;
				switch (controllerType)
				{
				case ControllerType.Joystick:
				case ControllerType.Custom:
					khwzwOcakzDikccnveJzjAgUCGAB(controllerType, ref result, ref num);
					break;
				case ControllerType.Keyboard:
					if (AvUUXWlMnmDnSPiqlLZBlpDhtFM && FYhaGsSrJROJNlrGnfBAmdGhiqmc > 0.0)
					{
						result = Keyboard;
					}
					break;
				case ControllerType.Mouse:
					if (vOUBXSpvHVbZCuutJoqhhChowtG && VNVFSKeJFsIEbzsVqKKuCGDWXhU > 0.0)
					{
						result = Mouse;
					}
					break;
				default:
					throw new NotImplementedException();
				}
				return result;
			}

			private void khwzwOcakzDikccnveJzjAgUCGAB(ControllerType P_0, ref Controller P_1, ref double P_2)
			{
				UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
				int count = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
				for (int i = 0; i < count; i++)
				{
					double lastActiveTime = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).uTRYjniBIJOmiFWRrBPmOajohcO;
					if (!(lastActiveTime <= P_2))
					{
						P_1 = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(i).TWofsWdWcZrFDlgktqaiXknQuRD;
						P_2 = lastActiveTime;
					}
				}
			}

			public Controller GetLastActiveController<T>() where T : Controller
			{
				return GetLastActiveController(BbpfTcGSZRHmltstKOfXrucHPJO.MCqTpqfPfAfEfejTBeFbGkgGaXhu<T>());
			}

			public void AddLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback)
			{
				if (ReInput.isReady)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						QFlXjfmiJabcsMblLziegHSMCLfJ.mvrCdGRIOFGaMUOTuzwAwqCUSAr.ouxUDDBduHJbdBSMXcegTHpIIOy(QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri, callback);
					}
				}
			}

			public void AddLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback, ControllerType controllerType)
			{
				if (ReInput.isReady)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						QFlXjfmiJabcsMblLziegHSMCLfJ.mvrCdGRIOFGaMUOTuzwAwqCUSAr.ouxUDDBduHJbdBSMXcegTHpIIOy(QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri, callback, controllerType);
					}
				}
			}

			public void RemoveLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback)
			{
				if (ReInput.isReady)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						QFlXjfmiJabcsMblLziegHSMCLfJ.mvrCdGRIOFGaMUOTuzwAwqCUSAr.yYpaOdJbPCSCDaDDXsrqJjzhQNs(QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri, callback);
					}
				}
			}

			public void RemoveLastActiveControllerChangedDelegate(PlayerActiveControllerChangedDelegate callback, ControllerType controllerType)
			{
				if (ReInput.isReady)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						QFlXjfmiJabcsMblLziegHSMCLfJ.mvrCdGRIOFGaMUOTuzwAwqCUSAr.yYpaOdJbPCSCDaDDXsrqJjzhQNs(QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri, callback, controllerType);
					}
				}
			}

			public void ClearLastActiveControllerChangedDelegates()
			{
				if (ReInput.isReady)
				{
					if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
					{
						ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					}
					else
					{
						QFlXjfmiJabcsMblLziegHSMCLfJ.mvrCdGRIOFGaMUOTuzwAwqCUSAr.PCAliDlBQkIBjxLpZAIBzFcEAjc(QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri);
					}
				}
			}

			public Controller GetFirstControllerWithTemplate(Guid templateTypeGuid)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
				for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
				{
					Controller controller = NBBbYAqZOtfOEWzpwIfWcFrfeap(ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(i).kEHmRBonufPaXwWSSWlSciOdvWy, Controller.implementsTemplateDelegate_Guid, templateTypeGuid);
					if (controller != null)
					{
						return controller;
					}
				}
				return null;
			}

			public Controller GetFirstControllerWithTemplate(Type templateType)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				int ioXgUGjpFGeVuGnqwbPHBeKgnSzF = ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
				for (int i = 0; i < ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
				{
					Controller controller = NBBbYAqZOtfOEWzpwIfWcFrfeap(ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(i).kEHmRBonufPaXwWSSWlSciOdvWy, Controller.implementsTemplateDelegate_Type, templateType);
					if (controller != null)
					{
						return controller;
					}
				}
				return null;
			}

			public Controller GetFirstControllerWithTemplate<T>() where T : class
			{
				return GetFirstControllerWithTemplate(typeof(T));
			}

			public IList<TInterface> GetControllerTemplates<TInterface>() where TInterface : IControllerTemplate
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return EmptyObjects<TInterface>.EmptyReadOnlyIListT;
				}
				return dkugfFkVCtTWFFqVQkfYWmwUgQB.lNQimYThrafnaIoBhBJyUhJMjHA<TInterface>();
			}

			private Controller NBBbYAqZOtfOEWzpwIfWcFrfeap<TDelegateParam>(ControllerType P_0, Func<Controller, TDelegateParam, bool> P_1, TDelegateParam P_2)
			{
				switch (P_0)
				{
				case ControllerType.Joystick:
				{
					int num2 = joystickCount;
					IList<Joystick> joysticks = Joysticks;
					for (int j = 0; j < num2; j++)
					{
						if (P_1(joysticks[j], P_2))
						{
							return joysticks[j];
						}
					}
					return null;
				}
				case ControllerType.Keyboard:
					if (AvUUXWlMnmDnSPiqlLZBlpDhtFM && P_1(Keyboard, P_2))
					{
						return Keyboard;
					}
					return null;
				case ControllerType.Mouse:
					if (vOUBXSpvHVbZCuutJoqhhChowtG && P_1(Mouse, P_2))
					{
						return Mouse;
					}
					return null;
				case ControllerType.Custom:
				{
					int num = customControllerCount;
					IList<CustomController> customControllers = CustomControllers;
					for (int i = 0; i < num; i++)
					{
						if (P_1(customControllers[i], P_2))
						{
							return customControllers[i];
						}
					}
					return null;
				}
				default:
					throw new NotImplementedException();
				}
			}

			internal void ijQPrfbohIDtyfCSvLMVhrlmSpB()
			{
				for (int i = 0; i < ABFRtFGewGBlnFCXDBmfEJGKiLo.ioXgUGjpFGeVuGnqwbPHBeKgnSzF; i++)
				{
					ABFRtFGewGBlnFCXDBmfEJGKiLo.nGoeHQQFrJEctOmWrfOcOGAwdob(i).LlCkzvOeJVaCziTDPktzBWuYotAZ();
				}
				ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Keyboard).IZbaudhWyBbPeJpvcIZQLOAuOFCc(new IcESaAjemNGWngcrzWaBSsruFXF<Keyboard, KeyboardMap>.eQaARQwlcakzPaJCLRZmbjzCHZE(ReInput.CoyPNJHWMheFytmTMQdqyctMRFl.VptHLZXdJfMsrxxJFwCBsNGGFnMF, new global::gHFgzSPsLtKjGAtobRtDQKtpUvu<KeyboardMap>(0)));
				ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Mouse).IZbaudhWyBbPeJpvcIZQLOAuOFCc(new IcESaAjemNGWngcrzWaBSsruFXF<Mouse, MouseMap>.eQaARQwlcakzPaJCLRZmbjzCHZE(ReInput.CoyPNJHWMheFytmTMQdqyctMRFl.iBsunrzpmNRGjincwoFXBCjHvrY, new global::gHFgzSPsLtKjGAtobRtDQKtpUvu<MouseMap>(0)));
				tWaggyJPBcRxwyAUFZkujNIcHgO.LlCkzvOeJVaCziTDPktzBWuYotAZ();
				FYhaGsSrJROJNlrGnfBAmdGhiqmc = 0.0;
				VNVFSKeJFsIEbzsVqKKuCGDWXhU = 0.0;
				maps.ijQPrfbohIDtyfCSvLMVhrlmSpB();
			}

			internal double dfdOiowwLZcMZBIipiTiccpUkTG(int P_0)
			{
				return tWaggyJPBcRxwyAUFZkujNIcHgO.qsbDEOfbSUzywOGZSmnkKKrjfAW(P_0)?.FxyJuJaCCTESVvQMYBylPtXljFT ?? (-1.0);
			}

			internal void jXcIleFqupiPcaNOuNJYVoHIGet(Joystick P_0, bool P_1)
			{
				if (P_0 == null)
				{
					return;
				}
				UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Joystick);
				if (uatpsZKPeFXZcGHRylaqbbrOzNO.oQFygjrDaMtXNUGnYpOhqPuoBesB(P_0.id))
				{
					return;
				}
				if (P_1)
				{
					ReInput.controllers.RemoveJoystickFromAllPlayers(P_0);
				}
				VXBoNHtgnKLLBJDGZBmIlDeVkgE.IhutOmkxTxJFmqGgDPFKTuVBQbd ihutOmkxTxJFmqGgDPFKTuVBQbd = tWaggyJPBcRxwyAUFZkujNIcHgO.qsbDEOfbSUzywOGZSmnkKKrjfAW(P_0.id);
				IcESaAjemNGWngcrzWaBSsruFXF<Joystick, JoystickMap>.eQaARQwlcakzPaJCLRZmbjzCHZE eQaARQwlcakzPaJCLRZmbjzCHZE;
				if (ihutOmkxTxJFmqGgDPFKTuVBQbd != null && ihutOmkxTxJFmqGgDPFKTuVBQbd.JYKAxzbcwrkvXFkdyALvVdvpDkeE != null)
				{
					eQaARQwlcakzPaJCLRZmbjzCHZE = new IcESaAjemNGWngcrzWaBSsruFXF<Joystick, JoystickMap>.eQaARQwlcakzPaJCLRZmbjzCHZE(P_0, ihutOmkxTxJFmqGgDPFKTuVBQbd.JYKAxzbcwrkvXFkdyALvVdvpDkeE);
				}
				else
				{
					global::gHFgzSPsLtKjGAtobRtDQKtpUvu<JoystickMap> gHFgzSPsLtKjGAtobRtDQKtpUvu = maps.coprcYULrnmEHTxIxavieooLEsq(P_0, true);
					if (gHFgzSPsLtKjGAtobRtDQKtpUvu == null)
					{
						gHFgzSPsLtKjGAtobRtDQKtpUvu = new global::gHFgzSPsLtKjGAtobRtDQKtpUvu<JoystickMap>(P_0.id);
					}
					eQaARQwlcakzPaJCLRZmbjzCHZE = new IcESaAjemNGWngcrzWaBSsruFXF<Joystick, JoystickMap>.eQaARQwlcakzPaJCLRZmbjzCHZE(P_0, gHFgzSPsLtKjGAtobRtDQKtpUvu);
				}
				uatpsZKPeFXZcGHRylaqbbrOzNO.IZbaudhWyBbPeJpvcIZQLOAuOFCc(eQaARQwlcakzPaJCLRZmbjzCHZE);
				tWaggyJPBcRxwyAUFZkujNIcHgO.ROWDMagIyIfgsVWhoSroKVHpUgvW(eQaARQwlcakzPaJCLRZmbjzCHZE);
				dkugfFkVCtTWFFqVQkfYWmwUgQB.rXfrpsKYmqSvVJAFxhmUjsiGnVlp(P_0);
				maps.layoutManager.Apply();
				if (RICNPBfGkKFgeHDiLBKIeIlKpvM.Count > 0)
				{
					RICNPBfGkKFgeHDiLBKIeIlKpvM.Invoke(new ControllerAssignmentChangedEventArgs(QFlXjfmiJabcsMblLziegHSMCLfJ.id, P_0.id, ControllerType.Joystick, state: true));
				}
			}

			internal void jXcIleFqupiPcaNOuNJYVoHIGet(int P_0, bool P_1)
			{
				Joystick joystick = ReInput.controllers.GetJoystick(P_0);
				if (joystick != null)
				{
					jXcIleFqupiPcaNOuNJYVoHIGet(joystick, P_1);
				}
			}

			internal void JWZmhyjAyCCSfFSFTwjTOGtVJIh(int P_0)
			{
				UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Joystick);
				if (uatpsZKPeFXZcGHRylaqbbrOzNO.oQFygjrDaMtXNUGnYpOhqPuoBesB(P_0))
				{
					if (uatpsZKPeFXZcGHRylaqbbrOzNO.UHzLoQtWuAoHLAFsVljNrYZrrEC(P_0) is IcESaAjemNGWngcrzWaBSsruFXF<Joystick, JoystickMap>.eQaARQwlcakzPaJCLRZmbjzCHZE eQaARQwlcakzPaJCLRZmbjzCHZE)
					{
						tWaggyJPBcRxwyAUFZkujNIcHgO.ROWDMagIyIfgsVWhoSroKVHpUgvW(eQaARQwlcakzPaJCLRZmbjzCHZE);
					}
					uatpsZKPeFXZcGHRylaqbbrOzNO.trkLxqDkOLvKrmFNndzuxOPolzd(P_0);
					Joystick joystick = ReInput.controllers.GetJoystick(P_0);
					dkugfFkVCtTWFFqVQkfYWmwUgQB.QGwSMXaWKSCNARuGHBNVpuHCjHs(joystick);
					if (OMgxGCUBLiypPRuxmqVJpaLpTGv.Count > 0)
					{
						OMgxGCUBLiypPRuxmqVJpaLpTGv.Invoke(new ControllerAssignmentChangedEventArgs(QFlXjfmiJabcsMblLziegHSMCLfJ.id, joystick.id, ControllerType.Joystick, state: false));
					}
				}
			}

			internal void JWZmhyjAyCCSfFSFTwjTOGtVJIh(Joystick P_0)
			{
				if (P_0 != null)
				{
					JWZmhyjAyCCSfFSFTwjTOGtVJIh(P_0.id);
				}
			}

			internal void xoXlCkarddDqwdSNGEYQSspSqJq()
			{
				UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Joystick);
				for (int num = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF - 1; num >= 0; num--)
				{
					tWaggyJPBcRxwyAUFZkujNIcHgO.ROWDMagIyIfgsVWhoSroKVHpUgvW(uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num) as IcESaAjemNGWngcrzWaBSsruFXF<Joystick, JoystickMap>.eQaARQwlcakzPaJCLRZmbjzCHZE);
					dkugfFkVCtTWFFqVQkfYWmwUgQB.QGwSMXaWKSCNARuGHBNVpuHCjHs(uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).TWofsWdWcZrFDlgktqaiXknQuRD);
					int id = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).TWofsWdWcZrFDlgktqaiXknQuRD.id;
					uatpsZKPeFXZcGHRylaqbbrOzNO.OtHEMvEtwLDLiaSXftVcvELMffBm(num);
					if (OMgxGCUBLiypPRuxmqVJpaLpTGv.Count > 0)
					{
						OMgxGCUBLiypPRuxmqVJpaLpTGv.Invoke(new ControllerAssignmentChangedEventArgs(QFlXjfmiJabcsMblLziegHSMCLfJ.id, id, ControllerType.Joystick, state: false));
					}
				}
				uatpsZKPeFXZcGHRylaqbbrOzNO.LlCkzvOeJVaCziTDPktzBWuYotAZ();
			}

			internal void heurBGDGCDjNAitaNAkazXKYoIv(CustomController P_0, bool P_1)
			{
				if (P_0 == null)
				{
					return;
				}
				UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Custom);
				if (!uatpsZKPeFXZcGHRylaqbbrOzNO.oQFygjrDaMtXNUGnYpOhqPuoBesB(P_0.id))
				{
					if (P_1)
					{
						ReInput.controllers.RemoveCustomControllerFromAllPlayers(P_0);
					}
					global::gHFgzSPsLtKjGAtobRtDQKtpUvu<CustomControllerMap> gHFgzSPsLtKjGAtobRtDQKtpUvu = maps.nDyFEZHezZGUactAHTwZWHPhhIOE(P_0, true);
					if (gHFgzSPsLtKjGAtobRtDQKtpUvu == null)
					{
						gHFgzSPsLtKjGAtobRtDQKtpUvu = new global::gHFgzSPsLtKjGAtobRtDQKtpUvu<CustomControllerMap>(P_0.id);
					}
					IcESaAjemNGWngcrzWaBSsruFXF<CustomController, CustomControllerMap>.eQaARQwlcakzPaJCLRZmbjzCHZE eQaARQwlcakzPaJCLRZmbjzCHZE = new IcESaAjemNGWngcrzWaBSsruFXF<CustomController, CustomControllerMap>.eQaARQwlcakzPaJCLRZmbjzCHZE(P_0, gHFgzSPsLtKjGAtobRtDQKtpUvu);
					uatpsZKPeFXZcGHRylaqbbrOzNO.IZbaudhWyBbPeJpvcIZQLOAuOFCc(eQaARQwlcakzPaJCLRZmbjzCHZE);
					dkugfFkVCtTWFFqVQkfYWmwUgQB.rXfrpsKYmqSvVJAFxhmUjsiGnVlp(P_0);
					maps.layoutManager.Apply();
					if (RICNPBfGkKFgeHDiLBKIeIlKpvM.Count > 0)
					{
						RICNPBfGkKFgeHDiLBKIeIlKpvM.Invoke(new ControllerAssignmentChangedEventArgs(QFlXjfmiJabcsMblLziegHSMCLfJ.id, P_0.id, ControllerType.Custom, state: true));
					}
				}
			}

			internal void heurBGDGCDjNAitaNAkazXKYoIv(int P_0, bool P_1)
			{
				CustomController customController = ReInput.controllers.GetCustomController(P_0);
				if (customController != null)
				{
					heurBGDGCDjNAitaNAkazXKYoIv(customController, P_1);
				}
			}

			internal void bPqJQkzKFDbRgIQpDdYVjahWPJBg(int P_0)
			{
				UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Custom);
				if (uatpsZKPeFXZcGHRylaqbbrOzNO.oQFygjrDaMtXNUGnYpOhqPuoBesB(P_0))
				{
					uatpsZKPeFXZcGHRylaqbbrOzNO.UHzLoQtWuAoHLAFsVljNrYZrrEC(P_0);
					uatpsZKPeFXZcGHRylaqbbrOzNO.trkLxqDkOLvKrmFNndzuxOPolzd(P_0);
					CustomController customController = ReInput.controllers.GetCustomController(P_0);
					dkugfFkVCtTWFFqVQkfYWmwUgQB.QGwSMXaWKSCNARuGHBNVpuHCjHs(customController);
					if (OMgxGCUBLiypPRuxmqVJpaLpTGv.Count > 0)
					{
						OMgxGCUBLiypPRuxmqVJpaLpTGv.Invoke(new ControllerAssignmentChangedEventArgs(QFlXjfmiJabcsMblLziegHSMCLfJ.id, customController.id, ControllerType.Custom, state: false));
					}
				}
			}

			internal void bPqJQkzKFDbRgIQpDdYVjahWPJBg(CustomController P_0)
			{
				if (P_0 != null)
				{
					bPqJQkzKFDbRgIQpDdYVjahWPJBg(P_0.id);
				}
			}

			internal void ILAaOYbQIzDjkDLUVSqWkmgAKpka()
			{
				UatpsZKPeFXZcGHRylaqbbrOzNO uatpsZKPeFXZcGHRylaqbbrOzNO = ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Custom);
				for (int num = uatpsZKPeFXZcGHRylaqbbrOzNO.ioXgUGjpFGeVuGnqwbPHBeKgnSzF - 1; num >= 0; num--)
				{
					dkugfFkVCtTWFFqVQkfYWmwUgQB.QGwSMXaWKSCNARuGHBNVpuHCjHs(uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).TWofsWdWcZrFDlgktqaiXknQuRD);
					int id = uatpsZKPeFXZcGHRylaqbbrOzNO.get_Item(num).TWofsWdWcZrFDlgktqaiXknQuRD.id;
					uatpsZKPeFXZcGHRylaqbbrOzNO.OtHEMvEtwLDLiaSXftVcvELMffBm(num);
					if (OMgxGCUBLiypPRuxmqVJpaLpTGv.Count > 0)
					{
						OMgxGCUBLiypPRuxmqVJpaLpTGv.Invoke(new ControllerAssignmentChangedEventArgs(QFlXjfmiJabcsMblLziegHSMCLfJ.id, id, ControllerType.Custom, state: false));
					}
				}
				uatpsZKPeFXZcGHRylaqbbrOzNO.LlCkzvOeJVaCziTDPktzBWuYotAZ();
			}

			internal CustomController udmwaShPdzxbUpFVwBKjiHdbMIeF(int P_0)
			{
				CustomController customController = QFlXjfmiJabcsMblLziegHSMCLfJ.mvrCdGRIOFGaMUOTuzwAwqCUSAr.udmwaShPdzxbUpFVwBKjiHdbMIeF(P_0);
				if (customController == null)
				{
					return null;
				}
				heurBGDGCDjNAitaNAkazXKYoIv(customController, false);
				return customController;
			}

			internal void ZZkvtkppBBqtsYXTUtwpTHHXACJ(Action<bool, int, int> P_0)
			{
				GSEdsYCjBXqDSNWhZfzILKqLZDWv<Joystick, JoystickMap>(ControllerType.Joystick, P_0);
			}

			internal void gRNXUCzdDePTRJxogGIYuaawYlC(Keyboard P_0, RNWQZBxFpDLQTySzjFNrTBtiTEt P_1, Action<bool, int, int> P_2)
			{
				if (!AvUUXWlMnmDnSPiqlLZBlpDhtFM || !P_0.enabled)
				{
					return;
				}
				gYrADBpnMkBBqSxPmkMFiVbrqev wUHNaEsGCLdpFDvelpmVJPotYVAb = XrsxaFoSedDmSEVIidqjOjugISoF.WUHNaEsGCLdpFDvelpmVJPotYVAb;
				bool flag = false;
				SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Keyboard).UHzLoQtWuAoHLAFsVljNrYZrrEC(0).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
				int count = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
				for (int i = 0; i < count; i++)
				{
					KeyboardMap keyboardMap = (KeyboardMap)mapSet.get_Item(i);
					if (!keyboardMap.enabled)
					{
						continue;
					}
					AList<ActionElementMap> buttonMaps_orig = keyboardMap.ButtonMaps_orig;
					int count2 = buttonMaps_orig._count;
					for (int j = 0; j < count2; j++)
					{
						ActionElementMap actionElementMap = buttonMaps_orig._items[j];
						if (!actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM)
						{
							continue;
						}
						int actionId = actionElementMap._actionId;
						bool flag2 = actionElementMap._modifierKey1 != 0 || actionElementMap._modifierKey2 != 0 || actionElementMap._modifierKey3 != ModifierKey.None;
						KeyboardKeyCode keyboardKeyCode = actionElementMap._keyboardKeyCode;
						bool flag3 = false;
						ModifierKeyFlags modifierKeyFlags;
						jSernrZtwfgFWhWGiBVhaYtxNfl jSernrZtwfgFWhWGiBVhaYtxNfl;
						if (flag2)
						{
							modifierKeyFlags = actionElementMap.modifierKeyFlags;
							if (P_0.wbATQgOLQewsaRBOOMImAFIaeMaI(keyboardKeyCode, modifierKeyFlags))
							{
								if (!P_1.flrSyPrdXSUCxHEzcrynAQOqfDd(keyboardKeyCode, modifierKeyFlags))
								{
									jSernrZtwfgFWhWGiBVhaYtxNfl = jSernrZtwfgFWhWGiBVhaYtxNfl.bxMoFoqvmPaQLIJckPsRmJGDrlE(actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri);
									jSernrZtwfgFWhWGiBVhaYtxNfl.YToveGdcRHkKMwBHduKuPAzLFOu(ReInput.currentUpdateLoop, true);
									flag3 = true;
									goto IL_0120;
								}
							}
							else
							{
								jSernrZtwfgFWhWGiBVhaYtxNfl = jSernrZtwfgFWhWGiBVhaYtxNfl.sezeDwIhqSxIrrYLXmDBFGqFFqh(actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri);
								if (jSernrZtwfgFWhWGiBVhaYtxNfl != null)
								{
									goto IL_0120;
								}
							}
							goto IL_0177;
						}
						modifierKeyFlags = ModifierKeyFlags.None;
						ButtonStateFlags buttonStateFlags = P_0.ClqyccpJBHwIUEvwLoXaOpaAqJW(actionElementMap.UgYKpPGXoJUWiIrkuIiAFetRZuI);
						goto IL_013e;
						IL_013e:
						if (buttonStateFlags != 0 && (flag3 || !P_1.flrSyPrdXSUCxHEzcrynAQOqfDd(keyboardKeyCode, modifierKeyFlags)))
						{
							rMbQzHfmUhLeJBOaXbMswYzusVf(P_0, keyboardMap, actionElementMap, wUHNaEsGCLdpFDvelpmVJPotYVAb, buttonStateFlags);
							P_2(arg1: true, QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri, actionId);
							flag = true;
							continue;
						}
						goto IL_0177;
						IL_0120:
						buttonStateFlags = jSernrZtwfgFWhWGiBVhaYtxNfl.WMPgPQJeUOrYvQehNDottdeoomhB(true);
						goto IL_013e;
						IL_0177:
						if (wUHNaEsGCLdpFDvelpmVJPotYVAb.foSRcEqSuRsWnadDiKcGnhBewOU != 0f)
						{
							wUHNaEsGCLdpFDvelpmVJPotYVAb.foSRcEqSuRsWnadDiKcGnhBewOU = 0f;
						}
						if (wUHNaEsGCLdpFDvelpmVJPotYVAb.ZFLUvHIyNpevfqxjpbxCqlZKrBi != 0)
						{
							wUHNaEsGCLdpFDvelpmVJPotYVAb.ZFLUvHIyNpevfqxjpbxCqlZKrBi = ButtonStateFlags.DyTkQiNnAPnZlOxrECHYhBSslIv;
						}
						P_2(arg1: false, QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri, actionId);
					}
				}
				if (flag)
				{
					FYhaGsSrJROJNlrGnfBAmdGhiqmc = ReInput.unscaledTime;
				}
			}

			private static void rMbQzHfmUhLeJBOaXbMswYzusVf(Keyboard P_0, ControllerMap P_1, ActionElementMap P_2, gYrADBpnMkBBqSxPmkMFiVbrqev P_3, ButtonStateFlags P_4)
			{
				float num = (((P_4 & ButtonStateFlags.AgsjzxPUGELGeHFAPrimMZoZTDX) != 0) ? 1f : 0f);
				if (num != 0f && P_2._axisContribution == Pole.Negative)
				{
					num *= -1f;
				}
				P_3.foSRcEqSuRsWnadDiKcGnhBewOU = num;
				P_3.ZFLUvHIyNpevfqxjpbxCqlZKrBi = P_4;
				P_3.TWofsWdWcZrFDlgktqaiXknQuRD = P_0;
				P_3.kEHmRBonufPaXwWSSWlSciOdvWy = ControllerType.Keyboard;
				P_3.DffVgxLTxGtWFSQnSTfYIAPKKDj = ControllerElementType.Button;
				P_3.LAuRCWsrqJRFKOmBPvyBpCEIKop = P_2;
				P_3.bLXFjMcXvYEkCgtXBNCHEQazALWK = P_1;
				if (P_3.QRuzmzFzlSSWUjQjSFUBDsXXdtR)
				{
					P_3.QRuzmzFzlSSWUjQjSFUBDsXXdtR = false;
				}
				if (P_3.pwqkIczUIliYnxirDGkPRbHIWxk)
				{
					P_3.pwqkIczUIliYnxirDGkPRbHIWxk = false;
				}
			}

			internal void lbBaLWzRWbJzYibFQOIRrYkjXn(Mouse P_0, Action<bool, int, int> P_1)
			{
				if (!vOUBXSpvHVbZCuutJoqhhChowtG || !P_0.enabled)
				{
					return;
				}
				SXQDlPgGRIYIShDiTzLBebiUKvNw mapSet = ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(ControllerType.Mouse).UHzLoQtWuAoHLAFsVljNrYZrrEC(0).JYKAxzbcwrkvXFkdyALvVdvpDkeE;
				gYrADBpnMkBBqSxPmkMFiVbrqev wUHNaEsGCLdpFDvelpmVJPotYVAb = XrsxaFoSedDmSEVIidqjOjugISoF.WUHNaEsGCLdpFDvelpmVJPotYVAb;
				bool flag = false;
				int count = mapSet.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
				for (int i = 0; i < count; i++)
				{
					MouseMap mouseMap = (MouseMap)mapSet.get_Item(i);
					if (!mouseMap.enabled)
					{
						continue;
					}
					AList<ActionElementMap> axisMaps_orig = mouseMap.AxisMaps_orig;
					if (axisMaps_orig != null)
					{
						int count2 = axisMaps_orig._count;
						for (int j = 0; j < count2; j++)
						{
							ActionElementMap actionElementMap = axisMaps_orig._items[j];
							if (!actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM || actionElementMap._elementType != 0)
							{
								continue;
							}
							int actionId = actionElementMap._actionId;
							if (!P_0.zUVKdUvdiPydLmPiiMfZwUgISZR(actionElementMap, actionId, true, false, out var num))
							{
								continue;
							}
							if (num == 0f)
							{
								P_0.zUVKdUvdiPydLmPiiMfZwUgISZR(actionElementMap, actionId, true, true, out var num2);
								if (num2 == 0f)
								{
									P_1(arg1: false, QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri, actionId);
									continue;
								}
							}
							wUHNaEsGCLdpFDvelpmVJPotYVAb.foSRcEqSuRsWnadDiKcGnhBewOU = num;
							wUHNaEsGCLdpFDvelpmVJPotYVAb.TWofsWdWcZrFDlgktqaiXknQuRD = P_0;
							wUHNaEsGCLdpFDvelpmVJPotYVAb.kEHmRBonufPaXwWSSWlSciOdvWy = ControllerType.Mouse;
							wUHNaEsGCLdpFDvelpmVJPotYVAb.DffVgxLTxGtWFSQnSTfYIAPKKDj = ControllerElementType.Axis;
							wUHNaEsGCLdpFDvelpmVJPotYVAb.LAuRCWsrqJRFKOmBPvyBpCEIKop = actionElementMap;
							wUHNaEsGCLdpFDvelpmVJPotYVAb.bLXFjMcXvYEkCgtXBNCHEQazALWK = mouseMap;
							if (wUHNaEsGCLdpFDvelpmVJPotYVAb.pwqkIczUIliYnxirDGkPRbHIWxk)
							{
								wUHNaEsGCLdpFDvelpmVJPotYVAb.pwqkIczUIliYnxirDGkPRbHIWxk = false;
							}
							if (wUHNaEsGCLdpFDvelpmVJPotYVAb.NryHUqyjZpeWlAgANeIKxxZwaMMC != AxisCoordinateMode.Relative)
							{
								wUHNaEsGCLdpFDvelpmVJPotYVAb.NryHUqyjZpeWlAgANeIKxxZwaMMC = AxisCoordinateMode.Relative;
							}
							P_1(arg1: true, QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri, actionId);
							flag = true;
						}
					}
					AList<ActionElementMap> buttonMaps_orig = mouseMap.ButtonMaps_orig;
					if (buttonMaps_orig == null)
					{
						continue;
					}
					int count3 = buttonMaps_orig._count;
					for (int k = 0; k < count3; k++)
					{
						ActionElementMap actionElementMap2 = buttonMaps_orig._items[k];
						if (!actionElementMap2.nZTtfeZBpthDaoAvSONdTABGEaM || actionElementMap2._elementType != ControllerElementType.Button)
						{
							continue;
						}
						int actionId2 = actionElementMap2._actionId;
						if (!P_0.HvDZItSAoowpoblGiTywvlDVobM(actionElementMap2, actionId2, out var foSRcEqSuRsWnadDiKcGnhBewOU, out wUHNaEsGCLdpFDvelpmVJPotYVAb.QRuzmzFzlSSWUjQjSFUBDsXXdtR))
						{
							continue;
						}
						ButtonStateFlags buttonStateFlags = P_0.ClqyccpJBHwIUEvwLoXaOpaAqJW(actionElementMap2.UgYKpPGXoJUWiIrkuIiAFetRZuI);
						if (buttonStateFlags == ButtonStateFlags.DyTkQiNnAPnZlOxrECHYhBSslIv)
						{
							P_1(arg1: false, QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri, actionId2);
							continue;
						}
						wUHNaEsGCLdpFDvelpmVJPotYVAb.foSRcEqSuRsWnadDiKcGnhBewOU = foSRcEqSuRsWnadDiKcGnhBewOU;
						wUHNaEsGCLdpFDvelpmVJPotYVAb.ZFLUvHIyNpevfqxjpbxCqlZKrBi = buttonStateFlags;
						wUHNaEsGCLdpFDvelpmVJPotYVAb.TWofsWdWcZrFDlgktqaiXknQuRD = P_0;
						wUHNaEsGCLdpFDvelpmVJPotYVAb.kEHmRBonufPaXwWSSWlSciOdvWy = ControllerType.Mouse;
						wUHNaEsGCLdpFDvelpmVJPotYVAb.DffVgxLTxGtWFSQnSTfYIAPKKDj = ControllerElementType.Button;
						wUHNaEsGCLdpFDvelpmVJPotYVAb.LAuRCWsrqJRFKOmBPvyBpCEIKop = actionElementMap2;
						wUHNaEsGCLdpFDvelpmVJPotYVAb.bLXFjMcXvYEkCgtXBNCHEQazALWK = mouseMap;
						if (wUHNaEsGCLdpFDvelpmVJPotYVAb.QRuzmzFzlSSWUjQjSFUBDsXXdtR)
						{
							wUHNaEsGCLdpFDvelpmVJPotYVAb.QRuzmzFzlSSWUjQjSFUBDsXXdtR = false;
						}
						if (wUHNaEsGCLdpFDvelpmVJPotYVAb.pwqkIczUIliYnxirDGkPRbHIWxk)
						{
							wUHNaEsGCLdpFDvelpmVJPotYVAb.pwqkIczUIliYnxirDGkPRbHIWxk = false;
						}
						P_1(arg1: true, QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri, actionId2);
						flag = true;
					}
				}
				if (flag)
				{
					VNVFSKeJFsIEbzsVqKKuCGDWXhU = ReInput.unscaledTime;
				}
			}

			internal void VbxayShkGwHGcSriawazYKPJEMg(Action<bool, int, int> P_0)
			{
				GSEdsYCjBXqDSNWhZfzILKqLZDWv<CustomController, CustomControllerMap>(ControllerType.Custom, P_0);
			}

			private void GSEdsYCjBXqDSNWhZfzILKqLZDWv<T, TMap>(ControllerType P_0, Action<bool, int, int> P_1) where T : ControllerWithAxes where TMap : ControllerMapWithAxes
			{
				IcESaAjemNGWngcrzWaBSsruFXF<T, TMap> icESaAjemNGWngcrzWaBSsruFXF = (IcESaAjemNGWngcrzWaBSsruFXF<T, TMap>)ABFRtFGewGBlnFCXDBmfEJGKiLo.rDKxChtDNsieXfOckVhIIKbyGxDA(P_0);
				gYrADBpnMkBBqSxPmkMFiVbrqev wUHNaEsGCLdpFDvelpmVJPotYVAb = XrsxaFoSedDmSEVIidqjOjugISoF.WUHNaEsGCLdpFDvelpmVJPotYVAb;
				int count = icESaAjemNGWngcrzWaBSsruFXF.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
				for (int i = 0; i < count; i++)
				{
					IcESaAjemNGWngcrzWaBSsruFXF<T, TMap>.eQaARQwlcakzPaJCLRZmbjzCHZE eQaARQwlcakzPaJCLRZmbjzCHZE = icESaAjemNGWngcrzWaBSsruFXF.get_Item(i);
					T tWofsWdWcZrFDlgktqaiXknQuRD = eQaARQwlcakzPaJCLRZmbjzCHZE.TWofsWdWcZrFDlgktqaiXknQuRD;
					if (!tWofsWdWcZrFDlgktqaiXknQuRD.enabled)
					{
						continue;
					}
					global::gHFgzSPsLtKjGAtobRtDQKtpUvu<TMap> jYKAxzbcwrkvXFkdyALvVdvpDkeE = eQaARQwlcakzPaJCLRZmbjzCHZE.JYKAxzbcwrkvXFkdyALvVdvpDkeE;
					bool flag = false;
					int count2 = jYKAxzbcwrkvXFkdyALvVdvpDkeE.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
					for (int j = 0; j < count2; j++)
					{
						TMap bLXFjMcXvYEkCgtXBNCHEQazALWK = jYKAxzbcwrkvXFkdyALvVdvpDkeE.get_Item(j);
						if (!bLXFjMcXvYEkCgtXBNCHEQazALWK.enabled)
						{
							continue;
						}
						AList<ActionElementMap> axisMaps_orig = bLXFjMcXvYEkCgtXBNCHEQazALWK.AxisMaps_orig;
						if (axisMaps_orig != null)
						{
							int count3 = axisMaps_orig._count;
							for (int k = 0; k < count3; k++)
							{
								ActionElementMap actionElementMap = axisMaps_orig._items[k];
								if (!actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM || actionElementMap._elementType != 0)
								{
									continue;
								}
								int actionId = actionElementMap._actionId;
								if (!tWofsWdWcZrFDlgktqaiXknQuRD.zUVKdUvdiPydLmPiiMfZwUgISZR(actionElementMap, actionId, false, false, out var num))
								{
									continue;
								}
								if (num == 0f)
								{
									tWofsWdWcZrFDlgktqaiXknQuRD.zUVKdUvdiPydLmPiiMfZwUgISZR(actionElementMap, actionId, false, true, out var num2);
									if (num2 == 0f)
									{
										P_1(arg1: false, QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri, actionId);
										continue;
									}
								}
								wUHNaEsGCLdpFDvelpmVJPotYVAb.foSRcEqSuRsWnadDiKcGnhBewOU = num;
								wUHNaEsGCLdpFDvelpmVJPotYVAb.TWofsWdWcZrFDlgktqaiXknQuRD = tWofsWdWcZrFDlgktqaiXknQuRD;
								wUHNaEsGCLdpFDvelpmVJPotYVAb.kEHmRBonufPaXwWSSWlSciOdvWy = P_0;
								wUHNaEsGCLdpFDvelpmVJPotYVAb.DffVgxLTxGtWFSQnSTfYIAPKKDj = ControllerElementType.Axis;
								wUHNaEsGCLdpFDvelpmVJPotYVAb.LAuRCWsrqJRFKOmBPvyBpCEIKop = actionElementMap;
								wUHNaEsGCLdpFDvelpmVJPotYVAb.bLXFjMcXvYEkCgtXBNCHEQazALWK = bLXFjMcXvYEkCgtXBNCHEQazALWK;
								wUHNaEsGCLdpFDvelpmVJPotYVAb.pwqkIczUIliYnxirDGkPRbHIWxk = tWofsWdWcZrFDlgktqaiXknQuRD.calibrationMap.Axes[actionElementMap.UgYKpPGXoJUWiIrkuIiAFetRZuI].applyRangeCalibration;
								wUHNaEsGCLdpFDvelpmVJPotYVAb.NryHUqyjZpeWlAgANeIKxxZwaMMC = tWofsWdWcZrFDlgktqaiXknQuRD.Axes[actionElementMap.elementIndex].LFHpDfBYTFpZGnHfuiJaFQDzksL?._dataFormat ?? AxisCoordinateMode.Absolute;
								P_1(arg1: true, QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri, actionId);
								flag = true;
							}
						}
						AList<ActionElementMap> buttonMaps_orig = bLXFjMcXvYEkCgtXBNCHEQazALWK.ButtonMaps_orig;
						if (buttonMaps_orig != null)
						{
							int count4 = buttonMaps_orig._count;
							for (int l = 0; l < count4; l++)
							{
								ActionElementMap actionElementMap2 = buttonMaps_orig._items[l];
								if (!actionElementMap2.nZTtfeZBpthDaoAvSONdTABGEaM || actionElementMap2._elementType != ControllerElementType.Button)
								{
									continue;
								}
								int actionId2 = actionElementMap2._actionId;
								float foSRcEqSuRsWnadDiKcGnhBewOU = 0f;
								int ugYKpPGXoJUWiIrkuIiAFetRZuI = actionElementMap2.UgYKpPGXoJUWiIrkuIiAFetRZuI;
								if (!niYxrwcDflQIeSggqrFbcJVihPZ(tWofsWdWcZrFDlgktqaiXknQuRD, i, ugYKpPGXoJUWiIrkuIiAFetRZuI, actionElementMap2, jYKAxzbcwrkvXFkdyALvVdvpDkeE, actionId2, ref foSRcEqSuRsWnadDiKcGnhBewOU) && !tWofsWdWcZrFDlgktqaiXknQuRD.HvDZItSAoowpoblGiTywvlDVobM(actionElementMap2, actionId2, out foSRcEqSuRsWnadDiKcGnhBewOU, out wUHNaEsGCLdpFDvelpmVJPotYVAb.QRuzmzFzlSSWUjQjSFUBDsXXdtR))
								{
									continue;
								}
								ButtonStateFlags buttonStateFlags = tWofsWdWcZrFDlgktqaiXknQuRD.ClqyccpJBHwIUEvwLoXaOpaAqJW(actionElementMap2.UgYKpPGXoJUWiIrkuIiAFetRZuI);
								if (buttonStateFlags == ButtonStateFlags.DyTkQiNnAPnZlOxrECHYhBSslIv)
								{
									P_1(arg1: false, QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri, actionId2);
									continue;
								}
								wUHNaEsGCLdpFDvelpmVJPotYVAb.foSRcEqSuRsWnadDiKcGnhBewOU = foSRcEqSuRsWnadDiKcGnhBewOU;
								wUHNaEsGCLdpFDvelpmVJPotYVAb.ZFLUvHIyNpevfqxjpbxCqlZKrBi = buttonStateFlags;
								wUHNaEsGCLdpFDvelpmVJPotYVAb.TWofsWdWcZrFDlgktqaiXknQuRD = tWofsWdWcZrFDlgktqaiXknQuRD;
								wUHNaEsGCLdpFDvelpmVJPotYVAb.kEHmRBonufPaXwWSSWlSciOdvWy = P_0;
								wUHNaEsGCLdpFDvelpmVJPotYVAb.DffVgxLTxGtWFSQnSTfYIAPKKDj = ControllerElementType.Button;
								wUHNaEsGCLdpFDvelpmVJPotYVAb.LAuRCWsrqJRFKOmBPvyBpCEIKop = actionElementMap2;
								wUHNaEsGCLdpFDvelpmVJPotYVAb.bLXFjMcXvYEkCgtXBNCHEQazALWK = bLXFjMcXvYEkCgtXBNCHEQazALWK;
								if (wUHNaEsGCLdpFDvelpmVJPotYVAb.pwqkIczUIliYnxirDGkPRbHIWxk)
								{
									wUHNaEsGCLdpFDvelpmVJPotYVAb.pwqkIczUIliYnxirDGkPRbHIWxk = false;
								}
								P_1(arg1: true, QFlXjfmiJabcsMblLziegHSMCLfJ.BoMCLeauexjolkkRqzIpOQOAGri, actionId2);
								flag = true;
							}
						}
						if (flag)
						{
							eQaARQwlcakzPaJCLRZmbjzCHZE.drlbfUDgyvPaiZWASoBBKrHpfBhE();
						}
					}
				}
			}

			private bool niYxrwcDflQIeSggqrFbcJVihPZ<TMap>(ControllerWithAxes P_0, int P_1, int P_2, ActionElementMap P_3, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<TMap> P_4, int P_5, ref float P_6) where TMap : ControllerMapWithAxes
			{
				if (!P_0.OcGEaRzMecIeBFudxFTOaknZTFKe.IsUnknownHatCardinal(P_2))
				{
					return false;
				}
				UnknownControllerHat.HatButtons unknownHatButtons = P_0.OcGEaRzMecIeBFudxFTOaknZTFKe.GetUnknownHatButtons(P_2);
				if (dIucaMbtlRjTIqkisiYoywLKQsX(unknownHatButtons, P_1, P_4))
				{
					unknownHatButtons.GetNeighbors(P_2, out var neighbor, out var neighbor2);
					if (P_0.GetButton(neighbor) || P_0.GetButton(neighbor2))
					{
						if (!P_0.HvDZItSAoowpoblGiTywvlDVobM(P_3, P_5, true, out P_6))
						{
							return false;
						}
						return true;
					}
				}
				return false;
			}

			private bool dIucaMbtlRjTIqkisiYoywLKQsX<TMap>(UnknownControllerHat.HatButtons P_0, int P_1, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<TMap> P_2) where TMap : ControllerMapWithAxes
			{
				if (P_0 == null)
				{
					return false;
				}
				if (ReInput.configVars.force4WayHats)
				{
					return true;
				}
				if (rcgRIcCydAGQYyzMYutcNMwUBIPC(P_0, P_1, P_2))
				{
					return false;
				}
				return true;
			}

			private bool rcgRIcCydAGQYyzMYutcNMwUBIPC<TMap>(UnknownControllerHat.HatButtons P_0, int P_1, global::gHFgzSPsLtKjGAtobRtDQKtpUvu<TMap> P_2) where TMap : ControllerMapWithAxes
			{
				if (P_2 == null)
				{
					return false;
				}
				int count = P_2.ioXgUGjpFGeVuGnqwbPHBeKgnSzF;
				for (int i = 0; i < count; i++)
				{
					TMap val = P_2.get_Item(i);
					IList<ActionElementMap> buttonMaps = val.ButtonMaps;
					if (buttonMaps == null)
					{
						continue;
					}
					int count2 = buttonMaps.Count;
					for (int j = 0; j < count2; j++)
					{
						int ugYKpPGXoJUWiIrkuIiAFetRZuI = buttonMaps[j].UgYKpPGXoJUWiIrkuIiAFetRZuI;
						if (buttonMaps[j]._actionId >= 0 && P_0.IsCorner(ugYKpPGXoJUWiIrkuIiAFetRZuI))
						{
							return true;
						}
					}
				}
				return false;
			}

			[CompilerGenerated]
			private static void XKFWLQwxvyuZhvVFOpYzEIQENLl(Exception P_0)
			{
				ReInput.HandleCallbackException("Player.ControllerHelper.ControllerAddedEvent", P_0);
			}

			[CompilerGenerated]
			private static void XcuoTWNFxxdouUPmpRRTrlPQmTK(Exception P_0)
			{
				ReInput.HandleCallbackException("Player.ControllerHelper.ControllerRemovedEvent", P_0);
			}
		}

		private readonly uhjoXbTonsTOuVJOQAQlbMAgzIYW mvrCdGRIOFGaMUOTuzwAwqCUSAr;

		private bool QmHJanjCSvTdyyRZfurAffCoIio;

		private int BoMCLeauexjolkkRqzIpOQOAGri;

		private string cdTetXhABLRmOQUvcmFAFXpBMHcj;

		private string JBlgGMEZvdxjyCStlnnPnsnFXoGr;

		private bool vlGUSNKVCDjndZSodtnDpiJKoHX;

		private readonly int PivQvdYMhUssuLwaglJVqkqXMSH;

		public readonly ControllerHelper controllers;

		public int id
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return -1;
				}
				return BoMCLeauexjolkkRqzIpOQOAGri;
			}
			internal set
			{
				BoMCLeauexjolkkRqzIpOQOAGri = value;
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
				return cdTetXhABLRmOQUvcmFAFXpBMHcj;
			}
			internal set
			{
				cdTetXhABLRmOQUvcmFAFXpBMHcj = value;
			}
		}

		public string descriptiveName
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return string.Empty;
				}
				return JBlgGMEZvdxjyCStlnnPnsnFXoGr;
			}
			internal set
			{
				JBlgGMEZvdxjyCStlnnPnsnFXoGr = value;
			}
		}

		public bool isPlaying
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return false;
				}
				return vlGUSNKVCDjndZSodtnDpiJKoHX;
			}
			set
			{
				vlGUSNKVCDjndZSodtnDpiJKoHX = value;
			}
		}

		internal Player(bool isSystem, int playerId, string name, string descriptiveName, hoGZGoKcYjvzMpyhYIdlAPtnxIh startingControllerMapInfo, ControllerMapLayoutManager.lRHvetoYBHZvdHTlYVwfdpCPcAs controllerMapLayoutManagerSettings, ControllerMapEnabler.xIhBRlVXbtrPkJZqdoJCRHAyPSc controllerMapEnablerSettings)
		{
			QmHJanjCSvTdyyRZfurAffCoIio = isSystem;
			BoMCLeauexjolkkRqzIpOQOAGri = playerId;
			cdTetXhABLRmOQUvcmFAFXpBMHcj = name;
			JBlgGMEZvdxjyCStlnnPnsnFXoGr = descriptiveName;
			PivQvdYMhUssuLwaglJVqkqXMSH = ReInput.id;
			controllers = new ControllerHelper(this, startingControllerMapInfo, controllerMapLayoutManagerSettings, controllerMapEnablerSettings);
			mvrCdGRIOFGaMUOTuzwAwqCUSAr = ReInput.CoyPNJHWMheFytmTMQdqyctMRFl;
			ijQPrfbohIDtyfCSvLMVhrlmSpB();
		}

		public PlayerSaveData GetSaveData(bool userAssignableMapsOnly)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return default(PlayerSaveData);
			}
			return new PlayerSaveData(controllers.maps.GetAllMapSaveData<JoystickMapSaveData>(userAssignableMapsOnly), controllers.maps.GetAllMapSaveData<KeyboardMapSaveData>(userAssignableMapsOnly), controllers.maps.GetAllMapSaveData<MouseMapSaveData>(userAssignableMapsOnly), controllers.maps.GetAllMapSaveData<CustomControllerMapSaveData>(userAssignableMapsOnly), ReInput.mapping.GetInputBehaviors(BoMCLeauexjolkkRqzIpOQOAGri));
		}

		public bool GetButton(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.TCWvrlpYTrIwTmaFZCrFglGyZdS() ?? false;
		}

		public bool GetButton(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.TCWvrlpYTrIwTmaFZCrFglGyZdS() ?? false;
		}

		public bool GetButtonDown(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.UzfAMThVYdqMudGicKGhMmcVLNfe() ?? false;
		}

		public bool GetButtonDown(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.UzfAMThVYdqMudGicKGhMmcVLNfe() ?? false;
		}

		public bool GetButtonUp(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.oRveQXtNmlxxfdFQcBcgiXXDnHhU() ?? false;
		}

		public bool GetButtonUp(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.oRveQXtNmlxxfdFQcBcgiXXDnHhU() ?? false;
		}

		public bool GetButtonPrev(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.LpZDtGGwsJWdKGXsgaCmlXBXbxjq() ?? false;
		}

		public bool GetButtonPrev(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.LpZDtGGwsJWdKGXsgaCmlXBXbxjq() ?? false;
		}

		public bool GetButtonSinglePressHold(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.UgWvGCEaRDvBZoxWBqudkBbBhjb() ?? false;
		}

		public bool GetButtonSinglePressHold(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.UgWvGCEaRDvBZoxWBqudkBbBhjb() ?? false;
		}

		public bool GetButtonSinglePressDown(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.ZmwKxnwfnEcMkNHCruCKBGYKOhg() ?? false;
		}

		public bool GetButtonSinglePressDown(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.ZmwKxnwfnEcMkNHCruCKBGYKOhg() ?? false;
		}

		public bool GetButtonSinglePressUp(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.SSKnYIpdXiHqRnjdcsPJXbGUzOK() ?? false;
		}

		public bool GetButtonSinglePressUp(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.SSKnYIpdXiHqRnjdcsPJXbGUzOK() ?? false;
		}

		public bool GetButtonDoublePressHold(string actionName, float speed)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.AhQsMzwZFroUkeOHfbjXGYXbODnh(speed) ?? false;
		}

		public bool GetButtonDoublePressHold(int actionId, float speed)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.AhQsMzwZFroUkeOHfbjXGYXbODnh(speed) ?? false;
		}

		public bool GetButtonDoublePressHold(string actionName)
		{
			return GetButtonDoublePressHold(actionName, 0f);
		}

		public bool GetButtonDoublePressHold(int actionId)
		{
			return GetButtonDoublePressHold(actionId, 0f);
		}

		public bool GetButtonDoublePressDown(string actionName, float speed)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.kciImsjuaZduDjovtWDEackQout(speed) ?? false;
		}

		public bool GetButtonDoublePressDown(int actionId, float speed)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.kciImsjuaZduDjovtWDEackQout(speed) ?? false;
		}

		public bool GetButtonDoublePressDown(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return GetButtonDoublePressDown(actionName, 0f);
		}

		public bool GetButtonDoublePressDown(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return GetButtonDoublePressDown(actionId, 0f);
		}

		public bool GetButtonDoublePressUp(string actionName, float speed)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.pSusZntwSjsVdQQqxBEiXNXUupH(speed) ?? false;
		}

		public bool GetButtonDoublePressUp(int actionId, float speed)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.pSusZntwSjsVdQQqxBEiXNXUupH(speed) ?? false;
		}

		public bool GetButtonDoublePressUp(string actionName)
		{
			return GetButtonDoublePressUp(actionName, 0f);
		}

		public bool GetButtonDoublePressUp(int actionId)
		{
			return GetButtonDoublePressUp(actionId, 0f);
		}

		public bool GetButtonTimedPress(string actionName, float time)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.QcSsRGYaurUSMbZdwrdNkblYzgD(time, 0f) ?? false;
		}

		public bool GetButtonTimedPress(int actionId, float time)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.QcSsRGYaurUSMbZdwrdNkblYzgD(time, 0f) ?? false;
		}

		public bool GetButtonTimedPress(string actionName, float time, float expireIn)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.QcSsRGYaurUSMbZdwrdNkblYzgD(time, expireIn) ?? false;
		}

		public bool GetButtonTimedPress(int actionId, float time, float expireIn)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.QcSsRGYaurUSMbZdwrdNkblYzgD(time, expireIn) ?? false;
		}

		public bool GetButtonTimedPressDown(string actionName, float time)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.ClafnqACuizCNDqExqMplQHtUXa(time) ?? false;
		}

		public bool GetButtonTimedPressDown(int actionId, float time)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.ClafnqACuizCNDqExqMplQHtUXa(time) ?? false;
		}

		public bool GetButtonTimedPressUp(string actionName, float time)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.HdfhlkfxObSYEdkqLNHoJMzhtOCJ(time, 0f) ?? false;
		}

		public bool GetButtonTimedPressUp(int actionId, float time)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.HdfhlkfxObSYEdkqLNHoJMzhtOCJ(time, 0f) ?? false;
		}

		public bool GetButtonTimedPressUp(string actionName, float time, float expireIn)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.HdfhlkfxObSYEdkqLNHoJMzhtOCJ(time, expireIn) ?? false;
		}

		public bool GetButtonTimedPressUp(int actionId, float time, float expireIn)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.HdfhlkfxObSYEdkqLNHoJMzhtOCJ(time, expireIn) ?? false;
		}

		public bool GetButtonShortPress(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.XjEQMBXsuqxlOCwbuTvPIFeIlEJ() ?? false;
		}

		public bool GetButtonShortPress(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.XjEQMBXsuqxlOCwbuTvPIFeIlEJ() ?? false;
		}

		public bool GetButtonShortPressDown(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.UVAdNNaPpzDMuxxLAngERrubVTN() ?? false;
		}

		public bool GetButtonShortPressDown(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.UVAdNNaPpzDMuxxLAngERrubVTN() ?? false;
		}

		public bool GetButtonShortPressUp(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.kDgrwblaRrSDwudvldfKtFtJepxE() ?? false;
		}

		public bool GetButtonShortPressUp(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.kDgrwblaRrSDwudvldfKtFtJepxE() ?? false;
		}

		public bool GetButtonLongPress(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.ZENUyIwPfAqUZEjrkaSfQmivFle() ?? false;
		}

		public bool GetButtonLongPress(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.ZENUyIwPfAqUZEjrkaSfQmivFle() ?? false;
		}

		public bool GetButtonLongPressDown(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.AaPJBzAaAdepKVGqwSjcPqUDOAq() ?? false;
		}

		public bool GetButtonLongPressDown(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.AaPJBzAaAdepKVGqwSjcPqUDOAq() ?? false;
		}

		public bool GetButtonLongPressUp(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.OgSlBUwSYdXdkzGtWzRiodFcEHR() ?? false;
		}

		public bool GetButtonLongPressUp(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.OgSlBUwSYdXdkzGtWzRiodFcEHR() ?? false;
		}

		public bool GetButtonRepeating(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.zKKTDzHWahorsmhpqdKidxrhKXnd() ?? false;
		}

		public bool GetButtonRepeating(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.zKKTDzHWahorsmhpqdKidxrhKXnd() ?? false;
		}

		public bool GetAnyButton()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.ZcIGDkhYqgWFskSZmIoqvrdWWSNj(BoMCLeauexjolkkRqzIpOQOAGri);
		}

		public bool GetAnyButtonDown()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.ZgjamxcKdSJXetMZbJmNaRmcTjun(BoMCLeauexjolkkRqzIpOQOAGri);
		}

		public bool GetAnyButtonUp()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.OomBMbWfCskalfnCMnAeOfRXaTmA(BoMCLeauexjolkkRqzIpOQOAGri);
		}

		public bool GetAnyButtonPrev()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.HPNYHXydniFcCAdLzpmsavELXPke(BoMCLeauexjolkkRqzIpOQOAGri);
		}

		public double GetButtonTimePressed(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.oATDmPiwRrPUYbQOWZrqHJeFjjg() ?? 0.0;
		}

		public double GetButtonTimePressed(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.oATDmPiwRrPUYbQOWZrqHJeFjjg() ?? 0.0;
		}

		public double GetButtonTimeUnpressed(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.SrSGNaCvJkWyANBffDFdAJGvwjBE() ?? 0.0;
		}

		public double GetButtonTimeUnpressed(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.SrSGNaCvJkWyANBffDFdAJGvwjBE() ?? 0.0;
		}

		public bool GetNegativeButton(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.iqaAyEcHqdpsAZatEXcYRcIruvj() ?? false;
		}

		public bool GetNegativeButton(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.iqaAyEcHqdpsAZatEXcYRcIruvj() ?? false;
		}

		public bool GetNegativeButtonDown(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.oXMNVKNTpnOLUaguzJPKSnhoapa() ?? false;
		}

		public bool GetNegativeButtonDown(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.oXMNVKNTpnOLUaguzJPKSnhoapa() ?? false;
		}

		public bool GetNegativeButtonUp(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.bVfrluEmiRTJoxAilUuhMBMaOpt() ?? false;
		}

		public bool GetNegativeButtonUp(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.bVfrluEmiRTJoxAilUuhMBMaOpt() ?? false;
		}

		public bool GetNegativeButtonPrev(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.zDUGzlgrGuZsKAvySFmYAjdTBHFT() ?? false;
		}

		public bool GetNegativeButtonPrev(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.zDUGzlgrGuZsKAvySFmYAjdTBHFT() ?? false;
		}

		public bool GetNegativeButtonSinglePressHold(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.evvTokiijtmyrGAgUTPZQMOILub() ?? false;
		}

		public bool GetNegativeButtonSinglePressHold(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.evvTokiijtmyrGAgUTPZQMOILub() ?? false;
		}

		public bool GetNegativeButtonSinglePressDown(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.hBcUdxdjwIVlURrzizRRgZUZvDk() ?? false;
		}

		public bool GetNegativeButtonSinglePressDown(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.hBcUdxdjwIVlURrzizRRgZUZvDk() ?? false;
		}

		public bool GetNegativeButtonSinglePressUp(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.JvVzCNDKjgfIOJKRDWqCKxHwCvlG() ?? false;
		}

		public bool GetNegativeButtonSinglePressUp(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.JvVzCNDKjgfIOJKRDWqCKxHwCvlG() ?? false;
		}

		public bool GetNegativeButtonDoublePressHold(string actionName, float speed)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.iSJFayIvWnbWJxcHZtTjNyWVhdE(speed) ?? false;
		}

		public bool GetNegativeButtonDoublePressHold(int actionId, float speed)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.iSJFayIvWnbWJxcHZtTjNyWVhdE(speed) ?? false;
		}

		public bool GetNegativeButtonDoublePressHold(string actionName)
		{
			return GetNegativeButtonDoublePressHold(actionName, 0f);
		}

		public bool GetNegativeButtonDoublePressHold(int actionId)
		{
			return GetNegativeButtonDoublePressHold(actionId, 0f);
		}

		public bool GetNegativeButtonDoublePressDown(string actionName, float speed)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.uzgrHHrIlamtEugSmzAcHkYNQwr(speed) ?? false;
		}

		public bool GetNegativeButtonDoublePressDown(int actionId, float speed)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.uzgrHHrIlamtEugSmzAcHkYNQwr(speed) ?? false;
		}

		public bool GetNegativeButtonDoublePressDown(string actionName)
		{
			return GetNegativeButtonDoublePressDown(actionName, 0f);
		}

		public bool GetNegativeButtonDoublePressDown(int actionId)
		{
			return GetNegativeButtonDoublePressDown(actionId, 0f);
		}

		public bool GetNegativeButtonDoublePressUp(string actionName, float speed)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.OivUvHDLEenAQaHVtLYeIVbTFUJ(speed) ?? false;
		}

		public bool GetNegativeButtonDoublePressUp(int actionId, float speed)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.OivUvHDLEenAQaHVtLYeIVbTFUJ(speed) ?? false;
		}

		public bool GetNegativeButtonDoublePressUp(string actionName)
		{
			return GetNegativeButtonDoublePressUp(actionName, 0f);
		}

		public bool GetNegativeButtonDoublePressUp(int actionId)
		{
			return GetNegativeButtonDoublePressUp(actionId, 0f);
		}

		public bool GetNegativeButtonTimedPress(string actionName, float time)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.XLCIyyxbfnSdTlbUKFeatCFHPva(time, 0f) ?? false;
		}

		public bool GetNegativeButtonTimedPress(int actionId, float time)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.XLCIyyxbfnSdTlbUKFeatCFHPva(time, 0f) ?? false;
		}

		public bool GetNegativeButtonTimedPress(string actionName, float time, float expireIn)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.XLCIyyxbfnSdTlbUKFeatCFHPva(time, expireIn) ?? false;
		}

		public bool GetNegativeButtonTimedPress(int actionId, float time, float expireIn)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.XLCIyyxbfnSdTlbUKFeatCFHPva(time, expireIn) ?? false;
		}

		public bool GetNegativeButtonTimedPressDown(string actionName, float time)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.aUWUfhQcfxidmePDKGfSXLgbEhb(time) ?? false;
		}

		public bool GetNegativeButtonTimedPressDown(int actionId, float time)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.aUWUfhQcfxidmePDKGfSXLgbEhb(time) ?? false;
		}

		public bool GetNegativeButtonTimedPressUp(string actionName, float time)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.nJUBAbsoiUeNQoUWzwBULFKwmKR(time, 0f) ?? false;
		}

		public bool GetNegativeButtonTimedPressUp(int actionId, float time)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.nJUBAbsoiUeNQoUWzwBULFKwmKR(time, 0f) ?? false;
		}

		public bool GetNegativeButtonTimedPressUp(string actionName, float time, float expireIn)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.nJUBAbsoiUeNQoUWzwBULFKwmKR(time, expireIn) ?? false;
		}

		public bool GetNegativeButtonTimedPressUp(int actionId, float time, float expireIn)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.nJUBAbsoiUeNQoUWzwBULFKwmKR(time, expireIn) ?? false;
		}

		public bool GetNegativeButtonShortPress(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.rsbocuLgoXoAeksZdweGqFofKRx() ?? false;
		}

		public bool GetNegativeButtonShortPress(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.rsbocuLgoXoAeksZdweGqFofKRx() ?? false;
		}

		public bool GetNegativeButtonShortPressDown(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.AZnzlkEspdMDrbGiJQSNLiVdzzR() ?? false;
		}

		public bool GetNegativeButtonShortPressDown(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.AZnzlkEspdMDrbGiJQSNLiVdzzR() ?? false;
		}

		public bool GetNegativeButtonShortPressUp(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.XVYuYDBxqNNkZvpfdecmrPImZKw() ?? false;
		}

		public bool GetNegativeButtonShortPressUp(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.XVYuYDBxqNNkZvpfdecmrPImZKw() ?? false;
		}

		public bool GetNegativeButtonLongPress(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.IABnWtyeoNnaZZDvIABOPjPtFNR() ?? false;
		}

		public bool GetNegativeButtonLongPress(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.IABnWtyeoNnaZZDvIABOPjPtFNR() ?? false;
		}

		public bool GetNegativeButtonLongPressDown(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.NPfjTCkwvhbbXdkUfjqqxQvNQHF() ?? false;
		}

		public bool GetNegativeButtonLongPressDown(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.NPfjTCkwvhbbXdkUfjqqxQvNQHF() ?? false;
		}

		public bool GetNegativeButtonLongPressUp(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.PSwwnFdnPtdjhfHOsFWWyZFMCgT() ?? false;
		}

		public bool GetNegativeButtonLongPressUp(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.PSwwnFdnPtdjhfHOsFWWyZFMCgT() ?? false;
		}

		public bool GetNegativeButtonRepeating(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.bTMzAABqqYNwnBmyXsXvNssMmTt() ?? false;
		}

		public bool GetNegativeButtonRepeating(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.bTMzAABqqYNwnBmyXsXvNssMmTt() ?? false;
		}

		public bool GetAnyNegativeButton()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.bNZBNCfIrtOxezrBCtaFiabIUlHZ(BoMCLeauexjolkkRqzIpOQOAGri);
		}

		public bool GetAnyNegativeButtonDown()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.lfMHFuEhkeBpwcbMzXtFRfJiKjtE(BoMCLeauexjolkkRqzIpOQOAGri);
		}

		public bool GetAnyNegativeButtonUp()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.QhDYZVhbCrFpsbRMPkAFUrkMnTn(BoMCLeauexjolkkRqzIpOQOAGri);
		}

		public bool GetAnyNegativeButtonPrev()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.SkFmFYJpGXerRaSgnvlEVthWJGr(BoMCLeauexjolkkRqzIpOQOAGri);
		}

		public double GetNegativeButtonTimePressed(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.TMTnvcIdGasmvQbzNNrlUFAInyZ() ?? 0.0;
		}

		public double GetNegativeButtonTimePressed(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.TMTnvcIdGasmvQbzNNrlUFAInyZ() ?? 0.0;
		}

		public double GetNegativeButtonTimeUnpressed(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.ZMssshEhiFbjjlhsSlhAFwrtncU() ?? 0.0;
		}

		public double GetNegativeButtonTimeUnpressed(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.ZMssshEhiFbjjlhsSlhAFwrtncU() ?? 0.0;
		}

		public float GetAxis(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0f;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.GLWgPekOoFtzAmRRNYWNkzKdCZgc() ?? 0f;
		}

		public float GetAxis(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0f;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.GLWgPekOoFtzAmRRNYWNkzKdCZgc() ?? 0f;
		}

		public float GetAxisRaw(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0f;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.XveAiBhJdpBhkOGEyKTpyxPqkZw() ?? 0f;
		}

		public float GetAxisRaw(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0f;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.XveAiBhJdpBhkOGEyKTpyxPqkZw() ?? 0f;
		}

		public float GetAxisPrev(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0f;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.iVALatsHQUVsDgFZEPWWmyXrOke() ?? 0f;
		}

		public float GetAxisPrev(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0f;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.iVALatsHQUVsDgFZEPWWmyXrOke() ?? 0f;
		}

		public float GetAxisRawPrev(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0f;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.WtXxJknRRwYqhWjAscFTChvwcYO() ?? 0f;
		}

		public float GetAxisRawPrev(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0f;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.WtXxJknRRwYqhWjAscFTChvwcYO() ?? 0f;
		}

		public float GetAxisDelta(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0f;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.EBWPcYiGGBPBFsqPQeLirLQCxsk() ?? 0f;
		}

		public float GetAxisDelta(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0f;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.EBWPcYiGGBPBFsqPQeLirLQCxsk() ?? 0f;
		}

		public float GetAxisRawDelta(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0f;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.tfHdIYOAKcFIoCDVSZgHFnHbswdD() ?? 0f;
		}

		public float GetAxisRawDelta(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0f;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.tfHdIYOAKcFIoCDVSZgHFnHbswdD() ?? 0f;
		}

		public Vector2 GetAxis2D(string xAxisActionName, string yAxisActionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return Vector2.zero;
			}
			Vector2 result = default(Vector2);
			XrsxaFoSedDmSEVIidqjOjugISoF xrsxaFoSedDmSEVIidqjOjugISoF = mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, xAxisActionName, true);
			if (xrsxaFoSedDmSEVIidqjOjugISoF != null)
			{
				result.x = xrsxaFoSedDmSEVIidqjOjugISoF.GLWgPekOoFtzAmRRNYWNkzKdCZgc();
			}
			xrsxaFoSedDmSEVIidqjOjugISoF = mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, yAxisActionName, true);
			if (xrsxaFoSedDmSEVIidqjOjugISoF != null)
			{
				result.y = xrsxaFoSedDmSEVIidqjOjugISoF.GLWgPekOoFtzAmRRNYWNkzKdCZgc();
			}
			return result;
		}

		public Vector2 GetAxis2D(int xAxisActionId, int yAxisActionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return Vector2.zero;
			}
			Vector2 result = default(Vector2);
			XrsxaFoSedDmSEVIidqjOjugISoF xrsxaFoSedDmSEVIidqjOjugISoF = mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, xAxisActionId, true);
			if (xrsxaFoSedDmSEVIidqjOjugISoF != null)
			{
				result.x = xrsxaFoSedDmSEVIidqjOjugISoF.GLWgPekOoFtzAmRRNYWNkzKdCZgc();
			}
			xrsxaFoSedDmSEVIidqjOjugISoF = mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, yAxisActionId, true);
			if (xrsxaFoSedDmSEVIidqjOjugISoF != null)
			{
				result.y = xrsxaFoSedDmSEVIidqjOjugISoF.GLWgPekOoFtzAmRRNYWNkzKdCZgc();
			}
			return result;
		}

		public Vector2 GetAxis2DPrev(string xAxisActionName, string yAxisActionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return Vector2.zero;
			}
			Vector2 result = default(Vector2);
			XrsxaFoSedDmSEVIidqjOjugISoF xrsxaFoSedDmSEVIidqjOjugISoF = mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, xAxisActionName, true);
			if (xrsxaFoSedDmSEVIidqjOjugISoF != null)
			{
				result.x = xrsxaFoSedDmSEVIidqjOjugISoF.iVALatsHQUVsDgFZEPWWmyXrOke();
			}
			xrsxaFoSedDmSEVIidqjOjugISoF = mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, yAxisActionName, true);
			if (xrsxaFoSedDmSEVIidqjOjugISoF != null)
			{
				result.y = xrsxaFoSedDmSEVIidqjOjugISoF.iVALatsHQUVsDgFZEPWWmyXrOke();
			}
			return result;
		}

		public Vector2 GetAxis2DPrev(int xAxisActionId, int yAxisActionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return Vector2.zero;
			}
			Vector2 result = default(Vector2);
			XrsxaFoSedDmSEVIidqjOjugISoF xrsxaFoSedDmSEVIidqjOjugISoF = mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, xAxisActionId, true);
			if (xrsxaFoSedDmSEVIidqjOjugISoF != null)
			{
				result.x = xrsxaFoSedDmSEVIidqjOjugISoF.iVALatsHQUVsDgFZEPWWmyXrOke();
			}
			xrsxaFoSedDmSEVIidqjOjugISoF = mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, yAxisActionId, true);
			if (xrsxaFoSedDmSEVIidqjOjugISoF != null)
			{
				result.y = xrsxaFoSedDmSEVIidqjOjugISoF.iVALatsHQUVsDgFZEPWWmyXrOke();
			}
			return result;
		}

		public Vector2 GetAxis2DRaw(string xAxisActionName, string yAxisActionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return Vector2.zero;
			}
			Vector2 result = default(Vector2);
			XrsxaFoSedDmSEVIidqjOjugISoF xrsxaFoSedDmSEVIidqjOjugISoF = mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, xAxisActionName, true);
			if (xrsxaFoSedDmSEVIidqjOjugISoF != null)
			{
				result.x = xrsxaFoSedDmSEVIidqjOjugISoF.XveAiBhJdpBhkOGEyKTpyxPqkZw();
			}
			xrsxaFoSedDmSEVIidqjOjugISoF = mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, yAxisActionName, true);
			if (xrsxaFoSedDmSEVIidqjOjugISoF != null)
			{
				result.y = xrsxaFoSedDmSEVIidqjOjugISoF.XveAiBhJdpBhkOGEyKTpyxPqkZw();
			}
			return result;
		}

		public Vector2 GetAxis2DRaw(int xAxisActionId, int yAxisActionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return Vector2.zero;
			}
			Vector2 result = default(Vector2);
			XrsxaFoSedDmSEVIidqjOjugISoF xrsxaFoSedDmSEVIidqjOjugISoF = mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, xAxisActionId, true);
			if (xrsxaFoSedDmSEVIidqjOjugISoF != null)
			{
				result.x = xrsxaFoSedDmSEVIidqjOjugISoF.XveAiBhJdpBhkOGEyKTpyxPqkZw();
			}
			xrsxaFoSedDmSEVIidqjOjugISoF = mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, yAxisActionId, true);
			if (xrsxaFoSedDmSEVIidqjOjugISoF != null)
			{
				result.y = xrsxaFoSedDmSEVIidqjOjugISoF.XveAiBhJdpBhkOGEyKTpyxPqkZw();
			}
			return result;
		}

		public Vector2 GetAxis2DRawPrev(string xAxisActionName, string yAxisActionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return Vector2.zero;
			}
			Vector2 result = default(Vector2);
			XrsxaFoSedDmSEVIidqjOjugISoF xrsxaFoSedDmSEVIidqjOjugISoF = mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, xAxisActionName, true);
			if (xrsxaFoSedDmSEVIidqjOjugISoF != null)
			{
				result.x = xrsxaFoSedDmSEVIidqjOjugISoF.WtXxJknRRwYqhWjAscFTChvwcYO();
			}
			xrsxaFoSedDmSEVIidqjOjugISoF = mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, yAxisActionName, true);
			if (xrsxaFoSedDmSEVIidqjOjugISoF != null)
			{
				result.y = xrsxaFoSedDmSEVIidqjOjugISoF.WtXxJknRRwYqhWjAscFTChvwcYO();
			}
			return result;
		}

		public Vector2 GetAxis2DRawPrev(int xAxisActionId, int yAxisActionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return Vector2.zero;
			}
			Vector2 result = default(Vector2);
			XrsxaFoSedDmSEVIidqjOjugISoF xrsxaFoSedDmSEVIidqjOjugISoF = mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, xAxisActionId, true);
			if (xrsxaFoSedDmSEVIidqjOjugISoF != null)
			{
				result.x = xrsxaFoSedDmSEVIidqjOjugISoF.WtXxJknRRwYqhWjAscFTChvwcYO();
			}
			xrsxaFoSedDmSEVIidqjOjugISoF = mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, yAxisActionId, true);
			if (xrsxaFoSedDmSEVIidqjOjugISoF != null)
			{
				result.y = xrsxaFoSedDmSEVIidqjOjugISoF.WtXxJknRRwYqhWjAscFTChvwcYO();
			}
			return result;
		}

		public double GetAxisTimeActive(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.FbYLUMnKHemiCVyWjjCmBSyCSdx() ?? 0.0;
		}

		public double GetAxisTimeActive(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.FbYLUMnKHemiCVyWjjCmBSyCSdx() ?? 0.0;
		}

		public double GetAxisTimeInactive(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.JrgcdgsdFzuruGFPHrAtHEYhsDW() ?? 0.0;
		}

		public double GetAxisTimeInactive(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.JrgcdgsdFzuruGFPHrAtHEYhsDW() ?? 0.0;
		}

		public double GetAxisRawTimeActive(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.QbegBwIrfehnXIbIFfFGgfqGwADJ() ?? 0.0;
		}

		public double GetAxisRawTimeActive(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.QbegBwIrfehnXIbIFfFGgfqGwADJ() ?? 0.0;
		}

		public double GetAxisRawTimeInactive(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.IEAKIpMYAuDfBQFTZLimfIDYvGf() ?? 0.0;
		}

		public double GetAxisRawTimeInactive(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0.0;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.IEAKIpMYAuDfBQFTZLimfIDYvGf() ?? 0.0;
		}

		public AxisCoordinateMode GetAxisCoordinateMode(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return AxisCoordinateMode.Absolute;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.YouCrCOmfiVRZXvZapTqdJITOmG() ?? AxisCoordinateMode.Absolute;
		}

		public AxisCoordinateMode GetAxisCoordinateMode(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return AxisCoordinateMode.Absolute;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.YouCrCOmfiVRZXvZapTqdJITOmG() ?? AxisCoordinateMode.Absolute;
		}

		public AxisCoordinateMode GetAxisRawCoordinateMode(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return AxisCoordinateMode.Absolute;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.vuSKyKCMDAMfhOMcShwMYeUhZpe() ?? AxisCoordinateMode.Absolute;
		}

		public AxisCoordinateMode GetAxisRawCoordinateMode(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return AxisCoordinateMode.Absolute;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.vuSKyKCMDAMfhOMcShwMYeUhZpe() ?? AxisCoordinateMode.Absolute;
		}

		public AxisCoordinateMode GetAxisCoordinateModePrev(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return AxisCoordinateMode.Absolute;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.kmytUYeYLgmKBhacjKRrGAjkZEJ() ?? AxisCoordinateMode.Absolute;
		}

		public AxisCoordinateMode GetAxisCoordinateModePrev(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return AxisCoordinateMode.Absolute;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.kmytUYeYLgmKBhacjKRrGAjkZEJ() ?? AxisCoordinateMode.Absolute;
		}

		public AxisCoordinateMode GetAxisRawCoordinateModePrev(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return AxisCoordinateMode.Absolute;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.CeWAVTKiaHTKUCmbYASKouNRBzj() ?? AxisCoordinateMode.Absolute;
		}

		public AxisCoordinateMode GetAxisRawCoordinateModePrev(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return AxisCoordinateMode.Absolute;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.CeWAVTKiaHTKUCmbYASKouNRBzj() ?? AxisCoordinateMode.Absolute;
		}

		public IList<InputActionSourceData> GetCurrentInputSources(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<InputActionSourceData>.EmptyReadOnlyIListT;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.aYwoPDjjBgUVKwrUTrNdFgSSMR();
		}

		public IList<InputActionSourceData> GetCurrentInputSources(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<InputActionSourceData>.EmptyReadOnlyIListT;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.aYwoPDjjBgUVKwrUTrNdFgSSMR();
		}

		public bool IsCurrentInputSource(string actionName, ControllerType controllerType)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.GkfxgmoXKOLOWjigJWUpWkLLOEL(controllerType) ?? false;
		}

		public bool IsCurrentInputSource(int actionId, ControllerType controllerType)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.GkfxgmoXKOLOWjigJWUpWkLLOEL(controllerType) ?? false;
		}

		public bool IsCurrentInputSource(string actionName, ControllerType controllerType, int controllerId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.GkfxgmoXKOLOWjigJWUpWkLLOEL(controllerType, controllerId) ?? false;
		}

		public bool IsCurrentInputSource(int actionId, ControllerType controllerType, int controllerId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.GkfxgmoXKOLOWjigJWUpWkLLOEL(controllerType, controllerId) ?? false;
		}

		public bool IsCurrentInputSource(string actionName, Controller controller)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionName, true)?.GkfxgmoXKOLOWjigJWUpWkLLOEL(controller) ?? false;
		}

		public bool IsCurrentInputSource(int actionId, Controller controller)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return mvrCdGRIOFGaMUOTuzwAwqCUSAr.XPToosqqXMRHQrnQiuecVwOHVUJ(BoMCLeauexjolkkRqzIpOQOAGri, actionId, true)?.GkfxgmoXKOLOWjigJWUpWkLLOEL(controller) ?? false;
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop)
		{
			if (ReInput.isReady)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					mvrCdGRIOFGaMUOTuzwAwqCUSAr.sJvxAzvIhHCiuNyXTYkCIPJiQxQ(BoMCLeauexjolkkRqzIpOQOAGri, callback, updateLoop);
				}
			}
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, int actionId)
		{
			if (ReInput.isReady)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					mvrCdGRIOFGaMUOTuzwAwqCUSAr.sJvxAzvIhHCiuNyXTYkCIPJiQxQ(BoMCLeauexjolkkRqzIpOQOAGri, callback, updateLoop, actionId);
				}
			}
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, string actionName)
		{
			if (!ReInput.isReady)
			{
				return;
			}
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return;
			}
			int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			if (num >= 0)
			{
				AddInputEventDelegate(callback, updateLoop, num);
			}
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType)
		{
			AddInputEventDelegate(callback, updateLoop, eventType, (object[])null);
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId)
		{
			AddInputEventDelegate(callback, updateLoop, eventType, actionId, null);
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName)
		{
			AddInputEventDelegate(callback, updateLoop, eventType, actionName, null);
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, object[] arguments)
		{
			if (ReInput.isReady)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					mvrCdGRIOFGaMUOTuzwAwqCUSAr.sJvxAzvIhHCiuNyXTYkCIPJiQxQ(BoMCLeauexjolkkRqzIpOQOAGri, callback, updateLoop, eventType, arguments);
				}
			}
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId, object[] arguments)
		{
			if (ReInput.isReady)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					mvrCdGRIOFGaMUOTuzwAwqCUSAr.sJvxAzvIhHCiuNyXTYkCIPJiQxQ(BoMCLeauexjolkkRqzIpOQOAGri, callback, updateLoop, eventType, actionId, arguments);
				}
			}
		}

		public void AddInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName, object[] arguments)
		{
			if (!ReInput.isReady)
			{
				return;
			}
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return;
			}
			int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName, true);
			if (num >= 0)
			{
				AddInputEventDelegate(callback, updateLoop, eventType, num, arguments);
			}
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback)
		{
			if (ReInput.isReady)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					mvrCdGRIOFGaMUOTuzwAwqCUSAr.fbYjmEUqKRgUFWEHQxIfUevDeIXG(BoMCLeauexjolkkRqzIpOQOAGri, callback);
				}
			}
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, int actionId)
		{
			if (ReInput.isReady)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					mvrCdGRIOFGaMUOTuzwAwqCUSAr.fbYjmEUqKRgUFWEHQxIfUevDeIXG(BoMCLeauexjolkkRqzIpOQOAGri, callback, actionId);
				}
			}
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, string actionName)
		{
			if (!ReInput.isReady)
			{
				return;
			}
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return;
			}
			int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			if (num >= 0)
			{
				RemoveInputEventDelegate(callback, num);
			}
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop)
		{
			if (ReInput.isReady)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					mvrCdGRIOFGaMUOTuzwAwqCUSAr.fbYjmEUqKRgUFWEHQxIfUevDeIXG(BoMCLeauexjolkkRqzIpOQOAGri, callback, updateLoop);
				}
			}
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType)
		{
			if (ReInput.isReady)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					mvrCdGRIOFGaMUOTuzwAwqCUSAr.fbYjmEUqKRgUFWEHQxIfUevDeIXG(BoMCLeauexjolkkRqzIpOQOAGri, callback, eventType);
				}
			}
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, int actionId)
		{
			if (ReInput.isReady)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					mvrCdGRIOFGaMUOTuzwAwqCUSAr.fbYjmEUqKRgUFWEHQxIfUevDeIXG(BoMCLeauexjolkkRqzIpOQOAGri, callback, updateLoop, actionId);
				}
			}
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, string actionName)
		{
			if (!ReInput.isReady)
			{
				return;
			}
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return;
			}
			int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			if (num >= 0)
			{
				RemoveInputEventDelegate(callback, updateLoop, num);
			}
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType, int actionId)
		{
			if (ReInput.isReady)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					mvrCdGRIOFGaMUOTuzwAwqCUSAr.fbYjmEUqKRgUFWEHQxIfUevDeIXG(BoMCLeauexjolkkRqzIpOQOAGri, callback, eventType, actionId);
				}
			}
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, InputActionEventType eventType, string actionName)
		{
			if (!ReInput.isReady)
			{
				return;
			}
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return;
			}
			int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			if (num >= 0)
			{
				RemoveInputEventDelegate(callback, eventType, num);
			}
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType)
		{
			if (ReInput.isReady)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					mvrCdGRIOFGaMUOTuzwAwqCUSAr.fbYjmEUqKRgUFWEHQxIfUevDeIXG(BoMCLeauexjolkkRqzIpOQOAGri, callback, updateLoop, eventType);
				}
			}
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, int actionId)
		{
			if (ReInput.isReady)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					mvrCdGRIOFGaMUOTuzwAwqCUSAr.fbYjmEUqKRgUFWEHQxIfUevDeIXG(BoMCLeauexjolkkRqzIpOQOAGri, callback, updateLoop, eventType, actionId);
				}
			}
		}

		public void RemoveInputEventDelegate(Action<InputActionEventData> callback, UpdateLoopType updateLoop, InputActionEventType eventType, string actionName)
		{
			if (!ReInput.isReady)
			{
				return;
			}
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return;
			}
			int num = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			if (num >= 0)
			{
				RemoveInputEventDelegate(callback, updateLoop, eventType, num);
			}
		}

		public void ClearInputEventDelegates()
		{
			if (ReInput.isReady)
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					mvrCdGRIOFGaMUOTuzwAwqCUSAr.gNVONAWiphFUgGEukggqccEDkbJw(BoMCLeauexjolkkRqzIpOQOAGri);
				}
			}
		}

		public void SetVibration(int motorIndex, float motorLevel)
		{
			SetVibration(motorIndex, motorLevel, 0f, stopOtherMotors: false);
		}

		public void SetVibration(int motorIndex, float motorLevel, float duration)
		{
			SetVibration(motorIndex, motorLevel, duration, stopOtherMotors: false);
		}

		public void SetVibration(int motorIndex, float motorLevel, bool stopOtherMotors)
		{
			SetVibration(motorIndex, motorLevel, 0f, stopOtherMotors);
		}

		public void SetVibration(int motorIndex, float motorLevel, float duration, bool stopOtherMotors)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return;
			}
			IList<Joystick> joysticks = controllers.Joysticks;
			int count = joysticks.Count;
			for (int i = 0; i < count; i++)
			{
				Joystick joystick = joysticks[i];
				if (joystick.supportsVibration)
				{
					joystick.SetVibration(motorIndex, motorLevel, duration, stopOtherMotors);
				}
			}
		}

		public float GetVibration(int motorIndex)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0f;
			}
			IList<Joystick> joysticks = controllers.Joysticks;
			int count = joysticks.Count;
			float num = 0f;
			for (int i = 0; i < count; i++)
			{
				Joystick joystick = joysticks[i];
				if (joystick.supportsVibration)
				{
					num = MathTools.Max(joystick.GetVibration(motorIndex), num);
				}
			}
			return num;
		}

		public void StopVibration()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return;
			}
			IList<Joystick> joysticks = controllers.Joysticks;
			int count = joysticks.Count;
			for (int i = 0; i < count; i++)
			{
				Joystick joystick = joysticks[i];
				if (joystick.supportsVibration)
				{
					joystick.StopVibration();
				}
			}
		}

		internal void skeOSBSqSPGPnIZySfEhxuCHbTXM()
		{
			ijQPrfbohIDtyfCSvLMVhrlmSpB();
		}

		private void ijQPrfbohIDtyfCSvLMVhrlmSpB()
		{
			controllers.ijQPrfbohIDtyfCSvLMVhrlmSpB();
			vlGUSNKVCDjndZSodtnDpiJKoHX = false;
		}
	}
}
