using System;
using Rewired.Interfaces;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	public class ControllerTemplateElementIdentifier : IControllerElementIdentifierCommon_Internal, IControllerTemplateElementIdentifier
	{
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private int _id;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private string _name;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private string _positiveName;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private string _negativeName;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private ControllerTemplateElementType _elementType;

		internal readonly bool isMappableOnPlatform;

		public int id => _id;

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

		public string positiveName
		{
			get
			{
				return _positiveName;
			}
			internal set
			{
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
				_negativeName = value;
			}
		}

		public ControllerTemplateElementType elementType => _elementType;

		internal virtual bool useEditorElementTypeOverride => false;

		internal virtual ControllerElementType editorElementTypeOverride
		{
			get
			{
				throw new NotImplementedException();
			}
		}

		object IControllerElementIdentifierCommon_Internal.elementType => _elementType;

		bool IControllerElementIdentifierCommon_Internal.useEditorElementTypeOverride => useEditorElementTypeOverride;

		ControllerElementType IControllerElementIdentifierCommon_Internal.editorElementTypeOverride => editorElementTypeOverride;

		public ControllerTemplateElementIdentifier()
		{
		}

		public ControllerTemplateElementIdentifier(ControllerTemplateElementIdentifier source)
		{
			isMappableOnPlatform = source.isMappableOnPlatform;
			_id = source._id;
			_name = source._name;
			_positiveName = source._positiveName;
			_negativeName = source._negativeName;
			_elementType = source._elementType;
		}

		internal ControllerTemplateElementIdentifier(int id, string name, string positiveName, string negativeName, ControllerTemplateElementType elementType, bool isMappableOnPlatform)
		{
			_id = id;
			_name = name;
			_positiveName = positiveName;
			_negativeName = negativeName;
			_elementType = elementType;
			this.isMappableOnPlatform = isMappableOnPlatform;
		}

		internal ControllerTemplateElementIdentifier(ControllerTemplateElementIdentifier source, ControllerTemplateElementType changedElementType, bool isMappableOnPlatform)
			: this(source)
		{
			_elementType = changedElementType;
			this.isMappableOnPlatform = isMappableOnPlatform;
		}

		public virtual ControllerTemplateElementIdentifier Clone()
		{
			return new ControllerTemplateElementIdentifier(this);
		}

		public string GetDisplayName(AxisRange axisRange)
		{
			switch (_elementType)
			{
			case ControllerTemplateElementType.Axis:
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
			case ControllerTemplateElementType.Button:
				return name;
			default:
				return name;
			}
		}

		internal ControllerElementIdentifier ToControllerElementIdentifier()
		{
			return new ControllerElementIdentifier(_id, _name, _positiveName, _negativeName, BbpfTcGSZRHmltstKOfXrucHPJO.HmyCssJgCNQXpNTOGOPizakJBWou(_elementType), CompoundControllerElementType.Axis2D, isMappableOnPlatform);
		}
	}
}
