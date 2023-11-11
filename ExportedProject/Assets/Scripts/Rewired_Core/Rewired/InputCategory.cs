using System;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	public class InputCategory
	{
		[SerializeField]
		[CustomObfuscation(rename = false)]
		protected string _name;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		protected string _descriptiveName;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		protected string _tag;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		protected int _id;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		protected bool _userAssignable;

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

		public bool userAssignable
		{
			get
			{
				return _userAssignable;
			}
			internal set
			{
				_userAssignable = value;
			}
		}

		public InputCategory()
		{
		}

		public InputCategory(InputCategory source)
		{
			_name = source._name;
			_descriptiveName = source._descriptiveName;
			_tag = source._tag;
			_id = source._id;
			_userAssignable = source._userAssignable;
		}
	}
}
