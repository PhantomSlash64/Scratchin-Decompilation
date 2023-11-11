using System;
using Rewired.ControllerExtensions;
using Rewired.Drivers.Interfaces;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired.HID.Drivers
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal class DualShock4Driver : HIDDeviceDriver, IDisposable, IControllerDriver, IDriver_DualShock4
	{
		private enum yKEldgOylrWCXofhKisiajOhUCnM
		{
			PYBETkQVsRmUDiCvIHprMAIKEVN = 0,
			zdZvHrngnxPnydNyOxhmBTPWOLk = 1,
			vMFCHhhISrvmOsmZnghClToXZSS = 2
		}

		private enum kkhRRYuUVqtFCGhfmfvYajpVdcuK
		{
			fUyeeVFhkdEderlnmYYFoAwmZEL = 0,
			JiqnlfEwZFKahPPMCwySfgXJlyA = 1,
			zdZvHrngnxPnydNyOxhmBTPWOLk = 2
		}

		private const float fAnQUbmJRsnMDHyPxSlZlCPQKiC = 4f;

		private const int MIYoAXxJmUicNKAfsvlLFppMumFk = 14;

		private const int KGXAwTBqaMzAmTivodqkAYRbDzuo = 2;

		private const int sjWzDmmmlvYndNomDxZoXVAvXRa = 0;

		private const int YLLzrzgsMWVkHUCDWErxpZmhQHS = 1912;

		private const int wusiocqsXWCHBgZXAcpyJjekeMU = 0;

		private const int BFkHXeFVMEpovARCffxdMMGLMBVE = 941;

		private const bool bNueAXYhbECkvWmBmJdSrPQKWoA = false;

		private const bool rgyFlbpqLwehVYNrECSrufTJXOE = true;

		private const float BcUxMdfNITaYMCwZWcyYcqZejFH = 2.5f;

		private const int lpYmUlPKNtZvXynjTnarNmRjsgE = 0;

		private const int vXBXsHyacAADNjevARvQDZdcPoOK = 0;

		private const int YVfWHLbbbqpyTggyCLjUvMEkNUN = 1;

		private const int fUOpjpBtGgJtLvPoUOCCBMYsnCW = 0;

		private const int tJfosfsBsMteZXEbbaHkoHMSgQM = 0;

		private const int vkDCbhfirsCfERGngbmPgWesNV = 0;

		private const int YtPUyXynaPtIXoVCJOzTGWmrcVq = 1;

		private const int qiLjTQzZKGzLHEcvTFzilmNlBsn = 17;

		private const int GHkAZOiKjzGcoLMeuyUnNTmUiFZ = 0;

		private const int lFOFkjGqNijMZrTXSWwLdmNDRBNp = 2;

		private const int PKYEjyctkhojSHCGysyHEfWkyuKu = 64;

		private const int TOlpwXgkbcLytYaBmXVOVJaQjWg = 78;

		private const int cFUkBGSVQQtlKKkoldOgPCDICbdJ = 1;

		private const int ZGGhvEKpERWmcuDXqklkWXaeVDR = 2;

		private const int KDcdhwwKDoXZuukpmjHLKhFJlao = 3;

		private const int KTZmcTHcfgtyyegHTcRippXTWPO = 4;

		private const int yABqcCoWAsPxRIQJDdBICtDxkdL = 8;

		private const int rmGjyjxSOMplcaZdKAbuJJRMOSz = 9;

		private const int jYmlJZAHFWMundOjzHzsqjBeCmG = 5;

		private const int hYzOcmnqnhvhqMbPeIOZnnljjsNA = 19;

		private const int BUEZhscAyODynSAXqbLmOlYVnzq = 13;

		private const int KXGscmwhMxFJfHkyEVFfLLYCqqhf = 35;

		private const int hnlHCYHWllpArmVFARKNAciknNn = 5;

		private const int OurGXDTqihdxczsgJKvQeoUWEdF = 6;

		private const int ayAGbmvwpzAsJosBzmlISVjJduk = 7;

		private const int MujHOqcJkzaOsqOhmsRZSKfHWsR = 10;

		private const int SoOeAsRGfVvccLmVxqIrkFJsiwcD = 30;

		private const int bgusmyjFBccBuvUHxxukcdjuTxw = 27;

		private const byte YvexETfkOPlCxvOnptEUjYApfyZ = 200;

		private const byte sObZGkLBqwpCAYroaEjllItiuZN = 53;

		private const byte HXreXosYbxyrCdtpAKFfGqXygCw = byte.MaxValue;

		private const byte UunrZGCTwsgKFyxgLjucHEqsLmw = 0;

		private const bool cAWAMQbjlYYsCYiKEnQZnuruMhR = true;

		private const int JWpHhhXPsItCXNqNSQGUbCSMzFC = 25;

		private const int hjXOGBgAHYshNJHXFCuPCDgWFYK = 187500;

		private const float yVxHbGDrZNDnUcQSpEJfjzsXYFR = 8192f;

		private const float IdvEgopDtSUEpnkeznDGLvyqaWr = 3.4971635f;

		private const float IWPVJfuddteRHowFTbQgYpDebwDi = 0.06103702f;

		private const bool LKOdBLGRQAlgdFKYeLCuCrRAerg = true;

		private const bool hgxZnghVDRJciuDgDzaKyrVghZN = true;

		private const bool HOskqCViKznyXoKEBHJLvksgYyt = true;

		private const bool NTJWoEnycRUkjrAGuzGbVIhmajj = true;

		private const float xyWWXVSOTnFFNXcOaaiQUDYCFckJ = 4096f;

		private const float IQtPDoMzoJPoLnTUfXtOKNOFya = 16384f;

		private const float VmXFnHdugwVsRarQQwmKFAjcrBr = 16777216f;

		private const float WfCEAdgjtUesjJRuSvKwSWXChzX = 268435460f;

		private const float iXyirunBsMFttAKipZmSWNobOFQ = 0.01999998f;

		private const float bxexnvbZgOUQKOpOKBHPoVbldXZ = 8192f;

		private const float yPkmWIatQiOjghELmaBADImFvl = 0.98f;

		private const float vbsHNmjkBEHSQeueneafLiNIItJz = 45f;

		private const float YxIwoCJdPidmAGRbxiNkHGMKtbX = 20f;

		private readonly bool uiKzFbJoKSboUzaXcUnWBjVZohw;

		private readonly DeviceConnectionType evvaxufzZtJqFcXXIoQmmRnAGEj;

		private readonly int titCGPAhtGLjnUzZCINhLpGTmLKa;

		private readonly int pFFJxSfqRRHMXZRaWOvHspMIcTKg;

		private readonly bool lYFaFOelZuFeZlIpiioSSRMTCErC;

		private readonly byte kURiGkcrCHBxPShdHOvkCGvRAtd;

		private readonly int ajCHMgCEAbaEkFVJkaIPaoVfCr;

		private readonly int GZBrnJXSggJRlcoPFfoEWSvhIVX;

		private readonly int eesFGtJZTKWMgolXXnmdFnmGlLy;

		private readonly int gyrGKnIaWDciwbatYfdjGsjeTgAe;

		private readonly int hbFeyMARHWWaTLgXbdzzyYNOBkv;

		private readonly int ByAsKVJlZQcUCKRxrRLQxmxbeYL;

		private readonly NativeBuffer QGuGsnXIgcCjxddpnmSxdBwnGvlq;

		private readonly NativeBuffer LcLlGDTUOBwsDSCppZCbNWXyzac;

		private readonly OutputReport WsUfyCCtUNweMPHwXAqResAQpPKF;

		private readonly Func<OutputReport, bool> cFzyrmqlmvtEuXUQstBuFKbWFVj;

		private readonly Action<OutputReport> XrxEIkNzgjhXQNIGpeBExQGePGz;

		private readonly GetHidFeatureData cQqOeEIrTVTeRsZuQavKJDknxky;

		private bool JhfGDIhIgxEkFUyBTCYpkYbVqPau;

		private bool BbDHEMJExvhXNYfPyMgEWPklvwM;

		private double qiPfmrSXAYJwIZrEvRCsHYmQaqt;

		private byte KgsBMivUuHvQAhTlLaIKubLmlmc;

		private Quaternion tcLHyjngGbFRCpVKAwhiMCXqOMa = Quaternion.identity;

		private ushort OSZQlQOayoPaBhNvIAxMfOKyobDv;

		private float rWsbBCdkKvnqEKLyfqwadYaYPqEE;

		private double nXuDzJHigpgKfWDUSmPieCouQiTh;

		private float IzQPnSODdaaTdTtPRjlugJNmInTx;

		private byte ymhXBrxUDwZnQKtWDxnfiYMxWGv;

		private byte DmNzlERKQvJlyStVMQSkcueSKGS;

		private Quaternion zUQvAuywiiSfbcBZJtcIOeaZjRhG = Quaternion.identity;

		private Quaternion sVglbvdaHNuJinfczFazCBUVNue = Quaternion.identity;

		private bool qslTxvSpkokQhrECYhufvLxMbaxF;

		private int nonrmQsqeMxNsKbrZrakOInVIbb;

		private int[] xlPNDaCeygxALryAJwxogoQEIjL = new int[2];

		private int[] OQeQvUmgoaBjloPCeNsDqsBCBrU = new int[2];

		private bool isVibrating
		{
			get
			{
				for (int i = 0; i < base.VibrationMotorCount; i++)
				{
					if (vibrationMotors[i].SpeedRaw > 0)
					{
						return true;
					}
				}
				return false;
			}
		}

		public float BatteryLevel
		{
			get
			{
				float num = 0f;
				num = ((!uiKzFbJoKSboUzaXcUnWBjVZohw) ? ((float)(KgsBMivUuHvQAhTlLaIKubLmlmc - 1) * 10f) : ((float)(KgsBMivUuHvQAhTlLaIKubLmlmc + 2) * 10f));
				return MathTools.Clamp(num, 0f, 100f);
			}
		}

		public float LeftMotor
		{
			get
			{
				return vibrationMotors[0].Speed;
			}
			set
			{
				vibrationMotors[0].Speed = value;
			}
		}

		public float RightMotor
		{
			get
			{
				return vibrationMotors[1].Speed;
			}
			set
			{
				vibrationMotors[1].Speed = value;
			}
		}

		public float LightColorR
		{
			get
			{
				return lights[0].ColorR;
			}
			set
			{
				lights[0].ColorR = value;
			}
		}

		public float LightColorG
		{
			get
			{
				return lights[0].ColorG;
			}
			set
			{
				lights[0].ColorG = value;
			}
		}

		public float LightColorB
		{
			get
			{
				return lights[0].ColorB;
			}
			set
			{
				lights[0].ColorB = value;
			}
		}

		public float LightFlashOnDuration
		{
			get
			{
				return (int)ymhXBrxUDwZnQKtWDxnfiYMxWGv;
			}
			set
			{
				ymhXBrxUDwZnQKtWDxnfiYMxWGv = (byte)MathTools.Clamp(MathTools.Clamp(value, 0f, 2.5f) * 100f, 0f, 255f);
				JhfGDIhIgxEkFUyBTCYpkYbVqPau = true;
				if (ymhXBrxUDwZnQKtWDxnfiYMxWGv == 0 && DmNzlERKQvJlyStVMQSkcueSKGS == 0)
				{
					BbDHEMJExvhXNYfPyMgEWPklvwM = true;
				}
			}
		}

		public float LightFlashOffDuration
		{
			get
			{
				return (int)DmNzlERKQvJlyStVMQSkcueSKGS;
			}
			set
			{
				DmNzlERKQvJlyStVMQSkcueSKGS = (byte)MathTools.Clamp(MathTools.Clamp(value, 0f, 2.5f) * 100f, 0f, 255f);
				JhfGDIhIgxEkFUyBTCYpkYbVqPau = true;
				if (ymhXBrxUDwZnQKtWDxnfiYMxWGv == 0 && DmNzlERKQvJlyStVMQSkcueSKGS == 0)
				{
					BbDHEMJExvhXNYfPyMgEWPklvwM = true;
				}
			}
		}

		public Vector3 AccelerometerValue => CLuukNAEFqxQWqhizEBDQusnqWr(accelerometers[0].rawValue);

		public Vector3 AccelerometerValueRaw => new Vector3(accelerometers[0].rawValue[0], accelerometers[0].rawValue[1], accelerometers[0].rawValue[2]);

		public Vector3 GyroscopeValue => KZgkGkZwHwNjQThWMeHENsQzDft(gyroscopes[0].events);

		public Vector3 GyroscopeValueRaw => new Vector3(gyroscopes[0].rawValue[0], gyroscopes[0].rawValue[1], gyroscopes[0].rawValue[2]);

		public Vector3 LastGyroscopeValue
		{
			get
			{
				Vector3 vector = new Vector3(gyroscopes[0].lastRawValue[0], gyroscopes[0].lastRawValue[1], gyroscopes[0].lastRawValue[2]);
				return KZgkGkZwHwNjQThWMeHENsQzDft(vector, rWsbBCdkKvnqEKLyfqwadYaYPqEE);
			}
		}

		public Vector3 LastGyroscopeValueRaw => new Vector3(gyroscopes[0].lastRawValue[0], gyroscopes[0].lastRawValue[1], gyroscopes[0].lastRawValue[2]);

		public Quaternion Orientation => tcLHyjngGbFRCpVKAwhiMCXqOMa;

		public int MaxTouches => 2;

		public void ResetOrientation()
		{
			tcLHyjngGbFRCpVKAwhiMCXqOMa = Quaternion.identity;
			qslTxvSpkokQhrECYhufvLxMbaxF = false;
		}

		public int GetTouchCount()
		{
			int num = 0;
			for (int i = 0; i < 2; i++)
			{
				if (touchpads[0].values[i].isTouching)
				{
					num++;
				}
			}
			return num;
		}

		public bool IsTouchingAtIndex(int index)
		{
			if (index < 0 || index >= 2)
			{
				return false;
			}
			return touchpads[0].values[index].isTouching;
		}

		public bool IsTouchingAtTouchId(int touchId)
		{
			return touchpads[0].IsTouching(touchId);
		}

		public int GetTouchIdAtIndex(int index)
		{
			if (index < 0 || index >= 2)
			{
				return -1;
			}
			return touchpads[0].values[index].touchId;
		}

		public bool GetTouchPositionByIndex(int index, out Vector2 position)
		{
			position = default(Vector2);
			if (index < 0 || index >= 2)
			{
				return false;
			}
			HIDTouchpad.TouchData[] values = touchpads[0].values;
			if (!values[index].isTouching)
			{
				return false;
			}
			position.x = values[index].positionX;
			position.y = values[index].positionY;
			return true;
		}

		public bool GetTouchPositionByTouchId(int touchId, out Vector2 position)
		{
			position = default(Vector2);
			if (!touchpads[0].IsTouching(touchId))
			{
				return false;
			}
			HIDTouchpad.TouchData[] values = touchpads[0].values;
			for (int i = 0; i < values.Length; i++)
			{
				if (values[i].isTouching)
				{
					position.x = values[i].positionX;
					position.y = values[i].positionY;
				}
			}
			return true;
		}

		public bool GetTouchPositionAbsoluteByIndex(int index, out int positionX, out int positionY)
		{
			positionX = 0;
			positionY = 0;
			if (index < 0 || index >= 2)
			{
				return false;
			}
			HIDTouchpad.TouchData[] values = touchpads[0].values;
			if (!values[index].isTouching)
			{
				return false;
			}
			positionX = values[index].positionAbsX;
			positionY = values[index].positionAbsY;
			return true;
		}

		public bool GetTouchPositionAbsoluteByTouchId(int touchId, out int positionX, out int positionY)
		{
			positionX = 0;
			positionY = 0;
			if (!touchpads[0].IsTouching(touchId))
			{
				return false;
			}
			HIDTouchpad.TouchData[] values = touchpads[0].values;
			for (int i = 0; i < values.Length; i++)
			{
				if (values[i].isTouching)
				{
					positionX = values[i].positionAbsX;
					positionY = values[i].positionAbsY;
				}
			}
			return true;
		}

		public void StopLightFlash()
		{
			ymhXBrxUDwZnQKtWDxnfiYMxWGv = 0;
			DmNzlERKQvJlyStVMQSkcueSKGS = 0;
			JhfGDIhIgxEkFUyBTCYpkYbVqPau = true;
			BbDHEMJExvhXNYfPyMgEWPklvwM = true;
		}

		public void StopVibration()
		{
			int vibrationMotorCount = base.VibrationMotorCount;
			for (int i = 0; i < vibrationMotorCount; i++)
			{
				vibrationMotors[i].SpeedRaw = 0;
			}
		}

		public DualShock4Driver(InitArgs initArgs)
		{
			if (initArgs == null)
			{
				throw new ArgumentNullException("initArgs");
			}
			titCGPAhtGLjnUzZCINhLpGTmLKa = initArgs.hatZeroValue;
			pFFJxSfqRRHMXZRaWOvHspMIcTKg = initArgs.hatSpan;
			ajCHMgCEAbaEkFVJkaIPaoVfCr = initArgs.inputReportLength;
			GZBrnJXSggJRlcoPFfoEWSvhIVX = initArgs.outputReportLength;
			cFzyrmqlmvtEuXUQstBuFKbWFVj = initArgs.synchronousWriteOutputReportDelegate;
			XrxEIkNzgjhXQNIGpeBExQGePGz = initArgs.asynchronousWriteOutputReportDelegate;
			cQqOeEIrTVTeRsZuQavKJDknxky = initArgs.getFeatureReportDelegate;
			evvaxufzZtJqFcXXIoQmmRnAGEj = initArgs.connectionType;
			uiKzFbJoKSboUzaXcUnWBjVZohw = evvaxufzZtJqFcXXIoQmmRnAGEj == DeviceConnectionType.CabkzYmwkSoeZRQBHEfOFiOxqlo;
			if (uiKzFbJoKSboUzaXcUnWBjVZohw)
			{
				GZBrnJXSggJRlcoPFfoEWSvhIVX = 78;
			}
			if (GZBrnJXSggJRlcoPFfoEWSvhIVX < 23)
			{
				GZBrnJXSggJRlcoPFfoEWSvhIVX = 23;
			}
			QGuGsnXIgcCjxddpnmSxdBwnGvlq = new NativeBuffer(64);
			LcLlGDTUOBwsDSCppZCbNWXyzac = new NativeBuffer(GZBrnJXSggJRlcoPFfoEWSvhIVX);
			WsUfyCCtUNweMPHwXAqResAQpPKF = new OutputReport(LcLlGDTUOBwsDSCppZCbNWXyzac.Pointer, LcLlGDTUOBwsDSCppZCbNWXyzac.Length, GZBrnJXSggJRlcoPFfoEWSvhIVX);
			lights = new HIDLight[1]
			{
				new HIDLight(11, 24, 28)
			};
			lights[0].ValueChangedEvent += gbmmmgjVZjTAevexHcPGeQfwTxS;
			vibrationMotors = new HIDVibrationMotor[2]
			{
				new HIDVibrationMotor(0, 255),
				new HIDVibrationMotor(0, 255)
			};
			vibrationMotors[0].ValueChangedEvent += gbmmmgjVZjTAevexHcPGeQfwTxS;
			vibrationMotors[1].ValueChangedEvent += gbmmmgjVZjTAevexHcPGeQfwTxS;
			if (uiKzFbJoKSboUzaXcUnWBjVZohw)
			{
				WsUfyCCtUNweMPHwXAqResAQpPKF.options |= OutputReportOptions.SSvSDRDYezVnraRZAICkShhcePQ;
				lYFaFOelZuFeZlIpiioSSRMTCErC = true;
				lYFaFOelZuFeZlIpiioSSRMTCErC = iwMqjybkvSNZHbRhqjokBiVDksQ(uvxRrkvDupzxBQCtimfuNwvaThC.XzNISeVEiyPbcvzNpmDUJzSWeUO);
				if (!lYFaFOelZuFeZlIpiioSSRMTCErC)
				{
					WsUfyCCtUNweMPHwXAqResAQpPKF.options &= ~OutputReportOptions.SSvSDRDYezVnraRZAICkShhcePQ;
				}
			}
			else
			{
				lYFaFOelZuFeZlIpiioSSRMTCErC = true;
				lYFaFOelZuFeZlIpiioSSRMTCErC = iwMqjybkvSNZHbRhqjokBiVDksQ(uvxRrkvDupzxBQCtimfuNwvaThC.XzNISeVEiyPbcvzNpmDUJzSWeUO);
			}
			if (!lYFaFOelZuFeZlIpiioSSRMTCErC)
			{
				throw new Exception("Special features not supported so just treat this as a standard HID device.");
			}
			kURiGkcrCHBxPShdHOvkCGvRAtd = 1;
			eesFGtJZTKWMgolXXnmdFnmGlLy = 0;
			if (uiKzFbJoKSboUzaXcUnWBjVZohw && lYFaFOelZuFeZlIpiioSSRMTCErC)
			{
				kURiGkcrCHBxPShdHOvkCGvRAtd = 17;
				eesFGtJZTKWMgolXXnmdFnmGlLy = 2;
			}
			gyrGKnIaWDciwbatYfdjGsjeTgAe = 5 + eesFGtJZTKWMgolXXnmdFnmGlLy;
			hbFeyMARHWWaTLgXbdzzyYNOBkv = 6 + eesFGtJZTKWMgolXXnmdFnmGlLy;
			ByAsKVJlZQcUCKRxrRLQxmxbeYL = 7 + eesFGtJZTKWMgolXXnmdFnmGlLy;
			buttons = new HIDButton[14];
			for (int i = 0; i < 14; i++)
			{
				buttons[i] = new HIDButton(kURiGkcrCHBxPShdHOvkCGvRAtd, new HIDControllerElement.HIDInfo
				{
					usagePage = 9,
					usage = (ushort)i
				});
			}
			axes = new HIDAxis[6]
			{
				new HIDAxis(kURiGkcrCHBxPShdHOvkCGvRAtd, new HIDControllerElement.HIDInfo
				{
					usagePage = 1,
					usage = 48,
					dataIndex = 1 + eesFGtJZTKWMgolXXnmdFnmGlLy,
					bitSize = 8,
					logicalMin = 0,
					logicalMax = 255,
					physicalMin = 0,
					physicalMax = 0,
					units = 0u,
					unitsExp = 0u
				}, isSigned: false, 127),
				new HIDAxis(kURiGkcrCHBxPShdHOvkCGvRAtd, new HIDControllerElement.HIDInfo
				{
					usagePage = 1,
					usage = 49,
					dataIndex = 2 + eesFGtJZTKWMgolXXnmdFnmGlLy,
					bitSize = 8,
					logicalMin = 0,
					logicalMax = 255,
					physicalMin = 0,
					physicalMax = 0,
					units = 0u,
					unitsExp = 0u
				}, isSigned: false, 127),
				new HIDAxis(kURiGkcrCHBxPShdHOvkCGvRAtd, new HIDControllerElement.HIDInfo
				{
					usagePage = 1,
					usage = 50,
					dataIndex = 3 + eesFGtJZTKWMgolXXnmdFnmGlLy,
					bitSize = 8,
					logicalMin = 0,
					logicalMax = 255,
					physicalMin = 0,
					physicalMax = 0,
					units = 0u,
					unitsExp = 0u
				}, isSigned: false, 127),
				new HIDAxis(kURiGkcrCHBxPShdHOvkCGvRAtd, new HIDControllerElement.HIDInfo
				{
					usagePage = 1,
					usage = 53,
					dataIndex = 4 + eesFGtJZTKWMgolXXnmdFnmGlLy,
					bitSize = 8,
					logicalMin = 0,
					logicalMax = 255,
					physicalMin = 0,
					physicalMax = 0,
					units = 0u,
					unitsExp = 0u
				}, isSigned: false, 127),
				new HIDAxis(kURiGkcrCHBxPShdHOvkCGvRAtd, new HIDControllerElement.HIDInfo
				{
					usagePage = 1,
					usage = 51,
					dataIndex = 8 + eesFGtJZTKWMgolXXnmdFnmGlLy,
					bitSize = 8,
					logicalMin = 0,
					logicalMax = 255,
					physicalMin = 0,
					physicalMax = 315,
					units = 0u,
					unitsExp = 0u
				}, isSigned: false, 0),
				new HIDAxis(kURiGkcrCHBxPShdHOvkCGvRAtd, new HIDControllerElement.HIDInfo
				{
					usagePage = 1,
					usage = 52,
					dataIndex = 9 + eesFGtJZTKWMgolXXnmdFnmGlLy,
					bitSize = 8,
					logicalMin = 0,
					logicalMax = 255,
					physicalMin = 0,
					physicalMax = 315,
					units = 0u,
					unitsExp = 0u
				}, isSigned: false, 0)
			};
			hats = new HIDHat[1]
			{
				new HIDHat(kURiGkcrCHBxPShdHOvkCGvRAtd, new HIDControllerElement.HIDInfo
				{
					usagePage = 1,
					usage = 57,
					dataIndex = 5 + eesFGtJZTKWMgolXXnmdFnmGlLy,
					bitSize = 4,
					logicalMin = 0,
					logicalMax = 7,
					physicalMin = 0,
					physicalMax = 315,
					units = 20u,
					unitsExp = 0u
				}, aTfSxYWEaMURzfutCXjUZKOsbuv)
			};
			accelerometers = new HIDAccelerometer[1]
			{
				new HIDAccelerometer(kURiGkcrCHBxPShdHOvkCGvRAtd, new HIDControllerElement.HIDInfo
				{
					usagePage = 1,
					dataIndex = 19 + eesFGtJZTKWMgolXXnmdFnmGlLy,
					bitSize = 48
				}, 3, cGDbKvxxnAEUJFJOUujzTgpdpbzd)
			};
			gyroscopes = new HIDGyroscope[1]
			{
				new HIDGyroscope(initArgs.updateLoopSetting, kURiGkcrCHBxPShdHOvkCGvRAtd, new HIDControllerElement.HIDInfo
				{
					usagePage = 1,
					dataIndex = 13 + eesFGtJZTKWMgolXXnmdFnmGlLy,
					bitSize = 48
				}, 3, 25, rFWDEkCGCqNdrAPKIoqaczvZRyQY, uCDIPOdKTtJysOUFJrjBxacBtMTA)
			};
			touchpads = new HIDTouchpad[1]
			{
				new HIDTouchpad(kURiGkcrCHBxPShdHOvkCGvRAtd, new HIDTouchpad.TouchpadInfo(2, 0, 1912, 0, 941, invertY: false, reverseY: true), new HIDControllerElement.HIDInfo
				{
					usagePage = 1,
					dataIndex = 35 + eesFGtJZTKWMgolXXnmdFnmGlLy,
					bitSize = 48
				}, xwBjFEKpyceIRCTgTwzlbpwQkqQj)
			};
			nXuDzJHigpgKfWDUSmPieCouQiTh = ReInput.realTime;
		}

		public override void Update(UpdateLoopType updateLoop)
		{
			ThjORACJeVUQygdKrSUlHeQdqHO();
			QGmbNfcVjGqGwflsfMHYdFHKFtYW(uvxRrkvDupzxBQCtimfuNwvaThC.ldtYCLqxGeJIHbodYJKZpPapKnP);
		}

		public override bool ParseInputReport(IntPtr inputReportPtr, int inputReportLength, double timestamp)
		{
			if (inputReportPtr == IntPtr.Zero)
			{
				return false;
			}
			if (inputReportLength < QGuGsnXIgcCjxddpnmSxdBwnGvlq.Length)
			{
				return false;
			}
			IzQPnSODdaaTdTtPRjlugJNmInTx = (float)(timestamp - nXuDzJHigpgKfWDUSmPieCouQiTh);
			nXuDzJHigpgKfWDUSmPieCouQiTh = timestamp;
			QGuGsnXIgcCjxddpnmSxdBwnGvlq.Write(inputReportPtr, inputReportLength, QGuGsnXIgcCjxddpnmSxdBwnGvlq.Length);
			SKgYlBYSJtBfgLhVgEwpCiSPPJlh(QGuGsnXIgcCjxddpnmSxdBwnGvlq);
			ZoEfBvZLEHeQeEqRqOmhOcalkaSu(QGuGsnXIgcCjxddpnmSxdBwnGvlq, timestamp);
			dYCOUXQdfDEyXLlepJqLclKkytx(axes, QGuGsnXIgcCjxddpnmSxdBwnGvlq, timestamp);
			dYCOUXQdfDEyXLlepJqLclKkytx(hats, QGuGsnXIgcCjxddpnmSxdBwnGvlq, timestamp);
			dYCOUXQdfDEyXLlepJqLclKkytx(accelerometers, QGuGsnXIgcCjxddpnmSxdBwnGvlq, timestamp);
			dYCOUXQdfDEyXLlepJqLclKkytx(gyroscopes, QGuGsnXIgcCjxddpnmSxdBwnGvlq, timestamp);
			dYCOUXQdfDEyXLlepJqLclKkytx(touchpads, QGuGsnXIgcCjxddpnmSxdBwnGvlq, timestamp);
			KgsBMivUuHvQAhTlLaIKubLmlmc = (byte)(QGuGsnXIgcCjxddpnmSxdBwnGvlq[30 + eesFGtJZTKWMgolXXnmdFnmGlLy] & 0xFu);
			YLjqWGoPsWiVnPihFhvobjAaPsCH();
			return true;
		}

		public override Controller.Extension CreateControllerExtension()
		{
			return new DualShock4Extension(this);
		}

		private void QGmbNfcVjGqGwflsfMHYdFHKFtYW(uvxRrkvDupzxBQCtimfuNwvaThC P_0)
		{
			if (JhfGDIhIgxEkFUyBTCYpkYbVqPau)
			{
				iwMqjybkvSNZHbRhqjokBiVDksQ(P_0);
				JhfGDIhIgxEkFUyBTCYpkYbVqPau = false;
			}
		}

		private bool iwMqjybkvSNZHbRhqjokBiVDksQ(uvxRrkvDupzxBQCtimfuNwvaThC P_0)
		{
			TpYdLaDAdEbsrsdUAjYxaGibFJIm();
			bool result = ilmlrpVSNPjsnOgsPZdTIfpNGQY(P_0);
			if (BbDHEMJExvhXNYfPyMgEWPklvwM)
			{
				result = ilmlrpVSNPjsnOgsPZdTIfpNGQY(P_0);
				BbDHEMJExvhXNYfPyMgEWPklvwM = false;
			}
			return result;
		}

		private void TpYdLaDAdEbsrsdUAjYxaGibFJIm()
		{
			if (uiKzFbJoKSboUzaXcUnWBjVZohw && lYFaFOelZuFeZlIpiioSSRMTCErC)
			{
				LcLlGDTUOBwsDSCppZCbNWXyzac[0] = 17;
				LcLlGDTUOBwsDSCppZCbNWXyzac[1] = 128;
				LcLlGDTUOBwsDSCppZCbNWXyzac[3] = byte.MaxValue;
				LcLlGDTUOBwsDSCppZCbNWXyzac[6] = (byte)vibrationMotors[1].SpeedRaw;
				LcLlGDTUOBwsDSCppZCbNWXyzac[7] = (byte)vibrationMotors[0].SpeedRaw;
				LcLlGDTUOBwsDSCppZCbNWXyzac[8] = lights[0].ColorRRaw;
				LcLlGDTUOBwsDSCppZCbNWXyzac[9] = lights[0].ColorGRaw;
				LcLlGDTUOBwsDSCppZCbNWXyzac[10] = lights[0].ColorBRaw;
				LcLlGDTUOBwsDSCppZCbNWXyzac[11] = ymhXBrxUDwZnQKtWDxnfiYMxWGv;
				LcLlGDTUOBwsDSCppZCbNWXyzac[12] = DmNzlERKQvJlyStVMQSkcueSKGS;
				LcLlGDTUOBwsDSCppZCbNWXyzac[21] = 53;
				LcLlGDTUOBwsDSCppZCbNWXyzac[22] = 53;
				LcLlGDTUOBwsDSCppZCbNWXyzac[23] = byte.MaxValue;
				LcLlGDTUOBwsDSCppZCbNWXyzac[24] = 0;
			}
			else
			{
				LcLlGDTUOBwsDSCppZCbNWXyzac[0] = 5;
				LcLlGDTUOBwsDSCppZCbNWXyzac[1] = byte.MaxValue;
				LcLlGDTUOBwsDSCppZCbNWXyzac[4] = (byte)vibrationMotors[1].SpeedRaw;
				LcLlGDTUOBwsDSCppZCbNWXyzac[5] = (byte)vibrationMotors[0].SpeedRaw;
				LcLlGDTUOBwsDSCppZCbNWXyzac[6] = lights[0].ColorRRaw;
				LcLlGDTUOBwsDSCppZCbNWXyzac[7] = lights[0].ColorGRaw;
				LcLlGDTUOBwsDSCppZCbNWXyzac[8] = lights[0].ColorBRaw;
				LcLlGDTUOBwsDSCppZCbNWXyzac[9] = ymhXBrxUDwZnQKtWDxnfiYMxWGv;
				LcLlGDTUOBwsDSCppZCbNWXyzac[10] = DmNzlERKQvJlyStVMQSkcueSKGS;
				LcLlGDTUOBwsDSCppZCbNWXyzac[19] = 53;
				LcLlGDTUOBwsDSCppZCbNWXyzac[20] = 53;
				LcLlGDTUOBwsDSCppZCbNWXyzac[21] = byte.MaxValue;
				LcLlGDTUOBwsDSCppZCbNWXyzac[22] = 0;
			}
		}

		private bool ilmlrpVSNPjsnOgsPZdTIfpNGQY(uvxRrkvDupzxBQCtimfuNwvaThC P_0)
		{
			qiPfmrSXAYJwIZrEvRCsHYmQaqt = ReInput.realTime + 4.0;
			switch (P_0)
			{
			case uvxRrkvDupzxBQCtimfuNwvaThC.XzNISeVEiyPbcvzNpmDUJzSWeUO:
				if (cFzyrmqlmvtEuXUQstBuFKbWFVj == null)
				{
					return false;
				}
				return cFzyrmqlmvtEuXUQstBuFKbWFVj(WsUfyCCtUNweMPHwXAqResAQpPKF);
			case uvxRrkvDupzxBQCtimfuNwvaThC.ldtYCLqxGeJIHbodYJKZpPapKnP:
				if (XrxEIkNzgjhXQNIGpeBExQGePGz == null)
				{
					return false;
				}
				XrxEIkNzgjhXQNIGpeBExQGePGz(WsUfyCCtUNweMPHwXAqResAQpPKF);
				return true;
			default:
				throw new NotImplementedException();
			}
		}

		private void ZoEfBvZLEHeQeEqRqOmhOcalkaSu(NativeBuffer P_0, double P_1)
		{
			byte b = P_0[gyrGKnIaWDciwbatYfdjGsjeTgAe];
			buttons[0].SetValue((b & 0x10) != 0, P_1);
			buttons[1].SetValue((b & 0x20) != 0, P_1);
			buttons[2].SetValue((b & 0x40) != 0, P_1);
			buttons[3].SetValue((b & 0x80) != 0, P_1);
			b = P_0[hbFeyMARHWWaTLgXbdzzyYNOBkv];
			buttons[4].SetValue((b & 1) != 0, P_1);
			buttons[5].SetValue((b & 2) != 0, P_1);
			buttons[6].SetValue((b & 4) != 0, P_1);
			buttons[7].SetValue((b & 8) != 0, P_1);
			buttons[8].SetValue((b & 0x10) != 0, P_1);
			buttons[9].SetValue((b & 0x20) != 0, P_1);
			buttons[10].SetValue((b & 0x40) != 0, P_1);
			buttons[11].SetValue((b & 0x80) != 0, P_1);
			b = P_0[ByAsKVJlZQcUCKRxrRLQxmxbeYL];
			buttons[12].SetValue((b & 1) != 0, P_1);
			buttons[13].SetValue((b & 2) != 0, P_1);
		}

		private void dYCOUXQdfDEyXLlepJqLclKkytx(HIDControllerElement[] P_0, NativeBuffer P_1, double P_2)
		{
			for (int i = 0; i < P_0.Length; i++)
			{
				P_0[i].UpdateValue(P_1, P_2);
			}
		}

		private void ThjORACJeVUQygdKrSUlHeQdqHO()
		{
			if (isVibrating && ReInput.realTime >= qiPfmrSXAYJwIZrEvRCsHYmQaqt)
			{
				JhfGDIhIgxEkFUyBTCYpkYbVqPau = true;
			}
		}

		private void SKgYlBYSJtBfgLhVgEwpCiSPPJlh(NativeBuffer P_0)
		{
			if (lYFaFOelZuFeZlIpiioSSRMTCErC)
			{
				ushort num = QGuGsnXIgcCjxddpnmSxdBwnGvlq.ReadUShort(10 + eesFGtJZTKWMgolXXnmdFnmGlLy);
				float num3;
				if (num != OSZQlQOayoPaBhNvIAxMfOKyobDv)
				{
					int num2 = ((num >= OSZQlQOayoPaBhNvIAxMfOKyobDv) ? (num - OSZQlQOayoPaBhNvIAxMfOKyobDv) : (num + 65535 - OSZQlQOayoPaBhNvIAxMfOKyobDv));
					num3 = (float)num2 / 187500f;
				}
				else
				{
					int num2 = 0;
					num3 = 0f;
				}
				OSZQlQOayoPaBhNvIAxMfOKyobDv = num;
				rWsbBCdkKvnqEKLyfqwadYaYPqEE = num3;
			}
		}

		private void YLjqWGoPsWiVnPihFhvobjAaPsCH()
		{
			if (lYFaFOelZuFeZlIpiioSSRMTCErC)
			{
				_ = rWsbBCdkKvnqEKLyfqwadYaYPqEE;
				_ = 0f;
				Vector3 vector = KZgkGkZwHwNjQThWMeHENsQzDft(new Vector3(gyroscopes[0].lastRawValue[0], gyroscopes[0].lastRawValue[1], gyroscopes[0].lastRawValue[2]), rWsbBCdkKvnqEKLyfqwadYaYPqEE);
				jrweDkUzlvQsjurbncpauSjdBlh(ref vector);
				Vector3 vector2 = new Vector3(accelerometers[0].rawValue[0] * -1f, accelerometers[0].rawValue[1] * -1f, accelerometers[0].rawValue[2] * -1f);
				LHHkCjjiHeqehMCMwncpzxMmGFF(vector2, vector);
			}
		}

		private static bool jrweDkUzlvQsjurbncpauSjdBlh(ref Vector3 P_0)
		{
			if (P_0.magnitude < 0.004f)
			{
				P_0.x = 0f;
				P_0.y = 0f;
				P_0.z = 0f;
				return false;
			}
			return true;
		}

		private void LHHkCjjiHeqehMCMwncpzxMmGFF(Vector3 P_0, Vector3 P_1)
		{
			Quaternion quaternion = Quaternion.Euler(P_1);
			float sqrMagnitude = P_0.sqrMagnitude;
			if (sqrMagnitude > 16777216f && sqrMagnitude < 268435460f && gaeRkPxMveyUlucLIvkhJfHuVRy(P_0, out var kkhRRYuUVqtFCGhfmfvYajpVdcuK))
			{
				Quaternion a = tcLHyjngGbFRCpVKAwhiMCXqOMa * quaternion;
				if (!qslTxvSpkokQhrECYhufvLxMbaxF)
				{
					qslTxvSpkokQhrECYhufvLxMbaxF = true;
					zUQvAuywiiSfbcBZJtcIOeaZjRhG = Quaternion.identity * Quaternion.Euler(new Vector3(90f, 0f, 0f));
					sVglbvdaHNuJinfczFazCBUVNue = tcLHyjngGbFRCpVKAwhiMCXqOMa;
				}
				zUQvAuywiiSfbcBZJtcIOeaZjRhG *= quaternion;
				sVglbvdaHNuJinfczFazCBUVNue *= quaternion;
				Quaternion b;
				if ((kkhRRYuUVqtFCGhfmfvYajpVdcuK & kkhRRYuUVqtFCGhfmfvYajpVdcuK.JiqnlfEwZFKahPPMCwySfgXJlyA) != 0)
				{
					b = HBMwrtdQclvSKNvqlAdgHKRBgDK(P_0, a.eulerAngles.y);
				}
				else if ((kkhRRYuUVqtFCGhfmfvYajpVdcuK & kkhRRYuUVqtFCGhfmfvYajpVdcuK.zdZvHrngnxPnydNyOxhmBTPWOLk) != 0)
				{
					b = CIdPxXzdeMhdbgbZllPpNSHBiRD(P_0);
					Vector3 vector = sVglbvdaHNuJinfczFazCBUVNue * Vector3.right;
					float y = 0f - MathTools.SignedAngle(new Vector3(vector.x, 0f, vector.z), Vector3.right, Vector3.up);
					b = Quaternion.Euler(0f, y, 0f) * b;
				}
				else
				{
					b = Quaternion.identity;
				}
				tcLHyjngGbFRCpVKAwhiMCXqOMa = Quaternion.Lerp(a, b, 0.01999998f);
			}
			else
			{
				tcLHyjngGbFRCpVKAwhiMCXqOMa *= quaternion;
				if (qslTxvSpkokQhrECYhufvLxMbaxF)
				{
					qslTxvSpkokQhrECYhufvLxMbaxF = false;
				}
			}
		}

		private static Quaternion emySGAVgGdWfZnMKYdvrliuMDhe(Quaternion P_0, Vector3 P_1)
		{
			Vector3 vector = new Vector3(P_0.x, P_0.y, P_0.z);
			Vector3 vector2 = SycUkcXQJkybPobRUYYWKrEvRlo(vector, P_1);
			return new Quaternion(vector2.x, vector2.y, vector2.z, P_0.w);
		}

		private static Vector3 SycUkcXQJkybPobRUYYWKrEvRlo(Vector3 P_0, Vector3 P_1)
		{
			float num = Vector3.Dot(P_1, P_1);
			if (num < float.Epsilon)
			{
				return Vector3.zero;
			}
			return P_1 * Vector3.Dot(P_0, P_1) / num;
		}

		private Quaternion qsKTOVVzBpPEGbtIdyaJtdZDGcl(Quaternion P_0, yKEldgOylrWCXofhKisiajOhUCnM P_1)
		{
			Vector4 vector = default(Vector4);
			if (MathTools.Approximately(P_0.w, 0f) && MathTools.Approximately(P_0[(int)P_1], 0f))
			{
				P_0 = Quaternion.identity;
			}
			else
			{
				float num = P_0[(int)P_1];
				float num2 = MathTools.Sqrt(P_0.w * P_0.w + num * num);
				vector[3] = P_0.w / num2;
				vector[(int)P_1] = num / num2;
				P_0 = new Quaternion(vector[0], vector[1], vector[2], vector[3]);
			}
			return P_0;
		}

		public static Quaternion Inverse(Quaternion quaternion)
		{
			float num = quaternion.x * quaternion.x + quaternion.y * quaternion.y + quaternion.z * quaternion.z + quaternion.w * quaternion.w;
			float num2 = 1f / num;
			Quaternion result = default(Quaternion);
			result.x = (0f - quaternion.x) * num2;
			result.y = (0f - quaternion.y) * num2;
			result.z = (0f - quaternion.z) * num2;
			result.w = quaternion.w * num2;
			return result;
		}

		private float QNBYecGGhwtgCdGCGCBZFBksMBMv(float P_0, float P_1)
		{
			P_0 = MathTools.ClampAngle360(P_0);
			P_1 = MathTools.ClampAngle360(P_1);
			if (P_0 == P_1)
			{
				return 0f;
			}
			if (P_0 >= 180f)
			{
				P_0 -= 360f;
			}
			if (P_1 >= 180f)
			{
				P_1 -= 360f;
			}
			return P_0 - P_1;
		}

		private Vector3 UPvfYOFOqDJOBJVrkswLSgJrxHgF(Vector3 P_0, float P_1 = 0f)
		{
			float num = MathTools.Atan2(P_0.z, P_0.y);
			float x = MathTools.Sqrt(MathTools.Pow(P_0.y, 2f) + MathTools.Pow(P_0.z, 2f));
			float num2 = MathTools.Atan2(P_0.x, x);
			float x2 = num * 57.29578f + 180f;
			float z = (0f - num2) * 57.29578f;
			return new Vector3(x2, P_1, z);
		}

		private Quaternion HBMwrtdQclvSKNvqlAdgHKRBgDK(Vector3 P_0, float P_1 = 0f)
		{
			float num = MathTools.Atan2(P_0.z, P_0.y);
			float x = MathTools.Sqrt(MathTools.Pow(P_0.y, 2f) + MathTools.Pow(P_0.z, 2f));
			float num2 = MathTools.Atan2(P_0.x, x);
			float x2 = num * 57.29578f + 180f;
			float z = (0f - num2) * 57.29578f;
			return Quaternion.Euler(x2, P_1, z);
		}

		private Quaternion CIdPxXzdeMhdbgbZllPpNSHBiRD(Vector3 P_0, float P_1 = 0f)
		{
			float num = MathTools.Atan2(P_0.z, P_0.y);
			float x = MathTools.Sqrt(MathTools.Pow(P_0.y, 2f) + MathTools.Pow(P_0.z, 2f));
			float num2 = MathTools.Atan2(P_0.x, x);
			float x2 = num * 57.29578f + 180f;
			float z = (0f - num2) * 57.29578f;
			Quaternion quaternion = Quaternion.Euler(0f, 0f, z) * Quaternion.Euler(x2, 0f, 0f);
			if (P_1 != 0f)
			{
				return quaternion * Quaternion.Euler(0f, P_1, 0f);
			}
			return quaternion;
		}

		private float ejpQjpMhtjCqVeNEoISPkOujzgT(Vector3 P_0)
		{
			return MathTools.Atan2(P_0.x, P_0.z) * 57.29578f;
		}

		private bool xzOLaauyMGuRnieshqMVxOibUeE(float P_0)
		{
			if (P_0 >= 45f)
			{
				return P_0 <= 70f;
			}
			return false;
		}

		private bool gaeRkPxMveyUlucLIvkhJfHuVRy(Vector3 P_0, out kkhRRYuUVqtFCGhfmfvYajpVdcuK P_1)
		{
			P_0.Normalize();
			P_1 = kkhRRYuUVqtFCGhfmfvYajpVdcuK.fUyeeVFhkdEderlnmYYFoAwmZEL;
			bool result = false;
			if (UFrtjsXMsEdvofWUpsVUJDGdAwi(P_0))
			{
				result = true;
				P_1 |= kkhRRYuUVqtFCGhfmfvYajpVdcuK.JiqnlfEwZFKahPPMCwySfgXJlyA;
			}
			if (leFkEzdvofNxvZdGgSraGDfAdOoE(P_0))
			{
				result = true;
				P_1 |= kkhRRYuUVqtFCGhfmfvYajpVdcuK.zdZvHrngnxPnydNyOxhmBTPWOLk;
			}
			return result;
		}

		private bool UFrtjsXMsEdvofWUpsVUJDGdAwi(Vector3 P_0)
		{
			if (P_0.y > 0f)
			{
				return false;
			}
			if (Vector3.Angle(Vector3.down, P_0) > 45f)
			{
				return false;
			}
			return true;
		}

		private bool leFkEzdvofNxvZdGgSraGDfAdOoE(Vector3 P_0)
		{
			if (P_0.z < 0f)
			{
				return false;
			}
			if (Vector3.Angle(new Vector3(0f, 0f, 1f), P_0) > 20f)
			{
				return false;
			}
			return true;
		}

		private Vector3 CLuukNAEFqxQWqhizEBDQusnqWr(float[] P_0)
		{
			return new Vector3(P_0[0] * 0.00012207031f * -1f, P_0[1] * 0.00012207031f * -1f, P_0[2] * 0.00012207031f);
		}

		private Vector3 KZgkGkZwHwNjQThWMeHENsQzDft(ExpandableArray_DataContainer<HIDGyroscope.ePopPcSKOyxPfeOuQZJrekpiocw> P_0)
		{
			Vector3 result = default(Vector3);
			int count = P_0.Count;
			for (int i = 0; i < count; i++)
			{
				HIDGyroscope.ePopPcSKOyxPfeOuQZJrekpiocw ePopPcSKOyxPfeOuQZJrekpiocw = P_0[i];
				result += KZgkGkZwHwNjQThWMeHENsQzDft(ePopPcSKOyxPfeOuQZJrekpiocw.QRDpwPykAQowLDZXAdYlFwGxNGI, ePopPcSKOyxPfeOuQZJrekpiocw.nMELmVyDurcOmgrvmwRzYQUNdch);
			}
			return result;
		}

		private Vector3 KZgkGkZwHwNjQThWMeHENsQzDft(Vector3 P_0, float P_1)
		{
			P_0.x *= -1f;
			P_0.y *= -1f;
			return P_0 * 0.06103702f * P_1;
		}

		private Vector3 VBUULyubboDQxkgQfbKYmtbWgphq(Vector3 P_0)
		{
			P_0.x *= -1f;
			P_0.y *= -1f;
			return P_0 * 3.4971635f;
		}

		private int aTfSxYWEaMURzfutCXjUZKOsbuv(int P_0)
		{
			P_0 &= 0xF;
			return P_0;
		}

		private void cGDbKvxxnAEUJFJOUujzTgpdpbzd(byte[] P_0, float[] P_1)
		{
			P_1[0] = BitConverter.ToInt16(P_0, 0);
			P_1[1] = BitConverter.ToInt16(P_0, 2);
			P_1[2] = BitConverter.ToInt16(P_0, 4);
		}

		private void rFWDEkCGCqNdrAPKIoqaczvZRyQY(byte[] P_0, float[] P_1)
		{
			P_1[0] = BitConverter.ToInt16(P_0, 0);
			P_1[1] = BitConverter.ToInt16(P_0, 2);
			P_1[2] = BitConverter.ToInt16(P_0, 4);
		}

		private float uCDIPOdKTtJysOUFJrjBxacBtMTA()
		{
			return rWsbBCdkKvnqEKLyfqwadYaYPqEE;
		}

		private void xwBjFEKpyceIRCTgTwzlbpwQkqQj(NativeBuffer P_0, HIDTouchpad.TouchData[] P_1)
		{
			int num = 35 + eesFGtJZTKWMgolXXnmdFnmGlLy;
			int positionRawX = P_0[1 + num] + (P_0[2 + num] & 0xF) * 255;
			int positionRawY = ((P_0[2 + num] & 0xF0) >> 4) + P_0[3 + num] * 16;
			int positionRawX2 = P_0[5 + num] + (P_0[6 + num] & 0xF) * 255;
			int positionRawY2 = ((P_0[6 + num] & 0xF0) >> 4) + P_0[7 + num] * 16;
			byte b = P_0[num];
			bool flag = b < 128;
			byte b2 = P_0[num + 4];
			bool flag2 = b2 < 128;
			int num2 = b & 0x7F;
			int num3 = b2 & 0x7F;
			P_1[0].isTouching = flag;
			P_1[0].touchId = jekTauYZYfPDjFEMwqaCQyBNHsg(0, flag, num2);
			P_1[0].positionRawX = positionRawX;
			P_1[0].positionRawY = positionRawY;
			P_1[1].isTouching = flag2;
			P_1[1].touchId = jekTauYZYfPDjFEMwqaCQyBNHsg(1, flag2, num3);
			P_1[1].positionRawX = positionRawX2;
			P_1[1].positionRawY = positionRawY2;
		}

		private int jekTauYZYfPDjFEMwqaCQyBNHsg(int P_0, bool P_1, int P_2)
		{
			if (!P_1)
			{
				xlPNDaCeygxALryAJwxogoQEIjL[P_0] = -1;
				OQeQvUmgoaBjloPCeNsDqsBCBrU[P_0] = P_2;
				return -1;
			}
			if (P_2 != OQeQvUmgoaBjloPCeNsDqsBCBrU[P_0])
			{
				int num = nonrmQsqeMxNsKbrZrakOInVIbb;
				if (nonrmQsqeMxNsKbrZrakOInVIbb == int.MaxValue)
				{
					nonrmQsqeMxNsKbrZrakOInVIbb = 0;
				}
				else
				{
					nonrmQsqeMxNsKbrZrakOInVIbb++;
				}
				OQeQvUmgoaBjloPCeNsDqsBCBrU[P_0] = P_2;
				xlPNDaCeygxALryAJwxogoQEIjL[P_0] = num;
				return num;
			}
			return xlPNDaCeygxALryAJwxogoQEIjL[P_0];
		}

		private void gbmmmgjVZjTAevexHcPGeQfwTxS()
		{
			JhfGDIhIgxEkFUyBTCYpkYbVqPau = true;
		}

		~DualShock4Driver()
		{
			Dispose(disposing: false);
		}

		protected override void Dispose(bool disposing)
		{
			if (base.disposed)
			{
				return;
			}
			base.Dispose(disposing);
			if (disposing)
			{
				StopVibration();
				QGmbNfcVjGqGwflsfMHYdFHKFtYW(uvxRrkvDupzxBQCtimfuNwvaThC.XzNISeVEiyPbcvzNpmDUJzSWeUO);
				if (QGuGsnXIgcCjxddpnmSxdBwnGvlq != null)
				{
					QGuGsnXIgcCjxddpnmSxdBwnGvlq.Dispose();
				}
				if (LcLlGDTUOBwsDSCppZCbNWXyzac != null)
				{
					LcLlGDTUOBwsDSCppZCbNWXyzac.Dispose();
				}
			}
		}

		public static bool Matches(int vid, int pid)
		{
			for (int i = 0; i < Consts.pidVids_sony_dualShock4.Count; i++)
			{
				if (Consts.pidVids_sony_dualShock4[i].vendorId == vid && Consts.pidVids_sony_dualShock4[i].productId == pid)
				{
					return true;
				}
			}
			return false;
		}
	}
}
