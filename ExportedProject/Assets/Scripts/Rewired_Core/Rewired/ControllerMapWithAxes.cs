using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;

namespace Rewired
{
	public abstract class ControllerMapWithAxes : ControllerMap
	{
		private readonly IList<ActionElementMap> UJLJEaSiCVFRPgTvWpdGpKlYjDtH;

		private readonly ReadOnlyCollection<ActionElementMap> nnIGLjbilYWhebMKiOanRtFoprQq;

		public int axisMapCount
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return 0;
				}
				if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH == null)
				{
					return 0;
				}
				return UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count;
			}
		}

		public IList<ActionElementMap> AxisMaps
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
				}
				return nnIGLjbilYWhebMKiOanRtFoprQq;
			}
		}

		internal AList<ActionElementMap> AxisMaps_orig => (AList<ActionElementMap>)UJLJEaSiCVFRPgTvWpdGpKlYjDtH;

		public ControllerMapWithAxes()
		{
			UJLJEaSiCVFRPgTvWpdGpKlYjDtH = new AList<ActionElementMap>();
			nnIGLjbilYWhebMKiOanRtFoprQq = new ReadOnlyCollection<ActionElementMap>(UJLJEaSiCVFRPgTvWpdGpKlYjDtH);
		}

		public ControllerMapWithAxes(ControllerMapWithAxes controllerMap)
			: base(controllerMap)
		{
			UJLJEaSiCVFRPgTvWpdGpKlYjDtH = new AList<ActionElementMap>();
			nnIGLjbilYWhebMKiOanRtFoprQq = new ReadOnlyCollection<ActionElementMap>(UJLJEaSiCVFRPgTvWpdGpKlYjDtH);
			if (controllerMap.UJLJEaSiCVFRPgTvWpdGpKlYjDtH != null)
			{
				int count = controllerMap.UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count;
				for (int i = 0; i < count; i++)
				{
					MLZJFmnHEjIjZVHwyEkbXZgfbkZ(new ActionElementMap(controllerMap.UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i]));
				}
			}
		}

		public override bool ContainsAction(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (base.ContainsAction(actionId))
			{
				return true;
			}
			if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH == null)
			{
				return false;
			}
			int count = UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count;
			for (int i = 0; i < count; i++)
			{
				if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i]._actionId == actionId)
				{
					return true;
				}
			}
			return false;
		}

		public override bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				result = null;
				return false;
			}
			if (base.CreateElementMap(actionId, axisContribution, elementIdentifierId, elementType, axisRange, invert, out result))
			{
				return true;
			}
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(elementType))
			{
				return false;
			}
			ActionElementMap actionElementMap = new ActionElementMap(actionId, elementType, elementIdentifierId, axisContribution, axisRange, invert);
			BakeElementMap(actionElementMap);
			MLZJFmnHEjIjZVHwyEkbXZgfbkZ(actionElementMap);
			result = actionElementMap;
			return true;
		}

		public override bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				result = null;
				return false;
			}
			if (base.ReplaceElementMap(elementMapId, actionId, axisContribution, elementIdentifierId, elementType, axisRange, invert, out result))
			{
				return true;
			}
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(elementType))
			{
				return false;
			}
			ActionElementMap elementMap = GetElementMap(elementMapId);
			if (elementMap == null)
			{
				return false;
			}
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(elementMap._elementType))
			{
				DeleteElementMap(elementMapId);
				elementMap._elementType = ControllerElementType.Axis;
				MLZJFmnHEjIjZVHwyEkbXZgfbkZ(elementMap);
			}
			int num = CcGPoCwdPTGFuoKdoVhIppkNlcp(elementMapId);
			if (num < 0)
			{
				return false;
			}
			ControllerMap.VbYTsEAPoQgdcsYwtmTpEeMSVQY(elementMap, actionId, axisContribution, elementIdentifierId, elementType, axisRange, invert);
			BakeElementMap(elementMap);
			result = elementMap;
			return true;
		}

		public override bool DeleteElementMap(int elementMapId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (base.DeleteElementMap(elementMapId))
			{
				return true;
			}
			int num = CcGPoCwdPTGFuoKdoVhIppkNlcp(elementMapId);
			if (num < 0)
			{
				return false;
			}
			uwynSkIDvtsmzFueBuqCAExcBBr(elementMapId, num);
			return true;
		}

		public override bool DeleteElementMapsWithAction(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			return DeleteElementMapsWithAction(ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName));
		}

		public override bool DeleteElementMapsWithAction(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			bool flag = base.DeleteElementMapsWithAction(actionId);
			return flag | DeleteAxisMapsWithAction(actionId);
		}

		public override ActionElementMap GetElementMap(int elementMapId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			ActionElementMap elementMap = base.GetElementMap(elementMapId);
			if (elementMap != null)
			{
				return elementMap;
			}
			if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH == null)
			{
				return null;
			}
			int count = UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count;
			for (int i = 0; i < count; i++)
			{
				if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i].BoMCLeauexjolkkRqzIpOQOAGri == elementMapId)
				{
					return UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
				}
			}
			return null;
		}

		public override ActionElementMap GetFirstElementMapWithAction(int actionId)
		{
			return GetFirstElementMapWithAction(actionId, skipDisabledMaps: false);
		}

		public override ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps)
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
			ActionElementMap firstElementMapWithAction = base.GetFirstElementMapWithAction(actionId, skipDisabledMaps);
			if (firstElementMapWithAction != null)
			{
				return firstElementMapWithAction;
			}
			int count = UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count;
			for (int i = 0; i < count; i++)
			{
				ActionElementMap actionElementMap = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
				if (actionElementMap._actionId == actionId && (!skipDisabledMaps || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM))
				{
					return actionElementMap;
				}
			}
			return null;
		}

		internal override ActionElementMap XJElERBtNBGdisiZeKGfVQVgXJL(Predicate<ActionElementMap> P_0, bool P_1)
		{
			ActionElementMap actionElementMap = base.XJElERBtNBGdisiZeKGfVQVgXJL(P_0, P_1);
			if (actionElementMap != null)
			{
				return actionElementMap;
			}
			return bsCNWZyHoDoHgAaThcNrPHZbtdn(P_0, P_1);
		}

		internal override int nYxHWYBhzcSPnNGDLPIYfSoccJt(Predicate<ActionElementMap> P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			int num = base.nYxHWYBhzcSPnNGDLPIYfSoccJt(P_0, P_1, P_2, P_3);
			return num + lTYakvijIsSuXqZEfkkXfpPpUSS(P_0, P_1, P_2, true);
		}

		public override void ClearElementMaps()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return;
			}
			base.ClearElementMaps();
			UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Clear();
		}

		public ActionElementMap GetAxisMap(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH == null || index < 0 || index >= UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count)
			{
				return null;
			}
			return UJLJEaSiCVFRPgTvWpdGpKlYjDtH[index];
		}

		public ActionElementMap[] GetAxisMaps()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.array;
			}
			return GetAxisMaps(skipDisabledMaps: false);
		}

		public ActionElementMap[] GetAxisMaps(bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.array;
			}
			if (!skipDisabledMaps)
			{
				return ListTools.ToArray(UJLJEaSiCVFRPgTvWpdGpKlYjDtH);
			}
			int num = axisMapCount;
			List<ActionElementMap> list = new List<ActionElementMap>(num);
			for (int i = 0; i < num; i++)
			{
				ActionElementMap actionElementMap = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
				if (actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM)
				{
					list.Add(actionElementMap);
				}
			}
			return list.ToArray();
		}

		public int GetAxisMaps(bool skipDisabledMaps, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			return REgEgjIdqzxkcYgZkPTZLWwKXK(skipDisabledMaps, results, false);
		}

		public ActionElementMap[] GetAxisMapsWithAction(string actionName)
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
			return GetAxisMapsWithAction(inputAction.id);
		}

		public ActionElementMap[] GetAxisMapsWithAction(int actionId)
		{
			return GetAxisMapsWithAction(actionId, skipDisabledMaps: false);
		}

		public ActionElementMap[] GetAxisMapsWithAction(string actionName, bool skipDisabledMaps)
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
			return GetAxisMapsWithAction(inputAction.id, skipDisabledMaps);
		}

		public ActionElementMap[] GetAxisMapsWithAction(int actionId, bool skipDisabledMaps)
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
			int num = axisMapCount;
			if (num == 0)
			{
				return EmptyObjects<ActionElementMap>.array;
			}
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				ActionElementMap actionElementMap = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
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
				ActionElementMap actionElementMap2 = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[j];
				if (actionElementMap2._actionId == actionId && (!skipDisabledMaps || actionElementMap2.nZTtfeZBpthDaoAvSONdTABGEaM))
				{
					array[num3] = actionElementMap2;
					num3++;
				}
			}
			return array;
		}

		public int GetAxisMapsWithAction(string actionName, List<ActionElementMap> results)
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
			return GetAxisMapsWithAction(inputAction.id, results);
		}

		public int GetAxisMapsWithAction(int actionId, List<ActionElementMap> results)
		{
			return GetAxisMapsWithAction(actionId, skipDisabledMaps: false, results);
		}

		public int GetAxisMapsWithAction(string actionName, bool skipDisabledMaps, List<ActionElementMap> results)
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
			return GetAxisMapsWithAction(inputAction.id, skipDisabledMaps, results);
		}

		public int GetAxisMapsWithAction(int actionId, bool skipDisabledMaps, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			return AFEuEUDCsmGMceBQdrVoJZTKsBP(actionId, skipDisabledMaps, results, false);
		}

		public IEnumerable<ActionElementMap> AxisMapsWithAction(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<ActionElementMap>.EmptyReadOnlyIListT;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return AxisMapsWithAction(actionId);
		}

		public IEnumerable<ActionElementMap> AxisMapsWithAction(int actionId)
		{
			return AxisMapsWithAction(actionId, skipDisabledMaps: false);
		}

		public IEnumerable<ActionElementMap> AxisMapsWithAction(string actionName, bool skipDisabledMaps)
		{
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return AxisMapsWithAction(actionId, skipDisabledMaps);
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
				foreach (ActionElementMap axisMap in AxisMaps)
				{
					if (axisMap._actionId == actionId && (!skipDisabledMaps || axisMap.nZTtfeZBpthDaoAvSONdTABGEaM))
					{
						yield return axisMap;
					}
				}
			}
		}

		public ActionElementMap GetFirstAxisMapWithAction(int actionId)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			return GetFirstAxisMapWithAction(actionId, skipDisabledMaps: false);
		}

		public ActionElementMap GetFirstAxisMapWithAction(string actionName)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			int actionId = ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName);
			return GetFirstAxisMapWithAction(actionId);
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
			IList<ActionElementMap> axisMaps = AxisMaps;
			int count = axisMaps.Count;
			for (int i = 0; i < count; i++)
			{
				ActionElementMap actionElementMap = axisMaps[i];
				if (actionElementMap._actionId == actionId && (!skipDisabledMaps || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM))
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

		public ActionElementMap GetFirstAxisMapMatch(Predicate<ActionElementMap> predicate)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			return bsCNWZyHoDoHgAaThcNrPHZbtdn(predicate, false);
		}

		internal ActionElementMap bsCNWZyHoDoHgAaThcNrPHZbtdn(Predicate<ActionElementMap> P_0, bool P_1)
		{
			if (P_0 == null)
			{
				throw new ArgumentNullException("predicate");
			}
			IList<ActionElementMap> axisMaps = AxisMaps;
			int num = axisMapCount;
			try
			{
				for (int i = 0; i < num; i++)
				{
					ActionElementMap actionElementMap = axisMaps[i];
					if ((!P_1 || actionElementMap.enabled) && P_0(actionElementMap))
					{
						return actionElementMap;
					}
				}
			}
			catch (Exception exception)
			{
				ReInput.HandleCallbackException("ControllerMap.GetFirstAxisMapMatch", exception);
			}
			return null;
		}

		public int GetAxisMapMatches(Predicate<ActionElementMap> predicate, List<ActionElementMap> results)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			return lTYakvijIsSuXqZEfkkXfpPpUSS(predicate, false, results, false);
		}

		internal int lTYakvijIsSuXqZEfkkXfpPpUSS(Predicate<ActionElementMap> P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
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
			IList<ActionElementMap> axisMaps = AxisMaps;
			int num2 = axisMapCount;
			try
			{
				for (int i = 0; i < num2; i++)
				{
					ActionElementMap actionElementMap = axisMaps[i];
					if ((!P_1 || actionElementMap.enabled) && P_0(actionElementMap))
					{
						P_2.Add(actionElementMap);
					}
				}
			}
			catch (Exception exception)
			{
				ReInput.HandleCallbackException("ControllerMap.GetAxisMapMatches", exception);
			}
			return P_2.Count - num;
		}

		public void ForEachAxisMapMatch(Predicate<ActionElementMap> predicate, Action<ActionElementMap> actionToPerform)
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
			int count = UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count;
			try
			{
				for (int i = 0; i < count; i++)
				{
					ActionElementMap obj = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
					if (predicate(obj))
					{
						actionToPerform(obj);
					}
				}
			}
			catch (Exception exception)
			{
				ReInput.HandleCallbackException("ControllerMap.ForEachAxisMapMatch", exception);
			}
		}

		public bool DeleteAxisMapsWithAction(string actionName)
		{
			return DeleteAxisMapsWithAction(ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.wDbPGBsfwyAzxAEZTjUyFzvfvMu(actionName));
		}

		public bool DeleteAxisMapsWithAction(int actionId)
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
			int num = axisMapCount;
			if (num == 0)
			{
				return false;
			}
			bool result = false;
			for (int num2 = num - 1; num2 >= 0; num2--)
			{
				if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH[num2] != null && UJLJEaSiCVFRPgTvWpdGpKlYjDtH[num2]._actionId == actionId)
				{
					uwynSkIDvtsmzFueBuqCAExcBBr(UJLJEaSiCVFRPgTvWpdGpKlYjDtH[num2].BoMCLeauexjolkkRqzIpOQOAGri, num2);
					result = true;
				}
			}
			return result;
		}

		public int SetAllAxisMapsEnabled(bool state)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			int num = 0;
			int count = UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count;
			for (int i = 0; i < count; i++)
			{
				ActionElementMap actionElementMap = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
				if (actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM != state)
				{
					actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM = state;
					num++;
				}
			}
			return num;
		}

		public override bool DoesElementAssignmentConflict(ControllerMap controllerMap, bool skipDisabledMaps)
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
			if (base.DoesElementAssignmentConflict(controllerMap, skipDisabledMaps))
			{
				return true;
			}
			if (!(controllerMap is ControllerMapWithAxes controllerMapWithAxes))
			{
				return false;
			}
			if (skipDisabledMaps && (!_enabled || !controllerMapWithAxes._enabled))
			{
				return false;
			}
			if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH == null)
			{
				return false;
			}
			IList<ActionElementMap> axisMaps = controllerMapWithAxes.AxisMaps;
			if (axisMaps == null)
			{
				return false;
			}
			int count = UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count;
			int count2 = axisMaps.Count;
			for (int i = 0; i < count; i++)
			{
				ActionElementMap actionElementMap = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
				if (skipDisabledMaps && !actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM)
				{
					continue;
				}
				for (int j = 0; j < count2; j++)
				{
					ActionElementMap actionElementMap2 = axisMaps[j];
					if ((!skipDisabledMaps || actionElementMap2.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap.CheckForAssignmentConflict(actionElementMap2))
					{
						return true;
					}
				}
			}
			return false;
		}

		public override bool DoesElementAssignmentConflict(ActionElementMap actionElementMap, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (actionElementMap == null)
			{
				return false;
			}
			if (base.DoesElementAssignmentConflict(actionElementMap, skipDisabledMaps))
			{
				return true;
			}
			if (skipDisabledMaps && (!_enabled || !actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM))
			{
				return false;
			}
			if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH == null)
			{
				return false;
			}
			for (int i = 0; i < UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count; i++)
			{
				ActionElementMap actionElementMap2 = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
				if ((!skipDisabledMaps || actionElementMap2.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap2.CheckForAssignmentConflict(actionElementMap))
				{
					return true;
				}
			}
			return false;
		}

		public override bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (base.DoesElementAssignmentConflict(conflictCheck, skipDisabledMaps))
			{
				return true;
			}
			if (skipDisabledMaps && !_enabled)
			{
				return false;
			}
			if (conflictCheck.elementAssignmentType != 0 && conflictCheck.elementAssignmentType != ElementAssignmentType.SplitAxis)
			{
				return false;
			}
			if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH == null)
			{
				return false;
			}
			ElementAssignment elementAssignment = conflictCheck.ToElementAssignment();
			for (int i = 0; i < UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count; i++)
			{
				ActionElementMap actionElementMap = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
				if ((!skipDisabledMaps || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri != conflictCheck.elementMapId && actionElementMap.CheckForAssignmentConflict(elementAssignment))
				{
					return true;
				}
			}
			return false;
		}

		public override IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else
			{
				if (controllerMap == null)
				{
					yield break;
				}
				foreach (ElementAssignmentConflictInfo item in base.ElementAssignmentConflicts(controllerMap, skipDisabledMaps))
				{
					yield return item;
				}
				if (!(controllerMap is ControllerMapWithAxes controllerMapWithAxes) || (skipDisabledMaps && (!_enabled || !controllerMapWithAxes._enabled)))
				{
					yield break;
				}
				IList<ActionElementMap> axisMaps = controllerMapWithAxes.AxisMaps;
				if (axisMaps == null)
				{
					yield break;
				}
				int count = axisMaps.Count;
				for (int i = 0; i < UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count; i++)
				{
					ActionElementMap actionElementMap = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
					if (skipDisabledMaps && !actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM)
					{
						continue;
					}
					for (int j = 0; j < count; j++)
					{
						ActionElementMap actionElementMap2 = axisMaps[j];
						if ((!skipDisabledMaps || actionElementMap2.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap.CheckForAssignmentConflict(actionElementMap2))
						{
							yield return new ElementAssignmentConflictInfo(isConflict: true, ReInput.mapping.GetMapCategory(_categoryId).userAssignable, -1, _controllerType, _controllerId, _id, actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri, actionElementMap._actionId, actionElementMap._elementType, actionElementMap._elementIdentifierId, actionElementMap.keyCode, actionElementMap.modifierKeyFlags);
						}
					}
				}
			}
		}

		public override IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
			}
			else
			{
				if (actionElementMap == null)
				{
					yield break;
				}
				foreach (ElementAssignmentConflictInfo item in base.ElementAssignmentConflicts(actionElementMap, skipDisabledMaps))
				{
					yield return item;
				}
				if ((skipDisabledMaps && (!_enabled || !actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM)) || UJLJEaSiCVFRPgTvWpdGpKlYjDtH == null)
				{
					yield break;
				}
				for (int i = 0; i < UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count; i++)
				{
					ActionElementMap actionElementMap2 = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
					if ((!skipDisabledMaps || actionElementMap2.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap2.CheckForAssignmentConflict(actionElementMap))
					{
						yield return new ElementAssignmentConflictInfo(isConflict: true, ReInput.mapping.GetMapCategory(_categoryId).userAssignable, -1, _controllerType, _controllerId, _id, actionElementMap2.BoMCLeauexjolkkRqzIpOQOAGri, actionElementMap2._actionId, actionElementMap2._elementType, actionElementMap2._elementIdentifierId, actionElementMap2.keyCode, actionElementMap2.modifierKeyFlags);
					}
				}
			}
		}

		public override IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				yield break;
			}
			foreach (ElementAssignmentConflictInfo item in base.ElementAssignmentConflicts(conflictCheck, skipDisabledMaps))
			{
				yield return item;
			}
			if ((skipDisabledMaps && !_enabled) || UJLJEaSiCVFRPgTvWpdGpKlYjDtH == null)
			{
				yield break;
			}
			ElementAssignment elementAssignment = conflictCheck.ToElementAssignment();
			for (int i = 0; i < UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count; i++)
			{
				ActionElementMap actionElementMap = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
				if ((!skipDisabledMaps || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri != conflictCheck.elementMapId && actionElementMap.CheckForAssignmentConflict(elementAssignment))
				{
					yield return new ElementAssignmentConflictInfo(isConflict: true, ReInput.mapping.GetMapCategory(_categoryId).userAssignable, -1, _controllerType, _controllerId, _id, actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri, actionElementMap._actionId, actionElementMap._elementType, actionElementMap._elementIdentifierId, actionElementMap.keyCode, actionElementMap.modifierKeyFlags);
				}
			}
		}

		public override int RemoveElementAssignmentConflicts(ControllerMap controllerMap, bool skipDisabledMaps)
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
			int num = base.RemoveElementAssignmentConflicts(controllerMap, skipDisabledMaps);
			if (!(controllerMap is ControllerMapWithAxes controllerMapWithAxes))
			{
				return num;
			}
			if (skipDisabledMaps && (!_enabled || !controllerMapWithAxes._enabled))
			{
				return num;
			}
			if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH == null)
			{
				return num;
			}
			IList<ActionElementMap> axisMaps = controllerMapWithAxes.AxisMaps;
			if (axisMaps == null)
			{
				return num;
			}
			InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(_categoryId);
			if (mapCategory != null && !mapCategory.userAssignable)
			{
				return num;
			}
			_ = UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count;
			int count = axisMaps.Count;
			for (int num2 = UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count - 1; num2 >= 0; num2--)
			{
				ActionElementMap actionElementMap = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[num2];
				if (!skipDisabledMaps || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM)
				{
					for (int i = 0; i < count; i++)
					{
						ActionElementMap actionElementMap2 = axisMaps[i];
						if ((!skipDisabledMaps || actionElementMap2.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap.CheckForAssignmentConflict(actionElementMap2))
						{
							uwynSkIDvtsmzFueBuqCAExcBBr(actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri, num2);
							num++;
							break;
						}
					}
				}
			}
			return num;
		}

		public override int RemoveElementAssignmentConflicts(ActionElementMap actionElementMap, bool skipDisabledMaps)
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
			int num = base.RemoveElementAssignmentConflicts(actionElementMap, skipDisabledMaps);
			if (skipDisabledMaps && (!_enabled || !actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM))
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
			if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH == null)
			{
				return num;
			}
			for (int num2 = UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count - 1; num2 >= 0; num2--)
			{
				ActionElementMap actionElementMap2 = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[num2];
				if ((!skipDisabledMaps || actionElementMap2.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap2.CheckForAssignmentConflict(actionElementMap))
				{
					uwynSkIDvtsmzFueBuqCAExcBBr(actionElementMap2.BoMCLeauexjolkkRqzIpOQOAGri, num2);
					num++;
				}
			}
			return num;
		}

		public override int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0;
			}
			int num = base.RemoveElementAssignmentConflicts(conflictCheck, skipDisabledMaps);
			if (skipDisabledMaps && !_enabled)
			{
				return num;
			}
			if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH == null)
			{
				return num;
			}
			if (conflictCheck.elementAssignmentType != 0 && conflictCheck.elementAssignmentType != ElementAssignmentType.SplitAxis)
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
			ElementAssignment elementAssignment = conflictCheck.ToElementAssignment();
			for (int num2 = UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count - 1; num2 >= 0; num2--)
			{
				ActionElementMap actionElementMap = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[num2];
				if ((!skipDisabledMaps || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM) && actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri != conflictCheck.elementMapId && actionElementMap.CheckForAssignmentConflict(elementAssignment))
				{
					uwynSkIDvtsmzFueBuqCAExcBBr(actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri, num2);
					num++;
				}
			}
			return num;
		}

		internal override int mhZadScPRZEsWIyiakthekVNlGBG(ControllerMap P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			int num = base.mhZadScPRZEsWIyiakthekVNlGBG(P_0, P_1, P_2, P_3);
			if (!(P_0 is ControllerMapWithAxes controllerMapWithAxes))
			{
				return num;
			}
			if (P_1 && (!_enabled || !controllerMapWithAxes._enabled))
			{
				return num;
			}
			if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH == null)
			{
				return num;
			}
			IList<ActionElementMap> axisMaps = controllerMapWithAxes.AxisMaps;
			if (axisMaps == null)
			{
				return num;
			}
			InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(_categoryId);
			if (mapCategory != null && !mapCategory.userAssignable)
			{
				return num;
			}
			int count = UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count;
			int count2 = axisMaps.Count;
			for (int i = 0; i < count; i++)
			{
				ActionElementMap actionElementMap = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
				if (!actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM)
				{
					continue;
				}
				for (int j = 0; j < count2; j++)
				{
					ActionElementMap actionElementMap2 = axisMaps[j];
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

		internal override int mhZadScPRZEsWIyiakthekVNlGBG(ActionElementMap P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			int num = base.mhZadScPRZEsWIyiakthekVNlGBG(P_0, P_1, P_2, P_3);
			if (P_0 == null)
			{
				return num;
			}
			if (P_1 && (!_enabled || !P_0.nZTtfeZBpthDaoAvSONdTABGEaM))
			{
				return num;
			}
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
			int num2 = axisMapCount;
			for (int i = 0; i < num2; i++)
			{
				ActionElementMap actionElementMap = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
				if (actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM && P_0.CheckForAssignmentConflict(actionElementMap))
				{
					actionElementMap.enabled = false;
					P_2?.Add(actionElementMap);
					num++;
				}
			}
			return num;
		}

		internal override int mhZadScPRZEsWIyiakthekVNlGBG(ElementAssignmentConflictCheck P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			int num = base.mhZadScPRZEsWIyiakthekVNlGBG(P_0, P_1, P_2, P_3);
			if (P_1 && !_enabled)
			{
				return num;
			}
			if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH == null)
			{
				return num;
			}
			if (P_0.elementAssignmentType != 0 && P_0.elementAssignmentType != ElementAssignmentType.SplitAxis)
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
			ElementAssignment elementAssignment = P_0.ToElementAssignment();
			int count = UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count;
			for (int i = 0; i < count; i++)
			{
				ActionElementMap actionElementMap = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
				if (actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM && actionElementMap.BoMCLeauexjolkkRqzIpOQOAGri != P_0.elementMapId && actionElementMap.CheckForAssignmentConflict(elementAssignment))
				{
					actionElementMap.enabled = false;
					P_2?.Add(actionElementMap);
					num++;
				}
			}
			return num;
		}

		public string[] GetAxisNames()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return EmptyObjects<string>.array;
			}
			int num = axisMapCount;
			if (num == 0)
			{
				return null;
			}
			string[] array = new string[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i].elementIdentifierName;
			}
			return array;
		}

		internal override bool cOYCFliSLtjGEfDRHMGzdQVtdteA(ActionElementMap P_0)
		{
			if (base.cOYCFliSLtjGEfDRHMGzdQVtdteA(P_0))
			{
				return true;
			}
			ControllerElementType elementType = P_0._elementType;
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(elementType))
			{
				return false;
			}
			MLZJFmnHEjIjZVHwyEkbXZgfbkZ(P_0);
			return true;
		}

		internal override int ZaUNnOLPcrdqeSVoeoRcJfoOcuPh(List<ActionElementMap> P_0, bool P_1)
		{
			base.ZaUNnOLPcrdqeSVoeoRcJfoOcuPh(P_0, P_1);
			int count = P_0.Count;
			int count2 = UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count;
			for (int i = 0; i < count2; i++)
			{
				if (!P_1 || UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i].nZTtfeZBpthDaoAvSONdTABGEaM)
				{
					P_0.Add(UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i]);
				}
			}
			return P_0.Count - count;
		}

		internal override ActionElementMap qDpyvMYMDLWpNKBJMgFRdiaXOOH(int P_0, int P_1, ControllerElementType P_2)
		{
			ActionElementMap actionElementMap = base.qDpyvMYMDLWpNKBJMgFRdiaXOOH(P_0, P_1, P_2);
			if (actionElementMap != null)
			{
				return actionElementMap;
			}
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(P_2))
			{
				return null;
			}
			int num = oXhvPiImtukIdYWWZiEgypBcgXV(P_0, P_1, P_2);
			if (num < 0)
			{
				return null;
			}
			if (P_2 == ControllerElementType.Axis)
			{
				return UJLJEaSiCVFRPgTvWpdGpKlYjDtH[num];
			}
			throw new NotImplementedException();
		}

		internal override int PTVivKfqnzQRgshXiLmalPsimLJ(int P_0, List<ActionElementMap> P_1, bool P_2)
		{
			if (P_1 == null)
			{
				throw new ArgumentNullException("results");
			}
			int num = (P_2 ? P_1.Count : 0);
			base.PTVivKfqnzQRgshXiLmalPsimLJ(P_0, P_1, P_2);
			if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH == null)
			{
				return P_1.Count - num;
			}
			int count = UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count;
			for (int i = 0; i < count; i++)
			{
				if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i]._elementIdentifierId == P_0)
				{
					P_1.Add(UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i]);
				}
			}
			return P_1.Count - num;
		}

		internal override bool RDdGNLBIHpxzHQrHimunxgfPPHub(int P_0, int P_1, ControllerElementType P_2)
		{
			if (base.RDdGNLBIHpxzHQrHimunxgfPPHub(P_0, P_1, P_2))
			{
				return true;
			}
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(P_2))
			{
				return false;
			}
			if (P_2 == ControllerElementType.Axis)
			{
				int count = UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count;
				for (int i = 0; i < count; i++)
				{
					if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i]._elementIdentifierId == P_0 && UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i]._actionId == P_1)
					{
						return true;
					}
				}
				return false;
			}
			throw new NotImplementedException();
		}

		internal override int oXhvPiImtukIdYWWZiEgypBcgXV(int P_0, int P_1, ControllerElementType P_2)
		{
			int num = base.oXhvPiImtukIdYWWZiEgypBcgXV(P_0, P_1, P_2);
			if (num >= 0)
			{
				return num;
			}
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(P_2))
			{
				return -1;
			}
			if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH == null)
			{
				return -1;
			}
			if (P_2 == ControllerElementType.Axis)
			{
				int count = UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count;
				for (int i = 0; i < count; i++)
				{
					if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i]._elementIdentifierId == P_0 && UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i]._actionId == P_1)
					{
						return i;
					}
				}
				return -1;
			}
			throw new NotImplementedException();
		}

		internal int CcGPoCwdPTGFuoKdoVhIppkNlcp(int P_0)
		{
			if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH == null)
			{
				return -1;
			}
			int count = UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Count;
			for (int i = 0; i < count; i++)
			{
				if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i].BoMCLeauexjolkkRqzIpOQOAGri == P_0)
				{
					return i;
				}
			}
			return -1;
		}

		internal int REgEgjIdqzxkcYgZkPTZLWwKXK(bool P_0, List<ActionElementMap> P_1, bool P_2)
		{
			if (P_1 == null)
			{
				throw new ArgumentNullException("results");
			}
			if (!P_2)
			{
				P_1.Clear();
			}
			int num = axisMapCount;
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				ActionElementMap actionElementMap = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
				if (!P_0 || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM)
				{
					P_1.Add(actionElementMap);
					num2++;
				}
			}
			return num2;
		}

		internal int AFEuEUDCsmGMceBQdrVoJZTKsBP(int P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
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
			int num = axisMapCount;
			int num2 = 0;
			for (int i = 0; i < num; i++)
			{
				ActionElementMap actionElementMap = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
				if (actionElementMap._actionId == P_0 && (!P_1 || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM))
				{
					P_2.Add(actionElementMap);
					num2++;
				}
			}
			return num2;
		}

		internal override int hHAktoEzTjklPLyzcjMCfmqeriO(int P_0, bool P_1, List<ActionElementMap> P_2, bool P_3)
		{
			int num = base.hHAktoEzTjklPLyzcjMCfmqeriO(P_0, P_1, P_2, P_3);
			if (P_0 < 0)
			{
				return num;
			}
			int num2 = axisMapCount;
			for (int i = 0; i < num2; i++)
			{
				ActionElementMap actionElementMap = UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
				if (actionElementMap._actionId == P_0 && (!P_1 || actionElementMap.nZTtfeZBpthDaoAvSONdTABGEaM))
				{
					P_2.Add(actionElementMap);
					num++;
				}
			}
			return num;
		}

		internal override ActionElementMap VfcfyKNKnGeUcaZTKcbxEoucaoFO(IControllerElementTarget P_0, bool P_1, int P_2, bool P_3, out bool P_4)
		{
			ActionElementMap actionElementMap = base.VfcfyKNKnGeUcaZTKcbxEoucaoFO(P_0, P_1, P_2, P_3, out P_4);
			if (actionElementMap != null)
			{
				return actionElementMap;
			}
			if (P_4)
			{
				return null;
			}
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(P_0.elementType))
			{
				return null;
			}
			int num = axisMapCount;
			_ = P_0.elementIdentifierId;
			for (int i = 0; i < num; i++)
			{
				if ((!P_1 || UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i]._actionId == P_2) && (!P_3 || UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i].nZTtfeZBpthDaoAvSONdTABGEaM) && UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i].IsTarget(P_0))
				{
					return UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i];
				}
			}
			return null;
		}

		internal override int JzTnuZQPeJZpOCUTrCSLHdIycSYG(IControllerElementTarget P_0, bool P_1, int P_2, bool P_3, List<ActionElementMap> P_4, bool P_5, out bool P_6)
		{
			int num = base.JzTnuZQPeJZpOCUTrCSLHdIycSYG(P_0, P_1, P_2, P_3, P_4, P_5, out P_6);
			if (P_6)
			{
				return num;
			}
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(P_0.elementType))
			{
				return num;
			}
			int num2 = axisMapCount;
			_ = P_0.elementIdentifierId;
			for (int i = 0; i < num2; i++)
			{
				if ((!P_1 || UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i]._actionId == P_2) && (!P_3 || UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i].nZTtfeZBpthDaoAvSONdTABGEaM) && UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i].IsTarget(P_0))
				{
					P_4.Add(UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i]);
					num++;
				}
			}
			return num;
		}

		internal override bool AMitEmYOawZwzTNfMPWFEkGrtco(ActionElementMap P_0)
		{
			if (base.AMitEmYOawZwzTNfMPWFEkGrtco(P_0))
			{
				return true;
			}
			if (P_0 == null)
			{
				return false;
			}
			if (!bVLuZgVxltodTscOsEIfKtFHBdt(P_0._elementType))
			{
				return false;
			}
			UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Add(P_0);
			lSbAFMHMYMOJTotcLFYtToDjlaDq(P_0);
			return true;
		}

		private bool bVLuZgVxltodTscOsEIfKtFHBdt(ControllerElementType P_0)
		{
			if (P_0 != 0)
			{
				return false;
			}
			return true;
		}

		private void uwynSkIDvtsmzFueBuqCAExcBBr(int P_0, int P_1)
		{
			bxwBSedWxwfoPPptVOhvKHrgnQKL(P_0);
			if (P_1 >= 0 && P_1 < axisMapCount)
			{
				UJLJEaSiCVFRPgTvWpdGpKlYjDtH.RemoveAt(P_1);
			}
		}

		private void MLZJFmnHEjIjZVHwyEkbXZgfbkZ(ActionElementMap P_0)
		{
			if (P_0 != null)
			{
				UJLJEaSiCVFRPgTvWpdGpKlYjDtH.Add(P_0);
				lSbAFMHMYMOJTotcLFYtToDjlaDq(P_0);
			}
		}

		private void TrXbbGpAlDnTHxhkhMSfdJWVFMbd(ActionElementMap P_0, int P_1)
		{
			if (P_0 != null && P_1 >= 0 && P_1 < axisMapCount)
			{
				wfZdzOlcgjiGUhXNfevhWBxcQcvD(UJLJEaSiCVFRPgTvWpdGpKlYjDtH[P_1].BoMCLeauexjolkkRqzIpOQOAGri, P_0);
				UJLJEaSiCVFRPgTvWpdGpKlYjDtH[P_1] = P_0;
			}
		}

		internal override void tobyAseOeexEQBYeyNriFyhLxKv(SerializedObject P_0)
		{
			base.tobyAseOeexEQBYeyNriFyhLxKv(P_0);
			int num = axisMapCount;
			List<object> list = new List<object>();
			P_0.Add("axisMaps", list);
			for (int i = 0; i < num; i++)
			{
				if (UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i] != null)
				{
					list.Add(UJLJEaSiCVFRPgTvWpdGpKlYjDtH[i].KmsZJAaClfxbOKcqKGgeMqITFsc());
				}
			}
		}

		internal override bool jzPtspnkZAgrKJfuKATzOhURnEB(SerializedObject P_0)
		{
			bool flag = base.jzPtspnkZAgrKJfuKATzOhURnEB(P_0);
			if (!flag)
			{
				ClearElementMaps();
				flag = true;
			}
			SerializedObject value = null;
			if (P_0.TryGetDeserializedValueByRef("axisMaps", ref value) && value != null)
			{
				for (int i = 0; i < value.count; i++)
				{
					if (value.TryGetDeserializedValue<SerializedObject>(i, out var value2) || value2 == null)
					{
						ActionElementMap actionElementMap = new ActionElementMap();
						actionElementMap.jzPtspnkZAgrKJfuKATzOhURnEB(value2);
						if (ActionElementMap.DELMeXKAfFIGOFYSEfHUJAflYci(actionElementMap))
						{
							MLZJFmnHEjIjZVHwyEkbXZgfbkZ(actionElementMap);
						}
					}
				}
			}
			return flag;
		}

		[CompilerGenerated]
		private IEnumerable<ElementAssignmentConflictInfo> ABmLMGHTkVgCxeBNVdSejBhLakFz(ControllerMap P_0, bool P_1)
		{
			return base.ElementAssignmentConflicts(P_0, P_1);
		}

		[CompilerGenerated]
		private IEnumerable<ElementAssignmentConflictInfo> dRizcwiHFEbzbkevCmqybRDjAjb(ActionElementMap P_0, bool P_1)
		{
			return base.ElementAssignmentConflicts(P_0, P_1);
		}

		[CompilerGenerated]
		private IEnumerable<ElementAssignmentConflictInfo> dvFANzipHxLJLuxirizmermZWEHl(ElementAssignmentConflictCheck P_0, bool P_1)
		{
			return base.ElementAssignmentConflicts(P_0, P_1);
		}
	}
}
