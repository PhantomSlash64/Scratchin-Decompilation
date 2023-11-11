namespace Rewired.Utils.Classes.Data
{
	[CustomClassObfuscation(renamePrivateMembers = true, renamePubIntMembers = false)]
	[CustomObfuscation(rename = false)]
	internal struct ReadOnlyArrayStruct<T>
	{
		private T[] wEPcgKANvjiwMEIbQyYAmClQoemS;

		public int Length
		{
			get
			{
				if (wEPcgKANvjiwMEIbQyYAmClQoemS == null)
				{
					return 0;
				}
				return wEPcgKANvjiwMEIbQyYAmClQoemS.Length;
			}
		}

		public T this[int index] => wEPcgKANvjiwMEIbQyYAmClQoemS[index];

		public ReadOnlyArrayStruct(T[] array)
		{
			wEPcgKANvjiwMEIbQyYAmClQoemS = array;
		}
	}
}
