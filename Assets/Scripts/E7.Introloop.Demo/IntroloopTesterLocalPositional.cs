using E7.Introloop;
using UnityEngine;

public class IntroloopTesterLocalPositional : MonoBehaviour
{
	public IntroloopPlayer leftSphere;

	public GameObject rightSphere;

	public IntroloopAudio assault;

	public IntroloopAudio compete;

	public void Awake()
	{
		rightSphere.AddComponent<IntroloopPlayer>();
		rightSphere.GetComponent<AudioSource>().spatialBlend = 1f;
	}

	public void LeftPlay()
	{
		leftSphere.Play(assault);
	}

	public void LeftStop()
	{
		leftSphere.Stop();
	}

	public void RightPlay()
	{
		rightSphere.GetComponent<IntroloopPlayer>().Play(compete);
	}

	public void RightStop()
	{
		rightSphere.GetComponent<IntroloopPlayer>().Stop();
	}
}
