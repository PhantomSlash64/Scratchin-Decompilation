using System;
using Rewired.Utils;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired.Data
{
	[Serializable]
	[Preserve]
	public sealed class ControllerSetSelector_Editor : IDeepCloneable
	{
		[SerializeField]
		[Serialize]
		private ControllerSetSelector.Type _type;

		[SerializeField]
		[Serialize]
		private ControllerType _controllerType;

		[SerializeField]
		[Serialize]
		private string _hardwareTypeGuidString;

		[SerializeField]
		[Serialize]
		private string _hardwareIdentifier;

		[SerializeField]
		[Serialize]
		private string _controllerTemplateTypeGuidString;

		[Serialize]
		[SerializeField]
		private string _deviceInstanceGuidString;

		[SerializeField]
		[Serialize]
		private int _customControllerSourceId;

		[SerializeField]
		[Serialize]
		private int _controllerId;

		public ControllerSetSelector.Type type
		{
			get
			{
				return _type;
			}
			set
			{
				_type = value;
			}
		}

		public ControllerType controllerType
		{
			get
			{
				return _controllerType;
			}
			set
			{
				_controllerType = value;
			}
		}

		public Guid hardwareTypeGuid
		{
			get
			{
				return StringTools.ToGuid(_hardwareTypeGuidString);
			}
			set
			{
				_hardwareTypeGuidString = value.ToString();
			}
		}

		public string hardwareTypeGuidString
		{
			get
			{
				return _hardwareTypeGuidString;
			}
			set
			{
				_hardwareTypeGuidString = value;
			}
		}

		public string hardwareIdentifier
		{
			get
			{
				return _hardwareIdentifier;
			}
			set
			{
				_hardwareIdentifier = value;
			}
		}

		public Guid controllerTemplateTypeGuid
		{
			get
			{
				return StringTools.ToGuid(_controllerTemplateTypeGuidString);
			}
			set
			{
				_controllerTemplateTypeGuidString = value.ToString();
			}
		}

		public string controllerTemplateTypeGuidString
		{
			get
			{
				return _controllerTemplateTypeGuidString;
			}
			set
			{
				_controllerTemplateTypeGuidString = value;
			}
		}

		public Guid deviceInstanceGuid
		{
			get
			{
				return StringTools.ToGuid(_deviceInstanceGuidString);
			}
			set
			{
				_deviceInstanceGuidString = value.ToString();
			}
		}

		public string deviceInstanceGuidString
		{
			get
			{
				return _deviceInstanceGuidString;
			}
			set
			{
				_deviceInstanceGuidString = value;
			}
		}

		public int controllerId
		{
			get
			{
				return _controllerId;
			}
			set
			{
				_controllerId = value;
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

		internal ControllerSetSelector_Editor(ControllerSetSelector.Type type)
			: this()
		{
			_type = type;
		}

		public ControllerSetSelector_Editor()
		{
			_controllerId = -1;
			_customControllerSourceId = -1;
			Guid empty = Guid.Empty;
			_hardwareTypeGuidString = empty.ToString();
		}

		public ControllerSetSelector_Editor(ControllerSetSelector_Editor source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			_type = source._type;
			_controllerType = source._controllerType;
			_hardwareTypeGuidString = source._hardwareTypeGuidString;
			_controllerTemplateTypeGuidString = source._controllerTemplateTypeGuidString;
			_deviceInstanceGuidString = source._deviceInstanceGuidString;
			_hardwareIdentifier = source._hardwareIdentifier;
			_customControllerSourceId = source._customControllerSourceId;
			_controllerId = source._controllerId;
		}

		internal ControllerSetSelector NpmCVpDFglazbcoTJNipRMZzkDr()
		{
			string guid = string.Empty;
			if (_type != 0 && _controllerType == ControllerType.Custom)
			{
				CustomController_Editor customControllerById = ReInput.UserData.GetCustomControllerById(_controllerId);
				if (customControllerById != null)
				{
					guid = customControllerById.typeGuidString;
				}
			}
			else
			{
				switch (_type)
				{
				case ControllerSetSelector.Type.ControllerTemplateType:
					guid = _controllerTemplateTypeGuidString;
					break;
				case ControllerSetSelector.Type.HardwareType:
					guid = _hardwareTypeGuidString;
					break;
				case ControllerSetSelector.Type.PersistentControllerInstance:
					guid = _deviceInstanceGuidString;
					break;
				default:
					throw new NotImplementedException();
				case ControllerSetSelector.Type.All:
				case ControllerSetSelector.Type.ControllerType:
				case ControllerSetSelector.Type.SessionControllerInstance:
					break;
				}
			}
			return new ControllerSetSelector(_type, _controllerType, guid, _hardwareIdentifier, _controllerId);
		}

		private object JIhhUPBycpRQjmJEwruiPMEnxVt()
		{
			return new ControllerSetSelector_Editor(this);
		}

		object IDeepCloneable.DeepClone()
		{
			//ILSpy generated this explicit interface implementation from .override directive in JIhhUPBycpRQjmJEwruiPMEnxVt
			return this.JIhhUPBycpRQjmJEwruiPMEnxVt();
		}
	}
}
