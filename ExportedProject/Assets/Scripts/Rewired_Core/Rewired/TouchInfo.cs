using UnityEngine;

namespace Rewired
{
	[CustomClassObfuscation(renamePubIntMembers = false, renamePrivateMembers = true)]
	[CustomObfuscation(rename = false)]
	internal struct TouchInfo
	{
		private bool BhyuisYWlCQCMQSIXrzMJaxECAD;

		private int xhztpkCOADIgtUXivpaIPkiDdnj;

		private Vector2 LmiVXiAGyYIvfWTqqRlczAlTDtp;

		private Vector2 ffALxPbXARVIDrQfemNTfFgOzvT;

		private Vector2 ztJLXTqAAWhLLjuibNmDaKSdCYFh;

		private Vector2 nxoMSRAiXFAPSIMkTAVjgDvFUoSW;

		private float lyAFKghMzaZYvGtaEBzZyWGoyC;

		private int riUHCYOeJTAGtAkkKZASngeOHFI;

		public bool isValid
		{
			get
			{
				return BhyuisYWlCQCMQSIXrzMJaxECAD;
			}
			internal set
			{
				BhyuisYWlCQCMQSIXrzMJaxECAD = value;
			}
		}

		public int touchId
		{
			get
			{
				return xhztpkCOADIgtUXivpaIPkiDdnj;
			}
			internal set
			{
				xhztpkCOADIgtUXivpaIPkiDdnj = value;
			}
		}

		public Vector2 touchPos
		{
			get
			{
				return LmiVXiAGyYIvfWTqqRlczAlTDtp;
			}
			internal set
			{
				LmiVXiAGyYIvfWTqqRlczAlTDtp = value;
			}
		}

		public Vector2 touchPosRaw
		{
			get
			{
				return ffALxPbXARVIDrQfemNTfFgOzvT;
			}
			internal set
			{
				ffALxPbXARVIDrQfemNTfFgOzvT = value;
			}
		}

		public Vector2 deltaPos
		{
			get
			{
				return ztJLXTqAAWhLLjuibNmDaKSdCYFh;
			}
			internal set
			{
				ztJLXTqAAWhLLjuibNmDaKSdCYFh = value;
			}
		}

		public Vector2 deltaPosRaw
		{
			get
			{
				return nxoMSRAiXFAPSIMkTAVjgDvFUoSW;
			}
			internal set
			{
				nxoMSRAiXFAPSIMkTAVjgDvFUoSW = value;
			}
		}

		public float deltaTime
		{
			get
			{
				return lyAFKghMzaZYvGtaEBzZyWGoyC;
			}
			internal set
			{
				lyAFKghMzaZYvGtaEBzZyWGoyC = value;
			}
		}

		public int tapCount
		{
			get
			{
				return riUHCYOeJTAGtAkkKZASngeOHFI;
			}
			internal set
			{
				riUHCYOeJTAGtAkkKZASngeOHFI = value;
			}
		}

		internal static TouchInfo Invalid
		{
			get
			{
				TouchInfo result = default(TouchInfo);
				result.BhyuisYWlCQCMQSIXrzMJaxECAD = false;
				return result;
			}
		}

		internal TouchInfo(bool isValid, int touchId, Vector2 touchPos, Vector2 touchPosRaw, Vector2 deltaPos, Vector2 deltaPosRaw, float deltaTime, int tapCount)
		{
			BhyuisYWlCQCMQSIXrzMJaxECAD = isValid;
			xhztpkCOADIgtUXivpaIPkiDdnj = touchId;
			LmiVXiAGyYIvfWTqqRlczAlTDtp = touchPos;
			ffALxPbXARVIDrQfemNTfFgOzvT = touchPosRaw;
			ztJLXTqAAWhLLjuibNmDaKSdCYFh = deltaPos;
			nxoMSRAiXFAPSIMkTAVjgDvFUoSW = deltaPosRaw;
			lyAFKghMzaZYvGtaEBzZyWGoyC = deltaTime;
			riUHCYOeJTAGtAkkKZASngeOHFI = tapCount;
		}
	}
}
