namespace Rewired.Interfaces
{
	public interface IUserDataStore
	{
		void Save();

		void SaveControllerData(int playerId, ControllerType controllerType, int controllerId);

		void SaveControllerData(ControllerType controllerType, int controllerId);

		void SavePlayerData(int playerId);

		void SaveInputBehavior(int playerId, int behaviorId);

		void Load();

		void LoadControllerData(int playerId, ControllerType controllerType, int controllerId);

		void LoadControllerData(ControllerType controllerType, int controllerId);

		void LoadPlayerData(int playerId);

		void LoadInputBehavior(int playerId, int behaviorId);
	}
}
