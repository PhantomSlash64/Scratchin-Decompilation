using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Rewired.Utils
{
	[CustomObfuscation(rename = false)]
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	internal static class EmptyObjects<T>
	{
		private static T[] wEPcgKANvjiwMEIbQyYAmClQoemS;

		private static IList<T> zFoTmGskQwGUEDeAFlNnKmuhYWD;

		public static T[] array => wEPcgKANvjiwMEIbQyYAmClQoemS ?? (wEPcgKANvjiwMEIbQyYAmClQoemS = new T[0]);

		public static IList<T> EmptyReadOnlyIListT => zFoTmGskQwGUEDeAFlNnKmuhYWD ?? (zFoTmGskQwGUEDeAFlNnKmuhYWD = new ReadOnlyCollection<T>(new List<T>()));
	}
}
