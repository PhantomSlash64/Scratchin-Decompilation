using System;
using System.Collections;
using System.Collections.Generic;
using Rewired.Interfaces;
using Rewired.Utils;
using Rewired.Utils.Attributes;
using Rewired.Utils.Classes.Data;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired
{
	public sealed class ControllerMapLayoutManager
	{
		internal class lRHvetoYBHZvdHTlYVwfdpCPcAs
		{
			public bool bkJZsGZyHUpGCYsHZcTTeWizaugq;

			public bool UjhTqpmeRxgBnOZzfAmXHOIDRta;

			public oVnMIJhZctoXaxkUiKzmKEMXgYv[] hFZNKOOTgpVtfdmEiScEjMrviQP;

			public lRHvetoYBHZvdHTlYVwfdpCPcAs(bool enabled, bool loadFromUserDataStore, oVnMIJhZctoXaxkUiKzmKEMXgYv[] startingRuleSets)
			{
				bkJZsGZyHUpGCYsHZcTTeWizaugq = enabled;
				UjhTqpmeRxgBnOZzfAmXHOIDRta = loadFromUserDataStore;
				hFZNKOOTgpVtfdmEiScEjMrviQP = startingRuleSets;
			}
		}

		[Serializable]
		[Preserve]
		[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
		public sealed class Rule : IDeepCloneable
		{
			[Serialize(Name = "tag")]
			[SerializeField]
			private string _tag;

			[Serialize(Name = "categoryIds")]
			[SerializeField]
			private int[] _categoryIds;

			[SerializeField]
			[Serialize(Name = "layoutId")]
			private int _layoutId;

			[Serialize(Name = "controllerSetSelector")]
			[SerializeField]
			private ControllerSetSelector _controllerSetSelector;

			[NonSerialized]
			private string[] _preInitCategoryNames;

			[NonSerialized]
			private string _preInitLayoutName;

			public string tag
			{
				get
				{
					return _tag;
				}
				set
				{
					_tag = value;
				}
			}

			public ControllerSetSelector controllerSetSelector
			{
				get
				{
					return _controllerSetSelector ?? (_controllerSetSelector = new ControllerSetSelector(ControllerSetSelector.Type.ControllerType));
				}
				set
				{
					if (value == null)
					{
						value = new ControllerSetSelector(ControllerSetSelector.Type.ControllerType);
					}
					if (!value.hasControllerType)
					{
						Logger.LogError(string.Concat(value.type, " is not allowed. Each Controller Type has its own unique Layouts and a single Layout cannot be set for all Controller Types. ControllerSelector.type has been changed to ControllerSelector.Type.ControllerType."), requiredThreadSafety: true);
						value.type = ControllerSetSelector.Type.ControllerType;
					}
					_controllerSetSelector = value;
				}
			}

			public int categoryId
			{
				get
				{
					Initialize();
					if (_categoryIds == null || _categoryIds.Length == 0)
					{
						return -1;
					}
					return categoryIds[0];
				}
				set
				{
					if (value < 0)
					{
						_categoryIds = EmptyObjects<int>.array;
					}
					else
					{
						if (_categoryIds == null || _categoryIds.Length == 0)
						{
							_categoryIds = new int[1];
						}
						_categoryIds[0] = value;
					}
					_preInitCategoryNames = null;
				}
			}

			public int[] categoryIds
			{
				get
				{
					Initialize();
					return _categoryIds ?? (_categoryIds = EmptyObjects<int>.array);
				}
				set
				{
					if (value == null)
					{
						value = EmptyObjects<int>.array;
					}
					_categoryIds = value;
					_preInitCategoryNames = null;
				}
			}

			public int layoutId
			{
				get
				{
					Initialize();
					return _layoutId;
				}
				set
				{
					if (value < 0)
					{
						value = -1;
					}
					_layoutId = value;
					_preInitLayoutName = null;
				}
			}

			public string categoryName
			{
				get
				{
					if (!ReInput.isReady)
					{
						if (_preInitCategoryNames == null || _preInitCategoryNames.Length <= 0)
						{
							return null;
						}
						return _preInitCategoryNames[0];
					}
					Initialize();
					if (_categoryIds == null || _categoryIds.Length == 0)
					{
						return null;
					}
					InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(_categoryIds[0]);
					if (mapCategory == null)
					{
						return "INVALID";
					}
					return mapCategory.name;
				}
				set
				{
					if (!ReInput.isReady)
					{
						_preInitCategoryNames = ((!string.IsNullOrEmpty(value)) ? new string[1] { value } : null);
						_categoryIds = EmptyObjects<int>.array;
						return;
					}
					if (string.IsNullOrEmpty(value))
					{
						_preInitCategoryNames = null;
						_categoryIds = EmptyObjects<int>.array;
						return;
					}
					int mapCategoryId = ReInput.mapping.GetMapCategoryId(value);
					if (mapCategoryId >= 0)
					{
						categoryId = mapCategoryId;
					}
					else
					{
						Logger.LogWarning("Map Category \"" + value + "\" does not exist.");
					}
				}
			}

			public string[] categoryNames
			{
				get
				{
					if (!ReInput.isReady)
					{
						if (_preInitCategoryNames == null)
						{
							return EmptyObjects<string>.array;
						}
						return _preInitCategoryNames;
					}
					Initialize();
					if (_categoryIds == null)
					{
						return EmptyObjects<string>.array;
					}
					string[] array = new string[_categoryIds.Length];
					for (int i = 0; i < _categoryIds.Length; i++)
					{
						InputMapCategory mapCategory = ReInput.mapping.GetMapCategory(_categoryIds[i]);
						array[i] = ((mapCategory != null) ? mapCategory.name : "INVALID");
					}
					return array;
				}
				set
				{
					if (!ReInput.isReady)
					{
						_preInitCategoryNames = ((value != null && value.Length > 0) ? value : null);
						_categoryIds = EmptyObjects<int>.array;
						return;
					}
					if (value == null || value.Length == 0)
					{
						_preInitCategoryNames = null;
						_categoryIds = EmptyObjects<int>.array;
						return;
					}
					List<int> list = new List<int>(value.Length);
					for (int i = 0; i < value.Length; i++)
					{
						if (!string.IsNullOrEmpty(value[i]))
						{
							int mapCategoryId = ReInput.mapping.GetMapCategoryId(value[i]);
							if (mapCategoryId >= 0)
							{
								list.Add(mapCategoryId);
							}
							else
							{
								Logger.LogWarning("Map Category \"" + value[i] + "\" does not exist.");
							}
						}
					}
					_categoryIds = list.ToArray();
				}
			}

			public string layoutName
			{
				get
				{
					if (!ReInput.isReady)
					{
						return _preInitLayoutName;
					}
					Initialize();
					InputLayout layout = ReInput.mapping.GetLayout(controllerSetSelector.controllerType, _layoutId);
					if (layout == null)
					{
						return "INVALID";
					}
					return layout.name;
				}
				set
				{
					if (!ReInput.isReady)
					{
						_preInitLayoutName = value;
						_layoutId = -1;
						return;
					}
					if (string.IsNullOrEmpty(value))
					{
						_preInitLayoutName = null;
						_layoutId = -1;
						return;
					}
					layoutId = ReInput.mapping.GetLayoutId(controllerSetSelector.controllerType, value);
					if (_layoutId < 0)
					{
						Logger.LogWarning(string.Concat(controllerSetSelector.controllerType, " Layout \"", value, "\" does not exist."));
					}
				}
			}

			internal bool isValid
			{
				get
				{
					if (_controllerSetSelector == null)
					{
						return false;
					}
					Initialize();
					if (_categoryIds == null || _categoryIds.Length == 0)
					{
						return false;
					}
					if (!ReInput.isReady)
					{
						if (_categoryIds[0] >= 0)
						{
							return _layoutId >= 0;
						}
						return false;
					}
					bool flag = false;
					for (int i = 0; i < _categoryIds.Length; i++)
					{
						if (ReInput.mapping.GetMapCategory(_categoryIds[i]) != null)
						{
							flag = true;
						}
					}
					if (!flag)
					{
						return false;
					}
					return ReInput.mapping.GetLayout(_controllerSetSelector.controllerType, _layoutId) != null;
				}
			}

			public Rule()
			{
				_categoryIds = EmptyObjects<int>.array;
				_layoutId = -1;
				_controllerSetSelector = new ControllerSetSelector(ControllerSetSelector.Type.ControllerType);
			}

			public Rule(Rule source)
			{
				if (source == null)
				{
					throw new ArgumentNullException("source");
				}
				_tag = source._tag;
				_categoryIds = ArrayTools.ShallowCopy(source._categoryIds);
				_layoutId = source._layoutId;
				_controllerSetSelector = MiscTools.DeepClone(source._controllerSetSelector);
				_preInitCategoryNames = ArrayTools.ShallowCopy(source._preInitCategoryNames);
				_preInitLayoutName = source._preInitLayoutName;
			}

			internal Rule(string tag, int[] categoryIds, int layoutId, ControllerSetSelector controllerSetSelector)
			{
				_tag = tag;
				_categoryIds = categoryIds;
				_layoutId = layoutId;
				_controllerSetSelector = controllerSetSelector;
			}

			private void Initialize()
			{
				if (!ReInput.isReady || _controllerSetSelector == null)
				{
					return;
				}
				if (_categoryIds == null)
				{
					_categoryIds = EmptyObjects<int>.array;
				}
				if (_preInitCategoryNames != null && _preInitCategoryNames.Length != 0)
				{
					List<int> list = new List<int>(_preInitCategoryNames.Length);
					for (int i = 0; i < _preInitCategoryNames.Length; i++)
					{
						if (!string.IsNullOrEmpty(_preInitCategoryNames[i]))
						{
							int mapCategoryId = ReInput.mapping.GetMapCategoryId(_preInitCategoryNames[i]);
							if (mapCategoryId >= 0)
							{
								list.Add(mapCategoryId);
							}
							else
							{
								Logger.LogWarning("Map Category \"" + _preInitCategoryNames[i] + "\" does not exist.");
							}
						}
					}
					_categoryIds = list.ToArray();
					_preInitCategoryNames = null;
				}
				if (!string.IsNullOrEmpty(_preInitLayoutName))
				{
					layoutName = _preInitLayoutName;
					_preInitLayoutName = null;
				}
			}

			object IDeepCloneable.DeepClone()
			{
				return new Rule(this);
			}
		}

		[Serializable]
		[SerializationType(SerializationTypeAttribute.SerializationType.Object)]
		[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
		[Preserve]
		public sealed class RuleSet : IDeepCloneable, IEnumerable, IList<Rule>, ICollection<Rule>, IEnumerable<Rule>
		{
			private const string className = "ControllerMapLayoutManager.RuleSet";

			[Serialize(Name = "enabled")]
			[SerializeField]
			private bool _enabled;

			[SerializeField]
			[Serialize(Name = "tag")]
			private string _tag;

			[SerializeField]
			[Serialize(Name = "rules")]
			private List<Rule> _rules;

			public bool enabled
			{
				get
				{
					return _enabled;
				}
				set
				{
					_enabled = value;
				}
			}

			public string tag
			{
				get
				{
					return _tag;
				}
				set
				{
					_tag = value;
				}
			}

			public List<Rule> rules
			{
				get
				{
					return _rules;
				}
				set
				{
					_rules = value;
					CheckList();
				}
			}

			public Rule this[int index]
			{
				get
				{
					CheckList();
					return _rules[index];
				}
				set
				{
					CheckList();
					_rules[index] = value;
				}
			}

			public int Count
			{
				get
				{
					CheckList();
					return _rules.Count;
				}
			}

			bool ICollection<Rule>.IsReadOnly
			{
				get
				{
					CheckList();
					return ((ICollection<Rule>)_rules).IsReadOnly;
				}
			}

			internal RuleSet(bool enabled, string tag, List<Rule> rules)
				: this()
			{
				_enabled = enabled;
				_tag = tag;
				_rules = rules;
				CheckList();
			}

			public RuleSet()
			{
				_enabled = true;
				_rules = new List<Rule>();
			}

			public RuleSet(RuleSet source)
			{
				if (source == null)
				{
					throw new ArgumentNullException("source");
				}
				_enabled = source._enabled;
				_tag = source._tag;
				_rules = MiscTools.DeepClone(source._rules);
				CheckList();
			}

			public Rule Find(Predicate<Rule> predicate)
			{
				if (predicate == null)
				{
					throw new ArgumentNullException("predicate");
				}
				int num = ((_rules != null) ? _rules.Count : 0);
				for (int i = 0; i < num; i++)
				{
					try
					{
						if (predicate(_rules[i]))
						{
							return _rules[i];
						}
					}
					catch (Exception exception)
					{
						ReInput.HandleCallbackException("ControllerMapLayoutManager.RuleSet.Find", exception);
					}
				}
				return null;
			}

			public Rule FindLast(Predicate<Rule> predicate)
			{
				if (predicate == null)
				{
					throw new ArgumentNullException("predicate");
				}
				int num = ((_rules != null) ? _rules.Count : 0);
				for (int num2 = num - 1; num2 >= 0; num2--)
				{
					try
					{
						if (predicate(_rules[num2]))
						{
							return _rules[num2];
						}
					}
					catch (Exception exception)
					{
						ReInput.HandleCallbackException("ControllerMapLayoutManager.RuleSet.FindLast", exception);
					}
				}
				return null;
			}

			public int FindIndex(Predicate<Rule> predicate)
			{
				if (predicate == null)
				{
					throw new ArgumentNullException("predicate");
				}
				int num = ((_rules != null) ? _rules.Count : 0);
				for (int i = 0; i < num; i++)
				{
					try
					{
						if (predicate(_rules[i]))
						{
							return i;
						}
					}
					catch (Exception exception)
					{
						ReInput.HandleCallbackException("ControllerMapLayoutManager.RuleSet.FindIndex", exception);
					}
				}
				return -1;
			}

			public int FindLastIndex(Predicate<Rule> predicate)
			{
				if (predicate == null)
				{
					throw new ArgumentNullException("predicate");
				}
				int num = ((_rules != null) ? _rules.Count : 0);
				for (int num2 = num - 1; num2 >= 0; num2--)
				{
					try
					{
						if (predicate(_rules[num2]))
						{
							return num2;
						}
					}
					catch (Exception exception)
					{
						ReInput.HandleCallbackException("ControllerMapLayoutManager.RuleSet.FindLastIndex", exception);
					}
				}
				return -1;
			}

			public int IndexOf(Rule item)
			{
				CheckList();
				return _rules.Count;
			}

			public void Insert(int index, Rule item)
			{
				CheckList();
				_rules.Insert(index, item);
			}

			public void RemoveAt(int index)
			{
				CheckList();
				_rules.RemoveAt(index);
			}

			public void Add(Rule item)
			{
				CheckList();
				_rules.Add(item);
			}

			public void Clear()
			{
				CheckList();
				_rules.Clear();
			}

			public bool Contains(Rule item)
			{
				CheckList();
				return _rules.Contains(item);
			}

			public void CopyTo(Rule[] array, int arrayIndex)
			{
				CheckList();
				_rules.CopyTo(array, arrayIndex);
			}

			public bool Remove(Rule item)
			{
				CheckList();
				return _rules.Remove(item);
			}

			public IEnumerator<Rule> GetEnumerator()
			{
				CheckList();
				return _rules.GetEnumerator();
			}

			IEnumerator IEnumerable.GetEnumerator()
			{
				CheckList();
				return _rules.GetEnumerator();
			}

			object IDeepCloneable.DeepClone()
			{
				return new RuleSet(this);
			}

			private void CheckList()
			{
				if (_rules == null)
				{
					_rules = new List<Rule>();
				}
			}
		}

		private bool nZTtfeZBpthDaoAvSONdTABGEaM;

		private bool bLRzHJXpBCBzKCXJVsfVpzGLqEPP = true;

		private Player OcKThfvEDnebuGNQDMZlmlOZdOGb;

		private lRHvetoYBHZvdHTlYVwfdpCPcAs MeFxFuDwgbhKJjIvfCLAJVMpiTJ;

		private readonly int PivQvdYMhUssuLwaglJVqkqXMSH;

		private List<RuleSet> XaQdNOVbrhDzpFDCaSgLNnGyqMib;

		private Action BkfVBeUsfrBlWOXFpbQwzSMmvZd;

		public bool enabled
		{
			get
			{
				return nZTtfeZBpthDaoAvSONdTABGEaM;
			}
			set
			{
				nZTtfeZBpthDaoAvSONdTABGEaM = value;
				if (value)
				{
					Apply();
				}
			}
		}

		public bool loadFromUserDataStore
		{
			get
			{
				return bLRzHJXpBCBzKCXJVsfVpzGLqEPP;
			}
			set
			{
				bLRzHJXpBCBzKCXJVsfVpzGLqEPP = value;
			}
		}

		public List<RuleSet> ruleSets
		{
			get
			{
				return XaQdNOVbrhDzpFDCaSgLNnGyqMib;
			}
			set
			{
				if (value == null)
				{
					value = new List<RuleSet>();
				}
				XaQdNOVbrhDzpFDCaSgLNnGyqMib = value;
			}
		}

		internal event Action ApplyCalledEvent
		{
			add
			{
				BkfVBeUsfrBlWOXFpbQwzSMmvZd = (Action)Delegate.Combine(BkfVBeUsfrBlWOXFpbQwzSMmvZd, value);
			}
			remove
			{
				BkfVBeUsfrBlWOXFpbQwzSMmvZd = (Action)Delegate.Remove(BkfVBeUsfrBlWOXFpbQwzSMmvZd, value);
			}
		}

		internal ControllerMapLayoutManager(Player player, lRHvetoYBHZvdHTlYVwfdpCPcAs startingSettings)
		{
			if (player == null)
			{
				throw new ArgumentNullException("player");
			}
			if (startingSettings == null)
			{
				throw new ArgumentNullException("startingSettings");
			}
			PivQvdYMhUssuLwaglJVqkqXMSH = ReInput.id;
			OcKThfvEDnebuGNQDMZlmlOZdOGb = player;
			MeFxFuDwgbhKJjIvfCLAJVMpiTJ = startingSettings;
		}

		public void Apply()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return;
			}
			BkfVBeUsfrBlWOXFpbQwzSMmvZd?.Invoke();
			if (!nZTtfeZBpthDaoAvSONdTABGEaM || XaQdNOVbrhDzpFDCaSgLNnGyqMib == null)
			{
				return;
			}
			int count = XaQdNOVbrhDzpFDCaSgLNnGyqMib.Count;
			if (count == 0)
			{
				return;
			}
			using TempListPool.TList<ControllerMap> tList = TempListPool.GetTList<ControllerMap>();
			List<ControllerMap> list = tList.list;
			using TempListPool.TList<Controller> tList2 = TempListPool.GetTList<Controller>();
			List<Controller> list2 = tList2.list;
			if (!list2.Contains(ReInput.controllers.Keyboard))
			{
				list2.Add(ReInput.controllers.Keyboard);
			}
			if (!list2.Contains(ReInput.controllers.Mouse))
			{
				list2.Add(ReInput.controllers.Mouse);
			}
			OcKThfvEDnebuGNQDMZlmlOZdOGb.controllers.maps.GetAllMaps(list);
			list2.AddRange(OcKThfvEDnebuGNQDMZlmlOZdOGb.controllers.Controllers);
			IControllerMapStore controllerMapStore = ReInput.userDataStore as IControllerMapStore;
			for (int i = 0; i < count; i++)
			{
				RuleSet ruleSet = XaQdNOVbrhDzpFDCaSgLNnGyqMib[i];
				if (ruleSet == null || !ruleSet.enabled)
				{
					continue;
				}
				int count2 = ruleSet.Count;
				for (int j = 0; j < count2; j++)
				{
					Rule rule = ruleSet[j];
					if (rule == null || !rule.isValid)
					{
						continue;
					}
					int count3 = list.Count;
					for (int num = count3 - 1; num >= 0; num--)
					{
						ControllerMap controllerMap = list[num];
						if (rule.controllerSetSelector.Matches(controllerMap.controller) && ArrayTools.Contains(rule.categoryIds, controllerMap.categoryId) && controllerMap.layoutId != rule.layoutId)
						{
							list.RemoveAt(num);
							OcKThfvEDnebuGNQDMZlmlOZdOGb.controllers.maps.RemoveMap(controllerMap.controllerType, controllerMap.controllerId, controllerMap.id);
						}
					}
					foreach (Controller controller in OcKThfvEDnebuGNQDMZlmlOZdOGb.controllers.Controllers)
					{
						if (!rule.controllerSetSelector.Matches(controller))
						{
							continue;
						}
						int[] categoryIds = rule.categoryIds;
						for (int k = 0; k < categoryIds.Length; k++)
						{
							ControllerMap controllerMap2 = OcKThfvEDnebuGNQDMZlmlOZdOGb.controllers.maps.GetMap(controller, categoryIds[k], rule.layoutId);
							if (controllerMap2 != null)
							{
								continue;
							}
							if (bLRzHJXpBCBzKCXJVsfVpzGLqEPP && controllerMapStore != null)
							{
								try
								{
									controllerMap2 = controllerMapStore.LoadControllerMap(OcKThfvEDnebuGNQDMZlmlOZdOGb.id, controller.identifier, categoryIds[k], rule.layoutId);
								}
								catch (Exception exception)
								{
									ReInput.HandleExternalInterfaceException(typeof(ControllerMapLayoutManager).Name, exception);
								}
								if (controllerMap2 != null)
								{
									OcKThfvEDnebuGNQDMZlmlOZdOGb.controllers.maps.AddMap(controller, controllerMap2);
									continue;
								}
							}
							OcKThfvEDnebuGNQDMZlmlOZdOGb.controllers.maps.LoadMap(controller.type, controller.id, categoryIds[k], rule.layoutId, startEnabled: true);
						}
					}
				}
			}
		}

		public void LoadDefaults()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return;
			}
			List<RuleSet> list = new List<RuleSet>();
			int num = ((MeFxFuDwgbhKJjIvfCLAJVMpiTJ != null && MeFxFuDwgbhKJjIvfCLAJVMpiTJ.hFZNKOOTgpVtfdmEiScEjMrviQP != null) ? MeFxFuDwgbhKJjIvfCLAJVMpiTJ.hFZNKOOTgpVtfdmEiScEjMrviQP.Length : 0);
			for (int i = 0; i < num; i++)
			{
				RuleSet controllerMapLayoutManagerRuleSetInstance = ReInput.mapping.GetControllerMapLayoutManagerRuleSetInstance(MeFxFuDwgbhKJjIvfCLAJVMpiTJ.hFZNKOOTgpVtfdmEiScEjMrviQP[i].BlZsUkOGPQDnwzRAzcAFtbBWDaNH);
				if (controllerMapLayoutManagerRuleSetInstance == null)
				{
					Logger.LogError("Invalid Layout Manager Rule Set is assigned to Player. This should not be possible. If you are seeing this error, this is a sign of serialized data corruption, usually caused by a bad source control merge.");
					continue;
				}
				controllerMapLayoutManagerRuleSetInstance.enabled = MeFxFuDwgbhKJjIvfCLAJVMpiTJ.hFZNKOOTgpVtfdmEiScEjMrviQP[i].ymsUnVrtgSJhBqqpdBJTGKspcCtS;
				list.Add(controllerMapLayoutManagerRuleSetInstance);
			}
			if (MeFxFuDwgbhKJjIvfCLAJVMpiTJ != null)
			{
				nZTtfeZBpthDaoAvSONdTABGEaM = MeFxFuDwgbhKJjIvfCLAJVMpiTJ.bkJZsGZyHUpGCYsHZcTTeWizaugq;
				bLRzHJXpBCBzKCXJVsfVpzGLqEPP = MeFxFuDwgbhKJjIvfCLAJVMpiTJ.UjhTqpmeRxgBnOZzfAmXHOIDRta;
			}
			XaQdNOVbrhDzpFDCaSgLNnGyqMib = list;
			Apply();
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

		public bool ImportXml(string xmlString)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			try
			{
				jzPtspnkZAgrKJfuKATzOhURnEB(SerializedObject.FromXml(GetType(), xmlString));
				Apply();
				return true;
			}
			catch (Exception ex)
			{
				Logger.LogError("Error importing " + GetType().Name + " data from XML. " + ex.Message);
				return false;
			}
		}

		public bool ImportJson(string jsonString)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			try
			{
				jzPtspnkZAgrKJfuKATzOhURnEB(SerializedObject.FromJson(GetType(), jsonString));
				Apply();
				return true;
			}
			catch (Exception ex)
			{
				Logger.LogError("Error importing " + GetType().Name + " data from JSON. " + ex.Message);
				return false;
			}
		}

		private SerializedObject KmsZJAaClfxbOKcqKGgeMqITFsc()
		{
			SerializedObject serializedObject = new SerializedObject(GetType(), SerializedObject.ObjectType.Object);
			tobyAseOeexEQBYeyNriFyhLxKv(serializedObject);
			return serializedObject;
		}

		private void tobyAseOeexEQBYeyNriFyhLxKv(SerializedObject P_0)
		{
			if (P_0.xmlInfo == null)
			{
				P_0.xmlInfo = new SerializedObject.XmlInfo();
			}
			P_0.Add("dataVersion", 1, SerializedObject.FieldOptions.ExculdeFromXml);
			P_0.xmlInfo.attributes.Add(new SerializedObject.XmlInfo.kwLxndskJikCtPGLslSPWsTXCTW
			{
				FaRCzmOJYwGVoyOIjhyHpMferPo = "dataVersion",
				foSRcEqSuRsWnadDiKcGnhBewOU = 1.ToString()
			});
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
				foSRcEqSuRsWnadDiKcGnhBewOU = string.Format("{0} {1}{2}{3}{4}{5}", "http://guavaman.com/rewired", "http://guavaman.com/schemas/rewired/", "1.0", "/", GetType().Name, ".xsd")
			});
			P_0.Add("enabled", nZTtfeZBpthDaoAvSONdTABGEaM);
			P_0.Add("loadFromUserDataStore", bLRzHJXpBCBzKCXJVsfVpzGLqEPP);
			P_0.Add("ruleSets", XaQdNOVbrhDzpFDCaSgLNnGyqMib);
		}

		private bool jzPtspnkZAgrKJfuKATzOhURnEB(SerializedObject P_0)
		{
			nZTtfeZBpthDaoAvSONdTABGEaM = false;
			XaQdNOVbrhDzpFDCaSgLNnGyqMib = null;
			P_0.TryGetDeserializedValueByRef("enabled", ref nZTtfeZBpthDaoAvSONdTABGEaM);
			P_0.TryGetDeserializedValueByRef("loadFromUserDataStore", ref bLRzHJXpBCBzKCXJVsfVpzGLqEPP);
			List<RuleSet> value = new List<RuleSet>();
			P_0.TryGetDeserializedValueByRef("ruleSets", ref value);
			XaQdNOVbrhDzpFDCaSgLNnGyqMib = value;
			return true;
		}
	}
}
