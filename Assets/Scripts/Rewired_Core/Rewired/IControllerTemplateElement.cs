namespace Rewired
{
	public interface IControllerTemplateElement
	{
		int id { get; }

		string descriptiveName { get; }

		ControllerTemplateElementType type { get; }

		bool exists { get; }

		IControllerTemplateElementSource source { get; }
	}
}
