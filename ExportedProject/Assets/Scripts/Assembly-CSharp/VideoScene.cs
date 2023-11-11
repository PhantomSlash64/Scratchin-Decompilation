using System.Collections;
using UnityEngine;

public class VideoScene : MonoBehaviour
{
	public float VidLength;

	private void Start()
	{
		StartCoroutine(Movie());
	}

	public IEnumerator Movie()
	{
		yield return new WaitForSeconds(VidLength);
		Application.LoadLevel("Title");
	}
}
