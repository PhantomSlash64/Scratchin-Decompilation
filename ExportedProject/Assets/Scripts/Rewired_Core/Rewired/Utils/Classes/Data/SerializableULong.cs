using System;
using UnityEngine;

namespace Rewired.Utils.Classes.Data
{
	[Serializable]
	public class SerializableULong
	{
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private int ulong_32BitLow;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private int ulong_32BitHigh;

		public ulong value
		{
			get
			{
				return ifxwErhKQUIjtkgFaBqMhRUdpom(ulong_32BitLow, ulong_32BitHigh);
			}
			set
			{
				LlQyKrhdkGfXdjOfqdzmuPpWjEvd(value, out ulong_32BitLow, out ulong_32BitHigh);
			}
		}

		public SerializableULong()
		{
		}

		public SerializableULong(SerializableULong sULong)
		{
			ulong_32BitLow = sULong.ulong_32BitLow;
			ulong_32BitHigh = sULong.ulong_32BitHigh;
		}

		private void LlQyKrhdkGfXdjOfqdzmuPpWjEvd(ulong P_0, out int P_1, out int P_2)
		{
			P_1 = (int)P_0;
			P_2 = (int)(P_0 >> 32);
		}

		private ulong ifxwErhKQUIjtkgFaBqMhRUdpom(int P_0, int P_1)
		{
			ulong num = (ulong)P_0;
			num &= 0xFFFFFFFFu;
			ulong num2 = (ulong)((long)P_1 << 32);
			return num | num2;
		}

		public SerializableULong Clone()
		{
			SerializableULong serializableULong = new SerializableULong();
			serializableULong.ulong_32BitLow = ulong_32BitLow;
			serializableULong.ulong_32BitHigh = ulong_32BitHigh;
			return serializableULong;
		}
	}
}
