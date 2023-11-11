using System;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	[Serializable]
	public class HardwareButtonInfo : IDeepCloneable
	{
		[SerializeField]
		internal bool _excludeFromPolling;

		[SerializeField]
		internal bool _isPressureSensitive;

		public bool excludeFromPolling => _excludeFromPolling;

		public bool isPressureSensitive => _isPressureSensitive;

		public HardwareButtonInfo()
		{
			_excludeFromPolling = false;
			_isPressureSensitive = false;
		}

		[CustomObfuscation(rename = false)]
		internal HardwareButtonInfo(bool excludeFromPolling, bool isPressureSensitive)
		{
			_excludeFromPolling = excludeFromPolling;
			_isPressureSensitive = isPressureSensitive;
		}

		public object DeepClone()
		{
			return new HardwareButtonInfo(_excludeFromPolling, _isPressureSensitive);
		}
	}
}
