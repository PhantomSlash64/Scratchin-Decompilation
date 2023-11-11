using Rewired;
using UnityEngine;

public class Item : MonoBehaviour
{
	public GameObject notifBox;

	public GameObject Selector;

	public bool nearby;

	public bool notifup;

	public Animator playerAn;

	public GameObject self;

	public GameObject inventoryGO;

	public AudioSource music;

	public AudioSource ItemSound;

	public SpriteRenderer rend;

	public CircleCollider2D collo;

	public string item;

	public int playerId;

	private Player player;

	private CharacterController cc;

	private void Start()
	{
		player = ReInput.players.GetPlayer(playerId);
		cc = GetComponent<CharacterController>();
	}

	private void Update()
	{
	}

	public void NotifUp()
	{
		self.SetActive(value: false);
		notifup = true;
		notifBox.SetActive(value: true);
		inventoryGO.SetActive(value: true);
		ItemSound.Play();
		music.mute = true;
		rend.enabled = false;
		collo.enabled = false;
		if (item == "keyboard")
		{
			NenreiOW.hasKeyboard = true;
		}
	}

	public void GiveItem()
	{
		if (item == "keyboard")
		{
			NenreiOW.hasKeyboard = true;
			ES3.Save("Keyboard", 1);
		}
	}

	public void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			nearby = true;
			Selector.SetActive(value: true);
		}
	}

	public void OnTriggerExit2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			nearby = false;
			Selector.SetActive(value: false);
		}
	}
}
