using Rewired.Utils;

namespace Rewired
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	[CustomObfuscation(rename = false)]
	internal class UnknownControllerHat
	{
		[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
		[CustomObfuscation(rename = false)]
		public class HatButtons
		{
			private int[] ifqVRInjAzRYJsVFyORpqnnqXsX;

			public int this[int index] => ifqVRInjAzRYJsVFyORpqnnqXsX[index];

			public HatButtons(int[] buttons)
			{
				ifqVRInjAzRYJsVFyORpqnnqXsX = buttons;
			}

			public void GetNeighbors(int button, out int neighbor1, out int neighbor2)
			{
				int num = IndexOf(button);
				if (num < 0)
				{
					neighbor1 = -1;
					neighbor2 = -1;
					return;
				}
				if (num > 0)
				{
					neighbor1 = ifqVRInjAzRYJsVFyORpqnnqXsX[num - 1];
				}
				else
				{
					neighbor1 = ifqVRInjAzRYJsVFyORpqnnqXsX[ifqVRInjAzRYJsVFyORpqnnqXsX.Length - 1];
				}
				if (num >= ifqVRInjAzRYJsVFyORpqnnqXsX.Length - 1)
				{
					neighbor2 = ifqVRInjAzRYJsVFyORpqnnqXsX[0];
				}
				else
				{
					neighbor2 = ifqVRInjAzRYJsVFyORpqnnqXsX[num + 1];
				}
			}

			public bool IsCardinal(int button)
			{
				int num = IndexOf(button);
				if (num < 0)
				{
					return false;
				}
				return MathTools.IsEven(num);
			}

			public bool IsCorner(int button)
			{
				int num = IndexOf(button);
				if (num < 0)
				{
					return false;
				}
				return !MathTools.IsEven(num);
			}

			public int IndexOf(int button)
			{
				for (int i = 0; i < ifqVRInjAzRYJsVFyORpqnnqXsX.Length; i++)
				{
					if (ifqVRInjAzRYJsVFyORpqnnqXsX[i] == button)
					{
						return i;
					}
				}
				return -1;
			}

			public bool Contains(int button)
			{
				return IndexOf(button) >= 0;
			}
		}

		private HatButtons ifqVRInjAzRYJsVFyORpqnnqXsX;

		public UnknownControllerHat(HatButtons buttons)
		{
			ifqVRInjAzRYJsVFyORpqnnqXsX = buttons;
		}

		public bool ContainsButtonIndex(int index)
		{
			for (int i = 0; i < 8; i++)
			{
				if (ifqVRInjAzRYJsVFyORpqnnqXsX.Contains(index))
				{
					return true;
				}
			}
			return false;
		}

		public bool IsButtonIndexCardinal(int index)
		{
			for (int i = 0; i < 8; i++)
			{
				if (ifqVRInjAzRYJsVFyORpqnnqXsX.IsCardinal(index))
				{
					return true;
				}
			}
			return false;
		}

		public HatButtons GetButtons()
		{
			return ifqVRInjAzRYJsVFyORpqnnqXsX;
		}
	}
}
