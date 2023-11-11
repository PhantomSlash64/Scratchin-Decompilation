using KetosGames.SceneTransition;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
	public string CurrentScene;

	public int playerId;

	private Player player;

	private CharacterController cc;

	public bool LevelJumper;

	public string SceneName;

	public int LevelsUnlocked;

	public int LastLevel;

	public int LastLevelStory;

	public GameObject LVL1scr;

	public static int Level;

	public static bool InStory;

	public bool OptMenu;

	public bool InHub;

	public GameObject ClearSaveButton;

	public GameObject BGMusic;

	public AudioListener OptAudio;

	public GameObject OptLight;

	public bool ActualScene;

	public int SaveFile;

	public int defaultValue;

	public Animator DifficIcon;

	public string Difficulty;

	public int diffiValue = 1;

	public GameObject DifficultyMenu;

	public GameObject QGclose;

	public bool ChangingDiff;

	public bool StoryMode;

	public int story;

	public static bool DemoCompleted;

	public bool DemoComplete;

	public GameObject StoryWarning;

	public GameObject MenuEventSystem;

	public GameObject TitleMusic;

	public AudioSource NoWay;

	public GameObject CalibrationExit;

	public GameObject OptionsMenu;

	public GameObject LVL0;

	public GameObject Riv1;

	public GameObject Riv2;

	public GameObject Riv3;

	public GameObject LVL1;

	public TextMeshProUGUI DiffiTxt;

	public TextMeshProUGUI Riv1HS;

	public TextMeshProUGUI Riv2HS;

	public TextMeshProUGUI Riv3HS;

	public TextMeshProUGUI Riv4HS;

	public TextMeshProUGUI LVL1HS;

	private void Start()
	{
		player = ReInput.players.GetPlayer(playerId);
		cc = GetComponent<CharacterController>();
		if (ActualScene)
		{
			SceneManager.SetActiveScene(SceneManager.GetSceneByName("LevelSelect"));
		}
		if (OptMenu && (CurrentScene == "Title" || CurrentScene == "How2Funk"))
		{
			SceneManager.SetActiveScene(SceneManager.GetSceneByName("Options"));
		}
		if (LevelJumper)
		{
			SceneLoader.LoadScene(SceneName);
		}
		LevelsUnlocked = PlayerPrefs.GetInt("Level");
		if (LevelsUnlocked == 1)
		{
			LVL1scr.SetActive(value: true);
		}
		Difficulty = PlayerPrefs.GetString("difficulty", "Normal");
		if (Difficulty == "Easy")
		{
			diffiValue = 0;
			SetEasy();
		}
		else if (Difficulty == "Normal")
		{
			diffiValue = 1;
			SetNormal();
		}
		Level = PlayerPrefs.GetInt("Level");
		LastLevel = PlayerPrefs.GetInt("LastLevelPlayed");
		if (LastLevel == 0)
		{
			EventSystem.current.SetSelectedGameObject(LVL0);
		}
		else if (LastLevel == 1)
		{
			EventSystem.current.SetSelectedGameObject(Riv1);
		}
		else if (LastLevel == 2)
		{
			EventSystem.current.SetSelectedGameObject(Riv2);
		}
		else if (LastLevel == 3)
		{
			EventSystem.current.SetSelectedGameObject(Riv3);
		}
		else if (LastLevel == 4)
		{
			EventSystem.current.SetSelectedGameObject(LVL1);
		}
		CurrentScene = PlayerPrefs.GetString("LastScene", "Title");
		if (CurrentScene == "JamWell" || CurrentScene == "MelodiiHouse")
		{
			InHub = true;
		}
		else
		{
			InHub = false;
		}
		if (OptMenu && CurrentScene != "Title")
		{
			ClearSaveButton.SetActive(value: false);
			if (CurrentScene != "Title" && CurrentScene != "How2Funk")
			{
				OptLight.SetActive(value: false);
			}
		}
	}

	public void Awake()
	{
		CurrentScene = PlayerPrefs.GetString("LastScene", "Title");
	}

	public void Quit()
	{
		InStory = false;
		SceneManager.LoadSceneAsync("Title");
	}

	public void CloseGame()
	{
		Application.Quit();
	}

	public void Go_Options()
	{
		SceneManager.LoadScene("Options", LoadSceneMode.Additive);
		if (CurrentScene == "Title")
		{
			SceneManager.MoveGameObjectToScene(TitleMusic, SceneManager.GetSceneByName("Options"));
		}
		if (InHub)
		{
			SceneManager.MoveGameObjectToScene(BGMusic, SceneManager.GetSceneByName("Options"));
		}
	}

	public void Bye_Options()
	{
		SceneManager.UnloadSceneAsync("Options");
		SceneManager.SetActiveScene(SceneManager.GetSceneByName("Title"));
		if (CurrentScene == "Title")
		{
			SceneManager.MoveGameObjectToScene(TitleMusic, SceneManager.GetSceneByName("Title"));
			PlayerPrefs.SetString("LastScene", "Title");
		}
		if (InHub)
		{
			SceneManager.MoveGameObjectToScene(BGMusic, SceneManager.GetSceneByName(CurrentScene));
		}
	}

	public void Go_LvLSelect()
	{
		InStory = false;
		SceneManager.LoadScene("LevelSelect", LoadSceneMode.Additive);
	}

	public void Bye_LvLSelect()
	{
		if (PlayerPrefs.GetInt("AfterSong") > 0)
		{
			SceneManager.LoadScene("Title");
			PlayerPrefs.SetInt("AfterSong", 0);
		}
		else
		{
			SceneManager.UnloadSceneAsync("LevelSelect");
			SceneManager.SetActiveScene(SceneManager.GetSceneByName("Title"));
		}
		PlayerPrefs.SetString("LastScene", "Title");
	}

	public void Go_Story()
	{
		if (!DemoComplete)
		{
			InStory = true;
			LastLevelStory = ES3.Load("LastSongStory", defaultValue);
			PlayerPrefs.SetInt("SaveFile", 1);
			if (LastLevelStory == 0)
			{
				SceneLoader.LoadScene("Calibration");
				PlayerPrefs.SetString("LastScene", "MelodiiRoom");
			}
			if (LastLevelStory > 0)
			{
				SceneLoader.LoadScene("JamWell");
				PlayerPrefs.SetString("LastScene", "JamWell");
			}
		}
		else
		{
			StoryWarning.SetActive(value: true);
		}
	}

	public void Clear_Story()
	{
		ES3.Save("Level", 0);
		ES3.Save("LastSongStory", 0);
		ES3.Save("hasMelSticker", 0f);
		ES3.Save("hasCoffSticker", 0f);
		ES3.Save("Keyboard", 0f);
		ES3.Save("hasStickers", 0f);
		ES3.Save("MelSticker", 0f);
		ES3.Save("CoffSticker", 0f);
		DemoCompleted = false;
	}

	public void Go_LvL0()
	{
		SceneLoader.LoadScene("How2Funk");
		PlayerPrefs.SetString("LastScene", "How2Funk");
		GameObject.FindGameObjectWithTag("ExitButton").SetActive(value: false);
		if (ActualScene)
		{
			PlayerPrefs.SetInt("LastLevelPlayed", 0);
		}
	}

	public void Go_RvL1()
	{
		SceneLoader.LoadScene("Rival1");
		PlayerPrefs.SetString("LastScene", "Rival1");
		GameObject.FindGameObjectWithTag("ExitButton").SetActive(value: false);
		if (ActualScene)
		{
			PlayerPrefs.SetInt("LastLevelPlayed", 1);
		}
	}

	public void Go_RvL2()
	{
		SceneLoader.LoadScene("Rival2");
		PlayerPrefs.SetString("LastScene", "Rival2");
		GameObject.FindGameObjectWithTag("ExitButton").SetActive(value: false);
		if (ActualScene)
		{
			PlayerPrefs.SetInt("LastLevelPlayed", 2);
		}
	}

	public void Go_RvL3()
	{
		SceneLoader.LoadScene("Rival3");
		PlayerPrefs.SetString("LastScene", "Rival3");
		GameObject.FindGameObjectWithTag("ExitButton").SetActive(value: false);
		if (ActualScene)
		{
			PlayerPrefs.SetInt("LastLevelPlayed", 3);
		}
	}

	public void Go_RvL4()
	{
		SceneLoader.LoadScene("Rival4");
		PlayerPrefs.SetString("LastScene", "Rival4");
		GameObject.FindGameObjectWithTag("ExitButton").SetActive(value: false);
	}

	public void Go_LvL1()
	{
		SceneLoader.LoadScene("LvL1");
		PlayerPrefs.SetString("LastScene", "LvL1");
		GameObject.FindGameObjectWithTag("ExitButton").SetActive(value: false);
		if (ActualScene)
		{
			PlayerPrefs.SetInt("LastLevelPlayed", 4);
		}
	}

	public void ClearData()
	{
		PlayerPrefs.DeleteAll();
	}

	public void Go_Title()
	{
		InStory = false;
		SceneLoader.LoadScene("Title");
		PlayerPrefs.SetString("LastScene", "Title");
	}

	public void Go_Calibrate()
	{
		if (!OptMenu)
		{
			SceneLoader.LoadScene("Calibration");
			Metronome.OptMenu = false;
		}
		else if (CurrentScene == "Title")
		{
			SceneManager.LoadScene("Calibration", LoadSceneMode.Additive);
			Metronome.OptMenu = true;
			CalibrationExit.SetActive(value: true);
			OptionsMenu.SetActive(value: false);
			DisableBackButtons();
		}
		else
		{
			NoWay.Play();
		}
	}

	public void Enable_Music()
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("Music");
		for (int i = 0; i < array.Length; i++)
		{
			array[i].GetComponent<AudioSource>().mute = false;
		}
	}

	public void DisableBackButtons()
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("ExitButton2");
		for (int i = 0; i < array.Length; i++)
		{
			array[i].GetComponent<CloseB>().enabled = false;
		}
	}

	public void EnableBackButtons()
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("ExitButton2");
		for (int i = 0; i < array.Length; i++)
		{
			array[i].GetComponent<CloseB>().enabled = true;
		}
	}

	public void SetEasy()
	{
		PlayerPrefs.SetString("difficulty", "Easy");
		if (ActualScene)
		{
			DiffiTxt.text = "Easy";
		}
	}

	public void SetNormal()
	{
		PlayerPrefs.SetString("difficulty", "Normal");
		if (ActualScene)
		{
			DiffiTxt.text = "Normal";
		}
	}

	public void RiseDifficulty()
	{
		diffiValue++;
		if (diffiValue <= 0)
		{
			SetEasy();
			diffiValue = 0;
		}
		else if (diffiValue >= 1)
		{
			SetNormal();
			diffiValue = 1;
		}
	}

	public void LowerDifficulty()
	{
		diffiValue--;
		if (diffiValue <= 0)
		{
			SetEasy();
			diffiValue = 0;
		}
		else if (diffiValue >= 1)
		{
			SetNormal();
			diffiValue = 1;
		}
	}

	private void Update()
	{
		if (DemoCompleted)
		{
			DemoComplete = true;
		}
		else
		{
			DemoComplete = false;
		}
		if (!ActualScene)
		{
			return;
		}
		if (player.GetButton("Butt3") && !ChangingDiff)
		{
			DifficultyMenu.SetActive(value: true);
			ChangingDiff = true;
			QGclose.SetActive(value: false);
		}
		if (ChangingDiff)
		{
			if (player.GetButtonUp("Butt3"))
			{
				DifficultyMenu.SetActive(value: false);
				ChangingDiff = false;
				QGclose.SetActive(value: true);
			}
			if (player.GetAxisRaw("Horizontal") > 0f)
			{
				RiseDifficulty();
			}
			if (player.GetAxisRaw("Horizontal") < 0f)
			{
				LowerDifficulty();
			}
		}
		if (Difficulty == "Easy" && DifficIcon.gameObject.activeInHierarchy)
		{
			DifficIcon.SetTrigger("easy");
		}
		if (Difficulty == "Normal" && DifficIcon.gameObject.activeInHierarchy)
		{
			DifficIcon.SetTrigger("normal");
		}
		Difficulty = PlayerPrefs.GetString("difficulty");
		if (Difficulty == "Easy")
		{
			Riv1HS.text = ES3.Load("HighScoreCCIeasy", (float)defaultValue).ToString();
			Riv2HS.text = ES3.Load("HighScoreNWAVeasy", (float)defaultValue).ToString();
			Riv3HS.text = ES3.Load("HighScoreSAMeasy", (float)defaultValue).ToString();
			LVL1HS.text = ES3.Load("HighScoreGPeasy", (float)defaultValue).ToString();
		}
		else if (Difficulty == "Normal")
		{
			Riv1HS.text = ES3.Load("HighScoreCCI", (float)defaultValue).ToString();
			Riv2HS.text = ES3.Load("HighScoreNWAV", (float)defaultValue).ToString();
			Riv3HS.text = ES3.Load("HighScoreSAM", (float)defaultValue).ToString();
			LVL1HS.text = ES3.Load("HighScoreGP", (float)defaultValue).ToString();
		}
	}
}
