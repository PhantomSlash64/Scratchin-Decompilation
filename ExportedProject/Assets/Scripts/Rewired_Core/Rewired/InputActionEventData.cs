using System.Collections.Generic;

namespace Rewired
{
	public struct InputActionEventData
	{
		private XrsxaFoSedDmSEVIidqjOjugISoF obaJQDcopxJtGKWbwlzaSUuOReG;

		private InputActionEventType gUHOOnZOYpDJFEDmAXgWqXYACCBe;

		public readonly int playerId;

		public readonly int actionId;

		public readonly UpdateLoopType updateLoop;

		public InputActionEventType eventType
		{
			get
			{
				return gUHOOnZOYpDJFEDmAXgWqXYACCBe;
			}
			internal set
			{
				gUHOOnZOYpDJFEDmAXgWqXYACCBe = value;
			}
		}

		public Player player
		{
			get
			{
				if (!ReInput.isReady)
				{
					return null;
				}
				return ReInput.players.GetPlayer(playerId);
			}
		}

		public string actionName
		{
			get
			{
				if (!ReInput.isReady)
				{
					return string.Empty;
				}
				return ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.RqJdcHsAxUbtTwkILZedHAbEBKb(actionId).name;
			}
		}

		public string actionDescriptiveName
		{
			get
			{
				if (!ReInput.isReady)
				{
					return string.Empty;
				}
				return ReInput.JLezATTKNEMVFfHVAgRNIpvVfYV.RqJdcHsAxUbtTwkILZedHAbEBKb(actionId).descriptiveName;
			}
		}

		public float GetAxis()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.GLWgPekOoFtzAmRRNYWNkzKdCZgc();
		}

		public float GetAxisPrev()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.iVALatsHQUVsDgFZEPWWmyXrOke();
		}

		public float GetAxisDelta()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.EBWPcYiGGBPBFsqPQeLirLQCxsk();
		}

		public double GetAxisTimeActive()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.FbYLUMnKHemiCVyWjjCmBSyCSdx();
		}

		public double GetAxisTimeInactive()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.JrgcdgsdFzuruGFPHrAtHEYhsDW();
		}

		public float GetAxisRaw()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.XveAiBhJdpBhkOGEyKTpyxPqkZw();
		}

		public float GetAxisRawDelta()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.tfHdIYOAKcFIoCDVSZgHFnHbswdD();
		}

		public float GetAxisRawPrev()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.WtXxJknRRwYqhWjAscFTChvwcYO();
		}

		public double GetAxisRawTimeActive()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.QbegBwIrfehnXIbIFfFGgfqGwADJ();
		}

		public double GetAxisRawTimeInactive()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.IEAKIpMYAuDfBQFTZLimfIDYvGf();
		}

		public AxisCoordinateMode GetAxisCoordinateMode()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.YouCrCOmfiVRZXvZapTqdJITOmG();
		}

		public AxisCoordinateMode GetAxisCoordinateModePrev()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.kmytUYeYLgmKBhacjKRrGAjkZEJ();
		}

		public AxisCoordinateMode GetAxisRawCoordinateMode()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.vuSKyKCMDAMfhOMcShwMYeUhZpe();
		}

		public AxisCoordinateMode GetAxisRawCoordinateModePrev()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.CeWAVTKiaHTKUCmbYASKouNRBzj();
		}

		public bool GetButton()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.TCWvrlpYTrIwTmaFZCrFglGyZdS();
		}

		public bool GetButtonPrev()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.LpZDtGGwsJWdKGXsgaCmlXBXbxjq();
		}

		public bool GetButtonDown()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.UzfAMThVYdqMudGicKGhMmcVLNfe();
		}

		public bool GetButtonUp()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.oRveQXtNmlxxfdFQcBcgiXXDnHhU();
		}

		public bool GetButtonSinglePressHold()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.UgWvGCEaRDvBZoxWBqudkBbBhjb();
		}

		public bool GetButtonSinglePressDown()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.ZmwKxnwfnEcMkNHCruCKBGYKOhg();
		}

		public bool GetButtonSinglePressUp()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.SSKnYIpdXiHqRnjdcsPJXbGUzOK();
		}

		public bool GetButtonDoublePressDown()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.kciImsjuaZduDjovtWDEackQout();
		}

		public bool GetButtonDoublePressDown(float speed)
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.kciImsjuaZduDjovtWDEackQout(speed);
		}

		public bool GetButtonDoublePressHold()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.AhQsMzwZFroUkeOHfbjXGYXbODnh();
		}

		public bool GetButtonDoublePressHold(float speed)
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.AhQsMzwZFroUkeOHfbjXGYXbODnh(speed);
		}

		public bool GetButtonDoublePressUp()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.pSusZntwSjsVdQQqxBEiXNXUupH();
		}

		public bool GetButtonDoublePressUp(float speed)
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.pSusZntwSjsVdQQqxBEiXNXUupH(speed);
		}

		public bool GetButtonTimedPress(float time)
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.QcSsRGYaurUSMbZdwrdNkblYzgD(time, 0f);
		}

		public bool GetButtonTimedPress(float time, float expireIn)
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.QcSsRGYaurUSMbZdwrdNkblYzgD(time, expireIn);
		}

		public bool GetButtonTimedPressDown(float time)
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.ClafnqACuizCNDqExqMplQHtUXa(time);
		}

		public bool GetButtonTimedPressUp(float time)
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.HdfhlkfxObSYEdkqLNHoJMzhtOCJ(time, 0f);
		}

		public bool GetButtonTimedPressUp(float time, float expireIn)
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.HdfhlkfxObSYEdkqLNHoJMzhtOCJ(time, expireIn);
		}

		public bool GetButtonShortPress()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.XjEQMBXsuqxlOCwbuTvPIFeIlEJ();
		}

		public bool GetButtonShortPressDown()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.UVAdNNaPpzDMuxxLAngERrubVTN();
		}

		public bool GetButtonShortPressUp()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.kDgrwblaRrSDwudvldfKtFtJepxE();
		}

		public bool GetButtonLongPress()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.ZENUyIwPfAqUZEjrkaSfQmivFle();
		}

		public bool GetButtonLongPressDown()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.AaPJBzAaAdepKVGqwSjcPqUDOAq();
		}

		public bool GetButtonLongPressUp()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.OgSlBUwSYdXdkzGtWzRiodFcEHR();
		}

		public bool GetButtonRepeating()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.zKKTDzHWahorsmhpqdKidxrhKXnd();
		}

		public double GetButtonTimePressed()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.oATDmPiwRrPUYbQOWZrqHJeFjjg();
		}

		public double GetButtonTimeUnpressed()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.SrSGNaCvJkWyANBffDFdAJGvwjBE();
		}

		public bool GetNegativeButton()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.iqaAyEcHqdpsAZatEXcYRcIruvj();
		}

		public bool GetNegativeButtonPrev()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.zDUGzlgrGuZsKAvySFmYAjdTBHFT();
		}

		public bool GetNegativeButtonDown()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.oXMNVKNTpnOLUaguzJPKSnhoapa();
		}

		public bool GetNegativeButtonUp()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.bVfrluEmiRTJoxAilUuhMBMaOpt();
		}

		public bool GetNegativeButtonSinglePressHold()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.evvTokiijtmyrGAgUTPZQMOILub();
		}

		public bool GetNegativeButtonSinglePressDown()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.hBcUdxdjwIVlURrzizRRgZUZvDk();
		}

		public bool GetNegativeButtonSinglePressUp()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.JvVzCNDKjgfIOJKRDWqCKxHwCvlG();
		}

		public bool GetNegativeButtonDoublePressDown()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.uzgrHHrIlamtEugSmzAcHkYNQwr();
		}

		public bool GetNegativeButtonDoublePressDown(float speed)
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.uzgrHHrIlamtEugSmzAcHkYNQwr(speed);
		}

		public bool GetNegativeButtonDoublePressHold()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.iSJFayIvWnbWJxcHZtTjNyWVhdE();
		}

		public bool GetNegativeButtonDoublePressHold(float speed)
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.iSJFayIvWnbWJxcHZtTjNyWVhdE(speed);
		}

		public bool GetNegativeButtonDoublePressUp()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.OivUvHDLEenAQaHVtLYeIVbTFUJ();
		}

		public bool GetNegativeButtonDoublePressUp(float speed)
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.OivUvHDLEenAQaHVtLYeIVbTFUJ(speed);
		}

		public bool GetNegativeButtonTimedPress(float time)
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.XLCIyyxbfnSdTlbUKFeatCFHPva(time, 0f);
		}

		public bool GetNegativeButtonTimedPress(float time, float expireIn)
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.XLCIyyxbfnSdTlbUKFeatCFHPva(time, expireIn);
		}

		public bool GetNegativeButtonTimedPressDown(float time)
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.aUWUfhQcfxidmePDKGfSXLgbEhb(time);
		}

		public bool GetNegativeButtonTimedPressUp(float time)
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.nJUBAbsoiUeNQoUWzwBULFKwmKR(time, 0f);
		}

		public bool GetNegativeButtonTimedPressUp(float time, float expireIn)
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.nJUBAbsoiUeNQoUWzwBULFKwmKR(time, expireIn);
		}

		public bool GetNegativeButtonShortPress()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.rsbocuLgoXoAeksZdweGqFofKRx();
		}

		public bool GetNegativeButtonShortPressDown()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.AZnzlkEspdMDrbGiJQSNLiVdzzR();
		}

		public bool GetNegativeButtonShortPressUp()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.XVYuYDBxqNNkZvpfdecmrPImZKw();
		}

		public bool GetNegativeButtonLongPress()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.IABnWtyeoNnaZZDvIABOPjPtFNR();
		}

		public bool GetNegativeButtonLongPressDown()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.NPfjTCkwvhbbXdkUfjqqxQvNQHF();
		}

		public bool GetNegativeButtonLongPressUp()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.PSwwnFdnPtdjhfHOsFWWyZFMCgT();
		}

		public bool GetNegativeButtonRepeating()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.bTMzAABqqYNwnBmyXsXvNssMmTt();
		}

		public double GetNegativeButtonTimePressed()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.TMTnvcIdGasmvQbzNNrlUFAInyZ();
		}

		public double GetNegativeButtonTimeUnpressed()
		{
			return obaJQDcopxJtGKWbwlzaSUuOReG.ZMssshEhiFbjjlhsSlhAFwrtncU();
		}

		public IList<InputActionSourceData> GetCurrentInputSources()
		{
			return ReInput.CoyPNJHWMheFytmTMQdqyctMRFl.XPToosqqXMRHQrnQiuecVwOHVUJ(playerId, actionId, true)?.aYwoPDjjBgUVKwrUTrNdFgSSMR();
		}

		public bool IsCurrentInputSource(ControllerType controllerType)
		{
			return ReInput.CoyPNJHWMheFytmTMQdqyctMRFl.XPToosqqXMRHQrnQiuecVwOHVUJ(playerId, actionId, true)?.GkfxgmoXKOLOWjigJWUpWkLLOEL(controllerType) ?? false;
		}

		public bool IsCurrentInputSource(ControllerType controllerType, int controllerId)
		{
			return ReInput.CoyPNJHWMheFytmTMQdqyctMRFl.XPToosqqXMRHQrnQiuecVwOHVUJ(playerId, actionId, true)?.GkfxgmoXKOLOWjigJWUpWkLLOEL(controllerType, controllerId) ?? false;
		}

		public bool IsCurrentInputSource(Controller controller)
		{
			return ReInput.CoyPNJHWMheFytmTMQdqyctMRFl.XPToosqqXMRHQrnQiuecVwOHVUJ(playerId, actionId, true)?.GkfxgmoXKOLOWjigJWUpWkLLOEL(controller) ?? false;
		}

		internal InputActionEventData(XrsxaFoSedDmSEVIidqjOjugISoF vc, int playerId, int actionId, UpdateLoopType updateLoop)
		{
			gUHOOnZOYpDJFEDmAXgWqXYACCBe = InputActionEventType.Update;
			obaJQDcopxJtGKWbwlzaSUuOReG = vc;
			this.playerId = playerId;
			this.actionId = actionId;
			this.updateLoop = updateLoop;
		}
	}
}
