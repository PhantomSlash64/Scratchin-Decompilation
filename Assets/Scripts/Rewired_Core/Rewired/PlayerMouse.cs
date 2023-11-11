using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Rewired.UI;
using Rewired.Utils.Classes.Data;
using UnityEngine;

namespace Rewired
{
	public sealed class PlayerMouse : PlayerController, IPlayerController, IPlayerMouse, IMouseInputSource
	{
		public new sealed class Definition : PlayerController.Definition
		{
			public bool defaultToCenter = true;

			public bool clampToMovementArea = true;

			public ScreenRect movementArea = utVeAjcEtHUWKHLsgqjIrvdfUZoC;

			public MovementAreaUnit movementAreaUnit;

			public float pointerSpeed = 1f;

			public bool useHardwarePointerPosition = true;

			internal Definition()
			{
			}
		}

		public new static class Factory
		{
			public static PlayerMouse Create()
			{
				return aWlEKFrTmxgBGgRqJDXRHeKwHYg(3, 3);
			}

			private static PlayerMouse aWlEKFrTmxgBGgRqJDXRHeKwHYg(int P_0, int P_1)
			{
				if (P_0 < 0)
				{
					P_0 = 0;
				}
				if (P_1 < 0)
				{
					P_1 = 0;
				}
				List<Element.Definition> list = new List<Element.Definition>(P_0 + P_1);
				if (P_1 >= 1)
				{
					list.Add(new MouseAxis2D.Definition
					{
						name = "Movement",
						xAxis = new MouseAxis.Definition
						{
							name = "Horizontal"
						},
						yAxis = new MouseAxis.Definition
						{
							name = "Vertical"
						}
					});
				}
				if (P_1 >= 3)
				{
					list.Add(new MouseWheel.Definition
					{
						name = "Wheel",
						xAxis = new MouseWheelAxis.Definition
						{
							name = "Wheel Horizontal"
						},
						yAxis = new MouseWheelAxis.Definition
						{
							name = "Wheel Vertical"
						}
					});
				}
				for (int i = 4; i < P_1; i++)
				{
					list.Add(new Axis.Definition
					{
						coordinateMode = AxisCoordinateMode.Relative
					});
				}
				if (P_0 >= 1)
				{
					list.Add(new Button.Definition
					{
						name = "Left Button"
					});
				}
				if (P_0 >= 2)
				{
					list.Add(new Button.Definition
					{
						name = "Right Button"
					});
				}
				if (P_0 >= 3)
				{
					list.Add(new Button.Definition
					{
						name = "Middle Button"
					});
				}
				for (int j = 3; j < P_0; j++)
				{
					list.Add(new Button.Definition());
				}
				Definition definition = new Definition();
				definition.elements = list;
				return new PlayerMouse(definition);
			}

			public static PlayerMouse Create(Definition definition)
			{
				return new PlayerMouse(definition);
			}
		}

		public enum MovementAreaUnit
		{
			Screen = 0,
			Pixel = 1
		}

		internal const bool fjtWVnTRvILmqiaDmrKnJIKAFRZ = true;

		internal const float PEKaYxqceacoyCujbyCtmiTCFNto = 1f;

		internal const bool SDniJSXgQuJIsRaHmaQlaZgPTSMl = true;

		internal const bool FVyqQWBYqlBOILNkkhtLcGpxpoMg = true;

		internal const MovementAreaUnit gOdcUlGHLAguQWUEcWoYCTZAJTJ = MovementAreaUnit.Screen;

		private const int HcoeOimIMzZlIKmYDmHBEgisTRn = 3;

		private const int RJFigPMEkweqBygqCkLKMzXYgVL = 3;

		internal const string HYgqvNUhvSmAbHRAyWkfIlbHnU = "Movement";

		internal const string aXvBYpHFcAChHJUubXBWUCSeWia = "Horizontal";

		internal const string DHWqvkDohZFOiAEgraKwYBpQGcUK = "Vertical";

		internal const string LTLoxujQBJzWXSYQxTRNJAGYVxJ = "Wheel";

		internal const string wibFRYCaaZcBMMRXjIWttoCLEIu = "Wheel Horizontal";

		internal const string pdKcWNBCmiBKKinEdHxyNqnhsMij = "Wheel Vertical";

		internal const string eCCOblVvLTYXZefOkfVsQfkwzik = "Left Button";

		internal const string bpQjWgCQTYEoKhFTPIfaiHdrEvD = "Right Button";

		internal const string HhNBEOhTETOBHtjHASgmtnssXKuC = "Middle Button";

		internal static readonly ScreenRect utVeAjcEtHUWKHLsgqjIrvdfUZoC = new ScreenRect(0f, 0f, 1f, 1f);

		private readonly int mmuYgZjZeCXKOeHtGHxAFpQjYVR = -1;

		private readonly int GGMIIyTAysFclvfjqkWoWRvVmrr = -1;

		private readonly int ijrhtUCZfMMTssSaomhatUVplSD = -1;

		private readonly int wBgBxZHLcufkZcWTnsHOcqNbIfdt = -1;

		private readonly int CVRfnvAuiPxZZPucWeYDWPemDMUd = -1;

		private readonly int XqteqZIUUqjcHlTwWxEDBPrDClY = -1;

		private bool uFFfHuENSSbuTbVGsPOjQPPNial;

		private Vector2 hVjYjsRxfSUCxGApEjQDdDAmPAHb;

		private Vector2 yhfItYeADRkANjOGkybzCjjLjPnC;

		private Vector2 YsnvuTyDCUfDUIBsGJZfsdSrRMiW;

		private Vector2 KYmexHAyxMSTzTnltxcEaZcRfTP;

		private Vector2 XWmElLTgryzLJFMxGghOwesMkfY;

		private float VBZZeRjbqnfCUBtcQzJrnoyxHmOB;

		private bool MsFcQUbcmcUBkizflIWWnqlEDSc;

		private Action<Vector2> scrMBCeAfkNdYHUcVeOPwoepNcD;

		private bool bxyJHnrkZXySKkYAJjNXTEadEBX;

		private ScreenRect urcoydJQNEUhdBJnAVfRqnUYurX;

		private bool itxfJGBmOKqfDgQwaxnAScqMpdE;

		private MovementAreaUnit XWECCkaWCfEbiIsHEkOoINjoTCGw;

		[CompilerGenerated]
		private static Predicate<Axis> LotWtnPDJdoYmvZxratQvQagYKU;

		[CompilerGenerated]
		private static Predicate<Axis> pectuQcVPqrHcaPDJtuIjnCUgQY;

		public bool defaultToCenter
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return false;
				}
				return bxyJHnrkZXySKkYAJjNXTEadEBX;
			}
			set
			{
				bxyJHnrkZXySKkYAJjNXTEadEBX = value;
			}
		}

		public bool clampToMovementArea
		{
			get
			{
				return itxfJGBmOKqfDgQwaxnAScqMpdE;
			}
			set
			{
				itxfJGBmOKqfDgQwaxnAScqMpdE = value;
			}
		}

		public ScreenRect movementArea
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return default(ScreenRect);
				}
				return urcoydJQNEUhdBJnAVfRqnUYurX;
			}
			set
			{
				urcoydJQNEUhdBJnAVfRqnUYurX = value;
			}
		}

		public MovementAreaUnit movementAreaUnit
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return MovementAreaUnit.Screen;
				}
				return XWECCkaWCfEbiIsHEkOoINjoTCGw;
			}
			set
			{
				XWECCkaWCfEbiIsHEkOoINjoTCGw = value;
			}
		}

		public Vector2 screenPosition
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return Vector2.zero;
				}
				if (!base.enabled)
				{
					return Vector2.zero;
				}
				return YsnvuTyDCUfDUIBsGJZfsdSrRMiW;
			}
			set
			{
				mOphZEQOiyBHxOQabsYMIBztdEXJ(value);
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
				if (!base.enabled)
				{
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
				if (!base.enabled)
				{
					return Vector2.zero;
				}
				return XWmElLTgryzLJFMxGghOwesMkfY;
			}
		}

		public MouseAxis xAxis
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				if (GGMIIyTAysFclvfjqkWoWRvVmrr < 0)
				{
					return null;
				}
				return (MouseAxis)base.axes[GGMIIyTAysFclvfjqkWoWRvVmrr];
			}
		}

		public MouseAxis yAxis
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				if (ijrhtUCZfMMTssSaomhatUVplSD < 0)
				{
					return null;
				}
				return (MouseAxis)base.axes[ijrhtUCZfMMTssSaomhatUVplSD];
			}
		}

		public MouseWheel wheel
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				if (mmuYgZjZeCXKOeHtGHxAFpQjYVR < 0)
				{
					return null;
				}
				return (MouseWheel)base.elements[mmuYgZjZeCXKOeHtGHxAFpQjYVR];
			}
		}

		public Button leftButton
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				if (wBgBxZHLcufkZcWTnsHOcqNbIfdt < 0)
				{
					return null;
				}
				return base.buttons[wBgBxZHLcufkZcWTnsHOcqNbIfdt];
			}
		}

		public Button rightButton
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				if (CVRfnvAuiPxZZPucWeYDWPemDMUd < 0)
				{
					return null;
				}
				return base.buttons[CVRfnvAuiPxZZPucWeYDWPemDMUd];
			}
		}

		public Button middleButton
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				if (XqteqZIUUqjcHlTwWxEDBPrDClY < 0)
				{
					return null;
				}
				return base.buttons[XqteqZIUUqjcHlTwWxEDBPrDClY];
			}
		}

		public float pointerSpeed
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return 0f;
				}
				return VBZZeRjbqnfCUBtcQzJrnoyxHmOB;
			}
			set
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return;
				}
				if (value < 0f)
				{
					value = 0f;
				}
				VBZZeRjbqnfCUBtcQzJrnoyxHmOB = value;
			}
		}

		public bool useHardwarePointerPosition
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return false;
				}
				return MsFcQUbcmcUBkizflIWWnqlEDSc;
			}
			set
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return;
				}
				MsFcQUbcmcUBkizflIWWnqlEDSc = value;
				if (!value)
				{
					QQiscXgXdMxcINEVwNbwUQhZdEe();
				}
			}
		}

		bool IMouseInputSource.enabled => base.enabled;

		Vector2 IMouseInputSource.screenPosition => YsnvuTyDCUfDUIBsGJZfsdSrRMiW;

		Vector2 IMouseInputSource.screenPositionDelta => XWmElLTgryzLJFMxGghOwesMkfY;

		Vector2 IMouseInputSource.wheelDelta
		{
			get
			{
				if (wheel == null)
				{
					return Vector2.zero;
				}
				return wheel.value;
			}
		}

		bool IMouseInputSource.locked => false;

		public event Action<Vector2> ScreenPositionChangedEvent
		{
			add
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
				}
				else
				{
					scrMBCeAfkNdYHUcVeOPwoepNcD = (Action<Vector2>)Delegate.Combine(scrMBCeAfkNdYHUcVeOPwoepNcD, value);
				}
			}
			remove
			{
				scrMBCeAfkNdYHUcVeOPwoepNcD = (Action<Vector2>)Delegate.Remove(scrMBCeAfkNdYHUcVeOPwoepNcD, value);
			}
		}

		private PlayerMouse(Definition definition)
			: base(definition)
		{
			bxyJHnrkZXySKkYAJjNXTEadEBX = definition.defaultToCenter;
			itxfJGBmOKqfDgQwaxnAScqMpdE = definition.clampToMovementArea;
			urcoydJQNEUhdBJnAVfRqnUYurX = definition.movementArea;
			XWECCkaWCfEbiIsHEkOoINjoTCGw = definition.movementAreaUnit;
			VBZZeRjbqnfCUBtcQzJrnoyxHmOB = definition.pointerSpeed;
			MsFcQUbcmcUBkizflIWWnqlEDSc = definition.useHardwarePointerPosition;
			int num = base.elementCount;
			int num2 = 0;
			int num3 = 0;
			for (int i = 0; i < num; i++)
			{
				if (num2 < 2 && object.ReferenceEquals(base.elements[i].GetType(), typeof(MouseAxis)))
				{
					if (num2 == 0)
					{
						GGMIIyTAysFclvfjqkWoWRvVmrr = base.axes.IndexOf((MouseAxis)base.elements[i]);
					}
					else
					{
						ijrhtUCZfMMTssSaomhatUVplSD = base.axes.IndexOf((MouseAxis)base.elements[i]);
					}
					num2++;
				}
				else if (mmuYgZjZeCXKOeHtGHxAFpQjYVR < 0 && base.elements[i] is MouseWheel)
				{
					mmuYgZjZeCXKOeHtGHxAFpQjYVR = i;
				}
				else if (num3 < 3 && object.ReferenceEquals(base.elements[i].GetType(), typeof(Button)))
				{
					switch (num3)
					{
					case 0:
						wBgBxZHLcufkZcWTnsHOcqNbIfdt = base.buttons.IndexOf((Button)base.elements[i]);
						break;
					case 1:
						CVRfnvAuiPxZZPucWeYDWPemDMUd = base.buttons.IndexOf((Button)base.elements[i]);
						break;
					case 2:
						XqteqZIUUqjcHlTwWxEDBPrDClY = base.buttons.IndexOf((Button)base.elements[i]);
						break;
					}
					num3++;
				}
			}
			if (mmuYgZjZeCXKOeHtGHxAFpQjYVR < 0)
			{
				int num4 = PlayerController.ArAJziBDDqblUPTGKFgxIUeNiqD(base.axes, (Axis P_0) => object.ReferenceEquals(P_0.GetType(), typeof(MouseWheelAxis)) && !P_0.isMemberElement, 1);
				int num5 = PlayerController.ArAJziBDDqblUPTGKFgxIUeNiqD(base.axes, (Axis P_0) => object.ReferenceEquals(P_0.GetType(), typeof(MouseWheelAxis)) && !P_0.isMemberElement, 2);
				if (num4 >= 0 || num5 >= 0)
				{
					MouseWheel mouseWheel = new MouseWheel(this, new MouseWheel.Definition
					{
						name = "Wheel"
					});
					WqsdoDpSvzDOWFFxuzffBuWiPsvG(mouseWheel);
					mmuYgZjZeCXKOeHtGHxAFpQjYVR = base.elements.Count - 1;
					if (num4 < 0 || num5 < 0)
					{
						Element element = new MouseWheelAxis(this, new MouseWheelAxis.Definition
						{
							name = "Wheel Horizontal",
							coordinateMode = AxisCoordinateMode.Relative
						});
						WqsdoDpSvzDOWFFxuzffBuWiPsvG(element);
						mouseWheel.WqsdoDpSvzDOWFFxuzffBuWiPsvG(element);
						mouseWheel.WqsdoDpSvzDOWFFxuzffBuWiPsvG((num4 < 0) ? base.axes[num5] : base.axes[num4]);
					}
					else
					{
						mouseWheel.WqsdoDpSvzDOWFFxuzffBuWiPsvG(base.axes[num4]);
						mouseWheel.WqsdoDpSvzDOWFFxuzffBuWiPsvG(base.axes[num5]);
					}
				}
			}
			if (bxyJHnrkZXySKkYAJjNXTEadEBX)
			{
				ScreenRect screenRect = EoYDSpalCmXhqcwNmdhUunsywMDf();
				YsnvuTyDCUfDUIBsGJZfsdSrRMiW = new Vector2(screenRect.center.x, screenRect.center.y);
			}
			else
			{
				YsnvuTyDCUfDUIBsGJZfsdSrRMiW = Vector2.zero;
			}
		}

		protected override bool Update(UpdateLoopType updateLoop)
		{
			if (!base.Update(updateLoop))
			{
				return false;
			}
			if (updateLoop != 0)
			{
				return false;
			}
			Player player;
			if (MsFcQUbcmcUBkizflIWWnqlEDSc && (player = base.player) != null)
			{
				if (!player.controllers.hasMouse)
				{
					QQiscXgXdMxcINEVwNbwUQhZdEe();
				}
				else
				{
					hVjYjsRxfSUCxGApEjQDdDAmPAHb = ReInput.controllers.Mouse.screenPosition;
					if (hVjYjsRxfSUCxGApEjQDdDAmPAHb.x != yhfItYeADRkANjOGkybzCjjLjPnC.x || hVjYjsRxfSUCxGApEjQDdDAmPAHb.y != yhfItYeADRkANjOGkybzCjjLjPnC.y)
					{
						YsnvuTyDCUfDUIBsGJZfsdSrRMiW.x = hVjYjsRxfSUCxGApEjQDdDAmPAHb.x;
						YsnvuTyDCUfDUIBsGJZfsdSrRMiW.y = hVjYjsRxfSUCxGApEjQDdDAmPAHb.y;
					}
					yhfItYeADRkANjOGkybzCjjLjPnC.x = hVjYjsRxfSUCxGApEjQDdDAmPAHb.x;
					yhfItYeADRkANjOGkybzCjjLjPnC.y = hVjYjsRxfSUCxGApEjQDdDAmPAHb.y;
				}
			}
			if (GGMIIyTAysFclvfjqkWoWRvVmrr >= 0)
			{
				YsnvuTyDCUfDUIBsGJZfsdSrRMiW.x = hqueMGBQeOaiSWjnNGPZdkSKaOin(base.axes[GGMIIyTAysFclvfjqkWoWRvVmrr], YsnvuTyDCUfDUIBsGJZfsdSrRMiW.x, VBZZeRjbqnfCUBtcQzJrnoyxHmOB);
			}
			if (ijrhtUCZfMMTssSaomhatUVplSD >= 0)
			{
				YsnvuTyDCUfDUIBsGJZfsdSrRMiW.y = hqueMGBQeOaiSWjnNGPZdkSKaOin(base.axes[ijrhtUCZfMMTssSaomhatUVplSD], YsnvuTyDCUfDUIBsGJZfsdSrRMiW.y, VBZZeRjbqnfCUBtcQzJrnoyxHmOB);
			}
			mOphZEQOiyBHxOQabsYMIBztdEXJ(YsnvuTyDCUfDUIBsGJZfsdSrRMiW);
			XWmElLTgryzLJFMxGghOwesMkfY.x = YsnvuTyDCUfDUIBsGJZfsdSrRMiW.x - KYmexHAyxMSTzTnltxcEaZcRfTP.x;
			XWmElLTgryzLJFMxGghOwesMkfY.y = YsnvuTyDCUfDUIBsGJZfsdSrRMiW.y - KYmexHAyxMSTzTnltxcEaZcRfTP.y;
			uFFfHuENSSbuTbVGsPOjQPPNial = YsnvuTyDCUfDUIBsGJZfsdSrRMiW.x != KYmexHAyxMSTzTnltxcEaZcRfTP.x || YsnvuTyDCUfDUIBsGJZfsdSrRMiW.y != KYmexHAyxMSTzTnltxcEaZcRfTP.y;
			KYmexHAyxMSTzTnltxcEaZcRfTP.x = YsnvuTyDCUfDUIBsGJZfsdSrRMiW.x;
			KYmexHAyxMSTzTnltxcEaZcRfTP.y = YsnvuTyDCUfDUIBsGJZfsdSrRMiW.y;
			return true;
		}

		protected override void UpdateFinished()
		{
			base.UpdateFinished();
			if (uFFfHuENSSbuTbVGsPOjQPPNial && scrMBCeAfkNdYHUcVeOPwoepNcD != null)
			{
				try
				{
					scrMBCeAfkNdYHUcVeOPwoepNcD(YsnvuTyDCUfDUIBsGJZfsdSrRMiW);
				}
				catch (Exception ex)
				{
					Logger.LogError("An exception occurred in a listener of ScreenPositionChangedEvent. This means an exception was thrown by your code.\n" + ex);
				}
				uFFfHuENSSbuTbVGsPOjQPPNial = false;
			}
		}

		protected override void ClearVars()
		{
			base.ClearVars();
			KYmexHAyxMSTzTnltxcEaZcRfTP = YsnvuTyDCUfDUIBsGJZfsdSrRMiW;
			XWmElLTgryzLJFMxGghOwesMkfY = Vector2.zero;
			QQiscXgXdMxcINEVwNbwUQhZdEe();
			uFFfHuENSSbuTbVGsPOjQPPNial = false;
		}

		private void mOphZEQOiyBHxOQabsYMIBztdEXJ(Vector2 P_0)
		{
			if (!itxfJGBmOKqfDgQwaxnAScqMpdE)
			{
				YsnvuTyDCUfDUIBsGJZfsdSrRMiW = P_0;
				return;
			}
			if (XWECCkaWCfEbiIsHEkOoINjoTCGw == MovementAreaUnit.Screen)
			{
				float num = Screen.width;
				float num2 = Screen.height;
				YsnvuTyDCUfDUIBsGJZfsdSrRMiW.x = Mathf.Clamp(P_0.x, urcoydJQNEUhdBJnAVfRqnUYurX.xMin * num, urcoydJQNEUhdBJnAVfRqnUYurX.xMax * num);
				YsnvuTyDCUfDUIBsGJZfsdSrRMiW.y = Mathf.Clamp(P_0.y, urcoydJQNEUhdBJnAVfRqnUYurX.yMin * num2, urcoydJQNEUhdBJnAVfRqnUYurX.yMax * num2);
				return;
			}
			if (XWECCkaWCfEbiIsHEkOoINjoTCGw == MovementAreaUnit.Pixel)
			{
				YsnvuTyDCUfDUIBsGJZfsdSrRMiW.x = Mathf.Clamp(P_0.x, urcoydJQNEUhdBJnAVfRqnUYurX.xMin, urcoydJQNEUhdBJnAVfRqnUYurX.xMax);
				YsnvuTyDCUfDUIBsGJZfsdSrRMiW.y = Mathf.Clamp(P_0.y, urcoydJQNEUhdBJnAVfRqnUYurX.yMin, urcoydJQNEUhdBJnAVfRqnUYurX.yMax);
				return;
			}
			throw new NotImplementedException();
		}

		private ScreenRect EoYDSpalCmXhqcwNmdhUunsywMDf()
		{
			if (XWECCkaWCfEbiIsHEkOoINjoTCGw == MovementAreaUnit.Screen)
			{
				return new ScreenRect(urcoydJQNEUhdBJnAVfRqnUYurX.xMin * (float)Screen.width, urcoydJQNEUhdBJnAVfRqnUYurX.yMin * (float)Screen.height, urcoydJQNEUhdBJnAVfRqnUYurX.width * (float)Screen.width, urcoydJQNEUhdBJnAVfRqnUYurX.height * (float)Screen.height);
			}
			if (XWECCkaWCfEbiIsHEkOoINjoTCGw == MovementAreaUnit.Pixel)
			{
				return urcoydJQNEUhdBJnAVfRqnUYurX;
			}
			throw new NotImplementedException();
		}

		private void QQiscXgXdMxcINEVwNbwUQhZdEe()
		{
			hVjYjsRxfSUCxGApEjQDdDAmPAHb = Vector2.zero;
			yhfItYeADRkANjOGkybzCjjLjPnC = Vector2.zero;
		}

		private static float hqueMGBQeOaiSWjnNGPZdkSKaOin(Axis P_0, float P_1, float P_2)
		{
			if (P_0 == null)
			{
				return P_1;
			}
			return P_0.coordinateMode switch
			{
				AxisCoordinateMode.Absolute => P_0.value, 
				AxisCoordinateMode.Relative => P_1 + P_0.value * P_2, 
				_ => throw new NotImplementedException(), 
			};
		}

		private bool QPejpvCySqYAJKgTdfYsbfuUKbR(int P_0)
		{
			return GetButtonDown(P_0);
		}

		bool IMouseInputSource.GetButtonDown(int P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in QPejpvCySqYAJKgTdfYsbfuUKbR
			return this.QPejpvCySqYAJKgTdfYsbfuUKbR(P_0);
		}

		private bool xksCvEhWWSGxsuSvbWlrOBvHNlEq(int P_0)
		{
			return GetButtonUp(P_0);
		}

		bool IMouseInputSource.GetButtonUp(int P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in xksCvEhWWSGxsuSvbWlrOBvHNlEq
			return this.xksCvEhWWSGxsuSvbWlrOBvHNlEq(P_0);
		}

		private bool RVICZPrpgdRAEFbwCGuEUHjtHQm(int P_0)
		{
			return GetButton(P_0);
		}

		bool IMouseInputSource.GetButton(int P_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in RVICZPrpgdRAEFbwCGuEUHjtHQm
			return this.RVICZPrpgdRAEFbwCGuEUHjtHQm(P_0);
		}

		[CompilerGenerated]
		private static bool gvGKktYMgRGljFlTtOsYCScsNxR(Axis P_0)
		{
			if (object.ReferenceEquals(P_0.GetType(), typeof(MouseWheelAxis)))
			{
				return !P_0.isMemberElement;
			}
			return false;
		}

		[CompilerGenerated]
		private static bool BQmHPCUZJQuotjltbUyugYzGZbL(Axis P_0)
		{
			if (object.ReferenceEquals(P_0.GetType(), typeof(MouseWheelAxis)))
			{
				return !P_0.isMemberElement;
			}
			return false;
		}
	}
}
