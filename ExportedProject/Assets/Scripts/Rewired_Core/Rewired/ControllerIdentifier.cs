using System;

namespace Rewired
{
	public struct ControllerIdentifier
	{
		private int BUaVcuFwTcIVxSAyrnOfAxOjuhI;

		private ControllerType DdmGAhnWjBkGezCJigEsEoriSFLq;

		private Guid cBbvDblDdxYvWIffImKZKlfGJPE;

		private string gxbsVYNDSSQzqJJFSMAGUOBIgei;

		private Guid fjSleAyNNzAAwUFQRDtsPmEVFPD;

		public int controllerId
		{
			get
			{
				return BUaVcuFwTcIVxSAyrnOfAxOjuhI;
			}
			set
			{
				BUaVcuFwTcIVxSAyrnOfAxOjuhI = value;
			}
		}

		public ControllerType controllerType
		{
			get
			{
				return DdmGAhnWjBkGezCJigEsEoriSFLq;
			}
			set
			{
				DdmGAhnWjBkGezCJigEsEoriSFLq = value;
			}
		}

		public Guid hardwareTypeGuid
		{
			get
			{
				return cBbvDblDdxYvWIffImKZKlfGJPE;
			}
			set
			{
				cBbvDblDdxYvWIffImKZKlfGJPE = value;
			}
		}

		public string hardwareIdentifier
		{
			get
			{
				return gxbsVYNDSSQzqJJFSMAGUOBIgei;
			}
			set
			{
				gxbsVYNDSSQzqJJFSMAGUOBIgei = value;
			}
		}

		public Guid deviceInstanceGuid
		{
			get
			{
				return fjSleAyNNzAAwUFQRDtsPmEVFPD;
			}
			set
			{
				fjSleAyNNzAAwUFQRDtsPmEVFPD = value;
			}
		}

		public static ControllerIdentifier Blank
		{
			get
			{
				ControllerIdentifier result = default(ControllerIdentifier);
				result.BUaVcuFwTcIVxSAyrnOfAxOjuhI = -1;
				return result;
			}
		}

		internal ControllerIdentifier(Controller controller)
		{
			BUaVcuFwTcIVxSAyrnOfAxOjuhI = controller.id;
			DdmGAhnWjBkGezCJigEsEoriSFLq = controller.type;
			cBbvDblDdxYvWIffImKZKlfGJPE = controller.cBbvDblDdxYvWIffImKZKlfGJPE;
			gxbsVYNDSSQzqJJFSMAGUOBIgei = controller.hardwareIdentifier;
			fjSleAyNNzAAwUFQRDtsPmEVFPD = controller.deviceInstanceGuid;
		}
	}
}
