using UnityEngine;

public class RivalDeloader : MonoBehaviour
{
	public bool Debug;

	public bool DisableRivals;

	public GameObject Riv1;

	public GameObject Riv1end;

	public GameObject Riv1NewStuff;

	public Transform Riv1SpawnLocale;

	public GameObject GrapeguyNotif;

	public GameObject Riv2;

	public GameObject Riv2end;

	public GameObject Riv2NewStuff;

	public Transform Riv2SpawnLocale;

	public GameObject Riv3;

	public GameObject Riv3end;

	public GameObject Riv3NewStuff;

	public Transform Riv3SpawnLocale;

	public GameObject player_obj;

	public float lastsong;

	public Transform StartLocale;

	private void Start()
	{
		lastsong = ES3.Load("LastSongStory", 0);
		if (!Debug)
		{
			if (lastsong == 0f)
			{
				player_obj.transform.position = StartLocale.position;
			}
			if (lastsong > 0f)
			{
				Riv1.SetActive(value: false);
				Riv1NewStuff.SetActive(value: true);
			}
			if (lastsong > 1f)
			{
				Riv2.SetActive(value: false);
				Riv2NewStuff.SetActive(value: true);
				GrapeguyNotif.SetActive(value: false);
			}
			if (lastsong == 1f)
			{
				Riv1end.SetActive(value: true);
				StartLocale = Riv1SpawnLocale;
				player_obj.transform.position = Riv1SpawnLocale.position;
			}
			if (lastsong == 2f)
			{
				Riv2.SetActive(value: false);
				Riv2end.SetActive(value: true);
				StartLocale = Riv2SpawnLocale;
				player_obj.transform.position = Riv2SpawnLocale.position;
			}
			if (lastsong == 3f)
			{
				Riv3.SetActive(value: false);
				Riv3end.SetActive(value: true);
				StartLocale = Riv3SpawnLocale;
				player_obj.transform.position = Riv3SpawnLocale.position;
			}
		}
		if (DisableRivals)
		{
			Riv1.SetActive(value: false);
			Riv2.SetActive(value: false);
			Riv3.SetActive(value: false);
		}
	}

	private void Update()
	{
	}
}
