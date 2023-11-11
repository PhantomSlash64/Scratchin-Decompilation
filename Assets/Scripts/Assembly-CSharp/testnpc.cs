using KetosGames.SceneTransition;
using Rewired;
using UnityEngine;

public class testnpc : MonoBehaviour
{
	public int playerId;

	private Player player;

	private CharacterController cc;

	public GameObject textBox;

	public GameObject Choice;

	public bool nearby;

	public GameObject playerObj;

	public Animator Player;

	public Animator doorfade;

	public bool NeedKBToPass;

	public bool hasKeyboard;

	public bool Door;

	public bool SceneDoor;

	public Vector3 TakeTo;

	public GameObject CurrentCam;

	public GameObject NewCam;

	public GameObject doorBlack;

	public bool CamReady;

	public bool Instant;

	public bool active;

	public bool InstaCutscene;

	public GameObject Cutscene;

	public bool Important;

	public GameObject Notif;

	public bool Person;

	public Animator NPC;

	public AudioSource bgmusic;

	public bool IsCutscene;

	public bool readytogo;

	public string NextScene;

	public bool musicbox;

	public Animator MusicBox;

	public bool done;

	public GameObject Lock;

	public GameObject Close;

	public GameObject ItemGet;

	public GameObject StickerBook;

	public CircleCollider2D collo;

	public bool NeedsCollo;

	public bool SpecialNPC;

	public bool flip;

	public SpriteRenderer Character;

	public Animator MelodiiActor;

	public bool InMenu;

	public static bool MusicTime;

	private void Start()
	{
		player = ReInput.players.GetPlayer(playerId);
		cc = GetComponent<CharacterController>();
	}

	private void Update()
	{
		if (NenreiOW.InMenu)
		{
			InMenu = true;
		}
		if (active)
		{
			if (!Door && player.GetButtonDown("UISubmit") && nearby)
			{
				textBox.SetActive(value: true);
				ObjectText.amorgos = true;
				if (NeedsCollo)
				{
					collo.enabled = false;
				}
				if (Important)
				{
					Notif.SetActive(value: false);
				}
				_ = Person;
				if (SpecialNPC)
				{
					MelodiiActor.SetTrigger("34");
					if (flip)
					{
						if (!Character.flipX)
						{
							Character.flipX = true;
						}
						else
						{
							Character.flipX = false;
						}
					}
				}
			}
			if (Door)
			{
				if (player.GetButtonDown("UISubmit") && nearby && NeedKBToPass)
				{
					if (!NenreiOW.hasKeyboard)
					{
						textBox.SetActive(value: true);
						ObjectText.amorgos = true;
						if (NeedsCollo)
						{
							collo.enabled = false;
						}
					}
					else if (NenreiOW.hasKeyboard)
					{
						doorfade.SetTrigger("go");
						playerObj.transform.position = TakeTo;
						textBox.SetActive(value: false);
					}
				}
				else if (nearby && Instant)
				{
					playerObj.transform.position = TakeTo;
				}
				if (doorBlack.activeInHierarchy)
				{
					CamReady = true;
					active = false;
				}
				if (CamReady)
				{
					SwitchCam();
				}
			}
			if (SceneDoor)
			{
				if (player.GetButtonDown("UISubmit") && nearby && !readytogo && !NenreiOW.InMenu)
				{
					textBox.SetActive(value: true);
					NenreiOW.InMenu = true;
				}
			}
			else if (nearby && Instant)
			{
				playerObj.transform.position = TakeTo;
			}
		}
		if (InstaCutscene)
		{
			Cutscene.SetActive(value: true);
			if (Important)
			{
				Notif.SetActive(value: false);
			}
		}
		if (IsCutscene && Cutscene.activeInHierarchy)
		{
			bgmusic.Stop();
		}
		if (!musicbox || done)
		{
			return;
		}
		if (player.GetButtonDown("UISubmit") && nearby && Lock.activeInHierarchy && NenreiOW.canMove)
		{
			textBox.SetActive(value: true);
			NenreiOW.canMove = false;
			NenreiOW.InMenu = true;
			MusicTime = true;
		}
		if (Choice.activeInHierarchy)
		{
			NenreiOW.canMove = false;
			NenreiOW.InMenu = true;
		}
		if (Close.activeInHierarchy)
		{
			if (player.GetButtonDown("UISubmit"))
			{
				MusicBox.SetTrigger("end");
				Lock.SetActive(value: false);
				done = true;
				active = false;
				Player.SetTrigger("CloseNotif");
				NenreiOW.canMove = true;
				ObjectText.amorgos = false;
				bgmusic.Play();
			}
			if (player.GetButtonDown("Butt3"))
			{
				Lock.SetActive(value: false);
				done = true;
				active = false;
				MusicBox.SetTrigger("end");
				Lock.SetActive(value: false);
				bgmusic.Play();
				StickerBook.SetActive(value: true);
			}
		}
	}

	public void StartMusicBox()
	{
		MusicBox.SetTrigger("go");
		active = false;
		NenreiOW.canMove = false;
		NenreiOW.InMenu = true;
		textBox.SetActive(value: false);
	}

	private void SwitchCam()
	{
		CamReady = false;
		CurrentCam.SetActive(value: false);
		NewCam.SetActive(value: true);
	}

	public void Done()
	{
		collo.enabled = true;
	}

	public void ExitDoor()
	{
		doorfade.SetTrigger("goExit");
		SceneLoader.LoadScene(NextScene);
	}

	public void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Player" && NenreiOW.canMove)
		{
			nearby = true;
			active = true;
		}
		if (coll.gameObject.name == "HasKeyboard")
		{
			hasKeyboard = true;
		}
	}

	public void OnTriggerExit2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			nearby = false;
		}
		if (coll.gameObject.name == "HasKeyboard")
		{
			hasKeyboard = false;
		}
	}
}
