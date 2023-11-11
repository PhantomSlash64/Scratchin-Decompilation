namespace Rewired
{
	public struct InputActionSourceData
	{
		private Controller bGNJaBTbykivsIWbGpkIOAQalRn;

		private ControllerMap dvELFlNCXsbUbhaEdTEhAKKKUbc;

		private ActionElementMap ukDViWpADtgLpGGwUzvZxmXDnFt;

		public Controller controller => bGNJaBTbykivsIWbGpkIOAQalRn;

		public ControllerType controllerType => bGNJaBTbykivsIWbGpkIOAQalRn.type;

		public ControllerMap controllerMap => dvELFlNCXsbUbhaEdTEhAKKKUbc;

		public ActionElementMap actionElementMap => ukDViWpADtgLpGGwUzvZxmXDnFt;

		public string elementIdentifierName => ukDViWpADtgLpGGwUzvZxmXDnFt.elementIdentifierName;

		internal InputActionSourceData(Controller controller, ControllerMap controllerMap, ActionElementMap actionElementMap)
		{
			bGNJaBTbykivsIWbGpkIOAQalRn = controller;
			dvELFlNCXsbUbhaEdTEhAKKKUbc = controllerMap;
			ukDViWpADtgLpGGwUzvZxmXDnFt = actionElementMap;
		}

		internal InputActionSourceData(RWLCROlmXnWJjDaKDWiRqbOVgjF working)
		{
			bGNJaBTbykivsIWbGpkIOAQalRn = working.TWofsWdWcZrFDlgktqaiXknQuRD;
			dvELFlNCXsbUbhaEdTEhAKKKUbc = working.bLXFjMcXvYEkCgtXBNCHEQazALWK;
			ukDViWpADtgLpGGwUzvZxmXDnFt = working.LAuRCWsrqJRFKOmBPvyBpCEIKop;
		}
	}
}
