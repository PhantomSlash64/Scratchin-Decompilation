using System;

namespace Rewired
{
	public sealed class ControllerStatusChangedEventArgs : EventArgs
	{
		private string cdTetXhABLRmOQUvcmFAFXpBMHcj;

		private int BUaVcuFwTcIVxSAyrnOfAxOjuhI;

		private ControllerType DdmGAhnWjBkGezCJigEsEoriSFLq;

		public string name => cdTetXhABLRmOQUvcmFAFXpBMHcj;

		public int controllerId => BUaVcuFwTcIVxSAyrnOfAxOjuhI;

		public ControllerType controllerType => DdmGAhnWjBkGezCJigEsEoriSFLq;

		public Controller controller
		{
			get
			{
				if (!ReInput.isReady)
				{
					return null;
				}
				return ReInput.controllers.GetController(DdmGAhnWjBkGezCJigEsEoriSFLq, BUaVcuFwTcIVxSAyrnOfAxOjuhI);
			}
		}

		public ControllerStatusChangedEventArgs(string name, int uniqueId, ControllerType controllerType)
		{
			cdTetXhABLRmOQUvcmFAFXpBMHcj = name;
			BUaVcuFwTcIVxSAyrnOfAxOjuhI = uniqueId;
			DdmGAhnWjBkGezCJigEsEoriSFLq = controllerType;
		}
	}
}
