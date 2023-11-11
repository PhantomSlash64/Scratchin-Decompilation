using System;

namespace UnityEngine.U2D.Animation.TriangleNet.Logging
{
	internal interface ILogItem
	{
		DateTime Time { get; }

		LogLevel Level { get; }

		string Message { get; }

		string Info { get; }
	}
}
