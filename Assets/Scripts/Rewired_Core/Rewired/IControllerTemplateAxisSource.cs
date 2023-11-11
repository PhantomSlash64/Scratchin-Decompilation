namespace Rewired
{
	public interface IControllerTemplateAxisSource : IControllerTemplateElementSource
	{
		bool splitAxis { get; }

		IControllerElementTarget fullTarget { get; }

		IControllerElementTarget positiveTarget { get; }

		IControllerElementTarget negativeTarget { get; }
	}
}
