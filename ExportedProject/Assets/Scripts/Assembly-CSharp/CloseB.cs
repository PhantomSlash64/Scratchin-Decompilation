using Rewired;
using UnityEngine;
using UnityEngine.UI;

public class CloseB : MonoBehaviour
{
	public bool A_instead;

	public int playerId;

	private Player player;

	private CharacterController cc;

	public Button button;

	public Image current;

	public Sprite XB;

	public Sprite PS;

	public Sprite NS;

	public Sprite KB;

	public Sprite GEN;

	public int layout = 1;

	private void Start()
	{
		player = ReInput.players.GetPlayer(playerId);
		cc = GetComponent<CharacterController>();
	}

	private void Update()
	{
		if (player.GetButtonDown("UICancel") && !A_instead)
		{
			button.onClick.Invoke();
		}
		else if (player.GetButtonDown("UISubmit") && A_instead)
		{
			button.onClick.Invoke();
		}
		layout = PlayerPrefs.GetInt("CTRlayout");
		if (layout == 1)
		{
			GetComponent<Image>().sprite = XB;
		}
		else if (layout == 2)
		{
			GetComponent<Image>().sprite = PS;
		}
		else if (layout == 3)
		{
			GetComponent<Image>().sprite = NS;
		}
		else if (layout == 4)
		{
			GetComponent<Image>().sprite = KB;
		}
		else if (layout == 5)
		{
			GetComponent<Image>().sprite = GEN;
		}
	}
}
