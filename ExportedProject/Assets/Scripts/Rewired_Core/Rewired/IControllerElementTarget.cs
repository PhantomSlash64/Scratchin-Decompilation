namespace Rewired
{
	public interface IControllerElementTarget
	{
		int elementIdentifierId { get; }

		AxisRange axisRange { get; }

		bool hasTarget { get; }

		ControllerElementType elementType { get; }

		string descriptiveName { get; }

		Controller controller { get; }

		Controller.Element element { get; }
	}
}
