using System.Diagnostics;

namespace Rewired
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal static class GCProfiler
	{
		[Conditional("ENABLE_GCPROFILER")]
		public static void Begin(string name)
		{
		}

		[Conditional("ENABLE_GCPROFILER")]
		public static void End()
		{
		}

		[Conditional("ENABLE_GCPROFILER")]
		public static void LogReport()
		{
		}

		[Conditional("ENABLE_GCPROFILER")]
		public static void Clear()
		{
		}
	}
}
