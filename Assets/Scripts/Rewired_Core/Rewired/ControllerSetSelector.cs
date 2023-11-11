using System;
using System.Text;
using Rewired.Utils;
using Rewired.Utils.Attributes;
using Rewired.Utils.Interfaces;
using Rewired.Utils.Libraries.TinyJson;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	[Preserve]
	public sealed class ControllerSetSelector : ISerializationCallbackReceiver, IDeepCloneable
	{
		public enum Type
		{
			All = 0,
			ControllerType = 1,
			HardwareType = 2,
			ControllerTemplateType = 3,
			PersistentControllerInstance = 4,
			SessionControllerInstance = 5
		}

		[Serialize(Name = "type")]
		[SerializeField]
		private Type _type;

		[Serialize(Name = "controllerType")]
		[SerializeField]
		private ControllerType _controllerType;

		[SerializeField]
		[Serialize(Name = "guid")]
		private string _guid;

		[SerializeField]
		[Serialize(Name = "hardwareIdentifier")]
		private string _hardwareIdentifier;

		[Serialize(Name = "controllerId")]
		[SerializeField]
		private int _controllerId;

		[NonSerialized]
		private Guid bodLcOEhQspJVWyXkcOCSOZtgpx;

		internal bool hasControllerType => _type != Type.All;

		public Type type
		{
			get
			{
				return _type;
			}
			set
			{
				if (value != _type)
				{
					qQBUetxmBGbiwjdkWNJyOHzntzd();
				}
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
				if (_type != Type.HardwareType)
				{
					return Guid.Empty;
				}
				return bodLcOEhQspJVWyXkcOCSOZtgpx;
			}
			set
			{
				if (_type != Type.ControllerTemplateType)
				{
					Logger.LogWarning(string.Concat("hardwareTypeGuid can only be set when type is ", Type.HardwareType, "."), requiredThreadSafety: true);
					return;
				}
				bodLcOEhQspJVWyXkcOCSOZtgpx = value;
				_guid = value.ToString();
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
				if (_type != Type.ControllerTemplateType)
				{
					return Guid.Empty;
				}
				return bodLcOEhQspJVWyXkcOCSOZtgpx;
			}
			set
			{
				if (_type != Type.ControllerTemplateType)
				{
					Logger.LogWarning(string.Concat("controllerTemplateTypeGuid can only be set when type is ", Type.ControllerTemplateType, "."), requiredThreadSafety: true);
					return;
				}
				bodLcOEhQspJVWyXkcOCSOZtgpx = value;
				_guid = value.ToString();
			}
		}

		public Guid deviceInstanceGuid
		{
			get
			{
				if (_type != Type.PersistentControllerInstance)
				{
					return Guid.Empty;
				}
				return bodLcOEhQspJVWyXkcOCSOZtgpx;
			}
			set
			{
				if (_type != Type.PersistentControllerInstance)
				{
					Logger.LogWarning(string.Concat("deviceInstanceGuid can only be set when type is ", Type.PersistentControllerInstance, "."), requiredThreadSafety: true);
					return;
				}
				bodLcOEhQspJVWyXkcOCSOZtgpx = value;
				_guid = value.ToString();
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

		internal ControllerSetSelector(Type type)
			: this()
		{
			_type = type;
		}

		public ControllerSetSelector()
		{
			_controllerId = -1;
		}

		public ControllerSetSelector(ControllerSetSelector source)
		{
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			_type = source._type;
			_controllerType = source._controllerType;
			_guid = source._guid;
			_hardwareIdentifier = source._hardwareIdentifier;
			_controllerId = source._controllerId;
			bodLcOEhQspJVWyXkcOCSOZtgpx = source.bodLcOEhQspJVWyXkcOCSOZtgpx;
		}

		internal ControllerSetSelector(Type type, ControllerType controllerType, string guid, string hardwareIdentifier, int controllerId)
		{
			_type = type;
			_controllerType = controllerType;
			_guid = guid;
			bodLcOEhQspJVWyXkcOCSOZtgpx = StringTools.ToGuid(guid);
			_hardwareIdentifier = hardwareIdentifier;
			_controllerId = controllerId;
		}

		public bool Matches(Controller controller)
		{
			if (controller == null)
			{
				return false;
			}
			if (_type != 0 && _controllerType != controller.type)
			{
				return false;
			}
			switch (_type)
			{
			case Type.All:
			case Type.ControllerType:
				return true;
			case Type.HardwareType:
				if (bodLcOEhQspJVWyXkcOCSOZtgpx != Guid.Empty)
				{
					return bodLcOEhQspJVWyXkcOCSOZtgpx == controller.hardwareTypeGuid;
				}
				if (string.IsNullOrEmpty(_hardwareIdentifier))
				{
					return true;
				}
				return string.Equals(_hardwareIdentifier, controller.hardwareIdentifier, StringComparison.Ordinal);
			case Type.ControllerTemplateType:
				return controller.ImplementsTemplate(bodLcOEhQspJVWyXkcOCSOZtgpx);
			case Type.PersistentControllerInstance:
				return controller.deviceInstanceGuid == bodLcOEhQspJVWyXkcOCSOZtgpx;
			case Type.SessionControllerInstance:
				return controller.id == _controllerId;
			default:
				throw new NotImplementedException();
			}
		}

		public override string ToString()
		{
			StringBuilder stringBuilder = new StringBuilder();
			StringTools.WriteVar(stringBuilder, "Type", _type.ToString());
			StringTools.WriteVar(stringBuilder, "Controller Type", _controllerType.ToString());
			StringTools.WriteVar(stringBuilder, "Guid", _guid.ToString());
			StringTools.WriteVar(stringBuilder, "Hardware Identifier", _hardwareIdentifier.ToString());
			StringTools.WriteVar(stringBuilder, "Controller Id", _controllerId.ToString());
			return stringBuilder.ToString();
		}

		private void qQBUetxmBGbiwjdkWNJyOHzntzd()
		{
			_guid = string.Empty;
			bodLcOEhQspJVWyXkcOCSOZtgpx = Guid.Empty;
		}

		void ISerializationCallbackReceiver.OnAfterDeserialize()
		{
			bodLcOEhQspJVWyXkcOCSOZtgpx = StringTools.ToGuid(_guid);
		}

		void ISerializationCallbackReceiver.OnBeforeSerialize()
		{
		}

		private object JIhhUPBycpRQjmJEwruiPMEnxVt()
		{
			return new ControllerSetSelector(this);
		}

		object IDeepCloneable.DeepClone()
		{
			//ILSpy generated this explicit interface implementation from .override directive in JIhhUPBycpRQjmJEwruiPMEnxVt
			return this.JIhhUPBycpRQjmJEwruiPMEnxVt();
		}

		public static ControllerSetSelector SelectAll()
		{
			return new ControllerSetSelector(Type.All);
		}

		public static ControllerSetSelector SelectControllerType(ControllerType controllerType)
		{
			ControllerSetSelector controllerSetSelector = new ControllerSetSelector(Type.ControllerType);
			controllerSetSelector._controllerType = controllerType;
			return controllerSetSelector;
		}

		public static ControllerSetSelector SelectHardwareType(ControllerType controllerType, Guid hardwareTypeGuid, string hardwareIdentifier)
		{
			ControllerSetSelector controllerSetSelector = new ControllerSetSelector(Type.HardwareType);
			controllerSetSelector._controllerType = controllerType;
			controllerSetSelector.hardwareTypeGuid = hardwareTypeGuid;
			controllerSetSelector._hardwareIdentifier = hardwareIdentifier;
			return controllerSetSelector;
		}

		public static ControllerSetSelector SelectHardwareType(Controller controller)
		{
			if (controller == null)
			{
				throw new ArgumentNullException("controller");
			}
			return SelectHardwareType(controller.type, controller.hardwareTypeGuid, controller.hardwareIdentifier);
		}

		public static ControllerSetSelector SelectControllerTemplateType(ControllerType controllerType, Guid controllerTemplateTypeGuid)
		{
			ControllerSetSelector controllerSetSelector = new ControllerSetSelector(Type.ControllerTemplateType);
			controllerSetSelector._controllerType = controllerType;
			controllerSetSelector.controllerTemplateTypeGuid = controllerTemplateTypeGuid;
			return controllerSetSelector;
		}

		public static ControllerSetSelector SelectControllerTemplateType(IControllerTemplate controllerTemplate)
		{
			if (controllerTemplate == null)
			{
				throw new ArgumentNullException("controllerTemplate");
			}
			return SelectControllerTemplateType(controllerTemplate.controller.type, controllerTemplate.typeGuid);
		}

		public static ControllerSetSelector SelectPersistentControllerInstance(ControllerType controllerType, Guid deviceInstanceGuid)
		{
			ControllerSetSelector controllerSetSelector = new ControllerSetSelector(Type.PersistentControllerInstance);
			controllerSetSelector._controllerType = controllerType;
			controllerSetSelector.deviceInstanceGuid = deviceInstanceGuid;
			return controllerSetSelector;
		}

		public static ControllerSetSelector SelectPersistentControllerInstance(Controller controller)
		{
			if (controller == null)
			{
				throw new ArgumentNullException("controller");
			}
			return SelectPersistentControllerInstance(controller.type, controller.deviceInstanceGuid);
		}

		public static ControllerSetSelector SelectSessionControllerInstance(ControllerType controllerType, int controllerId)
		{
			ControllerSetSelector controllerSetSelector = new ControllerSetSelector(Type.SessionControllerInstance);
			controllerSetSelector._controllerType = controllerType;
			controllerSetSelector._controllerId = controllerId;
			return controllerSetSelector;
		}

		public static ControllerSetSelector SelectSessionControllerInstance(Controller controller)
		{
			if (controller == null)
			{
				throw new ArgumentNullException("controller");
			}
			return SelectSessionControllerInstance(controller.type, controller.id);
		}
	}
}
