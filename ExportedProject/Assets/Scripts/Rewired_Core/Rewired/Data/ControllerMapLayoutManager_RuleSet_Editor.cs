using System;
using System.Collections.Generic;
using Rewired.Utils;
using Rewired.Utils.Attributes;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[CustomClassObfuscation(renamePrivateMembers = false, renamePubIntMembers = false)]
	[Preserve]
	public sealed class ControllerMapLayoutManager_RuleSet_Editor
	{
		[SerializeField]
		[Serialize]
		private int _id;

		[Serialize]
		[SerializeField]
		private string _name;

		[SerializeField]
		[Serialize]
		private string _tag;

		[Serialize]
		[SerializeField]
		private List<ControllerMapLayoutManager_Rule_Editor> _rules;

		public int id
		{
			get
			{
				return _id;
			}
			set
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
			set
			{
				_name = value;
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

		public List<ControllerMapLayoutManager_Rule_Editor> rules
		{
			get
			{
				return _rules;
			}
			set
			{
				_rules = value;
			}
		}

		public ControllerMapLayoutManager_RuleSet_Editor()
		{
			_rules = new List<ControllerMapLayoutManager_Rule_Editor>();
		}

		public ControllerMapLayoutManager_RuleSet_Editor(ControllerMapLayoutManager_RuleSet_Editor source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			_id = source._id;
			_name = source._name;
			_tag = source._tag;
			_rules = MiscTools.DeepClone(source._rules);
		}

		internal ControllerMapLayoutManager_RuleSet_Editor Clone()
		{
			return new ControllerMapLayoutManager_RuleSet_Editor(this);
		}

		internal ControllerMapLayoutManager.RuleSet ToRuntime()
		{
			List<ControllerMapLayoutManager.Rule> list = new List<ControllerMapLayoutManager.Rule>();
			if (_rules != null)
			{
				for (int i = 0; i < _rules.Count; i++)
				{
					if (_rules[i] != null)
					{
						list.Add(_rules[i].ToRuntime());
					}
				}
			}
			return new ControllerMapLayoutManager.RuleSet(enabled: true, _tag, list);
		}
	}
}
