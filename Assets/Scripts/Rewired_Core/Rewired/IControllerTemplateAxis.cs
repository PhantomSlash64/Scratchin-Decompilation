namespace Rewired
{
	public interface IControllerTemplateAxis : IControllerTemplateElement
	{
		string positiveDescriptiveName { get; }

		string negativeDescriptiveName { get; }

		float value { get; }

		float valuePrev { get; }

		new IControllerTemplateAxisSource source { get; }

		IControllerTemplateButton AsButton { get; }

		string GetDescriptiveName(AxisRange axisRange);
	}
}
