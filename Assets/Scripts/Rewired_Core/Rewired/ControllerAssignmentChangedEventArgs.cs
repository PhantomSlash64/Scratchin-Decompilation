using System;

namespace Rewired
{
	public sealed class ControllerAssignmentChangedEventArgs : EventArgs
	{
		private bool FAVhPsORMhhBhEhoKytqPJGvqQpU;

		private int IUWpTXMJPIJwDJdybAJNwpRpcYp;

		private int BUaVcuFwTcIVxSAyrnOfAxOjuhI;

		private ControllerType DdmGAhnWjBkGezCJigEsEoriSFLq;

		public bool state => FAVhPsORMhhBhEhoKytqPJGvqQpU;

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

		public Player player
		{
			get
			{
				if (!ReInput.isReady)
				{
					return null;
				}
				return ReInput.players.GetPlayer(IUWpTXMJPIJwDJdybAJNwpRpcYp);
			}
		}

		internal ControllerAssignmentChangedEventArgs(int playerId, int controllerId, ControllerType controllerType, bool state)
		{
			FAVhPsORMhhBhEhoKytqPJGvqQpU = state;
			IUWpTXMJPIJwDJdybAJNwpRpcYp = playerId;
			BUaVcuFwTcIVxSAyrnOfAxOjuhI = controllerId;
			DdmGAhnWjBkGezCJigEsEoriSFLq = controllerType;
		}
	}
}
