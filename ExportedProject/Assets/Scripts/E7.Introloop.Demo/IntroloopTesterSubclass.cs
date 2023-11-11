using E7.Introloop;
using UnityEngine;

public class IntroloopTesterSubclass : MonoBehaviour
{
	public IntroloopAudio maidBattle;

	public void LeftPlay()
	{
		IntroloopPlayer.Instance.Play(maidBattle);
	}

	public void LeftPause()
	{
		IntroloopPlayer.Instance.Pause(0.5f);
	}

	public void LeftResume()
	{
		IntroloopPlayer.Instance.Resume();
	}

	public void LeftStop()
	{
		IntroloopPlayer.Instance.Stop(0.8f);
	}

	public void RightPlay1()
	{
		IntroloopPlayer<DemoSubclassPlayer>.Get.PlayAssault();
	}

	public void RightPlay2()
	{
		IntroloopPlayer<DemoSubclassPlayer>.Get.PlayCompete();
	}

	public void RightPause()
	{
		IntroloopPlayer<DemoSubclassPlayer>.Get.Pause();
	}

	public void RightResume()
	{
		IntroloopPlayer<DemoSubclassPlayer>.Get.Resume();
	}

	public void RightStop()
	{
		IntroloopPlayer<DemoSubclassPlayer>.Get.Stop();
	}
}
