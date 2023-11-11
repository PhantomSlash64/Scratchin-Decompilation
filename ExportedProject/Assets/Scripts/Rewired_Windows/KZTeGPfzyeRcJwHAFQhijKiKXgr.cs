using System;
using System.Threading;

internal class KZTeGPfzyeRcJwHAFQhijKiKXgr
{
	public delegate void WWkCvTgbCkiwixevSQrpIiaofKHe();

	public delegate void hCAuougxsVdYMRHNGugKVHbdHXDc();

	private readonly tJKAaDrvDYPmVdvOWTbYhAqgFPi GjMLLAqOVACbxDjgBByztvjaQVC;

	private bool ervaETgRlvNpnxGMlWqweFgsAgO;

	public event WWkCvTgbCkiwixevSQrpIiaofKHe fyRODQZvhKNUDvfwaBKNUqYQxJV;

	public event hCAuougxsVdYMRHNGugKVHbdHXDc VvYvdNYqBDaKiaHHcgPFkOwqjfyH;

	public KZTeGPfzyeRcJwHAFQhijKiKXgr(tJKAaDrvDYPmVdvOWTbYhAqgFPi device)
	{
		GjMLLAqOVACbxDjgBByztvjaQVC = device;
	}

	public void yXtbQoGixuQSGXVAmsnwhfKJRzx()
	{
		Action action = HsIEMREDxeAnKedyqbkibQvpXLiH;
		action.BeginInvoke(xDIecdRCvMaTgzUjmYjtttlNfmq, action);
	}

	private void HsIEMREDxeAnKedyqbkibQvpXLiH()
	{
		bool isConnected = GjMLLAqOVACbxDjgBByztvjaQVC.fGcvLiXbUIhveYuKHpUprbEcdtk;
		if (isConnected != ervaETgRlvNpnxGMlWqweFgsAgO)
		{
			if (isConnected && this.fyRODQZvhKNUDvfwaBKNUqYQxJV != null)
			{
				this.fyRODQZvhKNUDvfwaBKNUqYQxJV();
			}
			else if (!isConnected && this.VvYvdNYqBDaKiaHHcgPFkOwqjfyH != null)
			{
				this.VvYvdNYqBDaKiaHHcgPFkOwqjfyH();
			}
			ervaETgRlvNpnxGMlWqweFgsAgO = isConnected;
		}
		Thread.Sleep(500);
		if (GjMLLAqOVACbxDjgBByztvjaQVC.qohGwlGbfglXFJjyfAOYMWFGXGRO)
		{
			yXtbQoGixuQSGXVAmsnwhfKJRzx();
		}
	}

	private static void xDIecdRCvMaTgzUjmYjtttlNfmq(IAsyncResult P_0)
	{
		((Action)P_0.AsyncState).EndInvoke(P_0);
	}
}
