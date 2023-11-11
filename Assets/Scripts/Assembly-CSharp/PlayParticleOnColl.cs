using UnityEngine;

public class PlayParticleOnColl : MonoBehaviour
{
	public ParticleSystem part;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnTriggerEnter2D(Collider2D coll)
	{
		part.Play();
	}

	private void OnTriggerExit2D(Collider2D coll)
	{
		part.Stop();
	}
}
