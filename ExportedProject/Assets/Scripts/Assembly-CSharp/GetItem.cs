using UnityEngine;

public class GetItem : MonoBehaviour
{
	public bool MelSticker;

	public bool CoffSticker;

	private void Start()
	{
		if (MelSticker)
		{
			StickerManager.Has_MelSticker = true;
		}
		if (CoffSticker)
		{
			StickerManager.Has_CoffSticker = true;
		}
		StickerManager.Has_NoStickers = false;
	}

	private void Update()
	{
	}
}
