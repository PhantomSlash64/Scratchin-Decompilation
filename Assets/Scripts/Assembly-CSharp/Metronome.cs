using KetosGames.SceneTransition;
using Rewired;
using SonicBloom.Koreo;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Metronome : MonoBehaviour
{
	public int playerId;

	private Player player;

	private CharacterController cc;

	public AudioListener Listener;

	public Animator Tick1;

	public Animator Tick2;

	public Animator Tick3;

	public Animator Tick4;

	public int tick = 1;

	public TextMeshProUGUI VisMs;

	public Slider VDslider;

	public float NewDelayMs;

	public float defaultValue;

	public GameObject StoryNext;

	public GameObject Next;

	public int story;

	public static bool OptMenu;

	public string CurrentScene;

	[EventID]
	public string Beat1;

	[EventID]
	public string Beat2;

	[EventID]
	public string Beat3;

	[EventID]
	public string Beat4;

	private void Start()
	{
		player = ReInput.players.GetPlayer(playerId);
		cc = GetComponent<CharacterController>();
		story = PlayerPrefs.GetInt("Story");
		Koreographer.Instance.RegisterForEvents(Beat1, On_Beat1);
		Koreographer.Instance.RegisterForEvents(Beat2, On_Beat2);
		Koreographer.Instance.RegisterForEvents(Beat3, On_Beat3);
		Koreographer.Instance.RegisterForEvents(Beat4, On_Beat4);
		Koreographer.Instance.EventDelayInSeconds = ES3.Load("VisDelay", defaultValue);
		float value = ES3.Load("VisDelay", defaultValue);
		VDslider.value = value;
		SetNewDelay(VDslider.value);
		if (!LevelSelect.InStory)
		{
			Listener.enabled = false;
			GameObject[] array = GameObject.FindGameObjectsWithTag("Music");
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GetComponent<AudioSource>().Pause();
			}
		}
		SceneManager.SetActiveScene(SceneManager.GetSceneByName("Calibration"));
		CurrentScene = PlayerPrefs.GetString("LastScene");
	}

	private void Awake()
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("ExitButton2");
		for (int i = 0; i < array.Length; i++)
		{
			array[i].GetComponent<CloseB>().enabled = false;
		}
	}

	private void Update()
	{
		if (!player.GetButtonDown("UISubmit"))
		{
			return;
		}
		if (!LevelSelect.InStory)
		{
			SceneManager.UnloadSceneAsync("Calibration");
			GameObject[] array = GameObject.FindGameObjectsWithTag("Music");
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GetComponent<AudioSource>().Play();
			}
			array = GameObject.FindGameObjectsWithTag("ExitButton2");
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GetComponent<CloseB>().enabled = true;
			}
		}
		else
		{
			SceneLoader.LoadScene("How2Funk");
		}
	}

	public void SetNewDelay(float newDelay)
	{
		Koreographer.Instance.EventDelayInSeconds = newDelay;
		NewDelayMs = newDelay * 1000f;
		VisMs.text = NewDelayMs.ToString("0.##") + "ms";
		ES3.Save("VisDelay", newDelay);
	}

	private void On_Beat1(KoreographyEvent evt)
	{
		Tick1.SetTrigger("go");
	}

	private void On_Beat2(KoreographyEvent evt)
	{
		Tick1.SetTrigger("go2");
	}

	private void On_Beat3(KoreographyEvent evt)
	{
		Tick1.SetTrigger("go3");
	}

	private void On_Beat4(KoreographyEvent evt)
	{
		Tick1.SetTrigger("go4");
	}
}
