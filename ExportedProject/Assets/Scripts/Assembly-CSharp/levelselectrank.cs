using UnityEngine;
using UnityEngine.UI;

public class levelselectrank : MonoBehaviour
{
	public int Rank;

	public string Level;

	public GameObject S;

	public Sprite A;

	public Sprite B;

	public Sprite C;

	public Sprite D;

	public Sprite None;

	public string Difficulty;

	public GameObject Daiper;

	public int HasFreeEmb;

	public GameObject FreeEmblem;

	public string LvlFree;

	private void Start()
	{
		DaiperCheck();
		HasFreeEmb = ES3.Load(LvlFree, 0);
	}

	public void SwitchRanks()
	{
		if (Level == "CreamCheeseIcing")
		{
			if (Difficulty == "Easy")
			{
				Rank = ES3.Load("Riv1rankeasy", 0);
			}
			else if (Difficulty == "Normal")
			{
				Rank = ES3.Load("Riv1rank", 0);
			}
		}
		if (Level == "NamiWAV")
		{
			if (Difficulty == "Easy")
			{
				Rank = ES3.Load("Riv2rankeasy", 0);
			}
			else if (Difficulty == "Normal")
			{
				Rank = ES3.Load("Riv2rank", 0);
			}
		}
		if (Level == "GreasePoppin")
		{
			if (Difficulty == "Easy")
			{
				Rank = ES3.Load("LvL1rankeasy", 0);
			}
			else if (Difficulty == "Normal")
			{
				Rank = ES3.Load("LvL1rank", 0);
			}
		}
	}

	public void DaiperCheck()
	{
		if (Rank > 0 && Difficulty == "Easy")
		{
			Daiper.SetActive(value: true);
		}
		else
		{
			Daiper.SetActive(value: false);
		}
	}

	private void Update()
	{
		Difficulty = PlayerPrefs.GetString("difficulty");
		if (HasFreeEmb > 0 && Difficulty == "Normal")
		{
			FreeEmblem.SetActive(value: true);
		}
		else
		{
			FreeEmblem.SetActive(value: false);
		}
		if (Rank == 5)
		{
			GetComponent<Image>().sprite = None;
			S.SetActive(value: true);
		}
		if (Rank == 4)
		{
			GetComponent<Image>().sprite = A;
			S.SetActive(value: false);
		}
		else if (Rank == 3)
		{
			GetComponent<Image>().sprite = B;
			S.SetActive(value: false);
		}
		else if (Rank == 2)
		{
			GetComponent<Image>().sprite = C;
			S.SetActive(value: false);
		}
		else if (Rank == 1)
		{
			GetComponent<Image>().sprite = D;
			S.SetActive(value: false);
		}
		else if (Rank == 0)
		{
			GetComponent<Image>().sprite = None;
			S.SetActive(value: false);
		}
		if (Rank > 0 && Difficulty == "Easy")
		{
			Daiper.SetActive(value: true);
		}
		else
		{
			Daiper.SetActive(value: false);
		}
		if (Level == "CreamCheeseIcing")
		{
			if (Difficulty == "Easy")
			{
				Rank = ES3.Load("Riv1rankeasy", 0);
			}
			else if (Difficulty == "Normal")
			{
				Rank = ES3.Load("Riv1rank", 0);
			}
		}
		if (Level == "NamiWAV")
		{
			if (Difficulty == "Easy")
			{
				Rank = ES3.Load("Riv2rankeasy", 0);
			}
			else if (Difficulty == "Normal")
			{
				Rank = ES3.Load("Riv2rank", 0);
			}
		}
		if (Level == "StirAndMix")
		{
			if (Difficulty == "Easy")
			{
				Rank = ES3.Load("Riv3rankeasy", 0);
			}
			else if (Difficulty == "Normal")
			{
				Rank = ES3.Load("Riv3rank", 0);
			}
		}
		if (Level == "GreasePoppin")
		{
			if (Difficulty == "Easy")
			{
				Rank = ES3.Load("LvL1rankeasy", 0);
			}
			else if (Difficulty == "Normal")
			{
				Rank = ES3.Load("LvL1rank", 0);
			}
		}
	}
}
