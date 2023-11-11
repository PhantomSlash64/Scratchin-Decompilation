namespace UnityEngine.VFX.Utility
{
	[RequireComponent(typeof(Collider))]
	internal class VFXMouseEventBinder : VFXEventBinderBase
	{
		public enum Activation
		{
			OnMouseUp = 0,
			OnMouseDown = 1,
			OnMouseEnter = 2,
			OnMouseExit = 3,
			OnMouseOver = 4,
			OnMouseDrag = 5
		}

		public Activation activation = Activation.OnMouseDown;

		private ExposedProperty position = "position";

		[Tooltip("Computes intersection in world space and sets it to the position EventAttribute")]
		public bool RaycastMousePosition;

		protected override void SetEventAttribute(object[] parameters)
		{
			if (RaycastMousePosition)
			{
				Ray ray = Camera.main.ScreenPointToRay(GetMousePosition());
				if (GetComponent<Collider>().Raycast(ray, out var hitInfo, float.MaxValue))
				{
					eventAttribute.SetVector3(position, hitInfo.point);
				}
			}
		}

		private static Vector2 GetMousePosition()
		{
			return Input.mousePosition;
		}

		private void DoOnMouseDown()
		{
			if (activation == Activation.OnMouseDown)
			{
				SendEventToVisualEffect();
			}
		}

		private void DoOnMouseUp()
		{
			if (activation == Activation.OnMouseUp)
			{
				SendEventToVisualEffect();
			}
		}

		private void DoOnMouseDrag()
		{
			if (activation == Activation.OnMouseDrag)
			{
				SendEventToVisualEffect();
			}
		}

		private void DoOnMouseOver()
		{
			if (activation == Activation.OnMouseOver)
			{
				SendEventToVisualEffect();
			}
		}

		private void DoOnMouseEnter()
		{
			if (activation == Activation.OnMouseEnter)
			{
				SendEventToVisualEffect();
			}
		}

		private void DoOnMouseExit()
		{
			if (activation == Activation.OnMouseExit)
			{
				SendEventToVisualEffect();
			}
		}

		private void OnMouseDown()
		{
			DoOnMouseDown();
		}

		private void OnMouseUp()
		{
			DoOnMouseUp();
		}

		private void OnMouseDrag()
		{
			DoOnMouseDrag();
		}

		private void OnMouseOver()
		{
			DoOnMouseOver();
		}

		private void OnMouseEnter()
		{
			DoOnMouseEnter();
		}

		private void OnMouseExit()
		{
			DoOnMouseExit();
		}
	}
}
