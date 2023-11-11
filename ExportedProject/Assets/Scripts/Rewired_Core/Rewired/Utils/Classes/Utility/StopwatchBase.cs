namespace Rewired.Utils.Classes.Utility
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal abstract class StopwatchBase
	{
		public abstract double offsetSeconds { get; set; }

		public abstract long offsetTicks { get; set; }

		public abstract double elapsedSeconds { get; }

		public abstract double elapsedSecondsRaw { get; }

		public abstract long elapsedMilliseconds { get; }

		public abstract long elapsedMillisecondsRaw { get; }

		public abstract long elapsedTicks { get; }

		public abstract long elapsedTicksRaw { get; }

		public abstract bool isRunning { get; }

		public abstract void Stop();

		public abstract void Start();

		public abstract void Reset();
	}
}
