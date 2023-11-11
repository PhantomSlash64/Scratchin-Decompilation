using Rewired;
using SonicBloom.Koreo;
using UnityEngine;

public class SkipIntro : MonoBehaviour
{
	public int playerId;

	private Player player;

	private CharacterController cc;

	public bool forwarding;

	public AudioSource Song;

	public AudioSource SongFree;

	public float Speed;

	public Animator FFWScreen;

	public bool Done;

	public bool NoFreeMode;

	public static bool Alive = true;

	[EventID]
	public string Checkpoint;

	private void Start()
	{
		player = ReInput.players.GetPlayer(playerId);
		cc = GetComponent<CharacterController>();
		Koreographer.Instance.RegisterForEvents(Checkpoint, On_Checkpoint);
	}

	private void On_Checkpoint(KoreographyEvent evt)
	{
		if (Alive)
		{
			Time.timeScale = 1f;
			Song.pitch = 1f;
			if (!NoFreeMode)
			{
				SongFree.pitch = 1f;
			}
			forwarding = false;
			FFWScreen.SetTrigger("Out");
			Done = true;
			Alive = false;
		}
	}

	private void Update()
	{
		if (player.GetButtonDown("FastForward") && !forwarding && !Done && Alive)
		{
			FFWScreen.SetFloat("Speed", Speed);
			Time.timeScale = Speed;
			forwarding = true;
			Song.pitch = Speed;
			if (!NoFreeMode)
			{
				SongFree.pitch = Speed;
			}
			FFWScreen.SetTrigger("In");
		}
	}
}
