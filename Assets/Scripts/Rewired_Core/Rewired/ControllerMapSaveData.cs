using System;

namespace Rewired
{
	public abstract class ControllerMapSaveData
	{
		protected Controller _controller;

		protected ControllerMap _map;

		internal readonly int PivQvdYMhUssuLwaglJVqkqXMSH;

		public ControllerMap map
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return _map;
			}
		}

		public int categoryId
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return -1;
				}
				return _map.categoryId;
			}
		}

		public int layoutId
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return -1;
				}
				return _map.layoutId;
			}
		}

		public Type mapType
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return _map.GetType();
			}
		}

		public string mapTypeString
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return string.Empty;
				}
				return _controller.mapTypeString;
			}
		}

		public Controller controller
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return _controller;
			}
		}

		public ControllerType controllerType
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return ControllerType.Keyboard;
				}
				return _controller.type;
			}
		}

		public string controllerHardwareIdentifier
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return string.Empty;
				}
				return _controller.hardwareIdentifier;
			}
		}

		public T GetMap<T>() where T : ControllerMap
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			return _map as T;
		}

		internal ControllerMapSaveData(Controller controller, ControllerMap map)
		{
			_controller = controller;
			_map = map;
			PivQvdYMhUssuLwaglJVqkqXMSH = ReInput.id;
		}

		internal static T aWlEKFrTmxgBGgRqJDXRHeKwHYg<T>(Controller P_0, ControllerMap P_1) where T : ControllerMapSaveData
		{
			return (T)aWlEKFrTmxgBGgRqJDXRHeKwHYg(P_0, P_1);
		}

		internal static ControllerMapSaveData aWlEKFrTmxgBGgRqJDXRHeKwHYg(Controller P_0, ControllerMap P_1)
		{
			return P_0.type switch
			{
				ControllerType.Joystick => new JoystickMapSaveData((Joystick)P_0, (JoystickMap)P_1), 
				ControllerType.Keyboard => new KeyboardMapSaveData((Keyboard)P_0, (KeyboardMap)P_1), 
				ControllerType.Mouse => new MouseMapSaveData((Mouse)P_0, (MouseMap)P_1), 
				ControllerType.Custom => new CustomControllerMapSaveData((CustomController)P_0, (CustomControllerMap)P_1), 
				_ => throw new ArgumentNullException(), 
			};
		}
	}
}
