namespace Rewired
{
	public sealed class CustomControllerMapSaveData : ControllerMapSaveData
	{
		public CustomController customController
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return _controller as CustomController;
			}
		}

		public CustomControllerMap customControllerMap
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return null;
				}
				return _map as CustomControllerMap;
			}
		}

		public int customControllerSourceId
		{
			get
			{
				if (ReInput._id != PivQvdYMhUssuLwaglJVqkqXMSH)
				{
					ReInput.CheckInitialized(PivQvdYMhUssuLwaglJVqkqXMSH);
					return -1;
				}
				return customController.sourceControllerId;
			}
		}

		internal CustomControllerMapSaveData(CustomController customController, CustomControllerMap map)
			: base(customController, map)
		{
		}
	}
}
