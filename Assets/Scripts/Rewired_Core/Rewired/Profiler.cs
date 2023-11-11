using System.Diagnostics;
using UnityEngine;

namespace Rewired
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePubIntMembers = false)]
	internal static class Profiler
	{
		private const string JmufJlLOTkEgnyrPODvvzNwiDxUa = "ENABLE_PROFILER must be set in Rewired Core to use the profiler.";

		public static bool enableBinaryLog
		{
			get
			{
				JXdlYFCbozeSrjhxEZCNurECdgA();
				return false;
			}
			set
			{
				JXdlYFCbozeSrjhxEZCNurECdgA();
			}
		}

		public static bool enabled
		{
			get
			{
				JXdlYFCbozeSrjhxEZCNurECdgA();
				return false;
			}
			set
			{
				JXdlYFCbozeSrjhxEZCNurECdgA();
			}
		}

		public static string logFile
		{
			get
			{
				JXdlYFCbozeSrjhxEZCNurECdgA();
				return string.Empty;
			}
			set
			{
				JXdlYFCbozeSrjhxEZCNurECdgA();
			}
		}

		public static bool supported
		{
			get
			{
				JXdlYFCbozeSrjhxEZCNurECdgA();
				return false;
			}
		}

		public static uint usedHeapSize
		{
			get
			{
				JXdlYFCbozeSrjhxEZCNurECdgA();
				return 0u;
			}
		}

		public static long usedHeapSizeLong
		{
			get
			{
				JXdlYFCbozeSrjhxEZCNurECdgA();
				return 0L;
			}
		}

		private static void JXdlYFCbozeSrjhxEZCNurECdgA()
		{
			Logger.Log("ENABLE_PROFILER must be set in Rewired Core to use the profiler.");
		}

		[Conditional("ENABLE_PROFILER")]
		public static void AddFramesFromFile(string file)
		{
			JXdlYFCbozeSrjhxEZCNurECdgA();
		}

		[Conditional("ENABLE_PROFILER")]
		public static void BeginSample(string name)
		{
			JXdlYFCbozeSrjhxEZCNurECdgA();
		}

		[Conditional("ENABLE_PROFILER")]
		public static void BeginSample(string name, Object targetObject)
		{
			JXdlYFCbozeSrjhxEZCNurECdgA();
		}

		[Conditional("ENABLE_PROFILER")]
		public static void EndSample()
		{
			JXdlYFCbozeSrjhxEZCNurECdgA();
		}

		public static uint GetMonoHeapSize()
		{
			JXdlYFCbozeSrjhxEZCNurECdgA();
			return 0u;
		}

		public static long GetMonoHeapSizeLong()
		{
			return 0L;
		}

		public static uint GetMonoUsedSize()
		{
			JXdlYFCbozeSrjhxEZCNurECdgA();
			return 0u;
		}

		public static long GetMonoUsedSizeLong()
		{
			return 0L;
		}

		public static int GetRuntimeMemorySize(Object o)
		{
			JXdlYFCbozeSrjhxEZCNurECdgA();
			return 0;
		}

		public static long GetRuntimeMemorySizeLong(Object o)
		{
			return 0L;
		}

		public static uint GetTotalAllocatedMemory()
		{
			JXdlYFCbozeSrjhxEZCNurECdgA();
			return 0u;
		}

		public static long GetTotalAllocatedMemoryLong()
		{
			return 0L;
		}

		public static uint GetTotalReservedMemory()
		{
			return 0u;
		}

		public static long GetTotalReservedMemoryLong()
		{
			return 0L;
		}

		public static uint GetTotalUnusedReservedMemory()
		{
			return 0u;
		}

		public static long GetTotalUnusedReservedMemoryLong()
		{
			return 0L;
		}
	}
}
