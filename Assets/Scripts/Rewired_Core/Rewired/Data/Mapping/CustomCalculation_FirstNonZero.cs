using System;
using Rewired.Utils.Classes.Data;

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class CustomCalculation_FirstNonZero : CustomCalculation
	{
		private const TypeWrapper.DataType resultType = TypeWrapper.DataType.Single;

		internal override TypeWrapper.DataType ResultType => TypeWrapper.DataType.Single;

		internal bool UTBGhSDYbMalVnurcPANZeSDWTZH()
		{
			bool flag = false;
			ClearResult();
			if (base.DataCount >= 1)
			{
				_result = ivKeGBsgVlMvHxDVyhxWRFpmSCs();
				flag = true;
			}
			ClearData();
			_resultIsValid = flag;
			return flag;
		}

		private float ivKeGBsgVlMvHxDVyhxWRFpmSCs()
		{
			int dataCount = base.DataCount;
			if (dataCount == 0)
			{
				return 0f;
			}
			float result = 0f;
			for (int i = 0; i < dataCount; i++)
			{
				TypeWrapper.DataType type = _data[i].type;
				if (type != TypeWrapper.DataType.Single)
				{
					throw new Exception("Data type must be the same on all data fields!");
				}
				float num = _data[i];
				if (num != 0f)
				{
					result = num;
					break;
				}
			}
			return result;
		}
	}
}
