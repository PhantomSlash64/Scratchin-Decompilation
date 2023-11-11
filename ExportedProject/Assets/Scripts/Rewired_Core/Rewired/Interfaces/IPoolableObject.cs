using System;

namespace Rewired.Interfaces
{
	public interface IPoolableObject : IDisposable
	{
		void Return();
	}
}
