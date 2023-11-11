using System.Text;
using E7.Introloop;
using UnityEngine;
using UnityEngine.UI;

public class IntroloopReporter : MonoBehaviour
{
	public Text text1;

	public Text text2;

	private StringBuilder sb;

	private string[] debug1;

	private string[] debug2;

	private void Start()
	{
		sb = new StringBuilder();
	}

	private void Update()
	{
		debug1 = IntroloopPlayer.Instance.GetDebugStringsTrack1();
		debug2 = IntroloopPlayer.Instance.GetDebugStringsTrack2();
		sb.Length = 0;
		sb.Append("DSP TIME : " + AudioSettings.dspTime + "\n");
		sb.Append("<color=\"yellow\">= Track 1 =\n</color>");
		string[] array = debug1;
		foreach (string value in array)
		{
			sb.Append(value);
			sb.Append("\n");
		}
		text1.text = sb.ToString();
		sb.Length = 0;
		sb.Append("\n");
		sb.Append("<color=\"yellow\">= Track 2 =\n</color>");
		array = debug2;
		foreach (string value2 in array)
		{
			sb.Append(value2);
			sb.Append("\n");
		}
		text2.text = sb.ToString();
	}
}
