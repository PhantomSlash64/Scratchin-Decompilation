using System.Collections;
using KetosGames.SceneTransition;
using SonicBloom.Koreo;
using SonicBloom.Koreo.Players;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MentorIcoRiv3 : MonoBehaviour
{
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

	public GameObject playerico;

	public ParticleSystem Trail;

	public int ExtraCount;

	public GameObject Line3P;

	public GameObject Line4P;

	public GameObject Line8P;

	public GameObject Line9P;

	public GameObject Line10P;

	public GameObject Line11P;

	public GameObject Line15P;

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

	public int IntroCount;

	public Animator IntroCam;

	public GameObject MainLight;

	public GameObject IntroScene;

	public GameObject Scene1;

	public GameObject Scene2;

	public GameObject Scene3;

	public GameObject Scene4;

	public GameObject SceneSKG;

	public GameObject Scene5;

	public GameObject Scene8;

	public GameObject Scene9;

	public GameObject Scene10;

	public GameObject CookiesScene;

	public GameObject Scene11;

	public GameObject ButterScene;

	public GameObject FinalScene;

	public GameObject CookieTray;

	public Animator ButterDance;

	public Animator Scene1Cam;

	public Animator Scene5Cam;

	public Animator Scene9Cam;

	public Animator Scene8bg;

	public TextMeshProUGUI caption;

	public Animator PlayerL1;

	public Animator MentorL1;

	public Animator MentorL2;

	public Animator MentorL3;

	public Animator MentorL4;

	public Animator MentorL5;

	public Animator MentorL8;

	public Animator PlayerL8;

	public Animator MentorL12;

	public Animator MentorL14;

	public Animator MentorL15;

	public Animator MentorL16;

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

	public AudioClip none;

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

	public AudioClip p87;

	public AudioClip p88;

	public AudioClip p89;

	public AudioClip p90;

	public AudioClip p91;

	public AudioClip p92;

	public AudioClip p93;

	public AudioClip p94;

	public AudioClip p95;

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
	public string Extra;

	[EventID]
	public string PinkWarning;

	[EventID]
	public string EndSong;

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
		Difficulty = PlayerPrefs.GetString("difficulty");
		Difficulty2 = Difficulty;
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
		if (LevelSelect.InStory)
		{
			InStory = true;
		}
		else
		{
			PlayerPrefs.SetInt("LastLevelPlayed", 3);
		}
		SaveFile = PlayerPrefs.GetInt("SaveFile");
		firstTime = ES3.Load("FirstTimeSAM", defaultValue);
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
		Koreographer.Instance.RegisterForEvents(Extra, On_Extra);
		Koreographer.Instance.RegisterForEvents(PinkWarning, On_PinkWarning);
		Koreographer.Instance.RegisterForEvents(EndSong, On_EndSong);
		NextLine2.SetTrigger("Double");
	}

	private void Bonus()
	{
		if (PlayerIcoRiv3.HiFi && !BonusAdded)
		{
			BonusAdded = true;
			HiFiBonus.SetActive(value: true);
			ResultsSlider.value += 25f;
		}
		else if (PlayerIcoRiv3.WoahFi && !BonusAdded)
		{
			BonusAdded = true;
			WoahFiBonus.SetActive(value: true);
			ResultsSlider.value += 400f;
		}
	}

	private void On_Intro(KoreographyEvent evt)
	{
		IntroCount++;
		if (IntroCount == 1)
		{
			IntroCam.SetTrigger("next");
			Scene1.SetActive(value: false);
			UIjunk1.SetActive(value: false);
			UIjunk.enabled = false;
		}
		if (IntroCount == 2)
		{
			IntroCam.SetTrigger("next");
		}
		if (IntroCount == 3)
		{
			IntroCam.SetTrigger("next");
			Scene1.SetActive(value: true);
		}
		if (IntroCount == 4)
		{
			IntroScene.SetActive(value: false);
			MainLight.SetActive(value: true);
			Scene1Cam.SetTrigger("reset");
		}
		if (IntroCount == 5)
		{
			UIjunk.enabled = true;
			UIjunk1.SetActive(value: true);
			RhyBox.SetTrigger("boxin");
			Scene1Cam.SetTrigger("Mel");
		}
	}

	private void On_Extra(KoreographyEvent evt)
	{
		if (Line == 1f || (Line == 16f && !done))
		{
			L2.clip = p93;
			L2.Play();
		}
		if (Line == 4f)
		{
			caption.text = "";
			RhyBox.SetTrigger("boxout");
			Line4P.SetActive(value: false);
			Scene4.SetActive(value: false);
			SceneSKG.SetActive(value: true);
		}
		if (Line == 14f)
		{
			Scene10.SetActive(value: false);
			CookiesScene.SetActive(value: true);
			caption.text = "I'm gonna give him cookies saying...";
			Up.Play();
			KillNotes();
		}
		if (Line == 15f && !done)
		{
			PlayerIcoRiv3.LineReady = true;
			CookiesScene.SetActive(value: false);
			Scene11.SetActive(value: true);
		}
		if (Line == 15f && done)
		{
			ButterDance.SetTrigger("go");
		}
		if (Line == 16f && done)
		{
			FinalScene.SetActive(value: true);
			CookieTray.SetActive(value: false);
			caption.text = "";
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
		self.SetTrigger("speak1");
		if (Line > 4f && Line < 8f)
		{
			MentorL5.SetTrigger("Up");
		}
		if (UpPresses == 0f)
		{
			Up.Play();
			UpPresses += 1f;
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
		self.SetTrigger("speak1");
		if (Line > 4f && Line < 8f)
		{
			MentorL5.SetTrigger("Down");
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
		if (Line < 8f || Line > 11f)
		{
			Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone";
		}
		self.SetTrigger("speak1");
		if (Line == 9f)
		{
			MentorL5.SetTrigger("Left");
		}
		if (Line == 8f || Line == 9f)
		{
			MentorL8.SetTrigger("Left");
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
		if (Line < 8f || Line > 11f)
		{
			Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone";
		}
		self.SetTrigger("speak1");
		if (Line > 4f && Line < 8f)
		{
			MentorL5.SetTrigger("Right");
		}
		if (Line == 8f)
		{
			MentorL8.SetTrigger("Right");
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
		if (Line < 8f || Line > 11f)
		{
			Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone";
		}
		self.SetTrigger("speak");
		if (Line < 3f || Line == 16f)
		{
			MentorL1.SetTrigger("A");
		}
		if (Line > 4f && Line < 8f)
		{
			MentorL5.SetTrigger("A");
		}
		if (Line == 10f || Line == 11f)
		{
			MentorL8.SetTrigger("A");
		}
		if (Line == 14f)
		{
			MentorL14.SetTrigger("A");
		}
		if (Line == 15f)
		{
			MentorL15.SetTrigger("A");
		}
		if (Butt1Presses == 0f)
		{
			if (Line != 10f)
			{
				A.Play();
			}
			else
			{
				A.PlayOneShot(p69, 1f);
			}
			Butt1Presses += 1f;
			if (Line == 3f)
			{
				MentorL3.SetTrigger("A");
			}
			if (Line == 4f)
			{
				MentorL4.SetTrigger("A");
			}
			if (Line == 12f || Line == 13f)
			{
				MentorL12.SetTrigger("A");
			}
		}
		else if (Butt1Presses == 1f)
		{
			A2.Play();
			Butt1Presses += 1f;
			if (Line == 3f)
			{
				MentorL3.SetTrigger("A2");
			}
			if (Line == 4f)
			{
				MentorL4.SetTrigger("A2");
			}
			if (Line == 12f || Line == 13f)
			{
				MentorL12.SetTrigger("A2");
			}
		}
		else if (Butt1Presses == 2f)
		{
			A3.Play();
			Butt1Presses += 1f;
		}
		else if (Butt1Presses >= 3f)
		{
			A4.Play();
			Butt1Presses += 1f;
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
		self.SetTrigger("speak");
		if (Line == 12f)
		{
			MentorL12.SetTrigger("B");
		}
		if (Line == 14f)
		{
			MentorL14.SetTrigger("B");
		}
		if (Line == 15f)
		{
			MentorL15.SetTrigger("B");
		}
		if (Butt2Presses == 0f)
		{
			B.Play();
			Butt2Presses += 1f;
			if (Line == 1f || Line == 2f || Line == 16f)
			{
				MentorL1.SetTrigger("B");
			}
			if (Line == 4f)
			{
				MentorL4.SetTrigger("B");
			}
			if (Line == 13f)
			{
				MentorL12.SetTrigger("B");
			}
		}
		else if (Butt2Presses == 1f)
		{
			B2.Play();
			Butt2Presses += 1f;
			if (Line == 1f || Line == 2f || Line == 16f)
			{
				MentorL1.SetTrigger("B2");
			}
			if (Line == 4f)
			{
				MentorL4.SetTrigger("B2");
			}
			if (Line == 13f)
			{
				MentorL12.SetTrigger("B2");
			}
		}
		else if (Butt2Presses == 2f)
		{
			B3.Play();
			Butt2Presses += 1f;
			if (Line == 1f || Line == 2f || Line == 16f)
			{
				MentorL1.SetTrigger("B3");
			}
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
		if (Line == 13f)
		{
			MentorL12.SetTrigger("X");
		}
		if (Butt4Presses == 0f)
		{
			X.Play();
			Butt4Presses += 1f;
			if (Line == 1f || Line == 2f || Line == 16f)
			{
				MentorL1.SetTrigger("X");
			}
			if (Line == 3f)
			{
				MentorL3.SetTrigger("X");
			}
			if (Line == 4f)
			{
				MentorL4.SetTrigger("X");
			}
			if (Line == 12f)
			{
				MentorL12.SetTrigger("X");
			}
		}
		else if (Butt4Presses == 1f)
		{
			X2.Play();
			Butt4Presses += 1f;
			if (Line == 1f || Line == 2f || Line == 16f)
			{
				MentorL1.SetTrigger("X2");
			}
			if (Line == 3f)
			{
				MentorL3.SetTrigger("X2");
			}
			if (Line == 4f)
			{
				MentorL4.SetTrigger("X2");
			}
			if (Line == 12f)
			{
				MentorL12.SetTrigger("X2");
			}
		}
		else if (Butt4Presses == 2f)
		{
			X3.Play();
			Butt4Presses += 1f;
			if (Line == 12f)
			{
				MentorL12.SetTrigger("X3");
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
		if (Line == 12f || Line == 13f)
		{
			MentorL12.SetTrigger("Y");
		}
		if (Line == 15f)
		{
			MentorL15.SetTrigger("Y");
		}
		if (Butt3Presses == 0f)
		{
			Y.Play();
			Butt3Presses += 1f;
			if (Line == 1f || Line == 2f || Line == 16f)
			{
				MentorL1.SetTrigger("Y");
			}
			if (Line == 3f)
			{
				MentorL3.SetTrigger("Y");
			}
			if (Line == 4f)
			{
				MentorL4.SetTrigger("Y");
			}
		}
		else if (Butt3Presses == 1f)
		{
			Y2.Play();
			Butt3Presses += 1f;
			if (Line == 1f || Line == 16f)
			{
				MentorL1.SetTrigger("Y2");
			}
			if (Line == 3f)
			{
				MentorL3.SetTrigger("Y2");
			}
			if (Line == 4f)
			{
				MentorL4.SetTrigger("Y2");
			}
		}
		else if (Butt3Presses == 2f)
		{
			Y3.Play();
			Butt3Presses += 1f;
			if (Line == 1f || Line == 16f)
			{
				MentorL1.SetTrigger("Y3");
			}
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
		if (Line < 8f || Line > 11f)
		{
			Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone";
		}
		self.SetTrigger("speak");
		if (Line < 3f || Line == 16f)
		{
			MentorL1.SetTrigger("L");
		}
		if (Line == 10f || Line == 11f)
		{
			MentorL8.SetTrigger("L");
		}
		if (Line == 12f || Line == 13f)
		{
			MentorL12.SetTrigger("L");
		}
		if (Line == 14f)
		{
			MentorL14.SetTrigger("L");
		}
		if (ZLPresses == 0f)
		{
			L.Play();
			ZLPresses += 1f;
			if (Line == 3f)
			{
				MentorL3.SetTrigger("L");
			}
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
		if (Line < 8f || Line > 11f)
		{
			Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone";
		}
		self.SetTrigger("speak");
		if (Line < 3f || Line == 16f)
		{
			MentorL1.SetTrigger("R");
		}
		if (Line == 10f || Line == 11f)
		{
			MentorL8.SetTrigger("R");
		}
		if (ZRPresses == 0f)
		{
			R.Play();
			ZRPresses += 1f;
			if (Line == 4f)
			{
				MentorL4.SetTrigger("R");
			}
			if (Line == 14f)
			{
				MentorL14.SetTrigger("R");
			}
		}
		else if (ZRPresses == 1f)
		{
			R2.Play();
			ZRPresses += 1f;
			if (Line == 4f)
			{
				MentorL4.SetTrigger("R");
			}
			if (Line == 14f)
			{
				MentorL14.SetTrigger("R2");
			}
		}
		else if (ZRPresses == 2f)
		{
			R3.Play();
			ZRPresses += 1f;
			if (Line == 4f)
			{
				MentorL4.SetTrigger("R");
			}
			if (Line == 14f)
			{
				MentorL14.SetTrigger("R");
			}
		}
		else if (ZRPresses >= 3f)
		{
			R4.Play();
			ZRPresses += 1f;
			if (Line == 14f)
			{
				MentorL14.SetTrigger("R2");
			}
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
		if (DoubleLineNext)
		{
			Double.SetTrigger("In");
			DoubleLineNext = false;
		}
		else
		{
			Double.SetTrigger("Out");
		}
		if (Line == 0f)
		{
			DoubleLineNext = true;
		}
		if (Line == 1f)
		{
			NextLine2.SetTrigger("Double");
			DoubleLineNext = true;
		}
		if (Line == 1f)
		{
			caption.text = "Making cookies for my love, I stir and mix!";
			Scene1Cam.SetTrigger("Jam");
			RhyLine_P.Double = 2;
		}
		if (Line == 2f)
		{
			caption.text = "He deserves icing and sprinkles, yes all of it!";
			NextLine2.SetTrigger("Single");
			NextLine.SetTrigger("Pink");
			Scene1Cam.SetTrigger("Jam");
			RhyLine_P.Double = 2;
		}
		if (Line == 3f)
		{
			caption.text = "What will I do if he hates me?!";
			Scene2.SetActive(value: false);
			Scene3.SetActive(value: true);
			Double.SetTrigger("SPinkIn");
			GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
			Line3P.SetActive(value: true);
			NextLine2.SetTrigger("Single");
			NextLine.SetTrigger("Pink");
			RhyLine_P.Double = 1;
		}
		if (Line == 4f)
		{
			caption.text = "Will baked goods set his heart free?!";
			Scene3.SetActive(value: false);
			Scene4.SetActive(value: true);
			Double.SetTrigger("SPinkIn");
			GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
			Line3P.SetActive(value: false);
			Line4P.SetActive(value: true);
			NextLine2.SetTrigger("Double");
			DoubleLineNext = true;
			NextLine.SetTrigger("Blue");
		}
		if (Line == 5f)
		{
			Scene5.SetActive(value: true);
			RhyBox.SetTrigger("boxin");
			Scene5Cam.SetTrigger("Jam");
			RhyLine_P.Double = 2;
		}
		if (Line == 6f)
		{
			Scene5Cam.SetTrigger("Jam");
			RhyLine_P.Double = 1;
		}
		if (Line == 7f)
		{
			NextLine2.SetTrigger("Double");
			NextLine.SetTrigger("Pink");
			Scene5Cam.SetTrigger("Jam");
		}
		if (Line > 7f && Line < 12f)
		{
			Trail.Stop();
			Double.SetTrigger("DPinkIn");
			GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
		}
		if (Line == 8f)
		{
			Scene5.SetActive(value: false);
			Scene8.SetActive(value: true);
			caption.text = "Mix, mix, mix, uh huh!";
			RhyCircle.SetBool("pink", value: true);
			RhyLine_P.Double = 2;
		}
		if (Line == 9f)
		{
			caption.text = "Stir, stir, stir, what's up!";
		}
		if (Line == 10f)
		{
			caption.text = "Mix, mix, mix, uh huh!";
		}
		if (Line == 11f)
		{
			NextLine2.SetTrigger("Single");
			NextLine.SetTrigger("Blue");
			caption.text = "Stir, stir, stir, word up!";
		}
		if (Line == 12f)
		{
			Scene8.SetActive(value: false);
			Scene9.SetActive(value: true);
			Line11P.SetActive(value: false);
			caption.text = "Love is such a fickle thing!";
			RhyBox.SetTrigger("blue");
			RhyCircle.SetBool("pink", value: false);
			RhyLine_P.Double = 1;
		}
		if (Line == 12f || Line == 13f)
		{
			Scene9Cam.SetTrigger("Jam");
		}
		if (Line == 13f)
		{
			MentorL12.SetInteger("Line", 13);
			caption.text = "Wondering what our hearts will bring...";
		}
		if (Line == 14f)
		{
			Scene9.SetActive(value: false);
			Scene10.SetActive(value: true);
			caption.text = "I could go from rosy red...";
			NextLine2.SetTrigger("Single");
			NextLine.SetTrigger("Pink");
		}
		if (Line == 15f)
		{
			Line15P.SetActive(value: true);
			caption.text = "''I love you!''";
			Double.SetTrigger("SPinkIn");
			GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
			PlayerIcoRiv3.LineReady = false;
			NextLine2.SetTrigger("Double");
			DoubleLineNext = true;
			CookieTray.SetActive(value: true);
			RhyBox.SetTrigger("pink");
		}
		if (Line == 16f)
		{
			ButterScene.SetActive(value: false);
			Scene1.SetActive(value: true);
			caption.text = "Making cookies for my love, I stir and mix...";
			Double.SetTrigger("In");
			RhyBox.SetTrigger("boxin");
			RhyBox.SetTrigger("blue");
		}
		if (Line == 1f)
		{
			RhyLine_P.Blocks = 8;
		}
		if (Line == 3f)
		{
			RhyLine_P.PlayerSpecific = true;
			RhyLine_P.Blocks2 = 5;
		}
		if (Line == 5f)
		{
			RhyLine_P.PlayerSpecific = false;
			RhyLine_P.Blocks = 8;
		}
		if (Line == 15f)
		{
			RhyLine_P.Blocks = -2;
		}
		if (Line == 16f)
		{
			RhyLine_P.Blocks = 8;
		}
	}

	private void On_NextLine(KoreographyEvent evt)
	{
		if (active)
		{
			base.transform.localPosition = new Vector3(-10.09615f, 2.982475f, 12.91997f);
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
		if (Line < 3f || Line == 16f)
		{
			MentorL1.SetTrigger("stop");
		}
		if (Line > 4f)
		{
			MentorL5.SetTrigger("stop");
		}
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
		if (BlueLine)
		{
			Rep.SetTrigger("Out");
		}
		else if (PinkLine)
		{
			Sup.SetTrigger("Out");
		}
		if (Line == 2f)
		{
			DoubleLineNext = true;
		}
		if (Line == 3f)
		{
			DoubleLineNext = true;
		}
		if (Line == 4f)
		{
			DoubleLineNext = true;
		}
		if (Line == 5f)
		{
			DoubleLineNext = false;
		}
		_ = Line;
		_ = 6f;
		if (Line == 8f)
		{
			Line8P.SetActive(value: false);
			Line9P.SetActive(value: true);
		}
		if (Line == 9f)
		{
			Line9P.SetActive(value: false);
			Line10P.SetActive(value: true);
			MentorL8.SetTrigger("book");
			Scene8bg.SetTrigger("next");
		}
		if (Line == 10f)
		{
			Line10P.SetActive(value: false);
			Line11P.SetActive(value: true);
		}
		if (Line == 11f)
		{
			PlayerL8.SetTrigger("laugh");
		}
		if (Line == 15f)
		{
			Scene11.SetActive(value: false);
			ButterScene.SetActive(value: true);
			caption.text = "";
			Line15P.SetActive(value: false);
			RhyBox.SetTrigger("boxout");
		}
	}

	private void On_PLineEnd(KoreographyEvent evt)
	{
		if (Line == 5f && done)
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
		BlueLine = PlayerIcoRiv3.BlueLine1;
		PinkLine = PlayerIcoRiv3.PinkLine1;
		if (ResultsTime)
		{
			if (!Funkdone)
			{
				ResultsSlider.value += 4f;
				tick.Play();
				FunkAdded += 4;
				if (FunkAdded > PlayerIcoRiv3.FunkStatic)
				{
					FunkAdded = PlayerIcoRiv3.FunkStatic;
				}
				if (FunkAdded == PlayerIcoRiv3.FunkStatic)
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
				if (StyleAdded > PlayerIcoRiv3.StyleStatic)
				{
					StyleAdded = PlayerIcoRiv3.StyleStatic;
				}
				if (StyleAdded >= PlayerIcoRiv3.StyleStatic)
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
				if (ACPAdded > PlayerIcoRiv3.ACPStatic)
				{
					ACPAdded = PlayerIcoRiv3.ACPStatic;
				}
				if (ACPAdded >= PlayerIcoRiv3.ACPStatic)
				{
					ACPdone = true;
				}
			}
			if (ACPdone)
			{
				if (Difficulty == "Easy")
				{
					highScore = ES3.Load("HighScoreSAMeasy", defaultValue);
				}
				else if (Difficulty == "Normal")
				{
					highScore = ES3.Load("HighScoreSAM", defaultValue);
				}
				ACPcount.SetActive(value: true);
				StartCoroutine(GiveRank());
				if ((float)(PlayerIcoRiv3.FunkStatic + PlayerIcoRiv3.StyleStatic + PlayerIcoRiv3.ACPStatic) > highScore)
				{
					NewRecord = true;
					if (Difficulty == "Easy")
					{
						ES3.Save("HighScoreSAMeasy", (float)(PlayerIcoRiv3.FunkStatic + PlayerIcoRiv3.StyleStatic + PlayerIcoRiv3.ACPStatic));
					}
					else if (Difficulty == "Normal")
					{
						ES3.Save("HighScoreSAM", (float)(PlayerIcoRiv3.FunkStatic + PlayerIcoRiv3.StyleStatic + PlayerIcoRiv3.ACPStatic));
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
			if (Difficulty == "Normal")
			{
				MentorL1.SetInteger("Line", 1);
				A.clip = p1;
				B.clip = p2;
				X.clip = p3;
				X2.clip = p4;
				L.clip = none;
				R.clip = p6;
				Y.clip = p7;
				Y2.clip = p8;
				Y3.clip = p9;
			}
			else if (Difficulty == "Easy")
			{
				MentorL1.SetInteger("Line", 1);
				R.clip = p27;
				L.clip = none;
				A.clip = p1;
				B.clip = p2;
				Y.clip = p7;
				Y2.clip = p8;
				Y3.clip = p9;
			}
		}
		if (Line == 2f)
		{
			MentorL1.SetInteger("Line", 2);
			X.clip = p10;
			X2.clip = p11;
			R.clip = p12;
			A.clip = p13;
			L.clip = p14;
			Y.clip = p15;
			B.clip = p16;
			B2.clip = p17;
			B3.clip = p18;
		}
		if (Line == 3f)
		{
			if (Difficulty == "Normal")
			{
				L.clip = p19;
				A.clip = p20;
				X.clip = p21;
				X2.clip = p22;
				Y.clip = p23;
				Y2.clip = p24;
				A2.clip = p25;
				GameObject[] array = GameObject.FindGameObjectsWithTag("NoteClone");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
				}
			}
			else if (Difficulty == "Easy")
			{
				L.clip = p28;
				X.clip = p22;
				Y.clip = p23;
				Y2.clip = p24;
				A.clip = p25;
				GameObject[] array = GameObject.FindGameObjectsWithTag("NoteClone");
				for (int i = 0; i < array.Length; i++)
				{
					array[i].GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
				}
			}
		}
		if (Line == 4f)
		{
			R.clip = p30;
			B.clip = p31;
			Y.clip = p32;
			Y2.clip = p33;
			X.clip = p34;
			X2.clip = p35;
			B2.clip = p36;
			GameObject[] array = GameObject.FindGameObjectsWithTag("NoteClone");
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
			}
		}
		if (Line == 5f)
		{
			Down.clip = p41;
			Left.clip = p42;
			Right.clip = p43;
			Left2.clip = p44;
			Right2.clip = p45;
			Down2.clip = p46;
			Up.clip = p47;
			Down3.clip = p48;
			Up2.clip = p49;
			Down4.clip = p50;
			A.clip = p51;
		}
		if (Line == 6f)
		{
			Left.clip = p52;
			Right.clip = p53;
			Up.clip = p54;
			Up2.clip = p55;
			Left2.clip = p56;
			Right2.clip = p57;
		}
		if (Line == 7f)
		{
			Left.clip = p58;
			Right.clip = p59;
			Left2.clip = p60;
			Down.clip = p61;
			Up.clip = p62;
			Down2.clip = p63;
		}
		if (Line == 8f)
		{
			Right.clip = p64;
			Right2.clip = p64;
			Right3.clip = p64;
			Right4.clip = p64;
			GameObject[] array = GameObject.FindGameObjectsWithTag("NoteClone");
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
			}
		}
		if (Line == 9f)
		{
			Left.clip = p65;
			Left2.clip = p65;
			Left3.clip = p65;
			Left4.clip = p65;
			GameObject[] array = GameObject.FindGameObjectsWithTag("NoteClone");
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
			}
		}
		if (Line == 10f)
		{
			R.clip = p68;
			R2.clip = p68;
			R3.clip = p68;
			R4.clip = p68;
			A.clip = p69;
			GameObject[] array = GameObject.FindGameObjectsWithTag("NoteClone");
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
			}
		}
		if (Line == 11f)
		{
			L.clip = p70;
			L2.clip = p70;
			L3.clip = p70;
			L4.clip = p70;
			A.clip = p71;
			GameObject[] array = GameObject.FindGameObjectsWithTag("NoteClone");
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
			}
		}
		if (Line == 12f)
		{
			if (Difficulty == "Normal")
			{
				L.clip = p72;
				X.clip = p73;
				X2.clip = p74;
				X3.clip = p75;
				A.clip = p76;
				A2.clip = p77;
				B.clip = p78;
			}
			else if (Difficulty == "Easy")
			{
				L.clip = p72;
				X.clip = p73;
				X2.clip = p75;
				A.clip = p76;
				A2.clip = p77;
				B.clip = p78;
			}
		}
		if (Line == 13f)
		{
			if (Difficulty == "Normal")
			{
				Y.clip = p79;
				X.clip = p80;
				B.clip = p81;
				B2.clip = p82;
				A.clip = p83;
				A2.clip = p84;
			}
			if (Difficulty == "Easy")
			{
				Y.clip = p79;
				X.clip = p80;
				B.clip = p82;
				A.clip = p84;
			}
		}
		if (Line == 14f)
		{
			R.clip = p85;
			R2.clip = p86;
			L.clip = p87;
			A.clip = p88;
			B.clip = p89;
			Up.clip = p95;
		}
		if (Line == 15f)
		{
			B.clip = p90;
			A.clip = p91;
			Y.clip = p92;
			GameObject[] array = GameObject.FindGameObjectsWithTag("NoteClone");
			for (int i = 0; i < array.Length; i++)
			{
				array[i].GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.2f);
			}
		}
		if (Line == 16f)
		{
			if (Difficulty == "Normal")
			{
				MentorL1.SetInteger("Line", 1);
				A.clip = p1;
				B.clip = p2;
				X.clip = p3;
				X2.clip = p4;
				L.clip = none;
				R.clip = p6;
				Y.clip = p7;
				Y2.clip = p8;
				Y3.clip = p9;
			}
			else if (Difficulty == "Easy")
			{
				MentorL1.SetInteger("Line", 1);
				R.clip = p27;
				L.clip = none;
				A.clip = p1;
				B.clip = p2;
				Y.clip = p7;
				Y2.clip = p8;
				Y3.clip = p9;
			}
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
					ES3.Save("Riv3rankeasy", 5);
				}
				else if (Difficulty == "Normal")
				{
					ES3.Save("Riv3rank", 5);
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
					ES3.Save("Riv3rankeasy", 4);
				}
				else if (Difficulty == "Normal")
				{
					ES3.Save("Riv3rank", 4);
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
					ES3.Save("Riv3rankeasy", 3);
				}
				else if (Difficulty == "Normal")
				{
					ES3.Save("Riv3rank", 3);
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
					ES3.Save("Riv3rankeasy", 2);
				}
				else if (Difficulty == "Normal")
				{
					ES3.Save("Riv3rank", 2);
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
					ES3.Save("Riv3rankeasy", 1);
				}
				else if (Difficulty == "Normal")
				{
					ES3.Save("Riv3rank", 1);
				}
			}
			MelodiiRes.SetTrigger("okay");
		}
		yield return new WaitForSeconds(3f);
		ResultsTheme.SetActive(value: true);
		if (InStory)
		{
			ES3.Save("Level", 2);
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
			PlayerPrefs.SetInt("LastLevelPlayed", 3);
			PlayerPrefs.SetInt("AfterSong", 1);
		}
		else
		{
			SceneLoader.LoadScene("JamWell");
		}
	}

	private void On_EndSong(KoreographyEvent evt)
	{
		self.SetTrigger("cry");
		ResultsTime = true;
		Results.SetActive(value: true);
		UIjunk.enabled = false;
		UIjunk1.SetActive(value: false);
		RhyCam.SetActive(value: false);
		if (FirstTime)
		{
			ES3.Save("FirstTimeSAM", 1f);
		}
		if (SaveFile == 1 && InStory)
		{
			ES3.Save("LastSongStory", 3);
		}
		FinalScene.SetActive(value: false);
	}
}
