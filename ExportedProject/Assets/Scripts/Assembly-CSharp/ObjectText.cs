using System;
using System.Collections;
using Rewired;
using TMPro;
using UnityEngine;
using UnityEngine.Playables;

public class ObjectText : MonoBehaviour
{
	public string emotion;

	public string direction;

	public bool HasCommand;

	public bool HasNoIcon;

	public int playerId;

	private Player player;

	private CharacterController cc;

	public string NextScene;

	public float letPause;

	public float letPauseOrigin;

	public float spacePause;

	public float puncPause;

	public float elipPause = 0.1f;

	public string message;

	public string FinalText;

	public TextMeshProUGUI Phrase;

	public GameObject choice;

	public Animator speakerIco;

	public Animator playerObj;

	public bool ready;

	public AudioSource voice;

	public float line = 1f;

	public GameObject close;

	public GameObject textBox;

	public bool lastCharPunctuation;

	public char Letter;

	private char charComma;

	private char charPeriod;

	private char charExclam;

	private char charQmark;

	private char charElipse;

	private char charEmpty;

	public bool CanSkip = true;

	public bool IsCutscene;

	public GameObject Cutscene;

	public bool Person;

	public Animator NPC;

	public static bool amorgos;

	public bool NotStupid = true;

	public bool Choice;

	public bool MusicBox;

	public bool Example;

	public bool Example2;

	public bool HasPrompt;

	public GameObject ButtPrompt;

	public float PromptTime;

	public GameObject Extra;

	public PlayableDirector Timeline;

	private void OnEnable()
	{
		player = ReInput.players.GetPlayer(playerId);
		cc = GetComponent<CharacterController>();
		if (NotStupid)
		{
			amorgos = true;
		}
		charComma = Convert.ToChar(44);
		charPeriod = Convert.ToChar(46);
		charElipse = Convert.ToChar("…");
		charQmark = Convert.ToChar(63);
		charExclam = Convert.ToChar(33);
		charEmpty = Convert.ToChar(" ");
		ready = false;
		close.SetActive(value: false);
		Phrase = GetComponent<TextMeshProUGUI>();
		Phrase.text = "";
		StartCoroutine(TypeText());
		if (Person)
		{
			NPC.ResetTrigger("curious");
			if (!HasNoIcon)
			{
				speakerIco.SetTrigger(emotion);
			}
			if (emotion != "" && emotion != "nervous" && emotion != "normal")
			{
				NPC.SetTrigger(emotion);
			}
			else
			{
				NPC.SetTrigger("34");
			}
			NPC.SetTrigger("speak");
			if (direction != "")
			{
				NPC.SetTrigger(direction);
			}
			else
			{
				NPC.SetTrigger("Right");
			}
		}
		if (HasPrompt)
		{
			StartCoroutine(ShowButton());
		}
	}

	private IEnumerator ShowButton()
	{
		yield return new WaitForSeconds(PromptTime);
		ButtPrompt.SetActive(value: true);
	}

	private IEnumerator TypeText()
	{
		letPause = letPauseOrigin;
		char[] array = message.ToCharArray();
		for (int i = 0; i < array.Length; i++)
		{
			char letter = array[i];
			if (ready)
			{
				continue;
			}
			Letter = letter;
			Phrase.text += letter;
			voice.Play();
			yield return 0;
			yield return new WaitForSeconds(letPause);
			if (Person)
			{
				speakerIco.SetTrigger("speak");
			}
			if (letter == charComma || letter == charPeriod || letter == charExclam || letter == charQmark)
			{
				voice.Pause();
				letPause = puncPause;
				voice.mute = true;
				lastCharPunctuation = true;
				if (Person)
				{
					speakerIco.SetTrigger("Stop");
				}
			}
			else if (letter == charElipse)
			{
				voice.Pause();
				letPause = elipPause;
				voice.mute = true;
				lastCharPunctuation = true;
				if (Person)
				{
					speakerIco.SetTrigger("Stop");
				}
			}
			else if (letter == charEmpty)
			{
				voice.Pause();
				if (Person)
				{
					speakerIco.SetTrigger("Stop");
				}
				letPause = letPauseOrigin;
				voice.mute = false;
			}
			else if (letter != charComma && letter != charPeriod && letter != charExclam && letter != charQmark && letter != charElipse)
			{
				lastCharPunctuation = false;
				letPause = letPauseOrigin;
				voice.mute = false;
				if (Person)
				{
					speakerIco.SetTrigger("speak");
				}
			}
		}
		if (Phrase.text == message)
		{
			ready = true;
			if (Choice)
			{
				choice.SetActive(value: true);
			}
			else if (!Example && !Example2)
			{
				close.SetActive(value: true);
			}
			if (HasCommand)
			{
				Phrase.text = FinalText;
			}
			if (Person)
			{
				NPC.SetTrigger("Stop");
			}
			if (Example)
			{
				Extra.SetActive(value: true);
				NPC.SetTrigger("Stop");
			}
			if (Example2)
			{
				Timeline.Play();
				NPC.SetTrigger("Stop");
			}
		}
	}

	private void Update()
	{
		if (!NotStupid)
		{
			return;
		}
		if (player.GetButtonDown("UISubmit") && close.activeInHierarchy && ready)
		{
			amorgos = false;
			_ = Person;
			if (IsCutscene)
			{
				Cutscene.SetActive(value: true);
			}
			if (!MusicBox)
			{
				amorgos = false;
			}
		}
		else if (player.GetButtonDown("UISubmit") && !ready && CanSkip)
		{
			Phrase.text = message;
			ready = true;
			close.SetActive(value: true);
			_ = MusicBox;
			_ = Person;
			if (IsCutscene)
			{
				Cutscene.SetActive(value: true);
			}
			if (HasPrompt)
			{
				ButtPrompt.SetActive(value: true);
			}
		}
		if (Person && ready)
		{
			NPC.SetTrigger("Stop");
		}
		else if (Person)
		{
			NPC.SetTrigger("speak");
		}
	}
}
