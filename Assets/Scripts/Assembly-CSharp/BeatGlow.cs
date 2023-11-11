using UnityEngine;

public class BeatGlow : MonoBehaviour
{
	private Animator self;

	private void Start()
	{
		self = base.gameObject.GetComponent<Animator>();
	}

	private void Update()
	{
	}

	public void OnTriggerEnter2D(Collider2D coll)
	{
		if (coll.gameObject.tag == "Player" || coll.gameObject.tag == "Mentor")
		{
			self.SetTrigger("Go");
		}
	}
}
