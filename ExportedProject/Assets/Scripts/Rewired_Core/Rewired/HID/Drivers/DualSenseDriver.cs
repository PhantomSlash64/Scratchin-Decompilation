using System;
using Rewired.ControllerExtensions;
using Rewired.Drivers.Interfaces;
using Rewired.Utils;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired.HID.Drivers
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class DualSenseDriver : HIDDeviceDriver, IDisposable, IControllerDriver, IDriver_DualSense
	{
		private enum wtfCtqQmHNcrwjOIMhTsNZQnakhO
		{
			PYBETkQVsRmUDiCvIHprMAIKEVN = 0,
			zdZvHrngnxPnydNyOxhmBTPWOLk = 1,
			vMFCHhhISrvmOsmZnghClToXZSS = 2
		}

		private enum cXCzkvnfBUwsRYZNwACqFsJWIsG
		{
			fUyeeVFhkdEderlnmYYFoAwmZEL = 0,
			JiqnlfEwZFKahPPMCwySfgXJlyA = 1,
			zdZvHrngnxPnydNyOxhmBTPWOLk = 2
		}

		public enum pGLGzUBcLvQLQRHTAiqqZZkASec : byte
		{
			wjFbZVmjaTkEjRNqQtmlMHRYpoy = 0,
			AWkvqfwjiMQBIQzYVvXIKKINNlz = 1,
			OxjqbnvvfdpcNWxbghOzSHDAWHJ = 2
		}

		private const float fAnQUbmJRsnMDHyPxSlZlCPQKiC = 4f;

		private const int MIYoAXxJmUicNKAfsvlLFppMumFk = 15;

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

		private const int wYdNhJFhmRryuozDAmurpCCXbyZ = 49;

		private const int GHkAZOiKjzGcoLMeuyUnNTmUiFZ = 0;

		private const int GoGdXxWtwAzcbxQjGfRzcyGDoEOe = 1;

		private const int PKYEjyctkhojSHCGysyHEfWkyuKu = 64;

		private const int aTLORhXpueDiZvhxqMgbOBxxIsT = 48;

		private const int eYohTscfeeLHDzYgTOraRnJWEdh = 547;

		private const int DDNHxkHysUxlFOVKOpCvcjFDuNlo = 64;

		private const int vjEUyIqUcogzQTaTTQbbMdrFzNF = 547;

		private const int cFUkBGSVQQtlKKkoldOgPCDICbdJ = 1;

		private const int ZGGhvEKpERWmcuDXqklkWXaeVDR = 2;

		private const int KDcdhwwKDoXZuukpmjHLKhFJlao = 3;

		private const int KTZmcTHcfgtyyegHTcRippXTWPO = 4;

		private const int yABqcCoWAsPxRIQJDdBICtDxkdL = 5;

		private const int rmGjyjxSOMplcaZdKAbuJJRMOSz = 6;

		private const int jYmlJZAHFWMundOjzHzsqjBeCmG = 8;

		private const int hYzOcmnqnhvhqMbPeIOZnnljjsNA = 22;

		private const int BUEZhscAyODynSAXqbLmOlYVnzq = 16;

		private const int KXGscmwhMxFJfHkyEVFfLLYCqqhf = 33;

		private const int hnlHCYHWllpArmVFARKNAciknNn = 8;

		private const int OurGXDTqihdxczsgJKvQeoUWEdF = 9;

		private const int ayAGbmvwpzAsJosBzmlISVjJduk = 10;

		private const int MujHOqcJkzaOsqOhmsRZSKfHWsR = 28;

		private const int AMneLhqIKZgWtwsaYynKLLUEYbA = 54;

		private const int YBofNCUMVwgVJcisvAOaGuVtnOJ = 55;

		private const int LpcRbaeNGEeAjLJDlKvrPkdRmlZ = 54;

		private const bool cAWAMQbjlYYsCYiKEnQZnuruMhR = true;

		private const int JWpHhhXPsItCXNqNSQGUbCSMzFC = 25;

		private const int hjXOGBgAHYshNJHXFCuPCDgWFYK = 3000000;

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

		private const uint oPwDnOVAkIConBETKhNZfefFtwCx = 3940166985u;

		private readonly bool uiKzFbJoKSboUzaXcUnWBjVZohw;

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

		private OutputReport WsUfyCCtUNweMPHwXAqResAQpPKF;

		private readonly Func<OutputReport, bool> cFzyrmqlmvtEuXUQstBuFKbWFVj;

		private readonly Action<OutputReport> XrxEIkNzgjhXQNIGpeBExQGePGz;

		private bool JhfGDIhIgxEkFUyBTCYpkYbVqPau;

		private bool BbDHEMJExvhXNYfPyMgEWPklvwM;

		private double qiPfmrSXAYJwIZrEvRCsHYmQaqt;

		private byte KgsBMivUuHvQAhTlLaIKubLmlmc;

		private bool RtoGAenvQRcNdZAEDrKLyBROVdw;

		private bool QnCRGUGVnvlLjuaLqxwaCPlHBPP;

		private bool PbyPBDzsizYwxxgvBtmnjagJpNP;

		private Quaternion tcLHyjngGbFRCpVKAwhiMCXqOMa = Quaternion.identity;

		private DualSenseMicrophoneLightMode JBuaGlFdKAKOnxRQlkiAPBfbENk;

		private pGLGzUBcLvQLQRHTAiqqZZkASec nXXfRGjWPBvvJhndJlJfkDTgfoJ;

		private DualSensePlayerLightFlags mHSCvohiweVbSWgCdsfckiYcSdaM;

		private bool AWbVcGHehheOzJTflIiVQkMJPlTe;

		private bool JKxLkiCdULFDnMMgYXZnjeeJzPy;

		private uint OSZQlQOayoPaBhNvIAxMfOKyobDv;

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

		private static uint[] xgFldxhRcQeNlIaQbCvqZUAyfqH = new uint[256]
		{
			3523407757u, 2768625435u, 1007455905u, 1259060791u, 3580832660u, 2724731650u, 996231864u, 1281784366u, 3705235391u, 2883475241u,
			852952723u, 1171273221u, 3686048678u, 2897449776u, 901431946u, 1119744540u, 3484811241u, 3098726271u, 565944005u, 1455205971u,
			3369614320u, 3219065702u, 651582172u, 1372678730u, 3245242331u, 3060352845u, 794826487u, 1483155041u, 3322131394u, 2969862996u,
			671994606u, 1594548856u, 3916222277u, 2657877971u, 123907689u, 1885708031u, 3993045852u, 2567322570u, 1010288u, 1997036262u,
			3887548279u, 2427484129u, 163128923u, 2126386893u, 3772416878u, 2547889144u, 248832578u, 2043925204u, 4108050209u, 2212294583u,
			450215437u, 1842515611u, 4088798008u, 2226203566u, 498629140u, 1790921346u, 4194326291u, 2366072709u, 336475711u, 1661535913u,
			4251816714u, 2322244508u, 325317158u, 1684325040u, 2766056989u, 3554254475u, 1255198513u, 1037565863u, 2746444292u, 3568589458u,
			1304234792u, 985283518u, 2852464175u, 3707901625u, 1141589763u, 856455061u, 2909332022u, 3664761504u, 1130791706u, 878818188u,
			3110715001u, 3463352047u, 1466425173u, 543223747u, 3187964512u, 3372436214u, 1342839628u, 655174618u, 3081909835u, 3233089245u,
			1505515367u, 784033777u, 2967466578u, 3352871620u, 1590793086u, 701932520u, 2679148245u, 3904355907u, 1908338681u, 112844655u,
			2564639436u, 4024072794u, 1993550816u, 30677878u, 2439710439u, 3865851505u, 2137352139u, 140662621u, 2517025534u, 3775001192u,
			2013832146u, 252678980u, 2181537457u, 4110462503u, 1812594589u, 453955339u, 2238339752u, 4067256894u, 1801730948u, 476252946u,
			2363233923u, 4225443349u, 1657960367u, 366298937u, 2343686810u, 4239843852u, 1707062198u, 314082080u, 1069182125u, 1220369467u,
			3518238081u, 2796764439u, 953657524u, 1339070498u, 3604597144u, 2715744526u, 828499103u, 1181144073u, 3748627891u, 2825434405u,
			906764422u, 1091244048u, 3624026538u, 2936369468u, 571309257u, 1426738271u, 3422756325u, 3137613171u, 627095760u, 1382516806u,
			3413039612u, 3161057642u, 752284923u, 1540473965u, 3268974039u, 3051332929u, 733688034u, 1555824756u, 3316994510u, 2998034776u,
			81022053u, 1943239923u, 3940166985u, 2648514015u, 62490748u, 1958656234u, 3988253008u, 2595281350u, 168805463u, 2097738945u,
			3825313147u, 2466682349u, 224526414u, 2053451992u, 3815530850u, 2490061300u, 425942017u, 1852075159u, 4151131437u, 2154433979u,
			504272920u, 1762240654u, 4026595636u, 2265434530u, 397988915u, 1623188645u, 4189500703u, 2393998729u, 282398762u, 1741824188u,
			4275794182u, 2312913296u, 1231433021u, 1046551979u, 2808630289u, 3496967303u, 1309403428u, 957143474u, 2684717064u, 3607279774u,
			1203610895u, 817534361u, 2847130659u, 3736401077u, 1087398166u, 936857984u, 2933784634u, 3654889644u, 1422998873u, 601230799u,
			3135200373u, 3453512931u, 1404893504u, 616286678u, 3182598252u, 3400902906u, 1510651243u, 755860989u, 3020215367u, 3271812305u,
			1567060338u, 710951396u, 3010007134u, 3295551688u, 1913130485u, 84884835u, 2617666777u, 3942734927u, 1969605100u, 40040826u,
			2607524032u, 3966539862u, 2094237127u, 198489425u, 2464015595u, 3856323709u, 2076066270u, 213479752u, 2511347954u, 3803648100u,
			1874795921u, 414723335u, 2175892669u, 4139142187u, 1758648712u, 534112542u, 2262612132u, 4057696306u, 1633981859u, 375629109u,
			2406151311u, 4167943193u, 1711886778u, 286155052u, 2282172566u, 4278190080u
		};

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

		public bool BatteryCharging => RtoGAenvQRcNdZAEDrKLyBROVdw;

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

		public DualSenseMicrophoneLightMode microphoneLightMode
		{
			get
			{
				return JBuaGlFdKAKOnxRQlkiAPBfbENk;
			}
			set
			{
				JBuaGlFdKAKOnxRQlkiAPBfbENk = value;
				JhfGDIhIgxEkFUyBTCYpkYbVqPau = true;
			}
		}

		public DualSenseOtherLightBrightness otherLightBrightness
		{
			get
			{
				return fEObFuRFJuRFNLGMYQSUkknTBVzf(nXXfRGjWPBvvJhndJlJfkDTgfoJ);
			}
			set
			{
				nXXfRGjWPBvvJhndJlJfkDTgfoJ = slMgzrKmWbpBSKRCzfqLpIICDGrf(value);
				JhfGDIhIgxEkFUyBTCYpkYbVqPau = true;
			}
		}

		public DualSensePlayerLightFlags playerLights
		{
			get
			{
				return mHSCvohiweVbSWgCdsfckiYcSdaM;
			}
			set
			{
				mHSCvohiweVbSWgCdsfckiYcSdaM = value;
				JhfGDIhIgxEkFUyBTCYpkYbVqPau = true;
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

		public DualSenseDriver(InitArgs initArgs)
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
			uiKzFbJoKSboUzaXcUnWBjVZohw = initArgs.connectionType == DeviceConnectionType.CabkzYmwkSoeZRQBHEfOFiOxqlo;
			if (uiKzFbJoKSboUzaXcUnWBjVZohw)
			{
				GZBrnJXSggJRlcoPFfoEWSvhIVX = 547;
			}
			else
			{
				GZBrnJXSggJRlcoPFfoEWSvhIVX = 48;
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
				byte[] array = initArgs.getFeatureReportDelegate(5);
				lYFaFOelZuFeZlIpiioSSRMTCErC = array != null && array.Length > 0;
				if (lYFaFOelZuFeZlIpiioSSRMTCErC)
				{
					iwMqjybkvSNZHbRhqjokBiVDksQ(uvxRrkvDupzxBQCtimfuNwvaThC.XzNISeVEiyPbcvzNpmDUJzSWeUO);
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
				kURiGkcrCHBxPShdHOvkCGvRAtd = 49;
				eesFGtJZTKWMgolXXnmdFnmGlLy = 1;
			}
			gyrGKnIaWDciwbatYfdjGsjeTgAe = 8 + eesFGtJZTKWMgolXXnmdFnmGlLy;
			hbFeyMARHWWaTLgXbdzzyYNOBkv = 9 + eesFGtJZTKWMgolXXnmdFnmGlLy;
			ByAsKVJlZQcUCKRxrRLQxmxbeYL = 10 + eesFGtJZTKWMgolXXnmdFnmGlLy;
			buttons = new HIDButton[15];
			for (int i = 0; i < 15; i++)
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
					dataIndex = 5 + eesFGtJZTKWMgolXXnmdFnmGlLy,
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
					dataIndex = 6 + eesFGtJZTKWMgolXXnmdFnmGlLy,
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
					dataIndex = 8 + eesFGtJZTKWMgolXXnmdFnmGlLy,
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
					dataIndex = 22 + eesFGtJZTKWMgolXXnmdFnmGlLy,
					bitSize = 48
				}, 3, cGDbKvxxnAEUJFJOUujzTgpdpbzd)
			};
			gyroscopes = new HIDGyroscope[1]
			{
				new HIDGyroscope(initArgs.updateLoopSetting, kURiGkcrCHBxPShdHOvkCGvRAtd, new HIDControllerElement.HIDInfo
				{
					usagePage = 1,
					dataIndex = 16 + eesFGtJZTKWMgolXXnmdFnmGlLy,
					bitSize = 48
				}, 3, 25, rFWDEkCGCqNdrAPKIoqaczvZRyQY, uCDIPOdKTtJysOUFJrjBxacBtMTA)
			};
			touchpads = new HIDTouchpad[1]
			{
				new HIDTouchpad(kURiGkcrCHBxPShdHOvkCGvRAtd, new HIDTouchpad.TouchpadInfo(2, 0, 1912, 0, 941, invertY: false, reverseY: true), new HIDControllerElement.HIDInfo
				{
					usagePage = 1,
					dataIndex = 33 + eesFGtJZTKWMgolXXnmdFnmGlLy,
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
			RtoGAenvQRcNdZAEDrKLyBROVdw = (QGuGsnXIgcCjxddpnmSxdBwnGvlq[54 + eesFGtJZTKWMgolXXnmdFnmGlLy] & 8) != 0;
			QnCRGUGVnvlLjuaLqxwaCPlHBPP = (QGuGsnXIgcCjxddpnmSxdBwnGvlq[55 + eesFGtJZTKWMgolXXnmdFnmGlLy] & 0x20) != 0;
			KgsBMivUuHvQAhTlLaIKubLmlmc = (byte)(QGuGsnXIgcCjxddpnmSxdBwnGvlq[55 + eesFGtJZTKWMgolXXnmdFnmGlLy] & 0xFu);
			PbyPBDzsizYwxxgvBtmnjagJpNP = (QGuGsnXIgcCjxddpnmSxdBwnGvlq[54 + eesFGtJZTKWMgolXXnmdFnmGlLy] & 1) != 0;
			YLjqWGoPsWiVnPihFhvobjAaPsCH();
			return true;
		}

		public override Controller.Extension CreateControllerExtension()
		{
			return new DualSenseExtension(this);
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
				LcLlGDTUOBwsDSCppZCbNWXyzac[0] = 49;
				LcLlGDTUOBwsDSCppZCbNWXyzac[1] = 2;
				TpYdLaDAdEbsrsdUAjYxaGibFJIm(LcLlGDTUOBwsDSCppZCbNWXyzac, 2);
				uint num = VpKdvXJlVTqDhghORJFTSkRDffZ(LcLlGDTUOBwsDSCppZCbNWXyzac, 74);
				LcLlGDTUOBwsDSCppZCbNWXyzac[74] = (byte)(num & 0xFFu);
				LcLlGDTUOBwsDSCppZCbNWXyzac[75] = (byte)((num & 0xFF00) >> 8);
				LcLlGDTUOBwsDSCppZCbNWXyzac[76] = (byte)((num & 0xFF0000) >> 16);
				LcLlGDTUOBwsDSCppZCbNWXyzac[77] = (byte)((num & 0xFF000000u) >> 24);
			}
			else
			{
				LcLlGDTUOBwsDSCppZCbNWXyzac[0] = 2;
				TpYdLaDAdEbsrsdUAjYxaGibFJIm(LcLlGDTUOBwsDSCppZCbNWXyzac, 1);
			}
		}

		private void TpYdLaDAdEbsrsdUAjYxaGibFJIm(NativeBuffer P_0, int P_1)
		{
			P_0[P_1] = byte.MaxValue;
			P_0[1 + P_1] = 247;
			P_0[2 + P_1] = (byte)vibrationMotors[1].SpeedRaw;
			P_0[3 + P_1] = (byte)vibrationMotors[0].SpeedRaw;
			P_0[8 + P_1] = (byte)JBuaGlFdKAKOnxRQlkiAPBfbENk;
			P_0[43 + P_1] = (byte)mHSCvohiweVbSWgCdsfckiYcSdaM;
			if (AWbVcGHehheOzJTflIiVQkMJPlTe)
			{
				P_0[43 + P_1] = (byte)(P_0[43 + P_1] & 0xFFFFFFDFu);
			}
			else
			{
				P_0[43 + P_1] |= 32;
			}
			P_0[38 + P_1] = 3;
			P_0[41 + P_1] = (byte)(JKxLkiCdULFDnMMgYXZnjeeJzPy ? 1 : 2);
			P_0[42 + P_1] = (byte)nXXfRGjWPBvvJhndJlJfkDTgfoJ;
			P_0[44 + P_1] = lights[0].ColorRRaw;
			P_0[45 + P_1] = lights[0].ColorGRaw;
			P_0[46 + P_1] = lights[0].ColorBRaw;
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
			if (lYFaFOelZuFeZlIpiioSSRMTCErC)
			{
				buttons[14].SetValue((b & 4) != 0, P_1);
			}
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
				uint num = QGuGsnXIgcCjxddpnmSxdBwnGvlq.ReadUInt(28 + eesFGtJZTKWMgolXXnmdFnmGlLy);
				float num3;
				if (num != OSZQlQOayoPaBhNvIAxMfOKyobDv)
				{
					uint num2 = (uint)((num >= OSZQlQOayoPaBhNvIAxMfOKyobDv) ? (num - OSZQlQOayoPaBhNvIAxMfOKyobDv) : ((long)num + 4294967295L - OSZQlQOayoPaBhNvIAxMfOKyobDv));
					num3 = (float)num2 / 3000000f;
				}
				else
				{
					uint num2 = 0u;
					num3 = 0f;
				}
				OSZQlQOayoPaBhNvIAxMfOKyobDv = num;
				rWsbBCdkKvnqEKLyfqwadYaYPqEE = num3;
			}
		}

		private void YLjqWGoPsWiVnPihFhvobjAaPsCH()
		{
			if (lYFaFOelZuFeZlIpiioSSRMTCErC && !(rWsbBCdkKvnqEKLyfqwadYaYPqEE <= 0f))
			{
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
			if (sqrMagnitude > 16777216f && sqrMagnitude < 268435460f && gaeRkPxMveyUlucLIvkhJfHuVRy(P_0, out var cXCzkvnfBUwsRYZNwACqFsJWIsG))
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
				if ((cXCzkvnfBUwsRYZNwACqFsJWIsG & cXCzkvnfBUwsRYZNwACqFsJWIsG.JiqnlfEwZFKahPPMCwySfgXJlyA) != 0)
				{
					b = HBMwrtdQclvSKNvqlAdgHKRBgDK(P_0, a.eulerAngles.y);
				}
				else if ((cXCzkvnfBUwsRYZNwACqFsJWIsG & cXCzkvnfBUwsRYZNwACqFsJWIsG.zdZvHrngnxPnydNyOxhmBTPWOLk) != 0)
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

		private Quaternion qsKTOVVzBpPEGbtIdyaJtdZDGcl(Quaternion P_0, wtfCtqQmHNcrwjOIMhTsNZQnakhO P_1)
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

		private bool gaeRkPxMveyUlucLIvkhJfHuVRy(Vector3 P_0, out cXCzkvnfBUwsRYZNwACqFsJWIsG P_1)
		{
			P_0.Normalize();
			P_1 = cXCzkvnfBUwsRYZNwACqFsJWIsG.fUyeeVFhkdEderlnmYYFoAwmZEL;
			bool result = false;
			if (UFrtjsXMsEdvofWUpsVUJDGdAwi(P_0))
			{
				result = true;
				P_1 |= cXCzkvnfBUwsRYZNwACqFsJWIsG.JiqnlfEwZFKahPPMCwySfgXJlyA;
			}
			if (leFkEzdvofNxvZdGgSraGDfAdOoE(P_0))
			{
				result = true;
				P_1 |= cXCzkvnfBUwsRYZNwACqFsJWIsG.zdZvHrngnxPnydNyOxhmBTPWOLk;
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
			int num = 33 + eesFGtJZTKWMgolXXnmdFnmGlLy;
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

		~DualSenseDriver()
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
			if (vid == 1356 && pid == 3302)
			{
				return true;
			}
			return false;
		}

		private static uint VpKdvXJlVTqDhghORJFTSkRDffZ(NativeBuffer P_0, int P_1)
		{
			uint num = 3940166985u;
			for (int i = 0; i < P_1; i++)
			{
				num = xgFldxhRcQeNlIaQbCvqZUAyfqH[(byte)num ^ P_0[i]] ^ (num >> 8);
			}
			return num;
		}

		private static pGLGzUBcLvQLQRHTAiqqZZkASec slMgzrKmWbpBSKRCzfqLpIICDGrf(DualSenseOtherLightBrightness P_0)
		{
			return P_0 switch
			{
				DualSenseOtherLightBrightness.High => pGLGzUBcLvQLQRHTAiqqZZkASec.wjFbZVmjaTkEjRNqQtmlMHRYpoy, 
				DualSenseOtherLightBrightness.Medium => pGLGzUBcLvQLQRHTAiqqZZkASec.AWkvqfwjiMQBIQzYVvXIKKINNlz, 
				DualSenseOtherLightBrightness.Low => pGLGzUBcLvQLQRHTAiqqZZkASec.OxjqbnvvfdpcNWxbghOzSHDAWHJ, 
				_ => throw new NotImplementedException(), 
			};
		}

		private static DualSenseOtherLightBrightness fEObFuRFJuRFNLGMYQSUkknTBVzf(pGLGzUBcLvQLQRHTAiqqZZkASec P_0)
		{
			return P_0 switch
			{
				pGLGzUBcLvQLQRHTAiqqZZkASec.wjFbZVmjaTkEjRNqQtmlMHRYpoy => DualSenseOtherLightBrightness.High, 
				pGLGzUBcLvQLQRHTAiqqZZkASec.AWkvqfwjiMQBIQzYVvXIKKINNlz => DualSenseOtherLightBrightness.Medium, 
				pGLGzUBcLvQLQRHTAiqqZZkASec.OxjqbnvvfdpcNWxbghOzSHDAWHJ => DualSenseOtherLightBrightness.Low, 
				_ => throw new NotImplementedException(), 
			};
		}
	}
}
