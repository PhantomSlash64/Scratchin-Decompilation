using System;
using System.Collections.Generic;
using System.ComponentModel;
using Rewired.Utils;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public sealed class Player_Editor
	{
		[Serializable]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public sealed class Mapping
		{
			[CustomObfuscation(rename = false)]
			[SerializeField]
			private bool _enabled;

			[SerializeField]
			[CustomObfuscation(rename = false)]
			private int _categoryId;

			[CustomObfuscation(rename = false)]
			[SerializeField]
			private int _layoutId;

			public int categoryId
			{
				get
				{
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
					return _layoutId;
				}
				internal set
				{
					_layoutId = value;
				}
			}

			public bool enabled
			{
				get
				{
					return _enabled;
				}
				internal set
				{
					_enabled = value;
				}
			}

			public Mapping()
			{
				Clear();
			}

			public Mapping(bool enabled, int categoryId, int layoutId)
			{
				_enabled = enabled;
				_categoryId = categoryId;
				_layoutId = layoutId;
			}

			public void Clear()
			{
				_categoryId = 0;
				_layoutId = 0;
				_enabled = true;
			}

			public Mapping Clone()
			{
				return new Mapping(_enabled, _categoryId, _layoutId);
			}

			internal dCUflXNeHsiDyiuKKNnJFvASoHlm uwEdNXBvCcoCDLGHhpruDHgmOVy()
			{
				return new dCUflXNeHsiDyiuKKNnJFvASoHlm(_categoryId, _layoutId, _enabled);
			}
		}

		[Serializable]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public sealed class ControllerMapLayoutManagerSettings : IDeepCloneable
		{
			[SerializeField]
			[CustomObfuscation(rename = false)]
			private bool _enabled = true;

			[CustomObfuscation(rename = false)]
			[SerializeField]
			private bool _loadFromUserDataStore = true;

			[CustomObfuscation(rename = false)]
			[SerializeField]
			private List<RuleSetMapping> _ruleSets;

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

			public bool loadFromUserDataStore
			{
				get
				{
					return _loadFromUserDataStore;
				}
				set
				{
					_loadFromUserDataStore = value;
				}
			}

			public List<RuleSetMapping> ruleSets
			{
				get
				{
					return _ruleSets;
				}
				set
				{
					_ruleSets = value ?? (_ruleSets = new List<RuleSetMapping>());
				}
			}

			public ControllerMapLayoutManagerSettings()
			{
				_ruleSets = new List<RuleSetMapping>();
				_enabled = true;
				_loadFromUserDataStore = true;
			}

			public ControllerMapLayoutManagerSettings(ControllerMapLayoutManagerSettings source)
			{
				if (source == null)
				{
					throw new ArgumentNullException("source");
				}
				_enabled = source._enabled;
				_loadFromUserDataStore = source._loadFromUserDataStore;
				_ruleSets = MiscTools.DeepClone(source._ruleSets) ?? new List<RuleSetMapping>();
			}

			internal ControllerMapLayoutManager.lRHvetoYBHZvdHTlYVwfdpCPcAs pRKrGlOxYBVuYhJzdFUPxUehMOi()
			{
				return new ControllerMapLayoutManager.lRHvetoYBHZvdHTlYVwfdpCPcAs(_enabled, _loadFromUserDataStore, aGXcWwYyFqhunPXVgeEWtIexHKW());
			}

			private oVnMIJhZctoXaxkUiKzmKEMXgYv[] aGXcWwYyFqhunPXVgeEWtIexHKW()
			{
				List<oVnMIJhZctoXaxkUiKzmKEMXgYv> list = new List<oVnMIJhZctoXaxkUiKzmKEMXgYv>();
				int num = ((_ruleSets != null) ? _ruleSets.Count : 0);
				for (int i = 0; i < num; i++)
				{
					if (_ruleSets[i] != null)
					{
						list.Add(_ruleSets[i].HVSGDJdnSeeCOyiRYFdjwatfIORD());
					}
				}
				return list.ToArray();
			}

			private object JIhhUPBycpRQjmJEwruiPMEnxVt()
			{
				return new ControllerMapLayoutManagerSettings(this);
			}

			object IDeepCloneable.DeepClone()
			{
				//ILSpy generated this explicit interface implementation from .override directive in JIhhUPBycpRQjmJEwruiPMEnxVt
				return this.JIhhUPBycpRQjmJEwruiPMEnxVt();
			}
		}

		[Serializable]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public sealed class ControllerMapEnablerSettings : IDeepCloneable
		{
			[SerializeField]
			[CustomObfuscation(rename = false)]
			private bool _enabled = true;

			[CustomObfuscation(rename = false)]
			[SerializeField]
			private List<RuleSetMapping> _ruleSets;

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

			public List<RuleSetMapping> ruleSets
			{
				get
				{
					return _ruleSets;
				}
				set
				{
					_ruleSets = value ?? (_ruleSets = new List<RuleSetMapping>());
				}
			}

			public ControllerMapEnablerSettings()
			{
				_ruleSets = new List<RuleSetMapping>();
				_enabled = true;
			}

			public ControllerMapEnablerSettings(ControllerMapEnablerSettings source)
			{
				if (source == null)
				{
					throw new ArgumentNullException("source");
				}
				_enabled = source._enabled;
				_ruleSets = MiscTools.DeepClone(source._ruleSets) ?? new List<RuleSetMapping>();
			}

			internal ControllerMapEnabler.xIhBRlVXbtrPkJZqdoJCRHAyPSc pRKrGlOxYBVuYhJzdFUPxUehMOi()
			{
				return new ControllerMapEnabler.xIhBRlVXbtrPkJZqdoJCRHAyPSc(_enabled, aGXcWwYyFqhunPXVgeEWtIexHKW());
			}

			private oVnMIJhZctoXaxkUiKzmKEMXgYv[] aGXcWwYyFqhunPXVgeEWtIexHKW()
			{
				List<oVnMIJhZctoXaxkUiKzmKEMXgYv> list = new List<oVnMIJhZctoXaxkUiKzmKEMXgYv>();
				int num = ((_ruleSets != null) ? _ruleSets.Count : 0);
				for (int i = 0; i < num; i++)
				{
					if (_ruleSets[i] != null)
					{
						list.Add(_ruleSets[i].HVSGDJdnSeeCOyiRYFdjwatfIORD());
					}
				}
				return list.ToArray();
			}

			private object JIhhUPBycpRQjmJEwruiPMEnxVt()
			{
				return new ControllerMapEnablerSettings(this);
			}

			object IDeepCloneable.DeepClone()
			{
				//ILSpy generated this explicit interface implementation from .override directive in JIhhUPBycpRQjmJEwruiPMEnxVt
				return this.JIhhUPBycpRQjmJEwruiPMEnxVt();
			}
		}

		[Serializable]
		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public sealed class RuleSetMapping : IDeepCloneable
		{
			[CustomObfuscation(rename = false)]
			[SerializeField]
			private bool _enabled;

			[CustomObfuscation(rename = false)]
			[SerializeField]
			private int _id;

			public int id
			{
				get
				{
					return _id;
				}
				internal set
				{
					_id = value;
				}
			}

			public bool enabled
			{
				get
				{
					return _enabled;
				}
				internal set
				{
					_enabled = value;
				}
			}

			public RuleSetMapping()
			{
				Clear();
			}

			public RuleSetMapping(RuleSetMapping source)
				: this()
			{
				if (source == null)
				{
					throw new ArgumentNullException("source");
				}
				_enabled = source._enabled;
				_id = source._id;
			}

			public RuleSetMapping(bool enabled, int id)
			{
				_enabled = enabled;
				_id = id;
			}

			public void Clear()
			{
				_id = 0;
				_enabled = true;
			}

			public RuleSetMapping Clone()
			{
				return new RuleSetMapping(_enabled, _id);
			}

			internal oVnMIJhZctoXaxkUiKzmKEMXgYv HVSGDJdnSeeCOyiRYFdjwatfIORD()
			{
				return new oVnMIJhZctoXaxkUiKzmKEMXgYv(_id, _enabled);
			}

			private object JIhhUPBycpRQjmJEwruiPMEnxVt()
			{
				return new RuleSetMapping(this);
			}

			object IDeepCloneable.DeepClone()
			{
				//ILSpy generated this explicit interface implementation from .override directive in JIhhUPBycpRQjmJEwruiPMEnxVt
				return this.JIhhUPBycpRQjmJEwruiPMEnxVt();
			}
		}

		[Serializable]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public sealed class CreateControllerInfo
		{
			[CustomObfuscation(rename = false)]
			[SerializeField]
			private int _sourceId;

			[SerializeField]
			[CustomObfuscation(rename = false)]
			private string _tag;

			public int sourceId
			{
				get
				{
					return _sourceId;
				}
				internal set
				{
					_sourceId = value;
				}
			}

			public string tag
			{
				get
				{
					return _tag;
				}
				internal set
				{
					_tag = value;
				}
			}

			public CreateControllerInfo()
			{
			}

			public CreateControllerInfo(int sourceId, string tag)
			{
				_sourceId = sourceId;
				_tag = tag;
			}

			public CreateControllerInfo(CreateControllerInfo source)
			{
				_sourceId = source._sourceId;
				_tag = source._tag;
			}
		}

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private int _id;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private string _name;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private string _descriptiveName;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private bool _startPlaying;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private List<Mapping> _defaultJoystickMaps;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private List<Mapping> _defaultMouseMaps;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private List<Mapping> _defaultKeyboardMaps;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private List<Mapping> _defaultCustomControllerMaps;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private List<CreateControllerInfo> _startingCustomControllers;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private bool _assignMouseOnStart;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private bool _assignKeyboardOnStart = true;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private bool _excludeFromControllerAutoAssignment;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private ControllerMapLayoutManagerSettings _controllerMapLayoutManagerSettings;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private ControllerMapEnablerSettings _controllerMapEnablerSettings;

		public int id
		{
			get
			{
				return _id;
			}
			internal set
			{
				_id = value;
			}
		}

		public string name
		{
			get
			{
				return _name;
			}
			internal set
			{
				_name = value;
			}
		}

		public string descriptiveName
		{
			get
			{
				return _descriptiveName;
			}
			internal set
			{
				_descriptiveName = value;
			}
		}

		public bool startPlaying
		{
			get
			{
				return _startPlaying;
			}
			internal set
			{
				_startPlaying = value;
			}
		}

		public List<Mapping> defaultJoystickMaps
		{
			get
			{
				return _defaultJoystickMaps;
			}
			internal set
			{
				_defaultJoystickMaps = value;
			}
		}

		public List<Mapping> defaultMouseMaps
		{
			get
			{
				return _defaultMouseMaps;
			}
			internal set
			{
				_defaultMouseMaps = value;
			}
		}

		public List<Mapping> defaultKeyboardMaps
		{
			get
			{
				return _defaultKeyboardMaps;
			}
			internal set
			{
				_defaultKeyboardMaps = value;
			}
		}

		public List<Mapping> defaultCustomControllerMaps
		{
			get
			{
				return _defaultCustomControllerMaps;
			}
			internal set
			{
				_defaultCustomControllerMaps = value;
			}
		}

		public List<CreateControllerInfo> startingCustomControllers
		{
			get
			{
				return _startingCustomControllers;
			}
			internal set
			{
				_startingCustomControllers = value;
			}
		}

		public bool assignMouseOnStart
		{
			get
			{
				return _assignMouseOnStart;
			}
			internal set
			{
				_assignMouseOnStart = value;
			}
		}

		public bool assignKeyboardOnStart
		{
			get
			{
				return _assignKeyboardOnStart;
			}
			internal set
			{
				_assignKeyboardOnStart = value;
			}
		}

		public bool excludeFromControllerAutoAssignment
		{
			get
			{
				return _excludeFromControllerAutoAssignment;
			}
			internal set
			{
				_excludeFromControllerAutoAssignment = value;
			}
		}

		public ControllerMapLayoutManagerSettings controllerMapLayoutManagerSettings
		{
			get
			{
				return _controllerMapLayoutManagerSettings;
			}
			set
			{
				_controllerMapLayoutManagerSettings = value;
			}
		}

		public ControllerMapEnablerSettings controllerMapEnablerSettings
		{
			get
			{
				return _controllerMapEnablerSettings;
			}
			set
			{
				_controllerMapEnablerSettings = value;
			}
		}

		public Player_Editor()
		{
			_defaultKeyboardMaps = new List<Mapping>();
			_defaultJoystickMaps = new List<Mapping>();
			_defaultMouseMaps = new List<Mapping>();
			_defaultCustomControllerMaps = new List<Mapping>();
			_startingCustomControllers = new List<CreateControllerInfo>();
			_excludeFromControllerAutoAssignment = false;
			_controllerMapLayoutManagerSettings = new ControllerMapLayoutManagerSettings();
			_controllerMapEnablerSettings = new ControllerMapEnablerSettings();
		}

		public Player_Editor(Player_Editor source)
		{
			_id = source._id;
			_name = source._name;
			_descriptiveName = source._descriptiveName;
			_startPlaying = source._startPlaying;
			_defaultJoystickMaps = new List<Mapping>();
			if (source._defaultJoystickMaps != null)
			{
				for (int i = 0; i < source._defaultJoystickMaps.Count; i++)
				{
					_defaultJoystickMaps.Add(source._defaultJoystickMaps[i].Clone());
				}
			}
			_defaultKeyboardMaps = new List<Mapping>();
			if (source._defaultKeyboardMaps != null)
			{
				for (int j = 0; j < source._defaultKeyboardMaps.Count; j++)
				{
					_defaultKeyboardMaps.Add(source._defaultKeyboardMaps[j].Clone());
				}
			}
			_defaultMouseMaps = new List<Mapping>();
			if (source._defaultMouseMaps != null)
			{
				for (int k = 0; k < source._defaultMouseMaps.Count; k++)
				{
					_defaultMouseMaps.Add(source._defaultMouseMaps[k].Clone());
				}
			}
			_defaultCustomControllerMaps = new List<Mapping>();
			if (source._defaultCustomControllerMaps != null)
			{
				for (int l = 0; l < source._defaultCustomControllerMaps.Count; l++)
				{
					_defaultCustomControllerMaps.Add(source._defaultCustomControllerMaps[l].Clone());
				}
			}
			_startingCustomControllers = new List<CreateControllerInfo>();
			if (source._startingCustomControllers != null)
			{
				for (int m = 0; m < source._startingCustomControllers.Count; m++)
				{
					_startingCustomControllers.Add(new CreateControllerInfo(source._startingCustomControllers[m]));
				}
			}
			_controllerMapLayoutManagerSettings = MiscTools.DeepClone(source._controllerMapLayoutManagerSettings) ?? new ControllerMapLayoutManagerSettings();
			_controllerMapEnablerSettings = MiscTools.DeepClone(source._controllerMapEnablerSettings) ?? new ControllerMapEnablerSettings();
			_assignMouseOnStart = source._assignMouseOnStart;
			_assignKeyboardOnStart = source._assignKeyboardOnStart;
			_excludeFromControllerAutoAssignment = source._excludeFromControllerAutoAssignment;
		}

		public Player_Editor Clone()
		{
			return new Player_Editor(this);
		}

		internal hoGZGoKcYjvzMpyhYIdlAPtnxIh mxWhjvUZEzirQJYkqEAMYLCggjvA()
		{
			dCUflXNeHsiDyiuKKNnJFvASoHlm[] array = null;
			if (_defaultJoystickMaps != null)
			{
				array = new dCUflXNeHsiDyiuKKNnJFvASoHlm[_defaultJoystickMaps.Count];
				for (int i = 0; i < _defaultJoystickMaps.Count; i++)
				{
					array[i] = _defaultJoystickMaps[i].uwEdNXBvCcoCDLGHhpruDHgmOVy();
				}
			}
			dCUflXNeHsiDyiuKKNnJFvASoHlm[] array2 = null;
			if (_defaultKeyboardMaps != null)
			{
				array2 = new dCUflXNeHsiDyiuKKNnJFvASoHlm[_defaultKeyboardMaps.Count];
				for (int j = 0; j < _defaultKeyboardMaps.Count; j++)
				{
					array2[j] = _defaultKeyboardMaps[j].uwEdNXBvCcoCDLGHhpruDHgmOVy();
				}
			}
			dCUflXNeHsiDyiuKKNnJFvASoHlm[] array3 = null;
			if (_defaultMouseMaps != null)
			{
				array3 = new dCUflXNeHsiDyiuKKNnJFvASoHlm[_defaultMouseMaps.Count];
				for (int k = 0; k < _defaultMouseMaps.Count; k++)
				{
					array3[k] = _defaultMouseMaps[k].uwEdNXBvCcoCDLGHhpruDHgmOVy();
				}
			}
			dCUflXNeHsiDyiuKKNnJFvASoHlm[] array4 = null;
			if (_defaultCustomControllerMaps != null)
			{
				array4 = new dCUflXNeHsiDyiuKKNnJFvASoHlm[_defaultCustomControllerMaps.Count];
				for (int l = 0; l < _defaultCustomControllerMaps.Count; l++)
				{
					array4[l] = _defaultCustomControllerMaps[l].uwEdNXBvCcoCDLGHhpruDHgmOVy();
				}
			}
			return new hoGZGoKcYjvzMpyhYIdlAPtnxIh(array, array2, array3, array4);
		}
	}
}
