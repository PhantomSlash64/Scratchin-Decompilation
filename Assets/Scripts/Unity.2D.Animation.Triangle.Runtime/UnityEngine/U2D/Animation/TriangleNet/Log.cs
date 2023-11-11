using System.Collections.Generic;
using UnityEngine.U2D.Animation.TriangleNet.Logging;

namespace UnityEngine.U2D.Animation.TriangleNet
{
	internal sealed class Log : ILog<LogItem>
	{
		private List<LogItem> log = new List<LogItem>();

		private LogLevel level;

		private static readonly Log instance;

		internal static bool Verbose { get; set; }

		internal static ILog<LogItem> Instance => instance;

		public IList<LogItem> Data => log;

		public LogLevel Level => level;

		static Log()
		{
			instance = new Log();
		}

		private Log()
		{
		}

		public void Add(LogItem item)
		{
			log.Add(item);
		}

		public void Clear()
		{
			log.Clear();
		}

		public void Info(string message)
		{
			log.Add(new LogItem(LogLevel.Info, message));
		}

		public void Warning(string message, string location)
		{
			log.Add(new LogItem(LogLevel.Warning, message, location));
		}

		public void Error(string message, string location)
		{
			log.Add(new LogItem(LogLevel.Error, message, location));
		}
	}
}
