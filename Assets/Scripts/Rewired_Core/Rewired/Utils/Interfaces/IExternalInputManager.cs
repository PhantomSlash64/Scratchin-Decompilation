using Rewired.Platforms;

namespace Rewired.Utils.Interfaces
{
	public interface IExternalInputManager
	{
		object Initialize(Platform platform, object configVars);

		void Deinitialize();
	}
}
