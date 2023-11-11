using System.Collections;
using Rewired;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
	public GameObject Loading;

	public GameObject QuitFade;

	public AudioSource Tw_Loop;

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
		if (player.GetButtonDown("Butt1"))
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
			Loading.SetActive(value: true);
		}
		if (player.GetButtonDown("Butt2"))
		{
			QuitFade.SetActive(value: true);
			Tw_Loop.Stop();
			StartCoroutine(QuitGame());
		}
		static IEnumerator QuitGame()
		{
			yield return new WaitForSecondsRealtime(2f);
			SceneManager.LoadSceneAsync("Title");
		}
	}
}
