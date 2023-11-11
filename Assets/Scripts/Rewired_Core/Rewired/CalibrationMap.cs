using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	public sealed class CalibrationMap
	{
		private AxisCalibration[] nhriWQPeWgGbYcNCMSloCGMDlpbH;

		private IList<AxisCalibration> FzZHQoDaEFKBwlFIxxzubHbpNPv;

		private readonly int PivQvdYMhUssuLwaglJVqkqXMSH;

		public IList<AxisCalibration> Axes => FzZHQoDaEFKBwlFIxxzubHbpNPv;

		public int axisCount
		{
			get
			{
				if (nhriWQPeWgGbYcNCMSloCGMDlpbH == null)
				{
					return 0;
				}
				return nhriWQPeWgGbYcNCMSloCGMDlpbH.Length;
			}
		}

		private CalibrationMap()
		{
			PivQvdYMhUssuLwaglJVqkqXMSH = ReInput.id;
		}

		internal CalibrationMap(AxisCalibrationData[] hardwareAxisCalibrationData)
			: this()
		{
			int num = ((hardwareAxisCalibrationData != null) ? hardwareAxisCalibrationData.Length : 0);
			nhriWQPeWgGbYcNCMSloCGMDlpbH = new AxisCalibration[num];
			for (int i = 0; i < num; i++)
			{
				nhriWQPeWgGbYcNCMSloCGMDlpbH[i] = new AxisCalibration(hardwareAxisCalibrationData[i]);
			}
			FzZHQoDaEFKBwlFIxxzubHbpNPv = new ReadOnlyCollection<AxisCalibration>(nhriWQPeWgGbYcNCMSloCGMDlpbH);
		}

		public CalibrationMap(AxisCalibration[] axisCalibrations)
			: this()
		{
			nhriWQPeWgGbYcNCMSloCGMDlpbH = axisCalibrations;
			FzZHQoDaEFKBwlFIxxzubHbpNPv = new ReadOnlyCollection<AxisCalibration>(nhriWQPeWgGbYcNCMSloCGMDlpbH);
		}

		public void Reset()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return;
			}
			for (int i = 0; i < nhriWQPeWgGbYcNCMSloCGMDlpbH.Length; i++)
			{
				nhriWQPeWgGbYcNCMSloCGMDlpbH[i].Reset();
			}
		}

		public AxisCalibration GetAxis(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return null;
			}
			if (index < 0 || index >= nhriWQPeWgGbYcNCMSloCGMDlpbH.Length)
			{
				return null;
			}
			return nhriWQPeWgGbYcNCMSloCGMDlpbH[index];
		}

		public float GetCalibratedValue(int axisIndex, float value)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return 0f;
			}
			if (axisIndex < 0 || axisIndex >= nhriWQPeWgGbYcNCMSloCGMDlpbH.Length)
			{
				return value;
			}
			return nhriWQPeWgGbYcNCMSloCGMDlpbH[axisIndex].GetCalibratedValue(value);
		}

		public bool SetAxisData(int index, AxisCalibrationData data)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (index < 0 || index >= nhriWQPeWgGbYcNCMSloCGMDlpbH.Length)
			{
				return false;
			}
			nhriWQPeWgGbYcNCMSloCGMDlpbH[index].SetData(data);
			return true;
		}

		public AxisCalibrationData GetAxisData(int index)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return default(AxisCalibrationData);
			}
			if (index < 0 || index >= nhriWQPeWgGbYcNCMSloCGMDlpbH.Length)
			{
				return default(AxisCalibrationData);
			}
			return nhriWQPeWgGbYcNCMSloCGMDlpbH[index].GetData();
		}

		internal void CopyFrom(CalibrationMap map, bool copyHardwareDeadzone)
		{
			if (map == null)
			{
				return;
			}
			if (map.nhriWQPeWgGbYcNCMSloCGMDlpbH.Length != nhriWQPeWgGbYcNCMSloCGMDlpbH.Length)
			{
				Logger.LogError("Calibration map data does not match the number of elements in the hardware!");
				return;
			}
			for (int i = 0; i < nhriWQPeWgGbYcNCMSloCGMDlpbH.Length; i++)
			{
				nhriWQPeWgGbYcNCMSloCGMDlpbH[i].CopyFrom(map.nhriWQPeWgGbYcNCMSloCGMDlpbH[i], copyHardwareDeadzone);
			}
		}

		public string ToXmlString()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return string.Empty;
			}
			string empty = string.Empty;
			try
			{
				return KmsZJAaClfxbOKcqKGgeMqITFsc().ToXmlString(writeDocumentTag: true);
			}
			catch (Exception ex)
			{
				Logger.LogWarning("Error writing CalibrationMap to XML! " + ex.Message);
				return empty;
			}
		}

		public string ToJsonString()
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return string.Empty;
			}
			try
			{
				return KmsZJAaClfxbOKcqKGgeMqITFsc().ToJsonString();
			}
			catch (Exception ex)
			{
				Logger.LogWarning("Error writing CalibrationMap to JSON! " + ex.Message);
			}
			return string.Empty;
		}

		public bool ImportXmlString(string xmlString)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (string.IsNullOrEmpty(xmlString))
			{
				return false;
			}
			try
			{
				jzPtspnkZAgrKJfuKATzOhURnEB(SerializedObject.FromXml(GetType(), xmlString));
				return true;
			}
			catch (Exception ex)
			{
				Logger.LogWarning("Error creating CalibrationMap from XML! " + ex.Message);
			}
			return false;
		}

		public bool ImportJsonString(string jsonString)
		{
			if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
			{
				ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				return false;
			}
			if (string.IsNullOrEmpty(jsonString))
			{
				return false;
			}
			try
			{
				jzPtspnkZAgrKJfuKATzOhURnEB(SerializedObject.FromJson(GetType(), jsonString));
				return true;
			}
			catch (Exception ex)
			{
				Logger.LogWarning("Error creating CalibrationMap from JSON! " + ex.Message);
			}
			return false;
		}

		private SerializedObject KmsZJAaClfxbOKcqKGgeMqITFsc()
		{
			SerializedObject serializedObject = new SerializedObject(GetType(), SerializedObject.ObjectType.Object);
			serializedObject.Add("dataVersion", 4, SerializedObject.FieldOptions.ExculdeFromXml);
			serializedObject.xmlInfo = new SerializedObject.XmlInfo();
			serializedObject.xmlInfo.attributes.Add(new SerializedObject.XmlInfo.kwLxndskJikCtPGLslSPWsTXCTW
			{
				FaRCzmOJYwGVoyOIjhyHpMferPo = "dataVersion",
				foSRcEqSuRsWnadDiKcGnhBewOU = 4.ToString()
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
				foSRcEqSuRsWnadDiKcGnhBewOU = string.Format("{0} {1}{2}{3}{4}{5}", "http://guavaman.com/rewired", "http://guavaman.com/schemas/rewired/", "1.3", "/", GetType().Name, ".xsd")
			});
			List<object> list = new List<object>();
			serializedObject.Add("axes", list);
			int num = ((nhriWQPeWgGbYcNCMSloCGMDlpbH != null) ? nhriWQPeWgGbYcNCMSloCGMDlpbH.Length : 0);
			for (int i = 0; i < num; i++)
			{
				if (nhriWQPeWgGbYcNCMSloCGMDlpbH[i] != null)
				{
					list.Add(nhriWQPeWgGbYcNCMSloCGMDlpbH[i].ExportData());
				}
			}
			return serializedObject;
		}

		private void jzPtspnkZAgrKJfuKATzOhURnEB(SerializedObject P_0)
		{
			SerializedObject value = null;
			if (!P_0.TryGetDeserializedValueByRef("axes", ref value))
			{
				return;
			}
			int num = MathTools.Min(value.count, nhriWQPeWgGbYcNCMSloCGMDlpbH.Length);
			for (int i = 0; i < num; i++)
			{
				if (value[i].value is SerializedObject && nhriWQPeWgGbYcNCMSloCGMDlpbH[i] != null)
				{
					nhriWQPeWgGbYcNCMSloCGMDlpbH[i].Import((SerializedObject)value[i].value);
				}
			}
		}

		internal Vector2 GetCalibrated2DValue(int xAxisIndex, int yAxisIndex, float valueRawX, float valueRawY, DeadZone2DType deadZoneType, AxisSensitivity2DType sensitivityType)
		{
			return Axis2DCalibration.GetCalibrated2DValue(valueRawX, valueRawY, GetAxis(xAxisIndex), GetAxis(yAxisIndex), deadZoneType, sensitivityType);
		}
	}
}
