using System;
using Rewired.ControllerExtensions;
using Rewired.Drivers.Interfaces;
using Rewired.Utils.Classes.Data;

namespace Rewired.HID.Drivers
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal class RailDriverDriver : HIDDeviceDriver, IDisposable, IControllerDriver, IDriver_RailDriver
	{
		private enum uWYOzQtLVfrxkmYmbHFaqEocynw
		{
			pElkYSVRvuItVwBXHfPOcOOCpNhf = 0,
			reVDHJrdSlArFmzlBoGlaknQQsc = 1
		}

		private const int oYrCJOzRfOPqeUhPZykHsZudcKe = 1523;

		private const int wswEsuiHFmiJvTerIonbdbRJwTyz = 210;

		private const int MIYoAXxJmUicNKAfsvlLFppMumFk = 50;

		private const int EZisYuzvXtNBARsrQUNMzcTkXAQ = 44;

		private const int EhYMdpTHlIiJfKDesLDuvCVKwPp = 6;

		private const int crthIfDcdZpTHctekXkzxvSflE = 44;

		private const int fNGrYLWLHEaTzVqAwrzYyIbBzQl = 45;

		private const int komqzGRVrKAaQaAcRCDnZlbllRm = 46;

		private const int rvIlMeiFbcQoMpHdInjLrMjecDT = 47;

		private const int QtJGWiwDeGAUqFhchqFiTkwJmPKf = 48;

		private const int hrXZfmKOyhaGMzMOynRaXDJMZhv = 49;

		private const int uIFculKswqMUINfRBMJIGbwrtlV = 0;

		private const int nRPwcSNEhqDNkkPxDeltOxPkhbK = 15;

		private const int qHubRgClizjYkhbmhfMvBVVoAMB = 9;

		private const int dvgIfzLitokSWqJhTedUjJCxxnN = 1;

		private const int gWdNjgqorwVuvEXYJWbehFnWgbQ = 2;

		private const int SrLKmKryHnrLYVdNRRVZmnghGHyj = 3;

		private const int fipDnoFPPbxkviHWVjjVluHQeDha = 4;

		private const int UBmHjFCplWuRBOskvKECXDimsnhd = 5;

		private const int imBhkpsZlqsNjViXnKZgBuGySAr = 6;

		private const int ZNpwopXuqPpkwkgdPQqFLmAPlSo = 7;

		private const int bjYzMZPapDCZyBjIlRHsaaVGemY = 8;

		private const int xRCyZeEbOkMQCIuaREtVTvBGzLf = 14;

		private const int fMlCMLdHHOCCqHhHFhRingseIyHX = 3;

		private const int goVUiBkqaJbEheZgvUnFHCqkAwbd = 7;

		private readonly NativeBuffer QGuGsnXIgcCjxddpnmSxdBwnGvlq;

		private readonly NativeBuffer LcLlGDTUOBwsDSCppZCbNWXyzac;

		private bool bmIZLiRhQxrsAHpZpsZxzXCPlLe;

		private byte[] CHLcCCFdSSeWwZnKtvpLdNuXTQiC = new byte[3];

		private readonly OutputReport WsUfyCCtUNweMPHwXAqResAQpPKF;

		private readonly Func<OutputReport, bool> cFzyrmqlmvtEuXUQstBuFKbWFVj;

		private readonly Action<OutputReport> XrxEIkNzgjhXQNIGpeBExQGePGz;

		public bool SpeakerEnabled
		{
			get
			{
				return bmIZLiRhQxrsAHpZpsZxzXCPlLe;
			}
			set
			{
				bmIZLiRhQxrsAHpZpsZxzXCPlLe = value;
				iwMqjybkvSNZHbRhqjokBiVDksQ(uWYOzQtLVfrxkmYmbHFaqEocynw.pElkYSVRvuItVwBXHfPOcOOCpNhf, uvxRrkvDupzxBQCtimfuNwvaThC.XzNISeVEiyPbcvzNpmDUJzSWeUO);
			}
		}

		public void SetLEDDisplay(int digitIndex, byte digitBitValues)
		{
			if (digitIndex >= 0 && digitIndex < 3)
			{
				CHLcCCFdSSeWwZnKtvpLdNuXTQiC[digitIndex] = digitBitValues;
				iwMqjybkvSNZHbRhqjokBiVDksQ(uWYOzQtLVfrxkmYmbHFaqEocynw.reVDHJrdSlArFmzlBoGlaknQQsc, uvxRrkvDupzxBQCtimfuNwvaThC.XzNISeVEiyPbcvzNpmDUJzSWeUO);
			}
		}

		public void SetLEDDisplay(byte digit1BitValues, byte digit2BitValues, byte digit3BitValues)
		{
			CHLcCCFdSSeWwZnKtvpLdNuXTQiC[0] = digit1BitValues;
			CHLcCCFdSSeWwZnKtvpLdNuXTQiC[1] = digit2BitValues;
			CHLcCCFdSSeWwZnKtvpLdNuXTQiC[2] = digit3BitValues;
			iwMqjybkvSNZHbRhqjokBiVDksQ(uWYOzQtLVfrxkmYmbHFaqEocynw.reVDHJrdSlArFmzlBoGlaknQQsc, uvxRrkvDupzxBQCtimfuNwvaThC.XzNISeVEiyPbcvzNpmDUJzSWeUO);
		}

		public RailDriverDriver(InitArgs initArgs)
		{
			if (initArgs == null)
			{
				throw new ArgumentNullException("initArgs");
			}
			QGuGsnXIgcCjxddpnmSxdBwnGvlq = new NativeBuffer(15);
			LcLlGDTUOBwsDSCppZCbNWXyzac = new NativeBuffer(9);
			WsUfyCCtUNweMPHwXAqResAQpPKF = new OutputReport(LcLlGDTUOBwsDSCppZCbNWXyzac.Pointer, LcLlGDTUOBwsDSCppZCbNWXyzac.Length, 9);
			cFzyrmqlmvtEuXUQstBuFKbWFVj = initArgs.synchronousWriteOutputReportDelegate;
			XrxEIkNzgjhXQNIGpeBExQGePGz = initArgs.asynchronousWriteOutputReportDelegate;
			buttons = new HIDButton[50];
			for (int i = 0; i < 50; i++)
			{
				buttons[i] = new HIDButton(0, new HIDControllerElement.HIDInfo
				{
					usagePage = 9,
					usage = (ushort)i
				});
			}
			axes = new HIDAxis[4]
			{
				new HIDAxis(0, new HIDControllerElement.HIDInfo
				{
					usagePage = 1,
					usage = 48,
					dataIndex = 1,
					bitSize = 8,
					logicalMin = 0,
					logicalMax = 255,
					physicalMin = 0,
					physicalMax = 0,
					units = 0u,
					unitsExp = 0u
				}, isSigned: false, 127),
				new HIDAxis(0, new HIDControllerElement.HIDInfo
				{
					usagePage = 1,
					usage = 49,
					dataIndex = 2,
					bitSize = 8,
					logicalMin = 0,
					logicalMax = 255,
					physicalMin = 0,
					physicalMax = 0,
					units = 0u,
					unitsExp = 0u
				}, isSigned: false, 127),
				new HIDAxis(0, new HIDControllerElement.HIDInfo
				{
					usagePage = 1,
					usage = 49,
					dataIndex = 3,
					bitSize = 8,
					logicalMin = 0,
					logicalMax = 255,
					physicalMin = 0,
					physicalMax = 0,
					units = 0u,
					unitsExp = 0u
				}, isSigned: false, 127),
				new HIDAxis(0, new HIDControllerElement.HIDInfo
				{
					usagePage = 1,
					usage = 50,
					dataIndex = 4,
					bitSize = 8,
					logicalMin = 0,
					logicalMax = 255,
					physicalMin = 0,
					physicalMax = 0,
					units = 0u,
					unitsExp = 0u
				}, isSigned: false, 127)
			};
		}

		public override void Update(UpdateLoopType updateLoop)
		{
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
			QGuGsnXIgcCjxddpnmSxdBwnGvlq.Write(inputReportPtr, inputReportLength, QGuGsnXIgcCjxddpnmSxdBwnGvlq.Length);
			ZoEfBvZLEHeQeEqRqOmhOcalkaSu(QGuGsnXIgcCjxddpnmSxdBwnGvlq, timestamp);
			dYCOUXQdfDEyXLlepJqLclKkytx(axes, QGuGsnXIgcCjxddpnmSxdBwnGvlq, timestamp);
			return true;
		}

		public override Controller.Extension CreateControllerExtension()
		{
			return new RailDriverExtension(this);
		}

		private bool iwMqjybkvSNZHbRhqjokBiVDksQ(uWYOzQtLVfrxkmYmbHFaqEocynw P_0, uvxRrkvDupzxBQCtimfuNwvaThC P_1)
		{
			TpYdLaDAdEbsrsdUAjYxaGibFJIm(P_0);
			return ilmlrpVSNPjsnOgsPZdTIfpNGQY(P_1);
		}

		private void TpYdLaDAdEbsrsdUAjYxaGibFJIm(uWYOzQtLVfrxkmYmbHFaqEocynw P_0)
		{
			switch (P_0)
			{
			case uWYOzQtLVfrxkmYmbHFaqEocynw.pElkYSVRvuItVwBXHfPOcOOCpNhf:
				LcLlGDTUOBwsDSCppZCbNWXyzac.Clear();
				LcLlGDTUOBwsDSCppZCbNWXyzac[1] = 133;
				LcLlGDTUOBwsDSCppZCbNWXyzac[7] = (byte)(bmIZLiRhQxrsAHpZpsZxzXCPlLe ? 1 : 0);
				break;
			case uWYOzQtLVfrxkmYmbHFaqEocynw.reVDHJrdSlArFmzlBoGlaknQQsc:
				LcLlGDTUOBwsDSCppZCbNWXyzac.Clear();
				LcLlGDTUOBwsDSCppZCbNWXyzac[1] = 134;
				LcLlGDTUOBwsDSCppZCbNWXyzac[2] = CHLcCCFdSSeWwZnKtvpLdNuXTQiC[0];
				LcLlGDTUOBwsDSCppZCbNWXyzac[3] = CHLcCCFdSSeWwZnKtvpLdNuXTQiC[1];
				LcLlGDTUOBwsDSCppZCbNWXyzac[4] = CHLcCCFdSSeWwZnKtvpLdNuXTQiC[2];
				break;
			default:
				throw new NotImplementedException();
			}
		}

		private bool ilmlrpVSNPjsnOgsPZdTIfpNGQY(uvxRrkvDupzxBQCtimfuNwvaThC P_0)
		{
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
			for (int i = 0; i < 6; i++)
			{
				byte b = P_0[8 + i];
				int num = i * 8;
				for (int j = 0; j < 8; j++)
				{
					int num2 = num + j;
					if (num2 >= 44)
					{
						break;
					}
					buttons[num2].SetValue((b & (1 << j)) != 0, P_1);
				}
			}
			byte b2 = P_0[6];
			buttons[44].SetValue(b2 < 95, P_1);
			buttons[45].SetValue(b2 >= 95 && b2 < 161, P_1);
			buttons[46].SetValue(b2 >= 161, P_1);
			b2 = P_0[7];
			buttons[47].SetValue(b2 < 95, P_1);
			buttons[48].SetValue(b2 >= 95 && b2 < 161, P_1);
			buttons[49].SetValue(b2 >= 161, P_1);
		}

		private void dYCOUXQdfDEyXLlepJqLclKkytx(HIDControllerElement[] P_0, NativeBuffer P_1, double P_2)
		{
			for (int i = 0; i < P_0.Length; i++)
			{
				P_0[i].UpdateValue(P_1, P_2);
			}
		}

		~RailDriverDriver()
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
			if (1523 == vid)
			{
				return 210 == pid;
			}
			return false;
		}
	}
}
