using System;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[Serializable]
	public sealed class InputBehavior
	{
		[SerializeField]
		[CustomObfuscation(rename = false)]
		private int _id;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private string _name;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private float _joystickAxisSensitivity = 1f;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private bool _digitalAxisSimulation = true;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private bool _digitalAxisSnap;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private bool _digitalAxisInstantReverse;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private float _digitalAxisGravity;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private float _digitalAxisSensitivity;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private MouseXYAxisMode _mouseXYAxisMode;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private MouseOtherAxisMode _mouseOtherAxisMode;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private float _mouseXYAxisSensitivity;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private MouseXYAxisDeltaCalc _mouseXYAxisDeltaCalc;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private float _mouseOtherAxisSensitivity;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private float _customControllerAxisSensitivity = 1f;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private float _buttonDoublePressSpeed;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private float _buttonShortPressTime = 0.25f;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private float _buttonShortPressExpiresIn;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private float _buttonLongPressTime = 1f;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private float _buttonLongPressExpiresIn;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private float _buttonDeadZone;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private float _buttonDownBuffer;

		[CustomObfuscation(rename = false)]
		[SerializeField]
		private float _buttonRepeatRate = 30f;

		[SerializeField]
		[CustomObfuscation(rename = false)]
		private float _buttonRepeatDelay;

		public int id
		{
			get
			{
				return _id;
			}
			internal set
			{
				_id = value;
			}
		}

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

		public float joystickAxisSensitivity
		{
			get
			{
				return _joystickAxisSensitivity;
			}
			set
			{
				value = MathTools.Clamp(value, 0f, float.PositiveInfinity);
				_joystickAxisSensitivity = value;
			}
		}

		public bool digitalAxisSimulation
		{
			get
			{
				return _digitalAxisSimulation;
			}
			set
			{
				_digitalAxisSimulation = value;
			}
		}

		public bool digitalAxisSnap
		{
			get
			{
				return _digitalAxisSnap;
			}
			set
			{
				_digitalAxisSnap = value;
			}
		}

		public bool digitalAxisInstantReverse
		{
			get
			{
				return _digitalAxisInstantReverse;
			}
			set
			{
				_digitalAxisInstantReverse = value;
			}
		}

		public float digitalAxisGravity
		{
			get
			{
				return _digitalAxisGravity;
			}
			set
			{
				value = MathTools.Clamp(value, 0f, float.PositiveInfinity);
				_digitalAxisGravity = value;
			}
		}

		public float digitalAxisSensitivity
		{
			get
			{
				return _digitalAxisSensitivity;
			}
			set
			{
				value = MathTools.Clamp(value, 0f, float.PositiveInfinity);
				_digitalAxisSensitivity = value;
			}
		}

		public MouseXYAxisMode mouseXYAxisMode
		{
			get
			{
				return _mouseXYAxisMode;
			}
			set
			{
				_mouseXYAxisMode = value;
			}
		}

		public MouseOtherAxisMode mouseOtherAxisMode
		{
			get
			{
				return _mouseOtherAxisMode;
			}
			set
			{
				_mouseOtherAxisMode = value;
			}
		}

		public float mouseXYAxisSensitivity
		{
			get
			{
				return _mouseXYAxisSensitivity;
			}
			set
			{
				value = MathTools.Clamp(value, 0f, float.PositiveInfinity);
				_mouseXYAxisSensitivity = value;
			}
		}

		public MouseXYAxisDeltaCalc mouseXYAxisDeltaCalc
		{
			get
			{
				return _mouseXYAxisDeltaCalc;
			}
			set
			{
				_mouseXYAxisDeltaCalc = value;
			}
		}

		public float mouseOtherAxisSensitivity
		{
			get
			{
				return _mouseOtherAxisSensitivity;
			}
			set
			{
				value = MathTools.Clamp(value, 0f, float.PositiveInfinity);
				_mouseOtherAxisSensitivity = value;
			}
		}

		public float customControllerAxisSensitivity
		{
			get
			{
				return _customControllerAxisSensitivity;
			}
			set
			{
				value = MathTools.Clamp(value, 0f, float.PositiveInfinity);
				_customControllerAxisSensitivity = value;
			}
		}

		public float buttonDoublePressSpeed
		{
			get
			{
				return _buttonDoublePressSpeed;
			}
			set
			{
				value = MathTools.Clamp(value, 0.01f, 10f);
				_buttonDoublePressSpeed = value;
			}
		}

		public float buttonShortPressTime
		{
			get
			{
				return _buttonShortPressTime;
			}
			set
			{
				value = MathTools.Clamp(value, 0f, float.MaxValue);
				_buttonShortPressTime = value;
			}
		}

		public float buttonShortPressExpiresIn
		{
			get
			{
				return _buttonShortPressExpiresIn;
			}
			set
			{
				value = MathTools.Clamp(value, 0f, float.MaxValue);
				_buttonShortPressExpiresIn = value;
			}
		}

		public float buttonLongPressTime
		{
			get
			{
				return _buttonLongPressTime;
			}
			set
			{
				value = MathTools.Clamp(value, 0f, float.MaxValue);
				_buttonLongPressTime = value;
			}
		}

		public float buttonLongPressExpiresIn
		{
			get
			{
				return _buttonLongPressExpiresIn;
			}
			set
			{
				value = MathTools.Clamp(value, 0f, float.MaxValue);
				_buttonLongPressExpiresIn = value;
			}
		}

		public float buttonDeadZone
		{
			get
			{
				return _buttonDeadZone;
			}
			set
			{
				value = MathTools.Clamp(value, 0f, 1f);
				_buttonDeadZone = value;
			}
		}

		public float buttonDownBuffer
		{
			get
			{
				return _buttonDownBuffer;
			}
			set
			{
				value = MathTools.Clamp(value, 0f, float.PositiveInfinity);
				_buttonDownBuffer = value;
			}
		}

		public float buttonRepeatRate
		{
			get
			{
				return _buttonRepeatRate;
			}
			set
			{
				value = MathTools.Max(0.001f, value);
				_buttonRepeatRate = value;
			}
		}

		public float buttonRepeatDelay
		{
			get
			{
				return _buttonRepeatDelay;
			}
			set
			{
				value = MathTools.Max(0f, value);
				_buttonRepeatDelay = value;
			}
		}

		public InputBehavior()
		{
		}

		public InputBehavior(InputBehavior source)
			: this()
		{
			bgLdNiYEOYHSgFFoUkdxtdQUvuK(source, this, true);
		}

		public string ToXmlString()
		{
			try
			{
				return fpYSxtCTDRTKJEqidcabyFZdTWE().ToXmlString(writeDocumentTag: true);
			}
			catch (Exception ex)
			{
				Logger.LogWarning("Error writing InputBehavior to XML. " + ex.Message);
			}
			return string.Empty;
		}

		public bool ImportXmlString(string xmlString)
		{
			try
			{
				QwulHzCeLMcALfriecpsBcgtEiTX(SerializedObject.FromXml(GetType(), xmlString));
				return true;
			}
			catch (Exception ex)
			{
				Logger.LogWarning("Error reading InputBehavior from XML. " + ex.Message);
				return false;
			}
		}

		public string ToJsonString()
		{
			try
			{
				return fpYSxtCTDRTKJEqidcabyFZdTWE().ToJsonString();
			}
			catch (Exception ex)
			{
				Logger.LogWarning("Error writing InputBehavior to JSON. " + ex.Message);
			}
			return string.Empty;
		}

		public bool ImportJsonString(string jsonString)
		{
			try
			{
				QwulHzCeLMcALfriecpsBcgtEiTX(SerializedObject.FromJson(GetType(), jsonString));
				return true;
			}
			catch (Exception ex)
			{
				Logger.LogWarning("Error reading InputBehavior from JSON. " + ex.Message);
				return false;
			}
		}

		public bool ImportData(InputBehavior inputBehavior)
		{
			if (inputBehavior == null)
			{
				return false;
			}
			bgLdNiYEOYHSgFFoUkdxtdQUvuK(inputBehavior, this, false);
			return true;
		}

		public InputBehavior Clone()
		{
			return new InputBehavior(this);
		}

		public void Reset()
		{
			InputBehavior inputBehavior = ReInput.mapping.hqlzrbLJgYemJobDFvOYgEihuSx(_id);
			if (inputBehavior != null)
			{
				bgLdNiYEOYHSgFFoUkdxtdQUvuK(inputBehavior, this, true);
			}
		}

		internal SerializedObject fpYSxtCTDRTKJEqidcabyFZdTWE()
		{
			SerializedObject serializedObject = new SerializedObject(GetType(), SerializedObject.ObjectType.Object);
			serializedObject.Add("dataVersion", 5, SerializedObject.FieldOptions.ExculdeFromXml);
			serializedObject.xmlInfo = new SerializedObject.XmlInfo();
			serializedObject.xmlInfo.attributes.Add(new SerializedObject.XmlInfo.kwLxndskJikCtPGLslSPWsTXCTW
			{
				FaRCzmOJYwGVoyOIjhyHpMferPo = "dataVersion",
				foSRcEqSuRsWnadDiKcGnhBewOU = 5.ToString()
			});
			serializedObject.xmlInfo.attributes.Add(new SerializedObject.XmlInfo.kwLxndskJikCtPGLslSPWsTXCTW
			{
				FaRCzmOJYwGVoyOIjhyHpMferPo = "id",
				foSRcEqSuRsWnadDiKcGnhBewOU = _id.ToString()
			});
			serializedObject.xmlInfo.attributes.Add(new SerializedObject.XmlInfo.kwLxndskJikCtPGLslSPWsTXCTW
			{
				jveufREDmiaHzvZNPCiXJKHYoFA = "xmlns",
				FaRCzmOJYwGVoyOIjhyHpMferPo = "xsi",
				ErZkPlJPCSFziEkQUXjksErSMGjf = null,
				foSRcEqSuRsWnadDiKcGnhBewOU = "http://www.w3.org/2001/XMLSchema-instance"
			});
			serializedObject.xmlInfo.attributes.Add(new SerializedObject.XmlInfo.kwLxndskJikCtPGLslSPWsTXCTW
			{
				jveufREDmiaHzvZNPCiXJKHYoFA = "xsi",
				FaRCzmOJYwGVoyOIjhyHpMferPo = "schemaLocation",
				ErZkPlJPCSFziEkQUXjksErSMGjf = null,
				foSRcEqSuRsWnadDiKcGnhBewOU = string.Format("{0} {1}{2}{3}{4}{5}", "http://guavaman.com/rewired", "http://guavaman.com/schemas/rewired/", "1.4", "/", GetType().Name, ".xsd")
			});
			serializedObject.Add("id", _id);
			serializedObject.Add("name", _name);
			serializedObject.Add("joystickAxisSensitivity", _joystickAxisSensitivity);
			serializedObject.Add("digitalAxisSimulation", _digitalAxisSimulation);
			serializedObject.Add("digitalAxisSnap", _digitalAxisSnap);
			serializedObject.Add("digitalAxisInstantReverse", _digitalAxisInstantReverse);
			serializedObject.Add("digitalAxisGravity", _digitalAxisGravity);
			serializedObject.Add("digitalAxisSensitivity", _digitalAxisSensitivity);
			serializedObject.Add("mouseXYAxisMode", _mouseXYAxisMode);
			serializedObject.Add("mouseOtherAxisMode", _mouseOtherAxisMode);
			serializedObject.Add("mouseXYAxisSensitivity", _mouseXYAxisSensitivity);
			serializedObject.Add("mouseXYAxisDeltaCalc", _mouseXYAxisDeltaCalc);
			serializedObject.Add("mouseOtherAxisSensitivity", _mouseOtherAxisSensitivity);
			serializedObject.Add("customControllerAxisSensitivity", _customControllerAxisSensitivity);
			serializedObject.Add("buttonDoublePressSpeed", _buttonDoublePressSpeed);
			serializedObject.Add("buttonShortPressTime", _buttonShortPressTime);
			serializedObject.Add("buttonShortPressExpiresIn", _buttonShortPressExpiresIn);
			serializedObject.Add("buttonLongPressTime", _buttonLongPressTime);
			serializedObject.Add("buttonLongPressExpiresIn", _buttonLongPressExpiresIn);
			serializedObject.Add("buttonDeadZone", _buttonDeadZone);
			serializedObject.Add("buttonDownBuffer", _buttonDownBuffer);
			serializedObject.Add("buttonRepeatRate", _buttonRepeatRate);
			serializedObject.Add("buttonRepeatDelay", _buttonRepeatDelay);
			return serializedObject;
		}

		internal void QwulHzCeLMcALfriecpsBcgtEiTX(SerializedObject P_0)
		{
			Reset();
			P_0.TryGetDeserializedValueByRef("joystickAxisSensitivity", ref _joystickAxisSensitivity);
			P_0.TryGetDeserializedValueByRef("digitalAxisSimulation", ref _digitalAxisSimulation);
			P_0.TryGetDeserializedValueByRef("digitalAxisSnap", ref _digitalAxisSnap);
			P_0.TryGetDeserializedValueByRef("digitalAxisInstantReverse", ref _digitalAxisInstantReverse);
			P_0.TryGetDeserializedValueByRef("digitalAxisGravity", ref _digitalAxisGravity);
			P_0.TryGetDeserializedValueByRef("digitalAxisSensitivity", ref _digitalAxisSensitivity);
			P_0.TryGetDeserializedValueByRef("mouseXYAxisMode", ref _mouseXYAxisMode);
			P_0.TryGetDeserializedValueByRef("mouseOtherAxisMode", ref _mouseOtherAxisMode);
			P_0.TryGetDeserializedValueByRef("mouseXYAxisSensitivity", ref _mouseXYAxisSensitivity);
			P_0.TryGetDeserializedValueByRef("mouseXYAxisDeltaCalc", ref _mouseXYAxisDeltaCalc);
			P_0.TryGetDeserializedValueByRef("mouseOtherAxisSensitivity", ref _mouseOtherAxisSensitivity);
			P_0.TryGetDeserializedValueByRef("customControllerAxisSensitivity", ref _customControllerAxisSensitivity);
			P_0.TryGetDeserializedValueByRef("buttonDoublePressSpeed", ref _buttonDoublePressSpeed);
			P_0.TryGetDeserializedValueByRef("buttonShortPressTime", ref _buttonShortPressTime);
			P_0.TryGetDeserializedValueByRef("buttonShortPressExpiresIn", ref _buttonShortPressExpiresIn);
			P_0.TryGetDeserializedValueByRef("buttonLongPressTime", ref _buttonLongPressTime);
			P_0.TryGetDeserializedValueByRef("buttonLongPressExpiresIn", ref _buttonLongPressExpiresIn);
			P_0.TryGetDeserializedValueByRef("buttonDeadZone", ref _buttonDeadZone);
			P_0.TryGetDeserializedValueByRef("buttonDownBuffer", ref _buttonDownBuffer);
			P_0.TryGetDeserializedValueByRef("buttonRepeatRate", ref _buttonRepeatRate);
			P_0.TryGetDeserializedValueByRef("buttonRepeatDelay", ref _buttonRepeatDelay);
		}

		private static void bgLdNiYEOYHSgFFoUkdxtdQUvuK(InputBehavior P_0, InputBehavior P_1, bool P_2)
		{
			if (P_2)
			{
				P_1._id = P_0._id;
			}
			P_1._name = P_0._name;
			P_1._joystickAxisSensitivity = P_0._joystickAxisSensitivity;
			P_1._digitalAxisSimulation = P_0._digitalAxisSimulation;
			P_1._digitalAxisSnap = P_0._digitalAxisSnap;
			P_1._digitalAxisInstantReverse = P_0._digitalAxisInstantReverse;
			P_1._digitalAxisGravity = P_0._digitalAxisGravity;
			P_1._digitalAxisSensitivity = P_0._digitalAxisSensitivity;
			P_1._mouseXYAxisMode = P_0._mouseXYAxisMode;
			P_1._mouseOtherAxisMode = P_0._mouseOtherAxisMode;
			P_1._mouseXYAxisSensitivity = P_0._mouseXYAxisSensitivity;
			P_1._mouseOtherAxisSensitivity = P_0._mouseOtherAxisSensitivity;
			P_1._mouseXYAxisDeltaCalc = P_0._mouseXYAxisDeltaCalc;
			P_1._customControllerAxisSensitivity = P_0._customControllerAxisSensitivity;
			P_1._buttonDoublePressSpeed = P_0._buttonDoublePressSpeed;
			P_1._buttonShortPressTime = P_0._buttonShortPressTime;
			P_1._buttonShortPressExpiresIn = P_0._buttonShortPressExpiresIn;
			P_1._buttonLongPressTime = P_0._buttonLongPressTime;
			P_1._buttonLongPressExpiresIn = P_0._buttonLongPressExpiresIn;
			P_1._buttonDeadZone = P_0._buttonDeadZone;
			P_1._buttonDownBuffer = P_0._buttonDownBuffer;
			P_1._buttonRepeatRate = P_0._buttonRepeatRate;
			P_1._buttonRepeatDelay = P_0._buttonRepeatDelay;
		}
	}
}
