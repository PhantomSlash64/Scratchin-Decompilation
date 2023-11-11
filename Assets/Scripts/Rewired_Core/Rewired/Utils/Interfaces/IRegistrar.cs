namespace Rewired.Utils.Interfaces
{
	public interface IRegistrar<T> where T : class
	{
		void Register(T registrant);

		void Deregister(T registrant);
	}
}
