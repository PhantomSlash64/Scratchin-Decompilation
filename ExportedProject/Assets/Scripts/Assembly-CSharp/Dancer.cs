using SonicBloom.Koreo;
using UnityEngine;

public class Dancer : MonoBehaviour
{
	public bool Half;

	public Animator dancer;

	public int BeatCount;

	[EventID]
	public string Beat;

	private void Start()
	{
		Koreographer.Instance.RegisterForEvents(Beat, On_Beat);
	}

	private void On_Beat(KoreographyEvent evt)
	{
		if (!Half)
		{
			dancer.SetTrigger("bop");
		}
		else if (BeatCount == 0)
		{
			BeatCount = 1;
			dancer.SetTrigger("bop");
		}
		else if (BeatCount == 1)
		{
			BeatCount = 0;
		}
	}
}
