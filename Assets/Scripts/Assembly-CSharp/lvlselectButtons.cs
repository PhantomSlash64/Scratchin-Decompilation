using Rewired;
using UnityEngine;

public class lvlselectButtons : MonoBehaviour
{
	public int playerId;

	private Player player;

	private CharacterController cc;

	public GameObject DiffMenu;

	public GameObject EventSys;

	public GameObject Self;

	private void Start()
	{
		player = ReInput.players.GetPlayer(playerId);
		cc = GetComponent<CharacterController>();
	}

	private void Update()
	{
		if (player.GetButtonDown("Butt3"))
		{
			DiffMenu.SetActive(value: true);
			EventSys.SetActive(value: false);
			Self.SetActive(value: false);
		}
	}
}
