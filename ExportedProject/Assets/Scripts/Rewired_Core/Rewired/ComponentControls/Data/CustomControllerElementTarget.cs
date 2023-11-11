using System;
using UnityEngine;

namespace Rewired.ComponentControls.Data
{
	[Serializable]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	public class CustomControllerElementTarget
	{
		[CustomObfuscation(rename = false)]
		internal enum ValueRange
		{
			[CustomObfuscation(rename = false)]
			Full = 0,
			[CustomObfuscation(rename = false)]
			Positive = 1,
			[CustomObfuscation(rename = false)]
			Negative = 2
		}

		[SerializeField]
		[Tooltip("The Custom Controller element.")]
		[CustomObfuscation(rename = false)]
		private CustomControllerElementSelector _element = new CustomControllerElementSelector
		{
			elementType = CustomControllerElementSelector.ElementType.Axis
		};

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private ValueRange _valueRange;

		[Tooltip("Should the final value be positive or negative?")]
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private Pole _valueContribution;

		[CustomObfuscation(rename = false)]
		[Tooltip("Should the final value be inverted?")]
		[SerializeField]
		private bool _invert;

		public CustomControllerElementSelector element => _element;

		public Pole valueContribution
		{
			get
			{
				return _valueContribution;
			}
			set
			{
				_valueContribution = value;
			}
		}

		internal ValueRange valueRange
		{
			get
			{
				return _valueRange;
			}
			set
			{
				_valueRange = value;
			}
		}

		public bool invert
		{
			get
			{
				return _invert;
			}
			set
			{
				_invert = value;
			}
		}

		internal CustomControllerElementTarget()
		{
		}

		internal CustomControllerElementTarget(CustomControllerElementSelector selector)
		{
			_element = selector;
		}

		internal void ClearElementCaches()
		{
			if (_element != null)
			{
				_element.ClearCache();
			}
		}
	}
}
