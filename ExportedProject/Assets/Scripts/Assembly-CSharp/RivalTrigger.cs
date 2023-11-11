using UnityEngine;

public class RivalTrigger : MonoBehaviour
{
	public Animator Cinnabay;

	public Animator BCC;

	public Animator Nenrei;

	public GameObject Cutscene;

	public GameObject Encounter;

	public float waitTime;

	public float waitTime2;

	public AudioSource WorldMusic;

	public AudioSource Theme;

	public bool FadeOut;

	public int RivalID;

	private void Start()
	{
	}

	private void Update()
	{
		if (FadeOut)
		{
			if (WorldMusic.volume > 0f)
			{
				WorldMusic.volume -= 0.5f;
				return;
			}
			PlayTheme();
			FadeOut = false;
		}
	}

	public void PlayTheme()
	{
	}

	public void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Player")
		{
			StartCoroutine("CutsceneStart");
			FadeOut = true;
			NenreiOW.canMove = false;
			Nenrei.SetFloat("Speed", 0f);
		}
	}

	public void CutsceneStart()
	{
		Encounter.SetActive(value: true);
	}
}
