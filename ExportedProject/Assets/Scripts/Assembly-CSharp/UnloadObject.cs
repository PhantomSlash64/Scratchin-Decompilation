using UnityEngine;

public class UnloadObject : MonoBehaviour
{
	public int item_id;

	public float sticker_mel;

	public float sticker_coff;

	public float defaultValue;

	public int toRemove;

	public GameObject self;

	public int SaveFile;

	private void Start()
	{
		if (item_id == 1)
		{
			if (SaveFile == 1)
			{
				sticker_mel = ES3.Load("hasMelSticker", defaultValue);
			}
			if (sticker_mel > 0f)
			{
				self.SetActive(value: false);
			}
		}
		if (item_id == 2)
		{
			if (SaveFile == 1)
			{
				sticker_coff = ES3.Load("hasCoffSticker", defaultValue);
			}
			if (sticker_coff > 0f)
			{
				self.SetActive(value: false);
			}
		}
	}

	private void Update()
	{
	}
}
