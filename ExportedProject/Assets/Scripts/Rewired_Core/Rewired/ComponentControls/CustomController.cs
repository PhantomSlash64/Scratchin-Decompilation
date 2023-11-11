using System;
using System.Collections.Generic;
using Rewired.ComponentControls.Data;
using Rewired.Data;
using Rewired.Utils;
using UnityEngine;

namespace Rewired.ComponentControls
{
	[Serializable]
	[AddComponentMenu("Rewired/Custom Controller")]
	[DisallowMultipleComponent]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	public class CustomController : ComponentController
	{
		[Serializable]
		public class CreateCustomControllerSettings
		{
			[Tooltip("If true, a new Custom Controller will be created. Otherwise, an existing Custom Controller will be found using the selector properties.")]
			[CustomObfuscation(rename = false)]
			[SerializeField]
			private bool _createCustomController = true;

			[Tooltip("The source id of the Custom Controller to create. Get this from the Rewired Input Manager.")]
			[CustomObfuscation(rename = false)]
			[SerializeField]
			private int _customControllerSourceId = -1;

			[CustomObfuscation(rename = false)]
			[Tooltip("The Player that will be assigned this Custom Controller when it is created.")]
			[SerializeField]
			private int _assignToPlayerId;

			[Tooltip("If true, the Custom Controller created by this component will be destroyed when this component is destroyed.")]
			[SerializeField]
			[CustomObfuscation(rename = false)]
			private bool _destroyCustomController = true;

			public bool createCustomController
			{
				get
				{
					return _createCustomController;
				}
				set
				{
					if (_createCustomController != value)
					{
						_createCustomController = value;
					}
				}
			}

			public int customControllerSourceId
			{
				get
				{
					return _customControllerSourceId;
				}
				set
				{
					_customControllerSourceId = value;
				}
			}

			public int assignToPlayerId
			{
				get
				{
					return _assignToPlayerId;
				}
				set
				{
					_assignToPlayerId = value;
				}
			}

			public bool destroyCustomController
			{
				get
				{
					return _destroyCustomController;
				}
				set
				{
					_destroyCustomController = value;
				}
			}
		}

		private struct fXlXNsAuXfrdOhRjuKzxXXdTNIR
		{
			public CustomControllerElementSelector.ElementType DffVgxLTxGtWFSQnSTfYIAPKKDj;

			public int wkTGWLXdweLqZjigTyvMxxKxDvp;

			public float foSRcEqSuRsWnadDiKcGnhBewOU;

			public fXlXNsAuXfrdOhRjuKzxXXdTNIR(CustomControllerElementSelector.ElementType elementType, int elementIndex, float value)
			{
				DffVgxLTxGtWFSQnSTfYIAPKKDj = elementType;
				wkTGWLXdweLqZjigTyvMxxKxDvp = elementIndex;
				foSRcEqSuRsWnadDiKcGnhBewOU = value;
			}

			public fXlXNsAuXfrdOhRjuKzxXXdTNIR(CustomControllerElementSelector.ElementType elementType, int elementIndex, bool value)
			{
				DffVgxLTxGtWFSQnSTfYIAPKKDj = elementType;
				wkTGWLXdweLqZjigTyvMxxKxDvp = elementIndex;
				foSRcEqSuRsWnadDiKcGnhBewOU = (value ? 1f : 0f);
			}

			public bool ZmJgXIszemLzAbeMBnVDIvApfYY(CustomControllerElementSelector.ElementType P_0, int P_1)
			{
				if (DffVgxLTxGtWFSQnSTfYIAPKKDj == P_0)
				{
					return wkTGWLXdweLqZjigTyvMxxKxDvp == P_1;
				}
				return false;
			}

			public void fXPhyUzKDetRtrRNdVKrqUJqTU(float P_0)
			{
				foSRcEqSuRsWnadDiKcGnhBewOU = MathTools.MaxMagnitude(foSRcEqSuRsWnadDiKcGnhBewOU, P_0);
			}

			public void fXPhyUzKDetRtrRNdVKrqUJqTU(bool P_0)
			{
				if (P_0)
				{
					foSRcEqSuRsWnadDiKcGnhBewOU = 1f;
				}
			}
		}

		[SerializeField]
		[Tooltip("(Optional) Link the Rewired Input Manager here for easier access to Custom Controller elements, etc.")]
		[CustomObfuscation(rename = false)]
		private InputManager_Base _rewiredInputManager;

		[Tooltip("Contains search parameters to find a particular Custom Controller.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private CustomControllerSelector _customControllerSelector = new CustomControllerSelector();

		[Tooltip("Settings for creating a Custom Controller on start.")]
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private CreateCustomControllerSettings _createCustomControllerSettings = new CreateCustomControllerSettings();

		private List<fXlXNsAuXfrdOhRjuKzxXXdTNIR> pQlFMSfsNWumIkmWXRBqBMJEHTJN = new List<fXlXNsAuXfrdOhRjuKzxXXdTNIR>(10);

		[NonSerialized]
		private int AnVMDfYuJfbdBsHCBQCkENZGZoF = -1;

		private Action OzIXwsUkOqbKUhMpEKRhEetjcIdH;

		public InputManager_Base rewiredInputManager
		{
			get
			{
				return _rewiredInputManager;
			}
			set
			{
				if (!(_rewiredInputManager == value))
				{
					_rewiredInputManager = value;
					QCALZHBveTZKrIACkwpJsrxWoUa();
				}
			}
		}

		public CustomControllerSelector customControllerSelector => _customControllerSelector;

		public CreateCustomControllerSettings createCustomControllerSettings => _createCustomControllerSettings;

		internal event Action InputSourceUpdateEvent
		{
			add
			{
				OzIXwsUkOqbKUhMpEKRhEetjcIdH = (Action)Delegate.Combine(OzIXwsUkOqbKUhMpEKRhEetjcIdH, value);
			}
			remove
			{
				OzIXwsUkOqbKUhMpEKRhEetjcIdH = (Action)Delegate.Remove(OzIXwsUkOqbKUhMpEKRhEetjcIdH, value);
			}
		}

		[CustomObfuscation(rename = false)]
		internal CustomController()
		{
		}

		public Rewired.CustomController GetCustomController()
		{
			return FWZkRMuknthenkBjRBPUsZyMEpF(false);
		}

		[CustomObfuscation(rename = false)]
		internal override void OnEnable()
		{
			base.OnEnable();
			_ = base.initialized;
		}

		[CustomObfuscation(rename = false)]
		internal override void OnDisable()
		{
			base.OnDisable();
			if (base.initialized)
			{
				pQlFMSfsNWumIkmWXRBqBMJEHTJN.Clear();
			}
		}

		[CustomObfuscation(rename = false)]
		internal override void OnValidate()
		{
			base.OnValidate();
			if (base.initialized)
			{
				QCALZHBveTZKrIACkwpJsrxWoUa();
			}
		}

		[CustomObfuscation(rename = false)]
		internal override void OnDestroy()
		{
			base.OnDestroy();
			vfnddZQIhDJjMktzHTENYSHYETz();
		}

		internal virtual bool OnInitialize()
		{
			if (!base.sTGamvWFKxGXQiXUVibUDPQNCmv())
			{
				return false;
			}
			if (GetUseCustomController())
			{
				if (!xkpVjzKucJCigtSpnnPfSuaHfRK())
				{
					return false;
				}
				if (FWZkRMuknthenkBjRBPUsZyMEpF(true) == null)
				{
					SetUseCustomController(value: false);
				}
			}
			return true;
		}

		internal virtual void OnSubscribeEvents()
		{
			base.vVOkBAFOLrFCgxJvZTjUEsBzcRV();
			YWpzYbuwLnICLOIxYOdSdgrbQWU();
			if (ReInput.isReady)
			{
				ReInput.InputSourceUpdateEvent += pHwfVcZfRoODAlBJLPEjAQeVjjDc;
			}
		}

		internal virtual void OnUnsubscribeEvents()
		{
			base.YWpzYbuwLnICLOIxYOdSdgrbQWU();
			ReInput.InputSourceUpdateEvent -= pHwfVcZfRoODAlBJLPEjAQeVjjDc;
		}

		public override void ClearControlValues()
		{
			base.ClearControlValues();
			if (base.initialized)
			{
				pQlFMSfsNWumIkmWXRBqBMJEHTJN.Clear();
			}
		}

		[CustomObfuscation(rename = false)]
		internal virtual bool GetUseCustomController()
		{
			return true;
		}

		[CustomObfuscation(rename = false)]
		internal virtual void SetUseCustomController(bool value)
		{
		}

		internal void SetAxisValue(CustomControllerElementSelector element, float value)
		{
			if (!base.initialized || element == null || !GetUseCustomController())
			{
				return;
			}
			Rewired.CustomController customController = FWZkRMuknthenkBjRBPUsZyMEpF(false);
			if (customController == null)
			{
				return;
			}
			int elementIndex = element.GetElementIndex(customController);
			if (elementIndex < 0)
			{
				return;
			}
			_ = pQlFMSfsNWumIkmWXRBqBMJEHTJN.Count;
			for (int i = 0; i < pQlFMSfsNWumIkmWXRBqBMJEHTJN.Count; i++)
			{
				fXlXNsAuXfrdOhRjuKzxXXdTNIR value2 = pQlFMSfsNWumIkmWXRBqBMJEHTJN[i];
				if (value2.ZmJgXIszemLzAbeMBnVDIvApfYY(element.elementType, elementIndex))
				{
					value2.fXPhyUzKDetRtrRNdVKrqUJqTU(value);
					pQlFMSfsNWumIkmWXRBqBMJEHTJN[i] = value2;
					return;
				}
			}
			pQlFMSfsNWumIkmWXRBqBMJEHTJN.Add(new fXlXNsAuXfrdOhRjuKzxXXdTNIR(element.elementType, elementIndex, value));
		}

		internal void SetButtonValue(CustomControllerElementSelector element, bool value)
		{
			if (!base.initialized || element == null || !GetUseCustomController())
			{
				return;
			}
			Rewired.CustomController customController = FWZkRMuknthenkBjRBPUsZyMEpF(false);
			if (customController == null)
			{
				return;
			}
			int elementIndex = element.GetElementIndex(customController);
			if (elementIndex < 0)
			{
				return;
			}
			_ = pQlFMSfsNWumIkmWXRBqBMJEHTJN.Count;
			for (int i = 0; i < pQlFMSfsNWumIkmWXRBqBMJEHTJN.Count; i++)
			{
				fXlXNsAuXfrdOhRjuKzxXXdTNIR value2 = pQlFMSfsNWumIkmWXRBqBMJEHTJN[i];
				if (value2.ZmJgXIszemLzAbeMBnVDIvApfYY(element.elementType, elementIndex))
				{
					value2.fXPhyUzKDetRtrRNdVKrqUJqTU(value);
					pQlFMSfsNWumIkmWXRBqBMJEHTJN[i] = value2;
					return;
				}
			}
			pQlFMSfsNWumIkmWXRBqBMJEHTJN.Add(new fXlXNsAuXfrdOhRjuKzxXXdTNIR(element.elementType, elementIndex, value));
		}

		internal void ClearElementValue(CustomControllerElementTargetSet targetSet)
		{
			if (targetSet != null)
			{
				int targetCount = targetSet.targetCount;
				for (int i = 0; i < targetCount; i++)
				{
					ClearElementValue(targetSet[i]);
				}
			}
		}

		internal void ClearElementValue(CustomControllerElementTarget target)
		{
			if (target != null)
			{
				ClearElementValue(target.element);
			}
		}

		internal void ClearElementValue(CustomControllerElementSelector element)
		{
			if (!base.initialized || element == null || !GetUseCustomController())
			{
				return;
			}
			Rewired.CustomController customController = FWZkRMuknthenkBjRBPUsZyMEpF(false);
			if (customController == null)
			{
				return;
			}
			int elementIndex = element.GetElementIndex(customController);
			if (elementIndex < 0)
			{
				return;
			}
			switch (element.elementType)
			{
			case CustomControllerElementSelector.ElementType.Axis:
				customController.ClearAxisValue(elementIndex);
				break;
			case CustomControllerElementSelector.ElementType.Button:
				customController.ClearButtonValue(elementIndex);
				break;
			default:
				throw new NotImplementedException();
			}
			_ = pQlFMSfsNWumIkmWXRBqBMJEHTJN.Count;
			for (int num = pQlFMSfsNWumIkmWXRBqBMJEHTJN.Count - 1; num >= 0; num--)
			{
				if (pQlFMSfsNWumIkmWXRBqBMJEHTJN[num].ZmJgXIszemLzAbeMBnVDIvApfYY(element.elementType, elementIndex))
				{
					pQlFMSfsNWumIkmWXRBqBMJEHTJN.RemoveAt(num);
				}
			}
		}

		internal int ElementExists_Editor(CustomControllerElementSelector element)
		{
			if (element == null)
			{
				return -1;
			}
			if (!element.isAssigned)
			{
				return -1;
			}
			if (_rewiredInputManager == null)
			{
				return -1;
			}
			if (!_customControllerSelector.findUsingSourceId)
			{
				return -1;
			}
			CustomController_Editor customControllerById = _rewiredInputManager.userData.GetCustomControllerById(_customControllerSelector.sourceId);
			if (customControllerById == null)
			{
				return -1;
			}
			switch (element.selectorType)
			{
			case CustomControllerElementSelector.SelectorType.Id:
				if (!customControllerById.ContainsElementIdentifier(element.elementId))
				{
					return 0;
				}
				return 1;
			case CustomControllerElementSelector.SelectorType.Index:
				switch (element.elementType)
				{
				case CustomControllerElementSelector.ElementType.Axis:
					if (element.elementIndex < 0 || element.elementIndex >= customControllerById.axisCount)
					{
						return 0;
					}
					return 1;
				case CustomControllerElementSelector.ElementType.Button:
					if (element.elementIndex < 0 || element.elementIndex >= customControllerById.buttonCount)
					{
						return 0;
					}
					return 1;
				default:
					throw new NotImplementedException();
				}
			case CustomControllerElementSelector.SelectorType.Name:
				if (!ArrayTools.Contains(customControllerById.GetElementIdentifierNames(), element.elementName))
				{
					return 0;
				}
				return 1;
			default:
				throw new NotImplementedException();
			}
		}

		internal bool ElementExists(CustomControllerElementSelector element)
		{
			if (!base.initialized)
			{
				return false;
			}
			if (element == null)
			{
				return false;
			}
			Rewired.CustomController customController = FWZkRMuknthenkBjRBPUsZyMEpF(false);
			if (customController == null)
			{
				return false;
			}
			return element.GetElementIndex(customController) >= 0;
		}

		internal bool ValidateElements(CustomControllerElementTargetSet targetSet)
		{
			if (targetSet == null)
			{
				return false;
			}
			bool flag = true;
			int targetCount = targetSet.targetCount;
			for (int i = 0; i < targetCount; i++)
			{
				flag &= ValidateElement(targetSet[i]);
			}
			return flag;
		}

		internal bool ValidateElement(CustomControllerElementTarget target)
		{
			if (target == null)
			{
				return false;
			}
			return ValidateElement(target.element);
		}

		internal bool ValidateElement(CustomControllerElementSelector element)
		{
			if (!base.initialized)
			{
				return false;
			}
			if (!GetUseCustomController())
			{
				return false;
			}
			if (element == null)
			{
				return false;
			}
			if (!element.isAssigned)
			{
				return false;
			}
			Rewired.CustomController customController = FWZkRMuknthenkBjRBPUsZyMEpF(false);
			if (customController == null)
			{
				return false;
			}
			if (!ElementExists(element))
			{
				Logger.LogWarning("No element found for " + element.GetSelectorFormattedString() + " in Custom Controller \"" + customController.name + "\"");
				return false;
			}
			return true;
		}

		private void QCALZHBveTZKrIACkwpJsrxWoUa()
		{
			if (base.initialized)
			{
				pQlFMSfsNWumIkmWXRBqBMJEHTJN.Clear();
			}
		}

		private bool xkpVjzKucJCigtSpnnPfSuaHfRK()
		{
			if (ReInput.isReady)
			{
				return true;
			}
			Logger.LogError("Rewired is not initialized. You must have an enabled Rewired Input Manager in the scene if using a Custom Controller. Custom Controller support will be disabled on this Custom Controller.");
			SetUseCustomController(value: false);
			return false;
		}

		private void zRufekZVEKHvUZzuADmZaHypjsO()
		{
			if (pQlFMSfsNWumIkmWXRBqBMJEHTJN.Count == 0)
			{
				return;
			}
			Rewired.CustomController customController = FWZkRMuknthenkBjRBPUsZyMEpF(false);
			if (customController == null)
			{
				pQlFMSfsNWumIkmWXRBqBMJEHTJN.Clear();
				return;
			}
			for (int i = 0; i < pQlFMSfsNWumIkmWXRBqBMJEHTJN.Count; i++)
			{
				fXlXNsAuXfrdOhRjuKzxXXdTNIR fXlXNsAuXfrdOhRjuKzxXXdTNIR = pQlFMSfsNWumIkmWXRBqBMJEHTJN[i];
				switch (fXlXNsAuXfrdOhRjuKzxXXdTNIR.DffVgxLTxGtWFSQnSTfYIAPKKDj)
				{
				case CustomControllerElementSelector.ElementType.Axis:
					customController.SetAxisValue(fXlXNsAuXfrdOhRjuKzxXXdTNIR.wkTGWLXdweLqZjigTyvMxxKxDvp, fXlXNsAuXfrdOhRjuKzxXXdTNIR.foSRcEqSuRsWnadDiKcGnhBewOU);
					break;
				case CustomControllerElementSelector.ElementType.Button:
					customController.SetButtonValue(fXlXNsAuXfrdOhRjuKzxXXdTNIR.wkTGWLXdweLqZjigTyvMxxKxDvp, fXlXNsAuXfrdOhRjuKzxXXdTNIR.foSRcEqSuRsWnadDiKcGnhBewOU != 0f);
					break;
				default:
					throw new NotImplementedException();
				}
			}
			pQlFMSfsNWumIkmWXRBqBMJEHTJN.Clear();
		}

		private Rewired.CustomController FWZkRMuknthenkBjRBPUsZyMEpF(bool P_0)
		{
			if (!GetUseCustomController())
			{
				return null;
			}
			if (!ReInput.isReady)
			{
				return null;
			}
			Rewired.CustomController customController;
			if (AnVMDfYuJfbdBsHCBQCkENZGZoF >= 0)
			{
				customController = ReInput.controllers.GetCustomController(AnVMDfYuJfbdBsHCBQCkENZGZoF);
				if (customController == null)
				{
					AnVMDfYuJfbdBsHCBQCkENZGZoF = -1;
				}
			}
			else
			{
				customController = null;
			}
			if (customController == null)
			{
				if (_createCustomControllerSettings.createCustomController)
				{
					customController = ReInput.controllers.CreateCustomController(_createCustomControllerSettings.customControllerSourceId);
					if (customController != null)
					{
						AnVMDfYuJfbdBsHCBQCkENZGZoF = customController.id;
						ihweuNkjBcGTCiugNGahqEzxMuv(customController);
					}
				}
				else
				{
					customController = _customControllerSelector.GetCustomController();
				}
			}
			if (P_0 && customController == null && GetUseCustomController())
			{
				Logger.LogWarning("No Custom Controller was found matching the search parameters.");
			}
			return customController;
		}

		private void ihweuNkjBcGTCiugNGahqEzxMuv(Rewired.CustomController P_0)
		{
			if (P_0 == null)
			{
				return;
			}
			if (_createCustomControllerSettings.assignToPlayerId == -1)
			{
				if (Application.isEditor)
				{
					Logger.LogWarning("The Custom Controller has not been assigned to any Player and will not be used for input until it is assigned. You should set the Player to assign it to in the inspector.");
				}
				return;
			}
			Player player = ReInput.players.GetPlayer(_createCustomControllerSettings.assignToPlayerId);
			if (player == null)
			{
				Logger.LogError("Invalid Player Id " + _createCustomControllerSettings.assignToPlayerId + ". Cannot assign Custom Controller to Player.");
			}
			else
			{
				player.controllers.AddController(P_0, removeFromOtherPlayers: true);
			}
		}

		private void vfnddZQIhDJjMktzHTENYSHYETz()
		{
			if (AnVMDfYuJfbdBsHCBQCkENZGZoF >= 0 && _createCustomControllerSettings.destroyCustomController)
			{
				Rewired.CustomController customController = FWZkRMuknthenkBjRBPUsZyMEpF(false);
				if (customController != null && ReInput.isReady)
				{
					ReInput.controllers.DestroyCustomController(customController);
					AnVMDfYuJfbdBsHCBQCkENZGZoF = -1;
				}
			}
		}

		private void pHwfVcZfRoODAlBJLPEjAQeVjjDc()
		{
			if (OzIXwsUkOqbKUhMpEKRhEetjcIdH != null)
			{
				OzIXwsUkOqbKUhMpEKRhEetjcIdH();
			}
			zRufekZVEKHvUZzuADmZaHypjsO();
		}
	}
}
