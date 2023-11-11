using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired.Utils;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	public sealed class InputMapCategory : InputCategory
	{
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private bool _checkConflictsWithAllCategories;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private List<int> _checkConflictsCategoryIds;

		private ReadOnlyCollection<int> _checkConflictsCategoryIds_readOnly;

		public bool checkConflictsWithAllCategories
		{
			get
			{
				return _checkConflictsWithAllCategories;
			}
			internal set
			{
				_checkConflictsWithAllCategories = value;
			}
		}

		public IList<int> checkConflictsCategoryIds => _checkConflictsCategoryIds_readOnly;

		internal List<int> checkConflictsCategoryIds_orig => _checkConflictsCategoryIds;

		public InputMapCategory()
		{
			_checkConflictsCategoryIds = new List<int>();
		}

		public InputMapCategory(InputMapCategory source)
			: base(source)
		{
			_checkConflictsWithAllCategories = source._checkConflictsWithAllCategories;
			_checkConflictsCategoryIds = ListTools.ShallowCopy(source._checkConflictsCategoryIds);
		}

		internal void ijQPrfbohIDtyfCSvLMVhrlmSpB()
		{
			if (_checkConflictsCategoryIds != null)
			{
				_checkConflictsCategoryIds_readOnly = new ReadOnlyCollection<int>(_checkConflictsCategoryIds);
			}
		}
	}
}
