using UnityEngine;
using UnityEngine.UI;

public class PrefsHandler : MonoBehaviour
{
	public bool TitleScreen;

	public int CTRlayout;

	public Toggle KB_Toggle;

	public Toggle XB_Toggle;

	public Toggle PS_Toggle;

	public Toggle NS_Toggle;

	public Toggle GEN_Toggle;

	public GameObject KBToggle;

	public GameObject XBToggle;

	public GameObject PSToggle;

	public GameObject NSToggle;

	public GameObject GENToggle;

	private GameObject lastSelected;

	private void Start()
	{
		CTRlayout = PlayerPrefs.GetInt("CTRlayout", 5);
		if (CTRlayout == 1)
		{
			XB_Toggle.isOn = true;
		}
		else if (CTRlayout == 2)
		{
			PS_Toggle.isOn = true;
		}
		else if (CTRlayout == 3)
		{
			NS_Toggle.isOn = true;
		}
		else if (CTRlayout == 4)
		{
			KB_Toggle.isOn = true;
		}
		else if (CTRlayout == 5)
		{
			GEN_Toggle.isOn = true;
		}
		if (TitleScreen)
		{
			PlayerPrefs.SetString("LastScene", "Title");
		}
	}

	public void XB()
	{
		PlayerPrefs.SetInt("CTRlayout", 1);
	}

	public void PS()
	{
		PlayerPrefs.SetInt("CTRlayout", 2);
	}

	public void NS()
	{
		PlayerPrefs.SetInt("CTRlayout", 3);
	}

	public void KB()
	{
		PlayerPrefs.SetInt("CTRlayout", 4);
	}

	public void GEN()
	{
		PlayerPrefs.SetInt("CTRlayout", 5);
	}

	public void NotInStory()
	{
		PlayerPrefs.SetInt("Story", 0);
	}

	public void InStory()
	{
		PlayerPrefs.SetInt("Story", 1);
	}

	public void ClearData()
	{
		ES3.DeleteFile("SaveFile.es3");
	}

	public void OpenOptions()
	{
		CTRlayout = PlayerPrefs.GetInt("CTRlayout", 5);
	}

	private void Update()
	{
	}
}
