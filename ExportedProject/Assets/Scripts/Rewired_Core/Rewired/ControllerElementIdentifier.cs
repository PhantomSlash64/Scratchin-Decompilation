using System;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	public sealed class ControllerElementIdentifier : IControllerElementIdentifierCommon_Internal
	{
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private int _id;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private string _name;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private string _positiveName;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private string _negativeName;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private ControllerElementType _elementType;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private CompoundControllerElementType _compoundElementType;

		internal readonly bool isMappableOnPlatform;

		private bool AcAYEzUyZtGgBEKRyDcTHFnyDoG;

		private static ControllerElementIdentifier IKuLYabGtsfIrCzaJcuDXnqrhaYQ;

		public int id => _id;

		public string name
		{
			get
			{
				return _name;
			}
			internal set
			{
				wcTfmLxRtMsTCvsSVmrjPqkHprq();
				_name = value;
			}
		}

		public string positiveName
		{
			get
			{
				return _positiveName;
			}
			internal set
			{
				wcTfmLxRtMsTCvsSVmrjPqkHprq();
				_positiveName = value;
			}
		}

		public string negativeName
		{
			get
			{
				return _negativeName;
			}
			internal set
			{
				wcTfmLxRtMsTCvsSVmrjPqkHprq();
				_negativeName = value;
			}
		}

		public ControllerElementType elementType => _elementType;

		public CompoundControllerElementType compoundElementType => _compoundElementType;

		internal bool isCompoundElement => _elementType == ControllerElementType.CompoundElement;

		object IControllerElementIdentifierCommon_Internal.elementType => _elementType;

		bool IControllerElementIdentifierCommon_Internal.useEditorElementTypeOverride => false;

		ControllerElementType IControllerElementIdentifierCommon_Internal.editorElementTypeOverride => _elementType;

		internal static ControllerElementIdentifier BlankReadOnly
		{
			get
			{
				if (IKuLYabGtsfIrCzaJcuDXnqrhaYQ == null)
				{
					ControllerElementIdentifier controllerElementIdentifier = new ControllerElementIdentifier();
					controllerElementIdentifier._id = -1;
					controllerElementIdentifier.AcAYEzUyZtGgBEKRyDcTHFnyDoG = true;
					return IKuLYabGtsfIrCzaJcuDXnqrhaYQ = controllerElementIdentifier;
				}
				return IKuLYabGtsfIrCzaJcuDXnqrhaYQ;
			}
		}

		public ControllerElementIdentifier()
		{
		}

		public ControllerElementIdentifier(ControllerElementIdentifier source)
		{
			isMappableOnPlatform = source.isMappableOnPlatform;
			_id = source._id;
			_name = source._name;
			_positiveName = source._positiveName;
			_negativeName = source._negativeName;
			_elementType = source._elementType;
			_compoundElementType = source._compoundElementType;
		}

		internal ControllerElementIdentifier(int id, string name, string positiveName, string negativeName, ControllerElementType elementType, CompoundControllerElementType compoundElementType, bool isMappableOnPlatform)
		{
			_id = id;
			_name = name;
			_positiveName = positiveName;
			_negativeName = negativeName;
			_elementType = elementType;
			_compoundElementType = compoundElementType;
			this.isMappableOnPlatform = isMappableOnPlatform;
		}

		internal ControllerElementIdentifier(int id, string name, string positiveName, string negativeName, ControllerElementType elementType, bool isMappableOnPlatform)
		{
			_id = id;
			_name = name;
			_positiveName = positiveName;
			_negativeName = negativeName;
			_elementType = elementType;
			_compoundElementType = CompoundControllerElementType.Axis2D;
			this.isMappableOnPlatform = isMappableOnPlatform;
		}

		internal ControllerElementIdentifier(ControllerElementIdentifier source, bool isMappableOnPlatform, ControllerElementType changedElementType)
			: this(source)
		{
			_elementType = changedElementType;
			this.isMappableOnPlatform = isMappableOnPlatform;
		}

		public ControllerElementIdentifier Clone()
		{
			return new ControllerElementIdentifier(this);
		}

		public string GetDisplayName(ControllerElementType actualElementType, AxisRange axisRange)
		{
			switch (actualElementType)
			{
			case ControllerElementType.Axis:
				switch (axisRange)
				{
				case AxisRange.Full:
					return name;
				case AxisRange.Positive:
					if (string.IsNullOrEmpty(positiveName))
					{
						return name + " +";
					}
					return positiveName;
				case AxisRange.Negative:
					if (string.IsNullOrEmpty(negativeName))
					{
						return name + " -";
					}
					return negativeName;
				default:
					throw new NotImplementedException();
				}
			case ControllerElementType.Button:
				return name;
			case ControllerElementType.CompoundElement:
				return name;
			default:
				throw new NotImplementedException();
			}
		}

		public string GetDisplayName(AxisRange axisRange)
		{
			return GetDisplayName(_elementType, axisRange);
		}

		private void wcTfmLxRtMsTCvsSVmrjPqkHprq()
		{
			if (AcAYEzUyZtGgBEKRyDcTHFnyDoG)
			{
				throw new Exception("The object is marked readonly and you are trying to modify its values.");
			}
		}
	}
}
