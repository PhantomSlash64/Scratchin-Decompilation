using UnityEngine;

public class QualityCheck : MonoBehaviour
{
	public GameObject HighQualityOnly;

	public GameObject LowQualityOnly;

	public int qualityLevel;

	private void Start()
	{
		qualityLevel = QualitySettings.GetQualityLevel();
	}

	private void Update()
	{
		if (qualityLevel > 2)
		{
			HighQualityOnly.SetActive(value: true);
			LowQualityOnly.SetActive(value: false);
		}
		else
		{
			LowQualityOnly.SetActive(value: true);
			HighQualityOnly.SetActive(value: false);
		}
	}
}
