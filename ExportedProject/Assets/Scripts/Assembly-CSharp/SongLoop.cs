using SonicBloom.Koreo;
using UnityEngine;

public class SongLoop : MonoBehaviour
{
	public AudioSource Intro;

	public AudioSource Loop;

	public bool TitleScreen;

	[EventID]
	public string StartLoop;

	private void Start()
	{
		Koreographer.Instance.RegisterForEvents(StartLoop, On_StartLoop);
		if (TitleScreen)
		{
			PlayerPrefs.SetString("LastScene", "Title");
		}
	}

	private void Update()
	{
	}

	private void On_StartLoop(KoreographyEvent evt)
	{
		Intro.Stop();
		Loop.Play();
	}
}
