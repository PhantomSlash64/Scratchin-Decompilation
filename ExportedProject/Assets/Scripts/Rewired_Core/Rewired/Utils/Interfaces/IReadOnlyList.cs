namespace Rewired.Utils.Interfaces
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal interface IReadOnlyList
	{
		int Count { get; }

		object this[int index] { get; }

		int IndexOf(object value);

		bool Contains(object value);
	}
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal interface IReadOnlyList<T> : IReadOnlyList
	{
		new T this[int index] { get; }

		int IndexOf(T value);

		bool Contains(T value);
	}
}
