using UnityEngine;

public class StickerManager : MonoBehaviour
{
	public AudioSource Slap;

	public AudioSource No;

	public static bool Has_MelSticker;

	public static bool MelStickerEquipped;

	public GameObject MelodiiSticker;

	public GameObject MelodiiStickerCheck;

	public float MelSticker;

	public float sticker_mel;

	public static bool Has_CoffSticker;

	public static bool CoffStickerEquipped;

	public GameObject CoffeeSticker;

	public GameObject CoffeeStickerCheck;

	public float CoffSticker;

	public float sticker_coff;

	public static bool Has_NoStickers = true;

	public GameObject NoStickers;

	public GameObject EquipButton;

	public GameObject CloseButton;

	public GameObject Stickerbook;

	public float defaultValue;

	public float sticker_none;

	private void Start()
	{
		sticker_mel = ES3.Load("hasMelSticker", defaultValue);
		sticker_coff = ES3.Load("hasCoffSticker", defaultValue);
		sticker_none = ES3.Load("hasStickers", defaultValue);
	}

	private void OnEnable()
	{
		sticker_none = ES3.Load("hasStickers", defaultValue);
		sticker_mel = ES3.Load("hasMelSticker", defaultValue);
		MelSticker = ES3.Load("MelSticker", defaultValue);
		sticker_coff = ES3.Load("hasCoffSticker", defaultValue);
		CoffSticker = ES3.Load("CoffSticker", defaultValue);
	}

	public void EquipSticker_Mel()
	{
		if (!MelStickerEquipped)
		{
			MelStickerEquipped = true;
			Slap.Play();
			ES3.Save("MelSticker", 1f);
		}
	}

	public void RemoveSticker_Mel()
	{
		if (MelStickerEquipped)
		{
			MelStickerEquipped = false;
			No.Play();
			ES3.Save("MelSticker", 0f);
		}
	}

	public void EquipSticker_Coff()
	{
		if (!CoffStickerEquipped)
		{
			CoffStickerEquipped = true;
			Slap.Play();
			ES3.Save("CoffSticker", 1f);
		}
	}

	public void RemoveSticker_Coff()
	{
		if (CoffStickerEquipped)
		{
			CoffStickerEquipped = false;
			No.Play();
			ES3.Save("CoffSticker", 0f);
		}
	}

	public void CheckStickers()
	{
		sticker_none = ES3.Load("hasStickers", defaultValue);
		sticker_mel = ES3.Load("hasMelSticker", defaultValue);
		MelSticker = ES3.Load("MelSticker", defaultValue);
		sticker_coff = ES3.Load("hasCoffSticker", defaultValue);
		MelSticker = ES3.Load("CoffSticker", defaultValue);
	}

	private void Update()
	{
		if (Has_NoStickers)
		{
			NoStickers.SetActive(value: true);
			EquipButton.SetActive(value: false);
		}
		else
		{
			NoStickers.SetActive(value: false);
			CloseButton.SetActive(value: true);
			EquipButton.SetActive(value: true);
		}
		if (sticker_mel > 0f)
		{
			MelodiiSticker.SetActive(value: true);
		}
		if (sticker_mel > 0f)
		{
			Has_MelSticker = true;
			Has_NoStickers = false;
		}
		if (sticker_coff > 0f)
		{
			CoffeeSticker.SetActive(value: true);
			Has_NoStickers = false;
		}
		if (sticker_none > 0f)
		{
			Has_NoStickers = false;
		}
		if (MelSticker > 0f)
		{
			MelodiiStickerCheck.SetActive(value: true);
			MelStickerEquipped = true;
		}
	}
}
