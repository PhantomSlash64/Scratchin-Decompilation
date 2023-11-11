using SonicBloom.Koreo;
using UnityEngine;

public class IntroGP : MonoBehaviour
{
	public bool Door;

	public int HW;

	public Animator door1;

	public Animator door2;

	public GameObject Synth;

	public GameObject Mel;

	public GameObject SillyWalk;

	public GameObject HandWash;

	public GameObject BuildingBounce;

	public Animator MainCam;

	public GameObject LookIt;

	public GameObject Scene1;

	public GameObject Scene0;

	public GameObject Clock;

	public GameObject Customers;

	public Camera camera1;

	public Camera camera2;

	public bool Luigi;

	public int readycount;

	[EventID]
	public string DoorOpen;

	[EventID]
	public string DoorOpen1;

	[EventID]
	public string SillyWalky;

	[EventID]
	public string HandWashin;

	[EventID]
	public string GetReady;

	private void Start()
	{
		camera1.enabled = true;
		camera2.enabled = false;
		Koreographer.Instance.RegisterForEvents(DoorOpen, On_DoorOpen);
		Koreographer.Instance.RegisterForEvents(DoorOpen1, On_DoorOpen1);
		Koreographer.Instance.RegisterForEvents(SillyWalky, On_SillyWalk);
		Koreographer.Instance.RegisterForEvents(HandWashin, On_HandWash);
		Koreographer.Instance.RegisterForEvents(GetReady, On_GetReady);
	}

	private void On_DoorOpen(KoreographyEvent evt)
	{
		BuildingBounce.SetActive(value: false);
		HandWash.SetActive(value: false);
		door1.SetTrigger("open");
		Synth.SetActive(value: true);
		MainCam.SetTrigger("next");
	}

	private void On_DoorOpen1(KoreographyEvent evt)
	{
		door2.SetTrigger("open");
		Mel.SetActive(value: true);
	}

	private void On_SillyWalk(KoreographyEvent evt)
	{
		if (!Door && !Luigi)
		{
			Door = true;
			camera2.enabled = true;
			camera1.enabled = false;
			SillyWalk.SetActive(value: true);
		}
		else if (Door && !Luigi)
		{
			camera2.enabled = false;
			camera1.enabled = true;
			SillyWalk.SetActive(value: false);
			Clock.SetActive(value: true);
			Luigi = true;
			Door = false;
		}
		else if (!Door && Luigi)
		{
			Clock.SetActive(value: false);
			LookIt.SetActive(value: true);
			Luigi = true;
		}
	}

	private void On_HandWash(KoreographyEvent evt)
	{
		HandWash.SetActive(value: true);
	}

	private void On_GetReady(KoreographyEvent evt)
	{
		Scene0.SetActive(value: false);
		LookIt.SetActive(value: false);
		Scene1.SetActive(value: true);
		Customers.SetActive(value: true);
	}

	private void Update()
	{
	}
}
