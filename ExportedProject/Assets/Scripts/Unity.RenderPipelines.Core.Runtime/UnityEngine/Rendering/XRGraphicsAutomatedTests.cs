using System;

namespace UnityEngine.Rendering
{
	public static class XRGraphicsAutomatedTests
	{
		public static bool running = false;

		private static bool activatedFromCommandLine => Array.Exists(Environment.GetCommandLineArgs(), (string arg) => arg == "-xr-tests");

		public static bool enabled { get; } = activatedFromCommandLine;

	}
}
