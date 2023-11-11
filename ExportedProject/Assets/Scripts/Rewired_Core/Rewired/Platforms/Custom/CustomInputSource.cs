using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;

namespace Rewired.Platforms.Custom
{
	public abstract class CustomInputSource : IDisposable
	{
		public abstract class Controller
		{
			protected bool _isConnected;

			protected string _deviceName;

			protected string _customName;

			public string customName => _customName;

			public bool isConnected
			{
				get
				{
					return _isConnected;
				}
				set
				{
					if (value != _isConnected)
					{
						_ = _isConnected;
						_isConnected = value;
					}
				}
			}

			public string deviceName => _deviceName;

			protected Controller(string deviceName)
			{
				_deviceName = deviceName;
			}

			public void Disconnect()
			{
				if (_isConnected)
				{
					_isConnected = false;
				}
			}

			public void Connect()
			{
				if (!_isConnected)
				{
					_isConnected = true;
				}
			}

			public abstract void Update();
		}

		public abstract class Joystick : Controller
		{
			private long? zjGrlRpLFjJQPLJfBgshkcIHtSr;

			private int cHGGtPQmQEdFSaIvpIgqFYTwIUM;

			private readonly Axis[] nhriWQPeWgGbYcNCMSloCGMDlpbH;

			private readonly Button[] XMmeKfLALLiqakhkZdFxAjspFgaC;

			private readonly ReadOnlyCollection<Axis> tdOiKeLHLKVlPthfTFBcPGJSFvqe;

			private readonly ReadOnlyCollection<Button> qcayjwJGLhgSrXkPUjgcWvPSnsA;

			private bool BxmfGIMUjjyBvyrhaODhxOdxZeV;

			private Rewired.Controller.Extension hmZLUQBpfeonCDoNcFmKCFWkaEcl;

			public long? systemId
			{
				get
				{
					return zjGrlRpLFjJQPLJfBgshkcIHtSr;
				}
				protected set
				{
					zjGrlRpLFjJQPLJfBgshkcIHtSr = value;
				}
			}

			public int unityId
			{
				get
				{
					return cHGGtPQmQEdFSaIvpIgqFYTwIUM;
				}
				protected set
				{
					cHGGtPQmQEdFSaIvpIgqFYTwIUM = value;
				}
			}

			public IList<Axis> Axes => tdOiKeLHLKVlPthfTFBcPGJSFvqe;

			public IList<Button> Buttons => qcayjwJGLhgSrXkPUjgcWvPSnsA;

			public bool supportsVibration
			{
				get
				{
					return BxmfGIMUjjyBvyrhaODhxOdxZeV;
				}
				set
				{
					BxmfGIMUjjyBvyrhaODhxOdxZeV = value;
				}
			}

			public Rewired.Controller.Extension extension
			{
				get
				{
					return hmZLUQBpfeonCDoNcFmKCFWkaEcl;
				}
				set
				{
					hmZLUQBpfeonCDoNcFmKCFWkaEcl = value;
				}
			}

			public int buttonCount => XMmeKfLALLiqakhkZdFxAjspFgaC.Length;

			public int axisCount => nhriWQPeWgGbYcNCMSloCGMDlpbH.Length;

			public Joystick(string deviceName, long? systemId, int unityId, int axisCount, int buttonCount)
				: base(deviceName)
			{
				if (axisCount < 0)
				{
					axisCount = 0;
				}
				if (buttonCount < 0)
				{
					buttonCount = 0;
				}
				zjGrlRpLFjJQPLJfBgshkcIHtSr = systemId;
				cHGGtPQmQEdFSaIvpIgqFYTwIUM = unityId;
				nhriWQPeWgGbYcNCMSloCGMDlpbH = new Axis[axisCount];
				XMmeKfLALLiqakhkZdFxAjspFgaC = new Button[buttonCount];
				for (int i = 0; i < axisCount; i++)
				{
					nhriWQPeWgGbYcNCMSloCGMDlpbH[i] = new Axis();
				}
				for (int j = 0; j < buttonCount; j++)
				{
					XMmeKfLALLiqakhkZdFxAjspFgaC[j] = new Button();
				}
				tdOiKeLHLKVlPthfTFBcPGJSFvqe = new ReadOnlyCollection<Axis>(nhriWQPeWgGbYcNCMSloCGMDlpbH);
				qcayjwJGLhgSrXkPUjgcWvPSnsA = new ReadOnlyCollection<Button>(XMmeKfLALLiqakhkZdFxAjspFgaC);
			}

			public virtual float GetAxisValue(int index)
			{
				if (index < 0 || index >= nhriWQPeWgGbYcNCMSloCGMDlpbH.Length)
				{
					return 0f;
				}
				return nhriWQPeWgGbYcNCMSloCGMDlpbH[index].value;
			}

			public virtual bool GetButtonValue(int index)
			{
				if (index < 0 || index >= XMmeKfLALLiqakhkZdFxAjspFgaC.Length)
				{
					return false;
				}
				return XMmeKfLALLiqakhkZdFxAjspFgaC[index].value;
			}
		}

		public abstract class Element
		{
		}

		public sealed class Axis : Element
		{
			public float value;
		}

		public sealed class Button : Element
		{
			public bool value;
		}

		private readonly InputSource pCAdqWRoodLcXGGlseBwWkZLpAh;

		private readonly List<Joystick> eiwPcAqwtEBbdaWooJNuXXQFvlS;

		private readonly ReadOnlyCollection<Joystick> PsHeuQcYkMCbhNwpBfgvkJbIDOtg;

		private bool NgReTEITdSiVfwcfEwLfnYzjWjJ = true;

		private Action kDQtBJGVCalBUtNTVxcNcdehtHn;

		private Action NQNrJtTULxfizamYUekqVJMyvwL;

		private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

		public bool useApproximateMatching
		{
			get
			{
				return NgReTEITdSiVfwcfEwLfnYzjWjJ;
			}
			protected set
			{
				NgReTEITdSiVfwcfEwLfnYzjWjJ = value;
			}
		}

		internal InputSource inputSource => pCAdqWRoodLcXGGlseBwWkZLpAh;

		public abstract bool isReady { get; }

		private event Action _JoystickConnectedEvent
		{
			add
			{
				Action action = kDQtBJGVCalBUtNTVxcNcdehtHn;
				Action action2;
				do
				{
					action2 = action;
					Action value2 = (Action)Delegate.Combine(action2, value);
					action = Interlocked.CompareExchange(ref kDQtBJGVCalBUtNTVxcNcdehtHn, value2, action2);
				}
				while ((object)action != action2);
			}
			remove
			{
				Action action = kDQtBJGVCalBUtNTVxcNcdehtHn;
				Action action2;
				do
				{
					action2 = action;
					Action value2 = (Action)Delegate.Remove(action2, value);
					action = Interlocked.CompareExchange(ref kDQtBJGVCalBUtNTVxcNcdehtHn, value2, action2);
				}
				while ((object)action != action2);
			}
		}

		private event Action _JoystickDisconnectedEvent
		{
			add
			{
				Action action = NQNrJtTULxfizamYUekqVJMyvwL;
				Action action2;
				do
				{
					action2 = action;
					Action value2 = (Action)Delegate.Combine(action2, value);
					action = Interlocked.CompareExchange(ref NQNrJtTULxfizamYUekqVJMyvwL, value2, action2);
				}
				while ((object)action != action2);
			}
			remove
			{
				Action action = NQNrJtTULxfizamYUekqVJMyvwL;
				Action action2;
				do
				{
					action2 = action;
					Action value2 = (Action)Delegate.Remove(action2, value);
					action = Interlocked.CompareExchange(ref NQNrJtTULxfizamYUekqVJMyvwL, value2, action2);
				}
				while ((object)action != action2);
			}
		}

		internal event Action JoystickConnectedEvent
		{
			add
			{
				_JoystickConnectedEvent += value;
			}
			remove
			{
				_JoystickConnectedEvent -= value;
			}
		}

		internal event Action JoystickDisconnectedEvent
		{
			add
			{
				_JoystickDisconnectedEvent += value;
			}
			remove
			{
				_JoystickDisconnectedEvent -= value;
			}
		}

		public CustomInputSource(int inputSource)
		{
			if (!Enum.IsDefined(typeof(InputSource), inputSource))
			{
				Logger.LogError("Unknown InputSource (" + inputSource + ")!");
			}
			pCAdqWRoodLcXGGlseBwWkZLpAh = (InputSource)inputSource;
			eiwPcAqwtEBbdaWooJNuXXQFvlS = new List<Joystick>();
			PsHeuQcYkMCbhNwpBfgvkJbIDOtg = new ReadOnlyCollection<Joystick>(eiwPcAqwtEBbdaWooJNuXXQFvlS);
		}

		public void AddJoystick(Joystick joystick)
		{
			if (joystick != null)
			{
				if (eiwPcAqwtEBbdaWooJNuXXQFvlS.Contains(joystick))
				{
					Logger.LogWarning("The joystick is already in the list. Cannot add again.");
				}
				else
				{
					eiwPcAqwtEBbdaWooJNuXXQFvlS.Add(joystick);
				}
			}
		}

		public void RemoveJoystick(Joystick joystick)
		{
			if (joystick != null)
			{
				if (!eiwPcAqwtEBbdaWooJNuXXQFvlS.Contains(joystick))
				{
					Logger.LogWarning("The joystick was not found in the list. Cannot remove.");
				}
				else
				{
					eiwPcAqwtEBbdaWooJNuXXQFvlS.Remove(joystick);
				}
			}
		}

		public IList<Joystick> GetJoysticks()
		{
			return PsHeuQcYkMCbhNwpBfgvkJbIDOtg;
		}

		protected virtual void OnJoystickConnected()
		{
			if (kDQtBJGVCalBUtNTVxcNcdehtHn != null)
			{
				kDQtBJGVCalBUtNTVxcNcdehtHn();
			}
		}

		protected virtual void OnJoystickDisconnected()
		{
			if (NQNrJtTULxfizamYUekqVJMyvwL != null)
			{
				NQNrJtTULxfizamYUekqVJMyvwL();
			}
		}

		internal Joystick[] KQofPLAjTuJuhepcqipQzhiuXed()
		{
			List<Joystick> list = new List<Joystick>(eiwPcAqwtEBbdaWooJNuXXQFvlS.Count);
			for (int i = 0; i < eiwPcAqwtEBbdaWooJNuXXQFvlS.Count; i++)
			{
				Joystick joystick = eiwPcAqwtEBbdaWooJNuXXQFvlS[i];
				if (joystick != null && joystick.isConnected)
				{
					list.Add(joystick);
				}
			}
			return list.ToArray();
		}

		public virtual void Dispose()
		{
			Dispose(disposing: true);
			GC.SuppressFinalize(this);
		}

		~CustomInputSource()
		{
			Dispose(disposing: false);
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!RFSEgUYkCipDyWyLEnlGiNDUlzz)
			{
				RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
			}
		}

		public abstract void Update();
	}
}
