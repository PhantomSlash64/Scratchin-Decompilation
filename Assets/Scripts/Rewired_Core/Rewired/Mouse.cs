using System;
using Rewired.Interfaces;
using Rewired.Utils;
using Rewired.Utils.Classes.Utility;
using UnityEngine;

namespace Rewired
{
	public sealed class Mouse : ControllerWithAxes
	{
		private TimerAbs ytOPOBAqfjQwSUzEfWQwhmaBFRK;

		private float[] AKfgXTZZJMSzWmwfNbZnRmNBmNF;

		private Vector2 YsnvuTyDCUfDUIBsGJZfsdSrRMiW;

		private Vector2 KYmexHAyxMSTzTnltxcEaZcRfTP;

		private int yDFltqHaJUqxhNdZJzZZxZeFKnF;

		private readonly IUnifiedMouseSource ptgshdhzmBqmpwQkacMBSGAyXPI;

		private static Guid gPTYYeacNPgNhkHFNQmyWUMOaJy;

		public Vector2 screenPosition
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return Vector2.zero;
				}
				return YsnvuTyDCUfDUIBsGJZfsdSrRMiW;
			}
		}

		public Vector2 screenPositionPrev
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return Vector2.zero;
				}
				return KYmexHAyxMSTzTnltxcEaZcRfTP;
			}
		}

		public Vector2 screenPositionDelta
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return Vector2.zero;
				}
				return YsnvuTyDCUfDUIBsGJZfsdSrRMiW - KYmexHAyxMSTzTnltxcEaZcRfTP;
			}
		}

		public override Guid deviceInstanceGuid
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return Guid.Empty;
				}
				return gPTYYeacNPgNhkHFNQmyWUMOaJy;
			}
		}

		internal Mouse(string name, IUnifiedMouseSource source)
			: this(0, source.inputSource, name, InputTools.FormatHardwareIdentifierString(name), source.axisCount, source.buttonCount, source.hardwareMap, source?.controllerExtension, new ControllerDataUpdater(source.inputSource, source.axisCount, source.buttonCount, null))
		{
			ptgshdhzmBqmpwQkacMBSGAyXPI = source;
			gPTYYeacNPgNhkHFNQmyWUMOaJy = MiscTools.CreateGuidHashSHA1("[Universal Mouse]");
			GHVjMXbHizvmmwecacPaiHtKzHl();
		}

		private Mouse(int controllerId, InputSource inputSource, string name, string hardwareIdentifier, int axisCount, int buttonCount, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater)
			: base(controllerId, inputSource, name, name, hardwareIdentifier, ControllerType.Mouse, Consts.hardwareTypeGuid_universalMouse, axisCount, buttonCount, null, hardwareMap, extension, dataUpdater)
		{
		}

		internal override void MlEQHREVxHLTuUCANSxPMEKvYTk(UpdateLoopType P_0)
		{
			ptgshdhzmBqmpwQkacMBSGAyXPI.UpdateInputData(OcGEaRzMecIeBFudxFTOaknZTFKe);
			base.MlEQHREVxHLTuUCANSxPMEKvYTk(P_0);
			dSFOEYBOWVRZyUDAisZNPSyzbAI();
		}

		protected override bool IsPolledAxisActive(int index, out Pole pole, out int elementIdentifierId)
		{
			pole = Pole.Positive;
			elementIdentifierId = -1;
			if (AKfgXTZZJMSzWmwfNbZnRmNBmNF == null)
			{
				AKfgXTZZJMSzWmwfNbZnRmNBmNF = new float[_axisCount];
			}
			if (ytOPOBAqfjQwSUzEfWQwhmaBFRK == null)
			{
				ytOPOBAqfjQwSUzEfWQwhmaBFRK = new TimerAbs(1.0);
			}
			if (ytOPOBAqfjQwSUzEfWQwhmaBFRK.Update() || !ytOPOBAqfjQwSUzEfWQwhmaBFRK.running)
			{
				ytOPOBAqfjQwSUzEfWQwhmaBFRK.Start();
				Array.Clear(AKfgXTZZJMSzWmwfNbZnRmNBmNF, 0, AKfgXTZZJMSzWmwfNbZnRmNBmNF.Length);
			}
			if (ReInput.currentUpdateLoop == UpdateLoopType.OnGUI && !ReInput.configVars.GetPlatformVar_useNativeMouse())
			{
				AKfgXTZZJMSzWmwfNbZnRmNBmNF[index] += axes[index].valueRaw * 0.5f;
			}
			else
			{
				AKfgXTZZJMSzWmwfNbZnRmNBmNF[index] += axes[index].valueRaw;
			}
			float num = AKfgXTZZJMSzWmwfNbZnRmNBmNF[index];
			if (MathTools.Abs(num) <= axes[index].effectivePollingDeadZone)
			{
				return false;
			}
			pole = ((!(num >= 0f)) ? Pole.Negative : Pole.Positive);
			elementIdentifierId = pAhzhvigFoLFbwPDdcXHatZWRIl.axisElementIdentifierIds[index];
			if (elementIdentifierId < 0)
			{
				return false;
			}
			ytOPOBAqfjQwSUzEfWQwhmaBFRK.running = false;
			return true;
		}

		internal override void LlCkzvOeJVaCziTDPktzBWuYotAZ()
		{
			base.LlCkzvOeJVaCziTDPktzBWuYotAZ();
			if (ytOPOBAqfjQwSUzEfWQwhmaBFRK != null)
			{
				ytOPOBAqfjQwSUzEfWQwhmaBFRK.Clear();
			}
			YsnvuTyDCUfDUIBsGJZfsdSrRMiW = Vector2.zero;
			KYmexHAyxMSTzTnltxcEaZcRfTP = Vector2.zero;
		}

		internal override bool GVPaGnImiZihtbyndAIXuQVGSLHA(bool P_0)
		{
			if (!base.GVPaGnImiZihtbyndAIXuQVGSLHA(P_0))
			{
				return false;
			}
			if (P_0)
			{
				dSFOEYBOWVRZyUDAisZNPSyzbAI();
				KYmexHAyxMSTzTnltxcEaZcRfTP = screenPosition;
			}
			return true;
		}

		private void dSFOEYBOWVRZyUDAisZNPSyzbAI()
		{
			int currentUnityFrame = ReInput.currentUnityFrame;
			if (currentUnityFrame != yDFltqHaJUqxhNdZJzZZxZeFKnF)
			{
				KYmexHAyxMSTzTnltxcEaZcRfTP = YsnvuTyDCUfDUIBsGJZfsdSrRMiW;
				YsnvuTyDCUfDUIBsGJZfsdSrRMiW = ptgshdhzmBqmpwQkacMBSGAyXPI.mousePosition;
				yDFltqHaJUqxhNdZJzZZxZeFKnF = currentUnityFrame;
			}
		}
	}
}
