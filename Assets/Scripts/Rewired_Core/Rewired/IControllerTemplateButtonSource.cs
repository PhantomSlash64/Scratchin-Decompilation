namespace Rewired
{
	public interface IControllerTemplateButtonSource : IControllerTemplateElementSource
	{
		IControllerElementTarget target { get; }
	}
}
