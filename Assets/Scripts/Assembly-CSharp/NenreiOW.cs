using System.Collections;
using Rewired;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NenreiOW : MonoBehaviour
{
	public int playerId;

	private Player player;

	private CharacterController cc;

	public static bool Debug;

	public bool DebugMode;

	private Rigidbody2D rb2d;

	private Vector2 movement;

	public float speed;

	public float speedOG;

	public float Runspeed;

	public float RunspeedOG;

	public float acceleration;

	public float maxSpeed;

	private float moveLimiter = 0.7f;

	public GameObject notifBox;

	public Animator self;

	public bool moving;

	public bool strafe;

	public static bool hasKeyboard;

	public static bool canMove;

	public AudioSource music;

	public bool SCam;

	public bool FCam;

	public Camera stillcam;

	public Camera followcam;

	public GameObject Stopper;

	public static bool InMenu;

	public bool Cutscene;

	public GameObject StickerBook;

	public GameObject Self;

	public bool NoAnims;

	public bool NotifTime;

	public bool gamePaused;

	public GameObject PauseMenu;

	public bool pressUp;

	public bool pressDown;

	public bool pressLeft;

	public bool pressRight;

	public int HorAxis;

	public int VerAxis;

	public int hasKB;

	private void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		player = ReInput.players.GetPlayer(playerId);
		cc = GetComponent<CharacterController>();
		EmergencyCanMove();
		if (DebugMode)
		{
			Debug = true;
		}
		else
		{
			Debug = false;
		}
		hasKB = ES3.Load("Keyboard", 0);
		if (hasKB == 1)
		{
			hasKeyboard = true;
		}
	}

	private void StillCam()
	{
		stillcam.enabled = true;
		followcam.enabled = false;
		SCam = true;
		FCam = false;
	}

	private void FollowCam()
	{
		stillcam.enabled = false;
		followcam.enabled = true;
		FCam = true;
		SCam = false;
	}

	public void EmergencyCanMove()
	{
		canMove = true;
		ObjectText.amorgos = false;
		InMenu = false;
	}

	public void Resume()
	{
		PauseMenu.SetActive(value: false);
		gamePaused = false;
		Time.timeScale = 1f;
		EmergencyCanMove();
	}

	public void ResumeToStickerBook()
	{
		PauseMenu.SetActive(value: false);
		gamePaused = false;
		Time.timeScale = 1f;
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

	public void OpenStickerBook()
	{
		StickerBook.SetActive(value: true);
		InMenu = true;
		canMove = false;
		ObjectText.amorgos = true;
	}

	private void ItemGet()
	{
		if (!NotifTime)
		{
			canMove = false;
			Stopper.SetActive(value: true);
			StartCoroutine(ExampleCoroutine());
		}
		IEnumerator ExampleCoroutine()
		{
			yield return new WaitForSeconds(0.5f);
			NotifTime = true;
		}
	}

	private void Update()
	{
		if (player.GetButtonDown("Butt3") && !InMenu && canMove)
		{
			OpenStickerBook();
		}
		if (NoAnims)
		{
			self.SetTrigger("Stop");
		}
		self.SetBool("cutscene", value: false);
		if (player.GetButtonDown("Pause") && !InMenu && canMove && !gamePaused)
		{
			PauseMenu.SetActive(value: true);
			gamePaused = true;
			Time.timeScale = 0f;
			InMenu = true;
			canMove = false;
			ObjectText.amorgos = true;
		}
		else if (player.GetButtonDown("Pause") && gamePaused)
		{
			Resume();
		}
		if (canMove)
		{
			movement.x = player.GetAxisRaw("Horizontal");
			movement.y = player.GetAxisRaw("Vertical");
			movement.Normalize();
			if (!strafe)
			{
				self.SetFloat("Horizontal", movement.x);
				self.SetFloat("Vertical", movement.y);
			}
			else
			{
				self.SetFloat("Horizontal", movement.x * -1f);
				self.SetFloat("Vertical", movement.y * -1f);
			}
			self.SetFloat("Speed", movement.sqrMagnitude);
			if (player.GetButton("Butt4") && hasKeyboard)
			{
				speed = Runspeed;
				if (speed <= maxSpeed && moving)
				{
					Runspeed += acceleration;
				}
				self.SetBool("dash", value: true);
			}
			else
			{
				speed = speedOG;
				Runspeed = RunspeedOG;
				self.SetBool("dash", value: false);
			}
			if (player.GetButton("FastForward"))
			{
				strafe = true;
			}
			else
			{
				strafe = false;
			}
			if (!moving)
			{
				Runspeed = RunspeedOG;
			}
			if (movement.y > 0.01f && Mathf.Abs(movement.y) > Mathf.Abs(movement.x))
			{
				self.SetInteger("Direction", 1);
				moving = true;
			}
			else if (movement.y < -0.01f && Mathf.Abs(movement.y) > Mathf.Abs(movement.x))
			{
				self.SetInteger("Direction", 2);
				moving = true;
			}
			else if (movement.x < -0.01f && Mathf.Abs(movement.x) > Mathf.Abs(movement.y))
			{
				self.SetInteger("Direction", 3);
				moving = true;
			}
			else if (movement.x > 0.01f && Mathf.Abs(movement.x) > Mathf.Abs(movement.y))
			{
				self.SetInteger("Direction", 4);
				moving = true;
			}
			else if ((double)Mathf.Abs(movement.x) < 0.01 && (double)Mathf.Abs(movement.y) < 0.01)
			{
				moving = false;
			}
		}
		else
		{
			speed = 0f;
		}
	}

	private void FixedUpdate()
	{
		rb2d.MovePosition(rb2d.position + movement * speed * Time.fixedDeltaTime);
		if (!ObjectText.amorgos)
		{
			canMove = true;
		}
		else
		{
			canMove = false;
			speed = 0f;
			self.SetFloat("Speed", 0f);
			self.SetTrigger("Stop");
		}
		if (Stopper.activeInHierarchy)
		{
			canMove = false;
			moving = false;
			Stop();
			speed = 0f;
			self.SetFloat("Speed", 0f);
		}
	}

	private void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "FCAM")
		{
			FollowCam();
		}
		if (coll.gameObject.tag == "SCAM")
		{
			StillCam();
		}
		if (coll.gameObject.tag == "OWEvent")
		{
			Stop();
			NoAnims = true;
		}
	}

	public void Stop()
	{
		canMove = false;
		moving = false;
		Stopper.SetActive(value: true);
		if (!NotifTime)
		{
			self.SetTrigger("Stop");
		}
	}

	public void NotifTimeOn()
	{
		NotifTime = true;
	}

	public void NotifTimeGone()
	{
		NotifTime = false;
	}
}
