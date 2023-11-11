using System.ComponentModel;

namespace Rewired.Utils.Classes
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[Browsable(false)]
	public abstract class CodeHelper
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Browsable(false)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[Browsable(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}
}
