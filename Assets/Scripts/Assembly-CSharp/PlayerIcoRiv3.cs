using System.Collections;
using Rewired;
using SonicBloom.Koreo;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerIcoRiv3 : MonoBehaviour
{
	public bool DebugMode;

	public static bool CanSkipIntro = false;

	public int story;

	public GameObject IntroSkipper;

	public bool StickerUsed;

	public int playerId;

	private Player player;

	private CharacterController cc;

	public float VibLvl;

	public int LofiWarning;

	public bool InStory;

	public int Dots;

	public float PressesAllowed;

	public float IPS;

	public float IPSLimit;

	public float IPSLimitOG;

	public float IPSLimitFS;

	public bool CheckingIPS;

	public float ButtPresses;

	public static bool WoahFi = false;

	public static bool HiFi = true;

	public static bool MidFi = false;

	public static bool LoFi = false;

	public static bool LineReady = true;

	public bool BlueLine = true;

	public bool PinkLine;

	public static bool BlueLine1 = true;

	public static bool PinkLine1 = false;

	public bool songOver;

	public Animator RhyBox;

	public Animator RhyCircle;

	public ParticleSystem Trail;

	public GameObject MainCam;

	public Text DebugButtneed;

	public GameObject GameOver;

	public GameObject DANGER;

	public GameObject Breather;

	public GameObject Scene1obj;

	public GameObject Scene2;

	public GameObject AllScenes;

	public GameObject GameOpress;

	public AudioSource DangerBeat;

	public AudioReverbFilter reverb;

	public int ACP;

	public int ACP2;

	public int funkneeded;

	public int funkneededOG;

	public int ACPneeded;

	public int ACPneededOG;

	public int grooveneeded;

	public int grooveneededOG;

	private bool active;

	private bool active2;

	public bool ButtBusy;

	public bool GrooveReady;

	public GameObject Fryer;

	public GameObject Fryer2;

	public bool gamePaused;

	public AudioSource Instrumental;

	public GameObject Menu;

	public Animator Fidelity;

	public GameObject FreeMode;

	public bool FreeStyle;

	public AudioSource freeIntro;

	public AudioSource freeLoop;

	public AudioSource badend;

	public AudioSource twLoop;

	public GameObject freeLoop_obj;

	public GameObject MentorVoice;

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

	public GameObject sparkleB;

	public AudioSource voice;

	public Animator PlayerFree;

	public Animator PlayerL1;

	public Animator PlayerL2;

	public GameObject PlayerL2obj;

	public Animator PlayerL3;

	public Animator PlayerL4;

	public Animator PlayerL5;

	public Animator PlayerL8;

	public Animator PlayerL12;

	public Animator PlayerL14;

	public Animator PlayerL15;

	public Animator PlayerL16;

	public GameObject WeddingCake;

	public ParticleSystem Smoke;

	public Animator Oven;

	public Animator funknob;

	public Animator Scene1;

	public Animator Scene1Cam;

	public Animator Scene5Cam;

	public Animator Scene9Cam;

	public Animator Scene10Cam;

	public Animator Scene10bg;

	public GameObject Line8P;

	public TextMeshProUGUI caption;

	public TextMeshProUGUI ScoreAdd;

	public TextMeshProUGUI ScoreSub;

	public Slider FunkSlider;

	public Slider ACPSlider;

	public GameObject Glow;

	public GameObject top_flipper;

	public GameObject bottom_flipper;

	public float line = 1f;

	public float groovycount;

	public float badcount;

	public GUI scoreText;

	public float rhyths;

	public bool onbackbeat;

	public bool onbeat;

	public bool onstarbeat;

	public bool offbeat = true;

	public bool offbackbeat = true;

	public bool offstarbeat = true;

	public bool offanybeat;

	public bool onanybeat;

	public bool good;

	public bool groovy;

	public bool pressUp;

	public bool pressDown;

	public bool pressRight;

	public bool pressLeft;

	public bool pressZL;

	public bool pressZR;

	public bool ZLdown;

	public bool ZRdown;

	public int funk;

	public int style;

	public AudioClip good1;

	public AudioClip bad1;

	public ParticleSystem burstin;

	public float Speed;

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

	public AudioClip miss;

	private Animator anim;

	public Animator lowflipper;

	public Animator highflipper;

	public Animator mentor;

	public GameObject FadeOff;

	public GameObject Goodbye;

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
	public string LineStart;

	[EventID]
	public string LineEnd;

	[EventID]
	public string LineNext;

	[EventID]
	public string GroovyStart;

	[EventID]
	public string Beat;

	[EventID]
	public string Backbeat;

	[EventID]
	public string Starbeat;

	[EventID]
	public string BeatG;

	[EventID]
	public string BackbeatG;

	[EventID]
	public string Offbeat;

	[EventID]
	public string Offbackbeat;

	[EventID]
	public string Offstarbeat;

	[EventID]
	public string EndSong;

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
	public string Perfect_Blue;

	public TextMeshProUGUI ResStyle;

	public TextMeshProUGUI ResACP;

	public TextMeshProUGUI ResFunk;

	public int AllFunk;

	public int AllFunkSmall;

	public static int StyleStatic;

	public static int FunkStatic;

	public static int ACPStatic;

	public float MelSticker;

	public bool MelStickerEquipped;

	public float CoffSticker;

	public bool CoffStickerEquipped;

	private void Start()
	{
		Application.targetFrameRate = 60;
		QualitySettings.vSyncCount = 1;
		voice = GetComponent<AudioSource>();
		anim = base.gameObject.GetComponent<Animator>();
		if (!CanSkipIntro && !DebugMode)
		{
			Object.Destroy(IntroSkipper);
			SkipIntro.Alive = false;
		}
		else
		{
			SkipIntro.Alive = true;
		}
		player = ReInput.players.GetPlayer(playerId);
		cc = GetComponent<CharacterController>();
		Koreographer.Instance.RegisterForEvents(LineStart, On_LineStart);
		Koreographer.Instance.RegisterForEvents(LineNext, On_NextLine);
		Koreographer.Instance.RegisterForEvents(LineEnd, On_LineEnd);
		Koreographer.Instance.RegisterForEvents(GroovyStart, On_GroovyStart);
		Koreographer.Instance.RegisterForEvents(Starbeat, On_Starbeat);
		Koreographer.Instance.RegisterForEvents(Beat, On_Beat);
		Koreographer.Instance.RegisterForEvents(Backbeat, On_Backbeat);
		Koreographer.Instance.RegisterForEvents(BeatG, On_BeatG);
		Koreographer.Instance.RegisterForEvents(BackbeatG, On_BackbeatG);
		Koreographer.Instance.RegisterForEvents(Offbeat, On_Offbeat);
		Koreographer.Instance.RegisterForEvents(Offbackbeat, On_Offbackbeat);
		Koreographer.Instance.RegisterForEvents(Offstarbeat, On_Offstarbeat);
		Koreographer.Instance.RegisterForEvents(EndSong, On_EndSong);
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
		Koreographer.Instance.RegisterForEvents(Perfect_Blue, On_Perfect_Blue);
		VibLvl = PlayerPrefs.GetFloat("RumbleLevel");
		LofiWarning = PlayerPrefs.GetInt("LofiToggle");
		if (LevelSelect.InStory)
		{
			InStory = true;
		}
		songOver = false;
		PinkLine1 = false;
		BlueLine1 = true;
		LoFi = false;
		MidFi = false;
		HiFi = true;
		ACPStatic = 0;
		FunkStatic = 0;
		StyleStatic = 0;
		MelSticker = ES3.Load("MelSticker", 0f);
		if (MelSticker > 0f)
		{
			MelStickerEquipped = true;
		}
		CoffSticker = ES3.Load("CoffSticker", 0f);
		if (CoffSticker > 0f)
		{
			CoffStickerEquipped = true;
		}
		PlayerPrefs.SetString("LastScene", "Rival3");
	}

	private void On_EndSong(KoreographyEvent evt)
	{
		songOver = true;
	}

	private void ACPsliderAdj()
	{
		if (BlueLine)
		{
			ACPSlider.maxValue = SumScoreManager.NoteAmount;
			FunkSlider.maxValue = grooveneeded;
		}
		else if (PinkLine)
		{
			ACPSlider.maxValue = SumScoreManager.PinkNoteAmount;
			FunkSlider.maxValue = grooveneeded;
		}
	}

	private void On_LineStart(KoreographyEvent evt)
	{
		if (!RhyLine_P.PlayerSpecific)
		{
			Dots = Mathf.Abs(RhyLine_P.Blocks * 4 * RhyLine_P.Double);
		}
		else
		{
			Dots = Mathf.Abs(RhyLine_P.Blocks2 * 4 * RhyLine_P.Double);
		}
		RhyCircle.SetTrigger("flip");
		Trail.Play();
		if (!FreeStyle)
		{
			player.SetVibration(0, 1.5f * VibLvl, 0.15f);
			if (BlueLine)
			{
				anim.SetTrigger("getreadyB");
				funkneeded = SumScoreManager.NoteAmount * 6;
				grooveneeded = funkneeded * 5;
				ACPneeded = SumScoreManager.NoteAmount / 3;
			}
			else if (PinkLine)
			{
				anim.SetTrigger("getreadyP");
				funkneeded = SumScoreManager.NoteAmount * 6;
				ACPneeded = SumScoreManager.PinkNoteAmount / 3;
			}
			if (RhyLine_P.Double == 1)
			{
				lowflipper.SetTrigger("flipup");
				highflipper.ResetTrigger("flipup");
			}
			else if (RhyLine_P.Double == 2)
			{
				highflipper.SetTrigger("flipup");
			}
			lowflipper.ResetTrigger("flipdown");
			ACPsliderAdj();
			ACP = 0;
			active = true;
			if (line == 1f || line == 16f)
			{
				base.transform.localPosition = new Vector3(-11.31f, 4.292475f, 12.91997f);
				PlayerL1.SetInteger("Line", 1);
				caption.text = "Making cookies for your love, you stir and mix!";
				Scene1Cam.SetTrigger("Mel");
			}
			if (line == 2f)
			{
				base.transform.localPosition = new Vector3(-11.31f, 4.292475f, 12.91997f);
				Scene1obj.SetActive(value: false);
				Scene2.SetActive(value: true);
				caption.text = "How exactly long has this butter been out to sit?";
			}
			if (line == 3f)
			{
				ACPSlider.maxValue = 4f;
				FunkSlider.maxValue = 50f;
				ACPneeded = 0;
				funkneeded = 25;
				grooveneeded = 55;
				caption.text = "I'm sure he won't!";
				PinkLine = true;
				BlueLine = false;
			}
			if (line == 4f)
			{
				ACPSlider.maxValue = 4f;
				FunkSlider.maxValue = 50f;
				ACPneeded = 0;
				funkneeded = 25;
				grooveneeded = 55;
				PlayerL1.SetInteger("Line", 1);
				caption.text = "Man, I don't know!";
			}
			if (line == 5f)
			{
				base.transform.localPosition = new Vector3(-11.31f, 4.292475f, 12.91997f);
				PlayerL1.SetInteger("Line", 2);
				Scene5Cam.SetTrigger("Mel");
			}
			if (line == 6f)
			{
				Scene5Cam.SetTrigger("Mel");
			}
			if (line == 7f)
			{
				Scene5Cam.SetTrigger("Mel");
			}
			if (line == 8f)
			{
				RhyBox.SetTrigger("pink");
				PinkLine = true;
				BlueLine = false;
			}
			if (line == 10f)
			{
				PlayerL8.SetTrigger("bowl");
			}
			if (line > 7f && line < 12f)
			{
				base.transform.localPosition = new Vector3(-11.31f, 4.292475f, 12.91997f);
				funkneeded = 25;
				grooveneeded = 55;
				ACPSlider.maxValue = 4f;
				FunkSlider.maxValue = 55f;
				ACPneeded = 0;
			}
			if (line == 12f)
			{
				caption.text = "Like a note you just can't sing!";
			}
			if (line == 12f || line == 13f)
			{
				Scene9Cam.SetTrigger("Mel");
			}
			if (line == 13f)
			{
				WeddingCake.SetActive(value: true);
				PlayerL12.SetInteger("Line", 13);
				PlayerL12.SetTrigger("stop");
				caption.text = "Wondering if the bell will ring!";
			}
			if (line == 14f)
			{
				Scene10Cam.SetTrigger("blues");
				Scene10bg.SetTrigger("blues");
				caption.text = "To the major violet blues!";
			}
			if (line == 15f)
			{
				RhyBox.SetTrigger("pink");
				PinkLine = true;
				BlueLine = false;
				funkneeded = 30;
				grooveneeded = 90;
				ACPSlider.maxValue = 3f;
				FunkSlider.maxValue = 45f;
				ACPneeded = 0;
			}
			RhyBox = RhyBox.GetComponent<Animator>();
		}
		if (InStory && StickerManager.CoffStickerEquipped)
		{
			ACP += 2;
		}
	}

	private void On_NextLine(KoreographyEvent evt)
	{
		if (active && !FreeStyle)
		{
			base.transform.localPosition = new Vector3(-10.09615f, 2.982475f, 12.91997f);
			PlayerL1.SetTrigger("stop");
		}
		if (line == 3f)
		{
			PlayerL2obj.SetActive(value: true);
		}
	}

	private void On_LineEnd(KoreographyEvent evt)
	{
		Trail.Stop();
		_ = PinkLine;
		base.transform.localPosition = new Vector3(-11.31f, 2.982475f, 12.91997f);
		line += 1f;
		if (!FreeStyle)
		{
			active = false;
		}
		lowflipper.SetTrigger("flipdown");
		if (line < 3f)
		{
			PlayerL1.SetTrigger("stop");
		}
		if (line > 4f)
		{
			PlayerL5.SetTrigger("stop");
		}
		if (line == 3f)
		{
			RhyBox.SetTrigger("pink");
		}
		if (line == 5f)
		{
			PinkLine = false;
			BlueLine = true;
		}
		if (line == 8f)
		{
			Line8P.SetActive(value: true);
		}
		if (line == 12f)
		{
			PinkLine = false;
			BlueLine = true;
		}
		if (line == 16f)
		{
			PinkLine = false;
			BlueLine = true;
		}
		if (!FreeStyle)
		{
			funk = (int)((float)funk * 0.3f);
			SumScore.Add(ACP + funk + style);
			if (good)
			{
				ScoreAdd.text = (ACP + funk + style).ToString();
				Glow.SetActive(value: false);
				AllFunk += ACP + funk + style;
				AllFunkSmall += style;
				anim.SetTrigger("good");
				voice.PlayOneShot(good1, 1f);
				KillNotes();
				groovycount = 0f;
				player.SetVibration(0, 1.5f * VibLvl, 0.15f);
				if (badcount > 0f)
				{
					badcount -= 1f;
				}
				Smoke.Stop();
				Oven.SetTrigger("good");
			}
			else if (groovy)
			{
				ScoreAdd.text = (ACP + funk + style).ToString();
				AllFunk += ACP + funk;
				AllFunkSmall += style;
				anim.SetTrigger("good");
				Glow.SetActive(value: true);
				voice.PlayOneShot(good1, 1f);
				player.SetVibration(0, 1.5f * VibLvl, 0.15f);
				KillNotes();
				groovycount += 1f;
				badcount = 0f;
				Smoke.Stop();
				Oven.SetTrigger("good");
			}
			else if (MelStickerEquipped && !StickerUsed && InStory)
			{
				ScoreSub.text = 0.ToString();
				Glow.SetActive(value: false);
				anim.SetTrigger("bad");
				mentor.SetTrigger("diss");
				voice.clip = bad1;
				voice.Play();
				player.SetVibration(0, 1.5f * VibLvl, 0.15f);
				KillNotes();
				groovycount = 0f;
				StickerUsed = true;
			}
			else
			{
				ScoreSub.text = 20.ToString();
				Glow.SetActive(value: false);
				AllFunk -= 20;
				anim.SetTrigger("bad");
				mentor.SetTrigger("diss");
				badcount += 1f;
				voice.PlayOneShot(bad1, 1f);
				SumScore.Subtract(20);
				player.SetVibration(0, 1.5f * VibLvl, 0.15f);
				groovycount = 0f;
				KillNotes();
				if (badcount > 1f)
				{
					Smoke.Play();
					Oven.SetTrigger("bad");
				}
			}
			if (badcount == 3f)
			{
				TrainWreck();
			}
		}
		Debug.Log("ButtsNeeded: " + SumScoreManager.ButtsNeeded);
		ResFunk.text = AllFunk.ToString();
		ResStyle.text = AllFunkSmall.ToString();
		ResACP.text = ACP2.ToString();
	}

	private void TrainWreck()
	{
		line = 0f;
		MainCam.SetActive(value: false);
		Scene1obj.SetActive(value: false);
		Scene2.SetActive(value: false);
		AllScenes.SetActive(value: false);
		DANGER.SetActive(value: false);
		caption.text = "";
		active = false;
		GameOver.SetActive(value: true);
		Instrumental.Stop();
		voice.Pause();
		badend.Play();
		twLoop.PlayDelayed(badend.clip.length);
	}

	private void GrooveMode()
	{
	}

	private void On_GroovyStart(KoreographyEvent evt)
	{
		if (freeLoop_obj.activeInHierarchy && GrooveReady)
		{
			GrooveReady = false;
			active2 = true;
		}
		if (freeLoop_obj.activeInHierarchy && !GrooveReady)
		{
			active2 = true;
			base.transform.localPosition = new Vector3(-9.7f, 2.982475f, 12.91997f);
			SumScore.Add(funk);
			if (good)
			{
				anim.SetTrigger("good");
				voice.clip = good1;
				voice.Play();
				KillNotes();
				badcount = 0f;
			}
			else if (groovy)
			{
				anim.SetTrigger("good");
				voice.clip = good1;
				voice.Play();
				KillNotes();
			}
			else
			{
				Glow.SetActive(value: false);
				anim.SetTrigger("bad");
				mentor.SetTrigger("diss");
				badcount += 1f;
				voice.clip = bad1;
				voice.Play();
				SumScore.Subtract(20);
				KillNotes();
			}
		}
	}

	private void Update()
	{
		BlueLine1 = BlueLine;
		PinkLine1 = PinkLine;
		if (active)
		{
			if (player.GetButtonDown("Butt1") && SumScoreManager.Butt1Needed)
			{
				SumScoreManager.Butt1Needed = false;
				SumScoreManager.ButtsNeeded--;
			}
			if (player.GetButtonDown("Butt2") && SumScoreManager.Butt2Needed)
			{
				SumScoreManager.Butt2Needed = false;
				SumScoreManager.ButtsNeeded--;
			}
			if (player.GetButtonDown("Butt3") && SumScoreManager.Butt3Needed)
			{
				SumScoreManager.Butt3Needed = false;
				SumScoreManager.ButtsNeeded--;
			}
			if (player.GetButtonDown("Butt4") && SumScoreManager.Butt4Needed)
			{
				SumScoreManager.Butt4Needed = false;
				SumScoreManager.ButtsNeeded--;
			}
			if (player.GetButtonDown("Up") && SumScoreManager.UpNeeded)
			{
				SumScoreManager.UpNeeded = false;
				SumScoreManager.ButtsNeeded--;
			}
			if (player.GetButtonDown("Down") && SumScoreManager.DownNeeded)
			{
				SumScoreManager.DownNeeded = false;
				SumScoreManager.ButtsNeeded--;
			}
			if (player.GetButtonDown("Left") && SumScoreManager.LeftNeeded)
			{
				SumScoreManager.LeftNeeded = false;
				SumScoreManager.ButtsNeeded--;
			}
			if (player.GetButtonDown("Right") && SumScoreManager.RightNeeded)
			{
				SumScoreManager.RightNeeded = false;
				SumScoreManager.ButtsNeeded--;
			}
			if (player.GetButtonDown("ZL") && SumScoreManager.ZLNeeded)
			{
				SumScoreManager.ZLNeeded = false;
				SumScoreManager.ButtsNeeded--;
			}
			if (player.GetButtonDown("ZR") && SumScoreManager.ZRNeeded)
			{
				SumScoreManager.ZRNeeded = false;
				SumScoreManager.ButtsNeeded--;
			}
		}
		if (active)
		{
			FunkSlider.value = funk;
			ACPSlider.value = ACP;
			if (!good && !groovy)
			{
				funknob.SetTrigger("bad");
			}
			if (good)
			{
				funknob.SetTrigger("good");
			}
			if (groovy)
			{
				funknob.SetTrigger("groovy");
			}
			if (!player.GetButtonDown("Butt1") && !player.GetButtonDown("Butt2") && !player.GetButtonDown("Butt3") && !player.GetButtonDown("Butt4") && !player.GetButtonDown("Up") && !player.GetButtonDown("Down") && !player.GetButtonDown("Left") && !player.GetButtonDown("Right") && !player.GetButtonDown("ZL") && !player.GetButtonDown("ZR"))
			{
				ButtBusy = false;
			}
		}
		if (active2)
		{
			FunkSlider.value = funk;
			if (!good && !groovy)
			{
				funknob.SetTrigger("bad");
			}
			if (good)
			{
				funknob.SetTrigger("groovy");
			}
			if (groovy)
			{
				funknob.SetTrigger("groovy");
			}
			if (!player.GetButtonDown("Butt1") && !player.GetButtonDown("Butt2") && !player.GetButtonDown("Butt3") && !player.GetButtonDown("Butt4") && !player.GetButtonDown("Up") && !player.GetButtonDown("Down") && !player.GetButtonDown("Left") && !player.GetButtonDown("Right") && !player.GetButtonDown("ZL") && !player.GetButtonDown("ZR"))
			{
				ButtBusy = false;
			}
		}
		if (active)
		{
			if (BlueLine)
			{
				if ((funk >= funkneeded && ACP >= ACPneeded && SumScoreManager.ButtsNeeded <= 0) || (funk >= funkneeded && ButtPresses < 20f && SumScoreManager.ButtsNeeded <= 1))
				{
					good = true;
				}
				else if (funk < funkneeded || ACP < ACPneeded || SumScoreManager.ButtsNeeded > 2)
				{
					good = false;
					groovy = false;
				}
				if (funk >= grooveneeded && ACP >= ACPneeded && SumScoreManager.ButtsNeeded <= 0)
				{
					groovy = true;
					good = false;
				}
				else if (funk < grooveneeded || ACP < ACPneeded)
				{
					groovy = false;
				}
			}
			else if (PinkLine)
			{
				if ((funk >= funkneeded && ACP >= ACPneeded) || (funk >= funkneeded && ButtPresses < (float)(SumScoreManager.PinkNoteAmount * 10)))
				{
					good = true;
				}
				else if (funk < funkneeded || ACP < ACPneeded)
				{
					good = false;
					groovy = false;
				}
				if (funk >= grooveneeded && ACP >= ACPneeded)
				{
					groovy = true;
					good = false;
				}
				else if (funk < grooveneeded || ACP < ACPneeded)
				{
					groovy = false;
				}
			}
			if (funk > funkneeded)
			{
				style = funk - funkneeded;
			}
		}
		ButtPresses = Butt1Presses + Butt2Presses + Butt3Presses + Butt4Presses + UpPresses + DownPresses + RightPresses + LeftPresses + ZRPresses + ZLPresses;
		if (badcount == 1f)
		{
			Fidelity.SetTrigger("Mid");
			DANGER.SetActive(value: false);
		}
		else if (badcount == 2f)
		{
			Fidelity.SetTrigger("Lo");
			if (LofiWarning == 1)
			{
				DANGER.SetActive(value: true);
			}
		}
		else if (badcount == 0f)
		{
			Fidelity.SetTrigger("Hi");
			DANGER.SetActive(value: false);
		}
		if (player.GetButtonDown("Pause") && !gamePaused && !songOver)
		{
			gamePaused = true;
			Time.timeScale = 0f;
			Menu.SetActive(value: true);
			Instrumental.Pause();
			voice.Pause();
			voice.mute = true;
		}
		else if (player.GetButtonDown("Pause") && gamePaused && !songOver)
		{
			gamePaused = false;
			Menu.SetActive(value: false);
			Time.timeScale = 1f;
			Instrumental.Play();
			voice.mute = false;
			VibLvl = PlayerPrefs.GetFloat("RumbleLevel");
			LofiWarning = PlayerPrefs.GetInt("LofiToggle");
		}
		if (active && !active2)
		{
			base.transform.Translate(Speed * Time.deltaTime, 0f, 0f);
			GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 1f);
			if (line != 15f)
			{
				PressesAllowed = (float)Dots * 0.3f;
			}
			else
			{
				PressesAllowed = 10f;
			}
		}
		if (active2)
		{
			base.transform.Translate(Speed * Time.deltaTime, 0f, 0f);
			PressesAllowed = 25f;
		}
		if (!gamePaused)
		{
			if (player.GetButtonDown("Butt1") && active && !ButtBusy && line == 1f)
			{
				anim.SetTrigger("speak");
				voice.clip = p1;
				PlayerL1.SetTrigger("A");
				voice.Play();
				Butt1Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				if (Butt1Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt2") && active && !ButtBusy && line == 1f)
			{
				anim.SetTrigger("speak");
				voice.clip = p2;
				voice.Play();
				Butt2Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL1.SetTrigger("B");
				if (Butt2Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt3") && active && !ButtBusy && line == 1f)
			{
				anim.SetTrigger("speak");
				if (Butt3Presses == 0f)
				{
					voice.clip = p7;
					PlayerL1.SetTrigger("Y");
				}
				else if (Butt3Presses == 1f)
				{
					voice.clip = p8;
					PlayerL1.SetTrigger("Y2");
				}
				else
				{
					voice.clip = p9;
					PlayerL1.SetTrigger("Y3");
				}
				voice.Play();
				Butt3Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				if (Butt3Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt4") && active && !ButtBusy && line == 1f)
			{
				if (MentorIcoRiv3.Difficulty2 == "Normal")
				{
					anim.SetTrigger("speak");
					if (Butt4Presses % 2f == 0f)
					{
						voice.clip = p3;
						PlayerL1.SetTrigger("X");
					}
					else
					{
						voice.clip = p4;
						PlayerL1.SetTrigger("X2");
					}
					voice.Play();
					Butt4Presses += 1f;
					ButtBusy = true;
					Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					if (Butt4Presses <= 5f)
					{
						if (onstarbeat)
						{
							funk += 8;
							burstin.Play();
						}
						if (onbeat)
						{
							funk += 5;
						}
						if (onbackbeat)
						{
							funk += 3;
						}
						if (offanybeat)
						{
							funk -= 20;
						}
					}
				}
				else if (MentorIcoRiv3.Difficulty2 == "Easy")
				{
					anim.SetTrigger("speak");
					voice.clip = miss;
					funk -= 20;
					voice.Play();
					Butt4Presses += 1f;
					ButtBusy = true;
					Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					PlayerL1.SetTrigger("Miss");
				}
			}
			if (player.GetButtonDown("Up") && active && !ButtBusy && line == 1f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				UpPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_up, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL1.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Down") && active && !ButtBusy && line == 1f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				DownPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_down, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL1.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Left") && active && !ButtBusy && line == 1f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				LeftPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL1.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Right") && active && !ButtBusy && line == 1f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				RightPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL1.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZL") && active && line == 1f)
			{
				anim.SetTrigger("speak");
				voice.clip = p5;
				voice.Play();
				ZLPresses += 1f;
				Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL1.SetTrigger("L");
				if (ZLPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("ZR") && active && line == 1f)
			{
				if (MentorIcoRiv3.Difficulty2 == "Normal")
				{
					anim.SetTrigger("speak");
					voice.clip = p6;
					voice.Play();
					ZRPresses += 1f;
					Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					PlayerL1.SetTrigger("R");
					if (ZRPresses <= 5f)
					{
						if (onstarbeat)
						{
							funk += 8;
							burstin.Play();
						}
						if (onbeat)
						{
							funk += 5;
						}
						if (onbackbeat)
						{
							funk += 3;
						}
						if (offanybeat)
						{
							funk -= 20;
						}
					}
				}
				else if (MentorIcoRiv3.Difficulty2 == "Easy")
				{
					anim.SetTrigger("speak");
					voice.clip = p22;
					voice.Play();
					ZRPresses += 1f;
					Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					PlayerL1.SetTrigger("R");
					if (ZRPresses <= 5f)
					{
						if (onstarbeat)
						{
							funk += 8;
							burstin.Play();
						}
						if (onbeat)
						{
							funk += 5;
						}
						if (onbackbeat)
						{
							funk += 3;
						}
						if (offanybeat)
						{
							funk -= 20;
						}
					}
				}
			}
			if (player.GetButtonDown("Butt1") && active && !ButtBusy && line == 2f)
			{
				anim.SetTrigger("speak");
				voice.clip = p13;
				voice.Play();
				Butt1Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL2.SetTrigger("A");
				if (Butt1Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt2") && active && !ButtBusy && line == 2f)
			{
				anim.SetTrigger("speak");
				if (Butt2Presses == 0f)
				{
					voice.clip = p16;
					PlayerL2.SetTrigger("B");
				}
				else if (Butt2Presses == 1f)
				{
					voice.clip = p17;
					PlayerL2.SetTrigger("B2");
				}
				else if (Butt2Presses >= 2f)
				{
					voice.clip = p18;
					PlayerL2.SetTrigger("B3");
				}
				voice.Play();
				Butt2Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				if (Butt2Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt3") && active && !ButtBusy && line == 2f)
			{
				if (MentorIcoRiv3.Difficulty2 == "Normal")
				{
					anim.SetTrigger("speak");
					voice.clip = p15;
					voice.Play();
					Butt3Presses += 1f;
					ButtBusy = true;
					Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					PlayerL1.SetTrigger("Y");
					if (Butt3Presses <= 5f)
					{
						if (onstarbeat)
						{
							funk += 8;
							burstin.Play();
						}
						if (onbeat)
						{
							funk += 5;
						}
						if (onbackbeat)
						{
							funk += 3;
						}
						if (offanybeat)
						{
							funk -= 20;
						}
					}
				}
				else if (MentorIcoRiv3.Difficulty2 == "Easy")
				{
					anim.SetTrigger("speak");
					voice.clip = p15;
					voice.Play();
					Butt3Presses += 1f;
					ButtBusy = true;
					Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					PlayerL1.SetTrigger("Miss");
				}
			}
			if (player.GetButtonDown("Butt4") && active && !ButtBusy && line == 2f)
			{
				anim.SetTrigger("speak");
				if (Butt4Presses == 0f)
				{
					voice.clip = p10;
					PlayerL2.SetTrigger("X");
				}
				else if (Butt4Presses >= 1f)
				{
					voice.clip = p11;
					PlayerL2.SetTrigger("X2");
				}
				voice.Play();
				Butt4Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				if (Butt4Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("ZL") && active && line == 2f)
			{
				anim.SetTrigger("speak");
				voice.clip = p14;
				voice.Play();
				ZLPresses += 1f;
				Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL2.SetTrigger("L");
				if (ZLPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("ZR") && active && line == 2f)
			{
				anim.SetTrigger("speak");
				voice.clip = p12;
				voice.Play();
				ZRPresses += 1f;
				Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL2.SetTrigger("R");
				if (ZRPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Up") && active && !ButtBusy && line == 2f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				UpPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_up, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL2.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Down") && active && !ButtBusy && line == 2f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				DownPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_down, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL2.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Left") && active && !ButtBusy && line == 2f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				LeftPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL2.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Right") && active && !ButtBusy && line == 2f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				RightPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL2.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt1") && active && !ButtBusy && line == 3f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt1Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL3.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt2") && active && !ButtBusy && line == 3f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt2Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL3.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt3") && active && !ButtBusy && line == 3f)
			{
				anim.SetTrigger("speak");
				voice.clip = p29;
				voice.Play();
				Butt3Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL3.SetTrigger("Y");
				if (Butt3Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt4") && active && !ButtBusy && line == 3f)
			{
				anim.SetTrigger("speak");
				voice.clip = p28;
				voice.Play();
				Butt4Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL3.SetTrigger("X");
				if (Butt4Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("ZL") && active && line == 3f)
			{
				anim.SetTrigger("speak");
				if (ZLPresses == 0f)
				{
					voice.clip = p26;
					PlayerL3.SetTrigger("L");
				}
				else
				{
					voice.clip = p27;
					PlayerL3.SetTrigger("L2");
				}
				voice.Play();
				ZLPresses += 1f;
				Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				if (ZLPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("ZR") && active && line == 3f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZRPresses += 1f;
				Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL3.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Up") && active && !ButtBusy && line == 3f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				UpPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_up, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL3.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Down") && active && !ButtBusy && line == 3f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				DownPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_down, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL3.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Left") && active && !ButtBusy && line == 3f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				LeftPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL3.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Right") && active && !ButtBusy && line == 3f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				RightPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL3.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt1") && active && !ButtBusy && line == 4f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt1Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL4.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt2") && active && !ButtBusy && line == 4f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt2Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL4.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt3") && active && !ButtBusy && line == 4f)
			{
				anim.SetTrigger("speak");
				voice.clip = p39;
				voice.Play();
				Butt3Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL4.SetTrigger("Yb");
				if (Butt3Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt4") && active && !ButtBusy && line == 4f)
			{
				anim.SetTrigger("speak");
				voice.clip = p40;
				voice.Play();
				Butt4Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL4.SetTrigger("Xb");
				if (Butt4Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("ZL") && active && line == 4f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZLPresses += 1f;
				Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL4.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZR") && active && line == 4f)
			{
				anim.SetTrigger("speak");
				if (ZRPresses == 0f)
				{
					voice.clip = p37;
					PlayerL4.SetTrigger("Rb");
				}
				else
				{
					voice.clip = p38;
					PlayerL4.SetTrigger("R2b");
				}
				voice.Play();
				ZRPresses += 1f;
				Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				if (ZRPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Up") && active && !ButtBusy && line == 4f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				UpPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_up, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL4.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Down") && active && !ButtBusy && line == 4f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				DownPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_down, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL4.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Left") && active && !ButtBusy && line == 4f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				LeftPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL4.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Right") && active && !ButtBusy && line == 4f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				RightPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL4.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt1") && active && !ButtBusy && line == 5f)
			{
				anim.SetTrigger("speak");
				voice.clip = p51;
				voice.Play();
				Butt1Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("A");
				if (Butt1Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt2") && active && !ButtBusy && line == 5f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt2Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt3") && active && !ButtBusy && line == 5f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt3Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt4") && active && !ButtBusy && line == 5f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt4Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZL") && active && line == 5f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZLPresses += 1f;
				Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZR") && active && line == 5f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZRPresses += 1f;
				Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Up") && active && !ButtBusy && line == 5f)
			{
				if (UpPresses % 2f == 0f)
				{
					voice.clip = p47;
				}
				else
				{
					voice.clip = p49;
				}
				voice.Play();
				UpPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_up, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Up");
				if (UpPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Down") && active && !ButtBusy && line == 5f)
			{
				if (DownPresses == 0f)
				{
					voice.clip = p41;
				}
				else if (DownPresses == 1f)
				{
					voice.clip = p46;
				}
				else if (DownPresses == 2f)
				{
					voice.clip = p48;
				}
				else if (DownPresses == 3f)
				{
					voice.clip = p50;
				}
				voice.Play();
				DownPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_down, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Down");
				if (DownPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Left") && active && !ButtBusy && line == 5f)
			{
				if (LeftPresses % 2f == 0f)
				{
					voice.clip = p42;
				}
				else
				{
					voice.clip = p44;
				}
				voice.Play();
				LeftPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Left");
				if (LeftPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Right") && active && !ButtBusy && line == 5f)
			{
				if (RightPresses % 2f == 0f)
				{
					voice.clip = p43;
				}
				else
				{
					voice.clip = p45;
				}
				voice.Play();
				RightPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Right");
				if (RightPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt1") && active && !ButtBusy && line == 6f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt1Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt2") && active && !ButtBusy && line == 6f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt2Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt3") && active && !ButtBusy && line == 6f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt3Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt4") && active && !ButtBusy && line == 6f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt4Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZL") && active && line == 6f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZLPresses += 1f;
				Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZR") && active && line == 6f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZRPresses += 1f;
				Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Up") && active && !ButtBusy && line == 6f)
			{
				voice.clip = p54;
				voice.Play();
				UpPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_up, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Up");
				if (UpPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Down") && active && !ButtBusy && line == 6f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				DownPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_down, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Left") && active && !ButtBusy && line == 6f)
			{
				voice.clip = p52;
				voice.Play();
				LeftPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Left");
				if (LeftPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Right") && active && !ButtBusy && line == 6f)
			{
				voice.clip = p53;
				voice.Play();
				RightPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Right");
				if (RightPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt1") && active && !ButtBusy && line == 7f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt1Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt2") && active && !ButtBusy && line == 7f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt2Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt3") && active && !ButtBusy && line == 7f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt3Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt4") && active && !ButtBusy && line == 7f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt4Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZL") && active && line == 7f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZLPresses += 1f;
				Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZR") && active && line == 7f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZRPresses += 1f;
				Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Up") && active && !ButtBusy && line == 7f)
			{
				voice.clip = p62;
				voice.Play();
				UpPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_up, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Up");
				if (UpPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Down") && active && !ButtBusy && line == 7f)
			{
				if (DownPresses % 2f == 0f)
				{
					voice.clip = p61;
				}
				else
				{
					voice.clip = p63;
				}
				voice.Play();
				DownPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_down, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Down");
				if (DownPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Left") && active && !ButtBusy && line == 7f)
			{
				if (LeftPresses == 0f)
				{
					voice.clip = p58;
				}
				else
				{
					voice.clip = p60;
				}
				voice.Play();
				LeftPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Left");
				if (LeftPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Right") && active && !ButtBusy && line == 7f)
			{
				voice.clip = p59;
				voice.Play();
				RightPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL5.SetTrigger("Right");
				if (RightPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt1") && active && !ButtBusy && line == 8f)
			{
				anim.SetTrigger("speak");
				voice.clip = p66;
				voice.Play();
				Butt1Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("A");
				if (Butt1Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt2") && active && !ButtBusy && line == 8f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt2Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt3") && active && !ButtBusy && line == 8f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt3Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt4") && active && !ButtBusy && line == 8f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt4Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZL") && active && line == 8f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZLPresses += 1f;
				Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZR") && active && line == 8f)
			{
				anim.SetTrigger("speak");
				voice.clip = p65;
				voice.Play();
				ZRPresses += 1f;
				Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("R");
				if (ZRPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Up") && active && !ButtBusy && line == 8f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				UpPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_up, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Down") && active && !ButtBusy && line == 8f)
			{
				voice.clip = miss;
				funk -= 20;
				DownPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_down, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Left") && active && !ButtBusy && line == 8f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				LeftPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Right") && active && !ButtBusy && line == 8f)
			{
				voice.clip = miss;
				funk -= 20;
				RightPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt1") && active && !ButtBusy && line == 9f)
			{
				anim.SetTrigger("speak");
				voice.clip = p93;
				voice.Play();
				Butt1Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("A");
				if (Butt1Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt2") && active && !ButtBusy && line == 9f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt2Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt3") && active && !ButtBusy && line == 9f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt3Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt4") && active && !ButtBusy && line == 9f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt4Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZL") && active && line == 9f)
			{
				anim.SetTrigger("speak");
				voice.clip = p67;
				voice.Play();
				ZLPresses += 1f;
				Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("L");
				if (ZLPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("ZR") && active && line == 9f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZRPresses += 1f;
				Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Up") && active && !ButtBusy && line == 9f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				UpPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_up, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Down") && active && !ButtBusy && line == 9f)
			{
				voice.clip = miss;
				funk -= 20;
				DownPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_down, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Left") && active && !ButtBusy && line == 9f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				LeftPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Right") && active && !ButtBusy && line == 9f)
			{
				voice.clip = miss;
				funk -= 20;
				RightPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt1") && active && !ButtBusy && line == 10f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				Butt1Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt2") && active && !ButtBusy && line == 10f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt2Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt3") && active && !ButtBusy && line == 10f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt3Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt4") && active && !ButtBusy && line == 10f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt4Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZL") && active && line == 10f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZLPresses += 1f;
				Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZR") && active && line == 10f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZRPresses += 1f;
				Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Up") && active && !ButtBusy && line == 10f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				UpPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_up, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Down") && active && !ButtBusy && line == 10f)
			{
				voice.clip = miss;
				funk -= 20;
				DownPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_down, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Left") && active && !ButtBusy && line == 10f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				LeftPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Right") && active && !ButtBusy && line == 10f)
			{
				voice.clip = p63;
				voice.Play();
				RightPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Right");
				if (RightPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt1") && active && !ButtBusy && line == 11f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				Butt1Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt2") && active && !ButtBusy && line == 11f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt2Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt3") && active && !ButtBusy && line == 11f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt3Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt4") && active && !ButtBusy && line == 11f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt4Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZL") && active && line == 11f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZLPresses += 1f;
				Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZR") && active && line == 11f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZRPresses += 1f;
				Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Up") && active && !ButtBusy && line == 11f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				UpPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_up, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Down") && active && !ButtBusy && line == 11f)
			{
				voice.clip = miss;
				funk -= 20;
				DownPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_down, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Left") && active && !ButtBusy && line == 11f)
			{
				voice.clip = p64;
				voice.Play();
				LeftPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Left");
				if (LeftPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Right") && active && !ButtBusy && line == 11f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				RightPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL8.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt1") && active && !ButtBusy && line == 12f)
			{
				anim.SetTrigger("speak");
				if (Butt1Presses == 0f)
				{
					voice.clip = p76;
					PlayerL12.SetTrigger("A");
				}
				else
				{
					voice.clip = p77;
					PlayerL12.SetTrigger("A2");
				}
				voice.Play();
				Butt1Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				if (Butt1Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt2") && active && !ButtBusy && line == 12f)
			{
				anim.SetTrigger("speak");
				voice.clip = p78;
				voice.Play();
				Butt2Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL12.SetTrigger("B");
				if (Butt2Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt3") && active && !ButtBusy && line == 12f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt3Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL12.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt4") && active && !ButtBusy && line == 12f)
			{
				if (MentorIcoRiv3.Difficulty2 == "Normal")
				{
					anim.SetTrigger("speak");
					if (Butt4Presses == 0f)
					{
						voice.clip = p73;
						PlayerL12.SetTrigger("X");
					}
					else if (Butt4Presses == 1f)
					{
						voice.clip = p74;
						PlayerL12.SetTrigger("X2");
					}
					else if (Butt4Presses >= 2f)
					{
						voice.clip = p75;
						PlayerL12.SetTrigger("X3");
					}
					voice.Play();
					Butt4Presses += 1f;
					ButtBusy = true;
					Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					if (Butt4Presses <= 5f)
					{
						if (onstarbeat)
						{
							funk += 8;
							burstin.Play();
						}
						if (onbeat)
						{
							funk += 5;
						}
						if (onbackbeat)
						{
							funk += 3;
						}
						if (offanybeat)
						{
							funk -= 20;
						}
					}
				}
				else if (MentorIcoRiv3.Difficulty2 == "Easy")
				{
					anim.SetTrigger("speak");
					if (Butt4Presses == 0f)
					{
						voice.clip = p74;
						PlayerL12.SetTrigger("X");
					}
					else if (Butt4Presses == 1f)
					{
						voice.clip = p75;
						PlayerL12.SetTrigger("X2");
					}
					voice.Play();
					Butt4Presses += 1f;
					ButtBusy = true;
					Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					if (Butt4Presses <= 5f)
					{
						if (onstarbeat)
						{
							funk += 8;
							burstin.Play();
						}
						if (onbeat)
						{
							funk += 5;
						}
						if (onbackbeat)
						{
							funk += 3;
						}
						if (offanybeat)
						{
							funk -= 20;
						}
					}
				}
			}
			if (player.GetButtonDown("ZL") && active && line == 12f)
			{
				anim.SetTrigger("speak");
				voice.clip = p72;
				voice.Play();
				ZLPresses += 1f;
				Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL12.SetTrigger("L");
				if (ZLPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("ZR") && active && line == 12f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZRPresses += 1f;
				Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL12.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Up") && active && !ButtBusy && line == 12f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				UpPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_up, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL12.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Down") && active && !ButtBusy && line == 12f)
			{
				voice.clip = miss;
				funk -= 20;
				DownPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_down, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL12.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Left") && active && !ButtBusy && line == 12f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				LeftPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL12.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Right") && active && !ButtBusy && line == 12f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				RightPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL12.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt1") && active && !ButtBusy && line == 13f)
			{
				if (MentorIcoRiv3.Difficulty2 == "Normal")
				{
					anim.SetTrigger("speak");
					if (Butt1Presses == 0f)
					{
						voice.clip = p83;
						PlayerL12.SetTrigger("A");
					}
					else
					{
						voice.clip = p84;
						PlayerL12.SetTrigger("A2");
					}
					voice.Play();
					Butt1Presses += 1f;
					ButtBusy = true;
					Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					if (Butt1Presses <= 5f)
					{
						if (onstarbeat)
						{
							funk += 8;
							burstin.Play();
						}
						if (onbeat)
						{
							funk += 5;
						}
						if (onbackbeat)
						{
							funk += 3;
						}
						if (offanybeat)
						{
							funk -= 20;
						}
					}
				}
				else if (MentorIcoRiv3.Difficulty2 == "Easy")
				{
					anim.SetTrigger("speak");
					voice.clip = p84;
					PlayerL12.SetTrigger("A");
					voice.Play();
					Butt1Presses += 1f;
					ButtBusy = true;
					Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					if (Butt1Presses <= 5f)
					{
						if (onstarbeat)
						{
							funk += 8;
							burstin.Play();
						}
						if (onbeat)
						{
							funk += 5;
						}
						if (onbackbeat)
						{
							funk += 3;
						}
						if (offanybeat)
						{
							funk -= 20;
						}
					}
				}
			}
			if (player.GetButtonDown("Butt2") && active && !ButtBusy && line == 13f)
			{
				if (MentorIcoRiv3.Difficulty2 == "Normal")
				{
					anim.SetTrigger("speak");
					if (Butt2Presses % 2f == 0f)
					{
						voice.clip = p81;
						PlayerL12.SetTrigger("B");
					}
					else
					{
						voice.clip = p82;
						PlayerL12.SetTrigger("B2");
					}
					voice.Play();
					Butt2Presses += 1f;
					ButtBusy = true;
					Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					if (Butt2Presses <= 5f)
					{
						if (onstarbeat)
						{
							funk += 8;
							burstin.Play();
						}
						if (onbeat)
						{
							funk += 5;
						}
						if (onbackbeat)
						{
							funk += 3;
						}
						if (offanybeat)
						{
							funk -= 20;
						}
					}
				}
				else if (MentorIcoRiv3.Difficulty2 == "Easy")
				{
					anim.SetTrigger("speak");
					voice.clip = p82;
					PlayerL12.SetTrigger("B");
					voice.Play();
					Butt2Presses += 1f;
					ButtBusy = true;
					Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					if (Butt2Presses <= 5f)
					{
						if (onstarbeat)
						{
							funk += 8;
							burstin.Play();
						}
						if (onbeat)
						{
							funk += 5;
						}
						if (onbackbeat)
						{
							funk += 3;
						}
						if (offanybeat)
						{
							funk -= 20;
						}
					}
				}
			}
			if (player.GetButtonDown("Butt3") && active && !ButtBusy && line == 13f)
			{
				anim.SetTrigger("speak");
				voice.clip = p79;
				voice.Play();
				Butt3Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL12.SetTrigger("Y");
				if (Butt3Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt4") && active && !ButtBusy && line == 13f)
			{
				anim.SetTrigger("speak");
				voice.clip = p80;
				voice.Play();
				Butt4Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL12.SetTrigger("X");
				if (Butt4Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("ZL") && active && line == 13f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZLPresses += 1f;
				Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL12.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZR") && active && line == 13f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZRPresses += 1f;
				Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL12.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Up") && active && !ButtBusy && line == 13f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				UpPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_up, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL12.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Down") && active && !ButtBusy && line == 13f)
			{
				voice.clip = miss;
				funk -= 20;
				DownPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_down, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL12.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Left") && active && !ButtBusy && line == 13f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				LeftPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL12.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Right") && active && !ButtBusy && line == 13f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				RightPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL12.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt1") && active && !ButtBusy && line == 14f)
			{
				anim.SetTrigger("speak");
				voice.clip = p88;
				voice.Play();
				Butt1Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL14.SetTrigger("A");
				if (Butt1Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt2") && active && !ButtBusy && line == 14f)
			{
				anim.SetTrigger("speak");
				voice.clip = p89;
				voice.Play();
				Butt2Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL14.SetTrigger("B");
				if (Butt2Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt3") && active && !ButtBusy && line == 14f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt3Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL14.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt4") && active && !ButtBusy && line == 14f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt4Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL14.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZL") && active && line == 14f)
			{
				anim.SetTrigger("speak");
				voice.clip = p87;
				voice.Play();
				ZLPresses += 1f;
				Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL14.SetTrigger("L");
				if (ZLPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("ZR") && active && line == 14f)
			{
				if (MentorIcoRiv3.Difficulty2 == "Normal")
				{
					anim.SetTrigger("speak");
					if (ZRPresses % 2f == 0f)
					{
						voice.clip = p85;
						PlayerL14.SetTrigger("R");
					}
					else
					{
						voice.clip = p86;
						PlayerL14.SetTrigger("R2");
					}
					voice.Play();
					ZRPresses += 1f;
					Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					if (ZRPresses <= 5f)
					{
						if (onstarbeat)
						{
							funk += 8;
							burstin.Play();
						}
						if (onbeat)
						{
							funk += 5;
						}
						if (onbackbeat)
						{
							funk += 3;
						}
						if (offanybeat)
						{
							funk -= 20;
						}
					}
				}
				else if (MentorIcoRiv3.Difficulty2 == "Easy")
				{
					anim.SetTrigger("speak");
					voice.clip = p85;
					voice.Play();
					ZRPresses += 1f;
					Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					if (ZRPresses <= 5f)
					{
						if (onstarbeat)
						{
							funk += 8;
							burstin.Play();
						}
						if (onbeat)
						{
							funk += 5;
						}
						if (onbackbeat)
						{
							funk += 3;
						}
						if (offanybeat)
						{
							funk -= 20;
						}
					}
				}
			}
			if (player.GetButtonDown("Up") && active && !ButtBusy && line == 14f)
			{
				voice.clip = miss;
				voice.Play();
				UpPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_up, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL14.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Down") && active && !ButtBusy && line == 14f)
			{
				voice.clip = miss;
				funk -= 20;
				DownPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_down, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL14.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Left") && active && !ButtBusy && line == 14f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				LeftPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL14.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Right") && active && !ButtBusy && line == 14f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				RightPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL14.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt1") && active && !ButtBusy && line == 15f && LineReady && LineReady)
			{
				anim.SetTrigger("speak");
				voice.clip = p91;
				voice.Play();
				Butt1Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL15.SetTrigger("A");
				if (Butt1Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt2") && active && !ButtBusy && line == 15f && LineReady)
			{
				anim.SetTrigger("speak");
				voice.clip = p90;
				voice.Play();
				Butt2Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL15.SetTrigger("B");
				if (Butt2Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt3") && active && !ButtBusy && line == 15f && LineReady)
			{
				anim.SetTrigger("speak");
				voice.clip = p92;
				voice.Play();
				Butt3Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL15.SetTrigger("Y");
				if (Butt3Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt4") && active && !ButtBusy && line == 15f && LineReady)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				Butt4Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL15.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZL") && active && line == 15f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZLPresses += 1f;
				Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL15.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZR") && active && line == 15f)
			{
				anim.SetTrigger("speak");
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				ZRPresses += 1f;
				Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL15.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Up") && active && !ButtBusy && line == 15f && LineReady)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				UpPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_up, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL15.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Down") && active && !ButtBusy && line == 15f && LineReady)
			{
				voice.clip = miss;
				funk -= 20;
				DownPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_down, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL15.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Left") && active && !ButtBusy && line == 15f && LineReady)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				LeftPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL15.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Right") && active && !ButtBusy && line == 15f && LineReady)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				RightPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL15.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Butt1") && active && !ButtBusy && line == 16f)
			{
				anim.SetTrigger("speak");
				voice.clip = p1;
				PlayerL1.SetTrigger("A");
				voice.Play();
				Butt1Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_A, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				if (Butt1Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt2") && active && !ButtBusy && line == 16f)
			{
				anim.SetTrigger("speak");
				voice.clip = p2;
				voice.Play();
				Butt2Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_B, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL1.SetTrigger("B");
				if (Butt2Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt3") && active && !ButtBusy && line == 16f)
			{
				anim.SetTrigger("speak");
				if (Butt3Presses == 0f)
				{
					voice.clip = p7;
					PlayerL1.SetTrigger("Y");
				}
				else if (Butt3Presses == 1f)
				{
					voice.clip = p8;
					PlayerL1.SetTrigger("Y2");
				}
				else
				{
					voice.clip = p9;
					PlayerL1.SetTrigger("Y3");
				}
				voice.Play();
				Butt3Presses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_Y, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				if (Butt3Presses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("Butt4") && active && !ButtBusy && line == 16f)
			{
				if (MentorIcoRiv3.Difficulty2 == "Normal")
				{
					anim.SetTrigger("speak");
					if (Butt4Presses % 2f == 0f)
					{
						voice.clip = p3;
						PlayerL1.SetTrigger("X");
					}
					else
					{
						voice.clip = p4;
						PlayerL1.SetTrigger("X2");
					}
					voice.Play();
					Butt4Presses += 1f;
					ButtBusy = true;
					Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					if (Butt4Presses <= 5f)
					{
						if (onstarbeat)
						{
							funk += 8;
							burstin.Play();
						}
						if (onbeat)
						{
							funk += 5;
						}
						if (onbackbeat)
						{
							funk += 3;
						}
						if (offanybeat)
						{
							funk -= 20;
						}
					}
				}
				else if (MentorIcoRiv3.Difficulty2 == "Easy")
				{
					anim.SetTrigger("speak");
					voice.clip = miss;
					funk -= 20;
					voice.Play();
					Butt4Presses += 1f;
					ButtBusy = true;
					Object.Instantiate(note_X, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					PlayerL1.SetTrigger("Miss");
				}
			}
			if (player.GetButtonDown("Up") && active && !ButtBusy && line == 16f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				UpPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_up, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL1.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Down") && active && !ButtBusy && line == 16f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				DownPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_down, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL1.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Left") && active && !ButtBusy && line == 16f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				LeftPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_left, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL1.SetTrigger("Miss");
			}
			if (player.GetButtonDown("Right") && active && !ButtBusy && line == 16f)
			{
				voice.clip = miss;
				funk -= 20;
				voice.Play();
				RightPresses += 1f;
				ButtBusy = true;
				Object.Instantiate(note_right, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL1.SetTrigger("Miss");
			}
			if (player.GetButtonDown("ZL") && active && line == 16f)
			{
				anim.SetTrigger("speak");
				voice.clip = p5;
				voice.Play();
				ZLPresses += 1f;
				Object.Instantiate(note_ZL, base.transform.position, base.transform.rotation).tag = "NoteClone2";
				PlayerL1.SetTrigger("L");
				if (ZLPresses <= 5f)
				{
					if (onstarbeat)
					{
						funk += 8;
						burstin.Play();
					}
					if (onbeat)
					{
						funk += 5;
					}
					if (onbackbeat)
					{
						funk += 3;
					}
					if (offanybeat)
					{
						funk -= 20;
					}
				}
			}
			if (player.GetButtonDown("ZR") && active && line == 16f)
			{
				if (MentorIcoRiv3.Difficulty2 == "Normal")
				{
					anim.SetTrigger("speak");
					voice.clip = p6;
					voice.Play();
					ZRPresses += 1f;
					Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					PlayerL1.SetTrigger("R");
					if (ZRPresses <= 5f)
					{
						if (onstarbeat)
						{
							funk += 8;
							burstin.Play();
						}
						if (onbeat)
						{
							funk += 5;
						}
						if (onbackbeat)
						{
							funk += 3;
						}
						if (offanybeat)
						{
							funk -= 20;
						}
					}
				}
				else if (MentorIcoRiv3.Difficulty2 == "Easy")
				{
					anim.SetTrigger("speak");
					voice.clip = p22;
					voice.Play();
					ZRPresses += 1f;
					Object.Instantiate(note_ZR, base.transform.position, base.transform.rotation).tag = "NoteClone2";
					PlayerL1.SetTrigger("R");
					if (ZRPresses <= 5f)
					{
						if (onstarbeat)
						{
							funk += 8;
							burstin.Play();
						}
						if (onbeat)
						{
							funk += 5;
						}
						if (onbackbeat)
						{
							funk += 3;
						}
						if (offanybeat)
						{
							funk -= 20;
						}
					}
				}
			}
		}
		if (offbeat && offbackbeat && offstarbeat)
		{
			offanybeat = true;
			onanybeat = false;
		}
		else
		{
			offanybeat = false;
			onanybeat = true;
		}
		FunkStatic = AllFunk;
		StyleStatic = AllFunkSmall;
		ACPStatic = ACP2;
		if (!FreeStyle)
		{
			if (badcount == 0f)
			{
				HiFi = true;
				MidFi = false;
				LoFi = false;
			}
			else if (badcount == 1f)
			{
				HiFi = false;
				MidFi = true;
				LoFi = false;
			}
			else if (badcount > 1f)
			{
				HiFi = false;
				MidFi = false;
				LoFi = true;
			}
		}
		if (!LineReady)
		{
			GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 0.5f);
		}
		else
		{
			GetComponent<SpriteRenderer>().material.color = new Color(1f, 1f, 1f, 1f);
		}
		if (player.GetButtonDown("Left") || player.GetButtonDown("Right") || player.GetButtonDown("Up") || player.GetButtonDown("Down") || !active)
		{
			reverb.enabled = false;
			voice.volume = 0.65f;
		}
		else
		{
			reverb.enabled = false;
		}
		if (active && !gamePaused)
		{
			if ((player.GetButtonDown("Butt1") || player.GetButtonDown("Butt2") || player.GetButtonDown("Butt3") || player.GetButtonDown("Butt4") || player.GetButtonDown("ZR") || player.GetButtonDown("ZL") || player.GetButtonDown("Up") || player.GetButtonDown("Down") || player.GetButtonDown("Left") || player.GetButtonDown("Right")) && ButtPresses > PressesAllowed && !FreeStyle)
			{
				funk -= 20;
			}
			if (!CheckingIPS && (player.GetButtonDown("Butt1") || player.GetButtonDown("Butt2") || player.GetButtonDown("Butt3") || player.GetButtonDown("Butt4") || player.GetButtonDown("ZR") || player.GetButtonDown("ZL") || player.GetButtonDown("Up") || player.GetButtonDown("Down") || player.GetButtonDown("Left") || player.GetButtonDown("Right")))
			{
				StartCoroutine(InputsPerSec());
				IPS = 0f;
			}
			if (CheckingIPS)
			{
				IPS = ButtPresses;
			}
		}
	}

	private IEnumerator InputsPerSec()
	{
		if (CheckingIPS)
		{
			yield break;
		}
		CheckingIPS = true;
		if (RhyLine_P.Double == 1)
		{
			yield return new WaitForSeconds(0.5f);
			IPS = ButtPresses;
			CheckingIPS = false;
			if (DebugMode)
			{
				Debug.Log("IPS Checked" + IPS);
			}
			if (IPS > IPSLimit)
			{
				funk = 0;
			}
		}
		else
		{
			yield return new WaitForSeconds(1f);
			IPS = ButtPresses;
			CheckingIPS = false;
			if (DebugMode)
			{
				Debug.Log("IPS Checked" + IPS);
			}
			if (IPS > IPSLimit)
			{
				funk = 0;
			}
		}
	}

	public void AddPoints(int points)
	{
		SumScore.Add(points);
	}

	private void KillNotes()
	{
		GameObject[] array = GameObject.FindGameObjectsWithTag("NoteClone2");
		for (int i = 0; i < array.Length; i++)
		{
			Object.Destroy(array[i]);
		}
		Butt2Presses -= Butt2Presses;
		Butt1Presses -= Butt1Presses;
		Butt3Presses -= Butt3Presses;
		Butt4Presses -= Butt4Presses;
		LeftPresses -= LeftPresses;
		RightPresses -= RightPresses;
		DownPresses -= DownPresses;
		UpPresses -= UpPresses;
		ZLPresses -= ZLPresses;
		ZRPresses -= ZRPresses;
		funk -= funk;
		ACP2 += ACP;
		style = 0;
	}

	private void LoseGroove()
	{
		Instrumental.mute = false;
		FreeMode.SetActive(value: false);
		FreeStyle = false;
		MentorVoice.SetActive(value: true);
		active2 = false;
	}

	public void Retry()
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex, LoadSceneMode.Single);
		CanSkipIntro = true;
	}

	public void Quit()
	{
		gamePaused = false;
		Time.timeScale = 1f;
		StartCoroutine(QuitGame());
	}

	private IEnumerator QuitGame()
	{
		yield return new WaitForSecondsRealtime(2f);
		SceneManager.LoadSceneAsync("Title");
	}

	public void Resume()
	{
		gamePaused = false;
		Menu.SetActive(value: false);
		Time.timeScale = 1f;
		Instrumental.Play();
		voice.Play();
		voice.mute = false;
		VibLvl = PlayerPrefs.GetFloat("RumbleLevel");
		LofiWarning = PlayerPrefs.GetInt("LofiToggle");
	}

	private void On_Starbeat(KoreographyEvent evt)
	{
		onstarbeat = true;
		offstarbeat = false;
		offanybeat = false;
		if (badcount == 2f && LofiWarning == 1)
		{
			DangerBeat.Play();
			player.SetVibration(0, 0.25f * VibLvl, 0.2f);
		}
	}

	private void On_Beat(KoreographyEvent evt)
	{
		onbeat = true;
		offbeat = false;
		offanybeat = false;
	}

	private void On_Backbeat(KoreographyEvent evt)
	{
		onbackbeat = true;
		offbackbeat = false;
		offanybeat = false;
	}

	private void On_BeatG(KoreographyEvent evt)
	{
		onbeat = true;
		offbeat = false;
		offanybeat = false;
	}

	private void On_BackbeatG(KoreographyEvent evt)
	{
		onbackbeat = true;
		offbackbeat = false;
		offanybeat = false;
	}

	private void On_Offbeat(KoreographyEvent evt)
	{
		onbeat = false;
		offbeat = true;
	}

	private void On_Offbackbeat(KoreographyEvent evt)
	{
		onbackbeat = false;
		offbackbeat = true;
	}

	private void On_Offstarbeat(KoreographyEvent evt)
	{
		onstarbeat = false;
		offstarbeat = true;
	}

	private void On_Perfect_Blue(KoreographyEvent evt)
	{
		if (active && voice.clip != miss)
		{
			if ((player.GetButtonDown("Butt1") && Butt1Presses < 5f) || (player.GetButtonDown("Butt2") && Butt2Presses < 5f) || (player.GetButtonDown("Butt3") && Butt3Presses < 5f) || (player.GetButtonDown("Butt4") && Butt4Presses < 5f))
			{
				ACP++;
				Object.Instantiate(sparkleB, base.transform.position, base.transform.rotation);
			}
			if (player.GetButtonDown("Up") && UpPresses < 5f)
			{
				ACP++;
				Object.Instantiate(sparkleB, base.transform.position, base.transform.rotation);
			}
			if (player.GetButtonDown("Down") && DownPresses < 5f)
			{
				ACP++;
				Object.Instantiate(sparkleB, base.transform.position, base.transform.rotation);
			}
			if (player.GetButtonDown("Left") && LeftPresses < 5f)
			{
				ACP++;
				Object.Instantiate(sparkleB, base.transform.position, base.transform.rotation);
			}
			if (player.GetButtonDown("Right") && RightPresses < 5f)
			{
				ACP++;
				Object.Instantiate(sparkleB, base.transform.position, base.transform.rotation);
			}
			if (player.GetButtonDown("ZL") && ZLPresses < 5f)
			{
				ACP++;
				Object.Instantiate(sparkleB, base.transform.position, base.transform.rotation);
			}
			if (player.GetButtonDown("ZR") && ZRPresses < 5f)
			{
				ACP++;
				Object.Instantiate(sparkleB, base.transform.position, base.transform.rotation);
			}
		}
	}

	private void On_Up(KoreographyEvent evt)
	{
		if (active && player.GetButtonDown("Up"))
		{
			funk += 3;
			ACP++;
		}
	}

	private void On_Down(KoreographyEvent evt)
	{
		if (active && player.GetButtonDown("Down"))
		{
			funk += 3;
			ACP++;
		}
	}

	private void On_Left(KoreographyEvent evt)
	{
		if (active && player.GetButtonDown("Left"))
		{
			funk += 3;
			ACP++;
		}
	}

	private void On_Right(KoreographyEvent evt)
	{
		if (active && player.GetButtonDown("Right"))
		{
			funk += 3;
			ACP++;
		}
	}

	private void On_Abutt(KoreographyEvent evt)
	{
		if (active && player.GetButtonDown("Butt1"))
		{
			funk += 3;
			ACP++;
		}
	}

	private void On_Bbutt(KoreographyEvent evt)
	{
		if (active && player.GetButtonDown("Butt2"))
		{
			funk += 3;
			ACP++;
		}
	}

	private void On_Xbutt(KoreographyEvent evt)
	{
		if (active && player.GetButtonDown("Butt4"))
		{
			funk += 3;
			ACP++;
		}
	}

	private void On_Ybutt(KoreographyEvent evt)
	{
		if (active && player.GetButtonDown("Butt3"))
		{
			funk += 3;
			ACP++;
		}
	}

	private void On_Lbutt(KoreographyEvent evt)
	{
		if (active && player.GetButtonDown("ZL"))
		{
			funk += 3;
			ACP++;
		}
	}

	private void On_Rbutt(KoreographyEvent evt)
	{
		if (active && player.GetButtonDown("ZR"))
		{
			funk += 3;
			ACP++;
		}
	}
}
