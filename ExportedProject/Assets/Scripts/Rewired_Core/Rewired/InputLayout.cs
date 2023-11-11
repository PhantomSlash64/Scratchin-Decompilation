using System;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	public sealed class InputLayout
	{
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private string _name;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private string _descriptiveName;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private int _id;

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

		public InputLayout()
		{
		}

		public InputLayout(InputLayout source)
		{
			_name = source._name;
			_descriptiveName = source._descriptiveName;
			_id = source._id;
		}

		public InputLayout Clone()
		{
			return new InputLayout(this);
		}
	}
}
