using System;
using System.Runtime.CompilerServices;
using Rewired;
using Rewired.Interfaces;
using Rewired.Utils.Classes.Utility;

internal sealed class bjWEjHBROAVpeyUanBwIblyUmUNK : IDisposable, IControllerElementTarget, IPoolableObject, IPoolableObject_Internal
{
	private static ObjectPool<bjWEjHBROAVpeyUanBwIblyUmUNK> OeZIaPpiMBIVIXKLzKuDafhBeezh;

	private Controller bGNJaBTbykivsIWbGpkIOAQalRn;

	private int AlqqKkRsWUkTOzkmxGfVDUZYXTSf;

	private AxisRange gOyrPUAIUSFpmOhLYqogcFQxBEg;

	private IObjectPool OxvOwtjfWXoVegFVRChJqjUTwhk;

	private bool RFSEgUYkCipDyWyLEnlGiNDUlzz;

	[CompilerGenerated]
	private static Func<bjWEjHBROAVpeyUanBwIblyUmUNK> feNsFZUOhAfDWJOQenHKxUwAcDTR;

	public int elementIdentifierId => AlqqKkRsWUkTOzkmxGfVDUZYXTSf;

	public AxisRange axisRange => gOyrPUAIUSFpmOhLYqogcFQxBEg;

	public bool hasTarget => element != null;

	public ControllerElementType elementType
	{
		get
		{
			if (element == null)
			{
				return ControllerElementType.Axis;
			}
			return element.type;
		}
	}

	public string descriptiveName
	{
		get
		{
			if (bGNJaBTbykivsIWbGpkIOAQalRn == null)
			{
				return string.Empty;
			}
			ControllerElementIdentifier elementIdentifierById = bGNJaBTbykivsIWbGpkIOAQalRn.GetElementIdentifierById(AlqqKkRsWUkTOzkmxGfVDUZYXTSf);
			if (elementIdentifierById == null)
			{
				return string.Empty;
			}
			Controller.Element elementById = bGNJaBTbykivsIWbGpkIOAQalRn.GetElementById(AlqqKkRsWUkTOzkmxGfVDUZYXTSf);
			if (elementById == null)
			{
				return string.Empty;
			}
			return elementIdentifierById.GetDisplayName(elementById.type, gOyrPUAIUSFpmOhLYqogcFQxBEg);
		}
	}

	public Controller controller => bGNJaBTbykivsIWbGpkIOAQalRn;

	public Controller.Element element
	{
		get
		{
			if (bGNJaBTbykivsIWbGpkIOAQalRn == null)
			{
				return null;
			}
			ControllerElementIdentifier elementIdentifierById = bGNJaBTbykivsIWbGpkIOAQalRn.GetElementIdentifierById(AlqqKkRsWUkTOzkmxGfVDUZYXTSf);
			if (elementIdentifierById == null)
			{
				return null;
			}
			return bGNJaBTbykivsIWbGpkIOAQalRn.GetElementById(AlqqKkRsWUkTOzkmxGfVDUZYXTSf);
		}
	}

	public ControllerElementIdentifier kmkWsWMhHLwajiGilDirbTZiMLzd
	{
		get
		{
			if (bGNJaBTbykivsIWbGpkIOAQalRn == null)
			{
				return null;
			}
			return bGNJaBTbykivsIWbGpkIOAQalRn.GetElementIdentifierById(AlqqKkRsWUkTOzkmxGfVDUZYXTSf);
		}
	}

	IObjectPool IPoolableObject_Internal.URFOtkLNwGyIoRTgMtgxTNaXKxs
	{
		get
		{
			return OxvOwtjfWXoVegFVRChJqjUTwhk;
		}
		set
		{
			OxvOwtjfWXoVegFVRChJqjUTwhk = value;
		}
	}

	internal bjWEjHBROAVpeyUanBwIblyUmUNK(Controller controller, int elementIdentifierId, AxisRange axisRange)
	{
		bGNJaBTbykivsIWbGpkIOAQalRn = controller;
		AlqqKkRsWUkTOzkmxGfVDUZYXTSf = elementIdentifierId;
		gOyrPUAIUSFpmOhLYqogcFQxBEg = axisRange;
	}

	internal void jzPtspnkZAgrKJfuKATzOhURnEB(ControllerElementTarget P_0)
	{
		bGNJaBTbykivsIWbGpkIOAQalRn = P_0.controller;
		AlqqKkRsWUkTOzkmxGfVDUZYXTSf = P_0.elementIdentifierId;
		gOyrPUAIUSFpmOhLYqogcFQxBEg = P_0.axisRange;
	}

	internal void jzPtspnkZAgrKJfuKATzOhURnEB(IControllerElementTarget P_0)
	{
		bGNJaBTbykivsIWbGpkIOAQalRn = P_0.controller;
		AlqqKkRsWUkTOzkmxGfVDUZYXTSf = P_0.elementIdentifierId;
		gOyrPUAIUSFpmOhLYqogcFQxBEg = P_0.axisRange;
	}

	internal void jzPtspnkZAgrKJfuKATzOhURnEB(bjWEjHBROAVpeyUanBwIblyUmUNK P_0)
	{
		jzPtspnkZAgrKJfuKATzOhURnEB((IControllerElementTarget)P_0);
	}

	private void uivwYRNEghQlynWjhrACaDAdyET()
	{
		bGNJaBTbykivsIWbGpkIOAQalRn = null;
		AlqqKkRsWUkTOzkmxGfVDUZYXTSf = -1;
		gOyrPUAIUSFpmOhLYqogcFQxBEg = AxisRange.Full;
	}

	void IPoolableObject_Internal.Clear()
	{
		//ILSpy generated this explicit interface implementation from .override directive in uivwYRNEghQlynWjhrACaDAdyET
		this.uivwYRNEghQlynWjhrACaDAdyET();
	}

	private void RLOrTLkTcvDlApGvIOfPhlLdGQN()
	{
		if (OxvOwtjfWXoVegFVRChJqjUTwhk != null)
		{
			OxvOwtjfWXoVegFVRChJqjUTwhk.Return(this);
		}
	}

	void IPoolableObject.Return()
	{
		//ILSpy generated this explicit interface implementation from .override directive in RLOrTLkTcvDlApGvIOfPhlLdGQN
		this.RLOrTLkTcvDlApGvIOfPhlLdGQN();
	}

	internal static bjWEjHBROAVpeyUanBwIblyUmUNK UKQvGkzCJAbJnKtAMsajOiGhqqO()
	{
		if (OeZIaPpiMBIVIXKLzKuDafhBeezh == null)
		{
			OeZIaPpiMBIVIXKLzKuDafhBeezh = new ObjectPool<bjWEjHBROAVpeyUanBwIblyUmUNK>(() => kbUEkrjNKrFkwKWFaqXQToCsrDji());
		}
		return OeZIaPpiMBIVIXKLzKuDafhBeezh.Get();
	}

	internal static bjWEjHBROAVpeyUanBwIblyUmUNK UKQvGkzCJAbJnKtAMsajOiGhqqO(ControllerElementTarget P_0)
	{
		bjWEjHBROAVpeyUanBwIblyUmUNK bjWEjHBROAVpeyUanBwIblyUmUNK2 = UKQvGkzCJAbJnKtAMsajOiGhqqO();
		bjWEjHBROAVpeyUanBwIblyUmUNK2.jzPtspnkZAgrKJfuKATzOhURnEB(P_0);
		return bjWEjHBROAVpeyUanBwIblyUmUNK2;
	}

	internal static void FiATKxCfZoUkEvsaOqFpRJSJFZtH(bjWEjHBROAVpeyUanBwIblyUmUNK P_0)
	{
		if (P_0 != null && OeZIaPpiMBIVIXKLzKuDafhBeezh != null)
		{
			OeZIaPpiMBIVIXKLzKuDafhBeezh.Return(P_0);
		}
	}

	internal static bjWEjHBROAVpeyUanBwIblyUmUNK kbUEkrjNKrFkwKWFaqXQToCsrDji()
	{
		return new bjWEjHBROAVpeyUanBwIblyUmUNK(null, -1, AxisRange.Full);
	}

	void IDisposable.Dispose()
	{
		vLCbxFvjSKbaoKsQRAbGNRMrnwI(true);
		GC.SuppressFinalize(this);
	}

	~bjWEjHBROAVpeyUanBwIblyUmUNK()
	{
		vLCbxFvjSKbaoKsQRAbGNRMrnwI(false);
	}

	private void vLCbxFvjSKbaoKsQRAbGNRMrnwI(bool P_0)
	{
		if (!RFSEgUYkCipDyWyLEnlGiNDUlzz)
		{
			if (P_0)
			{
				((IPoolableObject)this).Return();
			}
			RFSEgUYkCipDyWyLEnlGiNDUlzz = true;
		}
	}

	[CompilerGenerated]
	private static bjWEjHBROAVpeyUanBwIblyUmUNK YtFRLbTkBTqAPEmufUtDlBrHmDc()
	{
		return kbUEkrjNKrFkwKWFaqXQToCsrDji();
	}
}
