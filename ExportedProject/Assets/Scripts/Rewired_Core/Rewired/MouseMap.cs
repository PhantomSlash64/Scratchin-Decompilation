using System;

namespace Rewired
{
	public sealed class MouseMap : ControllerMapWithAxes
	{
		public MouseMap()
		{
		}

		public MouseMap(MouseMap mouseMap)
			: base(mouseMap)
		{
		}

		internal void VHccjfEMNntOyUjHbKfsjtKQWZf(Guid P_0, int P_1, int P_2)
		{
			_hardwareGuid = P_0;
			_categoryId = P_1;
			_layoutId = P_2;
		}

		internal static MouseMap EOKwQcxsIwIbTLRXRRCTTzrEDPK(Guid P_0, int P_1, int P_2)
		{
			MouseMap mouseMap = new MouseMap();
			mouseMap._hardwareGuid = P_0;
			mouseMap._categoryId = P_1;
			mouseMap._layoutId = P_2;
			mouseMap._sourceMapId = -1;
			return mouseMap;
		}
	}
}
