using SonicBloom.Koreo;
using UnityEngine;

public class RhyLine_P : MonoBehaviour
{
	public int blocks;

	public bool lineUp;

	public static int Blocks;

	public static int Blocks2;

	public static int Double = 1;

	public static bool PlayerSpecific;

	public bool Player;

	public GameObject Block1;

	public GameObject Block2;

	public GameObject Block3;

	public GameObject Block4;

	public GameObject Block5;

	public GameObject Block6;

	public GameObject Block7;

	public GameObject Block8;

	[EventID]
	public string LineStart;

	private void Start()
	{
		PlayerSpecific = false;
		Koreographer.Instance.RegisterForEvents(LineStart, On_LineStart);
	}

	private void Update()
	{
		blocks = Blocks;
		if (!lineUp)
		{
			return;
		}
		lineUp = false;
		if (!PlayerSpecific)
		{
			if (Blocks == 8)
			{
				Block1.SetActive(value: true);
				Block2.SetActive(value: true);
				Block3.SetActive(value: true);
				Block4.SetActive(value: true);
				Block5.SetActive(value: true);
				Block6.SetActive(value: true);
				Block7.SetActive(value: true);
				Block8.SetActive(value: true);
			}
			else if (Blocks == 7)
			{
				Block1.SetActive(value: true);
				Block2.SetActive(value: true);
				Block3.SetActive(value: true);
				Block4.SetActive(value: true);
				Block5.SetActive(value: true);
				Block6.SetActive(value: true);
				Block7.SetActive(value: true);
				Block8.SetActive(value: false);
			}
			else if (Blocks == 6)
			{
				Block1.SetActive(value: true);
				Block2.SetActive(value: true);
				Block3.SetActive(value: true);
				Block4.SetActive(value: true);
				Block5.SetActive(value: true);
				Block6.SetActive(value: true);
				Block7.SetActive(value: false);
				Block8.SetActive(value: false);
			}
			else if (Blocks == 5)
			{
				Block1.SetActive(value: true);
				Block2.SetActive(value: true);
				Block3.SetActive(value: true);
				Block4.SetActive(value: true);
				Block5.SetActive(value: true);
				Block6.SetActive(value: false);
				Block7.SetActive(value: false);
				Block8.SetActive(value: false);
			}
			else if (Blocks == 4)
			{
				Block1.SetActive(value: true);
				Block2.SetActive(value: true);
				Block3.SetActive(value: true);
				Block4.SetActive(value: true);
				Block5.SetActive(value: false);
				Block6.SetActive(value: false);
				Block7.SetActive(value: false);
				Block8.SetActive(value: false);
			}
			else if (Blocks == 3)
			{
				Block1.SetActive(value: true);
				Block2.SetActive(value: true);
				Block3.SetActive(value: true);
				Block4.SetActive(value: false);
				Block5.SetActive(value: false);
				Block6.SetActive(value: false);
				Block7.SetActive(value: false);
				Block8.SetActive(value: false);
			}
			else if (Blocks == 2)
			{
				Block1.SetActive(value: true);
				Block2.SetActive(value: true);
				Block3.SetActive(value: false);
				Block4.SetActive(value: false);
				Block5.SetActive(value: false);
				Block6.SetActive(value: false);
				Block7.SetActive(value: false);
				Block8.SetActive(value: false);
			}
			else if (Blocks == -1)
			{
				Block1.SetActive(value: false);
				Block2.SetActive(value: true);
				Block3.SetActive(value: true);
				Block4.SetActive(value: true);
				Block5.SetActive(value: true);
				Block6.SetActive(value: true);
				Block7.SetActive(value: true);
				Block8.SetActive(value: true);
			}
			else if (Blocks == -2)
			{
				Block1.SetActive(value: false);
				Block2.SetActive(value: false);
				Block3.SetActive(value: true);
				Block4.SetActive(value: true);
				Block5.SetActive(value: true);
				Block6.SetActive(value: true);
				Block7.SetActive(value: true);
				Block8.SetActive(value: true);
			}
			else if (Blocks == -3)
			{
				Block1.SetActive(value: false);
				Block2.SetActive(value: false);
				Block3.SetActive(value: false);
				Block4.SetActive(value: true);
				Block5.SetActive(value: true);
				Block6.SetActive(value: true);
				Block7.SetActive(value: true);
				Block8.SetActive(value: true);
			}
		}
		else if (Player)
		{
			if (Blocks2 == 8)
			{
				Block1.SetActive(value: true);
				Block2.SetActive(value: true);
				Block3.SetActive(value: true);
				Block4.SetActive(value: true);
				Block5.SetActive(value: true);
				Block6.SetActive(value: true);
				Block7.SetActive(value: true);
				Block8.SetActive(value: true);
			}
			else if (Blocks2 == 7)
			{
				Block1.SetActive(value: true);
				Block2.SetActive(value: true);
				Block3.SetActive(value: true);
				Block4.SetActive(value: true);
				Block5.SetActive(value: true);
				Block6.SetActive(value: true);
				Block7.SetActive(value: true);
				Block8.SetActive(value: false);
			}
			else if (Blocks2 == 6)
			{
				Block1.SetActive(value: true);
				Block2.SetActive(value: true);
				Block3.SetActive(value: true);
				Block4.SetActive(value: true);
				Block5.SetActive(value: true);
				Block6.SetActive(value: true);
				Block7.SetActive(value: false);
				Block8.SetActive(value: false);
			}
			else if (Blocks2 == 5)
			{
				Block1.SetActive(value: true);
				Block2.SetActive(value: true);
				Block3.SetActive(value: true);
				Block4.SetActive(value: true);
				Block5.SetActive(value: true);
				Block6.SetActive(value: false);
				Block7.SetActive(value: false);
				Block8.SetActive(value: false);
			}
			else if (Blocks2 == 4)
			{
				Block1.SetActive(value: true);
				Block2.SetActive(value: true);
				Block3.SetActive(value: true);
				Block4.SetActive(value: true);
				Block5.SetActive(value: false);
				Block6.SetActive(value: false);
				Block7.SetActive(value: false);
				Block8.SetActive(value: false);
			}
			else if (Blocks2 == 3)
			{
				Block1.SetActive(value: true);
				Block2.SetActive(value: true);
				Block3.SetActive(value: true);
				Block4.SetActive(value: false);
				Block5.SetActive(value: false);
				Block6.SetActive(value: false);
				Block7.SetActive(value: false);
				Block8.SetActive(value: false);
			}
			else if (Blocks2 == 2)
			{
				Block1.SetActive(value: true);
				Block2.SetActive(value: true);
				Block3.SetActive(value: false);
				Block4.SetActive(value: false);
				Block5.SetActive(value: false);
				Block6.SetActive(value: false);
				Block7.SetActive(value: false);
				Block8.SetActive(value: false);
			}
			else if (Blocks2 == -1)
			{
				Block1.SetActive(value: false);
				Block2.SetActive(value: true);
				Block3.SetActive(value: true);
				Block4.SetActive(value: true);
				Block5.SetActive(value: true);
				Block6.SetActive(value: true);
				Block7.SetActive(value: true);
				Block8.SetActive(value: true);
			}
			else if (Blocks2 == -2)
			{
				Block1.SetActive(value: false);
				Block2.SetActive(value: false);
				Block3.SetActive(value: true);
				Block4.SetActive(value: true);
				Block5.SetActive(value: true);
				Block6.SetActive(value: true);
				Block7.SetActive(value: true);
				Block8.SetActive(value: true);
			}
			else if (Blocks2 == -3)
			{
				Block1.SetActive(value: false);
				Block2.SetActive(value: false);
				Block3.SetActive(value: false);
				Block4.SetActive(value: true);
				Block5.SetActive(value: true);
				Block6.SetActive(value: true);
				Block7.SetActive(value: true);
				Block8.SetActive(value: true);
			}
		}
	}

	private void On_LineStart(KoreographyEvent evt)
	{
		lineUp = true;
	}
}
