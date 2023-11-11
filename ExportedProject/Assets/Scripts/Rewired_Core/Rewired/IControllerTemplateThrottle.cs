namespace Rewired
{
	public interface IControllerTemplateThrottle : IControllerTemplateElement
	{
		float value { get; }

		float valuePrev { get; }

		IControllerTemplateAxis throttle { get; }

		IControllerTemplateButton minDetent { get; }
	}
}
