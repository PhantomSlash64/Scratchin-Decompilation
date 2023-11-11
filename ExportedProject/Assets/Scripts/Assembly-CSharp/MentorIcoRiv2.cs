using System.Collections;
using KetosGames.SceneTransition;
using SonicBloom.Koreo;
using SonicBloom.Koreo.Players;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MentorIcoRiv2 : MonoBehaviour
{
	public bool SongLoaded;

	public string Difficulty = "Normal";

	public static string Difficulty2;

	public SimpleMusicPlayer MusicPlayer;

	public Koreography Easy;

	public Koreography Normal;

	public Koreography Hard;

	public bool InStory;

	public int story;

	public int SaveFile;

	public bool FirstTime;

	public Animator RhyBox;

	public Animator RhyCircle;

	public bool BlueLine = true;

	public bool PinkLine;

	public bool DoubleLineNext;

	public Animator Rep;

	public Animator Sup;

	public Animator Double;

	public Animator NextLine;

	public Animator NextLine2;

	public Animator NextLineWhole;

	public AudioSource ColorSwap;

	public AudioClip colorswap;

	public GameObject playerico;

	public ParticleSystem Trail;

	public int ExtraCount;

	public int IntroCount;

	public GameObject WaveSky;

	public GameObject NamiCursor;

	public GameObject NamiCursor2;

	public bool dontSpeak;

	public GameObject Line2P;

	public GameObject Line5P;

	public GameObject Line12P;

	public GameObject note_A;

	public GameObject note_ZL;

	public GameObject note_ZR;

	public GameObject note_B;

	public GameObject note_Y;

	public GameObject note_X;

	public GameObject note_up;

	public GameObject note_down;

	public GameObject note_left;

	public GameObject note_right;

	public GameObject Rhybox;

	public GameObject Scene1;

	public GameObject Scene2;

	public GameObject Scene3;

	public GameObject Scene4;

	public GameObject Scene5;

	public GameObject Scene5Mel;

	public GameObject Scene6;

	public GameObject SceneSKG;

	public GameObject Scene7;

	public GameObject Scene8;

	public GameObject EndScene;

	public GameObject MelWindow;

	public GameObject OtherWindow;

	public GameObject DolphinJump;

	public TextMeshProUGUI caption;

	public Animator PlayerL1;

	public Animator MentorL1;

	public Animator MentorL1b;

	public Animator MentorL2;

	public Animator MentorL3;

	public Animator MentorL4;

	public Animator MentorL5;

	public Animator MentorL6;

	public Animator MentorL7;

	public Animator MentorL8;

	public Animator Scene1Cam;

	public Animator camera;

	public bool done;

	public float Speed;

	public AudioSource Song;

	private bool active;

	public Animator lowflipper;

	public Animator highflipper;

	public Animator self;

	public float Butt2Presses;

	public float Butt1Presses;

	public float Butt3Presses;

	public float Butt4Presses;

	public float LeftPresses;

	public float RightPresses;

	public float DownPresses;

	public float UpPresses;

	public float ZLPresses;

	public float ZRPresses;

	public float Line;

	public AudioClip p1;

	public AudioClip p2;

	public AudioClip p3;

	public AudioClip p4;

	public AudioClip p5;

	public AudioClip p6;

	public AudioClip p7;

	public AudioClip p8;

	public AudioClip p9;

	public AudioClip p10;

	public AudioClip p11;

	public AudioClip p12;

	public AudioClip p13;

	public AudioClip p14;

	public AudioClip p15;

	public AudioClip p16;

	public AudioClip p17;

	public AudioClip p18;

	public AudioClip p19;

	public AudioClip p20;

	public AudioClip p21;

	public AudioClip p22;

	public AudioClip p23;

	public AudioClip p24;

	public AudioClip p25;

	public AudioClip p26;

	public AudioClip p27;

	public AudioClip p28;

	public AudioClip p29;

	public AudioClip p30;

	public AudioClip p31;

	public AudioClip p32;

	public AudioClip p33;

	public AudioClip p34;

	public AudioClip p35;

	public AudioClip p36;

	public AudioClip p37;

	public AudioClip p38;

	public AudioClip p39;

	public AudioClip p40;

	public AudioClip p41;

	public AudioClip p42;

	public AudioClip p43;

	public AudioClip p44;

	public AudioClip p45;

	public AudioClip p46;

	public AudioClip p47;

	public AudioClip p48;

	public AudioClip p49;

	public AudioClip p50;

	public AudioClip p51;

	public AudioClip p52;

	public AudioClip p53;

	public AudioClip p54;

	public AudioClip p55;

	public AudioClip p56;

	public AudioClip p57;

	public AudioClip p58;

	public AudioClip p59;

	public AudioClip p60;

	public AudioClip p61;

	public AudioClip p62;

	public AudioClip p63;

	public AudioClip p64;

	public AudioClip p65;

	public AudioClip p66;

	public AudioClip p67;

	public AudioClip p68;

	public AudioClip p69;

	public AudioClip p70;

	public AudioClip p71;

	public AudioClip p72;

	public AudioClip p73;

	public AudioClip p74;

	public AudioClip p75;

	public AudioClip p76;

	public AudioClip p77;

	public AudioClip p78;

	public AudioClip p79;

	public AudioClip p80;

	public AudioClip p81;

	public AudioClip p82;

	public AudioClip p83;

	public AudioClip p84;

	public AudioClip p85;

	public AudioClip p86;

	public AudioClip none;

	public AudioSource voice;

	public AudioSource Up;

	public AudioSource Up2;

	public AudioSource Up3;

	public AudioSource Up4;

	public AudioSource Down;

	public AudioSource Down2;

	public AudioSource Down3;

	public AudioSource Down4;

	public AudioSource Left;

	public AudioSource Left2;

	public AudioSource Left3;

	public AudioSource Left4;

	public AudioSource Right;

	public AudioSource Right2;

	public AudioSource Right3;

	public AudioSource Right4;

	public AudioSource A;

	public AudioSource A2;

	public AudioSource A3;

	public AudioSource A4;

	public AudioSource B;

	public AudioSource B2;

	public AudioSource B3;

	public AudioSource B4;

	public AudioSource X;

	public AudioSource X2;

	public AudioSource X3;

	public AudioSource X4;

	public AudioSource Y;

	public AudioSource Y2;

	public AudioSource Y3;

	public AudioSource Y4;

	public AudioSource L;

	public AudioSource L2;

	public AudioSource L3;

	public AudioSource L4;

	public AudioSource R;

	public AudioSource R2;

	public AudioSource R3;

	public AudioSource R4;

	[EventID]
	public string A_note;

	[EventID]
	public string B_note;

	[EventID]
	public string X_note;

	[EventID]
	public string Y_note;

	[EventID]
	public string L_note;

	[EventID]
	public string R_note;

	[EventID]
	public string Up_note;

	[EventID]
	public string Down_note;

	[EventID]
	public string Left_note;

	[EventID]
	public string Right_note;

	[EventID]
	public string LineStart;

	[EventID]
	public string LineEnd;

	[EventID]
	public string LineNext;

	[EventID]
	public string PlayerLineEnd;

	[EventID]
	public string Intro;

	[EventID]
	public string EndSong;

	[EventID]
	public string Extra;

	[EventID]
	public string PinkWarning;

	public Slider ResultsSlider;

	public GameObject Funkcount;

	public GameObject Stylecount;

	public GameObject ACPcount;

	public GameObject Rewards;

	public bool ResultsTime;

	public GameObject Results;

	public AudioSource tick;

	public int StyleAdded;

	public int FunkAdded;

	public int ACPAdded;

	public bool Funkdone;

	public bool Styledone;

	public bool ACPdone;

	public Canvas UIjunk;

	public GameObject UIjunk1;

	public GameObject HiFiBonus;

	public GameObject WoahFiBonus;

	public GameObject RhyCam;

	public bool BonusAdded;

	public Animator MelodiiRes;

	public GameObject Srank;

	public GameObject Arank;

	public GameObject Brank;

	public GameObject Crank;

	public GameObject Drank;

	public bool NewRecord;

	public GameObject NewRecordSplash;

	public float highScore;

	public float defaultValue;

	private float firstTime;

	public GameObject ResultsTheme;

	public GameObject CloseReg;

	public GameObject CloseStory;

	private void Start()
	{
		Difficulty = PlayerPrefs.GetString("difficulty", "Normal");
		Difficulty2 = Difficulty;
		if (LevelSelect.InStory)
		{
			InStory = true;
		}
		else
		{
			PlayerPrefs.SetInt("LastLevelPlayed", 2);
		}
		firstTime = ES3.Load("FirstTimeNMW", defaultValue);
		if (firstTime == 0f)
		{
			FirstTime = true;
		}
		RhyBox.SetTrigger("boxout");
		Koreographer.Instance.RegisterForEvents(LineStart, On_LineStart);
		Koreographer.Instance.RegisterForEvents(LineNext, On_NextLine);
		Koreographer.Instance.RegisterForEvents(LineEnd, On_LineEnd);
		Koreographer.Instance.RegisterForEvents(PlayerLineEnd, On_PLineEnd);
		Koreographer.Instance.RegisterForEvents(A_note, On_Abutt);
		Koreographer.Instance.RegisterForEvents(B_note, On_Bbutt);
		Koreographer.Instance.RegisterForEvents(X_note, On_Xbutt);
		Koreographer.Instance.RegisterForEvents(Y_note, On_Ybutt);
		Koreographer.Instance.RegisterForEvents(L_note, On_Lbutt);
		Koreographer.Instance.RegisterForEvents(R_note, On_Rbutt);
		Koreographer.Instance.RegisterForEvents(Up_note, On_Up);
		Koreographer.Instance.RegisterForEvents(Down_note, On_Down);
		Koreographer.Instance.RegisterForEvents(Left_note, On_Left);
		Koreographer.Instance.RegisterForEvents(Right_note, On_Right);
		Koreographer.Instance.RegisterForEvents(Intro, On_Intro);
		Koreographer.Instance.RegisterForEvents(EndSong, On_EndSong);
		Koreographer.Instance.RegisterForEvents(Extra, On_Extra);
		Koreographer.Instance.RegisterForEvents(PinkWarning, On_PinkWarning);
	}

	private void On_Extra(KoreographyEvent evt)
	{
		ExtraCount++;
		if (ExtraCount == 1)
		{
			NamiCursor.SetActive(value: true);
		}
		if (ExtraCount == 2)
		{
			NamiCursor2.SetActive(value: true);
		}
		if (ExtraCount == 3)
		{
			Scene6.SetActive(value: false);
			SceneSKG.SetActive(value: true);
		}
		if (ExtraCount == 4)
		{
			Scene6.SetActive(value: false);
			SceneSKG.SetActive(value: true);
			Cursor.visible = true;
		}
		if (ExtraCount == 5)
		{
			Scene1.SetActive(value: false);
			Scene8.SetActive(value: true);
		}
		if (ExtraCount == 6)
		{
			MentorL8.SetTrigger("Extra");
		}
		if (ExtraCount == 7)
		{
			PlayerIcoRiv2.LineReady = true;
			MelWindow.SetActive(value: true);
		}
		if (ExtraCount == 8)
		{
			DolphinJump.SetActive(value: true);
		}
		if (ExtraCount == 9)
		{
			Scene3.SetActive(value: false);
			EndScene.SetActive(value: true);
			WaveSky.SetActive(value: false);
			RhyBox.SetTrigger("boxout");
		}
	}

	private void Bonus()
	{
		if (PlayerIcoRiv2.HiFi && !BonusAdded)
		{
			BonusAdded = true;
			HiFiBonus.SetActive(value: true);
			ResultsSlider.value += 25f;
		}
		else if (PlayerIcoRiv2.WoahFi && !BonusAdded)
		{
			BonusAdded = true;
			WoahFiBonus.SetActive(value: true);
			ResultsSlider.value += 400f;
		}
	}

	private void On_Intro(KoreographyEvent evt)
	{
		if (IntroCount == 0)
		{
			MentorL1.SetTrigger("Start");
			PlayerL1.SetTrigger("Start");
			IntroCount++;
		}
		else
		{
			WaveSky.SetActive(value: true);
			RhyBox.SetTrigger("boxin");
		}
	}

	private void On_Up(KoreographyEvent evt)
	{
		if (!SumScoreManager.UpNeeded)
		{
			SumScoreManager.ButtsNeeded++;
		}
		SumScoreManager.UpNeeded = true;
		SumScoreManager.NoteAmount++;
		Object.Instantiate(note_up, base.transform.position, base.transform.rotation).tag = "NoteClone";
		if (MentorL1.gameObject.activeInHierarchy)
		{
			MentorL1.SetTrigger("Up");
		}
		if (MentorL1b.gameObject.activeInHierarchy)
		{
			MentorL1b.SetTrigger("Up");
		}
		if (MentorL2.gameObject.activeInHierarchy)
		{
			MentorL2.SetTrigger("Up");
		}
		if (UpPresses == 0f)
		{
			Up.Play();
			UpPresses += 1f;
			if (Line == 4f)
			{
				Scene3.SetActive(value: false);
				Scene1.SetActive(value: true);
			}
		}
		else if (UpPresses == 1f)
		{
			Up2.Play();
			UpPresses += 1f;
		}
		else if (UpPresses == 2f)
		{
			Up3.Play();
			UpPresses += 1f;
		}
		else if (UpPresses >= 3f)
		{
			Up4.Play();
			UpPresses += 1f;
		}
	}

	private void On_Down(KoreographyEvent evt)
	{
		if (!SumScoreManager.DownNeeded)
		{
			SumScoreManager.ButtsNeeded++;
		}
		SumScoreManager.DownNeeded = true;
		SumScoreManager.NoteAmount++;
		Object.Instantiate(note_down, base.transform.position, base.transform.rotation).tag = "NoteClone";
		if (MentorL1.gameObject.activeInHierarchy)
		{
			MentorL1.SetTrigger("Down");
		}
		if (MentorL1b.gameObject.activeInHierarchy)
		{
			MentorL1b.SetTrigger("Down");
		}
		if (MentorL2.gameObject.activeInHierarchy)
		{
			MentorL2.SetTrigger("Down");
		}
		if (DownPresses == 0f)
		{
			Down.Play();
			DownPresses += 1f;
		}
		else if (DownPresses == 1f)
		{
			Down2.Play();
			DownPresses += 1f;
		}
		else if (DownPresses == 2f)
		{
			Down3.Play();
			DownPresses += 1f;
		}
		else if (DownPresses >= 3f)
		{
			Down4.Play();
			DownPresses += 1f;
		}
	}

	private void On_Left(KoreographyEvent evt)
	{
		if (!SumScoreManager.LeftNeeded)
		{
			SumScoreManager.ButtsNeeded++;
		}
		SumScoreManager.LeftNeeded = true;
		SumScoreManager.NoteAmount++;
		Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone";
		if (MentorL1.gameObject.activeInHierarchy)
		{
			MentorL1.SetTrigger("Left");
		}
		if (MentorL1b.gameObject.activeInHierarchy)
		{
			MentorL1b.SetTrigger("Left");
		}
		if (MentorL2.gameObject.activeInHierarchy)
		{
			MentorL2.SetTrigger("Left");
		}
		if (LeftPresses == 0f)
		{
			Left.Play();
			LeftPresses += 1f;
		}
		else if (LeftPresses == 1f)
		{
			Left2.Play();
			LeftPresses += 1f;
		}
		else if (LeftPresses == 2f)
		{
			Left3.Play();
			LeftPresses += 1f;
		}
		else if (LeftPresses >= 3f)
		{
			Left4.Play();
			LeftPresses += 1f;
		}
	}

	private void On_Right(KoreographyEvent evt)
	{
		if (!SumScoreManager.RightNeeded)
		{
			SumScoreManager.ButtsNeeded++;
		}
		SumScoreManager.RightNeeded = true;
		SumScoreManager.NoteAmount++;
		Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone";
		if (MentorL1.gameObject.activeInHierarchy)
		{
			MentorL1.SetTrigger("Right");
		}
		if (MentorL1b.gameObject.activeInHierarchy)
		{
			MentorL1b.SetTrigger("Right");
		}
		if (MentorL2.gameObject.activeInHierarchy)
		{
			MentorL2.SetTrigger("Right");
		}
		if (RightPresses == 0f)
		{
			Right.Play();
			RightPresses += 1f;
		}
		else if (RightPresses == 1f)
		{
			Right2.Play();
			RightPresses += 1f;
		}
		else if (RightPresses == 2f)
		{
			Right3.Play();
			RightPresses += 1f;
		}
		else if (RightPresses >= 3f)
		{
			Right4.Play();
			RightPresses += 1f;
		}
	}

	private void On_Abutt(KoreographyEvent evt)
	{
		if (!SumScoreManager.Butt1Needed)
		{
			SumScoreManager.ButtsNeeded++;
		}
		SumScoreManager.Butt1Needed = true;
		SumScoreManager.NoteAmount++;
		Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone";
		self.SetTrigger("speak");
		if (MentorL1.gameObject.activeInHierarchy)
		{
			MentorL1.SetTrigger("A");
		}
		if (MentorL2.gameObject.activeInHierarchy)
		{
			MentorL2.SetTrigger("A");
		}
		if (MentorL3.gameObject.activeInHierarchy)
		{
			MentorL3.SetTrigger("A");
		}
		if (MentorL7.gameObject.activeInHierarchy)
		{
			MentorL7.SetTrigger("A");
		}
		if (Butt1Presses == 0f)
		{
			A.Play();
			Butt1Presses += 1f;
			if (Line == 4f)
			{
				Scene3.SetActive(value: false);
				Scene1.SetActive(value: true);
				PlayerL1.SetTrigger("escape");
			}
			if (Line == 7f)
			{
				if (Difficulty == "Normal")
				{
					MentorL5.SetTrigger("A");
				}
				else if (Difficulty == "Easy")
				{
					MentorL5.SetTrigger("A2");
				}
			}
			if (Line == 8f)
			{
				MentorL6.SetTrigger("A");
			}
		}
		else if (Butt1Presses == 1f)
		{
			A2.Play();
			Butt1Presses += 1f;
			if (Line == 7f)
			{
				MentorL5.SetTrigger("A2");
			}
			if (Line == 8f)
			{
				MentorL6.SetTrigger("A2");
			}
		}
		else if (Butt1Presses == 2f)
		{
			A3.Play();
			Butt1Presses += 1f;
			if (Line == 7f)
			{
				MentorL5.SetTrigger("A");
			}
		}
		else if (Butt1Presses >= 3f)
		{
			A4.Play();
			Butt1Presses += 1f;
			if (Line == 8f)
			{
				MentorL6.SetTrigger("A2");
			}
		}
	}

	private void On_Bbutt(KoreographyEvent evt)
	{
		if (!SumScoreManager.Butt2Needed)
		{
			SumScoreManager.ButtsNeeded++;
		}
		SumScoreManager.Butt2Needed = true;
		SumScoreManager.NoteAmount++;
		Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone";
		if (!dontSpeak)
		{
			self.SetTrigger("speak");
		}
		if (MentorL1.gameObject.activeInHierarchy)
		{
			MentorL1.SetTrigger("B");
		}
		if (MentorL2.gameObject.activeInHierarchy)
		{
			MentorL2.SetTrigger("B");
		}
		if (MentorL5.gameObject.activeInHierarchy)
		{
			MentorL5.SetTrigger("B");
		}
		if (MentorL7.gameObject.activeInHierarchy)
		{
			MentorL7.SetTrigger("B");
		}
		if (MentorL8.gameObject.activeInHierarchy)
		{
			MentorL8.SetTrigger("B");
		}
		if (Butt2Presses == 0f)
		{
			B.Play();
			Butt2Presses += 1f;
			if (Line == 8f)
			{
				MentorL6.SetTrigger("B");
			}
		}
		else if (Butt2Presses == 1f)
		{
			B2.Play();
			Butt2Presses += 1f;
			if (Line == 8f)
			{
				MentorL6.SetTrigger("B2");
			}
		}
		else if (Butt2Presses == 2f)
		{
			B3.Play();
			Butt2Presses += 1f;
		}
		else if (Butt2Presses >= 3f)
		{
			B4.Play();
			Butt2Presses += 1f;
		}
	}

	private void On_Xbutt(KoreographyEvent evt)
	{
		if (!SumScoreManager.Butt4Needed)
		{
			SumScoreManager.ButtsNeeded++;
		}
		SumScoreManager.Butt4Needed = true;
		SumScoreManager.NoteAmount++;
		Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone";
		self.SetTrigger("speak");
		if (MentorL1.gameObject.activeInHierarchy)
		{
			MentorL1.SetTrigger("X");
		}
		if (MentorL4.gameObject.activeInHierarchy)
		{
			MentorL4.SetTrigger("X");
		}
		if (MentorL5.gameObject.activeInHierarchy)
		{
			MentorL5.SetTrigger("X");
		}
		if (MentorL7.gameObject.activeInHierarchy)
		{
			MentorL7.SetTrigger("X");
		}
		if (MentorL8.gameObject.activeInHierarchy)
		{
			MentorL8.SetTrigger("X");
		}
		if (Butt4Presses == 0f)
		{
			X.Play();
			Butt4Presses += 1f;
			MentorL2.SetTrigger("X");
			if (Line == 3f)
			{
				MentorL3.SetTrigger("X");
				Scene2.SetActive(value: false);
				Scene3.SetActive(value: true);
			}
			if (Line == 6f)
			{
				MentorL3.SetTrigger("X");
				Scene4.SetActive(value: false);
				Scene3.SetActive(value: true);
			}
			if (Line == 13f)
			{
				MentorL3.SetTrigger("X");
				Scene8.SetActive(value: false);
				Scene3.SetActive(value: true);
			}
			if (Line == 8f)
			{
				MentorL6.SetTrigger("X");
			}
		}
		else if (Butt4Presses == 1f && Line != 6f)
		{
			X2.Play();
			Butt4Presses += 1f;
			MentorL2.SetTrigger("X2");
			MentorL3.SetTrigger("X2");
		}
		else if (Butt4Presses == 1f && Line == 6f)
		{
			Butt4Presses += 1f;
			MentorL3.SetTrigger("X2");
		}
		else if (Butt4Presses == 2f)
		{
			X3.Play();
			Butt4Presses += 1f;
			if (Line == 8f)
			{
				MentorL6.SetTrigger("X2");
			}
		}
		else if (Butt4Presses >= 3f)
		{
			X4.Play();
			Butt4Presses += 1f;
		}
	}

	private void On_Ybutt(KoreographyEvent evt)
	{
		if (!SumScoreManager.Butt3Needed)
		{
			SumScoreManager.ButtsNeeded++;
		}
		SumScoreManager.Butt3Needed = true;
		SumScoreManager.NoteAmount++;
		Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone";
		self.SetTrigger("speak");
		if (MentorL1.gameObject.activeInHierarchy)
		{
			MentorL1.SetTrigger("Y");
		}
		if (MentorL3.gameObject.activeInHierarchy)
		{
			MentorL3.SetTrigger("Y");
		}
		if (MentorL5.gameObject.activeInHierarchy)
		{
			MentorL5.SetTrigger("Y");
		}
		if (MentorL7.gameObject.activeInHierarchy)
		{
			MentorL7.SetTrigger("Y");
		}
		if (MentorL8.gameObject.activeInHierarchy)
		{
			MentorL8.SetTrigger("Y");
		}
		if (Butt3Presses == 0f)
		{
			Y.Play();
			Butt3Presses += 1f;
			if (MentorL2.gameObject.activeInHierarchy)
			{
				MentorL2.SetTrigger("Y");
			}
			if (Line == 8f)
			{
				MentorL6.SetTrigger("Y");
			}
		}
		else if (Butt3Presses == 1f)
		{
			Y2.Play();
			Butt3Presses += 1f;
			MentorL2.SetTrigger("Y2");
			if (Line == 8f)
			{
				MentorL6.SetTrigger("Y2");
			}
		}
		else if (Butt3Presses == 2f)
		{
			Y3.Play();
			Butt3Presses += 1f;
		}
		else if (Butt3Presses >= 3f)
		{
			Y4.Play();
			Butt3Presses += 1f;
		}
	}

	private void On_Lbutt(KoreographyEvent evt)
	{
		SumScoreManager.ZLNeeded = true;
		if (!SumScoreManager.ZLNeeded)
		{
			SumScoreManager.ButtsNeeded++;
		}
		SumScoreManager.NoteAmount++;
		Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone";
		self.SetTrigger("speak");
		if (MentorL1.gameObject.activeInHierarchy)
		{
			MentorL1.SetTrigger("L");
		}
		if (MentorL7.gameObject.activeInHierarchy)
		{
			MentorL7.SetTrigger("L");
		}
		if (ZLPresses == 0f)
		{
			L.Play();
			ZLPresses += 1f;
		}
		else if (ZLPresses == 1f)
		{
			L2.Play();
			ZLPresses += 1f;
		}
		else if (ZLPresses == 2f)
		{
			L3.Play();
			ZLPresses += 1f;
		}
		else if (ZLPresses >= 3f)
		{
			L4.Play();
			ZLPresses += 1f;
		}
	}

	private void On_Rbutt(KoreographyEvent evt)
	{
		if (!SumScoreManager.ZRNeeded)
		{
			SumScoreManager.ButtsNeeded++;
		}
		SumScoreManager.ZRNeeded = true;
		SumScoreManager.NoteAmount++;
		Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone";
		self.SetTrigger("speak");
		if (MentorL1.gameObject.activeInHierarchy)
		{
			MentorL1.SetTrigger("R");
		}
		if (ZRPresses == 0f)
		{
			R.Play();
			ZRPresses += 1f;
		}
		else if (ZRPresses == 1f)
		{
			R2.Play();
			ZRPresses += 1f;
		}
		else if (ZRPresses == 2f)
		{
			R3.Play();
			ZRPresses += 1f;
		}
		else if (ZRPresses >= 3f)
		{
			R4.Play();
			ZRPresses += 1f;
		}
	}

	private void SwitchCam()
	{
		camera.SetTrigger("MentorTurn");
	}

	private void On_LineStart(KoreographyEvent evt)
	{
		if (Line > 0f)
		{
			RhyCircle.SetTrigger("flip1");
		}
		RhyCircle.ResetTrigger("none");
		Trail.Play();
		SumScoreManager.ButtsNeeded = 0;
		KillNotes();
		Line += 1f;
		active = true;
		highflipper.SetTrigger("flipup");
		GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 1f);
		GameObject[] array = GameObject.FindGameObjectsWithTag("NoteClone");
		for (int i = 0; i < array.Length; i++)
		{
			array[i].GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 1f);
		}
		done = false;
		Debug.Log("ButtsNeeded: " + SumScoreManager.ButtsNeeded);
		if (BlueLine)
		{
			Rep.SetTrigger("In");
		}
		else if (PinkLine)
		{
			Sup.SetTrigger("In");
		}
		NextLineWhole.SetTrigger("GoAway");
		if (DoubleLineNext)
		{
			Double.SetTrigger("In");
			DoubleLineNext = false;
			NextLine2.SetTrigger("Double");
		}
		else
		{
			Double.SetTrigger("Out");
			NextLine2.SetTrigger("Single");
		}
		if (Line == 1f)
		{
			NextLine.SetTrigger("Pink");
		}
		if (Line == 2f)
		{
			Double.SetTrigger("SPinkIn");
			Line2P.SetActive(value: true);
			GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
			RhyBox.SetTrigger("pink");
			Scene1.SetActive(value: false);
			Scene2.SetActive(value: true);
			NextLine.SetTrigger("Blue");
		}
		if (Line == 3f)
		{
			PlayerIcoRiv2.BlueLine1 = true;
			PlayerIcoRiv2.PinkLine1 = false;
			RhyBox.SetTrigger("blue");
			Line2P.SetActive(value: false);
			dontSpeak = true;
		}
		if (Line == 4f)
		{
			NextLine.SetTrigger("Pink");
			dontSpeak = false;
		}
		if (Line == 5f)
		{
			RhyBox.SetTrigger("pink");
			Scene1.SetActive(value: false);
			Scene4.SetActive(value: true);
			Double.SetTrigger("SPinkIn");
			Line5P.SetActive(value: true);
			NextLine.SetTrigger("Blue");
			GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
		}
		if (Line == 6f)
		{
			PlayerIcoRiv2.BlueLine1 = true;
			PlayerIcoRiv2.PinkLine1 = false;
			RhyBox.SetTrigger("blue");
			Line5P.SetActive(value: false);
			dontSpeak = true;
		}
		if (Line == 7f)
		{
			SumScoreManager.ButtsNeeded = 2;
			dontSpeak = false;
			Scene3.SetActive(value: false);
			Scene5.SetActive(value: true);
		}
		if (Line == 8f)
		{
			Scene5.SetActive(value: false);
			Scene6.SetActive(value: true);
		}
		if (Line == 9f)
		{
			SceneSKG.SetActive(value: false);
			Scene7.SetActive(value: true);
		}
		if (Line == 11f)
		{
			NextLine.SetTrigger("Pink");
			Scene7.SetActive(value: false);
			Scene1.SetActive(value: true);
			OtherWindow.SetActive(value: true);
		}
		if (Line == 12f)
		{
			RhyBox.SetTrigger("pink");
			Double.SetTrigger("SPinkIn");
			Line12P.SetActive(value: true);
			NextLine.SetTrigger("Blue");
			GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
			PlayerIcoRiv2.LineReady = false;
		}
		if (Line == 13f)
		{
			RhyBox.SetTrigger("blue");
			Line12P.SetActive(value: false);
			dontSpeak = true;
		}
		if (Line == 1f)
		{
			RhyLine_P.Blocks = 7;
		}
		if (Line == 3f)
		{
			RhyLine_P.Blocks = 4;
		}
		if (Line == 4f)
		{
			RhyLine_P.Blocks = 7;
		}
		if (Line == 6f)
		{
			RhyLine_P.Blocks = 4;
		}
		if (Line == 7f)
		{
			RhyLine_P.Blocks = 8;
		}
		if (Line == 12f)
		{
			RhyLine_P.Blocks = -2;
		}
		if (Line == 13f)
		{
			RhyLine_P.Blocks = 4;
		}
	}

	private void On_NextLine(KoreographyEvent evt)
	{
		if (active)
		{
			base.transform.localPosition = new Vector3(-10.09615f, 2.982475f, 12.91997f);
			MentorL1.SetTrigger("stop");
		}
		if (BlueLine)
		{
			Rep.SetTrigger("Out");
		}
		else if (PinkLine)
		{
			Sup.SetTrigger("Out");
		}
	}

	private void On_LineEnd(KoreographyEvent evt)
	{
		Trail.Stop();
		caption.text = "";
		MentorL1.SetTrigger("stop");
		base.transform.localPosition = new Vector3(-11.31f, 4.292475f, 12.91997f);
		active = false;
		highflipper.SetTrigger("flipdown");
		GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.5f);
		GameObject[] array = GameObject.FindGameObjectsWithTag("NoteClone");
		for (int i = 0; i < array.Length; i++)
		{
			array[i].GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.5f);
		}
		done = true;
		Debug.Log("ButtsNeeded: " + SumScoreManager.ButtsNeeded);
		MentorL1.SetTrigger("stop");
		if (BlueLine)
		{
			Rep.SetTrigger("Out");
		}
		else if (PinkLine)
		{
			Sup.SetTrigger("Out");
		}
		_ = Line;
		_ = 2f;
		_ = Line;
		_ = 3f;
		if (Line == 7f)
		{
			Scene5Mel.SetActive(value: true);
		}
	}

	private void On_PLineEnd(KoreographyEvent evt)
	{
		if (Line == 3f && done)
		{
			KillNotes();
		}
		if (Line == 5f && done)
		{
			KillNotes();
		}
		if (Line == 7f)
		{
			_ = done;
		}
		if (Line == 12f && done)
		{
			KillNotes();
		}
	}

	private void On_PinkWarning(KoreographyEvent evt)
	{
		RhyBox.SetTrigger("pinkwarn");
		ColorSwap.Play();
	}

	private void KillNotes()
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("NoteClone");
		for (int i = 0; i < array.Length; i++)
		{
			Object.Destroy(array[i]);
		}
		Butt2Presses = 0f;
		Butt1Presses = 0f;
		Butt3Presses = 0f;
		Butt4Presses = 0f;
		LeftPresses = 0f;
		RightPresses = 0f;
		DownPresses = 0f;
		UpPresses = 0f;
		ZLPresses = 0f;
		ZRPresses = 0f;
		SumScoreManager.NoteAmount = 0;
		SumScoreManager.Butt1Needed = false;
		SumScoreManager.Butt2Needed = false;
		SumScoreManager.Butt3Needed = false;
		SumScoreManager.Butt4Needed = false;
		SumScoreManager.UpNeeded = false;
		SumScoreManager.DownNeeded = false;
		SumScoreManager.LeftNeeded = false;
		SumScoreManager.RightNeeded = false;
		SumScoreManager.ZRNeeded = false;
		SumScoreManager.ZLNeeded = false;
	}

	private void Update()
	{
		if (PlayerIcoRiv2.ReadyToLoadSong && !SongLoaded)
		{
			if (!InStory)
			{
				if (Difficulty == "Easy")
				{
					MusicPlayer.LoadSong(Easy);
				}
				else if (Difficulty == "Normal")
				{
					MusicPlayer.LoadSong(Normal);
				}
				else if (Difficulty == "Hard")
				{
					MusicPlayer.LoadSong(Hard);
				}
			}
			else
			{
				MusicPlayer.LoadSong(Normal);
			}
			SongLoaded = true;
		}
		if (PinkLine)
		{
			RhyCircle.SetTrigger("none");
		}
		else
		{
			RhyCircle.ResetTrigger("none");
		}
		BlueLine = PlayerIcoRiv2.BlueLine1;
		PinkLine = PlayerIcoRiv2.PinkLine1;
		if (active)
		{
			if (Line == 7f)
			{
				caption.text = "Peace, loops, and ascension.";
			}
			if (Line == 8f)
			{
				caption.text = "Waves of the water break down the tension.";
			}
		}
		if (ResultsTime)
		{
			if (!Funkdone)
			{
				ResultsSlider.value += 4f;
				tick.Play();
				FunkAdded += 4;
				if (FunkAdded > PlayerIcoRiv2.FunkStatic)
				{
					FunkAdded = PlayerIcoRiv2.FunkStatic;
				}
				if (FunkAdded == PlayerIcoRiv2.FunkStatic)
				{
					Funkdone = true;
				}
			}
			if (Funkdone && !Styledone)
			{
				Stylecount.SetActive(value: true);
				ResultsSlider.value += 4f;
				tick.Play();
				StyleAdded += 4;
				if (StyleAdded > PlayerIcoRiv2.StyleStatic)
				{
					StyleAdded = PlayerIcoRiv2.StyleStatic;
				}
				if (StyleAdded >= PlayerIcoRiv2.StyleStatic)
				{
					Styledone = true;
				}
			}
			if (Styledone && !ACPdone)
			{
				Funkcount.SetActive(value: true);
				ResultsSlider.value += 4f;
				tick.Play();
				ACPAdded += 4;
				if (ACPAdded > PlayerIcoRiv2.ACPStatic)
				{
					ACPAdded = PlayerIcoRiv2.ACPStatic;
				}
				if (ACPAdded >= PlayerIcoRiv2.ACPStatic)
				{
					ACPdone = true;
				}
			}
			if (ACPdone)
			{
				if (Difficulty == "Easy")
				{
					highScore = ES3.Load("HighScoreNWAVeasy", defaultValue);
				}
				else if (Difficulty == "Normal")
				{
					highScore = ES3.Load("HighScoreNWAV", defaultValue);
				}
				ACPcount.SetActive(value: true);
				StartCoroutine(GiveRank());
				if ((float)(PlayerIcoRiv2.FunkStatic + PlayerIcoRiv2.StyleStatic + PlayerIcoRiv2.ACPStatic) > highScore)
				{
					NewRecord = true;
					if (Difficulty == "Easy")
					{
						ES3.Save("HighScoreNWAVeasy", (float)(PlayerIcoRiv2.FunkStatic + PlayerIcoRiv2.StyleStatic + PlayerIcoRiv2.ACPStatic));
					}
					else if (Difficulty == "Normal")
					{
						ES3.Save("HighScoreNWAV", (float)(PlayerIcoRiv2.FunkStatic + PlayerIcoRiv2.StyleStatic + PlayerIcoRiv2.ACPStatic));
					}
				}
			}
		}
		if (active)
		{
			base.transform.Translate(Speed * Time.deltaTime, 0f, 0f);
			if (!PinkLine)
			{
				playerico.GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.5f);
			}
		}
		if (Line == 1f)
		{
			MentorL1.SetInteger("Line", 1);
			Up.clip = p1;
			Left.clip = p2;
			Right.clip = p3;
			Up2.clip = p1;
			Left2.clip = p2;
			Right2.clip = p3;
			Down.clip = p4;
			Up3.clip = p1;
		}
		if (Line == 2f)
		{
			RhyCircle.SetBool("pink", value: true);
			MentorL1.SetInteger("Line", 2);
			Up.clip = p5;
			Up2.clip = p5;
			SumScoreManager.PinkNoteAmount = 2;
			SumScoreManager.Butt4Needed = true;
			SumScoreManager.ButtsNeeded = 1;
			GameObject[] array = GameObject.FindGameObjectsWithTag("NoteClone");
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
			}
		}
		if (Line == 3f)
		{
			RhyCircle.SetBool("pink", value: false);
			X.clip = none;
			A.clip = none;
			Y.clip = none;
			X2.clip = none;
		}
		if (Line == 4f)
		{
			MentorL1.SetInteger("Line", 1);
			Up.clip = p1;
			Left.clip = p2;
			Right.clip = p3;
			Up2.clip = p1;
			Left2.clip = p2;
			Right2.clip = p3;
			Up.clip = p1;
			Down.clip = p4;
		}
		if (Line == 5f)
		{
			RhyCircle.SetBool("pink", value: true);
			X.clip = p50;
			X.clip = p50;
			X2.clip = p50;
		}
		if (Line == 6f)
		{
			RhyCircle.SetBool("pink", value: false);
			X.clip = none;
			A.clip = none;
			Y.clip = none;
		}
		if (Line == 7f)
		{
			if (Difficulty == "Normal")
			{
				Y.clip = p10;
				B.clip = p11;
				A.clip = p12;
				A2.clip = p13;
			}
			else if (Difficulty == "Easy")
			{
				Y.clip = p10;
				B.clip = p11;
				A.clip = p13;
			}
		}
		if (Line == 8f)
		{
			if (Difficulty == "Normal")
			{
				A.clip = p14;
				B.clip = p15;
				B2.clip = p16;
				A2.clip = p17;
				Y.clip = p18;
				X.clip = p19;
				X2.clip = p20;
				Y2.clip = p21;
			}
			else if (Difficulty == "Easy")
			{
				A.clip = p14;
				A2.clip = p17;
				A3.clip = p14;
				Y.clip = p18;
				X.clip = p19;
				Y2.clip = p21;
			}
		}
		if (Line == 9f)
		{
			if (Difficulty == "Normal")
			{
				X.clip = p22;
				X2.clip = p23;
				A.clip = p24;
				A2.clip = p25;
				Y.clip = p26;
				Y2.clip = p27;
				L.clip = p28;
			}
			else if (Difficulty == "Easy")
			{
				X.clip = p22;
				X2.clip = p23;
				X3.clip = p22;
				L.clip = p28;
			}
		}
		if (Line == 10f)
		{
			if (Difficulty == "Normal")
			{
				A.clip = p29;
				A2.clip = p30;
				B.clip = p31;
				X.clip = p32;
				Y.clip = p33;
			}
			else if (Difficulty == "Easy")
			{
				A.clip = p29;
				A2.clip = p30;
				A3.clip = p30;
				X.clip = p32;
				Y.clip = p33;
			}
		}
		if (Line == 11f)
		{
			Down.clip = p34;
			Down2.clip = p34;
			Up.clip = p35;
			Right.clip = p36;
			Down3.clip = p37;
			Left.clip = p38;
			Up2.clip = p35;
			Right2.clip = p36;
			Down4.clip = p37;
			Left2.clip = p38;
		}
		if (Line == 12f)
		{
			Y.clip = p41;
			Y2.clip = p42;
			X.clip = p43;
			B.clip = p44;
		}
		if (Line == 13f)
		{
			X.clip = none;
			A.clip = none;
			Y.clip = none;
			X2.clip = none;
		}
	}

	private IEnumerator GiveRank()
	{
		Bonus();
		yield return new WaitForSeconds(2f);
		if (NewRecord)
		{
			NewRecordSplash.SetActive(value: true);
		}
		if (ResultsSlider.value >= 1650f)
		{
			Srank.SetActive(value: true);
			if (NewRecord)
			{
				if (Difficulty == "Easy")
				{
					ES3.Save("Riv2rankeasy", 5);
				}
				else if (Difficulty == "Normal")
				{
					ES3.Save("Riv2rank", 5);
				}
			}
			MelodiiRes.SetTrigger("nice");
		}
		else if (ResultsSlider.value >= 1288f && ResultsSlider.value < 1650f)
		{
			Arank.SetActive(value: true);
			if (NewRecord)
			{
				if (Difficulty == "Easy")
				{
					ES3.Save("Riv2rankeasy", 4);
				}
				else if (Difficulty == "Normal")
				{
					ES3.Save("Riv2rank", 4);
				}
			}
			MelodiiRes.SetTrigger("nice");
		}
		else if (ResultsSlider.value >= 1005f && ResultsSlider.value < 1288f)
		{
			Brank.SetActive(value: true);
			if (NewRecord)
			{
				if (Difficulty == "Easy")
				{
					ES3.Save("Riv2rankeasy", 3);
				}
				else if (Difficulty == "Normal")
				{
					ES3.Save("Riv2rank", 3);
				}
			}
			MelodiiRes.SetTrigger("nice");
		}
		else if (ResultsSlider.value >= 700f && ResultsSlider.value < 1005f)
		{
			Crank.SetActive(value: true);
			if (NewRecord)
			{
				if (Difficulty == "Easy")
				{
					ES3.Save("Riv2rankeasy", 2);
				}
				else if (Difficulty == "Normal")
				{
					ES3.Save("Riv2rank", 2);
				}
			}
			MelodiiRes.SetTrigger("okay");
		}
		else
		{
			Drank.SetActive(value: true);
			if (NewRecord)
			{
				if (Difficulty == "Easy")
				{
					ES3.Save("Riv2rankeasy", 1);
				}
				else if (Difficulty == "Normal")
				{
					ES3.Save("Riv2rank", 1);
				}
			}
			MelodiiRes.SetTrigger("okay");
		}
		yield return new WaitForSeconds(3f);
		ResultsTheme.SetActive(value: true);
		if (InStory)
		{
			ES3.Save("Level", 3);
			CloseStory.SetActive(value: true);
		}
		else
		{
			CloseReg.SetActive(value: true);
		}
	}

	public void HeadOut()
	{
		if (!InStory)
		{
			SceneLoader.LoadScene("LevelSelect");
			PlayerPrefs.SetInt("LastLevelPlayed", 2);
			PlayerPrefs.SetInt("AfterSong", 1);
		}
		else
		{
			SceneLoader.LoadScene("JamWell");
		}
	}

	private void On_EndSong(KoreographyEvent evt)
	{
		ResultsTime = true;
		Results.SetActive(value: true);
		UIjunk.enabled = false;
		UIjunk1.SetActive(value: false);
		RhyCam.SetActive(value: false);
		if (FirstTime)
		{
			ES3.Save("FirstTimeNMW", 1f);
		}
		if (SaveFile == 1 && InStory)
		{
			ES3.Save("LastSongStory", 2);
		}
	}
}
