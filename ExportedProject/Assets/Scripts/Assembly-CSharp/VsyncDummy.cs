using UnityEngine;

public class VsyncDummy : MonoBehaviour
{
	private void Start()
	{
		Application.targetFrameRate = 60;
		QualitySettings.vSyncCount = 1;
	}

	private void Update()
	{
	}
}
