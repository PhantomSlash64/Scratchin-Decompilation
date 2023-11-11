using Rewired.Utils.Interfaces;

namespace Rewired.ComponentControls
{
	public interface IComponentController : IRegistrar<IComponentControl>
	{
		void ClearControlValues();
	}
}
