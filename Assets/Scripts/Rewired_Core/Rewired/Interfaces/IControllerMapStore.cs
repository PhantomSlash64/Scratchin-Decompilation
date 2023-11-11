namespace Rewired.Interfaces
{
	public interface IControllerMapStore
	{
		void SaveControllerMap(int playerId, ControllerMap controllerMap);

		ControllerMap LoadControllerMap(int playerId, ControllerIdentifier controllerIdentifier, int categoryId, int layoutId);
	}
}
