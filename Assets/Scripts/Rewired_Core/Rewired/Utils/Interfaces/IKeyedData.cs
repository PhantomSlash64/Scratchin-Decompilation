namespace Rewired.Utils.Interfaces
{
	public interface IKeyedData<TKey>
	{
		bool TryGetValue<T>(TKey key, out T value);

		bool TrySetValue<T>(TKey key, T value);
	}
}
