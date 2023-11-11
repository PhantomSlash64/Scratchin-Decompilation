using System;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired.Data.Mapping
{
	[Serializable]
	public sealed class CustomCalculation_Accelerometer : CustomCalculation
	{
		public enum CalculationType
		{
			Pitch = 0,
			Roll = 1
		}

		public enum OutputType
		{
			Axis = 0,
			Angle = 1
		}

		public enum InputType
		{
			Acceleration = 0,
			UserAcceleration = 1,
			Gravity = 2
		}

		public CalculationType _calculationType;

		public InputType _inputType;

		public OutputType _outputType;

		internal override TypeWrapper.DataType ResultType => TypeWrapper.DataType.Single;

		internal bool UTBGhSDYbMalVnurcPANZeSDWTZH()
		{
			bool flag = false;
			ClearResult();
			if (base.DataCount >= 1)
			{
				switch (_calculationType)
				{
				case CalculationType.Pitch:
					_result = jcwkBqaAniIRzYqdRJqBkxhHKST();
					flag = true;
					break;
				case CalculationType.Roll:
					_result = NbsqyUOKXduiXlpCJgUtosYVzMZ();
					flag = true;
					break;
				}
			}
			ClearData();
			_resultIsValid = flag;
			return flag;
		}

		private float jcwkBqaAniIRzYqdRJqBkxhHKST()
		{
			Vector3 vector = default(Vector3);
			int num = MathTools.Min(base.DataCount, 3);
			for (int i = 0; i < num; i++)
			{
				if (_data[i].type == TypeWrapper.DataType.Single)
				{
					vector[i] = _data[i];
				}
			}
			InputType inputType = _inputType;
			float num2;
			if (inputType == InputType.Gravity)
			{
				if (vector.x == 0f && vector.y == 0f && vector.z == 0f)
				{
					return 0f;
				}
				num2 = (0f - MathTools.Atan2(0f - vector.z, 0f - vector.y)) * 57.29578f;
			}
			else
			{
				num2 = 0f;
			}
			return _outputType switch
			{
				OutputType.Angle => num2, 
				OutputType.Axis => vdNTfJUQfhqAqTJDAjPjeQRcvqh(num2), 
				_ => 0f, 
			};
		}

		private float NbsqyUOKXduiXlpCJgUtosYVzMZ()
		{
			Vector3 vector = default(Vector3);
			int num = MathTools.Min(base.DataCount, 3);
			for (int i = 0; i < num; i++)
			{
				vector[i] = _data[i];
			}
			InputType inputType = _inputType;
			float num2;
			if (inputType == InputType.Gravity)
			{
				if (vector.x == 0f && vector.y == 0f && vector.z == 0f)
				{
					return 0f;
				}
				num2 = (0f - MathTools.Atan2(vector.x, 0f - vector.y)) * 57.29578f;
			}
			else
			{
				num2 = 0f;
			}
			return _outputType switch
			{
				OutputType.Angle => num2, 
				OutputType.Axis => vdNTfJUQfhqAqTJDAjPjeQRcvqh(num2), 
				_ => 0f, 
			};
		}

		private float vdNTfJUQfhqAqTJDAjPjeQRcvqh(float P_0)
		{
			if (P_0 == 0f)
			{
				return 0f;
			}
			return MathTools.Abs(P_0) / 180f * MathTools.Sign(P_0);
		}
	}
}
