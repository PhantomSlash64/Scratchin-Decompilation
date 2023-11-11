namespace Rewired
{
	public interface IControllerTemplateButton : IControllerTemplateElement
	{
		bool value { get; }

		bool valuePrev { get; }

		float pressure { get; }

		float pressurePrev { get; }

		bool justPressed { get; }

		bool justReleased { get; }

		bool justChangedState { get; }

		new IControllerTemplateButtonSource source { get; }

		IControllerTemplateAxis AsAxis { get; }
	}
}
