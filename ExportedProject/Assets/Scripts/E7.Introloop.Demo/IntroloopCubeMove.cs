using UnityEngine;

public class IntroloopCubeMove : MonoBehaviour
{
	public float moveSpeed;

	private bool forward;

	private bool backward;

	private bool left;

	private bool right;

	public void Forward()
	{
		forward = true;
	}

	public void ForwardUp()
	{
		forward = false;
	}

	public void Backward()
	{
		backward = true;
	}

	public void BackwardUp()
	{
		backward = false;
	}

	public void Left()
	{
		left = true;
	}

	public void LeftUp()
	{
		left = false;
	}

	public void Right()
	{
		right = true;
	}

	public void RightUp()
	{
		right = false;
	}

	public void Update()
	{
		Vector3 position = base.transform.position;
		if (forward)
		{
			position.z += moveSpeed;
		}
		if (backward)
		{
			position.z -= moveSpeed;
		}
		if (left)
		{
			position.x -= moveSpeed;
		}
		if (right)
		{
			position.x += moveSpeed;
		}
		base.transform.position = position;
	}
}
