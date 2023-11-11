using Rewired;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioSettingsMenu : MonoBehaviour
{
	public AudioMixer masterMixer;

	public Slider mainVolumeSlider;

	public Slider fxVolumeSlider;

	public Slider musicVolumeSLider;

	public Slider RumbleSlider;

	private bool isMuted;

	public int playerId;

	private Player player;

	private CharacterController cc;

	public float VibLvl;

	private void Start()
	{
		player = ReInput.players.GetPlayer(playerId);
		cc = GetComponent<CharacterController>();
		LoadMenuVariables();
	}

	public void ToggleMute(bool toggleValue)
	{
		isMuted = toggleValue;
		if (isMuted)
		{
			masterMixer.SetFloat("mainVolume", -80f);
		}
		else
		{
			masterMixer.SetFloat("mainVolume", Mathf.Log(mainVolumeSlider.value) * 20f);
		}
	}

	public void SetMainVolume(float sliderValue)
	{
		masterMixer.SetFloat("mainVolume", Mathf.Log(sliderValue) * 20f);
	}

	public void SetFxVolume(float sliderValue)
	{
		masterMixer.SetFloat("fxVolume", Mathf.Log(sliderValue) * 20f);
	}

	public void SetMusicVolume(float sliderValue)
	{
		masterMixer.SetFloat("musicVolume", Mathf.Log(sliderValue) * 20f);
	}

	public void SaveMenuVariables()
	{
		PlayerPrefs.SetInt("audioPrefsSaved", 0);
		PlayerPrefs.SetFloat("mainVolumeF", mainVolumeSlider.value);
	}

	public void LoadMenuVariables()
	{
		if (PlayerPrefs.HasKey("audioPrefsSaved"))
		{
			mainVolumeSlider.value = PlayerPrefs.GetFloat("mainVolumeF");
		}
		RumbleSlider.value = PlayerPrefs.GetFloat("RumbleLevel", 1f);
		VibLvl = PlayerPrefs.GetFloat("RumbleLevel", 1f);
	}

	public void SetRumbleIntensity()
	{
		VibLvl = RumbleSlider.value;
		player.SetVibration(0, 1.5f * VibLvl, 0.15f);
		PlayerPrefs.SetFloat("RumbleLevel", RumbleSlider.value);
	}

	public void ApplyControllerSettings()
	{
		PlayerPrefs.SetFloat("RumbleLevel", VibLvl);
	}

	public void ResetToDefault()
	{
		PlayerPrefs.SetFloat("RumbleLevel", 1f);
		RumbleSlider.value = PlayerPrefs.GetFloat("RumbleLevel", 1f);
		VibLvl = RumbleSlider.value;
	}
}
