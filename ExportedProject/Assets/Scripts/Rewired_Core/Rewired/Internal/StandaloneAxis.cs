using System;
using System.Threading;
using Rewired.Utils;
using UnityEngine;

namespace Rewired.Internal
{
	[Serializable]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal sealed class StandaloneAxis
	{
		[CustomObfuscation(rename = false)]
		public delegate void AxisValueChangedEventHandler(float value);

		[CustomObfuscation(rename = false)]
		public delegate void ButtonValueChangedEventHandler(bool value);

		[CustomObfuscation(rename = false)]
		public delegate void ButtonDownEventHandler();

		[CustomObfuscation(rename = false)]
		public delegate void ButtonUpEventHandler();

		[CustomObfuscation(rename = false)]
		[Range(0f, 1f)]
		[Tooltip("The axis value at or above which the buttonValue property will return True. This will also return true for negative values below the inverse of this threshold.")]
		[SerializeField]
		private float _buttonActivationThreshold = 0.5f;

		[Tooltip("Contains calibration settings for the axis.")]
		[CustomObfuscation(rename = false)]
		[SerializeField]
		private AxisCalibration _calibration = new AxisCalibration();

		[CustomObfuscation(rename = false)]
		private float _valueRaw;

		[CustomObfuscation(rename = false)]
		private float _valueRawPrev;

		private AxisValueChangedEventHandler VpnAlZEvaIiiDiEKuJtBbTisMqN;

		private AxisValueChangedEventHandler fJjMNhvjUjSykbOGSJzLSLENQwi;

		private ButtonDownEventHandler gXDwyqGTRmPvJjaGbtgGmRorFVR;

		private ButtonUpEventHandler MfaaIlxdEqqQhjkDAbCkkhRFxnx;

		private ButtonValueChangedEventHandler CUHQMQjrUITanRViFWpJuGpMvrk;

		private ButtonDownEventHandler UGTnAQjIlkgSSoSBsQzdXzuHxUK;

		private ButtonUpEventHandler VBIMSAPRWDJyOhuIMbXKcvDReTM;

		private ButtonValueChangedEventHandler PBvSUaHTFzTaiPpKHSkPWyMpMgU;

		public float buttonActivationThreshold
		{
			get
			{
				return _buttonActivationThreshold;
			}
			set
			{
				if (value != _buttonActivationThreshold)
				{
					_buttonActivationThreshold = MathTools.Abs(value);
				}
			}
		}

		public AxisCalibration calibration
		{
			get
			{
				return _calibration;
			}
			private set
			{
				if (value != _calibration)
				{
					_calibration = value;
				}
			}
		}

		public float valueRaw
		{
			get
			{
				return _valueRaw;
			}
			private set
			{
				if (value != _valueRaw)
				{
					_valueRaw = value;
				}
			}
		}

		public float valueRawPrev
		{
			get
			{
				return _valueRawPrev;
			}
			private set
			{
				if (value != _valueRawPrev)
				{
					_valueRawPrev = value;
				}
			}
		}

		public float valueRawDelta => _valueRaw - _valueRawPrev;

		public float value
		{
			get
			{
				if (_calibration == null)
				{
					return _valueRaw;
				}
				return _calibration.GetCalibratedValue(_valueRaw);
			}
		}

		public float valuePrev
		{
			get
			{
				if (_calibration == null)
				{
					return _valueRawPrev;
				}
				return _calibration.GetCalibratedValue(_valueRawPrev);
			}
		}

		public float valueDelta
		{
			get
			{
				if (_calibration == null)
				{
					return valueRawDelta;
				}
				return _calibration.GetCalibratedValue(_valueRaw) - _calibration.GetCalibratedValue(_valueRawPrev);
			}
		}

		public bool rawButtonValue => _valueRaw >= _buttonActivationThreshold;

		public bool rawButtonValuePrev => _valueRawPrev >= _buttonActivationThreshold;

		public bool buttonValue => MathTools.Abs(_calibration.GetCalibratedValue(value)) >= _buttonActivationThreshold;

		public bool buttonValuePrev => MathTools.Abs(_calibration.GetCalibratedValue(valuePrev)) >= _buttonActivationThreshold;

		internal float rawMin
		{
			get
			{
				if (_calibration == null)
				{
					return -1f;
				}
				if (!_calibration.applyRangeCalibration)
				{
					return float.NegativeInfinity;
				}
				return _calibration.calibratedMin;
			}
		}

		internal float rawMax
		{
			get
			{
				if (_calibration == null)
				{
					return 1f;
				}
				if (!_calibration.applyRangeCalibration)
				{
					return float.PositiveInfinity;
				}
				return _calibration.calibratedMax;
			}
		}

		internal float rawZero
		{
			get
			{
				if (_calibration == null)
				{
					return 0f;
				}
				if (!_calibration.applyRangeCalibration)
				{
					return 0f;
				}
				return _calibration.calibratedZero;
			}
		}

		private event AxisValueChangedEventHandler _AxisValueChangedEvent
		{
			add
			{
				AxisValueChangedEventHandler axisValueChangedEventHandler = VpnAlZEvaIiiDiEKuJtBbTisMqN;
				AxisValueChangedEventHandler axisValueChangedEventHandler2;
				do
				{
					axisValueChangedEventHandler2 = axisValueChangedEventHandler;
					AxisValueChangedEventHandler axisValueChangedEventHandler3 = (AxisValueChangedEventHandler)Delegate.Combine(axisValueChangedEventHandler2, value);
					axisValueChangedEventHandler = Interlocked.CompareExchange(ref VpnAlZEvaIiiDiEKuJtBbTisMqN, axisValueChangedEventHandler3, axisValueChangedEventHandler2);
				}
				while ((object)axisValueChangedEventHandler != axisValueChangedEventHandler2);
			}
			remove
			{
				AxisValueChangedEventHandler axisValueChangedEventHandler = VpnAlZEvaIiiDiEKuJtBbTisMqN;
				AxisValueChangedEventHandler axisValueChangedEventHandler2;
				do
				{
					axisValueChangedEventHandler2 = axisValueChangedEventHandler;
					AxisValueChangedEventHandler axisValueChangedEventHandler3 = (AxisValueChangedEventHandler)Delegate.Remove(axisValueChangedEventHandler2, value);
					axisValueChangedEventHandler = Interlocked.CompareExchange(ref VpnAlZEvaIiiDiEKuJtBbTisMqN, axisValueChangedEventHandler3, axisValueChangedEventHandler2);
				}
				while ((object)axisValueChangedEventHandler != axisValueChangedEventHandler2);
			}
		}

		public event AxisValueChangedEventHandler AxisValueChangedEvent
		{
			add
			{
				_AxisValueChangedEvent += value;
			}
			remove
			{
				_AxisValueChangedEvent -= value;
			}
		}

		private event AxisValueChangedEventHandler _RawAxisValueChangedEvent
		{
			add
			{
				AxisValueChangedEventHandler axisValueChangedEventHandler = fJjMNhvjUjSykbOGSJzLSLENQwi;
				AxisValueChangedEventHandler axisValueChangedEventHandler2;
				do
				{
					axisValueChangedEventHandler2 = axisValueChangedEventHandler;
					AxisValueChangedEventHandler axisValueChangedEventHandler3 = (AxisValueChangedEventHandler)Delegate.Combine(axisValueChangedEventHandler2, value);
					axisValueChangedEventHandler = Interlocked.CompareExchange(ref fJjMNhvjUjSykbOGSJzLSLENQwi, axisValueChangedEventHandler3, axisValueChangedEventHandler2);
				}
				while ((object)axisValueChangedEventHandler != axisValueChangedEventHandler2);
			}
			remove
			{
				AxisValueChangedEventHandler axisValueChangedEventHandler = fJjMNhvjUjSykbOGSJzLSLENQwi;
				AxisValueChangedEventHandler axisValueChangedEventHandler2;
				do
				{
					axisValueChangedEventHandler2 = axisValueChangedEventHandler;
					AxisValueChangedEventHandler axisValueChangedEventHandler3 = (AxisValueChangedEventHandler)Delegate.Remove(axisValueChangedEventHandler2, value);
					axisValueChangedEventHandler = Interlocked.CompareExchange(ref fJjMNhvjUjSykbOGSJzLSLENQwi, axisValueChangedEventHandler3, axisValueChangedEventHandler2);
				}
				while ((object)axisValueChangedEventHandler != axisValueChangedEventHandler2);
			}
		}

		public event AxisValueChangedEventHandler RawAxisValueChangedEvent
		{
			add
			{
				_RawAxisValueChangedEvent += value;
			}
			remove
			{
				_RawAxisValueChangedEvent -= value;
			}
		}

		private event ButtonDownEventHandler _ButtonDownEvent
		{
			add
			{
				ButtonDownEventHandler buttonDownEventHandler = gXDwyqGTRmPvJjaGbtgGmRorFVR;
				ButtonDownEventHandler buttonDownEventHandler2;
				do
				{
					buttonDownEventHandler2 = buttonDownEventHandler;
					ButtonDownEventHandler buttonDownEventHandler3 = (ButtonDownEventHandler)Delegate.Combine(buttonDownEventHandler2, value);
					buttonDownEventHandler = Interlocked.CompareExchange(ref gXDwyqGTRmPvJjaGbtgGmRorFVR, buttonDownEventHandler3, buttonDownEventHandler2);
				}
				while ((object)buttonDownEventHandler != buttonDownEventHandler2);
			}
			remove
			{
				ButtonDownEventHandler buttonDownEventHandler = gXDwyqGTRmPvJjaGbtgGmRorFVR;
				ButtonDownEventHandler buttonDownEventHandler2;
				do
				{
					buttonDownEventHandler2 = buttonDownEventHandler;
					ButtonDownEventHandler buttonDownEventHandler3 = (ButtonDownEventHandler)Delegate.Remove(buttonDownEventHandler2, value);
					buttonDownEventHandler = Interlocked.CompareExchange(ref gXDwyqGTRmPvJjaGbtgGmRorFVR, buttonDownEventHandler3, buttonDownEventHandler2);
				}
				while ((object)buttonDownEventHandler != buttonDownEventHandler2);
			}
		}

		public event ButtonDownEventHandler ButtonDownEvent
		{
			add
			{
				_ButtonDownEvent += value;
			}
			remove
			{
				_ButtonDownEvent -= value;
			}
		}

		private event ButtonUpEventHandler _ButtonUpEvent
		{
			add
			{
				ButtonUpEventHandler buttonUpEventHandler = MfaaIlxdEqqQhjkDAbCkkhRFxnx;
				ButtonUpEventHandler buttonUpEventHandler2;
				do
				{
					buttonUpEventHandler2 = buttonUpEventHandler;
					ButtonUpEventHandler buttonUpEventHandler3 = (ButtonUpEventHandler)Delegate.Combine(buttonUpEventHandler2, value);
					buttonUpEventHandler = Interlocked.CompareExchange(ref MfaaIlxdEqqQhjkDAbCkkhRFxnx, buttonUpEventHandler3, buttonUpEventHandler2);
				}
				while ((object)buttonUpEventHandler != buttonUpEventHandler2);
			}
			remove
			{
				ButtonUpEventHandler buttonUpEventHandler = MfaaIlxdEqqQhjkDAbCkkhRFxnx;
				ButtonUpEventHandler buttonUpEventHandler2;
				do
				{
					buttonUpEventHandler2 = buttonUpEventHandler;
					ButtonUpEventHandler buttonUpEventHandler3 = (ButtonUpEventHandler)Delegate.Remove(buttonUpEventHandler2, value);
					buttonUpEventHandler = Interlocked.CompareExchange(ref MfaaIlxdEqqQhjkDAbCkkhRFxnx, buttonUpEventHandler3, buttonUpEventHandler2);
				}
				while ((object)buttonUpEventHandler != buttonUpEventHandler2);
			}
		}

		public event ButtonUpEventHandler ButtonUpEvent
		{
			add
			{
				_ButtonUpEvent += value;
			}
			remove
			{
				_ButtonUpEvent -= value;
			}
		}

		private event ButtonValueChangedEventHandler _ButtonValueChangedEvent
		{
			add
			{
				ButtonValueChangedEventHandler buttonValueChangedEventHandler = CUHQMQjrUITanRViFWpJuGpMvrk;
				ButtonValueChangedEventHandler buttonValueChangedEventHandler2;
				do
				{
					buttonValueChangedEventHandler2 = buttonValueChangedEventHandler;
					ButtonValueChangedEventHandler buttonValueChangedEventHandler3 = (ButtonValueChangedEventHandler)Delegate.Combine(buttonValueChangedEventHandler2, value);
					buttonValueChangedEventHandler = Interlocked.CompareExchange(ref CUHQMQjrUITanRViFWpJuGpMvrk, buttonValueChangedEventHandler3, buttonValueChangedEventHandler2);
				}
				while ((object)buttonValueChangedEventHandler != buttonValueChangedEventHandler2);
			}
			remove
			{
				ButtonValueChangedEventHandler buttonValueChangedEventHandler = CUHQMQjrUITanRViFWpJuGpMvrk;
				ButtonValueChangedEventHandler buttonValueChangedEventHandler2;
				do
				{
					buttonValueChangedEventHandler2 = buttonValueChangedEventHandler;
					ButtonValueChangedEventHandler buttonValueChangedEventHandler3 = (ButtonValueChangedEventHandler)Delegate.Remove(buttonValueChangedEventHandler2, value);
					buttonValueChangedEventHandler = Interlocked.CompareExchange(ref CUHQMQjrUITanRViFWpJuGpMvrk, buttonValueChangedEventHandler3, buttonValueChangedEventHandler2);
				}
				while ((object)buttonValueChangedEventHandler != buttonValueChangedEventHandler2);
			}
		}

		public event ButtonValueChangedEventHandler ButtonValueChangedEvent
		{
			add
			{
				_ButtonValueChangedEvent += value;
			}
			remove
			{
				_ButtonValueChangedEvent -= value;
			}
		}

		private event ButtonDownEventHandler _RawButtonDownEvent
		{
			add
			{
				ButtonDownEventHandler buttonDownEventHandler = UGTnAQjIlkgSSoSBsQzdXzuHxUK;
				ButtonDownEventHandler buttonDownEventHandler2;
				do
				{
					buttonDownEventHandler2 = buttonDownEventHandler;
					ButtonDownEventHandler buttonDownEventHandler3 = (ButtonDownEventHandler)Delegate.Combine(buttonDownEventHandler2, value);
					buttonDownEventHandler = Interlocked.CompareExchange(ref UGTnAQjIlkgSSoSBsQzdXzuHxUK, buttonDownEventHandler3, buttonDownEventHandler2);
				}
				while ((object)buttonDownEventHandler != buttonDownEventHandler2);
			}
			remove
			{
				ButtonDownEventHandler buttonDownEventHandler = UGTnAQjIlkgSSoSBsQzdXzuHxUK;
				ButtonDownEventHandler buttonDownEventHandler2;
				do
				{
					buttonDownEventHandler2 = buttonDownEventHandler;
					ButtonDownEventHandler buttonDownEventHandler3 = (ButtonDownEventHandler)Delegate.Remove(buttonDownEventHandler2, value);
					buttonDownEventHandler = Interlocked.CompareExchange(ref UGTnAQjIlkgSSoSBsQzdXzuHxUK, buttonDownEventHandler3, buttonDownEventHandler2);
				}
				while ((object)buttonDownEventHandler != buttonDownEventHandler2);
			}
		}

		public event ButtonDownEventHandler RawButtonDownEvent
		{
			add
			{
				_RawButtonDownEvent += value;
			}
			remove
			{
				_RawButtonDownEvent -= value;
			}
		}

		private event ButtonUpEventHandler _RawButtonUpEvent
		{
			add
			{
				ButtonUpEventHandler buttonUpEventHandler = VBIMSAPRWDJyOhuIMbXKcvDReTM;
				ButtonUpEventHandler buttonUpEventHandler2;
				do
				{
					buttonUpEventHandler2 = buttonUpEventHandler;
					ButtonUpEventHandler buttonUpEventHandler3 = (ButtonUpEventHandler)Delegate.Combine(buttonUpEventHandler2, value);
					buttonUpEventHandler = Interlocked.CompareExchange(ref VBIMSAPRWDJyOhuIMbXKcvDReTM, buttonUpEventHandler3, buttonUpEventHandler2);
				}
				while ((object)buttonUpEventHandler != buttonUpEventHandler2);
			}
			remove
			{
				ButtonUpEventHandler buttonUpEventHandler = VBIMSAPRWDJyOhuIMbXKcvDReTM;
				ButtonUpEventHandler buttonUpEventHandler2;
				do
				{
					buttonUpEventHandler2 = buttonUpEventHandler;
					ButtonUpEventHandler buttonUpEventHandler3 = (ButtonUpEventHandler)Delegate.Remove(buttonUpEventHandler2, value);
					buttonUpEventHandler = Interlocked.CompareExchange(ref VBIMSAPRWDJyOhuIMbXKcvDReTM, buttonUpEventHandler3, buttonUpEventHandler2);
				}
				while ((object)buttonUpEventHandler != buttonUpEventHandler2);
			}
		}

		public event ButtonUpEventHandler RawButtonUpEvent
		{
			add
			{
				_RawButtonUpEvent += value;
			}
			remove
			{
				_RawButtonUpEvent -= value;
			}
		}

		private event ButtonValueChangedEventHandler _RawButtonValueChangedEvent
		{
			add
			{
				ButtonValueChangedEventHandler buttonValueChangedEventHandler = PBvSUaHTFzTaiPpKHSkPWyMpMgU;
				ButtonValueChangedEventHandler buttonValueChangedEventHandler2;
				do
				{
					buttonValueChangedEventHandler2 = buttonValueChangedEventHandler;
					ButtonValueChangedEventHandler buttonValueChangedEventHandler3 = (ButtonValueChangedEventHandler)Delegate.Combine(buttonValueChangedEventHandler2, value);
					buttonValueChangedEventHandler = Interlocked.CompareExchange(ref PBvSUaHTFzTaiPpKHSkPWyMpMgU, buttonValueChangedEventHandler3, buttonValueChangedEventHandler2);
				}
				while ((object)buttonValueChangedEventHandler != buttonValueChangedEventHandler2);
			}
			remove
			{
				ButtonValueChangedEventHandler buttonValueChangedEventHandler = PBvSUaHTFzTaiPpKHSkPWyMpMgU;
				ButtonValueChangedEventHandler buttonValueChangedEventHandler2;
				do
				{
					buttonValueChangedEventHandler2 = buttonValueChangedEventHandler;
					ButtonValueChangedEventHandler buttonValueChangedEventHandler3 = (ButtonValueChangedEventHandler)Delegate.Remove(buttonValueChangedEventHandler2, value);
					buttonValueChangedEventHandler = Interlocked.CompareExchange(ref PBvSUaHTFzTaiPpKHSkPWyMpMgU, buttonValueChangedEventHandler3, buttonValueChangedEventHandler2);
				}
				while ((object)buttonValueChangedEventHandler != buttonValueChangedEventHandler2);
			}
		}

		public event ButtonValueChangedEventHandler RawButtonValueChangedEvent
		{
			add
			{
				_RawButtonValueChangedEvent += value;
			}
			remove
			{
				_RawButtonValueChangedEvent -= value;
			}
		}

		internal StandaloneAxis()
		{
		}

		public void SetRawValue(float value)
		{
			_valueRawPrev = _valueRaw;
			_valueRaw = value;
			if (value == _valueRawPrev)
			{
				return;
			}
			if (fJjMNhvjUjSykbOGSJzLSLENQwi != null && _valueRaw != _valueRawPrev)
			{
				fJjMNhvjUjSykbOGSJzLSLENQwi(_valueRaw);
			}
			if (VpnAlZEvaIiiDiEKuJtBbTisMqN != null)
			{
				float num = this.value;
				if (num != valuePrev)
				{
					VpnAlZEvaIiiDiEKuJtBbTisMqN(num);
				}
			}
			if (PBvSUaHTFzTaiPpKHSkPWyMpMgU != null)
			{
				bool flag = rawButtonValue;
				if (flag != rawButtonValuePrev)
				{
					PBvSUaHTFzTaiPpKHSkPWyMpMgU(flag);
				}
			}
			if (UGTnAQjIlkgSSoSBsQzdXzuHxUK != null && rawButtonValue && !rawButtonValuePrev)
			{
				UGTnAQjIlkgSSoSBsQzdXzuHxUK();
			}
			if (VBIMSAPRWDJyOhuIMbXKcvDReTM != null && !rawButtonValue && rawButtonValuePrev)
			{
				VBIMSAPRWDJyOhuIMbXKcvDReTM();
			}
			if (CUHQMQjrUITanRViFWpJuGpMvrk != null)
			{
				bool flag2 = buttonValue;
				if (flag2 != buttonValuePrev)
				{
					CUHQMQjrUITanRViFWpJuGpMvrk(flag2);
				}
			}
			if (gXDwyqGTRmPvJjaGbtgGmRorFVR != null && buttonValue && !buttonValuePrev)
			{
				gXDwyqGTRmPvJjaGbtgGmRorFVR();
			}
			if (MfaaIlxdEqqQhjkDAbCkkhRFxnx != null && !buttonValue && buttonValuePrev)
			{
				MfaaIlxdEqqQhjkDAbCkkhRFxnx();
			}
		}

		public void Clear()
		{
			SetRawValue(rawZero);
		}

		[CustomObfuscation(rename = false)]
		internal static StandaloneAxis CreateRelative()
		{
			StandaloneAxis standaloneAxis = new StandaloneAxis();
			standaloneAxis._calibration = AxisCalibration.CreateRelative();
			return standaloneAxis;
		}
	}
}
