using System;
using E7.Introloop;
using UnityEngine;

public class DemoSubclassPlayer : IntroloopPlayer<DemoSubclassPlayer>
{
	public IntroloopAudio assault;

	[Range(0f, 2f)]
	public float assaultFade;

	[Space]
	public IntroloopAudio compete;

	[Range(0f, 2f)]
	public float competeFade;

	public void PlayAssault()
	{
		try
		{
			Play(assault, assaultFade);
		}
		catch (ArgumentNullException)
		{
			Debug.LogError("To run this demo, please put DemoSubclassPlayer.prefab from the Samples in your Resources/Introloop so the custom singleton spawns with asset references connected for use. It is not a good practice for plugins to mess with your Resources folder on import/on installing samples, so I have to ask you to do it :)");
		}
	}

	public void PlayCompete()
	{
		try
		{
			Play(compete, assaultFade);
		}
		catch (ArgumentNullException)
		{
			Debug.LogError("To run this demo, please put DemoSubclassPlayer.prefab from the Samples in your Resources/Introloop so the custom singleton spawns with asset references connected for use. It is not a good practice for plugins to mess with your Resources folder on import/on installing samples, so I have to ask you to do it :)");
		}
	}

	public void LateAssign(IntroloopAudio assault, IntroloopAudio compete)
	{
		this.assault = assault;
		this.compete = compete;
	}
}
