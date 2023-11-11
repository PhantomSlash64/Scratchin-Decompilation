using System;
using System.Collections;
using E7.Introloop;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroloopTester : MonoBehaviour
{
	public IntroloopAudio[] allIntroloopAudio;

	public IntroloopTestSwitches testSwitches;

	private float stopTime;

	public Text songNameText;

	public Text genreText;

	public Button[] playButtons;

	public Button pauseButton;

	public Button resumeButton;

	public Button stopButton;

	public Button rememberAndStopButton;

	public Toggle useFadeToggle;

	public void PlayIntroloop()
	{
		IntroloopPlayer.Instance.Play(allIntroloopAudio[0]);
	}

	public void PlayIndex(int arrayMember)
	{
		IntroloopPlayer.Instance.Play(allIntroloopAudio[arrayMember], testSwitches.useFade ? testSwitches.fadeTime : 0f, stopTime);
		UpdateSongInformation(arrayMember);
	}

	public void Preload(int arrayMember)
	{
		IntroloopPlayer.Instance.Preload(allIntroloopAudio[arrayMember]);
	}

	private void UpdateSongInformation(int arrayMember)
	{
		float clipLength = allIntroloopAudio[arrayMember].ClipLength;
		string text = "";
		string text2 = "";
		switch (arrayMember)
		{
		case 0:
			text = "5argon - Assault";
			text2 = "Psy Techno";
			break;
		case 1:
			text = "5argon - Assault (End)";
			text2 = "Psy Techno";
			break;
		case 2:
			text = "5argon - Compete";
			text2 = "Latin Beats";
			break;
		case 3:
			text = "5argon - Compete (End)";
			text2 = "Latin Beats";
			break;
		case 4:
			text = "5argon - Otter's Celebration (Prepare)";
			text2 = "Funk";
			break;
		case 5:
			text = "5argon - Otter's Celebration";
			text2 = "Funk";
			break;
		case 6:
			text = "5argon - Maid Battle (RPG Arrange)";
			text2 = "Jazz Fusion";
			break;
		case 7:
			text = "5argon - Assault (Pitch 0.4)";
			text2 = "Psy Techno";
			break;
		}
		TimeSpan timeSpan = TimeSpan.FromSeconds(clipLength);
		text = text + " [" + $"{timeSpan.Minutes:D1}:{timeSpan.Seconds:D2}" + "]";
		songNameText.text = text;
		genreText.text = text2;
	}

	public void DSPPause()
	{
		AudioListener.pause = true;
	}

	public void DSPResume()
	{
		AudioListener.pause = false;
	}

	public void Pause()
	{
		if (testSwitches.useFade)
		{
			IntroloopPlayer.Instance.Pause(testSwitches.fadeTime);
		}
		else
		{
			IntroloopPlayer.Instance.Pause();
		}
	}

	public void Resume()
	{
		IntroloopPlayer.Instance.Resume(testSwitches.useFade ? testSwitches.fadeTime : 0f);
	}

	public void Stop(bool rememberStopTime)
	{
		stopTime = (rememberStopTime ? IntroloopPlayer.Instance.GetPlayheadTime() : 0f);
		if (testSwitches.useFade)
		{
			IntroloopPlayer.Instance.Stop(testSwitches.fadeTime);
		}
		else
		{
			IntroloopPlayer.Instance.Stop();
		}
		songNameText.text = "";
		genreText.text = "";
	}

	private IEnumerator Start()
	{
		songNameText.text = "";
		genreText.text = "";
		yield break;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.N))
		{
			DSPPause();
		}
		if (Input.GetKeyDown(KeyCode.M))
		{
			DSPResume();
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			playButtons[0].onClick.Invoke();
		}
		if (Input.GetKeyDown(KeyCode.S))
		{
			playButtons[1].onClick.Invoke();
		}
		if (Input.GetKeyDown(KeyCode.D))
		{
			playButtons[2].onClick.Invoke();
		}
		if (Input.GetKeyDown(KeyCode.F))
		{
			playButtons[3].onClick.Invoke();
		}
		if (Input.GetKeyDown(KeyCode.G))
		{
			playButtons[4].onClick.Invoke();
		}
		if (Input.GetKeyDown(KeyCode.H))
		{
			playButtons[5].onClick.Invoke();
		}
		if (Input.GetKeyDown(KeyCode.J))
		{
			playButtons[6].onClick.Invoke();
		}
		if (Input.GetKeyDown(KeyCode.K))
		{
			playButtons[7].onClick.Invoke();
		}
		if (Input.GetKeyDown(KeyCode.Z))
		{
			pauseButton.onClick.Invoke();
		}
		if (Input.GetKeyDown(KeyCode.X))
		{
			resumeButton.onClick.Invoke();
		}
		if (Input.GetKeyDown(KeyCode.C))
		{
			stopButton.onClick.Invoke();
		}
		if (Input.GetKeyDown(KeyCode.V))
		{
			rememberAndStopButton.onClick.Invoke();
		}
		if (Input.GetKeyDown(KeyCode.Q))
		{
			useFadeToggle.isOn = !useFadeToggle.isOn;
			useFadeToggle.onValueChanged.Invoke(useFadeToggle.isOn);
		}
		if (Input.GetKeyDown(KeyCode.O))
		{
			IntroloopPlayer.Instance.Preload(allIntroloopAudio[0]);
		}
		if (Input.GetKeyDown(KeyCode.P))
		{
			SceneManager.LoadScene("IntroloopDemo");
		}
	}
}
