namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal interface IObjectPool
	{
		void Clear(bool reduceSize = false);

		object Get();

		bool Return(object item);
	}
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal interface IObjectPool<T>
	{
		void Clear(bool reduceSize = false);

		T Get();

		bool Return(T item);
	}
}
